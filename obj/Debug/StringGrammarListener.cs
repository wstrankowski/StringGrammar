//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\WAT\JFK\StringGrammarJFK-master\StringGrammar\StringGrammar.g4 by ANTLR 4.6.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace StringGrammar {
#pragma warning disable 3021
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="StringGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public interface IStringGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>con_diff</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCon_diff([NotNull] StringGrammarParser.Con_diffContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>con_diff</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCon_diff([NotNull] StringGrammarParser.Con_diffContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] StringGrammarParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] StringGrammarParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>shift</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShift([NotNull] StringGrammarParser.ShiftContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>shift</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShift([NotNull] StringGrammarParser.ShiftContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>case</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase([NotNull] StringGrammarParser.CaseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>case</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase([NotNull] StringGrammarParser.CaseContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>substring</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubstring([NotNull] StringGrammarParser.SubstringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>substring</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubstring([NotNull] StringGrammarParser.SubstringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>brackets</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBrackets([NotNull] StringGrammarParser.BracketsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>brackets</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBrackets([NotNull] StringGrammarParser.BracketsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="StringGrammarParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] StringGrammarParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="StringGrammarParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] StringGrammarParser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] StringGrammarParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="StringGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] StringGrammarParser.ExpressionContext context);
}
} // namespace StringGrammar
