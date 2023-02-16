using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/detail/[action]")]
    [ApiController]
    public class DetailApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public DetailApiController(ApplicationDbContext context)
        {
            _db = context;
        }
      
        [HttpGet("{id}")]
        public ShopDetailModel GetHouseDetailById(int id)
        {
            var data = _db.Estates.Include(x => x.EstateImage).Include(x=>x.RoomType).FirstOrDefault(x => x.Id == id);          
            if (data == null)
            {
                return null;
            }

            var model = new ShopDetailModel
            {
                Id = id,
                Address = data.Address,
                Bathroom = data.bathroom,
                Car = data.Car,
                City = data.City,
                District = data.District,
                Floor = data.Floor,
                Hall = data.hall,
                Lease = data.Lease,
                Message = data.message,
                Meters = data.Meters,
                Miscellaneous = data.Miscellaneous,
                Motorcycle = data.Motorcycle,
                Price = data.Price,
                Room = data.Room,
                RoomTypeId = data.RoomTypeId,
                Tittle = data.Tittle,
                Images = data.EstateImage.Select(x => x.ImagePath).ToList(),
                RoomTypeName = data.RoomType.Name,

        };
            return model;
        }
    }
}
