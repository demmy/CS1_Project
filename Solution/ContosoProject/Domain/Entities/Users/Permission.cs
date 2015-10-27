namespace Domain.Entities.Users
{
    public class Permission : Entity
    {
        public Permission()
        {
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
    
}
