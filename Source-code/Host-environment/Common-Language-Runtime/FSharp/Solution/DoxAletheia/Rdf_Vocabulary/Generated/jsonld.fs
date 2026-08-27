namespace http.www.w3.org.ns.json_ld.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module jsonld =
    let _namespace_iri = Namespace_Iri jsonld |> NamespaceIRI
    /// <summary>
    ///   <para>jsonld:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#">http://www.w3.org/ns/json-ld#</seealso>
    let _prefix_iri = Prefixed_Name(jsonld, "") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:ContainerType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#ContainerType">http://www.w3.org/ns/json-ld#ContainerType</seealso>
    let ContainerType = Prefixed_Name(jsonld, "ContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Defines term definitions and other aspects of a JSON-LD `Context`.
    ///
    /// A [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) MUST be a map whose keys MUST be either _terms_, _compact IRIs_, _IRIs_, or one of the keywords `@base`, `@import`, `@language`, `@propagate`, `@protected`, `@type`, `@version`, or `@vocab`."</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#Context">http://www.w3.org/ns/json-ld#Context</seealso>
    let Context = Prefixed_Name(jsonld, "Context") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:PrefixDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A string ([simple term definition](http://www.w3.org/TR/json-ld11/#dfn-simple-term-definitions)), expanding to an IRI."</para>
    /// labels<para>"Prefix Definition"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#PrefixDefinition">http://www.w3.org/ns/json-ld#PrefixDefinition</seealso>
    let PrefixDefinition = Prefixed_Name(jsonld, "PrefixDefinition") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:TermDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A [term definition](http://www.w3.org/TR/json-ld11/#dfn-term-definitions) is an entry in a [context](#Context), where the key defines a term which may be used within a dictionary as a key, type, or elsewhere that a string is interpreted as a vocabulary item. Its value is an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    ///
    ///
    ///
    /// An [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definition) MUST be a map composed of zero or more keys from `@id`, `@reverse`, `@type`, `@language`, `@container`, `@context`, `@prefix`, `@propagate`, or `@protected`. An expanded term definition SHOULD NOT contain any other keys."</para>
    /// labels<para>"Term Definition"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#TermDefinition">http://www.w3.org/ns/json-ld#TermDefinition</seealso>
    let TermDefinition = Prefixed_Name(jsonld, "TermDefinition") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:base</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) has an `@base` key, its value MUST be an _IRI reference_, or `null`."</para>
    /// labels<para>"base"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#base">http://www.w3.org/ns/json-ld#base</seealso>
    let base_ = Prefixed_Name(jsonld, "base") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:compacted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This profile IRI is used to request or specify compacted JSON-LD document form."</para>
    /// labels<para>"compacted"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#compacted">http://www.w3.org/ns/json-ld#compacted</seealso>
    let compacted = Prefixed_Name(jsonld, "compacted") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:container</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The associated `@container` value in an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    ///
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an array containing exactly any one of those keywords, or a combination of `@set` and any of `@index`, `@id`, `@graph`, `@type`, `@language` in any order.
    ///
    /// `@container` may also be an array containing `@graph` along with either `@id` or `@index` and also optionally including `@set`.
    ///
    /// If the value is `@language`, when the term is used outside of the `@context`, the associated value MUST be a language map.
    ///
    /// If the value is `@index`, when the term is used outside of the `@context`, the associated value MUST be an index map."</para>
    /// labels<para>"container"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#container">http://www.w3.org/ns/json-ld#container</seealso>
    let container = Prefixed_Name(jsonld, "container") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"As an IRI, this link relation is used to associate a JSON-LD context with a JSON document so that it can be interpreted as JSON-LD. In an HTTP request header, specifies the location of a context to use for compaction. As a Context, defines an inline `context definition`."</para>
    /// labels<para>"context"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#context">http://www.w3.org/ns/json-ld#context</seealso>
    let context = Prefixed_Name(jsonld, "context") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Term definition(s) associated with this context."</para>
    /// labels<para>"definition"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#definition">http://www.w3.org/ns/json-ld#definition</seealso>
    let definition = Prefixed_Name(jsonld, "definition") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) has an `@direction` key, its value MUST be one of `"ltr"` or `"rtl"`, or be `null`."</para>
    /// labels<para>"direction"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#direction">http://www.w3.org/ns/json-ld#direction</seealso>
    let direction = Prefixed_Name(jsonld, "direction") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:expanded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This profile URI is used to request or specify expanded JSON-LD document form."</para>
    /// labels<para>"expanded"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#expanded">http://www.w3.org/ns/json-ld#expanded</seealso>
    let expanded = Prefixed_Name(jsonld, "expanded") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:flattened</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This profile URI is used to request or specify flattened JSON-LD document form."</para>
    /// labels<para>"flattened"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#flattened">http://www.w3.org/ns/json-ld#flattened</seealso>
    let flattened = Prefixed_Name(jsonld, "flattened") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"As an IRI, this link relation is used to associate a JSON-LD frame with a JSON-LD document. In an HTTP request header, specifies the location of a frame to use for framing."</para>
    /// labels<para>"frame"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#frame">http://www.w3.org/ns/json-ld#frame</seealso>
    let frame = Prefixed_Name(jsonld, "frame") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:framed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This profile URI is used to request or specify framed JSON-LD document form."</para>
    /// labels<para>"framed"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#framed">http://www.w3.org/ns/json-ld#framed</seealso>
    let framed = Prefixed_Name(jsonld, "framed") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:graphContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@graph"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#graphContainerType">http://www.w3.org/ns/json-ld#graphContainerType</seealso>
    let graphContainerType = Prefixed_Name(jsonld, "graphContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The `@id` mapping of a [term definition](#TermDefinition)."</para>
    /// labels<para>"id"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#id">http://www.w3.org/ns/json-ld#id</seealso>
    let id = Prefixed_Name(jsonld, "id") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:idContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@id"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#idContainerType">http://www.w3.org/ns/json-ld#idContainerType</seealso>
    let idContainerType = Prefixed_Name(jsonld, "idContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:import</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@import` keyword, its value MUST be an _IRI reference_. When used as a reference from an `@import`, the referenced context definition MUST NOT include an `@import` key, itself."</para>
    /// labels<para>"import"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#import">http://www.w3.org/ns/json-ld#import</seealso>
    let import = Prefixed_Name(jsonld, "import") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:indexContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@index"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#indexContainerType">http://www.w3.org/ns/json-ld#indexContainerType</seealso>
    let indexContainerType = Prefixed_Name(jsonld, "indexContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The [default language](https://www.w3.org/TR/json-ld11/#dfn-default-language) is set in the context using the `@language` key whose value MUST be a string representing a [BCP47](https://tools.ietf.org/html/bcp47) language code or null."</para>
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#language">http://www.w3.org/ns/json-ld#language</seealso>
    let language = Prefixed_Name(jsonld, "language") |> PrefixedName

    /// <summary>
    ///   <para>jsonld:languageContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@language"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#languageContainerType">http://www.w3.org/ns/json-ld#languageContainerType</seealso>
    let languageContainerType =
        Prefixed_Name(jsonld, "languageContainerType") |> PrefixedName

    /// <summary>
    ///   <para>jsonld:listContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@list"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#listContainerType">http://www.w3.org/ns/json-ld#listContainerType</seealso>
    let listContainerType = Prefixed_Name(jsonld, "listContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:nest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@nest` keyword, its value MUST be either `@nest`, or a _term_ which expands to `@nest`."</para>
    /// labels<para>"nest"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#nest">http://www.w3.org/ns/json-ld#nest</seealso>
    let nest = Prefixed_Name(jsonld, "nest") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"With the value `true`, allows this term to be used to construct a compact IRI when compacting."</para>
    /// labels<para>"prefix"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#prefix">http://www.w3.org/ns/json-ld#prefix</seealso>
    let prefix = Prefixed_Name(jsonld, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:propagate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@propagate` keyword, its value MUST be `true` or `false`."</para>
    /// labels<para>"propagate"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#propagate">http://www.w3.org/ns/json-ld#propagate</seealso>
    let propagate = Prefixed_Name(jsonld, "propagate") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:protected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@protected` keyword, its value MUST be `true` or `false`."</para>
    /// labels<para>"protected"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#protected">http://www.w3.org/ns/json-ld#protected</seealso>
    let protected_ = Prefixed_Name(jsonld, "protected") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:reverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The `@reverse` mapping of an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions)."</para>
    /// labels<para>"reverse"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#reverse">http://www.w3.org/ns/json-ld#reverse</seealso>
    let reverse = Prefixed_Name(jsonld, "reverse") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:setContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#setContainerType">http://www.w3.org/ns/json-ld#setContainerType</seealso>
    let setContainerType = Prefixed_Name(jsonld, "setContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:streaming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This profile URI is used to request or specify streaming JSON-LD document form."</para>
    /// labels<para>"streaming"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#streaming">http://www.w3.org/ns/json-ld#streaming</seealso>
    let streaming = Prefixed_Name(jsonld, "streaming") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The term associated with a [term definition](#TermDefinition)."</para>
    /// labels<para>"term"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#term">http://www.w3.org/ns/json-ld#term</seealso>
    let term = Prefixed_Name(jsonld, "term") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@type` keyword, its value MUST be a map with only the entry `@container` set to `@set`, and optionally an entry `@protected`.
    ///
    ///
    ///
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@type` keyword, its value MUST be an _IRI reference_, a _term_, `null`, or one of the keywords `@id`, `@json`, `@none`, or `@vocab`."</para>
    /// labels<para>"type"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#type">http://www.w3.org/ns/json-ld#type</seealso>
    let type_ = Prefixed_Name(jsonld, "type") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:typeContainerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords."</para>
    /// labels<para>"@type"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#typeContainerType">http://www.w3.org/ns/json-ld#typeContainerType</seealso>
    let typeContainerType = Prefixed_Name(jsonld, "typeContainerType") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The [processing mode](https://www.w3.org/TR/json-ld11/#dfn-processing-mode) defines how a JSON-LD document is processed. By default, all documents are assumed to be conformant with [JSON-LD 1.1`](http://www.w3.org/TR/json-ld11). By defining a different version via explicit API option, other processing modes can be accessed. This specification defines extensions for the `json-ld-1.1` processing mode."</para>
    /// labels<para>"version"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#version">http://www.w3.org/ns/json-ld#version</seealso>
    let version = Prefixed_Name(jsonld, "version") |> PrefixedName
    /// <summary>
    ///   <para>jsonld:vocab</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to expand properties and values in `@type` with a common prefix IRI."</para>
    /// labels<para>"vocab"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/json-ld#vocab">http://www.w3.org/ns/json-ld#vocab</seealso>
    let vocab = Prefixed_Name(jsonld, "vocab") |> PrefixedName
