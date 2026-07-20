namespace http.www.daml.org.services.owl_s._1._2.generic.Expression.owl.hash

open DoxAletheia

module owls_Expression =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    ///     We add the 0 cardinality specs simply to ensure that no system can
    ///     define those properties for this instance.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#AlwaysTrue"></see></summary>
    let AlwaysTrue = _prefix "AlwaysTrue"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Condition"></see>
    /// </summary>
    let Condition = _prefix "Condition"
    /// <summary>
    ///
    ///     This property is used to refer to an "unquoted" expression body.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionObject"></see></summary>
    let expressionObject = _prefix "expressionObject"
    /// <summary>
    ///
    ///     This property is used to refer to an "quoted" (literal) expression body.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionData"></see></summary>
    let expressionData = _prefix "expressionData"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Expression"></see>
    /// </summary>
    let Expression = _prefix "Expression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS"></see>
    /// </summary>
    let DRS = _prefix "DRS"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#refURI"></see>
    /// </summary>
    let refURI = _prefix "refURI"
    /// <summary>
    ///
    ///     An instance of this class represents a particular logical formalism,
    ///     such as KIF, SWRL, or DRS.  At present we allow for zero or more
    ///     URIs to be specified, which normally are references to public document(s)
    ///     that define the formalism.  We anticipate a variety of other properties
    ///     will be added as the requirements become better understood.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#LogicLanguage"></see></summary>
    let LogicLanguage = _prefix "LogicLanguage"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Condition"></see>
    /// </summary>
    let ``DRS-Condition`` = _prefix "DRS-Condition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Expression"></see>
    /// </summary>
    let ``DRS-Expression`` = _prefix "DRS-Expression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#UnquotedExpression"></see>
    /// </summary>
    let UnquotedExpression = _prefix "UnquotedExpression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionLanguage"></see>
    /// </summary>
    let expressionLanguage = _prefix "expressionLanguage"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF"></see>
    /// </summary>
    let KIF = _prefix "KIF"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Condition"></see>
    /// </summary>
    let ``KIF-Condition`` = _prefix "KIF-Condition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Expression"></see>
    /// </summary>
    let ``KIF-Expression`` = _prefix "KIF-Expression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#QuotedExpression"></see>
    /// </summary>
    let QuotedExpression = _prefix "QuotedExpression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL"></see>
    /// </summary>
    let RDQL = _prefix "RDQL"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Condition"></see>
    /// </summary>
    let ``RDQL-Condition`` = _prefix "RDQL-Condition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Expression"></see>
    /// </summary>
    let ``RDQL-Expression`` = _prefix "RDQL-Expression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL"></see>
    /// </summary>
    let SPARQL = _prefix "SPARQL"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Condition"></see>
    /// </summary>
    let ``SPARQL-Condition`` = _prefix "SPARQL-Condition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Expression"></see>
    /// </summary>
    let ``SPARQL-Expression`` = _prefix "SPARQL-Expression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL"></see>
    /// </summary>
    let SWRL = _prefix "SWRL"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Condition"></see>
    /// </summary>
    let ``SWRL-Condition`` = _prefix "SWRL-Condition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Expression"></see>
    /// </summary>
    let ``SWRL-Expression`` = _prefix "SWRL-Expression"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL"></see>
    /// </summary>
    let ``SWRL-FOL`` = _prefix "SWRL-FOL"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Condition"></see>
    /// </summary>
    let ``SWRL-FOL-Condition`` = _prefix "SWRL-FOL-Condition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Expression"></see>
    /// </summary>
    let ``SWRL-FOL-Expression`` = _prefix "SWRL-FOL-Expression"
    /// <summary>
    ///
    ///     This class is used to define a correspondence between a variable
    ///     mentioned in an quoted expression and an OWL instance.  This is
    ///     useful with expression languages in which the variables
    ///     can't be identified using URIs.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#VariableBinding"></see></summary>
    let VariableBinding = _prefix "VariableBinding"
    /// <summary>
    ///
    ///     The value of this property is a substring of a QuotedExpression.
    ///     The substring represents a variable in the language of the
    ///     QuotedExpression.  For example, if the QuotedExpression is in KIF,
    ///     the substring would be something like "?a".
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theVariable"></see></summary>
    let theVariable = _prefix "theVariable"
    /// <summary>
    ///
    ///     The range is not defined, and so the value of this property can
    ///     be any OWL instance.
    ///     When used to bind an OWL-S process precondition variable, however,
    ///     the value of this property must be an instance of process:Parameter.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theObject"></see></summary>
    let theObject = _prefix "theObject"
    /// <summary>
    /// same as expressionData; for backwards compatibility
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionBody"></see></summary>
    let expressionBody = _prefix "expressionBody"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#variableBinding"></see>
    /// </summary>
    let variableBinding = _prefix "variableBinding"
