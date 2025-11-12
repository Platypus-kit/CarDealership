using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request.RoleRequest
{
    public record AddPermissionToRoleRequest(Guid RoleId, string NewName);
}