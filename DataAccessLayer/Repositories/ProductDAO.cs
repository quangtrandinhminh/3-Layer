using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Objects;
using Repository.Base;
using Repository.Interface;

namespace Repository.Repositories
{
    public class ProductDAO : BaseRepository<Product>, IProductRepository
    {
    }
}
