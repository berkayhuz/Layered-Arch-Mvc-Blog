using HuzlabBlog.Entities.DTOs.Images;
using HuzlabBlog.Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HuzlabBlog.Service.Helpers.Images
{
	public interface IImageHelper
	{
		Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string folderName = null);
		void Delete(string imageName);
	}
}
