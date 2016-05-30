using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using System;

namespace Aveva.Models
{
    [Serializable]
    [SitecoreType(TemplateId = "{C6A06BBF-B6B9-407C-B9B0-02A4AE4DC389}",  EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase , AutoMap = true)]
    public class GHeaderContentModel
    {
        [SitecoreField("HeadImage")]
        public virtual Image Image { get; set; }
    }
}
