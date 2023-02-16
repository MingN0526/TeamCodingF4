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
        public List<HouseDetailModel> GetAllHouseDetail()
        {
            //var eq = _db.Estates.Include(e => e.Equipment).Select( e => e.Equipment);
            return _db.Estates.Select(x => new HouseDetailModel
            {
                Address = x.Address,
                City = x.City,
                EstateImage = x.EstateImage,
                bathroom = x.bathroom,
                Car = x.Car,
                Conditions = x.Conditions,
                District = x.District,
                Equipment = x.Equipment,
                Floor = x.Floor,
                hall = x.hall,
                Id = x.Id,
                Lease = x.Lease,
                message = x.message,
                Meters = x.Meters,
                Miscellaneous = x.Miscellaneous,
                Motorcycle = x.Motorcycle,
                Price = x.Price,
                Room = x.Room,
                RoomType = x.RoomType,
                RoomTypeId = x.RoomTypeId,
                Tittle = x.Tittle,
            }).ToList();
        }
        [HttpGet("{id}")]
        public IActionResult GetHouseDetailById(int id)
        {
            var data = _db.Estates.Include(x => x.Equipment).Include(x => x.Conditions).Include(x => x.EstateImage).FirstOrDefault(x => x.Id == id);

            if (data == null)
            {
                return null;
            }

            var model = new HouseDetailModel
            {
               Id= id,
               Address= data.Address,
               bathroom= data.bathroom,
               Car = data.Car,
               City= data.City,
               Conditions= data.Conditions,
               District= data.District,
               Equipment= data.Equipment,
               EstateImage= data.EstateImage,
               EstateVideoPath= data.EstateVideoPath,
               Floor= data.Floor,
               hall= data.hall,
               Lease = data.Lease,
               message= data.message,
               Meters = data.Meters,
               Miscellaneous= data.Miscellaneous,
               Motorcycle= data.Motorcycle,
               Price= data.Price,
               Room= data.Room,
               RoomType= data.RoomType,
               RoomTypeId= data.RoomTypeId,
               Tittle= data.Tittle,
            };
            return Ok(model);
        }
    }
}
