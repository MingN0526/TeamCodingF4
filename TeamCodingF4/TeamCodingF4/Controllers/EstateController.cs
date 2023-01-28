using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers
{
    public class EstateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EstateModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.EstateModel.ToListAsync());
        }

        // GET: EstateModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EstateModel == null)
            {
                return NotFound();
            }

            var estateModel = await _context.EstateModel
                .FirstOrDefaultAsync(m => m.EstateId == id);
            if (estateModel == null)
            {
                return NotFound();
            }

            return View(estateModel);
        }

        // GET: EstateModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstateModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstateId,EstateTittle,RoomType,Address,EststePrice,Miscellaneous,Meters,Car,Motorcycle,AirConditioner,Television,WetDry,Balcony,WashingMachine,WaterDispenser,Refrigerator,Lease,EstatePicture,EstateVideo,message")] EstateModel estateModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estateModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estateModel);
        }

        // GET: EstateModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EstateModel == null)
            {
                return NotFound();
            }

            var estateModel = await _context.EstateModel.FindAsync(id);
            if (estateModel == null)
            {
                return NotFound();
            }
            return View(estateModel);
        }

        // POST: EstateModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstateId,EstateTittle,RoomType,Address,EststePrice,Miscellaneous,Meters,Car,Motorcycle,AirConditioner,Television,WetDry,Balcony,WashingMachine,WaterDispenser,Refrigerator,Lease,EstatePicture,EstateVideo,message")] EstateModel estateModel)
        {
            if (id != estateModel.EstateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estateModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstateModelExists(estateModel.EstateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(estateModel);
        }

        // GET: EstateModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EstateModel == null)
            {
                return NotFound();
            }

            var estateModel = await _context.EstateModel
                .FirstOrDefaultAsync(m => m.EstateId == id);
            if (estateModel == null)
            {
                return NotFound();
            }

            return View(estateModel);
        }

        // POST: EstateModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EstateModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.EstateModel'  is null.");
            }
            var estateModel = await _context.EstateModel.FindAsync(id);
            if (estateModel != null)
            {
                _context.EstateModel.Remove(estateModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstateModelExists(int id)
        {
          return _context.EstateModel.Any(e => e.EstateId == id);
        }
    }
}
