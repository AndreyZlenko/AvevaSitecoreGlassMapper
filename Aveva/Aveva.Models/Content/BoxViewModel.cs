using Aveva.Glass.Models.Content;

namespace Aveva.Models.Content
{
    public class BoxViewModel : BaseViewModel
    {
        private BoxGlassModel gModel;

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

        public BoxViewModel(BoxGlassModel gModel)
        {
            this.Type = ContentType.BOX;
            this.gModel = gModel;
        }
    }
}
