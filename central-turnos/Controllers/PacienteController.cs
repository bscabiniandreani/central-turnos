using central_turnos.Models;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace central_turnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly DBTurnosContext _context;

        public PacienteController(DBTurnosContext context)
        {
            _context = context;
        }

        // GET api/Paciente
        [HttpPost]
        public IActionResult Post(Paciente paciente)
        {
            _context.Add(paciente);
            _context.SaveChanges();
            return Ok();
        }

        // GET api/Paciente
        [HttpGet]
        public IEnumerable<Paciente> Get()
        {
           return  _context.Pacientes.ToList();
        }

        // GET api/Paciente/id
        [HttpGet("{id}")]
        public ActionResult<Paciente> Get(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if(paciente==null)
            {
                return NotFound();
            }

            return paciente;
        }
        // GET api/Paciente/id
        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Paciente paciente)
        {
            if(Id != paciente.Id)
            {
                return BadRequest();
            }

            _context.Entry(paciente).State = EntityState.Modified;
            
            _context.SaveChanges();

            return Ok();
        }

        // GET api/Paciente/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var paciente = _context.Pacientes.First(x => x.Id == Id);
            if (paciente == null)
            {
                return NotFound();
            }

            _context.Remove(paciente);
            _context.SaveChanges();
            return Ok();
        }
    }
}
