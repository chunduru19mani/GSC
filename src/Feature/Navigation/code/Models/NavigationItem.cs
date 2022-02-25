using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace GSC.Feature.Navigation.Models
{
    public class NavigationItem
    {
        public Item Item { get; set; }
        public string NavigationTitle { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public IEnumerable<NavigationItem> Children { get; set; }      
        public bool ShowChildren { get; set; }
    }
}