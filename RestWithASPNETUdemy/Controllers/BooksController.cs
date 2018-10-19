using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Data.VO;
using Microsoft.AspNetCore.Authorization;

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
        private IBookBusiness _bookBusiness;

        /* Injeção de uma instancia de IBooksRepository ao criar
        uma instancia de PersonController */
        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;            
        }

        [HttpGet]
        [Authorize("bearer")]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [Authorize("bearer")]
        public IActionResult Get(long id)
        {
            var book = _bookBusiness.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        [Authorize("bearer")]
        public IActionResult Post([FromBody]BookVO book)
        {
            if (book == null) return BadRequest();
            return new ObjectResult(_bookBusiness.Create(book)); 
        }

        [HttpPut]
        [Authorize("bearer")]
        public IActionResult Put([FromBody]BookVO book)
        {
            if (book == null) return BadRequest();
            var updateBook = _bookBusiness.Update(book);
            if (updateBook == null) return BadRequest();
            return new ObjectResult(updateBook);
        }

        [HttpDelete("{id}")]
        [Authorize("bearer")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}