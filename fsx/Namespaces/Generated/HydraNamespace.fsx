#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hydra =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/hydra/core#" "hydra"

    let ApiDocumentation = _prefixId.prefix "ApiDocumentation"
    let BasicRepresentation = _prefixId.prefix "BasicRepresentation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Hydra Class^^xsd:string</para>
    ///   <para>rdfs:comment : The class of Hydra classes. Hydra classes and their instances are dereferenceable resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#Class">hydra:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    let Collection = _prefixId.prefix "Collection"
    let CreateResourceOperation = _prefixId.prefix "CreateResourceOperation"
    let DeleteResourceOperation = _prefixId.prefix "DeleteResourceOperation"
    let Error = _prefixId.prefix "Error"
    let ExplicitRepresentation = _prefixId.prefix "ExplicitRepresentation"
    let IriTemplate = _prefixId.prefix "IriTemplate"
    let IriTemplateMapping = _prefixId.prefix "IriTemplateMapping"
    let Link = _prefixId.prefix "Link"
    let Operation = _prefixId.prefix "Operation"
    let PagedCollection = _prefixId.prefix "PagedCollection"
    let ReplaceResourceOperation = _prefixId.prefix "ReplaceResourceOperation"
    let Resource = _prefixId.prefix "Resource"
    let Status = _prefixId.prefix "Status"
    let SupportedProperty = _prefixId.prefix "SupportedProperty"
    let TemplatedLink = _prefixId.prefix "TemplatedLink"
    let apiDocumentation = _prefixId.prefix "apiDocumentation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>rdfs:comment : A description.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#description">hydra:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let entrypoint = _prefixId.prefix "entrypoint"
    let expects = _prefixId.prefix "expects"
    let firstPage = _prefixId.prefix "firstPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : freetext query^^xsd:string</para>
    ///   <para>rdfs:comment : A property representing a freetext query.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#freetextQuery">hydra:freetextQuery</a>
    /// </summary>
    let freetextQuery = _prefixId.prefix "freetextQuery"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : items per page^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum number of items referenced by each single PagedCollection in a set of interlinked PagedCollections.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#itemsPerPage">hydra:itemsPerPage</a>
    /// </summary>
    let itemsPerPage = _prefixId.prefix "itemsPerPage"
    let lastPage = _prefixId.prefix "lastPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : mapping^^xsd:string</para>
    ///   <para>rdfs:comment : A variable-to-property mapping of the IRI template.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#mapping">hydra:mapping</a>
    /// </summary>
    let mapping = _prefixId.prefix "mapping"
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>rdfs:comment : The HTTP method.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#method">hydra:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    let nextPage = _prefixId.prefix "nextPage"
    let operation = _prefixId.prefix "operation"
    let possibleStatus = _prefixId.prefix "possibleStatus"
    let previousPage = _prefixId.prefix "previousPage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <para>rdfs:comment : A property^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#property">hydra:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : readable^^xsd:string</para>
    ///   <para>rdfs:comment : True if the client can retrieve the property's value, false otherwise.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#readable">hydra:readable</a>
    /// </summary>
    let readable = _prefixId.prefix "readable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : required^^xsd:string</para>
    ///   <para>rdfs:comment : True if the property is required, false otherwise.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#required">hydra:required</a>
    /// </summary>
    let required = _prefixId.prefix "required"
    let returns = _prefixId.prefix "returns"
    let search = _prefixId.prefix "search"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : status code^^xsd:string</para>
    ///   <para>rdfs:comment : The HTTP status code^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#statusCode">hydra:statusCode</a>
    /// </summary>
    let statusCode = _prefixId.prefix "statusCode"
    let supportedClass = _prefixId.prefix "supportedClass"
    let supportedOperation = _prefixId.prefix "supportedOperation"
    let supportedProperty = _prefixId.prefix "supportedProperty"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : template^^xsd:string</para>
    ///   <para>rdfs:comment : An IRI template as defined by RFC6570.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#template">hydra:template</a>
    /// </summary>
    let template = _prefixId.prefix "template"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : A title, often used along with a description.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#title">hydra:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : total items^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of items referenced by a collection or a set of interlinked PagedCollections.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#totalItems">hydra:totalItems</a>
    /// </summary>
    let totalItems = _prefixId.prefix "totalItems"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : variable^^xsd:string</para>
    ///   <para>rdfs:comment : An IRI template variable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#variable">hydra:variable</a>
    /// </summary>
    let variable = _prefixId.prefix "variable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : variable representation^^xsd:string</para>
    ///   <para>rdfs:comment : The representation format to use when expanding the IRI template.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#variableRepresentation">hydra:variableRepresentation</a>
    /// </summary>
    let variableRepresentation = _prefixId.prefix "variableRepresentation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : writeable^^xsd:string</para>
    ///   <para>rdfs:comment : True if the client can change the property's value, false otherwise.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#writeable">hydra:writeable</a>
    /// </summary>
    let writeable = _prefixId.prefix "writeable"
