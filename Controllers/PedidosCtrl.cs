using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monitores_WebApp.Entities;

namespace Monitores_WebApp.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidosCtrl : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PedidosCtrl(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Pedidos pedidos)
        {
            dbContext.Add(pedidos);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<Pedidos>>> GetAll()
        {
            return await dbContext.pedidos.ToListAsync(); //Obtener todos los pedidos disponibles
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pedidos>> GetbyId(int id)
        {
            return await dbContext.pedidos.FirstOrDefaultAsync(x => x.id == id); //Primer registro obtenido de la consulta
        }

        [HttpPut("{id:int}")] // api/pedidos/1

        public async Task<ActionResult> Put(Pedidos pedidos, int id)
        {
            var exist = await dbContext.pedidos.AnyAsync(x => x.id == id);

            if (!exist)
            {
                return BadRequest("El pedido especificado no existe");
            }

            if (pedidos.id != id)
            {
                return BadRequest("El id del pedido no coincide con la estrablecido de la url");
            }


            dbContext.Update(pedidos);
            await dbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.pedidos.AnyAsync(x => x.id == id);
            if (!exist)
            {
                return NotFound("El recurso no se encontró");
            }

            dbContext.Remove(new Pedidos()
            {
                id = id,
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}