namespace IdentityService.Domain.Entities
{
    public class Permission
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // product.read, order.create, user.manage
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}