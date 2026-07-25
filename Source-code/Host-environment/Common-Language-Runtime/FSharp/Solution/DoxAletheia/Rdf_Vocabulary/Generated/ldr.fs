namespace http.purl.oclc.org.NET.ldr.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ldr =
    let _namespace_iri = Namespace_Iri ldr |> NamespaceIRI
    /// <summary>
    ///   <para>ldr:HTTPDELETE</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:LDPAccess</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Accessing with the HTTP DELETE Method</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#HTTPDELETE">http://purl.oclc.org/NET/ldr/ns#HTTPDELETE</seealso>
    let HTTPDELETE = Prefixed_Name(ldr, "HTTPDELETE") |> PrefixedName
    /// <summary>
    ///   <para>ldr:LinkedDataPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A policy applied over a Linked Data resource</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#LinkedDataPolicy">http://purl.oclc.org/NET/ldr/ns#LinkedDataPolicy</seealso>
    let LinkedDataPolicy = Prefixed_Name(ldr, "LinkedDataPolicy") |> PrefixedName
    /// <summary>
    ///   <para>ldr:downloadDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Extraction</para>
    ///   <para>Downloading a dataset, for other purposes than private use</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#downloadDatabase">http://purl.oclc.org/NET/ldr/ns#downloadDatabase</seealso>
    let downloadDatabase = Prefixed_Name(ldr, "downloadDatabase") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares a claim asserted in the context of a rights expression</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasClaim">http://purl.oclc.org/NET/ldr/ns#hasClaim</seealso>
    let hasClaim = Prefixed_Name(ldr, "hasClaim") |> PrefixedName
    /// <summary>
    ///   <para>ldr:LinkedDataRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action legally granted as allowable to be exercised on a Linked Data resource</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#LinkedDataRight">http://purl.oclc.org/NET/ldr/ns#LinkedDataRight</seealso>
    let LinkedDataRight = Prefixed_Name(ldr, "LinkedDataRight") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transformation of the work, including translation adaptation or any other form modification</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Derivation">http://purl.oclc.org/NET/ldr/ns#Derivation</seealso>
    let Derivation = Prefixed_Name(ldr, "Derivation") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Right of access, which can be legally granted (e.g. public sector information) or expressely restricted (e.g. secrets compromising national security)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Access">http://purl.oclc.org/NET/ldr/ns#Access</seealso>
    let Access = Prefixed_Name(ldr, "Access") |> PrefixedName
    /// <summary>
    ///   <para>ldr:CopyrightException</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reason which can be invoked to make an exception to the intellectual property or database law </para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#CopyrightException">http://purl.oclc.org/NET/ldr/ns#CopyrightException</seealso>
    let CopyrightException = Prefixed_Name(ldr, "CopyrightException") |> PrefixedName
    /// <summary>
    ///   <para>ldr:IPRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intellectual Property right</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#IPRight">http://purl.oclc.org/NET/ldr/ns#IPRight</seealso>
    let IPRight = Prefixed_Name(ldr, "IPRight") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Action">http://purl.oclc.org/NET/ldr/ns#Action</seealso>
    let Action = Prefixed_Name(ldr, "Action") |> PrefixedName
    /// <summary>
    ///   <para>ldr:DatabaseRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sui generis right for databases, recognized in European countries and others</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#DatabaseRight">http://purl.oclc.org/NET/ldr/ns#DatabaseRight</seealso>
    let DatabaseRight = Prefixed_Name(ldr, "DatabaseRight") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>Agent related to a Linked Data resource</para>
    ///   <para>Deprecated in favour of the ODRL term</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Agent">http://purl.oclc.org/NET/ldr/ns#Agent</seealso>
    let Agent = Prefixed_Name(ldr, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>ldr:reutilization</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Reutilization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>General right of re-utilization</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#reutilization">http://purl.oclc.org/NET/ldr/ns#reutilization</seealso>
    let reutilization = Prefixed_Name(ldr, "reutilization") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Proposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A veritative statement</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Proposition">http://purl.oclc.org/NET/ldr/ns#Proposition</seealso>
    let Proposition = Prefixed_Name(ldr, "Proposition") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Make available the original work or its copies, in a physical medium</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Distribution">http://purl.oclc.org/NET/ldr/ns#Distribution</seealso>
    let Distribution = Prefixed_Name(ldr, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>ldr:ExtendedRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extended Relations may tie Permission, Prohibition, Duty, and Constraint entities together with an AND, OR or XOR relationship. Only entities of the same type can be linked with this model. For example, a Permission and Prohibition cannot be linked together within this model. The Extended rule is composed of two or more rules</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#ExtendedRule">http://purl.oclc.org/NET/ldr/ns#ExtendedRule</seealso>
    let ExtendedRule = Prefixed_Name(ldr, "ExtendedRule") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Extraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Right to permanent or temporary transfer of all or a substantial part of the contents of a database to another medium by any means or in any form</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Extraction">http://purl.oclc.org/NET/ldr/ns#Extraction</seealso>
    let Extraction = Prefixed_Name(ldr, "Extraction") |> PrefixedName
    /// <summary>
    ///   <para>ldr:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of rights expressions offered to the public, which grant one or more rights, possibly conditioned to the fulfillment of one or more conditions (propositions)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#License">http://purl.oclc.org/NET/ldr/ns#License</seealso>
    let License = Prefixed_Name(ldr, "License") |> PrefixedName
    /// <summary>
    ///   <para>ldr:HTTPGET</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:LDPAccess</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Accessing with the HTTP GET Method</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#HTTPGET">http://purl.oclc.org/NET/ldr/ns#HTTPGET</seealso>
    let HTTPGET = Prefixed_Name(ldr, "HTTPGET") |> PrefixedName
    /// <summary>
    ///   <para>ldr:FamousDataLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>License publicly available and known to the public</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#FamousDataLicense">http://purl.oclc.org/NET/ldr/ns#FamousDataLicense</seealso>
    let FamousDataLicense = Prefixed_Name(ldr, "FamousDataLicense") |> PrefixedName
    /// <summary>
    ///   <para>ldr:LDPAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#LDPAccess">http://purl.oclc.org/NET/ldr/ns#LDPAccess</seealso>
    let LDPAccess = Prefixed_Name(ldr, "LDPAccess") |> PrefixedName
    /// <summary>
    ///   <para>ldr:HTTPPATCH</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:LDPAccess</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Accesing with the HTTP PATH Method</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#HTTPPATCH">http://purl.oclc.org/NET/ldr/ns#HTTPPATCH</seealso>
    let HTTPPATCH = Prefixed_Name(ldr, "HTTPPATCH") |> PrefixedName
    /// <summary>
    ///   <para>ldr:HTTPPOST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:LDPAccess</para>
    ///   <para>Accessing with the HTTP POST Method</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#HTTPPOST">http://purl.oclc.org/NET/ldr/ns#HTTPPOST</seealso>
    let HTTPPOST = Prefixed_Name(ldr, "HTTPPOST") |> PrefixedName
    /// <summary>
    ///   <para>ldr:PublicCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Granting a number of people access to the work without existing distribution</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#PublicCommunication">http://purl.oclc.org/NET/ldr/ns#PublicCommunication</seealso>
    let PublicCommunication = Prefixed_Name(ldr, "PublicCommunication") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Direct or indirect fixation, allowing its communication and/or making copies of it</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Reproduction">http://purl.oclc.org/NET/ldr/ns#Reproduction</seealso>
    let Reproduction = Prefixed_Name(ldr, "Reproduction") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Reutilization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Right to make available to the public all or a substantial part of the contents of a database by the distribution of copies, by renting, by on-line or other forms of transmission</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Reutilization">http://purl.oclc.org/NET/ldr/ns#Reutilization</seealso>
    let Reutilization = Prefixed_Name(ldr, "Reutilization") |> PrefixedName
    /// <summary>
    ///   <para>ldr:HTTPPUT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:LDPAccess</para>
    ///   <para>Accessing with the HTTP PUT Method</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#HTTPPUT">http://purl.oclc.org/NET/ldr/ns#HTTPPUT</seealso>
    let HTTPPUT = Prefixed_Name(ldr, "HTTPPUT") |> PrefixedName
    /// <summary>
    ///   <para>ldr:LinkedDataAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Access</para>
    ///
    /// labels<para>Retrieval of Linked Data resources</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#LinkedDataAccess">http://purl.oclc.org/NET/ldr/ns#LinkedDataAccess</seealso>
    let LinkedDataAccess = Prefixed_Name(ldr, "LinkedDataAccess") |> PrefixedName
    /// <summary>
    ///   <para>ldr:LinkedDataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Linked Data resource, object of some rights</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#LinkedDataResource">http://purl.oclc.org/NET/ldr/ns#LinkedDataResource</seealso>
    let LinkedDataResource = Prefixed_Name(ldr, "LinkedDataResource") |> PrefixedName
    /// <summary>
    ///   <para>ldr:ResourceLegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Attribute of a resource regarding its legal status</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#ResourceLegalStatus">http://purl.oclc.org/NET/ldr/ns#ResourceLegalStatus</seealso>
    let ResourceLegalStatus = Prefixed_Name(ldr, "ResourceLegalStatus") |> PrefixedName
    /// <summary>
    ///   <para>ldr:SPARQLASK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:SPARQLAccess</para>
    ///   <para>Access through the SPARQL ASK query form</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#SPARQLASK">http://purl.oclc.org/NET/ldr/ns#SPARQLASK</seealso>
    let SPARQLASK = Prefixed_Name(ldr, "SPARQLASK") |> PrefixedName
    /// <summary>
    ///   <para>ldr:SPARQLDESCRIBE</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:SPARQLAccess</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Access through the SPARQL DESCRIBE query form</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#SPARQLDESCRIBE">http://purl.oclc.org/NET/ldr/ns#SPARQLDESCRIBE</seealso>
    let SPARQLDESCRIBE = Prefixed_Name(ldr, "SPARQLDESCRIBE") |> PrefixedName
    /// <summary>
    ///   <para>ldr:SPARQLAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#SPARQLAccess">http://purl.oclc.org/NET/ldr/ns#SPARQLAccess</seealso>
    let SPARQLAccess = Prefixed_Name(ldr, "SPARQLAccess") |> PrefixedName
    /// <summary>
    ///   <para>ldr:access</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Access</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Access in any manner or form</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#access">http://purl.oclc.org/NET/ldr/ns#access</seealso>
    let access = Prefixed_Name(ldr, "access") |> PrefixedName
    /// <summary>
    ///   <para>ldr:dataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Format of the data ("text/html", "application/rdf+xml", etc.)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#dataFormat">http://purl.oclc.org/NET/ldr/ns#dataFormat</seealso>
    let dataFormat = Prefixed_Name(ldr, "dataFormat") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasclaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasclaim">http://purl.oclc.org/NET/ldr/ns#hasclaim</seealso>
    let hasclaim = Prefixed_Name(ldr, "hasclaim") |> PrefixedName
    /// <summary>
    ///   <para>ldr:deriveProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Derivation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Subpropertying</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#deriveProperties">http://purl.oclc.org/NET/ldr/ns#deriveProperties</seealso>
    let deriveProperties = Prefixed_Name(ldr, "deriveProperties") |> PrefixedName
    /// <summary>
    ///   <para>ldr:copyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Reproduction</para>
    ///   <para>copying the work for purposes other than private</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#copyWork">http://purl.oclc.org/NET/ldr/ns#copyWork</seealso>
    let copyWork = Prefixed_Name(ldr, "copyWork") |> PrefixedName
    /// <summary>
    ///   <para>ldr:deriveClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Derivation</para>
    ///   <para>Subclassing</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#deriveClasses">http://purl.oclc.org/NET/ldr/ns#deriveClasses</seealso>
    let deriveClasses = Prefixed_Name(ldr, "deriveClasses") |> PrefixedName
    /// <summary>
    ///   <para>ldr:downloadWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Reproduction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>downloading the work for purposes other than private</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#downloadWork">http://purl.oclc.org/NET/ldr/ns#downloadWork</seealso>
    let downloadWork = Prefixed_Name(ldr, "downloadWork") |> PrefixedName
    /// <summary>
    ///   <para>ldr:extract</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Extraction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>General right of extraction</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#extract">http://purl.oclc.org/NET/ldr/ns#extract</seealso>
    let extract = Prefixed_Name(ldr, "extract") |> PrefixedName

    /// <summary>
    ///   <para>ldr:hasDatabaseRightsExpired</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Declares that the referred resource has the database rights expired</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasDatabaseRightsExpired">http://purl.oclc.org/NET/ldr/ns#hasDatabaseRightsExpired</seealso>
    let hasDatabaseRightsExpired =
        Prefixed_Name(ldr, "hasDatabaseRightsExpired") |> PrefixedName

    /// <summary>
    ///   <para>ldr:hasDisclaimerText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text discharging responsibilities on the use of the Linked Data resource</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasDisclaimerText">http://purl.oclc.org/NET/ldr/ns#hasDisclaimerText</seealso>
    let hasDisclaimerText = Prefixed_Name(ldr, "hasDisclaimerText") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasLegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares the legal status of a resource</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasLegalStatus">http://purl.oclc.org/NET/ldr/ns#hasLegalStatus</seealso>
    let hasLegalStatus = Prefixed_Name(ldr, "hasLegalStatus") |> PrefixedName

    /// <summary>
    ///   <para>ldr:hasNationalSecurityInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>Declares that the referred resource has information whose disclosure might harm the national security</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasNationalSecurityInfo">http://purl.oclc.org/NET/ldr/ns#hasNationalSecurityInfo</seealso>
    let hasNationalSecurityInfo =
        Prefixed_Name(ldr, "hasNationalSecurityInfo") |> PrefixedName

    /// <summary>
    ///   <para>ldr:hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares which requirements have to be fulfilled for the Rule to be valid</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasRequirement">http://purl.oclc.org/NET/ldr/ns#hasRequirement</seealso>
    let hasRequirement = Prefixed_Name(ldr, "hasRequirement") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasTopSecret</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>Declares that the referred resource contains top secret information of military nature or other</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasTopSecret">http://purl.oclc.org/NET/ldr/ns#hasTopSecret</seealso>
    let hasTopSecret = Prefixed_Name(ldr, "hasTopSecret") |> PrefixedName
    /// <summary>
    ///   <para>ldr:issuedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date on which the rights expression is issued, with legal consequences on the copyright or database right expiration.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#issuedOn">http://purl.oclc.org/NET/ldr/ns#issuedOn</seealso>
    let issuedOn = Prefixed_Name(ldr, "issuedOn") |> PrefixedName
    /// <summary>
    ///   <para>ldr:judicialProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:CopyrightException</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>if the action is carried out for the purposes of an administrative or judicial procedure</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#judicialProcess">http://purl.oclc.org/NET/ldr/ns#judicialProcess</seealso>
    let judicialProcess = Prefixed_Name(ldr, "judicialProcess") |> PrefixedName
    /// <summary>
    ///   <para>ldr:nationalSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:CopyrightException</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>if the action is carried out in the interests of public security</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#nationalSecurity">http://purl.oclc.org/NET/ldr/ns#nationalSecurity</seealso>
    let nationalSecurity = Prefixed_Name(ldr, "nationalSecurity") |> PrefixedName
    /// <summary>
    ///   <para>ldr:isInPublicDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>Declares that the declared resource is in the public domain</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#isInPublicDomain">http://purl.oclc.org/NET/ldr/ns#isInPublicDomain</seealso>
    let isInPublicDomain = Prefixed_Name(ldr, "isInPublicDomain") |> PrefixedName
    /// <summary>
    ///   <para>ldr:Policy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#Policy">http://purl.oclc.org/NET/ldr/ns#Policy</seealso>
    let Policy = Prefixed_Name(ldr, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>ldr:mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Distribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The action of mirroring any piece of Linked Data</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#mirror">http://purl.oclc.org/NET/ldr/ns#mirror</seealso>
    let mirror = Prefixed_Name(ldr, "mirror") |> PrefixedName
    /// <summary>
    ///   <para>ldr:operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>May be set with one of the mathematical values AND, OR and XOR. (OR is the default if not specified.)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#operation">http://purl.oclc.org/NET/ldr/ns#operation</seealso>
    let operation = Prefixed_Name(ldr, "operation") |> PrefixedName
    /// <summary>
    ///   <para>ldr:protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Access protocol (e.g. "SPARQL", "HTTPS", etc.)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#protocol">http://purl.oclc.org/NET/ldr/ns#protocol</seealso>
    let protocol = Prefixed_Name(ldr, "protocol") |> PrefixedName
    /// <summary>
    ///   <para>ldr:publishDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Reutilization</para>
    ///   <para>Make available a database in internet or by other means</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#publishDatabase">http://purl.oclc.org/NET/ldr/ns#publishDatabase</seealso>
    let publishDatabase = Prefixed_Name(ldr, "publishDatabase") |> PrefixedName
    /// <summary>
    ///   <para>ldr:rebaseURIs</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Derivation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Partially change the URI systematically rebasing the entities</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#rebaseURIs">http://purl.oclc.org/NET/ldr/ns#rebaseURIs</seealso>
    let rebaseURIs = Prefixed_Name(ldr, "rebaseURIs") |> PrefixedName
    /// <summary>
    ///   <para>ldr:reificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Derivation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Reificate an RDF statement or a set thereof</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#reificate">http://purl.oclc.org/NET/ldr/ns#reificate</seealso>
    let reificate = Prefixed_Name(ldr, "reificate") |> PrefixedName
    /// <summary>
    ///   <para>ldr:research</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:CopyrightException</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>illustration for teaching or scientific research, provided the source, including the author's name, is acknowledged</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#research">http://purl.oclc.org/NET/ldr/ns#research</seealso>
    let research = Prefixed_Name(ldr, "research") |> PrefixedName
    /// <summary>
    ///   <para>ldr:transcodeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Derivation</para>
    ///   <para>Transcoding the work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#transcodeWork">http://purl.oclc.org/NET/ldr/ns#transcodeWork</seealso>
    let transcodeWork = Prefixed_Name(ldr, "transcodeWork") |> PrefixedName
    /// <summary>
    ///   <para>ldr:publicCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:PublicCommunication</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>General right of public communication</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#publicCommunication">http://purl.oclc.org/NET/ldr/ns#publicCommunication</seealso>
    let publicCommunication = Prefixed_Name(ldr, "publicCommunication") |> PrefixedName
    /// <summary>
    ///   <para>ldr:queriesPerDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of queries per day</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#queriesPerDay">http://purl.oclc.org/NET/ldr/ns#queriesPerDay</seealso>
    let queriesPerDay = Prefixed_Name(ldr, "queriesPerDay") |> PrefixedName
    /// <summary>
    ///   <para>ldr:queriesPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of queries per minute</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#queriesPerMinute">http://purl.oclc.org/NET/ldr/ns#queriesPerMinute</seealso>
    let queriesPerMinute = Prefixed_Name(ldr, "queriesPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>ldr:reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Reproduction</para>
    ///   <para>General right of public reproduction</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#reproduction">http://purl.oclc.org/NET/ldr/ns#reproduction</seealso>
    let reproduction = Prefixed_Name(ldr, "reproduction") |> PrefixedName
    /// <summary>
    ///   <para>ldr:sellAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Distribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Offering for meny the access to a copy of the work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#sellAccess">http://purl.oclc.org/NET/ldr/ns#sellAccess</seealso>
    let sellAccess = Prefixed_Name(ldr, "sellAccess") |> PrefixedName
    /// <summary>
    ///   <para>ldr:truthValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Truth value</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#truthValue">http://purl.oclc.org/NET/ldr/ns#truthValue</seealso>
    let truthValue = Prefixed_Name(ldr, "truthValue") |> PrefixedName
    /// <summary>
    ///   <para>ldr:reasonWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Access</para>
    ///   <para>Accesing Linked Data with the purpose of reasoning, through an specialized protocol (e.g. OWLLink) or not</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#reasonWith">http://purl.oclc.org/NET/ldr/ns#reasonWith</seealso>
    let reasonWith = Prefixed_Name(ldr, "reasonWith") |> PrefixedName
    /// <summary>
    ///   <para>ldr:rent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Distribution</para>
    ///   <para>Renting a copy of the work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#rent">http://purl.oclc.org/NET/ldr/ns#rent</seealso>
    let rent = Prefixed_Name(ldr, "rent") |> PrefixedName
    /// <summary>
    ///   <para>ldr:sell</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Distribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Selling a copy of the work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#sell">http://purl.oclc.org/NET/ldr/ns#sell</seealso>
    let sell = Prefixed_Name(ldr, "sell") |> PrefixedName
    /// <summary>
    ///   <para>ldr:translateWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ldr:Derivation</para>
    ///   <para>Translating the work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#translateWork">http://purl.oclc.org/NET/ldr/ns#translateWork</seealso>
    let translateWork = Prefixed_Name(ldr, "translateWork") |> PrefixedName
    /// <summary>
    ///   <para>ldr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Linked Data Rights</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#">http://purl.oclc.org/NET/ldr/ns#</seealso>
    let _prefix_iri = Prefixed_Name(ldr, "") |> PrefixedName
    /// <summary>
    ///   <para>ldr:RightsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>Deprecated in favour of ODRL</para>
    ///   <para>Object over which a right is execised</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#RightsObject">http://purl.oclc.org/NET/ldr/ns#RightsObject</seealso>
    let RightsObject = Prefixed_Name(ldr, "RightsObject") |> PrefixedName
    /// <summary>
    ///   <para>ldr:SPARQLCONSTRUCT</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:SPARQLAccess</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Access through the SPARQL CONSTRUCT query form</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#SPARQLCONSTRUCT">http://purl.oclc.org/NET/ldr/ns#SPARQLCONSTRUCT</seealso>
    let SPARQLCONSTRUCT = Prefixed_Name(ldr, "SPARQLCONSTRUCT") |> PrefixedName
    /// <summary>
    ///   <para>ldr:SPARQLSELECT</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:SPARQLAccess</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Access through the SPARQL SELECT query form</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#SPARQLSELECT">http://purl.oclc.org/NET/ldr/ns#SPARQLSELECT</seealso>
    let SPARQLSELECT = Prefixed_Name(ldr, "SPARQLSELECT") |> PrefixedName
    /// <summary>
    ///   <para>ldr:baseSoftwareUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Distribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Distribute a pice of software whose well functioning depends on the related Linked Data resource</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#baseSoftwareUpon">http://purl.oclc.org/NET/ldr/ns#baseSoftwareUpon</seealso>
    let baseSoftwareUpon = Prefixed_Name(ldr, "baseSoftwareUpon") |> PrefixedName
    /// <summary>
    ///   <para>ldr:copyDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Extraction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Coyping a dataset, for other purposes than private use</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#copyDatabase">http://purl.oclc.org/NET/ldr/ns#copyDatabase</seealso>
    let copyDatabase = Prefixed_Name(ldr, "copyDatabase") |> PrefixedName
    /// <summary>
    ///   <para>ldr:derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Derivation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>General transformation of the work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#derivation">http://purl.oclc.org/NET/ldr/ns#derivation</seealso>
    let derivation = Prefixed_Name(ldr, "derivation") |> PrefixedName
    /// <summary>
    ///   <para>ldr:distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:Distribution</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>General act of making available the original work or its copies, in a physical medium</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#distribution">http://purl.oclc.org/NET/ldr/ns#distribution</seealso>
    let distribution = Prefixed_Name(ldr, "distribution") |> PrefixedName

    /// <summary>
    ///   <para>ldr:hasAllRightsReserved</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Declares that the referred resource is protected under copyright or database rights, and none of them is waived</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasAllRightsReserved">http://purl.oclc.org/NET/ldr/ns#hasAllRightsReserved</seealso>
    let hasAllRightsReserved =
        Prefixed_Name(ldr, "hasAllRightsReserved") |> PrefixedName

    /// <summary>
    ///   <para>ldr:hasAttributionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text that has to be included as requested by a condition</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasAttributionText">http://purl.oclc.org/NET/ldr/ns#hasAttributionText</seealso>
    let hasAttributionText = Prefixed_Name(ldr, "hasAttributionText") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasCopyrightExpired</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Declares that the referred resource has its copyright expired</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightExpired">http://purl.oclc.org/NET/ldr/ns#hasCopyrightExpired</seealso>
    let hasCopyrightExpired = Prefixed_Name(ldr, "hasCopyrightExpired") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasCopyrightNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text that has to be attached imposed as a condition</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasCopyrightNotice">http://purl.oclc.org/NET/ldr/ns#hasCopyrightNotice</seealso>
    let hasCopyrightNotice = Prefixed_Name(ldr, "hasCopyrightNotice") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasExtendedRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Policy to an ExtendedRule it contains</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasExtendedRule">http://purl.oclc.org/NET/ldr/ns#hasExtendedRule</seealso>
    let hasExtendedRule = Prefixed_Name(ldr, "hasExtendedRule") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasIndustrialSecret</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The referred resource containts an Industrial Secret</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasIndustrialSecret">http://purl.oclc.org/NET/ldr/ns#hasIndustrialSecret</seealso>
    let hasIndustrialSecret = Prefixed_Name(ldr, "hasIndustrialSecret") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>ldr:ResourceLegalStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Declares that the referred resource has personal data</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasPersonalData">http://purl.oclc.org/NET/ldr/ns#hasPersonalData</seealso>
    let hasPersonalData = Prefixed_Name(ldr, "hasPersonalData") |> PrefixedName
    /// <summary>
    ///   <para>ldr:hasPrivacyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Declares the privacy level (e.g. personal data) for a Linked Data resource</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/ldr/ns#hasPrivacyLevel">http://purl.oclc.org/NET/ldr/ns#hasPrivacyLevel</seealso>
    let hasPrivacyLevel = Prefixed_Name(ldr, "hasPrivacyLevel") |> PrefixedName
