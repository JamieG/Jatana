using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatana
{
    public class Token
    {
        public TokenType Type { get; }
        public string Value { get; }
        public int LineNo { get; }
        public int ColNo { get; }

        public Token(TokenType type, string value, int lineNo, int colNo)
        {
            Type = type;
            Value = value;
            LineNo = lineNo;
            ColNo = colNo;
        }
    }

    public enum TokenType
    {
        String,
        Whitespace,
        Data,
        BlockStart,
        BlockEnd,
        VariableStart,
        VariableEnd,
        Comment,
        LeftParen,
        RightParen,
        LeftBracket,
        RightBracket,
        LeftCurly,
        RightCurly,
        Operator,
        Comma,
        Colon,
        Tilde,
        Pipe,
        Int,
        Float,
        Boolean,
        None,
        Symbol,
        Special,
        Regex
    }
}
