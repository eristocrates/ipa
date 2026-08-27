namespace http.culturalis.org.oad.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oad =
    let _namespace_iri = Namespace_Iri oad |> NamespaceIRI
    /// <summary>
    ///   <para>oad:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"Con questo aggiornamento è stata pubblicata l'estensione di OAD relativa all'integrazione con l'Archival Resource. Hanno preso parte alla elaborazione di questo aggiornamento IBC e regesta.exe"</para>
    /// labels<para>"Ontology for archival description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://culturalis.org/oad#">http://culturalis.org/oad#</seealso>
    let _prefix_iri = Prefixed_Name(oad, "") |> PrefixedName

    /// <summary>
    ///   <para>oad:AdministrativeBiographicalHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe rappresenta le informazioni relative alla storia istituzionale, amministrativa o biografica"</para>
    ///   <para>"The class represents the administrative and biographical history."</para>
    /// labels<para>"Administrative / Biographical history"</para><para>"Storia istituzionale/ amministrativa o biografia"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#AdministrativeBiographicalHistory">http://culturalis.org/oad#AdministrativeBiographicalHistory</seealso>
    let AdministrativeBiographicalHistory =
        Prefixed_Name(oad, "AdministrativeBiographicalHistory") |> PrefixedName

    /// <summary>
    ///   <para>oad:ArchivalInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#ArchivalInstance">http://culturalis.org/oad#ArchivalInstance</seealso>
    let ArchivalInstance = Prefixed_Name(oad, "ArchivalInstance") |> PrefixedName
    /// <summary>
    ///   <para>oad:ArchivalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe Archival resource indica un corpus documentale oggetto di descrizione"</para>
    ///   <para>"oad:ArchivalResource is the class that represents the object of the description (i.e., a single document or a set of document)."</para>
    /// labels<para>"Risorsa archivistica"</para><para>"Archival resource"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#ArchivalResource">http://culturalis.org/oad#ArchivalResource</seealso>
    let ArchivalResource = Prefixed_Name(oad, "ArchivalResource") |> PrefixedName
    /// <summary>
    ///   <para>oad:Custody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#Custody">http://culturalis.org/oad#Custody</seealso>
    let Custody = Prefixed_Name(oad, "Custody") |> PrefixedName
    /// <summary>
    ///   <para>oad:EadElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe è utilizzata per mappare le classi e le proprietà dell'ontologia OAD con gli elementi dello schema EAD"</para>
    /// labels<para>"EAD Schema's element or attribute"</para><para>"Elemento o attributo dello Schema EAD"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#EadElement">http://culturalis.org/oad#EadElement</seealso>
    let EadElement = Prefixed_Name(oad, "EadElement") |> PrefixedName
    /// <summary>
    ///   <para>oad:ExtentAndMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class represents the description about extent and medium."</para>
    ///   <para>"La classe Extent and medium rappresenta la descrizione dell'estensione e del supporto"</para>
    /// labels<para>"Consistenza e supporto"</para><para>"Extent and medium"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#ExtentAndMedium">http://culturalis.org/oad#ExtentAndMedium</seealso>
    let ExtentAndMedium = Prefixed_Name(oad, "ExtentAndMedium") |> PrefixedName
    /// <summary>
    ///   <para>oad:FindingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe rappresenta lo strumento di ricerca"</para>
    ///   <para>"The class represents a finding aid."</para>
    /// labels<para>"Finding aid"</para><para>"Strumento di ricerca"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#FindingAid">http://culturalis.org/oad#FindingAid</seealso>
    let FindingAid = Prefixed_Name(oad, "FindingAid") |> PrefixedName
    /// <summary>
    ///   <para>oad:Instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe Archival instance rappresenta l'istanziazione dell'archival resource"</para>
    ///   <para>"The class represents the descriptive entry of an archival resource"</para>
    /// labels<para>"Archival instance"</para><para>"Instanza archivistica"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#Instance">http://culturalis.org/oad#Instance</seealso>
    let Instance = Prefixed_Name(oad, "Instance") |> PrefixedName
    /// <summary>
    ///   <para>oad:LevelOfDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class represents the archival description level"</para>
    ///   <para>"La classe rappresenta il livello della descrizione archivistica"</para>
    /// labels<para>"Livello di descrizione"</para><para>"Level of description"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#LevelOfDescription">http://culturalis.org/oad#LevelOfDescription</seealso>
    let LevelOfDescription = Prefixed_Name(oad, "LevelOfDescription") |> PrefixedName
    /// <summary>
    ///   <para>oad:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe rappresenta un luogo"</para>
    ///   <para>"The class represents a physical place"</para>
    /// labels<para>"Luogo"</para><para>"Place"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#Place">http://culturalis.org/oad#Place</seealso>
    let Place = Prefixed_Name(oad, "Place") |> PrefixedName
    /// <summary>
    ///   <para>oad:Production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#Production">http://culturalis.org/oad#Production</seealso>
    let Production = Prefixed_Name(oad, "Production") |> PrefixedName
    /// <summary>
    ///   <para>oad:PublicationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class represents a bibliography"</para>
    ///   <para>"La classe rappresenta la bibliografia"</para>
    /// labels<para>"Bibliografia"</para><para>"Publication note"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#PublicationNote">http://culturalis.org/oad#PublicationNote</seealso>
    let PublicationNote = Prefixed_Name(oad, "PublicationNote") |> PrefixedName
    /// <summary>
    ///   <para>oad:UoD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La classe uod rappresenta la descrizione della risorsa archivistica"</para>
    /// labels<para>"Unit of description"</para><para>"Unità of descrizione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#UoD">http://culturalis.org/oad#UoD</seealso>
    let UoD = Prefixed_Name(oad, "UoD") |> PrefixedName
    /// <summary>
    ///   <para>oad:accruals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative agli incrementi previsti."</para>
    ///   <para>"The property represents expected increase."</para>
    /// labels<para>"Accruals"</para><para>"Incrementi previsti"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#accruals">http://culturalis.org/oad#accruals</seealso>
    let accruals = Prefixed_Name(oad, "accruals") |> PrefixedName

    /// <summary>
    ///   <para>oad:appraisalDestructionAndSchedulingInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents appraisal, destruction and scheduling information"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle procedure, ai tempi e ai criteri di valutazione e scarto della risorsa archivistica descritta"</para>
    /// labels<para>"Appraisal, destruction and scheduling information"</para><para>"Procedure, tempi e criteri di valutazione e scarto"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#appraisalDestructionAndSchedulingInformation">http://culturalis.org/oad#appraisalDestructionAndSchedulingInformation</seealso>
    let appraisalDestructionAndSchedulingInformation =
        Prefixed_Name(oad, "appraisalDestructionAndSchedulingInformation") |> PrefixedName

    /// <summary>
    ///   <para>oad:archivalHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents information about the history of the instance"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alla storia archivistica della risorsa archivistica descritta"</para>
    /// labels<para>"Storia archivistica"</para><para>"Archival history"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#archivalHistory">http://culturalis.org/oad#archivalHistory</seealso>
    let archivalHistory = Prefixed_Name(oad, "archivalHistory") |> PrefixedName
    /// <summary>
    ///   <para>oad:archivistsNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle note dell'archivista della risorsa archivistica descritta"</para>
    /// labels<para>"Nota dell'archivista"</para><para>"Archivist's Note"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#archivistsNote">http://culturalis.org/oad#archivistsNote</seealso>
    let archivistsNote = Prefixed_Name(oad, "archivistsNote") |> PrefixedName

    /// <summary>
    ///   <para>oad:conditionsGoverningAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents condition governing access of the instance"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle condizioni che regolano l'accesso della risorsa archivistica descritta"</para>
    /// labels<para>"Condizioni che regolano l’accesso"</para><para>"Conditions governing access"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#conditionsGoverningAccess">http://culturalis.org/oad#conditionsGoverningAccess</seealso>
    let conditionsGoverningAccess =
        Prefixed_Name(oad, "conditionsGoverningAccess") |> PrefixedName

    /// <summary>
    ///   <para>oad:conditionsGoverningReproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents condition governing reproduction of the instance"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle condizioni che regolano la riproduzione della risorsa archivistica descritta"</para>
    /// labels<para>"Condizioni che regolano la riproduzione"</para><para>"Conditions governing reproduction"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#conditionsGoverningReproduction">http://culturalis.org/oad#conditionsGoverningReproduction</seealso>
    let conditionsGoverningReproduction =
        Prefixed_Name(oad, "conditionsGoverningReproduction") |> PrefixedName

    /// <summary>
    ///   <para>oad:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Proprietà inversa di 'isContainedIn'."</para>
    ///   <para>"Inverse property of oad:isContainedIn"</para>
    /// labels<para>"Contiene"</para><para>"Contains"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#contains">http://culturalis.org/oad#contains</seealso>
    let contains = Prefixed_Name(oad, "contains") |> PrefixedName
    /// <summary>
    ///   <para>oad:custody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Conservazione"</para><para>"Custody"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#custody">http://culturalis.org/oad#custody</seealso>
    let custody = Prefixed_Name(oad, "custody") |> PrefixedName
    /// <summary>
    ///   <para>oad:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents a date"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alla datazione della risorsa archivistica descritta"</para>
    /// labels<para>"Data/e"</para><para>"Date(s)"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#date">http://culturalis.org/oad#date</seealso>
    let date = Prefixed_Name(oad, "date") |> PrefixedName
    /// <summary>
    ///   <para>oad:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This functional property links a finding aid to the archival resource described"</para>
    ///   <para>"La proprietà collega uno strumento di ricerca alla risorsa archivistica descritta"</para>
    /// labels<para>"Descrive"</para><para>"Describes"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#describes">http://culturalis.org/oad#describes</seealso>
    let describes = Prefixed_Name(oad, "describes") |> PrefixedName

    /// <summary>
    ///   <para>oad:existenceAndLocationOfCopies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative all'esistenza e alla localizzazione di copie della risorsa archivistica descritta"</para>
    ///   <para>"The property represents the existence and location of copies"</para>
    /// labels<para>"Esistenza e localizzazione di copie"</para><para>"Existence and location of copies"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#existenceAndLocationOfCopies">http://culturalis.org/oad#existenceAndLocationOfCopies</seealso>
    let existenceAndLocationOfCopies =
        Prefixed_Name(oad, "existenceAndLocationOfCopies") |> PrefixedName

    /// <summary>
    ///   <para>oad:existenceAndLocationOfOriginals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative all'esistenza e alla localizzazione degli originali della risorsa archivistica descritta"</para>
    ///   <para>"The property represents the existence and location of originals"</para>
    /// labels<para>"Esistenza e localizzazione degli originali"</para><para>"Existence and location of originals"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#existenceAndLocationOfOriginals">http://culturalis.org/oad#existenceAndLocationOfOriginals</seealso>
    let existenceAndLocationOfOriginals =
        Prefixed_Name(oad, "existenceAndLocationOfOriginals") |> PrefixedName

    /// <summary>
    ///   <para>oad:extentAndMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alla consistenza e al supporto della risorsa archivistica descritta"</para>
    /// labels<para>"Extent and medium of the unit of description (quantity, bulk, or size)"</para><para>"Consistenza e supporto dell'unità di descrizione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#extentAndMedium">http://culturalis.org/oad#extentAndMedium</seealso>
    let extentAndMedium = Prefixed_Name(oad, "extentAndMedium") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasAccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property represents an access point"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle chiavi di accesso"</para>
    /// labels<para>"Has key access point"</para><para>"Ha chiave di indice"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasAccessPoint">http://culturalis.org/oad#hasAccessPoint</seealso>
    let hasAccessPoint = Prefixed_Name(oad, "hasAccessPoint") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasAccessPointCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#hasAccessPointCorporateBody">http://culturalis.org/oad#hasAccessPointCorporateBody</seealso>
    let hasAccessPointCorporateBody =
        Prefixed_Name(oad, "hasAccessPointCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasAccessPointFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#hasAccessPointFamily">http://culturalis.org/oad#hasAccessPointFamily</seealso>
    let hasAccessPointFamily =
        Prefixed_Name(oad, "hasAccessPointFamily") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasAccessPointPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#hasAccessPointPerson">http://culturalis.org/oad#hasAccessPointPerson</seealso>
    let hasAccessPointPerson =
        Prefixed_Name(oad, "hasAccessPointPerson") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasAccessPointPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://culturalis.org/oad#hasAccessPointPlace">http://culturalis.org/oad#hasAccessPointPlace</seealso>
    let hasAccessPointPlace = Prefixed_Name(oad, "hasAccessPointPlace") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasAdministrativeBiographicalHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property links and instace to information about administrative and biographica history."</para>
    ///   <para>"La proprietà collega una scheda descrittiva alle informazioni relative alla storia amministrativa o biografica"</para>
    /// labels<para>"Ha storia amministrativa / biografica"</para><para>"Has administrative / biographical history"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasAdministrativeBiographicalHistory">http://culturalis.org/oad#hasAdministrativeBiographicalHistory</seealso>
    let hasAdministrativeBiographicalHistory =
        Prefixed_Name(oad, "hasAdministrativeBiographicalHistory") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasCustody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Conservato da"</para><para>"Has Custody"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasCustody">http://culturalis.org/oad#hasCustody</seealso>
    let hasCustody = Prefixed_Name(oad, "hasCustody") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Has Entity"</para><para>"Entità collegata"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasEntity">http://culturalis.org/oad#hasEntity</seealso>
    let hasEntity = Prefixed_Name(oad, "hasEntity") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà inversa di 'isEntryOf'."</para>
    /// labels<para>"Has entry"</para><para>"Ha scheda descrittiva"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasEntry">http://culturalis.org/oad#hasEntry</seealso>
    let hasEntry = Prefixed_Name(oad, "hasEntry") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasExtentAndMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega l'istanziazione di una risorsa archivistica alle informazioni relative all'estensione e al supporto"</para>
    ///   <para>"The property links an instance to information about extent and medium"</para>
    /// labels<para>"Ha estensione e supporto"</para><para>"Has extent and medium"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasExtentAndMedium">http://culturalis.org/oad#hasExtentAndMedium</seealso>
    let hasExtentAndMedium = Prefixed_Name(oad, "hasExtentAndMedium") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasExtentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property represents an extent type and it is related to a skos vocabulary"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alla tipologia di estensione e punta ad un vocabolario skos"</para>
    /// labels<para>"Has extent type"</para><para>"Ha tipo di estensione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasExtentType">http://culturalis.org/oad#hasExtentType</seealso>
    let hasExtentType = Prefixed_Name(oad, "hasExtentType") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasFilePlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property links an instance to a classification system"</para>
    ///   <para>"La proprietà collega una archival instance ad un sistema di classificazione"</para>
    /// labels<para>"File Plan"</para><para>"Sistema di classificazione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasFilePlan">http://culturalis.org/oad#hasFilePlan</seealso>
    let hasFilePlan = Prefixed_Name(oad, "hasFilePlan") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasFindingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega una archival instance allo strumento di ricerca che la contiene"</para>
    /// labels<para>"Has finding aid"</para><para>"Ha strumento di ricerca"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasFindingAid">http://culturalis.org/oad#hasFindingAid</seealso>
    let hasFindingAid = Prefixed_Name(oad, "hasFindingAid") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasLanguageScriptsOfMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property links an instance to its language information"</para>
    ///   <para>"La proprietà collega una archival instance alle informazioni relative alla lingua"</para>
    /// labels<para>"Has language/scripts of material"</para><para>"Ha lingua/scrittura della documentazione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasLanguageScriptsOfMaterial">http://culturalis.org/oad#hasLanguageScriptsOfMaterial</seealso>
    let hasLanguageScriptsOfMaterial =
        Prefixed_Name(oad, "hasLanguageScriptsOfMaterial") |> PrefixedName

    /// <summary>
    ///   <para>oad:hasLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega una unità di descrizione al livello di descrizione archivistica"</para>
    ///   <para>"The property links an archival resource to its level of description"</para>
    /// labels<para>"Has level of description"</para><para>"Ha livello di descrizione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasLevel">http://culturalis.org/oad#hasLevel</seealso>
    let hasLevel = Prefixed_Name(oad, "hasLevel") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasNameOfCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Nome del soggetto produttore"</para><para>"Name of creator(s)"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasNameOfCreator">http://culturalis.org/oad#hasNameOfCreator</seealso>
    let hasNameOfCreator = Prefixed_Name(oad, "hasNameOfCreator") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasNextInSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property links an instance to the following sibling"</para>
    ///   <para>"La proprietà collega l'istanziazione di una risorsa archivistica alla sua successiva gerarchicamente"</para>
    /// labels<para>"Has next in sequence"</para><para>"Ha successivo"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasNextInSequence">http://culturalis.org/oad#hasNextInSequence</seealso>
    let hasNextInSequence = Prefixed_Name(oad, "hasNextInSequence") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has Production"</para><para>"Prodotto da"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasProduction">http://culturalis.org/oad#hasProduction</seealso>
    let hasProduction = Prefixed_Name(oad, "hasProduction") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasPublicationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega una scheda descrittiva alle informazioni relative alla pubblicazione"</para>
    ///   <para>"The property links an instance to its bibliography information"</para>
    /// labels<para>"Has publication note"</para><para>"Ha bibliografia"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasPublicationNote">http://culturalis.org/oad#hasPublicationNote</seealso>
    let hasPublicationNote = Prefixed_Name(oad, "hasPublicationNote") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasRelatedInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega tra loro due o più istanze archivistiche"</para>
    ///   <para>"The property links two or more instances related"</para>
    /// labels<para>"Has related instance"</para><para>"Ha scheda descrittiva collegata"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasRelatedInstance">http://culturalis.org/oad#hasRelatedInstance</seealso>
    let hasRelatedInstance = Prefixed_Name(oad, "hasRelatedInstance") |> PrefixedName
    /// <summary>
    ///   <para>oad:hasRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has repository"</para><para>"Soggetto conservatore"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#hasRepository">http://culturalis.org/oad#hasRepository</seealso>
    let hasRepository = Prefixed_Name(oad, "hasRepository") |> PrefixedName

    /// <summary>
    ///   <para>oad:immediateSourceOfAcquisitionOrTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents an immediate source of acquisition or transfer"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alla modalità di acquisizione o versamento della risorsa archivistica descritta"</para>
    /// labels<para>"Modalità di acquisizione o versamento"</para><para>"Immediate source of acquisition or transfer"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#immediateSourceOfAcquisitionOrTransfer">http://culturalis.org/oad#immediateSourceOfAcquisitionOrTransfer</seealso>
    let immediateSourceOfAcquisitionOrTransfer =
        Prefixed_Name(oad, "immediateSourceOfAcquisitionOrTransfer") |> PrefixedName

    /// <summary>
    ///   <para>oad:isContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The property represents the relationship between an instance and the finding aid in which it is contained"</para>
    ///   <para>"La proprietà descrive la relazione tra l'istanziazione di una risorsa archivistica o di un'entity e lo strumento di ricerca in cui è contenuta"</para>
    /// labels<para>"Is contained in"</para><para>"È contenuta in"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#isContainedIn">http://culturalis.org/oad#isContainedIn</seealso>
    let isContainedIn = Prefixed_Name(oad, "isContainedIn") |> PrefixedName
    /// <summary>
    ///   <para>oad:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà inversa di 'describes'."</para>
    ///   <para>"Inverse property of oad:describes"</para>
    /// labels<para>"Is described by"</para><para>"Descritta da"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#isDescribedBy">http://culturalis.org/oad#isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(oad, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>oad:isEntryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property links an instance to an archival resource"</para>
    ///   <para>"La proprietà mette in relazione l'istanziazione di una risorsa archivistica alla risorsa archivistica oggetto della descrizione"</para>
    /// labels<para>"È scheda descrittiva di"</para><para>"Is entry of"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#isEntryOf">http://culturalis.org/oad#isEntryOf</seealso>
    let isEntryOf = Prefixed_Name(oad, "isEntryOf") |> PrefixedName
    /// <summary>
    ///   <para>oad:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega la risorsa archivistica descritta alla entity responsabile della sua produzione"</para>
    ///   <para>"The property links the archival resource described to the entity responsible for the production of the resource"</para>
    /// labels<para>"È prodotta da"</para><para>"Is produced by"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#isProducedBy">http://culturalis.org/oad#isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(oad, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>oad:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle note della risorsa archivistica descritta"</para>
    ///   <para>"The property represents information that cannot be accommodated in any of the other properties."</para>
    /// labels<para>"Note"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#note">http://culturalis.org/oad#note</seealso>
    let note = Prefixed_Name(oad, "note") |> PrefixedName
    /// <summary>
    ///   <para>oad:otherlevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative ad un altro livello di descrizione della risorsa archivistica descritta"</para>
    ///   <para>"The property represents an otherlevel of description"</para>
    /// labels<para>"Altro livello di descrizione"</para><para>"Other Level of description"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#otherlevel">http://culturalis.org/oad#otherlevel</seealso>
    let otherlevel = Prefixed_Name(oad, "otherlevel") |> PrefixedName

    /// <summary>
    ///   <para>oad:physicalCharacteristicsAndTechnicalRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alle caratteristiche materiali e ai requisiti tecnici della risorsa archivistica descritta"</para>
    ///   <para>"The property represents physical characteristics and technical requirements"</para>
    /// labels<para>"Physical characteristics and technical requirements"</para><para>"Caratteristiche materiali e requisiti tecnici"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#physicalCharacteristicsAndTechnicalRequirements">http://culturalis.org/oad#physicalCharacteristicsAndTechnicalRequirements</seealso>
    let physicalCharacteristicsAndTechnicalRequirements =
        Prefixed_Name(oad, "physicalCharacteristicsAndTechnicalRequirements") |> PrefixedName

    /// <summary>
    ///   <para>oad:production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Production"</para><para>"Produzione"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#production">http://culturalis.org/oad#production</seealso>
    let production = Prefixed_Name(oad, "production") |> PrefixedName
    /// <summary>
    ///   <para>oad:referenceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents an identification code of the described resource"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative al codice identificativo riportato in una scheda descrittiva"</para>
    /// labels<para>"Segnatura o codice identificativo"</para><para>"Reference code"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#referenceCode">http://culturalis.org/oad#referenceCode</seealso>
    let referenceCode = Prefixed_Name(oad, "referenceCode") |> PrefixedName
    /// <summary>
    ///   <para>oad:scopeAndContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents the scope and the content of the described resource"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative ad ambiti e contenuto della risorsa archivistica descritta"</para>
    /// labels<para>"Scope and content"</para><para>"Ambiti e contenuto"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#scopeAndContent">http://culturalis.org/oad#scopeAndContent</seealso>
    let scopeAndContent = Prefixed_Name(oad, "scopeAndContent") |> PrefixedName
    /// <summary>
    ///   <para>oad:systemOfArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La proprietà rappresenta le informazioni relative ai criteri di ordinamento della risorsa archivistica descritta"</para>
    ///   <para>"The property represents the internal structure, the order and/or the system of classification of the described resource"</para>
    /// labels<para>"Criteri di ordinamento"</para><para>"System of arrangement"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#systemOfArrangement">http://culturalis.org/oad#systemOfArrangement</seealso>
    let systemOfArrangement = Prefixed_Name(oad, "systemOfArrangement") |> PrefixedName
    /// <summary>
    ///   <para>oad:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property represents the name shown in a description"</para>
    ///   <para>"La proprietà rappresenta le informazioni relative alla denominazione riportata in una scheda descrittiva"</para>
    /// labels<para>"Denominazione o titolo"</para><para>"Title"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#title">http://culturalis.org/oad#title</seealso>
    let title = Prefixed_Name(oad, "title") |> PrefixedName
    /// <summary>
    ///   <para>oad:useEadElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La proprietà collega una organizzazione all'elemento dello schema EAD utilizzato"</para>
    /// labels<para>"Use EAD element or attribute"</para><para>"Utilizza l'elemento o attributo di EAD"</para></remarks>
    /// <seealso href="http://culturalis.org/oad#useEadElement">http://culturalis.org/oad#useEadElement</seealso>
    let useEadElement = Prefixed_Name(oad, "useEadElement") |> PrefixedName
