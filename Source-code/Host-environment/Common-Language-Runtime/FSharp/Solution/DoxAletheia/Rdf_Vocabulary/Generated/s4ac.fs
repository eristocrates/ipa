namespace http.ns.inria.fr.s4ac.v2.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4ac =
    let _namespace_iri = Namespace_Iri s4ac |> NamespaceIRI
    /// <summary>
    ///   <para>s4ac:AccessPrivilege</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the kind of access privileges which is granted to the user (Create, Read, Update, Delete).</para>
    /// labels<para>AccessPrivilege</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#AccessPrivilege">http://ns.inria.fr/s4ac/v2#AccessPrivilege</seealso>
    let AccessPrivilege = Prefixed_Name(s4ac, "AccessPrivilege") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:Create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a create access on the resource. This class is equivalent to acl:Append.</para>
    /// labels<para>Create</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#Create">http://ns.inria.fr/s4ac/v2#Create</seealso>
    let Create = Prefixed_Name(s4ac, "Create") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:Read</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a read access on the resource. This class is equivalent to acl:Read.</para>
    /// labels<para>Read</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#Read">http://ns.inria.fr/s4ac/v2#Read</seealso>
    let Read = Prefixed_Name(s4ac, "Read") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to describe the value assigned to the variables used in the Access Conditions.</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#Value">http://ns.inria.fr/s4ac/v2#Value</seealso>
    let Value = Prefixed_Name(s4ac, "Value") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:isAccessConditionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property says that an Access Condition is part of an Access Condition Set.</para>
    /// labels<para>isAccessConditionOf</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#isAccessConditionOf">http://ns.inria.fr/s4ac/v2#isAccessConditionOf</seealso>
    let isAccessConditionOf = Prefixed_Name(s4ac, "isAccessConditionOf") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:hasAccessConditionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property defines whether the Access Condition Set (ACS) of an Access Policy is a Conjunctive ACS, or a Disjunctive ACS.</para>
    /// labels<para>hasAccessConditionSet</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasAccessConditionSet">http://ns.inria.fr/s4ac/v2#hasAccessConditionSet</seealso>
    let hasAccessConditionSet =
        Prefixed_Name(s4ac, "hasAccessConditionSet") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#">http://ns.inria.fr/s4ac/v2#</seealso>
    let _prefix_iri = Prefixed_Name(s4ac, "") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:AccessConditionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Access Condition Set (ACS) represents a set of Access Conditions which can be either Conjunctive or Disjunctive.
    /// 		</para>
    /// labels<para>AccessConditionSet</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#AccessConditionSet">http://ns.inria.fr/s4ac/v2#AccessConditionSet</seealso>
    let AccessConditionSet = Prefixed_Name(s4ac, "AccessConditionSet") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:AccessPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Access Policy (AP) is a composed by an Access Condition Set, a Subject, an Access Evaluation Context, an Access Privilege, and a URI of the resource to which it is applied. </para>
    /// labels<para>AccessPolicy</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#AccessPolicy">http://ns.inria.fr/s4ac/v2#AccessPolicy</seealso>
    let AccessPolicy = Prefixed_Name(s4ac, "AccessPolicy") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:ConjunctiveAccessConditionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Conjunctive ACS (CACS) is a logical conjunction of Access Conditions, and it is said to be verified if and only if every Access Condition it contains is verified.
    /// 		</para>
    /// labels<para>ConjontiveAccessConditionSet</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#ConjunctiveAccessConditionSet">http://ns.inria.fr/s4ac/v2#ConjunctiveAccessConditionSet</seealso>
    let ConjunctiveAccessConditionSet =
        Prefixed_Name(s4ac, "ConjunctiveAccessConditionSet") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:DisjunctiveAccessConditionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Disjunctive ACS (DACS) is a logical disjunction of Access Conditions, and it is said to be verified if and only if at least one Access Condition it contains is verified.
    /// 		</para>
    /// labels<para>DisjontiveAccessConditionSet</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#DisjunctiveAccessConditionSet">http://ns.inria.fr/s4ac/v2#DisjunctiveAccessConditionSet</seealso>
    let DisjunctiveAccessConditionSet =
        Prefixed_Name(s4ac, "DisjunctiveAccessConditionSet") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:Delete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a delete access on the resource.</para>
    /// labels<para>Delete</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#Delete">http://ns.inria.fr/s4ac/v2#Delete</seealso>
    let Delete = Prefixed_Name(s4ac, "Delete") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:Update</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an update access on the resource.</para>
    /// labels<para>Update</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#Update">http://ns.inria.fr/s4ac/v2#Update</seealso>
    let Update = Prefixed_Name(s4ac, "Update") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:appliesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates the Access Policy to the URI of the resource to which the policy is applied.</para>
    /// labels<para>appliesTo</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#appliesTo">http://ns.inria.fr/s4ac/v2#appliesTo</seealso>
    let appliesTo = Prefixed_Name(s4ac, "appliesTo") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to describe the variables used in the Access Conditions.</para>
    /// labels<para>Variable</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#Variable">http://ns.inria.fr/s4ac/v2#Variable</seealso>
    let Variable = Prefixed_Name(s4ac, "Variable") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:hasAccessEvaluationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates an Access Policy with an Access Evaluation Context.</para>
    /// labels<para>hasAccessEvaluationContext</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasAccessEvaluationContext">http://ns.inria.fr/s4ac/v2#hasAccessEvaluationContext</seealso>
    let hasAccessEvaluationContext =
        Prefixed_Name(s4ac, "hasAccessEvaluationContext") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates a description of the variable used in the Access Condition Set to explain their use in the definition of the policies. </para>
    /// labels<para>hasDescription</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasDescription">http://ns.inria.fr/s4ac/v2#hasDescription</seealso>
    let hasDescription = Prefixed_Name(s4ac, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property assigns a name to an Access Condition.</para>
    /// labels<para>hasName</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasName">http://ns.inria.fr/s4ac/v2#hasName</seealso>
    let hasName = Prefixed_Name(s4ac, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasAccessCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property adds an Access Condition to an Access Condition Set.</para>
    /// labels<para>hasAccessCondition</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasAccessCondition">http://ns.inria.fr/s4ac/v2#hasAccessCondition</seealso>
    let hasAccessCondition = Prefixed_Name(s4ac, "hasAccessCondition") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasAccessPrivilege</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates the Access Privileges to the Access Policies.</para>
    /// labels<para>hasAccessPrivilege</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasAccessPrivilege">http://ns.inria.fr/s4ac/v2#hasAccessPrivilege</seealso>
    let hasAccessPrivilege = Prefixed_Name(s4ac, "hasAccessPrivilege") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasQueryAsk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property defines the SPARQL 1.1 ASK queries which represent the Access Conditions.</para>
    /// labels<para>hasQueryAsk</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasQueryAsk">http://ns.inria.fr/s4ac/v2#hasQueryAsk</seealso>
    let hasQueryAsk = Prefixed_Name(s4ac, "hasQueryAsk") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasVarName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates a name to the variable used in the Access Conditions.</para>
    /// labels<para>hasVarName</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasVarName">http://ns.inria.fr/s4ac/v2#hasVarName</seealso>
    let hasVarName = Prefixed_Name(s4ac, "hasVarName") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates a value to the variable used in the Access Conditions.</para>
    /// labels<para>hasValue</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasValue">http://ns.inria.fr/s4ac/v2#hasValue</seealso>
    let hasValue = Prefixed_Name(s4ac, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:hasVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property associates the variables and the Access Condition Set where they are used.</para>
    /// labels<para>hasVariable</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#hasVariable">http://ns.inria.fr/s4ac/v2#hasVariable</seealso>
    let hasVariable = Prefixed_Name(s4ac, "hasVariable") |> PrefixedName
    /// <summary>
    ///   <para>s4ac:AccessCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Access Condition (AC) allows the users to access specific resources. An AC is a SPARQL 1.1 ASK query. If a solution exists, the ASK query returns true, and the AC is said to be verified. If no solution exists, the ASK query returns false, and the AC is said not to be verified.</para>
    /// labels<para>AccessCondition</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#AccessCondition">http://ns.inria.fr/s4ac/v2#AccessCondition</seealso>
    let AccessCondition = Prefixed_Name(s4ac, "AccessCondition") |> PrefixedName

    /// <summary>
    ///   <para>s4ac:AccessEvaluationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Access Evaluation Context (AEC) is a list L of predetermined bound variables names of the form (var1, val1) for which a SPARQL 1.1 Binding Clause constrains the ASK query evaluation (i.e., the evaluation of the Access Conditions) when verifying the Access Conditions.</para>
    /// labels<para>AccessEvaluationContext</para></remarks>
    /// <seealso href="http://ns.inria.fr/s4ac/v2#AccessEvaluationContext">http://ns.inria.fr/s4ac/v2#AccessEvaluationContext</seealso>
    let AccessEvaluationContext =
        Prefixed_Name(s4ac, "AccessEvaluationContext") |> PrefixedName
