#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dcndl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ndl.go.jp/dcndl/terms/" "dcndl"
    let _namespaceIri = _prefixId.prefix ""
    let BRNO = _prefixId.prefix "BRNO"
    let BSH = _prefixId.prefix "BSH"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>rdfs:comment : 管理情報のクラス^^xsd:string</para>
    ///   <para>rdfs:label : Bib Admin Resource^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/BibAdminResource">dcndl:BibAdminResource</a>
    /// </summary>
    let BibAdminResource = _prefixId.prefix "BibAdminResource"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>rdfs:comment : 書誌情報のクラス^^xsd:string</para>
    ///   <para>rdfs:label : Bib Resource^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/BibResource">dcndl:BibResource</a>
    /// </summary>
    let BibResource = _prefixId.prefix "BibResource"
    let CODEN = _prefixId.prefix "CODEN"
    let DOI = _prefixId.prefix "DOI"
    let ErrorISBN = _prefixId.prefix "ErrorISBN"
    let GHQSCAP = _prefixId.prefix "GHQSCAP"
    let GPOBibNO = _prefixId.prefix "GPOBibNO"
    let GPOCN = _prefixId.prefix "GPOCN"
    let ICNO = _prefixId.prefix "ICNO"
    let ISBN = _prefixId.prefix "ISBN"
    let ISIL = _prefixId.prefix "ISIL"
    let ISMN = _prefixId.prefix "ISMN"
    let ISRN = _prefixId.prefix "ISRN"
    let ISSN = _prefixId.prefix "ISSN"
    let ISSNL = _prefixId.prefix "ISSNL"
    let IncorrectISSN = _prefixId.prefix "IncorrectISSN"
    let IncorrectISSNL = _prefixId.prefix "IncorrectISSNL"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>rdfs:comment : 個体情報のクラス^^xsd:string</para>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/Item">dcndl:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    let JISX0304 = _prefixId.prefix "JISX0304"
    let JISX0402 = _prefixId.prefix "JISX0402"
    let JISX0408 = _prefixId.prefix "JISX0408"
    let JISX0410 = _prefixId.prefix "JISX0410"
    let JPNO = _prefixId.prefix "JPNO"
    let KAKENHINO = _prefixId.prefix "KAKENHINO"
    let KNMARCNO = _prefixId.prefix "KNMARCNO"
    let MCJ = _prefixId.prefix "MCJ"
    let NCNO = _prefixId.prefix "NCNO"
    let NDC = _prefixId.prefix "NDC"
    let NDC8 = _prefixId.prefix "NDC8"
    let NDLBibID = _prefixId.prefix "NDLBibID"
    let NDLC = _prefixId.prefix "NDLC"
    let NDLJP = _prefixId.prefix "NDLJP"
    let NDLNA = _prefixId.prefix "NDLNA"
    let NDLType = _prefixId.prefix "NDLType"
    let NIIBibID = _prefixId.prefix "NIIBibID"
    let NIISubject = _prefixId.prefix "NIISubject"
    let NIIType = _prefixId.prefix "NIIType"
    let NSMARCNO = _prefixId.prefix "NSMARCNO"
    let OCLCNO = _prefixId.prefix "OCLCNO"
    let OPLMARCNO = _prefixId.prefix "OPLMARCNO"
    let PBNO = _prefixId.prefix "PBNO"
    let PLNO = _prefixId.prefix "PLNO"
    let RIS502 = _prefixId.prefix "RIS502"
    let RLINNO = _prefixId.prefix "RLINNO"
    let SICI = _prefixId.prefix "SICI"
    let StandardNO = _prefixId.prefix "StandardNO"
    let TRCMARCNO = _prefixId.prefix "TRCMARCNO"
    let TRNO = _prefixId.prefix "TRNO"
    let UKMARCNO = _prefixId.prefix "UKMARCNO"
    let UNDS = _prefixId.prefix "UNDS"
    let UNSN = _prefixId.prefix "UNSN"
    let USCAR = _prefixId.prefix "USCAR"
    let USMARCNO = _prefixId.prefix "USMARCNO"
    let UTMNO = _prefixId.prefix "UTMNO"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 所蔵する逐次刊行物の欠号に関する情報^^xsd:string</para>
    ///   <para>rdfs:label : Absent Issues^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/absentIssues">dcndl:absentIssues</a>
    /// </summary>
    let absentIssues = _prefixId.prefix "absentIssues"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : タイトルの別言語又は別文字の表示形等を収める。2010年10月に行われたDCMI Metadata Termsの改訂において、dcterms:alternativeの値域がリテラルに制約された。値域の制約をしない、別タイトルの記述語彙として当該語彙を定義する。^^xsd:string</para>
    ///   <para>rdfs:comment : 別タイトル^^xsd:string</para>
    ///   <para>rdfs:label : Alternative^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/alternative">dcndl:alternative</a>
    /// </summary>
    let alternative = _prefixId.prefix "alternative"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : Alternativeの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/alternativeTranscription">dcndl:alternativeTranscription</a>
    /// </summary>
    let alternativeTranscription = _prefixId.prefix "alternativeTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : Alternative Titleを記録する際、Alternative Titleの言語と同一の部編番号表記があればそれを収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 別タイトル部編番号^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Volume^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/alternativeVolume">dcndl:alternativeVolume</a>
    /// </summary>
    let alternativeVolume = _prefixId.prefix "alternativeVolume"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : Alternative Titleを記録する際、Alternative Titleの言語と同一の部編名表記があればそれを収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 別タイトル部編名^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Volume Title^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitle">dcndl:alternativeVolumeTitle</a>
    /// </summary>
    let alternativeVolumeTitle = _prefixId.prefix "alternativeVolumeTitle"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Alternative Volume Titleの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Volume Title Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitleTranscription">dcndl:alternativeVolumeTitleTranscription</a>
    /// </summary>
    let alternativeVolumeTitleTranscription =
        _prefixId.prefix "alternativeVolumeTitleTranscription"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Alternative Volumeの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Volume Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTranscription">dcndl:alternativeVolumeTranscription</a>
    /// </summary>
    let alternativeVolumeTranscription =
        _prefixId.prefix "alternativeVolumeTranscription"

    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 当該典拠情報に対し、リンク先典拠情報の名称が「別名」に相当する場合、「をも見よ参照」の記述に当該語彙を使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : をも見よ参照（別名）^^xsd:string</para>
    ///   <para>rdfs:label : Another Name^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/anotherName">dcndl:anotherName</a>
    /// </summary>
    let anotherName = _prefixId.prefix "anotherName"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 「ＩＬＬ可」、「複写申込み可」、「オンライン利用可」等の情報を収める。情報資源そのものへのアクセス制限、プライバシーやセキュリティ等のポリシーはDublin Core Metadata TermsのAccess Rightsを使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の二次的・副次的な入手可能性^^xsd:string</para>
    ///   <para>rdfs:label : Availability^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/availability">dcndl:availability</a>
    /// </summary>
    let availability = _prefixId.prefix "availability"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : メタデータのハーベスト元であるデータベースに付与したリポジトリ番号等を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : メタデータのハーベスト元のデータベースに関する情報^^xsd:string</para>
    ///   <para>rdfs:label : Bibliographic Record Category^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/bibRecordCategory">dcndl:bibRecordCategory</a>
    /// </summary>
    let bibRecordCategory = _prefixId.prefix "bibRecordCategory"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : メタデータのハーベスト元であるデータベースに付与したリポジトリ番号の下位に有用な情報がある場合、コード値等を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : dcndl:bibRecordCategoryの下位区分にあたる情報^^xsd:string</para>
    ///   <para>rdfs:label : Bibliographic Record Sub Category^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/bibRecordSubCategory">dcndl:bibRecordSubCategory</a>
    /// </summary>
    let bibRecordSubCategory = _prefixId.prefix "bibRecordSubCategory"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 当該情報資源を保有する所蔵館における正請求記号を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 請求記号^^xsd:string</para>
    ///   <para>rdfs:label : Call Number^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/callNumber">dcndl:callNumber</a>
    /// </summary>
    let callNumber = _prefixId.prefix "callNumber"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源のメタデータ記述に採用した目録規則^^xsd:string</para>
    ///   <para>rdfs:label : Cataloging Rule^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/catalogingRule">dcndl:catalogingRule</a>
    /// </summary>
    let catalogingRule = _prefixId.prefix "catalogingRule"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 書誌レコード作成の作業段階を示すコード値を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 書誌レコード作成のステータス^^xsd:string</para>
    ///   <para>rdfs:label : Cataloguing Status^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/cataloguingStatus">dcndl:cataloguingStatus</a>
    /// </summary>
    let cataloguingStatus = _prefixId.prefix "cataloguingStatus"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : Contributorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Contributor Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/contributorTranscription">dcndl:contributorTranscription</a>
    /// </summary>
    let contributorTranscription = _prefixId.prefix "contributorTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>dcterms:description : URIを持つ場合は、一律DCTERMS Creatorに収め、対象リソースへのURI参照を行う。^^xsd:string</para>
    ///   <para>rdfs:comment : Creatorの別名又は異なる形^^xsd:string</para>
    ///   <para>rdfs:label : Creator Alternative^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/creatorAlternative">dcndl:creatorAlternative</a>
    /// </summary>
    let creatorAlternative = _prefixId.prefix "creatorAlternative"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : Creator Alternativeの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Creator Alternative Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/creatorAlternativeTranscription">dcndl:creatorAlternativeTranscription</a>
    /// </summary>
    let creatorAlternativeTranscription =
        _prefixId.prefix "creatorAlternativeTranscription"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>dcterms:description : 主に、著者標目の読みを表現する際に用いる。^^xsd:string</para>
    ///   <para>rdfs:comment : Creatorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Creator Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/creatorTranscription">dcndl:creatorTranscription</a>
    /// </summary>
    let creatorTranscription = _prefixId.prefix "creatorTranscription"
    /// <summary>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源を採取・保存した日^^xsd:string</para>
    ///   <para>rdfs:label : Date Captured^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/dateCaptured">dcndl:dateCaptured</a>
    /// </summary>
    let dateCaptured = _prefixId.prefix "dateCaptured"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 非デジタル資料をデジタル化した年月日を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源をデジタル化した日付^^xsd:string</para>
    ///   <para>rdfs:label : Date Digitized^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/dateDigitized">dcndl:dateDigitized</a>
    /// </summary>
    let dateDigitized = _prefixId.prefix "dateDigitized"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の作成者が博士号を授与された年月日^^xsd:string</para>
    ///   <para>rdfs:label : Date Granted^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/dateGranted">dcndl:dateGranted</a>
    /// </summary>
    let dateGranted = _prefixId.prefix "dateGranted"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 博士号の授与大学名・大学コード等を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の作成者に博士号を授与した大学名^^xsd:string</para>
    ///   <para>rdfs:label : Degree Grantor^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/degreeGrantor">dcndl:degreeGrantor</a>
    /// </summary>
    let degreeGrantor = _prefixId.prefix "degreeGrantor"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Degree Grantorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Degree Grantor Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/degreeGrantorTranscription">dcndl:degreeGrantorTranscription</a>
    /// </summary>
    let degreeGrantorTranscription = _prefixId.prefix "degreeGrantorTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 博士論文の学位分野名^^xsd:string</para>
    ///   <para>rdfs:label : Degree Name^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/degreeName">dcndl:degreeName</a>
    /// </summary>
    let degreeName = _prefixId.prefix "degreeName"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源をデジタル化した実体^^xsd:string</para>
    ///   <para>rdfs:label : Digitized Publisher^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/digitizedPublisher">dcndl:digitizedPublisher</a>
    /// </summary>
    let digitizedPublisher = _prefixId.prefix "digitizedPublisher"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 博士論文の報告番号^^xsd:string</para>
    ///   <para>rdfs:label : Dissertation Number^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/dissertationNumber">dcndl:dissertationNumber</a>
    /// </summary>
    let dissertationNumber = _prefixId.prefix "dissertationNumber"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源が属する版^^xsd:string</para>
    ///   <para>rdfs:label : Edition^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/edition">dcndl:edition</a>
    /// </summary>
    let edition = _prefixId.prefix "edition"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源が属する版に対し著作責任を持つ実体^^xsd:string</para>
    ///   <para>rdfs:label : Edition Creator^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/editionCreator">dcndl:editionCreator</a>
    /// </summary>
    let editionCreator = _prefixId.prefix "editionCreator"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Edition Creatorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Edition Creator Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/editionCreatorTranscription">dcndl:editionCreatorTranscription</a>
    /// </summary>
    let editionCreatorTranscription = _prefixId.prefix "editionCreatorTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の保有者^^xsd:string</para>
    ///   <para>rdfs:label : Holding Agent^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/holdingAgent">dcndl:holdingAgent</a>
    /// </summary>
    let holdingAgent = _prefixId.prefix "holdingAgent"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 所蔵する逐次刊行物の巻次・年月次^^xsd:string</para>
    ///   <para>rdfs:label : Holding Issues^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/holdingIssues">dcndl:holdingIssues</a>
    /// </summary>
    let holdingIssues = _prefixId.prefix "holdingIssues"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源が属する刊行物の通号^^xsd:string</para>
    ///   <para>rdfs:label : Issue^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/issue">dcndl:issue</a>
    /// </summary>
    let issue = _prefixId.prefix "issue"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 当該典拠情報に対し、リンク先典拠情報の名称が「新称」に相当する場合、「をも見よ参照」の記述に当該語彙を使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : をも見よ参照（新称）^^xsd:string</para>
    ///   <para>rdfs:label : Later Name^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/laterName">dcndl:laterName</a>
    /// </summary>
    let laterName = _prefixId.prefix "laterName"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 当該情報資源を保有する所蔵館におけるローカル請求記号を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 請求記号^^xsd:string</para>
    ///   <para>rdfs:label : Local Call Number^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/localCallNumber">dcndl:localCallNumber</a>
    /// </summary>
    let localCallNumber = _prefixId.prefix "localCallNumber"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 出版者を記述対象とし、その出版者の所在に関する情報を記録する場合に、当該語彙を使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : 出版者の所在に関する情報^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/location">dcndl:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 資料種別^^xsd:string</para>
    ///   <para>rdfs:label : Material Type^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/materialType">dcndl:materialType</a>
    /// </summary>
    let materialType = _prefixId.prefix "materialType"
    let ndlsh = _prefixId.prefix "ndlsh"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : PRISM（Publishing Requirements for Industry Standard Metadata）のプロパティprism:volumeでは、プロパティそのものにURIが付与されていないため、独自に新設した。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源が属する刊行物の号^^xsd:string</para>
    ///   <para>rdfs:label : Number^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/number">dcndl:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 原文の言語^^xsd:string</para>
    ///   <para>rdfs:label : Original Language^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/originalLanguage">dcndl:originalLanguage</a>
    /// </summary>
    let originalLanguage = _prefixId.prefix "originalLanguage"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : PRISM（Publishing Requirements for Industry Standard Metadata）のプロパティprism:volumeでは、プロパティそのものにURIが付与されていないため、独自に新設した。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源が掲載されているページの範囲^^xsd:string</para>
    ///   <para>rdfs:label : Page Range^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/pageRange">dcndl:pageRange</a>
    /// </summary>
    let pageRange = _prefixId.prefix "pageRange"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 内容細目のタイトルと責任表示をセットでdcndl:partInformationに記録せず、個別に記録する場合、内容細目の責任表示の表現に当該語彙を使用する。
    /// ただし、URIを持つ場合は、一律DCTERMS Creatorに収め、対象リソースへのURI参照を行う。^^xsd:string</para>
    ///   <para>rdfs:comment : 単行書の構成レベルの各著作に著作責任を持つ実体^^xsd:string</para>
    ///   <para>rdfs:label : Part Creator^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/partCreator">dcndl:partCreator</a>
    /// </summary>
    let partCreator = _prefixId.prefix "partCreator"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Part Creatorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Part Creator Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/partCreatorTranscription">dcndl:partCreatorTranscription</a>
    /// </summary>
    let partCreatorTranscription = _prefixId.prefix "partCreatorTranscription"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 内容細目のタイトル及び責任表示をセットで記録する場合に使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : 単行書の構成レベルに相当する情報^^xsd:string</para>
    ///   <para>rdfs:label : Part Information^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/partInformation">dcndl:partInformation</a>
    /// </summary>
    let partInformation = _prefixId.prefix "partInformation"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 内容細目のタイトルと責任表示をセットでdcndl:partInformationとして記録せず、個別に記録する場合、内容細目のタイトルの表現に当該語彙を使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : 単行書の構成レベルに相当する各著作のタイトル^^xsd:string</para>
    ///   <para>rdfs:label : Part Title^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/partTitle">dcndl:partTitle</a>
    /// </summary>
    let partTitle = _prefixId.prefix "partTitle"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Part Titleの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Part Title Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/partTitleTranscription">dcndl:partTitleTranscription</a>
    /// </summary>
    let partTitleTranscription = _prefixId.prefix "partTitleTranscription"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 当該典拠情報に対し、リンク先典拠情報の名称が「旧称」に相当する場合、「をも見よ参照」の記述に当該語彙を使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : をも見よ参照（旧称）^^xsd:string</para>
    ///   <para>rdfs:label : Previous Name^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/previousName">dcndl:previousName</a>
    /// </summary>
    let previousName = _prefixId.prefix "previousName"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 販売価格^^xsd:string</para>
    ///   <para>rdfs:label : Price^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/price">dcndl:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 当該情報資源が雑誌記事である場合、雑誌名をここに収める。
    /// PRISM（Publishing Requirements for Industry Standard Metadata）のプロパティprism:volumeでは、プロパティそのものにURIが付与されていないため、独自に新設した。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の属する刊行物名^^xsd:string</para>
    ///   <para>rdfs:label : Publication Name^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/publicationName">dcndl:publicationName</a>
    /// </summary>
    let publicationName = _prefixId.prefix "publicationName"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 逐次刊行物の刊行頻度^^xsd:string</para>
    ///   <para>rdfs:label : Publication Periodicity^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/publicationPeriodicity">dcndl:publicationPeriodicity</a>
    /// </summary>
    let publicationPeriodicity = _prefixId.prefix "publicationPeriodicity"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 記述対象とする情報資源の出版地・頒布地を記述する場合に使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : 出版地・頒布地^^xsd:string</para>
    ///   <para>rdfs:label : Publication Place^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/publicationPlace">dcndl:publicationPlace</a>
    /// </summary>
    let publicationPlace = _prefixId.prefix "publicationPlace"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 継続刊行中、刊行終了等、逐次刊行物の刊行状態に関する情報をここに収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 逐次刊行物の刊行状態^^xsd:string</para>
    ///   <para>rdfs:label : Publication Status^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/publicationStatus">dcndl:publicationStatus</a>
    /// </summary>
    let publicationStatus = _prefixId.prefix "publicationStatus"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 当該情報資源が雑誌記事である場合、属する刊行物の巻をここに収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の属する刊行物の巻^^xsd:string</para>
    ///   <para>rdfs:label : Publication Volume^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/publicationVolume">dcndl:publicationVolume</a>
    /// </summary>
    let publicationVolume = _prefixId.prefix "publicationVolume"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : Publisherの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Publisher Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/publisherTranscription">dcndl:publisherTranscription</a>
    /// </summary>
    let publisherTranscription = _prefixId.prefix "publisherTranscription"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 当該典拠情報に対し、リンク先典拠情報の名称が「本名」に相当する場合、「をも見よ参照」の記述に当該語彙を使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : をも見よ参照（本名）^^xsd:string</para>
    ///   <para>rdfs:label : Real Name^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/realName">dcndl:realName</a>
    /// </summary>
    let realName = _prefixId.prefix "realName"
    /// <summary>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 参照先に関係のあるメタデータを持つ^^xsd:string</para>
    ///   <para>rdfs:label : Record^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/record">dcndl:record</a>
    /// </summary>
    let record = _prefixId.prefix "record"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : 新規・更新等のレコードの状態に関する情報を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該レコードの状態^^xsd:string</para>
    ///   <para>rdfs:label : Record Status^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/recordStatus">dcndl:recordStatus</a>
    /// </summary>
    let recordStatus = _prefixId.prefix "recordStatus"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : シリーズタイトルの別言語又は別文字の表示形を収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 別シリーズタイトル^^xsd:string</para>
    ///   <para>rdfs:label : Series Alternative^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesAlternative">dcndl:seriesAlternative</a>
    /// </summary>
    let seriesAlternative = _prefixId.prefix "seriesAlternative"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Series Alternativeの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Series Alternative Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesAlternativeTranscription">dcndl:seriesAlternativeTranscription</a>
    /// </summary>
    let seriesAlternativeTranscription =
        _prefixId.prefix "seriesAlternativeTranscription"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : URIを持つ場合は、一律DCTERMS Creatorに収め、対象リソースへのURI参照を行う。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源が属するシリーズに対し著作責任を持つ実体^^xsd:string</para>
    ///   <para>rdfs:label : Series Creator^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesCreator">dcndl:seriesCreator</a>
    /// </summary>
    let seriesCreator = _prefixId.prefix "seriesCreator"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Series Creatorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Series Creator Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesCreatorTranscription">dcndl:seriesCreatorTranscription</a>
    /// </summary>
    let seriesCreatorTranscription = _prefixId.prefix "seriesCreatorTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : シリーズタイトル^^xsd:string</para>
    ///   <para>rdfs:label : Series Title^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesTitle">dcndl:seriesTitle</a>
    /// </summary>
    let seriesTitle = _prefixId.prefix "seriesTitle"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Series Titleの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Series Title Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesTitleTranscription">dcndl:seriesTitleTranscription</a>
    /// </summary>
    let seriesTitleTranscription = _prefixId.prefix "seriesTitleTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : シリーズの巻次又は部編番号^^xsd:string</para>
    ///   <para>rdfs:label : Series Volume^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesVolume">dcndl:seriesVolume</a>
    /// </summary>
    let seriesVolume = _prefixId.prefix "seriesVolume"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : シリーズの部編名^^xsd:string</para>
    ///   <para>rdfs:label : Series Volume Title^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitle">dcndl:seriesVolumeTitle</a>
    /// </summary>
    let seriesVolumeTitle = _prefixId.prefix "seriesVolumeTitle"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Series Volume Titleの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Series Volume Title Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitleTranscription">dcndl:seriesVolumeTitleTranscription</a>
    /// </summary>
    let seriesVolumeTitleTranscription =
        _prefixId.prefix "seriesVolumeTitleTranscription"

    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Series Volumeの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Series Volume Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/seriesVolumeTranscription">dcndl:seriesVolumeTranscription</a>
    /// </summary>
    let seriesVolumeTranscription = _prefixId.prefix "seriesVolumeTranscription"
    let somokuBibID = _prefixId.prefix "somokuBibID"
    let somokuSubID = _prefixId.prefix "somokuSubID"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:description : 当該情報資源が複製資料である場合に、原資料の識別子をここに収める。^^xsd:string</para>
    ///   <para>rdfs:comment : 原資料の識別子^^xsd:string</para>
    ///   <para>rdfs:label : Source Identifier^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/sourceIdentifier">dcndl:sourceIdentifier</a>
    /// </summary>
    let sourceIdentifier = _prefixId.prefix "sourceIdentifier"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : Subjectの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Subject Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/subjectTranscription">dcndl:subjectTranscription</a>
    /// </summary>
    let subjectTranscription = _prefixId.prefix "subjectTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2007-05-01^^xsd:string</para>
    ///   <para>rdfs:comment : Titleの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Title Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/titleTranscription">dcndl:titleTranscription</a>
    /// </summary>
    let titleTranscription = _prefixId.prefix "titleTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : Title、Creator等の値とセットで表現できる場合に使用する。^^xsd:string</para>
    ///   <para>rdfs:comment : 読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/transcription">dcndl:transcription</a>
    /// </summary>
    let transcription = _prefixId.prefix "transcription"
    /// <summary>
    ///   <para>dcterms:created : 2011-12-01^^xsd:string</para>
    ///   <para>rdfs:comment : 統一タイトル^^xsd:string</para>
    ///   <para>rdfs:label : Uniform Title^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/uniformTitle">dcndl:uniformTitle</a>
    /// </summary>
    let uniformTitle = _prefixId.prefix "uniformTitle"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : PRISM（Publishing Requirements for Industry Standard Metadata）のプロパティprism:volumeでは、プロパティそのものにURIが付与されていないため、独自に設定した。^^xsd:string</para>
    ///   <para>rdfs:comment : 巻次又は部編番号^^xsd:string</para>
    ///   <para>rdfs:label : Volume^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volume">dcndl:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>dcterms:description : URIを持つ場合は、一律DCTERMS Creatorに収め、対象リソースへのURI参照を行う。^^xsd:string</para>
    ///   <para>rdfs:comment : 当該情報資源の当該する巻又は部編に対し著作責任を持つ実体^^xsd:string</para>
    ///   <para>rdfs:label : Volume Creator^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volumeCreator">dcndl:volumeCreator</a>
    /// </summary>
    let volumeCreator = _prefixId.prefix "volumeCreator"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Volume Creatorの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Volume Creator Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volumeCreatorTranscription">dcndl:volumeCreatorTranscription</a>
    /// </summary>
    let volumeCreatorTranscription = _prefixId.prefix "volumeCreatorTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 逐次刊行物の初号から終号までの巻次及び年月次^^xsd:string</para>
    ///   <para>rdfs:label : Volume Range^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volumeRange">dcndl:volumeRange</a>
    /// </summary>
    let volumeRange = _prefixId.prefix "volumeRange"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : 多巻ものの各巻タイトル又は逐次刊行物の部編名^^xsd:string</para>
    ///   <para>rdfs:label : Volume Title^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volumeTitle">dcndl:volumeTitle</a>
    /// </summary>
    let volumeTitle = _prefixId.prefix "volumeTitle"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Volume Titleの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Volume Title Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volumeTitleTranscription">dcndl:volumeTitleTranscription</a>
    /// </summary>
    let volumeTitleTranscription = _prefixId.prefix "volumeTitleTranscription"
    /// <summary>
    ///   <para>dcterms:modified : 2011-12-01^^xsd:string</para>
    ///   <para>dcterms:created : 2010-06-21^^xsd:string</para>
    ///   <para>rdfs:comment : Volumeの読み又は翻字形^^xsd:string</para>
    ///   <para>rdfs:label : Volume Transcription^^xsd:string</para>
    ///   <a href="http://ndl.go.jp/dcndl/terms/volumeTranscription">dcndl:volumeTranscription</a>
    /// </summary>
    let volumeTranscription = _prefixId.prefix "volumeTranscription"
