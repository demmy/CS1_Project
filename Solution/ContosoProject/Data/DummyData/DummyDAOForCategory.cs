using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.DummyData
{
    class DummyDAOForCategory : DummyDAOExtension<Category>, ICategoryRepository
    {
        public DummyDAOForCategory()
        {
            _collection = (IList<Category>) CategoriesCollection.Target;
        }
    }
}
