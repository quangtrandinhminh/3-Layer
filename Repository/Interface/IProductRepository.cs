using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Objects;
using Repository.IBase;
using Repository.Infrastructure;

namespace Repository.Interface
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
