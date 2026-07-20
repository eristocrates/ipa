namespace http.purl.oclc.org.NET.muo.ucum.slash

open DoxAletheia

module ucum =
    let _namespace_name = "http://purl.oclc.org/NET/muo/ucum/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
