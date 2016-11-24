using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using EdgeJs;

namespace Jatana.Mvc
{
    public abstract class NunjucksRenderer
    {
        public static NunjucksRenderer Current { get; private set; }
        
        public static void SetRenderer(NunjucksRenderer renderer)
        {
            Current = renderer;
        }

        public abstract string Render<T>(string template, T model);
    }

    public class NodeHostedNunjucks : NunjucksRenderer
    {
        private Func<object, Task<object>> _renderer;

        public static NodeHostedNunjucks Create()
        {
            var renderer = new NodeHostedNunjucks();
            renderer.SetupRenderCallback();
            return renderer;
        }

        public void SetupRenderCallback()
        {
            using (Stream stream = typeof(NodeHostedNunjucks).Assembly.GetManifestResourceStream("Jatana.Mvc.Js.nunjucks.js"))
            {
                if (stream == null)
                    throw new NullReferenceException("Missing nunjucks render script");

                using (StreamReader reader = new StreamReader(stream))
                {
                    string nunjucksScript = reader.ReadToEnd();

                    _renderer = Edge.Func(nunjucksScript);
                }
            }
        }

        public override string Render<T>(string template, T model)
        {
            var output = _renderer(new { template, model }).Result;

             if (output == null)
                throw new ApplicationException("Nunjucks render failed");

            return output.ToString();
        }
    }
}