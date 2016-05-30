using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;

namespace Aveva.Models
{
    [Serializable]
    [SitecoreType(TemplateId = "{0EBD4240-1D1F-42D1-B966-636402D97E9F}", AutoMap = true)]
    public class HeaderModel
    {
        [SitecoreInfo(SitecoreInfoType.Url)]
        public string ItemUrl { get; set; }

        [SitecoreField]
        public virtual Image Logo { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public IEnumerable<ItemLinkModel> Items { get; set; }
    }
}
