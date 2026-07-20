namespace http.www.daml.org.services.owl_s._1._2.GroundingDeprecatedElements.owl.bare

open DoxAletheia

module owls_GroundingDeprecatedElements =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///  Deprecated as of version 1.1; no longer needed
    ///  A list of WsdlInputMessageMap instances
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMapList"></see></summary>
    let ``_#WsdlInputMessageMapList`` = _prefix "#WsdlInputMessageMapList"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlInputMessageMap"></see>
    /// </summary>
    let ``_#WsdlInputMessageMap`` = _prefix "#WsdlInputMessageMap"
    /// <summary>
    ///  Deprecated as of version 1.1; no longer needed
    ///  A list of WsdlOutputMessageMap instances
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMapList"></see></summary>
    let ``_#WsdlOutputMessageMapList`` = _prefix "#WsdlOutputMessageMapList"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#WsdlOutputMessageMap"></see>
    /// </summary>
    let ``_#WsdlOutputMessageMap`` = _prefix "#WsdlOutputMessageMap"
    /// <summary>
    ///
    ///     Deprecated as of OWL-S 1.0.  owlsParameter should be used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#damlsParameter"></see></summary>
    let ``_#damlsParameter`` = _prefix "#damlsParameter"
    /// <summary>
    ///
    ///     A URI indicating a relevant standards document (other than that
    ///     for WSDL).
    ///     Deprecated as of DAML-S 0.9; no longer recommended or supported.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#otherReference"></see></summary>
    let ``_#otherReference`` = _prefix "#otherReference"
    /// <summary>
    ///
    ///     Deprecated as of DAML-S 0.9.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputMessageParts"></see></summary>
    let ``_#wsdlInputMessageParts`` = _prefix "#wsdlInputMessageParts"
    /// <summary>
    ///
    ///     Deprecated as of OWL-S 1.0.  wsdlInput should be used.
    ///
    ///
    ///     A list of WsdlMessageMap instances, one for each
    ///     message part of the WSDL input message.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlInputs"></see></summary>
    let ``_#wsdlInputs`` = _prefix "#wsdlInputs"
    /// <summary>
    ///
    ///     Deprecated as of DAML-S 0.9; wsdlOutputs should now be used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputMessageParts"></see></summary>
    let ``_#wsdlOutputMessageParts`` = _prefix "#wsdlOutputMessageParts"
    /// <summary>
    ///
    ///     Deprecated as of OWL-S 1.0.  wsdlOutput should be used.
    ///
    ///
    ///     A list of WsdlMessageMap instances, one for each
    ///     output of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlOutputs"></see></summary>
    let ``_#wsdlOutputs`` = _prefix "#wsdlOutputs"
    /// <summary>
    ///
    ///     Deprecated as of DAML-S 0.9; wsdlVersion should now be used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl#wsdlReference"></see></summary>
    let ``_#wsdlReference`` = _prefix "#wsdlReference"
