using AutoMapper;
using HuzlabBlog.Entities.DTOs.Users;
using HuzlabBlog.Entities.Entities;

namespace HuzlabBlog.Service.AutoMapper.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
			CreateMap<AppUser, UserDto>().ReverseMap();
			CreateMap<AppUser, UserAddDto>().ReverseMap();
			CreateMap<AppUser, UserUpdateDto>().ReverseMap();
			CreateMap<AppUser, UserProfileDto>().ReverseMap();

		}
	}
}
