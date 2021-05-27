using AspNetUdemy.Model;
using AspNetUdemy.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetUdemy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BookController> _logger;
        private IBookBusiness _BookBusiness;

        public BookController(ILogger<BookController> logger, IBookBusiness BookService)
        {
            _logger = logger;
            _BookBusiness = BookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_BookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var Book = _BookBusiness.FindByID(id);
            if (Book == null) return NotFound();
            return Ok(Book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return Ok(_BookBusiness.Create(Book));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return Ok(_BookBusiness.Update(Book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _BookBusiness.Delete(id);
            return NoContent();
        }
    }
}
