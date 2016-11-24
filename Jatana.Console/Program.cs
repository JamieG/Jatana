using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdgeJs;


namespace Jatana.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Start().Wait();

            System.Console.ReadKey();
        }

        public static async Task Start()
        {
            var func = Edge.Func(@"
                
                var nunjucks = require('nunjucks');

                return function (data, callback) {
                    
                    callback(null, 'Node.js welcomes ' + __dirname);
                }
            ");

            System.Console.WriteLine(await func(new { content =  ".NET"}));
        }
    }
}
