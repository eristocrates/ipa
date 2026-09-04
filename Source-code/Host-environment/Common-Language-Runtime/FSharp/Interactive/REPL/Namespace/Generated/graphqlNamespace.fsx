#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module graphql =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://datashapes.org/graphql#" "graphql"

    let ClassShape = _prefixId.prefix "ClassShape"
    /// <summary>
    ///   <para>rdfs:label : Input object type^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an input object type in a GraphQL schema.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#InputObjectType">graphql:InputObjectType</a>
    /// </summary>
    let InputObjectType = _prefixId.prefix "InputObjectType"
    /// <summary>
    ///   <para>http://datashapes.org/dash#abstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Input type^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#InputType">graphql:InputType</a>
    /// </summary>
    let InputType = _prefixId.prefix "InputType"
    /// <summary>
    ///   <para>rdfs:label : Input value^^xsd:string</para>
    ///   <para>rdfs:comment : The definition of an input value, consisting of a name, type and an optional default value.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#InputValue">graphql:InputValue</a>
    /// </summary>
    let InputValue = _prefixId.prefix "InputValue"
    /// <summary>
    ///   <para>rdfs:label : JSON-to-RDF test case^^xsd:string</para>
    ///   <para>rdfs:comment : A test case that can be used to verify that a given JSON object is translated into RDF triples using shape definitions from a given graphql:Service. The service must be in the test case graph.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#JSON2RDFTestCase">graphql:JSON2RDFTestCase</a>
    /// </summary>
    let JSON2RDFTestCase = _prefixId.prefix "JSON2RDFTestCase"
    /// <summary>
    ///   <para>rdfs:label : List type^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#ListType">graphql:ListType</a>
    /// </summary>
    let ListType = _prefixId.prefix "ListType"
    /// <summary>
    ///   <para>rdfs:label : GraphQL mutation test case^^xsd:string</para>
    ///   <para>rdfs:comment : A test case that runs a given GraphQL mutation (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The mutation is executed over a given "before" graph which must be isomorphic to a given "after" graph. The TestCase is also a graphql:Schema defining which shapes to publish.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#MutationTestCase">graphql:MutationTestCase</a>
    /// </summary>
    let MutationTestCase = _prefixId.prefix "MutationTestCase"
    let NameShape = _prefixId.prefix "NameShape"
    /// <summary>
    ///   <para>rdfs:label : Named type^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#NamedType">graphql:NamedType</a>
    /// </summary>
    let NamedType = _prefixId.prefix "NamedType"
    let NodeShapeShape = _prefixId.prefix "NodeShapeShape"
    /// <summary>
    ///   <para>rdfs:label : Non null type^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#NonNullType">graphql:NonNullType</a>
    /// </summary>
    let NonNullType = _prefixId.prefix "NonNullType"
    /// <summary>
    ///   <para>rdfs:label : GraphQL query^^xsd:string</para>
    ///   <para>rdfs:comment : Represents specific GraphQL queries, stored by their query string and possibly other properties with metadata.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#Query">graphql:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : GraphQL query test case^^xsd:string</para>
    ///   <para>rdfs:comment : A test case that runs a given GraphQL query (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The TestCase is also a graphql:Schema defining which shapes to publish.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#QueryTestCase">graphql:QueryTestCase</a>
    /// </summary>
    let QueryTestCase = _prefixId.prefix "QueryTestCase"
    /// <summary>
    ///   <para>rdfs:label : Scalar type^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a scalar type as defined by a GraphQL schema. The primary purpose of these types is for round-tripping, otherwise they are basically the same as node shapes. The instances must be URIs, and the GraphQL name is derived from them.
    ///
    /// This is currently not marked as a subClassOf sh:NodeShape, although this may happen in the future. The idea is that we don't want all constraint parameters to apply here, only selected ones such as sh:datatype. In the SHACL spec, anything that has constraints counts as a node shape, even if it doesn't have a matching rdf:type triple.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#ScalarType">graphql:ScalarType</a>
    /// </summary>
    let ScalarType = _prefixId.prefix "ScalarType"
    /// <summary>
    ///   <para>rdfs:label : GraphQL Schema^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of shapes that are part of a GraphQL schema. Includes declarations about which shapes shall be exposed/published by a GraphQL service. The set of public node shapes consists of all values of graphql:publicShape, all values of graphql:publicClass and their subclasses, all node shapes from any namespace graphql:publicNamespace, minus any explicitly excluded shapes via graphql:privateShape.
    ///
    /// An RDF graph may contain multiple GraphQL schemas, each providing a different API or view on the underlying data. GraphQL services can include each other using owl:imports. To simplify common usage patterns, owl:Ontology has been marked as a subclass, so that all Ontologies are also graphql:Schemas once this graphql namespace is imported.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#Schema">graphql:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    let Schema_privateShape = _prefixId.prefix "Schema-privateShape"
    let Schema_protectedClass = _prefixId.prefix "Schema-protectedClass"
    let Schema_protectedShape = _prefixId.prefix "Schema-protectedShape"
    let Schema_publicClass = _prefixId.prefix "Schema-publicClass"
    let Schema_publicNamespace = _prefixId.prefix "Schema-publicNamespace"
    let Schema_publicShape = _prefixId.prefix "Schema-publicShape"
    let SchemaPropertyGroup = _prefixId.prefix "SchemaPropertyGroup"
    let ShapesPropertyGroup = _prefixId.prefix "ShapesPropertyGroup"
    /// <summary>
    ///   <para>rdfs:label : Writer test case^^xsd:string</para>
    ///   <para>rdfs:comment : A test case that can be used to verify that a RDF/SHACL to GraphQL writer works correctly. The expected result must be the complete GraphQL schema string.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#WriterTestCase">graphql:WriterTestCase</a>
    /// </summary>
    let WriterTestCase = _prefixId.prefix "WriterTestCase"
    let canRoundTrip = _prefixId.prefix "canRoundTrip"
    let dataGraph = _prefixId.prefix "dataGraph"
    /// <summary>
    ///   <para>rdfs:label : default prefix^^xsd:string</para>
    ///   <para>rdfs:comment : Points at a prefix declaration of the default namespace for the shapes derived by GraphQL types. This property can be used to round-trip .graphql files.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#defaultPrefix">graphql:defaultPrefix</a>
    /// </summary>
    let defaultPrefix = _prefixId.prefix "defaultPrefix"
    let defaultValue = _prefixId.prefix "defaultValue"
    let expectedGraph = _prefixId.prefix "expectedGraph"
    let fieldName = _prefixId.prefix "fieldName"
    let inputValue = _prefixId.prefix "inputValue"
    /// <summary>
    ///   <para>rdfs:label : is ID field^^xsd:string</para>
    ///   <para>rdfs:comment : Can be attached to property shapes to indicate they should be round-tripped as GraphQL type ID.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#isIDField">graphql:isIDField</a>
    /// </summary>
    let isIDField = _prefixId.prefix "isIDField"
    /// <summary>
    ///   <para>rdfs:label : is GraphQL interface^^xsd:string</para>
    ///   <para>rdfs:comment : If set to true for a node shape, then it should become a GraphQL interface.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#isInterface">graphql:isInterface</a>
    /// </summary>
    let isInterface = _prefixId.prefix "isInterface"
    let json = _prefixId.prefix "json"
    let memberType = _prefixId.prefix "memberType"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : Defines a GraphQL name for a given subject. The values need to match the regular expression specified in http://facebook.github.io/graphql/October2016/#Name.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#name">graphql:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let nodeShape = _prefixId.prefix "nodeShape"
    let path = _prefixId.prefix "path"
    let privateShape = _prefixId.prefix "privateShape"
    let protectedClass = _prefixId.prefix "protectedClass"
    let protectedShape = _prefixId.prefix "protectedShape"
    let publicClass = _prefixId.prefix "publicClass"
    let publicNamespace = _prefixId.prefix "publicNamespace"
    let publicShape = _prefixId.prefix "publicShape"
    /// <summary>
    ///   <para>rdfs:label : query^^xsd:string</para>
    ///   <para>rdfs:comment : The GraphQL query string.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#query">graphql:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:label : query shape^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#queryShape">graphql:queryShape</a>
    /// </summary>
    let queryShape = _prefixId.prefix "queryShape"
    /// <summary>
    ///   <para>rdfs:label : query string^^xsd:string</para>
    ///   <para>rdfs:comment : The text of the actual query in GraphQL syntax.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#queryString">graphql:queryString</a>
    /// </summary>
    let queryString = _prefixId.prefix "queryString"
    let rdfGraph = _prefixId.prefix "rdfGraph"
    let schema = _prefixId.prefix "schema"
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : GraphQL URI template^^xsd:string</para>
    ///   <para>rdfs:comment : Can be used to attach a URI template to node shapes, meaning that JSON objects that are processed with the given node shape will become URI resources with a URI derived from the given template. Example: "ex:Person-{$id}".
    ///
    /// URI templates can include {...} blocks that contain a variable reference such as $id if the corresponding GraphQL type has a field named "id". Fields are mandatory by default, meaning that if a JSON converter attempts to produce a URI that lacks a mandatory field then the conversion fails with an exception.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#uriTemplate">graphql:uriTemplate</a>
    /// </summary>
    let uriTemplate = _prefixId.prefix "uriTemplate"
    /// <summary>
    ///   <para>rdfs:label : variables^^xsd:string</para>
    ///   <para>rdfs:comment : An optional JSON object with variables that shall be passed into the query for execution.^^xsd:string</para>
    ///   <a href="http://datashapes.org/graphql#variables">graphql:variables</a>
    /// </summary>
    let variables = _prefixId.prefix "variables"
