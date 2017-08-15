using Microsoft.AspNetCore.Mvc;

namespace UtManager.Web.Controllers
{
    [Route("")]
    [Route("app")]
    public sealed class AppController : UtManagerControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}