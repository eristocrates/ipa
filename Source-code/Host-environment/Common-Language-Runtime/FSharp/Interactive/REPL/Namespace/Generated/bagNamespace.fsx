#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bag =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://bag.basisregistraties.overheid.nl/def/bag#" "bag"

    /// <summary>
    ///   <para>rdfs:comment : Op basis van wet- of regelgeving afgebakend gebied dat als eenheid geldt van politiek/bestuurlijke verantwoordelijkheid of voor bedrijfsvoering.</para>
    ///   <para>rdfs:label : Administratief gebied</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#AdministratiefGebied">bag:AdministratiefGebied</a>
    /// </summary>
    let AdministratiefGebied = _prefixId.prefix "AdministratiefGebied"
    /// <summary>
    ///   <para>rdfs:comment : Een adresseerbaar object is een object waaraan adressen ingevolge de basisregistratie adressen kunnen worden toegekend: een verblijfsobject, standplaats of ligplaats.</para>
    ///   <para>rdfs:label : Adresseerbaar object</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#AdresseerbaarObject">bag:AdresseerbaarObject</a>
    /// </summary>
    let AdresseerbaarObject = _prefixId.prefix "AdresseerbaarObject"
    /// <summary>
    ///   <para>rdfs:comment : Een object is een woonplaats, openbare ruimte, nummeraanduiding, pand, verblijfsobject, standplaats of ligplaats</para>
    ///   <para>rdfs:label : BAG-object</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#BAG-object">bag:BAG-object</a>
    /// </summary>
    let BAG_object = _prefixId.prefix "BAG-object"
    /// <summary>
    ///   <para>rdfs:comment : Een brondocument is een document waarin rechtsfeiten en andere voor de registraties relevante feiten zijn neergelegd.</para>
    ///   <para>rdfs:label : Brondocument</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Brondocument">bag:Brondocument</a>
    /// </summary>
    let Brondocument = _prefixId.prefix "Brondocument"
    /// <summary>
    ///   <para>rdfs:comment : Civiel-technisch werk voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen en niet bedoeld voor permanent menselijk verblijf.</para>
    ///   <para>rdfs:label : Kunstwerk</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Kunstwerk">bag:Kunstwerk</a>
    /// </summary>
    let Kunstwerk = _prefixId.prefix "Kunstwerk"
    /// <summary>
    ///   <para>rdfs:comment : Definitie ontbreekt</para>
    ///   <para>rdfs:label : Landschappelijk gebied</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#LandschappelijkGebied">bag:LandschappelijkGebied</a>
    /// </summary>
    let LandschappelijkGebied = _prefixId.prefix "LandschappelijkGebied"
    /// <summary>
    ///   <para>rdfs:comment : Een ligplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen plaats in het water al dan niet aangevuld met een op de oever aanwezig terrein of een gedeelte daarvan, die bestemd is voor het permanent afmeren van een voor woon-, bedrijfsmatige of recreatieve doeleinden geschikt vaartuig</para>
    ///   <para>rdfs:label : Ligplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Ligplaats">bag:Ligplaats</a>
    /// </summary>
    let Ligplaats = _prefixId.prefix "Ligplaats"
    /// <summary>
    ///   <para>rdfs:comment : Een nummeraanduiding is een door het bevoegde gemeentelijke orgaan als zodanig toegekende aanduiding van een verblijfsobject, een standplaats of een ligplaats. Het is het samenstel van huisnummer, huisletter en huisnummertoevoeging.</para>
    ///   <para>rdfs:label : Nummeraanduiding</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Nummeraanduiding">bag:Nummeraanduiding</a>
    /// </summary>
    let Nummeraanduiding = _prefixId.prefix "Nummeraanduiding"
    /// <summary>
    ///   <para>rdfs:comment : Een openbare ruimte is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen en van een naam voorziene buitenruimte die binnen één woonplaats is gelegen.</para>
    ///   <para>rdfs:label : Openbare ruimte</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#OpenbareRuimte">bag:OpenbareRuimte</a>
    /// </summary>
    let OpenbareRuimte = _prefixId.prefix "OpenbareRuimte"
    /// <summary>
    ///   <para>rdfs:comment : Een pand is een kleinste bij de totstandkoming functioneel en bouwkundig-constructief zelfstandige eenheid die direct en duurzaam met de aarde is verbonden en betreedbaar en afsluitbaar is</para>
    ///   <para>rdfs:label : Pand</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Pand">bag:Pand</a>
    /// </summary>
    let Pand = _prefixId.prefix "Pand"
    /// <summary>
    ///   <para>rdfs:comment : Gebaand gedeelte voor het verkeer over rails.</para>
    ///   <para>rdfs:label : Spoorbaan</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Spoorbaan">bag:Spoorbaan</a>
    /// </summary>
    let Spoorbaan = _prefixId.prefix "Spoorbaan"
    /// <summary>
    ///   <para>rdfs:comment : Een standplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen terrein of gedeelte daarvan dat bestemd is voor het permanent plaatsen van een niet direct en niet duurzaam met de aarde verbonden en voor woon-, bedrijfsmatige, of recreatieve doeleinden geschikte ruimte</para>
    ///   <para>rdfs:label : Standplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Standplaats">bag:Standplaats</a>
    /// </summary>
    let Standplaats = _prefixId.prefix "Standplaats"
    /// <summary>
    ///   <para>rdfs:comment : Door een fysiek voorkomen gekarakteriseerd zichtbaar begrensd stuk grond.</para>
    ///   <para>rdfs:label : Terrein</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Terrein">bag:Terrein</a>
    /// </summary>
    let Terrein = _prefixId.prefix "Terrein"
    /// <summary>
    ///   <para>rdfs:comment : Een verblijfsobject is een kleinste binnen één of meer panden gelegen en voor woon-, bedrijfsmatige, of recreatieve doeleinden geschikte eenheid van gebruik die ontsloten wordt via een eigen afsluitbare toegang vanaf de openbare weg, een erf of een gedeelde verkeersruimte, onderwerp kan zijn van goederenrechtelijke rechtshandelingen en in functioneel opzicht zelfstandig is</para>
    ///   <para>rdfs:label : Verblijfsobject</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Verblijfsobject">bag:Verblijfsobject</a>
    /// </summary>
    let Verblijfsobject = _prefixId.prefix "Verblijfsobject"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het samenkomen van mensen voor kunst, cultuur, godsdienst, communicatie, kinderopvang, het verstrekken van consumpties voor het gebruik ter plaatse en het aanschouwen van sport.</para>
    ///   <para>rdfs:label : Verblijfsobject met bijeenkomstfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectBijeenkomstfunctie">bag:VerblijfsobjectBijeenkomstfunctie</a>
    /// </summary>
    let VerblijfsobjectBijeenkomstfunctie =
        _prefixId.prefix "VerblijfsobjectBijeenkomstfunctie"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor dwangverblijf van mensen.</para>
    ///   <para>rdfs:label : Verblijfsobject met celfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectCelfunctie">bag:VerblijfsobjectCelfunctie</a>
    /// </summary>
    let VerblijfsobjectCelfunctie = _prefixId.prefix "VerblijfsobjectCelfunctie"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor medisch onderzoek, verpleging, verzorging of behandeling.</para>
    ///   <para>rdfs:label : Verblijfsobject met gezondheidszorgfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectGezondheidszorgfunctie">bag:VerblijfsobjectGezondheidszorgfunctie</a>
    /// </summary>
    let VerblijfsobjectGezondheidszorgfunctie =
        _prefixId.prefix "VerblijfsobjectGezondheidszorgfunctie"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het bedrijfsmatig bewerken of opslaan van materialen en goederen, of voor agrarische doeleinden.</para>
    ///   <para>rdfs:label : Verblijfsobject met industriefunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectIndustriefunctie">bag:VerblijfsobjectIndustriefunctie</a>
    /// </summary>
    let VerblijfsobjectIndustriefunctie =
        _prefixId.prefix "VerblijfsobjectIndustriefunctie"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor administratie.</para>
    ///   <para>rdfs:label : Verblijfsobject met kantoorfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectKantoorfunctie">bag:VerblijfsobjectKantoorfunctie</a>
    /// </summary>
    let VerblijfsobjectKantoorfunctie = _prefixId.prefix "VerblijfsobjectKantoorfunctie"
    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het bieden van recreatief verblijf of tijdelijk onderdak aan mensen.</para>
    ///   <para>rdfs:label : Verblijfsobject met logiesfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectLogiesfunctie">bag:VerblijfsobjectLogiesfunctie</a>
    /// </summary>
    let VerblijfsobjectLogiesfunctie = _prefixId.prefix "VerblijfsobjectLogiesfunctie"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het geven van onderwijs.</para>
    ///   <para>rdfs:label : Verblijfsobject met onderwijsfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOnderwijsfunctie">bag:VerblijfsobjectOnderwijsfunctie</a>
    /// </summary>
    let VerblijfsobjectOnderwijsfunctie =
        _prefixId.prefix "VerblijfsobjectOnderwijsfunctie"

    /// <summary>
    ///   <para>rdfs:comment : Niet in dit lid benoemde gebruiksfunctie voor activiteiten waarbij het verblijven van mensen een ondergeschikte rol speelt.</para>
    ///   <para>rdfs:label : Verblijfsobject met overige gebruiksfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOverigeGebruiksfunctie">bag:VerblijfsobjectOverigeGebruiksfunctie</a>
    /// </summary>
    let VerblijfsobjectOverigeGebruiksfunctie =
        _prefixId.prefix "VerblijfsobjectOverigeGebruiksfunctie"

    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het beoefenen van sport.</para>
    ///   <para>rdfs:label : Verblijfsobject met sportfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectSportfunctie">bag:VerblijfsobjectSportfunctie</a>
    /// </summary>
    let VerblijfsobjectSportfunctie = _prefixId.prefix "VerblijfsobjectSportfunctie"
    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het verhandelen van materialen, goederen of diensten.</para>
    ///   <para>rdfs:label : Verblijfsobject met winkelfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWinkelfunctie">bag:VerblijfsobjectWinkelfunctie</a>
    /// </summary>
    let VerblijfsobjectWinkelfunctie = _prefixId.prefix "VerblijfsobjectWinkelfunctie"
    /// <summary>
    ///   <para>rdfs:comment : Gebruiksfunctie voor het wonen.</para>
    ///   <para>rdfs:label : Verblijfsobject met woonfunctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWoonfunctie">bag:VerblijfsobjectWoonfunctie</a>
    /// </summary>
    let VerblijfsobjectWoonfunctie = _prefixId.prefix "VerblijfsobjectWoonfunctie"
    /// <summary>
    ///   <para>rdfs:comment : Een voorkomen van een object is de combinatie van gegevens over een object dat geldig is in een bepaalde periode.</para>
    ///   <para>rdfs:label : Voorkomen</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Voorkomen">bag:Voorkomen</a>
    /// </summary>
    let Voorkomen = _prefixId.prefix "Voorkomen"
    /// <summary>
    ///   <para>rdfs:comment : Grondoppervlak in principe bedekt met water.</para>
    ///   <para>rdfs:label : Water</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Water">bag:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>rdfs:comment : Gebaand gedeelte voor het wegverkeer en vliegverkeer te land.</para>
    ///   <para>rdfs:label : Weg</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Weg">bag:Weg</a>
    /// </summary>
    let Weg = _prefixId.prefix "Weg"
    /// <summary>
    ///   <para>rdfs:comment : Een woonplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen en van een naam voorzien gedeelte van het grondgebied van de gemeente</para>
    ///   <para>rdfs:label : Woonplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#Woonplaats">bag:Woonplaats</a>
    /// </summary>
    let Woonplaats = _prefixId.prefix "Woonplaats"
    /// <summary>
    ///   <para>rdfs:comment : Een inactief voorkomen als gevolg van synchronisatie tussen bronhouder en de Landelijke Voorziening BAG.</para>
    ///   <para>rdfs:label : aanduiding correctie</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#aanduidingCorrectie">bag:aanduidingCorrectie</a>
    /// </summary>
    let aanduidingCorrectie = _prefixId.prefix "aanduidingCorrectie"
    /// <summary>
    ///   <para>rdfs:comment : Voorkomens van objecten met een begindatum in de toekomst die zijn gemuteerd. Ze maken daarmee geen onderdeel meer uit van de levenscyclus.</para>
    ///   <para>rdfs:label : aanduiding inactief</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#aanduidingInactief">bag:aanduidingInactief</a>
    /// </summary>
    let aanduidingInactief = _prefixId.prefix "aanduidingInactief"
    /// <summary>
    ///   <para>rdfs:comment : Een ingangsdatum is een niet-authentiek gegeven dat de begindatum aangeeft van een periode waarin een voorkomen een wijziging heeft ondergaan.</para>
    ///   <para>rdfs:label : begin geldigheid</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#beginGeldigheid">bag:beginGeldigheid</a>
    /// </summary>
    let beginGeldigheid = _prefixId.prefix "beginGeldigheid"
    /// <summary>
    ///   <para>rdfs:comment : Openbare ruimte van een nummeraanduiding is de openbare ruimte waaraan een adresseerbaar object is gelegen en aan welk object de nummeraanduiding is gerelateerd</para>
    ///   <para>rdfs:label : bijbehorende openbare ruimte</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeOpenbareRuimte">bag:bijbehorendeOpenbareRuimte</a>
    /// </summary>
    let bijbehorendeOpenbareRuimte = _prefixId.prefix "bijbehorendeOpenbareRuimte"
    /// <summary>
    ///   <para>rdfs:comment : De woonplaats openbare ruimte is een unieke aanduiding van de woonplaats waarbinnen een openbare ruimte is gelegen.rdfs:comment : Een woonplaats van een nummeraanduiding is de woonplaats waarbinnen het object waaraan de nummeraanduiding is toegekend gelegen is indien die woonplaats afwijkt van de woonplaats waarbinnen de openbare ruimte waaraan de nummeraanduiding is gerelateerd gelegen is.</para>
    ///   <para>rdfs:label : bijbehorende woonplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeWoonplaats">bag:bijbehorendeWoonplaats</a>
    /// </summary>
    let bijbehorendeWoonplaats = _prefixId.prefix "bijbehorendeWoonplaats"
    /// <summary>
    ///   <para>rdfs:comment : De relatie naar het brondocument dat ten grondslag ligt aan het voorkomen van een object.</para>
    ///   <para>rdfs:label : bron</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#bron">bag:bron</a>
    /// </summary>
    let bron = _prefixId.prefix "bron"
    /// <summary>
    ///   <para>rdfs:comment : De datum waarop het brondocument is vastgesteld, op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een object heeft plaatsgevonden.</para>
    ///   <para>rdfs:label : documentdatum</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#documentdatum">bag:documentdatum</a>
    /// </summary>
    let documentdatum = _prefixId.prefix "documentdatum"
    /// <summary>
    ///   <para>rdfs:comment : De unieke aanduiding van de vindplaats van een document binnen een organisatie.</para>
    ///   <para>rdfs:label : documentnummer</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#documentnummer">bag:documentnummer</a>
    /// </summary>
    let documentnummer = _prefixId.prefix "documentnummer"
    /// <summary>
    ///   <para>rdfs:comment : De einddatum van de geldigheid van een bepaalde combinatie van gegevens.</para>
    ///   <para>rdfs:label : eind geldigheid</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#eindGeldigheid">bag:eindGeldigheid</a>
    /// </summary>
    let eindGeldigheid = _prefixId.prefix "eindGeldigheid"
    /// <summary>
    ///   <para>rdfs:comment : Geconstateerd is een aanduiding waarmee kan worden aangegeven dat een object in de registratie is opgenomen als gevolg van een feitelijke constatering, zonder dat er op het moment van opname sprake was van een regulier brondocument voor deze opname.</para>
    ///   <para>rdfs:label : geconstateerd</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#geconstateerd">bag:geconstateerd</a>
    /// </summary>
    let geconstateerd = _prefixId.prefix "geconstateerd"
    /// <summary>
    ///   <para>rdfs:comment : Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    ///   <para>rdfs:label : geometrie ligplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieLigplaats">bag:geometrieLigplaats</a>
    /// </summary>
    let geometrieLigplaats = _prefixId.prefix "geometrieLigplaats"
    /// <summary>
    ///   <para>rdfs:comment : Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    ///   <para>rdfs:label : geometrie pand</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#geometriePand">bag:geometriePand</a>
    /// </summary>
    let geometriePand = _prefixId.prefix "geometriePand"
    /// <summary>
    ///   <para>rdfs:comment : Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    ///   <para>rdfs:label : geometrie standplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieStandplaats">bag:geometrieStandplaats</a>
    /// </summary>
    let geometrieStandplaats = _prefixId.prefix "geometrieStandplaats"
    /// <summary>
    ///   <para>rdfs:comment : Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    ///   <para>rdfs:label : geometrie verblijfsobject</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieVerblijfsobject">bag:geometrieVerblijfsobject</a>
    /// </summary>
    let geometrieVerblijfsobject = _prefixId.prefix "geometrieVerblijfsobject"
    /// <summary>
    ///   <para>rdfs:comment : Geometrie is een authentiek gegeven van een ruimtelijk object in de vorm van één of meerdere coordinaten.</para>
    ///   <para>rdfs:label : geometrie woonplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieWoonplaats">bag:geometrieWoonplaats</a>
    /// </summary>
    let geometrieWoonplaats = _prefixId.prefix "geometrieWoonplaats"
    /// <summary>
    ///   <para>rdfs:comment : Een hoofdadres is het primaire adres van een adresseerbaar object</para>
    ///   <para>rdfs:label : hoofdadres</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#hoofdadres">bag:hoofdadres</a>
    /// </summary>
    let hoofdadres = _prefixId.prefix "hoofdadres"
    /// <summary>
    ///   <para>rdfs:comment : Een huisletter is een authentiek gegeven met betrekking tot een nummeraanduiding. Het is de lettering van een adresseerbaar object</para>
    ///   <para>rdfs:label : huisletter</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#huisletter">bag:huisletter</a>
    /// </summary>
    let huisletter = _prefixId.prefix "huisletter"
    /// <summary>
    ///   <para>rdfs:comment : Een huisnummer is een authentiek gegeven met betrekking tot een nummeraanduiding. Het is de nummering van een adresseerbaar object.</para>
    ///   <para>rdfs:label : huisnummer</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#huisnummer">bag:huisnummer</a>
    /// </summary>
    let huisnummer = _prefixId.prefix "huisnummer"
    /// <summary>
    ///   <para>rdfs:comment : Een huisnummertoevoeging is een authentiek gegeven met betrekking tot een nummeraanduiding. Het is de toevoeging aan de nummering van een adresseerbaar object.</para>
    ///   <para>rdfs:label : huisnummertoevoeging</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#huisnummertoevoeging">bag:huisnummertoevoeging</a>
    /// </summary>
    let huisnummertoevoeging = _prefixId.prefix "huisnummertoevoeging"
    /// <summary>
    ///   <para>rdfs:comment : Een identificatiecode van een pand is een authentiek gegeven en een unieke aanduiding van het pand.rdfs:comment : Een identificatiecode van een standplaats is een authentiek gegeven en een unieke aanduiding van de standplaats.rdfs:comment : Een identificatiecode van een woonplaats is een authentiek gegeven zoals opgenomen in de landelijke woonplaatsentabelrdfs:comment : Een identificatiecode van een verblijfsobject is een authentiek gegeven en een unieke aanduiding van het verblijfsobject.rdfs:comment : Een identificatiecode van een openbare ruimte is een authentiek gegeven en een unieke aanduiding van de openbare ruimte.rdfs:comment : Een identificatiecode van een nummeraanduiding is een authentiek gegeven en een unieke aanduiding van de nummeraanduiding.rdfs:comment : Een identificatiecode van een ligplaats is een authentiek gegeven en een unieke aanduiding van de ligplaats.</para>
    ///   <para>rdfs:label : identificatiecode</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#identificatiecode">bag:identificatiecode</a>
    /// </summary>
    let identificatiecode = _prefixId.prefix "identificatiecode"
    /// <summary>
    ///   <para>rdfs:comment : In onderzoek is een aanduiding waarmee wordt aangegeven dat een onderzoek wordt uitgevoerd naar de juistheid van een of meer gegevens van een object.</para>
    ///   <para>rdfs:label : in onderzoek</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#inOnderzoek">bag:inOnderzoek</a>
    /// </summary>
    let inOnderzoek = _prefixId.prefix "inOnderzoek"
    /// <summary>
    ///   <para>rdfs:comment : De naam van een openbare ruimte is de door het bevoegde gemeentelijke orgaan aan een openbare ruimte toegekende benaming en een authentiek gegeven</para>
    ///   <para>rdfs:label : naam openbare ruimte</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#naamOpenbareRuimte">bag:naamOpenbareRuimte</a>
    /// </summary>
    let naamOpenbareRuimte = _prefixId.prefix "naamOpenbareRuimte"
    /// <summary>
    ///   <para>rdfs:comment : De naam van een woonplaats is de door het bevoegde gemeentelijke orgaan aan een woonplaats toegekende benaming en een authentiek gegeven</para>
    ///   <para>rdfs:label : naam woonplaats</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#naamWoonplaats">bag:naamWoonplaats</a>
    /// </summary>
    let naamWoonplaats = _prefixId.prefix "naamWoonplaats"
    /// <summary>
    ///   <para>rdfs:comment : Een nevenadres is een aanvullend adres voor een verblijfsobject in het geval dat sprake is van meerdere ingangen aan verschillende straten.</para>
    ///   <para>rdfs:label : nevenadres</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#nevenadres">bag:nevenadres</a>
    /// </summary>
    let nevenadres = _prefixId.prefix "nevenadres"
    /// <summary>
    ///   <para>rdfs:comment : Een bouwjaar is een authentiek gegeven met betrekking tot het jaar dat een pand bouwkundig gereed is of wordt opgeleverd.</para>
    ///   <para>rdfs:label : oorspronkelijk bouwjaar</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#oorspronkelijkBouwjaar">bag:oorspronkelijkBouwjaar</a>
    /// </summary>
    let oorspronkelijkBouwjaar = _prefixId.prefix "oorspronkelijkBouwjaar"
    /// <summary>
    ///   <para>rdfs:comment : Een oppervlakte is de gebruiksoppervlakte van een verblijfsobject en een authentiek gegeven</para>
    ///   <para>rdfs:label : oppervlakte</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#oppervlakte">bag:oppervlakte</a>
    /// </summary>
    let oppervlakte = _prefixId.prefix "oppervlakte"
    /// <summary>
    ///   <para>rdfs:comment : De unieke aanduidingen van de panden waarvan het verblijfsobject onderdeel uitmaakt.</para>
    ///   <para>rdfs:label : pandrelatering</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#pandrelatering">bag:pandrelatering</a>
    /// </summary>
    let pandrelatering = _prefixId.prefix "pandrelatering"
    /// <summary>
    ///   <para>rdfs:comment : De postcode is een coderingssystematiek zoals ontwikkeld en beheerd door PostNL. Een postcode is een niet-authentiek gegeven met betrekking tot een nummeraanduiding</para>
    ///   <para>rdfs:label : postcode</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#postcode">bag:postcode</a>
    /// </summary>
    let postcode = _prefixId.prefix "postcode"
    /// <summary>
    ///   <para>rdfs:comment : De fase in de levenscyclus van een BAG object.</para>
    ///   <para>rdfs:label : status</para>
    ///   <a href="http://bag.basisregistraties.overheid.nl/def/bag#status">bag:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
