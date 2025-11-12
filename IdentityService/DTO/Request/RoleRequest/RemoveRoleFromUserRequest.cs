using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request.RoleRequest
{
    public record RemoveRoleFromUserRequest(Guid UserId, Role UserRole);
}
