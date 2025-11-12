using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record AddPermissionToRoleRequest(Guid RoleId, string NewName);
}