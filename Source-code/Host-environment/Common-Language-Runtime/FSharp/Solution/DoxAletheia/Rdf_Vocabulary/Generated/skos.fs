namespace http.www.w3.org._2004._02.skos.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module skos =
    let _namespace_iri = Namespace_Iri skos |> NamespaceIRI
    /// <summary>
    ///   <para>skos:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#">http://www.w3.org/2004/02/skos/core#</seealso>
    let _prefix_iri = Prefixed_Name(skos, "") |> PrefixedName
    /// <summary>
    ///   <para>skos:AltLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#AltLabel">http://www.w3.org/2004/02/skos/core#AltLabel</seealso>
    let AltLabel = Prefixed_Name(skos, "AltLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Collection"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#Collection">http://www.w3.org/2004/02/skos/core#Collection</seealso>
    let Collection = Prefixed_Name(skos, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>skos:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A SKOS concept can be viewed as an idea or notion; a unit of thought. However, what constitutes a unit of thought is subjective, and this definition is meant to be suggestive, rather than restrictive.
    ///
    /// The notion of a SKOS concept is useful when describing the conceptual or intellectual structure of a knowledge organization system, and when referring to specific ideas or meanings established within a KOS.
    ///
    /// Note that, because SKOS is designed to be a vehicle for representing semi-formal KOS, such as thesauri and classification schemes, a certain amount of flexibility has been built in to the formal definition of this class."</para>
    ///   <para>"Used to classify entities, such as the organization types"</para>
    ///   <para>"super class of ISO ThesaurusConcept
    ///
    /// The mandatory attribute identifier may be mapped to the Dublin Core property dc:identifier.
    /// Attributes or associations not detailed below typically are mapped to dc: (or dct:) properties:
    /// - dct:created
    /// - dct:modified"</para>
    ///   <para>"Utilizado para clasificar entidades, como los tipos de organizaciones"</para>
    ///   <para>"An idea or notion; a unit of thought."</para>
    ///   <para>"skos:concept is required for establishing a relationship for the object property rov:orgActivity."</para>
    ///   <para>"The class skos:Concept is the class of SKOS concepts.
    ///
    /// A SKOS concept can be viewed as an idea or notion; a unit of thought. However, what constitutes a unit of thought is subjective, and this definition is meant to be suggestive, rather than restrictive.
    ///
    /// The notion of a SKOS concept is useful when describing the conceptual or intellectual structure of a knowledge organization system, and when referring to specific ideas or meanings established within a KOS.
    ///
    /// Note that, because SKOS is designed to be a vehicle for representing semi-formal KOS, such as thesauri and classification schemes, a certain amount of flexibility has been built in to the formal definition of this class."</para>
    ///   <para>"The concept class is the generalization of specific ideas."</para>
    ///   <para>"&lt;p xmlns="http://www.w3.org/ns/radion#"&gt;The Conceptual Model includes a 'Code' datatype that
    ///       is used by several classes. This is expressed using the &lt;a href="http://www.w3.org/TR/skos-primer/"&gt;SKOS vocabulary&lt;/a&gt; with
    ///       a particular 'code' usually being a skos:Concept that is part of a scheme.
    ///       The intention is that the skos:Concept class be used as follows;&lt;/p&gt;&lt;ul&gt;
    ///       &lt;li&gt;for the content property, use skos:notation&lt;/li&gt;
    ///       &lt;li&gt;the 'list' property will be taken care of by means of the skos:inScheme property;&lt;/li&gt;
    ///       &lt;li&gt;the list agency property is likely to be applied to the scheme as a whole for which dcterms:creator is appropriate;&lt;/li&gt;
    ///       &lt;li&gt;the list version property can be fulfilled using schema:version (see &lt;a href="http://schema.org/CreativeWork"&gt;http://schema.org/CreativeWork&lt;/a&gt;)&lt;/li&gt;&lt;/ul&gt;
    ///     "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    ///   <para>"&lt;p xmlns="http://purl.org/oslo/ns/localgov#"&gt;The Conceptual Model includes a 'Code' datatype that
    ///       is used for the types of relation and membership properties. This is expressed using the &lt;a ="http://www.w3.org/TR/skos-primer/"&gt;SKOS vocabulary&lt;/a&gt; with
    ///       a particular 'code' usually being a skos:Concept that is part of a scheme.
    ///       The intention is that the skos:Concepts class be used as follows;&lt;/p&gt;&lt;skos:ul xmlns:skos="http://www.w3.org/2004/02/skos/core#"&gt;
    ///         &lt;skos:li&gt;for the content property, use skos:notation&lt;/skos:li&gt;
    ///         &lt;skos:li&gt;the 'list' property will be taken care of by means of the skos:inScheme property;&lt;/skos:li&gt;
    ///         &lt;skos:li&gt;the list agency property is likely to be applied to the scheme as a whole for which dcterms:creator is appropriate;&lt;/skos:li&gt;
    ///         &lt;skos:li&gt;the list version property can be fulfilled using schema:version (see &lt;skos:a ="http://schema.org/CreativeWork"&gt;http://schema.org/CreativeWork&lt;/skos:a&gt;)&lt;/skos:li&gt;&lt;/skos:ul&gt;
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"concept"</para><para>"Concept"</para><para>"Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Concepto"</para><para>"Code"</para><para>"concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#Concept">http://www.w3.org/2004/02/skos/core#Concept</seealso>
    let Concept = Prefixed_Name(skos, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>skos:ConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A SKOS concept scheme can be viewed as an aggregation of one or more SKOS concepts. Semantic relationships (links) between those concepts may also be viewed as part of a concept scheme. This definition is, however, meant to be suggestive rather than restrictive, and there is some flexibility in the formal data model stated below.
    ///
    /// The notion of a concept scheme is useful when dealing with data from an unknown source, and when dealing with data that describes two or more different knowledge organization systems. "</para>
    ///   <para>"SKOS concept scheme can be viewed as an aggregation of one or more SKOS concepts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A SKOS concept scheme can be viewed as an aggregation of one or more SKOS concepts. Semantic relationships (links) between those concepts may also be viewed as part of a concept scheme."</para>
    ///   <para>"All ESCO published taxonomies.
    /// - either external but having a skossified clone on the ESCO platform,
    /// - or constructed within ESCO
    /// These concept schemes have as base URI: http://data.europa.eu/esco/ConceptScheme/
    ///
    /// A skossified clone will only be maintained for external taxonomies that are not available as LOD."</para>
    ///   <para>"super class of ISO Thesaurus
    ///
    /// The mandatory attribute identifier may be mapped to the Dublin Core property dc:identifier. A typical representation of a thesaurus should document a (scoped) relationship between an identifier of this thesaurus and the URI of the RDF Concept Scheme URI.
    ///
    /// The mandatory attribute lang can be mapped to either of the Dublin Core properties dc:language or dct:language. The value space is defined by RFC 4646. For multilingual thesaurus, one lang attribute is needed per supported language.
    ///
    /// Typically these can be mapped to the corresponding Dublin Core dc: (or dct:) properties:
    /// - dc:contributor
    /// - dc:coverage
    /// - dc:creator
    /// - dct:created
    /// - dct:modified
    /// - dc:date
    /// - skos:definition
    /// - dc:format
    /// - dc:publisher
    /// - dc:relation, dct:relation or a specialization
    /// - dc:rights
    /// - dc:source
    /// - dc:subject
    /// - dc:title
    /// - dc:type
    ///
    /// The association "hasVersion" is discussed in the Version_History section of the mapping documentation (http://www.niso.org/schemas/iso25964/correspondencesSKOS/)."</para>
    /// labels<para>"Esquema de conceptos"</para><para>"Concept Scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Concept Scheme"</para><para>"concept scheme"</para><para>"Concept scheme"</para><para>"Structure de concepts"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#ConceptScheme">http://www.w3.org/2004/02/skos/core#ConceptScheme</seealso>
    let ConceptScheme = Prefixed_Name(skos, "ConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>skos:Note</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#Note">http://www.w3.org/2004/02/skos/core#Note</seealso>
    let Note = Prefixed_Name(skos, "Note") |> PrefixedName
    /// <summary>
    ///   <para>skos:OrderedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ordered Collection"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#OrderedCollection">http://www.w3.org/2004/02/skos/core#OrderedCollection</seealso>
    let OrderedCollection = Prefixed_Name(skos, "OrderedCollection") |> PrefixedName
    /// <summary>
    ///   <para>skos:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An alternative lexical label for a resource."</para>
    ///   <para>"skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties."</para>
    ///   <para>"Simple or basic super property of ISO hasNonPreferredLabel
    ///
    /// Applies if the value of "hasNonPreferredLabel" is of class SimpleNonPreferredTerm with the Boolean attribute "hidden" either absent or with value false."</para>
    ///   <para>"The range of skos:altLabel is the class of RDF plain literals."</para>
    /// labels<para>"alt label (trade name)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"alternative label"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#altLabel">http://www.w3.org/2004/02/skos/core#altLabel</seealso>
    let altLabel = Prefixed_Name(skos, "altLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:altlabel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#altlabel">http://www.w3.org/2004/02/skos/core#altlabel</seealso>
    let altlabel = Prefixed_Name(skos, "altlabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:braoder</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#braoder">http://www.w3.org/2004/02/skos/core#braoder</seealso>
    let braoder = Prefixed_Name(skos, "braoder") |> PrefixedName
    /// <summary>
    ///   <para>skos:broadMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has broader match"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broadMatch">http://www.w3.org/2004/02/skos/core#broadMatch</seealso>
    let broadMatch = Prefixed_Name(skos, "broadMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:broadMatch_</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broadMatch_">http://www.w3.org/2004/02/skos/core#broadMatch_</seealso>
    let broadMatch_ = Prefixed_Name(skos, "broadMatch_") |> PrefixedName
    /// <summary>
    ///   <para>skos:broader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Apunta a las categorías padre"</para>
    ///   <para>"Broader concepts are typically rendered as parents in a concept hierarchy (tree)."</para>
    /// labels<para>"Padre"</para><para>"broader concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has broader"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Broader"</para><para>"Más amplio"</para><para>"broader"</para><para>"has broader"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broader">http://www.w3.org/2004/02/skos/core#broader</seealso>
    let broader = Prefixed_Name(skos, "broader") |> PrefixedName
    /// <summary>
    ///   <para>skos:broaderMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/AliasPredicateEnum</para>
    ///
    /// labels<para>"BROAD_SYNONYM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broaderMatch">http://www.w3.org/2004/02/skos/core#broaderMatch</seealso>
    let broaderMatch = Prefixed_Name(skos, "broaderMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:broaderTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to derive ISO hasTopConcept (which is different from skos:hasTopConcept).
    ///
    /// The ISO hasTopConcept can be derived in SKOS from skos:broaderTransitive where the object of skos:broaderTransitive is a concept having the property skos:topConceptOf (i.e., a ThesaurusConcept having topConcept = true)."</para>
    /// labels<para>"has broader transitive"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broaderTransitive">http://www.w3.org/2004/02/skos/core#broaderTransitive</seealso>
    let broaderTransitive = Prefixed_Name(skos, "broaderTransitive") |> PrefixedName
    /// <summary>
    ///   <para>skos:changeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"change note"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#changeNote">http://www.w3.org/2004/02/skos/core#changeNote</seealso>
    let changeNote = Prefixed_Name(skos, "changeNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:closeMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"close match (SKOS)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has close match"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#closeMatch">http://www.w3.org/2004/02/skos/core#closeMatch</seealso>
    let closeMatch = Prefixed_Name(skos, "closeMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Enlace categoría"</para>
    /// labels<para>"Categoría"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#concept">http://www.w3.org/2004/02/skos/core#concept</seealso>
    let concept = Prefixed_Name(skos, "concept") |> PrefixedName
    /// <summary>
    ///   <para>skos:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"definition"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#definition">http://www.w3.org/2004/02/skos/core#definition</seealso>
    let definition = Prefixed_Name(skos, "definition") |> PrefixedName
    /// <summary>
    ///   <para>skos:editorialNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Determines a general note relative to the resource documentation process. Accepts xsd:string and rdf:langString literals. E.g., "The model was originally designed in Portuguese and translated by the publisher."@en."</para>
    /// labels<para>"editorial note"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#editorialNote">http://www.w3.org/2004/02/skos/core#editorialNote</seealso>
    let editorialNote = Prefixed_Name(skos, "editorialNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:equivalent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#equivalent">http://www.w3.org/2004/02/skos/core#equivalent</seealso>
    let equivalent = Prefixed_Name(skos, "equivalent") |> PrefixedName
    /// <summary>
    ///   <para>skos:equivalentProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#equivalentProperty">http://www.w3.org/2004/02/skos/core#equivalentProperty</seealso>
    let equivalentProperty = Prefixed_Name(skos, "equivalentProperty") |> PrefixedName
    /// <summary>
    ///   <para>skos:exactMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/AliasPredicateEnum</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch."</para>
    /// labels<para>"exact match (SKOS)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has exact match"</para><para>"EXACT_SYNONYM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#exactMatch">http://www.w3.org/2004/02/skos/core#exactMatch</seealso>
    let exactMatch = Prefixed_Name(skos, "exactMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"example"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#example">http://www.w3.org/2004/02/skos/core#example</seealso>
    let example = Prefixed_Name(skos, "example") |> PrefixedName
    /// <summary>
    ///   <para>skos:hasTopConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has top concept"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#hasTopConcept">http://www.w3.org/2004/02/skos/core#hasTopConcept</seealso>
    let hasTopConcept = Prefixed_Name(skos, "hasTopConcept") |> PrefixedName
    /// <summary>
    ///   <para>skos:hiddenLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties."</para>
    ///   <para>"The range of skos:hiddenLabel is the class of RDF plain literals."</para>
    ///   <para>"Simple or basic super property of ISO hasNonPreferredLabel
    ///
    /// Applies if the value of "hasNonPreferredLabel" is of class SimpleNonPreferredTerm with the Boolean attribute "hidden" having value true."</para>
    ///   <para>"A lexical label for a resource that should be hidden when generating visual displays of the resource, but should still be accessible to free text search operations."</para>
    /// labels<para>"hidden label"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#hiddenLabel">http://www.w3.org/2004/02/skos/core#hiddenLabel</seealso>
    let hiddenLabel = Prefixed_Name(skos, "hiddenLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:historyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A note about the past state/use/meaning of a concept."</para>
    /// labels<para>"history note"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#historyNote">http://www.w3.org/2004/02/skos/core#historyNote</seealso>
    let historyNote = Prefixed_Name(skos, "historyNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:inScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Tipo de documento"</para>
    ///   <para>"This property expresses the fact that a concept is a part of a scheme."</para>
    ///   <para>"Super property of ISO isPartOf
    ///
    /// Applies to any ISO 25964 "isPartOf" relation that targets the Thesaurus. Subjects of the skos:inScheme statements can be ISO 25964’s ThesaurusConcept, ConceptGroup, and ThesaurusArray.
    ///
    /// Only applies to ISO 25964 "contains" statements having a Thesaurus [ConceptScheme] as subject."</para>
    /// labels<para>"En esquema"</para><para>"is in scheme"</para><para>"in scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"in scheme"</para><para>"Tipo de documento"</para><para>"In scheme"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#inScheme">http://www.w3.org/2004/02/skos/core#inScheme</seealso>
    let inScheme = Prefixed_Name(skos, "inScheme") |> PrefixedName
    /// <summary>
    ///   <para>skos:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#isDefinedBy">http://www.w3.org/2004/02/skos/core#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(skos, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>skos:isNarrowerThan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#isNarrowerThan">http://www.w3.org/2004/02/skos/core#isNarrowerThan</seealso>
    let isNarrowerThan = Prefixed_Name(skos, "isNarrowerThan") |> PrefixedName
    /// <summary>
    ///   <para>skos:isReplacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#isReplacedBy">http://www.w3.org/2004/02/skos/core#isReplacedBy</seealso>
    let isReplacedBy = Prefixed_Name(skos, "isReplacedBy") |> PrefixedName
    /// <summary>
    ///   <para>skos:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#label">http://www.w3.org/2004/02/skos/core#label</seealso>
    let label = Prefixed_Name(skos, "label") |> PrefixedName
    /// <summary>
    ///   <para>skos:mappingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice."</para>
    /// labels<para>"is in mapping relation with"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#mappingRelation">http://www.w3.org/2004/02/skos/core#mappingRelation</seealso>
    let mappingRelation = Prefixed_Name(skos, "mappingRelation") |> PrefixedName
    /// <summary>
    ///   <para>skos:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Categorías raíz del tesauro"</para>
    ///   <para>"ISO
    /// - hasMemberArray
    /// - hasMemberConcept
    /// - hasAsMember
    /// Note: SKOS S39 (any concept in a List of a skos:memberList is also a value of skos:member).
    ///
    /// By definition, used to represent members of a thesaurus Array or of a thesaurus Group.
    ///
    /// An Array may have as members thesaurus Concepts or other thesaurus Arrays.
    ///
    /// Thesaurus Group members are thesaurus Concepts."</para>
    /// labels<para>"has member"</para><para>"Categorías raíz del tesauro"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#member">http://www.w3.org/2004/02/skos/core#member</seealso>
    let member_ = Prefixed_Name(skos, "member") |> PrefixedName
    /// <summary>
    ///   <para>skos:memberList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For any resource, every item in the list given as the value of the
    ///       skos:memberList property is also a value of the skos:member property."</para>
    ///   <para>"ISO
    /// - hasMemberArray&lt;ordered=true&gt;
    /// - hasMemberConcept&lt;ordered=true&gt;"</para>
    /// labels<para>"has member list"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#memberList">http://www.w3.org/2004/02/skos/core#memberList</seealso>
    let memberList = Prefixed_Name(skos, "memberList") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrowMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has narrower match"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrowMatch">http://www.w3.org/2004/02/skos/core#narrowMatch</seealso>
    let narrowMatch = Prefixed_Name(skos, "narrowMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Narrower concepts are typically rendered as children in a concept hierarchy (tree)."</para>
    /// labels<para>"has narrower"</para><para>"Narrower"</para><para>"Más concreto"</para><para>"narrower"</para><para>"narrower concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrower">http://www.w3.org/2004/02/skos/core#narrower</seealso>
    let narrower = Prefixed_Name(skos, "narrower") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrowerMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/AliasPredicateEnum</para>
    ///
    /// labels<para>"NARROW_SYNONYM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrowerMatch">http://www.w3.org/2004/02/skos/core#narrowerMatch</seealso>
    let narrowerMatch = Prefixed_Name(skos, "narrowerMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrowerTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to derive ISO isTopConceptOf (which is different from skos:isTopConceptOf).
    ///
    /// The ISO isTopConceptOf can be derived in SKOS from skos:narrowerTransitive where the skos:narrowerTransitive has as subject a concept that is object of a skos:hasTopConcept statement (i.e., a ThesaurusConcept having topConcept = true)."</para>
    /// labels<para>"has narrower transitive"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrowerTransitive">http://www.w3.org/2004/02/skos/core#narrowerTransitive</seealso>
    let narrowerTransitive = Prefixed_Name(skos, "narrowerTransitive") |> PrefixedName
    /// <summary>
    ///   <para>skos:nationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#nationality">http://www.w3.org/2004/02/skos/core#nationality</seealso>
    let nationality = Prefixed_Name(skos, "nationality") |> PrefixedName
    /// <summary>
    ///   <para>skos:notation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Used to store the values of feature codes"</para>
    ///   <para>"Best practice in SKOS is to (RDF) type the notation value object. This allows multiple notation value types for the same concept or term to be distinguished.
    ///
    /// Note: In ISO 25964-1, such typing is implicit in the thesaurus or it is part of the "notation" value."</para>
    /// labels<para>"notation (identifier value)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"notation"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#notation">http://www.w3.org/2004/02/skos/core#notation</seealso>
    let notation = Prefixed_Name(skos, "notation") |> PrefixedName
    /// <summary>
    ///   <para>skos:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"ISO refersTo is not mapped.
    ///
    /// Work is ongoing in the RDF group to type the content explicitly as HTML or XML in RDF1.1 (http://dvcs.w3.org/hg/rdf/raw-file/default/rdf-concepts/index.html#section-html). This would allow embedding relevant hyperlinks in notes.
    ///
    /// May be an embedded and tagged link in the note value (e.g., as done for EuroVoc).
    ///
    ///
    /// In ISO 25964, some types of Note are associated with concepts, others with terms. In SKOS, all documentation notes are associated with concepts.
    ///
    /// In basic SKOS, notes are represented using simple annotation properties, which type captures the note type. However the SKOS annotation properties can also be used with structured representation of notes as fully-fledged resources. See http://www.w3.org/TR/skos-primer/#secdocumentation and http://www.w3.org/TR/skos-primer/#secadvanceddocumentation for examples of both approaches.
    ///
    /// Within a thesaurus the application of notes to concept and term is more restrictive than in SKOS.
    ///
    /// A note may have some structure or formatting. In general, this can be modelled using rdf:value (to represent lexicalValue)
    ///
    /// The language should be held in rdf:value. If this is an XMLLiteral, the language shall also be made available using dc:language (or dct:language).
    ///
    /// Note: Work is ongoing in the RDF group to type the content explicitly as HTML or XML In RDF1.1 (http://dvcs.w3.org/hg/rdf/raw-file/default/rdf-concepts/index.html#section-html). This would allow embedding relevant hyperlinks in notes.
    ///
    /// Additional attributes can be added to the note structure:
    /// - dct:created
    /// - dct:modified"</para>
    /// labels<para>"note"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#note">http://www.w3.org/2004/02/skos/core#note</seealso>
    let note = Prefixed_Name(skos, "note") |> PrefixedName
    /// <summary>
    ///   <para>skos:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Simple super property of ISO hasPreferredLabel
    ///
    /// Basic SKOS allows labels (as simple literals) to be attached directly to Concepts using skos:prefLabel; this is the preferred simple scenario where label relations are not explicit."</para>
    ///   <para>"A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag."</para>
    ///   <para>"Etiqueta"</para>
    ///   <para>"skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise
    ///       disjoint properties."</para>
    ///   <para>"The range of skos:prefLabel is the class of RDF plain literals."</para>
    ///   <para>"The preferred lexical label for a resource, in a given language."</para>
    /// labels<para>"Etiqueta"</para><para>"preferred name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"preferred label"</para><para>"pref label"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#prefLabel">http://www.w3.org/2004/02/skos/core#prefLabel</seealso>
    let prefLabel = Prefixed_Name(skos, "prefLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:preflabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#preflabel">http://www.w3.org/2004/02/skos/core#preflabel</seealso>
    let preflabel = Prefixed_Name(skos, "preflabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:realted</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#realted">http://www.w3.org/2004/02/skos/core#realted</seealso>
    let realted = Prefixed_Name(skos, "realted") |> PrefixedName
    /// <summary>
    ///   <para>skos:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"skos:related is disjoint with skos:broaderTransitive"</para>
    /// labels<para>"has related"</para><para>"related concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#related">http://www.w3.org/2004/02/skos/core#related</seealso>
    let related = Prefixed_Name(skos, "related") |> PrefixedName
    /// <summary>
    ///   <para>skos:relatedMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>w3id:linkml/AliasPredicateEnum</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"RELATED_SYNONYM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has related match"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#relatedMatch">http://www.w3.org/2004/02/skos/core#relatedMatch</seealso>
    let relatedMatch = Prefixed_Name(skos, "relatedMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#replaces">http://www.w3.org/2004/02/skos/core#replaces</seealso>
    let replaces = Prefixed_Name(skos, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>skos:scopeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"scope note"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#scopeNote">http://www.w3.org/2004/02/skos/core#scopeNote</seealso>
    let scopeNote = Prefixed_Name(skos, "scopeNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:semanticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is in semantic relation with"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#semanticRelation">http://www.w3.org/2004/02/skos/core#semanticRelation</seealso>
    let semanticRelation = Prefixed_Name(skos, "semanticRelation") |> PrefixedName
    /// <summary>
    ///   <para>skos:subject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#subject">http://www.w3.org/2004/02/skos/core#subject</seealso>
    let subject = Prefixed_Name(skos, "subject") |> PrefixedName
    /// <summary>
    ///   <para>skos:topConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Top concept of"</para><para>"Concepto superior"</para><para>"is top concept in scheme"</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#topConceptOf">http://www.w3.org/2004/02/skos/core#topConceptOf</seealso>
    let topConceptOf = Prefixed_Name(skos, "topConceptOf") |> PrefixedName
    /// <summary>
    ///   <para>skos:usageNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#usageNote">http://www.w3.org/2004/02/skos/core#usageNote</seealso>
    let usageNote = Prefixed_Name(skos, "usageNote") |> PrefixedName
