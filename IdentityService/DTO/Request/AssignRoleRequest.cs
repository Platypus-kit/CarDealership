using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record AssignRoleRequest(Guid userId, Role userRole);
}
