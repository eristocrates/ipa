namespace https.www.purl.org.mso_em.hash

open DoxAletheia

module mso_em =
    let _namespace_name = "https://www.purl.org/mso-em#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
