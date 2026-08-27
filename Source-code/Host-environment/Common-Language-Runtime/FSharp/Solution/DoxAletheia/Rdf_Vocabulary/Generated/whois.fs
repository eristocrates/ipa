namespace http.www.kanzaki.com.ns.whois.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module whois =
    let _namespace_iri = Namespace_Iri whois |> NamespaceIRI
    /// <summary>
    ///   <para>whois:Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A period of education in one's academic career, as a stage of life. NOT an activity of learning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"ライフステージ中での、学業期間。学歴を表す"</para>
    /// labels<para>"Educaton (stage)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#Education">http://www.kanzaki.com/ns/whois#Education</seealso>
    let Education = Prefixed_Name(whois, "Education") |> PrefixedName
    /// <summary>
    ///   <para>whois:Job</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A period of job in one's professional career, as a stage of life. NOT an activity of working."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"ライフステージ中でのある職業の期間。職歴を表す"</para>
    /// labels<para>"Job (stage)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#Job">http://www.kanzaki.com/ns/whois#Job</seealso>
    let Job = Prefixed_Name(whois, "Job") |> PrefixedName
    /// <summary>
    ///   <para>whois:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"場所を表すクラス"</para>
    ///   <para>"A place -- this can be the domain of both contact: vocab and geo: vocab."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#Place">http://www.kanzaki.com/ns/whois#Place</seealso>
    let Place = Prefixed_Name(whois, "Place") |> PrefixedName
    /// <summary>
    ///   <para>whois:Stage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stage of life. A distinct time period in a sequence of one's life cycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"人生のあるステージ。人のライフサイクルの中での、はっきりと区切られる一時期"</para>
    /// labels<para>"Stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#Stage">http://www.kanzaki.com/ns/whois#Stage</seealso>
    let Stage = Prefixed_Name(whois, "Stage") |> PrefixedName
    /// <summary>
    ///   <para>whois:academicCareer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"学歴を記述する。careerのサブプロパティ"</para>
    ///   <para>"an educational career in one's personal history."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Academic Career"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#academicCareer">http://www.kanzaki.com/ns/whois#academicCareer</seealso>
    let academicCareer = Prefixed_Name(whois, "academicCareer") |> PrefixedName
    /// <summary>
    ///   <para>whois:achievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"業績を記述する。careerのサブプロパティ"</para>
    ///   <para>"a one's achievement in general. Note you can use foaf:pastProject for a specific achievement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Achievement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#achievement">http://www.kanzaki.com/ns/whois#achievement</seealso>
    let achievement = Prefixed_Name(whois, "achievement") |> PrefixedName
    /// <summary>
    ///   <para>whois:born</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"One's birthday. This can be used in place of 'whois:since' where the 'whois:Stage' is one's first stage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"誕生日を記述する。sinceのサブプロパティ（人生の最初のステージの始まり）"</para>
    /// labels<para>"Born"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#born">http://www.kanzaki.com/ns/whois#born</seealso>
    let born = Prefixed_Name(whois, "born") |> PrefixedName
    /// <summary>
    ///   <para>whois:career</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"人生における職業、教育、業績などを記述する"</para>
    ///   <para>"A job, education or any achievement in one's life, which can be specific to a stage of life (object = #Stage) or in general (object = any)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Career"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#career">http://www.kanzaki.com/ns/whois#career</seealso>
    let career = Prefixed_Name(whois, "career") |> PrefixedName
    /// <summary>
    ///   <para>whois:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"人の活動の一般的な記述。stage、career、planの上位プロパティ。一つのステージに収まらない事項を記述するためにも使える"</para>
    ///   <para>"General description of a person's activities. Use to describe something that does not fit into a Stage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#description">http://www.kanzaki.com/ns/whois#description</seealso>
    let description = Prefixed_Name(whois, "description") |> PrefixedName
    /// <summary>
    ///   <para>whois:honor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"an honor that one has been rewarded."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"顕彰歴を記述する。careerのサブプロパティ"</para>
    /// labels<para>"Honor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#honor">http://www.kanzaki.com/ns/whois#honor</seealso>
    let honor = Prefixed_Name(whois, "honor") |> PrefixedName
    /// <summary>
    ///   <para>whois:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Place which relates to a stage of life. Literal version of 'where'. ":x whois:place 'y'." implies ":x whois:where [rdfs:label 'y']."."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"あるステージの場所をリテラルとして記述する"</para>
    /// labels<para>"Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#place">http://www.kanzaki.com/ns/whois#place</seealso>
    let place = Prefixed_Name(whois, "place") |> PrefixedName
    /// <summary>
    ///   <para>whois:plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"General description of a person's future activities. Note past activity can be described with #career."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"人の将来の活動予定を記述する"</para>
    /// labels<para>"Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#plan">http://www.kanzaki.com/ns/whois#plan</seealso>
    let plan = Prefixed_Name(whois, "plan") |> PrefixedName
    /// <summary>
    ///   <para>whois:professionalCareer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"職歴を記述する。careerのサブプロパティ"</para>
    ///   <para>"a professional or business career in one's personal history."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Professional Career"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#professionalCareer">http://www.kanzaki.com/ns/whois#professionalCareer</seealso>
    let professionalCareer = Prefixed_Name(whois, "professionalCareer") |> PrefixedName
    /// <summary>
    ///   <para>whois:publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a one's publication in general. Note foaf:publications describes publication list page."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"出版物、論文を記述する。descriptionのサブプロパティ"</para>
    /// labels<para>"Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#publication">http://www.kanzaki.com/ns/whois#publication</seealso>
    let publication = Prefixed_Name(whois, "publication") |> PrefixedName
    /// <summary>
    ///   <para>whois:since</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"あるステージが始まったときを記述する。whenのサブプロパティ"</para>
    ///   <para>"date when a stage of life started. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Since"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#since">http://www.kanzaki.com/ns/whois#since</seealso>
    let since = Prefixed_Name(whois, "since") |> PrefixedName
    /// <summary>
    ///   <para>whois:stage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"人の履歴のにおけるある切り口を記述する"</para>
    ///   <para>"Describes an aspect of one's personal history. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#stage">http://www.kanzaki.com/ns/whois#stage</seealso>
    let stage = Prefixed_Name(whois, "stage") |> PrefixedName
    /// <summary>
    ///   <para>whois:until</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"あるステージが終わったときを記述する。whenのサブプロパティ"</para>
    ///   <para>"date when a stage of life ended."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Until"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#until">http://www.kanzaki.com/ns/whois#until</seealso>
    let until = Prefixed_Name(whois, "until") |> PrefixedName
    /// <summary>
    ///   <para>whois:what</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"あるステージを特徴付けるトピックを記述する（目的語はリテラルではないことに注意）"</para>
    ///   <para>"Specifies a topic in a stage of life. The range is owl:Thing to have structured description. Use dc:description for literal description, or dc:subject for keywords."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"What"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#what">http://www.kanzaki.com/ns/whois#what</seealso>
    let what = Prefixed_Name(whois, "what") |> PrefixedName
    /// <summary>
    ///   <para>whois:when</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"あるステージの時期を記述するための上位プロパティ"</para>
    ///   <para>"date/time which is related to a stage of life. Super property of since and until. W3C-DTF format value is assumed (i.e. can be yyyy, yyyy-mm, yyyy-mm-dd etc)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"When"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#when">http://www.kanzaki.com/ns/whois#when</seealso>
    let when_ = Prefixed_Name(whois, "when") |> PrefixedName
    /// <summary>
    ///   <para>whois:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"あるステージの場所を記述する"</para>
    ///   <para>"Place which relates to a stage of life. The range is whois:Place to have structured description. Use bio:place for literal value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Where"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/whois#where">http://www.kanzaki.com/ns/whois#where</seealso>
    let where = Prefixed_Name(whois, "where") |> PrefixedName
