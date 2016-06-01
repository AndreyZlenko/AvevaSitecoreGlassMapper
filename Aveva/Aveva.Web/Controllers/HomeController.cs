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
            HeaderGlassModel glassModel = CommonMapper.MapItem<HeaderGlassModel>(Sitecore.Context.Item);
            return View(new HeaderViewModel(glassModel));
        }

        public ActionResult GetFooter()
        {
            FooterGlassModel glassModel = CommonMapper.MapItem<FooterGlassModel>(Sitecore.Context.Item);
            return View(new FooterViewModel(glassModel));
        }
    }
}