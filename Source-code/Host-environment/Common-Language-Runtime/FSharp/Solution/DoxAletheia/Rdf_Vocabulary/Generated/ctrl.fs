namespace https.w3id.org.ibp.CTRLont.hash

open DoxAletheia.Rdf_Vocabulary

module ctrl =
    let _namespace_name = "https://w3id.org/ibp/CTRLont#"

    /// <summary>
    /// An annotated element is a generic superclass for ctrl:Input, ctrl:Output and ctrl:Parameter
    /// <see href="https://w3id.org/ibp/CTRLont#AnnotatedElement"></see></summary>
    let AnnotatedElement =
        Namespaced_IRI.parse _namespace_name "AnnotatedElement" |> NamespacedName

    /// <summary>
    /// Object property to annotate a input, output or parameter with its data type.
    /// <see href="https://w3id.org/ibp/CTRLont#hasDataType"></see></summary>
    let hasDataType =
        Namespaced_IRI.parse _namespace_name "hasDataType" |> NamespacedName

    /// <summary>
    /// Placeholder class for the specification of basic data types such as, e.g. integer, boolean or double.
    /// <see href="https://w3id.org/ibp/CTRLont#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName
    /// <summary>
    /// Object property to annotate an input, output or parameter with its medium.
    /// <see href="https://w3id.org/ibp/CTRLont#hasMedium"></see></summary>
    let hasMedium = Namespaced_IRI.parse _namespace_name "hasMedium" |> NamespacedName
    /// <summary>
    /// Placeholder concept to stipulate reuse of existing ontologies such as dbpedia or  	http://www.productontology.org/id/
    /// <see href="https://w3id.org/ibp/CTRLont#Medium"></see></summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName

    /// <summary>
    /// Object property to annotate an input, output or parameter with its quantity.
    /// <see href="https://w3id.org/ibp/CTRLont#hasQuantity"></see></summary>
    let hasQuantity =
        Namespaced_IRI.parse _namespace_name "hasQuantity" |> NamespacedName

    /// <summary>
    /// Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.
    /// <see href="https://w3id.org/ibp/CTRLont#Quantity"></see></summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName

    /// <summary>
    /// Object property to relate an input, output or parameter with its semantic type.
    /// <see href="https://w3id.org/ibp/CTRLont#hasSemanticType"></see></summary>
    let hasSemanticType =
        Namespaced_IRI.parse _namespace_name "hasSemanticType" |> NamespacedName

    /// <summary>
    /// It may be required to further annotate an Input, Output or Parameter with a specific Semantic Type. For example in building automation to differ between room air temperature or outdoor air temperature.
    /// <see href="https://w3id.org/ibp/CTRLont#SemanticType"></see></summary>
    let SemanticType =
        Namespaced_IRI.parse _namespace_name "SemanticType" |> NamespacedName

    /// <summary>
    /// Object property to relate an input, output or parameter with its unit.
    /// <see href="https://w3id.org/ibp/CTRLont#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
    /// <summary>
    /// Placeholder concept to stipulate reuse of existing ontologies such as Ontology for Units and Measures (OM) or QUDT.
    /// <see href="https://w3id.org/ibp/CTRLont#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// Concept to specify the application logic of a control actor. Seperate ontologies may be used to further specify this concept.
    /// <see href="https://w3id.org/ibp/CTRLont#ApplicationLogic"></see></summary>
    let ApplicationLogic =
        Namespaced_IRI.parse _namespace_name "ApplicationLogic" |> NamespacedName

    /// <summary>
    /// Concept to describe the in general accepted Sense-Process-Actuate
    /// pattern in automation systems, e.g. function blocks from IEC 61499.
    /// <see href="https://w3id.org/ibp/CTRLont#ControlActor"></see></summary>
    let ControlActor =
        Namespaced_IRI.parse _namespace_name "ControlActor" |> NamespacedName

    /// <summary>
    /// Object property to relate a control actor to its specific application logic
    /// <see href="https://w3id.org/ibp/CTRLont#hasApplicationLogic"></see></summary>
    let hasApplicationLogic =
        Namespaced_IRI.parse _namespace_name "hasApplicationLogic" |> NamespacedName

    /// <summary>
    /// An output allows compute results by the application logic of an control actor to be fowarded to outside entities such as actuators or other control actors.
    /// <see href="https://w3id.org/ibp/CTRLont#Output"></see></summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    /// Object property to relate a control actor to its outputs.
    /// <see href="https://w3id.org/ibp/CTRLont#hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName
    /// <summary>
    /// Object property to relate a control actor to its inputs.
    /// <see href="https://w3id.org/ibp/CTRLont#hasInput"></see></summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    /// An input allow flows of information to enter a control actor. Inputs are processed by the respective application logic of the control actor to compute the outputs.
    /// <see href="https://w3id.org/ibp/CTRLont#Input"></see></summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName

    /// <summary>
    /// Object property to relate a control actor to its parameter.
    /// <see href="https://w3id.org/ibp/CTRLont#hasParameter"></see></summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    /// Parameter describe time-invariant values and settings of the respective control actor. Thus thay can be added dependent on the respective application logic.
    /// <see href="https://w3id.org/ibp/CTRLont#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    /// Object property to describe the topological relationship between an input of one control actor and the output of another.
    /// <see href="https://w3id.org/ibp/CTRLont#isConnectedTo"></see></summary>
    let isConnectedTo =
        Namespaced_IRI.parse _namespace_name "isConnectedTo" |> NamespacedName

    /// <summary>
    /// Object property to describe hierarchical composition of control actors.
    /// <see href="https://w3id.org/ibp/CTRLont#isSupervisedBy"></see></summary>
    let isSupervisedBy =
        Namespaced_IRI.parse _namespace_name "isSupervisedBy" |> NamespacedName

    /// <summary>
    /// Object property to describe if one control actor supervises another.
    /// <see href="https://w3id.org/ibp/CTRLont#supervises"></see></summary>
    let supervises = Namespaced_IRI.parse _namespace_name "supervises" |> NamespacedName
    /// <summary>
    /// Object property to express the relationship of some application logic concept to an input.
    /// <see href="https://w3id.org/ibp/CTRLont#logicInput"></see></summary>
    let logicInput = Namespaced_IRI.parse _namespace_name "logicInput" |> NamespacedName

    /// <summary>
    /// Object property to express the relationship of some application logic concept to an output.
    /// <see href="https://w3id.org/ibp/CTRLont#logicOutput"></see></summary>
    let logicOutput =
        Namespaced_IRI.parse _namespace_name "logicOutput" |> NamespacedName

    /// <summary>
    /// Object property to express the relationship of some application logic concept to an parameter.
    /// <see href="https://w3id.org/ibp/CTRLont#logicParameter"></see></summary>
    let logicParameter =
        Namespaced_IRI.parse _namespace_name "logicParameter" |> NamespacedName
