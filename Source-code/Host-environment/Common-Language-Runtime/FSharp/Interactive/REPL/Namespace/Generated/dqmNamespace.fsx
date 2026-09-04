#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dqm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/dqm-vocabulary/v1/dqm#" "dqm"

    /// <summary>
    ///   <para>rdfs:label : Accuracy</para>
    ///   <para>rdfs:comment : Accuracy is the degree to which a data value represents the desired state regarding its syntax and semantics.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Accuracy">dqm:Accuracy</a>
    /// </summary>
    let Accuracy = _prefixId.prefix "Accuracy"
    /// <summary>
    ///   <para>rdfs:label : Affected Class^^xsd:string</para>
    ///   <para>rdfs:comment : An affected class holds one or more affected instances</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedClass">dqm:AffectedClass</a>
    /// </summary>
    let AffectedClass = _prefixId.prefix "AffectedClass"
    /// <summary>
    ///   <para>rdfs:comment : An affected instance is a data instance that contains one or more data quality problems.</para>
    ///   <para>rdfs:label : Affected Instance</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedInstance">dqm:AffectedInstance</a>
    /// </summary>
    let AffectedInstance = _prefixId.prefix "AffectedInstance"
    /// <summary>
    ///   <para>rdfs:comment : An affected property specifies the property of a data instance that contains one or more data quality problems.</para>
    ///   <para>rdfs:label : Affected Property^^xsd:string</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedProperty">dqm:AffectedProperty</a>
    /// </summary>
    let AffectedProperty = _prefixId.prefix "AffectedProperty"
    /// <summary>
    ///   <para>rdfs:label : Blacklist Class</para>
    ///   <para>rdfs:comment : A blacklist class holds instances with values that are disallowed for a certain data set. Thus, illegal value rules refer to such classes over the blacklist class property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistClass">dqm:BlacklistClass</a>
    /// </summary>
    let BlacklistClass = _prefixId.prefix "BlacklistClass"
    /// <summary>
    ///   <para>rdfs:label : Blacklist Property</para>
    ///   <para>rdfs:comment : A blacklist property holds the values that are disallowed for a certain data set.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistProperty">dqm:BlacklistProperty</a>
    /// </summary>
    let BlacklistProperty = _prefixId.prefix "BlacklistProperty"
    /// <summary>
    ///   <para>rdfs:comment : A class requirement is a data requirement that refers to the instances of a class as a whole.</para>
    ///   <para>rdfs:label : Class Requirement</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ClassRequirement">dqm:ClassRequirement</a>
    /// </summary>
    let ClassRequirement = _prefixId.prefix "ClassRequirement"
    /// <summary>
    ///   <para>rdfs:label : Completeness</para>
    ///   <para>rdfs:comment : Completeness is the extent to which data are of sufficient breadth, depth, and scope for the task at hand.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Completeness">dqm:Completeness</a>
    /// </summary>
    let Completeness = _prefixId.prefix "Completeness"
    /// <summary>
    ///   <para>rdfs:comment : A condition constrains instances of a class to a certain subset for which certain data quality rules apply.</para>
    ///   <para>rdfs:label : Condition</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Condition">dqm:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"

    /// <summary>
    ///   <para>rdfs:comment : Conditional property completeness rules specify that a tested property and/or its literal values must exist when the value of another property obtains a certain state. E.g. the property foo:state must exist and have a value when the property foo:country obtains the value "USA".</para>
    ///   <para>rdfs:label : Conditional Data Competeness Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalPropertyCompletenessRule">dqm:ConditionalPropertyCompletenessRule</a>
    /// </summary>
    let ConditionalPropertyCompletenessRule =
        _prefixId.prefix "ConditionalPropertyCompletenessRule"

    /// <summary>
    ///   <para>rdfs:comment : A conditional rule is a multi property requirement that can be used to specify that values of a tested property A must always obtain a certain state under the condition that values of another property B obtain a certain state (condition).</para>
    ///   <para>rdfs:label : Conditional Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalRule">dqm:ConditionalRule</a>
    /// </summary>
    let ConditionalRule = _prefixId.prefix "ConditionalRule"
    /// <summary>
    ///   <para>rdfs:comment : Conditional syntax rules define that the literal values of a tested property must follow a certain syntax when the value of another property obtains a certain state. E.g. the property foo:state must have a value with two capital letters when the property foo:country obtains the value "USA".</para>
    ///   <para>rdfs:label : Conditional Syntax Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalSyntaxRule">dqm:ConditionalSyntaxRule</a>
    /// </summary>
    let ConditionalSyntaxRule = _prefixId.prefix "ConditionalSyntaxRule"
    /// <summary>
    ///   <para>rdfs:label : Custom Requirement</para>
    ///   <para>rdfs:comment : A custom requirement is a data requirement that is expressed via a SPARQL query.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#CustomRequirement">dqm:CustomRequirement</a>
    /// </summary>
    let CustomRequirement = _prefixId.prefix "CustomRequirement"
    /// <summary>
    ///   <para>rdfs:comment : A data cleansing rule is an unambiguous rule that precisely specifies the required state of a data value.</para>
    ///   <para>rdfs:label : Data Cleansing Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DataCleansingRule">dqm:DataCleansingRule</a>
    /// </summary>
    let DataCleansingRule = _prefixId.prefix "DataCleansingRule"
    /// <summary>
    ///   <para>rdfs:comment : A data element is a class, a property, an instance, or a literal value.</para>
    ///   <para>rdfs:label : Data Element</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DataElement">dqm:DataElement</a>
    /// </summary>
    let DataElement = _prefixId.prefix "DataElement"
    /// <summary>
    ///   <para>rdfs:label : Data Quality Assessment</para>
    ///   <para>rdfs:comment : Data quality score is an abstract class that can be used to structure data quality dimension scores that indicate the quality state of classes and/or properties.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DataQualityScore">dqm:DataQualityScore</a>
    /// </summary>
    let DataQualityScore = _prefixId.prefix "DataQualityScore"
    /// <summary>
    ///   <para>rdfs:label : Data Requirement</para>
    ///   <para>rdfs:comment : A data requirement is a prescribed directive or consensual agreement that defines the content and/or structure that constitute high quality data instances and values.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirement">dqm:DataRequirement</a>
    /// </summary>
    let DataRequirement = _prefixId.prefix "DataRequirement"
    /// <summary>
    ///   <para>rdfs:comment : A data requirement violation occurs when a data value or a data instance does not meet its requirements.</para>
    ///   <para>rdfs:label : Data Requirement Violation</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirementViolation">dqm:DataRequirementViolation</a>
    /// </summary>
    let DataRequirementViolation = _prefixId.prefix "DataRequirementViolation"
    /// <summary>
    ///   <para>rdfs:comment : Two or more instances are duplicates when they represent the same real world entity.</para>
    ///   <para>rdfs:label : Duplicate Instance</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstance">dqm:DuplicateInstance</a>
    /// </summary>
    let DuplicateInstance = _prefixId.prefix "DuplicateInstance"
    /// <summary>
    ///   <para>rdfs:label : Duplicate Instance Rule</para>
    ///   <para>rdfs:comment : A duplicate instance rule is a multi property requirement which specifies the properties that (when seen together) uniquely identify an entity. I.e. if the properties of two or more different instances represent the same state, then the instances represent the same entity. Thus, the instances are considered to be duplicates.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstanceRule">dqm:DuplicateInstanceRule</a>
    /// </summary>
    let DuplicateInstanceRule = _prefixId.prefix "DuplicateInstanceRule"
    /// <summary>
    ///   <para>rdfs:label : Expiry Rule</para>
    ///   <para>rdfs:comment : An expiry rule is an outdated instance rule that specifies the expiration date of an instance that must not exceed the current date and time. Therefore, expiry rules require date information about the validity period of an instance.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ExpiryRule">dqm:ExpiryRule</a>
    /// </summary>
    let ExpiryRule = _prefixId.prefix "ExpiryRule"
    /// <summary>
    ///   <para>rdfs:comment : A functional dependency reference rule is a multi property requirement that specifies legal value combinations for two or more properties that are allowed to occur within the same instance. Functional dependency reference rules refer to reference properties of classes that hold instances with all allowed value combinations.</para>
    ///   <para>rdfs:label : Functional Dependency Reference Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepReferenceRule">dqm:FuncDepReferenceRule</a>
    /// </summary>
    let FuncDepReferenceRule = _prefixId.prefix "FuncDepReferenceRule"
    /// <summary>
    ///   <para>rdfs:comment : A functionally dependent value rule defines that the value of a tested property must have a certain value when the values of other properties obtain certain states (conditions). E.g. the property foo:inStock must have value "true" when the property foo:availableAmount is greater than zero.</para>
    ///   <para>rdfs:label : Functionally Dependent Value Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepValueRule">dqm:FuncDepValueRule</a>
    /// </summary>
    let FuncDepValueRule = _prefixId.prefix "FuncDepValueRule"
    /// <summary>
    ///   <para>rdfs:label : Functional Dependency Violation</para>
    ///   <para>rdfs:comment : A functional dependency violation is a combination of different property values within the same instance that must not occur together. E.g. an instance describing the man “Peter Miller” has the value “Mr.” as salutation property, but the value “female” as sex.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#FunctionalDependencyViolation">dqm:FunctionalDependencyViolation</a>
    /// </summary>
    let FunctionalDependencyViolation = _prefixId.prefix "FunctionalDependencyViolation"
    /// <summary>
    ///   <para>rdfs:comment : An illegal value is a data value that must not be used for a property.</para>
    ///   <para>rdfs:label : Illegal Value</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValue">dqm:IllegalValue</a>
    /// </summary>
    let IllegalValue = _prefixId.prefix "IllegalValue"
    /// <summary>
    ///   <para>rdfs:label : Illegal Value Range Rule</para>
    ///   <para>rdfs:comment : An illegal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property must not obtain.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRangeRule">dqm:IllegalValueRangeRule</a>
    /// </summary>
    let IllegalValueRangeRule = _prefixId.prefix "IllegalValueRangeRule"
    /// <summary>
    ///   <para>rdfs:comment : An illegal value rule is a property requirement that specifies the values that a certain property must not obtain. Illegal value rules, therefore, refer to reference properties that hold all disallowed values.</para>
    ///   <para>rdfs:label : Illegal Value Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRule">dqm:IllegalValueRule</a>
    /// </summary>
    let IllegalValueRule = _prefixId.prefix "IllegalValueRule"
    /// <summary>
    ///   <para>rdfs:comment : A legal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property is allowed to obtain.</para>
    ///   <para>rdfs:label : Legal Value Range Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRangeRule">dqm:LegalValueRangeRule</a>
    /// </summary>
    let LegalValueRangeRule = _prefixId.prefix "LegalValueRangeRule"
    /// <summary>
    ///   <para>rdfs:label : Legal Value Rule</para>
    ///   <para>rdfs:comment : A legal value rule is a property requirement that specifies all values that a certain property is allowed to obtain. Legal value rules, therefore, refer to reference properties of classes that hold instances with all allowed values.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRule">dqm:LegalValueRule</a>
    /// </summary>
    let LegalValueRule = _prefixId.prefix "LegalValueRule"
    /// <summary>
    ///   <para>rdfs:label : Literal Cleansing Rule</para>
    ///   <para>rdfs:comment : Literal cleansing rules can be used to cleanse the literal values of a certain property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#LiteralCleansingRule">dqm:LiteralCleansingRule</a>
    /// </summary>
    let LiteralCleansingRule = _prefixId.prefix "LiteralCleansingRule"
    /// <summary>
    ///   <para>rdfs:comment : Matching value rules are multi property requirements in which the property values of other instances are used to identify data requirements violations in an instance.</para>
    ///   <para>rdfs:label : Matching Value Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MatchingValueRule">dqm:MatchingValueRule</a>
    /// </summary>
    let MatchingValueRule = _prefixId.prefix "MatchingValueRule"
    /// <summary>
    ///   <para>rdfs:comment : A missing element is a data requirement violation that occurs when schema elements, instances, or data values are missing, but required.</para>
    ///   <para>rdfs:label : Missing Element</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MissingElement">dqm:MissingElement</a>
    /// </summary>
    let MissingElement = _prefixId.prefix "MissingElement"
    /// <summary>
    ///   <para>rdfs:comment : A property is missing when an instances does not contain a specific property that is required.</para>
    ///   <para>rdfs:label : Missing Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MissingProperty">dqm:MissingProperty</a>
    /// </summary>
    let MissingProperty = _prefixId.prefix "MissingProperty"
    /// <summary>
    ///   <para>rdfs:label : Missing Property and Value</para>
    ///   <para>rdfs:comment : Class for instances that miss both a property and its value.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MissingPropertyAndValue">dqm:MissingPropertyAndValue</a>
    /// </summary>
    let MissingPropertyAndValue = _prefixId.prefix "MissingPropertyAndValue"
    /// <summary>
    ///   <para>rdfs:comment : A missing value occurs when a property of an instance does not hold a value.</para>
    ///   <para>rdfs:label : Missing Value</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MissingValue">dqm:MissingValue</a>
    /// </summary>
    let MissingValue = _prefixId.prefix "MissingValue"
    /// <summary>
    ///   <para>rdfs:label : Multi Property Cleansing Rule</para>
    ///   <para>rdfs:comment : Multi property cleansing rules can be used to cleanse the literal values of two or more dependent properties.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyCleansingRule">dqm:MultiPropertyCleansingRule</a>
    /// </summary>
    let MultiPropertyCleansingRule = _prefixId.prefix "MultiPropertyCleansingRule"
    /// <summary>
    ///   <para>rdfs:comment : Multi property requirements are data requirements that consider values from two or more properties.</para>
    ///   <para>rdfs:label : Multi Property Requirement</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyRequirement">dqm:MultiPropertyRequirement</a>
    /// </summary>
    let MultiPropertyRequirement = _prefixId.prefix "MultiPropertyRequirement"
    /// <summary>
    ///   <para>rdfs:comment : A value is out of range when it is not part of the legal value range or when it is part of the illegal value range.</para>
    ///   <para>rdfs:label : Out of Range Value^^xsd:string</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#OutOfRangeValue">dqm:OutOfRangeValue</a>
    /// </summary>
    let OutOfRangeValue = _prefixId.prefix "OutOfRangeValue"
    /// <summary>
    ///   <para>rdfs:label : Outdated Instance</para>
    ///   <para>rdfs:comment : An instance is outdated when it represents an outdated state of its corresponding real-world entity.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstance">dqm:OutdatedInstance</a>
    /// </summary>
    let OutdatedInstance = _prefixId.prefix "OutdatedInstance"
    /// <summary>
    ///   <para>rdfs:label : Outdated Instance Rule</para>
    ///   <para>rdfs:comment : An outdated instance rule is a data requirement that specifies the point in time when an instance is not current anymore.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstanceRule">dqm:OutdatedInstanceRule</a>
    /// </summary>
    let OutdatedInstanceRule = _prefixId.prefix "OutdatedInstanceRule"
    /// <summary>
    ///   <para>rdfs:label : Population Completeness</para>
    ///   <para>rdfs:comment : Population completeness is the degree to which all objects of a certain reference are represented in a specific class.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationCompleteness">dqm:PopulationCompleteness</a>
    /// </summary>
    let PopulationCompleteness = _prefixId.prefix "PopulationCompleteness"
    /// <summary>
    ///   <para>rdfs:label : Population Uniqueness</para>
    ///   <para>rdfs:comment : Entity uniqueness is the degree to which entities (that must be uniquely represented within a certain class) are unique.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationUniqueness">dqm:PopulationUniqueness</a>
    /// </summary>
    let PopulationUniqueness = _prefixId.prefix "PopulationUniqueness"
    /// <summary>
    ///   <para>rdfs:label : Property Completeness</para>
    ///   <para>rdfs:comment : Property completeness is the degree to which values for a specific property are missing in entities of a specific class.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompleteness">dqm:PropertyCompleteness</a>
    /// </summary>
    let PropertyCompleteness = _prefixId.prefix "PropertyCompleteness"
    /// <summary>
    ///   <para>rdfs:comment : A property completeness rule is a data requirement that specifies that a certain property and/or its value must exist in all instances of a certain class.</para>
    ///   <para>rdfs:label : Property Completeness Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletenessRule">dqm:PropertyCompletenessRule</a>
    /// </summary>
    let PropertyCompletenessRule = _prefixId.prefix "PropertyCompletenessRule"
    /// <summary>
    ///   <para>rdfs:comment : A property completion rule specifies a property and value that shall be added to certain instances.</para>
    ///   <para>rdfs:label : Property Completion Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletion">dqm:PropertyCompletion</a>
    /// </summary>
    let PropertyCompletion = _prefixId.prefix "PropertyCompletion"
    /// <summary>
    ///   <para>rdfs:label : Property Requirement</para>
    ///   <para>rdfs:comment : Property requirements are data requirements that are related to values of a single property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyRequirement">dqm:PropertyRequirement</a>
    /// </summary>
    let PropertyRequirement = _prefixId.prefix "PropertyRequirement"
    /// <summary>
    ///   <para>rdfs:label : Property Uniqueness</para>
    ///   <para>rdfs:comment : Property uniqueness is the degree to which the values of a property (that must only contain unique values within instances of a certain class) are unique.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyUniqueness">dqm:PropertyUniqueness</a>
    /// </summary>
    let PropertyUniqueness = _prefixId.prefix "PropertyUniqueness"
    /// <summary>
    ///   <para>rdfs:label : Scale Value</para>
    ///   <para>rdfs:comment : A scale value is a value of a nominal or ordinal scale.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ScaleValue">dqm:ScaleValue</a>
    /// </summary>
    let ScaleValue = _prefixId.prefix "ScaleValue"
    /// <summary>
    ///   <para>rdfs:label : Semantic Accuracy</para>
    ///   <para>rdfs:comment : Semantic accuracy is the degree to which the data values of an instance represent the correct state of an entity’s property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#SemanticAccuracy">dqm:SemanticAccuracy</a>
    /// </summary>
    let SemanticAccuracy = _prefixId.prefix "SemanticAccuracy"
    /// <summary>
    ///   <para>rdfs:comment : A strict value combination is a combination of two values of different properties that may only be assigned to each other, but not to other values.</para>
    ///   <para>rdfs:label : Strict Value Combination Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#StrictValueCombination">dqm:StrictValueCombination</a>
    /// </summary>
    let StrictValueCombination = _prefixId.prefix "StrictValueCombination"
    /// <summary>
    ///   <para>rdfs:comment : Syntactic accuracy is the degree to which data values of a property represent legal values and are free from syntax violations.</para>
    ///   <para>rdfs:label : Syntactic Accuracy</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#SyntacticAccuracy">dqm:SyntacticAccuracy</a>
    /// </summary>
    let SyntacticAccuracy = _prefixId.prefix "SyntacticAccuracy"
    /// <summary>
    ///   <para>rdfs:label : Syntax Rule</para>
    ///   <para>rdfs:comment : A syntax rule is a property requirement that specifies the allowed characters and/or character pattern to be used in values for a certain property in instances of a certain class.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxRule">dqm:SyntaxRule</a>
    /// </summary>
    let SyntaxRule = _prefixId.prefix "SyntaxRule"
    /// <summary>
    ///   <para>rdfs:comment : A syntax violation is a data requirement violation that occurs when a data value contains disallowed characters or does not match a predefined pattern.</para>
    ///   <para>rdfs:label : Syntax Violation</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxViolation">dqm:SyntaxViolation</a>
    /// </summary>
    let SyntaxViolation = _prefixId.prefix "SyntaxViolation"
    /// <summary>
    ///   <para>rdfs:label : Task</para>
    ///   <para>rdfs:comment : Classifies the tasks for which the data quality rule shall apply for.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Task">dqm:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:comment : A tested class is a class that holds the instances that shall be analyzed for data quality problems.</para>
    ///   <para>rdfs:label : Tested Class</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#TestedClass">dqm:TestedClass</a>
    /// </summary>
    let TestedClass = _prefixId.prefix "TestedClass"
    /// <summary>
    ///   <para>rdfs:comment : A tested property holds the values to be analyzed for data quality problems.</para>
    ///   <para>rdfs:label : Tested Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#TestedProperty">dqm:TestedProperty</a>
    /// </summary>
    let TestedProperty = _prefixId.prefix "TestedProperty"
    /// <summary>
    ///   <para>rdfs:comment : Timeliness is the degree to which instances of a specific class (1) are updated within an expected time or (2) have not exceeded their expiration date.</para>
    ///   <para>rdfs:label : Timeliness</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Timeliness">dqm:Timeliness</a>
    /// </summary>
    let Timeliness = _prefixId.prefix "Timeliness"
    /// <summary>
    ///   <para>rdfs:comment : Legal value rules and functional dependency reference rules require the specification of a trusted class as a reference that holds instances with legal values / legal value combinations.</para>
    ///   <para>rdfs:label : Trusted Class</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedClass">dqm:TrustedClass</a>
    /// </summary>
    let TrustedClass = _prefixId.prefix "TrustedClass"
    /// <summary>
    ///   <para>rdfs:label : Trusted Property</para>
    ///   <para>rdfs:comment : A trusted property holds the values that serve as a trusted reference in legal value rules / functional dependency reference rules, e.g. to define legal values for a tested property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedProperty">dqm:TrustedProperty</a>
    /// </summary>
    let TrustedProperty = _prefixId.prefix "TrustedProperty"
    /// <summary>
    ///   <para>rdfs:comment : A unique value rule is a property requirement that specifies that each value of a certain property must be unique in instances of a certain class.</para>
    ///   <para>rdfs:label : Unique Value Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#UniqueValueRule">dqm:UniqueValueRule</a>
    /// </summary>
    let UniqueValueRule = _prefixId.prefix "UniqueValueRule"
    /// <summary>
    ///   <para>rdfs:comment : Uniqueness is the degree to which properties and classes are free of duplicate values and instances.</para>
    ///   <para>rdfs:label : Uniqueness</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Uniqueness">dqm:Uniqueness</a>
    /// </summary>
    let Uniqueness = _prefixId.prefix "Uniqueness"
    /// <summary>
    ///   <para>rdfs:comment : A uniqueness violation occurs when two or more identical values are assigned to a property that requires unique values.</para>
    ///   <para>rdfs:label : Uniqueness Violation</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#UniquenessViolation">dqm:UniquenessViolation</a>
    /// </summary>
    let UniquenessViolation = _prefixId.prefix "UniquenessViolation"
    /// <summary>
    ///   <para>rdfs:comment : Class for units of numerical values that are used to express certain property states.</para>
    ///   <para>rdfs:label : Unit</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#Unit">dqm:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:comment : An update rule is an outdated instance rule that specifies the maximum duration tolerated without any updates. Update rules require timestamps about the last update of an instance.</para>
    ///   <para>rdfs:label : Update Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#UpdateRule">dqm:UpdateRule</a>
    /// </summary>
    let UpdateRule = _prefixId.prefix "UpdateRule"
    /// <summary>
    ///   <para>rdfs:comment : A value substitution rule specifies a value to be removed and a new value that shall substitute the removed value.</para>
    ///   <para>rdfs:label : Value Substitution Rule</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ValueSubstitution">dqm:ValueSubstitution</a>
    /// </summary>
    let ValueSubstitution = _prefixId.prefix "ValueSubstitution"
    /// <summary>
    ///   <para>rdfs:label : White Space Removal Rule</para>
    ///   <para>rdfs:comment : A white space removal rule states that whitespaces at the beginning of a string and at the end of a string shall be removed for the specified property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#WhitespaceRemoval">dqm:WhitespaceRemoval</a>
    /// </summary>
    let WhitespaceRemoval = _prefixId.prefix "WhitespaceRemoval"
    /// <summary>
    ///   <para>rdfs:label : Add Property</para>
    ///   <para>rdfs:comment : A property that shall be added to an instance.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#addProperty">dqm:addProperty</a>
    /// </summary>
    let addProperty = _prefixId.prefix "addProperty"
    /// <summary>
    ///   <para>rdfs:label : Add Value</para>
    ///   <para>rdfs:comment : A value that shall be added to a property of an instance.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#addValue">dqm:addValue</a>
    /// </summary>
    let addValue = _prefixId.prefix "addValue"
    /// <summary>
    ///   <para>rdfs:label : Affected Class</para>
    ///   <para>rdfs:comment : An affected class holds one or more instances with one or more data requirement violations.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#affectedClass">dqm:affectedClass</a>
    /// </summary>
    let affectedClass = _prefixId.prefix "affectedClass"
    /// <summary>
    ///   <para>rdfs:label : Affected Instance</para>
    ///   <para>rdfs:comment : An affected instance is the data instance that contains one or more data requirement violations.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#affectedInstance">dqm:affectedInstance</a>
    /// </summary>
    let affectedInstance = _prefixId.prefix "affectedInstance"
    /// <summary>
    ///   <para>rdfs:comment : An affected property specifies the property of a data instance that contains one or more data requirement violations. Some data requirement violations, such as functional dependency violations, have more than one affected property.</para>
    ///   <para>rdfs:label : Affected Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#affectedProperty">dqm:affectedProperty</a>
    /// </summary>
    let affectedProperty = _prefixId.prefix "affectedProperty"
    /// <summary>
    ///   <para>rdfs:comment : Connects data requirements with the tasks in which the requirement applies.</para>
    ///   <para>rdfs:label : Applies For</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#appliesFor">dqm:appliesFor</a>
    /// </summary>
    let appliesFor = _prefixId.prefix "appliesFor"
    /// <summary>
    ///   <para>rdfs:comment : The assessed class is the class that holds the instances that have been analyzed to compute the assessment score.</para>
    ///   <para>rdfs:label : Assessed Class</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#assessedClass">dqm:assessedClass</a>
    /// </summary>
    let assessedClass = _prefixId.prefix "assessedClass"
    /// <summary>
    ///   <para>rdfs:comment : The assessed property represents all properties that have been tested for rule violations during the computation of the assessment score.</para>
    ///   <para>rdfs:label : Assessed Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#assessedProperty">dqm:assessedProperty</a>
    /// </summary>
    let assessedProperty = _prefixId.prefix "assessedProperty"
    /// <summary>
    ///   <para>rdfs:label : Assessment</para>
    ///   <para>rdfs:comment : The assessment property indicates whether the rule shall be used for data quality assessment.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#assessment">dqm:assessment</a>
    /// </summary>
    let assessment = _prefixId.prefix "assessment"
    /// <summary>
    ///   <para>rdfs:comment : Connects a data quality score with the data requirements that were used to calculate the score.</para>
    ///   <para>rdfs:label : Based On</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#basedOn">dqm:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>rdfs:label : Blacklist Class</para>
    ///   <para>rdfs:comment : A blacklist class holds instances with values that are disallowed for a certain data set.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistClass">dqm:blacklistClass</a>
    /// </summary>
    let blacklistClass = _prefixId.prefix "blacklistClass"
    /// <summary>
    ///   <para>rdfs:comment : A blacklist property holds the values that are disallowed for a certain data set.</para>
    ///   <para>rdfs:label : Blacklist Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistProperty">dqm:blacklistProperty</a>
    /// </summary>
    let blacklistProperty = _prefixId.prefix "blacklistProperty"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies classes that contain instances that shall be cleansed via a data cleansing rule.</para>
    ///   <para>rdfs:label : Cleanses Class</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesClass">dqm:cleansesClass</a>
    /// </summary>
    let cleansesClass = _prefixId.prefix "cleansesClass"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies a property that holds values that shall be cleansed.</para>
    ///   <para>rdfs:label : Cleanses Property 1</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesProperty1">dqm:cleansesProperty1</a>
    /// </summary>
    let cleansesProperty1 = _prefixId.prefix "cleansesProperty1"
    /// <summary>
    ///   <para>rdfs:comment : The data cleansing property specifies whether the rule shall be applied to cleanse the data in a data source.</para>
    ///   <para>rdfs:label : Cleansing</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#cleansing">dqm:cleansing</a>
    /// </summary>
    let cleansing = _prefixId.prefix "cleansing"
    /// <summary>
    ///   <para>rdfs:comment : Cleansing properties are properties of data cleansing rules.</para>
    ///   <para>rdfs:label : Cleansing Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#cleansingProperty">dqm:cleansingProperty</a>
    /// </summary>
    let cleansingProperty = _prefixId.prefix "cleansingProperty"
    /// <summary>
    ///   <para>rdfs:label : UN/CEFACT common code</para>
    ///   <para>rdfs:comment : UN/CEFACT common code of a unit of measurement.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#commonCode">dqm:commonCode</a>
    /// </summary>
    let commonCode = _prefixId.prefix "commonCode"
    /// <summary>
    ///   <para>rdfs:comment : The conditional property property indicates the URI of a property that holds values that can be used to filter the relevant subset of data for which a rule applies.</para>
    ///   <para>rdfs:label : Conditional Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#conditionalProperty">dqm:conditionalProperty</a>
    /// </summary>
    let conditionalProperty = _prefixId.prefix "conditionalProperty"
    /// <summary>
    ///   <para>rdfs:comment : The confidence property indicates how confident a rule creators is regarding the correctness of the rule.</para>
    ///   <para>rdfs:label : Confidence</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#confidence">dqm:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    /// <summary>
    ///   <para>rdfs:label : Contains</para>
    ///   <para>rdfs:comment : Holds one or more consecutive characters that are supposed to be found in strings of another property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#contains">dqm:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:comment : The current value propertiy specifies the value to be removed.</para>
    ///   <para>rdfs:label : Current Value</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#currentValue">dqm:currentValue</a>
    /// </summary>
    let currentValue = _prefixId.prefix "currentValue"
    /// <summary>
    ///   <para>rdfs:comment : Data cleansing rule relationships are object properties of the data cleansing rules.</para>
    ///   <para>rdfs:label : Data Cleansing Rule Relationship</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#dataCleansingRuleRelationship">dqm:dataCleansingRuleRelationship</a>
    /// </summary>
    let dataCleansingRuleRelationship = _prefixId.prefix "dataCleansingRuleRelationship"
    /// <summary>
    ///   <para>rdfs:label : Data Element Relationship</para>
    ///   <para>rdfs:comment : The data element relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data elements.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#dataElementRelationship">dqm:dataElementRelationship</a>
    /// </summary>
    let dataElementRelationship = _prefixId.prefix "dataElementRelationship"
    /// <summary>
    ///   <para>rdfs:label : Data Requirements Relationship</para>
    ///   <para>rdfs:comment : The data requirements relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data requirements.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#dataRequirementsRelationship">dqm:dataRequirementsRelationship</a>
    /// </summary>
    let dataRequirementsRelationship = _prefixId.prefix "dataRequirementsRelationship"
    /// <summary>
    ///   <para>rdfs:label : Ends With</para>
    ///   <para>rdfs:comment : Holds one or more consecutive characters that are supposed to be found at the end of strings of another property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#endsWith">dqm:endsWith</a>
    /// </summary>
    let endsWith = _prefixId.prefix "endsWith"
    /// <summary>
    ///   <para>rdfs:comment : Holds one or more consecutive characters that are supposed to be found in the same order in strings of another property.</para>
    ///   <para>rdfs:label : Equals</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#equals">dqm:equals</a>
    /// </summary>
    let equals = _prefixId.prefix "equals"
    /// <summary>
    ///   <para>rdfs:label : Expected Update Interval</para>
    ///   <para>rdfs:comment : The expected update interval specifies the time interval in which instances of a specific class must be updated in order to be current.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#expectedUpdateInterval">dqm:expectedUpdateInterval</a>
    /// </summary>
    let expectedUpdateInterval = _prefixId.prefix "expectedUpdateInterval"
    /// <summary>
    ///   <para>rdfs:comment : The filtering property indicates whether the rule shall be used for information filtering, i.e. only high quality data is retrieved.</para>
    ///   <para>rdfs:label : Filtering</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#filtering">dqm:filtering</a>
    /// </summary>
    let filtering = _prefixId.prefix "filtering"
    /// <summary>
    ///   <para>rdfs:label : Greater Than</para>
    ///   <para>rdfs:comment : Holds a numeric value that is used to identify values of a property that are greater than the value of this property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#greaterThan">dqm:greaterThan</a>
    /// </summary>
    let greaterThan = _prefixId.prefix "greaterThan"
    /// <summary>
    ///   <para>rdfs:label : Condition</para>
    ///   <para>rdfs:comment : Connects a conditional rule with a certain condition</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition">dqm:hasCondition</a>
    /// </summary>
    let hasCondition = _prefixId.prefix "hasCondition"
    /// <summary>
    ///   <para>rdfs:comment : Connects a conditional rule with a certain condition.</para>
    ///   <para>rdfs:label : Has Condition 1</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition1">dqm:hasCondition1</a>
    /// </summary>
    let hasCondition1 = _prefixId.prefix "hasCondition1"
    /// <summary>
    ///   <para>rdfs:label : Has Condition 2</para>
    ///   <para>rdfs:comment : Connects a conditional rule with a certain condition.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition2">dqm:hasCondition2</a>
    /// </summary>
    let hasCondition2 = _prefixId.prefix "hasCondition2"
    /// <summary>
    ///   <para>rdfs:comment : Connects a conditional rule with a certain condition.</para>
    ///   <para>rdfs:label : Has Condition 3</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition3">dqm:hasCondition3</a>
    /// </summary>
    let hasCondition3 = _prefixId.prefix "hasCondition3"
    /// <summary>
    ///   <para>rdfs:label : Has Condition 4</para>
    ///   <para>rdfs:comment : Connects a conditional rule with a certain condition.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition4">dqm:hasCondition4</a>
    /// </summary>
    let hasCondition4 = _prefixId.prefix "hasCondition4"
    /// <summary>
    ///   <para>rdfs:label : Has Condition 5</para>
    ///   <para>rdfs:comment : Connects a conditional rule with a certain condition.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition5">dqm:hasCondition5</a>
    /// </summary>
    let hasCondition5 = _prefixId.prefix "hasCondition5"
    /// <summary>
    ///   <para>rdfs:label : Has Properties</para>
    ///   <para>rdfs:comment : Reconnects mapped classes and properties with each other.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasProperties">dqm:hasProperties</a>
    /// </summary>
    let hasProperties = _prefixId.prefix "hasProperties"
    /// <summary>
    ///   <para>rdfs:label : Has Requirement</para>
    ///   <para>rdfs:comment : Specifies the data requirements that have to be fulfilled to perform the task.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasRequirement">dqm:hasRequirement</a>
    /// </summary>
    let hasRequirement = _prefixId.prefix "hasRequirement"
    /// <summary>
    ///   <para>rdfs:comment : Connects data requirements with the data quality score which was calculated based on the requirement.</para>
    ///   <para>rdfs:label : Has Score</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasScore">dqm:hasScore</a>
    /// </summary>
    let hasScore = _prefixId.prefix "hasScore"
    /// <summary>
    ///   <para>rdfs:label : Has URI</para>
    ///   <para>rdfs:comment : The hasURI property is used to map properties to instances of a class.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#hasURI">dqm:hasURI</a>
    /// </summary>
    let hasURI = _prefixId.prefix "hasURI"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the importance of a task, a data quality rule, or a data element.</para>
    ///   <para>rdfs:label : Importance</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#importance">dqm:importance</a>
    /// </summary>
    let importance = _prefixId.prefix "importance"
    /// <summary>
    ///   <para>rdfs:comment : The property lastModified indicates the date and time when the rule was last modified.</para>
    ///   <para>rdfs:label : Last Modified</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#lastModified">dqm:lastModified</a>
    /// </summary>
    let lastModified = _prefixId.prefix "lastModified"
    /// <summary>
    ///   <para>rdfs:comment : Holds a numeric value that is used to identify values of a property that are less than the value of this property.</para>
    ///   <para>rdfs:label : Less Than</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#lessThan">dqm:lessThan</a>
    /// </summary>
    let lessThan = _prefixId.prefix "lessThan"
    /// <summary>
    ///   <para>rdfs:label : Lower Limit</para>
    ///   <para>rdfs:comment : Specifies the lower limit a numeric property value shall obtain.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#lowerLimit">dqm:lowerLimit</a>
    /// </summary>
    let lowerLimit = _prefixId.prefix "lowerLimit"
    /// <summary>
    ///   <para>rdfs:comment : The new value property specifies the new value which shall substitute the current value.</para>
    ///   <para>rdfs:label : New Value</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#newValue">dqm:newValue</a>
    /// </summary>
    let newValue = _prefixId.prefix "newValue"
    /// <summary>
    ///   <para>rdfs:comment : Links an instances to the next instance in an ordinal scale.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#next">dqm:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:comment : Holds one or more consecutive characters that are used to identify values of another property that do not match with the value of this property.</para>
    ///   <para>rdfs:label : Not Equal To</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#notEqualTo">dqm:notEqualTo</a>
    /// </summary>
    let notEqualTo = _prefixId.prefix "notEqualTo"
    /// <summary>
    ///   <para>rdfs:comment : Official name of a value.</para>
    ///   <para>rdfs:label : Official Name</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#officialName">dqm:officialName</a>
    /// </summary>
    let officialName = _prefixId.prefix "officialName"
    /// <summary>
    ///   <para>rdfs:label : Operated Value</para>
    ///   <para>rdfs:comment : The operated value property is an abstract property for datatype properties that are used to express string filtering criteria.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#operatedValue">dqm:operatedValue</a>
    /// </summary>
    let operatedValue = _prefixId.prefix "operatedValue"
    /// <summary>
    ///   <para>rdfs:label : Pattern</para>
    ///   <para>rdfs:comment : The pattern property can be used to express value patterns based on a simple syntax without the need for knowing regular expressions. E.g. the pattern "AaaaaNN" where "A" stands for capital letters, "a" for small letters, and "N" for numbers.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#pattern">dqm:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:label : Plain Score</para>
    ///   <para>rdfs:comment : The plain score represents a data quality dimension score that was assessed by using a certain formula that accounts for the violations of data quality rules related to the size of the relevant data set.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#plainScore">dqm:plainScore</a>
    /// </summary>
    let plainScore = _prefixId.prefix "plainScore"
    /// <summary>
    ///   <para>rdfs:comment : Position of a value in an ordinal scale.</para>
    ///   <para>rdfs:label : Rank</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#rank">dqm:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>rdfs:comment : The reference class property points to the URI of a class that contains trusted instances, i.e. instances of high quality.</para>
    ///   <para>rdfs:label : Reference Class</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceClass">dqm:referenceClass</a>
    /// </summary>
    let referenceClass = _prefixId.prefix "referenceClass"
    /// <summary>
    ///   <para>rdfs:comment : The reference property points to the URI of a property that holds trusted values, i.e. values of high quality</para>
    ///   <para>rdfs:label : Reference Property</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty">dqm:referenceProperty</a>
    /// </summary>
    let referenceProperty = _prefixId.prefix "referenceProperty"
    /// <summary>
    ///   <para>rdfs:comment : The reference property points to the URI of a property that holds trusted values, i.e. values of high quality</para>
    ///   <para>rdfs:label : Reference Property 1</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty1">dqm:referenceProperty1</a>
    /// </summary>
    let referenceProperty1 = _prefixId.prefix "referenceProperty1"
    /// <summary>
    ///   <para>rdfs:comment : The reference property points to the URI of a property that holds trusted values, i.e. values of high quality</para>
    ///   <para>rdfs:label : Reference Property 2</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty2">dqm:referenceProperty2</a>
    /// </summary>
    let referenceProperty2 = _prefixId.prefix "referenceProperty2"
    /// <summary>
    ///   <para>rdfs:label : Reference Property 3</para>
    ///   <para>rdfs:comment : The reference property points to the URI of a property that holds trusted values, i.e. values of high quality</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty3">dqm:referenceProperty3</a>
    /// </summary>
    let referenceProperty3 = _prefixId.prefix "referenceProperty3"
    /// <summary>
    ///   <para>rdfs:comment : The reference property points to the URI of a property that holds trusted values, i.e. values of high quality</para>
    ///   <para>rdfs:label : Reference Property 4</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty4">dqm:referenceProperty4</a>
    /// </summary>
    let referenceProperty4 = _prefixId.prefix "referenceProperty4"
    /// <summary>
    ///   <para>rdfs:label : Reference Property 5</para>
    ///   <para>rdfs:comment : The reference property points to the URI of a property that holds trusted values, i.e. values of high quality</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty5">dqm:referenceProperty5</a>
    /// </summary>
    let referenceProperty5 = _prefixId.prefix "referenceProperty5"
    /// <summary>
    ///   <para>rdfs:comment : The regular expressions property can be used to express legal character ranges and data patterns for values of a certain property via regular expressions.</para>
    ///   <para>rdfs:label : Regular Expression</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#regex">dqm:regex</a>
    /// </summary>
    let regex = _prefixId.prefix "regex"
    /// <summary>
    ///   <para>rdfs:label : Requirement Description</para>
    ///   <para>rdfs:comment : Describes a data requirement in natural language.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#reqDescription">dqm:reqDescription</a>
    /// </summary>
    let reqDescription = _prefixId.prefix "reqDescription"
    /// <summary>
    ///   <para>rdfs:comment : An abstract property that holds generic datatype properties that describe a data requirement.</para>
    ///   <para>rdfs:label : Requirement Metadata</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#reqMetadata">dqm:reqMetadata</a>
    /// </summary>
    let reqMetadata = _prefixId.prefix "reqMetadata"
    /// <summary>
    ///   <para>rdfs:label : Requirement Name</para>
    ///   <para>rdfs:comment : Specifies the name of a data requirement in natural language.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#reqName">dqm:reqName</a>
    /// </summary>
    let reqName = _prefixId.prefix "reqName"
    /// <summary>
    ///   <para>rdfs:label : Requirement Source</para>
    ///   <para>rdfs:comment : Specifies the source of a data requirement.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#reqSource">dqm:reqSource</a>
    /// </summary>
    let reqSource = _prefixId.prefix "reqSource"
    /// <summary>
    ///   <para>rdfs:label : Required Property</para>
    ///   <para>rdfs:comment : Specifies whether a property must exist.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#requiredProperty">dqm:requiredProperty</a>
    /// </summary>
    let requiredProperty = _prefixId.prefix "requiredProperty"
    /// <summary>
    ///   <para>rdfs:label : Required Value</para>
    ///   <para>rdfs:comment : Specifies whether a value for a property must exist.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#requiredValue">dqm:requiredValue</a>
    /// </summary>
    let requiredValue = _prefixId.prefix "requiredValue"
    /// <summary>
    ///   <para>rdfs:comment : The rule of identification property connects the data quality problem instances with the instance of the data requirement that has detected the problem.</para>
    ///   <para>rdfs:label : Rule Of Identification</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ruleOfIdentification">dqm:ruleOfIdentification</a>
    /// </summary>
    let ruleOfIdentification = _prefixId.prefix "ruleOfIdentification"
    /// <summary>
    ///   <para>rdfs:label : Rule Violation</para>
    ///   <para>rdfs:comment : Connects data requirements with data quality problems that have been identified using the requirement.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#ruleViolation">dqm:ruleViolation</a>
    /// </summary>
    let ruleViolation = _prefixId.prefix "ruleViolation"
    /// <summary>
    ///   <para>rdfs:comment : Type of statistical scale.</para>
    ///   <para>rdfs:label : Scale Type</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#scaleType">dqm:scaleType</a>
    /// </summary>
    let scaleType = _prefixId.prefix "scaleType"
    /// <summary>
    ///   <para>rdfs:label : Scale Values</para>
    ///   <para>rdfs:comment : Links to values of a certain ordinal or nominal scale.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#scaleValues">dqm:scaleValues</a>
    /// </summary>
    let scaleValues = _prefixId.prefix "scaleValues"
    /// <summary>
    ///   <para>rdfs:label : SPARQL rule</para>
    ///   <para>rdfs:comment : This property can store custom data requirements that are expressed via SPARQL queries.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#sparqlrule">dqm:sparqlrule</a>
    /// </summary>
    let sparqlrule = _prefixId.prefix "sparqlrule"
    /// <summary>
    ///   <para>rdfs:label : Starts With</para>
    ///   <para>rdfs:comment : Holds one or more consecutive characters that are supposed to be found at the beginning of strings of another property.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#startsWith">dqm:startsWith</a>
    /// </summary>
    let startsWith = _prefixId.prefix "startsWith"
    /// <summary>
    ///   <para>rdfs:label : Sub Task Of</para>
    ///   <para>rdfs:comment : Property that can be used to represent hierachies of between tasks.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#subTaskOf">dqm:subTaskOf</a>
    /// </summary>
    let subTaskOf = _prefixId.prefix "subTaskOf"
    /// <summary>
    ///   <para>rdfs:label : Task Dependent</para>
    ///   <para>rdfs:comment : Specifies whether the data quality rule is task dependent.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#taskDependent">dqm:taskDependent</a>
    /// </summary>
    let taskDependent = _prefixId.prefix "taskDependent"
    /// <summary>
    ///   <para>rdfs:label : Task Description</para>
    ///   <para>rdfs:comment : Describes the task in natural language.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#taskDescription">dqm:taskDescription</a>
    /// </summary>
    let taskDescription = _prefixId.prefix "taskDescription"
    /// <summary>
    ///   <para>rdfs:label : Task Name</para>
    ///   <para>rdfs:comment : Specifies the name of the task.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#taskName">dqm:taskName</a>
    /// </summary>
    let taskName = _prefixId.prefix "taskName"
    /// <summary>
    ///   <para>rdfs:comment : Technical name of a value.</para>
    ///   <para>rdfs:label : Technical Name</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#technicalName">dqm:technicalName</a>
    /// </summary>
    let technicalName = _prefixId.prefix "technicalName"
    /// <summary>
    ///   <para>rdfs:label : Tested Class</para>
    ///   <para>rdfs:comment : The tested class property specifies the class that holds the instances that shall be tested for data quality problems.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedClass">dqm:testedClass</a>
    /// </summary>
    let testedClass = _prefixId.prefix "testedClass"
    /// <summary>
    ///   <para>rdfs:label : Tested Property</para>
    ///   <para>rdfs:comment : The property with the values that shall be tested for data quality problems.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty">dqm:testedProperty</a>
    /// </summary>
    let testedProperty = _prefixId.prefix "testedProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property with the values that shall be tested for data quality problems.</para>
    ///   <para>rdfs:label : Tested Property 1</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty1">dqm:testedProperty1</a>
    /// </summary>
    let testedProperty1 = _prefixId.prefix "testedProperty1"
    /// <summary>
    ///   <para>rdfs:comment : The property with the values that shall be tested for data quality problems.</para>
    ///   <para>rdfs:label : Tested Property 2</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty2">dqm:testedProperty2</a>
    /// </summary>
    let testedProperty2 = _prefixId.prefix "testedProperty2"
    /// <summary>
    ///   <para>rdfs:comment : The property with the values that shall be tested for data quality problems.</para>
    ///   <para>rdfs:label : Tested Property 3</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty3">dqm:testedProperty3</a>
    /// </summary>
    let testedProperty3 = _prefixId.prefix "testedProperty3"
    /// <summary>
    ///   <para>rdfs:label : Tested Property 4</para>
    ///   <para>rdfs:comment : The property with the values that shall be tested for data quality problems.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty4">dqm:testedProperty4</a>
    /// </summary>
    let testedProperty4 = _prefixId.prefix "testedProperty4"
    /// <summary>
    ///   <para>rdfs:comment : The property with the values that shall be tested for data quality problems.</para>
    ///   <para>rdfs:label : Tested Property 5</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty5">dqm:testedProperty5</a>
    /// </summary>
    let testedProperty5 = _prefixId.prefix "testedProperty5"
    /// <summary>
    ///   <para>rdfs:label : Time Of Assessment</para>
    ///   <para>rdfs:comment : The time of assessment represents the data and time when the data quality score was computed.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfAssessment">dqm:timeOfAssessment</a>
    /// </summary>
    let timeOfAssessment = _prefixId.prefix "timeOfAssessment"
    /// <summary>
    ///   <para>rdfs:comment : The time of identification property specifies the date and time in which the data quality problem was detected</para>
    ///   <para>rdfs:label : Time Of Identification</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfIdentification">dqm:timeOfIdentification</a>
    /// </summary>
    let timeOfIdentification = _prefixId.prefix "timeOfIdentification"
    /// <summary>
    ///   <para>rdfs:comment : Description of a unit of measurement.</para>
    ///   <para>rdfs:label : Unit Description</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#unitDescription">dqm:unitDescription</a>
    /// </summary>
    let unitDescription = _prefixId.prefix "unitDescription"
    /// <summary>
    ///   <para>rdfs:comment : Name of a unit of measurement.</para>
    ///   <para>rdfs:label : Unit Name</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#unitName">dqm:unitName</a>
    /// </summary>
    let unitName = _prefixId.prefix "unitName"
    /// <summary>
    ///   <para>rdfs:comment : The unit in which confidence is expressed.</para>
    ///   <para>rdfs:label : Unit of Confidence</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfConfidence">dqm:unitOfConfidence</a>
    /// </summary>
    let unitOfConfidence = _prefixId.prefix "unitOfConfidence"
    /// <summary>
    ///   <para>rdfs:label : Unit of Importance</para>
    ///   <para>rdfs:comment : The unit in which importance is expressed.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfImportance">dqm:unitOfImportance</a>
    /// </summary>
    let unitOfImportance = _prefixId.prefix "unitOfImportance"
    /// <summary>
    ///   <para>rdfs:label : Unit of Measurement</para>
    ///   <para>rdfs:comment : Indicates the unit of measurement, e.g. of data quality scores. It is recommended to use UN/CEFACT common codes to specify the unit of measurement, e.g. "P1" stands for percent.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfMeasurement">dqm:unitOfMeasurement</a>
    /// </summary>
    let unitOfMeasurement = _prefixId.prefix "unitOfMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Upper Limit</para>
    ///   <para>rdfs:comment : Specifies the upper limit a numeric property value shall obtain.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#upperLimit">dqm:upperLimit</a>
    /// </summary>
    let upperLimit = _prefixId.prefix "upperLimit"
    /// <summary>
    ///   <para>rdfs:label : Valid From</para>
    ///   <para>rdfs:comment : Specifies the date and time from which a rule is valid.</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#validFrom">dqm:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the date and time until a rule stays valid.</para>
    ///   <para>rdfs:label : Valid Until</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#validUntil">dqm:validUntil</a>
    /// </summary>
    let validUntil = _prefixId.prefix "validUntil"
    /// <summary>
    ///   <para>rdfs:comment : Validation indicates whether a data quality rule shall be used for validation during data entry.</para>
    ///   <para>rdfs:label : Validation</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#validation">dqm:validation</a>
    /// </summary>
    let validation = _prefixId.prefix "validation"
    /// <summary>
    ///   <para>rdfs:comment : Meaning of a value.</para>
    ///   <para>rdfs:label : Value Meaning</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#valueMeaning">dqm:valueMeaning</a>
    /// </summary>
    let valueMeaning = _prefixId.prefix "valueMeaning"
    /// <summary>
    ///   <para>rdfs:comment : A weighted score is a data quality dimension score that is computed by integration of importance values of data requirements, tasks, or data elements.</para>
    ///   <para>rdfs:label : Weighted Score</para>
    ///   <a href="http://purl.org/dqm-vocabulary/v1/dqm#weightedScore">dqm:weightedScore</a>
    /// </summary>
    let weightedScore = _prefixId.prefix "weightedScore"
