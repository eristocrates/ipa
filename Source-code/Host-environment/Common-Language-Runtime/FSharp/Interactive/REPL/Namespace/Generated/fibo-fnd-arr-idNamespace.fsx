#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-id`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/" "fibo-fnd-arr-id"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : index^^xsd:string</para>
    ///   <para>skos:definition : indirect shortcut derived from and pointing into, a greater volume of values, data, information or knowledge^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : http://en.wikipedia.org/wiki/Index^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/Index">fibo-fnd-arr-id:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:label : indexing scheme^^xsd:string</para>
    ///   <para>skos:definition : system for indexing values, data, information, or knowledge^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/IndexingScheme">fibo-fnd-arr-id:IndexingScheme</a>
    /// </summary>
    let IndexingScheme = _prefixId.prefix "IndexingScheme"
    /// <summary>
    ///   <para>rdfs:label : reassignable identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that uniquely identifies something for a given time period, and that may be reused to identify something else at a different point in time^^xsd:string</para>
    ///   <para>skos:example : ticker symbol, vehicle license number, such as a vanity plate that can be reassigned and moved from one car to another^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If no assignment termination date is provided, the identifier is considered to be assigned and valid. If there is no initial assignment date, then the identifier is assumed to be assigned up until the termination date, if any.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/ReassignableIdentifier">fibo-fnd-arr-id:ReassignableIdentifier</a>
    /// </summary>
    let ReassignableIdentifier = _prefixId.prefix "ReassignableIdentifier"
    /// <summary>
    ///   <para>rdfs:label : construct regex^^xsd:string</para>
    ///   <para>skos:definition : indicates how to compose the supplied character string from its components^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/constructRegex">fibo-fnd-arr-id:constructRegex</a>
    /// </summary>
    let constructRegex = _prefixId.prefix "constructRegex"
    /// <summary>
    ///   <para>rdfs:label : has assignment termination date^^xsd:string</para>
    ///   <para>skos:definition : the date on which an identifier is released from its assignment to some resource^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasAssignmentTerminationDate">fibo-fnd-arr-id:hasAssignmentTerminationDate</a>
    /// </summary>
    let hasAssignmentTerminationDate = _prefixId.prefix "hasAssignmentTerminationDate"
    /// <summary>
    ///   <para>rdfs:label : has initial assignment date^^xsd:string</para>
    ///   <para>skos:definition : the date on which an identifier is first assigned to some resource^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasInitialAssignmentDate">fibo-fnd-arr-id:hasInitialAssignmentDate</a>
    /// </summary>
    let hasInitialAssignmentDate = _prefixId.prefix "hasInitialAssignmentDate"
    /// <summary>
    ///   <para>rdfs:label : is index to^^xsd:string</para>
    ///   <para>skos:definition : that to which the index refers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/isIndexTo">fibo-fnd-arr-id:isIndexTo</a>
    /// </summary>
    let isIndexTo = _prefixId.prefix "isIndexTo"
    /// <summary>
    ///   <para>rdfs:label : parse regex^^xsd:string</para>
    ///   <para>skos:definition : indicates how to deconstruct the supplied character string into its components^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/parseRegex">fibo-fnd-arr-id:parseRegex</a>
    /// </summary>
    let parseRegex = _prefixId.prefix "parseRegex"
