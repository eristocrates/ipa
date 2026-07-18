namespace http.datashapes.org.graphql.hash

open DoxAletheia.Rdf_Vocabulary

module graphql =
    let _namespace_name = "http://datashapes.org/graphql#"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#ClassShape"></see>
    /// </summary>
    let ClassShape = Namespaced_IRI.parse _namespace_name "ClassShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#protectedClass"></see>
    /// </summary>
    let protectedClass =
        Namespaced_IRI.parse _namespace_name "protectedClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#SchemaPropertyGroup"></see>
    /// </summary>
    let SchemaPropertyGroup =
        Namespaced_IRI.parse _namespace_name "SchemaPropertyGroup" |> NamespacedName

    /// <summary>
    /// A collection of shapes that are part of a GraphQL schema. Includes declarations about which shapes shall be exposed/published by a GraphQL service. The set of public node shapes consists of all values of graphql:publicShape, all values of graphql:publicClass and their subclasses, all node shapes from any namespace graphql:publicNamespace, minus any explicitly excluded shapes via graphql:privateShape.
    ///
    /// An RDF graph may contain multiple GraphQL schemas, each providing a different API or view on the underlying data. GraphQL services can include each other using owl:imports. To simplify common usage patterns, owl:Ontology has been marked as a subclass, so that all Ontologies are also graphql:Schemas once this graphql namespace is imported.
    /// <see href="http://datashapes.org/graphql#Schema"></see></summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#publicClass"></see>
    /// </summary>
    let publicClass =
        Namespaced_IRI.parse _namespace_name "publicClass" |> NamespacedName

    /// <summary>
    /// Represents an input object type in a GraphQL schema.
    /// <see href="http://datashapes.org/graphql#InputObjectType"></see></summary>
    let InputObjectType =
        Namespaced_IRI.parse _namespace_name "InputObjectType" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#inputValue"></see>
    /// </summary>
    let inputValue = Namespaced_IRI.parse _namespace_name "inputValue" |> NamespacedName
    /// <summary>
    /// The definition of an input value, consisting of a name, type and an optional default value.
    /// <see href="http://datashapes.org/graphql#InputValue"></see></summary>
    let InputValue = Namespaced_IRI.parse _namespace_name "InputValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#InputType"></see>
    /// </summary>
    let InputType = Namespaced_IRI.parse _namespace_name "InputType" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#defaultValue"></see>
    /// </summary>
    let defaultValue =
        Namespaced_IRI.parse _namespace_name "defaultValue" |> NamespacedName

    /// <summary>
    /// Defines a GraphQL name for a given subject. The values need to match the regular expression specified in http://facebook.github.io/graphql/October2016/#Name.
    /// <see href="http://datashapes.org/graphql#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// A test case that can be used to verify that a given JSON object is translated into RDF triples using shape definitions from a given graphql:Service. The service must be in the test case graph.
    /// <see href="http://datashapes.org/graphql#JSON2RDFTestCase"></see></summary>
    let JSON2RDFTestCase =
        Namespaced_IRI.parse _namespace_name "JSON2RDFTestCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#json"></see>
    /// </summary>
    let json = Namespaced_IRI.parse _namespace_name "json" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#schema"></see>
    /// </summary>
    let schema = Namespaced_IRI.parse _namespace_name "schema" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#ListType"></see>
    /// </summary>
    let ListType = Namespaced_IRI.parse _namespace_name "ListType" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#memberType"></see>
    /// </summary>
    let memberType = Namespaced_IRI.parse _namespace_name "memberType" |> NamespacedName

    /// <summary>
    /// A test case that runs a given GraphQL mutation (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The mutation is executed over a given "before" graph which must be isomorphic to a given "after" graph. The TestCase is also a graphql:Schema defining which shapes to publish.
    /// <see href="http://datashapes.org/graphql#MutationTestCase"></see></summary>
    let MutationTestCase =
        Namespaced_IRI.parse _namespace_name "MutationTestCase" |> NamespacedName

    /// <summary>
    /// Represents specific GraphQL queries, stored by their query string and possibly other properties with metadata.
    /// <see href="http://datashapes.org/graphql#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#dataGraph"></see>
    /// </summary>
    let dataGraph = Namespaced_IRI.parse _namespace_name "dataGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#expectedGraph"></see>
    /// </summary>
    let expectedGraph =
        Namespaced_IRI.parse _namespace_name "expectedGraph" |> NamespacedName

    /// <summary>
    /// Defines syntax restrictions on the use of the graphql:name property.
    /// <see href="http://datashapes.org/graphql#NameShape"></see></summary>
    let NameShape = Namespaced_IRI.parse _namespace_name "NameShape" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#NamedType"></see>
    /// </summary>
    let NamedType = Namespaced_IRI.parse _namespace_name "NamedType" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#NodeShapeShape"></see>
    /// </summary>
    let NodeShapeShape =
        Namespaced_IRI.parse _namespace_name "NodeShapeShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#privateShape"></see>
    /// </summary>
    let privateShape =
        Namespaced_IRI.parse _namespace_name "privateShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#protectedShape"></see>
    /// </summary>
    let protectedShape =
        Namespaced_IRI.parse _namespace_name "protectedShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#publicShape"></see>
    /// </summary>
    let publicShape =
        Namespaced_IRI.parse _namespace_name "publicShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#NonNullType"></see>
    /// </summary>
    let NonNullType =
        Namespaced_IRI.parse _namespace_name "NonNullType" |> NamespacedName

    /// <summary>
    /// The text of the actual query in GraphQL syntax.
    /// <see href="http://datashapes.org/graphql#queryString"></see></summary>
    let queryString =
        Namespaced_IRI.parse _namespace_name "queryString" |> NamespacedName

    /// <summary>
    /// An optional JSON object with variables that shall be passed into the query for execution.
    /// <see href="http://datashapes.org/graphql#variables"></see></summary>
    let variables = Namespaced_IRI.parse _namespace_name "variables" |> NamespacedName

    /// <summary>
    /// A test case that runs a given GraphQL query (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The TestCase is also a graphql:Schema defining which shapes to publish.
    /// <see href="http://datashapes.org/graphql#QueryTestCase"></see></summary>
    let QueryTestCase =
        Namespaced_IRI.parse _namespace_name "QueryTestCase" |> NamespacedName

    /// <summary>
    /// Represents a scalar type as defined by a GraphQL schema. The primary purpose of these types is for round-tripping, otherwise they are basically the same as node shapes. The instances must be URIs, and the GraphQL name is derived from them.
    ///
    /// This is currently not marked as a subClassOf sh:NodeShape, although this may happen in the future. The idea is that we don't want all constraint parameters to apply here, only selected ones such as sh:datatype. In the SHACL spec, anything that has constraints counts as a node shape, even if it doesn't have a matching rdf:type triple.
    /// <see href="http://datashapes.org/graphql#ScalarType"></see></summary>
    let ScalarType = Namespaced_IRI.parse _namespace_name "ScalarType" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-protectedShape"></see>
    /// </summary>
    let ``Schema-protectedShape`` =
        Namespaced_IRI.parse _namespace_name "Schema-protectedShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-privateShape"></see>
    /// </summary>
    let ``Schema-privateShape`` =
        Namespaced_IRI.parse _namespace_name "Schema-privateShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#queryShape"></see>
    /// </summary>
    let queryShape = Namespaced_IRI.parse _namespace_name "queryShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-protectedClass"></see>
    /// </summary>
    let ``Schema-protectedClass`` =
        Namespaced_IRI.parse _namespace_name "Schema-protectedClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-publicShape"></see>
    /// </summary>
    let ``Schema-publicShape`` =
        Namespaced_IRI.parse _namespace_name "Schema-publicShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-publicNamespace"></see>
    /// </summary>
    let ``Schema-publicNamespace`` =
        Namespaced_IRI.parse _namespace_name "Schema-publicNamespace" |> NamespacedName

    /// <summary>
    /// Points at a prefix declaration of the default namespace for the shapes derived by GraphQL types. This property can be used to round-trip .graphql files.
    /// <see href="http://datashapes.org/graphql#defaultPrefix"></see></summary>
    let defaultPrefix =
        Namespaced_IRI.parse _namespace_name "defaultPrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-publicClass"></see>
    /// </summary>
    let ``Schema-publicClass`` =
        Namespaced_IRI.parse _namespace_name "Schema-publicClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#ShapesPropertyGroup"></see>
    /// </summary>
    let ShapesPropertyGroup =
        Namespaced_IRI.parse _namespace_name "ShapesPropertyGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#publicNamespace"></see>
    /// </summary>
    let publicNamespace =
        Namespaced_IRI.parse _namespace_name "publicNamespace" |> NamespacedName

    /// <summary>
    /// A test case that can be used to verify that a RDF/SHACL to GraphQL writer works correctly. The expected result must be the complete GraphQL schema string.
    /// <see href="http://datashapes.org/graphql#WriterTestCase"></see></summary>
    let WriterTestCase =
        Namespaced_IRI.parse _namespace_name "WriterTestCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#canRoundTrip"></see>
    /// </summary>
    let canRoundTrip =
        Namespaced_IRI.parse _namespace_name "canRoundTrip" |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#rdfGraph"></see>
    /// </summary>
    let rdfGraph = Namespaced_IRI.parse _namespace_name "rdfGraph" |> NamespacedName
    /// <summary>
    /// Gets the GraphQL field name for a property path at a given node shape.
    /// <see href="http://datashapes.org/graphql#fieldName"></see></summary>
    let fieldName = Namespaced_IRI.parse _namespace_name "fieldName" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#nodeShape"></see>
    /// </summary>
    let nodeShape = Namespaced_IRI.parse _namespace_name "nodeShape" |> NamespacedName
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#path"></see>
    /// </summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    /// Can be attached to property shapes to indicate they should be round-tripped as GraphQL type ID.
    /// <see href="http://datashapes.org/graphql#isIDField"></see></summary>
    let isIDField = Namespaced_IRI.parse _namespace_name "isIDField" |> NamespacedName

    /// <summary>
    /// If set to true for a node shape, then it should become a GraphQL interface.
    /// <see href="http://datashapes.org/graphql#isInterface"></see></summary>
    let isInterface =
        Namespaced_IRI.parse _namespace_name "isInterface" |> NamespacedName

    /// <summary>
    /// The GraphQL query string.
    /// <see href="http://datashapes.org/graphql#query"></see></summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName

    /// <summary>
    /// Can be used to attach a URI template to node shapes, meaning that JSON objects that are processed with the given node shape will become URI resources with a URI derived from the given template. Example: "ex:Person-{$id}".
    ///
    /// URI templates can include {...} blocks that contain a variable reference such as $id if the corresponding GraphQL type has a field named "id". Fields are mandatory by default, meaning that if a JSON converter attempts to produce a URI that lacks a mandatory field then the conversion fails with an exception.
    /// <see href="http://datashapes.org/graphql#uriTemplate"></see></summary>
    let uriTemplate =
        Namespaced_IRI.parse _namespace_name "uriTemplate" |> NamespacedName
