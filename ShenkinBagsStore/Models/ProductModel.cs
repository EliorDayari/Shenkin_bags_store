using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ShenkinBagsStore.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product {
                    ProductName = "Some name",
                    Price = 5,
                   ProductTypeId=1234,
                   Description="sdavdsv",
                   Quantity=34,
                   Metrial="blasde"

                },
                new Product {
                       ProductName = "Some nam1",
                    Price = 51,
                   ProductTypeId=12341,
                   Description="sdavdsv111",
                   Quantity=341,
                   Metrial="111blasde"

                },
                new Product {
                        ProductName = "Som2323e name",
                    Price = 523,
                   ProductTypeId=122334,
                   Description="232sdavdsv",
                   Quantity=234,
                   Metrial="2323blasde"

                }
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.ProductId.Equals(id));
        }
    }
}
