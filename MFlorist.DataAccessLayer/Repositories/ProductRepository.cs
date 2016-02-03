
using MFlorist.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFlorist.DataAccessLayer.Repositories 
{
    public class ProductRepository : IProductRepository
    {
        private FlowersdbEntities context;

        #region Constructors

        public ProductRepository(FlowersdbEntities context)
        {
            this.context = context;
        }

        #endregion Constructors

        #region Methods

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        #endregion
    }
}
