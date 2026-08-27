namespace http.ndl.go.jp.dcndl.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcndl =
    let _namespace_iri = Namespace_Iri dcndl |> NamespaceIRI
    /// <summary>
    ///   <para>dcndl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Agent</para>
    ///   <para>"DC-NDLに関するお問い合わせは、standardization@ndl.go.jpまでお願いいたします。"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/">http://ndl.go.jp/dcndl/terms/</seealso>
    let _prefix_iri = Prefixed_Name(dcndl, "") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:BRNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"点字図書・録音図書全国総合目録番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Braille And Audio Book Union Catalogue NO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/BRNO">http://ndl.go.jp/dcndl/terms/BRNO</seealso>
    let BRNO = Prefixed_Name(dcndl, "BRNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:BSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"基本件名標目表"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BSH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/BSH">http://ndl.go.jp/dcndl/terms/BSH</seealso>
    let BSH = Prefixed_Name(dcndl, "BSH") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:BibAdminResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"管理情報のクラス"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bib Admin Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/BibAdminResource">http://ndl.go.jp/dcndl/terms/BibAdminResource</seealso>
    let BibAdminResource = Prefixed_Name(dcndl, "BibAdminResource") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:BibResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"書誌情報のクラス"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bib Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/BibResource">http://ndl.go.jp/dcndl/terms/BibResource</seealso>
    let BibResource = Prefixed_Name(dcndl, "BibResource") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:CODEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Code Designated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CODEN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/CODEN">http://ndl.go.jp/dcndl/terms/CODEN</seealso>
    let CODEN = Prefixed_Name(dcndl, "CODEN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:DOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Digital Object Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/DOI">http://ndl.go.jp/dcndl/terms/DOI</seealso>
    let DOI = Prefixed_Name(dcndl, "DOI") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ErrorISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"ISBNエラーコード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Error ISBN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ErrorISBN">http://ndl.go.jp/dcndl/terms/ErrorISBN</seealso>
    let ErrorISBN = Prefixed_Name(dcndl, "ErrorISBN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:GHQSCAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"GHQ/SCAP分類表"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GHQSCAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/GHQSCAP">http://ndl.go.jp/dcndl/terms/GHQSCAP</seealso>
    let GHQSCAP = Prefixed_Name(dcndl, "GHQSCAP") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:GPOBibNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"GPO書誌番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GPO Bibliographic Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/GPOBibNO">http://ndl.go.jp/dcndl/terms/GPOBibNO</seealso>
    let GPOBibNO = Prefixed_Name(dcndl, "GPOBibNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:GPOCN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"GPO管理番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GPO Control Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/GPOCN">http://ndl.go.jp/dcndl/terms/GPOCN</seealso>
    let GPOCN = Prefixed_Name(dcndl, "GPOCN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ICNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"国際海図番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"International Chart NO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ICNO">http://ndl.go.jp/dcndl/terms/ICNO</seealso>
    let ICNO = Prefixed_Name(dcndl, "ICNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"International Standard Book Number : 国際標準図書番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISBN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ISBN">http://ndl.go.jp/dcndl/terms/ISBN</seealso>
    let ISBN = Prefixed_Name(dcndl, "ISBN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ISIL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"International standard identifier for libraries and related organizations : 図書館及び関連組織のための国際標準識別子"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISIL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ISIL">http://ndl.go.jp/dcndl/terms/ISIL</seealso>
    let ISIL = Prefixed_Name(dcndl, "ISIL") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ISMN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"International Standard Music Number : 国際標準楽譜番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISMN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ISMN">http://ndl.go.jp/dcndl/terms/ISMN</seealso>
    let ISMN = Prefixed_Name(dcndl, "ISMN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ISRN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"International Standard technical Report Number : 国際標準テクニカルリポート番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISRN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ISRN">http://ndl.go.jp/dcndl/terms/ISRN</seealso>
    let ISRN = Prefixed_Name(dcndl, "ISRN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ISSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"International Standard Serial Number : 国際標準逐次刊行物番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISSN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ISSN">http://ndl.go.jp/dcndl/terms/ISSN</seealso>
    let ISSN = Prefixed_Name(dcndl, "ISSN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ISSNL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Linking ISSN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISSN-L"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ISSNL">http://ndl.go.jp/dcndl/terms/ISSNL</seealso>
    let ISSNL = Prefixed_Name(dcndl, "ISSNL") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:IncorrectISSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"ISSNエラーコード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incorrect ISSN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/IncorrectISSN">http://ndl.go.jp/dcndl/terms/IncorrectISSN</seealso>
    let IncorrectISSN = Prefixed_Name(dcndl, "IncorrectISSN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:IncorrectISSNL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"ISSN-Lエラーコード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incorrect ISSN-L"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/IncorrectISSNL">http://ndl.go.jp/dcndl/terms/IncorrectISSNL</seealso>
    let IncorrectISSNL = Prefixed_Name(dcndl, "IncorrectISSNL") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"個体情報のクラス"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/Item">http://ndl.go.jp/dcndl/terms/Item</seealso>
    let Item = Prefixed_Name(dcndl, "Item") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:JISX0304</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"国名コード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JIS X 0304"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/JISX0304">http://ndl.go.jp/dcndl/terms/JISX0304</seealso>
    let JISX0304 = Prefixed_Name(dcndl, "JISX0304") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:JISX0402</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"全国地方公共団体コード（5桁）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JIS X 0402"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/JISX0402">http://ndl.go.jp/dcndl/terms/JISX0402</seealso>
    let JISX0402 = Prefixed_Name(dcndl, "JISX0402") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:JISX0408</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"大学・高等専門学校コード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JIS X 0408"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/JISX0408">http://ndl.go.jp/dcndl/terms/JISX0408</seealso>
    let JISX0408 = Prefixed_Name(dcndl, "JISX0408") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:JISX0410</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"標準地域メッシュコード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JIS X 0410"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/JISX0410">http://ndl.go.jp/dcndl/terms/JISX0410</seealso>
    let JISX0410 = Prefixed_Name(dcndl, "JISX0410") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:JPNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"日本全国書誌番号（JP番号）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JP Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/JPNO">http://ndl.go.jp/dcndl/terms/JPNO</seealso>
    let JPNO = Prefixed_Name(dcndl, "JPNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:KAKENHINO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"文部科学省科学研究費補助金研究の課題番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KAKENHI Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/KAKENHINO">http://ndl.go.jp/dcndl/terms/KAKENHINO</seealso>
    let KAKENHINO = Prefixed_Name(dcndl, "KAKENHINO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:KNMARCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"紀伊国屋MARC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KN MARC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/KNMARCNO">http://ndl.go.jp/dcndl/terms/KNMARCNO</seealso>
    let KNMARCNO = Prefixed_Name(dcndl, "KNMARCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:MCJ</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"MCJ地理コード"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MCJ"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/MCJ">http://ndl.go.jp/dcndl/terms/MCJ</seealso>
    let MCJ = Prefixed_Name(dcndl, "MCJ") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"各国国内海図番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"National Chart Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NCNO">http://ndl.go.jp/dcndl/terms/NCNO</seealso>
    let NCNO = Prefixed_Name(dcndl, "NCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"日本十進分類法"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDC">http://ndl.go.jp/dcndl/terms/NDC</seealso>
    let NDC = Prefixed_Name(dcndl, "NDC") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDC8</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"日本十進分類法新訂8版"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDC(8)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDC8">http://ndl.go.jp/dcndl/terms/NDC8</seealso>
    let NDC8 = Prefixed_Name(dcndl, "NDC8") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDLBibID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"国立国会図書館書誌ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDL Bibliographic ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDLBibID">http://ndl.go.jp/dcndl/terms/NDLBibID</seealso>
    let NDLBibID = Prefixed_Name(dcndl, "NDLBibID") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"国立国会図書館分類表"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDLC">http://ndl.go.jp/dcndl/terms/NDLC</seealso>
    let NDLC = Prefixed_Name(dcndl, "NDLC") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDLJP</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"国立国会図書館で付与した永続的識別子"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDLJP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDLJP">http://ndl.go.jp/dcndl/terms/NDLJP</seealso>
    let NDLJP = Prefixed_Name(dcndl, "NDLJP") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDLNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"国立国会図書館名称典拠（個人名、団体名、家族名、統一タイトル及び地名）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDLNA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDLNA">http://ndl.go.jp/dcndl/terms/NDLNA</seealso>
    let NDLNA = Prefixed_Name(dcndl, "NDLNA") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NDLType</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"NDL Typeで規定した情報資源の種別"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDL Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NDLType">http://ndl.go.jp/dcndl/terms/NDLType</seealso>
    let NDLType = Prefixed_Name(dcndl, "NDLType") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NIIBibID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"NACSIS-CAT書誌レコード番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NII Bib ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NIIBibID">http://ndl.go.jp/dcndl/terms/NIIBibID</seealso>
    let NIIBibID = Prefixed_Name(dcndl, "NIIBibID") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NIISubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"国立情報学研究所メタデータ主題語彙集"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NII Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NIISubject">http://ndl.go.jp/dcndl/terms/NIISubject</seealso>
    let NIISubject = Prefixed_Name(dcndl, "NIISubject") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NIIType</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"国立情報学研究所メタデータ主題語彙集（資源タイプ）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NII Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NIIType">http://ndl.go.jp/dcndl/terms/NIIType</seealso>
    let NIIType = Prefixed_Name(dcndl, "NIIType") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:NSMARCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"日販MARC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NS-MARC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/NSMARCNO">http://ndl.go.jp/dcndl/terms/NSMARCNO</seealso>
    let NSMARCNO = Prefixed_Name(dcndl, "NSMARCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:OCLCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"OCLC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OCLC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/OCLCNO">http://ndl.go.jp/dcndl/terms/OCLCNO</seealso>
    let OCLCNO = Prefixed_Name(dcndl, "OCLCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:OPLMARCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"大阪屋MARC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OPL-MARC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/OPLMARCNO">http://ndl.go.jp/dcndl/terms/OPLMARCNO</seealso>
    let OPLMARCNO = Prefixed_Name(dcndl, "OPLMARCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:PBNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"出版者番号（楽譜）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PBNO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/PBNO">http://ndl.go.jp/dcndl/terms/PBNO</seealso>
    let PBNO = Prefixed_Name(dcndl, "PBNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:PLNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"プレート番号（楽譜）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PLNO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/PLNO">http://ndl.go.jp/dcndl/terms/PLNO</seealso>
    let PLNO = Prefixed_Name(dcndl, "PLNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:RIS502</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"レコード商品番号体系"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RIS 502"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/RIS502">http://ndl.go.jp/dcndl/terms/RIS502</seealso>
    let RIS502 = Prefixed_Name(dcndl, "RIS502") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:RLINNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"RLIN番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RLIN Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/RLINNO">http://ndl.go.jp/dcndl/terms/RLINNO</seealso>
    let RLINNO = Prefixed_Name(dcndl, "RLINNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:SICI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Serial Item and Contributor Identifier。雑誌記事の識別子。"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SICI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/SICI">http://ndl.go.jp/dcndl/terms/SICI</seealso>
    let SICI = Prefixed_Name(dcndl, "SICI") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:StandardNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"規格番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Standard Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/StandardNO">http://ndl.go.jp/dcndl/terms/StandardNO</seealso>
    let StandardNO = Prefixed_Name(dcndl, "StandardNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:TRCMARCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"TRC MARC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TRC MARC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/TRCMARCNO">http://ndl.go.jp/dcndl/terms/TRCMARCNO</seealso>
    let TRCMARCNO = Prefixed_Name(dcndl, "TRCMARCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:TRNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"テクニカルリポート番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TR Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/TRNO">http://ndl.go.jp/dcndl/terms/TRNO</seealso>
    let TRNO = Prefixed_Name(dcndl, "TRNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:UKMARCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"UK MARC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UK MARC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/UKMARCNO">http://ndl.go.jp/dcndl/terms/UKMARCNO</seealso>
    let UKMARCNO = Prefixed_Name(dcndl, "UKMARCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:UNDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"国際連合ドキュメント記号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"United Nations Document Symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/UNDS">http://ndl.go.jp/dcndl/terms/UNDS</seealso>
    let UNDS = Prefixed_Name(dcndl, "UNDS") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:UNSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"国際連合セールス番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"United Nations Sales Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/UNSN">http://ndl.go.jp/dcndl/terms/UNSN</seealso>
    let UNSN = Prefixed_Name(dcndl, "UNSN") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:USCAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"USCAR資料分類表"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USCAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/USCAR">http://ndl.go.jp/dcndl/terms/USCAR</seealso>
    let USCAR = Prefixed_Name(dcndl, "USCAR") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:USMARCNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"US MARC番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"US MARC Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/USMARCNO">http://ndl.go.jp/dcndl/terms/USMARCNO</seealso>
    let USMARCNO = Prefixed_Name(dcndl, "USMARCNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:UTMNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"ユニバーサル横メルカトル図法区画番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Universal Transverse Mercator Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/UTMNO">http://ndl.go.jp/dcndl/terms/UTMNO</seealso>
    let UTMNO = Prefixed_Name(dcndl, "UTMNO") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:absentIssues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"所蔵する逐次刊行物の欠号に関する情報"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absent Issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/absentIssues">http://ndl.go.jp/dcndl/terms/absentIssues</seealso>
    let absentIssues = Prefixed_Name(dcndl, "absentIssues") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"別タイトル"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alternative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/alternative">http://ndl.go.jp/dcndl/terms/alternative</seealso>
    let alternative = Prefixed_Name(dcndl, "alternative") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:alternativeTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Alternativeの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alternative Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/alternativeTranscription">http://ndl.go.jp/dcndl/terms/alternativeTranscription</seealso>
    let alternativeTranscription =
        Prefixed_Name(dcndl, "alternativeTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:alternativeVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"別タイトル部編番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alternative Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/alternativeVolume">http://ndl.go.jp/dcndl/terms/alternativeVolume</seealso>
    let alternativeVolume = Prefixed_Name(dcndl, "alternativeVolume") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:alternativeVolumeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"別タイトル部編名"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alternative Volume Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitle">http://ndl.go.jp/dcndl/terms/alternativeVolumeTitle</seealso>
    let alternativeVolumeTitle =
        Prefixed_Name(dcndl, "alternativeVolumeTitle") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:alternativeVolumeTitleTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Alternative Volume Titleの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alternative Volume Title Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTitleTranscription">http://ndl.go.jp/dcndl/terms/alternativeVolumeTitleTranscription</seealso>
    let alternativeVolumeTitleTranscription =
        Prefixed_Name(dcndl, "alternativeVolumeTitleTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:alternativeVolumeTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Alternative Volumeの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alternative Volume Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/alternativeVolumeTranscription">http://ndl.go.jp/dcndl/terms/alternativeVolumeTranscription</seealso>
    let alternativeVolumeTranscription =
        Prefixed_Name(dcndl, "alternativeVolumeTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:anotherName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"をも見よ参照（別名）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Another Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/anotherName">http://ndl.go.jp/dcndl/terms/anotherName</seealso>
    let anotherName = Prefixed_Name(dcndl, "anotherName") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の二次的・副次的な入手可能性"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Availability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/availability">http://ndl.go.jp/dcndl/terms/availability</seealso>
    let availability = Prefixed_Name(dcndl, "availability") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:bibRecordCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"メタデータのハーベスト元のデータベースに関する情報"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bibliographic Record Category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/bibRecordCategory">http://ndl.go.jp/dcndl/terms/bibRecordCategory</seealso>
    let bibRecordCategory = Prefixed_Name(dcndl, "bibRecordCategory") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:bibRecordSubCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"dcndl:bibRecordCategoryの下位区分にあたる情報"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bibliographic Record Sub Category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/bibRecordSubCategory">http://ndl.go.jp/dcndl/terms/bibRecordSubCategory</seealso>
    let bibRecordSubCategory =
        Prefixed_Name(dcndl, "bibRecordSubCategory") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:callNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"請求記号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Call Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/callNumber">http://ndl.go.jp/dcndl/terms/callNumber</seealso>
    let callNumber = Prefixed_Name(dcndl, "callNumber") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:catalogingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源のメタデータ記述に採用した目録規則"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cataloging Rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/catalogingRule">http://ndl.go.jp/dcndl/terms/catalogingRule</seealso>
    let catalogingRule = Prefixed_Name(dcndl, "catalogingRule") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:cataloguingStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"書誌レコード作成のステータス"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cataloguing Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/cataloguingStatus">http://ndl.go.jp/dcndl/terms/cataloguingStatus</seealso>
    let cataloguingStatus = Prefixed_Name(dcndl, "cataloguingStatus") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:contributorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Contributorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contributor Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/contributorTranscription">http://ndl.go.jp/dcndl/terms/contributorTranscription</seealso>
    let contributorTranscription =
        Prefixed_Name(dcndl, "contributorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:creatorAlternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Creatorの別名又は異なる形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Creator Alternative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/creatorAlternative">http://ndl.go.jp/dcndl/terms/creatorAlternative</seealso>
    let creatorAlternative = Prefixed_Name(dcndl, "creatorAlternative") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:creatorAlternativeTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Creator Alternativeの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Creator Alternative Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/creatorAlternativeTranscription">http://ndl.go.jp/dcndl/terms/creatorAlternativeTranscription</seealso>
    let creatorAlternativeTranscription =
        Prefixed_Name(dcndl, "creatorAlternativeTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:creatorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Creatorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Creator Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/creatorTranscription">http://ndl.go.jp/dcndl/terms/creatorTranscription</seealso>
    let creatorTranscription =
        Prefixed_Name(dcndl, "creatorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:dateCaptured</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源を採取・保存した日"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date Captured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/dateCaptured">http://ndl.go.jp/dcndl/terms/dateCaptured</seealso>
    let dateCaptured = Prefixed_Name(dcndl, "dateCaptured") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:dateDigitized</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源をデジタル化した日付"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date Digitized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/dateDigitized">http://ndl.go.jp/dcndl/terms/dateDigitized</seealso>
    let dateDigitized = Prefixed_Name(dcndl, "dateDigitized") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:dateGranted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の作成者が博士号を授与された年月日"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date Granted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/dateGranted">http://ndl.go.jp/dcndl/terms/dateGranted</seealso>
    let dateGranted = Prefixed_Name(dcndl, "dateGranted") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:degreeGrantor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の作成者に博士号を授与した大学名"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Degree Grantor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/degreeGrantor">http://ndl.go.jp/dcndl/terms/degreeGrantor</seealso>
    let degreeGrantor = Prefixed_Name(dcndl, "degreeGrantor") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:degreeGrantorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Degree Grantorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Degree Grantor Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/degreeGrantorTranscription">http://ndl.go.jp/dcndl/terms/degreeGrantorTranscription</seealso>
    let degreeGrantorTranscription =
        Prefixed_Name(dcndl, "degreeGrantorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:degreeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"博士論文の学位分野名"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Degree Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/degreeName">http://ndl.go.jp/dcndl/terms/degreeName</seealso>
    let degreeName = Prefixed_Name(dcndl, "degreeName") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:digitizedPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源をデジタル化した実体"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Digitized Publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/digitizedPublisher">http://ndl.go.jp/dcndl/terms/digitizedPublisher</seealso>
    let digitizedPublisher = Prefixed_Name(dcndl, "digitizedPublisher") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:dissertationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"博士論文の報告番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dissertation Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/dissertationNumber">http://ndl.go.jp/dcndl/terms/dissertationNumber</seealso>
    let dissertationNumber = Prefixed_Name(dcndl, "dissertationNumber") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源が属する版"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Edition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/edition">http://ndl.go.jp/dcndl/terms/edition</seealso>
    let edition = Prefixed_Name(dcndl, "edition") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:editionCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源が属する版に対し著作責任を持つ実体"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Edition Creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/editionCreator">http://ndl.go.jp/dcndl/terms/editionCreator</seealso>
    let editionCreator = Prefixed_Name(dcndl, "editionCreator") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:editionCreatorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Edition Creatorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Edition Creator Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/editionCreatorTranscription">http://ndl.go.jp/dcndl/terms/editionCreatorTranscription</seealso>
    let editionCreatorTranscription =
        Prefixed_Name(dcndl, "editionCreatorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:holdingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の保有者"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Holding Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/holdingAgent">http://ndl.go.jp/dcndl/terms/holdingAgent</seealso>
    let holdingAgent = Prefixed_Name(dcndl, "holdingAgent") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:holdingIssues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"所蔵する逐次刊行物の巻次・年月次"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Holding Issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/holdingIssues">http://ndl.go.jp/dcndl/terms/holdingIssues</seealso>
    let holdingIssues = Prefixed_Name(dcndl, "holdingIssues") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源が属する刊行物の通号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/issue">http://ndl.go.jp/dcndl/terms/issue</seealso>
    let issue = Prefixed_Name(dcndl, "issue") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:laterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"をも見よ参照（新称）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Later Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/laterName">http://ndl.go.jp/dcndl/terms/laterName</seealso>
    let laterName = Prefixed_Name(dcndl, "laterName") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:localCallNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"請求記号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Local Call Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/localCallNumber">http://ndl.go.jp/dcndl/terms/localCallNumber</seealso>
    let localCallNumber = Prefixed_Name(dcndl, "localCallNumber") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"出版者の所在に関する情報"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/location">http://ndl.go.jp/dcndl/terms/location</seealso>
    let location = Prefixed_Name(dcndl, "location") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:materialType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"資料種別"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/materialType">http://ndl.go.jp/dcndl/terms/materialType</seealso>
    let materialType = Prefixed_Name(dcndl, "materialType") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:ndlsh</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>"国立国会図書館件名標目表"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NDLSH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/ndlsh">http://ndl.go.jp/dcndl/terms/ndlsh</seealso>
    let ndlsh = Prefixed_Name(dcndl, "ndlsh") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源が属する刊行物の号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/number">http://ndl.go.jp/dcndl/terms/number</seealso>
    let number = Prefixed_Name(dcndl, "number") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:originalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"原文の言語"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Original Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/originalLanguage">http://ndl.go.jp/dcndl/terms/originalLanguage</seealso>
    let originalLanguage = Prefixed_Name(dcndl, "originalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:pageRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源が掲載されているページの範囲"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Page Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/pageRange">http://ndl.go.jp/dcndl/terms/pageRange</seealso>
    let pageRange = Prefixed_Name(dcndl, "pageRange") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:partCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"単行書の構成レベルの各著作に著作責任を持つ実体"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Part Creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/partCreator">http://ndl.go.jp/dcndl/terms/partCreator</seealso>
    let partCreator = Prefixed_Name(dcndl, "partCreator") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:partCreatorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Part Creatorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Part Creator Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/partCreatorTranscription">http://ndl.go.jp/dcndl/terms/partCreatorTranscription</seealso>
    let partCreatorTranscription =
        Prefixed_Name(dcndl, "partCreatorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:partInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"単行書の構成レベルに相当する情報"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Part Information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/partInformation">http://ndl.go.jp/dcndl/terms/partInformation</seealso>
    let partInformation = Prefixed_Name(dcndl, "partInformation") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:partTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"単行書の構成レベルに相当する各著作のタイトル"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Part Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/partTitle">http://ndl.go.jp/dcndl/terms/partTitle</seealso>
    let partTitle = Prefixed_Name(dcndl, "partTitle") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:partTitleTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Part Titleの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Part Title Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/partTitleTranscription">http://ndl.go.jp/dcndl/terms/partTitleTranscription</seealso>
    let partTitleTranscription =
        Prefixed_Name(dcndl, "partTitleTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:previousName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"をも見よ参照（旧称）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Previous Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/previousName">http://ndl.go.jp/dcndl/terms/previousName</seealso>
    let previousName = Prefixed_Name(dcndl, "previousName") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"販売価格"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/price">http://ndl.go.jp/dcndl/terms/price</seealso>
    let price = Prefixed_Name(dcndl, "price") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:publicationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の属する刊行物名"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/publicationName">http://ndl.go.jp/dcndl/terms/publicationName</seealso>
    let publicationName = Prefixed_Name(dcndl, "publicationName") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:publicationPeriodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"逐次刊行物の刊行頻度"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Periodicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/publicationPeriodicity">http://ndl.go.jp/dcndl/terms/publicationPeriodicity</seealso>
    let publicationPeriodicity =
        Prefixed_Name(dcndl, "publicationPeriodicity") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:publicationPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"出版地・頒布地"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/publicationPlace">http://ndl.go.jp/dcndl/terms/publicationPlace</seealso>
    let publicationPlace = Prefixed_Name(dcndl, "publicationPlace") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:publicationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"逐次刊行物の刊行状態"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/publicationStatus">http://ndl.go.jp/dcndl/terms/publicationStatus</seealso>
    let publicationStatus = Prefixed_Name(dcndl, "publicationStatus") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:publicationVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の属する刊行物の巻"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/publicationVolume">http://ndl.go.jp/dcndl/terms/publicationVolume</seealso>
    let publicationVolume = Prefixed_Name(dcndl, "publicationVolume") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:publisherTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Publisherの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publisher Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/publisherTranscription">http://ndl.go.jp/dcndl/terms/publisherTranscription</seealso>
    let publisherTranscription =
        Prefixed_Name(dcndl, "publisherTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:realName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"をも見よ参照（本名）"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Real Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/realName">http://ndl.go.jp/dcndl/terms/realName</seealso>
    let realName = Prefixed_Name(dcndl, "realName") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:record</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"参照先に関係のあるメタデータを持つ"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/record">http://ndl.go.jp/dcndl/terms/record</seealso>
    let record = Prefixed_Name(dcndl, "record") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:recordStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該レコードの状態"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Record Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/recordStatus">http://ndl.go.jp/dcndl/terms/recordStatus</seealso>
    let recordStatus = Prefixed_Name(dcndl, "recordStatus") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:seriesAlternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"別シリーズタイトル"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Alternative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesAlternative">http://ndl.go.jp/dcndl/terms/seriesAlternative</seealso>
    let seriesAlternative = Prefixed_Name(dcndl, "seriesAlternative") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesAlternativeTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Series Alternativeの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Alternative Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesAlternativeTranscription">http://ndl.go.jp/dcndl/terms/seriesAlternativeTranscription</seealso>
    let seriesAlternativeTranscription =
        Prefixed_Name(dcndl, "seriesAlternativeTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源が属するシリーズに対し著作責任を持つ実体"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesCreator">http://ndl.go.jp/dcndl/terms/seriesCreator</seealso>
    let seriesCreator = Prefixed_Name(dcndl, "seriesCreator") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesCreatorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Series Creatorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Creator Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesCreatorTranscription">http://ndl.go.jp/dcndl/terms/seriesCreatorTranscription</seealso>
    let seriesCreatorTranscription =
        Prefixed_Name(dcndl, "seriesCreatorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"シリーズタイトル"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesTitle">http://ndl.go.jp/dcndl/terms/seriesTitle</seealso>
    let seriesTitle = Prefixed_Name(dcndl, "seriesTitle") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesTitleTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Series Titleの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Title Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesTitleTranscription">http://ndl.go.jp/dcndl/terms/seriesTitleTranscription</seealso>
    let seriesTitleTranscription =
        Prefixed_Name(dcndl, "seriesTitleTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"シリーズの巻次又は部編番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesVolume">http://ndl.go.jp/dcndl/terms/seriesVolume</seealso>
    let seriesVolume = Prefixed_Name(dcndl, "seriesVolume") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:seriesVolumeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"シリーズの部編名"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Volume Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitle">http://ndl.go.jp/dcndl/terms/seriesVolumeTitle</seealso>
    let seriesVolumeTitle = Prefixed_Name(dcndl, "seriesVolumeTitle") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesVolumeTitleTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Series Volume Titleの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Volume Title Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesVolumeTitleTranscription">http://ndl.go.jp/dcndl/terms/seriesVolumeTitleTranscription</seealso>
    let seriesVolumeTitleTranscription =
        Prefixed_Name(dcndl, "seriesVolumeTitleTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:seriesVolumeTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Series Volumeの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series Volume Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/seriesVolumeTranscription">http://ndl.go.jp/dcndl/terms/seriesVolumeTranscription</seealso>
    let seriesVolumeTranscription =
        Prefixed_Name(dcndl, "seriesVolumeTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:somokuBibID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"総合目録参加館における管理番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Somoku BibID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/somokuBibID">http://ndl.go.jp/dcndl/terms/somokuBibID</seealso>
    let somokuBibID = Prefixed_Name(dcndl, "somokuBibID") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:somokuSubID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"総合目録参加館における図書登録番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Somoku SubID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/somokuSubID">http://ndl.go.jp/dcndl/terms/somokuSubID</seealso>
    let somokuSubID = Prefixed_Name(dcndl, "somokuSubID") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:sourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"原資料の識別子"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/sourceIdentifier">http://ndl.go.jp/dcndl/terms/sourceIdentifier</seealso>
    let sourceIdentifier = Prefixed_Name(dcndl, "sourceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:subjectTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Subjectの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subject Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/subjectTranscription">http://ndl.go.jp/dcndl/terms/subjectTranscription</seealso>
    let subjectTranscription =
        Prefixed_Name(dcndl, "subjectTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:titleTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Titleの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Title Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/titleTranscription">http://ndl.go.jp/dcndl/terms/titleTranscription</seealso>
    let titleTranscription = Prefixed_Name(dcndl, "titleTranscription") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:transcription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/transcription">http://ndl.go.jp/dcndl/terms/transcription</seealso>
    let transcription = Prefixed_Name(dcndl, "transcription") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:uniformTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"統一タイトル"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Uniform Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/uniformTitle">http://ndl.go.jp/dcndl/terms/uniformTitle</seealso>
    let uniformTitle = Prefixed_Name(dcndl, "uniformTitle") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"巻次又は部編番号"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volume">http://ndl.go.jp/dcndl/terms/volume</seealso>
    let volume = Prefixed_Name(dcndl, "volume") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:volumeCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"当該情報資源の当該する巻又は部編に対し著作責任を持つ実体"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volumeCreator">http://ndl.go.jp/dcndl/terms/volumeCreator</seealso>
    let volumeCreator = Prefixed_Name(dcndl, "volumeCreator") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:volumeCreatorTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Volume Creatorの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Creator Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volumeCreatorTranscription">http://ndl.go.jp/dcndl/terms/volumeCreatorTranscription</seealso>
    let volumeCreatorTranscription =
        Prefixed_Name(dcndl, "volumeCreatorTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:volumeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"逐次刊行物の初号から終号までの巻次及び年月次"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volumeRange">http://ndl.go.jp/dcndl/terms/volumeRange</seealso>
    let volumeRange = Prefixed_Name(dcndl, "volumeRange") |> PrefixedName
    /// <summary>
    ///   <para>dcndl:volumeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"多巻ものの各巻タイトル又は逐次刊行物の部編名"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volumeTitle">http://ndl.go.jp/dcndl/terms/volumeTitle</seealso>
    let volumeTitle = Prefixed_Name(dcndl, "volumeTitle") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:volumeTitleTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Volume Titleの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Title Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volumeTitleTranscription">http://ndl.go.jp/dcndl/terms/volumeTitleTranscription</seealso>
    let volumeTitleTranscription =
        Prefixed_Name(dcndl, "volumeTitleTranscription") |> PrefixedName

    /// <summary>
    ///   <para>dcndl:volumeTranscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Volumeの読み又は翻字形"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Transcription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ndl.go.jp/dcndl/terms/volumeTranscription">http://ndl.go.jp/dcndl/terms/volumeTranscription</seealso>
    let volumeTranscription =
        Prefixed_Name(dcndl, "volumeTranscription") |> PrefixedName
