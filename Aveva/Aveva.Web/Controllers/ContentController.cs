using Aveva.Glass.Models;
using Aveva.Models;
using Aveva.Models.Content;
using Aveva.Services;
using Sitecore.Data;
using Sitecore.Data.Items;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aveva.Web.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Header()
        {
            HeaderContentViewModel model = CommonMapper.MapItem<HeaderContentViewModel, HeaderContentGlassModel>(Sitecore.Context.Item);
            return View(model);
        }

        public ActionResult LeftNavigationBar()
        {
            Item item = Sitecore.Context.Item;
            if (item.TemplateID == ID.Parse(Constants.TemplatesIDs.DropdownItem))
                item = item.Parent;

            ItemLinkViewModel model = CommonMapper.MapItem<ItemLinkViewModel, ItemLinkGlassModel>(item);

            return View(model);
        }

        public ActionResult CentralColumn()
        {
            ContentViewModel contentModel = CommonMapper.MapItem<ContentViewModel, ContentGlassModel>(Sitecore.Context.Item);
            List<BaseViewModel> model = CommonMapper.MapContent(contentModel.CentralColumn);
            return View(model);
        }
    }
}