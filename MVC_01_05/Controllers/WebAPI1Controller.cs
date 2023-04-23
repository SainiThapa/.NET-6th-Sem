using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_01_05.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class DateServices : Interface
    {
        public DateTime Getdate()
        {
            return System.DateTime.Now;
        }

    }

/*
    public class DateServices
    {
        public DateTime Getdate()
        {
            return System.DateTime.Now;
        }
    }*/

    public class WebAPI1Controller : ControllerBase
    {
        // GET: api/<WebAPI1>
        [HttpGet]
        public object Get()
        {
            return new string[] { "value1", "value2" };
            return new { name = "Saini", Address = "Tilotama" };
        }

        public List<object> Get1() 
        {
            List<object> list = new List<object>();
            list.Add(new { name = "Saini", Address = "Rupandehi" });
            list.Add(new { name = "Ronit", Address = "Bhaktapur" });
            list.Add(new { name = "Suman", Address = "Kathmandu" });
            return list;
        }

        // GET api/<WebAPI1>/5
        [HttpGet("{id}")]
        public string Get2(int id)
        {
            return "value";
        }

        // POST api/<WebAPI1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WebAPI1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebAPI1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
