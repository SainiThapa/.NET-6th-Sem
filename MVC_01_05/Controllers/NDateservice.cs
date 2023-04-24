using Microsoft.AspNetCore.Mvc;

namespace MVC_01_05.Controllers
{
    public class NDateservice : Interface
    {

        public DateTime Getdate()
        {
            return System.DateTime.Now.AddYears(57);
        }

    }
}
