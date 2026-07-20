namespace http.ns.inria.fr.ast.sql.hash

open DoxAletheia

module sql =
    let _namespace_name = "http://ns.inria.fr/ast/sql#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Abstract class subsumed by all AST node classes.
    /// <see href="http://ns.inria.fr/ast/sql#ASTNode"></see></summary>
    let ASTNode = _prefix "ASTNode"
    /// <summary>
    /// A SQL access control statement.
    /// <see href="http://ns.inria.fr/ast/sql#AccessControlStatement"></see></summary>
    let AccessControlStatement = _prefix "AccessControlStatement"
    /// <summary>
    /// A SQL statement.
    /// <see href="http://ns.inria.fr/ast/sql#Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    /// A SQL aggregate function returns a single value given the values of multiple rows from a column.
    /// <see href="http://ns.inria.fr/ast/sql#AggregateFunction"></see></summary>
    let AggregateFunction = _prefix "AggregateFunction"
    /// <summary>
    /// A SQL built-in function that performs calculation and returns a value. May be vendor-specific.
    /// <see href="http://ns.inria.fr/ast/sql#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// A SQL aggregation expression consists in the use of an aggregate function.
    /// <see href="http://ns.inria.fr/ast/sql#AggregationExpression"></see></summary>
    let AggregationExpression = _prefix "AggregationExpression"
    /// <summary>
    /// A SQL expression denotes any clause that when evaluated returns values.
    /// <see href="http://ns.inria.fr/ast/sql#Expression"></see></summary>
    let Expression = _prefix "Expression"
    /// <summary>
    /// The SQL AS operator used to give an identifier to an expression.
    /// <see href="http://ns.inria.fr/ast/sql#Alias"></see></summary>
    let Alias = _prefix "Alias"
    /// <summary>
    /// A SQL operator used to perform arithmetic calculations, comparisons or value assignments.
    /// <see href="http://ns.inria.fr/ast/sql#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    /// The SQL '*' wildcard operator, substitutes to all the columns of the tables in the FROM clause.
    /// <see href="http://ns.inria.fr/ast/sql#All"></see></summary>
    let All = _prefix "All"
    /// <summary>
    /// A SQL ALTER statement.
    /// <see href="http://ns.inria.fr/ast/sql#AlterStatement"></see></summary>
    let AlterStatement = _prefix "AlterStatement"
    /// <summary>
    /// A SQL data definition statement.
    /// <see href="http://ns.inria.fr/ast/sql#DataDefinitionStatement"></see></summary>
    let DataDefinitionStatement = _prefix "DataDefinitionStatement"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#And"></see>
    /// </summary>
    let And = _prefix "And"
    /// <summary>
    /// A SQL logical connective used to perform logical calculation.
    /// <see href="http://ns.inria.fr/ast/sql#LogicalOperator"></see></summary>
    let LogicalOperator = _prefix "LogicalOperator"
    /// <summary>
    /// A SQL arithmetic operator used to perform arithmetic calculation.
    /// <see href="http://ns.inria.fr/ast/sql#ArithmeticOperator"></see></summary>
    let ArithmeticOperator = _prefix "ArithmeticOperator"
    /// <summary>
    /// The SQL aggregate function that returns the mean of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Avg"></see></summary>
    let Avg = _prefix "Avg"
    /// <summary>
    /// Ternary predicate used to assert whether a provided expression's value is within the range specified by two other expressions' values.
    /// <see href="http://ns.inria.fr/ast/sql#Between"></see></summary>
    let Between = _prefix "Between"
    /// <summary>
    /// Represents a collection of one or more expressions or subqueries, that may be combined with logical operators, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.
    /// <see href="http://ns.inria.fr/ast/sql#Predicate"></see></summary>
    let Predicate = _prefix "Predicate"
    /// <summary>
    /// A SQL CALL statement.
    /// <see href="http://ns.inria.fr/ast/sql#CallStatement"></see></summary>
    let CallStatement = _prefix "CallStatement"
    /// <summary>
    /// A SQL procedural statement.
    /// <see href="http://ns.inria.fr/ast/sql#ProceduralStatement"></see></summary>
    let ProceduralStatement = _prefix "ProceduralStatement"
    /// <summary>
    /// A SQL case expression enables the use of the IF &lt;condition&gt; THEN &lt;consequent&gt; ELSE &lt;alternative&gt; logic within SQL statements.
    /// <see href="http://ns.inria.fr/ast/sql#CaseExpression"></see></summary>
    let CaseExpression = _prefix "CaseExpression"
    /// <summary>
    /// A SQL scalar function that converts an expression to a target data type
    /// <see href="http://ns.inria.fr/ast/sql#Cast"></see></summary>
    let Cast = _prefix "Cast"
    /// <summary>
    /// A SQL scalar function.
    /// <see href="http://ns.inria.fr/ast/sql#DataTypeConversionFunction"></see></summary>
    let DataTypeConversionFunction = _prefix "DataTypeConversionFunction"
    /// <summary>
    /// A database catalog object reference.
    /// <see href="http://ns.inria.fr/ast/sql#CatalogObject"></see></summary>
    let CatalogObject = _prefix "CatalogObject"
    /// <summary>
    /// A reference or declarative statement for a catalog column.
    /// <see href="http://ns.inria.fr/ast/sql#Column"></see></summary>
    let Column = _prefix "Column"
    /// <summary>
    /// A valid identifier for a catalog column.
    /// <see href="http://ns.inria.fr/ast/sql#ColumnIdentifier"></see></summary>
    let ColumnIdentifier = _prefix "ColumnIdentifier"
    /// <summary>
    /// A database catalog object identifier, qualified or not.
    /// <see href="http://ns.inria.fr/ast/sql#ObjectIdentifier"></see></summary>
    let ObjectIdentifier = _prefix "ObjectIdentifier"
    /// <summary>
    /// A SQL COMMIT statement.
    /// <see href="http://ns.inria.fr/ast/sql#CommitStatement"></see></summary>
    let CommitStatement = _prefix "CommitStatement"
    /// <summary>
    /// A SQL transaction management statement.
    /// <see href="http://ns.inria.fr/ast/sql#TransactionManagementStatement"></see></summary>
    let TransactionManagementStatement = _prefix "TransactionManagementStatement"
    /// <summary>
    /// A binary operator used to compare two values, and when evaluated returns one of the TRUE / FALSE / UNKNOWN truth values.
    /// <see href="http://ns.inria.fr/ast/sql#ComparisonOperator"></see></summary>
    let ComparisonOperator = _prefix "ComparisonOperator"
    /// <summary>
    /// A SQL concatenation operator that returns the combination of two strings, expressions or values.
    /// <see href="http://ns.inria.fr/ast/sql#Concatenation"></see></summary>
    let Concatenation = _prefix "Concatenation"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#StringOperator"></see>
    /// </summary>
    let StringOperator = _prefix "StringOperator"
    /// <summary>
    /// A SQL CONNECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#ConnectStatement"></see></summary>
    let ConnectStatement = _prefix "ConnectStatement"
    /// <summary>
    /// A SQL session management statement.
    /// <see href="http://ns.inria.fr/ast/sql#SessionManagementStatement"></see></summary>
    let SessionManagementStatement = _prefix "SessionManagementStatement"
    /// <summary>
    /// The SQL aggregate function that returns the number of rows or non NULL values from the result set.
    /// <see href="http://ns.inria.fr/ast/sql#Count"></see></summary>
    let Count = _prefix "Count"
    /// <summary>
    /// A SQL CREATE statement.
    /// <see href="http://ns.inria.fr/ast/sql#CreateStatement"></see></summary>
    let CreateStatement = _prefix "CreateStatement"
    /// <summary>
    /// Join predicate used to perform the cross-product of two tables.
    /// <see href="http://ns.inria.fr/ast/sql#CrossJoin"></see></summary>
    let CrossJoin = _prefix "CrossJoin"
    /// <summary>
    /// Binary predicate used join two or more tables.
    /// <see href="http://ns.inria.fr/ast/sql#JoinPredicate"></see></summary>
    let JoinPredicate = _prefix "JoinPredicate"
    /// <summary>
    /// A SQL data manipulation statement.
    /// <see href="http://ns.inria.fr/ast/sql#DataManipulationStatement"></see></summary>
    let DataManipulationStatement = _prefix "DataManipulationStatement"
    /// <summary>
    /// A SQL scalar function returns a single value given the input values. The input value is of a SQL primitive data type.
    /// <see href="http://ns.inria.fr/ast/sql#ScalarFunction"></see></summary>
    let ScalarFunction = _prefix "ScalarFunction"
    /// <summary>
    /// A SQL date time function returns a date or time value or performs a specific date or time value computation.
    /// <see href="http://ns.inria.fr/ast/sql#DateTimeFunction"></see></summary>
    let DateTimeFunction = _prefix "DateTimeFunction"
    /// <summary>
    /// A SQL DELETE statement.
    /// <see href="http://ns.inria.fr/ast/sql#DeleteStatement"></see></summary>
    let DeleteStatement = _prefix "DeleteStatement"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Div"></see>
    /// </summary>
    let Div = _prefix "Div"
    /// <summary>
    /// A SQL DROP statement.
    /// <see href="http://ns.inria.fr/ast/sql#DropStatement"></see></summary>
    let DropStatement = _prefix "DropStatement"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Equals"></see>
    /// </summary>
    let Equals = _prefix "Equals"
    /// <summary>
    /// A SQL exclusion operator used to return the result set produced by removing the result rows of the second query that appear in the result set of the first query.
    /// <see href="http://ns.inria.fr/ast/sql#Except"></see></summary>
    let Except = _prefix "Except"
    /// <summary>
    /// A SQL set operator used to perform set operation on the results of two or more queries.
    /// <see href="http://ns.inria.fr/ast/sql#SetOperator"></see></summary>
    let SetOperator = _prefix "SetOperator"
    /// <summary>
    /// Unary predicate that returns one of the TRUE or FALSE truth values depending on whether the evaluated subquery returns an empty result set.
    /// <see href="http://ns.inria.fr/ast/sql#Exists"></see></summary>
    let Exists = _prefix "Exists"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#FullOuterJoin"></see>
    /// </summary>
    let FullOuterJoin = _prefix "FullOuterJoin"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#OuterJoin"></see>
    /// </summary>
    let OuterJoin = _prefix "OuterJoin"
    /// <summary>
    /// A SQL function expressions consists in the use of any built-in SQL function.
    /// <see href="http://ns.inria.fr/ast/sql#FunctionExpression"></see></summary>
    let FunctionExpression = _prefix "FunctionExpression"
    /// <summary>
    /// A SQL GRANT statement used to give a set of privileges or roles to specified users that are actionable on specified database objects.
    /// <see href="http://ns.inria.fr/ast/sql#Grant"></see></summary>
    let Grant = _prefix "Grant"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#GreaterEquals"></see>
    /// </summary>
    let GreaterEquals = _prefix "GreaterEquals"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#GreaterThan"></see>
    /// </summary>
    let GreaterThan = _prefix "GreaterThan"
    /// <summary>
    /// A SQL import or export statement.
    /// <see href="http://ns.inria.fr/ast/sql#IOStatement"></see></summary>
    let IOStatement = _prefix "IOStatement"
    /// <summary>
    /// Variadic predicate used to assert whether the first provided expression's value is within the set of following provided expressions' values.
    /// <see href="http://ns.inria.fr/ast/sql#In"></see></summary>
    let In = _prefix "In"
    /// <summary>
    /// A reference or declarative statement for a catalog index.
    /// <see href="http://ns.inria.fr/ast/sql#Index"></see></summary>
    let Index = _prefix "Index"
    /// <summary>
    /// A valid identifier for a catalog index.
    /// <see href="http://ns.inria.fr/ast/sql#IndexIdentifier"></see></summary>
    let IndexIdentifier = _prefix "IndexIdentifier"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#InnerJoin"></see>
    /// </summary>
    let InnerJoin = _prefix "InnerJoin"
    /// <summary>
    /// A SQL INSERT statement.
    /// <see href="http://ns.inria.fr/ast/sql#InsertStatement"></see></summary>
    let InsertStatement = _prefix "InsertStatement"
    /// <summary>
    /// A SQL intersection operator used to return the common result rows of the combination of the result sets of two or more queries.
    /// <see href="http://ns.inria.fr/ast/sql#Intersect"></see></summary>
    let Intersect = _prefix "Intersect"
    /// <summary>
    /// Unary predicate that compares the evaluated expression's value with NULL
    /// <see href="http://ns.inria.fr/ast/sql#IsNull"></see></summary>
    let IsNull = _prefix "IsNull"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#LeftOuterJoin"></see>
    /// </summary>
    let LeftOuterJoin = _prefix "LeftOuterJoin"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#LessEquals"></see>
    /// </summary>
    let LessEquals = _prefix "LessEquals"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#LessThan"></see>
    /// </summary>
    let LessThan = _prefix "LessThan"
    /// <summary>
    /// Binary predicate that returns one of the TRUE or FALSE truth values depending on whether the string resulting in the evaluation of the first expression matches the lightweight regular expression described in the second expression.
    /// <see href="http://ns.inria.fr/ast/sql#Like"></see></summary>
    let Like = _prefix "Like"
    /// <summary>
    /// A SQL LOCK TABLE statement.
    /// <see href="http://ns.inria.fr/ast/sql#LockTableStatement"></see></summary>
    let LockTableStatement = _prefix "LockTableStatement"
    /// <summary>
    /// The SQL aggregate function that returns the maximum value of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Max"></see></summary>
    let Max = _prefix "Max"
    /// <summary>
    /// The SQL aggregate function that returns the minimum value of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Min"></see></summary>
    let Min = _prefix "Min"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Minus"></see>
    /// </summary>
    let Minus = _prefix "Minus"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Mult"></see>
    /// </summary>
    let Mult = _prefix "Mult"
    /// <summary>
    /// A unary arithmetic operator used to produce the negative of its operand.
    /// <see href="http://ns.inria.fr/ast/sql#Negate"></see></summary>
    let Negate = _prefix "Negate"
    /// <summary>
    /// A SQL logical negation that can be used to negate any condition.
    /// <see href="http://ns.inria.fr/ast/sql#Not"></see></summary>
    let Not = _prefix "Not"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#NotEquals"></see>
    /// </summary>
    let NotEquals = _prefix "NotEquals"
    /// <summary>
    /// A SQL now function is a nullary function that returns the current timestamp.
    /// <see href="http://ns.inria.fr/ast/sql#Now"></see></summary>
    let Now = _prefix "Now"
    /// <summary>
    /// A SQL number function that returns a numeric value and reads numeric values or string with numeric characters.
    /// <see href="http://ns.inria.fr/ast/sql#NumberFunction"></see></summary>
    let NumberFunction = _prefix "NumberFunction"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Or"></see>
    /// </summary>
    let Or = _prefix "Or"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#Plus"></see>
    /// </summary>
    let Plus = _prefix "Plus"
    /// <summary>
    /// A reference or declarative statement for a catalog procedure.
    /// <see href="http://ns.inria.fr/ast/sql#Procedure"></see></summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    /// A valid identifier for a catalog procedure.
    /// <see href="http://ns.inria.fr/ast/sql#ProcedureIdentifier"></see></summary>
    let ProcedureIdentifier = _prefix "ProcedureIdentifier"
    /// <summary>
    /// A SQL REVOKE statement used to revoke a set of privileges or roles to specified users from specified database objects.
    /// <see href="http://ns.inria.fr/ast/sql#Revoke"></see></summary>
    let Revoke = _prefix "Revoke"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ast/sql#RightOuterJoin"></see>
    /// </summary>
    let RightOuterJoin = _prefix "RightOuterJoin"
    /// <summary>
    /// A reference or declarative statement for a catalog role.
    /// <see href="http://ns.inria.fr/ast/sql#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A valid identifier for a catalog role.
    /// <see href="http://ns.inria.fr/ast/sql#RoleIdentifier"></see></summary>
    let RoleIdentifier = _prefix "RoleIdentifier"
    /// <summary>
    /// A SQL ROLLBACK statement.
    /// <see href="http://ns.inria.fr/ast/sql#RollbackStatement"></see></summary>
    let RollbackStatement = _prefix "RollbackStatement"
    /// <summary>
    /// A reference or declarative statement for a catalog schema.
    /// <see href="http://ns.inria.fr/ast/sql#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    /// A valid identifier for a catalog schema.
    /// <see href="http://ns.inria.fr/ast/sql#SchemaIdentifier"></see></summary>
    let SchemaIdentifier = _prefix "SchemaIdentifier"
    /// <summary>
    /// A SQL SELECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#SelectStatement"></see></summary>
    let SelectStatement = _prefix "SelectStatement"
    /// <summary>
    /// A reference or declarative statement for a catalog sequence.
    /// <see href="http://ns.inria.fr/ast/sql#Sequence"></see></summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    /// A valid identifier for a catalog sequence.
    /// <see href="http://ns.inria.fr/ast/sql#SequenceIdentifier"></see></summary>
    let SequenceIdentifier = _prefix "SequenceIdentifier"
    /// <summary>
    /// Assigns a value to a session variable identifier.
    /// <see href="http://ns.inria.fr/ast/sql#SetStatement"></see></summary>
    let SetStatement = _prefix "SetStatement"
    /// <summary>
    /// The SQL aggregate function that returns the standard deviation (square root of the variance) of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#StdDev"></see></summary>
    let StdDev = _prefix "StdDev"
    /// <summary>
    /// The SQL aggregate function that returns the sum of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Sum"></see></summary>
    let Sum = _prefix "Sum"
    /// <summary>
    /// A reference or declarative statement for a catalog table.
    /// <see href="http://ns.inria.fr/ast/sql#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// A SQL function that returns a virtual table.
    /// <see href="http://ns.inria.fr/ast/sql#TableFunction"></see></summary>
    let TableFunction = _prefix "TableFunction"
    /// <summary>
    /// A valid identifier for a catalog table.
    /// <see href="http://ns.inria.fr/ast/sql#TableIdentifier"></see></summary>
    let TableIdentifier = _prefix "TableIdentifier"
    /// <summary>
    /// A SQL union operator used to return the combination of the result sets of two or more queries.
    /// <see href="http://ns.inria.fr/ast/sql#Union"></see></summary>
    let Union = _prefix "Union"
    /// <summary>
    /// A SQL union operator used to return the combination of the result sets of two or more queries, including duplicate result rows.
    /// <see href="http://ns.inria.fr/ast/sql#UnionAll"></see></summary>
    let UnionAll = _prefix "UnionAll"
    /// <summary>
    /// A SQL UPDATE statement.
    /// <see href="http://ns.inria.fr/ast/sql#UpdateStatement"></see></summary>
    let UpdateStatement = _prefix "UpdateStatement"
    /// <summary>
    /// A reference or declarative statement for a catalog user.
    /// <see href="http://ns.inria.fr/ast/sql#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// A valid identifier for a catalog user.
    /// <see href="http://ns.inria.fr/ast/sql#UserIdentifier"></see></summary>
    let UserIdentifier = _prefix "UserIdentifier"
    /// <summary>
    /// The SQL aggregate function that returns the variance of the given expression.
    /// <see href="http://ns.inria.fr/ast/sql#Var"></see></summary>
    let Var = _prefix "Var"
    /// <summary>
    /// A reference or declarative statement for a catalog view.
    /// <see href="http://ns.inria.fr/ast/sql#View"></see></summary>
    let View = _prefix "View"
    /// <summary>
    /// A valid identifier for a catalog view.
    /// <see href="http://ns.inria.fr/ast/sql#ViewIdentifier"></see></summary>
    let ViewIdentifier = _prefix "ViewIdentifier"
    /// <summary>
    /// The generic predicate used to attach an ordered list of children to any AST node.
    /// <see href="http://ns.inria.fr/ast/sql#args"></see></summary>
    let args = _prefix "args"
    /// <summary>
    /// A SQL clause is a part of a statement.
    /// <see href="http://ns.inria.fr/ast/sql#clause"></see></summary>
    let clause = _prefix "clause"
    /// <summary>
    /// The SQL clause that specifies the target sources (tables, views, subqueries) of a SELECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// The SQL clause that specifies the columns whose values will be considered to cluster the result set of selected rows.
    /// <see href="http://ns.inria.fr/ast/sql#groupBy"></see></summary>
    let groupBy = _prefix "groupBy"
    /// <summary>
    /// The SQL clause that specifies the filtering predicates to apply on the clustered result set resulting of a GROUP BY clause.
    /// <see href="http://ns.inria.fr/ast/sql#having"></see></summary>
    let having = _prefix "having"
    /// <summary>
    /// The SQL clause that specifies into which table the following values or select statement's result set are to be inserted into.
    /// <see href="http://ns.inria.fr/ast/sql#into"></see></summary>
    let into = _prefix "into"
    /// <summary>
    /// The SQL clause that limits the number of records from the result set that should be returned.
    /// <see href="http://ns.inria.fr/ast/sql#limit"></see></summary>
    let limit = _prefix "limit"
    /// <summary>
    /// The SQL clause that specifies how to order the result set's records according to given expressions.
    /// <see href="http://ns.inria.fr/ast/sql#orderBy"></see></summary>
    let orderBy = _prefix "orderBy"
    /// <summary>
    /// The SQL clause that specifies the projected tables of a SELECT statement.
    /// <see href="http://ns.inria.fr/ast/sql#select"></see></summary>
    let select = _prefix "select"
    /// <summary>
    /// The SQL clause that specifies a list of values or expressions evaluating to values.
    /// <see href="http://ns.inria.fr/ast/sql#values"></see></summary>
    let values = _prefix "values"
    /// <summary>
    /// The SQL clause that specifies the filtering predicates to apply on the inputs of the FROM clause.
    /// <see href="http://ns.inria.fr/ast/sql#where"></see></summary>
    let where = _prefix "where"
