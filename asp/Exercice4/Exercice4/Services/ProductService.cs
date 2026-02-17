using Exercice4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    public class ProductService : IProductService
    {
        private List<Product> _products;
        public ProductService() 
        { 
            _products = new List<Product>();
            _products.Add(new Product(1, "pc portable", "informatique", 500));
            _products.Add(new Product(2, "pc portable", "informatique", 500));
            _products.Add(new Product(3, "pc portable", "informatique", 500));
            _products.Add(new Product(4, "pc portable", "informatique", 500));
        }

        public Product RecupererProduct(int ID)
        {

            return _products.FirstOrDefault(p => p.Id == ID);
        }

      
    
    }





}
