namespace http.ndl.go.jp.dcndl.terms.slash

open DoxAletheia

module dcndl =
    let _namespace_name = "http://ndl.go.jp/dcndl/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// 読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/transcription"></see></summary>
    let transcription = _prefix "transcription"
    /// <summary>
    /// 点字図書・録音図書全国総合目録番号
    /// <see href="http://ndl.go.jp/dcndl/terms/BRNO"></see></summary>
    let BRNO = _prefix "BRNO"
    /// <summary>
    /// 基本件名標目表
    /// <see href="http://ndl.go.jp/dcndl/terms/BSH"></see></summary>
    let BSH = _prefix "BSH"
    /// <summary>
    /// 管理情報のクラス
    /// <see href="http://ndl.go.jp/dcndl/terms/BibAdminResource"></see></summary>
    let BibAdminResource = _prefix "BibAdminResource"
    /// <summary>
    /// 書誌情報のクラス
    /// <see href="http://ndl.go.jp/dcndl/terms/BibResource"></see></summary>
    let BibResource = _prefix "BibResource"
    /// <summary>
    /// Code Designated
    /// <see href="http://ndl.go.jp/dcndl/terms/CODEN"></see></summary>
    let CODEN = _prefix "CODEN"
    /// <summary>
    /// Digital Object Identifier
    /// <see href="http://ndl.go.jp/dcndl/terms/DOI"></see></summary>
    let DOI = _prefix "DOI"
    /// <summary>
    /// ISBNエラーコード
    /// <see href="http://ndl.go.jp/dcndl/terms/ErrorISBN"></see></summary>
    let ErrorISBN = _prefix "ErrorISBN"
    /// <summary>
    /// GHQ/SCAP分類表
    /// <see href="http://ndl.go.jp/dcndl/terms/GHQSCAP"></see></summary>
    let GHQSCAP = _prefix "GHQSCAP"
    /// <summary>
    /// GPO書誌番号
    /// <see href="http://ndl.go.jp/dcndl/terms/GPOBibNO"></see></summary>
    let GPOBibNO = _prefix "GPOBibNO"
    /// <summary>
    /// GPO管理番号
    /// <see href="http://ndl.go.jp/dcndl/terms/GPOCN"></see></summary>
    let GPOCN = _prefix "GPOCN"
    /// <summary>
    /// 国際海図番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ICNO"></see></summary>
    let ICNO = _prefix "ICNO"
    /// <summary>
    /// International Standard Book Number : 国際標準図書番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISBN"></see></summary>
    let ISBN = _prefix "ISBN"
    /// <summary>
    /// International standard identifier for libraries and related organizations : 図書館及び関連組織のための国際標準識別子
    /// <see href="http://ndl.go.jp/dcndl/terms/ISIL"></see></summary>
    let ISIL = _prefix "ISIL"
    /// <summary>
    /// International Standard Music Number : 国際標準楽譜番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISMN"></see></summary>
    let ISMN = _prefix "ISMN"
    /// <summary>
    /// International Standard technical Report Number : 国際標準テクニカルリポート番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISRN"></see></summary>
    let ISRN = _prefix "ISRN"
    /// <summary>
    /// International Standard Serial Number : 国際標準逐次刊行物番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISSN"></see></summary>
    let ISSN = _prefix "ISSN"
    /// <summary>
    /// Linking ISSN
    /// <see href="http://ndl.go.jp/dcndl/terms/ISSNL"></see></summary>
    let ISSNL = _prefix "ISSNL"
    /// <summary>
    /// ISSNエラーコード
    /// <see href="http://ndl.go.jp/dcndl/terms/IncorrectISSN"></see></summary>
    let IncorrectISSN = _prefix "IncorrectISSN"
    /// <summary>
    /// ISSN-Lエラーコード
    /// <see href="http://ndl.go.jp/dcndl/terms/IncorrectISSNL"></see></summary>
    let IncorrectISSNL = _prefix "IncorrectISSNL"
    /// <summary>
    /// 個体情報のクラス
    /// <see href="http://ndl.go.jp/dcndl/terms/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// 国名コード
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0304"></see></summary>
    let JISX0304 = _prefix "JISX0304"
    /// <summary>
    /// 全国地方公共団体コード（5桁）
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0402"></see></summary>
    let JISX0402 = _prefix "JISX0402"
    /// <summary>
    /// 大学・高等専門学校コード
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0408"></see></summary>
    let JISX0408 = _prefix "JISX0408"
    /// <summary>
    /// 標準地域メッシュコード
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0410"></see></summary>
    let JISX0410 = _prefix "JISX0410"
    /// <summary>
    /// 日本全国書誌番号（JP番号）
    /// <see href="http://ndl.go.jp/dcndl/terms/JPNO"></see></summary>
    let JPNO = _prefix "JPNO"
    /// <summary>
    /// 文部科学省科学研究費補助金研究の課題番号
    /// <see href="http://ndl.go.jp/dcndl/terms/KAKENHINO"></see></summary>
    let KAKENHINO = _prefix "KAKENHINO"
    /// <summary>
    /// 紀伊国屋MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/KNMARCNO"></see></summary>
    let KNMARCNO = _prefix "KNMARCNO"
    /// <summary>
    /// MCJ地理コード
    /// <see href="http://ndl.go.jp/dcndl/terms/MCJ"></see></summary>
    let MCJ = _prefix "MCJ"
    /// <summary>
    /// 各国国内海図番号
    /// <see href="http://ndl.go.jp/dcndl/terms/NCNO"></see></summary>
    let NCNO = _prefix "NCNO"
    /// <summary>
    /// 日本十進分類法
    /// <see href="http://ndl.go.jp/dcndl/terms/NDC"></see></summary>
    let NDC = _prefix "NDC"
    /// <summary>
    /// 日本十進分類法新訂8版
    /// <see href="http://ndl.go.jp/dcndl/terms/NDC8"></see></summary>
    let NDC8 = _prefix "NDC8"
    /// <summary>
    /// 国立国会図書館書誌ID
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLBibID"></see></summary>
    let NDLBibID = _prefix "NDLBibID"
    /// <summary>
    /// 国立国会図書館分類表
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLC"></see></summary>
    let NDLC = _prefix "NDLC"
    /// <summary>
    /// 国立国会図書館で付与した永続的識別子
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLJP"></see></summary>
    let NDLJP = _prefix "NDLJP"
    /// <summary>
    /// 国立国会図書館名称典拠（個人名、団体名、家族名、統一タイトル及び地名）
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLNA"></see></summary>
    let NDLNA = _prefix "NDLNA"
    /// <summary>
    /// NDL Typeで規定した情報資源の種別
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLType"></see></summary>
    let NDLType = _prefix "NDLType"
    /// <summary>
    /// NACSIS-CAT書誌レコード番号
    /// <see href="http://ndl.go.jp/dcndl/terms/NIIBibID"></see></summary>
    let NIIBibID = _prefix "NIIBibID"
    /// <summary>
    /// 国立情報学研究所メタデータ主題語彙集
    /// <see href="http://ndl.go.jp/dcndl/terms/NIISubject"></see></summary>
    let NIISubject = _prefix "NIISubject"
    /// <summary>
    /// 国立情報学研究所メタデータ主題語彙集（資源タイプ）
    /// <see href="http://ndl.go.jp/dcndl/terms/NIIType"></see></summary>
    let NIIType = _prefix "NIIType"
    /// <summary>
    /// 日販MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/NSMARCNO"></see></summary>
    let NSMARCNO = _prefix "NSMARCNO"
    /// <summary>
    /// OCLC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/OCLCNO"></see></summary>
    let OCLCNO = _prefix "OCLCNO"
    /// <summary>
    /// 大阪屋MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/OPLMARCNO"></see></summary>
    let OPLMARCNO = _prefix "OPLMARCNO"
    /// <summary>
    /// 出版者番号（楽譜）
    /// <see href="http://ndl.go.jp/dcndl/terms/PBNO"></see></summary>
    let PBNO = _prefix "PBNO"
    /// <summary>
    /// プレート番号（楽譜）
    /// <see href="http://ndl.go.jp/dcndl/terms/PLNO"></see></summary>
    let PLNO = _prefix "PLNO"
    /// <summary>
    /// レコード商品番号体系
    /// <see href="http://ndl.go.jp/dcndl/terms/RIS502"></see></summary>
    let RIS502 = _prefix "RIS502"
    /// <summary>
    /// RLIN番号
    /// <see href="http://ndl.go.jp/dcndl/terms/RLINNO"></see></summary>
    let RLINNO = _prefix "RLINNO"
    /// <summary>
    /// Serial Item and Contributor Identifier。雑誌記事の識別子。
    /// <see href="http://ndl.go.jp/dcndl/terms/SICI"></see></summary>
    let SICI = _prefix "SICI"
    /// <summary>
    /// 規格番号
    /// <see href="http://ndl.go.jp/dcndl/terms/StandardNO"></see></summary>
    let StandardNO = _prefix "StandardNO"
    /// <summary>
    /// TRC MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/TRCMARCNO"></see></summary>
    let TRCMARCNO = _prefix "TRCMARCNO"
    /// <summary>
    /// テクニカルリポート番号
    /// <see href="http://ndl.go.jp/dcndl/terms/TRNO"></see></summary>
    let TRNO = _prefix "TRNO"
    /// <summary>
    /// UK MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/UKMARCNO"></see></summary>
    let UKMARCNO = _prefix "UKMARCNO"
    /// <summary>
    /// 国際連合ドキュメント記号
    /// <see href="http://ndl.go.jp/dcndl/terms/UNDS"></see></summary>
    let UNDS = _prefix "UNDS"
    /// <summary>
    /// 国際連合セールス番号
    /// <see href="http://ndl.go.jp/dcndl/terms/UNSN"></see></summary>
    let UNSN = _prefix "UNSN"
    /// <summary>
    /// USCAR資料分類表
    /// <see href="http://ndl.go.jp/dcndl/terms/USCAR"></see></summary>
    let USCAR = _prefix "USCAR"
    /// <summary>
    /// US MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/USMARCNO"></see></summary>
    let USMARCNO = _prefix "USMARCNO"
    /// <summary>
    /// ユニバーサル横メルカトル図法区画番号
    /// <see href="http://ndl.go.jp/dcndl/terms/UTMNO"></see></summary>
    let UTMNO = _prefix "UTMNO"
    /// <summary>
    /// 所蔵する逐次刊行物の欠号に関する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/absentIssues"></see></summary>
    let absentIssues = _prefix "absentIssues"
    /// <summary>
    /// 別タイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/alternative"></see></summary>
    let alternative = _prefix "alternative"
    /// <summary>
    /// Alternativeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeTranscription"></see></summary>
    let alternativeTranscription = _prefix "alternativeTranscription"
    /// <summary>
    /// 別タイトル部編番号
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolume"></see></summary>
    let alternativeVolume = _prefix "alternativeVolume"
    /// <summary>
    /// 別タイトル部編名
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitle"></see></summary>
    let alternativeVolumeTitle = _prefix "alternativeVolumeTitle"

    /// <summary>
    /// Alternative Volume Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitleTranscription"></see></summary>
    let alternativeVolumeTitleTranscription =
        _prefix "alternativeVolumeTitleTranscription"

    /// <summary>
    /// Alternative Volumeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTranscription"></see></summary>
    let alternativeVolumeTranscription = _prefix "alternativeVolumeTranscription"
    /// <summary>
    /// をも見よ参照（別名）
    /// <see href="http://ndl.go.jp/dcndl/terms/anotherName"></see></summary>
    let anotherName = _prefix "anotherName"
    /// <summary>
    /// 当該情報資源の二次的・副次的な入手可能性
    /// <see href="http://ndl.go.jp/dcndl/terms/availability"></see></summary>
    let availability = _prefix "availability"
    /// <summary>
    /// メタデータのハーベスト元のデータベースに関する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/bibRecordCategory"></see></summary>
    let bibRecordCategory = _prefix "bibRecordCategory"
    /// <summary>
    /// dcndl:bibRecordCategoryの下位区分にあたる情報
    /// <see href="http://ndl.go.jp/dcndl/terms/bibRecordSubCategory"></see></summary>
    let bibRecordSubCategory = _prefix "bibRecordSubCategory"
    /// <summary>
    /// 請求記号
    /// <see href="http://ndl.go.jp/dcndl/terms/callNumber"></see></summary>
    let callNumber = _prefix "callNumber"
    /// <summary>
    /// 当該情報資源のメタデータ記述に採用した目録規則
    /// <see href="http://ndl.go.jp/dcndl/terms/catalogingRule"></see></summary>
    let catalogingRule = _prefix "catalogingRule"
    /// <summary>
    /// 書誌レコード作成のステータス
    /// <see href="http://ndl.go.jp/dcndl/terms/cataloguingStatus"></see></summary>
    let cataloguingStatus = _prefix "cataloguingStatus"
    /// <summary>
    /// Contributorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/contributorTranscription"></see></summary>
    let contributorTranscription = _prefix "contributorTranscription"
    /// <summary>
    /// Creatorの別名又は異なる形
    /// <see href="http://ndl.go.jp/dcndl/terms/creatorAlternative"></see></summary>
    let creatorAlternative = _prefix "creatorAlternative"
    /// <summary>
    /// Creator Alternativeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/creatorAlternativeTranscription"></see></summary>
    let creatorAlternativeTranscription = _prefix "creatorAlternativeTranscription"
    /// <summary>
    /// Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/creatorTranscription"></see></summary>
    let creatorTranscription = _prefix "creatorTranscription"
    /// <summary>
    /// 当該情報資源を採取・保存した日
    /// <see href="http://ndl.go.jp/dcndl/terms/dateCaptured"></see></summary>
    let dateCaptured = _prefix "dateCaptured"
    /// <summary>
    /// 当該情報資源をデジタル化した日付
    /// <see href="http://ndl.go.jp/dcndl/terms/dateDigitized"></see></summary>
    let dateDigitized = _prefix "dateDigitized"
    /// <summary>
    /// 当該情報資源の作成者が博士号を授与された年月日
    /// <see href="http://ndl.go.jp/dcndl/terms/dateGranted"></see></summary>
    let dateGranted = _prefix "dateGranted"
    /// <summary>
    /// 当該情報資源の作成者に博士号を授与した大学名
    /// <see href="http://ndl.go.jp/dcndl/terms/degreeGrantor"></see></summary>
    let degreeGrantor = _prefix "degreeGrantor"
    /// <summary>
    /// Degree Grantorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/degreeGrantorTranscription"></see></summary>
    let degreeGrantorTranscription = _prefix "degreeGrantorTranscription"
    /// <summary>
    /// 博士論文の学位分野名
    /// <see href="http://ndl.go.jp/dcndl/terms/degreeName"></see></summary>
    let degreeName = _prefix "degreeName"
    /// <summary>
    /// 当該情報資源をデジタル化した実体
    /// <see href="http://ndl.go.jp/dcndl/terms/digitizedPublisher"></see></summary>
    let digitizedPublisher = _prefix "digitizedPublisher"
    /// <summary>
    /// 博士論文の報告番号
    /// <see href="http://ndl.go.jp/dcndl/terms/dissertationNumber"></see></summary>
    let dissertationNumber = _prefix "dissertationNumber"
    /// <summary>
    /// 当該情報資源が属する版
    /// <see href="http://ndl.go.jp/dcndl/terms/edition"></see></summary>
    let edition = _prefix "edition"
    /// <summary>
    /// 当該情報資源が属する版に対し著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/editionCreator"></see></summary>
    let editionCreator = _prefix "editionCreator"
    /// <summary>
    /// Edition Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/editionCreatorTranscription"></see></summary>
    let editionCreatorTranscription = _prefix "editionCreatorTranscription"
    /// <summary>
    /// 当該情報資源の保有者
    /// <see href="http://ndl.go.jp/dcndl/terms/holdingAgent"></see></summary>
    let holdingAgent = _prefix "holdingAgent"
    /// <summary>
    /// 所蔵する逐次刊行物の巻次・年月次
    /// <see href="http://ndl.go.jp/dcndl/terms/holdingIssues"></see></summary>
    let holdingIssues = _prefix "holdingIssues"
    /// <summary>
    /// 当該情報資源が属する刊行物の通号
    /// <see href="http://ndl.go.jp/dcndl/terms/issue"></see></summary>
    let issue = _prefix "issue"
    /// <summary>
    /// をも見よ参照（新称）
    /// <see href="http://ndl.go.jp/dcndl/terms/laterName"></see></summary>
    let laterName = _prefix "laterName"
    /// <summary>
    /// 請求記号
    /// <see href="http://ndl.go.jp/dcndl/terms/localCallNumber"></see></summary>
    let localCallNumber = _prefix "localCallNumber"
    /// <summary>
    /// 出版者の所在に関する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// 資料種別
    /// <see href="http://ndl.go.jp/dcndl/terms/materialType"></see></summary>
    let materialType = _prefix "materialType"
    /// <summary>
    /// 国立国会図書館件名標目表
    /// <see href="http://ndl.go.jp/dcndl/terms/ndlsh"></see></summary>
    let ndlsh = _prefix "ndlsh"
    /// <summary>
    /// 当該情報資源が属する刊行物の号
    /// <see href="http://ndl.go.jp/dcndl/terms/number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    /// 原文の言語
    /// <see href="http://ndl.go.jp/dcndl/terms/originalLanguage"></see></summary>
    let originalLanguage = _prefix "originalLanguage"
    /// <summary>
    /// 当該情報資源が掲載されているページの範囲
    /// <see href="http://ndl.go.jp/dcndl/terms/pageRange"></see></summary>
    let pageRange = _prefix "pageRange"
    /// <summary>
    /// 単行書の構成レベルの各著作に著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/partCreator"></see></summary>
    let partCreator = _prefix "partCreator"
    /// <summary>
    /// Part Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/partCreatorTranscription"></see></summary>
    let partCreatorTranscription = _prefix "partCreatorTranscription"
    /// <summary>
    /// 単行書の構成レベルに相当する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/partInformation"></see></summary>
    let partInformation = _prefix "partInformation"
    /// <summary>
    /// 単行書の構成レベルに相当する各著作のタイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/partTitle"></see></summary>
    let partTitle = _prefix "partTitle"
    /// <summary>
    /// Part Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/partTitleTranscription"></see></summary>
    let partTitleTranscription = _prefix "partTitleTranscription"
    /// <summary>
    /// をも見よ参照（旧称）
    /// <see href="http://ndl.go.jp/dcndl/terms/previousName"></see></summary>
    let previousName = _prefix "previousName"
    /// <summary>
    /// 販売価格
    /// <see href="http://ndl.go.jp/dcndl/terms/price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    /// 当該情報資源の属する刊行物名
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationName"></see></summary>
    let publicationName = _prefix "publicationName"
    /// <summary>
    /// 逐次刊行物の刊行頻度
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationPeriodicity"></see></summary>
    let publicationPeriodicity = _prefix "publicationPeriodicity"
    /// <summary>
    /// 出版地・頒布地
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationPlace"></see></summary>
    let publicationPlace = _prefix "publicationPlace"
    /// <summary>
    /// 逐次刊行物の刊行状態
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationStatus"></see></summary>
    let publicationStatus = _prefix "publicationStatus"
    /// <summary>
    /// 当該情報資源の属する刊行物の巻
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationVolume"></see></summary>
    let publicationVolume = _prefix "publicationVolume"
    /// <summary>
    /// Publisherの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/publisherTranscription"></see></summary>
    let publisherTranscription = _prefix "publisherTranscription"
    /// <summary>
    /// をも見よ参照（本名）
    /// <see href="http://ndl.go.jp/dcndl/terms/realName"></see></summary>
    let realName = _prefix "realName"
    /// <summary>
    /// 参照先に関係のあるメタデータを持つ
    /// <see href="http://ndl.go.jp/dcndl/terms/record"></see></summary>
    let record = _prefix "record"
    /// <summary>
    /// 当該レコードの状態
    /// <see href="http://ndl.go.jp/dcndl/terms/recordStatus"></see></summary>
    let recordStatus = _prefix "recordStatus"
    /// <summary>
    /// 別シリーズタイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesAlternative"></see></summary>
    let seriesAlternative = _prefix "seriesAlternative"
    /// <summary>
    /// Series Alternativeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesAlternativeTranscription"></see></summary>
    let seriesAlternativeTranscription = _prefix "seriesAlternativeTranscription"
    /// <summary>
    /// 当該情報資源が属するシリーズに対し著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesCreator"></see></summary>
    let seriesCreator = _prefix "seriesCreator"
    /// <summary>
    /// Series Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesCreatorTranscription"></see></summary>
    let seriesCreatorTranscription = _prefix "seriesCreatorTranscription"
    /// <summary>
    /// シリーズタイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesTitle"></see></summary>
    let seriesTitle = _prefix "seriesTitle"
    /// <summary>
    /// Series Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesTitleTranscription"></see></summary>
    let seriesTitleTranscription = _prefix "seriesTitleTranscription"
    /// <summary>
    /// シリーズの巻次又は部編番号
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolume"></see></summary>
    let seriesVolume = _prefix "seriesVolume"
    /// <summary>
    /// シリーズの部編名
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitle"></see></summary>
    let seriesVolumeTitle = _prefix "seriesVolumeTitle"
    /// <summary>
    /// Series Volume Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitleTranscription"></see></summary>
    let seriesVolumeTitleTranscription = _prefix "seriesVolumeTitleTranscription"
    /// <summary>
    /// Series Volumeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolumeTranscription"></see></summary>
    let seriesVolumeTranscription = _prefix "seriesVolumeTranscription"
    /// <summary>
    /// 総合目録参加館における管理番号
    /// <see href="http://ndl.go.jp/dcndl/terms/somokuBibID"></see></summary>
    let somokuBibID = _prefix "somokuBibID"
    /// <summary>
    /// 総合目録参加館における図書登録番号
    /// <see href="http://ndl.go.jp/dcndl/terms/somokuSubID"></see></summary>
    let somokuSubID = _prefix "somokuSubID"
    /// <summary>
    /// 原資料の識別子
    /// <see href="http://ndl.go.jp/dcndl/terms/sourceIdentifier"></see></summary>
    let sourceIdentifier = _prefix "sourceIdentifier"
    /// <summary>
    /// Subjectの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/subjectTranscription"></see></summary>
    let subjectTranscription = _prefix "subjectTranscription"
    /// <summary>
    /// Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/titleTranscription"></see></summary>
    let titleTranscription = _prefix "titleTranscription"
    /// <summary>
    /// 統一タイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/uniformTitle"></see></summary>
    let uniformTitle = _prefix "uniformTitle"
    /// <summary>
    /// 巻次又は部編番号
    /// <see href="http://ndl.go.jp/dcndl/terms/volume"></see></summary>
    let volume = _prefix "volume"
    /// <summary>
    /// 当該情報資源の当該する巻又は部編に対し著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeCreator"></see></summary>
    let volumeCreator = _prefix "volumeCreator"
    /// <summary>
    /// Volume Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeCreatorTranscription"></see></summary>
    let volumeCreatorTranscription = _prefix "volumeCreatorTranscription"
    /// <summary>
    /// 逐次刊行物の初号から終号までの巻次及び年月次
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeRange"></see></summary>
    let volumeRange = _prefix "volumeRange"
    /// <summary>
    /// 多巻ものの各巻タイトル又は逐次刊行物の部編名
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeTitle"></see></summary>
    let volumeTitle = _prefix "volumeTitle"
    /// <summary>
    /// Volume Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeTitleTranscription"></see></summary>
    let volumeTitleTranscription = _prefix "volumeTitleTranscription"
    /// <summary>
    /// Volumeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeTranscription"></see></summary>
    let volumeTranscription = _prefix "volumeTranscription"
