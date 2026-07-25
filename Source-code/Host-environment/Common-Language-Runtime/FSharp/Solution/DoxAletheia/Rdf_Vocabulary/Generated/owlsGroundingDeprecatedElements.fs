namespace http.www.daml.org.services.owl_s._1._2.GroundingDeprecatedElements.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsGroundingDeprecatedElements =
    let _namespace_iri = Namespace_Iri owlsGroundingDeprecatedElements |> NamespaceIRI

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#damlsParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     Deprecated as of OWL-S 1.0.  owlsParameter should be used.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#damlsParameter">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#damlsParameter</seealso>
    let ``_#damlsParameter`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#damlsParameter") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#wsdlInputMessageParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    ///     Deprecated as of DAML-S 0.9.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputMessageParts">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputMessageParts</seealso>
    let ``_#wsdlInputMessageParts`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#wsdlInputMessageParts") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#WsdlOutputMessageMap</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMap">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMap</seealso>
    let ``_#WsdlOutputMessageMap`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#WsdlOutputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#WsdlOutputMessageMapList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> A list of WsdlOutputMessageMap instances </para>
    ///   <para> Deprecated as of version 1.1; no longer needed </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMapList">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMapList</seealso>
    let ``_#WsdlOutputMessageMapList`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#WsdlOutputMessageMapList") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#otherReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI indicating a relevant standards document (other than that
    ///     for WSDL).
    ///     Deprecated as of DAML-S 0.9; no longer recommended or supported.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#otherReference">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#otherReference</seealso>
    let ``_#otherReference`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#otherReference") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#wsdlInputs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    ///     A list of WsdlMessageMap instances, one for each
    ///     message part of the WSDL input message.
    ///   </para>
    ///   <para>
    ///     Deprecated as of OWL-S 1.0.  wsdlInput should be used.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputs">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputs</seealso>
    let ``_#wsdlInputs`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#wsdlInputs") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#wsdlOutputs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     Deprecated as of OWL-S 1.0.  wsdlOutput should be used.
    ///   </para>
    ///   <para>
    ///     A list of WsdlMessageMap instances, one for each
    ///     output of the atomic process.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputs">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputs</seealso>
    let ``_#wsdlOutputs`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#wsdlOutputs") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#wsdlOutputMessageParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    ///     Deprecated as of DAML-S 0.9; wsdlOutputs should now be used.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputMessageParts">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputMessageParts</seealso>
    let ``_#wsdlOutputMessageParts`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#wsdlOutputMessageParts") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#wsdlReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     Deprecated as of DAML-S 0.9; wsdlVersion should now be used.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlReference">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlReference</seealso>
    let ``_#wsdlReference`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#wsdlReference") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>
    ///     Upper-level OWL ontology for Groundings that employ WSDL.
    ///     Part of the OWL-S ontology; see http://www.daml.org/services/.
    ///
    ///     This version is intended for use with WSDL 1.1.  The OWL-S
    ///     Coalition plans to produce a future version for use with WSDL 2.0,
    ///     when it has been finalized (or nearly so).
    ///
    ///     Note that other approaches to grounding may be accommodated
    ///     within the OWL-S framework.  This is the only approach produced
    ///     to date by the OWL-S Coalition.
    ///
    ///     For notes on version history, see
    ///         http://www.daml.org/services/owl-s/1.2/status.html.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl</seealso>
    let _prefix_iri = Prefixed_Name(owlsGroundingDeprecatedElements, "") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#WsdlInputMessageMapList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> A list of WsdlInputMessageMap instances </para>
    ///   <para> Deprecated as of version 1.1; no longer needed </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMapList">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMapList</seealso>
    let ``_#WsdlInputMessageMapList`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#WsdlInputMessageMapList") |> PrefixedName

    /// <summary>
    ///   <para>owlsGroundingDeprecatedElements:#WsdlInputMessageMap</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMap">http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMap</seealso>
    let ``_#WsdlInputMessageMap`` =
        Prefixed_Name(owlsGroundingDeprecatedElements, "#WsdlInputMessageMap") |> PrefixedName
