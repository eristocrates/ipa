namespace https.w3id.org.iddo.hash

open DoxAletheia.Rdf_Vocabulary

module iddo =
    let _namespace_name = "https://w3id.org/iddo#"

    /// <summary>
    /// Defines a subset or subgrouping of a data catalog
    /// <see href="https://w3id.org/iddo#DictionarySubset"></see></summary>
    let DictionarySubset =
        Namespaced_IRI.parse _namespace_name "DictionarySubset" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/iddo#hasDictionaryReferenceDocument"></see>
    /// </summary>
    let hasDictionaryReferenceDocument =
        Namespaced_IRI.parse _namespace_name "hasDictionaryReferenceDocument" |> NamespacedName

    /// <summary>
    /// Centralized repository of information about data such as meaning, relationships to other data, origin, usage and format
    /// <see href="https://w3id.org/iddo#Dictionary"></see></summary>
    let Dictionary = Namespaced_IRI.parse _namespace_name "Dictionary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/iddo#hasDictionarySubset"></see>
    /// </summary>
    let hasDictionarySubset =
        Namespaced_IRI.parse _namespace_name "hasDictionarySubset" |> NamespacedName

    /// <summary>
    /// Collection enabling the properties to be prearranged or organized
    /// <see href="https://w3id.org/iddo#GroupOfProperties"></see></summary>
    let GroupOfProperties =
        Namespaced_IRI.parse _namespace_name "GroupOfProperties" |> NamespacedName

    /// <summary>
    /// Specifies the category of the created property group
    /// <see href="https://w3id.org/iddo#CategoryOfGroupOfProperties"></see></summary>
    let CategoryOfGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "CategoryOfGroupOfProperties" |> NamespacedName

    /// <summary>
    /// Country from where the requirement for this property/group of properties originated
    /// <see href="https://w3id.org/iddo#CountryOfOrigin"></see></summary>
    let CountryOfOrigin =
        Namespaced_IRI.parse _namespace_name "CountryOfOrigin" |> NamespacedName

    /// <summary>
    /// Country (group of countries, continent) in which the property is relevant for the market the stakeholders operate in
    /// <see href="https://w3id.org/iddo#CountryOfUse"></see></summary>
    let CountryOfUse =
        Namespaced_IRI.parse _namespace_name "CountryOfUse" |> NamespacedName

    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/iddo#CreatorsLanguage"></see></summary>
    let CreatorsLanguage =
        Namespaced_IRI.parse _namespace_name "CreatorsLanguage" |> NamespacedName

    /// <summary>
    /// Date after when the property can be used
    /// <see href="https://w3id.org/iddo#DateOfActivation"></see></summary>
    let DateOfActivation =
        Namespaced_IRI.parse _namespace_name "DateOfActivation" |> NamespacedName

    /// <summary>
    /// Date of validation of the property creation request by experts
    /// <see href="https://w3id.org/iddo#DateOfCreation"></see></summary>
    let DateOfCreation =
        Namespaced_IRI.parse _namespace_name "DateOfCreation" |> NamespacedName

    /// <summary>
    /// Date of validation of the last change request by experts
    /// <see href="https://w3id.org/iddo#DateOfLastChange"></see></summary>
    let DateOfLastChange =
        Namespaced_IRI.parse _namespace_name "DateOfLastChange" |> NamespacedName

    /// <summary>
    /// Date of revision
    /// <see href="https://w3id.org/iddo#DateOfRevision"></see></summary>
    let DateOfRevision =
        Namespaced_IRI.parse _namespace_name "DateOfRevision" |> NamespacedName

    /// <summary>
    /// Date of version
    /// <see href="https://w3id.org/iddo#DateOfVersion"></see></summary>
    let DateOfVersion =
        Namespaced_IRI.parse _namespace_name "DateOfVersion" |> NamespacedName

    /// <summary>
    /// List of pairs (definition of the property/group of properties, language)
    /// <see href="https://w3id.org/iddo#DefinitionInLanguage"></see></summary>
    let DefinitionInLanguage =
        Namespaced_IRI.parse _namespace_name "DefinitionInLanguage" |> NamespacedName

    /// <summary>
    /// Unique identifier generated using the algorithm denoted in RFC 4122
    /// <see href="https://w3id.org/iddo#GloballyUniqueIdentifier"></see></summary>
    let GloballyUniqueIdentifier =
        Namespaced_IRI.parse _namespace_name "GloballyUniqueIdentifier" |> NamespacedName

    /// <summary>
    /// List of pairs (property name and language)
    /// This attribute can be used to add synonyms for different domains
    /// <see href="https://w3id.org/iddo#NameInLanguage"></see></summary>
    let NameInLanguage =
        Namespaced_IRI.parse _namespace_name "NameInLanguage" |> NamespacedName

    /// <summary>
    /// This revision number allows tracking of minor changes e.g. new translation, changes of typos: if the version number changes, the revision number starts again at 1
    /// Experts decide if a new revision number can be applied or if a new revision is needed
    /// <see href="https://w3id.org/iddo#RevisionNumber"></see></summary>
    let RevisionNumber =
        Namespaced_IRI.parse _namespace_name "RevisionNumber" |> NamespacedName

    /// <summary>
    /// Status of the property during its life cycle
    /// <see href="https://w3id.org/iddo#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// This version number allows tracking of major changes. Experts decide if a new version number must be applied
    /// <see href="https://w3id.org/iddo#VersionNumber"></see></summary>
    let VersionNumber =
        Namespaced_IRI.parse _namespace_name "VersionNumber" |> NamespacedName

    /// <summary>
    /// Inherent or acquired feature of an item
    /// <see href="https://w3id.org/iddo#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    /// List of globally unique identifiers of groups of properties (attribute GA001) to which the property is attached
    /// <see href="https://w3id.org/iddo#GroupsOfProperties"></see></summary>
    let GroupsOfProperties =
        Namespaced_IRI.parse _namespace_name "GroupsOfProperties" |> NamespacedName

    /// <summary>
    /// Publication that is consulted to find specific information, particularly in a technical or scientific domain
    /// <see href="https://w3id.org/iddo#DictionaryReferenceDocument"></see></summary>
    let DictionaryReferenceDocument =
        Namespaced_IRI.parse _namespace_name "DictionaryReferenceDocument" |> NamespacedName

    /// <summary>
    /// Attaches a property group reference to a iddo:ReferenceDocument
    /// <see href="https://w3id.org/iddo#hasPropertyGroupReference"></see></summary>
    let hasPropertyGroupReference =
        Namespaced_IRI.parse _namespace_name "hasPropertyGroupReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/iddo#GroupOfProperties_1"></see>
    /// </summary>
    let GroupOfProperties_1 =
        Namespaced_IRI.parse _namespace_name "GroupOfProperties_1" |> NamespacedName

    /// <summary>
    /// Represents the assignment of a property and a property state to a feature of interest (FOI).
    /// <see href="https://w3id.org/iddo#AssignedProperty"></see></summary>
    let AssignedProperty =
        Namespaced_IRI.parse _namespace_name "AssignedProperty" |> NamespacedName

    /// <summary>
    /// Attaches a property reference to a property assignment
    /// <see href="https://w3id.org/iddo#hasPropertyReference"></see></summary>
    let hasPropertyReference =
        Namespaced_IRI.parse _namespace_name "hasPropertyReference" |> NamespacedName

    /// <summary>
    /// Represents the validation using SHACL of the assignment of a property and a property state to a feature of interest (FOI).
    /// <see href="https://w3id.org/iddo#AssignedPropertyShape"></see></summary>
    let AssignedPropertyShape =
        Namespaced_IRI.parse _namespace_name "AssignedPropertyShape" |> NamespacedName

    /// <summary>
    /// Attaches a property to a feature of interest (FOI)
    /// <see href="https://w3id.org/iddo#hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// Single Boundary value interval
    /// <see href="https://w3id.org/iddo#BoundaryValue"></see></summary>
    let BoundaryValue =
        Namespaced_IRI.parse _namespace_name "BoundaryValue" |> NamespacedName

    /// <summary>
    /// Pair  (List of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/iddo#BoundaryValuesList"></see></summary>
    let BoundaryValuesList =
        Namespaced_IRI.parse _namespace_name "BoundaryValuesList" |> NamespacedName

    /// <summary>
    /// Boundary value interval consisting of the lower(minValue) and the upper(maxValue) interval boundary
    /// <see href="https://w3id.org/iddo#BoundaryValueItem"></see></summary>
    let BoundaryValueItem =
        Namespaced_IRI.parse _namespace_name "BoundaryValueItem" |> NamespacedName

    /// <summary>
    /// Code that can be used to identify the attribute
    /// <see href="https://w3id.org/iddo#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    /// Pair (list of boundary intervals of possible values for the property, unit)
    /// <see href="https://w3id.org/iddo#BoundaryValues"></see></summary>
    let BoundaryValues =
        Namespaced_IRI.parse _namespace_name "BoundaryValues" |> NamespacedName

    /// <summary>
    /// Unit of measurement for the digital text type
    /// <see href="https://w3id.org/iddo#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// List of the globally unique identifier of the connected properties (attribute PA001); the value of one property is related to the values of the other ones. For example, a sound absorption coefficient is given for a specific frequency, in this case sound absorption and frequency are connected properties
    /// <see href="https://w3id.org/iddo#ConnectedProperties"></see></summary>
    let ConnectedProperties =
        Namespaced_IRI.parse _namespace_name "ConnectedProperties" |> NamespacedName

    /// <summary>
    /// Format for expressing the value of the property
    /// This can be understood as the storage type from a software perspective
    /// In case of a dynamic property the value of this attribute is the datatype of the result of the calculation by the formula
    /// <see href="https://w3id.org/iddo#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName

    /// <summary>
    /// Date of deactivation
    /// <see href="https://w3id.org/iddo#DateOfDeactivation"></see></summary>
    let DateOfDeactivation =
        Namespaced_IRI.parse _namespace_name "DateOfDeactivation" |> NamespacedName

    /// <summary>
    /// Contains a defining value of an array
    /// <see href="https://w3id.org/iddo#DefiningValue"></see></summary>
    let DefiningValue =
        Namespaced_IRI.parse _namespace_name "DefiningValue" |> NamespacedName

    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/iddo#DefiningValuesList"></see></summary>
    let DefiningValuesList =
        Namespaced_IRI.parse _namespace_name "DefiningValuesList" |> NamespacedName

    /// <summary>
    /// Contains a defining value of an array in the form of a literal
    /// <see href="https://w3id.org/iddo#DefiningValueItem"></see></summary>
    let DefiningValueItem =
        Namespaced_IRI.parse _namespace_name "DefiningValueItem" |> NamespacedName

    /// <summary>
    /// In case of an array, this attribute provides the defining values when applicable, the datatype is given by the attribute PA030
    /// <see href="https://w3id.org/iddo#DefiningValues"></see></summary>
    let DefiningValues =
        Namespaced_IRI.parse _namespace_name "DefiningValues" |> NamespacedName

    /// <summary>
    /// Sentence explaining the reason of the deprecation, which can explain how to convert values to conform to the new property/group of properties; this explanation has to be written in international English (EN)
    /// <see href="https://w3id.org/iddo#DeprecationExplanation"></see></summary>
    let DeprecationExplanation =
        Namespaced_IRI.parse _namespace_name "DeprecationExplanation" |> NamespacedName

    /// <summary>
    /// List of pairs (Description of the property, language)
    /// <see href="https://w3id.org/iddo#DescriptionInLanguage"></see></summary>
    let DescriptionInLanguage =
        Namespaced_IRI.parse _namespace_name "DescriptionInLanguage" |> NamespacedName

    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/iddo#DigitalFormat"></see></summary>
    let DigitalFormat =
        Namespaced_IRI.parse _namespace_name "DigitalFormat" |> NamespacedName

    /// <summary>
    /// Pair for digital text type (precision, unit)
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/iddo#DigitalFormatItem"></see></summary>
    let DigitalFormatItem =
        Namespaced_IRI.parse _namespace_name "DigitalFormatItem" |> NamespacedName

    /// <summary>
    /// Precision is the number of significant digits
    /// <see href="https://w3id.org/iddo#Precision"></see></summary>
    let Precision = Namespaced_IRI.parse _namespace_name "Precision" |> NamespacedName
    /// <summary>
    /// In case of a physical quantity, dimension according to ISO 80000 (all parts)
    /// This attribute allows the dimension to be machine readable; as all physical quantities are derived from 7 base quantities, it is provided with the power (as a rational number) attached to a basic dimension in the following order and with one space between each
    /// <see href="https://w3id.org/iddo#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName

    /// <summary>
    /// If this is a dynamic property, the value is dependent on the parameters provided in the attribute PA032
    /// <see href="https://w3id.org/iddo#DynamicProperty"></see></summary>
    let DynamicProperty =
        Namespaced_IRI.parse _namespace_name "DynamicProperty" |> NamespacedName

    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#Encoding"></see></summary>
    let Encoding = Namespaced_IRI.parse _namespace_name "Encoding" |> NamespacedName

    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#TextFormatItem"></see></summary>
    let TextFormatItem =
        Namespaced_IRI.parse _namespace_name "TextFormatItem" |> NamespacedName

    /// <summary>
    /// List of pairs (example of the property, language)
    /// <see href="https://w3id.org/iddo#ExampleInLanguage"></see></summary>
    let ExampleInLanguage =
        Namespaced_IRI.parse _namespace_name "ExampleInLanguage" |> NamespacedName

    /// <summary>
    /// Globally unique identifier of a group of properties (attribute GA001) for the symbol assigned to the property.
    /// <see href="https://w3id.org/iddo#GivenGroupsOfProperties"></see></summary>
    let GivenGroupsOfProperties =
        Namespaced_IRI.parse _namespace_name "GivenGroupsOfProperties" |> NamespacedName

    /// <summary>
    /// List of pairs (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties
    /// <see href="https://w3id.org/iddo#RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Namespaced_IRI.parse _namespace_name "RelationsOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries" |> NamespacedName

    /// <summary>
    /// Pair (group of properties internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing groups of properties
    /// <see href="https://w3id.org/iddo#RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries =
        Namespaced_IRI.parse _namespace_name "RelationOfTheGroupOfPropertiesIdentifiersInTheInterconnectedDataDictionaries" |> NamespacedName

    /// <summary>
    /// Visual representation of the group of properties through sketches, photos, videos or other multimedia objects
    /// <see href="https://w3id.org/iddo#VisualRepresentation"></see></summary>
    let VisualRepresentation =
        Namespaced_IRI.parse _namespace_name "VisualRepresentation" |> NamespacedName

    /// <summary>
    /// List of globally unique identifiers of the replaced groups of properties
    /// <see href="https://w3id.org/iddo#ListOfReplacedGroupsOfProperties"></see></summary>
    let ListOfReplacedGroupsOfProperties =
        Namespaced_IRI.parse _namespace_name "ListOfReplacedGroupsOfProperties" |> NamespacedName

    /// <summary>
    /// For numerical values; the total amount that a specific unit is permitted to vary; it is the difference between the maximum and the minimum limits for the unit
    /// <see href="https://w3id.org/iddo#Tolerance"></see></summary>
    let Tolerance = Namespaced_IRI.parse _namespace_name "Tolerance" |> NamespacedName

    /// <summary>
    /// Documented geographical region of use of the group of properties
    /// <see href="https://w3id.org/iddo#SubdivisionOfUse"></see></summary>
    let SubdivisionOfUse =
        Namespaced_IRI.parse _namespace_name "SubdivisionOfUse" |> NamespacedName

    /// <summary>
    /// List of globally unique identifiers of the replacing groups of properties
    /// <see href="https://w3id.org/iddo#ListOfReplacingGroupsOfProperties"></see></summary>
    let ListOfReplacingGroupsOfProperties =
        Namespaced_IRI.parse _namespace_name "ListOfReplacingGroupsOfProperties" |> NamespacedName

    /// <summary>
    /// Enables a sub-group to be linked to a parent group via their globally unique identifiers (attribute GA001)
    /// Any property attached to a group is inherited by the sub-group(s)
    /// <see href="https://w3id.org/iddo#ParentGroupOfProperties"></see></summary>
    let ParentGroupOfProperties =
        Namespaced_IRI.parse _namespace_name "ParentGroupOfProperties" |> NamespacedName

    /// <summary>
    /// Corresponding data dictionary identifier
    /// <see href="https://w3id.org/iddo#InterConDictID"></see></summary>
    let InterConDictID =
        Namespaced_IRI.parse _namespace_name "InterConDictID" |> NamespacedName

    /// <summary>
    /// Pair (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/iddo#RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries =
        Namespaced_IRI.parse _namespace_name "RelationOfPropertiyIdentifiersInTheInterconnectedDataDictionaries" |> NamespacedName

    /// <summary>
    /// List of pairs (possible value for the property and language)
    /// Values can be string or numbers
    /// <see href="https://w3id.org/iddo#ListOfPossibleValuesInLanguageN"></see></summary>
    let ListOfPossibleValuesInLanguageN =
        Namespaced_IRI.parse _namespace_name "ListOfPossibleValuesInLanguageN" |> NamespacedName

    /// <summary>
    /// Possible value for the property and language
    /// Values can be string or numbers
    /// <see href="https://w3id.org/iddo#PossibleValueInLanguageN"></see></summary>
    let PossibleValueInLanguageN =
        Namespaced_IRI.parse _namespace_name "PossibleValueInLanguageN" |> NamespacedName

    /// <summary>
    /// Globally unique identifier of the replaced property (or properties)
    /// <see href="https://w3id.org/iddo#ListOfReplacedProperties"></see></summary>
    let ListOfReplacedProperties =
        Namespaced_IRI.parse _namespace_name "ListOfReplacedProperties" |> NamespacedName

    /// <summary>
    /// Globally unique identifier (attribute PA001) of the replacing property (or properties)
    /// <see href="https://w3id.org/iddo#ListOfReplacingProperties"></see></summary>
    let ListOfReplacingProperties =
        Namespaced_IRI.parse _namespace_name "ListOfReplacingProperties" |> NamespacedName

    /// <summary>
    /// Evaluation of construction products to ensure their fitness according to requirements in harmonised technical specifications
    /// Beurteilung von Bauprodukten, um ihre Tauglichkeit entsprechend den Anforderungen in harmonisierten technischen Spezifikationen sicherzustellen
    /// <see href="https://w3id.org/iddo#MethodOfMeasurement"></see></summary>
    let MethodOfMeasurement =
        Namespaced_IRI.parse _namespace_name "MethodOfMeasurement" |> NamespacedName

    /// <summary>
    /// In case of an array, this attribute provides the names of the column headers defined as a list of pairs (name, language)
    /// <see href="https://w3id.org/iddo#NameOfTheDefiningValues"></see></summary>
    let NameOfTheDefiningValues =
        Namespaced_IRI.parse _namespace_name "NameOfTheDefiningValues" |> NamespacedName

    /// <summary>
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#NumberOfCharacters"></see></summary>
    let NumberOfCharacters =
        Namespaced_IRI.parse _namespace_name "NumberOfCharacters" |> NamespacedName

    /// <summary>
    /// List of GUIDS of properties which are parameters of the function for a dynamic property
    /// <see href="https://w3id.org/iddo#ParametersOfTheDynamicProperty"></see></summary>
    let ParametersOfTheDynamicProperty =
        Namespaced_IRI.parse _namespace_name "ParametersOfTheDynamicProperty" |> NamespacedName

    /// <summary>
    /// List of pairs (physical quantity | language)
    /// Physical quantities are expressed in International System (SI) units
    /// Non-physical quantities such as text are expressed with the value "without"
    /// This is equivalent to a measure in ISO 16739-1 and ISO 10303
    /// Only one physical quantity can be attached to a property. This attribute is used to provide the quantity in plain text with all the needed translations
    /// <see href="https://w3id.org/iddo#PhysicalQuantity"></see></summary>
    let PhysicalQuantity =
        Namespaced_IRI.parse _namespace_name "PhysicalQuantity" |> NamespacedName

    /// <summary>
    /// List of pairs (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/iddo#SymbolsOfTheProperty"></see></summary>
    let SymbolsOfTheProperty =
        Namespaced_IRI.parse _namespace_name "SymbolsOfTheProperty" |> NamespacedName

    /// <summary>
    /// Pair (symbol of the property, globally unique identifier of the group of properties (attribute GA001))
    /// <see href="https://w3id.org/iddo#SymbolOfTheProperty"></see></summary>
    let SymbolOfTheProperty =
        Namespaced_IRI.parse _namespace_name "SymbolOfTheProperty" |> NamespacedName

    /// <summary>
    /// List of pairs (property internal identifier, corresponding data dictionary identifier)
    /// This attribute should be used for compatibility between already existing properties
    /// <see href="https://w3id.org/iddo#RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries"></see></summary>
    let RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries =
        Namespaced_IRI.parse _namespace_name "RelationsOfThePropertyIdentifiersInTheInterconnectedDataDictionaries" |> NamespacedName

    /// <summary>
    /// A unit to represent a scale that enables a value to be measured
    /// It is possible to use this attribute to explain there is no unit attached to the property by using unitless
    /// <see href="https://w3id.org/iddo#Units"></see></summary>
    let Units = Namespaced_IRI.parse _namespace_name "Units" |> NamespacedName
    /// <summary>
    /// Pair for text type (encoding, number of characters)
    /// The encoding is set according to Name of encoding standard of IANA, RFC 2978
    /// <see href="https://w3id.org/iddo#TextFormat"></see></summary>
    let TextFormat = Namespaced_IRI.parse _namespace_name "TextFormat" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/iddo#Symbol"></see>
    /// </summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/iddo#ReferenceDocument"></see>
    /// </summary>
    let ReferenceDocument =
        Namespaced_IRI.parse _namespace_name "ReferenceDocument" |> NamespacedName
