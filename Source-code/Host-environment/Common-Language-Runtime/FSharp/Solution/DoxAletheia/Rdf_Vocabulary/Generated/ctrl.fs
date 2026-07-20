namespace https.w3id.org.ibp.CTRLont.hash

open DoxAletheia

module ctrl =
    let _namespace_name = "https://w3id.org/ibp/CTRLont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An annotated element is a generic superclass for ctrl:Input, ctrl:Output and ctrl:Parameter
    /// <see href="https://w3id.org/ibp/CTRLont#AnnotatedElement"></see></summary>
    let AnnotatedElement = _prefix "AnnotatedElement"
    /// <summary>
    /// Object property to annotate a input, output or parameter with its data type.
    /// <see href="https://w3id.org/ibp/CTRLont#hasDataType"></see></summary>
    let hasDataType = _prefix "hasDataType"
    /// <summary>
    /// Placeholder class for the specification of basic data types such as, e.g. integer, boolean or double.
    /// <see href="https://w3id.org/ibp/CTRLont#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// Object property to annotate an input, output or parameter with its medium.
    /// <see href="https://w3id.org/ibp/CTRLont#hasMedium"></see></summary>
    let hasMedium = _prefix "hasMedium"
    /// <summary>
    /// Placeholder concept to stipulate reuse of existing ontologies such as dbpedia or  	http://www.productontology.org/id/
    /// <see href="https://w3id.org/ibp/CTRLont#Medium"></see></summary>
    let Medium = _prefix "Medium"
    /// <summary>
    /// Object property to annotate an input, output or parameter with its quantity.
    /// <see href="https://w3id.org/ibp/CTRLont#hasQuantity"></see></summary>
    let hasQuantity = _prefix "hasQuantity"
    /// <summary>
    /// Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.
    /// <see href="https://w3id.org/ibp/CTRLont#Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    /// Object property to relate an input, output or parameter with its semantic type.
    /// <see href="https://w3id.org/ibp/CTRLont#hasSemanticType"></see></summary>
    let hasSemanticType = _prefix "hasSemanticType"
    /// <summary>
    /// It may be required to further annotate an Input, Output or Parameter with a specific Semantic Type. For example in building automation to differ between room air temperature or outdoor air temperature.
    /// <see href="https://w3id.org/ibp/CTRLont#SemanticType"></see></summary>
    let SemanticType = _prefix "SemanticType"
    /// <summary>
    /// Object property to relate an input, output or parameter with its unit.
    /// <see href="https://w3id.org/ibp/CTRLont#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.
    /// <see href="https://w3id.org/ibp/CTRLont#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// Concept to specify the application logic of a control actor. Seperate ontologies may be used to further specify this concept.
    /// <see href="https://w3id.org/ibp/CTRLont#ApplicationLogic"></see></summary>
    let ApplicationLogic = _prefix "ApplicationLogic"
    /// <summary>
    /// Concept to describe the in general accepted Sense-Process-Actuate
    /// pattern in automation systems, e.g. function blocks from IEC 61499.
    /// <see href="https://w3id.org/ibp/CTRLont#ControlActor"></see></summary>
    let ControlActor = _prefix "ControlActor"
    /// <summary>
    /// Object property to relate a control actor to its specific application logic
    /// <see href="https://w3id.org/ibp/CTRLont#hasApplicationLogic"></see></summary>
    let hasApplicationLogic = _prefix "hasApplicationLogic"
    /// <summary>
    /// An output allows compute results by the application logic of an control actor to be fowarded to outside entities such as actuators or other control actors.
    /// <see href="https://w3id.org/ibp/CTRLont#Output"></see></summary>
    let Output = _prefix "Output"
    /// <summary>
    /// Object property to relate a control actor to its outputs.
    /// <see href="https://w3id.org/ibp/CTRLont#hasOutput"></see></summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// Object property to relate a control actor to its inputs.
    /// <see href="https://w3id.org/ibp/CTRLont#hasInput"></see></summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    /// An input allow flows of information to enter a control actor. Inputs are processed by the respective application logic of the control actor to compute the outputs.
    /// <see href="https://w3id.org/ibp/CTRLont#Input"></see></summary>
    let Input = _prefix "Input"
    /// <summary>
    /// Object property to relate a control actor to its parameter.
    /// <see href="https://w3id.org/ibp/CTRLont#hasParameter"></see></summary>
    let hasParameter = _prefix "hasParameter"
    /// <summary>
    /// Parameter describe time-invariant values and settings of the respective control actor. Thus thay can be added dependent on the respective application logic.
    /// <see href="https://w3id.org/ibp/CTRLont#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// Object property to describe the topological relationship between an input of one control actor and the output of another.
    /// <see href="https://w3id.org/ibp/CTRLont#isConnectedTo"></see></summary>
    let isConnectedTo = _prefix "isConnectedTo"
    /// <summary>
    /// Object property to describe hierarchical composition of control actors.
    /// <see href="https://w3id.org/ibp/CTRLont#isSupervisedBy"></see></summary>
    let isSupervisedBy = _prefix "isSupervisedBy"
    /// <summary>
    /// Object property to describe if one control actor supervises another.
    /// <see href="https://w3id.org/ibp/CTRLont#supervises"></see></summary>
    let supervises = _prefix "supervises"
    /// <summary>
    /// Object property to express the relationship of some application logic concept to an input.
    /// <see href="https://w3id.org/ibp/CTRLont#logicInput"></see></summary>
    let logicInput = _prefix "logicInput"
    /// <summary>
    /// Object property to express the relationship of some application logic concept to an output.
    /// <see href="https://w3id.org/ibp/CTRLont#logicOutput"></see></summary>
    let logicOutput = _prefix "logicOutput"
    /// <summary>
    /// Object property to express the relationship of some application logic concept to an parameter.
    /// <see href="https://w3id.org/ibp/CTRLont#logicParameter"></see></summary>
    let logicParameter = _prefix "logicParameter"
