namespace https.w3id.org.dt.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3dt =
    let _namespace_iri = Namespace_Iri w3dt |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:dt#ConstructionObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"object of interest in the context of a construction process"</para>
    /// labels<para>"Construction object"</para></remarks>
    /// <seealso href="https://w3id.org/dt#ConstructionObject">https://w3id.org/dt#ConstructionObject</seealso>
    let ConstructionObject = Prefixed_Name(w3dt, "ConstructionObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#DataTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"data structure used to describe the characteristics of construction objects"</para>
    /// labels<para>"Data template"</para></remarks>
    /// <seealso href="https://w3id.org/dt#DataTemplate">https://w3id.org/dt#DataTemplate</seealso>
    let DataTemplate = Prefixed_Name(w3dt, "DataTemplate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#ExternalDictionaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"reference to an external dictionary, which is a centralized repository of information about data such as meaning, relationships to other data, origin, usage and format"</para>
    /// labels<para>"External dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#ExternalDictionaryReference">https://w3id.org/dt#ExternalDictionaryReference</seealso>
    let ExternalDictionaryReference =
        Prefixed_Name(w3dt, "ExternalDictionaryReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#ISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ISBN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#ISBN">https://w3id.org/dt#ISBN</seealso>
    let ISBN = Prefixed_Name(w3dt, "ISBN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#LibraryComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"named and individually scheduled physical item and feature that might require management, such as inspection, maintenance, servicing or replacement, during the in-use phase"</para>
    /// labels<para>"Library component"</para></remarks>
    /// <seealso href="https://w3id.org/dt#LibraryComponent">https://w3id.org/dt#LibraryComponent</seealso>
    let LibraryComponent = Prefixed_Name(w3dt, "LibraryComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#PhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"the physical quantity of a library component"</para>
    /// labels<para>"Physical quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#PhysicalQuantity">https://w3id.org/dt#PhysicalQuantity</seealso>
    let PhysicalQuantity = Prefixed_Name(w3dt, "PhysicalQuantity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#PredefinedValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the physical quantity of a library component"</para>
    /// labels<para>"Predefined value item"</para></remarks>
    /// <seealso href="https://w3id.org/dt#PredefinedValueItem">https://w3id.org/dt#PredefinedValueItem</seealso>
    let PredefinedValueItem = Prefixed_Name(w3dt, "PredefinedValueItem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#PredefinedValuesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"list of predefined values"</para>
    /// labels<para>"Predefined value list"</para></remarks>
    /// <seealso href="https://w3id.org/dt#PredefinedValuesList">https://w3id.org/dt#PredefinedValuesList</seealso>
    let PredefinedValuesList =
        Prefixed_Name(w3dt, "PredefinedValuesList") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"inherent or acquired feature of an item"</para>
    /// labels<para>"Property"</para></remarks>
    /// <seealso href="https://w3id.org/dt#Property">https://w3id.org/dt#Property</seealso>
    let Property = Prefixed_Name(w3dt, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#ReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"publication that is consulted to find specific information, particularly in a technical or scientific domain"</para>
    /// labels<para>"Reference document"</para></remarks>
    /// <seealso href="https://w3id.org/dt#ReferenceDocument">https://w3id.org/dt#ReferenceDocument</seealso>
    let ReferenceDocument = Prefixed_Name(w3dt, "ReferenceDocument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#SetOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a set of properties that can be applied to a data template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Set of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#SetOfProperties">https://w3id.org/dt#SetOfProperties</seealso>
    let SetOfProperties = Prefixed_Name(w3dt, "SetOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"real scalar quantity, defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the second quantity to the first one as a number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit"</para></remarks>
    /// <seealso href="https://w3id.org/dt#Unit">https://w3id.org/dt#Unit</seealso>
    let Unit = Prefixed_Name(w3dt, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"author"</para></remarks>
    /// <seealso href="https://w3id.org/dt#author">https://w3id.org/dt#author</seealso>
    let author = Prefixed_Name(w3dt, "author") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#dateOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date of publication"</para></remarks>
    /// <seealso href="https://w3id.org/dt#dateOfPublication">https://w3id.org/dt#dateOfPublication</seealso>
    let dateOfPublication = Prefixed_Name(w3dt, "dateOfPublication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasExternalDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has external dictionary"</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasExternalDictionary">https://w3id.org/dt#hasExternalDictionary</seealso>
    let hasExternalDictionary =
        Prefixed_Name(w3dt, "hasExternalDictionary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasExternalDictionaryProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has external property reference"</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasExternalDictionaryProperty">https://w3id.org/dt#hasExternalDictionaryProperty</seealso>
    let hasExternalDictionaryProperty =
        Prefixed_Name(w3dt, "hasExternalDictionaryProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasExternalDictionaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"referenced external dictionary"</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasExternalDictionaryReference">https://w3id.org/dt#hasExternalDictionaryReference</seealso>
    let hasExternalDictionaryReference =
        Prefixed_Name(w3dt, "hasExternalDictionaryReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Index of the element in the enumeration"</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasIndex">https://w3id.org/dt#hasIndex</seealso>
    let hasIndex = Prefixed_Name(w3dt, "hasIndex") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasPredefinedValueItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has predefinded value item"</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasPredefinedValueItem">https://w3id.org/dt#hasPredefinedValueItem</seealso>
    let hasPredefinedValueItem =
        Prefixed_Name(w3dt, "hasPredefinedValueItem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasPredefinedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has predefined values"</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasPredefinedValues">https://w3id.org/dt#hasPredefinedValues</seealso>
    let hasPredefinedValues = Prefixed_Name(w3dt, "hasPredefinedValues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasProperty">https://w3id.org/dt#hasProperty</seealso>
    let hasProperty = Prefixed_Name(w3dt, "hasProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reference document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasReferenceDocument">https://w3id.org/dt#hasReferenceDocument</seealso>
    let hasReferenceDocument =
        Prefixed_Name(w3dt, "hasReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dt#hasSetOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has set of properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#hasSetOfProperties">https://w3id.org/dt#hasSetOfProperties</seealso>
    let hasSetOfProperties = Prefixed_Name(w3dt, "hasSetOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#isDataTemplateFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is data template for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#isDataTemplateFor">https://w3id.org/dt#isDataTemplateFor</seealso>
    let isDataTemplateFor = Prefixed_Name(w3dt, "isDataTemplateFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#publisher">https://w3id.org/dt#publisher</seealso>
    let publisher = Prefixed_Name(w3dt, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt#uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dt#uri">https://w3id.org/dt#uri</seealso>
    let uri = Prefixed_Name(w3dt, "uri") |> PrefixedName
