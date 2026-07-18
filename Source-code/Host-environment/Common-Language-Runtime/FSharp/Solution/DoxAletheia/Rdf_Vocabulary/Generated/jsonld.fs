namespace http.www.w3.org.ns.json_ld.hash

open DoxAletheia.Rdf_Vocabulary

module jsonld =
    let _namespace_name = "http://www.w3.org/ns/json-ld#"
    /// <summary>
    /// Defines term definitions and other aspects of a JSON-LD `Context`.
    ///
    /// A [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) MUST be a map whose keys MUST be either _terms_, _compact IRIs_, _IRIs_, or one of the keywords `@base`, `@import`, `@language`, `@propagate`, `@protected`, `@type`, `@version`, or `@vocab`.
    /// <see href="http://www.w3.org/ns/json-ld#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    /// A string ([simple term definition](http://www.w3.org/TR/json-ld11/#dfn-simple-term-definitions)), expanding to an IRI.
    /// <see href="http://www.w3.org/ns/json-ld#PrefixDefinition"></see></summary>
    let PrefixDefinition =
        Namespaced_IRI.parse _namespace_name "PrefixDefinition" |> NamespacedName

    /// <summary>
    /// A [term definition](http://www.w3.org/TR/json-ld11/#dfn-term-definitions) is an entry in a [context](#Context), where the key defines a term which may be used within a dictionary as a key, type, or elsewhere that a string is interpreted as a vocabulary item. Its value is an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    ///
    ///
    ///
    /// An [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definition) MUST be a map composed of zero or more keys from `@id`, `@reverse`, `@type`, `@language`, `@container`, `@context`, `@prefix`, `@propagate`, or `@protected`. An expanded term definition SHOULD NOT contain any other keys.
    /// <see href="http://www.w3.org/ns/json-ld#TermDefinition"></see></summary>
    let TermDefinition =
        Namespaced_IRI.parse _namespace_name "TermDefinition" |> NamespacedName

    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) has an `@base` key, its value MUST be an _IRI reference_, or `null`.
    /// <see href="http://www.w3.org/ns/json-ld#base"></see></summary>
    let base_ = Namespaced_IRI.parse _namespace_name "base" |> NamespacedName
    /// <summary>
    /// This profile IRI is used to request or specify compacted JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#compacted"></see></summary>
    let compacted = Namespaced_IRI.parse _namespace_name "compacted" |> NamespacedName
    /// <summary>
    /// The associated `@container` value in an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    ///
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an array containing exactly any one of those keywords, or a combination of `@set` and any of `@index`, `@id`, `@graph`, `@type`, `@language` in any order.
    ///
    /// `@container` may also be an array containing `@graph` along with either `@id` or `@index` and also optionally including `@set`.
    ///
    /// If the value is `@language`, when the term is used outside of the `@context`, the associated value MUST be a language map.
    ///
    /// If the value is `@index`, when the term is used outside of the `@context`, the associated value MUST be an index map.
    /// <see href="http://www.w3.org/ns/json-ld#container"></see></summary>
    let container = Namespaced_IRI.parse _namespace_name "container" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/json-ld#ContainerType"></see>
    /// </summary>
    let ContainerType =
        Namespaced_IRI.parse _namespace_name "ContainerType" |> NamespacedName

    /// <summary>
    /// As an IRI, this link relation is used to associate a JSON-LD context with a JSON document so that it can be interpreted as JSON-LD. In an HTTP request header, specifies the location of a context to use for compaction. As a Context, defines an inline `context definition`.
    /// <see href="http://www.w3.org/ns/json-ld#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    /// Term definition(s) associated with this context.
    /// <see href="http://www.w3.org/ns/json-ld#definition"></see></summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) has an `@direction` key, its value MUST be one of `"ltr"` or `"rtl"`, or be `null`.
    /// <see href="http://www.w3.org/ns/json-ld#direction"></see></summary>
    let direction = Namespaced_IRI.parse _namespace_name "direction" |> NamespacedName
    /// <summary>
    /// This profile URI is used to request or specify expanded JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#expanded"></see></summary>
    let expanded = Namespaced_IRI.parse _namespace_name "expanded" |> NamespacedName
    /// <summary>
    /// This profile URI is used to request or specify flattened JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#flattened"></see></summary>
    let flattened = Namespaced_IRI.parse _namespace_name "flattened" |> NamespacedName
    /// <summary>
    /// As an IRI, this link relation is used to associate a JSON-LD frame with a JSON-LD document. In an HTTP request header, specifies the location of a frame to use for framing.
    /// <see href="http://www.w3.org/ns/json-ld#frame"></see></summary>
    let frame = Namespaced_IRI.parse _namespace_name "frame" |> NamespacedName
    /// <summary>
    /// This profile URI is used to request or specify framed JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#framed"></see></summary>
    let framed = Namespaced_IRI.parse _namespace_name "framed" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#graphContainerType"></see></summary>
    let graphContainerType =
        Namespaced_IRI.parse _namespace_name "graphContainerType" |> NamespacedName

    /// <summary>
    /// The `@id` mapping of a [term definition](#TermDefinition).
    /// <see href="http://www.w3.org/ns/json-ld#id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#idContainerType"></see></summary>
    let idContainerType =
        Namespaced_IRI.parse _namespace_name "idContainerType" |> NamespacedName

    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@import` keyword, its value MUST be an _IRI reference_. When used as a reference from an `@import`, the referenced context definition MUST NOT include an `@import` key, itself.
    /// <see href="http://www.w3.org/ns/json-ld#import"></see></summary>
    let import = Namespaced_IRI.parse _namespace_name "import" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#indexContainerType"></see></summary>
    let indexContainerType =
        Namespaced_IRI.parse _namespace_name "indexContainerType" |> NamespacedName

    /// <summary>
    /// The [default language](https://www.w3.org/TR/json-ld11/#dfn-default-language) is set in the context using the `@language` key whose value MUST be a string representing a [BCP47](https://tools.ietf.org/html/bcp47) language code or null.
    /// <see href="http://www.w3.org/ns/json-ld#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#languageContainerType"></see></summary>
    let languageContainerType =
        Namespaced_IRI.parse _namespace_name "languageContainerType" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#listContainerType"></see></summary>
    let listContainerType =
        Namespaced_IRI.parse _namespace_name "listContainerType" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@nest` keyword, its value MUST be either `@nest`, or a _term_ which expands to `@nest`.
    /// <see href="http://www.w3.org/ns/json-ld#nest"></see></summary>
    let nest = Namespaced_IRI.parse _namespace_name "nest" |> NamespacedName
    /// <summary>
    /// With the value `true`, allows this term to be used to construct a compact IRI when compacting.
    /// <see href="http://www.w3.org/ns/json-ld#prefix"></see></summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@propagate` keyword, its value MUST be `true` or `false`.
    /// <see href="http://www.w3.org/ns/json-ld#propagate"></see></summary>
    let propagate = Namespaced_IRI.parse _namespace_name "propagate" |> NamespacedName
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@protected` keyword, its value MUST be `true` or `false`.
    /// <see href="http://www.w3.org/ns/json-ld#protected"></see></summary>
    let protected_ = Namespaced_IRI.parse _namespace_name "protected" |> NamespacedName
    /// <summary>
    /// The `@reverse` mapping of an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    /// <see href="http://www.w3.org/ns/json-ld#reverse"></see></summary>
    let reverse = Namespaced_IRI.parse _namespace_name "reverse" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#setContainerType"></see></summary>
    let setContainerType =
        Namespaced_IRI.parse _namespace_name "setContainerType" |> NamespacedName

    /// <summary>
    /// This profile URI is used to request or specify streaming JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#streaming"></see></summary>
    let streaming = Namespaced_IRI.parse _namespace_name "streaming" |> NamespacedName
    /// <summary>
    /// The term associated with a [term definition](#TermDefinition).
    /// <see href="http://www.w3.org/ns/json-ld#term"></see></summary>
    let term = Namespaced_IRI.parse _namespace_name "term" |> NamespacedName
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@type` keyword, its value MUST be a map with only the entry `@container` set to `@set`, and optionally an entry `@protected`.
    ///
    ///
    ///
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@type` keyword, its value MUST be an _IRI reference_, a _term_, `null`, or one of the keywords `@id`, `@json`, `@none`, or `@vocab`.
    /// <see href="http://www.w3.org/ns/json-ld#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#typeContainerType"></see></summary>
    let typeContainerType =
        Namespaced_IRI.parse _namespace_name "typeContainerType" |> NamespacedName

    /// <summary>
    /// The [processing mode](https://www.w3.org/TR/json-ld11/#dfn-processing-mode) defines how a JSON-LD document is processed. By default, all documents are assumed to be conformant with [JSON-LD 1.1`](http://www.w3.org/TR/json-ld11). By defining a different version via explicit API option, other processing modes can be accessed. This specification defines extensions for the `json-ld-1.1` processing mode.
    /// <see href="http://www.w3.org/ns/json-ld#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// Used to expand properties and values in `@type` with a common prefix IRI.
    /// <see href="http://www.w3.org/ns/json-ld#vocab"></see></summary>
    let vocab = Namespaced_IRI.parse _namespace_name "vocab" |> NamespacedName
