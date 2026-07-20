namespace http.qudt.org._2._1.vocab.sou.slash

open DoxAletheia

module sou =
    let _namespace_name = "http://qudt.org/2.1/vocab/sou/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
