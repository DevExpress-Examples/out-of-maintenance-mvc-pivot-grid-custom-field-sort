using System.Linq;
using System.Web.Mvc;

namespace DXWebApplication19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        NWindEntities db = new NWindEntities();

        [ValidateInput(false)]
        public ActionResult PivotGridPartial(bool? enable) {
            if(enable != null)
                ViewBag.Enable = enable;
            else
                ViewBag.Enable = false;
            var model = db.SalesPersons;
            return PartialView("_PivotGridPartial", model.ToList());
        }
    }
}