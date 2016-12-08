// Signature file for parser generated by fsyacc
module Parser
type token = 
  | DECR
  | LPAREN
  | RPAREN
  | WHILE
  | DO
  | END
  | BEGIN
  | IF
  | THEN
  | ELSE
  | PRINT
  | SEMI
  | ASSIGN
  | EOF
  | FLOAT of (System.Double)
  | INT of (System.Int32)
  | ID of (string)
type tokenId = 
    | TOKEN_DECR
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_WHILE
    | TOKEN_DO
    | TOKEN_END
    | TOKEN_BEGIN
    | TOKEN_IF
    | TOKEN_THEN
    | TOKEN_ELSE
    | TOKEN_PRINT
    | TOKEN_SEMI
    | TOKEN_ASSIGN
    | TOKEN_EOF
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_Prog
    | NONTERM_Expr
    | NONTERM_Stmt
    | NONTERM_StmtList
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Ast.Prog ) 
