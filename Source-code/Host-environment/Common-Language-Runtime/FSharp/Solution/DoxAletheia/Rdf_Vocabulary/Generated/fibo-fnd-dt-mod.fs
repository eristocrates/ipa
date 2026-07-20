namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.MetadataFNDDatesAndTimes.slash

open DoxAletheia

module fibo_fnd_dt_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/DatesAndTimesModule"></see>
    /// </summary>
    let DatesAndTimesModule = _prefix "DatesAndTimesModule"
