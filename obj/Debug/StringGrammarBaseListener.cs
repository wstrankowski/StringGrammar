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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IStringGrammarListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public partial class StringGrammarBaseListener : IStringGrammarListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>con_diff</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCon_diff([NotNull] StringGrammarParser.Con_diffContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>con_diff</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCon_diff([NotNull] StringGrammarParser.Con_diffContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] StringGrammarParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] StringGrammarParser.StringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>shift</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShift([NotNull] StringGrammarParser.ShiftContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>shift</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShift([NotNull] StringGrammarParser.ShiftContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>case</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase([NotNull] StringGrammarParser.CaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>case</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase([NotNull] StringGrammarParser.CaseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>substring</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubstring([NotNull] StringGrammarParser.SubstringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>substring</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubstring([NotNull] StringGrammarParser.SubstringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>brackets</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBrackets([NotNull] StringGrammarParser.BracketsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>brackets</c>
	/// labeled alternative in <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBrackets([NotNull] StringGrammarParser.BracketsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="StringGrammarParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] StringGrammarParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="StringGrammarParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] StringGrammarParser.ProgContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] StringGrammarParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="StringGrammarParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] StringGrammarParser.ExpressionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace StringGrammar
