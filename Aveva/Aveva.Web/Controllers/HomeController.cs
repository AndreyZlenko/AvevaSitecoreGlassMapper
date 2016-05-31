using Aveva.Glass.Models;
using Aveva.Models;
using Aveva.Services;
using System.Web.Mvc;

namespace Aveva.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetHeader()
        {
            HeaderViewModel model = CommonMapper.MapItem<HeaderViewModel, HeaderGlassModel>(Sitecore.Context.Item);
            return View(model);
        }

        public ActionResult GetFooter()
        {
            FooterViewModel model = CommonMapper.MapItem<FooterViewModel, FooterGlassModel>(Sitecore.Context.Item);
            return View(model);
        }
    }
}