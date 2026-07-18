namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.MetadataFNDDatesAndTimes.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_dt_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/DatesAndTimesModule"></see>
    /// </summary>
    let DatesAndTimesModule =
        Namespaced_IRI.parse _namespace_name "DatesAndTimesModule" |> NamespacedName
