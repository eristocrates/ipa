#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc_rm =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/rm#" "oslc_rm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Statement of need.^^xsd:string</para>
    ///   <para>rdfs:label : Requirement^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#Requirement">oslc_rm:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    /// <summary>
    ///   <para>rdfs:comment : Collection of requirements. A collection uses zero or more requirements.^^xsd:string</para>
    ///   <para>rdfs:label : RequirementCollection^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#RequirementCollection">oslc_rm:RequirementCollection</a>
    /// </summary>
    let RequirementCollection = _prefixId.prefix "RequirementCollection"
    /// <summary>
    ///   <para>rdfs:comment : Expresses an affects relationship between entities, where the object entity in some way affects the subject entity. For example, a requirement is affected by a defect.^^xsd:string</para>
    ///   <para>rdfs:label : affectedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#affectedBy">oslc_rm:affectedBy</a>
    /// </summary>
    let affectedBy = _prefixId.prefix "affectedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a constraining relationship between entities, where the object entity constrains the subject entity. For example, a functional requirement is constrained by a safety requirement.^^xsd:string</para>
    ///   <para>rdfs:label : constrainedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#constrainedBy">oslc_rm:constrainedBy</a>
    /// </summary>
    let constrainedBy = _prefixId.prefix "constrainedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a constraining relationship between entities, where the subject entity constrains the object entity. For example, a safety requirement constrains a functional requirement.^^xsd:string</para>
    ///   <para>rdfs:label : constrains^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#constrains">oslc_rm:constrains</a>
    /// </summary>
    let constrains = _prefixId.prefix "constrains"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a decomposition relationship between entities, where the object entity decomposes the subject entity. For example, a system requirement is decomposed into a collection of system requirements.^^xsd:string</para>
    ///   <para>rdfs:label : decomposedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#decomposedBy">oslc_rm:decomposedBy</a>
    /// </summary>
    let decomposedBy = _prefixId.prefix "decomposedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a decomposition relationship between entities, where the subject entity decomposes the object entity. For example, a collection of system requirements decompose a system requirement.^^xsd:string</para>
    ///   <para>rdfs:label : decomposes^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#decomposes">oslc_rm:decomposes</a>
    /// </summary>
    let decomposes = _prefixId.prefix "decomposes"
    /// <summary>
    ///   <para>rdfs:comment : Expresses an elaboration relationship between entities, where the object entity elaborates the subject entity. For example, a requirement is elaborated by a model element.^^xsd:string</para>
    ///   <para>rdfs:label : elaboratedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#elaboratedBy">oslc_rm:elaboratedBy</a>
    /// </summary>
    let elaboratedBy = _prefixId.prefix "elaboratedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses an elaboration relationship between entities, where the subject entity elaborates the object entity. For example, a model element elaborates a requirement.^^xsd:string</para>
    ///   <para>rdfs:label : elaborates^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#elaborates">oslc_rm:elaborates</a>
    /// </summary>
    let elaborates = _prefixId.prefix "elaborates"
    /// <summary>
    ///   <para>rdfs:comment : Expresses an implementation relationship between entities, where the object entity is a necessary or desirable aspect of an implementation of the subject entity.^^xsd:string</para>
    ///   <para>rdfs:label : implementedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#implementedBy">oslc_rm:implementedBy</a>
    /// </summary>
    let implementedBy = _prefixId.prefix "implementedBy"
    /// <summary>
    ///   <para>rdfs:comment : The subject is satisfied by the object. For example, a user requirement is satisfied by a system requirement.^^xsd:string</para>
    ///   <para>rdfs:label : satisfiedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#satisfiedBy">oslc_rm:satisfiedBy</a>
    /// </summary>
    let satisfiedBy = _prefixId.prefix "satisfiedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a relationship between entities, where the subject entity satisfies the object entity. For example, a system requirement satisfies a user requirement.^^xsd:string</para>
    ///   <para>rdfs:label : satisfies^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#satisfies">oslc_rm:satisfies</a>
    /// </summary>
    let satisfies = _prefixId.prefix "satisfies"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a specification relationship between entities, where the object entity further clarifies or specifies the subject entity. For example, a requirement is specified by a model element.^^xsd:string</para>
    ///   <para>rdfs:label : specifiedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#specifiedBy">oslc_rm:specifiedBy</a>
    /// </summary>
    let specifiedBy = _prefixId.prefix "specifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a specification relationship between entities, where the subject entity further clarifies or specifies the object entity. For example, a model element specifies a requirement.^^xsd:string</para>
    ///   <para>rdfs:label : specifies^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#specifies">oslc_rm:specifies</a>
    /// </summary>
    let specifies = _prefixId.prefix "specifies"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a tracking relationship between entities, where the object entity in some way tracks or governs the evolution of the subject entity. For example, a requirement may be said to be tracked by a change request, in that it governs the changes to a requirement according to some process machinery.^^xsd:string</para>
    ///   <para>rdfs:label : trackedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#trackedBy">oslc_rm:trackedBy</a>
    /// </summary>
    let trackedBy = _prefixId.prefix "trackedBy"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a use relationship between entities, where the object entity is used by the subject entity. For example, a requirement collection may use a requirement.^^xsd:string</para>
    ///   <para>rdfs:label : uses^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#uses">oslc_rm:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>rdfs:comment : Expresses a validation relationship between entities, where the object entity in some way validates the subject entity. For example, a requirement collection may be said to be validated by a test plan.^^xsd:string</para>
    ///   <para>rdfs:label : validatedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/rm#validatedBy">oslc_rm:validatedBy</a>
    /// </summary>
    let validatedBy = _prefixId.prefix "validatedBy"
