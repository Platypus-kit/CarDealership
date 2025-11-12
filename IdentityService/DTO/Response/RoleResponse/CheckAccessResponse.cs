using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Response.RoleResponse
{
    public record CheckAccessResponse(Permission UserPermission);
}
