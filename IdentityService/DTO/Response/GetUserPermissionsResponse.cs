using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record GetUserPermissionsResponse(List<Permission> UserPermissions);
}
