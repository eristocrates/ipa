namespace http.modellen.geostandaarden.nl.def.nen3610.hash

open DoxAletheia

module nen3610 =
    let _namespace_name = "http://modellen.geostandaarden.nl/def/nen3610#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Planten die op natuurlijke wijze zijn ontstaan of door mensen zijn aangeplant.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Begroeiing"></see></summary>
    let Begroeiing = _prefix "Begroeiing"
    /// <summary>
    /// Geo-object dat zich geheel materieel manifesteert.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#ReeelObject"></see></summary>
    let ReeelObject = _prefix "ReeelObject"
    /// <summary>
    /// Bovenste deel van de aarde, exclusief oppervlaktewater.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Bodem"></see></summary>
    let Bodem = _prefix "Bodem"
    /// <summary>
    /// Gebouwd object dat direct of indirect met de bodem is verbonden en bedoeld is om ter plaatse te functioneren.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Constructie"></see></summary>
    let Constructie = _prefix "Constructie"
    /// <summary>
    /// Ruimte met een specifieke functie.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#FunctioneleRuimte"></see></summary>
    let FunctioneleRuimte = _prefix "FunctioneleRuimte"
    /// <summary>
    /// Geo-object dat zich geheel of gedeeltelijk niet-materieel manifesteert en dus slechts in abstracte en/of geregistreerde vorm bestaat.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#VirtueleRuimte"></see></summary>
    let VirtueleRuimte = _prefix "VirtueleRuimte"
    /// <summary>
    /// Overdekte en geheel of gedeeltelijk met wanden omsloten constructie bedoeld voor het in een afgeschermde omgeving onderbrengen van mensen, dieren of voorwerpen of voor de productie van goederen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Gebouw"></see></summary>
    let Gebouw = _prefix "Gebouw"
    /// <summary>
    /// Een fenomeen in de werkelijkheid dat direct of indirect is geassocieerd met een locatie relatief ten opzichte van de aarde.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#GeoObject"></see></summary>
    let GeoObject = _prefix "GeoObject"
    /// <summary>
    /// Ruimte die bekendstaat onder een vanuit de historie of het gebruik bekende benaming of een fysisch-geografische samenhang, al dan niet met zijn omgeving, kent.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#GeografischeRuimte"></see></summary>
    let GeografischeRuimte = _prefix "GeografischeRuimte"
    /// <summary>
    /// Klasse opgenomen om identificatie-attributen in te defini�ren.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#IdentificeerbaarObject"></see></summary>
    let IdentificeerbaarObject = _prefix "IdentificeerbaarObject"
    /// <summary>
    /// Ruimte waar een juridisch instrument beleid of regelgeving toepast.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#JuridischeRuimte"></see></summary>
    let JuridischeRuimte = _prefix "JuridischeRuimte"
    /// <summary>
    /// Civiel-technische constructie voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Kunstwerk"></see></summary>
    let Kunstwerk = _prefix "Kunstwerk"
    /// <summary>
    /// Een geheel van geleiders of een ruimte die voorzien is van ��n ommanteling en bestemd is voor transport van materie, data en/of energie.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Leiding"></see></summary>
    let Leiding = _prefix "Leiding"
    /// <summary>
    /// Verkeerruimte voor voertuigen die zich door de lucht verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Luchtvaartruimte"></see></summary>
    let Luchtvaartruimte = _prefix "Luchtvaartruimte"
    /// <summary>
    /// Transportruimte voor verkeer via land, water of lucht.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Verkeerruimte"></see></summary>
    let Verkeerruimte = _prefix "Verkeerruimte"
    /// <summary>
    /// Massa van water dat de bodem bedekt of in normale omstandigheden kan bedekken.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Oppervlaktewater"></see></summary>
    let Oppervlaktewater = _prefix "Oppervlaktewater"
    /// <summary>
    /// Vastlegging van een versie van een set gegevens.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Registratie"></see></summary>
    let Registratie = _prefix "Registratie"
    /// <summary>
    /// Op basis van wet- of regelgeving afgebakende ruimte die als eenheid geldt van politiek-bestuurlijke verantwoordelijkheid of voor bedrijfsvoering.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#RegistratieveRuimte"></see></summary>
    let RegistratieveRuimte = _prefix "RegistratieveRuimte"
    /// <summary>
    /// Verkeerruimte voor voertuigen die zich over water verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Scheepvaartruimte"></see></summary>
    let Scheepvaartruimte = _prefix "Scheepvaartruimte"
    /// <summary>
    /// Verkeerruimte voor voertuigen die zich over rails verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Spoorverkeerruimte"></see></summary>
    let Spoorverkeerruimte = _prefix "Spoorverkeerruimte"
    /// <summary>
    /// Natuurlijke of aangelegde transportlijnen of verbindingen met knooppunten waarlangs stromen zich kunnen verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Transportruimte"></see></summary>
    let Transportruimte = _prefix "Transportruimte"
    /// <summary>
    /// Een door egaliseren, verstevigen en/of verruwen voor het beoogde gebruik geschikt gemaakt oppervlak, bestaande uit in een of meer lagen over een bodem of onderliggende constructie aangelegd materiaal.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Verharding"></see></summary>
    let Verharding = _prefix "Verharding"
    /// <summary>
    /// Reden waarom een 'nil'-waarde is ingevuld.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#VoidReasonValue"></see></summary>
    let VoidReasonValue = _prefix "VoidReasonValue"
    /// <summary>
    /// Transportruimte waardoor water zich verplaatst.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Waterverplaatsingsruimte"></see></summary>
    let Waterverplaatsingsruimte = _prefix "Waterverplaatsingsruimte"
    /// <summary>
    /// Verkeerruimte voor weggebruikers die zich over wegen verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Wegverkeerruimte"></see></summary>
    let Wegverkeerruimte = _prefix "Wegverkeerruimte"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#beginGeldigheid"></see>
    /// </summary>
    let beginGeldigheid = _prefix "beginGeldigheid"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#domein"></see>
    /// </summary>
    let domein = _prefix "domein"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#eindGeldigheid"></see>
    /// </summary>
    let eindGeldigheid = _prefix "eindGeldigheid"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#eindRegistratie"></see>
    /// </summary>
    let eindRegistratie = _prefix "eindRegistratie"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#identificatie"></see>
    /// </summary>
    let identificatie = _prefix "identificatie"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#objectBeginTijd"></see>
    /// </summary>
    let objectBeginTijd = _prefix "objectBeginTijd"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#objectEindTijd"></see>
    /// </summary>
    let objectEindTijd = _prefix "objectEindTijd"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#registratiegegevens"></see>
    /// </summary>
    let registratiegegevens = _prefix "registratiegegevens"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#tijdstipRegistratie"></see>
    /// </summary>
    let tijdstipRegistratie = _prefix "tijdstipRegistratie"
    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#versie"></see>
    /// </summary>
    let versie = _prefix "versie"
