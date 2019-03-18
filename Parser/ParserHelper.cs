using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Parser.grammars;

namespace Parser
{
    public class ParserHelper
    {
        public static string GetOwnText(string filename)
        {
            var afs = new AntlrFileStream(filename);
            var lexer = new gramLexer(afs);
            var ts = new UnbufferedTokenStream(lexer);
            var parser = new gramParser(ts);
            var tree = parser.compileUnit();
            var source = tree.GetText();
            return source;
        }

        public static string GetRules(string code)
        {
            var ais = new AntlrInputStream(code);
            //var lexer = new gramLexer(ais);
            var lexer = new SASLibnamesLexer(ais);
            var ts = new UnbufferedTokenStream(lexer);
            //var parser = new gramParser(ts);
            var parser = new SASLibnamesParser(ts);
            //var tree = parser.compileUnit();
            var tree = parser.program();

            var listener = new BaseListener<SASLibnamesParser>();
            var walker = new ParseTreeWalker();
            walker.Walk(listener, tree);
            return listener.GetRules();
        }
    }
}
