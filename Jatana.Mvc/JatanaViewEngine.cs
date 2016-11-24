using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Jatana.Mvc
{
    public class JatanaViewEngine : VirtualPathProviderViewEngine
    {
        public JatanaViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.njk",
                "~/Views/Shared/{0}.njk"
            };

            PartialViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.njk",
                "~/Views/Shared/{0}.njk"
            };
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            return new JatanaView(partialPath);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            return new JatanaView(viewPath);
        }
    }
}
