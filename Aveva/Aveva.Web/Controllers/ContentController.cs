using Aveva.Models;
using Aveva.Models.Content;
using Aveva.Services;
using Glass.Mapper.Sc.Web.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aveva.Web.Controllers
{
    public class ContentController : GlassController
    {
        public ActionResult Header()
        {
            HeaderContentModel model = this.GetContextItem<HeaderContentModel>();
            return View(model);
        }

        public ActionResult LeftNavigationBar()
        {
            List<ItemLinkModel> model = ViewModelsMapper.MapLeftNavigationBar(Sitecore.Context.Item);
            return View(model);
        }

        public ActionResult CentralColumn()
        {
            List<BaseModel> model = ViewModelsMapper.MapContentColumn(Sitecore.Context.Item, ViewModelsMapper.Column.CENTAL);
            return View(model);
        }
    }
}