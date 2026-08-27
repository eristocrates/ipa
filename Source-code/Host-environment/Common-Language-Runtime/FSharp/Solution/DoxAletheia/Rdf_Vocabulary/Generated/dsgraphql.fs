namespace http.datashapes.org.graphql.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dsgraphql =
    let _namespace_iri = Namespace_Iri dsgraphql |> NamespaceIRI
    /// <summary>
    ///   <para>dsgraphql:ClassShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>shacl:PropertyShape</para>
    ///
    /// labels<para>"GraphQL class shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#ClassShape">http://datashapes.org/graphql#ClassShape</seealso>
    let ClassShape = Prefixed_Name(dsgraphql, "ClassShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:InputObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Represents an input object type in a GraphQL schema."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input object type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#InputObjectType">http://datashapes.org/graphql#InputObjectType</seealso>
    let InputObjectType = Prefixed_Name(dsgraphql, "InputObjectType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:InputType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///
    /// labels<para>"Input type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#InputType">http://datashapes.org/graphql#InputType</seealso>
    let InputType = Prefixed_Name(dsgraphql, "InputType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:InputValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The definition of an input value, consisting of a name, type and an optional default value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#InputValue">http://datashapes.org/graphql#InputValue</seealso>
    let InputValue = Prefixed_Name(dsgraphql, "InputValue") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:JSON2RDFTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A test case that can be used to verify that a given JSON object is translated into RDF triples using shape definitions from a given graphql:Service. The service must be in the test case graph."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JSON-to-RDF test case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#JSON2RDFTestCase">http://datashapes.org/graphql#JSON2RDFTestCase</seealso>
    let JSON2RDFTestCase = Prefixed_Name(dsgraphql, "JSON2RDFTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:ListType</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"List type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#ListType">http://datashapes.org/graphql#ListType</seealso>
    let ListType = Prefixed_Name(dsgraphql, "ListType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:MutationTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A test case that runs a given GraphQL mutation (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The mutation is executed over a given "before" graph which must be isomorphic to a given "after" graph. The TestCase is also a graphql:Schema defining which shapes to publish."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphQL mutation test case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#MutationTestCase">http://datashapes.org/graphql#MutationTestCase</seealso>
    let MutationTestCase = Prefixed_Name(dsgraphql, "MutationTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:NameShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Defines syntax restrictions on the use of the graphql:name property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Name shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#NameShape">http://datashapes.org/graphql#NameShape</seealso>
    let NameShape = Prefixed_Name(dsgraphql, "NameShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:NamedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///
    /// labels<para>"Named type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#NamedType">http://datashapes.org/graphql#NamedType</seealso>
    let NamedType = Prefixed_Name(dsgraphql, "NamedType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:NodeShapeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///
    /// labels<para>"GraphQL node shape shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#NodeShapeShape">http://datashapes.org/graphql#NodeShapeShape</seealso>
    let NodeShapeShape = Prefixed_Name(dsgraphql, "NodeShapeShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:NonNullType</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Non null type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#NonNullType">http://datashapes.org/graphql#NonNullType</seealso>
    let NonNullType = Prefixed_Name(dsgraphql, "NonNullType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Represents specific GraphQL queries, stored by their query string and possibly other properties with metadata."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphQL query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#Query">http://datashapes.org/graphql#Query</seealso>
    let Query = Prefixed_Name(dsgraphql, "Query") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:QueryTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>"A test case that runs a given GraphQL query (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The TestCase is also a graphql:Schema defining which shapes to publish."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphQL query test case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#QueryTestCase">http://datashapes.org/graphql#QueryTestCase</seealso>
    let QueryTestCase = Prefixed_Name(dsgraphql, "QueryTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:ScalarType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Represents a scalar type as defined by a GraphQL schema. The primary purpose of these types is for round-tripping, otherwise they are basically the same as node shapes. The instances must be URIs, and the GraphQL name is derived from them.
    ///
    /// This is currently not marked as a subClassOf sh:NodeShape, although this may happen in the future. The idea is that we don't want all constraint parameters to apply here, only selected ones such as sh:datatype. In the SHACL spec, anything that has constraints counts as a node shape, even if it doesn't have a matching rdf:type triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scalar type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#ScalarType">http://datashapes.org/graphql#ScalarType</seealso>
    let ScalarType = Prefixed_Name(dsgraphql, "ScalarType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A collection of shapes that are part of a GraphQL schema. Includes declarations about which shapes shall be exposed/published by a GraphQL service. The set of public node shapes consists of all values of graphql:publicShape, all values of graphql:publicClass and their subclasses, all node shapes from any namespace graphql:publicNamespace, minus any explicitly excluded shapes via graphql:privateShape.
    ///
    /// An RDF graph may contain multiple GraphQL schemas, each providing a different API or view on the underlying data. GraphQL services can include each other using owl:imports. To simplify common usage patterns, owl:Ontology has been marked as a subclass, so that all Ontologies are also graphql:Schemas once this graphql namespace is imported."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphQL Schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema">http://datashapes.org/graphql#Schema</seealso>
    let Schema = Prefixed_Name(dsgraphql, "Schema") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:Schema-privateShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema-privateShape">http://datashapes.org/graphql#Schema-privateShape</seealso>
    let Schema_privateShape =
        Prefixed_Name(dsgraphql, "Schema-privateShape") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:Schema-protectedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema-protectedClass">http://datashapes.org/graphql#Schema-protectedClass</seealso>
    let Schema_protectedClass =
        Prefixed_Name(dsgraphql, "Schema-protectedClass") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:Schema-protectedShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema-protectedShape">http://datashapes.org/graphql#Schema-protectedShape</seealso>
    let Schema_protectedShape =
        Prefixed_Name(dsgraphql, "Schema-protectedShape") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:Schema-publicClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema-publicClass">http://datashapes.org/graphql#Schema-publicClass</seealso>
    let Schema_publicClass =
        Prefixed_Name(dsgraphql, "Schema-publicClass") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:Schema-publicNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema-publicNamespace">http://datashapes.org/graphql#Schema-publicNamespace</seealso>
    let Schema_publicNamespace =
        Prefixed_Name(dsgraphql, "Schema-publicNamespace") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:Schema-publicShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#Schema-publicShape">http://datashapes.org/graphql#Schema-publicShape</seealso>
    let Schema_publicShape =
        Prefixed_Name(dsgraphql, "Schema-publicShape") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:SchemaPropertyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyGroup</para>
    ///
    /// labels<para>"GraphQL Schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#SchemaPropertyGroup">http://datashapes.org/graphql#SchemaPropertyGroup</seealso>
    let SchemaPropertyGroup =
        Prefixed_Name(dsgraphql, "SchemaPropertyGroup") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:ShapesPropertyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyGroup</para>
    ///
    /// labels<para>"Shapes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#ShapesPropertyGroup">http://datashapes.org/graphql#ShapesPropertyGroup</seealso>
    let ShapesPropertyGroup =
        Prefixed_Name(dsgraphql, "ShapesPropertyGroup") |> PrefixedName

    /// <summary>
    ///   <para>dsgraphql:WriterTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:PropertyShape</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A test case that can be used to verify that a RDF/SHACL to GraphQL writer works correctly. The expected result must be the complete GraphQL schema string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Writer test case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#WriterTestCase">http://datashapes.org/graphql#WriterTestCase</seealso>
    let WriterTestCase = Prefixed_Name(dsgraphql, "WriterTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:canRoundTrip</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#canRoundTrip">http://datashapes.org/graphql#canRoundTrip</seealso>
    let canRoundTrip = Prefixed_Name(dsgraphql, "canRoundTrip") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:dataGraph</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#dataGraph">http://datashapes.org/graphql#dataGraph</seealso>
    let dataGraph = Prefixed_Name(dsgraphql, "dataGraph") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:defaultPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points at a prefix declaration of the default namespace for the shapes derived by GraphQL types. This property can be used to round-trip .graphql files."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"default prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#defaultPrefix">http://datashapes.org/graphql#defaultPrefix</seealso>
    let defaultPrefix = Prefixed_Name(dsgraphql, "defaultPrefix") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:defaultValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#defaultValue">http://datashapes.org/graphql#defaultValue</seealso>
    let defaultValue = Prefixed_Name(dsgraphql, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:expectedGraph</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#expectedGraph">http://datashapes.org/graphql#expectedGraph</seealso>
    let expectedGraph = Prefixed_Name(dsgraphql, "expectedGraph") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:fieldName</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    ///   <para>shacl:Function</para>
    ///   <para>"Gets the GraphQL field name for a property path at a given node shape."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"field name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#fieldName">http://datashapes.org/graphql#fieldName</seealso>
    let fieldName = Prefixed_Name(dsgraphql, "fieldName") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:inputValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#inputValue">http://datashapes.org/graphql#inputValue</seealso>
    let inputValue = Prefixed_Name(dsgraphql, "inputValue") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:isIDField</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be attached to property shapes to indicate they should be round-tripped as GraphQL type ID."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is ID field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#isIDField">http://datashapes.org/graphql#isIDField</seealso>
    let isIDField = Prefixed_Name(dsgraphql, "isIDField") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:isInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If set to true for a node shape, then it should become a GraphQL interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is GraphQL interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#isInterface">http://datashapes.org/graphql#isInterface</seealso>
    let isInterface = Prefixed_Name(dsgraphql, "isInterface") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:json</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#json">http://datashapes.org/graphql#json</seealso>
    let json = Prefixed_Name(dsgraphql, "json") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:memberType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#memberType">http://datashapes.org/graphql#memberType</seealso>
    let memberType = Prefixed_Name(dsgraphql, "memberType") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines a GraphQL name for a given subject. The values need to match the regular expression specified in http://facebook.github.io/graphql/October2016/#Name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#name">http://datashapes.org/graphql#name</seealso>
    let name = Prefixed_Name(dsgraphql, "name") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:nodeShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#nodeShape">http://datashapes.org/graphql#nodeShape</seealso>
    let nodeShape = Prefixed_Name(dsgraphql, "nodeShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:path</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#path">http://datashapes.org/graphql#path</seealso>
    let path = Prefixed_Name(dsgraphql, "path") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:privateShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#privateShape">http://datashapes.org/graphql#privateShape</seealso>
    let privateShape = Prefixed_Name(dsgraphql, "privateShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:protectedClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#protectedClass">http://datashapes.org/graphql#protectedClass</seealso>
    let protectedClass = Prefixed_Name(dsgraphql, "protectedClass") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:protectedShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#protectedShape">http://datashapes.org/graphql#protectedShape</seealso>
    let protectedShape = Prefixed_Name(dsgraphql, "protectedShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:publicClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#publicClass">http://datashapes.org/graphql#publicClass</seealso>
    let publicClass = Prefixed_Name(dsgraphql, "publicClass") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:publicNamespace</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#publicNamespace">http://datashapes.org/graphql#publicNamespace</seealso>
    let publicNamespace = Prefixed_Name(dsgraphql, "publicNamespace") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:publicShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#publicShape">http://datashapes.org/graphql#publicShape</seealso>
    let publicShape = Prefixed_Name(dsgraphql, "publicShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The GraphQL query string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#query">http://datashapes.org/graphql#query</seealso>
    let query = Prefixed_Name(dsgraphql, "query") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:queryShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"query shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#queryShape">http://datashapes.org/graphql#queryShape</seealso>
    let queryShape = Prefixed_Name(dsgraphql, "queryShape") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:queryString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The text of the actual query in GraphQL syntax."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"query string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#queryString">http://datashapes.org/graphql#queryString</seealso>
    let queryString = Prefixed_Name(dsgraphql, "queryString") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:rdfGraph</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#rdfGraph">http://datashapes.org/graphql#rdfGraph</seealso>
    let rdfGraph = Prefixed_Name(dsgraphql, "rdfGraph") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/graphql#schema">http://datashapes.org/graphql#schema</seealso>
    let schema = Prefixed_Name(dsgraphql, "schema") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/graphql#type">http://datashapes.org/graphql#type</seealso>
    let type_ = Prefixed_Name(dsgraphql, "type") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:uriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Can be used to attach a URI template to node shapes, meaning that JSON objects that are processed with the given node shape will become URI resources with a URI derived from the given template. Example: "ex:Person-{$id}".
    ///
    /// URI templates can include {...} blocks that contain a variable reference such as $id if the corresponding GraphQL type has a field named "id". Fields are mandatory by default, meaning that if a JSON converter attempts to produce a URI that lacks a mandatory field then the conversion fails with an exception."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphQL URI template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#uriTemplate">http://datashapes.org/graphql#uriTemplate</seealso>
    let uriTemplate = Prefixed_Name(dsgraphql, "uriTemplate") |> PrefixedName
    /// <summary>
    ///   <para>dsgraphql:variables</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An optional JSON object with variables that shall be passed into the query for execution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"variables"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://datashapes.org/graphql#variables">http://datashapes.org/graphql#variables</seealso>
    let variables = Prefixed_Name(dsgraphql, "variables") |> PrefixedName
