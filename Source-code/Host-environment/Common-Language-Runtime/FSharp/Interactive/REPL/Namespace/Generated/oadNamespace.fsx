#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oad =
    let _prefixId = PrefixId.fromNamespaceLabel "http://culturalis.org/oad#" "oad"
    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : Administrative / Biographical historyrdfs:label : Storia istituzionale/ amministrativa o biografia</para>
    ///   <para>rdfs:comment : The class represents the administrative and biographical history.rdfs:comment : La classe rappresenta le informazioni relative alla storia istituzionale, amministrativa o biografica</para>
    ///   <a href="http://culturalis.org/oad#AdministrativeBiographicalHistory">oad:AdministrativeBiographicalHistory</a>
    /// </summary>
    let AdministrativeBiographicalHistory =
        _prefixId.prefix "AdministrativeBiographicalHistory"

    /// <summary>
    ///   <para>rdfs:label : Archival resourcerdfs:label : Risorsa archivistica</para>
    ///   <para>owl:versionInfo : Questa classe è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : oad:ArchivalResource is the class that represents the object of the description (i.e., a single document or a set of document).rdfs:comment : La classe Archival resource indica un corpus documentale oggetto di descrizione</para>
    ///   <a href="http://culturalis.org/oad#ArchivalResource">oad:ArchivalResource</a>
    /// </summary>
    let ArchivalResource = _prefixId.prefix "ArchivalResource"
    let Custody = _prefixId.prefix "Custody"
    /// <summary>
    ///   <para>rdfs:label : EAD Schema's element or attributerdfs:label : Elemento o attributo dello Schema EAD</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>rdfs:comment : La classe è utilizzata per mappare le classi e le proprietà dell'ontologia OAD con gli elementi dello schema EAD</para>
    ///   <a href="http://culturalis.org/oad#EadElement">oad:EadElement</a>
    /// </summary>
    let EadElement = _prefixId.prefix "EadElement"
    /// <summary>
    ///   <para>rdfs:label : Extent and mediumrdfs:label : Consistenza e supporto</para>
    ///   <para>owl:versionInfo : Questa classe è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The class represents the description about extent and medium.rdfs:comment : La classe Extent and medium rappresenta la descrizione dell'estensione e del supporto</para>
    ///   <a href="http://culturalis.org/oad#ExtentAndMedium">oad:ExtentAndMedium</a>
    /// </summary>
    let ExtentAndMedium = _prefixId.prefix "ExtentAndMedium"
    /// <summary>
    ///   <para>rdfs:label : Finding aidrdfs:label : Strumento di ricerca</para>
    ///   <para>rdfs:comment : The class represents a finding aid.rdfs:comment : La classe rappresenta lo strumento di ricerca</para>
    ///   <a href="http://culturalis.org/oad#FindingAid">oad:FindingAid</a>
    /// </summary>
    let FindingAid = _prefixId.prefix "FindingAid"
    /// <summary>
    ///   <para>rdfs:label : Archival instancerdfs:label : Instanza archivistica</para>
    ///   <para>owl:versionInfo : Questa classe è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The class represents the descriptive entry of an archival resourcerdfs:comment : La classe Archival instance rappresenta l'istanziazione dell'archival resource</para>
    ///   <a href="http://culturalis.org/oad#Instance">oad:Instance</a>
    /// </summary>
    let Instance = _prefixId.prefix "Instance"
    /// <summary>
    ///   <para>rdfs:label : Level of descriptionrdfs:label : Livello di descrizione</para>
    ///   <para>rdfs:comment : The class represents the archival description levelrdfs:comment : La classe rappresenta il livello della descrizione archivistica</para>
    ///   <a href="http://culturalis.org/oad#LevelOfDescription">oad:LevelOfDescription</a>
    /// </summary>
    let LevelOfDescription = _prefixId.prefix "LevelOfDescription"
    /// <summary>
    ///   <para>rdfs:label : Placerdfs:label : Luogo</para>
    ///   <para>rdfs:comment : The class represents a physical placerdfs:comment : La classe rappresenta un luogo</para>
    ///   <a href="http://culturalis.org/oad#Place">oad:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    let Production = _prefixId.prefix "Production"
    /// <summary>
    ///   <para>rdfs:label : Publication noterdfs:label : Bibliografia</para>
    ///   <para>rdfs:comment : The class represents a bibliographyrdfs:comment : La classe rappresenta la bibliografia</para>
    ///   <a href="http://culturalis.org/oad#PublicationNote">oad:PublicationNote</a>
    /// </summary>
    let PublicationNote = _prefixId.prefix "PublicationNote"
    /// <summary>
    ///   <para>rdfs:label : Unit of descriptionrdfs:label : Unità of descrizione</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>rdfs:comment : La classe uod rappresenta la descrizione della risorsa archivistica</para>
    ///   <a href="http://culturalis.org/oad#UoD">oad:UoD</a>
    /// </summary>
    let UoD = _prefixId.prefix "UoD"
    /// <summary>
    ///   <para>rdfs:label : Accrualsrdfs:label : Incrementi previsti</para>
    ///   <para>rdfs:comment : The property represents expected increase.rdfs:comment : La proprietà rappresenta le informazioni relative agli incrementi previsti.</para>
    ///   <a href="http://culturalis.org/oad#accruals">oad:accruals</a>
    /// </summary>
    let accruals = _prefixId.prefix "accruals"

    /// <summary>
    ///   <para>rdfs:label : Appraisal, destruction and scheduling informationrdfs:label : Procedure, tempi e criteri di valutazione e scarto</para>
    ///   <para>rdfs:comment : The property represents appraisal, destruction and scheduling informationrdfs:comment : La proprietà rappresenta le informazioni relative alle procedure, ai tempi e ai criteri di valutazione e scarto della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#appraisalDestructionAndSchedulingInformation">oad:appraisalDestructionAndSchedulingInformation</a>
    /// </summary>
    let appraisalDestructionAndSchedulingInformation =
        _prefixId.prefix "appraisalDestructionAndSchedulingInformation"

    /// <summary>
    ///   <para>rdfs:label : Archival historyrdfs:label : Storia archivistica</para>
    ///   <para>rdfs:comment : The property represents information about the history of the instancerdfs:comment : La proprietà rappresenta le informazioni relative alla storia archivistica della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#archivalHistory">oad:archivalHistory</a>
    /// </summary>
    let archivalHistory = _prefixId.prefix "archivalHistory"
    /// <summary>
    ///   <para>rdfs:label : Archivist's Noterdfs:label : Nota dell'archivista</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>rdfs:comment : La proprietà rappresenta le informazioni relative alle note dell'archivista della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#archivistsNote">oad:archivistsNote</a>
    /// </summary>
    let archivistsNote = _prefixId.prefix "archivistsNote"
    /// <summary>
    ///   <para>rdfs:label : Conditions governing accessrdfs:label : Condizioni che regolano l’accesso</para>
    ///   <para>rdfs:comment : The property represents condition governing access of the instancerdfs:comment : La proprietà rappresenta le informazioni relative alle condizioni che regolano l'accesso della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#conditionsGoverningAccess">oad:conditionsGoverningAccess</a>
    /// </summary>
    let conditionsGoverningAccess = _prefixId.prefix "conditionsGoverningAccess"

    /// <summary>
    ///   <para>rdfs:label : Conditions governing reproductionrdfs:label : Condizioni che regolano la riproduzione</para>
    ///   <para>rdfs:comment : The property represents condition governing reproduction of the instancerdfs:comment : La proprietà rappresenta le informazioni relative alle condizioni che regolano la riproduzione della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#conditionsGoverningReproduction">oad:conditionsGoverningReproduction</a>
    /// </summary>
    let conditionsGoverningReproduction =
        _prefixId.prefix "conditionsGoverningReproduction"

    /// <summary>
    ///   <para>rdfs:label : Containsrdfs:label : Contiene</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse property of oad:isContainedInrdfs:comment : Proprietà inversa di 'isContainedIn'.</para>
    ///   <a href="http://culturalis.org/oad#contains">oad:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : Custodyrdfs:label : Conservazione</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>dce:description : Le classi production e custody sono state inserite per descrivere il rapporto tra una risorsa archivistica e una entità (CPF), volendo esplicitare anche le date di relazione verso un soggetto produttore o un conservatore, gestendo in questo modo ad esempio anche i cambi di custodia</para>
    ///   <a href="http://culturalis.org/oad#custody">oad:custody</a>
    /// </summary>
    let custody = _prefixId.prefix "custody"
    /// <summary>
    ///   <para>rdfs:label : Date(s)rdfs:label : Data/e</para>
    ///   <para>rdfs:comment : The property represents a daterdfs:comment : La proprietà rappresenta le informazioni relative alla datazione della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#date">oad:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : La proprietà collega uno strumento di ricerca alla risorsa archivistica descrittardfs:comment : This functional property links a finding aid to the archival resource described</para>
    ///   <para>rdfs:label : Descriverdfs:label : Describes</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <a href="http://culturalis.org/oad#describes">oad:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : Existence and location of copiesrdfs:label : Esistenza e localizzazione di copie</para>
    ///   <para>rdfs:comment : The property represents the existence and location of copiesrdfs:comment : La proprietà rappresenta le informazioni relative all'esistenza e alla localizzazione di copie della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#existenceAndLocationOfCopies">oad:existenceAndLocationOfCopies</a>
    /// </summary>
    let existenceAndLocationOfCopies = _prefixId.prefix "existenceAndLocationOfCopies"

    /// <summary>
    ///   <para>rdfs:label : Existence and location of originalsrdfs:label : Esistenza e localizzazione degli originali</para>
    ///   <para>rdfs:comment : The property represents the existence and location of originalsrdfs:comment : La proprietà rappresenta le informazioni relative all'esistenza e alla localizzazione degli originali della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#existenceAndLocationOfOriginals">oad:existenceAndLocationOfOriginals</a>
    /// </summary>
    let existenceAndLocationOfOriginals =
        _prefixId.prefix "existenceAndLocationOfOriginals"

    /// <summary>
    ///   <para>rdfs:label : Extent and medium of the unit of description (quantity, bulk, or size)rdfs:label : Consistenza e supporto dell'unità di descrizione</para>
    ///   <para>dce:description : Le informazioni sottoforma di stringa di testo sulla consistenza vengono descritte attraverso la proprietà dc:format^^xsd:string</para>
    ///   <para>rdfs:comment : La proprietà rappresenta le informazioni relative alla consistenza e al supporto della risorsa archivistica descritta</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#extentAndMedium">oad:extentAndMedium</a>
    /// </summary>
    let extentAndMedium = _prefixId.prefix "extentAndMedium"
    /// <summary>
    ///   <para>rdfs:label : Has key access pointrdfs:label : Ha chiave di indice</para>
    ///   <para>rdfs:comment : The property represents an access pointrdfs:comment : La proprietà rappresenta le informazioni relative alle chiavi di accesso</para>
    ///   <a href="http://culturalis.org/oad#hasAccessPoint">oad:hasAccessPoint</a>
    /// </summary>
    let hasAccessPoint = _prefixId.prefix "hasAccessPoint"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasAccessPointCorporateBody">oad:hasAccessPointCorporateBody</a>
    /// </summary>
    let hasAccessPointCorporateBody = _prefixId.prefix "hasAccessPointCorporateBody"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasAccessPointFamily">oad:hasAccessPointFamily</a>
    /// </summary>
    let hasAccessPointFamily = _prefixId.prefix "hasAccessPointFamily"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasAccessPointPerson">oad:hasAccessPointPerson</a>
    /// </summary>
    let hasAccessPointPerson = _prefixId.prefix "hasAccessPointPerson"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasAccessPointPlace">oad:hasAccessPointPlace</a>
    /// </summary>
    let hasAccessPointPlace = _prefixId.prefix "hasAccessPointPlace"

    /// <summary>
    ///   <para>rdfs:label : Has administrative / biographical historyrdfs:label : Ha storia amministrativa / biografica</para>
    ///   <para>rdfs:comment : The property links and instace to information about administrative and biographica history.rdfs:comment : La proprietà collega una scheda descrittiva alle informazioni relative alla storia amministrativa o biografica</para>
    ///   <a href="http://culturalis.org/oad#hasAdministrativeBiographicalHistory">oad:hasAdministrativeBiographicalHistory</a>
    /// </summary>
    let hasAdministrativeBiographicalHistory =
        _prefixId.prefix "hasAdministrativeBiographicalHistory"

    /// <summary>
    ///   <para>rdfs:label : Has Custodyrdfs:label : Conservato da</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasCustody">oad:hasCustody</a>
    /// </summary>
    let hasCustody = _prefixId.prefix "hasCustody"
    /// <summary>
    ///   <para>rdfs:label : Has Entityrdfs:label : Entità collegata</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasEntity">oad:hasEntity</a>
    /// </summary>
    let hasEntity = _prefixId.prefix "hasEntity"
    /// <summary>
    ///   <para>rdfs:label : Has entryrdfs:label : Ha scheda descrittiva</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : Proprietà inversa di 'isEntryOf'.</para>
    ///   <a href="http://culturalis.org/oad#hasEntry">oad:hasEntry</a>
    /// </summary>
    let hasEntry = _prefixId.prefix "hasEntry"
    /// <summary>
    ///   <para>rdfs:label : Has extent and mediumrdfs:label : Ha estensione e supporto</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The property links an instance to information about extent and mediumrdfs:comment : La proprietà collega l'istanziazione di una risorsa archivistica alle informazioni relative all'estensione e al supporto</para>
    ///   <a href="http://culturalis.org/oad#hasExtentAndMedium">oad:hasExtentAndMedium</a>
    /// </summary>
    let hasExtentAndMedium = _prefixId.prefix "hasExtentAndMedium"
    /// <summary>
    ///   <para>rdfs:label : Has extent typerdfs:label : Ha tipo di estensione</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The property represents an extent type and it is related to a skos vocabularyrdfs:comment : La proprietà rappresenta le informazioni relative alla tipologia di estensione e punta ad un vocabolario skos</para>
    ///   <a href="http://culturalis.org/oad#hasExtentType">oad:hasExtentType</a>
    /// </summary>
    let hasExtentType = _prefixId.prefix "hasExtentType"
    /// <summary>
    ///   <para>rdfs:label : File Planrdfs:label : Sistema di classificazione</para>
    ///   <para>rdfs:comment : The property links an instance to a classification systemrdfs:comment : La proprietà collega una archival instance ad un sistema di classificazione</para>
    ///   <a href="http://culturalis.org/oad#hasFilePlan">oad:hasFilePlan</a>
    /// </summary>
    let hasFilePlan = _prefixId.prefix "hasFilePlan"
    /// <summary>
    ///   <para>rdfs:label : Has finding aidrdfs:label : Ha strumento di ricerca</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>rdfs:comment : La proprietà collega una archival instance allo strumento di ricerca che la contiene</para>
    ///   <a href="http://culturalis.org/oad#hasFindingAid">oad:hasFindingAid</a>
    /// </summary>
    let hasFindingAid = _prefixId.prefix "hasFindingAid"
    /// <summary>
    ///   <para>rdfs:label : Has language/scripts of materialrdfs:label : Ha lingua/scrittura della documentazione</para>
    ///   <para>rdfs:comment : The property links an instance to its language informationrdfs:comment : La proprietà collega una archival instance alle informazioni relative alla lingua</para>
    ///   <a href="http://culturalis.org/oad#hasLanguageScriptsOfMaterial">oad:hasLanguageScriptsOfMaterial</a>
    /// </summary>
    let hasLanguageScriptsOfMaterial = _prefixId.prefix "hasLanguageScriptsOfMaterial"
    /// <summary>
    ///   <para>rdfs:label : Has level of descriptionrdfs:label : Ha livello di descrizione</para>
    ///   <para>rdfs:comment : The property links an archival resource to its level of descriptionrdfs:comment : La proprietà collega una unità di descrizione al livello di descrizione archivistica</para>
    ///   <a href="http://culturalis.org/oad#hasLevel">oad:hasLevel</a>
    /// </summary>
    let hasLevel = _prefixId.prefix "hasLevel"
    /// <summary>
    ///   <para>rdfs:label : Name of creator(s)rdfs:label : Nome del soggetto produttore</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://culturalis.org/oad#hasNameOfCreator">oad:hasNameOfCreator</a>
    /// </summary>
    let hasNameOfCreator = _prefixId.prefix "hasNameOfCreator"
    /// <summary>
    ///   <para>rdfs:label : Has next in sequencerdfs:label : Ha successivo</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The property links an instance to the following siblingrdfs:comment : La proprietà collega l'istanziazione di una risorsa archivistica alla sua successiva gerarchicamente</para>
    ///   <a href="http://culturalis.org/oad#hasNextInSequence">oad:hasNextInSequence</a>
    /// </summary>
    let hasNextInSequence = _prefixId.prefix "hasNextInSequence"
    /// <summary>
    ///   <para>rdfs:label : Has Productionrdfs:label : Prodotto da</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <a href="http://culturalis.org/oad#hasProduction">oad:hasProduction</a>
    /// </summary>
    let hasProduction = _prefixId.prefix "hasProduction"
    /// <summary>
    ///   <para>rdfs:label : Has publication noterdfs:label : Ha bibliografia</para>
    ///   <para>rdfs:comment : The property links an instance to its bibliography informationrdfs:comment : La proprietà collega una scheda descrittiva alle informazioni relative alla pubblicazione</para>
    ///   <a href="http://culturalis.org/oad#hasPublicationNote">oad:hasPublicationNote</a>
    /// </summary>
    let hasPublicationNote = _prefixId.prefix "hasPublicationNote"
    /// <summary>
    ///   <para>rdfs:label : Has related instancerdfs:label : Ha scheda descrittiva collegata</para>
    ///   <para>rdfs:comment : The property links two or more instances relatedrdfs:comment : La proprietà collega tra loro due o più istanze archivistiche</para>
    ///   <a href="http://culturalis.org/oad#hasRelatedInstance">oad:hasRelatedInstance</a>
    /// </summary>
    let hasRelatedInstance = _prefixId.prefix "hasRelatedInstance"
    /// <summary>
    ///   <para>rdfs:label : Has repositoryrdfs:label : Soggetto conservatore</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://culturalis.org/oad#hasRepository">oad:hasRepository</a>
    /// </summary>
    let hasRepository = _prefixId.prefix "hasRepository"

    /// <summary>
    ///   <para>rdfs:label : Immediate source of acquisition or transferrdfs:label : Modalità di acquisizione o versamento</para>
    ///   <para>rdfs:comment : The property represents an immediate source of acquisition or transferrdfs:comment : La proprietà rappresenta le informazioni relative alla modalità di acquisizione o versamento della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#immediateSourceOfAcquisitionOrTransfer">oad:immediateSourceOfAcquisitionOrTransfer</a>
    /// </summary>
    let immediateSourceOfAcquisitionOrTransfer =
        _prefixId.prefix "immediateSourceOfAcquisitionOrTransfer"

    /// <summary>
    ///   <para>rdfs:label : Is contained inrdfs:label : È contenuta in</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The property represents the relationship between an instance and the finding aid in which it is containedrdfs:comment : La proprietà descrive la relazione tra l'istanziazione di una risorsa archivistica o di un'entity e lo strumento di ricerca in cui è contenuta</para>
    ///   <a href="http://culturalis.org/oad#isContainedIn">oad:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    /// <summary>
    ///   <para>rdfs:label : Is described byrdfs:label : Descritta da</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse property of oad:describesrdfs:comment : Proprietà inversa di 'describes'.</para>
    ///   <a href="http://culturalis.org/oad#isDescribedBy">oad:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : Is entry ofrdfs:label : È scheda descrittiva di</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The property links an instance to an archival resourcerdfs:comment : La proprietà mette in relazione l'istanziazione di una risorsa archivistica alla risorsa archivistica oggetto della descrizione</para>
    ///   <a href="http://culturalis.org/oad#isEntryOf">oad:isEntryOf</a>
    /// </summary>
    let isEntryOf = _prefixId.prefix "isEntryOf"
    /// <summary>
    ///   <para>rdfs:label : Is produced byrdfs:label : È prodotta da</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nella versione del 2 agosto 2018^^xsd:string</para>
    ///   <para>rdfs:comment : The property links the archival resource described to the entity responsible for the production of the resourcerdfs:comment : La proprietà collega la risorsa archivistica descritta alla entity responsabile della sua produzione</para>
    ///   <a href="http://culturalis.org/oad#isProducedBy">oad:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>rdfs:label : Noterdfs:label : Note</para>
    ///   <para>rdfs:comment : The property represents information that cannot be accommodated in any of the other properties.rdfs:comment : La proprietà rappresenta le informazioni relative alle note della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#note">oad:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:label : Other Level of descriptionrdfs:label : Altro livello di descrizione</para>
    ///   <para>rdfs:comment : The property represents an otherlevel of descriptionrdfs:comment : La proprietà rappresenta le informazioni relative ad un altro livello di descrizione della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#otherlevel">oad:otherlevel</a>
    /// </summary>
    let otherlevel = _prefixId.prefix "otherlevel"

    /// <summary>
    ///   <para>rdfs:label : Physical characteristics and technical requirementsrdfs:label : Caratteristiche materiali e requisiti tecnici</para>
    ///   <para>rdfs:comment : The property represents physical characteristics and technical requirementsrdfs:comment : La proprietà rappresenta le informazioni relative alle caratteristiche materiali e ai requisiti tecnici della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#physicalCharacteristicsAndTechnicalRequirements">oad:physicalCharacteristicsAndTechnicalRequirements</a>
    /// </summary>
    let physicalCharacteristicsAndTechnicalRequirements =
        _prefixId.prefix "physicalCharacteristicsAndTechnicalRequirements"

    /// <summary>
    ///   <para>rdfs:label : Productionrdfs:label : Produzione</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>dce:description : Le classi production e custody sono state inserite per descrivere il rapporto tra una risorsa archivistica e una entità (CPF), volendo esplicitare anche le date di relazione verso un soggetto produttore o un conservatore, gestendo in questo modo ad esempio anche i cambi di custodia</para>
    ///   <a href="http://culturalis.org/oad#production">oad:production</a>
    /// </summary>
    let production = _prefixId.prefix "production"
    /// <summary>
    ///   <para>rdfs:label : Reference coderdfs:label : Segnatura o codice identificativo</para>
    ///   <para>rdfs:comment : The property represents an identification code of the described resourcerdfs:comment : La proprietà rappresenta le informazioni relative al codice identificativo riportato in una scheda descrittiva</para>
    ///   <a href="http://culturalis.org/oad#referenceCode">oad:referenceCode</a>
    /// </summary>
    let referenceCode = _prefixId.prefix "referenceCode"
    /// <summary>
    ///   <para>rdfs:label : Scope and contentrdfs:label : Ambiti e contenuto</para>
    ///   <para>rdfs:comment : The property represents the scope and the content of the described resourcerdfs:comment : La proprietà rappresenta le informazioni relative ad ambiti e contenuto della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#scopeAndContent">oad:scopeAndContent</a>
    /// </summary>
    let scopeAndContent = _prefixId.prefix "scopeAndContent"
    /// <summary>
    ///   <para>rdfs:label : System of arrangementrdfs:label : Criteri di ordinamento</para>
    ///   <para>rdfs:comment : The property represents the internal structure, the order and/or the system of classification of the described resourcerdfs:comment : La proprietà rappresenta le informazioni relative ai criteri di ordinamento della risorsa archivistica descritta</para>
    ///   <a href="http://culturalis.org/oad#systemOfArrangement">oad:systemOfArrangement</a>
    /// </summary>
    let systemOfArrangement = _prefixId.prefix "systemOfArrangement"
    /// <summary>
    ///   <para>rdfs:label : Titlerdfs:label : Denominazione o titolo</para>
    ///   <para>rdfs:comment : The property represents the name shown in a descriptionrdfs:comment : La proprietà rappresenta le informazioni relative alla denominazione riportata in una scheda descrittiva</para>
    ///   <a href="http://culturalis.org/oad#title">oad:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : Use EAD element or attributerdfs:label : Utilizza l'elemento o attributo di EAD</para>
    ///   <para>owl:deprecated : true^^xsd:booelan</para>
    ///   <para>rdfs:comment : La proprietà collega una organizzazione all'elemento dello schema EAD utilizzato</para>
    ///   <a href="http://culturalis.org/oad#useEadElement">oad:useEadElement</a>
    /// </summary>
    let useEadElement = _prefixId.prefix "useEadElement"
