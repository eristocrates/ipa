#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nlon =
    let _prefixId = PrefixId.fromNamespaceLabel "http://lod.nl.go.kr/ontology/" "nlon"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 장애인대체자료rdfs:label : Alternative material</para>
    ///   <a href="http://lod.nl.go.kr/ontology/AlternativeMaterial">nlon:AlternativeMaterial</a>
    /// </summary>
    let AlternativeMaterial = _prefixId.prefix "AlternativeMaterial"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Archivesrdfs:label : 해외수집기록물</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Archives">nlon:Archives</a>
    /// </summary>
    let Archives = _prefixId.prefix "Archives"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : authorrdfs:label : 저자</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Author">nlon:Author</a>
    /// </summary>
    let Author = _prefixId.prefix "Author"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Bookrdfs:label : 도서</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Book">nlon:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Classificationrdfs:label : 분류</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Classification">nlon:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 복합자료rdfs:label : Complex document</para>
    ///   <a href="http://lod.nl.go.kr/ontology/ComplexDocument">nlon:ComplexDocument</a>
    /// </summary>
    let ComplexDocument = _prefixId.prefix "ComplexDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Concept">nlon:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Continuous data typerdfs:label : 연속자료구분</para>
    ///   <para>rdfs:comment : 연속간행물에서 사용하는 연속자료 구분 부가정보</para>
    ///   <a href="http://lod.nl.go.kr/ontology/ContinuousDataType">nlon:ContinuousDataType</a>
    /// </summary>
    let ContinuousDataType = _prefixId.prefix "ContinuousDataType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Countryrdfs:label : 국가</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Country">nlon:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Data typerdfs:label : 자료구분</para>
    ///   <para>rdfs:comment : 공통 대상에서 사용하는 자료 구분 부가정보</para>
    ///   <a href="http://lod.nl.go.kr/ontology/DataType">nlon:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Electronic documentrdfs:label : 전자자료</para>
    ///   <a href="http://lod.nl.go.kr/ontology/ElectronicDocument">nlon:ElectronicDocument</a>
    /// </summary>
    let ElectronicDocument = _prefixId.prefix "ElectronicDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Governmentrdfs:label : 정부기관</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Government">nlon:Government</a>
    /// </summary>
    let Government = _prefixId.prefix "Government"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 사서rdfs:label : librarian</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Librarian">nlon:Librarian</a>
    /// </summary>
    let Librarian = _prefixId.prefix "Librarian"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 도서관rdfs:label : Library</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Library">nlon:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 지역^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Location">nlon:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Non bookrdfs:label : 비도서</para>
    ///   <a href="http://lod.nl.go.kr/ontology/NonBook">nlon:NonBook</a>
    /// </summary>
    let NonBook = _prefixId.prefix "NonBook"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Offline materialrdfs:label : 오프라인 자료</para>
    ///   <a href="http://lod.nl.go.kr/ontology/OfflineMaterial">nlon:OfflineMaterial</a>
    /// </summary>
    let OfflineMaterial = _prefixId.prefix "OfflineMaterial"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 고서rdfs:label : Old book</para>
    ///   <a href="http://lod.nl.go.kr/ontology/OldBook">nlon:OldBook</a>
    /// </summary>
    let OldBook = _prefixId.prefix "OldBook"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Online materialrdfs:label : 온라인 자료</para>
    ///   <a href="http://lod.nl.go.kr/ontology/OnlineMaterial">nlon:OnlineMaterial</a>
    /// </summary>
    let OnlineMaterial = _prefixId.prefix "OnlineMaterial"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Online material typerdfs:label : 온라인자료 유형</para>
    ///   <a href="http://lod.nl.go.kr/ontology/OnlineMaterialType">nlon:OnlineMaterialType</a>
    /// </summary>
    let OnlineMaterialType = _prefixId.prefix "OnlineMaterialType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Publication frequency typerdfs:label : 간행빈도구분</para>
    ///   <para>rdfs:comment : 연속간행물에서 사용하는 간행빈도 구분 부가정보(008태그 18자리)</para>
    ///   <a href="http://lod.nl.go.kr/ontology/PublicationFrequencyType">nlon:PublicationFrequencyType</a>
    /// </summary>
    let PublicationFrequencyType = _prefixId.prefix "PublicationFrequencyType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Publication status typerdfs:label : 간행상태구분</para>
    ///   <para>rdfs:comment : 연속간행물에서 사용하는 간행상태 구분 부가정보(008태그 6자리)</para>
    ///   <a href="http://lod.nl.go.kr/ontology/PublicationStatusType">nlon:PublicationStatusType</a>
    /// </summary>
    let PublicationStatusType = _prefixId.prefix "PublicationStatusType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Scorerdfs:label : 악보</para>
    ///   <a href="http://lod.nl.go.kr/ontology/Score">nlon:Score</a>
    /// </summary>
    let Score = _prefixId.prefix "Score"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 대학rdfs:label : University</para>
    ///   <a href="http://lod.nl.go.kr/ontology/University">nlon:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 색인작성이나 식별을 목적으로 축약된 해당자료의 표제를 기술한다. 등록표제(222 필드)에 기초하여 ISSN 센터가 부여하는 축약표제를 말한다. 기타 축약 표제는 목록작성기관에서 제공한다. 여기에는 초록 및 색인 작성도 포함된다. 약어 표제는 이 필드를 제공하는 기관에 의해 작성될 수 있으며 잡지기사에서 채택될 수도 있다.</para>
    ///   <para>rdfs:label : 축약표제rdfs:label : abbreviated title</para>
    ///   <a href="http://lod.nl.go.kr/ontology/abbreviatedTitle">nlon:abbreviatedTitle</a>
    /// </summary>
    let abbreviatedTitle = _prefixId.prefix "abbreviatedTitle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 원시자료의 정보원rdfs:label : antecedent source</para>
    ///   <a href="http://lod.nl.go.kr/ontology/antecedentSource">nlon:antecedentSource</a>
    /// </summary>
    let antecedentSource = _prefixId.prefix "antecedentSource"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 당자료가 특수한 이용자층을 고려하여 간행된 경우, 그 이용대상자를 기술한다.
    /// 이용 대상자에 대한 코드정보는 008/22(이용대상자 수준)에 기술하고, 접근제한에 관한 주기는 506(이용제한주기) 필드에 기술한다.
    /// (주의: 전자자료나 시각 자료 레코드에서 읽기 수준과 흥미 연령 및 흥미 수준 정보가 521 필드에 기술될 경우, 008/22 필드는 관심 연령 수준이나 학년에 기준을 둔 관심 수준 정보를 기초로 부호화한다.) 접근 제한을 포함하는 주기는 506(이용제한주기) 필드에 기술한다.</para>
    ///   <para>rdfs:label : 이용대상자 주기rdfs:label : audience note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/audienceNote">nlon:audienceNote</a>
    /// </summary>
    let audienceNote = _prefixId.prefix "audienceNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 검증부호rdfs:label : authentication code</para>
    ///   <a href="http://lod.nl.go.kr/ontology/authenticationCode">nlon:authenticationCode</a>
    /// </summary>
    let authenticationCode = _prefixId.prefix "authenticationCode"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 학위수여대학과 대학원을 기술한다.</para>
    ///   <para>rdfs:label : awarded fromrdfs:label : 학위수여 기관</para>
    ///   <a href="http://lod.nl.go.kr/ontology/awardedFrom">nlon:awardedFrom</a>
    /// </summary>
    let awardedFrom = _prefixId.prefix "awardedFrom"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 수상내역을 기술한다.</para>
    ///   <para>rdfs:label : 수상 주기rdfs:label : awards note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/awardsNote">nlon:awardsNote</a>
    /// </summary>
    let awardsNote = _prefixId.prefix "awardsNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 주기의 전체설명을 해당 면수와 함께 기술한다.</para>
    ///   <para>rdfs:label : 서지 등 주기rdfs:label : bibliography</para>
    ///   <a href="http://lod.nl.go.kr/ontology/bibliography">nlon:bibliography</a>
    /// </summary>
    let bibliography = _prefixId.prefix "bibliography"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 기술대상 자료의 저자명 표목으로 채택된 개인의 전기적 정보나 단체 또는 사건에 대한 역사적인 정보를 기술한다.</para>
    ///   <para>rdfs:label : biographical noterdfs:label : 전기 또는 역사 관련 주기</para>
    ///   <a href="http://lod.nl.go.kr/ontology/biographicalNote">nlon:biographicalNote</a>
    /// </summary>
    let biographicalNote = _prefixId.prefix "biographicalNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 생년</para>
    ///   <para>rdfs:label : 출생연도rdfs:label : birth year</para>
    ///   <a href="http://lod.nl.go.kr/ontology/birthYear">nlon:birthYear</a>
    /// </summary>
    let birthYear = _prefixId.prefix "birthYear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 한 레코드에 하나의 제어번호를 부여한다. 제어번호의 구조는 자료구분부호 3자리, 연도 4자리, 일련번호 6자리로 구성한다. 출판예정도서목록(CIP) 레코드는 CIP를 자료구분부호로 사용한다. CIP 레코드는 자료의 물리적 형태와 관계없이 연도별로 일련번호를 부여한다.</para>
    ///   <para>rdfs:label : 출판시도서목록 제어번호rdfs:label : CIP system control number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/cip">nlon:cip</a>
    /// </summary>
    let cip = _prefixId.prefix "cip"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이 필드는 자료의 서평 및 발행된 서지 기술에 대한 인용사항이나 참고문헌 주기를 기술하며 자료가 어디에서 인용되고, 서평 기사를 수록하고 있는지를 상술하는데 적용된다. 인용사항이나 참고문헌은 간략한 형태 즉, 일반적으로 인식할 수 있는 약자 등으로 기술된다. 실제 발행된 기술의 내용은 510 필드에 기술되지 않고, 520(요약 등 주기) 필드에 기술된다.
    ///
    /// 도서와 녹음자료의 경우, 자료의 출판된 기술사항(예, 간략하고 표준화된 형식으로 기술된 희귀자료 기술) 또는 서평(전문 저술에 관한 비평)에 대한 참고문헌을 주기한다.
    ///
    /// 연속간행물의 경우, 연속간행물에 대한 색인 또는 요약이 실린 출판물을 상술하고, 알 수 있을 때 수록 날짜 범위까지 상술하는데 적용된다. 참조된 색인과 초록 서비스는 주로 연속간행물로서 발행된 것들이다. 단행본 표제라 할지라도 어떤 주제 분야의 참고자료로 쓰이고, 연속간행물 형식은 아니지만 일정한 기간을 다룬다면 여기서 다룰 수 있다.
    ///
    /// 집합물로 다루어지는 인쇄물이 아닌 시청각자료나 그래픽 자료인 경우, 이 필드는 작품 또는 작품집에 대한 기술을 수록하고 있는 참고자료들을 기술한다.
    ///
    /// 복합자료의 경우, 기술된 자료의 초록, 인용, 기술, 색인을 수록한 참고문헌을 기술한다.</para>
    ///   <para>rdfs:label : 인용 참고 주기rdfs:label : citation reference note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/citationReferenceNote">nlon:citationReferenceNote</a>
    /// </summary>
    let citationReferenceNote = _prefixId.prefix "citationReferenceNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 분류기호rdfs:label : classification number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/classificationNumber">nlon:classificationNumber</a>
    /// </summary>
    let classificationNumber = _prefixId.prefix "classificationNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 청구기호상의 분류기호를 기술한다.</para>
    ///   <para>rdfs:label : 미국국회도서관 청구기호 분류기호rdfs:label : Library of Congress Call Number - Classification Number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/classificationNumberOfLC">nlon:classificationNumberOfLC</a>
    /// </summary>
    let classificationNumberOfLC = _prefixId.prefix "classificationNumberOfLC"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 국립중앙도서관 청구기호상의 분류기호를 기술한다. 적용 분류표는 KDC, DDC, KDCP, 조선총독부 신서부·양서부·고서부분류표 등이 있다. 여기에 기술된 분류기호는 분류기호 검색을 위하여 적용분류표에 해당하는 분류기호 필드(KDC는 056, DDC는 082, 그 외는 085)에 다시 기술한다.</para>
    ///   <para>rdfs:label : 국립중앙도서관 청구기호 분류기호rdfs:label : National Library of Korea Call Number - Classification Number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/classificationNumberOfNLK">nlon:classificationNumberOfNLK</a>
    /// </summary>
    let classificationNumberOfNLK = _prefixId.prefix "classificationNumberOfNLK"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 확인 날짜rdfs:label : confirm date</para>
    ///   <a href="http://lod.nl.go.kr/ontology/confirmDate">nlon:confirmDate</a>
    /// </summary>
    let confirmDate = _prefixId.prefix "confirmDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : confirmed by</para>
    ///   <a href="http://lod.nl.go.kr/ontology/confirmedBy">nlon:confirmedBy</a>
    /// </summary>
    let confirmedBy = _prefixId.prefix "confirmedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 저작하다rdfs:label : create</para>
    ///   <a href="http://lod.nl.go.kr/ontology/create">nlon:create</a>
    /// </summary>
    let create = _prefixId.prefix "create"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 현행 출판물의 간행빈도를 기술한다.</para>
    ///   <para>rdfs:label : current publication frequencyrdfs:label : 현재 간행빈도</para>
    ///   <a href="http://lod.nl.go.kr/ontology/currentPublicationFrequency">nlon:currentPublicationFrequency</a>
    /// </summary>
    let currentPublicationFrequency = _prefixId.prefix "currentPublicationFrequency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : date linkedrdfs:label : 링크 생성 일시</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateLinked">nlon:dateLinked</a>
    /// </summary>
    let dateLinked = _prefixId.prefix "dateLinked"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : date of closedrdfs:label : 휴관일</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfClosed">nlon:dateOfClosed</a>
    /// </summary>
    let dateOfClosed = _prefixId.prefix "dateOfClosed"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 현재 간행빈도가 창간호의 간행빈도와 같지 않을 경우 현재 간행빈도 시작 연·월을 기술한다. 이전의 간행빈도는 321 필드에 기술한다.</para>
    ///   <para>rdfs:label : 현재 간행빈도 시작 연월rdfs:label : date of current publication frequency</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfCurrentPublicationFrequency">nlon:dateOfCurrentPublicationFrequency</a>
    /// </summary>
    let dateOfCurrentPublicationFrequency =
        _prefixId.prefix "dateOfCurrentPublicationFrequency"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 배포년</para>
    ///   <para>rdfs:label : date of distributerdfs:label : 배포년</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfDistribute">nlon:dateOfDistribute</a>
    /// </summary>
    let dateOfDistribute = _prefixId.prefix "dateOfDistribute"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이전의 간행빈도에 해당하는 연·월을 기술한다.</para>
    ///   <para>rdfs:label : 이전 간행빈도 시행 연월rdfs:label : date of former publication frequency</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfFormerPublicationFrequency">nlon:dateOfFormerPublicationFrequency</a>
    /// </summary>
    let dateOfFormerPublicationFrequency =
        _prefixId.prefix "dateOfFormerPublicationFrequency"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 제작년 또는 인쇄년을 기술한다. 발행년 식별기호인 ▾c에 제작년 또는 인쇄년을 기술한 경우에는 식별기호 ▾g에는 기술하지 않는다.</para>
    ///   <para>rdfs:label : date of manufacturerdfs:label : 제작년</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfManufacture">nlon:dateOfManufacture</a>
    /// </summary>
    let dateOfManufacture = _prefixId.prefix "dateOfManufacture"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : date of openingrdfs:label : 개관일</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfOpening">nlon:dateOfOpening</a>
    /// </summary>
    let dateOfOpening = _prefixId.prefix "dateOfOpening"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이 식별기호에는 창간 권호차와 연월차 뒤에 종간 권호차와 연월차를 기술하되 현재 계속 간행중인 경우에는 창간권·연차 뒤에 짧은 붙임표( - )를 표시한다. 권호차표시는 권차, 판차, 호수, 총서번호 또는 발행처가 관례에 따라 부여한 다른 순차적인 명칭을 기술한다. 연월차는 간행빈도에 따라 "연·월·일"이나 "연과 월 또는 계절", "연"으로 구성된다. 권호차와 연월차가 둘 다 나타나 있는 경우 연월차는 권호차 뒤에 원괄호로 묶어 기술한다.</para>
    ///   <para>rdfs:label : 권,연차 또는 발행년 표시rdfs:label : date of publication sequential designation</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateOfPublicationSequentialDesignation">nlon:dateOfPublicationSequentialDesignation</a>
    /// </summary>
    let dateOfPublicationSequentialDesignation =
        _prefixId.prefix "dateOfPublicationSequentialDesignation"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 트리플 발행 일시rdfs:label : date published</para>
    ///   <a href="http://lod.nl.go.kr/ontology/datePublished">nlon:datePublished</a>
    /// </summary>
    let datePublished = _prefixId.prefix "datePublished"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 기술되는 변경 전 표제와 관련된 권·연차를 기술한다.</para>
    ///   <para>rdfs:label : 표제변동 권연차표시rdfs:label : date sequential designation</para>
    ///   <a href="http://lod.nl.go.kr/ontology/dateSequentialDesignation">nlon:dateSequentialDesignation</a>
    /// </summary>
    let dateSequentialDesignation = _prefixId.prefix "dateSequentialDesignation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 듀이십진분류기호를 기술한다. 동일자료에 둘 이상의 분류기호가 부여된 경우에는 청구기호를 구성하는 식별기호(첫번째 ▾a 및 ▾b) 뒤에 ▾a를 반복하여 두 번째 이하 분류기호를 기술한다.</para>
    ///   <para>rdfs:label : 듀이십진분류기호rdfs:label : Dewey Decimal Classification Number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/ddc">nlon:ddc</a>
    /// </summary>
    let ddc = _prefixId.prefix "ddc"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 듀이십진분류기호rdfs:label : ddc</para>
    ///   <a href="http://lod.nl.go.kr/ontology/ddcn">nlon:ddcn</a>
    /// </summary>
    let ddcn = _prefixId.prefix "ddcn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 몰년</para>
    ///   <para>rdfs:label : 사망연도rdfs:label : death year</para>
    ///   <a href="http://lod.nl.go.kr/ontology/deathYear">nlon:deathYear</a>
    /// </summary>
    let deathYear = _prefixId.prefix "deathYear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 학위수여연월을 기술한다. 학위논문은 학위청구연도와 학위수여연도가 다른 경우, 학위수여연도를 008/06(발행년 유형) s(단일연도), 260 필드의 발행연도에도 동일하게 적용한다. 학위청구연도가 명확하게 구별되지 않는 경우에는 최근 연도를 적용한다.</para>
    ///   <para>rdfs:label : 학위수여연도rdfs:label : degree year</para>
    ///   <a href="http://lod.nl.go.kr/ontology/degreeYear">nlon:degreeYear</a>
    /// </summary>
    let degreeYear = _prefixId.prefix "degreeYear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 논문에 나타나 있는 학과 또는 전공을 기술한다.</para>
    ///   <para>rdfs:label : 학과, 전공rdfs:label : department</para>
    ///   <a href="http://lod.nl.go.kr/ontology/department">nlon:department</a>
    /// </summary>
    let department = _prefixId.prefix "department"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 배포지</para>
    ///   <para>rdfs:label : distribution placerdfs:label : 배포지</para>
    ///   <a href="http://lod.nl.go.kr/ontology/distributionPlace">nlon:distributionPlace</a>
    /// </summary>
    let distributionPlace = _prefixId.prefix "distributionPlace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 배포처</para>
    ///   <para>rdfs:label : distributorrdfs:label : 배포처</para>
    ///   <a href="http://lod.nl.go.kr/ontology/distributor">nlon:distributor</a>
    /// </summary>
    let distributor = _prefixId.prefix "distributor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 분류에 적용한 DDC분류표의 판을 분류기호 뒤에 기술한다. 한 자료에 하나 이상의 분류기호가 서로 판이 다른 경우, 필드를 반복하여 독립된 필드에 기술한다.</para>
    ///   <para>rdfs:label : 듀이십진분류기호 판표시rdfs:label : edition of DDC</para>
    ///   <a href="http://lod.nl.go.kr/ontology/editionOfDDC">nlon:editionOfDDC</a>
    /// </summary>
    let editionOfDDC = _prefixId.prefix "editionOfDDC"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 분류에 적용한 KDC분류표의 판을 분류기호 뒤에 기술한다. 적용된 분류표의 판이 달라 발생하는 2개 이상의 분류기호의 경우에는 056 필드를 반복하여 기술한다.</para>
    ///   <para>rdfs:label : 한국십진분류기호 판표시rdfs:label : edition of KDC</para>
    ///   <a href="http://lod.nl.go.kr/ontology/editionOfKDC">nlon:editionOfKDC</a>
    /// </summary>
    let editionOfKDC = _prefixId.prefix "editionOfKDC"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 전시내용을 기술한다.</para>
    ///   <para>rdfs:label : 전시rdfs:label : exhibition</para>
    ///   <a href="http://lod.nl.go.kr/ontology/exhibition">nlon:exhibition</a>
    /// </summary>
    let exhibition = _prefixId.prefix "exhibition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : faxrdfs:label : 팩스번호</para>
    ///   <a href="http://lod.nl.go.kr/ontology/fax">nlon:fax</a>
    /// </summary>
    let fax = _prefixId.prefix "fax"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이전 간행빈도를 기술한다.</para>
    ///   <para>rdfs:label : 이전 간행빈도rdfs:label : former publication frequency</para>
    ///   <a href="http://lod.nl.go.kr/ontology/formerPublicationFrequency">nlon:formerPublicationFrequency</a>
    /// </summary>
    let formerPublicationFrequency = _prefixId.prefix "formerPublicationFrequency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 권차 또는 권차명 표시를 제외한 본표제, 별표제 또는 관제를 포함하는 본표제를 기술한다. 본표제가 반복되는 경우에는 식별기호(▾a)를 반복한다. 두 번째 이하의 식별기호(▾a)는 245 필드에서 직접 부출 되지 않고 740 필드에 자동생성을 위한 용도로 사용된다. 또한 이 식별기호에는 종합 표제가 없는 집서의 경우, 독립된 저작의 첫 번째 표제(동일하거나 다른 저자/작곡가)를 기술한다.</para>
    ///   <para>rdfs:label : 변경전 표제rdfs:label : former title</para>
    ///   <a href="http://lod.nl.go.kr/ontology/formerTitle">nlon:formerTitle</a>
    /// </summary>
    let formerTitle = _prefixId.prefix "formerTitle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 변경전 표제 설명주기에 관한 사항을 기술한다.</para>
    ///   <para>rdfs:label : 변경전 표제 설명주기rdfs:label : former title complexity note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/formerTitleComplexityNote">nlon:formerTitleComplexityNote</a>
    /// </summary>
    let formerTitleComplexityNote = _prefixId.prefix "formerTitleComplexityNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 장르rdfs:label : genre</para>
    ///   <a href="http://lod.nl.go.kr/ontology/genre">nlon:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : GPO자료번호를 기술한다. 마이크로필름인 경우에는 GPO자료번호 뒤에 "MF"를 원괄호로 묶어 기술한다.</para>
    ///   <para>rdfs:label : 미국정부간행물번호rdfs:label : gpo</para>
    ///   <a href="http://lod.nl.go.kr/ontology/gpo">nlon:gpo</a>
    /// </summary>
    let gpo = _prefixId.prefix "gpo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 한국정부간행물 발간등록번호(GPRN: Government Publications Registration Number)를 기술한다. 마이크로필름인 경우에는 GPRN 자료번호 뒤에 "MF"를 원 괄호에 넣어 기술한다.</para>
    ///   <para>rdfs:label : 한국정부간행물 발간등록번호rdfs:label : gprn</para>
    ///   <a href="http://lod.nl.go.kr/ontology/gprn">nlon:gprn</a>
    /// </summary>
    let gprn = _prefixId.prefix "gprn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    ///   <para>rdfs:label : 원저 기본표목rdfs:label : heading of original language</para>
    ///   <a href="http://lod.nl.go.kr/ontology/headingOfOriginalLanguage">nlon:headingOfOriginalLanguage</a>
    /// </summary>
    let headingOfOriginalLanguage = _prefixId.prefix "headingOfOriginalLanguage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    ///   <para>rdfs:label : 번역저 기본표목rdfs:label : heading of translation</para>
    ///   <a href="http://lod.nl.go.kr/ontology/headingOfTranslation">nlon:headingOfTranslation</a>
    /// </summary>
    let headingOfTranslation = _prefixId.prefix "headingOfTranslation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 자료를 소장하고 있는 기관명에 대한 KORMARC의 부호를 기술한다. 관련 KORMARC 부호는 국립중앙도서관에서 제공하는 "부속서 7. 한국도서관부호표"의 부호를 적용한다.</para>
    ///   <para>rdfs:label : 소장기관rdfs:label : holding institution</para>
    ///   <a href="http://lod.nl.go.kr/ontology/holdingInstitution">nlon:holdingInstitution</a>
    /// </summary>
    let holdingInstitution = _prefixId.prefix "holdingInstitution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 해당기관 소장본의 낙장(落張), 배접(褙接), 보사(補寫), 인문(印文), 장서기(藏書記), 지어(識語), 묵서(墨書)나 열람용 복제본 여부, 소장 원본·복제본의 청구기호 등 소장본 관련 로컬정보를 기술한다.</para>
    ///   <para>rdfs:label : 소장본 주기rdfs:label : holding item note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/holdingItemNote">nlon:holdingItemNote</a>
    /// </summary>
    let holdingItemNote = _prefixId.prefix "holdingItemNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 입력 날짜rdfs:label : input date</para>
    ///   <a href="http://lod.nl.go.kr/ontology/inputDate">nlon:inputDate</a>
    /// </summary>
    let inputDate = _prefixId.prefix "inputDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : inputed by</para>
    ///   <a href="http://lod.nl.go.kr/ontology/inputedBy">nlon:inputedBy</a>
    /// </summary>
    let inputedBy = _prefixId.prefix "inputedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is closedrdfs:label : 폐관여부</para>
    ///   <a href="http://lod.nl.go.kr/ontology/isClosed">nlon:isClosed</a>
    /// </summary>
    let isClosed = _prefixId.prefix "isClosed"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 7자리의 지역구분부호를 기술한다. 해당 자료와 관련된 지역구분부호가 둘 이상일 경우에는 식별기호를 반복하여 기술한다.</para>
    ///   <para>rdfs:label : is geographic area of</para>
    ///   <a href="http://lod.nl.go.kr/ontology/isGeographicAreaOf">nlon:isGeographicAreaOf</a>
    /// </summary>
    let isGeographicAreaOf = _prefixId.prefix "isGeographicAreaOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is subject of</para>
    ///   <a href="http://lod.nl.go.kr/ontology/isSubjectOf">nlon:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 발행처주기에 관한 사항을 기술한다.</para>
    ///   <para>rdfs:label : 발행처주기rdfs:label : issuing body note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/issuingBodyNote">nlon:issuingBodyNote</a>
    /// </summary>
    let issuingBodyNote = _prefixId.prefix "issuingBodyNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : item numberrdfs:label : 도서기호</para>
    ///   <a href="http://lod.nl.go.kr/ontology/itemNumber">nlon:itemNumber</a>
    /// </summary>
    let itemNumber = _prefixId.prefix "itemNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 청구기호 중 도서기호를 기술한다. 이 식별기호에는 자료(또는 세트) 기호를 기술할 수도 있다.</para>
    ///   <para>rdfs:label : 듀이십진분류기호 도서기호rdfs:label : item number of DDC</para>
    ///   <a href="http://lod.nl.go.kr/ontology/itemNumberOfDDC">nlon:itemNumberOfDDC</a>
    /// </summary>
    let itemNumberOfDDC = _prefixId.prefix "itemNumberOfDDC"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 청구기호상의 도서기호를 기술한다.</para>
    ///   <para>rdfs:label : 미국국회도서관 청구기호 도서기호rdfs:label : item number of LC</para>
    ///   <a href="http://lod.nl.go.kr/ontology/itemNumberOfLC">nlon:itemNumberOfLC</a>
    /// </summary>
    let itemNumberOfLC = _prefixId.prefix "itemNumberOfLC"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 국립중앙도서관 청구기호상의 도서기호를 기술한다. 적용 도서기호는 국립중앙도서관 동양서 저자기호표, 카터-샌본저자기호표(Cutter-Sanborn Three-Author Table), 수입순기호 등이 있다.</para>
    ///   <para>rdfs:label : 국립중앙도서관 청구기호 도서기호rdfs:label : item number of NLK</para>
    ///   <a href="http://lod.nl.go.kr/ontology/itemNumberOfNLK">nlon:itemNumberOfNLK</a>
    /// </summary>
    let itemNumberOfNLK = _prefixId.prefix "itemNumberOfNLK"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 청구 기호 중 도서기호를 기술한다.</para>
    ///   <para>rdfs:label : 다른 분류기호 도서기호rdfs:label : item number of other number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/itemNumberOfOtherNumber">nlon:itemNumberOfOtherNumber</a>
    /// </summary>
    let itemNumberOfOtherNumber = _prefixId.prefix "itemNumberOfOtherNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 청구기호 중 도서기호를 기술한다. 이 식별기호에는 자료(또는 세트) 기호를 기술할 수도 있다.</para>
    ///   <para>rdfs:label : 한국십진분류기호 도서기호rdfs:label : iterm number of KDC</para>
    ///   <a href="http://lod.nl.go.kr/ontology/itermNumberOfKDC">nlon:itermNumberOfKDC</a>
    /// </summary>
    let itermNumberOfKDC = _prefixId.prefix "itermNumberOfKDC"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : KDC 분류기호를 기술한다. 복수주제를 다룬 자료로서 분류기호가 2개 이상 부여되는 경우에는 식별기호 ▾a를 반복하여 기술한다.</para>
    ///   <para>rdfs:label : 한국십진분류기호rdfs:label : Korean Decimal Classification Number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/kdc">nlon:kdc</a>
    /// </summary>
    let kdc = _prefixId.prefix "kdc"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : kdcrdfs:label : 한국십진분류기호</para>
    ///   <a href="http://lod.nl.go.kr/ontology/kdcn">nlon:kdcn</a>
    /// </summary>
    let kdcn = _prefixId.prefix "kdcn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 등록표제는 022(ISSN) 필드에 기록된 국제표준연속간행물번호(ISSN)와 관련되어 연속간행물에 부여되는 표제이다. 이 표제는 한 편의 연속간행물에서 그대로 옮겨온 표제정보로 작성되거나, 필요한 경우 유일성을 갖도록 하는 한정어로 구성된다. 등록표제는 국가센터에 의해 부여된 데이터요소이며 ISSN 네트워크에 연결된 국가센터에서 부여한다.</para>
    ///   <para>rdfs:label : 등록표제rdfs:label : key title</para>
    ///   <a href="http://lod.nl.go.kr/ontology/keyTitle">nlon:keyTitle</a>
    /// </summary>
    let keyTitle = _prefixId.prefix "keyTitle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 키워드rdfs:label : keyword</para>
    ///   <a href="http://lod.nl.go.kr/ontology/keyword">nlon:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 해당자료에 사용된 언어에 관한 사항을 문장으로 기술한다. 이 필드는 또한 해당자료에 기재된 알파벳, 문자 또는 다른 기호 체계를 기술하는 데 사용한다. 언어부호(부호)는 008/35-37(언어)과 041(언어부호) 필드에 기술한다.</para>
    ///   <para>rdfs:label : 언어주기rdfs:label : language note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/languageNote">nlon:languageNote</a>
    /// </summary>
    let languageNote = _prefixId.prefix "languageNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : library typerdfs:label : 관종구분</para>
    ///   <a href="http://lod.nl.go.kr/ontology/libraryType">nlon:libraryType</a>
    /// </summary>
    let libraryType = _prefixId.prefix "libraryType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 해당자료와 관련 있는 서명 및 관련 있는 기술사항을 기술한다.</para>
    ///   <para>rdfs:label : 연관저록 설명 주기rdfs:label : linking entry complexity note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/linkingEntryComplexityNote">nlon:linkingEntryComplexityNote</a>
    /// </summary>
    let linkingEntryComplexityNote = _prefixId.prefix "linkingEntryComplexityNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이 필드는 각 로컬도서관에서 도서관부호와 소장자료의 등록번호, 권·연차기호, 복본기호, 별치기호 등을 기술한다.
    ///
    /// 도서관에 따라 소장사항은 049 필드나 090 필드가 아닌 다른 로컬필드(092, 093 필드 등) 또는 소장 MARC의 필드(852 필드 등)를 사용할 수 있다. KORMARC에서 표시기호에 사용된 숫자 "9"는 대체로 로컬 도서관에서 사용하여 내용을 기술하였음을 의미한다. 049 필드는 MARC21이나 다른 나라의 MARC와는 다른 형식이다.</para>
    ///   <para>rdfs:label : 소장사항rdfs:label : local holding</para>
    ///   <a href="http://lod.nl.go.kr/ontology/localHolding">nlon:localHolding</a>
    /// </summary>
    let localHolding = _prefixId.prefix "localHolding"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 기술대상 자료의 원본이나 복제본이 타기관에 소장되어 있는 경우, 그 원본이나 복제본의 소장처를 기술한다. 이 필드는 원본이나 복제본이 기술된 자료와 다른 곳에 있을 경우에만 기술한다.</para>
    ///   <para>rdfs:label : 원본/복제본 소재 주기rdfs:label : Location of Originals/Duplicates Note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/locationNote">nlon:locationNote</a>
    /// </summary>
    let locationNote = _prefixId.prefix "locationNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    ///   <para>rdfs:label : 상위총서 기본표목rdfs:label : main entry heading</para>
    ///   <a href="http://lod.nl.go.kr/ontology/mainEntryHeading">nlon:mainEntryHeading</a>
    /// </summary>
    let mainEntryHeading = _prefixId.prefix "mainEntryHeading"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : managed by</para>
    ///   <a href="http://lod.nl.go.kr/ontology/managedBy">nlon:managedBy</a>
    /// </summary>
    let managedBy = _prefixId.prefix "managedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 제작처</para>
    ///   <para>rdfs:label : manufacturerrdfs:label : 제작처</para>
    ///   <a href="http://lod.nl.go.kr/ontology/manufacturer">nlon:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 제작지</para>
    ///   <para>rdfs:label : manufacturing placerdfs:label : 제작지</para>
    ///   <a href="http://lod.nl.go.kr/ontology/manufacturingPlace">nlon:manufacturingPlace</a>
    /// </summary>
    let manufacturingPlace = _prefixId.prefix "manufacturingPlace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 인쇄자료 이외의 각종 형태자료의 자료종별성격을 나타내는 매체 표시를 기술한다. ISBD 원칙에 따라 매체표시는 항상 각괄호([ ])로 묶어 기술한다. 종합표제 대신 개별저작의 표제를 기술할 경우에는 첫 번째 표제 다음에 기재한다. 식별기호 ▾a가 반복될 경우에는 첫 번째 식별기호 ▾a 다음에 기술한다.</para>
    ///   <para>rdfs:label : 자료형태rdfs:label : medium</para>
    ///   <a href="http://lod.nl.go.kr/ontology/medium">nlon:medium</a>
    /// </summary>
    let medium = _prefixId.prefix "medium"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : meeting informationrdfs:label : 회의 정보</para>
    ///   <a href="http://lod.nl.go.kr/ontology/meetingInformation">nlon:meetingInformation</a>
    /// </summary>
    let meetingInformation = _prefixId.prefix "meetingInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 수정 날짜rdfs:label : modification date</para>
    ///   <a href="http://lod.nl.go.kr/ontology/modificationDate">nlon:modificationDate</a>
    /// </summary>
    let modificationDate = _prefixId.prefix "modificationDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : modified by</para>
    ///   <a href="http://lod.nl.go.kr/ontology/modifiedBy">nlon:modifiedBy</a>
    /// </summary>
    let modifiedBy = _prefixId.prefix "modifiedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : municipal levelrdfs:label : 시군구 레벨</para>
    ///   <a href="http://lod.nl.go.kr/ontology/municipalLevel">nlon:municipalLevel</a>
    /// </summary>
    let municipalLevel = _prefixId.prefix "municipalLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 숫자부호rdfs:label : number mark</para>
    ///   <a href="http://lod.nl.go.kr/ontology/numberMark">nlon:numberMark</a>
    /// </summary>
    let numberMark = _prefixId.prefix "numberMark"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾a는 특수하거나 예외적인 권차를 기술한다. 식별기호 ▾a 아래 기술하는 특수하거나 예외적인 권차의 유형들은 다음과 같다.</para>
    ///   <para>rdfs:label : 특수한 권차표시주기rdfs:label : numbering peculiarities note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/numberingPeculiaritiesNote">nlon:numberingPeculiaritiesNote</a>
    /// </summary>
    let numberingPeculiaritiesNote = _prefixId.prefix "numberingPeculiaritiesNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : opening yearrdfs:label : 개관연도</para>
    ///   <a href="http://lod.nl.go.kr/ontology/openingYear">nlon:openingYear</a>
    /// </summary>
    let openingYear = _prefixId.prefix "openingYear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 해당자료가 영인, 복사, 마이크로형태 등에 의한 복제물이고 복제본을 중심으로 서지정보를 기술한 경우, 그 원본에 관한 사항을 기술한다.</para>
    ///   <para>rdfs:label : 원본주기rdfs:label : original version note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/originalVersionNote">nlon:originalVersionNote</a>
    /// </summary>
    let originalVersionNote = _prefixId.prefix "originalVersionNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 제1지시기호에 정의된 분류기호를 기술한다. 복수주제를 다룬 자료로서 분류기호가 2개 이상 부여되는 경우에는 식별기호 ▾a를 반복하여 기술한다.</para>
    ///   <para>rdfs:label : 기타 분류기호rdfs:label : Other Classification Number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/otherNumber">nlon:otherNumber</a>
    /// </summary>
    let otherNumber = _prefixId.prefix "otherNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이용가능한 다른 형태자료에 대하여 기술한다. 또한 다른 식별기호에 해당하지 않는 설명도 포함한다.</para>
    ///   <para>rdfs:label : 이용가능한 다른 형태자료 주기rdfs:label : physical form available note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/physicalFormAvailableNote">nlon:physicalFormAvailableNote</a>
    /// </summary>
    let physicalFormAvailableNote = _prefixId.prefix "physicalFormAvailableNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 생산처</para>
    ///   <para>rdfs:label : producerrdfs:label : 생산처</para>
    ///   <a href="http://lod.nl.go.kr/ontology/producer">nlon:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 생산지</para>
    ///   <para>rdfs:label : production placerdfs:label : 생산지</para>
    ///   <a href="http://lod.nl.go.kr/ontology/productionPlace">nlon:productionPlace</a>
    /// </summary>
    let productionPlace = _prefixId.prefix "productionPlace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 전체 도법표시를 기술한다. ISBD의 원칙에 따라 ▾b는 쌍반점(;)을 앞세워 기술한다.</para>
    ///   <para>rdfs:label : 도법rdfs:label : projection</para>
    ///   <a href="http://lod.nl.go.kr/ontology/projection">nlon:projection</a>
    /// </summary>
    let projection = _prefixId.prefix "projection"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : provincial levelrdfs:label : 광역시도 레벨</para>
    ///   <a href="http://lod.nl.go.kr/ontology/provincialLevel">nlon:provincialLevel</a>
    /// </summary>
    let provincialLevel = _prefixId.prefix "provincialLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 발행지</para>
    ///   <para>rdfs:label : 발행지rdfs:label : publication place</para>
    ///   <a href="http://lod.nl.go.kr/ontology/publicationPlace">nlon:publicationPlace</a>
    /// </summary>
    let publicationPlace = _prefixId.prefix "publicationPlace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 발행rdfs:label : publish</para>
    ///   <a href="http://lod.nl.go.kr/ontology/publish">nlon:publish</a>
    /// </summary>
    let publish = _prefixId.prefix "publish"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : published inrdfs:label : 발행되다</para>
    ///   <a href="http://lod.nl.go.kr/ontology/publishedIn">nlon:publishedIn</a>
    /// </summary>
    let publishedIn = _prefixId.prefix "publishedIn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : rankrdfs:label : 등급</para>
    ///   <a href="http://lod.nl.go.kr/ontology/rank">nlon:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 상위총서 관계표시rdfs:label : related parts</para>
    ///   <a href="http://lod.nl.go.kr/ontology/relatedParts">nlon:relatedParts</a>
    /// </summary>
    let relatedParts = _prefixId.prefix "relatedParts"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 관계 정보rdfs:label : relationship information</para>
    ///   <a href="http://lod.nl.go.kr/ontology/relationshipInformation">nlon:relationshipInformation</a>
    /// </summary>
    let relationshipInformation = _prefixId.prefix "relationshipInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 서지레코드의 표제와 책임표시사항을 기술한다. 이 필드는 본표제를 구성하며 또한 자료유형표시, 표제의 나머지 부분, 기타 표제 관련 정보, 표제지 상의 나머지 부분 전기(轉記)/책임표시로 구성된다. 표제에는 별표제, 편차/권차, 권제/편제가 포함된다.</para>
    ///   <para>rdfs:label : 표제 관련정보rdfs:label : remainder of title</para>
    ///   <a href="http://lod.nl.go.kr/ontology/remainderOfTitle">nlon:remainderOfTitle</a>
    /// </summary>
    let remainderOfTitle = _prefixId.prefix "remainderOfTitle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 복제물이 만들어진 일자를 기술한다. 연속간행물일 경우 시작일과 종료일을 기술한다.</para>
    ///   <para>rdfs:label : 복제일자rdfs:label : reproduction date</para>
    ///   <a href="http://lod.nl.go.kr/ontology/reproductionDate">nlon:reproductionDate</a>
    /// </summary>
    let reproductionDate = _prefixId.prefix "reproductionDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 복제기관을 기술한다. 만약에 동일한 복제물에 대하여 복제기관이 하나 이상일 경우 반복하여 기술할 수 있다.</para>
    ///   <para>rdfs:label : 복제기관rdfs:label : reproduction institution</para>
    ///   <a href="http://lod.nl.go.kr/ontology/reproductionInstitution">nlon:reproductionInstitution</a>
    /// </summary>
    let reproductionInstitution = _prefixId.prefix "reproductionInstitution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 해당자료가 영인, 복사, 마이크로형태 등에 의한 복제물이고 그 원본을 중심으로 서지정보를 기술한 경우, 복제에 관한 사항을 기술한다.
    ///
    /// 이 필드에는 원본이 복제된 사항을 기술한다. 서지 레코드를 원본을 중심으로 기술하고 복제와 관련된 정보는 533 필드에 주기로 기술한다. 목록작성기관에서 기술부에 원본을 반영할 것을 선택한 경우, 복제본에 관한 정보를 반영하는 데 사용된다.
    ///
    /// 복합 자료의 경우, 기관에서 복제물만을 소장할 때, 이 필드에는 복제된 기록물 단위로 기술하고 기술부는 관례에 따라 원본을 기준으로 작성한다. 이 필드는 보통 원본을 소장하고 있는 기관을 나타내는 535(원본/복제본 소재주기) 필드와 관련하여 사용한다.</para>
    ///   <para>rdfs:label : 복제주기rdfs:label : reproduction note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/reproductionNote">nlon:reproductionNote</a>
    /// </summary>
    let reproductionNote = _prefixId.prefix "reproductionNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 복제물이 만들어진 장소의 명칭을 기술한다. 복제장소가 한 곳 이상일 때에는 반복하여 기술할 수 있다.</para>
    ///   <para>rdfs:label : 복제장소rdfs:label : reproduction place</para>
    ///   <a href="http://lod.nl.go.kr/ontology/reproductionPlace">nlon:reproductionPlace</a>
    /// </summary>
    let reproductionPlace = _prefixId.prefix "reproductionPlace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 자료를 이용하는데 제한이 있는 경우, 그 접근제한에 관한 내용을 기술한다. 출판된 저작의 경우, 이 필드에 배포 제한사항에 대한 정보를 기술한다.
    ///
    /// 출판물에 접근하는 것을 제한한다는 의미가 아니라 출판물이 특정 이용자층을 대상으로 만들어졌을 경우, 이는 521(이용대상자 주기) 필드에 기술한다. 자료를 접근한 이후 자료를 이용하거나 복제하는 데 대한 제한 내용은 540(이용과 복제 제한에 관한 주기) 필드에 기술한다.
    ///
    /// 계속자료(serial)의 경우에는 모든 호수에 대해 제한이 적용되는 경우 사용한다</para>
    ///   <para>rdfs:label : 이용제한사항rdfs:label : restriction</para>
    ///   <a href="http://lod.nl.go.kr/ontology/restriction">nlon:restriction</a>
    /// </summary>
    let restriction = _prefixId.prefix "restriction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 축척이나 그에 상당하는 축척내용을 기술한다. 수직축척이나 지형모형 또는 다른 삼차원자료의 수직확장표시도 이 식별기호에 기술한다.</para>
    ///   <para>rdfs:label : 축척rdfs:label : scale</para>
    ///   <a href="http://lod.nl.go.kr/ontology/scale">nlon:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 창간호나 종간호를 소장하지 않아 권·연차를 다른 정보원으로부터 채기한 경우 (제1지시기호가 1) 그 정보원을 참조(Cf.)와 함께 기술한다.</para>
    ///   <para>rdfs:label : 확인자료명rdfs:label : source of information</para>
    ///   <a href="http://lod.nl.go.kr/ontology/sourceOfInformation">nlon:sourceOfInformation</a>
    /// </summary>
    let sourceOfInformation = _prefixId.prefix "sourceOfInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾a(분류기호)의 적용 분류표와 판표시를 분류기호 뒤에 기술하되, 분류표는 제1지시기호가 b/(그 외의 분류표)인 경우에만 기술한다. 적용된 분류표의 판이 달라 발생하는 2개 이상의 분류기호의 경우에는 필드를 반복하여 기술하는 것이 바람직하다.</para>
    ///   <para>rdfs:label : 분류기호 정보원rdfs:label : source of other number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/sourceOfOtherNumber">nlon:sourceOfOtherNumber</a>
    /// </summary>
    let sourceOfOtherNumber = _prefixId.prefix "sourceOfOtherNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 해당자료의 표준기술보고서번호를 기술한다.</para>
    ///   <para>rdfs:label : 표준기술보고서번호rdfs:label : Standard Technical Report Number</para>
    ///   <a href="http://lod.nl.go.kr/ontology/strn">nlon:strn</a>
    /// </summary>
    let strn = _prefixId.prefix "strn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾a는 관련 레코드 100(기본표목-개인명) 필드, 110(기본표목-단체명) 필드, 111(기본표목-회의명) 필드의 기본표목 데이터를 포함한다. 하지만 식별기호에서는 1XX 필드에서 사용하는 개별적인 이름의 요소나 통일표제는 기술되지 않는다.</para>
    ///   <para>rdfs:label : 하위총서저록 기본표목rdfs:label : subseries entry heading</para>
    ///   <a href="http://lod.nl.go.kr/ontology/subseriesEntryHeading">nlon:subseriesEntryHeading</a>
    /// </summary>
    let subseriesEntryHeading = _prefixId.prefix "subseriesEntryHeading"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : 부제목rdfs:label : subtitle</para>
    ///   <a href="http://lod.nl.go.kr/ontology/subtitle">nlon:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : summer open timerdfs:label : 하절기 개관시간</para>
    ///   <a href="http://lod.nl.go.kr/ontology/summerOpenTime">nlon:summerOpenTime</a>
    /// </summary>
    let summerOpenTime = _prefixId.prefix "summerOpenTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 부록주기를 기술한다. 식별기호 ▾a는 이 주기의 전체 내용을 기술한다.</para>
    ///   <para>rdfs:label : 부록주기rdfs:label : supplement note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/supplementNote">nlon:supplementNote</a>
    /// </summary>
    let supplementNote = _prefixId.prefix "supplementNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 기타형태저록 표제rdfs:label : title of additional physical form</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfAdditionalPhysicalForm">nlon:titleOfAdditionalPhysicalForm</a>
    /// </summary>
    let titleOfAdditionalPhysicalForm = _prefixId.prefix "titleOfAdditionalPhysicalForm"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 구성단위저록 표제rdfs:label : title of constituent unit</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfConstituentUnit">nlon:titleOfConstituentUnit</a>
    /// </summary>
    let titleOfConstituentUnit = _prefixId.prefix "titleOfConstituentUnit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 기본자료저록 표제rdfs:label : title of host item</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfHostItem">nlon:titleOfHostItem</a>
    /// </summary>
    let titleOfHostItem = _prefixId.prefix "titleOfHostItem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 상위총서표제rdfs:label : title of main series</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfMainSeries">nlon:titleOfMainSeries</a>
    /// </summary>
    let titleOfMainSeries = _prefixId.prefix "titleOfMainSeries"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 원저표제rdfs:label : title of original language</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfOriginalLanguage">nlon:titleOfOriginalLanguage</a>
    /// </summary>
    let titleOfOriginalLanguage = _prefixId.prefix "titleOfOriginalLanguage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 이판저록 표제rdfs:label : title of other edition</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfOtherEdition">nlon:titleOfOtherEdition</a>
    /// </summary>
    let titleOfOtherEdition = _prefixId.prefix "titleOfOtherEdition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 선행저록 표제rdfs:label : title of preceding</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfPreceding">nlon:titleOfPreceding</a>
    /// </summary>
    let titleOfPreceding = _prefixId.prefix "titleOfPreceding"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이 필드에는 총서사항과 총서표제의 부출표목이 같은 경우에 총서사항을 기술한다. 이 필드는 총서사항이자 총서부출표목이다. 440 필드가 있는 경우, 이에 대응하는 830 필드는 440 필드와 중복되기 때문에 사용되지 않는다.
    ///
    /// 총서사항은 매체 표시(식별기호 ▾h)를 포함하지 않으므로, 총서부출표목에 매체 표시가 필요한 경우, 490 필드가 총서부출표목에 대응하는 8XX 필드와 함께 총서사항에 사용된다.</para>
    ///   <para>rdfs:label : 총서표제rdfs:label : title of series</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfSeries">nlon:titleOfSeries</a>
    /// </summary>
    let titleOfSeries = _prefixId.prefix "titleOfSeries"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 하위총서표제rdfs:label : title of sub series</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfSubSeries">nlon:titleOfSubSeries</a>
    /// </summary>
    let titleOfSubSeries = _prefixId.prefix "titleOfSubSeries"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 후속저록 표제rdfs:label : title of succeeding</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfSucceeding">nlon:titleOfSucceeding</a>
    /// </summary>
    let titleOfSucceeding = _prefixId.prefix "titleOfSucceeding"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 보유판 및 특별호저록 표제rdfs:label : title of supplement</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfSupplement">nlon:titleOfSupplement</a>
    /// </summary>
    let titleOfSupplement = _prefixId.prefix "titleOfSupplement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 모체레코드저록 표제rdfs:label : title of supplement parent</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfSupplementParent">nlon:titleOfSupplementParent</a>
    /// </summary>
    let titleOfSupplementParent = _prefixId.prefix "titleOfSupplementParent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 식별기호 ▾t는 관련 레코드의 245(표제와 책임표시사항) 필드 또는 130(기본표목-통일표제) 필드의 식별기호 ▾a, ▾f, ▾g, ▾k, ▾n, ▾p로부터 표제정보를 기술한다. 표제의 개별적인 구성요소들은 별도의 식별기호로 부호화되지 않는다.</para>
    ///   <para>rdfs:label : 번역저록 표제rdfs:label : title of translation</para>
    ///   <a href="http://lod.nl.go.kr/ontology/titleOfTranslation">nlon:titleOfTranslation</a>
    /// </summary>
    let titleOfTranslation = _prefixId.prefix "titleOfTranslation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : type of continuous datardfs:label : 연속자료유형</para>
    ///   <a href="http://lod.nl.go.kr/ontology/typeOfContinuousData">nlon:typeOfContinuousData</a>
    /// </summary>
    let typeOfContinuousData = _prefixId.prefix "typeOfContinuousData"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : type of datardfs:label : 자료유형</para>
    ///   <a href="http://lod.nl.go.kr/ontology/typeOfData">nlon:typeOfData</a>
    /// </summary>
    let typeOfData = _prefixId.prefix "typeOfData"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : type of publication frequencyrdfs:label : 간행빈도유형</para>
    ///   <a href="http://lod.nl.go.kr/ontology/typeOfPublicationFrequency">nlon:typeOfPublicationFrequency</a>
    /// </summary>
    let typeOfPublicationFrequency = _prefixId.prefix "typeOfPublicationFrequency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : type of publication statusrdfs:label : 간행상태유형</para>
    ///   <a href="http://lod.nl.go.kr/ontology/typeOfPublicationStatus">nlon:typeOfPublicationStatus</a>
    /// </summary>
    let typeOfPublicationStatus = _prefixId.prefix "typeOfPublicationStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : type of resourcerdfs:label : 콘텐츠유형</para>
    ///   <a href="http://lod.nl.go.kr/ontology/typeOfResource">nlon:typeOfResource</a>
    /// </summary>
    let typeOfResource = _prefixId.prefix "typeOfResource"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Universal Content Identifierrdfs:label : 국가디지털콘텐츠식별체계</para>
    ///   <para>rdfs:comment : 한국형 URN 식별 체계^^xsd:string</para>
    ///   <a href="http://lod.nl.go.kr/ontology/uci">nlon:uci</a>
    /// </summary>
    let uci = _prefixId.prefix "uci"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이 필드는 총서의 부출표목이 서명일 경우를 나타낸다. 830 필드는 보통 총서와 관련된 필드 490 필드의 총서사항이나 500 필드의 일반주기로 판단될 수 있다. 복제물의 경우 533(복제주기) 필드의 ▾f(복제 총서사항)에 기술된 것을 근거로 기술할 수 있다.</para>
    ///   <para>rdfs:label : 통일표제rdfs:label : uniform title of series</para>
    ///   <a href="http://lod.nl.go.kr/ontology/uniformTitleOfSeries">nlon:uniformTitleOfSeries</a>
    /// </summary>
    let uniformTitleOfSeries = _prefixId.prefix "uniformTitleOfSeries"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 이용과 복제에 관한 사항을 기술한다. 이 사항은 법적인 효력을 가지고 있거나 공식적인 제한규정을 의미하는 것이다.</para>
    ///   <para>rdfs:label : 이용과 복제 제한에 관한 주기rdfs:label : use and reproduction note</para>
    ///   <a href="http://lod.nl.go.kr/ontology/useAndReproductionNote">nlon:useAndReproductionNote</a>
    /// </summary>
    let useAndReproductionNote = _prefixId.prefix "useAndReproductionNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : volume of NLKrdfs:label : 국립중앙도서관 청구기호 권연차기호</para>
    ///   <para>rdfs:comment : 국립중앙도서관 청구기호상의 권·연차기호를 기술한다. 권·연차가 연속된 경우에는 처음 권·연차와 마지막 권·연차를 붙임표( - )로 연결한다. 단, 현재 계속 간행중인 경우에는 처음 권·연차 뒤에 붙임표( - )까지만 입력한다</para>
    ///   <a href="http://lod.nl.go.kr/ontology/volumeOfNLK">nlon:volumeOfNLK</a>
    /// </summary>
    let volumeOfNLK = _prefixId.prefix "volumeOfNLK"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 총서에 주어진 권차 또는 차례를 나타내는 명칭을 기술한다.</para>
    ///   <para>rdfs:label : volume of seriesrdfs:label : 총서번호</para>
    ///   <a href="http://lod.nl.go.kr/ontology/volumeOfSeries">nlon:volumeOfSeries</a>
    /// </summary>
    let volumeOfSeries = _prefixId.prefix "volumeOfSeries"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : winter open timerdfs:label : 동절기 개관시간</para>
    ///   <a href="http://lod.nl.go.kr/ontology/winterOpenTime">nlon:winterOpenTime</a>
    /// </summary>
    let winterOpenTime = _prefixId.prefix "winterOpenTime"
