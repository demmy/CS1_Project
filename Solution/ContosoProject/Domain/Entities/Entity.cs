namespace Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
