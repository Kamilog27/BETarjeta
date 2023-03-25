using BETarjetaCredito.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BETarjetaCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public TarjetaController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/<TarjetaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listTarjetas = await context.TarjetaCreditos.ToListAsync();
                return Ok(listTarjetas);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                
            }

        }


        // POST api/<TarjetaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito tarjeta)
        {
            try 
	        {	        
                context.Add(tarjeta);
                await context.SaveChangesAsync();
                return Ok(tarjeta);

            }
	        catch (Exception e)
	        {
                return BadRequest(e.Message);

            }
        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                if (id != tarjeta.Id)
                {
                    return NotFound();
                }
                context.Update(tarjeta);
                await context.SaveChangesAsync();
                return Ok(new { message = "La tarjeta fue actualizada con éxito!" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var tarjeta = context.TarjetaCreditos.FindAsync(id);
                if (tarjeta == null)
                {
                    return NotFound();
                }
                context.TarjetaCreditos.Remove(await tarjeta);
                await context.SaveChangesAsync();
                return Ok(new { message = "La tarjeta fue eliminada con éxito" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
