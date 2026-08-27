namespace http.purl.org.dc.elements._1._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dc11 =
    let _namespace_iri = Namespace_Iri dc11 |> NamespaceIRI
    /// <summary>
    ///   <para>dc11:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/">http://purl.org/dc/elements/1.1/</seealso>
    let _prefix_iri = Prefixed_Name(dc11, "") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#contributor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#contributor">http://purl.org/dc/elements/1.1/#contributor</seealso>
    let ``_#contributor`` = Prefixed_Name(dc11, "#contributor") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#creator">http://purl.org/dc/elements/1.1/#creator</seealso>
    let ``_#creator`` = Prefixed_Name(dc11, "#creator") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#description">http://purl.org/dc/elements/1.1/#description</seealso>
    let ``_#description`` = Prefixed_Name(dc11, "#description") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#license">http://purl.org/dc/elements/1.1/#license</seealso>
    let ``_#license`` = Prefixed_Name(dc11, "#license") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#publisher</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#publisher">http://purl.org/dc/elements/1.1/#publisher</seealso>
    let ``_#publisher`` = Prefixed_Name(dc11, "#publisher") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#rights">http://purl.org/dc/elements/1.1/#rights</seealso>
    let ``_#rights`` = Prefixed_Name(dc11, "#rights") |> PrefixedName
    /// <summary>
    ///   <para>dc11:#title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/#title">http://purl.org/dc/elements/1.1/#title</seealso>
    let ``_#title`` = Prefixed_Name(dc11, "#title") |> PrefixedName
    /// <summary>
    ///   <para>dc11:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A resource that acts or has the power to act."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/Agent">http://purl.org/dc/elements/1.1/Agent</seealso>
    let Agent = Prefixed_Name(dc11, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>dc11:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/abstract">http://purl.org/dc/elements/1.1/abstract</seealso>
    let abstract_ = Prefixed_Name(dc11, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>dc11:alternativeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/alternativeName">http://purl.org/dc/elements/1.1/alternativeName</seealso>
    let alternativeName = Prefixed_Name(dc11, "alternativeName") |> PrefixedName
    /// <summary>
    ///   <para>dc11:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/author">http://purl.org/dc/elements/1.1/author</seealso>
    let author = Prefixed_Name(dc11, "author") |> PrefixedName
    /// <summary>
    ///   <para>dc11:conformsTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/conformsTo">http://purl.org/dc/elements/1.1/conformsTo</seealso>
    let conformsTo = Prefixed_Name(dc11, "conformsTo") |> PrefixedName
    /// <summary>
    ///   <para>dc11:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Definition: 	An entity responsible for making contributions to the content of the resource.
    /// Comment: 	Examples of Contributor include a person, an organization, or a service. Typically, the name of a Contributor should be used to indicate the entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"check range. Olivier 2006-06-07
    /// Philipp: checked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An Agent who has participated in any phase of management of a BusinessObject or Resource."</para>
    ///   <para>"check domain. Olivier 2006-06-07
    /// Philipp: checked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An entity responsible for making contributions to the
    ///          content of the resource."</para>
    ///   <para>"An entity responsible for making contributions to the resource."</para>
    /// labels<para>"Contributor"</para><para>"beteiligter"</para><para>"Contributor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/contributor">http://purl.org/dc/elements/1.1/contributor</seealso>
    let contributor = Prefixed_Name(dc11, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>dc11:coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The extent or scope of the content of the resource."</para>
    ///   <para>"The spatial or temporal topic of the resource, spatial applicability of the resource, or jurisdiction under which the resource is relevant."</para>
    ///   <para>"A property to identify the Events and or
    ///             Locations, all real or fictional, covered by the
    ///             BusinessObject."</para>
    ///   <para>"The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant."</para>
    ///   <para>"Definition: 	The extent or scope of the content of the resource.
    /// Comment: 	Typically, Coverage will include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range) or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and to use, where appropriate, named places or time periods in preference to numeric identifiers such as sets of coordinates or date ranges."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coverage"</para><para>"abdeckungsspektrum"</para><para>"Coverage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/coverage">http://purl.org/dc/elements/1.1/coverage</seealso>
    let coverage = Prefixed_Name(dc11, "coverage") |> PrefixedName
    /// <summary>
    ///   <para>dc11:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/created">http://purl.org/dc/elements/1.1/created</seealso>
    let created = Prefixed_Name(dc11, "created") |> PrefixedName
    /// <summary>
    ///   <para>dc11:createdBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/createdBy">http://purl.org/dc/elements/1.1/createdBy</seealso>
    let createdBy = Prefixed_Name(dc11, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>dc11:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A creator of content such as a director or a producer."</para>
    ///   <para>"An entity primarily responsible for making the resource."</para>
    ///   <para>"An entity primarily responsible for making the content
    ///          of the resource."</para>
    ///   <para>"Definition: 	An entity primarily responsible for making the content of the resource (for instance an author).
    /// Comment: 	Examples of Creator include a person, an organization, or a service. Typically, the name of a Creator should be used to indicate the entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has creator"</para><para>"Creator"</para><para>"Shivam Ganguly"</para><para>"Creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"urheber"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/creator">http://purl.org/dc/elements/1.1/creator</seealso>
    let creator = Prefixed_Name(dc11, "creator") |> PrefixedName
    /// <summary>
    ///   <para>dc11:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"contains a date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A date associated with the BusinessObject, Resource or Contact/Person."</para>
    ///   <para>"Fecha"</para>
    ///   <para>"A point or period of time associated with an event in the lifecycle of the resource."</para>
    ///   <para>"Definition: 	A date of an event in the lifecycle of the resource.
    ///
    /// Comment: 	Typically, Date will be associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A date associated with an event in the life cycle of the
    ///          resource."</para>
    /// labels<para>"Date"</para><para>"has date"</para><para>"2025-06-16"</para><para>"datum"</para><para>"date"</para><para>"Fecha"</para><para>"Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/date">http://purl.org/dc/elements/1.1/date</seealso>
    let date = Prefixed_Name(dc11, "date") |> PrefixedName
    /// <summary>
    ///   <para>dc11:descripion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/descripion">http://purl.org/dc/elements/1.1/descripion</seealso>
    let descripion = Prefixed_Name(dc11, "descripion") |> PrefixedName
    /// <summary>
    ///   <para>dc11:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An account of the content of the resource."</para>
    ///   <para>"Observaciones"</para>
    ///   <para>"A description of the BusinessObject or Resource."</para>
    ///   <para>"An account of the resource."</para>
    ///   <para>"Definition: 	An account of the content of the resource.
    /// Comment: 	Examples of Description include, but is not limited to: an abstract, table of contents, reference to a graphical representation of content or a free-text account of the content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has description"</para><para>"Description"</para><para>"Observaciones"</para><para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"An ontology to model farmer-to-consumer food donation logistics."</para><para>"inhaltlicheBeschreibung"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/description">http://purl.org/dc/elements/1.1/description</seealso>
    let description = Prefixed_Name(dc11, "description") |> PrefixedName
    /// <summary>
    ///   <para>dc11:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Definition: 	The physical or digital manifestation of the resource.
    /// Comment: 	Typically, Format may include the media-type or dimensions of the resource. Format may be used to identify the software, hardware, or other equipment needed to display or operate the resource. Examples of dimensions include size and duration. Recommended best practice is to select a value from a controlled vocabulary (for example, the list of Internet Media Types [MIME] defining computer media formats)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The file format, physical medium, or dimensions of the resource."</para>
    ///   <para>"Information about the Format of a Resource."</para>
    ///   <para>"The physical or digital manifestation of the resource."</para>
    /// labels<para>"Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Format"</para><para>"MIME Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/format">http://purl.org/dc/elements/1.1/format</seealso>
    let format = Prefixed_Name(dc11, "format") |> PrefixedName
    /// <summary>
    ///   <para>dc11:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"identifier of a part in the invoice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Identificador"</para>
    ///   <para>"An identifier associated with a BusinessObject or a resource."</para>
    ///   <para>"Recommended practice is to identify the resource by means of a string conforming to an identification system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An unambiguous reference to the resource within a given context."</para>
    ///   <para>"Definition: 	An unambiguous reference to the resource within a given context.
    /// Comment: 	Recommended best practice is to identify the resource by means of a string or number conforming to a formal identification system. Formal identification systems include but are not limited to the Uniform Resource Identifier (URI) (including the Uniform Resource Locator (URL)), the Digital Object Identifier (DOI) and the International Standard Book Number (ISBN)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"identifikation"</para><para>"Resource Identifier"</para><para>"identifier"</para><para>"Identifier"</para><para>"Identificador"</para><para>"Resource Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/identifier">http://purl.org/dc/elements/1.1/identifier</seealso>
    let identifier = Prefixed_Name(dc11, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>dc11:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/isPartOf">http://purl.org/dc/elements/1.1/isPartOf</seealso>
    let isPartOf = Prefixed_Name(dc11, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>dc11:issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/issued">http://purl.org/dc/elements/1.1/issued</seealso>
    let issued = Prefixed_Name(dc11, "issued") |> PrefixedName
    /// <summary>
    ///   <para>dc11:label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/label">http://purl.org/dc/elements/1.1/label</seealso>
    let label = Prefixed_Name(dc11, "label") |> PrefixedName
    /// <summary>
    ///   <para>dc11:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Definition: 	A language of the intellectual content of the resource.
    /// Comment: 	Recommended best practice is to use RFC 3066 [RFC3066] which, in conjunction with ISO639 [ISO639]), defines two- and three-letter primary language tags with optional subtags. Examples include "en" or "eng" for English, "akk" for Akkadian", and "en-GB" for English used in the United Kingdom."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A language of the intellectual content of the resource."</para>
    ///   <para>"A Languages used in the BusinessObject or Resource."</para>
    ///   <para>"A language of the resource."</para>
    /// labels<para>"Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"sprache"</para><para>"Language"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/language">http://purl.org/dc/elements/1.1/language</seealso>
    let language = Prefixed_Name(dc11, "language") |> PrefixedName
    /// <summary>
    ///   <para>dc11:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/license">http://purl.org/dc/elements/1.1/license</seealso>
    let license = Prefixed_Name(dc11, "license") |> PrefixedName
    /// <summary>
    ///   <para>dc11:mandate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/mandate">http://purl.org/dc/elements/1.1/mandate</seealso>
    let mandate = Prefixed_Name(dc11, "mandate") |> PrefixedName
    /// <summary>
    ///   <para>dc11:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/member">http://purl.org/dc/elements/1.1/member</seealso>
    let member_ = Prefixed_Name(dc11, "member") |> PrefixedName
    /// <summary>
    ///   <para>dc11:modifed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/modifed">http://purl.org/dc/elements/1.1/modifed</seealso>
    let modifed = Prefixed_Name(dc11, "modifed") |> PrefixedName
    /// <summary>
    ///   <para>dc11:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/modified">http://purl.org/dc/elements/1.1/modified</seealso>
    let modified = Prefixed_Name(dc11, "modified") |> PrefixedName
    /// <summary>
    ///   <para>dc11:name</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/name">http://purl.org/dc/elements/1.1/name</seealso>
    let name = Prefixed_Name(dc11, "name") |> PrefixedName
    /// <summary>
    ///   <para>dc11:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An entity responsible for making the resource available"</para>
    ///   <para>"check domain. Olivier 2006-06-07
    /// Philipp: checked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An Agent involved in the distribution of content."</para>
    ///   <para>"check range. Olivier 2006-06-07
    /// Philipp: checked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Definition: 	An entity responsible for making the resource available
    /// Comment: 	Examples of Publisher include a person, an organization, or a service. Typically, the name of a Publisher should be used to indicate the entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An entity responsible for making the resource available."</para>
    /// labels<para>"Publisher"</para><para>"publisher"</para><para>"herausgeber"</para><para>"Shivam Ganguly"</para><para>"Publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/publisher">http://purl.org/dc/elements/1.1/publisher</seealso>
    let publisher = Prefixed_Name(dc11, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>dc11:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A reference to a related resource."</para>
    ///   <para>"A relation between BusinessObjects and resources."</para>
    ///   <para>"A related resource."</para>
    ///   <para>"Definition: 	A reference to a related resource.
    /// Comment: 	Recommended best practice is to identify the referenced resource by means of a string or number conforming to a formal identification system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relation"</para><para>"Relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"beziehung"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/relation">http://purl.org/dc/elements/1.1/relation</seealso>
    let relation = Prefixed_Name(dc11, "relation") |> PrefixedName
    /// <summary>
    ///   <para>dc11:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Rights information related to an Asset, aPublicationEvent, a BusinessObject or a resource."</para>
    ///   <para>"Information about rights held in and over the resource."</para>
    ///   <para>"Definition: 	Information about rights held in and over the resource.
    /// Comment: 	Typically, Rights will contain a rights management statement for the resource, or reference a service providing such information. Rights information often encompasses Intellectual Property Rights (IPR), Copyright, and various Property Rights. If the Rights element is absent, no assumptions may be made about any rights held in or over the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rights"</para><para>"rechtlicheBedingungen"</para><para>"Rights Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"https://creativecommons.org/licenses/by/4.0/"</para><para>"Rights Management"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/rights">http://purl.org/dc/elements/1.1/rights</seealso>
    let rights = Prefixed_Name(dc11, "rights") |> PrefixedName
    /// <summary>
    ///   <para>dc11:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a Resource as the source of another Resource."</para>
    ///   <para>"Definition: 	A Reference to a resource from which the present resource is derived.
    /// Comment: 	The present resource may be derived from the Source resource in whole or in part. Recommended best practice is to identify the referenced resource by means of a string or number conforming to a formal identification system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A reference to a resource from which the present resource
    ///          is derived."</para>
    ///   <para>"A related resource from which the described resource is derived."</para>
    ///   <para>"Indentificador"</para>
    /// labels<para>"Indentificador"</para><para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"quelle"</para><para>"Source"</para><para>"https://github.com/MonarchRyuzaki/FoodWastageOntology"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/source">http://purl.org/dc/elements/1.1/source</seealso>
    let source = Prefixed_Name(dc11, "source") |> PrefixedName
    /// <summary>
    ///   <para>dc11:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Subject or topic addressed by a
    ///             BusinessObject / Resource."</para>
    ///   <para>"Definition: 	A topic of the content of the resource.
    /// Comment: 	Typically, Subject will be expressed as keywords, key phrases or classification codes that describe a topic of the resource. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The topic of the resource."</para>
    ///   <para>"The topic of the content of the resource."</para>
    /// labels<para>"Subject and Keywords"</para><para>"Subject and Keywords"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"schlagwoerter"</para><para>"Subject"</para><para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/subject">http://purl.org/dc/elements/1.1/subject</seealso>
    let subject = Prefixed_Name(dc11, "subject") |> PrefixedName
    /// <summary>
    ///   <para>dc11:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Definition: 	A name given to the resource.
    /// Comment: 	Typically, Title will be a name by which the resource is formally known."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A name given to the resource."</para>
    ///   <para>"Título"</para>
    ///   <para>"swrc:booktitle removed, since it is redundant to this property here."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The title by which a BusinessObject is known."</para>
    ///   <para>"Title of the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Title"</para><para>"Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"titel"</para><para>"Título"</para><para>"has title"</para><para>"Food Wastage Ontology"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/title">http://purl.org/dc/elements/1.1/title</seealso>
    let title = Prefixed_Name(dc11, "title") |> PrefixedName
    /// <summary>
    ///   <para>dc11:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The nature or genre of the resource."</para>
    ///   <para>"Definition: 	The nature or genre of the content of the resource.
    /// Comment: 	Type includes terms describing general categories, functions, genres, or aggregation levels for content. Recommended best practice is to select a value from a controlled vocabulary (for example, the DCMI Type Vocabulary [DCT1]). To describe the physical or digital manifestation of the resource, use the FORMAT element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A concept associated with a BusinessObject or Resource."</para>
    ///   <para>"The nature or genre of the content of the resource."</para>
    /// labels<para>"Type"</para><para>"type"</para><para>"Resource Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"typ"</para><para>"Resource Type"</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/type">http://purl.org/dc/elements/1.1/type</seealso>
    let type_ = Prefixed_Name(dc11, "type") |> PrefixedName
    /// <summary>
    ///   <para>dc11:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/version">http://purl.org/dc/elements/1.1/version</seealso>
    let version = Prefixed_Name(dc11, "version") |> PrefixedName
