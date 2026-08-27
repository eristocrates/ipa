namespace http.vocab.deri.ie.csp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module csp =
    let _namespace_iri = Namespace_Iri csp |> NamespaceIRI
    /// <summary>
    ///   <para>csp:And</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Models a conjunctive logical sub-expression AND (BoolExpr1 BoolExpr2 ... BoolExprn)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"And"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#And">http://vocab.deri.ie/csp#And</seealso>
    let And = Prefixed_Name(csp, "And") |> PrefixedName
    /// <summary>
    ///   <para>csp:BoolExpr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Boolean expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boolean expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#BoolExpr">http://vocab.deri.ie/csp#BoolExpr</seealso>
    let BoolExpr = Prefixed_Name(csp, "BoolExpr") |> PrefixedName

    /// <summary>
    ///   <para>csp:DERI%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#DERI%2C%20NUI%20Galway">http://vocab.deri.ie/csp#DERI%2C%20NUI%20Galway</seealso>
    let ``DERI%2C%20NUI%20Galway`` =
        Prefixed_Name(csp, "DERI%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>csp:Fluent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A fluent is the association of a variable name and a subset of its domain of values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fluent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#Fluent">http://vocab.deri.ie/csp#Fluent</seealso>
    let Fluent = Prefixed_Name(csp, "Fluent") |> PrefixedName
    /// <summary>
    ///   <para>csp:Not</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models the negation of a logical sub-expression NOT(BoolExpr)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#Not">http://vocab.deri.ie/csp#Not</seealso>
    let Not = Prefixed_Name(csp, "Not") |> PrefixedName
    /// <summary>
    ///   <para>csp:Or</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models a disjunctive logical sub-expression OR (BoolExpr1 BoolExpr2 ... BoolExprn)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Or"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#Or">http://vocab.deri.ie/csp#Or</seealso>
    let Or = Prefixed_Name(csp, "Or") |> PrefixedName
    /// <summary>
    ///   <para>csp:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The list of all valid combinations of values of a set of variables."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#Relation">http://vocab.deri.ie/csp#Relation</seealso>
    let Relation = Prefixed_Name(csp, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>csp:Renault</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#Renault">http://vocab.deri.ie/csp#Renault</seealso>
    let Renault = Prefixed_Name(csp, "Renault") |> PrefixedName
    /// <summary>
    ///   <para>csp:Solution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A solution of the constraint satisfaction problem."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Solution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#Solution">http://vocab.deri.ie/csp#Solution</seealso>
    let Solution = Prefixed_Name(csp, "Solution") |> PrefixedName
    /// <summary>
    ///   <para>csp:alepas</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#alepas">http://vocab.deri.ie/csp#alepas</seealso>
    let alepas = Prefixed_Name(csp, "alepas") |> PrefixedName
    /// <summary>
    ///   <para>csp:and</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a logical conjunction operator to its arguments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"and"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#and">http://vocab.deri.ie/csp#and</seealso>
    let and_ = Prefixed_Name(csp, "and") |> PrefixedName
    /// <summary>
    ///   <para>csp:fbadra</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#fbadra">http://vocab.deri.ie/csp#fbadra</seealso>
    let fbadra = Prefixed_Name(csp, "fbadra") |> PrefixedName
    /// <summary>
    ///   <para>csp:fpservant</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#fpservant">http://vocab.deri.ie/csp#fpservant</seealso>
    let fpservant = Prefixed_Name(csp, "fpservant") |> PrefixedName
    /// <summary>
    ///   <para>csp:isSatisfiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Boolean flag indicating for a relation if each supported combination of values must be satisfiable or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is satisfiable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#isSatisfiable">http://vocab.deri.ie/csp#isSatisfiable</seealso>
    let isSatisfiable = Prefixed_Name(csp, "isSatisfiable") |> PrefixedName
    /// <summary>
    ///   <para>csp:not</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a logical negation operator to its argument."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#not">http://vocab.deri.ie/csp#not</seealso>
    let ``not`` = Prefixed_Name(csp, "not") |> PrefixedName
    /// <summary>
    ///   <para>csp:or</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a logical disjunction operator to its arguments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"or"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#or">http://vocab.deri.ie/csp#or</seealso>
    let or_ = Prefixed_Name(csp, "or") |> PrefixedName
    /// <summary>
    ///   <para>csp:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#rdf">http://vocab.deri.ie/csp#rdf</seealso>
    let rdf = Prefixed_Name(csp, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>csp:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies all supported value combinations in the relation. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"supports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#supports">http://vocab.deri.ie/csp#supports</seealso>
    let supports = Prefixed_Name(csp, "supports") |> PrefixedName
    /// <summary>
    ///   <para>csp:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/csp#ttl">http://vocab.deri.ie/csp#ttl</seealso>
    let ttl = Prefixed_Name(csp, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>csp:val</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A value associated with a fluent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#val">http://vocab.deri.ie/csp#val</seealso>
    let val_ = Prefixed_Name(csp, "val") |> PrefixedName
    /// <summary>
    ///   <para>csp:var</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The variable associated with a fluent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#var">http://vocab.deri.ie/csp#var</seealso>
    let var = Prefixed_Name(csp, "var") |> PrefixedName
    /// <summary>
    ///   <para>csp:variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A variable can be seen as a function associating a value to an object, and is therefore modelled as an RDF property that points to one (or many) value(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/csp#variable">http://vocab.deri.ie/csp#variable</seealso>
    let variable = Prefixed_Name(csp, "variable") |> PrefixedName
