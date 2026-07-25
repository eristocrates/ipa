namespace https.w3id.org.arco.ontology.location.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module a_loc =
    let _namespace_iri = Namespace_Iri a_loc |> NamespaceIRI

    /// <summary>
    ///   <para>a-loc:isClericalAdministrativeAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a clerical administrative area (e.g. a diocese) to its address.</para>
    ///   <para>Questa proprietà collega un'area amministrativa ecclesiastica (ad es. una diocesi) al suo indirizzo.</para>
    /// labels<para>è area amministrativa ecclesiastica di</para><para>is clerical administrative area of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isClericalAdministrativeAreaOf">https://w3id.org/arco/ontology/location/isClericalAdministrativeAreaOf</seealso>
    let isClericalAdministrativeAreaOf =
        Prefixed_Name(a_loc, "isClericalAdministrativeAreaOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:Coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta l'insieme delle coordinate, geografiche o proiettate, che permettono la georeferenziazione di un oggetto. Per la georeferenziazione puntuale sarà presente soltanto una coppia di coordinate; per la georeferenziazione lineare e areale saranno presenti più coppie di coordinate che individuano i punti che definiscono la linea o l'area che rappresenta il bene.</para>
    ///   <para>This class represents the set of coordinates, geographic or projected, which allows the georeferencing of an object. For the punctual georeferencing there is only a pair of coordinates. For the linear and areal georeferencing there are more pairs of coordinates identifying those points of the line or area representing the object.</para>
    /// labels<para>Coordinates</para><para>Coordinate</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/Coordinates">https://w3id.org/arco/ontology/location/Coordinates</seealso>
    let Coordinates = Prefixed_Name(a_loc, "Coordinates") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasBaseMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una georeferenziazione di un oggetto alla base cartografica eventualmente utilizzata.</para>
    ///   <para>This property links an object georeferencing to the base map possibly used.</para>
    /// labels<para>ha base cartografica</para><para>has base map</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasBaseMap">https://w3id.org/arco/ontology/location/hasBaseMap</seealso>
    let hasBaseMap = Prefixed_Name(a_loc, "hasBaseMap") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isCadastralCityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega il comune a cui è intestato il foglio di mappa catastale, riportato nella forma attestata nel catasto all'identità catastale di un'entità.</para>
    ///   <para>This property links the municipality to which the cadastral map is registered, as attested by the cadastre, to a cadastral identity of an entity.</para>
    /// labels<para>è città catastale di</para><para>is cadastral city of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCadastralCityOf">https://w3id.org/arco/ontology/location/isCadastralCityOf</seealso>
    let isCadastralCityOf = Prefixed_Name(a_loc, "isCadastralCityOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasCadastralIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene culturale all'insieme delle informazioni catastali che lo riguardano, relativamente a una delle sue localizzazioni (storica, attuale, di rinvenimento, ecc.)</para>
    ///   <para>This property links a cultural property to all its cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc.</para>
    /// labels<para>has cadastral identity</para><para>ha identità catastale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCadastralIdentity">https://w3id.org/arco/ontology/location/hasCadastralIdentity</seealso>
    let hasCadastralIdentity =
        Prefixed_Name(a_loc, "hasCadastralIdentity") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasContinent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the location of an entity to the continent where it is located.</para>
    ///   <para>Questa proprietà collega la localizzazione di un'entità al continente in cui si trova.</para>
    /// labels<para>ha continente</para><para>has continent</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasContinent">https://w3id.org/arco/ontology/location/hasContinent</seealso>
    let hasContinent = Prefixed_Name(a_loc, "hasContinent") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCulturalInstituteOrSiteOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a cultural institute or site to a cultural property</para>
    ///   <para>Questa proprietà collega un luogo o istituto della cultura (contenitore giuridico) al bene culturale</para>
    /// labels<para>è luogo o istituto della cultura di</para><para>is cultural institute or site of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteOf">https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteOf</seealso>
    let isCulturalInstituteOrSiteOf =
        Prefixed_Name(a_loc, "isCulturalInstituteOrSiteOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasCulturalInstituteOrSiteDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the type of a cultural institute or site to one of its components, that is to the definition of its type.</para>
    ///   <para>Questa proprietà collega la tipologia di un contenitore giuridico a una delle sue componenti, cioè alla definizione della sua tipologia.</para>
    /// labels<para>has cultiral institute or site definition</para><para>ha definizione del contenitore giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteDefinition">https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteDefinition</seealso>
    let hasCulturalInstituteOrSiteDefinition =
        Prefixed_Name(a_loc, "hasCulturalInstituteOrSiteDefinition") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCulturalInstituteOrSiteSpecificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the specification of a cultural institute or site to one of its type.</para>
    ///   <para>Questa proprietà collega le specifiche sulla qualificazione del contenitore giuridico alla sua tipologia.</para>
    /// labels<para>is cultural institute or site specification of</para><para>è specificazione di contenitore giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteSpecificationOf">https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteSpecificationOf</seealso>
    let isCulturalInstituteOrSiteSpecificationOf =
        Prefixed_Name(a_loc, "isCulturalInstituteOrSiteSpecificationOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasCulturalInstituteOrSiteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un contenitore giuridico al tipo di contenitore giuridico, per permetterne la corretta e precisa individuazione.</para>
    ///   <para>This property connects a Cultural institute or site to its type, to allow its correct and precise identification.</para>
    /// labels<para>has cultural institute or site type</para><para>ha tipo di contenitore giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteType">https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteType</seealso>
    let hasCulturalInstituteOrSiteType =
        Prefixed_Name(a_loc, "hasCulturalInstituteOrSiteType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasCulturalPropertyAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un bene culturale all'indirizzo della sua localizzazione fisica attuale, al momento della catalogazione. La relazione fornisce una rappresentazione semplificata, con ridotta espressività, della localizzazione attuale del bene culturale, e provoca la perdita delle altre informazioni che riguardano la collocazione del bene (continente, eventuale contenitore fisico, collocazione specifica nel contenitore fisico, ecc.).</para>
    ///   <para>This property represents the relationship that links a cultural property to the address of its current physical location at the cataloging time. The report provides a simplified representation, with a reduced expressivity, of the current location of the cultural property, and it causes the loss of other information regarding its location (i.e. the continent, the possible physical container, the specific location in the physical container, etc.).</para>
    /// labels<para>indirizzo del bene culturale</para><para>cultural property address</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCulturalPropertyAddress">https://w3id.org/arco/ontology/location/hasCulturalPropertyAddress</seealso>
    let hasCulturalPropertyAddress =
        Prefixed_Name(a_loc, "hasCulturalPropertyAddress") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCulturalPropertyAddressOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega l'indirizzo della localizzazione fisica attuale, al momento della catalogazione, con il bene culturale catalogato.</para>
    ///   <para>This property represents the relationship that links the address of the current physical location at the cataloging time to the catalogued cultural property.</para>
    /// labels<para>is cultural property address of</para><para>è indirizzo del bene culturale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCulturalPropertyAddressOf">https://w3id.org/arco/ontology/location/isCulturalPropertyAddressOf</seealso>
    let isCulturalPropertyAddressOf =
        Prefixed_Name(a_loc, "isCulturalPropertyAddressOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasGeometryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a georeferencing to the method used for the object positioning.</para>
    ///   <para>Questa proprietà collega una georeferenziazione al metodo utilizzato per il posizionamento.</para>
    /// labels<para>ha metodo di georeferenziazione</para><para>has geometry method</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasGeometryMethod">https://w3id.org/arco/ontology/location/hasGeometryMethod</seealso>
    let hasGeometryMethod = Prefixed_Name(a_loc, "hasGeometryMethod") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasGovernmentalAdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links an address to a governmental administrative area.</para>
    ///   <para>Questa proprietà collega un indirizzo a un'area di appartenenza amministrativa.</para>
    /// labels<para>ha area di appartenenza amministrativa</para><para>has governamental administrative area</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasGovernmentalAdministrativeArea">https://w3id.org/arco/ontology/location/hasGovernmentalAdministrativeArea</seealso>
    let hasGovernmentalAdministrativeArea =
        Prefixed_Name(a_loc, "hasGovernmentalAdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isHistoricalAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un'area storico-geografica al suo indirizzo.</para>
    ///   <para>This property links a historical-geographical area to its address.</para>
    /// labels<para>is historical area of</para><para>è area storica di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isHistoricalAreaOf">https://w3id.org/arco/ontology/location/isHistoricalAreaOf</seealso>
    let isHistoricalAreaOf = Prefixed_Name(a_loc, "isHistoricalAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasSiteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property connects a physical container (Site) to its type, to allow its correct and precise identification.</para>
    ///   <para>Questa proprietà collega un contenitore fisico al tipo di contenitore fisico, per permetterne la corretta e precisa individuazione.</para>
    /// labels<para>ha tipo di contenitore fisico</para><para>has site type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasSiteType">https://w3id.org/arco/ontology/location/hasSiteType</seealso>
    let hasSiteType = Prefixed_Name(a_loc, "hasSiteType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isStratigraphicAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "has stratigraphic area".</para>
    ///   <para>Questa è la proprietà inversa di "ha ambiente".</para>
    /// labels<para>is stratigraphic area of</para><para>è ambiente di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isStratigraphicAreaOf">https://w3id.org/arco/ontology/location/isStratigraphicAreaOf</seealso>
    let isStratigraphicAreaOf =
        Prefixed_Name(a_loc, "isStratigraphicAreaOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasStratigraphicRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un saggio stratigrafico al settore in cui il saggio è stato effettuato.</para>
    ///   <para>This property relates a stratigraphic record to the room in which it took place.</para>
    /// labels<para>has stratigraphic room</para><para>ha settore</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasStratigraphicRoom">https://w3id.org/arco/ontology/location/hasStratigraphicRoom</seealso>
    let hasStratigraphicRoom =
        Prefixed_Name(a_loc, "hasStratigraphicRoom") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isStratigraphicRoomOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "has stratigraphic room".</para>
    ///   <para>Questa è la proprietà inversa di "ha settore".</para>
    /// labels<para>is stratigraphic room of</para><para>è settore di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isStratigraphicRoomOf">https://w3id.org/arco/ontology/location/isStratigraphicRoomOf</seealso>
    let isStratigraphicRoomOf =
        Prefixed_Name(a_loc, "isStratigraphicRoomOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasStratigraphicSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a stratigraphic record to the square in which it took place.</para>
    ///   <para>Questa proprietà collega un saggio stratigrafico al quadrato in un il saggio è stato effettuato.</para>
    /// labels<para>has stratigraphic square</para><para>ha quadrato</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasStratigraphicSquare">https://w3id.org/arco/ontology/location/hasStratigraphicSquare</seealso>
    let hasStratigraphicSquare =
        Prefixed_Name(a_loc, "hasStratigraphicSquare") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasTerritorialArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un indirizzo a un'area di appartenenza territoriale, che può non coincidere con l'area amministrativa.</para>
    ///   <para>This property links an address to a territorial area, which may not coincide with the administrative area, to which a cultural property belongs.</para>
    /// labels<para>ha area di appartenenza territoriale</para><para>has territorial area</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasTerritorialArea">https://w3id.org/arco/ontology/location/hasTerritorialArea</seealso>
    let hasTerritorialArea = Prefixed_Name(a_loc, "hasTerritorialArea") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isTerritorialAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un'area di appartenenza territoriale, che può non coincidere con l'area amministrativa, al suo indirizzo.</para>
    ///   <para>This property links a territorial area (which may not coincide with the administrative area) to which a cultural property belongs to its address.</para>
    /// labels<para>è area di appartenenza territoriale di</para><para>is territorial area of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isTerritorialAreaOf">https://w3id.org/arco/ontology/location/isTerritorialAreaOf</seealso>
    let isTerritorialAreaOf =
        Prefixed_Name(a_loc, "isTerritorialAreaOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasTerritorialDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un indirizzo a una ripartizione territoriale interna a un'area territoriale.</para>
    ///   <para>This property links an address to a territorial division within a territorial area.</para>
    /// labels<para>ha ripartizione territoriale</para><para>has territorial division</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasTerritorialDivision">https://w3id.org/arco/ontology/location/hasTerritorialDivision</seealso>
    let hasTerritorialDivision =
        Prefixed_Name(a_loc, "hasTerritorialDivision") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isTerritorialDivisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una ripartizione territoriale interna a un'area territoriale a un indirizzo.</para>
    ///   <para>This property links a territorial division within a territorial area to an address.</para>
    /// labels<para>è ripartizione territoriale di</para><para>is territorial division of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isTerritorialDivisionOf">https://w3id.org/arco/ontology/location/isTerritorialDivisionOf</seealso>
    let isTerritorialDivisionOf =
        Prefixed_Name(a_loc, "isTerritorialDivisionOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasToponymInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a geographical entity to a toponym chianging over time.</para>
    ///   <para>Questa proprietà permette di collegare un luogo a una denominazione che cambia nel tempo.</para>
    /// labels<para>ha toponimo nel tempo</para><para>has toponym in time</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasToponymInTime">https://w3id.org/arco/ontology/location/hasToponymInTime</seealso>
    let hasToponymInTime = Prefixed_Name(a_loc, "hasToponymInTime") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasTypeOfContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates an entity to the type of context where the cultural property is located (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context).</para>
    ///   <para>Questa proprietà permette di collegare un'entità al tipo di contesto (urbano, suburbano, extraurbano, territoriale, subacqueo) in cui si trova.</para>
    /// labels<para>has type of geographical context</para><para>ha tipo di contesto geografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasTypeOfContext">https://w3id.org/arco/ontology/location/hasTypeOfContext</seealso>
    let hasTypeOfContext = Prefixed_Name(a_loc, "hasTypeOfContext") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isUrbanAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property connects the the urban area with the its old town.</para>
    ///   <para>Questa proprietà collega la zona urbana con il suo centro storico.</para>
    /// labels<para>is urban area of</para><para>è area urbana di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isUrbanAreaOf">https://w3id.org/arco/ontology/location/isUrbanAreaOf</seealso>
    let isUrbanAreaOf = Prefixed_Name(a_loc, "isUrbanAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:locationDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare informazioni sui percorsi che permettono l’accesso al bene o che lo delimitano, o ulteriori specifiche per la localizzazione del bene.</para>
    ///   <para>This property is used to represent other paths and details about the cultural property location.</para>
    /// labels<para>dettagli della localizzazione</para><para>location details</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/locationDetails">https://w3id.org/arco/ontology/location/locationDetails</seealso>
    let locationDetails = Prefixed_Name(a_loc, "locationDetails") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:maxAlt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the absolute maximum altitude above sea level.</para>
    ///   <para>Questa proprietà rappresenta l'altitudine massima assoluta rispetto al livello del mare.</para>
    /// labels<para>altitudine massima</para><para>maximum altitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/maxAlt">https://w3id.org/arco/ontology/location/maxAlt</seealso>
    let maxAlt = Prefixed_Name(a_loc, "maxAlt") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:minAlt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the absolute minimum altitude above sea level.</para>
    ///   <para>Questa proprietà rappresenta l'altitudine minima assoluta rispetto al livello del mare.</para>
    /// labels<para>altitudine minima</para><para>minimum altitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/minAlt">https://w3id.org/arco/ontology/location/minAlt</seealso>
    let minAlt = Prefixed_Name(a_loc, "minAlt") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:pointType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta il tipo di punto che georeferenzia il bene catalogato. La definizione del tipo di punto non è univoca e dipende dalla tipologia e dalla conformazione del bene e dal tipo di localizzazione.</para>
    ///   <para>This property represents the type of point that georeferences the catalogued cultural property. The definition of the point type is not univocal and depends on the cultural property's type and conformation as well as on the type of location.</para>
    /// labels<para>tipo di punto</para><para>point type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/pointType">https://w3id.org/arco/ontology/location/pointType</seealso>
    let pointType = Prefixed_Name(a_loc, "pointType") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:relativeAlt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta l'altezza relativa dell'oggetto rispetto a un punto, un elemento o una situazione da specificare.</para>
    ///   <para>This property represents the object relative height by reference to a point or an element or a situation to be specified.</para>
    /// labels<para>altitudine relativa</para><para>relative altitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/relativeAlt">https://w3id.org/arco/ontology/location/relativeAlt</seealso>
    let relativeAlt = Prefixed_Name(a_loc, "relativeAlt") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:siteIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property allows to associate a physical container to its code assigned by the ICCD.</para>
    ///   <para>Questa proprietà permette di associare un contenitore fisico al codice assegnatogli dall'ICCD.</para>
    /// labels<para>identificativo del contenitore fisico</para><para>site identifier</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/siteIdentifier">https://w3id.org/arco/ontology/location/siteIdentifier</seealso>
    let siteIdentifier = Prefixed_Name(a_loc, "siteIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:spatialReferenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta il sistema di riferimento utilizzato per la georeferenziazione (ad es. WGS84, WGS84 UTM32, ecc.).</para>
    ///   <para>This property represents the reference system used for the object georeferencing (e.g. WGS84, WGS84 UTM32, etc.).</para>
    /// labels<para>spatial reference system</para><para>sistema di riferimento</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/spatialReferenceSystem">https://w3id.org/arco/ontology/location/spatialReferenceSystem</seealso>
    let spatialReferenceSystem =
        Prefixed_Name(a_loc, "spatialReferenceSystem") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isTypeOfContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà permette di collegare tipo di contesto (urbano, suburbano, extraurbano, territoriale, subacqueo) all'entità che vi si trova.</para>
    ///   <para>This property relates the type of context (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context) an entity where it is located.</para>
    /// labels<para>is type of geographical context of</para><para>è tipo di contesto geografico di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isTypeOfContextOf">https://w3id.org/arco/ontology/location/isTypeOfContextOf</seealso>
    let isTypeOfContextOf = Prefixed_Name(a_loc, "isTypeOfContextOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:UrbanContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/TypeOfContext</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This individual represents a specific type of context, that is the urban context where the cultural asset is located.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di contesto, ovvero il contesto urbano nel quale si trova il bene culturale.</para>
    /// labels<para>Contesto urbano</para><para>Urban context</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/UrbanContext">https://w3id.org/arco/ontology/location/UrbanContext</seealso>
    let UrbanContext = Prefixed_Name(a_loc, "UrbanContext") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:administrativeOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà associa il numero d'ordine che identifica una località intesa come unità amministrativa, ovvero un centro storico, una zona urbana e un settore.</para>
    ///   <para>This property associates the order number that identifies a location intended as an administrative unit, i.e. an old town, an urban area and a sector.</para>
    /// labels<para>Numero d'ordine amministrativo</para><para>Administrative order number</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/administrativeOrderNumber">https://w3id.org/arco/ontology/location/administrativeOrderNumber</seealso>
    let administrativeOrderNumber =
        Prefixed_Name(a_loc, "administrativeOrderNumber") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isStratigraphicSquareOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha quadrato".</para>
    ///   <para>This is the inverse property of "has stratigraphic square".</para>
    /// labels<para>is stratigraphic square of</para><para>è quadrato di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isStratigraphicSquareOf">https://w3id.org/arco/ontology/location/isStratigraphicSquareOf</seealso>
    let isStratigraphicSquareOf =
        Prefixed_Name(a_loc, "isStratigraphicSquareOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:UnderwaterContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/TypeOfContext</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Questo individuo rappresenta un particolare tipo di contesto, ovvero il contesto subacqueo nel quale si trova il bene culturale.</para>
    ///   <para>This individual represents a specific type of context, that is the underwater context where the cultural property is located.</para>
    /// labels<para>Underwater context</para><para>Contesto subacqueo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/UnderwaterContext">https://w3id.org/arco/ontology/location/UnderwaterContext</seealso>
    let UnderwaterContext = Prefixed_Name(a_loc, "UnderwaterContext") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:1.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/1.2">https://w3id.org/arco/ontology/location/1.2</seealso>
    let ``_1.2`` = Prefixed_Name(a_loc, "1.2") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:alt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the z coordinate of an object, which defines its altitude above sea level.</para>
    ///   <para>Questa proprietà rappresenta la coordinata z di un oggetto, che ne definisce l'altitudine rispetto al livello del mare.</para>
    /// labels<para>altitudine</para><para>altitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/alt">https://w3id.org/arco/ontology/location/alt</seealso>
    let alt = Prefixed_Name(a_loc, "alt") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isAltitudeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the georeferencing coordinates of the altitude to an object (Geometry).</para>
    ///   <para>Questa proprietà collega le coordinate relative alla georeferenziazione dell'altitudine a un oggetto (Geometry).</para>
    /// labels<para>è altitudine di</para><para>is altitude of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isAltitudeOf">https://w3id.org/arco/ontology/location/isAltitudeOf</seealso>
    let isAltitudeOf = Prefixed_Name(a_loc, "isAltitudeOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:LocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta il tipo di localizzazione di un bene culturale.</para>
    ///   <para>This class represents the type of location of a cultural property.</para>
    /// labels<para>Tipo di localizzazione</para><para>Location Type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/LocationType">https://w3id.org/arco/ontology/location/LocationType</seealso>
    let LocationType = Prefixed_Name(a_loc, "LocationType") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:Altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the altitude, that is the height of an object above the sea level, which can be specified as maximum, minimum and relative altitude.</para>
    ///   <para>Questa classe rappresenta l'altitudine, ovvero l'altezza di un oggetto rispetto al livello del mare, che può essere specificata da un'altitudine massima, minima, relativa.</para>
    /// labels<para>Altitudine</para><para>Altitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/Altitude">https://w3id.org/arco/ontology/location/Altitude</seealso>
    let Altitude = Prefixed_Name(a_loc, "Altitude") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega la georeferenziazione di un oggetto (Geometry) alle coordinate (x, y, z).</para>
    ///   <para>This property links the object georeferencing (Geometry) to its coordinates (x, y, z).</para>
    /// labels<para>has coordinates</para><para>ha coordinate</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCoordinates">https://w3id.org/arco/ontology/location/hasCoordinates</seealso>
    let hasCoordinates = Prefixed_Name(a_loc, "hasCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isSiteIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un contenitore fisico a una localizzazione tipizzata nel tempo.</para>
    ///   <para>This property relates a cultural site to the time indexed typed location.</para>
    /// labels<para>è contenitore fisico in</para><para>is site in</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isSiteIn">https://w3id.org/arco/ontology/location/isSiteIn</seealso>
    let isSiteIn = Prefixed_Name(a_loc, "isSiteIn") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:cadastreName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the designation of a historical cadastre.</para>
    ///   <para>Questa proprietà rappresenta la denominazione con cui è noto un catasto storico.</para>
    /// labels<para>denominazione del catasto</para><para>cadastre name</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/cadastreName">https://w3id.org/arco/ontology/location/cadastreName</seealso>
    let cadastreName = Prefixed_Name(a_loc, "cadastreName") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:culturalInstituteOrSiteIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà permette di associare un contenitore giuridico al codice assegnatogli dall'ICCD.</para>
    ///   <para>This property allows to associate a legal container to its code assigned by the ICCD.</para>
    /// labels<para>identificativo del contenitore giuridico</para><para>cultural institute or site identifier</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/culturalInstituteOrSiteIdentifier">https://w3id.org/arco/ontology/location/culturalInstituteOrSiteIdentifier</seealso>
    let culturalInstituteOrSiteIdentifier =
        Prefixed_Name(a_loc, "culturalInstituteOrSiteIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:districtNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the progressive number that identifies the district where the cultural property is located.</para>
    ///   <para>Questa proprietà rappresenta il numero progressivo che individua il settore dove si trova il bene culturale.</para>
    /// labels<para>Numero del settore</para><para>District number</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/districtNumber">https://w3id.org/arco/ontology/location/districtNumber</seealso>
    let districtNumber = Prefixed_Name(a_loc, "districtNumber") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isLocationIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un luogo fisico a una localizzazione tipizzata nel tempo che si riferisce a quel luogo.</para>
    ///   <para>This property relates a geographical feature to a time indexed typed location that refers to that feature.</para>
    /// labels<para>is location in</para><para>è luogo in</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isLocationIn">https://w3id.org/arco/ontology/location/isLocationIn</seealso>
    let isLocationIn = Prefixed_Name(a_loc, "isLocationIn") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:ArchivalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>This individual represents a specific type of location, that is the archival location.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero la localizzazione di archivio.</para>
    /// labels<para>Localizzazione di archivio</para><para>Archival location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ArchivalLocation">https://w3id.org/arco/ontology/location/ArchivalLocation</seealso>
    let ArchivalLocation = Prefixed_Name(a_loc, "ArchivalLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:CadastralEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a cadastral entity, which is intended as an object that can have a spatial representation related to the cadastral allocation.</para>
    ///   <para>Questa classe rappresenta un'entità catastale, intesa come un oggetto che può avere una rappresentazione spaziale, relativamente alla ripartizione catastale.</para>
    /// labels<para>Cadastral Entity</para><para>Entità catastale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CadastralEntity">https://w3id.org/arco/ontology/location/CadastralEntity</seealso>
    let CadastralEntity = Prefixed_Name(a_loc, "CadastralEntity") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:CadastralIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ICCD Normativa Traversale 4.00: CS; LS</para>
    ///   <para>Questa classe rappresenta l'identità catastale di un'entità, intesa come l'insieme delle informazioni di localizzazione che riguardano il bene con riferimento alla ripartizione catastale nazionale. L'identità catastale di un'entità può avere un riferimento cronologico, che indica l'epoca alla quale risalgono i dati catastali.</para>
    ///   <para>This class represents the cadastral identity of an entity, which is intended as a set of location information concerning the property with reference to the national cadastral allocation. The cadastral identity can have a chronological reference indicating the dating of cadastral data.</para>
    /// labels<para>Identità catastale</para><para>Cadastral identity</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CadastralIdentity">https://w3id.org/arco/ontology/location/CadastralIdentity</seealso>
    let CadastralIdentity = Prefixed_Name(a_loc, "CadastralIdentity") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasStratigraphicArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a stratigraphic record to the area in which it took place.</para>
    ///   <para>Questa proprietà collega un saggio stratigrafico all'ambiente in un il saggio è stato effettuato.</para>
    /// labels<para>has stratigraphic area</para><para>ha ambiente</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasStratigraphicArea">https://w3id.org/arco/ontology/location/hasStratigraphicArea</seealso>
    let hasStratigraphicArea =
        Prefixed_Name(a_loc, "hasStratigraphicArea") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:BaseMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the base map possibly used for georeferencing activities.</para>
    ///   <para>Questa classe rappresenta la base cartografica eventualmente utilizzata nelle attività di georeferenziazione.</para>
    /// labels<para>Base cartografica</para><para>Base map</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/BaseMap">https://w3id.org/arco/ontology/location/BaseMap</seealso>
    let BaseMap = Prefixed_Name(a_loc, "BaseMap") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:BuildingCadastre</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/CadastreType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/BuildingCadastre">https://w3id.org/arco/ontology/location/BuildingCadastre</seealso>
    let BuildingCadastre = Prefixed_Name(a_loc, "BuildingCadastre") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:CadastralFolio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a folio of a cadastral map, which contains one or more cadastral parcels.</para>
    ///   <para>Questa classe rappresenta un foglio di mappa catastale, in cui ricadono una o più particelle.</para>
    /// labels<para>Foglio di mappa catastale</para><para>Cadastral map folio</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CadastralFolio">https://w3id.org/arco/ontology/location/CadastralFolio</seealso>
    let CadastralFolio = Prefixed_Name(a_loc, "CadastralFolio") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasCadastralEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un'identità catastale di un'entità a una delle entità catastali, intese come oggetti spaziali, che la definiscono.</para>
    ///   <para>This property links a cadastral identity of an entity to one of the cadastral entities, understood as spatial objects, that define it.</para>
    /// labels<para>has cadastral entity</para><para>ha entità catastale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCadastralEntity">https://w3id.org/arco/ontology/location/hasCadastralEntity</seealso>
    let hasCadastralEntity = Prefixed_Name(a_loc, "hasCadastralEntity") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasCadastreType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una identità catastale relativa a un'entità al tipo di catasto (ad es. catasto terreni, catasto fabbricati, catasto misto).</para>
    ///   <para>This property relates a cadastral identity of an entity to the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).</para>
    /// labels<para>ha tipo di catasto</para><para>has cadastre type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCadastreType">https://w3id.org/arco/ontology/location/hasCadastreType</seealso>
    let hasCadastreType = Prefixed_Name(a_loc, "hasCadastreType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:CadastralUnitCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta una o più particelle catastali.</para>
    ///   <para>This class represents one or more cadastral parcels.</para>
    /// labels<para>Collezione di particelle catastali</para><para>Cadastral unit collection</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CadastralUnitCollection">https://w3id.org/arco/ontology/location/CadastralUnitCollection</seealso>
    let CadastralUnitCollection =
        Prefixed_Name(a_loc, "CadastralUnitCollection") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:ChiefTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/OldTownAdmistrativeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di riferimento amministrativo che caratterizza un centro storico, ovvero il capoluogo.</para>
    ///   <para>This individual represents a specific type of administrative reference that characterizes an old town, that is the chief town.</para>
    /// labels<para>Chief town</para><para>Capoluogo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ChiefTown">https://w3id.org/arco/ontology/location/ChiefTown</seealso>
    let ChiefTown = Prefixed_Name(a_loc, "ChiefTown") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:OldTownAdmistrativeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta le informazioni che precisano il carattere amministrativo del centro storico, che può essere: un capoluogo, una frazione, un centro inglobato o una località.</para>
    ///   <para>This class represents the information clarifying the administrative character of the old town, which may be: a chief town, a town fraction, an incorporated area or a locality.</para>
    /// labels<para>Tipo di carattere amministrativo del centro storico</para><para>Old town administrative type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/OldTownAdmistrativeType">https://w3id.org/arco/ontology/location/OldTownAdmistrativeType</seealso>
    let OldTownAdmistrativeType =
        Prefixed_Name(a_loc, "OldTownAdmistrativeType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a Continent.</para>
    ///   <para>Questa classe rappresenta un Continente.</para>
    /// labels<para>Continente</para><para>Continent</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/Continent">https://w3id.org/arco/ontology/location/Continent</seealso>
    let Continent = Prefixed_Name(a_loc, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the georeferencing coordinates of an object (Geometry) to its altitude.</para>
    ///   <para>Questa proprietà collega le coordinate relative alla georeferenziazione di un oggetto (Geometry) alla sua altitudine.</para>
    /// labels<para>ha altitudine</para><para>has altitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasAltitude">https://w3id.org/arco/ontology/location/hasAltitude</seealso>
    let hasAltitude = Prefixed_Name(a_loc, "hasAltitude") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:long</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta la coordinata x, ovvero la longitudine.</para>
    ///   <para>This property represents the x coordinate, that is the longitude.</para>
    /// labels<para>longitudine</para><para>longitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/long">https://w3id.org/arco/ontology/location/long</seealso>
    let long = Prefixed_Name(a_loc, "long") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isBaseMapOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a base map to an object georeferencing.</para>
    ///   <para>Questa proprietà collega una base cartografica alla georeferenziazione di un oggetto.</para>
    /// labels<para>è base cartografica di</para><para>is base map of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isBaseMapOf">https://w3id.org/arco/ontology/location/isBaseMapOf</seealso>
    let isBaseMapOf = Prefixed_Name(a_loc, "isBaseMapOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:CadastreType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).</para>
    ///   <para>Questa classe rappresenta il tipo di catasto (ad es. catasto terreni, catasto fabbricati, catasto misto).</para>
    /// labels<para>Tipo di catasto</para><para>Cadastre type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CadastreType">https://w3id.org/arco/ontology/location/CadastreType</seealso>
    let CadastreType = Prefixed_Name(a_loc, "CadastreType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasClericalAdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates an address to a clerical administrative area (e.g. a diocese).</para>
    ///   <para>Questa proprietà collega un indirizzo a un'area amministrativa ecclesiastica (ad es. una diocesi).</para>
    /// labels<para>ha area amministrativa ecclesiastica</para><para>has clerical administrative area</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasClericalAdministrativeArea">https://w3id.org/arco/ontology/location/hasClericalAdministrativeArea</seealso>
    let hasClericalAdministrativeArea =
        Prefixed_Name(a_loc, "hasClericalAdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasCulturalInstituteOrSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene culturale al luogo o istituto della cultura (contenitore giuridico) in cui è contenuta</para>
    ///   <para>This property links a cultural property to the cultural institute or site</para>
    ///   <para></para>
    /// labels<para>ha luogo o istituto della cultura</para><para>has cultural institute or site</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSite">https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSite</seealso>
    let hasCulturalInstituteOrSite =
        Prefixed_Name(a_loc, "hasCulturalInstituteOrSite") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCulturalInstituteOrSiteDefinitionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the definition of a cultural institute or site to its type.</para>
    ///   <para>Questa proprietà collega la definizione del contenitore giuridico alla sua tipologia.</para>
    /// labels<para>is cultural institute or site definition of</para><para>è definizione del contenitore giuridico di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteDefinitionOf">https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteDefinitionOf</seealso>
    let isCulturalInstituteOrSiteDefinitionOf =
        Prefixed_Name(a_loc, "isCulturalInstituteOrSiteDefinitionOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasCulturalInstituteOrSiteSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the type of a cultural institute or site to one of its components, that is to the specifications of its type.</para>
    ///   <para>Questa proprietà collega la tipologia di un contenitore giuridico a una delle sue componenti, cioè alle specifiche sulla sua tipologia.</para>
    /// labels<para>has cultural institute or site specification</para><para>ha qualificazione del contenitore giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteSpecification">https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteSpecification</seealso>
    let hasCulturalInstituteOrSiteSpecification =
        Prefixed_Name(a_loc, "hasCulturalInstituteOrSiteSpecification") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCulturalInstituteOrSiteTypeof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property connects the type of cultural institute or site to a cultural institute or site, to allow its correct and precise identification.</para>
    ///   <para>Questa proprietà collega il tipo di contenitore giuridico a un contenitore giuridico, per permetterne la corretta e precisa individuazione.</para>
    /// labels<para>is cultural institute or site type of</para><para>è tipo di contenitore giuridico di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteTypeof">https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteTypeof</seealso>
    let isCulturalInstituteOrSiteTypeof =
        Prefixed_Name(a_loc, "isCulturalInstituteOrSiteTypeof") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasTimeIndexedTypedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links an entity to its typified location over time.</para>
    ///   <para>Questa proprietà collega un'entità a una sua localizzazione tipizzata nel tempo.</para>
    /// labels<para>ha localizzazione tipizzata nel tempo</para><para>has time indexed typed location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasTimeIndexedTypedLocation">https://w3id.org/arco/ontology/location/hasTimeIndexedTypedLocation</seealso>
    let hasTimeIndexedTypedLocation =
        Prefixed_Name(a_loc, "hasTimeIndexedTypedLocation") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasGeometryTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una georeferenziazione alla tecnica di georeferenziazione.</para>
    ///   <para>This property links a georeferencing to the georeferencing technique.</para>
    /// labels<para>ha tecnica di georeferenziazione</para><para>has geometry technique</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasGeometryTechnique">https://w3id.org/arco/ontology/location/hasGeometryTechnique</seealso>
    let hasGeometryTechnique =
        Prefixed_Name(a_loc, "hasGeometryTechnique") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasHistoricalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links an address to a historical-geographical area.</para>
    ///   <para>Questa proprietà collega un indirizzo a un'area storico-geografica.</para>
    /// labels<para>has historical area</para><para>ha area storica</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasHistoricalArea">https://w3id.org/arco/ontology/location/hasHistoricalArea</seealso>
    let hasHistoricalArea = Prefixed_Name(a_loc, "hasHistoricalArea") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:BuildingAndLandCadastre</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/CadastreType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/BuildingAndLandCadastre">https://w3id.org/arco/ontology/location/BuildingAndLandCadastre</seealso>
    let BuildingAndLandCadastre =
        Prefixed_Name(a_loc, "BuildingAndLandCadastre") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCadastralEntityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un'entità catastale, intesa come oggetti spaziali, a alla sua identità catastale.</para>
    ///   <para>This property links a cadastral entity, understood as spatial object, to its cadastral identity.</para>
    /// labels<para>is cadastral entity of</para><para>è entità catastale di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCadastralEntityOf">https://w3id.org/arco/ontology/location/isCadastralEntityOf</seealso>
    let isCadastralEntityOf =
        Prefixed_Name(a_loc, "isCadastralEntityOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links an entity (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity) to the role of the localization referring to it (i.e current physical location, previous location, finding location, etc.).</para>
    ///   <para>Questa proprietà collega un'entità, per esempio un situazione in cui un luogo riveste un certo ruolo nei confronti di un bene culturale in un intervallo di tempo, o una georeferenziazione, o un'identità catastale al ruolo della localizzazione (fisica attuale, precedente, di rinvenimento, ecc.) cui si riferisce.</para>
    /// labels<para>ha tipo di localizzazione cui si riferisce</para><para>has referred location type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasLocationType">https://w3id.org/arco/ontology/location/hasLocationType</seealso>
    let hasLocationType = Prefixed_Name(a_loc, "hasLocationType") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasCadastralCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a cadastral identity of an entity to the municipality to which the cadastral map is registered, as attested by the cadastre.</para>
    ///   <para>Questa proprietà collega un'identità catastale di un'entità al comune a cui è intestato il foglio di mappa catastale, riportato nella forma attestata nel catasto.</para>
    /// labels<para>has cadastral city</para><para>ha città catastale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasCadastralCity">https://w3id.org/arco/ontology/location/hasCadastralCity</seealso>
    let hasCadastralCity = Prefixed_Name(a_loc, "hasCadastralCity") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCadastralIdentityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega l'insieme delle informazioni catastali, relative a una delle sue localizzazioni (storica, attuale, di rinvenimento, ecc.), a un bene culturale.</para>
    ///   <para>This property links all the cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc., to a cultural property.</para>
    /// labels<para>è identitià catastale di</para><para>is cadastral identity of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCadastralIdentityOf">https://w3id.org/arco/ontology/location/isCadastralIdentityOf</seealso>
    let isCadastralIdentityOf =
        Prefixed_Name(a_loc, "isCadastralIdentityOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isCadastreTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un tipo di catasto (ad es. catasto terreni, catasto fabbricati, catasto misto) a una identità catastale relativa a un'entità.</para>
    ///   <para>This property relates the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre) to a cadastral identity of an entity.</para>
    /// labels<para>è tipo di catasto di</para><para>is cadastre type of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isCadastreTypeOf">https://w3id.org/arco/ontology/location/isCadastreTypeOf</seealso>
    let isCadastreTypeOf = Prefixed_Name(a_loc, "isCadastreTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:CollectingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///
    /// labels<para>Collecting location</para><para>Luogo di raccolta</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CollectingLocation">https://w3id.org/arco/ontology/location/CollectingLocation</seealso>
    let CollectingLocation = Prefixed_Name(a_loc, "CollectingLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isContinentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un continente alla localizzazione di un'entità.</para>
    ///   <para>This property links the continent to the location of an entity.</para>
    /// labels<para>è continente di</para><para>is continent of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isContinentOf">https://w3id.org/arco/ontology/location/isContinentOf</seealso>
    let isContinentOf = Prefixed_Name(a_loc, "isContinentOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:areCoordinatesOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "has coordinates".</para>
    ///   <para>Questa è la proprietà inversa di "ha coordinate".</para>
    /// labels<para>are coordinates of</para><para>sono coordinate di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/areCoordinatesOf">https://w3id.org/arco/ontology/location/areCoordinatesOf</seealso>
    let areCoordinatesOf = Prefixed_Name(a_loc, "areCoordinatesOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:CulturalInstituteOrSiteDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the type definition of a cultural insititute or site.</para>
    ///   <para>Questa classe rappresenta la definizione della tipologia di un contenitore giuridico.</para>
    /// labels<para>Cultural Institute or Site Definition</para><para>Definizione di Contenitore Giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteDefinition">https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteDefinition</seealso>
    let CulturalInstituteOrSiteDefinition =
        Prefixed_Name(a_loc, "CulturalInstituteOrSiteDefinition") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:CurrentPhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>This individual represents a specific type of localization, that is the current physical location.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero la localizzazione fisica attuale.</para>
    /// labels<para>Localizzazione fisica attuale</para><para>Current Physical Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CurrentPhysicalLocation">https://w3id.org/arco/ontology/location/CurrentPhysicalLocation</seealso>
    let CurrentPhysicalLocation =
        Prefixed_Name(a_loc, "CurrentPhysicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:ExhibitionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero il luogo di esposizione.</para>
    ///   <para>This individual represents a specific type of localization, that is the exhibition location.</para>
    /// labels<para>Luogo di esposizione</para><para>Exhibition Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ExhibitionLocation">https://w3id.org/arco/ontology/location/ExhibitionLocation</seealso>
    let ExhibitionLocation = Prefixed_Name(a_loc, "ExhibitionLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:lat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the y coordinate, that is the latitude.</para>
    ///   <para>Questa proprietà rappresenta la coordinata y, ovvero la latitudine.</para>
    /// labels<para>latitudine</para><para>latitude</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/lat">https://w3id.org/arco/ontology/location/lat</seealso>
    let lat = Prefixed_Name(a_loc, "lat") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:CulturalInstituteOrSiteSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the type specification of a cultural insititute or site.</para>
    ///   <para>Questa classe rappresenta la specificazione della tipologia di un contenitore giuridico.</para>
    /// labels<para>Cultural Institute or Site Specification</para><para>Specificazione di Contenitore Giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteSpecification">https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteSpecification</seealso>
    let CulturalInstituteOrSiteSpecification =
        Prefixed_Name(a_loc, "CulturalInstituteOrSiteSpecification") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:CulturalInstituteOrSiteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la tipologia di un contenitore giuridico.</para>
    ///   <para>This class represents the type of a cultural insititute or site.</para>
    /// labels<para>Cultural Institute or Site type</para><para>Tipo di Contenitore Giuridico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteType">https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteType</seealso>
    let CulturalInstituteOrSiteType =
        Prefixed_Name(a_loc, "CulturalInstituteOrSiteType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isGovernmentalAdministrativeAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a governmental administrative area to its address.</para>
    ///   <para>Questa proprietà collega un'area di appartenenza amministrativa al suo indirizzo.</para>
    /// labels<para>è area di appartenenza amministrativa di</para><para>is governmental administrative area of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isGovernmentalAdministrativeAreaOf">https://w3id.org/arco/ontology/location/isGovernmentalAdministrativeAreaOf</seealso>
    let isGovernmentalAdministrativeAreaOf =
        Prefixed_Name(a_loc, "isGovernmentalAdministrativeAreaOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:ExtraurbanContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/TypeOfContext</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di contesto, ovvero il contesto extraurbano dove si trova il bene culturale.</para>
    ///   <para>This individual represents a specific type of context, that is the extra-urban context where the cultural property is located.</para>
    /// labels<para>Contesto extraurbano</para><para>Extra-urban context</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ExtraurbanContext">https://w3id.org/arco/ontology/location/ExtraurbanContext</seealso>
    let ExtraurbanContext = Prefixed_Name(a_loc, "ExtraurbanContext") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:TypeOfContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the type of geographical context where the cultural property is located: i.e. urban, suburban, extra-urban, territorial, underwater.</para>
    ///   <para>Questa classe rappresenta il tipo di contesto in cui si trova un bene culturale, che può essere urbano, suburbano, extraurbano, territoriale, subacqueo.</para>
    /// labels<para>Tipo di contesto geografico</para><para>Type of geographic context</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/TypeOfContext">https://w3id.org/arco/ontology/location/TypeOfContext</seealso>
    let TypeOfContext = Prefixed_Name(a_loc, "TypeOfContext") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:FindingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero il luogo di ritrovamento.</para>
    ///   <para>This individual represents a specific type of localization, that is the finding location.</para>
    /// labels<para>Luogo di reperimento</para><para>Finding Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/FindingLocation">https://w3id.org/arco/ontology/location/FindingLocation</seealso>
    let FindingLocation = Prefixed_Name(a_loc, "FindingLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:GeometryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the method used for the object positioning (i.e. exact, approximate, with a symbolic representation).</para>
    ///   <para>Questa classe rappresenta il metodo utilizzato per il posizionamento (esatto, approssimato, con rappresentazione simbolica).</para>
    /// labels<para>Metodo di posizionamento</para><para>Geometry method</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/GeometryMethod">https://w3id.org/arco/ontology/location/GeometryMethod</seealso>
    let GeometryMethod = Prefixed_Name(a_loc, "GeometryMethod") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isGeometryMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega il metodo utilizzato per il posizionamento alla georeferenziazione.</para>
    ///   <para>This property links the method used for the object positioning to the georeferencing.</para>
    /// labels<para>è metodo di georeferenziazione di</para><para>is geometry method of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isGeometryMethodOf">https://w3id.org/arco/ontology/location/isGeometryMethodOf</seealso>
    let isGeometryMethodOf = Prefixed_Name(a_loc, "isGeometryMethodOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:GeometryTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the technique of georeferencing, used for the acquisition of coordinates (i.e. survey from cartography with or without inspection, survey from aerial photos with or without inspection, satellite survey, traditional survey, survey via GPS, etc.).</para>
    ///   <para>Questa classe rappresenta la tecnica di georeferenziazione, utilizzata per l'acquisizione delle coordinate (rilievo da cartografia con sopralluogo, rilievo da cartografia senza sopralluogo, rilievo da foto aerea con sopralluogo, rilievo da foto aerea senza sopralluogo, rilievo da satellite, rilievo tradizionale, rilievo tramite GPS, rilievo tramite punti d'appoggio fiduciali o trigonometrici, stereofotogrammetria).</para>
    /// labels<para>Tecnica di georeferenziazione</para><para>Geometry technique</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/GeometryTechnique">https://w3id.org/arco/ontology/location/GeometryTechnique</seealso>
    let GeometryTechnique = Prefixed_Name(a_loc, "GeometryTechnique") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isGeometryTechniqueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the georeferencing technique to the georeferencing.</para>
    ///   <para>Questa proprietà collega la tecnica di georeferenziazione alla georeferenziazione.</para>
    /// labels<para>è tecnica di georeferenziazione di</para><para>is geometry technique of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isGeometryTechniqueOf">https://w3id.org/arco/ontology/location/isGeometryTechniqueOf</seealso>
    let isGeometryTechniqueOf =
        Prefixed_Name(a_loc, "isGeometryTechniqueOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:HistoricalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero la localizzazione storica.</para>
    ///   <para>This individual represents a specific type of localization, that is the historical location.</para>
    /// labels<para>Localizzazione storica</para><para>Historical Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/HistoricalLocation">https://w3id.org/arco/ontology/location/HistoricalLocation</seealso>
    let HistoricalLocation = Prefixed_Name(a_loc, "HistoricalLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:IncorporatedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/OldTownAdmistrativeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This individual represents a specific type of administrative reference that characterizes the old town, that is the denomination of 'incorporated area'.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di riferimento amministrativo che caratterizza un centro storico, ovvero la denominazione di 'centro inglobato'.</para>
    /// labels<para>Incorporated area</para><para>Centro inglobato</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/IncorporatedArea">https://w3id.org/arco/ontology/location/IncorporatedArea</seealso>
    let IncorporatedArea = Prefixed_Name(a_loc, "IncorporatedArea") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:LandCadastre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/CadastreType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/LandCadastre">https://w3id.org/arco/ontology/location/LandCadastre</seealso>
    let LandCadastre = Prefixed_Name(a_loc, "LandCadastre") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:LastLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>Replaced by https://w3id.org/arco/ontology/location/PreviousLocation</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero il luogo di provenienza o collocazione precedente.</para>
    ///   <para>This individual represents a specific type of location, that is the place of origin or last location.</para>
    /// labels<para>Luogo di provenienza / Collocazione precedente</para><para>Place of Origin / Last Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/LastLocation">https://w3id.org/arco/ontology/location/LastLocation</seealso>
    let LastLocation = Prefixed_Name(a_loc, "LastLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:Locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/OldTownAdmistrativeType</para>
    ///   <para>This individual represents a specific type of administrative reference that characterizes the old town, that is the locality.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di riferimento amministrativo che caratterizza il centro storico, ovvero la località.</para>
    /// labels<para>Località</para><para>Locality</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/Locality">https://w3id.org/arco/ontology/location/Locality</seealso>
    let Locality = Prefixed_Name(a_loc, "Locality") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isLocationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the role of a localization (i.e current physical location, previous location, finding location, etc.) to an entity referring to it (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity).</para>
    ///   <para>Questa proprietà collega il ruolo della localizzazione (fisica attuale, precedente, di rinvenimento, ecc.) all'entità cui si riferisce, per esempio un situazione in cui un luogo riveste un certo ruolo nei confronti di un bene culturale in un intervallo di tempo, o una georeferenziazione, o un'identità catastale.</para>
    /// labels<para>è tipo di localizzazione cui si riferisce</para><para>is referred location type of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isLocationTypeOf">https://w3id.org/arco/ontology/location/isLocationTypeOf</seealso>
    let isLocationTypeOf = Prefixed_Name(a_loc, "isLocationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:NeighbouringCadastralEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta le entità spaziali (particelle, strade, corsi d'acqua, ecc.) confinanti con una o più particelle catastali.</para>
    ///   <para>This class represents spatial entities (i.e. roads, waterways, etc.) that border one or more cadastral parcels.</para>
    /// labels<para>Neighbouring cadastral entity</para><para>Elemento di confine</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/NeighbouringCadastralEntity">https://w3id.org/arco/ontology/location/NeighbouringCadastralEntity</seealso>
    let NeighbouringCadastralEntity =
        Prefixed_Name(a_loc, "NeighbouringCadastralEntity") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:ObservationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>This individual represents a specific type of location, that is the location of observation.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero il luogo di rilevamento.</para>
    /// labels<para>Luogo di rilevamento</para><para>Observation Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ObservationLocation">https://w3id.org/arco/ontology/location/ObservationLocation</seealso>
    let ObservationLocation =
        Prefixed_Name(a_loc, "ObservationLocation") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:OldTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the information describing the old town where the cultural property is located.</para>
    ///   <para>Questa classe rappresenta le informazioni che descrivono il centro storico in cui si trova il bene culturale.</para>
    /// labels<para>Centro storico</para><para>Old town</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/OldTown">https://w3id.org/arco/ontology/location/OldTown</seealso>
    let OldTown = Prefixed_Name(a_loc, "OldTown") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasUrbanArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega il centro storico con la zona urbana che ne fa parte.</para>
    ///   <para>This property connects the old town with the urban area that is part of it.</para>
    /// labels<para>ha zona urbana</para><para>has urban area</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasUrbanArea">https://w3id.org/arco/ontology/location/hasUrbanArea</seealso>
    let hasUrbanArea = Prefixed_Name(a_loc, "hasUrbanArea") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:UrbanArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta le informazioni relative alla denominazione della zona urbana che fa parte del centro storico dove si trova il bene culturale.</para>
    ///   <para>This class represents the informations on the denomination of the urban area that is part of the old town where the cultural property is located.</para>
    /// labels<para>Zona urbana</para><para>Urban area</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/UrbanArea">https://w3id.org/arco/ontology/location/UrbanArea</seealso>
    let UrbanArea = Prefixed_Name(a_loc, "UrbanArea") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasOldTownAdministrativeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un centro storico con le informazioni relative al tipo del suo carattere amministrativo.</para>
    ///   <para>This property connects a historical center with information related to its administrative type.</para>
    /// labels<para>Tipo amministrativo del centro storico</para><para>Old town administrative type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasOldTownAdministrativeType">https://w3id.org/arco/ontology/location/hasOldTownAdministrativeType</seealso>
    let hasOldTownAdministrativeType =
        Prefixed_Name(a_loc, "hasOldTownAdministrativeType") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isOldTownAdministrativeTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega il tipo di carattere amministrativo alle informazioni relative al suo centro storico.</para>
    ///   <para>This property connects the administrative type with the information related to its historical center.</para>
    /// labels<para>è tipo amministrativo del centro storico</para><para>is old town administrative type of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isOldTownAdministrativeTypeOf">https://w3id.org/arco/ontology/location/isOldTownAdministrativeTypeOf</seealso>
    let isOldTownAdministrativeTypeOf =
        Prefixed_Name(a_loc, "isOldTownAdministrativeTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:PreviousLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di localizzazione, ovvero il luogo di provenienza o collocazione precedente.</para>
    ///   <para>This individual represents a specific type of location, that is the place of origin or previous location.</para>
    /// labels<para>Luogo di provenienza / Collocazione precedente</para><para>Place of Origin / Previous Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/PreviousLocation">https://w3id.org/arco/ontology/location/PreviousLocation</seealso>
    let PreviousLocation = Prefixed_Name(a_loc, "PreviousLocation") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:ProductionRealizationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This individual represents a specific type of location, that is the production or realization location.</para>
    ///   <para>Questo individuo rappresenta un tipo specifico di posizione, ovvero il luogo di produzione o realizzazione.</para>
    /// labels<para>Luogo di produzione / realizzazione</para><para>Production or Realization Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ProductionRealizationLocation">https://w3id.org/arco/ontology/location/ProductionRealizationLocation</seealso>
    let ProductionRealizationLocation =
        Prefixed_Name(a_loc, "ProductionRealizationLocation") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:ShootingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This individual represents a specific type of localization, that is the shooting location.</para>
    ///   <para>Questo individuo rappresenta un tipo specifico di posizione, ovvero il luogo della ripresa.</para>
    /// labels<para>Luogo della ripresa</para><para>Shooting Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ShootingLocation">https://w3id.org/arco/ontology/location/ShootingLocation</seealso>
    let ShootingLocation = Prefixed_Name(a_loc, "ShootingLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:SiteDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la definizione della tipologia di un contenitore fisico.</para>
    ///   <para>This class represents the type definition of a physical container.</para>
    /// labels<para>Definizione di Contenitore Fisico</para><para>Site Definition</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/SiteDefinition">https://w3id.org/arco/ontology/location/SiteDefinition</seealso>
    let SiteDefinition = Prefixed_Name(a_loc, "SiteDefinition") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:SiteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the type of a physical container, i.e. it contains adjectives or phrases that specify, integrate or characterize the physical container from the point of view of the legal-administrative or functional condition.</para>
    ///   <para>Questa classe rappresenta il tipo di contenitore fisico, cioè la tipologia del contenitore fisico ed eventuali aggettivi o locuzioni che precisano, integrano o caratterizzano il contenitore fisico dal punto di vista della condizione giuridico-amministrativa o funzionale.</para>
    /// labels<para>Tipo di Contenitore Fisico</para><para>Site Type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/SiteType">https://w3id.org/arco/ontology/location/SiteType</seealso>
    let SiteType = Prefixed_Name(a_loc, "SiteType") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isSiteDefinitionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega la definizione del contenitore fisico alla sua tipologia.</para>
    ///   <para>This property links the definition of a physical container to of its type.</para>
    /// labels<para>è definizione del contenitore fisico di</para><para>is site definition of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isSiteDefinitionOf">https://w3id.org/arco/ontology/location/isSiteDefinitionOf</seealso>
    let isSiteDefinitionOf = Prefixed_Name(a_loc, "isSiteDefinitionOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:SiteSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents specifications about the physical container, i.e. the adjective or the phrase that with respect to the Site Definition specifies, integrates or characterizes the physical container from the point of view of the legal-administrative or functional condition.</para>
    ///   <para>Questa classe rappresenta specifiche sulla qualificazione del contenitore fisico, cioè l'aggettivo o la locuzione che, rispetto alla Site Definition, precisa, integra o caratterizza il contenitore fisico dal punto di vista della condizione giuridico-amministrativa o funzionale.</para>
    /// labels<para>Qualificazione del Contenitore Fisico</para><para>Site Specification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/SiteSpecification">https://w3id.org/arco/ontology/location/SiteSpecification</seealso>
    let SiteSpecification = Prefixed_Name(a_loc, "SiteSpecification") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isSiteSpecificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega le specifiche sulla qualificazione del contenitore fisico alla sua tipologia.</para>
    ///   <para>This property links the specification of a physical container to one of its type.</para>
    /// labels<para>è specificazione di contenitore fisico</para><para>is site specification of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isSiteSpecificationOf">https://w3id.org/arco/ontology/location/isSiteSpecificationOf</seealso>
    let isSiteSpecificationOf =
        Prefixed_Name(a_loc, "isSiteSpecificationOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isSiteTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property connects the type of physical container to a physical container (Site), to allow its correct and precise identification.</para>
    ///   <para>Questa proprietà collega il tipo di contenitore fisico a un contenitore fisico, per permetterne la corretta e precisa individuazione.</para>
    /// labels<para>è tipo di contenitore fisico di</para><para>is site type of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isSiteTypeOf">https://w3id.org/arco/ontology/location/isSiteTypeOf</seealso>
    let isSiteTypeOf = Prefixed_Name(a_loc, "isSiteTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:hasSiteDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega la tipologia di un contenitore fisico a una delle sue componenti, cioè alla definizione della sua tipologia.</para>
    ///   <para>This property links the type of a physical container to one of its components, that is to the definition of its type.</para>
    /// labels<para>ha definizione del contenitore fisico</para><para>has site definition</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasSiteDefinition">https://w3id.org/arco/ontology/location/hasSiteDefinition</seealso>
    let hasSiteDefinition = Prefixed_Name(a_loc, "hasSiteDefinition") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:hasSiteSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the type of a physical container to one of its components, that is to the specifications of its type.</para>
    ///   <para>Questa proprietà collega la tipologia di un contenitore fisico a una delle sue componenti, cioè alle specifiche sulla sua tipologia.</para>
    /// labels<para>ha qualificazione del contenitore fisico</para><para>has site specification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/hasSiteSpecification">https://w3id.org/arco/ontology/location/hasSiteSpecification</seealso>
    let hasSiteSpecification =
        Prefixed_Name(a_loc, "hasSiteSpecification") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:StorageLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>This individual represents a specific type of localization, that is the storage location.</para>
    ///   <para>Questo individuo rappresenta un tipo specifico di localizzazione, ovvero il luogo di deposito.</para>
    /// labels<para>Luogo di deposito</para><para>Storage Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/StorageLocation">https://w3id.org/arco/ontology/location/StorageLocation</seealso>
    let StorageLocation = Prefixed_Name(a_loc, "StorageLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:SubjectLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/LocationType</para>
    ///   <para>Questo individuo rappresenta un tipo specifico di localizzazione, ovvero l'area rappresentata.</para>
    ///   <para>This individual represents a specific type of localization, that is the subject location.</para>
    /// labels<para>Area rappresentata</para><para>Subject Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/SubjectLocation">https://w3id.org/arco/ontology/location/SubjectLocation</seealso>
    let SubjectLocation = Prefixed_Name(a_loc, "SubjectLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:SuburbanContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/location/TypeOfContext</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di contesto geografico, ovvero un contesto suburbano che si trova nella zona intermedia tra il contesto urbano e quello extraurbano.</para>
    ///   <para>This individual represents a specific type of geographical context, that is a suburban context, which is located in the intermediate area between the urban and extraurban context.</para>
    /// labels<para>Contesto suburbano</para><para>Suburban context</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/SuburbanContext">https://w3id.org/arco/ontology/location/SuburbanContext</seealso>
    let SuburbanContext = Prefixed_Name(a_loc, "SuburbanContext") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:TerritorialContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/TypeOfContext</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This individual represents a specific type of context, i.e. the territorial context where the cultural property is located.</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di contesto, ovvero il contesto territoriale in cui si trova il bene culturale.</para>
    /// labels<para>Contesto territoriale</para><para>Territorial context</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/TerritorialContext">https://w3id.org/arco/ontology/location/TerritorialContext</seealso>
    let TerritorialContext = Prefixed_Name(a_loc, "TerritorialContext") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:TimeIndexedTypedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta una localizzazione di un bene culturale, inserita in un arco temporale e qualificata in base al ruolo che la localizzazione riveste nei confronti del bene culturale.</para>
    ///   <para>This class represents a localization of a cultural property, within a timeframe and qualified according to the role that the localization plays in relation to the cultural property.</para>
    /// labels<para>Localizzazione tipizzata nel tempo</para><para>Time Indexed Typed Location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/TimeIndexedTypedLocation">https://w3id.org/arco/ontology/location/TimeIndexedTypedLocation</seealso>
    let TimeIndexedTypedLocation =
        Prefixed_Name(a_loc, "TimeIndexedTypedLocation") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:isTimeIndexedTypedLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a typified location over time to an entity.</para>
    ///   <para>Questa proprietà collega una  localizzazione tipizzata nel tempo a un'entità.</para>
    /// labels<para>è localizzazione tipizzata nel tempo</para><para>is time indexed typed location of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isTimeIndexedTypedLocationOf">https://w3id.org/arco/ontology/location/isTimeIndexedTypedLocationOf</seealso>
    let isTimeIndexedTypedLocationOf =
        Prefixed_Name(a_loc, "isTimeIndexedTypedLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>a-loc:atLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una localizzazione tipizzata nel tempo al luogo cui si riferisce.</para>
    ///   <para>This property links a typed location over time to its related geographical entity.</para>
    /// labels<para>presso luogo</para><para>at location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/atLocation">https://w3id.org/arco/ontology/location/atLocation</seealso>
    let atLocation = Prefixed_Name(a_loc, "atLocation") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:atSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a typified location over time to its physical container (Site).</para>
    ///   <para>Questa proprietà collega una localizzazione tipizzata nel tempo al contenitore fisico cui si riferisce.</para>
    /// labels<para>presso contenitore fisico</para><para>at site</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/atSite">https://w3id.org/arco/ontology/location/atSite</seealso>
    let atSite = Prefixed_Name(a_loc, "atSite") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:ToponymInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents other place's designations changing over time.</para>
    ///   <para>Questa classe rappresenta eventuali altre denominazioni del luogo, che cambiano nel tempo.</para>
    /// labels<para>Toponimo nel tempo</para><para>Toponym in time</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/ToponymInTime">https://w3id.org/arco/ontology/location/ToponymInTime</seealso>
    let ToponymInTime = Prefixed_Name(a_loc, "ToponymInTime") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:isToponymInTimeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà permette di collegare una denominazione che cambia nel tempo a un luogo.</para>
    ///   <para>This property relates a toponym chianging over time to a geographical entity.</para>
    /// labels<para>è toponimo nel tempo di</para><para>is toponym in time of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/isToponymInTimeOf">https://w3id.org/arco/ontology/location/isToponymInTimeOf</seealso>
    let isToponymInTimeOf = Prefixed_Name(a_loc, "isToponymInTimeOf") |> PrefixedName
    /// <summary>
    ///   <para>a-loc:TownFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/location/OldTownAdmistrativeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Questo individuo rappresenta uno specifico tipo di riferimento amministrativo che caratterizza centro storico, ovvero la frazione cittadina.</para>
    ///   <para>This individual represents a specific type of administrative reference that characterizes the old town, i.e. the town fraction.</para>
    /// labels<para>Frazione del centro urbano</para><para>Town fraction</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location/TownFraction">https://w3id.org/arco/ontology/location/TownFraction</seealso>
    let TownFraction = Prefixed_Name(a_loc, "TownFraction") |> PrefixedName
