using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NgocShop.Web.Models
{
    public class TagViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}