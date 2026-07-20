namespace http.vocab.deri.ie.csp.hash

open DoxAletheia

module csp =
    let _namespace_name = "http://vocab.deri.ie/csp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#fpservant"></see>
    /// </summary>
    let fpservant = _prefix "fpservant"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#fbadra"></see>
    /// </summary>
    let fbadra = _prefix "fbadra"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#alepas"></see>
    /// </summary>
    let alepas = _prefix "alepas"
    /// <summary>
    /// Models a conjunctive logical sub-expression AND (BoolExpr1 BoolExpr2 ... BoolExprn).
    /// <see href="http://vocab.deri.ie/csp#And"></see></summary>
    let And = _prefix "And"
    /// <summary>
    /// A Boolean expression.
    /// <see href="http://vocab.deri.ie/csp#BoolExpr"></see></summary>
    let BoolExpr = _prefix "BoolExpr"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` = _prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    /// A fluent is the association of a variable name and a subset of its domain of values.
    /// <see href="http://vocab.deri.ie/csp#Fluent"></see></summary>
    let Fluent = _prefix "Fluent"
    /// <summary>
    /// Models the negation of a logical sub-expression NOT(BoolExpr).
    /// <see href="http://vocab.deri.ie/csp#Not"></see></summary>
    let Not = _prefix "Not"
    /// <summary>
    /// Models a disjunctive logical sub-expression OR (BoolExpr1 BoolExpr2 ... BoolExprn).
    /// <see href="http://vocab.deri.ie/csp#Or"></see></summary>
    let Or = _prefix "Or"
    /// <summary>
    /// The list of all valid combinations of values of a set of variables.
    /// <see href="http://vocab.deri.ie/csp#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#Renault"></see>
    /// </summary>
    let Renault = _prefix "Renault"
    /// <summary>
    /// A solution of the constraint satisfaction problem.
    /// <see href="http://vocab.deri.ie/csp#Solution"></see></summary>
    let Solution = _prefix "Solution"
    /// <summary>
    /// Links a logical conjunction operator to its arguments.
    /// <see href="http://vocab.deri.ie/csp#and"></see></summary>
    let and_ = _prefix "and"
    /// <summary>
    /// Boolean flag indicating for a relation if each supported combination of values must be satisfiable or not.
    /// <see href="http://vocab.deri.ie/csp#isSatisfiable"></see></summary>
    let isSatisfiable = _prefix "isSatisfiable"
    /// <summary>
    /// Links a logical negation operator to its argument.
    /// <see href="http://vocab.deri.ie/csp#not"></see></summary>
    let ``not`` = _prefix "not"
    /// <summary>
    /// Links a logical disjunction operator to its arguments.
    /// <see href="http://vocab.deri.ie/csp#or"></see></summary>
    let or_ = _prefix "or"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// Specifies all supported value combinations in the relation.
    /// <see href="http://vocab.deri.ie/csp#supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/csp#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// A value associated with a fluent.
    /// <see href="http://vocab.deri.ie/csp#val"></see></summary>
    let val_ = _prefix "val"
    /// <summary>
    /// The variable associated with a fluent.
    /// <see href="http://vocab.deri.ie/csp#var"></see></summary>
    let var = _prefix "var"
    /// <summary>
    /// A variable can be seen as a function associating a value to an object, and is therefore modelled as an RDF property that points to one (or many) value(s).
    /// <see href="http://vocab.deri.ie/csp#variable"></see></summary>
    let variable = _prefix "variable"
