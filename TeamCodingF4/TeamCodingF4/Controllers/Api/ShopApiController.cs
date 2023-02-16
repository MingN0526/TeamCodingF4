using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
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
            //var eq = _db.Estates.Include(e => e.Equipment).Select( e => e.Equipment);
            return _db.Estates.Select(x => new ShopModel
            {
                Address= x.Address,
                City= x.City,
                EstateImage= x.EstateImage,
                bathroom= x.bathroom,
                Car = x.Car,
                Conditions= x.Conditions,
                District= x.District,
                Equipment= x.Equipment,
                Floor = x.Floor,
                hall= x.hall,
                Id= x.Id,
                Lease= x.Lease,
                message= x.message,
                Meters= x.Meters,
                Miscellaneous = x.Miscellaneous,
                Motorcycle= x.Motorcycle,
                Price= x.Price,
                Room= x.Room,
                RoomType= x.RoomType,
                RoomTypeId= x.RoomTypeId,
                Tittle= x.Tittle,
            }).ToList();




        }
    }
}
