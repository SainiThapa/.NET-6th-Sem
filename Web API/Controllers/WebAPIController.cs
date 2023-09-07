using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
        [Route("api/[controller]/[action]")] //to call specific action, placing action in route
        [ApiController]
        public class WebAPIController : ControllerBase
        {
            // GET: api/<WebAPIController>
            [HttpGet]
            public object Getdata()
            {
                //return new string[] { "value1", "value2" };
                return new { Name = "Saini", Address = "Bhaktapur" }; //displays in json format
            }
            public List<object> GetUsers()
            {
                List<object> list = new List<object>(); //creating new list
                list.Add(new { name = "Saitama", anime = "One Punch Man" });
                list.Add(new { name = "Jotaro", anime = "Jojo's Bizzare Adventure" });
                list.Add(new { name = "Gojo", anime = "Jujutsu Kaisen" });
                return list;  // displays json data in a list 
            }

        }
}
