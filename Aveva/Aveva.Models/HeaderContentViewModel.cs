using Aveva.Glass.Models;

namespace Aveva.Models
{

    public class HeaderContentViewModel
    {
        private HeaderContentGlassModel gModel;

        public string ImageUrl
        {
            get
            {
                return (gModel.Image != null) ? gModel.Image.Src : string.Empty;
            }
        }

        public string ImageAlt
        {
            get
            {
                return (gModel.Image != null) ? gModel.Image.Alt : string.Empty;
            }
        }

        public HeaderContentViewModel(HeaderContentGlassModel gModel)
        {
            this.gModel = gModel;
        }
    }
}
