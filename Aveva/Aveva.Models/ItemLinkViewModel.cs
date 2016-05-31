using Aveva.Glass.Models;
using System.Collections.Generic;

namespace Aveva.Models
{
    public class ItemLinkViewModel
    {
        private ItemLinkGlassModel gModel;

        public string Url
        {
            get
            {
                return gModel.Url;
            }
        }

        public string Name
        {
            get
            {
                return gModel.Name;
            }
        }

        public IEnumerable<ItemLinkViewModel> Items
        {
            get
            {
                foreach (ItemLinkGlassModel gItemLink in gModel.Items)
                {
                    yield return new ItemLinkViewModel(gItemLink);
                }
            }
        }

        public ItemLinkViewModel(ItemLinkGlassModel gModel)
        {
            this.gModel = gModel;
        }
    }
}
