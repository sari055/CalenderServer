using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LevelController : ControllerBase
    {
        ILevelService _service;
        public LevelController(ILevelService service)
        {
            _service = service;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<LevelModel> Get()
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
            LevelModel levelModel = new LevelModel();
            _service.Add(levelModel);
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
