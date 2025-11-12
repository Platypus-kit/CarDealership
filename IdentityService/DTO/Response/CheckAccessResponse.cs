using IdentityService.Domain.Entities;

namespace IdentityService.DTO.Request
{
    public record CheckAccessResponse(Permission userPermission);
}
