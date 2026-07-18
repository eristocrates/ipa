namespace http.dh.aks.ac.kr.ontologies.ekc.hash

open DoxAletheia.Rdf_Vocabulary

module ekc =
    let _namespace_name = "http://dh.aks.ac.kr/ontologies/ekc#"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4"></see>
    /// </summary>
    let ``_%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4`` =
        Namespaced_IRI.parse _namespace_name "%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Concept"></see>
    /// </summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95"></see>
    /// </summary>
    let ``_%EA%B1%B4%EC%B6%95`` =
        Namespaced_IRI.parse _namespace_name "%EA%B1%B4%EC%B6%95" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Architecture"></see>
    /// </summary>
    let Architecture =
        Namespaced_IRI.parse _namespace_name "Architecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88"></see>
    /// </summary>
    let ``_%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88`` =
        Namespaced_IRI.parse _namespace_name "%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%EA%B3%A0%EB%AC%B8%ED%97%8C`` =
        Namespaced_IRI.parse _namespace_name "%EA%B3%A0%EB%AC%B8%ED%97%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Bibliography"></see>
    /// </summary>
    let Bibliography =
        Namespaced_IRI.parse _namespace_name "Bibliography" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EC%A7%80%EB%AA%85"></see>
    /// </summary>
    let ``_%EA%B3%A0%EC%A7%80%EB%AA%85`` =
        Namespaced_IRI.parse _namespace_name "%EA%B3%A0%EC%A7%80%EB%AA%85" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%84%9C"></see>
    /// </summary>
    let ``_%EA%B4%80%EC%84%9C`` =
        Namespaced_IRI.parse _namespace_name "%EA%B4%80%EC%84%9C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Actor"></see>
    /// </summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%A7%81"></see>
    /// </summary>
    let ``_%EA%B4%80%EC%A7%81`` =
        Namespaced_IRI.parse _namespace_name "%EA%B4%80%EC%A7%81" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EA%B0%80"></see>
    /// </summary>
    let ``_%EA%B5%AD%EA%B0%80`` =
        Namespaced_IRI.parse _namespace_name "%EA%B5%AD%EA%B0%80" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EB%B3%B4"></see>
    /// </summary>
    let ``_%EA%B5%AD%EB%B3%B4`` =
        Namespaced_IRI.parse _namespace_name "%EA%B5%AD%EB%B3%B4" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Heritage"></see>
    /// </summary>
    let Heritage = Namespaced_IRI.parse _namespace_name "Heritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%B8%EB%A6%BC"></see>
    /// </summary>
    let ``_%EA%B7%B8%EB%A6%BC`` =
        Namespaced_IRI.parse _namespace_name "%EA%B7%B8%EB%A6%BC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#WebResource"></see>
    /// </summary>
    let WebResource =
        Namespaced_IRI.parse _namespace_name "WebResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        Namespaced_IRI.parse _namespace_name "%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Record"></see>
    /// </summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80"></see>
    /// </summary>
    let ``_%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        Namespaced_IRI.parse _namespace_name "%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%88%EC%84%9D%EB%AC%B8"></see>
    /// </summary>
    let ``_%EA%B8%88%EC%84%9D%EB%AC%B8`` =
        Namespaced_IRI.parse _namespace_name "%EA%B8%88%EC%84%9D%EB%AC%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EA%B4%80"></see>
    /// </summary>
    let ``_%EA%B8%B0%EA%B4%80`` =
        Namespaced_IRI.parse _namespace_name "%EA%B8%B0%EA%B4%80" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EB%85%90%EB%AC%BC"></see>
    /// </summary>
    let ``_%EA%B8%B0%EB%85%90%EB%AC%BC`` =
        Namespaced_IRI.parse _namespace_name "%EA%B8%B0%EB%85%90%EB%AC%BC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%82%AC"></see>
    /// </summary>
    let ``_%EA%B8%B0%EC%82%AC`` =
        Namespaced_IRI.parse _namespace_name "%EA%B8%B0%EC%82%AC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%9E%A5"></see>
    /// </summary>
    let ``_%EA%B8%B0%EC%9E%A5`` =
        Namespaced_IRI.parse _namespace_name "%EA%B8%B0%EC%9E%A5" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%85%BC%EB%AC%B8"></see>
    /// </summary>
    let ``_%EB%85%BC%EB%AC%B8`` =
        Namespaced_IRI.parse _namespace_name "%EB%85%BC%EB%AC%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%EC%B2%B4"></see>
    /// </summary>
    let ``_%EB%8B%A8%EC%B2%B4`` =
        Namespaced_IRI.parse _namespace_name "%EB%8B%A8%EC%B2%B4" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%ED%96%89%EB%B3%B8"></see>
    /// </summary>
    let ``_%EB%8B%A8%ED%96%89%EB%B3%B8`` =
        Namespaced_IRI.parse _namespace_name "%EB%8B%A8%ED%96%89%EB%B3%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%84%EB%A9%B4"></see>
    /// </summary>
    let ``_%EB%8F%84%EB%A9%B4`` =
        Namespaced_IRI.parse _namespace_name "%EB%8F%84%EB%A9%B4" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%99%EC%98%81%EC%83%81"></see>
    /// </summary>
    let ``_%EB%8F%99%EC%98%81%EC%83%81`` =
        Namespaced_IRI.parse _namespace_name "%EB%8F%99%EC%98%81%EC%83%81" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC"></see>
    /// </summary>
    let ``_%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        Namespaced_IRI.parse _namespace_name "%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87"></see>
    /// </summary>
    let ``_%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87`` =
        Namespaced_IRI.parse _namespace_name "%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Text"></see>
    /// </summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%EC%9A%A9"></see>
    /// </summary>
    let ``_%EB%AC%B4%EC%9A%A9`` =
        Namespaced_IRI.parse _namespace_name "%EB%AC%B4%EC%9A%A9" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%ED%98%95"></see>
    /// </summary>
    let ``_%EB%AC%B4%ED%98%95`` =
        Namespaced_IRI.parse _namespace_name "%EB%AC%B4%ED%98%95" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%95%99"></see>
    /// </summary>
    let ``_%EB%AC%B8%ED%95%99`` =
        Namespaced_IRI.parse _namespace_name "%EB%AC%B8%ED%95%99" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%EB%AC%B8%ED%97%8C`` =
        Namespaced_IRI.parse _namespace_name "%EB%AC%B8%ED%97%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%BC%ED%92%88"></see>
    /// </summary>
    let ``_%EB%AC%BC%ED%92%88`` =
        Namespaced_IRI.parse _namespace_name "%EB%AC%BC%ED%92%88" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AE%A4%EC%A7%80%EC%BB%AC"></see>
    /// </summary>
    let ``_%EB%AE%A4%EC%A7%80%EC%BB%AC`` =
        Namespaced_IRI.parse _namespace_name "%EB%AE%A4%EC%A7%80%EC%BB%AC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AF%B8%EC%88%A0"></see>
    /// </summary>
    let ``_%EB%AF%B8%EC%88%A0`` =
        Namespaced_IRI.parse _namespace_name "%EB%AF%B8%EC%88%A0" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B2%88%EC%97%AD%EB%AC%B8"></see>
    /// </summary>
    let ``_%EB%B2%88%EC%97%AD%EB%AC%B8`` =
        Namespaced_IRI.parse _namespace_name "%EB%B2%88%EC%97%AD%EB%AC%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B4%EB%AC%BC"></see>
    /// </summary>
    let ``_%EB%B3%B4%EB%AC%BC`` =
        Namespaced_IRI.parse _namespace_name "%EB%B3%B4%EB%AC%BC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%8B%9D"></see>
    /// </summary>
    let ``_%EB%B3%B5%EC%8B%9D`` =
        Namespaced_IRI.parse _namespace_name "%EB%B3%B5%EC%8B%9D" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Clothing"></see>
    /// </summary>
    let Clothing = Namespaced_IRI.parse _namespace_name "Clothing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%9E%A5"></see>
    /// </summary>
    let ``_%EB%B3%B5%EC%9E%A5`` =
        Namespaced_IRI.parse _namespace_name "%EB%B3%B5%EC%9E%A5" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C"></see>
    /// </summary>
    let ``_%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C`` =
        Namespaced_IRI.parse _namespace_name "%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EA%B1%B4"></see>
    /// </summary>
    let ``_%EC%82%AC%EA%B1%B4`` =
        Namespaced_IRI.parse _namespace_name "%EC%82%AC%EA%B1%B4" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A0%81"></see>
    /// </summary>
    let ``_%EC%82%AC%EC%A0%81`` =
        Namespaced_IRI.parse _namespace_name "%EC%82%AC%EC%A0%81" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A7%84"></see>
    /// </summary>
    let ``_%EC%82%AC%EC%A7%84`` =
        Namespaced_IRI.parse _namespace_name "%EC%82%AC%EC%A7%84" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%83%81%EC%B0%A8%EB%A6%BC"></see>
    /// </summary>
    let ``_%EC%83%81%EC%B0%A8%EB%A6%BC`` =
        Namespaced_IRI.parse _namespace_name "%EC%83%81%EC%B0%A8%EB%A6%BC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Food"></see>
    /// </summary>
    let Food = Namespaced_IRI.parse _namespace_name "Food" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%86%8C%EC%9E%A5%EC%B2%98"></see>
    /// </summary>
    let ``_%EC%86%8C%EC%9E%A5%EC%B2%98`` =
        Namespaced_IRI.parse _namespace_name "%EC%86%8C%EC%9E%A5%EC%B2%98" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8"></see>
    /// </summary>
    let ``_%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8`` =
        Namespaced_IRI.parse _namespace_name "%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Story"></see>
    /// </summary>
    let Story = Namespaced_IRI.parse _namespace_name "Story" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C"></see>
    /// </summary>
    let ``_%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C`` =
        Namespaced_IRI.parse _namespace_name "%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C"></see>
    /// </summary>
    let ``_%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C`` =
        Namespaced_IRI.parse _namespace_name "%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC"></see>
    /// </summary>
    let ``_%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        Namespaced_IRI.parse _namespace_name "%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9D%EC%9E%AC%EB%A3%8C"></see>
    /// </summary>
    let ``_%EC%8B%9D%EC%9E%AC%EB%A3%8C`` =
        Namespaced_IRI.parse _namespace_name "%EC%8B%9D%EC%9E%AC%EB%A3%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%B0%EA%B7%B9"></see>
    /// </summary>
    let ``_%EC%97%B0%EA%B7%B9`` =
        Namespaced_IRI.parse _namespace_name "%EC%97%B0%EA%B7%B9" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%98%81%ED%99%94"></see>
    /// </summary>
    let ``_%EC%98%81%ED%99%94`` =
        Namespaced_IRI.parse _namespace_name "%EC%98%81%ED%99%94" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%90%EB%AC%B8"></see>
    /// </summary>
    let ``_%EC%9B%90%EB%AC%B8`` =
        Namespaced_IRI.parse _namespace_name "%EC%9B%90%EB%AC%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8"></see>
    /// </summary>
    let ``_%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8`` =
        Namespaced_IRI.parse _namespace_name "%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Index"></see>
    /// </summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9C%A0%EC%A0%81%EC%A7%80"></see>
    /// </summary>
    let ``_%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        Namespaced_IRI.parse _namespace_name "%EC%9C%A0%EC%A0%81%EC%A7%80" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%8B%9D"></see>
    /// </summary>
    let ``_%EC%9D%8C%EC%8B%9D`` =
        Namespaced_IRI.parse _namespace_name "%EC%9D%8C%EC%8B%9D" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%95%85"></see>
    /// </summary>
    let ``_%EC%9D%8C%EC%95%85`` =
        Namespaced_IRI.parse _namespace_name "%EC%9D%8C%EC%95%85" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%98%EB%A1%80"></see>
    /// </summary>
    let ``_%EC%9D%98%EB%A1%80`` =
        Namespaced_IRI.parse _namespace_name "%EC%9D%98%EB%A1%80" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC"></see>
    /// </summary>
    let ``_%EC%9D%B8%EB%AC%BC`` =
        Namespaced_IRI.parse _namespace_name "%EC%9D%B8%EB%AC%BC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC%EA%B5%B0"></see>
    /// </summary>
    let ``_%EC%9D%B8%EB%AC%BC%EA%B5%B0`` =
        Namespaced_IRI.parse _namespace_name "%EC%9D%B8%EB%AC%BC%EA%B5%B0" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85"></see>
    /// </summary>
    let ``_%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85`` =
        Namespaced_IRI.parse _namespace_name "%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%A5%EC%86%8C"></see>
    /// </summary>
    let ``_%EC%9E%A5%EC%86%8C`` =
        Namespaced_IRI.parse _namespace_name "%EC%9E%A5%EC%86%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%84%EC%8B%9C"></see>
    /// </summary>
    let ``_%EC%A0%84%EC%8B%9C`` =
        Namespaced_IRI.parse _namespace_name "%EC%A0%84%EC%8B%9C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EB%8F%84"></see>
    /// </summary>
    let ``_%EC%A0%9C%EB%8F%84`` =
        Namespaced_IRI.parse _namespace_name "%EC%A0%9C%EB%8F%84" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EC%88%98"></see>
    /// </summary>
    let ``_%EC%A0%9C%EC%88%98`` =
        Namespaced_IRI.parse _namespace_name "%EC%A0%9C%EC%88%98" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A1%B0%ED%98%95"></see>
    /// </summary>
    let ``_%EC%A1%B0%ED%98%95`` =
        Namespaced_IRI.parse _namespace_name "%EC%A1%B0%ED%98%95" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%80%EB%8F%84"></see>
    /// </summary>
    let ``_%EC%A7%80%EB%8F%84`` =
        Namespaced_IRI.parse _namespace_name "%EC%A7%80%EB%8F%84" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%81%EC%97%AD"></see>
    /// </summary>
    let ``_%EC%A7%81%EC%97%AD`` =
        Namespaced_IRI.parse _namespace_name "%EC%A7%81%EC%97%AD" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0"></see>
    /// </summary>
    let ``_%EC%B0%B8%EA%B3%A0`` =
        Namespaced_IRI.parse _namespace_name "%EC%B0%B8%EA%B3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8"></see>
    /// </summary>
    let ``_%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8`` =
        Namespaced_IRI.parse _namespace_name "%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%83%91%EB%B3%B8"></see>
    /// </summary>
    let ``_%ED%83%91%EB%B3%B8`` =
        Namespaced_IRI.parse _namespace_name "%ED%83%91%EB%B3%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%95%B4%EC%84%A4"></see>
    /// </summary>
    let ``_%ED%95%B4%EC%84%A4`` =
        Namespaced_IRI.parse _namespace_name "%ED%95%B4%EC%84%A4" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%82%AC"></see>
    /// </summary>
    let ``_%ED%96%89%EC%82%AC`` =
        Namespaced_IRI.parse _namespace_name "%ED%96%89%EC%82%AC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85"></see>
    /// </summary>
    let ``_%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85`` =
        Namespaced_IRI.parse _namespace_name "%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        Namespaced_IRI.parse _namespace_name "%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%ED%8C%90"></see>
    /// </summary>
    let ``_%ED%98%84%ED%8C%90`` =
        Namespaced_IRI.parse _namespace_name "%ED%98%84%ED%8C%90" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%B8%EC%B9%AD"></see>
    /// </summary>
    let ``_%ED%98%B8%EC%B9%AD`` =
        Namespaced_IRI.parse _namespace_name "%ED%98%B8%EC%B9%AD" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%99%94%ED%8F%90"></see>
    /// </summary>
    let ``_%ED%99%94%ED%8F%90`` =
        Namespaced_IRI.parse _namespace_name "%ED%99%94%ED%8F%90" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EB%AA%A8%EB%8D%B8"></see>
    /// </summary>
    let ``_3D_%EB%AA%A8%EB%8D%B8`` =
        Namespaced_IRI.parse _namespace_name "3D_%EB%AA%A8%EB%8D%B8" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Multimedia"></see>
    /// </summary>
    let Multimedia = Namespaced_IRI.parse _namespace_name "Multimedia" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EC%A7%80%EB%8F%84"></see>
    /// </summary>
    let ``_3D_%EC%A7%80%EB%8F%84`` =
        Namespaced_IRI.parse _namespace_name "3D_%EC%A7%80%EB%8F%84" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A1"></see>
    /// </summary>
    let A1 = Namespaced_IRI.parse _namespace_name "A1" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A2"></see>
    /// </summary>
    let A2 = Namespaced_IRI.parse _namespace_name "A2" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A3"></see>
    /// </summary>
    let A3 = Namespaced_IRI.parse _namespace_name "A3" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A4"></see>
    /// </summary>
    let A4 = Namespaced_IRI.parse _namespace_name "A4" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#AR"></see>
    /// </summary>
    let AR = Namespaced_IRI.parse _namespace_name "AR" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#CL"></see>
    /// </summary>
    let CL = Namespaced_IRI.parse _namespace_name "CL" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#CO"></see>
    /// </summary>
    let CO = Namespaced_IRI.parse _namespace_name "CO" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E1"></see>
    /// </summary>
    let E1 = Namespaced_IRI.parse _namespace_name "E1" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E2"></see>
    /// </summary>
    let E2 = Namespaced_IRI.parse _namespace_name "E2" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E3"></see>
    /// </summary>
    let E3 = Namespaced_IRI.parse _namespace_name "E3" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E4"></see>
    /// </summary>
    let E4 = Namespaced_IRI.parse _namespace_name "E4" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#FO"></see>
    /// </summary>
    let FO = Namespaced_IRI.parse _namespace_name "FO" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#HR"></see>
    /// </summary>
    let HR = Namespaced_IRI.parse _namespace_name "HR" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#NM"></see>
    /// </summary>
    let NM = Namespaced_IRI.parse _namespace_name "NM" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#OB"></see>
    /// </summary>
    let OB = Namespaced_IRI.parse _namespace_name "OB" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#P1"></see>
    /// </summary>
    let P1 = Namespaced_IRI.parse _namespace_name "P1" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#P2"></see>
    /// </summary>
    let P2 = Namespaced_IRI.parse _namespace_name "P2" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#RE"></see>
    /// </summary>
    let RE = Namespaced_IRI.parse _namespace_name "RE" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#ST"></see>
    /// </summary>
    let ST = Namespaced_IRI.parse _namespace_name "ST" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#TM"></see>
    /// </summary>
    let TM = Namespaced_IRI.parse _namespace_name "TM" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#XR"></see>
    /// </summary>
    let XR = Namespaced_IRI.parse _namespace_name "XR" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#administrates"></see>
    /// </summary>
    let administrates =
        Namespaced_IRI.parse _namespace_name "administrates" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAdministratedBy"></see>
    /// </summary>
    let isAdministratedBy =
        Namespaced_IRI.parse _namespace_name "isAdministratedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#annotator"></see>
    /// </summary>
    let annotator = Namespaced_IRI.parse _namespace_name "annotator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAnnotatorOf"></see>
    /// </summary>
    let isAnnotatorOf =
        Namespaced_IRI.parse _namespace_name "isAnnotatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#appearsIn"></see>
    /// </summary>
    let appearsIn = Namespaced_IRI.parse _namespace_name "appearsIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#archiveHolding"></see>
    /// </summary>
    let archiveHolding =
        Namespaced_IRI.parse _namespace_name "archiveHolding" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#bibliography"></see>
    /// </summary>
    let bibliography =
        Namespaced_IRI.parse _namespace_name "bibliography" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#calligrapher"></see>
    /// </summary>
    let calligrapher =
        Namespaced_IRI.parse _namespace_name "calligrapher" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCalligrapherOf"></see>
    /// </summary>
    let isCalligrapherOf =
        Namespaced_IRI.parse _namespace_name "isCalligrapherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#commemorates"></see>
    /// </summary>
    let commemorates =
        Namespaced_IRI.parse _namespace_name "commemorates" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#constructor"></see>
    /// </summary>
    let constructor =
        Namespaced_IRI.parse _namespace_name "constructor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isConstructorOf"></see>
    /// </summary>
    let isConstructorOf =
        Namespaced_IRI.parse _namespace_name "isConstructorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#cooks"></see>
    /// </summary>
    let cooks = Namespaced_IRI.parse _namespace_name "cooks" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#creatorPresumed"></see>
    /// </summary>
    let creatorPresumed =
        Namespaced_IRI.parse _namespace_name "creatorPresumed" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#curates"></see>
    /// </summary>
    let curates = Namespaced_IRI.parse _namespace_name "curates" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#depicts"></see>
    /// </summary>
    let depicts = Namespaced_IRI.parse _namespace_name "depicts" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDepictedIn"></see>
    /// </summary>
    let isDepictedIn =
        Namespaced_IRI.parse _namespace_name "isDepictedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#documents"></see>
    /// </summary>
    let documents = Namespaced_IRI.parse _namespace_name "documents" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDocumentedIn"></see>
    /// </summary>
    let isDocumentedIn =
        Namespaced_IRI.parse _namespace_name "isDocumentedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#doner"></see>
    /// </summary>
    let doner = Namespaced_IRI.parse _namespace_name "doner" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#editor"></see>
    /// </summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#enshrines"></see>
    /// </summary>
    let enshrines = Namespaced_IRI.parse _namespace_name "enshrines" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isEnshrinedIn"></see>
    /// </summary>
    let isEnshrinedIn =
        Namespaced_IRI.parse _namespace_name "isEnshrinedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#founder"></see>
    /// </summary>
    let founder = Namespaced_IRI.parse _namespace_name "founder" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFounderOf"></see>
    /// </summary>
    let isFounderOf =
        Namespaced_IRI.parse _namespace_name "isFounderOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#goesWith"></see>
    /// </summary>
    let goesWith = Namespaced_IRI.parse _namespace_name "goesWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAdoptedHeir"></see>
    /// </summary>
    let hasAdoptedHeir =
        Namespaced_IRI.parse _namespace_name "hasAdoptedHeir" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAdoptedHeirOf"></see>
    /// </summary>
    let isAdoptedHeirOf =
        Namespaced_IRI.parse _namespace_name "isAdoptedHeirOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAffiliation"></see>
    /// </summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAppointee"></see>
    /// </summary>
    let hasAppointee =
        Namespaced_IRI.parse _namespace_name "hasAppointee" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAsset"></see>
    /// </summary>
    let hasAsset = Namespaced_IRI.parse _namespace_name "hasAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasBranchTemple"></see>
    /// </summary>
    let hasBranchTemple =
        Namespaced_IRI.parse _namespace_name "hasBranchTemple" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasBrother"></see>
    /// </summary>
    let hasBrother = Namespaced_IRI.parse _namespace_name "hasBrother" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isBrotherOf"></see>
    /// </summary>
    let isBrotherOf =
        Namespaced_IRI.parse _namespace_name "isBrotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasBrotherInLaw"></see>
    /// </summary>
    let hasBrotherInLaw =
        Namespaced_IRI.parse _namespace_name "hasBrotherInLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasChineseExplanation"></see>
    /// </summary>
    let hasChineseExplanation =
        Namespaced_IRI.parse _namespace_name "hasChineseExplanation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasConcubine"></see>
    /// </summary>
    let hasConcubine =
        Namespaced_IRI.parse _namespace_name "hasConcubine" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHusbandOf"></see>
    /// </summary>
    let isHusbandOf =
        Namespaced_IRI.parse _namespace_name "isHusbandOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isConcubineOf"></see>
    /// </summary>
    let isConcubineOf =
        Namespaced_IRI.parse _namespace_name "isConcubineOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasContextualElement"></see>
    /// </summary>
    let hasContextualElement =
        Namespaced_IRI.parse _namespace_name "hasContextualElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasCousin"></see>
    /// </summary>
    let hasCousin = Namespaced_IRI.parse _namespace_name "hasCousin" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughter"></see>
    /// </summary>
    let hasDaughter =
        Namespaced_IRI.parse _namespace_name "hasDaughter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterOf"></see>
    /// </summary>
    let isDaughterOf =
        Namespaced_IRI.parse _namespace_name "isDaughterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughterInLaw"></see>
    /// </summary>
    let hasDaughterInLaw =
        Namespaced_IRI.parse _namespace_name "hasDaughterInLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterInLawOf"></see>
    /// </summary>
    let isDaughterInLawOf =
        Namespaced_IRI.parse _namespace_name "isDaughterInLawOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDescendant"></see>
    /// </summary>
    let hasDescendant =
        Namespaced_IRI.parse _namespace_name "hasDescendant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDescendantOf"></see>
    /// </summary>
    let isDescendantOf =
        Namespaced_IRI.parse _namespace_name "isDescendantOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDisciple"></see>
    /// </summary>
    let hasDisciple =
        Namespaced_IRI.parse _namespace_name "hasDisciple" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMasterOf"></see>
    /// </summary>
    let isMasterOf = Namespaced_IRI.parse _namespace_name "isMasterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDiscipleOf"></see>
    /// </summary>
    let isDiscipleOf =
        Namespaced_IRI.parse _namespace_name "isDiscipleOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDrawing"></see>
    /// </summary>
    let hasDrawing = Namespaced_IRI.parse _namespace_name "hasDrawing" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasEnglishExplanation"></see>
    /// </summary>
    let hasEnglishExplanation =
        Namespaced_IRI.parse _namespace_name "hasEnglishExplanation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasEpitaph"></see>
    /// </summary>
    let hasEpitaph = Namespaced_IRI.parse _namespace_name "hasEpitaph" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibition"></see>
    /// </summary>
    let hasExhibition =
        Namespaced_IRI.parse _namespace_name "hasExhibition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibitionAt"></see>
    /// </summary>
    let hasExhibitionAt =
        Namespaced_IRI.parse _namespace_name "hasExhibitionAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasFather"></see>
    /// </summary>
    let hasFather = Namespaced_IRI.parse _namespace_name "hasFather" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFatherOf"></see>
    /// </summary>
    let isFatherOf = Namespaced_IRI.parse _namespace_name "isFatherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasFatherInLaw"></see>
    /// </summary>
    let hasFatherInLaw =
        Namespaced_IRI.parse _namespace_name "hasFatherInLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFatherInLawOf"></see>
    /// </summary>
    let isFatherInLawOf =
        Namespaced_IRI.parse _namespace_name "isFatherInLawOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandDaughter"></see>
    /// </summary>
    let hasGrandDaughter =
        Namespaced_IRI.parse _namespace_name "hasGrandDaughter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isGrandDaughterOf"></see>
    /// </summary>
    let isGrandDaughterOf =
        Namespaced_IRI.parse _namespace_name "isGrandDaughterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandson"></see>
    /// </summary>
    let hasGrandson =
        Namespaced_IRI.parse _namespace_name "hasGrandson" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isGrandsonOf"></see>
    /// </summary>
    let isGrandsonOf =
        Namespaced_IRI.parse _namespace_name "isGrandsonOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasHermitage"></see>
    /// </summary>
    let hasHermitage =
        Namespaced_IRI.parse _namespace_name "hasHermitage" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasHistoricalSetting"></see>
    /// </summary>
    let hasHistoricalSetting =
        Namespaced_IRI.parse _namespace_name "hasHistoricalSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasHusband"></see>
    /// </summary>
    let hasHusband = Namespaced_IRI.parse _namespace_name "hasHusband" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasIngredient"></see>
    /// </summary>
    let hasIngredient =
        Namespaced_IRI.parse _namespace_name "hasIngredient" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasInscription"></see>
    /// </summary>
    let hasInscription =
        Namespaced_IRI.parse _namespace_name "hasInscription" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasMaster"></see>
    /// </summary>
    let hasMaster = Namespaced_IRI.parse _namespace_name "hasMaster" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasMother"></see>
    /// </summary>
    let hasMother = Namespaced_IRI.parse _namespace_name "hasMother" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMotherOf"></see>
    /// </summary>
    let isMotherOf = Namespaced_IRI.parse _namespace_name "isMotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasMotherInLaw"></see>
    /// </summary>
    let hasMotherInLaw =
        Namespaced_IRI.parse _namespace_name "hasMotherInLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMotherInLawOf"></see>
    /// </summary>
    let isMotherInLawOf =
        Namespaced_IRI.parse _namespace_name "isMotherInLawOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasNewName"></see>
    /// </summary>
    let hasNewName = Namespaced_IRI.parse _namespace_name "hasNewName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasOldName"></see>
    /// </summary>
    let hasOldName = Namespaced_IRI.parse _namespace_name "hasOldName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNewNameOf"></see>
    /// </summary>
    let isNewNameOf =
        Namespaced_IRI.parse _namespace_name "isNewNameOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOldNameOf"></see>
    /// </summary>
    let isOldNameOf =
        Namespaced_IRI.parse _namespace_name "isOldNameOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasOwner"></see>
    /// </summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOwnerOf"></see>
    /// </summary>
    let isOwnerOf = Namespaced_IRI.parse _namespace_name "isOwnerOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasParticipant"></see>
    /// </summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#participatesIn"></see>
    /// </summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasPerformance"></see>
    /// </summary>
    let hasPerformance =
        Namespaced_IRI.parse _namespace_name "hasPerformance" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedIn"></see>
    /// </summary>
    let isPerformedIn =
        Namespaced_IRI.parse _namespace_name "isPerformedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasPhoto"></see>
    /// </summary>
    let hasPhoto = Namespaced_IRI.parse _namespace_name "hasPhoto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasReferenceNote"></see>
    /// </summary>
    let hasReferenceNote =
        Namespaced_IRI.parse _namespace_name "hasReferenceNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSister"></see>
    /// </summary>
    let hasSister = Namespaced_IRI.parse _namespace_name "hasSister" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSisterOf"></see>
    /// </summary>
    let isSisterOf = Namespaced_IRI.parse _namespace_name "isSisterOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSisterInLaw"></see>
    /// </summary>
    let hasSisterInLaw =
        Namespaced_IRI.parse _namespace_name "hasSisterInLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSon"></see>
    /// </summary>
    let hasSon = Namespaced_IRI.parse _namespace_name "hasSon" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSonOf"></see>
    /// </summary>
    let isSonOf = Namespaced_IRI.parse _namespace_name "isSonOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSonInLaw"></see>
    /// </summary>
    let hasSonInLaw =
        Namespaced_IRI.parse _namespace_name "hasSonInLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSonInLawOf"></see>
    /// </summary>
    let isSonInLawOf =
        Namespaced_IRI.parse _namespace_name "isSonInLawOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasStele"></see>
    /// </summary>
    let hasStele = Namespaced_IRI.parse _namespace_name "hasStele" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSteleOf"></see>
    /// </summary>
    let isSteleOf = Namespaced_IRI.parse _namespace_name "isSteleOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasStupa"></see>
    /// </summary>
    let hasStupa = Namespaced_IRI.parse _namespace_name "hasStupa" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isStupaOf"></see>
    /// </summary>
    let isStupaOf = Namespaced_IRI.parse _namespace_name "isStupaOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSubject"></see>
    /// </summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSubjectOf"></see>
    /// </summary>
    let isSubjectOf =
        Namespaced_IRI.parse _namespace_name "isSubjectOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasTemporalElement"></see>
    /// </summary>
    let hasTemporalElement =
        Namespaced_IRI.parse _namespace_name "hasTemporalElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasText"></see>
    /// </summary>
    let hasText = Namespaced_IRI.parse _namespace_name "hasText" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasVersion"></see>
    /// </summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasVirtualParticipant"></see>
    /// </summary>
    let hasVirtualParticipant =
        Namespaced_IRI.parse _namespace_name "hasVirtualParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#virtuallyParticipatesIn"></see>
    /// </summary>
    let virtuallyParticipatesIn =
        Namespaced_IRI.parse _namespace_name "virtuallyParticipatesIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasWife"></see>
    /// </summary>
    let hasWife = Namespaced_IRI.parse _namespace_name "hasWife" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWifeOf"></see>
    /// </summary>
    let isWifeOf = Namespaced_IRI.parse _namespace_name "isWifeOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#includes"></see>
    /// </summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#inscriber"></see>
    /// </summary>
    let inscriber = Namespaced_IRI.parse _namespace_name "inscriber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isInscriberOf"></see>
    /// </summary>
    let isInscriberOf =
        Namespaced_IRI.parse _namespace_name "isInscriberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAffinalKinOf"></see>
    /// </summary>
    let isAffinalKinOf =
        Namespaced_IRI.parse _namespace_name "isAffinalKinOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAvailableAt"></see>
    /// </summary>
    let isAvailableAt =
        Namespaced_IRI.parse _namespace_name "isAvailableAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAwarded"></see>
    /// </summary>
    let isAwarded = Namespaced_IRI.parse _namespace_name "isAwarded" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isBirthPlaceOf"></see>
    /// </summary>
    let isBirthPlaceOf =
        Namespaced_IRI.parse _namespace_name "isBirthPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCausedBy"></see>
    /// </summary>
    let isCausedBy = Namespaced_IRI.parse _namespace_name "isCausedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isConceptionPlaceOf"></see>
    /// </summary>
    let isConceptionPlaceOf =
        Namespaced_IRI.parse _namespace_name "isConceptionPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isContributorOf"></see>
    /// </summary>
    let isContributorOf =
        Namespaced_IRI.parse _namespace_name "isContributorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCreatorOf"></see>
    /// </summary>
    let isCreatorOf =
        Namespaced_IRI.parse _namespace_name "isCreatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentLocationOf"></see>
    /// </summary>
    let isCurrentLocationOf =
        Namespaced_IRI.parse _namespace_name "isCurrentLocationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentlySituatedOn"></see>
    /// </summary>
    let isCurrentlySituatedOn =
        Namespaced_IRI.parse _namespace_name "isCurrentlySituatedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDeathPlaceOf"></see>
    /// </summary>
    let isDeathPlaceOf =
        Namespaced_IRI.parse _namespace_name "isDeathPlaceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDesignatedAs"></see>
    /// </summary>
    let isDesignatedAs =
        Namespaced_IRI.parse _namespace_name "isDesignatedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFellowOf"></see>
    /// </summary>
    let isFellowOf = Namespaced_IRI.parse _namespace_name "isFellowOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFormerlocationOf"></see>
    /// </summary>
    let isFormerlocationOf =
        Namespaced_IRI.parse _namespace_name "isFormerlocationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isGarnishedWith"></see>
    /// </summary>
    let isGarnishedWith =
        Namespaced_IRI.parse _namespace_name "isGarnishedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHeldAt"></see>
    /// </summary>
    let isHeldAt = Namespaced_IRI.parse _namespace_name "isHeldAt" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHeldBy"></see>
    /// </summary>
    let isHeldBy = Namespaced_IRI.parse _namespace_name "isHeldBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHeldFor"></see>
    /// </summary>
    let isHeldFor = Namespaced_IRI.parse _namespace_name "isHeldFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isInfluencedBy"></see>
    /// </summary>
    let isInfluencedBy =
        Namespaced_IRI.parse _namespace_name "isInfluencedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isKindOf"></see>
    /// </summary>
    let isKindOf = Namespaced_IRI.parse _namespace_name "isKindOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isLineageKinOf"></see>
    /// </summary>
    let isLineageKinOf =
        Namespaced_IRI.parse _namespace_name "isLineageKinOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isLocatedIn"></see>
    /// </summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMadeOf"></see>
    /// </summary>
    let isMadeOf = Namespaced_IRI.parse _namespace_name "isMadeOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMemberOf"></see>
    /// </summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedBy"></see>
    /// </summary>
    let isMentionedBy =
        Namespaced_IRI.parse _namespace_name "isMentionedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedIn"></see>
    /// </summary>
    let isMentionedIn =
        Namespaced_IRI.parse _namespace_name "isMentionedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#mentions"></see>
    /// </summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNamedAfter"></see>
    /// </summary>
    let isNamedAfter =
        Namespaced_IRI.parse _namespace_name "isNamedAfter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNamedBy"></see>
    /// </summary>
    let isNamedBy = Namespaced_IRI.parse _namespace_name "isNamedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNamesakeOf"></see>
    /// </summary>
    let isNamesakeOf =
        Namespaced_IRI.parse _namespace_name "isNamesakeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNear"></see>
    /// </summary>
    let isNear = Namespaced_IRI.parse _namespace_name "isNear" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOfficialPostOf"></see>
    /// </summary>
    let isOfficialPostOf =
        Namespaced_IRI.parse _namespace_name "isOfficialPostOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOperatedIn"></see>
    /// </summary>
    let isOperatedIn =
        Namespaced_IRI.parse _namespace_name "isOperatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPasserOf"></see>
    /// </summary>
    let isPasserOf = Namespaced_IRI.parse _namespace_name "isPasserOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedAt"></see>
    /// </summary>
    let isPerformedAt =
        Namespaced_IRI.parse _namespace_name "isPerformedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedBy"></see>
    /// </summary>
    let isPerformedBy =
        Namespaced_IRI.parse _namespace_name "isPerformedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPlacentaChamberOf"></see>
    /// </summary>
    let isPlacentaChamberOf =
        Namespaced_IRI.parse _namespace_name "isPlacentaChamberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPostedIn"></see>
    /// </summary>
    let isPostedIn = Namespaced_IRI.parse _namespace_name "isPostedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPreviousInSequenceTo"></see>
    /// </summary>
    let isPreviousInSequenceTo =
        Namespaced_IRI.parse _namespace_name "isPreviousInSequenceTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPreviouslySituatedOn"></see>
    /// </summary>
    let isPreviouslySituatedOn =
        Namespaced_IRI.parse _namespace_name "isPreviouslySituatedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProducedBy"></see>
    /// </summary>
    let isProducedBy =
        Namespaced_IRI.parse _namespace_name "isProducedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProducedIn"></see>
    /// </summary>
    let isProducedIn =
        Namespaced_IRI.parse _namespace_name "isProducedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProvenanceOf"></see>
    /// </summary>
    let isProvenanceOf =
        Namespaced_IRI.parse _namespace_name "isProvenanceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProvidedIn"></see>
    /// </summary>
    let isProvidedIn =
        Namespaced_IRI.parse _namespace_name "isProvidedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPublisherOf"></see>
    /// </summary>
    let isPublisherOf =
        Namespaced_IRI.parse _namespace_name "isPublisherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isReconstructorOf"></see>
    /// </summary>
    let isReconstructorOf =
        Namespaced_IRI.parse _namespace_name "isReconstructorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#reconstructor"></see>
    /// </summary>
    let reconstructor =
        Namespaced_IRI.parse _namespace_name "reconstructor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isReferencedFrom"></see>
    /// </summary>
    let isReferencedFrom =
        Namespaced_IRI.parse _namespace_name "isReferencedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isRenovatorOf"></see>
    /// </summary>
    let isRenovatorOf =
        Namespaced_IRI.parse _namespace_name "isRenovatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#renovator"></see>
    /// </summary>
    let renovator = Namespaced_IRI.parse _namespace_name "renovator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isRightsHolderOf"></see>
    /// </summary>
    let isRightsHolderOf =
        Namespaced_IRI.parse _namespace_name "isRightsHolderOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isServedIn"></see>
    /// </summary>
    let isServedIn = Namespaced_IRI.parse _namespace_name "isServedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isServedOn"></see>
    /// </summary>
    let isServedOn = Namespaced_IRI.parse _namespace_name "isServedOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isServedTo"></see>
    /// </summary>
    let isServedTo = Namespaced_IRI.parse _namespace_name "isServedTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSiteOf"></see>
    /// </summary>
    let isSiteOf = Namespaced_IRI.parse _namespace_name "isSiteOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isStoredIn"></see>
    /// </summary>
    let isStoredIn = Namespaced_IRI.parse _namespace_name "isStoredIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isTombOf"></see>
    /// </summary>
    let isTombOf = Namespaced_IRI.parse _namespace_name "isTombOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isTombstoneOf"></see>
    /// </summary>
    let isTombstoneOf =
        Namespaced_IRI.parse _namespace_name "isTombstoneOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isTranslatorOf"></see>
    /// </summary>
    let isTranslatorOf =
        Namespaced_IRI.parse _namespace_name "isTranslatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#translator"></see>
    /// </summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isUsedIn"></see>
    /// </summary>
    let isUsedIn = Namespaced_IRI.parse _namespace_name "isUsedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isVictimOf"></see>
    /// </summary>
    let isVictimOf = Namespaced_IRI.parse _namespace_name "isVictimOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWornBy"></see>
    /// </summary>
    let isWornBy = Namespaced_IRI.parse _namespace_name "isWornBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wears"></see>
    /// </summary>
    let wears = Namespaced_IRI.parse _namespace_name "wears" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWornIn"></see>
    /// </summary>
    let isWornIn = Namespaced_IRI.parse _namespace_name "isWornIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWriterOf"></see>
    /// </summary>
    let isWriterOf = Namespaced_IRI.parse _namespace_name "isWriterOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#writer"></see>
    /// </summary>
    let writer = Namespaced_IRI.parse _namespace_name "writer" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#leads"></see>
    /// </summary>
    let leads = Namespaced_IRI.parse _namespace_name "leads" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#livesIn"></see>
    /// </summary>
    let livesIn = Namespaced_IRI.parse _namespace_name "livesIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#mightBeRelatedTo"></see>
    /// </summary>
    let mightBeRelatedTo =
        Namespaced_IRI.parse _namespace_name "mightBeRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#onlineReference"></see>
    /// </summary>
    let onlineReference =
        Namespaced_IRI.parse _namespace_name "onlineReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#plays"></see>
    /// </summary>
    let plays = Namespaced_IRI.parse _namespace_name "plays" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#prepares"></see>
    /// </summary>
    let prepares = Namespaced_IRI.parse _namespace_name "prepares" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#serves"></see>
    /// </summary>
    let serves = Namespaced_IRI.parse _namespace_name "serves" |> NamespacedName
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#servesAs"></see>
    /// </summary>
    let servesAs = Namespaced_IRI.parse _namespace_name "servesAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#servesTemporarilyAs"></see>
    /// </summary>
    let servesTemporarilyAs =
        Namespaced_IRI.parse _namespace_name "servesTemporarilyAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#textReference"></see>
    /// </summary>
    let textReference =
        Namespaced_IRI.parse _namespace_name "textReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#timeline"></see>
    /// </summary>
    let timeline = Namespaced_IRI.parse _namespace_name "timeline" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasBuriedIn"></see>
    /// </summary>
    let wasBuriedIn =
        Namespaced_IRI.parse _namespace_name "wasBuriedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasExecutedAt"></see>
    /// </summary>
    let wasExecutedAt =
        Namespaced_IRI.parse _namespace_name "wasExecutedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasOrdainedBy"></see>
    /// </summary>
    let wasOrdainedBy =
        Namespaced_IRI.parse _namespace_name "wasOrdainedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasPreceptorOf"></see>
    /// </summary>
    let wasPreceptorOf =
        Namespaced_IRI.parse _namespace_name "wasPreceptorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasPosthumouslyPromotedTo"></see>
    /// </summary>
    let wasPosthumouslyPromotedTo =
        Namespaced_IRI.parse _namespace_name "wasPosthumouslyPromotedTo" |> NamespacedName
