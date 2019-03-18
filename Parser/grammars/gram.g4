grammar gram;

@lexer::members {
	public static int TEST = 2;
}

/*
 * Parser Rules
 */

compileUnit
	:	block* EOF
	;

block
	:	'{' ( block | stmt ) (',' ( block | stmt ))* '}'
	;

stmt
	:	'(' stmt ')'			# stmt_paren
	|	stmt '+' stmt			# stmt_plus
	|	stmt '-' stmt			# stmt_minus
	|	ID						# stmt_id
	|	INT						# stmt_int
	;

/*
 * Lexer Rules
 */

INT		:	[0-9]+ ;
ID		:	[a-zA-Z_][a-zA-Z0-9_]* ;
CBLOCK	:	'/*' .*? '*/' -> channel(HIDDEN) ;
CINLINE	:	'//' ~'\n'* -> channel(HIDDEN) ;
WS		:	[ \r\n\t]+ -> channel(TEST) ;
