using Microsoft.AspNetCore.Mvc;

namespace w9Page.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            // return View();
            return "This is my default action...";
        }
        public string Wellcome()
        {
            return "this is the Welcome action method";
        }
    }
}
