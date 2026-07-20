namespace http.purl.org.dqm_vocabulary.v1.dqm.hash

open DoxAletheia

module dqm =
    let _namespace_name = "http://purl.org/dqm-vocabulary/v1/dqm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Accuracy is the degree to which a data value represents the desired state regarding its syntax and semantics.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Accuracy"></see></summary>
    let Accuracy = _prefix "Accuracy"
    /// <summary>
    /// Data quality score is an abstract class that can be used to structure data quality dimension scores that indicate the quality state of classes and/or properties.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataQualityScore"></see></summary>
    let DataQualityScore = _prefix "DataQualityScore"
    /// <summary>
    /// An affected class holds one or more affected instances
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedClass"></see></summary>
    let AffectedClass = _prefix "AffectedClass"
    /// <summary>
    /// A data element is a class, a property, an instance, or a literal value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataElement"></see></summary>
    let DataElement = _prefix "DataElement"
    /// <summary>
    /// An affected instance is a data instance that contains one or more data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedInstance"></see></summary>
    let AffectedInstance = _prefix "AffectedInstance"
    /// <summary>
    /// An affected property specifies the property of a data instance that contains one or more data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedProperty"></see></summary>
    let AffectedProperty = _prefix "AffectedProperty"
    /// <summary>
    /// A blacklist class holds instances with values that are disallowed for a certain data set. Thus, illegal value rules refer to such classes over the blacklist class property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistClass"></see></summary>
    let BlacklistClass = _prefix "BlacklistClass"
    /// <summary>
    /// A blacklist property holds the values that are disallowed for a certain data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistProperty"></see></summary>
    let BlacklistProperty = _prefix "BlacklistProperty"
    /// <summary>
    /// A class requirement is a data requirement that refers to the instances of a class as a whole.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ClassRequirement"></see></summary>
    let ClassRequirement = _prefix "ClassRequirement"
    /// <summary>
    /// A data requirement is a prescribed directive or consensual agreement that defines the content and/or structure that constitute high quality data instances and values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirement"></see></summary>
    let DataRequirement = _prefix "DataRequirement"
    /// <summary>
    /// Completeness is the extent to which data are of sufficient breadth, depth, and scope for the task at hand.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Completeness"></see></summary>
    let Completeness = _prefix "Completeness"
    /// <summary>
    /// A condition constrains instances of a class to a certain subset for which certain data quality rules apply.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Condition"></see></summary>
    let Condition = _prefix "Condition"

    /// <summary>
    /// Conditional property completeness rules specify that a tested property and/or its literal values must exist when the value of another property obtains a certain state. E.g. the property foo:state must exist and have a value when the property foo:country obtains the value "USA".
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalPropertyCompletenessRule"></see></summary>
    let ConditionalPropertyCompletenessRule =
        _prefix "ConditionalPropertyCompletenessRule"

    /// <summary>
    /// A conditional rule is a multi property requirement that can be used to specify that values of a tested property A must always obtain a certain state under the condition that values of another property B obtain a certain state (condition).
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalRule"></see></summary>
    let ConditionalRule = _prefix "ConditionalRule"
    /// <summary>
    /// Multi property requirements are data requirements that consider values from two or more properties.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyRequirement"></see></summary>
    let MultiPropertyRequirement = _prefix "MultiPropertyRequirement"
    /// <summary>
    /// Conditional syntax rules define that the literal values of a tested property must follow a certain syntax when the value of another property obtains a certain state. E.g. the property foo:state must have a value with two capital letters when the property foo:country obtains the value "USA".
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalSyntaxRule"></see></summary>
    let ConditionalSyntaxRule = _prefix "ConditionalSyntaxRule"
    /// <summary>
    /// A custom requirement is a data requirement that is expressed via a SPARQL query.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#CustomRequirement"></see></summary>
    let CustomRequirement = _prefix "CustomRequirement"
    /// <summary>
    /// A data cleansing rule is an unambiguous rule that precisely specifies the required state of a data value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataCleansingRule"></see></summary>
    let DataCleansingRule = _prefix "DataCleansingRule"
    /// <summary>
    /// A data requirement violation occurs when a data value or a data instance does not meet its requirements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirementViolation"></see></summary>
    let DataRequirementViolation = _prefix "DataRequirementViolation"
    /// <summary>
    /// Two or more instances are duplicates when they represent the same real world entity.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstance"></see></summary>
    let DuplicateInstance = _prefix "DuplicateInstance"
    /// <summary>
    /// A duplicate instance rule is a multi property requirement which specifies the properties that (when seen together) uniquely identify an entity. I.e. if the properties of two or more different instances represent the same state, then the instances represent the same entity. Thus, the instances are considered to be duplicates.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstanceRule"></see></summary>
    let DuplicateInstanceRule = _prefix "DuplicateInstanceRule"
    /// <summary>
    /// Matching value rules are multi property requirements in which the property values of other instances are used to identify data requirements violations in an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MatchingValueRule"></see></summary>
    let MatchingValueRule = _prefix "MatchingValueRule"
    /// <summary>
    /// An expiry rule is an outdated instance rule that specifies the expiration date of an instance that must not exceed the current date and time. Therefore, expiry rules require date information about the validity period of an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ExpiryRule"></see></summary>
    let ExpiryRule = _prefix "ExpiryRule"
    /// <summary>
    /// An outdated instance rule is a data requirement that specifies the point in time when an instance is not current anymore.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstanceRule"></see></summary>
    let OutdatedInstanceRule = _prefix "OutdatedInstanceRule"
    /// <summary>
    /// A functional dependency reference rule is a multi property requirement that specifies legal value combinations for two or more properties that are allowed to occur within the same instance. Functional dependency reference rules refer to reference properties of classes that hold instances with all allowed value combinations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepReferenceRule"></see></summary>
    let FuncDepReferenceRule = _prefix "FuncDepReferenceRule"
    /// <summary>
    /// A functionally dependent value rule defines that the value of a tested property must have a certain value when the values of other properties obtain certain states (conditions). E.g. the property foo:inStock must have value "true" when the property foo:availableAmount is greater than zero.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepValueRule"></see></summary>
    let FuncDepValueRule = _prefix "FuncDepValueRule"
    /// <summary>
    /// A functional dependency violation is a combination of different property values within the same instance that must not occur together. E.g. an instance describing the man “Peter Miller” has the value “Mr.” as salutation property, but the value “female” as sex.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#FunctionalDependencyViolation"></see></summary>
    let FunctionalDependencyViolation = _prefix "FunctionalDependencyViolation"
    /// <summary>
    /// An illegal value is a data value that must not be used for a property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValue"></see></summary>
    let IllegalValue = _prefix "IllegalValue"
    /// <summary>
    /// An illegal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property must not obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRangeRule"></see></summary>
    let IllegalValueRangeRule = _prefix "IllegalValueRangeRule"
    /// <summary>
    /// Property requirements are data requirements that are related to values of a single property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyRequirement"></see></summary>
    let PropertyRequirement = _prefix "PropertyRequirement"
    /// <summary>
    /// An illegal value rule is a property requirement that specifies the values that a certain property must not obtain. Illegal value rules, therefore, refer to reference properties that hold all disallowed values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRule"></see></summary>
    let IllegalValueRule = _prefix "IllegalValueRule"
    /// <summary>
    /// A legal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property is allowed to obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRangeRule"></see></summary>
    let LegalValueRangeRule = _prefix "LegalValueRangeRule"
    /// <summary>
    /// A legal value rule is a property requirement that specifies all values that a certain property is allowed to obtain. Legal value rules, therefore, refer to reference properties of classes that hold instances with all allowed values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRule"></see></summary>
    let LegalValueRule = _prefix "LegalValueRule"
    /// <summary>
    /// Literal cleansing rules can be used to cleanse the literal values of a certain property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#LiteralCleansingRule"></see></summary>
    let LiteralCleansingRule = _prefix "LiteralCleansingRule"
    /// <summary>
    /// A missing element is a data requirement violation that occurs when schema elements, instances, or data values are missing, but required.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingElement"></see></summary>
    let MissingElement = _prefix "MissingElement"
    /// <summary>
    /// A property is missing when an instances does not contain a specific property that is required.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingProperty"></see></summary>
    let MissingProperty = _prefix "MissingProperty"
    /// <summary>
    /// Class for instances that miss both a property and its value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingPropertyAndValue"></see></summary>
    let MissingPropertyAndValue = _prefix "MissingPropertyAndValue"
    /// <summary>
    /// A missing value occurs when a property of an instance does not hold a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MissingValue"></see></summary>
    let MissingValue = _prefix "MissingValue"
    /// <summary>
    /// Multi property cleansing rules can be used to cleanse the literal values of two or more dependent properties.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyCleansingRule"></see></summary>
    let MultiPropertyCleansingRule = _prefix "MultiPropertyCleansingRule"
    /// <summary>
    /// A value is out of range when it is not part of the legal value range or when it is part of the illegal value range.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#OutOfRangeValue"></see></summary>
    let OutOfRangeValue = _prefix "OutOfRangeValue"
    /// <summary>
    /// An instance is outdated when it represents an outdated state of its corresponding real-world entity.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstance"></see></summary>
    let OutdatedInstance = _prefix "OutdatedInstance"
    /// <summary>
    /// Population completeness is the degree to which all objects of a certain reference are represented in a specific class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationCompleteness"></see></summary>
    let PopulationCompleteness = _prefix "PopulationCompleteness"
    /// <summary>
    /// Entity uniqueness is the degree to which entities (that must be uniquely represented within a certain class) are unique.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationUniqueness"></see></summary>
    let PopulationUniqueness = _prefix "PopulationUniqueness"
    /// <summary>
    /// Uniqueness is the degree to which properties and classes are free of duplicate values and instances.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Uniqueness"></see></summary>
    let Uniqueness = _prefix "Uniqueness"
    /// <summary>
    /// Property completeness is the degree to which values for a specific property are missing in entities of a specific class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompleteness"></see></summary>
    let PropertyCompleteness = _prefix "PropertyCompleteness"
    /// <summary>
    /// A property completeness rule is a data requirement that specifies that a certain property and/or its value must exist in all instances of a certain class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletenessRule"></see></summary>
    let PropertyCompletenessRule = _prefix "PropertyCompletenessRule"
    /// <summary>
    /// A property completion rule specifies a property and value that shall be added to certain instances.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletion"></see></summary>
    let PropertyCompletion = _prefix "PropertyCompletion"
    /// <summary>
    /// Property uniqueness is the degree to which the values of a property (that must only contain unique values within instances of a certain class) are unique.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyUniqueness"></see></summary>
    let PropertyUniqueness = _prefix "PropertyUniqueness"
    /// <summary>
    /// A scale value is a value of a nominal or ordinal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ScaleValue"></see></summary>
    let ScaleValue = _prefix "ScaleValue"
    /// <summary>
    /// Semantic accuracy is the degree to which the data values of an instance represent the correct state of an entity’s property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SemanticAccuracy"></see></summary>
    let SemanticAccuracy = _prefix "SemanticAccuracy"
    /// <summary>
    /// A strict value combination is a combination of two values of different properties that may only be assigned to each other, but not to other values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#StrictValueCombination"></see></summary>
    let StrictValueCombination = _prefix "StrictValueCombination"
    /// <summary>
    /// Syntactic accuracy is the degree to which data values of a property represent legal values and are free from syntax violations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SyntacticAccuracy"></see></summary>
    let SyntacticAccuracy = _prefix "SyntacticAccuracy"
    /// <summary>
    /// A syntax rule is a property requirement that specifies the allowed characters and/or character pattern to be used in values for a certain property in instances of a certain class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxRule"></see></summary>
    let SyntaxRule = _prefix "SyntaxRule"
    /// <summary>
    /// A syntax violation is a data requirement violation that occurs when a data value contains disallowed characters or does not match a predefined pattern.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxViolation"></see></summary>
    let SyntaxViolation = _prefix "SyntaxViolation"
    /// <summary>
    /// Classifies the tasks for which the data quality rule shall apply for.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// A tested class is a class that holds the instances that shall be analyzed for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TestedClass"></see></summary>
    let TestedClass = _prefix "TestedClass"
    /// <summary>
    /// A tested property holds the values to be analyzed for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TestedProperty"></see></summary>
    let TestedProperty = _prefix "TestedProperty"
    /// <summary>
    /// Timeliness is the degree to which instances of a specific class (1) are updated within an expected time or (2) have not exceeded their expiration date.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Timeliness"></see></summary>
    let Timeliness = _prefix "Timeliness"
    /// <summary>
    /// Legal value rules and functional dependency reference rules require the specification of a trusted class as a reference that holds instances with legal values / legal value combinations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedClass"></see></summary>
    let TrustedClass = _prefix "TrustedClass"
    /// <summary>
    /// A trusted property holds the values that serve as a trusted reference in legal value rules / functional dependency reference rules, e.g. to define legal values for a tested property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedProperty"></see></summary>
    let TrustedProperty = _prefix "TrustedProperty"
    /// <summary>
    /// A unique value rule is a property requirement that specifies that each value of a certain property must be unique in instances of a certain class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#UniqueValueRule"></see></summary>
    let UniqueValueRule = _prefix "UniqueValueRule"
    /// <summary>
    /// A uniqueness violation occurs when two or more identical values are assigned to a property that requires unique values.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#UniquenessViolation"></see></summary>
    let UniquenessViolation = _prefix "UniquenessViolation"
    /// <summary>
    /// Class for units of numerical values that are used to express certain property states.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// An update rule is an outdated instance rule that specifies the maximum duration tolerated without any updates. Update rules require timestamps about the last update of an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#UpdateRule"></see></summary>
    let UpdateRule = _prefix "UpdateRule"
    /// <summary>
    /// A value substitution rule specifies a value to be removed and a new value that shall substitute the removed value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ValueSubstitution"></see></summary>
    let ValueSubstitution = _prefix "ValueSubstitution"
    /// <summary>
    /// A white space removal rule states that whitespaces at the beginning of a string and at the end of a string shall be removed for the specified property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#WhitespaceRemoval"></see></summary>
    let WhitespaceRemoval = _prefix "WhitespaceRemoval"
    /// <summary>
    /// A property that shall be added to an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#addProperty"></see></summary>
    let addProperty = _prefix "addProperty"
    /// <summary>
    /// Cleansing properties are properties of data cleansing rules.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansingProperty"></see></summary>
    let cleansingProperty = _prefix "cleansingProperty"
    /// <summary>
    /// A value that shall be added to a property of an instance.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#addValue"></see></summary>
    let addValue = _prefix "addValue"
    /// <summary>
    /// An affected class holds one or more instances with one or more data requirement violations.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#affectedClass"></see></summary>
    let affectedClass = _prefix "affectedClass"
    /// <summary>
    /// The data element relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data elements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#dataElementRelationship"></see></summary>
    let dataElementRelationship = _prefix "dataElementRelationship"
    /// <summary>
    ///   <see href="http://purl.org/dqm-vocabulary/v1/dqm#affectedInstance"></see>
    /// </summary>
    let affectedInstance = _prefix "affectedInstance"
    /// <summary>
    ///   <see href="http://purl.org/dqm-vocabulary/v1/dqm#affectedProperty"></see>
    /// </summary>
    let affectedProperty = _prefix "affectedProperty"
    /// <summary>
    /// Connects data requirements with the tasks in which the requirement applies.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#appliesFor"></see></summary>
    let appliesFor = _prefix "appliesFor"
    /// <summary>
    /// The data requirements relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data requirements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#dataRequirementsRelationship"></see></summary>
    let dataRequirementsRelationship = _prefix "dataRequirementsRelationship"
    /// <summary>
    /// Specifies the data requirements that have to be fulfilled to perform the task.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasRequirement"></see></summary>
    let hasRequirement = _prefix "hasRequirement"
    /// <summary>
    /// The assessed class is the class that holds the instances that have been analyzed to compute the assessment score.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#assessedClass"></see></summary>
    let assessedClass = _prefix "assessedClass"
    /// <summary>
    /// The assessed property represents all properties that have been tested for rule violations during the computation of the assessment score.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#assessedProperty"></see></summary>
    let assessedProperty = _prefix "assessedProperty"
    /// <summary>
    /// The assessment property indicates whether the rule shall be used for data quality assessment.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#assessment"></see></summary>
    let assessment = _prefix "assessment"
    /// <summary>
    /// An abstract property that holds generic datatype properties that describe a data requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqMetadata"></see></summary>
    let reqMetadata = _prefix "reqMetadata"
    /// <summary>
    /// Connects a data quality score with the data requirements that were used to calculate the score.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#basedOn"></see></summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    /// Connects data requirements with the data quality score which was calculated based on the requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasScore"></see></summary>
    let hasScore = _prefix "hasScore"
    /// <summary>
    /// A blacklist class holds instances with values that are disallowed for a certain data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistClass"></see></summary>
    let blacklistClass = _prefix "blacklistClass"
    /// <summary>
    /// A blacklist property holds the values that are disallowed for a certain data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistProperty"></see></summary>
    let blacklistProperty = _prefix "blacklistProperty"
    /// <summary>
    /// This property identifies classes that contain instances that shall be cleansed via a data cleansing rule.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesClass"></see></summary>
    let cleansesClass = _prefix "cleansesClass"
    /// <summary>
    /// Data cleansing rule relationships are object properties of the data cleansing rules.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#dataCleansingRuleRelationship"></see></summary>
    let dataCleansingRuleRelationship = _prefix "dataCleansingRuleRelationship"
    /// <summary>
    /// This property identifies a property that holds values that shall be cleansed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesProperty1"></see></summary>
    let cleansesProperty1 = _prefix "cleansesProperty1"
    /// <summary>
    /// The data cleansing property specifies whether the rule shall be applied to cleanse the data in a data source.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#cleansing"></see></summary>
    let cleansing = _prefix "cleansing"
    /// <summary>
    /// UN/CEFACT common code of a unit of measurement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#commonCode"></see></summary>
    let commonCode = _prefix "commonCode"
    /// <summary>
    /// The conditional property property indicates the URI of a property that holds values that can be used to filter the relevant subset of data for which a rule applies.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#conditionalProperty"></see></summary>
    let conditionalProperty = _prefix "conditionalProperty"
    /// <summary>
    /// The confidence property indicates how confident a rule creators is regarding the correctness of the rule.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#confidence"></see></summary>
    let confidence = _prefix "confidence"
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found in strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// The operated value property is an abstract property for datatype properties that are used to express string filtering criteria.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#operatedValue"></see></summary>
    let operatedValue = _prefix "operatedValue"
    /// <summary>
    /// The current value propertiy specifies the value to be removed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#currentValue"></see></summary>
    let currentValue = _prefix "currentValue"
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found at the end of strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#endsWith"></see></summary>
    let endsWith = _prefix "endsWith"
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found in the same order in strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#equals"></see></summary>
    let equals = _prefix "equals"
    /// <summary>
    /// The expected update interval specifies the time interval in which instances of a specific class must be updated in order to be current.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#expectedUpdateInterval"></see></summary>
    let expectedUpdateInterval = _prefix "expectedUpdateInterval"
    /// <summary>
    /// The filtering property indicates whether the rule shall be used for information filtering, i.e. only high quality data is retrieved.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#filtering"></see></summary>
    let filtering = _prefix "filtering"
    /// <summary>
    /// Holds a numeric value that is used to identify values of a property that are greater than the value of this property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#greaterThan"></see></summary>
    let greaterThan = _prefix "greaterThan"
    /// <summary>
    /// Connects a conditional rule with a certain condition
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition"></see></summary>
    let hasCondition = _prefix "hasCondition"
    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition1"></see></summary>
    let hasCondition1 = _prefix "hasCondition1"
    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition2"></see></summary>
    let hasCondition2 = _prefix "hasCondition2"
    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition3"></see></summary>
    let hasCondition3 = _prefix "hasCondition3"
    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition4"></see></summary>
    let hasCondition4 = _prefix "hasCondition4"
    /// <summary>
    /// Connects a conditional rule with a certain condition.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition5"></see></summary>
    let hasCondition5 = _prefix "hasCondition5"
    /// <summary>
    /// Reconnects mapped classes and properties with each other.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasProperties"></see></summary>
    let hasProperties = _prefix "hasProperties"
    /// <summary>
    /// The hasURI property is used to map properties to instances of a class.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#hasURI"></see></summary>
    let hasURI = _prefix "hasURI"
    /// <summary>
    /// Specifies the importance of a task, a data quality rule, or a data element.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#importance"></see></summary>
    let importance = _prefix "importance"
    /// <summary>
    /// The property lastModified indicates the date and time when the rule was last modified.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// Holds a numeric value that is used to identify values of a property that are less than the value of this property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#lessThan"></see></summary>
    let lessThan = _prefix "lessThan"
    /// <summary>
    /// Specifies the lower limit a numeric property value shall obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#lowerLimit"></see></summary>
    let lowerLimit = _prefix "lowerLimit"
    /// <summary>
    /// The new value property specifies the new value which shall substitute the current value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#newValue"></see></summary>
    let newValue = _prefix "newValue"
    /// <summary>
    /// Links an instances to the next instance in an ordinal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// Holds one or more consecutive characters that are used to identify values of another property that do not match with the value of this property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#notEqualTo"></see></summary>
    let notEqualTo = _prefix "notEqualTo"
    /// <summary>
    /// Official name of a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#officialName"></see></summary>
    let officialName = _prefix "officialName"
    /// <summary>
    /// The pattern property can be used to express value patterns based on a simple syntax without the need for knowing regular expressions. E.g. the pattern "AaaaaNN" where "A" stands for capital letters, "a" for small letters, and "N" for numbers.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#pattern"></see></summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// The plain score represents a data quality dimension score that was assessed by using a certain formula that accounts for the violations of data quality rules related to the size of the relevant data set.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#plainScore"></see></summary>
    let plainScore = _prefix "plainScore"
    /// <summary>
    /// Position of a value in an ordinal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#rank"></see></summary>
    let rank = _prefix "rank"
    /// <summary>
    /// The reference class property points to the URI of a class that contains trusted instances, i.e. instances of high quality.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceClass"></see></summary>
    let referenceClass = _prefix "referenceClass"
    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty"></see></summary>
    let referenceProperty = _prefix "referenceProperty"
    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty1"></see></summary>
    let referenceProperty1 = _prefix "referenceProperty1"
    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty2"></see></summary>
    let referenceProperty2 = _prefix "referenceProperty2"
    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty3"></see></summary>
    let referenceProperty3 = _prefix "referenceProperty3"
    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty4"></see></summary>
    let referenceProperty4 = _prefix "referenceProperty4"
    /// <summary>
    /// The reference property points to the URI of a property that holds trusted values, i.e. values of high quality
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty5"></see></summary>
    let referenceProperty5 = _prefix "referenceProperty5"
    /// <summary>
    /// The regular expressions property can be used to express legal character ranges and data patterns for values of a certain property via regular expressions.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#regex"></see></summary>
    let regex = _prefix "regex"
    /// <summary>
    /// Describes a data requirement in natural language.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqDescription"></see></summary>
    let reqDescription = _prefix "reqDescription"
    /// <summary>
    /// Specifies the name of a data requirement in natural language.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqName"></see></summary>
    let reqName = _prefix "reqName"
    /// <summary>
    /// Specifies the source of a data requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#reqSource"></see></summary>
    let reqSource = _prefix "reqSource"
    /// <summary>
    /// Specifies whether a property must exist.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#requiredProperty"></see></summary>
    let requiredProperty = _prefix "requiredProperty"
    /// <summary>
    /// Specifies whether a value for a property must exist.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#requiredValue"></see></summary>
    let requiredValue = _prefix "requiredValue"
    /// <summary>
    /// The rule of identification property connects the data quality problem instances with the instance of the data requirement that has detected the problem.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ruleOfIdentification"></see></summary>
    let ruleOfIdentification = _prefix "ruleOfIdentification"
    /// <summary>
    /// Connects data requirements with data quality problems that have been identified using the requirement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#ruleViolation"></see></summary>
    let ruleViolation = _prefix "ruleViolation"
    /// <summary>
    /// Type of statistical scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#scaleType"></see></summary>
    let scaleType = _prefix "scaleType"
    /// <summary>
    /// Links to values of a certain ordinal or nominal scale.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#scaleValues"></see></summary>
    let scaleValues = _prefix "scaleValues"
    /// <summary>
    /// This property can store custom data requirements that are expressed via SPARQL queries.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#sparqlrule"></see></summary>
    let sparqlrule = _prefix "sparqlrule"
    /// <summary>
    /// Holds one or more consecutive characters that are supposed to be found at the beginning of strings of another property.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#startsWith"></see></summary>
    let startsWith = _prefix "startsWith"
    /// <summary>
    /// Property that can be used to represent hierachies of between tasks.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#subTaskOf"></see></summary>
    let subTaskOf = _prefix "subTaskOf"
    /// <summary>
    /// Specifies whether the data quality rule is task dependent.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#taskDependent"></see></summary>
    let taskDependent = _prefix "taskDependent"
    /// <summary>
    /// Describes the task in natural language.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#taskDescription"></see></summary>
    let taskDescription = _prefix "taskDescription"
    /// <summary>
    /// Specifies the name of the task.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#taskName"></see></summary>
    let taskName = _prefix "taskName"
    /// <summary>
    /// Technical name of a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#technicalName"></see></summary>
    let technicalName = _prefix "technicalName"
    /// <summary>
    /// The tested class property specifies the class that holds the instances that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedClass"></see></summary>
    let testedClass = _prefix "testedClass"
    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty"></see></summary>
    let testedProperty = _prefix "testedProperty"
    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty1"></see></summary>
    let testedProperty1 = _prefix "testedProperty1"
    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty2"></see></summary>
    let testedProperty2 = _prefix "testedProperty2"
    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty3"></see></summary>
    let testedProperty3 = _prefix "testedProperty3"
    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty4"></see></summary>
    let testedProperty4 = _prefix "testedProperty4"
    /// <summary>
    /// The property with the values that shall be tested for data quality problems.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty5"></see></summary>
    let testedProperty5 = _prefix "testedProperty5"
    /// <summary>
    /// The time of assessment represents the data and time when the data quality score was computed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfAssessment"></see></summary>
    let timeOfAssessment = _prefix "timeOfAssessment"
    /// <summary>
    /// The time of identification property specifies the date and time in which the data quality problem was detected
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfIdentification"></see></summary>
    let timeOfIdentification = _prefix "timeOfIdentification"
    /// <summary>
    /// Description of a unit of measurement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitDescription"></see></summary>
    let unitDescription = _prefix "unitDescription"
    /// <summary>
    /// Name of a unit of measurement.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitName"></see></summary>
    let unitName = _prefix "unitName"
    /// <summary>
    /// The unit in which confidence is expressed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfConfidence"></see></summary>
    let unitOfConfidence = _prefix "unitOfConfidence"
    /// <summary>
    /// The unit in which importance is expressed.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfImportance"></see></summary>
    let unitOfImportance = _prefix "unitOfImportance"
    /// <summary>
    /// Indicates the unit of measurement, e.g. of data quality scores. It is recommended to use UN/CEFACT common codes to specify the unit of measurement, e.g. "P1" stands for percent.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfMeasurement"></see></summary>
    let unitOfMeasurement = _prefix "unitOfMeasurement"
    /// <summary>
    /// Specifies the upper limit a numeric property value shall obtain.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#upperLimit"></see></summary>
    let upperLimit = _prefix "upperLimit"
    /// <summary>
    /// Specifies the date and time from which a rule is valid.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// Specifies the date and time until a rule stays valid.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    /// Validation indicates whether a data quality rule shall be used for validation during data entry.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#validation"></see></summary>
    let validation = _prefix "validation"
    /// <summary>
    /// Meaning of a value.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#valueMeaning"></see></summary>
    let valueMeaning = _prefix "valueMeaning"
    /// <summary>
    /// A weighted score is a data quality dimension score that is computed by integration of importance values of data requirements, tasks, or data elements.
    /// <see href="http://purl.org/dqm-vocabulary/v1/dqm#weightedScore"></see></summary>
    let weightedScore = _prefix "weightedScore"
