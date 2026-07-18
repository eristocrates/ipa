namespace http.www.w3.org.ns.shex.hash

open DoxAletheia.Rdf_Vocabulary

module shex =
    let _namespace_name = "http://www.w3.org/ns/shex#"
    /// <summary>
    /// Annotations provide a format-independent way to provide additional information about elements in a schema.
    /// <see href="http://www.w3.org/ns/shex#Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName
    /// <summary>
    /// A TripleExpression composed of one or more sub-expressions, all of which must match.
    /// <see href="http://www.w3.org/ns/shex#EachOf"></see></summary>
    let EachOf = Namespaced_IRI.parse _namespace_name "EachOf" |> NamespacedName

    /// <summary>
    /// The abstract class of Triple Expressions.
    /// <see href="http://www.w3.org/ns/shex#TripleExpression"></see></summary>
    let TripleExpression =
        Namespaced_IRI.parse _namespace_name "TripleExpression" |> NamespacedName

    /// <summary>
    /// An IRI prefix used for matching IRIs.
    /// <see href="http://www.w3.org/ns/shex#IriStem"></see></summary>
    let IriStem = Namespaced_IRI.parse _namespace_name "IriStem" |> NamespacedName
    /// <summary>
    /// Abstract class for Stems
    /// <see href="http://www.w3.org/ns/shex#Stem"></see></summary>
    let Stem = Namespaced_IRI.parse _namespace_name "Stem" |> NamespacedName

    /// <summary>
    /// An IRI prefix (or wildcard) along with a set of excluded values, used for node matching.
    /// <see href="http://www.w3.org/ns/shex#IriStemRange"></see></summary>
    let IriStemRange =
        Namespaced_IRI.parse _namespace_name "IriStemRange" |> NamespacedName

    /// <summary>
    /// Abstract Class for Stem Ranges
    /// <see href="http://www.w3.org/ns/shex#StemRange"></see></summary>
    let StemRange = Namespaced_IRI.parse _namespace_name "StemRange" |> NamespacedName
    /// <summary>
    /// An Language tag used for matching Literal Languages.
    /// <see href="http://www.w3.org/ns/shex#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// An Language prefix used for matching Literal Languages.
    /// <see href="http://www.w3.org/ns/shex#LanguageStem"></see></summary>
    let LanguageStem =
        Namespaced_IRI.parse _namespace_name "LanguageStem" |> NamespacedName

    /// <summary>
    /// An Language prefix (or wildcard) along with a set of excluded values, used for node matching.
    /// <see href="http://www.w3.org/ns/shex#LanguageStemRange"></see></summary>
    let LanguageStemRange =
        Namespaced_IRI.parse _namespace_name "LanguageStemRange" |> NamespacedName

    /// <summary>
    /// An Literal prefix used for matching Literals.
    /// <see href="http://www.w3.org/ns/shex#LiteralStem"></see></summary>
    let LiteralStem =
        Namespaced_IRI.parse _namespace_name "LiteralStem" |> NamespacedName

    /// <summary>
    /// An Literal prefix (or wildcard) along with a set of excluded values, used for node matching.
    /// <see href="http://www.w3.org/ns/shex#LiteralStemRange"></see></summary>
    let LiteralStemRange =
        Namespaced_IRI.parse _namespace_name "LiteralStemRange" |> NamespacedName

    /// <summary>
    /// A constraint on the type or value of an RDF Node.
    /// <see href="http://www.w3.org/ns/shex#NodeConstraint"></see></summary>
    let NodeConstraint =
        Namespaced_IRI.parse _namespace_name "NodeConstraint" |> NamespacedName

    /// <summary>
    /// The abstract class of Shape Expressions.
    /// <see href="http://www.w3.org/ns/shex#ShapeExpression"></see></summary>
    let ShapeExpression =
        Namespaced_IRI.parse _namespace_name "ShapeExpression" |> NamespacedName

    /// <summary>
    /// The set of kinds of RDF Nodes.
    /// <see href="http://www.w3.org/ns/shex#NodeKind"></see></summary>
    let NodeKind = Namespaced_IRI.parse _namespace_name "NodeKind" |> NamespacedName
    /// <summary>
    /// A TripleExpression composed of one or more sub-expressions, one of which must match.
    /// <see href="http://www.w3.org/ns/shex#OneOf"></see></summary>
    let OneOf = Namespaced_IRI.parse _namespace_name "OneOf" |> NamespacedName
    /// <summary>
    /// A Schema contains the set of shapes, used for matching a focus node.
    /// <see href="http://www.w3.org/ns/shex#Schema"></see></summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName
    /// <summary>
    /// A list of Semantic Actions that serve as an extension point for Shape Expressions. They appear in lists in Schema's startActs and Shape, OneOf, EachOf and TripleConstraint's semActs.
    /// <see href="http://www.w3.org/ns/shex#SemAct"></see></summary>
    let SemAct = Namespaced_IRI.parse _namespace_name "SemAct" |> NamespacedName
    /// <summary>
    /// A shapes schema is captured in a Schema object where shapes is a mapping from shape label to shape expression.
    /// <see href="http://www.w3.org/ns/shex#Shape"></see></summary>
    let Shape = Namespaced_IRI.parse _namespace_name "Shape" |> NamespacedName
    /// <summary>
    /// A ShapeExpression composed of one or more sub-expressions, all of which must match.
    /// <see href="http://www.w3.org/ns/shex#ShapeAnd"></see></summary>
    let ShapeAnd = Namespaced_IRI.parse _namespace_name "ShapeAnd" |> NamespacedName

    /// <summary>
    /// A reference to a shape defined in some external Schema.
    /// <see href="http://www.w3.org/ns/shex#ShapeExternal"></see></summary>
    let ShapeExternal =
        Namespaced_IRI.parse _namespace_name "ShapeExternal" |> NamespacedName

    /// <summary>
    /// A ShapeNot is satisfied when it’s included ShapeExpression is not satisfied.
    /// <see href="http://www.w3.org/ns/shex#ShapeNot"></see></summary>
    let ShapeNot = Namespaced_IRI.parse _namespace_name "ShapeNot" |> NamespacedName
    /// <summary>
    /// A ShapeExpression composed of one or more sub-expressions, one of which must match.
    /// <see href="http://www.w3.org/ns/shex#ShapeOr"></see></summary>
    let ShapeOr = Namespaced_IRI.parse _namespace_name "ShapeOr" |> NamespacedName

    /// <summary>
    /// A constraint on a triple having a specific predicate and optionally a shape expression used for matching values.
    /// <see href="http://www.w3.org/ns/shex#TripleConstraint"></see></summary>
    let TripleConstraint =
        Namespaced_IRI.parse _namespace_name "TripleConstraint" |> NamespacedName

    /// <summary>
    /// Indicates that a stem is a Wildcard, rather than a URI prefix.
    /// <see href="http://www.w3.org/ns/shex#Wildcard"></see></summary>
    let Wildcard = Namespaced_IRI.parse _namespace_name "Wildcard" |> NamespacedName
    /// <summary>
    /// Annotations on a TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#annotation"></see></summary>
    let annotation = Namespaced_IRI.parse _namespace_name "annotation" |> NamespacedName
    /// <summary>
    /// Requires node to be a Blank Node
    /// <see href="http://www.w3.org/ns/shex#bnode"></see></summary>
    let bnode = Namespaced_IRI.parse _namespace_name "bnode" |> NamespacedName
    /// <summary>
    /// Indicates that a Shape is closed, meaning that it may contain no property values other than those used within TripleConstraints.
    /// <see href="http://www.w3.org/ns/shex#closed"></see></summary>
    let closed = Namespaced_IRI.parse _namespace_name "closed" |> NamespacedName
    /// <summary>
    /// Code executed by Semantic Action.
    /// <see href="http://www.w3.org/ns/shex#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// A datatype constraint.
    /// <see href="http://www.w3.org/ns/shex#datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// Values that are excluded from value matching.
    /// <see href="http://www.w3.org/ns/shex#exclusion"></see></summary>
    let exclusion = Namespaced_IRI.parse _namespace_name "exclusion" |> NamespacedName
    /// <summary>
    /// Expression associated with the TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#expression"></see></summary>
    let expression = Namespaced_IRI.parse _namespace_name "expression" |> NamespacedName

    /// <summary>
    /// List of 2 or more expressions associated with the TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#expressions"></see></summary>
    let expressions =
        Namespaced_IRI.parse _namespace_name "expressions" |> NamespacedName

    /// <summary>
    /// Base shape expressions for this shape.
    /// <see href="http://www.w3.org/ns/shex#extends"></see></summary>
    let extends = Namespaced_IRI.parse _namespace_name "extends" |> NamespacedName
    /// <summary>
    /// Properties which may have extra values beyond those matched through a constraint.
    /// <see href="http://www.w3.org/ns/shex#extra"></see></summary>
    let extra = Namespaced_IRI.parse _namespace_name "extra" |> NamespacedName
    /// <summary>
    /// Regular expression flags
    /// <see href="http://www.w3.org/ns/shex#flags"></see></summary>
    let flags = Namespaced_IRI.parse _namespace_name "flags" |> NamespacedName

    /// <summary>
    /// for "fractiondigits" constraints, v is less than or equals the number of digits to the right of the decimal place in the XML Schema canonical form[xmlschema-2] of the value of n, ignoring trailing zeros.
    /// <see href="http://www.w3.org/ns/shex#fractiondigits"></see></summary>
    let fractiondigits =
        Namespaced_IRI.parse _namespace_name "fractiondigits" |> NamespacedName

    /// <summary>
    /// Abstract property of numeric facets on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#numericFacet"></see></summary>
    let numericFacet =
        Namespaced_IRI.parse _namespace_name "numericFacet" |> NamespacedName

    /// <summary>
    /// Constrains the subject of a triple, rather than the object.
    /// <see href="http://www.w3.org/ns/shex#inverse"></see></summary>
    let inverse = Namespaced_IRI.parse _namespace_name "inverse" |> NamespacedName
    /// <summary>
    /// Requires node to be an IRI
    /// <see href="http://www.w3.org/ns/shex#iri"></see></summary>
    let iri = Namespaced_IRI.parse _namespace_name "iri" |> NamespacedName

    /// <summary>
    /// The value used to match the language tag of a language-tagged string.
    /// <see href="http://www.w3.org/ns/shex#languageTag"></see></summary>
    let languageTag =
        Namespaced_IRI.parse _namespace_name "languageTag" |> NamespacedName

    /// <summary>
    /// The exact length of the value of the cell.
    /// <see href="http://www.w3.org/ns/shex#length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    /// An abstract property of string facets on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#stringFacet"></see></summary>
    let stringFacet =
        Namespaced_IRI.parse _namespace_name "stringFacet" |> NamespacedName

    /// <summary>
    /// Requires node to be an rdf:Literal
    /// <see href="http://www.w3.org/ns/shex#literal"></see></summary>
    let literal = Namespaced_IRI.parse _namespace_name "literal" |> NamespacedName
    /// <summary>
    /// Maximum number of times this TripleExpression may match; -1 for “*”
    /// <see href="http://www.w3.org/ns/shex#max"></see></summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName

    /// <summary>
    /// An atomic property that contains a single number that is the maximum valid value (exclusive).
    /// <see href="http://www.w3.org/ns/shex#maxexclusive"></see></summary>
    let maxexclusive =
        Namespaced_IRI.parse _namespace_name "maxexclusive" |> NamespacedName

    /// <summary>
    /// An atomic property that contains a single number that is the maximum valid value (inclusive).
    /// <see href="http://www.w3.org/ns/shex#maxinclusive"></see></summary>
    let maxinclusive =
        Namespaced_IRI.parse _namespace_name "maxinclusive" |> NamespacedName

    /// <summary>
    /// A numeric atomic property that contains a single integer that is the maximum length of the value.
    /// <see href="http://www.w3.org/ns/shex#maxlength"></see></summary>
    let maxlength = Namespaced_IRI.parse _namespace_name "maxlength" |> NamespacedName
    /// <summary>
    /// Minimum number of times this TripleExpression may match.
    /// <see href="http://www.w3.org/ns/shex#min"></see></summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName

    /// <summary>
    /// An atomic property that contains a single number that is the minimum valid value (exclusive).
    /// <see href="http://www.w3.org/ns/shex#minexclusive"></see></summary>
    let minexclusive =
        Namespaced_IRI.parse _namespace_name "minexclusive" |> NamespacedName

    /// <summary>
    /// An atomic property that contains a single number that is the minimum valid value (inclusive).
    /// <see href="http://www.w3.org/ns/shex#mininclusive"></see></summary>
    let mininclusive =
        Namespaced_IRI.parse _namespace_name "mininclusive" |> NamespacedName

    /// <summary>
    /// An atomic property that contains a single integer that is the minimum length of the value.
    /// <see href="http://www.w3.org/ns/shex#minlength"></see></summary>
    let minlength = Namespaced_IRI.parse _namespace_name "minlength" |> NamespacedName
    /// <summary>
    /// Identifier of SemAct extension.
    /// <see href="http://www.w3.org/ns/shex#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Restiction on the kind of node matched; restricted to the defined instances of NodeKind. One of shex:iri, shex:bnode, shex:literal, or shex:nonliteral.
    /// <see href="http://www.w3.org/ns/shex#nodeKind"></see></summary>
    let nodeKind = Namespaced_IRI.parse _namespace_name "nodeKind" |> NamespacedName
    /// <summary>
    /// Requires node to be a Blank Node or IRI
    /// <see href="http://www.w3.org/ns/shex#nonliteral"></see></summary>
    let nonliteral = Namespaced_IRI.parse _namespace_name "nonliteral" |> NamespacedName
    /// <summary>
    /// An abstract property of string and numeric facets on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#xsFacet"></see></summary>
    let xsFacet = Namespaced_IRI.parse _namespace_name "xsFacet" |> NamespacedName
    /// <summary>
    /// The object of an Annotation.
    /// <see href="http://www.w3.org/ns/shex#object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// A regular expression used for matching a value.
    /// <see href="http://www.w3.org/ns/shex#pattern"></see></summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName
    /// <summary>
    /// The predicate of a TripleConstraint or Annotation.
    /// <see href="http://www.w3.org/ns/shex#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// Semantic Actions on this TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#semActs"></see></summary>
    let semActs = Namespaced_IRI.parse _namespace_name "semActs" |> NamespacedName
    /// <summary>
    /// Shape Expression referenced by this shape.
    /// <see href="http://www.w3.org/ns/shex#shapeExpr"></see></summary>
    let shapeExpr = Namespaced_IRI.parse _namespace_name "shapeExpr" |> NamespacedName
    /// <summary>
    /// A list of 2 or more Shape Expressions referenced by this shape.
    /// <see href="http://www.w3.org/ns/shex#shapeExprs"></see></summary>
    let shapeExprs = Namespaced_IRI.parse _namespace_name "shapeExprs" |> NamespacedName
    /// <summary>
    /// Shapes in this Schema.
    /// <see href="http://www.w3.org/ns/shex#shapes"></see></summary>
    let shapes = Namespaced_IRI.parse _namespace_name "shapes" |> NamespacedName
    /// <summary>
    /// A ShapeExpression matched against the focus node prior to any other mapped expressions.
    /// <see href="http://www.w3.org/ns/shex#start"></see></summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName
    /// <summary>
    /// Semantic Actions run on the Schema.
    /// <see href="http://www.w3.org/ns/shex#startActs"></see></summary>
    let startActs = Namespaced_IRI.parse _namespace_name "startActs" |> NamespacedName
    /// <summary>
    /// A stem value used for matching or excluding values.
    /// <see href="http://www.w3.org/ns/shex#stem"></see></summary>
    let stem = Namespaced_IRI.parse _namespace_name "stem" |> NamespacedName

    /// <summary>
    /// for "totaldigits" constraints, v equals the number of digits in the XML Schema canonical form[xmlschema-2] of the value of n
    /// <see href="http://www.w3.org/ns/shex#totaldigits"></see></summary>
    let totaldigits =
        Namespaced_IRI.parse _namespace_name "totaldigits" |> NamespacedName

    /// <summary>
    /// A ShapeExpression used for matching the object (or subject if inverted) of a TripleConstraint.
    /// <see href="http://www.w3.org/ns/shex#valueExpr"></see></summary>
    let valueExpr = Namespaced_IRI.parse _namespace_name "valueExpr" |> NamespacedName
    /// <summary>
    /// A value restriction on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#values"></see></summary>
    let values = Namespaced_IRI.parse _namespace_name "values" |> NamespacedName
