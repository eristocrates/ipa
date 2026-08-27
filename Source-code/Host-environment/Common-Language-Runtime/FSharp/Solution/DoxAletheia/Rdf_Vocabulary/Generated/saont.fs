namespace https.w3id.org.sao.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module saont =
    let _namespace_iri = Namespace_Iri saont |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:sao#AccountabilityPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan which describes a specification of the information that should be collected, so as to support accountability of systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accountability Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#AccountabilityPlan">https://w3id.org/sao#AccountabilityPlan</seealso>
    let AccountabilityPlan = Prefixed_Name(saont, "AccountabilityPlan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#AccountableAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step which is deemed to be important for accountability purposes and produces AccountableResult."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accountable Action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#AccountableAction">https://w3id.org/sao#AccountableAction</seealso>
    let AccountableAction = Prefixed_Name(saont, "AccountableAction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#AccountableAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agent (typically a human) that can be held accountable for his/her actions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An agent (typically a human)  that can be held accountable for his/her actions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accountable Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#AccountableAgent">https://w3id.org/sao#AccountableAgent</seealso>
    let AccountableAgent = Prefixed_Name(saont, "AccountableAgent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#AccountableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accountable object models an abstract representation of a thing that should be documented for accountability. This may reference the whole system, its logical part, or associated process.  For example, a larger system may be described as a group of sub-systems or a single system may be broken down into a number of layers/components (e.g., a decision logic layer)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accountable Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#AccountableObject">https://w3id.org/sao#AccountableObject</seealso>
    let AccountableObject = Prefixed_Name(saont, "AccountableObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#AccountableResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An output variable which is produced by an Accountable Action, for example,  a decision made by a human or a specification produced by a team. The variable is part of the accountability plan and has a corresponding InformationRealization collection in the execution trace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accountable Result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#AccountableResult">https://w3id.org/sao#AccountableResult</seealso>
    let AccountableResult = Prefixed_Name(saont, "AccountableResult") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#InformationElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A member of the collection of type Information Realization. Information Realizations may have multiple Information Elements.  Information Element describes in more detail a specific type of information contained by the Information Realization collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#InformationElement">https://w3id.org/sao#InformationElement</seealso>
    let InformationElement = Prefixed_Name(saont, "InformationElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#InformationRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of pieces of information (InformationElements) which corresponds to a variable of type  AccountableResult. The collection represents the actual piece of provenance information documenting a specific AccountableResult during a single plan execution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information Realization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#InformationRealization">https://w3id.org/sao#InformationRealization</seealso>
    let InformationRealization =
        Prefixed_Name(saont, "InformationRealization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A system that the collected accountability information is about."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#System">https://w3id.org/sao#System</seealso>
    let System = Prefixed_Name(saont, "System") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#hasAccountableAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of is accountable for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has accountable agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#hasAccountableAgent">https://w3id.org/sao#hasAccountableAgent</seealso>
    let hasAccountableAgent =
        Prefixed_Name(saont, "hasAccountableAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#hasRelatedAccountableResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has related accountable result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#hasRelatedAccountableResult">https://w3id.org/sao#hasRelatedAccountableResult</seealso>
    let hasRelatedAccountableResult =
        Prefixed_Name(saont, "hasRelatedAccountableResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#hasSpecifiedAccountabiltyPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of specified for system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has specified accountability plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#hasSpecifiedAccountabiltyPlan">https://w3id.org/sao#hasSpecifiedAccountabiltyPlan</seealso>
    let hasSpecifiedAccountabiltyPlan =
        Prefixed_Name(saont, "hasSpecifiedAccountabiltyPlan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#impacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation which describes that an accountable object have some effect on the system's accountability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"impacts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#impacts">https://w3id.org/sao#impacts</seealso>
    let impacts = Prefixed_Name(saont, "impacts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#isAccountableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that links accountable agents to entities they are accountable for."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is accountable for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#isAccountableFor">https://w3id.org/sao#isAccountableFor</seealso>
    let isAccountableFor = Prefixed_Name(saont, "isAccountableFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sao#isImpactedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of impacts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is impacted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#isImpactedBy">https://w3id.org/sao#isImpactedBy</seealso>
    let isImpactedBy = Prefixed_Name(saont, "isImpactedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#relatesToAccountableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation which describes the information described by an accountable result relates to an accountable object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relates to accountable object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#relatesToAccountableObject">https://w3id.org/sao#relatesToAccountableObject</seealso>
    let relatesToAccountableObject =
        Prefixed_Name(saont, "relatesToAccountableObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao#specifiedForSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that links the accountability plan to the system it was specified for."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"specified for system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao#specifiedForSystem">https://w3id.org/sao#specifiedForSystem</seealso>
    let specifiedForSystem = Prefixed_Name(saont, "specifiedForSystem") |> PrefixedName
