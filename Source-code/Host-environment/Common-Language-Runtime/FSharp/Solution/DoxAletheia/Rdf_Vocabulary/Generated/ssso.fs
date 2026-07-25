namespace http.purl.org.ontology.ssso.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ssso =
    let _namespace_iri = Namespace_Iri ssso |> NamespaceIRI
    /// <summary>
    ///   <para>ssso:ReservedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ReservedService</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#ReservedService">http://purl.org/ontology/ssso#ReservedService</seealso>
    let ReservedService = Prefixed_Name(ssso, "ReservedService") |> PrefixedName
    /// <summary>
    ///   <para>ssso:RejectedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>RejectedService</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#RejectedService">http://purl.org/ontology/ssso#RejectedService</seealso>
    let RejectedService = Prefixed_Name(ssso, "RejectedService") |> PrefixedName
    /// <summary>
    ///   <para>ssso:ServiceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ServiceEvent</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#ServiceEvent">http://purl.org/ontology/ssso#ServiceEvent</seealso>
    let ServiceEvent = Prefixed_Name(ssso, "ServiceEvent") |> PrefixedName
    /// <summary>
    ///   <para>ssso:nextService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>nextService</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#nextService">http://purl.org/ontology/ssso#nextService</seealso>
    let nextService = Prefixed_Name(ssso, "nextService") |> PrefixedName
    /// <summary>
    ///   <para>ssso:ServiceFulfillment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ServiceFulfillment</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#ServiceFulfillment">http://purl.org/ontology/ssso#ServiceFulfillment</seealso>
    let ServiceFulfillment = Prefixed_Name(ssso, "ServiceFulfillment") |> PrefixedName
    /// <summary>
    ///   <para>ssso:previousService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>previousService</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#previousService">http://purl.org/ontology/ssso#previousService</seealso>
    let previousService = Prefixed_Name(ssso, "previousService") |> PrefixedName
    /// <summary>
    ///   <para>ssso:TimeTravel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TimeTravel</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#TimeTravel">http://purl.org/ontology/ssso#TimeTravel</seealso>
    let TimeTravel = Prefixed_Name(ssso, "TimeTravel") |> PrefixedName
    /// <summary>
    ///   <para>ssso:ExecutedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ExecutedService</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#ExecutedService">http://purl.org/ontology/ssso#ExecutedService</seealso>
    let ExecutedService = Prefixed_Name(ssso, "ExecutedService") |> PrefixedName
    /// <summary>
    ///   <para>ssso:ProvidedService</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#ProvidedService">http://purl.org/ontology/ssso#ProvidedService</seealso>
    let ProvidedService = Prefixed_Name(ssso, "ProvidedService") |> PrefixedName
    /// <summary>
    ///   <para>ssso:PreparedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ReservedService</para></remarks>
    /// <seealso href="http://purl.org/ontology/ssso#PreparedService">http://purl.org/ontology/ssso#PreparedService</seealso>
    let PreparedService = Prefixed_Name(ssso, "PreparedService") |> PrefixedName
