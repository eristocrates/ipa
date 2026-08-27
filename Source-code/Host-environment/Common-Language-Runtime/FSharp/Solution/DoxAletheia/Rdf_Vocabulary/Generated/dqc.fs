namespace http.semwebquality.org.ontologies.dq_constraints.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dqc =
    let _namespace_iri = Namespace_Iri dqc |> NamespaceIRI
    /// <summary>
    ///   <para>dqc:ConstraintTemplates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Constraint templates are generalized SPARQL query templates based on the SPARQL Inferencing Framework (SPIN). The query templates represent generic data quality rules that may be used to identify data quality problems, i.e. violations of previously defined constraints."</para>
    /// labels<para>"data quality constraint templates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ConstraintTemplates">http://semwebquality.org/ontologies/dq-constraints#ConstraintTemplates</seealso>
    let ConstraintTemplates = Prefixed_Name(dqc, "ConstraintTemplates") |> PrefixedName
    /// <summary>
    ///   <para>dqc:EAN-13All</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://jena.hpl.hp.com/ARQ/function#substr&gt;</para>
    ///   <para>sp:add</para>
    ///   <para>sp:regex</para>
    ///   <para>sp:Let</para>
    ///   <para>sp:str</para>
    ///   <para>xsd:int</para>
    ///   <para>sp:ne</para>
    ///   <para>fn:string-length</para>
    ///   <para>spl:Argument</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:mul</para>
    ///   <para>sp:and</para>
    ///   <para>sp:or</para>
    ///   <para>sp:sub</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:not</para>
    ///   <para>sp:Construct</para>
    ///   <para>"Please enter the property holding the EAN-13!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags wrong EAN-13 values."</para>
    /// labels<para>"EAN-13 All"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#EAN-13All">http://semwebquality.org/ontologies/dq-constraints#EAN-13All</seealso>
    let EAN_13All = Prefixed_Name(dqc, "EAN-13All") |> PrefixedName
    /// <summary>
    ///   <para>dqc:EAN-13Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:str</para>
    ///   <para>&lt;http://jena.hpl.hp.com/ARQ/function#substr&gt;</para>
    ///   <para>sp:Filter</para>
    ///   <para>xsd:int</para>
    ///   <para>fn:string-length</para>
    ///   <para>sp:Let</para>
    ///   <para>sp:add</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:and</para>
    ///   <para>sp:ne</para>
    ///   <para>sp:regex</para>
    ///   <para>sp:or</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:mul</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:sub</para>
    ///   <para>sp:not</para>
    ///   <para>"Please enter the property holding the EAN-13!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags wrong EAN-13 values in instances of a specified class."</para>
    ///   <para>"Please enter the class holding the instances that shall be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EAN-13 Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#EAN-13Class">http://semwebquality.org/ontologies/dq-constraints#EAN-13Class</seealso>
    let EAN_13Class = Prefixed_Name(dqc, "EAN-13Class") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ExclusiveFunctionalDependencyAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:not</para>
    ///   <para>spl:Argument</para>
    ///   <para>spl:hasValue</para>
    ///   <para>sp:Construct</para>
    ///   <para>"Select property 2 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags instances with property ?arg1 and value ?arg2 that do not have value ?arg4 with property ?arg3. It is only suitable for value dependencies with one to one cardinality. The query does not tolerate homonyms and is not restricted to a specific class."</para>
    ///   <para>"Enter functionally dependent value 2 of property 2!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property 1 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Enter functionally dependent value 1 of property 1!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exclusive functional dependency check in all instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ExclusiveFunctionalDependencyAll">http://semwebquality.org/ontologies/dq-constraints#ExclusiveFunctionalDependencyAll</seealso>
    let ExclusiveFunctionalDependencyAll =
        Prefixed_Name(dqc, "ExclusiveFunctionalDependencyAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ExclusiveFunctionalDependencyClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:hasValue</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:not</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:Filter</para>
    ///   <para>"Select class that holds instances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property 1 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Enter functionally dependent value 2 of property 2!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Enter functionally dependent value 1 of property 1!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags instances of class ?arg1 with property ?arg2 and value ?arg3 that do not have value ?arg5 with property ?arg4. It is only suitable for value dependencies with one to one cardinality. The query does not tolerate homonyms. Not defined dependencies will not be flagged."</para>
    ///   <para>"Select property 2 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exclusive functional dependency check in class instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ExclusiveFunctionalDependencyClass">http://semwebquality.org/ontologies/dq-constraints#ExclusiveFunctionalDependencyClass</seealso>
    let ExclusiveFunctionalDependencyClass =
        Prefixed_Name(dqc, "ExclusiveFunctionalDependencyClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:FiveDigitNumericAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:regex</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:not</para>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:str</para>
    ///   <para>"Select the property that contains the US zip codes!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances that do not have a five digit numeric value for property ?arg1."</para>
    /// labels<para>"syntax check in all instances:  5 digit numeric values"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#FiveDigitNumericAll">http://semwebquality.org/ontologies/dq-constraints#FiveDigitNumericAll</seealso>
    let FiveDigitNumericAll = Prefixed_Name(dqc, "FiveDigitNumericAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:FunctionalDependencyConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Functional dependencies are dependencies between the values of two or more different properties. Functional dependency constraints check the abidance of functional dependencies."</para>
    /// labels<para>"functional dependency constraints"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyConstraints">http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyConstraints</seealso>
    let FunctionalDependencyConstraints =
        Prefixed_Name(dqc, "FunctionalDependencyConstraints") |> PrefixedName

    /// <summary>
    ///   <para>dqc:FunctionalDependencyTrustedReferenceAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:NotExists</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:Optional</para>
    ///   <para>spl:Argument</para>
    ///   <para>"Select class of trusted reference that holds instances with legal value combinations!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select first property of trusted reference that holds legal values for property 1!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property 2 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property 1 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags instances with properties ?arg1 and ?arg2 that do not have a corresponding value combination in instances of the trusted reference in class ?arg3. The semantics of property ?arg1 should be equal with property ?arg4, and the semantics of property ?arg2 should be equal with ?arg5. The query tolerates homonymous values, i.e. the same value may be assigned to different dependent values by using different instances in the trusted reference. Value combinations that cannot be found in the trusted reference will also be flagged as incorrect. The query will also test the existence of a single value in the trusted reference when one property of the tested data is missing."</para>
    ///   <para>"Select second property of trusted reference that holds legal values for property 2!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Functional dependency check in all instances with trusted reference"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReferenceAll">http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReferenceAll</seealso>
    let FunctionalDependencyTrustedReferenceAll =
        Prefixed_Name(dqc, "FunctionalDependencyTrustedReferenceAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:FunctionalDependencyTrustedReferenceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:NotExists</para>
    ///   <para>sp:Construct</para>
    ///   <para>spin:Template</para>
    ///   <para>"Select property 2 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class of trusted reference that holds instances with legal value combinations!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags instances of class ?arg 1 with properties ?arg2 and ?arg3 that do not have the exact value combination in instances of the trusted reference in class ?arg4. The semantics of property ?arg2 should be equal with property ?arg5, and the semantics of property ?arg3 should be equal with ?arg6. The query tolerates homonymous values, i.e. the same value may be assigned to different dependent values. Value combinations that cannot be found in the trusted reference will also be flagged. The query will also test the existence of a single value in the trusted reference when one property of the tested data is missing."</para>
    ///   <para>"Select first property of trusted reference that holds legal values for property 1!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property 1 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select second property of trusted reference that holds legal values for property 2!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class that holds instances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Functional dependency check in class instances with trusted reference"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReferenceClass">http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReferenceClass</seealso>
    let FunctionalDependencyTrustedReferenceClass =
        Prefixed_Name(dqc, "FunctionalDependencyTrustedReferenceClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:FunctionalDependencyTrustedReference_ClassOverBlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:Construct</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:NotExists</para>
    ///   <para>"Select class of trusted reference that holds instances with legal value combinations!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select second property of trusted reference that holds legal values for property 2!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query is designed to test (blank node) instances of the property-and-node element (rdf:parseType="Resource") ?arg2 that are part of the instances of class ?arg 1. The query flags instances of property ?arg2 with properties ?arg3 and ?arg4 that do not have the exact value combination in instances of the trusted reference in class ?arg5. The semantics of property ?arg3 should be equal with property ?arg6, and the semantics of property ?arg4 should be equal with ?arg7. The query tolerates homonymous values, i.e. the same value may be assigned to different dependent values. Value combinations that cannot be found in the trusted reference will also be flagged. The query will also test the existence of a single value in the trusted reference when one property of the tested data is missing."</para>
    ///   <para>"Select property 2 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property that holds blank nodes!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property 1 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class that holds instances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select first property of trusted reference that holds legal values for property 1!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Functional dependency check in blank node instances of a class with trusted reference"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReference_ClassOverBlankNode">http://semwebquality.org/ontologies/dq-constraints#FunctionalDependencyTrustedReference_ClassOverBlankNode</seealso>
    let FunctionalDependencyTrustedReference_ClassOverBlankNode =
        Prefixed_Name(dqc, "FunctionalDependencyTrustedReference_ClassOverBlankNode") |> PrefixedName

    /// <summary>
    ///   <para>dqc:FunctionalDependentEmptyValueAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:Filter</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:not</para>
    ///   <para>spl:hasValue</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Construct</para>
    ///   <para>"Select property 1 of functional dependency!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query returns all instances with value ?arg2 for property ?arg1 that do not have an empty literal string for property ?arg3."</para>
    ///   <para>"Enter functionally dependent value 1 of property 1!"</para>
    ///   <para>"Select property that must contain empty literal!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#FunctionalDependentEmptyValueAll">http://semwebquality.org/ontologies/dq-constraints#FunctionalDependentEmptyValueAll</seealso>
    let FunctionalDependentEmptyValueAll =
        Prefixed_Name(dqc, "FunctionalDependentEmptyValueAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:InconsistentValueRangeAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:ge</para>
    ///   <para>sp:Construct</para>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>"Please enter the datatype property that shall hold the greater value!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Please enter the datatype property that shall hold the lower value!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances with inconsistant value ranges. Among others it is suitable for value ranges with datatypes xsd:integer, xsd:int, xsd:float, xsd:date, and xsd:dateTime. The literals must be typed."</para>
    /// labels<para>"Inconsistent value range all"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#InconsistentValueRangeAll">http://semwebquality.org/ontologies/dq-constraints#InconsistentValueRangeAll</seealso>
    let InconsistentValueRangeAll =
        Prefixed_Name(dqc, "InconsistentValueRangeAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:LegalValueConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Legal value constraints identify values that are either not explicitly allowed or explicitly illegal."</para>
    /// labels<para>"legal value constraints"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#LegalValueConstraints">http://semwebquality.org/ontologies/dq-constraints#LegalValueConstraints</seealso>
    let LegalValueConstraints =
        Prefixed_Name(dqc, "LegalValueConstraints") |> PrefixedName

    /// <summary>
    ///   <para>dqc:LettersAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Construct</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:not</para>
    ///   <para>sp:regex</para>
    ///   <para>sp:str</para>
    ///   <para>sp:Filter</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances with property ?arg1 that do not have letters as literal values. The query tolerates language tags."</para>
    /// labels<para>"syntax check in all instances: only letters allowed"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#LettersAll">http://semwebquality.org/ontologies/dq-constraints#LettersAll</seealso>
    let LettersAll = Prefixed_Name(dqc, "LettersAll") |> PrefixedName
    /// <summary>
    ///   <para>dqc:LettersAndDotsAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:regex</para>
    ///   <para>sp:str</para>
    ///   <para>sp:Filter</para>
    ///   <para>spl:Argument</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:not</para>
    ///   <para>sp:Construct</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances with property ?arg1 that have characters other than letters or dots in literal values. The query tolerates language tags."</para>
    /// labels<para>"syntax check in all instances: only letters and dots allowed"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#LettersAndDotsAll">http://semwebquality.org/ontologies/dq-constraints#LettersAndDotsAll</seealso>
    let LettersAndDotsAll = Prefixed_Name(dqc, "LettersAndDotsAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ListedIllegalValueAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:str</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:bound</para>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:eq</para>
    ///   <para>sp:Construct</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class with instances holding the illegal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances with property ?arg1 that have values which are contained in property ?arg3 of instances of class ?arg2. The query tolerates chaotic assignments of language tags."</para>
    ///   <para>"Select property holding the illegal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Illegal value check in all instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ListedIllegalValueAll">http://semwebquality.org/ontologies/dq-constraints#ListedIllegalValueAll</seealso>
    let ListedIllegalValueAll =
        Prefixed_Name(dqc, "ListedIllegalValueAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ListedIllegalValueClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:bound</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:str</para>
    ///   <para>sp:eq</para>
    ///   <para>"This query flags all instances of class ?arg1 with property ?arg2 that have values which are contained in property ?arg4 of instances of class ?arg3. The query tolerates chaotic assignments of language tags."</para>
    ///   <para>"Select class that holds instances with illegal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class with instances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property that holds illegal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Illegal value check in class instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ListedIllegalValueClass">http://semwebquality.org/ontologies/dq-constraints#ListedIllegalValueClass</seealso>
    let ListedIllegalValueClass =
        Prefixed_Name(dqc, "ListedIllegalValueClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ListedLegalValueAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:bound</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:str</para>
    ///   <para>sp:Construct</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:eq</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:not</para>
    ///   <para>"Select class that holds instances with legal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances with property ?arg1 that have values which are not contained in  property ?arg3 of instances of class ?arg2. The query tolerates chaotic assignments of language tags."</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property that holds legal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Legal value check in all instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueAll">http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueAll</seealso>
    let ListedLegalValueAll = Prefixed_Name(dqc, "ListedLegalValueAll") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ListedLegalValueClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:str</para>
    ///   <para>sp:bound</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:not</para>
    ///   <para>sp:eq</para>
    ///   <para>"Select class that holds instances with legal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class with instances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property that holds legal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances of class ?arg1 with property ?arg2 that have values which are not contained in property ?arg4 of instances of class ?arg3. The query tolerates chaotic assignments of language tags."</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Legal value check in class instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueClass">http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueClass</seealso>
    let ListedLegalValueClass =
        Prefixed_Name(dqc, "ListedLegalValueClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ListedLegalValueClassOverBlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:str</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:bound</para>
    ///   <para>sp:Optional</para>
    ///   <para>sp:not</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:eq</para>
    ///   <para>"Select class with instances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class that holds instances with legal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property that holds blank nodes!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select property that holds legal values!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query flags all instances of property-and-node element ?arg2 (rdf:parseType="Resource") with property ?arg3 in class ?arg1 that have values which are not contained in property ?arg5 of instances of class ?arg3. The query tolerates chaotic assignments of language tags."</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Legal value check in blank node instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueClassOverBlankNode">http://semwebquality.org/ontologies/dq-constraints#ListedLegalValueClassOverBlankNode</seealso>
    let ListedLegalValueClassOverBlankNode =
        Prefixed_Name(dqc, "ListedLegalValueClassOverBlankNode") |> PrefixedName

    /// <summary>
    ///   <para>dqc:LowerLimitAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>sp:Construct</para>
    ///   <para>smf:cast</para>
    ///   <para>sp:lt</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>"Select property to be tested!"</para>
    ///   <para>"This query returns all instances that have a value for property ?arg1 below the user defined limit ?arg2. The query tolerates chaotic datatype assignments."</para>
    ///   <para>"Enter lower limit!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lower limit check in all instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#LowerLimitAll">http://semwebquality.org/ontologies/dq-constraints#LowerLimitAll</seealso>
    let LowerLimitAll = Prefixed_Name(dqc, "LowerLimitAll") |> PrefixedName
    /// <summary>
    ///   <para>dqc:LowerLimitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>sp:Construct</para>
    ///   <para>smf:cast</para>
    ///   <para>sp:lt</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>"This query returns all instances of class ?arg1 that have a value for property ?arg2 below the user defined limit ?arg3. The query tolerates chaotic datatype assignments."</para>
    ///   <para>"Select class that contains instances to be tested!"</para>
    ///   <para>"Select property to be tested!"</para>
    ///   <para>"Enter lower limit! {@en}"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lower limit check in all instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#LowerLimitClass">http://semwebquality.org/ontologies/dq-constraints#LowerLimitClass</seealso>
    let LowerLimitClass = Prefixed_Name(dqc, "LowerLimitClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:MissingElementConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Missing element constraints identify elements in the data set that are missing but required."</para>
    /// labels<para>"missing element constraints"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#MissingElementConstraints">http://semwebquality.org/ontologies/dq-constraints#MissingElementConstraints</seealso>
    let MissingElementConstraints =
        Prefixed_Name(dqc, "MissingElementConstraints") |> PrefixedName

    /// <summary>
    ///   <para>dqc:MissingLiterals</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Construct</para>
    ///   <para>"This query returns all instances of class ?arg1 where the literal for ?arg2 is empty. It does not return instances where the whole property ?arg2 is missing."</para>
    ///   <para>"Select class to be tested!"</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mandatory literal value check in instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#MissingLiterals">http://semwebquality.org/ontologies/dq-constraints#MissingLiterals</seealso>
    let MissingLiterals = Prefixed_Name(dqc, "MissingLiterals") |> PrefixedName

    /// <summary>
    ///   <para>dqc:MissingLiteralsAndProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Union</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:NotExists</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class that contains intances to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query returns all instances of class ?arg1 where the literal for ?arg2 is empty or the whole property ?arg2 is missing."</para>
    /// labels<para>"Mandatory literal value and property check in instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#MissingLiteralsAndProperties">http://semwebquality.org/ontologies/dq-constraints#MissingLiteralsAndProperties</seealso>
    let MissingLiteralsAndProperties =
        Prefixed_Name(dqc, "MissingLiteralsAndProperties") |> PrefixedName

    /// <summary>
    ///   <para>dqc:MissingProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:NotExists</para>
    ///   <para>"This query returns all instances of class ?arg1 where property ?arg2 is missing. It explicitly tolerates empty literal values in property ?arg2."</para>
    ///   <para>"Select property to be tested!"</para>
    ///   <para>"Select class that contains instances to be tested!"</para>
    /// labels<para>"Mandatory property check in instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#MissingProperties">http://semwebquality.org/ontologies/dq-constraints#MissingProperties</seealso>
    let MissingProperties = Prefixed_Name(dqc, "MissingProperties") |> PrefixedName
    /// <summary>
    ///   <para>dqc:NumbersAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>sp:str</para>
    ///   <para>sp:not</para>
    ///   <para>sp:regex</para>
    ///   <para>sp:Construct</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>"This query flags all instances with property ?arg1 that have characters other than numbers as literal values."</para>
    ///   <para>"Select property to be tested!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"syntax check in all instances: only numbers allowed"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#NumbersAll">http://semwebquality.org/ontologies/dq-constraints#NumbersAll</seealso>
    let NumbersAll = Prefixed_Name(dqc, "NumbersAll") |> PrefixedName
    /// <summary>
    ///   <para>dqc:SyntaxConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Syntax constraints identify values that do not adhere to syntactical rules. {@en} "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"syntax constraints"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#SyntaxConstraints">http://semwebquality.org/ontologies/dq-constraints#SyntaxConstraints</seealso>
    let SyntaxConstraints = Prefixed_Name(dqc, "SyntaxConstraints") |> PrefixedName
    /// <summary>
    ///   <para>dqc:UniqueValueAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:ne</para>
    ///   <para>sp:eq</para>
    ///   <para>sp:Construct</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:str</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:and</para>
    ///   <para>"Select property to be tested!"</para>
    ///   <para>"This query returns all instances where the value for property ?arg1 is not unique in the tested data set. The query tolerates chaotic language tag assignments."</para>
    /// labels<para>"Uniqueness check for all values in a property"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#UniqueValueAll">http://semwebquality.org/ontologies/dq-constraints#UniqueValueAll</seealso>
    let UniqueValueAll = Prefixed_Name(dqc, "UniqueValueAll") |> PrefixedName
    /// <summary>
    ///   <para>dqc:UniqueValueClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>sp:eq</para>
    ///   <para>sp:Construct</para>
    ///   <para>spl:Argument</para>
    ///   <para>sp:str</para>
    ///   <para>sp:ne</para>
    ///   <para>sp:and</para>
    ///   <para>spin:Template</para>
    ///   <para>sp:Filter</para>
    ///   <para>"Select property to be tested! {@en}"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Select class that contains instances to be tested!"</para>
    ///   <para>"This query returns all instances of class ?arg1 where the value for property ?arg2 is not unique in the tested data set. The query tolerates chaotic language tag assignments."</para>
    /// labels<para>"Uniqueness check for all values in instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#UniqueValueClass">http://semwebquality.org/ontologies/dq-constraints#UniqueValueClass</seealso>
    let UniqueValueClass = Prefixed_Name(dqc, "UniqueValueClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:UniquenessConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Uniqueness constraints identify values that shall be unique, but are redundant within a certain data set."</para>
    /// labels<para>"uniqueness constraints"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#UniquenessConstraints">http://semwebquality.org/ontologies/dq-constraints#UniquenessConstraints</seealso>
    let UniquenessConstraints =
        Prefixed_Name(dqc, "UniquenessConstraints") |> PrefixedName

    /// <summary>
    ///   <para>dqc:UpperLimitAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Argument</para>
    ///   <para>sp:Filter</para>
    ///   <para>sp:Construct</para>
    ///   <para>smf:cast</para>
    ///   <para>sp:gt</para>
    ///   <para>spin:Template</para>
    ///   <para>"Enter upper limit!"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This query returns all instances that have a value for property ?arg1 above the user defined limit ?arg2. The query tolerates chaotic datatype assignments."</para>
    ///   <para>"Select property to be tested!"</para>
    /// labels<para>"Upper limit check in all instances"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#UpperLimitAll">http://semwebquality.org/ontologies/dq-constraints#UpperLimitAll</seealso>
    let UpperLimitAll = Prefixed_Name(dqc, "UpperLimitAll") |> PrefixedName
    /// <summary>
    ///   <para>dqc:UpperLimitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spl:Argument</para>
    ///   <para>spin:Template</para>
    ///   <para>smf:cast</para>
    ///   <para>sp:Construct</para>
    ///   <para>sp:gt</para>
    ///   <para>sp:Filter</para>
    ///   <para>"Select class that contains instances to be tested!"</para>
    ///   <para>"This query returns all instances of class ?arg1 that have a value for property ?arg2 above the user defined limit ?arg3. The query tolerates chaotic datatype assignments."</para>
    ///   <para>"Select property to be tested!"</para>
    ///   <para>"Enter upper limit!"</para>
    /// labels<para>"Upper limit check in all instances of a class"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#UpperLimitClass">http://semwebquality.org/ontologies/dq-constraints#UpperLimitClass</seealso>
    let UpperLimitClass = Prefixed_Name(dqc, "UpperLimitClass") |> PrefixedName

    /// <summary>
    ///   <para>dqc:ValueRangeConstraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>spin:Template</para>
    ///   <para>"Value range constraints allow the identification of values that do not obey a certain upper and/or lower limit."</para>
    /// labels<para>"value range constraints"</para></remarks>
    /// <seealso href="http://semwebquality.org/ontologies/dq-constraints#ValueRangeConstraints">http://semwebquality.org/ontologies/dq-constraints#ValueRangeConstraints</seealso>
    let ValueRangeConstraints =
        Prefixed_Name(dqc, "ValueRangeConstraints") |> PrefixedName
