using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserTypeController : ControllerBase
    {
        IUserTypeService _service;
        public UserTypeController(IUserTypeService service)
        {
            _service = service;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserTypeModel> Get()
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
            UserTypeModel userTypeModel = new UserTypeModel();
            _service.Add(userTypeModel);
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
