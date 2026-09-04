#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-law-cor`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/" "fibo-fnd-law-cor"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : constitution^^xsd:string</para>
    ///   <para>skos:definition : set of basic principles by which an organization is governed, especially in relation to the rights of the people it governs^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A constitution is an aggregate of fundamental principles or established precedents that constitute the legal basis of a polity, organisation or other type of entity and commonly determine how that entity is to be governed.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Constitution">fibo-fnd-law-cor:Constitution</a>
    /// </summary>
    let Constitution = _prefixId.prefix "Constitution"
    /// <summary>
    ///   <para>rdfs:label : court of law^^xsd:string</para>
    ///   <para>skos:definition : person or body of persons having judicial authority to hear and resolve disputes on the basis of statutes or the common law^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A court of law is a formal forum of justice that may have authority over civil, criminal, ecclesiastical, or military cases.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/CourtOfLaw">fibo-fnd-law-cor:CourtOfLaw</a>
    /// </summary>
    let CourtOfLaw = _prefixId.prefix "CourtOfLaw"
    /// <summary>
    ///   <para>rdfs:label : law^^xsd:string</para>
    ///   <para>skos:definition : rule recognized by some community as regulating the behavior of its members and that it may enforce through the imposition of penalties^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Law is a term which does not have a universally accepted definition. Certain laws are made by governments, specifically by their legislatures although the sense intended here is broader. The formation of laws themselves may be influenced by a constitution (written or unwritten) and the rights encoded therein. The law shapes politics, economics and society in countless ways and serves as a social mediator of relations between people.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Law">fibo-fnd-law-cor:Law</a>
    /// </summary>
    let Law = _prefixId.prefix "Law"
    /// <summary>
    ///   <para>rdfs:label : statute law</para>
    ///   <para>skos:altLabel : statutory law^^xsd:string</para>
    ///   <para>skos:definition : law enacted by a legislature^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.law.cornell.edu/wex/statute^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : In the United States, statutes may also be called acts, such as the Civil Rights Act of 1964 or the Sarbanes-Oxley Act. Federal laws must be passed by both houses of Congress, the House of Representative and the Senate, and then usually require approval from the president before they can take effect.^^xsd:stringcmns-av:explanatoryNote : Statutes may originate with national, state legislatures or local municipalities. Statutory laws are subordinate to the higher constitutional laws of the land.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/StatuteLaw">fibo-fnd-law-cor:StatuteLaw</a>
    /// </summary>
    let StatuteLaw = _prefixId.prefix "StatuteLaw"
    /// <summary>
    ///   <para>rdfs:label : has in force^^xsd:string</para>
    ///   <para>skos:definition : relates a jurisdiction or situation to a rule, regulation or law (collectively "law") that is currently in force in that situation or jurisdiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/hasInForce">fibo-fnd-law-cor:hasInForce</a>
    /// </summary>
    let hasInForce = _prefixId.prefix "hasInForce"
    /// <summary>
    ///   <para>rdfs:label : is in force in^^xsd:string</para>
    ///   <para>skos:definition : identifies a jurisdiction in which some law has effect^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/isInForceIn">fibo-fnd-law-cor:isInForceIn</a>
    /// </summary>
    let isInForceIn = _prefixId.prefix "isInForceIn"
