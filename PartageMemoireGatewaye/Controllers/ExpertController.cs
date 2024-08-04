using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PartageMemoireGatewaye.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpertController : ControllerBase
    {
        ServiceMetier.Service1Client service = new ServiceMetier.Service1Client();
        [HttpPost]
        public bool addExpert(ServiceMetier.Expert expert)
        {
            return service.addExpert(expert);
        }

        [HttpGet]
        public ICollection<ServiceMetier.Expert> GetExperts()
        {
            return service.getAllExpert();
        }

        [HttpGet("{id}")]
        public ActionResult<ServiceMetier.Expert> getExpert(int id)
        {
            var expert = service.getExpert(id);
            if (expert == null)
            {
                return NotFound();
            }
            return Ok(expert);
        }

        [HttpPut("{id}")]
        public ActionResult updateExpert(int id, ServiceMetier.Expert expert)
        {
            var existingExpert = service.getExpert(id);
            if (existingExpert == null)
            {
                return NotFound();
            }

            expert.Id = id;
            var result = service.updateExpert(expert);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la mise à jour de l'expert");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult deleteExpert(int id)
        {
            var existingExpert = service.getExpert(id);
            if (existingExpert == null)
            {
                return NotFound();
            }

            var result = service.deleteExpert(id);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la suppression de l'expert");
            }

            return NoContent();
        }
    }

}
