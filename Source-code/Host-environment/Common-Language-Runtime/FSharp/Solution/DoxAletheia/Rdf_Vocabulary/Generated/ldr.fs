namespace http.purl.oclc.org.NET.ldr.ns.hash

open DoxAletheia.Rdf_Vocabulary

module ldr =
    let _namespace_name = "http://purl.oclc.org/NET/ldr/ns#"
    /// <summary>
    /// Right of access, which can be legally granted (e.g. public sector information) or expressely restricted (e.g. secrets compromising national security)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Access"></see></summary>
    let Access = Namespaced_IRI.parse _namespace_name "Access" |> NamespacedName

    /// <summary>
    /// Action legally granted as allowable to be exercised on a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataRight"></see></summary>
    let LinkedDataRight =
        Namespaced_IRI.parse _namespace_name "LinkedDataRight" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Deprecated in favour of the ODRL term
    /// Agent related to a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Reason which can be invoked to make an exception to the intellectual property or database law
    /// <see href="http://purl.oclc.org/NET/ldr/ns#CopyrightException"></see></summary>
    let CopyrightException =
        Namespaced_IRI.parse _namespace_name "CopyrightException" |> NamespacedName

    /// <summary>
    /// A veritative statement
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Proposition"></see></summary>
    let Proposition =
        Namespaced_IRI.parse _namespace_name "Proposition" |> NamespacedName

    /// <summary>
    /// Sui generis right for databases, recognized in European countries and others
    /// <see href="http://purl.oclc.org/NET/ldr/ns#DatabaseRight"></see></summary>
    let DatabaseRight =
        Namespaced_IRI.parse _namespace_name "DatabaseRight" |> NamespacedName

    /// <summary>
    /// Transformation of the work, including translation adaptation or any other form modification
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Derivation"></see></summary>
    let Derivation = Namespaced_IRI.parse _namespace_name "Derivation" |> NamespacedName
    /// <summary>
    /// Intellectual Property right
    /// <see href="http://purl.oclc.org/NET/ldr/ns#IPRight"></see></summary>
    let IPRight = Namespaced_IRI.parse _namespace_name "IPRight" |> NamespacedName

    /// <summary>
    /// Make available the original work or its copies, in a physical medium
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    /// Extended Relations may tie Permission, Prohibition, Duty, and Constraint entities together with an AND, OR or XOR relationship. Only entities of the same type can be linked with this model. For example, a Permission and Prohibition cannot be linked together within this model. The Extended rule is composed of two or more rules
    /// <see href="http://purl.oclc.org/NET/ldr/ns#ExtendedRule"></see></summary>
    let ExtendedRule =
        Namespaced_IRI.parse _namespace_name "ExtendedRule" |> NamespacedName

    /// <summary>
    /// Right to permanent or temporary transfer of all or a substantial part of the contents of a database to another medium by any means or in any form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Extraction"></see></summary>
    let Extraction = Namespaced_IRI.parse _namespace_name "Extraction" |> NamespacedName

    /// <summary>
    /// License publicly available and known to the public
    /// <see href="http://purl.oclc.org/NET/ldr/ns#FamousDataLicense"></see></summary>
    let FamousDataLicense =
        Namespaced_IRI.parse _namespace_name "FamousDataLicense" |> NamespacedName

    /// <summary>
    /// Set of rights expressions offered to the public, which grant one or more rights, possibly conditioned to the fulfillment of one or more conditions (propositions)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    /// Accessing with the HTTP DELETE Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPDELETE"></see></summary>
    let HTTPDELETE = Namespaced_IRI.parse _namespace_name "HTTPDELETE" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#LDPAccess"></see>
    /// </summary>
    let LDPAccess = Namespaced_IRI.parse _namespace_name "LDPAccess" |> NamespacedName
    /// <summary>
    /// Accessing with the HTTP GET Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPGET"></see></summary>
    let HTTPGET = Namespaced_IRI.parse _namespace_name "HTTPGET" |> NamespacedName
    /// <summary>
    /// Accesing with the HTTP PATH Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPPATCH"></see></summary>
    let HTTPPATCH = Namespaced_IRI.parse _namespace_name "HTTPPATCH" |> NamespacedName
    /// <summary>
    /// Accessing with the HTTP POST Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPPOST"></see></summary>
    let HTTPPOST = Namespaced_IRI.parse _namespace_name "HTTPPOST" |> NamespacedName
    /// <summary>
    /// Accessing with the HTTP PUT Method
    /// <see href="http://purl.oclc.org/NET/ldr/ns#HTTPPUT"></see></summary>
    let HTTPPUT = Namespaced_IRI.parse _namespace_name "HTTPPUT" |> NamespacedName

    /// <summary>
    /// A policy applied over a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataPolicy"></see></summary>
    let LinkedDataPolicy =
        Namespaced_IRI.parse _namespace_name "LinkedDataPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataAccess"></see>
    /// </summary>
    let LinkedDataAccess =
        Namespaced_IRI.parse _namespace_name "LinkedDataAccess" |> NamespacedName

    /// <summary>
    /// A Linked Data resource, object of some rights
    /// <see href="http://purl.oclc.org/NET/ldr/ns#LinkedDataResource"></see></summary>
    let LinkedDataResource =
        Namespaced_IRI.parse _namespace_name "LinkedDataResource" |> NamespacedName

    /// <summary>
    /// Granting a number of people access to the work without existing distribution
    /// <see href="http://purl.oclc.org/NET/ldr/ns#PublicCommunication"></see></summary>
    let PublicCommunication =
        Namespaced_IRI.parse _namespace_name "PublicCommunication" |> NamespacedName

    /// <summary>
    /// Direct or indirect fixation, allowing its communication and/or making copies of it
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Reproduction"></see></summary>
    let Reproduction =
        Namespaced_IRI.parse _namespace_name "Reproduction" |> NamespacedName

    /// <summary>
    /// Attribute of a resource regarding its legal status
    /// <see href="http://purl.oclc.org/NET/ldr/ns#ResourceLegalStatus"></see></summary>
    let ResourceLegalStatus =
        Namespaced_IRI.parse _namespace_name "ResourceLegalStatus" |> NamespacedName

    /// <summary>
    /// Right to make available to the public all or a substantial part of the contents of a database by the distribution of copies, by renting, by on-line or other forms of transmission
    /// <see href="http://purl.oclc.org/NET/ldr/ns#Reutilization"></see></summary>
    let Reutilization =
        Namespaced_IRI.parse _namespace_name "Reutilization" |> NamespacedName

    /// <summary>
    /// Object over which a right is execised
    /// Deprecated in favour of ODRL
    /// <see href="http://purl.oclc.org/NET/ldr/ns#RightsObject"></see></summary>
    let RightsObject =
        Namespaced_IRI.parse _namespace_name "RightsObject" |> NamespacedName

    /// <summary>
    /// Access through the SPARQL ASK query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLASK"></see></summary>
    let SPARQLASK = Namespaced_IRI.parse _namespace_name "SPARQLASK" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLAccess"></see>
    /// </summary>
    let SPARQLAccess =
        Namespaced_IRI.parse _namespace_name "SPARQLAccess" |> NamespacedName

    /// <summary>
    /// Access through the SPARQL CONSTRUCT query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLCONSTRUCT"></see></summary>
    let SPARQLCONSTRUCT =
        Namespaced_IRI.parse _namespace_name "SPARQLCONSTRUCT" |> NamespacedName

    /// <summary>
    /// Access through the SPARQL DESCRIBE query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLDESCRIBE"></see></summary>
    let SPARQLDESCRIBE =
        Namespaced_IRI.parse _namespace_name "SPARQLDESCRIBE" |> NamespacedName

    /// <summary>
    /// Access through the SPARQL SELECT query form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#SPARQLSELECT"></see></summary>
    let SPARQLSELECT =
        Namespaced_IRI.parse _namespace_name "SPARQLSELECT" |> NamespacedName

    /// <summary>
    /// Access in any manner or form
    /// <see href="http://purl.oclc.org/NET/ldr/ns#access"></see></summary>
    let access = Namespaced_IRI.parse _namespace_name "access" |> NamespacedName

    /// <summary>
    /// Distribute a pice of software whose well functioning depends on the related Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#baseSoftwareUpon"></see></summary>
    let baseSoftwareUpon =
        Namespaced_IRI.parse _namespace_name "baseSoftwareUpon" |> NamespacedName

    /// <summary>
    /// Coyping a dataset, for other purposes than private use
    /// <see href="http://purl.oclc.org/NET/ldr/ns#copyDatabase"></see></summary>
    let copyDatabase =
        Namespaced_IRI.parse _namespace_name "copyDatabase" |> NamespacedName

    /// <summary>
    /// copying the work for purposes other than private
    /// <see href="http://purl.oclc.org/NET/ldr/ns#copyWork"></see></summary>
    let copyWork = Namespaced_IRI.parse _namespace_name "copyWork" |> NamespacedName
    /// <summary>
    /// Format of the data ("text/html", "application/rdf+xml", etc.)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#dataFormat"></see></summary>
    let dataFormat = Namespaced_IRI.parse _namespace_name "dataFormat" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#hasclaim"></see>
    /// </summary>
    let hasclaim = Namespaced_IRI.parse _namespace_name "hasclaim" |> NamespacedName
    /// <summary>
    /// General transformation of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#derivation"></see></summary>
    let derivation = Namespaced_IRI.parse _namespace_name "derivation" |> NamespacedName

    /// <summary>
    /// Subclassing
    /// <see href="http://purl.oclc.org/NET/ldr/ns#deriveClasses"></see></summary>
    let deriveClasses =
        Namespaced_IRI.parse _namespace_name "deriveClasses" |> NamespacedName

    /// <summary>
    /// Subpropertying
    /// <see href="http://purl.oclc.org/NET/ldr/ns#deriveProperties"></see></summary>
    let deriveProperties =
        Namespaced_IRI.parse _namespace_name "deriveProperties" |> NamespacedName

    /// <summary>
    /// General act of making available the original work or its copies, in a physical medium
    /// <see href="http://purl.oclc.org/NET/ldr/ns#distribution"></see></summary>
    let distribution =
        Namespaced_IRI.parse _namespace_name "distribution" |> NamespacedName

    /// <summary>
    /// Downloading a dataset, for other purposes than private use
    /// <see href="http://purl.oclc.org/NET/ldr/ns#downloadDatabase"></see></summary>
    let downloadDatabase =
        Namespaced_IRI.parse _namespace_name "downloadDatabase" |> NamespacedName

    /// <summary>
    /// downloading the work for purposes other than private
    /// <see href="http://purl.oclc.org/NET/ldr/ns#downloadWork"></see></summary>
    let downloadWork =
        Namespaced_IRI.parse _namespace_name "downloadWork" |> NamespacedName

    /// <summary>
    /// General right of extraction
    /// <see href="http://purl.oclc.org/NET/ldr/ns#extract"></see></summary>
    let extract = Namespaced_IRI.parse _namespace_name "extract" |> NamespacedName

    /// <summary>
    /// Declares that the referred resource is protected under copyright or database rights, and none of them is waived
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasAllRightsReserved"></see></summary>
    let hasAllRightsReserved =
        Namespaced_IRI.parse _namespace_name "hasAllRightsReserved" |> NamespacedName

    /// <summary>
    /// Text that has to be included as requested by a condition
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasAttributionText"></see></summary>
    let hasAttributionText =
        Namespaced_IRI.parse _namespace_name "hasAttributionText" |> NamespacedName

    /// <summary>
    /// Declares a claim asserted in the context of a rights expression
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasClaim"></see></summary>
    let hasClaim = Namespaced_IRI.parse _namespace_name "hasClaim" |> NamespacedName

    /// <summary>
    /// Declares that the referred resource has its copyright expired
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightExpired"></see></summary>
    let hasCopyrightExpired =
        Namespaced_IRI.parse _namespace_name "hasCopyrightExpired" |> NamespacedName

    /// <summary>
    /// Text that has to be attached imposed as a condition
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightNotice"></see></summary>
    let hasCopyrightNotice =
        Namespaced_IRI.parse _namespace_name "hasCopyrightNotice" |> NamespacedName

    /// <summary>
    /// Declares that the referred resource has the database rights expired
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasDatabaseRightsExpired"></see></summary>
    let hasDatabaseRightsExpired =
        Namespaced_IRI.parse _namespace_name "hasDatabaseRightsExpired" |> NamespacedName

    /// <summary>
    /// Text discharging responsibilities on the use of the Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasDisclaimerText"></see></summary>
    let hasDisclaimerText =
        Namespaced_IRI.parse _namespace_name "hasDisclaimerText" |> NamespacedName

    /// <summary>
    /// Links a Policy to an ExtendedRule it contains
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasExtendedRule"></see></summary>
    let hasExtendedRule =
        Namespaced_IRI.parse _namespace_name "hasExtendedRule" |> NamespacedName

    /// <summary>
    /// The referred resource containts an Industrial Secret
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasIndustrialSecret"></see></summary>
    let hasIndustrialSecret =
        Namespaced_IRI.parse _namespace_name "hasIndustrialSecret" |> NamespacedName

    /// <summary>
    /// Declares the legal status of a resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasLegalStatus"></see></summary>
    let hasLegalStatus =
        Namespaced_IRI.parse _namespace_name "hasLegalStatus" |> NamespacedName

    /// <summary>
    /// Declares that the referred resource has information whose disclosure might harm the national security
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasNationalSecurityInfo"></see></summary>
    let hasNationalSecurityInfo =
        Namespaced_IRI.parse _namespace_name "hasNationalSecurityInfo" |> NamespacedName

    /// <summary>
    /// Declares that the referred resource has personal data
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasPersonalData"></see></summary>
    let hasPersonalData =
        Namespaced_IRI.parse _namespace_name "hasPersonalData" |> NamespacedName

    /// <summary>
    /// Declares the privacy level (e.g. personal data) for a Linked Data resource
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasPrivacyLevel"></see></summary>
    let hasPrivacyLevel =
        Namespaced_IRI.parse _namespace_name "hasPrivacyLevel" |> NamespacedName

    /// <summary>
    /// Declares which requirements have to be fulfilled for the Rule to be valid
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasRequirement"></see></summary>
    let hasRequirement =
        Namespaced_IRI.parse _namespace_name "hasRequirement" |> NamespacedName

    /// <summary>
    /// Declares that the referred resource contains top secret information of military nature or other
    /// <see href="http://purl.oclc.org/NET/ldr/ns#hasTopSecret"></see></summary>
    let hasTopSecret =
        Namespaced_IRI.parse _namespace_name "hasTopSecret" |> NamespacedName

    /// <summary>
    /// Declares that the declared resource is in the public domain
    /// <see href="http://purl.oclc.org/NET/ldr/ns#isInPublicDomain"></see></summary>
    let isInPublicDomain =
        Namespaced_IRI.parse _namespace_name "isInPublicDomain" |> NamespacedName

    /// <summary>
    /// Date on which the rights expression is issued, with legal consequences on the copyright or database right expiration.
    /// <see href="http://purl.oclc.org/NET/ldr/ns#issuedOn"></see></summary>
    let issuedOn = Namespaced_IRI.parse _namespace_name "issuedOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ldr/ns#Policy"></see>
    /// </summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// if the action is carried out for the purposes of an administrative or judicial procedure
    /// <see href="http://purl.oclc.org/NET/ldr/ns#judicialProcess"></see></summary>
    let judicialProcess =
        Namespaced_IRI.parse _namespace_name "judicialProcess" |> NamespacedName

    /// <summary>
    /// The action of mirroring any piece of Linked Data
    /// <see href="http://purl.oclc.org/NET/ldr/ns#mirror"></see></summary>
    let mirror = Namespaced_IRI.parse _namespace_name "mirror" |> NamespacedName

    /// <summary>
    /// if the action is carried out in the interests of public security
    /// <see href="http://purl.oclc.org/NET/ldr/ns#nationalSecurity"></see></summary>
    let nationalSecurity =
        Namespaced_IRI.parse _namespace_name "nationalSecurity" |> NamespacedName

    /// <summary>
    /// May be set with one of the mathematical values AND, OR and XOR. (OR is the default if not specified.)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#operation"></see></summary>
    let operation = Namespaced_IRI.parse _namespace_name "operation" |> NamespacedName
    /// <summary>
    /// Access protocol (e.g. "SPARQL", "HTTPS", etc.)
    /// <see href="http://purl.oclc.org/NET/ldr/ns#protocol"></see></summary>
    let protocol = Namespaced_IRI.parse _namespace_name "protocol" |> NamespacedName

    /// <summary>
    /// General right of public communication
    /// <see href="http://purl.oclc.org/NET/ldr/ns#publicCommunication"></see></summary>
    let publicCommunication =
        Namespaced_IRI.parse _namespace_name "publicCommunication" |> NamespacedName

    /// <summary>
    /// Make available a database in internet or by other means
    /// <see href="http://purl.oclc.org/NET/ldr/ns#publishDatabase"></see></summary>
    let publishDatabase =
        Namespaced_IRI.parse _namespace_name "publishDatabase" |> NamespacedName

    /// <summary>
    /// Number of queries per day
    /// <see href="http://purl.oclc.org/NET/ldr/ns#queriesPerDay"></see></summary>
    let queriesPerDay =
        Namespaced_IRI.parse _namespace_name "queriesPerDay" |> NamespacedName

    /// <summary>
    /// Number of queries per minute
    /// <see href="http://purl.oclc.org/NET/ldr/ns#queriesPerMinute"></see></summary>
    let queriesPerMinute =
        Namespaced_IRI.parse _namespace_name "queriesPerMinute" |> NamespacedName

    /// <summary>
    /// Accesing Linked Data with the purpose of reasoning, through an specialized protocol (e.g. OWLLink) or not
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reasonWith"></see></summary>
    let reasonWith = Namespaced_IRI.parse _namespace_name "reasonWith" |> NamespacedName
    /// <summary>
    /// Partially change the URI systematically rebasing the entities
    /// <see href="http://purl.oclc.org/NET/ldr/ns#rebaseURIs"></see></summary>
    let rebaseURIs = Namespaced_IRI.parse _namespace_name "rebaseURIs" |> NamespacedName
    /// <summary>
    /// Reificate an RDF statement or a set thereof
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reificate"></see></summary>
    let reificate = Namespaced_IRI.parse _namespace_name "reificate" |> NamespacedName
    /// <summary>
    /// Renting a copy of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#rent"></see></summary>
    let rent = Namespaced_IRI.parse _namespace_name "rent" |> NamespacedName

    /// <summary>
    /// General right of public reproduction
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reproduction"></see></summary>
    let reproduction =
        Namespaced_IRI.parse _namespace_name "reproduction" |> NamespacedName

    /// <summary>
    /// illustration for teaching or scientific research, provided the source, including the author's name, is acknowledged
    /// <see href="http://purl.oclc.org/NET/ldr/ns#research"></see></summary>
    let research = Namespaced_IRI.parse _namespace_name "research" |> NamespacedName

    /// <summary>
    /// General right of re-utilization
    /// <see href="http://purl.oclc.org/NET/ldr/ns#reutilization"></see></summary>
    let reutilization =
        Namespaced_IRI.parse _namespace_name "reutilization" |> NamespacedName

    /// <summary>
    /// Selling a copy of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#sell"></see></summary>
    let sell = Namespaced_IRI.parse _namespace_name "sell" |> NamespacedName
    /// <summary>
    /// Offering for meny the access to a copy of the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#sellAccess"></see></summary>
    let sellAccess = Namespaced_IRI.parse _namespace_name "sellAccess" |> NamespacedName

    /// <summary>
    /// Transcoding the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#transcodeWork"></see></summary>
    let transcodeWork =
        Namespaced_IRI.parse _namespace_name "transcodeWork" |> NamespacedName

    /// <summary>
    /// Translating the work
    /// <see href="http://purl.oclc.org/NET/ldr/ns#translateWork"></see></summary>
    let translateWork =
        Namespaced_IRI.parse _namespace_name "translateWork" |> NamespacedName

    /// <summary>
    /// Truth value
    /// <see href="http://purl.oclc.org/NET/ldr/ns#truthValue"></see></summary>
    let truthValue = Namespaced_IRI.parse _namespace_name "truthValue" |> NamespacedName
