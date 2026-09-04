#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module csp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/csp#" "csp"
    /// <summary>
    ///   <para>rdfs:label : And^^xsd:string</para>
    ///   <para>rdfs:comment : Models a conjunctive logical sub-expression AND (BoolExpr1 BoolExpr2 ... BoolExprn).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#And">csp:And</a>
    /// </summary>
    let And = _prefixId.prefix "And"
    /// <summary>
    ///   <para>rdfs:label : Boolean expression^^xsd:string</para>
    ///   <para>rdfs:comment : A Boolean expression.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#BoolExpr">csp:BoolExpr</a>
    /// </summary>
    let BoolExpr = _prefixId.prefix "BoolExpr"
    let ``DERI%2C%20NUI%20Galway`` = _prefixId.prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <para>rdfs:label : Fluent^^xsd:string</para>
    ///   <para>rdfs:comment : A fluent is the association of a variable name and a subset of its domain of values.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#Fluent">csp:Fluent</a>
    /// </summary>
    let Fluent = _prefixId.prefix "Fluent"
    /// <summary>
    ///   <para>rdfs:label : Not^^xsd:string</para>
    ///   <para>rdfs:comment : Models the negation of a logical sub-expression NOT(BoolExpr).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#Not">csp:Not</a>
    /// </summary>
    let Not = _prefixId.prefix "Not"
    /// <summary>
    ///   <para>rdfs:label : Or^^xsd:string</para>
    ///   <para>rdfs:comment : Models a disjunctive logical sub-expression OR (BoolExpr1 BoolExpr2 ... BoolExprn).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#Or">csp:Or</a>
    /// </summary>
    let Or = _prefixId.prefix "Or"
    /// <summary>
    ///   <para>rdfs:label : Relation^^xsd:string</para>
    ///   <para>rdfs:comment : The list of all valid combinations of values of a set of variables.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#Relation">csp:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    let Renault = _prefixId.prefix "Renault"
    /// <summary>
    ///   <para>rdfs:label : Solution^^xsd:string</para>
    ///   <para>rdfs:comment : A solution of the constraint satisfaction problem.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#Solution">csp:Solution</a>
    /// </summary>
    let Solution = _prefixId.prefix "Solution"
    let alepas = _prefixId.prefix "alepas"
    /// <summary>
    ///   <para>rdfs:label : and^^xsd:string</para>
    ///   <para>rdfs:comment : Links a logical conjunction operator to its arguments.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#and">csp:and</a>
    /// </summary>
    let and_ = _prefixId.prefix "and"
    let fbadra = _prefixId.prefix "fbadra"
    let fpservant = _prefixId.prefix "fpservant"
    /// <summary>
    ///   <para>rdfs:label : is satisfiable^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean flag indicating for a relation if each supported combination of values must be satisfiable or not.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#isSatisfiable">csp:isSatisfiable</a>
    /// </summary>
    let isSatisfiable = _prefixId.prefix "isSatisfiable"
    /// <summary>
    ///   <para>rdfs:label : not^^xsd:string</para>
    ///   <para>rdfs:comment : Links a logical negation operator to its argument.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#not">csp:not</a>
    /// </summary>
    let ``not`` = _prefixId.prefix "not"
    /// <summary>
    ///   <para>rdfs:label : or^^xsd:string</para>
    ///   <para>rdfs:comment : Links a logical disjunction operator to its arguments.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#or">csp:or</a>
    /// </summary>
    let or_ = _prefixId.prefix "or"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : supports^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies all supported value combinations in the relation. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#supports">csp:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : has value^^xsd:string</para>
    ///   <para>rdfs:comment : A value associated with a fluent.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#val">csp:val</a>
    /// </summary>
    let val_ = _prefixId.prefix "val"
    /// <summary>
    ///   <para>rdfs:label : has variable^^xsd:string</para>
    ///   <para>rdfs:comment : The variable associated with a fluent.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#var">csp:var</a>
    /// </summary>
    let var = _prefixId.prefix "var"
    /// <summary>
    ///   <para>rdfs:label : variable^^xsd:string</para>
    ///   <para>rdfs:comment : A variable can be seen as a function associating a value to an object, and is therefore modelled as an RDF property that points to one (or many) value(s).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/csp#variable">csp:variable</a>
    /// </summary>
    let variable = _prefixId.prefix "variable"
