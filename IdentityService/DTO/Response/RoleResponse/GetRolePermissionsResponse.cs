using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Response.RoleResponse
{
    public record GetRolePermissionsResponse(List<string> Names);
}
