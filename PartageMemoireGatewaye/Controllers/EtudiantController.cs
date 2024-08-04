using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PartageMemoireGatewaye.Controllers
{
  //  [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {
        ServiceMetier.Service1Client service = new ServiceMetier.Service1Client();
        [HttpPost]
        public bool AddEtudiant(ServiceMetier.Etudiant Etudiant)
        {
            return service.AddEtudiant(Etudiant);
        }

        [HttpGet]
        public ICollection<ServiceMetier.Etudiant> GetEtudiant()
        {
            return service.getAllEtudiant();
        }

        [HttpPut("{id}")]
        public ActionResult updateEtudiant(int id, ServiceMetier.Etudiant etudiant)
        {
            var existingEtudiant = service.getEtudiant(id);
            if (existingEtudiant == null)
            {
                return NotFound();
            }

            etudiant.Id = id;
            var result = service.updateEtudiant(etudiant);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la mise à jour de l'expert");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult deleteEtudiant(int id)
        {
            var existingEtudiant = service.getEtudiant(id);
            if (existingEtudiant == null)
            {
                return NotFound();
            }

            var result = service.deleteEtudiant(id);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur lors de la suppression de l'expert");
            }

            return NoContent();
        }
    }
}
