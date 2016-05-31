using Aveva.Glass.Models.Content;

namespace Aveva.Models.Content
{
    public class ListViewModel : BaseViewModel
    {
        private ListGlassModel gModel;

        public string Topic
        {
            get
            {
                return gModel.Topic;
            }
        }

        public string Content
        {
            get
            {
                return gModel.Content;
            }
        }

        public ListViewModel(ListGlassModel gModel)
        {
            this.Type = ContentType.LIST;
            this.gModel = gModel;
        }
    }
}
