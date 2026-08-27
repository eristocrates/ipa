namespace http.purl.org.dqm_vocabulary.v1.dqm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dqm =
    let _namespace_iri = Namespace_Iri dqm |> NamespaceIRI
    /// <summary>
    ///   <para>dqm:Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Accuracy is the degree to which a data value represents the desired state regarding its syntax and semantics."</para>
    /// labels<para>"Accuracy"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Accuracy">http://purl.org/dqm-vocabulary/v1/dqm#Accuracy</seealso>
    let Accuracy = Prefixed_Name(dqm, "Accuracy") |> PrefixedName
    /// <summary>
    ///   <para>dqm:AffectedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affected class holds one or more affected instances"</para>
    /// labels<para>"Affected Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedClass">http://purl.org/dqm-vocabulary/v1/dqm#AffectedClass</seealso>
    let AffectedClass = Prefixed_Name(dqm, "AffectedClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:AffectedInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affected instance is a data instance that contains one or more data quality problems."</para>
    /// labels<para>"Affected Instance"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedInstance">http://purl.org/dqm-vocabulary/v1/dqm#AffectedInstance</seealso>
    let AffectedInstance = Prefixed_Name(dqm, "AffectedInstance") |> PrefixedName
    /// <summary>
    ///   <para>dqm:AffectedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affected property specifies the property of a data instance that contains one or more data quality problems."</para>
    /// labels<para>"Affected Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#AffectedProperty">http://purl.org/dqm-vocabulary/v1/dqm#AffectedProperty</seealso>
    let AffectedProperty = Prefixed_Name(dqm, "AffectedProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:BlacklistClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A blacklist class holds instances with values that are disallowed for a certain data set. Thus, illegal value rules refer to such classes over the blacklist class property."</para>
    /// labels<para>"Blacklist Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistClass">http://purl.org/dqm-vocabulary/v1/dqm#BlacklistClass</seealso>
    let BlacklistClass = Prefixed_Name(dqm, "BlacklistClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:BlacklistProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A blacklist property holds the values that are disallowed for a certain data set."</para>
    /// labels<para>"Blacklist Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#BlacklistProperty">http://purl.org/dqm-vocabulary/v1/dqm#BlacklistProperty</seealso>
    let BlacklistProperty = Prefixed_Name(dqm, "BlacklistProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:ClassRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class requirement is a data requirement that refers to the instances of a class as a whole."</para>
    /// labels<para>"Class Requirement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ClassRequirement">http://purl.org/dqm-vocabulary/v1/dqm#ClassRequirement</seealso>
    let ClassRequirement = Prefixed_Name(dqm, "ClassRequirement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:Completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Completeness is the extent to which data are of sufficient breadth, depth, and scope for the task at hand."</para>
    /// labels<para>"Completeness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Completeness">http://purl.org/dqm-vocabulary/v1/dqm#Completeness</seealso>
    let Completeness = Prefixed_Name(dqm, "Completeness") |> PrefixedName
    /// <summary>
    ///   <para>dqm:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A condition constrains instances of a class to a certain subset for which certain data quality rules apply."</para>
    /// labels<para>"Condition"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Condition">http://purl.org/dqm-vocabulary/v1/dqm#Condition</seealso>
    let Condition = Prefixed_Name(dqm, "Condition") |> PrefixedName

    /// <summary>
    ///   <para>dqm:ConditionalPropertyCompletenessRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Conditional property completeness rules specify that a tested property and/or its literal values must exist when the value of another property obtains a certain state. E.g. the property foo:state must exist and have a value when the property foo:country obtains the value "USA"."</para>
    /// labels<para>"Conditional Data Competeness Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalPropertyCompletenessRule">http://purl.org/dqm-vocabulary/v1/dqm#ConditionalPropertyCompletenessRule</seealso>
    let ConditionalPropertyCompletenessRule =
        Prefixed_Name(dqm, "ConditionalPropertyCompletenessRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:ConditionalRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A conditional rule is a multi property requirement that can be used to specify that values of a tested property A must always obtain a certain state under the condition that values of another property B obtain a certain state (condition)."</para>
    /// labels<para>"Conditional Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalRule">http://purl.org/dqm-vocabulary/v1/dqm#ConditionalRule</seealso>
    let ConditionalRule = Prefixed_Name(dqm, "ConditionalRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:ConditionalSyntaxRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Conditional syntax rules define that the literal values of a tested property must follow a certain syntax when the value of another property obtains a certain state. E.g. the property foo:state must have a value with two capital letters when the property foo:country obtains the value "USA"."</para>
    /// labels<para>"Conditional Syntax Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ConditionalSyntaxRule">http://purl.org/dqm-vocabulary/v1/dqm#ConditionalSyntaxRule</seealso>
    let ConditionalSyntaxRule =
        Prefixed_Name(dqm, "ConditionalSyntaxRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:CustomRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A custom requirement is a data requirement that is expressed via a SPARQL query."</para>
    /// labels<para>"Custom Requirement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#CustomRequirement">http://purl.org/dqm-vocabulary/v1/dqm#CustomRequirement</seealso>
    let CustomRequirement = Prefixed_Name(dqm, "CustomRequirement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:DataCleansingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data cleansing rule is an unambiguous rule that precisely specifies the required state of a data value."</para>
    /// labels<para>"Data Cleansing Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DataCleansingRule">http://purl.org/dqm-vocabulary/v1/dqm#DataCleansingRule</seealso>
    let DataCleansingRule = Prefixed_Name(dqm, "DataCleansingRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:DataElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data element is a class, a property, an instance, or a literal value."</para>
    /// labels<para>"Data Element"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DataElement">http://purl.org/dqm-vocabulary/v1/dqm#DataElement</seealso>
    let DataElement = Prefixed_Name(dqm, "DataElement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:DataQualityScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data quality score is an abstract class that can be used to structure data quality dimension scores that indicate the quality state of classes and/or properties."</para>
    /// labels<para>"Data Quality Assessment"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DataQualityScore">http://purl.org/dqm-vocabulary/v1/dqm#DataQualityScore</seealso>
    let DataQualityScore = Prefixed_Name(dqm, "DataQualityScore") |> PrefixedName
    /// <summary>
    ///   <para>dqm:DataRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data requirement is a prescribed directive or consensual agreement that defines the content and/or structure that constitute high quality data instances and values."</para>
    /// labels<para>"Data Requirement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirement">http://purl.org/dqm-vocabulary/v1/dqm#DataRequirement</seealso>
    let DataRequirement = Prefixed_Name(dqm, "DataRequirement") |> PrefixedName

    /// <summary>
    ///   <para>dqm:DataRequirementViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data requirement violation occurs when a data value or a data instance does not meet its requirements."</para>
    /// labels<para>"Data Requirement Violation"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DataRequirementViolation">http://purl.org/dqm-vocabulary/v1/dqm#DataRequirementViolation</seealso>
    let DataRequirementViolation =
        Prefixed_Name(dqm, "DataRequirementViolation") |> PrefixedName

    /// <summary>
    ///   <para>dqm:DuplicateInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Two or more instances are duplicates when they represent the same real world entity."</para>
    /// labels<para>"Duplicate Instance"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstance">http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstance</seealso>
    let DuplicateInstance = Prefixed_Name(dqm, "DuplicateInstance") |> PrefixedName

    /// <summary>
    ///   <para>dqm:DuplicateInstanceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A duplicate instance rule is a multi property requirement which specifies the properties that (when seen together) uniquely identify an entity. I.e. if the properties of two or more different instances represent the same state, then the instances represent the same entity. Thus, the instances are considered to be duplicates."</para>
    /// labels<para>"Duplicate Instance Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstanceRule">http://purl.org/dqm-vocabulary/v1/dqm#DuplicateInstanceRule</seealso>
    let DuplicateInstanceRule =
        Prefixed_Name(dqm, "DuplicateInstanceRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:ExpiryRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An expiry rule is an outdated instance rule that specifies the expiration date of an instance that must not exceed the current date and time. Therefore, expiry rules require date information about the validity period of an instance."</para>
    /// labels<para>"Expiry Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ExpiryRule">http://purl.org/dqm-vocabulary/v1/dqm#ExpiryRule</seealso>
    let ExpiryRule = Prefixed_Name(dqm, "ExpiryRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:FuncDepReferenceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A functional dependency reference rule is a multi property requirement that specifies legal value combinations for two or more properties that are allowed to occur within the same instance. Functional dependency reference rules refer to reference properties of classes that hold instances with all allowed value combinations."</para>
    /// labels<para>"Functional Dependency Reference Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepReferenceRule">http://purl.org/dqm-vocabulary/v1/dqm#FuncDepReferenceRule</seealso>
    let FuncDepReferenceRule =
        Prefixed_Name(dqm, "FuncDepReferenceRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:FuncDepValueRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A functionally dependent value rule defines that the value of a tested property must have a certain value when the values of other properties obtain certain states (conditions). E.g. the property foo:inStock must have value "true" when the property foo:availableAmount is greater than zero."</para>
    /// labels<para>"Functionally Dependent Value Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#FuncDepValueRule">http://purl.org/dqm-vocabulary/v1/dqm#FuncDepValueRule</seealso>
    let FuncDepValueRule = Prefixed_Name(dqm, "FuncDepValueRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:FunctionalDependencyViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A functional dependency violation is a combination of different property values within the same instance that must not occur together. E.g. an instance describing the man “Peter Miller” has the value “Mr.” as salutation property, but the value “female” as sex."</para>
    /// labels<para>"Functional Dependency Violation"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#FunctionalDependencyViolation">http://purl.org/dqm-vocabulary/v1/dqm#FunctionalDependencyViolation</seealso>
    let FunctionalDependencyViolation =
        Prefixed_Name(dqm, "FunctionalDependencyViolation") |> PrefixedName

    /// <summary>
    ///   <para>dqm:IllegalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An illegal value is a data value that must not be used for a property."</para>
    /// labels<para>"Illegal Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValue">http://purl.org/dqm-vocabulary/v1/dqm#IllegalValue</seealso>
    let IllegalValue = Prefixed_Name(dqm, "IllegalValue") |> PrefixedName

    /// <summary>
    ///   <para>dqm:IllegalValueRangeRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An illegal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property must not obtain."</para>
    /// labels<para>"Illegal Value Range Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRangeRule">http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRangeRule</seealso>
    let IllegalValueRangeRule =
        Prefixed_Name(dqm, "IllegalValueRangeRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:IllegalValueRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An illegal value rule is a property requirement that specifies the values that a certain property must not obtain. Illegal value rules, therefore, refer to reference properties that hold all disallowed values."</para>
    /// labels<para>"Illegal Value Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRule">http://purl.org/dqm-vocabulary/v1/dqm#IllegalValueRule</seealso>
    let IllegalValueRule = Prefixed_Name(dqm, "IllegalValueRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:LegalValueRangeRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legal value range rule is a property requirement that specifies the upper and/or lower boundary of numeric values that a certain property is allowed to obtain."</para>
    /// labels<para>"Legal Value Range Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRangeRule">http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRangeRule</seealso>
    let LegalValueRangeRule = Prefixed_Name(dqm, "LegalValueRangeRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:LegalValueRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legal value rule is a property requirement that specifies all values that a certain property is allowed to obtain. Legal value rules, therefore, refer to reference properties of classes that hold instances with all allowed values."</para>
    /// labels<para>"Legal Value Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRule">http://purl.org/dqm-vocabulary/v1/dqm#LegalValueRule</seealso>
    let LegalValueRule = Prefixed_Name(dqm, "LegalValueRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:LiteralCleansingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Literal cleansing rules can be used to cleanse the literal values of a certain property."</para>
    /// labels<para>"Literal Cleansing Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#LiteralCleansingRule">http://purl.org/dqm-vocabulary/v1/dqm#LiteralCleansingRule</seealso>
    let LiteralCleansingRule =
        Prefixed_Name(dqm, "LiteralCleansingRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:MatchingValueRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Matching value rules are multi property requirements in which the property values of other instances are used to identify data requirements violations in an instance."</para>
    /// labels<para>"Matching Value Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MatchingValueRule">http://purl.org/dqm-vocabulary/v1/dqm#MatchingValueRule</seealso>
    let MatchingValueRule = Prefixed_Name(dqm, "MatchingValueRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:MissingElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A missing element is a data requirement violation that occurs when schema elements, instances, or data values are missing, but required."</para>
    /// labels<para>"Missing Element"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MissingElement">http://purl.org/dqm-vocabulary/v1/dqm#MissingElement</seealso>
    let MissingElement = Prefixed_Name(dqm, "MissingElement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:MissingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property is missing when an instances does not contain a specific property that is required."</para>
    /// labels<para>"Missing Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MissingProperty">http://purl.org/dqm-vocabulary/v1/dqm#MissingProperty</seealso>
    let MissingProperty = Prefixed_Name(dqm, "MissingProperty") |> PrefixedName

    /// <summary>
    ///   <para>dqm:MissingPropertyAndValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class for instances that miss both a property and its value."</para>
    /// labels<para>"Missing Property and Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MissingPropertyAndValue">http://purl.org/dqm-vocabulary/v1/dqm#MissingPropertyAndValue</seealso>
    let MissingPropertyAndValue =
        Prefixed_Name(dqm, "MissingPropertyAndValue") |> PrefixedName

    /// <summary>
    ///   <para>dqm:MissingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A missing value occurs when a property of an instance does not hold a value."</para>
    /// labels<para>"Missing Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MissingValue">http://purl.org/dqm-vocabulary/v1/dqm#MissingValue</seealso>
    let MissingValue = Prefixed_Name(dqm, "MissingValue") |> PrefixedName

    /// <summary>
    ///   <para>dqm:MultiPropertyCleansingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Multi property cleansing rules can be used to cleanse the literal values of two or more dependent properties."</para>
    /// labels<para>"Multi Property Cleansing Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyCleansingRule">http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyCleansingRule</seealso>
    let MultiPropertyCleansingRule =
        Prefixed_Name(dqm, "MultiPropertyCleansingRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:MultiPropertyRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Multi property requirements are data requirements that consider values from two or more properties."</para>
    /// labels<para>"Multi Property Requirement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyRequirement">http://purl.org/dqm-vocabulary/v1/dqm#MultiPropertyRequirement</seealso>
    let MultiPropertyRequirement =
        Prefixed_Name(dqm, "MultiPropertyRequirement") |> PrefixedName

    /// <summary>
    ///   <para>dqm:OutOfRangeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value is out of range when it is not part of the legal value range or when it is part of the illegal value range."</para>
    /// labels<para>"Out of Range Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#OutOfRangeValue">http://purl.org/dqm-vocabulary/v1/dqm#OutOfRangeValue</seealso>
    let OutOfRangeValue = Prefixed_Name(dqm, "OutOfRangeValue") |> PrefixedName
    /// <summary>
    ///   <para>dqm:OutdatedInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance is outdated when it represents an outdated state of its corresponding real-world entity."</para>
    /// labels<para>"Outdated Instance"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstance">http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstance</seealso>
    let OutdatedInstance = Prefixed_Name(dqm, "OutdatedInstance") |> PrefixedName

    /// <summary>
    ///   <para>dqm:OutdatedInstanceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An outdated instance rule is a data requirement that specifies the point in time when an instance is not current anymore."</para>
    /// labels<para>"Outdated Instance Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstanceRule">http://purl.org/dqm-vocabulary/v1/dqm#OutdatedInstanceRule</seealso>
    let OutdatedInstanceRule =
        Prefixed_Name(dqm, "OutdatedInstanceRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:PopulationCompleteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Population completeness is the degree to which all objects of a certain reference are represented in a specific class."</para>
    /// labels<para>"Population Completeness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationCompleteness">http://purl.org/dqm-vocabulary/v1/dqm#PopulationCompleteness</seealso>
    let PopulationCompleteness =
        Prefixed_Name(dqm, "PopulationCompleteness") |> PrefixedName

    /// <summary>
    ///   <para>dqm:PopulationUniqueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entity uniqueness is the degree to which entities (that must be uniquely represented within a certain class) are unique."</para>
    /// labels<para>"Population Uniqueness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PopulationUniqueness">http://purl.org/dqm-vocabulary/v1/dqm#PopulationUniqueness</seealso>
    let PopulationUniqueness =
        Prefixed_Name(dqm, "PopulationUniqueness") |> PrefixedName

    /// <summary>
    ///   <para>dqm:PropertyCompleteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property completeness is the degree to which values for a specific property are missing in entities of a specific class."</para>
    /// labels<para>"Property Completeness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompleteness">http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompleteness</seealso>
    let PropertyCompleteness =
        Prefixed_Name(dqm, "PropertyCompleteness") |> PrefixedName

    /// <summary>
    ///   <para>dqm:PropertyCompletenessRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property completeness rule is a data requirement that specifies that a certain property and/or its value must exist in all instances of a certain class."</para>
    /// labels<para>"Property Completeness Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletenessRule">http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletenessRule</seealso>
    let PropertyCompletenessRule =
        Prefixed_Name(dqm, "PropertyCompletenessRule") |> PrefixedName

    /// <summary>
    ///   <para>dqm:PropertyCompletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property completion rule specifies a property and value that shall be added to certain instances."</para>
    /// labels<para>"Property Completion Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletion">http://purl.org/dqm-vocabulary/v1/dqm#PropertyCompletion</seealso>
    let PropertyCompletion = Prefixed_Name(dqm, "PropertyCompletion") |> PrefixedName
    /// <summary>
    ///   <para>dqm:PropertyRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property requirements are data requirements that are related to values of a single property."</para>
    /// labels<para>"Property Requirement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyRequirement">http://purl.org/dqm-vocabulary/v1/dqm#PropertyRequirement</seealso>
    let PropertyRequirement = Prefixed_Name(dqm, "PropertyRequirement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:PropertyUniqueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property uniqueness is the degree to which the values of a property (that must only contain unique values within instances of a certain class) are unique."</para>
    /// labels<para>"Property Uniqueness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#PropertyUniqueness">http://purl.org/dqm-vocabulary/v1/dqm#PropertyUniqueness</seealso>
    let PropertyUniqueness = Prefixed_Name(dqm, "PropertyUniqueness") |> PrefixedName
    /// <summary>
    ///   <para>dqm:ScaleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scale value is a value of a nominal or ordinal scale."</para>
    /// labels<para>"Scale Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ScaleValue">http://purl.org/dqm-vocabulary/v1/dqm#ScaleValue</seealso>
    let ScaleValue = Prefixed_Name(dqm, "ScaleValue") |> PrefixedName
    /// <summary>
    ///   <para>dqm:SemanticAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Semantic accuracy is the degree to which the data values of an instance represent the correct state of an entity’s property."</para>
    /// labels<para>"Semantic Accuracy"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#SemanticAccuracy">http://purl.org/dqm-vocabulary/v1/dqm#SemanticAccuracy</seealso>
    let SemanticAccuracy = Prefixed_Name(dqm, "SemanticAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dqm:StrictValueCombination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A strict value combination is a combination of two values of different properties that may only be assigned to each other, but not to other values."</para>
    /// labels<para>"Strict Value Combination Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#StrictValueCombination">http://purl.org/dqm-vocabulary/v1/dqm#StrictValueCombination</seealso>
    let StrictValueCombination =
        Prefixed_Name(dqm, "StrictValueCombination") |> PrefixedName

    /// <summary>
    ///   <para>dqm:SyntacticAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Syntactic accuracy is the degree to which data values of a property represent legal values and are free from syntax violations."</para>
    /// labels<para>"Syntactic Accuracy"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#SyntacticAccuracy">http://purl.org/dqm-vocabulary/v1/dqm#SyntacticAccuracy</seealso>
    let SyntacticAccuracy = Prefixed_Name(dqm, "SyntacticAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>dqm:SyntaxRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A syntax rule is a property requirement that specifies the allowed characters and/or character pattern to be used in values for a certain property in instances of a certain class."</para>
    /// labels<para>"Syntax Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxRule">http://purl.org/dqm-vocabulary/v1/dqm#SyntaxRule</seealso>
    let SyntaxRule = Prefixed_Name(dqm, "SyntaxRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:SyntaxViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A syntax violation is a data requirement violation that occurs when a data value contains disallowed characters or does not match a predefined pattern."</para>
    /// labels<para>"Syntax Violation"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#SyntaxViolation">http://purl.org/dqm-vocabulary/v1/dqm#SyntaxViolation</seealso>
    let SyntaxViolation = Prefixed_Name(dqm, "SyntaxViolation") |> PrefixedName
    /// <summary>
    ///   <para>dqm:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Classifies the tasks for which the data quality rule shall apply for."</para>
    /// labels<para>"Task"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Task">http://purl.org/dqm-vocabulary/v1/dqm#Task</seealso>
    let Task = Prefixed_Name(dqm, "Task") |> PrefixedName
    /// <summary>
    ///   <para>dqm:TestedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tested class is a class that holds the instances that shall be analyzed for data quality problems."</para>
    /// labels<para>"Tested Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#TestedClass">http://purl.org/dqm-vocabulary/v1/dqm#TestedClass</seealso>
    let TestedClass = Prefixed_Name(dqm, "TestedClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:TestedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tested property holds the values to be analyzed for data quality problems."</para>
    /// labels<para>"Tested Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#TestedProperty">http://purl.org/dqm-vocabulary/v1/dqm#TestedProperty</seealso>
    let TestedProperty = Prefixed_Name(dqm, "TestedProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:Timeliness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Timeliness is the degree to which instances of a specific class (1) are updated within an expected time or (2) have not exceeded their expiration date."</para>
    /// labels<para>"Timeliness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Timeliness">http://purl.org/dqm-vocabulary/v1/dqm#Timeliness</seealso>
    let Timeliness = Prefixed_Name(dqm, "Timeliness") |> PrefixedName
    /// <summary>
    ///   <para>dqm:TrustedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Legal value rules and functional dependency reference rules require the specification of a trusted class as a reference that holds instances with legal values / legal value combinations."</para>
    /// labels<para>"Trusted Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedClass">http://purl.org/dqm-vocabulary/v1/dqm#TrustedClass</seealso>
    let TrustedClass = Prefixed_Name(dqm, "TrustedClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:TrustedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A trusted property holds the values that serve as a trusted reference in legal value rules / functional dependency reference rules, e.g. to define legal values for a tested property."</para>
    /// labels<para>"Trusted Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#TrustedProperty">http://purl.org/dqm-vocabulary/v1/dqm#TrustedProperty</seealso>
    let TrustedProperty = Prefixed_Name(dqm, "TrustedProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:UniqueValueRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unique value rule is a property requirement that specifies that each value of a certain property must be unique in instances of a certain class."</para>
    /// labels<para>"Unique Value Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#UniqueValueRule">http://purl.org/dqm-vocabulary/v1/dqm#UniqueValueRule</seealso>
    let UniqueValueRule = Prefixed_Name(dqm, "UniqueValueRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:Uniqueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uniqueness is the degree to which properties and classes are free of duplicate values and instances."</para>
    /// labels<para>"Uniqueness"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Uniqueness">http://purl.org/dqm-vocabulary/v1/dqm#Uniqueness</seealso>
    let Uniqueness = Prefixed_Name(dqm, "Uniqueness") |> PrefixedName
    /// <summary>
    ///   <para>dqm:UniquenessViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A uniqueness violation occurs when two or more identical values are assigned to a property that requires unique values."</para>
    /// labels<para>"Uniqueness Violation"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#UniquenessViolation">http://purl.org/dqm-vocabulary/v1/dqm#UniquenessViolation</seealso>
    let UniquenessViolation = Prefixed_Name(dqm, "UniquenessViolation") |> PrefixedName
    /// <summary>
    ///   <para>dqm:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class for units of numerical values that are used to express certain property states."</para>
    /// labels<para>"Unit"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#Unit">http://purl.org/dqm-vocabulary/v1/dqm#Unit</seealso>
    let Unit = Prefixed_Name(dqm, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>dqm:UpdateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An update rule is an outdated instance rule that specifies the maximum duration tolerated without any updates. Update rules require timestamps about the last update of an instance."</para>
    /// labels<para>"Update Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#UpdateRule">http://purl.org/dqm-vocabulary/v1/dqm#UpdateRule</seealso>
    let UpdateRule = Prefixed_Name(dqm, "UpdateRule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:ValueSubstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value substitution rule specifies a value to be removed and a new value that shall substitute the removed value."</para>
    /// labels<para>"Value Substitution Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ValueSubstitution">http://purl.org/dqm-vocabulary/v1/dqm#ValueSubstitution</seealso>
    let ValueSubstitution = Prefixed_Name(dqm, "ValueSubstitution") |> PrefixedName
    /// <summary>
    ///   <para>dqm:WhitespaceRemoval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A white space removal rule states that whitespaces at the beginning of a string and at the end of a string shall be removed for the specified property."</para>
    /// labels<para>"White Space Removal Rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#WhitespaceRemoval">http://purl.org/dqm-vocabulary/v1/dqm#WhitespaceRemoval</seealso>
    let WhitespaceRemoval = Prefixed_Name(dqm, "WhitespaceRemoval") |> PrefixedName
    /// <summary>
    ///   <para>dqm:addProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A property that shall be added to an instance."</para>
    /// labels<para>"Add Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#addProperty">http://purl.org/dqm-vocabulary/v1/dqm#addProperty</seealso>
    let addProperty = Prefixed_Name(dqm, "addProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:addValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A value that shall be added to a property of an instance."</para>
    /// labels<para>"Add Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#addValue">http://purl.org/dqm-vocabulary/v1/dqm#addValue</seealso>
    let addValue = Prefixed_Name(dqm, "addValue") |> PrefixedName
    /// <summary>
    ///   <para>dqm:affectedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An affected class holds one or more instances with one or more data requirement violations."</para>
    /// labels<para>"Affected Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#affectedClass">http://purl.org/dqm-vocabulary/v1/dqm#affectedClass</seealso>
    let affectedClass = Prefixed_Name(dqm, "affectedClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:affectedInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An affected instance is the data instance that contains one or more data requirement violations."</para>
    /// labels<para>"Affected Instance"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#affectedInstance">http://purl.org/dqm-vocabulary/v1/dqm#affectedInstance</seealso>
    let affectedInstance = Prefixed_Name(dqm, "affectedInstance") |> PrefixedName
    /// <summary>
    ///   <para>dqm:affectedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An affected property specifies the property of a data instance that contains one or more data requirement violations. Some data requirement violations, such as functional dependency violations, have more than one affected property."</para>
    /// labels<para>"Affected Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#affectedProperty">http://purl.org/dqm-vocabulary/v1/dqm#affectedProperty</seealso>
    let affectedProperty = Prefixed_Name(dqm, "affectedProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:appliesFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects data requirements with the tasks in which the requirement applies."</para>
    /// labels<para>"Applies For"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#appliesFor">http://purl.org/dqm-vocabulary/v1/dqm#appliesFor</seealso>
    let appliesFor = Prefixed_Name(dqm, "appliesFor") |> PrefixedName
    /// <summary>
    ///   <para>dqm:assessedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The assessed class is the class that holds the instances that have been analyzed to compute the assessment score."</para>
    /// labels<para>"Assessed Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#assessedClass">http://purl.org/dqm-vocabulary/v1/dqm#assessedClass</seealso>
    let assessedClass = Prefixed_Name(dqm, "assessedClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:assessedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The assessed property represents all properties that have been tested for rule violations during the computation of the assessment score."</para>
    /// labels<para>"Assessed Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#assessedProperty">http://purl.org/dqm-vocabulary/v1/dqm#assessedProperty</seealso>
    let assessedProperty = Prefixed_Name(dqm, "assessedProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The assessment property indicates whether the rule shall be used for data quality assessment."</para>
    /// labels<para>"Assessment"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#assessment">http://purl.org/dqm-vocabulary/v1/dqm#assessment</seealso>
    let assessment = Prefixed_Name(dqm, "assessment") |> PrefixedName
    /// <summary>
    ///   <para>dqm:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a data quality score with the data requirements that were used to calculate the score."</para>
    /// labels<para>"Based On"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#basedOn">http://purl.org/dqm-vocabulary/v1/dqm#basedOn</seealso>
    let basedOn = Prefixed_Name(dqm, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>dqm:blacklistClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A blacklist class holds instances with values that are disallowed for a certain data set."</para>
    /// labels<para>"Blacklist Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistClass">http://purl.org/dqm-vocabulary/v1/dqm#blacklistClass</seealso>
    let blacklistClass = Prefixed_Name(dqm, "blacklistClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:blacklistProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A blacklist property holds the values that are disallowed for a certain data set."</para>
    /// labels<para>"Blacklist Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#blacklistProperty">http://purl.org/dqm-vocabulary/v1/dqm#blacklistProperty</seealso>
    let blacklistProperty = Prefixed_Name(dqm, "blacklistProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:cleansesClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property identifies classes that contain instances that shall be cleansed via a data cleansing rule."</para>
    /// labels<para>"Cleanses Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesClass">http://purl.org/dqm-vocabulary/v1/dqm#cleansesClass</seealso>
    let cleansesClass = Prefixed_Name(dqm, "cleansesClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:cleansesProperty1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property identifies a property that holds values that shall be cleansed."</para>
    /// labels<para>"Cleanses Property 1"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#cleansesProperty1">http://purl.org/dqm-vocabulary/v1/dqm#cleansesProperty1</seealso>
    let cleansesProperty1 = Prefixed_Name(dqm, "cleansesProperty1") |> PrefixedName
    /// <summary>
    ///   <para>dqm:cleansing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The data cleansing property specifies whether the rule shall be applied to cleanse the data in a data source."</para>
    /// labels<para>"Cleansing"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#cleansing">http://purl.org/dqm-vocabulary/v1/dqm#cleansing</seealso>
    let cleansing = Prefixed_Name(dqm, "cleansing") |> PrefixedName
    /// <summary>
    ///   <para>dqm:cleansingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Cleansing properties are properties of data cleansing rules."</para>
    /// labels<para>"Cleansing Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#cleansingProperty">http://purl.org/dqm-vocabulary/v1/dqm#cleansingProperty</seealso>
    let cleansingProperty = Prefixed_Name(dqm, "cleansingProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:commonCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"UN/CEFACT common code of a unit of measurement."</para>
    /// labels<para>"UN/CEFACT common code"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#commonCode">http://purl.org/dqm-vocabulary/v1/dqm#commonCode</seealso>
    let commonCode = Prefixed_Name(dqm, "commonCode") |> PrefixedName
    /// <summary>
    ///   <para>dqm:conditionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The conditional property property indicates the URI of a property that holds values that can be used to filter the relevant subset of data for which a rule applies."</para>
    /// labels<para>"Conditional Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#conditionalProperty">http://purl.org/dqm-vocabulary/v1/dqm#conditionalProperty</seealso>
    let conditionalProperty = Prefixed_Name(dqm, "conditionalProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The confidence property indicates how confident a rule creators is regarding the correctness of the rule."</para>
    /// labels<para>"Confidence"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#confidence">http://purl.org/dqm-vocabulary/v1/dqm#confidence</seealso>
    let confidence = Prefixed_Name(dqm, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>dqm:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Holds one or more consecutive characters that are supposed to be found in strings of another property."</para>
    /// labels<para>"Contains"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#contains">http://purl.org/dqm-vocabulary/v1/dqm#contains</seealso>
    let contains = Prefixed_Name(dqm, "contains") |> PrefixedName
    /// <summary>
    ///   <para>dqm:currentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The current value propertiy specifies the value to be removed."</para>
    /// labels<para>"Current Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#currentValue">http://purl.org/dqm-vocabulary/v1/dqm#currentValue</seealso>
    let currentValue = Prefixed_Name(dqm, "currentValue") |> PrefixedName

    /// <summary>
    ///   <para>dqm:dataCleansingRuleRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Data cleansing rule relationships are object properties of the data cleansing rules."</para>
    /// labels<para>"Data Cleansing Rule Relationship"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#dataCleansingRuleRelationship">http://purl.org/dqm-vocabulary/v1/dqm#dataCleansingRuleRelationship</seealso>
    let dataCleansingRuleRelationship =
        Prefixed_Name(dqm, "dataCleansingRuleRelationship") |> PrefixedName

    /// <summary>
    ///   <para>dqm:dataElementRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The data element relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data elements."</para>
    /// labels<para>"Data Element Relationship"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#dataElementRelationship">http://purl.org/dqm-vocabulary/v1/dqm#dataElementRelationship</seealso>
    let dataElementRelationship =
        Prefixed_Name(dqm, "dataElementRelationship") |> PrefixedName

    /// <summary>
    ///   <para>dqm:dataRequirementsRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The data requirements relationship property is an abstract property that holds object properties that are used to define internal and external relationships of data requirements."</para>
    /// labels<para>"Data Requirements Relationship"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#dataRequirementsRelationship">http://purl.org/dqm-vocabulary/v1/dqm#dataRequirementsRelationship</seealso>
    let dataRequirementsRelationship =
        Prefixed_Name(dqm, "dataRequirementsRelationship") |> PrefixedName

    /// <summary>
    ///   <para>dqm:endsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Holds one or more consecutive characters that are supposed to be found at the end of strings of another property."</para>
    /// labels<para>"Ends With"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#endsWith">http://purl.org/dqm-vocabulary/v1/dqm#endsWith</seealso>
    let endsWith = Prefixed_Name(dqm, "endsWith") |> PrefixedName
    /// <summary>
    ///   <para>dqm:equals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Holds one or more consecutive characters that are supposed to be found in the same order in strings of another property."</para>
    /// labels<para>"Equals"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#equals">http://purl.org/dqm-vocabulary/v1/dqm#equals</seealso>
    let equals = Prefixed_Name(dqm, "equals") |> PrefixedName

    /// <summary>
    ///   <para>dqm:expectedUpdateInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The expected update interval specifies the time interval in which instances of a specific class must be updated in order to be current."</para>
    /// labels<para>"Expected Update Interval"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#expectedUpdateInterval">http://purl.org/dqm-vocabulary/v1/dqm#expectedUpdateInterval</seealso>
    let expectedUpdateInterval =
        Prefixed_Name(dqm, "expectedUpdateInterval") |> PrefixedName

    /// <summary>
    ///   <para>dqm:filtering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The filtering property indicates whether the rule shall be used for information filtering, i.e. only high quality data is retrieved."</para>
    /// labels<para>"Filtering"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#filtering">http://purl.org/dqm-vocabulary/v1/dqm#filtering</seealso>
    let filtering = Prefixed_Name(dqm, "filtering") |> PrefixedName
    /// <summary>
    ///   <para>dqm:greaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Holds a numeric value that is used to identify values of a property that are greater than the value of this property."</para>
    /// labels<para>"Greater Than"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#greaterThan">http://purl.org/dqm-vocabulary/v1/dqm#greaterThan</seealso>
    let greaterThan = Prefixed_Name(dqm, "greaterThan") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a conditional rule with a certain condition"</para>
    /// labels<para>"Condition"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition">http://purl.org/dqm-vocabulary/v1/dqm#hasCondition</seealso>
    let hasCondition = Prefixed_Name(dqm, "hasCondition") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasCondition1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Connects a conditional rule with a certain condition."</para>
    /// labels<para>"Has Condition 1"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition1">http://purl.org/dqm-vocabulary/v1/dqm#hasCondition1</seealso>
    let hasCondition1 = Prefixed_Name(dqm, "hasCondition1") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasCondition2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a conditional rule with a certain condition."</para>
    /// labels<para>"Has Condition 2"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition2">http://purl.org/dqm-vocabulary/v1/dqm#hasCondition2</seealso>
    let hasCondition2 = Prefixed_Name(dqm, "hasCondition2") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasCondition3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a conditional rule with a certain condition."</para>
    /// labels<para>"Has Condition 3"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition3">http://purl.org/dqm-vocabulary/v1/dqm#hasCondition3</seealso>
    let hasCondition3 = Prefixed_Name(dqm, "hasCondition3") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasCondition4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Connects a conditional rule with a certain condition."</para>
    /// labels<para>"Has Condition 4"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition4">http://purl.org/dqm-vocabulary/v1/dqm#hasCondition4</seealso>
    let hasCondition4 = Prefixed_Name(dqm, "hasCondition4") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasCondition5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Connects a conditional rule with a certain condition."</para>
    /// labels<para>"Has Condition 5"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasCondition5">http://purl.org/dqm-vocabulary/v1/dqm#hasCondition5</seealso>
    let hasCondition5 = Prefixed_Name(dqm, "hasCondition5") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Reconnects mapped classes and properties with each other."</para>
    /// labels<para>"Has Properties"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasProperties">http://purl.org/dqm-vocabulary/v1/dqm#hasProperties</seealso>
    let hasProperties = Prefixed_Name(dqm, "hasProperties") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the data requirements that have to be fulfilled to perform the task."</para>
    /// labels<para>"Has Requirement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasRequirement">http://purl.org/dqm-vocabulary/v1/dqm#hasRequirement</seealso>
    let hasRequirement = Prefixed_Name(dqm, "hasRequirement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects data requirements with the data quality score which was calculated based on the requirement."</para>
    /// labels<para>"Has Score"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasScore">http://purl.org/dqm-vocabulary/v1/dqm#hasScore</seealso>
    let hasScore = Prefixed_Name(dqm, "hasScore") |> PrefixedName
    /// <summary>
    ///   <para>dqm:hasURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The hasURI property is used to map properties to instances of a class."</para>
    /// labels<para>"Has URI"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#hasURI">http://purl.org/dqm-vocabulary/v1/dqm#hasURI</seealso>
    let hasURI = Prefixed_Name(dqm, "hasURI") |> PrefixedName
    /// <summary>
    ///   <para>dqm:importance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies the importance of a task, a data quality rule, or a data element."</para>
    /// labels<para>"Importance"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#importance">http://purl.org/dqm-vocabulary/v1/dqm#importance</seealso>
    let importance = Prefixed_Name(dqm, "importance") |> PrefixedName
    /// <summary>
    ///   <para>dqm:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The property lastModified indicates the date and time when the rule was last modified."</para>
    /// labels<para>"Last Modified"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#lastModified">http://purl.org/dqm-vocabulary/v1/dqm#lastModified</seealso>
    let lastModified = Prefixed_Name(dqm, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>dqm:lessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Holds a numeric value that is used to identify values of a property that are less than the value of this property."</para>
    /// labels<para>"Less Than"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#lessThan">http://purl.org/dqm-vocabulary/v1/dqm#lessThan</seealso>
    let lessThan = Prefixed_Name(dqm, "lessThan") |> PrefixedName
    /// <summary>
    ///   <para>dqm:lowerLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies the lower limit a numeric property value shall obtain."</para>
    /// labels<para>"Lower Limit"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#lowerLimit">http://purl.org/dqm-vocabulary/v1/dqm#lowerLimit</seealso>
    let lowerLimit = Prefixed_Name(dqm, "lowerLimit") |> PrefixedName
    /// <summary>
    ///   <para>dqm:newValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The new value property specifies the new value which shall substitute the current value."</para>
    /// labels<para>"New Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#newValue">http://purl.org/dqm-vocabulary/v1/dqm#newValue</seealso>
    let newValue = Prefixed_Name(dqm, "newValue") |> PrefixedName
    /// <summary>
    ///   <para>dqm:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an instances to the next instance in an ordinal scale."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#next">http://purl.org/dqm-vocabulary/v1/dqm#next</seealso>
    let next = Prefixed_Name(dqm, "next") |> PrefixedName
    /// <summary>
    ///   <para>dqm:notEqualTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Holds one or more consecutive characters that are used to identify values of another property that do not match with the value of this property."</para>
    /// labels<para>"Not Equal To"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#notEqualTo">http://purl.org/dqm-vocabulary/v1/dqm#notEqualTo</seealso>
    let notEqualTo = Prefixed_Name(dqm, "notEqualTo") |> PrefixedName
    /// <summary>
    ///   <para>dqm:officialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Official name of a value."</para>
    /// labels<para>"Official Name"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#officialName">http://purl.org/dqm-vocabulary/v1/dqm#officialName</seealso>
    let officialName = Prefixed_Name(dqm, "officialName") |> PrefixedName
    /// <summary>
    ///   <para>dqm:operatedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The operated value property is an abstract property for datatype properties that are used to express string filtering criteria."</para>
    /// labels<para>"Operated Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#operatedValue">http://purl.org/dqm-vocabulary/v1/dqm#operatedValue</seealso>
    let operatedValue = Prefixed_Name(dqm, "operatedValue") |> PrefixedName
    /// <summary>
    ///   <para>dqm:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The pattern property can be used to express value patterns based on a simple syntax without the need for knowing regular expressions. E.g. the pattern "AaaaaNN" where "A" stands for capital letters, "a" for small letters, and "N" for numbers."</para>
    /// labels<para>"Pattern"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#pattern">http://purl.org/dqm-vocabulary/v1/dqm#pattern</seealso>
    let pattern = Prefixed_Name(dqm, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>dqm:plainScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The plain score represents a data quality dimension score that was assessed by using a certain formula that accounts for the violations of data quality rules related to the size of the relevant data set."</para>
    /// labels<para>"Plain Score"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#plainScore">http://purl.org/dqm-vocabulary/v1/dqm#plainScore</seealso>
    let plainScore = Prefixed_Name(dqm, "plainScore") |> PrefixedName
    /// <summary>
    ///   <para>dqm:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Position of a value in an ordinal scale."</para>
    /// labels<para>"Rank"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#rank">http://purl.org/dqm-vocabulary/v1/dqm#rank</seealso>
    let rank = Prefixed_Name(dqm, "rank") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference class property points to the URI of a class that contains trusted instances, i.e. instances of high quality."</para>
    /// labels<para>"Reference Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceClass">http://purl.org/dqm-vocabulary/v1/dqm#referenceClass</seealso>
    let referenceClass = Prefixed_Name(dqm, "referenceClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference property points to the URI of a property that holds trusted values, i.e. values of high quality"</para>
    /// labels<para>"Reference Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty">http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty</seealso>
    let referenceProperty = Prefixed_Name(dqm, "referenceProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceProperty1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The reference property points to the URI of a property that holds trusted values, i.e. values of high quality"</para>
    /// labels<para>"Reference Property 1"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty1">http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty1</seealso>
    let referenceProperty1 = Prefixed_Name(dqm, "referenceProperty1") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceProperty2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The reference property points to the URI of a property that holds trusted values, i.e. values of high quality"</para>
    /// labels<para>"Reference Property 2"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty2">http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty2</seealso>
    let referenceProperty2 = Prefixed_Name(dqm, "referenceProperty2") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceProperty3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The reference property points to the URI of a property that holds trusted values, i.e. values of high quality"</para>
    /// labels<para>"Reference Property 3"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty3">http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty3</seealso>
    let referenceProperty3 = Prefixed_Name(dqm, "referenceProperty3") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceProperty4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference property points to the URI of a property that holds trusted values, i.e. values of high quality"</para>
    /// labels<para>"Reference Property 4"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty4">http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty4</seealso>
    let referenceProperty4 = Prefixed_Name(dqm, "referenceProperty4") |> PrefixedName
    /// <summary>
    ///   <para>dqm:referenceProperty5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference property points to the URI of a property that holds trusted values, i.e. values of high quality"</para>
    /// labels<para>"Reference Property 5"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty5">http://purl.org/dqm-vocabulary/v1/dqm#referenceProperty5</seealso>
    let referenceProperty5 = Prefixed_Name(dqm, "referenceProperty5") |> PrefixedName
    /// <summary>
    ///   <para>dqm:regex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The regular expressions property can be used to express legal character ranges and data patterns for values of a certain property via regular expressions."</para>
    /// labels<para>"Regular Expression"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#regex">http://purl.org/dqm-vocabulary/v1/dqm#regex</seealso>
    let regex = Prefixed_Name(dqm, "regex") |> PrefixedName
    /// <summary>
    ///   <para>dqm:reqDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes a data requirement in natural language."</para>
    /// labels<para>"Requirement Description"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#reqDescription">http://purl.org/dqm-vocabulary/v1/dqm#reqDescription</seealso>
    let reqDescription = Prefixed_Name(dqm, "reqDescription") |> PrefixedName
    /// <summary>
    ///   <para>dqm:reqMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An abstract property that holds generic datatype properties that describe a data requirement."</para>
    /// labels<para>"Requirement Metadata"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#reqMetadata">http://purl.org/dqm-vocabulary/v1/dqm#reqMetadata</seealso>
    let reqMetadata = Prefixed_Name(dqm, "reqMetadata") |> PrefixedName
    /// <summary>
    ///   <para>dqm:reqName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the name of a data requirement in natural language."</para>
    /// labels<para>"Requirement Name"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#reqName">http://purl.org/dqm-vocabulary/v1/dqm#reqName</seealso>
    let reqName = Prefixed_Name(dqm, "reqName") |> PrefixedName
    /// <summary>
    ///   <para>dqm:reqSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the source of a data requirement."</para>
    /// labels<para>"Requirement Source"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#reqSource">http://purl.org/dqm-vocabulary/v1/dqm#reqSource</seealso>
    let reqSource = Prefixed_Name(dqm, "reqSource") |> PrefixedName
    /// <summary>
    ///   <para>dqm:requiredProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies whether a property must exist."</para>
    /// labels<para>"Required Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#requiredProperty">http://purl.org/dqm-vocabulary/v1/dqm#requiredProperty</seealso>
    let requiredProperty = Prefixed_Name(dqm, "requiredProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:requiredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies whether a value for a property must exist."</para>
    /// labels<para>"Required Value"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#requiredValue">http://purl.org/dqm-vocabulary/v1/dqm#requiredValue</seealso>
    let requiredValue = Prefixed_Name(dqm, "requiredValue") |> PrefixedName

    /// <summary>
    ///   <para>dqm:ruleOfIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The rule of identification property connects the data quality problem instances with the instance of the data requirement that has detected the problem."</para>
    /// labels<para>"Rule Of Identification"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ruleOfIdentification">http://purl.org/dqm-vocabulary/v1/dqm#ruleOfIdentification</seealso>
    let ruleOfIdentification =
        Prefixed_Name(dqm, "ruleOfIdentification") |> PrefixedName

    /// <summary>
    ///   <para>dqm:ruleViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects data requirements with data quality problems that have been identified using the requirement."</para>
    /// labels<para>"Rule Violation"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#ruleViolation">http://purl.org/dqm-vocabulary/v1/dqm#ruleViolation</seealso>
    let ruleViolation = Prefixed_Name(dqm, "ruleViolation") |> PrefixedName
    /// <summary>
    ///   <para>dqm:scaleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DataRange</para>
    ///   <para>"Type of statistical scale."</para>
    /// labels<para>"Scale Type"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#scaleType">http://purl.org/dqm-vocabulary/v1/dqm#scaleType</seealso>
    let scaleType = Prefixed_Name(dqm, "scaleType") |> PrefixedName
    /// <summary>
    ///   <para>dqm:scaleValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links to values of a certain ordinal or nominal scale."</para>
    /// labels<para>"Scale Values"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#scaleValues">http://purl.org/dqm-vocabulary/v1/dqm#scaleValues</seealso>
    let scaleValues = Prefixed_Name(dqm, "scaleValues") |> PrefixedName
    /// <summary>
    ///   <para>dqm:sparqlrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property can store custom data requirements that are expressed via SPARQL queries."</para>
    /// labels<para>"SPARQL rule"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#sparqlrule">http://purl.org/dqm-vocabulary/v1/dqm#sparqlrule</seealso>
    let sparqlrule = Prefixed_Name(dqm, "sparqlrule") |> PrefixedName
    /// <summary>
    ///   <para>dqm:startsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Holds one or more consecutive characters that are supposed to be found at the beginning of strings of another property."</para>
    /// labels<para>"Starts With"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#startsWith">http://purl.org/dqm-vocabulary/v1/dqm#startsWith</seealso>
    let startsWith = Prefixed_Name(dqm, "startsWith") |> PrefixedName
    /// <summary>
    ///   <para>dqm:subTaskOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Property that can be used to represent hierachies of between tasks."</para>
    /// labels<para>"Sub Task Of"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#subTaskOf">http://purl.org/dqm-vocabulary/v1/dqm#subTaskOf</seealso>
    let subTaskOf = Prefixed_Name(dqm, "subTaskOf") |> PrefixedName
    /// <summary>
    ///   <para>dqm:taskDependent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies whether the data quality rule is task dependent."</para>
    /// labels<para>"Task Dependent"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#taskDependent">http://purl.org/dqm-vocabulary/v1/dqm#taskDependent</seealso>
    let taskDependent = Prefixed_Name(dqm, "taskDependent") |> PrefixedName
    /// <summary>
    ///   <para>dqm:taskDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes the task in natural language."</para>
    /// labels<para>"Task Description"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#taskDescription">http://purl.org/dqm-vocabulary/v1/dqm#taskDescription</seealso>
    let taskDescription = Prefixed_Name(dqm, "taskDescription") |> PrefixedName
    /// <summary>
    ///   <para>dqm:taskName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the name of the task."</para>
    /// labels<para>"Task Name"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#taskName">http://purl.org/dqm-vocabulary/v1/dqm#taskName</seealso>
    let taskName = Prefixed_Name(dqm, "taskName") |> PrefixedName
    /// <summary>
    ///   <para>dqm:technicalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Technical name of a value."</para>
    /// labels<para>"Technical Name"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#technicalName">http://purl.org/dqm-vocabulary/v1/dqm#technicalName</seealso>
    let technicalName = Prefixed_Name(dqm, "technicalName") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The tested class property specifies the class that holds the instances that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Class"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedClass">http://purl.org/dqm-vocabulary/v1/dqm#testedClass</seealso>
    let testedClass = Prefixed_Name(dqm, "testedClass") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property with the values that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Property"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty">http://purl.org/dqm-vocabulary/v1/dqm#testedProperty</seealso>
    let testedProperty = Prefixed_Name(dqm, "testedProperty") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedProperty1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property with the values that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Property 1"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty1">http://purl.org/dqm-vocabulary/v1/dqm#testedProperty1</seealso>
    let testedProperty1 = Prefixed_Name(dqm, "testedProperty1") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedProperty2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The property with the values that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Property 2"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty2">http://purl.org/dqm-vocabulary/v1/dqm#testedProperty2</seealso>
    let testedProperty2 = Prefixed_Name(dqm, "testedProperty2") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedProperty3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The property with the values that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Property 3"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty3">http://purl.org/dqm-vocabulary/v1/dqm#testedProperty3</seealso>
    let testedProperty3 = Prefixed_Name(dqm, "testedProperty3") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedProperty4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The property with the values that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Property 4"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty4">http://purl.org/dqm-vocabulary/v1/dqm#testedProperty4</seealso>
    let testedProperty4 = Prefixed_Name(dqm, "testedProperty4") |> PrefixedName
    /// <summary>
    ///   <para>dqm:testedProperty5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property with the values that shall be tested for data quality problems."</para>
    /// labels<para>"Tested Property 5"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#testedProperty5">http://purl.org/dqm-vocabulary/v1/dqm#testedProperty5</seealso>
    let testedProperty5 = Prefixed_Name(dqm, "testedProperty5") |> PrefixedName
    /// <summary>
    ///   <para>dqm:timeOfAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time of assessment represents the data and time when the data quality score was computed."</para>
    /// labels<para>"Time Of Assessment"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfAssessment">http://purl.org/dqm-vocabulary/v1/dqm#timeOfAssessment</seealso>
    let timeOfAssessment = Prefixed_Name(dqm, "timeOfAssessment") |> PrefixedName

    /// <summary>
    ///   <para>dqm:timeOfIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time of identification property specifies the date and time in which the data quality problem was detected"</para>
    /// labels<para>"Time Of Identification"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#timeOfIdentification">http://purl.org/dqm-vocabulary/v1/dqm#timeOfIdentification</seealso>
    let timeOfIdentification =
        Prefixed_Name(dqm, "timeOfIdentification") |> PrefixedName

    /// <summary>
    ///   <para>dqm:unitDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Description of a unit of measurement."</para>
    /// labels<para>"Unit Description"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#unitDescription">http://purl.org/dqm-vocabulary/v1/dqm#unitDescription</seealso>
    let unitDescription = Prefixed_Name(dqm, "unitDescription") |> PrefixedName
    /// <summary>
    ///   <para>dqm:unitName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of a unit of measurement."</para>
    /// labels<para>"Unit Name"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#unitName">http://purl.org/dqm-vocabulary/v1/dqm#unitName</seealso>
    let unitName = Prefixed_Name(dqm, "unitName") |> PrefixedName
    /// <summary>
    ///   <para>dqm:unitOfConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The unit in which confidence is expressed."</para>
    /// labels<para>"Unit of Confidence"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfConfidence">http://purl.org/dqm-vocabulary/v1/dqm#unitOfConfidence</seealso>
    let unitOfConfidence = Prefixed_Name(dqm, "unitOfConfidence") |> PrefixedName
    /// <summary>
    ///   <para>dqm:unitOfImportance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The unit in which importance is expressed."</para>
    /// labels<para>"Unit of Importance"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfImportance">http://purl.org/dqm-vocabulary/v1/dqm#unitOfImportance</seealso>
    let unitOfImportance = Prefixed_Name(dqm, "unitOfImportance") |> PrefixedName
    /// <summary>
    ///   <para>dqm:unitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicates the unit of measurement, e.g. of data quality scores. It is recommended to use UN/CEFACT common codes to specify the unit of measurement, e.g. "P1" stands for percent."</para>
    /// labels<para>"Unit of Measurement"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#unitOfMeasurement">http://purl.org/dqm-vocabulary/v1/dqm#unitOfMeasurement</seealso>
    let unitOfMeasurement = Prefixed_Name(dqm, "unitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>dqm:upperLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the upper limit a numeric property value shall obtain."</para>
    /// labels<para>"Upper Limit"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#upperLimit">http://purl.org/dqm-vocabulary/v1/dqm#upperLimit</seealso>
    let upperLimit = Prefixed_Name(dqm, "upperLimit") |> PrefixedName
    /// <summary>
    ///   <para>dqm:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the date and time from which a rule is valid."</para>
    /// labels<para>"Valid From"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#validFrom">http://purl.org/dqm-vocabulary/v1/dqm#validFrom</seealso>
    let validFrom = Prefixed_Name(dqm, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>dqm:validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the date and time until a rule stays valid."</para>
    /// labels<para>"Valid Until"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#validUntil">http://purl.org/dqm-vocabulary/v1/dqm#validUntil</seealso>
    let validUntil = Prefixed_Name(dqm, "validUntil") |> PrefixedName
    /// <summary>
    ///   <para>dqm:validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Validation indicates whether a data quality rule shall be used for validation during data entry."</para>
    /// labels<para>"Validation"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#validation">http://purl.org/dqm-vocabulary/v1/dqm#validation</seealso>
    let validation = Prefixed_Name(dqm, "validation") |> PrefixedName
    /// <summary>
    ///   <para>dqm:valueMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Meaning of a value."</para>
    /// labels<para>"Value Meaning"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#valueMeaning">http://purl.org/dqm-vocabulary/v1/dqm#valueMeaning</seealso>
    let valueMeaning = Prefixed_Name(dqm, "valueMeaning") |> PrefixedName
    /// <summary>
    ///   <para>dqm:weightedScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A weighted score is a data quality dimension score that is computed by integration of importance values of data requirements, tasks, or data elements."</para>
    /// labels<para>"Weighted Score"</para></remarks>
    /// <seealso href="http://purl.org/dqm-vocabulary/v1/dqm#weightedScore">http://purl.org/dqm-vocabulary/v1/dqm#weightedScore</seealso>
    let weightedScore = Prefixed_Name(dqm, "weightedScore") |> PrefixedName
