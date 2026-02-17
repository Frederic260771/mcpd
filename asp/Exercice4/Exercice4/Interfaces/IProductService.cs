using Exercice4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    public interface IProductService
    {
        public Product RecupererProduct(int ID);

    }
}
