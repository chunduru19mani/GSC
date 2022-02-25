using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSC.Feature.Navigation
{
    public struct Templates
    {
        public struct Page
        {
            public static readonly ID TemlateID = new ID("{570D0FA9-BE63-4367-AE30-A9163227D4EE}");
           
        }
        public struct Navigation
        {
            public struct Fields
            {
                public static readonly ID NavigationTitle = new ID("{11961E8E-1182-437A-87D4-E835D4E7BB69}");
                public static readonly ID ShowInMenu = new ID("{904A2A6F-EDE7-4EDC-BF43-9AF42C5A19F4}");
                public static readonly ID ShowChildren = new ID("{30C89D93-225A-4DAE-98AA-0275DDE6249A}");
            }
           

        }
        public struct Root
        {
            public static readonly ID ID = new ID("{58C04DCD-6FBD-420B-8972-8B4E00AB714A}");
        }

    }
}