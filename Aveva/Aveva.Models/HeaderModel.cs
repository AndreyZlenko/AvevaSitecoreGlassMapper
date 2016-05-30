using System.Collections.Generic;

namespace Aveva.Models
{
    public class HeaderModel
    {
        public string ItemUrl { get; set; }

        public string LogoUrl { get; set; }

        public string LogoAlt { get; set; }

        public IEnumerable<ItemLinkModel> Items { get; set; }
    }
}
