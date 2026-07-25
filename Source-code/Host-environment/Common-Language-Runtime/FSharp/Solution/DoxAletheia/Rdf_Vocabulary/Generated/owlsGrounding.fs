namespace http.www.daml.org.services.owl_s._1._2.Grounding.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsGrounding =
    let _namespace_iri = Namespace_Iri owlsGrounding |> NamespaceIRI

    /// <summary>
    ///   <para>owlsGrounding:DirectInputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectInputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectInputMessageMap</seealso>
    let DirectInputMessageMap =
        Prefixed_Name(owlsGrounding, "DirectInputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:xsltTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     XSLT Tranformation to transform OWL-S parameters (inputs and outputs)
    ///     to and from WSDL messages.  This property exists mainly for declaring
    ///     a cardinality restriction, and should not be instantiated
    ///     directly.  Instantiate xsltTransformationString or xsltTransformationURI.
    ///     (Ranges are specified with the sub properties.)
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformation">http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformation</seealso>
    let xsltTransformation =
        Prefixed_Name(owlsGrounding, "xsltTransformation") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:WsdlOutputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
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
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlOutputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlOutputMessageMap</seealso>
    let WsdlOutputMessageMap =
        Prefixed_Name(owlsGrounding, "WsdlOutputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:Grounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A Grounding is just a collection of AtomicProcessGrounding
    ///     instances, one for each atomic process in the process model.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#Grounding">http://www.daml.org/services/owl-s/1.2/Grounding.owl#Grounding</seealso>
    let Grounding = Prefixed_Name(owlsGrounding, "Grounding") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:wsdlOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     A WSDL operation to which the atomic process
    ///     (referenced by owlsProcess) corresponds.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOperation">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOperation</seealso>
    let wsdlOperation = Prefixed_Name(owlsGrounding, "wsdlOperation") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:hasAtomicProcessGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#hasAtomicProcessGrounding">http://www.daml.org/services/owl-s/1.2/Grounding.owl#hasAtomicProcessGrounding</seealso>
    let hasAtomicProcessGrounding =
        Prefixed_Name(owlsGrounding, "hasAtomicProcessGrounding") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:WsdlMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     MessageMap for WSDL inputs and outputs
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlMessageMap</seealso>
    let WsdlMessageMap = Prefixed_Name(owlsGrounding, "WsdlMessageMap") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#operation">http://www.daml.org/services/owl-s/1.2/Grounding.owl#operation</seealso>
    let operation = Prefixed_Name(owlsGrounding, "operation") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:wsdlInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     There should be one instance of this property for each
    ///     message part of the WSDL input message.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInput">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInput</seealso>
    let wsdlInput = Prefixed_Name(owlsGrounding, "wsdlInput") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:wsdlInputMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI for the WSDL input message element corresponding
    ///     to the inputs of the atomic process.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInputMessage">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlInputMessage</seealso>
    let wsdlInputMessage =
        Prefixed_Name(owlsGrounding, "wsdlInputMessage") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:wsdlOutputMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI for the WSDL message element corresponding
    ///     to the outputs of the atomic process.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutputMessage">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutputMessage</seealso>
    let wsdlOutputMessage =
        Prefixed_Name(owlsGrounding, "wsdlOutputMessage") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:wsdlPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI for a WSDL Port that provides the operation to which
    ///     this atomic process is grounded.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlPort">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlPort</seealso>
    let wsdlPort = Prefixed_Name(owlsGrounding, "wsdlPort") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:xsltTransformationString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A string giving an XSLT Tranformation.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationString">http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationString</seealso>
    let xsltTransformationString =
        Prefixed_Name(owlsGrounding, "xsltTransformationString") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:DirectOutputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectOutputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#DirectOutputMessageMap</seealso>
    let DirectOutputMessageMap =
        Prefixed_Name(owlsGrounding, "DirectOutputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:WsdlOperationRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     This class provides a unique specification of a WSDL operation.
    ///     WSDL 1.1, on which this version of the grounding is based, does
    ///     not have a way to uniquely identify an operation with a single URI.
    ///     Uniqueness is achieved using a pair (portType, operation).
    ///   </para>
    ///   <para>
    ///     Restricting the cardinality of operation to one
    ///   </para>
    ///   <para>
    ///     Restricting the cardinality of portType to one
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlOperationRef">http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlOperationRef</seealso>
    let WsdlOperationRef =
        Prefixed_Name(owlsGrounding, "WsdlOperationRef") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:AtomicProcessGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A class that relates elements of a OWL-S atomic process to a
    ///     WSDL specification.
    ///
    ///     Each instance of AtomicProcessGrounding must have exactly one
    ///     value for owlsProcess. Rest of the AtomicProcessGrounding depends
    ///     on the specifics of the grounding type.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#AtomicProcessGrounding">http://www.daml.org/services/owl-s/1.2/Grounding.owl#AtomicProcessGrounding</seealso>
    let AtomicProcessGrounding =
        Prefixed_Name(owlsGrounding, "AtomicProcessGrounding") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:WsdlInputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
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
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlInputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlInputMessageMap</seealso>
    let WsdlInputMessageMap =
        Prefixed_Name(owlsGrounding, "WsdlInputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:MessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A class used to map parameters in OWL-S to the parameters
    ///     in the grounded operation. owlsParamater property is used
    ///     to specify the OWL-S parameter.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#MessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#MessageMap</seealso>
    let MessageMap = Prefixed_Name(owlsGrounding, "MessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:OutputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A MessageMap that maps outputs to grounding specification
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#OutputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#OutputMessageMap</seealso>
    let OutputMessageMap =
        Prefixed_Name(owlsGrounding, "OutputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:WsdlAtomicProcessGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
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
    ///   </para>
    ///   <para>
    ///     A class that relates elements of a OWL-S atomic process to a
    ///     WSDL specification.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlAtomicProcessGrounding">http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlAtomicProcessGrounding</seealso>
    let WsdlAtomicProcessGrounding =
        Prefixed_Name(owlsGrounding, "WsdlAtomicProcessGrounding") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:WsdlGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     WsdlGrounding is A Grounding that grounds every process to
    ///     a WSDL operation.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlGrounding">http://www.daml.org/services/owl-s/1.2/Grounding.owl#WsdlGrounding</seealso>
    let WsdlGrounding = Prefixed_Name(owlsGrounding, "WsdlGrounding") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:portType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#portType">http://www.daml.org/services/owl-s/1.2/Grounding.owl#portType</seealso>
    let portType = Prefixed_Name(owlsGrounding, "portType") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:wsdlDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI indicating a WSDL document to
    ///     which this grounding refers.  This isn't
    ///     essential; primarily for convenience as documentation.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlDocument">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlDocument</seealso>
    let wsdlDocument = Prefixed_Name(owlsGrounding, "wsdlDocument") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:wsdlOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     There should be one instance of this property for each
    ///     output of the atomic process.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutput">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlOutput</seealso>
    let wsdlOutput = Prefixed_Name(owlsGrounding, "wsdlOutput") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:wsdlService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI for a WSDL Service that provides the operation to which
    ///     this atomic process is grounded.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlService">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlService</seealso>
    let wsdlService = Prefixed_Name(owlsGrounding, "wsdlService") |> PrefixedName
    /// <summary>
    ///   <para>owlsGrounding:wsdlVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI indicating the version of WSDL being used.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlVersion">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlVersion</seealso>
    let wsdlVersion = Prefixed_Name(owlsGrounding, "wsdlVersion") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:xsltTransformationURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI for an XSLT Tranformation.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationURI">http://www.daml.org/services/owl-s/1.2/Grounding.owl#xsltTransformationURI</seealso>
    let xsltTransformationURI =
        Prefixed_Name(owlsGrounding, "xsltTransformationURI") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:owlsParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///     An input or output property of an atomic process.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsParameter">http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsParameter</seealso>
    let owlsParameter = Prefixed_Name(owlsGrounding, "owlsParameter") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:XSLTOutputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTOutputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTOutputMessageMap</seealso>
    let XSLTOutputMessageMap =
        Prefixed_Name(owlsGrounding, "XSLTOutputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:owlsProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    ///     The atomic process to which this grounding applies.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsProcess">http://www.daml.org/services/owl-s/1.2/Grounding.owl#owlsProcess</seealso>
    let owlsProcess = Prefixed_Name(owlsGrounding, "owlsProcess") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:XSLTInputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTInputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#XSLTInputMessageMap</seealso>
    let XSLTInputMessageMap =
        Prefixed_Name(owlsGrounding, "XSLTInputMessageMap") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:wsdlMessagePart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     A URI for a WSDL message part element.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlMessagePart">http://www.daml.org/services/owl-s/1.2/Grounding.owl#wsdlMessagePart</seealso>
    let wsdlMessagePart =
        Prefixed_Name(owlsGrounding, "wsdlMessagePart") |> PrefixedName

    /// <summary>
    ///   <para>owlsGrounding:InputMessageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A MessageMap that maps inputs to grounding specification
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Grounding.owl#InputMessageMap">http://www.daml.org/services/owl-s/1.2/Grounding.owl#InputMessageMap</seealso>
    let InputMessageMap =
        Prefixed_Name(owlsGrounding, "InputMessageMap") |> PrefixedName
