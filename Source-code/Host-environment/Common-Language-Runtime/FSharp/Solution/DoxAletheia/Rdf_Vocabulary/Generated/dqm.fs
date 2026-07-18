namespace http.purl.org.dqm_vocabulary.v1.dqm.hash

open DoxAletheia.Rdf_Vocabulary

module dqm =
    let _namespace_name = "http://purl.org/dqm-vocabulary/v1/dqm#"
    /// <summary>
    /// Accuracy is the degree to which a data value represents the desired state regarding its syntax and semantics.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Accuracy"></see></summary>
    let Accuracy = Namespaced_IRI.parse _namespace_name "Accuracy" |> NamespacedName

    /// <summary>
    /// Data quality score is an abstract class that can be used to structure data quality dimension scores that indicate the quality state of classes and/or properties.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataQualityScore"></see></summary>
    let DataQualityScore =
        Namespaced_IRI.parse _namespace_name "DataQualityScore" |> NamespacedName

    /// <summary>
    /// An affected class holds one or more affected instances
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedClass"></see></summary>
    let AffectedClass =
        Namespaced_IRI.parse _namespace_name "AffectedClass" |> NamespacedName

    /// <summary>
    /// A data element is a class, a property, an instance, or a literal value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataElement"></see></summary>
    let DataElement =
        Namespaced_IRI.parse _namespace_name "DataElement" |> NamespacedName

    /// <summary>
    /// An affected instance is a data instance that contains one or more data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedInstance"></see></summary>
    let AffectedInstance =
        Namespaced_IRI.parse _namespace_name "AffectedInstance" |> NamespacedName

    /// <summary>
    /// An affected property specifies the property of a data instance that contains one or more data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedProperty"></see></summary>
    let AffectedProperty =
        Namespaced_IRI.parse _namespace_name "AffectedProperty" |> NamespacedName

    /// <summary>
    /// A blacklist class holds instances with values that are disallowed for a certain data set. Thus, illegal value rules refer to such classes over the blacklist class property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistClass"></see></summary>
    let BlacklistClass =
        Namespaced_IRI.parse _namespace_name "BlacklistClass" |> NamespacedName

    /// <summary>
    /// A blacklist property holds the values that are disallowed for a certain data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistProperty"></see></summary>
    let BlacklistProperty =
        Namespaced_IRI.parse _namespace_name "BlacklistProperty" |> NamespacedName

    /// <summary>
    /// A class requirement is a data requirement that refers to the instances of a class as a whole.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ClassRequirement"></see></summary>
    let ClassRequirement =
        Namespaced_IRI.parse _namespace_name "ClassRequirement" |> NamespacedName

    /// <summary>
    /// A data requirement is a prescribed directive or consensual agreement that defines the content and/or structure that constitute high quality data instances and values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirement"></see></summary>
    let DataRequirement =
        Namespaced_IRI.parse _namespace_name "DataRequirement" |> NamespacedName

    /// <summary>
    /// Completeness is the extent to which data are of sufficient breadth, depth, and scope for the task at hand.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Completeness"></see></summary>
    let Completeness =
        Namespaced_IRI.parse _namespace_name "Completeness" |> NamespacedName

    /// <summary>
    /// A condition constrains instances of a class to a certain subset for which certain data quality rules apply.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName

    /// <summary>
    /// Conditional property completeness rules specify that a tested property and/or its literal values must exist when the value of another property obtains a certain state. E.g. the property foo:state must exist and have a value when the property foo:country obtains the value "USA".
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalPropertyCompletenessRule"></see></summary>
    let ConditionalPropertyCompletenessRule =
        Namespaced_IRI.parse _namespace_name "ConditionalPropertyCompletenessRule" |> NamespacedName

    /// <summary>
    /// A conditional rule is a multi property requirement that can be used to specify that values of a tested property A must always obtain a certain state under the condition that values of another property B obtain a certain state (condition).
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalRule"></see></summary>
    let ConditionalRule =
        Namespaced_IRI.parse _namespace_name "ConditionalRule" |> NamespacedName

    /// <summary>
    /// Multi property requirements are data requirements that consider values from two or more properties.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyRequirement"></see></summary>
    let MultiPropertyRequirement =
        Namespaced_IRI.parse _namespace_name "MultiPropertyRequirement" |> NamespacedName

    /// <summary>
    /// Conditional syntax rules define that the literal values of a tested property must follow a certain syntax when the value of another property obtains a certain state. E.g. the property foo:state must have a value with two capital letters when the property foo:country obtains the value "USA".
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalSyntaxRule"></see></summary>
    let ConditionalSyntaxRule =
        Namespaced_IRI.parse _namespace_name "ConditionalSyntaxRule" |> NamespacedName

    /// <summary>
    /// A custom requirement is a data requirement that is expressed via a SPARQL query.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#CustomRequirement"></see></summary>
    let CustomRequirement =
        Namespaced_IRI.parse _namespace_name "CustomRequirement" |> NamespacedName

    /// <summary>
    /// A data cleansing rule is an unambiguous rule that precisely specifies the required state of a data value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataCleansingRule"></see></summary>
    let DataCleansingRule =
        Namespaced_IRI.parse _namespace_name "DataCleansingRule" |> NamespacedName

    /// <summary>
    /// A data requirement violation occurs when a data value or a data instance does not meet its requirements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirementViolation"></see></summary>
    let DataRequirementViolation =
        Namespaced_IRI.parse _namespace_name "DataRequirementViolation" |> NamespacedName

    /// <summary>
    /// Two or more instances are duplicates when they represent the same real world entity.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstance"></see></summary>
    let DuplicateInstance =
        Namespaced_IRI.parse _namespace_name "DuplicateInstance" |> NamespacedName

    /// <summary>
    /// A duplicate instance rule is a multi property requirement which specifies the properties that (when seen together) uniquely identify an entity. I.e. if the properties of two or more different instances represent the same state, then the instances represent the same entity. Thus, the instances are considered to be duplicates.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstanceRule"></see></summary>
    let DuplicateInstanceRule =
        Namespaced_IRI.parse _namespace_name "DuplicateInstanceRule" |> NamespacedName

    /// <summary>
    /// Matching value rules are multi property requirements in which the property values of other instances are used to identify data requirements violations in an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MatchingValueRule"></see></summary>
    let MatchingValueRule =
        Namespaced_IRI.parse _namespace_name "MatchingValueRule" |> NamespacedName

    /// <summary>
    /// An expiry rule is an outdated instance rule that specifies the expiration date of an instance that must not exceed the current date and time. Therefore, expiry rules require date information about the validity period of an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ExpiryRule"></see></summary>
    let ExpiryRule = Namespaced_IRI.parse _namespace_name "ExpiryRule" |> NamespacedName

    /// <summary>
    /// An outdated instance rule is a data requirement that specifies the point in time when an instance is not current anymore.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstanceRule"></see></summary>
    let OutdatedInstanceRule =
        Namespaced_IRI.parse _namespace_name "OutdatedInstanceRule" |> NamespacedName

    /// <summary>
    /// A functional dependency reference rule is a multi property requirement that specifies legal value combinations for two or more properties that are allowed to occur within the same instance. Functional dependency reference rules refer to reference properties of classes that hold instances with all allowed value combinations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepReferenceRule"></see></summary>
    let FuncDepReferenceRule =
        Namespaced_IRI.parse _namespace_name "FuncDepReferenceRule" |> NamespacedName

    /// <summary>
    /// A functionally dependent value rule defines that the value of a tested property must have a certain value when the values of other properties obtain certain states (conditions). E.g. the property foo:inStock must have value "true" when the property foo:availableAmount is greater than zero.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepValueRule"></see></summary>
    let FuncDepValueRule =
        Namespaced_IRI.parse _namespace_name "FuncDepValueRule" |> NamespacedName

    /// <summary>
    /// A functional dependency violation is a combination of different property values within the same instance that must not occur together. E.g. an instance describing the man “Peter Miller” has the value “Mr.” as salutation property, but the value “female” as sex.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#FunctionalDependencyViolation"></see></summary>
    let FunctionalDependencyViolation =
        Namespaced_IRI.parse _namespace_name "FunctionalDependencyViolation" |> NamespacedName

    /// <summary>
    /// An illegal value is a data value that must not be used for a property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValue"></see></summary>
    let IllegalValue =
        Namespaced_IRI.parse _namespace_name "IllegalValue" |> NamespacedName

    /// <summary>
    /// An illegal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property must not obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRangeRule"></see></summary>
    let IllegalValueRangeRule =
        Namespaced_IRI.parse _namespace_name "IllegalValueRangeRule" |> NamespacedName

    /// <summary>
    /// Property requirements are data requirements that are related to values of a single property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyRequirement"></see></summary>
    let PropertyRequirement =
        Namespaced_IRI.parse _namespace_name "PropertyRequirement" |> NamespacedName

    /// <summary>
    /// An illegal value rule is a property requirement that specifies the values that a certain property must not obtain. Illegal value rules, therefore, refer to reference properties that hold all disallowed values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRule"></see></summary>
    let IllegalValueRule =
        Namespaced_IRI.parse _namespace_name "IllegalValueRule" |> NamespacedName

    /// <summary>
    /// A legal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property is allowed to obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRangeRule"></see></summary>
    let LegalValueRangeRule =
        Namespaced_IRI.parse _namespace_name "LegalValueRangeRule" |> NamespacedName

    /// <summary>
    /// A legal value rule is a property requirement that specifies all values that a certain property is allowed to obtain. Legal value rules, therefore, refer to reference properties of classes that hold instances with all allowed values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRule"></see></summary>
    let LegalValueRule =
        Namespaced_IRI.parse _namespace_name "LegalValueRule" |> NamespacedName

    /// <summary>
    /// Literal cleansing rules can be used to cleanse the literal values of a certain property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#LiteralCleansingRule"></see></summary>
    let LiteralCleansingRule =
        Namespaced_IRI.parse _namespace_name "LiteralCleansingRule" |> NamespacedName

    /// <summary>
    /// A missing element is a data requirement violation that occurs when schema elements, instances, or data values are missing, but required.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingElement"></see></summary>
    let MissingElement =
        Namespaced_IRI.parse _namespace_name "MissingElement" |> NamespacedName

    /// <summary>
    /// A property is missing when an instances does not contain a specific property that is required.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingProperty"></see></summary>
    let MissingProperty =
        Namespaced_IRI.parse _namespace_name "MissingProperty" |> NamespacedName

    /// <summary>
    /// Class for instances that miss both a property and its value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingPropertyAndValue"></see></summary>
    let MissingPropertyAndValue =
        Namespaced_IRI.parse _namespace_name "MissingPropertyAndValue" |> NamespacedName

    /// <summary>
    /// A missing value occurs when a property of an instance does not hold a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingValue"></see></summary>
    let MissingValue =
        Namespaced_IRI.parse _namespace_name "MissingValue" |> NamespacedName

    /// <summary>
    /// Multi property cleansing rules can be used to cleanse the literal values of two or more dependent properties.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyCleansingRule"></see></summary>
    let MultiPropertyCleansingRule =
        Namespaced_IRI.parse _namespace_name "MultiPropertyCleansingRule" |> NamespacedName

    /// <summary>
    /// A value is out of range when it is not part of the legal value range or when it is part of the illegal value range.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#OutOfRangeValue"></see></summary>
    let OutOfRangeValue =
        Namespaced_IRI.parse _namespace_name "OutOfRangeValue" |> NamespacedName

    /// <summary>
    /// An instance is outdated when it represents an outdated state of its corresponding real-world entity.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstance"></see></summary>
    let OutdatedInstance =
        Namespaced_IRI.parse _namespace_name "OutdatedInstance" |> NamespacedName

    /// <summary>
    /// Population completeness is the degree to which all objects of a certain reference are represented in a specific class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationCompleteness"></see></summary>
    let PopulationCompleteness =
        Namespaced_IRI.parse _namespace_name "PopulationCompleteness" |> NamespacedName

    /// <summary>
    /// Entity uniqueness is the degree to which entities (that must be uniquely represented within a certain class) are unique.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationUniqueness"></see></summary>
    let PopulationUniqueness =
        Namespaced_IRI.parse _namespace_name "PopulationUniqueness" |> NamespacedName

    /// <summary>
    /// Uniqueness is the degree to which properties and classes are free of duplicate values and instances.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Uniqueness"></see></summary>
    let Uniqueness = Namespaced_IRI.parse _namespace_name "Uniqueness" |> NamespacedName

    /// <summary>
    /// Property completeness is the degree to which values for a specific property are missing in entities of a specific class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompleteness"></see></summary>
    let PropertyCompleteness =
        Namespaced_IRI.parse _namespace_name "PropertyCompleteness" |> NamespacedName

    /// <summary>
    /// A property completeness rule is a data requirement that specifies that a certain property and/or its value must exist in all instances of a certain class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletenessRule"></see></summary>
    let PropertyCompletenessRule =
        Namespaced_IRI.parse _namespace_name "PropertyCompletenessRule" |> NamespacedName

    /// <summary>
    /// A property completion rule specifies a property and value that shall be added to certain instances.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletion"></see></summary>
    let PropertyCompletion =
        Namespaced_IRI.parse _namespace_name "PropertyCompletion" |> NamespacedName

    /// <summary>
    /// Property uniqueness is the degree to which the values of a property (that must only contain unique values within instances of a certain class) are unique.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyUniqueness"></see></summary>
    let PropertyUniqueness =
        Namespaced_IRI.parse _namespace_name "PropertyUniqueness" |> NamespacedName

    /// <summary>
    /// A scale value is a value of a nominal or ordinal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ScaleValue"></see></summary>
    let ScaleValue = Namespaced_IRI.parse _namespace_name "ScaleValue" |> NamespacedName

    /// <summary>
    /// Semantic accuracy is the degree to which the data values of an instance represent the correct state of an entity’s property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SemanticAccuracy"></see></summary>
    let SemanticAccuracy =
        Namespaced_IRI.parse _namespace_name "SemanticAccuracy" |> NamespacedName

    /// <summary>
    /// A strict value combination is a combination of two values of different properties that may only be assigned to each other, but not to other values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#StrictValueCombination"></see></summary>
    let StrictValueCombination =
        Namespaced_IRI.parse _namespace_name "StrictValueCombination" |> NamespacedName

    /// <summary>
    /// Syntactic accuracy is the degree to which data values of a property represent legal values and are free from syntax violations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SyntacticAccuracy"></see></summary>
    let SyntacticAccuracy =
        Namespaced_IRI.parse _namespace_name "SyntacticAccuracy" |> NamespacedName

    /// <summary>
    /// A syntax rule is a property requirement that specifies the allowed characters and/or character pattern to be used in values for a certain property in instances of a certain class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxRule"></see></summary>
    let SyntaxRule = Namespaced_IRI.parse _namespace_name "SyntaxRule" |> NamespacedName

    /// <summary>
    /// A syntax violation is a data requirement violation that occurs when a data value contains disallowed characters or does not match a predefined pattern.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxViolation"></see></summary>
    let SyntaxViolation =
        Namespaced_IRI.parse _namespace_name "SyntaxViolation" |> NamespacedName

    /// <summary>
    /// Classifies the tasks for which the data quality rule shall apply for.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// A tested class is a class that holds the instances that shall be analyzed for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TestedClass"></see></summary>
    let TestedClass =
        Namespaced_IRI.parse _namespace_name "TestedClass" |> NamespacedName

    /// <summary>
    /// A tested property holds the values to be analyzed for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TestedProperty"></see></summary>
    let TestedProperty =
        Namespaced_IRI.parse _namespace_name "TestedProperty" |> NamespacedName

    /// <summary>
    /// Timeliness is the degree to which instances of a specific class (1) are updated within an expected time or (2) have not exceeded their expiration date.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Timeliness"></see></summary>
    let Timeliness = Namespaced_IRI.parse _namespace_name "Timeliness" |> NamespacedName

    /// <summary>
    /// Legal value rules and functional dependency reference rules require the specification of a trusted class as a reference that holds instances with legal values / legal value combinations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedClass"></see></summary>
    let TrustedClass =
        Namespaced_IRI.parse _namespace_name "TrustedClass" |> NamespacedName

    /// <summary>
    /// A trusted property holds the values that serve as a trusted reference in legal value rules / functional dependency reference rules, e.g. to define legal values for a tested property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedProperty"></see></summary>
    let TrustedProperty =
        Namespaced_IRI.parse _namespace_name "TrustedProperty" |> NamespacedName

    /// <summary>
    /// A unique value rule is a property requirement that specifies that each value of a certain property must be unique in instances of a certain class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#UniqueValueRule"></see></summary>
    let UniqueValueRule =
        Namespaced_IRI.parse _namespace_name "UniqueValueRule" |> NamespacedName

    /// <summary>
    /// A uniqueness violation occurs when two or more identical values are assigned to a property that requires unique values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#UniquenessViolation"></see></summary>
    let UniquenessViolation =
        Namespaced_IRI.parse _namespace_name "UniquenessViolation" |> NamespacedName

    /// <summary>
    /// Class for units of numerical values that are used to express certain property states.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName
    /// <summary>
    /// An update rule is an outdated instance rule that specifies the maximum duration tolerated without any updates. Update rules require timestamps about the last update of an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#UpdateRule"></see></summary>
    let UpdateRule = Namespaced_IRI.parse _namespace_name "UpdateRule" |> NamespacedName

    /// <summary>
    /// A value substitution rule specifies a value to be removed and a new value that shall substitute the removed value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ValueSubstitution"></see></summary>
    let ValueSubstitution =
        Namespaced_IRI.parse _namespace_name "ValueSubstitution" |> NamespacedName

    /// <summary>
    /// A white space removal rule states that whitespaces at the beginning of a string and at the end of a string shall be removed for the specified property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#WhitespaceRemoval"></see></summary>
    let WhitespaceRemoval =
        Namespaced_IRI.parse _namespace_name "WhitespaceRemoval" |> NamespacedName

    /// <summary>
    /// A property that shall be added to an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#addProperty"></see></summary>
    let addProperty =
        Namespaced_IRI.parse _namespace_name "addProperty" |> NamespacedName

    /// <summary>
    /// Cleansing properties are properties of data cleansing rules.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansingProperty"></see></summary>
    let cleansingProperty =
        Namespaced_IRI.parse _namespace_name "cleansingProperty" |> NamespacedName

    /// <summary>
    /// A value that shall be added to a property of an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#addValue"></see></summary>
    let addValue = Namespaced_IRI.parse _namespace_name "addValue" |> NamespacedName

    /// <summary>
    /// An affected class holds one or more instances with one or more data requirement violations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#affectedClass"></see></summary>
    let affectedClass =
        Namespaced_IRI.parse _namespace_name "affectedClass" |> NamespacedName

    /// <summary>
    /// The data element relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data elements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#dataElementRelationship"></see></summary>
    let dataElementRelationship =
        Namespaced_IRI.parse _namespace_name "dataElementRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dqm-vocabulary/v1/dqm#affectedInstance"></see>
    /// </summary>
    let affectedInstance =
        Namespaced_IRI.parse _namespace_name "affectedInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dqm-vocabulary/v1/dqm#affectedProperty"></see>
    /// </summary>
    let affectedProperty =
        Namespaced_IRI.parse _namespace_name "affectedProperty" |> NamespacedName

    /// <summary>
    /// Connects data requirements with the tasks in which the requirement applies.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#appliesFor"></see></summary>
    let appliesFor = Namespaced_IRI.parse _namespace_name "appliesFor" |> NamespacedName

    /// <summary>
    /// The data requirements relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data requirements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#dataRequirementsRelationship"></see></summary>
    let dataRequirementsRelationship =
        Namespaced_IRI.parse _namespace_name "dataRequirementsRelationship" |> NamespacedName

    /// <summary>
    /// Specifies the data requirements that have to be fulfilled to perform the task.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasRequirement"></see></summary>
    let hasRequirement =
        Namespaced_IRI.parse _namespace_name "hasRequirement" |> NamespacedName

    /// <summary>
    /// The assessed class is the class that holds the instances that have been analyzed to compute the assessment score.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#assessedClass"></see></summary>
    let assessedClass =
        Namespaced_IRI.parse _namespace_name "assessedClass" |> NamespacedName

    /// <summary>
    /// The assessed property represents all properties that have been tested for rule violations during the computation of the assessment score.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#assessedProperty"></see></summary>
    let assessedProperty =
        Namespaced_IRI.parse _namespace_name "assessedProperty" |> NamespacedName

    /// <summary>
    /// The assessment property indicates whether the rule shall be used for data quality assessment.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#assessment"></see></summary>
    let assessment = Namespaced_IRI.parse _namespace_name "assessment" |> NamespacedName

    /// <summary>
    /// An abstract property that holds generic datatype properties that describe a data requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqMetadata"></see></summary>
    let reqMetadata =
        Namespaced_IRI.parse _namespace_name "reqMetadata" |> NamespacedName

    /// <summary>
    /// Connects a data quality score with the data requirements that were used to calculate the score.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#basedOn"></see></summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName
    /// <summary>
    /// Connects data requirements with the data quality score which was calculated based on the requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasScore"></see></summary>
    let hasScore = Namespaced_IRI.parse _namespace_name "hasScore" |> NamespacedName

    /// <summary>
    /// A blacklist class holds instances with values that are disallowed for a certain data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistClass"></see></summary>
    let blacklistClass =
        Namespaced_IRI.parse _namespace_name "blacklistClass" |> NamespacedName

    /// <summary>
    /// A blacklist property holds the values that are disallowed for a certain data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistProperty"></see></summary>
    let blacklistProperty =
        Namespaced_IRI.parse _namespace_name "blacklistProperty" |> NamespacedName

    /// <summary>
    /// This property identifies classes that contain instances that shall be cleansed via a data cleansing rule.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesClass"></see></summary>
    let cleansesClass =
        Namespaced_IRI.parse _namespace_name "cleansesClass" |> NamespacedName

    /// <summary>
    /// Data cleansing rule relationships are object properties of the data cleansing rules.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#dataCleansingRuleRelationship"></see></summary>
    let dataCleansingRuleRelationship =
        Namespaced_IRI.parse _namespace_name "dataCleansingRuleRelationship" |> NamespacedName

    /// <summary>
    /// This property identifies a property that holds values that shall be cleansed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesProperty1"></see></summary>
    let cleansesProperty1 =
        Namespaced_IRI.parse _namespace_name "cleansesProperty1" |> NamespacedName

    /// <summary>
    /// The data cleansing property specifies whether the rule shall be applied to cleanse the data in a data source.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansing"></see></summary>
    let cleansing = Namespaced_IRI.parse _namespace_name "cleansing" |> NamespacedName
    /// <summary>
    /// UN/CEFACT common code of a unit of measurement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#commonCode"></see></summary>
    let commonCode = Namespaced_IRI.parse _namespace_name "commonCode" |> NamespacedName

    /// <summary>
    /// The conditional property property indicates the URI of a property that holds values that can be used to filter the relevant subset of data for which a rule applies.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#conditionalProperty"></see></summary>
    let conditionalProperty =
        Namespaced_IRI.parse _namespace_name "conditionalProperty" |> NamespacedName

    /// <summary>
    /// The confidence property indicates how confident a rule creators is regarding the correctness of the rule.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#confidence"></see></summary>
    let confidence = Namespaced_IRI.parse _namespace_name "confidence" |> NamespacedName
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found in strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// The operated value property is an abstract property for datatype properties that are used to express string filtering criteria.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#operatedValue"></see></summary>
    let operatedValue =
        Namespaced_IRI.parse _namespace_name "operatedValue" |> NamespacedName

    /// <summary>
    /// The current value propertiy specifies the value to be removed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#currentValue"></see></summary>
    let currentValue =
        Namespaced_IRI.parse _namespace_name "currentValue" |> NamespacedName

    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found at the end of strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#endsWith"></see></summary>
    let endsWith = Namespaced_IRI.parse _namespace_name "endsWith" |> NamespacedName
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found in the same order in strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#equals"></see></summary>
    let equals = Namespaced_IRI.parse _namespace_name "equals" |> NamespacedName

    /// <summary>
    /// The expected update interval specifies the time interval in which instances of a specific class must be updated in order to be current.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#expectedUpdateInterval"></see></summary>
    let expectedUpdateInterval =
        Namespaced_IRI.parse _namespace_name "expectedUpdateInterval" |> NamespacedName

    /// <summary>
    /// The filtering property indicates whether the rule shall be used for information filtering, i.e. only high quality data is retrieved.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#filtering"></see></summary>
    let filtering = Namespaced_IRI.parse _namespace_name "filtering" |> NamespacedName

    /// <summary>
    /// Holds a numeric value that is used to identify values of a property that are greater than the value of this property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#greaterThan"></see></summary>
    let greaterThan =
        Namespaced_IRI.parse _namespace_name "greaterThan" |> NamespacedName

    /// <summary>
    /// Connects a conditional rule with a certain condition
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition"></see></summary>
    let hasCondition =
        Namespaced_IRI.parse _namespace_name "hasCondition" |> NamespacedName

    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition1"></see></summary>
    let hasCondition1 =
        Namespaced_IRI.parse _namespace_name "hasCondition1" |> NamespacedName

    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition2"></see></summary>
    let hasCondition2 =
        Namespaced_IRI.parse _namespace_name "hasCondition2" |> NamespacedName

    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition3"></see></summary>
    let hasCondition3 =
        Namespaced_IRI.parse _namespace_name "hasCondition3" |> NamespacedName

    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition4"></see></summary>
    let hasCondition4 =
        Namespaced_IRI.parse _namespace_name "hasCondition4" |> NamespacedName

    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition5"></see></summary>
    let hasCondition5 =
        Namespaced_IRI.parse _namespace_name "hasCondition5" |> NamespacedName

    /// <summary>
    /// Reconnects mapped classes and properties with each other.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasProperties"></see></summary>
    let hasProperties =
        Namespaced_IRI.parse _namespace_name "hasProperties" |> NamespacedName

    /// <summary>
    /// The hasURI property is used to map properties to instances of a class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasURI"></see></summary>
    let hasURI = Namespaced_IRI.parse _namespace_name "hasURI" |> NamespacedName
    /// <summary>
    /// Specifies the importance of a task, a data quality rule, or a data element.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#importance"></see></summary>
    let importance = Namespaced_IRI.parse _namespace_name "importance" |> NamespacedName

    /// <summary>
    /// The property lastModified indicates the date and time when the rule was last modified.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#lastModified"></see></summary>
    let lastModified =
        Namespaced_IRI.parse _namespace_name "lastModified" |> NamespacedName

    /// <summary>
    /// Holds a numeric value that is used to identify values of a property that are less than the value of this property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#lessThan"></see></summary>
    let lessThan = Namespaced_IRI.parse _namespace_name "lessThan" |> NamespacedName
    /// <summary>
    /// Specifies the lower limit a numeric property value shall obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#lowerLimit"></see></summary>
    let lowerLimit = Namespaced_IRI.parse _namespace_name "lowerLimit" |> NamespacedName
    /// <summary>
    /// The new value property specifies the new value which shall substitute the current value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#newValue"></see></summary>
    let newValue = Namespaced_IRI.parse _namespace_name "newValue" |> NamespacedName
    /// <summary>
    /// Links an instances to the next instance in an ordinal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName
    /// <summary>
    /// Holds one or more consecutive characters that are used to identify values of another property that do not match with the value of this property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#notEqualTo"></see></summary>
    let notEqualTo = Namespaced_IRI.parse _namespace_name "notEqualTo" |> NamespacedName

    /// <summary>
    /// Official name of a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#officialName"></see></summary>
    let officialName =
        Namespaced_IRI.parse _namespace_name "officialName" |> NamespacedName

    /// <summary>
    /// The pattern property can be used to express value patterns based on a simple syntax without the need for knowing regular expressions. E.g. the pattern "AaaaaNN" where "A" stands for capital letters, "a" for small letters, and "N" for numbers.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#pattern"></see></summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName
    /// <summary>
    /// The plain score represents a data quality dimension score that was assessed by using a certain formula that accounts for the violations of data quality rules related to the size of the relevant data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#plainScore"></see></summary>
    let plainScore = Namespaced_IRI.parse _namespace_name "plainScore" |> NamespacedName
    /// <summary>
    /// Position of a value in an ordinal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName

    /// <summary>
    /// The reference class property points to the URI of a class that contains trusted instances, i.e. instances of high quality.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceClass"></see></summary>
    let referenceClass =
        Namespaced_IRI.parse _namespace_name "referenceClass" |> NamespacedName

    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty"></see></summary>
    let referenceProperty =
        Namespaced_IRI.parse _namespace_name "referenceProperty" |> NamespacedName

    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty1"></see></summary>
    let referenceProperty1 =
        Namespaced_IRI.parse _namespace_name "referenceProperty1" |> NamespacedName

    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty2"></see></summary>
    let referenceProperty2 =
        Namespaced_IRI.parse _namespace_name "referenceProperty2" |> NamespacedName

    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty3"></see></summary>
    let referenceProperty3 =
        Namespaced_IRI.parse _namespace_name "referenceProperty3" |> NamespacedName

    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty4"></see></summary>
    let referenceProperty4 =
        Namespaced_IRI.parse _namespace_name "referenceProperty4" |> NamespacedName

    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty5"></see></summary>
    let referenceProperty5 =
        Namespaced_IRI.parse _namespace_name "referenceProperty5" |> NamespacedName

    /// <summary>
    /// The regular expressions property can be used to express legal character ranges and data patterns for values of a certain property via regular expressions.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#regex"></see></summary>
    let regex = Namespaced_IRI.parse _namespace_name "regex" |> NamespacedName

    /// <summary>
    /// Describes a data requirement in natural language.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqDescription"></see></summary>
    let reqDescription =
        Namespaced_IRI.parse _namespace_name "reqDescription" |> NamespacedName

    /// <summary>
    /// Specifies the name of a data requirement in natural language.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqName"></see></summary>
    let reqName = Namespaced_IRI.parse _namespace_name "reqName" |> NamespacedName
    /// <summary>
    /// Specifies the source of a data requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqSource"></see></summary>
    let reqSource = Namespaced_IRI.parse _namespace_name "reqSource" |> NamespacedName

    /// <summary>
    /// Specifies whether a property must exist.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#requiredProperty"></see></summary>
    let requiredProperty =
        Namespaced_IRI.parse _namespace_name "requiredProperty" |> NamespacedName

    /// <summary>
    /// Specifies whether a value for a property must exist.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#requiredValue"></see></summary>
    let requiredValue =
        Namespaced_IRI.parse _namespace_name "requiredValue" |> NamespacedName

    /// <summary>
    /// The rule of identification property connects the data quality problem instances with the instance of the data requirement that has detected the problem.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ruleOfIdentification"></see></summary>
    let ruleOfIdentification =
        Namespaced_IRI.parse _namespace_name "ruleOfIdentification" |> NamespacedName

    /// <summary>
    /// Connects data requirements with data quality problems that have been identified using the requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ruleViolation"></see></summary>
    let ruleViolation =
        Namespaced_IRI.parse _namespace_name "ruleViolation" |> NamespacedName

    /// <summary>
    /// Type of statistical scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#scaleType"></see></summary>
    let scaleType = Namespaced_IRI.parse _namespace_name "scaleType" |> NamespacedName

    /// <summary>
    /// Links to values of a certain ordinal or nominal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#scaleValues"></see></summary>
    let scaleValues =
        Namespaced_IRI.parse _namespace_name "scaleValues" |> NamespacedName

    /// <summary>
    /// This property can store custom data requirements that are expressed via SPARQL queries.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#sparqlrule"></see></summary>
    let sparqlrule = Namespaced_IRI.parse _namespace_name "sparqlrule" |> NamespacedName
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found at the beginning of strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#startsWith"></see></summary>
    let startsWith = Namespaced_IRI.parse _namespace_name "startsWith" |> NamespacedName
    /// <summary>
    /// Property that can be used to represent hierachies of between tasks.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#subTaskOf"></see></summary>
    let subTaskOf = Namespaced_IRI.parse _namespace_name "subTaskOf" |> NamespacedName

    /// <summary>
    /// Specifies whether the data quality rule is task dependent.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#taskDependent"></see></summary>
    let taskDependent =
        Namespaced_IRI.parse _namespace_name "taskDependent" |> NamespacedName

    /// <summary>
    /// Describes the task in natural language.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#taskDescription"></see></summary>
    let taskDescription =
        Namespaced_IRI.parse _namespace_name "taskDescription" |> NamespacedName

    /// <summary>
    /// Specifies the name of the task.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#taskName"></see></summary>
    let taskName = Namespaced_IRI.parse _namespace_name "taskName" |> NamespacedName

    /// <summary>
    /// Technical name of a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#technicalName"></see></summary>
    let technicalName =
        Namespaced_IRI.parse _namespace_name "technicalName" |> NamespacedName

    /// <summary>
    /// The tested class property specifies the class that holds the instances that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedClass"></see></summary>
    let testedClass =
        Namespaced_IRI.parse _namespace_name "testedClass" |> NamespacedName

    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty"></see></summary>
    let testedProperty =
        Namespaced_IRI.parse _namespace_name "testedProperty" |> NamespacedName

    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty1"></see></summary>
    let testedProperty1 =
        Namespaced_IRI.parse _namespace_name "testedProperty1" |> NamespacedName

    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty2"></see></summary>
    let testedProperty2 =
        Namespaced_IRI.parse _namespace_name "testedProperty2" |> NamespacedName

    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty3"></see></summary>
    let testedProperty3 =
        Namespaced_IRI.parse _namespace_name "testedProperty3" |> NamespacedName

    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty4"></see></summary>
    let testedProperty4 =
        Namespaced_IRI.parse _namespace_name "testedProperty4" |> NamespacedName

    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty5"></see></summary>
    let testedProperty5 =
        Namespaced_IRI.parse _namespace_name "testedProperty5" |> NamespacedName

    /// <summary>
    /// The time of assessment represents the data and time when the data quality score was computed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfAssessment"></see></summary>
    let timeOfAssessment =
        Namespaced_IRI.parse _namespace_name "timeOfAssessment" |> NamespacedName

    /// <summary>
    /// The time of identification property specifies the date and time in which the data quality problem was detected
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfIdentification"></see></summary>
    let timeOfIdentification =
        Namespaced_IRI.parse _namespace_name "timeOfIdentification" |> NamespacedName

    /// <summary>
    /// Description of a unit of measurement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitDescription"></see></summary>
    let unitDescription =
        Namespaced_IRI.parse _namespace_name "unitDescription" |> NamespacedName

    /// <summary>
    /// Name of a unit of measurement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitName"></see></summary>
    let unitName = Namespaced_IRI.parse _namespace_name "unitName" |> NamespacedName

    /// <summary>
    /// The unit in which confidence is expressed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfConfidence"></see></summary>
    let unitOfConfidence =
        Namespaced_IRI.parse _namespace_name "unitOfConfidence" |> NamespacedName

    /// <summary>
    /// The unit in which importance is expressed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfImportance"></see></summary>
    let unitOfImportance =
        Namespaced_IRI.parse _namespace_name "unitOfImportance" |> NamespacedName

    /// <summary>
    /// Indicates the unit of measurement, e.g. of data quality scores. It is recommended to use UN/CEFACT common codes to specify the unit of measurement, e.g. "P1" stands for percent.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfMeasurement"></see></summary>
    let unitOfMeasurement =
        Namespaced_IRI.parse _namespace_name "unitOfMeasurement" |> NamespacedName

    /// <summary>
    /// Specifies the upper limit a numeric property value shall obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#upperLimit"></see></summary>
    let upperLimit = Namespaced_IRI.parse _namespace_name "upperLimit" |> NamespacedName
    /// <summary>
    /// Specifies the date and time from which a rule is valid.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName
    /// <summary>
    /// Specifies the date and time until a rule stays valid.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName
    /// <summary>
    /// Validation indicates whether a data quality rule shall be used for validation during data entry.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#validation"></see></summary>
    let validation = Namespaced_IRI.parse _namespace_name "validation" |> NamespacedName

    /// <summary>
    /// Meaning of a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#valueMeaning"></see></summary>
    let valueMeaning =
        Namespaced_IRI.parse _namespace_name "valueMeaning" |> NamespacedName

    /// <summary>
    /// A weighted score is a data quality dimension score that is computed by integration of importance values of data requirements, tasks, or data elements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#weightedScore"></see></summary>
    let weightedScore =
        Namespaced_IRI.parse _namespace_name "weightedScore" |> NamespacedName
