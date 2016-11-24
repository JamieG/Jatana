using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatana
{
    public class Tokeniser
    {
        private readonly TextReader _reader;

        public Tokeniser(TextReader reader)
        {
            _reader = reader;
        }

        public IEnumerable<Token> Read()
        {
            int readChar = _reader.Read();

            bool inTag = false;

            do
            {
                char current = (char)readChar;

                if (char.IsWhiteSpace(current))
                {
                    yield return new Token(TokenType.Whitespace, current + ReadWhile(char.IsWhiteSpace), 0, 0);
                }
                else if (!inTag && current == '{')
                {
                    
                }


            } while ((readChar = _reader.Read()) != -1);
        }

        private string ReadWhile(Func<char, bool> condition = null)
        {
            StringBuilder extract = new StringBuilder();

            char current;

            do
            {
                int readChar = _reader.Read();

                if (readChar == -1)
                {
                    break;
                }

                current = (char)readChar;

            } while (condition == null || condition(current));

            return extract.ToString();
        }
    }
}