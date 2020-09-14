using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinBagsStore.Models
{
    public class Product
    {
        

        public enum Color
        {
            Blue,
            Gold,
            Green,
            Red,
            Yellow,
            Pink,
            White,
            Black,
            Orange,
            Brown,
            Purple
        }
        public enum Gender
        {
            male,
            famale,
            unisex
        }
        
    
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public float Price { get; set; }
        [Display(Name = "Color")]
        public Color? Colorr { get; set; }
        [Display(Name = "Product Type Id")]
        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Metrial { get; set; }

        [Display(Name ="Gender")]
        public Gender? Genderr { get; set; }
      //  public string CartId { get; internal set; }
    }
}
