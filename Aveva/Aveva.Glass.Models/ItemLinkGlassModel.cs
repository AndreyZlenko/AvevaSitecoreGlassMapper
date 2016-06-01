using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace Aveva.Glass.Models
{
    [SitecoreType(TemplateId = Constants.TemplatesIDs.MenuItem, EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase, AutoMap = true)]
    public class ItemLinkGlassModel
    {
        [SitecoreInfo(SitecoreInfoType.Url)]
        public string Url { get; set; }

        [SitecoreField(Constants.Fields.MenuItem.MenuItemName)]
        public string Name { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public IEnumerable<ItemLinkGlassModel> Items { get; set; }
    }
}
