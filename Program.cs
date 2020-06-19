using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4;
using System.Globalization;
using Antlr4.Runtime.Tree;

namespace StringGrammar {
    class Program {
        static void Main(string[] args) {

            try {
                string input = "";
                StringBuilder text = new StringBuilder();
                Console.WriteLine("-----StringGrammar----- \n" +
                    "Ciag znakow: (ujety w cudyslow \"\") Przyklad: \"tekst\"\n" +
                    "Przesuniecie w lewo: '<' Przyklad: <2\"tekst\" \n" +
                    "Przesuniecie w prawo: '>' Przyklad: >2\"tekst\" \n" +
                    "Konkatencja: '+' Przyklad: \"tekst1\" + \"tekst2\" \n" +
                    "Roznica: '-' Przyklad: \"abce\" - \"ab\" \n" +
                    "Litery duze: '^' Przyklad: ^\"abc\" \n" +
                    "Litery male: '_' Przyklad: _\"ABC\" \n" +
                    "Podciag: '$' Przyklad: $2\"abcde\" lub $3,2\"abcde\" \n" +
                    "\n" +
                    "Podaj ciag (Ciag nalezy zakonczyc kombinacja 'CTRL+Z'):");

                while ((input = Console.ReadLine()) != null) {
                    text.AppendLine(input);
                }

                AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
                StringGrammarLexer lexer = new StringGrammarLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                StringGrammarParser parser = new StringGrammarParser(commonTokenStream)
                {
                    BuildParseTree = true
                };
                IParseTree tree = parser.prog();
                int errors = parser.NumberOfSyntaxErrors;
                Console.WriteLine("Liczba bledow syntaktycznych: " + errors);

                if (0 == errors) {
                    StringGrammarVisitor visitor = new StringGrammarVisitor();
                    if(TreeIsNotEmpty(tree))
                    {
                        var result = visitor.Visit(tree);
                        Console.WriteLine(tree.ToStringTree(parser));
                        Console.WriteLine("Wynik = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Nie podano żadnego ciągu znakowego");
                    }
                };

            } catch (Exception ex) {
                Console.WriteLine("Blad: " + ex);
            }
            Console.Read();
        }

        private static bool TreeIsNotEmpty(IParseTree tree)
        {
            return tree.ChildCount > 1;
        }
    }
}
