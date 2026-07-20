namespace http.bag.basisregistraties.overheid.nl.def.bag.hash

open DoxAletheia

module bag2 =
    let _namespace_name = "http://bag.basisregistraties.overheid.nl/def/bag#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#AdministratiefGebied"></see>
    /// </summary>
    let AdministratiefGebied = _prefix "AdministratiefGebied"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#OpenbareRuimte"></see>
    /// </summary>
    let OpenbareRuimte = _prefix "OpenbareRuimte"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#AdresseerbaarObject"></see>
    /// </summary>
    let AdresseerbaarObject = _prefix "AdresseerbaarObject"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#BAG-object"></see>
    /// </summary>
    let ``BAG-object`` = _prefix "BAG-object"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Brondocument"></see>
    /// </summary>
    let Brondocument = _prefix "Brondocument"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Kunstwerk"></see>
    /// </summary>
    let Kunstwerk = _prefix "Kunstwerk"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#LandschappelijkGebied"></see>
    /// </summary>
    let LandschappelijkGebied = _prefix "LandschappelijkGebied"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Ligplaats"></see>
    /// </summary>
    let Ligplaats = _prefix "Ligplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Nummeraanduiding"></see>
    /// </summary>
    let Nummeraanduiding = _prefix "Nummeraanduiding"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Pand"></see>
    /// </summary>
    let Pand = _prefix "Pand"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Spoorbaan"></see>
    /// </summary>
    let Spoorbaan = _prefix "Spoorbaan"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Standplaats"></see>
    /// </summary>
    let Standplaats = _prefix "Standplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Terrein"></see>
    /// </summary>
    let Terrein = _prefix "Terrein"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Verblijfsobject"></see>
    /// </summary>
    let Verblijfsobject = _prefix "Verblijfsobject"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectBijeenkomstfunctie"></see>
    /// </summary>
    let VerblijfsobjectBijeenkomstfunctie = _prefix "VerblijfsobjectBijeenkomstfunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectCelfunctie"></see>
    /// </summary>
    let VerblijfsobjectCelfunctie = _prefix "VerblijfsobjectCelfunctie"

    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectGezondheidszorgfunctie"></see>
    /// </summary>
    let VerblijfsobjectGezondheidszorgfunctie =
        _prefix "VerblijfsobjectGezondheidszorgfunctie"

    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectIndustriefunctie"></see>
    /// </summary>
    let VerblijfsobjectIndustriefunctie = _prefix "VerblijfsobjectIndustriefunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectKantoorfunctie"></see>
    /// </summary>
    let VerblijfsobjectKantoorfunctie = _prefix "VerblijfsobjectKantoorfunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectLogiesfunctie"></see>
    /// </summary>
    let VerblijfsobjectLogiesfunctie = _prefix "VerblijfsobjectLogiesfunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOnderwijsfunctie"></see>
    /// </summary>
    let VerblijfsobjectOnderwijsfunctie = _prefix "VerblijfsobjectOnderwijsfunctie"

    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectOverigeGebruiksfunctie"></see>
    /// </summary>
    let VerblijfsobjectOverigeGebruiksfunctie =
        _prefix "VerblijfsobjectOverigeGebruiksfunctie"

    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectSportfunctie"></see>
    /// </summary>
    let VerblijfsobjectSportfunctie = _prefix "VerblijfsobjectSportfunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWinkelfunctie"></see>
    /// </summary>
    let VerblijfsobjectWinkelfunctie = _prefix "VerblijfsobjectWinkelfunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#VerblijfsobjectWoonfunctie"></see>
    /// </summary>
    let VerblijfsobjectWoonfunctie = _prefix "VerblijfsobjectWoonfunctie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Voorkomen"></see>
    /// </summary>
    let Voorkomen = _prefix "Voorkomen"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Water"></see>
    /// </summary>
    let Water = _prefix "Water"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Weg"></see>
    /// </summary>
    let Weg = _prefix "Weg"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#Woonplaats"></see>
    /// </summary>
    let Woonplaats = _prefix "Woonplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#aanduidingCorrectie"></see>
    /// </summary>
    let aanduidingCorrectie = _prefix "aanduidingCorrectie"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#aanduidingInactief"></see>
    /// </summary>
    let aanduidingInactief = _prefix "aanduidingInactief"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#beginGeldigheid"></see>
    /// </summary>
    let beginGeldigheid = _prefix "beginGeldigheid"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeOpenbareRuimte"></see>
    /// </summary>
    let bijbehorendeOpenbareRuimte = _prefix "bijbehorendeOpenbareRuimte"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#bijbehorendeWoonplaats"></see>
    /// </summary>
    let bijbehorendeWoonplaats = _prefix "bijbehorendeWoonplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#bron"></see>
    /// </summary>
    let bron = _prefix "bron"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#documentdatum"></see>
    /// </summary>
    let documentdatum = _prefix "documentdatum"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#documentnummer"></see>
    /// </summary>
    let documentnummer = _prefix "documentnummer"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#eindGeldigheid"></see>
    /// </summary>
    let eindGeldigheid = _prefix "eindGeldigheid"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#geconstateerd"></see>
    /// </summary>
    let geconstateerd = _prefix "geconstateerd"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieLigplaats"></see>
    /// </summary>
    let geometrieLigplaats = _prefix "geometrieLigplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#geometriePand"></see>
    /// </summary>
    let geometriePand = _prefix "geometriePand"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieStandplaats"></see>
    /// </summary>
    let geometrieStandplaats = _prefix "geometrieStandplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieVerblijfsobject"></see>
    /// </summary>
    let geometrieVerblijfsobject = _prefix "geometrieVerblijfsobject"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#geometrieWoonplaats"></see>
    /// </summary>
    let geometrieWoonplaats = _prefix "geometrieWoonplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#hoofdadres"></see>
    /// </summary>
    let hoofdadres = _prefix "hoofdadres"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#huisletter"></see>
    /// </summary>
    let huisletter = _prefix "huisletter"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#huisnummer"></see>
    /// </summary>
    let huisnummer = _prefix "huisnummer"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#huisnummertoevoeging"></see>
    /// </summary>
    let huisnummertoevoeging = _prefix "huisnummertoevoeging"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#identificatiecode"></see>
    /// </summary>
    let identificatiecode = _prefix "identificatiecode"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#inOnderzoek"></see>
    /// </summary>
    let inOnderzoek = _prefix "inOnderzoek"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#naamOpenbareRuimte"></see>
    /// </summary>
    let naamOpenbareRuimte = _prefix "naamOpenbareRuimte"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#naamWoonplaats"></see>
    /// </summary>
    let naamWoonplaats = _prefix "naamWoonplaats"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#nevenadres"></see>
    /// </summary>
    let nevenadres = _prefix "nevenadres"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#oorspronkelijkBouwjaar"></see>
    /// </summary>
    let oorspronkelijkBouwjaar = _prefix "oorspronkelijkBouwjaar"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#oppervlakte"></see>
    /// </summary>
    let oppervlakte = _prefix "oppervlakte"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#pandrelatering"></see>
    /// </summary>
    let pandrelatering = _prefix "pandrelatering"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#postcode"></see>
    /// </summary>
    let postcode = _prefix "postcode"
    /// <summary>
    ///   <see href="http://bag.basisregistraties.overheid.nl/def/bag#status"></see>
    /// </summary>
    let status = _prefix "status"
