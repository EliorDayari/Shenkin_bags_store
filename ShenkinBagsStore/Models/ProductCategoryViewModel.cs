using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShenkinBagsStore.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product> Products { get; set; }
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Categries { get; set; }
        public string ProductCategory { get; set; }
        public string SearchString { get; set; }
    }
}
