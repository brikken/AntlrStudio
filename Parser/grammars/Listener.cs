using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Parser.grammars
{
    class BaseListener<T> : IParseTreeListener where T : Antlr4.Runtime.Parser, new()
    {
        private StringBuilder sb = new StringBuilder();

        public void EnterEveryRule([NotNull] ParserRuleContext context)
        {
            T dummy = new T();
            sb.AppendLine($"I'm a {dummy.RuleNames[context.RuleIndex]} ({context.GetType().Name}) and I'm running from {context.Start.StartIndex} to {context.Stop.StopIndex}");
        }

        public void ExitEveryRule([NotNull] ParserRuleContext ctx)
        {
        }

        public string GetRules()
        {
            return sb.ToString();
        }

        public void VisitErrorNode([NotNull] IErrorNode node)
        {
        }

        public void VisitTerminal([NotNull] ITerminalNode node)
        {
        }
    }
}
