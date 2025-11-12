using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record GetRolePermissionsResponse(List<string> Names);
}
