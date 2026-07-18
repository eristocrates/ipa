namespace http.linkeddata.finki.ukim.mk.lod.ontology.cfrl.hash

open DoxAletheia.Rdf_Vocabulary

module cfrl =
    let _namespace_name = "http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#"
    /// <summary>
    /// This property links a Company with a Loan instance.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasLoan"></see></summary>
    let hasLoan = Namespaced_IRI.parse _namespace_name "hasLoan" |> NamespacedName
    /// <summary>
    /// This property links a Company with a Financial Report instance.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasReport"></see></summary>
    let hasReport = Namespaced_IRI.parse _namespace_name "hasReport" |> NamespacedName
