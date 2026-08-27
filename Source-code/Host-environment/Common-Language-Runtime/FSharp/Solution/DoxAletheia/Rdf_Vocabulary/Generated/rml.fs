namespace http.w3id.org.rml.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rml =
    let _namespace_iri = Namespace_Iri rml |> NamespaceIRI
    /// <summary>
    ///   <para>rml:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/">http://w3id.org/rml/</seealso>
    let _prefix_iri = Prefixed_Name(rml, "") |> PrefixedName
    /// <summary>
    ///   <para>rml:AssertedTriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of Triples Map that is quoted and asserted in the resulting graph."</para>
    /// labels<para>"Asserted Triples Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/AssertedTriplesMap">http://w3id.org/rml/AssertedTriplesMap</seealso>
    let AssertedTriplesMap = Prefixed_Name(rml, "AssertedTriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:BlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a blank node, used with termType"</para>
    /// labels<para>"Blank Node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/BlankNode">http://w3id.org/rml/BlankNode</seealso>
    let BlankNode = Prefixed_Name(rml, "BlankNode") |> PrefixedName
    /// <summary>
    ///   <para>rml:CSV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:ReferenceFormulation</para>
    ///   <para>"Denotes that the CSV file's column names are used for referring to extracts of CSV resources."</para>
    /// labels<para>"CSV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/CSV">http://w3id.org/rml/CSV</seealso>
    let CSV = Prefixed_Name(rml, "CSV") |> PrefixedName
    /// <summary>
    ///   <para>rml:ChildMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a child map"</para>
    /// labels<para>"Child Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ChildMap">http://w3id.org/rml/ChildMap</seealso>
    let ChildMap = Prefixed_Name(rml, "ChildMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:Compression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents file compression schemes."</para>
    /// labels<para>"compression class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Compression">http://w3id.org/rml/Compression</seealso>
    let Compression = Prefixed_Name(rml, "Compression") |> PrefixedName
    /// <summary>
    ///   <para>rml:DatatypeMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a datatype map"</para>
    /// labels<para>"Datatype Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/DatatypeMap">http://w3id.org/rml/DatatypeMap</seealso>
    let DatatypeMap = Prefixed_Name(rml, "DatatypeMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:Encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents encoding formats."</para>
    /// labels<para>"Encoding class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Encoding">http://w3id.org/rml/Encoding</seealso>
    let Encoding = Prefixed_Name(rml, "Encoding") |> PrefixedName
    /// <summary>
    ///   <para>rml:ExpressionMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an expression map"</para>
    /// labels<para>"Expression Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ExpressionMap">http://w3id.org/rml/ExpressionMap</seealso>
    let ExpressionMap = Prefixed_Name(rml, "ExpressionMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:FunctionExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a function execution."</para>
    /// labels<para>"Function Execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/FunctionExecution">http://w3id.org/rml/FunctionExecution</seealso>
    let FunctionExecution = Prefixed_Name(rml, "FunctionExecution") |> PrefixedName
    /// <summary>
    ///   <para>rml:FunctionMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a function map."</para>
    /// labels<para>"Function Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/FunctionMap">http://w3id.org/rml/FunctionMap</seealso>
    let FunctionMap = Prefixed_Name(rml, "FunctionMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:GatherMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a term map that generates a collection (rdf:List) or container (rdf:Bag, rdf:Seq, rdf:Alt)."</para>
    /// labels<para>"Gather Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/GatherMap">http://w3id.org/rml/GatherMap</seealso>
    let GatherMap = Prefixed_Name(rml, "GatherMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:GraphMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a graph map."</para>
    /// labels<para>"Graph Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/GraphMap">http://w3id.org/rml/GraphMap</seealso>
    let GraphMap = Prefixed_Name(rml, "GraphMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:IRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes an IRI, used with termpType."</para>
    /// labels<para>"IRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/IRI">http://w3id.org/rml/IRI</seealso>
    let IRI = Prefixed_Name(rml, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>rml:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a input for an execution."</para>
    /// labels<para>"Input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Input">http://w3id.org/rml/Input</seealso>
    let Input = Prefixed_Name(rml, "Input") |> PrefixedName
    /// <summary>
    ///   <para>rml:JSONPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:ReferenceFormulation</para>
    ///   <para>"Denotes the JSONPath reference formulation, used for referring to extracts of JSON sources."</para>
    /// labels<para>"JSONPath"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/JSONPath">http://w3id.org/rml/JSONPath</seealso>
    let JSONPath = Prefixed_Name(rml, "JSONPath") |> PrefixedName
    /// <summary>
    ///   <para>rml:Join</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a join condition."</para>
    /// labels<para>"Join"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Join">http://w3id.org/rml/Join</seealso>
    let Join = Prefixed_Name(rml, "Join") |> PrefixedName
    /// <summary>
    ///   <para>rml:LanguageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a language map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Language Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/LanguageMap">http://w3id.org/rml/LanguageMap</seealso>
    let LanguageMap = Prefixed_Name(rml, "LanguageMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a Literal, used with termType."</para>
    /// labels<para>"Literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Literal">http://w3id.org/rml/Literal</seealso>
    let Literal = Prefixed_Name(rml, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>rml:LogicalSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a logical source."</para>
    /// labels<para>"Logical Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/LogicalSource">http://w3id.org/rml/LogicalSource</seealso>
    let LogicalSource = Prefixed_Name(rml, "LogicalSource") |> PrefixedName
    /// <summary>
    ///   <para>rml:LogicalTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a logical target."</para>
    /// labels<para>"LogicalTarget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/LogicalTarget">http://w3id.org/rml/LogicalTarget</seealso>
    let LogicalTarget = Prefixed_Name(rml, "LogicalTarget") |> PrefixedName
    /// <summary>
    ///   <para>rml:Namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a namespace"</para>
    /// labels<para>"Namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Namespace">http://w3id.org/rml/Namespace</seealso>
    let Namespace = Prefixed_Name(rml, "Namespace") |> PrefixedName

    /// <summary>
    ///   <para>rml:NonAssertedTriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of Triples Map that is quoted but not asserted in the resulting graph"</para>
    /// labels<para>"Non Asserted Triples Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/NonAssertedTriplesMap">http://w3id.org/rml/NonAssertedTriplesMap</seealso>
    let NonAssertedTriplesMap =
        Prefixed_Name(rml, "NonAssertedTriplesMap") |> PrefixedName

    /// <summary>
    ///   <para>rml:ObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an object map."</para>
    /// labels<para>"Object Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ObjectMap">http://w3id.org/rml/ObjectMap</seealso>
    let ObjectMap = Prefixed_Name(rml, "ObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:ParameterMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a parameter map."</para>
    /// labels<para>"Parameter Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ParameterMap">http://w3id.org/rml/ParameterMap</seealso>
    let ParameterMap = Prefixed_Name(rml, "ParameterMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:ParentMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a parent map"</para>
    /// labels<para>"Parent Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ParentMap">http://w3id.org/rml/ParentMap</seealso>
    let ParentMap = Prefixed_Name(rml, "ParentMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:PredicateMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a predicate map."</para>
    /// labels<para>"Predicate Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/PredicateMap">http://w3id.org/rml/PredicateMap</seealso>
    let PredicateMap = Prefixed_Name(rml, "PredicateMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:PredicateObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a predicate-object map."</para>
    /// labels<para>"Predicate Object Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/PredicateObjectMap">http://w3id.org/rml/PredicateObjectMap</seealso>
    let PredicateObjectMap = Prefixed_Name(rml, "PredicateObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:RefObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a reference to an object map."</para>
    /// labels<para>"Reference Object Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/RefObjectMap">http://w3id.org/rml/RefObjectMap</seealso>
    let RefObjectMap = Prefixed_Name(rml, "RefObjectMap") |> PrefixedName

    /// <summary>
    ///   <para>rml:ReferenceFormulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a Reference Formulation."</para>
    /// labels<para>"Reference Formulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ReferenceFormulation">http://w3id.org/rml/ReferenceFormulation</seealso>
    let ReferenceFormulation =
        Prefixed_Name(rml, "ReferenceFormulation") |> PrefixedName

    /// <summary>
    ///   <para>rml:ReturnMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a return map."</para>
    /// labels<para>"Return Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/ReturnMap">http://w3id.org/rml/ReturnMap</seealso>
    let ReturnMap = Prefixed_Name(rml, "ReturnMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:SQL2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rml:ReferenceFormulation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Denotes the Core SQL 2008."</para>
    /// labels<para>"SQL 2008"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/SQL2008">http://w3id.org/rml/SQL2008</seealso>
    let SQL2008 = Prefixed_Name(rml, "SQL2008") |> PrefixedName
    /// <summary>
    ///   <para>rml:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a source."</para>
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Source">http://w3id.org/rml/Source</seealso>
    let Source = Prefixed_Name(rml, "Source") |> PrefixedName
    /// <summary>
    ///   <para>rml:StarMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a star map able to generate RDF-star triples."</para>
    /// labels<para>"Star Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/StarMap">http://w3id.org/rml/StarMap</seealso>
    let StarMap = Prefixed_Name(rml, "StarMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a strategy to perform a action (e.g. gather for collections and containers, joins)."</para>
    /// labels<para>"Strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Strategy">http://w3id.org/rml/Strategy</seealso>
    let Strategy = Prefixed_Name(rml, "Strategy") |> PrefixedName
    /// <summary>
    ///   <para>rml:SubjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a subject map."</para>
    /// labels<para>"Subject Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/SubjectMap">http://w3id.org/rml/SubjectMap</seealso>
    let SubjectMap = Prefixed_Name(rml, "SubjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:Target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a target."</para>
    /// labels<para>"Target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/Target">http://w3id.org/rml/Target</seealso>
    let Target = Prefixed_Name(rml, "Target") |> PrefixedName
    /// <summary>
    ///   <para>rml:TermMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A function that generates any number of RDF terms from a logical source record."</para>
    /// labels<para>"Term Map"</para></remarks>
    /// <seealso href="http://w3id.org/rml/TermMap">http://w3id.org/rml/TermMap</seealso>
    let TermMap = Prefixed_Name(rml, "TermMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:TriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a triples map."</para>
    /// labels<para>"Triples Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/TriplesMap">http://w3id.org/rml/TriplesMap</seealso>
    let TriplesMap = Prefixed_Name(rml, "TriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:UTF-16</para>
    /// </summary>
    /// <remarks>
    ///   <para>rml:Encoding</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents the UFT-16 encoding."</para>
    /// labels<para>"UTF-16"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/UTF-16">http://w3id.org/rml/UTF-16</seealso>
    let UTF_16 = Prefixed_Name(rml, "UTF-16") |> PrefixedName
    /// <summary>
    ///   <para>rml:UTF-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>rml:Encoding</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents the UFT-8 encoding."</para>
    /// labels<para>"UTF-8"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/UTF-8">http://w3id.org/rml/UTF-8</seealso>
    let UTF_8 = Prefixed_Name(rml, "UTF-8") |> PrefixedName
    /// <summary>
    ///   <para>rml:XPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rml:ReferenceFormulation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Denotes the XPath reference formulation, used for referring to extracts of XML sources."</para>
    /// labels<para>"XPath"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/XPath">http://w3id.org/rml/XPath</seealso>
    let XPath = Prefixed_Name(rml, "XPath") |> PrefixedName

    /// <summary>
    ///   <para>rml:XPathReferenceFormulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a XPath Reference Formulation."</para>
    /// labels<para>"XPath Reference Formulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/XPathReferenceFormulation">http://w3id.org/rml/XPathReferenceFormulation</seealso>
    let XPathReferenceFormulation =
        Prefixed_Name(rml, "XPathReferenceFormulation") |> PrefixedName

    /// <summary>
    ///   <para>rml:allowEmptyListAndContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the behavior of a GatherMap in case rml:gather does not yield any element"</para>
    /// labels<para>"allow empty list and container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/allowEmptyListAndContainer">http://w3id.org/rml/allowEmptyListAndContainer</seealso>
    let allowEmptyListAndContainer =
        Prefixed_Name(rml, "allowEmptyListAndContainer") |> PrefixedName

    /// <summary>
    ///   <para>rml:append</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:Strategy</para>
    ///   <para>"Informs that the sets of RDF terms generated by each TermMap of the GatherMap are to be appended within the collection or container."</para>
    /// labels<para>"Append"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/append">http://w3id.org/rml/append</seealso>
    let append = Prefixed_Name(rml, "append") |> PrefixedName
    /// <summary>
    ///   <para>rml:cartessianProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rml:Strategy</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Informs that the RDF terms generated by each TermMap of the GatherMap are to be grouped (in the constructed collection or container) by doing a cartesian product of these terms."</para>
    /// labels<para>"Cartessian Product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/cartessianProduct">http://w3id.org/rml/cartessianProduct</seealso>
    let cartessianProduct = Prefixed_Name(rml, "cartessianProduct") |> PrefixedName
    /// <summary>
    ///   <para>rml:cc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/cc">http://w3id.org/rml/cc</seealso>
    let cc = Prefixed_Name(rml, "cc") |> PrefixedName
    /// <summary>
    ///   <para>rml:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Names a source record in the child source of a join."</para>
    /// labels<para>"child"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/child">http://w3id.org/rml/child</seealso>
    let child = Prefixed_Name(rml, "child") |> PrefixedName
    /// <summary>
    ///   <para>rml:childMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Names a child map in the child source of a join."</para>
    /// labels<para>"child map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/childMap">http://w3id.org/rml/childMap</seealso>
    let childMap = Prefixed_Name(rml, "childMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject value generated for a logical source record will be asserted as an instance of this RDFS class."</para>
    /// labels<para>"class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/class">http://w3id.org/rml/class</seealso>
    let class_ = Prefixed_Name(rml, "class") |> PrefixedName
    /// <summary>
    ///   <para>rml:compression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the compression format of a Source or Target."</para>
    /// labels<para>"compression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/compression">http://w3id.org/rml/compression</seealso>
    let compression = Prefixed_Name(rml, "compression") |> PrefixedName
    /// <summary>
    ///   <para>rml:constant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A property for indicating whether a expression map is a constant-valued expression map."</para>
    /// labels<para>"constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
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
    ///   <para>rml:core/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/core/">http://w3id.org/rml/core/</seealso>
    let ``core/`` = Prefixed_Name(rml, "core/") |> PrefixedName
    /// <summary>
    ///   <para>rml:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the datatype of the object component for the generated triple."</para>
    /// labels<para>"datatype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/datatype">http://w3id.org/rml/datatype</seealso>
    let datatype = Prefixed_Name(rml, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>rml:datatypeMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A DatatypetMap element to generate the datatype component of the object component from a logical source record."</para>
    /// labels<para>"datatype map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/datatypeMap">http://w3id.org/rml/datatypeMap</seealso>
    let datatypeMap = Prefixed_Name(rml, "datatypeMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the encoding format of a Source or Target."</para>
    /// labels<para>"encoding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/encoding">http://w3id.org/rml/encoding</seealso>
    let encoding = Prefixed_Name(rml, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>rml:fnml</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/fnml">http://w3id.org/rml/fnml</seealso>
    let fnml = Prefixed_Name(rml, "fnml") |> PrefixedName
    /// <summary>
    ///   <para>rml:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies a data transformation function."</para>
    /// labels<para>"function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/function">http://w3id.org/rml/function</seealso>
    let function_ = Prefixed_Name(rml, "function") |> PrefixedName
    /// <summary>
    ///   <para>rml:functionExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the execution of a function with its required input parameters and values."</para>
    /// labels<para>"function execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/functionExecution">http://w3id.org/rml/functionExecution</seealso>
    let functionExecution = Prefixed_Name(rml, "functionExecution") |> PrefixedName
    /// <summary>
    ///   <para>rml:functionMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Function Map element to generate the data transformation function."</para>
    /// labels<para>"function map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/functionMap">http://w3id.org/rml/functionMap</seealso>
    let functionMap = Prefixed_Name(rml, "functionMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:gather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies where the terms of a collection or container come from."</para>
    /// labels<para>"gather"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/gather">http://w3id.org/rml/gather</seealso>
    let gather = Prefixed_Name(rml, "gather") |> PrefixedName
    /// <summary>
    ///   <para>rml:gatherAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a GatherMap with the desired result type of collection or container."</para>
    /// labels<para>"gather as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/gatherAs">http://w3id.org/rml/gatherAs</seealso>
    let gatherAs = Prefixed_Name(rml, "gatherAs") |> PrefixedName
    /// <summary>
    ///   <para>rml:graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An IRI reference for use as the graph name of all triples generated with the SubjectMap or PredicateObjectMap."</para>
    /// labels<para>"graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/graph">http://w3id.org/rml/graph</seealso>
    let graph = Prefixed_Name(rml, "graph") |> PrefixedName
    /// <summary>
    ///   <para>rml:graphMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph."</para>
    /// labels<para>"graph map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/graphMap">http://w3id.org/rml/graphMap</seealso>
    let graphMap = Prefixed_Name(rml, "graphMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:gzip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:Compression</para>
    ///   <para>"Represents GZip file compression."</para>
    /// labels<para>"GZip"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/gzip">http://w3id.org/rml/gzip</seealso>
    let gzip = Prefixed_Name(rml, "gzip") |> PrefixedName
    /// <summary>
    ///   <para>rml:input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the Input element of a Function Map."</para>
    /// labels<para>"input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/input">http://w3id.org/rml/input</seealso>
    let input = Prefixed_Name(rml, "input") |> PrefixedName
    /// <summary>
    ///   <para>rml:inputValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the value of a parameter of a function."</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/inputValue">http://w3id.org/rml/inputValue</seealso>
    let inputValue = Prefixed_Name(rml, "inputValue") |> PrefixedName
    /// <summary>
    ///   <para>rml:inputValueMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Value map element to generate the value of a parameter of a function."</para>
    /// labels<para>"value map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/inputValueMap">http://w3id.org/rml/inputValueMap</seealso>
    let inputValueMap = Prefixed_Name(rml, "inputValueMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:io</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/io">http://w3id.org/rml/io</seealso>
    let io = Prefixed_Name(rml, "io") |> PrefixedName
    /// <summary>
    ///   <para>rml:iterator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An expression qualified according to the reference formulation specified for pointing to an extract of the source data. "</para>
    /// labels<para>"iterator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/iterator">http://w3id.org/rml/iterator</seealso>
    let iterator = Prefixed_Name(rml, "iterator") |> PrefixedName
    /// <summary>
    ///   <para>rml:joinCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the join condition for joining the child logical source with the parent logical source of the foreign key constraint."</para>
    /// labels<para>"join condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/joinCondition">http://w3id.org/rml/joinCondition</seealso>
    let joinCondition = Prefixed_Name(rml, "joinCondition") |> PrefixedName
    /// <summary>
    ///   <para>rml:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specified the language for the object component for the generated triple."</para>
    /// labels<para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/language">http://w3id.org/rml/language</seealso>
    let language = Prefixed_Name(rml, "language") |> PrefixedName
    /// <summary>
    ///   <para>rml:languageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A LanguagetMap element to generate the language tag of the object component from a logical source record."</para>
    /// labels<para>"language map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/languageMap">http://w3id.org/rml/languageMap</seealso>
    let languageMap = Prefixed_Name(rml, "languageMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:logicalSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the logical source to be mapped."</para>
    /// labels<para>"logical source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/logicalSource">http://w3id.org/rml/logicalSource</seealso>
    let logicalSource = Prefixed_Name(rml, "logicalSource") |> PrefixedName
    /// <summary>
    ///   <para>rml:logicalTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the logical target to where triples are exported to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"logical target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/logicalTarget">http://w3id.org/rml/logicalTarget</seealso>
    let logicalTarget = Prefixed_Name(rml, "logicalTarget") |> PrefixedName
    /// <summary>
    ///   <para>rml:namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A namespace for describing a XPath reference formulation."</para>
    /// labels<para>"namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/namespace">http://w3id.org/rml/namespace</seealso>
    let namespace_ = Prefixed_Name(rml, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>rml:namespacePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes the prefix of a namespace."</para>
    /// labels<para>"namespace prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/namespacePrefix">http://w3id.org/rml/namespacePrefix</seealso>
    let namespacePrefix = Prefixed_Name(rml, "namespacePrefix") |> PrefixedName
    /// <summary>
    ///   <para>rml:namespaceURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes the URL of a namespace."</para>
    /// labels<para>"namespace URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/namespaceURL">http://w3id.org/rml/namespaceURL</seealso>
    let namespaceURL = Prefixed_Name(rml, "namespaceURL") |> PrefixedName
    /// <summary>
    ///   <para>rml:none</para>
    /// </summary>
    /// <remarks>
    ///   <para>rml:Compression</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents no compression."</para>
    /// labels<para>"None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/none">http://w3id.org/rml/none</seealso>
    let none = Prefixed_Name(rml, "none") |> PrefixedName
    /// <summary>
    ///   <para>rml:null</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes which data values inside the source should be considered as NULL."</para>
    /// labels<para>"null"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/null">http://w3id.org/rml/null</seealso>
    let null_ = Prefixed_Name(rml, "null") |> PrefixedName
    /// <summary>
    ///   <para>rml:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the object for the generated triple from the logical source record."</para>
    /// labels<para>"object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/object">http://w3id.org/rml/object</seealso>
    let object = Prefixed_Name(rml, "object") |> PrefixedName
    /// <summary>
    ///   <para>rml:objectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An ObjectMap element to generate the object component of the (predicate, object) pair from a logical source record."</para>
    /// labels<para>"object map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/objectMap">http://w3id.org/rml/objectMap</seealso>
    let objectMap = Prefixed_Name(rml, "objectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the parameter of a function."</para>
    /// labels<para>"parameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/parameter">http://w3id.org/rml/parameter</seealso>
    let parameter = Prefixed_Name(rml, "parameter") |> PrefixedName
    /// <summary>
    ///   <para>rml:parameterMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Parameter Map element to generate the parameter of a function."</para>
    /// labels<para>"parameter map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/parameterMap">http://w3id.org/rml/parameterMap</seealso>
    let parameterMap = Prefixed_Name(rml, "parameterMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Names a source record in the parent source of a join."</para>
    /// labels<para>"parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/parent">http://w3id.org/rml/parent</seealso>
    let parent = Prefixed_Name(rml, "parent") |> PrefixedName
    /// <summary>
    ///   <para>rml:parentMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Names a parent map in the parent source of a join."</para>
    /// labels<para>"parent map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/parentMap">http://w3id.org/rml/parentMap</seealso>
    let parentMap = Prefixed_Name(rml, "parentMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:parentTriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the TriplesMap element corresponding to the parent logical source of the foreign key constraint."</para>
    /// labels<para>"parent triples map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/parentTriplesMap">http://w3id.org/rml/parentTriplesMap</seealso>
    let parentTriplesMap = Prefixed_Name(rml, "parentTriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the predicate for the generated triple from the logical source record."</para>
    /// labels<para>"predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/predicate">http://w3id.org/rml/predicate</seealso>
    let predicate = Prefixed_Name(rml, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>rml:predicateMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical source record."</para>
    /// labels<para>"predicate map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/predicateMap">http://w3id.org/rml/predicateMap</seealso>
    let predicateMap = Prefixed_Name(rml, "predicateMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:predicateObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A PredicateObjectMap element to generate (predicate, object) pair from a logical source record."</para>
    /// labels<para>"predicate object map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/predicateObjectMap">http://w3id.org/rml/predicateObjectMap</seealso>
    let predicateObjectMap = Prefixed_Name(rml, "predicateObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines which query should be applied on the source during access"</para>
    /// labels<para>"query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/query">http://w3id.org/rml/query</seealso>
    let query = Prefixed_Name(rml, "query") |> PrefixedName
    /// <summary>
    ///   <para>rml:quotedTriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An quoted TriplesMap element to generate a RDF-star triple as subject or object or another triple from a logical source record."</para>
    /// labels<para>"quoted triples map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/quotedTriplesMap">http://w3id.org/rml/quotedTriplesMap</seealso>
    let quotedTriplesMap = Prefixed_Name(rml, "quotedTriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A valid expression that selects values from the source data. The reference should conform to the syntax rules/grammar of the specified Reference Formulation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/reference">http://w3id.org/rml/reference</seealso>
    let reference = Prefixed_Name(rml, "reference") |> PrefixedName

    /// <summary>
    ///   <para>rml:referenceFormulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference formulation used to refer to extracts of the source data. "</para>
    /// labels<para>"reference formulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/referenceFormulation">http://w3id.org/rml/referenceFormulation</seealso>
    let referenceFormulation =
        Prefixed_Name(rml, "referenceFormulation") |> PrefixedName

    /// <summary>
    ///   <para>rml:return</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the return output of a function."</para>
    /// labels<para>"return"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/return">http://w3id.org/rml/return</seealso>
    let return_ = Prefixed_Name(rml, "return") |> PrefixedName
    /// <summary>
    ///   <para>rml:returnMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Return Map element to generate the return output of a function."</para>
    /// labels<para>"return map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/returnMap">http://w3id.org/rml/returnMap</seealso>
    let returnMap = Prefixed_Name(rml, "returnMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:serialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the serialization to generate the target output."</para>
    /// labels<para>"serialization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/serialization">http://w3id.org/rml/serialization</seealso>
    let serialization = Prefixed_Name(rml, "serialization") |> PrefixedName
    /// <summary>
    ///   <para>rml:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the source that describe the input data."</para>
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/source">http://w3id.org/rml/source</seealso>
    let source = Prefixed_Name(rml, "source") |> PrefixedName
    /// <summary>
    ///   <para>rml:star</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/rml/star">http://w3id.org/rml/star</seealso>
    let star = Prefixed_Name(rml, "star") |> PrefixedName
    /// <summary>
    ///   <para>rml:strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Strategy element to indicate how to perform an action (e.g. gather for collections and containers, join)."</para>
    /// labels<para>"strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/strategy">http://w3id.org/rml/strategy</seealso>
    let strategy = Prefixed_Name(rml, "strategy") |> PrefixedName
    /// <summary>
    ///   <para>rml:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An IRI reference for use as subject for all the RDF triples generated from a logical source record."</para>
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/subject">http://w3id.org/rml/subject</seealso>
    let subject = Prefixed_Name(rml, "subject") |> PrefixedName
    /// <summary>
    ///   <para>rml:subjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SubjectMap element to generate a subject from a logical source record."</para>
    /// labels<para>"subject map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/subjectMap">http://w3id.org/rml/subjectMap</seealso>
    let subjectMap = Prefixed_Name(rml, "subjectMap") |> PrefixedName
    /// <summary>
    ///   <para>rml:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the target that describe the output data."</para>
    /// labels<para>"target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/target">http://w3id.org/rml/target</seealso>
    let target = Prefixed_Name(rml, "target") |> PrefixedName
    /// <summary>
    ///   <para>rml:targzip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:Compression</para>
    ///   <para>"Represents TarGZip file compression."</para>
    /// labels<para>"TarGZip"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/targzip">http://w3id.org/rml/targzip</seealso>
    let targzip = Prefixed_Name(rml, "targzip") |> PrefixedName
    /// <summary>
    ///   <para>rml:tarxz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:Compression</para>
    ///   <para>"Represents TarXz file compression."</para>
    /// labels<para>"TarXz"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/tarxz">http://w3id.org/rml/tarxz</seealso>
    let tarxz = Prefixed_Name(rml, "tarxz") |> PrefixedName
    /// <summary>
    ///   <para>rml:template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A template (format string) to specify how to generate a value for a expression map, using one or more records from a logical source record."</para>
    /// labels<para>"template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/template">http://w3id.org/rml/template</seealso>
    let template = Prefixed_Name(rml, "template") |> PrefixedName
    /// <summary>
    ///   <para>rml:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A string indicating whether subject or object generated using the value from a source record name specified should be an IRI reference, blank node, or a literal."</para>
    /// labels<para>"term type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/termType">http://w3id.org/rml/termType</seealso>
    let termType = Prefixed_Name(rml, "termType") |> PrefixedName
    /// <summary>
    ///   <para>rml:zip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rml:Compression</para>
    ///   <para>"Represents Zip file compression."</para>
    /// labels<para>"Zip"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/rml/zip">http://w3id.org/rml/zip</seealso>
    let zip = Prefixed_Name(rml, "zip") |> PrefixedName
