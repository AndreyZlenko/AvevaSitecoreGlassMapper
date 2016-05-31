using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;

namespace Aveva.Glass.Models
{
    [Serializable]
    [SitecoreType(TemplateId = Constants.TemplatesIDs.SiteRootItem, AutoMap = true)]
    public class HeaderGlassModel
    {
        [SitecoreInfo(SitecoreInfoType.Url)]
        public string ItemUrl { get; set; }

        [SitecoreField(Constants.Fields.SiteRootItem.Logo)]
        public virtual Image Logo { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public IEnumerable<ItemLinkGlassModel> Items { get; set; }
    }
}
