using EcoAcceso.Core.Application.Dtos.Account;
using EcoAcceso.Core.Application.ViewModel.Roles;
using EcoAcceso.Core.Application.ViewModel.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {
        Task<List<UsersViewModel>> GetUsersAsync();
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<string> ConfirmAccountAsync(string userId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);
        Task<RegisterResponse> RegisterBasicUserAsync(RegisterRequest request, string origin);
        Task<RegisterResponse> UpdateUser(RegisterRequest request, string Id);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request);
        Task SignOutAsync();
        Task<List<RolesViewModel>> GetAllRoles();
        Task<RolesViewModel> GetRolByName(string roleName);
        Task<List<UsersViewModel>> GetUserByRol(string roleName);
        Task<UsersViewModel> GetUserByIdAsync(string Id);
        Task Delete(string id);
        Task Active(string id);
        Task Inactive(string id);
        Task<UsersStateByRolViewModel> GetAllUserStateByRol(string Rol);
    }
}