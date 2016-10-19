using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AdventureWorksSvc
{
    public class ProductsService : IProductsService
    {
        public Product GetProductsByCategory(string category)
        {
            throw new NotImplementedException("Not implemented.");
        }
    }
}
