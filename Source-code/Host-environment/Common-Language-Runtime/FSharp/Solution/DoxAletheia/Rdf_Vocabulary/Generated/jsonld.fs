namespace http.www.w3.org.ns.json_ld.hash

open DoxAletheia

module jsonld =
    let _namespace_name = "http://www.w3.org/ns/json-ld#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Defines term definitions and other aspects of a JSON-LD `Context`.
    ///
    /// A [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) MUST be a map whose keys MUST be either _terms_, _compact IRIs_, _IRIs_, or one of the keywords `@base`, `@import`, `@language`, `@propagate`, `@protected`, `@type`, `@version`, or `@vocab`.
    /// <see href="http://www.w3.org/ns/json-ld#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// A string ([simple term definition](http://www.w3.org/TR/json-ld11/#dfn-simple-term-definitions)), expanding to an IRI.
    /// <see href="http://www.w3.org/ns/json-ld#PrefixDefinition"></see></summary>
    let PrefixDefinition = _prefix "PrefixDefinition"
    /// <summary>
    /// A [term definition](http://www.w3.org/TR/json-ld11/#dfn-term-definitions) is an entry in a [context](#Context), where the key defines a term which may be used within a dictionary as a key, type, or elsewhere that a string is interpreted as a vocabulary item. Its value is an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    ///
    ///
    ///
    /// An [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definition) MUST be a map composed of zero or more keys from `@id`, `@reverse`, `@type`, `@language`, `@container`, `@context`, `@prefix`, `@propagate`, or `@protected`. An expanded term definition SHOULD NOT contain any other keys.
    /// <see href="http://www.w3.org/ns/json-ld#TermDefinition"></see></summary>
    let TermDefinition = _prefix "TermDefinition"
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) has an `@base` key, its value MUST be an _IRI reference_, or `null`.
    /// <see href="http://www.w3.org/ns/json-ld#base"></see></summary>
    let base_ = _prefix "base"
    /// <summary>
    /// This profile IRI is used to request or specify compacted JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#compacted"></see></summary>
    let compacted = _prefix "compacted"
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
    let container = _prefix "container"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/json-ld#ContainerType"></see>
    /// </summary>
    let ContainerType = _prefix "ContainerType"
    /// <summary>
    /// As an IRI, this link relation is used to associate a JSON-LD context with a JSON document so that it can be interpreted as JSON-LD. In an HTTP request header, specifies the location of a context to use for compaction. As a Context, defines an inline `context definition`.
    /// <see href="http://www.w3.org/ns/json-ld#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    /// Term definition(s) associated with this context.
    /// <see href="http://www.w3.org/ns/json-ld#definition"></see></summary>
    let definition = _prefix "definition"
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) has an `@direction` key, its value MUST be one of `"ltr"` or `"rtl"`, or be `null`.
    /// <see href="http://www.w3.org/ns/json-ld#direction"></see></summary>
    let direction = _prefix "direction"
    /// <summary>
    /// This profile URI is used to request or specify expanded JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#expanded"></see></summary>
    let expanded = _prefix "expanded"
    /// <summary>
    /// This profile URI is used to request or specify flattened JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#flattened"></see></summary>
    let flattened = _prefix "flattened"
    /// <summary>
    /// As an IRI, this link relation is used to associate a JSON-LD frame with a JSON-LD document. In an HTTP request header, specifies the location of a frame to use for framing.
    /// <see href="http://www.w3.org/ns/json-ld#frame"></see></summary>
    let frame = _prefix "frame"
    /// <summary>
    /// This profile URI is used to request or specify framed JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#framed"></see></summary>
    let framed = _prefix "framed"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#graphContainerType"></see></summary>
    let graphContainerType = _prefix "graphContainerType"
    /// <summary>
    /// The `@id` mapping of a [term definition](#TermDefinition).
    /// <see href="http://www.w3.org/ns/json-ld#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#idContainerType"></see></summary>
    let idContainerType = _prefix "idContainerType"
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@import` keyword, its value MUST be an _IRI reference_. When used as a reference from an `@import`, the referenced context definition MUST NOT include an `@import` key, itself.
    /// <see href="http://www.w3.org/ns/json-ld#import"></see></summary>
    let import = _prefix "import"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#indexContainerType"></see></summary>
    let indexContainerType = _prefix "indexContainerType"
    /// <summary>
    /// The [default language](https://www.w3.org/TR/json-ld11/#dfn-default-language) is set in the context using the `@language` key whose value MUST be a string representing a [BCP47](https://tools.ietf.org/html/bcp47) language code or null.
    /// <see href="http://www.w3.org/ns/json-ld#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#languageContainerType"></see></summary>
    let languageContainerType = _prefix "languageContainerType"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#listContainerType"></see></summary>
    let listContainerType = _prefix "listContainerType"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@nest` keyword, its value MUST be either `@nest`, or a _term_ which expands to `@nest`.
    /// <see href="http://www.w3.org/ns/json-ld#nest"></see></summary>
    let nest = _prefix "nest"
    /// <summary>
    /// With the value `true`, allows this term to be used to construct a compact IRI when compacting.
    /// <see href="http://www.w3.org/ns/json-ld#prefix"></see></summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@propagate` keyword, its value MUST be `true` or `false`.
    /// <see href="http://www.w3.org/ns/json-ld#propagate"></see></summary>
    let propagate = _prefix "propagate"
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@protected` keyword, its value MUST be `true` or `false`.
    /// <see href="http://www.w3.org/ns/json-ld#protected"></see></summary>
    let protected_ = _prefix "protected"
    /// <summary>
    /// The `@reverse` mapping of an [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions).
    /// <see href="http://www.w3.org/ns/json-ld#reverse"></see></summary>
    let reverse = _prefix "reverse"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#setContainerType"></see></summary>
    let setContainerType = _prefix "setContainerType"
    /// <summary>
    /// This profile URI is used to request or specify streaming JSON-LD document form.
    /// <see href="http://www.w3.org/ns/json-ld#streaming"></see></summary>
    let streaming = _prefix "streaming"
    /// <summary>
    /// The term associated with a [term definition](#TermDefinition).
    /// <see href="http://www.w3.org/ns/json-ld#term"></see></summary>
    let term = _prefix "term"
    /// <summary>
    /// If the [context definition](https://www.w3.org/TR/json-ld11/#dfn-context-definition) contains the `@type` keyword, its value MUST be a map with only the entry `@container` set to `@set`, and optionally an entry `@protected`.
    ///
    ///
    ///
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@type` keyword, its value MUST be an _IRI reference_, a _term_, `null`, or one of the keywords `@id`, `@json`, `@none`, or `@vocab`.
    /// <see href="http://www.w3.org/ns/json-ld#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// If the [expanded term definition](https://www.w3.org/TR/json-ld11/#dfn-expanded-term-definitions) contains the `@container` keyword, its value MUST be either `@list`, `@set`, `@language`, `@index`, `@id`, `@graph`, `@type`, or be `null` or an _array_ containing exactly any one of those keywords.
    /// <see href="http://www.w3.org/ns/json-ld#typeContainerType"></see></summary>
    let typeContainerType = _prefix "typeContainerType"
    /// <summary>
    /// The [processing mode](https://www.w3.org/TR/json-ld11/#dfn-processing-mode) defines how a JSON-LD document is processed. By default, all documents are assumed to be conformant with [JSON-LD 1.1`](http://www.w3.org/TR/json-ld11). By defining a different version via explicit API option, other processing modes can be accessed. This specification defines extensions for the `json-ld-1.1` processing mode.
    /// <see href="http://www.w3.org/ns/json-ld#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// Used to expand properties and values in `@type` with a common prefix IRI.
    /// <see href="http://www.w3.org/ns/json-ld#vocab"></see></summary>
    let vocab = _prefix "vocab"
