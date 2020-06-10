using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archieve.Helper
{
    public static class ToSelectedListItem
    {
        public static IEnumerable<SelectListItem> GetListItems<T>
      (this IEnumerable<T> items,string  name , string  valuefiled, int selectedVal)
        {
            return from item in items
                   select new SelectListItem
                   {
                       Text = item.GetPropValue(name),
                       Value = item.GetPropValue(valuefiled),
                       Selected =
                    item.GetPropValue(valuefiled).Equals(selectedVal.ToString())
                   };
        }

        public static string GetPropValue<T>(this T item, string refName)
        {

            return
               item.GetType().GetProperty(refName).GetValue(item).ToString();
        }
    }
}
