using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers
{
    public class EstateController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public EstateController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }


        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Estates == null)
        //    {
        //        return NotFound();
        //    }

        //    var estateModel = await _context.Estates
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (estateModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(estateModel);
        //}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EstateCreateModel estateModel)
        {
            var ep = estateModel.EstateImages;
            var ev = estateModel.EstateVideo;
            if (ep == null && ev == null)
            {
                return BadRequest("沒圖片/影片");
            }

            var insertData = new Estate()
            {
                Tittle = estateModel.Tittle,
                Car = estateModel.Car,
                District = estateModel.District,
                City = estateModel.City,
                EstateImage = new List<EstateImage>(),
                Address = estateModel.Address,
                Conditions = new List<Condition>(),
                Floor = estateModel.Floor,
                Lease = estateModel.Lease,
                Meters = estateModel.Meters,
                Price = estateModel.Price,
                Motorcycle = estateModel.Motorcycle,
                Miscellaneous = estateModel.Miscellaneous,
                message = estateModel.message,
                RoomTypeId = estateModel.RoomTypeId,
            };

            var root = _environment.WebRootPath;
            foreach (var picture in ep)
            {
                var pictureName = DateTime.Now.Ticks + picture.FileName;
                var picturepath = $@"{root}\Picture\{pictureName}";
                picture.CopyTo(System.IO.File.Create(picturepath));
                insertData.EstateImage.Add(new EstateImage()
                {                    
                    ImagePath = $@"\Picture\{pictureName}"
                });
            }
            var videoName = DateTime.Now.Ticks + ev.FileName;
            var videopath = $@"{root}\Video\{videoName}";
            ev.CopyTo(System.IO.File.Create(videopath));
            insertData.EstateVideoPath = $@"\Video\{videoName}";

            _context.Estates.Add(insertData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Estates == null)
        //    {
        //        return NotFound();
        //    }

        //    var estateCreateModel = await _context.Estates.FindAsync(id);
        //    if (estateCreateModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(estateCreateModel);
        //}

        
    }
}
