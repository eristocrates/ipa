namespace http.data.vlaanderen.be.ns.persoon.hash

open DoxAletheia

module bperson =
    let _namespace_name = "http://data.vlaanderen.be/ns/persoon#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Afstamming"></see>
    /// </summary>
    let Afstamming = _prefix "Afstamming"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Persoonsrelatie"></see>
    /// </summary>
    let Persoonsrelatie = _prefix "Persoonsrelatie"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#BurgerlijkeStaat"></see>
    /// </summary>
    let BurgerlijkeStaat = _prefix "BurgerlijkeStaat"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Domicilie"></see>
    /// </summary>
    let Domicilie = _prefix "Domicilie"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Verblijfplaats"></see>
    /// </summary>
    let Verblijfplaats = _prefix "Verblijfplaats"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Geboorte"></see>
    /// </summary>
    let Geboorte = _prefix "Geboorte"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Persoonsgebeurtenis"></see>
    /// </summary>
    let Persoonsgebeurtenis = _prefix "Persoonsgebeurtenis"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#GeenInwoner"></see>
    /// </summary>
    let GeenInwoner = _prefix "GeenInwoner"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Inwonerschap"></see>
    /// </summary>
    let Inwonerschap = _prefix "Inwonerschap"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#GeregistreerdPersoon"></see>
    /// </summary>
    let GeregistreerdPersoon = _prefix "GeregistreerdPersoon"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Gezin"></see>
    /// </summary>
    let Gezin = _prefix "Gezin"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Gezinsrelatie"></see>
    /// </summary>
    let Gezinsrelatie = _prefix "Gezinsrelatie"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Huwelijk"></see>
    /// </summary>
    let Huwelijk = _prefix "Huwelijk"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Inwoner"></see>
    /// </summary>
    let Inwoner = _prefix "Inwoner"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Inwonerschap.binnenJurisdictie"></see>
    /// </summary>
    let ``Inwonerschap.binnenJurisdictie`` = _prefix "Inwonerschap.binnenJurisdictie"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Nationaliteit"></see>
    /// </summary>
    let Nationaliteit = _prefix "Nationaliteit"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Overlijden"></see>
    /// </summary>
    let Overlijden = _prefix "Overlijden"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#PermanentInwoner"></see>
    /// </summary>
    let PermanentInwoner = _prefix "PermanentInwoner"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Samenwonen"></see>
    /// </summary>
    let Samenwonen = _prefix "Samenwonen"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Staatsburger"></see>
    /// </summary>
    let Staatsburger = _prefix "Staatsburger"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap"></see>
    /// </summary>
    let Staatsburgerschap = _prefix "Staatsburgerschap"

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Staatsburgerschap.binnenJurisdictie"></see>
    /// </summary>
    let ``Staatsburgerschap.binnenJurisdictie`` =
        _prefix "Staatsburgerschap.binnenJurisdictie"

    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#TijdelijkInwoner"></see>
    /// </summary>
    let TijdelijkInwoner = _prefix "TijdelijkInwoner"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Voogdij"></see>
    /// </summary>
    let Voogdij = _prefix "Voogdij"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#Vreemdeling"></see>
    /// </summary>
    let Vreemdeling = _prefix "Vreemdeling"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#afstammingsType"></see>
    /// </summary>
    let afstammingsType = _prefix "afstammingsType"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#datum"></see>
    /// </summary>
    let datum = _prefix "datum"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#datumVanAfstamming"></see>
    /// </summary>
    let datumVanAfstamming = _prefix "datumVanAfstamming"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#gebruikteVoornaam"></see>
    /// </summary>
    let gebruikteVoornaam = _prefix "gebruikteVoornaam"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#geslacht"></see>
    /// </summary>
    let geslacht = _prefix "geslacht"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#gezinsadres"></see>
    /// </summary>
    let gezinsadres = _prefix "gezinsadres"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#gezinsrelatietype"></see>
    /// </summary>
    let gezinsrelatietype = _prefix "gezinsrelatietype"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftBurgerlijkeStaat"></see>
    /// </summary>
    let heeftBurgerlijkeStaat = _prefix "heeftBurgerlijkeStaat"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftGeboorte"></see>
    /// </summary>
    let heeftGeboorte = _prefix "heeftGeboorte"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftInwonerschap"></see>
    /// </summary>
    let heeftInwonerschap = _prefix "heeftInwonerschap"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftNationaliteit"></see>
    /// </summary>
    let heeftNationaliteit = _prefix "heeftNationaliteit"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftOverlijden"></see>
    /// </summary>
    let heeftOverlijden = _prefix "heeftOverlijden"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftPersoonsrelatie"></see>
    /// </summary>
    let heeftPersoonsrelatie = _prefix "heeftPersoonsrelatie"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftStaatsburgerschap"></see>
    /// </summary>
    let heeftStaatsburgerschap = _prefix "heeftStaatsburgerschap"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#heeftVerblijfplaats"></see>
    /// </summary>
    let heeftVerblijfplaats = _prefix "heeftVerblijfplaats"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#isHoofdVan"></see>
    /// </summary>
    let isHoofdVan = _prefix "isHoofdVan"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#isLidVan"></see>
    /// </summary>
    let isLidVan = _prefix "isLidVan"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#isRelatieMet"></see>
    /// </summary>
    let isRelatieMet = _prefix "isRelatieMet"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#nationaliteit"></see>
    /// </summary>
    let nationaliteit = _prefix "nationaliteit"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#plaats"></see>
    /// </summary>
    let plaats = _prefix "plaats"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#registratie"></see>
    /// </summary>
    let registratie = _prefix "registratie"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#verblijfsadres"></see>
    /// </summary>
    let verblijfsadres = _prefix "verblijfsadres"
    /// <summary>
    ///   <see href="http://data.vlaanderen.be/ns/persoon#volledigeNaam"></see>
    /// </summary>
    let volledigeNaam = _prefix "volledigeNaam"
