using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace Aveva.Models
{
    public class GItemLinkModel
    {
        [SitecoreInfo(SitecoreInfoType.Url)]
        public string Url { get; set; }

        [SitecoreField("Name")]
        public string Name { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public IEnumerable<GItemLinkModel> Items { get; set; }
    }
}
