using central_turnos.Models;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace central_turnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly DBTurnosContext _context;

        public MedicoController(DBTurnosContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Medico medico)
        {
            _context.Add(medico);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IEnumerable<Medico> Get()
        {
            return _context.Medicos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Medico> Get(int id)
        {
            var medico = _context.Medicos.Find(id);

            return (medico != null) ? medico : NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Medico medico)
        {
            if (Id != medico.idMedico)
            {
                return BadRequest();
            }
            _context.Entry(medico).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var medico = _context.Medicos.First(x => x.idMedico == Id);
            if (medico == null)
            {
                return NotFound();
            }
            _context.Remove(medico);
            _context.SaveChanges();

            return Ok();
        }
    }
}
