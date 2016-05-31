﻿using Aveva.Glass.Models.Content;
using Aveva.Models.Content;
using Glass.Mapper.Sc;
using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;

namespace Aveva.Services
{
    public static class CommonMapper
    {
       
        #region Common mapper

        public static TViewModel MapItem<TViewModel, TGlassModel>(Item item)
            where TViewModel : class
            where TGlassModel : class
        {
            SitecoreContext context = new SitecoreContext();
            return (TViewModel)Activator.CreateInstance(typeof(TViewModel), new object[] { context.GetItem<TGlassModel>(item.ID.Guid) });
        }

        #endregion

        #region Content column mapper

        public static List<BaseViewModel> MapContent(IEnumerable<Guid> contentItemsGuids)
        {
            List<BaseViewModel> model = new List<BaseViewModel>();

            SitecoreContext context = new SitecoreContext();

            if (contentItemsGuids != null)
            {
                foreach (Guid contentItemGuid in contentItemsGuids)
                {
                    if (Sitecore.Context.Database.GetItem(ID.Parse(contentItemGuid)).TemplateID == ID.Parse(Constants.TemplatesIDs.ContentBox))
                    {
                        model.Add( new BoxViewModel(context.GetItem<BoxGlassModel>(contentItemGuid)) );
                    }
                    else if (Sitecore.Context.Database.GetItem(ID.Parse(contentItemGuid)).TemplateID == ID.Parse(Constants.TemplatesIDs.ContentList))
                    {
                        model.Add(new ListViewModel(context.GetItem<ListGlassModel>(contentItemGuid)));
                    }
                }
            }

            return model;
        }
        #endregion
    }
}