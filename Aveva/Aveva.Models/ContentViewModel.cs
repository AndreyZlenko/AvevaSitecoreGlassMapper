using Aveva.Glass.Models;
using System;
using System.Collections.Generic;

namespace Aveva.Models
{
    public class ContentViewModel
    {
        private ContentGlassModel gModel;

        public IEnumerable<Guid> LeftColumn
        {
            get
            {
                return gModel.LeftColumn;
            }
        }

        public IEnumerable<Guid> CentralColumn
        {
            get
            {
                return gModel.CentralColumn;
            }
        }

        public IEnumerable<Guid> RightColumn
        {
            get
            {
                return gModel.RightColumn;
            }
        }

        public ContentViewModel(ContentGlassModel gModel)
        {
            this.gModel = gModel;
        }
    }
}
