using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.Models
{
    public class Upload
    {//Bir file dosyasını alabilmek için, kendi işimize yarayan bir işlem.
        public string ImageUpload(List<IFormFile> files, IWebHostEnvironment environment,
            out bool imgResult)
        {
            //Resim yükleme işlemler,
            //Geriye hata yada resim yolunu dönebilirim
            imgResult = false;
            var uploads = Path.Combine(environment.WebRootPath, "uploads");

            foreach (var file in files)
            {
                if (file.ContentType.Contains("image"))
                {
                    if (file.Length <= 2097152)//Dosyaboyutu. Vermek zorundayız yoksa saldırı olabilir. 2mb a denktir bu.
                    {
                        string uniqueName = $"{Guid.NewGuid().ToString().Replace("-", "_").ToLower()}" +
                            $".{file.ContentType.Split('/')[1]}";
                        var filePath = Path.Combine(uploads, uniqueName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                            imgResult = true;
                            return filePath.Substring(filePath.IndexOf("\\uploads\\"));
                        }
                    }
                    else
                    {
                        return $"2 MB'dan büyük resim yükleyemezsiniz.";
                    }
                }
                else
                {
                    return $"Lütfen sadece resim dosyası yükleyin.";
                }
            }
            return "Dosya bulunamadı! Lütfen en az bir dosya seçin.";
        }
    }
}
