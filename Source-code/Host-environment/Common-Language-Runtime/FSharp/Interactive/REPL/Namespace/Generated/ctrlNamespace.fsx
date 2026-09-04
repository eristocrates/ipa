#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ctrl =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/ibp/CTRLont#" "ctrl"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Annotated Element</para>
    ///   <para>rdfs:comment : An annotated element is a generic superclass for ctrl:Input, ctrl:Output and ctrl:Parameter</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#AnnotatedElement">ctrl:AnnotatedElement</a>
    /// </summary>
    let AnnotatedElement = _prefixId.prefix "AnnotatedElement"
    /// <summary>
    ///   <para>rdfs:label : Application Logic</para>
    ///   <para>rdfs:comment : Concept to specify the application logic of a control actor. Seperate ontologies may be used to further specify this concept.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#ApplicationLogic">ctrl:ApplicationLogic</a>
    /// </summary>
    let ApplicationLogic = _prefixId.prefix "ApplicationLogic"
    /// <summary>
    ///   <para>rdfs:label : Control Actor</para>
    ///   <para>rdfs:comment : Concept to describe the in general accepted Sense-Process-Actuate
    /// pattern in automation systems, e.g. function blocks from IEC 61499.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#ControlActor">ctrl:ControlActor</a>
    /// </summary>
    let ControlActor = _prefixId.prefix "ControlActor"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.w3.org/TR/xmlschema-2/#built-in-datatypes^^xsd:anyURI</para>
    ///   <para>rdfs:label : Data type</para>
    ///   <para>rdfs:comment : Placeholder class for the specification of basic data types such as, e.g. integer, boolean or double.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#DataType">ctrl:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:label : Input</para>
    ///   <para>rdfs:comment : An input allow flows of information to enter a control actor. Inputs are processed by the respective application logic of the control actor to compute the outputs.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#Input">ctrl:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>rdfs:label : Medium</para>
    ///   <para>rdfs:comment : Placeholder concept to stipulate reuse of existing ontologies such as dbpedia or  	http://www.productontology.org/id/</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#Medium">ctrl:Medium</a>
    /// </summary>
    let Medium = _prefixId.prefix "Medium"
    /// <summary>
    ///   <para>rdfs:label : Output</para>
    ///   <para>rdfs:comment : An output allows compute results by the application logic of an control actor to be fowarded to outside entities such as actuators or other control actors.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#Output">ctrl:Output</a>
    /// </summary>
    let Output = _prefixId.prefix "Output"
    /// <summary>
    ///   <para>rdfs:label : Parameter</para>
    ///   <para>rdfs:comment : Parameter describe time-invariant values and settings of the respective control actor. Thus thay can be added dependent on the respective application logic.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#Parameter">ctrl:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:label : Quantity</para>
    ///   <para>rdfs:comment : Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#Quantity">ctrl:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>rdfs:label : Semantic Type</para>
    ///   <para>rdfs:comment : It may be required to further annotate an Input, Output or Parameter with a specific Semantic Type. For example in building automation to differ between room air temperature or outdoor air temperature.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#SemanticType">ctrl:SemanticType</a>
    /// </summary>
    let SemanticType = _prefixId.prefix "SemanticType"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:comment : Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#Unit">ctrl:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : hasApplicationLogic</para>
    ///   <para>rdfs:comment : Object property to relate a control actor to its specific application logic</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasApplicationLogic">ctrl:hasApplicationLogic</a>
    /// </summary>
    let hasApplicationLogic = _prefixId.prefix "hasApplicationLogic"
    /// <summary>
    ///   <para>rdfs:label : hasDataType</para>
    ///   <para>rdfs:comment : Object property to annotate a input, output or parameter with its data type.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasDataType">ctrl:hasDataType</a>
    /// </summary>
    let hasDataType = _prefixId.prefix "hasDataType"
    /// <summary>
    ///   <para>rdfs:label : hasInput</para>
    ///   <para>rdfs:comment : Object property to relate a control actor to its inputs.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasInput">ctrl:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:label : hasMedium</para>
    ///   <para>rdfs:comment : Object property to annotate an input, output or parameter with its medium.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasMedium">ctrl:hasMedium</a>
    /// </summary>
    let hasMedium = _prefixId.prefix "hasMedium"
    /// <summary>
    ///   <para>rdfs:label : hasOutput</para>
    ///   <para>rdfs:comment : Object property to relate a control actor to its outputs.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasOutput">ctrl:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : hasParameter</para>
    ///   <para>rdfs:comment : Object property to relate a control actor to its parameter.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasParameter">ctrl:hasParameter</a>
    /// </summary>
    let hasParameter = _prefixId.prefix "hasParameter"
    /// <summary>
    ///   <para>rdfs:label : hasQuantity</para>
    ///   <para>rdfs:comment : Object property to annotate an input, output or parameter with its quantity.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasQuantity">ctrl:hasQuantity</a>
    /// </summary>
    let hasQuantity = _prefixId.prefix "hasQuantity"
    /// <summary>
    ///   <para>rdfs:label : hasSemanticType</para>
    ///   <para>rdfs:comment : Object property to relate an input, output or parameter with its semantic type.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasSemanticType">ctrl:hasSemanticType</a>
    /// </summary>
    let hasSemanticType = _prefixId.prefix "hasSemanticType"
    /// <summary>
    ///   <para>rdfs:label : hasUnit</para>
    ///   <para>rdfs:comment : Object property to relate an input, output or parameter with its unit.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#hasUnit">ctrl:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : isConnectedTo</para>
    ///   <para>rdfs:comment : Object property to describe the topological relationship between an input of one control actor and the output of another.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#isConnectedTo">ctrl:isConnectedTo</a>
    /// </summary>
    let isConnectedTo = _prefixId.prefix "isConnectedTo"
    /// <summary>
    ///   <para>rdfs:label : isSupervisedBy</para>
    ///   <para>rdfs:comment : Object property to describe hierarchical composition of control actors.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#isSupervisedBy">ctrl:isSupervisedBy</a>
    /// </summary>
    let isSupervisedBy = _prefixId.prefix "isSupervisedBy"
    /// <summary>
    ///   <para>rdfs:label : logicInput</para>
    ///   <para>rdfs:comment : Object property to express the relationship of some application logic concept to an input.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#logicInput">ctrl:logicInput</a>
    /// </summary>
    let logicInput = _prefixId.prefix "logicInput"
    /// <summary>
    ///   <para>rdfs:label : logicOutput</para>
    ///   <para>rdfs:comment : Object property to express the relationship of some application logic concept to an output.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#logicOutput">ctrl:logicOutput</a>
    /// </summary>
    let logicOutput = _prefixId.prefix "logicOutput"
    /// <summary>
    ///   <para>rdfs:label : logicParameter</para>
    ///   <para>rdfs:comment : Object property to express the relationship of some application logic concept to an parameter.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#logicParameter">ctrl:logicParameter</a>
    /// </summary>
    let logicParameter = _prefixId.prefix "logicParameter"
    /// <summary>
    ///   <para>rdfs:label : supervises</para>
    ///   <para>rdfs:comment : Object property to describe if one control actor supervises another.</para>
    ///   <a href="https://w3id.org/ibp/CTRLont#supervises">ctrl:supervises</a>
    /// </summary>
    let supervises = _prefixId.prefix "supervises"
