using NgocShop.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NgocShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { get; set; }
        public string TagID { get; set; }
        public virtual PostViewModel Post { get; set; }
        public virtual TagViewModel Tag { get; set; }
    }
}