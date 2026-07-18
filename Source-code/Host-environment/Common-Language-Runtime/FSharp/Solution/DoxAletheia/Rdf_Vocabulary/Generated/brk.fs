namespace http.brk.basisregistraties.overheid.nl.def.brk.hash

open DoxAletheia.Rdf_Vocabulary

module brk =
    let _namespace_name = "http://brk.basisregistraties.overheid.nl/def/brk#"

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#KadastraleGrens"></see>
    /// </summary>
    let KadastraleGrens =
        Namespaced_IRI.parse _namespace_name "KadastraleGrens" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#Perceel"></see>
    /// </summary>
    let Perceel = Namespaced_IRI.parse _namespace_name "Perceel" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#begrenzingPerceel"></see>
    /// </summary>
    let begrenzingPerceel =
        Namespaced_IRI.parse _namespace_name "begrenzingPerceel" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#grenslijn"></see>
    /// </summary>
    let grenslijn = Namespaced_IRI.parse _namespace_name "grenslijn" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGemeente"></see>
    /// </summary>
    let kadastraleGemeente =
        Namespaced_IRI.parse _namespace_name "kadastraleGemeente" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGrootte"></see>
    /// </summary>
    let kadastraleGrootte =
        Namespaced_IRI.parse _namespace_name "kadastraleGrootte" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummer"></see>
    /// </summary>
    let perceelnummer =
        Namespaced_IRI.parse _namespace_name "perceelnummer" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummerRotatie"></see>
    /// </summary>
    let perceelnummerRotatie =
        Namespaced_IRI.parse _namespace_name "perceelnummerRotatie" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#plaatscoordinaten"></see>
    /// </summary>
    let plaatscoordinaten =
        Namespaced_IRI.parse _namespace_name "plaatscoordinaten" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#sectie"></see>
    /// </summary>
    let sectie = Namespaced_IRI.parse _namespace_name "sectie" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#soortGrootte"></see>
    /// </summary>
    let soortGrootte =
        Namespaced_IRI.parse _namespace_name "soortGrootte" |> NamespacedName

    /// <summary>
    ///   <see href="http://brk.basisregistraties.overheid.nl/def/brk#typeGrens"></see>
    /// </summary>
    let typeGrens = Namespaced_IRI.parse _namespace_name "typeGrens" |> NamespacedName
