namespace http.www.w3.org.ns.shex.hash

open DoxAletheia

module shex =
    let _namespace_name = "http://www.w3.org/ns/shex#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Annotations provide a format-independent way to provide additional information about elements in a schema.
    /// <see href="http://www.w3.org/ns/shex#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// A TripleExpression composed of one or more sub-expressions, all of which must match.
    /// <see href="http://www.w3.org/ns/shex#EachOf"></see></summary>
    let EachOf = _prefix "EachOf"
    /// <summary>
    /// The abstract class of Triple Expressions.
    /// <see href="http://www.w3.org/ns/shex#TripleExpression"></see></summary>
    let TripleExpression = _prefix "TripleExpression"
    /// <summary>
    /// An IRI prefix used for matching IRIs.
    /// <see href="http://www.w3.org/ns/shex#IriStem"></see></summary>
    let IriStem = _prefix "IriStem"
    /// <summary>
    /// Abstract class for Stems
    /// <see href="http://www.w3.org/ns/shex#Stem"></see></summary>
    let Stem = _prefix "Stem"
    /// <summary>
    /// An IRI prefix (or wildcard) along with a set of excluded values, used for node matching.
    /// <see href="http://www.w3.org/ns/shex#IriStemRange"></see></summary>
    let IriStemRange = _prefix "IriStemRange"
    /// <summary>
    /// Abstract Class for Stem Ranges
    /// <see href="http://www.w3.org/ns/shex#StemRange"></see></summary>
    let StemRange = _prefix "StemRange"
    /// <summary>
    /// An Language tag used for matching Literal Languages.
    /// <see href="http://www.w3.org/ns/shex#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// An Language prefix used for matching Literal Languages.
    /// <see href="http://www.w3.org/ns/shex#LanguageStem"></see></summary>
    let LanguageStem = _prefix "LanguageStem"
    /// <summary>
    /// An Language prefix (or wildcard) along with a set of excluded values, used for node matching.
    /// <see href="http://www.w3.org/ns/shex#LanguageStemRange"></see></summary>
    let LanguageStemRange = _prefix "LanguageStemRange"
    /// <summary>
    /// An Literal prefix used for matching Literals.
    /// <see href="http://www.w3.org/ns/shex#LiteralStem"></see></summary>
    let LiteralStem = _prefix "LiteralStem"
    /// <summary>
    /// An Literal prefix (or wildcard) along with a set of excluded values, used for node matching.
    /// <see href="http://www.w3.org/ns/shex#LiteralStemRange"></see></summary>
    let LiteralStemRange = _prefix "LiteralStemRange"
    /// <summary>
    /// A constraint on the type or value of an RDF Node.
    /// <see href="http://www.w3.org/ns/shex#NodeConstraint"></see></summary>
    let NodeConstraint = _prefix "NodeConstraint"
    /// <summary>
    /// The abstract class of Shape Expressions.
    /// <see href="http://www.w3.org/ns/shex#ShapeExpression"></see></summary>
    let ShapeExpression = _prefix "ShapeExpression"
    /// <summary>
    /// The set of kinds of RDF Nodes.
    /// <see href="http://www.w3.org/ns/shex#NodeKind"></see></summary>
    let NodeKind = _prefix "NodeKind"
    /// <summary>
    /// A TripleExpression composed of one or more sub-expressions, one of which must match.
    /// <see href="http://www.w3.org/ns/shex#OneOf"></see></summary>
    let OneOf = _prefix "OneOf"
    /// <summary>
    /// A Schema contains the set of shapes, used for matching a focus node.
    /// <see href="http://www.w3.org/ns/shex#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    /// A list of Semantic Actions that serve as an extension point for Shape Expressions. They appear in lists in Schema's startActs and Shape, OneOf, EachOf and TripleConstraint's semActs.
    /// <see href="http://www.w3.org/ns/shex#SemAct"></see></summary>
    let SemAct = _prefix "SemAct"
    /// <summary>
    /// A shapes schema is captured in a Schema object where shapes is a mapping from shape label to shape expression.
    /// <see href="http://www.w3.org/ns/shex#Shape"></see></summary>
    let Shape = _prefix "Shape"
    /// <summary>
    /// A ShapeExpression composed of one or more sub-expressions, all of which must match.
    /// <see href="http://www.w3.org/ns/shex#ShapeAnd"></see></summary>
    let ShapeAnd = _prefix "ShapeAnd"
    /// <summary>
    /// A reference to a shape defined in some external Schema.
    /// <see href="http://www.w3.org/ns/shex#ShapeExternal"></see></summary>
    let ShapeExternal = _prefix "ShapeExternal"
    /// <summary>
    /// A ShapeNot is satisfied when it’s included ShapeExpression is not satisfied.
    /// <see href="http://www.w3.org/ns/shex#ShapeNot"></see></summary>
    let ShapeNot = _prefix "ShapeNot"
    /// <summary>
    /// A ShapeExpression composed of one or more sub-expressions, one of which must match.
    /// <see href="http://www.w3.org/ns/shex#ShapeOr"></see></summary>
    let ShapeOr = _prefix "ShapeOr"
    /// <summary>
    /// A constraint on a triple having a specific predicate and optionally a shape expression used for matching values.
    /// <see href="http://www.w3.org/ns/shex#TripleConstraint"></see></summary>
    let TripleConstraint = _prefix "TripleConstraint"
    /// <summary>
    /// Indicates that a stem is a Wildcard, rather than a URI prefix.
    /// <see href="http://www.w3.org/ns/shex#Wildcard"></see></summary>
    let Wildcard = _prefix "Wildcard"
    /// <summary>
    /// Annotations on a TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#annotation"></see></summary>
    let annotation = _prefix "annotation"
    /// <summary>
    /// Requires node to be a Blank Node
    /// <see href="http://www.w3.org/ns/shex#bnode"></see></summary>
    let bnode = _prefix "bnode"
    /// <summary>
    /// Indicates that a Shape is closed, meaning that it may contain no property values other than those used within TripleConstraints.
    /// <see href="http://www.w3.org/ns/shex#closed"></see></summary>
    let closed = _prefix "closed"
    /// <summary>
    /// Code executed by Semantic Action.
    /// <see href="http://www.w3.org/ns/shex#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// A datatype constraint.
    /// <see href="http://www.w3.org/ns/shex#datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// Values that are excluded from value matching.
    /// <see href="http://www.w3.org/ns/shex#exclusion"></see></summary>
    let exclusion = _prefix "exclusion"
    /// <summary>
    /// Expression associated with the TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#expression"></see></summary>
    let expression = _prefix "expression"
    /// <summary>
    /// List of 2 or more expressions associated with the TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#expressions"></see></summary>
    let expressions = _prefix "expressions"
    /// <summary>
    /// Base shape expressions for this shape.
    /// <see href="http://www.w3.org/ns/shex#extends"></see></summary>
    let extends = _prefix "extends"
    /// <summary>
    /// Properties which may have extra values beyond those matched through a constraint.
    /// <see href="http://www.w3.org/ns/shex#extra"></see></summary>
    let extra = _prefix "extra"
    /// <summary>
    /// Regular expression flags
    /// <see href="http://www.w3.org/ns/shex#flags"></see></summary>
    let flags = _prefix "flags"
    /// <summary>
    /// for "fractiondigits" constraints, v is less than or equals the number of digits to the right of the decimal place in the XML Schema canonical form[xmlschema-2] of the value of n, ignoring trailing zeros.
    /// <see href="http://www.w3.org/ns/shex#fractiondigits"></see></summary>
    let fractiondigits = _prefix "fractiondigits"
    /// <summary>
    /// Abstract property of numeric facets on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#numericFacet"></see></summary>
    let numericFacet = _prefix "numericFacet"
    /// <summary>
    /// Constrains the subject of a triple, rather than the object.
    /// <see href="http://www.w3.org/ns/shex#inverse"></see></summary>
    let inverse = _prefix "inverse"
    /// <summary>
    /// Requires node to be an IRI
    /// <see href="http://www.w3.org/ns/shex#iri"></see></summary>
    let iri = _prefix "iri"
    /// <summary>
    /// The value used to match the language tag of a language-tagged string.
    /// <see href="http://www.w3.org/ns/shex#languageTag"></see></summary>
    let languageTag = _prefix "languageTag"
    /// <summary>
    /// The exact length of the value of the cell.
    /// <see href="http://www.w3.org/ns/shex#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// An abstract property of string facets on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#stringFacet"></see></summary>
    let stringFacet = _prefix "stringFacet"
    /// <summary>
    /// Requires node to be an rdf:Literal
    /// <see href="http://www.w3.org/ns/shex#literal"></see></summary>
    let literal = _prefix "literal"
    /// <summary>
    /// Maximum number of times this TripleExpression may match; -1 for “*”
    /// <see href="http://www.w3.org/ns/shex#max"></see></summary>
    let max = _prefix "max"
    /// <summary>
    /// An atomic property that contains a single number that is the maximum valid value (exclusive).
    /// <see href="http://www.w3.org/ns/shex#maxexclusive"></see></summary>
    let maxexclusive = _prefix "maxexclusive"
    /// <summary>
    /// An atomic property that contains a single number that is the maximum valid value (inclusive).
    /// <see href="http://www.w3.org/ns/shex#maxinclusive"></see></summary>
    let maxinclusive = _prefix "maxinclusive"
    /// <summary>
    /// A numeric atomic property that contains a single integer that is the maximum length of the value.
    /// <see href="http://www.w3.org/ns/shex#maxlength"></see></summary>
    let maxlength = _prefix "maxlength"
    /// <summary>
    /// Minimum number of times this TripleExpression may match.
    /// <see href="http://www.w3.org/ns/shex#min"></see></summary>
    let min = _prefix "min"
    /// <summary>
    /// An atomic property that contains a single number that is the minimum valid value (exclusive).
    /// <see href="http://www.w3.org/ns/shex#minexclusive"></see></summary>
    let minexclusive = _prefix "minexclusive"
    /// <summary>
    /// An atomic property that contains a single number that is the minimum valid value (inclusive).
    /// <see href="http://www.w3.org/ns/shex#mininclusive"></see></summary>
    let mininclusive = _prefix "mininclusive"
    /// <summary>
    /// An atomic property that contains a single integer that is the minimum length of the value.
    /// <see href="http://www.w3.org/ns/shex#minlength"></see></summary>
    let minlength = _prefix "minlength"
    /// <summary>
    /// Identifier of SemAct extension.
    /// <see href="http://www.w3.org/ns/shex#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Restiction on the kind of node matched; restricted to the defined instances of NodeKind. One of shex:iri, shex:bnode, shex:literal, or shex:nonliteral.
    /// <see href="http://www.w3.org/ns/shex#nodeKind"></see></summary>
    let nodeKind = _prefix "nodeKind"
    /// <summary>
    /// Requires node to be a Blank Node or IRI
    /// <see href="http://www.w3.org/ns/shex#nonliteral"></see></summary>
    let nonliteral = _prefix "nonliteral"
    /// <summary>
    /// An abstract property of string and numeric facets on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#xsFacet"></see></summary>
    let xsFacet = _prefix "xsFacet"
    /// <summary>
    /// The object of an Annotation.
    /// <see href="http://www.w3.org/ns/shex#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// A regular expression used for matching a value.
    /// <see href="http://www.w3.org/ns/shex#pattern"></see></summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// The predicate of a TripleConstraint or Annotation.
    /// <see href="http://www.w3.org/ns/shex#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// Semantic Actions on this TripleExpression.
    /// <see href="http://www.w3.org/ns/shex#semActs"></see></summary>
    let semActs = _prefix "semActs"
    /// <summary>
    /// Shape Expression referenced by this shape.
    /// <see href="http://www.w3.org/ns/shex#shapeExpr"></see></summary>
    let shapeExpr = _prefix "shapeExpr"
    /// <summary>
    /// A list of 2 or more Shape Expressions referenced by this shape.
    /// <see href="http://www.w3.org/ns/shex#shapeExprs"></see></summary>
    let shapeExprs = _prefix "shapeExprs"
    /// <summary>
    /// Shapes in this Schema.
    /// <see href="http://www.w3.org/ns/shex#shapes"></see></summary>
    let shapes = _prefix "shapes"
    /// <summary>
    /// A ShapeExpression matched against the focus node prior to any other mapped expressions.
    /// <see href="http://www.w3.org/ns/shex#start"></see></summary>
    let start = _prefix "start"
    /// <summary>
    /// Semantic Actions run on the Schema.
    /// <see href="http://www.w3.org/ns/shex#startActs"></see></summary>
    let startActs = _prefix "startActs"
    /// <summary>
    /// A stem value used for matching or excluding values.
    /// <see href="http://www.w3.org/ns/shex#stem"></see></summary>
    let stem = _prefix "stem"
    /// <summary>
    /// for "totaldigits" constraints, v equals the number of digits in the XML Schema canonical form[xmlschema-2] of the value of n
    /// <see href="http://www.w3.org/ns/shex#totaldigits"></see></summary>
    let totaldigits = _prefix "totaldigits"
    /// <summary>
    /// A ShapeExpression used for matching the object (or subject if inverted) of a TripleConstraint.
    /// <see href="http://www.w3.org/ns/shex#valueExpr"></see></summary>
    let valueExpr = _prefix "valueExpr"
    /// <summary>
    /// A value restriction on a NodeConstraint.
    /// <see href="http://www.w3.org/ns/shex#values"></see></summary>
    let values = _prefix "values"
