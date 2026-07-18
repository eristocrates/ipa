namespace http.ns.inria.fr.ast.sql.hash

open DoxAletheia.Rdf_Vocabulary

module sql =
    let _namespace_name = "http://ns.inria.fr/ast/sql#"
    /// <summary>
    /// Abstract class subsumed by all AST node classes.
    /// <see href="http://ns.inria.fr/ast/sql#ASTNode"></see></summary>
    let ASTNode = Namespaced_IRI.parse _namespace_name "ASTNode" |> NamespacedName

    /// <summary>
    /// A SQL access control statement.
    /// <see href="http://ns.inria.fr/ast/sql#AccessControlStatement"></see></summary>
    let AccessControlStatement =
        Namespaced_IRI.parse _namespace_name "AccessControlStatement" |> NamespacedName

    /// <summary>
    /// A SQL statement.
    /// <see href="http://ns.inria.fr/ast/sql#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName

    /// <summary>
    /// A SQL aggregate function returns a single value given the values of multiple rows from a column.
    /// <see href="http://ns.inria.fr/ast/sql#AggregateFunction"></see></summary>
    let AggregateFunction =
        Namespaced_IRI.parse _namespace_name "AggregateFunction" |> NamespacedName

    /// <summary>
    /// A SQL built-in function that performs calculation and returns a value. May be vendor-specific.
    /// <see href="http://ns.inria.fr/ast/sql#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName

    /// <summary>
    /// A SQL aggregation expression consists in the use of an aggregate function.
    /// <see href="http://ns.inria.fr/ast/sql#AggregationExpression"></see></summary>
    let AggregationExpression =
        Namespaced_IRI.parse _namespace_name "AggregationExpression" |> NamespacedName

    /// <summary>
    /// A SQL expression denotes any clause that when evaluated returns values.
    /// <see href="http://ns.inria.fr/ast/sql#Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    /// The SQL AS operator used to give an identifier to an expression.
    /// <see href="http://ns.inria.fr/ast/sql#Alias"></see></summary>
    let Alias = Namespaced_IRI.parse _namespace_name "Alias" |> NamespacedName
    /// <summary>
    /// A SQL operator used to perform arithmetic calculations, comparisons or value assignments.
    /// <see href="http://ns.inria.fr/ast/sql#Operator"></see></summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName
    /// <summary>
    /// The SQL '*' wildcard operator, substitutes to all the columns of the tables in the FROM clause.
    /// <see href="http://ns.inria.fr/ast/sql#All"></see></summary>
    let All = Namespaced_IRI.parse _namespace_name "All" |> NamespacedName

    /// <summary>
    /// A SQL ALTER statement.
    /// <see href="http://ns.inria.fr/ast/sql#AlterStatement"></see></summary>
    let AlterStatement =
        Namespaced_IRI.parse _namespace_name "AlterStatement" |> NamespacedName

    /// <summary>
    /// A SQL data definition statement.
    /// <see href="http://ns.inria.fr/ast/sql#DataDefinitionStatement"></see></summary>
    let DataDefinitionStatement =
        Namespaced_IRI.parse _namespace_name "DataDefinitionStatement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#And"></see>
    /// </summary>
    let And = Namespaced_IRI.parse _namespace_name "And" |> NamespacedName

    /// <summary>
    /// A SQL logical connective used to perform logical calculation.
    /// <see href="http://ns.inria.fr/ast/sql#LogicalOperator"></see></summary>
    let LogicalOperator =
        Namespaced_IRI.parse _namespace_name "LogicalOperator" |> NamespacedName

    /// <summary>
    /// A SQL arithmetic operator used to perform arithmetic calculation.
    /// <see href="http://ns.inria.fr/ast/sql#ArithmeticOperator"></see></summary>
    let ArithmeticOperator =
        Namespaced_IRI.parse _namespace_name "ArithmeticOperator" |> NamespacedName

    /// <summary>
    /// The SQL aggregate function that returns the mean of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Avg"></see></summary>
    let Avg = Namespaced_IRI.parse _namespace_name "Avg" |> NamespacedName
    /// <summary>
    /// Ternary predicate used to assert whether a provided expression's value is within the range specified by two other expressions' values.
    /// <see href="http://ns.inria.fr/ast/sql#Between"></see></summary>
    let Between = Namespaced_IRI.parse _namespace_name "Between" |> NamespacedName
    /// <summary>
    /// Represents a collection of one or more expressions or subqueries, that may be combined with logical operators, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.
    /// <see href="http://ns.inria.fr/ast/sql#Predicate"></see></summary>
    let Predicate = Namespaced_IRI.parse _namespace_name "Predicate" |> NamespacedName

    /// <summary>
    /// A SQL CALL statement.
    /// <see href="http://ns.inria.fr/ast/sql#CallStatement"></see></summary>
    let CallStatement =
        Namespaced_IRI.parse _namespace_name "CallStatement" |> NamespacedName

    /// <summary>
    /// A SQL procedural statement.
    /// <see href="http://ns.inria.fr/ast/sql#ProceduralStatement"></see></summary>
    let ProceduralStatement =
        Namespaced_IRI.parse _namespace_name "ProceduralStatement" |> NamespacedName

    /// <summary>
    /// A SQL case expression enables the use of the IF &lt;condition&gt; THEN &lt;consequent&gt; ELSE &lt;alternative&gt; logic within SQL statements.
    /// <see href="http://ns.inria.fr/ast/sql#CaseExpression"></see></summary>
    let CaseExpression =
        Namespaced_IRI.parse _namespace_name "CaseExpression" |> NamespacedName

    /// <summary>
    /// A SQL scalar function that converts an expression to a target data type
    /// <see href="http://ns.inria.fr/ast/sql#Cast"></see></summary>
    let Cast = Namespaced_IRI.parse _namespace_name "Cast" |> NamespacedName

    /// <summary>
    /// A SQL scalar function.
    /// <see href="http://ns.inria.fr/ast/sql#DataTypeConversionFunction"></see></summary>
    let DataTypeConversionFunction =
        Namespaced_IRI.parse _namespace_name "DataTypeConversionFunction" |> NamespacedName

    /// <summary>
    /// A database catalog object reference.
    /// <see href="http://ns.inria.fr/ast/sql#CatalogObject"></see></summary>
    let CatalogObject =
        Namespaced_IRI.parse _namespace_name "CatalogObject" |> NamespacedName

    /// <summary>
    /// A reference or declarative statement for a catalog column.
    /// <see href="http://ns.inria.fr/ast/sql#Column"></see></summary>
    let Column = Namespaced_IRI.parse _namespace_name "Column" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog column.
    /// <see href="http://ns.inria.fr/ast/sql#ColumnIdentifier"></see></summary>
    let ColumnIdentifier =
        Namespaced_IRI.parse _namespace_name "ColumnIdentifier" |> NamespacedName

    /// <summary>
    /// A database catalog object identifier, qualified or not.
    /// <see href="http://ns.inria.fr/ast/sql#ObjectIdentifier"></see></summary>
    let ObjectIdentifier =
        Namespaced_IRI.parse _namespace_name "ObjectIdentifier" |> NamespacedName

    /// <summary>
    /// A SQL COMMIT statement.
    /// <see href="http://ns.inria.fr/ast/sql#CommitStatement"></see></summary>
    let CommitStatement =
        Namespaced_IRI.parse _namespace_name "CommitStatement" |> NamespacedName

    /// <summary>
    /// A SQL transaction management statement.
    /// <see href="http://ns.inria.fr/ast/sql#TransactionManagementStatement"></see></summary>
    let TransactionManagementStatement =
        Namespaced_IRI.parse _namespace_name "TransactionManagementStatement" |> NamespacedName

    /// <summary>
    /// A binary operator used to compare two values, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.
    /// <see href="http://ns.inria.fr/ast/sql#ComparisonOperator"></see></summary>
    let ComparisonOperator =
        Namespaced_IRI.parse _namespace_name "ComparisonOperator" |> NamespacedName

    /// <summary>
    /// A SQL concatenation operator that returns the combination of two strings, expressions or values.
    /// <see href="http://ns.inria.fr/ast/sql#Concatenation"></see></summary>
    let Concatenation =
        Namespaced_IRI.parse _namespace_name "Concatenation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#StringOperator"></see>
    /// </summary>
    let StringOperator =
        Namespaced_IRI.parse _namespace_name "StringOperator" |> NamespacedName

    /// <summary>
    /// A SQL CONNECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#ConnectStatement"></see></summary>
    let ConnectStatement =
        Namespaced_IRI.parse _namespace_name "ConnectStatement" |> NamespacedName

    /// <summary>
    /// A SQL session management statement.
    /// <see href="http://ns.inria.fr/ast/sql#SessionManagementStatement"></see></summary>
    let SessionManagementStatement =
        Namespaced_IRI.parse _namespace_name "SessionManagementStatement" |> NamespacedName

    /// <summary>
    /// The SQL aggregate function that returns the number of rows or non NULL values from the result set.
    /// <see href="http://ns.inria.fr/ast/sql#Count"></see></summary>
    let Count = Namespaced_IRI.parse _namespace_name "Count" |> NamespacedName

    /// <summary>
    /// A SQL CREATE statement.
    /// <see href="http://ns.inria.fr/ast/sql#CreateStatement"></see></summary>
    let CreateStatement =
        Namespaced_IRI.parse _namespace_name "CreateStatement" |> NamespacedName

    /// <summary>
    /// Join predicate used to perform the cross-product of two tables.
    /// <see href="http://ns.inria.fr/ast/sql#CrossJoin"></see></summary>
    let CrossJoin = Namespaced_IRI.parse _namespace_name "CrossJoin" |> NamespacedName

    /// <summary>
    /// Binary predicate used join two or more tables.
    /// <see href="http://ns.inria.fr/ast/sql#JoinPredicate"></see></summary>
    let JoinPredicate =
        Namespaced_IRI.parse _namespace_name "JoinPredicate" |> NamespacedName

    /// <summary>
    /// A SQL data manipulation statement.
    /// <see href="http://ns.inria.fr/ast/sql#DataManipulationStatement"></see></summary>
    let DataManipulationStatement =
        Namespaced_IRI.parse _namespace_name "DataManipulationStatement" |> NamespacedName

    /// <summary>
    /// A SQL scalar function returns a single value given the input values. The input value is of a SQL primitive data type.
    /// <see href="http://ns.inria.fr/ast/sql#ScalarFunction"></see></summary>
    let ScalarFunction =
        Namespaced_IRI.parse _namespace_name "ScalarFunction" |> NamespacedName

    /// <summary>
    /// A SQL date time function returns a date or time value or performs a specific date or time value computation.
    /// <see href="http://ns.inria.fr/ast/sql#DateTimeFunction"></see></summary>
    let DateTimeFunction =
        Namespaced_IRI.parse _namespace_name "DateTimeFunction" |> NamespacedName

    /// <summary>
    /// A SQL DELETE statement.
    /// <see href="http://ns.inria.fr/ast/sql#DeleteStatement"></see></summary>
    let DeleteStatement =
        Namespaced_IRI.parse _namespace_name "DeleteStatement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Div"></see>
    /// </summary>
    let Div = Namespaced_IRI.parse _namespace_name "Div" |> NamespacedName

    /// <summary>
    /// A SQL DROP statement.
    /// <see href="http://ns.inria.fr/ast/sql#DropStatement"></see></summary>
    let DropStatement =
        Namespaced_IRI.parse _namespace_name "DropStatement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Equals"></see>
    /// </summary>
    let Equals = Namespaced_IRI.parse _namespace_name "Equals" |> NamespacedName
    /// <summary>
    /// A SQL exclusion operator used to return the result set produced by removing the result rows of the second query that appear in the result set of the first query.
    /// <see href="http://ns.inria.fr/ast/sql#Except"></see></summary>
    let Except = Namespaced_IRI.parse _namespace_name "Except" |> NamespacedName

    /// <summary>
    /// A SQL set operator used to perform set operation on the results of two or more queries.
    /// <see href="http://ns.inria.fr/ast/sql#SetOperator"></see></summary>
    let SetOperator =
        Namespaced_IRI.parse _namespace_name "SetOperator" |> NamespacedName

    /// <summary>
    /// Unary predicate that returns one of the TRUE or FALSE truth values depending on whether the evaluated subquery returns an empty result set.
    /// <see href="http://ns.inria.fr/ast/sql#Exists"></see></summary>
    let Exists = Namespaced_IRI.parse _namespace_name "Exists" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#FullOuterJoin"></see>
    /// </summary>
    let FullOuterJoin =
        Namespaced_IRI.parse _namespace_name "FullOuterJoin" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#OuterJoin"></see>
    /// </summary>
    let OuterJoin = Namespaced_IRI.parse _namespace_name "OuterJoin" |> NamespacedName

    /// <summary>
    /// A SQL function expressions consists in the use of any built-in SQL function.
    /// <see href="http://ns.inria.fr/ast/sql#FunctionExpression"></see></summary>
    let FunctionExpression =
        Namespaced_IRI.parse _namespace_name "FunctionExpression" |> NamespacedName

    /// <summary>
    /// A SQL GRANT statement used to give a set of privileges or roles to specified users that are actionable on specified database objects.
    /// <see href="http://ns.inria.fr/ast/sql#Grant"></see></summary>
    let Grant = Namespaced_IRI.parse _namespace_name "Grant" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#GreaterEquals"></see>
    /// </summary>
    let GreaterEquals =
        Namespaced_IRI.parse _namespace_name "GreaterEquals" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#GreaterThan"></see>
    /// </summary>
    let GreaterThan =
        Namespaced_IRI.parse _namespace_name "GreaterThan" |> NamespacedName

    /// <summary>
    /// A SQL import or export statement.
    /// <see href="http://ns.inria.fr/ast/sql#IOStatement"></see></summary>
    let IOStatement =
        Namespaced_IRI.parse _namespace_name "IOStatement" |> NamespacedName

    /// <summary>
    /// Variadic predicate used to assert whether the first provided expression's value is within the set of following provided expressions' values.
    /// <see href="http://ns.inria.fr/ast/sql#In"></see></summary>
    let In = Namespaced_IRI.parse _namespace_name "In" |> NamespacedName
    /// <summary>
    /// A reference or declarative statement for a catalog index.
    /// <see href="http://ns.inria.fr/ast/sql#Index"></see></summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog index.
    /// <see href="http://ns.inria.fr/ast/sql#IndexIdentifier"></see></summary>
    let IndexIdentifier =
        Namespaced_IRI.parse _namespace_name "IndexIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#InnerJoin"></see>
    /// </summary>
    let InnerJoin = Namespaced_IRI.parse _namespace_name "InnerJoin" |> NamespacedName

    /// <summary>
    /// A SQL INSERT statement.
    /// <see href="http://ns.inria.fr/ast/sql#InsertStatement"></see></summary>
    let InsertStatement =
        Namespaced_IRI.parse _namespace_name "InsertStatement" |> NamespacedName

    /// <summary>
    /// A SQL intersection operator used to return the common result rows of the combination of the result sets of two or more queries.
    /// <see href="http://ns.inria.fr/ast/sql#Intersect"></see></summary>
    let Intersect = Namespaced_IRI.parse _namespace_name "Intersect" |> NamespacedName
    /// <summary>
    /// Unary predicate that compares the evaluated expression's value with NULL
    /// <see href="http://ns.inria.fr/ast/sql#IsNull"></see></summary>
    let IsNull = Namespaced_IRI.parse _namespace_name "IsNull" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#LeftOuterJoin"></see>
    /// </summary>
    let LeftOuterJoin =
        Namespaced_IRI.parse _namespace_name "LeftOuterJoin" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#LessEquals"></see>
    /// </summary>
    let LessEquals = Namespaced_IRI.parse _namespace_name "LessEquals" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#LessThan"></see>
    /// </summary>
    let LessThan = Namespaced_IRI.parse _namespace_name "LessThan" |> NamespacedName
    /// <summary>
    /// Binary predicate that returns one of the TRUE or FALSE truth values depending on whether the string resulting in the evaluation of the first expression matches the lightweight regular expression described in the second expression.
    /// <see href="http://ns.inria.fr/ast/sql#Like"></see></summary>
    let Like = Namespaced_IRI.parse _namespace_name "Like" |> NamespacedName

    /// <summary>
    /// A SQL LOCK TABLE statement.
    /// <see href="http://ns.inria.fr/ast/sql#LockTableStatement"></see></summary>
    let LockTableStatement =
        Namespaced_IRI.parse _namespace_name "LockTableStatement" |> NamespacedName

    /// <summary>
    /// The SQL aggregate function that returns the maximum value of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Max"></see></summary>
    let Max = Namespaced_IRI.parse _namespace_name "Max" |> NamespacedName
    /// <summary>
    /// The SQL aggregate function that returns the minimum value of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Min"></see></summary>
    let Min = Namespaced_IRI.parse _namespace_name "Min" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Minus"></see>
    /// </summary>
    let Minus = Namespaced_IRI.parse _namespace_name "Minus" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Mult"></see>
    /// </summary>
    let Mult = Namespaced_IRI.parse _namespace_name "Mult" |> NamespacedName
    /// <summary>
    /// A unary arithmetic operator used to produce the negative of its operand.
    /// <see href="http://ns.inria.fr/ast/sql#Negate"></see></summary>
    let Negate = Namespaced_IRI.parse _namespace_name "Negate" |> NamespacedName
    /// <summary>
    /// A SQL logical negation that can be used to negate any condition.
    /// <see href="http://ns.inria.fr/ast/sql#Not"></see></summary>
    let Not = Namespaced_IRI.parse _namespace_name "Not" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#NotEquals"></see>
    /// </summary>
    let NotEquals = Namespaced_IRI.parse _namespace_name "NotEquals" |> NamespacedName
    /// <summary>
    /// A SQL now function is a nullary function that returns the current timestamp.
    /// <see href="http://ns.inria.fr/ast/sql#Now"></see></summary>
    let Now = Namespaced_IRI.parse _namespace_name "Now" |> NamespacedName

    /// <summary>
    /// A SQL number function that returns a numeric value and reads numeric values or string with numeric characters.
    /// <see href="http://ns.inria.fr/ast/sql#NumberFunction"></see></summary>
    let NumberFunction =
        Namespaced_IRI.parse _namespace_name "NumberFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Or"></see>
    /// </summary>
    let Or = Namespaced_IRI.parse _namespace_name "Or" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Plus"></see>
    /// </summary>
    let Plus = Namespaced_IRI.parse _namespace_name "Plus" |> NamespacedName
    /// <summary>
    /// A reference or declarative statement for a catalog procedure.
    /// <see href="http://ns.inria.fr/ast/sql#Procedure"></see></summary>
    let Procedure = Namespaced_IRI.parse _namespace_name "Procedure" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog procedure.
    /// <see href="http://ns.inria.fr/ast/sql#ProcedureIdentifier"></see></summary>
    let ProcedureIdentifier =
        Namespaced_IRI.parse _namespace_name "ProcedureIdentifier" |> NamespacedName

    /// <summary>
    /// A SQL REVOKE statement used to revoke a set of privileges or roles to specified users from specified database objects.
    /// <see href="http://ns.inria.fr/ast/sql#Revoke"></see></summary>
    let Revoke = Namespaced_IRI.parse _namespace_name "Revoke" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#RightOuterJoin"></see>
    /// </summary>
    let RightOuterJoin =
        Namespaced_IRI.parse _namespace_name "RightOuterJoin" |> NamespacedName

    /// <summary>
    /// A reference or declarative statement for a catalog role.
    /// <see href="http://ns.inria.fr/ast/sql#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog role.
    /// <see href="http://ns.inria.fr/ast/sql#RoleIdentifier"></see></summary>
    let RoleIdentifier =
        Namespaced_IRI.parse _namespace_name "RoleIdentifier" |> NamespacedName

    /// <summary>
    /// A SQL ROLLBACK statement.
    /// <see href="http://ns.inria.fr/ast/sql#RollbackStatement"></see></summary>
    let RollbackStatement =
        Namespaced_IRI.parse _namespace_name "RollbackStatement" |> NamespacedName

    /// <summary>
    /// A reference or declarative statement for a catalog schema.
    /// <see href="http://ns.inria.fr/ast/sql#Schema"></see></summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog schema.
    /// <see href="http://ns.inria.fr/ast/sql#SchemaIdentifier"></see></summary>
    let SchemaIdentifier =
        Namespaced_IRI.parse _namespace_name "SchemaIdentifier" |> NamespacedName

    /// <summary>
    /// A SQL SELECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#SelectStatement"></see></summary>
    let SelectStatement =
        Namespaced_IRI.parse _namespace_name "SelectStatement" |> NamespacedName

    /// <summary>
    /// A reference or declarative statement for a catalog sequence.
    /// <see href="http://ns.inria.fr/ast/sql#Sequence"></see></summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog sequence.
    /// <see href="http://ns.inria.fr/ast/sql#SequenceIdentifier"></see></summary>
    let SequenceIdentifier =
        Namespaced_IRI.parse _namespace_name "SequenceIdentifier" |> NamespacedName

    /// <summary>
    /// Assigns a value to a session variable identifier.
    /// <see href="http://ns.inria.fr/ast/sql#SetStatement"></see></summary>
    let SetStatement =
        Namespaced_IRI.parse _namespace_name "SetStatement" |> NamespacedName

    /// <summary>
    /// The SQL aggregate function that returns the standard deviation (square root of the variance) of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#StdDev"></see></summary>
    let StdDev = Namespaced_IRI.parse _namespace_name "StdDev" |> NamespacedName
    /// <summary>
    /// The SQL aggregate function that returns the sum of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Sum"></see></summary>
    let Sum = Namespaced_IRI.parse _namespace_name "Sum" |> NamespacedName
    /// <summary>
    /// A reference or declarative statement for a catalog table.
    /// <see href="http://ns.inria.fr/ast/sql#Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName

    /// <summary>
    /// A SQL function that returns a virtual table.
    /// <see href="http://ns.inria.fr/ast/sql#TableFunction"></see></summary>
    let TableFunction =
        Namespaced_IRI.parse _namespace_name "TableFunction" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog table.
    /// <see href="http://ns.inria.fr/ast/sql#TableIdentifier"></see></summary>
    let TableIdentifier =
        Namespaced_IRI.parse _namespace_name "TableIdentifier" |> NamespacedName

    /// <summary>
    /// A SQL union operator used to return the combination of the result sets of two or more queries.
    /// <see href="http://ns.inria.fr/ast/sql#Union"></see></summary>
    let Union = Namespaced_IRI.parse _namespace_name "Union" |> NamespacedName
    /// <summary>
    /// A SQL union operator used to return the combination of the result sets of two or more queries, including duplicate result rows.
    /// <see href="http://ns.inria.fr/ast/sql#UnionAll"></see></summary>
    let UnionAll = Namespaced_IRI.parse _namespace_name "UnionAll" |> NamespacedName

    /// <summary>
    /// A SQL UPDATE statement.
    /// <see href="http://ns.inria.fr/ast/sql#UpdateStatement"></see></summary>
    let UpdateStatement =
        Namespaced_IRI.parse _namespace_name "UpdateStatement" |> NamespacedName

    /// <summary>
    /// A reference or declarative statement for a catalog user.
    /// <see href="http://ns.inria.fr/ast/sql#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog user.
    /// <see href="http://ns.inria.fr/ast/sql#UserIdentifier"></see></summary>
    let UserIdentifier =
        Namespaced_IRI.parse _namespace_name "UserIdentifier" |> NamespacedName

    /// <summary>
    /// The SQL aggregate function that returns the variance of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Var"></see></summary>
    let Var = Namespaced_IRI.parse _namespace_name "Var" |> NamespacedName
    /// <summary>
    /// A reference or declarative statement for a catalog view.
    /// <see href="http://ns.inria.fr/ast/sql#View"></see></summary>
    let View = Namespaced_IRI.parse _namespace_name "View" |> NamespacedName

    /// <summary>
    /// A valid identifier for a catalog view.
    /// <see href="http://ns.inria.fr/ast/sql#ViewIdentifier"></see></summary>
    let ViewIdentifier =
        Namespaced_IRI.parse _namespace_name "ViewIdentifier" |> NamespacedName

    /// <summary>
    /// The generic predicate used to attach an ordered list of children to any AST node.
    /// <see href="http://ns.inria.fr/ast/sql#args"></see></summary>
    let args = Namespaced_IRI.parse _namespace_name "args" |> NamespacedName
    /// <summary>
    /// A SQL clause is a part of a statement.
    /// <see href="http://ns.inria.fr/ast/sql#clause"></see></summary>
    let clause = Namespaced_IRI.parse _namespace_name "clause" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies the target sources (tables, views, subqueries) of a SELECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies the columns whose values will be considered to cluster the result set of selected rows.
    /// <see href="http://ns.inria.fr/ast/sql#groupBy"></see></summary>
    let groupBy = Namespaced_IRI.parse _namespace_name "groupBy" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies the filtering predicates to apply on the clustered result set resulting of a GROUP BY clause.
    /// <see href="http://ns.inria.fr/ast/sql#having"></see></summary>
    let having = Namespaced_IRI.parse _namespace_name "having" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies into which table the following values or select statement's result set are to be inserted into.
    /// <see href="http://ns.inria.fr/ast/sql#into"></see></summary>
    let into = Namespaced_IRI.parse _namespace_name "into" |> NamespacedName
    /// <summary>
    /// The SQL clause that limits the number of records from the result set that should be returned.
    /// <see href="http://ns.inria.fr/ast/sql#limit"></see></summary>
    let limit = Namespaced_IRI.parse _namespace_name "limit" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies how to order the result set's records according to given expressions.
    /// <see href="http://ns.inria.fr/ast/sql#orderBy"></see></summary>
    let orderBy = Namespaced_IRI.parse _namespace_name "orderBy" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies the projected tables of a SELECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#select"></see></summary>
    let select = Namespaced_IRI.parse _namespace_name "select" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies a list of values or expressions evaluating to values.
    /// <see href="http://ns.inria.fr/ast/sql#values"></see></summary>
    let values = Namespaced_IRI.parse _namespace_name "values" |> NamespacedName
    /// <summary>
    /// The SQL clause that specifies the filtering predicates to apply on the inputs of the FROM clause.
    /// <see href="http://ns.inria.fr/ast/sql#where"></see></summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName
