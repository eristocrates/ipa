namespace http.purl.org.ontology.service.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module service =
    let _namespace_iri = Namespace_Iri service |> NamespaceIRI
    /// <summary>
    ///   <para>service:limitedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>limitedBy</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#limitedBy">http://purl.org/ontology/service#limitedBy</seealso>
    let limitedBy = Prefixed_Name(service, "limitedBy") |> PrefixedName
    /// <summary>
    ///   <para>service:limits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>limits</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#limits">http://purl.org/ontology/service#limits</seealso>
    let limits = Prefixed_Name(service, "limits") |> PrefixedName
    /// <summary>
    ///   <para>service:queue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>queue</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#queue">http://purl.org/ontology/service#queue</seealso>
    let queue = Prefixed_Name(service, "queue") |> PrefixedName
    /// <summary>
    ///   <para>service:ServiceLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ServiceLimitation</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#ServiceLimitation">http://purl.org/ontology/service#ServiceLimitation</seealso>
    let ServiceLimitation = Prefixed_Name(service, "ServiceLimitation") |> PrefixedName
    /// <summary>
    ///   <para>service:consumedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>consumedBy</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#consumedBy">http://purl.org/ontology/service#consumedBy</seealso>
    let consumedBy = Prefixed_Name(service, "consumedBy") |> PrefixedName
    /// <summary>
    ///   <para>service:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#Service">http://purl.org/ontology/service#Service</seealso>
    let Service = Prefixed_Name(service, "Service") |> PrefixedName
    /// <summary>
    ///   <para>service:ServiceConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ServiceConsumer</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#ServiceConsumer">http://purl.org/ontology/service#ServiceConsumer</seealso>
    let ServiceConsumer = Prefixed_Name(service, "ServiceConsumer") |> PrefixedName
    /// <summary>
    ///   <para>service:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ServiceProvider</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#ServiceProvider">http://purl.org/ontology/service#ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(service, "ServiceProvider") |> PrefixedName
    /// <summary>
    ///   <para>service:consumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>consumes</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#consumes">http://purl.org/ontology/service#consumes</seealso>
    let consumes = Prefixed_Name(service, "consumes") |> PrefixedName
    /// <summary>
    ///   <para>service:delay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>delay</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#delay">http://purl.org/ontology/service#delay</seealso>
    let delay = Prefixed_Name(service, "delay") |> PrefixedName
    /// <summary>
    ///   <para>service:providedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>providedBy</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#providedBy">http://purl.org/ontology/service#providedBy</seealso>
    let providedBy = Prefixed_Name(service, "providedBy") |> PrefixedName
    /// <summary>
    ///   <para>service:provides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>provides</para></remarks>
    /// <seealso href="http://purl.org/ontology/service#provides">http://purl.org/ontology/service#provides</seealso>
    let provides = Prefixed_Name(service, "provides") |> PrefixedName
