#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hydra =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/hydra/core#" "hydra"

    let ApiDocumentation = _prefixId.prefix "ApiDocumentation"
    let BaseUriSource = _prefixId.prefix "BaseUriSource"
    let BasicRepresentation = _prefixId.prefix "BasicRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : The class of Hydra classes.^^xsd:string</para>
    ///   <para>rdfs:label : Hydra Class^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#Class">hydra:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    let Collection = _prefixId.prefix "Collection"
    let Error = _prefixId.prefix "Error"
    let ExplicitRepresentation = _prefixId.prefix "ExplicitRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a possible either expected or returned header values^^xsd:string</para>
    ///   <para>rdfs:label : Header specification^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#HeaderSpecification">hydra:HeaderSpecification</a>
    /// </summary>
    let HeaderSpecification = _prefixId.prefix "HeaderSpecification"
    let IriTemplate = _prefixId.prefix "IriTemplate"
    let IriTemplateMapping = _prefixId.prefix "IriTemplateMapping"
    let Link = _prefixId.prefix "Link"
    let LinkContext = _prefixId.prefix "LinkContext"
    let Operation = _prefixId.prefix "Operation"
    let PartialCollectionView = _prefixId.prefix "PartialCollectionView"
    let Resource = _prefixId.prefix "Resource"
    let Rfc3986 = _prefixId.prefix "Rfc3986"
    let Rfc6570Template = _prefixId.prefix "Rfc6570Template"
    let Status = _prefixId.prefix "Status"
    let SupportedProperty = _prefixId.prefix "SupportedProperty"
    let TemplatedLink = _prefixId.prefix "TemplatedLink"
    let VariableRepresentation = _prefixId.prefix "VariableRepresentation"
    let apiDocumentation = _prefixId.prefix "apiDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : Determines whether the provided set of header values is closed or not.^^xsd:string</para>
    ///   <para>rdfs:label : closed set^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#closedSet">hydra:closedSet</a>
    /// </summary>
    let closedSet = _prefixId.prefix "closedSet"
    let collection = _prefixId.prefix "collection"
    /// <summary>
    ///   <para>rdfs:comment : A description.^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#description">hydra:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let entrypoint = _prefixId.prefix "entrypoint"
    let expects = _prefixId.prefix "expects"
    /// <summary>
    ///   <para>rdfs:comment : Specification of the header expected by the operation.^^xsd:string</para>
    ///   <para>rdfs:label : expects header^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#expectsHeader">hydra:expectsHeader</a>
    /// </summary>
    let expectsHeader = _prefixId.prefix "expectsHeader"
    /// <summary>
    ///   <para>rdfs:comment : Hint on what kind of extensions are in use.^^xsd:string</para>
    ///   <para>rdfs:label : extension^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#extension">hydra:extension</a>
    /// </summary>
    let extension = _prefixId.prefix "extension"
    let first = _prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:comment : A property representing a freetext query.^^xsd:string</para>
    ///   <para>rdfs:label : freetext query^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#freetextQuery">hydra:freetextQuery</a>
    /// </summary>
    let freetextQuery = _prefixId.prefix "freetextQuery"
    /// <summary>
    ///   <para>rdfs:comment : Name of the header.^^xsd:string</para>
    ///   <para>rdfs:label : header name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#headerName">hydra:headerName</a>
    /// </summary>
    let headerName = _prefixId.prefix "headerName"
    let last = _prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to limit set only to N elements.^^xsd:string</para>
    ///   <para>rdfs:label : take^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#limit">hydra:limit</a>
    /// </summary>
    let limit = _prefixId.prefix "limit"
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:comment : A variable-to-property mapping of the IRI template.^^xsd:string</para>
    ///   <para>rdfs:label : mapping^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#mapping">hydra:mapping</a>
    /// </summary>
    let mapping = _prefixId.prefix "mapping"
    let member_ = _prefixId.prefix "member"
    let memberAssertion = _prefixId.prefix "memberAssertion"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP method.^^xsd:string</para>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#method">hydra:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    let next = _prefixId.prefix "next"
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to skip N elements of the set.^^xsd:string</para>
    ///   <para>rdfs:label : skip^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#offset">hydra:offset</a>
    /// </summary>
    let offset = _prefixId.prefix "offset"
    let operation = _prefixId.prefix "operation"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to provide a specific page of the collection at a given index.^^xsd:string</para>
    ///   <para>rdfs:label : page index^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#pageIndex">hydra:pageIndex</a>
    /// </summary>
    let pageIndex = _prefixId.prefix "pageIndex"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to provide a specific page reference of the collection.^^xsd:string</para>
    ///   <para>rdfs:label : page reference^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#pageReference">hydra:pageReference</a>
    /// </summary>
    let pageReference = _prefixId.prefix "pageReference"
    let possibleStatus = _prefixId.prefix "possibleStatus"
    /// <summary>
    ///   <para>rdfs:comment : Possible value of the header.^^xsd:string</para>
    ///   <para>rdfs:label : possible header value^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#possibleValue">hydra:possibleValue</a>
    /// </summary>
    let possibleValue = _prefixId.prefix "possibleValue"
    let previous = _prefixId.prefix "previous"
    /// <summary>
    ///   <para>rdfs:comment : A property^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#property">hydra:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : True if the client can retrieve the property's value, false otherwise.^^xsd:string</para>
    ///   <para>rdfs:label : readable^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#readable">hydra:readable</a>
    /// </summary>
    let readable = _prefixId.prefix "readable"
    /// <summary>
    ///   <para>rdfs:comment : True if the property is required, false otherwise.^^xsd:string</para>
    ///   <para>rdfs:label : required^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#required">hydra:required</a>
    /// </summary>
    let required = _prefixId.prefix "required"
    /// <summary>
    ///   <para>rdfs:label : relative Uri resolution^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#resolveRelativeUsing">hydra:resolveRelativeUsing</a>
    /// </summary>
    let resolveRelativeUsing = _prefixId.prefix "resolveRelativeUsing"
    let returns = _prefixId.prefix "returns"
    /// <summary>
    ///   <para>rdfs:comment : Name of the header returned by the operation.^^xsd:string</para>
    ///   <para>rdfs:label : returns header^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#returnsHeader">hydra:returnsHeader</a>
    /// </summary>
    let returnsHeader = _prefixId.prefix "returnsHeader"
    let search = _prefixId.prefix "search"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP status code. Please note it may happen this value will be different to actual status code received.^^xsd:string</para>
    ///   <para>rdfs:label : status code^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#statusCode">hydra:statusCode</a>
    /// </summary>
    let statusCode = _prefixId.prefix "statusCode"
    let subject = _prefixId.prefix "subject"
    let supportedClass = _prefixId.prefix "supportedClass"
    let supportedOperation = _prefixId.prefix "supportedOperation"
    let supportedProperty = _prefixId.prefix "supportedProperty"
    /// <summary>
    ///   <para>rdfs:comment : A templated string with placeholders. The literal's datatype indicates the template syntax; if not specified, hydra:Rfc6570Template is assumed.^^xsd:string</para>
    ///   <para>rdfs:label : template^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#template">hydra:template</a>
    /// </summary>
    let template = _prefixId.prefix "template"
    /// <summary>
    ///   <para>rdfs:comment : A title, often used along with a description.^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#title">hydra:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : The total number of items referenced by a collection.^^xsd:string</para>
    ///   <para>rdfs:label : total items^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#totalItems">hydra:totalItems</a>
    /// </summary>
    let totalItems = _prefixId.prefix "totalItems"
    /// <summary>
    ///   <para>rdfs:comment : An IRI template variable^^xsd:string</para>
    ///   <para>rdfs:label : variable^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#variable">hydra:variable</a>
    /// </summary>
    let variable = _prefixId.prefix "variable"
    /// <summary>
    ///   <para>rdfs:comment : The representation format to use when expanding the IRI template.^^xsd:string</para>
    ///   <para>rdfs:label : variable representation^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#variableRepresentation">hydra:variableRepresentation</a>
    /// </summary>
    let variableRepresentation = _prefixId.prefix "variableRepresentation"
    let view = _prefixId.prefix "view"
    /// <summary>
    ///   <para>rdfs:comment : True if the client can change the property's value, false otherwise.^^xsd:string</para>
    ///   <para>rdfs:label : writable^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#writable">hydra:writable</a>
    /// </summary>
    let writable = _prefixId.prefix "writable"
    let writeable = _prefixId.prefix "writeable"
