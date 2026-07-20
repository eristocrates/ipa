namespace https.w3id.org.isoprops.hash

open DoxAletheia

module isoprops =
    let _namespace_name = "https://w3id.org/isoprops#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents the assignment of a property and a property state to a feature of interest (FOI).
    /// <see href="https://w3id.org/isoprops#AssignedProperty"></see></summary>
    let AssignedProperty = _prefix "AssignedProperty"
    /// <summary>
    /// Attaches a property reference to a property assignment
    /// <see href="https://w3id.org/isoprops#hasPropertyReference"></see></summary>
    let hasPropertyReference = _prefix "hasPropertyReference"
    /// <summary>
    /// Boundary limit  interval consisting of the the upper (maxValue) interval boundary
    /// <see href="https://w3id.org/isoprops#BoundaryLimitMax"></see></summary>
    let BoundaryLimitMax = _prefix "BoundaryLimitMax"
    /// <summary>
    /// A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless --&gt; http://qudt.org/vocab/unit/UNITLESS
    /// <see href="https://w3id.org/isoprops#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#Inclusive"></see>
    /// </summary>
    let Inclusive = _prefix "Inclusive"
    /// <summary>
    /// Code that can be used to identify the attribute
    /// <see href="https://w3id.org/isoprops#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// Boundary limit interval consisting of the lower(minValue) interval boundary
    /// <see href="https://w3id.org/isoprops#BoundaryLimitMin"></see></summary>
    let BoundaryLimitMin = _prefix "BoundaryLimitMin"
    /// <summary>
    /// Pair  (List of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/isoprops#BoundaryValue"></see></summary>
    let BoundaryValue = _prefix "BoundaryValue"
    /// <summary>
    /// Single Boundary value interval
    /// <see href="https://w3id.org/isoprops#hasBoundaryLimit"></see></summary>
    let hasBoundaryLimit = _prefix "hasBoundaryLimit"
    /// <summary>
    /// Specifies the category of the created property group
    /// <see href="https://w3id.org/isoprops#CategoryOfGroupOfProperties"></see></summary>
    let CategoryOfGroupOfProperties = _prefix "CategoryOfGroupOfProperties"
    /// <summary>
    /// Collection enabling the properties to be prearranged or organized
    /// <see href="https://w3id.org/isoprops#GroupOfProperties"></see></summary>
    let GroupOfProperties = _prefix "GroupOfProperties"
    /// <summary>
    /// Country from where the requirement for this property/group of properties originated
    /// <see href="https://w3id.org/isoprops#CountryOfOrigin"></see></summary>
    let CountryOfOrigin = _prefix "CountryOfOrigin"
    /// <summary>
    /// Inherent or acquired feature of an item
    /// <see href="https://w3id.org/isoprops#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in
    /// <see href="https://w3id.org/isoprops#CountryOfUse"></see></summary>
    let CountryOfUse = _prefix "CountryOfUse"
    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/isoprops#CreatorsLanguage"></see></summary>
    let CreatorsLanguage = _prefix "CreatorsLanguage"
    /// <summary>
    /// Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula
    /// <see href="https://w3id.org/isoprops#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// Date after when the property can be used
    /// <see href="https://w3id.org/isoprops#DateOfActivation"></see></summary>
    let DateOfActivation = _prefix "DateOfActivation"
    /// <summary>
    /// Date of validation of the property creation request by experts
    /// <see href="https://w3id.org/isoprops#DateOfCreation"></see></summary>
    let DateOfCreation = _prefix "DateOfCreation"
    /// <summary>
    /// Date of deactivation
    /// <see href="https://w3id.org/isoprops#DateOfDeactivation"></see></summary>
    let DateOfDeactivation = _prefix "DateOfDeactivation"
    /// <summary>
    /// Date of validation of the last change request by experts
    /// <see href="https://w3id.org/isoprops#DateOfLastChange"></see></summary>
    let DateOfLastChange = _prefix "DateOfLastChange"
    /// <summary>
    /// Date of revision
    /// <see href="https://w3id.org/isoprops#DateOfRevision"></see></summary>
    let DateOfRevision = _prefix "DateOfRevision"
    /// <summary>
    /// Date of version
    /// <see href="https://w3id.org/isoprops#DateOfVersion"></see></summary>
    let DateOfVersion = _prefix "DateOfVersion"
    /// <summary>
    /// Contains a defining value of an array in the form of a literal
    /// <see href="https://w3id.org/isoprops#DefiningValueItem"></see></summary>
    let DefiningValueItem = _prefix "DefiningValueItem"
    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/isoprops#DefiningValuesList"></see></summary>
    let DefiningValuesList = _prefix "DefiningValuesList"
    /// <summary>
    /// List of pairs (definition of the property/group of properties, language)
    /// <see href="https://w3id.org/isoprops#DefinitionInLanguage"></see></summary>
    let DefinitionInLanguage = _prefix "DefinitionInLanguage"
    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/isoprops#DeprecationExplanation"></see></summary>
    let DeprecationExplanation = _prefix "DeprecationExplanation"
    /// <summary>
    /// List of pairs (Description of the property, language)
    /// <see href="https://w3id.org/isoprops#DescriptionInLanguage"></see></summary>
    let DescriptionInLanguage = _prefix "DescriptionInLanguage"
    /// <summary>
    /// Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format
    /// <see href="https://w3id.org/isoprops#Dictionary"></see></summary>
    let Dictionary = _prefix "Dictionary"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasDictionarySubset"></see>
    /// </summary>
    let hasDictionarySubset = _prefix "hasDictionarySubset"
    /// <summary>
    /// Publication that is consulted to find specific information, particularly in a technical or scientific domain
    /// <see href="https://w3id.org/isoprops#DictionaryReferenceDocument"></see></summary>
    let DictionaryReferenceDocument = _prefix "DictionaryReferenceDocument"
    /// <summary>
    /// Attaches a property group reference to a isoprops:ReferenceDocument
    /// <see href="https://w3id.org/isoprops#hasPropertyGroupReference"></see></summary>
    let hasPropertyGroupReference = _prefix "hasPropertyGroupReference"
    /// <summary>
    /// Defines a subset or subgrouping of a data catalog
    /// <see href="https://w3id.org/isoprops#DictionarySubset"></see></summary>
    let DictionarySubset = _prefix "DictionarySubset"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasDictionaryReferenceDocument"></see>
    /// </summary>
    let hasDictionaryReferenceDocument = _prefix "hasDictionaryReferenceDocument"
    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/isoprops#DigitalFormatItem"></see></summary>
    let DigitalFormatItem = _prefix "DigitalFormatItem"
    /// <summary>
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/isoprops#Precision"></see></summary>
    let Precision = _prefix "Precision"
    /// <summary>
    /// If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032
    /// <see href="https://w3id.org/isoprops#DynamicProperty"></see></summary>
    let DynamicProperty = _prefix "DynamicProperty"
    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#Encoding"></see></summary>
    let Encoding = _prefix "Encoding"
    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#TextFormatItem"></see></summary>
    let TextFormatItem = _prefix "TextFormatItem"
    /// <summary>
    /// List of pairs (example of the property, language)
    /// <see href="https://w3id.org/isoprops#ExampleInLanguage"></see></summary>
    let ExampleInLanguage = _prefix "ExampleInLanguage"
    /// <summary>
    /// Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/isoprops#ExternalDictionaryReference"></see></summary>
    let ExternalDictionaryReference = _prefix "ExternalDictionaryReference"
    /// <summary>
    /// Unique identifier generated using the algorithm denoted in RFC 4122
    /// <see href="https://w3id.org/isoprops#GloballyUniqueIdentifier"></see></summary>
    let GloballyUniqueIdentifier = _prefix "GloballyUniqueIdentifier"
    /// <summary>
    /// Documented geographical region of use of the group of properties
    /// <see href="https://w3id.org/isoprops#SubdivisionOfUse"></see></summary>
    let SubdivisionOfUse = _prefix "SubdivisionOfUse"
    /// <summary>
    /// Visual representation of the group of properties through sketches, photos, videos or other multimedia objects
    /// <see href="https://w3id.org/isoprops#VisualRepresentation"></see></summary>
    let VisualRepresentation = _prefix "VisualRepresentation"
    /// <summary>
    /// List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains
    /// <see href="https://w3id.org/isoprops#NameInLanguage"></see></summary>
    let NameInLanguage = _prefix "NameInLanguage"
    /// <summary>
    /// List of globally unique identifiers of the replaced groups of properties
    /// <see href="https://w3id.org/isoprops#replacesGroupOfProperties"></see></summary>
    let replacesGroupOfProperties = _prefix "replacesGroupOfProperties"
    /// <summary>
    /// This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed
    /// <see href="https://w3id.org/isoprops#RevisionNumber"></see></summary>
    let RevisionNumber = _prefix "RevisionNumber"
    /// <summary>
    /// List of globally unique identifiers of the replacing groups of properties
    /// <see href="https://w3id.org/isoprops#isReplacedByGroupOfProperties"></see></summary>
    let isReplacedByGroupOfProperties = _prefix "isReplacedByGroupOfProperties"
    /// <summary>
    /// List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/isoprops#hasExternalDictionaryReference"></see></summary>
    let hasExternalDictionaryReference = _prefix "hasExternalDictionaryReference"
    /// <summary>
    /// Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)
    /// <see href="https://w3id.org/isoprops#hasParentGroupOfProperties"></see></summary>
    let hasParentGroupOfProperties = _prefix "hasParentGroupOfProperties"
    /// <summary>
    /// This version number allows tracking of major changes. Experts decide if a new version number must be applied
    /// <see href="https://w3id.org/isoprops#VersionNumber"></see></summary>
    let VersionNumber = _prefix "VersionNumber"
    /// <summary>
    /// For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit
    /// <see href="https://w3id.org/isoprops#Tolerance"></see></summary>
    let Tolerance = _prefix "Tolerance"
    /// <summary>
    /// Status of the property during its life cycle
    /// <see href="https://w3id.org/isoprops#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen
    /// Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications
    /// <see href="https://w3id.org/isoprops#MethodOfMeasurement"></see></summary>
    let MethodOfMeasurement = _prefix "MethodOfMeasurement"
    /// <summary>
    /// In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)
    /// <see href="https://w3id.org/isoprops#NameOfTheDefiningValues"></see></summary>
    let NameOfTheDefiningValues = _prefix "NameOfTheDefiningValues"
    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#NumberOfCharacters"></see></summary>
    let NumberOfCharacters = _prefix "NumberOfCharacters"
    /// <summary>
    /// List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations
    /// <see href="https://w3id.org/isoprops#PhysicalQuantity"></see></summary>
    let PhysicalQuantity = _prefix "PhysicalQuantity"
    /// <summary>
    /// Possible value for the property and language
    /// Values can be string or numbers
    /// <see href="https://w3id.org/isoprops#PossibleValues"></see></summary>
    let PossibleValues = _prefix "PossibleValues"
    /// <summary>
    /// List of pairs (possible value for the property and language)
    /// Values can be string or numbers
    /// <see href="https://w3id.org/isoprops#hasPossibleValues"></see></summary>
    let hasPossibleValues = _prefix "hasPossibleValues"
    /// <summary>
    /// List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties
    /// <see href="https://w3id.org/isoprops#hasConnectedProperty"></see></summary>
    let hasConnectedProperty = _prefix "hasConnectedProperty"
    /// <summary>
    /// Globally unique identifier of the replaced property (or properties)
    /// <see href="https://w3id.org/isoprops#replacesProperties"></see></summary>
    let replacesProperties = _prefix "replacesProperties"
    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/isoprops#hasDigitalFormat"></see></summary>
    let hasDigitalFormat = _prefix "hasDigitalFormat"
    /// <summary>
    /// List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without" --&gt; http://qudt.org/vocab/quantitykind/Dimensionless
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations
    /// <see href="https://w3id.org/isoprops#hasPhysicalQuantity"></see></summary>
    let hasPhysicalQuantity = _prefix "hasPhysicalQuantity"
    /// <summary>
    /// List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached
    /// <see href="https://w3id.org/isoprops#hasGroupOfProperties"></see></summary>
    let hasGroupOfProperties = _prefix "hasGroupOfProperties"
    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/isoprops#hasTextFormat"></see></summary>
    let hasTextFormat = _prefix "hasTextFormat"
    /// <summary>
    /// Pair (list of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/isoprops#hasBoundary"></see></summary>
    let hasBoundary = _prefix "hasBoundary"
    /// <summary>
    /// List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/isoprops#hasSymbolsOfTheProperty"></see></summary>
    let hasSymbolsOfTheProperty = _prefix "hasSymbolsOfTheProperty"
    /// <summary>
    /// Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/isoprops#SymbolOfTheProperty"></see></summary>
    let SymbolOfTheProperty = _prefix "SymbolOfTheProperty"
    /// <summary>
    /// List of GUIDS of properties which are parameters of the function for a dynamic property
    /// <see href="https://w3id.org/isoprops#hasParameterOfTheDynamicProperty"></see></summary>
    let hasParameterOfTheDynamicProperty = _prefix "hasParameterOfTheDynamicProperty"
    /// <summary>
    /// Globally unique identifier (attribute PA001) of the replacing property (or properties)
    /// <see href="https://w3id.org/isoprops#isReplacedByProperty"></see></summary>
    let isReplacedByProperty = _prefix "isReplacedByProperty"
    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/isoprops#hasDefiningValue"></see></summary>
    let hasDefiningValue = _prefix "hasDefiningValue"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#Symbol"></see>
    /// </summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    /// Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.
    /// <see href="https://w3id.org/isoprops#hasGivenGroupOfProperties"></see></summary>
    let hasGivenGroupOfProperties = _prefix "hasGivenGroupOfProperties"
    /// <summary>
    /// Contains a defining value of an array
    /// <see href="https://w3id.org/isoprops#hasDefiningValueItem"></see></summary>
    let hasDefiningValueItem = _prefix "hasDefiningValueItem"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasExternalDictionary"></see>
    /// </summary>
    let hasExternalDictionary = _prefix "hasExternalDictionary"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#hasExternalDictionaryProperty"></see>
    /// </summary>
    let hasExternalDictionaryProperty = _prefix "hasExternalDictionaryProperty"
    /// <summary>
    /// Attaches a property to a feature of interest (FOI)
    /// <see href="https://w3id.org/isoprops#hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    ///   <see href="https://w3id.org/isoprops#ReferenceDocument"></see>
    /// </summary>
    let ReferenceDocument = _prefix "ReferenceDocument"

    /// <summary>
    /// List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties
    /// <see href="https://w3id.org/isoprops#hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        _prefix "hasRelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"
