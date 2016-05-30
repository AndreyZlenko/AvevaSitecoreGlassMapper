namespace Aveva.Models
{
    public class FooterModel
    {

        private GFooterModel gModel;

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

        public FooterModel(GFooterModel gModel)
        {
            this.gModel = gModel;
        }
    }
}
