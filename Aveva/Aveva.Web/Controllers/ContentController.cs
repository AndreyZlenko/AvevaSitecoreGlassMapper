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
            HeaderContentGlassModel glassModel = CommonMapper.MapItem<HeaderContentGlassModel>(Sitecore.Context.Item);
            return View(new HeaderContentViewModel(glassModel));
        }

        public ActionResult LeftNavigationBar()
        {
            Item item = Sitecore.Context.Item;
            if (item.TemplateID == ID.Parse(Constants.TemplatesIDs.DropdownItem))
                item = item.Parent;

            ItemLinkGlassModel glassModel = CommonMapper.MapItem<ItemLinkGlassModel>(item);
            return View(new ItemLinkViewModel(glassModel));
        }

        public ActionResult CentralColumn()
        {
            ContentGlassModel contentGlassModel = CommonMapper.MapItem<ContentGlassModel>(Sitecore.Context.Item);
            List<BaseViewModel> model = CommonMapper.MapContent(contentGlassModel.CentralColumn);
            return View(model);
        }
    }
}