#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ends =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://labs.mondeca.com/vocab/endpointStatus#" "ends"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A Status of a void:Dataset endpoint at a particular time</para>
    ///   <para>rdfs:label : Endpoint status</para>
    ///   <a href="http://labs.mondeca.com/vocab/endpointStatus#EndpointStatus">ends:EndpointStatus</a>
    /// </summary>
    let EndpointStatus = _prefixId.prefix "EndpointStatus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a void:Dataset and an ends:EndpointStatus</para>
    ///   <para>rdfs:label : has status</para>
    ///   <a href="http://labs.mondeca.com/vocab/endpointStatus#status">ends:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Describes whether a void:Dataset endpoint is available or not</para>
    ///   <para>rdfs:label : is endpoint available</para>
    ///   <a href="http://labs.mondeca.com/vocab/endpointStatus#statusIsAvailable">ends:statusIsAvailable</a>
    /// </summary>
    let statusIsAvailable = _prefixId.prefix "statusIsAvailable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : If a void:Dataset endpoint is available, this property indicates in milliseconds the responseTime to a simple Select query</para>
    ///   <para>rdfs:label : endpoint response time</para>
    ///   <a href="http://labs.mondeca.com/vocab/endpointStatus#statusResponseTime">ends:statusResponseTime</a>
    /// </summary>
    let statusResponseTime = _prefixId.prefix "statusResponseTime"
