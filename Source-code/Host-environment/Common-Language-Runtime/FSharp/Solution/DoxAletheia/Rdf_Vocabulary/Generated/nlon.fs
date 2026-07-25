namespace http.lod.nl.go.kr.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nlon =
    let _namespace_iri = Namespace_Iri nlon |> NamespaceIRI
    /// <summary>
    ///   <para>nlon:AlternativeMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alternative material</para><para>장애인대체자료</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/AlternativeMaterial">http://lod.nl.go.kr/ontology/AlternativeMaterial</seealso>
    let AlternativeMaterial = Prefixed_Name(nlon, "AlternativeMaterial") |> PrefixedName

    /// <summary>
    ///   <para>nlon:citationReferenceNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이 필드는 자료의 서평 및 발행된 서지 기술에 대한 인용사항이나 참고문헌 주기를 기술하며 자료가 어디에서 인용되고, 서평 기사를 수록하고 있는지를 상술하는데 적용된다. 인용사항이나 참고문헌은 간략한 형태 즉, 일반적으로 인식할 수 있는 약자 등으로 기술된다. 실제 발행된 기술의 내용은 510 필드에 기술되지 않고, 520(요약 등 주기) 필드에 기술된다.
    ///
    /// 도서와 녹음자료의 경우, 자료의 출판된 기술사항(예, 간략하고 표준화된 형식으로 기술된 희귀자료 기술) 또는 서평(전문 저술에 관한 비평)에 대한 참고문헌을 주기한다.
    ///
    /// 연속간행물의 경우, 연속간행물에 대한 색인 또는 요약이 실린 출판물을 상술하고, 알 수 있을 때 수록 날짜 범위까지 상술하는데 적용된다. 참조된 색인과 초록 서비스는 주로 연속간행물로서 발행된 것들이다. 단행본 표제라 할지라도 어떤 주제 분야의 참고자료로 쓰이고, 연속간행물 형식은 아니지만 일정한 기간을 다룬다면 여기서 다룰 수 있다.
    ///
    /// 집합물로 다루어지는 인쇄물이 아닌 시청각자료나 그래픽 자료인 경우, 이 필드는 작품 또는 작품집에 대한 기술을 수록하고 있는 참고자료들을 기술한다.
    ///
    /// 복합자료의 경우, 기술된 자료의 초록, 인용, 기술, 색인을 수록한 참고문헌을 기술한다.</para>
    /// labels<para>citation reference note</para><para>인용 참고 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/citationReferenceNote">http://lod.nl.go.kr/ontology/citationReferenceNote</seealso>
    let citationReferenceNote =
        Prefixed_Name(nlon, "citationReferenceNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:classificationNumberOfLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>청구기호상의 분류기호를 기술한다.</para>
    /// labels<para>Library of Congress Call Number - Classification Number</para><para>미국국회도서관 청구기호 분류기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/classificationNumberOfLC">http://lod.nl.go.kr/ontology/classificationNumberOfLC</seealso>
    let classificationNumberOfLC =
        Prefixed_Name(nlon, "classificationNumberOfLC") |> PrefixedName

    /// <summary>
    ///   <para>nlon:classificationNumberOfNLK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>국립중앙도서관 청구기호상의 분류기호를 기술한다. 적용 분류표는 KDC, DDC, KDCP, 조선총독부 신서부·양서부·고서부분류표 등이 있다. 여기에 기술된 분류기호는 분류기호 검색을 위하여 적용분류표에 해당하는 분류기호 필드(KDC는 056, DDC는 082, 그 외는 085)에 다시 기술한다.</para>
    /// labels<para>National Library of Korea Call Number - Classification Number</para><para>국립중앙도서관 청구기호 분류기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/classificationNumberOfNLK">http://lod.nl.go.kr/ontology/classificationNumberOfNLK</seealso>
    let classificationNumberOfNLK =
        Prefixed_Name(nlon, "classificationNumberOfNLK") |> PrefixedName

    /// <summary>
    ///   <para>nlon:confirmDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>confirm date</para><para>확인 날짜</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/confirmDate">http://lod.nl.go.kr/ontology/confirmDate</seealso>
    let confirmDate = Prefixed_Name(nlon, "confirmDate") |> PrefixedName
    /// <summary>
    ///   <para>nlon:confirmedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>confirmed by</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/confirmedBy">http://lod.nl.go.kr/ontology/confirmedBy</seealso>
    let confirmedBy = Prefixed_Name(nlon, "confirmedBy") |> PrefixedName
    /// <summary>
    ///   <para>nlon:distributionPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>배포지</para>
    /// labels<para>distribution place</para><para>배포지</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/distributionPlace">http://lod.nl.go.kr/ontology/distributionPlace</seealso>
    let distributionPlace = Prefixed_Name(nlon, "distributionPlace") |> PrefixedName
    /// <summary>
    ///   <para>nlon:distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>배포처</para>
    /// labels<para>distributor</para><para>배포처</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/distributor">http://lod.nl.go.kr/ontology/distributor</seealso>
    let distributor = Prefixed_Name(nlon, "distributor") |> PrefixedName

    /// <summary>
    ///   <para>nlon:headingOfOriginalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    /// labels<para>heading of original language</para><para>원저 기본표목</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/headingOfOriginalLanguage">http://lod.nl.go.kr/ontology/headingOfOriginalLanguage</seealso>
    let headingOfOriginalLanguage =
        Prefixed_Name(nlon, "headingOfOriginalLanguage") |> PrefixedName

    /// <summary>
    ///   <para>nlon:holdingItemNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>해당기관 소장본의 낙장(落張), 배접(褙接), 보사(補寫), 인문(印文), 장서기(藏書記), 지어(識語), 묵서(墨書)나 열람용 복제본 여부, 소장 원본·복제본의 청구기호 등 소장본 관련 로컬정보를 기술한다.</para>
    /// labels<para>holding item note</para><para>소장본 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/holdingItemNote">http://lod.nl.go.kr/ontology/holdingItemNote</seealso>
    let holdingItemNote = Prefixed_Name(nlon, "holdingItemNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:inputDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>input date</para><para>입력 날짜</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/inputDate">http://lod.nl.go.kr/ontology/inputDate</seealso>
    let inputDate = Prefixed_Name(nlon, "inputDate") |> PrefixedName
    /// <summary>
    ///   <para>nlon:inputedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inputed by</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/inputedBy">http://lod.nl.go.kr/ontology/inputedBy</seealso>
    let inputedBy = Prefixed_Name(nlon, "inputedBy") |> PrefixedName
    /// <summary>
    ///   <para>nlon:isClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>is closed</para><para>폐관여부</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/isClosed">http://lod.nl.go.kr/ontology/isClosed</seealso>
    let isClosed = Prefixed_Name(nlon, "isClosed") |> PrefixedName
    /// <summary>
    ///   <para>nlon:isGeographicAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>7자리의 지역구분부호를 기술한다. 해당 자료와 관련된 지역구분부호가 둘 이상일 경우에는 식별기호를 반복하여 기술한다.</para>
    /// labels<para>is geographic area of</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/isGeographicAreaOf">http://lod.nl.go.kr/ontology/isGeographicAreaOf</seealso>
    let isGeographicAreaOf = Prefixed_Name(nlon, "isGeographicAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>nlon:issuingBodyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>발행처주기에 관한 사항을 기술한다.</para>
    /// labels<para>issuing body note</para><para>발행처주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/issuingBodyNote">http://lod.nl.go.kr/ontology/issuingBodyNote</seealso>
    let issuingBodyNote = Prefixed_Name(nlon, "issuingBodyNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:itemNumberOfDDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>청구기호 중 도서기호를 기술한다. 이 식별기호에는 자료(또는 세트) 기호를 기술할 수도 있다.</para>
    /// labels<para>item number of DDC</para><para>듀이십진분류기호 도서기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/itemNumberOfDDC">http://lod.nl.go.kr/ontology/itemNumberOfDDC</seealso>
    let itemNumberOfDDC = Prefixed_Name(nlon, "itemNumberOfDDC") |> PrefixedName
    /// <summary>
    ///   <para>nlon:itemNumberOfLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>청구기호상의 도서기호를 기술한다.</para>
    /// labels<para>item number of LC</para><para>미국국회도서관 청구기호 도서기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/itemNumberOfLC">http://lod.nl.go.kr/ontology/itemNumberOfLC</seealso>
    let itemNumberOfLC = Prefixed_Name(nlon, "itemNumberOfLC") |> PrefixedName
    /// <summary>
    ///   <para>nlon:itemNumberOfNLK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>국립중앙도서관 청구기호상의 도서기호를 기술한다. 적용 도서기호는 국립중앙도서관 동양서 저자기호표, 카터-샌본저자기호표(Cutter-Sanborn Three-Author Table), 수입순기호 등이 있다.</para>
    /// labels<para>item number of NLK</para><para>국립중앙도서관 청구기호 도서기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/itemNumberOfNLK">http://lod.nl.go.kr/ontology/itemNumberOfNLK</seealso>
    let itemNumberOfNLK = Prefixed_Name(nlon, "itemNumberOfNLK") |> PrefixedName
    /// <summary>
    ///   <para>nlon:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>This specification describes National Library of Korea Ontology vocaburaries using W3C's RDF and OWL technology.</para>
    /// </remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/">http://lod.nl.go.kr/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(nlon, "") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Archives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Archives</para><para>해외수집기록물</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Archives">http://lod.nl.go.kr/ontology/Archives</seealso>
    let Archives = Prefixed_Name(nlon, "Archives") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Book</para><para>도서</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Book">http://lod.nl.go.kr/ontology/Book</seealso>
    let Book = Prefixed_Name(nlon, "Book") |> PrefixedName
    /// <summary>
    ///   <para>nlon:dateOfManufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>제작년 또는 인쇄년을 기술한다. 발행년 식별기호인 ▾c에 제작년 또는 인쇄년을 기술한 경우에는 식별기호 ▾g에는 기술하지 않는다.</para>
    /// labels<para>date of manufacture</para><para>제작년</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfManufacture">http://lod.nl.go.kr/ontology/dateOfManufacture</seealso>
    let dateOfManufacture = Prefixed_Name(nlon, "dateOfManufacture") |> PrefixedName
    /// <summary>
    ///   <para>nlon:dateOfOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date of opening</para><para>개관일</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfOpening">http://lod.nl.go.kr/ontology/dateOfOpening</seealso>
    let dateOfOpening = Prefixed_Name(nlon, "dateOfOpening") |> PrefixedName

    /// <summary>
    ///   <para>nlon:dateSequentialDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>기술되는 변경 전 표제와 관련된 권·연차를 기술한다.</para>
    /// labels<para>date sequential designation</para><para>표제변동 권연차표시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateSequentialDesignation">http://lod.nl.go.kr/ontology/dateSequentialDesignation</seealso>
    let dateSequentialDesignation =
        Prefixed_Name(nlon, "dateSequentialDesignation") |> PrefixedName

    /// <summary>
    ///   <para>nlon:ddc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>듀이십진분류기호를 기술한다. 동일자료에 둘 이상의 분류기호가 부여된 경우에는 청구기호를 구성하는 식별기호(첫번째 ▾a 및 ▾b) 뒤에 ▾a를 반복하여 두 번째 이하 분류기호를 기술한다.</para>
    /// labels<para>Dewey Decimal Classification Number</para><para>듀이십진분류기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/ddc">http://lod.nl.go.kr/ontology/ddc</seealso>
    let ddc = Prefixed_Name(nlon, "ddc") |> PrefixedName
    /// <summary>
    ///   <para>nlon:deathYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>몰년</para>
    /// labels<para>death year</para><para>사망연도</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/deathYear">http://lod.nl.go.kr/ontology/deathYear</seealso>
    let deathYear = Prefixed_Name(nlon, "deathYear") |> PrefixedName
    /// <summary>
    ///   <para>nlon:department</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>논문에 나타나 있는 학과 또는 전공을 기술한다.</para>
    /// labels<para>department</para><para>학과, 전공</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/department">http://lod.nl.go.kr/ontology/department</seealso>
    let department = Prefixed_Name(nlon, "department") |> PrefixedName
    /// <summary>
    ///   <para>nlon:managedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>managed by</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/managedBy">http://lod.nl.go.kr/ontology/managedBy</seealso>
    let managedBy = Prefixed_Name(nlon, "managedBy") |> PrefixedName

    /// <summary>
    ///   <para>nlon:currentPublicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>현행 출판물의 간행빈도를 기술한다.</para>
    /// labels<para>current publication frequency</para><para>현재 간행빈도</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/currentPublicationFrequency">http://lod.nl.go.kr/ontology/currentPublicationFrequency</seealso>
    let currentPublicationFrequency =
        Prefixed_Name(nlon, "currentPublicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>nlon:dateLinked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date linked</para><para>링크 생성 일시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateLinked">http://lod.nl.go.kr/ontology/dateLinked</seealso>
    let dateLinked = Prefixed_Name(nlon, "dateLinked") |> PrefixedName
    /// <summary>
    ///   <para>nlon:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>생산처</para>
    /// labels<para>producer</para><para>생산처</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/producer">http://lod.nl.go.kr/ontology/producer</seealso>
    let producer = Prefixed_Name(nlon, "producer") |> PrefixedName
    /// <summary>
    ///   <para>nlon:projection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>전체 도법표시를 기술한다. ISBD의 원칙에 따라 ▾b는 쌍반점(;)을 앞세워 기술한다.</para>
    /// labels<para>projection</para><para>도법</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/projection">http://lod.nl.go.kr/ontology/projection</seealso>
    let projection = Prefixed_Name(nlon, "projection") |> PrefixedName
    /// <summary>
    ///   <para>nlon:publish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>publish</para><para>발행</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/publish">http://lod.nl.go.kr/ontology/publish</seealso>
    let publish = Prefixed_Name(nlon, "publish") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>author</para><para>저자</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Author">http://lod.nl.go.kr/ontology/Author</seealso>
    let Author = Prefixed_Name(nlon, "Author") |> PrefixedName
    /// <summary>
    ///   <para>nlon:create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>create</para><para>저작하다</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/create">http://lod.nl.go.kr/ontology/create</seealso>
    let create = Prefixed_Name(nlon, "create") |> PrefixedName
    /// <summary>
    ///   <para>nlon:dateOfClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date of closed</para><para>휴관일</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfClosed">http://lod.nl.go.kr/ontology/dateOfClosed</seealso>
    let dateOfClosed = Prefixed_Name(nlon, "dateOfClosed") |> PrefixedName

    /// <summary>
    ///   <para>nlon:dateOfCurrentPublicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>현재 간행빈도가 창간호의 간행빈도와 같지 않을 경우 현재 간행빈도 시작 연·월을 기술한다. 이전의 간행빈도는 321 필드에 기술한다.</para>
    /// labels<para>date of current publication frequency</para><para>현재 간행빈도 시작 연월</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfCurrentPublicationFrequency">http://lod.nl.go.kr/ontology/dateOfCurrentPublicationFrequency</seealso>
    let dateOfCurrentPublicationFrequency =
        Prefixed_Name(nlon, "dateOfCurrentPublicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>nlon:dateOfFormerPublicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이전의 간행빈도에 해당하는 연·월을 기술한다.</para>
    /// labels<para>date of former publication frequency</para><para>이전 간행빈도 시행 연월</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfFormerPublicationFrequency">http://lod.nl.go.kr/ontology/dateOfFormerPublicationFrequency</seealso>
    let dateOfFormerPublicationFrequency =
        Prefixed_Name(nlon, "dateOfFormerPublicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>nlon:reproductionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>해당자료가 영인, 복사, 마이크로형태 등에 의한 복제물이고 그 원본을 중심으로 서지정보를 기술한 경우, 복제에 관한 사항을 기술한다.
    ///
    /// 이 필드에는 원본이 복제된 사항을 기술한다. 서지 레코드를 원본을 중심으로 기술하고 복제와 관련된 정보는 533 필드에 주기로 기술한다. 목록작성기관에서 기술부에 원본을 반영할 것을 선택한 경우, 복제본에 관한 정보를 반영하는 데 사용된다.
    ///
    /// 복합 자료의 경우, 기관에서 복제물만을 소장할 때, 이 필드에는 복제된 기록물 단위로 기술하고 기술부는 관례에 따라 원본을 기준으로 작성한다. 이 필드는 보통 원본을 소장하고 있는 기관을 나타내는 535(원본/복제본 소재주기) 필드와 관련하여 사용한다.</para>
    /// labels<para>reproduction note</para><para>복제주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/reproductionNote">http://lod.nl.go.kr/ontology/reproductionNote</seealso>
    let reproductionNote = Prefixed_Name(nlon, "reproductionNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:reproductionInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>복제기관을 기술한다. 만약에 동일한 복제물에 대하여 복제기관이 하나 이상일 경우 반복하여 기술할 수 있다.</para>
    /// labels<para>reproduction institution</para><para>복제기관</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/reproductionInstitution">http://lod.nl.go.kr/ontology/reproductionInstitution</seealso>
    let reproductionInstitution =
        Prefixed_Name(nlon, "reproductionInstitution") |> PrefixedName

    /// <summary>
    ///   <para>nlon:reproductionPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>복제물이 만들어진 장소의 명칭을 기술한다. 복제장소가 한 곳 이상일 때에는 반복하여 기술할 수 있다.</para>
    /// labels<para>reproduction place</para><para>복제장소</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/reproductionPlace">http://lod.nl.go.kr/ontology/reproductionPlace</seealso>
    let reproductionPlace = Prefixed_Name(nlon, "reproductionPlace") |> PrefixedName
    /// <summary>
    ///   <para>nlon:scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>축척이나 그에 상당하는 축척내용을 기술한다. 수직축척이나 지형모형 또는 다른 삼차원자료의 수직확장표시도 이 식별기호에 기술한다.</para>
    /// labels<para>scale</para><para>축척</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/scale">http://lod.nl.go.kr/ontology/scale</seealso>
    let scale = Prefixed_Name(nlon, "scale") |> PrefixedName
    /// <summary>
    ///   <para>nlon:sourceOfInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>창간호나 종간호를 소장하지 않아 권·연차를 다른 정보원으로부터 채기한 경우 (제1지시기호가 1) 그 정보원을 참조(Cf.)와 함께 기술한다.</para>
    /// labels<para>source of information</para><para>확인자료명</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/sourceOfInformation">http://lod.nl.go.kr/ontology/sourceOfInformation</seealso>
    let sourceOfInformation = Prefixed_Name(nlon, "sourceOfInformation") |> PrefixedName
    /// <summary>
    ///   <para>nlon:sourceOfOtherNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾a(분류기호)의 적용 분류표와 판표시를 분류기호 뒤에 기술하되, 분류표는 제1지시기호가 b/(그 외의 분류표)인 경우에만 기술한다. 적용된 분류표의 판이 달라 발생하는 2개 이상의 분류기호의 경우에는 필드를 반복하여 기술하는 것이 바람직하다.</para>
    /// labels<para>source of other number</para><para>분류기호 정보원</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/sourceOfOtherNumber">http://lod.nl.go.kr/ontology/sourceOfOtherNumber</seealso>
    let sourceOfOtherNumber = Prefixed_Name(nlon, "sourceOfOtherNumber") |> PrefixedName
    /// <summary>
    ///   <para>nlon:strn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>해당자료의 표준기술보고서번호를 기술한다.</para>
    /// labels<para>Standard Technical Report Number</para><para>표준기술보고서번호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/strn">http://lod.nl.go.kr/ontology/strn</seealso>
    let strn = Prefixed_Name(nlon, "strn") |> PrefixedName

    /// <summary>
    ///   <para>nlon:subseriesEntryHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    /// labels<para>subseries entry heading</para><para>하위총서저록 기본표목</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/subseriesEntryHeading">http://lod.nl.go.kr/ontology/subseriesEntryHeading</seealso>
    let subseriesEntryHeading =
        Prefixed_Name(nlon, "subseriesEntryHeading") |> PrefixedName

    /// <summary>
    ///   <para>nlon:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>subtitle</para><para>부제목</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/subtitle">http://lod.nl.go.kr/ontology/subtitle</seealso>
    let subtitle = Prefixed_Name(nlon, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>nlon:summerOpenTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>summer open time</para><para>하절기 개관시간</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/summerOpenTime">http://lod.nl.go.kr/ontology/summerOpenTime</seealso>
    let summerOpenTime = Prefixed_Name(nlon, "summerOpenTime") |> PrefixedName
    /// <summary>
    ///   <para>nlon:supplementNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>부록주기를 기술한다. 식별기호 ▾a는 이 주기의 전체 내용을 기술한다.</para>
    /// labels<para>supplement note</para><para>부록주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/supplementNote">http://lod.nl.go.kr/ontology/supplementNote</seealso>
    let supplementNote = Prefixed_Name(nlon, "supplementNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:birthYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>생년</para>
    /// labels<para>birth year</para><para>출생연도</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/birthYear">http://lod.nl.go.kr/ontology/birthYear</seealso>
    let birthYear = Prefixed_Name(nlon, "birthYear") |> PrefixedName
    /// <summary>
    ///   <para>nlon:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>제작처</para>
    /// labels<para>manufacturer</para><para>제작처</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/manufacturer">http://lod.nl.go.kr/ontology/manufacturer</seealso>
    let manufacturer = Prefixed_Name(nlon, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>nlon:OfflineMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Offline material</para><para>오프라인 자료</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/OfflineMaterial">http://lod.nl.go.kr/ontology/OfflineMaterial</seealso>
    let OfflineMaterial = Prefixed_Name(nlon, "OfflineMaterial") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Country</para><para>국가</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Country">http://lod.nl.go.kr/ontology/Country</seealso>
    let Country = Prefixed_Name(nlon, "Country") |> PrefixedName
    /// <summary>
    ///   <para>nlon:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>공통 대상에서 사용하는 자료 구분 부가정보</para>
    /// labels<para>Data type</para><para>자료구분</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/DataType">http://lod.nl.go.kr/ontology/DataType</seealso>
    let DataType = Prefixed_Name(nlon, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfHostItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of host item</para><para>기본자료저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfHostItem">http://lod.nl.go.kr/ontology/titleOfHostItem</seealso>
    let titleOfHostItem = Prefixed_Name(nlon, "titleOfHostItem") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfPreceding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of preceding</para><para>선행저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfPreceding">http://lod.nl.go.kr/ontology/titleOfPreceding</seealso>
    let titleOfPreceding = Prefixed_Name(nlon, "titleOfPreceding") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfSubSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of sub series</para><para>하위총서표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfSubSeries">http://lod.nl.go.kr/ontology/titleOfSubSeries</seealso>
    let titleOfSubSeries = Prefixed_Name(nlon, "titleOfSubSeries") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfSucceeding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of succeeding</para><para>후속저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfSucceeding">http://lod.nl.go.kr/ontology/titleOfSucceeding</seealso>
    let titleOfSucceeding = Prefixed_Name(nlon, "titleOfSucceeding") |> PrefixedName

    /// <summary>
    ///   <para>nlon:titleOfSupplementParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of supplement parent</para><para>모체레코드저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfSupplementParent">http://lod.nl.go.kr/ontology/titleOfSupplementParent</seealso>
    let titleOfSupplementParent =
        Prefixed_Name(nlon, "titleOfSupplementParent") |> PrefixedName

    /// <summary>
    ///   <para>nlon:typeOfContinuousData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type of continuous data</para><para>연속자료유형</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/typeOfContinuousData">http://lod.nl.go.kr/ontology/typeOfContinuousData</seealso>
    let typeOfContinuousData =
        Prefixed_Name(nlon, "typeOfContinuousData") |> PrefixedName

    /// <summary>
    ///   <para>nlon:typeOfPublicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type of publication frequency</para><para>간행빈도유형</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/typeOfPublicationFrequency">http://lod.nl.go.kr/ontology/typeOfPublicationFrequency</seealso>
    let typeOfPublicationFrequency =
        Prefixed_Name(nlon, "typeOfPublicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>nlon:typeOfPublicationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type of publication status</para><para>간행상태유형</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/typeOfPublicationStatus">http://lod.nl.go.kr/ontology/typeOfPublicationStatus</seealso>
    let typeOfPublicationStatus =
        Prefixed_Name(nlon, "typeOfPublicationStatus") |> PrefixedName

    /// <summary>
    ///   <para>nlon:typeOfResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type of resource</para><para>콘텐츠유형</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/typeOfResource">http://lod.nl.go.kr/ontology/typeOfResource</seealso>
    let typeOfResource = Prefixed_Name(nlon, "typeOfResource") |> PrefixedName

    /// <summary>
    ///   <para>nlon:uniformTitleOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이 필드는 총서의 부출표목이 서명일 경우를 나타낸다. 830 필드는 보통 총서와 관련된 필드 490 필드의 총서사항이나 500 필드의 일반주기로 판단될 수 있다. 복제물의 경우 533(복제주기) 필드의 ▾f(복제 총서사항)에 기술된 것을 근거로 기술할 수 있다.</para>
    /// labels<para>uniform title of series</para><para>통일표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/uniformTitleOfSeries">http://lod.nl.go.kr/ontology/uniformTitleOfSeries</seealso>
    let uniformTitleOfSeries =
        Prefixed_Name(nlon, "uniformTitleOfSeries") |> PrefixedName

    /// <summary>
    ///   <para>nlon:volumeOfNLK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>국립중앙도서관 청구기호상의 권·연차기호를 기술한다. 권·연차가 연속된 경우에는 처음 권·연차와 마지막 권·연차를 붙임표( - )로 연결한다. 단, 현재 계속 간행중인 경우에는 처음 권·연차 뒤에 붙임표( - )까지만 입력한다</para>
    /// labels<para>국립중앙도서관 청구기호 권연차기호</para><para>volume of NLK</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/volumeOfNLK">http://lod.nl.go.kr/ontology/volumeOfNLK</seealso>
    let volumeOfNLK = Prefixed_Name(nlon, "volumeOfNLK") |> PrefixedName
    /// <summary>
    ///   <para>nlon:volumeOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>총서에 주어진 권차 또는 차례를 나타내는 명칭을 기술한다.</para>
    /// labels<para>volume of series</para><para>총서번호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/volumeOfSeries">http://lod.nl.go.kr/ontology/volumeOfSeries</seealso>
    let volumeOfSeries = Prefixed_Name(nlon, "volumeOfSeries") |> PrefixedName
    /// <summary>
    ///   <para>nlon:winterOpenTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>winter open time</para><para>동절기 개관시간</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/winterOpenTime">http://lod.nl.go.kr/ontology/winterOpenTime</seealso>
    let winterOpenTime = Prefixed_Name(nlon, "winterOpenTime") |> PrefixedName
    /// <summary>
    ///   <para>nlon:modificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>modification date</para><para>수정 날짜</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/modificationDate">http://lod.nl.go.kr/ontology/modificationDate</seealso>
    let modificationDate = Prefixed_Name(nlon, "modificationDate") |> PrefixedName
    /// <summary>
    ///   <para>nlon:municipalLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>municipal level</para><para>시군구 레벨</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/municipalLevel">http://lod.nl.go.kr/ontology/municipalLevel</seealso>
    let municipalLevel = Prefixed_Name(nlon, "municipalLevel") |> PrefixedName

    /// <summary>
    ///   <para>nlon:numberingPeculiaritiesNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾a는 특수하거나 예외적인 권차를 기술한다. 식별기호 ▾a 아래 기술하는 특수하거나 예외적인 권차의 유형들은 다음과 같다.</para>
    /// labels<para>numbering peculiarities note</para><para>특수한 권차표시주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/numberingPeculiaritiesNote">http://lod.nl.go.kr/ontology/numberingPeculiaritiesNote</seealso>
    let numberingPeculiaritiesNote =
        Prefixed_Name(nlon, "numberingPeculiaritiesNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:originalVersionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>해당자료가 영인, 복사, 마이크로형태 등에 의한 복제물이고 복제본을 중심으로 서지정보를 기술한 경우, 그 원본에 관한 사항을 기술한다.</para>
    /// labels<para>original version note</para><para>원본주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/originalVersionNote">http://lod.nl.go.kr/ontology/originalVersionNote</seealso>
    let originalVersionNote = Prefixed_Name(nlon, "originalVersionNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:dateOfDistribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>배포년</para>
    /// labels<para>date of distribute</para><para>배포년</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfDistribute">http://lod.nl.go.kr/ontology/dateOfDistribute</seealso>
    let dateOfDistribute = Prefixed_Name(nlon, "dateOfDistribute") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Classification</para><para>분류</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Classification">http://lod.nl.go.kr/ontology/Classification</seealso>
    let Classification = Prefixed_Name(nlon, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Concept">http://lod.nl.go.kr/ontology/Concept</seealso>
    let Concept = Prefixed_Name(nlon, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>nlon:editionOfDDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>분류에 적용한 DDC분류표의 판을 분류기호 뒤에 기술한다. 한 자료에 하나 이상의 분류기호가 서로 판이 다른 경우, 필드를 반복하여 독립된 필드에 기술한다.</para>
    /// labels<para>edition of DDC</para><para>듀이십진분류기호 판표시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/editionOfDDC">http://lod.nl.go.kr/ontology/editionOfDDC</seealso>
    let editionOfDDC = Prefixed_Name(nlon, "editionOfDDC") |> PrefixedName
    /// <summary>
    ///   <para>nlon:editionOfKDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>분류에 적용한 KDC분류표의 판을 분류기호 뒤에 기술한다. 적용된 분류표의 판이 달라 발생하는 2개 이상의 분류기호의 경우에는 056 필드를 반복하여 기술한다.</para>
    /// labels<para>edition of KDC</para><para>한국십진분류기호 판표시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/editionOfKDC">http://lod.nl.go.kr/ontology/editionOfKDC</seealso>
    let editionOfKDC = Prefixed_Name(nlon, "editionOfKDC") |> PrefixedName

    /// <summary>
    ///   <para>nlon:titleOfAdditionalPhysicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of additional physical form</para><para>기타형태저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfAdditionalPhysicalForm">http://lod.nl.go.kr/ontology/titleOfAdditionalPhysicalForm</seealso>
    let titleOfAdditionalPhysicalForm =
        Prefixed_Name(nlon, "titleOfAdditionalPhysicalForm") |> PrefixedName

    /// <summary>
    ///   <para>nlon:titleOfConstituentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of constituent unit</para><para>구성단위저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfConstituentUnit">http://lod.nl.go.kr/ontology/titleOfConstituentUnit</seealso>
    let titleOfConstituentUnit =
        Prefixed_Name(nlon, "titleOfConstituentUnit") |> PrefixedName

    /// <summary>
    ///   <para>nlon:titleOfMainSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of main series</para><para>상위총서표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfMainSeries">http://lod.nl.go.kr/ontology/titleOfMainSeries</seealso>
    let titleOfMainSeries = Prefixed_Name(nlon, "titleOfMainSeries") |> PrefixedName

    /// <summary>
    ///   <para>nlon:titleOfOriginalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of original language</para><para>원저표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfOriginalLanguage">http://lod.nl.go.kr/ontology/titleOfOriginalLanguage</seealso>
    let titleOfOriginalLanguage =
        Prefixed_Name(nlon, "titleOfOriginalLanguage") |> PrefixedName

    /// <summary>
    ///   <para>nlon:titleOfOtherEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of other edition</para><para>이판저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfOtherEdition">http://lod.nl.go.kr/ontology/titleOfOtherEdition</seealso>
    let titleOfOtherEdition = Prefixed_Name(nlon, "titleOfOtherEdition") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이 필드에는 총서사항과 총서표제의 부출표목이 같은 경우에 총서사항을 기술한다. 이 필드는 총서사항이자 총서부출표목이다. 440 필드가 있는 경우, 이에 대응하는 830 필드는 440 필드와 중복되기 때문에 사용되지 않는다.
    ///
    /// 총서사항은 매체 표시(식별기호 ▾h)를 포함하지 않으므로, 총서부출표목에 매체 표시가 필요한 경우, 490 필드가 총서부출표목에 대응하는 8XX 필드와 함께 총서사항에 사용된다.</para>
    /// labels<para>title of series</para><para>총서표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfSeries">http://lod.nl.go.kr/ontology/titleOfSeries</seealso>
    let titleOfSeries = Prefixed_Name(nlon, "titleOfSeries") |> PrefixedName
    /// <summary>
    ///   <para>nlon:ComplexDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Complex document</para><para>복합자료</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/ComplexDocument">http://lod.nl.go.kr/ontology/ComplexDocument</seealso>
    let ComplexDocument = Prefixed_Name(nlon, "ComplexDocument") |> PrefixedName
    /// <summary>
    ///   <para>nlon:restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>자료를 이용하는데 제한이 있는 경우, 그 접근제한에 관한 내용을 기술한다. 출판된 저작의 경우, 이 필드에 배포 제한사항에 대한 정보를 기술한다.
    ///
    /// 출판물에 접근하는 것을 제한한다는 의미가 아니라 출판물이 특정 이용자층을 대상으로 만들어졌을 경우, 이는 521(이용대상자 주기) 필드에 기술한다. 자료를 접근한 이후 자료를 이용하거나 복제하는 데 대한 제한 내용은 540(이용과 복제 제한에 관한 주기) 필드에 기술한다.
    ///
    /// 계속자료(serial)의 경우에는 모든 호수에 대해 제한이 적용되는 경우 사용한다</para>
    /// labels<para>restriction</para><para>이용제한사항</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/restriction">http://lod.nl.go.kr/ontology/restriction</seealso>
    let restriction = Prefixed_Name(nlon, "restriction") |> PrefixedName
    /// <summary>
    ///   <para>nlon:ContinuousDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>연속간행물에서 사용하는 연속자료 구분 부가정보</para>
    /// labels<para>Continuous data type</para><para>연속자료구분</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/ContinuousDataType">http://lod.nl.go.kr/ontology/ContinuousDataType</seealso>
    let ContinuousDataType = Prefixed_Name(nlon, "ContinuousDataType") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Government</para><para>정부기관</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Government">http://lod.nl.go.kr/ontology/Government</seealso>
    let Government = Prefixed_Name(nlon, "Government") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Librarian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>librarian</para><para>사서</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Librarian">http://lod.nl.go.kr/ontology/Librarian</seealso>
    let Librarian = Prefixed_Name(nlon, "Librarian") |> PrefixedName

    /// <summary>
    ///   <para>nlon:formerPublicationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이전 간행빈도를 기술한다.</para>
    /// labels<para>former publication frequency</para><para>이전 간행빈도</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/formerPublicationFrequency">http://lod.nl.go.kr/ontology/formerPublicationFrequency</seealso>
    let formerPublicationFrequency =
        Prefixed_Name(nlon, "formerPublicationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>nlon:formerTitleComplexityNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>변경전 표제 설명주기에 관한 사항을 기술한다.</para>
    /// labels<para>former title complexity note</para><para>변경전 표제 설명주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/formerTitleComplexityNote">http://lod.nl.go.kr/ontology/formerTitleComplexityNote</seealso>
    let formerTitleComplexityNote =
        Prefixed_Name(nlon, "formerTitleComplexityNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>genre</para><para>장르</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/genre">http://lod.nl.go.kr/ontology/genre</seealso>
    let genre = Prefixed_Name(nlon, "genre") |> PrefixedName
    /// <summary>
    ///   <para>nlon:exhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>전시내용을 기술한다.</para>
    /// labels<para>exhibition</para><para>전시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/exhibition">http://lod.nl.go.kr/ontology/exhibition</seealso>
    let exhibition = Prefixed_Name(nlon, "exhibition") |> PrefixedName
    /// <summary>
    ///   <para>nlon:formerTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>권차 또는 권차명 표시를 제외한 본표제, 별표제 또는 관제를 포함하는 본표제를 기술한다. 본표제가 반복되는 경우에는 식별기호(▾a)를 반복한다. 두 번째 이하의 식별기호(▾a)는 245 필드에서 직접 부출 되지 않고 740 필드에 자동생성을 위한 용도로 사용된다. 또한 이 식별기호에는 종합 표제가 없는 집서의 경우, 독립된 저작의 첫 번째 표제(동일하거나 다른 저자/작곡가)를 기술한다.</para>
    /// labels<para>former title</para><para>변경전 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/formerTitle">http://lod.nl.go.kr/ontology/formerTitle</seealso>
    let formerTitle = Prefixed_Name(nlon, "formerTitle") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfSupplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of supplement</para><para>보유판 및 특별호저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfSupplement">http://lod.nl.go.kr/ontology/titleOfSupplement</seealso>
    let titleOfSupplement = Prefixed_Name(nlon, "titleOfSupplement") |> PrefixedName
    /// <summary>
    ///   <para>nlon:titleOfTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    /// labels<para>title of translation</para><para>번역저록 표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/titleOfTranslation">http://lod.nl.go.kr/ontology/titleOfTranslation</seealso>
    let titleOfTranslation = Prefixed_Name(nlon, "titleOfTranslation") |> PrefixedName
    /// <summary>
    ///   <para>nlon:typeOfData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type of data</para><para>자료유형</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/typeOfData">http://lod.nl.go.kr/ontology/typeOfData</seealso>
    let typeOfData = Prefixed_Name(nlon, "typeOfData") |> PrefixedName
    /// <summary>
    ///   <para>nlon:ElectronicDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Electronic document</para><para>전자자료</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/ElectronicDocument">http://lod.nl.go.kr/ontology/ElectronicDocument</seealso>
    let ElectronicDocument = Prefixed_Name(nlon, "ElectronicDocument") |> PrefixedName
    /// <summary>
    ///   <para>nlon:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>지역</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Location">http://lod.nl.go.kr/ontology/Location</seealso>
    let Location = Prefixed_Name(nlon, "Location") |> PrefixedName
    /// <summary>
    ///   <para>nlon:NonBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Non book</para><para>비도서</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/NonBook">http://lod.nl.go.kr/ontology/NonBook</seealso>
    let NonBook = Prefixed_Name(nlon, "NonBook") |> PrefixedName
    /// <summary>
    ///   <para>nlon:uci</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>한국형 URN 식별 체계</para>
    /// labels<para>Universal Content Identifier</para><para>국가디지털콘텐츠식별체계</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/uci">http://lod.nl.go.kr/ontology/uci</seealso>
    let uci = Prefixed_Name(nlon, "uci") |> PrefixedName

    /// <summary>
    ///   <para>nlon:useAndReproductionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이용과 복제에 관한 사항을 기술한다. 이 사항은 법적인 효력을 가지고 있거나 공식적인 제한규정을 의미하는 것이다.</para>
    /// labels<para>use and reproduction note</para><para>이용과 복제 제한에 관한 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/useAndReproductionNote">http://lod.nl.go.kr/ontology/useAndReproductionNote</seealso>
    let useAndReproductionNote =
        Prefixed_Name(nlon, "useAndReproductionNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Library</para><para>도서관</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Library">http://lod.nl.go.kr/ontology/Library</seealso>
    let Library = Prefixed_Name(nlon, "Library") |> PrefixedName
    /// <summary>
    ///   <para>nlon:gpo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>GPO자료번호를 기술한다. 마이크로필름인 경우에는 GPO자료번호 뒤에 "MF"를 원괄호로 묶어 기술한다.</para>
    /// labels<para>미국정부간행물번호</para><para>gpo</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/gpo">http://lod.nl.go.kr/ontology/gpo</seealso>
    let gpo = Prefixed_Name(nlon, "gpo") |> PrefixedName
    /// <summary>
    ///   <para>nlon:gprn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>한국정부간행물 발간등록번호(GPRN: Government Publications Registration Number)를 기술한다. 마이크로필름인 경우에는 GPRN 자료번호 뒤에 "MF"를 원 괄호에 넣어 기술한다.</para>
    /// labels<para>한국정부간행물 발간등록번호</para><para>gprn</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/gprn">http://lod.nl.go.kr/ontology/gprn</seealso>
    let gprn = Prefixed_Name(nlon, "gprn") |> PrefixedName

    /// <summary>
    ///   <para>nlon:headingOfTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    /// labels<para>heading of translation</para><para>번역저 기본표목</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/headingOfTranslation">http://lod.nl.go.kr/ontology/headingOfTranslation</seealso>
    let headingOfTranslation =
        Prefixed_Name(nlon, "headingOfTranslation") |> PrefixedName

    /// <summary>
    ///   <para>nlon:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>팩스번호</para><para>fax</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/fax">http://lod.nl.go.kr/ontology/fax</seealso>
    let fax = Prefixed_Name(nlon, "fax") |> PrefixedName
    /// <summary>
    ///   <para>nlon:OnlineMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Online material</para><para>온라인 자료</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/OnlineMaterial">http://lod.nl.go.kr/ontology/OnlineMaterial</seealso>
    let OnlineMaterial = Prefixed_Name(nlon, "OnlineMaterial") |> PrefixedName

    /// <summary>
    ///   <para>nlon:PublicationFrequencyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>연속간행물에서 사용하는 간행빈도 구분 부가정보(008태그 18자리)</para>
    /// labels<para>Publication frequency type</para><para>간행빈도구분</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/PublicationFrequencyType">http://lod.nl.go.kr/ontology/PublicationFrequencyType</seealso>
    let PublicationFrequencyType =
        Prefixed_Name(nlon, "PublicationFrequencyType") |> PrefixedName

    /// <summary>
    ///   <para>nlon:abbreviatedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>색인작성이나 식별을 목적으로 축약된 해당자료의 표제를 기술한다. 등록표제(222 필드)에 기초하여 ISSN 센터가 부여하는 축약표제를 말한다. 기타 축약 표제는 목록작성기관에서 제공한다. 여기에는 초록 및 색인 작성도 포함된다. 약어 표제는 이 필드를 제공하는 기관에 의해 작성될 수 있으며 잡지기사에서 채택될 수도 있다.</para>
    /// labels<para>abbreviated title</para><para>축약표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/abbreviatedTitle">http://lod.nl.go.kr/ontology/abbreviatedTitle</seealso>
    let abbreviatedTitle = Prefixed_Name(nlon, "abbreviatedTitle") |> PrefixedName
    /// <summary>
    ///   <para>nlon:authenticationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>authentication code</para><para>검증부호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/authenticationCode">http://lod.nl.go.kr/ontology/authenticationCode</seealso>
    let authenticationCode = Prefixed_Name(nlon, "authenticationCode") |> PrefixedName

    /// <summary>
    ///   <para>nlon:itemNumberOfOtherNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>청구 기호 중 도서기호를 기술한다.</para>
    /// labels<para>item number of other number</para><para>다른 분류기호 도서기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/itemNumberOfOtherNumber">http://lod.nl.go.kr/ontology/itemNumberOfOtherNumber</seealso>
    let itemNumberOfOtherNumber =
        Prefixed_Name(nlon, "itemNumberOfOtherNumber") |> PrefixedName

    /// <summary>
    ///   <para>nlon:itermNumberOfKDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>청구기호 중 도서기호를 기술한다. 이 식별기호에는 자료(또는 세트) 기호를 기술할 수도 있다.</para>
    /// labels<para>iterm number of KDC</para><para>한국십진분류기호 도서기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/itermNumberOfKDC">http://lod.nl.go.kr/ontology/itermNumberOfKDC</seealso>
    let itermNumberOfKDC = Prefixed_Name(nlon, "itermNumberOfKDC") |> PrefixedName
    /// <summary>
    ///   <para>nlon:kdc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>KDC 분류기호를 기술한다. 복수주제를 다룬 자료로서 분류기호가 2개 이상 부여되는 경우에는 식별기호 ▾a를 반복하여 기술한다.</para>
    /// labels<para>Korean Decimal Classification Number</para><para>한국십진분류기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/kdc">http://lod.nl.go.kr/ontology/kdc</seealso>
    let kdc = Prefixed_Name(nlon, "kdc") |> PrefixedName
    /// <summary>
    ///   <para>nlon:OldBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Old book</para><para>고서</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/OldBook">http://lod.nl.go.kr/ontology/OldBook</seealso>
    let OldBook = Prefixed_Name(nlon, "OldBook") |> PrefixedName
    /// <summary>
    ///   <para>nlon:OnlineMaterialType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Online material type</para><para>온라인자료 유형</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/OnlineMaterialType">http://lod.nl.go.kr/ontology/OnlineMaterialType</seealso>
    let OnlineMaterialType = Prefixed_Name(nlon, "OnlineMaterialType") |> PrefixedName

    /// <summary>
    ///   <para>nlon:PublicationStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>연속간행물에서 사용하는 간행상태 구분 부가정보(008태그 6자리)</para>
    /// labels<para>Publication status type</para><para>간행상태구분</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/PublicationStatusType">http://lod.nl.go.kr/ontology/PublicationStatusType</seealso>
    let PublicationStatusType =
        Prefixed_Name(nlon, "PublicationStatusType") |> PrefixedName

    /// <summary>
    ///   <para>nlon:Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Score</para><para>악보</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/Score">http://lod.nl.go.kr/ontology/Score</seealso>
    let Score = Prefixed_Name(nlon, "Score") |> PrefixedName
    /// <summary>
    ///   <para>nlon:isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is subject of</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/isSubjectOf">http://lod.nl.go.kr/ontology/isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(nlon, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>nlon:itemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>item number</para><para>도서기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/itemNumber">http://lod.nl.go.kr/ontology/itemNumber</seealso>
    let itemNumber = Prefixed_Name(nlon, "itemNumber") |> PrefixedName
    /// <summary>
    ///   <para>nlon:holdingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>자료를 소장하고 있는 기관명에 대한 KORMARC의 부호를 기술한다. 관련 KORMARC 부호는 국립중앙도서관에서 제공하는 "부속서 7. 한국도서관부호표"의 부호를 적용한다.</para>
    /// labels<para>holding institution</para><para>소장기관</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/holdingInstitution">http://lod.nl.go.kr/ontology/holdingInstitution</seealso>
    let holdingInstitution = Prefixed_Name(nlon, "holdingInstitution") |> PrefixedName
    /// <summary>
    ///   <para>nlon:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>University</para><para>대학</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/University">http://lod.nl.go.kr/ontology/University</seealso>
    let University = Prefixed_Name(nlon, "University") |> PrefixedName
    /// <summary>
    ///   <para>nlon:antecedentSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>antecedent source</para><para>원시자료의 정보원</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/antecedentSource">http://lod.nl.go.kr/ontology/antecedentSource</seealso>
    let antecedentSource = Prefixed_Name(nlon, "antecedentSource") |> PrefixedName
    /// <summary>
    ///   <para>nlon:awardsNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>수상내역을 기술한다.</para>
    /// labels<para>awards note</para><para>수상 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/awardsNote">http://lod.nl.go.kr/ontology/awardsNote</seealso>
    let awardsNote = Prefixed_Name(nlon, "awardsNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:audienceNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>당자료가 특수한 이용자층을 고려하여 간행된 경우, 그 이용대상자를 기술한다.
    /// 이용 대상자에 대한 코드정보는 008/22(이용대상자 수준)에 기술하고, 접근제한에 관한 주기는 506(이용제한주기) 필드에 기술한다.
    /// (주의: 전자자료나 시각 자료 레코드에서 읽기 수준과 흥미 연령 및 흥미 수준 정보가 521 필드에 기술될 경우, 008/22 필드는 관심 연령 수준이나 학년에 기준을 둔 관심 수준 정보를 기초로 부호화한다.) 접근 제한을 포함하는 주기는 506(이용제한주기) 필드에 기술한다.</para>
    /// labels<para>audience note</para><para>이용대상자 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/audienceNote">http://lod.nl.go.kr/ontology/audienceNote</seealso>
    let audienceNote = Prefixed_Name(nlon, "audienceNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:awardedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>학위수여대학과 대학원을 기술한다.</para>
    /// labels<para>awarded from</para><para>학위수여 기관</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/awardedFrom">http://lod.nl.go.kr/ontology/awardedFrom</seealso>
    let awardedFrom = Prefixed_Name(nlon, "awardedFrom") |> PrefixedName
    /// <summary>
    ///   <para>nlon:kdcn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>한국십진분류기호</para><para>kdc</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/kdcn">http://lod.nl.go.kr/ontology/kdcn</seealso>
    let kdcn = Prefixed_Name(nlon, "kdcn") |> PrefixedName
    /// <summary>
    ///   <para>nlon:languageNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>해당자료에 사용된 언어에 관한 사항을 문장으로 기술한다. 이 필드는 또한 해당자료에 기재된 알파벳, 문자 또는 다른 기호 체계를 기술하는 데 사용한다. 언어부호(부호)는 008/35-37(언어)과 041(언어부호) 필드에 기술한다.</para>
    /// labels<para>language note</para><para>언어주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/languageNote">http://lod.nl.go.kr/ontology/languageNote</seealso>
    let languageNote = Prefixed_Name(nlon, "languageNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>주기의 전체설명을 해당 면수와 함께 기술한다.</para>
    /// labels<para>bibliography</para><para>서지 등 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/bibliography">http://lod.nl.go.kr/ontology/bibliography</seealso>
    let bibliography = Prefixed_Name(nlon, "bibliography") |> PrefixedName
    /// <summary>
    ///   <para>nlon:biographicalNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>기술대상 자료의 저자명 표목으로 채택된 개인의 전기적 정보나 단체 또는 사건에 대한 역사적인 정보를 기술한다.</para>
    /// labels<para>biographical note</para><para>전기 또는 역사 관련 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/biographicalNote">http://lod.nl.go.kr/ontology/biographicalNote</seealso>
    let biographicalNote = Prefixed_Name(nlon, "biographicalNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:cip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>한 레코드에 하나의 제어번호를 부여한다. 제어번호의 구조는 자료구분부호 3자리, 연도 4자리, 일련번호 6자리로 구성한다. 출판예정도서목록(CIP) 레코드는 CIP를 자료구분부호로 사용한다. CIP 레코드는 자료의 물리적 형태와 관계없이 연도별로 일련번호를 부여한다.</para>
    /// labels<para>CIP system control number</para><para>출판시도서목록 제어번호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/cip">http://lod.nl.go.kr/ontology/cip</seealso>
    let cip = Prefixed_Name(nlon, "cip") |> PrefixedName

    /// <summary>
    ///   <para>nlon:classificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>classification number</para><para>분류기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/classificationNumber">http://lod.nl.go.kr/ontology/classificationNumber</seealso>
    let classificationNumber =
        Prefixed_Name(nlon, "classificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>nlon:manufacturingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>제작지</para>
    /// labels<para>manufacturing place</para><para>제작지</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/manufacturingPlace">http://lod.nl.go.kr/ontology/manufacturingPlace</seealso>
    let manufacturingPlace = Prefixed_Name(nlon, "manufacturingPlace") |> PrefixedName
    /// <summary>
    ///   <para>nlon:medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>인쇄자료 이외의 각종 형태자료의 자료종별성격을 나타내는 매체 표시를 기술한다. ISBD 원칙에 따라 매체표시는 항상 각괄호([ ])로 묶어 기술한다. 종합표제 대신 개별저작의 표제를 기술할 경우에는 첫 번째 표제 다음에 기재한다. 식별기호 ▾a가 반복될 경우에는 첫 번째 식별기호 ▾a 다음에 기술한다.</para>
    /// labels<para>medium</para><para>자료형태</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/medium">http://lod.nl.go.kr/ontology/medium</seealso>
    let medium = Prefixed_Name(nlon, "medium") |> PrefixedName
    /// <summary>
    ///   <para>nlon:meetingInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>meeting information</para><para>회의 정보</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/meetingInformation">http://lod.nl.go.kr/ontology/meetingInformation</seealso>
    let meetingInformation = Prefixed_Name(nlon, "meetingInformation") |> PrefixedName
    /// <summary>
    ///   <para>nlon:modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>modified by</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/modifiedBy">http://lod.nl.go.kr/ontology/modifiedBy</seealso>
    let modifiedBy = Prefixed_Name(nlon, "modifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>nlon:numberMark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>number mark</para><para>숫자부호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/numberMark">http://lod.nl.go.kr/ontology/numberMark</seealso>
    let numberMark = Prefixed_Name(nlon, "numberMark") |> PrefixedName
    /// <summary>
    ///   <para>nlon:openingYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>opening year</para><para>개관연도</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/openingYear">http://lod.nl.go.kr/ontology/openingYear</seealso>
    let openingYear = Prefixed_Name(nlon, "openingYear") |> PrefixedName
    /// <summary>
    ///   <para>nlon:otherNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>제1지시기호에 정의된 분류기호를 기술한다. 복수주제를 다룬 자료로서 분류기호가 2개 이상 부여되는 경우에는 식별기호 ▾a를 반복하여 기술한다.</para>
    /// labels<para>Other Classification Number</para><para>기타 분류기호</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/otherNumber">http://lod.nl.go.kr/ontology/otherNumber</seealso>
    let otherNumber = Prefixed_Name(nlon, "otherNumber") |> PrefixedName

    /// <summary>
    ///   <para>nlon:physicalFormAvailableNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이용가능한 다른 형태자료에 대하여 기술한다. 또한 다른 식별기호에 해당하지 않는 설명도 포함한다.</para>
    /// labels<para>physical form available note</para><para>이용가능한 다른 형태자료 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/physicalFormAvailableNote">http://lod.nl.go.kr/ontology/physicalFormAvailableNote</seealso>
    let physicalFormAvailableNote =
        Prefixed_Name(nlon, "physicalFormAvailableNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:productionPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>생산지</para>
    /// labels<para>production place</para><para>생산지</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/productionPlace">http://lod.nl.go.kr/ontology/productionPlace</seealso>
    let productionPlace = Prefixed_Name(nlon, "productionPlace") |> PrefixedName
    /// <summary>
    ///   <para>nlon:provincialLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>provincial level</para><para>광역시도 레벨</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/provincialLevel">http://lod.nl.go.kr/ontology/provincialLevel</seealso>
    let provincialLevel = Prefixed_Name(nlon, "provincialLevel") |> PrefixedName
    /// <summary>
    ///   <para>nlon:publicationPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>발행지</para>
    /// labels<para>publication place</para><para>발행지</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/publicationPlace">http://lod.nl.go.kr/ontology/publicationPlace</seealso>
    let publicationPlace = Prefixed_Name(nlon, "publicationPlace") |> PrefixedName
    /// <summary>
    ///   <para>nlon:publishedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>published in</para><para>발행되다</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/publishedIn">http://lod.nl.go.kr/ontology/publishedIn</seealso>
    let publishedIn = Prefixed_Name(nlon, "publishedIn") |> PrefixedName
    /// <summary>
    ///   <para>nlon:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>rank</para><para>등급</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/rank">http://lod.nl.go.kr/ontology/rank</seealso>
    let rank = Prefixed_Name(nlon, "rank") |> PrefixedName
    /// <summary>
    ///   <para>nlon:relatedParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>related parts</para><para>상위총서 관계표시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/relatedParts">http://lod.nl.go.kr/ontology/relatedParts</seealso>
    let relatedParts = Prefixed_Name(nlon, "relatedParts") |> PrefixedName

    /// <summary>
    ///   <para>nlon:relationshipInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>relationship information</para><para>관계 정보</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/relationshipInformation">http://lod.nl.go.kr/ontology/relationshipInformation</seealso>
    let relationshipInformation =
        Prefixed_Name(nlon, "relationshipInformation") |> PrefixedName

    /// <summary>
    ///   <para>nlon:remainderOfTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>서지레코드의 표제와 책임표시사항을 기술한다. 이 필드는 본표제를 구성하며 또한 자료유형표시, 표제의 나머지 부분, 기타 표제 관련 정보, 표제지 상의 나머지 부분 전기(轉記)/책임표시로 구성된다. 표제에는 별표제, 편차/권차, 권제/편제가 포함된다.</para>
    /// labels<para>remainder of title</para><para>표제 관련정보</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/remainderOfTitle">http://lod.nl.go.kr/ontology/remainderOfTitle</seealso>
    let remainderOfTitle = Prefixed_Name(nlon, "remainderOfTitle") |> PrefixedName
    /// <summary>
    ///   <para>nlon:reproductionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>복제물이 만들어진 일자를 기술한다. 연속간행물일 경우 시작일과 종료일을 기술한다.</para>
    /// labels<para>reproduction date</para><para>복제일자</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/reproductionDate">http://lod.nl.go.kr/ontology/reproductionDate</seealso>
    let reproductionDate = Prefixed_Name(nlon, "reproductionDate") |> PrefixedName
    /// <summary>
    ///   <para>nlon:keyTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>등록표제는 022(ISSN) 필드에 기록된 국제표준연속간행물번호(ISSN)와 관련되어 연속간행물에 부여되는 표제이다. 이 표제는 한 편의 연속간행물에서 그대로 옮겨온 표제정보로 작성되거나, 필요한 경우 유일성을 갖도록 하는 한정어로 구성된다. 등록표제는 국가센터에 의해 부여된 데이터요소이며 ISSN 네트워크에 연결된 국가센터에서 부여한다.</para>
    /// labels<para>key title</para><para>등록표제</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/keyTitle">http://lod.nl.go.kr/ontology/keyTitle</seealso>
    let keyTitle = Prefixed_Name(nlon, "keyTitle") |> PrefixedName
    /// <summary>
    ///   <para>nlon:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>keyword</para><para>키워드</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/keyword">http://lod.nl.go.kr/ontology/keyword</seealso>
    let keyword = Prefixed_Name(nlon, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>nlon:libraryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>library type</para><para>관종구분</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/libraryType">http://lod.nl.go.kr/ontology/libraryType</seealso>
    let libraryType = Prefixed_Name(nlon, "libraryType") |> PrefixedName

    /// <summary>
    ///   <para>nlon:linkingEntryComplexityNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>해당자료와 관련 있는 서명 및 관련 있는 기술사항을 기술한다.</para>
    /// labels<para>linking entry complexity note</para><para>연관저록 설명 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/linkingEntryComplexityNote">http://lod.nl.go.kr/ontology/linkingEntryComplexityNote</seealso>
    let linkingEntryComplexityNote =
        Prefixed_Name(nlon, "linkingEntryComplexityNote") |> PrefixedName

    /// <summary>
    ///   <para>nlon:localHolding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이 필드는 각 로컬도서관에서 도서관부호와 소장자료의 등록번호, 권·연차기호, 복본기호, 별치기호 등을 기술한다.
    ///
    /// 도서관에 따라 소장사항은 049 필드나 090 필드가 아닌 다른 로컬필드(092, 093 필드 등) 또는 소장 MARC의 필드(852 필드 등)를 사용할 수 있다. KORMARC에서 표시기호에 사용된 숫자 "9"는 대체로 로컬 도서관에서 사용하여 내용을 기술하였음을 의미한다. 049 필드는 MARC21이나 다른 나라의 MARC와는 다른 형식이다.</para>
    /// labels<para>local holding</para><para>소장사항</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/localHolding">http://lod.nl.go.kr/ontology/localHolding</seealso>
    let localHolding = Prefixed_Name(nlon, "localHolding") |> PrefixedName
    /// <summary>
    ///   <para>nlon:locationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>기술대상 자료의 원본이나 복제본이 타기관에 소장되어 있는 경우, 그 원본이나 복제본의 소장처를 기술한다. 이 필드는 원본이나 복제본이 기술된 자료와 다른 곳에 있을 경우에만 기술한다.</para>
    /// labels<para>Location of Originals/Duplicates Note</para><para>원본/복제본 소재 주기</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/locationNote">http://lod.nl.go.kr/ontology/locationNote</seealso>
    let locationNote = Prefixed_Name(nlon, "locationNote") |> PrefixedName
    /// <summary>
    ///   <para>nlon:mainEntryHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    /// labels<para>main entry heading</para><para>상위총서 기본표목</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/mainEntryHeading">http://lod.nl.go.kr/ontology/mainEntryHeading</seealso>
    let mainEntryHeading = Prefixed_Name(nlon, "mainEntryHeading") |> PrefixedName

    /// <summary>
    ///   <para>nlon:dateOfPublicationSequentialDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>이 식별기호에는 창간 권호차와 연월차 뒤에 종간 권호차와 연월차를 기술하되 현재 계속 간행중인 경우에는 창간권·연차 뒤에 짧은 붙임표( - )를 표시한다. 권호차표시는 권차, 판차, 호수, 총서번호 또는 발행처가 관례에 따라 부여한 다른 순차적인 명칭을 기술한다. 연월차는 간행빈도에 따라 "연·월·일"이나 "연과 월 또는 계절", "연"으로 구성된다. 권호차와 연월차가 둘 다 나타나 있는 경우 연월차는 권호차 뒤에 원괄호로 묶어 기술한다.</para>
    /// labels<para>date of publication sequential designation</para><para>권,연차 또는 발행년 표시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/dateOfPublicationSequentialDesignation">http://lod.nl.go.kr/ontology/dateOfPublicationSequentialDesignation</seealso>
    let dateOfPublicationSequentialDesignation =
        Prefixed_Name(nlon, "dateOfPublicationSequentialDesignation") |> PrefixedName

    /// <summary>
    ///   <para>nlon:datePublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date published</para><para>트리플 발행 일시</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/datePublished">http://lod.nl.go.kr/ontology/datePublished</seealso>
    let datePublished = Prefixed_Name(nlon, "datePublished") |> PrefixedName
    /// <summary>
    ///   <para>nlon:ddcn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>듀이십진분류기호</para><para>ddc</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/ddcn">http://lod.nl.go.kr/ontology/ddcn</seealso>
    let ddcn = Prefixed_Name(nlon, "ddcn") |> PrefixedName
    /// <summary>
    ///   <para>nlon:degreeYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>학위수여연월을 기술한다. 학위논문은 학위청구연도와 학위수여연도가 다른 경우, 학위수여연도를 008/06(발행년 유형) s(단일연도), 260 필드의 발행연도에도 동일하게 적용한다. 학위청구연도가 명확하게 구별되지 않는 경우에는 최근 연도를 적용한다.</para>
    /// labels<para>degree year</para><para>학위수여연도</para></remarks>
    /// <seealso href="http://lod.nl.go.kr/ontology/degreeYear">http://lod.nl.go.kr/ontology/degreeYear</seealso>
    let degreeYear = Prefixed_Name(nlon, "degreeYear") |> PrefixedName
