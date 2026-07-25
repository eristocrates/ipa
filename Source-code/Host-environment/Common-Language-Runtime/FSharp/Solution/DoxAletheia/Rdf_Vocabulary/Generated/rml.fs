namespace http.w3id.org.rml.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rml =
    let _namespace_iri = Namespace_Iri rml |> NamespaceIRI
    /// <summary>
    ///   <para>rml:core/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/core/">http://w3id.org/rml/core/</seealso>
    let ``core/`` = Prefixed_Name(rml, "core/") |> PrefixedName
    /// <summary>
    ///   <para>rml:DatatypeMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a datatype map</para>
    /// labels<para>Datatype Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/DatatypeMap">http://w3id.org/rml/DatatypeMap</seealso>
    let DatatypeMap = Prefixed_Name(rml, "DatatypeMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:IRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Denotes an IRI, used with termpType.</para>
    /// labels<para>IRI</para></remarks>
    /// <seealso href="http://w3id.org/rml/IRI">http://w3id.org/rml/IRI</seealso>
    let IRI = Prefixed_Name(rml, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>rml:Join</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a join condition.</para>
    /// labels<para>Join</para></remarks>
    /// <seealso href="http://w3id.org/rml/Join">http://w3id.org/rml/Join</seealso>
    let Join = Prefixed_Name(rml, "Join") |> PrefixedName
    /// <summary>
    ///   <para>rml:GraphMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a graph map.</para>
    /// labels<para>Graph Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/GraphMap">http://w3id.org/rml/GraphMap</seealso>
    let GraphMap = Prefixed_Name(rml, "GraphMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:ChildMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a child map</para>
    /// labels<para>Child Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/ChildMap">http://w3id.org/rml/ChildMap</seealso>
    let ChildMap = Prefixed_Name(rml, "ChildMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:ExpressionMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents an expression map</para>
    /// labels<para>Expression Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/ExpressionMap">http://w3id.org/rml/ExpressionMap</seealso>
    let ExpressionMap = Prefixed_Name(rml, "ExpressionMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:TermMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that generates any number of RDF terms from a logical source record.</para>
    /// labels<para>Term Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/TermMap">http://w3id.org/rml/TermMap</seealso>
    let TermMap = Prefixed_Name(rml, "TermMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:LanguageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a language map</para>
    /// labels<para>Language Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/LanguageMap">http://w3id.org/rml/LanguageMap</seealso>
    let LanguageMap = Prefixed_Name(rml, "LanguageMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:LogicalSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/LogicalSource">http://w3id.org/rml/LogicalSource</seealso>
    let LogicalSource = Prefixed_Name(rml, "LogicalSource") |> PrefixedName
    /// <summary>
    ///   <para>rml:ParentMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a parent map</para>
    /// labels<para>Parent Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/ParentMap">http://w3id.org/rml/ParentMap</seealso>
    let ParentMap = Prefixed_Name(rml, "ParentMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:LogicalTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/LogicalTarget">http://w3id.org/rml/LogicalTarget</seealso>
    let LogicalTarget = Prefixed_Name(rml, "LogicalTarget") |> PrefixedName
    /// <summary>
    ///   <para>rml:PredicateObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a predicate-object map.</para>
    /// labels<para>Predicate Object Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/PredicateObjectMap">http://w3id.org/rml/PredicateObjectMap</seealso>
    let PredicateObjectMap = Prefixed_Name(rml, "PredicateObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:SubjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a subject map.</para>
    /// labels<para>Subject Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/SubjectMap">http://w3id.org/rml/SubjectMap</seealso>
    let SubjectMap = Prefixed_Name(rml, "SubjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:PredicateMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a predicate map.</para>
    /// labels<para>Predicate Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/PredicateMap">http://w3id.org/rml/PredicateMap</seealso>
    let PredicateMap = Prefixed_Name(rml, "PredicateMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:TriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a triples map.</para>
    /// labels<para>Triples Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/TriplesMap">http://w3id.org/rml/TriplesMap</seealso>
    let TriplesMap = Prefixed_Name(rml, "TriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Names a source record in the child source of a join.</para>
    /// labels<para>child</para></remarks>
    /// <seealso href="http://w3id.org/rml/child">http://w3id.org/rml/child</seealso>
    let child = Prefixed_Name(rml, "child") |> PrefixedName
    /// <summary>
    ///   <para>rml:childMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Names a child map in the child source of a join.</para>
    /// labels<para>child map</para></remarks>
    /// <seealso href="http://w3id.org/rml/childMap">http://w3id.org/rml/childMap</seealso>
    let childMap = Prefixed_Name(rml, "childMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:constant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A property for indicating whether a expression map is a constant-valued expression map.</para>
    /// labels<para>constant</para></remarks>
    /// <seealso href="http://w3id.org/rml/constant">http://w3id.org/rml/constant</seealso>
    let constant = Prefixed_Name(rml, "constant") |> PrefixedName
    /// <summary>
    ///   <para>rml:core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/core">http://w3id.org/rml/core</seealso>
    let core = Prefixed_Name(rml, "core") |> PrefixedName
    /// <summary>
    ///   <para>rml:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The subject value generated for a logical source record will be asserted as an instance of this RDFS class.</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="http://w3id.org/rml/class">http://w3id.org/rml/class</seealso>
    let class_ = Prefixed_Name(rml, "class") |> PrefixedName
    /// <summary>
    ///   <para>rml:graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An IRI reference for use as the graph name of all triples generated with the SubjectMap or PredicateObjectMap.</para>
    /// labels<para>graph</para></remarks>
    /// <seealso href="http://w3id.org/rml/graph">http://w3id.org/rml/graph</seealso>
    let graph = Prefixed_Name(rml, "graph") |> PrefixedName
    /// <summary>
    ///   <para>rml:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the datatype of the object component for the generated triple.</para>
    /// labels<para>datatype</para></remarks>
    /// <seealso href="http://w3id.org/rml/datatype">http://w3id.org/rml/datatype</seealso>
    let datatype = Prefixed_Name(rml, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>rml:joinCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the join condition for joining the child logical source with the parent logical source of the foreign key constraint.</para>
    /// labels<para>join condition</para></remarks>
    /// <seealso href="http://w3id.org/rml/joinCondition">http://w3id.org/rml/joinCondition</seealso>
    let joinCondition = Prefixed_Name(rml, "joinCondition") |> PrefixedName
    /// <summary>
    ///   <para>rml:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specified the language for the object component for the generated triple.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://w3id.org/rml/language">http://w3id.org/rml/language</seealso>
    let language = Prefixed_Name(rml, "language") |> PrefixedName
    /// <summary>
    ///   <para>rml:logicalSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Represents the logical source to be mapped.</para>
    /// labels<para>logical source</para></remarks>
    /// <seealso href="http://w3id.org/rml/logicalSource">http://w3id.org/rml/logicalSource</seealso>
    let logicalSource = Prefixed_Name(rml, "logicalSource") |> PrefixedName
    /// <summary>
    ///   <para>rml:parentMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Names a parent map in the parent source of a join.</para>
    /// labels<para>parent map</para></remarks>
    /// <seealso href="http://w3id.org/rml/parentMap">http://w3id.org/rml/parentMap</seealso>
    let parentMap = Prefixed_Name(rml, "parentMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:predicateMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical source record.</para>
    /// labels<para>predicate map</para></remarks>
    /// <seealso href="http://w3id.org/rml/predicateMap">http://w3id.org/rml/predicateMap</seealso>
    let predicateMap = Prefixed_Name(rml, "predicateMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:predicateObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A PredicateObjectMap element to generate (predicate, object) pair from a logical source record.</para>
    /// labels<para>predicate object map</para></remarks>
    /// <seealso href="http://w3id.org/rml/predicateObjectMap">http://w3id.org/rml/predicateObjectMap</seealso>
    let predicateObjectMap = Prefixed_Name(rml, "predicateObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An IRI reference for use as subject for all the RDF triples generated from a logical source record.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://w3id.org/rml/subject">http://w3id.org/rml/subject</seealso>
    let subject = Prefixed_Name(rml, "subject") |> PrefixedName
    /// <summary>
    ///   <para>rml:template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A template (format string) to specify how to generate a value for a expression map, using one or more records from a logical source record.</para>
    /// labels<para>template</para></remarks>
    /// <seealso href="http://w3id.org/rml/template">http://w3id.org/rml/template</seealso>
    let template = Prefixed_Name(rml, "template") |> PrefixedName
    /// <summary>
    ///   <para>rml:datatypeMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A DatatypetMap element to generate the datatype component of the object component from a logical source record.</para>
    /// labels<para>datatype map</para></remarks>
    /// <seealso href="http://w3id.org/rml/datatypeMap">http://w3id.org/rml/datatypeMap</seealso>
    let datatypeMap = Prefixed_Name(rml, "datatypeMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:graphMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.</para>
    /// labels<para>graph map</para></remarks>
    /// <seealso href="http://w3id.org/rml/graphMap">http://w3id.org/rml/graphMap</seealso>
    let graphMap = Prefixed_Name(rml, "graphMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:languageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LanguagetMap element to generate the language tag of the object component from a logical source record.</para>
    /// labels<para>language map</para></remarks>
    /// <seealso href="http://w3id.org/rml/languageMap">http://w3id.org/rml/languageMap</seealso>
    let languageMap = Prefixed_Name(rml, "languageMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the object for the generated triple from the logical source record.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://w3id.org/rml/object">http://w3id.org/rml/object</seealso>
    let object = Prefixed_Name(rml, "object") |> PrefixedName
    /// <summary>
    ///   <para>rml:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Names a source record in the parent source of a join.</para>
    /// labels<para>parent</para></remarks>
    /// <seealso href="http://w3id.org/rml/parent">http://w3id.org/rml/parent</seealso>
    let parent = Prefixed_Name(rml, "parent") |> PrefixedName
    /// <summary>
    ///   <para>rml:logicalTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Represents the logical target to where triples are exported to.</para>
    /// labels<para>logical target</para></remarks>
    /// <seealso href="http://w3id.org/rml/logicalTarget">http://w3id.org/rml/logicalTarget</seealso>
    let logicalTarget = Prefixed_Name(rml, "logicalTarget") |> PrefixedName
    /// <summary>
    ///   <para>rml:objectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An ObjectMap element to generate the object component of the (predicate, object) pair from a logical source record.</para>
    /// labels<para>object map</para></remarks>
    /// <seealso href="http://w3id.org/rml/objectMap">http://w3id.org/rml/objectMap</seealso>
    let objectMap = Prefixed_Name(rml, "objectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the predicate for the generated triple from the logical source record.</para>
    /// labels<para>predicate</para></remarks>
    /// <seealso href="http://w3id.org/rml/predicate">http://w3id.org/rml/predicate</seealso>
    let predicate = Prefixed_Name(rml, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>rml:parentTriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the TriplesMap element corresponding to the parent logical source of the foreign key constraint.</para>
    /// labels<para>parent triples map</para></remarks>
    /// <seealso href="http://w3id.org/rml/parentTriplesMap">http://w3id.org/rml/parentTriplesMap</seealso>
    let parentTriplesMap = Prefixed_Name(rml, "parentTriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Strategy element to indicate how to perform an action (e.g. gather for collections and containers, join).</para>
    /// labels<para>strategy</para></remarks>
    /// <seealso href="http://w3id.org/rml/strategy">http://w3id.org/rml/strategy</seealso>
    let strategy = Prefixed_Name(rml, "strategy") |> PrefixedName
    /// <summary>
    ///   <para>rml:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A valid expression that selects values from the source data. The reference should conform to the syntax rules/grammar of the specified Reference Formulation.</para>
    /// labels<para>reference</para></remarks>
    /// <seealso href="http://w3id.org/rml/reference">http://w3id.org/rml/reference</seealso>
    let reference = Prefixed_Name(rml, "reference") |> PrefixedName
    /// <summary>
    ///   <para>rml:subjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A SubjectMap element to generate a subject from a logical source record.</para>
    /// labels<para>subject map</para></remarks>
    /// <seealso href="http://w3id.org/rml/subjectMap">http://w3id.org/rml/subjectMap</seealso>
    let subjectMap = Prefixed_Name(rml, "subjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A string indicating whether subject or object generated using the value from a source record name specified should be an IRI reference, blank node, or a literal.</para>
    /// labels<para>term type</para></remarks>
    /// <seealso href="http://w3id.org/rml/termType">http://w3id.org/rml/termType</seealso>
    let termType = Prefixed_Name(rml, "termType") |> PrefixedName
    /// <summary>
    ///   <para>rml:BlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Denotes a blank node, used with termType</para>
    /// labels<para>Blank Node</para></remarks>
    /// <seealso href="http://w3id.org/rml/BlankNode">http://w3id.org/rml/BlankNode</seealso>
    let BlankNode = Prefixed_Name(rml, "BlankNode") |> PrefixedName
    /// <summary>
    ///   <para>rml:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Denotes a Literal, used with termType.</para>
    /// labels<para>Literal</para></remarks>
    /// <seealso href="http://w3id.org/rml/Literal">http://w3id.org/rml/Literal</seealso>
    let Literal = Prefixed_Name(rml, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>rml:ObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents an object map.</para>
    /// labels<para>Object Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/ObjectMap">http://w3id.org/rml/ObjectMap</seealso>
    let ObjectMap = Prefixed_Name(rml, "ObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:RefObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Denotes a reference to an object map.</para>
    /// labels<para>Reference Object Map</para></remarks>
    /// <seealso href="http://w3id.org/rml/RefObjectMap">http://w3id.org/rml/RefObjectMap</seealso>
    let RefObjectMap = Prefixed_Name(rml, "RefObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Denotes a strategy to perform a action (e.g. gather for collections and containers, joins).</para>
    /// labels<para>Strategy</para></remarks>
    /// <seealso href="http://w3id.org/rml/Strategy">http://w3id.org/rml/Strategy</seealso>
    let Strategy = Prefixed_Name(rml, "Strategy") |> PrefixedName
