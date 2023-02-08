using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Collections.Generic;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("Api/EstateApi/[action]")]
    public class EstateApiController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public EstateApiController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        public List<EstateIndexModel> Index()
        {
            var data = _context.Estates.Select(x => new EstateIndexModel
            {
               Id = x.Id,
               Tittle=x.Tittle,
               RoomType=x.RoomType.Name,
               Price=x.Price,
               Miscellaneous=x.Miscellaneous,
            }).ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Create(EstateCreateModel estateModel)
        {
            var Data = new Estate()
            {
                Tittle = estateModel.Tittle,
                RoomTypeId = estateModel.RoomTypeId,
                Room = estateModel.Room,
                hall=estateModel.hall,
                bathroom=estateModel.bathroom,
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
                message = estateModel.message,
                Conditions=_context.Conditions.Where(x=>estateModel.ConditionId.Contains(x.Id)).ToList(),
                Equipment= _context.Equipments.Where(x => estateModel.EquipmentId.Contains(x.Id)).ToList(),
            };


            var root = _environment.WebRootPath;
            var ev = estateModel.EstateVideo;
            if (ev != null)
            {
                var videoName = DateTime.Now.Ticks + ev.FileName;
                var videopath = $@"{root}\Video\{videoName}";
                ev.CopyTo(System.IO.File.Create(videopath));
                Data.EstateVideoPath = $@"\Video\{videoName}";
            }


            var ep = estateModel.EstateImages;
            if (ep != null)
            {
                var pictureList = new List<EstateImage>();
                foreach (var picture in ep)
                {
                    var path = $@"\Picture\{DateTime.Now.Ticks}-{picture.FileName}";
                    using (var stream = new FileStream($@"{root}{path}",FileMode.Create))
                    {
                        picture.CopyTo(stream);
                    }
                    pictureList.Add(new EstateImage() { ImagePath = path });
                   
                }
                Data.EstateImage = pictureList;
            }
           

            _context.Estates.Add(Data);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }



        //public async Task<string> Detail(int id, EstateDetailModel estateDetailModel)
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

        //    return EstateDetail.ToJson();
        //}
    }
}