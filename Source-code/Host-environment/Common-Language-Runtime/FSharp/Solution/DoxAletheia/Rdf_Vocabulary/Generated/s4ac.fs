namespace http.ns.inria.fr.s4ac.v2.hash

open DoxAletheia.Rdf_Vocabulary

module s4ac =
    let _namespace_name = "http://ns.inria.fr/s4ac/v2#"

    /// <summary>
    /// The Access Condition (AC) allows the users to access specific resources. An AC is a SPARQL 1.1 ASK query. If a solution exists, the ASK query returns true, and the AC is said to be verified. If no solution exists, the ASK query returns false, and the AC is said not to be verified.
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessCondition"></see></summary>
    let AccessCondition =
        Namespaced_IRI.parse _namespace_name "AccessCondition" |> NamespacedName

    /// <summary>
    /// An Access Condition Set (ACS) represents a set of Access Conditions which can be either Conjunctive or Disjunctive.
    ///
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessConditionSet"></see></summary>
    let AccessConditionSet =
        Namespaced_IRI.parse _namespace_name "AccessConditionSet" |> NamespacedName

    /// <summary>
    /// An Access Evaluation Context (AEC) is a list L of predetermined bound variables names of the form (var1, val1) for which a SPARQL 1.1 Binding Clause constrains the ASK query evaluation (i.e., the evaluation of the Access Conditions) when verifying the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessEvaluationContext"></see></summary>
    let AccessEvaluationContext =
        Namespaced_IRI.parse _namespace_name "AccessEvaluationContext" |> NamespacedName

    /// <summary>
    /// An Access Policy (AP) is a composed by an Access Condition Set, a Subject, an Access Evaluation Context, an Access Privilege, and a URI of the resource to which it is applied.
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessPolicy"></see></summary>
    let AccessPolicy =
        Namespaced_IRI.parse _namespace_name "AccessPolicy" |> NamespacedName

    /// <summary>
    /// This class represents the kind of access privileges which is granted to the user (Create, Read, Update, Delete).
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessPrivilege"></see></summary>
    let AccessPrivilege =
        Namespaced_IRI.parse _namespace_name "AccessPrivilege" |> NamespacedName

    /// <summary>
    /// A Conjunctive ACS (CACS) is a logical conjunction of Access Conditions, and it is said to be verified if and only if every Access Condition it contains is verified.
    ///
    /// <see href="http://ns.inria.fr/s4ac/v2#ConjunctiveAccessConditionSet"></see></summary>
    let ConjunctiveAccessConditionSet =
        Namespaced_IRI.parse _namespace_name "ConjunctiveAccessConditionSet" |> NamespacedName

    /// <summary>
    /// A Disjunctive ACS (DACS) is a logical disjunction of Access Conditions, and it is said to be verified if and only if at least one Access Condition it contains is verified.
    ///
    /// <see href="http://ns.inria.fr/s4ac/v2#DisjunctiveAccessConditionSet"></see></summary>
    let DisjunctiveAccessConditionSet =
        Namespaced_IRI.parse _namespace_name "DisjunctiveAccessConditionSet" |> NamespacedName

    /// <summary>
    /// This class represents a create access on the resource. This class is equivalent to acl:Append.
    /// <see href="http://ns.inria.fr/s4ac/v2#Create"></see></summary>
    let Create = Namespaced_IRI.parse _namespace_name "Create" |> NamespacedName
    /// <summary>
    /// This class represents a delete access on the resource.
    /// <see href="http://ns.inria.fr/s4ac/v2#Delete"></see></summary>
    let Delete = Namespaced_IRI.parse _namespace_name "Delete" |> NamespacedName
    /// <summary>
    /// This class represents a read access on the resource. This class is equivalent to acl:Read.
    /// <see href="http://ns.inria.fr/s4ac/v2#Read"></see></summary>
    let Read = Namespaced_IRI.parse _namespace_name "Read" |> NamespacedName
    /// <summary>
    /// This class represents an update access on the resource.
    /// <see href="http://ns.inria.fr/s4ac/v2#Update"></see></summary>
    let Update = Namespaced_IRI.parse _namespace_name "Update" |> NamespacedName
    /// <summary>
    /// This class is used to describe the value assigned to the variables used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName
    /// <summary>
    /// This class is used to describe the variables used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName
    /// <summary>
    /// This property associates the Access Policy to the URI of the resource to which the policy is applied.
    /// <see href="http://ns.inria.fr/s4ac/v2#appliesTo"></see></summary>
    let appliesTo = Namespaced_IRI.parse _namespace_name "appliesTo" |> NamespacedName

    /// <summary>
    /// This property adds an Access Condition to an Access Condition Set.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessCondition"></see></summary>
    let hasAccessCondition =
        Namespaced_IRI.parse _namespace_name "hasAccessCondition" |> NamespacedName

    /// <summary>
    /// This property says that an Access Condition is part of an Access Condition Set.
    /// <see href="http://ns.inria.fr/s4ac/v2#isAccessConditionOf"></see></summary>
    let isAccessConditionOf =
        Namespaced_IRI.parse _namespace_name "isAccessConditionOf" |> NamespacedName

    /// <summary>
    /// This property defines whether the Access Condition Set (ACS) of an Access Policy is a Conjunctive ACS, or a Disjunctive ACS.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessConditionSet"></see></summary>
    let hasAccessConditionSet =
        Namespaced_IRI.parse _namespace_name "hasAccessConditionSet" |> NamespacedName

    /// <summary>
    /// This property associates an Access Policy with an Access Evaluation Context.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessEvaluationContext"></see></summary>
    let hasAccessEvaluationContext =
        Namespaced_IRI.parse _namespace_name "hasAccessEvaluationContext" |> NamespacedName

    /// <summary>
    /// This property associates the Access Privileges to the Access Policies.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessPrivilege"></see></summary>
    let hasAccessPrivilege =
        Namespaced_IRI.parse _namespace_name "hasAccessPrivilege" |> NamespacedName

    /// <summary>
    /// This property associates a description of the variable used in the Access Condition Set to explain their use in the definition of the policies.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// This property assigns a name to an Access Condition.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// This property defines the SPARQL 1.1 ASK queries which represent the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasQueryAsk"></see></summary>
    let hasQueryAsk =
        Namespaced_IRI.parse _namespace_name "hasQueryAsk" |> NamespacedName

    /// <summary>
    /// This property associates a value to the variable used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// This property associates a name to the variable used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasVarName"></see></summary>
    let hasVarName = Namespaced_IRI.parse _namespace_name "hasVarName" |> NamespacedName

    /// <summary>
    /// The property associates the variables and the Access Condition Set where they are used.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasVariable"></see></summary>
    let hasVariable =
        Namespaced_IRI.parse _namespace_name "hasVariable" |> NamespacedName
