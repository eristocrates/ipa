namespace http.dh.aks.ac.kr.ontologies.ekc.hash

open DoxAletheia

module ekc =
    let _namespace_name = "http://dh.aks.ac.kr/ontologies/ekc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4"></see>
    /// </summary>
    let ``_%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4`` =
        _prefix "%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Concept"></see>
    /// </summary>
    let Concept = _prefix "Concept"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95"></see>
    /// </summary>
    let ``_%EA%B1%B4%EC%B6%95`` = _prefix "%EA%B1%B4%EC%B6%95"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Architecture"></see>
    /// </summary>
    let Architecture = _prefix "Architecture"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88"></see>
    /// </summary>
    let ``_%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88`` =
        _prefix "%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%EA%B3%A0%EB%AC%B8%ED%97%8C`` = _prefix "%EA%B3%A0%EB%AC%B8%ED%97%8C"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Bibliography"></see>
    /// </summary>
    let Bibliography = _prefix "Bibliography"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EC%A7%80%EB%AA%85"></see>
    /// </summary>
    let ``_%EA%B3%A0%EC%A7%80%EB%AA%85`` = _prefix "%EA%B3%A0%EC%A7%80%EB%AA%85"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%84%9C"></see>
    /// </summary>
    let ``_%EA%B4%80%EC%84%9C`` = _prefix "%EA%B4%80%EC%84%9C"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Actor"></see>
    /// </summary>
    let Actor = _prefix "Actor"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%A7%81"></see>
    /// </summary>
    let ``_%EA%B4%80%EC%A7%81`` = _prefix "%EA%B4%80%EC%A7%81"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EA%B0%80"></see>
    /// </summary>
    let ``_%EA%B5%AD%EA%B0%80`` = _prefix "%EA%B5%AD%EA%B0%80"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EB%B3%B4"></see>
    /// </summary>
    let ``_%EA%B5%AD%EB%B3%B4`` = _prefix "%EA%B5%AD%EB%B3%B4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Heritage"></see>
    /// </summary>
    let Heritage = _prefix "Heritage"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%B8%EB%A6%BC"></see>
    /// </summary>
    let ``_%EA%B7%B8%EB%A6%BC`` = _prefix "%EA%B7%B8%EB%A6%BC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#WebResource"></see>
    /// </summary>
    let WebResource = _prefix "WebResource"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        _prefix "%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Record"></see>
    /// </summary>
    let Record = _prefix "Record"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80"></see>
    /// </summary>
    let ``_%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        _prefix "%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%88%EC%84%9D%EB%AC%B8"></see>
    /// </summary>
    let ``_%EA%B8%88%EC%84%9D%EB%AC%B8`` = _prefix "%EA%B8%88%EC%84%9D%EB%AC%B8"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EA%B4%80"></see>
    /// </summary>
    let ``_%EA%B8%B0%EA%B4%80`` = _prefix "%EA%B8%B0%EA%B4%80"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EB%85%90%EB%AC%BC"></see>
    /// </summary>
    let ``_%EA%B8%B0%EB%85%90%EB%AC%BC`` = _prefix "%EA%B8%B0%EB%85%90%EB%AC%BC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%82%AC"></see>
    /// </summary>
    let ``_%EA%B8%B0%EC%82%AC`` = _prefix "%EA%B8%B0%EC%82%AC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%9E%A5"></see>
    /// </summary>
    let ``_%EA%B8%B0%EC%9E%A5`` = _prefix "%EA%B8%B0%EC%9E%A5"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%85%BC%EB%AC%B8"></see>
    /// </summary>
    let ``_%EB%85%BC%EB%AC%B8`` = _prefix "%EB%85%BC%EB%AC%B8"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%EC%B2%B4"></see>
    /// </summary>
    let ``_%EB%8B%A8%EC%B2%B4`` = _prefix "%EB%8B%A8%EC%B2%B4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%ED%96%89%EB%B3%B8"></see>
    /// </summary>
    let ``_%EB%8B%A8%ED%96%89%EB%B3%B8`` = _prefix "%EB%8B%A8%ED%96%89%EB%B3%B8"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%84%EB%A9%B4"></see>
    /// </summary>
    let ``_%EB%8F%84%EB%A9%B4`` = _prefix "%EB%8F%84%EB%A9%B4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%99%EC%98%81%EC%83%81"></see>
    /// </summary>
    let ``_%EB%8F%99%EC%98%81%EC%83%81`` = _prefix "%EB%8F%99%EC%98%81%EC%83%81"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC"></see>
    /// </summary>
    let ``_%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        _prefix "%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87"></see>
    /// </summary>
    let ``_%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87`` =
        _prefix "%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Text"></see>
    /// </summary>
    let Text = _prefix "Text"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%EC%9A%A9"></see>
    /// </summary>
    let ``_%EB%AC%B4%EC%9A%A9`` = _prefix "%EB%AC%B4%EC%9A%A9"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Work"></see>
    /// </summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%ED%98%95"></see>
    /// </summary>
    let ``_%EB%AC%B4%ED%98%95`` = _prefix "%EB%AC%B4%ED%98%95"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%95%99"></see>
    /// </summary>
    let ``_%EB%AC%B8%ED%95%99`` = _prefix "%EB%AC%B8%ED%95%99"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%EB%AC%B8%ED%97%8C`` = _prefix "%EB%AC%B8%ED%97%8C"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%BC%ED%92%88"></see>
    /// </summary>
    let ``_%EB%AC%BC%ED%92%88`` = _prefix "%EB%AC%BC%ED%92%88"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AE%A4%EC%A7%80%EC%BB%AC"></see>
    /// </summary>
    let ``_%EB%AE%A4%EC%A7%80%EC%BB%AC`` = _prefix "%EB%AE%A4%EC%A7%80%EC%BB%AC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AF%B8%EC%88%A0"></see>
    /// </summary>
    let ``_%EB%AF%B8%EC%88%A0`` = _prefix "%EB%AF%B8%EC%88%A0"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B2%88%EC%97%AD%EB%AC%B8"></see>
    /// </summary>
    let ``_%EB%B2%88%EC%97%AD%EB%AC%B8`` = _prefix "%EB%B2%88%EC%97%AD%EB%AC%B8"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B4%EB%AC%BC"></see>
    /// </summary>
    let ``_%EB%B3%B4%EB%AC%BC`` = _prefix "%EB%B3%B4%EB%AC%BC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%8B%9D"></see>
    /// </summary>
    let ``_%EB%B3%B5%EC%8B%9D`` = _prefix "%EB%B3%B5%EC%8B%9D"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Clothing"></see>
    /// </summary>
    let Clothing = _prefix "Clothing"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%9E%A5"></see>
    /// </summary>
    let ``_%EB%B3%B5%EC%9E%A5`` = _prefix "%EB%B3%B5%EC%9E%A5"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C"></see>
    /// </summary>
    let ``_%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C`` =
        _prefix "%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EA%B1%B4"></see>
    /// </summary>
    let ``_%EC%82%AC%EA%B1%B4`` = _prefix "%EC%82%AC%EA%B1%B4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A0%81"></see>
    /// </summary>
    let ``_%EC%82%AC%EC%A0%81`` = _prefix "%EC%82%AC%EC%A0%81"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A7%84"></see>
    /// </summary>
    let ``_%EC%82%AC%EC%A7%84`` = _prefix "%EC%82%AC%EC%A7%84"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%83%81%EC%B0%A8%EB%A6%BC"></see>
    /// </summary>
    let ``_%EC%83%81%EC%B0%A8%EB%A6%BC`` = _prefix "%EC%83%81%EC%B0%A8%EB%A6%BC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Food"></see>
    /// </summary>
    let Food = _prefix "Food"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%86%8C%EC%9E%A5%EC%B2%98"></see>
    /// </summary>
    let ``_%EC%86%8C%EC%9E%A5%EC%B2%98`` = _prefix "%EC%86%8C%EC%9E%A5%EC%B2%98"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8"></see>
    /// </summary>
    let ``_%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8`` =
        _prefix "%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Story"></see>
    /// </summary>
    let Story = _prefix "Story"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C"></see>
    /// </summary>
    let ``_%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C`` =
        _prefix "%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C"></see>
    /// </summary>
    let ``_%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C`` =
        _prefix "%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC"></see>
    /// </summary>
    let ``_%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        _prefix "%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9D%EC%9E%AC%EB%A3%8C"></see>
    /// </summary>
    let ``_%EC%8B%9D%EC%9E%AC%EB%A3%8C`` = _prefix "%EC%8B%9D%EC%9E%AC%EB%A3%8C"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%B0%EA%B7%B9"></see>
    /// </summary>
    let ``_%EC%97%B0%EA%B7%B9`` = _prefix "%EC%97%B0%EA%B7%B9"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%98%81%ED%99%94"></see>
    /// </summary>
    let ``_%EC%98%81%ED%99%94`` = _prefix "%EC%98%81%ED%99%94"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%90%EB%AC%B8"></see>
    /// </summary>
    let ``_%EC%9B%90%EB%AC%B8`` = _prefix "%EC%9B%90%EB%AC%B8"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8"></see>
    /// </summary>
    let ``_%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8`` =
        _prefix "%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Index"></see>
    /// </summary>
    let Index = _prefix "Index"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9C%A0%EC%A0%81%EC%A7%80"></see>
    /// </summary>
    let ``_%EC%9C%A0%EC%A0%81%EC%A7%80`` = _prefix "%EC%9C%A0%EC%A0%81%EC%A7%80"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%8B%9D"></see>
    /// </summary>
    let ``_%EC%9D%8C%EC%8B%9D`` = _prefix "%EC%9D%8C%EC%8B%9D"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%95%85"></see>
    /// </summary>
    let ``_%EC%9D%8C%EC%95%85`` = _prefix "%EC%9D%8C%EC%95%85"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%98%EB%A1%80"></see>
    /// </summary>
    let ``_%EC%9D%98%EB%A1%80`` = _prefix "%EC%9D%98%EB%A1%80"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC"></see>
    /// </summary>
    let ``_%EC%9D%B8%EB%AC%BC`` = _prefix "%EC%9D%B8%EB%AC%BC"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC%EA%B5%B0"></see>
    /// </summary>
    let ``_%EC%9D%B8%EB%AC%BC%EA%B5%B0`` = _prefix "%EC%9D%B8%EB%AC%BC%EA%B5%B0"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85"></see>
    /// </summary>
    let ``_%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85`` =
        _prefix "%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%A5%EC%86%8C"></see>
    /// </summary>
    let ``_%EC%9E%A5%EC%86%8C`` = _prefix "%EC%9E%A5%EC%86%8C"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%84%EC%8B%9C"></see>
    /// </summary>
    let ``_%EC%A0%84%EC%8B%9C`` = _prefix "%EC%A0%84%EC%8B%9C"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EB%8F%84"></see>
    /// </summary>
    let ``_%EC%A0%9C%EB%8F%84`` = _prefix "%EC%A0%9C%EB%8F%84"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EC%88%98"></see>
    /// </summary>
    let ``_%EC%A0%9C%EC%88%98`` = _prefix "%EC%A0%9C%EC%88%98"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A1%B0%ED%98%95"></see>
    /// </summary>
    let ``_%EC%A1%B0%ED%98%95`` = _prefix "%EC%A1%B0%ED%98%95"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%80%EB%8F%84"></see>
    /// </summary>
    let ``_%EC%A7%80%EB%8F%84`` = _prefix "%EC%A7%80%EB%8F%84"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%81%EC%97%AD"></see>
    /// </summary>
    let ``_%EC%A7%81%EC%97%AD`` = _prefix "%EC%A7%81%EC%97%AD"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0"></see>
    /// </summary>
    let ``_%EC%B0%B8%EA%B3%A0`` = _prefix "%EC%B0%B8%EA%B3%A0"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8"></see>
    /// </summary>
    let ``_%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8`` =
        _prefix "%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%83%91%EB%B3%B8"></see>
    /// </summary>
    let ``_%ED%83%91%EB%B3%B8`` = _prefix "%ED%83%91%EB%B3%B8"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%95%B4%EC%84%A4"></see>
    /// </summary>
    let ``_%ED%95%B4%EC%84%A4`` = _prefix "%ED%95%B4%EC%84%A4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%82%AC"></see>
    /// </summary>
    let ``_%ED%96%89%EC%82%AC`` = _prefix "%ED%96%89%EC%82%AC"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85"></see>
    /// </summary>
    let ``_%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85`` =
        _prefix "%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C"></see>
    /// </summary>
    let ``_%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        _prefix "%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C"

    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%ED%8C%90"></see>
    /// </summary>
    let ``_%ED%98%84%ED%8C%90`` = _prefix "%ED%98%84%ED%8C%90"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%B8%EC%B9%AD"></see>
    /// </summary>
    let ``_%ED%98%B8%EC%B9%AD`` = _prefix "%ED%98%B8%EC%B9%AD"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#%ED%99%94%ED%8F%90"></see>
    /// </summary>
    let ``_%ED%99%94%ED%8F%90`` = _prefix "%ED%99%94%ED%8F%90"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EB%AA%A8%EB%8D%B8"></see>
    /// </summary>
    let ``_3D_%EB%AA%A8%EB%8D%B8`` = _prefix "3D_%EB%AA%A8%EB%8D%B8"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#Multimedia"></see>
    /// </summary>
    let Multimedia = _prefix "Multimedia"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EC%A7%80%EB%8F%84"></see>
    /// </summary>
    let ``_3D_%EC%A7%80%EB%8F%84`` = _prefix "3D_%EC%A7%80%EB%8F%84"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A1"></see>
    /// </summary>
    let A1 = _prefix "A1"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A2"></see>
    /// </summary>
    let A2 = _prefix "A2"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A3"></see>
    /// </summary>
    let A3 = _prefix "A3"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#A4"></see>
    /// </summary>
    let A4 = _prefix "A4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#AR"></see>
    /// </summary>
    let AR = _prefix "AR"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#CL"></see>
    /// </summary>
    let CL = _prefix "CL"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#CO"></see>
    /// </summary>
    let CO = _prefix "CO"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E1"></see>
    /// </summary>
    let E1 = _prefix "E1"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E2"></see>
    /// </summary>
    let E2 = _prefix "E2"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E3"></see>
    /// </summary>
    let E3 = _prefix "E3"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#E4"></see>
    /// </summary>
    let E4 = _prefix "E4"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#FO"></see>
    /// </summary>
    let FO = _prefix "FO"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#HR"></see>
    /// </summary>
    let HR = _prefix "HR"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#NM"></see>
    /// </summary>
    let NM = _prefix "NM"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#OB"></see>
    /// </summary>
    let OB = _prefix "OB"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#P1"></see>
    /// </summary>
    let P1 = _prefix "P1"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#P2"></see>
    /// </summary>
    let P2 = _prefix "P2"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#RE"></see>
    /// </summary>
    let RE = _prefix "RE"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#ST"></see>
    /// </summary>
    let ST = _prefix "ST"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#TM"></see>
    /// </summary>
    let TM = _prefix "TM"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#XR"></see>
    /// </summary>
    let XR = _prefix "XR"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#administrates"></see>
    /// </summary>
    let administrates = _prefix "administrates"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAdministratedBy"></see>
    /// </summary>
    let isAdministratedBy = _prefix "isAdministratedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#annotator"></see>
    /// </summary>
    let annotator = _prefix "annotator"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAnnotatorOf"></see>
    /// </summary>
    let isAnnotatorOf = _prefix "isAnnotatorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#appearsIn"></see>
    /// </summary>
    let appearsIn = _prefix "appearsIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#archiveHolding"></see>
    /// </summary>
    let archiveHolding = _prefix "archiveHolding"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#bibliography"></see>
    /// </summary>
    let bibliography = _prefix "bibliography"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#calligrapher"></see>
    /// </summary>
    let calligrapher = _prefix "calligrapher"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCalligrapherOf"></see>
    /// </summary>
    let isCalligrapherOf = _prefix "isCalligrapherOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#commemorates"></see>
    /// </summary>
    let commemorates = _prefix "commemorates"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#constructor"></see>
    /// </summary>
    let constructor = _prefix "constructor"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isConstructorOf"></see>
    /// </summary>
    let isConstructorOf = _prefix "isConstructorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#cooks"></see>
    /// </summary>
    let cooks = _prefix "cooks"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#creatorPresumed"></see>
    /// </summary>
    let creatorPresumed = _prefix "creatorPresumed"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#curates"></see>
    /// </summary>
    let curates = _prefix "curates"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#depicts"></see>
    /// </summary>
    let depicts = _prefix "depicts"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDepictedIn"></see>
    /// </summary>
    let isDepictedIn = _prefix "isDepictedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#documents"></see>
    /// </summary>
    let documents = _prefix "documents"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDocumentedIn"></see>
    /// </summary>
    let isDocumentedIn = _prefix "isDocumentedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#doner"></see>
    /// </summary>
    let doner = _prefix "doner"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#editor"></see>
    /// </summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#enshrines"></see>
    /// </summary>
    let enshrines = _prefix "enshrines"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isEnshrinedIn"></see>
    /// </summary>
    let isEnshrinedIn = _prefix "isEnshrinedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#founder"></see>
    /// </summary>
    let founder = _prefix "founder"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFounderOf"></see>
    /// </summary>
    let isFounderOf = _prefix "isFounderOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#goesWith"></see>
    /// </summary>
    let goesWith = _prefix "goesWith"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAdoptedHeir"></see>
    /// </summary>
    let hasAdoptedHeir = _prefix "hasAdoptedHeir"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAdoptedHeirOf"></see>
    /// </summary>
    let isAdoptedHeirOf = _prefix "isAdoptedHeirOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAffiliation"></see>
    /// </summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAppointee"></see>
    /// </summary>
    let hasAppointee = _prefix "hasAppointee"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasAsset"></see>
    /// </summary>
    let hasAsset = _prefix "hasAsset"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasBranchTemple"></see>
    /// </summary>
    let hasBranchTemple = _prefix "hasBranchTemple"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasBrother"></see>
    /// </summary>
    let hasBrother = _prefix "hasBrother"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isBrotherOf"></see>
    /// </summary>
    let isBrotherOf = _prefix "isBrotherOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasBrotherInLaw"></see>
    /// </summary>
    let hasBrotherInLaw = _prefix "hasBrotherInLaw"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasChineseExplanation"></see>
    /// </summary>
    let hasChineseExplanation = _prefix "hasChineseExplanation"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasConcubine"></see>
    /// </summary>
    let hasConcubine = _prefix "hasConcubine"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHusbandOf"></see>
    /// </summary>
    let isHusbandOf = _prefix "isHusbandOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isConcubineOf"></see>
    /// </summary>
    let isConcubineOf = _prefix "isConcubineOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasContextualElement"></see>
    /// </summary>
    let hasContextualElement = _prefix "hasContextualElement"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasCousin"></see>
    /// </summary>
    let hasCousin = _prefix "hasCousin"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughter"></see>
    /// </summary>
    let hasDaughter = _prefix "hasDaughter"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterOf"></see>
    /// </summary>
    let isDaughterOf = _prefix "isDaughterOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughterInLaw"></see>
    /// </summary>
    let hasDaughterInLaw = _prefix "hasDaughterInLaw"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterInLawOf"></see>
    /// </summary>
    let isDaughterInLawOf = _prefix "isDaughterInLawOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDescendant"></see>
    /// </summary>
    let hasDescendant = _prefix "hasDescendant"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDescendantOf"></see>
    /// </summary>
    let isDescendantOf = _prefix "isDescendantOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDisciple"></see>
    /// </summary>
    let hasDisciple = _prefix "hasDisciple"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMasterOf"></see>
    /// </summary>
    let isMasterOf = _prefix "isMasterOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDiscipleOf"></see>
    /// </summary>
    let isDiscipleOf = _prefix "isDiscipleOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasDrawing"></see>
    /// </summary>
    let hasDrawing = _prefix "hasDrawing"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasEnglishExplanation"></see>
    /// </summary>
    let hasEnglishExplanation = _prefix "hasEnglishExplanation"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasEpitaph"></see>
    /// </summary>
    let hasEpitaph = _prefix "hasEpitaph"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibition"></see>
    /// </summary>
    let hasExhibition = _prefix "hasExhibition"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibitionAt"></see>
    /// </summary>
    let hasExhibitionAt = _prefix "hasExhibitionAt"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasFather"></see>
    /// </summary>
    let hasFather = _prefix "hasFather"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFatherOf"></see>
    /// </summary>
    let isFatherOf = _prefix "isFatherOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasFatherInLaw"></see>
    /// </summary>
    let hasFatherInLaw = _prefix "hasFatherInLaw"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFatherInLawOf"></see>
    /// </summary>
    let isFatherInLawOf = _prefix "isFatherInLawOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandDaughter"></see>
    /// </summary>
    let hasGrandDaughter = _prefix "hasGrandDaughter"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isGrandDaughterOf"></see>
    /// </summary>
    let isGrandDaughterOf = _prefix "isGrandDaughterOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandson"></see>
    /// </summary>
    let hasGrandson = _prefix "hasGrandson"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isGrandsonOf"></see>
    /// </summary>
    let isGrandsonOf = _prefix "isGrandsonOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasHermitage"></see>
    /// </summary>
    let hasHermitage = _prefix "hasHermitage"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasHistoricalSetting"></see>
    /// </summary>
    let hasHistoricalSetting = _prefix "hasHistoricalSetting"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasHusband"></see>
    /// </summary>
    let hasHusband = _prefix "hasHusband"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasIngredient"></see>
    /// </summary>
    let hasIngredient = _prefix "hasIngredient"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasInscription"></see>
    /// </summary>
    let hasInscription = _prefix "hasInscription"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasMaster"></see>
    /// </summary>
    let hasMaster = _prefix "hasMaster"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasMother"></see>
    /// </summary>
    let hasMother = _prefix "hasMother"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMotherOf"></see>
    /// </summary>
    let isMotherOf = _prefix "isMotherOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasMotherInLaw"></see>
    /// </summary>
    let hasMotherInLaw = _prefix "hasMotherInLaw"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMotherInLawOf"></see>
    /// </summary>
    let isMotherInLawOf = _prefix "isMotherInLawOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasNewName"></see>
    /// </summary>
    let hasNewName = _prefix "hasNewName"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasOldName"></see>
    /// </summary>
    let hasOldName = _prefix "hasOldName"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNewNameOf"></see>
    /// </summary>
    let isNewNameOf = _prefix "isNewNameOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOldNameOf"></see>
    /// </summary>
    let isOldNameOf = _prefix "isOldNameOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasOwner"></see>
    /// </summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOwnerOf"></see>
    /// </summary>
    let isOwnerOf = _prefix "isOwnerOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasParticipant"></see>
    /// </summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#participatesIn"></see>
    /// </summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasPerformance"></see>
    /// </summary>
    let hasPerformance = _prefix "hasPerformance"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedIn"></see>
    /// </summary>
    let isPerformedIn = _prefix "isPerformedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasPhoto"></see>
    /// </summary>
    let hasPhoto = _prefix "hasPhoto"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasReferenceNote"></see>
    /// </summary>
    let hasReferenceNote = _prefix "hasReferenceNote"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSister"></see>
    /// </summary>
    let hasSister = _prefix "hasSister"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSisterOf"></see>
    /// </summary>
    let isSisterOf = _prefix "isSisterOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSisterInLaw"></see>
    /// </summary>
    let hasSisterInLaw = _prefix "hasSisterInLaw"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSon"></see>
    /// </summary>
    let hasSon = _prefix "hasSon"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSonOf"></see>
    /// </summary>
    let isSonOf = _prefix "isSonOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSonInLaw"></see>
    /// </summary>
    let hasSonInLaw = _prefix "hasSonInLaw"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSonInLawOf"></see>
    /// </summary>
    let isSonInLawOf = _prefix "isSonInLawOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasStele"></see>
    /// </summary>
    let hasStele = _prefix "hasStele"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSteleOf"></see>
    /// </summary>
    let isSteleOf = _prefix "isSteleOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasStupa"></see>
    /// </summary>
    let hasStupa = _prefix "hasStupa"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isStupaOf"></see>
    /// </summary>
    let isStupaOf = _prefix "isStupaOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasSubject"></see>
    /// </summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSubjectOf"></see>
    /// </summary>
    let isSubjectOf = _prefix "isSubjectOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasTemporalElement"></see>
    /// </summary>
    let hasTemporalElement = _prefix "hasTemporalElement"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasText"></see>
    /// </summary>
    let hasText = _prefix "hasText"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasVersion"></see>
    /// </summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasVirtualParticipant"></see>
    /// </summary>
    let hasVirtualParticipant = _prefix "hasVirtualParticipant"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#virtuallyParticipatesIn"></see>
    /// </summary>
    let virtuallyParticipatesIn = _prefix "virtuallyParticipatesIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#hasWife"></see>
    /// </summary>
    let hasWife = _prefix "hasWife"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWifeOf"></see>
    /// </summary>
    let isWifeOf = _prefix "isWifeOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#includes"></see>
    /// </summary>
    let includes = _prefix "includes"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#inscriber"></see>
    /// </summary>
    let inscriber = _prefix "inscriber"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isInscriberOf"></see>
    /// </summary>
    let isInscriberOf = _prefix "isInscriberOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAffinalKinOf"></see>
    /// </summary>
    let isAffinalKinOf = _prefix "isAffinalKinOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAvailableAt"></see>
    /// </summary>
    let isAvailableAt = _prefix "isAvailableAt"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isAwarded"></see>
    /// </summary>
    let isAwarded = _prefix "isAwarded"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isBirthPlaceOf"></see>
    /// </summary>
    let isBirthPlaceOf = _prefix "isBirthPlaceOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCausedBy"></see>
    /// </summary>
    let isCausedBy = _prefix "isCausedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isConceptionPlaceOf"></see>
    /// </summary>
    let isConceptionPlaceOf = _prefix "isConceptionPlaceOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isContributorOf"></see>
    /// </summary>
    let isContributorOf = _prefix "isContributorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCreatorOf"></see>
    /// </summary>
    let isCreatorOf = _prefix "isCreatorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentLocationOf"></see>
    /// </summary>
    let isCurrentLocationOf = _prefix "isCurrentLocationOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentlySituatedOn"></see>
    /// </summary>
    let isCurrentlySituatedOn = _prefix "isCurrentlySituatedOn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDeathPlaceOf"></see>
    /// </summary>
    let isDeathPlaceOf = _prefix "isDeathPlaceOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isDesignatedAs"></see>
    /// </summary>
    let isDesignatedAs = _prefix "isDesignatedAs"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFellowOf"></see>
    /// </summary>
    let isFellowOf = _prefix "isFellowOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isFormerlocationOf"></see>
    /// </summary>
    let isFormerlocationOf = _prefix "isFormerlocationOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isGarnishedWith"></see>
    /// </summary>
    let isGarnishedWith = _prefix "isGarnishedWith"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHeldAt"></see>
    /// </summary>
    let isHeldAt = _prefix "isHeldAt"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHeldBy"></see>
    /// </summary>
    let isHeldBy = _prefix "isHeldBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isHeldFor"></see>
    /// </summary>
    let isHeldFor = _prefix "isHeldFor"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isInfluencedBy"></see>
    /// </summary>
    let isInfluencedBy = _prefix "isInfluencedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isKindOf"></see>
    /// </summary>
    let isKindOf = _prefix "isKindOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isLineageKinOf"></see>
    /// </summary>
    let isLineageKinOf = _prefix "isLineageKinOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isLocatedIn"></see>
    /// </summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMadeOf"></see>
    /// </summary>
    let isMadeOf = _prefix "isMadeOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMemberOf"></see>
    /// </summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedBy"></see>
    /// </summary>
    let isMentionedBy = _prefix "isMentionedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedIn"></see>
    /// </summary>
    let isMentionedIn = _prefix "isMentionedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#mentions"></see>
    /// </summary>
    let mentions = _prefix "mentions"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNamedAfter"></see>
    /// </summary>
    let isNamedAfter = _prefix "isNamedAfter"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNamedBy"></see>
    /// </summary>
    let isNamedBy = _prefix "isNamedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNamesakeOf"></see>
    /// </summary>
    let isNamesakeOf = _prefix "isNamesakeOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isNear"></see>
    /// </summary>
    let isNear = _prefix "isNear"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOfficialPostOf"></see>
    /// </summary>
    let isOfficialPostOf = _prefix "isOfficialPostOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isOperatedIn"></see>
    /// </summary>
    let isOperatedIn = _prefix "isOperatedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPasserOf"></see>
    /// </summary>
    let isPasserOf = _prefix "isPasserOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedAt"></see>
    /// </summary>
    let isPerformedAt = _prefix "isPerformedAt"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedBy"></see>
    /// </summary>
    let isPerformedBy = _prefix "isPerformedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPlacentaChamberOf"></see>
    /// </summary>
    let isPlacentaChamberOf = _prefix "isPlacentaChamberOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPostedIn"></see>
    /// </summary>
    let isPostedIn = _prefix "isPostedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPreviousInSequenceTo"></see>
    /// </summary>
    let isPreviousInSequenceTo = _prefix "isPreviousInSequenceTo"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPreviouslySituatedOn"></see>
    /// </summary>
    let isPreviouslySituatedOn = _prefix "isPreviouslySituatedOn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProducedBy"></see>
    /// </summary>
    let isProducedBy = _prefix "isProducedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProducedIn"></see>
    /// </summary>
    let isProducedIn = _prefix "isProducedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProvenanceOf"></see>
    /// </summary>
    let isProvenanceOf = _prefix "isProvenanceOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isProvidedIn"></see>
    /// </summary>
    let isProvidedIn = _prefix "isProvidedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isPublisherOf"></see>
    /// </summary>
    let isPublisherOf = _prefix "isPublisherOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isReconstructorOf"></see>
    /// </summary>
    let isReconstructorOf = _prefix "isReconstructorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#reconstructor"></see>
    /// </summary>
    let reconstructor = _prefix "reconstructor"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isReferencedFrom"></see>
    /// </summary>
    let isReferencedFrom = _prefix "isReferencedFrom"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isRenovatorOf"></see>
    /// </summary>
    let isRenovatorOf = _prefix "isRenovatorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#renovator"></see>
    /// </summary>
    let renovator = _prefix "renovator"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isRightsHolderOf"></see>
    /// </summary>
    let isRightsHolderOf = _prefix "isRightsHolderOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isServedIn"></see>
    /// </summary>
    let isServedIn = _prefix "isServedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isServedOn"></see>
    /// </summary>
    let isServedOn = _prefix "isServedOn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isServedTo"></see>
    /// </summary>
    let isServedTo = _prefix "isServedTo"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isSiteOf"></see>
    /// </summary>
    let isSiteOf = _prefix "isSiteOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isStoredIn"></see>
    /// </summary>
    let isStoredIn = _prefix "isStoredIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isTombOf"></see>
    /// </summary>
    let isTombOf = _prefix "isTombOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isTombstoneOf"></see>
    /// </summary>
    let isTombstoneOf = _prefix "isTombstoneOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isTranslatorOf"></see>
    /// </summary>
    let isTranslatorOf = _prefix "isTranslatorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#translator"></see>
    /// </summary>
    let translator = _prefix "translator"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isUsedIn"></see>
    /// </summary>
    let isUsedIn = _prefix "isUsedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isVictimOf"></see>
    /// </summary>
    let isVictimOf = _prefix "isVictimOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWornBy"></see>
    /// </summary>
    let isWornBy = _prefix "isWornBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wears"></see>
    /// </summary>
    let wears = _prefix "wears"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWornIn"></see>
    /// </summary>
    let isWornIn = _prefix "isWornIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#isWriterOf"></see>
    /// </summary>
    let isWriterOf = _prefix "isWriterOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#writer"></see>
    /// </summary>
    let writer = _prefix "writer"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#leads"></see>
    /// </summary>
    let leads = _prefix "leads"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#livesIn"></see>
    /// </summary>
    let livesIn = _prefix "livesIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#mightBeRelatedTo"></see>
    /// </summary>
    let mightBeRelatedTo = _prefix "mightBeRelatedTo"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#onlineReference"></see>
    /// </summary>
    let onlineReference = _prefix "onlineReference"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#plays"></see>
    /// </summary>
    let plays = _prefix "plays"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#prepares"></see>
    /// </summary>
    let prepares = _prefix "prepares"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#serves"></see>
    /// </summary>
    let serves = _prefix "serves"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#servesAs"></see>
    /// </summary>
    let servesAs = _prefix "servesAs"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#servesTemporarilyAs"></see>
    /// </summary>
    let servesTemporarilyAs = _prefix "servesTemporarilyAs"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#textReference"></see>
    /// </summary>
    let textReference = _prefix "textReference"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#timeline"></see>
    /// </summary>
    let timeline = _prefix "timeline"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasBuriedIn"></see>
    /// </summary>
    let wasBuriedIn = _prefix "wasBuriedIn"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasExecutedAt"></see>
    /// </summary>
    let wasExecutedAt = _prefix "wasExecutedAt"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasOrdainedBy"></see>
    /// </summary>
    let wasOrdainedBy = _prefix "wasOrdainedBy"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasPreceptorOf"></see>
    /// </summary>
    let wasPreceptorOf = _prefix "wasPreceptorOf"
    /// <summary>
    ///   <see href="http://dh.aks.ac.kr/ontologies/ekc#wasPosthumouslyPromotedTo"></see>
    /// </summary>
    let wasPosthumouslyPromotedTo = _prefix "wasPosthumouslyPromotedTo"
