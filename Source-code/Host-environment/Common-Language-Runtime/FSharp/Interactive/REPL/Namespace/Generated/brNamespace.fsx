#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module br =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/br#" "br"
    /// <summary>
    ///   <para>rdfs:label : BrTopic^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#BrTopic">br:BrTopic</a>
    /// </summary>
    let BrTopic = _prefixId.prefix "BrTopic"
    /// <summary>
    ///   <para>rdfs:label : Brainstorm^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#Brainstorm">br:Brainstorm</a>
    /// </summary>
    let Brainstorm = _prefixId.prefix "Brainstorm"
    let ``DERI%2C%20NUI%20Galway`` = _prefixId.prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <para>rdfs:label : Idea^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#Idea">br:Idea</a>
    /// </summary>
    let Idea = _prefixId.prefix "Idea"
    /// <summary>
    ///   <para>rdfs:label : Label^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#Label">br:Label</a>
    /// </summary>
    let Label = _prefixId.prefix "Label"
    /// <summary>
    ///   <para>rdfs:label : Objective Description^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#ObjDescription">br:ObjDescription</a>
    /// </summary>
    let ObjDescription = _prefixId.prefix "ObjDescription"
    /// <summary>
    ///   <para>rdfs:label : Objective Title^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#ObjTitle">br:ObjTitle</a>
    /// </summary>
    let ObjTitle = _prefixId.prefix "ObjTitle"
    /// <summary>
    ///   <para>rdfs:label : Objective^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#Objective">br:Objective</a>
    /// </summary>
    let Objective = _prefixId.prefix "Objective"
    /// <summary>
    ///   <para>rdfs:label : Participant^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#Participant">br:Participant</a>
    /// </summary>
    let Participant = _prefixId.prefix "Participant"
    /// <summary>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#Site">br:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : dc:creator^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#creator">br:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : dc:description^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#description">br:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : br:hasEvent^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasEvent">br:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    /// <summary>
    ///   <para>rdfs:label : br:hasExpectation^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasExpectation">br:hasExpectation</a>
    /// </summary>
    let hasExpectation = _prefixId.prefix "hasExpectation"
    /// <summary>
    ///   <para>rdfs:label : br:hasIdea^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasIdea">br:hasIdea</a>
    /// </summary>
    let hasIdea = _prefixId.prefix "hasIdea"
    /// <summary>
    ///   <para>rdfs:label : br:hasParticipant^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasParticipant">br:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:label : rev:hasReview^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasReview">br:hasReview</a>
    /// </summary>
    let hasReview = _prefixId.prefix "hasReview"
    /// <summary>
    ///   <para>rdfs:label : sioc:has_space^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasSpace">br:hasSpace</a>
    /// </summary>
    let hasSpace = _prefixId.prefix "hasSpace"
    /// <summary>
    ///   <para>rdfs:label : br:hasTopic^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#hasTopic">br:hasTopic</a>
    /// </summary>
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>rdfs:label : foaf:holdsAccount^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#holdsAccount">br:holdsAccount</a>
    /// </summary>
    let holdsAccount = _prefixId.prefix "holdsAccount"
    let lorlor = _prefixId.prefix "lorlor"
    /// <summary>
    ///   <para>rdfs:label : skos:member^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#member">br:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : skos:prefLabel^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#prefLabel">br:prefLabel</a>
    /// </summary>
    let prefLabel = _prefixId.prefix "prefLabel"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : skos:semanticRelation^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#semanticRelation">br:semanticRelation</a>
    /// </summary>
    let semanticRelation = _prefixId.prefix "semanticRelation"
    /// <summary>
    ///   <para>rdfs:label : Tags_taggedBy^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#taggedBy">br:taggedBy</a>
    /// </summary>
    let taggedBy = _prefixId.prefix "taggedBy"
    /// <summary>
    ///   <para>rdfs:label : dc:title^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#title">br:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : rdf:type^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/br#type">br:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
