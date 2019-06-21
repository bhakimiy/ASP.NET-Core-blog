using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.FileManager
{
    public interface IFileManager
    {
        FileStream ImageStream(string imageName);
        Task<string> SaveImageAsync(IFormFile image);
    }
}
