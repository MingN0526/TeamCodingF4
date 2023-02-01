using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

namespace TeamCodingF4.Controllers
{
    public class EstateController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public EstateController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.EstateModel.ToListAsync());
        }

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("EstateId,EstateTittle,RoomType,Address,EststePrice,Miscellaneous,Meters,Car,Motorcycle,AirConditioner,Television,WetDry,Balcony,WashingMachine,WaterDispenser,Refrigerator,Lease,EstatePicture,EstateVideo,message")] EstateModel estateModel)
        {

            if (ModelState.IsValid)
            {
                var ep = estateModel.EstatePicture;
                var ev = estateModel.EstateVideo;
                if (ep != null && ev!=null)
                {
                    var root = _environment.WebRootPath;
                    foreach (var picture in ep)
                    {
                        var pictureName = DateTime.Now.Ticks + picture.FileName;
                        var picturepath = $@"{root}\Picture\{pictureName}";
                        picture.CopyTo(System.IO.File.Create(picturepath));
                        _context.EstateImage.Add(new EstateImage()
                        {
                            Path = $@"\Picture\{pictureName}",
                        });
                    }
                    var videoName = DateTime.Now.Ticks + ev.FileName;
                    var videopath = $@"{root}\Video\{videoName}";
                    ev.CopyTo(System.IO.File.Create(videopath));
                    _context.EstateVideo.Add(new EstateVideo()
                    {
                        Path = $@"\Video\{videoName}",
                    });

                    _context.Add(estateModel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(estateModel);
        }

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

        [HttpPost]
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

        [HttpPost, ActionName("Delete")]
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
