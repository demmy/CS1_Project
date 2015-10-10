namespace Domain.Entities
{
    public abstract class Entity
    {
        protected Entity(bool isActive)
        {
            IsActive = isActive;
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
