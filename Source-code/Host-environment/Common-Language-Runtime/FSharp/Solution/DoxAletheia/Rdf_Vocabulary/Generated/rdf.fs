namespace http.www.w3.org._1999._02._22_rdf_syntax_ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdf =
    let _namespace_iri = Namespace_Iri rdf |> NamespaceIRI
    /// <summary>
    ///   <para>rdf:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an instance of a class.</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type">http://www.w3.org/1999/02/22-rdf-syntax-ns#type</seealso>
    let type_ = Prefixed_Name(rdf, "type") |> PrefixedName
    /// <summary>
    ///   <para>rdf:JSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The datatype of RDF literals storing JSON content.</para>
    /// labels<para>JSON</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON">http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON</seealso>
    let JSON = Prefixed_Name(rdf, "JSON") |> PrefixedName
    /// <summary>
    ///   <para>rdf:PlainLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2</para>
    /// labels<para>PlainLiteral</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral">http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral</seealso>
    let PlainLiteral = Prefixed_Name(rdf, "PlainLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of RDF properties.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property">http://www.w3.org/1999/02/22-rdf-syntax-ns#Property</seealso>
    let Property = Prefixed_Name(rdf, "Property") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of RDF statements.</para>
    /// labels<para>Statement</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement">http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement</seealso>
    let Statement = Prefixed_Name(rdf, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>rdf:XMLLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The datatype of XML literal values.</para>
    /// labels<para>XMLLiteral</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral">http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral</seealso>
    let XMLLiteral = Prefixed_Name(rdf, "XMLLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdf:CompoundLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A class representing a compound literal.</para>
    /// labels<para>CompoundLiteral</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral">http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral</seealso>
    let CompoundLiteral = Prefixed_Name(rdf, "CompoundLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdf:HTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The datatype of RDF literals storing fragments of HTML content</para>
    /// labels<para>HTML</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML">http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML</seealso>
    let HTML = Prefixed_Name(rdf, "HTML") |> PrefixedName
    /// <summary>
    ///   <para>rdf:direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The base direction component of a CompoundLiteral.</para>
    /// labels<para>direction</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction">http://www.w3.org/1999/02/22-rdf-syntax-ns#direction</seealso>
    let direction = Prefixed_Name(rdf, "direction") |> PrefixedName
    /// <summary>
    ///   <para>rdf:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The first item in the subject RDF list.</para>
    /// labels<para>first</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first">http://www.w3.org/1999/02/22-rdf-syntax-ns#first</seealso>
    let first = Prefixed_Name(rdf, "first") |> PrefixedName
    /// <summary>
    ///   <para>rdf:langString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The datatype of language-tagged string values</para>
    /// labels<para>langString</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString">http://www.w3.org/1999/02/22-rdf-syntax-ns#langString</seealso>
    let langString = Prefixed_Name(rdf, "langString") |> PrefixedName
    /// <summary>
    ///   <para>rdf:nil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    ///   <para>The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.</para>
    /// labels<para>nil</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil">http://www.w3.org/1999/02/22-rdf-syntax-ns#nil</seealso>
    let nil = Prefixed_Name(rdf, "nil") |> PrefixedName
    /// <summary>
    ///   <para>rdf:rest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The rest of the subject RDF list after the first item.</para>
    /// labels<para>rest</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest">http://www.w3.org/1999/02/22-rdf-syntax-ns#rest</seealso>
    let rest = Prefixed_Name(rdf, "rest") |> PrefixedName
    /// <summary>
    ///   <para>rdf:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Idiomatic property used for structured values.</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value">http://www.w3.org/1999/02/22-rdf-syntax-ns#value</seealso>
    let value = Prefixed_Name(rdf, "value") |> PrefixedName
    /// <summary>
    ///   <para>rdf:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The language component of a CompoundLiteral.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language">http://www.w3.org/1999/02/22-rdf-syntax-ns#language</seealso>
    let language = Prefixed_Name(rdf, "language") |> PrefixedName
    /// <summary>
    ///   <para>rdf:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the subject RDF statement.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object">http://www.w3.org/1999/02/22-rdf-syntax-ns#object</seealso>
    let object = Prefixed_Name(rdf, "object") |> PrefixedName
    /// <summary>
    ///   <para>rdf:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The predicate of the subject RDF statement.</para>
    /// labels<para>predicate</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate">http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate</seealso>
    let predicate = Prefixed_Name(rdf, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>rdf:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject of the subject RDF statement.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject">http://www.w3.org/1999/02/22-rdf-syntax-ns#subject</seealso>
    let subject = Prefixed_Name(rdf, "subject") |> PrefixedName
    /// <summary>
    ///   <para>rdf:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#">http://www.w3.org/1999/02/22-rdf-syntax-ns#</seealso>
    let _prefix_iri = Prefixed_Name(rdf, "") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Alt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of containers of alternatives.</para>
    /// labels<para>Alt</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt">http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt</seealso>
    let Alt = Prefixed_Name(rdf, "Alt") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Bag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of unordered containers.</para>
    /// labels<para>Bag</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag">http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag</seealso>
    let Bag = Prefixed_Name(rdf, "Bag") |> PrefixedName
    /// <summary>
    ///   <para>rdf:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of RDF Lists.</para>
    /// labels<para>List</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List">http://www.w3.org/1999/02/22-rdf-syntax-ns#List</seealso>
    let List = Prefixed_Name(rdf, "List") |> PrefixedName
    /// <summary>
    ///   <para>rdf:Seq</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of ordered containers.</para>
    /// labels<para>Seq</para></remarks>
    /// <seealso href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq">http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq</seealso>
    let Seq = Prefixed_Name(rdf, "Seq") |> PrefixedName
