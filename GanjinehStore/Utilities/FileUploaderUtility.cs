using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GanjinehStore.Utilities
{
    public static class FileUploaderUtility
    {
        public static string UploadFile(IFormFile file, string directoryName) 
        {
            if (file != null)
            {
                string imageName = TextUtility.CodeGenerator() + Path.GetExtension(file.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\img\\{directoryName}", imageName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return imageName;
            }

            return "default.jpg";
        }

        public static async Task<string> UploadFileAsync(IFormFile file, string directoryName)
        {
            if (file != null)
            {
                string imageName = TextUtility.CodeGenerator() + Path.GetExtension(file.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\images\\{directoryName}", imageName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                return imageName;
            }

            return "default.jpg";
        }

        public static string UpdateUploadedFile(string fileName, IFormFile file, string directoryName)
        {
            if (fileName != "default.jpg")
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\images\\{directoryName}\\{fileName}");

                File.Delete(path);
            }

            return UploadFile(file, directoryName);
        }

        public static async Task<string> UpdateUploadedFileAsync(string fileName, IFormFile file, string directoryName)
        {
            if (fileName != "default.jpg")
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\images\\{directoryName}\\{fileName}");

                File.Delete(path);
            }

            return await UploadFileAsync(file, directoryName);
        }

        public static void RemoveImages(List<string> oldProductImages, string directoryName)
        {
            string path = string.Empty;

            if (oldProductImages != null)
            {
                foreach (var image in oldProductImages)
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\images\\{directoryName}\\" + image);

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
            }
        }
    }
}
