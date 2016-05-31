using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;

namespace Aveva.Glass.Models
{
    [Serializable]
    [SitecoreType(EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase, TemplateId = Constants.TemplatesIDs.DropdownItem, AutoMap = true)]
    public class ContentGlassModel
    {
        [SitecoreField(Constants.Fields.DropdownItem.LeftColumn)]
        public virtual IEnumerable<Guid> LeftColumn { get; set; }

        [SitecoreField(Constants.Fields.DropdownItem.CentralColumn)]
        public virtual IEnumerable<Guid> CentralColumn { get; set; }

        [SitecoreField(Constants.Fields.DropdownItem.RightColumn)]
        public virtual IEnumerable<Guid> RightColumn { get; set; }
    }
}
