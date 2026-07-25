namespace http.data.vlaanderen.be.ns.persoon.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bperson =
    let _namespace_iri = Namespace_Iri bperson |> NamespaceIRI
    /// <summary>
    ///   <para>bperson:Verblijfplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Plaats waar een persoon al dan niet tijdelijk woont of logeert.</para>
    /// labels<para>Verblijfplaats</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Verblijfplaats">http://data.vlaanderen.be/ns/persoon#Verblijfplaats</seealso>
    let Verblijfplaats = Prefixed_Name(bperson, "Verblijfplaats") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Gezin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Samenwerkingsvorm die een herkenbare sociale eenheid vormt (bv tgv huwelijk), met al dan niet verwante personen die duurzame banden hebben en elkaar onderling steun en verzorging verlenen.</para>
    /// labels<para>Gezin</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Gezin">http://data.vlaanderen.be/ns/persoon#Gezin</seealso>
    let Gezin = Prefixed_Name(bperson, "Gezin") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Vreemdeling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon die niet de nationaliteit bezit vh land waar hij verblijft.</para>
    /// labels<para>Vreemdeling</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Vreemdeling">http://data.vlaanderen.be/ns/persoon#Vreemdeling</seealso>
    let Vreemdeling = Prefixed_Name(bperson, "Vreemdeling") |> PrefixedName
    /// <summary>
    ///   <para>bperson:datum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datum waarop de gebeurtenis plaatsvond.</para>
    /// labels<para>datum</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#datum">http://data.vlaanderen.be/ns/persoon#datum</seealso>
    let datum = Prefixed_Name(bperson, "datum") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Inwoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon die in een bepaalde plaats of land woont.</para>
    /// labels<para>Inwoner</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Inwoner">http://data.vlaanderen.be/ns/persoon#Inwoner</seealso>
    let Inwoner = Prefixed_Name(bperson, "Inwoner") |> PrefixedName
    /// <summary>
    ///   <para>bperson:PermanentInwoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon die permanent in een bepaalde plaats of land woont.</para>
    /// labels<para>Permanent Inwoner</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#PermanentInwoner">http://data.vlaanderen.be/ns/persoon#PermanentInwoner</seealso>
    let PermanentInwoner = Prefixed_Name(bperson, "PermanentInwoner") |> PrefixedName

    /// <summary>
    ///   <para>bperson:datumVanAfstamming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De datum waarop de afstamming wordt vastgesteld.</para>
    /// labels<para>datum van afstamming</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#datumVanAfstamming">http://data.vlaanderen.be/ns/persoon#datumVanAfstamming</seealso>
    let datumVanAfstamming =
        Prefixed_Name(bperson, "datumVanAfstamming") |> PrefixedName

    /// <summary>
    ///   <para>bperson:gezinsrelatietype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Aard vd relatie.</para>
    /// labels<para>gezinsrelatietype</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#gezinsrelatietype">http://data.vlaanderen.be/ns/persoon#gezinsrelatietype</seealso>
    let gezinsrelatietype = Prefixed_Name(bperson, "gezinsrelatietype") |> PrefixedName
    /// <summary>
    ///   <para>bperson:heeftGeboorte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Verwijst naar de geboortegegevens vd persoon.</para>
    /// labels<para>heeft geboorte</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftGeboorte">http://data.vlaanderen.be/ns/persoon#heeftGeboorte</seealso>
    let heeftGeboorte = Prefixed_Name(bperson, "heeftGeboorte") |> PrefixedName

    /// <summary>
    ///   <para>bperson:heeftNationaliteit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Nationaliteit vd persoon.</para>
    /// labels<para>heeft nationaliteit</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftNationaliteit">http://data.vlaanderen.be/ns/persoon#heeftNationaliteit</seealso>
    let heeftNationaliteit =
        Prefixed_Name(bperson, "heeftNationaliteit") |> PrefixedName

    /// <summary>
    ///   <para>bperson:heeftPersoonsrelatie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relatie van een persoon (met een ander persoon).</para>
    /// labels<para>heeft persoonsrelatie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftPersoonsrelatie">http://data.vlaanderen.be/ns/persoon#heeftPersoonsrelatie</seealso>
    let heeftPersoonsrelatie =
        Prefixed_Name(bperson, "heeftPersoonsrelatie") |> PrefixedName

    /// <summary>
    ///   <para>bperson:heeftVerblijfplaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Plaats waar een persoon verblijft.</para>
    /// labels<para>heeft verblijfplaats</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftVerblijfplaats">http://data.vlaanderen.be/ns/persoon#heeftVerblijfplaats</seealso>
    let heeftVerblijfplaats =
        Prefixed_Name(bperson, "heeftVerblijfplaats") |> PrefixedName

    /// <summary>
    ///   <para>bperson:isHoofdVan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Persoon die standaard het gezin vertegenwoordigt.</para>
    /// labels<para>is hoofd van</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#isHoofdVan">http://data.vlaanderen.be/ns/persoon#isHoofdVan</seealso>
    let isHoofdVan = Prefixed_Name(bperson, "isHoofdVan") |> PrefixedName
    /// <summary>
    ///   <para>bperson:isLidVan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Persoon die tot een gezin behoort.</para>
    /// labels<para>is lid van</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#isLidVan">http://data.vlaanderen.be/ns/persoon#isLidVan</seealso>
    let isLidVan = Prefixed_Name(bperson, "isLidVan") |> PrefixedName
    /// <summary>
    ///   <para>bperson:isRelatieMet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Persoon waarmee de persoon gerelateerd is.</para>
    /// labels<para>is relatie met</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#isRelatieMet">http://data.vlaanderen.be/ns/persoon#isRelatieMet</seealso>
    let isRelatieMet = Prefixed_Name(bperson, "isRelatieMet") |> PrefixedName
    /// <summary>
    ///   <para>bperson:nationaliteit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De nationaliteit vd persoon.</para>
    /// labels<para>nationaliteit</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#nationaliteit">http://data.vlaanderen.be/ns/persoon#nationaliteit</seealso>
    let nationaliteit = Prefixed_Name(bperson, "nationaliteit") |> PrefixedName
    /// <summary>
    ///   <para>bperson:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Aard vd burgerlijke staat.</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#type">http://data.vlaanderen.be/ns/persoon#type</seealso>
    let type_ = Prefixed_Name(bperson, "type") |> PrefixedName
    /// <summary>
    ///   <para>bperson:heeftInwonerschap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inwonerschap vd persoon.</para>
    /// labels<para>heeft inwonerschap</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftInwonerschap">http://data.vlaanderen.be/ns/persoon#heeftInwonerschap</seealso>
    let heeftInwonerschap = Prefixed_Name(bperson, "heeftInwonerschap") |> PrefixedName
    /// <summary>
    ///   <para>bperson:heeftOverlijden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Verwijst naar de overlijdensgegevens vd persoon.</para>
    /// labels<para>heeft overlijden</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftOverlijden">http://data.vlaanderen.be/ns/persoon#heeftOverlijden</seealso>
    let heeftOverlijden = Prefixed_Name(bperson, "heeftOverlijden") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Staatsburgerschap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Juridische band ve persoon met een staat, waaraan bepaalde rechten en plichten verbonden zijn</para>
    /// labels<para>Staatburgerschap</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap">http://data.vlaanderen.be/ns/persoon#Staatsburgerschap</seealso>
    let Staatsburgerschap = Prefixed_Name(bperson, "Staatsburgerschap") |> PrefixedName

    /// <summary>
    ///   <para>bperson:heeftBurgerlijkeStaat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Burgerlijke staat vd Persoon.</para>
    /// labels<para>heeft burgerlijke staat</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftBurgerlijkeStaat">http://data.vlaanderen.be/ns/persoon#heeftBurgerlijkeStaat</seealso>
    let heeftBurgerlijkeStaat =
        Prefixed_Name(bperson, "heeftBurgerlijkeStaat") |> PrefixedName

    /// <summary>
    ///   <para>bperson:heeftStaatsburgerschap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Staatsburgerschap vd persoon.</para>
    /// labels<para>heeft staatsburgerschap</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#heeftStaatsburgerschap">http://data.vlaanderen.be/ns/persoon#heeftStaatsburgerschap</seealso>
    let heeftStaatsburgerschap =
        Prefixed_Name(bperson, "heeftStaatsburgerschap") |> PrefixedName

    /// <summary>
    ///   <para>bperson:plaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Plaats waar de gebeurtenis plaatsvond.</para>
    /// labels<para>plaats</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#plaats">http://data.vlaanderen.be/ns/persoon#plaats</seealso>
    let plaats = Prefixed_Name(bperson, "plaats") |> PrefixedName
    /// <summary>
    ///   <para>bperson:verblijfsadres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Plaats waar een persoon al dan niet tijdelijk woont of logeert.</para>
    /// labels<para>verblijfsadres</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#verblijfsadres">http://data.vlaanderen.be/ns/persoon#verblijfsadres</seealso>
    let verblijfsadres = Prefixed_Name(bperson, "verblijfsadres") |> PrefixedName
    /// <summary>
    ///   <para>bperson:registratie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identificatiecode vd persoon ih register.</para>
    /// labels<para>registratie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#registratie">http://data.vlaanderen.be/ns/persoon#registratie</seealso>
    let registratie = Prefixed_Name(bperson, "registratie") |> PrefixedName
    /// <summary>
    ///   <para>bperson:volledigeNaam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>De volledige naam vd persoon, doorgaans de combinatie van voornamen en achternaam.</para>
    /// labels<para>volledige naam</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#volledigeNaam">http://data.vlaanderen.be/ns/persoon#volledigeNaam</seealso>
    let volledigeNaam = Prefixed_Name(bperson, "volledigeNaam") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Afstamming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Afstamming is de dalende lijn van bloedverwantschap tussen verschillende generaties.</para>
    /// labels<para>Afstamming</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Afstamming">http://data.vlaanderen.be/ns/persoon#Afstamming</seealso>
    let Afstamming = Prefixed_Name(bperson, "Afstamming") |> PrefixedName
    /// <summary>
    ///   <para>bperson:BurgerlijkeStaat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Burgerrechtelijke toestand van een persoon.</para>
    /// labels<para>Burgerlijke Staat</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#BurgerlijkeStaat">http://data.vlaanderen.be/ns/persoon#BurgerlijkeStaat</seealso>
    let BurgerlijkeStaat = Prefixed_Name(bperson, "BurgerlijkeStaat") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Domicilie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hoofdverblijfplaats ve persoon.</para>
    /// labels<para>Domicilie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Domicilie">http://data.vlaanderen.be/ns/persoon#Domicilie</seealso>
    let Domicilie = Prefixed_Name(bperson, "Domicilie") |> PrefixedName

    /// <summary>
    ///   <para>bperson:Persoonsgebeurtenis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Belangrijke gebeurtenis ih leven ve persoon.</para>
    /// labels<para>Persoonsgebeurtenis</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Persoonsgebeurtenis">http://data.vlaanderen.be/ns/persoon#Persoonsgebeurtenis</seealso>
    let Persoonsgebeurtenis =
        Prefixed_Name(bperson, "Persoonsgebeurtenis") |> PrefixedName

    /// <summary>
    ///   <para>bperson:GeenInwoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon die niet in een bepaalde plaats of land woont.</para>
    /// labels<para>Geen Inwoner</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#GeenInwoner">http://data.vlaanderen.be/ns/persoon#GeenInwoner</seealso>
    let GeenInwoner = Prefixed_Name(bperson, "GeenInwoner") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Inwonerschap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Het feit dat een persoon verblijf houdt in een plaats of land.</para>
    /// labels<para>Inwonerschap</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Inwonerschap">http://data.vlaanderen.be/ns/persoon#Inwonerschap</seealso>
    let Inwonerschap = Prefixed_Name(bperson, "Inwonerschap") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Gezinsrelatie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relatie tussen leden van eenzelfde gezin.</para>
    /// labels<para>Gezinsrelatie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Gezinsrelatie">http://data.vlaanderen.be/ns/persoon#Gezinsrelatie</seealso>
    let Gezinsrelatie = Prefixed_Name(bperson, "Gezinsrelatie") |> PrefixedName

    /// <summary>
    ///   <para>bperson:Inwonerschap.binnenJurisdictie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Jurisdictie waarbinnen het inwonerschap (ve persoon) is gedefineerd.</para>
    /// labels<para>binnen jurisdictie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Inwonerschap.binnenJurisdictie">http://data.vlaanderen.be/ns/persoon#Inwonerschap.binnenJurisdictie</seealso>
    let ``Inwonerschap.binnenJurisdictie`` =
        Prefixed_Name(bperson, "Inwonerschap.binnenJurisdictie") |> PrefixedName

    /// <summary>
    ///   <para>bperson:Nationaliteit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>De relatie tussen een persoon en een staat, cultuur of loyaliteit.</para>
    /// labels<para>Nationaliteit</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Nationaliteit">http://data.vlaanderen.be/ns/persoon#Nationaliteit</seealso>
    let Nationaliteit = Prefixed_Name(bperson, "Nationaliteit") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Overlijden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Het doodgaan vd Persoon.</para>
    /// labels<para>Overlijden</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Overlijden">http://data.vlaanderen.be/ns/persoon#Overlijden</seealso>
    let Overlijden = Prefixed_Name(bperson, "Overlijden") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Persoonsrelatie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relatie tussen twee of meer personen.</para>
    /// labels<para>Persoonsrelatie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Persoonsrelatie">http://data.vlaanderen.be/ns/persoon#Persoonsrelatie</seealso>
    let Persoonsrelatie = Prefixed_Name(bperson, "Persoonsrelatie") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Geboorte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Het ter wereld komen vd persoon.</para>
    /// labels<para>Geboorte</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Geboorte">http://data.vlaanderen.be/ns/persoon#Geboorte</seealso>
    let Geboorte = Prefixed_Name(bperson, "Geboorte") |> PrefixedName

    /// <summary>
    ///   <para>bperson:GeregistreerdPersoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon waarvan de gegevens zijn ingeschreven in een register.</para>
    /// labels<para>Geregistreerd Persoon</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#GeregistreerdPersoon">http://data.vlaanderen.be/ns/persoon#GeregistreerdPersoon</seealso>
    let GeregistreerdPersoon =
        Prefixed_Name(bperson, "GeregistreerdPersoon") |> PrefixedName

    /// <summary>
    ///   <para>bperson:Huwelijk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een door burgerlijk of religieus recht geregelde samenlevingsvorm van twee personen.</para>
    /// labels<para>Huwelijk</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Huwelijk">http://data.vlaanderen.be/ns/persoon#Huwelijk</seealso>
    let Huwelijk = Prefixed_Name(bperson, "Huwelijk") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Samenwonen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Regeling waarbij twee personen die niet getrouwd zijn samenleven.</para>
    /// labels<para>Samenwonen</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Samenwonen">http://data.vlaanderen.be/ns/persoon#Samenwonen</seealso>
    let Samenwonen = Prefixed_Name(bperson, "Samenwonen") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Staatsburger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon die juridisch verbonden is met een staat.</para>
    /// labels<para>Staatsburger</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Staatsburger">http://data.vlaanderen.be/ns/persoon#Staatsburger</seealso>
    let Staatsburger = Prefixed_Name(bperson, "Staatsburger") |> PrefixedName

    /// <summary>
    ///   <para>bperson:Staatsburgerschap.binnenJurisdictie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Jurisdictie waarbinnen het staatsburgerschap (ve persoon) is gedefineerd.</para>
    /// labels<para>binnen jurisdictie</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap.binnenJurisdictie">http://data.vlaanderen.be/ns/persoon#Staatsburgerschap.binnenJurisdictie</seealso>
    let ``Staatsburgerschap.binnenJurisdictie`` =
        Prefixed_Name(bperson, "Staatsburgerschap.binnenJurisdictie") |> PrefixedName

    /// <summary>
    ///   <para>bperson:TijdelijkInwoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Persoon die tijdelijk in een plaats of land woont.</para>
    /// labels<para>Tijdelijk Inwoner</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#TijdelijkInwoner">http://data.vlaanderen.be/ns/persoon#TijdelijkInwoner</seealso>
    let TijdelijkInwoner = Prefixed_Name(bperson, "TijdelijkInwoner") |> PrefixedName
    /// <summary>
    ///   <para>bperson:Voogdij</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Situatie waarbij een persoon die optreedt als voogd ve ander persoon en in die hoedanigheid instaat voor deze persoon en zijn goederen.</para>
    /// labels<para>Voogdij</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#Voogdij">http://data.vlaanderen.be/ns/persoon#Voogdij</seealso>
    let Voogdij = Prefixed_Name(bperson, "Voogdij") |> PrefixedName
    /// <summary>
    ///   <para>bperson:afstammingsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Aard vd afstamming.</para>
    /// labels<para>afstammingstype</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#afstammingsType">http://data.vlaanderen.be/ns/persoon#afstammingsType</seealso>
    let afstammingsType = Prefixed_Name(bperson, "afstammingsType") |> PrefixedName
    /// <summary>
    ///   <para>bperson:gebruikteVoornaam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Belangrijkste vd voornamen ve persoon.</para>
    /// labels<para>gebruikte voornaam</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#gebruikteVoornaam">http://data.vlaanderen.be/ns/persoon#gebruikteVoornaam</seealso>
    let gebruikteVoornaam = Prefixed_Name(bperson, "gebruikteVoornaam") |> PrefixedName
    /// <summary>
    ///   <para>bperson:geslacht</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Het feit of de persoon een man of een vrouw is.</para>
    /// labels<para>geslacht</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#geslacht">http://data.vlaanderen.be/ns/persoon#geslacht</seealso>
    let geslacht = Prefixed_Name(bperson, "geslacht") |> PrefixedName
    /// <summary>
    ///   <para>bperson:gezinsadres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Verblijfplaats vh gezin.</para>
    /// labels<para>gezinsadres</para></remarks>
    /// <seealso href="http://data.vlaanderen.be/ns/persoon#gezinsadres">http://data.vlaanderen.be/ns/persoon#gezinsadres</seealso>
    let gezinsadres = Prefixed_Name(bperson, "gezinsadres") |> PrefixedName
