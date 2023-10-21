﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Primitives;
using System.Runtime.InteropServices;

namespace CustomHTMLHelperInCoreMvc.Models
{
    public static class CustomHTMLHelper
    {
        //public static TagBuilder Image(this IHtmlHelper helper, string src, string alt, string height, string width, string cssClass)
        public static TagBuilder Image(string src, string alt, string height, string width, string cssClass)
        {
            var imgTag = new TagBuilder("img");
            imgTag.MergeAttribute("src", src);

            if (alt != null)
            {
                imgTag.MergeAttribute("alt", alt);
            }

            if (Convert.ToInt32(height) > 0)
            {
                imgTag.MergeAttribute("height", height);
            }

            if (Convert.ToInt32(width) > 0)
            {
                imgTag.MergeAttribute("width", width);
            }

            if (cssClass != null)
            {
                imgTag.AddCssClass(cssClass);
            }
            return imgTag;
        }
    }
}
