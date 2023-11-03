using HuzlabBlog.Entities.DTOs.Users;
using HuzlabBlog.Entities.Entities;
using Microsoft.AspNetCore.Identity;

namespace HuzlabBlog.Service.Services.Abstractions
{
    public interface IUserService
    {
		Task<List<UserDto>> GetAllUsersWithRoleAsync();
		Task<List<AppRole>> GetAllRolesAsync();
		Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto);
		Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto);
		Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(Guid userId);
		Task<AppUser> GetAppUserByIdAsync(Guid userId);
		Task<string> GetUserRoleAsync(AppUser user);
		Task<UserProfileDto> GetUserProfileAsync();
		Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto);
	}
}
