#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``eac-cpf`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/" "eac-cpf"

    /// <summary>
    ///   <para>rdfs:label : Biographical or Historical Note^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/biogHist">eac-cpf:biogHist</a>
    /// </summary>
    let biogHist = _prefixId.prefix "biogHist"
    /// <summary>
    ///   <para>rdfs:label : Control^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/control">eac-cpf:control</a>
    /// </summary>
    let control = _prefixId.prefix "control"
    /// <summary>
    ///   <para>rdfs:label : control area^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/controlArea">eac-cpf:controlArea</a>
    /// </summary>
    let controlArea = _prefixId.prefix "controlArea"
    /// <summary>
    ///   <para>rdfs:label : Convention Declaration^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/conventionDeclaration">eac-cpf:conventionDeclaration</a>
    /// </summary>
    let conventionDeclaration = _prefixId.prefix "conventionDeclaration"
    /// <summary>
    ///   <para>rdfs:label : corporate body^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/corporateBody">eac-cpf:corporateBody</a>
    /// </summary>
    let corporateBody = _prefixId.prefix "corporateBody"
    /// <summary>
    ///   <para>rdfs:label : Corporate Body, Person, or Family Relation^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelation">eac-cpf:cpfRelation</a>
    /// </summary>
    let cpfRelation = _prefixId.prefix "cpfRelation"
    /// <summary>
    ///   <para>rdfs:label : Corporate Body, Person, or Family Relation Type^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelationType">eac-cpf:cpfRelationType</a>
    /// </summary>
    let cpfRelationType = _prefixId.prefix "cpfRelationType"
    let dainserire = _prefixId.prefix "dainserire"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/description">eac-cpf:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : description area^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/descriptionArea">eac-cpf:descriptionArea</a>
    /// </summary>
    let descriptionArea = _prefixId.prefix "descriptionArea"
    let ``eac_cpf.rdf`` = _prefixId.prefix "eac-cpf.rdf"
    /// <summary>
    ///   <para>rdfs:label : entity^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/entity">eac-cpf:entity</a>
    /// </summary>
    let entity = _prefixId.prefix "entity"
    /// <summary>
    ///   <para>rdfs:label : Dates of Existence^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/existDates">eac-cpf:existDates</a>
    /// </summary>
    let existDates = _prefixId.prefix "existDates"
    /// <summary>
    ///   <para>rdfs:label : family^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/family">eac-cpf:family</a>
    /// </summary>
    let family = _prefixId.prefix "family"
    /// <summary>
    ///   <para>rdfs:label : Function^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/function">eac-cpf:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"
    /// <summary>
    ///   <para>rdfs:label : General Context^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/generalContext">eac-cpf:generalContext</a>
    /// </summary>
    let generalContext = _prefixId.prefix "generalContext"
    /// <summary>
    ///   <para>rdfs:label : Multiple Identities^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasMultipleIdentities">eac-cpf:hasMultipleIdentities</a>
    /// </summary>
    let hasMultipleIdentities = _prefixId.prefix "hasMultipleIdentities"
    /// <summary>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nella versione del 18 febbraio 2013^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasPlace">eac-cpf:hasPlace</a>
    /// </summary>
    let hasPlace = _prefixId.prefix "hasPlace"
    /// <summary>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/language">eac-cpf:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : Language Declaration^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageDeclaration">eac-cpf:languageDeclaration</a>
    /// </summary>
    let languageDeclaration = _prefixId.prefix "languageDeclaration"
    /// <summary>
    ///   <para>rdfs:label : Languages Used^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageUsed">eac-cpf:languageUsed</a>
    /// </summary>
    let languageUsed = _prefixId.prefix "languageUsed"
    /// <summary>
    ///   <para>rdfs:label : Legal Status^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/legalStatus">eac-cpf:legalStatus</a>
    /// </summary>
    let legalStatus = _prefixId.prefix "legalStatus"
    /// <summary>
    ///   <para>rdfs:label : Local Control^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localControl">eac-cpf:localControl</a>
    /// </summary>
    let localControl = _prefixId.prefix "localControl"
    /// <summary>
    ///   <para>rdfs:label : Local Type Declaration^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localTypeDeclaration">eac-cpf:localTypeDeclaration</a>
    /// </summary>
    let localTypeDeclaration = _prefixId.prefix "localTypeDeclaration"
    /// <summary>
    ///   <para>rdfs:label : Maintenance Agency^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceAgency">eac-cpf:maintenanceAgency</a>
    /// </summary>
    let maintenanceAgency = _prefixId.prefix "maintenanceAgency"
    /// <summary>
    ///   <para>rdfs:label : Maintenance History^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceHistory">eac-cpf:maintenanceHistory</a>
    /// </summary>
    let maintenanceHistory = _prefixId.prefix "maintenanceHistory"
    /// <summary>
    ///   <para>rdfs:label : Maintenance Status^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceStatus">eac-cpf:maintenanceStatus</a>
    /// </summary>
    let maintenanceStatus = _prefixId.prefix "maintenanceStatus"
    /// <summary>
    ///   <para>rdfs:label : Mandate^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/mandate">eac-cpf:mandate</a>
    /// </summary>
    let mandate = _prefixId.prefix "mandate"
    /// <summary>
    ///   <para>rdfs:label : name area^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameArea">eac-cpf:nameArea</a>
    /// </summary>
    let nameArea = _prefixId.prefix "nameArea"
    /// <summary>
    ///   <para>rdfs:label : Name Entry^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameEntry">eac-cpf:nameEntry</a>
    /// </summary>
    let nameEntry = _prefixId.prefix "nameEntry"
    /// <summary>
    ///   <para>rdfs:label : Occupation^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/occupation">eac-cpf:occupation</a>
    /// </summary>
    let occupation = _prefixId.prefix "occupation"
    /// <summary>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/person">eac-cpf:person</a>
    /// </summary>
    let person = _prefixId.prefix "person"
    /// <summary>
    ///   <para>rdfs:label : place^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/place">eac-cpf:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>rdfs:label : Place Role^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nella versione del 18 febbraio 2013^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/placeRole">eac-cpf:placeRole</a>
    /// </summary>
    let placeRole = _prefixId.prefix "placeRole"
    /// <summary>
    ///   <para>rdfs:label : Publication Status^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/publicationStatus">eac-cpf:publicationStatus</a>
    /// </summary>
    let publicationStatus = _prefixId.prefix "publicationStatus"
    /// <summary>
    ///   <para>rdfs:label : Record Identifier^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/recordID">eac-cpf:recordID</a>
    /// </summary>
    let recordID = _prefixId.prefix "recordID"
    /// <summary>
    ///   <para>rdfs:label : relation^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/relation">eac-cpf:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:label : Resource Relation^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelation">eac-cpf:resourceRelation</a>
    /// </summary>
    let resourceRelation = _prefixId.prefix "resourceRelation"
    /// <summary>
    ///   <para>rdfs:label : Resource Relation Type^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelationType">eac-cpf:resourceRelationType</a>
    /// </summary>
    let resourceRelationType = _prefixId.prefix "resourceRelationType"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/source">eac-cpf:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : Structure or Genealogy^^xsd:string</para>
    ///   <a href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/structureOrGenealogy">eac-cpf:structureOrGenealogy</a>
    /// </summary>
    let structureOrGenealogy = _prefixId.prefix "structureOrGenealogy"
