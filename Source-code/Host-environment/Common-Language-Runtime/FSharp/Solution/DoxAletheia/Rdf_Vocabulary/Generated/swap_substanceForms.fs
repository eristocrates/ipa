namespace http.eulersharp.sourceforge.net._2003._03swap.substanceForms.hash

open DoxAletheia

module swap_substanceForms =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#GranularSubstance"></see>
    /// </summary>
    let GranularSubstance = _prefix "GranularSubstance"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#Powder"></see>
    /// </summary>
    let Powder = _prefix "Powder"
