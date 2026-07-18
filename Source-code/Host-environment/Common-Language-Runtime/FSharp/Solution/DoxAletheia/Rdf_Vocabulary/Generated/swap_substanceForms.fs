namespace http.eulersharp.sourceforge.net._2003._03swap.substanceForms.hash

open DoxAletheia.Rdf_Vocabulary

module swap_substanceForms =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#GranularSubstance"></see>
    /// </summary>
    let GranularSubstance =
        Namespaced_IRI.parse _namespace_name "GranularSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#Powder"></see>
    /// </summary>
    let Powder = Namespaced_IRI.parse _namespace_name "Powder" |> NamespacedName
