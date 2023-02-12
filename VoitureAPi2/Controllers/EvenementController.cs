using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoitureApi.Model;
using VoitureAPi2.Model;
using VoitureAPi2.Services;

namespace VoitureAPi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenementController : ControllerBase
    {
        IEvenement eventServ;
        public EvenementController(IEvenement eventServ)
        {
            this.eventServ = eventServ;
        }
        [HttpGet("{id}")]
        public  async Task<Evenement> getEvent(int id)
        {
            return  await eventServ.getEvenement(id);
        }

        [HttpPost]
        public Task<Evenement> getEvenement([FromBody] Evenement evenement)
        {
            return eventServ.addUpdateEvent(evenement);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deletecat(int id)
        {
            Evenement evenement = await getEvent(id);
            eventServ.removeEvent(evenement);
            return Ok();
        }

        [HttpGet()]
        public Task<IEnumerable<Evenement>> getAllCategories()
        {
            return eventServ.getAllEvenement();
        }
    }
}
