using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record GetAllRolesResponse(List<Role> ListRole);
}
