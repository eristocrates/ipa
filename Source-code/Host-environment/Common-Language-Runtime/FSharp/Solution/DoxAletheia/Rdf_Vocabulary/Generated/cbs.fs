namespace http.betalinkeddata.cbs.nl.def.cbs.hash

open DoxAletheia.Rdf_Vocabulary

module cbs =
    let _namespace_name = "http://betalinkeddata.cbs.nl/def/cbs#"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Buurt"></see>
    /// </summary>
    let Buurt = Namespaced_IRI.parse _namespace_name "Buurt" |> NamespacedName
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Regio"></see>
    /// </summary>
    let Regio = Namespaced_IRI.parse _namespace_name "Regio" |> NamespacedName

    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Gemeente_Geografisch"></see>
    /// </summary>
    let Gemeente_Geografisch =
        Namespaced_IRI.parse _namespace_name "Gemeente_Geografisch" |> NamespacedName

    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Land_Geografisch"></see>
    /// </summary>
    let Land_Geografisch =
        Namespaced_IRI.parse _namespace_name "Land_Geografisch" |> NamespacedName

    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Wijk"></see>
    /// </summary>
    let Wijk = Namespaced_IRI.parse _namespace_name "Wijk" |> NamespacedName

    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#indelingswijziging"></see>
    /// </summary>
    let indelingswijziging =
        Namespaced_IRI.parse _namespace_name "indelingswijziging" |> NamespacedName

    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#regiocode"></see>
    /// </summary>
    let regiocode = Namespaced_IRI.parse _namespace_name "regiocode" |> NamespacedName
