using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Response.RoleResponse
{
    public record GetUserPermissionsResponse(List<Permission> UserPermissions);
}
