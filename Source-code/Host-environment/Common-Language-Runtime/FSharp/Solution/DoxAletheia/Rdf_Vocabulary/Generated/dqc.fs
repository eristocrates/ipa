namespace http.semwebquality.org.ontologies.dq_constraints.hash

open DoxAletheia.Rdf_Vocabulary

module dqc =
    let _namespace_name = "http://semwebquality.org/ontologies/dq-constraints#"

    /// <summary>
    /// Constraint templates are generalized SPARQL query templates based on the SPARQL Inferencing Framework (SPIN). The query templates represent generic data quality rules that may be used to identify data quality problems, i.e. violations of previously defined constraints.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ConstraintTemplates"></see></summary>
    let ConstraintTemplates =
        Namespaced_IRI.parse _namespace_name "ConstraintTemplates" |> NamespacedName

    /// <summary>
    /// This query flags wrong EAN-13 values.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#EAN-13All"></see></summary>
    let ``EAN-13All`` =
        Namespaced_IRI.parse _namespace_name "EAN-13All" |> NamespacedName

    /// <summary>
    /// Syntax constraints identify values that do not adhere to syntactical rules. {@en}
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#SyntaxConstraints"></see></summary>
    let SyntaxConstraints =
        Namespaced_IRI.parse _namespace_name "SyntaxConstraints" |> NamespacedName

    /// <summary>
    /// This query flags wrong EAN-13 values in instances of a specified class.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#EAN-13Class"></see></summary>
    let ``EAN-13Class`` =
        Namespaced_IRI.parse _namespace_name "EAN-13Class" |> NamespacedName

    /// <summary>
    /// This query flags instances with property ?arg1 and value ?arg2 that do not have value ?arg4 with property ?arg3. It is only suitable for value dependencies with one to one cardinality. The query does not tolerate homonyms and is not restricted to a specific class.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ExclusiveFunctionalDependencyAll"></see></summary>
    let ExclusiveFunctionalDependencyAll =
        Namespaced_IRI.parse _namespace_name "ExclusiveFunctionalDependencyAll" |> NamespacedName

    /// <summary>
    /// Functional dependencies are dependencies between the values of two or more different properties. Functional dependency constraints check the abidance of functional dependencies.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyConstraints"></see></summary>
    let FunctionalDependencyConstraints =
        Namespaced_IRI.parse _namespace_name "FunctionalDependencyConstraints" |> NamespacedName

    /// <summary>
    /// This query flags instances of class ?arg1 with property ?arg2 and value ?arg3 that do not have value ?arg5 with property ?arg4. It is only suitable for value dependencies with one to one cardinality. The query does not tolerate homonyms. Not defined dependencies will not be flagged.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ExclusiveFunctionalDependencyClass"></see></summary>
    let ExclusiveFunctionalDependencyClass =
        Namespaced_IRI.parse _namespace_name "ExclusiveFunctionalDependencyClass" |> NamespacedName

    /// <summary>
    /// This query flags all instances that do not have a five digit numeric value for property ?arg1.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#FiveDigitNumericAll"></see></summary>
    let FiveDigitNumericAll =
        Namespaced_IRI.parse _namespace_name "FiveDigitNumericAll" |> NamespacedName

    /// <summary>
    /// This query flags instances with properties ?arg1 and ?arg2 that do not have a corresponding value combination in instances of the trusted reference in class ?arg3. The semantics of property ?arg1 should be equal with property ?arg4, and the semantics of property ?arg2 should be equal with ?arg5. The query tolerates homonymous values, i.e. the same value may be assigned to different dependent values by using different instances in the trusted reference. Value combinations that cannot be found in the trusted reference will also be flagged as incorrect. The query will also test the existence of a single value in the trusted reference when one property of the tested data is missing.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReferenceAll"></see></summary>
    let FunctionalDependencyTrustedReferenceAll =
        Namespaced_IRI.parse _namespace_name "FunctionalDependencyTrustedReferenceAll" |> NamespacedName

    /// <summary>
    /// This query flags instances of class ?arg 1 with properties ?arg2 and ?arg3 that do not have the exact value combination in instances of the trusted reference in class ?arg4. The semantics of property ?arg2 should be equal with property ?arg5, and the semantics of property ?arg3 should be equal with ?arg6. The query tolerates homonymous values, i.e. the same value may be assigned to different dependent values. Value combinations that cannot be found in the trusted reference will also be flagged. The query will also test the existence of a single value in the trusted reference when one property of the tested data is missing.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReferenceClass"></see></summary>
    let FunctionalDependencyTrustedReferenceClass =
        Namespaced_IRI.parse _namespace_name "FunctionalDependencyTrustedReferenceClass" |> NamespacedName

    /// <summary>
    /// This query is designed to test (blank node) instances of the property-and-node element (rdf:parseType="Resource") ?arg2 that are part of the instances of class ?arg 1. The query flags instances of property ?arg2 with properties ?arg3 and ?arg4 that do not have the exact value combination in instances of the trusted reference in class ?arg5. The semantics of property ?arg3 should be equal with property ?arg6, and the semantics of property ?arg4 should be equal with ?arg7. The query tolerates homonymous values, i.e. the same value may be assigned to different dependent values. Value combinations that cannot be found in the trusted reference will also be flagged. The query will also test the existence of a single value in the trusted reference when one property of the tested data is missing.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReference_ClassOverBlankNode"></see></summary>
    let FunctionalDependencyTrustedReference_ClassOverBlankNode =
        Namespaced_IRI.parse _namespace_name "FunctionalDependencyTrustedReference_ClassOverBlankNode" |> NamespacedName

    /// <summary>
    /// This query returns all instances with value ?arg2 for property ?arg1 that do not have an empty literal string for property ?arg3.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependentEmptyValueAll"></see></summary>
    let FunctionalDependentEmptyValueAll =
        Namespaced_IRI.parse _namespace_name "FunctionalDependentEmptyValueAll" |> NamespacedName

    /// <summary>
    /// This query flags all instances with inconsistant value ranges. Among others it is suitable for value ranges with datatypes xsd:integer, xsd:int, xsd:float, xsd:date, and xsd:dateTime. The literals must be typed.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#InconsistentValueRangeAll"></see></summary>
    let InconsistentValueRangeAll =
        Namespaced_IRI.parse _namespace_name "InconsistentValueRangeAll" |> NamespacedName

    /// <summary>
    /// Value range constraints allow the identification of values that do not obey a certain upper and/or lower limit.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ValueRangeConstraints"></see></summary>
    let ValueRangeConstraints =
        Namespaced_IRI.parse _namespace_name "ValueRangeConstraints" |> NamespacedName

    /// <summary>
    /// Legal value constraints identify values that are either not explicitly allowed or explicitly illegal.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#LegalValueConstraints"></see></summary>
    let LegalValueConstraints =
        Namespaced_IRI.parse _namespace_name "LegalValueConstraints" |> NamespacedName

    /// <summary>
    /// This query flags all instances with property ?arg1 that do not have letters as literal values. The query tolerates language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#LettersAll"></see></summary>
    let LettersAll = Namespaced_IRI.parse _namespace_name "LettersAll" |> NamespacedName

    /// <summary>
    /// This query flags all instances with property ?arg1 that have characters other than letters or dots in literal values. The query tolerates language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#LettersAndDotsAll"></see></summary>
    let LettersAndDotsAll =
        Namespaced_IRI.parse _namespace_name "LettersAndDotsAll" |> NamespacedName

    /// <summary>
    /// This query flags all instances with property ?arg1 that have values which are contained in property ?arg3 of instances of class ?arg2. The query tolerates chaotic assignments of language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ListedIllegalValueAll"></see></summary>
    let ListedIllegalValueAll =
        Namespaced_IRI.parse _namespace_name "ListedIllegalValueAll" |> NamespacedName

    /// <summary>
    /// This query flags all instances of class ?arg1 with property ?arg2 that have values which are contained in property ?arg4 of instances of class ?arg3. The query tolerates chaotic assignments of language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ListedIllegalValueClass"></see></summary>
    let ListedIllegalValueClass =
        Namespaced_IRI.parse _namespace_name "ListedIllegalValueClass" |> NamespacedName

    /// <summary>
    /// This query flags all instances with property ?arg1 that have values which are not contained in  property ?arg3 of instances of class ?arg2. The query tolerates chaotic assignments of language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueAll"></see></summary>
    let ListedLegalValueAll =
        Namespaced_IRI.parse _namespace_name "ListedLegalValueAll" |> NamespacedName

    /// <summary>
    /// This query flags all instances of class ?arg1 with property ?arg2 that have values which are not contained in property ?arg4 of instances of class ?arg3. The query tolerates chaotic assignments of language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueClass"></see></summary>
    let ListedLegalValueClass =
        Namespaced_IRI.parse _namespace_name "ListedLegalValueClass" |> NamespacedName

    /// <summary>
    /// This query flags all instances of property-and-node element ?arg2 (rdf:parseType="Resource") with property ?arg3 in class ?arg1 that have values which are not contained in property ?arg5 of instances of class ?arg3. The query tolerates chaotic assignments of language tags.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueClassOverBlankNode"></see></summary>
    let ListedLegalValueClassOverBlankNode =
        Namespaced_IRI.parse _namespace_name "ListedLegalValueClassOverBlankNode" |> NamespacedName

    /// <summary>
    /// This query returns all instances that have a value for property ?arg1 below the user defined limit ?arg2. The query tolerates chaotic datatype assignments.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#LowerLimitAll"></see></summary>
    let LowerLimitAll =
        Namespaced_IRI.parse _namespace_name "LowerLimitAll" |> NamespacedName

    /// <summary>
    /// This query returns all instances of class ?arg1 that have a value for property ?arg2 below the user defined limit ?arg3. The query tolerates chaotic datatype assignments.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#LowerLimitClass"></see></summary>
    let LowerLimitClass =
        Namespaced_IRI.parse _namespace_name "LowerLimitClass" |> NamespacedName

    /// <summary>
    /// Missing element constraints identify elements in the data set that are missing but required.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#MissingElementConstraints"></see></summary>
    let MissingElementConstraints =
        Namespaced_IRI.parse _namespace_name "MissingElementConstraints" |> NamespacedName

    /// <summary>
    /// This query returns all instances of class ?arg1 where the literal for ?arg2 is empty. It does not return instances where the whole property ?arg2 is missing.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#MissingLiterals"></see></summary>
    let MissingLiterals =
        Namespaced_IRI.parse _namespace_name "MissingLiterals" |> NamespacedName

    /// <summary>
    /// This query returns all instances of class ?arg1 where the literal for ?arg2 is empty or the whole property ?arg2 is missing.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#MissingLiteralsAndProperties"></see></summary>
    let MissingLiteralsAndProperties =
        Namespaced_IRI.parse _namespace_name "MissingLiteralsAndProperties" |> NamespacedName

    /// <summary>
    /// This query returns all instances of class ?arg1 where property ?arg2 is missing. It explicitly tolerates empty literal values in property ?arg2.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#MissingProperties"></see></summary>
    let MissingProperties =
        Namespaced_IRI.parse _namespace_name "MissingProperties" |> NamespacedName

    /// <summary>
    /// This query flags all instances with property ?arg1 that have characters other than numbers as literal values.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#NumbersAll"></see></summary>
    let NumbersAll = Namespaced_IRI.parse _namespace_name "NumbersAll" |> NamespacedName

    /// <summary>
    /// This query returns all instances where the value for property ?arg1 is not unique in the tested data set. The query tolerates chaotic language tag assignments.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#UniqueValueAll"></see></summary>
    let UniqueValueAll =
        Namespaced_IRI.parse _namespace_name "UniqueValueAll" |> NamespacedName

    /// <summary>
    /// Uniqueness constraints identify values that shall be unique, but are redundant within a certain data set.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#UniquenessConstraints"></see></summary>
    let UniquenessConstraints =
        Namespaced_IRI.parse _namespace_name "UniquenessConstraints" |> NamespacedName

    /// <summary>
    /// This query returns all instances of class ?arg1 where the value for property ?arg2 is not unique in the tested data set. The query tolerates chaotic language tag assignments.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#UniqueValueClass"></see></summary>
    let UniqueValueClass =
        Namespaced_IRI.parse _namespace_name "UniqueValueClass" |> NamespacedName

    /// <summary>
    /// This query returns all instances that have a value for property ?arg1 above the user defined limit ?arg2. The query tolerates chaotic datatype assignments.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#UpperLimitAll"></see></summary>
    let UpperLimitAll =
        Namespaced_IRI.parse _namespace_name "UpperLimitAll" |> NamespacedName

    /// <summary>
    /// This query returns all instances of class ?arg1 that have a value for property ?arg2 above the user defined limit ?arg3. The query tolerates chaotic datatype assignments.
    /// <see href="http://semwebquality.org/ontologies/dq-constraints#UpperLimitClass"></see></summary>
    let UpperLimitClass =
        Namespaced_IRI.parse _namespace_name "UpperLimitClass" |> NamespacedName
