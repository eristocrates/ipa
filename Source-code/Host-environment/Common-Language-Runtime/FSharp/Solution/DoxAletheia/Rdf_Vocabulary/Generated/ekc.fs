namespace http.dh.aks.ac.kr.ontologies.ekc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ekc =
    let _namespace_iri = Namespace_Iri ekc |> NamespaceIRI
    /// <summary>
    ///   <para>ekc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#">http://dh.aks.ac.kr/ontologies/ekc#</seealso>
    let _prefix_iri = Prefixed_Name(ekc, "") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"개념용어"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4">http://dh.aks.ac.kr/ontologies/ekc#%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4</seealso>
    let ``_%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4`` =
        Prefixed_Name(ekc, "%EA%B0%9C%EB%85%90%EC%9A%A9%EC%96%B4") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B1%B4%EC%B6%95</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"건축"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95">http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95</seealso>
    let ``_%EA%B1%B4%EC%B6%95`` =
        Prefixed_Name(ekc, "%EA%B1%B4%EC%B6%95") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"건축부품"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88">http://dh.aks.ac.kr/ontologies/ekc#%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88</seealso>
    let ``_%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88`` =
        Prefixed_Name(ekc, "%EA%B1%B4%EC%B6%95%EB%B6%80%ED%92%88") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B3%A0%EB%AC%B8%ED%97%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"고문헌"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EB%AC%B8%ED%97%8C">http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EB%AC%B8%ED%97%8C</seealso>
    let ``_%EA%B3%A0%EB%AC%B8%ED%97%8C`` =
        Prefixed_Name(ekc, "%EA%B3%A0%EB%AC%B8%ED%97%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B3%A0%EC%A7%80%EB%AA%85</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"고지명"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EC%A7%80%EB%AA%85">http://dh.aks.ac.kr/ontologies/ekc#%EA%B3%A0%EC%A7%80%EB%AA%85</seealso>
    let ``_%EA%B3%A0%EC%A7%80%EB%AA%85`` =
        Prefixed_Name(ekc, "%EA%B3%A0%EC%A7%80%EB%AA%85") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B4%80%EC%84%9C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"관서"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%84%9C">http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%84%9C</seealso>
    let ``_%EA%B4%80%EC%84%9C`` =
        Prefixed_Name(ekc, "%EA%B4%80%EC%84%9C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B4%80%EC%A7%81</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"관직"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%A7%81">http://dh.aks.ac.kr/ontologies/ekc#%EA%B4%80%EC%A7%81</seealso>
    let ``_%EA%B4%80%EC%A7%81`` =
        Prefixed_Name(ekc, "%EA%B4%80%EC%A7%81") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B5%AD%EA%B0%80</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"국가"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EA%B0%80">http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EA%B0%80</seealso>
    let ``_%EA%B5%AD%EA%B0%80`` =
        Prefixed_Name(ekc, "%EA%B5%AD%EA%B0%80") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B5%AD%EB%B3%B4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"국보"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EB%B3%B4">http://dh.aks.ac.kr/ontologies/ekc#%EA%B5%AD%EB%B3%B4</seealso>
    let ``_%EA%B5%AD%EB%B3%B4`` =
        Prefixed_Name(ekc, "%EA%B5%AD%EB%B3%B4") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B7%B8%EB%A6%BC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"그림"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%B8%EB%A6%BC">http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%B8%EB%A6%BC</seealso>
    let ``_%EA%B7%B8%EB%A6%BC`` =
        Prefixed_Name(ekc, "%EA%B7%B8%EB%A6%BC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"근대문헌"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C">http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C</seealso>
    let ``_%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        Prefixed_Name(ekc, "%EA%B7%BC%EB%8C%80%EB%AC%B8%ED%97%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"근대유적지"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80">http://dh.aks.ac.kr/ontologies/ekc#%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80</seealso>
    let ``_%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        Prefixed_Name(ekc, "%EA%B7%BC%EB%8C%80%EC%9C%A0%EC%A0%81%EC%A7%80") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B8%88%EC%84%9D%EB%AC%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"금석문"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%88%EC%84%9D%EB%AC%B8">http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%88%EC%84%9D%EB%AC%B8</seealso>
    let ``_%EA%B8%88%EC%84%9D%EB%AC%B8`` =
        Prefixed_Name(ekc, "%EA%B8%88%EC%84%9D%EB%AC%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B8%B0%EA%B4%80</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"기관"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EA%B4%80">http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EA%B4%80</seealso>
    let ``_%EA%B8%B0%EA%B4%80`` =
        Prefixed_Name(ekc, "%EA%B8%B0%EA%B4%80") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B8%B0%EB%85%90%EB%AC%BC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"기념물"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EB%85%90%EB%AC%BC">http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EB%85%90%EB%AC%BC</seealso>
    let ``_%EA%B8%B0%EB%85%90%EB%AC%BC`` =
        Prefixed_Name(ekc, "%EA%B8%B0%EB%85%90%EB%AC%BC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B8%B0%EC%82%AC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"기사"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%82%AC">http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%82%AC</seealso>
    let ``_%EA%B8%B0%EC%82%AC`` =
        Prefixed_Name(ekc, "%EA%B8%B0%EC%82%AC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EA%B8%B0%EC%9E%A5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"기장"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%9E%A5">http://dh.aks.ac.kr/ontologies/ekc#%EA%B8%B0%EC%9E%A5</seealso>
    let ``_%EA%B8%B0%EC%9E%A5`` =
        Prefixed_Name(ekc, "%EA%B8%B0%EC%9E%A5") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%85%BC%EB%AC%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"논문"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%85%BC%EB%AC%B8">http://dh.aks.ac.kr/ontologies/ekc#%EB%85%BC%EB%AC%B8</seealso>
    let ``_%EB%85%BC%EB%AC%B8`` =
        Prefixed_Name(ekc, "%EB%85%BC%EB%AC%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%8B%A8%EC%B2%B4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"단체"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%EC%B2%B4">http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%EC%B2%B4</seealso>
    let ``_%EB%8B%A8%EC%B2%B4`` =
        Prefixed_Name(ekc, "%EB%8B%A8%EC%B2%B4") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%8B%A8%ED%96%89%EB%B3%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"단행본"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%ED%96%89%EB%B3%B8">http://dh.aks.ac.kr/ontologies/ekc#%EB%8B%A8%ED%96%89%EB%B3%B8</seealso>
    let ``_%EB%8B%A8%ED%96%89%EB%B3%B8`` =
        Prefixed_Name(ekc, "%EB%8B%A8%ED%96%89%EB%B3%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%8F%84%EB%A9%B4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"도면"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%84%EB%A9%B4">http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%84%EB%A9%B4</seealso>
    let ``_%EB%8F%84%EB%A9%B4`` =
        Prefixed_Name(ekc, "%EB%8F%84%EB%A9%B4") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%8F%99%EC%98%81%EC%83%81</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"동영상"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%99%EC%98%81%EC%83%81">http://dh.aks.ac.kr/ontologies/ekc#%EB%8F%99%EC%98%81%EC%83%81</seealso>
    let ``_%EB%8F%99%EC%98%81%EC%83%81`` =
        Prefixed_Name(ekc, "%EB%8F%99%EC%98%81%EC%83%81") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"등록문화유산"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC">http://dh.aks.ac.kr/ontologies/ekc#%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC</seealso>
    let ``_%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        Prefixed_Name(ekc, "%EB%93%B1%EB%A1%9D%EB%AC%B8%ED%99%94%EC%9E%AC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"명문(銘文)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87">http://dh.aks.ac.kr/ontologies/ekc#%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87</seealso>
    let ``_%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87`` =
        Prefixed_Name(ekc, "%EB%AA%85%EB%AC%B8%E9%8A%98%E6%96%87") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AC%B4%EC%9A%A9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"무용"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%EC%9A%A9">http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%EC%9A%A9</seealso>
    let ``_%EB%AC%B4%EC%9A%A9`` =
        Prefixed_Name(ekc, "%EB%AC%B4%EC%9A%A9") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AC%B4%ED%98%95</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"무형"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%ED%98%95">http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B4%ED%98%95</seealso>
    let ``_%EB%AC%B4%ED%98%95`` =
        Prefixed_Name(ekc, "%EB%AC%B4%ED%98%95") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AC%B8%ED%95%99</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"문학"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%95%99">http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%95%99</seealso>
    let ``_%EB%AC%B8%ED%95%99`` =
        Prefixed_Name(ekc, "%EB%AC%B8%ED%95%99") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AC%B8%ED%97%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"문헌"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%97%8C">http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%B8%ED%97%8C</seealso>
    let ``_%EB%AC%B8%ED%97%8C`` =
        Prefixed_Name(ekc, "%EB%AC%B8%ED%97%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AC%BC%ED%92%88</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"물품"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%BC%ED%92%88">http://dh.aks.ac.kr/ontologies/ekc#%EB%AC%BC%ED%92%88</seealso>
    let ``_%EB%AC%BC%ED%92%88`` =
        Prefixed_Name(ekc, "%EB%AC%BC%ED%92%88") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AE%A4%EC%A7%80%EC%BB%AC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"뮤지컬"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AE%A4%EC%A7%80%EC%BB%AC">http://dh.aks.ac.kr/ontologies/ekc#%EB%AE%A4%EC%A7%80%EC%BB%AC</seealso>
    let ``_%EB%AE%A4%EC%A7%80%EC%BB%AC`` =
        Prefixed_Name(ekc, "%EB%AE%A4%EC%A7%80%EC%BB%AC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%AF%B8%EC%88%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"미술"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%AF%B8%EC%88%A0">http://dh.aks.ac.kr/ontologies/ekc#%EB%AF%B8%EC%88%A0</seealso>
    let ``_%EB%AF%B8%EC%88%A0`` =
        Prefixed_Name(ekc, "%EB%AF%B8%EC%88%A0") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%B2%88%EC%97%AD%EB%AC%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"번역문"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B2%88%EC%97%AD%EB%AC%B8">http://dh.aks.ac.kr/ontologies/ekc#%EB%B2%88%EC%97%AD%EB%AC%B8</seealso>
    let ``_%EB%B2%88%EC%97%AD%EB%AC%B8`` =
        Prefixed_Name(ekc, "%EB%B2%88%EC%97%AD%EB%AC%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%B3%B4%EB%AC%BC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"보물"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B4%EB%AC%BC">http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B4%EB%AC%BC</seealso>
    let ``_%EB%B3%B4%EB%AC%BC`` =
        Prefixed_Name(ekc, "%EB%B3%B4%EB%AC%BC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%B3%B5%EC%8B%9D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"복식"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%8B%9D">http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%8B%9D</seealso>
    let ``_%EB%B3%B5%EC%8B%9D`` =
        Prefixed_Name(ekc, "%EB%B3%B5%EC%8B%9D") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%B3%B5%EC%9E%A5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"복장"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%9E%A5">http://dh.aks.ac.kr/ontologies/ekc#%EB%B3%B5%EC%9E%A5</seealso>
    let ``_%EB%B3%B5%EC%9E%A5`` =
        Prefixed_Name(ekc, "%EB%B3%B5%EC%9E%A5") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"분류주제"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C">http://dh.aks.ac.kr/ontologies/ekc#%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C</seealso>
    let ``_%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C`` =
        Prefixed_Name(ekc, "%EB%B6%84%EB%A5%98%EC%A3%BC%EC%A0%9C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%82%AC%EA%B1%B4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"사건"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EA%B1%B4">http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EA%B1%B4</seealso>
    let ``_%EC%82%AC%EA%B1%B4`` =
        Prefixed_Name(ekc, "%EC%82%AC%EA%B1%B4") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%82%AC%EC%A0%81</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"사적"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A0%81">http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A0%81</seealso>
    let ``_%EC%82%AC%EC%A0%81`` =
        Prefixed_Name(ekc, "%EC%82%AC%EC%A0%81") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%82%AC%EC%A7%84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"사진"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A7%84">http://dh.aks.ac.kr/ontologies/ekc#%EC%82%AC%EC%A7%84</seealso>
    let ``_%EC%82%AC%EC%A7%84`` =
        Prefixed_Name(ekc, "%EC%82%AC%EC%A7%84") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%83%81%EC%B0%A8%EB%A6%BC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"상차림"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%83%81%EC%B0%A8%EB%A6%BC">http://dh.aks.ac.kr/ontologies/ekc#%EC%83%81%EC%B0%A8%EB%A6%BC</seealso>
    let ``_%EC%83%81%EC%B0%A8%EB%A6%BC`` =
        Prefixed_Name(ekc, "%EC%83%81%EC%B0%A8%EB%A6%BC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%86%8C%EC%9E%A5%EC%B2%98</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"소장처"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%86%8C%EC%9E%A5%EC%B2%98">http://dh.aks.ac.kr/ontologies/ekc#%EC%86%8C%EC%9E%A5%EC%B2%98</seealso>
    let ``_%EC%86%8C%EC%9E%A5%EC%B2%98`` =
        Prefixed_Name(ekc, "%EC%86%8C%EC%9E%A5%EC%B2%98") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"스토리라인"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8">http://dh.aks.ac.kr/ontologies/ekc#%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8</seealso>
    let ``_%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8`` =
        Prefixed_Name(ekc, "%EC%8A%A4%ED%86%A0%EB%A6%AC%EB%9D%BC%EC%9D%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"시각자료"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C">http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C</seealso>
    let ``_%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C`` =
        Prefixed_Name(ekc, "%EC%8B%9C%EA%B0%81%EC%9E%90%EB%A3%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"시도문화유산"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC">http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC</seealso>
    let ``_%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC`` =
        Prefixed_Name(ekc, "%EC%8B%9C%EB%8F%84%EB%AC%B8%ED%99%94%EC%9E%AC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%8B%9D%EC%9E%AC%EB%A3%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"식재료"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9D%EC%9E%AC%EB%A3%8C">http://dh.aks.ac.kr/ontologies/ekc#%EC%8B%9D%EC%9E%AC%EB%A3%8C</seealso>
    let ``_%EC%8B%9D%EC%9E%AC%EB%A3%8C`` =
        Prefixed_Name(ekc, "%EC%8B%9D%EC%9E%AC%EB%A3%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"에피소드"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C">http://dh.aks.ac.kr/ontologies/ekc#%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C</seealso>
    let ``_%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C`` =
        Prefixed_Name(ekc, "%EC%97%90%ED%94%BC%EC%86%8C%EB%93%9C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%97%B0%EA%B7%B9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"연극"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%97%B0%EA%B7%B9">http://dh.aks.ac.kr/ontologies/ekc#%EC%97%B0%EA%B7%B9</seealso>
    let ``_%EC%97%B0%EA%B7%B9`` =
        Prefixed_Name(ekc, "%EC%97%B0%EA%B7%B9") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%98%81%ED%99%94</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"영화"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%98%81%ED%99%94">http://dh.aks.ac.kr/ontologies/ekc#%EC%98%81%ED%99%94</seealso>
    let ``_%EC%98%81%ED%99%94`` =
        Prefixed_Name(ekc, "%EC%98%81%ED%99%94") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9B%90%EB%AC%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"원문"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%90%EB%AC%B8">http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%90%EB%AC%B8</seealso>
    let ``_%EC%9B%90%EB%AC%B8`` =
        Prefixed_Name(ekc, "%EC%9B%90%EB%AC%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"웹자원색인"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8">http://dh.aks.ac.kr/ontologies/ekc#%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8</seealso>
    let ``_%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8`` =
        Prefixed_Name(ekc, "%EC%9B%B9%EC%9E%90%EC%9B%90%EC%83%89%EC%9D%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9C%A0%EC%A0%81%EC%A7%80</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"유적지"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9C%A0%EC%A0%81%EC%A7%80">http://dh.aks.ac.kr/ontologies/ekc#%EC%9C%A0%EC%A0%81%EC%A7%80</seealso>
    let ``_%EC%9C%A0%EC%A0%81%EC%A7%80`` =
        Prefixed_Name(ekc, "%EC%9C%A0%EC%A0%81%EC%A7%80") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9D%8C%EC%8B%9D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"음식"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%8B%9D">http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%8B%9D</seealso>
    let ``_%EC%9D%8C%EC%8B%9D`` =
        Prefixed_Name(ekc, "%EC%9D%8C%EC%8B%9D") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9D%8C%EC%95%85</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"음악"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%95%85">http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%8C%EC%95%85</seealso>
    let ``_%EC%9D%8C%EC%95%85`` =
        Prefixed_Name(ekc, "%EC%9D%8C%EC%95%85") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9D%98%EB%A1%80</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"의례"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%98%EB%A1%80">http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%98%EB%A1%80</seealso>
    let ``_%EC%9D%98%EB%A1%80`` =
        Prefixed_Name(ekc, "%EC%9D%98%EB%A1%80") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9D%B8%EB%AC%BC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"인물"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC">http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC</seealso>
    let ``_%EC%9D%B8%EB%AC%BC`` =
        Prefixed_Name(ekc, "%EC%9D%B8%EB%AC%BC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9D%B8%EB%AC%BC%EA%B5%B0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"인물군"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC%EA%B5%B0">http://dh.aks.ac.kr/ontologies/ekc#%EC%9D%B8%EB%AC%BC%EA%B5%B0</seealso>
    let ``_%EC%9D%B8%EB%AC%BC%EA%B5%B0`` =
        Prefixed_Name(ekc, "%EC%9D%B8%EB%AC%BC%EA%B5%B0") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"자연지명"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85">http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85</seealso>
    let ``_%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85`` =
        Prefixed_Name(ekc, "%EC%9E%90%EC%97%B0%EC%A7%80%EB%AA%85") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%9E%A5%EC%86%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"장소"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%A5%EC%86%8C">http://dh.aks.ac.kr/ontologies/ekc#%EC%9E%A5%EC%86%8C</seealso>
    let ``_%EC%9E%A5%EC%86%8C`` =
        Prefixed_Name(ekc, "%EC%9E%A5%EC%86%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%A0%84%EC%8B%9C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"전시"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%84%EC%8B%9C">http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%84%EC%8B%9C</seealso>
    let ``_%EC%A0%84%EC%8B%9C`` =
        Prefixed_Name(ekc, "%EC%A0%84%EC%8B%9C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%A0%9C%EB%8F%84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"제도"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EB%8F%84">http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EB%8F%84</seealso>
    let ``_%EC%A0%9C%EB%8F%84`` =
        Prefixed_Name(ekc, "%EC%A0%9C%EB%8F%84") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%A0%9C%EC%88%98</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"제수"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EC%88%98">http://dh.aks.ac.kr/ontologies/ekc#%EC%A0%9C%EC%88%98</seealso>
    let ``_%EC%A0%9C%EC%88%98`` =
        Prefixed_Name(ekc, "%EC%A0%9C%EC%88%98") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%A1%B0%ED%98%95</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"조형"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A1%B0%ED%98%95">http://dh.aks.ac.kr/ontologies/ekc#%EC%A1%B0%ED%98%95</seealso>
    let ``_%EC%A1%B0%ED%98%95`` =
        Prefixed_Name(ekc, "%EC%A1%B0%ED%98%95") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%A7%80%EB%8F%84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"지도"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%80%EB%8F%84">http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%80%EB%8F%84</seealso>
    let ``_%EC%A7%80%EB%8F%84`` =
        Prefixed_Name(ekc, "%EC%A7%80%EB%8F%84") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%A7%81%EC%97%AD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"직역"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%81%EC%97%AD">http://dh.aks.ac.kr/ontologies/ekc#%EC%A7%81%EC%97%AD</seealso>
    let ``_%EC%A7%81%EC%97%AD`` =
        Prefixed_Name(ekc, "%EC%A7%81%EC%97%AD") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%B0%B8%EA%B3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"참고"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0">http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0</seealso>
    let ``_%EC%B0%B8%EA%B3%A0`` =
        Prefixed_Name(ekc, "%EC%B0%B8%EA%B3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"참고문헌색인"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8">http://dh.aks.ac.kr/ontologies/ekc#%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8</seealso>
    let ``_%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8`` =
        Prefixed_Name(ekc, "%EC%B0%B8%EA%B3%A0%EB%AC%B8%ED%97%8C%EC%83%89%EC%9D%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%83%91%EB%B3%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"탑본"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%83%91%EB%B3%B8">http://dh.aks.ac.kr/ontologies/ekc#%ED%83%91%EB%B3%B8</seealso>
    let ``_%ED%83%91%EB%B3%B8`` =
        Prefixed_Name(ekc, "%ED%83%91%EB%B3%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%95%B4%EC%84%A4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"해설"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%95%B4%EC%84%A4">http://dh.aks.ac.kr/ontologies/ekc#%ED%95%B4%EC%84%A4</seealso>
    let ``_%ED%95%B4%EC%84%A4`` =
        Prefixed_Name(ekc, "%ED%95%B4%EC%84%A4") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%96%89%EC%82%AC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"행사"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%82%AC">http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%82%AC</seealso>
    let ``_%ED%96%89%EC%82%AC`` =
        Prefixed_Name(ekc, "%ED%96%89%EC%82%AC") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"행정지명"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85">http://dh.aks.ac.kr/ontologies/ekc#%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85</seealso>
    let ``_%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85`` =
        Prefixed_Name(ekc, "%ED%96%89%EC%A0%95%EC%A7%80%EB%AA%85") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"현대문헌"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C">http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C</seealso>
    let ``_%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C`` =
        Prefixed_Name(ekc, "%ED%98%84%EB%8C%80%EB%AC%B8%ED%97%8C") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%98%84%ED%8C%90</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"현판"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%ED%8C%90">http://dh.aks.ac.kr/ontologies/ekc#%ED%98%84%ED%8C%90</seealso>
    let ``_%ED%98%84%ED%8C%90`` =
        Prefixed_Name(ekc, "%ED%98%84%ED%8C%90") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%98%B8%EC%B9%AD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"호칭"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%98%B8%EC%B9%AD">http://dh.aks.ac.kr/ontologies/ekc#%ED%98%B8%EC%B9%AD</seealso>
    let ``_%ED%98%B8%EC%B9%AD`` =
        Prefixed_Name(ekc, "%ED%98%B8%EC%B9%AD") |> PrefixedName

    /// <summary>
    ///   <para>ekc:%ED%99%94%ED%8F%90</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"화폐"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#%ED%99%94%ED%8F%90">http://dh.aks.ac.kr/ontologies/ekc#%ED%99%94%ED%8F%90</seealso>
    let ``_%ED%99%94%ED%8F%90`` =
        Prefixed_Name(ekc, "%ED%99%94%ED%8F%90") |> PrefixedName

    /// <summary>
    ///   <para>ekc:3D_%EB%AA%A8%EB%8D%B8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3D_모델"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EB%AA%A8%EB%8D%B8">http://dh.aks.ac.kr/ontologies/ekc#3D_%EB%AA%A8%EB%8D%B8</seealso>
    let ``_3D_%EB%AA%A8%EB%8D%B8`` =
        Prefixed_Name(ekc, "3D_%EB%AA%A8%EB%8D%B8") |> PrefixedName

    /// <summary>
    ///   <para>ekc:3D_%EC%A7%80%EB%8F%84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3D_지도"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#3D_%EC%A7%80%EB%8F%84">http://dh.aks.ac.kr/ontologies/ekc#3D_%EC%A7%80%EB%8F%84</seealso>
    let ``_3D_%EC%A7%80%EB%8F%84`` =
        Prefixed_Name(ekc, "3D_%EC%A7%80%EB%8F%84") |> PrefixedName

    /// <summary>
    ///   <para>ekc:A1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"A1"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#A1">http://dh.aks.ac.kr/ontologies/ekc#A1</seealso>
    let A1 = Prefixed_Name(ekc, "A1") |> PrefixedName
    /// <summary>
    ///   <para>ekc:A2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"A2"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#A2">http://dh.aks.ac.kr/ontologies/ekc#A2</seealso>
    let A2 = Prefixed_Name(ekc, "A2") |> PrefixedName
    /// <summary>
    ///   <para>ekc:A3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"A3"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#A3">http://dh.aks.ac.kr/ontologies/ekc#A3</seealso>
    let A3 = Prefixed_Name(ekc, "A3") |> PrefixedName
    /// <summary>
    ///   <para>ekc:A4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"A4"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#A4">http://dh.aks.ac.kr/ontologies/ekc#A4</seealso>
    let A4 = Prefixed_Name(ekc, "A4") |> PrefixedName
    /// <summary>
    ///   <para>ekc:AR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"AR"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#AR">http://dh.aks.ac.kr/ontologies/ekc#AR</seealso>
    let AR = Prefixed_Name(ekc, "AR") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Actor">http://dh.aks.ac.kr/ontologies/ekc#Actor</seealso>
    let Actor = Prefixed_Name(ekc, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Architecture"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Architecture">http://dh.aks.ac.kr/ontologies/ekc#Architecture</seealso>
    let Architecture = Prefixed_Name(ekc, "Architecture") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bibliography"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Bibliography">http://dh.aks.ac.kr/ontologies/ekc#Bibliography</seealso>
    let Bibliography = Prefixed_Name(ekc, "Bibliography") |> PrefixedName
    /// <summary>
    ///   <para>ekc:CL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"CL"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#CL">http://dh.aks.ac.kr/ontologies/ekc#CL</seealso>
    let CL = Prefixed_Name(ekc, "CL") |> PrefixedName
    /// <summary>
    ///   <para>ekc:CO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"CO"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#CO">http://dh.aks.ac.kr/ontologies/ekc#CO</seealso>
    let CO = Prefixed_Name(ekc, "CO") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Clothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clothing"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Clothing">http://dh.aks.ac.kr/ontologies/ekc#Clothing</seealso>
    let Clothing = Prefixed_Name(ekc, "Clothing") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Concept"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Concept">http://dh.aks.ac.kr/ontologies/ekc#Concept</seealso>
    let Concept = Prefixed_Name(ekc, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>ekc:E1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"E1"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#E1">http://dh.aks.ac.kr/ontologies/ekc#E1</seealso>
    let E1 = Prefixed_Name(ekc, "E1") |> PrefixedName
    /// <summary>
    ///   <para>ekc:E2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"E2"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#E2">http://dh.aks.ac.kr/ontologies/ekc#E2</seealso>
    let E2 = Prefixed_Name(ekc, "E2") |> PrefixedName
    /// <summary>
    ///   <para>ekc:E3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"E3"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#E3">http://dh.aks.ac.kr/ontologies/ekc#E3</seealso>
    let E3 = Prefixed_Name(ekc, "E3") |> PrefixedName
    /// <summary>
    ///   <para>ekc:E4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"E4"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#E4">http://dh.aks.ac.kr/ontologies/ekc#E4</seealso>
    let E4 = Prefixed_Name(ekc, "E4") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Event">http://dh.aks.ac.kr/ontologies/ekc#Event</seealso>
    let Event = Prefixed_Name(ekc, "Event") |> PrefixedName
    /// <summary>
    ///   <para>ekc:FO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"FO"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#FO">http://dh.aks.ac.kr/ontologies/ekc#FO</seealso>
    let FO = Prefixed_Name(ekc, "FO") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Food"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Food">http://dh.aks.ac.kr/ontologies/ekc#Food</seealso>
    let Food = Prefixed_Name(ekc, "Food") |> PrefixedName
    /// <summary>
    ///   <para>ekc:HR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"HR"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#HR">http://dh.aks.ac.kr/ontologies/ekc#HR</seealso>
    let HR = Prefixed_Name(ekc, "HR") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Heritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heritage"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Heritage">http://dh.aks.ac.kr/ontologies/ekc#Heritage</seealso>
    let Heritage = Prefixed_Name(ekc, "Heritage") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Index"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Index">http://dh.aks.ac.kr/ontologies/ekc#Index</seealso>
    let Index = Prefixed_Name(ekc, "Index") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Multimedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multimedia"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Multimedia">http://dh.aks.ac.kr/ontologies/ekc#Multimedia</seealso>
    let Multimedia = Prefixed_Name(ekc, "Multimedia") |> PrefixedName
    /// <summary>
    ///   <para>ekc:NM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"NM"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#NM">http://dh.aks.ac.kr/ontologies/ekc#NM</seealso>
    let NM = Prefixed_Name(ekc, "NM") |> PrefixedName
    /// <summary>
    ///   <para>ekc:OB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"OB"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#OB">http://dh.aks.ac.kr/ontologies/ekc#OB</seealso>
    let OB = Prefixed_Name(ekc, "OB") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Object">http://dh.aks.ac.kr/ontologies/ekc#Object</seealso>
    let Object = Prefixed_Name(ekc, "Object") |> PrefixedName
    /// <summary>
    ///   <para>ekc:P1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"P1"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#P1">http://dh.aks.ac.kr/ontologies/ekc#P1</seealso>
    let P1 = Prefixed_Name(ekc, "P1") |> PrefixedName
    /// <summary>
    ///   <para>ekc:P2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"P2"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#P2">http://dh.aks.ac.kr/ontologies/ekc#P2</seealso>
    let P2 = Prefixed_Name(ekc, "P2") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Place"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Place">http://dh.aks.ac.kr/ontologies/ekc#Place</seealso>
    let Place = Prefixed_Name(ekc, "Place") |> PrefixedName
    /// <summary>
    ///   <para>ekc:RE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"RE"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#RE">http://dh.aks.ac.kr/ontologies/ekc#RE</seealso>
    let RE = Prefixed_Name(ekc, "RE") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Record"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Record">http://dh.aks.ac.kr/ontologies/ekc#Record</seealso>
    let Record = Prefixed_Name(ekc, "Record") |> PrefixedName
    /// <summary>
    ///   <para>ekc:ST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ST"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#ST">http://dh.aks.ac.kr/ontologies/ekc#ST</seealso>
    let ST = Prefixed_Name(ekc, "ST") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Story</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Story"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Story">http://dh.aks.ac.kr/ontologies/ekc#Story</seealso>
    let Story = Prefixed_Name(ekc, "Story") |> PrefixedName
    /// <summary>
    ///   <para>ekc:TM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"TM"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#TM">http://dh.aks.ac.kr/ontologies/ekc#TM</seealso>
    let TM = Prefixed_Name(ekc, "TM") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Text"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Text">http://dh.aks.ac.kr/ontologies/ekc#Text</seealso>
    let Text = Prefixed_Name(ekc, "Text") |> PrefixedName
    /// <summary>
    ///   <para>ekc:WebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WebResource"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#WebResource">http://dh.aks.ac.kr/ontologies/ekc#WebResource</seealso>
    let WebResource = Prefixed_Name(ekc, "WebResource") |> PrefixedName
    /// <summary>
    ///   <para>ekc:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Work"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#Work">http://dh.aks.ac.kr/ontologies/ekc#Work</seealso>
    let Work = Prefixed_Name(ekc, "Work") |> PrefixedName
    /// <summary>
    ///   <para>ekc:XR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"XR"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#XR">http://dh.aks.ac.kr/ontologies/ekc#XR</seealso>
    let XR = Prefixed_Name(ekc, "XR") |> PrefixedName
    /// <summary>
    ///   <para>ekc:administrates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"administrates"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#administrates">http://dh.aks.ac.kr/ontologies/ekc#administrates</seealso>
    let administrates = Prefixed_Name(ekc, "administrates") |> PrefixedName
    /// <summary>
    ///   <para>ekc:annotator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"annotator"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#annotator">http://dh.aks.ac.kr/ontologies/ekc#annotator</seealso>
    let annotator = Prefixed_Name(ekc, "annotator") |> PrefixedName
    /// <summary>
    ///   <para>ekc:appearsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"appearsIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#appearsIn">http://dh.aks.ac.kr/ontologies/ekc#appearsIn</seealso>
    let appearsIn = Prefixed_Name(ekc, "appearsIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:archiveHolding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"archiveHolding"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#archiveHolding">http://dh.aks.ac.kr/ontologies/ekc#archiveHolding</seealso>
    let archiveHolding = Prefixed_Name(ekc, "archiveHolding") |> PrefixedName
    /// <summary>
    ///   <para>ekc:bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bibliography"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#bibliography">http://dh.aks.ac.kr/ontologies/ekc#bibliography</seealso>
    let bibliography = Prefixed_Name(ekc, "bibliography") |> PrefixedName
    /// <summary>
    ///   <para>ekc:calligrapher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#calligrapher">http://dh.aks.ac.kr/ontologies/ekc#calligrapher</seealso>
    let calligrapher = Prefixed_Name(ekc, "calligrapher") |> PrefixedName
    /// <summary>
    ///   <para>ekc:commemorates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"commemorates"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#commemorates">http://dh.aks.ac.kr/ontologies/ekc#commemorates</seealso>
    let commemorates = Prefixed_Name(ekc, "commemorates") |> PrefixedName
    /// <summary>
    ///   <para>ekc:constructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"constructor"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#constructor">http://dh.aks.ac.kr/ontologies/ekc#constructor</seealso>
    let constructor = Prefixed_Name(ekc, "constructor") |> PrefixedName
    /// <summary>
    ///   <para>ekc:cooks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"cooks"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#cooks">http://dh.aks.ac.kr/ontologies/ekc#cooks</seealso>
    let cooks = Prefixed_Name(ekc, "cooks") |> PrefixedName
    /// <summary>
    ///   <para>ekc:creatorPresumed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"creatorPresumed"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#creatorPresumed">http://dh.aks.ac.kr/ontologies/ekc#creatorPresumed</seealso>
    let creatorPresumed = Prefixed_Name(ekc, "creatorPresumed") |> PrefixedName
    /// <summary>
    ///   <para>ekc:curates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"curates"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#curates">http://dh.aks.ac.kr/ontologies/ekc#curates</seealso>
    let curates = Prefixed_Name(ekc, "curates") |> PrefixedName
    /// <summary>
    ///   <para>ekc:depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"depicts"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#depicts">http://dh.aks.ac.kr/ontologies/ekc#depicts</seealso>
    let depicts = Prefixed_Name(ekc, "depicts") |> PrefixedName
    /// <summary>
    ///   <para>ekc:documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"documents"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#documents">http://dh.aks.ac.kr/ontologies/ekc#documents</seealso>
    let documents = Prefixed_Name(ekc, "documents") |> PrefixedName
    /// <summary>
    ///   <para>ekc:doner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"doner"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#doner">http://dh.aks.ac.kr/ontologies/ekc#doner</seealso>
    let doner = Prefixed_Name(ekc, "doner") |> PrefixedName
    /// <summary>
    ///   <para>ekc:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"editor"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#editor">http://dh.aks.ac.kr/ontologies/ekc#editor</seealso>
    let editor = Prefixed_Name(ekc, "editor") |> PrefixedName
    /// <summary>
    ///   <para>ekc:enshrines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"enshrines"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#enshrines">http://dh.aks.ac.kr/ontologies/ekc#enshrines</seealso>
    let enshrines = Prefixed_Name(ekc, "enshrines") |> PrefixedName
    /// <summary>
    ///   <para>ekc:founder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"founder"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#founder">http://dh.aks.ac.kr/ontologies/ekc#founder</seealso>
    let founder = Prefixed_Name(ekc, "founder") |> PrefixedName
    /// <summary>
    ///   <para>ekc:goesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"goesWith"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#goesWith">http://dh.aks.ac.kr/ontologies/ekc#goesWith</seealso>
    let goesWith = Prefixed_Name(ekc, "goesWith") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasAdoptedHeir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAdoptedHeir"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasAdoptedHeir">http://dh.aks.ac.kr/ontologies/ekc#hasAdoptedHeir</seealso>
    let hasAdoptedHeir = Prefixed_Name(ekc, "hasAdoptedHeir") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAffiliation"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasAffiliation">http://dh.aks.ac.kr/ontologies/ekc#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(ekc, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasAppointee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAppointee"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasAppointee">http://dh.aks.ac.kr/ontologies/ekc#hasAppointee</seealso>
    let hasAppointee = Prefixed_Name(ekc, "hasAppointee") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAsset"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasAsset">http://dh.aks.ac.kr/ontologies/ekc#hasAsset</seealso>
    let hasAsset = Prefixed_Name(ekc, "hasAsset") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasBranchTemple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBranchTemple"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasBranchTemple">http://dh.aks.ac.kr/ontologies/ekc#hasBranchTemple</seealso>
    let hasBranchTemple = Prefixed_Name(ekc, "hasBranchTemple") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasBrother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBrother"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasBrother">http://dh.aks.ac.kr/ontologies/ekc#hasBrother</seealso>
    let hasBrother = Prefixed_Name(ekc, "hasBrother") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasBrotherInLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBrotherInLaw"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasBrotherInLaw">http://dh.aks.ac.kr/ontologies/ekc#hasBrotherInLaw</seealso>
    let hasBrotherInLaw = Prefixed_Name(ekc, "hasBrotherInLaw") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasChineseExplanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasChineseExplanation"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasChineseExplanation">http://dh.aks.ac.kr/ontologies/ekc#hasChineseExplanation</seealso>
    let hasChineseExplanation =
        Prefixed_Name(ekc, "hasChineseExplanation") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasConcubine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasConcubine"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasConcubine">http://dh.aks.ac.kr/ontologies/ekc#hasConcubine</seealso>
    let hasConcubine = Prefixed_Name(ekc, "hasConcubine") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasContextualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasContextualElement"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasContextualElement">http://dh.aks.ac.kr/ontologies/ekc#hasContextualElement</seealso>
    let hasContextualElement =
        Prefixed_Name(ekc, "hasContextualElement") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasCousin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"hasCousin"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasCousin">http://dh.aks.ac.kr/ontologies/ekc#hasCousin</seealso>
    let hasCousin = Prefixed_Name(ekc, "hasCousin") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasDaughter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDaughter"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughter">http://dh.aks.ac.kr/ontologies/ekc#hasDaughter</seealso>
    let hasDaughter = Prefixed_Name(ekc, "hasDaughter") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasDaughterInLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDaughterInLaw"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasDaughterInLaw">http://dh.aks.ac.kr/ontologies/ekc#hasDaughterInLaw</seealso>
    let hasDaughterInLaw = Prefixed_Name(ekc, "hasDaughterInLaw") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasDescendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"hasDescendant"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasDescendant">http://dh.aks.ac.kr/ontologies/ekc#hasDescendant</seealso>
    let hasDescendant = Prefixed_Name(ekc, "hasDescendant") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasDisciple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDisciple"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasDisciple">http://dh.aks.ac.kr/ontologies/ekc#hasDisciple</seealso>
    let hasDisciple = Prefixed_Name(ekc, "hasDisciple") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasDrawing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDrawing"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasDrawing">http://dh.aks.ac.kr/ontologies/ekc#hasDrawing</seealso>
    let hasDrawing = Prefixed_Name(ekc, "hasDrawing") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasEnglishExplanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasEnglishExplanation"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasEnglishExplanation">http://dh.aks.ac.kr/ontologies/ekc#hasEnglishExplanation</seealso>
    let hasEnglishExplanation =
        Prefixed_Name(ekc, "hasEnglishExplanation") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasEpitaph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasEpitaph"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasEpitaph">http://dh.aks.ac.kr/ontologies/ekc#hasEpitaph</seealso>
    let hasEpitaph = Prefixed_Name(ekc, "hasEpitaph") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasExhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasExhibition"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibition">http://dh.aks.ac.kr/ontologies/ekc#hasExhibition</seealso>
    let hasExhibition = Prefixed_Name(ekc, "hasExhibition") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasExhibitionAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasExhibitionAt"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasExhibitionAt">http://dh.aks.ac.kr/ontologies/ekc#hasExhibitionAt</seealso>
    let hasExhibitionAt = Prefixed_Name(ekc, "hasExhibitionAt") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFather"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasFather">http://dh.aks.ac.kr/ontologies/ekc#hasFather</seealso>
    let hasFather = Prefixed_Name(ekc, "hasFather") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasFatherInLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFatherInLaw"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasFatherInLaw">http://dh.aks.ac.kr/ontologies/ekc#hasFatherInLaw</seealso>
    let hasFatherInLaw = Prefixed_Name(ekc, "hasFatherInLaw") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasGrandDaughter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasGrandDaughter"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandDaughter">http://dh.aks.ac.kr/ontologies/ekc#hasGrandDaughter</seealso>
    let hasGrandDaughter = Prefixed_Name(ekc, "hasGrandDaughter") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasGrandson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasGrandson"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasGrandson">http://dh.aks.ac.kr/ontologies/ekc#hasGrandson</seealso>
    let hasGrandson = Prefixed_Name(ekc, "hasGrandson") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasHermitage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHermitage"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasHermitage">http://dh.aks.ac.kr/ontologies/ekc#hasHermitage</seealso>
    let hasHermitage = Prefixed_Name(ekc, "hasHermitage") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasHistoricalSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHistoricalSetting"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasHistoricalSetting">http://dh.aks.ac.kr/ontologies/ekc#hasHistoricalSetting</seealso>
    let hasHistoricalSetting =
        Prefixed_Name(ekc, "hasHistoricalSetting") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasHusband</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHusband"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasHusband">http://dh.aks.ac.kr/ontologies/ekc#hasHusband</seealso>
    let hasHusband = Prefixed_Name(ekc, "hasHusband") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasIngredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasIngredient"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasIngredient">http://dh.aks.ac.kr/ontologies/ekc#hasIngredient</seealso>
    let hasIngredient = Prefixed_Name(ekc, "hasIngredient") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasInscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasInscription"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasInscription">http://dh.aks.ac.kr/ontologies/ekc#hasInscription</seealso>
    let hasInscription = Prefixed_Name(ekc, "hasInscription") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasMaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasMaster"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasMaster">http://dh.aks.ac.kr/ontologies/ekc#hasMaster</seealso>
    let hasMaster = Prefixed_Name(ekc, "hasMaster") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasMother"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasMother">http://dh.aks.ac.kr/ontologies/ekc#hasMother</seealso>
    let hasMother = Prefixed_Name(ekc, "hasMother") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasMotherInLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasMotherInLaw"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasMotherInLaw">http://dh.aks.ac.kr/ontologies/ekc#hasMotherInLaw</seealso>
    let hasMotherInLaw = Prefixed_Name(ekc, "hasMotherInLaw") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasNewName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasNewName"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasNewName">http://dh.aks.ac.kr/ontologies/ekc#hasNewName</seealso>
    let hasNewName = Prefixed_Name(ekc, "hasNewName") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasOldName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasOldName"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasOldName">http://dh.aks.ac.kr/ontologies/ekc#hasOldName</seealso>
    let hasOldName = Prefixed_Name(ekc, "hasOldName") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasOwner"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasOwner">http://dh.aks.ac.kr/ontologies/ekc#hasOwner</seealso>
    let hasOwner = Prefixed_Name(ekc, "hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasParticipant"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasParticipant">http://dh.aks.ac.kr/ontologies/ekc#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(ekc, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPerformance"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasPerformance">http://dh.aks.ac.kr/ontologies/ekc#hasPerformance</seealso>
    let hasPerformance = Prefixed_Name(ekc, "hasPerformance") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasPhoto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPhoto"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasPhoto">http://dh.aks.ac.kr/ontologies/ekc#hasPhoto</seealso>
    let hasPhoto = Prefixed_Name(ekc, "hasPhoto") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasReferenceNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasReferenceNote"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasReferenceNote">http://dh.aks.ac.kr/ontologies/ekc#hasReferenceNote</seealso>
    let hasReferenceNote = Prefixed_Name(ekc, "hasReferenceNote") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasSister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSister"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasSister">http://dh.aks.ac.kr/ontologies/ekc#hasSister</seealso>
    let hasSister = Prefixed_Name(ekc, "hasSister") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasSisterInLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSisterInLaw"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasSisterInLaw">http://dh.aks.ac.kr/ontologies/ekc#hasSisterInLaw</seealso>
    let hasSisterInLaw = Prefixed_Name(ekc, "hasSisterInLaw") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasSon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSon"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasSon">http://dh.aks.ac.kr/ontologies/ekc#hasSon</seealso>
    let hasSon = Prefixed_Name(ekc, "hasSon") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasSonInLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSonInLaw"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasSonInLaw">http://dh.aks.ac.kr/ontologies/ekc#hasSonInLaw</seealso>
    let hasSonInLaw = Prefixed_Name(ekc, "hasSonInLaw") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasStele</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasStele"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasStele">http://dh.aks.ac.kr/ontologies/ekc#hasStele</seealso>
    let hasStele = Prefixed_Name(ekc, "hasStele") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasStupa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasStupa"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasStupa">http://dh.aks.ac.kr/ontologies/ekc#hasStupa</seealso>
    let hasStupa = Prefixed_Name(ekc, "hasStupa") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSubject"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasSubject">http://dh.aks.ac.kr/ontologies/ekc#hasSubject</seealso>
    let hasSubject = Prefixed_Name(ekc, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasTemporalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTemporalElement"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasTemporalElement">http://dh.aks.ac.kr/ontologies/ekc#hasTemporalElement</seealso>
    let hasTemporalElement = Prefixed_Name(ekc, "hasTemporalElement") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasText"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasText">http://dh.aks.ac.kr/ontologies/ekc#hasText</seealso>
    let hasText = Prefixed_Name(ekc, "hasText") |> PrefixedName
    /// <summary>
    ///   <para>ekc:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasVersion"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasVersion">http://dh.aks.ac.kr/ontologies/ekc#hasVersion</seealso>
    let hasVersion = Prefixed_Name(ekc, "hasVersion") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasVirtualParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasVirtualParticipant"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasVirtualParticipant">http://dh.aks.ac.kr/ontologies/ekc#hasVirtualParticipant</seealso>
    let hasVirtualParticipant =
        Prefixed_Name(ekc, "hasVirtualParticipant") |> PrefixedName

    /// <summary>
    ///   <para>ekc:hasWife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWife"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#hasWife">http://dh.aks.ac.kr/ontologies/ekc#hasWife</seealso>
    let hasWife = Prefixed_Name(ekc, "hasWife") |> PrefixedName
    /// <summary>
    ///   <para>ekc:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"includes"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#includes">http://dh.aks.ac.kr/ontologies/ekc#includes</seealso>
    let includes = Prefixed_Name(ekc, "includes") |> PrefixedName
    /// <summary>
    ///   <para>ekc:inscriber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inscriber"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#inscriber">http://dh.aks.ac.kr/ontologies/ekc#inscriber</seealso>
    let inscriber = Prefixed_Name(ekc, "inscriber") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isAdministratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAdministratedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isAdministratedBy">http://dh.aks.ac.kr/ontologies/ekc#isAdministratedBy</seealso>
    let isAdministratedBy = Prefixed_Name(ekc, "isAdministratedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isAdoptedHeirOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAdoptedHeirOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isAdoptedHeirOf">http://dh.aks.ac.kr/ontologies/ekc#isAdoptedHeirOf</seealso>
    let isAdoptedHeirOf = Prefixed_Name(ekc, "isAdoptedHeirOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isAffinalKinOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAffinalKinOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isAffinalKinOf">http://dh.aks.ac.kr/ontologies/ekc#isAffinalKinOf</seealso>
    let isAffinalKinOf = Prefixed_Name(ekc, "isAffinalKinOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isAnnotatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAnnotatorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isAnnotatorOf">http://dh.aks.ac.kr/ontologies/ekc#isAnnotatorOf</seealso>
    let isAnnotatorOf = Prefixed_Name(ekc, "isAnnotatorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isAvailableAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAvailableAt"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isAvailableAt">http://dh.aks.ac.kr/ontologies/ekc#isAvailableAt</seealso>
    let isAvailableAt = Prefixed_Name(ekc, "isAvailableAt") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isAwarded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAwarded"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isAwarded">http://dh.aks.ac.kr/ontologies/ekc#isAwarded</seealso>
    let isAwarded = Prefixed_Name(ekc, "isAwarded") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isBirthPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isBirthPlaceOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isBirthPlaceOf">http://dh.aks.ac.kr/ontologies/ekc#isBirthPlaceOf</seealso>
    let isBirthPlaceOf = Prefixed_Name(ekc, "isBirthPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isBrotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isBrotherOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isBrotherOf">http://dh.aks.ac.kr/ontologies/ekc#isBrotherOf</seealso>
    let isBrotherOf = Prefixed_Name(ekc, "isBrotherOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isCalligrapherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCalligrapherOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isCalligrapherOf">http://dh.aks.ac.kr/ontologies/ekc#isCalligrapherOf</seealso>
    let isCalligrapherOf = Prefixed_Name(ekc, "isCalligrapherOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCausedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isCausedBy">http://dh.aks.ac.kr/ontologies/ekc#isCausedBy</seealso>
    let isCausedBy = Prefixed_Name(ekc, "isCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isConceptionPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isConceptionPlaceOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isConceptionPlaceOf">http://dh.aks.ac.kr/ontologies/ekc#isConceptionPlaceOf</seealso>
    let isConceptionPlaceOf = Prefixed_Name(ekc, "isConceptionPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isConcubineOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isConcubineOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isConcubineOf">http://dh.aks.ac.kr/ontologies/ekc#isConcubineOf</seealso>
    let isConcubineOf = Prefixed_Name(ekc, "isConcubineOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isConstructorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isConstructorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isConstructorOf">http://dh.aks.ac.kr/ontologies/ekc#isConstructorOf</seealso>
    let isConstructorOf = Prefixed_Name(ekc, "isConstructorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isContributorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isContributorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isContributorOf">http://dh.aks.ac.kr/ontologies/ekc#isContributorOf</seealso>
    let isContributorOf = Prefixed_Name(ekc, "isContributorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isCreatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCreatorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isCreatorOf">http://dh.aks.ac.kr/ontologies/ekc#isCreatorOf</seealso>
    let isCreatorOf = Prefixed_Name(ekc, "isCreatorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isCurrentLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCurrentLocationOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentLocationOf">http://dh.aks.ac.kr/ontologies/ekc#isCurrentLocationOf</seealso>
    let isCurrentLocationOf = Prefixed_Name(ekc, "isCurrentLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>ekc:isCurrentlySituatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCurrentlySituatedOn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isCurrentlySituatedOn">http://dh.aks.ac.kr/ontologies/ekc#isCurrentlySituatedOn</seealso>
    let isCurrentlySituatedOn =
        Prefixed_Name(ekc, "isCurrentlySituatedOn") |> PrefixedName

    /// <summary>
    ///   <para>ekc:isDaughterInLawOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDaughterInLawOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterInLawOf">http://dh.aks.ac.kr/ontologies/ekc#isDaughterInLawOf</seealso>
    let isDaughterInLawOf = Prefixed_Name(ekc, "isDaughterInLawOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDaughterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDaughterOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDaughterOf">http://dh.aks.ac.kr/ontologies/ekc#isDaughterOf</seealso>
    let isDaughterOf = Prefixed_Name(ekc, "isDaughterOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDeathPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDeathPlaceOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDeathPlaceOf">http://dh.aks.ac.kr/ontologies/ekc#isDeathPlaceOf</seealso>
    let isDeathPlaceOf = Prefixed_Name(ekc, "isDeathPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDepictedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDepictedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDepictedIn">http://dh.aks.ac.kr/ontologies/ekc#isDepictedIn</seealso>
    let isDepictedIn = Prefixed_Name(ekc, "isDepictedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDescendantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDescendantOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDescendantOf">http://dh.aks.ac.kr/ontologies/ekc#isDescendantOf</seealso>
    let isDescendantOf = Prefixed_Name(ekc, "isDescendantOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDesignatedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDesignatedAs"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDesignatedAs">http://dh.aks.ac.kr/ontologies/ekc#isDesignatedAs</seealso>
    let isDesignatedAs = Prefixed_Name(ekc, "isDesignatedAs") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDiscipleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDiscipleOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDiscipleOf">http://dh.aks.ac.kr/ontologies/ekc#isDiscipleOf</seealso>
    let isDiscipleOf = Prefixed_Name(ekc, "isDiscipleOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isDocumentedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDocumentedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isDocumentedIn">http://dh.aks.ac.kr/ontologies/ekc#isDocumentedIn</seealso>
    let isDocumentedIn = Prefixed_Name(ekc, "isDocumentedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isEnshrinedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isEnshrinedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isEnshrinedIn">http://dh.aks.ac.kr/ontologies/ekc#isEnshrinedIn</seealso>
    let isEnshrinedIn = Prefixed_Name(ekc, "isEnshrinedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isFatherInLawOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isFatherInLawOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isFatherInLawOf">http://dh.aks.ac.kr/ontologies/ekc#isFatherInLawOf</seealso>
    let isFatherInLawOf = Prefixed_Name(ekc, "isFatherInLawOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isFatherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isFatherOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isFatherOf">http://dh.aks.ac.kr/ontologies/ekc#isFatherOf</seealso>
    let isFatherOf = Prefixed_Name(ekc, "isFatherOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isFellowOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isFellowOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isFellowOf">http://dh.aks.ac.kr/ontologies/ekc#isFellowOf</seealso>
    let isFellowOf = Prefixed_Name(ekc, "isFellowOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isFormerlocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isFormerlocationOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isFormerlocationOf">http://dh.aks.ac.kr/ontologies/ekc#isFormerlocationOf</seealso>
    let isFormerlocationOf = Prefixed_Name(ekc, "isFormerlocationOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isFounderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isFounderOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isFounderOf">http://dh.aks.ac.kr/ontologies/ekc#isFounderOf</seealso>
    let isFounderOf = Prefixed_Name(ekc, "isFounderOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isGarnishedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isGarnishedWith"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isGarnishedWith">http://dh.aks.ac.kr/ontologies/ekc#isGarnishedWith</seealso>
    let isGarnishedWith = Prefixed_Name(ekc, "isGarnishedWith") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isGrandDaughterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isGrandDaughterOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isGrandDaughterOf">http://dh.aks.ac.kr/ontologies/ekc#isGrandDaughterOf</seealso>
    let isGrandDaughterOf = Prefixed_Name(ekc, "isGrandDaughterOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isGrandsonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isGrandsonOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isGrandsonOf">http://dh.aks.ac.kr/ontologies/ekc#isGrandsonOf</seealso>
    let isGrandsonOf = Prefixed_Name(ekc, "isGrandsonOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isHeldAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isHeldAt"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isHeldAt">http://dh.aks.ac.kr/ontologies/ekc#isHeldAt</seealso>
    let isHeldAt = Prefixed_Name(ekc, "isHeldAt") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isHeldBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isHeldBy">http://dh.aks.ac.kr/ontologies/ekc#isHeldBy</seealso>
    let isHeldBy = Prefixed_Name(ekc, "isHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isHeldFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isHeldFor"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isHeldFor">http://dh.aks.ac.kr/ontologies/ekc#isHeldFor</seealso>
    let isHeldFor = Prefixed_Name(ekc, "isHeldFor") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isHusbandOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isHusbandOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isHusbandOf">http://dh.aks.ac.kr/ontologies/ekc#isHusbandOf</seealso>
    let isHusbandOf = Prefixed_Name(ekc, "isHusbandOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isInfluencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isInfluencedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isInfluencedBy">http://dh.aks.ac.kr/ontologies/ekc#isInfluencedBy</seealso>
    let isInfluencedBy = Prefixed_Name(ekc, "isInfluencedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isInscriberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isInscriberOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isInscriberOf">http://dh.aks.ac.kr/ontologies/ekc#isInscriberOf</seealso>
    let isInscriberOf = Prefixed_Name(ekc, "isInscriberOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isKindOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isKindOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isKindOf">http://dh.aks.ac.kr/ontologies/ekc#isKindOf</seealso>
    let isKindOf = Prefixed_Name(ekc, "isKindOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isLineageKinOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isLineageKinOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isLineageKinOf">http://dh.aks.ac.kr/ontologies/ekc#isLineageKinOf</seealso>
    let isLineageKinOf = Prefixed_Name(ekc, "isLineageKinOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isLocatedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isLocatedIn">http://dh.aks.ac.kr/ontologies/ekc#isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(ekc, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMadeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMadeOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMadeOf">http://dh.aks.ac.kr/ontologies/ekc#isMadeOf</seealso>
    let isMadeOf = Prefixed_Name(ekc, "isMadeOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMasterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMasterOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMasterOf">http://dh.aks.ac.kr/ontologies/ekc#isMasterOf</seealso>
    let isMasterOf = Prefixed_Name(ekc, "isMasterOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMemberOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMemberOf">http://dh.aks.ac.kr/ontologies/ekc#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(ekc, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMentionedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMentionedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedBy">http://dh.aks.ac.kr/ontologies/ekc#isMentionedBy</seealso>
    let isMentionedBy = Prefixed_Name(ekc, "isMentionedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMentionedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMentionedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMentionedIn">http://dh.aks.ac.kr/ontologies/ekc#isMentionedIn</seealso>
    let isMentionedIn = Prefixed_Name(ekc, "isMentionedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMotherInLawOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMotherInLawOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMotherInLawOf">http://dh.aks.ac.kr/ontologies/ekc#isMotherInLawOf</seealso>
    let isMotherInLawOf = Prefixed_Name(ekc, "isMotherInLawOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isMotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMotherOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isMotherOf">http://dh.aks.ac.kr/ontologies/ekc#isMotherOf</seealso>
    let isMotherOf = Prefixed_Name(ekc, "isMotherOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isNamedAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNamedAfter"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isNamedAfter">http://dh.aks.ac.kr/ontologies/ekc#isNamedAfter</seealso>
    let isNamedAfter = Prefixed_Name(ekc, "isNamedAfter") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isNamedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNamedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isNamedBy">http://dh.aks.ac.kr/ontologies/ekc#isNamedBy</seealso>
    let isNamedBy = Prefixed_Name(ekc, "isNamedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isNamesakeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNamesakeOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isNamesakeOf">http://dh.aks.ac.kr/ontologies/ekc#isNamesakeOf</seealso>
    let isNamesakeOf = Prefixed_Name(ekc, "isNamesakeOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isNear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNear"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isNear">http://dh.aks.ac.kr/ontologies/ekc#isNear</seealso>
    let isNear = Prefixed_Name(ekc, "isNear") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isNewNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNewNameOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isNewNameOf">http://dh.aks.ac.kr/ontologies/ekc#isNewNameOf</seealso>
    let isNewNameOf = Prefixed_Name(ekc, "isNewNameOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isOfficialPostOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOfficialPostOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isOfficialPostOf">http://dh.aks.ac.kr/ontologies/ekc#isOfficialPostOf</seealso>
    let isOfficialPostOf = Prefixed_Name(ekc, "isOfficialPostOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isOldNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOldNameOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isOldNameOf">http://dh.aks.ac.kr/ontologies/ekc#isOldNameOf</seealso>
    let isOldNameOf = Prefixed_Name(ekc, "isOldNameOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isOperatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOperatedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isOperatedIn">http://dh.aks.ac.kr/ontologies/ekc#isOperatedIn</seealso>
    let isOperatedIn = Prefixed_Name(ekc, "isOperatedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isOwnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOwnerOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isOwnerOf">http://dh.aks.ac.kr/ontologies/ekc#isOwnerOf</seealso>
    let isOwnerOf = Prefixed_Name(ekc, "isOwnerOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPasserOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPasserOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPasserOf">http://dh.aks.ac.kr/ontologies/ekc#isPasserOf</seealso>
    let isPasserOf = Prefixed_Name(ekc, "isPasserOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPerformedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPerformedAt"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedAt">http://dh.aks.ac.kr/ontologies/ekc#isPerformedAt</seealso>
    let isPerformedAt = Prefixed_Name(ekc, "isPerformedAt") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPerformedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedBy">http://dh.aks.ac.kr/ontologies/ekc#isPerformedBy</seealso>
    let isPerformedBy = Prefixed_Name(ekc, "isPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPerformedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPerformedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPerformedIn">http://dh.aks.ac.kr/ontologies/ekc#isPerformedIn</seealso>
    let isPerformedIn = Prefixed_Name(ekc, "isPerformedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPlacentaChamberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPlacentaChamberOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPlacentaChamberOf">http://dh.aks.ac.kr/ontologies/ekc#isPlacentaChamberOf</seealso>
    let isPlacentaChamberOf = Prefixed_Name(ekc, "isPlacentaChamberOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPostedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPostedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPostedIn">http://dh.aks.ac.kr/ontologies/ekc#isPostedIn</seealso>
    let isPostedIn = Prefixed_Name(ekc, "isPostedIn") |> PrefixedName

    /// <summary>
    ///   <para>ekc:isPreviousInSequenceTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPreviousInSequenceTo"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPreviousInSequenceTo">http://dh.aks.ac.kr/ontologies/ekc#isPreviousInSequenceTo</seealso>
    let isPreviousInSequenceTo =
        Prefixed_Name(ekc, "isPreviousInSequenceTo") |> PrefixedName

    /// <summary>
    ///   <para>ekc:isPreviouslySituatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPreviouslySituatedOn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPreviouslySituatedOn">http://dh.aks.ac.kr/ontologies/ekc#isPreviouslySituatedOn</seealso>
    let isPreviouslySituatedOn =
        Prefixed_Name(ekc, "isPreviouslySituatedOn") |> PrefixedName

    /// <summary>
    ///   <para>ekc:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isProducedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isProducedBy">http://dh.aks.ac.kr/ontologies/ekc#isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(ekc, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isProducedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isProducedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isProducedIn">http://dh.aks.ac.kr/ontologies/ekc#isProducedIn</seealso>
    let isProducedIn = Prefixed_Name(ekc, "isProducedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isProvenanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isProvenanceOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isProvenanceOf">http://dh.aks.ac.kr/ontologies/ekc#isProvenanceOf</seealso>
    let isProvenanceOf = Prefixed_Name(ekc, "isProvenanceOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isProvidedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isProvidedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isProvidedIn">http://dh.aks.ac.kr/ontologies/ekc#isProvidedIn</seealso>
    let isProvidedIn = Prefixed_Name(ekc, "isProvidedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isPublisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPublisherOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isPublisherOf">http://dh.aks.ac.kr/ontologies/ekc#isPublisherOf</seealso>
    let isPublisherOf = Prefixed_Name(ekc, "isPublisherOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isReconstructorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isReconstructorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isReconstructorOf">http://dh.aks.ac.kr/ontologies/ekc#isReconstructorOf</seealso>
    let isReconstructorOf = Prefixed_Name(ekc, "isReconstructorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isReferencedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isReferencedFrom"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isReferencedFrom">http://dh.aks.ac.kr/ontologies/ekc#isReferencedFrom</seealso>
    let isReferencedFrom = Prefixed_Name(ekc, "isReferencedFrom") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isRenovatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRenovatorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isRenovatorOf">http://dh.aks.ac.kr/ontologies/ekc#isRenovatorOf</seealso>
    let isRenovatorOf = Prefixed_Name(ekc, "isRenovatorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isRightsHolderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRightsHolderOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isRightsHolderOf">http://dh.aks.ac.kr/ontologies/ekc#isRightsHolderOf</seealso>
    let isRightsHolderOf = Prefixed_Name(ekc, "isRightsHolderOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isServedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isServedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isServedIn">http://dh.aks.ac.kr/ontologies/ekc#isServedIn</seealso>
    let isServedIn = Prefixed_Name(ekc, "isServedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isServedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isServedOn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isServedOn">http://dh.aks.ac.kr/ontologies/ekc#isServedOn</seealso>
    let isServedOn = Prefixed_Name(ekc, "isServedOn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isServedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isServedTo"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isServedTo">http://dh.aks.ac.kr/ontologies/ekc#isServedTo</seealso>
    let isServedTo = Prefixed_Name(ekc, "isServedTo") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isSisterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSisterOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isSisterOf">http://dh.aks.ac.kr/ontologies/ekc#isSisterOf</seealso>
    let isSisterOf = Prefixed_Name(ekc, "isSisterOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isSiteOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSiteOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isSiteOf">http://dh.aks.ac.kr/ontologies/ekc#isSiteOf</seealso>
    let isSiteOf = Prefixed_Name(ekc, "isSiteOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isSonInLawOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSonInLawOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isSonInLawOf">http://dh.aks.ac.kr/ontologies/ekc#isSonInLawOf</seealso>
    let isSonInLawOf = Prefixed_Name(ekc, "isSonInLawOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isSonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSonOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isSonOf">http://dh.aks.ac.kr/ontologies/ekc#isSonOf</seealso>
    let isSonOf = Prefixed_Name(ekc, "isSonOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isSteleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSteleOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isSteleOf">http://dh.aks.ac.kr/ontologies/ekc#isSteleOf</seealso>
    let isSteleOf = Prefixed_Name(ekc, "isSteleOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isStoredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isStoredIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isStoredIn">http://dh.aks.ac.kr/ontologies/ekc#isStoredIn</seealso>
    let isStoredIn = Prefixed_Name(ekc, "isStoredIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isStupaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isStupaOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isStupaOf">http://dh.aks.ac.kr/ontologies/ekc#isStupaOf</seealso>
    let isStupaOf = Prefixed_Name(ekc, "isStupaOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isSubjectOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isSubjectOf">http://dh.aks.ac.kr/ontologies/ekc#isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(ekc, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isTombOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isTombOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isTombOf">http://dh.aks.ac.kr/ontologies/ekc#isTombOf</seealso>
    let isTombOf = Prefixed_Name(ekc, "isTombOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isTombstoneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isTombstoneOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isTombstoneOf">http://dh.aks.ac.kr/ontologies/ekc#isTombstoneOf</seealso>
    let isTombstoneOf = Prefixed_Name(ekc, "isTombstoneOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isTranslatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isTranslatorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isTranslatorOf">http://dh.aks.ac.kr/ontologies/ekc#isTranslatorOf</seealso>
    let isTranslatorOf = Prefixed_Name(ekc, "isTranslatorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isUsedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isUsedIn">http://dh.aks.ac.kr/ontologies/ekc#isUsedIn</seealso>
    let isUsedIn = Prefixed_Name(ekc, "isUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isVictimOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isVictimOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isVictimOf">http://dh.aks.ac.kr/ontologies/ekc#isVictimOf</seealso>
    let isVictimOf = Prefixed_Name(ekc, "isVictimOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isWifeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isWifeOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isWifeOf">http://dh.aks.ac.kr/ontologies/ekc#isWifeOf</seealso>
    let isWifeOf = Prefixed_Name(ekc, "isWifeOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isWornBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isWornBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isWornBy">http://dh.aks.ac.kr/ontologies/ekc#isWornBy</seealso>
    let isWornBy = Prefixed_Name(ekc, "isWornBy") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isWornIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isWornIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isWornIn">http://dh.aks.ac.kr/ontologies/ekc#isWornIn</seealso>
    let isWornIn = Prefixed_Name(ekc, "isWornIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:isWriterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isWriterOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#isWriterOf">http://dh.aks.ac.kr/ontologies/ekc#isWriterOf</seealso>
    let isWriterOf = Prefixed_Name(ekc, "isWriterOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:leads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"leads"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#leads">http://dh.aks.ac.kr/ontologies/ekc#leads</seealso>
    let leads = Prefixed_Name(ekc, "leads") |> PrefixedName
    /// <summary>
    ///   <para>ekc:livesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"livesIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#livesIn">http://dh.aks.ac.kr/ontologies/ekc#livesIn</seealso>
    let livesIn = Prefixed_Name(ekc, "livesIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mentions"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#mentions">http://dh.aks.ac.kr/ontologies/ekc#mentions</seealso>
    let mentions = Prefixed_Name(ekc, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>ekc:mightBeRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mightBeRelatedTo"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#mightBeRelatedTo">http://dh.aks.ac.kr/ontologies/ekc#mightBeRelatedTo</seealso>
    let mightBeRelatedTo = Prefixed_Name(ekc, "mightBeRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ekc:onlineReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"onlineReference"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#onlineReference">http://dh.aks.ac.kr/ontologies/ekc#onlineReference</seealso>
    let onlineReference = Prefixed_Name(ekc, "onlineReference") |> PrefixedName
    /// <summary>
    ///   <para>ekc:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owner"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#owner">http://dh.aks.ac.kr/ontologies/ekc#owner</seealso>
    let owner = Prefixed_Name(ekc, "owner") |> PrefixedName
    /// <summary>
    ///   <para>ekc:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"participatesIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#participatesIn">http://dh.aks.ac.kr/ontologies/ekc#participatesIn</seealso>
    let participatesIn = Prefixed_Name(ekc, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:plays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"plays"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#plays">http://dh.aks.ac.kr/ontologies/ekc#plays</seealso>
    let plays = Prefixed_Name(ekc, "plays") |> PrefixedName
    /// <summary>
    ///   <para>ekc:prepares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prepares"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#prepares">http://dh.aks.ac.kr/ontologies/ekc#prepares</seealso>
    let prepares = Prefixed_Name(ekc, "prepares") |> PrefixedName
    /// <summary>
    ///   <para>ekc:reconstructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reconstructor"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#reconstructor">http://dh.aks.ac.kr/ontologies/ekc#reconstructor</seealso>
    let reconstructor = Prefixed_Name(ekc, "reconstructor") |> PrefixedName
    /// <summary>
    ///   <para>ekc:renovator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"renovator"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#renovator">http://dh.aks.ac.kr/ontologies/ekc#renovator</seealso>
    let renovator = Prefixed_Name(ekc, "renovator") |> PrefixedName
    /// <summary>
    ///   <para>ekc:serves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"serves"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#serves">http://dh.aks.ac.kr/ontologies/ekc#serves</seealso>
    let serves = Prefixed_Name(ekc, "serves") |> PrefixedName
    /// <summary>
    ///   <para>ekc:servesAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"servesAs"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#servesAs">http://dh.aks.ac.kr/ontologies/ekc#servesAs</seealso>
    let servesAs = Prefixed_Name(ekc, "servesAs") |> PrefixedName
    /// <summary>
    ///   <para>ekc:servesTemporarilyAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"servesTemporarilyAs"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#servesTemporarilyAs">http://dh.aks.ac.kr/ontologies/ekc#servesTemporarilyAs</seealso>
    let servesTemporarilyAs = Prefixed_Name(ekc, "servesTemporarilyAs") |> PrefixedName
    /// <summary>
    ///   <para>ekc:textReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"textReference"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#textReference">http://dh.aks.ac.kr/ontologies/ekc#textReference</seealso>
    let textReference = Prefixed_Name(ekc, "textReference") |> PrefixedName
    /// <summary>
    ///   <para>ekc:timeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"timeline"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#timeline">http://dh.aks.ac.kr/ontologies/ekc#timeline</seealso>
    let timeline = Prefixed_Name(ekc, "timeline") |> PrefixedName
    /// <summary>
    ///   <para>ekc:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"translator"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#translator">http://dh.aks.ac.kr/ontologies/ekc#translator</seealso>
    let translator = Prefixed_Name(ekc, "translator") |> PrefixedName

    /// <summary>
    ///   <para>ekc:virtuallyParticipatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"virtuallyParticipatesIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#virtuallyParticipatesIn">http://dh.aks.ac.kr/ontologies/ekc#virtuallyParticipatesIn</seealso>
    let virtuallyParticipatesIn =
        Prefixed_Name(ekc, "virtuallyParticipatesIn") |> PrefixedName

    /// <summary>
    ///   <para>ekc:wasBuriedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasBuriedIn"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#wasBuriedIn">http://dh.aks.ac.kr/ontologies/ekc#wasBuriedIn</seealso>
    let wasBuriedIn = Prefixed_Name(ekc, "wasBuriedIn") |> PrefixedName
    /// <summary>
    ///   <para>ekc:wasExecutedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasExecutedAt"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#wasExecutedAt">http://dh.aks.ac.kr/ontologies/ekc#wasExecutedAt</seealso>
    let wasExecutedAt = Prefixed_Name(ekc, "wasExecutedAt") |> PrefixedName
    /// <summary>
    ///   <para>ekc:wasOrdainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasOrdainedBy"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#wasOrdainedBy">http://dh.aks.ac.kr/ontologies/ekc#wasOrdainedBy</seealso>
    let wasOrdainedBy = Prefixed_Name(ekc, "wasOrdainedBy") |> PrefixedName

    /// <summary>
    ///   <para>ekc:wasPosthumouslyPromotedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasPosthumouslyPromotedTo"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#wasPosthumouslyPromotedTo">http://dh.aks.ac.kr/ontologies/ekc#wasPosthumouslyPromotedTo</seealso>
    let wasPosthumouslyPromotedTo =
        Prefixed_Name(ekc, "wasPosthumouslyPromotedTo") |> PrefixedName

    /// <summary>
    ///   <para>ekc:wasPreceptorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasPreceptorOf"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#wasPreceptorOf">http://dh.aks.ac.kr/ontologies/ekc#wasPreceptorOf</seealso>
    let wasPreceptorOf = Prefixed_Name(ekc, "wasPreceptorOf") |> PrefixedName
    /// <summary>
    ///   <para>ekc:wears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wears"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#wears">http://dh.aks.ac.kr/ontologies/ekc#wears</seealso>
    let wears = Prefixed_Name(ekc, "wears") |> PrefixedName
    /// <summary>
    ///   <para>ekc:writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"writer"</para></remarks>
    /// <seealso href="http://dh.aks.ac.kr/ontologies/ekc#writer">http://dh.aks.ac.kr/ontologies/ekc#writer</seealso>
    let writer = Prefixed_Name(ekc, "writer") |> PrefixedName
