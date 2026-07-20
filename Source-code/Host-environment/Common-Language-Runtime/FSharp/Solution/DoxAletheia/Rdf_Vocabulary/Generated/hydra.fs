namespace http.www.w3.org.ns.hydra.core.hash

open DoxAletheia

module hydra =
    let _namespace_name = "http://www.w3.org/ns/hydra/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The Hydra API documentation class
    /// <see href="http://www.w3.org/ns/hydra/core#ApiDocumentation"></see></summary>
    let ApiDocumentation = _prefix "ApiDocumentation"
    /// <summary>
    /// The class of Hydra classes. Hydra classes and their instances are dereferenceable resources.
    /// <see href="http://www.w3.org/ns/hydra/core#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// The class of dereferenceable resources.
    /// <see href="http://www.w3.org/ns/hydra/core#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// A representation that serializes just the lexical form, but omits language and type information.
    /// <see href="http://www.w3.org/ns/hydra/core#BasicRepresentation"></see></summary>
    let BasicRepresentation = _prefix "BasicRepresentation"
    /// <summary>
    /// A collection holding references to a number of related resources.
    /// <see href="http://www.w3.org/ns/hydra/core#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A CreateResourceOperation is a HTTP operation which expects an input of the type specified by hydra:expects and creates a resource of the type specified by hydra:returns.
    /// <see href="http://www.w3.org/ns/hydra/core#CreateResourceOperation"></see></summary>
    let CreateResourceOperation = _prefix "CreateResourceOperation"
    /// <summary>
    /// An operation.
    /// <see href="http://www.w3.org/ns/hydra/core#Operation"></see></summary>
    let Operation = _prefix "Operation"
    /// <summary>
    /// A DeleteResourceOperation is a HTTP operation that deletes a resource.
    /// <see href="http://www.w3.org/ns/hydra/core#DeleteResourceOperation"></see></summary>
    let DeleteResourceOperation = _prefix "DeleteResourceOperation"
    /// <summary>
    /// A runtime error, used to report information beyond the returned status code.
    /// <see href="http://www.w3.org/ns/hydra/core#Error"></see></summary>
    let Error = _prefix "Error"
    /// <summary>
    /// Additional information about a status code that might be returned.
    /// <see href="http://www.w3.org/ns/hydra/core#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// A representation that serializes a value including its language and type information and thus differentiating between IRIs and literals.
    /// <see href="http://www.w3.org/ns/hydra/core#ExplicitRepresentation"></see></summary>
    let ExplicitRepresentation = _prefix "ExplicitRepresentation"
    /// <summary>
    /// The class of IRI templates.
    /// <see href="http://www.w3.org/ns/hydra/core#IriTemplate"></see></summary>
    let IriTemplate = _prefix "IriTemplate"
    /// <summary>
    /// A mapping from an IRI template variable to a property.
    /// <see href="http://www.w3.org/ns/hydra/core#IriTemplateMapping"></see></summary>
    let IriTemplateMapping = _prefix "IriTemplateMapping"
    /// <summary>
    /// The class of properties representing links.
    /// <see href="http://www.w3.org/ns/hydra/core#Link"></see></summary>
    let Link = _prefix "Link"
    /// <summary>
    /// A PagedCollection is a subclass of Collection with the only difference that its members are sorted and only a subset of all members are returned in a single PagedCollection. To get the other members, the nextPage/previousPage properties have to be used.
    /// <see href="http://www.w3.org/ns/hydra/core#PagedCollection"></see></summary>
    let PagedCollection = _prefix "PagedCollection"
    /// <summary>
    /// A ReplaceResourceOperation is a HTTP operation which overwrites a resource. It expects data of the type specified in hydra:expects and results in a resource of the type specified by hydra:returns.
    /// <see href="http://www.w3.org/ns/hydra/core#ReplaceResourceOperation"></see></summary>
    let ReplaceResourceOperation = _prefix "ReplaceResourceOperation"
    /// <summary>
    /// A property known to be supported by a Hydra class.
    /// <see href="http://www.w3.org/ns/hydra/core#SupportedProperty"></see></summary>
    let SupportedProperty = _prefix "SupportedProperty"
    /// <summary>
    /// A templated link.
    /// <see href="http://www.w3.org/ns/hydra/core#TemplatedLink"></see></summary>
    let TemplatedLink = _prefix "TemplatedLink"
    /// <summary>
    /// A link to the API documentation
    /// <see href="http://www.w3.org/ns/hydra/core#apiDocumentation"></see></summary>
    let apiDocumentation = _prefix "apiDocumentation"
    /// <summary>
    /// A description.
    /// <see href="http://www.w3.org/ns/hydra/core#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A link to main entry point of the Web API
    /// <see href="http://www.w3.org/ns/hydra/core#entrypoint"></see></summary>
    let entrypoint = _prefix "entrypoint"
    /// <summary>
    /// The information expected by the Web API.
    /// <see href="http://www.w3.org/ns/hydra/core#expects"></see></summary>
    let expects = _prefix "expects"
    /// <summary>
    /// The first page of an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#firstPage"></see></summary>
    let firstPage = _prefix "firstPage"
    /// <summary>
    /// A property representing a freetext query.
    /// <see href="http://www.w3.org/ns/hydra/core#freetextQuery"></see></summary>
    let freetextQuery = _prefix "freetextQuery"
    /// <summary>
    /// The maximum number of items referenced by each single PagedCollection in a set of interlinked PagedCollections.
    /// <see href="http://www.w3.org/ns/hydra/core#itemsPerPage"></see></summary>
    let itemsPerPage = _prefix "itemsPerPage"
    /// <summary>
    /// The last page of an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#lastPage"></see></summary>
    let lastPage = _prefix "lastPage"
    /// <summary>
    /// A variable-to-property mapping of the IRI template.
    /// <see href="http://www.w3.org/ns/hydra/core#mapping"></see></summary>
    let mapping = _prefix "mapping"
    /// <summary>
    /// A member of the collection
    /// <see href="http://www.w3.org/ns/hydra/core#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// The HTTP method.
    /// <see href="http://www.w3.org/ns/hydra/core#method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    /// The page following the current instance in an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#nextPage"></see></summary>
    let nextPage = _prefix "nextPage"
    /// <summary>
    /// An operation supported by the Hydra resource
    /// <see href="http://www.w3.org/ns/hydra/core#operation"></see></summary>
    let operation = _prefix "operation"
    /// <summary>
    /// A status that might be returned by the Web API (other statuses should be expected and properly handled as well)
    /// <see href="http://www.w3.org/ns/hydra/core#possibleStatus"></see></summary>
    let possibleStatus = _prefix "possibleStatus"
    /// <summary>
    /// The page preceding the current instance in an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#previousPage"></see></summary>
    let previousPage = _prefix "previousPage"
    /// <summary>
    /// A property
    /// <see href="http://www.w3.org/ns/hydra/core#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// True if the client can retrieve the property's value, false otherwise.
    /// <see href="http://www.w3.org/ns/hydra/core#readable"></see></summary>
    let readable = _prefix "readable"
    /// <summary>
    /// True if the property is required, false otherwise.
    /// <see href="http://www.w3.org/ns/hydra/core#required"></see></summary>
    let required = _prefix "required"
    /// <summary>
    /// The information returned by the Web API on success
    /// <see href="http://www.w3.org/ns/hydra/core#returns"></see></summary>
    let returns = _prefix "returns"
    /// <summary>
    /// A IRI template that can be used to query a collection
    /// <see href="http://www.w3.org/ns/hydra/core#search"></see></summary>
    let search = _prefix "search"
    /// <summary>
    /// The HTTP status code
    /// <see href="http://www.w3.org/ns/hydra/core#statusCode"></see></summary>
    let statusCode = _prefix "statusCode"
    /// <summary>
    /// A class known to be supported by the Web API
    /// <see href="http://www.w3.org/ns/hydra/core#supportedClass"></see></summary>
    let supportedClass = _prefix "supportedClass"
    /// <summary>
    /// An operation supported by instances of the specific Hydra class or the target of the Hydra link
    /// <see href="http://www.w3.org/ns/hydra/core#supportedOperation"></see></summary>
    let supportedOperation = _prefix "supportedOperation"
    /// <summary>
    /// The properties known to be supported by a Hydra class
    /// <see href="http://www.w3.org/ns/hydra/core#supportedProperty"></see></summary>
    let supportedProperty = _prefix "supportedProperty"
    /// <summary>
    /// An IRI template as defined by RFC6570.
    /// <see href="http://www.w3.org/ns/hydra/core#template"></see></summary>
    let template = _prefix "template"
    /// <summary>
    /// A title, often used along with a description.
    /// <see href="http://www.w3.org/ns/hydra/core#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// The total number of items referenced by a collection or a set of interlinked PagedCollections.
    /// <see href="http://www.w3.org/ns/hydra/core#totalItems"></see></summary>
    let totalItems = _prefix "totalItems"
    /// <summary>
    /// An IRI template variable
    /// <see href="http://www.w3.org/ns/hydra/core#variable"></see></summary>
    let variable = _prefix "variable"
    /// <summary>
    /// The representation format to use when expanding the IRI template.
    /// <see href="http://www.w3.org/ns/hydra/core#variableRepresentation"></see></summary>
    let variableRepresentation = _prefix "variableRepresentation"
    /// <summary>
    /// True if the client can change the property's value, false otherwise.
    /// <see href="http://www.w3.org/ns/hydra/core#writeable"></see></summary>
    let writeable = _prefix "writeable"
