namespace http.www.w3.org.ns.shex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module shex =
    let _namespace_iri = Namespace_Iri shex |> NamespaceIRI
    /// <summary>
    ///   <para>shex:EachOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TripleExpression composed of one or more sub-expressions, all of which must match.</para>
    /// labels<para>Each Of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#EachOf">http://www.w3.org/ns/shex#EachOf</seealso>
    let EachOf = Prefixed_Name(shex, "EachOf") |> PrefixedName
    /// <summary>
    ///   <para>shex:IriStem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An IRI prefix used for matching IRIs.</para>
    /// labels<para>IRI Stem</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#IriStem">http://www.w3.org/ns/shex#IriStem</seealso>
    let IriStem = Prefixed_Name(shex, "IriStem") |> PrefixedName
    /// <summary>
    ///   <para>shex:IriStemRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An IRI prefix (or wildcard) along with a set of excluded values, used for node matching.</para>
    /// labels<para>IRI StemRange</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#IriStemRange">http://www.w3.org/ns/shex#IriStemRange</seealso>
    let IriStemRange = Prefixed_Name(shex, "IriStemRange") |> PrefixedName
    /// <summary>
    ///   <para>shex:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Language tag used for matching Literal Languages.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#Language">http://www.w3.org/ns/shex#Language</seealso>
    let Language = Prefixed_Name(shex, "Language") |> PrefixedName
    /// <summary>
    ///   <para>shex:LanguageStem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Language prefix used for matching Literal Languages.</para>
    /// labels<para>Language Stem</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#LanguageStem">http://www.w3.org/ns/shex#LanguageStem</seealso>
    let LanguageStem = Prefixed_Name(shex, "LanguageStem") |> PrefixedName
    /// <summary>
    ///   <para>shex:LiteralStem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Literal prefix used for matching Literals.</para>
    /// labels<para>Literal Stem</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#LiteralStem">http://www.w3.org/ns/shex#LiteralStem</seealso>
    let LiteralStem = Prefixed_Name(shex, "LiteralStem") |> PrefixedName
    /// <summary>
    ///   <para>shex:NodeConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A constraint on the type or value of an RDF Node.</para>
    /// labels<para>Node Constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#NodeConstraint">http://www.w3.org/ns/shex#NodeConstraint</seealso>
    let NodeConstraint = Prefixed_Name(shex, "NodeConstraint") |> PrefixedName
    /// <summary>
    ///   <para>shex:fractiondigits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>for "fractiondigits" constraints, v is less than or equals the number of digits to the right of the decimal place in the XML Schema canonical form[xmlschema-2] of the value of n, ignoring trailing zeros.</para>
    /// labels<para>fraction digits</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#fractiondigits">http://www.w3.org/ns/shex#fractiondigits</seealso>
    let fractiondigits = Prefixed_Name(shex, "fractiondigits") |> PrefixedName
    /// <summary>
    ///   <para>shex:inverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Constrains the subject of a triple, rather than the object.</para>
    /// labels<para>inverse</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#inverse">http://www.w3.org/ns/shex#inverse</seealso>
    let inverse = Prefixed_Name(shex, "inverse") |> PrefixedName
    /// <summary>
    ///   <para>shex:iri</para>
    /// </summary>
    /// <remarks>
    ///   <para>shex:NodeKind</para>
    ///   <para>Requires node to be an IRI</para>
    /// labels<para>iri</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#iri">http://www.w3.org/ns/shex#iri</seealso>
    let iri = Prefixed_Name(shex, "iri") |> PrefixedName
    /// <summary>
    ///   <para>shex:stringFacet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An abstract property of string facets on a NodeConstraint.</para>
    /// labels<para></para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#stringFacet">http://www.w3.org/ns/shex#stringFacet</seealso>
    let stringFacet = Prefixed_Name(shex, "stringFacet") |> PrefixedName
    /// <summary>
    ///   <para>shex:literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>shex:NodeKind</para>
    ///   <para>Requires node to be an rdf:Literal</para>
    /// labels<para>literal</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#literal">http://www.w3.org/ns/shex#literal</seealso>
    let literal = Prefixed_Name(shex, "literal") |> PrefixedName
    /// <summary>
    ///   <para>shex:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Annotations provide a format-independent way to provide additional information about elements in a schema. </para>
    /// labels<para>Annotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#Annotation">http://www.w3.org/ns/shex#Annotation</seealso>
    let Annotation = Prefixed_Name(shex, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>shex:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Schema contains the set of shapes, used for matching a focus node.</para>
    /// labels<para>Schema</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#Schema">http://www.w3.org/ns/shex#Schema</seealso>
    let Schema = Prefixed_Name(shex, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>shex:Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shapes schema is captured in a Schema object where shapes is a mapping from shape label to shape expression.</para>
    /// labels<para>Shape Or</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#Shape">http://www.w3.org/ns/shex#Shape</seealso>
    let Shape = Prefixed_Name(shex, "Shape") |> PrefixedName
    /// <summary>
    ///   <para>shex:ShapeExternal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reference to a shape defined in some external Schema.</para>
    /// labels<para>Shape External</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#ShapeExternal">http://www.w3.org/ns/shex#ShapeExternal</seealso>
    let ShapeExternal = Prefixed_Name(shex, "ShapeExternal") |> PrefixedName
    /// <summary>
    ///   <para>shex:annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Annotations on a TripleExpression.</para>
    /// labels<para>annotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#annotation">http://www.w3.org/ns/shex#annotation</seealso>
    let annotation = Prefixed_Name(shex, "annotation") |> PrefixedName
    /// <summary>
    ///   <para>shex:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A datatype constraint.</para>
    /// labels<para>datatype</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#datatype">http://www.w3.org/ns/shex#datatype</seealso>
    let datatype = Prefixed_Name(shex, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>shex:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expression associated with the TripleExpression.</para>
    /// labels<para>expression</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#expression">http://www.w3.org/ns/shex#expression</seealso>
    let expression = Prefixed_Name(shex, "expression") |> PrefixedName
    /// <summary>
    ///   <para>shex:extra</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Properties which may have extra values beyond those matched through a constraint.</para>
    /// labels<para>extra</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#extra">http://www.w3.org/ns/shex#extra</seealso>
    let extra = Prefixed_Name(shex, "extra") |> PrefixedName
    /// <summary>
    ///   <para>shex:flags</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Regular expression flags</para>
    /// labels<para>flags</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#flags">http://www.w3.org/ns/shex#flags</seealso>
    let flags = Prefixed_Name(shex, "flags") |> PrefixedName
    /// <summary>
    ///   <para>shex:numericFacet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Abstract property of numeric facets on a NodeConstraint.</para>
    /// labels<para></para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#numericFacet">http://www.w3.org/ns/shex#numericFacet</seealso>
    let numericFacet = Prefixed_Name(shex, "numericFacet") |> PrefixedName
    /// <summary>
    ///   <para>shex:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Minimum number of times this TripleExpression may match.</para>
    /// labels<para>minimum cardinatliy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#min">http://www.w3.org/ns/shex#min</seealso>
    let min = Prefixed_Name(shex, "min") |> PrefixedName
    /// <summary>
    ///   <para>shex:totaldigits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>for "totaldigits" constraints, v equals the number of digits in the XML Schema canonical form[xmlschema-2] of the value of n</para>
    /// labels<para>total digits</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#totaldigits">http://www.w3.org/ns/shex#totaldigits</seealso>
    let totaldigits = Prefixed_Name(shex, "totaldigits") |> PrefixedName
    /// <summary>
    ///   <para>shex:minlength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An atomic property that contains a single integer that is the minimum length of the value.</para>
    /// labels<para>min length</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#minlength">http://www.w3.org/ns/shex#minlength</seealso>
    let minlength = Prefixed_Name(shex, "minlength") |> PrefixedName
    /// <summary>
    ///   <para>shex:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A regular expression used for matching a value.</para>
    /// labels<para>pattern</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#pattern">http://www.w3.org/ns/shex#pattern</seealso>
    let pattern = Prefixed_Name(shex, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>shex:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The predicate of a TripleConstraint or Annotation.</para>
    /// labels<para>predicate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#predicate">http://www.w3.org/ns/shex#predicate</seealso>
    let predicate = Prefixed_Name(shex, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>shex:shapes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shapes in this Schema.</para>
    /// labels<para>shapes</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#shapes">http://www.w3.org/ns/shex#shapes</seealso>
    let shapes = Prefixed_Name(shex, "shapes") |> PrefixedName
    /// <summary>
    ///   <para>shex:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shex#">http://www.w3.org/ns/shex#</seealso>
    let _prefix_iri = Prefixed_Name(shex, "") |> PrefixedName
    /// <summary>
    ///   <para>shex:TripleExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The abstract class of Triple Expressions.</para>
    /// labels<para>Triple Expression</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#TripleExpression">http://www.w3.org/ns/shex#TripleExpression</seealso>
    let TripleExpression = Prefixed_Name(shex, "TripleExpression") |> PrefixedName
    /// <summary>
    ///   <para>shex:Stem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract class for Stems</para>
    /// labels<para>Stem</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#Stem">http://www.w3.org/ns/shex#Stem</seealso>
    let Stem = Prefixed_Name(shex, "Stem") |> PrefixedName
    /// <summary>
    ///   <para>shex:StemRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract Class for Stem Ranges</para>
    /// labels<para>StemRange</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#StemRange">http://www.w3.org/ns/shex#StemRange</seealso>
    let StemRange = Prefixed_Name(shex, "StemRange") |> PrefixedName
    /// <summary>
    ///   <para>shex:LanguageStemRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Language prefix (or wildcard) along with a set of excluded values, used for node matching.</para>
    /// labels<para>Language StemRange</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#LanguageStemRange">http://www.w3.org/ns/shex#LanguageStemRange</seealso>
    let LanguageStemRange = Prefixed_Name(shex, "LanguageStemRange") |> PrefixedName
    /// <summary>
    ///   <para>shex:LiteralStemRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Literal prefix (or wildcard) along with a set of excluded values, used for node matching.</para>
    /// labels<para>Literal StemRange</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#LiteralStemRange">http://www.w3.org/ns/shex#LiteralStemRange</seealso>
    let LiteralStemRange = Prefixed_Name(shex, "LiteralStemRange") |> PrefixedName
    /// <summary>
    ///   <para>shex:ShapeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The abstract class of Shape Expressions.</para>
    /// labels<para>Shape Expression</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#ShapeExpression">http://www.w3.org/ns/shex#ShapeExpression</seealso>
    let ShapeExpression = Prefixed_Name(shex, "ShapeExpression") |> PrefixedName
    /// <summary>
    ///   <para>shex:NodeKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The set of kinds of RDF Nodes.</para>
    /// labels<para>Node Kind</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#NodeKind">http://www.w3.org/ns/shex#NodeKind</seealso>
    let NodeKind = Prefixed_Name(shex, "NodeKind") |> PrefixedName
    /// <summary>
    ///   <para>shex:OneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TripleExpression composed of one or more sub-expressions, one of which must match.</para>
    /// labels<para>One Of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#OneOf">http://www.w3.org/ns/shex#OneOf</seealso>
    let OneOf = Prefixed_Name(shex, "OneOf") |> PrefixedName
    /// <summary>
    ///   <para>shex:SemAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A list of Semantic Actions that serve as an extension point for Shape Expressions. They appear in lists in Schema's startActs and Shape, OneOf, EachOf and TripleConstraint's semActs.</para>
    /// labels<para>Semantic Actions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#SemAct">http://www.w3.org/ns/shex#SemAct</seealso>
    let SemAct = Prefixed_Name(shex, "SemAct") |> PrefixedName
    /// <summary>
    ///   <para>shex:ShapeAnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ShapeExpression composed of one or more sub-expressions, all of which must match.</para>
    /// labels<para>Shape And</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#ShapeAnd">http://www.w3.org/ns/shex#ShapeAnd</seealso>
    let ShapeAnd = Prefixed_Name(shex, "ShapeAnd") |> PrefixedName
    /// <summary>
    ///   <para>shex:ShapeNot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ShapeNot is satisfied when it’s included ShapeExpression is not satisfied.</para>
    /// labels<para>Shape Not</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#ShapeNot">http://www.w3.org/ns/shex#ShapeNot</seealso>
    let ShapeNot = Prefixed_Name(shex, "ShapeNot") |> PrefixedName
    /// <summary>
    ///   <para>shex:ShapeOr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ShapeExpression composed of one or more sub-expressions, one of which must match.</para>
    /// labels<para>Shape Or</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#ShapeOr">http://www.w3.org/ns/shex#ShapeOr</seealso>
    let ShapeOr = Prefixed_Name(shex, "ShapeOr") |> PrefixedName
    /// <summary>
    ///   <para>shex:TripleConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A constraint on a triple having a specific predicate and optionally a shape expression used for matching values.</para>
    /// labels<para>Triple Constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#TripleConstraint">http://www.w3.org/ns/shex#TripleConstraint</seealso>
    let TripleConstraint = Prefixed_Name(shex, "TripleConstraint") |> PrefixedName
    /// <summary>
    ///   <para>shex:Wildcard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Indicates that a stem is a Wildcard, rather than a URI prefix.</para>
    /// labels<para>Wildcard</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#Wildcard">http://www.w3.org/ns/shex#Wildcard</seealso>
    let Wildcard = Prefixed_Name(shex, "Wildcard") |> PrefixedName
    /// <summary>
    ///   <para>shex:bnode</para>
    /// </summary>
    /// <remarks>
    ///   <para>shex:NodeKind</para>
    ///   <para>Requires node to be a Blank Node</para>
    /// labels<para>bnode</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#bnode">http://www.w3.org/ns/shex#bnode</seealso>
    let bnode = Prefixed_Name(shex, "bnode") |> PrefixedName
    /// <summary>
    ///   <para>shex:closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a Shape is closed, meaning that it may contain no property values other than those used within TripleConstraints.</para>
    /// labels<para>closed</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#closed">http://www.w3.org/ns/shex#closed</seealso>
    let closed = Prefixed_Name(shex, "closed") |> PrefixedName
    /// <summary>
    ///   <para>shex:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Code executed by Semantic Action.</para>
    /// labels<para>code</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#code">http://www.w3.org/ns/shex#code</seealso>
    let code = Prefixed_Name(shex, "code") |> PrefixedName
    /// <summary>
    ///   <para>shex:exclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Values that are excluded from value matching.</para>
    /// labels<para>exclusion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#exclusion">http://www.w3.org/ns/shex#exclusion</seealso>
    let exclusion = Prefixed_Name(shex, "exclusion") |> PrefixedName
    /// <summary>
    ///   <para>shex:expressions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>List of 2 or more expressions associated with the TripleExpression.</para>
    /// labels<para>expressions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#expressions">http://www.w3.org/ns/shex#expressions</seealso>
    let expressions = Prefixed_Name(shex, "expressions") |> PrefixedName
    /// <summary>
    ///   <para>shex:extends</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Base shape expressions for this shape.</para>
    /// labels<para>extends</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#extends">http://www.w3.org/ns/shex#extends</seealso>
    let extends = Prefixed_Name(shex, "extends") |> PrefixedName
    /// <summary>
    ///   <para>shex:languageTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value used to match the language tag of a language-tagged string.</para>
    /// labels<para>language tag</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#languageTag">http://www.w3.org/ns/shex#languageTag</seealso>
    let languageTag = Prefixed_Name(shex, "languageTag") |> PrefixedName
    /// <summary>
    ///   <para>shex:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The exact length of the value of the cell.</para>
    /// labels<para>length</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#length">http://www.w3.org/ns/shex#length</seealso>
    let length = Prefixed_Name(shex, "length") |> PrefixedName
    /// <summary>
    ///   <para>shex:max</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Maximum number of times this TripleExpression may match; -1 for “*”</para>
    /// labels<para>maximum cardinality</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#max">http://www.w3.org/ns/shex#max</seealso>
    let max = Prefixed_Name(shex, "max") |> PrefixedName
    /// <summary>
    ///   <para>shex:maxexclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An atomic property that contains a single number that is the maximum valid value (exclusive).</para>
    /// labels<para>max exclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#maxexclusive">http://www.w3.org/ns/shex#maxexclusive</seealso>
    let maxexclusive = Prefixed_Name(shex, "maxexclusive") |> PrefixedName
    /// <summary>
    ///   <para>shex:maxinclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An atomic property that contains a single number that is the maximum valid value (inclusive).</para>
    /// labels<para>max inclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#maxinclusive">http://www.w3.org/ns/shex#maxinclusive</seealso>
    let maxinclusive = Prefixed_Name(shex, "maxinclusive") |> PrefixedName
    /// <summary>
    ///   <para>shex:maxlength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A numeric atomic property that contains a single integer that is the maximum length of the value.</para>
    /// labels<para>max length</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#maxlength">http://www.w3.org/ns/shex#maxlength</seealso>
    let maxlength = Prefixed_Name(shex, "maxlength") |> PrefixedName
    /// <summary>
    ///   <para>shex:minexclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An atomic property that contains a single number that is the minimum valid value (exclusive).</para>
    /// labels<para>min exclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#minexclusive">http://www.w3.org/ns/shex#minexclusive</seealso>
    let minexclusive = Prefixed_Name(shex, "minexclusive") |> PrefixedName
    /// <summary>
    ///   <para>shex:mininclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An atomic property that contains a single number that is the minimum valid value (inclusive).</para>
    /// labels<para>min inclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#mininclusive">http://www.w3.org/ns/shex#mininclusive</seealso>
    let mininclusive = Prefixed_Name(shex, "mininclusive") |> PrefixedName
    /// <summary>
    ///   <para>shex:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifier of SemAct extension.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#name">http://www.w3.org/ns/shex#name</seealso>
    let name = Prefixed_Name(shex, "name") |> PrefixedName
    /// <summary>
    ///   <para>shex:nodeKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Restiction on the kind of node matched; restricted to the defined instances of NodeKind. One of shex:iri, shex:bnode, shex:literal, or shex:nonliteral.</para>
    /// labels<para>node kind</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#nodeKind">http://www.w3.org/ns/shex#nodeKind</seealso>
    let nodeKind = Prefixed_Name(shex, "nodeKind") |> PrefixedName
    /// <summary>
    ///   <para>shex:nonliteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>shex:NodeKind</para>
    ///   <para>Requires node to be a Blank Node or IRI</para>
    /// labels<para>nonliteral</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#nonliteral">http://www.w3.org/ns/shex#nonliteral</seealso>
    let nonliteral = Prefixed_Name(shex, "nonliteral") |> PrefixedName
    /// <summary>
    ///   <para>shex:xsFacet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An abstract property of string and numeric facets on a NodeConstraint.</para>
    /// labels<para></para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#xsFacet">http://www.w3.org/ns/shex#xsFacet</seealso>
    let xsFacet = Prefixed_Name(shex, "xsFacet") |> PrefixedName
    /// <summary>
    ///   <para>shex:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of an Annotation.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#object">http://www.w3.org/ns/shex#object</seealso>
    let object = Prefixed_Name(shex, "object") |> PrefixedName
    /// <summary>
    ///   <para>shex:semActs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Semantic Actions on this TripleExpression.</para>
    /// labels<para>semantic action</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#semActs">http://www.w3.org/ns/shex#semActs</seealso>
    let semActs = Prefixed_Name(shex, "semActs") |> PrefixedName
    /// <summary>
    ///   <para>shex:shapeExpr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shape Expression referenced by this shape.</para>
    /// labels<para>shape expression</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#shapeExpr">http://www.w3.org/ns/shex#shapeExpr</seealso>
    let shapeExpr = Prefixed_Name(shex, "shapeExpr") |> PrefixedName
    /// <summary>
    ///   <para>shex:shapeExprs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list of 2 or more Shape Expressions referenced by this shape.</para>
    /// labels<para>shape expressions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#shapeExprs">http://www.w3.org/ns/shex#shapeExprs</seealso>
    let shapeExprs = Prefixed_Name(shex, "shapeExprs") |> PrefixedName
    /// <summary>
    ///   <para>shex:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A ShapeExpression matched against the focus node prior to any other mapped expressions.</para>
    /// labels<para>start</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#start">http://www.w3.org/ns/shex#start</seealso>
    let start = Prefixed_Name(shex, "start") |> PrefixedName
    /// <summary>
    ///   <para>shex:startActs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Semantic Actions run on the Schema.</para>
    /// labels<para>start actions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#startActs">http://www.w3.org/ns/shex#startActs</seealso>
    let startActs = Prefixed_Name(shex, "startActs") |> PrefixedName
    /// <summary>
    ///   <para>shex:stem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A stem value used for matching or excluding values.</para>
    /// labels<para>stem</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#stem">http://www.w3.org/ns/shex#stem</seealso>
    let stem = Prefixed_Name(shex, "stem") |> PrefixedName
    /// <summary>
    ///   <para>shex:valueExpr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A ShapeExpression used for matching the object (or subject if inverted) of a TripleConstraint.</para>
    /// labels<para>value expression</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#valueExpr">http://www.w3.org/ns/shex#valueExpr</seealso>
    let valueExpr = Prefixed_Name(shex, "valueExpr") |> PrefixedName
    /// <summary>
    ///   <para>shex:values</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A value restriction on a NodeConstraint.</para>
    /// labels<para>values</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shex#values">http://www.w3.org/ns/shex#values</seealso>
    let values = Prefixed_Name(shex, "values") |> PrefixedName
