using System.Collections.Generic;

namespace Aveva.Models
{
    public class ItemLinkModel
    {
        public string Url { get; set; }

        public string Name { get; set; }

        public IEnumerable<ItemLinkModel> Items { get; set; }
    }
}
