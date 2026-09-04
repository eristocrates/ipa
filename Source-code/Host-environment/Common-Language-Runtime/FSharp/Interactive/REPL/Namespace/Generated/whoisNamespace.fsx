#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module whois =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.kanzaki.com/ns/whois#" "whois"

    /// <summary>
    ///   <para>rdfs:label : Educaton (stage)^^xsd:string</para>
    ///   <para>rdfs:comment : A period of education in one's academic career, as a stage of life. NOT an activity of learning.^^xsd:stringrdfs:comment : ライフステージ中での、学業期間。学歴を表す</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#Education">whois:Education</a>
    /// </summary>
    let Education = _prefixId.prefix "Education"
    /// <summary>
    ///   <para>rdfs:label : Job (stage)^^xsd:string</para>
    ///   <para>rdfs:comment : A period of job in one's professional career, as a stage of life. NOT an activity of working.^^xsd:stringrdfs:comment : ライフステージ中でのある職業の期間。職歴を表す</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#Job">whois:Job</a>
    /// </summary>
    let Job = _prefixId.prefix "Job"
    /// <summary>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>rdfs:comment : A place -- this can be the domain of both contact: vocab and geo: vocab.^^xsd:stringrdfs:comment : 場所を表すクラス</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#Place">whois:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Stage^^xsd:string</para>
    ///   <para>rdfs:comment : A stage of life. A distinct time period in a sequence of one's life cycle.^^xsd:stringrdfs:comment : 人生のあるステージ。人のライフサイクルの中での、はっきりと区切られる一時期</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#Stage">whois:Stage</a>
    /// </summary>
    let Stage = _prefixId.prefix "Stage"
    /// <summary>
    ///   <para>rdfs:label : Academic Career^^xsd:string</para>
    ///   <para>rdfs:comment : an educational career in one's personal history.^^xsd:stringrdfs:comment : 学歴を記述する。careerのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#academicCareer">whois:academicCareer</a>
    /// </summary>
    let academicCareer = _prefixId.prefix "academicCareer"
    /// <summary>
    ///   <para>rdfs:label : Achievement^^xsd:string</para>
    ///   <para>rdfs:comment : a one's achievement in general. Note you can use foaf:pastProject for a specific achievement.^^xsd:stringrdfs:comment : 業績を記述する。careerのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#achievement">whois:achievement</a>
    /// </summary>
    let achievement = _prefixId.prefix "achievement"
    /// <summary>
    ///   <para>rdfs:label : Born^^xsd:string</para>
    ///   <para>rdfs:comment : One's birthday. This can be used in place of 'whois:since' where the 'whois:Stage' is one's first stage.^^xsd:stringrdfs:comment : 誕生日を記述する。sinceのサブプロパティ（人生の最初のステージの始まり）</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#born">whois:born</a>
    /// </summary>
    let born = _prefixId.prefix "born"
    /// <summary>
    ///   <para>rdfs:label : Career^^xsd:string</para>
    ///   <para>rdfs:comment : A job, education or any achievement in one's life, which can be specific to a stage of life (object = #Stage) or in general (object = any).^^xsd:stringrdfs:comment : 人生における職業、教育、業績などを記述する</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#career">whois:career</a>
    /// </summary>
    let career = _prefixId.prefix "career"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <para>rdfs:comment : General description of a person's activities. Use to describe something that does not fit into a Stage.^^xsd:stringrdfs:comment : 人の活動の一般的な記述。stage、career、planの上位プロパティ。一つのステージに収まらない事項を記述するためにも使える</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#description">whois:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : Honor^^xsd:string</para>
    ///   <para>rdfs:comment : an honor that one has been rewarded.^^xsd:stringrdfs:comment : 顕彰歴を記述する。careerのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#honor">whois:honor</a>
    /// </summary>
    let honor = _prefixId.prefix "honor"
    /// <summary>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>rdfs:comment : Place which relates to a stage of life. Literal version of 'where'. ":x whois:place 'y'." implies ":x whois:where [rdfs:label 'y'].".^^xsd:stringrdfs:comment : あるステージの場所をリテラルとして記述する</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#place">whois:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>rdfs:label : Plan^^xsd:string</para>
    ///   <para>rdfs:comment : General description of a person's future activities. Note past activity can be described with #career.^^xsd:stringrdfs:comment : 人の将来の活動予定を記述する</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#plan">whois:plan</a>
    /// </summary>
    let plan = _prefixId.prefix "plan"
    /// <summary>
    ///   <para>rdfs:label : Professional Career^^xsd:string</para>
    ///   <para>rdfs:comment : a professional or business career in one's personal history.^^xsd:stringrdfs:comment : 職歴を記述する。careerのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#professionalCareer">whois:professionalCareer</a>
    /// </summary>
    let professionalCareer = _prefixId.prefix "professionalCareer"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <para>rdfs:comment : a one's publication in general. Note foaf:publications describes publication list page.^^xsd:stringrdfs:comment : 出版物、論文を記述する。descriptionのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#publication">whois:publication</a>
    /// </summary>
    let publication = _prefixId.prefix "publication"
    /// <summary>
    ///   <para>rdfs:label : Since^^xsd:string</para>
    ///   <para>rdfs:comment : date when a stage of life started. ^^xsd:stringrdfs:comment : あるステージが始まったときを記述する。whenのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#since">whois:since</a>
    /// </summary>
    let since = _prefixId.prefix "since"
    /// <summary>
    ///   <para>rdfs:label : Stage^^xsd:string</para>
    ///   <para>rdfs:comment : Describes an aspect of one's personal history. ^^xsd:stringrdfs:comment : 人の履歴のにおけるある切り口を記述する</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#stage">whois:stage</a>
    /// </summary>
    let stage = _prefixId.prefix "stage"
    /// <summary>
    ///   <para>rdfs:label : Until^^xsd:string</para>
    ///   <para>rdfs:comment : date when a stage of life ended.^^xsd:stringrdfs:comment : あるステージが終わったときを記述する。whenのサブプロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#until">whois:until</a>
    /// </summary>
    let until = _prefixId.prefix "until"
    /// <summary>
    ///   <para>rdfs:label : What^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a topic in a stage of life. The range is owl:Thing to have structured description. Use dc:description for literal description, or dc:subject for keywords.^^xsd:stringrdfs:comment : あるステージを特徴付けるトピックを記述する（目的語はリテラルではないことに注意）</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#what">whois:what</a>
    /// </summary>
    let what = _prefixId.prefix "what"
    /// <summary>
    ///   <para>rdfs:label : When^^xsd:string</para>
    ///   <para>rdfs:comment : date/time which is related to a stage of life. Super property of since and until. W3C-DTF format value is assumed (i.e. can be yyyy, yyyy-mm, yyyy-mm-dd etc).^^xsd:stringrdfs:comment : あるステージの時期を記述するための上位プロパティ</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#when">whois:when</a>
    /// </summary>
    let when_ = _prefixId.prefix "when"
    /// <summary>
    ///   <para>rdfs:label : Where^^xsd:string</para>
    ///   <para>rdfs:comment : Place which relates to a stage of life. The range is whois:Place to have structured description. Use bio:place for literal value^^xsd:stringrdfs:comment : あるステージの場所を記述する</para>
    ///   <a href="http://www.kanzaki.com/ns/whois#where">whois:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
