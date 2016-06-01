using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Aveva.Glass.Models
{
    [SitecoreType(TemplateId = Constants.TemplatesIDs.MainContentItem, EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase, AutoMap = true)]
    public class ContentGlassModel
    {
        [SitecoreField(Constants.Fields.MainContentItem.LeftColumn)]
        public virtual IEnumerable<Guid> LeftColumn { get; set; }

        [SitecoreField(Constants.Fields.MainContentItem.CentralColumn)]
        public virtual IEnumerable<Guid> CentralColumn { get; set; }

        [SitecoreField(Constants.Fields.MainContentItem.RightColumn)]
        public virtual IEnumerable<Guid> RightColumn { get; set; }
    }
}
