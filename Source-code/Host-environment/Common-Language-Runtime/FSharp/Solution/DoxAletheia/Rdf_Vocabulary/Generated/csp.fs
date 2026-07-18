namespace http.vocab.deri.ie.csp.hash

open DoxAletheia.Rdf_Vocabulary

module csp =
    let _namespace_name = "http://vocab.deri.ie/csp#"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#fpservant"></see>
    /// </summary>
    let fpservant = Namespaced_IRI.parse _namespace_name "fpservant" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#fbadra"></see>
    /// </summary>
    let fbadra = Namespaced_IRI.parse _namespace_name "fbadra" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#alepas"></see>
    /// </summary>
    let alepas = Namespaced_IRI.parse _namespace_name "alepas" |> NamespacedName
    /// <summary>
    /// Models a conjunctive logical sub-expression AND (BoolExpr1 BoolExpr2 ... BoolExprn).
    /// <see href="http://vocab.deri.ie/csp#And"></see></summary>
    let And = Namespaced_IRI.parse _namespace_name "And" |> NamespacedName
    /// <summary>
    /// A Boolean expression.
    /// <see href="http://vocab.deri.ie/csp#BoolExpr"></see></summary>
    let BoolExpr = Namespaced_IRI.parse _namespace_name "BoolExpr" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` =
        Namespaced_IRI.parse _namespace_name "DERI%2C%20NUI%20Galway" |> NamespacedName

    /// <summary>
    /// A fluent is the association of a variable name and a subset of its domain of values.
    /// <see href="http://vocab.deri.ie/csp#Fluent"></see></summary>
    let Fluent = Namespaced_IRI.parse _namespace_name "Fluent" |> NamespacedName
    /// <summary>
    /// Models the negation of a logical sub-expression NOT(BoolExpr).
    /// <see href="http://vocab.deri.ie/csp#Not"></see></summary>
    let Not = Namespaced_IRI.parse _namespace_name "Not" |> NamespacedName
    /// <summary>
    /// Models a disjunctive logical sub-expression OR (BoolExpr1 BoolExpr2 ... BoolExprn).
    /// <see href="http://vocab.deri.ie/csp#Or"></see></summary>
    let Or = Namespaced_IRI.parse _namespace_name "Or" |> NamespacedName
    /// <summary>
    /// The list of all valid combinations of values of a set of variables.
    /// <see href="http://vocab.deri.ie/csp#Relation"></see></summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#Renault"></see>
    /// </summary>
    let Renault = Namespaced_IRI.parse _namespace_name "Renault" |> NamespacedName
    /// <summary>
    /// A solution of the constraint satisfaction problem.
    /// <see href="http://vocab.deri.ie/csp#Solution"></see></summary>
    let Solution = Namespaced_IRI.parse _namespace_name "Solution" |> NamespacedName
    /// <summary>
    /// Links a logical conjunction operator to its arguments.
    /// <see href="http://vocab.deri.ie/csp#and"></see></summary>
    let and_ = Namespaced_IRI.parse _namespace_name "and" |> NamespacedName

    /// <summary>
    /// Boolean flag indicating for a relation if each supported combination of values must be satisfiable or not.
    /// <see href="http://vocab.deri.ie/csp#isSatisfiable"></see></summary>
    let isSatisfiable =
        Namespaced_IRI.parse _namespace_name "isSatisfiable" |> NamespacedName

    /// <summary>
    /// Links a logical negation operator to its argument.
    /// <see href="http://vocab.deri.ie/csp#not"></see></summary>
    let ``not`` = Namespaced_IRI.parse _namespace_name "not" |> NamespacedName
    /// <summary>
    /// Links a logical disjunction operator to its arguments.
    /// <see href="http://vocab.deri.ie/csp#or"></see></summary>
    let or_ = Namespaced_IRI.parse _namespace_name "or" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    /// Specifies all supported value combinations in the relation.
    /// <see href="http://vocab.deri.ie/csp#supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
    /// <summary>
    /// A value associated with a fluent.
    /// <see href="http://vocab.deri.ie/csp#val"></see></summary>
    let val_ = Namespaced_IRI.parse _namespace_name "val" |> NamespacedName
    /// <summary>
    /// The variable associated with a fluent.
    /// <see href="http://vocab.deri.ie/csp#var"></see></summary>
    let var = Namespaced_IRI.parse _namespace_name "var" |> NamespacedName
    /// <summary>
    /// A variable can be seen as a function associating a value to an object, and is therefore modelled as an RDF property that points to one (or many) value(s).
    /// <see href="http://vocab.deri.ie/csp#variable"></see></summary>
    let variable = Namespaced_IRI.parse _namespace_name "variable" |> NamespacedName
