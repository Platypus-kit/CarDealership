using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request.RoleRequest
{
    public record AssignRoleRequest(Guid UserId, Role UserRole);
}
