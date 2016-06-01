using Glass.Mapper.Sc.Configuration.Attributes;

namespace Aveva.Glass.Models
{
    [SitecoreType(TemplateId = Constants.TemplatesIDs.SiteRootItem, AutoMap = true)]
    public class FooterGlassModel
    {
        [SitecoreField(Constants.Fields.SiteRootItem.Date)]
        public string Date { get; set; }

        [SitecoreField(Constants.Fields.SiteRootItem.Contacts)]
        public string Contacts { get; set; }

        [SitecoreField(Constants.Fields.SiteRootItem.Information)]
        public string Information { get; set; }
    }
}
