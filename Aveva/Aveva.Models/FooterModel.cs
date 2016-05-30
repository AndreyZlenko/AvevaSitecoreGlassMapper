using Glass.Mapper.Sc.Configuration.Attributes;
using System;

namespace Aveva.Models
{
    [Serializable]
    [SitecoreType(TemplateId = "{0EBD4240-1D1F-42D1-B966-636402D97E9F}", AutoMap = true)]
    public class FooterModel
    {
        [SitecoreField("Date")]
        public string Date { get; set; }

        [SitecoreField("Contacts")]
        public string Contacts { get; set; }

        [SitecoreField("Information")]
        public string Information { get; set; }
    }
}
