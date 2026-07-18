namespace http.www.w3.org.ns.hydra.core.hash

open DoxAletheia.Rdf_Vocabulary

module hydra =
    let _namespace_name = "http://www.w3.org/ns/hydra/core#"

    /// <summary>
    /// The Hydra API documentation class
    /// <see href="http://www.w3.org/ns/hydra/core#ApiDocumentation"></see></summary>
    let ApiDocumentation =
        Namespaced_IRI.parse _namespace_name "ApiDocumentation" |> NamespacedName

    /// <summary>
    /// The class of Hydra classes. Hydra classes and their instances are dereferenceable resources.
    /// <see href="http://www.w3.org/ns/hydra/core#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    /// The class of dereferenceable resources.
    /// <see href="http://www.w3.org/ns/hydra/core#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    /// A representation that serializes just the lexical form, but omits language and type information.
    /// <see href="http://www.w3.org/ns/hydra/core#BasicRepresentation"></see></summary>
    let BasicRepresentation =
        Namespaced_IRI.parse _namespace_name "BasicRepresentation" |> NamespacedName

    /// <summary>
    /// A collection holding references to a number of related resources.
    /// <see href="http://www.w3.org/ns/hydra/core#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// A CreateResourceOperation is a HTTP operation which expects an input of the type specified by hydra:expects and creates a resource of the type specified by hydra:returns.
    /// <see href="http://www.w3.org/ns/hydra/core#CreateResourceOperation"></see></summary>
    let CreateResourceOperation =
        Namespaced_IRI.parse _namespace_name "CreateResourceOperation" |> NamespacedName

    /// <summary>
    /// An operation.
    /// <see href="http://www.w3.org/ns/hydra/core#Operation"></see></summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName

    /// <summary>
    /// A DeleteResourceOperation is a HTTP operation that deletes a resource.
    /// <see href="http://www.w3.org/ns/hydra/core#DeleteResourceOperation"></see></summary>
    let DeleteResourceOperation =
        Namespaced_IRI.parse _namespace_name "DeleteResourceOperation" |> NamespacedName

    /// <summary>
    /// A runtime error, used to report information beyond the returned status code.
    /// <see href="http://www.w3.org/ns/hydra/core#Error"></see></summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName
    /// <summary>
    /// Additional information about a status code that might be returned.
    /// <see href="http://www.w3.org/ns/hydra/core#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A representation that serializes a value including its language and type information and thus differentiating between IRIs and literals.
    /// <see href="http://www.w3.org/ns/hydra/core#ExplicitRepresentation"></see></summary>
    let ExplicitRepresentation =
        Namespaced_IRI.parse _namespace_name "ExplicitRepresentation" |> NamespacedName

    /// <summary>
    /// The class of IRI templates.
    /// <see href="http://www.w3.org/ns/hydra/core#IriTemplate"></see></summary>
    let IriTemplate =
        Namespaced_IRI.parse _namespace_name "IriTemplate" |> NamespacedName

    /// <summary>
    /// A mapping from an IRI template variable to a property.
    /// <see href="http://www.w3.org/ns/hydra/core#IriTemplateMapping"></see></summary>
    let IriTemplateMapping =
        Namespaced_IRI.parse _namespace_name "IriTemplateMapping" |> NamespacedName

    /// <summary>
    /// The class of properties representing links.
    /// <see href="http://www.w3.org/ns/hydra/core#Link"></see></summary>
    let Link = Namespaced_IRI.parse _namespace_name "Link" |> NamespacedName

    /// <summary>
    /// A PagedCollection is a subclass of Collection with the only difference that its members are sorted and only a subset of all members are returned in a single PagedCollection. To get the other members, the nextPage/previousPage properties have to be used.
    /// <see href="http://www.w3.org/ns/hydra/core#PagedCollection"></see></summary>
    let PagedCollection =
        Namespaced_IRI.parse _namespace_name "PagedCollection" |> NamespacedName

    /// <summary>
    /// A ReplaceResourceOperation is a HTTP operation which overwrites a resource. It expects data of the type specified in hydra:expects and results in a resource of the type specified by hydra:returns.
    /// <see href="http://www.w3.org/ns/hydra/core#ReplaceResourceOperation"></see></summary>
    let ReplaceResourceOperation =
        Namespaced_IRI.parse _namespace_name "ReplaceResourceOperation" |> NamespacedName

    /// <summary>
    /// A property known to be supported by a Hydra class.
    /// <see href="http://www.w3.org/ns/hydra/core#SupportedProperty"></see></summary>
    let SupportedProperty =
        Namespaced_IRI.parse _namespace_name "SupportedProperty" |> NamespacedName

    /// <summary>
    /// A templated link.
    /// <see href="http://www.w3.org/ns/hydra/core#TemplatedLink"></see></summary>
    let TemplatedLink =
        Namespaced_IRI.parse _namespace_name "TemplatedLink" |> NamespacedName

    /// <summary>
    /// A link to the API documentation
    /// <see href="http://www.w3.org/ns/hydra/core#apiDocumentation"></see></summary>
    let apiDocumentation =
        Namespaced_IRI.parse _namespace_name "apiDocumentation" |> NamespacedName

    /// <summary>
    /// A description.
    /// <see href="http://www.w3.org/ns/hydra/core#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// A link to main entry point of the Web API
    /// <see href="http://www.w3.org/ns/hydra/core#entrypoint"></see></summary>
    let entrypoint = Namespaced_IRI.parse _namespace_name "entrypoint" |> NamespacedName
    /// <summary>
    /// The information expected by the Web API.
    /// <see href="http://www.w3.org/ns/hydra/core#expects"></see></summary>
    let expects = Namespaced_IRI.parse _namespace_name "expects" |> NamespacedName
    /// <summary>
    /// The first page of an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#firstPage"></see></summary>
    let firstPage = Namespaced_IRI.parse _namespace_name "firstPage" |> NamespacedName

    /// <summary>
    /// A property representing a freetext query.
    /// <see href="http://www.w3.org/ns/hydra/core#freetextQuery"></see></summary>
    let freetextQuery =
        Namespaced_IRI.parse _namespace_name "freetextQuery" |> NamespacedName

    /// <summary>
    /// The maximum number of items referenced by each single PagedCollection in a set of interlinked PagedCollections.
    /// <see href="http://www.w3.org/ns/hydra/core#itemsPerPage"></see></summary>
    let itemsPerPage =
        Namespaced_IRI.parse _namespace_name "itemsPerPage" |> NamespacedName

    /// <summary>
    /// The last page of an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#lastPage"></see></summary>
    let lastPage = Namespaced_IRI.parse _namespace_name "lastPage" |> NamespacedName
    /// <summary>
    /// A variable-to-property mapping of the IRI template.
    /// <see href="http://www.w3.org/ns/hydra/core#mapping"></see></summary>
    let mapping = Namespaced_IRI.parse _namespace_name "mapping" |> NamespacedName
    /// <summary>
    /// A member of the collection
    /// <see href="http://www.w3.org/ns/hydra/core#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    /// The HTTP method.
    /// <see href="http://www.w3.org/ns/hydra/core#method"></see></summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName
    /// <summary>
    /// The page following the current instance in an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#nextPage"></see></summary>
    let nextPage = Namespaced_IRI.parse _namespace_name "nextPage" |> NamespacedName
    /// <summary>
    /// An operation supported by the Hydra resource
    /// <see href="http://www.w3.org/ns/hydra/core#operation"></see></summary>
    let operation = Namespaced_IRI.parse _namespace_name "operation" |> NamespacedName

    /// <summary>
    /// A status that might be returned by the Web API (other statuses should be expected and properly handled as well)
    /// <see href="http://www.w3.org/ns/hydra/core#possibleStatus"></see></summary>
    let possibleStatus =
        Namespaced_IRI.parse _namespace_name "possibleStatus" |> NamespacedName

    /// <summary>
    /// The page preceding the current instance in an interlinked set of PagedCollections
    /// <see href="http://www.w3.org/ns/hydra/core#previousPage"></see></summary>
    let previousPage =
        Namespaced_IRI.parse _namespace_name "previousPage" |> NamespacedName

    /// <summary>
    /// A property
    /// <see href="http://www.w3.org/ns/hydra/core#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName
    /// <summary>
    /// True if the client can retrieve the property's value, false otherwise.
    /// <see href="http://www.w3.org/ns/hydra/core#readable"></see></summary>
    let readable = Namespaced_IRI.parse _namespace_name "readable" |> NamespacedName
    /// <summary>
    /// True if the property is required, false otherwise.
    /// <see href="http://www.w3.org/ns/hydra/core#required"></see></summary>
    let required = Namespaced_IRI.parse _namespace_name "required" |> NamespacedName
    /// <summary>
    /// The information returned by the Web API on success
    /// <see href="http://www.w3.org/ns/hydra/core#returns"></see></summary>
    let returns = Namespaced_IRI.parse _namespace_name "returns" |> NamespacedName
    /// <summary>
    /// A IRI template that can be used to query a collection
    /// <see href="http://www.w3.org/ns/hydra/core#search"></see></summary>
    let search = Namespaced_IRI.parse _namespace_name "search" |> NamespacedName
    /// <summary>
    /// The HTTP status code
    /// <see href="http://www.w3.org/ns/hydra/core#statusCode"></see></summary>
    let statusCode = Namespaced_IRI.parse _namespace_name "statusCode" |> NamespacedName

    /// <summary>
    /// A class known to be supported by the Web API
    /// <see href="http://www.w3.org/ns/hydra/core#supportedClass"></see></summary>
    let supportedClass =
        Namespaced_IRI.parse _namespace_name "supportedClass" |> NamespacedName

    /// <summary>
    /// An operation supported by instances of the specific Hydra class or the target of the Hydra link
    /// <see href="http://www.w3.org/ns/hydra/core#supportedOperation"></see></summary>
    let supportedOperation =
        Namespaced_IRI.parse _namespace_name "supportedOperation" |> NamespacedName

    /// <summary>
    /// The properties known to be supported by a Hydra class
    /// <see href="http://www.w3.org/ns/hydra/core#supportedProperty"></see></summary>
    let supportedProperty =
        Namespaced_IRI.parse _namespace_name "supportedProperty" |> NamespacedName

    /// <summary>
    /// An IRI template as defined by RFC6570.
    /// <see href="http://www.w3.org/ns/hydra/core#template"></see></summary>
    let template = Namespaced_IRI.parse _namespace_name "template" |> NamespacedName
    /// <summary>
    /// A title, often used along with a description.
    /// <see href="http://www.w3.org/ns/hydra/core#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// The total number of items referenced by a collection or a set of interlinked PagedCollections.
    /// <see href="http://www.w3.org/ns/hydra/core#totalItems"></see></summary>
    let totalItems = Namespaced_IRI.parse _namespace_name "totalItems" |> NamespacedName
    /// <summary>
    /// An IRI template variable
    /// <see href="http://www.w3.org/ns/hydra/core#variable"></see></summary>
    let variable = Namespaced_IRI.parse _namespace_name "variable" |> NamespacedName

    /// <summary>
    /// The representation format to use when expanding the IRI template.
    /// <see href="http://www.w3.org/ns/hydra/core#variableRepresentation"></see></summary>
    let variableRepresentation =
        Namespaced_IRI.parse _namespace_name "variableRepresentation" |> NamespacedName

    /// <summary>
    /// True if the client can change the property's value, false otherwise.
    /// <see href="http://www.w3.org/ns/hydra/core#writeable"></see></summary>
    let writeable = Namespaced_IRI.parse _namespace_name "writeable" |> NamespacedName
