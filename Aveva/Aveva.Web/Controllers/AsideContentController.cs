using Aveva.Glass.Models;
using Aveva.Models.Content;
using Aveva.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aveva.Web.Controllers
{
    public class AsideContentController : Controller
    {
        public ActionResult LeftColumn()
        {
            ContentGlassModel contentGlassModel = CommonMapper.MapItem<ContentGlassModel>(Sitecore.Context.Item);
            List<BaseViewModel> model = CommonMapper.MapContent(contentGlassModel.LeftColumn);
            return View("AsideColumn", model);
        }

        public ActionResult RightColumn()
        {
            ContentGlassModel contentGlassModel = CommonMapper.MapItem<ContentGlassModel>(Sitecore.Context.Item);
            List<BaseViewModel> model = CommonMapper.MapContent(contentGlassModel.RightColumn);
            return View("AsideColumn", model);
        }
    }
}