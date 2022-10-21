using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Best_Buy_db
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        
    }
}
