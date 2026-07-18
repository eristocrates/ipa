namespace http.spinrdf.org.sp.hash

open DoxAletheia.Rdf_Vocabulary

module sp =
    let _namespace_name = "http://spinrdf.org/sp#"

    /// <summary>
    /// Base class of aggregation types (not part of the SPARQL 1.0 standard but supported by ARQ and other engines).
    /// <see href="http://spinrdf.org/sp#Aggregation"></see></summary>
    let Aggregation =
        Namespaced_IRI.parse _namespace_name "Aggregation" |> NamespacedName

    /// <summary>
    /// An "artificial" root class that groups all SP classes. This makes them look much less overwhelming in UI tools. Typical end users don't need to see those classes anyway.
    /// <see href="http://spinrdf.org/sp#SystemClass"></see></summary>
    let SystemClass =
        Namespaced_IRI.parse _namespace_name "SystemClass" |> NamespacedName

    /// <summary>
    /// An alternative path with the union of sp:path1 and sp:path2.
    /// <see href="http://spinrdf.org/sp#AltPath"></see></summary>
    let AltPath = Namespaced_IRI.parse _namespace_name "AltPath" |> NamespacedName
    /// <summary>
    /// The base class of SPARQL property path expressions. Paths are used by sp:TriplePath triple paths.
    /// <see href="http://spinrdf.org/sp#Path"></see></summary>
    let Path = Namespaced_IRI.parse _namespace_name "Path" |> NamespacedName
    /// <summary>
    /// Marker to indicate ascending order.
    /// <see href="http://spinrdf.org/sp#Asc"></see></summary>
    let Asc = Namespaced_IRI.parse _namespace_name "Asc" |> NamespacedName

    /// <summary>
    /// An abstract base class for ascending or descending order conditions. Instances of this class (typically bnodes) must have a value for expression to point to the actual values.
    /// <see href="http://spinrdf.org/sp#OrderByCondition"></see></summary>
    let OrderByCondition =
        Namespaced_IRI.parse _namespace_name "OrderByCondition" |> NamespacedName

    /// <summary>
    /// An ASK query that returns true if the condition in the body is met by at least one result set.
    /// <see href="http://spinrdf.org/sp#Ask"></see></summary>
    let Ask = Namespaced_IRI.parse _namespace_name "Ask" |> NamespacedName
    /// <summary>
    /// Abstract base class of the various types of supported queries. Common to all types of queries is that they can have a body ("WHERE clause").
    /// <see href="http://spinrdf.org/sp#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    /// Represents AVG aggregations.
    /// <see href="http://spinrdf.org/sp#Avg"></see></summary>
    let Avg = Namespaced_IRI.parse _namespace_name "Avg" |> NamespacedName
    /// <summary>
    /// A BIND element.
    /// <see href="http://spinrdf.org/sp#Bind"></see></summary>
    let Bind = Namespaced_IRI.parse _namespace_name "Bind" |> NamespacedName
    /// <summary>
    /// An abstract base class for all pattern elements.
    /// <see href="http://spinrdf.org/sp#Element"></see></summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName
    /// <summary>
    /// An Update operation that removes all triples from a specified graph. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent.
    /// <see href="http://spinrdf.org/sp#Clear"></see></summary>
    let Clear = Namespaced_IRI.parse _namespace_name "Clear" |> NamespacedName
    /// <summary>
    /// Abstract base class to group the various SPARQL UPDATE commands.
    /// <see href="http://spinrdf.org/sp#Update"></see></summary>
    let Update = Namespaced_IRI.parse _namespace_name "Update" |> NamespacedName
    /// <summary>
    /// A shared superclass for sp:Query and sp:Update that can be used to specify that the range of property can be either one.
    /// <see href="http://spinrdf.org/sp#Command"></see></summary>
    let Command = Namespaced_IRI.parse _namespace_name "Command" |> NamespacedName
    /// <summary>
    /// A CONSTRUCT-type query that can be used to construct new triples from template triples (head) that use variable bindings from the match patterns (body).
    /// <see href="http://spinrdf.org/sp#Construct"></see></summary>
    let Construct = Namespaced_IRI.parse _namespace_name "Construct" |> NamespacedName
    /// <summary>
    /// Counts the number of times a variable is used. The variable is stored in the variable property. This might be left blank to indicate COUNT(*).
    /// <see href="http://spinrdf.org/sp#Count"></see></summary>
    let Count = Namespaced_IRI.parse _namespace_name "Count" |> NamespacedName
    /// <summary>
    /// An Update operation that creates a new empty graph with a name specified by sp:graphIRI. May have sp:silent set to true.
    /// <see href="http://spinrdf.org/sp#Create"></see></summary>
    let Create = Namespaced_IRI.parse _namespace_name "Create" |> NamespacedName
    /// <summary>
    /// Deprecated - use sp:Modify instead.
    ///
    /// Represents a DELETE FROM (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:deletePattern. The WHERE clause is represented using sp:where.
    /// <see href="http://spinrdf.org/sp#Delete"></see></summary>
    let Delete = Namespaced_IRI.parse _namespace_name "Delete" |> NamespacedName
    /// <summary>
    /// Represents a MODIFY (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns are stored in sp:deletePattern and sp:insertPattern. The WHERE clause is represented using sp:where.
    /// <see href="http://spinrdf.org/sp#Modify"></see></summary>
    let Modify = Namespaced_IRI.parse _namespace_name "Modify" |> NamespacedName
    /// <summary>
    /// An Update operation to delete specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs.
    /// <see href="http://spinrdf.org/sp#DeleteData"></see></summary>
    let DeleteData = Namespaced_IRI.parse _namespace_name "DeleteData" |> NamespacedName

    /// <summary>
    /// An Update operation where the triples matched by the WHERE clause (sp:where) will be the triples deleted.
    /// <see href="http://spinrdf.org/sp#DeleteWhere"></see></summary>
    let DeleteWhere =
        Namespaced_IRI.parse _namespace_name "DeleteWhere" |> NamespacedName

    /// <summary>
    /// Marker to indicate descending order.
    /// <see href="http://spinrdf.org/sp#Desc"></see></summary>
    let Desc = Namespaced_IRI.parse _namespace_name "Desc" |> NamespacedName
    /// <summary>
    /// A DESCRIBE-type Query.
    /// <see href="http://spinrdf.org/sp#Describe"></see></summary>
    let Describe = Namespaced_IRI.parse _namespace_name "Describe" |> NamespacedName
    /// <summary>
    /// An Update operation that removes a specified graph from the Graph Store. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent.
    /// <see href="http://spinrdf.org/sp#Drop"></see></summary>
    let Drop = Namespaced_IRI.parse _namespace_name "Drop" |> NamespacedName

    /// <summary>
    /// Abstract base class of group patterns.
    /// <see href="http://spinrdf.org/sp#ElementGroup"></see></summary>
    let ElementGroup =
        Namespaced_IRI.parse _namespace_name "ElementGroup" |> NamespacedName

    /// <summary>
    /// A list of Elements. This class is never instantiated directly as SPIN will use plain rdf:Lists to store element lists.
    /// <see href="http://spinrdf.org/sp#ElementList"></see></summary>
    let ElementList =
        Namespaced_IRI.parse _namespace_name "ElementList" |> NamespacedName

    /// <summary>
    /// An EXISTS element group.
    /// <see href="http://spinrdf.org/sp#Exists"></see></summary>
    let Exists = Namespaced_IRI.parse _namespace_name "Exists" |> NamespacedName
    /// <summary>
    /// A constraint element that evaluates a given expression to true or false.
    /// <see href="http://spinrdf.org/sp#Filter"></see></summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName

    /// <summary>
    /// Represents GROUP_CONCAT aggregations.
    /// <see href="http://spinrdf.org/sp#GroupConcat"></see></summary>
    let GroupConcat =
        Namespaced_IRI.parse _namespace_name "GroupConcat" |> NamespacedName

    /// <summary>
    /// Deprecated - use sp:Modify instead.
    ///
    /// Represents a INSERT INTO (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:insertPattern. The WHERE clause is represented using sp:where.
    /// <see href="http://spinrdf.org/sp#Insert"></see></summary>
    let Insert = Namespaced_IRI.parse _namespace_name "Insert" |> NamespacedName
    /// <summary>
    /// An Update operation to insert specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs.
    /// <see href="http://spinrdf.org/sp#InsertData"></see></summary>
    let InsertData = Namespaced_IRI.parse _namespace_name "InsertData" |> NamespacedName
    /// <summary>
    /// Deprecated: use sp:Bind instead.
    ///
    /// A variable assignment (LET (?&lt;varName&gt; := &lt;expression&gt;)). Not part of the SPARQL 1.0 standard, but (for example) ARQ.
    /// <see href="http://spinrdf.org/sp#Let"></see></summary>
    let Let = Namespaced_IRI.parse _namespace_name "Let" |> NamespacedName
    /// <summary>
    /// A LOAD Update operation. The document to load is specified using sp:document, and the (optional) target graph using sp:into.
    /// <see href="http://spinrdf.org/sp#Load"></see></summary>
    let Load = Namespaced_IRI.parse _namespace_name "Load" |> NamespacedName
    /// <summary>
    /// Represents MAX aggregations.
    /// <see href="http://spinrdf.org/sp#Max"></see></summary>
    let Max = Namespaced_IRI.parse _namespace_name "Max" |> NamespacedName
    /// <summary>
    /// Represents MIN aggregations.
    /// <see href="http://spinrdf.org/sp#Min"></see></summary>
    let Min = Namespaced_IRI.parse _namespace_name "Min" |> NamespacedName
    /// <summary>
    /// A MINUS element group.
    /// <see href="http://spinrdf.org/sp#Minus"></see></summary>
    let Minus = Namespaced_IRI.parse _namespace_name "Minus" |> NamespacedName
    /// <summary>
    /// A modified path such as rdfs:subClassOf*.
    /// <see href="http://spinrdf.org/sp#ModPath"></see></summary>
    let ModPath = Namespaced_IRI.parse _namespace_name "ModPath" |> NamespacedName
    /// <summary>
    /// A named Graph element such as GRAPH &lt;uri&gt; {...}.
    /// <see href="http://spinrdf.org/sp#NamedGraph"></see></summary>
    let NamedGraph = Namespaced_IRI.parse _namespace_name "NamedGraph" |> NamespacedName
    /// <summary>
    /// A NOT EXISTS element group.
    /// <see href="http://spinrdf.org/sp#NotExists"></see></summary>
    let NotExists = Namespaced_IRI.parse _namespace_name "NotExists" |> NamespacedName
    /// <summary>
    /// An optional element in a query.
    /// <see href="http://spinrdf.org/sp#Optional"></see></summary>
    let Optional = Namespaced_IRI.parse _namespace_name "Optional" |> NamespacedName

    /// <summary>
    ///   <see href="http://spinrdf.org/sp#ReverseLinkPath"></see>
    /// </summary>
    let ReverseLinkPath =
        Namespaced_IRI.parse _namespace_name "ReverseLinkPath" |> NamespacedName

    /// <summary>
    /// A path with reversed direction.
    /// <see href="http://spinrdf.org/sp#ReversePath"></see></summary>
    let ReversePath =
        Namespaced_IRI.parse _namespace_name "ReversePath" |> NamespacedName

    /// <summary>
    /// Represents SAMPLE aggregations
    /// <see href="http://spinrdf.org/sp#Sample"></see></summary>
    let Sample = Namespaced_IRI.parse _namespace_name "Sample" |> NamespacedName
    /// <summary>
    /// A SELECT-type query that returns variable bindings as its result.
    /// <see href="http://spinrdf.org/sp#Select"></see></summary>
    let Select = Namespaced_IRI.parse _namespace_name "Select" |> NamespacedName
    /// <summary>
    /// A sequence of multiple paths.
    /// <see href="http://spinrdf.org/sp#SeqPath"></see></summary>
    let SeqPath = Namespaced_IRI.parse _namespace_name "SeqPath" |> NamespacedName
    /// <summary>
    /// A SERVICE call that matches a nested sub-pattern against a SPARQL end point specified by a URI.
    /// <see href="http://spinrdf.org/sp#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// A nested SELECT query inside of an element list. The query is stored in sp:query.
    /// <see href="http://spinrdf.org/sp#SubQuery"></see></summary>
    let SubQuery = Namespaced_IRI.parse _namespace_name "SubQuery" |> NamespacedName
    /// <summary>
    /// Represents sum aggregations, e.g. SELECT SUM(?varName)...
    /// <see href="http://spinrdf.org/sp#Sum"></see></summary>
    let Sum = Namespaced_IRI.parse _namespace_name "Sum" |> NamespacedName
    /// <summary>
    /// A base class for TriplePattern and TripleTemplate. This basically specifies that subject, predicate and object must be present.
    /// <see href="http://spinrdf.org/sp#Triple"></see></summary>
    let Triple = Namespaced_IRI.parse _namespace_name "Triple" |> NamespacedName
    /// <summary>
    /// Abstract base class for things that have subject and object.
    /// <see href="http://spinrdf.org/sp#Tuple"></see></summary>
    let Tuple = Namespaced_IRI.parse _namespace_name "Tuple" |> NamespacedName
    /// <summary>
    /// Similar to a TriplePattern, but with a path expression as its predicate. For example, this can be used to express transitive sub-class relationships (?subClass rdfs:subClassOf* ?superClass).
    /// <see href="http://spinrdf.org/sp#TriplePath"></see></summary>
    let TriplePath = Namespaced_IRI.parse _namespace_name "TriplePath" |> NamespacedName

    /// <summary>
    /// A triple pattern used in the body of a query.
    /// <see href="http://spinrdf.org/sp#TriplePattern"></see></summary>
    let TriplePattern =
        Namespaced_IRI.parse _namespace_name "TriplePattern" |> NamespacedName

    /// <summary>
    /// A prototypical triple used as template in the head of a Construct query. May contain variables.
    /// <see href="http://spinrdf.org/sp#TripleTemplate"></see></summary>
    let TripleTemplate =
        Namespaced_IRI.parse _namespace_name "TripleTemplate" |> NamespacedName

    /// <summary>
    /// A UNION group.
    /// <see href="http://spinrdf.org/sp#Union"></see></summary>
    let Union = Namespaced_IRI.parse _namespace_name "Union" |> NamespacedName
    /// <summary>
    /// A VALUES element. sp:varNames points to an rdf:List of strings for the variables, sp:values to an rdf:List of rdf:Lists with nodes for each variable, in the order defined by the variables list.
    /// <see href="http://spinrdf.org/sp#Values"></see></summary>
    let Values = Namespaced_IRI.parse _namespace_name "Values" |> NamespacedName
    /// <summary>
    /// A variable mentioned in a Triple or expression. Variables are often blank nodes with the variable name stored in ts:name. Variables can also be supplied with a URI in which case the system will attempt to reuse the same variable instance across multiple query definitions.
    /// <see href="http://spinrdf.org/sp#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName
    /// <summary>
    /// Used in DROP and CLEAR.
    /// <see href="http://spinrdf.org/sp#all"></see></summary>
    let all = Namespaced_IRI.parse _namespace_name "all" |> NamespacedName

    /// <summary>
    /// An abstract base proprerty that groups together the SP system properties. Users typically don't need to see them anyway.
    /// <see href="http://spinrdf.org/sp#systemProperty"></see></summary>
    let systemProperty =
        Namespaced_IRI.parse _namespace_name "systemProperty" |> NamespacedName

    /// <summary>
    /// Abstract superproperty for the enumerated arg1, arg2 etc.
    /// <see href="http://spinrdf.org/sp#arg"></see></summary>
    let arg = Namespaced_IRI.parse _namespace_name "arg" |> NamespacedName
    /// <summary>
    /// The first argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg1"></see></summary>
    let arg1 = Namespaced_IRI.parse _namespace_name "arg1" |> NamespacedName
    /// <summary>
    /// The second argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg2"></see></summary>
    let arg2 = Namespaced_IRI.parse _namespace_name "arg2" |> NamespacedName
    /// <summary>
    /// The third argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg3"></see></summary>
    let arg3 = Namespaced_IRI.parse _namespace_name "arg3" |> NamespacedName
    /// <summary>
    /// The forth argument of a function call.
    /// <see href="http://spinrdf.org/sp#arg4"></see></summary>
    let arg4 = Namespaced_IRI.parse _namespace_name "arg4" |> NamespacedName
    /// <summary>
    /// The fifth argument of a function call. Further arguments are not common in SPARQL, therefore no sp:arg6, etc are defined here. However, they can be created if needed.
    /// <see href="http://spinrdf.org/sp#arg5"></see></summary>
    let arg5 = Namespaced_IRI.parse _namespace_name "arg5" |> NamespacedName
    /// <summary>
    /// Points to a Variable used in an AS statement such as COUNT aggregates.
    /// <see href="http://spinrdf.org/sp#as"></see></summary>
    let as_ = Namespaced_IRI.parse _namespace_name "as" |> NamespacedName
    /// <summary>
    /// The actual bindings of a sp:Values element.
    /// <see href="http://spinrdf.org/sp#bindings"></see></summary>
    let bindings = Namespaced_IRI.parse _namespace_name "bindings" |> NamespacedName
    /// <summary>
    /// Used in DROP and CLEAR.
    /// <see href="http://spinrdf.org/sp#default"></see></summary>
    let default_ = Namespaced_IRI.parse _namespace_name "default" |> NamespacedName

    /// <summary>
    /// Points to a list of sp:TripleTemplates and sp:NamedGraphs in a modify operation.
    /// <see href="http://spinrdf.org/sp#deletePattern"></see></summary>
    let deletePattern =
        Namespaced_IRI.parse _namespace_name "deletePattern" |> NamespacedName

    /// <summary>
    /// A marker property to indicate that a Select query is of type SELECT DISTINCT.
    /// <see href="http://spinrdf.org/sp#distinct"></see></summary>
    let distinct = Namespaced_IRI.parse _namespace_name "distinct" |> NamespacedName
    /// <summary>
    /// The URI of the document to load using a LOAD Update operation.
    /// <see href="http://spinrdf.org/sp#document"></see></summary>
    let document = Namespaced_IRI.parse _namespace_name "document" |> NamespacedName
    /// <summary>
    /// Points to an ElementList, for example in an Optional element.
    /// <see href="http://spinrdf.org/sp#elements"></see></summary>
    let elements = Namespaced_IRI.parse _namespace_name "elements" |> NamespacedName
    /// <summary>
    /// Points to an expression, for example in a Filter or Assignment.
    /// <see href="http://spinrdf.org/sp#expression"></see></summary>
    let expression = Namespaced_IRI.parse _namespace_name "expression" |> NamespacedName
    /// <summary>
    /// Specifies an RDF Dataset used by a Query (FROM syntax in SPARQL). Values of this property must be URI resources.
    /// <see href="http://spinrdf.org/sp#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    /// Specifies a named RDF Dataset used by a Query (FROM NAMED syntax in SPARQL). Values of this property must be URI resources.
    /// <see href="http://spinrdf.org/sp#fromNamed"></see></summary>
    let fromNamed = Namespaced_IRI.parse _namespace_name "fromNamed" |> NamespacedName
    /// <summary>
    /// Points to graph names (IRIs) in various sp:Update operations.
    /// <see href="http://spinrdf.org/sp#graphIRI"></see></summary>
    let graphIRI = Namespaced_IRI.parse _namespace_name "graphIRI" |> NamespacedName

    /// <summary>
    /// The name (URI or Variable) of a NamedGraph.
    /// <see href="http://spinrdf.org/sp#graphNameNode"></see></summary>
    let graphNameNode =
        Namespaced_IRI.parse _namespace_name "graphNameNode" |> NamespacedName

    /// <summary>
    /// Points from a Query to the list of GROUP BY expressions.
    /// <see href="http://spinrdf.org/sp#groupBy"></see></summary>
    let groupBy = Namespaced_IRI.parse _namespace_name "groupBy" |> NamespacedName
    /// <summary>
    /// Points from a SELECT query to a list of HAVING expressions.
    /// <see href="http://spinrdf.org/sp#having"></see></summary>
    let having = Namespaced_IRI.parse _namespace_name "having" |> NamespacedName

    /// <summary>
    /// Points to a list of sp:TripleTemplates or sp:NamedGraphs in a modify command.
    /// <see href="http://spinrdf.org/sp#insertPattern"></see></summary>
    let insertPattern =
        Namespaced_IRI.parse _namespace_name "insertPattern" |> NamespacedName

    /// <summary>
    /// The (optional) target of a LOAD Update operation.
    /// <see href="http://spinrdf.org/sp#into"></see></summary>
    let into = Namespaced_IRI.parse _namespace_name "into" |> NamespacedName
    /// <summary>
    /// The LIMIT solution modifier of a Query.
    /// <see href="http://spinrdf.org/sp#limit"></see></summary>
    let limit = Namespaced_IRI.parse _namespace_name "limit" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#modMax"></see>
    /// </summary>
    let modMax = Namespaced_IRI.parse _namespace_name "modMax" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#modMin"></see>
    /// </summary>
    let modMin = Namespaced_IRI.parse _namespace_name "modMin" |> NamespacedName
    /// <summary>
    /// Used in DROP and CLEAR.
    /// <see href="http://spinrdf.org/sp#named"></see></summary>
    let named = Namespaced_IRI.parse _namespace_name "named" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#node"></see>
    /// </summary>
    let node = Namespaced_IRI.parse _namespace_name "node" |> NamespacedName
    /// <summary>
    /// An RDF Node or Variable describing the object of a triple.
    /// <see href="http://spinrdf.org/sp#object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// The OFFSET solution modifier of a Query.
    /// <see href="http://spinrdf.org/sp#offset"></see></summary>
    let offset = Namespaced_IRI.parse _namespace_name "offset" |> NamespacedName
    /// <summary>
    /// Links a query with an ORDER BY clause where the values are rdf:List containing OrderByConditions or expressions. While the domain of this property is sp:Query, only Describe and Select queries can have values of it.
    /// <see href="http://spinrdf.org/sp#orderBy"></see></summary>
    let orderBy = Namespaced_IRI.parse _namespace_name "orderBy" |> NamespacedName
    /// <summary>
    /// Points from a TriplePath to its path.
    /// <see href="http://spinrdf.org/sp#path"></see></summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    /// The first child path of a property path. Used by sp:AltPath and sp:SeqPath.
    /// <see href="http://spinrdf.org/sp#path1"></see></summary>
    let path1 = Namespaced_IRI.parse _namespace_name "path1" |> NamespacedName
    /// <summary>
    /// The second child path of a property path. Used by sp:AltPath and sp:SeqPath.
    /// <see href="http://spinrdf.org/sp#path2"></see></summary>
    let path2 = Namespaced_IRI.parse _namespace_name "path2" |> NamespacedName
    /// <summary>
    /// A resource or Variable describing the predicate of a triple.
    /// <see href="http://spinrdf.org/sp#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// Links a SubQuery resource with the nested Query.
    /// <see href="http://spinrdf.org/sp#query"></see></summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName
    /// <summary>
    /// A property with true to indicate that a Select query has a REDUCED flag.
    /// <see href="http://spinrdf.org/sp#reduced"></see></summary>
    let reduced = Namespaced_IRI.parse _namespace_name "reduced" |> NamespacedName

    /// <summary>
    /// Contains the result nodes (URI resources or Variables) of a Describe query.
    /// <see href="http://spinrdf.org/sp#resultNodes"></see></summary>
    let resultNodes =
        Namespaced_IRI.parse _namespace_name "resultNodes" |> NamespacedName

    /// <summary>
    /// An rdf:List of variables that are returned by a Select query.
    /// <see href="http://spinrdf.org/sp#resultVariables"></see></summary>
    let resultVariables =
        Namespaced_IRI.parse _namespace_name "resultVariables" |> NamespacedName

    /// <summary>
    /// Stores the separator="..." value of a GROUP_CONCAT (sp:GroupConcat) aggregation.
    /// <see href="http://spinrdf.org/sp#separator"></see></summary>
    let separator = Namespaced_IRI.parse _namespace_name "separator" |> NamespacedName
    /// <summary>
    /// Used by sp:Service to specify the URI of the SPARQL end point to invoke. Must point to a URI node.
    /// <see href="http://spinrdf.org/sp#serviceURI"></see></summary>
    let serviceURI = Namespaced_IRI.parse _namespace_name "serviceURI" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#silent"></see>
    /// </summary>
    let silent = Namespaced_IRI.parse _namespace_name "silent" |> NamespacedName
    /// <summary>
    /// The child path of a property path expression. This is used by ReversePath and ModPath.
    /// <see href="http://spinrdf.org/sp#subPath"></see></summary>
    let subPath = Namespaced_IRI.parse _namespace_name "subPath" |> NamespacedName
    /// <summary>
    /// A resource or Variable describing the subject of a triple.
    /// <see href="http://spinrdf.org/sp#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// Points to a list of TripleTemplates that form the head of a Construct query.
    /// <see href="http://spinrdf.org/sp#templates"></see></summary>
    let templates = Namespaced_IRI.parse _namespace_name "templates" |> NamespacedName
    /// <summary>
    /// Can be attached to sp:Queries to store a textual representation of the query. This can be useful for tools that do not have a complete SPIN Syntax parser available.
    /// <see href="http://spinrdf.org/sp#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#using"></see>
    /// </summary>
    let using = Namespaced_IRI.parse _namespace_name "using" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#usingNamed"></see>
    /// </summary>
    let usingNamed = Namespaced_IRI.parse _namespace_name "usingNamed" |> NamespacedName
    /// <summary>
    /// The VALUES block at the end of a query. The object may just be an untyped blank node, i.e. the sp:Values type triple is optional.
    /// <see href="http://spinrdf.org/sp#values"></see></summary>
    let values = Namespaced_IRI.parse _namespace_name "values" |> NamespacedName
    /// <summary>
    /// The name of a Variable.
    /// <see href="http://spinrdf.org/sp#varName"></see></summary>
    let varName = Namespaced_IRI.parse _namespace_name "varName" |> NamespacedName
    /// <summary>
    /// The names of the variables (xsd:strings) of the variables declared for a VALUES element.
    /// <see href="http://spinrdf.org/sp#varNames"></see></summary>
    let varNames = Namespaced_IRI.parse _namespace_name "varNames" |> NamespacedName
    /// <summary>
    /// The variable of a Bind element.
    /// <see href="http://spinrdf.org/sp#variable"></see></summary>
    let variable = Namespaced_IRI.parse _namespace_name "variable" |> NamespacedName
    /// <summary>
    /// The WHERE clause of a Query.
    /// <see href="http://spinrdf.org/sp#where"></see></summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName
    /// <summary>
    ///   <see href="http://spinrdf.org/sp#with"></see>
    /// </summary>
    let with_ = Namespaced_IRI.parse _namespace_name "with" |> NamespacedName
