using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using System;

namespace Aveva.Glass.Models
{
    [Serializable]
    [SitecoreType(TemplateId = Constants.TemplatesIDs.DropdownItem,  EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase , AutoMap = true)]
    public class HeaderContentGlassModel
    {
        [SitecoreField(Constants.Fields.DropdownItem.HeadImage)]
        public virtual Image Image { get; set; }
    }
}
