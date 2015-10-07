using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Product : ExtendedEntity, ICommentable
    {
        private int Quantity { get; set; }
        public double Price { get; set; }
        public string SKU;
        public Category Category { get; set; }
        
        public static ExtendedEntity entityID;
        public static User user;

        public Product(string SKU)
            : base(entityID.GetNewID, false, user.GetCurrentUser, DateTime.Now)
        {
            this.SKU = SKU;
            Quantity = 0;
            Price = 0.0;
        }

        public Product(string SKU, Category category)
            : base(entityID.GetNewID, false, user.GetCurrentUser, DateTime.Now)
        {
            this.SKU = SKU;
            Quantity = 0;
            Price = 0.0;
            Category = category;
        }


        public IReadOnlyList<Comment> Comments
        {
            get { throw new NotImplementedException(); }
        }
    }
}
