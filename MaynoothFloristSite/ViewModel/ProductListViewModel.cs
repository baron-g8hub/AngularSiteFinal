using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFlorist.DataAccessLayer;

namespace MaynoothFloristSite.ViewModel
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Items { get; set; }
    }
}