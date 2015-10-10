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

        public string Text { get; set; }

        public EntityType EntityType { get; set; }
    }
}
