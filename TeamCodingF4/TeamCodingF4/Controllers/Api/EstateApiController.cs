using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    public class EstateApiController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public EstateApiController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
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
                RoomTypeId = estateModel.RoomTypeId,
                City = estateModel.City,
                District = estateModel.District,
                Address = estateModel.Address,
                Floor = estateModel.Floor,
                Price = estateModel.Price,
                Miscellaneous = estateModel.Miscellaneous,
                Meters = estateModel.Meters,
                Car = estateModel.Car,
                Motorcycle = estateModel.Motorcycle,
                Lease = estateModel.Lease,
                Conditions = new List<Condition>(),
                message = estateModel.message,
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
            var ee = estateModel.EquipmentId;
            foreach (var Equiment in ee)
            {
                insertData.Equipment.Add(new Equipment()
                {

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



        //public async Task<IActionResult> Detail(int id, EstateDetailModel estateDetailModel)
        //{
        //    var EstateDetail = _context.Estates.Where(emp => emp.Id == id).Select(emp => new EstateDetailModel
        //    {
        //        Id = emp.Id,
        //        Tittle = emp.Tittle,
        //        RoomTypeId = emp.RoomTypeId,
        //        City = emp.City,
        //        District = emp.District,
        //        Address = emp.Address,
        //        Floor = emp.Floor,
        //        Price = emp.Price,
        //        Miscellaneous = emp.Miscellaneous,
        //        Meters = emp.Meters,
        //        Car = emp.Car,
        //        Motorcycle = emp.Motorcycle,
        //        Lease = emp.Lease,
        //    }).ToList();

        //    if (EstateDetail == null)
        //    {
        //        return null;
        //    }

        //    return View(EstateDetail);
        //}
    }
}