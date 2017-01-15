using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using System.Web.Mvc;
using DotNet.Domain.Model;

namespace DotNet.Web.Controllers
{
    [ExcludeFromCodeCoverage]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult CustomBinder(Person person)
        {
            return Content("Bound");

        }
    }
}