namespace http.www.w3.org._2000._01.rdf_schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfs =
    let _namespace_iri = Namespace_Iri rdfs |> NamespaceIRI
    /// <summary>
    ///   <para>rdfs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#">http://www.w3.org/2000/01/rdf-schema#</seealso>
    let _prefix_iri = Prefixed_Name(rdfs, "") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The class resource, everything."</para>
    /// labels<para>"Class"</para><para>"Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Class">http://www.w3.org/2000/01/rdf-schema#Class</seealso>
    let Class = Prefixed_Name(rdfs, "Class") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of RDF containers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Container">http://www.w3.org/2000/01/rdf-schema#Container</seealso>
    let Container = Prefixed_Name(rdfs, "Container") |> PrefixedName

    /// <summary>
    ///   <para>rdfs:ContainerMembershipProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContainerMembershipProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty">http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty</seealso>
    let ContainerMembershipProperty =
        Prefixed_Name(rdfs, "ContainerMembershipProperty") |> PrefixedName

    /// <summary>
    ///   <para>rdfs:Datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of RDF datatypes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Datatype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Datatype">http://www.w3.org/2000/01/rdf-schema#Datatype</seealso>
    let Datatype = Prefixed_Name(rdfs, "Datatype") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:DatatypeProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#DatatypeProperty">http://www.w3.org/2000/01/rdf-schema#DatatypeProperty</seealso>
    let DatatypeProperty = Prefixed_Name(rdfs, "DatatypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Description">http://www.w3.org/2000/01/rdf-schema#Description</seealso>
    let Description = Prefixed_Name(rdfs, "Description") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Label">http://www.w3.org/2000/01/rdf-schema#Label</seealso>
    let Label = Prefixed_Name(rdfs, "Label") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The class of literal values, eg. textual strings and integers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"At the conceptual level, the rdfs:Literal datatype fully represents the RADion datatypes of
    ///     a string (an untyped literal) and text (string plus language tag). The RADion datatype of
    ///     dateTime is also served since that requires a string conformant with ISO 8601:2004 which is
    ///     true of all relevant xsd datatypes. Likewise a Literal datatyped as xsd:anyURI will fulfil
    ///     the needs of RADion's URI data type."</para>
    /// labels<para>"Literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"string, URI, dateTime, text"</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Literal">http://www.w3.org/2000/01/rdf-schema#Literal</seealso>
    let Literal = Prefixed_Name(rdfs, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Predicate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Predicate">http://www.w3.org/2000/01/rdf-schema#Predicate</seealso>
    let Predicate = Prefixed_Name(rdfs, "Predicate") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Property">http://www.w3.org/2000/01/rdf-schema#Property</seealso>
    let Property = Prefixed_Name(rdfs, "Property") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class resource, everything."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"All things described by RDF are called resources."</para>
    /// labels<para>"Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Resource"</para><para>"rdfs:Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Resource">http://www.w3.org/2000/01/rdf-schema#Resource</seealso>
    let Resource = Prefixed_Name(rdfs, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:SubClassOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#SubClassOf">http://www.w3.org/2000/01/rdf-schema#SubClassOf</seealso>
    let SubClassOf = Prefixed_Name(rdfs, "SubClassOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:XMLLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#XMLLiteral">http://www.w3.org/2000/01/rdf-schema#XMLLiteral</seealso>
    let XMLLiteral = Prefixed_Name(rdfs, "XMLLiteral") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#altLabel">http://www.w3.org/2000/01/rdf-schema#altLabel</seealso>
    let altLabel = Prefixed_Name(rdfs, "altLabel") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:alternateLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#alternateLabel">http://www.w3.org/2000/01/rdf-schema#alternateLabel</seealso>
    let alternateLabel = Prefixed_Name(rdfs, "alternateLabel") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:coment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#coment">http://www.w3.org/2000/01/rdf-schema#coment</seealso>
    let coment = Prefixed_Name(rdfs, "coment") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:commenet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#commenet">http://www.w3.org/2000/01/rdf-schema#commenet</seealso>
    let commenet = Prefixed_Name(rdfs, "commenet") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>""</para>
    ///   <para>"A description of the subject resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#comment">http://www.w3.org/2000/01/rdf-schema#comment</seealso>
    let comment = Prefixed_Name(rdfs, "comment") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:definedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#definedBy">http://www.w3.org/2000/01/rdf-schema#definedBy</seealso>
    let definedBy = Prefixed_Name(rdfs, "definedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#description">http://www.w3.org/2000/01/rdf-schema#description</seealso>
    let description = Prefixed_Name(rdfs, "description") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A domain of the subject property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#domain">http://www.w3.org/2000/01/rdf-schema#domain</seealso>
    let domain = Prefixed_Name(rdfs, "domain") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:int</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#int">http://www.w3.org/2000/01/rdf-schema#int</seealso>
    let int = Prefixed_Name(rdfs, "int") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The defininition of the subject resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isDefinedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"is defined by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy">http://www.w3.org/2000/01/rdf-schema#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(rdfs, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:isDefinedby</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#isDefinedby">http://www.w3.org/2000/01/rdf-schema#isDefinedby</seealso>
    let isDefinedby = Prefixed_Name(rdfs, "isDefinedby") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:isSubClassOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#isSubClassOf">http://www.w3.org/2000/01/rdf-schema#isSubClassOf</seealso>
    let isSubClassOf = Prefixed_Name(rdfs, "isSubClassOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:isdefinedby</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#isdefinedby">http://www.w3.org/2000/01/rdf-schema#isdefinedby</seealso>
    let isdefinedby = Prefixed_Name(rdfs, "isdefinedby") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:kabel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#kabel">http://www.w3.org/2000/01/rdf-schema#kabel</seealso>
    let kabel = Prefixed_Name(rdfs, "kabel") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The rdfs:label property fully represents the RADion properties of name and label."</para>
    ///   <para>"A human-readable name for the subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This property holds the brand name of the drug, as a label."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""</para>
    ///   <para>"A minimal interpretation of a stimulus."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label or name"</para><para>"label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#label">http://www.w3.org/2000/01/rdf-schema#label</seealso>
    let label = Prefixed_Name(rdfs, "label") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:longLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#longLabel">http://www.w3.org/2000/01/rdf-schema#longLabel</seealso>
    let longLabel = Prefixed_Name(rdfs, "longLabel") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A member of the subject resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"member"</para><para>"member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#member">http://www.w3.org/2000/01/rdf-schema#member</seealso>
    let member_ = Prefixed_Name(rdfs, "member") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:name</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#name">http://www.w3.org/2000/01/rdf-schema#name</seealso>
    let name = Prefixed_Name(rdfs, "name") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:ramge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#ramge">http://www.w3.org/2000/01/rdf-schema#ramge</seealso>
    let ramge = Prefixed_Name(rdfs, "ramge") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A range of the subject property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#range">http://www.w3.org/2000/01/rdf-schema#range</seealso>
    let range = Prefixed_Name(rdfs, "range") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:resource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#resource">http://www.w3.org/2000/01/rdf-schema#resource</seealso>
    let resource = Prefixed_Name(rdfs, "resource") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#sameAs">http://www.w3.org/2000/01/rdf-schema#sameAs</seealso>
    let sameAs = Prefixed_Name(rdfs, "sameAs") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>""</para>
    ///   <para>"Further information about the subject resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"rdfs:seeAlso is an instance of rdf:Property that is used to indicate a resource that might provide additional information about the subject resource."</para>
    ///   <para>"rdfs:seeAlso fully represents the Location Core Vocabulary concept of a geographic identifier."</para>
    ///   <para>"Indicate a resource that might provide additional information about the subject resource."</para>
    ///   <para>"This property links a drug from the Macedonian Drug Bureau with a drug from DrugBank, based on the ATC code."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"EMMO applies the naming convension to its sub-properties of rdfs:seeAlso that their label must end with one of the following terms:
    ///   - 'Match': resolvable URLs to corresponding entity in another ontology
    ///   - 'Entry': resolvable URLs to a human readable resource describing the subject
    ///   - 'Ref': non-resolvable reference to a human readable resource describing the subject"</para>
    ///   <para>"rdfs:seeAlso fully represents the ISA Programme Location Core Vocabulary concept of a geographic identifier."</para>
    /// labels<para>"geographic identifier"</para><para>"seeAlso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"see also"</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#seeAlso">http://www.w3.org/2000/01/rdf-schema#seeAlso</seealso>
    let seeAlso = Prefixed_Name(rdfs, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:shortLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#shortLabel">http://www.w3.org/2000/01/rdf-schema#shortLabel</seealso>
    let shortLabel = Prefixed_Name(rdfs, "shortLabel") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:string</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#string">http://www.w3.org/2000/01/rdf-schema#string</seealso>
    let string = Prefixed_Name(rdfs, "string") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subClass">http://www.w3.org/2000/01/rdf-schema#subClass</seealso>
    let subClass = Prefixed_Name(rdfs, "subClass") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subClassOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is a subclass of a class."</para>
    ///   <para>"The subject is a subclass of a class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subClassOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subClassOf">http://www.w3.org/2000/01/rdf-schema#subClassOf</seealso>
    let subClassOf = Prefixed_Name(rdfs, "subClassOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subClasssOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subClasssOf">http://www.w3.org/2000/01/rdf-schema#subClasssOf</seealso>
    let subClasssOf = Prefixed_Name(rdfs, "subClasssOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The subject is a subproperty of a property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subPropertyOf"</para><para>"subPropertyOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf">http://www.w3.org/2000/01/rdf-schema#subPropertyOf</seealso>
    let subPropertyOf = Prefixed_Name(rdfs, "subPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subPropertyof</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subPropertyof">http://www.w3.org/2000/01/rdf-schema#subPropertyof</seealso>
    let subPropertyof = Prefixed_Name(rdfs, "subPropertyof") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subclassOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subclassOf">http://www.w3.org/2000/01/rdf-schema#subclassOf</seealso>
    let subclassOf = Prefixed_Name(rdfs, "subclassOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#title">http://www.w3.org/2000/01/rdf-schema#title</seealso>
    let title = Prefixed_Name(rdfs, "title") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#type">http://www.w3.org/2000/01/rdf-schema#type</seealso>
    let type_ = Prefixed_Name(rdfs, "type") |> PrefixedName
