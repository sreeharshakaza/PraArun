using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClass
{
    public static class CustomHelpers
    {
        public static MvcHtmlString CustomImg()
        {
            string helperString = "<img src='../../Content/themes/base/images/ui-icons_cd0a0a_256x240.png' width='100' height='100'/>";

            return new MvcHtmlString(helperString);
        }
    }
}