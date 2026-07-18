namespace http.qudt.org.vocab.soqk.bare

open DoxAletheia.Rdf_Vocabulary

module qudt_soqk =
    let _namespace_name = "http://qudt.org/vocab/soqk"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS"></see>
    /// </summary>
    let ``_/CGS`` = Namespaced_IRI.parse _namespace_name "/CGS" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS-EMU"></see>
    /// </summary>
    let ``_/CGS-EMU`` =
        Namespaced_IRI.parse _namespace_name "/CGS-EMU" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS-ESU"></see>
    /// </summary>
    let ``_/CGS-ESU`` =
        Namespaced_IRI.parse _namespace_name "/CGS-ESU" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS-Gauss"></see>
    /// </summary>
    let ``_/CGS-Gauss`` =
        Namespaced_IRI.parse _namespace_name "/CGS-Gauss" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/IMPERIAL"></see>
    /// </summary>
    let ``_/IMPERIAL`` =
        Namespaced_IRI.parse _namespace_name "/IMPERIAL" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/ISQ"></see>
    /// </summary>
    let ``_/ISQ`` = Namespaced_IRI.parse _namespace_name "/ISQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/Planck"></see>
    /// </summary>
    let ``_/Planck`` = Namespaced_IRI.parse _namespace_name "/Planck" |> NamespacedName
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/SI"></see>
    /// </summary>
    let ``_/SI`` = Namespaced_IRI.parse _namespace_name "/SI" |> NamespacedName
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/USCS"></see>
    /// </summary>
    let ``_/USCS`` = Namespaced_IRI.parse _namespace_name "/USCS" |> NamespacedName
