using System.Collections.Generic;
using AutoMapper;
using BargainFetcher.Data;
using BargainFetcher.Dtos;
using BargainFetcher.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BargainFetcher.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IBargainFetcherRepo _repository;

        public IMapper _mapper { get; }

        public ProductsController(IBargainFetcherRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // private readonly MockBargainFetcherRepo _repository = new MockBargainFetcherRepo();
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IEnumerable<ProductReadDto>> GetAllProducts()
        {
            var productItems = _repository.GetAllProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

        //GET api/products/id
        [HttpGet("{id}", Name = "GetProductById")]
        [EnableQuery()]

        public ActionResult<ProductReadDto> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);
            if (productItem != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(productItem));
            }
            return NotFound();
        }

        //POST api/products
        [HttpPost]

        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(nameof(GetProductById), new { Id = productReadDto.ProductID }, productReadDto);
            // return Ok(productReadDto);
        }

        //PUT api/products/{id}
        [HttpPut("{id}")]

        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, productModelFromRepo);

            _repository.UpdateProducts(productModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/products/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<ProductUpdateDto> patchDoc)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }

            var productToPatch = _mapper.Map<ProductUpdateDto>(productModelFromRepo);
            patchDoc.ApplyTo(productToPatch, ModelState);

            if(!TryValidateModel(productToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(productToPatch, productModelFromRepo);
            _repository.UpdateProducts(productModelFromRepo);
            
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/products/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteProduct(productModelFromRepo);
            _repository.SaveChanges();

            return NoContent();

        }
    }
}