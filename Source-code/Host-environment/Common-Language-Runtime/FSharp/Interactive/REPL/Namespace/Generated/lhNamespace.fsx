#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lh =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/legalhtml/ov#" "lh"
    /// <summary>
    ///   <para>skos:definition : A modification affecting a legal resource</para>
    ///   <para>rdfs:label : change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Change">lh:Change</a>
    /// </summary>
    let Change = _prefixId.prefix "Change"
    /// <summary>
    ///   <para>skos:definition : A collection of related modifications to a legal resource (e.g. originating from the same amendment)</para>
    ///   <para>rdfs:label : change set</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ChangeSet">lh:ChangeSet</a>
    /// </summary>
    let ChangeSet = _prefixId.prefix "ChangeSet"
    /// <summary>
    ///   <para>skos:definition : A consolidated legal resource accounting for subsequent amendments</para>
    ///   <para>rdfs:label : consolidated resource</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ConsolidatedResource">lh:ConsolidatedResource</a>
    /// </summary>
    let ConsolidatedResource = _prefixId.prefix "ConsolidatedResource"
    /// <summary>
    ///   <para>skos:definition : A modification in the efficacy of a legal resource</para>
    ///   <para>rdfs:label : efficacy change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#EfficacyChange">lh:EfficacyChange</a>
    /// </summary>
    let EfficacyChange = _prefixId.prefix "EfficacyChange"
    /// <summary>
    ///   <para>rdfs:label : end of efficacy</para>
    ///   <a href="https://w3id.org/legalhtml/ov#EndOfEfficacy">lh:EndOfEfficacy</a>
    /// </summary>
    let EndOfEfficacy = _prefixId.prefix "EndOfEfficacy"
    /// <summary>
    ///   <para>rdfs:label : end of enactment</para>
    ///   <a href="https://w3id.org/legalhtml/ov#EndOfEnactment">lh:EndOfEnactment</a>
    /// </summary>
    let EndOfEnactment = _prefixId.prefix "EndOfEnactment"
    /// <summary>
    ///   <para>rdfs:label : entry into efficacy</para>
    ///   <a href="https://w3id.org/legalhtml/ov#EntryIntoEfficacy">lh:EntryIntoEfficacy</a>
    /// </summary>
    let EntryIntoEfficacy = _prefixId.prefix "EntryIntoEfficacy"
    /// <summary>
    ///   <para>rdfs:label : entry into force</para>
    ///   <a href="https://w3id.org/legalhtml/ov#EntryIntoForce">lh:EntryIntoForce</a>
    /// </summary>
    let EntryIntoForce = _prefixId.prefix "EntryIntoForce"
    /// <summary>
    ///   <para>rdfs:label : extraefficacy</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Extraefficacy">lh:Extraefficacy</a>
    /// </summary>
    let Extraefficacy = _prefixId.prefix "Extraefficacy"
    /// <summary>
    ///   <para>skos:definition : A modification in the force of a legal resource</para>
    ///   <para>rdfs:label : force change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ForceChange">lh:ForceChange</a>
    /// </summary>
    let ForceChange = _prefixId.prefix "ForceChange"
    /// <summary>
    ///   <para>rdfs:label : inapplication</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Inapplication">lh:Inapplication</a>
    /// </summary>
    let Inapplication = _prefixId.prefix "Inapplication"
    /// <summary>
    ///   <para>skos:definition : An insertion of text into a legal resource</para>
    ///   <para>rdfs:label : insertion</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Insertion">lh:Insertion</a>
    /// </summary>
    let Insertion = _prefixId.prefix "Insertion"
    /// <summary>
    ///   <para>skos:definition : An assembly that is empowered to legislate for a political entity such as a country or city</para>
    ///   <para>rdfs:label : legislature</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Legislature">lh:Legislature</a>
    /// </summary>
    let Legislature = _prefixId.prefix "Legislature"
    /// <summary>
    ///   <para>rdfs:label : postponement of efficacy</para>
    ///   <a href="https://w3id.org/legalhtml/ov#PostponementOfEfficacy">lh:PostponementOfEfficacy</a>
    /// </summary>
    let PostponementOfEfficacy = _prefixId.prefix "PostponementOfEfficacy"
    /// <summary>
    ///   <para>rdfs:label : postponement of entry into force</para>
    ///   <a href="https://w3id.org/legalhtml/ov#PostponementOfEntryIntoForce">lh:PostponementOfEntryIntoForce</a>
    /// </summary>
    let PostponementOfEntryIntoForce = _prefixId.prefix "PostponementOfEntryIntoForce"
    /// <summary>
    ///   <para>skos:definition : A stage of a procedure</para>
    ///   <para>rdfs:label : procedure stage</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ProcedureStage">lh:ProcedureStage</a>
    /// </summary>
    let ProcedureStage = _prefixId.prefix "ProcedureStage"
    /// <summary>
    ///   <para>rdfs:label : prorogation of efficacy</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ProrogationOfEfficacy">lh:ProrogationOfEfficacy</a>
    /// </summary>
    let ProrogationOfEfficacy = _prefixId.prefix "ProrogationOfEfficacy"
    /// <summary>
    ///   <para>rdfs:label : prorogation of force</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ProrogationOfForce">lh:ProrogationOfForce</a>
    /// </summary>
    let ProrogationOfForce = _prefixId.prefix "ProrogationOfForce"
    /// <summary>
    ///   <para>rdfs:label : re-enactment</para>
    ///   <a href="https://w3id.org/legalhtml/ov#ReEnactment">lh:ReEnactment</a>
    /// </summary>
    let ReEnactment = _prefixId.prefix "ReEnactment"
    /// <summary>
    ///   <para>skos:definition : A deletion of text from a legal resource</para>
    ///   <para>rdfs:label : repeal</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Repeal">lh:Repeal</a>
    /// </summary>
    let Repeal = _prefixId.prefix "Repeal"
    /// <summary>
    ///   <para>rdfs:label : retroactivity</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Retroactivity">lh:Retroactivity</a>
    /// </summary>
    let Retroactivity = _prefixId.prefix "Retroactivity"
    /// <summary>
    ///   <para>skos:definition : A role within an organization</para>
    ///   <para>rdfs:label : role</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Role">lh:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>skos:definition : A signature on a legal resource made by someone in some organization with certain role</para>
    ///   <para>rdfs:label : signature</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Signature">lh:Signature</a>
    /// </summary>
    let Signature = _prefixId.prefix "Signature"
    /// <summary>
    ///   <para>skos:definition : A status of a file, document, etc.^^xsd:string</para>
    ///   <para>rdfs:label : status</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Status">lh:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>skos:definition : A substitution of text inside a legal resource</para>
    ///   <para>rdfs:label : substitution</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Substitution">lh:Substitution</a>
    /// </summary>
    let Substitution = _prefixId.prefix "Substitution"
    /// <summary>
    ///   <para>skos:definition : A textual modificaiton to a legal resource</para>
    ///   <para>rdfs:label : textual change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#TextualChange">lh:TextualChange</a>
    /// </summary>
    let TextualChange = _prefixId.prefix "TextualChange"
    /// <summary>
    ///   <para>rdfs:label : uncostitutionality</para>
    ///   <a href="https://w3id.org/legalhtml/ov#Unconstitutionality">lh:Unconstitutionality</a>
    /// </summary>
    let Unconstitutionality = _prefixId.prefix "Unconstitutionality"
    /// <summary>
    ///   <para>skos:definition : Each of the acting entities of a legal resource</para>
    ///   <para>rdfs:label : acting entity</para>
    ///   <a href="https://w3id.org/legalhtml/ov#actingEntity">lh:actingEntity</a>
    /// </summary>
    let actingEntity = _prefixId.prefix "actingEntity"
    /// <summary>
    ///   <para>skos:definition : Technical reference to the inserted text</para>
    ///   <para>rdfs:label : addendum</para>
    ///   <a href="https://w3id.org/legalhtml/ov#addendum">lh:addendum</a>
    /// </summary>
    let addendum = _prefixId.prefix "addendum"
    /// <summary>
    ///   <para>skos:definition : A person or entity to which a legal resource is addressed</para>
    ///   <para>rdfs:label : addressee</para>
    ///   <a href="https://w3id.org/legalhtml/ov#addressee">lh:addressee</a>
    /// </summary>
    let addressee = _prefixId.prefix "addressee"
    /// <summary>
    ///   <para>skos:definition : Reference to the part of the act that is being modified</para>
    ///   <para>rdfs:label : amended text</para>
    ///   <a href="https://w3id.org/legalhtml/ov#amendedText">lh:amendedText</a>
    /// </summary>
    let amendedText = _prefixId.prefix "amendedText"
    /// <summary>
    ///   <para>skos:definition : Reference to the part of the amending act that specifies the modification being done</para>
    ///   <para>rdfs:label : amending text</para>
    ///   <a href="https://w3id.org/legalhtml/ov#amendingText">lh:amendingText</a>
    /// </summary>
    let amendingText = _prefixId.prefix "amendingText"
    /// <summary>
    ///   <para>skos:definition : Reference to an entity directly bound by the application of a legal resource</para>
    ///   <para>rdfs:label : applicability</para>
    ///   <a href="https://w3id.org/legalhtml/ov#applicability">lh:applicability</a>
    /// </summary>
    let applicability = _prefixId.prefix "applicability"
    /// <summary>
    ///   <para>skos:definition : Reference to a change in a change set</para>
    ///   <para>rdfs:label : change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#change">lh:change</a>
    /// </summary>
    let change = _prefixId.prefix "change"
    /// <summary>
    ///   <para>skos:definition : Reference to a change set being consolidated by a consolidated resource</para>
    ///   <para>rdfs:label : change set</para>
    ///   <a href="https://w3id.org/legalhtml/ov#changeSet">lh:changeSet</a>
    /// </summary>
    let changeSet = _prefixId.prefix "changeSet"
    /// <summary>
    ///   <para>skos:definition : the act making the modification</para>
    ///   <para>rdfs:label : changing act</para>
    ///   <a href="https://w3id.org/legalhtml/ov#changingAct">lh:changingAct</a>
    /// </summary>
    let changingAct = _prefixId.prefix "changingAct"
    /// <summary>
    ///   <para>skos:definition : Technical reference to the deleted text</para>
    ///   <para>rdfs:label : deletion</para>
    ///   <a href="https://w3id.org/legalhtml/ov#deletion">lh:deletion</a>
    /// </summary>
    let deletion = _prefixId.prefix "deletion"
    /// <summary>
    ///   <para>skos:definition : The date of first entry into force</para>
    ///   <para>rdfs:label : entry into force</para>
    ///   <a href="https://w3id.org/legalhtml/ov#entryIntoForce">lh:entryIntoForce</a>
    /// </summary>
    let entryIntoForce = _prefixId.prefix "entryIntoForce"
    /// <summary>
    ///   <para>skos:definition : Reference to a force change</para>
    ///   <para>rdfs:label : force change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#forceChange">lh:forceChange</a>
    /// </summary>
    let forceChange = _prefixId.prefix "forceChange"
    /// <summary>
    ///   <para>skos:definition : An entity responsible for originating a legal resource</para>
    ///   <para>rdfs:label : issuer</para>
    ///   <a href="https://w3id.org/legalhtml/ov#issuer">lh:issuer</a>
    /// </summary>
    let issuer = _prefixId.prefix "issuer"
    /// <summary>
    ///   <para>skos:definition : Reference to the legislature responsible for originating a legal resource</para>
    ///   <para>rdfs:label : legislature</para>
    ///   <a href="https://w3id.org/legalhtml/ov#legislature">lh:legislature</a>
    /// </summary>
    let legislature = _prefixId.prefix "legislature"
    /// <summary>
    ///   <para>skos:definition : The language in which a legal resource has been originally drafted</para>
    ///   <para>rdfs:label : original language</para>
    ///   <a href="https://w3id.org/legalhtml/ov#originalLanguage">lh:originalLanguage</a>
    /// </summary>
    let originalLanguage = _prefixId.prefix "originalLanguage"
    /// <summary>
    ///   <para>skos:definition : Unique reference for a procedure</para>
    ///   <para>rdfs:label : procedure identifier</para>
    ///   <a href="https://w3id.org/legalhtml/ov#procedureID">lh:procedureID</a>
    /// </summary>
    let procedureID = _prefixId.prefix "procedureID"
    /// <summary>
    ///   <para>skos:definition : Reference to the stage of a procedure</para>
    ///   <para>rdfs:label : procedure stage</para>
    ///   <a href="https://w3id.org/legalhtml/ov#procedureStage">lh:procedureStage</a>
    /// </summary>
    let procedureStage = _prefixId.prefix "procedureStage"
    /// <summary>
    ///   <para>skos:definition : An entity responsible for the proposal</para>
    ///   <para>rdfs:label : proposing entity</para>
    ///   <a href="https://w3id.org/legalhtml/ov#proposingEntity">lh:proposingEntity</a>
    /// </summary>
    let proposingEntity = _prefixId.prefix "proposingEntity"
    /// <summary>
    ///   <para>skos:definition : The date of publication</para>
    ///   <para>rdfs:label : published</para>
    ///   <a href="https://w3id.org/legalhtml/ov#published">lh:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>skos:definition : An identifier assigned to a legal resource by an entity</para>
    ///   <para>rdfs:label : reference</para>
    ///   <a href="https://w3id.org/legalhtml/ov#reference">lh:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    /// <summary>
    ///   <para>skos:definition : An entity governed by legal acts relevant for a legal resource</para>
    ///   <para>rdfs:label : relevance</para>
    ///   <a href="https://w3id.org/legalhtml/ov#relevance">lh:relevance</a>
    /// </summary>
    let relevance = _prefixId.prefix "relevance"
    /// <summary>
    ///   <para>skos:definition : Technical reference to the replaced text</para>
    ///   <para>rdfs:label : replaced content</para>
    ///   <a href="https://w3id.org/legalhtml/ov#replacedContent">lh:replacedContent</a>
    /// </summary>
    let replacedContent = _prefixId.prefix "replacedContent"
    /// <summary>
    ///   <para>skos:definition : Technical reference to the replacement text</para>
    ///   <para>rdfs:label : replacement</para>
    ///   <a href="https://w3id.org/legalhtml/ov#replacement">lh:replacement</a>
    /// </summary>
    let replacement = _prefixId.prefix "replacement"
    /// <summary>
    ///   <para>skos:definition : The person who affixed the signature</para>
    ///   <para>rdfs:label : signatory</para>
    ///   <a href="https://w3id.org/legalhtml/ov#signatory">lh:signatory</a>
    /// </summary>
    let signatory = _prefixId.prefix "signatory"
    /// <summary>
    ///   <para>skos:definition : The organization on behalf of which the signatory affixed a signature on a legal resource</para>
    ///   <para>rdfs:label : signatory organization</para>
    ///   <a href="https://w3id.org/legalhtml/ov#signatoryOrganization">lh:signatoryOrganization</a>
    /// </summary>
    let signatoryOrganization = _prefixId.prefix "signatoryOrganization"
    /// <summary>
    ///   <para>skos:definition : The role played within an organization by someones who affixed a signature on a legal resource on behalf of it</para>
    ///   <para>rdfs:label : signatory role</para>
    ///   <a href="https://w3id.org/legalhtml/ov#signatoryRole">lh:signatoryRole</a>
    /// </summary>
    let signatoryRole = _prefixId.prefix "signatoryRole"
    /// <summary>
    ///   <para>skos:definition : Reference to a signature on a legal resource</para>
    ///   <para>rdfs:label : signature</para>
    ///   <a href="https://w3id.org/legalhtml/ov#signature">lh:signature</a>
    /// </summary>
    let signature = _prefixId.prefix "signature"
    /// <summary>
    ///   <para>skos:definition : The signature date of a legal resource</para>
    ///   <para>rdfs:label : signature date</para>
    ///   <a href="https://w3id.org/legalhtml/ov#signatureDate">lh:signatureDate</a>
    /// </summary>
    let signatureDate = _prefixId.prefix "signatureDate"
    /// <summary>
    ///   <para>skos:definition : The signature place of a legal resource</para>
    ///   <para>rdfs:label : signature place</para>
    ///   <a href="https://w3id.org/legalhtml/ov#signaturePlace">lh:signaturePlace</a>
    /// </summary>
    let signaturePlace = _prefixId.prefix "signaturePlace"
    /// <summary>
    ///   <para>skos:definition : The date of first applicability</para>
    ///   <para>rdfs:label : start of applicability</para>
    ///   <a href="https://w3id.org/legalhtml/ov#startOfApplicability">lh:startOfApplicability</a>
    /// </summary>
    let startOfApplicability = _prefixId.prefix "startOfApplicability"
    /// <summary>
    ///   <para>skos:definition : The status of a language resource</para>
    ///   <para>rdfs:label : status</para>
    ///   <a href="https://w3id.org/legalhtml/ov#status">lh:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>skos:definition : Reference to a textual change</para>
    ///   <para>rdfs:label : textual change</para>
    ///   <a href="https://w3id.org/legalhtml/ov#textualChange">lh:textualChange</a>
    /// </summary>
    let textualChange = _prefixId.prefix "textualChange"
