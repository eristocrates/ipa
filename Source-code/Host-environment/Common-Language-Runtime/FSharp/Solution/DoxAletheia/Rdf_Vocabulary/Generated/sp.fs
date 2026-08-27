namespace http.spinrdf.org.sp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sp =
    let _namespace_iri = Namespace_Iri sp |> NamespaceIRI
    /// <summary>
    ///   <para>sp:Aggregation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Base class of aggregation types (not part of the SPARQL 1.0 standard but supported by ARQ and other engines)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aggregation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Aggregation">http://spinrdf.org/sp#Aggregation</seealso>
    let Aggregation = Prefixed_Name(sp, "Aggregation") |> PrefixedName
    /// <summary>
    ///   <para>sp:AltPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An alternative path with the union of sp:path1 and sp:path2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alt path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#AltPath">http://spinrdf.org/sp#AltPath</seealso>
    let AltPath = Prefixed_Name(sp, "AltPath") |> PrefixedName
    /// <summary>
    ///   <para>sp:Asc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Marker to indicate ascending order."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Asc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Asc">http://spinrdf.org/sp#Asc</seealso>
    let Asc = Prefixed_Name(sp, "Asc") |> PrefixedName
    /// <summary>
    ///   <para>sp:Ask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An ASK query that returns true if the condition in the body is met by at least one result set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Ask">http://spinrdf.org/sp#Ask</seealso>
    let Ask = Prefixed_Name(sp, "Ask") |> PrefixedName
    /// <summary>
    ///   <para>sp:Avg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents AVG aggregations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AVG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Avg">http://spinrdf.org/sp#Avg</seealso>
    let Avg = Prefixed_Name(sp, "Avg") |> PrefixedName
    /// <summary>
    ///   <para>sp:Bind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A BIND element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Bind">http://spinrdf.org/sp#Bind</seealso>
    let Bind = Prefixed_Name(sp, "Bind") |> PrefixedName
    /// <summary>
    ///   <para>sp:Clear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Update operation that removes all triples from a specified graph. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Clear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Clear">http://spinrdf.org/sp#Clear</seealso>
    let Clear = Prefixed_Name(sp, "Clear") |> PrefixedName
    /// <summary>
    ///   <para>sp:Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A shared superclass for sp:Query and sp:Update that can be used to specify that the range of property can be either one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Command">http://spinrdf.org/sp#Command</seealso>
    let Command = Prefixed_Name(sp, "Command") |> PrefixedName
    /// <summary>
    ///   <para>sp:Construct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A CONSTRUCT-type query that can be used to construct new triples from template triples (head) that use variable bindings from the match patterns (body)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Construct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Construct">http://spinrdf.org/sp#Construct</seealso>
    let Construct = Prefixed_Name(sp, "Construct") |> PrefixedName
    /// <summary>
    ///   <para>sp:Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Counts the number of times a variable is used. The variable is stored in the variable property. This might be left blank to indicate COUNT(*)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"COUNT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Count">http://spinrdf.org/sp#Count</seealso>
    let Count = Prefixed_Name(sp, "Count") |> PrefixedName
    /// <summary>
    ///   <para>sp:Create</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Update operation that creates a new empty graph with a name specified by sp:graphIRI. May have sp:silent set to true."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Create"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Create">http://spinrdf.org/sp#Create</seealso>
    let Create = Prefixed_Name(sp, "Create") |> PrefixedName
    /// <summary>
    ///   <para>sp:Delete</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"Deprecated - use sp:Modify instead.
    ///
    /// Represents a DELETE FROM (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:deletePattern. The WHERE clause is represented using sp:where."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Delete">http://spinrdf.org/sp#Delete</seealso>
    let Delete = Prefixed_Name(sp, "Delete") |> PrefixedName
    /// <summary>
    ///   <para>sp:DeleteData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Update operation to delete specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delete data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#DeleteData">http://spinrdf.org/sp#DeleteData</seealso>
    let DeleteData = Prefixed_Name(sp, "DeleteData") |> PrefixedName
    /// <summary>
    ///   <para>sp:DeleteWhere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Update operation where the triples matched by the WHERE clause (sp:where) will be the triples deleted."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delete where"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#DeleteWhere">http://spinrdf.org/sp#DeleteWhere</seealso>
    let DeleteWhere = Prefixed_Name(sp, "DeleteWhere") |> PrefixedName
    /// <summary>
    ///   <para>sp:Desc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Marker to indicate descending order."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Desc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Desc">http://spinrdf.org/sp#Desc</seealso>
    let Desc = Prefixed_Name(sp, "Desc") |> PrefixedName
    /// <summary>
    ///   <para>sp:Describe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A DESCRIBE-type Query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Describe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Describe">http://spinrdf.org/sp#Describe</seealso>
    let Describe = Prefixed_Name(sp, "Describe") |> PrefixedName
    /// <summary>
    ///   <para>sp:Drop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Update operation that removes a specified graph from the Graph Store. Must specify the graph using sp:graphIRI, or sp:default, sp:named or sp:all. May have the SILENT flag, encoded using sp:silent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Drop">http://spinrdf.org/sp#Drop</seealso>
    let Drop = Prefixed_Name(sp, "Drop") |> PrefixedName
    /// <summary>
    ///   <para>sp:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract base class for all pattern elements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Element">http://spinrdf.org/sp#Element</seealso>
    let Element = Prefixed_Name(sp, "Element") |> PrefixedName
    /// <summary>
    ///   <para>sp:ElementGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Abstract base class of group patterns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Element group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#ElementGroup">http://spinrdf.org/sp#ElementGroup</seealso>
    let ElementGroup = Prefixed_Name(sp, "ElementGroup") |> PrefixedName
    /// <summary>
    ///   <para>sp:ElementList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A list of Elements. This class is never instantiated directly as SPIN will use plain rdf:Lists to store element lists."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Element list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#ElementList">http://spinrdf.org/sp#ElementList</seealso>
    let ElementList = Prefixed_Name(sp, "ElementList") |> PrefixedName
    /// <summary>
    ///   <para>sp:Exists</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An EXISTS element group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exists"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Exists">http://spinrdf.org/sp#Exists</seealso>
    let Exists = Prefixed_Name(sp, "Exists") |> PrefixedName
    /// <summary>
    ///   <para>sp:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A constraint element that evaluates a given expression to true or false."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Filter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Filter">http://spinrdf.org/sp#Filter</seealso>
    let Filter = Prefixed_Name(sp, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>sp:GroupConcat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents GROUP_CONCAT aggregations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GROUP_CONCAT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#GroupConcat">http://spinrdf.org/sp#GroupConcat</seealso>
    let GroupConcat = Prefixed_Name(sp, "GroupConcat") |> PrefixedName
    /// <summary>
    ///   <para>sp:Insert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Deprecated - use sp:Modify instead.
    ///
    /// Represents a INSERT INTO (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns to delete are stored in sp:insertPattern. The WHERE clause is represented using sp:where."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Insert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Insert">http://spinrdf.org/sp#Insert</seealso>
    let Insert = Prefixed_Name(sp, "Insert") |> PrefixedName
    /// <summary>
    ///   <para>sp:InsertData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Update operation to insert specific triples. The graph triples are represented using sp:data, which points to an rdf:List of sp:Triples or sp:NamedGraphs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Insert data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#InsertData">http://spinrdf.org/sp#InsertData</seealso>
    let InsertData = Prefixed_Name(sp, "InsertData") |> PrefixedName
    /// <summary>
    ///   <para>sp:Let</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"Deprecated: use sp:Bind instead.
    ///
    /// A variable assignment (LET (?&lt;varName&gt; := &lt;expression&gt;)). Not part of the SPARQL 1.0 standard, but (for example) ARQ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Let"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Let">http://spinrdf.org/sp#Let</seealso>
    let Let = Prefixed_Name(sp, "Let") |> PrefixedName
    /// <summary>
    ///   <para>sp:Load</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A LOAD Update operation. The document to load is specified using sp:document, and the (optional) target graph using sp:into."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Load"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Load">http://spinrdf.org/sp#Load</seealso>
    let Load = Prefixed_Name(sp, "Load") |> PrefixedName
    /// <summary>
    ///   <para>sp:Max</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents MAX aggregations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MAX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Max">http://spinrdf.org/sp#Max</seealso>
    let Max = Prefixed_Name(sp, "Max") |> PrefixedName
    /// <summary>
    ///   <para>sp:Min</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents MIN aggregations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MIN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Min">http://spinrdf.org/sp#Min</seealso>
    let Min = Prefixed_Name(sp, "Min") |> PrefixedName
    /// <summary>
    ///   <para>sp:Minus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A MINUS element group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Minus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Minus">http://spinrdf.org/sp#Minus</seealso>
    let Minus = Prefixed_Name(sp, "Minus") |> PrefixedName
    /// <summary>
    ///   <para>sp:ModPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A modified path such as rdfs:subClassOf*."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mod path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#ModPath">http://spinrdf.org/sp#ModPath</seealso>
    let ModPath = Prefixed_Name(sp, "ModPath") |> PrefixedName
    /// <summary>
    ///   <para>sp:Modify</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a MODIFY (part of SPARQL UPDATE language). The graph IRIs are stored in sp:graphIRI. The template patterns are stored in sp:deletePattern and sp:insertPattern. The WHERE clause is represented using sp:where."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modify"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Modify">http://spinrdf.org/sp#Modify</seealso>
    let Modify = Prefixed_Name(sp, "Modify") |> PrefixedName
    /// <summary>
    ///   <para>sp:NamedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A named Graph element such as GRAPH &lt;uri&gt; {...}."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Named graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#NamedGraph">http://spinrdf.org/sp#NamedGraph</seealso>
    let NamedGraph = Prefixed_Name(sp, "NamedGraph") |> PrefixedName
    /// <summary>
    ///   <para>sp:NotExists</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A NOT EXISTS element group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Not exists"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#NotExists">http://spinrdf.org/sp#NotExists</seealso>
    let NotExists = Prefixed_Name(sp, "NotExists") |> PrefixedName
    /// <summary>
    ///   <para>sp:Optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An optional element in a query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Optional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Optional">http://spinrdf.org/sp#Optional</seealso>
    let Optional = Prefixed_Name(sp, "Optional") |> PrefixedName
    /// <summary>
    ///   <para>sp:OrderByCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract base class for ascending or descending order conditions. Instances of this class (typically bnodes) must have a value for expression to point to the actual values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Order by condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#OrderByCondition">http://spinrdf.org/sp#OrderByCondition</seealso>
    let OrderByCondition = Prefixed_Name(sp, "OrderByCondition") |> PrefixedName
    /// <summary>
    ///   <para>sp:Path</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The base class of SPARQL property path expressions. Paths are used by sp:TriplePath triple paths."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Path">http://spinrdf.org/sp#Path</seealso>
    let Path = Prefixed_Name(sp, "Path") |> PrefixedName
    /// <summary>
    ///   <para>sp:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Abstract base class of the various types of supported queries. Common to all types of queries is that they can have a body ("WHERE clause")."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Query">http://spinrdf.org/sp#Query</seealso>
    let Query = Prefixed_Name(sp, "Query") |> PrefixedName
    /// <summary>
    ///   <para>sp:ReverseLinkPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Reverse link path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#ReverseLinkPath">http://spinrdf.org/sp#ReverseLinkPath</seealso>
    let ReverseLinkPath = Prefixed_Name(sp, "ReverseLinkPath") |> PrefixedName
    /// <summary>
    ///   <para>sp:ReversePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A path with reversed direction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reverse path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#ReversePath">http://spinrdf.org/sp#ReversePath</seealso>
    let ReversePath = Prefixed_Name(sp, "ReversePath") |> PrefixedName
    /// <summary>
    ///   <para>sp:Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents SAMPLE aggregations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SAMPLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Sample">http://spinrdf.org/sp#Sample</seealso>
    let Sample = Prefixed_Name(sp, "Sample") |> PrefixedName
    /// <summary>
    ///   <para>sp:Select</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A SELECT-type query that returns variable bindings as its result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Select query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Select">http://spinrdf.org/sp#Select</seealso>
    let Select = Prefixed_Name(sp, "Select") |> PrefixedName
    /// <summary>
    ///   <para>sp:SeqPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A sequence of multiple paths."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seq path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#SeqPath">http://spinrdf.org/sp#SeqPath</seealso>
    let SeqPath = Prefixed_Name(sp, "SeqPath") |> PrefixedName
    /// <summary>
    ///   <para>sp:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A SERVICE call that matches a nested sub-pattern against a SPARQL end point specified by a URI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Service">http://spinrdf.org/sp#Service</seealso>
    let Service = Prefixed_Name(sp, "Service") |> PrefixedName
    /// <summary>
    ///   <para>sp:SubQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A nested SELECT query inside of an element list. The query is stored in sp:query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#SubQuery">http://spinrdf.org/sp#SubQuery</seealso>
    let SubQuery = Prefixed_Name(sp, "SubQuery") |> PrefixedName
    /// <summary>
    ///   <para>sp:Sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents sum aggregations, e.g. SELECT SUM(?varName)..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SUM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Sum">http://spinrdf.org/sp#Sum</seealso>
    let Sum = Prefixed_Name(sp, "Sum") |> PrefixedName
    /// <summary>
    ///   <para>sp:SystemClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An "artificial" root class that groups all SP classes. This makes them look much less overwhelming in UI tools. Typical end users don't need to see those classes anyway."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SP System class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#SystemClass">http://spinrdf.org/sp#SystemClass</seealso>
    let SystemClass = Prefixed_Name(sp, "SystemClass") |> PrefixedName
    /// <summary>
    ///   <para>sp:Triple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A base class for TriplePattern and TripleTemplate. This basically specifies that subject, predicate and object must be present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Triple"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Triple">http://spinrdf.org/sp#Triple</seealso>
    let Triple = Prefixed_Name(sp, "Triple") |> PrefixedName
    /// <summary>
    ///   <para>sp:TriplePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Similar to a TriplePattern, but with a path expression as its predicate. For example, this can be used to express transitive sub-class relationships (?subClass rdfs:subClassOf* ?superClass)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Triple path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#TriplePath">http://spinrdf.org/sp#TriplePath</seealso>
    let TriplePath = Prefixed_Name(sp, "TriplePath") |> PrefixedName
    /// <summary>
    ///   <para>sp:TriplePattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A triple pattern used in the body of a query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Triple pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#TriplePattern">http://spinrdf.org/sp#TriplePattern</seealso>
    let TriplePattern = Prefixed_Name(sp, "TriplePattern") |> PrefixedName
    /// <summary>
    ///   <para>sp:TripleTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A prototypical triple used as template in the head of a Construct query. May contain variables."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Triple template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#TripleTemplate">http://spinrdf.org/sp#TripleTemplate</seealso>
    let TripleTemplate = Prefixed_Name(sp, "TripleTemplate") |> PrefixedName
    /// <summary>
    ///   <para>sp:Tuple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Abstract base class for things that have subject and object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tuple"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Tuple">http://spinrdf.org/sp#Tuple</seealso>
    let Tuple = Prefixed_Name(sp, "Tuple") |> PrefixedName
    /// <summary>
    ///   <para>sp:Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A UNION group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Union"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Union">http://spinrdf.org/sp#Union</seealso>
    let Union = Prefixed_Name(sp, "Union") |> PrefixedName
    /// <summary>
    ///   <para>sp:Update</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Abstract base class to group the various SPARQL UPDATE commands."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Update"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Update">http://spinrdf.org/sp#Update</seealso>
    let Update = Prefixed_Name(sp, "Update") |> PrefixedName
    /// <summary>
    ///   <para>sp:Values</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A VALUES element. sp:varNames points to an rdf:List of strings for the variables, sp:values to an rdf:List of rdf:Lists with nodes for each variable, in the order defined by the variables list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Values">http://spinrdf.org/sp#Values</seealso>
    let Values = Prefixed_Name(sp, "Values") |> PrefixedName
    /// <summary>
    ///   <para>sp:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A variable mentioned in a Triple or expression. Variables are often blank nodes with the variable name stored in ts:name. Variables can also be supplied with a URI in which case the system will attempt to reuse the same variable instance across multiple query definitions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#Variable">http://spinrdf.org/sp#Variable</seealso>
    let Variable = Prefixed_Name(sp, "Variable") |> PrefixedName
    /// <summary>
    ///   <para>sp:add</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#add">http://spinrdf.org/sp#add</seealso>
    let add = Prefixed_Name(sp, "add") |> PrefixedName
    /// <summary>
    ///   <para>sp:all</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used in DROP and CLEAR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"all"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#all">http://spinrdf.org/sp#all</seealso>
    let all = Prefixed_Name(sp, "all") |> PrefixedName
    /// <summary>
    ///   <para>sp:and</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#and">http://spinrdf.org/sp#and</seealso>
    let and_ = Prefixed_Name(sp, "and") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Abstract superproperty for the enumerated arg1, arg2 etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg">http://spinrdf.org/sp#arg</seealso>
    let arg = Prefixed_Name(sp, "arg") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The first argument of a function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg1">http://spinrdf.org/sp#arg1</seealso>
    let arg1 = Prefixed_Name(sp, "arg1") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The second argument of a function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg2">http://spinrdf.org/sp#arg2</seealso>
    let arg2 = Prefixed_Name(sp, "arg2") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg3</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The third argument of a function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg3">http://spinrdf.org/sp#arg3</seealso>
    let arg3 = Prefixed_Name(sp, "arg3") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg4</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The forth argument of a function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg4">http://spinrdf.org/sp#arg4</seealso>
    let arg4 = Prefixed_Name(sp, "arg4") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg5</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The fifth argument of a function call. Further arguments are not common in SPARQL, therefore no sp:arg6, etc are defined here. However, they can be created if needed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg5">http://spinrdf.org/sp#arg5</seealso>
    let arg5 = Prefixed_Name(sp, "arg5") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg6</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The sixth argument of a function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg6"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg6">http://spinrdf.org/sp#arg6</seealso>
    let arg6 = Prefixed_Name(sp, "arg6") |> PrefixedName
    /// <summary>
    ///   <para>sp:arg7</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The seventh argument of a function call."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arg7"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#arg7">http://spinrdf.org/sp#arg7</seealso>
    let arg7 = Prefixed_Name(sp, "arg7") |> PrefixedName
    /// <summary>
    ///   <para>sp:as</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a Variable used in an AS statement such as COUNT aggregates."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#as">http://spinrdf.org/sp#as</seealso>
    let as_ = Prefixed_Name(sp, "as") |> PrefixedName
    /// <summary>
    ///   <para>sp:bindings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The actual bindings of a sp:Values element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bindings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#bindings">http://spinrdf.org/sp#bindings</seealso>
    let bindings = Prefixed_Name(sp, "bindings") |> PrefixedName
    /// <summary>
    ///   <para>sp:bound</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#bound">http://spinrdf.org/sp#bound</seealso>
    let bound = Prefixed_Name(sp, "bound") |> PrefixedName
    /// <summary>
    ///   <para>sp:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used in DROP and CLEAR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"default"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#default">http://spinrdf.org/sp#default</seealso>
    let default_ = Prefixed_Name(sp, "default") |> PrefixedName
    /// <summary>
    ///   <para>sp:deletePattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a list of sp:TripleTemplates and sp:NamedGraphs in a modify operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"delete pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#deletePattern">http://spinrdf.org/sp#deletePattern</seealso>
    let deletePattern = Prefixed_Name(sp, "deletePattern") |> PrefixedName
    /// <summary>
    ///   <para>sp:distinct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A marker property to indicate that a Select query is of type SELECT DISTINCT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"distinct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#distinct">http://spinrdf.org/sp#distinct</seealso>
    let distinct = Prefixed_Name(sp, "distinct") |> PrefixedName
    /// <summary>
    ///   <para>sp:document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URI of the document to load using a LOAD Update operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#document">http://spinrdf.org/sp#document</seealso>
    let document = Prefixed_Name(sp, "document") |> PrefixedName
    /// <summary>
    ///   <para>sp:elements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to an ElementList, for example in an Optional element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"elements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#elements">http://spinrdf.org/sp#elements</seealso>
    let elements = Prefixed_Name(sp, "elements") |> PrefixedName
    /// <summary>
    ///   <para>sp:eq</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#eq">http://spinrdf.org/sp#eq</seealso>
    let eq = Prefixed_Name(sp, "eq") |> PrefixedName
    /// <summary>
    ///   <para>sp:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to an expression, for example in a Filter or Assignment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#expression">http://spinrdf.org/sp#expression</seealso>
    let expression = Prefixed_Name(sp, "expression") |> PrefixedName
    /// <summary>
    ///   <para>sp:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies an RDF Dataset used by a Query (FROM syntax in SPARQL). Values of this property must be URI resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#from">http://spinrdf.org/sp#from</seealso>
    let from = Prefixed_Name(sp, "from") |> PrefixedName
    /// <summary>
    ///   <para>sp:fromNamed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a named RDF Dataset used by a Query (FROM NAMED syntax in SPARQL). Values of this property must be URI resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"from named"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#fromNamed">http://spinrdf.org/sp#fromNamed</seealso>
    let fromNamed = Prefixed_Name(sp, "fromNamed") |> PrefixedName
    /// <summary>
    ///   <para>sp:ge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#ge">http://spinrdf.org/sp#ge</seealso>
    let ge = Prefixed_Name(sp, "ge") |> PrefixedName
    /// <summary>
    ///   <para>sp:graphIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to graph names (IRIs) in various sp:Update operations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"graph IRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#graphIRI">http://spinrdf.org/sp#graphIRI</seealso>
    let graphIRI = Prefixed_Name(sp, "graphIRI") |> PrefixedName
    /// <summary>
    ///   <para>sp:graphNameNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name (URI or Variable) of a NamedGraph."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"graph name node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#graphNameNode">http://spinrdf.org/sp#graphNameNode</seealso>
    let graphNameNode = Prefixed_Name(sp, "graphNameNode") |> PrefixedName
    /// <summary>
    ///   <para>sp:groupBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points from a Query to the list of GROUP BY expressions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"group by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#groupBy">http://spinrdf.org/sp#groupBy</seealso>
    let groupBy = Prefixed_Name(sp, "groupBy") |> PrefixedName
    /// <summary>
    ///   <para>sp:gt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#gt">http://spinrdf.org/sp#gt</seealso>
    let gt = Prefixed_Name(sp, "gt") |> PrefixedName
    /// <summary>
    ///   <para>sp:having</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points from a SELECT query to a list of HAVING expressions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"having"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#having">http://spinrdf.org/sp#having</seealso>
    let having = Prefixed_Name(sp, "having") |> PrefixedName
    /// <summary>
    ///   <para>sp:insertPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a list of sp:TripleTemplates or sp:NamedGraphs in a modify command."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"insert pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#insertPattern">http://spinrdf.org/sp#insertPattern</seealso>
    let insertPattern = Prefixed_Name(sp, "insertPattern") |> PrefixedName
    /// <summary>
    ///   <para>sp:into</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The (optional) target of a LOAD Update operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"into"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#into">http://spinrdf.org/sp#into</seealso>
    let into = Prefixed_Name(sp, "into") |> PrefixedName
    /// <summary>
    ///   <para>sp:limit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The LIMIT solution modifier of a Query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#limit">http://spinrdf.org/sp#limit</seealso>
    let limit = Prefixed_Name(sp, "limit") |> PrefixedName
    /// <summary>
    ///   <para>sp:lt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#lt">http://spinrdf.org/sp#lt</seealso>
    let lt = Prefixed_Name(sp, "lt") |> PrefixedName
    /// <summary>
    ///   <para>sp:modMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"mod max"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#modMax">http://spinrdf.org/sp#modMax</seealso>
    let modMax = Prefixed_Name(sp, "modMax") |> PrefixedName
    /// <summary>
    ///   <para>sp:modMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"mod min"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#modMin">http://spinrdf.org/sp#modMin</seealso>
    let modMin = Prefixed_Name(sp, "modMin") |> PrefixedName
    /// <summary>
    ///   <para>sp:mul</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#mul">http://spinrdf.org/sp#mul</seealso>
    let mul = Prefixed_Name(sp, "mul") |> PrefixedName
    /// <summary>
    ///   <para>sp:named</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used in DROP and CLEAR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"named"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#named">http://spinrdf.org/sp#named</seealso>
    let named = Prefixed_Name(sp, "named") |> PrefixedName
    /// <summary>
    ///   <para>sp:ne</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#ne">http://spinrdf.org/sp#ne</seealso>
    let ne = Prefixed_Name(sp, "ne") |> PrefixedName
    /// <summary>
    ///   <para>sp:node</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#node">http://spinrdf.org/sp#node</seealso>
    let node = Prefixed_Name(sp, "node") |> PrefixedName
    /// <summary>
    ///   <para>sp:not</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#not">http://spinrdf.org/sp#not</seealso>
    let ``not`` = Prefixed_Name(sp, "not") |> PrefixedName
    /// <summary>
    ///   <para>sp:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An RDF Node or Variable describing the object of a triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#object">http://spinrdf.org/sp#object</seealso>
    let object = Prefixed_Name(sp, "object") |> PrefixedName
    /// <summary>
    ///   <para>sp:offset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The OFFSET solution modifier of a Query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"offset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#offset">http://spinrdf.org/sp#offset</seealso>
    let offset = Prefixed_Name(sp, "offset") |> PrefixedName
    /// <summary>
    ///   <para>sp:or</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#or">http://spinrdf.org/sp#or</seealso>
    let or_ = Prefixed_Name(sp, "or") |> PrefixedName
    /// <summary>
    ///   <para>sp:orderBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a query with an ORDER BY clause where the values are rdf:List containing OrderByConditions or expressions. While the domain of this property is sp:Query, only Describe and Select queries can have values of it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#orderBy">http://spinrdf.org/sp#orderBy</seealso>
    let orderBy = Prefixed_Name(sp, "orderBy") |> PrefixedName
    /// <summary>
    ///   <para>sp:path</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points from a TriplePath to its path."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#path">http://spinrdf.org/sp#path</seealso>
    let path = Prefixed_Name(sp, "path") |> PrefixedName
    /// <summary>
    ///   <para>sp:path1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The first child path of a property path. Used by sp:AltPath and sp:SeqPath."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"path1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#path1">http://spinrdf.org/sp#path1</seealso>
    let path1 = Prefixed_Name(sp, "path1") |> PrefixedName
    /// <summary>
    ///   <para>sp:path2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The second child path of a property path. Used by sp:AltPath and sp:SeqPath."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"path2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#path2">http://spinrdf.org/sp#path2</seealso>
    let path2 = Prefixed_Name(sp, "path2") |> PrefixedName
    /// <summary>
    ///   <para>sp:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A resource or Variable describing the predicate of a triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#predicate">http://spinrdf.org/sp#predicate</seealso>
    let predicate = Prefixed_Name(sp, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>sp:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a SubQuery resource with the nested Query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#query">http://spinrdf.org/sp#query</seealso>
    let query = Prefixed_Name(sp, "query") |> PrefixedName
    /// <summary>
    ///   <para>sp:reduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property with true to indicate that a Select query has a REDUCED flag."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#reduced">http://spinrdf.org/sp#reduced</seealso>
    let reduced = Prefixed_Name(sp, "reduced") |> PrefixedName
    /// <summary>
    ///   <para>sp:regex</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#regex">http://spinrdf.org/sp#regex</seealso>
    let regex = Prefixed_Name(sp, "regex") |> PrefixedName
    /// <summary>
    ///   <para>sp:resultNodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Contains the result nodes (URI resources or Variables) of a Describe query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"result nodes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#resultNodes">http://spinrdf.org/sp#resultNodes</seealso>
    let resultNodes = Prefixed_Name(sp, "resultNodes") |> PrefixedName
    /// <summary>
    ///   <para>sp:resultVariables</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An rdf:List of variables that are returned by a Select query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"result variables"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#resultVariables">http://spinrdf.org/sp#resultVariables</seealso>
    let resultVariables = Prefixed_Name(sp, "resultVariables") |> PrefixedName
    /// <summary>
    ///   <para>sp:separator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Stores the separator="..." value of a GROUP_CONCAT (sp:GroupConcat) aggregation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"separator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#separator">http://spinrdf.org/sp#separator</seealso>
    let separator = Prefixed_Name(sp, "separator") |> PrefixedName
    /// <summary>
    ///   <para>sp:serviceURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used by sp:Service to specify the URI of the SPARQL end point to invoke. Must point to a URI node."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"service URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#serviceURI">http://spinrdf.org/sp#serviceURI</seealso>
    let serviceURI = Prefixed_Name(sp, "serviceURI") |> PrefixedName
    /// <summary>
    ///   <para>sp:silent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"silent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#silent">http://spinrdf.org/sp#silent</seealso>
    let silent = Prefixed_Name(sp, "silent") |> PrefixedName
    /// <summary>
    ///   <para>sp:str</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#str">http://spinrdf.org/sp#str</seealso>
    let str = Prefixed_Name(sp, "str") |> PrefixedName
    /// <summary>
    ///   <para>sp:sub</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/sp#sub">http://spinrdf.org/sp#sub</seealso>
    let sub = Prefixed_Name(sp, "sub") |> PrefixedName
    /// <summary>
    ///   <para>sp:subPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The child path of a property path expression. This is used by ReversePath and ModPath."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sub path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#subPath">http://spinrdf.org/sp#subPath</seealso>
    let subPath = Prefixed_Name(sp, "subPath") |> PrefixedName
    /// <summary>
    ///   <para>sp:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A resource or Variable describing the subject of a triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#subject">http://spinrdf.org/sp#subject</seealso>
    let subject = Prefixed_Name(sp, "subject") |> PrefixedName
    /// <summary>
    ///   <para>sp:systemProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An abstract base proprerty that groups together the SP system properties. Users typically don't need to see them anyway."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SP system property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#systemProperty">http://spinrdf.org/sp#systemProperty</seealso>
    let systemProperty = Prefixed_Name(sp, "systemProperty") |> PrefixedName
    /// <summary>
    ///   <para>sp:templates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a list of TripleTemplates that form the head of a Construct query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#templates">http://spinrdf.org/sp#templates</seealso>
    let templates = Prefixed_Name(sp, "templates") |> PrefixedName
    /// <summary>
    ///   <para>sp:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be attached to sp:Queries to store a textual representation of the query. This can be useful for tools that do not have a complete SPIN Syntax parser available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#text">http://spinrdf.org/sp#text</seealso>
    let text = Prefixed_Name(sp, "text") |> PrefixedName
    /// <summary>
    ///   <para>sp:using</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"using"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#using">http://spinrdf.org/sp#using</seealso>
    let using = Prefixed_Name(sp, "using") |> PrefixedName
    /// <summary>
    ///   <para>sp:usingNamed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"using named"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#usingNamed">http://spinrdf.org/sp#usingNamed</seealso>
    let usingNamed = Prefixed_Name(sp, "usingNamed") |> PrefixedName
    /// <summary>
    ///   <para>sp:values</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The VALUES block at the end of a query. The object may just be an untyped blank node, i.e. the sp:Values type triple is optional."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#values">http://spinrdf.org/sp#values</seealso>
    let values = Prefixed_Name(sp, "values") |> PrefixedName
    /// <summary>
    ///   <para>sp:varName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of a Variable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"varName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#varName">http://spinrdf.org/sp#varName</seealso>
    let varName = Prefixed_Name(sp, "varName") |> PrefixedName
    /// <summary>
    ///   <para>sp:varNames</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The names of the variables (xsd:strings) of the variables declared for a VALUES element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"var names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#varNames">http://spinrdf.org/sp#varNames</seealso>
    let varNames = Prefixed_Name(sp, "varNames") |> PrefixedName
    /// <summary>
    ///   <para>sp:variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The variable of a Bind element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#variable">http://spinrdf.org/sp#variable</seealso>
    let variable = Prefixed_Name(sp, "variable") |> PrefixedName
    /// <summary>
    ///   <para>sp:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The WHERE clause of a Query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"where"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#where">http://spinrdf.org/sp#where</seealso>
    let where = Prefixed_Name(sp, "where") |> PrefixedName
    /// <summary>
    ///   <para>sp:with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spinrdf.org/sp#with">http://spinrdf.org/sp#with</seealso>
    let with_ = Prefixed_Name(sp, "with") |> PrefixedName
