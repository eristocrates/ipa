namespace http.qudt.org.vocab.soqk.bare

open DoxAletheia

module qudt_soqk =
    let _namespace_name = "http://qudt.org/vocab/soqk"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS"></see>
    /// </summary>
    let ``_/CGS`` = _prefix "/CGS"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS-EMU"></see>
    /// </summary>
    let ``_/CGS-EMU`` = _prefix "/CGS-EMU"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS-ESU"></see>
    /// </summary>
    let ``_/CGS-ESU`` = _prefix "/CGS-ESU"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/CGS-Gauss"></see>
    /// </summary>
    let ``_/CGS-Gauss`` = _prefix "/CGS-Gauss"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/IMPERIAL"></see>
    /// </summary>
    let ``_/IMPERIAL`` = _prefix "/IMPERIAL"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/ISQ"></see>
    /// </summary>
    let ``_/ISQ`` = _prefix "/ISQ"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/Planck"></see>
    /// </summary>
    let ``_/Planck`` = _prefix "/Planck"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/SI"></see>
    /// </summary>
    let ``_/SI`` = _prefix "/SI"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/soqk/USCS"></see>
    /// </summary>
    let ``_/USCS`` = _prefix "/USCS"
