#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ldr =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ldr/ns#" "ldr"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Right of access, which can be legally granted (e.g. public sector information) or expressely restricted (e.g. secrets compromising national security)</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Access">ldr:Access</a>
    /// </summary>
    let Access = _prefixId.prefix "Access"
    let Action = _prefixId.prefix "Action"
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : Reason which can be invoked to make an exception to the intellectual property or database law </para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#CopyrightException">ldr:CopyrightException</a>
    /// </summary>
    let CopyrightException = _prefixId.prefix "CopyrightException"
    /// <summary>
    ///   <para>rdfs:comment : Sui generis right for databases, recognized in European countries and others</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#DatabaseRight">ldr:DatabaseRight</a>
    /// </summary>
    let DatabaseRight = _prefixId.prefix "DatabaseRight"
    /// <summary>
    ///   <para>rdfs:comment : Transformation of the work, including translation adaptation or any other form modification</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Derivation">ldr:Derivation</a>
    /// </summary>
    let Derivation = _prefixId.prefix "Derivation"
    /// <summary>
    ///   <para>rdfs:comment : Make available the original work or its copies, in a physical medium</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Distribution">ldr:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:comment : Extended Relations may tie Permission, Prohibition, Duty, and Constraint entities together with an AND, OR or XOR relationship. Only entities of the same type can be linked with this model. For example, a Permission and Prohibition cannot be linked together within this model. The Extended rule is composed of two or more rules^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#ExtendedRule">ldr:ExtendedRule</a>
    /// </summary>
    let ExtendedRule = _prefixId.prefix "ExtendedRule"
    /// <summary>
    ///   <para>rdfs:comment : Right to permanent or temporary transfer of all or a substantial part of the contents of a database to another medium by any means or in any form</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Extraction">ldr:Extraction</a>
    /// </summary>
    let Extraction = _prefixId.prefix "Extraction"
    /// <summary>
    ///   <para>rdfs:comment : License publicly available and known to the public</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#FamousDataLicense">ldr:FamousDataLicense</a>
    /// </summary>
    let FamousDataLicense = _prefixId.prefix "FamousDataLicense"
    let HTTPDELETE = _prefixId.prefix "HTTPDELETE"
    let HTTPGET = _prefixId.prefix "HTTPGET"
    let HTTPPATCH = _prefixId.prefix "HTTPPATCH"
    let HTTPPOST = _prefixId.prefix "HTTPPOST"
    let HTTPPUT = _prefixId.prefix "HTTPPUT"
    /// <summary>
    ///   <para>rdfs:comment : Intellectual Property right</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#IPRight">ldr:IPRight</a>
    /// </summary>
    let IPRight = _prefixId.prefix "IPRight"
    let LDPAccess = _prefixId.prefix "LDPAccess"
    /// <summary>
    ///   <para>rdfs:comment : Set of rights expressions offered to the public, which grant one or more rights, possibly conditioned to the fulfillment of one or more conditions (propositions)</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#License">ldr:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    let LinkedDataAccess = _prefixId.prefix "LinkedDataAccess"
    /// <summary>
    ///   <para>rdfs:comment : A policy applied over a Linked Data resource</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#LinkedDataPolicy">ldr:LinkedDataPolicy</a>
    /// </summary>
    let LinkedDataPolicy = _prefixId.prefix "LinkedDataPolicy"
    /// <summary>
    ///   <para>rdfs:comment : A Linked Data resource, object of some rights</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#LinkedDataResource">ldr:LinkedDataResource</a>
    /// </summary>
    let LinkedDataResource = _prefixId.prefix "LinkedDataResource"
    /// <summary>
    ///   <para>rdfs:comment : Action legally granted as allowable to be exercised on a Linked Data resource</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#LinkedDataRight">ldr:LinkedDataRight</a>
    /// </summary>
    let LinkedDataRight = _prefixId.prefix "LinkedDataRight"
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:comment : A veritative statement</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Proposition">ldr:Proposition</a>
    /// </summary>
    let Proposition = _prefixId.prefix "Proposition"
    /// <summary>
    ///   <para>rdfs:comment : Granting a number of people access to the work without existing distribution</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#PublicCommunication">ldr:PublicCommunication</a>
    /// </summary>
    let PublicCommunication = _prefixId.prefix "PublicCommunication"
    /// <summary>
    ///   <para>rdfs:comment : Direct or indirect fixation, allowing its communication and/or making copies of it</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Reproduction">ldr:Reproduction</a>
    /// </summary>
    let Reproduction = _prefixId.prefix "Reproduction"
    /// <summary>
    ///   <para>rdfs:comment : Attribute of a resource regarding its legal status</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#ResourceLegalStatus">ldr:ResourceLegalStatus</a>
    /// </summary>
    let ResourceLegalStatus = _prefixId.prefix "ResourceLegalStatus"
    /// <summary>
    ///   <para>rdfs:comment : Right to make available to the public all or a substantial part of the contents of a database by the distribution of copies, by renting, by on-line or other forms of transmission</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#Reutilization">ldr:Reutilization</a>
    /// </summary>
    let Reutilization = _prefixId.prefix "Reutilization"
    let RightsObject = _prefixId.prefix "RightsObject"
    let SPARQLASK = _prefixId.prefix "SPARQLASK"
    let SPARQLAccess = _prefixId.prefix "SPARQLAccess"
    let SPARQLCONSTRUCT = _prefixId.prefix "SPARQLCONSTRUCT"
    let SPARQLDESCRIBE = _prefixId.prefix "SPARQLDESCRIBE"
    let SPARQLSELECT = _prefixId.prefix "SPARQLSELECT"
    let access = _prefixId.prefix "access"
    let baseSoftwareUpon = _prefixId.prefix "baseSoftwareUpon"
    let copyDatabase = _prefixId.prefix "copyDatabase"
    let copyWork = _prefixId.prefix "copyWork"
    /// <summary>
    ///   <para>rdfs:comment : Format of the data ("text/html", "application/rdf+xml", etc.)</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#dataFormat">ldr:dataFormat</a>
    /// </summary>
    let dataFormat = _prefixId.prefix "dataFormat"
    let derivation = _prefixId.prefix "derivation"
    let deriveClasses = _prefixId.prefix "deriveClasses"
    let deriveProperties = _prefixId.prefix "deriveProperties"
    let distribution = _prefixId.prefix "distribution"
    let downloadDatabase = _prefixId.prefix "downloadDatabase"
    let downloadWork = _prefixId.prefix "downloadWork"
    let extract = _prefixId.prefix "extract"
    let hasAllRightsReserved = _prefixId.prefix "hasAllRightsReserved"
    /// <summary>
    ///   <para>rdfs:comment : Text that has to be included as requested by a condition</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasAttributionText">ldr:hasAttributionText</a>
    /// </summary>
    let hasAttributionText = _prefixId.prefix "hasAttributionText"
    /// <summary>
    ///   <para>rdfs:comment : Declares a claim asserted in the context of a rights expression</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasClaim">ldr:hasClaim</a>
    /// </summary>
    let hasClaim = _prefixId.prefix "hasClaim"
    let hasCopyrightExpired = _prefixId.prefix "hasCopyrightExpired"
    /// <summary>
    ///   <para>rdfs:comment : Text that has to be attached imposed as a condition</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightNotice">ldr:hasCopyrightNotice</a>
    /// </summary>
    let hasCopyrightNotice = _prefixId.prefix "hasCopyrightNotice"
    let hasDatabaseRightsExpired = _prefixId.prefix "hasDatabaseRightsExpired"
    /// <summary>
    ///   <para>rdfs:comment : Text discharging responsibilities on the use of the Linked Data resource</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasDisclaimerText">ldr:hasDisclaimerText</a>
    /// </summary>
    let hasDisclaimerText = _prefixId.prefix "hasDisclaimerText"
    /// <summary>
    ///   <para>rdfs:comment : Links a Policy to an ExtendedRule it contains</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasExtendedRule">ldr:hasExtendedRule</a>
    /// </summary>
    let hasExtendedRule = _prefixId.prefix "hasExtendedRule"
    let hasIndustrialSecret = _prefixId.prefix "hasIndustrialSecret"
    /// <summary>
    ///   <para>rdfs:comment : Declares the legal status of a resource^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasLegalStatus">ldr:hasLegalStatus</a>
    /// </summary>
    let hasLegalStatus = _prefixId.prefix "hasLegalStatus"
    let hasNationalSecurityInfo = _prefixId.prefix "hasNationalSecurityInfo"
    /// <summary>
    ///   <para>rdfs:comment : Declares that the referred resource has personal data</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasPersonalData">ldr:hasPersonalData</a>
    /// </summary>
    let hasPersonalData = _prefixId.prefix "hasPersonalData"
    /// <summary>
    ///   <para>rdfs:comment : Declares the privacy level (e.g. personal data) for a Linked Data resource</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasPrivacyLevel">ldr:hasPrivacyLevel</a>
    /// </summary>
    let hasPrivacyLevel = _prefixId.prefix "hasPrivacyLevel"
    /// <summary>
    ///   <para>rdfs:comment : Declares which requirements have to be fulfilled for the Rule to be valid</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#hasRequirement">ldr:hasRequirement</a>
    /// </summary>
    let hasRequirement = _prefixId.prefix "hasRequirement"
    let hasTopSecret = _prefixId.prefix "hasTopSecret"
    let hasclaim = _prefixId.prefix "hasclaim"
    let isInPublicDomain = _prefixId.prefix "isInPublicDomain"
    /// <summary>
    ///   <para>rdfs:comment : Date on which the rights expression is issued, with legal consequences on the copyright or database right expiration.</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#issuedOn">ldr:issuedOn</a>
    /// </summary>
    let issuedOn = _prefixId.prefix "issuedOn"
    let judicialProcess = _prefixId.prefix "judicialProcess"
    let mirror = _prefixId.prefix "mirror"
    let nationalSecurity = _prefixId.prefix "nationalSecurity"
    /// <summary>
    ///   <para>rdfs:comment : May be set with one of the mathematical values AND, OR and XOR. (OR is the default if not specified.)</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#operation">ldr:operation</a>
    /// </summary>
    let operation = _prefixId.prefix "operation"
    /// <summary>
    ///   <para>rdfs:comment : Access protocol (e.g. "SPARQL", "HTTPS", etc.)</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#protocol">ldr:protocol</a>
    /// </summary>
    let protocol = _prefixId.prefix "protocol"
    let publicCommunication = _prefixId.prefix "publicCommunication"
    let publishDatabase = _prefixId.prefix "publishDatabase"
    /// <summary>
    ///   <para>rdfs:comment : Number of queries per day</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#queriesPerDay">ldr:queriesPerDay</a>
    /// </summary>
    let queriesPerDay = _prefixId.prefix "queriesPerDay"
    /// <summary>
    ///   <para>rdfs:comment : Number of queries per minute</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#queriesPerMinute">ldr:queriesPerMinute</a>
    /// </summary>
    let queriesPerMinute = _prefixId.prefix "queriesPerMinute"
    let reasonWith = _prefixId.prefix "reasonWith"
    let rebaseURIs = _prefixId.prefix "rebaseURIs"
    let reificate = _prefixId.prefix "reificate"
    let rent = _prefixId.prefix "rent"
    let reproduction = _prefixId.prefix "reproduction"
    let research = _prefixId.prefix "research"
    let reutilization = _prefixId.prefix "reutilization"
    let sell = _prefixId.prefix "sell"
    let sellAccess = _prefixId.prefix "sellAccess"
    let transcodeWork = _prefixId.prefix "transcodeWork"
    let translateWork = _prefixId.prefix "translateWork"
    /// <summary>
    ///   <para>rdfs:comment : Truth value</para>
    ///   <a href="http://purl.oclc.org/NET/ldr/ns#truthValue">ldr:truthValue</a>
    /// </summary>
    let truthValue = _prefixId.prefix "truthValue"
