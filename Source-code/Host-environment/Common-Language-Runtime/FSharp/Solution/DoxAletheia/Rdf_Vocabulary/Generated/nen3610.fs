namespace http.modellen.geostandaarden.nl.def.nen3610.hash

open DoxAletheia.Rdf_Vocabulary

module nen3610 =
    let _namespace_name = "http://modellen.geostandaarden.nl/def/nen3610#"
    /// <summary>
    /// Planten die op natuurlijke wijze zijn ontstaan of door mensen zijn aangeplant.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Begroeiing"></see></summary>
    let Begroeiing = Namespaced_IRI.parse _namespace_name "Begroeiing" |> NamespacedName

    /// <summary>
    /// Geo-object dat zich geheel materieel manifesteert.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#ReeelObject"></see></summary>
    let ReeelObject =
        Namespaced_IRI.parse _namespace_name "ReeelObject" |> NamespacedName

    /// <summary>
    /// Bovenste deel van de aarde, exclusief oppervlaktewater.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Bodem"></see></summary>
    let Bodem = Namespaced_IRI.parse _namespace_name "Bodem" |> NamespacedName

    /// <summary>
    /// Gebouwd object dat direct of indirect met de bodem is verbonden en bedoeld is om ter plaatse te functioneren.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Constructie"></see></summary>
    let Constructie =
        Namespaced_IRI.parse _namespace_name "Constructie" |> NamespacedName

    /// <summary>
    /// Ruimte met een specifieke functie.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#FunctioneleRuimte"></see></summary>
    let FunctioneleRuimte =
        Namespaced_IRI.parse _namespace_name "FunctioneleRuimte" |> NamespacedName

    /// <summary>
    /// Geo-object dat zich geheel of gedeeltelijk niet-materieel manifesteert en dus slechts in abstracte en/of geregistreerde vorm bestaat.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#VirtueleRuimte"></see></summary>
    let VirtueleRuimte =
        Namespaced_IRI.parse _namespace_name "VirtueleRuimte" |> NamespacedName

    /// <summary>
    /// Overdekte en geheel of gedeeltelijk met wanden omsloten constructie bedoeld voor het in een afgeschermde omgeving onderbrengen van mensen, dieren of voorwerpen of voor de productie van goederen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Gebouw"></see></summary>
    let Gebouw = Namespaced_IRI.parse _namespace_name "Gebouw" |> NamespacedName
    /// <summary>
    /// Een fenomeen in de werkelijkheid dat direct of indirect is geassocieerd met een locatie relatief ten opzichte van de aarde.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#GeoObject"></see></summary>
    let GeoObject = Namespaced_IRI.parse _namespace_name "GeoObject" |> NamespacedName

    /// <summary>
    /// Ruimte die bekendstaat onder een vanuit de historie of het gebruik bekende benaming of een fysisch-geografische samenhang, al dan niet met zijn omgeving, kent.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#GeografischeRuimte"></see></summary>
    let GeografischeRuimte =
        Namespaced_IRI.parse _namespace_name "GeografischeRuimte" |> NamespacedName

    /// <summary>
    /// Klasse opgenomen om identificatie-attributen in te defini�ren.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#IdentificeerbaarObject"></see></summary>
    let IdentificeerbaarObject =
        Namespaced_IRI.parse _namespace_name "IdentificeerbaarObject" |> NamespacedName

    /// <summary>
    /// Ruimte waar een juridisch instrument beleid of regelgeving toepast.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#JuridischeRuimte"></see></summary>
    let JuridischeRuimte =
        Namespaced_IRI.parse _namespace_name "JuridischeRuimte" |> NamespacedName

    /// <summary>
    /// Civiel-technische constructie voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Kunstwerk"></see></summary>
    let Kunstwerk = Namespaced_IRI.parse _namespace_name "Kunstwerk" |> NamespacedName
    /// <summary>
    /// Een geheel van geleiders of een ruimte die voorzien is van ��n ommanteling en bestemd is voor transport van materie, data en/of energie.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Leiding"></see></summary>
    let Leiding = Namespaced_IRI.parse _namespace_name "Leiding" |> NamespacedName

    /// <summary>
    /// Verkeerruimte voor voertuigen die zich door de lucht verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Luchtvaartruimte"></see></summary>
    let Luchtvaartruimte =
        Namespaced_IRI.parse _namespace_name "Luchtvaartruimte" |> NamespacedName

    /// <summary>
    /// Transportruimte voor verkeer via land, water of lucht.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Verkeerruimte"></see></summary>
    let Verkeerruimte =
        Namespaced_IRI.parse _namespace_name "Verkeerruimte" |> NamespacedName

    /// <summary>
    /// Massa van water dat de bodem bedekt of in normale omstandigheden kan bedekken.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Oppervlaktewater"></see></summary>
    let Oppervlaktewater =
        Namespaced_IRI.parse _namespace_name "Oppervlaktewater" |> NamespacedName

    /// <summary>
    /// Vastlegging van een versie van een set gegevens.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Registratie"></see></summary>
    let Registratie =
        Namespaced_IRI.parse _namespace_name "Registratie" |> NamespacedName

    /// <summary>
    /// Op basis van wet- of regelgeving afgebakende ruimte die als eenheid geldt van politiek-bestuurlijke verantwoordelijkheid of voor bedrijfsvoering.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#RegistratieveRuimte"></see></summary>
    let RegistratieveRuimte =
        Namespaced_IRI.parse _namespace_name "RegistratieveRuimte" |> NamespacedName

    /// <summary>
    /// Verkeerruimte voor voertuigen die zich over water verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Scheepvaartruimte"></see></summary>
    let Scheepvaartruimte =
        Namespaced_IRI.parse _namespace_name "Scheepvaartruimte" |> NamespacedName

    /// <summary>
    /// Verkeerruimte voor voertuigen die zich over rails verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Spoorverkeerruimte"></see></summary>
    let Spoorverkeerruimte =
        Namespaced_IRI.parse _namespace_name "Spoorverkeerruimte" |> NamespacedName

    /// <summary>
    /// Natuurlijke of aangelegde transportlijnen of verbindingen met knooppunten waarlangs stromen zich kunnen verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Transportruimte"></see></summary>
    let Transportruimte =
        Namespaced_IRI.parse _namespace_name "Transportruimte" |> NamespacedName

    /// <summary>
    /// Een door egaliseren, verstevigen en/of verruwen voor het beoogde gebruik geschikt gemaakt oppervlak, bestaande uit in een of meer lagen over een bodem of onderliggende constructie aangelegd materiaal.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Verharding"></see></summary>
    let Verharding = Namespaced_IRI.parse _namespace_name "Verharding" |> NamespacedName

    /// <summary>
    /// Reden waarom een 'nil'-waarde is ingevuld.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#VoidReasonValue"></see></summary>
    let VoidReasonValue =
        Namespaced_IRI.parse _namespace_name "VoidReasonValue" |> NamespacedName

    /// <summary>
    /// Transportruimte waardoor water zich verplaatst.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Waterverplaatsingsruimte"></see></summary>
    let Waterverplaatsingsruimte =
        Namespaced_IRI.parse _namespace_name "Waterverplaatsingsruimte" |> NamespacedName

    /// <summary>
    /// Verkeerruimte voor weggebruikers die zich over wegen verplaatsen.
    /// <see href="http://modellen.geostandaarden.nl/def/nen3610#Wegverkeerruimte"></see></summary>
    let Wegverkeerruimte =
        Namespaced_IRI.parse _namespace_name "Wegverkeerruimte" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#beginGeldigheid"></see>
    /// </summary>
    let beginGeldigheid =
        Namespaced_IRI.parse _namespace_name "beginGeldigheid" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#domein"></see>
    /// </summary>
    let domein = Namespaced_IRI.parse _namespace_name "domein" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#eindGeldigheid"></see>
    /// </summary>
    let eindGeldigheid =
        Namespaced_IRI.parse _namespace_name "eindGeldigheid" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#eindRegistratie"></see>
    /// </summary>
    let eindRegistratie =
        Namespaced_IRI.parse _namespace_name "eindRegistratie" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#identificatie"></see>
    /// </summary>
    let identificatie =
        Namespaced_IRI.parse _namespace_name "identificatie" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#objectBeginTijd"></see>
    /// </summary>
    let objectBeginTijd =
        Namespaced_IRI.parse _namespace_name "objectBeginTijd" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#objectEindTijd"></see>
    /// </summary>
    let objectEindTijd =
        Namespaced_IRI.parse _namespace_name "objectEindTijd" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#registratiegegevens"></see>
    /// </summary>
    let registratiegegevens =
        Namespaced_IRI.parse _namespace_name "registratiegegevens" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#tijdstipRegistratie"></see>
    /// </summary>
    let tijdstipRegistratie =
        Namespaced_IRI.parse _namespace_name "tijdstipRegistratie" |> NamespacedName

    /// <summary>
    ///   <see href="http://modellen.geostandaarden.nl/def/nen3610#versie"></see>
    /// </summary>
    let versie = Namespaced_IRI.parse _namespace_name "versie" |> NamespacedName
