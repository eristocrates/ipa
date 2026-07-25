namespace https.w3id.org.vocab.olca.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3olca =
    let _namespace_iri = Namespace_Iri w3olca |> NamespaceIRI
    /// <summary>
    ///   <para>w3olca:rangeIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A loose coupling of a property to possible or expected values. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:range or some owl:Restriction constraint.</para>
    /// labels<para>range includes</para></remarks>
    /// <seealso href="https://w3id.org/vocab/olca#rangeIncludes">https://w3id.org/vocab/olca#rangeIncludes</seealso>
    let rangeIncludes = Prefixed_Name(w3olca, "rangeIncludes") |> PrefixedName
    /// <summary>
    ///   <para>w3olca:similarProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A loose similary of properties, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentProperty. </para>
    /// labels<para>similar property</para></remarks>
    /// <seealso href="https://w3id.org/vocab/olca#similarProperty">https://w3id.org/vocab/olca#similarProperty</seealso>
    let similarProperty = Prefixed_Name(w3olca, "similarProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3olca:domainIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A loose coupling of a property to possible or expected class it can describe. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:domain or some owl:Restriction constraint. </para>
    /// labels<para>domain includes</para></remarks>
    /// <seealso href="https://w3id.org/vocab/olca#domainIncludes">https://w3id.org/vocab/olca#domainIncludes</seealso>
    let domainIncludes = Prefixed_Name(w3olca, "domainIncludes") |> PrefixedName
    /// <summary>
    ///   <para>w3olca:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/olca#">https://w3id.org/vocab/olca#</seealso>
    let _prefix_iri = Prefixed_Name(w3olca, "") |> PrefixedName
    /// <summary>
    ///   <para>w3olca:expectedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A loose coupling of a class to possible or expected properties. This annotation is to be used when one does not want to enforce formally the coupling using rdfs:range or some owl:Restriction.</para>
    /// labels<para>expected property</para></remarks>
    /// <seealso href="https://w3id.org/vocab/olca#expectedProperty">https://w3id.org/vocab/olca#expectedProperty</seealso>
    let expectedProperty = Prefixed_Name(w3olca, "expectedProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3olca:similarClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A loose similarity of classes, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentClass. </para>
    /// labels<para>similar class</para></remarks>
    /// <seealso href="https://w3id.org/vocab/olca#similarClass">https://w3id.org/vocab/olca#similarClass</seealso>
    let similarClass = Prefixed_Name(w3olca, "similarClass") |> PrefixedName
