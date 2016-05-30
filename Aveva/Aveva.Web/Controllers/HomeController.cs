using Aveva.Models;
using Aveva.Services;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Aveva.Web.Controllers
{
    public class HomeController : GlassController
    {
        public ActionResult GetHeader()
        {
            HeaderModel model = this.GetContextItem<HeaderModel>();
            return View(model);
        }

        public ActionResult GetFooter()
        {
            FooterModel model = this.GetContextItem<FooterModel>();
            return View(model);
        }
    }
}