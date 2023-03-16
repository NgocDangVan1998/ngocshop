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
using System.Linq;

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
        public HttpResponseMessage GetAll(HttpRequestMessage request,string keyword, int page, int pageSize)
        {
            return createHttpResponse(request, () =>
            {
                int totalSize = 0;
                var listProductCategory = _productCategoryService.GetAll(keyword);

                var totalRow = listProductCategory.Count();

                var query = listProductCategory.OrderByDescending(x => x.CreatedDate).Skip(page * pageSize).Take(pageSize);

                var responseData = Mapper.Map<IEnumerable<ProductCategory>,IEnumerable<ProductCategoryViewModel>>(query);

                var paginationSet = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = responseData,
                    Page = page,
                    TotalCount = totalRow,
                    TotalPages = (int)Math.Ceiling((decimal)totalRow/pageSize)
                };

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, paginationSet);
                return response;
            });
        }
    }
}
