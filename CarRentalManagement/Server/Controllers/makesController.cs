using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class makesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public makesController(ApplicationDbContext context)
        public makesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/makes
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<make>>> Getmakes()
        public async Task<IActionResult> GetMakes()
        {
            //if (_context.makes == null)
            //{
            //    return NotFound();
            //}
            // return await _context.makes.ToListAsync();
            var makes = await _unitOfWork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: api/makes/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<make>> Getmake(int id)
        public async Task<ActionResult> GetMakes(int id)
        {
            //if (_context.makes == null)
            //{
            //    return NotFound();
            //}
            //var make = await _context.makes.FindAsync(id);
            var make = await _unitOfWork.Makes.Get(q => q.Id== id);

			if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: api/makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmake(int id, make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Makes.Update(make);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!makeExists(id))
                if(!await MakeExists(id))
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

        // POST: api/makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<make>> Postmake(make make)
        {
           // _context.makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Makes.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getmake", new { id = make.Id }, make);
        }

        // DELETE: api/makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletemake(int id)
        {
            //var make = await _context.makes.FindAsync(id);
            var make= await _unitOfWork.Makes.Get(q=>q.Id== id);
            if (make == null)
            {
                return NotFound();
            }

            //_context.makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);


			return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            //return (_context.makes?.Any(e => e.Id == id)).GetValueOrDefault();
            var make = await _unitOfWork.Makes.Get(q=>q.Id== id);
            return make != null;
        }
    }
}
