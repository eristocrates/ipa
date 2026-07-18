namespace http.ndl.go.jp.dcndl.terms.slash

open DoxAletheia.Rdf_Vocabulary

module dcndl =
    let _namespace_name = "http://ndl.go.jp/dcndl/terms/"

    /// <summary>
    /// 読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/transcription"></see></summary>
    let transcription =
        Namespaced_IRI.parse _namespace_name "transcription" |> NamespacedName

    /// <summary>
    /// 点字図書・録音図書全国総合目録番号
    /// <see href="http://ndl.go.jp/dcndl/terms/BRNO"></see></summary>
    let BRNO = Namespaced_IRI.parse _namespace_name "BRNO" |> NamespacedName
    /// <summary>
    /// 基本件名標目表
    /// <see href="http://ndl.go.jp/dcndl/terms/BSH"></see></summary>
    let BSH = Namespaced_IRI.parse _namespace_name "BSH" |> NamespacedName

    /// <summary>
    /// 管理情報のクラス
    /// <see href="http://ndl.go.jp/dcndl/terms/BibAdminResource"></see></summary>
    let BibAdminResource =
        Namespaced_IRI.parse _namespace_name "BibAdminResource" |> NamespacedName

    /// <summary>
    /// 書誌情報のクラス
    /// <see href="http://ndl.go.jp/dcndl/terms/BibResource"></see></summary>
    let BibResource =
        Namespaced_IRI.parse _namespace_name "BibResource" |> NamespacedName

    /// <summary>
    /// Code Designated
    /// <see href="http://ndl.go.jp/dcndl/terms/CODEN"></see></summary>
    let CODEN = Namespaced_IRI.parse _namespace_name "CODEN" |> NamespacedName
    /// <summary>
    /// Digital Object Identifier
    /// <see href="http://ndl.go.jp/dcndl/terms/DOI"></see></summary>
    let DOI = Namespaced_IRI.parse _namespace_name "DOI" |> NamespacedName
    /// <summary>
    /// ISBNエラーコード
    /// <see href="http://ndl.go.jp/dcndl/terms/ErrorISBN"></see></summary>
    let ErrorISBN = Namespaced_IRI.parse _namespace_name "ErrorISBN" |> NamespacedName
    /// <summary>
    /// GHQ/SCAP分類表
    /// <see href="http://ndl.go.jp/dcndl/terms/GHQSCAP"></see></summary>
    let GHQSCAP = Namespaced_IRI.parse _namespace_name "GHQSCAP" |> NamespacedName
    /// <summary>
    /// GPO書誌番号
    /// <see href="http://ndl.go.jp/dcndl/terms/GPOBibNO"></see></summary>
    let GPOBibNO = Namespaced_IRI.parse _namespace_name "GPOBibNO" |> NamespacedName
    /// <summary>
    /// GPO管理番号
    /// <see href="http://ndl.go.jp/dcndl/terms/GPOCN"></see></summary>
    let GPOCN = Namespaced_IRI.parse _namespace_name "GPOCN" |> NamespacedName
    /// <summary>
    /// 国際海図番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ICNO"></see></summary>
    let ICNO = Namespaced_IRI.parse _namespace_name "ICNO" |> NamespacedName
    /// <summary>
    /// International Standard Book Number : 国際標準図書番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISBN"></see></summary>
    let ISBN = Namespaced_IRI.parse _namespace_name "ISBN" |> NamespacedName
    /// <summary>
    /// International standard identifier for libraries and related organizations : 図書館及び関連組織のための国際標準識別子
    /// <see href="http://ndl.go.jp/dcndl/terms/ISIL"></see></summary>
    let ISIL = Namespaced_IRI.parse _namespace_name "ISIL" |> NamespacedName
    /// <summary>
    /// International Standard Music Number : 国際標準楽譜番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISMN"></see></summary>
    let ISMN = Namespaced_IRI.parse _namespace_name "ISMN" |> NamespacedName
    /// <summary>
    /// International Standard technical Report Number : 国際標準テクニカルリポート番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISRN"></see></summary>
    let ISRN = Namespaced_IRI.parse _namespace_name "ISRN" |> NamespacedName
    /// <summary>
    /// International Standard Serial Number : 国際標準逐次刊行物番号
    /// <see href="http://ndl.go.jp/dcndl/terms/ISSN"></see></summary>
    let ISSN = Namespaced_IRI.parse _namespace_name "ISSN" |> NamespacedName
    /// <summary>
    /// Linking ISSN
    /// <see href="http://ndl.go.jp/dcndl/terms/ISSNL"></see></summary>
    let ISSNL = Namespaced_IRI.parse _namespace_name "ISSNL" |> NamespacedName

    /// <summary>
    /// ISSNエラーコード
    /// <see href="http://ndl.go.jp/dcndl/terms/IncorrectISSN"></see></summary>
    let IncorrectISSN =
        Namespaced_IRI.parse _namespace_name "IncorrectISSN" |> NamespacedName

    /// <summary>
    /// ISSN-Lエラーコード
    /// <see href="http://ndl.go.jp/dcndl/terms/IncorrectISSNL"></see></summary>
    let IncorrectISSNL =
        Namespaced_IRI.parse _namespace_name "IncorrectISSNL" |> NamespacedName

    /// <summary>
    /// 個体情報のクラス
    /// <see href="http://ndl.go.jp/dcndl/terms/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// 国名コード
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0304"></see></summary>
    let JISX0304 = Namespaced_IRI.parse _namespace_name "JISX0304" |> NamespacedName
    /// <summary>
    /// 全国地方公共団体コード（5桁）
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0402"></see></summary>
    let JISX0402 = Namespaced_IRI.parse _namespace_name "JISX0402" |> NamespacedName
    /// <summary>
    /// 大学・高等専門学校コード
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0408"></see></summary>
    let JISX0408 = Namespaced_IRI.parse _namespace_name "JISX0408" |> NamespacedName
    /// <summary>
    /// 標準地域メッシュコード
    /// <see href="http://ndl.go.jp/dcndl/terms/JISX0410"></see></summary>
    let JISX0410 = Namespaced_IRI.parse _namespace_name "JISX0410" |> NamespacedName
    /// <summary>
    /// 日本全国書誌番号（JP番号）
    /// <see href="http://ndl.go.jp/dcndl/terms/JPNO"></see></summary>
    let JPNO = Namespaced_IRI.parse _namespace_name "JPNO" |> NamespacedName
    /// <summary>
    /// 文部科学省科学研究費補助金研究の課題番号
    /// <see href="http://ndl.go.jp/dcndl/terms/KAKENHINO"></see></summary>
    let KAKENHINO = Namespaced_IRI.parse _namespace_name "KAKENHINO" |> NamespacedName
    /// <summary>
    /// 紀伊国屋MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/KNMARCNO"></see></summary>
    let KNMARCNO = Namespaced_IRI.parse _namespace_name "KNMARCNO" |> NamespacedName
    /// <summary>
    /// MCJ地理コード
    /// <see href="http://ndl.go.jp/dcndl/terms/MCJ"></see></summary>
    let MCJ = Namespaced_IRI.parse _namespace_name "MCJ" |> NamespacedName
    /// <summary>
    /// 各国国内海図番号
    /// <see href="http://ndl.go.jp/dcndl/terms/NCNO"></see></summary>
    let NCNO = Namespaced_IRI.parse _namespace_name "NCNO" |> NamespacedName
    /// <summary>
    /// 日本十進分類法
    /// <see href="http://ndl.go.jp/dcndl/terms/NDC"></see></summary>
    let NDC = Namespaced_IRI.parse _namespace_name "NDC" |> NamespacedName
    /// <summary>
    /// 日本十進分類法新訂8版
    /// <see href="http://ndl.go.jp/dcndl/terms/NDC8"></see></summary>
    let NDC8 = Namespaced_IRI.parse _namespace_name "NDC8" |> NamespacedName
    /// <summary>
    /// 国立国会図書館書誌ID
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLBibID"></see></summary>
    let NDLBibID = Namespaced_IRI.parse _namespace_name "NDLBibID" |> NamespacedName
    /// <summary>
    /// 国立国会図書館分類表
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLC"></see></summary>
    let NDLC = Namespaced_IRI.parse _namespace_name "NDLC" |> NamespacedName
    /// <summary>
    /// 国立国会図書館で付与した永続的識別子
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLJP"></see></summary>
    let NDLJP = Namespaced_IRI.parse _namespace_name "NDLJP" |> NamespacedName
    /// <summary>
    /// 国立国会図書館名称典拠（個人名、団体名、家族名、統一タイトル及び地名）
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLNA"></see></summary>
    let NDLNA = Namespaced_IRI.parse _namespace_name "NDLNA" |> NamespacedName
    /// <summary>
    /// NDL Typeで規定した情報資源の種別
    /// <see href="http://ndl.go.jp/dcndl/terms/NDLType"></see></summary>
    let NDLType = Namespaced_IRI.parse _namespace_name "NDLType" |> NamespacedName
    /// <summary>
    /// NACSIS-CAT書誌レコード番号
    /// <see href="http://ndl.go.jp/dcndl/terms/NIIBibID"></see></summary>
    let NIIBibID = Namespaced_IRI.parse _namespace_name "NIIBibID" |> NamespacedName
    /// <summary>
    /// 国立情報学研究所メタデータ主題語彙集
    /// <see href="http://ndl.go.jp/dcndl/terms/NIISubject"></see></summary>
    let NIISubject = Namespaced_IRI.parse _namespace_name "NIISubject" |> NamespacedName
    /// <summary>
    /// 国立情報学研究所メタデータ主題語彙集（資源タイプ）
    /// <see href="http://ndl.go.jp/dcndl/terms/NIIType"></see></summary>
    let NIIType = Namespaced_IRI.parse _namespace_name "NIIType" |> NamespacedName
    /// <summary>
    /// 日販MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/NSMARCNO"></see></summary>
    let NSMARCNO = Namespaced_IRI.parse _namespace_name "NSMARCNO" |> NamespacedName
    /// <summary>
    /// OCLC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/OCLCNO"></see></summary>
    let OCLCNO = Namespaced_IRI.parse _namespace_name "OCLCNO" |> NamespacedName
    /// <summary>
    /// 大阪屋MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/OPLMARCNO"></see></summary>
    let OPLMARCNO = Namespaced_IRI.parse _namespace_name "OPLMARCNO" |> NamespacedName
    /// <summary>
    /// 出版者番号（楽譜）
    /// <see href="http://ndl.go.jp/dcndl/terms/PBNO"></see></summary>
    let PBNO = Namespaced_IRI.parse _namespace_name "PBNO" |> NamespacedName
    /// <summary>
    /// プレート番号（楽譜）
    /// <see href="http://ndl.go.jp/dcndl/terms/PLNO"></see></summary>
    let PLNO = Namespaced_IRI.parse _namespace_name "PLNO" |> NamespacedName
    /// <summary>
    /// レコード商品番号体系
    /// <see href="http://ndl.go.jp/dcndl/terms/RIS502"></see></summary>
    let RIS502 = Namespaced_IRI.parse _namespace_name "RIS502" |> NamespacedName
    /// <summary>
    /// RLIN番号
    /// <see href="http://ndl.go.jp/dcndl/terms/RLINNO"></see></summary>
    let RLINNO = Namespaced_IRI.parse _namespace_name "RLINNO" |> NamespacedName
    /// <summary>
    /// Serial Item and Contributor Identifier。雑誌記事の識別子。
    /// <see href="http://ndl.go.jp/dcndl/terms/SICI"></see></summary>
    let SICI = Namespaced_IRI.parse _namespace_name "SICI" |> NamespacedName
    /// <summary>
    /// 規格番号
    /// <see href="http://ndl.go.jp/dcndl/terms/StandardNO"></see></summary>
    let StandardNO = Namespaced_IRI.parse _namespace_name "StandardNO" |> NamespacedName
    /// <summary>
    /// TRC MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/TRCMARCNO"></see></summary>
    let TRCMARCNO = Namespaced_IRI.parse _namespace_name "TRCMARCNO" |> NamespacedName
    /// <summary>
    /// テクニカルリポート番号
    /// <see href="http://ndl.go.jp/dcndl/terms/TRNO"></see></summary>
    let TRNO = Namespaced_IRI.parse _namespace_name "TRNO" |> NamespacedName
    /// <summary>
    /// UK MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/UKMARCNO"></see></summary>
    let UKMARCNO = Namespaced_IRI.parse _namespace_name "UKMARCNO" |> NamespacedName
    /// <summary>
    /// 国際連合ドキュメント記号
    /// <see href="http://ndl.go.jp/dcndl/terms/UNDS"></see></summary>
    let UNDS = Namespaced_IRI.parse _namespace_name "UNDS" |> NamespacedName
    /// <summary>
    /// 国際連合セールス番号
    /// <see href="http://ndl.go.jp/dcndl/terms/UNSN"></see></summary>
    let UNSN = Namespaced_IRI.parse _namespace_name "UNSN" |> NamespacedName
    /// <summary>
    /// USCAR資料分類表
    /// <see href="http://ndl.go.jp/dcndl/terms/USCAR"></see></summary>
    let USCAR = Namespaced_IRI.parse _namespace_name "USCAR" |> NamespacedName
    /// <summary>
    /// US MARC番号
    /// <see href="http://ndl.go.jp/dcndl/terms/USMARCNO"></see></summary>
    let USMARCNO = Namespaced_IRI.parse _namespace_name "USMARCNO" |> NamespacedName
    /// <summary>
    /// ユニバーサル横メルカトル図法区画番号
    /// <see href="http://ndl.go.jp/dcndl/terms/UTMNO"></see></summary>
    let UTMNO = Namespaced_IRI.parse _namespace_name "UTMNO" |> NamespacedName

    /// <summary>
    /// 所蔵する逐次刊行物の欠号に関する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/absentIssues"></see></summary>
    let absentIssues =
        Namespaced_IRI.parse _namespace_name "absentIssues" |> NamespacedName

    /// <summary>
    /// 別タイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/alternative"></see></summary>
    let alternative =
        Namespaced_IRI.parse _namespace_name "alternative" |> NamespacedName

    /// <summary>
    /// Alternativeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeTranscription"></see></summary>
    let alternativeTranscription =
        Namespaced_IRI.parse _namespace_name "alternativeTranscription" |> NamespacedName

    /// <summary>
    /// 別タイトル部編番号
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolume"></see></summary>
    let alternativeVolume =
        Namespaced_IRI.parse _namespace_name "alternativeVolume" |> NamespacedName

    /// <summary>
    /// 別タイトル部編名
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitle"></see></summary>
    let alternativeVolumeTitle =
        Namespaced_IRI.parse _namespace_name "alternativeVolumeTitle" |> NamespacedName

    /// <summary>
    /// Alternative Volume Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitleTranscription"></see></summary>
    let alternativeVolumeTitleTranscription =
        Namespaced_IRI.parse _namespace_name "alternativeVolumeTitleTranscription" |> NamespacedName

    /// <summary>
    /// Alternative Volumeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTranscription"></see></summary>
    let alternativeVolumeTranscription =
        Namespaced_IRI.parse _namespace_name "alternativeVolumeTranscription" |> NamespacedName

    /// <summary>
    /// をも見よ参照（別名）
    /// <see href="http://ndl.go.jp/dcndl/terms/anotherName"></see></summary>
    let anotherName =
        Namespaced_IRI.parse _namespace_name "anotherName" |> NamespacedName

    /// <summary>
    /// 当該情報資源の二次的・副次的な入手可能性
    /// <see href="http://ndl.go.jp/dcndl/terms/availability"></see></summary>
    let availability =
        Namespaced_IRI.parse _namespace_name "availability" |> NamespacedName

    /// <summary>
    /// メタデータのハーベスト元のデータベースに関する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/bibRecordCategory"></see></summary>
    let bibRecordCategory =
        Namespaced_IRI.parse _namespace_name "bibRecordCategory" |> NamespacedName

    /// <summary>
    /// dcndl:bibRecordCategoryの下位区分にあたる情報
    /// <see href="http://ndl.go.jp/dcndl/terms/bibRecordSubCategory"></see></summary>
    let bibRecordSubCategory =
        Namespaced_IRI.parse _namespace_name "bibRecordSubCategory" |> NamespacedName

    /// <summary>
    /// 請求記号
    /// <see href="http://ndl.go.jp/dcndl/terms/callNumber"></see></summary>
    let callNumber = Namespaced_IRI.parse _namespace_name "callNumber" |> NamespacedName

    /// <summary>
    /// 当該情報資源のメタデータ記述に採用した目録規則
    /// <see href="http://ndl.go.jp/dcndl/terms/catalogingRule"></see></summary>
    let catalogingRule =
        Namespaced_IRI.parse _namespace_name "catalogingRule" |> NamespacedName

    /// <summary>
    /// 書誌レコード作成のステータス
    /// <see href="http://ndl.go.jp/dcndl/terms/cataloguingStatus"></see></summary>
    let cataloguingStatus =
        Namespaced_IRI.parse _namespace_name "cataloguingStatus" |> NamespacedName

    /// <summary>
    /// Contributorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/contributorTranscription"></see></summary>
    let contributorTranscription =
        Namespaced_IRI.parse _namespace_name "contributorTranscription" |> NamespacedName

    /// <summary>
    /// Creatorの別名又は異なる形
    /// <see href="http://ndl.go.jp/dcndl/terms/creatorAlternative"></see></summary>
    let creatorAlternative =
        Namespaced_IRI.parse _namespace_name "creatorAlternative" |> NamespacedName

    /// <summary>
    /// Creator Alternativeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/creatorAlternativeTranscription"></see></summary>
    let creatorAlternativeTranscription =
        Namespaced_IRI.parse _namespace_name "creatorAlternativeTranscription" |> NamespacedName

    /// <summary>
    /// Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/creatorTranscription"></see></summary>
    let creatorTranscription =
        Namespaced_IRI.parse _namespace_name "creatorTranscription" |> NamespacedName

    /// <summary>
    /// 当該情報資源を採取・保存した日
    /// <see href="http://ndl.go.jp/dcndl/terms/dateCaptured"></see></summary>
    let dateCaptured =
        Namespaced_IRI.parse _namespace_name "dateCaptured" |> NamespacedName

    /// <summary>
    /// 当該情報資源をデジタル化した日付
    /// <see href="http://ndl.go.jp/dcndl/terms/dateDigitized"></see></summary>
    let dateDigitized =
        Namespaced_IRI.parse _namespace_name "dateDigitized" |> NamespacedName

    /// <summary>
    /// 当該情報資源の作成者が博士号を授与された年月日
    /// <see href="http://ndl.go.jp/dcndl/terms/dateGranted"></see></summary>
    let dateGranted =
        Namespaced_IRI.parse _namespace_name "dateGranted" |> NamespacedName

    /// <summary>
    /// 当該情報資源の作成者に博士号を授与した大学名
    /// <see href="http://ndl.go.jp/dcndl/terms/degreeGrantor"></see></summary>
    let degreeGrantor =
        Namespaced_IRI.parse _namespace_name "degreeGrantor" |> NamespacedName

    /// <summary>
    /// Degree Grantorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/degreeGrantorTranscription"></see></summary>
    let degreeGrantorTranscription =
        Namespaced_IRI.parse _namespace_name "degreeGrantorTranscription" |> NamespacedName

    /// <summary>
    /// 博士論文の学位分野名
    /// <see href="http://ndl.go.jp/dcndl/terms/degreeName"></see></summary>
    let degreeName = Namespaced_IRI.parse _namespace_name "degreeName" |> NamespacedName

    /// <summary>
    /// 当該情報資源をデジタル化した実体
    /// <see href="http://ndl.go.jp/dcndl/terms/digitizedPublisher"></see></summary>
    let digitizedPublisher =
        Namespaced_IRI.parse _namespace_name "digitizedPublisher" |> NamespacedName

    /// <summary>
    /// 博士論文の報告番号
    /// <see href="http://ndl.go.jp/dcndl/terms/dissertationNumber"></see></summary>
    let dissertationNumber =
        Namespaced_IRI.parse _namespace_name "dissertationNumber" |> NamespacedName

    /// <summary>
    /// 当該情報資源が属する版
    /// <see href="http://ndl.go.jp/dcndl/terms/edition"></see></summary>
    let edition = Namespaced_IRI.parse _namespace_name "edition" |> NamespacedName

    /// <summary>
    /// 当該情報資源が属する版に対し著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/editionCreator"></see></summary>
    let editionCreator =
        Namespaced_IRI.parse _namespace_name "editionCreator" |> NamespacedName

    /// <summary>
    /// Edition Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/editionCreatorTranscription"></see></summary>
    let editionCreatorTranscription =
        Namespaced_IRI.parse _namespace_name "editionCreatorTranscription" |> NamespacedName

    /// <summary>
    /// 当該情報資源の保有者
    /// <see href="http://ndl.go.jp/dcndl/terms/holdingAgent"></see></summary>
    let holdingAgent =
        Namespaced_IRI.parse _namespace_name "holdingAgent" |> NamespacedName

    /// <summary>
    /// 所蔵する逐次刊行物の巻次・年月次
    /// <see href="http://ndl.go.jp/dcndl/terms/holdingIssues"></see></summary>
    let holdingIssues =
        Namespaced_IRI.parse _namespace_name "holdingIssues" |> NamespacedName

    /// <summary>
    /// 当該情報資源が属する刊行物の通号
    /// <see href="http://ndl.go.jp/dcndl/terms/issue"></see></summary>
    let issue = Namespaced_IRI.parse _namespace_name "issue" |> NamespacedName
    /// <summary>
    /// をも見よ参照（新称）
    /// <see href="http://ndl.go.jp/dcndl/terms/laterName"></see></summary>
    let laterName = Namespaced_IRI.parse _namespace_name "laterName" |> NamespacedName

    /// <summary>
    /// 請求記号
    /// <see href="http://ndl.go.jp/dcndl/terms/localCallNumber"></see></summary>
    let localCallNumber =
        Namespaced_IRI.parse _namespace_name "localCallNumber" |> NamespacedName

    /// <summary>
    /// 出版者の所在に関する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// 資料種別
    /// <see href="http://ndl.go.jp/dcndl/terms/materialType"></see></summary>
    let materialType =
        Namespaced_IRI.parse _namespace_name "materialType" |> NamespacedName

    /// <summary>
    /// 国立国会図書館件名標目表
    /// <see href="http://ndl.go.jp/dcndl/terms/ndlsh"></see></summary>
    let ndlsh = Namespaced_IRI.parse _namespace_name "ndlsh" |> NamespacedName
    /// <summary>
    /// 当該情報資源が属する刊行物の号
    /// <see href="http://ndl.go.jp/dcndl/terms/number"></see></summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName

    /// <summary>
    /// 原文の言語
    /// <see href="http://ndl.go.jp/dcndl/terms/originalLanguage"></see></summary>
    let originalLanguage =
        Namespaced_IRI.parse _namespace_name "originalLanguage" |> NamespacedName

    /// <summary>
    /// 当該情報資源が掲載されているページの範囲
    /// <see href="http://ndl.go.jp/dcndl/terms/pageRange"></see></summary>
    let pageRange = Namespaced_IRI.parse _namespace_name "pageRange" |> NamespacedName

    /// <summary>
    /// 単行書の構成レベルの各著作に著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/partCreator"></see></summary>
    let partCreator =
        Namespaced_IRI.parse _namespace_name "partCreator" |> NamespacedName

    /// <summary>
    /// Part Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/partCreatorTranscription"></see></summary>
    let partCreatorTranscription =
        Namespaced_IRI.parse _namespace_name "partCreatorTranscription" |> NamespacedName

    /// <summary>
    /// 単行書の構成レベルに相当する情報
    /// <see href="http://ndl.go.jp/dcndl/terms/partInformation"></see></summary>
    let partInformation =
        Namespaced_IRI.parse _namespace_name "partInformation" |> NamespacedName

    /// <summary>
    /// 単行書の構成レベルに相当する各著作のタイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/partTitle"></see></summary>
    let partTitle = Namespaced_IRI.parse _namespace_name "partTitle" |> NamespacedName

    /// <summary>
    /// Part Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/partTitleTranscription"></see></summary>
    let partTitleTranscription =
        Namespaced_IRI.parse _namespace_name "partTitleTranscription" |> NamespacedName

    /// <summary>
    /// をも見よ参照（旧称）
    /// <see href="http://ndl.go.jp/dcndl/terms/previousName"></see></summary>
    let previousName =
        Namespaced_IRI.parse _namespace_name "previousName" |> NamespacedName

    /// <summary>
    /// 販売価格
    /// <see href="http://ndl.go.jp/dcndl/terms/price"></see></summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName

    /// <summary>
    /// 当該情報資源の属する刊行物名
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationName"></see></summary>
    let publicationName =
        Namespaced_IRI.parse _namespace_name "publicationName" |> NamespacedName

    /// <summary>
    /// 逐次刊行物の刊行頻度
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationPeriodicity"></see></summary>
    let publicationPeriodicity =
        Namespaced_IRI.parse _namespace_name "publicationPeriodicity" |> NamespacedName

    /// <summary>
    /// 出版地・頒布地
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationPlace"></see></summary>
    let publicationPlace =
        Namespaced_IRI.parse _namespace_name "publicationPlace" |> NamespacedName

    /// <summary>
    /// 逐次刊行物の刊行状態
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationStatus"></see></summary>
    let publicationStatus =
        Namespaced_IRI.parse _namespace_name "publicationStatus" |> NamespacedName

    /// <summary>
    /// 当該情報資源の属する刊行物の巻
    /// <see href="http://ndl.go.jp/dcndl/terms/publicationVolume"></see></summary>
    let publicationVolume =
        Namespaced_IRI.parse _namespace_name "publicationVolume" |> NamespacedName

    /// <summary>
    /// Publisherの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/publisherTranscription"></see></summary>
    let publisherTranscription =
        Namespaced_IRI.parse _namespace_name "publisherTranscription" |> NamespacedName

    /// <summary>
    /// をも見よ参照（本名）
    /// <see href="http://ndl.go.jp/dcndl/terms/realName"></see></summary>
    let realName = Namespaced_IRI.parse _namespace_name "realName" |> NamespacedName
    /// <summary>
    /// 参照先に関係のあるメタデータを持つ
    /// <see href="http://ndl.go.jp/dcndl/terms/record"></see></summary>
    let record = Namespaced_IRI.parse _namespace_name "record" |> NamespacedName

    /// <summary>
    /// 当該レコードの状態
    /// <see href="http://ndl.go.jp/dcndl/terms/recordStatus"></see></summary>
    let recordStatus =
        Namespaced_IRI.parse _namespace_name "recordStatus" |> NamespacedName

    /// <summary>
    /// 別シリーズタイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesAlternative"></see></summary>
    let seriesAlternative =
        Namespaced_IRI.parse _namespace_name "seriesAlternative" |> NamespacedName

    /// <summary>
    /// Series Alternativeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesAlternativeTranscription"></see></summary>
    let seriesAlternativeTranscription =
        Namespaced_IRI.parse _namespace_name "seriesAlternativeTranscription" |> NamespacedName

    /// <summary>
    /// 当該情報資源が属するシリーズに対し著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesCreator"></see></summary>
    let seriesCreator =
        Namespaced_IRI.parse _namespace_name "seriesCreator" |> NamespacedName

    /// <summary>
    /// Series Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesCreatorTranscription"></see></summary>
    let seriesCreatorTranscription =
        Namespaced_IRI.parse _namespace_name "seriesCreatorTranscription" |> NamespacedName

    /// <summary>
    /// シリーズタイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesTitle"></see></summary>
    let seriesTitle =
        Namespaced_IRI.parse _namespace_name "seriesTitle" |> NamespacedName

    /// <summary>
    /// Series Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesTitleTranscription"></see></summary>
    let seriesTitleTranscription =
        Namespaced_IRI.parse _namespace_name "seriesTitleTranscription" |> NamespacedName

    /// <summary>
    /// シリーズの巻次又は部編番号
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolume"></see></summary>
    let seriesVolume =
        Namespaced_IRI.parse _namespace_name "seriesVolume" |> NamespacedName

    /// <summary>
    /// シリーズの部編名
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitle"></see></summary>
    let seriesVolumeTitle =
        Namespaced_IRI.parse _namespace_name "seriesVolumeTitle" |> NamespacedName

    /// <summary>
    /// Series Volume Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitleTranscription"></see></summary>
    let seriesVolumeTitleTranscription =
        Namespaced_IRI.parse _namespace_name "seriesVolumeTitleTranscription" |> NamespacedName

    /// <summary>
    /// Series Volumeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/seriesVolumeTranscription"></see></summary>
    let seriesVolumeTranscription =
        Namespaced_IRI.parse _namespace_name "seriesVolumeTranscription" |> NamespacedName

    /// <summary>
    /// 総合目録参加館における管理番号
    /// <see href="http://ndl.go.jp/dcndl/terms/somokuBibID"></see></summary>
    let somokuBibID =
        Namespaced_IRI.parse _namespace_name "somokuBibID" |> NamespacedName

    /// <summary>
    /// 総合目録参加館における図書登録番号
    /// <see href="http://ndl.go.jp/dcndl/terms/somokuSubID"></see></summary>
    let somokuSubID =
        Namespaced_IRI.parse _namespace_name "somokuSubID" |> NamespacedName

    /// <summary>
    /// 原資料の識別子
    /// <see href="http://ndl.go.jp/dcndl/terms/sourceIdentifier"></see></summary>
    let sourceIdentifier =
        Namespaced_IRI.parse _namespace_name "sourceIdentifier" |> NamespacedName

    /// <summary>
    /// Subjectの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/subjectTranscription"></see></summary>
    let subjectTranscription =
        Namespaced_IRI.parse _namespace_name "subjectTranscription" |> NamespacedName

    /// <summary>
    /// Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/titleTranscription"></see></summary>
    let titleTranscription =
        Namespaced_IRI.parse _namespace_name "titleTranscription" |> NamespacedName

    /// <summary>
    /// 統一タイトル
    /// <see href="http://ndl.go.jp/dcndl/terms/uniformTitle"></see></summary>
    let uniformTitle =
        Namespaced_IRI.parse _namespace_name "uniformTitle" |> NamespacedName

    /// <summary>
    /// 巻次又は部編番号
    /// <see href="http://ndl.go.jp/dcndl/terms/volume"></see></summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName

    /// <summary>
    /// 当該情報資源の当該する巻又は部編に対し著作責任を持つ実体
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeCreator"></see></summary>
    let volumeCreator =
        Namespaced_IRI.parse _namespace_name "volumeCreator" |> NamespacedName

    /// <summary>
    /// Volume Creatorの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeCreatorTranscription"></see></summary>
    let volumeCreatorTranscription =
        Namespaced_IRI.parse _namespace_name "volumeCreatorTranscription" |> NamespacedName

    /// <summary>
    /// 逐次刊行物の初号から終号までの巻次及び年月次
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeRange"></see></summary>
    let volumeRange =
        Namespaced_IRI.parse _namespace_name "volumeRange" |> NamespacedName

    /// <summary>
    /// 多巻ものの各巻タイトル又は逐次刊行物の部編名
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeTitle"></see></summary>
    let volumeTitle =
        Namespaced_IRI.parse _namespace_name "volumeTitle" |> NamespacedName

    /// <summary>
    /// Volume Titleの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeTitleTranscription"></see></summary>
    let volumeTitleTranscription =
        Namespaced_IRI.parse _namespace_name "volumeTitleTranscription" |> NamespacedName

    /// <summary>
    /// Volumeの読み又は翻字形
    /// <see href="http://ndl.go.jp/dcndl/terms/volumeTranscription"></see></summary>
    let volumeTranscription =
        Namespaced_IRI.parse _namespace_name "volumeTranscription" |> NamespacedName
