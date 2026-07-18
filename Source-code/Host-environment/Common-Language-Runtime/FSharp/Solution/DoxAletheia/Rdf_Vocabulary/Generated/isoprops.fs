namespace https.w3id.org.isoprops.hash

open DoxAletheia.Rdf_Vocabulary

module isoprops =
    let _namespace_name = "https://w3id.org/isoprops#"

    /// <summary>
    /// Represents the assignment of a property and a property state to a feature of interest (FOI).
    /// <see href="https://w3id.org/isoprops#AssignedProperty"></see></summary>
    let AssignedProperty =
        Namespaced_IRI.parse _namespace_name "AssignedProperty" |> NamespacedName

    /// <summary>
    /// Attaches a property reference to a property assignment
    /// <see href="https://w3id.org/isoprops#hasPropertyReference"></see></summary>
    let hasPropertyReference =
        Namespaced_IRI.parse _namespace_name "hasPropertyReference" |> NamespacedName

    /// <summary>
    /// Boundary limit  interval consisting of the the upper (maxValue) interval boundary
    /// <see href="https://w3id.org/isoprops#BoundaryLimitMax"></see></summary>
    let BoundaryLimitMax =
        Namespaced_IRI.parse _namespace_name "BoundaryLimitMax" |> NamespacedName

    /// <summary>
    /// A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless --&gt; http://qudt.org/vocab/unit/UNITLESS
    /// <see href="https://w3id.org/isoprops#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#Inclusive"></see>
    /// </summary>
    let Inclusive = Namespaced_IRI.parse _namespace_name "Inclusive" |> NamespacedName
    /// <summary>
    /// Code that can be used to identify the attribute
    /// <see href="https://w3id.org/isoprops#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    /// Boundary limit interval consisting of the lower(minValue) interval boundary
    /// <see href="https://w3id.org/isoprops#BoundaryLimitMin"></see></summary>
    let BoundaryLimitMin =
        Namespaced_IRI.parse _namespace_name "BoundaryLimitMin" |> NamespacedName

    /// <summary>
    /// Pair  (List of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/isoprops#BoundaryValue"></see></summary>
    let BoundaryValue =
        Namespaced_IRI.parse _namespace_name "BoundaryValue" |> NamespacedName

    /// <summary>
    /// Single Boundary value interval
    /// <see href="https://w3id.org/isoprops#hasBoundaryLimit"></see></summary>
    let hasBoundaryLimit =
        Namespaced_IRI.parse _namespace_name "hasBoundaryLimit" |> NamespacedName

    /// <summary>
    /// Specifies the category of the created property group
    /// <see href="https://w3id.org/isoprops#CategoryOfGroupOfProperties"></see></summary>
    let CategoryOfGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "CategoryOfGroupOfProperties" |> NamespacedName

    /// <summary>
    /// Collection enabling the properties to be prearranged or organized
    /// <see href="https://w3id.org/isoprops#GroupOfProperties"></see></summary>
    let GroupOfProperties =
        Namespaced_IRI.parse _namespace_name "GroupOfProperties" |> NamespacedName

    /// <summary>
    /// Country from where the requirement for this property/group of properties originated
    /// <see href="https://w3id.org/isoprops#CountryOfOrigin"></see></summary>
    let CountryOfOrigin =
        Namespaced_IRI.parse _namespace_name "CountryOfOrigin" |> NamespacedName

    /// <summary>
    /// Inherent or acquired feature of an item
    /// <see href="https://w3id.org/isoprops#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    /// Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in
    /// <see href="https://w3id.org/isoprops#CountryOfUse"></see></summary>
    let CountryOfUse =
        Namespaced_IRI.parse _namespace_name "CountryOfUse" |> NamespacedName

    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/isoprops#CreatorsLanguage"></see></summary>
    let CreatorsLanguage =
        Namespaced_IRI.parse _namespace_name "CreatorsLanguage" |> NamespacedName

    /// <summary>
    /// Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula
    /// <see href="https://w3id.org/isoprops#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName

    /// <summary>
    /// Date after when the property can be used
    /// <see href="https://w3id.org/isoprops#DateOfActivation"></see></summary>
    let DateOfActivation =
        Namespaced_IRI.parse _namespace_name "DateOfActivation" |> NamespacedName

    /// <summary>
    /// Date of validation of the property creation request by experts
    /// <see href="https://w3id.org/isoprops#DateOfCreation"></see></summary>
    let DateOfCreation =
        Namespaced_IRI.parse _namespace_name "DateOfCreation" |> NamespacedName

    /// <summary>
    /// Date of deactivation
    /// <see href="https://w3id.org/isoprops#DateOfDeactivation"></see></summary>
    let DateOfDeactivation =
        Namespaced_IRI.parse _namespace_name "DateOfDeactivation" |> NamespacedName

    /// <summary>
    /// Date of validation of the last change request by experts
    /// <see href="https://w3id.org/isoprops#DateOfLastChange"></see></summary>
    let DateOfLastChange =
        Namespaced_IRI.parse _namespace_name "DateOfLastChange" |> NamespacedName

    /// <summary>
    /// Date of revision
    /// <see href="https://w3id.org/isoprops#DateOfRevision"></see></summary>
    let DateOfRevision =
        Namespaced_IRI.parse _namespace_name "DateOfRevision" |> NamespacedName

    /// <summary>
    /// Date of version
    /// <see href="https://w3id.org/isoprops#DateOfVersion"></see></summary>
    let DateOfVersion =
        Namespaced_IRI.parse _namespace_name "DateOfVersion" |> NamespacedName

    /// <summary>
    /// Contains a defining value of an array in the form of a literal
    /// <see href="https://w3id.org/isoprops#DefiningValueItem"></see></summary>
    let DefiningValueItem =
        Namespaced_IRI.parse _namespace_name "DefiningValueItem" |> NamespacedName

    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/isoprops#DefiningValuesList"></see></summary>
    let DefiningValuesList =
        Namespaced_IRI.parse _namespace_name "DefiningValuesList" |> NamespacedName

    /// <summary>
    /// List of pairs (definition of the property/group of properties, language)
    /// <see href="https://w3id.org/isoprops#DefinitionInLanguage"></see></summary>
    let DefinitionInLanguage =
        Namespaced_IRI.parse _namespace_name "DefinitionInLanguage" |> NamespacedName

    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/isoprops#DeprecationExplanation"></see></summary>
    let DeprecationExplanation =
        Namespaced_IRI.parse _namespace_name "DeprecationExplanation" |> NamespacedName

    /// <summary>
    /// List of pairs (Description of the property, language)
    /// <see href="https://w3id.org/isoprops#DescriptionInLanguage"></see></summary>
    let DescriptionInLanguage =
        Namespaced_IRI.parse _namespace_name "DescriptionInLanguage" |> NamespacedName

    /// <summary>
    /// Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format
    /// <see href="https://w3id.org/isoprops#Dictionary"></see></summary>
    let Dictionary = Namespaced_IRI.parse _namespace_name "Dictionary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasDictionarySubset"></see>
    /// </summary>
    let hasDictionarySubset =
        Namespaced_IRI.parse _namespace_name "hasDictionarySubset" |> NamespacedName

    /// <summary>
    /// Publication that is consulted to find specific information, particularly in a technical or scientific domain
    /// <see href="https://w3id.org/isoprops#DictionaryReferenceDocument"></see></summary>
    let DictionaryReferenceDocument =
        Namespaced_IRI.parse _namespace_name "DictionaryReferenceDocument" |> NamespacedName

    /// <summary>
    /// Attaches a property group reference to a isoprops:ReferenceDocument
    /// <see href="https://w3id.org/isoprops#hasPropertyGroupReference"></see></summary>
    let hasPropertyGroupReference =
        Namespaced_IRI.parse _namespace_name "hasPropertyGroupReference" |> NamespacedName

    /// <summary>
    /// Defines a subset or subgrouping of a data catalog
    /// <see href="https://w3id.org/isoprops#DictionarySubset"></see></summary>
    let DictionarySubset =
        Namespaced_IRI.parse _namespace_name "DictionarySubset" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasDictionaryReferenceDocument"></see>
    /// </summary>
    let hasDictionaryReferenceDocument =
        Namespaced_IRI.parse _namespace_name "hasDictionaryReferenceDocument" |> NamespacedName

    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/isoprops#DigitalFormatItem"></see></summary>
    let DigitalFormatItem =
        Namespaced_IRI.parse _namespace_name "DigitalFormatItem" |> NamespacedName

    /// <summary>
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/isoprops#Precision"></see></summary>
    let Precision = Namespaced_IRI.parse _namespace_name "Precision" |> NamespacedName

    /// <summary>
    /// If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032
    /// <see href="https://w3id.org/isoprops#DynamicProperty"></see></summary>
    let DynamicProperty =
        Namespaced_IRI.parse _namespace_name "DynamicProperty" |> NamespacedName

    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#Encoding"></see></summary>
    let Encoding = Namespaced_IRI.parse _namespace_name "Encoding" |> NamespacedName

    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#TextFormatItem"></see></summary>
    let TextFormatItem =
        Namespaced_IRI.parse _namespace_name "TextFormatItem" |> NamespacedName

    /// <summary>
    /// List of pairs (example of the property, language)
    /// <see href="https://w3id.org/isoprops#ExampleInLanguage"></see></summary>
    let ExampleInLanguage =
        Namespaced_IRI.parse _namespace_name "ExampleInLanguage" |> NamespacedName

    /// <summary>
    /// Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/isoprops#ExternalDictionaryReference"></see></summary>
    let ExternalDictionaryReference =
        Namespaced_IRI.parse _namespace_name "ExternalDictionaryReference" |> NamespacedName

    /// <summary>
    /// Unique identifier generated using the algorithm denoted in RFC 4122
    /// <see href="https://w3id.org/isoprops#GloballyUniqueIdentifier"></see></summary>
    let GloballyUniqueIdentifier =
        Namespaced_IRI.parse _namespace_name "GloballyUniqueIdentifier" |> NamespacedName

    /// <summary>
    /// Documented geographical region of use of the group of properties
    /// <see href="https://w3id.org/isoprops#SubdivisionOfUse"></see></summary>
    let SubdivisionOfUse =
        Namespaced_IRI.parse _namespace_name "SubdivisionOfUse" |> NamespacedName

    /// <summary>
    /// Visual representation of the group of properties through sketches, photos, videos or other multimedia objects
    /// <see href="https://w3id.org/isoprops#VisualRepresentation"></see></summary>
    let VisualRepresentation =
        Namespaced_IRI.parse _namespace_name "VisualRepresentation" |> NamespacedName

    /// <summary>
    /// List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains
    /// <see href="https://w3id.org/isoprops#NameInLanguage"></see></summary>
    let NameInLanguage =
        Namespaced_IRI.parse _namespace_name "NameInLanguage" |> NamespacedName

    /// <summary>
    /// List of globally unique identifiers of the replaced groups of properties
    /// <see href="https://w3id.org/isoprops#replacesGroupOfProperties"></see></summary>
    let replacesGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "replacesGroupOfProperties" |> NamespacedName

    /// <summary>
    /// This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed
    /// <see href="https://w3id.org/isoprops#RevisionNumber"></see></summary>
    let RevisionNumber =
        Namespaced_IRI.parse _namespace_name "RevisionNumber" |> NamespacedName

    /// <summary>
    /// List of globally unique identifiers of the replacing groups of properties
    /// <see href="https://w3id.org/isoprops#isReplacedByGroupOfProperties"></see></summary>
    let isReplacedByGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "isReplacedByGroupOfProperties" |> NamespacedName

    /// <summary>
    /// List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/isoprops#hasExternalDictionaryReference"></see></summary>
    let hasExternalDictionaryReference =
        Namespaced_IRI.parse _namespace_name "hasExternalDictionaryReference" |> NamespacedName

    /// <summary>
    /// Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)
    /// <see href="https://w3id.org/isoprops#hasParentGroupOfProperties"></see></summary>
    let hasParentGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "hasParentGroupOfProperties" |> NamespacedName

    /// <summary>
    /// This version number allows tracking of major changes. Experts decide if a new version number must be applied
    /// <see href="https://w3id.org/isoprops#VersionNumber"></see></summary>
    let VersionNumber =
        Namespaced_IRI.parse _namespace_name "VersionNumber" |> NamespacedName

    /// <summary>
    /// For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit
    /// <see href="https://w3id.org/isoprops#Tolerance"></see></summary>
    let Tolerance = Namespaced_IRI.parse _namespace_name "Tolerance" |> NamespacedName
    /// <summary>
    /// Status of the property during its life cycle
    /// <see href="https://w3id.org/isoprops#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen
    /// Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications
    /// <see href="https://w3id.org/isoprops#MethodOfMeasurement"></see></summary>
    let MethodOfMeasurement =
        Namespaced_IRI.parse _namespace_name "MethodOfMeasurement" |> NamespacedName

    /// <summary>
    /// In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)
    /// <see href="https://w3id.org/isoprops#NameOfTheDefiningValues"></see></summary>
    let NameOfTheDefiningValues =
        Namespaced_IRI.parse _namespace_name "NameOfTheDefiningValues" |> NamespacedName

    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#NumberOfCharacters"></see></summary>
    let NumberOfCharacters =
        Namespaced_IRI.parse _namespace_name "NumberOfCharacters" |> NamespacedName

    /// <summary>
    /// List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations
    /// <see href="https://w3id.org/isoprops#PhysicalQuantity"></see></summary>
    let PhysicalQuantity =
        Namespaced_IRI.parse _namespace_name "PhysicalQuantity" |> NamespacedName

    /// <summary>
    /// Possible value for the property and language
    /// Values can be string or numbers
    /// <see href="https://w3id.org/isoprops#PossibleValues"></see></summary>
    let PossibleValues =
        Namespaced_IRI.parse _namespace_name "PossibleValues" |> NamespacedName

    /// <summary>
    /// List of pairs (possible value for the property and language)
    /// Values can be string or numbers
    /// <see href="https://w3id.org/isoprops#hasPossibleValues"></see></summary>
    let hasPossibleValues =
        Namespaced_IRI.parse _namespace_name "hasPossibleValues" |> NamespacedName

    /// <summary>
    /// List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties
    /// <see href="https://w3id.org/isoprops#hasConnectedProperty"></see></summary>
    let hasConnectedProperty =
        Namespaced_IRI.parse _namespace_name "hasConnectedProperty" |> NamespacedName

    /// <summary>
    /// Globally unique identifier of the replaced property (or properties)
    /// <see href="https://w3id.org/isoprops#replacesProperties"></see></summary>
    let replacesProperties =
        Namespaced_IRI.parse _namespace_name "replacesProperties" |> NamespacedName

    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/isoprops#hasDigitalFormat"></see></summary>
    let hasDigitalFormat =
        Namespaced_IRI.parse _namespace_name "hasDigitalFormat" |> NamespacedName

    /// <summary>
    /// List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without" --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations
    /// <see href="https://w3id.org/isoprops#hasPhysicalQuantity"></see></summary>
    let hasPhysicalQuantity =
        Namespaced_IRI.parse _namespace_name "hasPhysicalQuantity" |> NamespacedName

    /// <summary>
    /// List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached
    /// <see href="https://w3id.org/isoprops#hasGroupOfProperties"></see></summary>
    let hasGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "hasGroupOfProperties" |> NamespacedName

    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#hasTextFormat"></see></summary>
    let hasTextFormat =
        Namespaced_IRI.parse _namespace_name "hasTextFormat" |> NamespacedName

    /// <summary>
    /// Pair (list of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/isoprops#hasBoundary"></see></summary>
    let hasBoundary =
        Namespaced_IRI.parse _namespace_name "hasBoundary" |> NamespacedName

    /// <summary>
    /// List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/isoprops#hasSymbolsOfTheProperty"></see></summary>
    let hasSymbolsOfTheProperty =
        Namespaced_IRI.parse _namespace_name "hasSymbolsOfTheProperty" |> NamespacedName

    /// <summary>
    /// Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/isoprops#SymbolOfTheProperty"></see></summary>
    let SymbolOfTheProperty =
        Namespaced_IRI.parse _namespace_name "SymbolOfTheProperty" |> NamespacedName

    /// <summary>
    /// List of GUIDS of properties which are parameters of the function for a dynamic property
    /// <see href="https://w3id.org/isoprops#hasParameterOfTheDynamicProperty"></see></summary>
    let hasParameterOfTheDynamicProperty =
        Namespaced_IRI.parse _namespace_name "hasParameterOfTheDynamicProperty" |> NamespacedName

    /// <summary>
    /// Globally unique identifier (attribute PA001) of the replacing property (or properties)
    /// <see href="https://w3id.org/isoprops#isReplacedByProperty"></see></summary>
    let isReplacedByProperty =
        Namespaced_IRI.parse _namespace_name "isReplacedByProperty" |> NamespacedName

    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/isoprops#hasDefiningValue"></see></summary>
    let hasDefiningValue =
        Namespaced_IRI.parse _namespace_name "hasDefiningValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/isoprops#Symbol"></see>
    /// </summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName

    /// <summary>
    /// Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.
    /// <see href="https://w3id.org/isoprops#hasGivenGroupOfProperties"></see></summary>
    let hasGivenGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "hasGivenGroupOfProperties" |> NamespacedName

    /// <summary>
    /// Contains a defining value of an array
    /// <see href="https://w3id.org/isoprops#hasDefiningValueItem"></see></summary>
    let hasDefiningValueItem =
        Namespaced_IRI.parse _namespace_name "hasDefiningValueItem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasExternalDictionary"></see>
    /// </summary>
    let hasExternalDictionary =
        Namespaced_IRI.parse _namespace_name "hasExternalDictionary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasExternalDictionaryProperty"></see>
    /// </summary>
    let hasExternalDictionaryProperty =
        Namespaced_IRI.parse _namespace_name "hasExternalDictionaryProperty" |> NamespacedName

    /// <summary>
    /// Attaches a property to a feature of interest (FOI)
    /// <see href="https://w3id.org/isoprops#hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/isoprops#ReferenceDocument"></see>
    /// </summary>
    let ReferenceDocument =
        Namespaced_IRI.parse _namespace_name "ReferenceDocument" |> NamespacedName

    /// <summary>
    /// List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties
    /// <see href="https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Namespaced_IRI.parse _namespace_name "hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries" |> NamespacedName
