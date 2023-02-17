using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/shop/[action]")]
    [ApiController]
    public class ShopApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ShopApiController(ApplicationDbContext context)
        {
            _db = context;
        }
        public List<ShopModel> GetAllHouse()
        {
            return _db.Estates.Include(x => x.Equipment).Include(x => x.Conditions)
                .Include(x => x.RoomType).Include(x => x.EstateImage).Select(x => new ShopModel
                {
                    Car = x.Car,
                    Bathroom = x.bathroom,
                    Address = x.Address,
                    City = x.City,
                    District = x.District,
                    Floor = x.Floor,
                    Hall = x.hall,
                    Id = x.Id,
                    Lease = x.Lease,
                    Message = x.message,
                    Meters = x.Meters,
                    Miscellaneous = x.Miscellaneous,
                    Motorcycle = x.Motorcycle,
                    Price = x.Price,
                    Room = x.Room,
                    RoomTypeId = x.RoomTypeId,
                    Tittle = x.Tittle,
                    EquipmentName = x.Equipment.Select(x => x.Name).ToList(),
                    Conditions = x.Conditions.Select(x => x.Name).ToList(),
                    RoomType = x.RoomType.Name,
                    EstateImage = x.EstateImage.Select(x => x.ImagePath).ToList()
                }).ToList();
        }
    }
}
