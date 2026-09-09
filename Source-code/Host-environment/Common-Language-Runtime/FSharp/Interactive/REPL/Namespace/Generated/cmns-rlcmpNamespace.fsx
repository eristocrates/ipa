#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-rlcmp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/RolesAndCompositions/" "cmns-rlcmp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : composition^^xsd:string</para>
    ///   <para>skos:definition : distinct thing resulting from bringing together other things, possibly in specific roles, for a particular purpose^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 18384-1:2016, Information technology - Reference Architecture for Service Oriented Architecture (SOA RA) - Part 1: Terminology and concepts for SOA, clause 2.5 and ISO/IEC 18384-3:2016, Information technology - Reference Architecture for Service Oriented Architecture (SOA RA) - Part 3: Service Oriented Architecture ontology, clause 8.2^^xsd:stringcmns-av:adaptedFrom : ISO/TS 19807-1:2019(en), Nanotechnologies - Magnetic nanomaterials - Part 1: Specification of characteristics and measurements for magnetic nanosuspensions, clause 3.4^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The composition may be specified based on the roles that the things play in the composition, such as the roles that various ingredients play in a recipe or pharmaceutical product, and such things may or may not be transformed in some way through the process of combining them. Quantification including the nature and amount of each thing, potentially including the ratio of the quantities, may be required depending kind of composition.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : The properties hasConstituent and hasRole are included in value restrictions rather than via number restrictions to facilitate their use in complex property chains and other axioms as needed for some applications.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/Composition">cmns-rlcmp:Composition</a>
    /// </summary>
    let Composition = _prefixId.prefix "Composition"
    /// <summary>
    ///   <para>rdfs:label : functional role^^xsd:string</para>
    ///   <para>skos:definition : role representing an underlying functionality that something, such as a person, organization, process, or service, is expected to perform or deliver^^xsd:string</para>
    ///   <para>skos:note : Functional roles can be assigned to be performed during an act.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 21298:2017(en), Health informatics - Functional and structural roles, clause 3.9^^xsd:stringcmns-av:adaptedFrom : ISO/IEC 19763-8:2015(en), Information technology - Metamodel framework for interoperability (MFI) - Part 8: Metamodel for role and goal model registration, clause 3.1.2^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/FunctionalRole">cmns-rlcmp:FunctionalRole</a>
    /// </summary>
    let FunctionalRole = _prefixId.prefix "FunctionalRole"
    /// <summary>
    ///   <para>rdfs:label : process role^^xsd:string</para>
    ///   <para>skos:definition : role that associates resources and participants to a structured set of activities involving various enterprise entities, that is designed and organised for a given purpose^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 12651-2:2014(en), Electronic document management - Vocabulary - Part 2: Workflow management, clause 3.33^^xsd:stringcmns-av:adaptedFrom : ISO 18629-1:2004(en), Industrial automation systems and integration - Process specification language - Part 1: Overview and basic principles^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/ProcessRole">cmns-rlcmp:ProcessRole</a>
    /// </summary>
    let ProcessRole = _prefixId.prefix "ProcessRole"
    /// <summary>
    ///   <para>rdfs:label : role^^xsd:string</para>
    ///   <para>skos:definition : named specific behavior of something participating in a particular context^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 19763-8:2015(en), Information technology - Metamodel framework for interoperability (MFI) - Part 8: Metamodel for role and goal model registration, clause 3.1.7^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/Role">cmns-rlcmp:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : structural role^^xsd:string</para>
    ///   <para>dct:source : ISO 21298:2017(en), Health informatics - Functional and structural roles, clause 3.26^^xsd:string</para>
    ///   <para>skos:definition : role specifying relations between entities in the sense of competence, often reflecting organizational or structural relations (hierarchies)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/StructuralRole">cmns-rlcmp:StructuralRole</a>
    /// </summary>
    let StructuralRole = _prefixId.prefix "StructuralRole"
    /// <summary>
    ///   <para>rdfs:label : has role^^xsd:string</para>
    ///   <para>skos:definition : identifies something or someone playing a part in something, such as a composition^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/hasRole">cmns-rlcmp:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : is manifested in^^xsd:string</para>
    ///   <para>skos:definition : indicates something in which the role is realized, appears, or occurs^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/isManifestedIn">cmns-rlcmp:isManifestedIn</a>
    /// </summary>
    let isManifestedIn = _prefixId.prefix "isManifestedIn"
    /// <summary>
    ///   <para>rdfs:label : is played by^^xsd:string</para>
    ///   <para>skos:definition : indicates something or someone, such as a person, organization, or other thing filling a role^^xsd:string</para>
    ///   <para>skos:example : A party, counterparty, or third party to a contract is played by an organization or person; an issuer of a financial instrument is typically played by an organization; an ingredient in a recipe may be played by a substance.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/isPlayedBy">cmns-rlcmp:isPlayedBy</a>
    /// </summary>
    let isPlayedBy = _prefixId.prefix "isPlayedBy"
    /// <summary>
    ///   <para>rdfs:label : is role in^^xsd:string</para>
    ///   <para>skos:definition : identifies something, such as a composition, situation, or contract, involving the role^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/isRoleIn">cmns-rlcmp:isRoleIn</a>
    /// </summary>
    let isRoleIn = _prefixId.prefix "isRoleIn"
    /// <summary>
    ///   <para>rdfs:label : manifests^^xsd:string</para>
    ///   <para>skos:definition : indicates a role that realizes, displays, or shows something, typically in some context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/manifests">cmns-rlcmp:manifests</a>
    /// </summary>
    let manifests = _prefixId.prefix "manifests"
    /// <summary>
    ///   <para>rdfs:label : plays role^^xsd:string</para>
    ///   <para>skos:definition : indicates a part that someone or something plays under some circumstance^^xsd:string</para>
    ///   <para>skos:example : an organization may play the role of employer, issuer, regulatory agency, bank, custodian, manufacturer, vendor, etc.; a person may play the role of employee, examiner, banker, seller, buyer, etc.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RolesAndCompositions/playsRole">cmns-rlcmp:playsRole</a>
    /// </summary>
    let playsRole = _prefixId.prefix "playsRole"
