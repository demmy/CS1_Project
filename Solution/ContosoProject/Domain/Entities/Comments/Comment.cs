using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Comments
{
    public class Comment: ExtendedEntity
    {
        private string _text;
        private EntityType _entityType;

        public Comment(string text, EntityType entityType)
        {
            _text = text;
            _entityType = entityType;
        }

        public string Text
        {
            get
            {
                return _text;
            }
        }

        public EntityType EntityType
        {
            get
            {
                return _entityType;
            }
        }
    }
}
