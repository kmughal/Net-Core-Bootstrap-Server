using Microsoft.AspNetCore.Mvc;

namespace SimpleServer.Controllers
{
    public class StationDataController : Controller
    {
        public IActionResult Get() => Ok("hello world");

    }
}