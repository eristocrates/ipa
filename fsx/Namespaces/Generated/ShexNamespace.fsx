#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module shex =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/shex#" "shex"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Annotation</para>
    ///   <para>rdfs:comment : Annotations provide a format-independent way to provide additional information about elements in a schema. </para>
    ///   <a href="http://www.w3.org/ns/shex#Annotation">shex:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:label : Each Of</para>
    ///   <para>rdfs:comment : A TripleExpression composed of one or more sub-expressions, all of which must match.</para>
    ///   <a href="http://www.w3.org/ns/shex#EachOf">shex:EachOf</a>
    /// </summary>
    let EachOf = _prefixId.prefix "EachOf"
    let FOCUS = _prefixId.prefix "FOCUS"
    /// <summary>
    ///   <para>rdfs:label : IRI Stem</para>
    ///   <para>rdfs:comment : An IRI prefix used for matching IRIs.</para>
    ///   <a href="http://www.w3.org/ns/shex#IriStem">shex:IriStem</a>
    /// </summary>
    let IriStem = _prefixId.prefix "IriStem"
    /// <summary>
    ///   <para>rdfs:label : IRI StemRange</para>
    ///   <para>rdfs:comment : An IRI prefix (or wildcard) along with a set of excluded values, used for node matching.</para>
    ///   <a href="http://www.w3.org/ns/shex#IriStemRange">shex:IriStemRange</a>
    /// </summary>
    let IriStemRange = _prefixId.prefix "IriStemRange"
    /// <summary>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : An Language tag used for matching Literal Languages.</para>
    ///   <a href="http://www.w3.org/ns/shex#Language">shex:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:label : Language Stem</para>
    ///   <para>rdfs:comment : An Language prefix used for matching Literal Languages.</para>
    ///   <a href="http://www.w3.org/ns/shex#LanguageStem">shex:LanguageStem</a>
    /// </summary>
    let LanguageStem = _prefixId.prefix "LanguageStem"
    /// <summary>
    ///   <para>rdfs:label : Language StemRange</para>
    ///   <para>rdfs:comment : An Language prefix (or wildcard) along with a set of excluded values, used for node matching.</para>
    ///   <a href="http://www.w3.org/ns/shex#LanguageStemRange">shex:LanguageStemRange</a>
    /// </summary>
    let LanguageStemRange = _prefixId.prefix "LanguageStemRange"
    /// <summary>
    ///   <para>rdfs:label : Literal Stem</para>
    ///   <para>rdfs:comment : An Literal prefix used for matching Literals.</para>
    ///   <a href="http://www.w3.org/ns/shex#LiteralStem">shex:LiteralStem</a>
    /// </summary>
    let LiteralStem = _prefixId.prefix "LiteralStem"
    /// <summary>
    ///   <para>rdfs:label : Literal StemRange</para>
    ///   <para>rdfs:comment : An Literal prefix (or wildcard) along with a set of excluded values, used for node matching.</para>
    ///   <a href="http://www.w3.org/ns/shex#LiteralStemRange">shex:LiteralStemRange</a>
    /// </summary>
    let LiteralStemRange = _prefixId.prefix "LiteralStemRange"
    /// <summary>
    ///   <para>rdfs:label : Node Constraint</para>
    ///   <para>rdfs:comment : A constraint on the type or value of an RDF Node.</para>
    ///   <a href="http://www.w3.org/ns/shex#NodeConstraint">shex:NodeConstraint</a>
    /// </summary>
    let NodeConstraint = _prefixId.prefix "NodeConstraint"
    /// <summary>
    ///   <para>rdfs:label : Node Kind</para>
    ///   <para>rdfs:comment : The set of kinds of RDF Nodes.</para>
    ///   <a href="http://www.w3.org/ns/shex#NodeKind">shex:NodeKind</a>
    /// </summary>
    let NodeKind = _prefixId.prefix "NodeKind"
    /// <summary>
    ///   <para>rdfs:label : One Of</para>
    ///   <para>rdfs:comment : A TripleExpression composed of one or more sub-expressions, one of which must match.</para>
    ///   <a href="http://www.w3.org/ns/shex#OneOf">shex:OneOf</a>
    /// </summary>
    let OneOf = _prefixId.prefix "OneOf"
    /// <summary>
    ///   <para>rdfs:label : Query Map</para>
    ///   <para>rdfs:comment : A map of node selectors to shape labels, used to select the nodes to be validated against particular shapes. Node selectors are RDF nodes or triple patterns.</para>
    ///   <a href="http://www.w3.org/ns/shex#QueryMap">shex:QueryMap</a>
    /// </summary>
    let QueryMap = _prefixId.prefix "QueryMap"
    /// <summary>
    ///   <para>rdfs:label : Schema</para>
    ///   <para>rdfs:comment : A Schema contains the set of shapes, used for matching a focus node.</para>
    ///   <a href="http://www.w3.org/ns/shex#Schema">shex:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    /// <summary>
    ///   <para>rdfs:label : Semantic Actions</para>
    ///   <para>rdfs:comment : A list of Semantic Actions that serve as an extension point for Shape Expressions. They appear in lists in Schema's startActs and Shape, OneOf, EachOf and TripleConstraint's semActs.</para>
    ///   <a href="http://www.w3.org/ns/shex#SemAct">shex:SemAct</a>
    /// </summary>
    let SemAct = _prefixId.prefix "SemAct"
    /// <summary>
    ///   <para>rdfs:label : Shape Or</para>
    ///   <para>rdfs:comment : A shapes schema is captured in a Schema object where shapes is a mapping from shape label to shape expression.</para>
    ///   <a href="http://www.w3.org/ns/shex#Shape">shex:Shape</a>
    /// </summary>
    let Shape = _prefixId.prefix "Shape"
    /// <summary>
    ///   <para>rdfs:label : Shape And</para>
    ///   <para>rdfs:comment : A ShapeExpression composed of one or more sub-expressions, all of which must match.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeAnd">shex:ShapeAnd</a>
    /// </summary>
    let ShapeAnd = _prefixId.prefix "ShapeAnd"
    /// <summary>
    ///   <para>rdfs:label : Shape Declaration</para>
    ///   <para>rdfs:comment : Associates a shape expression with a label, and optionally declares it abstract. The shapes in a Schema are ShapeDecls.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeDecl">shex:ShapeDecl</a>
    /// </summary>
    let ShapeDecl = _prefixId.prefix "ShapeDecl"
    /// <summary>
    ///   <para>rdfs:label : Shape Expression</para>
    ///   <para>rdfs:comment : The abstract class of Shape Expressions.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeExpression">shex:ShapeExpression</a>
    /// </summary>
    let ShapeExpression = _prefixId.prefix "ShapeExpression"
    /// <summary>
    ///   <para>rdfs:label : Shape External</para>
    ///   <para>rdfs:comment : A reference to a shape defined in some external Schema.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeExternal">shex:ShapeExternal</a>
    /// </summary>
    let ShapeExternal = _prefixId.prefix "ShapeExternal"
    /// <summary>
    ///   <para>rdfs:label : Shape Map</para>
    ///   <para>rdfs:comment : A QueryMap in which each node selector is an RDF node; associates RDF nodes with shapes, optionally recording the validation status of each association.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeMap">shex:ShapeMap</a>
    /// </summary>
    let ShapeMap = _prefixId.prefix "ShapeMap"
    /// <summary>
    ///   <para>rdfs:label : Shape Not</para>
    ///   <para>rdfs:comment : A ShapeNot is satisfied when it’s included ShapeExpression is not satisfied.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeNot">shex:ShapeNot</a>
    /// </summary>
    let ShapeNot = _prefixId.prefix "ShapeNot"
    /// <summary>
    ///   <para>rdfs:label : Shape Or</para>
    ///   <para>rdfs:comment : A ShapeExpression composed of one or more sub-expressions, one of which must match.</para>
    ///   <a href="http://www.w3.org/ns/shex#ShapeOr">shex:ShapeOr</a>
    /// </summary>
    let ShapeOr = _prefixId.prefix "ShapeOr"
    /// <summary>
    ///   <para>rdfs:label : Stem</para>
    ///   <para>rdfs:comment : Abstract class for Stems</para>
    ///   <a href="http://www.w3.org/ns/shex#Stem">shex:Stem</a>
    /// </summary>
    let Stem = _prefixId.prefix "Stem"
    /// <summary>
    ///   <para>rdfs:label : StemRange</para>
    ///   <para>rdfs:comment : Abstract Class for Stem Ranges</para>
    ///   <a href="http://www.w3.org/ns/shex#StemRange">shex:StemRange</a>
    /// </summary>
    let StemRange = _prefixId.prefix "StemRange"
    /// <summary>
    ///   <para>rdfs:label : Triple Constraint</para>
    ///   <para>rdfs:comment : A constraint on a triple having a specific predicate and optionally a shape expression used for matching values.</para>
    ///   <a href="http://www.w3.org/ns/shex#TripleConstraint">shex:TripleConstraint</a>
    /// </summary>
    let TripleConstraint = _prefixId.prefix "TripleConstraint"
    /// <summary>
    ///   <para>rdfs:label : Triple Expression</para>
    ///   <para>rdfs:comment : The abstract class of Triple Expressions.</para>
    ///   <a href="http://www.w3.org/ns/shex#TripleExpression">shex:TripleExpression</a>
    /// </summary>
    let TripleExpression = _prefixId.prefix "TripleExpression"
    /// <summary>
    ///   <para>rdfs:label : Wildcard</para>
    ///   <para>rdfs:comment : Indicates that a stem is a Wildcard, rather than a URI prefix.</para>
    ///   <a href="http://www.w3.org/ns/shex#Wildcard">shex:Wildcard</a>
    /// </summary>
    let Wildcard = _prefixId.prefix "Wildcard"
    let _ = _prefixId.prefix "_"
    /// <summary>
    ///   <para>rdfs:label : abstract</para>
    ///   <para>rdfs:comment : Declares a ShapeDecl abstract, meaning that every reference to it must also identify at least one non-abstract shape.</para>
    ///   <a href="http://www.w3.org/ns/shex#abstract">shex:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : annotation</para>
    ///   <para>rdfs:comment : Annotations on a TripleExpression.</para>
    ///   <a href="http://www.w3.org/ns/shex#annotation">shex:annotation</a>
    /// </summary>
    let annotation = _prefixId.prefix "annotation"
    let bnode = _prefixId.prefix "bnode"
    /// <summary>
    ///   <para>rdfs:label : closed</para>
    ///   <para>rdfs:comment : Indicates that a Shape is closed, meaning that it may contain no property values other than those used within TripleConstraints.</para>
    ///   <a href="http://www.w3.org/ns/shex#closed">shex:closed</a>
    /// </summary>
    let closed = _prefixId.prefix "closed"
    /// <summary>
    ///   <para>rdfs:label : code</para>
    ///   <para>rdfs:comment : Code executed by Semantic Action.</para>
    ///   <a href="http://www.w3.org/ns/shex#code">shex:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:label : datatype</para>
    ///   <para>rdfs:comment : A datatype constraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#datatype">shex:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    /// <summary>
    ///   <para>rdfs:label : exclusion</para>
    ///   <para>rdfs:comment : Values that are excluded from value matching.</para>
    ///   <a href="http://www.w3.org/ns/shex#exclusion">shex:exclusion</a>
    /// </summary>
    let exclusion = _prefixId.prefix "exclusion"
    /// <summary>
    ///   <para>rdfs:label : expression</para>
    ///   <para>rdfs:comment : Expression associated with the TripleExpression.</para>
    ///   <a href="http://www.w3.org/ns/shex#expression">shex:expression</a>
    /// </summary>
    let expression = _prefixId.prefix "expression"
    /// <summary>
    ///   <para>rdfs:label : expressions</para>
    ///   <para>rdfs:comment : List of 2 or more expressions associated with the TripleExpression.</para>
    ///   <a href="http://www.w3.org/ns/shex#expressions">shex:expressions</a>
    /// </summary>
    let expressions = _prefixId.prefix "expressions"
    /// <summary>
    ///   <para>rdfs:label : extends</para>
    ///   <para>rdfs:comment : Base shape expressions for this shape.</para>
    ///   <a href="http://www.w3.org/ns/shex#extends">shex:extends</a>
    /// </summary>
    let extends = _prefixId.prefix "extends"
    /// <summary>
    ///   <para>rdfs:label : extra</para>
    ///   <para>rdfs:comment : Properties which may have extra values beyond those matched through a constraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#extra">shex:extra</a>
    /// </summary>
    let extra = _prefixId.prefix "extra"
    /// <summary>
    ///   <para>rdfs:label : flags</para>
    ///   <para>rdfs:comment : Regular expression flags</para>
    ///   <a href="http://www.w3.org/ns/shex#flags">shex:flags</a>
    /// </summary>
    let flags = _prefixId.prefix "flags"
    /// <summary>
    ///   <para>rdfs:label : fraction digits</para>
    ///   <para>rdfs:comment : for "fractiondigits" constraints, v is less than or equals the number of digits to the right of the decimal place in the XML Schema canonical form[xmlschema-2] of the value of n, ignoring trailing zeros.</para>
    ///   <a href="http://www.w3.org/ns/shex#fractiondigits">shex:fractiondigits</a>
    /// </summary>
    let fractiondigits = _prefixId.prefix "fractiondigits"
    /// <summary>
    ///   <para>rdfs:label : imports</para>
    ///   <para>rdfs:comment : Schemas imported by this Schema; their shape and triple expression labels are also in scope here.</para>
    ///   <a href="http://www.w3.org/ns/shex#imports">shex:imports</a>
    /// </summary>
    let imports = _prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:label : inverse</para>
    ///   <para>rdfs:comment : Constrains the subject of a triple, rather than the object.</para>
    ///   <a href="http://www.w3.org/ns/shex#inverse">shex:inverse</a>
    /// </summary>
    let inverse = _prefixId.prefix "inverse"
    let iri = _prefixId.prefix "iri"
    /// <summary>
    ///   <para>rdfs:label : language tag</para>
    ///   <para>rdfs:comment : The value used to match the language tag of a language-tagged string.</para>
    ///   <a href="http://www.w3.org/ns/shex#languageTag">shex:languageTag</a>
    /// </summary>
    let languageTag = _prefixId.prefix "languageTag"
    /// <summary>
    ///   <para>rdfs:label : length</para>
    ///   <para>rdfs:comment : The exact length of the value of the cell.</para>
    ///   <a href="http://www.w3.org/ns/shex#length">shex:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    let literal = _prefixId.prefix "literal"
    /// <summary>
    ///   <para>rdfs:label : maximum cardinality</para>
    ///   <para>rdfs:comment : Maximum number of times this TripleExpression may match; -1 for “*”</para>
    ///   <a href="http://www.w3.org/ns/shex#max">shex:max</a>
    /// </summary>
    let max = _prefixId.prefix "max"
    /// <summary>
    ///   <para>rdfs:label : max exclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the maximum valid value (exclusive).</para>
    ///   <a href="http://www.w3.org/ns/shex#maxexclusive">shex:maxexclusive</a>
    /// </summary>
    let maxexclusive = _prefixId.prefix "maxexclusive"
    /// <summary>
    ///   <para>rdfs:label : max inclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the maximum valid value (inclusive).</para>
    ///   <a href="http://www.w3.org/ns/shex#maxinclusive">shex:maxinclusive</a>
    /// </summary>
    let maxinclusive = _prefixId.prefix "maxinclusive"
    /// <summary>
    ///   <para>rdfs:label : max length</para>
    ///   <para>rdfs:comment : A numeric atomic property that contains a single integer that is the maximum length of the value.</para>
    ///   <a href="http://www.w3.org/ns/shex#maxlength">shex:maxlength</a>
    /// </summary>
    let maxlength = _prefixId.prefix "maxlength"
    /// <summary>
    ///   <para>rdfs:label : minimum cardinatliy</para>
    ///   <para>rdfs:comment : Minimum number of times this TripleExpression may match.</para>
    ///   <a href="http://www.w3.org/ns/shex#min">shex:min</a>
    /// </summary>
    let min = _prefixId.prefix "min"
    /// <summary>
    ///   <para>rdfs:label : min exclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the minimum valid value (exclusive).</para>
    ///   <a href="http://www.w3.org/ns/shex#minexclusive">shex:minexclusive</a>
    /// </summary>
    let minexclusive = _prefixId.prefix "minexclusive"
    /// <summary>
    ///   <para>rdfs:label : min inclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the minimum valid value (inclusive).</para>
    ///   <a href="http://www.w3.org/ns/shex#mininclusive">shex:mininclusive</a>
    /// </summary>
    let mininclusive = _prefixId.prefix "mininclusive"
    /// <summary>
    ///   <para>rdfs:label : min length</para>
    ///   <para>rdfs:comment : An atomic property that contains a single integer that is the minimum length of the value.</para>
    ///   <a href="http://www.w3.org/ns/shex#minlength">shex:minlength</a>
    /// </summary>
    let minlength = _prefixId.prefix "minlength"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : Identifier of SemAct extension.</para>
    ///   <a href="http://www.w3.org/ns/shex#name">shex:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : node</para>
    ///   <para>rdfs:comment : An RDF node, or a triple pattern which is used to select RDF nodes to be validated.</para>
    ///   <a href="http://www.w3.org/ns/shex#node">shex:node</a>
    /// </summary>
    let node = _prefixId.prefix "node"
    /// <summary>
    ///   <para>rdfs:label : node kind</para>
    ///   <para>rdfs:comment : Restiction on the kind of node matched; restricted to the defined instances of NodeKind. One of shex:iri, shex:bnode, shex:literal, or shex:nonliteral.</para>
    ///   <a href="http://www.w3.org/ns/shex#nodeKind">shex:nodeKind</a>
    /// </summary>
    let nodeKind = _prefixId.prefix "nodeKind"
    let nonliteral = _prefixId.prefix "nonliteral"
    /// <summary>
    ///   <para>rdfs:label : </para>
    ///   <para>rdfs:comment : Abstract property of numeric facets on a NodeConstraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#numericFacet">shex:numericFacet</a>
    /// </summary>
    let numericFacet = _prefixId.prefix "numericFacet"
    /// <summary>
    ///   <para>rdfs:label : object</para>
    ///   <para>rdfs:comment : The object of an Annotation.</para>
    ///   <a href="http://www.w3.org/ns/shex#object">shex:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:label : pattern</para>
    ///   <para>rdfs:comment : A regular expression used for matching a value.</para>
    ///   <a href="http://www.w3.org/ns/shex#pattern">shex:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:label : predicate</para>
    ///   <para>rdfs:comment : The predicate of a TripleConstraint or Annotation.</para>
    ///   <a href="http://www.w3.org/ns/shex#predicate">shex:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:label : semantic action</para>
    ///   <para>rdfs:comment : Semantic Actions on this TripleExpression.</para>
    ///   <a href="http://www.w3.org/ns/shex#semActs">shex:semActs</a>
    /// </summary>
    let semActs = _prefixId.prefix "semActs"
    /// <summary>
    ///   <para>rdfs:label : shape</para>
    ///   <para>rdfs:comment : A ShEx shape expression label identifying the shape expression against which the selected nodes are validated, or the string "START" for the schema's start shape expression.</para>
    ///   <a href="http://www.w3.org/ns/shex#shape">shex:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>rdfs:label : shape expression</para>
    ///   <para>rdfs:comment : Shape Expression referenced by this shape or shape declaration.</para>
    ///   <a href="http://www.w3.org/ns/shex#shapeExpr">shex:shapeExpr</a>
    /// </summary>
    let shapeExpr = _prefixId.prefix "shapeExpr"
    /// <summary>
    ///   <para>rdfs:label : shape expressions</para>
    ///   <para>rdfs:comment : A list of 2 or more Shape Expressions referenced by this shape.</para>
    ///   <a href="http://www.w3.org/ns/shex#shapeExprs">shex:shapeExprs</a>
    /// </summary>
    let shapeExprs = _prefixId.prefix "shapeExprs"
    /// <summary>
    ///   <para>rdfs:label : shapes</para>
    ///   <para>rdfs:comment : Shape declarations in this Schema.</para>
    ///   <a href="http://www.w3.org/ns/shex#shapes">shex:shapes</a>
    /// </summary>
    let shapes = _prefixId.prefix "shapes"
    /// <summary>
    ///   <para>rdfs:label : start</para>
    ///   <para>rdfs:comment : A ShapeExpression matched against the focus node prior to any other mapped expressions.</para>
    ///   <a href="http://www.w3.org/ns/shex#start">shex:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    /// <summary>
    ///   <para>rdfs:label : start actions</para>
    ///   <para>rdfs:comment : Semantic Actions run on the Schema.</para>
    ///   <a href="http://www.w3.org/ns/shex#startActs">shex:startActs</a>
    /// </summary>
    let startActs = _prefixId.prefix "startActs"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : The validation status of a node/shape association: "conformant" or "nonconformant". Defaults to "conformant".</para>
    ///   <a href="http://www.w3.org/ns/shex#status">shex:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : stem</para>
    ///   <para>rdfs:comment : A stem value used for matching or excluding values.</para>
    ///   <a href="http://www.w3.org/ns/shex#stem">shex:stem</a>
    /// </summary>
    let stem = _prefixId.prefix "stem"
    /// <summary>
    ///   <para>rdfs:label : </para>
    ///   <para>rdfs:comment : An abstract property of string facets on a NodeConstraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#stringFacet">shex:stringFacet</a>
    /// </summary>
    let stringFacet = _prefixId.prefix "stringFacet"
    /// <summary>
    ///   <para>rdfs:label : total digits</para>
    ///   <para>rdfs:comment : for "totaldigits" constraints, v equals the number of digits in the XML Schema canonical form[xmlschema-2] of the value of n</para>
    ///   <a href="http://www.w3.org/ns/shex#totaldigits">shex:totaldigits</a>
    /// </summary>
    let totaldigits = _prefixId.prefix "totaldigits"
    /// <summary>
    ///   <para>rdfs:label : value expression</para>
    ///   <para>rdfs:comment : A ShapeExpression used for matching the object (or subject if inverted) of a TripleConstraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#valueExpr">shex:valueExpr</a>
    /// </summary>
    let valueExpr = _prefixId.prefix "valueExpr"
    /// <summary>
    ///   <para>rdfs:label : values</para>
    ///   <para>rdfs:comment : A value restriction on a NodeConstraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#values">shex:values</a>
    /// </summary>
    let values = _prefixId.prefix "values"
    /// <summary>
    ///   <para>rdfs:label : </para>
    ///   <para>rdfs:comment : An abstract property of string and numeric facets on a NodeConstraint.</para>
    ///   <a href="http://www.w3.org/ns/shex#xsFacet">shex:xsFacet</a>
    /// </summary>
    let xsFacet = _prefixId.prefix "xsFacet"
