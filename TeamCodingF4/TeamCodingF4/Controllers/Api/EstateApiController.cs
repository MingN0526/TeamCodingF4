using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return _context.Estates.Select(x => new EstateIndexModel
            {
                Id = x.Id,
                Tittle = x.Tittle,
                RoomType = x.RoomType.Name,
                Price = x.Price,
                Miscellaneous = x.Miscellaneous,
                Meters = x.Meters,
            }).ToList();
        }

        [HttpPost]
        public IActionResult Create(EstateCreateModel estateModel)
        {
            var Data = new Estate()
            {
                Tittle = estateModel.Tittle,
                RoomTypeId = estateModel.RoomTypeId,
                Room = estateModel.Room,
                hall = estateModel.hall,
                bathroom = estateModel.bathroom,
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
            };
            if(estateModel.ConditionId != null)
            {
                Data.Conditions = _context.Conditions.Where(x => estateModel.ConditionId.Contains(x.Id)).ToList();
            };
            if (estateModel.EquipmentId != null)
            {
                Data.Equipment = _context.Equipments.Where(x => estateModel.EquipmentId.Contains(x.Id)).ToList();
            };
            var root = _environment.WebRootPath;
            var ep = estateModel.EstateImages;
            if (ep != null)
            {
                var pictureList = new List<EstateImage>();
                foreach (var picture in ep)
                {
                    var path = $@"\Picture\{DateTime.Now.Ticks}-{picture.FileName}";
                    using (var stream = new FileStream($@"{root}{path}", FileMode.Create))
                    {
                        picture.CopyTo(stream);
                    }
                    pictureList.Add(new EstateImage() { ImagePath = path });

                }
                Data.EstateImage = pictureList;
            }
            _context.Estates.Add(Data);
            _context.SaveChanges();

            return RedirectToAction("Index", "Estate");
        }

        public List<EstateDetailModel> Detail(int id)
        {
            return _context.Estates
               .Include(x => x.Conditions).Include(x => x.Equipment).Include(x => x.EstateImage).Include(x => x.RoomType)
               .Where(x => x.Id == id).Select(x => new EstateDetailModel
               {
                   Id = x.Id,
                   Tittle = x.Tittle,
                   Room = x.Room,
                   hall = x.hall,
                   bathroom = x.bathroom,
                   City = x.City,
                   District = x.District,
                   Address = x.Address,
                   Floor = x.Floor,
                   Price = x.Price,
                   Meters = x.Meters,
                   Miscellaneous = x.Miscellaneous,
                   Car = x.Car,
                   Motorcycle = x.Motorcycle,
                   Lease = x.Lease,
                   message = x.message,
                   RoomType = x.RoomType.Name,
                   Conditions = x.Conditions.Select(x => x.Name).ToList(),
                   Equipment = x.Equipment.Select(x => x.Name).ToList(),
                   EstateImage = x.EstateImage.Select(x => x.ImagePath).ToList(),
               }).ToList() ;
        }

        [HttpPost]
        public void Delete([FromBody] int id)
        {
            var img = _context.EstateImages.Where(x => x.EstateId == id).ToList();
            _context.EstateImages.RemoveRange(img);

            Estate estate = _context.Estates.Find(id);
            if (estate.Conditions != null)
            {
                var conditions = new List<Condition>();
                conditions.AddRange(estate.Conditions.Select(x => x));
                foreach (var condition in conditions)
                {
                    estate.Conditions.Remove(condition);
                }
            }
            if (estate.Equipment != null)
            {
                var equipments = new List<Equipment>();
                equipments.AddRange(estate.Equipment.Select(x => x));
                foreach (var equipment in equipments)
                {
                    estate.Equipment.Remove(equipment);
                }
            }
            _context.Estates.Remove(estate);
            _context.SaveChanges();
        }


        public List<EstateEditModel> Edit(int id)
        {
            return _context.Estates
                .Include(x => x.Conditions).Include(x => x.Equipment).Include(x => x.EstateImage).Include(x => x.RoomType)
                .Where(x => x.Id == id).Select(x => new EstateEditModel
                {
                    Id = x.Id,
                    Tittle = x.Tittle,
                    Room = x.Room,
                    hall = x.hall,
                    bathroom = x.bathroom,
                    City = x.City,
                    District = x.District,
                    Address = x.Address,
                    Floor = x.Floor,
                    Price = x.Price,
                    Meters = x.Meters,
                    Miscellaneous = x.Miscellaneous,
                    Car = x.Car,
                    Motorcycle = x.Motorcycle,
                    Lease = x.Lease,
                    message = x.message,
                    RoomType = x.RoomType.Name,
                    Conditions = x.Conditions.Select(x => x.Name).ToList(),
                    Equipment = x.Equipment.Select(x => x.Name).ToList(),
                    EstateImage = x.EstateImage.Select(x => x.ImagePath).ToList(),
                }).ToList();
        }
    } 
}