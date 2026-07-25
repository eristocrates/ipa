namespace http.cedric.cnam.fr.isid.ontologies.PersonLink.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module personlink =
    let _namespace_iri = Namespace_Iri personlink |> NamespaceIRI
    /// <summary>
    ///   <para>personlink:1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>FatherOf</para><para>PèreDe</para><para>أب ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2</seealso>
    let ``_1.3.2`` = Prefixed_Name(personlink, "1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>DaughterOf</para><para>إبنة ل </para><para>FilleDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1</seealso>
    let ``_3.1.1`` = Prefixed_Name(personlink, "3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:Homme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Homme</para><para>Male</para><para>رجل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Homme">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Homme</seealso>
    let Homme = Prefixed_Name(personlink, "Homme") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>مرتبط ب </para><para>UniÀ</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2</seealso>
    let ``_13.2`` = Prefixed_Name(personlink, "13.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>FilsDe</para><para>SonOf</para><para>إبن ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2</seealso>
    let ``_3.1.2`` = Prefixed_Name(personlink, "3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:Femme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Female</para><para>امرأة</para><para>Femme</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Femme">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Femme</seealso>
    let Femme = Prefixed_Name(personlink, "Femme") |> PrefixedName
    /// <summary>
    ///   <para>personlink:4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>HalfSiblingOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4</seealso>
    let _4 = Prefixed_Name(personlink, "4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CousinDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2</seealso>
    let ``_2.2`` = Prefixed_Name(personlink, "2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>WidowerOf</para><para> أرمل ل</para><para>VeufDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.3</seealso>
    let ``_12.2.3`` = Prefixed_Name(personlink, "12.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SeparatedFrom</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12</seealso>
    let _12 = Prefixed_Name(personlink, "12") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبنة عمة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.4</seealso>
    let ``_2.1.4`` = Prefixed_Name(personlink, "2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CousineDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1</seealso>
    let ``_2.1`` = Prefixed_Name(personlink, "2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبن بالتبني ل </para><para>FilsAdoptifDe</para><para>AdoptedSonOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.1</seealso>
    let ``_3.1.2.1`` = Prefixed_Name(personlink, "3.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PartnerOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13</seealso>
    let _13 = Prefixed_Name(personlink, "13") |> PrefixedName
    /// <summary>
    ///   <para>personlink:11.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبن الأخ ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.2</seealso>
    let ``_11.2`` = Prefixed_Name(personlink, "11.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>AncestorOf</para><para>AncêtreDe</para><para>سلف ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1</seealso>
    let _1 = Prefixed_Name(personlink, "1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ArrièreGrandPèreDe</para><para>GreatGrandFatherOf</para><para>الجد الأكبر ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.2</seealso>
    let ``_1.1.2`` = Prefixed_Name(personlink, "1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SéparéeDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1</seealso>
    let ``_12.1`` = Prefixed_Name(personlink, "12.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>MèrePorteuseDe</para><para>SurrogateOf</para><para>أم بديلة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.5</seealso>
    let ``_1.3.1.5`` = Prefixed_Name(personlink, "1.3.1.5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ConjointHomoDe</para><para>GayHusbandOf</para><para>زوج مثلي ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.1</seealso>
    let ``_13.2.2.1`` = Prefixed_Name(personlink, "13.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ConjointeHétéroDe</para><para>StraightWifeOf</para><para>زوجة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.2</seealso>
    let ``_13.1.2.2`` = Prefixed_Name(personlink, "13.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوجة العم ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.4</seealso>
    let ``_8.4`` = Prefixed_Name(personlink, "8.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SéparéDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2</seealso>
    let ``_12.2`` = Prefixed_Name(personlink, "12.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>FilsBiologiqueDe</para><para>BiologicalSonOf</para><para>إبن بيولوجي ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.2</seealso>
    let ``_3.1.2.2`` = Prefixed_Name(personlink, "3.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبنة ممنوحة من</para><para>FilleDonnéeDe</para><para>GivenGirlOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.3</seealso>
    let ``_3.1.1.3`` = Prefixed_Name(personlink, "3.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#</seealso>
    let _prefix_iri = Prefixed_Name(personlink, "") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ArrièreGrandParentDe</para><para>GreatGrandParentOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1</seealso>
    let ``_1.1`` = Prefixed_Name(personlink, "1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>GrandParentOf</para><para>GrandParentDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2</seealso>
    let ``_1.2`` = Prefixed_Name(personlink, "1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ParentOf</para><para>ParentDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3</seealso>
    let ``_1.3`` = Prefixed_Name(personlink, "1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExCommonLawWifeOf</para><para>ExConcubineDe</para><para>خليلة سابقة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.1</seealso>
    let ``_12.1.1`` = Prefixed_Name(personlink, "12.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوجة مثلية سابقة ل</para><para>ExConjointeHomoDe</para><para>ExGayWifeOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.1</seealso>
    let ``_12.1.2.1`` = Prefixed_Name(personlink, "12.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExConjointeHétéroDe</para><para>ExStraightWifeOf</para><para>زوجة سابقة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.2</seealso>
    let ``_12.1.2.2`` = Prefixed_Name(personlink, "12.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوجة متعددة الأزواج سابقة ل </para><para>ExConjointePolyandreDe</para><para>ExPolyandrousWifeOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.3</seealso>
    let ``_12.1.2.3`` = Prefixed_Name(personlink, "12.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExPacséeÀ</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.4</seealso>
    let ``_12.1.4`` = Prefixed_Name(personlink, "12.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExCommonLawHusbandOf</para><para>ExConcubinDe</para><para>خليل سابق ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.1</seealso>
    let ``_12.2.1`` = Prefixed_Name(personlink, "12.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExConjointHomoDe</para><para>زوج مثلي سابق ل</para><para>ExGayHusbandOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.1</seealso>
    let ``_12.2.2.1`` = Prefixed_Name(personlink, "12.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExStraightHusbandOf</para><para>ExConjointHétéroDe</para><para>زوج سابق ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.2</seealso>
    let ``_12.2.2.2`` = Prefixed_Name(personlink, "12.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوج متعدد الزوجات سابق ل</para><para>ExPolygynousHusbandOf</para><para>ExConjointPolygyneDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.3</seealso>
    let ``_12.2.2.3`` = Prefixed_Name(personlink, "12.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExPacséÀ</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.4</seealso>
    let ``_12.2.4`` = Prefixed_Name(personlink, "12.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ConjointeDe</para><para>زوجة ل</para><para>WifeOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2</seealso>
    let ``_13.1.2`` = Prefixed_Name(personlink, "13.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ConjointDe</para><para>HusbandOf</para><para>زوج ل </para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2</seealso>
    let ``_13.2.2`` = Prefixed_Name(personlink, "13.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>EnfantDe</para><para>ChildOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1</seealso>
    let ``_3.1`` = Prefixed_Name(personlink, "3.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>FilsNaturelDe</para><para>NaturalSonOf</para><para>إبن طبيعي ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.4</seealso>
    let ``_3.1.2.4`` = Prefixed_Name(personlink, "3.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PèreJuridiqueDe</para><para>الأب القانوني ل</para><para>LegalFatherOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.1</seealso>
    let ``_1.3.2.1`` = Prefixed_Name(personlink, "1.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>الأم القانونية ل</para><para>MèreJuridiqueDe</para><para>LegalMotherOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.1</seealso>
    let ``_1.3.1.1`` = Prefixed_Name(personlink, "1.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبن ممنوح من </para><para>FilsDonnéDe</para><para>GivenSonOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.3</seealso>
    let ``_3.1.2.3`` = Prefixed_Name(personlink, "3.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>MèreNaturelleDe</para><para>الأم الطبيعية ل</para><para>NaturalMotherOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.4</seealso>
    let ``_1.3.1.4`` = Prefixed_Name(personlink, "1.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>MotherOf</para><para>MèreDe</para><para>أم ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1</seealso>
    let ``_1.3.1`` = Prefixed_Name(personlink, "1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CousinOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2</seealso>
    let _2 = Prefixed_Name(personlink, "2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوجة الخال ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.3</seealso>
    let ``_8.3`` = Prefixed_Name(personlink, "8.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>TanteDe</para><para>AuntOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8</seealso>
    let _8 = Prefixed_Name(personlink, "8") |> PrefixedName
    /// <summary>
    ///   <para>personlink:4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>أخت غير شقيقة ل</para><para>HalfSisterOf</para><para>DemiSoeurDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.1</seealso>
    let ``_4.1`` = Prefixed_Name(personlink, "4.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PetitEnfantDe</para><para>GrandChildOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2</seealso>
    let ``_3.2`` = Prefixed_Name(personlink, "3.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:Personne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Personne</para><para>Person</para><para>شخص</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Personne">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Personne</seealso>
    let Personne = Prefixed_Name(personlink, "Personne") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوج الخالة ل </para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.3</seealso>
    let ``_9.3`` = Prefixed_Name(personlink, "9.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>OnclePaternelDe</para><para>عم ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.2</seealso>
    let ``_9.2`` = Prefixed_Name(personlink, "9.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SonInLawOf</para><para>GendreDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#7">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#7</seealso>
    let _7 = Prefixed_Name(personlink, "7") |> PrefixedName
    /// <summary>
    ///   <para>personlink:5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SiblingOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5</seealso>
    let _5 = Prefixed_Name(personlink, "5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PolygynousHusbandOf</para><para>زوج متعدد الزوجات ل</para><para>ConjointPolygyneDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.3</seealso>
    let ``_13.2.2.3`` = Prefixed_Name(personlink, "13.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>TantePaternelleDe</para><para>عمة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.2</seealso>
    let ``_8.2`` = Prefixed_Name(personlink, "8.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>GrandFatherOf</para><para>GrandPèreDe</para><para>جد ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.2</seealso>
    let ``_1.2.2`` = Prefixed_Name(personlink, "1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>BiologicalDaughterOf</para><para>FilleBiologiqueDe</para><para>إبنة بيولوجية ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.2</seealso>
    let ``_3.1.1.2`` = Prefixed_Name(personlink, "3.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>مرتبطة ب</para><para>UnieÀ</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1</seealso>
    let ``_13.1`` = Prefixed_Name(personlink, "13.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>DescendantDe</para><para>DescendantOf</para><para>سليل ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3</seealso>
    let _3 = Prefixed_Name(personlink, "3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ابنة الاخت ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.1</seealso>
    let ``_10.1`` = Prefixed_Name(personlink, "10.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>NieceOf</para><para>NièceDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10</seealso>
    let _10 = Prefixed_Name(personlink, "10") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ابن خال ل </para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.1</seealso>
    let ``_2.2.1`` = Prefixed_Name(personlink, "2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PacséÀ</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.3</seealso>
    let ``_13.2.3`` = Prefixed_Name(personlink, "13.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>TanteMaternelleDe</para><para>خالة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.1</seealso>
    let ``_8.1`` = Prefixed_Name(personlink, "8.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>DaughterInLawOf</para><para>BruDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#6">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#6</seealso>
    let _6 = Prefixed_Name(personlink, "6") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CommonLawWifeOf</para><para>ConcubineDe</para><para>خليلة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.1</seealso>
    let ``_13.1.1`` = Prefixed_Name(personlink, "13.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>أخ غير شقيق ل</para><para>HalfBrotherOf</para><para>DemiFrèreDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.2</seealso>
    let ``_4.2`` = Prefixed_Name(personlink, "4.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PetitFilsDe</para><para>GrandSonOf</para><para>حفيد ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.2</seealso>
    let ``_3.2.2`` = Prefixed_Name(personlink, "3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>GreatGrandMotherOf</para><para>ArrièreGrandMèreDe</para><para>الجدة الكبيرة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.1</seealso>
    let ``_1.1.1`` = Prefixed_Name(personlink, "1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:11.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبن الأ خت ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.1</seealso>
    let ``_11.1`` = Prefixed_Name(personlink, "11.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>StraightHusbandOf</para><para>ConjointHétéroDe</para><para>زوج ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.2</seealso>
    let ``_13.2.2.2`` = Prefixed_Name(personlink, "13.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>GrandMotherOf</para><para>GrandMèreDe</para><para>جدة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.1</seealso>
    let ``_1.2.1`` = Prefixed_Name(personlink, "1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ابنة عم ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.2</seealso>
    let ``_2.1.2`` = Prefixed_Name(personlink, "2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبن عمة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.4</seealso>
    let ``_2.2.4`` = Prefixed_Name(personlink, "2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>OncleDe</para><para>UncleOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9</seealso>
    let _9 = Prefixed_Name(personlink, "9") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوجة متعددة الأزواج ل </para><para>ConjointePolyandreDe</para><para>PolyandrousWifeOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.3</seealso>
    let ``_13.1.2.3`` = Prefixed_Name(personlink, "13.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبن خالة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.3</seealso>
    let ``_2.2.3`` = Prefixed_Name(personlink, "2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>NephewOf</para><para>NeveuDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11</seealso>
    let _11 = Prefixed_Name(personlink, "11") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>MèreDonneuseDe</para><para>الأم المانحة ل</para><para>EggDonorOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.3</seealso>
    let ``_1.3.1.3`` = Prefixed_Name(personlink, "1.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PacséeÀ</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.3</seealso>
    let ``_13.1.3`` = Prefixed_Name(personlink, "13.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:10.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ابنة الاخ ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.2</seealso>
    let ``_10.2`` = Prefixed_Name(personlink, "10.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>أرملة ل</para><para>VeuveDe</para><para>WidowOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.3</seealso>
    let ``_12.1.3`` = Prefixed_Name(personlink, "12.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExConjointDe</para><para>ExHusbandOf</para><para>زوج سابق ل </para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2</seealso>
    let ``_12.2.2`` = Prefixed_Name(personlink, "12.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>BiologicalFatherOf</para><para>PèreBiologiqueDe</para><para>الأب البيولوجي ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.2</seealso>
    let ``_1.3.2.2`` = Prefixed_Name(personlink, "1.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ابن عم ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.2</seealso>
    let ``_2.2.2`` = Prefixed_Name(personlink, "2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>NaturalDaughterOf</para><para>FilleNaturelleDe</para><para>إبنة طبيعية ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.4</seealso>
    let ``_3.1.1.4`` = Prefixed_Name(personlink, "3.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>NaturalFatherOf</para><para>الأب الطبيعي ل</para><para>PèreNaturelDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.4</seealso>
    let ``_1.3.2.4`` = Prefixed_Name(personlink, "1.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>AdoptedDaughterOf</para><para>FilleAdoptiveDe</para><para>ابنة بالتبني ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.1</seealso>
    let ``_3.1.1.1`` = Prefixed_Name(personlink, "3.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ابنة خال ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.1</seealso>
    let ``_2.1.1`` = Prefixed_Name(personlink, "2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SurrogateDaughterOf</para><para>FillePortéeDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.5</seealso>
    let ``_3.1.1.5`` = Prefixed_Name(personlink, "3.1.1.5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>إبنة خالة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.3</seealso>
    let ``_2.1.3`` = Prefixed_Name(personlink, "2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>BiologicalMotherOf</para><para>الأم البيولوجية ل</para><para>MèreBiologiqueDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.2</seealso>
    let ``_1.3.1.2`` = Prefixed_Name(personlink, "1.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ExConjointeDe</para><para>زوجة سابقة ل</para><para>ExWifeOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2</seealso>
    let ``_12.1.2`` = Prefixed_Name(personlink, "12.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ConjointeHomoDe</para><para>زوجة مثلية ل</para><para>GayWifeOf</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.1</seealso>
    let ``_13.1.2.1`` = Prefixed_Name(personlink, "13.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>زوج العمة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.4</seealso>
    let ``_9.4`` = Prefixed_Name(personlink, "9.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SurrogateSonOf</para><para>FilsPortéDe</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.5</seealso>
    let ``_3.1.2.5`` = Prefixed_Name(personlink, "3.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>PèreDonneurDe</para><para>DonorFatherOf</para><para>الأب المانح ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.3</seealso>
    let ``_1.3.2.3`` = Prefixed_Name(personlink, "1.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>OncleMaternelDe</para><para>خال ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.1</seealso>
    let ``_9.1`` = Prefixed_Name(personlink, "9.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>BrotherOf</para><para>FrèreDe</para><para>أخ ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.2</seealso>
    let ``_5.2`` = Prefixed_Name(personlink, "5.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>GrandDaughterOf</para><para>PetiteFilleDe</para><para>حفيدة ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.1</seealso>
    let ``_3.2.1`` = Prefixed_Name(personlink, "3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>SisterOf</para><para>SoeurDe</para><para>أخت ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.1</seealso>
    let ``_5.1`` = Prefixed_Name(personlink, "5.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CommonLawHusbandOf</para><para>ConcubinDe</para><para>خليل ل</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.1</seealso>
    let ``_13.2.1`` = Prefixed_Name(personlink, "13.2.1") |> PrefixedName
