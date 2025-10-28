using CustomerService.Entities;

namespace CustomerService
{
    public class CustomerRequest
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
