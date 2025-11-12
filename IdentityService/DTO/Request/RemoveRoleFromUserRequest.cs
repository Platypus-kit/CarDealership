using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record RemoveRoleFromUserRequest(Guid UserId, Role UserRole);
}
