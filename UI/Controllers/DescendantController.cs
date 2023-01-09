using Microsoft.AspNetCore.Mvc;
//using Repository.Entities;
using Services.Interfaces;
using Services.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]

    public class DescendantController : ControllerBase
    {
        IDescendantService _service;
        public DescendantController(IDescendantService service)
        {
            _service = service;
        }
        // GET: api/<DescendantController>
        [HttpGet]
        public IEnumerable<DescendantModel> Get()
        {
            var result = _service.GetAll();
            return result;
        }

        // GET api/<DescendantController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DescendantController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            DescendantModel descModel = new DescendantModel() { DescendantId = 1113, FirstName = "Ruthi", LastName = "Rom", FatherId = 1110, MotherId = 1111, DOB = DateOnly.FromDateTime(DateTime.Now), SpouseId = 0 };
            _service.Add(descModel);
        }

        // PUT api/<DescendantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DescendantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
