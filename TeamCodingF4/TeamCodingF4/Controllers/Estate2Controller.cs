using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers
{
    public class Estate2Controller : Controller
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext db;

        public Estate2Controller(IWebHostEnvironment environment,ApplicationDbContext db)
        {
            this.environment = environment;
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rent()
        {
            return View();
        }

        [HttpPost]
        public string Upload(IFormFile file)
        {
            if (file == null) return "要有東西";            
            if (file.Length >=1024000) return "太大了";

            if (file.ContentType == "image/png")
            {
                var root = environment.WebRootPath;
                var fileName = DateTime.Now.Ticks + file.FileName;                
                var path = $@"{root}\Upload\{fileName}";

                using (var fs = System.IO.File.Create(path))
                {
                    file.CopyTo(fs);
                }
                db.EstateImage.Add(new EstateImage()
                {
                    ImagePath = $@"\Upload\{fileName}",
                });
                db.SaveChanges();
                return "成功";
            }
            else {
                return "檔案格式錯誤";
            }
        }

        [HttpPost]
        public string Upload2(List<IFormFile> files)
        {
            if (files == null) return "要有東西";
            if (files.Sum(x=>x.Length) >= 1024000000) return "太大了";
            if (files.Any(x => x.ContentType != "image/png")) return "不接受";

            var root = environment.WebRootPath;
            foreach (var file in files)
            {
               
                var fileName = DateTime.Now.Ticks + file.FileName;
                var path = $@"{root}\Upload\{fileName}";

                using (var fs = System.IO.File.Create(path))
                {
                    file.CopyTo(fs);
                }
                db.EstateImage.Add(new EstateImage()
                {
                    ImagePath = $@"\Upload\{fileName}",
                });                
            }
            db.SaveChanges();
            return "成功";
        }

        [HttpPost]
        public ApiResult Upload3(UploadModel model)
        {
            if (model.files == null) return new ApiResult(false, "要有東西");
            if (model.files.Sum(x => x.Length) >= 1024000000) return new ApiResult(false, "太大了");
            if (model.files.Any(x => x.ContentType != "image/png")) return new ApiResult(false, "不接受");

            var root = environment.WebRootPath;
            foreach (var file in model.files)
            {

                var fileName = DateTime.Now.Ticks + file.FileName;
                var path = $@"{root}\Upload\{fileName}";

                using (var fs = System.IO.File.Create(path))
                {
                    file.CopyTo(fs);
                }
                db.EstateImage.Add(new EstateImage()
                {
                    ImagePath = $@"\Upload\{fileName}",
                });
            }
            db.SaveChanges();
            return new ApiResult(true,"新增成功");
        }
    }
}
