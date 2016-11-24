using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;

using EdgeJs;

namespace Jatana.Mvc
{
    public class JatanaView : IView
    {
        private readonly string _templatePath;

        public JatanaView(string templatePath)
        {
            _templatePath = templatePath;
        }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            string templatePath = _templatePath.Replace("~/Views/", string.Empty);

            writer.Write(NunjucksRenderer.Current.Render(templatePath, viewContext.ViewData.Model));
        }
    }
}