namespace http.www.daml.org.services.owl_s._1._2.ActorDefault.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsActorDefault =
    let _namespace_iri = Namespace_Iri owlsActorDefault |> NamespaceIRI
    /// <summary>
    ///   <para>owlsActorDefault:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#email">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#email</seealso>
    let email = Prefixed_Name(owlsActorDefault, "email") |> PrefixedName

    /// <summary>
    ///   <para>owlsActorDefault:physicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#physicalAddress">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#physicalAddress</seealso>
    let physicalAddress =
        Prefixed_Name(owlsActorDefault, "physicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>owlsActorDefault:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#title">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#title</seealso>
    let title = Prefixed_Name(owlsActorDefault, "title") |> PrefixedName
    /// <summary>
    ///   <para>owlsActorDefault:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#fax">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#fax</seealso>
    let fax = Prefixed_Name(owlsActorDefault, "fax") |> PrefixedName
    /// <summary>
    ///   <para>owlsActorDefault:webURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#webURL">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#webURL</seealso>
    let webURL = Prefixed_Name(owlsActorDefault, "webURL") |> PrefixedName
    /// <summary>
    ///   <para>owlsActorDefault:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///       Actor represents a Requester or Provider who might request or offer a service.
    ///       The original Actor definition was provided within DAML-S V0.5, V0.6 and V0.7
    ///     </para>
    /// labels<para>DefaultActor</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#Actor">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#Actor</seealso>
    let Actor = Prefixed_Name(owlsActorDefault, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>owlsActorDefault:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#name">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#name</seealso>
    let name = Prefixed_Name(owlsActorDefault, "name") |> PrefixedName
    /// <summary>
    ///   <para>owlsActorDefault:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#phone">http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#phone</seealso>
    let phone = Prefixed_Name(owlsActorDefault, "phone") |> PrefixedName
