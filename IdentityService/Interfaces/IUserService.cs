using IdentityService.DTO.Request.RoleRequest;
using IdentityService.DTO.Response.RoleResponse;

namespace IdentityService.Interfaces
{
    public interface IUserService //- методы для работы с пользователями:**
    {
        //**CRUD операции:**
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest); // - создание нового пользователя
        
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest); // - обновление данных пользователя
        
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest); // - удаление пользователя
        
        Task<GetUserByIdResponse> GetUserByIdAsync(GetUserByIdRequest getUserByIdRequest); // - получение пользователя по ID
        
        Task<GetUserByEmailResponse> GetUserByEmailAsync(GetUserByEmailRequest getUserByEmailRequest); // - получение пользователя по email
        
        Task<GetUserByUsernameResponse> GetUserByUsernameAsync(GetUserByUsernameRequest getUserByUsernameRequest); // - получение пользователя по имени пользователя

        //** Управление состоянием:**

        Task<ActivateUserResponse> ActivateUserAsync(ActivateUserRequest activateUserRequest); // - активация пользователя
        
        Task<DeactivateUserResponse> DeactivateUserAsync(DeactivateUserRequest deactivateUserRequest); // - деактивация пользователя
        
        Task<VerifyEmailResponse> VerifyEmailAsync(VerifyEmailRequest verifyEmailRequest); // - подтверждение email
        
        Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest changePasswordRequest);// - смена пароля

        //**Поиск и валидация:**

        Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest searchUsersRequest); // - поиск пользователей по критериям
        

        Task<CheckEmailExistsResponse> CheckEmailExistsAsync(CheckEmailExistsRequest checkEmailExistsRequest); // - проверка существования email
        
        Task<CheckUsernameExistsResponse> CheckUsernameExistsAsync(CheckUsernameExistsRequest checkUsernameExistsRequest); // - проверка существования имени пользователя
        
        Task<ValidateUserCredentialsResponse> ValidateUserCredentialsAsync(ValidateUserCredentialsRequest validateUserCredentialsRequest); // - валидация учетных данных

        //** Профиль:**
        
        Task<GetUserProfileResponse> GetUserProfileAsync(GetUserProfileRequest getUserProfileRequest); // - получение профиля пользователя
        
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest updateUserProfileRequest); // - обновление профиля пользователя
    }
}
