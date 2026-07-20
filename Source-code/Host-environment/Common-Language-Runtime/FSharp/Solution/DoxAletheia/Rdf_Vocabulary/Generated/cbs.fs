namespace http.betalinkeddata.cbs.nl.def.cbs.hash

open DoxAletheia

module cbs =
    let _namespace_name = "http://betalinkeddata.cbs.nl/def/cbs#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Buurt"></see>
    /// </summary>
    let Buurt = _prefix "Buurt"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Regio"></see>
    /// </summary>
    let Regio = _prefix "Regio"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Gemeente_Geografisch"></see>
    /// </summary>
    let Gemeente_Geografisch = _prefix "Gemeente_Geografisch"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Land_Geografisch"></see>
    /// </summary>
    let Land_Geografisch = _prefix "Land_Geografisch"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#Wijk"></see>
    /// </summary>
    let Wijk = _prefix "Wijk"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#indelingswijziging"></see>
    /// </summary>
    let indelingswijziging = _prefix "indelingswijziging"
    /// <summary>
    ///   <see href="http://betalinkeddata.cbs.nl/def/cbs#regiocode"></see>
    /// </summary>
    let regiocode = _prefix "regiocode"
