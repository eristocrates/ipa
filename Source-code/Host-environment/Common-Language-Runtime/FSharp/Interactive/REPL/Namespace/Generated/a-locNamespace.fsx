#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``a-loc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/location/" "a-loc"

    let ``_1.2`` = _prefixId.prefix "1.2"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : quota minima: GP/GPC/GPCI -GA/GAQ/GAQI - GL/GLQ/GLQI - MT/MTA/MTAM; quota massima: GP/GPC/GPCS - GA/GAQS - GL/GLQ/GLQS - MT/MTA/MTAX; quota relativa: MT/MTA/MTAR; coordinata z: 4.00 GE/GEC/GECZ - 3.00GP/GPC/GPCL</para>
    ///   <para>rdfs:label : Altitudinerdfs:label : Altitude</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'altitudine, ovvero l'altezza di un oggetto rispetto al livello del mare, che può essere specificata da un'altitudine massima, minima, relativa.rdfs:comment : This class represents the altitude, that is the height of an object above the sea level, which can be specified as maximum, minimum and relative altitude.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/Altitude">a-loc:Altitude</a>
    /// </summary>
    let Altitude = _prefixId.prefix "Altitude"
    let ArchivalLocation = _prefixId.prefix "ArchivalLocation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GPB; versioni precedenti: GP/GPB - GA/GAB - GL/GLB</para>
    ///   <para>rdfs:comment : This class represents the base map possibly used for georeferencing activities.rdfs:comment : Questa classe rappresenta la base cartografica eventualmente utilizzata nelle attività di georeferenziazione.</para>
    ///   <para>rdfs:label : Base cartograficardfs:label : Base map</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/BaseMap">a-loc:BaseMap</a>
    /// </summary>
    let BaseMap = _prefixId.prefix "BaseMap"
    let BuildingAndLandCadastre = _prefixId.prefix "BuildingAndLandCadastre"
    let BuildingCadastre = _prefixId.prefix "BuildingCadastre"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Entità catastalerdfs:label : Cadastral Entity</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'entità catastale, intesa come un oggetto che può avere una rappresentazione spaziale, relativamente alla ripartizione catastale.rdfs:comment : This class represents a cadastral entity, which is intended as an object that can have a spatial representation related to the cadastral allocation.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Traversale 4.00: CS/CTS; LS/CSS</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CadastralEntity">a-loc:CadastralEntity</a>
    /// </summary>
    let CadastralEntity = _prefixId.prefix "CadastralEntity"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un foglio di mappa catastale, in cui ricadono una o più particelle.rdfs:comment : This class represents a folio of a cadastral map, which contains one or more cadastral parcels.</para>
    ///   <para>rdfs:label : Cadastral map foliordfs:label : Foglio di mappa catastale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CS/CTS/CTSF ; LS/CSS/CSSF. - Normativa RA v.2: RP/LGC/LGCM+LGCA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CadastralFolio">a-loc:CadastralFolio</a>
    /// </summary>
    let CadastralFolio = _prefixId.prefix "CadastralFolio"
    /// <summary>
    ///   <para>rdfs:label : Cadastral identityrdfs:label : Identità catastale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : Un esempio d'uso della classe "Identità catastale" è il seguente:
    /// resource:CadastralIdentity/1400055239-1
    ///         a a-loc:CadastralIdentity ;
    ///         rdfs:label  "Identità catastale 1 del bene culturale: 1400055239"@en ;
    ///         a-cd:hasLegalSituation resource:LegalSituation/1400055239-cadastral-legal-situation-1 ;
    ///         a-loc:hasCadastralCity resource:City/s-martino-in-pensilis ;
    ///         a-loc:hasCadastralEntity resource:CadastralUnitCollection/1400055239-207 , resource:CadastralFolio/1400055239-8 .dce:description : An example of usage of the class 'Cadastral Identity' is the following:
    /// resource:CadastralIdentity/1400055239-1
    ///         a a-loc:CadastralIdentity ;
    ///         rdfs:label  "Cadastral identity 1 of cultural property: 1400055239"@en ;
    ///         a-cd:hasLegalSituation resource:LegalSituation/1400055239-cadastral-legal-situation-1 ;
    ///         a-loc:hasCadastralCity resource:City/s-martino-in-pensilis ;
    ///         a-loc:hasCadastralEntity resource:CadastralUnitCollection/1400055239-207 , resource:CadastralFolio/1400055239-8 .</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'identità catastale di un'entità, intesa come l'insieme delle informazioni di localizzazione che riguardano il bene con riferimento alla ripartizione catastale nazionale. L'identità catastale di un'entità può avere un riferimento cronologico, che indica l'epoca alla quale risalgono i dati catastali.rdfs:comment : This class represents the cadastral identity of an entity, which is intended as a set of location information concerning the property with reference to the national cadastral allocation. The cadastral identity can have a chronological reference indicating the dating of cadastral data.rdfs:comment : ICCD Normativa Traversale 4.00: CS; LS</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CS. - Normativa RA v.2: RP/LGC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CadastralIdentity">a-loc:CadastralIdentity</a>
    /// </summary>
    let CadastralIdentity = _prefixId.prefix "CadastralIdentity"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Traversale 4.00: CS/CTS/CTSN; LS/CSS/CSSN. - Normativa RA v.2: RP/LGC/LGCR^^xsd:string</para>
    ///   <para>rdfs:label : Cadastral unit collectionrdfs:label : Collezione di particelle catastali</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents one or more cadastral parcels.rdfs:comment : Questa classe rappresenta una o più particelle catastali.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CadastralUnitCollection">a-loc:CadastralUnitCollection</a>
    /// </summary>
    let CadastralUnitCollection = _prefixId.prefix "CadastralUnitCollection"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CS/CTS/CTST^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di catastordfs:label : Cadastre type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di catasto (ad es. catasto terreni, catasto fabbricati, catasto misto).rdfs:comment : This class represents the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CadastreType">a-loc:CadastreType</a>
    /// </summary>
    let CadastreType = _prefixId.prefix "CadastreType"
    let ChiefTown = _prefixId.prefix "ChiefTown"
    let CollectingLocation = _prefixId.prefix "CollectingLocation"
    /// <summary>
    ///   <para>rdfs:label : Continenterdfs:label : Continent</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un Continente.rdfs:comment : This class represents a Continent.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/Continent">a-loc:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:label : Coordinatesrdfs:label : Coordinate</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the set of coordinates, geographic or projected, which allows the georeferencing of an object. For the punctual georeferencing there is only a pair of coordinates. For the linear and areal georeferencing there are more pairs of coordinates identifying those points of the line or area representing the object.rdfs:comment : Questa classe rappresenta l'insieme delle coordinate, geografiche o proiettate, che permettono la georeferenziazione di un oggetto. Per la georeferenziazione puntuale sarà presente soltanto una coppia di coordinate; per la georeferenziazione lineare e areale saranno presenti più coppie di coordinate che individuano i punti che definiscono la linea o l'area che rappresenta il bene.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: GE/GEC - Normative precedenti: GP/GPD; GA/GAPD; GL/GLS</para>
    ///   <a href="https://w3id.org/arco/ontology/location/Coordinates">a-loc:Coordinates</a>
    /// </summary>
    let Coordinates = _prefixId.prefix "Coordinates"

    /// <summary>
    ///   <para>rdfs:label : Cultural Institute or Site Definitionrdfs:label : Definizione di Contenitore Giuridico</para>
    ///   <para>rdfs:comment : This class represents the type definition of a cultural insititute or site.rdfs:comment : Questa classe rappresenta la definizione della tipologia di un contenitore giuridico.</para>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CG: CG/CGT</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteDefinition">a-loc:CulturalInstituteOrSiteDefinition</a>
    /// </summary>
    let CulturalInstituteOrSiteDefinition =
        _prefixId.prefix "CulturalInstituteOrSiteDefinition"

    /// <summary>
    ///   <para>rdfs:label : Specificazione di Contenitore Giuridicordfs:label : Cultural Institute or Site Specification</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CG: CG/CGQ</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la specificazione della tipologia di un contenitore giuridico.rdfs:comment : This class represents the type specification of a cultural insititute or site.</para>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteSpecification">a-loc:CulturalInstituteOrSiteSpecification</a>
    /// </summary>
    let CulturalInstituteOrSiteSpecification =
        _prefixId.prefix "CulturalInstituteOrSiteSpecification"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CG: CG/CGT, CG/CGQ</para>
    ///   <para>rdfs:comment : This class represents the type of a cultural insititute or site.rdfs:comment : Questa classe rappresenta la tipologia di un contenitore giuridico.</para>
    ///   <para>rdfs:label : Tipo di Contenitore Giuridicordfs:label : Cultural Institute or Site type</para>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteType">a-loc:CulturalInstituteOrSiteType</a>
    /// </summary>
    let CulturalInstituteOrSiteType = _prefixId.prefix "CulturalInstituteOrSiteType"
    let CurrentPhysicalLocation = _prefixId.prefix "CurrentPhysicalLocation"
    let ExhibitionLocation = _prefixId.prefix "ExhibitionLocation"
    let ExtraurbanContext = _prefixId.prefix "ExtraurbanContext"
    let FindingLocation = _prefixId.prefix "FindingLocation"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa trasversale 4.00: GE/GPM - Normative precedenti: GP/GPM;  GA/GAM; GL/GLM</para>
    ///   <para>rdfs:label : Geometry methodrdfs:label : Metodo di posizionamento</para>
    ///   <para>rdfs:comment : This class represents the method used for the object positioning (i.e. exact, approximate, with a symbolic representation).rdfs:comment : Questa classe rappresenta il metodo utilizzato per il posizionamento (esatto, approssimato, con rappresentazione simbolica).</para>
    ///   <a href="https://w3id.org/arco/ontology/location/GeometryMethod">a-loc:GeometryMethod</a>
    /// </summary>
    let GeometryMethod = _prefixId.prefix "GeometryMethod"
    /// <summary>
    ///   <para>rdfs:label : Geometry techniquerdfs:label : Tecnica di georeferenziazione</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la tecnica di georeferenziazione, utilizzata per l'acquisizione delle coordinate (rilievo da cartografia con sopralluogo, rilievo da cartografia senza sopralluogo, rilievo da foto aerea con sopralluogo, rilievo da foto aerea senza sopralluogo, rilievo da satellite, rilievo tradizionale, rilievo tramite GPS, rilievo tramite punti d'appoggio fiduciali o trigonometrici, stereofotogrammetria).rdfs:comment : This class represents the technique of georeferencing, used for the acquisition of coordinates (i.e. survey from cartography with or without inspection, survey from aerial photos with or without inspection, satellite survey, traditional survey, survey via GPS, etc.).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GPT - Normative precedenti: GP/GPT; GA/GAT; GL/GLT</para>
    ///   <a href="https://w3id.org/arco/ontology/location/GeometryTechnique">a-loc:GeometryTechnique</a>
    /// </summary>
    let GeometryTechnique = _prefixId.prefix "GeometryTechnique"
    let HistoricalLocation = _prefixId.prefix "HistoricalLocation"
    let IncorporatedArea = _prefixId.prefix "IncorporatedArea"
    let LandCadastre = _prefixId.prefix "LandCadastre"
    let LastLocation = _prefixId.prefix "LastLocation"
    let Locality = _prefixId.prefix "Locality"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the type of location of a cultural property.rdfs:comment : Questa classe rappresenta il tipo di localizzazione di un bene culturale.</para>
    ///   <para>rdfs:label : Tipo di localizzazionerdfs:label : Location Type</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LA/TLC; LA/TCL; LC (CurrentPhysicalLocation) - Normativa F: anche LR (ShotLocation). - CS/CTL. - GE/GEL; GP/GPL; GL/GLL; GA/GAL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/LocationType">a-loc:LocationType</a>
    /// </summary>
    let LocationType = _prefixId.prefix "LocationType"
    /// <summary>
    ///   <para>rdfs:comment : This class represents spatial entities (i.e. roads, waterways, etc.) that border one or more cadastral parcels.rdfs:comment : Questa classe rappresenta le entità spaziali (particelle, strade, corsi d'acqua, ecc.) confinanti con una o più particelle catastali.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CS/CTE. - CS/CTS/CTSE. - LC/CSS/CSSE^^xsd:string</para>
    ///   <para>rdfs:label : Elemento di confinerdfs:label : Neighbouring cadastral entity</para>
    ///   <a href="https://w3id.org/arco/ontology/location/NeighbouringCadastralEntity">a-loc:NeighbouringCadastralEntity</a>
    /// </summary>
    let NeighbouringCadastralEntity = _prefixId.prefix "NeighbouringCadastralEntity"
    let ObservationLocation = _prefixId.prefix "ObservationLocation"
    /// <summary>
    ///   <para>rdfs:label : Centro storicordfs:label : Old town</para>
    ///   <para>rdfs:comment : This class represents the information describing the old town where the cultural property is located.rdfs:comment : Questa classe rappresenta le informazioni che descrivono il centro storico in cui si trova il bene culturale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD normative A e PG: LC/CST</para>
    ///   <a href="https://w3id.org/arco/ontology/location/OldTown">a-loc:OldTown</a>
    /// </summary>
    let OldTown = _prefixId.prefix "OldTown"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative A e PG: LC/CST/CSTA</para>
    ///   <para>rdfs:comment : Questa classe rappresenta le informazioni che precisano il carattere amministrativo del centro storico, che può essere: un capoluogo, una frazione, un centro inglobato o una località.rdfs:comment : This class represents the information clarifying the administrative character of the old town, which may be: a chief town, a town fraction, an incorporated area or a locality.</para>
    ///   <para>rdfs:label : Old town administrative typerdfs:label : Tipo di carattere amministrativo del centro storico</para>
    ///   <a href="https://w3id.org/arco/ontology/location/OldTownAdmistrativeType">a-loc:OldTownAdmistrativeType</a>
    /// </summary>
    let OldTownAdmistrativeType = _prefixId.prefix "OldTownAdmistrativeType"
    let PreviousLocation = _prefixId.prefix "PreviousLocation"
    let ProductionRealizationLocation = _prefixId.prefix "ProductionRealizationLocation"
    let ShootingLocation = _prefixId.prefix "ShootingLocation"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the type definition of a physical container.rdfs:comment : Questa classe rappresenta la definizione della tipologia di un contenitore fisico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCT</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Definizione di Contenitore Fisicordfs:label : Site Definition</para>
    ///   <a href="https://w3id.org/arco/ontology/location/SiteDefinition">a-loc:SiteDefinition</a>
    /// </summary>
    let SiteDefinition = _prefixId.prefix "SiteDefinition"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents specifications about the physical container, i.e. the adjective or the phrase that with respect to the Site Definition specifies, integrates or characterizes the physical container from the point of view of the legal-administrative or functional condition.rdfs:comment : Questa classe rappresenta specifiche sulla qualificazione del contenitore fisico, cioè l'aggettivo o la locuzione che, rispetto alla Site Definition, precisa, integra o caratterizza il contenitore fisico dal punto di vista della condizione giuridico-amministrativa o funzionale.</para>
    ///   <para>rdfs:label : Qualificazione del Contenitore Fisicordfs:label : Site Specification</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCQ</para>
    ///   <a href="https://w3id.org/arco/ontology/location/SiteSpecification">a-loc:SiteSpecification</a>
    /// </summary>
    let SiteSpecification = _prefixId.prefix "SiteSpecification"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di contenitore fisico, cioè la tipologia del contenitore fisico ed eventuali aggettivi o locuzioni che precisano, integrano o caratterizzano il contenitore fisico dal punto di vista della condizione giuridico-amministrativa o funzionale.rdfs:comment : This class represents the type of a physical container, i.e. it contains adjectives or phrases that specify, integrate or characterize the physical container from the point of view of the legal-administrative or functional condition.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Site Typerdfs:label : Tipo di Contenitore Fisico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCT; LC/LDC/LDCQ</para>
    ///   <a href="https://w3id.org/arco/ontology/location/SiteType">a-loc:SiteType</a>
    /// </summary>
    let SiteType = _prefixId.prefix "SiteType"
    let StorageLocation = _prefixId.prefix "StorageLocation"
    let SubjectLocation = _prefixId.prefix "SubjectLocation"
    let SuburbanContext = _prefixId.prefix "SuburbanContext"
    let TerritorialContext = _prefixId.prefix "TerritorialContext"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a localization of a cultural property, within a timeframe and qualified according to the role that the localization plays in relation to the cultural property.rdfs:comment : Questa classe rappresenta una localizzazione di un bene culturale, inserita in un arco temporale e qualificata in base al ruolo che la localizzazione riveste nei confronti del bene culturale.</para>
    ///   <para>dce:description : Un esempio d'uso della classe "Localizzazione tipizzata nel tempo' è il seguente:
    /// resource:TimeIndexedTypedLocation/0800055566-alternative-1
    ///         a           a-loc:TimeIndexedTypedLocation ;
    ///         rdfs:label "Altra localizzazione 1 del bene culturale: 0800055566"@en ;
    ///        a-loc:atSite  resource:Site/7761991208459c29ef5c7cee8ff29deb ;
    ///         a-loc:hasLocationType a-loc:LastLocation ;
    ///         tiapit:atTime resource:TimeInterval/2002 .dce:description : An example of usage of the class 'Time Indexed Typed Location' is the following:
    /// resource:TimeIndexedTypedLocation/0800055566-alternative-1
    ///         a  a-loc:TimeIndexedTypedLocation ;
    ///         rdfs:label "Alternative location 1 of cultural property: 0800055566"@en ;  a-loc:atSite  resource:Site/7761991208459c29ef5c7cee8ff29deb ;
    ///         a-loc:hasLocationType a-loc:LastLocation ;
    ///         tiapit:atTime resource:TimeInterval/2002 .</para>
    ///   <para>rdfs:label : Localizzazione tipizzata nel tempordfs:label : Time Indexed Typed Location</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC; LA; per normativa F: anche LR</para>
    ///   <a href="https://w3id.org/arco/ontology/location/TimeIndexedTypedLocation">a-loc:TimeIndexedTypedLocation</a>
    /// </summary>
    let TimeIndexedTypedLocation = _prefixId.prefix "TimeIndexedTypedLocation"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta eventuali altre denominazioni del luogo, che cambiano nel tempo.rdfs:comment : This class represents other place's designations changing over time.</para>
    ///   <para>rdfs:label : Toponimo nel tempordfs:label : Toponym in time</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/PVL/PVLT; LA/PRL/PRLT. - Versioni precedenti: LC/PVL, LA/PRL</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/ToponymInTime">a-loc:ToponymInTime</a>
    /// </summary>
    let ToponymInTime = _prefixId.prefix "ToponymInTime"
    let TownFraction = _prefixId.prefix "TownFraction"
    /// <summary>
    ///   <para>rdfs:label : Type of geographic contextrdfs:label : Tipo di contesto geografico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/PVZ; LA/PRZ - Normative A e PG: LC/SET/SETT</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di contesto in cui si trova un bene culturale, che può essere urbano, suburbano, extraurbano, territoriale, subacqueo.rdfs:comment : This class represents the type of geographical context where the cultural property is located: i.e. urban, suburban, extra-urban, territorial, underwater.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/TypeOfContext">a-loc:TypeOfContext</a>
    /// </summary>
    let TypeOfContext = _prefixId.prefix "TypeOfContext"
    let UnderwaterContext = _prefixId.prefix "UnderwaterContext"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative A e PG: LC/ZUR/ZURD.</para>
    ///   <para>rdfs:label : Urban areardfs:label : Zona urbana</para>
    ///   <para>rdfs:comment : Questa classe rappresenta le informazioni relative alla denominazione della zona urbana che fa parte del centro storico dove si trova il bene culturale.rdfs:comment : This class represents the informations on the denomination of the urban area that is part of the old town where the cultural property is located.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/UrbanArea">a-loc:UrbanArea</a>
    /// </summary>
    let UrbanArea = _prefixId.prefix "UrbanArea"
    let UrbanContext = _prefixId.prefix "UrbanContext"
    /// <summary>
    ///   <para>rdfs:label : Numero d'ordine amministrativordfs:label : Administrative order number</para>
    ///   <para>rdfs:comment : This property associates the order number that identifies a location intended as an administrative unit, i.e. an old town, an urban area and a sector.rdfs:comment : Questa proprietà associa il numero d'ordine che identifica una località intesa come unità amministrativa, ovvero un centro storico, una zona urbana e un settore.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative A e PG: LC/CST/CSTN; LC/ZUR/ZURN; LC/SET/SETN</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/administrativeOrderNumber">a-loc:administrativeOrderNumber</a>
    /// </summary>
    let administrativeOrderNumber = _prefixId.prefix "administrativeOrderNumber"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la coordinata z di un oggetto, che ne definisce l'altitudine rispetto al livello del mare.rdfs:comment : This property represents the z coordinate of an object, which defines its altitude above sea level.</para>
    ///   <para>rdfs:label : altitudinerdfs:label : altitude</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GEC/GECZ - Normative precedenti: GP/GPC/GPCL</para>
    ///   <a href="https://w3id.org/arco/ontology/location/alt">a-loc:alt</a>
    /// </summary>
    let alt = _prefixId.prefix "alt"
    /// <summary>
    ///   <para>rdfs:label : sono coordinate dirdfs:label : are coordinates of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha coordinate".rdfs:comment : This is the inverse property of "has coordinates".</para>
    ///   <a href="https://w3id.org/arco/ontology/location/areCoordinatesOf">a-loc:areCoordinatesOf</a>
    /// </summary>
    let areCoordinatesOf = _prefixId.prefix "areCoordinatesOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una localizzazione tipizzata nel tempo al luogo cui si riferisce.rdfs:comment : This property links a typed location over time to its related geographical entity.</para>
    ///   <para>rdfs:label : at locationrdfs:label : presso luogo</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: se LC senza sottoelemento LDC; se LA senza sottoelemento PRC.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/atLocation">a-loc:atLocation</a>
    /// </summary>
    let atLocation = _prefixId.prefix "atLocation"
    /// <summary>
    ///   <para>rdfs:label : presso contenitore fisicordfs:label : at site</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC; LA/PRC</para>
    ///   <para>rdfs:comment : Questa proprietà collega una localizzazione tipizzata nel tempo al contenitore fisico cui si riferisce.rdfs:comment : This property links a typified location over time to its physical container (Site).</para>
    ///   <a href="https://w3id.org/arco/ontology/location/atSite">a-loc:atSite</a>
    /// </summary>
    let atSite = _prefixId.prefix "atSite"
    /// <summary>
    ///   <para>rdfs:label : denominazione del catastordfs:label : cadastre name</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents the designation of a historical cadastre.rdfs:comment : Questa proprietà rappresenta la denominazione con cui è noto un catasto storico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LS/CSS/CSSD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/cadastreName">a-loc:cadastreName</a>
    /// </summary>
    let cadastreName = _prefixId.prefix "cadastreName"

    /// <summary>
    ///   <para>rdfs:comment : This property allows to associate a legal container to its code assigned by the ICCD.rdfs:comment : Questa proprietà permette di associare un contenitore giuridico al codice assegnatogli dall'ICCD.</para>
    ///   <para>rdfs:label : identificativo del contenitore giuridicordfs:label : cultural institute or site identifier</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCG; LA/PRC/PRCG</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/culturalInstituteOrSiteIdentifier">a-loc:culturalInstituteOrSiteIdentifier</a>
    /// </summary>
    let culturalInstituteOrSiteIdentifier =
        _prefixId.prefix "culturalInstituteOrSiteIdentifier"

    /// <summary>
    ///   <para>rdfs:comment : This property represents the progressive number that identifies the district where the cultural property is located.rdfs:comment : Questa proprietà rappresenta il numero progressivo che individua il settore dove si trova il bene culturale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative A e PG: LC/SET/SETP</para>
    ///   <para>rdfs:label : District numberrdfs:label : Numero del settore</para>
    ///   <a href="https://w3id.org/arco/ontology/location/districtNumber">a-loc:districtNumber</a>
    /// </summary>
    let districtNumber = _prefixId.prefix "districtNumber"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : quota minima: GP/GPC/GPCI - GA/GAQ/GAQI - GL/GLQ/GLQI - MT/MTA/MTAM; quota massima: GP/GPC/GPCS - GA/GAQS - GL/GLQ/GLQS - MT/MTA/MTAX; quota relativa: MT/MTA/MTAR; coordinata z: 4.00 GE/GEC/GECZ - 3.00GP/GPC/GPCL</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega le coordinate relative alla georeferenziazione di un oggetto (Geometry) alla sua altitudine.rdfs:comment : This property links the georeferencing coordinates of an object (Geometry) to its altitude.</para>
    ///   <para>rdfs:label : has altituderdfs:label : ha altitudine</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasAltitude">a-loc:hasAltitude</a>
    /// </summary>
    let hasAltitude = _prefixId.prefix "hasAltitude"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha base cartograficardfs:label : has base map</para>
    ///   <para>rdfs:comment : Questa proprietà collega una georeferenziazione di un oggetto alla base cartografica eventualmente utilizzata.rdfs:comment : This property links an object georeferencing to the base map possibly used.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GPB; versioni precedenti: GP/GPB - GA/GAB - GL/GLB</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasBaseMap">a-loc:hasBaseMap</a>
    /// </summary>
    let hasBaseMap = _prefixId.prefix "hasBaseMap"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CS/CTS/CTSC. - Normativa RA v.2: RP/LGC/LGCC</para>
    ///   <para>rdfs:label : has cadastral cityrdfs:label : ha città catastale</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'identità catastale di un'entità al comune a cui è intestato il foglio di mappa catastale, riportato nella forma attestata nel catasto.rdfs:comment : This property links a cadastral identity of an entity to the municipality to which the cadastral map is registered, as attested by the cadastre.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCadastralCity">a-loc:hasCadastralCity</a>
    /// </summary>
    let hasCadastralCity = _prefixId.prefix "hasCadastralCity"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has cadastral entityrdfs:label : ha entità catastale</para>
    ///   <para>rdfs:comment : This property links a cadastral identity of an entity to one of the cadastral entities, understood as spatial objects, that define it.rdfs:comment : Questa proprietà collega un'identità catastale di un'entità a una delle entità catastali, intese come oggetti spaziali, che la definiscono.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Traversale 4.00: CS/CTS, CS/CTS/CTSF, CTSN; LS/CSS. LG/LGC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCadastralEntity">a-loc:hasCadastralEntity</a>
    /// </summary>
    let hasCadastralEntity = _prefixId.prefix "hasCadastralEntity"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links a cultural property to all its cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc.rdfs:comment : Questa proprietà collega un bene culturale all'insieme delle informazioni catastali che lo riguardano, relativamente a una delle sue localizzazioni (storica, attuale, di rinvenimento, ecc.)</para>
    ///   <para>rdfs:label : ha identità catastalerdfs:label : has cadastral identity</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CS. - Normativa RA v.2: RP/LGC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCadastralIdentity">a-loc:hasCadastralIdentity</a>
    /// </summary>
    let hasCadastralIdentity = _prefixId.prefix "hasCadastralIdentity"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cadastral identity of an entity to the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).rdfs:comment : Questa proprietà collega una identità catastale relativa a un'entità al tipo di catasto (ad es. catasto terreni, catasto fabbricati, catasto misto).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : CS/CTS/CTST^^xsd:string</para>
    ///   <para>rdfs:label : ha tipo di catastordfs:label : has cadastre type</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCadastreType">a-loc:hasCadastreType</a>
    /// </summary>
    let hasCadastreType = _prefixId.prefix "hasCadastreType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un indirizzo a un'area amministrativa ecclesiastica (ad es. una diocesi).rdfs:comment : This property relates an address to a clerical administrative area (e.g. a diocese).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LC/PVE; LA/PRE^^xsd:string</para>
    ///   <para>rdfs:label : ha area amministrativa ecclesiasticardfs:label : has clerical administrative area</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasClericalAdministrativeArea">a-loc:hasClericalAdministrativeArea</a>
    /// </summary>
    let hasClericalAdministrativeArea = _prefixId.prefix "hasClericalAdministrativeArea"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has continentrdfs:label : ha continente</para>
    ///   <para>rdfs:comment : Questa proprietà collega la localizzazione di un'entità al continente in cui si trova.rdfs:comment : This property links the location of an entity to the continent where it is located.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LA/PRT/PRTK</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasContinent">a-loc:hasContinent</a>
    /// </summary>
    let hasContinent = _prefixId.prefix "hasContinent"
    /// <summary>
    ///   <para>rdfs:label : ha coordinaterdfs:label : has coordinates</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega la georeferenziazione di un oggetto (Geometry) alle coordinate (x, y, z).rdfs:comment : This property links the object georeferencing (Geometry) to its coordinates (x, y, z).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: GE/GEC - versioni precedenti: GP/GPD; GA/GAPD; GL/GLS</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCoordinates">a-loc:hasCoordinates</a>
    /// </summary>
    let hasCoordinates = _prefixId.prefix "hasCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : This property links a cultural property to the cultural institute or siterdfs:comment : Questa proprietà collega un bene culturale al luogo o istituto della cultura (contenitore giuridico) in cui è contenuta</para>
    ///   <para>rdfs:label : ha luogo o istituto della culturardfs:label : has cultural institute or site</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : instabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSite">a-loc:hasCulturalInstituteOrSite</a>
    /// </summary>
    let hasCulturalInstituteOrSite = _prefixId.prefix "hasCulturalInstituteOrSite"

    /// <summary>
    ///   <para>rdfs:label : ha definizione del contenitore giuridicordfs:label : has cultiral institute or site definition</para>
    ///   <para>rdfs:comment : Questa proprietà collega la tipologia di un contenitore giuridico a una delle sue componenti, cioè alla definizione della sua tipologia.rdfs:comment : This property links the type of a cultural institute or site to one of its components, that is to the definition of its type.</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : instabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CG: CG/CGT</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteDefinition">a-loc:hasCulturalInstituteOrSiteDefinition</a>
    /// </summary>
    let hasCulturalInstituteOrSiteDefinition =
        _prefixId.prefix "hasCulturalInstituteOrSiteDefinition"

    /// <summary>
    ///   <para>rdfs:comment : This property links the type of a cultural institute or site to one of its components, that is to the specifications of its type.rdfs:comment : Questa proprietà collega la tipologia di un contenitore giuridico a una delle sue componenti, cioè alle specifiche sulla sua tipologia.</para>
    ///   <para>rdfs:label : has cultural institute or site specificationrdfs:label : ha qualificazione del contenitore giuridico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CG: CG/CGQ</para>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteSpecification">a-loc:hasCulturalInstituteOrSiteSpecification</a>
    /// </summary>
    let hasCulturalInstituteOrSiteSpecification =
        _prefixId.prefix "hasCulturalInstituteOrSiteSpecification"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CG: CG/CGT; CG/CGQ</para>
    ///   <para>rdfs:comment : Questa proprietà collega un contenitore giuridico al tipo di contenitore giuridico, per permetterne la corretta e precisa individuazione.rdfs:comment : This property connects a Cultural institute or site to its type, to allow its correct and precise identification.</para>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <para>rdfs:label : ha tipo di contenitore giuridicordfs:label : has cultural institute or site type</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteType">a-loc:hasCulturalInstituteOrSiteType</a>
    /// </summary>
    let hasCulturalInstituteOrSiteType =
        _prefixId.prefix "hasCulturalInstituteOrSiteType"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LC/PVC</para>
    ///   <para>rdfs:comment : This property represents the relationship that links a cultural property to the address of its current physical location at the cataloging time. The report provides a simplified representation, with a reduced expressivity, of the current location of the cultural property, and it causes the loss of other information regarding its location (i.e. the continent, the possible physical container, the specific location in the physical container, etc.).rdfs:comment : Questa proprietà rappresenta la relazione che collega un bene culturale all'indirizzo della sua localizzazione fisica attuale, al momento della catalogazione. La relazione fornisce una rappresentazione semplificata, con ridotta espressività, della localizzazione attuale del bene culturale, e provoca la perdita delle altre informazioni che riguardano la collocazione del bene (continente, eventuale contenitore fisico, collocazione specifica nel contenitore fisico, ecc.).</para>
    ///   <para>rdfs:label : indirizzo del bene culturalerdfs:label : cultural property address</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasCulturalPropertyAddress">a-loc:hasCulturalPropertyAddress</a>
    /// </summary>
    let hasCulturalPropertyAddress = _prefixId.prefix "hasCulturalPropertyAddress"
    /// <summary>
    ///   <para>rdfs:comment : This property links a georeferencing to the method used for the object positioning.rdfs:comment : Questa proprietà collega una georeferenziazione al metodo utilizzato per il posizionamento.</para>
    ///   <para>rdfs:label : has geometry methodrdfs:label : ha metodo di georeferenziazione</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GPM; versioni precedenti: GP/GPM - GA/GAM - GL/GLM</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasGeometryMethod">a-loc:hasGeometryMethod</a>
    /// </summary>
    let hasGeometryMethod = _prefixId.prefix "hasGeometryMethod"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links a georeferencing to the georeferencing technique.rdfs:comment : Questa proprietà collega una georeferenziazione alla tecnica di georeferenziazione.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GPT; versioni precedenti: GP/GPT - GA/GAT - GL/GLT</para>
    ///   <para>rdfs:label : ha tecnica di georeferenziazionerdfs:label : has geometry technique</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasGeometryTechnique">a-loc:hasGeometryTechnique</a>
    /// </summary>
    let hasGeometryTechnique = _prefixId.prefix "hasGeometryTechnique"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links an address to a governmental administrative area.rdfs:comment : Questa proprietà collega un indirizzo a un'area di appartenenza amministrativa.</para>
    ///   <para>rdfs:label : has governamental administrative areardfs:label : ha area di appartenenza amministrativa</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LS/LCS/LCSA; LA/PRT/PRTR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasGovernmentalAdministrativeArea">a-loc:hasGovernmentalAdministrativeArea</a>
    /// </summary>
    let hasGovernmentalAdministrativeArea =
        _prefixId.prefix "hasGovernmentalAdministrativeArea"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha area storicardfs:label : has historical area</para>
    ///   <para>rdfs:comment : Questa proprietà collega un indirizzo a un'area storico-geografica.rdfs:comment : This property links an address to a historical-geographical area.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasHistoricalArea">a-loc:hasHistoricalArea</a>
    /// </summary>
    let hasHistoricalArea = _prefixId.prefix "hasHistoricalArea"
    /// <summary>
    ///   <para>rdfs:comment : This property links an entity (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity) to the role of the localization referring to it (i.e current physical location, previous location, finding location, etc.).rdfs:comment : Questa proprietà collega un'entità, per esempio un situazione in cui un luogo riveste un certo ruolo nei confronti di un bene culturale in un intervallo di tempo, o una georeferenziazione, o un'identità catastale al ruolo della localizzazione (fisica attuale, precedente, di rinvenimento, ecc.) cui si riferisce.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha tipo di localizzazione cui si riferiscerdfs:label : has referred location type</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GEL; LA/TLC; LA/TCL; LC (CurrentPhysicalLocation) - Normativa F: anche LR (ShotLocation) - Normative di versioni precedenti: GP/GPL; GA/GAL; GL/GLL. - CS/CTL</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasLocationType">a-loc:hasLocationType</a>
    /// </summary>
    let hasLocationType = _prefixId.prefix "hasLocationType"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property connects a historical center with information related to its administrative type.rdfs:comment : Questa proprietà collega un centro storico con le informazioni relative al tipo del suo carattere amministrativo.</para>
    ///   <para>rdfs:label : Old town administrative typerdfs:label : Tipo amministrativo del centro storico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative A e PG: LC/CST/CSTA</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasOldTownAdministrativeType">a-loc:hasOldTownAdministrativeType</a>
    /// </summary>
    let hasOldTownAdministrativeType = _prefixId.prefix "hasOldTownAdministrativeType"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega la tipologia di un contenitore fisico a una delle sue componenti, cioè alla definizione della sua tipologia.rdfs:comment : This property links the type of a physical container to one of its components, that is to the definition of its type.</para>
    ///   <para>rdfs:label : ha definizione del contenitore fisicordfs:label : has site definition</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCT</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasSiteDefinition">a-loc:hasSiteDefinition</a>
    /// </summary>
    let hasSiteDefinition = _prefixId.prefix "hasSiteDefinition"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCQ</para>
    ///   <para>rdfs:comment : This property links the type of a physical container to one of its components, that is to the specifications of its type.rdfs:comment : Questa proprietà collega la tipologia di un contenitore fisico a una delle sue componenti, cioè alle specifiche sulla sua tipologia.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha qualificazione del contenitore fisicordfs:label : has site specification</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasSiteSpecification">a-loc:hasSiteSpecification</a>
    /// </summary>
    let hasSiteSpecification = _prefixId.prefix "hasSiteSpecification"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un contenitore fisico al tipo di contenitore fisico, per permetterne la corretta e precisa individuazione.rdfs:comment : This property connects a physical container (Site) to its type, to allow its correct and precise identification.</para>
    ///   <para>rdfs:label : has site typerdfs:label : ha tipo di contenitore fisico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCT; LC/LDC/LDCQ</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasSiteType">a-loc:hasSiteType</a>
    /// </summary>
    let hasSiteType = _prefixId.prefix "hasSiteType"
    /// <summary>
    ///   <para>rdfs:label : has stratigraphic areardfs:label : ha ambiente</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a stratigraphic record to the area in which it took place.rdfs:comment : Questa proprietà collega un saggio stratigrafico all'ambiente in un il saggio è stato effettuato.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SAS: OG/OGT/OGTX^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasStratigraphicArea">a-loc:hasStratigraphicArea</a>
    /// </summary>
    let hasStratigraphicArea = _prefixId.prefix "hasStratigraphicArea"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SAS: OG/OGT/OGTY^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha settorerdfs:label : has stratigraphic room</para>
    ///   <para>rdfs:comment : This property relates a stratigraphic record to the room in which it took place.rdfs:comment : Questa proprietà collega un saggio stratigrafico al settore in cui il saggio è stato effettuato.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasStratigraphicRoom">a-loc:hasStratigraphicRoom</a>
    /// </summary>
    let hasStratigraphicRoom = _prefixId.prefix "hasStratigraphicRoom"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SAS: OG/OGT/OGTZ^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha quadratordfs:label : has stratigraphic square</para>
    ///   <para>rdfs:comment : This property relates a stratigraphic record to the square in which it took place.rdfs:comment : Questa proprietà collega un saggio stratigrafico al quadrato in un il saggio è stato effettuato.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasStratigraphicSquare">a-loc:hasStratigraphicSquare</a>
    /// </summary>
    let hasStratigraphicSquare = _prefixId.prefix "hasStratigraphicSquare"
    /// <summary>
    ///   <para>rdfs:label : has territorial areardfs:label : ha area di appartenenza territoriale</para>
    ///   <para>rdfs:comment : This property links an address to a territorial area, which may not coincide with the administrative area, to which a cultural property belongs.rdfs:comment : Questa proprietà collega un indirizzo a un'area di appartenenza territoriale, che può non coincidere con l'area amministrativa.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LS/LCS/LCSR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasTerritorialArea">a-loc:hasTerritorialArea</a>
    /// </summary>
    let hasTerritorialArea = _prefixId.prefix "hasTerritorialArea"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha ripartizione territorialerdfs:label : has territorial division</para>
    ///   <para>rdfs:comment : This property links an address to a territorial division within a territorial area.rdfs:comment : Questa proprietà collega un indirizzo a una ripartizione territoriale interna a un'area territoriale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LS/LCS/LCST^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasTerritorialDivision">a-loc:hasTerritorialDivision</a>
    /// </summary>
    let hasTerritorialDivision = _prefixId.prefix "hasTerritorialDivision"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links an entity to its typified location over time.rdfs:comment : Questa proprietà collega un'entità a una sua localizzazione tipizzata nel tempo.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC; LA; per normativa F: anche LR</para>
    ///   <para>rdfs:label : ha localizzazione tipizzata nel tempordfs:label : has time indexed typed location</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasTimeIndexedTypedLocation">a-loc:hasTimeIndexedTypedLocation</a>
    /// </summary>
    let hasTimeIndexedTypedLocation = _prefixId.prefix "hasTimeIndexedTypedLocation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/PVL/PVLT; LA/PRL/PRLT. - Versioni precedenti: LC/PVL, LA/PRL</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà permette di collegare un luogo a una denominazione che cambia nel tempo.rdfs:comment : This property relates a geographical entity to a toponym chianging over time.</para>
    ///   <para>rdfs:label : ha toponimo nel tempordfs:label : has toponym in time</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasToponymInTime">a-loc:hasToponymInTime</a>
    /// </summary>
    let hasToponymInTime = _prefixId.prefix "hasToponymInTime"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/PVZ; LA/PRZ</para>
    ///   <para>rdfs:label : has type of geographical contextrdfs:label : ha tipo di contesto geografico</para>
    ///   <para>rdfs:comment : Questa proprietà permette di collegare un'entità al tipo di contesto (urbano, suburbano, extraurbano, territoriale, subacqueo) in cui si trova.rdfs:comment : This property relates an entity to the type of context where the cultural property is located (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context).</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasTypeOfContext">a-loc:hasTypeOfContext</a>
    /// </summary>
    let hasTypeOfContext = _prefixId.prefix "hasTypeOfContext"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has urban areardfs:label : ha zona urbana</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative A e PG: LC/ZUR/ZURD.</para>
    ///   <para>rdfs:comment : This property connects the old town with the urban area that is part of it.rdfs:comment : Questa proprietà collega il centro storico con la zona urbana che ne fa parte.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/hasUrbanArea">a-loc:hasUrbanArea</a>
    /// </summary>
    let hasUrbanArea = _prefixId.prefix "hasUrbanArea"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega le coordinate relative alla georeferenziazione dell'altitudine a un oggetto (Geometry).rdfs:comment : This property links the georeferencing coordinates of the altitude to an object (Geometry).</para>
    ///   <para>rdfs:label : is altitude ofrdfs:label : è altitudine di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isAltitudeOf">a-loc:isAltitudeOf</a>
    /// </summary>
    let isAltitudeOf = _prefixId.prefix "isAltitudeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links a base map to an object georeferencing.rdfs:comment : Questa proprietà collega una base cartografica alla georeferenziazione di un oggetto.</para>
    ///   <para>rdfs:label : is base map ofrdfs:label : è base cartografica di</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isBaseMapOf">a-loc:isBaseMapOf</a>
    /// </summary>
    let isBaseMapOf = _prefixId.prefix "isBaseMapOf"
    /// <summary>
    ///   <para>rdfs:comment : This property links the municipality to which the cadastral map is registered, as attested by the cadastre, to a cadastral identity of an entity.rdfs:comment : Questa proprietà collega il comune a cui è intestato il foglio di mappa catastale, riportato nella forma attestata nel catasto all'identità catastale di un'entità.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is cadastral city ofrdfs:label : è città catastale di</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCadastralCityOf">a-loc:isCadastralCityOf</a>
    /// </summary>
    let isCadastralCityOf = _prefixId.prefix "isCadastralCityOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità catastale, intesa come oggetti spaziali, a alla sua identità catastale.rdfs:comment : This property links a cadastral entity, understood as spatial object, to its cadastral identity.</para>
    ///   <para>rdfs:label : is cadastral entity ofrdfs:label : è entità catastale di</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCadastralEntityOf">a-loc:isCadastralEntityOf</a>
    /// </summary>
    let isCadastralEntityOf = _prefixId.prefix "isCadastralEntityOf"
    /// <summary>
    ///   <para>rdfs:label : è identitià catastale dirdfs:label : is cadastral identity of</para>
    ///   <para>rdfs:comment : This property links all the cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc., to a cultural property.rdfs:comment : Questa proprietà collega l'insieme delle informazioni catastali, relative a una delle sue localizzazioni (storica, attuale, di rinvenimento, ecc.), a un bene culturale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCadastralIdentityOf">a-loc:isCadastralIdentityOf</a>
    /// </summary>
    let isCadastralIdentityOf = _prefixId.prefix "isCadastralIdentityOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is cadastre type ofrdfs:label : è tipo di catasto di</para>
    ///   <para>rdfs:comment : Questa proprietà collega un tipo di catasto (ad es. catasto terreni, catasto fabbricati, catasto misto) a una identità catastale relativa a un'entità.rdfs:comment : This property relates the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre) to a cadastral identity of an entity.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCadastreTypeOf">a-loc:isCadastreTypeOf</a>
    /// </summary>
    let isCadastreTypeOf = _prefixId.prefix "isCadastreTypeOf"

    /// <summary>
    ///   <para>rdfs:comment : This property relates a clerical administrative area (e.g. a diocese) to its address.rdfs:comment : Questa proprietà collega un'area amministrativa ecclesiastica (ad es. una diocesi) al suo indirizzo.</para>
    ///   <para>rdfs:label : is clerical administrative area ofrdfs:label : è area amministrativa ecclesiastica di</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isClericalAdministrativeAreaOf">a-loc:isClericalAdministrativeAreaOf</a>
    /// </summary>
    let isClericalAdministrativeAreaOf =
        _prefixId.prefix "isClericalAdministrativeAreaOf"

    /// <summary>
    ///   <para>rdfs:label : è continente dirdfs:label : is continent of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un continente alla localizzazione di un'entità.rdfs:comment : This property links the continent to the location of an entity.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isContinentOf">a-loc:isContinentOf</a>
    /// </summary>
    let isContinentOf = _prefixId.prefix "isContinentOf"

    /// <summary>
    ///   <para>rdfs:label : è definizione del contenitore giuridico dirdfs:label : is cultural institute or site definition of</para>
    ///   <para>rdfs:comment : Questa proprietà collega la definizione del contenitore giuridico alla sua tipologia.rdfs:comment : This property links the definition of a cultural institute or site to its type.</para>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteDefinitionOf">a-loc:isCulturalInstituteOrSiteDefinitionOf</a>
    /// </summary>
    let isCulturalInstituteOrSiteDefinitionOf =
        _prefixId.prefix "isCulturalInstituteOrSiteDefinitionOf"

    /// <summary>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : instabile</para>
    ///   <para>rdfs:label : è luogo o istituto della cultura dirdfs:label : is cultural institute or site of</para>
    ///   <para>rdfs:comment : Questa proprietà collega un luogo o istituto della cultura (contenitore giuridico) al bene culturalerdfs:comment : This property links a cultural institute or site to a cultural property</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteOf">a-loc:isCulturalInstituteOrSiteOf</a>
    /// </summary>
    let isCulturalInstituteOrSiteOf = _prefixId.prefix "isCulturalInstituteOrSiteOf"

    /// <summary>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : instabile</para>
    ///   <para>rdfs:comment : This property links the specification of a cultural institute or site to one of its type.rdfs:comment : Questa proprietà collega le specifiche sulla qualificazione del contenitore giuridico alla sua tipologia.</para>
    ///   <para>rdfs:label : è specificazione di contenitore giuridicordfs:label : is cultural institute or site specification of</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteSpecificationOf">a-loc:isCulturalInstituteOrSiteSpecificationOf</a>
    /// </summary>
    let isCulturalInstituteOrSiteSpecificationOf =
        _prefixId.prefix "isCulturalInstituteOrSiteSpecificationOf"

    /// <summary>
    ///   <para>owl:versionInfo : instabileowl:versionInfo : unstable</para>
    ///   <para>rdfs:label : is cultural institute or site type ofrdfs:label : è tipo di contenitore giuridico di</para>
    ///   <para>rdfs:comment : This property connects the type of cultural institute or site to a cultural institute or site, to allow its correct and precise identification.rdfs:comment : Questa proprietà collega il tipo di contenitore giuridico a un contenitore giuridico, per permetterne la corretta e precisa individuazione.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteTypeof">a-loc:isCulturalInstituteOrSiteTypeof</a>
    /// </summary>
    let isCulturalInstituteOrSiteTypeof =
        _prefixId.prefix "isCulturalInstituteOrSiteTypeof"

    /// <summary>
    ///   <para>rdfs:label : è indirizzo del bene culturalerdfs:label : is cultural property address of</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega l'indirizzo della localizzazione fisica attuale, al momento della catalogazione, con il bene culturale catalogato.rdfs:comment : This property represents the relationship that links the address of the current physical location at the cataloging time to the catalogued cultural property.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isCulturalPropertyAddressOf">a-loc:isCulturalPropertyAddressOf</a>
    /// </summary>
    let isCulturalPropertyAddressOf = _prefixId.prefix "isCulturalPropertyAddressOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega il metodo utilizzato per il posizionamento alla georeferenziazione.rdfs:comment : This property links the method used for the object positioning to the georeferencing.</para>
    ///   <para>rdfs:label : è metodo di georeferenziazione dirdfs:label : is geometry method of</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isGeometryMethodOf">a-loc:isGeometryMethodOf</a>
    /// </summary>
    let isGeometryMethodOf = _prefixId.prefix "isGeometryMethodOf"
    /// <summary>
    ///   <para>rdfs:label : è tecnica di georeferenziazione dirdfs:label : is geometry technique of</para>
    ///   <para>rdfs:comment : Questa proprietà collega la tecnica di georeferenziazione alla georeferenziazione.rdfs:comment : This property links the georeferencing technique to the georeferencing.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isGeometryTechniqueOf">a-loc:isGeometryTechniqueOf</a>
    /// </summary>
    let isGeometryTechniqueOf = _prefixId.prefix "isGeometryTechniqueOf"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links a governmental administrative area to its address.rdfs:comment : Questa proprietà collega un'area di appartenenza amministrativa al suo indirizzo.</para>
    ///   <para>rdfs:label : is governmental administrative area ofrdfs:label : è area di appartenenza amministrativa di</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isGovernmentalAdministrativeAreaOf">a-loc:isGovernmentalAdministrativeAreaOf</a>
    /// </summary>
    let isGovernmentalAdministrativeAreaOf =
        _prefixId.prefix "isGovernmentalAdministrativeAreaOf"

    /// <summary>
    ///   <para>rdfs:comment : This property links a historical-geographical area to its address.rdfs:comment : Questa proprietà collega un'area storico-geografica al suo indirizzo.</para>
    ///   <para>rdfs:label : è area storica dirdfs:label : is historical area of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isHistoricalAreaOf">a-loc:isHistoricalAreaOf</a>
    /// </summary>
    let isHistoricalAreaOf = _prefixId.prefix "isHistoricalAreaOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è luogo inrdfs:label : is location in</para>
    ///   <para>rdfs:comment : Questa proprietà collega un luogo fisico a una localizzazione tipizzata nel tempo che si riferisce a quel luogo.rdfs:comment : This property relates a geographical feature to a time indexed typed location that refers to that feature.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isLocationIn">a-loc:isLocationIn</a>
    /// </summary>
    let isLocationIn = _prefixId.prefix "isLocationIn"
    /// <summary>
    ///   <para>rdfs:label : is referred location type ofrdfs:label : è tipo di localizzazione cui si riferisce</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links the role of a localization (i.e current physical location, previous location, finding location, etc.) to an entity referring to it (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity).rdfs:comment : Questa proprietà collega il ruolo della localizzazione (fisica attuale, precedente, di rinvenimento, ecc.) all'entità cui si riferisce, per esempio un situazione in cui un luogo riveste un certo ruolo nei confronti di un bene culturale in un intervallo di tempo, o una georeferenziazione, o un'identità catastale.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isLocationTypeOf">a-loc:isLocationTypeOf</a>
    /// </summary>
    let isLocationTypeOf = _prefixId.prefix "isLocationTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is old town administrative type ofrdfs:label : è tipo amministrativo del centro storico</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega il tipo di carattere amministrativo alle informazioni relative al suo centro storico.rdfs:comment : This property connects the administrative type with the information related to its historical center.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isOldTownAdministrativeTypeOf">a-loc:isOldTownAdministrativeTypeOf</a>
    /// </summary>
    let isOldTownAdministrativeTypeOf = _prefixId.prefix "isOldTownAdministrativeTypeOf"
    /// <summary>
    ///   <para>rdfs:label : è definizione del contenitore fisico dirdfs:label : is site definition of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega la definizione del contenitore fisico alla sua tipologia.rdfs:comment : This property links the definition of a physical container to of its type.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isSiteDefinitionOf">a-loc:isSiteDefinitionOf</a>
    /// </summary>
    let isSiteDefinitionOf = _prefixId.prefix "isSiteDefinitionOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un contenitore fisico a una localizzazione tipizzata nel tempo.rdfs:comment : This property relates a cultural site to the time indexed typed location.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is site inrdfs:label : è contenitore fisico in</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isSiteIn">a-loc:isSiteIn</a>
    /// </summary>
    let isSiteIn = _prefixId.prefix "isSiteIn"
    /// <summary>
    ///   <para>rdfs:label : is site specification ofrdfs:label : è specificazione di contenitore fisico</para>
    ///   <para>rdfs:comment : This property links the specification of a physical container to one of its type.rdfs:comment : Questa proprietà collega le specifiche sulla qualificazione del contenitore fisico alla sua tipologia.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isSiteSpecificationOf">a-loc:isSiteSpecificationOf</a>
    /// </summary>
    let isSiteSpecificationOf = _prefixId.prefix "isSiteSpecificationOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è tipo di contenitore fisico dirdfs:label : is site type of</para>
    ///   <para>rdfs:comment : This property connects the type of physical container to a physical container (Site), to allow its correct and precise identification.rdfs:comment : Questa proprietà collega il tipo di contenitore fisico a un contenitore fisico, per permetterne la corretta e precisa individuazione.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isSiteTypeOf">a-loc:isSiteTypeOf</a>
    /// </summary>
    let isSiteTypeOf = _prefixId.prefix "isSiteTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è ambiente dirdfs:label : is stratigraphic area of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has stratigraphic area".rdfs:comment : Questa è la proprietà inversa di "ha ambiente".</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isStratigraphicAreaOf">a-loc:isStratigraphicAreaOf</a>
    /// </summary>
    let isStratigraphicAreaOf = _prefixId.prefix "isStratigraphicAreaOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has stratigraphic room".rdfs:comment : Questa è la proprietà inversa di "ha settore".</para>
    ///   <para>rdfs:label : is stratigraphic room ofrdfs:label : è settore di</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isStratigraphicRoomOf">a-loc:isStratigraphicRoomOf</a>
    /// </summary>
    let isStratigraphicRoomOf = _prefixId.prefix "isStratigraphicRoomOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is stratigraphic square ofrdfs:label : è quadrato di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has stratigraphic square".rdfs:comment : Questa è la proprietà inversa di "ha quadrato".</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isStratigraphicSquareOf">a-loc:isStratigraphicSquareOf</a>
    /// </summary>
    let isStratigraphicSquareOf = _prefixId.prefix "isStratigraphicSquareOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un'area di appartenenza territoriale, che può non coincidere con l'area amministrativa, al suo indirizzo.rdfs:comment : This property links a territorial area (which may not coincide with the administrative area) to which a cultural property belongs to its address.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è area di appartenenza territoriale dirdfs:label : is territorial area of</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isTerritorialAreaOf">a-loc:isTerritorialAreaOf</a>
    /// </summary>
    let isTerritorialAreaOf = _prefixId.prefix "isTerritorialAreaOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una ripartizione territoriale interna a un'area territoriale a un indirizzo.rdfs:comment : This property links a territorial division within a territorial area to an address.</para>
    ///   <para>rdfs:label : è ripartizione territoriale dirdfs:label : is territorial division of</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isTerritorialDivisionOf">a-loc:isTerritorialDivisionOf</a>
    /// </summary>
    let isTerritorialDivisionOf = _prefixId.prefix "isTerritorialDivisionOf"
    /// <summary>
    ///   <para>rdfs:label : è localizzazione tipizzata nel tempordfs:label : is time indexed typed location of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property links a typified location over time to an entity.rdfs:comment : Questa proprietà collega una  localizzazione tipizzata nel tempo a un'entità.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isTimeIndexedTypedLocationOf">a-loc:isTimeIndexedTypedLocationOf</a>
    /// </summary>
    let isTimeIndexedTypedLocationOf = _prefixId.prefix "isTimeIndexedTypedLocationOf"
    /// <summary>
    ///   <para>rdfs:label : is toponym in time ofrdfs:label : è toponimo nel tempo di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà permette di collegare una denominazione che cambia nel tempo a un luogo.rdfs:comment : This property relates a toponym chianging over time to a geographical entity.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isToponymInTimeOf">a-loc:isToponymInTimeOf</a>
    /// </summary>
    let isToponymInTimeOf = _prefixId.prefix "isToponymInTimeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è tipo di contesto geografico dirdfs:label : is type of geographical context of</para>
    ///   <para>rdfs:comment : Questa proprietà permette di collegare tipo di contesto (urbano, suburbano, extraurbano, territoriale, subacqueo) all'entità che vi si trova.rdfs:comment : This property relates the type of context (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context) an entity where it is located.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isTypeOfContextOf">a-loc:isTypeOfContextOf</a>
    /// </summary>
    let isTypeOfContextOf = _prefixId.prefix "isTypeOfContextOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property connects the the urban area with the its old town.rdfs:comment : Questa proprietà collega la zona urbana con il suo centro storico.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : è area urbana dirdfs:label : is urban area of</para>
    ///   <a href="https://w3id.org/arco/ontology/location/isUrbanAreaOf">a-loc:isUrbanAreaOf</a>
    /// </summary>
    let isUrbanAreaOf = _prefixId.prefix "isUrbanAreaOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la coordinata y, ovvero la latitudine.rdfs:comment : This property represents the y coordinate, that is the latitude.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : latituderdfs:label : latitudine</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GEC/GECY - Normative precedenti: GP/GPD/GPDP/GPDPY; GA/GAD/GADP/GADPY; GL/GLD/GLDP/GLDPY</para>
    ///   <a href="https://w3id.org/arco/ontology/location/lat">a-loc:lat</a>
    /// </summary>
    let lat = _prefixId.prefix "lat"
    /// <summary>
    ///   <para>rdfs:label : location detailsrdfs:label : dettagli della localizzazione</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà è utilizzata per rappresentare informazioni sui percorsi che permettono l’accesso al bene o che lo delimitano, o ulteriori specifiche per la localizzazione del bene.rdfs:comment : This property is used to represent other paths and details about the cultural property location.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/PVC/PVCV</para>
    ///   <a href="https://w3id.org/arco/ontology/location/locationDetails">a-loc:locationDetails</a>
    /// </summary>
    let locationDetails = _prefixId.prefix "locationDetails"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the x coordinate, that is the longitude.rdfs:comment : Questa proprietà rappresenta la coordinata x, ovvero la longitudine.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : longituderdfs:label : longitudine</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GEC/GECX - Normative precedenti: GP/GPD/GPDP/GPDPX; GA/GAD/GADP/GADPX; GL/GLD/GLDP/GLDPX</para>
    ///   <a href="https://w3id.org/arco/ontology/location/long">a-loc:long</a>
    /// </summary>
    let long = _prefixId.prefix "long"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'altitudine massima assoluta rispetto al livello del mare.rdfs:comment : This property represents the absolute maximum altitude above sea level.</para>
    ///   <para>rdfs:label : maximum altituderdfs:label : altitudine massima</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTA/MTAX - Normative precedenti: GP/GPC/GPCS; GA/GAQS; GL/GLQ/GLQS</para>
    ///   <a href="https://w3id.org/arco/ontology/location/maxAlt">a-loc:maxAlt</a>
    /// </summary>
    let maxAlt = _prefixId.prefix "maxAlt"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'altitudine minima assoluta rispetto al livello del mare.rdfs:comment : This property represents the absolute minimum altitude above sea level.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTA/MTAM; versioni precedenti: GP/GPC/GPCI -GA/GAQ/GAQI - GL/GLQ/GLQI</para>
    ///   <para>rdfs:label : minimum altituderdfs:label : altitudine minima</para>
    ///   <a href="https://w3id.org/arco/ontology/location/minAlt">a-loc:minAlt</a>
    /// </summary>
    let minAlt = _prefixId.prefix "minAlt"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the type of point that georeferences the catalogued cultural property. The definition of the point type is not univocal and depends on the cultural property's type and conformation as well as on the type of location.rdfs:comment : Questa proprietà rappresenta il tipo di punto che georeferenzia il bene catalogato. La definizione del tipo di punto non è univoca e dipende dalla tipologia e dalla conformazione del bene e dal tipo di localizzazione.</para>
    ///   <para>ctlog:iccdNormTag : Normative precedenti alla 4.00: GP/GPC/GPCT</para>
    ///   <para>rdfs:label : tipo di puntordfs:label : point type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/location/pointType">a-loc:pointType</a>
    /// </summary>
    let pointType = _prefixId.prefix "pointType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTA/MTAR^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'altezza relativa dell'oggetto rispetto a un punto, un elemento o una situazione da specificare.rdfs:comment : This property represents the object relative height by reference to a point or an element or a situation to be specified.</para>
    ///   <para>rdfs:label : altitudine relativardfs:label : relative altitude</para>
    ///   <a href="https://w3id.org/arco/ontology/location/relativeAlt">a-loc:relativeAlt</a>
    /// </summary>
    let relativeAlt = _prefixId.prefix "relativeAlt"
    /// <summary>
    ///   <para>rdfs:label : identificativo del contenitore fisicordfs:label : site identifier</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: LC/LDC/LDCK; LA/PRC/PRCK</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property allows to associate a physical container to its code assigned by the ICCD.rdfs:comment : Questa proprietà permette di associare un contenitore fisico al codice assegnatogli dall'ICCD.</para>
    ///   <a href="https://w3id.org/arco/ontology/location/siteIdentifier">a-loc:siteIdentifier</a>
    /// </summary>
    let siteIdentifier = _prefixId.prefix "siteIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il sistema di riferimento utilizzato per la georeferenziazione (ad es. WGS84, WGS84 UTM32, ecc.).rdfs:comment : This property represents the reference system used for the object georeferencing (e.g. WGS84, WGS84 UTM32, etc.).</para>
    ///   <para>rdfs:label : spatial reference systemrdfs:label : sistema di riferimento</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: GE/GEP - Normative precedenti: GA/GAP; GL/GLP; GP/GPP</para>
    ///   <a href="https://w3id.org/arco/ontology/location/spatialReferenceSystem">a-loc:spatialReferenceSystem</a>
    /// </summary>
    let spatialReferenceSystem = _prefixId.prefix "spatialReferenceSystem"
