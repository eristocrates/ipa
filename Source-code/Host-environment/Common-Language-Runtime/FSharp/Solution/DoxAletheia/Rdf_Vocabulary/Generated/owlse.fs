namespace http.www.daml.org.services.owl_s._1._2.generic.Expression.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlse =
    let _namespace_iri = Namespace_Iri owlse |> NamespaceIRI
    /// <summary>
    ///   <para>owlse:AlwaysTrue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:Condition</para>
    ///   <para>"
    ///     We add the 0 cardinality specs simply to ensure that no system can
    ///     define those properties for this instance.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#AlwaysTrue">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#AlwaysTrue</seealso>
    let AlwaysTrue = Prefixed_Name(owlse, "AlwaysTrue") |> PrefixedName
    /// <summary>
    ///   <para>owlse:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Condition</seealso>
    let Condition = Prefixed_Name(owlse, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>owlse:DRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:LogicLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS</seealso>
    let DRS = Prefixed_Name(owlse, "DRS") |> PrefixedName
    /// <summary>
    ///   <para>owlse:DRS-Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Condition</seealso>
    let DRS_Condition = Prefixed_Name(owlse, "DRS-Condition") |> PrefixedName
    /// <summary>
    ///   <para>owlse:DRS-Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#DRS-Expression</seealso>
    let DRS_Expression = Prefixed_Name(owlse, "DRS-Expression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#Expression</seealso>
    let Expression = Prefixed_Name(owlse, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:KIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:LogicLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF</seealso>
    let KIF = Prefixed_Name(owlse, "KIF") |> PrefixedName
    /// <summary>
    ///   <para>owlse:KIF-Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Condition</seealso>
    let KIF_Condition = Prefixed_Name(owlse, "KIF-Condition") |> PrefixedName
    /// <summary>
    ///   <para>owlse:KIF-Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#KIF-Expression</seealso>
    let KIF_Expression = Prefixed_Name(owlse, "KIF-Expression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:LogicLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     An instance of this class represents a particular logical formalism,
    ///     such as KIF, SWRL, or DRS.  At present we allow for zero or more
    ///     URIs to be specified, which normally are references to public document(s)
    ///     that define the formalism.  We anticipate a variety of other properties
    ///     will be added as the requirements become better understood.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#LogicLanguage">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#LogicLanguage</seealso>
    let LogicLanguage = Prefixed_Name(owlse, "LogicLanguage") |> PrefixedName
    /// <summary>
    ///   <para>owlse:QuotedExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#QuotedExpression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#QuotedExpression</seealso>
    let QuotedExpression = Prefixed_Name(owlse, "QuotedExpression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:RDQL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:LogicLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL</seealso>
    let RDQL = Prefixed_Name(owlse, "RDQL") |> PrefixedName
    /// <summary>
    ///   <para>owlse:RDQL-Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Condition</seealso>
    let RDQL_Condition = Prefixed_Name(owlse, "RDQL-Condition") |> PrefixedName
    /// <summary>
    ///   <para>owlse:RDQL-Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#RDQL-Expression</seealso>
    let RDQL_Expression = Prefixed_Name(owlse, "RDQL-Expression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SPARQL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:LogicLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL</seealso>
    let SPARQL = Prefixed_Name(owlse, "SPARQL") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SPARQL-Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Condition</seealso>
    let SPARQL_Condition = Prefixed_Name(owlse, "SPARQL-Condition") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SPARQL-Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SPARQL-Expression</seealso>
    let SPARQL_Expression = Prefixed_Name(owlse, "SPARQL-Expression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SWRL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:LogicLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL</seealso>
    let SWRL = Prefixed_Name(owlse, "SWRL") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SWRL-Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Condition</seealso>
    let SWRL_Condition = Prefixed_Name(owlse, "SWRL-Condition") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SWRL-Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-Expression</seealso>
    let SWRL_Expression = Prefixed_Name(owlse, "SWRL-Expression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SWRL-FOL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlse:LogicLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL</seealso>
    let SWRL_FOL = Prefixed_Name(owlse, "SWRL-FOL") |> PrefixedName
    /// <summary>
    ///   <para>owlse:SWRL-FOL-Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Condition">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Condition</seealso>
    let SWRL_FOL_Condition = Prefixed_Name(owlse, "SWRL-FOL-Condition") |> PrefixedName

    /// <summary>
    ///   <para>owlse:SWRL-FOL-Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Expression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#SWRL-FOL-Expression</seealso>
    let SWRL_FOL_Expression =
        Prefixed_Name(owlse, "SWRL-FOL-Expression") |> PrefixedName

    /// <summary>
    ///   <para>owlse:UnquotedExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#UnquotedExpression">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#UnquotedExpression</seealso>
    let UnquotedExpression = Prefixed_Name(owlse, "UnquotedExpression") |> PrefixedName
    /// <summary>
    ///   <para>owlse:VariableBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     This class is used to define a correspondence between a variable
    ///     mentioned in an quoted expression and an OWL instance.  This is
    ///     useful with expression languages in which the variables
    ///     can't be identified using URIs.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#VariableBinding">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#VariableBinding</seealso>
    let VariableBinding = Prefixed_Name(owlse, "VariableBinding") |> PrefixedName
    /// <summary>
    ///   <para>owlse:expressionBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"same as expressionData; for backwards compatibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionBody">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionBody</seealso>
    let expressionBody = Prefixed_Name(owlse, "expressionBody") |> PrefixedName
    /// <summary>
    ///   <para>owlse:expressionData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     This property is used to refer to an "quoted" (literal) expression body.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionData">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionData</seealso>
    let expressionData = Prefixed_Name(owlse, "expressionData") |> PrefixedName
    /// <summary>
    ///   <para>owlse:expressionLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionLanguage">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionLanguage</seealso>
    let expressionLanguage = Prefixed_Name(owlse, "expressionLanguage") |> PrefixedName
    /// <summary>
    ///   <para>owlse:expressionObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     This property is used to refer to an "unquoted" expression body.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionObject">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#expressionObject</seealso>
    let expressionObject = Prefixed_Name(owlse, "expressionObject") |> PrefixedName
    /// <summary>
    ///   <para>owlse:refURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#refURI">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#refURI</seealso>
    let refURI = Prefixed_Name(owlse, "refURI") |> PrefixedName
    /// <summary>
    ///   <para>owlse:theObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     The range is not defined, and so the value of this property can
    ///     be any OWL instance.
    ///     When used to bind an OWL-S process precondition variable, however,
    ///     the value of this property must be an instance of process:Parameter.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theObject">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theObject</seealso>
    let theObject = Prefixed_Name(owlse, "theObject") |> PrefixedName
    /// <summary>
    ///   <para>owlse:theVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     The value of this property is a substring of a QuotedExpression.
    ///     The substring represents a variable in the language of the
    ///     QuotedExpression.  For example, if the QuotedExpression is in KIF,
    ///     the substring would be something like "?a".
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theVariable">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#theVariable</seealso>
    let theVariable = Prefixed_Name(owlse, "theVariable") |> PrefixedName
    /// <summary>
    ///   <para>owlse:variableBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#variableBinding">http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#variableBinding</seealso>
    let variableBinding = Prefixed_Name(owlse, "variableBinding") |> PrefixedName
