# ASP.NET CORE 7.0 API VERSIONING

### Table of Contents

- [About Project](#about-project)
- [Main Features](#main-features)
- [3rd Party Libraries](#3rd-party-libraries)
- [API Endpoints](#api-endpoints)
- [Credits](#credits)

### About Project

- This is an Asp.Net Core MVC API versioning example. "GetProducts" method call product datas from ProductDataService.


### Main Features

- There are 2 models as "ProductViewModelv1 and ProductViewModelv2" in Models.
- There is a "ProductDataService" that contains product datas. 
- There are 2 method as GetProductsv1 and GetProductsv2 in ProductDataService. 
- There are 2 Controller as "ProductController" in v1 and v2 folder.
- Get method expects a string value for api version like 1.0 or 2.0.

### API Endpoints
| API            | HTTP Verbs | Endpoints                                | Action        |
| -------------- | ---------- | ---------------------------------------- | ------------- |
| My API 1.0     | GET        | api/v{version:apiVersion}/[controller]   | GetProducts   |
| My API 2.0     | GET        | api/v{version:apiVersion}/[controller]   | GetProducts   |

### 3rd Party Libraries

The following libraries are used in the application:

- Microsoft.AspNetCore.Mvc.Versioning
- Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
- Microsoft.AspNetCore.OpenApi
- Swashbuckle.AspNetCore

### Credits

Deniz Demirdöven

- [Github](https://github.com/DenizDemirdoven)
- [LinkedIn](https://www.linkedin.com/in/denizdemirdoven)
- [Email](mailto:denizdemirdoven@gmail.com)
- [Web](https://www.denizdemirdoven.com/)