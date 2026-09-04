#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bperson =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.vlaanderen.be/ns/persoon#" "bperson"

    /// <summary>
    ///   <para>vann:usageNote : De afstamming kan ook niet-biologisch zijn, bv adoptie. Afstamming kan ook in opgaande lijn worden bekeken. Het begrip is enger dan verwantschap dat oa ook huwelijk inhoudt.</para>
    ///   <para>rdfs:label : Afstamming</para>
    ///   <para>rdfs:comment : Afstamming is de dalende lijn van bloedverwantschap tussen verschillende generaties.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Afstamming">bperson:Afstamming</a>
    /// </summary>
    let Afstamming = _prefixId.prefix "Afstamming"
    /// <summary>
    ///   <para>vann:usageNote : Slaat op huwelijk, partnerregistratie, afstamming, voogdij etc. Is maw de toestand van bepaalde verhoudingen tussen personen.</para>
    ///   <para>rdfs:label : Burgerlijke Staat</para>
    ///   <para>rdfs:comment : Burgerrechtelijke toestand van een persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#BurgerlijkeStaat">bperson:BurgerlijkeStaat</a>
    /// </summary>
    let BurgerlijkeStaat = _prefixId.prefix "BurgerlijkeStaat"
    /// <summary>
    ///   <para>vann:usageNote : Plaats waar de persoon het grootste deel vd tijd verblijft binnen de jurisdictie waarvan hij Inwoner is. Dit wordt doorgaans officieel vastgesteld en geregistreerd ih bevolkingsregister. Kan in praktijk verschillend vd feitelijke verblijfplaats.</para>
    ///   <para>rdfs:label : Domicilie</para>
    ///   <para>rdfs:comment : Hoofdverblijfplaats ve persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Domicilie">bperson:Domicilie</a>
    /// </summary>
    let Domicilie = _prefixId.prefix "Domicilie"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : Geboorte</para>
    ///   <para>rdfs:comment : Het ter wereld komen vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Geboorte">bperson:Geboorte</a>
    /// </summary>
    let Geboorte = _prefixId.prefix "Geboorte"
    /// <summary>
    ///   <para>vann:usageNote : Plaats of land wordt hier vertegenwoordigd door de entiteit jurisdictie.</para>
    ///   <para>rdfs:label : Geen Inwoner</para>
    ///   <para>rdfs:comment : Persoon die niet in een bepaalde plaats of land woont.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#GeenInwoner">bperson:GeenInwoner</a>
    /// </summary>
    let GeenInwoner = _prefixId.prefix "GeenInwoner"
    /// <summary>
    ///   <para>vann:usageNote : Doorgaans is dit register een bevolkingsregister maar het kan bv ook een kiesregister zijn. De ingeschreven gegevens hebben betrekking op de identeit (vb naam en voornaam) en de Verblijfplaats vd persoon en op belangrijke levensgebeurtenissen zoals geboorte, huwelijk, overlijden etc. Deze gegevens worden typisch geregistreerd door de overheid, ze bieden de ingeschreven persoon wettelijke bescherming en laten de overheid toe om basisstatistieken op te stellen over zijn bevolking.</para>
    ///   <para>rdfs:label : Geregistreerd Persoon</para>
    ///   <para>rdfs:comment : Persoon waarvan de gegevens zijn ingeschreven in een register.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#GeregistreerdPersoon">bperson:GeregistreerdPersoon</a>
    /// </summary>
    let GeregistreerdPersoon = _prefixId.prefix "GeregistreerdPersoon"
    /// <summary>
    ///   <para>vann:usageNote : Ruimer begrip dan familie waar het gezin louter bestaat uit nabije bloedverwanten, bv een enpersoonsgezin of living apart together. Gezinsleden hebben doorgaans dezelfde Verblijfplaats.</para>
    ///   <para>rdfs:label : Gezin</para>
    ///   <para>rdfs:comment : Samenwerkingsvorm die een herkenbare sociale eenheid vormt (bv tgv huwelijk), met al dan niet verwante personen die duurzame banden hebben en elkaar onderling steun en verzorging verlenen.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Gezin">bperson:Gezin</a>
    /// </summary>
    let Gezin = _prefixId.prefix "Gezin"
    /// <summary>
    ///   <para>vann:usageNote : Bv echtgenoot, zoon, schoonmoeder.</para>
    ///   <para>rdfs:label : Gezinsrelatie</para>
    ///   <para>rdfs:comment : Relatie tussen leden van eenzelfde gezin.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Gezinsrelatie">bperson:Gezinsrelatie</a>
    /// </summary>
    let Gezinsrelatie = _prefixId.prefix "Gezinsrelatie"
    /// <summary>
    ///   <para>vann:usageNote : Kan, net als bv samenwonen, de basis vormen van een gezin.</para>
    ///   <para>rdfs:label : Huwelijk</para>
    ///   <para>rdfs:comment : Een door burgerlijk of religieus recht geregelde samenlevingsvorm van twee personen.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Huwelijk">bperson:Huwelijk</a>
    /// </summary>
    let Huwelijk = _prefixId.prefix "Huwelijk"
    /// <summary>
    ///   <para>vann:usageNote : Plaats of land wordt hier vertegenwoordigd door de entiteit jurisdictie.</para>
    ///   <para>rdfs:label : Inwoner</para>
    ///   <para>rdfs:comment : Persoon die in een bepaalde plaats of land woont.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Inwoner">bperson:Inwoner</a>
    /// </summary>
    let Inwoner = _prefixId.prefix "Inwoner"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : Inwonerschap</para>
    ///   <para>rdfs:comment : Het feit dat een persoon verblijf houdt in een plaats of land.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Inwonerschap">bperson:Inwonerschap</a>
    /// </summary>
    let Inwonerschap = _prefixId.prefix "Inwonerschap"

    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : binnen jurisdictie</para>
    ///   <para>rdfs:comment : Jurisdictie waarbinnen het inwonerschap (ve persoon) is gedefineerd.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Inwonerschap.binnenJurisdictie">bperson:Inwonerschap.binnenJurisdictie</a>
    /// </summary>
    let ``Inwonerschap.binnenJurisdictie`` =
        _prefixId.prefix "Inwonerschap.binnenJurisdictie"

    /// <summary>
    ///   <para>vann:usageNote : Merk op dat dit begrip ruimer is dan staatsburgerschap (dat zich beperkt tot de relatie met een staat). Wie de nationaliteit ve bepaald land heeft is er doorgaans ook automatisch staatsburger van. Nationaliteit wordt doorgaans autamatisch verkregen door geboorte: men krijgt hetzij de nationaliteit van zijn ouders of men krijgt deze vh land waar men Inwoner van is. Men kan een bepaalde nationaliteit ook verkrijgen door naturalisatie. In principe verliest men dan zijn oorspronkelijke nationaliteit, maar dat is niet altijd zo (meervoudige nationaliteit).</para>
    ///   <para>rdfs:label : Nationaliteit</para>
    ///   <para>rdfs:comment : De relatie tussen een persoon en een staat, cultuur of loyaliteit.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Nationaliteit">bperson:Nationaliteit</a>
    /// </summary>
    let Nationaliteit = _prefixId.prefix "Nationaliteit"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : Overlijden</para>
    ///   <para>rdfs:comment : Het doodgaan vd Persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Overlijden">bperson:Overlijden</a>
    /// </summary>
    let Overlijden = _prefixId.prefix "Overlijden"
    /// <summary>
    ///   <para>vann:usageNote : Is een verblijfsrecht dat in principe officieel moet worden toegekend als de persoon geen staatsburger is.</para>
    ///   <para>rdfs:label : Permanent Inwoner</para>
    ///   <para>rdfs:comment : Persoon die permanent in een bepaalde plaats of land woont.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#PermanentInwoner">bperson:PermanentInwoner</a>
    /// </summary>
    let PermanentInwoner = _prefixId.prefix "PermanentInwoner"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : Persoonsgebeurtenis</para>
    ///   <para>rdfs:comment : Belangrijke gebeurtenis ih leven ve persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Persoonsgebeurtenis">bperson:Persoonsgebeurtenis</a>
    /// </summary>
    let Persoonsgebeurtenis = _prefixId.prefix "Persoonsgebeurtenis"
    /// <summary>
    ///   <para>vann:usageNote : Typisch zijn dit burgerrechtelijke relaties (zie burgerlijke staat) maar niet noodzakelijk daartoe beperkt.</para>
    ///   <para>rdfs:label : Persoonsrelatie</para>
    ///   <para>rdfs:comment : Relatie tussen twee of meer personen.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Persoonsrelatie">bperson:Persoonsrelatie</a>
    /// </summary>
    let Persoonsrelatie = _prefixId.prefix "Persoonsrelatie"
    /// <summary>
    ///   <para>vann:usageNote : Kan, net als bv een huwelijk, de basis vormen van een gezin.</para>
    ///   <para>rdfs:label : Samenwonen</para>
    ///   <para>rdfs:comment : Regeling waarbij twee personen die niet getrouwd zijn samenleven.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Samenwonen">bperson:Samenwonen</a>
    /// </summary>
    let Samenwonen = _prefixId.prefix "Samenwonen"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : Staatsburger</para>
    ///   <para>rdfs:comment : Persoon die juridisch verbonden is met een staat.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Staatsburger">bperson:Staatsburger</a>
    /// </summary>
    let Staatsburger = _prefixId.prefix "Staatsburger"
    /// <summary>
    ///   <para>vann:usageNote : Vloeit meestal voort uit de nationaliteit ve persoon. De rechten en plichten waarvan sprake zijn burgerrechten (vb godsdienstvrijheid) of van politieke (vb stemrecht) of sociale aard (bv recht op een uitkering).  </para>
    ///   <para>rdfs:label : Staatburgerschap</para>
    ///   <para>rdfs:comment : Juridische band ve persoon met een staat, waaraan bepaalde rechten en plichten verbonden zijn</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap">bperson:Staatsburgerschap</a>
    /// </summary>
    let Staatsburgerschap = _prefixId.prefix "Staatsburgerschap"

    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : binnen jurisdictie</para>
    ///   <para>rdfs:comment : Jurisdictie waarbinnen het staatsburgerschap (ve persoon) is gedefineerd.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap.binnenJurisdictie">bperson:Staatsburgerschap.binnenJurisdictie</a>
    /// </summary>
    let ``Staatsburgerschap.binnenJurisdictie`` =
        _prefixId.prefix "Staatsburgerschap.binnenJurisdictie"

    /// <summary>
    ///   <para>vann:usageNote : Is een verblijfsrecht dat in principe enkel wordt toegekend omwille ve zeer specifieke reden bv werken of studeren. Exclusief personen met kort verblijf, bv als toerist.</para>
    ///   <para>rdfs:label : Tijdelijk Inwoner</para>
    ///   <para>rdfs:comment : Persoon die tijdelijk in een plaats of land woont.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#TijdelijkInwoner">bperson:TijdelijkInwoner</a>
    /// </summary>
    let TijdelijkInwoner = _prefixId.prefix "TijdelijkInwoner"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : Verblijfplaats</para>
    ///   <para>rdfs:comment : Plaats waar een persoon al dan niet tijdelijk woont of logeert.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Verblijfplaats">bperson:Verblijfplaats</a>
    /// </summary>
    let Verblijfplaats = _prefixId.prefix "Verblijfplaats"
    /// <summary>
    ///   <para>vann:usageNote : Dit is bv het geval voor minderjarigen die hun ouders zijn verloren of voor meerderjarigen die hun verstandelijke vermogens zijn verloren.</para>
    ///   <para>rdfs:label : Voogdij</para>
    ///   <para>rdfs:comment : Situatie waarbij een persoon die optreedt als voogd ve ander persoon en in die hoedanigheid instaat voor deze persoon en zijn goederen.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Voogdij">bperson:Voogdij</a>
    /// </summary>
    let Voogdij = _prefixId.prefix "Voogdij"
    /// <summary>
    ///   <para>vann:usageNote : Daardoor kan de persoon geen staatsburger worden genoemd. In praktijk geniet de Vreemdeling als Inwoner een subset vd burgerrechten die een Staatsbutger wel heeft. Bv wel godsdienstvrijheid maar geen stemrecht.</para>
    ///   <para>rdfs:label : Vreemdeling</para>
    ///   <para>rdfs:comment : Persoon die niet de nationaliteit bezit vh land waar hij verblijft.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#Vreemdeling">bperson:Vreemdeling</a>
    /// </summary>
    let Vreemdeling = _prefixId.prefix "Vreemdeling"
    /// <summary>
    ///   <para>vann:usageNote : Bv geadopteerd, kind uit huwelijk, erkend door de vader etc.</para>
    ///   <para>rdfs:label : afstammingstype</para>
    ///   <para>rdfs:comment : Aard vd afstamming.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#afstammingsType">bperson:afstammingsType</a>
    /// </summary>
    let afstammingsType = _prefixId.prefix "afstammingsType"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : datum</para>
    ///   <para>rdfs:comment : Datum waarop de gebeurtenis plaatsvond.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#datum">bperson:datum</a>
    /// </summary>
    let datum = _prefixId.prefix "datum"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : datum van afstamming</para>
    ///   <para>rdfs:comment : De datum waarop de afstamming wordt vastgesteld.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#datumVanAfstamming">bperson:datumVanAfstamming</a>
    /// </summary>
    let datumVanAfstamming = _prefixId.prefix "datumVanAfstamming"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : gebruikte voornaam</para>
    ///   <para>rdfs:comment : Belangrijkste vd voornamen ve persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#gebruikteVoornaam">bperson:gebruikteVoornaam</a>
    /// </summary>
    let gebruikteVoornaam = _prefixId.prefix "gebruikteVoornaam"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : geslacht</para>
    ///   <para>rdfs:comment : Het feit of de persoon een man of een vrouw is.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#geslacht">bperson:geslacht</a>
    /// </summary>
    let geslacht = _prefixId.prefix "geslacht"
    /// <summary>
    ///   <para>vann:usageNote : Dikwijls een criterium om te bepalen of personen deel uitmaken van eenzelfde gezin.</para>
    ///   <para>rdfs:label : gezinsadres</para>
    ///   <para>rdfs:comment : Verblijfplaats vh gezin.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#gezinsadres">bperson:gezinsadres</a>
    /// </summary>
    let gezinsadres = _prefixId.prefix "gezinsadres"
    /// <summary>
    ///   <para>vann:usageNote : Wordt typisch bepaald tov het gezinshoofd. Bv als de vader gezinshoofd is en een gezinslid is zoon, dan zou als de grootvader gezinshoofd was datzelfde gezinslid kleinzoon zijn.</para>
    ///   <para>rdfs:label : gezinsrelatietype</para>
    ///   <para>rdfs:comment : Aard vd relatie.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#gezinsrelatietype">bperson:gezinsrelatietype</a>
    /// </summary>
    let gezinsrelatietype = _prefixId.prefix "gezinsrelatietype"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : heeft burgerlijke staat</para>
    ///   <para>rdfs:comment : Burgerlijke staat vd Persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftBurgerlijkeStaat">bperson:heeftBurgerlijkeStaat</a>
    /// </summary>
    let heeftBurgerlijkeStaat = _prefixId.prefix "heeftBurgerlijkeStaat"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : heeft geboorte</para>
    ///   <para>rdfs:comment : Verwijst naar de geboortegegevens vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftGeboorte">bperson:heeftGeboorte</a>
    /// </summary>
    let heeftGeboorte = _prefixId.prefix "heeftGeboorte"
    /// <summary>
    ///   <para>vann:usageNote : De entiteit inwonerschap beschrijft het inwonerschap in meer detail (oa de jurisdictie waarbinnen het gedefinieerd is).</para>
    ///   <para>rdfs:label : heeft inwonerschap</para>
    ///   <para>rdfs:comment : Inwonerschap vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftInwonerschap">bperson:heeftInwonerschap</a>
    /// </summary>
    let heeftInwonerschap = _prefixId.prefix "heeftInwonerschap"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : heeft nationaliteit</para>
    ///   <para>rdfs:comment : Nationaliteit vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftNationaliteit">bperson:heeftNationaliteit</a>
    /// </summary>
    let heeftNationaliteit = _prefixId.prefix "heeftNationaliteit"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : heeft overlijden</para>
    ///   <para>rdfs:comment : Verwijst naar de overlijdensgegevens vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftOverlijden">bperson:heeftOverlijden</a>
    /// </summary>
    let heeftOverlijden = _prefixId.prefix "heeftOverlijden"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : heeft persoonsrelatie</para>
    ///   <para>rdfs:comment : Relatie van een persoon (met een ander persoon).</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftPersoonsrelatie">bperson:heeftPersoonsrelatie</a>
    /// </summary>
    let heeftPersoonsrelatie = _prefixId.prefix "heeftPersoonsrelatie"
    /// <summary>
    ///   <para>vann:usageNote : De entiteit staatsburgerschap beschrijft het staatsburgerschap in meer detail (oa de jurisdictie waarbinnen het gedefinieerd is).</para>
    ///   <para>rdfs:label : heeft staatsburgerschap</para>
    ///   <para>rdfs:comment : Staatsburgerschap vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftStaatsburgerschap">bperson:heeftStaatsburgerschap</a>
    /// </summary>
    let heeftStaatsburgerschap = _prefixId.prefix "heeftStaatsburgerschap"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : heeft verblijfplaats</para>
    ///   <para>rdfs:comment : Plaats waar een persoon verblijft.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#heeftVerblijfplaats">bperson:heeftVerblijfplaats</a>
    /// </summary>
    let heeftVerblijfplaats = _prefixId.prefix "heeftVerblijfplaats"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : is hoofd van</para>
    ///   <para>rdfs:comment : Persoon die standaard het gezin vertegenwoordigt.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#isHoofdVan">bperson:isHoofdVan</a>
    /// </summary>
    let isHoofdVan = _prefixId.prefix "isHoofdVan"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : is lid van</para>
    ///   <para>rdfs:comment : Persoon die tot een gezin behoort.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#isLidVan">bperson:isLidVan</a>
    /// </summary>
    let isLidVan = _prefixId.prefix "isLidVan"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : is relatie met</para>
    ///   <para>rdfs:comment : Persoon waarmee de persoon gerelateerd is.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#isRelatieMet">bperson:isRelatieMet</a>
    /// </summary>
    let isRelatieMet = _prefixId.prefix "isRelatieMet"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : nationaliteit</para>
    ///   <para>rdfs:comment : De nationaliteit vd persoon.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#nationaliteit">bperson:nationaliteit</a>
    /// </summary>
    let nationaliteit = _prefixId.prefix "nationaliteit"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : plaats</para>
    ///   <para>rdfs:comment : Plaats waar de gebeurtenis plaatsvond.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#plaats">bperson:plaats</a>
    /// </summary>
    let plaats = _prefixId.prefix "plaats"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : registratie</para>
    ///   <para>rdfs:comment : Identificatiecode vd persoon ih register.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#registratie">bperson:registratie</a>
    /// </summary>
    let registratie = _prefixId.prefix "registratie"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:comment : Aard vd burgerlijke staat.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#type">bperson:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : verblijfsadres</para>
    ///   <para>rdfs:comment : Plaats waar een persoon al dan niet tijdelijk woont of logeert.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#verblijfsadres">bperson:verblijfsadres</a>
    /// </summary>
    let verblijfsadres = _prefixId.prefix "verblijfsadres"
    /// <summary>
    ///   <para>vann:usageNote :  </para>
    ///   <para>rdfs:label : volledige naam</para>
    ///   <para>rdfs:comment : De volledige naam vd persoon, doorgaans de combinatie van voornamen en achternaam.</para>
    ///   <a href="http://data.vlaanderen.be/ns/persoon#volledigeNaam">bperson:volledigeNaam</a>
    /// </summary>
    let volledigeNaam = _prefixId.prefix "volledigeNaam"
