using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Services.Interfaces;
using Services.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalenderController : ControllerBase
    {
        ICalenderService _service;
        public CalenderController(ICalenderService service)
        {
            _service = service;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<CalenderModel> Get()
        {
            var result = _service.GetAll();
            return result;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            CalenderModel calender = new CalenderModel();
            _service.Add(calender);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
