using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Objects;
using Repository.IBase;

namespace Repository.Interface
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }
}
