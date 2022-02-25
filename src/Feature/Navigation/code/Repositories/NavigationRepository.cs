using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Mvc.Presentation;
using GSC.Feature.Navigation.Models;
using GSC.Feature.Navigation.Extensions;

namespace GSC.Feature.Navigation.Repositories
{
    public class NavigationRepository
    {
        public static Item ContextItem => RenderingContext.Current?.ContextItem ?? Sitecore.Context.Item;
       
        public NavigationRepository()
        {
           
        }        
        public  static List<NavigationItem> GetNavigationList(Item NavigationItem)
        {
            if (NavigationItem != null)
            {
                var items = NavigationItem?.Children?.Where(item => item.DescendsFrom(Templates.Page.TemlateID) && item.Fields[Templates.Navigation.Fields.ShowInMenu].IsChecked())?.ToList();
                List<NavigationItem> lstNav = new List<NavigationItem>();
                foreach (Item item in items)
                {
                    var navItem = new NavigationItem
                    {
                        Item = item,
                        NavigationTitle = item.Fields[Templates.Navigation.Fields.NavigationTitle].Value,
                        Url = item.Url(),
                        IsActive = ContextItem.ID == item.ID,
                        ShowChildren = item.Fields[Templates.Navigation.Fields.ShowChildren].IsChecked()
                    };
                    lstNav.Add(navItem);

                }
                return lstNav;
            }           
            return null;

        }

    }
}