using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jatana.Test
{
    [TestClass]
    public class TokeniserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var stream = File.OpenRead(@"Templates\Basic.njk"))
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                var tokeniser = new Tokeniser(reader);

                foreach (Token token in tokeniser.Read())
                {
                    
                }
             
            }
        }
    }
}
