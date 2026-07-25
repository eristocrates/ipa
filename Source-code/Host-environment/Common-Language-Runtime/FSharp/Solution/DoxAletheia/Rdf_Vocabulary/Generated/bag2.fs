namespace http.bag.basisregistraties.overheid.nl.def.bag.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bag2 =
    let _namespace_iri = Namespace_Iri bag2 |> NamespaceIRI
    /// <summary>
    ///   <para>bag2:AdresseerbaarObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een adresseerbaar object is een object waaraan adressen ingevolge de basisregistratie adressen kunnen worden toegekend: een verblijfsobject, standplaats of ligplaats.</para>
    /// labels<para>Adresseerbaar object</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#AdresseerbaarObject">http://bag.basisregistraties.overheid.nl/def/bag#AdresseerbaarObject</seealso>
    let AdresseerbaarObject = Prefixed_Name(bag2, "AdresseerbaarObject") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Nummeraanduiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een nummeraanduiding is een door het bevoegde gemeentelijke orgaan als zodanig toegekende aanduiding van een verblijfsobject, een standplaats of een ligplaats. Het is het samenstel van huisnummer, huisletter en huisnummertoevoeging.</para>
    /// labels<para>Nummeraanduiding</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Nummeraanduiding">http://bag.basisregistraties.overheid.nl/def/bag#Nummeraanduiding</seealso>
    let Nummeraanduiding = Prefixed_Name(bag2, "Nummeraanduiding") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectKantoorfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor administratie.</para>
    /// labels<para>Verblijfsobject met kantoorfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectKantoorfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectKantoorfunctie</seealso>
    let VerblijfsobjectKantoorfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectKantoorfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectOverigeGebruiksfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Niet in dit lid benoemde gebruiksfunctie voor activiteiten waarbij het verblijven van mensen een ondergeschikte rol speelt.</para>
    /// labels<para>Verblijfsobject met overige gebruiksfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOverigeGebruiksfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOverigeGebruiksfunctie</seealso>
    let VerblijfsobjectOverigeGebruiksfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectOverigeGebruiksfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectWinkelfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het verhandelen van materialen, goederen of diensten.</para>
    /// labels<para>Verblijfsobject met winkelfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWinkelfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWinkelfunctie</seealso>
    let VerblijfsobjectWinkelfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectWinkelfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grondoppervlak in principe bedekt met water.</para>
    /// labels<para>Water</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Water">http://bag.basisregistraties.overheid.nl/def/bag#Water</seealso>
    let Water = Prefixed_Name(bag2, "Water") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Woonplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een woonplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen en van een naam voorzien gedeelte van het grondgebied van de gemeente</para>
    /// labels<para>Woonplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Woonplaats">http://bag.basisregistraties.overheid.nl/def/bag#Woonplaats</seealso>
    let Woonplaats = Prefixed_Name(bag2, "Woonplaats") |> PrefixedName
    /// <summary>
    ///   <para>bag2:aanduidingInactief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Voorkomens van objecten met een begindatum in de toekomst die zijn gemuteerd. Ze maken daarmee geen onderdeel meer uit van de levenscyclus.</para>
    /// labels<para>aanduiding inactief</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#aanduidingInactief">http://bag.basisregistraties.overheid.nl/def/bag#aanduidingInactief</seealso>
    let aanduidingInactief = Prefixed_Name(bag2, "aanduidingInactief") |> PrefixedName

    /// <summary>
    ///   <para>bag2:bijbehorendeWoonplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Een woonplaats van een nummeraanduiding is de woonplaats waarbinnen het object waaraan de nummeraanduiding is toegekend gelegen is indien die woonplaats afwijkt van de woonplaats waarbinnen de openbare ruimte waaraan de nummeraanduiding is gerelateerd gelegen is.</para>
    ///   <para>De woonplaats openbare ruimte is een unieke aanduiding van de woonplaats waarbinnen een openbare ruimte is gelegen.</para>
    /// labels<para>bijbehorende woonplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeWoonplaats">http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeWoonplaats</seealso>
    let bijbehorendeWoonplaats =
        Prefixed_Name(bag2, "bijbehorendeWoonplaats") |> PrefixedName

    /// <summary>
    ///   <para>bag2:eindGeldigheid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De einddatum van de geldigheid van een bepaalde combinatie van gegevens.</para>
    /// labels<para>eind geldigheid</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#eindGeldigheid">http://bag.basisregistraties.overheid.nl/def/bag#eindGeldigheid</seealso>
    let eindGeldigheid = Prefixed_Name(bag2, "eindGeldigheid") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Kunstwerk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Civiel-technisch werk voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen en niet bedoeld voor permanent menselijk verblijf.</para>
    /// labels<para>Kunstwerk</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Kunstwerk">http://bag.basisregistraties.overheid.nl/def/bag#Kunstwerk</seealso>
    let Kunstwerk = Prefixed_Name(bag2, "Kunstwerk") |> PrefixedName

    /// <summary>
    ///   <para>bag2:LandschappelijkGebied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definitie ontbreekt</para>
    /// labels<para>Landschappelijk gebied</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#LandschappelijkGebied">http://bag.basisregistraties.overheid.nl/def/bag#LandschappelijkGebied</seealso>
    let LandschappelijkGebied =
        Prefixed_Name(bag2, "LandschappelijkGebied") |> PrefixedName

    /// <summary>
    ///   <para>bag2:Ligplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een ligplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen plaats in het water al dan niet aangevuld met een op de oever aanwezig terrein of een gedeelte daarvan, die bestemd is voor het permanent afmeren van een voor woon-, bedrijfsmatige of recreatieve doeleinden geschikt vaartuig</para>
    /// labels<para>Ligplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Ligplaats">http://bag.basisregistraties.overheid.nl/def/bag#Ligplaats</seealso>
    let Ligplaats = Prefixed_Name(bag2, "Ligplaats") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Pand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een pand is een kleinste bij de totstandkoming functioneel en bouwkundig-constructief zelfstandige eenheid die direct en duurzaam met de aarde is verbonden en betreedbaar en afsluitbaar is</para>
    /// labels<para>Pand</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Pand">http://bag.basisregistraties.overheid.nl/def/bag#Pand</seealso>
    let Pand = Prefixed_Name(bag2, "Pand") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Standplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een standplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen terrein of gedeelte daarvan dat bestemd is voor het permanent plaatsen van een niet direct en niet duurzaam met de aarde verbonden en voor woon-, bedrijfsmatige, of recreatieve doeleinden geschikte ruimte</para>
    /// labels<para>Standplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Standplaats">http://bag.basisregistraties.overheid.nl/def/bag#Standplaats</seealso>
    let Standplaats = Prefixed_Name(bag2, "Standplaats") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Verblijfsobject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een verblijfsobject is een kleinste binnen één of meer panden gelegen en voor woon-, bedrijfsmatige, of recreatieve doeleinden geschikte eenheid van gebruik die ontsloten wordt via een eigen afsluitbare toegang vanaf de openbare weg, een erf of een gedeelde verkeersruimte, onderwerp kan zijn van goederenrechtelijke rechtshandelingen en in functioneel opzicht zelfstandig is</para>
    /// labels<para>Verblijfsobject</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Verblijfsobject">http://bag.basisregistraties.overheid.nl/def/bag#Verblijfsobject</seealso>
    let Verblijfsobject = Prefixed_Name(bag2, "Verblijfsobject") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectCelfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor dwangverblijf van mensen.</para>
    /// labels<para>Verblijfsobject met celfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectCelfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectCelfunctie</seealso>
    let VerblijfsobjectCelfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectCelfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectGezondheidszorgfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor medisch onderzoek, verpleging, verzorging of behandeling.</para>
    /// labels<para>Verblijfsobject met gezondheidszorgfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectGezondheidszorgfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectGezondheidszorgfunctie</seealso>
    let VerblijfsobjectGezondheidszorgfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectGezondheidszorgfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectIndustriefunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het bedrijfsmatig bewerken of opslaan van materialen en goederen, of voor agrarische doeleinden.</para>
    /// labels<para>Verblijfsobject met industriefunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectIndustriefunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectIndustriefunctie</seealso>
    let VerblijfsobjectIndustriefunctie =
        Prefixed_Name(bag2, "VerblijfsobjectIndustriefunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectSportfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het beoefenen van sport.</para>
    /// labels<para>Verblijfsobject met sportfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectSportfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectSportfunctie</seealso>
    let VerblijfsobjectSportfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectSportfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectWoonfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het wonen.</para>
    /// labels<para>Verblijfsobject met woonfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWoonfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWoonfunctie</seealso>
    let VerblijfsobjectWoonfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectWoonfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:Weg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebaand gedeelte voor het wegverkeer en vliegverkeer te land.</para>
    /// labels<para>Weg</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Weg">http://bag.basisregistraties.overheid.nl/def/bag#Weg</seealso>
    let Weg = Prefixed_Name(bag2, "Weg") |> PrefixedName
    /// <summary>
    ///   <para>bag2:aanduidingCorrectie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een inactief voorkomen als gevolg van synchronisatie tussen bronhouder en de Landelijke Voorziening BAG.</para>
    /// labels<para>aanduiding correctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#aanduidingCorrectie">http://bag.basisregistraties.overheid.nl/def/bag#aanduidingCorrectie</seealso>
    let aanduidingCorrectie = Prefixed_Name(bag2, "aanduidingCorrectie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:bijbehorendeOpenbareRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Openbare ruimte van een nummeraanduiding is de openbare ruimte waaraan een adresseerbaar object is gelegen en aan welk object de nummeraanduiding is gerelateerd</para>
    /// labels<para>bijbehorende openbare ruimte</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeOpenbareRuimte">http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeOpenbareRuimte</seealso>
    let bijbehorendeOpenbareRuimte =
        Prefixed_Name(bag2, "bijbehorendeOpenbareRuimte") |> PrefixedName

    /// <summary>
    ///   <para>bag2:bron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De relatie naar het brondocument dat ten grondslag ligt aan het voorkomen van een object.</para>
    /// labels<para>bron</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#bron">http://bag.basisregistraties.overheid.nl/def/bag#bron</seealso>
    let bron = Prefixed_Name(bag2, "bron") |> PrefixedName
    /// <summary>
    ///   <para>bag2:documentnummer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De unieke aanduiding van de vindplaats van een document binnen een organisatie.</para>
    /// labels<para>documentnummer</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#documentnummer">http://bag.basisregistraties.overheid.nl/def/bag#documentnummer</seealso>
    let documentnummer = Prefixed_Name(bag2, "documentnummer") |> PrefixedName
    /// <summary>
    ///   <para>bag2:geconstateerd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Geconstateerd is een aanduiding waarmee kan worden aangegeven dat een object in de registratie is opgenomen als gevolg van een feitelijke constatering, zonder dat er op het moment van opname sprake was van een regulier brondocument voor deze opname.</para>
    /// labels<para>geconstateerd</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#geconstateerd">http://bag.basisregistraties.overheid.nl/def/bag#geconstateerd</seealso>
    let geconstateerd = Prefixed_Name(bag2, "geconstateerd") |> PrefixedName
    /// <summary>
    ///   <para>bag2:geometriePand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    /// labels<para>geometrie pand</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#geometriePand">http://bag.basisregistraties.overheid.nl/def/bag#geometriePand</seealso>
    let geometriePand = Prefixed_Name(bag2, "geometriePand") |> PrefixedName

    /// <summary>
    ///   <para>bag2:geometrieStandplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    /// labels<para>geometrie standplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieStandplaats">http://bag.basisregistraties.overheid.nl/def/bag#geometrieStandplaats</seealso>
    let geometrieStandplaats =
        Prefixed_Name(bag2, "geometrieStandplaats") |> PrefixedName

    /// <summary>
    ///   <para>bag2:geometrieWoonplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    /// labels<para>geometrie woonplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieWoonplaats">http://bag.basisregistraties.overheid.nl/def/bag#geometrieWoonplaats</seealso>
    let geometrieWoonplaats = Prefixed_Name(bag2, "geometrieWoonplaats") |> PrefixedName
    /// <summary>
    ///   <para>bag2:hoofdadres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Een hoofdadres is het primaire adres van een adresseerbaar object</para>
    /// labels<para>hoofdadres</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#hoofdadres">http://bag.basisregistraties.overheid.nl/def/bag#hoofdadres</seealso>
    let hoofdadres = Prefixed_Name(bag2, "hoofdadres") |> PrefixedName
    /// <summary>
    ///   <para>bag2:huisletter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een huisletter is een authentiek gegeven met betrekking tot een nummeraanduiding. Het is de lettering van een adresseerbaar object</para>
    /// labels<para>huisletter</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#huisletter">http://bag.basisregistraties.overheid.nl/def/bag#huisletter</seealso>
    let huisletter = Prefixed_Name(bag2, "huisletter") |> PrefixedName
    /// <summary>
    ///   <para>bag2:identificatiecode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een identificatiecode van een standplaats is een authentiek gegeven en een unieke aanduiding van de standplaats.</para>
    ///   <para>Een identificatiecode van een verblijfsobject is een authentiek gegeven en een unieke aanduiding van het verblijfsobject.</para>
    ///   <para>Een identificatiecode van een nummeraanduiding is een authentiek gegeven en een unieke aanduiding van de nummeraanduiding.</para>
    ///   <para>Een identificatiecode van een woonplaats is een authentiek gegeven zoals opgenomen in de landelijke woonplaatsentabel</para>
    ///   <para>Een identificatiecode van een ligplaats is een authentiek gegeven en een unieke aanduiding van de ligplaats.</para>
    ///   <para>Een identificatiecode van een pand is een authentiek gegeven en een unieke aanduiding van het pand.</para>
    ///   <para>Een identificatiecode van een openbare ruimte is een authentiek gegeven en een unieke aanduiding van de openbare ruimte.</para>
    /// labels<para>identificatiecode</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#identificatiecode">http://bag.basisregistraties.overheid.nl/def/bag#identificatiecode</seealso>
    let identificatiecode = Prefixed_Name(bag2, "identificatiecode") |> PrefixedName
    /// <summary>
    ///   <para>bag2:naamOpenbareRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De naam van een openbare ruimte is de door het bevoegde gemeentelijke orgaan aan een openbare ruimte toegekende benaming en een authentiek gegeven</para>
    /// labels<para>naam openbare ruimte</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#naamOpenbareRuimte">http://bag.basisregistraties.overheid.nl/def/bag#naamOpenbareRuimte</seealso>
    let naamOpenbareRuimte = Prefixed_Name(bag2, "naamOpenbareRuimte") |> PrefixedName
    /// <summary>
    ///   <para>bag2:naamWoonplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De naam van een woonplaats is de door het bevoegde gemeentelijke orgaan aan een woonplaats toegekende benaming en een authentiek gegeven</para>
    /// labels<para>naam woonplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#naamWoonplaats">http://bag.basisregistraties.overheid.nl/def/bag#naamWoonplaats</seealso>
    let naamWoonplaats = Prefixed_Name(bag2, "naamWoonplaats") |> PrefixedName

    /// <summary>
    ///   <para>bag2:oorspronkelijkBouwjaar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een bouwjaar is een authentiek gegeven met betrekking tot het jaar dat een pand bouwkundig gereed is of wordt opgeleverd.</para>
    /// labels<para>oorspronkelijk bouwjaar</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#oorspronkelijkBouwjaar">http://bag.basisregistraties.overheid.nl/def/bag#oorspronkelijkBouwjaar</seealso>
    let oorspronkelijkBouwjaar =
        Prefixed_Name(bag2, "oorspronkelijkBouwjaar") |> PrefixedName

    /// <summary>
    ///   <para>bag2:oppervlakte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een oppervlakte is de gebruiksoppervlakte van een verblijfsobject en een authentiek gegeven</para>
    /// labels<para>oppervlakte</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#oppervlakte">http://bag.basisregistraties.overheid.nl/def/bag#oppervlakte</seealso>
    let oppervlakte = Prefixed_Name(bag2, "oppervlakte") |> PrefixedName
    /// <summary>
    ///   <para>bag2:postcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De postcode is een coderingssystematiek zoals ontwikkeld en beheerd door PostNL. Een postcode is een niet-authentiek gegeven met betrekking tot een nummeraanduiding</para>
    /// labels<para>postcode</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#postcode">http://bag.basisregistraties.overheid.nl/def/bag#postcode</seealso>
    let postcode = Prefixed_Name(bag2, "postcode") |> PrefixedName
    /// <summary>
    ///   <para>bag2:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De fase in de levenscyclus van een BAG object.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#status">http://bag.basisregistraties.overheid.nl/def/bag#status</seealso>
    let status = Prefixed_Name(bag2, "status") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Spoorbaan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebaand gedeelte voor het verkeer over rails.</para>
    /// labels<para>Spoorbaan</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Spoorbaan">http://bag.basisregistraties.overheid.nl/def/bag#Spoorbaan</seealso>
    let Spoorbaan = Prefixed_Name(bag2, "Spoorbaan") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Terrein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Door een fysiek voorkomen gekarakteriseerd zichtbaar begrensd stuk grond.</para>
    /// labels<para>Terrein</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Terrein">http://bag.basisregistraties.overheid.nl/def/bag#Terrein</seealso>
    let Terrein = Prefixed_Name(bag2, "Terrein") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectBijeenkomstfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het samenkomen van mensen voor kunst, cultuur, godsdienst, communicatie, kinderopvang, het verstrekken van consumpties voor het gebruik ter plaatse en het aanschouwen van sport.</para>
    /// labels<para>Verblijfsobject met bijeenkomstfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectBijeenkomstfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectBijeenkomstfunctie</seealso>
    let VerblijfsobjectBijeenkomstfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectBijeenkomstfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectOnderwijsfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het geven van onderwijs.</para>
    /// labels<para>Verblijfsobject met onderwijsfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOnderwijsfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOnderwijsfunctie</seealso>
    let VerblijfsobjectOnderwijsfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectOnderwijsfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:VerblijfsobjectLogiesfunctie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gebruiksfunctie voor het bieden van recreatief verblijf of tijdelijk onderdak aan mensen.</para>
    /// labels<para>Verblijfsobject met logiesfunctie</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectLogiesfunctie">http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectLogiesfunctie</seealso>
    let VerblijfsobjectLogiesfunctie =
        Prefixed_Name(bag2, "VerblijfsobjectLogiesfunctie") |> PrefixedName

    /// <summary>
    ///   <para>bag2:Voorkomen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een voorkomen van een object is de combinatie van gegevens over een object dat geldig is in een bepaalde periode.</para>
    /// labels<para>Voorkomen</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Voorkomen">http://bag.basisregistraties.overheid.nl/def/bag#Voorkomen</seealso>
    let Voorkomen = Prefixed_Name(bag2, "Voorkomen") |> PrefixedName
    /// <summary>
    ///   <para>bag2:beginGeldigheid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een ingangsdatum is een niet-authentiek gegeven dat de begindatum aangeeft van een periode waarin een voorkomen een wijziging heeft ondergaan.</para>
    /// labels<para>begin geldigheid</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#beginGeldigheid">http://bag.basisregistraties.overheid.nl/def/bag#beginGeldigheid</seealso>
    let beginGeldigheid = Prefixed_Name(bag2, "beginGeldigheid") |> PrefixedName
    /// <summary>
    ///   <para>bag2:documentdatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De datum waarop het brondocument is vastgesteld, op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een object heeft plaatsgevonden.</para>
    /// labels<para>documentdatum</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#documentdatum">http://bag.basisregistraties.overheid.nl/def/bag#documentdatum</seealso>
    let documentdatum = Prefixed_Name(bag2, "documentdatum") |> PrefixedName
    /// <summary>
    ///   <para>bag2:geometrieLigplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    /// labels<para>geometrie ligplaats</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieLigplaats">http://bag.basisregistraties.overheid.nl/def/bag#geometrieLigplaats</seealso>
    let geometrieLigplaats = Prefixed_Name(bag2, "geometrieLigplaats") |> PrefixedName

    /// <summary>
    ///   <para>bag2:geometrieVerblijfsobject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    /// labels<para>geometrie verblijfsobject</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieVerblijfsobject">http://bag.basisregistraties.overheid.nl/def/bag#geometrieVerblijfsobject</seealso>
    let geometrieVerblijfsobject =
        Prefixed_Name(bag2, "geometrieVerblijfsobject") |> PrefixedName

    /// <summary>
    ///   <para>bag2:huisnummer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een huisnummer is een authentiek gegeven met betrekking tot een nummeraanduiding. Het is de nummering van een adresseerbaar object.</para>
    /// labels<para>huisnummer</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#huisnummer">http://bag.basisregistraties.overheid.nl/def/bag#huisnummer</seealso>
    let huisnummer = Prefixed_Name(bag2, "huisnummer") |> PrefixedName

    /// <summary>
    ///   <para>bag2:huisnummertoevoeging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Een huisnummertoevoeging is een authentiek gegeven met betrekking tot een nummeraanduiding. Het is de toevoeging aan de nummering van een adresseerbaar object.</para>
    /// labels<para>huisnummertoevoeging</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#huisnummertoevoeging">http://bag.basisregistraties.overheid.nl/def/bag#huisnummertoevoeging</seealso>
    let huisnummertoevoeging =
        Prefixed_Name(bag2, "huisnummertoevoeging") |> PrefixedName

    /// <summary>
    ///   <para>bag2:inOnderzoek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>In onderzoek is een aanduiding waarmee wordt aangegeven dat een onderzoek wordt uitgevoerd naar de juistheid van een of meer gegevens van een object.</para>
    /// labels<para>in onderzoek</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#inOnderzoek">http://bag.basisregistraties.overheid.nl/def/bag#inOnderzoek</seealso>
    let inOnderzoek = Prefixed_Name(bag2, "inOnderzoek") |> PrefixedName
    /// <summary>
    ///   <para>bag2:pandrelatering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De unieke aanduidingen van de panden waarvan het verblijfsobject onderdeel uitmaakt.</para>
    /// labels<para>pandrelatering</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#pandrelatering">http://bag.basisregistraties.overheid.nl/def/bag#pandrelatering</seealso>
    let pandrelatering = Prefixed_Name(bag2, "pandrelatering") |> PrefixedName
    /// <summary>
    ///   <para>bag2:nevenadres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Een nevenadres is een aanvullend adres voor een verblijfsobject in het geval dat sprake is van meerdere ingangen aan verschillende straten.</para>
    /// labels<para>nevenadres</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#nevenadres">http://bag.basisregistraties.overheid.nl/def/bag#nevenadres</seealso>
    let nevenadres = Prefixed_Name(bag2, "nevenadres") |> PrefixedName

    /// <summary>
    ///   <para>bag2:AdministratiefGebied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Op basis van wet- of regelgeving afgebakend gebied dat als eenheid geldt van politiek/bestuurlijke verantwoordelijkheid of voor bedrijfsvoering.</para>
    /// labels<para>Administratief gebied</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#AdministratiefGebied">http://bag.basisregistraties.overheid.nl/def/bag#AdministratiefGebied</seealso>
    let AdministratiefGebied =
        Prefixed_Name(bag2, "AdministratiefGebied") |> PrefixedName

    /// <summary>
    ///   <para>bag2:OpenbareRuimte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een openbare ruimte is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen en van een naam voorziene buitenruimte die binnen één woonplaats is gelegen.</para>
    /// labels<para>Openbare ruimte</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#OpenbareRuimte">http://bag.basisregistraties.overheid.nl/def/bag#OpenbareRuimte</seealso>
    let OpenbareRuimte = Prefixed_Name(bag2, "OpenbareRuimte") |> PrefixedName
    /// <summary>
    ///   <para>bag2:BAG-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een object is een woonplaats, openbare ruimte, nummeraanduiding, pand, verblijfsobject, standplaats of ligplaats</para>
    /// labels<para>BAG-object</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#BAG-object">http://bag.basisregistraties.overheid.nl/def/bag#BAG-object</seealso>
    let BAG_object = Prefixed_Name(bag2, "BAG-object") |> PrefixedName
    /// <summary>
    ///   <para>bag2:Brondocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een brondocument is een document waarin rechtsfeiten en andere voor de registraties relevante feiten zijn neergelegd.</para>
    /// labels<para>Brondocument</para></remarks>
    /// <seealso href="http://bag.basisregistraties.overheid.nl/def/bag#Brondocument">http://bag.basisregistraties.overheid.nl/def/bag#Brondocument</seealso>
    let Brondocument = Prefixed_Name(bag2, "Brondocument") |> PrefixedName
