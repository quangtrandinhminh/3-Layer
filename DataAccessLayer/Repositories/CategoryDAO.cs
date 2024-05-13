using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Objects;
using DAO.Infrastructure;
using Repository.Infrastructure;
using Repository.Interface;

namespace Repository.Repositories
{
    public class CategoryDAO : Repository<Category>, ICategoryRepository
    {
    }
}
