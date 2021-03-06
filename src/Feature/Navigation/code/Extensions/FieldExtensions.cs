using Sitecore;
using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSC.Feature.Navigation.Extensions
{
    public static class FieldExtensions
    {
        public static bool IsChecked(this Field checkboxField)
        {
            if (checkboxField == null)
            {
                throw new ArgumentNullException(nameof(checkboxField));
            }
            return MainUtil.GetBool(checkboxField.Value, false);
        }
    }
}