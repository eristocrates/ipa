#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4ac =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.inria.fr/s4ac/v2#" "s4ac"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : AccessCondition</para>
    ///   <para>rdfs:comment : The Access Condition (AC) allows the users to access specific resources. An AC is a SPARQL 1.1 ASK query. If a solution exists, the ASK query returns true, and the AC is said to be verified. If no solution exists, the ASK query returns false, and the AC is said not to be verified.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#AccessCondition">s4ac:AccessCondition</a>
    /// </summary>
    let AccessCondition = _prefixId.prefix "AccessCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : AccessConditionSet</para>
    ///   <para>rdfs:comment : An Access Condition Set (ACS) represents a set of Access Conditions which can be either Conjunctive or Disjunctive.
    /// 		</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#AccessConditionSet">s4ac:AccessConditionSet</a>
    /// </summary>
    let AccessConditionSet = _prefixId.prefix "AccessConditionSet"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : AccessEvaluationContext</para>
    ///   <para>rdfs:comment : An Access Evaluation Context (AEC) is a list L of predetermined bound variables names of the form (var1, val1) for which a SPARQL 1.1 Binding Clause constrains the ASK query evaluation (i.e., the evaluation of the Access Conditions) when verifying the Access Conditions.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#AccessEvaluationContext">s4ac:AccessEvaluationContext</a>
    /// </summary>
    let AccessEvaluationContext = _prefixId.prefix "AccessEvaluationContext"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : AccessPolicy</para>
    ///   <para>rdfs:comment : An Access Policy (AP) is a composed by an Access Condition Set, a Subject, an Access Evaluation Context, an Access Privilege, and a URI of the resource to which it is applied. </para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#AccessPolicy">s4ac:AccessPolicy</a>
    /// </summary>
    let AccessPolicy = _prefixId.prefix "AccessPolicy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : AccessPrivilege</para>
    ///   <para>rdfs:comment : This class represents the kind of access privileges which is granted to the user (Create, Read, Update, Delete).</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#AccessPrivilege">s4ac:AccessPrivilege</a>
    /// </summary>
    let AccessPrivilege = _prefixId.prefix "AccessPrivilege"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ConjontiveAccessConditionSet</para>
    ///   <para>rdfs:comment : A Conjunctive ACS (CACS) is a logical conjunction of Access Conditions, and it is said to be verified if and only if every Access Condition it contains is verified.
    /// 		</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#ConjunctiveAccessConditionSet">s4ac:ConjunctiveAccessConditionSet</a>
    /// </summary>
    let ConjunctiveAccessConditionSet = _prefixId.prefix "ConjunctiveAccessConditionSet"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a create access on the resource. This class is equivalent to acl:Append.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Create</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#Create">s4ac:Create</a>
    /// </summary>
    let Create = _prefixId.prefix "Create"
    /// <summary>
    ///   <para>rdfs:label : Delete</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a delete access on the resource.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#Delete">s4ac:Delete</a>
    /// </summary>
    let Delete = _prefixId.prefix "Delete"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DisjontiveAccessConditionSet</para>
    ///   <para>rdfs:comment : A Disjunctive ACS (DACS) is a logical disjunction of Access Conditions, and it is said to be verified if and only if at least one Access Condition it contains is verified.
    /// 		</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#DisjunctiveAccessConditionSet">s4ac:DisjunctiveAccessConditionSet</a>
    /// </summary>
    let DisjunctiveAccessConditionSet = _prefixId.prefix "DisjunctiveAccessConditionSet"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a read access on the resource. This class is equivalent to acl:Read.</para>
    ///   <para>rdfs:label : Read</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#Read">s4ac:Read</a>
    /// </summary>
    let Read = _prefixId.prefix "Read"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Update</para>
    ///   <para>rdfs:comment : This class represents an update access on the resource.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#Update">s4ac:Update</a>
    /// </summary>
    let Update = _prefixId.prefix "Update"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Value</para>
    ///   <para>rdfs:comment : This class is used to describe the value assigned to the variables used in the Access Conditions.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#Value">s4ac:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Variable</para>
    ///   <para>rdfs:comment : This class is used to describe the variables used in the Access Conditions.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#Variable">s4ac:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : appliesTo</para>
    ///   <para>rdfs:comment : This property associates the Access Policy to the URI of the resource to which the policy is applied.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#appliesTo">s4ac:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAccessCondition</para>
    ///   <para>rdfs:comment : This property adds an Access Condition to an Access Condition Set.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasAccessCondition">s4ac:hasAccessCondition</a>
    /// </summary>
    let hasAccessCondition = _prefixId.prefix "hasAccessCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAccessConditionSet</para>
    ///   <para>rdfs:comment : This property defines whether the Access Condition Set (ACS) of an Access Policy is a Conjunctive ACS, or a Disjunctive ACS.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasAccessConditionSet">s4ac:hasAccessConditionSet</a>
    /// </summary>
    let hasAccessConditionSet = _prefixId.prefix "hasAccessConditionSet"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAccessEvaluationContext</para>
    ///   <para>rdfs:comment : This property associates an Access Policy with an Access Evaluation Context.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasAccessEvaluationContext">s4ac:hasAccessEvaluationContext</a>
    /// </summary>
    let hasAccessEvaluationContext = _prefixId.prefix "hasAccessEvaluationContext"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAccessPrivilege</para>
    ///   <para>rdfs:comment : This property associates the Access Privileges to the Access Policies.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasAccessPrivilege">s4ac:hasAccessPrivilege</a>
    /// </summary>
    let hasAccessPrivilege = _prefixId.prefix "hasAccessPrivilege"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDescription</para>
    ///   <para>rdfs:comment : This property associates a description of the variable used in the Access Condition Set to explain their use in the definition of the policies. </para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasDescription">s4ac:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasName</para>
    ///   <para>rdfs:comment : This property assigns a name to an Access Condition.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasName">s4ac:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasQueryAsk</para>
    ///   <para>rdfs:comment : This property defines the SPARQL 1.1 ASK queries which represent the Access Conditions.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasQueryAsk">s4ac:hasQueryAsk</a>
    /// </summary>
    let hasQueryAsk = _prefixId.prefix "hasQueryAsk"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasValue</para>
    ///   <para>rdfs:comment : This property associates a value to the variable used in the Access Conditions.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasValue">s4ac:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVarName</para>
    ///   <para>rdfs:comment : This property associates a name to the variable used in the Access Conditions.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasVarName">s4ac:hasVarName</a>
    /// </summary>
    let hasVarName = _prefixId.prefix "hasVarName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVariable</para>
    ///   <para>rdfs:comment : The property associates the variables and the Access Condition Set where they are used.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#hasVariable">s4ac:hasVariable</a>
    /// </summary>
    let hasVariable = _prefixId.prefix "hasVariable"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isAccessConditionOf</para>
    ///   <para>rdfs:comment : This property says that an Access Condition is part of an Access Condition Set.</para>
    ///   <a href="http://ns.inria.fr/s4ac/v2#isAccessConditionOf">s4ac:isAccessConditionOf</a>
    /// </summary>
    let isAccessConditionOf = _prefixId.prefix "isAccessConditionOf"
