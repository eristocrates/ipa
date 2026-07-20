namespace http.spinrdf.org.sp.hash

open DoxAletheia

module sp =
    let _namespace_name = "http://spinrdf.org/sp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Base class of aggregation types (not part of the SPARQL 1.0 standard but supported by ARQ and other engines).
    /// <see href="http://spinrdf.org/sp#Aggregation"></see></summary>
    let Aggregation = _prefix "Aggregation"
    /// <summary>
    /// An "artificial" root class that groups all SP classes. This makes them look much less overwhelming in UI tools. Typical end users don't need to see those classes anyway.
    /// <see href="http://spinrdf.org/sp#SystemClass"></see></summary>
    let SystemClass = _prefix "SystemClass"
    /// <summary>
    /// An alternative path with the union of sp:path1 and sp:path2.
    /// <see href="http://spinrdf.org/sp#AltPath"></see></summary>
    let AltPath = _prefix "AltPath"
    /// <summary>
    /// The base class of SPARQL property path expressions. Paths are used by sp:TriplePath triple paths.
    /// <see href="http://spinrdf.org/sp#Path"></see></summary>
    let Path = _prefix "Path"
    /// <summary>
    /// Marker to indicate ascending order.
    /// <see href="http://spinrdf.org/sp#Asc"></see></summary>
    let Asc = _prefix "Asc"
    /// <summary>
    /// An abstract base class for ascending or descending order conditions. Instances of this class (typically bnodes) must have a value for expression to point to the actual values.
    /// <see href="http://spinrdf.org/sp#OrderByCondition"></see></summary>
    let OrderByCondition = _prefix "OrderByCondition"
    /// <summary>
    /// An ASK query that returns true if the condition in the body is met by at least one result set.
    /// <see href="http://spinrdf.org/sp#Ask"></see></summary>
    let Ask = _prefix "Ask"
    /// <summary>
    /// Abstract base class of the various types of supported queries. Common to all types of queries is that they can have a body ("WHERE clause").
    /// <see href="http://spinrdf.org/sp#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// Represents AVG aggregations.
    /// <see href="http://spinrdf.org/sp#Avg"></see></summary>
    let Avg = _prefix "Avg"
    /// <summary>
    /// A BIND element.
    /// <see href="http://spinrdf.org/sp#Bind"></see></summary>
    let Bind = _prefix "Bind"
    /// <summary>
    /// An abstract base class for all pattern elements.
    /// <see href="http://spinrdf.org/sp#Element"></see></summary>
    let Element = _prefix "Element"
    /// <summary>
    /// An Update operation that removes all triples from a specified graph. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent.
    /// <see href="http://spinrdf.org/sp#Clear"></see></summary>
    let Clear = _prefix "Clear"
    /// <summary>
    /// Abstract base class to group the various SPARQL UPDATE commands.
    /// <see href="http://spinrdf.org/sp#Update"></see></summary>
    let Update = _prefix "Update"
    /// <summary>
    /// A shared superclass for sp:Query and sp:Update that can be used to specify that the range of property can be either one.
    /// <see href="http://spinrdf.org/sp#Command"></see></summary>
    let Command = _prefix "Command"
    /// <summary>
    /// A CONSTRUCT-type query that can be used to construct new triples from template triples (head) that use variable bindings from the match patterns (body).
    /// <see href="http://spinrdf.org/sp#Construct"></see></summary>
    let Construct = _prefix "Construct"
    /// <summary>
    /// Counts the number of times a variable is used. The variable is stored in the variable property. This might be left blank to indicate COUNT(*).
    /// <see href="http://spinrdf.org/sp#Count"></see></summary>
    let Count = _prefix "Count"
    /// <summary>
    /// An Update operation that creates a new empty graph with a name specified by sp:graphIRI. May have sp:silent set to true.
    /// <see href="http://spinrdf.org/sp#Create"></see></summary>
    let Create = _prefix "Create"
    /// <summary>
    /// Deprecated - use sp:Modify instead.
    ///
    /// Represents a DELETE FROM (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:deletePattern. The WHERE clause is represented using sp:where.
    /// <see href="http://spinrdf.org/sp#Delete"></see></summary>
    let Delete = _prefix "Delete"
    /// <summary>
    /// Represents a MODIFY (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns are stored in sp:deletePattern and sp:insertPattern. The WHERE clause is represented using sp:where.
    /// <see href="http://spinrdf.org/sp#Modify"></see></summary>
    let Modify = _prefix "Modify"
    /// <summary>
    /// An Update operation to delete specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs.
    /// <see href="http://spinrdf.org/sp#DeleteData"></see></summary>
    let DeleteData = _prefix "DeleteData"
    /// <summary>
    /// An Update operation where the triples matched by the WHERE clause (sp:where) will be the triples deleted.
    /// <see href="http://spinrdf.org/sp#DeleteWhere"></see></summary>
    let DeleteWhere = _prefix "DeleteWhere"
    /// <summary>
    /// Marker to indicate descending order.
    /// <see href="http://spinrdf.org/sp#Desc"></see></summary>
    let Desc = _prefix "Desc"
    /// <summary>
    /// A DESCRIBE-type Query.
    /// <see href="http://spinrdf.org/sp#Describe"></see></summary>
    let Describe = _prefix "Describe"
    /// <summary>
    /// An Update operation that removes a specified graph from the Graph Store. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent.
    /// <see href="http://spinrdf.org/sp#Drop"></see></summary>
    let Drop = _prefix "Drop"
    /// <summary>
    /// Abstract base class of group patterns.
    /// <see href="http://spinrdf.org/sp#ElementGroup"></see></summary>
    let ElementGroup = _prefix "ElementGroup"
    /// <summary>
    /// A list of Elements. This class is never instantiated directly as SPIN will use plain rdf:Lists to store element lists.
    /// <see href="http://spinrdf.org/sp#ElementList"></see></summary>
    let ElementList = _prefix "ElementList"
    /// <summary>
    /// An EXISTS element group.
    /// <see href="http://spinrdf.org/sp#Exists"></see></summary>
    let Exists = _prefix "Exists"
    /// <summary>
    /// A constraint element that evaluates a given expression to true or false.
    /// <see href="http://spinrdf.org/sp#Filter"></see></summary>
    let Filter = _prefix "Filter"
    /// <summary>
    /// Represents GROUP_CONCAT aggregations.
    /// <see href="http://spinrdf.org/sp#GroupConcat"></see></summary>
    let GroupConcat = _prefix "GroupConcat"
    /// <summary>
    /// Deprecated - use sp:Modify instead.
    ///
    /// Represents a INSERT INTO (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:insertPattern. The WHERE clause is represented using sp:where.
    /// <see href="http://spinrdf.org/sp#Insert"></see></summary>
    let Insert = _prefix "Insert"
    /// <summary>
    /// An Update operation to insert specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs.
    /// <see href="http://spinrdf.org/sp#InsertData"></see></summary>
    let InsertData = _prefix "InsertData"
    /// <summary>
    /// Deprecated: use sp:Bind instead.
    ///
    /// A variable assignment (LET (?&lt;varName&gt; := &lt;expression&gt;)). Not part of the SPARQL 1.0 standard, but (for example) ARQ.
    /// <see href="http://spinrdf.org/sp#Let"></see></summary>
    let Let = _prefix "Let"
    /// <summary>
    /// A LOAD Update operation. The document to load is specified using sp:document, and the (optional) target graph using sp:into.
    /// <see href="http://spinrdf.org/sp#Load"></see></summary>
    let Load = _prefix "Load"
    /// <summary>
    /// Represents MAX aggregations.
    /// <see href="http://spinrdf.org/sp#Max"></see></summary>
    let Max = _prefix "Max"
    /// <summary>
    /// Represents MIN aggregations.
    /// <see href="http://spinrdf.org/sp#Min"></see></summary>
    let Min = _prefix "Min"
    /// <summary>
    /// A MINUS element group.
    /// <see href="http://spinrdf.org/sp#Minus"></see></summary>
    let Minus = _prefix "Minus"
    /// <summary>
    /// A modified path such as rdfs:subClassOf*.
    /// <see href="http://spinrdf.org/sp#ModPath"></see></summary>
    let ModPath = _prefix "ModPath"
    /// <summary>
    /// A named Graph element such as GRAPH &lt;uri&gt; {...}.
    /// <see href="http://spinrdf.org/sp#NamedGraph"></see></summary>
    let NamedGraph = _prefix "NamedGraph"
    /// <summary>
    /// A NOT EXISTS element group.
    /// <see href="http://spinrdf.org/sp#NotExists"></see></summary>
    let NotExists = _prefix "NotExists"
    /// <summary>
    /// An optional element in a query.
    /// <see href="http://spinrdf.org/sp#Optional"></see></summary>
    let Optional = _prefix "Optional"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#ReverseLinkPath"></see>
    /// </summary>
    let ReverseLinkPath = _prefix "ReverseLinkPath"
    /// <summary>
    /// A path with reversed direction.
    /// <see href="http://spinrdf.org/sp#ReversePath"></see></summary>
    let ReversePath = _prefix "ReversePath"
    /// <summary>
    /// Represents SAMPLE aggregations
    /// <see href="http://spinrdf.org/sp#Sample"></see></summary>
    let Sample = _prefix "Sample"
    /// <summary>
    /// A SELECT-type query that returns variable bindings as its result.
    /// <see href="http://spinrdf.org/sp#Select"></see></summary>
    let Select = _prefix "Select"
    /// <summary>
    /// A sequence of multiple paths.
    /// <see href="http://spinrdf.org/sp#SeqPath"></see></summary>
    let SeqPath = _prefix "SeqPath"
    /// <summary>
    /// A SERVICE call that matches a nested sub-pattern against a SPARQL end point specified by a URI.
    /// <see href="http://spinrdf.org/sp#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A nested SELECT query inside of an element list. The query is stored in sp:query.
    /// <see href="http://spinrdf.org/sp#SubQuery"></see></summary>
    let SubQuery = _prefix "SubQuery"
    /// <summary>
    /// Represents sum aggregations, e.g. SELECT SUM(?varName)...
    /// <see href="http://spinrdf.org/sp#Sum"></see></summary>
    let Sum = _prefix "Sum"
    /// <summary>
    /// A base class for TriplePattern and TripleTemplate. This basically specifies that subject, predicate and object must be present.
    /// <see href="http://spinrdf.org/sp#Triple"></see></summary>
    let Triple = _prefix "Triple"
    /// <summary>
    /// Abstract base class for things that have subject and object.
    /// <see href="http://spinrdf.org/sp#Tuple"></see></summary>
    let Tuple = _prefix "Tuple"
    /// <summary>
    /// Similar to a TriplePattern, but with a path expression as its predicate. For example, this can be used to express transitive sub-class relationships (?subClass rdfs:subClassOf* ?superClass).
    /// <see href="http://spinrdf.org/sp#TriplePath"></see></summary>
    let TriplePath = _prefix "TriplePath"
    /// <summary>
    /// A triple pattern used in the body of a query.
    /// <see href="http://spinrdf.org/sp#TriplePattern"></see></summary>
    let TriplePattern = _prefix "TriplePattern"
    /// <summary>
    /// A prototypical triple used as template in the head of a Construct query. May contain variables.
    /// <see href="http://spinrdf.org/sp#TripleTemplate"></see></summary>
    let TripleTemplate = _prefix "TripleTemplate"
    /// <summary>
    /// A UNION group.
    /// <see href="http://spinrdf.org/sp#Union"></see></summary>
    let Union = _prefix "Union"
    /// <summary>
    /// A VALUES element. sp:varNames points to an rdf:List of strings for the variables, sp:values to an rdf:List of rdf:Lists with nodes for each variable, in the order defined by the variables list.
    /// <see href="http://spinrdf.org/sp#Values"></see></summary>
    let Values = _prefix "Values"
    /// <summary>
    /// A variable mentioned in a Triple or expression. Variables are often blank nodes with the variable name stored in ts:name. Variables can also be supplied with a URI in which case the system will attempt to reuse the same variable instance across multiple query definitions.
    /// <see href="http://spinrdf.org/sp#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// Used in DROP and CLEAR.
    /// <see href="http://spinrdf.org/sp#all"></see></summary>
    let all = _prefix "all"
    /// <summary>
    /// An abstract base proprerty that groups together the SP system properties. Users typically don't need to see them anyway.
    /// <see href="http://spinrdf.org/sp#systemProperty"></see></summary>
    let systemProperty = _prefix "systemProperty"
    /// <summary>
    /// Abstract superproperty for the enumerated arg1, arg2 etc.
    /// <see href="http://spinrdf.org/sp#arg"></see></summary>
    let arg = _prefix "arg"
    /// <summary>
    /// The first argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg1"></see></summary>
    let arg1 = _prefix "arg1"
    /// <summary>
    /// The second argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg2"></see></summary>
    let arg2 = _prefix "arg2"
    /// <summary>
    /// The third argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg3"></see></summary>
    let arg3 = _prefix "arg3"
    /// <summary>
    /// The forth argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg4"></see></summary>
    let arg4 = _prefix "arg4"
    /// <summary>
    /// The fifth argument of a function call. Further arguments are not common in SPARQL, therefore no sp:arg6, etc are defined here. However, they can be created if needed.
    /// <see href="http://spinrdf.org/sp#arg5"></see></summary>
    let arg5 = _prefix "arg5"
    /// <summary>
    /// Points to a Variable used in an AS statement such as COUNT aggregates.
    /// <see href="http://spinrdf.org/sp#as"></see></summary>
    let as_ = _prefix "as"
    /// <summary>
    /// The actual bindings of a sp:Values element.
    /// <see href="http://spinrdf.org/sp#bindings"></see></summary>
    let bindings = _prefix "bindings"
    /// <summary>
    /// Used in DROP and CLEAR.
    /// <see href="http://spinrdf.org/sp#default"></see></summary>
    let default_ = _prefix "default"
    /// <summary>
    /// Points to a list of sp:TripleTemplates and sp:NamedGraphs in a modify operation.
    /// <see href="http://spinrdf.org/sp#deletePattern"></see></summary>
    let deletePattern = _prefix "deletePattern"
    /// <summary>
    /// A marker property to indicate that a Select query is of type SELECT DISTINCT.
    /// <see href="http://spinrdf.org/sp#distinct"></see></summary>
    let distinct = _prefix "distinct"
    /// <summary>
    /// The URI of the document to load using a LOAD Update operation.
    /// <see href="http://spinrdf.org/sp#document"></see></summary>
    let document = _prefix "document"
    /// <summary>
    /// Points to an ElementList, for example in an Optional element.
    /// <see href="http://spinrdf.org/sp#elements"></see></summary>
    let elements = _prefix "elements"
    /// <summary>
    /// Points to an expression, for example in a Filter or Assignment.
    /// <see href="http://spinrdf.org/sp#expression"></see></summary>
    let expression = _prefix "expression"
    /// <summary>
    /// Specifies an RDF Dataset used by a Query (FROM syntax in SPARQL). Values of this property must be URI resources.
    /// <see href="http://spinrdf.org/sp#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// Specifies a named RDF Dataset used by a Query (FROM NAMED syntax in SPARQL). Values of this property must be URI resources.
    /// <see href="http://spinrdf.org/sp#fromNamed"></see></summary>
    let fromNamed = _prefix "fromNamed"
    /// <summary>
    /// Points to graph names (IRIs) in various sp:Update operations.
    /// <see href="http://spinrdf.org/sp#graphIRI"></see></summary>
    let graphIRI = _prefix "graphIRI"
    /// <summary>
    /// The name (URI or Variable) of a NamedGraph.
    /// <see href="http://spinrdf.org/sp#graphNameNode"></see></summary>
    let graphNameNode = _prefix "graphNameNode"
    /// <summary>
    /// Points from a Query to the list of GROUP BY expressions.
    /// <see href="http://spinrdf.org/sp#groupBy"></see></summary>
    let groupBy = _prefix "groupBy"
    /// <summary>
    /// Points from a SELECT query to a list of HAVING expressions.
    /// <see href="http://spinrdf.org/sp#having"></see></summary>
    let having = _prefix "having"
    /// <summary>
    /// Points to a list of sp:TripleTemplates or sp:NamedGraphs in a modify command.
    /// <see href="http://spinrdf.org/sp#insertPattern"></see></summary>
    let insertPattern = _prefix "insertPattern"
    /// <summary>
    /// The (optional) target of a LOAD Update operation.
    /// <see href="http://spinrdf.org/sp#into"></see></summary>
    let into = _prefix "into"
    /// <summary>
    /// The LIMIT solution modifier of a Query.
    /// <see href="http://spinrdf.org/sp#limit"></see></summary>
    let limit = _prefix "limit"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#modMax"></see>
    /// </summary>
    let modMax = _prefix "modMax"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#modMin"></see>
    /// </summary>
    let modMin = _prefix "modMin"
    /// <summary>
    /// Used in DROP and CLEAR.
    /// <see href="http://spinrdf.org/sp#named"></see></summary>
    let named = _prefix "named"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#node"></see>
    /// </summary>
    let node = _prefix "node"
    /// <summary>
    /// An RDF Node or Variable describing the object of a triple.
    /// <see href="http://spinrdf.org/sp#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// The OFFSET solution modifier of a Query.
    /// <see href="http://spinrdf.org/sp#offset"></see></summary>
    let offset = _prefix "offset"
    /// <summary>
    /// Links a query with an ORDER BY clause where the values are rdf:List containing OrderByConditions or expressions. While the domain of this property is sp:Query, only Describe and Select queries can have values of it.
    /// <see href="http://spinrdf.org/sp#orderBy"></see></summary>
    let orderBy = _prefix "orderBy"
    /// <summary>
    /// Points from a TriplePath to its path.
    /// <see href="http://spinrdf.org/sp#path"></see></summary>
    let path = _prefix "path"
    /// <summary>
    /// The first child path of a property path. Used by sp:AltPath and sp:SeqPath.
    /// <see href="http://spinrdf.org/sp#path1"></see></summary>
    let path1 = _prefix "path1"
    /// <summary>
    /// The second child path of a property path. Used by sp:AltPath and sp:SeqPath.
    /// <see href="http://spinrdf.org/sp#path2"></see></summary>
    let path2 = _prefix "path2"
    /// <summary>
    /// A resource or Variable describing the predicate of a triple.
    /// <see href="http://spinrdf.org/sp#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// Links a SubQuery resource with the nested Query.
    /// <see href="http://spinrdf.org/sp#query"></see></summary>
    let query = _prefix "query"
    /// <summary>
    /// A property with true to indicate that a Select query has a REDUCED flag.
    /// <see href="http://spinrdf.org/sp#reduced"></see></summary>
    let reduced = _prefix "reduced"
    /// <summary>
    /// Contains the result nodes (URI resources or Variables) of a Describe query.
    /// <see href="http://spinrdf.org/sp#resultNodes"></see></summary>
    let resultNodes = _prefix "resultNodes"
    /// <summary>
    /// An rdf:List of variables that are returned by a Select query.
    /// <see href="http://spinrdf.org/sp#resultVariables"></see></summary>
    let resultVariables = _prefix "resultVariables"
    /// <summary>
    /// Stores the separator="..." value of a GROUP_CONCAT (sp:GroupConcat) aggregation.
    /// <see href="http://spinrdf.org/sp#separator"></see></summary>
    let separator = _prefix "separator"
    /// <summary>
    /// Used by sp:Service to specify the URI of the SPARQL end point to invoke. Must point to a URI node.
    /// <see href="http://spinrdf.org/sp#serviceURI"></see></summary>
    let serviceURI = _prefix "serviceURI"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#silent"></see>
    /// </summary>
    let silent = _prefix "silent"
    /// <summary>
    /// The child path of a property path expression. This is used by ReversePath and ModPath.
    /// <see href="http://spinrdf.org/sp#subPath"></see></summary>
    let subPath = _prefix "subPath"
    /// <summary>
    /// A resource or Variable describing the subject of a triple.
    /// <see href="http://spinrdf.org/sp#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// Points to a list of TripleTemplates that form the head of a Construct query.
    /// <see href="http://spinrdf.org/sp#templates"></see></summary>
    let templates = _prefix "templates"
    /// <summary>
    /// Can be attached to sp:Queries to store a textual representation of the query. This can be useful for tools that do not have a complete SPIN Syntax parser available.
    /// <see href="http://spinrdf.org/sp#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#using"></see>
    /// </summary>
    let using = _prefix "using"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#usingNamed"></see>
    /// </summary>
    let usingNamed = _prefix "usingNamed"
    /// <summary>
    /// The VALUES block at the end of a query. The object may just be an untyped blank node, i.e. the sp:Values type triple is optional.
    /// <see href="http://spinrdf.org/sp#values"></see></summary>
    let values = _prefix "values"
    /// <summary>
    /// The name of a Variable.
    /// <see href="http://spinrdf.org/sp#varName"></see></summary>
    let varName = _prefix "varName"
    /// <summary>
    /// The names of the variables (xsd:strings) of the variables declared for a VALUES element.
    /// <see href="http://spinrdf.org/sp#varNames"></see></summary>
    let varNames = _prefix "varNames"
    /// <summary>
    /// The variable of a Bind element.
    /// <see href="http://spinrdf.org/sp#variable"></see></summary>
    let variable = _prefix "variable"
    /// <summary>
    /// The WHERE clause of a Query.
    /// <see href="http://spinrdf.org/sp#where"></see></summary>
    let where = _prefix "where"
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#with"></see>
    /// </summary>
    let with_ = _prefix "with"
