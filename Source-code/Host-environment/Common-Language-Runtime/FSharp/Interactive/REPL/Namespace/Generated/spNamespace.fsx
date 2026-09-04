#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://spinrdf.org/sp#" "sp"
    /// <summary>
    ///   <para>rdfs:comment : Base class of aggregation types (not part of the SPARQL 1.0 standard but supported by ARQ and other engines).^^xsd:string</para>
    ///   <para>rdfs:label : Aggregation^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Aggregation">sp:Aggregation</a>
    /// </summary>
    let Aggregation = _prefixId.prefix "Aggregation"
    /// <summary>
    ///   <para>rdfs:comment : An alternative path with the union of sp:path1 and sp:path2.^^xsd:string</para>
    ///   <para>rdfs:label : Alt path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#AltPath">sp:AltPath</a>
    /// </summary>
    let AltPath = _prefixId.prefix "AltPath"
    /// <summary>
    ///   <para>rdfs:comment : Marker to indicate ascending order.^^xsd:string</para>
    ///   <para>rdfs:label : Asc^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Asc">sp:Asc</a>
    /// </summary>
    let Asc = _prefixId.prefix "Asc"
    /// <summary>
    ///   <para>rdfs:comment : An ASK query that returns true if the condition in the body is met by at least one result set.^^xsd:string</para>
    ///   <para>rdfs:label : Ask^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Ask">sp:Ask</a>
    /// </summary>
    let Ask = _prefixId.prefix "Ask"
    /// <summary>
    ///   <para>rdfs:comment : Represents AVG aggregations.^^xsd:string</para>
    ///   <para>rdfs:label : AVG^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Avg">sp:Avg</a>
    /// </summary>
    let Avg = _prefixId.prefix "Avg"
    /// <summary>
    ///   <para>rdfs:comment : A BIND element.^^xsd:string</para>
    ///   <para>rdfs:label : Bind^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Bind">sp:Bind</a>
    /// </summary>
    let Bind = _prefixId.prefix "Bind"
    /// <summary>
    ///   <para>rdfs:comment : An Update operation that removes all triples from a specified graph. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent.^^xsd:string</para>
    ///   <para>rdfs:label : Clear^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Clear">sp:Clear</a>
    /// </summary>
    let Clear = _prefixId.prefix "Clear"
    /// <summary>
    ///   <para>rdfs:comment : A shared superclass for sp:Query and sp:Update that can be used to specify that the range of property can be either one.^^xsd:string</para>
    ///   <para>rdfs:label : Command^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Command">sp:Command</a>
    /// </summary>
    let Command = _prefixId.prefix "Command"
    /// <summary>
    ///   <para>rdfs:comment : A CONSTRUCT-type query that can be used to construct new triples from template triples (head) that use variable bindings from the match patterns (body).^^xsd:string</para>
    ///   <para>rdfs:label : Construct^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Construct">sp:Construct</a>
    /// </summary>
    let Construct = _prefixId.prefix "Construct"
    /// <summary>
    ///   <para>rdfs:comment : Counts the number of times a variable is used. The variable is stored in the variable property. This might be left blank to indicate COUNT(*).^^xsd:string</para>
    ///   <para>rdfs:label : COUNT^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Count">sp:Count</a>
    /// </summary>
    let Count = _prefixId.prefix "Count"
    /// <summary>
    ///   <para>rdfs:comment : An Update operation that creates a new empty graph with a name specified by sp:graphIRI. May have sp:silent set to true.^^xsd:string</para>
    ///   <para>rdfs:label : Create^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Create">sp:Create</a>
    /// </summary>
    let Create = _prefixId.prefix "Create"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated - use sp:Modify instead.
    ///
    /// Represents a DELETE FROM (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:deletePattern. The WHERE clause is represented using sp:where.^^xsd:string</para>
    ///   <para>rdfs:label : Delete^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Delete">sp:Delete</a>
    /// </summary>
    let Delete = _prefixId.prefix "Delete"
    /// <summary>
    ///   <para>rdfs:comment : An Update operation to delete specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs.^^xsd:string</para>
    ///   <para>rdfs:label : Delete data^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#DeleteData">sp:DeleteData</a>
    /// </summary>
    let DeleteData = _prefixId.prefix "DeleteData"
    /// <summary>
    ///   <para>rdfs:comment : An Update operation where the triples matched by the WHERE clause (sp:where) will be the triples deleted.^^xsd:string</para>
    ///   <para>rdfs:label : Delete where^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#DeleteWhere">sp:DeleteWhere</a>
    /// </summary>
    let DeleteWhere = _prefixId.prefix "DeleteWhere"
    /// <summary>
    ///   <para>rdfs:comment : Marker to indicate descending order.^^xsd:string</para>
    ///   <para>rdfs:label : Desc^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Desc">sp:Desc</a>
    /// </summary>
    let Desc = _prefixId.prefix "Desc"
    /// <summary>
    ///   <para>rdfs:comment : A DESCRIBE-type Query.^^xsd:string</para>
    ///   <para>rdfs:label : Describe^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Describe">sp:Describe</a>
    /// </summary>
    let Describe = _prefixId.prefix "Describe"
    /// <summary>
    ///   <para>rdfs:comment : An Update operation that removes a specified graph from the Graph Store. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent.^^xsd:string</para>
    ///   <para>rdfs:label : Drop^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Drop">sp:Drop</a>
    /// </summary>
    let Drop = _prefixId.prefix "Drop"
    /// <summary>
    ///   <para>rdfs:comment : An abstract base class for all pattern elements.^^xsd:string</para>
    ///   <para>rdfs:label : Element^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Element">sp:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>rdfs:comment : Abstract base class of group patterns.^^xsd:string</para>
    ///   <para>rdfs:label : Element group^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#ElementGroup">sp:ElementGroup</a>
    /// </summary>
    let ElementGroup = _prefixId.prefix "ElementGroup"
    /// <summary>
    ///   <para>rdfs:comment : A list of Elements. This class is never instantiated directly as SPIN will use plain rdf:Lists to store element lists.^^xsd:string</para>
    ///   <para>rdfs:label : Element list^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#ElementList">sp:ElementList</a>
    /// </summary>
    let ElementList = _prefixId.prefix "ElementList"
    /// <summary>
    ///   <para>rdfs:comment : An EXISTS element group.^^xsd:string</para>
    ///   <para>rdfs:label : Exists^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Exists">sp:Exists</a>
    /// </summary>
    let Exists = _prefixId.prefix "Exists"
    /// <summary>
    ///   <para>rdfs:comment : A constraint element that evaluates a given expression to true or false.^^xsd:string</para>
    ///   <para>rdfs:label : Filter^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Filter">sp:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>rdfs:comment : Represents GROUP_CONCAT aggregations.^^xsd:string</para>
    ///   <para>rdfs:label : GROUP_CONCAT^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#GroupConcat">sp:GroupConcat</a>
    /// </summary>
    let GroupConcat = _prefixId.prefix "GroupConcat"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated - use sp:Modify instead.
    ///
    /// Represents a INSERT INTO (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:insertPattern. The WHERE clause is represented using sp:where.^^xsd:string</para>
    ///   <para>rdfs:label : Insert^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Insert">sp:Insert</a>
    /// </summary>
    let Insert = _prefixId.prefix "Insert"
    /// <summary>
    ///   <para>rdfs:comment : An Update operation to insert specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs.^^xsd:string</para>
    ///   <para>rdfs:label : Insert data^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#InsertData">sp:InsertData</a>
    /// </summary>
    let InsertData = _prefixId.prefix "InsertData"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated: use sp:Bind instead.
    ///
    /// A variable assignment (LET (?&lt;varName&gt; := &lt;expression&gt;)). Not part of the SPARQL 1.0 standard, but (for example) ARQ.^^xsd:string</para>
    ///   <para>rdfs:label : Let^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Let">sp:Let</a>
    /// </summary>
    let Let = _prefixId.prefix "Let"
    /// <summary>
    ///   <para>rdfs:comment : A LOAD Update operation. The document to load is specified using sp:document, and the (optional) target graph using sp:into.^^xsd:string</para>
    ///   <para>rdfs:label : Load^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Load">sp:Load</a>
    /// </summary>
    let Load = _prefixId.prefix "Load"
    /// <summary>
    ///   <para>rdfs:comment : Represents MAX aggregations.^^xsd:string</para>
    ///   <para>rdfs:label : MAX^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Max">sp:Max</a>
    /// </summary>
    let Max = _prefixId.prefix "Max"
    /// <summary>
    ///   <para>rdfs:comment : Represents MIN aggregations.^^xsd:string</para>
    ///   <para>rdfs:label : MIN^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Min">sp:Min</a>
    /// </summary>
    let Min = _prefixId.prefix "Min"
    /// <summary>
    ///   <para>rdfs:comment : A MINUS element group.^^xsd:string</para>
    ///   <para>rdfs:label : Minus^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Minus">sp:Minus</a>
    /// </summary>
    let Minus = _prefixId.prefix "Minus"
    /// <summary>
    ///   <para>rdfs:comment : A modified path such as rdfs:subClassOf*.^^xsd:string</para>
    ///   <para>rdfs:label : Mod path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#ModPath">sp:ModPath</a>
    /// </summary>
    let ModPath = _prefixId.prefix "ModPath"
    /// <summary>
    ///   <para>rdfs:comment : Represents a MODIFY (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns are stored in sp:deletePattern and sp:insertPattern. The WHERE clause is represented using sp:where.^^xsd:string</para>
    ///   <para>rdfs:label : Modify^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Modify">sp:Modify</a>
    /// </summary>
    let Modify = _prefixId.prefix "Modify"
    /// <summary>
    ///   <para>rdfs:comment : A named Graph element such as GRAPH &lt;uri&gt; {...}.^^xsd:string</para>
    ///   <para>rdfs:label : Named graph^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#NamedGraph">sp:NamedGraph</a>
    /// </summary>
    let NamedGraph = _prefixId.prefix "NamedGraph"
    /// <summary>
    ///   <para>rdfs:comment : A NOT EXISTS element group.^^xsd:string</para>
    ///   <para>rdfs:label : Not exists^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#NotExists">sp:NotExists</a>
    /// </summary>
    let NotExists = _prefixId.prefix "NotExists"
    /// <summary>
    ///   <para>rdfs:comment : An optional element in a query.^^xsd:string</para>
    ///   <para>rdfs:label : Optional^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Optional">sp:Optional</a>
    /// </summary>
    let Optional = _prefixId.prefix "Optional"
    /// <summary>
    ///   <para>rdfs:comment : An abstract base class for ascending or descending order conditions. Instances of this class (typically bnodes) must have a value for expression to point to the actual values.^^xsd:string</para>
    ///   <para>rdfs:label : Order by condition^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#OrderByCondition">sp:OrderByCondition</a>
    /// </summary>
    let OrderByCondition = _prefixId.prefix "OrderByCondition"
    /// <summary>
    ///   <para>rdfs:comment : The base class of SPARQL property path expressions. Paths are used by sp:TriplePath triple paths.^^xsd:string</para>
    ///   <para>rdfs:label : Path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Path">sp:Path</a>
    /// </summary>
    let Path = _prefixId.prefix "Path"
    /// <summary>
    ///   <para>rdfs:comment : Abstract base class of the various types of supported queries. Common to all types of queries is that they can have a body ("WHERE clause").^^xsd:string</para>
    ///   <para>rdfs:label : Query^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Query">sp:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : Reverse link path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#ReverseLinkPath">sp:ReverseLinkPath</a>
    /// </summary>
    let ReverseLinkPath = _prefixId.prefix "ReverseLinkPath"
    /// <summary>
    ///   <para>rdfs:comment : A path with reversed direction.^^xsd:string</para>
    ///   <para>rdfs:label : Reverse path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#ReversePath">sp:ReversePath</a>
    /// </summary>
    let ReversePath = _prefixId.prefix "ReversePath"
    /// <summary>
    ///   <para>rdfs:comment : Represents SAMPLE aggregations^^xsd:string</para>
    ///   <para>rdfs:label : SAMPLE^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Sample">sp:Sample</a>
    /// </summary>
    let Sample = _prefixId.prefix "Sample"
    /// <summary>
    ///   <para>rdfs:comment : A SELECT-type query that returns variable bindings as its result.^^xsd:string</para>
    ///   <para>rdfs:label : Select query^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Select">sp:Select</a>
    /// </summary>
    let Select = _prefixId.prefix "Select"
    /// <summary>
    ///   <para>rdfs:comment : A sequence of multiple paths.^^xsd:string</para>
    ///   <para>rdfs:label : Seq path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#SeqPath">sp:SeqPath</a>
    /// </summary>
    let SeqPath = _prefixId.prefix "SeqPath"
    /// <summary>
    ///   <para>rdfs:comment : A SERVICE call that matches a nested sub-pattern against a SPARQL end point specified by a URI.^^xsd:string</para>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Service">sp:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : A nested SELECT query inside of an element list. The query is stored in sp:query.^^xsd:string</para>
    ///   <para>rdfs:label : Sub query^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#SubQuery">sp:SubQuery</a>
    /// </summary>
    let SubQuery = _prefixId.prefix "SubQuery"
    /// <summary>
    ///   <para>rdfs:comment : Represents sum aggregations, e.g. SELECT SUM(?varName)...^^xsd:string</para>
    ///   <para>rdfs:label : SUM^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Sum">sp:Sum</a>
    /// </summary>
    let Sum = _prefixId.prefix "Sum"
    /// <summary>
    ///   <para>rdfs:comment : An "artificial" root class that groups all SP classes. This makes them look much less overwhelming in UI tools. Typical end users don't need to see those classes anyway.^^xsd:string</para>
    ///   <para>rdfs:label : SP System class^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#SystemClass">sp:SystemClass</a>
    /// </summary>
    let SystemClass = _prefixId.prefix "SystemClass"
    /// <summary>
    ///   <para>rdfs:comment : A base class for TriplePattern and TripleTemplate. This basically specifies that subject, predicate and object must be present.^^xsd:string</para>
    ///   <para>rdfs:label : Triple^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Triple">sp:Triple</a>
    /// </summary>
    let Triple = _prefixId.prefix "Triple"
    /// <summary>
    ///   <para>rdfs:comment : Similar to a TriplePattern, but with a path expression as its predicate. For example, this can be used to express transitive sub-class relationships (?subClass rdfs:subClassOf* ?superClass).^^xsd:string</para>
    ///   <para>rdfs:label : Triple path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#TriplePath">sp:TriplePath</a>
    /// </summary>
    let TriplePath = _prefixId.prefix "TriplePath"
    /// <summary>
    ///   <para>rdfs:comment : A triple pattern used in the body of a query.^^xsd:string</para>
    ///   <para>rdfs:label : Triple pattern^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#TriplePattern">sp:TriplePattern</a>
    /// </summary>
    let TriplePattern = _prefixId.prefix "TriplePattern"
    /// <summary>
    ///   <para>rdfs:comment : A prototypical triple used as template in the head of a Construct query. May contain variables.^^xsd:string</para>
    ///   <para>rdfs:label : Triple template^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#TripleTemplate">sp:TripleTemplate</a>
    /// </summary>
    let TripleTemplate = _prefixId.prefix "TripleTemplate"
    /// <summary>
    ///   <para>rdfs:comment : Abstract base class for things that have subject and object.^^xsd:string</para>
    ///   <para>rdfs:label : Tuple^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Tuple">sp:Tuple</a>
    /// </summary>
    let Tuple = _prefixId.prefix "Tuple"
    /// <summary>
    ///   <para>rdfs:comment : A UNION group.^^xsd:string</para>
    ///   <para>rdfs:label : Union^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Union">sp:Union</a>
    /// </summary>
    let Union = _prefixId.prefix "Union"
    /// <summary>
    ///   <para>rdfs:comment : Abstract base class to group the various SPARQL UPDATE commands.^^xsd:string</para>
    ///   <para>rdfs:label : Update^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Update">sp:Update</a>
    /// </summary>
    let Update = _prefixId.prefix "Update"
    /// <summary>
    ///   <para>rdfs:comment : A VALUES element. sp:varNames points to an rdf:List of strings for the variables, sp:values to an rdf:List of rdf:Lists with nodes for each variable, in the order defined by the variables list.^^xsd:string</para>
    ///   <para>rdfs:label : Values^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Values">sp:Values</a>
    /// </summary>
    let Values = _prefixId.prefix "Values"
    /// <summary>
    ///   <para>rdfs:comment : A variable mentioned in a Triple or expression. Variables are often blank nodes with the variable name stored in ts:name. Variables can also be supplied with a URI in which case the system will attempt to reuse the same variable instance across multiple query definitions.^^xsd:string</para>
    ///   <para>rdfs:label : Variable^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#Variable">sp:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:comment : Used in DROP and CLEAR.^^xsd:string</para>
    ///   <para>rdfs:label : all^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#all">sp:all</a>
    /// </summary>
    let all = _prefixId.prefix "all"
    /// <summary>
    ///   <para>rdfs:comment : Abstract superproperty for the enumerated arg1, arg2 etc.^^xsd:string</para>
    ///   <para>rdfs:label : arg^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#arg">sp:arg</a>
    /// </summary>
    let arg = _prefixId.prefix "arg"
    /// <summary>
    ///   <para>rdfs:comment : The first argument of a function call.^^xsd:string</para>
    ///   <para>rdfs:label : arg1^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#arg1">sp:arg1</a>
    /// </summary>
    let arg1 = _prefixId.prefix "arg1"
    /// <summary>
    ///   <para>rdfs:comment : The second argument of a function call.^^xsd:string</para>
    ///   <para>rdfs:label : arg2^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#arg2">sp:arg2</a>
    /// </summary>
    let arg2 = _prefixId.prefix "arg2"
    /// <summary>
    ///   <para>rdfs:comment : The third argument of a function call.^^xsd:string</para>
    ///   <para>rdfs:label : arg3^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#arg3">sp:arg3</a>
    /// </summary>
    let arg3 = _prefixId.prefix "arg3"
    /// <summary>
    ///   <para>rdfs:comment : The forth argument of a function call.^^xsd:string</para>
    ///   <para>rdfs:label : arg4^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#arg4">sp:arg4</a>
    /// </summary>
    let arg4 = _prefixId.prefix "arg4"
    /// <summary>
    ///   <para>rdfs:comment : The fifth argument of a function call. Further arguments are not common in SPARQL, therefore no sp:arg6, etc are defined here. However, they can be created if needed.^^xsd:string</para>
    ///   <para>rdfs:label : arg5^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#arg5">sp:arg5</a>
    /// </summary>
    let arg5 = _prefixId.prefix "arg5"
    /// <summary>
    ///   <para>rdfs:comment : Points to a Variable used in an AS statement such as COUNT aggregates.^^xsd:string</para>
    ///   <para>rdfs:label : as^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#as">sp:as</a>
    /// </summary>
    let as_ = _prefixId.prefix "as"
    /// <summary>
    ///   <para>rdfs:comment : The actual bindings of a sp:Values element.^^xsd:string</para>
    ///   <para>rdfs:label : bindings^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#bindings">sp:bindings</a>
    /// </summary>
    let bindings = _prefixId.prefix "bindings"
    /// <summary>
    ///   <para>rdfs:comment : Used in DROP and CLEAR.^^xsd:string</para>
    ///   <para>rdfs:label : default^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#default">sp:default</a>
    /// </summary>
    let default_ = _prefixId.prefix "default"
    /// <summary>
    ///   <para>rdfs:comment : Points to a list of sp:TripleTemplates and sp:NamedGraphs in a modify operation.^^xsd:string</para>
    ///   <para>rdfs:label : delete pattern^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#deletePattern">sp:deletePattern</a>
    /// </summary>
    let deletePattern = _prefixId.prefix "deletePattern"
    /// <summary>
    ///   <para>rdfs:comment : A marker property to indicate that a Select query is of type SELECT DISTINCT.^^xsd:string</para>
    ///   <para>rdfs:label : distinct^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#distinct">sp:distinct</a>
    /// </summary>
    let distinct = _prefixId.prefix "distinct"
    /// <summary>
    ///   <para>rdfs:comment : The URI of the document to load using a LOAD Update operation.^^xsd:string</para>
    ///   <para>rdfs:label : document^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#document">sp:document</a>
    /// </summary>
    let document = _prefixId.prefix "document"
    /// <summary>
    ///   <para>rdfs:comment : Points to an ElementList, for example in an Optional element.^^xsd:string</para>
    ///   <para>rdfs:label : elements^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#elements">sp:elements</a>
    /// </summary>
    let elements = _prefixId.prefix "elements"
    /// <summary>
    ///   <para>rdfs:comment : Points to an expression, for example in a Filter or Assignment.^^xsd:string</para>
    ///   <para>rdfs:label : expression^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#expression">sp:expression</a>
    /// </summary>
    let expression = _prefixId.prefix "expression"
    /// <summary>
    ///   <para>rdfs:comment : Specifies an RDF Dataset used by a Query (FROM syntax in SPARQL). Values of this property must be URI resources.^^xsd:string</para>
    ///   <para>rdfs:label : from^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#from">sp:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a named RDF Dataset used by a Query (FROM NAMED syntax in SPARQL). Values of this property must be URI resources.^^xsd:string</para>
    ///   <para>rdfs:label : from named^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#fromNamed">sp:fromNamed</a>
    /// </summary>
    let fromNamed = _prefixId.prefix "fromNamed"
    /// <summary>
    ///   <para>rdfs:comment : Points to graph names (IRIs) in various sp:Update operations.^^xsd:string</para>
    ///   <para>rdfs:label : graph IRI^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#graphIRI">sp:graphIRI</a>
    /// </summary>
    let graphIRI = _prefixId.prefix "graphIRI"
    /// <summary>
    ///   <para>rdfs:comment : The name (URI or Variable) of a NamedGraph.^^xsd:string</para>
    ///   <para>rdfs:label : graph name node^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#graphNameNode">sp:graphNameNode</a>
    /// </summary>
    let graphNameNode = _prefixId.prefix "graphNameNode"
    /// <summary>
    ///   <para>rdfs:comment : Points from a Query to the list of GROUP BY expressions.^^xsd:string</para>
    ///   <para>rdfs:label : group by^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#groupBy">sp:groupBy</a>
    /// </summary>
    let groupBy = _prefixId.prefix "groupBy"
    /// <summary>
    ///   <para>rdfs:comment : Points from a SELECT query to a list of HAVING expressions.^^xsd:string</para>
    ///   <para>rdfs:label : having^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#having">sp:having</a>
    /// </summary>
    let having = _prefixId.prefix "having"
    /// <summary>
    ///   <para>rdfs:comment : Points to a list of sp:TripleTemplates or sp:NamedGraphs in a modify command.^^xsd:string</para>
    ///   <para>rdfs:label : insert pattern^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#insertPattern">sp:insertPattern</a>
    /// </summary>
    let insertPattern = _prefixId.prefix "insertPattern"
    /// <summary>
    ///   <para>rdfs:comment : The (optional) target of a LOAD Update operation.^^xsd:string</para>
    ///   <para>rdfs:label : into^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#into">sp:into</a>
    /// </summary>
    let into = _prefixId.prefix "into"
    /// <summary>
    ///   <para>rdfs:comment : The LIMIT solution modifier of a Query.^^xsd:string</para>
    ///   <para>rdfs:label : limit^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#limit">sp:limit</a>
    /// </summary>
    let limit = _prefixId.prefix "limit"
    /// <summary>
    ///   <para>rdfs:label : mod max^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#modMax">sp:modMax</a>
    /// </summary>
    let modMax = _prefixId.prefix "modMax"
    /// <summary>
    ///   <para>rdfs:label : mod min^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#modMin">sp:modMin</a>
    /// </summary>
    let modMin = _prefixId.prefix "modMin"
    /// <summary>
    ///   <para>rdfs:comment : Used in DROP and CLEAR.^^xsd:string</para>
    ///   <para>rdfs:label : named^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#named">sp:named</a>
    /// </summary>
    let named = _prefixId.prefix "named"
    /// <summary>
    ///   <para>rdfs:label : node^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#node">sp:node</a>
    /// </summary>
    let node = _prefixId.prefix "node"
    /// <summary>
    ///   <para>rdfs:comment : An RDF Node or Variable describing the object of a triple.^^xsd:string</para>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#object">sp:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : The OFFSET solution modifier of a Query.^^xsd:string</para>
    ///   <para>rdfs:label : offset^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#offset">sp:offset</a>
    /// </summary>
    let offset = _prefixId.prefix "offset"
    /// <summary>
    ///   <para>rdfs:comment : Links a query with an ORDER BY clause where the values are rdf:List containing OrderByConditions or expressions. While the domain of this property is sp:Query, only Describe and Select queries can have values of it.^^xsd:string</para>
    ///   <para>rdfs:label : order by^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#orderBy">sp:orderBy</a>
    /// </summary>
    let orderBy = _prefixId.prefix "orderBy"
    /// <summary>
    ///   <para>rdfs:comment : Points from a TriplePath to its path.^^xsd:string</para>
    ///   <para>rdfs:label : path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#path">sp:path</a>
    /// </summary>
    let path = _prefixId.prefix "path"
    /// <summary>
    ///   <para>rdfs:comment : The first child path of a property path. Used by sp:AltPath and sp:SeqPath.^^xsd:string</para>
    ///   <para>rdfs:label : path1^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#path1">sp:path1</a>
    /// </summary>
    let path1 = _prefixId.prefix "path1"
    /// <summary>
    ///   <para>rdfs:comment : The second child path of a property path. Used by sp:AltPath and sp:SeqPath.^^xsd:string</para>
    ///   <para>rdfs:label : path2^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#path2">sp:path2</a>
    /// </summary>
    let path2 = _prefixId.prefix "path2"
    /// <summary>
    ///   <para>rdfs:comment : A resource or Variable describing the predicate of a triple.^^xsd:string</para>
    ///   <para>rdfs:label : predicate^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#predicate">sp:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:comment : Links a SubQuery resource with the nested Query.^^xsd:string</para>
    ///   <para>rdfs:label : query^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#query">sp:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:comment : A property with true to indicate that a Select query has a REDUCED flag.^^xsd:string</para>
    ///   <para>rdfs:label : reduced^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#reduced">sp:reduced</a>
    /// </summary>
    let reduced = _prefixId.prefix "reduced"
    /// <summary>
    ///   <para>rdfs:comment : Contains the result nodes (URI resources or Variables) of a Describe query.^^xsd:string</para>
    ///   <para>rdfs:label : result nodes^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#resultNodes">sp:resultNodes</a>
    /// </summary>
    let resultNodes = _prefixId.prefix "resultNodes"
    /// <summary>
    ///   <para>rdfs:comment : An rdf:List of variables that are returned by a Select query.^^xsd:string</para>
    ///   <para>rdfs:label : result variables^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#resultVariables">sp:resultVariables</a>
    /// </summary>
    let resultVariables = _prefixId.prefix "resultVariables"
    /// <summary>
    ///   <para>rdfs:comment : Stores the separator="..." value of a GROUP_CONCAT (sp:GroupConcat) aggregation.^^xsd:string</para>
    ///   <para>rdfs:label : separator^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#separator">sp:separator</a>
    /// </summary>
    let separator = _prefixId.prefix "separator"
    /// <summary>
    ///   <para>rdfs:comment : Used by sp:Service to specify the URI of the SPARQL end point to invoke. Must point to a URI node.^^xsd:string</para>
    ///   <para>rdfs:label : service URI^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#serviceURI">sp:serviceURI</a>
    /// </summary>
    let serviceURI = _prefixId.prefix "serviceURI"
    /// <summary>
    ///   <para>rdfs:label : silent^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#silent">sp:silent</a>
    /// </summary>
    let silent = _prefixId.prefix "silent"
    /// <summary>
    ///   <para>rdfs:comment : The child path of a property path expression. This is used by ReversePath and ModPath.^^xsd:string</para>
    ///   <para>rdfs:label : sub path^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#subPath">sp:subPath</a>
    /// </summary>
    let subPath = _prefixId.prefix "subPath"
    /// <summary>
    ///   <para>rdfs:comment : A resource or Variable describing the subject of a triple.^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#subject">sp:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : An abstract base proprerty that groups together the SP system properties. Users typically don't need to see them anyway.^^xsd:string</para>
    ///   <para>rdfs:label : SP system property^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#systemProperty">sp:systemProperty</a>
    /// </summary>
    let systemProperty = _prefixId.prefix "systemProperty"
    /// <summary>
    ///   <para>rdfs:comment : Points to a list of TripleTemplates that form the head of a Construct query.^^xsd:string</para>
    ///   <para>rdfs:label : templates^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#templates">sp:templates</a>
    /// </summary>
    let templates = _prefixId.prefix "templates"
    /// <summary>
    ///   <para>rdfs:comment : Can be attached to sp:Queries to store a textual representation of the query. This can be useful for tools that do not have a complete SPIN Syntax parser available.^^xsd:string</para>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#text">sp:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:label : using^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#using">sp:using</a>
    /// </summary>
    let using = _prefixId.prefix "using"
    /// <summary>
    ///   <para>rdfs:label : using named^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#usingNamed">sp:usingNamed</a>
    /// </summary>
    let usingNamed = _prefixId.prefix "usingNamed"
    /// <summary>
    ///   <para>rdfs:comment : The VALUES block at the end of a query. The object may just be an untyped blank node, i.e. the sp:Values type triple is optional.^^xsd:string</para>
    ///   <para>rdfs:label : values^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#values">sp:values</a>
    /// </summary>
    let values = _prefixId.prefix "values"
    /// <summary>
    ///   <para>rdfs:comment : The name of a Variable.^^xsd:string</para>
    ///   <para>rdfs:label : varName^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#varName">sp:varName</a>
    /// </summary>
    let varName = _prefixId.prefix "varName"
    /// <summary>
    ///   <para>rdfs:comment : The names of the variables (xsd:strings) of the variables declared for a VALUES element.^^xsd:string</para>
    ///   <para>rdfs:label : var names^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#varNames">sp:varNames</a>
    /// </summary>
    let varNames = _prefixId.prefix "varNames"
    /// <summary>
    ///   <para>rdfs:comment : The variable of a Bind element.^^xsd:string</para>
    ///   <para>rdfs:label : variable^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#variable">sp:variable</a>
    /// </summary>
    let variable = _prefixId.prefix "variable"
    /// <summary>
    ///   <para>rdfs:comment : The WHERE clause of a Query.^^xsd:string</para>
    ///   <para>rdfs:label : where^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#where">sp:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
    /// <summary>
    ///   <para>rdfs:label : with^^xsd:string</para>
    ///   <a href="http://spinrdf.org/sp#with">sp:with</a>
    /// </summary>
    let with_ = _prefixId.prefix "with"
