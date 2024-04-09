using central_turnos.Models;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace central_turnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnoController : ControllerBase
    {
        private readonly DBTurnosContext _context;

        public TurnoController(DBTurnosContext context)
        {
            _context = context;
        }

        // POST api/Turno
        [HttpPost]
        public IActionResult Post(Turno turno)
        {
            _context.Add(turno);
            _context.SaveChanges();
            return Ok();
        }

        // GET api/Turno
        [HttpGet]
        public IEnumerable<Turno> Get()
        {
            return _context.Turnos.ToList();
        }

        // GET api/Turno/id
        [HttpGet("{id}")]
        public ActionResult<Turno> Get(int id)
        {
            var turno = _context.Turnos.Find(id);
            if (turno == null)
            {
                return NotFound();
            }
            return turno;
        }

        //PUT api/Turno/id
        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Turno turno)
        {
            if (Id != turno.Id)
            {
                return BadRequest();
            }

            _context.Entry(turno).State = EntityState.Modified;

            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/Turno/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var turno = _context.Turnos.Find(Id);
            if (turno == null)
            {
                return NotFound();
            }

            _context.Remove(turno);
            _context.SaveChanges();
            return Ok();
        }
    }
}
