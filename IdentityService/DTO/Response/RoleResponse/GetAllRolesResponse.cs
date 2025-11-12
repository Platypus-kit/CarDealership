using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Response.RoleResponse
{
    public record GetAllRolesResponse(List<Role> ListRole);
}
