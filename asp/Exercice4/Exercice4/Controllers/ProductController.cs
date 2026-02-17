using Exercice4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    public class ProductController : Controller
    {
        private object _products;
        private object _product;

        IProductService ProductService { get; set; }
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }
        public IActionResult AfficherProduct(int ID)
        {
            Product p = ProductService.RecupererProduct(ID);

            return View(p);
        }


        
    }

      
    }

