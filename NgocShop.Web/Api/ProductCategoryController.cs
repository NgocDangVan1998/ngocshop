using AutoMapper;
using NgocShop.Model.Models;
using NgocShop.Service;
using NgocShop.Web.Infrastructure.Core;
using NgocShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace NgocShop.Web.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        IProductCategoryService _productCategoryService;
        public ProductCategoryController(IErrorService errorService,IProductCategoryService productCategoryService)
            : base(errorService) 
        {
            _productCategoryService = productCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return createHttpResponse(request, () =>
            {
                var listProductCategory = _productCategoryService.GetAll();
                var responseData = Mapper.Map<IEnumerable<ProductCategory>,IEnumerable<ProductCategoryViewModel>>(listProductCategory);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }
    }
}
