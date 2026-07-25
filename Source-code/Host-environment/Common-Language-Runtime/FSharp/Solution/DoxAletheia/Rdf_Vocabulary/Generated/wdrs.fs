namespace http.www.w3.org._2007._05.powder_s.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wdrs =
    let _namespace_iri = Namespace_Iri wdrs |> NamespaceIRI
    /// <summary>
    ///   <para>wdrs:Processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A software agent able to process POWDER documents.</para>
    /// labels<para>POWDER processor</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#Processor">http://www.w3.org/2007/05/powder-s#Processor</seealso>
    let Processor = Prefixed_Name(wdrs, "Processor") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:data_error</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property denoting a description of the specific error found in a given POWDER document.</para>
    /// labels<para>data error</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#data_error">http://www.w3.org/2007/05/powder-s#data_error</seealso>
    let data_error = Prefixed_Name(wdrs, "data_error") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:error_code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property denoting the code of any error encountered by the POWDER processor.</para>
    /// labels<para>error code</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#error_code">http://www.w3.org/2007/05/powder-s#error_code</seealso>
    let error_code = Prefixed_Name(wdrs, "error_code") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Points to a graphic summary for the resources in a given class. Typically, it is a logo denoting conformance of a given (set of) resource(s) to a given set of criteria.</para>
    /// labels<para>logo</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#logo">http://www.w3.org/2007/05/powder-s#logo</seealso>
    let logo = Prefixed_Name(wdrs, "logo") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:certifiedby</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A property that links a resource to a POWDER document that certifies it.</para>
    /// labels<para>certified by</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#certifiedby">http://www.w3.org/2007/05/powder-s#certifiedby</seealso>
    let certifiedby = Prefixed_Name(wdrs, "certifiedby") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:describedby</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An RDF property to exactly match the describedby relationship type introduced in http://www.w3.org/TR/powder-dr/#assoc-linking and formally defined in appendix D of the same document, i.e. the relationship A 'describedby' B asserts that resource B provides a description of resource A. There are no constraints on the format or representation of either A or B, neither are there any further constraints on either resource.</para>
    /// labels<para>described by</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#describedby">http://www.w3.org/2007/05/powder-s#describedby</seealso>
    let describedby = Prefixed_Name(wdrs, "describedby") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:hasIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property is meant to be used in OWL2 instead of wdrs:matchesregex. It denotes the string data range corresponding to a set of IRIs.</para>
    /// labels<para>has IRI</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#hasIRI">http://www.w3.org/2007/05/powder-s#hasIRI</seealso>
    let hasIRI = Prefixed_Name(wdrs, "hasIRI") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:matchesregex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This is the key 'include' property for IRI set definitions in POWDER-S. It is necessary to take account of the POWDER Semantic Extension to process this fully. The value is a regular expression that is matched against an IRI.</para>
    /// labels<para>matches regular expression</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#matchesregex">http://www.w3.org/2007/05/powder-s#matchesregex</seealso>
    let matchesregex = Prefixed_Name(wdrs, "matchesregex") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:authenticate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to a document that describes how Description Resources created by a FOAF Agent or a DC Terms Agent may be authenticated</para>
    /// labels<para>authenticate</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#authenticate">http://www.w3.org/2007/05/powder-s#authenticate</seealso>
    let authenticate = Prefixed_Name(wdrs, "authenticate") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property provides a summary of the descriptorset that it annotates, suitable for display to end users.</para>
    /// labels<para>text that may be displayed</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#text">http://www.w3.org/2007/05/powder-s#text</seealso>
    let text = Prefixed_Name(wdrs, "text") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:issuedby</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>This property denotes the author of a POWDER document.</para>
    /// labels<para>issued by</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#issuedby">http://www.w3.org/2007/05/powder-s#issuedby</seealso>
    let issuedby = Prefixed_Name(wdrs, "issuedby") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:notmatchesregex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This is the key 'exclude' property for IRI set definitions in POWDER-S. It is necessary to take account of the POWDER Semantic Extension to process this fully. The value is a regular expression that is matched against an IRI.</para>
    /// labels<para>matches regular expression</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#notmatchesregex">http://www.w3.org/2007/05/powder-s#notmatchesregex</seealso>
    let notmatchesregex = Prefixed_Name(wdrs, "notmatchesregex") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:supportedby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A property that links a POWDER document to some other data source that supports the descriptions provided.</para>
    /// labels<para>supported by</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#supportedby">http://www.w3.org/2007/05/powder-s#supportedby</seealso>
    let supportedby = Prefixed_Name(wdrs, "supportedby") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:notknownto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property used in results returned from a POWDER Processor that has no data about the candidate resource. The value is the IRI of the processor.</para>
    /// labels<para>not known to</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#notknownto">http://www.w3.org/2007/05/powder-s#notknownto</seealso>
    let notknownto = Prefixed_Name(wdrs, "notknownto") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:proc_error</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property denoting a description of the specific software error.</para>
    /// labels<para>processing error</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#proc_error">http://www.w3.org/2007/05/powder-s#proc_error</seealso>
    let proc_error = Prefixed_Name(wdrs, "proc_error") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:sha1sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links to a Base64-encoded binary SHA-1 hash of the described resource. May be used by POWDER Processors when assessing trustworthiness of a DR.</para>
    /// labels<para>SHA-1 sum</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#sha1sum">http://www.w3.org/2007/05/powder-s#sha1sum</seealso>
    let sha1sum = Prefixed_Name(wdrs, "sha1sum") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Property linking to a free-text tag which may include spaces.</para>
    /// labels<para>tag</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#tag">http://www.w3.org/2007/05/powder-s#tag</seealso>
    let tag = Prefixed_Name(wdrs, "tag") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:validuntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Provides a timestamp that a POWDER Processor may use when assessing trustworthiness of a POWDER document. Informally, a POWDER Processor should normally ignore data in the document after the given date.</para>
    /// labels<para>valid until</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#validuntil">http://www.w3.org/2007/05/powder-s#validuntil</seealso>
    let validuntil = Prefixed_Name(wdrs, "validuntil") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:validfrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Provides a timestamp that a POWDER Processor may use when assessing trustworthiness of a POWDER document. Informally, a POWDER Processor should normally ignore data in the document before the given date.</para>
    /// labels<para>valid from</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#validfrom">http://www.w3.org/2007/05/powder-s#validfrom</seealso>
    let validfrom = Prefixed_Name(wdrs, "validfrom") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A POWDER document.</para>
    /// labels<para>POWDER document</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#Document">http://www.w3.org/2007/05/powder-s#Document</seealso>
    let Document = Prefixed_Name(wdrs, "Document") |> PrefixedName
    /// <summary>
    ///   <para>wdrs:certified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property that takes a Boolean value to declare whether the author of the data certifies the described resource.</para>
    /// labels<para>certified</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder-s#certified">http://www.w3.org/2007/05/powder-s#certified</seealso>
    let certified = Prefixed_Name(wdrs, "certified") |> PrefixedName
