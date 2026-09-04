#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dt =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dt#" "dt"
    /// <summary>
    ///   <para>rdfs:label : Construction object</para>
    ///   <para>rdfs:comment : object of interest in the context of a construction process</para>
    ///   <a href="https://w3id.org/dt#ConstructionObject">dt:ConstructionObject</a>
    /// </summary>
    let ConstructionObject = _prefixId.prefix "ConstructionObject"
    /// <summary>
    ///   <para>rdfs:label : Data template</para>
    ///   <para>rdfs:comment : data structure used to describe the characteristics of construction objects</para>
    ///   <a href="https://w3id.org/dt#DataTemplate">dt:DataTemplate</a>
    /// </summary>
    let DataTemplate = _prefixId.prefix "DataTemplate"
    /// <summary>
    ///   <para>rdfs:label : External dictionary^^xsd:string</para>
    ///   <para>rdfs:comment : reference to an external dictionary, which is a centralized repository of information about data such as meaning, relationships to other data, origin, usage and format</para>
    ///   <a href="https://w3id.org/dt#ExternalDictionaryReference">dt:ExternalDictionaryReference</a>
    /// </summary>
    let ExternalDictionaryReference = _prefixId.prefix "ExternalDictionaryReference"
    /// <summary>
    ///   <para>rdfs:label : ISBN^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#ISBN">dt:ISBN</a>
    /// </summary>
    let ISBN = _prefixId.prefix "ISBN"
    /// <summary>
    ///   <para>rdfs:label : Library component</para>
    ///   <para>rdfs:comment : named and individually scheduled physical item and feature that might require management, such as inspection, maintenance, servicing or replacement, during the in-use phase</para>
    ///   <a href="https://w3id.org/dt#LibraryComponent">dt:LibraryComponent</a>
    /// </summary>
    let LibraryComponent = _prefixId.prefix "LibraryComponent"
    /// <summary>
    ///   <para>rdfs:label : Physical quantity^^xsd:string</para>
    ///   <para>rdfs:comment : the physical quantity of a library component</para>
    ///   <a href="https://w3id.org/dt#PhysicalQuantity">dt:PhysicalQuantity</a>
    /// </summary>
    let PhysicalQuantity = _prefixId.prefix "PhysicalQuantity"
    /// <summary>
    ///   <para>rdfs:label : Predefined value item</para>
    ///   <para>rdfs:comment : the physical quantity of a library component</para>
    ///   <a href="https://w3id.org/dt#PredefinedValueItem">dt:PredefinedValueItem</a>
    /// </summary>
    let PredefinedValueItem = _prefixId.prefix "PredefinedValueItem"
    /// <summary>
    ///   <para>rdfs:label : Predefined value list</para>
    ///   <para>rdfs:comment : list of predefined values</para>
    ///   <a href="https://w3id.org/dt#PredefinedValuesList">dt:PredefinedValuesList</a>
    /// </summary>
    let PredefinedValuesList = _prefixId.prefix "PredefinedValuesList"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : inherent or acquired feature of an item</para>
    ///   <a href="https://w3id.org/dt#Property">dt:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:comment : publication that is consulted to find specific information, particularly in a technical or scientific domain</para>
    ///   <para>rdfs:label : Reference document</para>
    ///   <a href="https://w3id.org/dt#ReferenceDocument">dt:ReferenceDocument</a>
    /// </summary>
    let ReferenceDocument = _prefixId.prefix "ReferenceDocument"
    /// <summary>
    ///   <para>rdfs:label : Set of properties^^xsd:string</para>
    ///   <para>rdfs:comment : a set of properties that can be applied to a data template^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#SetOfProperties">dt:SetOfProperties</a>
    /// </summary>
    let SetOfProperties = _prefixId.prefix "SetOfProperties"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:comment : real scalar quantity, defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the second quantity to the first one as a number^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#Unit">dt:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : author</para>
    ///   <a href="https://w3id.org/dt#author">dt:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : date of publication</para>
    ///   <a href="https://w3id.org/dt#dateOfPublication">dt:dateOfPublication</a>
    /// </summary>
    let dateOfPublication = _prefixId.prefix "dateOfPublication"
    /// <summary>
    ///   <para>rdfs:label : has external dictionary</para>
    ///   <a href="https://w3id.org/dt#hasExternalDictionary">dt:hasExternalDictionary</a>
    /// </summary>
    let hasExternalDictionary = _prefixId.prefix "hasExternalDictionary"
    /// <summary>
    ///   <para>rdfs:label : has external property reference</para>
    ///   <a href="https://w3id.org/dt#hasExternalDictionaryProperty">dt:hasExternalDictionaryProperty</a>
    /// </summary>
    let hasExternalDictionaryProperty = _prefixId.prefix "hasExternalDictionaryProperty"

    /// <summary>
    ///   <para>rdfs:label : referenced external dictionary</para>
    ///   <a href="https://w3id.org/dt#hasExternalDictionaryReference">dt:hasExternalDictionaryReference</a>
    /// </summary>
    let hasExternalDictionaryReference =
        _prefixId.prefix "hasExternalDictionaryReference"

    /// <summary>
    ///   <para>rdfs:label : Index of the element in the enumeration</para>
    ///   <a href="https://w3id.org/dt#hasIndex">dt:hasIndex</a>
    /// </summary>
    let hasIndex = _prefixId.prefix "hasIndex"
    /// <summary>
    ///   <para>rdfs:label : has predefinded value item</para>
    ///   <a href="https://w3id.org/dt#hasPredefinedValueItem">dt:hasPredefinedValueItem</a>
    /// </summary>
    let hasPredefinedValueItem = _prefixId.prefix "hasPredefinedValueItem"
    /// <summary>
    ///   <para>rdfs:label : has predefined values</para>
    ///   <a href="https://w3id.org/dt#hasPredefinedValues">dt:hasPredefinedValues</a>
    /// </summary>
    let hasPredefinedValues = _prefixId.prefix "hasPredefinedValues"
    /// <summary>
    ///   <para>rdfs:label : has property^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#hasProperty">dt:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has reference document^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#hasReferenceDocument">dt:hasReferenceDocument</a>
    /// </summary>
    let hasReferenceDocument = _prefixId.prefix "hasReferenceDocument"
    /// <summary>
    ///   <para>rdfs:label : has set of properties^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#hasSetOfProperties">dt:hasSetOfProperties</a>
    /// </summary>
    let hasSetOfProperties = _prefixId.prefix "hasSetOfProperties"
    /// <summary>
    ///   <para>rdfs:label : is data template for^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#isDataTemplateFor">dt:isDataTemplateFor</a>
    /// </summary>
    let isDataTemplateFor = _prefixId.prefix "isDataTemplateFor"
    /// <summary>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#publisher">dt:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : uri^^xsd:string</para>
    ///   <a href="https://w3id.org/dt#uri">dt:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
