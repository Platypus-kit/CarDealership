using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Response.RoleResponse
{
    public record GetUserRolesResponse(List<Role> UserRolesList);
}
