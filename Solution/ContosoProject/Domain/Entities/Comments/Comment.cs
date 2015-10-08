using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Comments
{
    public class Comment: ExtendedEntity
    {
        public Comment()
        {
        }

        public string Text { get; set; }

        public EntityType EntityType { get; set; }
    }
}
