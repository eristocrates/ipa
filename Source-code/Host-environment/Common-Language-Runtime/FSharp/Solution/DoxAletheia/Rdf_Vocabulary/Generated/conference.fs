namespace https.w3id.org.scholarlydata.ontology.conference_ontology.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module conference =
    let _namespace_iri = Namespace_Iri conference |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#AcademicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#AcademicEvent">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#AcademicEvent</seealso>
    let AcademicEvent = Prefixed_Name(conference, "AcademicEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#Agent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Agent">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Agent</seealso>
    let Agent = Prefixed_Name(conference, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#EventSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#EventSeries">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#EventSeries</seealso>
    let EventSeries = Prefixed_Name(conference, "EventSeries") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#NonAcademicEvent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#NonAcademicEvent">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#NonAcademicEvent</seealso>
    let NonAcademicEvent = Prefixed_Name(conference, "NonAcademicEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#OrganisedEvent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#OrganisedEvent">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#OrganisedEvent</seealso>
    let OrganisedEvent = Prefixed_Name(conference, "OrganisedEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Person">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Person</seealso>
    let Person = Prefixed_Name(conference, "Person") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Proceedings">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Proceedings</seealso>
    let Proceedings = Prefixed_Name(conference, "Proceedings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#SocialEvent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#SocialEvent">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#SocialEvent</seealso>
    let SocialEvent = Prefixed_Name(conference, "SocialEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#Track</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Track">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#Track</seealso>
    let Track = Prefixed_Name(conference, "Track") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#endDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#endDate">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#endDate</seealso>
    let endDate = Prefixed_Name(conference, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#hasAddress</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#hasAddress">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#hasAddress</seealso>
    let hasAddress = Prefixed_Name(conference, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#hasLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#hasLocation">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#hasLocation</seealso>
    let hasLocation = Prefixed_Name(conference, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#hasProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#hasProceedings">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#hasProceedings</seealso>
    let hasProceedings = Prefixed_Name(conference, "hasProceedings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#holdsRoleIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#holdsRoleIn">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#holdsRoleIn</seealso>
    let holdsRoleIn = Prefixed_Name(conference, "holdsRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl#startDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl#startDate">https://w3id.org/scholarlydata/ontology/conference-ontology.owl#startDate</seealso>
    let startDate = Prefixed_Name(conference, "startDate") |> PrefixedName
