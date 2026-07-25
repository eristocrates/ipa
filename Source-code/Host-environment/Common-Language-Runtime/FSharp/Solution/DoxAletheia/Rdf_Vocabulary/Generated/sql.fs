namespace http.ns.inria.fr.ast.sql.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sql =
    let _namespace_iri = Namespace_Iri sql |> NamespaceIRI
    /// <summary>
    ///   <para>sql:ASTNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract class subsumed by all AST node classes.</para>
    /// labels<para>Generic AST Node</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ASTNode">http://ns.inria.fr/ast/sql#ASTNode</seealso>
    let ASTNode = Prefixed_Name(sql, "ASTNode") |> PrefixedName
    /// <summary>
    ///   <para>sql:AggregateFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL aggregate function returns a single value given the values of multiple rows from a column.</para>
    /// labels<para>Aggregate Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#AggregateFunction">http://ns.inria.fr/ast/sql#AggregateFunction</seealso>
    let AggregateFunction = Prefixed_Name(sql, "AggregateFunction") |> PrefixedName
    /// <summary>
    ///   <para>sql:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL built-in function that performs calculation and returns a value. May be vendor-specific.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Function">http://ns.inria.fr/ast/sql#Function</seealso>
    let Function = Prefixed_Name(sql, "Function") |> PrefixedName
    /// <summary>
    ///   <para>sql:Cast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL scalar function that converts an expression to a target data type</para>
    /// labels<para>Cast</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Cast">http://ns.inria.fr/ast/sql#Cast</seealso>
    let Cast = Prefixed_Name(sql, "Cast") |> PrefixedName
    /// <summary>
    ///   <para>sql:Column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog column.</para>
    /// labels<para>Relational Column</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Column">http://ns.inria.fr/ast/sql#Column</seealso>
    let Column = Prefixed_Name(sql, "Column") |> PrefixedName
    /// <summary>
    ///   <para>sql:CommitStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL COMMIT statement.</para>
    /// labels<para>Commit Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#CommitStatement">http://ns.inria.fr/ast/sql#CommitStatement</seealso>
    let CommitStatement = Prefixed_Name(sql, "CommitStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:TransactionManagementStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL transaction management statement.</para>
    /// labels<para>Transaction Management Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#TransactionManagementStatement">http://ns.inria.fr/ast/sql#TransactionManagementStatement</seealso>
    let TransactionManagementStatement =
        Prefixed_Name(sql, "TransactionManagementStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:StringOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para></para>
    /// labels<para>String Operator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#StringOperator">http://ns.inria.fr/ast/sql#StringOperator</seealso>
    let StringOperator = Prefixed_Name(sql, "StringOperator") |> PrefixedName
    /// <summary>
    ///   <para>sql:ConnectStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL CONNECT statement.</para>
    /// labels<para>Connect Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ConnectStatement">http://ns.inria.fr/ast/sql#ConnectStatement</seealso>
    let ConnectStatement = Prefixed_Name(sql, "ConnectStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the number of rows or non NULL values from the result set.</para>
    /// labels<para>Count</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Count">http://ns.inria.fr/ast/sql#Count</seealso>
    let Count = Prefixed_Name(sql, "Count") |> PrefixedName
    /// <summary>
    ///   <para>sql:CreateStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL CREATE statement.</para>
    /// labels<para>Create Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#CreateStatement">http://ns.inria.fr/ast/sql#CreateStatement</seealso>
    let CreateStatement = Prefixed_Name(sql, "CreateStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:RollbackStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL ROLLBACK statement.</para>
    /// labels<para>Rollback Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#RollbackStatement">http://ns.inria.fr/ast/sql#RollbackStatement</seealso>
    let RollbackStatement = Prefixed_Name(sql, "RollbackStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog sequence.</para>
    /// labels<para>Relational Sequence</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Sequence">http://ns.inria.fr/ast/sql#Sequence</seealso>
    let Sequence = Prefixed_Name(sql, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>sql:SequenceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog sequence.</para>
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#SequenceIdentifier">http://ns.inria.fr/ast/sql#SequenceIdentifier</seealso>
    let SequenceIdentifier = Prefixed_Name(sql, "SequenceIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:Sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the sum of the given expression.</para>
    /// labels<para>Sum</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Sum">http://ns.inria.fr/ast/sql#Sum</seealso>
    let Sum = Prefixed_Name(sql, "Sum") |> PrefixedName
    /// <summary>
    ///   <para>sql:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog table.</para>
    /// labels<para>Relational Table</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Table">http://ns.inria.fr/ast/sql#Table</seealso>
    let Table = Prefixed_Name(sql, "Table") |> PrefixedName
    /// <summary>
    ///   <para>sql:UpdateStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL UPDATE statement.</para>
    /// labels<para>Update Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#UpdateStatement">http://ns.inria.fr/ast/sql#UpdateStatement</seealso>
    let UpdateStatement = Prefixed_Name(sql, "UpdateStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog user.</para>
    /// labels<para>Relational User</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#User">http://ns.inria.fr/ast/sql#User</seealso>
    let User = Prefixed_Name(sql, "User") |> PrefixedName
    /// <summary>
    ///   <para>sql:UserIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog user.</para>
    /// labels<para>User Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#UserIdentifier">http://ns.inria.fr/ast/sql#UserIdentifier</seealso>
    let UserIdentifier = Prefixed_Name(sql, "UserIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:clause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A SQL clause is a part of a statement.</para>
    /// labels<para>Clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#clause">http://ns.inria.fr/ast/sql#clause</seealso>
    let clause = Prefixed_Name(sql, "clause") |> PrefixedName
    /// <summary>
    ///   <para>sql:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies the target sources (tables, views, subqueries) of a SELECT statement.</para>
    /// labels<para>FROM clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#from">http://ns.inria.fr/ast/sql#from</seealso>
    let from = Prefixed_Name(sql, "from") |> PrefixedName
    /// <summary>
    ///   <para>sql:LogicalOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL logical connective used to perform logical calculation.</para>
    /// labels<para>Logical Operator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#LogicalOperator">http://ns.inria.fr/ast/sql#LogicalOperator</seealso>
    let LogicalOperator = Prefixed_Name(sql, "LogicalOperator") |> PrefixedName
    /// <summary>
    ///   <para>sql:Predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a collection of one or more expressions or subqueries, that may be combined with logical operators, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.</para>
    /// labels<para>Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Predicate">http://ns.inria.fr/ast/sql#Predicate</seealso>
    let Predicate = Prefixed_Name(sql, "Predicate") |> PrefixedName
    /// <summary>
    ///   <para>sql:Except</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL exclusion operator used to return the result set produced by removing the result rows of the second query that appear in the result set of the first query.</para>
    /// labels<para>Exclusion</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Except">http://ns.inria.fr/ast/sql#Except</seealso>
    let Except = Prefixed_Name(sql, "Except") |> PrefixedName
    /// <summary>
    ///   <para>sql:FunctionExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL function expressions consists in the use of any built-in SQL function.</para>
    /// labels<para>Function Expression</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#FunctionExpression">http://ns.inria.fr/ast/sql#FunctionExpression</seealso>
    let FunctionExpression = Prefixed_Name(sql, "FunctionExpression") |> PrefixedName
    /// <summary>
    ///   <para>sql:GreaterEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Greater than or equal to comparison</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#GreaterEquals">http://ns.inria.fr/ast/sql#GreaterEquals</seealso>
    let GreaterEquals = Prefixed_Name(sql, "GreaterEquals") |> PrefixedName
    /// <summary>
    ///   <para>sql:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog index.</para>
    /// labels<para>Relational Index</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Index">http://ns.inria.fr/ast/sql#Index</seealso>
    let Index = Prefixed_Name(sql, "Index") |> PrefixedName
    /// <summary>
    ///   <para>sql:InnerJoin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Inner Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#InnerJoin">http://ns.inria.fr/ast/sql#InnerJoin</seealso>
    let InnerJoin = Prefixed_Name(sql, "InnerJoin") |> PrefixedName
    /// <summary>
    ///   <para>sql:Intersect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL intersection operator used to return the common result rows of the combination of the result sets of two or more queries.</para>
    /// labels<para>Intersection</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Intersect">http://ns.inria.fr/ast/sql#Intersect</seealso>
    let Intersect = Prefixed_Name(sql, "Intersect") |> PrefixedName
    /// <summary>
    ///   <para>sql:LessEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Less than or equal to comparison</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#LessEquals">http://ns.inria.fr/ast/sql#LessEquals</seealso>
    let LessEquals = Prefixed_Name(sql, "LessEquals") |> PrefixedName
    /// <summary>
    ///   <para>sql:LessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Less than comparison</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#LessThan">http://ns.inria.fr/ast/sql#LessThan</seealso>
    let LessThan = Prefixed_Name(sql, "LessThan") |> PrefixedName
    /// <summary>
    ///   <para>sql:Max</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the maximum value of the given expression.</para>
    /// labels<para>Maximum</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Max">http://ns.inria.fr/ast/sql#Max</seealso>
    let Max = Prefixed_Name(sql, "Max") |> PrefixedName
    /// <summary>
    ///   <para>sql:Min</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the minimum value of the given expression.</para>
    /// labels<para>Minimum</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Min">http://ns.inria.fr/ast/sql#Min</seealso>
    let Min = Prefixed_Name(sql, "Min") |> PrefixedName
    /// <summary>
    ///   <para>sql:Not</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL logical negation that can be used to negate any condition.</para>
    /// labels<para>Logical Negation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Not">http://ns.inria.fr/ast/sql#Not</seealso>
    let Not = Prefixed_Name(sql, "Not") |> PrefixedName
    /// <summary>
    ///   <para>sql:Or</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Logical Disjunction</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Or">http://ns.inria.fr/ast/sql#Or</seealso>
    let Or = Prefixed_Name(sql, "Or") |> PrefixedName
    /// <summary>
    ///   <para>sql:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL operator used to perform arithmetic calculations, comparisons or value assignments.</para>
    /// labels<para>Operator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Operator">http://ns.inria.fr/ast/sql#Operator</seealso>
    let Operator = Prefixed_Name(sql, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>sql:And</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Logical Conjunction</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#And">http://ns.inria.fr/ast/sql#And</seealso>
    let And = Prefixed_Name(sql, "And") |> PrefixedName
    /// <summary>
    ///   <para>sql:ArithmeticOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL arithmetic operator used to perform arithmetic calculation.</para>
    /// labels<para>Arithmetic Operator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ArithmeticOperator">http://ns.inria.fr/ast/sql#ArithmeticOperator</seealso>
    let ArithmeticOperator = Prefixed_Name(sql, "ArithmeticOperator") |> PrefixedName
    /// <summary>
    ///   <para>sql:Between</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Ternary predicate used to assert whether a provided expression's value is within the range specified by two other expressions' values.</para>
    /// labels<para>Range predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Between">http://ns.inria.fr/ast/sql#Between</seealso>
    let Between = Prefixed_Name(sql, "Between") |> PrefixedName

    /// <summary>
    ///   <para>sql:DataTypeConversionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL scalar function.</para>
    /// labels<para>Data Type Conversion Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#DataTypeConversionFunction">http://ns.inria.fr/ast/sql#DataTypeConversionFunction</seealso>
    let DataTypeConversionFunction =
        Prefixed_Name(sql, "DataTypeConversionFunction") |> PrefixedName

    /// <summary>
    ///   <para>sql:All</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL '*' wildcard operator, substitutes to all the columns of the tables in the FROM clause.</para>
    /// labels<para>All</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#All">http://ns.inria.fr/ast/sql#All</seealso>
    let All = Prefixed_Name(sql, "All") |> PrefixedName
    /// <summary>
    ///   <para>sql:Avg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the mean of the given expression.</para>
    /// labels<para>Average</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Avg">http://ns.inria.fr/ast/sql#Avg</seealso>
    let Avg = Prefixed_Name(sql, "Avg") |> PrefixedName
    /// <summary>
    ///   <para>sql:CallStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL CALL statement.</para>
    /// labels<para>Call Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#CallStatement">http://ns.inria.fr/ast/sql#CallStatement</seealso>
    let CallStatement = Prefixed_Name(sql, "CallStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:CaseExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL case expression enables the use of the IF &lt;condition&gt; THEN &lt;consequent&gt; ELSE &lt;alternative&gt; logic within SQL statements.</para>
    /// labels<para>Case Expression</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#CaseExpression">http://ns.inria.fr/ast/sql#CaseExpression</seealso>
    let CaseExpression = Prefixed_Name(sql, "CaseExpression") |> PrefixedName
    /// <summary>
    ///   <para>sql:CatalogObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A database catalog object reference.</para>
    /// labels<para>Database Catalog Object</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#CatalogObject">http://ns.inria.fr/ast/sql#CatalogObject</seealso>
    let CatalogObject = Prefixed_Name(sql, "CatalogObject") |> PrefixedName
    /// <summary>
    ///   <para>sql:ObjectIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A database catalog object identifier, qualified or not.</para>
    /// labels<para>Database Catalog Object Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ObjectIdentifier">http://ns.inria.fr/ast/sql#ObjectIdentifier</seealso>
    let ObjectIdentifier = Prefixed_Name(sql, "ObjectIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:NotEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Difference comparison</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#NotEquals">http://ns.inria.fr/ast/sql#NotEquals</seealso>
    let NotEquals = Prefixed_Name(sql, "NotEquals") |> PrefixedName
    /// <summary>
    ///   <para>sql:Plus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Addition</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Plus">http://ns.inria.fr/ast/sql#Plus</seealso>
    let Plus = Prefixed_Name(sql, "Plus") |> PrefixedName
    /// <summary>
    ///   <para>sql:ProcedureIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog procedure.</para>
    /// labels<para>Procedure Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ProcedureIdentifier">http://ns.inria.fr/ast/sql#ProcedureIdentifier</seealso>
    let ProcedureIdentifier = Prefixed_Name(sql, "ProcedureIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:RoleIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog role.</para>
    /// labels<para>Role Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#RoleIdentifier">http://ns.inria.fr/ast/sql#RoleIdentifier</seealso>
    let RoleIdentifier = Prefixed_Name(sql, "RoleIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog schema.</para>
    /// labels<para>Relational Schema</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Schema">http://ns.inria.fr/ast/sql#Schema</seealso>
    let Schema = Prefixed_Name(sql, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>sql:DeleteStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL DELETE statement.</para>
    /// labels<para>Delete Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#DeleteStatement">http://ns.inria.fr/ast/sql#DeleteStatement</seealso>
    let DeleteStatement = Prefixed_Name(sql, "DeleteStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:Equals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Equality comparison</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Equals">http://ns.inria.fr/ast/sql#Equals</seealso>
    let Equals = Prefixed_Name(sql, "Equals") |> PrefixedName
    /// <summary>
    ///   <para>sql:Grant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL GRANT statement used to give a set of privileges or roles to specified users that are actionable on specified database objects.</para>
    /// labels<para>Grant Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Grant">http://ns.inria.fr/ast/sql#Grant</seealso>
    let Grant = Prefixed_Name(sql, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>sql:In</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Variadic predicate used to assert whether the first provided expression's value is within the set of following provided expressions' values.</para>
    /// labels<para>In predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#In">http://ns.inria.fr/ast/sql#In</seealso>
    let In = Prefixed_Name(sql, "In") |> PrefixedName
    /// <summary>
    ///   <para>sql:ProceduralStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL procedural statement.</para>
    /// labels<para>Procedural Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ProceduralStatement">http://ns.inria.fr/ast/sql#ProceduralStatement</seealso>
    let ProceduralStatement = Prefixed_Name(sql, "ProceduralStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:FullOuterJoin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Full Outer Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#FullOuterJoin">http://ns.inria.fr/ast/sql#FullOuterJoin</seealso>
    let FullOuterJoin = Prefixed_Name(sql, "FullOuterJoin") |> PrefixedName
    /// <summary>
    ///   <para>sql:GreaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Greater than comparison</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#GreaterThan">http://ns.inria.fr/ast/sql#GreaterThan</seealso>
    let GreaterThan = Prefixed_Name(sql, "GreaterThan") |> PrefixedName
    /// <summary>
    ///   <para>sql:ColumnIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog column.</para>
    /// labels<para>Column Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ColumnIdentifier">http://ns.inria.fr/ast/sql#ColumnIdentifier</seealso>
    let ColumnIdentifier = Prefixed_Name(sql, "ColumnIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:Concatenation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL concatenation operator that returns the combination of two strings, expressions or values.</para>
    /// labels<para>Concatenation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Concatenation">http://ns.inria.fr/ast/sql#Concatenation</seealso>
    let Concatenation = Prefixed_Name(sql, "Concatenation") |> PrefixedName
    /// <summary>
    ///   <para>sql:CrossJoin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Join predicate used to perform the cross-product of two tables.</para>
    /// labels<para>Cross Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#CrossJoin">http://ns.inria.fr/ast/sql#CrossJoin</seealso>
    let CrossJoin = Prefixed_Name(sql, "CrossJoin") |> PrefixedName
    /// <summary>
    ///   <para>sql:groupBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies the columns whose values will be considered to cluster the result set of selected rows.</para>
    /// labels<para>GROUP BY clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#groupBy">http://ns.inria.fr/ast/sql#groupBy</seealso>
    let groupBy = Prefixed_Name(sql, "groupBy") |> PrefixedName
    /// <summary>
    ///   <para>sql:values</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies a list of values or expressions evaluating to values.</para>
    /// labels<para>VALUES list Clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#values">http://ns.inria.fr/ast/sql#values</seealso>
    let values = Prefixed_Name(sql, "values") |> PrefixedName
    /// <summary>
    ///   <para>sql:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>SQL Abstract Syntax Trees Vocabulary</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#">http://ns.inria.fr/ast/sql#</seealso>
    let _prefix_iri = Prefixed_Name(sql, "") |> PrefixedName

    /// <summary>
    ///   <para>sql:AccessControlStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL access control statement.</para>
    /// labels<para>Access Control Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#AccessControlStatement">http://ns.inria.fr/ast/sql#AccessControlStatement</seealso>
    let AccessControlStatement =
        Prefixed_Name(sql, "AccessControlStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL statement.</para>
    /// labels<para>Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Statement">http://ns.inria.fr/ast/sql#Statement</seealso>
    let Statement = Prefixed_Name(sql, "Statement") |> PrefixedName

    /// <summary>
    ///   <para>sql:AggregationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL aggregation expression consists in the use of an aggregate function.</para>
    /// labels<para>Aggregation Expression</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#AggregationExpression">http://ns.inria.fr/ast/sql#AggregationExpression</seealso>
    let AggregationExpression =
        Prefixed_Name(sql, "AggregationExpression") |> PrefixedName

    /// <summary>
    ///   <para>sql:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL expression denotes any clause that when evaluated returns values.</para>
    /// labels<para>Expression</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Expression">http://ns.inria.fr/ast/sql#Expression</seealso>
    let Expression = Prefixed_Name(sql, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>sql:Alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL AS operator used to give an identifier to an expression.</para>
    /// labels<para>Alias</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Alias">http://ns.inria.fr/ast/sql#Alias</seealso>
    let Alias = Prefixed_Name(sql, "Alias") |> PrefixedName
    /// <summary>
    ///   <para>sql:AlterStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL ALTER statement.</para>
    /// labels<para>Alter Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#AlterStatement">http://ns.inria.fr/ast/sql#AlterStatement</seealso>
    let AlterStatement = Prefixed_Name(sql, "AlterStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:DataDefinitionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL data definition statement.</para>
    /// labels<para>Data Definition Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#DataDefinitionStatement">http://ns.inria.fr/ast/sql#DataDefinitionStatement</seealso>
    let DataDefinitionStatement =
        Prefixed_Name(sql, "DataDefinitionStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:ComparisonOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A binary operator used to compare two values, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.</para>
    /// labels<para>Comparison Operator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ComparisonOperator">http://ns.inria.fr/ast/sql#ComparisonOperator</seealso>
    let ComparisonOperator = Prefixed_Name(sql, "ComparisonOperator") |> PrefixedName

    /// <summary>
    ///   <para>sql:SessionManagementStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL session management statement.</para>
    /// labels<para>Session Management Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#SessionManagementStatement">http://ns.inria.fr/ast/sql#SessionManagementStatement</seealso>
    let SessionManagementStatement =
        Prefixed_Name(sql, "SessionManagementStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:JoinPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Binary predicate used join two or more tables.</para>
    /// labels<para>Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#JoinPredicate">http://ns.inria.fr/ast/sql#JoinPredicate</seealso>
    let JoinPredicate = Prefixed_Name(sql, "JoinPredicate") |> PrefixedName

    /// <summary>
    ///   <para>sql:DataManipulationStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL data manipulation statement.</para>
    /// labels<para>Data Manipulation Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#DataManipulationStatement">http://ns.inria.fr/ast/sql#DataManipulationStatement</seealso>
    let DataManipulationStatement =
        Prefixed_Name(sql, "DataManipulationStatement") |> PrefixedName

    /// <summary>
    ///   <para>sql:ScalarFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL scalar function returns a single value given the input values. The input value is of a SQL primitive data type.</para>
    /// labels<para>Scalar Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ScalarFunction">http://ns.inria.fr/ast/sql#ScalarFunction</seealso>
    let ScalarFunction = Prefixed_Name(sql, "ScalarFunction") |> PrefixedName
    /// <summary>
    ///   <para>sql:DateTimeFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL date time function returns a date or time value or performs a specific date or time value computation.</para>
    /// labels<para>Date Time Computation Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#DateTimeFunction">http://ns.inria.fr/ast/sql#DateTimeFunction</seealso>
    let DateTimeFunction = Prefixed_Name(sql, "DateTimeFunction") |> PrefixedName
    /// <summary>
    ///   <para>sql:Div</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Division</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Div">http://ns.inria.fr/ast/sql#Div</seealso>
    let Div = Prefixed_Name(sql, "Div") |> PrefixedName
    /// <summary>
    ///   <para>sql:DropStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL DROP statement.</para>
    /// labels<para>Drop Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#DropStatement">http://ns.inria.fr/ast/sql#DropStatement</seealso>
    let DropStatement = Prefixed_Name(sql, "DropStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:SetOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL set operator used to perform set operation on the results of two or more queries.</para>
    /// labels<para>Set Operator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#SetOperator">http://ns.inria.fr/ast/sql#SetOperator</seealso>
    let SetOperator = Prefixed_Name(sql, "SetOperator") |> PrefixedName
    /// <summary>
    ///   <para>sql:Exists</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Unary predicate that returns one of the TRUE or FALSE truth values depending on whether the evaluated subquery returns an empty result set.</para>
    /// labels<para>Exists predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Exists">http://ns.inria.fr/ast/sql#Exists</seealso>
    let Exists = Prefixed_Name(sql, "Exists") |> PrefixedName
    /// <summary>
    ///   <para>sql:OuterJoin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Outer Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#OuterJoin">http://ns.inria.fr/ast/sql#OuterJoin</seealso>
    let OuterJoin = Prefixed_Name(sql, "OuterJoin") |> PrefixedName
    /// <summary>
    ///   <para>sql:IOStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL import or export statement.</para>
    /// labels<para>Import / Export Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#IOStatement">http://ns.inria.fr/ast/sql#IOStatement</seealso>
    let IOStatement = Prefixed_Name(sql, "IOStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:IndexIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog index.</para>
    /// labels<para>Index Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#IndexIdentifier">http://ns.inria.fr/ast/sql#IndexIdentifier</seealso>
    let IndexIdentifier = Prefixed_Name(sql, "IndexIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:InsertStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL INSERT statement.</para>
    /// labels<para>Insert Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#InsertStatement">http://ns.inria.fr/ast/sql#InsertStatement</seealso>
    let InsertStatement = Prefixed_Name(sql, "InsertStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:IsNull</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Unary predicate that compares the evaluated expression's value with NULL</para>
    /// labels<para>Is Null predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#IsNull">http://ns.inria.fr/ast/sql#IsNull</seealso>
    let IsNull = Prefixed_Name(sql, "IsNull") |> PrefixedName
    /// <summary>
    ///   <para>sql:LeftOuterJoin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Left Outer Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#LeftOuterJoin">http://ns.inria.fr/ast/sql#LeftOuterJoin</seealso>
    let LeftOuterJoin = Prefixed_Name(sql, "LeftOuterJoin") |> PrefixedName
    /// <summary>
    ///   <para>sql:Like</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Binary predicate that returns one of the TRUE or FALSE truth values depending on whether the string resulting in the evaluation of the first expression matches the lightweight regular expression described in the second expression.</para>
    /// labels<para>Like predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Like">http://ns.inria.fr/ast/sql#Like</seealso>
    let Like = Prefixed_Name(sql, "Like") |> PrefixedName
    /// <summary>
    ///   <para>sql:LockTableStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL LOCK TABLE statement.</para>
    /// labels<para>Lock Table Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#LockTableStatement">http://ns.inria.fr/ast/sql#LockTableStatement</seealso>
    let LockTableStatement = Prefixed_Name(sql, "LockTableStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:Minus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Subtraction</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Minus">http://ns.inria.fr/ast/sql#Minus</seealso>
    let Minus = Prefixed_Name(sql, "Minus") |> PrefixedName
    /// <summary>
    ///   <para>sql:Mult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Multiplication</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Mult">http://ns.inria.fr/ast/sql#Mult</seealso>
    let Mult = Prefixed_Name(sql, "Mult") |> PrefixedName
    /// <summary>
    ///   <para>sql:Negate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unary arithmetic operator used to produce the negative of its operand.</para>
    /// labels<para>Negation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Negate">http://ns.inria.fr/ast/sql#Negate</seealso>
    let Negate = Prefixed_Name(sql, "Negate") |> PrefixedName
    /// <summary>
    ///   <para>sql:Now</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL now function is a nullary function that returns the current timestamp.</para>
    /// labels<para>Now</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Now">http://ns.inria.fr/ast/sql#Now</seealso>
    let Now = Prefixed_Name(sql, "Now") |> PrefixedName
    /// <summary>
    ///   <para>sql:NumberFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL number function that returns a numeric value and reads numeric values or string with numeric characters.</para>
    /// labels<para>Number Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#NumberFunction">http://ns.inria.fr/ast/sql#NumberFunction</seealso>
    let NumberFunction = Prefixed_Name(sql, "NumberFunction") |> PrefixedName
    /// <summary>
    ///   <para>sql:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog procedure.</para>
    /// labels<para>Relational Procedure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Procedure">http://ns.inria.fr/ast/sql#Procedure</seealso>
    let Procedure = Prefixed_Name(sql, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>sql:Revoke</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL REVOKE statement used to revoke a set of privileges or roles to specified users from specified database objects.</para>
    /// labels<para>Revoke Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Revoke">http://ns.inria.fr/ast/sql#Revoke</seealso>
    let Revoke = Prefixed_Name(sql, "Revoke") |> PrefixedName
    /// <summary>
    ///   <para>sql:RightOuterJoin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Right Outer Join Predicate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#RightOuterJoin">http://ns.inria.fr/ast/sql#RightOuterJoin</seealso>
    let RightOuterJoin = Prefixed_Name(sql, "RightOuterJoin") |> PrefixedName
    /// <summary>
    ///   <para>sql:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog role.</para>
    /// labels<para>Relational Role</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Role">http://ns.inria.fr/ast/sql#Role</seealso>
    let Role = Prefixed_Name(sql, "Role") |> PrefixedName
    /// <summary>
    ///   <para>sql:SchemaIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog schema.</para>
    /// labels<para>Schema Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#SchemaIdentifier">http://ns.inria.fr/ast/sql#SchemaIdentifier</seealso>
    let SchemaIdentifier = Prefixed_Name(sql, "SchemaIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:SelectStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL SELECT statement.</para>
    /// labels<para>Select Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#SelectStatement">http://ns.inria.fr/ast/sql#SelectStatement</seealso>
    let SelectStatement = Prefixed_Name(sql, "SelectStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:SetStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Assigns a value to a session variable identifier.</para>
    /// labels<para>Set Statement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#SetStatement">http://ns.inria.fr/ast/sql#SetStatement</seealso>
    let SetStatement = Prefixed_Name(sql, "SetStatement") |> PrefixedName
    /// <summary>
    ///   <para>sql:StdDev</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the standard deviation (square root of the variance) of the given expression.</para>
    /// labels<para>Standard Deviation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#StdDev">http://ns.inria.fr/ast/sql#StdDev</seealso>
    let StdDev = Prefixed_Name(sql, "StdDev") |> PrefixedName
    /// <summary>
    ///   <para>sql:TableFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL function that returns a virtual table.</para>
    /// labels<para>Table Function</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#TableFunction">http://ns.inria.fr/ast/sql#TableFunction</seealso>
    let TableFunction = Prefixed_Name(sql, "TableFunction") |> PrefixedName
    /// <summary>
    ///   <para>sql:TableIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog table.</para>
    /// labels<para>Table Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#TableIdentifier">http://ns.inria.fr/ast/sql#TableIdentifier</seealso>
    let TableIdentifier = Prefixed_Name(sql, "TableIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL union operator used to return the combination of the result sets of two or more queries.</para>
    /// labels<para>Union</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Union">http://ns.inria.fr/ast/sql#Union</seealso>
    let Union = Prefixed_Name(sql, "Union") |> PrefixedName
    /// <summary>
    ///   <para>sql:UnionAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SQL union operator used to return the combination of the result sets of two or more queries, including duplicate result rows.</para>
    /// labels<para>Union All</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#UnionAll">http://ns.inria.fr/ast/sql#UnionAll</seealso>
    let UnionAll = Prefixed_Name(sql, "UnionAll") |> PrefixedName
    /// <summary>
    ///   <para>sql:Var</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The SQL aggregate function that returns the variance of the given expression.</para>
    /// labels<para>Variance</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#Var">http://ns.inria.fr/ast/sql#Var</seealso>
    let Var = Prefixed_Name(sql, "Var") |> PrefixedName
    /// <summary>
    ///   <para>sql:View</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference or declarative statement for a catalog view.</para>
    /// labels<para>Relational View</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#View">http://ns.inria.fr/ast/sql#View</seealso>
    let View = Prefixed_Name(sql, "View") |> PrefixedName
    /// <summary>
    ///   <para>sql:ViewIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A valid identifier for a catalog view.</para>
    /// labels<para>View Identifier</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#ViewIdentifier">http://ns.inria.fr/ast/sql#ViewIdentifier</seealso>
    let ViewIdentifier = Prefixed_Name(sql, "ViewIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>sql:args</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The generic predicate used to attach an ordered list of children to any AST node.</para>
    /// labels<para>AST Node Arguments</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#args">http://ns.inria.fr/ast/sql#args</seealso>
    let args = Prefixed_Name(sql, "args") |> PrefixedName
    /// <summary>
    ///   <para>sql:having</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies the filtering predicates to apply on the clustered result set resulting of a GROUP BY clause.</para>
    /// labels<para>HAVING clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#having">http://ns.inria.fr/ast/sql#having</seealso>
    let having = Prefixed_Name(sql, "having") |> PrefixedName
    /// <summary>
    ///   <para>sql:into</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies into which table the following values or select statement's result set are to be inserted into.</para>
    /// labels<para>INTO target table clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#into">http://ns.inria.fr/ast/sql#into</seealso>
    let into = Prefixed_Name(sql, "into") |> PrefixedName
    /// <summary>
    ///   <para>sql:limit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that limits the number of records from the result set that should be returned.</para>
    /// labels<para>LIMIT clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#limit">http://ns.inria.fr/ast/sql#limit</seealso>
    let limit = Prefixed_Name(sql, "limit") |> PrefixedName
    /// <summary>
    ///   <para>sql:orderBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies how to order the result set's records according to given expressions.</para>
    /// labels<para>ORDER BY clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#orderBy">http://ns.inria.fr/ast/sql#orderBy</seealso>
    let orderBy = Prefixed_Name(sql, "orderBy") |> PrefixedName
    /// <summary>
    ///   <para>sql:select</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies the projected tables of a SELECT statement.</para>
    /// labels<para>SELECT clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#select">http://ns.inria.fr/ast/sql#select</seealso>
    let select = Prefixed_Name(sql, "select") |> PrefixedName
    /// <summary>
    ///   <para>sql:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SQL clause that specifies the filtering predicates to apply on the inputs of the FROM clause.</para>
    /// labels<para>WHERE clause</para></remarks>
    /// <seealso href="http://ns.inria.fr/ast/sql#where">http://ns.inria.fr/ast/sql#where</seealso>
    let where = Prefixed_Name(sql, "where") |> PrefixedName
