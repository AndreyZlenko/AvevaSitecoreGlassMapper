using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace Aveva.Glass.Models
{
    public class ItemLinkGlassModel
    {
        [SitecoreInfo(SitecoreInfoType.Url)]
        public string Url { get; set; }

        [SitecoreField(Constants.Fields.DropdownItem.Name)]
        public string Name { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public IEnumerable<ItemLinkGlassModel> Items { get; set; }
    }
}
