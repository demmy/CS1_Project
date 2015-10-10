namespace Domain.Entities
{
    public class User : ExtendedEntity
    {
        public User()
        {
            
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

    }
}
