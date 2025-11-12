namespace IdentityService.DTO.Request.RoleRequest
{
    public record RemovePermissionFromRoleRequest(Guid RoleId, string NewName);
}
