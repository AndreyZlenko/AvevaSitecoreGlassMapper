
using Aveva.Glass.Models;

namespace Aveva.Models
{
    public class FooterViewModel
    {

        private FooterGlassModel gModel;

        public string Date
        {
            get
            {
                return gModel.Date;
            }
        }

        public string Contacts
        {
            get
            {
                return gModel.Contacts;
            }
        }

        public string Information
        {
            get
            {
                return gModel.Information;
            }
        }

        public FooterViewModel(FooterGlassModel gModel)
        {
            this.gModel = gModel;
        }
    }
}
