using Microsoft.AspNetCore.Mvc;
using RestWithASP_NET5.Model;
using RestWithASP_NET5.Services.Implamentations;

namespace RestWithASP_NET5.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private PersonService _person;
        public PersonController(ILogger<PersonController> logger, PersonService person)
        {
            _logger = logger;
            _person = person;
        }


        [HttpGet("{id}", Name = "GETPerson")]
        public IActionResult Get(long id)
        {
            var person = _person.FindAll();
            if (person == null) return NotFound();

            //return Ok(_person.FindByID(id));
            return Ok(person);
        }

        [HttpPost (Name = "PostPerson")]
        public IActionResult Post([FromBody] Person person)
        {
            
            if (person == null) return BadRequest();
            return Ok(_person.Create(person));
        }

        [HttpPut(Name = "PutPerson")]
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null) return BadRequest();
            return Ok(_person.Update(person));
        }

        [HttpDelete("{id}", Name ="DeletePerson")]
        public IActionResult Delete(long id)
        {
             _person.Delete();
            return NoContent();
        }
    }
}
