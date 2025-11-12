namespace IdentityService.DTO.Request
{
    public record RemovePermissionFromRoleRequest(Guid RoleId, string NewName);
}
