using Glass.Mapper.Sc.Configuration.Attributes;
using System;

namespace Aveva.Glass.Models.Content
{
    [Serializable]
    [SitecoreType(TemplateId = Constants.TemplatesIDs.ContentList, AutoMap = true)]
    public class ListGlassModel
    {
        [SitecoreField(Constants.Fields.Content.ListItem.Topic)]
        public string Topic { get; set; }

        [SitecoreField(Constants.Fields.Content.ListItem.Content)]
        public string Content { get; set; }
    }
}
