namespace http.www.daml.org.services.owl_s._1._2.generic.Expression.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_Expression =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#"

    /// <summary>
    ///
    ///     We add the 0 cardinality specs simply to ensure that no system can
    ///     define those properties for this instance.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#AlwaysTrue"></see></summary>
    let AlwaysTrue = Namespaced_IRI.parse _namespace_name "AlwaysTrue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Condition"></see>
    /// </summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName

    /// <summary>
    ///
    ///     This property is used to refer to an "unquoted" expression body.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionObject"></see></summary>
    let expressionObject =
        Namespaced_IRI.parse _namespace_name "expressionObject" |> NamespacedName

    /// <summary>
    ///
    ///     This property is used to refer to an "quoted" (literal) expression body.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionData"></see></summary>
    let expressionData =
        Namespaced_IRI.parse _namespace_name "expressionData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Expression"></see>
    /// </summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS"></see>
    /// </summary>
    let DRS = Namespaced_IRI.parse _namespace_name "DRS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#refURI"></see>
    /// </summary>
    let refURI = Namespaced_IRI.parse _namespace_name "refURI" |> NamespacedName

    /// <summary>
    ///
    ///     An instance of this class represents a particular logical formalism,
    ///     such as KIF, SWRL, or DRS.  At present we allow for zero or more
    ///     URIs to be specified, which normally are references to public document(s)
    ///     that define the formalism.  We anticipate a variety of other properties
    ///     will be added as the requirements become better understood.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#LogicLanguage"></see></summary>
    let LogicLanguage =
        Namespaced_IRI.parse _namespace_name "LogicLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Condition"></see>
    /// </summary>
    let ``DRS-Condition`` =
        Namespaced_IRI.parse _namespace_name "DRS-Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Expression"></see>
    /// </summary>
    let ``DRS-Expression`` =
        Namespaced_IRI.parse _namespace_name "DRS-Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#UnquotedExpression"></see>
    /// </summary>
    let UnquotedExpression =
        Namespaced_IRI.parse _namespace_name "UnquotedExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionLanguage"></see>
    /// </summary>
    let expressionLanguage =
        Namespaced_IRI.parse _namespace_name "expressionLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF"></see>
    /// </summary>
    let KIF = Namespaced_IRI.parse _namespace_name "KIF" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Condition"></see>
    /// </summary>
    let ``KIF-Condition`` =
        Namespaced_IRI.parse _namespace_name "KIF-Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Expression"></see>
    /// </summary>
    let ``KIF-Expression`` =
        Namespaced_IRI.parse _namespace_name "KIF-Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#QuotedExpression"></see>
    /// </summary>
    let QuotedExpression =
        Namespaced_IRI.parse _namespace_name "QuotedExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL"></see>
    /// </summary>
    let RDQL = Namespaced_IRI.parse _namespace_name "RDQL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Condition"></see>
    /// </summary>
    let ``RDQL-Condition`` =
        Namespaced_IRI.parse _namespace_name "RDQL-Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Expression"></see>
    /// </summary>
    let ``RDQL-Expression`` =
        Namespaced_IRI.parse _namespace_name "RDQL-Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL"></see>
    /// </summary>
    let SPARQL = Namespaced_IRI.parse _namespace_name "SPARQL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Condition"></see>
    /// </summary>
    let ``SPARQL-Condition`` =
        Namespaced_IRI.parse _namespace_name "SPARQL-Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Expression"></see>
    /// </summary>
    let ``SPARQL-Expression`` =
        Namespaced_IRI.parse _namespace_name "SPARQL-Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL"></see>
    /// </summary>
    let SWRL = Namespaced_IRI.parse _namespace_name "SWRL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Condition"></see>
    /// </summary>
    let ``SWRL-Condition`` =
        Namespaced_IRI.parse _namespace_name "SWRL-Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Expression"></see>
    /// </summary>
    let ``SWRL-Expression`` =
        Namespaced_IRI.parse _namespace_name "SWRL-Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL"></see>
    /// </summary>
    let ``SWRL-FOL`` = Namespaced_IRI.parse _namespace_name "SWRL-FOL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Condition"></see>
    /// </summary>
    let ``SWRL-FOL-Condition`` =
        Namespaced_IRI.parse _namespace_name "SWRL-FOL-Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Expression"></see>
    /// </summary>
    let ``SWRL-FOL-Expression`` =
        Namespaced_IRI.parse _namespace_name "SWRL-FOL-Expression" |> NamespacedName

    /// <summary>
    ///
    ///     This class is used to define a correspondence between a variable
    ///     mentioned in an quoted expression and an OWL instance.  This is
    ///     useful with expression languages in which the variables
    ///     can't be identified using URIs.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#VariableBinding"></see></summary>
    let VariableBinding =
        Namespaced_IRI.parse _namespace_name "VariableBinding" |> NamespacedName

    /// <summary>
    ///
    ///     The value of this property is a substring of a QuotedExpression.
    ///     The substring represents a variable in the language of the
    ///     QuotedExpression.  For example, if the QuotedExpression is in KIF,
    ///     the substring would be something like "?a".
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theVariable"></see></summary>
    let theVariable =
        Namespaced_IRI.parse _namespace_name "theVariable" |> NamespacedName

    /// <summary>
    ///
    ///     The range is not defined, and so the value of this property can
    ///     be any OWL instance.
    ///     When used to bind an OWL-S process precondition variable, however,
    ///     the value of this property must be an instance of process:Parameter.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theObject"></see></summary>
    let theObject = Namespaced_IRI.parse _namespace_name "theObject" |> NamespacedName

    /// <summary>
    /// same as expressionData; for backwards compatibility
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionBody"></see></summary>
    let expressionBody =
        Namespaced_IRI.parse _namespace_name "expressionBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#variableBinding"></see>
    /// </summary>
    let variableBinding =
        Namespaced_IRI.parse _namespace_name "variableBinding" |> NamespacedName
