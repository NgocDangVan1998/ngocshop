using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using NgocShop.Model.Models;
using NgocShop.Web.Models;

namespace NgocShop.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}