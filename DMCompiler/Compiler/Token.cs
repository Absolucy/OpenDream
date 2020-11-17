﻿namespace DMCompiler.Compiler {
    enum TokenType {
        //Base lexer
        Error,
        Newline,
        EndOfFile,
        Unknown,
        Skip, //Internally skipped by the lexer

        //DM
        DM_And,
        DM_AndAnd,
        DM_AndEquals,
        DM_As,
        DM_Bar,
        DM_BarBar,
        DM_BarEquals,
        DM_Break,
        DM_Call,
        DM_Colon,
        DM_Comma,
        DM_Continue,
        DM_Dedent,
        DM_Del,
        DM_Else,
        DM_Equals,
        DM_EqualsEquals,
        DM_Exclamation,
        DM_ExclamationEquals,
        DM_Float,
        DM_For,
        DM_GreaterThan,
        DM_GreaterThanEquals,
        DM_Identifier,
        DM_If,
        DM_In,
        DM_Indent,
        DM_RightShift,
        DM_Integer,
        DM_LeftBracket,
        DM_LeftCurlyBracket,
        DM_LeftParenthesis,
        DM_LessThan,
        DM_LessThanEquals,
        DM_List,
        DM_Minus,
        DM_MinusEquals,
        DM_MinusMinus,
        DM_Modulus,
        DM_ModulusEquals,
        DM_New,
        DM_Null,
        DM_LeftShift,
        DM_Period,
        DM_Plus,
        DM_PlusEquals,
        DM_PlusPlus,
        DM_Proc,
        DM_Question,
        DM_Resource,
        DM_Return,
        DM_RightBracket,
        DM_RightCurlyBracket,
        DM_RightParenthesis,
        DM_Semicolon,
        DM_Set,
        DM_Slash,
        DM_SlashEquals,
        DM_Spawn,
        DM_Star,
        DM_StarEquals,
        DM_String,
        DM_SuperProc,
        DM_Switch,
        DM_Tilde,
        DM_TildeEquals,
        DM_To,
        DM_Var,
        DM_While,
        DM_Xor,
        DM_XorEquals
    }

    struct Token {
        public TokenType Type;
        public string Text;
        public int Line, Column;
        public object Value;

        public Token(TokenType type, string text, int line, int column, object value) {
            Type = type;
            Text = text;
            Line = line;
            Column = column;
            Value = value;
        }
    }
}