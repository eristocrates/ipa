namespace http.www.daml.org.services.owl_s._1._2.Grounding.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_Grounding =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Grounding.owl#"

    /// <summary>
    ///
    ///     A class that relates elements of a OWL-S atomic process to a
    ///     WSDL specification.
    ///
    ///     Each instance of AtomicProcessGrounding must have exactly one
    ///     value for owlsProcess. Rest of the AtomicProcessGrounding depends
    ///     on the specifics of the grounding type.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#AtomicProcessGrounding"></see></summary>
    let AtomicProcessGrounding =
        Namespaced_IRI.parse _namespace_name "AtomicProcessGrounding" |> NamespacedName

    /// <summary>
    ///
    ///     The atomic process to which this grounding applies.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsProcess"></see></summary>
    let owlsProcess =
        Namespaced_IRI.parse _namespace_name "owlsProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectInputMessageMap"></see>
    /// </summary>
    let DirectInputMessageMap =
        Namespaced_IRI.parse _namespace_name "DirectInputMessageMap" |> NamespacedName

    /// <summary>
    ///
    /// 	The purpose of a WsdlInputMessageMap is to show how to derive the WSDL
    /// 	input message parts from the OWL-S Parameter values. There should be
    /// 	one WsdlInputMessageMap for each WSDL input message part.
    ///
    /// 	There are two different kinds of input message maps:
    ///
    /// 	(1) DirectInputMessageMap - This is used when we have a 1-1 mapping between
    /// 	Inputs in the AtomicProcess and WSDL message parts. There are two cases:
    ///
    /// 	(a) The parameterType of the Input is an OWL class.  The OWL class is
    /// 	used as the message part type in the WSDL document.  (Note: for this
    /// 	case to be fully general, further work may be needed to establish
    /// 	conventions for serializing arbitrary OWL instances).
    ///
    /// 	(b) The parameterType is an XSD simple type, and the WSDL message part
    /// 	has the same type.
    ///
    /// 	(2) XSLTInputMessageMap - This is used when the the parameterType and
    /// 	the WSDL message part type is not the same. The WSDL type can be
    /// 	either simple or complex.  In this case, a WSDL message part can be
    /// 	derived from multiple Inputs.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlInputMessageMap"></see></summary>
    let WsdlInputMessageMap =
        Namespaced_IRI.parse _namespace_name "WsdlInputMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     An input or output property of an atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsParameter"></see></summary>
    let owlsParameter =
        Namespaced_IRI.parse _namespace_name "owlsParameter" |> NamespacedName

    /// <summary>
    ///
    ///     XSLT Tranformation to transform OWL-S parameters (inputs and outputs)
    ///     to and from WSDL messages.  This property exists mainly for declaring
    ///     a cardinality restriction, and should not be instantiated
    ///     directly.  Instantiate xsltTransformationString or xsltTransformationURI.
    ///     (Ranges are specified with the sub properties.)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformation"></see></summary>
    let xsltTransformation =
        Namespaced_IRI.parse _namespace_name "xsltTransformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTInputMessageMap"></see>
    /// </summary>
    let XSLTInputMessageMap =
        Namespaced_IRI.parse _namespace_name "XSLTInputMessageMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectOutputMessageMap"></see>
    /// </summary>
    let DirectOutputMessageMap =
        Namespaced_IRI.parse _namespace_name "DirectOutputMessageMap" |> NamespacedName

    /// <summary>
    ///
    /// 	The purpose of WsdlOutputMessageMap is to show how to derive OWL-S
    /// 	Parameter values from the WSDL output message parts. There should be
    /// 	one WsdlOutputMessageMap for each Output of the corresponding
    /// 	AtomicProcess.
    ///
    /// 	There are two kinds of output message maps, similarly to input message maps.
    ///
    /// 	(1) DirectOutputMessageMap - This is used when we have a 1-1 mapping between
    /// 	WSDL message parts and Outputs in the Atomic Process. There are two cases:
    ///
    /// 	(a) The parameterType of the Output is an OWL class, and the OWL class
    /// 	is used as the message part type in the WSDL document.  (Note: for
    /// 	this case to be fully general, further work may be needed to establish
    /// 	conventions for serializing arbitrary OWL instances).
    ///
    /// 	(b) The parameterType is an XSD simple type, and the WSDL message part
    /// 	has the same type.
    ///
    /// 	(2) XSLTOutputMessageMap - This is used when the the parameterType and
    /// 	the WSDL message part type is not the same. The WSDL type can be
    /// 	either simple or complex.  In this case, an OWL Output can be derived
    /// 	from multiple WSDL message parts.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlOutputMessageMap"></see></summary>
    let WsdlOutputMessageMap =
        Namespaced_IRI.parse _namespace_name "WsdlOutputMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     A URI for a WSDL message part element.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlMessagePart"></see></summary>
    let wsdlMessagePart =
        Namespaced_IRI.parse _namespace_name "wsdlMessagePart" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTOutputMessageMap"></see>
    /// </summary>
    let XSLTOutputMessageMap =
        Namespaced_IRI.parse _namespace_name "XSLTOutputMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     A Grounding is just a collection of AtomicProcessGrounding
    ///     instances, one for each atomic process in the process model.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#Grounding"></see></summary>
    let Grounding = Namespaced_IRI.parse _namespace_name "Grounding" |> NamespacedName

    /// <summary>
    ///
    ///     A MessageMap that maps inputs to grounding specification
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#InputMessageMap"></see></summary>
    let InputMessageMap =
        Namespaced_IRI.parse _namespace_name "InputMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     A class used to map parameters in OWL-S to the parameters
    ///     in the grounded operation. owlsParamater property is used
    ///     to specify the OWL-S parameter.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#MessageMap"></see></summary>
    let MessageMap = Namespaced_IRI.parse _namespace_name "MessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     A MessageMap that maps outputs to grounding specification
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#OutputMessageMap"></see></summary>
    let OutputMessageMap =
        Namespaced_IRI.parse _namespace_name "OutputMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     A class that relates elements of a OWL-S atomic process to a
    ///     WSDL specification.
    ///
    ///
    ///     Each instance of WsdlAtomicProcessGrounding must have exactly one
    ///     value for owlsProcess and exactly one for wsdlOperation, which sets up
    ///     a one-to-one correspondence between an atomic process and a WSDL
    ///     operation.
    ///
    ///     In addition, for each message part of the relevant WSDL input message,
    ///     there must be exactly one value of wsdlInput.  For each output of the
    ///     atomic process, there must be exactly one value of wsdlOutput. These
    ///     property instances show the correspondences between OWL-S
    ///     inputs/outputs and WSDL message parts.  In addition, single values are
    ///     recommended (but not required) for wsdlInputMessage and
    ///     wsdlOutputMessage.
    ///
    ///     Note that the value of wsdlOperation may or may not uniquely identify
    ///     a particular WSDL port with which to interact.  If there are multiple
    ///     such ports offering the specified operation, an OWL-S enactment engine
    ///     is free to choose any of these ports.  If it is desired to further
    ///     constrain the choice of ports, a WsdlAtomicProcessGrounding may do so
    ///     by specifying any number of values for wsdlService and/or wsdlPort.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlAtomicProcessGrounding"></see></summary>
    let WsdlAtomicProcessGrounding =
        Namespaced_IRI.parse _namespace_name "WsdlAtomicProcessGrounding" |> NamespacedName

    /// <summary>
    ///
    ///     A WSDL operation to which the atomic process
    ///     (referenced by owlsProcess) corresponds.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOperation"></see></summary>
    let wsdlOperation =
        Namespaced_IRI.parse _namespace_name "wsdlOperation" |> NamespacedName

    /// <summary>
    ///
    ///     WsdlGrounding is A Grounding that grounds every process to
    ///     a WSDL operation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlGrounding"></see></summary>
    let WsdlGrounding =
        Namespaced_IRI.parse _namespace_name "WsdlGrounding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#hasAtomicProcessGrounding"></see>
    /// </summary>
    let hasAtomicProcessGrounding =
        Namespaced_IRI.parse _namespace_name "hasAtomicProcessGrounding" |> NamespacedName

    /// <summary>
    ///
    ///     MessageMap for WSDL inputs and outputs
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlMessageMap"></see></summary>
    let WsdlMessageMap =
        Namespaced_IRI.parse _namespace_name "WsdlMessageMap" |> NamespacedName

    /// <summary>
    ///
    ///     This class provides a unique specification of a WSDL operation.
    ///     WSDL 1.1, on which this version of the grounding is based, does
    ///     not have a way to uniquely identify an operation with a single URI.
    ///     Uniqueness is achieved using a pair (portType, operation).
    ///
    ///
    ///     Restricting the cardinality of portType to one
    ///
    ///
    ///     Restricting the cardinality of operation to one
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlOperationRef"></see></summary>
    let WsdlOperationRef =
        Namespaced_IRI.parse _namespace_name "WsdlOperationRef" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#portType"></see>
    /// </summary>
    let portType = Namespaced_IRI.parse _namespace_name "portType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#operation"></see>
    /// </summary>
    let operation = Namespaced_IRI.parse _namespace_name "operation" |> NamespacedName

    /// <summary>
    ///
    ///     A URI indicating a WSDL document to
    ///     which this grounding refers.  This isn't
    ///     essential; primarily for convenience as documentation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlDocument"></see></summary>
    let wsdlDocument =
        Namespaced_IRI.parse _namespace_name "wsdlDocument" |> NamespacedName

    /// <summary>
    ///
    ///     There should be one instance of this property for each
    ///     message part of the WSDL input message.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInput"></see></summary>
    let wsdlInput = Namespaced_IRI.parse _namespace_name "wsdlInput" |> NamespacedName

    /// <summary>
    ///
    ///     A URI for the WSDL input message element corresponding
    ///     to the inputs of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInputMessage"></see></summary>
    let wsdlInputMessage =
        Namespaced_IRI.parse _namespace_name "wsdlInputMessage" |> NamespacedName

    /// <summary>
    ///
    ///     There should be one instance of this property for each
    ///     output of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutput"></see></summary>
    let wsdlOutput = Namespaced_IRI.parse _namespace_name "wsdlOutput" |> NamespacedName

    /// <summary>
    ///
    ///     A URI for the WSDL message element corresponding
    ///     to the outputs of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutputMessage"></see></summary>
    let wsdlOutputMessage =
        Namespaced_IRI.parse _namespace_name "wsdlOutputMessage" |> NamespacedName

    /// <summary>
    ///
    ///     A URI for a WSDL Port that provides the operation to which
    ///     this atomic process is grounded.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlPort"></see></summary>
    let wsdlPort = Namespaced_IRI.parse _namespace_name "wsdlPort" |> NamespacedName

    /// <summary>
    ///
    ///     A URI for a WSDL Service that provides the operation to which
    ///     this atomic process is grounded.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlService"></see></summary>
    let wsdlService =
        Namespaced_IRI.parse _namespace_name "wsdlService" |> NamespacedName

    /// <summary>
    ///
    ///     A URI indicating the version of WSDL being used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlVersion"></see></summary>
    let wsdlVersion =
        Namespaced_IRI.parse _namespace_name "wsdlVersion" |> NamespacedName

    /// <summary>
    ///
    ///     A string giving an XSLT Tranformation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationString"></see></summary>
    let xsltTransformationString =
        Namespaced_IRI.parse _namespace_name "xsltTransformationString" |> NamespacedName

    /// <summary>
    ///
    ///     A URI for an XSLT Tranformation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationURI"></see></summary>
    let xsltTransformationURI =
        Namespaced_IRI.parse _namespace_name "xsltTransformationURI" |> NamespacedName
