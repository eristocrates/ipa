namespace https.w3id.org.ibp.CTRLont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ctrl =
    let _namespace_iri = Namespace_Iri ctrl |> NamespaceIRI
    /// <summary>
    ///   <para>ctrl:supervises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to describe if one control actor supervises another.</para>
    /// labels<para>supervises</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#supervises">https://w3id.org/ibp/CTRLont#supervises</seealso>
    let supervises = Prefixed_Name(ctrl, "supervises") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:logicInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to express the relationship of some application logic concept to an input.</para>
    /// labels<para>logicInput</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#logicInput">https://w3id.org/ibp/CTRLont#logicInput</seealso>
    let logicInput = Prefixed_Name(ctrl, "logicInput") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#">https://w3id.org/ibp/CTRLont#</seealso>
    let _prefix_iri = Prefixed_Name(ctrl, "") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to annotate a input, output or parameter with its data type.</para>
    /// labels<para>hasDataType</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasDataType">https://w3id.org/ibp/CTRLont#hasDataType</seealso>
    let hasDataType = Prefixed_Name(ctrl, "hasDataType") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to annotate an input, output or parameter with its medium.</para>
    /// labels<para>hasMedium</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasMedium">https://w3id.org/ibp/CTRLont#hasMedium</seealso>
    let hasMedium = Prefixed_Name(ctrl, "hasMedium") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Placeholder concept to stipulate reuse of existing ontologies such as dbpedia or  	http://www.productontology.org/id/</para>
    /// labels<para>Medium</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#Medium">https://w3id.org/ibp/CTRLont#Medium</seealso>
    let Medium = Prefixed_Name(ctrl, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasSemanticType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to relate an input, output or parameter with its semantic type.</para>
    /// labels<para>hasSemanticType</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasSemanticType">https://w3id.org/ibp/CTRLont#hasSemanticType</seealso>
    let hasSemanticType = Prefixed_Name(ctrl, "hasSemanticType") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#Unit">https://w3id.org/ibp/CTRLont#Unit</seealso>
    let Unit = Prefixed_Name(ctrl, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:ApplicationLogic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concept to specify the application logic of a control actor. Seperate ontologies may be used to further specify this concept.</para>
    /// labels<para>Application Logic</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#ApplicationLogic">https://w3id.org/ibp/CTRLont#ApplicationLogic</seealso>
    let ApplicationLogic = Prefixed_Name(ctrl, "ApplicationLogic") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasApplicationLogic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to relate a control actor to its specific application logic</para>
    /// labels<para>hasApplicationLogic</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasApplicationLogic">https://w3id.org/ibp/CTRLont#hasApplicationLogic</seealso>
    let hasApplicationLogic = Prefixed_Name(ctrl, "hasApplicationLogic") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An output allows compute results by the application logic of an control actor to be fowarded to outside entities such as actuators or other control actors.</para>
    /// labels<para>Output</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#Output">https://w3id.org/ibp/CTRLont#Output</seealso>
    let Output = Prefixed_Name(ctrl, "Output") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to relate a control actor to its outputs.</para>
    /// labels<para>hasOutput</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasOutput">https://w3id.org/ibp/CTRLont#hasOutput</seealso>
    let hasOutput = Prefixed_Name(ctrl, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to relate a control actor to its inputs.</para>
    /// labels<para>hasInput</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasInput">https://w3id.org/ibp/CTRLont#hasInput</seealso>
    let hasInput = Prefixed_Name(ctrl, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An input allow flows of information to enter a control actor. Inputs are processed by the respective application logic of the control actor to compute the outputs.</para>
    /// labels<para>Input</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#Input">https://w3id.org/ibp/CTRLont#Input</seealso>
    let Input = Prefixed_Name(ctrl, "Input") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Placeholder class for the specification of basic data types such as, e.g. integer, boolean or double.</para>
    /// labels<para>Data type</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#DataType">https://w3id.org/ibp/CTRLont#DataType</seealso>
    let DataType = Prefixed_Name(ctrl, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to relate a control actor to its parameter.</para>
    /// labels<para>hasParameter</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasParameter">https://w3id.org/ibp/CTRLont#hasParameter</seealso>
    let hasParameter = Prefixed_Name(ctrl, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parameter describe time-invariant values and settings of the respective control actor. Thus thay can be added dependent on the respective application logic.</para>
    /// labels<para>Parameter</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#Parameter">https://w3id.org/ibp/CTRLont#Parameter</seealso>
    let Parameter = Prefixed_Name(ctrl, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:AnnotatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An annotated element is a generic superclass for ctrl:Input, ctrl:Output and ctrl:Parameter</para>
    /// labels<para>Annotated Element</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#AnnotatedElement">https://w3id.org/ibp/CTRLont#AnnotatedElement</seealso>
    let AnnotatedElement = Prefixed_Name(ctrl, "AnnotatedElement") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to annotate an input, output or parameter with its quantity.</para>
    /// labels<para>hasQuantity</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasQuantity">https://w3id.org/ibp/CTRLont#hasQuantity</seealso>
    let hasQuantity = Prefixed_Name(ctrl, "hasQuantity") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:SemanticType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It may be required to further annotate an Input, Output or Parameter with a specific Semantic Type. For example in building automation to differ between room air temperature or outdoor air temperature.</para>
    /// labels<para>Semantic Type</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#SemanticType">https://w3id.org/ibp/CTRLont#SemanticType</seealso>
    let SemanticType = Prefixed_Name(ctrl, "SemanticType") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:ControlActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concept to describe the in general accepted Sense-Process-Actuate
    /// pattern in automation systems, e.g. function blocks from IEC 61499.</para>
    /// labels<para>Control Actor</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#ControlActor">https://w3id.org/ibp/CTRLont#ControlActor</seealso>
    let ControlActor = Prefixed_Name(ctrl, "ControlActor") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:isConnectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to describe the topological relationship between an input of one control actor and the output of another.</para>
    /// labels<para>isConnectedTo</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#isConnectedTo">https://w3id.org/ibp/CTRLont#isConnectedTo</seealso>
    let isConnectedTo = Prefixed_Name(ctrl, "isConnectedTo") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:isSupervisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to describe hierarchical composition of control actors.</para>
    /// labels<para>isSupervisedBy</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#isSupervisedBy">https://w3id.org/ibp/CTRLont#isSupervisedBy</seealso>
    let isSupervisedBy = Prefixed_Name(ctrl, "isSupervisedBy") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:logicOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to express the relationship of some application logic concept to an output.</para>
    /// labels<para>logicOutput</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#logicOutput">https://w3id.org/ibp/CTRLont#logicOutput</seealso>
    let logicOutput = Prefixed_Name(ctrl, "logicOutput") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:logicParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to express the relationship of some application logic concept to an parameter.</para>
    /// labels<para>logicParameter</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#logicParameter">https://w3id.org/ibp/CTRLont#logicParameter</seealso>
    let logicParameter = Prefixed_Name(ctrl, "logicParameter") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.</para>
    /// labels<para>Quantity</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#Quantity">https://w3id.org/ibp/CTRLont#Quantity</seealso>
    let Quantity = Prefixed_Name(ctrl, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>ctrl:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to relate an input, output or parameter with its unit.</para>
    /// labels<para>hasUnit</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont#hasUnit">https://w3id.org/ibp/CTRLont#hasUnit</seealso>
    let hasUnit = Prefixed_Name(ctrl, "hasUnit") |> PrefixedName
