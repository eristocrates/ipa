namespace https.w3id.org.dt.hash

open DoxAletheia.Rdf_Vocabulary

module dt =
    let _namespace_name = "https://w3id.org/dt#"

    /// <summary>
    /// object of interest in the context of a construction process
    /// <see href="https://w3id.org/dt#ConstructionObject"></see></summary>
    let ConstructionObject =
        Namespaced_IRI.parse _namespace_name "ConstructionObject" |> NamespacedName

    /// <summary>
    /// named and individually scheduled physical item and feature that might require management, such as inspection, maintenance, servicing or replacement, during the in-use phase
    /// <see href="https://w3id.org/dt#LibraryComponent"></see></summary>
    let LibraryComponent =
        Namespaced_IRI.parse _namespace_name "LibraryComponent" |> NamespacedName

    /// <summary>
    /// data structure used to describe the characteristics of construction objects
    /// <see href="https://w3id.org/dt#DataTemplate"></see></summary>
    let DataTemplate =
        Namespaced_IRI.parse _namespace_name "DataTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasProperty"></see>
    /// </summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// a set of properties that can be applied to a data template
    /// <see href="https://w3id.org/dt#SetOfProperties"></see></summary>
    let SetOfProperties =
        Namespaced_IRI.parse _namespace_name "SetOfProperties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasSetOfProperties"></see>
    /// </summary>
    let hasSetOfProperties =
        Namespaced_IRI.parse _namespace_name "hasSetOfProperties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#isDataTemplateFor"></see>
    /// </summary>
    let isDataTemplateFor =
        Namespaced_IRI.parse _namespace_name "isDataTemplateFor" |> NamespacedName

    /// <summary>
    /// reference to an external dictionary, which is a centralized repository of information about data such as meaning, relationships to other data, origin, usage and format
    /// <see href="https://w3id.org/dt#ExternalDictionaryReference"></see></summary>
    let ExternalDictionaryReference =
        Namespaced_IRI.parse _namespace_name "ExternalDictionaryReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasExternalDictionary"></see>
    /// </summary>
    let hasExternalDictionary =
        Namespaced_IRI.parse _namespace_name "hasExternalDictionary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasExternalDictionaryProperty"></see>
    /// </summary>
    let hasExternalDictionaryProperty =
        Namespaced_IRI.parse _namespace_name "hasExternalDictionaryProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#ISBN"></see>
    /// </summary>
    let ISBN = Namespaced_IRI.parse _namespace_name "ISBN" |> NamespacedName

    /// <summary>
    /// publication that is consulted to find specific information, particularly in a technical or scientific domain
    /// <see href="https://w3id.org/dt#ReferenceDocument"></see></summary>
    let ReferenceDocument =
        Namespaced_IRI.parse _namespace_name "ReferenceDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasReferenceDocument"></see>
    /// </summary>
    let hasReferenceDocument =
        Namespaced_IRI.parse _namespace_name "hasReferenceDocument" |> NamespacedName

    /// <summary>
    /// the physical quantity of a library component
    /// <see href="https://w3id.org/dt#PhysicalQuantity"></see></summary>
    let PhysicalQuantity =
        Namespaced_IRI.parse _namespace_name "PhysicalQuantity" |> NamespacedName

    /// <summary>
    /// the physical quantity of a library component
    /// <see href="https://w3id.org/dt#PredefinedValueItem"></see></summary>
    let PredefinedValueItem =
        Namespaced_IRI.parse _namespace_name "PredefinedValueItem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasIndex"></see>
    /// </summary>
    let hasIndex = Namespaced_IRI.parse _namespace_name "hasIndex" |> NamespacedName

    /// <summary>
    /// list of predefined values
    /// <see href="https://w3id.org/dt#PredefinedValuesList"></see></summary>
    let PredefinedValuesList =
        Namespaced_IRI.parse _namespace_name "PredefinedValuesList" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasPredefinedValueItem"></see>
    /// </summary>
    let hasPredefinedValueItem =
        Namespaced_IRI.parse _namespace_name "hasPredefinedValueItem" |> NamespacedName

    /// <summary>
    /// inherent or acquired feature of an item
    /// <see href="https://w3id.org/dt#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasPredefinedValues"></see>
    /// </summary>
    let hasPredefinedValues =
        Namespaced_IRI.parse _namespace_name "hasPredefinedValues" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#author"></see>
    /// </summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dt#uri"></see>
    /// </summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dt#publisher"></see>
    /// </summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#dateOfPublication"></see>
    /// </summary>
    let dateOfPublication =
        Namespaced_IRI.parse _namespace_name "dateOfPublication" |> NamespacedName

    /// <summary>
    /// real scalar quantity, defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the second quantity to the first one as a number
    /// <see href="https://w3id.org/dt#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dt#hasExternalDictionaryReference"></see>
    /// </summary>
    let hasExternalDictionaryReference =
        Namespaced_IRI.parse _namespace_name "hasExternalDictionaryReference" |> NamespacedName
