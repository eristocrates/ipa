#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sql =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ast/sql#" "sql"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Abstract class subsumed by all AST node classes.</para>
    ///   <para>rdfs:label : Generic AST Node</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ASTNode">sql:ASTNode</a>
    /// </summary>
    let ASTNode = _prefixId.prefix "ASTNode"
    /// <summary>
    ///   <para>rdfs:comment : A SQL access control statement.</para>
    ///   <para>rdfs:label : Access Control Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#AccessControlStatement">sql:AccessControlStatement</a>
    /// </summary>
    let AccessControlStatement = _prefixId.prefix "AccessControlStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL aggregate function returns a single value given the values of multiple rows from a column.</para>
    ///   <para>rdfs:label : Aggregate Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#AggregateFunction">sql:AggregateFunction</a>
    /// </summary>
    let AggregateFunction = _prefixId.prefix "AggregateFunction"
    /// <summary>
    ///   <para>rdfs:comment : A SQL aggregation expression consists in the use of an aggregate function.</para>
    ///   <para>rdfs:label : Aggregation Expression</para>
    ///   <a href="http://ns.inria.fr/ast/sql#AggregationExpression">sql:AggregationExpression</a>
    /// </summary>
    let AggregationExpression = _prefixId.prefix "AggregationExpression"
    /// <summary>
    ///   <para>rdfs:comment : The SQL AS operator used to give an identifier to an expression.</para>
    ///   <para>rdfs:label : Alias</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Alias">sql:Alias</a>
    /// </summary>
    let Alias = _prefixId.prefix "Alias"
    /// <summary>
    ///   <para>rdfs:comment : The SQL '*' wildcard operator, substitutes to all the columns of the tables in the FROM clause.</para>
    ///   <para>rdfs:label : All</para>
    ///   <a href="http://ns.inria.fr/ast/sql#All">sql:All</a>
    /// </summary>
    let All = _prefixId.prefix "All"
    /// <summary>
    ///   <para>rdfs:comment : A SQL ALTER statement.</para>
    ///   <para>rdfs:label : Alter Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#AlterStatement">sql:AlterStatement</a>
    /// </summary>
    let AlterStatement = _prefixId.prefix "AlterStatement"
    /// <summary>
    ///   <para>rdfs:label : Logical Conjunction</para>
    ///   <a href="http://ns.inria.fr/ast/sql#And">sql:And</a>
    /// </summary>
    let And = _prefixId.prefix "And"
    /// <summary>
    ///   <para>rdfs:comment : A SQL arithmetic operator used to perform arithmetic calculation.</para>
    ///   <para>rdfs:label : Arithmetic Operator</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ArithmeticOperator">sql:ArithmeticOperator</a>
    /// </summary>
    let ArithmeticOperator = _prefixId.prefix "ArithmeticOperator"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the mean of the given expression.</para>
    ///   <para>rdfs:label : Average</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Avg">sql:Avg</a>
    /// </summary>
    let Avg = _prefixId.prefix "Avg"
    /// <summary>
    ///   <para>rdfs:comment : Ternary predicate used to assert whether a provided expression's value is within the range specified by two other expressions' values.</para>
    ///   <para>rdfs:label : Range predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Between">sql:Between</a>
    /// </summary>
    let Between = _prefixId.prefix "Between"
    /// <summary>
    ///   <para>rdfs:comment : A SQL CALL statement.</para>
    ///   <para>rdfs:label : Call Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#CallStatement">sql:CallStatement</a>
    /// </summary>
    let CallStatement = _prefixId.prefix "CallStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL case expression enables the use of the IF &lt;condition&gt; THEN &lt;consequent&gt; ELSE &lt;alternative&gt; logic within SQL statements.</para>
    ///   <para>rdfs:label : Case Expression</para>
    ///   <a href="http://ns.inria.fr/ast/sql#CaseExpression">sql:CaseExpression</a>
    /// </summary>
    let CaseExpression = _prefixId.prefix "CaseExpression"
    /// <summary>
    ///   <para>rdfs:comment : A SQL scalar function that converts an expression to a target data type</para>
    ///   <para>rdfs:label : Cast</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Cast">sql:Cast</a>
    /// </summary>
    let Cast = _prefixId.prefix "Cast"
    /// <summary>
    ///   <para>rdfs:comment : A database catalog object reference.</para>
    ///   <para>rdfs:label : Database Catalog Object</para>
    ///   <a href="http://ns.inria.fr/ast/sql#CatalogObject">sql:CatalogObject</a>
    /// </summary>
    let CatalogObject = _prefixId.prefix "CatalogObject"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog column.</para>
    ///   <para>rdfs:label : Relational Column</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Column">sql:Column</a>
    /// </summary>
    let Column = _prefixId.prefix "Column"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog column.</para>
    ///   <para>rdfs:label : Column Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ColumnIdentifier">sql:ColumnIdentifier</a>
    /// </summary>
    let ColumnIdentifier = _prefixId.prefix "ColumnIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : A SQL COMMIT statement.</para>
    ///   <para>rdfs:label : Commit Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#CommitStatement">sql:CommitStatement</a>
    /// </summary>
    let CommitStatement = _prefixId.prefix "CommitStatement"
    /// <summary>
    ///   <para>rdfs:comment : A binary operator used to compare two values, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.</para>
    ///   <para>rdfs:label : Comparison Operator</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ComparisonOperator">sql:ComparisonOperator</a>
    /// </summary>
    let ComparisonOperator = _prefixId.prefix "ComparisonOperator"
    /// <summary>
    ///   <para>rdfs:comment : A SQL concatenation operator that returns the combination of two strings, expressions or values.</para>
    ///   <para>rdfs:label : Concatenation</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Concatenation">sql:Concatenation</a>
    /// </summary>
    let Concatenation = _prefixId.prefix "Concatenation"
    /// <summary>
    ///   <para>rdfs:comment : A SQL CONNECT statement.</para>
    ///   <para>rdfs:label : Connect Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ConnectStatement">sql:ConnectStatement</a>
    /// </summary>
    let ConnectStatement = _prefixId.prefix "ConnectStatement"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the number of rows or non NULL values from the result set.</para>
    ///   <para>rdfs:label : Count</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Count">sql:Count</a>
    /// </summary>
    let Count = _prefixId.prefix "Count"
    /// <summary>
    ///   <para>rdfs:comment : A SQL CREATE statement.</para>
    ///   <para>rdfs:label : Create Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#CreateStatement">sql:CreateStatement</a>
    /// </summary>
    let CreateStatement = _prefixId.prefix "CreateStatement"
    /// <summary>
    ///   <para>rdfs:comment : Join predicate used to perform the cross-product of two tables.</para>
    ///   <para>rdfs:label : Cross Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#CrossJoin">sql:CrossJoin</a>
    /// </summary>
    let CrossJoin = _prefixId.prefix "CrossJoin"
    /// <summary>
    ///   <para>rdfs:comment : A SQL data definition statement.</para>
    ///   <para>rdfs:label : Data Definition Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#DataDefinitionStatement">sql:DataDefinitionStatement</a>
    /// </summary>
    let DataDefinitionStatement = _prefixId.prefix "DataDefinitionStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL data manipulation statement.</para>
    ///   <para>rdfs:label : Data Manipulation Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#DataManipulationStatement">sql:DataManipulationStatement</a>
    /// </summary>
    let DataManipulationStatement = _prefixId.prefix "DataManipulationStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL scalar function.</para>
    ///   <para>rdfs:label : Data Type Conversion Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#DataTypeConversionFunction">sql:DataTypeConversionFunction</a>
    /// </summary>
    let DataTypeConversionFunction = _prefixId.prefix "DataTypeConversionFunction"
    /// <summary>
    ///   <para>rdfs:comment : A SQL date time function returns a date or time value or performs a specific date or time value computation.</para>
    ///   <para>rdfs:label : Date Time Computation Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#DateTimeFunction">sql:DateTimeFunction</a>
    /// </summary>
    let DateTimeFunction = _prefixId.prefix "DateTimeFunction"
    /// <summary>
    ///   <para>rdfs:comment : A SQL DELETE statement.</para>
    ///   <para>rdfs:label : Delete Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#DeleteStatement">sql:DeleteStatement</a>
    /// </summary>
    let DeleteStatement = _prefixId.prefix "DeleteStatement"
    /// <summary>
    ///   <para>rdfs:label : Division</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Div">sql:Div</a>
    /// </summary>
    let Div = _prefixId.prefix "Div"
    /// <summary>
    ///   <para>rdfs:comment : A SQL DROP statement.</para>
    ///   <para>rdfs:label : Drop Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#DropStatement">sql:DropStatement</a>
    /// </summary>
    let DropStatement = _prefixId.prefix "DropStatement"
    /// <summary>
    ///   <para>rdfs:label : Equality comparison</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Equals">sql:Equals</a>
    /// </summary>
    let Equals = _prefixId.prefix "Equals"
    /// <summary>
    ///   <para>rdfs:comment : A SQL exclusion operator used to return the result set produced by removing the result rows of the second query that appear in the result set of the first query.</para>
    ///   <para>rdfs:label : Exclusion</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Except">sql:Except</a>
    /// </summary>
    let Except = _prefixId.prefix "Except"
    /// <summary>
    ///   <para>rdfs:comment : Unary predicate that returns one of the TRUE or FALSE truth values depending on whether the evaluated subquery returns an empty result set.</para>
    ///   <para>rdfs:label : Exists predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Exists">sql:Exists</a>
    /// </summary>
    let Exists = _prefixId.prefix "Exists"
    /// <summary>
    ///   <para>rdfs:comment : A SQL expression denotes any clause that when evaluated returns values.</para>
    ///   <para>rdfs:label : Expression</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Expression">sql:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:label : Full Outer Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#FullOuterJoin">sql:FullOuterJoin</a>
    /// </summary>
    let FullOuterJoin = _prefixId.prefix "FullOuterJoin"
    /// <summary>
    ///   <para>rdfs:comment : A SQL built-in function that performs calculation and returns a value. May be vendor-specific.</para>
    ///   <para>rdfs:label : Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Function">sql:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>rdfs:comment : A SQL function expressions consists in the use of any built-in SQL function.</para>
    ///   <para>rdfs:label : Function Expression</para>
    ///   <a href="http://ns.inria.fr/ast/sql#FunctionExpression">sql:FunctionExpression</a>
    /// </summary>
    let FunctionExpression = _prefixId.prefix "FunctionExpression"
    /// <summary>
    ///   <para>rdfs:comment : A SQL GRANT statement used to give a set of privileges or roles to specified users that are actionable on specified database objects.</para>
    ///   <para>rdfs:label : Grant Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Grant">sql:Grant</a>
    /// </summary>
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>rdfs:label : Greater than or equal to comparison</para>
    ///   <a href="http://ns.inria.fr/ast/sql#GreaterEquals">sql:GreaterEquals</a>
    /// </summary>
    let GreaterEquals = _prefixId.prefix "GreaterEquals"
    /// <summary>
    ///   <para>rdfs:label : Greater than comparison</para>
    ///   <a href="http://ns.inria.fr/ast/sql#GreaterThan">sql:GreaterThan</a>
    /// </summary>
    let GreaterThan = _prefixId.prefix "GreaterThan"
    /// <summary>
    ///   <para>rdfs:comment : A SQL import or export statement.</para>
    ///   <para>rdfs:label : Import / Export Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#IOStatement">sql:IOStatement</a>
    /// </summary>
    let IOStatement = _prefixId.prefix "IOStatement"
    /// <summary>
    ///   <para>rdfs:comment : Variadic predicate used to assert whether the first provided expression's value is within the set of following provided expressions' values.</para>
    ///   <para>rdfs:label : In predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#In">sql:In</a>
    /// </summary>
    let In = _prefixId.prefix "In"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog index.</para>
    ///   <para>rdfs:label : Relational Index</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Index">sql:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog index.</para>
    ///   <para>rdfs:label : Index Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#IndexIdentifier">sql:IndexIdentifier</a>
    /// </summary>
    let IndexIdentifier = _prefixId.prefix "IndexIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Inner Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#InnerJoin">sql:InnerJoin</a>
    /// </summary>
    let InnerJoin = _prefixId.prefix "InnerJoin"
    /// <summary>
    ///   <para>rdfs:comment : A SQL INSERT statement.</para>
    ///   <para>rdfs:label : Insert Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#InsertStatement">sql:InsertStatement</a>
    /// </summary>
    let InsertStatement = _prefixId.prefix "InsertStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL intersection operator used to return the common result rows of the combination of the result sets of two or more queries.</para>
    ///   <para>rdfs:label : Intersection</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Intersect">sql:Intersect</a>
    /// </summary>
    let Intersect = _prefixId.prefix "Intersect"
    /// <summary>
    ///   <para>rdfs:comment : Unary predicate that compares the evaluated expression's value with NULL</para>
    ///   <para>rdfs:label : Is Null predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#IsNull">sql:IsNull</a>
    /// </summary>
    let IsNull = _prefixId.prefix "IsNull"
    /// <summary>
    ///   <para>rdfs:comment : Binary predicate used join two or more tables.</para>
    ///   <para>rdfs:label : Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#JoinPredicate">sql:JoinPredicate</a>
    /// </summary>
    let JoinPredicate = _prefixId.prefix "JoinPredicate"
    /// <summary>
    ///   <para>rdfs:label : Left Outer Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#LeftOuterJoin">sql:LeftOuterJoin</a>
    /// </summary>
    let LeftOuterJoin = _prefixId.prefix "LeftOuterJoin"
    /// <summary>
    ///   <para>rdfs:label : Less than or equal to comparison</para>
    ///   <a href="http://ns.inria.fr/ast/sql#LessEquals">sql:LessEquals</a>
    /// </summary>
    let LessEquals = _prefixId.prefix "LessEquals"
    /// <summary>
    ///   <para>rdfs:label : Less than comparison</para>
    ///   <a href="http://ns.inria.fr/ast/sql#LessThan">sql:LessThan</a>
    /// </summary>
    let LessThan = _prefixId.prefix "LessThan"
    /// <summary>
    ///   <para>rdfs:comment : Binary predicate that returns one of the TRUE or FALSE truth values depending on whether the string resulting in the evaluation of the first expression matches the lightweight regular expression described in the second expression.</para>
    ///   <para>rdfs:label : Like predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Like">sql:Like</a>
    /// </summary>
    let Like = _prefixId.prefix "Like"
    /// <summary>
    ///   <para>rdfs:comment : A SQL LOCK TABLE statement.</para>
    ///   <para>rdfs:label : Lock Table Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#LockTableStatement">sql:LockTableStatement</a>
    /// </summary>
    let LockTableStatement = _prefixId.prefix "LockTableStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL logical connective used to perform logical calculation.</para>
    ///   <para>rdfs:label : Logical Operator</para>
    ///   <a href="http://ns.inria.fr/ast/sql#LogicalOperator">sql:LogicalOperator</a>
    /// </summary>
    let LogicalOperator = _prefixId.prefix "LogicalOperator"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the maximum value of the given expression.</para>
    ///   <para>rdfs:label : Maximum</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Max">sql:Max</a>
    /// </summary>
    let Max = _prefixId.prefix "Max"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the minimum value of the given expression.</para>
    ///   <para>rdfs:label : Minimum</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Min">sql:Min</a>
    /// </summary>
    let Min = _prefixId.prefix "Min"
    /// <summary>
    ///   <para>rdfs:label : Subtraction</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Minus">sql:Minus</a>
    /// </summary>
    let Minus = _prefixId.prefix "Minus"
    /// <summary>
    ///   <para>rdfs:label : Multiplication</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Mult">sql:Mult</a>
    /// </summary>
    let Mult = _prefixId.prefix "Mult"
    /// <summary>
    ///   <para>rdfs:comment : A unary arithmetic operator used to produce the negative of its operand.</para>
    ///   <para>rdfs:label : Negation</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Negate">sql:Negate</a>
    /// </summary>
    let Negate = _prefixId.prefix "Negate"
    /// <summary>
    ///   <para>rdfs:comment : A SQL logical negation that can be used to negate any condition.</para>
    ///   <para>rdfs:label : Logical Negation</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Not">sql:Not</a>
    /// </summary>
    let Not = _prefixId.prefix "Not"
    /// <summary>
    ///   <para>rdfs:label : Difference comparison</para>
    ///   <a href="http://ns.inria.fr/ast/sql#NotEquals">sql:NotEquals</a>
    /// </summary>
    let NotEquals = _prefixId.prefix "NotEquals"
    /// <summary>
    ///   <para>rdfs:comment : A SQL now function is a nullary function that returns the current timestamp.</para>
    ///   <para>rdfs:label : Now</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Now">sql:Now</a>
    /// </summary>
    let Now = _prefixId.prefix "Now"
    /// <summary>
    ///   <para>rdfs:comment : A SQL number function that returns a numeric value and reads numeric values or string with numeric characters.</para>
    ///   <para>rdfs:label : Number Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#NumberFunction">sql:NumberFunction</a>
    /// </summary>
    let NumberFunction = _prefixId.prefix "NumberFunction"
    /// <summary>
    ///   <para>rdfs:comment : A database catalog object identifier, qualified or not.</para>
    ///   <para>rdfs:label : Database Catalog Object Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ObjectIdentifier">sql:ObjectIdentifier</a>
    /// </summary>
    let ObjectIdentifier = _prefixId.prefix "ObjectIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : A SQL operator used to perform arithmetic calculations, comparisons or value assignments.</para>
    ///   <para>rdfs:label : Operator</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Operator">sql:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>rdfs:label : Logical Disjunction</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Or">sql:Or</a>
    /// </summary>
    let Or = _prefixId.prefix "Or"
    /// <summary>
    ///   <para>rdfs:label : Outer Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#OuterJoin">sql:OuterJoin</a>
    /// </summary>
    let OuterJoin = _prefixId.prefix "OuterJoin"
    /// <summary>
    ///   <para>rdfs:label : Addition</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Plus">sql:Plus</a>
    /// </summary>
    let Plus = _prefixId.prefix "Plus"
    /// <summary>
    ///   <para>rdfs:comment : Represents a collection of one or more expressions or subqueries, that may be combined with logical operators, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.</para>
    ///   <para>rdfs:label : Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Predicate">sql:Predicate</a>
    /// </summary>
    let Predicate = _prefixId.prefix "Predicate"
    /// <summary>
    ///   <para>rdfs:comment : A SQL procedural statement.</para>
    ///   <para>rdfs:label : Procedural Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ProceduralStatement">sql:ProceduralStatement</a>
    /// </summary>
    let ProceduralStatement = _prefixId.prefix "ProceduralStatement"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog procedure.</para>
    ///   <para>rdfs:label : Relational Procedure</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Procedure">sql:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog procedure.</para>
    ///   <para>rdfs:label : Procedure Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ProcedureIdentifier">sql:ProcedureIdentifier</a>
    /// </summary>
    let ProcedureIdentifier = _prefixId.prefix "ProcedureIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : A SQL REVOKE statement used to revoke a set of privileges or roles to specified users from specified database objects.</para>
    ///   <para>rdfs:label : Revoke Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Revoke">sql:Revoke</a>
    /// </summary>
    let Revoke = _prefixId.prefix "Revoke"
    /// <summary>
    ///   <para>rdfs:label : Right Outer Join Predicate</para>
    ///   <a href="http://ns.inria.fr/ast/sql#RightOuterJoin">sql:RightOuterJoin</a>
    /// </summary>
    let RightOuterJoin = _prefixId.prefix "RightOuterJoin"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog role.</para>
    ///   <para>rdfs:label : Relational Role</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Role">sql:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog role.</para>
    ///   <para>rdfs:label : Role Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#RoleIdentifier">sql:RoleIdentifier</a>
    /// </summary>
    let RoleIdentifier = _prefixId.prefix "RoleIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : A SQL ROLLBACK statement.</para>
    ///   <para>rdfs:label : Rollback Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#RollbackStatement">sql:RollbackStatement</a>
    /// </summary>
    let RollbackStatement = _prefixId.prefix "RollbackStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL scalar function returns a single value given the input values. The input value is of a SQL primitive data type.</para>
    ///   <para>rdfs:label : Scalar Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ScalarFunction">sql:ScalarFunction</a>
    /// </summary>
    let ScalarFunction = _prefixId.prefix "ScalarFunction"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog schema.</para>
    ///   <para>rdfs:label : Relational Schema</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Schema">sql:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog schema.</para>
    ///   <para>rdfs:label : Schema Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#SchemaIdentifier">sql:SchemaIdentifier</a>
    /// </summary>
    let SchemaIdentifier = _prefixId.prefix "SchemaIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : A SQL SELECT statement.</para>
    ///   <para>rdfs:label : Select Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#SelectStatement">sql:SelectStatement</a>
    /// </summary>
    let SelectStatement = _prefixId.prefix "SelectStatement"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog sequence.</para>
    ///   <para>rdfs:label : Relational Sequence</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Sequence">sql:Sequence</a>
    /// </summary>
    let Sequence = _prefixId.prefix "Sequence"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog sequence.</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#SequenceIdentifier">sql:SequenceIdentifier</a>
    /// </summary>
    let SequenceIdentifier = _prefixId.prefix "SequenceIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : A SQL session management statement.</para>
    ///   <para>rdfs:label : Session Management Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#SessionManagementStatement">sql:SessionManagementStatement</a>
    /// </summary>
    let SessionManagementStatement = _prefixId.prefix "SessionManagementStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL set operator used to perform set operation on the results of two or more queries.</para>
    ///   <para>rdfs:label : Set Operator</para>
    ///   <a href="http://ns.inria.fr/ast/sql#SetOperator">sql:SetOperator</a>
    /// </summary>
    let SetOperator = _prefixId.prefix "SetOperator"
    /// <summary>
    ///   <para>rdfs:comment : Assigns a value to a session variable identifier.</para>
    ///   <para>rdfs:label : Set Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#SetStatement">sql:SetStatement</a>
    /// </summary>
    let SetStatement = _prefixId.prefix "SetStatement"
    /// <summary>
    ///   <para>rdfs:comment : A SQL statement.</para>
    ///   <para>rdfs:label : Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Statement">sql:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the standard deviation (square root of the variance) of the given expression.</para>
    ///   <para>rdfs:label : Standard Deviation</para>
    ///   <a href="http://ns.inria.fr/ast/sql#StdDev">sql:StdDev</a>
    /// </summary>
    let StdDev = _prefixId.prefix "StdDev"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : String Operator</para>
    ///   <a href="http://ns.inria.fr/ast/sql#StringOperator">sql:StringOperator</a>
    /// </summary>
    let StringOperator = _prefixId.prefix "StringOperator"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the sum of the given expression.</para>
    ///   <para>rdfs:label : Sum</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Sum">sql:Sum</a>
    /// </summary>
    let Sum = _prefixId.prefix "Sum"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog table.</para>
    ///   <para>rdfs:label : Relational Table</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Table">sql:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:comment : A SQL function that returns a virtual table.</para>
    ///   <para>rdfs:label : Table Function</para>
    ///   <a href="http://ns.inria.fr/ast/sql#TableFunction">sql:TableFunction</a>
    /// </summary>
    let TableFunction = _prefixId.prefix "TableFunction"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog table.</para>
    ///   <para>rdfs:label : Table Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#TableIdentifier">sql:TableIdentifier</a>
    /// </summary>
    let TableIdentifier = _prefixId.prefix "TableIdentifier"

    /// <summary>
    ///   <para>rdfs:comment : A SQL transaction management statement.</para>
    ///   <para>rdfs:label : Transaction Management Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#TransactionManagementStatement">sql:TransactionManagementStatement</a>
    /// </summary>
    let TransactionManagementStatement =
        _prefixId.prefix "TransactionManagementStatement"

    /// <summary>
    ///   <para>rdfs:comment : A SQL union operator used to return the combination of the result sets of two or more queries.</para>
    ///   <para>rdfs:label : Union</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Union">sql:Union</a>
    /// </summary>
    let Union = _prefixId.prefix "Union"
    /// <summary>
    ///   <para>rdfs:comment : A SQL union operator used to return the combination of the result sets of two or more queries, including duplicate result rows.</para>
    ///   <para>rdfs:label : Union All</para>
    ///   <a href="http://ns.inria.fr/ast/sql#UnionAll">sql:UnionAll</a>
    /// </summary>
    let UnionAll = _prefixId.prefix "UnionAll"
    /// <summary>
    ///   <para>rdfs:comment : A SQL UPDATE statement.</para>
    ///   <para>rdfs:label : Update Statement</para>
    ///   <a href="http://ns.inria.fr/ast/sql#UpdateStatement">sql:UpdateStatement</a>
    /// </summary>
    let UpdateStatement = _prefixId.prefix "UpdateStatement"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog user.</para>
    ///   <para>rdfs:label : Relational User</para>
    ///   <a href="http://ns.inria.fr/ast/sql#User">sql:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog user.</para>
    ///   <para>rdfs:label : User Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#UserIdentifier">sql:UserIdentifier</a>
    /// </summary>
    let UserIdentifier = _prefixId.prefix "UserIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The SQL aggregate function that returns the variance of the given expression.</para>
    ///   <para>rdfs:label : Variance</para>
    ///   <a href="http://ns.inria.fr/ast/sql#Var">sql:Var</a>
    /// </summary>
    let Var = _prefixId.prefix "Var"
    /// <summary>
    ///   <para>rdfs:comment : A reference or declarative statement for a catalog view.</para>
    ///   <para>rdfs:label : Relational View</para>
    ///   <a href="http://ns.inria.fr/ast/sql#View">sql:View</a>
    /// </summary>
    let View = _prefixId.prefix "View"
    /// <summary>
    ///   <para>rdfs:comment : A valid identifier for a catalog view.</para>
    ///   <para>rdfs:label : View Identifier</para>
    ///   <a href="http://ns.inria.fr/ast/sql#ViewIdentifier">sql:ViewIdentifier</a>
    /// </summary>
    let ViewIdentifier = _prefixId.prefix "ViewIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The generic predicate used to attach an ordered list of children to any AST node.</para>
    ///   <para>rdfs:label : AST Node Arguments</para>
    ///   <a href="http://ns.inria.fr/ast/sql#args">sql:args</a>
    /// </summary>
    let args = _prefixId.prefix "args"
    /// <summary>
    ///   <para>rdfs:comment : A SQL clause is a part of a statement.</para>
    ///   <para>rdfs:label : Clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#clause">sql:clause</a>
    /// </summary>
    let clause = _prefixId.prefix "clause"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies the target sources (tables, views, subqueries) of a SELECT statement.</para>
    ///   <para>rdfs:label : FROM clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#from">sql:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies the columns whose values will be considered to cluster the result set of selected rows.</para>
    ///   <para>rdfs:label : GROUP BY clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#groupBy">sql:groupBy</a>
    /// </summary>
    let groupBy = _prefixId.prefix "groupBy"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies the filtering predicates to apply on the clustered result set resulting of a GROUP BY clause.</para>
    ///   <para>rdfs:label : HAVING clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#having">sql:having</a>
    /// </summary>
    let having = _prefixId.prefix "having"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies into which table the following values or select statement's result set are to be inserted into.</para>
    ///   <para>rdfs:label : INTO target table clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#into">sql:into</a>
    /// </summary>
    let into = _prefixId.prefix "into"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that limits the number of records from the result set that should be returned.</para>
    ///   <para>rdfs:label : LIMIT clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#limit">sql:limit</a>
    /// </summary>
    let limit = _prefixId.prefix "limit"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies how to order the result set's records according to given expressions.</para>
    ///   <para>rdfs:label : ORDER BY clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#orderBy">sql:orderBy</a>
    /// </summary>
    let orderBy = _prefixId.prefix "orderBy"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies the projected tables of a SELECT statement.</para>
    ///   <para>rdfs:label : SELECT clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#select">sql:select</a>
    /// </summary>
    let select = _prefixId.prefix "select"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies a list of values or expressions evaluating to values.</para>
    ///   <para>rdfs:label : VALUES list Clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#values">sql:values</a>
    /// </summary>
    let values = _prefixId.prefix "values"
    /// <summary>
    ///   <para>rdfs:comment : The SQL clause that specifies the filtering predicates to apply on the inputs of the FROM clause.</para>
    ///   <para>rdfs:label : WHERE clause</para>
    ///   <a href="http://ns.inria.fr/ast/sql#where">sql:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
