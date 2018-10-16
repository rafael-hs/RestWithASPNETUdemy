using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Business;
namespace RestWithASPNETUdemy.Controllers
{

    /* Mapeia as requisições de http://localhost:{porta}/api/persons/v1/
    Por padrão o ASP.NET Core mapeia todas as classes que extendem Controller
    pegando a primeira parte do nome da classe em lower case [Person]Controller
    e expõe como endpoint REST
    */
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BooksController : Controller
    {
        //Declaração do serviço usado
        private IPersonBusiness _personBusiness;

        /* Injeção de uma instancia de IBooksRepository ao criar
        uma instancia de PersonController */
        public BooksController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            return 0; 
        }

        [HttpPut]
        public IActionResult Put([FromBody]Book book)
        {
            return 0;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}