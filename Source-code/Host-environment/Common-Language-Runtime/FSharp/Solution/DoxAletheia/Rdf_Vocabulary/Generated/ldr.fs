namespace http.purl.oclc.org.NET.ldr.ns.hash

open DoxAletheia

module ldr =
    let _namespace_name = "http://purl.oclc.org/NET/ldr/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Right of access, which can be legally granted (e.g. public sector information) or expressely restricted (e.g. secrets compromising national security)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Access"></see></summary>
    let Access = _prefix "Access"
    /// <summary>
    /// Action legally granted as allowable to be exercised on a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataRight"></see></summary>
    let LinkedDataRight = _prefix "LinkedDataRight"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Deprecated in favour of the ODRL term
    /// Agent related to a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Reason which can be invoked to make an exception to the intellectual property or database law
    /// <see href="http://purl.oclc.org/NET/ldr/ns#CopyrightException"></see></summary>
    let CopyrightException = _prefix "CopyrightException"
    /// <summary>
    /// A veritative statement
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Proposition"></see></summary>
    let Proposition = _prefix "Proposition"
    /// <summary>
    /// Sui generis right for databases, recognized in European countries and others
    /// <see href="http://purl.oclc.org/NET/ldr/ns#DatabaseRight"></see></summary>
    let DatabaseRight = _prefix "DatabaseRight"
    /// <summary>
    /// Transformation of the work, including translation adaptation or any other form modification
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Derivation"></see></summary>
    let Derivation = _prefix "Derivation"
    /// <summary>
    /// Intellectual Property right
    /// <see href="http://purl.oclc.org/NET/ldr/ns#IPRight"></see></summary>
    let IPRight = _prefix "IPRight"
    /// <summary>
    /// Make available the original work or its copies, in a physical medium
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Distribution"></see></summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    /// Extended Relations may tie Permission, Prohibition, Duty, and Constraint entities together with an AND, OR or XOR relationship. Only entities of the same type can be linked with this model. For example, a Permission and Prohibition cannot be linked together within this model. The Extended rule is composed of two or more rules
    /// <see href="http://purl.oclc.org/NET/ldr/ns#ExtendedRule"></see></summary>
    let ExtendedRule = _prefix "ExtendedRule"
    /// <summary>
    /// Right to permanent or temporary transfer of all or a substantial part of the contents of a database to another medium by any means or in any form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Extraction"></see></summary>
    let Extraction = _prefix "Extraction"
    /// <summary>
    /// License publicly available and known to the public
    /// <see href="http://purl.oclc.org/NET/ldr/ns#FamousDataLicense"></see></summary>
    let FamousDataLicense = _prefix "FamousDataLicense"
    /// <summary>
    /// Set of rights expressions offered to the public, which grant one or more rights, possibly conditioned to the fulfillment of one or more conditions (propositions)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#License"></see></summary>
    let License = _prefix "License"
    /// <summary>
    /// Accessing with the HTTP DELETE Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPDELETE"></see></summary>
    let HTTPDELETE = _prefix "HTTPDELETE"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#LDPAccess"></see>
    /// </summary>
    let LDPAccess = _prefix "LDPAccess"
    /// <summary>
    /// Accessing with the HTTP GET Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPGET"></see></summary>
    let HTTPGET = _prefix "HTTPGET"
    /// <summary>
    /// Accesing with the HTTP PATH Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPPATCH"></see></summary>
    let HTTPPATCH = _prefix "HTTPPATCH"
    /// <summary>
    /// Accessing with the HTTP POST Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPPOST"></see></summary>
    let HTTPPOST = _prefix "HTTPPOST"
    /// <summary>
    /// Accessing with the HTTP PUT Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPPUT"></see></summary>
    let HTTPPUT = _prefix "HTTPPUT"
    /// <summary>
    /// A policy applied over a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataPolicy"></see></summary>
    let LinkedDataPolicy = _prefix "LinkedDataPolicy"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataAccess"></see>
    /// </summary>
    let LinkedDataAccess = _prefix "LinkedDataAccess"
    /// <summary>
    /// A Linked Data resource, object of some rights
    /// <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataResource"></see></summary>
    let LinkedDataResource = _prefix "LinkedDataResource"
    /// <summary>
    /// Granting a number of people access to the work without existing distribution
    /// <see href="http://purl.oclc.org/NET/ldr/ns#PublicCommunication"></see></summary>
    let PublicCommunication = _prefix "PublicCommunication"
    /// <summary>
    /// Direct or indirect fixation, allowing its communication and/or making copies of it
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Reproduction"></see></summary>
    let Reproduction = _prefix "Reproduction"
    /// <summary>
    /// Attribute of a resource regarding its legal status
    /// <see href="http://purl.oclc.org/NET/ldr/ns#ResourceLegalStatus"></see></summary>
    let ResourceLegalStatus = _prefix "ResourceLegalStatus"
    /// <summary>
    /// Right to make available to the public all or a substantial part of the contents of a database by the distribution of copies, by renting, by on-line or other forms of transmission
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Reutilization"></see></summary>
    let Reutilization = _prefix "Reutilization"
    /// <summary>
    /// Object over which a right is execised
    /// Deprecated in favour of ODRL
    /// <see href="http://purl.oclc.org/NET/ldr/ns#RightsObject"></see></summary>
    let RightsObject = _prefix "RightsObject"
    /// <summary>
    /// Access through the SPARQL ASK query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLASK"></see></summary>
    let SPARQLASK = _prefix "SPARQLASK"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLAccess"></see>
    /// </summary>
    let SPARQLAccess = _prefix "SPARQLAccess"
    /// <summary>
    /// Access through the SPARQL CONSTRUCT query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLCONSTRUCT"></see></summary>
    let SPARQLCONSTRUCT = _prefix "SPARQLCONSTRUCT"
    /// <summary>
    /// Access through the SPARQL DESCRIBE query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLDESCRIBE"></see></summary>
    let SPARQLDESCRIBE = _prefix "SPARQLDESCRIBE"
    /// <summary>
    /// Access through the SPARQL SELECT query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLSELECT"></see></summary>
    let SPARQLSELECT = _prefix "SPARQLSELECT"
    /// <summary>
    /// Access in any manner or form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#access"></see></summary>
    let access = _prefix "access"
    /// <summary>
    /// Distribute a pice of software whose well functioning depends on the related Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#baseSoftwareUpon"></see></summary>
    let baseSoftwareUpon = _prefix "baseSoftwareUpon"
    /// <summary>
    /// Coyping a dataset, for other purposes than private use
    /// <see href="http://purl.oclc.org/NET/ldr/ns#copyDatabase"></see></summary>
    let copyDatabase = _prefix "copyDatabase"
    /// <summary>
    /// copying the work for purposes other than private
    /// <see href="http://purl.oclc.org/NET/ldr/ns#copyWork"></see></summary>
    let copyWork = _prefix "copyWork"
    /// <summary>
    /// Format of the data ("text/html", "application/rdf+xml", etc.)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#dataFormat"></see></summary>
    let dataFormat = _prefix "dataFormat"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#hasclaim"></see>
    /// </summary>
    let hasclaim = _prefix "hasclaim"
    /// <summary>
    /// General transformation of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#derivation"></see></summary>
    let derivation = _prefix "derivation"
    /// <summary>
    /// Subclassing
    /// <see href="http://purl.oclc.org/NET/ldr/ns#deriveClasses"></see></summary>
    let deriveClasses = _prefix "deriveClasses"
    /// <summary>
    /// Subpropertying
    /// <see href="http://purl.oclc.org/NET/ldr/ns#deriveProperties"></see></summary>
    let deriveProperties = _prefix "deriveProperties"
    /// <summary>
    /// General act of making available the original work or its copies, in a physical medium
    /// <see href="http://purl.oclc.org/NET/ldr/ns#distribution"></see></summary>
    let distribution = _prefix "distribution"
    /// <summary>
    /// Downloading a dataset, for other purposes than private use
    /// <see href="http://purl.oclc.org/NET/ldr/ns#downloadDatabase"></see></summary>
    let downloadDatabase = _prefix "downloadDatabase"
    /// <summary>
    /// downloading the work for purposes other than private
    /// <see href="http://purl.oclc.org/NET/ldr/ns#downloadWork"></see></summary>
    let downloadWork = _prefix "downloadWork"
    /// <summary>
    /// General right of extraction
    /// <see href="http://purl.oclc.org/NET/ldr/ns#extract"></see></summary>
    let extract = _prefix "extract"
    /// <summary>
    /// Declares that the referred resource is protected under copyright or database rights, and none of them is waived
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasAllRightsReserved"></see></summary>
    let hasAllRightsReserved = _prefix "hasAllRightsReserved"
    /// <summary>
    /// Text that has to be included as requested by a condition
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasAttributionText"></see></summary>
    let hasAttributionText = _prefix "hasAttributionText"
    /// <summary>
    /// Declares a claim asserted in the context of a rights expression
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasClaim"></see></summary>
    let hasClaim = _prefix "hasClaim"
    /// <summary>
    /// Declares that the referred resource has its copyright expired
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightExpired"></see></summary>
    let hasCopyrightExpired = _prefix "hasCopyrightExpired"
    /// <summary>
    /// Text that has to be attached imposed as a condition
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightNotice"></see></summary>
    let hasCopyrightNotice = _prefix "hasCopyrightNotice"
    /// <summary>
    /// Declares that the referred resource has the database rights expired
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasDatabaseRightsExpired"></see></summary>
    let hasDatabaseRightsExpired = _prefix "hasDatabaseRightsExpired"
    /// <summary>
    /// Text discharging responsibilities on the use of the Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasDisclaimerText"></see></summary>
    let hasDisclaimerText = _prefix "hasDisclaimerText"
    /// <summary>
    /// Links a Policy to an ExtendedRule it contains
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasExtendedRule"></see></summary>
    let hasExtendedRule = _prefix "hasExtendedRule"
    /// <summary>
    /// The referred resource containts an Industrial Secret
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasIndustrialSecret"></see></summary>
    let hasIndustrialSecret = _prefix "hasIndustrialSecret"
    /// <summary>
    /// Declares the legal status of a resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasLegalStatus"></see></summary>
    let hasLegalStatus = _prefix "hasLegalStatus"
    /// <summary>
    /// Declares that the referred resource has information whose disclosure might harm the national security
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasNationalSecurityInfo"></see></summary>
    let hasNationalSecurityInfo = _prefix "hasNationalSecurityInfo"
    /// <summary>
    /// Declares that the referred resource has personal data
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasPersonalData"></see></summary>
    let hasPersonalData = _prefix "hasPersonalData"
    /// <summary>
    /// Declares the privacy level (e.g. personal data) for a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasPrivacyLevel"></see></summary>
    let hasPrivacyLevel = _prefix "hasPrivacyLevel"
    /// <summary>
    /// Declares which requirements have to be fulfilled for the Rule to be valid
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasRequirement"></see></summary>
    let hasRequirement = _prefix "hasRequirement"
    /// <summary>
    /// Declares that the referred resource contains top secret information of military nature or other
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasTopSecret"></see></summary>
    let hasTopSecret = _prefix "hasTopSecret"
    /// <summary>
    /// Declares that the declared resource is in the public domain
    /// <see href="http://purl.oclc.org/NET/ldr/ns#isInPublicDomain"></see></summary>
    let isInPublicDomain = _prefix "isInPublicDomain"
    /// <summary>
    /// Date on which the rights expression is issued, with legal consequences on the copyright or database right expiration.
    /// <see href="http://purl.oclc.org/NET/ldr/ns#issuedOn"></see></summary>
    let issuedOn = _prefix "issuedOn"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#Policy"></see>
    /// </summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// if the action is carried out for the purposes of an administrative or judicial procedure
    /// <see href="http://purl.oclc.org/NET/ldr/ns#judicialProcess"></see></summary>
    let judicialProcess = _prefix "judicialProcess"
    /// <summary>
    /// The action of mirroring any piece of Linked Data
    /// <see href="http://purl.oclc.org/NET/ldr/ns#mirror"></see></summary>
    let mirror = _prefix "mirror"
    /// <summary>
    /// if the action is carried out in the interests of public security
    /// <see href="http://purl.oclc.org/NET/ldr/ns#nationalSecurity"></see></summary>
    let nationalSecurity = _prefix "nationalSecurity"
    /// <summary>
    /// May be set with one of the mathematical values AND, OR and XOR. (OR is the default if not specified.)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#operation"></see></summary>
    let operation = _prefix "operation"
    /// <summary>
    /// Access protocol (e.g. "SPARQL", "HTTPS", etc.)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#protocol"></see></summary>
    let protocol = _prefix "protocol"
    /// <summary>
    /// General right of public communication
    /// <see href="http://purl.oclc.org/NET/ldr/ns#publicCommunication"></see></summary>
    let publicCommunication = _prefix "publicCommunication"
    /// <summary>
    /// Make available a database in internet or by other means
    /// <see href="http://purl.oclc.org/NET/ldr/ns#publishDatabase"></see></summary>
    let publishDatabase = _prefix "publishDatabase"
    /// <summary>
    /// Number of queries per day
    /// <see href="http://purl.oclc.org/NET/ldr/ns#queriesPerDay"></see></summary>
    let queriesPerDay = _prefix "queriesPerDay"
    /// <summary>
    /// Number of queries per minute
    /// <see href="http://purl.oclc.org/NET/ldr/ns#queriesPerMinute"></see></summary>
    let queriesPerMinute = _prefix "queriesPerMinute"
    /// <summary>
    /// Accesing Linked Data with the purpose of reasoning, through an specialized protocol (e.g. OWLLink) or not
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reasonWith"></see></summary>
    let reasonWith = _prefix "reasonWith"
    /// <summary>
    /// Partially change the URI systematically rebasing the entities
    /// <see href="http://purl.oclc.org/NET/ldr/ns#rebaseURIs"></see></summary>
    let rebaseURIs = _prefix "rebaseURIs"
    /// <summary>
    /// Reificate an RDF statement or a set thereof
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reificate"></see></summary>
    let reificate = _prefix "reificate"
    /// <summary>
    /// Renting a copy of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#rent"></see></summary>
    let rent = _prefix "rent"
    /// <summary>
    /// General right of public reproduction
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reproduction"></see></summary>
    let reproduction = _prefix "reproduction"
    /// <summary>
    /// illustration for teaching or scientific research, provided the source, including the author's name, is acknowledged
    /// <see href="http://purl.oclc.org/NET/ldr/ns#research"></see></summary>
    let research = _prefix "research"
    /// <summary>
    /// General right of re-utilization
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reutilization"></see></summary>
    let reutilization = _prefix "reutilization"
    /// <summary>
    /// Selling a copy of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#sell"></see></summary>
    let sell = _prefix "sell"
    /// <summary>
    /// Offering for meny the access to a copy of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#sellAccess"></see></summary>
    let sellAccess = _prefix "sellAccess"
    /// <summary>
    /// Transcoding the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#transcodeWork"></see></summary>
    let transcodeWork = _prefix "transcodeWork"
    /// <summary>
    /// Translating the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#translateWork"></see></summary>
    let translateWork = _prefix "translateWork"
    /// <summary>
    /// Truth value
    /// <see href="http://purl.oclc.org/NET/ldr/ns#truthValue"></see></summary>
    let truthValue = _prefix "truthValue"
