using Glass.Mapper.Sc.Configuration.Attributes;
using System;

namespace Aveva.Glass.Models.Content
{
    [Serializable]
    [SitecoreType(TemplateId = Constants.TemplatesIDs.ContentBox, AutoMap = true)]
    public class BoxGlassModel
    {
        [SitecoreField(Constants.Fields.Content.BoxItem.Topic)]
        public string Topic { get; set; }

        [SitecoreField(Constants.Fields.Content.BoxItem.Content)]
        public string Content { get; set; }
    }
}
