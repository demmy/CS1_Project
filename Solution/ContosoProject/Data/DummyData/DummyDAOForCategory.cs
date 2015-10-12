using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.DummyData
{
    class DummyDAOForCategory : DummyDAOExtension<Category>, ICategoryRepository
    {
    }
}
