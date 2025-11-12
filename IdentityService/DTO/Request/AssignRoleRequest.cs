using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record AssignRoleRequest(Guid UserId, Role UserRole);
}
