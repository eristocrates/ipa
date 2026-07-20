namespace http.linkeddata.finki.ukim.mk.lod.ontology.cfrl.hash

open DoxAletheia

module cfrl =
    let _namespace_name = "http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This property links a Company with a Loan instance.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasLoan"></see></summary>
    let hasLoan = _prefix "hasLoan"
    /// <summary>
    /// This property links a Company with a Financial Report instance.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasReport"></see></summary>
    let hasReport = _prefix "hasReport"
