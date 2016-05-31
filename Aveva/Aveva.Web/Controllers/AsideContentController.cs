using Aveva.Glass.Models;
using Aveva.Models;
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
            ContentViewModel contentModel = CommonMapper.MapItem<ContentViewModel, ContentGlassModel>(Sitecore.Context.Item);
            List<BaseViewModel> model = CommonMapper.MapContent(contentModel.LeftColumn);
            return View("AsideColumn", model);
        }

        public ActionResult RightColumn()
        {
            ContentViewModel contentModel = CommonMapper.MapItem<ContentViewModel, ContentGlassModel>(Sitecore.Context.Item);
            List<BaseViewModel> model = CommonMapper.MapContent(contentModel.RightColumn);
            return View("AsideColumn", model);
        }
    }
}