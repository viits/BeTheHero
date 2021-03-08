using Microsoft.AspNetCore.Mvc;
using Projeto.Data;
using Projeto.Models;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {

        public readonly IRepository repo;
        public IncidentController(IRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult index()
        {             
             return Ok(this.repo.GetAllIncidents());
        }

        [HttpPost]
        public IActionResult create(Incident incident)
        {
            this.repo.Add(incident);
            this.repo.Save();
            return Ok("Cadastrado com sucesso");
        }

        [HttpPut]
        public IActionResult update(Incident incident)
        {
            this.repo.Update(incident);
            this.repo.Save();
            return Ok("Atualizado com sucesso");
        }
 
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var idInci = this.repo.GetByIdIncident(id);
            this.repo.Delete(idInci);
            this.repo.Save();
            return Ok("Deletado com sucesso");
        }
    }
}