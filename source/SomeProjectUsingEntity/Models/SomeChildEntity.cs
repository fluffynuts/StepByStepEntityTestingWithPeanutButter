namespace SomeProjectUsingEntity.Models
{
    public class SomeChildEntity
    {
        public int Id { get; set; }
        public int SomeEntityId { get; set; }
        public string Name { get; set; }

        public virtual SomeEntity SomeEntity { get; set; }
    }
}
