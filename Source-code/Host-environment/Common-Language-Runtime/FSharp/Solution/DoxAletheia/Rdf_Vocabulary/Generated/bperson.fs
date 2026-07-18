namespace http.data.vlaanderen.be.ns.persoon.hash

open DoxAletheia.Rdf_Vocabulary

module bperson =
    let _namespace_name = "http://data.vlaanderen.be/ns/persoon#"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Afstamming"></see>
    /// </summary>
    let Afstamming = Namespaced_IRI.parse _namespace_name "Afstamming" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Persoonsrelatie"></see>
    /// </summary>
    let Persoonsrelatie =
        Namespaced_IRI.parse _namespace_name "Persoonsrelatie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#BurgerlijkeStaat"></see>
    /// </summary>
    let BurgerlijkeStaat =
        Namespaced_IRI.parse _namespace_name "BurgerlijkeStaat" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Domicilie"></see>
    /// </summary>
    let Domicilie = Namespaced_IRI.parse _namespace_name "Domicilie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Verblijfplaats"></see>
    /// </summary>
    let Verblijfplaats =
        Namespaced_IRI.parse _namespace_name "Verblijfplaats" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Geboorte"></see>
    /// </summary>
    let Geboorte = Namespaced_IRI.parse _namespace_name "Geboorte" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Persoonsgebeurtenis"></see>
    /// </summary>
    let Persoonsgebeurtenis =
        Namespaced_IRI.parse _namespace_name "Persoonsgebeurtenis" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#GeenInwoner"></see>
    /// </summary>
    let GeenInwoner =
        Namespaced_IRI.parse _namespace_name "GeenInwoner" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Inwonerschap"></see>
    /// </summary>
    let Inwonerschap =
        Namespaced_IRI.parse _namespace_name "Inwonerschap" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#GeregistreerdPersoon"></see>
    /// </summary>
    let GeregistreerdPersoon =
        Namespaced_IRI.parse _namespace_name "GeregistreerdPersoon" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Gezin"></see>
    /// </summary>
    let Gezin = Namespaced_IRI.parse _namespace_name "Gezin" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Gezinsrelatie"></see>
    /// </summary>
    let Gezinsrelatie =
        Namespaced_IRI.parse _namespace_name "Gezinsrelatie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Huwelijk"></see>
    /// </summary>
    let Huwelijk = Namespaced_IRI.parse _namespace_name "Huwelijk" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Inwoner"></see>
    /// </summary>
    let Inwoner = Namespaced_IRI.parse _namespace_name "Inwoner" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Inwonerschap.binnenJurisdictie"></see>
    /// </summary>
    let ``Inwonerschap.binnenJurisdictie`` =
        Namespaced_IRI.parse _namespace_name "Inwonerschap.binnenJurisdictie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Nationaliteit"></see>
    /// </summary>
    let Nationaliteit =
        Namespaced_IRI.parse _namespace_name "Nationaliteit" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Overlijden"></see>
    /// </summary>
    let Overlijden = Namespaced_IRI.parse _namespace_name "Overlijden" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#PermanentInwoner"></see>
    /// </summary>
    let PermanentInwoner =
        Namespaced_IRI.parse _namespace_name "PermanentInwoner" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Samenwonen"></see>
    /// </summary>
    let Samenwonen = Namespaced_IRI.parse _namespace_name "Samenwonen" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Staatsburger"></see>
    /// </summary>
    let Staatsburger =
        Namespaced_IRI.parse _namespace_name "Staatsburger" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap"></see>
    /// </summary>
    let Staatsburgerschap =
        Namespaced_IRI.parse _namespace_name "Staatsburgerschap" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap.binnenJurisdictie"></see>
    /// </summary>
    let ``Staatsburgerschap.binnenJurisdictie`` =
        Namespaced_IRI.parse _namespace_name "Staatsburgerschap.binnenJurisdictie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#TijdelijkInwoner"></see>
    /// </summary>
    let TijdelijkInwoner =
        Namespaced_IRI.parse _namespace_name "TijdelijkInwoner" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Voogdij"></see>
    /// </summary>
    let Voogdij = Namespaced_IRI.parse _namespace_name "Voogdij" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Vreemdeling"></see>
    /// </summary>
    let Vreemdeling =
        Namespaced_IRI.parse _namespace_name "Vreemdeling" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#afstammingsType"></see>
    /// </summary>
    let afstammingsType =
        Namespaced_IRI.parse _namespace_name "afstammingsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#datum"></see>
    /// </summary>
    let datum = Namespaced_IRI.parse _namespace_name "datum" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#datumVanAfstamming"></see>
    /// </summary>
    let datumVanAfstamming =
        Namespaced_IRI.parse _namespace_name "datumVanAfstamming" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#gebruikteVoornaam"></see>
    /// </summary>
    let gebruikteVoornaam =
        Namespaced_IRI.parse _namespace_name "gebruikteVoornaam" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#geslacht"></see>
    /// </summary>
    let geslacht = Namespaced_IRI.parse _namespace_name "geslacht" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#gezinsadres"></see>
    /// </summary>
    let gezinsadres =
        Namespaced_IRI.parse _namespace_name "gezinsadres" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#gezinsrelatietype"></see>
    /// </summary>
    let gezinsrelatietype =
        Namespaced_IRI.parse _namespace_name "gezinsrelatietype" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftBurgerlijkeStaat"></see>
    /// </summary>
    let heeftBurgerlijkeStaat =
        Namespaced_IRI.parse _namespace_name "heeftBurgerlijkeStaat" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftGeboorte"></see>
    /// </summary>
    let heeftGeboorte =
        Namespaced_IRI.parse _namespace_name "heeftGeboorte" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftInwonerschap"></see>
    /// </summary>
    let heeftInwonerschap =
        Namespaced_IRI.parse _namespace_name "heeftInwonerschap" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftNationaliteit"></see>
    /// </summary>
    let heeftNationaliteit =
        Namespaced_IRI.parse _namespace_name "heeftNationaliteit" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftOverlijden"></see>
    /// </summary>
    let heeftOverlijden =
        Namespaced_IRI.parse _namespace_name "heeftOverlijden" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftPersoonsrelatie"></see>
    /// </summary>
    let heeftPersoonsrelatie =
        Namespaced_IRI.parse _namespace_name "heeftPersoonsrelatie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftStaatsburgerschap"></see>
    /// </summary>
    let heeftStaatsburgerschap =
        Namespaced_IRI.parse _namespace_name "heeftStaatsburgerschap" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftVerblijfplaats"></see>
    /// </summary>
    let heeftVerblijfplaats =
        Namespaced_IRI.parse _namespace_name "heeftVerblijfplaats" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#isHoofdVan"></see>
    /// </summary>
    let isHoofdVan = Namespaced_IRI.parse _namespace_name "isHoofdVan" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#isLidVan"></see>
    /// </summary>
    let isLidVan = Namespaced_IRI.parse _namespace_name "isLidVan" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#isRelatieMet"></see>
    /// </summary>
    let isRelatieMet =
        Namespaced_IRI.parse _namespace_name "isRelatieMet" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#nationaliteit"></see>
    /// </summary>
    let nationaliteit =
        Namespaced_IRI.parse _namespace_name "nationaliteit" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#plaats"></see>
    /// </summary>
    let plaats = Namespaced_IRI.parse _namespace_name "plaats" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#registratie"></see>
    /// </summary>
    let registratie =
        Namespaced_IRI.parse _namespace_name "registratie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#verblijfsadres"></see>
    /// </summary>
    let verblijfsadres =
        Namespaced_IRI.parse _namespace_name "verblijfsadres" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#volledigeNaam"></see>
    /// </summary>
    let volledigeNaam =
        Namespaced_IRI.parse _namespace_name "volledigeNaam" |> NamespacedName
