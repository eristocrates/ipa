namespace https.w3id.org.iddo.hash

open DoxAletheia

module iddo =
    let _namespace_name = "https://w3id.org/iddo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Defines a subset or subgrouping of a data catalog
    /// <see href="https://w3id.org/iddo#DictionarySubset"></see></summary>
    let DictionarySubset = _prefix "DictionarySubset"
    /// <summary>
    ///   <see href="https://w3id.org/iddo#hasDictionaryReferenceDocument"></see>
    /// </summary>
    let hasDictionaryReferenceDocument = _prefix "hasDictionaryReferenceDocument"
    /// <summary>
    /// Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format
    /// <see href="https://w3id.org/iddo#Dictionary"></see></summary>
    let Dictionary = _prefix "Dictionary"
    /// <summary>
    ///   <see href="https://w3id.org/iddo#hasDictionarySubset"></see>
    /// </summary>
    let hasDictionarySubset = _prefix "hasDictionarySubset"
    /// <summary>
    /// Collection enabling the properties to be prearranged or organized
    /// <see href="https://w3id.org/iddo#GroupOfProperties"></see></summary>
    let GroupOfProperties = _prefix "GroupOfProperties"
    /// <summary>
    /// Specifies the category of the created property group
    /// <see href="https://w3id.org/iddo#CategoryOfGroupOfProperties"></see></summary>
    let CategoryOfGroupOfProperties = _prefix "CategoryOfGroupOfProperties"
    /// <summary>
    /// Country from where the requirement for this property/group of properties originated
    /// <see href="https://w3id.org/iddo#CountryOfOrigin"></see></summary>
    let CountryOfOrigin = _prefix "CountryOfOrigin"
    /// <summary>
    /// Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in
    /// <see href="https://w3id.org/iddo#CountryOfUse"></see></summary>
    let CountryOfUse = _prefix "CountryOfUse"
    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/iddo#CreatorsLanguage"></see></summary>
    let CreatorsLanguage = _prefix "CreatorsLanguage"
    /// <summary>
    /// Date after when the property can be used
    /// <see href="https://w3id.org/iddo#DateOfActivation"></see></summary>
    let DateOfActivation = _prefix "DateOfActivation"
    /// <summary>
    /// Date of validation of the property creation request by experts
    /// <see href="https://w3id.org/iddo#DateOfCreation"></see></summary>
    let DateOfCreation = _prefix "DateOfCreation"
    /// <summary>
    /// Date of validation of the last change request by experts
    /// <see href="https://w3id.org/iddo#DateOfLastChange"></see></summary>
    let DateOfLastChange = _prefix "DateOfLastChange"
    /// <summary>
    /// Date of revision
    /// <see href="https://w3id.org/iddo#DateOfRevision"></see></summary>
    let DateOfRevision = _prefix "DateOfRevision"
    /// <summary>
    /// Date of version
    /// <see href="https://w3id.org/iddo#DateOfVersion"></see></summary>
    let DateOfVersion = _prefix "DateOfVersion"
    /// <summary>
    /// List of pairs (definition of the property/group of properties, language)
    /// <see href="https://w3id.org/iddo#DefinitionInLanguage"></see></summary>
    let DefinitionInLanguage = _prefix "DefinitionInLanguage"
    /// <summary>
    /// Unique identifier generated using the algorithm denoted in RFC 4122
    /// <see href="https://w3id.org/iddo#GloballyUniqueIdentifier"></see></summary>
    let GloballyUniqueIdentifier = _prefix "GloballyUniqueIdentifier"
    /// <summary>
    /// List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains
    /// <see href="https://w3id.org/iddo#NameInLanguage"></see></summary>
    let NameInLanguage = _prefix "NameInLanguage"
    /// <summary>
    /// This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed
    /// <see href="https://w3id.org/iddo#RevisionNumber"></see></summary>
    let RevisionNumber = _prefix "RevisionNumber"
    /// <summary>
    /// Status of the property during its life cycle
    /// <see href="https://w3id.org/iddo#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// This version number allows tracking of major changes. Experts decide if a new version number must be applied
    /// <see href="https://w3id.org/iddo#VersionNumber"></see></summary>
    let VersionNumber = _prefix "VersionNumber"
    /// <summary>
    /// Inherent or acquired feature of an item
    /// <see href="https://w3id.org/iddo#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached
    /// <see href="https://w3id.org/iddo#GroupsOfProperties"></see></summary>
    let GroupsOfProperties = _prefix "GroupsOfProperties"
    /// <summary>
    /// Publication that is consulted to find specific information, particularly in a technical or scientific domain
    /// <see href="https://w3id.org/iddo#DictionaryReferenceDocument"></see></summary>
    let DictionaryReferenceDocument = _prefix "DictionaryReferenceDocument"
    /// <summary>
    /// Attaches a property group reference to a iddo:ReferenceDocument
    /// <see href="https://w3id.org/iddo#hasPropertyGroupReference"></see></summary>
    let hasPropertyGroupReference = _prefix "hasPropertyGroupReference"
    /// <summary>
    ///   <see href="https://w3id.org/iddo#GroupOfProperties_1"></see>
    /// </summary>
    let GroupOfProperties_1 = _prefix "GroupOfProperties_1"
    /// <summary>
    /// Represents the assignment of a property and a property state to a feature of interest (FOI).
    /// <see href="https://w3id.org/iddo#AssignedProperty"></see></summary>
    let AssignedProperty = _prefix "AssignedProperty"
    /// <summary>
    /// Attaches a property reference to a property assignment
    /// <see href="https://w3id.org/iddo#hasPropertyReference"></see></summary>
    let hasPropertyReference = _prefix "hasPropertyReference"
    /// <summary>
    /// Represents the validation using SHACL of the assignment of a property and a property state to a feature of interest (FOI).
    /// <see href="https://w3id.org/iddo#AssignedPropertyShape"></see></summary>
    let AssignedPropertyShape = _prefix "AssignedPropertyShape"
    /// <summary>
    /// Attaches a property to a feature of interest (FOI)
    /// <see href="https://w3id.org/iddo#hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// Single Boundary value interval
    /// <see href="https://w3id.org/iddo#BoundaryValue"></see></summary>
    let BoundaryValue = _prefix "BoundaryValue"
    /// <summary>
    /// Pair  (List of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/iddo#BoundaryValuesList"></see></summary>
    let BoundaryValuesList = _prefix "BoundaryValuesList"
    /// <summary>
    /// Boundary value interval consisting of the lower(minValue) and the upper(maxValue) interval boundary
    /// <see href="https://w3id.org/iddo#BoundaryValueItem"></see></summary>
    let BoundaryValueItem = _prefix "BoundaryValueItem"
    /// <summary>
    /// Code that can be used to identify the attribute
    /// <see href="https://w3id.org/iddo#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// Pair (list of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/iddo#BoundaryValues"></see></summary>
    let BoundaryValues = _prefix "BoundaryValues"
    /// <summary>
    /// Unit of measurement for the digital text type
    /// <see href="https://w3id.org/iddo#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties
    /// <see href="https://w3id.org/iddo#ConnectedProperties"></see></summary>
    let ConnectedProperties = _prefix "ConnectedProperties"
    /// <summary>
    /// Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula
    /// <see href="https://w3id.org/iddo#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// Date of deactivation
    /// <see href="https://w3id.org/iddo#DateOfDeactivation"></see></summary>
    let DateOfDeactivation = _prefix "DateOfDeactivation"
    /// <summary>
    /// Contains a defining value of an array
    /// <see href="https://w3id.org/iddo#DefiningValue"></see></summary>
    let DefiningValue = _prefix "DefiningValue"
    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/iddo#DefiningValuesList"></see></summary>
    let DefiningValuesList = _prefix "DefiningValuesList"
    /// <summary>
    /// Contains a defining value of an array in the form of a literal
    /// <see href="https://w3id.org/iddo#DefiningValueItem"></see></summary>
    let DefiningValueItem = _prefix "DefiningValueItem"
    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/iddo#DefiningValues"></see></summary>
    let DefiningValues = _prefix "DefiningValues"
    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/iddo#DeprecationExplanation"></see></summary>
    let DeprecationExplanation = _prefix "DeprecationExplanation"
    /// <summary>
    /// List of pairs (Description of the property, language)
    /// <see href="https://w3id.org/iddo#DescriptionInLanguage"></see></summary>
    let DescriptionInLanguage = _prefix "DescriptionInLanguage"
    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/iddo#DigitalFormat"></see></summary>
    let DigitalFormat = _prefix "DigitalFormat"
    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/iddo#DigitalFormatItem"></see></summary>
    let DigitalFormatItem = _prefix "DigitalFormatItem"
    /// <summary>
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/iddo#Precision"></see></summary>
    let Precision = _prefix "Precision"
    /// <summary>
    /// In case of a physical quantity, dimension according to ISO 80000 (all parts)
    /// This attribute allows the dimension to be machine readable; as all physical quantities are derived from 7 base quantities, it is provided with the power (as a rational number) attached to a basic dimension in the following order and with one space between each
    /// <see href="https://w3id.org/iddo#Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    /// If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032
    /// <see href="https://w3id.org/iddo#DynamicProperty"></see></summary>
    let DynamicProperty = _prefix "DynamicProperty"
    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#Encoding"></see></summary>
    let Encoding = _prefix "Encoding"
    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#TextFormatItem"></see></summary>
    let TextFormatItem = _prefix "TextFormatItem"
    /// <summary>
    /// List of pairs (example of the property, language)
    /// <see href="https://w3id.org/iddo#ExampleInLanguage"></see></summary>
    let ExampleInLanguage = _prefix "ExampleInLanguage"
    /// <summary>
    /// Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.
    /// <see href="https://w3id.org/iddo#GivenGroupsOfProperties"></see></summary>
    let GivenGroupsOfProperties = _prefix "GivenGroupsOfProperties"

    /// <summary>
    /// List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties
    /// <see href="https://w3id.org/iddo#RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        _prefix "RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    /// Pair (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties
    /// <see href="https://w3id.org/iddo#RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        _prefix "RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    /// Visual representation of the group of properties through sketches, photos, videos or other multimedia objects
    /// <see href="https://w3id.org/iddo#VisualRepresentation"></see></summary>
    let VisualRepresentation = _prefix "VisualRepresentation"
    /// <summary>
    /// List of globally unique identifiers of the replaced groups of properties
    /// <see href="https://w3id.org/iddo#ListOfReplacedGroupsOfProperties"></see></summary>
    let ListOfReplacedGroupsOfProperties = _prefix "ListOfReplacedGroupsOfProperties"
    /// <summary>
    /// For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit
    /// <see href="https://w3id.org/iddo#Tolerance"></see></summary>
    let Tolerance = _prefix "Tolerance"
    /// <summary>
    /// Documented geographical region of use of the group of properties
    /// <see href="https://w3id.org/iddo#SubdivisionOfUse"></see></summary>
    let SubdivisionOfUse = _prefix "SubdivisionOfUse"
    /// <summary>
    /// List of globally unique identifiers of the replacing groups of properties
    /// <see href="https://w3id.org/iddo#ListOfReplacingGroupsOfProperties"></see></summary>
    let ListOfReplacingGroupsOfProperties = _prefix "ListOfReplacingGroupsOfProperties"
    /// <summary>
    /// Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)
    /// <see href="https://w3id.org/iddo#ParentGroupOfProperties"></see></summary>
    let ParentGroupOfProperties = _prefix "ParentGroupOfProperties"
    /// <summary>
    /// Corresponding data dictionary identifier
    /// <see href="https://w3id.org/iddo#InterConDictID"></see></summary>
    let InterConDictID = _prefix "InterConDictID"

    /// <summary>
    /// Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/iddo#RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries =
        _prefix "RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    /// List of pairs (possible value for the property and language)
    /// Values can be string or numbers
    /// <see href="https://w3id.org/iddo#ListOfPossibleValuesInLanguageN"></see></summary>
    let ListOfPossibleValuesInLanguageN = _prefix "ListOfPossibleValuesInLanguageN"
    /// <summary>
    /// Possible value for the property and language
    /// Values can be string or numbers
    /// <see href="https://w3id.org/iddo#PossibleValueInLanguageN"></see></summary>
    let PossibleValueInLanguageN = _prefix "PossibleValueInLanguageN"
    /// <summary>
    /// Globally unique identifier of the replaced property (or properties)
    /// <see href="https://w3id.org/iddo#ListOfReplacedProperties"></see></summary>
    let ListOfReplacedProperties = _prefix "ListOfReplacedProperties"
    /// <summary>
    /// Globally unique identifier (attribute PA001) of the replacing property (or properties)
    /// <see href="https://w3id.org/iddo#ListOfReplacingProperties"></see></summary>
    let ListOfReplacingProperties = _prefix "ListOfReplacingProperties"
    /// <summary>
    /// Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications
    /// Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen
    /// <see href="https://w3id.org/iddo#MethodOfMeasurement"></see></summary>
    let MethodOfMeasurement = _prefix "MethodOfMeasurement"
    /// <summary>
    /// In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)
    /// <see href="https://w3id.org/iddo#NameOfTheDefiningValues"></see></summary>
    let NameOfTheDefiningValues = _prefix "NameOfTheDefiningValues"
    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#NumberOfCharacters"></see></summary>
    let NumberOfCharacters = _prefix "NumberOfCharacters"
    /// <summary>
    /// List of GUIDS of properties which are parameters of the function for a dynamic property
    /// <see href="https://w3id.org/iddo#ParametersOfTheDynamicProperty"></see></summary>
    let ParametersOfTheDynamicProperty = _prefix "ParametersOfTheDynamicProperty"
    /// <summary>
    /// List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations
    /// <see href="https://w3id.org/iddo#PhysicalQuantity"></see></summary>
    let PhysicalQuantity = _prefix "PhysicalQuantity"
    /// <summary>
    /// List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/iddo#SymbolsOfTheProperty"></see></summary>
    let SymbolsOfTheProperty = _prefix "SymbolsOfTheProperty"
    /// <summary>
    /// Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/iddo#SymbolOfTheProperty"></see></summary>
    let SymbolOfTheProperty = _prefix "SymbolOfTheProperty"

    /// <summary>
    /// List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/iddo#RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries =
        _prefix "RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries"

    /// <summary>
    /// A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless
    /// <see href="https://w3id.org/iddo#Units"></see></summary>
    let Units = _prefix "Units"
    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#TextFormat"></see></summary>
    let TextFormat = _prefix "TextFormat"
    /// <summary>
    ///   <see href="https://w3id.org/iddo#Symbol"></see>
    /// </summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    ///   <see href="https://w3id.org/iddo#ReferenceDocument"></see>
    /// </summary>
    let ReferenceDocument = _prefix "ReferenceDocument"
