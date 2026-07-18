namespace http.www.daml.org.services.owl_s._1._2.GroundingDeprecatedElements.owl.bare

open DoxAletheia.Rdf_Vocabulary

module owls_GroundingDeprecatedElements =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl"

    /// <summary>
    ///  Deprecated as of version 1.1; no longer needed
    ///  A list of WsdlInputMessageMap instances
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMapList"></see></summary>
    let ``_#WsdlInputMessageMapList`` =
        Namespaced_IRI.parse _namespace_name "#WsdlInputMessageMapList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMap"></see>
    /// </summary>
    let ``_#WsdlInputMessageMap`` =
        Namespaced_IRI.parse _namespace_name "#WsdlInputMessageMap" |> NamespacedName

    /// <summary>
    ///  Deprecated as of version 1.1; no longer needed
    ///  A list of WsdlOutputMessageMap instances
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMapList"></see></summary>
    let ``_#WsdlOutputMessageMapList`` =
        Namespaced_IRI.parse _namespace_name "#WsdlOutputMessageMapList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMap"></see>
    /// </summary>
    let ``_#WsdlOutputMessageMap`` =
        Namespaced_IRI.parse _namespace_name "#WsdlOutputMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     Deprecated as of OWL-S 1.0.  owlsParameter should be used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#damlsParameter"></see></summary>
    let ``_#damlsParameter`` =
        Namespaced_IRI.parse _namespace_name "#damlsParameter" |> NamespacedName

    /// <summary>
    ///
    ///     A URI indicating a relevant standards document (other than that
    ///     for WSDL).
    ///     Deprecated as of DAML-S 0.9; no longer recommended or supported.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#otherReference"></see></summary>
    let ``_#otherReference`` =
        Namespaced_IRI.parse _namespace_name "#otherReference" |> NamespacedName

    /// <summary>
    ///
    ///     Deprecated as of DAML-S 0.9.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputMessageParts"></see></summary>
    let ``_#wsdlInputMessageParts`` =
        Namespaced_IRI.parse _namespace_name "#wsdlInputMessageParts" |> NamespacedName

    /// <summary>
    ///
    ///     Deprecated as of OWL-S 1.0.  wsdlInput should be used.
    ///
    ///
    ///     A list of WsdlMessageMap instances, one for each
    ///     message part of the WSDL input message.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputs"></see></summary>
    let ``_#wsdlInputs`` =
        Namespaced_IRI.parse _namespace_name "#wsdlInputs" |> NamespacedName

    /// <summary>
    ///
    ///     Deprecated as of DAML-S 0.9; wsdlOutputs should now be used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputMessageParts"></see></summary>
    let ``_#wsdlOutputMessageParts`` =
        Namespaced_IRI.parse _namespace_name "#wsdlOutputMessageParts" |> NamespacedName

    /// <summary>
    ///
    ///     Deprecated as of OWL-S 1.0.  wsdlOutput should be used.
    ///
    ///
    ///     A list of WsdlMessageMap instances, one for each
    ///     output of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputs"></see></summary>
    let ``_#wsdlOutputs`` =
        Namespaced_IRI.parse _namespace_name "#wsdlOutputs" |> NamespacedName

    /// <summary>
    ///
    ///     Deprecated as of DAML-S 0.9; wsdlVersion should now be used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlReference"></see></summary>
    let ``_#wsdlReference`` =
        Namespaced_IRI.parse _namespace_name "#wsdlReference" |> NamespacedName
