namespace http.www.daml.org.services.owl_s._1._2.Grounding.owl.hash

open DoxAletheia

module owls_Grounding =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Grounding.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

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
    let AtomicProcessGrounding = _prefix "AtomicProcessGrounding"
    /// <summary>
    ///
    ///     The atomic process to which this grounding applies.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsProcess"></see></summary>
    let owlsProcess = _prefix "owlsProcess"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectInputMessageMap"></see>
    /// </summary>
    let DirectInputMessageMap = _prefix "DirectInputMessageMap"
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
    let WsdlInputMessageMap = _prefix "WsdlInputMessageMap"
    /// <summary>
    ///
    ///     An input or output property of an atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsParameter"></see></summary>
    let owlsParameter = _prefix "owlsParameter"
    /// <summary>
    ///
    ///     XSLT Tranformation to transform OWL-S parameters (inputs and outputs)
    ///     to and from WSDL messages.  This property exists mainly for declaring
    ///     a cardinality restriction, and should not be instantiated
    ///     directly.  Instantiate xsltTransformationString or xsltTransformationURI.
    ///     (Ranges are specified with the sub properties.)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformation"></see></summary>
    let xsltTransformation = _prefix "xsltTransformation"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTInputMessageMap"></see>
    /// </summary>
    let XSLTInputMessageMap = _prefix "XSLTInputMessageMap"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectOutputMessageMap"></see>
    /// </summary>
    let DirectOutputMessageMap = _prefix "DirectOutputMessageMap"
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
    let WsdlOutputMessageMap = _prefix "WsdlOutputMessageMap"
    /// <summary>
    ///
    ///     A URI for a WSDL message part element.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlMessagePart"></see></summary>
    let wsdlMessagePart = _prefix "wsdlMessagePart"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTOutputMessageMap"></see>
    /// </summary>
    let XSLTOutputMessageMap = _prefix "XSLTOutputMessageMap"
    /// <summary>
    ///
    ///     A Grounding is just a collection of AtomicProcessGrounding
    ///     instances, one for each atomic process in the process model.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#Grounding"></see></summary>
    let Grounding = _prefix "Grounding"
    /// <summary>
    ///
    ///     A MessageMap that maps inputs to grounding specification
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#InputMessageMap"></see></summary>
    let InputMessageMap = _prefix "InputMessageMap"
    /// <summary>
    ///
    ///     A class used to map parameters in OWL-S to the parameters
    ///     in the grounded operation. owlsParamater property is used
    ///     to specify the OWL-S parameter.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#MessageMap"></see></summary>
    let MessageMap = _prefix "MessageMap"
    /// <summary>
    ///
    ///     A MessageMap that maps outputs to grounding specification
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#OutputMessageMap"></see></summary>
    let OutputMessageMap = _prefix "OutputMessageMap"
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
    let WsdlAtomicProcessGrounding = _prefix "WsdlAtomicProcessGrounding"
    /// <summary>
    ///
    ///     A WSDL operation to which the atomic process
    ///     (referenced by owlsProcess) corresponds.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOperation"></see></summary>
    let wsdlOperation = _prefix "wsdlOperation"
    /// <summary>
    ///
    ///     WsdlGrounding is A Grounding that grounds every process to
    ///     a WSDL operation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlGrounding"></see></summary>
    let WsdlGrounding = _prefix "WsdlGrounding"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#hasAtomicProcessGrounding"></see>
    /// </summary>
    let hasAtomicProcessGrounding = _prefix "hasAtomicProcessGrounding"
    /// <summary>
    ///
    ///     MessageMap for WSDL inputs and outputs
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlMessageMap"></see></summary>
    let WsdlMessageMap = _prefix "WsdlMessageMap"
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
    let WsdlOperationRef = _prefix "WsdlOperationRef"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#portType"></see>
    /// </summary>
    let portType = _prefix "portType"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#operation"></see>
    /// </summary>
    let operation = _prefix "operation"
    /// <summary>
    ///
    ///     A URI indicating a WSDL document to
    ///     which this grounding refers.  This isn't
    ///     essential; primarily for convenience as documentation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlDocument"></see></summary>
    let wsdlDocument = _prefix "wsdlDocument"
    /// <summary>
    ///
    ///     There should be one instance of this property for each
    ///     message part of the WSDL input message.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInput"></see></summary>
    let wsdlInput = _prefix "wsdlInput"
    /// <summary>
    ///
    ///     A URI for the WSDL input message element corresponding
    ///     to the inputs of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInputMessage"></see></summary>
    let wsdlInputMessage = _prefix "wsdlInputMessage"
    /// <summary>
    ///
    ///     There should be one instance of this property for each
    ///     output of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutput"></see></summary>
    let wsdlOutput = _prefix "wsdlOutput"
    /// <summary>
    ///
    ///     A URI for the WSDL message element corresponding
    ///     to the outputs of the atomic process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutputMessage"></see></summary>
    let wsdlOutputMessage = _prefix "wsdlOutputMessage"
    /// <summary>
    ///
    ///     A URI for a WSDL Port that provides the operation to which
    ///     this atomic process is grounded.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlPort"></see></summary>
    let wsdlPort = _prefix "wsdlPort"
    /// <summary>
    ///
    ///     A URI for a WSDL Service that provides the operation to which
    ///     this atomic process is grounded.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlService"></see></summary>
    let wsdlService = _prefix "wsdlService"
    /// <summary>
    ///
    ///     A URI indicating the version of WSDL being used.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlVersion"></see></summary>
    let wsdlVersion = _prefix "wsdlVersion"
    /// <summary>
    ///
    ///     A string giving an XSLT Tranformation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationString"></see></summary>
    let xsltTransformationString = _prefix "xsltTransformationString"
    /// <summary>
    ///
    ///     A URI for an XSLT Tranformation.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationURI"></see></summary>
    let xsltTransformationURI = _prefix "xsltTransformationURI"
