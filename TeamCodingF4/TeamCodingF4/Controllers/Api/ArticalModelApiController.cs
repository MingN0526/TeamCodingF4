using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticalModelApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArticalModelApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ArticalModelApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticalModel>>> GetArticalModels()
        {
            return await _context.ArticalModel.ToListAsync();
        }

        // GET: api/ArticalModelApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArticalModel>> GetArticalModel(int id)
        {
            var articalModel = await _context.ArticalModel.FindAsync(id);

            if (articalModel == null)
            {
                return NotFound();
            }

            return articalModel;
        }

        // PUT: api/ArticalModelApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticalModel(int id, ArticalModel articalModel)
        {
            if (id != articalModel.ArticalId)
            {
                return BadRequest();
            }

            _context.Entry(articalModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticalModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ArticalModelApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArticalModel>> PostArticalModel(ArticalModel articalModel)
        {
            _context.ArticalModel.Add(articalModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticalModel", new { id = articalModel.ArticalId }, articalModel);
        }

        // DELETE: api/ArticalModelApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticalModel(int id)
        {
            var articalModel = await _context.ArticalModel.FindAsync(id);
            if (articalModel == null)
            {
                return NotFound();
            }

            _context.ArticalModel.Remove(articalModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticalModelExists(int id)
        {
            return _context.ArticalModel.Any(e => e.ArticalId == id);
        }
    }
}
