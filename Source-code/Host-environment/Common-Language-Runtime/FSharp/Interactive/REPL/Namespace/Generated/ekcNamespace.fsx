#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ekc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://dh.aks.ac.kr/ontologies/ekc#" "ekc"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : 개념용어</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4">ekc:%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4</a>
    /// </summary>
    let ``_%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4`` =
        _prefixId.prefix "%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4"

    /// <summary>
    ///   <para>rdfs:label : 건축</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95">ekc:%EA%B1%B4%EC%B6%95</a>
    /// </summary>
    let ``_%EA%B1%B4%EC%B6%95`` = _prefixId.prefix "%EA%B1%B4%EC%B6%95"

    /// <summary>
    ///   <para>rdfs:label : 건축부품</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88">ekc:%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88</a>
    /// </summary>
    let ``_%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88`` =
        _prefixId.prefix "%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88"

    /// <summary>
    ///   <para>rdfs:label : 고문헌</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EB%AC%B8%ED%97%8C">ekc:%EA%B3%A0%EB%AC%B8%ED%97%8C</a>
    /// </summary>
    let ``_%EA%B3%A0%EB%AC%B8%ED%97%8C`` =
        _prefixId.prefix "%EA%B3%A0%EB%AC%B8%ED%97%8C"

    /// <summary>
    ///   <para>rdfs:label : 고지명</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EC%A7%80%EB%AA%85">ekc:%EA%B3%A0%EC%A7%80%EB%AA%85</a>
    /// </summary>
    let ``_%EA%B3%A0%EC%A7%80%EB%AA%85`` =
        _prefixId.prefix "%EA%B3%A0%EC%A7%80%EB%AA%85"

    /// <summary>
    ///   <para>rdfs:label : 관서</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%84%9C">ekc:%EA%B4%80%EC%84%9C</a>
    /// </summary>
    let ``_%EA%B4%80%EC%84%9C`` = _prefixId.prefix "%EA%B4%80%EC%84%9C"
    /// <summary>
    ///   <para>rdfs:label : 관직</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%A7%81">ekc:%EA%B4%80%EC%A7%81</a>
    /// </summary>
    let ``_%EA%B4%80%EC%A7%81`` = _prefixId.prefix "%EA%B4%80%EC%A7%81"
    /// <summary>
    ///   <para>rdfs:label : 국가</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EA%B0%80">ekc:%EA%B5%AD%EA%B0%80</a>
    /// </summary>
    let ``_%EA%B5%AD%EA%B0%80`` = _prefixId.prefix "%EA%B5%AD%EA%B0%80"
    /// <summary>
    ///   <para>rdfs:label : 국보</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EB%B3%B4">ekc:%EA%B5%AD%EB%B3%B4</a>
    /// </summary>
    let ``_%EA%B5%AD%EB%B3%B4`` = _prefixId.prefix "%EA%B5%AD%EB%B3%B4"
    /// <summary>
    ///   <para>rdfs:label : 그림</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%B8%EB%A6%BC">ekc:%EA%B7%B8%EB%A6%BC</a>
    /// </summary>
    let ``_%EA%B7%B8%EB%A6%BC`` = _prefixId.prefix "%EA%B7%B8%EB%A6%BC"

    /// <summary>
    ///   <para>rdfs:label : 근대문헌</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C">ekc:%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C</a>
    /// </summary>
    let ``_%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        _prefixId.prefix "%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C"

    /// <summary>
    ///   <para>rdfs:label : 근대유적지</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80">ekc:%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80</a>
    /// </summary>
    let ``_%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        _prefixId.prefix "%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80"

    /// <summary>
    ///   <para>rdfs:label : 금석문</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%88%EC%84%9D%EB%AC%B8">ekc:%EA%B8%88%EC%84%9D%EB%AC%B8</a>
    /// </summary>
    let ``_%EA%B8%88%EC%84%9D%EB%AC%B8`` =
        _prefixId.prefix "%EA%B8%88%EC%84%9D%EB%AC%B8"

    /// <summary>
    ///   <para>rdfs:label : 기관</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EA%B4%80">ekc:%EA%B8%B0%EA%B4%80</a>
    /// </summary>
    let ``_%EA%B8%B0%EA%B4%80`` = _prefixId.prefix "%EA%B8%B0%EA%B4%80"

    /// <summary>
    ///   <para>rdfs:label : 기념물</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EB%85%90%EB%AC%BC">ekc:%EA%B8%B0%EB%85%90%EB%AC%BC</a>
    /// </summary>
    let ``_%EA%B8%B0%EB%85%90%EB%AC%BC`` =
        _prefixId.prefix "%EA%B8%B0%EB%85%90%EB%AC%BC"

    /// <summary>
    ///   <para>rdfs:label : 기사</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%82%AC">ekc:%EA%B8%B0%EC%82%AC</a>
    /// </summary>
    let ``_%EA%B8%B0%EC%82%AC`` = _prefixId.prefix "%EA%B8%B0%EC%82%AC"
    /// <summary>
    ///   <para>rdfs:label : 기장</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%9E%A5">ekc:%EA%B8%B0%EC%9E%A5</a>
    /// </summary>
    let ``_%EA%B8%B0%EC%9E%A5`` = _prefixId.prefix "%EA%B8%B0%EC%9E%A5"
    /// <summary>
    ///   <para>rdfs:label : 논문</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%85%BC%EB%AC%B8">ekc:%EB%85%BC%EB%AC%B8</a>
    /// </summary>
    let ``_%EB%85%BC%EB%AC%B8`` = _prefixId.prefix "%EB%85%BC%EB%AC%B8"
    /// <summary>
    ///   <para>rdfs:label : 단체</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%EC%B2%B4">ekc:%EB%8B%A8%EC%B2%B4</a>
    /// </summary>
    let ``_%EB%8B%A8%EC%B2%B4`` = _prefixId.prefix "%EB%8B%A8%EC%B2%B4"

    /// <summary>
    ///   <para>rdfs:label : 단행본</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%ED%96%89%EB%B3%B8">ekc:%EB%8B%A8%ED%96%89%EB%B3%B8</a>
    /// </summary>
    let ``_%EB%8B%A8%ED%96%89%EB%B3%B8`` =
        _prefixId.prefix "%EB%8B%A8%ED%96%89%EB%B3%B8"

    /// <summary>
    ///   <para>rdfs:label : 도면</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%84%EB%A9%B4">ekc:%EB%8F%84%EB%A9%B4</a>
    /// </summary>
    let ``_%EB%8F%84%EB%A9%B4`` = _prefixId.prefix "%EB%8F%84%EB%A9%B4"

    /// <summary>
    ///   <para>rdfs:label : 동영상</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%99%EC%98%81%EC%83%81">ekc:%EB%8F%99%EC%98%81%EC%83%81</a>
    /// </summary>
    let ``_%EB%8F%99%EC%98%81%EC%83%81`` =
        _prefixId.prefix "%EB%8F%99%EC%98%81%EC%83%81"

    /// <summary>
    ///   <para>rdfs:label : 등록문화유산</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC">ekc:%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC</a>
    /// </summary>
    let ``_%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        _prefixId.prefix "%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC"

    /// <summary>
    ///   <para>rdfs:label : 명문(銘文)^^xsd:string</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87">ekc:%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87</a>
    /// </summary>
    let ``_%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87`` =
        _prefixId.prefix "%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87"

    /// <summary>
    ///   <para>rdfs:label : 무용</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%EC%9A%A9">ekc:%EB%AC%B4%EC%9A%A9</a>
    /// </summary>
    let ``_%EB%AC%B4%EC%9A%A9`` = _prefixId.prefix "%EB%AC%B4%EC%9A%A9"
    /// <summary>
    ///   <para>rdfs:label : 무형</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%ED%98%95">ekc:%EB%AC%B4%ED%98%95</a>
    /// </summary>
    let ``_%EB%AC%B4%ED%98%95`` = _prefixId.prefix "%EB%AC%B4%ED%98%95"
    /// <summary>
    ///   <para>rdfs:label : 문학</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%95%99">ekc:%EB%AC%B8%ED%95%99</a>
    /// </summary>
    let ``_%EB%AC%B8%ED%95%99`` = _prefixId.prefix "%EB%AC%B8%ED%95%99"
    /// <summary>
    ///   <para>rdfs:label : 문헌</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%97%8C">ekc:%EB%AC%B8%ED%97%8C</a>
    /// </summary>
    let ``_%EB%AC%B8%ED%97%8C`` = _prefixId.prefix "%EB%AC%B8%ED%97%8C"
    /// <summary>
    ///   <para>rdfs:label : 물품</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%BC%ED%92%88">ekc:%EB%AC%BC%ED%92%88</a>
    /// </summary>
    let ``_%EB%AC%BC%ED%92%88`` = _prefixId.prefix "%EB%AC%BC%ED%92%88"

    /// <summary>
    ///   <para>rdfs:label : 뮤지컬</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AE%A4%EC%A7%80%EC%BB%AC">ekc:%EB%AE%A4%EC%A7%80%EC%BB%AC</a>
    /// </summary>
    let ``_%EB%AE%A4%EC%A7%80%EC%BB%AC`` =
        _prefixId.prefix "%EB%AE%A4%EC%A7%80%EC%BB%AC"

    /// <summary>
    ///   <para>rdfs:label : 미술</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AF%B8%EC%88%A0">ekc:%EB%AF%B8%EC%88%A0</a>
    /// </summary>
    let ``_%EB%AF%B8%EC%88%A0`` = _prefixId.prefix "%EB%AF%B8%EC%88%A0"

    /// <summary>
    ///   <para>rdfs:label : 번역문</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B2%88%EC%97%AD%EB%AC%B8">ekc:%EB%B2%88%EC%97%AD%EB%AC%B8</a>
    /// </summary>
    let ``_%EB%B2%88%EC%97%AD%EB%AC%B8`` =
        _prefixId.prefix "%EB%B2%88%EC%97%AD%EB%AC%B8"

    /// <summary>
    ///   <para>rdfs:label : 보물</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B4%EB%AC%BC">ekc:%EB%B3%B4%EB%AC%BC</a>
    /// </summary>
    let ``_%EB%B3%B4%EB%AC%BC`` = _prefixId.prefix "%EB%B3%B4%EB%AC%BC"
    /// <summary>
    ///   <para>rdfs:label : 복식</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%8B%9D">ekc:%EB%B3%B5%EC%8B%9D</a>
    /// </summary>
    let ``_%EB%B3%B5%EC%8B%9D`` = _prefixId.prefix "%EB%B3%B5%EC%8B%9D"
    /// <summary>
    ///   <para>rdfs:label : 복장</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%9E%A5">ekc:%EB%B3%B5%EC%9E%A5</a>
    /// </summary>
    let ``_%EB%B3%B5%EC%9E%A5`` = _prefixId.prefix "%EB%B3%B5%EC%9E%A5"

    /// <summary>
    ///   <para>rdfs:label : 분류주제</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C">ekc:%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C</a>
    /// </summary>
    let ``_%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C`` =
        _prefixId.prefix "%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C"

    /// <summary>
    ///   <para>rdfs:label : 사건</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EA%B1%B4">ekc:%EC%82%AC%EA%B1%B4</a>
    /// </summary>
    let ``_%EC%82%AC%EA%B1%B4`` = _prefixId.prefix "%EC%82%AC%EA%B1%B4"
    /// <summary>
    ///   <para>rdfs:label : 사적</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A0%81">ekc:%EC%82%AC%EC%A0%81</a>
    /// </summary>
    let ``_%EC%82%AC%EC%A0%81`` = _prefixId.prefix "%EC%82%AC%EC%A0%81"
    /// <summary>
    ///   <para>rdfs:label : 사진</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A7%84">ekc:%EC%82%AC%EC%A7%84</a>
    /// </summary>
    let ``_%EC%82%AC%EC%A7%84`` = _prefixId.prefix "%EC%82%AC%EC%A7%84"

    /// <summary>
    ///   <para>rdfs:label : 상차림</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%83%81%EC%B0%A8%EB%A6%BC">ekc:%EC%83%81%EC%B0%A8%EB%A6%BC</a>
    /// </summary>
    let ``_%EC%83%81%EC%B0%A8%EB%A6%BC`` =
        _prefixId.prefix "%EC%83%81%EC%B0%A8%EB%A6%BC"

    /// <summary>
    ///   <para>rdfs:label : 소장처</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%86%8C%EC%9E%A5%EC%B2%98">ekc:%EC%86%8C%EC%9E%A5%EC%B2%98</a>
    /// </summary>
    let ``_%EC%86%8C%EC%9E%A5%EC%B2%98`` =
        _prefixId.prefix "%EC%86%8C%EC%9E%A5%EC%B2%98"

    /// <summary>
    ///   <para>rdfs:label : 스토리라인</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8">ekc:%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8</a>
    /// </summary>
    let ``_%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8`` =
        _prefixId.prefix "%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8"

    /// <summary>
    ///   <para>rdfs:label : 시각자료</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C">ekc:%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C</a>
    /// </summary>
    let ``_%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C`` =
        _prefixId.prefix "%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C"

    /// <summary>
    ///   <para>rdfs:label : 시도문화유산</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC">ekc:%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC</a>
    /// </summary>
    let ``_%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        _prefixId.prefix "%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC"

    /// <summary>
    ///   <para>rdfs:label : 식재료</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9D%EC%9E%AC%EB%A3%8C">ekc:%EC%8B%9D%EC%9E%AC%EB%A3%8C</a>
    /// </summary>
    let ``_%EC%8B%9D%EC%9E%AC%EB%A3%8C`` =
        _prefixId.prefix "%EC%8B%9D%EC%9E%AC%EB%A3%8C"

    /// <summary>
    ///   <para>rdfs:label : 에피소드</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C">ekc:%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C</a>
    /// </summary>
    let ``_%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C`` =
        _prefixId.prefix "%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C"

    /// <summary>
    ///   <para>rdfs:label : 연극</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%B0%EA%B7%B9">ekc:%EC%97%B0%EA%B7%B9</a>
    /// </summary>
    let ``_%EC%97%B0%EA%B7%B9`` = _prefixId.prefix "%EC%97%B0%EA%B7%B9"
    /// <summary>
    ///   <para>rdfs:label : 영화</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%98%81%ED%99%94">ekc:%EC%98%81%ED%99%94</a>
    /// </summary>
    let ``_%EC%98%81%ED%99%94`` = _prefixId.prefix "%EC%98%81%ED%99%94"
    /// <summary>
    ///   <para>rdfs:label : 원문</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%90%EB%AC%B8">ekc:%EC%9B%90%EB%AC%B8</a>
    /// </summary>
    let ``_%EC%9B%90%EB%AC%B8`` = _prefixId.prefix "%EC%9B%90%EB%AC%B8"

    /// <summary>
    ///   <para>rdfs:label : 웹자원색인</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8">ekc:%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8</a>
    /// </summary>
    let ``_%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8`` =
        _prefixId.prefix "%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8"

    /// <summary>
    ///   <para>rdfs:label : 유적지</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9C%A0%EC%A0%81%EC%A7%80">ekc:%EC%9C%A0%EC%A0%81%EC%A7%80</a>
    /// </summary>
    let ``_%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        _prefixId.prefix "%EC%9C%A0%EC%A0%81%EC%A7%80"

    /// <summary>
    ///   <para>rdfs:label : 음식</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%8B%9D">ekc:%EC%9D%8C%EC%8B%9D</a>
    /// </summary>
    let ``_%EC%9D%8C%EC%8B%9D`` = _prefixId.prefix "%EC%9D%8C%EC%8B%9D"
    /// <summary>
    ///   <para>rdfs:label : 음악</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%95%85">ekc:%EC%9D%8C%EC%95%85</a>
    /// </summary>
    let ``_%EC%9D%8C%EC%95%85`` = _prefixId.prefix "%EC%9D%8C%EC%95%85"
    /// <summary>
    ///   <para>rdfs:label : 의례</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%98%EB%A1%80">ekc:%EC%9D%98%EB%A1%80</a>
    /// </summary>
    let ``_%EC%9D%98%EB%A1%80`` = _prefixId.prefix "%EC%9D%98%EB%A1%80"
    /// <summary>
    ///   <para>rdfs:label : 인물</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC">ekc:%EC%9D%B8%EB%AC%BC</a>
    /// </summary>
    let ``_%EC%9D%B8%EB%AC%BC`` = _prefixId.prefix "%EC%9D%B8%EB%AC%BC"

    /// <summary>
    ///   <para>rdfs:label : 인물군</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC%EA%B5%B0">ekc:%EC%9D%B8%EB%AC%BC%EA%B5%B0</a>
    /// </summary>
    let ``_%EC%9D%B8%EB%AC%BC%EA%B5%B0`` =
        _prefixId.prefix "%EC%9D%B8%EB%AC%BC%EA%B5%B0"

    /// <summary>
    ///   <para>rdfs:label : 자연지명</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85">ekc:%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85</a>
    /// </summary>
    let ``_%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85`` =
        _prefixId.prefix "%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85"

    /// <summary>
    ///   <para>rdfs:label : 장소</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%A5%EC%86%8C">ekc:%EC%9E%A5%EC%86%8C</a>
    /// </summary>
    let ``_%EC%9E%A5%EC%86%8C`` = _prefixId.prefix "%EC%9E%A5%EC%86%8C"
    /// <summary>
    ///   <para>rdfs:label : 전시</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%84%EC%8B%9C">ekc:%EC%A0%84%EC%8B%9C</a>
    /// </summary>
    let ``_%EC%A0%84%EC%8B%9C`` = _prefixId.prefix "%EC%A0%84%EC%8B%9C"
    /// <summary>
    ///   <para>rdfs:label : 제도</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EB%8F%84">ekc:%EC%A0%9C%EB%8F%84</a>
    /// </summary>
    let ``_%EC%A0%9C%EB%8F%84`` = _prefixId.prefix "%EC%A0%9C%EB%8F%84"
    /// <summary>
    ///   <para>rdfs:label : 제수</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EC%88%98">ekc:%EC%A0%9C%EC%88%98</a>
    /// </summary>
    let ``_%EC%A0%9C%EC%88%98`` = _prefixId.prefix "%EC%A0%9C%EC%88%98"
    /// <summary>
    ///   <para>rdfs:label : 조형</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A1%B0%ED%98%95">ekc:%EC%A1%B0%ED%98%95</a>
    /// </summary>
    let ``_%EC%A1%B0%ED%98%95`` = _prefixId.prefix "%EC%A1%B0%ED%98%95"
    /// <summary>
    ///   <para>rdfs:label : 지도</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%80%EB%8F%84">ekc:%EC%A7%80%EB%8F%84</a>
    /// </summary>
    let ``_%EC%A7%80%EB%8F%84`` = _prefixId.prefix "%EC%A7%80%EB%8F%84"
    /// <summary>
    ///   <para>rdfs:label : 직역</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%81%EC%97%AD">ekc:%EC%A7%81%EC%97%AD</a>
    /// </summary>
    let ``_%EC%A7%81%EC%97%AD`` = _prefixId.prefix "%EC%A7%81%EC%97%AD"
    /// <summary>
    ///   <para>rdfs:label : 참고</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0">ekc:%EC%B0%B8%EA%B3%A0</a>
    /// </summary>
    let ``_%EC%B0%B8%EA%B3%A0`` = _prefixId.prefix "%EC%B0%B8%EA%B3%A0"

    /// <summary>
    ///   <para>rdfs:label : 참고문헌색인</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8">ekc:%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8</a>
    /// </summary>
    let ``_%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8`` =
        _prefixId.prefix "%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8"

    /// <summary>
    ///   <para>rdfs:label : 탑본</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%83%91%EB%B3%B8">ekc:%ED%83%91%EB%B3%B8</a>
    /// </summary>
    let ``_%ED%83%91%EB%B3%B8`` = _prefixId.prefix "%ED%83%91%EB%B3%B8"
    /// <summary>
    ///   <para>rdfs:label : 해설</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%95%B4%EC%84%A4">ekc:%ED%95%B4%EC%84%A4</a>
    /// </summary>
    let ``_%ED%95%B4%EC%84%A4`` = _prefixId.prefix "%ED%95%B4%EC%84%A4"
    /// <summary>
    ///   <para>rdfs:label : 행사</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%82%AC">ekc:%ED%96%89%EC%82%AC</a>
    /// </summary>
    let ``_%ED%96%89%EC%82%AC`` = _prefixId.prefix "%ED%96%89%EC%82%AC"

    /// <summary>
    ///   <para>rdfs:label : 행정지명</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85">ekc:%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85</a>
    /// </summary>
    let ``_%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85`` =
        _prefixId.prefix "%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85"

    /// <summary>
    ///   <para>rdfs:label : 현대문헌</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C">ekc:%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C</a>
    /// </summary>
    let ``_%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        _prefixId.prefix "%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C"

    /// <summary>
    ///   <para>rdfs:label : 현판</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%ED%8C%90">ekc:%ED%98%84%ED%8C%90</a>
    /// </summary>
    let ``_%ED%98%84%ED%8C%90`` = _prefixId.prefix "%ED%98%84%ED%8C%90"
    /// <summary>
    ///   <para>rdfs:label : 호칭</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%B8%EC%B9%AD">ekc:%ED%98%B8%EC%B9%AD</a>
    /// </summary>
    let ``_%ED%98%B8%EC%B9%AD`` = _prefixId.prefix "%ED%98%B8%EC%B9%AD"
    /// <summary>
    ///   <para>rdfs:label : 화폐</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#%ED%99%94%ED%8F%90">ekc:%ED%99%94%ED%8F%90</a>
    /// </summary>
    let ``_%ED%99%94%ED%8F%90`` = _prefixId.prefix "%ED%99%94%ED%8F%90"
    /// <summary>
    ///   <para>rdfs:label : 3D_모델^^xsd:string</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EB%AA%A8%EB%8D%B8">ekc:3D_%EB%AA%A8%EB%8D%B8</a>
    /// </summary>
    let ``_3D_%EB%AA%A8%EB%8D%B8`` = _prefixId.prefix "3D_%EB%AA%A8%EB%8D%B8"
    /// <summary>
    ///   <para>rdfs:label : 3D_지도^^xsd:string</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EC%A7%80%EB%8F%84">ekc:3D_%EC%A7%80%EB%8F%84</a>
    /// </summary>
    let ``_3D_%EC%A7%80%EB%8F%84`` = _prefixId.prefix "3D_%EC%A7%80%EB%8F%84"
    /// <summary>
    ///   <para>skos:definition : 인적 관계</para>
    ///   <para>rdfs:label : A1</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#A1">ekc:A1</a>
    /// </summary>
    let A1 = _prefixId.prefix "A1"
    /// <summary>
    ///   <para>skos:definition : 문헌/작품/사건의 역할자</para>
    ///   <para>rdfs:label : A2</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#A2">ekc:A2</a>
    /// </summary>
    let A2 = _prefixId.prefix "A2"
    /// <summary>
    ///   <para>skos:definition : 인물과 기관/단체의 관계</para>
    ///   <para>rdfs:label : A3</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#A3">ekc:A3</a>
    /// </summary>
    let A3 = _prefixId.prefix "A3"
    /// <summary>
    ///   <para>skos:definition : 관직 관련 관계</para>
    ///   <para>rdfs:label : A4</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#A4">ekc:A4</a>
    /// </summary>
    let A4 = _prefixId.prefix "A4"
    /// <summary>
    ///   <para>skos:definition : 건조물 관련 관계</para>
    ///   <para>rdfs:label : AR</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#AR">ekc:AR</a>
    /// </summary>
    let AR = _prefixId.prefix "AR"
    /// <summary>
    ///   <para>dce:description : Historical figures; Organizations as collective actors and institutions as operating entitiesdce:description : 역사적인 인물. 집단적 행위 주체로서의 단체, 운영주체로서의 기관</para>
    ///   <para>rdfs:label : Actor</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Actor">ekc:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>dce:description : Historic Buildings in a certain area and historically related structuresdce:description : 특정 권역의 역사적인 건조물 및 주변의 유관한 건축/조형물</para>
    ///   <para>rdfs:label : Architecture</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Architecture">ekc:Architecture</a>
    /// </summary>
    let Architecture = _prefixId.prefix "Architecture"
    /// <summary>
    ///   <para>dce:description : List of academic research materialsdce:description : 학술적 연구 자료의 목록</para>
    ///   <para>rdfs:label : Bibliography</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Bibliography">ekc:Bibliography</a>
    /// </summary>
    let Bibliography = _prefixId.prefix "Bibliography"
    /// <summary>
    ///   <para>skos:definition : 복식 관련 관계</para>
    ///   <para>rdfs:label : CL</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#CL">ekc:CL</a>
    /// </summary>
    let CL = _prefixId.prefix "CL"
    /// <summary>
    ///   <para>skos:definition : 개념적/포괄적 관계</para>
    ///   <para>rdfs:label : CO</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#CO">ekc:CO</a>
    /// </summary>
    let CO = _prefixId.prefix "CO"
    /// <summary>
    ///   <para>dce:description : Costumes, components of costumes, or traditional ornamentsdce:description : 역사적·문화적 복장과 복식 요소들</para>
    ///   <para>rdfs:label : Clothing</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Clothing">ekc:Clothing</a>
    /// </summary>
    let Clothing = _prefixId.prefix "Clothing"
    /// <summary>
    ///   <para>dce:description : Terms and concepts necessary to explain institutions, rituals, customs, etc.dce:description : 제도, 의례, 풍속 등을 설명하는 데 필요한 용어와 개념</para>
    ///   <para>rdfs:label : Concept</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Concept">ekc:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>skos:definition : 이벤트 관련 관계: 사건</para>
    ///   <para>rdfs:label : E1</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#E1">ekc:E1</a>
    /// </summary>
    let E1 = _prefixId.prefix "E1"
    /// <summary>
    ///   <para>skos:definition : 이벤트 관련 관계: 행사</para>
    ///   <para>rdfs:label : E2</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#E2">ekc:E2</a>
    /// </summary>
    let E2 = _prefixId.prefix "E2"
    /// <summary>
    ///   <para>skos:definition : 이벤트 관련 관계: 공연</para>
    ///   <para>rdfs:label : E3</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#E3">ekc:E3</a>
    /// </summary>
    let E3 = _prefixId.prefix "E3"
    /// <summary>
    ///   <para>skos:definition : 이벤트 관련 관계: 전시</para>
    ///   <para>rdfs:label : E4</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#E4">ekc:E4</a>
    /// </summary>
    let E4 = _prefixId.prefix "E4"
    /// <summary>
    ///   <para>dce:description : Events held in a certain area, ceremonies and events that reproduce them todaydce:description : 특정 권역에서 일어난 사건, 의례 및 이를 재현하는 행사</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Event">ekc:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>skos:definition : 음식 관련 관계</para>
    ///   <para>rdfs:label : FO</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#FO">ekc:FO</a>
    /// </summary>
    let FO = _prefixId.prefix "FO"
    /// <summary>
    ///   <para>dce:description : Food, ingredients and table settingdce:description : 음식, 식재료와 상차림</para>
    ///   <para>rdfs:label : Food</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Food">ekc:Food</a>
    /// </summary>
    let Food = _prefixId.prefix "Food"
    /// <summary>
    ///   <para>skos:definition : 문화재 관련 관계</para>
    ///   <para>rdfs:label : HR</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#HR">ekc:HR</a>
    /// </summary>
    let HR = _prefixId.prefix "HR"
    /// <summary>
    ///   <para>dce:description : Registration information of designated and registered cultural propertiesdce:description : 지정문화유산 및 등록문화유산 등록 정보</para>
    ///   <para>rdfs:label : Heritage</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Heritage">ekc:Heritage</a>
    /// </summary>
    let Heritage = _prefixId.prefix "Heritage"
    /// <summary>
    ///   <para>dce:description : A list of nodes of similar character. Timeline, collection list, reference list, web resource list, etc.dce:description : 유사한 성격의 노드들을 모아서 묶은 목록. 연표, 소장도서목록, 참고문헌목록, 웹자원목록 등</para>
    ///   <para>rdfs:label : Index</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Index">ekc:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>dce:description : 3D model of a building; 3D map indicating the location of a specific place; visual materialsdce:description : 3D 모델, 특정 공간의 위치를 알리는 3차원 지도, 시각자료</para>
    ///   <para>rdfs:label : Multimedia</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Multimedia">ekc:Multimedia</a>
    /// </summary>
    let Multimedia = _prefixId.prefix "Multimedia"
    /// <summary>
    ///   <para>skos:definition : 이름 사이의 관계</para>
    ///   <para>rdfs:label : NM</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#NM">ekc:NM</a>
    /// </summary>
    let NM = _prefixId.prefix "NM"
    /// <summary>
    ///   <para>skos:definition : 물품 관련 관계</para>
    ///   <para>rdfs:label : OB</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#OB">ekc:OB</a>
    /// </summary>
    let OB = _prefixId.prefix "OB"
    /// <summary>
    ///   <para>dce:description : Items used in various ceremonies or events; Items or tools that show the culture of the timedce:description : 각종 의례/행사의 도구, 그 시대의 문화를 보이는 물품들</para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Object">ekc:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>skos:definition : 장소를 설명하는 관계</para>
    ///   <para>rdfs:label : P1</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#P1">ekc:P1</a>
    /// </summary>
    let P1 = _prefixId.prefix "P1"
    /// <summary>
    ///   <para>skos:definition : 장소가 목적어인 관계</para>
    ///   <para>rdfs:label : P2</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#P2">ekc:P2</a>
    /// </summary>
    let P2 = _prefixId.prefix "P2"
    /// <summary>
    ///   <para>dce:description : Places related to historical events or characters; Places where historical relics or artifacts are locateddce:description : 역사적 배경(사건, 인물)과 관련이 있는 장소. 유물의 소장처</para>
    ///   <para>rdfs:label : Place</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Place">ekc:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>skos:definition : 기록물/유물 관련 관계</para>
    ///   <para>rdfs:label : RE</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#RE">ekc:RE</a>
    /// </summary>
    let RE = _prefixId.prefix "RE"
    /// <summary>
    ///   <para>dce:description : Records that serve as the source of knowledge such as books, photographs, drawings, and inscriptionsdce:description : 문헌, 사진, 도면, 금석문 등 지식 데이터의 원천 자료가 되는 기록물</para>
    ///   <para>rdfs:label : Record</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Record">ekc:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    /// <summary>
    ///   <para>skos:definition : 스토리텔링 구성을 지시하는 관계</para>
    ///   <para>rdfs:label : ST</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#ST">ekc:ST</a>
    /// </summary>
    let ST = _prefixId.prefix "ST"
    /// <summary>
    ///   <para>dce:description : Description of historical knowledge that explains the background of discovering data nodesdce:description : 데이터 노드 발굴의 배경이 된 역사적 지식에 대한 서술</para>
    ///   <para>rdfs:label : Story</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Story">ekc:Story</a>
    /// </summary>
    let Story = _prefixId.prefix "Story"
    /// <summary>
    ///   <para>skos:definition : 연표의 구성을 지시하는 관계</para>
    ///   <para>rdfs:label : TM</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#TM">ekc:TM</a>
    /// </summary>
    let TM = _prefixId.prefix "TM"
    /// <summary>
    ///   <para>dce:description : Text in the literature that functions as evidence of explanationdce:description : 설명의 증거 기능을 하는 문헌상의 텍스트</para>
    ///   <para>rdfs:label : Text</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Text">ekc:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>dce:description : Reference materials that can be accessed on the World Wide Webdce:description : 월드 와이드 웹에서 접근할 수 있는 참고 자료</para>
    ///   <para>rdfs:label : WebResource</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#WebResource">ekc:WebResource</a>
    /// </summary>
    let WebResource = _prefixId.prefix "WebResource"
    /// <summary>
    ///   <para>dce:description : Works of art such as literature, fine arts, music, dance, performance, etc.dce:description : 문학, 미술, 음악, 연희, 무용 등의 문예 작품</para>
    ///   <para>rdfs:label : Work</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#Work">ekc:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>skos:definition : 참고자료를 지시하는 관계</para>
    ///   <para>rdfs:label : XR</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#XR">ekc:XR</a>
    /// </summary>
    let XR = _prefixId.prefix "XR"
    /// <summary>
    ///   <para>skos:note : 의례·제도에서의 주관행위</para>
    ///   <para>skos:example : 가례도감 - 가례</para>
    ///   <para>dce:description : ~를 주관하다</para>
    ///   <para>rdfs:label : administrates</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#administrates">ekc:administrates</a>
    /// </summary>
    let administrates = _prefixId.prefix "administrates"
    /// <summary>
    ///   <para>skos:note : 주석자</para>
    ///   <para>skos:example : 용비어천가 - 성삼문</para>
    ///   <para>dce:description : 주석가는 ~이다</para>
    ///   <para>rdfs:label : annotator</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#annotator">ekc:annotator</a>
    /// </summary>
    let annotator = _prefixId.prefix "annotator"
    /// <summary>
    ///   <para>dce:description : (작품, 공연) ~에 출연하다</para>
    ///   <para>rdfs:label : appearsIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#appearsIn">ekc:appearsIn</a>
    /// </summary>
    let appearsIn = _prefixId.prefix "appearsIn"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Index/WebResource^^xsd:string</para>
    ///   <para>dce:description : 아카이브 소장 목록(자료)는 ~이다 ※ 목적어는 아카이브의 소장품(소장도서) 카타로그</para>
    ///   <para>rdfs:label : archiveHolding</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#archiveHolding">ekc:archiveHolding</a>
    /// </summary>
    let archiveHolding = _prefixId.prefix "archiveHolding"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Index/Bibliography^^xsd:string</para>
    ///   <para>dce:description : 참고문헌 목록은 ~이다 ※ 목적어는 참고문헌 색인(bib-XXXX) 노드^^xsd:string</para>
    ///   <para>rdfs:label : bibliography</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#bibliography">ekc:bibliography</a>
    /// </summary>
    let bibliography = _prefixId.prefix "bibliography"
    /// <summary>
    ///   <para>skos:note : 글씨 쓴 사람. 비문/편액/제액 글씨 쓴 사람.</para>
    ///   <para>skos:example : 김원(신라) - 장흥 보림사 보조선사탑비</para>
    ///   <para>dce:description : (금석문의) 글씨 쓴 이는 ~이다</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#calligrapher">ekc:calligrapher</a>
    /// </summary>
    let calligrapher = _prefixId.prefix "calligrapher"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Object/Event/Record^^xsd:string</para>
    ///   <para>skos:note : A는 B를 기념하여 만들어졌다^^xsd:string</para>
    ///   <para>dce:description : ~를 기념하다</para>
    ///   <para>rdfs:label : commemorates</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#commemorates">ekc:commemorates</a>
    /// </summary>
    let commemorates = _prefixId.prefix "commemorates"
    /// <summary>
    ///   <para>skos:note : 건축을 지휘</para>
    ///   <para>skos:example : 소양강댐 - 현대건설</para>
    ///   <para>dce:description : 건축가는 ~이다</para>
    ///   <para>rdfs:label : constructor</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#constructor">ekc:constructor</a>
    /// </summary>
    let constructor = _prefixId.prefix "constructor"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : 음식 ~을 조리한다</para>
    ///   <para>rdfs:label : cooks</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#cooks">ekc:cooks</a>
    /// </summary>
    let cooks = _prefixId.prefix "cooks"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Record/Object^^xsd:string</para>
    ///   <para>skos:note : A의 작가는 B라고 알려져 있다^^xsd:string</para>
    ///   <para>dce:description : (문헌/작품의) 작가는 ~라고 알려져 있다</para>
    ///   <para>rdfs:label : creatorPresumed</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#creatorPresumed">ekc:creatorPresumed</a>
    /// </summary>
    let creatorPresumed = _prefixId.prefix "creatorPresumed"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Object/Record/Event^^xsd:string</para>
    ///   <para>dce:description : ~를 전시(큐레이션)하다</para>
    ///   <para>rdfs:label : curates</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#curates">ekc:curates</a>
    /// </summary>
    let curates = _prefixId.prefix "curates"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Object/Record^^xsd:string</para>
    ///   <para>skos:note : A가 묘사하는 주된 대상이 B이다^^xsd:string</para>
    ///   <para>skos:example : 고산구곡도설 - 고산구곡도</para>
    ///   <para>dce:description : ~를 묘사하다</para>
    ///   <para>rdfs:label : depicts</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#depicts">ekc:depicts</a>
    /// </summary>
    let depicts = _prefixId.prefix "depicts"
    /// <summary>
    ///   <para>skos:note : A:기록물(예:의궤), B: 기록되는 대상(예:의례)^^xsd:string</para>
    ///   <para>skos:example : 영조정순왕후가례도감의궤 - 영조-정순왕후_가례</para>
    ///   <para>dce:description : ~를 문서화하다</para>
    ///   <para>rdfs:label : documents</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#documents">ekc:documents</a>
    /// </summary>
    let documents = _prefixId.prefix "documents"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Record/Object^^xsd:string</para>
    ///   <para>dce:description : (유물의) 기증자는 ~이다</para>
    ///   <para>rdfs:label : doner</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#doner">ekc:doner</a>
    /// </summary>
    let doner = _prefixId.prefix "doner"
    /// <summary>
    ///   <para>dce:description : 편집자는 ~이다</para>
    ///   <para>rdfs:label : editor</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#editor">ekc:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>dce:description : ~를 제향하다</para>
    ///   <para>rdfs:label : enshrines</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#enshrines">ekc:enshrines</a>
    /// </summary>
    let enshrines = _prefixId.prefix "enshrines"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>skos:note : 기관/단체/장소 설립자. 권위로써 무엇을 만들도록 함.</para>
    ///   <para>skos:example : 현대미술가협회 - 하인두</para>
    ///   <para>dce:description : 설립자는 ~이다</para>
    ///   <para>rdfs:label : founder</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#founder">ekc:founder</a>
    /// </summary>
    let founder = _prefixId.prefix "founder"
    /// <summary>
    ///   <para>skos:note : 의식에서 물품 간의 수반 관계
    /// A는 B와 함께 착용하였다/사용되었다
    /// A는 B에 올려졌다
    /// A는 B를 담는다/감싼다
    /// A는 B로 운반되었다^^xsd:string</para>
    ///   <para>skos:example : 외궤 - 내함</para>
    ///   <para>dce:description : ~를 수반하다</para>
    ///   <para>rdfs:label : goesWith</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#goesWith">ekc:goesWith</a>
    /// </summary>
    let goesWith = _prefixId.prefix "goesWith"
    /// <summary>
    ///   <para>skos:note : 양자(가계상속 목적)</para>
    ///   <para>skos:example : 윤이석 - 윤두서</para>
    ///   <para>dce:description : 양자 ~를 두었다</para>
    ///   <para>rdfs:label : hasAdoptedHeir</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasAdoptedHeir">ekc:hasAdoptedHeir</a>
    /// </summary>
    let hasAdoptedHeir = _prefixId.prefix "hasAdoptedHeir"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>skos:note : A는 B 소속이다^^xsd:string</para>
    ///   <para>dce:description : ~에 소속하다</para>
    ///   <para>rdfs:label : hasAffiliation</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasAffiliation">ekc:hasAffiliation</a>
    /// </summary>
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    /// <summary>
    ///   <para>skos:note : A(관직, 타이틀)의 피임자는 B이다^^xsd:string</para>
    ///   <para>dce:description : (임명장에 기록된) 피임자는 ~이다</para>
    ///   <para>rdfs:label : hasAppointee</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasAppointee">ekc:hasAppointee</a>
    /// </summary>
    let hasAppointee = _prefixId.prefix "hasAppointee"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Architecture/Object/Record^^xsd:string</para>
    ///   <para>skos:note : A(문화유산 도메인)는 B(개별 문화유산)를 가지고 있다^^xsd:string</para>
    ///   <para>dce:description : (상위 문화재가) 개별 문화재 ~을 가지고 있다</para>
    ///   <para>rdfs:label : hasAsset</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasAsset">ekc:hasAsset</a>
    /// </summary>
    let hasAsset = _prefixId.prefix "hasAsset"
    /// <summary>
    ///   <para>skos:note : A(사찰 본사)에는 말사 B(사찰 말사)가 있다^^xsd:string</para>
    ///   <para>dce:description : (사찰 본사에) 말사 ~가 있다</para>
    ///   <para>rdfs:label : hasBranchTemple</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasBranchTemple">ekc:hasBranchTemple</a>
    /// </summary>
    let hasBranchTemple = _prefixId.prefix "hasBranchTemple"
    /// <summary>
    ///   <para>skos:scopeNote : 형 / 남동생 / 오빠 / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 형제</para>
    ///   <para>skos:example : 조선 세종 - 효령대군</para>
    ///   <para>dce:description : 형제 ~가 있다</para>
    ///   <para>rdfs:label : hasBrother</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasBrother">ekc:hasBrother</a>
    /// </summary>
    let hasBrother = _prefixId.prefix "hasBrother"
    /// <summary>
    ///   <para>skos:scopeNote : 매부 / 동서 / 처남 / 시형제 / 미상未詳^^xsd:string</para>
    ///   <para>dce:description : 매부·동서·처남·시형제 ~가 있다</para>
    ///   <para>rdfs:label : hasBrotherInLaw</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasBrotherInLaw">ekc:hasBrotherInLaw</a>
    /// </summary>
    let hasBrotherInLaw = _prefixId.prefix "hasBrotherInLaw"
    /// <summary>
    ///   <para>dce:description : 중국어 해설문 ~이 있다</para>
    ///   <para>rdfs:label : hasChineseExplanation</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasChineseExplanation">ekc:hasChineseExplanation</a>
    /// </summary>
    let hasChineseExplanation = _prefixId.prefix "hasChineseExplanation"
    /// <summary>
    ///   <para>skos:note : 첩</para>
    ///   <para>dce:description : 첩 ~를 두었다</para>
    ///   <para>rdfs:label : hasConcubine</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasConcubine">ekc:hasConcubine</a>
    /// </summary>
    let hasConcubine = _prefixId.prefix "hasConcubine"
    /// <summary>
    ///   <para>dce:description : 스토리라인을 구성하는 세부 에피소드 ~이 있다</para>
    ///   <para>rdfs:label : hasContextualElement</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasContextualElement">ekc:hasContextualElement</a>
    /// </summary>
    let hasContextualElement = _prefixId.prefix "hasContextualElement"
    /// <summary>
    ///   <para>dce:description : ~가 사촌이다</para>
    ///   <para>rdfs:label : hasCousin</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasCousin">ekc:hasCousin</a>
    /// </summary>
    let hasCousin = _prefixId.prefix "hasCousin"
    /// <summary>
    ///   <para>skos:scopeNote : 부녀관계(=isFatherOf) / 모녀관계(=isMotherOf) / 미상未詳^^xsd:string</para>
    ///   <para>dce:description : 딸 ~가 있다</para>
    ///   <para>rdfs:label : hasDaughter</para>
    ///   <para>skos:example : 장흥효 - 장계향</para>
    ///   <para>skos:note : 부녀관계 / 모녀관계</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughter">ekc:hasDaughter</a>
    /// </summary>
    let hasDaughter = _prefixId.prefix "hasDaughter"
    /// <summary>
    ///   <para>skos:scopeNote : 시부입장(=isFatherInLawOf) / 시모입장(=isMotherInLawOf) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 시부-며느리 / 시모-며느리</para>
    ///   <para>dce:description : 며느리 ~가 있다</para>
    ///   <para>rdfs:label : hasDaughterInLaw</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughterInLaw">ekc:hasDaughterInLaw</a>
    /// </summary>
    let hasDaughterInLaw = _prefixId.prefix "hasDaughterInLaw"
    /// <summary>
    ///   <para>dce:description : 후손 ~가 있다</para>
    ///   <para>skos:example : 김성일 - 김주국</para>
    ///   <para>skos:note : 세대 불특정 선조-후손 관계</para>
    ///   <para>rdfs:label : hasDescendant</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasDescendant">ekc:hasDescendant</a>
    /// </summary>
    let hasDescendant = _prefixId.prefix "hasDescendant"
    /// <summary>
    ///   <para>skos:note : 스승-제자 관계</para>
    ///   <para>skos:example : 이황 - 김성일</para>
    ///   <para>dce:description : 제자 ~가 있다</para>
    ///   <para>rdfs:label : hasDisciple</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasDisciple">ekc:hasDisciple</a>
    /// </summary>
    let hasDisciple = _prefixId.prefix "hasDisciple"
    /// <summary>
    ///   <para>dce:description : 도면 ~이 있다</para>
    ///   <para>rdfs:label : hasDrawing</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasDrawing">ekc:hasDrawing</a>
    /// </summary>
    let hasDrawing = _prefixId.prefix "hasDrawing"
    /// <summary>
    ///   <para>dce:description : 영어 해설문 ~이 있다</para>
    ///   <para>rdfs:label : hasEnglishExplanation</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasEnglishExplanation">ekc:hasEnglishExplanation</a>
    /// </summary>
    let hasEnglishExplanation = _prefixId.prefix "hasEnglishExplanation"
    /// <summary>
    ///   <para>skos:note : A(비석)에는 비문 B(비문)가 새겨져 있다^^xsd:string</para>
    ///   <para>dce:description : (비석에) 비문 ~가 새겨져 있다</para>
    ///   <para>rdfs:label : hasEpitaph</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasEpitaph">ekc:hasEpitaph</a>
    /// </summary>
    let hasEpitaph = _prefixId.prefix "hasEpitaph"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Object/Record^^xsd:string</para>
    ///   <para>dce:description : 전시회 ~에서 전시되다</para>
    ///   <para>rdfs:label : hasExhibition</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibition">ekc:hasExhibition</a>
    /// </summary>
    let hasExhibition = _prefixId.prefix "hasExhibition"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Object/Record^^xsd:stringskos:scopeNote : Range : Place/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>skos:note : 대여 전시, 소장처 외의 전시 포함.</para>
    ///   <para>dce:description : ~에서 전시하다 ※ 소장처 외의 장소. 대여 전시 등.</para>
    ///   <para>rdfs:label : hasExhibitionAt</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibitionAt">ekc:hasExhibitionAt</a>
    /// </summary>
    let hasExhibitionAt = _prefixId.prefix "hasExhibitionAt"
    /// <summary>
    ///   <para>skos:scopeNote : 부녀관계(=isDaughterOf) / 부자관계(=isSonOf) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : A의 아버지는 B이다^^xsd:string</para>
    ///   <para>dce:description : ~가 아버지이다</para>
    ///   <para>rdfs:label : hasFather</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasFather">ekc:hasFather</a>
    /// </summary>
    let hasFather = _prefixId.prefix "hasFather"
    /// <summary>
    ///   <para>skos:scopeNote : 며느리입장(=isDaughterInLawOf) / 사위입장(=isSonInLawOf) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 시부-며느리 / 장인-사위</para>
    ///   <para>dce:description : ~가 장인이다 / ~가 시아버지이다</para>
    ///   <para>rdfs:label : hasFatherInLaw</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasFatherInLaw">ekc:hasFatherInLaw</a>
    /// </summary>
    let hasFatherInLaw = _prefixId.prefix "hasFatherInLaw"
    /// <summary>
    ///   <para>dce:description : 손녀 ~가 있다</para>
    ///   <para>rdfs:label : hasGrandDaughter</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandDaughter">ekc:hasGrandDaughter</a>
    /// </summary>
    let hasGrandDaughter = _prefixId.prefix "hasGrandDaughter"
    /// <summary>
    ///   <para>dce:description : 손자 ~가 있다</para>
    ///   <para>rdfs:label : hasGrandson</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandson">ekc:hasGrandson</a>
    /// </summary>
    let hasGrandson = _prefixId.prefix "hasGrandson"
    /// <summary>
    ///   <para>skos:note : A(사찰)에는 암자 B(사찰 암자)가 있다^^xsd:string</para>
    ///   <para>dce:description : (사찰에) 암자 ~가 있다</para>
    ///   <para>rdfs:label : hasHermitage</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasHermitage">ekc:hasHermitage</a>
    /// </summary>
    let hasHermitage = _prefixId.prefix "hasHermitage"
    /// <summary>
    ///   <para>dce:description : (작품의) 역사적 배경은 ~이다</para>
    ///   <para>rdfs:label : hasHistoricalSetting</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasHistoricalSetting">ekc:hasHistoricalSetting</a>
    /// </summary>
    let hasHistoricalSetting = _prefixId.prefix "hasHistoricalSetting"
    /// <summary>
    ///   <para>dce:description : ~가 남편이다</para>
    ///   <para>rdfs:label : hasHusband</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasHusband">ekc:hasHusband</a>
    /// </summary>
    let hasHusband = _prefixId.prefix "hasHusband"
    /// <summary>
    ///   <para>dce:description : 식재료 ~를 쓴다</para>
    ///   <para>rdfs:label : hasIngredient</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasIngredient">ekc:hasIngredient</a>
    /// </summary>
    let hasIngredient = _prefixId.prefix "hasIngredient"
    /// <summary>
    ///   <para>skos:note : A(물품)에는 명문 B(명문)가 새겨져 있다^^xsd:string</para>
    ///   <para>dce:description : (물품에) 명문 ~가 새겨져 있다</para>
    ///   <para>rdfs:label : hasInscription</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasInscription">ekc:hasInscription</a>
    /// </summary>
    let hasInscription = _prefixId.prefix "hasInscription"
    /// <summary>
    ///   <para>skos:note : A의 스승은 B이다^^xsd:string</para>
    ///   <para>dce:description : ~가 스승이다</para>
    ///   <para>rdfs:label : hasMaster</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasMaster">ekc:hasMaster</a>
    /// </summary>
    let hasMaster = _prefixId.prefix "hasMaster"
    /// <summary>
    ///   <para>skos:scopeNote : 모녀관계(=isDaughterOf) / 모자관계(=isSonOf) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : A의 어머니는 B이다^^xsd:string</para>
    ///   <para>dce:description : ~가 어머니이다</para>
    ///   <para>rdfs:label : hasMother</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasMother">ekc:hasMother</a>
    /// </summary>
    let hasMother = _prefixId.prefix "hasMother"
    /// <summary>
    ///   <para>skos:scopeNote : 며느리입장(=isDaughterInLawOf) / 사위입장(=isSonInLawOf) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 시모-며느리 / 장모-사위</para>
    ///   <para>rdfs:label : hasMotherInLaw</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasMotherInLaw">ekc:hasMotherInLaw</a>
    /// </summary>
    let hasMotherInLaw = _prefixId.prefix "hasMotherInLaw"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:stringskos:scopeNote : Range : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>skos:note : A의 새 이름은 B이다^^xsd:string</para>
    ///   <para>dce:description : 새 이름은 ~이다 ※ 새 명칭; 후신(後身)^^xsd:string</para>
    ///   <para>rdfs:label : hasNewName</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasNewName">ekc:hasNewName</a>
    /// </summary>
    let hasNewName = _prefixId.prefix "hasNewName"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:stringskos:scopeNote : Range : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>skos:note : 구 명칭; 전신(前身)^^xsd:string</para>
    ///   <para>skos:example : 대우중공업 - 한국기계공업</para>
    ///   <para>dce:description : 옛 이름은 ~이다 ※ 구 명칭; 전신(前身)^^xsd:string</para>
    ///   <para>rdfs:label : hasOldName</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasOldName">ekc:hasOldName</a>
    /// </summary>
    let hasOldName = _prefixId.prefix "hasOldName"
    /// <summary>
    ///   <para>skos:note : 노비-주인 관계</para>
    ///   <para>skos:example : 일복 - 윤두서</para>
    ///   <para>dce:description : 주인은 ~이다</para>
    ///   <para>rdfs:label : hasOwner</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasOwner">ekc:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    /// <summary>
    ///   <para>dce:description : 참석자 ~가 있다</para>
    ///   <para>rdfs:label : hasParticipant</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasParticipant">ekc:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>dce:description : (이벤트에) 공연 ~이 있다</para>
    ///   <para>rdfs:label : hasPerformance</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasPerformance">ekc:hasPerformance</a>
    /// </summary>
    let hasPerformance = _prefixId.prefix "hasPerformance"
    /// <summary>
    ///   <para>dce:description : 사진 ~을 포함한다 ※ 주어는 사진첩</para>
    ///   <para>rdfs:label : hasPhoto</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasPhoto">ekc:hasPhoto</a>
    /// </summary>
    let hasPhoto = _prefixId.prefix "hasPhoto"
    /// <summary>
    ///   <para>dce:description : 고증기록 ~이 있다 ※ 목적어는 3D 재현물에 관한 고증 사실을 기록한 온라인 기사</para>
    ///   <para>rdfs:label : hasReferenceNote</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasReferenceNote">ekc:hasReferenceNote</a>
    /// </summary>
    let hasReferenceNote = _prefixId.prefix "hasReferenceNote"
    /// <summary>
    ///   <para>skos:scopeNote : 누나 / 언니 / 여동생 / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 자매</para>
    ///   <para>dce:description : 여자형제 ~가 있다</para>
    ///   <para>rdfs:label : hasSister</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasSister">ekc:hasSister</a>
    /// </summary>
    let hasSister = _prefixId.prefix "hasSister"
    /// <summary>
    ///   <para>skos:scopeNote : 시누이 / 형수 / 제수 / 올케 / 처형제 / 동서 / 미상未詳^^xsd:string</para>
    ///   <para>dce:description : 시누이·형수·제수·올케·처형제·동서 ~가 있다</para>
    ///   <para>rdfs:label : hasSisterInLaw</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasSisterInLaw">ekc:hasSisterInLaw</a>
    /// </summary>
    let hasSisterInLaw = _prefixId.prefix "hasSisterInLaw"
    /// <summary>
    ///   <para>skos:example : 부자관계: 김주국 - 김광찬skos:example : 모자관계: 혜경궁 홍씨 - 조선 정조</para>
    ///   <para>rdfs:label : hasSon</para>
    ///   <para>skos:scopeNote : 부자관계(=isFatherOf) / 모자관계(=isMotherOf) / 미상未詳^^xsd:string</para>
    ///   <para>dce:description : 아들 ~이 있다</para>
    ///   <para>skos:note : 부자관계 / 모자관계</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasSon">ekc:hasSon</a>
    /// </summary>
    let hasSon = _prefixId.prefix "hasSon"
    /// <summary>
    ///   <para>skos:scopeNote : 장인입장(=isFatherInLawOf) / 장모입장(=isMotherInLawOf) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 장인-사위 / 장모-사위</para>
    ///   <para>dce:description : 사위 ~이 있다</para>
    ///   <para>rdfs:label : hasSonInLaw</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasSonInLaw">ekc:hasSonInLaw</a>
    /// </summary>
    let hasSonInLaw = _prefixId.prefix "hasSonInLaw"
    /// <summary>
    ///   <para>rdfs:label : hasStele</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasStele">ekc:hasStele</a>
    /// </summary>
    let hasStele = _prefixId.prefix "hasStele"
    /// <summary>
    ///   <para>rdfs:label : hasStupa</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasStupa">ekc:hasStupa</a>
    /// </summary>
    let hasStupa = _prefixId.prefix "hasStupa"
    /// <summary>
    ///   <para>skos:note : 임금-신하 관계</para>
    ///   <para>skos:example : 고려 우왕 - 최영</para>
    ///   <para>dce:description : 신하 ~이 있다</para>
    ///   <para>rdfs:label : hasSubject</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasSubject">ekc:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>dce:description : (이 역사연표는) 역사적 사실 ~을 포함한다.</para>
    ///   <para>rdfs:label : hasTemporalElement</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasTemporalElement">ekc:hasTemporalElement</a>
    /// </summary>
    let hasTemporalElement = _prefixId.prefix "hasTemporalElement"
    /// <summary>
    ///   <para>dce:description : 문장 ~이 있다</para>
    ///   <para>rdfs:label : hasText</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasText">ekc:hasText</a>
    /// </summary>
    let hasText = _prefixId.prefix "hasText"
    /// <summary>
    ///   <para>dce:description : 판본 ~이 있다</para>
    ///   <para>rdfs:label : hasVersion</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasVersion">ekc:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : hasVirtualParticipant</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasVirtualParticipant">ekc:hasVirtualParticipant</a>
    /// </summary>
    let hasVirtualParticipant = _prefixId.prefix "hasVirtualParticipant"
    /// <summary>
    ///   <para>skos:scopeNote : 차서</para>
    ///   <para>skos:note : 처</para>
    ///   <para>skos:example : 사도세자 - 혜경궁 홍씨</para>
    ///   <para>dce:description : 부인 ~이 있다</para>
    ///   <para>rdfs:label : hasWife</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#hasWife">ekc:hasWife</a>
    /// </summary>
    let hasWife = _prefixId.prefix "hasWife"
    /// <summary>
    ///   <para>dce:description : ~를 포함하다</para>
    ///   <para>rdfs:label : includes</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#includes">ekc:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>skos:note : 비문 새긴 이</para>
    ///   <para>dce:description : (금석문의) 글씨를 새긴 이는 ~이다</para>
    ///   <para>rdfs:label : inscriber</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#inscriber">ekc:inscriber</a>
    /// </summary>
    let inscriber = _prefixId.prefix "inscriber"
    /// <summary>
    ///   <para>rdfs:label : isAdministratedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isAdministratedBy">ekc:isAdministratedBy</a>
    /// </summary>
    let isAdministratedBy = _prefixId.prefix "isAdministratedBy"
    /// <summary>
    ///   <para>rdfs:label : isAdoptedHeirOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isAdoptedHeirOf">ekc:isAdoptedHeirOf</a>
    /// </summary>
    let isAdoptedHeirOf = _prefixId.prefix "isAdoptedHeirOf"
    /// <summary>
    ///   <para>skos:note : 인척(혼인으로 맺어진 친척)</para>
    ///   <para>dce:description : ~의 인척이다</para>
    ///   <para>rdfs:label : isAffinalKinOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isAffinalKinOf">ekc:isAffinalKinOf</a>
    /// </summary>
    let isAffinalKinOf = _prefixId.prefix "isAffinalKinOf"
    /// <summary>
    ///   <para>rdfs:label : isAnnotatorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isAnnotatorOf">ekc:isAnnotatorOf</a>
    /// </summary>
    let isAnnotatorOf = _prefixId.prefix "isAnnotatorOf"
    /// <summary>
    ///   <para>dce:description : ~에서 입수할 수 있다 ※ 목적어는 3D 재현물을 다운로드받을 수 있는 온라인 사이트</para>
    ///   <para>rdfs:label : isAvailableAt</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isAvailableAt">ekc:isAvailableAt</a>
    /// </summary>
    let isAvailableAt = _prefixId.prefix "isAvailableAt"
    /// <summary>
    ///   <para>skos:scopeNote : relation attribute : 수량(quantity. 예: 1필)^^xsd:string</para>
    ///   <para>dce:description : ~을 상으로 받다</para>
    ///   <para>rdfs:label : isAwarded</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isAwarded">ekc:isAwarded</a>
    /// </summary>
    let isAwarded = _prefixId.prefix "isAwarded"
    /// <summary>
    ///   <para>skos:note : A(장소)는 B(인물)의 생가/출생지이다^^xsd:string</para>
    ///   <para>dce:description : ~의 생가/출생지이다</para>
    ///   <para>rdfs:label : isBirthPlaceOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isBirthPlaceOf">ekc:isBirthPlaceOf</a>
    /// </summary>
    let isBirthPlaceOf = _prefixId.prefix "isBirthPlaceOf"
    /// <summary>
    ///   <para>rdfs:label : isBrotherOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isBrotherOf">ekc:isBrotherOf</a>
    /// </summary>
    let isBrotherOf = _prefixId.prefix "isBrotherOf"
    /// <summary>
    ///   <para>rdfs:label : isCalligrapherOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isCalligrapherOf">ekc:isCalligrapherOf</a>
    /// </summary>
    let isCalligrapherOf = _prefixId.prefix "isCalligrapherOf"
    /// <summary>
    ///   <para>skos:note : A(사건)는 B로 인해 발생했다^^xsd:string</para>
    ///   <para>dce:description : (사건이) 사건 ~로 인해 발생했다</para>
    ///   <para>rdfs:label : isCausedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isCausedBy">ekc:isCausedBy</a>
    /// </summary>
    let isCausedBy = _prefixId.prefix "isCausedBy"
    /// <summary>
    ///   <para>dce:description : ~의 수태지이다</para>
    ///   <para>rdfs:label : isConceptionPlaceOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isConceptionPlaceOf">ekc:isConceptionPlaceOf</a>
    /// </summary>
    let isConceptionPlaceOf = _prefixId.prefix "isConceptionPlaceOf"
    /// <summary>
    ///   <para>dce:description : ~의 첩이다</para>
    ///   <para>rdfs:label : isConcubineOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isConcubineOf">ekc:isConcubineOf</a>
    /// </summary>
    let isConcubineOf = _prefixId.prefix "isConcubineOf"
    /// <summary>
    ///   <para>rdfs:label : isConstructorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isConstructorOf">ekc:isConstructorOf</a>
    /// </summary>
    let isConstructorOf = _prefixId.prefix "isConstructorOf"
    /// <summary>
    ///   <para>rdfs:label : isContributorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isContributorOf">ekc:isContributorOf</a>
    /// </summary>
    let isContributorOf = _prefixId.prefix "isContributorOf"
    /// <summary>
    ///   <para>rdfs:label : isCreatorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isCreatorOf">ekc:isCreatorOf</a>
    /// </summary>
    let isCreatorOf = _prefixId.prefix "isCreatorOf"
    /// <summary>
    ///   <para>rdfs:label : isCurrentLocationOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentLocationOf">ekc:isCurrentLocationOf</a>
    /// </summary>
    let isCurrentLocationOf = _prefixId.prefix "isCurrentLocationOf"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : (현존건물이) 유적지 ~에 있다</para>
    ///   <para>rdfs:label : isCurrentlySituatedOn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentlySituatedOn">ekc:isCurrentlySituatedOn</a>
    /// </summary>
    let isCurrentlySituatedOn = _prefixId.prefix "isCurrentlySituatedOn"
    /// <summary>
    ///   <para>skos:scopeNote : 시부대상(=hasFatherInLaw) / 시모대상(=hasMotherInLaw) / 미상未詳^^xsd:string</para>
    ///   <para>rdfs:label : isDaughterInLawOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterInLawOf">ekc:isDaughterInLawOf</a>
    /// </summary>
    let isDaughterInLawOf = _prefixId.prefix "isDaughterInLawOf"
    /// <summary>
    ///   <para>skos:scopeNote : 부녀관계(=hasFather) / 모녀관계(=hasMother) / 미상未詳^^xsd:string</para>
    ///   <para>rdfs:label : isDaughterOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterOf">ekc:isDaughterOf</a>
    /// </summary>
    let isDaughterOf = _prefixId.prefix "isDaughterOf"
    /// <summary>
    ///   <para>dce:description : ~의 사망지이다</para>
    ///   <para>rdfs:label : isDeathPlaceOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDeathPlaceOf">ekc:isDeathPlaceOf</a>
    /// </summary>
    let isDeathPlaceOf = _prefixId.prefix "isDeathPlaceOf"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Object/Record^^xsd:string</para>
    ///   <para>skos:note : A는 B 속에서 묘사되다^^xsd:string</para>
    ///   <para>skos:example : 고산구곡 - 고산구곡도</para>
    ///   <para>dce:description : ~에 묘사되어 있다</para>
    ///   <para>rdfs:label : isDepictedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDepictedIn">ekc:isDepictedIn</a>
    /// </summary>
    let isDepictedIn = _prefixId.prefix "isDepictedIn"
    /// <summary>
    ///   <para>rdfs:label : isDescendantOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDescendantOf">ekc:isDescendantOf</a>
    /// </summary>
    let isDescendantOf = _prefixId.prefix "isDescendantOf"
    /// <summary>
    ///   <para>skos:note : A(문화유산)는 문화유산 B(지정번호)로 지정되었다^^xsd:string</para>
    ///   <para>dce:description : (문화재) ~로 지정되다</para>
    ///   <para>rdfs:label : isDesignatedAs</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDesignatedAs">ekc:isDesignatedAs</a>
    /// </summary>
    let isDesignatedAs = _prefixId.prefix "isDesignatedAs"
    /// <summary>
    ///   <para>rdfs:label : isDiscipleOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDiscipleOf">ekc:isDiscipleOf</a>
    /// </summary>
    let isDiscipleOf = _prefixId.prefix "isDiscipleOf"
    /// <summary>
    ///   <para>rdfs:label : isDocumentedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isDocumentedIn">ekc:isDocumentedIn</a>
    /// </summary>
    let isDocumentedIn = _prefixId.prefix "isDocumentedIn"
    /// <summary>
    ///   <para>skos:note : 제향</para>
    ///   <para>skos:example : 이순신 - 현충사</para>
    ///   <para>dce:description : ~에 제향되다</para>
    ///   <para>rdfs:label : isEnshrinedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isEnshrinedIn">ekc:isEnshrinedIn</a>
    /// </summary>
    let isEnshrinedIn = _prefixId.prefix "isEnshrinedIn"
    /// <summary>
    ///   <para>skos:scopeNote : 장인입장(=hasSonInLaw) / 시부입장(=hasDaughterInLaw) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 시부-며느리 / 장인-사위</para>
    ///   <para>rdfs:label : isFatherInLawOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isFatherInLawOf">ekc:isFatherInLawOf</a>
    /// </summary>
    let isFatherInLawOf = _prefixId.prefix "isFatherInLawOf"
    /// <summary>
    ///   <para>skos:scopeNote : 부녀관계(=hasDaughter) / 부자관계(=hasSon) / 미상未詳^^xsd:string</para>
    ///   <para>rdfs:label : isFatherOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isFatherOf">ekc:isFatherOf</a>
    /// </summary>
    let isFatherOf = _prefixId.prefix "isFatherOf"
    /// <summary>
    ///   <para>skos:note : 동문수학/동류</para>
    ///   <para>dce:description : ~의 친구이다</para>
    ///   <para>rdfs:label : isFellowOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isFellowOf">ekc:isFellowOf</a>
    /// </summary>
    let isFellowOf = _prefixId.prefix "isFellowOf"
    /// <summary>
    ///   <para>rdfs:label : isFormerlocationOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isFormerlocationOf">ekc:isFormerlocationOf</a>
    /// </summary>
    let isFormerlocationOf = _prefixId.prefix "isFormerlocationOf"
    /// <summary>
    ///   <para>rdfs:label : isFounderOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isFounderOf">ekc:isFounderOf</a>
    /// </summary>
    let isFounderOf = _prefixId.prefix "isFounderOf"
    /// <summary>
    ///   <para>dce:description : 상화 ~로 장식하다</para>
    ///   <para>rdfs:label : isGarnishedWith</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isGarnishedWith">ekc:isGarnishedWith</a>
    /// </summary>
    let isGarnishedWith = _prefixId.prefix "isGarnishedWith"
    /// <summary>
    ///   <para>rdfs:label : isGrandDaughterOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isGrandDaughterOf">ekc:isGrandDaughterOf</a>
    /// </summary>
    let isGrandDaughterOf = _prefixId.prefix "isGrandDaughterOf"
    /// <summary>
    ///   <para>rdfs:label : isGrandsonOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isGrandsonOf">ekc:isGrandsonOf</a>
    /// </summary>
    let isGrandsonOf = _prefixId.prefix "isGrandsonOf"
    /// <summary>
    ///   <para>dce:description : ~에서 개최되었다</para>
    ///   <para>rdfs:label : isHeldAt</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isHeldAt">ekc:isHeldAt</a>
    /// </summary>
    let isHeldAt = _prefixId.prefix "isHeldAt"
    /// <summary>
    ///   <para>dce:description : 아카이브 소장 자료의 소장처는 ~이다 ※ 목적어는 아카이브</para>
    ///   <para>rdfs:label : isHeldBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isHeldBy">ekc:isHeldBy</a>
    /// </summary>
    let isHeldBy = _prefixId.prefix "isHeldBy"
    /// <summary>
    ///   <para>dce:description : ~를 위해 개최되었다</para>
    ///   <para>rdfs:label : isHeldFor</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isHeldFor">ekc:isHeldFor</a>
    /// </summary>
    let isHeldFor = _prefixId.prefix "isHeldFor"
    /// <summary>
    ///   <para>rdfs:label : isHusbandOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isHusbandOf">ekc:isHusbandOf</a>
    /// </summary>
    let isHusbandOf = _prefixId.prefix "isHusbandOf"
    /// <summary>
    ///   <para>dce:description : ~에 의해 영향받다</para>
    ///   <para>rdfs:label : isInfluencedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isInfluencedBy">ekc:isInfluencedBy</a>
    /// </summary>
    let isInfluencedBy = _prefixId.prefix "isInfluencedBy"
    /// <summary>
    ///   <para>rdfs:label : isInscriberOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isInscriberOf">ekc:isInscriberOf</a>
    /// </summary>
    let isInscriberOf = _prefixId.prefix "isInscriberOf"
    /// <summary>
    ///   <para>dce:description : ~의 한 종류이다 ※ 분류 체계상의 분류인 경우에는 type^^xsd:string</para>
    ///   <para>rdfs:label : isKindOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isKindOf">ekc:isKindOf</a>
    /// </summary>
    let isKindOf = _prefixId.prefix "isKindOf"
    /// <summary>
    ///   <para>skos:note : 직계친족</para>
    ///   <para>dce:description : ~의 친척이다</para>
    ///   <para>rdfs:label : isLineageKinOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isLineageKinOf">ekc:isLineageKinOf</a>
    /// </summary>
    let isLineageKinOf = _prefixId.prefix "isLineageKinOf"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)/Object^^xsd:string</para>
    ///   <para>dce:description : ~에 위치하다</para>
    ///   <para>rdfs:label : isLocatedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isLocatedIn">ekc:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>dce:description : ~로 만들었다</para>
    ///   <para>rdfs:label : isMadeOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMadeOf">ekc:isMadeOf</a>
    /// </summary>
    let isMadeOf = _prefixId.prefix "isMadeOf"
    /// <summary>
    ///   <para>rdfs:label : isMasterOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMasterOf">ekc:isMasterOf</a>
    /// </summary>
    let isMasterOf = _prefixId.prefix "isMasterOf"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : ~의 일원이다</para>
    ///   <para>rdfs:label : isMemberOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMemberOf">ekc:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>dce:description : ~에 의해 언급되었다</para>
    ///   <para>rdfs:label : isMentionedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedBy">ekc:isMentionedBy</a>
    /// </summary>
    let isMentionedBy = _prefixId.prefix "isMentionedBy"
    /// <summary>
    ///   <para>skos:note : A가 문헌 B 내용에서 명확히 언급됨^^xsd:string</para>
    ///   <para>skos:example : 청심원 - 언해납약증치방</para>
    ///   <para>dce:description : ~에 언급되다</para>
    ///   <para>rdfs:label : isMentionedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedIn">ekc:isMentionedIn</a>
    /// </summary>
    let isMentionedIn = _prefixId.prefix "isMentionedIn"
    /// <summary>
    ///   <para>skos:scopeNote : 시모입장(=hasDaughterInLaw) / 장모입장(=hasSonInLaw) / 미상未詳^^xsd:string</para>
    ///   <para>skos:note : 시모-며느리 / 장모-사위</para>
    ///   <para>rdfs:label : isMotherInLawOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMotherInLawOf">ekc:isMotherInLawOf</a>
    /// </summary>
    let isMotherInLawOf = _prefixId.prefix "isMotherInLawOf"
    /// <summary>
    ///   <para>skos:scopeNote : 모녀관계(=hasDaughter) / 모자관계(=hasSon) / 미상未詳^^xsd:string</para>
    ///   <para>rdfs:label : isMotherOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isMotherOf">ekc:isMotherOf</a>
    /// </summary>
    let isMotherOf = _prefixId.prefix "isMotherOf"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:stringskos:scopeNote : Range : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : ~를 따라 이름지었다</para>
    ///   <para>rdfs:label : isNamedAfter</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isNamedAfter">ekc:isNamedAfter</a>
    /// </summary>
    let isNamedAfter = _prefixId.prefix "isNamedAfter"
    /// <summary>
    ///   <para>dce:description : ~가 명명했다</para>
    ///   <para>rdfs:label : isNamedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isNamedBy">ekc:isNamedBy</a>
    /// </summary>
    let isNamedBy = _prefixId.prefix "isNamedBy"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:stringskos:scopeNote : Range : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : ~와 같은 이름이다 ※ 실체는 다른데 이름이 같은 경우</para>
    ///   <para>rdfs:label : isNamesakeOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isNamesakeOf">ekc:isNamesakeOf</a>
    /// </summary>
    let isNamesakeOf = _prefixId.prefix "isNamesakeOf"
    /// <summary>
    ///   <para>skos:note : 물리적 인접</para>
    ///   <para>skos:example : 금산 칠백의총 - 금산 칠백의총 기념관</para>
    ///   <para>dce:description : ~에 가까이 있다</para>
    ///   <para>rdfs:label : isNear</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isNear">ekc:isNear</a>
    /// </summary>
    let isNear = _prefixId.prefix "isNear"
    /// <summary>
    ///   <para>rdfs:label : isNewNameOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isNewNameOf">ekc:isNewNameOf</a>
    /// </summary>
    let isNewNameOf = _prefixId.prefix "isNewNameOf"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : 관청 ~의 관직이다</para>
    ///   <para>rdfs:label : isOfficialPostOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isOfficialPostOf">ekc:isOfficialPostOf</a>
    /// </summary>
    let isOfficialPostOf = _prefixId.prefix "isOfficialPostOf"
    /// <summary>
    ///   <para>rdfs:label : isOldNameOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isOldNameOf">ekc:isOldNameOf</a>
    /// </summary>
    let isOldNameOf = _prefixId.prefix "isOldNameOf"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : (시설이) 이벤트 ~에서 운영되었다</para>
    ///   <para>rdfs:label : isOperatedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isOperatedIn">ekc:isOperatedIn</a>
    /// </summary>
    let isOperatedIn = _prefixId.prefix "isOperatedIn"
    /// <summary>
    ///   <para>rdfs:label : isOwnerOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isOwnerOf">ekc:isOwnerOf</a>
    /// </summary>
    let isOwnerOf = _prefixId.prefix "isOwnerOf"
    /// <summary>
    ///   <para>dce:description : (과거시험) ~의 합격자이다</para>
    ///   <para>rdfs:label : isPasserOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPasserOf">ekc:isPasserOf</a>
    /// </summary>
    let isPasserOf = _prefixId.prefix "isPasserOf"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Event/Concept^^xsd:string</para>
    ///   <para>skos:note : 의식 실행 장소</para>
    ///   <para>skos:example : 독립선언식 - 태화관</para>
    ///   <para>dce:description : (공연/의식이) ~에서 열렸다</para>
    ///   <para>rdfs:label : isPerformedAt</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedAt">ekc:isPerformedAt</a>
    /// </summary>
    let isPerformedAt = _prefixId.prefix "isPerformedAt"
    /// <summary>
    ///   <para>dce:description : ~가 공연했다</para>
    ///   <para>rdfs:label : isPerformedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedBy">ekc:isPerformedBy</a>
    /// </summary>
    let isPerformedBy = _prefixId.prefix "isPerformedBy"
    /// <summary>
    ///   <para>dce:description : (공연이) 이벤트 ~에서 공연되었다</para>
    ///   <para>rdfs:label : isPerformedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedIn">ekc:isPerformedIn</a>
    /// </summary>
    let isPerformedIn = _prefixId.prefix "isPerformedIn"
    /// <summary>
    ///   <para>dce:description : ~의 태실이다</para>
    ///   <para>rdfs:label : isPlacentaChamberOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPlacentaChamberOf">ekc:isPlacentaChamberOf</a>
    /// </summary>
    let isPlacentaChamberOf = _prefixId.prefix "isPlacentaChamberOf"
    /// <summary>
    ///   <para>dce:description : 사진이 문헌(신문, 잡지) ~에 실렸다</para>
    ///   <para>rdfs:label : isPostedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPostedIn">ekc:isPostedIn</a>
    /// </summary>
    let isPostedIn = _prefixId.prefix "isPostedIn"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Event/Concept^^xsd:stringskos:scopeNote : Range : Event/Concept^^xsd:string</para>
    ///   <para>skos:note : 사건, 항목 간의 인접연속 관계. A 다음이 B인 순서.^^xsd:string</para>
    ///   <para>skos:example : 1번 - 2번^^xsd:string</para>
    ///   <para>dce:description : (순서상) ~ 앞이다. ※ 사건, 항목 간의 인접연속 관계. A 다음이 B인 순서.^^xsd:string</para>
    ///   <para>rdfs:label : isPreviousInSequenceTo</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPreviousInSequenceTo">ekc:isPreviousInSequenceTo</a>
    /// </summary>
    let isPreviousInSequenceTo = _prefixId.prefix "isPreviousInSequenceTo"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Place/Architecture/Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : (부존건물이) 유적지 ~에 있었다</para>
    ///   <para>rdfs:label : isPreviouslySituatedOn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPreviouslySituatedOn">ekc:isPreviouslySituatedOn</a>
    /// </summary>
    let isPreviouslySituatedOn = _prefixId.prefix "isPreviouslySituatedOn"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Actor/Place^^xsd:string</para>
    ///   <para>dce:description : ~에서 만든다</para>
    ///   <para>rdfs:label : isProducedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isProducedBy">ekc:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>dce:description : ~ 지역에서 생산된다</para>
    ///   <para>rdfs:label : isProducedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isProducedIn">ekc:isProducedIn</a>
    /// </summary>
    let isProducedIn = _prefixId.prefix "isProducedIn"
    /// <summary>
    ///   <para>rdfs:label : isProvenanceOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isProvenanceOf">ekc:isProvenanceOf</a>
    /// </summary>
    let isProvenanceOf = _prefixId.prefix "isProvenanceOf"
    /// <summary>
    ///   <para>dce:description : (상차림이) 이벤트 ~에서 제공되다</para>
    ///   <para>rdfs:label : isProvidedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isProvidedIn">ekc:isProvidedIn</a>
    /// </summary>
    let isProvidedIn = _prefixId.prefix "isProvidedIn"
    /// <summary>
    ///   <para>rdfs:label : isPublisherOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isPublisherOf">ekc:isPublisherOf</a>
    /// </summary>
    let isPublisherOf = _prefixId.prefix "isPublisherOf"
    /// <summary>
    ///   <para>rdfs:label : isReconstructorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isReconstructorOf">ekc:isReconstructorOf</a>
    /// </summary>
    let isReconstructorOf = _prefixId.prefix "isReconstructorOf"
    /// <summary>
    ///   <para>dce:description : 문헌자료 ~를 참고하다</para>
    ///   <para>rdfs:label : isReferencedFrom</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isReferencedFrom">ekc:isReferencedFrom</a>
    /// </summary>
    let isReferencedFrom = _prefixId.prefix "isReferencedFrom"
    /// <summary>
    ///   <para>rdfs:label : isRenovatorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isRenovatorOf">ekc:isRenovatorOf</a>
    /// </summary>
    let isRenovatorOf = _prefixId.prefix "isRenovatorOf"
    /// <summary>
    ///   <para>rdfs:label : isRightsHolderOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isRightsHolderOf">ekc:isRightsHolderOf</a>
    /// </summary>
    let isRightsHolderOf = _prefixId.prefix "isRightsHolderOf"
    /// <summary>
    ///   <para>dce:description : (음식이) 그릇 ~에 담아 제공되다</para>
    ///   <para>rdfs:label : isServedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isServedIn">ekc:isServedIn</a>
    /// </summary>
    let isServedIn = _prefixId.prefix "isServedIn"
    /// <summary>
    ///   <para>dce:description : (음식이) 음식상 ~에 차려지다</para>
    ///   <para>rdfs:label : isServedOn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isServedOn">ekc:isServedOn</a>
    /// </summary>
    let isServedOn = _prefixId.prefix "isServedOn"
    /// <summary>
    ///   <para>dce:description : 인물 ~에게 제공되다</para>
    ///   <para>rdfs:label : isServedTo</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isServedTo">ekc:isServedTo</a>
    /// </summary>
    let isServedTo = _prefixId.prefix "isServedTo"
    /// <summary>
    ///   <para>rdfs:label : isSisterOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isSisterOf">ekc:isSisterOf</a>
    /// </summary>
    let isSisterOf = _prefixId.prefix "isSisterOf"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Place/Architecture/Agent^^xsd:string</para>
    ///   <para>dce:description : ~의 유적지이다</para>
    ///   <para>rdfs:label : isSiteOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isSiteOf">ekc:isSiteOf</a>
    /// </summary>
    let isSiteOf = _prefixId.prefix "isSiteOf"
    /// <summary>
    ///   <para>skos:scopeNote : 장인대상(=hasFatherInLaw) / 장모대상(=hasMotherInLaw) / 미상未詳^^xsd:string</para>
    ///   <para>rdfs:label : isSonInLawOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isSonInLawOf">ekc:isSonInLawOf</a>
    /// </summary>
    let isSonInLawOf = _prefixId.prefix "isSonInLawOf"
    /// <summary>
    ///   <para>skos:scopeNote : 부자관계(=hasFather) / 모자관계(=hasMother) / 미상未詳^^xsd:string</para>
    ///   <para>rdfs:label : isSonOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isSonOf">ekc:isSonOf</a>
    /// </summary>
    let isSonOf = _prefixId.prefix "isSonOf"
    /// <summary>
    ///   <para>skos:note : 인물·사건의 기념비</para>
    ///   <para>skos:example : 장흥 보림사 보조선사탑비 - 체징</para>
    ///   <para>dce:description : ~의 신도비(탑비)이다</para>
    ///   <para>rdfs:label : isSteleOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isSteleOf">ekc:isSteleOf</a>
    /// </summary>
    let isSteleOf = _prefixId.prefix "isSteleOf"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Place/Architecture^^xsd:string</para>
    ///   <para>dce:description : ~에 보관하다</para>
    ///   <para>rdfs:label : isStoredIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isStoredIn">ekc:isStoredIn</a>
    /// </summary>
    let isStoredIn = _prefixId.prefix "isStoredIn"
    /// <summary>
    ///   <para>skos:note : 승탑</para>
    ///   <para>skos:example : 장흥 보림사 보조선사탑- 체징</para>
    ///   <para>dce:description : ~의 승탑이다</para>
    ///   <para>rdfs:label : isStupaOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isStupaOf">ekc:isStupaOf</a>
    /// </summary>
    let isStupaOf = _prefixId.prefix "isStupaOf"
    /// <summary>
    ///   <para>rdfs:label : isSubjectOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isSubjectOf">ekc:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    /// <summary>
    ///   <para>skos:note : A는 B의 무덤(인물)이다^^xsd:string</para>
    ///   <para>dce:description : ~의 무덤이다</para>
    ///   <para>rdfs:label : isTombOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isTombOf">ekc:isTombOf</a>
    /// </summary>
    let isTombOf = _prefixId.prefix "isTombOf"
    /// <summary>
    ///   <para>dce:description : ~의 비석이다</para>
    ///   <para>rdfs:label : isTombstoneOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isTombstoneOf">ekc:isTombstoneOf</a>
    /// </summary>
    let isTombstoneOf = _prefixId.prefix "isTombstoneOf"
    /// <summary>
    ///   <para>rdfs:label : isTranslatorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isTranslatorOf">ekc:isTranslatorOf</a>
    /// </summary>
    let isTranslatorOf = _prefixId.prefix "isTranslatorOf"
    /// <summary>
    ///   <para>skos:note : 의례·사건에서의 사용</para>
    ///   <para>skos:example : 근배 - 동뢰</para>
    ///   <para>dce:description : ~에 쓰인다</para>
    ///   <para>rdfs:label : isUsedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isUsedIn">ekc:isUsedIn</a>
    /// </summary>
    let isUsedIn = _prefixId.prefix "isUsedIn"
    /// <summary>
    ///   <para>dce:description : (인물이) 사건 ~의 희생자이다</para>
    ///   <para>rdfs:label : isVictimOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isVictimOf">ekc:isVictimOf</a>
    /// </summary>
    let isVictimOf = _prefixId.prefix "isVictimOf"
    /// <summary>
    ///   <para>dce:description : ~의 부인이다</para>
    ///   <para>rdfs:label : isWifeOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isWifeOf">ekc:isWifeOf</a>
    /// </summary>
    let isWifeOf = _prefixId.prefix "isWifeOf"
    /// <summary>
    ///   <para>rdfs:label : isWornBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isWornBy">ekc:isWornBy</a>
    /// </summary>
    let isWornBy = _prefixId.prefix "isWornBy"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Event/Concept^^xsd:string</para>
    ///   <para>dce:description : (복장을) 행사 ~에서 입다</para>
    ///   <para>rdfs:label : isWornIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isWornIn">ekc:isWornIn</a>
    /// </summary>
    let isWornIn = _prefixId.prefix "isWornIn"
    /// <summary>
    ///   <para>rdfs:label : isWriterOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#isWriterOf">ekc:isWriterOf</a>
    /// </summary>
    let isWriterOf = _prefixId.prefix "isWriterOf"
    /// <summary>
    ///   <para>dce:description : (인물이) 사건 ~을 주도하다</para>
    ///   <para>rdfs:label : leads</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#leads">ekc:leads</a>
    /// </summary>
    let leads = _prefixId.prefix "leads"
    /// <summary>
    ///   <para>dce:description : ~에 살다</para>
    ///   <para>rdfs:label : livesIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#livesIn">ekc:livesIn</a>
    /// </summary>
    let livesIn = _prefixId.prefix "livesIn"
    /// <summary>
    ///   <para>skos:note : 문헌 A의 내용 중 B를 명확히 언급^^xsd:string</para>
    ///   <para>skos:example : 언해납약증치방 - 청심원</para>
    ///   <para>dce:description : ~를 언급하다</para>
    ///   <para>rdfs:label : mentions</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#mentions">ekc:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
    /// <summary>
    ///   <para>dce:description : ~과 관계가 있을지도 모른다</para>
    ///   <para>rdfs:label : mightBeRelatedTo</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#mightBeRelatedTo">ekc:mightBeRelatedTo</a>
    /// </summary>
    let mightBeRelatedTo = _prefixId.prefix "mightBeRelatedTo"
    /// <summary>
    ///   <para>skos:scopeNote : Range : Index/WebResource^^xsd:string</para>
    ///   <para>dce:description : 웹자원 목록은 ~이다 ※ 목적어는 웹자원 색인(ref-XXXX) 노드^^xsd:string</para>
    ///   <para>rdfs:label : onlineReference</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#onlineReference">ekc:onlineReference</a>
    /// </summary>
    let onlineReference = _prefixId.prefix "onlineReference"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Record/Object^^xsd:string</para>
    ///   <para>dce:description : (유물의) 소유주는 ~이다</para>
    ///   <para>rdfs:label : owner</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#owner">ekc:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>dce:description : ~에 참여하다</para>
    ///   <para>rdfs:label : participatesIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#participatesIn">ekc:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>dce:description : 악기 ~를 연주하다</para>
    ///   <para>rdfs:label : plays</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#plays">ekc:plays</a>
    /// </summary>
    let plays = _prefixId.prefix "plays"
    /// <summary>
    ///   <para>skos:scopeNote : Domain : Agent(Actor의 subclasses 중 기관, 단체 등)^^xsd:string</para>
    ///   <para>dce:description : 음식, 식재료 ~을 준비한다</para>
    ///   <para>rdfs:label : prepares</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#prepares">ekc:prepares</a>
    /// </summary>
    let prepares = _prefixId.prefix "prepares"
    /// <summary>
    ///   <para>skos:note : 수축(修築)을 지휘^^xsd:string</para>
    ///   <para>skos:example : 백마산성 - 강감찬</para>
    ///   <para>dce:description : 재건자는 ~이다 ※ 수축(修築)을 지휘^^xsd:string</para>
    ///   <para>rdfs:label : reconstructor</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#reconstructor">ekc:reconstructor</a>
    /// </summary>
    let reconstructor = _prefixId.prefix "reconstructor"
    /// <summary>
    ///   <para>skos:note : 중창·중건 추진</para>
    ///   <para>skos:example : 고성 유점사 - 유정</para>
    ///   <para>dce:description : 중건자는 ~이다 ※ 중창·중건 추진</para>
    ///   <para>rdfs:label : renovator</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#renovator">ekc:renovator</a>
    /// </summary>
    let renovator = _prefixId.prefix "renovator"
    /// <summary>
    ///   <para>dce:description : 음식 ~을 차린다</para>
    ///   <para>rdfs:label : serves</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#serves">ekc:serves</a>
    /// </summary>
    let serves = _prefixId.prefix "serves"
    /// <summary>
    ///   <para>skos:note : (관직/직무/역할)을 수행
    /// [HistoryNote] servedAs 에서 변경</para>
    ///   <para>skos:example : 서유문 - 서장관</para>
    ///   <para>dce:description : 관직 ~를 역임했다</para>
    ///   <para>rdfs:label : servesAs</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#servesAs">ekc:servesAs</a>
    /// </summary>
    let servesAs = _prefixId.prefix "servesAs"
    /// <summary>
    ///   <para>dce:description : 임시로 ~의 직책을 수행하다</para>
    ///   <para>rdfs:label : servesTemporarilyAs</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#servesTemporarilyAs">ekc:servesTemporarilyAs</a>
    /// </summary>
    let servesTemporarilyAs = _prefixId.prefix "servesTemporarilyAs"
    /// <summary>
    ///   <para>dce:description : 문헌상의 근거 텍스트는 ~이다 ※ 목적어는 온라인 텍스트 원문</para>
    ///   <para>rdfs:label : textReference</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#textReference">ekc:textReference</a>
    /// </summary>
    let textReference = _prefixId.prefix "textReference"
    /// <summary>
    ///   <para>dce:description : 연표 ~이 있다 ※ 목적어는 주어와 관련이 있는 역사연표</para>
    ///   <para>rdfs:label : timeline</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#timeline">ekc:timeline</a>
    /// </summary>
    let timeline = _prefixId.prefix "timeline"
    /// <summary>
    ///   <para>skos:note : 번역자; 언해자.</para>
    ///   <para>skos:example : 태교신기언해 - 유희</para>
    ///   <para>dce:description : 번역자는 ~이다</para>
    ///   <para>rdfs:label : translator</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#translator">ekc:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>dce:description : ~에 가상으로 참여하다. ~에 참여한 것으로 간주하다 ※ 기록물에 참여한 듯이 기록</para>
    ///   <para>rdfs:label : virtuallyParticipatesIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#virtuallyParticipatesIn">ekc:virtuallyParticipatesIn</a>
    /// </summary>
    let virtuallyParticipatesIn = _prefixId.prefix "virtuallyParticipatesIn"
    /// <summary>
    ///   <para>dce:description : ~에 묻혔다</para>
    ///   <para>rdfs:label : wasBuriedIn</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#wasBuriedIn">ekc:wasBuriedIn</a>
    /// </summary>
    let wasBuriedIn = _prefixId.prefix "wasBuriedIn"
    /// <summary>
    ///   <para>dce:description : ~에서 처형되었다</para>
    ///   <para>rdfs:label : wasExecutedAt</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#wasExecutedAt">ekc:wasExecutedAt</a>
    /// </summary>
    let wasExecutedAt = _prefixId.prefix "wasExecutedAt"
    /// <summary>
    ///   <para>skos:note : 계를 받았다(승려 간)</para>
    ///   <para>skos:example : 수철 - 윤법</para>
    ///   <para>dce:description : ~로부터 계를 받았다</para>
    ///   <para>rdfs:label : wasOrdainedBy</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#wasOrdainedBy">ekc:wasOrdainedBy</a>
    /// </summary>
    let wasOrdainedBy = _prefixId.prefix "wasOrdainedBy"
    /// <summary>
    ///   <para>dce:description : 증직 ~를 받다</para>
    ///   <para>rdfs:label : wasPosthumouslyPromotedTo</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#wasPosthumouslyPromotedTo">ekc:wasPosthumouslyPromotedTo</a>
    /// </summary>
    let wasPosthumouslyPromotedTo = _prefixId.prefix "wasPosthumouslyPromotedTo"
    /// <summary>
    ///   <para>rdfs:label : wasPreceptorOf</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#wasPreceptorOf">ekc:wasPreceptorOf</a>
    /// </summary>
    let wasPreceptorOf = _prefixId.prefix "wasPreceptorOf"
    /// <summary>
    ///   <para>skos:note : 궁중복식에서 입는 대상</para>
    ///   <para>skos:example : 궁녀 - 당의</para>
    ///   <para>dce:description : 복장 ~를 입다</para>
    ///   <para>rdfs:label : wears</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#wears">ekc:wears</a>
    /// </summary>
    let wears = _prefixId.prefix "wears"
    /// <summary>
    ///   <para>skos:note : 글 쓴 사람. 비문 지은이.</para>
    ///   <para>skos:example : 김언경 - 장흥 보림사 보조선사탑비</para>
    ///   <para>dce:description : (금석문의) 글 쓴 이는 ~이다</para>
    ///   <para>rdfs:label : writer</para>
    ///   <a href="http://dh.aks.ac.kr/ontologies/ekc#writer">ekc:writer</a>
    /// </summary>
    let writer = _prefixId.prefix "writer"
