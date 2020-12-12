# BargainFetcherWebAPI

This API decouples the BargainFetcherCrawler and the soon to be created BargainFetcherWebsite project. With the help of this API I can POST what I crawled, and GET the info to use on my website

Endpoint structure:  
GET all  
http://bargainfetcherwebapi.azurewebsites.net/api/products  
GET certain  
http://bargainfetcherwebapi.azurewebsites.net/api/products/1  
POST  
http://bargainfetcherwebapi.azurewebsites.net/api/products  
the object is in the body  

No authorization is provided for now.
