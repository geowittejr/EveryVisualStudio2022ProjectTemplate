using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class MVCController : Controller
    {
        // GET: MVCController
        public ActionResult Index()
        {
            return View();
        }

    }
}
