using Microsoft.AspNetCore.Mvc;
using Projeto.Data;
using Projeto.Models;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OngController : ControllerBase
    {
        public readonly IRepository repo;

        public OngController(IRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult index()
        {
            return Ok(this.repo.GetAllOngs());
        }

        [HttpPost]
        public IActionResult create(Ongs ong)
        {
           this.repo.Add(ong);
           
           return Ok(this.repo.Save());
        }

        [HttpPut]
        public IActionResult update(Ongs ong)
        {
            this.repo.Update(ong);
            return Ok(this.repo.Save());
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            Ongs ong =  this.repo.GetById(id);
            this.repo.Delete(ong);
            this.repo.Save();
            return Ok("Deletado com sucesso");
        }
    }
}