namespace http.purl.org.dc.dcam.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcam =
    let _namespace_iri = Namespace_Iri dcam |> NamespaceIRI
    /// <summary>
    ///   <para>dcam:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/dcam/">http://purl.org/dc/dcam/</seealso>
    let _prefix_iri = Prefixed_Name(dcam, "") |> PrefixedName

    /// <summary>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An enumerated set of resources."</para>
    /// labels<para>"Vocabulary Encoding Scheme"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcam/VocabularyEncodingScheme">http://purl.org/dc/dcam/VocabularyEncodingScheme</seealso>
    let VocabularyEncodingScheme =
        Prefixed_Name(dcam, "VocabularyEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>dcam:domainIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/dcam/domainIncludes">http://purl.org/dc/dcam/domainIncludes</seealso>
    let domainIncludes = Prefixed_Name(dcam, "domainIncludes") |> PrefixedName
    /// <summary>
    ///   <para>dcam:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A relationship between a resource and a vocabulary encoding scheme which indicates that the resource is a member of a set."</para>
    /// labels<para>"Member Of"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcam/memberOf">http://purl.org/dc/dcam/memberOf</seealso>
    let memberOf = Prefixed_Name(dcam, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>dcam:rangeIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dc/dcam/rangeIncludes">http://purl.org/dc/dcam/rangeIncludes</seealso>
    let rangeIncludes = Prefixed_Name(dcam, "rangeIncludes") |> PrefixedName
