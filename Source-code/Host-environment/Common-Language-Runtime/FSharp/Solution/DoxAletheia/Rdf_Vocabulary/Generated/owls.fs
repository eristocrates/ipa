namespace http.www.daml.org.services.owl_s._1._2.Service.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owls =
    let _namespace_iri = Namespace_Iri owls |> NamespaceIRI
    /// <summary>
    ///   <para>owls:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A service has 0 or 1 models.  (But note that a service with 0 models
    ///     does not provide automated online access; it exists only for
    ///     discovery purposes; that is, it exists so as to provide a Profile.)
    ///   </para>
    ///   <para>See comments above</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#Service">http://www.daml.org/services/owl-s/1.2/Service.owl#Service</seealso>
    let Service = Prefixed_Name(owls, "Service") |> PrefixedName
    /// <summary>
    ///   <para>owls:supportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#supportedBy">http://www.daml.org/services/owl-s/1.2/Service.owl#supportedBy</seealso>
    let supportedBy = Prefixed_Name(owls, "supportedBy") |> PrefixedName
    /// <summary>
    ///   <para>owls:ServiceModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See comments above</para>
    /// labels<para>ServiceModel</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceModel">http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceModel</seealso>
    let ServiceModel = Prefixed_Name(owls, "ServiceModel") |> PrefixedName
    /// <summary>
    ///   <para>owls:presentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     There are no cardinality restrictions on this property.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#presentedBy">http://www.daml.org/services/owl-s/1.2/Service.owl#presentedBy</seealso>
    let presentedBy = Prefixed_Name(owls, "presentedBy") |> PrefixedName
    /// <summary>
    ///   <para>owls:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#supports">http://www.daml.org/services/owl-s/1.2/Service.owl#supports</seealso>
    let supports = Prefixed_Name(owls, "supports") |> PrefixedName
    /// <summary>
    ///   <para>owls:describedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#describedBy">http://www.daml.org/services/owl-s/1.2/Service.owl#describedBy</seealso>
    let describedBy = Prefixed_Name(owls, "describedBy") |> PrefixedName
    /// <summary>
    ///   <para>owls:presents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     There are no cardinality restrictions on this property.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#presents">http://www.daml.org/services/owl-s/1.2/Service.owl#presents</seealso>
    let presents = Prefixed_Name(owls, "presents") |> PrefixedName
    /// <summary>
    ///   <para>owls:providedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#providedBy">http://www.daml.org/services/owl-s/1.2/Service.owl#providedBy</seealso>
    let providedBy = Prefixed_Name(owls, "providedBy") |> PrefixedName
    /// <summary>
    ///   <para>owls:provides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     OWL-S is completely agnostic at present about what kind of thing
    ///     provides a service (hence, no domain declared here).
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#provides">http://www.daml.org/services/owl-s/1.2/Service.owl#provides</seealso>
    let provides = Prefixed_Name(owls, "provides") |> PrefixedName
    /// <summary>
    ///   <para>owls:ServiceGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See comments above</para>
    ///   <para>
    ///     A Grounding must be associated with exactly one service.
    ///     (Also, that service must have a model - but that constraint
    ///     isn't expressed here.)
    ///   </para>
    /// labels<para>ServiceGrounding</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceGrounding">http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceGrounding</seealso>
    let ServiceGrounding = Prefixed_Name(owls, "ServiceGrounding") |> PrefixedName
    /// <summary>
    ///   <para>owls:ServiceProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See comments above</para>
    /// labels<para>ServiceProfile</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceProfile">http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceProfile</seealso>
    let ServiceProfile = Prefixed_Name(owls, "ServiceProfile") |> PrefixedName
    /// <summary>
    ///   <para>owls:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     There are no cardinality restrictions on this property. That is,
    ///     the same service model can be used by many different services.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Service.owl#describes">http://www.daml.org/services/owl-s/1.2/Service.owl#describes</seealso>
    let describes = Prefixed_Name(owls, "describes") |> PrefixedName
