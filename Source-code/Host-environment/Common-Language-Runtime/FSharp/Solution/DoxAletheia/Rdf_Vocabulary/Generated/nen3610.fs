namespace http.modellen.geostandaarden.nl.def.nen3610.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nen3610 =
    let _namespace_iri = Namespace_Iri nen3610 |> NamespaceIRI
    /// <summary>
    ///   <para>nen3610:Bodem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Bovenste deel van de aarde, exclusief oppervlaktewater.</para>
    /// labels<para>Bodem</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Bodem">http://modellen.geostandaarden.nl/def/nen3610#Bodem</seealso>
    let Bodem = Prefixed_Name(nen3610, "Bodem") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:VirtueleRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geo-object dat zich geheel of gedeeltelijk niet-materieel manifesteert en dus slechts in abstracte en/of geregistreerde vorm bestaat.</para>
    /// labels<para>VirtueleRuimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#VirtueleRuimte">http://modellen.geostandaarden.nl/def/nen3610#VirtueleRuimte</seealso>
    let VirtueleRuimte = Prefixed_Name(nen3610, "VirtueleRuimte") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Gebouw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Overdekte en geheel of gedeeltelijk met wanden omsloten constructie bedoeld voor het in een afgeschermde omgeving onderbrengen van mensen, dieren of voorwerpen of voor de productie van goederen.</para>
    /// labels<para>Gebouw</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Gebouw">http://modellen.geostandaarden.nl/def/nen3610#Gebouw</seealso>
    let Gebouw = Prefixed_Name(nen3610, "Gebouw") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:IdentificeerbaarObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Klasse opgenomen om identificatie-attributen in te defini�ren.</para>
    /// labels<para>IdentificeerbaarObject</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#IdentificeerbaarObject">http://modellen.geostandaarden.nl/def/nen3610#IdentificeerbaarObject</seealso>
    let IdentificeerbaarObject =
        Prefixed_Name(nen3610, "IdentificeerbaarObject") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:JuridischeRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ruimte waar een juridisch instrument beleid of regelgeving toepast.</para>
    /// labels<para>JuridischeRuimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#JuridischeRuimte">http://modellen.geostandaarden.nl/def/nen3610#JuridischeRuimte</seealso>
    let JuridischeRuimte = Prefixed_Name(nen3610, "JuridischeRuimte") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Kunstwerk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Civiel-technische constructie voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen.</para>
    /// labels<para>Kunstwerk</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Kunstwerk">http://modellen.geostandaarden.nl/def/nen3610#Kunstwerk</seealso>
    let Kunstwerk = Prefixed_Name(nen3610, "Kunstwerk") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Leiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een geheel van geleiders of een ruimte die voorzien is van ��n ommanteling en bestemd is voor transport van materie, data en/of energie.</para>
    /// labels<para>Leiding</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Leiding">http://modellen.geostandaarden.nl/def/nen3610#Leiding</seealso>
    let Leiding = Prefixed_Name(nen3610, "Leiding") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Begroeiing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Planten die op natuurlijke wijze zijn ontstaan of door mensen zijn aangeplant.</para>
    /// labels<para>Begroeiing</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Begroeiing">http://modellen.geostandaarden.nl/def/nen3610#Begroeiing</seealso>
    let Begroeiing = Prefixed_Name(nen3610, "Begroeiing") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:ReeelObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geo-object dat zich geheel materieel manifesteert.</para>
    /// labels<para>ReeelObject</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#ReeelObject">http://modellen.geostandaarden.nl/def/nen3610#ReeelObject</seealso>
    let ReeelObject = Prefixed_Name(nen3610, "ReeelObject") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Constructie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebouwd object dat direct of indirect met de bodem is verbonden en bedoeld is om ter plaatse te functioneren.</para>
    /// labels<para>Constructie</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Constructie">http://modellen.geostandaarden.nl/def/nen3610#Constructie</seealso>
    let Constructie = Prefixed_Name(nen3610, "Constructie") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:FunctioneleRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ruimte met een specifieke functie.</para>
    /// labels<para>FunctioneleRuimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#FunctioneleRuimte">http://modellen.geostandaarden.nl/def/nen3610#FunctioneleRuimte</seealso>
    let FunctioneleRuimte = Prefixed_Name(nen3610, "FunctioneleRuimte") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:GeografischeRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ruimte die bekendstaat onder een vanuit de historie of het gebruik bekende benaming of een fysisch-geografische samenhang, al dan niet met zijn omgeving, kent.</para>
    /// labels<para>GeografischeRuimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#GeografischeRuimte">http://modellen.geostandaarden.nl/def/nen3610#GeografischeRuimte</seealso>
    let GeografischeRuimte =
        Prefixed_Name(nen3610, "GeografischeRuimte") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:GeoObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een fenomeen in de werkelijkheid dat direct of indirect is geassocieerd met een locatie relatief ten opzichte van de aarde.</para>
    /// labels<para>GeoObject</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#GeoObject">http://modellen.geostandaarden.nl/def/nen3610#GeoObject</seealso>
    let GeoObject = Prefixed_Name(nen3610, "GeoObject") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:identificatie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>identificatie</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#identificatie">http://modellen.geostandaarden.nl/def/nen3610#identificatie</seealso>
    let identificatie = Prefixed_Name(nen3610, "identificatie") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:tijdstipRegistratie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>tijdstipRegistratie</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#tijdstipRegistratie">http://modellen.geostandaarden.nl/def/nen3610#tijdstipRegistratie</seealso>
    let tijdstipRegistratie =
        Prefixed_Name(nen3610, "tijdstipRegistratie") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:beginGeldigheid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>beginGeldigheid</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#beginGeldigheid">http://modellen.geostandaarden.nl/def/nen3610#beginGeldigheid</seealso>
    let beginGeldigheid = Prefixed_Name(nen3610, "beginGeldigheid") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:eindRegistratie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>eindRegistratie</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#eindRegistratie">http://modellen.geostandaarden.nl/def/nen3610#eindRegistratie</seealso>
    let eindRegistratie = Prefixed_Name(nen3610, "eindRegistratie") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:registratiegegevens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>registratiegegevens</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#registratiegegevens">http://modellen.geostandaarden.nl/def/nen3610#registratiegegevens</seealso>
    let registratiegegevens =
        Prefixed_Name(nen3610, "registratiegegevens") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:objectBeginTijd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>objectBeginTijd</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#objectBeginTijd">http://modellen.geostandaarden.nl/def/nen3610#objectBeginTijd</seealso>
    let objectBeginTijd = Prefixed_Name(nen3610, "objectBeginTijd") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Luchtvaartruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Verkeerruimte voor voertuigen die zich door de lucht verplaatsen.</para>
    /// labels<para>Luchtvaartruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Luchtvaartruimte">http://modellen.geostandaarden.nl/def/nen3610#Luchtvaartruimte</seealso>
    let Luchtvaartruimte = Prefixed_Name(nen3610, "Luchtvaartruimte") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Oppervlaktewater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Massa van water dat de bodem bedekt of in normale omstandigheden kan bedekken.</para>
    /// labels<para>Oppervlaktewater</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Oppervlaktewater">http://modellen.geostandaarden.nl/def/nen3610#Oppervlaktewater</seealso>
    let Oppervlaktewater = Prefixed_Name(nen3610, "Oppervlaktewater") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Verkeerruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transportruimte voor verkeer via land, water of lucht.</para>
    /// labels<para>Verkeerruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Verkeerruimte">http://modellen.geostandaarden.nl/def/nen3610#Verkeerruimte</seealso>
    let Verkeerruimte = Prefixed_Name(nen3610, "Verkeerruimte") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Registratie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vastlegging van een versie van een set gegevens.</para>
    /// labels<para>Registratie</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Registratie">http://modellen.geostandaarden.nl/def/nen3610#Registratie</seealso>
    let Registratie = Prefixed_Name(nen3610, "Registratie") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:RegistratieveRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Op basis van wet- of regelgeving afgebakende ruimte die als eenheid geldt van politiek-bestuurlijke verantwoordelijkheid of voor bedrijfsvoering.</para>
    /// labels<para>RegistratieveRuimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#RegistratieveRuimte">http://modellen.geostandaarden.nl/def/nen3610#RegistratieveRuimte</seealso>
    let RegistratieveRuimte =
        Prefixed_Name(nen3610, "RegistratieveRuimte") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:Scheepvaartruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Verkeerruimte voor voertuigen die zich over water verplaatsen.</para>
    /// labels<para>Scheepvaartruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Scheepvaartruimte">http://modellen.geostandaarden.nl/def/nen3610#Scheepvaartruimte</seealso>
    let Scheepvaartruimte = Prefixed_Name(nen3610, "Scheepvaartruimte") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:Spoorverkeerruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Verkeerruimte voor voertuigen die zich over rails verplaatsen.</para>
    /// labels<para>Spoorverkeerruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Spoorverkeerruimte">http://modellen.geostandaarden.nl/def/nen3610#Spoorverkeerruimte</seealso>
    let Spoorverkeerruimte =
        Prefixed_Name(nen3610, "Spoorverkeerruimte") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:Transportruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Natuurlijke of aangelegde transportlijnen of verbindingen met knooppunten waarlangs stromen zich kunnen verplaatsen.</para>
    /// labels<para>Transportruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Transportruimte">http://modellen.geostandaarden.nl/def/nen3610#Transportruimte</seealso>
    let Transportruimte = Prefixed_Name(nen3610, "Transportruimte") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:Verharding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een door egaliseren, verstevigen en/of verruwen voor het beoogde gebruik geschikt gemaakt oppervlak, bestaande uit in een of meer lagen over een bodem of onderliggende constructie aangelegd materiaal.</para>
    /// labels<para>Verharding</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Verharding">http://modellen.geostandaarden.nl/def/nen3610#Verharding</seealso>
    let Verharding = Prefixed_Name(nen3610, "Verharding") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:VoidReasonValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reden waarom een 'nil'-waarde is ingevuld.</para>
    /// labels<para>VoidReasonValue</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#VoidReasonValue">http://modellen.geostandaarden.nl/def/nen3610#VoidReasonValue</seealso>
    let VoidReasonValue = Prefixed_Name(nen3610, "VoidReasonValue") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:Waterverplaatsingsruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transportruimte waardoor water zich verplaatst.</para>
    /// labels<para>Waterverplaatsingsruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Waterverplaatsingsruimte">http://modellen.geostandaarden.nl/def/nen3610#Waterverplaatsingsruimte</seealso>
    let Waterverplaatsingsruimte =
        Prefixed_Name(nen3610, "Waterverplaatsingsruimte") |> PrefixedName

    /// <summary>
    ///   <para>nen3610:Wegverkeerruimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Verkeerruimte voor weggebruikers die zich over wegen verplaatsen.</para>
    /// labels<para>Wegverkeerruimte</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#Wegverkeerruimte">http://modellen.geostandaarden.nl/def/nen3610#Wegverkeerruimte</seealso>
    let Wegverkeerruimte = Prefixed_Name(nen3610, "Wegverkeerruimte") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:domein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>domein</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#domein">http://modellen.geostandaarden.nl/def/nen3610#domein</seealso>
    let domein = Prefixed_Name(nen3610, "domein") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:eindGeldigheid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>eindGeldigheid</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#eindGeldigheid">http://modellen.geostandaarden.nl/def/nen3610#eindGeldigheid</seealso>
    let eindGeldigheid = Prefixed_Name(nen3610, "eindGeldigheid") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:objectEindTijd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>objectEindTijd</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#objectEindTijd">http://modellen.geostandaarden.nl/def/nen3610#objectEindTijd</seealso>
    let objectEindTijd = Prefixed_Name(nen3610, "objectEindTijd") |> PrefixedName
    /// <summary>
    ///   <para>nen3610:versie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>versie</para></remarks>
    /// <seealso href="http://modellen.geostandaarden.nl/def/nen3610#versie">http://modellen.geostandaarden.nl/def/nen3610#versie</seealso>
    let versie = Prefixed_Name(nen3610, "versie") |> PrefixedName
