namespace https.w3id.org.dt.hash

open DoxAletheia

module dt =
    let _namespace_name = "https://w3id.org/dt#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// object of interest in the context of a construction process
    /// <see href="https://w3id.org/dt#ConstructionObject"></see></summary>
    let ConstructionObject = _prefix "ConstructionObject"
    /// <summary>
    /// named and individually scheduled physical item and feature that might require management, such as inspection, maintenance, servicing or replacement, during the in-use phase
    /// <see href="https://w3id.org/dt#LibraryComponent"></see></summary>
    let LibraryComponent = _prefix "LibraryComponent"
    /// <summary>
    /// data structure used to describe the characteristics of construction objects
    /// <see href="https://w3id.org/dt#DataTemplate"></see></summary>
    let DataTemplate = _prefix "DataTemplate"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasProperty"></see>
    /// </summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// a set of properties that can be applied to a data template
    /// <see href="https://w3id.org/dt#SetOfProperties"></see></summary>
    let SetOfProperties = _prefix "SetOfProperties"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasSetOfProperties"></see>
    /// </summary>
    let hasSetOfProperties = _prefix "hasSetOfProperties"
    /// <summary>
    ///   <see href="https://w3id.org/dt#isDataTemplateFor"></see>
    /// </summary>
    let isDataTemplateFor = _prefix "isDataTemplateFor"
    /// <summary>
    /// reference to an external dictionary, which is a centralized repository of information about data such as meaning, relationships to other data, origin, usage and format
    /// <see href="https://w3id.org/dt#ExternalDictionaryReference"></see></summary>
    let ExternalDictionaryReference = _prefix "ExternalDictionaryReference"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasExternalDictionary"></see>
    /// </summary>
    let hasExternalDictionary = _prefix "hasExternalDictionary"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasExternalDictionaryProperty"></see>
    /// </summary>
    let hasExternalDictionaryProperty = _prefix "hasExternalDictionaryProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dt#ISBN"></see>
    /// </summary>
    let ISBN = _prefix "ISBN"
    /// <summary>
    /// publication that is consulted to find specific information, particularly in a technical or scientific domain
    /// <see href="https://w3id.org/dt#ReferenceDocument"></see></summary>
    let ReferenceDocument = _prefix "ReferenceDocument"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasReferenceDocument"></see>
    /// </summary>
    let hasReferenceDocument = _prefix "hasReferenceDocument"
    /// <summary>
    /// the physical quantity of a library component
    /// <see href="https://w3id.org/dt#PhysicalQuantity"></see></summary>
    let PhysicalQuantity = _prefix "PhysicalQuantity"
    /// <summary>
    /// the physical quantity of a library component
    /// <see href="https://w3id.org/dt#PredefinedValueItem"></see></summary>
    let PredefinedValueItem = _prefix "PredefinedValueItem"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasIndex"></see>
    /// </summary>
    let hasIndex = _prefix "hasIndex"
    /// <summary>
    /// list of predefined values
    /// <see href="https://w3id.org/dt#PredefinedValuesList"></see></summary>
    let PredefinedValuesList = _prefix "PredefinedValuesList"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasPredefinedValueItem"></see>
    /// </summary>
    let hasPredefinedValueItem = _prefix "hasPredefinedValueItem"
    /// <summary>
    /// inherent or acquired feature of an item
    /// <see href="https://w3id.org/dt#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasPredefinedValues"></see>
    /// </summary>
    let hasPredefinedValues = _prefix "hasPredefinedValues"
    /// <summary>
    ///   <see href="https://w3id.org/dt#author"></see>
    /// </summary>
    let author = _prefix "author"
    /// <summary>
    ///   <see href="https://w3id.org/dt#uri"></see>
    /// </summary>
    let uri = _prefix "uri"
    /// <summary>
    ///   <see href="https://w3id.org/dt#publisher"></see>
    /// </summary>
    let publisher = _prefix "publisher"
    /// <summary>
    ///   <see href="https://w3id.org/dt#dateOfPublication"></see>
    /// </summary>
    let dateOfPublication = _prefix "dateOfPublication"
    /// <summary>
    /// real scalar quantity, defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the second quantity to the first one as a number
    /// <see href="https://w3id.org/dt#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    ///   <see href="https://w3id.org/dt#hasExternalDictionaryReference"></see>
    /// </summary>
    let hasExternalDictionaryReference = _prefix "hasExternalDictionaryReference"
