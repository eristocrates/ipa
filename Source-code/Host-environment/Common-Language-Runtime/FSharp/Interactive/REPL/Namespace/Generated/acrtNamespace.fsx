#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module acrt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://privatealpha.com/ontology/certification/1#" "acrt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : The issuance of a government-regulated privilege, e.g. driver's licenseskos:example : An officially-recognized trade qualification, e.g. a welding ticketskos:example : An errors and omissions insurance policyskos:example : The issuance of an academic degree to a particular personskos:example : A pet license, where the principal is an animalskos:example : The notarization of an affadavitskos:example : An award (e.g. 2014 Nobel Prize in physics)skos:example : A mandatory professional status, e.g. bar association membershipskos:example : A private certification of achievement, e.g. CISSP</para>
    ///   <para>rdfs:label : Certification</para>
    ///   <para>rdfs:comment : This class represents the abstract notion of certification, of an agent, by another agent, that the first agent possesses some property or set of properties implied by the certification, potentially within some spatiotemporal scope, and which may or may not be designated by some identifier.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#Certification">acrt:Certification</a>
    /// </summary>
    let Certification = _prefixId.prefix "Certification"
    /// <summary>
    ///   <para>skos:note : The issuing authority can, once again, be a person, business, institution, or any other kind of agent.</para>
    ///   <para>rdfs:label : authority</para>
    ///   <para>rdfs:comment : This property specifies who (or what) is doing the certifying.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#authority">acrt:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:label : certifies</para>
    ///   <para>rdfs:comment : This property specifies that its subject, an agent, has issued a certification.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#certifies">acrt:certifies</a>
    /// </summary>
    let certifies = _prefixId.prefix "certifies"
    /// <summary>
    ///   <para>rdfs:label : has-certification</para>
    ///   <para>rdfs:comment : This property specifies that an agent possesses a given certification.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#has-certification">acrt:has-certification</a>
    /// </summary>
    let has_certification = _prefixId.prefix "has-certification"
    /// <summary>
    ///   <para>skos:note : The principal of the certification can be any agent, like a person, company, animal, AI, whatever.</para>
    ///   <para>rdfs:label : principal</para>
    ///   <para>rdfs:comment : This property specifies who or what agent is being certified.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#principal">acrt:principal</a>
    /// </summary>
    let principal = _prefixId.prefix "principal"
    /// <summary>
    ///   <para>skos:note : The range of this term is left open, but should probably reference a document. It could even point to an actual cryptographic certificate.</para>
    ///   <para>rdfs:label : proof</para>
    ///   <para>rdfs:comment : This property points to some proof of the certification, like a scan of an official document or a page on the issuing authority's website that corroborates the certification.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#proof">acrt:proof</a>
    /// </summary>
    let proof = _prefixId.prefix "proof"
    /// <summary>
    ///   <para>rdfs:label : proves</para>
    ///   <para>rdfs:comment : This property asserts that its subject is somehow proof of a given certification.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#proves">acrt:proves</a>
    /// </summary>
    let proves = _prefixId.prefix "proves"
    /// <summary>
    ///   <para>skos:note : The range of this term is left open, but should probably reference something abstract like a skos:Concept, an org:Role (itself a subclass of skos:Concept), or a skill, such as modeled by the Cognitive Characteristics Ontology.</para>
    ///   <para>rdfs:label : qualification</para>
    ///   <para>rdfs:comment : This property specifies what achievement, skill, or fact is being certified.</para>
    ///   <a href="http://privatealpha.com/ontology/certification/1#qualification">acrt:qualification</a>
    /// </summary>
    let qualification = _prefixId.prefix "qualification"
