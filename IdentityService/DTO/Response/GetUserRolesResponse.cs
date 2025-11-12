using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record GetUserRolesResponse(List<Role> UserRolesList);
}
