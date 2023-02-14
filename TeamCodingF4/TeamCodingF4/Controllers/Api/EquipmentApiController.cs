using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/equipment/[action]")]
    [ApiController]
    public class EquipmentApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public EquipmentApiController(ApplicationDbContext context)
        {
            _db = context;
        }
        public List<EquipmentModel> GetAllHouseEquipment()
        {
            return _db.Equipments.Select(x => new EquipmentModel
            {
                Estate= x.Estate,
                Id=x.Id,
                Name=x.Name,
                Picture=x.Picture
            }).ToList();
        }
    }
}
