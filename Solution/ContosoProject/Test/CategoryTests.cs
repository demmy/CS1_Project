using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Domain.Entities;
using Domain.Entities.Comments;

namespace Contoso.Test
{
    [TestFixture]
    class CategoryTests
    {
        [TestCase]
        void TestCategoryComments()
        {
            Comment[] comments = new Comment[10];
            Category category = new Category("Shoes",comments);
            CollectionAssert.AreEqual(category.Comments, comments);
        }        
    }
}
