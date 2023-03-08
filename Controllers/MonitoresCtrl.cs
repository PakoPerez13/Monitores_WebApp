using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monitores_WebApp.Entities;

namespace Monitores_WebApp.Controllers
{
    [ApiController]
    [Route("api/monitores")]
    public class MonitoresCtrl:ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public MonitoresCtrl(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Monitors monitors)
        {
            dbContext.Add(monitors);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Monitors>>> Get()
        {
            return await dbContext.Monitores.Include(x => x.pedidos).ToListAsync();
        }

        [HttpPut("{id:int}")] // api/monitores/1

        public async Task<ActionResult> Put(Monitors monitors, int id)
        {
            if(monitors.Id != id)
            {
                return BadRequest("El id del monitor no coincide con la estrablecido de la url");
            }

            dbContext.Update(monitors);
            await dbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Monitores.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Monitors()
            {
                Id = id,
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
