using Microsoft.AspNetCore.Mvc;

namespace Simple_API.Controllers
{
    public class HelloWorldController : Controller
    {

        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }
        //
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes = 1)
        {
            return $"Hello {name}, NumTime is: {numTimes}";
        }
    }
}
