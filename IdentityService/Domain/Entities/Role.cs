namespace IdentityService.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // CLIENT, DEALER, ADMIN
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
