using Domain.Entities.Users;

namespace Domain.Entities.Comments
{
    public enum EntityType
    {
        User,
        Client,
        Product,
        Order,
        Category
    }
    public class Comment: ExtendedEntity
    {
        public Comment()
        {
        }

        public User Author { get; set; }
        public string Text { get; set; }

        public EntityType EntityType { get; set; }
        public override string ToString()
        {
            return Author != null ? string.Format("\"{0}\", {1}", Text, Date.ToShortDateString()) : string.Format("\"{0}\", {1} {2}", Text, Date.ToShortDateString(), Author);
        }
    }

}
