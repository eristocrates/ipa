namespace http.brk.basisregistraties.overheid.nl.def.brk.hash

open DoxAletheia

module brk =
    let _namespace_name = "http://brk.basisregistraties.overheid.nl/def/brk#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#KadastraleGrens"></see>
    /// </summary>
    let KadastraleGrens = _prefix "KadastraleGrens"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#Perceel"></see>
    /// </summary>
    let Perceel = _prefix "Perceel"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#begrenzingPerceel"></see>
    /// </summary>
    let begrenzingPerceel = _prefix "begrenzingPerceel"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#grenslijn"></see>
    /// </summary>
    let grenslijn = _prefix "grenslijn"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGemeente"></see>
    /// </summary>
    let kadastraleGemeente = _prefix "kadastraleGemeente"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGrootte"></see>
    /// </summary>
    let kadastraleGrootte = _prefix "kadastraleGrootte"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummer"></see>
    /// </summary>
    let perceelnummer = _prefix "perceelnummer"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummerRotatie"></see>
    /// </summary>
    let perceelnummerRotatie = _prefix "perceelnummerRotatie"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#plaatscoordinaten"></see>
    /// </summary>
    let plaatscoordinaten = _prefix "plaatscoordinaten"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#sectie"></see>
    /// </summary>
    let sectie = _prefix "sectie"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#soortGrootte"></see>
    /// </summary>
    let soortGrootte = _prefix "soortGrootte"
    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#typeGrens"></see>
    /// </summary>
    let typeGrens = _prefix "typeGrens"
