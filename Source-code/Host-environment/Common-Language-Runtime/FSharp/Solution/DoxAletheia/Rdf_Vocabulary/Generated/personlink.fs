namespace http.cedric.cnam.fr.isid.ontologies.PersonLink.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module personlink =
    let _namespace_iri = Namespace_Iri personlink |> NamespaceIRI
    /// <summary>
    ///   <para>personlink:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#</seealso>
    let _prefix_iri = Prefixed_Name(personlink, "") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"AncestorOf"</para><para>"AncêtreDe"</para><para>"سلف ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1</seealso>
    let _1 = Prefixed_Name(personlink, "1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ArrièreGrandParentDe"</para><para>"GreatGrandParentOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1</seealso>
    let ``_1.1`` = Prefixed_Name(personlink, "1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ArrièreGrandMèreDe"</para><para>"الجدة الكبيرة ل"</para><para>"GreatGrandMotherOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.1</seealso>
    let ``_1.1.1`` = Prefixed_Name(personlink, "1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"GreatGrandFatherOf"</para><para>"الجد الأكبر ل"</para><para>"ArrièreGrandPèreDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.1.2</seealso>
    let ``_1.1.2`` = Prefixed_Name(personlink, "1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"GrandParentDe"</para><para>"GrandParentOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2</seealso>
    let ``_1.2`` = Prefixed_Name(personlink, "1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"GrandMotherOf"</para><para>"جدة ل"</para><para>"GrandMèreDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.1</seealso>
    let ``_1.2.1`` = Prefixed_Name(personlink, "1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"GrandPèreDe"</para><para>"جد ل"</para><para>"GrandFatherOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.2.2</seealso>
    let ``_1.2.2`` = Prefixed_Name(personlink, "1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ParentDe"</para><para>"ParentOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3</seealso>
    let ``_1.3`` = Prefixed_Name(personlink, "1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"MèreDe"</para><para>"MotherOf"</para><para>"أم ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1</seealso>
    let ``_1.3.1`` = Prefixed_Name(personlink, "1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"الأم القانونية ل"</para><para>"LegalMotherOf"</para><para>"MèreJuridiqueDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.1</seealso>
    let ``_1.3.1.1`` = Prefixed_Name(personlink, "1.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"BiologicalMotherOf"</para><para>"الأم البيولوجية ل"</para><para>"MèreBiologiqueDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.2</seealso>
    let ``_1.3.1.2`` = Prefixed_Name(personlink, "1.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"الأم المانحة ل"</para><para>"MèreDonneuseDe"</para><para>"EggDonorOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.3</seealso>
    let ``_1.3.1.3`` = Prefixed_Name(personlink, "1.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"NaturalMotherOf"</para><para>"الأم الطبيعية ل"</para><para>"MèreNaturelleDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.4</seealso>
    let ``_1.3.1.4`` = Prefixed_Name(personlink, "1.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"MèrePorteuseDe"</para><para>"SurrogateOf"</para><para>"أم بديلة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.1.5</seealso>
    let ``_1.3.1.5`` = Prefixed_Name(personlink, "1.3.1.5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"FatherOf"</para><para>"PèreDe"</para><para>"أب ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2</seealso>
    let ``_1.3.2`` = Prefixed_Name(personlink, "1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"LegalFatherOf"</para><para>"PèreJuridiqueDe"</para><para>"الأب القانوني ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.1</seealso>
    let ``_1.3.2.1`` = Prefixed_Name(personlink, "1.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"BiologicalFatherOf"</para><para>"PèreBiologiqueDe"</para><para>"الأب البيولوجي ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.2</seealso>
    let ``_1.3.2.2`` = Prefixed_Name(personlink, "1.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PèreDonneurDe"</para><para>"الأب المانح ل"</para><para>"DonorFatherOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.3</seealso>
    let ``_1.3.2.3`` = Prefixed_Name(personlink, "1.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:1.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PèreNaturelDe"</para><para>"NaturalFatherOf"</para><para>"الأب الطبيعي ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#1.3.2.4</seealso>
    let ``_1.3.2.4`` = Prefixed_Name(personlink, "1.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"NieceOf"</para><para>"NièceDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10</seealso>
    let _10 = Prefixed_Name(personlink, "10") |> PrefixedName
    /// <summary>
    ///   <para>personlink:10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ابنة الاخت ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.1</seealso>
    let ``_10.1`` = Prefixed_Name(personlink, "10.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:10.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ابنة الاخ ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#10.2</seealso>
    let ``_10.2`` = Prefixed_Name(personlink, "10.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"NephewOf"</para><para>"NeveuDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11</seealso>
    let _11 = Prefixed_Name(personlink, "11") |> PrefixedName
    /// <summary>
    ///   <para>personlink:11.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبن الأ خت ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.1</seealso>
    let ``_11.1`` = Prefixed_Name(personlink, "11.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:11.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبن الأخ ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#11.2</seealso>
    let ``_11.2`` = Prefixed_Name(personlink, "11.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SeparatedFrom"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12</seealso>
    let _12 = Prefixed_Name(personlink, "12") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SéparéeDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1</seealso>
    let ``_12.1`` = Prefixed_Name(personlink, "12.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExCommonLawWifeOf"</para><para>"ExConcubineDe"</para><para>"خليلة سابقة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.1</seealso>
    let ``_12.1.1`` = Prefixed_Name(personlink, "12.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExConjointeDe"</para><para>"ExWifeOf"</para><para>"زوجة سابقة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2</seealso>
    let ``_12.1.2`` = Prefixed_Name(personlink, "12.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوجة مثلية سابقة ل"</para><para>"ExConjointeHomoDe"</para><para>"ExGayWifeOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.1</seealso>
    let ``_12.1.2.1`` = Prefixed_Name(personlink, "12.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوجة سابقة ل"</para><para>"ExStraightWifeOf"</para><para>"ExConjointeHétéroDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.2</seealso>
    let ``_12.1.2.2`` = Prefixed_Name(personlink, "12.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExConjointePolyandreDe"</para><para>"زوجة متعددة الأزواج سابقة ل "</para><para>"ExPolyandrousWifeOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.2.3</seealso>
    let ``_12.1.2.3`` = Prefixed_Name(personlink, "12.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"أرملة ل"</para><para>"WidowOf"</para><para>"VeuveDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.3</seealso>
    let ``_12.1.3`` = Prefixed_Name(personlink, "12.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExPacséeÀ"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.1.4</seealso>
    let ``_12.1.4`` = Prefixed_Name(personlink, "12.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SéparéDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2</seealso>
    let ``_12.2`` = Prefixed_Name(personlink, "12.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"خليل سابق ل"</para><para>"ExConcubinDe"</para><para>"ExCommonLawHusbandOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.1</seealso>
    let ``_12.2.1`` = Prefixed_Name(personlink, "12.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوج سابق ل "</para><para>"ExHusbandOf"</para><para>"ExConjointDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2</seealso>
    let ``_12.2.2`` = Prefixed_Name(personlink, "12.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExConjointHomoDe"</para><para>"ExGayHusbandOf"</para><para>"زوج مثلي سابق ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.1</seealso>
    let ``_12.2.2.1`` = Prefixed_Name(personlink, "12.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExConjointHétéroDe"</para><para>"ExStraightHusbandOf"</para><para>"زوج سابق ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.2</seealso>
    let ``_12.2.2.2`` = Prefixed_Name(personlink, "12.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExPolygynousHusbandOf"</para><para>"زوج متعدد الزوجات سابق ل"</para><para>"ExConjointPolygyneDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.2.3</seealso>
    let ``_12.2.2.3`` = Prefixed_Name(personlink, "12.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"WidowerOf"</para><para>" أرمل ل"</para><para>"VeufDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.3</seealso>
    let ``_12.2.3`` = Prefixed_Name(personlink, "12.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:12.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ExPacséÀ"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#12.2.4</seealso>
    let ``_12.2.4`` = Prefixed_Name(personlink, "12.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PartnerOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13</seealso>
    let _13 = Prefixed_Name(personlink, "13") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"UnieÀ"</para><para>"مرتبطة ب"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1</seealso>
    let ``_13.1`` = Prefixed_Name(personlink, "13.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"CommonLawWifeOf"</para><para>"خليلة ل"</para><para>"ConcubineDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.1</seealso>
    let ``_13.1.1`` = Prefixed_Name(personlink, "13.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"WifeOf"</para><para>"ConjointeDe"</para><para>"زوجة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2</seealso>
    let ``_13.1.2`` = Prefixed_Name(personlink, "13.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ConjointeHomoDe"</para><para>"GayWifeOf"</para><para>"زوجة مثلية ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.1</seealso>
    let ``_13.1.2.1`` = Prefixed_Name(personlink, "13.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوجة ل"</para><para>"StraightWifeOf"</para><para>"ConjointeHétéroDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.2</seealso>
    let ``_13.1.2.2`` = Prefixed_Name(personlink, "13.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ConjointePolyandreDe"</para><para>"PolyandrousWifeOf"</para><para>"زوجة متعددة الأزواج ل "</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.2.3</seealso>
    let ``_13.1.2.3`` = Prefixed_Name(personlink, "13.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PacséeÀ"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.1.3</seealso>
    let ``_13.1.3`` = Prefixed_Name(personlink, "13.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"UniÀ"</para><para>"مرتبط ب "</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2</seealso>
    let ``_13.2`` = Prefixed_Name(personlink, "13.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"خليل ل"</para><para>"ConcubinDe"</para><para>"CommonLawHusbandOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.1</seealso>
    let ``_13.2.1`` = Prefixed_Name(personlink, "13.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوج ل "</para><para>"ConjointDe"</para><para>"HusbandOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2</seealso>
    let ``_13.2.2`` = Prefixed_Name(personlink, "13.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ConjointHomoDe"</para><para>"زوج مثلي ل"</para><para>"GayHusbandOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.1</seealso>
    let ``_13.2.2.1`` = Prefixed_Name(personlink, "13.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوج ل"</para><para>"StraightHusbandOf"</para><para>"ConjointHétéroDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.2</seealso>
    let ``_13.2.2.2`` = Prefixed_Name(personlink, "13.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوج متعدد الزوجات ل"</para><para>"PolygynousHusbandOf"</para><para>"ConjointPolygyneDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.2.3</seealso>
    let ``_13.2.2.3`` = Prefixed_Name(personlink, "13.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:13.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PacséÀ"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#13.2.3</seealso>
    let ``_13.2.3`` = Prefixed_Name(personlink, "13.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"CousinOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2</seealso>
    let _2 = Prefixed_Name(personlink, "2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"CousineDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1</seealso>
    let ``_2.1`` = Prefixed_Name(personlink, "2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ابنة خال ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.1</seealso>
    let ``_2.1.1`` = Prefixed_Name(personlink, "2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ابنة عم ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.2</seealso>
    let ``_2.1.2`` = Prefixed_Name(personlink, "2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبنة خالة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.3</seealso>
    let ``_2.1.3`` = Prefixed_Name(personlink, "2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبنة عمة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.1.4</seealso>
    let ``_2.1.4`` = Prefixed_Name(personlink, "2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"CousinDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2</seealso>
    let ``_2.2`` = Prefixed_Name(personlink, "2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ابن خال ل "</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.1</seealso>
    let ``_2.2.1`` = Prefixed_Name(personlink, "2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ابن عم ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.2</seealso>
    let ``_2.2.2`` = Prefixed_Name(personlink, "2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبن خالة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.3</seealso>
    let ``_2.2.3`` = Prefixed_Name(personlink, "2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبن عمة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#2.2.4</seealso>
    let ``_2.2.4`` = Prefixed_Name(personlink, "2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"DescendantDe"</para><para>"DescendantOf"</para><para>"سليل ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3</seealso>
    let _3 = Prefixed_Name(personlink, "3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ChildOf"</para><para>"EnfantDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1</seealso>
    let ``_3.1`` = Prefixed_Name(personlink, "3.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"DaughterOf"</para><para>"FilleDe"</para><para>"إبنة ل "</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1</seealso>
    let ``_3.1.1`` = Prefixed_Name(personlink, "3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"AdoptedDaughterOf"</para><para>"FilleAdoptiveDe"</para><para>"ابنة بالتبني ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.1</seealso>
    let ``_3.1.1.1`` = Prefixed_Name(personlink, "3.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"BiologicalDaughterOf"</para><para>"FilleBiologiqueDe"</para><para>"إبنة بيولوجية ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.2</seealso>
    let ``_3.1.1.2`` = Prefixed_Name(personlink, "3.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبنة ممنوحة من"</para><para>"FilleDonnéeDe"</para><para>"GivenGirlOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.3</seealso>
    let ``_3.1.1.3`` = Prefixed_Name(personlink, "3.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"NaturalDaughterOf"</para><para>"إبنة طبيعية ل"</para><para>"FilleNaturelleDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.4</seealso>
    let ``_3.1.1.4`` = Prefixed_Name(personlink, "3.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SurrogateDaughterOf"</para><para>"FillePortéeDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.1.5</seealso>
    let ``_3.1.1.5`` = Prefixed_Name(personlink, "3.1.1.5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"إبن ل"</para><para>"FilsDe"</para><para>"SonOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2</seealso>
    let ``_3.1.2`` = Prefixed_Name(personlink, "3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"AdoptedSonOf"</para><para>"إبن بالتبني ل "</para><para>"FilsAdoptifDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.1</seealso>
    let ``_3.1.2.1`` = Prefixed_Name(personlink, "3.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"BiologicalSonOf"</para><para>"FilsBiologiqueDe"</para><para>"إبن بيولوجي ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.2</seealso>
    let ``_3.1.2.2`` = Prefixed_Name(personlink, "3.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"FilsDonnéDe"</para><para>"GivenSonOf"</para><para>"إبن ممنوح من "</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.3</seealso>
    let ``_3.1.2.3`` = Prefixed_Name(personlink, "3.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"NaturalSonOf"</para><para>"FilsNaturelDe"</para><para>"إبن طبيعي ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.4</seealso>
    let ``_3.1.2.4`` = Prefixed_Name(personlink, "3.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"FilsPortéDe"</para><para>"SurrogateSonOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.1.2.5</seealso>
    let ``_3.1.2.5`` = Prefixed_Name(personlink, "3.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PetitEnfantDe"</para><para>"GrandChildOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2</seealso>
    let ``_3.2`` = Prefixed_Name(personlink, "3.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"PetiteFilleDe"</para><para>"حفيدة ل"</para><para>"GrandDaughterOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.1</seealso>
    let ``_3.2.1`` = Prefixed_Name(personlink, "3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"GrandSonOf"</para><para>"PetitFilsDe"</para><para>"حفيد ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#3.2.2</seealso>
    let ``_3.2.2`` = Prefixed_Name(personlink, "3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"HalfSiblingOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4</seealso>
    let _4 = Prefixed_Name(personlink, "4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"DemiSoeurDe"</para><para>"أخت غير شقيقة ل"</para><para>"HalfSisterOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.1</seealso>
    let ``_4.1`` = Prefixed_Name(personlink, "4.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"أخ غير شقيق ل"</para><para>"DemiFrèreDe"</para><para>"HalfBrotherOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#4.2</seealso>
    let ``_4.2`` = Prefixed_Name(personlink, "4.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SiblingOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5</seealso>
    let _5 = Prefixed_Name(personlink, "5") |> PrefixedName
    /// <summary>
    ///   <para>personlink:5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"أخت ل"</para><para>"SisterOf"</para><para>"SoeurDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.1</seealso>
    let ``_5.1`` = Prefixed_Name(personlink, "5.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"أخ ل"</para><para>"FrèreDe"</para><para>"BrotherOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#5.2</seealso>
    let ``_5.2`` = Prefixed_Name(personlink, "5.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"BruDe"</para><para>"DaughterInLawOf"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#6">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#6</seealso>
    let _6 = Prefixed_Name(personlink, "6") |> PrefixedName
    /// <summary>
    ///   <para>personlink:7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SonInLawOf"</para><para>"GendreDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#7">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#7</seealso>
    let _7 = Prefixed_Name(personlink, "7") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"AuntOf"</para><para>"TanteDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8</seealso>
    let _8 = Prefixed_Name(personlink, "8") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"TanteMaternelleDe"</para><para>"خالة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.1</seealso>
    let ``_8.1`` = Prefixed_Name(personlink, "8.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"عمة ل"</para><para>"TantePaternelleDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.2</seealso>
    let ``_8.2`` = Prefixed_Name(personlink, "8.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوجة الخال ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.3</seealso>
    let ``_8.3`` = Prefixed_Name(personlink, "8.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوجة العم ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#8.4</seealso>
    let ``_8.4`` = Prefixed_Name(personlink, "8.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"UncleOf"</para><para>"OncleDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9</seealso>
    let _9 = Prefixed_Name(personlink, "9") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"خال ل"</para><para>"OncleMaternelDe"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.1">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.1</seealso>
    let ``_9.1`` = Prefixed_Name(personlink, "9.1") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"OnclePaternelDe"</para><para>"عم ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.2">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.2</seealso>
    let ``_9.2`` = Prefixed_Name(personlink, "9.2") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوج الخالة ل "</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.3">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.3</seealso>
    let ``_9.3`` = Prefixed_Name(personlink, "9.3") |> PrefixedName
    /// <summary>
    ///   <para>personlink:9.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"زوج العمة ل"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.4">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#9.4</seealso>
    let ``_9.4`` = Prefixed_Name(personlink, "9.4") |> PrefixedName
    /// <summary>
    ///   <para>personlink:Femme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Femme"</para><para>"Female"</para><para>"امرأة"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Femme">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Femme</seealso>
    let Femme = Prefixed_Name(personlink, "Femme") |> PrefixedName
    /// <summary>
    ///   <para>personlink:Homme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"رجل"</para><para>"Male"</para><para>"Homme"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Homme">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Homme</seealso>
    let Homme = Prefixed_Name(personlink, "Homme") |> PrefixedName
    /// <summary>
    ///   <para>personlink:Personne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Personne"</para><para>"Person"</para><para>"شخص"</para></remarks>
    /// <seealso href="http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Personne">http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#Personne</seealso>
    let Personne = Prefixed_Name(personlink, "Personne") |> PrefixedName
