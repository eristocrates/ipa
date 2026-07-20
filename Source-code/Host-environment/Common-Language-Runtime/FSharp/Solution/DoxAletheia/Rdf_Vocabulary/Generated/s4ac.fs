namespace http.ns.inria.fr.s4ac.v2.hash

open DoxAletheia

module s4ac =
    let _namespace_name = "http://ns.inria.fr/s4ac/v2#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The Access Condition (AC) allows the users to access specific resources. An AC is a SPARQL 1.1 ASK query. If a solution exists, the ASK query returns true, and the AC is said to be verified. If no solution exists, the ASK query returns false, and the AC is said not to be verified.
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessCondition"></see></summary>
    let AccessCondition = _prefix "AccessCondition"
    /// <summary>
    /// An Access Condition Set (ACS) represents a set of Access Conditions which can be either Conjunctive or Disjunctive.
    ///
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessConditionSet"></see></summary>
    let AccessConditionSet = _prefix "AccessConditionSet"
    /// <summary>
    /// An Access Evaluation Context (AEC) is a list L of predetermined bound variables names of the form (var1, val1) for which a SPARQL 1.1 Binding Clause constrains the ASK query evaluation (i.e., the evaluation of the Access Conditions) when verifying the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessEvaluationContext"></see></summary>
    let AccessEvaluationContext = _prefix "AccessEvaluationContext"
    /// <summary>
    /// An Access Policy (AP) is a composed by an Access Condition Set, a Subject, an Access Evaluation Context, an Access Privilege, and a URI of the resource to which it is applied.
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessPolicy"></see></summary>
    let AccessPolicy = _prefix "AccessPolicy"
    /// <summary>
    /// This class represents the kind of access privileges which is granted to the user (Create, Read, Update, Delete).
    /// <see href="http://ns.inria.fr/s4ac/v2#AccessPrivilege"></see></summary>
    let AccessPrivilege = _prefix "AccessPrivilege"
    /// <summary>
    /// A Conjunctive ACS (CACS) is a logical conjunction of Access Conditions, and it is said to be verified if and only if every Access Condition it contains is verified.
    ///
    /// <see href="http://ns.inria.fr/s4ac/v2#ConjunctiveAccessConditionSet"></see></summary>
    let ConjunctiveAccessConditionSet = _prefix "ConjunctiveAccessConditionSet"
    /// <summary>
    /// A Disjunctive ACS (DACS) is a logical disjunction of Access Conditions, and it is said to be verified if and only if at least one Access Condition it contains is verified.
    ///
    /// <see href="http://ns.inria.fr/s4ac/v2#DisjunctiveAccessConditionSet"></see></summary>
    let DisjunctiveAccessConditionSet = _prefix "DisjunctiveAccessConditionSet"
    /// <summary>
    /// This class represents a create access on the resource. This class is equivalent to acl:Append.
    /// <see href="http://ns.inria.fr/s4ac/v2#Create"></see></summary>
    let Create = _prefix "Create"
    /// <summary>
    /// This class represents a delete access on the resource.
    /// <see href="http://ns.inria.fr/s4ac/v2#Delete"></see></summary>
    let Delete = _prefix "Delete"
    /// <summary>
    /// This class represents a read access on the resource. This class is equivalent to acl:Read.
    /// <see href="http://ns.inria.fr/s4ac/v2#Read"></see></summary>
    let Read = _prefix "Read"
    /// <summary>
    /// This class represents an update access on the resource.
    /// <see href="http://ns.inria.fr/s4ac/v2#Update"></see></summary>
    let Update = _prefix "Update"
    /// <summary>
    /// This class is used to describe the value assigned to the variables used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    /// This class is used to describe the variables used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// This property associates the Access Policy to the URI of the resource to which the policy is applied.
    /// <see href="http://ns.inria.fr/s4ac/v2#appliesTo"></see></summary>
    let appliesTo = _prefix "appliesTo"
    /// <summary>
    /// This property adds an Access Condition to an Access Condition Set.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessCondition"></see></summary>
    let hasAccessCondition = _prefix "hasAccessCondition"
    /// <summary>
    /// This property says that an Access Condition is part of an Access Condition Set.
    /// <see href="http://ns.inria.fr/s4ac/v2#isAccessConditionOf"></see></summary>
    let isAccessConditionOf = _prefix "isAccessConditionOf"
    /// <summary>
    /// This property defines whether the Access Condition Set (ACS) of an Access Policy is a Conjunctive ACS, or a Disjunctive ACS.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessConditionSet"></see></summary>
    let hasAccessConditionSet = _prefix "hasAccessConditionSet"
    /// <summary>
    /// This property associates an Access Policy with an Access Evaluation Context.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessEvaluationContext"></see></summary>
    let hasAccessEvaluationContext = _prefix "hasAccessEvaluationContext"
    /// <summary>
    /// This property associates the Access Privileges to the Access Policies.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasAccessPrivilege"></see></summary>
    let hasAccessPrivilege = _prefix "hasAccessPrivilege"
    /// <summary>
    /// This property associates a description of the variable used in the Access Condition Set to explain their use in the definition of the policies.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasDescription"></see></summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// This property assigns a name to an Access Condition.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// This property defines the SPARQL 1.1 ASK queries which represent the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasQueryAsk"></see></summary>
    let hasQueryAsk = _prefix "hasQueryAsk"
    /// <summary>
    /// This property associates a value to the variable used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// This property associates a name to the variable used in the Access Conditions.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasVarName"></see></summary>
    let hasVarName = _prefix "hasVarName"
    /// <summary>
    /// The property associates the variables and the Access Condition Set where they are used.
    /// <see href="http://ns.inria.fr/s4ac/v2#hasVariable"></see></summary>
    let hasVariable = _prefix "hasVariable"
