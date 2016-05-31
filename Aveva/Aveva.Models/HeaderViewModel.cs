using Aveva.Glass.Models;
using System.Collections.Generic;

namespace Aveva.Models
{
    public class HeaderViewModel
    {
        private HeaderGlassModel gModel;

        public string ItemUrl
        {
            get
            {
                return gModel.ItemUrl;
            }
        }

        public string LogoUrl
        {
            get
            {
                return (gModel.Logo != null) ? gModel.Logo.Src : string.Empty;
            }
        }

        public string LogoAlt
        {
            get
            {
                return (gModel.Logo != null) ? gModel.Logo.Alt : string.Empty;
            }
        }

        public IEnumerable<ItemLinkViewModel> Items{
            get
            {
                foreach(ItemLinkGlassModel gItemLink in gModel.Items)
                {
                    yield return new ItemLinkViewModel(gItemLink);
                }
            }
        }

        public HeaderViewModel(HeaderGlassModel gModel)
        {
            this.gModel = gModel;
        }
    }
}
