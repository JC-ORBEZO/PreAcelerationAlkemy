using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PreAcelerationAlkemy.Context;
using PreAcelerationAlkemy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAcelerationAlkemy.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(_context.Usuarios.ToList());
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Usuario usuario,int id)
        {
            var existe = await _context.Usuarios.AnyAsync(x => x.Id == id);
            //if (!existe) return NotFound();
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            _context.Usuarios.Remove(new Usuario {Id=id });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
