using IdentityService.DTO.Request.RoleRequest;
using IdentityService.DTO.Response.RoleResponse;

namespace IdentityService.Interfaces
{
    public interface IRoleService //методы для управления ролями и правами
    {
        //**Управление ролями пользователей:**
        Task<AssignRoleResponse> AssignRoleToUserAsync(AssignRoleRequest assignRoleRequest); //- назначение роли пользователю +

        Task<RemoveRoleFromUserResponse> RemoveRoleFromUserAsync(RemoveRoleFromUserRequest removeRoleFromUserRequest); //- удаление роли у пользователя +

        Task<GetUserRolesResponse> GetUserRolesAsync(GetUserRolesRequest getUserRolesRequest); //- получение ролей пользователя +

        Task<UserHasRoleResponse> UserHasRoleAsync(UserHasRoleRequest userHasRoleRequest); //- проверка наличия роли у пользователя +

        //** Права доступа:**
        Task<UserHasPermissionResponse> UserHasPermissionAsync(UserHasPermissionRequest userHasPermissionRequest); //- проверка права доступа у пользователя +

        Task<GetUserPermissionsResponse> GetUserPermissionsAsync(GetUserPermissionsRequest getUserPermissionsRequest); //- получение всех прав пользователя +

        Task<CheckAccessResponse> CheckAccessAsync(CheckAccessRequest checkAccessRequest); //- проверка доступа к ресурсу +

        //**Управление ролями:**

        Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest createRoleRequest); //- создание новой роли +

        Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest updateRoleRequest); //- обновление роли +

        Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest deleteRoleRequest); //- удаление роли +

        Task<GetAllRolesResponse> GetAllRolesAsync(); //- получение всех ролей +

        Task<GetRoleByIdResponse> GetRoleByIdAsync(GetRoleByIdRequest getRoleByIdRequest); //- получение роли по ID +


        //**Управление правами:**

        Task<AddPermissionToRoleResponse> AddPermissionToRoleAsync(AddPermissionToRoleRequest addPermissionToRoleRequest); //- добавление права к роли +

        Task<RemovePermissionFromRoleResponse> RemovePermissionFromRoleAsync(RemovePermissionFromRoleRequest removePermissionFromRoleRequest); //- удаление права из роли +

        Task<GetRolePermissionsResponse> GetRolePermissionsAsync(GetRolePermissionsRequest getRolePermissionsRequest); //- получение прав роли +

        Task<GetAllPermissionsResponse> GetAllPermissionsAsync(GetAllPermissionsRequest getAllPermissionsRequest); //- получение всех доступных прав +

        //**Валидация:**

        Task<ValidateRoleExistsResponse> ValidateRoleExistsAsync(ValidateRoleExistsRequest validateRoleExistseRequest); //- проверка существования роли +

        Task<ValidatePermissionExistsResponse> ValidatePermissionExistsAsync(ValidatePermissionExistsRequest validatePermissionExistsRequest); //- проверка существования права +

        Task<CanDeleteRoleResponse> CanDeleteRoleAsync(CanDeleteRoleRequest canDeleteRoleRequest); //- проверка возможности удаления роли +
    }
}