namespace http.www.w3.org.ns.shacl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module shacl =
    let _namespace_iri = Namespace_Iri shacl |> NamespaceIRI
    /// <summary>
    ///   <para>shacl:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The prefix of a prefix declaration.</para>
    /// labels<para>prefix</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#prefix">http://www.w3.org/ns/shacl#prefix</seealso>
    let prefix = Prefixed_Name(shacl, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>shacl:namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The namespace associated with a prefix in a prefix declaration.</para>
    /// labels<para>namespace</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#namespace">http://www.w3.org/ns/shacl#namespace</seealso>
    let namespace_ = Prefixed_Name(shacl, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>shacl:AbstractResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The base class of validation results, typically not instantiated directly.</para>
    /// labels<para>Abstract result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#AbstractResult">http://www.w3.org/ns/shacl#AbstractResult</seealso>
    let AbstractResult = Prefixed_Name(shacl, "AbstractResult") |> PrefixedName

    /// <summary>
    ///   <para>shacl:AndConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to test whether a value node conforms to all members of a provided list of shapes.</para>
    /// labels<para>And constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#AndConstraintComponent">http://www.w3.org/ns/shacl#AndConstraintComponent</seealso>
    let AndConstraintComponent =
        Prefixed_Name(shacl, "AndConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:AndConstraintComponent-and</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#AndConstraintComponent-and">http://www.w3.org/ns/shacl#AndConstraintComponent-and</seealso>
    let AndConstraintComponent_and =
        Prefixed_Name(shacl, "AndConstraintComponent-and") |> PrefixedName

    /// <summary>
    ///   <para>shacl:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of parameter declarations, consisting of a path predicate and (possibly) information about allowed value type, cardinality and other characteristics.</para>
    /// labels<para>Parameter</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Parameter">http://www.w3.org/ns/shacl#Parameter</seealso>
    let Parameter = Prefixed_Name(shacl, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>shacl:NodeKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of all node kinds, including sh:BlankNode, sh:IRI, sh:Literal or the combinations of these: sh:BlankNodeOrIRI, sh:BlankNodeOrLiteral, sh:IRIOrLiteral.</para>
    /// labels<para>Node kind</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NodeKind">http://www.w3.org/ns/shacl#NodeKind</seealso>
    let NodeKind = Prefixed_Name(shacl, "NodeKind") |> PrefixedName

    /// <summary>
    ///   <para>shacl:EqualsConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that the set of value nodes is equal to the set of nodes that have the focus node as subject and the value of a given property as predicate.</para>
    /// labels<para>Equals constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#EqualsConstraintComponent">http://www.w3.org/ns/shacl#EqualsConstraintComponent</seealso>
    let EqualsConstraintComponent =
        Prefixed_Name(shacl, "EqualsConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:EqualsConstraintComponent-equals</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#EqualsConstraintComponent-equals">http://www.w3.org/ns/shacl#EqualsConstraintComponent-equals</seealso>
    let EqualsConstraintComponent_equals =
        Prefixed_Name(shacl, "EqualsConstraintComponent-equals") |> PrefixedName

    /// <summary>
    ///   <para>shacl:equals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a property that must have the same values as the value nodes.</para>
    /// labels<para>equals</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#equals">http://www.w3.org/ns/shacl#equals</seealso>
    let equals = Prefixed_Name(shacl, "equals") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ExpressionConstraintComponent-expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ExpressionConstraintComponent-expression">http://www.w3.org/ns/shacl#ExpressionConstraintComponent-expression</seealso>
    let ExpressionConstraintComponent_expression =
        Prefixed_Name(shacl, "ExpressionConstraintComponent-expression") |> PrefixedName

    /// <summary>
    ///   <para>shacl:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The node expression that must return true for the value nodes.</para>
    /// labels<para>expression</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#expression">http://www.w3.org/ns/shacl#expression</seealso>
    let expression = Prefixed_Name(shacl, "expression") |> PrefixedName

    /// <summary>
    ///   <para>shacl:HasValueConstraintComponent-hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#HasValueConstraintComponent-hasValue">http://www.w3.org/ns/shacl#HasValueConstraintComponent-hasValue</seealso>
    let HasValueConstraintComponent_hasValue =
        Prefixed_Name(shacl, "HasValueConstraintComponent-hasValue") |> PrefixedName

    /// <summary>
    ///   <para>shacl:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a value that must be among the value nodes.</para>
    /// labels<para>has value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#hasValue">http://www.w3.org/ns/shacl#hasValue</seealso>
    let hasValue = Prefixed_Name(shacl, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Info</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Severity</para>
    ///   <para>The severity for an informational validation result.</para>
    /// labels<para>Info</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Info">http://www.w3.org/ns/shacl#Info</seealso>
    let Info = Prefixed_Name(shacl, "Info") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of validation result severity levels, including violation and warning levels.</para>
    /// labels<para>Severity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Severity">http://www.w3.org/ns/shacl#Severity</seealso>
    let Severity = Prefixed_Name(shacl, "Severity") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSConstraint-js</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSConstraint-js">http://www.w3.org/ns/shacl#JSConstraint-js</seealso>
    let JSConstraint_js = Prefixed_Name(shacl, "JSConstraint-js") |> PrefixedName
    /// <summary>
    ///   <para>shacl:js</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Constraints expressed in JavaScript.</para>
    /// labels<para>JavaScript constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#js">http://www.w3.org/ns/shacl#js</seealso>
    let js = Prefixed_Name(shacl, "js") |> PrefixedName

    /// <summary>
    ///   <para>shacl:JSConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component with the parameter sh:js linking to a sh:JSConstraint containing a sh:script.</para>
    /// labels<para>JavaScript constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSConstraintComponent">http://www.w3.org/ns/shacl#JSConstraintComponent</seealso>
    let JSConstraintComponent =
        Prefixed_Name(shacl, "JSConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SHACL rules. Never instantiated directly.</para>
    /// labels<para>Rule</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Rule">http://www.w3.org/ns/shacl#Rule</seealso>
    let Rule = Prefixed_Name(shacl, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of targets that are based on JavaScript functions.</para>
    /// labels<para>JavaScript target</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSTarget">http://www.w3.org/ns/shacl#JSTarget</seealso>
    let JSTarget = Prefixed_Name(shacl, "JSTarget") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSValidator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SHACL validator based on JavaScript. This can be used to declare SHACL constraint components that perform JavaScript-based validation when used.</para>
    /// labels<para>JavaScript validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSValidator">http://www.w3.org/ns/shacl#JSValidator</seealso>
    let JSValidator = Prefixed_Name(shacl, "JSValidator") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Validator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of validators, which provide instructions on how to process a constraint definition. This class serves as base class for the SPARQL-based validators and other possible implementations.</para>
    /// labels<para>Validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Validator">http://www.w3.org/ns/shacl#Validator</seealso>
    let Validator = Prefixed_Name(shacl, "Validator") |> PrefixedName

    /// <summary>
    ///   <para>shacl:LessThanConstraintComponent-lessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#LessThanConstraintComponent-lessThan">http://www.w3.org/ns/shacl#LessThanConstraintComponent-lessThan</seealso>
    let LessThanConstraintComponent_lessThan =
        Prefixed_Name(shacl, "LessThanConstraintComponent-lessThan") |> PrefixedName

    /// <summary>
    ///   <para>shacl:lessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a property that must have smaller values than the value nodes.</para>
    /// labels<para>less than</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#lessThan">http://www.w3.org/ns/shacl#lessThan</seealso>
    let lessThan = Prefixed_Name(shacl, "lessThan") |> PrefixedName

    /// <summary>
    ///   <para>shacl:LessThanOrEqualsConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that every value node is smaller than all the nodes that have the focus node as subject and the value of a given property as predicate.</para>
    /// labels<para>less-than-or-equals constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent">http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent</seealso>
    let LessThanOrEqualsConstraintComponent =
        Prefixed_Name(shacl, "LessThanOrEqualsConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxCountConstraintComponent-maxCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxCountConstraintComponent-maxCount">http://www.w3.org/ns/shacl#MaxCountConstraintComponent-maxCount</seealso>
    let MaxCountConstraintComponent_maxCount =
        Prefixed_Name(shacl, "MaxCountConstraintComponent-maxCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxExclusiveConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the range of value nodes with a maximum exclusive value.</para>
    /// labels<para>Max-exclusive constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent">http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent</seealso>
    let MaxExclusiveConstraintComponent =
        Prefixed_Name(shacl, "MaxExclusiveConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxInclusiveConstraintComponent-maxInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent-maxInclusive">http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent-maxInclusive</seealso>
    let MaxInclusiveConstraintComponent_maxInclusive =
        Prefixed_Name(shacl, "MaxInclusiveConstraintComponent-maxInclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:maxInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the maximum inclusive value of each value node.</para>
    /// labels<para>max inclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#maxInclusive">http://www.w3.org/ns/shacl#maxInclusive</seealso>
    let maxInclusive = Prefixed_Name(shacl, "maxInclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxLengthConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the maximum string length of value nodes.</para>
    /// labels<para>Max-length constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxLengthConstraintComponent">http://www.w3.org/ns/shacl#MaxLengthConstraintComponent</seealso>
    let MaxLengthConstraintComponent =
        Prefixed_Name(shacl, "MaxLengthConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxLengthConstraintComponent-maxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxLengthConstraintComponent-maxLength">http://www.w3.org/ns/shacl#MaxLengthConstraintComponent-maxLength</seealso>
    let MaxLengthConstraintComponent_maxLength =
        Prefixed_Name(shacl, "MaxLengthConstraintComponent-maxLength") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinExclusiveConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the range of value nodes with a minimum exclusive value.</para>
    /// labels<para>Min-exclusive constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent">http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent</seealso>
    let MinExclusiveConstraintComponent =
        Prefixed_Name(shacl, "MinExclusiveConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinExclusiveConstraintComponent-minExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent-minExclusive">http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent-minExclusive</seealso>
    let MinExclusiveConstraintComponent_minExclusive =
        Prefixed_Name(shacl, "MinExclusiveConstraintComponent-minExclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:minExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the minimum exclusive value of each value node.</para>
    /// labels<para>min exclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#minExclusive">http://www.w3.org/ns/shacl#minExclusive</seealso>
    let minExclusive = Prefixed_Name(shacl, "minExclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinInclusiveConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the range of value nodes with a minimum inclusive value.</para>
    /// labels<para>Min-inclusive constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent">http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent</seealso>
    let MinInclusiveConstraintComponent =
        Prefixed_Name(shacl, "MinInclusiveConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinLengthConstraintComponent-minLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinLengthConstraintComponent-minLength">http://www.w3.org/ns/shacl#MinLengthConstraintComponent-minLength</seealso>
    let MinLengthConstraintComponent_minLength =
        Prefixed_Name(shacl, "MinLengthConstraintComponent-minLength") |> PrefixedName

    /// <summary>
    ///   <para>shacl:minLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the minimum string length of each value node.</para>
    /// labels<para>min length</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#minLength">http://www.w3.org/ns/shacl#minLength</seealso>
    let minLength = Prefixed_Name(shacl, "minLength") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NodeConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that all value nodes conform to the given node shape.</para>
    /// labels<para>Node constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NodeConstraintComponent">http://www.w3.org/ns/shacl#NodeConstraintComponent</seealso>
    let NodeConstraintComponent =
        Prefixed_Name(shacl, "NodeConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NodeConstraintComponent-node</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NodeConstraintComponent-node">http://www.w3.org/ns/shacl#NodeConstraintComponent-node</seealso>
    let NodeConstraintComponent_node =
        Prefixed_Name(shacl, "NodeConstraintComponent-node") |> PrefixedName

    /// <summary>
    ///   <para>shacl:node</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the node shape that all value nodes must conform to.</para>
    /// labels<para>node</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#node">http://www.w3.org/ns/shacl#node</seealso>
    let node = Prefixed_Name(shacl, "node") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NodeKindConstraintComponent-nodeKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NodeKindConstraintComponent-nodeKind">http://www.w3.org/ns/shacl#NodeKindConstraintComponent-nodeKind</seealso>
    let NodeKindConstraintComponent_nodeKind =
        Prefixed_Name(shacl, "NodeKindConstraintComponent-nodeKind") |> PrefixedName

    /// <summary>
    ///   <para>shacl:Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shape is a collection of constraints that may be targeted for certain nodes.</para>
    /// labels<para>Shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Shape">http://www.w3.org/ns/shacl#Shape</seealso>
    let Shape = Prefixed_Name(shacl, "Shape") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NotConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that value nodes do not conform to a given shape.</para>
    /// labels<para>Not constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NotConstraintComponent">http://www.w3.org/ns/shacl#NotConstraintComponent</seealso>
    let NotConstraintComponent =
        Prefixed_Name(shacl, "NotConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NotConstraintComponent-not</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NotConstraintComponent-not">http://www.w3.org/ns/shacl#NotConstraintComponent-not</seealso>
    let NotConstraintComponent_not =
        Prefixed_Name(shacl, "NotConstraintComponent-not") |> PrefixedName

    /// <summary>
    ///   <para>shacl:not</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a shape that the value nodes must not conform to.</para>
    /// labels<para>not</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#not">http://www.w3.org/ns/shacl#not</seealso>
    let ``not`` = Prefixed_Name(shacl, "not") |> PrefixedName
    /// <summary>
    ///   <para>shacl:PropertyShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A property shape is a shape that specifies constraints on the values of a focus node for a given property or path.</para>
    /// labels<para>Property shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PropertyShape">http://www.w3.org/ns/shacl#PropertyShape</seealso>
    let PropertyShape = Prefixed_Name(shacl, "PropertyShape") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PatternConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that every value node matches a given regular expression.</para>
    /// labels<para>Pattern constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PatternConstraintComponent">http://www.w3.org/ns/shacl#PatternConstraintComponent</seealso>
    let PatternConstraintComponent =
        Prefixed_Name(shacl, "PatternConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PatternConstraintComponent-pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PatternConstraintComponent-pattern">http://www.w3.org/ns/shacl#PatternConstraintComponent-pattern</seealso>
    let PatternConstraintComponent_pattern =
        Prefixed_Name(shacl, "PatternConstraintComponent-pattern") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PrefixDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of prefix declarations, consisting of pairs of a prefix with a namespace.</para>
    /// labels<para>Prefix declaration</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PrefixDeclaration">http://www.w3.org/ns/shacl#PrefixDeclaration</seealso>
    let PrefixDeclaration = Prefixed_Name(shacl, "PrefixDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PropertyConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that all value nodes conform to the given property shape.</para>
    /// labels<para>Property constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PropertyConstraintComponent">http://www.w3.org/ns/shacl#PropertyConstraintComponent</seealso>
    let PropertyConstraintComponent =
        Prefixed_Name(shacl, "PropertyConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PropertyConstraintComponent-property</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PropertyConstraintComponent-property">http://www.w3.org/ns/shacl#PropertyConstraintComponent-property</seealso>
    let PropertyConstraintComponent_property =
        Prefixed_Name(shacl, "PropertyConstraintComponent-property") |> PrefixedName

    /// <summary>
    ///   <para>shacl:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape to its property shapes.</para>
    /// labels<para>property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#property">http://www.w3.org/ns/shacl#property</seealso>
    let property = Prefixed_Name(shacl, "property") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMaxCountConstraintComponent-qualifiedValueShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShape">http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShape</seealso>
    let QualifiedMaxCountConstraintComponent_qualifiedValueShape =
        Prefixed_Name(shacl, "QualifiedMaxCountConstraintComponent-qualifiedValueShape") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint">http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint</seealso>
    let QualifiedMaxCountConstraintComponent_qualifiedValueShapesDisjoint =
        Prefixed_Name(shacl, "QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:qualifiedMaxCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The maximum number of value nodes that can conform to the shape.</para>
    /// labels<para>qualified max count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#qualifiedMaxCount">http://www.w3.org/ns/shacl#qualifiedMaxCount</seealso>
    let qualifiedMaxCount = Prefixed_Name(shacl, "qualifiedMaxCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:qualifiedValueShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The shape that a specified number of values must conform to.</para>
    /// labels<para>qualified value shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#qualifiedValueShape">http://www.w3.org/ns/shacl#qualifiedValueShape</seealso>
    let qualifiedValueShape =
        Prefixed_Name(shacl, "qualifiedValueShape") |> PrefixedName

    /// <summary>
    ///   <para>shacl:qualifiedValueShapesDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to mark the qualified value shape to be disjoint with its sibling shapes.</para>
    /// labels<para>qualified value shapes disjoint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#qualifiedValueShapesDisjoint">http://www.w3.org/ns/shacl#qualifiedValueShapesDisjoint</seealso>
    let qualifiedValueShapesDisjoint =
        Prefixed_Name(shacl, "qualifiedValueShapesDisjoint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMinCountConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that a specified minimum number of value nodes conforms to a given shape.</para>
    /// labels<para>Qualified-min-count constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent">http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent</seealso>
    let QualifiedMinCountConstraintComponent =
        Prefixed_Name(shacl, "QualifiedMinCountConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLAskExecutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SPARQL executables that are based on an ASK query.</para>
    /// labels<para>SPARQL ASK executable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLAskExecutable">http://www.w3.org/ns/shacl#SPARQLAskExecutable</seealso>
    let SPARQLAskExecutable =
        Prefixed_Name(shacl, "SPARQLAskExecutable") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLExecutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of resources that encapsulate a SPARQL query.</para>
    /// labels<para>SPARQL executable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLExecutable">http://www.w3.org/ns/shacl#SPARQLExecutable</seealso>
    let SPARQLExecutable = Prefixed_Name(shacl, "SPARQLExecutable") |> PrefixedName
    /// <summary>
    ///   <para>shacl:SPARQLAskValidator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of validators based on SPARQL ASK queries. The queries are evaluated for each value node and are supposed to return true if the given node conforms.</para>
    /// labels<para>SPARQL ASK validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLAskValidator">http://www.w3.org/ns/shacl#SPARQLAskValidator</seealso>
    let SPARQLAskValidator = Prefixed_Name(shacl, "SPARQLAskValidator") |> PrefixedName
    /// <summary>
    ///   <para>shacl:SPARQLConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of constraints based on SPARQL SELECT queries.</para>
    /// labels<para>SPARQL constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLConstraint">http://www.w3.org/ns/shacl#SPARQLConstraint</seealso>
    let SPARQLConstraint = Prefixed_Name(shacl, "SPARQLConstraint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLSelectExecutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SPARQL executables based on a SELECT query.</para>
    /// labels<para>SPARQL SELECT executable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLSelectExecutable">http://www.w3.org/ns/shacl#SPARQLSelectExecutable</seealso>
    let SPARQLSelectExecutable =
        Prefixed_Name(shacl, "SPARQLSelectExecutable") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to define constraints based on SPARQL queries.</para>
    /// labels<para>SPARQL constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLConstraintComponent">http://www.w3.org/ns/shacl#SPARQLConstraintComponent</seealso>
    let SPARQLConstraintComponent =
        Prefixed_Name(shacl, "SPARQLConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A function backed by a SPARQL query - either ASK or SELECT.</para>
    /// labels<para>SPARQL function</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLFunction">http://www.w3.org/ns/shacl#SPARQLFunction</seealso>
    let SPARQLFunction = Prefixed_Name(shacl, "SPARQLFunction") |> PrefixedName
    /// <summary>
    ///   <para>shacl:SPARQLRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SHACL rules based on SPARQL CONSTRUCT queries.</para>
    /// labels<para>SPARQL CONSTRUCT rule</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLRule">http://www.w3.org/ns/shacl#SPARQLRule</seealso>
    let SPARQLRule = Prefixed_Name(shacl, "SPARQLRule") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLSelectValidator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of validators based on SPARQL SELECT queries. The queries are evaluated for each focus node and are supposed to produce bindings for all focus nodes that do not conform.</para>
    /// labels<para>SPARQL SELECT validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLSelectValidator">http://www.w3.org/ns/shacl#SPARQLSelectValidator</seealso>
    let SPARQLSelectValidator =
        Prefixed_Name(shacl, "SPARQLSelectValidator") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of targets that are based on SPARQL queries.</para>
    /// labels<para>SPARQL target</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLTarget">http://www.w3.org/ns/shacl#SPARQLTarget</seealso>
    let SPARQLTarget = Prefixed_Name(shacl, "SPARQLTarget") |> PrefixedName
    /// <summary>
    ///   <para>shacl:SPARQLTargetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The (meta) class for parameterizable targets that are based on SPARQL queries.</para>
    /// labels<para>SPARQL target type</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLTargetType">http://www.w3.org/ns/shacl#SPARQLTargetType</seealso>
    let SPARQLTargetType = Prefixed_Name(shacl, "SPARQLTargetType") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLUpdateExecutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SPARQL executables based on a SPARQL UPDATE.</para>
    /// labels<para>SPARQL UPDATE executable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLUpdateExecutable">http://www.w3.org/ns/shacl#SPARQLUpdateExecutable</seealso>
    let SPARQLUpdateExecutable =
        Prefixed_Name(shacl, "SPARQLUpdateExecutable") |> PrefixedName

    /// <summary>
    ///   <para>shacl:TripleRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>A rule based on triple (subject, predicate, object) pattern.</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#TripleRule">http://www.w3.org/ns/shacl#TripleRule</seealso>
    let TripleRule = Prefixed_Name(shacl, "TripleRule") |> PrefixedName
    /// <summary>
    ///   <para>shacl:uniqueLang</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies whether all node values must have a unique (or no) language tag.</para>
    /// labels<para>unique languages</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#uniqueLang">http://www.w3.org/ns/shacl#uniqueLang</seealso>
    let uniqueLang = Prefixed_Name(shacl, "uniqueLang") |> PrefixedName
    /// <summary>
    ///   <para>shacl:ValidationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SHACL validation reports.</para>
    /// labels<para>Validation report</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ValidationReport">http://www.w3.org/ns/shacl#ValidationReport</seealso>
    let ValidationReport = Prefixed_Name(shacl, "ValidationReport") |> PrefixedName
    /// <summary>
    ///   <para>shacl:ValidationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of validation results.</para>
    /// labels<para>Validation result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ValidationResult">http://www.w3.org/ns/shacl#ValidationResult</seealso>
    let ValidationResult = Prefixed_Name(shacl, "ValidationResult") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Violation</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Severity</para>
    ///   <para>The severity for a violation validation result.</para>
    /// labels<para>Violation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Violation">http://www.w3.org/ns/shacl#Violation</seealso>
    let Violation = Prefixed_Name(shacl, "Violation") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Warning</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Severity</para>
    ///   <para>The severity for a warning validation result.</para>
    /// labels<para>Warning</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Warning">http://www.w3.org/ns/shacl#Warning</seealso>
    let Warning = Prefixed_Name(shacl, "Warning") |> PrefixedName

    /// <summary>
    ///   <para>shacl:XoneConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the value nodes so that they conform to exactly one out of several provided shapes.</para>
    /// labels<para>Exactly one constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#XoneConstraintComponent">http://www.w3.org/ns/shacl#XoneConstraintComponent</seealso>
    let XoneConstraintComponent =
        Prefixed_Name(shacl, "XoneConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:annotationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (default) values of the annotation property.</para>
    /// labels<para>annotation value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#annotationValue">http://www.w3.org/ns/shacl#annotationValue</seealso>
    let annotationValue = Prefixed_Name(shacl, "annotationValue") |> PrefixedName
    /// <summary>
    ///   <para>shacl:annotationVarName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the SPARQL variable from the SELECT clause that shall be used for the values.</para>
    /// labels<para>annotation variable name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#annotationVarName">http://www.w3.org/ns/shacl#annotationVarName</seealso>
    let annotationVarName = Prefixed_Name(shacl, "annotationVarName") |> PrefixedName
    /// <summary>
    ///   <para>shacl:ask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SPARQL ASK query to execute.</para>
    /// labels<para>ask</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ask">http://www.w3.org/ns/shacl#ask</seealso>
    let ask = Prefixed_Name(shacl, "ask") |> PrefixedName
    /// <summary>
    ///   <para>shacl:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The shapes that the focus nodes need to conform to before a rule is executed on them.</para>
    /// labels<para>condition</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#condition">http://www.w3.org/ns/shacl#condition</seealso>
    let condition = Prefixed_Name(shacl, "condition") |> PrefixedName
    /// <summary>
    ///   <para>shacl:construct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SPARQL CONSTRUCT query to execute.</para>
    /// labels<para>construct</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#construct">http://www.w3.org/ns/shacl#construct</seealso>
    let construct = Prefixed_Name(shacl, "construct") |> PrefixedName
    /// <summary>
    ///   <para>shacl:deactivated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If set to true then all nodes conform to this.</para>
    /// labels<para>deactivated</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#deactivated">http://www.w3.org/ns/shacl#deactivated</seealso>
    let deactivated = Prefixed_Name(shacl, "deactivated") |> PrefixedName
    /// <summary>
    ///   <para>shacl:defaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A default value for a property, for example for user interface tools to pre-populate input fields.</para>
    /// labels<para>default value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#defaultValue">http://www.w3.org/ns/shacl#defaultValue</seealso>
    let defaultValue = Prefixed_Name(shacl, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>shacl:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Human-readable descriptions for the property in the context of the surrounding shape.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#description">http://www.w3.org/ns/shacl#description</seealso>
    let description = Prefixed_Name(shacl, "description") |> PrefixedName
    /// <summary>
    ///   <para>shacl:entailment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entailment regime that indicates what kind of inferencing is required by a shapes graph.</para>
    /// labels<para>entailment</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#entailment">http://www.w3.org/ns/shacl#entailment</seealso>
    let entailment = Prefixed_Name(shacl, "entailment") |> PrefixedName
    /// <summary>
    ///   <para>shacl:filterShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The shape that all input nodes of the expression need to conform to.</para>
    /// labels<para>filter shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#filterShape">http://www.w3.org/ns/shacl#filterShape</seealso>
    let filterShape = Prefixed_Name(shacl, "filterShape") |> PrefixedName
    /// <summary>
    ///   <para>shacl:focusNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The focus node that was validated when the result was produced.</para>
    /// labels<para>focus node</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#focusNode">http://www.w3.org/ns/shacl#focusNode</seealso>
    let focusNode = Prefixed_Name(shacl, "focusNode") |> PrefixedName
    /// <summary>
    ///   <para>shacl:intersection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list of node expressions that shall be intersected.</para>
    /// labels<para>intersection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#intersection">http://www.w3.org/ns/shacl#intersection</seealso>
    let intersection = Prefixed_Name(shacl, "intersection") |> PrefixedName
    /// <summary>
    ///   <para>shacl:inversePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (single) value of this property represents an inverse path (object to subject).</para>
    /// labels<para>inverse path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#inversePath">http://www.w3.org/ns/shacl#inversePath</seealso>
    let inversePath = Prefixed_Name(shacl, "inversePath") |> PrefixedName
    /// <summary>
    ///   <para>shacl:jsFunctionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the JavaScript function to execute.</para>
    /// labels<para>JavaScript function name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#jsFunctionName">http://www.w3.org/ns/shacl#jsFunctionName</seealso>
    let jsFunctionName = Prefixed_Name(shacl, "jsFunctionName") |> PrefixedName
    /// <summary>
    ///   <para>shacl:jsLibrary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Declares which JavaScript libraries are needed to execute this.</para>
    /// labels<para>JavaScript library</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#jsLibrary">http://www.w3.org/ns/shacl#jsLibrary</seealso>
    let jsLibrary = Prefixed_Name(shacl, "jsLibrary") |> PrefixedName
    /// <summary>
    ///   <para>shacl:jsLibraryURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Declares the URLs of a JavaScript library. This should be the absolute URL of a JavaScript file. Implementations may redirect those to local files.</para>
    /// labels<para>JavaScript library URL</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#jsLibraryURL">http://www.w3.org/ns/shacl#jsLibraryURL</seealso>
    let jsLibraryURL = Prefixed_Name(shacl, "jsLibraryURL") |> PrefixedName
    /// <summary>
    ///   <para>shacl:labelTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Outlines how human-readable labels of instances of the associated Parameterizable shall be produced. The values can contain {?paramName} as placeholders for the actual values of the given parameter.</para>
    /// labels<para>label template</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#labelTemplate">http://www.w3.org/ns/shacl#labelTemplate</seealso>
    let labelTemplate = Prefixed_Name(shacl, "labelTemplate") |> PrefixedName
    /// <summary>
    ///   <para>shacl:message</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A human-readable message (possibly with placeholders for variables) explaining the cause of the result.</para>
    /// labels<para>message</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#message">http://www.w3.org/ns/shacl#message</seealso>
    let message = Prefixed_Name(shacl, "message") |> PrefixedName
    /// <summary>
    ///   <para>shacl:nodeValidator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The validator(s) used to evaluate a constraint in the context of a node shape.</para>
    /// labels<para>shape validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#nodeValidator">http://www.w3.org/ns/shacl#nodeValidator</seealso>
    let nodeValidator = Prefixed_Name(shacl, "nodeValidator") |> PrefixedName
    /// <summary>
    ///   <para>shacl:nodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The node expression producing the input nodes of a filter shape expression.</para>
    /// labels<para>nodes</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#nodes">http://www.w3.org/ns/shacl#nodes</seealso>
    let nodes = Prefixed_Name(shacl, "nodes") |> PrefixedName
    /// <summary>
    ///   <para>shacl:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An expression producing the nodes that shall be inferred as objects.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#object">http://www.w3.org/ns/shacl#object</seealso>
    let object = Prefixed_Name(shacl, "object") |> PrefixedName
    /// <summary>
    ///   <para>shacl:oneOrMorePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (single) value of this property represents a path that is matched one or more times.</para>
    /// labels<para>one or more path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#oneOrMorePath">http://www.w3.org/ns/shacl#oneOrMorePath</seealso>
    let oneOrMorePath = Prefixed_Name(shacl, "oneOrMorePath") |> PrefixedName
    /// <summary>
    ///   <para>shacl:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the relative order of this compared to its siblings. For example use 0 for the first, 1 for the second.</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#order">http://www.w3.org/ns/shacl#order</seealso>
    let order = Prefixed_Name(shacl, "order") |> PrefixedName
    /// <summary>
    ///   <para>shacl:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An expression producing the properties that shall be inferred as predicates.</para>
    /// labels<para>predicate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#predicate">http://www.w3.org/ns/shacl#predicate</seealso>
    let predicate = Prefixed_Name(shacl, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>shacl:declare</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a resource with its namespace prefix declarations.</para>
    /// labels<para>declare</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#declare">http://www.w3.org/ns/shacl#declare</seealso>
    let declare = Prefixed_Name(shacl, "declare") |> PrefixedName
    /// <summary>
    ///   <para>shacl:parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of a function or constraint component.</para>
    /// labels<para>parameter</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#parameter">http://www.w3.org/ns/shacl#parameter</seealso>
    let parameter = Prefixed_Name(shacl, "parameter") |> PrefixedName
    /// <summary>
    ///   <para>shacl:BlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeKind</para>
    ///   <para>The node kind of all blank nodes.</para>
    /// labels<para>Blank node</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#BlankNode">http://www.w3.org/ns/shacl#BlankNode</seealso>
    let BlankNode = Prefixed_Name(shacl, "BlankNode") |> PrefixedName

    /// <summary>
    ///   <para>shacl:InConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to exclusively enumerate the permitted value nodes.</para>
    /// labels<para>In constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#InConstraintComponent">http://www.w3.org/ns/shacl#InConstraintComponent</seealso>
    let InConstraintComponent =
        Prefixed_Name(shacl, "InConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:JSConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of constraints backed by a JavaScript function.</para>
    /// labels<para>JavaScript-based constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSConstraint">http://www.w3.org/ns/shacl#JSConstraint</seealso>
    let JSConstraint = Prefixed_Name(shacl, "JSConstraint") |> PrefixedName
    /// <summary>
    ///   <para>shacl:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link to a property group to indicate that a property shape belongs to a group of related property shapes.</para>
    /// labels<para>group</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#group">http://www.w3.org/ns/shacl#group</seealso>
    let group = Prefixed_Name(shacl, "group") |> PrefixedName
    /// <summary>
    ///   <para>shacl:severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the severity that validation results produced by a shape must have. Defaults to sh:Violation.</para>
    /// labels<para>severity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#severity">http://www.w3.org/ns/shacl#severity</seealso>
    let severity = Prefixed_Name(shacl, "severity") |> PrefixedName
    /// <summary>
    ///   <para>shacl:path</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the property path of a property shape.</para>
    /// labels<para>path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#path">http://www.w3.org/ns/shacl#path</seealso>
    let path = Prefixed_Name(shacl, "path") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ClassConstraintComponent-class</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ClassConstraintComponent-class">http://www.w3.org/ns/shacl#ClassConstraintComponent-class</seealso>
    let ClassConstraintComponent_class =
        Prefixed_Name(shacl, "ClassConstraintComponent-class") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ClosedConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to indicate that focus nodes must only have values for those properties that have been explicitly enumerated via sh:property/sh:path.</para>
    /// labels<para>Closed constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ClosedConstraintComponent">http://www.w3.org/ns/shacl#ClosedConstraintComponent</seealso>
    let ClosedConstraintComponent =
        Prefixed_Name(shacl, "ClosedConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies an RDF datatype that all value nodes must have.</para>
    /// labels<para>datatype</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#datatype">http://www.w3.org/ns/shacl#datatype</seealso>
    let datatype = Prefixed_Name(shacl, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>shacl:ignoredProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional RDF list of properties that are also permitted in addition to those explicitly enumerated via sh:property/sh:path.</para>
    /// labels<para>ignored properties</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ignoredProperties">http://www.w3.org/ns/shacl#ignoredProperties</seealso>
    let ignoredProperties = Prefixed_Name(shacl, "ignoredProperties") |> PrefixedName

    /// <summary>
    ///   <para>shacl:DatatypeConstraintComponent-datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#DatatypeConstraintComponent-datatype">http://www.w3.org/ns/shacl#DatatypeConstraintComponent-datatype</seealso>
    let DatatypeConstraintComponent_datatype =
        Prefixed_Name(shacl, "DatatypeConstraintComponent-datatype") |> PrefixedName

    /// <summary>
    ///   <para>shacl:maxCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the maximum number of values in the set of value nodes.</para>
    /// labels<para>max count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#maxCount">http://www.w3.org/ns/shacl#maxCount</seealso>
    let maxCount = Prefixed_Name(shacl, "maxCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxCountConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the maximum number of value nodes.</para>
    /// labels<para>Max-count constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxCountConstraintComponent">http://www.w3.org/ns/shacl#MaxCountConstraintComponent</seealso>
    let MaxCountConstraintComponent =
        Prefixed_Name(shacl, "MaxCountConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:maxExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the maximum exclusive value of each value node.</para>
    /// labels<para>max exclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#maxExclusive">http://www.w3.org/ns/shacl#maxExclusive</seealso>
    let maxExclusive = Prefixed_Name(shacl, "maxExclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxInclusiveConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the range of value nodes with a maximum inclusive value.</para>
    /// labels<para>Max-inclusive constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent">http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent</seealso>
    let MaxInclusiveConstraintComponent =
        Prefixed_Name(shacl, "MaxInclusiveConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:maxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the maximum string length of each value node.</para>
    /// labels<para>max length</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#maxLength">http://www.w3.org/ns/shacl#maxLength</seealso>
    let maxLength = Prefixed_Name(shacl, "maxLength") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinCountConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the minimum number of value nodes.</para>
    /// labels<para>Min-count constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinCountConstraintComponent">http://www.w3.org/ns/shacl#MinCountConstraintComponent</seealso>
    let MinCountConstraintComponent =
        Prefixed_Name(shacl, "MinCountConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ResultAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A class of result annotations, which define the rules to derive the values of a given annotation property as extra values for a validation result.</para>
    /// labels<para>Result annotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ResultAnnotation">http://www.w3.org/ns/shacl#ResultAnnotation</seealso>
    let ResultAnnotation = Prefixed_Name(shacl, "ResultAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>shacl:conforms</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True if the validation did not produce any validation results, and false otherwise.</para>
    /// labels<para>conforms</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#conforms">http://www.w3.org/ns/shacl#conforms</seealso>
    let conforms = Prefixed_Name(shacl, "conforms") |> PrefixedName
    /// <summary>
    ///   <para>shacl:detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a result with other results that provide more details, for example to describe violations against nested shapes.</para>
    /// labels<para>detail</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#detail">http://www.w3.org/ns/shacl#detail</seealso>
    let detail = Prefixed_Name(shacl, "detail") |> PrefixedName
    /// <summary>
    ///   <para>shacl:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The validation results contained in a validation report.</para>
    /// labels<para>result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#result">http://www.w3.org/ns/shacl#result</seealso>
    let result = Prefixed_Name(shacl, "result") |> PrefixedName
    /// <summary>
    ///   <para>shacl:resultPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The path of a validation result, based on the path of the validated property shape.</para>
    /// labels<para>result path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#resultPath">http://www.w3.org/ns/shacl#resultPath</seealso>
    let resultPath = Prefixed_Name(shacl, "resultPath") |> PrefixedName
    /// <summary>
    ///   <para>shacl:returnType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The expected type of values returned by the associated function.</para>
    /// labels<para>return type</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#returnType">http://www.w3.org/ns/shacl#returnType</seealso>
    let returnType = Prefixed_Name(shacl, "returnType") |> PrefixedName
    /// <summary>
    ///   <para>shacl:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The rules linked to a shape.</para>
    /// labels<para>rule</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#rule">http://www.w3.org/ns/shacl#rule</seealso>
    let rule = Prefixed_Name(shacl, "rule") |> PrefixedName

    /// <summary>
    ///   <para>shacl:shapesGraphWellFormed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If true then the validation engine was certain that the shapes graph has passed all SHACL syntax requirements during the validation process.</para>
    /// labels<para>shapes graph well-formed</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#shapesGraphWellFormed">http://www.w3.org/ns/shacl#shapesGraphWellFormed</seealso>
    let shapesGraphWellFormed =
        Prefixed_Name(shacl, "shapesGraphWellFormed") |> PrefixedName

    /// <summary>
    ///   <para>shacl:sourceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The shape that is was validated when the result was produced.</para>
    /// labels<para>source shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#sourceShape">http://www.w3.org/ns/shacl#sourceShape</seealso>
    let sourceShape = Prefixed_Name(shacl, "sourceShape") |> PrefixedName
    /// <summary>
    ///   <para>shacl:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An expression producing the resources that shall be inferred as subjects.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#subject">http://www.w3.org/ns/shacl#subject</seealso>
    let subject = Prefixed_Name(shacl, "subject") |> PrefixedName
    /// <summary>
    ///   <para>shacl:targetNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape to individual nodes, indicating that these nodes must conform to the shape.</para>
    /// labels<para>target node</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#targetNode">http://www.w3.org/ns/shacl#targetNode</seealso>
    let targetNode = Prefixed_Name(shacl, "targetNode") |> PrefixedName
    /// <summary>
    ///   <para>shacl:targetObjectsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape to a property, indicating that all all objects of triples that have the given property as their predicate must conform to the shape.</para>
    /// labels<para>target objects of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#targetObjectsOf">http://www.w3.org/ns/shacl#targetObjectsOf</seealso>
    let targetObjectsOf = Prefixed_Name(shacl, "targetObjectsOf") |> PrefixedName
    /// <summary>
    ///   <para>shacl:update</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SPARQL UPDATE to execute.</para>
    /// labels<para>update</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#update">http://www.w3.org/ns/shacl#update</seealso>
    let update = Prefixed_Name(shacl, "update") |> PrefixedName
    /// <summary>
    ///   <para>shacl:validator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The validator(s) used to evaluate constraints of either node or property shapes.</para>
    /// labels<para>validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#validator">http://www.w3.org/ns/shacl#validator</seealso>
    let validator = Prefixed_Name(shacl, "validator") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ClassConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that each value node is an instance of a given type.</para>
    /// labels<para>Class constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ClassConstraintComponent">http://www.w3.org/ns/shacl#ClassConstraintComponent</seealso>
    let ClassConstraintComponent =
        Prefixed_Name(shacl, "ClassConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type that all value nodes must have.</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#class">http://www.w3.org/ns/shacl#class</seealso>
    let class_ = Prefixed_Name(shacl, "class") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ClosedConstraintComponent-closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ClosedConstraintComponent-closed">http://www.w3.org/ns/shacl#ClosedConstraintComponent-closed</seealso>
    let ClosedConstraintComponent_closed =
        Prefixed_Name(shacl, "ClosedConstraintComponent-closed") |> PrefixedName

    /// <summary>
    ///   <para>shacl:closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If set to true then the shape is closed.</para>
    /// labels<para>closed</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#closed">http://www.w3.org/ns/shacl#closed</seealso>
    let closed = Prefixed_Name(shacl, "closed") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Parameterizable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Superclass of components that can take parameters, especially functions and constraint components.</para>
    /// labels<para>Parameterizable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Parameterizable">http://www.w3.org/ns/shacl#Parameterizable</seealso>
    let Parameterizable = Prefixed_Name(shacl, "Parameterizable") |> PrefixedName

    /// <summary>
    ///   <para>shacl:DisjointConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that the set of value nodes is disjoint with the the set of nodes that have the focus node as subject and the value of a given property as predicate.</para>
    /// labels<para>Disjoint constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#DisjointConstraintComponent">http://www.w3.org/ns/shacl#DisjointConstraintComponent</seealso>
    let DisjointConstraintComponent =
        Prefixed_Name(shacl, "DisjointConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:DisjointConstraintComponent-disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#DisjointConstraintComponent-disjoint">http://www.w3.org/ns/shacl#DisjointConstraintComponent-disjoint</seealso>
    let DisjointConstraintComponent_disjoint =
        Prefixed_Name(shacl, "DisjointConstraintComponent-disjoint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a property where the set of values must be disjoint with the value nodes.</para>
    /// labels<para>disjoint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#disjoint">http://www.w3.org/ns/shacl#disjoint</seealso>
    let disjoint = Prefixed_Name(shacl, "disjoint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NodeKindConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the RDF node kind of each value node.</para>
    /// labels<para>Node-kind constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NodeKindConstraintComponent">http://www.w3.org/ns/shacl#NodeKindConstraintComponent</seealso>
    let NodeKindConstraintComponent =
        Prefixed_Name(shacl, "NodeKindConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:NodeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A node shape is a shape that specifies constraint that need to be met with respect to focus nodes.</para>
    /// labels<para>Node shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#NodeShape">http://www.w3.org/ns/shacl#NodeShape</seealso>
    let NodeShape = Prefixed_Name(shacl, "NodeShape") |> PrefixedName

    /// <summary>
    ///   <para>shacl:OrConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the value nodes so that they conform to at least one out of several provided shapes.</para>
    /// labels<para>Or constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#OrConstraintComponent">http://www.w3.org/ns/shacl#OrConstraintComponent</seealso>
    let OrConstraintComponent =
        Prefixed_Name(shacl, "OrConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:OrConstraintComponent-or</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#OrConstraintComponent-or">http://www.w3.org/ns/shacl#OrConstraintComponent-or</seealso>
    let OrConstraintComponent_or =
        Prefixed_Name(shacl, "OrConstraintComponent-or") |> PrefixedName

    /// <summary>
    ///   <para>shacl:or</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a list of shapes so that the value nodes must conform to at least one of the shapes.</para>
    /// labels<para>or</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#or">http://www.w3.org/ns/shacl#or</seealso>
    let or_ = Prefixed_Name(shacl, "or") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PatternConstraintComponent-flags</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PatternConstraintComponent-flags">http://www.w3.org/ns/shacl#PatternConstraintComponent-flags</seealso>
    let PatternConstraintComponent_flags =
        Prefixed_Name(shacl, "PatternConstraintComponent-flags") |> PrefixedName

    /// <summary>
    ///   <para>shacl:flags</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional flag to be used with regular expression pattern matching.</para>
    /// labels<para>flags</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#flags">http://www.w3.org/ns/shacl#flags</seealso>
    let flags = Prefixed_Name(shacl, "flags") |> PrefixedName
    /// <summary>
    ///   <para>shacl:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a regular expression pattern that the string representations of the value nodes must match.</para>
    /// labels<para>pattern</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#pattern">http://www.w3.org/ns/shacl#pattern</seealso>
    let pattern = Prefixed_Name(shacl, "pattern") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMaxCountConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that a specified maximum number of value nodes conforms to a given shape.</para>
    /// labels<para>Qualified-max-count constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent">http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent</seealso>
    let QualifiedMaxCountConstraintComponent =
        Prefixed_Name(shacl, "QualifiedMaxCountConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMaxCountConstraintComponent-qualifiedMaxCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedMaxCount">http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedMaxCount</seealso>
    let QualifiedMaxCountConstraintComponent_qualifiedMaxCount =
        Prefixed_Name(shacl, "QualifiedMaxCountConstraintComponent-qualifiedMaxCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:UniqueLangConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to specify that no pair of value nodes may use the same language tag.</para>
    /// labels<para>Unique-languages constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#UniqueLangConstraintComponent">http://www.w3.org/ns/shacl#UniqueLangConstraintComponent</seealso>
    let UniqueLangConstraintComponent =
        Prefixed_Name(shacl, "UniqueLangConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:UniqueLangConstraintComponent-uniqueLang</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#UniqueLangConstraintComponent-uniqueLang">http://www.w3.org/ns/shacl#UniqueLangConstraintComponent-uniqueLang</seealso>
    let UniqueLangConstraintComponent_uniqueLang =
        Prefixed_Name(shacl, "UniqueLangConstraintComponent-uniqueLang") |> PrefixedName

    /// <summary>
    ///   <para>shacl:XoneConstraintComponent-xone</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#XoneConstraintComponent-xone">http://www.w3.org/ns/shacl#XoneConstraintComponent-xone</seealso>
    let XoneConstraintComponent_xone =
        Prefixed_Name(shacl, "XoneConstraintComponent-xone") |> PrefixedName

    /// <summary>
    ///   <para>shacl:xone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a list of shapes so that the value nodes must conform to exactly one of the shapes.</para>
    /// labels<para>exactly one</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#xone">http://www.w3.org/ns/shacl#xone</seealso>
    let xone = Prefixed_Name(shacl, "xone") |> PrefixedName
    /// <summary>
    ///   <para>shacl:alternativePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (single) value of this property must be a list of path elements, representing the elements of alternative paths.</para>
    /// labels<para>alternative path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#alternativePath">http://www.w3.org/ns/shacl#alternativePath</seealso>
    let alternativePath = Prefixed_Name(shacl, "alternativePath") |> PrefixedName
    /// <summary>
    ///   <para>shacl:annotationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The annotation property that shall be set.</para>
    /// labels<para>annotation property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#annotationProperty">http://www.w3.org/ns/shacl#annotationProperty</seealso>
    let annotationProperty = Prefixed_Name(shacl, "annotationProperty") |> PrefixedName
    /// <summary>
    ///   <para>shacl:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Human-readable labels for the property in the context of the surrounding shape.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#name">http://www.w3.org/ns/shacl#name</seealso>
    let name = Prefixed_Name(shacl, "name") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ClosedConstraintComponent-ignoredProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ClosedConstraintComponent-ignoredProperties">http://www.w3.org/ns/shacl#ClosedConstraintComponent-ignoredProperties</seealso>
    let ClosedConstraintComponent_ignoredProperties =
        Prefixed_Name(shacl, "ClosedConstraintComponent-ignoredProperties") |> PrefixedName

    /// <summary>
    ///   <para>shacl:prefixes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The prefixes that shall be applied before parsing the associated SPARQL query.</para>
    /// labels<para>prefixes</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#prefixes">http://www.w3.org/ns/shacl#prefixes</seealso>
    let prefixes = Prefixed_Name(shacl, "prefixes") |> PrefixedName
    /// <summary>
    ///   <para>shacl:propertyValidator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The validator(s) used to evaluate a constraint in the context of a property shape.</para>
    /// labels<para>property validator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#propertyValidator">http://www.w3.org/ns/shacl#propertyValidator</seealso>
    let propertyValidator = Prefixed_Name(shacl, "propertyValidator") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SHACL rules expressed using JavaScript.</para>
    /// labels<para>JavaScript rule</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSRule">http://www.w3.org/ns/shacl#JSRule</seealso>
    let JSRule = Prefixed_Name(shacl, "JSRule") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The base class of targets such as those based on SPARQL queries.</para>
    /// labels<para>Target</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Target">http://www.w3.org/ns/shacl#Target</seealso>
    let Target = Prefixed_Name(shacl, "Target") |> PrefixedName

    /// <summary>
    ///   <para>shacl:LanguageInConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to enumerate language tags that all value nodes must have.</para>
    /// labels<para>Language-in constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#LanguageInConstraintComponent">http://www.w3.org/ns/shacl#LanguageInConstraintComponent</seealso>
    let LanguageInConstraintComponent =
        Prefixed_Name(shacl, "LanguageInConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:PropertyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Instances of this class represent groups of property shapes that belong together.</para>
    /// labels<para>Property group</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#PropertyGroup">http://www.w3.org/ns/shacl#PropertyGroup</seealso>
    let PropertyGroup = Prefixed_Name(shacl, "PropertyGroup") |> PrefixedName
    /// <summary>
    ///   <para>shacl:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An RDF node that has caused the result.</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#value">http://www.w3.org/ns/shacl#value</seealso>
    let value = Prefixed_Name(shacl, "value") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ExpressionConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that a given node expression produces true for all value nodes.</para>
    /// labels<para>Expression constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ExpressionConstraintComponent">http://www.w3.org/ns/shacl#ExpressionConstraintComponent</seealso>
    let ExpressionConstraintComponent =
        Prefixed_Name(shacl, "ExpressionConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SHACL functions.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Function">http://www.w3.org/ns/shacl#Function</seealso>
    let Function = Prefixed_Name(shacl, "Function") |> PrefixedName

    /// <summary>
    ///   <para>shacl:HasValueConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that one of the value nodes is a given RDF node.</para>
    /// labels<para>Has-value constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#HasValueConstraintComponent">http://www.w3.org/ns/shacl#HasValueConstraintComponent</seealso>
    let HasValueConstraintComponent =
        Prefixed_Name(shacl, "HasValueConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:IRIOrLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeKind</para>
    ///   <para>The node kind of all IRIs or literals.</para>
    /// labels<para>IRI or literal</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#IRIOrLiteral">http://www.w3.org/ns/shacl#IRIOrLiteral</seealso>
    let IRIOrLiteral = Prefixed_Name(shacl, "IRIOrLiteral") |> PrefixedName

    /// <summary>
    ///   <para>shacl:InConstraintComponent-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#InConstraintComponent-in">http://www.w3.org/ns/shacl#InConstraintComponent-in</seealso>
    let InConstraintComponent_in =
        Prefixed_Name(shacl, "InConstraintComponent-in") |> PrefixedName

    /// <summary>
    ///   <para>shacl:in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a list of allowed values so that each value node must be among the members of the given list.</para>
    /// labels<para>in</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#in">http://www.w3.org/ns/shacl#in</seealso>
    let in_ = Prefixed_Name(shacl, "in") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSExecutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract base class of resources that declare an executable JavaScript.</para>
    /// labels<para>JavaScript executable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSExecutable">http://www.w3.org/ns/shacl#JSExecutable</seealso>
    let JSExecutable = Prefixed_Name(shacl, "JSExecutable") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SHACL functions that execute a JavaScript function when called.</para>
    /// labels<para>JavaScript function</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSFunction">http://www.w3.org/ns/shacl#JSFunction</seealso>
    let JSFunction = Prefixed_Name(shacl, "JSFunction") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSLibrary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a JavaScript library, typically identified by one or more URLs of files to include.</para>
    /// labels<para>JavaScript library</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSLibrary">http://www.w3.org/ns/shacl#JSLibrary</seealso>
    let JSLibrary = Prefixed_Name(shacl, "JSLibrary") |> PrefixedName
    /// <summary>
    ///   <para>shacl:JSTargetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The (meta) class for parameterizable targets that are based on JavaScript functions.</para>
    /// labels<para>JavaScript target type</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#JSTargetType">http://www.w3.org/ns/shacl#JSTargetType</seealso>
    let JSTargetType = Prefixed_Name(shacl, "JSTargetType") |> PrefixedName
    /// <summary>
    ///   <para>shacl:TargetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The (meta) class for parameterizable targets.	Instances of this are instantiated as values of the sh:target property.</para>
    /// labels<para>Target type</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#TargetType">http://www.w3.org/ns/shacl#TargetType</seealso>
    let TargetType = Prefixed_Name(shacl, "TargetType") |> PrefixedName

    /// <summary>
    ///   <para>shacl:LanguageInConstraintComponent-languageIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#LanguageInConstraintComponent-languageIn">http://www.w3.org/ns/shacl#LanguageInConstraintComponent-languageIn</seealso>
    let LanguageInConstraintComponent_languageIn =
        Prefixed_Name(shacl, "LanguageInConstraintComponent-languageIn") |> PrefixedName

    /// <summary>
    ///   <para>shacl:languageIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a list of language tags that all value nodes must have.</para>
    /// labels<para>language in</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#languageIn">http://www.w3.org/ns/shacl#languageIn</seealso>
    let languageIn = Prefixed_Name(shacl, "languageIn") |> PrefixedName

    /// <summary>
    ///   <para>shacl:LessThanConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that each value node is smaller than all the nodes that have the focus node as subject and the value of a given property as predicate.</para>
    /// labels<para>Less-than constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#LessThanConstraintComponent">http://www.w3.org/ns/shacl#LessThanConstraintComponent</seealso>
    let LessThanConstraintComponent =
        Prefixed_Name(shacl, "LessThanConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:LessThanOrEqualsConstraintComponent-lessThanOrEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent-lessThanOrEquals">http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent-lessThanOrEquals</seealso>
    let LessThanOrEqualsConstraintComponent_lessThanOrEquals =
        Prefixed_Name(shacl, "LessThanOrEqualsConstraintComponent-lessThanOrEquals") |> PrefixedName

    /// <summary>
    ///   <para>shacl:lessThanOrEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a property that must have smaller or equal values than the value nodes.</para>
    /// labels<para>less than or equals</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#lessThanOrEquals">http://www.w3.org/ns/shacl#lessThanOrEquals</seealso>
    let lessThanOrEquals = Prefixed_Name(shacl, "lessThanOrEquals") |> PrefixedName
    /// <summary>
    ///   <para>shacl:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeKind</para>
    ///   <para>The node kind of all literals.</para>
    /// labels<para>Literal</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#Literal">http://www.w3.org/ns/shacl#Literal</seealso>
    let Literal = Prefixed_Name(shacl, "Literal") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMinCountConstraintComponent-qualifiedMinCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedMinCount">http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedMinCount</seealso>
    let QualifiedMinCountConstraintComponent_qualifiedMinCount =
        Prefixed_Name(shacl, "QualifiedMinCountConstraintComponent-qualifiedMinCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMinCountConstraintComponent-qualifiedValueShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShape">http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShape</seealso>
    let QualifiedMinCountConstraintComponent_qualifiedValueShape =
        Prefixed_Name(shacl, "QualifiedMinCountConstraintComponent-qualifiedValueShape") |> PrefixedName

    /// <summary>
    ///   <para>shacl:QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint">http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint</seealso>
    let QualifiedMinCountConstraintComponent_qualifiedValueShapesDisjoint =
        Prefixed_Name(shacl, "QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:qualifiedMinCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The minimum number of value nodes that must conform to the shape.</para>
    /// labels<para>qualified min count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#qualifiedMinCount">http://www.w3.org/ns/shacl#qualifiedMinCount</seealso>
    let qualifiedMinCount = Prefixed_Name(shacl, "qualifiedMinCount") |> PrefixedName
    /// <summary>
    ///   <para>shacl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This vocabulary defines terms used in SHACL, the W3C Shapes Constraint Language.</para>
    /// labels<para>W3C Shapes Constraint Language (SHACL) Vocabulary</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#">http://www.w3.org/ns/shacl#</seealso>
    let _prefix_iri = Prefixed_Name(shacl, "") |> PrefixedName

    /// <summary>
    ///   <para>shacl:suggestedShapesGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Suggested shapes graphs for this ontology. The values of this property may be used in the absence of specific sh:shapesGraph statements.</para>
    /// labels<para>suggested shapes graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#suggestedShapesGraph">http://www.w3.org/ns/shacl#suggestedShapesGraph</seealso>
    let suggestedShapesGraph =
        Prefixed_Name(shacl, "suggestedShapesGraph") |> PrefixedName

    /// <summary>
    ///   <para>shacl:ConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of constraint components.</para>
    /// labels<para>Constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#ConstraintComponent">http://www.w3.org/ns/shacl#ConstraintComponent</seealso>
    let ConstraintComponent =
        Prefixed_Name(shacl, "ConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:and</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>RDF list of shapes to validate the value nodes against.</para>
    /// labels<para>and</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#and">http://www.w3.org/ns/shacl#and</seealso>
    let and_ = Prefixed_Name(shacl, "and") |> PrefixedName
    /// <summary>
    ///   <para>shacl:BlankNodeOrIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeKind</para>
    ///   <para>The node kind of all blank nodes or IRIs.</para>
    /// labels<para>Blank node or IRI</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#BlankNodeOrIRI">http://www.w3.org/ns/shacl#BlankNodeOrIRI</seealso>
    let BlankNodeOrIRI = Prefixed_Name(shacl, "BlankNodeOrIRI") |> PrefixedName
    /// <summary>
    ///   <para>shacl:BlankNodeOrLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeKind</para>
    ///   <para>The node kind of all blank nodes or literals.</para>
    /// labels<para>Blank node or literal</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#BlankNodeOrLiteral">http://www.w3.org/ns/shacl#BlankNodeOrLiteral</seealso>
    let BlankNodeOrLiteral = Prefixed_Name(shacl, "BlankNodeOrLiteral") |> PrefixedName
    /// <summary>
    ///   <para>shacl:nodeKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the node kind (e.g. IRI or literal) each value node.</para>
    /// labels<para>node kind</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#nodeKind">http://www.w3.org/ns/shacl#nodeKind</seealso>
    let nodeKind = Prefixed_Name(shacl, "nodeKind") |> PrefixedName
    /// <summary>
    ///   <para>shacl:IRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeKind</para>
    ///   <para>The node kind of all IRIs.</para>
    /// labels<para>IRI</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#IRI">http://www.w3.org/ns/shacl#IRI</seealso>
    let IRI = Prefixed_Name(shacl, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>shacl:optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether a parameter is optional.</para>
    /// labels<para>optional</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#optional">http://www.w3.org/ns/shacl#optional</seealso>
    let optional = Prefixed_Name(shacl, "optional") |> PrefixedName

    /// <summary>
    ///   <para>shacl:DatatypeConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the datatype of all value nodes.</para>
    /// labels<para>Datatype constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#DatatypeConstraintComponent">http://www.w3.org/ns/shacl#DatatypeConstraintComponent</seealso>
    let DatatypeConstraintComponent =
        Prefixed_Name(shacl, "DatatypeConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MaxExclusiveConstraintComponent-maxExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent-maxExclusive">http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent-maxExclusive</seealso>
    let MaxExclusiveConstraintComponent_maxExclusive =
        Prefixed_Name(shacl, "MaxExclusiveConstraintComponent-maxExclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinCountConstraintComponent-minCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinCountConstraintComponent-minCount">http://www.w3.org/ns/shacl#MinCountConstraintComponent-minCount</seealso>
    let MinCountConstraintComponent_minCount =
        Prefixed_Name(shacl, "MinCountConstraintComponent-minCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:minCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the minimum number of values in the set of value nodes.</para>
    /// labels<para>min count</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#minCount">http://www.w3.org/ns/shacl#minCount</seealso>
    let minCount = Prefixed_Name(shacl, "minCount") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinInclusiveConstraintComponent-minInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent-minInclusive">http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent-minInclusive</seealso>
    let MinInclusiveConstraintComponent_minInclusive =
        Prefixed_Name(shacl, "MinInclusiveConstraintComponent-minInclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:minInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the minimum inclusive value of each value node.</para>
    /// labels<para>min inclusive</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#minInclusive">http://www.w3.org/ns/shacl#minInclusive</seealso>
    let minInclusive = Prefixed_Name(shacl, "minInclusive") |> PrefixedName

    /// <summary>
    ///   <para>shacl:MinLengthConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to restrict the minimum string length of value nodes.</para>
    /// labels<para>Min-length constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#MinLengthConstraintComponent">http://www.w3.org/ns/shacl#MinLengthConstraintComponent</seealso>
    let MinLengthConstraintComponent =
        Prefixed_Name(shacl, "MinLengthConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLConstraintComponent-sparql</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLConstraintComponent-sparql">http://www.w3.org/ns/shacl#SPARQLConstraintComponent-sparql</seealso>
    let SPARQLConstraintComponent_sparql =
        Prefixed_Name(shacl, "SPARQLConstraintComponent-sparql") |> PrefixedName

    /// <summary>
    ///   <para>shacl:sparql</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape with SPARQL constraints.</para>
    /// labels<para>constraint (in SPARQL)</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#sparql">http://www.w3.org/ns/shacl#sparql</seealso>
    let sparql = Prefixed_Name(shacl, "sparql") |> PrefixedName

    /// <summary>
    ///   <para>shacl:SPARQLConstructExecutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of SPARQL executables that are based on a CONSTRUCT query.</para>
    /// labels<para>SPARQL CONSTRUCT executable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#SPARQLConstructExecutable">http://www.w3.org/ns/shacl#SPARQLConstructExecutable</seealso>
    let SPARQLConstructExecutable =
        Prefixed_Name(shacl, "SPARQLConstructExecutable") |> PrefixedName

    /// <summary>
    ///   <para>shacl:resultAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a SPARQL validator with zero or more sh:ResultAnnotation instances, defining how to derive additional result properties based on the variables of the SELECT query.</para>
    /// labels<para>result annotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#resultAnnotation">http://www.w3.org/ns/shacl#resultAnnotation</seealso>
    let resultAnnotation = Prefixed_Name(shacl, "resultAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>shacl:resultMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Human-readable messages explaining the cause of the result.</para>
    /// labels<para>result message</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#resultMessage">http://www.w3.org/ns/shacl#resultMessage</seealso>
    let resultMessage = Prefixed_Name(shacl, "resultMessage") |> PrefixedName
    /// <summary>
    ///   <para>shacl:resultSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The severity of the result, e.g. warning.</para>
    /// labels<para>result severity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#resultSeverity">http://www.w3.org/ns/shacl#resultSeverity</seealso>
    let resultSeverity = Prefixed_Name(shacl, "resultSeverity") |> PrefixedName
    /// <summary>
    ///   <para>shacl:select</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The SPARQL SELECT query to execute.</para>
    /// labels<para>select</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#select">http://www.w3.org/ns/shacl#select</seealso>
    let select = Prefixed_Name(shacl, "select") |> PrefixedName
    /// <summary>
    ///   <para>shacl:shapesGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shapes graphs that should be used when validating this data graph.</para>
    /// labels<para>shapes graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#shapesGraph">http://www.w3.org/ns/shacl#shapesGraph</seealso>
    let shapesGraph = Prefixed_Name(shacl, "shapesGraph") |> PrefixedName
    /// <summary>
    ///   <para>shacl:sourceConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The constraint that was validated when the result was produced.</para>
    /// labels<para>source constraint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#sourceConstraint">http://www.w3.org/ns/shacl#sourceConstraint</seealso>
    let sourceConstraint = Prefixed_Name(shacl, "sourceConstraint") |> PrefixedName

    /// <summary>
    ///   <para>shacl:sourceConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The constraint component that is the source of the result.</para>
    /// labels<para>source constraint component</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#sourceConstraintComponent">http://www.w3.org/ns/shacl#sourceConstraintComponent</seealso>
    let sourceConstraintComponent =
        Prefixed_Name(shacl, "sourceConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>shacl:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape to a target specified by an extension language, for example instances of sh:SPARQLTarget.</para>
    /// labels<para>target</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#target">http://www.w3.org/ns/shacl#target</seealso>
    let target = Prefixed_Name(shacl, "target") |> PrefixedName
    /// <summary>
    ///   <para>shacl:targetClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape to a class, indicating that all instances of the class must conform to the shape.</para>
    /// labels<para>target class</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#targetClass">http://www.w3.org/ns/shacl#targetClass</seealso>
    let targetClass = Prefixed_Name(shacl, "targetClass") |> PrefixedName
    /// <summary>
    ///   <para>shacl:targetSubjectsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a shape to a property, indicating that all subjects of triples that have the given property as their predicate must conform to the shape.</para>
    /// labels<para>target subjects of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#targetSubjectsOf">http://www.w3.org/ns/shacl#targetSubjectsOf</seealso>
    let targetSubjectsOf = Prefixed_Name(shacl, "targetSubjectsOf") |> PrefixedName
    /// <summary>
    ///   <para>shacl:this</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>A node expression that represents the current focus node.</para>
    /// labels<para>this</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#this">http://www.w3.org/ns/shacl#this</seealso>
    let this = Prefixed_Name(shacl, "this") |> PrefixedName
    /// <summary>
    ///   <para>shacl:union</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list of node expressions that shall be used together.</para>
    /// labels<para>union</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#union">http://www.w3.org/ns/shacl#union</seealso>
    let union = Prefixed_Name(shacl, "union") |> PrefixedName
    /// <summary>
    ///   <para>shacl:zeroOrMorePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (single) value of this property represents a path that is matched zero or more times.</para>
    /// labels<para>zero or more path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#zeroOrMorePath">http://www.w3.org/ns/shacl#zeroOrMorePath</seealso>
    let zeroOrMorePath = Prefixed_Name(shacl, "zeroOrMorePath") |> PrefixedName
    /// <summary>
    ///   <para>shacl:zeroOrOnePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (single) value of this property represents a path that is matched zero or one times.</para>
    /// labels<para>zero or one path</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl#zeroOrOnePath">http://www.w3.org/ns/shacl#zeroOrOnePath</seealso>
    let zeroOrOnePath = Prefixed_Name(shacl, "zeroOrOnePath") |> PrefixedName
