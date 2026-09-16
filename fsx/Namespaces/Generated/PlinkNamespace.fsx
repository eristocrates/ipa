#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module plink =
    let _prefixId = PrefixId.fromNamespaceLabel "http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#" "plink"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : سلف لrdfs:label : AncestorOfrdfs:label : AncêtreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1">plink:1</a>
    /// </summary>
    let _1 = _prefixId.prefix "1"
    /// <summary>
    ///   <para>rdfs:label : GreatGrandParentOfrdfs:label : ArrièreGrandParentDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1">plink:1.1</a>
    /// </summary>
    let _1'_period_'1 = _prefixId.prefix "1.1"
    /// <summary>
    ///   <para>rdfs:label : الجدة الكبيرة لrdfs:label : GreatGrandMotherOfrdfs:label : ArrièreGrandMèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.1">plink:1.1.1</a>
    /// </summary>
    let _1'_period_'1'_period_'1 = _prefixId.prefix "1.1.1"
    /// <summary>
    ///   <para>rdfs:label : الجد الأكبر لrdfs:label : GreatGrandFatherOfrdfs:label : ArrièreGrandPèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.2">plink:1.1.2</a>
    /// </summary>
    let _1'_period_'1'_period_'2 = _prefixId.prefix "1.1.2"
    /// <summary>
    ///   <para>rdfs:label : GrandParentOfrdfs:label : GrandParentDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2">plink:1.2</a>
    /// </summary>
    let _1'_period_'2 = _prefixId.prefix "1.2"
    /// <summary>
    ///   <para>rdfs:label : جدة لrdfs:label : GrandMotherOfrdfs:label : GrandMèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.1">plink:1.2.1</a>
    /// </summary>
    let _1'_period_'2'_period_'1 = _prefixId.prefix "1.2.1"
    /// <summary>
    ///   <para>rdfs:label : جد لrdfs:label : GrandFatherOfrdfs:label : GrandPèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.2">plink:1.2.2</a>
    /// </summary>
    let _1'_period_'2'_period_'2 = _prefixId.prefix "1.2.2"
    /// <summary>
    ///   <para>rdfs:label : ParentOfrdfs:label : ParentDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3">plink:1.3</a>
    /// </summary>
    let _1'_period_'3 = _prefixId.prefix "1.3"
    /// <summary>
    ///   <para>rdfs:label : أم لrdfs:label : MotherOfrdfs:label : MèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1">plink:1.3.1</a>
    /// </summary>
    let _1'_period_'3'_period_'1 = _prefixId.prefix "1.3.1"
    /// <summary>
    ///   <para>rdfs:label : الأم القانونية لrdfs:label : LegalMotherOfrdfs:label : MèreJuridiqueDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.1">plink:1.3.1.1</a>
    /// </summary>
    let _1'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "1.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : الأم البيولوجية لrdfs:label : BiologicalMotherOfrdfs:label : MèreBiologiqueDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.2">plink:1.3.1.2</a>
    /// </summary>
    let _1'_period_'3'_period_'1'_period_'2 = _prefixId.prefix "1.3.1.2"
    /// <summary>
    ///   <para>rdfs:label : الأم المانحة لrdfs:label : EggDonorOfrdfs:label : MèreDonneuseDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.3">plink:1.3.1.3</a>
    /// </summary>
    let _1'_period_'3'_period_'1'_period_'3 = _prefixId.prefix "1.3.1.3"
    /// <summary>
    ///   <para>rdfs:label : الأم الطبيعية لrdfs:label : NaturalMotherOfrdfs:label : MèreNaturelleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.4">plink:1.3.1.4</a>
    /// </summary>
    let _1'_period_'3'_period_'1'_period_'4 = _prefixId.prefix "1.3.1.4"
    /// <summary>
    ///   <para>rdfs:label : أم بديلة لrdfs:label : SurrogateOfrdfs:label : MèrePorteuseDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.5">plink:1.3.1.5</a>
    /// </summary>
    let _1'_period_'3'_period_'1'_period_'5 = _prefixId.prefix "1.3.1.5"
    /// <summary>
    ///   <para>rdfs:label : أب لrdfs:label : FatherOfrdfs:label : PèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2">plink:1.3.2</a>
    /// </summary>
    let _1'_period_'3'_period_'2 = _prefixId.prefix "1.3.2"
    /// <summary>
    ///   <para>rdfs:label : الأب القانوني لrdfs:label : LegalFatherOfrdfs:label : PèreJuridiqueDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.1">plink:1.3.2.1</a>
    /// </summary>
    let _1'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "1.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : الأب البيولوجي لrdfs:label : BiologicalFatherOfrdfs:label : PèreBiologiqueDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.2">plink:1.3.2.2</a>
    /// </summary>
    let _1'_period_'3'_period_'2'_period_'2 = _prefixId.prefix "1.3.2.2"
    /// <summary>
    ///   <para>rdfs:label : الأب المانح لrdfs:label : DonorFatherOfrdfs:label : PèreDonneurDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.3">plink:1.3.2.3</a>
    /// </summary>
    let _1'_period_'3'_period_'2'_period_'3 = _prefixId.prefix "1.3.2.3"
    /// <summary>
    ///   <para>rdfs:label : الأب الطبيعي لrdfs:label : NaturalFatherOfrdfs:label : PèreNaturelDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.4">plink:1.3.2.4</a>
    /// </summary>
    let _1'_period_'3'_period_'2'_period_'4 = _prefixId.prefix "1.3.2.4"
    /// <summary>
    ///   <para>rdfs:label : NieceOfrdfs:label : NièceDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10">plink:10</a>
    /// </summary>
    let _10 = _prefixId.prefix "10"
    /// <summary>
    ///   <para>rdfs:label : ابنة الاخت ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.1">plink:10.1</a>
    /// </summary>
    let _10'_period_'1 = _prefixId.prefix "10.1"
    /// <summary>
    ///   <para>rdfs:label : ابنة الاخ ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.2">plink:10.2</a>
    /// </summary>
    let _10'_period_'2 = _prefixId.prefix "10.2"
    /// <summary>
    ///   <para>rdfs:label : NephewOfrdfs:label : NeveuDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11">plink:11</a>
    /// </summary>
    let _11 = _prefixId.prefix "11"
    /// <summary>
    ///   <para>rdfs:label : إبن الأ خت ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.1">plink:11.1</a>
    /// </summary>
    let _11'_period_'1 = _prefixId.prefix "11.1"
    /// <summary>
    ///   <para>rdfs:label : إبن الأخ ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.2">plink:11.2</a>
    /// </summary>
    let _11'_period_'2 = _prefixId.prefix "11.2"
    /// <summary>
    ///   <para>rdfs:label : SeparatedFrom</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12">plink:12</a>
    /// </summary>
    let _12 = _prefixId.prefix "12"
    /// <summary>
    ///   <para>rdfs:label : SéparéeDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1">plink:12.1</a>
    /// </summary>
    let _12'_period_'1 = _prefixId.prefix "12.1"
    /// <summary>
    ///   <para>rdfs:label : خليلة سابقة لrdfs:label : ExCommonLawWifeOfrdfs:label : ExConcubineDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.1">plink:12.1.1</a>
    /// </summary>
    let _12'_period_'1'_period_'1 = _prefixId.prefix "12.1.1"
    /// <summary>
    ///   <para>rdfs:label : زوجة سابقة لrdfs:label : ExWifeOfrdfs:label : ExConjointeDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2">plink:12.1.2</a>
    /// </summary>
    let _12'_period_'1'_period_'2 = _prefixId.prefix "12.1.2"
    /// <summary>
    ///   <para>rdfs:label : زوجة مثلية سابقة لrdfs:label : ExGayWifeOfrdfs:label : ExConjointeHomoDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.1">plink:12.1.2.1</a>
    /// </summary>
    let _12'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "12.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : زوجة سابقة لrdfs:label : ExStraightWifeOfrdfs:label : ExConjointeHétéroDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.2">plink:12.1.2.2</a>
    /// </summary>
    let _12'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "12.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : زوجة متعددة الأزواج سابقة ل rdfs:label : ExPolyandrousWifeOfrdfs:label : ExConjointePolyandreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.3">plink:12.1.2.3</a>
    /// </summary>
    let _12'_period_'1'_period_'2'_period_'3 = _prefixId.prefix "12.1.2.3"
    /// <summary>
    ///   <para>rdfs:label : أرملة لrdfs:label : WidowOfrdfs:label : VeuveDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.3">plink:12.1.3</a>
    /// </summary>
    let _12'_period_'1'_period_'3 = _prefixId.prefix "12.1.3"
    /// <summary>
    ///   <para>rdfs:label : ExPacséeÀ</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.4">plink:12.1.4</a>
    /// </summary>
    let _12'_period_'1'_period_'4 = _prefixId.prefix "12.1.4"
    /// <summary>
    ///   <para>rdfs:label : SéparéDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2">plink:12.2</a>
    /// </summary>
    let _12'_period_'2 = _prefixId.prefix "12.2"
    /// <summary>
    ///   <para>rdfs:label : خليل سابق لrdfs:label : ExCommonLawHusbandOfrdfs:label : ExConcubinDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.1">plink:12.2.1</a>
    /// </summary>
    let _12'_period_'2'_period_'1 = _prefixId.prefix "12.2.1"
    /// <summary>
    ///   <para>rdfs:label : زوج سابق ل rdfs:label : ExHusbandOfrdfs:label : ExConjointDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2">plink:12.2.2</a>
    /// </summary>
    let _12'_period_'2'_period_'2 = _prefixId.prefix "12.2.2"
    /// <summary>
    ///   <para>rdfs:label : زوج مثلي سابق لrdfs:label : ExGayHusbandOfrdfs:label : ExConjointHomoDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.1">plink:12.2.2.1</a>
    /// </summary>
    let _12'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "12.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : زوج سابق لrdfs:label : ExStraightHusbandOfrdfs:label : ExConjointHétéroDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.2">plink:12.2.2.2</a>
    /// </summary>
    let _12'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "12.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : زوج متعدد الزوجات سابق لrdfs:label : ExPolygynousHusbandOfrdfs:label : ExConjointPolygyneDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.3">plink:12.2.2.3</a>
    /// </summary>
    let _12'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "12.2.2.3"
    /// <summary>
    ///   <para>rdfs:label :  أرمل لrdfs:label : WidowerOfrdfs:label : VeufDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.3">plink:12.2.3</a>
    /// </summary>
    let _12'_period_'2'_period_'3 = _prefixId.prefix "12.2.3"
    /// <summary>
    ///   <para>rdfs:label : ExPacséÀ</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.4">plink:12.2.4</a>
    /// </summary>
    let _12'_period_'2'_period_'4 = _prefixId.prefix "12.2.4"
    /// <summary>
    ///   <para>rdfs:label : PartnerOf</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13">plink:13</a>
    /// </summary>
    let _13 = _prefixId.prefix "13"
    /// <summary>
    ///   <para>rdfs:label : مرتبطة بrdfs:label : UnieÀ</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1">plink:13.1</a>
    /// </summary>
    let _13'_period_'1 = _prefixId.prefix "13.1"
    /// <summary>
    ///   <para>rdfs:label : خليلة لrdfs:label : CommonLawWifeOfrdfs:label : ConcubineDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.1">plink:13.1.1</a>
    /// </summary>
    let _13'_period_'1'_period_'1 = _prefixId.prefix "13.1.1"
    /// <summary>
    ///   <para>rdfs:label : زوجة لrdfs:label : WifeOfrdfs:label : ConjointeDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2">plink:13.1.2</a>
    /// </summary>
    let _13'_period_'1'_period_'2 = _prefixId.prefix "13.1.2"
    /// <summary>
    ///   <para>rdfs:label : زوجة مثلية لrdfs:label : GayWifeOfrdfs:label : ConjointeHomoDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.1">plink:13.1.2.1</a>
    /// </summary>
    let _13'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "13.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : زوجة لrdfs:label : StraightWifeOfrdfs:label : ConjointeHétéroDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.2">plink:13.1.2.2</a>
    /// </summary>
    let _13'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "13.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : زوجة متعددة الأزواج ل rdfs:label : PolyandrousWifeOfrdfs:label : ConjointePolyandreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.3">plink:13.1.2.3</a>
    /// </summary>
    let _13'_period_'1'_period_'2'_period_'3 = _prefixId.prefix "13.1.2.3"
    /// <summary>
    ///   <para>rdfs:label : PacséeÀ</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.3">plink:13.1.3</a>
    /// </summary>
    let _13'_period_'1'_period_'3 = _prefixId.prefix "13.1.3"
    /// <summary>
    ///   <para>rdfs:label : مرتبط ب rdfs:label : UniÀ</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2">plink:13.2</a>
    /// </summary>
    let _13'_period_'2 = _prefixId.prefix "13.2"
    /// <summary>
    ///   <para>rdfs:label : خليل لrdfs:label : CommonLawHusbandOfrdfs:label : ConcubinDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.1">plink:13.2.1</a>
    /// </summary>
    let _13'_period_'2'_period_'1 = _prefixId.prefix "13.2.1"
    /// <summary>
    ///   <para>rdfs:label : زوج ل rdfs:label : HusbandOfrdfs:label : ConjointDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2">plink:13.2.2</a>
    /// </summary>
    let _13'_period_'2'_period_'2 = _prefixId.prefix "13.2.2"
    /// <summary>
    ///   <para>rdfs:label : زوج مثلي لrdfs:label : GayHusbandOfrdfs:label : ConjointHomoDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.1">plink:13.2.2.1</a>
    /// </summary>
    let _13'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "13.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : زوج لrdfs:label : StraightHusbandOfrdfs:label : ConjointHétéroDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.2">plink:13.2.2.2</a>
    /// </summary>
    let _13'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "13.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : زوج متعدد الزوجات لrdfs:label : PolygynousHusbandOfrdfs:label : ConjointPolygyneDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.3">plink:13.2.2.3</a>
    /// </summary>
    let _13'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "13.2.2.3"
    /// <summary>
    ///   <para>rdfs:label : PacséÀ</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.3">plink:13.2.3</a>
    /// </summary>
    let _13'_period_'2'_period_'3 = _prefixId.prefix "13.2.3"
    /// <summary>
    ///   <para>rdfs:label : CousinOf</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2">plink:2</a>
    /// </summary>
    let _2 = _prefixId.prefix "2"
    /// <summary>
    ///   <para>rdfs:label : CousineDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1">plink:2.1</a>
    /// </summary>
    let _2'_period_'1 = _prefixId.prefix "2.1"
    /// <summary>
    ///   <para>rdfs:label : ابنة خال ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.1">plink:2.1.1</a>
    /// </summary>
    let _2'_period_'1'_period_'1 = _prefixId.prefix "2.1.1"
    /// <summary>
    ///   <para>rdfs:label : ابنة عم ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.2">plink:2.1.2</a>
    /// </summary>
    let _2'_period_'1'_period_'2 = _prefixId.prefix "2.1.2"
    /// <summary>
    ///   <para>rdfs:label : إبنة خالة ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.3">plink:2.1.3</a>
    /// </summary>
    let _2'_period_'1'_period_'3 = _prefixId.prefix "2.1.3"
    /// <summary>
    ///   <para>rdfs:label : إبنة عمة ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.4">plink:2.1.4</a>
    /// </summary>
    let _2'_period_'1'_period_'4 = _prefixId.prefix "2.1.4"
    /// <summary>
    ///   <para>rdfs:label : CousinDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2">plink:2.2</a>
    /// </summary>
    let _2'_period_'2 = _prefixId.prefix "2.2"
    /// <summary>
    ///   <para>rdfs:label : ابن خال ل </para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.1">plink:2.2.1</a>
    /// </summary>
    let _2'_period_'2'_period_'1 = _prefixId.prefix "2.2.1"
    /// <summary>
    ///   <para>rdfs:label : ابن عم ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.2">plink:2.2.2</a>
    /// </summary>
    let _2'_period_'2'_period_'2 = _prefixId.prefix "2.2.2"
    /// <summary>
    ///   <para>rdfs:label : إبن خالة ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.3">plink:2.2.3</a>
    /// </summary>
    let _2'_period_'2'_period_'3 = _prefixId.prefix "2.2.3"
    /// <summary>
    ///   <para>rdfs:label : إبن عمة ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.4">plink:2.2.4</a>
    /// </summary>
    let _2'_period_'2'_period_'4 = _prefixId.prefix "2.2.4"
    /// <summary>
    ///   <para>rdfs:label : سليل لrdfs:label : DescendantOfrdfs:label : DescendantDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3">plink:3</a>
    /// </summary>
    let _3 = _prefixId.prefix "3"
    /// <summary>
    ///   <para>rdfs:label : ChildOfrdfs:label : EnfantDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1">plink:3.1</a>
    /// </summary>
    let _3'_period_'1 = _prefixId.prefix "3.1"
    /// <summary>
    ///   <para>rdfs:label : إبنة ل rdfs:label : DaughterOfrdfs:label : FilleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1">plink:3.1.1</a>
    /// </summary>
    let _3'_period_'1'_period_'1 = _prefixId.prefix "3.1.1"
    /// <summary>
    ///   <para>rdfs:label : ابنة بالتبني لrdfs:label : AdoptedDaughterOfrdfs:label : FilleAdoptiveDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.1">plink:3.1.1.1</a>
    /// </summary>
    let _3'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "3.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : إبنة بيولوجية لrdfs:label : BiologicalDaughterOfrdfs:label : FilleBiologiqueDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.2">plink:3.1.1.2</a>
    /// </summary>
    let _3'_period_'1'_period_'1'_period_'2 = _prefixId.prefix "3.1.1.2"
    /// <summary>
    ///   <para>rdfs:label : إبنة ممنوحة منrdfs:label : GivenGirlOfrdfs:label : FilleDonnéeDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.3">plink:3.1.1.3</a>
    /// </summary>
    let _3'_period_'1'_period_'1'_period_'3 = _prefixId.prefix "3.1.1.3"
    /// <summary>
    ///   <para>rdfs:label : إبنة طبيعية لrdfs:label : NaturalDaughterOfrdfs:label : FilleNaturelleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.4">plink:3.1.1.4</a>
    /// </summary>
    let _3'_period_'1'_period_'1'_period_'4 = _prefixId.prefix "3.1.1.4"
    /// <summary>
    ///   <para>rdfs:label : SurrogateDaughterOfrdfs:label : FillePortéeDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.5">plink:3.1.1.5</a>
    /// </summary>
    let _3'_period_'1'_period_'1'_period_'5 = _prefixId.prefix "3.1.1.5"
    /// <summary>
    ///   <para>rdfs:label : إبن لrdfs:label : SonOfrdfs:label : FilsDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2">plink:3.1.2</a>
    /// </summary>
    let _3'_period_'1'_period_'2 = _prefixId.prefix "3.1.2"
    /// <summary>
    ///   <para>rdfs:label : إبن بالتبني ل rdfs:label : AdoptedSonOfrdfs:label : FilsAdoptifDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.1">plink:3.1.2.1</a>
    /// </summary>
    let _3'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "3.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : إبن بيولوجي لrdfs:label : BiologicalSonOfrdfs:label : FilsBiologiqueDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.2">plink:3.1.2.2</a>
    /// </summary>
    let _3'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "3.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : إبن ممنوح من rdfs:label : GivenSonOfrdfs:label : FilsDonnéDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.3">plink:3.1.2.3</a>
    /// </summary>
    let _3'_period_'1'_period_'2'_period_'3 = _prefixId.prefix "3.1.2.3"
    /// <summary>
    ///   <para>rdfs:label : إبن طبيعي لrdfs:label : NaturalSonOfrdfs:label : FilsNaturelDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.4">plink:3.1.2.4</a>
    /// </summary>
    let _3'_period_'1'_period_'2'_period_'4 = _prefixId.prefix "3.1.2.4"
    /// <summary>
    ///   <para>rdfs:label : SurrogateSonOfrdfs:label : FilsPortéDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.5">plink:3.1.2.5</a>
    /// </summary>
    let _3'_period_'1'_period_'2'_period_'5 = _prefixId.prefix "3.1.2.5"
    /// <summary>
    ///   <para>rdfs:label : GrandChildOfrdfs:label : PetitEnfantDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2">plink:3.2</a>
    /// </summary>
    let _3'_period_'2 = _prefixId.prefix "3.2"
    /// <summary>
    ///   <para>rdfs:label : حفيدة لrdfs:label : GrandDaughterOfrdfs:label : PetiteFilleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.1">plink:3.2.1</a>
    /// </summary>
    let _3'_period_'2'_period_'1 = _prefixId.prefix "3.2.1"
    /// <summary>
    ///   <para>rdfs:label : حفيد لrdfs:label : GrandSonOfrdfs:label : PetitFilsDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.2">plink:3.2.2</a>
    /// </summary>
    let _3'_period_'2'_period_'2 = _prefixId.prefix "3.2.2"
    /// <summary>
    ///   <para>rdfs:label : HalfSiblingOf</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4">plink:4</a>
    /// </summary>
    let _4 = _prefixId.prefix "4"
    /// <summary>
    ///   <para>rdfs:label : أخت غير شقيقة لrdfs:label : HalfSisterOfrdfs:label : DemiSoeurDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.1">plink:4.1</a>
    /// </summary>
    let _4'_period_'1 = _prefixId.prefix "4.1"
    /// <summary>
    ///   <para>rdfs:label : أخ غير شقيق لrdfs:label : HalfBrotherOfrdfs:label : DemiFrèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.2">plink:4.2</a>
    /// </summary>
    let _4'_period_'2 = _prefixId.prefix "4.2"
    /// <summary>
    ///   <para>rdfs:label : SiblingOf</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5">plink:5</a>
    /// </summary>
    let _5 = _prefixId.prefix "5"
    /// <summary>
    ///   <para>rdfs:label : أخت لrdfs:label : SisterOfrdfs:label : SoeurDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.1">plink:5.1</a>
    /// </summary>
    let _5'_period_'1 = _prefixId.prefix "5.1"
    /// <summary>
    ///   <para>rdfs:label : أخ لrdfs:label : BrotherOfrdfs:label : FrèreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.2">plink:5.2</a>
    /// </summary>
    let _5'_period_'2 = _prefixId.prefix "5.2"
    /// <summary>
    ///   <para>rdfs:label : DaughterInLawOfrdfs:label : BruDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#6">plink:6</a>
    /// </summary>
    let _6 = _prefixId.prefix "6"
    /// <summary>
    ///   <para>rdfs:label : SonInLawOfrdfs:label : GendreDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#7">plink:7</a>
    /// </summary>
    let _7 = _prefixId.prefix "7"
    /// <summary>
    ///   <para>rdfs:label : AuntOfrdfs:label : TanteDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8">plink:8</a>
    /// </summary>
    let _8 = _prefixId.prefix "8"
    /// <summary>
    ///   <para>rdfs:label : خالة لrdfs:label : TanteMaternelleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.1">plink:8.1</a>
    /// </summary>
    let _8'_period_'1 = _prefixId.prefix "8.1"
    /// <summary>
    ///   <para>rdfs:label : عمة لrdfs:label : TantePaternelleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.2">plink:8.2</a>
    /// </summary>
    let _8'_period_'2 = _prefixId.prefix "8.2"
    /// <summary>
    ///   <para>rdfs:label : زوجة الخال ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.3">plink:8.3</a>
    /// </summary>
    let _8'_period_'3 = _prefixId.prefix "8.3"
    /// <summary>
    ///   <para>rdfs:label : زوجة العم ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.4">plink:8.4</a>
    /// </summary>
    let _8'_period_'4 = _prefixId.prefix "8.4"
    /// <summary>
    ///   <para>rdfs:label : UncleOfrdfs:label : OncleDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9">plink:9</a>
    /// </summary>
    let _9 = _prefixId.prefix "9"
    /// <summary>
    ///   <para>rdfs:label : خال لrdfs:label : OncleMaternelDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.1">plink:9.1</a>
    /// </summary>
    let _9'_period_'1 = _prefixId.prefix "9.1"
    /// <summary>
    ///   <para>rdfs:label : عم لrdfs:label : OnclePaternelDe</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.2">plink:9.2</a>
    /// </summary>
    let _9'_period_'2 = _prefixId.prefix "9.2"
    /// <summary>
    ///   <para>rdfs:label : زوج الخالة ل </para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.3">plink:9.3</a>
    /// </summary>
    let _9'_period_'3 = _prefixId.prefix "9.3"
    /// <summary>
    ///   <para>rdfs:label : زوج العمة ل</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.4">plink:9.4</a>
    /// </summary>
    let _9'_period_'4 = _prefixId.prefix "9.4"
    /// <summary>
    ///   <para>rdfs:label : Femmerdfs:label : Femalerdfs:label : امرأة</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Femme">plink:Femme</a>
    /// </summary>
    let Femme = _prefixId.prefix "Femme"
    /// <summary>
    ///   <para>rdfs:label : رجلrdfs:label : Malerdfs:label : Homme</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Homme">plink:Homme</a>
    /// </summary>
    let Homme = _prefixId.prefix "Homme"
    /// <summary>
    ///   <para>rdfs:label : شخصrdfs:label : Personrdfs:label : Personne</para>
    ///   <a href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Personne">plink:Personne</a>
    /// </summary>
    let Personne = _prefixId.prefix "Personne"
