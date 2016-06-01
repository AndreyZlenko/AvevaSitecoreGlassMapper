using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;

namespace Aveva.Glass.Models
{
    [SitecoreType(TemplateId = Constants.TemplatesIDs.MainContentItem, EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase, AutoMap = true)]
    public class HeaderContentGlassModel
    {
        [SitecoreField(Constants.Fields.MainContentItem.HeadImage)]
        public virtual Image Image { get; set; }
    }
}
