namespace http.acm.rkbexplorer.com.ontologies.acm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module acm =
    let _namespace_iri = Namespace_Iri acm |> NamespaceIRI
    /// <summary>
    ///   <para>acm:A.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.0.0. Biographies/autobiographies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0.0">http://acm.rkbexplorer.com/ontologies/acm#A.0.0</seealso>
    let ``A.0.0`` = Prefixed_Name(acm, "A.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.2. REFERENCE</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.2">http://acm.rkbexplorer.com/ontologies/acm#A.2</seealso>
    let ``A.2`` = Prefixed_Name(acm, "A.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B. Hardware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B">http://acm.rkbexplorer.com/ontologies/acm#B</seealso>
    let B = Prefixed_Name(acm, "B") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.1. Control Design Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.1</seealso>
    let ``B.1.1`` = Prefixed_Name(acm, "B.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.1.1. Microprogrammed logic arrays</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.1.1</seealso>
    let ``B.1.1.1`` = Prefixed_Name(acm, "B.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.2. Control Structure Performance Analysis and Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.2</seealso>
    let ``B.1.2`` = Prefixed_Name(acm, "B.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.2.1. Formal models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.2.1</seealso>
    let ``B.1.2.1`` = Prefixed_Name(acm, "B.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.1.3. Control Structure Reliability, Testing, and Fault-Tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.3</seealso>
    let ``B.1.3`` = Prefixed_Name(acm, "B.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.2.1. Hardware description languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.1</seealso>
    let ``B.5.2.1`` = Prefixed_Name(acm, "B.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.2.2. Optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.2</seealso>
    let ``B.5.2.2`` = Prefixed_Name(acm, "B.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.5.3.1. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.1</seealso>
    let ``B.5.3.1`` = Prefixed_Name(acm, "B.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.5.3.2. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.2</seealso>
    let ``B.5.3.2`` = Prefixed_Name(acm, "B.5.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.0</seealso>
    let ``H.2.0`` = Prefixed_Name(acm, "H.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.2.0.0. Security, integrity, and protection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.0.0</seealso>
    let ``H.2.0.0`` = Prefixed_Name(acm, "H.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.1.0. Data models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.1.0</seealso>
    let ``H.2.1.0`` = Prefixed_Name(acm, "H.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.1.1. Normal forms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.1.1</seealso>
    let ``H.2.1.1`` = Prefixed_Name(acm, "H.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.2.0. Access methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.2.0</seealso>
    let ``H.2.2.0`` = Prefixed_Name(acm, "H.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.2.1. Deadlock avoidance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.2.1</seealso>
    let ``H.2.2.1`` = Prefixed_Name(acm, "H.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.2.</para>
    /// labels<para>H.2.3. Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.3</seealso>
    let ``H.2.3`` = Prefixed_Name(acm, "H.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.3.0. Data description languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.0</seealso>
    let ``H.2.3.0`` = Prefixed_Name(acm, "H.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.2.3.5. Metatheory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.5</seealso>
    let ``I.2.3.5`` = Prefixed_Name(acm, "I.2.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.6. Nonmonotonic reasoning and belief revision</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.6</seealso>
    let ``I.2.3.6`` = Prefixed_Name(acm, "I.2.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.8. Uncertainty, ``fuzzy,'' and probabilistic reasoning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.8">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.8</seealso>
    let ``I.2.3.8`` = Prefixed_Name(acm, "I.2.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.4.1.</para>
    /// labels<para>I.2.4. Knowledge Representation Formalisms and Methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.4</seealso>
    let ``I.2.4`` = Prefixed_Name(acm, "I.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.4. Law</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.4">http://acm.rkbexplorer.com/ontologies/acm#J.1.4</seealso>
    let ``J.1.4`` = Prefixed_Name(acm, "J.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.5. Manufacturing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.5">http://acm.rkbexplorer.com/ontologies/acm#J.1.5</seealso>
    let ``J.1.5`` = Prefixed_Name(acm, "J.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.6. Marketing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.6">http://acm.rkbexplorer.com/ontologies/acm#J.1.6</seealso>
    let ``J.1.6`` = Prefixed_Name(acm, "J.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.7. Military</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.7">http://acm.rkbexplorer.com/ontologies/acm#J.1.7</seealso>
    let ``J.1.7`` = Prefixed_Name(acm, "J.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.4. Earth and atmospheric sciences</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.4">http://acm.rkbexplorer.com/ontologies/acm#J.2.4</seealso>
    let ``J.2.4`` = Prefixed_Name(acm, "J.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.5. Electronics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.5">http://acm.rkbexplorer.com/ontologies/acm#J.2.5</seealso>
    let ``J.2.5`` = Prefixed_Name(acm, "J.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.6. Engineering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.6">http://acm.rkbexplorer.com/ontologies/acm#J.2.6</seealso>
    let ``J.2.6`` = Prefixed_Name(acm, "J.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.7. Mathematics and statistics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.7">http://acm.rkbexplorer.com/ontologies/acm#J.2.7</seealso>
    let ``J.2.7`` = Prefixed_Name(acm, "J.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.4. SOCIAL AND BEHAVIORAL SCIENCES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4">http://acm.rkbexplorer.com/ontologies/acm#J.4</seealso>
    let ``J.4`` = Prefixed_Name(acm, "J.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.4.0. Economics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4.0">http://acm.rkbexplorer.com/ontologies/acm#J.4.0</seealso>
    let ``J.4.0`` = Prefixed_Name(acm, "J.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.4.1. Psychology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4.1">http://acm.rkbexplorer.com/ontologies/acm#J.4.1</seealso>
    let ``J.4.1`` = Prefixed_Name(acm, "J.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.4.2. Sociology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4.2">http://acm.rkbexplorer.com/ontologies/acm#J.4.2</seealso>
    let ``J.4.2`` = Prefixed_Name(acm, "J.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5.5. Literature</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.5">http://acm.rkbexplorer.com/ontologies/acm#J.5.5</seealso>
    let ``J.5.5`` = Prefixed_Name(acm, "J.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>J.5.6. Music</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.6">http://acm.rkbexplorer.com/ontologies/acm#J.5.6</seealso>
    let ``J.5.6`` = Prefixed_Name(acm, "J.5.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5.7. Performing arts</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.7">http://acm.rkbexplorer.com/ontologies/acm#J.5.7</seealso>
    let ``J.5.7`` = Prefixed_Name(acm, "J.5.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.6. COMPUTER-AIDED ENGINEERING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.6">http://acm.rkbexplorer.com/ontologies/acm#J.6</seealso>
    let ``J.6`` = Prefixed_Name(acm, "J.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.2. Industrial control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.2">http://acm.rkbexplorer.com/ontologies/acm#J.7.2</seealso>
    let ``J.7.2`` = Prefixed_Name(acm, "J.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.3. Military</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.3">http://acm.rkbexplorer.com/ontologies/acm#J.7.3</seealso>
    let ``J.7.3`` = Prefixed_Name(acm, "J.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.4. Process control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.4">http://acm.rkbexplorer.com/ontologies/acm#J.7.4</seealso>
    let ``J.7.4`` = Prefixed_Name(acm, "J.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.5. Publishing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.5">http://acm.rkbexplorer.com/ontologies/acm#J.7.5</seealso>
    let ``J.7.5`` = Prefixed_Name(acm, "J.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0">http://acm.rkbexplorer.com/ontologies/acm#A.0</seealso>
    let ``A.0`` = Prefixed_Name(acm, "A.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.1. INTRODUCTORY AND SURVEY</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.1">http://acm.rkbexplorer.com/ontologies/acm#A.1</seealso>
    let ``A.1`` = Prefixed_Name(acm, "A.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.m">http://acm.rkbexplorer.com/ontologies/acm#A.m</seealso>
    let ``A.m`` = Prefixed_Name(acm, "A.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.0">http://acm.rkbexplorer.com/ontologies/acm#B.0</seealso>
    let ``B.0`` = Prefixed_Name(acm, "B.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.0</seealso>
    let ``B.1.0`` = Prefixed_Name(acm, "B.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.1.0. Hardwired control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.1.0</seealso>
    let ``B.1.1.0`` = Prefixed_Name(acm, "B.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2.4. Multiple-instruction-stream, multiple-data-stream processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.4</seealso>
    let ``C.1.2.4`` = Prefixed_Name(acm, "C.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.2.6. Pipeline processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.6">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.6</seealso>
    let ``C.1.2.6`` = Prefixed_Name(acm, "C.1.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3. Other Architecture Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.3</seealso>
    let ``C.1.3`` = Prefixed_Name(acm, "C.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.1. Analog computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.1</seealso>
    let ``C.1.3.1`` = Prefixed_Name(acm, "C.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.4. Data-flow architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.4</seealso>
    let ``C.1.3.4`` = Prefixed_Name(acm, "C.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.7. Neural nets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.7">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.7</seealso>
    let ``C.1.3.7`` = Prefixed_Name(acm, "C.1.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.4. Parallel Architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.4</seealso>
    let ``C.1.4`` = Prefixed_Name(acm, "C.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.4.1. Mobile processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.4.1</seealso>
    let ``C.1.4.1`` = Prefixed_Name(acm, "C.1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.m.0. Analog computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.m.0</seealso>
    let ``C.1.m.0`` = Prefixed_Name(acm, "C.1.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.m.1. Hybrid systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.m.1</seealso>
    let ``C.1.m.1`` = Prefixed_Name(acm, "C.1.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.0</seealso>
    let ``C.2.0`` = Prefixed_Name(acm, "C.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.0.0. Data communications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.0.0</seealso>
    let ``C.2.0.0`` = Prefixed_Name(acm, "C.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.0. Asynchronous Transfer Mode</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.0</seealso>
    let ``C.2.1.0`` = Prefixed_Name(acm, "C.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.2.1.1. Centralized networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.1</seealso>
    let ``C.2.1.1`` = Prefixed_Name(acm, "C.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.4. Frame relay networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.4</seealso>
    let ``C.2.1.4`` = Prefixed_Name(acm, "C.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.5. ISDN</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.5">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.5</seealso>
    let ``C.2.1.5`` = Prefixed_Name(acm, "C.2.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.5. Coroutines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.5">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.5</seealso>
    let ``D.3.3.5`` = Prefixed_Name(acm, "D.3.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.6. Data types and structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.6">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.6</seealso>
    let ``D.3.3.6`` = Prefixed_Name(acm, "D.3.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.1. Convex programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.1</seealso>
    let ``G.1.6.1`` = Prefixed_Name(acm, "G.1.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.10. Stochastic programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.10</seealso>
    let ``G.1.6.10`` = Prefixed_Name(acm, "G.1.6.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.5. Least squares methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.5</seealso>
    let ``G.1.6.5`` = Prefixed_Name(acm, "G.1.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.6. Linear programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.6</seealso>
    let ``G.1.6.6`` = Prefixed_Name(acm, "G.1.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.0. Boundary value problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.0</seealso>
    let ``G.1.7.0`` = Prefixed_Name(acm, "G.1.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.1. Chaotic systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.1</seealso>
    let ``G.1.7.1`` = Prefixed_Name(acm, "G.1.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.6. Initial value problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.6</seealso>
    let ``G.1.7.6`` = Prefixed_Name(acm, "G.1.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.7. Multistep and multivalue methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.7</seealso>
    let ``G.1.7.7`` = Prefixed_Name(acm, "G.1.7.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.8. One-step methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.8</seealso>
    let ``G.1.7.8`` = Prefixed_Name(acm, "G.1.7.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.9. Stiff equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.9</seealso>
    let ``G.1.7.9`` = Prefixed_Name(acm, "G.1.7.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.11. Spectral methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.11">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.11</seealso>
    let ``G.1.8.11`` = Prefixed_Name(acm, "G.1.8.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.2. Finite difference methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.2</seealso>
    let ``G.1.8.2`` = Prefixed_Name(acm, "G.1.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.3. Finite element methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.3</seealso>
    let ``G.1.8.3`` = Prefixed_Name(acm, "G.1.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.4. Finite volume methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.4</seealso>
    let ``G.1.8.4`` = Prefixed_Name(acm, "G.1.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.9.0. Delay equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.0</seealso>
    let ``G.1.9.0`` = Prefixed_Name(acm, "G.1.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.9.1. Fredholm equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.1</seealso>
    let ``G.1.9.1`` = Prefixed_Name(acm, "G.1.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.9.2. Integro-differential equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.2</seealso>
    let ``G.1.9.2`` = Prefixed_Name(acm, "G.1.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.9.3. Volterra equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.3</seealso>
    let ``G.1.9.3`` = Prefixed_Name(acm, "G.1.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.14. Training, help, and documentation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.14">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.14</seealso>
    let ``H.5.2.14`` = Prefixed_Name(acm, "H.5.2.14") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.15. User-centered design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.15">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.15</seealso>
    let ``H.5.2.15`` = Prefixed_Name(acm, "H.5.2.15") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.16</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.16. User interface management systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.16">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.16</seealso>
    let ``H.5.2.16`` = Prefixed_Name(acm, "H.5.2.16") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.17</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.17. Voice I/O</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.17">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.17</seealso>
    let ``H.5.2.17`` = Prefixed_Name(acm, "H.5.2.17") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.3.0. Filtering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.0</seealso>
    let ``I.4.3.0`` = Prefixed_Name(acm, "I.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.3.1. Geometric correction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.1</seealso>
    let ``I.4.3.1`` = Prefixed_Name(acm, "I.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.3.2. Grayscale manipulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.2</seealso>
    let ``I.4.3.2`` = Prefixed_Name(acm, "I.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.3.3. Registration</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.3</seealso>
    let ``I.4.3.3`` = Prefixed_Name(acm, "I.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.4.1. Kalman filtering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.1</seealso>
    let ``I.4.4.1`` = Prefixed_Name(acm, "I.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.4.4.2. Pseudoinverse restoration</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.2</seealso>
    let ``I.4.4.2`` = Prefixed_Name(acm, "I.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.4.4.3. Wiener filtering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.3</seealso>
    let ``I.4.4.3`` = Prefixed_Name(acm, "I.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.5. Reconstruction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.5</seealso>
    let ``I.4.5`` = Prefixed_Name(acm, "I.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.2.</para>
    /// labels<para>B.1. CONTROL STRUCTURES AND MICROPROGRAMMING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1">http://acm.rkbexplorer.com/ontologies/acm#B.1</seealso>
    let ``B.1`` = Prefixed_Name(acm, "B.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.8.1. Reliability, Testing, and Fault-Tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.1">http://acm.rkbexplorer.com/ontologies/acm#B.8.1</seealso>
    let ``B.8.1`` = Prefixed_Name(acm, "B.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.2.0. Decision problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.0</seealso>
    let ``F.4.2.0`` = Prefixed_Name(acm, "F.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.0</seealso>
    let ``H.3.0`` = Prefixed_Name(acm, "H.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.1.6. Three-dimensional displays</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.6</seealso>
    let ``I.3.1.6`` = Prefixed_Name(acm, "I.3.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.2.2. Computing equipment management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.2</seealso>
    let ``K.6.2.2`` = Prefixed_Name(acm, "K.6.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.2.9.</para>
    /// labels<para>K.6.3. Software Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.3</seealso>
    let ``K.6.3`` = Prefixed_Name(acm, "K.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.3.2. Software process</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.2</seealso>
    let ``K.6.3.2`` = Prefixed_Name(acm, "K.6.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.1.1. Syntax</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.1.1</seealso>
    let ``D.3.1.1`` = Prefixed_Name(acm, "D.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.4. Multiple precision arithmetic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.4</seealso>
    let ``G.1.0.4`` = Prefixed_Name(acm, "G.1.0.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.6. Parallel algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.6</seealso>
    let ``G.1.0.6`` = Prefixed_Name(acm, "G.1.0.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #I.3.5, #I.3.7.</para>
    /// labels<para>G.1.1. Interpolation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.1</seealso>
    let ``G.1.1`` = Prefixed_Name(acm, "G.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.1.2. Interpolation formulas</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.2</seealso>
    let ``G.1.1.2`` = Prefixed_Name(acm, "G.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.0. Approximation of surfaces and contours</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.0</seealso>
    let ``G.1.2.0`` = Prefixed_Name(acm, "G.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.11. Wavelets and fractals</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.11">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.11</seealso>
    let ``G.1.2.11`` = Prefixed_Name(acm, "G.1.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.3. Fast Fourier transforms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.3</seealso>
    let ``G.1.2.3`` = Prefixed_Name(acm, "G.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.6. Minimax approximation and algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.6</seealso>
    let ``G.1.2.6`` = Prefixed_Name(acm, "G.1.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.7. Nonlinear approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.7</seealso>
    let ``G.1.2.7`` = Prefixed_Name(acm, "G.1.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.0. Conditioning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.0</seealso>
    let ``G.1.3.0`` = Prefixed_Name(acm, "G.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.4. Linear systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.4</seealso>
    let ``G.1.3.4`` = Prefixed_Name(acm, "G.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.1.3.6. Pseudoinverses</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.6</seealso>
    let ``G.1.3.6`` = Prefixed_Name(acm, "G.1.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.7. Singular value decomposition</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.7</seealso>
    let ``G.1.3.7`` = Prefixed_Name(acm, "G.1.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.2.1.</para>
    /// labels<para>G.1.4. Quadrature and Numerical Differentiation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.4</seealso>
    let ``G.1.4`` = Prefixed_Name(acm, "G.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.0. Adaptive and iterative quadrature</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.0</seealso>
    let ``G.1.4.0`` = Prefixed_Name(acm, "G.1.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.3. Error analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.3</seealso>
    let ``G.1.4.3`` = Prefixed_Name(acm, "G.1.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.4. Finite difference methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.4</seealso>
    let ``G.1.4.4`` = Prefixed_Name(acm, "G.1.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.7. Multidimensional quadrature</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.7</seealso>
    let ``G.1.4.7`` = Prefixed_Name(acm, "G.1.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5. Roots of Nonlinear Equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.5</seealso>
    let ``G.1.5`` = Prefixed_Name(acm, "G.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.3.3. Information browsers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.3</seealso>
    let ``H.4.3.3`` = Prefixed_Name(acm, "H.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.3.4. Videotex</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.4</seealso>
    let ``H.4.3.4`` = Prefixed_Name(acm, "H.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.6.3. Interaction techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.3</seealso>
    let ``I.3.6.3`` = Prefixed_Name(acm, "I.3.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.6.4. Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.4</seealso>
    let ``I.3.6.4`` = Prefixed_Name(acm, "I.3.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.2. Fractals</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.2</seealso>
    let ``I.3.7.2`` = Prefixed_Name(acm, "I.3.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.3. Hidden line/surface removal</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.3</seealso>
    let ``I.3.7.3`` = Prefixed_Name(acm, "I.3.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.m">http://acm.rkbexplorer.com/ontologies/acm#I.3.m</seealso>
    let ``I.3.m`` = Prefixed_Name(acm, "I.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4. IMAGE PROCESSING AND COMPUTER VISION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4">http://acm.rkbexplorer.com/ontologies/acm#I.4</seealso>
    let ``I.4`` = Prefixed_Name(acm, "I.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.0.0. Image displays</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.0.0</seealso>
    let ``I.4.0.0`` = Prefixed_Name(acm, "I.4.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.0.1. Image processing software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.0.1</seealso>
    let ``I.4.0.1`` = Prefixed_Name(acm, "I.4.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1. Digitization and Image Capture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.1</seealso>
    let ``I.4.1`` = Prefixed_Name(acm, "I.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.0. Camera calibration</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.0</seealso>
    let ``I.4.1.0`` = Prefixed_Name(acm, "I.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.1.2. Writable control store</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.1.2</seealso>
    let ``B.1.1.2`` = Prefixed_Name(acm, "B.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.2.2. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.2.2</seealso>
    let ``B.1.2.2`` = Prefixed_Name(acm, "B.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.3.1. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.1</seealso>
    let ``B.1.3.1`` = Prefixed_Name(acm, "B.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.3.3. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.3</seealso>
    let ``B.1.3.3`` = Prefixed_Name(acm, "B.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.4.0. Firmware engineering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.0</seealso>
    let ``B.1.4.0`` = Prefixed_Name(acm, "B.1.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.2.0. Built-in tests</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.0</seealso>
    let ``B.6.2.0`` = Prefixed_Name(acm, "B.6.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.0. Assertion checkers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.0</seealso>
    let ``D.2.4.0`` = Prefixed_Name(acm, "D.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.m">http://acm.rkbexplorer.com/ontologies/acm#F.1.m</seealso>
    let ``F.1.m`` = Prefixed_Name(acm, "F.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.1.0. Computation of transforms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.0</seealso>
    let ``F.2.1.0`` = Prefixed_Name(acm, "F.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.1.1. Computations in finite fields</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.1</seealso>
    let ``F.2.1.1`` = Prefixed_Name(acm, "F.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.0. Complexity of proof procedures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.0</seealso>
    let ``F.2.2.0`` = Prefixed_Name(acm, "F.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.4. Parallel databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.4</seealso>
    let ``H.2.4.4`` = Prefixed_Name(acm, "H.2.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.5. Query processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.5">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.5</seealso>
    let ``H.2.4.5`` = Prefixed_Name(acm, "H.2.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7. Natural Language Processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.7</seealso>
    let ``I.2.7`` = Prefixed_Name(acm, "I.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.0. Discourse</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.0</seealso>
    let ``I.2.7.0`` = Prefixed_Name(acm, "I.2.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.2. Language models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.2</seealso>
    let ``I.2.7.2`` = Prefixed_Name(acm, "I.2.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.3. Language parsing and understanding</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.3</seealso>
    let ``I.2.7.3`` = Prefixed_Name(acm, "I.2.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.6. Text analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.6</seealso>
    let ``I.2.7.6`` = Prefixed_Name(acm, "I.2.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.2.2.</para>
    /// labels<para>I.2.8. Problem Solving, Control Methods, and Search</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8">http://acm.rkbexplorer.com/ontologies/acm#I.2.8</seealso>
    let ``I.2.8`` = Prefixed_Name(acm, "I.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.1. Control theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.1</seealso>
    let ``I.2.8.1`` = Prefixed_Name(acm, "I.2.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.2. Dynamic programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.2</seealso>
    let ``I.2.8.2`` = Prefixed_Name(acm, "I.2.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.4. Heuristic methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.4</seealso>
    let ``I.2.8.4`` = Prefixed_Name(acm, "I.2.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.5. Plan execution, formation, and generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.5</seealso>
    let ``I.2.8.5`` = Prefixed_Name(acm, "I.2.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2. Computer and Information Science Education</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2">http://acm.rkbexplorer.com/ontologies/acm#K.3.2</seealso>
    let ``K.3.2`` = Prefixed_Name(acm, "K.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2.0. Accreditation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.0</seealso>
    let ``K.3.2.0`` = Prefixed_Name(acm, "K.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2.1. Computer science education</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.1</seealso>
    let ``K.3.2.1`` = Prefixed_Name(acm, "K.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2.2. Curriculum</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.2</seealso>
    let ``K.3.2.2`` = Prefixed_Name(acm, "K.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2.5. Self-assessment</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.5</seealso>
    let ``K.3.2.5`` = Prefixed_Name(acm, "K.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m">http://acm.rkbexplorer.com/ontologies/acm#K.3.m</seealso>
    let ``K.3.m`` = Prefixed_Name(acm, "K.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.3.m.0. Accreditation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.m.0</seealso>
    let ``K.3.m.0`` = Prefixed_Name(acm, "K.3.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.3.m.1. Computer literacy</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.m.1</seealso>
    let ``K.3.m.1`` = Prefixed_Name(acm, "K.3.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.1.1. Receivers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.1.1</seealso>
    let ``B.4.1.1`` = Prefixed_Name(acm, "B.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.2.1. Data terminals and printers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.1</seealso>
    let ``B.4.2.1`` = Prefixed_Name(acm, "B.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.0.1. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.0.1</seealso>
    let ``D.2.0.1`` = Prefixed_Name(acm, "D.2.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.1.2. Methodologies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.2</seealso>
    let ``D.2.1.2`` = Prefixed_Name(acm, "D.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.1.3. Tools</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.3</seealso>
    let ``D.2.1.3`` = Prefixed_Name(acm, "D.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.0">http://acm.rkbexplorer.com/ontologies/acm#H.0</seealso>
    let ``H.0`` = Prefixed_Name(acm, "H.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.3.2. Special-purpose algebraic systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.2</seealso>
    let ``I.1.3.2`` = Prefixed_Name(acm, "I.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.3.1. Similarity measures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.3.1</seealso>
    let ``I.5.3.1`` = Prefixed_Name(acm, "I.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.4.1. Signal processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.1</seealso>
    let ``I.5.4.1`` = Prefixed_Name(acm, "I.5.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.5.0. Interactive systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.5.0</seealso>
    let ``I.5.5.0`` = Prefixed_Name(acm, "I.5.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.2.0. Automatic synthesis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.2.0</seealso>
    let ``B.1.2.0`` = Prefixed_Name(acm, "B.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.3.0. Diagnostics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.0</seealso>
    let ``B.1.3.0`` = Prefixed_Name(acm, "B.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.3.2. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.2</seealso>
    let ``B.1.3.2`` = Prefixed_Name(acm, "B.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.2.2, #D.2.4, #D.3.2, #D.3.4.</para>
    /// labels<para>B.1.4. Microprogram Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.1.4</seealso>
    let ``B.1.4`` = Prefixed_Name(acm, "B.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.1.3. Memory control and access</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.3</seealso>
    let ``B.6.1.3`` = Prefixed_Name(acm, "B.6.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.1. Logical Design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.1</seealso>
    let ``H.2.1`` = Prefixed_Name(acm, "H.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.2. Physical Design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.2</seealso>
    let ``H.2.2`` = Prefixed_Name(acm, "H.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.7. Shape</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.7</seealso>
    let ``I.2.10.7`` = Prefixed_Name(acm, "I.2.10.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.7.0. Environments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.7.0</seealso>
    let ``I.6.7.0`` = Prefixed_Name(acm, "I.6.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8. Types of Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8">http://acm.rkbexplorer.com/ontologies/acm#I.6.8</seealso>
    let ``I.6.8`` = Prefixed_Name(acm, "I.6.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.2. Continuous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.2">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.2</seealso>
    let ``I.6.8.2`` = Prefixed_Name(acm, "I.6.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.6. Monte Carlo</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.6">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.6</seealso>
    let ``I.6.8.6`` = Prefixed_Name(acm, "I.6.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #H.4, #H.5.</para>
    /// labels<para>I.7. DOCUMENT AND TEXT PROCESSING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7">http://acm.rkbexplorer.com/ontologies/acm#I.7</seealso>
    let ``I.7`` = Prefixed_Name(acm, "I.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.0</seealso>
    let ``I.7.0`` = Prefixed_Name(acm, "I.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.1.3. Version control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.3</seealso>
    let ``I.7.1.3`` = Prefixed_Name(acm, "I.7.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2. Document Preparation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.2</seealso>
    let ``I.7.2`` = Prefixed_Name(acm, "I.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.4. Languages and systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.4">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.4</seealso>
    let ``I.7.2.4`` = Prefixed_Name(acm, "I.7.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.5. Markup languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.5">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.5</seealso>
    let ``I.7.2.5`` = Prefixed_Name(acm, "I.7.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.7.3. Index Generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.3</seealso>
    let ``I.7.3`` = Prefixed_Name(acm, "I.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #H.5.4, #J.7, #I.4.1.</para>
    /// labels<para>I.7.4. Electronic Publishing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.7.4</seealso>
    let ``I.7.4`` = Prefixed_Name(acm, "I.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.3.5. Topology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.5">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.5</seealso>
    let ``B.4.3.5`` = Prefixed_Name(acm, "B.4.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.4.3. Worst-case analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.3</seealso>
    let ``B.4.4.3`` = Prefixed_Name(acm, "B.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.5.3. Hardware reliability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.3</seealso>
    let ``B.4.5.3`` = Prefixed_Name(acm, "B.4.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.7. User interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.7">http://acm.rkbexplorer.com/ontologies/acm#G.4.7</seealso>
    let ``G.4.7`` = Prefixed_Name(acm, "G.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1. MODELS AND PRINCIPLES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1">http://acm.rkbexplorer.com/ontologies/acm#H.1</seealso>
    let ``H.1`` = Prefixed_Name(acm, "H.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.2. User/Machine Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.1.2</seealso>
    let ``H.1.2`` = Prefixed_Name(acm, "H.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.5.</para>
    /// labels<para>H.2. DATABASE MANAGEMENT</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2">http://acm.rkbexplorer.com/ontologies/acm#H.2</seealso>
    let ``H.2`` = Prefixed_Name(acm, "H.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #I.4.8, #I.5.</para>
    /// labels<para>I.2.10. Vision and Scene Understanding</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10">http://acm.rkbexplorer.com/ontologies/acm#I.2.10</seealso>
    let ``I.2.10`` = Prefixed_Name(acm, "I.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.0. 3D/stereo scene analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.0</seealso>
    let ``I.2.10.0`` = Prefixed_Name(acm, "I.2.10.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.5. Perceptual reasoning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.5</seealso>
    let ``I.2.10.5`` = Prefixed_Name(acm, "I.2.10.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.6. Representations, data structures, and transforms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.6</seealso>
    let ``I.2.10.6`` = Prefixed_Name(acm, "I.2.10.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.8. Texture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.8">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.8</seealso>
    let ``I.2.10.8`` = Prefixed_Name(acm, "I.2.10.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.9. Video analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.9">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.9</seealso>
    let ``I.2.10.9`` = Prefixed_Name(acm, "I.2.10.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.0. Animation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.0</seealso>
    let ``I.6.8.0`` = Prefixed_Name(acm, "I.6.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.1. Combined</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.1">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.1</seealso>
    let ``I.6.8.1`` = Prefixed_Name(acm, "I.6.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.3. Discrete event</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.3">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.3</seealso>
    let ``I.6.8.3`` = Prefixed_Name(acm, "I.6.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.4. Distributed</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.4">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.4</seealso>
    let ``I.6.8.4`` = Prefixed_Name(acm, "I.6.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.7. Parallel</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.7">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.7</seealso>
    let ``I.6.8.7`` = Prefixed_Name(acm, "I.6.8.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.8. Visual</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.8">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.8</seealso>
    let ``I.6.8.8`` = Prefixed_Name(acm, "I.6.8.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.1.0. Document management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.0</seealso>
    let ``I.7.1.0`` = Prefixed_Name(acm, "I.7.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.7.1.1. Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.1</seealso>
    let ``I.7.1.1`` = Prefixed_Name(acm, "I.7.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.2. Hypertext/hypermedia</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.2</seealso>
    let ``I.7.2.2`` = Prefixed_Name(acm, "I.7.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.3. Index generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.3</seealso>
    let ``I.7.2.3`` = Prefixed_Name(acm, "I.7.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.8. Scripting languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.8">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.8</seealso>
    let ``I.7.2.8`` = Prefixed_Name(acm, "I.7.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.9. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.9">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.9</seealso>
    let ``I.7.2.9`` = Prefixed_Name(acm, "I.7.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.4.0. Document analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.0</seealso>
    let ``I.7.4.0`` = Prefixed_Name(acm, "I.7.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.4.3. Scanning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.3</seealso>
    let ``I.7.4.3`` = Prefixed_Name(acm, "I.7.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.m">http://acm.rkbexplorer.com/ontologies/acm#I.7.m</seealso>
    let ``I.7.m`` = Prefixed_Name(acm, "I.7.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.m">http://acm.rkbexplorer.com/ontologies/acm#I.m</seealso>
    let ``I.m`` = Prefixed_Name(acm, "I.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:J</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J. Computer Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J">http://acm.rkbexplorer.com/ontologies/acm#J</seealso>
    let J = Prefixed_Name(acm, "J") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.0. Business</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.0">http://acm.rkbexplorer.com/ontologies/acm#J.1.0</seealso>
    let ``J.1.0`` = Prefixed_Name(acm, "J.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.1. Education</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.1">http://acm.rkbexplorer.com/ontologies/acm#J.1.1</seealso>
    let ``J.1.1`` = Prefixed_Name(acm, "J.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.2. Financial</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.2">http://acm.rkbexplorer.com/ontologies/acm#J.1.2</seealso>
    let ``J.1.2`` = Prefixed_Name(acm, "J.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1.3. Government</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.3">http://acm.rkbexplorer.com/ontologies/acm#J.1.3</seealso>
    let ``J.1.3`` = Prefixed_Name(acm, "J.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2. PHYSICAL SCIENCES AND ENGINEERING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2">http://acm.rkbexplorer.com/ontologies/acm#J.2</seealso>
    let ``J.2`` = Prefixed_Name(acm, "J.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.0. Aerospace</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.0">http://acm.rkbexplorer.com/ontologies/acm#J.2.0</seealso>
    let ``J.2.0`` = Prefixed_Name(acm, "J.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.1. Archaeology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.1">http://acm.rkbexplorer.com/ontologies/acm#J.2.1</seealso>
    let ``J.2.1`` = Prefixed_Name(acm, "J.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.2. Astronomy</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.2">http://acm.rkbexplorer.com/ontologies/acm#J.2.2</seealso>
    let ``J.2.2`` = Prefixed_Name(acm, "J.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.8. Physics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.8">http://acm.rkbexplorer.com/ontologies/acm#J.2.8</seealso>
    let ``J.2.8`` = Prefixed_Name(acm, "J.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.3. LIFE AND MEDICAL SCIENCES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3">http://acm.rkbexplorer.com/ontologies/acm#J.3</seealso>
    let ``J.3`` = Prefixed_Name(acm, "J.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.3.0. Biology and genetics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3.0">http://acm.rkbexplorer.com/ontologies/acm#J.3.0</seealso>
    let ``J.3.0`` = Prefixed_Name(acm, "J.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.3.1. Health</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3.1">http://acm.rkbexplorer.com/ontologies/acm#J.3.1</seealso>
    let ``J.3.1`` = Prefixed_Name(acm, "J.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5.0. Architecture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.0">http://acm.rkbexplorer.com/ontologies/acm#J.5.0</seealso>
    let ``J.5.0`` = Prefixed_Name(acm, "J.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>J.5.1. Arts, fine and performing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.1">http://acm.rkbexplorer.com/ontologies/acm#J.5.1</seealso>
    let ``J.5.1`` = Prefixed_Name(acm, "J.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5.2. Fine arts</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.2">http://acm.rkbexplorer.com/ontologies/acm#J.5.2</seealso>
    let ``J.5.2`` = Prefixed_Name(acm, "J.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5.3. Language translation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.3">http://acm.rkbexplorer.com/ontologies/acm#J.5.3</seealso>
    let ``J.5.3`` = Prefixed_Name(acm, "J.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.6.1. Computer-aided manufacturing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.6.1">http://acm.rkbexplorer.com/ontologies/acm#J.6.1</seealso>
    let ``J.6.1`` = Prefixed_Name(acm, "J.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.3.</para>
    /// labels<para>J.7. COMPUTERS IN OTHER SYSTEMS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7">http://acm.rkbexplorer.com/ontologies/acm#J.7</seealso>
    let ``J.7`` = Prefixed_Name(acm, "J.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.0. Command and control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.0">http://acm.rkbexplorer.com/ontologies/acm#J.7.0</seealso>
    let ``J.7.0`` = Prefixed_Name(acm, "J.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.1. Consumer products</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.1">http://acm.rkbexplorer.com/ontologies/acm#J.7.1</seealso>
    let ``J.7.1`` = Prefixed_Name(acm, "J.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.7.6. Real time</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.6">http://acm.rkbexplorer.com/ontologies/acm#J.7.6</seealso>
    let ``J.7.6`` = Prefixed_Name(acm, "J.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.m">http://acm.rkbexplorer.com/ontologies/acm#J.m</seealso>
    let ``J.m`` = Prefixed_Name(acm, "J.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K. Computing Milieux</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K">http://acm.rkbexplorer.com/ontologies/acm#K</seealso>
    let K = Prefixed_Name(acm, "K") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.0">http://acm.rkbexplorer.com/ontologies/acm#K.0</seealso>
    let ``K.0`` = Prefixed_Name(acm, "K.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.2.0. Automatic synthesis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.0</seealso>
    let ``B.5.2.0`` = Prefixed_Name(acm, "B.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.1.2. Value of information</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.1.1.2</seealso>
    let ``H.1.1.2`` = Prefixed_Name(acm, "H.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.2.2. Nonalgebraic algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.1.2.2</seealso>
    let ``I.1.2.2`` = Prefixed_Name(acm, "I.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.3.0. Evaluation strategies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.0</seealso>
    let ``I.1.3.0`` = Prefixed_Name(acm, "I.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.1.3.1. Nonprocedural languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.1</seealso>
    let ``I.1.3.1`` = Prefixed_Name(acm, "I.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.1.3.3. Special-purpose hardware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.3</seealso>
    let ``I.1.3.3`` = Prefixed_Name(acm, "I.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.3. Clustering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3">http://acm.rkbexplorer.com/ontologies/acm#I.5.3</seealso>
    let ``I.5.3`` = Prefixed_Name(acm, "I.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.3.0. Algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.3.0</seealso>
    let ``I.5.3.0`` = Prefixed_Name(acm, "I.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.4. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4">http://acm.rkbexplorer.com/ontologies/acm#I.5.4</seealso>
    let ``I.5.4`` = Prefixed_Name(acm, "I.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.4.0. Computer vision</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.0</seealso>
    let ``I.5.4.0`` = Prefixed_Name(acm, "I.5.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.0</seealso>
    let ``B.6.0`` = Prefixed_Name(acm, "B.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.5.3. Sorting/searching</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.3">http://acm.rkbexplorer.com/ontologies/acm#E.5.3</seealso>
    let ``E.5.3`` = Prefixed_Name(acm, "E.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.1.2. Computability theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.2</seealso>
    let ``F.1.1.2`` = Prefixed_Name(acm, "F.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.1.2. Schema and subschema</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.1.2</seealso>
    let ``H.2.1.2`` = Prefixed_Name(acm, "H.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.2.2. Recovery and restart</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.2.2</seealso>
    let ``H.2.2.2`` = Prefixed_Name(acm, "H.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.3. Logic programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.3</seealso>
    let ``I.2.3.3`` = Prefixed_Name(acm, "I.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.4. Mathematical induction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.4</seealso>
    let ``I.2.3.4`` = Prefixed_Name(acm, "I.2.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.7. Resolution</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.7</seealso>
    let ``I.2.3.7`` = Prefixed_Name(acm, "I.2.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.8.5. Gaming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.5">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.5</seealso>
    let ``I.6.8.5`` = Prefixed_Name(acm, "I.6.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.m">http://acm.rkbexplorer.com/ontologies/acm#I.6.m</seealso>
    let ``I.6.m`` = Prefixed_Name(acm, "I.6.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.1. Document and Text Editing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.1</seealso>
    let ``I.7.1`` = Prefixed_Name(acm, "I.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.7.1.2. Spelling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.2</seealso>
    let ``I.7.1.2`` = Prefixed_Name(acm, "I.7.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.0. Desktop publishing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.0</seealso>
    let ``I.7.2.0`` = Prefixed_Name(acm, "I.7.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.1. Format and notation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.1</seealso>
    let ``I.7.2.1`` = Prefixed_Name(acm, "I.7.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.6. Multi/mixed media</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.6">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.6</seealso>
    let ``I.7.2.6`` = Prefixed_Name(acm, "I.7.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.2.7. Photocomposition/typesetting</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.7">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.7</seealso>
    let ``I.7.2.7`` = Prefixed_Name(acm, "I.7.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.4.1. Graphics recognition and interpretation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.1</seealso>
    let ``I.7.4.1`` = Prefixed_Name(acm, "I.7.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.7.4.2. Optical character recognition</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.2</seealso>
    let ``I.7.4.2`` = Prefixed_Name(acm, "I.7.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.0">http://acm.rkbexplorer.com/ontologies/acm#J.0</seealso>
    let ``J.0`` = Prefixed_Name(acm, "J.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.1. ADMINISTRATIVE DATA PROCESSING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1">http://acm.rkbexplorer.com/ontologies/acm#J.1</seealso>
    let ``J.1`` = Prefixed_Name(acm, "J.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.4.1. Languages and compilers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.1</seealso>
    let ``B.1.4.1`` = Prefixed_Name(acm, "B.1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.7. Symbolic execution</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.7</seealso>
    let ``D.2.5.7`` = Prefixed_Name(acm, "D.2.5.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.1.1. Invariants</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.1</seealso>
    let ``F.3.1.1`` = Prefixed_Name(acm, "F.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.6. Parameter learning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.6</seealso>
    let ``I.2.6.6`` = Prefixed_Name(acm, "I.2.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.1. Language generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.1</seealso>
    let ``I.2.7.1`` = Prefixed_Name(acm, "I.2.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.5. Speech recognition and synthesis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.5</seealso>
    let ``I.2.7.5`` = Prefixed_Name(acm, "I.2.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.1.2. Computer-managed instruction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.2</seealso>
    let ``K.3.1.2`` = Prefixed_Name(acm, "K.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.1.3. Distance learning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.3</seealso>
    let ``K.3.1.3`` = Prefixed_Name(acm, "K.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2.3. Information systems education</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.3</seealso>
    let ``K.3.2.3`` = Prefixed_Name(acm, "K.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.2.4. Literacy</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.4</seealso>
    let ``K.3.2.4`` = Prefixed_Name(acm, "K.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3. Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.3</seealso>
    let ``B.6.3`` = Prefixed_Name(acm, "B.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3.4. Switching theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.4</seealso>
    let ``B.6.3.4`` = Prefixed_Name(acm, "B.6.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3.5. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.5">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.5</seealso>
    let ``B.6.3.5`` = Prefixed_Name(acm, "B.6.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7. INTEGRATED CIRCUITS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7">http://acm.rkbexplorer.com/ontologies/acm#B.7</seealso>
    let ``B.7`` = Prefixed_Name(acm, "B.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.2. Gate arrays</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.2</seealso>
    let ``B.7.1.2`` = Prefixed_Name(acm, "B.7.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.3. Input/output circuits</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.3</seealso>
    let ``B.7.1.3`` = Prefixed_Name(acm, "B.7.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.7.0. Corrections</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.0</seealso>
    let ``D.2.7.0`` = Prefixed_Name(acm, "D.2.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.7.2. Enhancement</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.2</seealso>
    let ``D.2.7.2`` = Prefixed_Name(acm, "D.2.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.7.0. Data dictionary/directory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.0</seealso>
    let ``H.2.7.0`` = Prefixed_Name(acm, "H.2.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.7.2. Logging and recovery</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.2</seealso>
    let ``H.2.7.2`` = Prefixed_Name(acm, "H.2.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.7. Workcell organization and planning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.7</seealso>
    let ``I.2.9.7`` = Prefixed_Name(acm, "I.2.9.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.m">http://acm.rkbexplorer.com/ontologies/acm#I.2.m</seealso>
    let ``I.2.m`` = Prefixed_Name(acm, "I.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.0</seealso>
    let ``I.3.0`` = Prefixed_Name(acm, "I.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.3. Organizational Impacts</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.3</seealso>
    let ``K.4.3`` = Prefixed_Name(acm, "K.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.3.1. Computer-supported collaborative work</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.1</seealso>
    let ``K.4.3.1`` = Prefixed_Name(acm, "K.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.3.2. Employment</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.2</seealso>
    let ``K.4.3.2`` = Prefixed_Name(acm, "K.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.4.2. Electronic data interchange</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.2</seealso>
    let ``K.4.4.2`` = Prefixed_Name(acm, "K.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.4.3. Intellectual property</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.3</seealso>
    let ``K.4.4.3`` = Prefixed_Name(acm, "K.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.4.2. Machine-independent microcode generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.2</seealso>
    let ``B.1.4.2`` = Prefixed_Name(acm, "B.1.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.4.3. Optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.3</seealso>
    let ``B.1.4.3`` = Prefixed_Name(acm, "B.1.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.m">http://acm.rkbexplorer.com/ontologies/acm#B.6.m</seealso>
    let ``B.6.m`` = Prefixed_Name(acm, "B.6.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.3.4. Relations among complexity measures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.4</seealso>
    let ``F.1.3.4`` = Prefixed_Name(acm, "F.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.3. Object-oriented databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.3</seealso>
    let ``H.2.4.3`` = Prefixed_Name(acm, "H.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.0. Frames and scripts</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.0</seealso>
    let ``I.2.4.0`` = Prefixed_Name(acm, "I.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.2.3. Chemistry</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.3">http://acm.rkbexplorer.com/ontologies/acm#J.2.3</seealso>
    let ``J.2.3`` = Prefixed_Name(acm, "J.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.3.2. Medical information systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3.2">http://acm.rkbexplorer.com/ontologies/acm#J.3.2</seealso>
    let ``J.3.2`` = Prefixed_Name(acm, "J.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5. ARTS AND HUMANITIES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5">http://acm.rkbexplorer.com/ontologies/acm#J.5</seealso>
    let ``J.5`` = Prefixed_Name(acm, "J.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.5.4. Linguistics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.4">http://acm.rkbexplorer.com/ontologies/acm#J.5.4</seealso>
    let ``J.5.4`` = Prefixed_Name(acm, "J.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>J.6.0. Computer-aided design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.6.0">http://acm.rkbexplorer.com/ontologies/acm#J.6.0</seealso>
    let ``J.6.0`` = Prefixed_Name(acm, "J.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.5. Microcode Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5">http://acm.rkbexplorer.com/ontologies/acm#B.1.5</seealso>
    let ``B.1.5`` = Prefixed_Name(acm, "B.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.5.2. Instruction set interpretation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.2</seealso>
    let ``B.1.5.2`` = Prefixed_Name(acm, "B.1.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.2.3. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.3</seealso>
    let ``B.7.2.3`` = Prefixed_Name(acm, "B.7.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.8.2. Process metrics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.2</seealso>
    let ``D.2.8.2`` = Prefixed_Name(acm, "D.2.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.8.3. Product metrics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.3</seealso>
    let ``D.2.8.3`` = Prefixed_Name(acm, "D.2.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.10. Temporal logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.10">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.10</seealso>
    let ``F.4.1.10`` = Prefixed_Name(acm, "F.4.1.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3. INFORMATION STORAGE AND RETRIEVAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3">http://acm.rkbexplorer.com/ontologies/acm#H.3</seealso>
    let ``H.3`` = Prefixed_Name(acm, "H.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3. COMPUTER GRAPHICS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3">http://acm.rkbexplorer.com/ontologies/acm#I.3</seealso>
    let ``I.3`` = Prefixed_Name(acm, "I.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.4.2.3. Handicapped persons/special needs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.3</seealso>
    let ``K.4.2.3`` = Prefixed_Name(acm, "K.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.3.0. Automation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.0</seealso>
    let ``K.4.3.0`` = Prefixed_Name(acm, "K.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.3.3. Reengineering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.3</seealso>
    let ``K.4.3.3`` = Prefixed_Name(acm, "K.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.4.0. Cybercash, digital cash</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.0</seealso>
    let ``K.4.4.0`` = Prefixed_Name(acm, "K.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.4.1. Distributed commercial transactions</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.1</seealso>
    let ``K.4.4.1`` = Prefixed_Name(acm, "K.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.5.0. Direct data manipulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.0</seealso>
    let ``B.1.5.0`` = Prefixed_Name(acm, "B.1.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.7.1. Documentation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.1</seealso>
    let ``D.2.7.1`` = Prefixed_Name(acm, "D.2.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.7. Database Administration</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7">http://acm.rkbexplorer.com/ontologies/acm#H.2.7</seealso>
    let ``H.2.7`` = Prefixed_Name(acm, "H.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.7.1. Data warehouse and repository</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.1</seealso>
    let ``H.2.7.1`` = Prefixed_Name(acm, "H.2.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.7.4. Machine translation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.4</seealso>
    let ``I.2.7.4`` = Prefixed_Name(acm, "I.2.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.0. Backtracking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.0</seealso>
    let ``I.2.8.0`` = Prefixed_Name(acm, "I.2.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.3. Graph and tree search strategies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.3</seealso>
    let ``I.2.8.3`` = Prefixed_Name(acm, "I.2.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.8.6. Scheduling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.6</seealso>
    let ``I.2.8.6`` = Prefixed_Name(acm, "I.2.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.5.4. Special-purpose</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.4">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.4</seealso>
    let ``B.1.5.4`` = Prefixed_Name(acm, "B.1.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.0</seealso>
    let ``B.2.0`` = Prefixed_Name(acm, "B.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.1.0. Calculator</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.1.0</seealso>
    let ``B.2.1.0`` = Prefixed_Name(acm, "B.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1. PROCESSOR ARCHITECTURES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1">http://acm.rkbexplorer.com/ontologies/acm#C.1</seealso>
    let ``C.1`` = Prefixed_Name(acm, "C.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.3. Data-flow languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.3</seealso>
    let ``D.3.2.3`` = Prefixed_Name(acm, "D.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3. Numerical Linear Algebra</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.3</seealso>
    let ``G.1.3`` = Prefixed_Name(acm, "G.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.3. Error analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.3</seealso>
    let ``G.1.3.3`` = Prefixed_Name(acm, "G.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.5. Matrix inversion</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.5</seealso>
    let ``G.1.3.5`` = Prefixed_Name(acm, "G.1.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.8. Sparse, structured, and very large systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.8</seealso>
    let ``G.1.3.8`` = Prefixed_Name(acm, "G.1.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.1. Automatic differentiation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.1</seealso>
    let ``G.1.4.1`` = Prefixed_Name(acm, "G.1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.6. Iterative methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.6</seealso>
    let ``G.1.4.6`` = Prefixed_Name(acm, "G.1.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5.0. Continuation methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.0</seealso>
    let ``G.1.5.0`` = Prefixed_Name(acm, "G.1.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5.3. Iterative methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.3</seealso>
    let ``G.1.5.3`` = Prefixed_Name(acm, "G.1.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5.4. Polynomials, methods for</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.4</seealso>
    let ``G.1.5.4`` = Prefixed_Name(acm, "G.1.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5.5. Systems of equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.5</seealso>
    let ``G.1.5.5`` = Prefixed_Name(acm, "G.1.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.11. Unconstrained optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.11">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.11</seealso>
    let ``G.1.6.11`` = Prefixed_Name(acm, "G.1.6.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.2. Global optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.2</seealso>
    let ``G.1.6.2`` = Prefixed_Name(acm, "G.1.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.7. Nonlinear programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.7</seealso>
    let ``G.1.6.7`` = Prefixed_Name(acm, "G.1.6.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.8. Quadratic programming methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.8</seealso>
    let ``G.1.6.8`` = Prefixed_Name(acm, "G.1.6.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.2. Convergence and stability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.2</seealso>
    let ``G.1.7.2`` = Prefixed_Name(acm, "G.1.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.3. Differential-algebraic equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.3</seealso>
    let ``G.1.7.3`` = Prefixed_Name(acm, "G.1.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8. Partial Differential Equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.8</seealso>
    let ``G.1.8`` = Prefixed_Name(acm, "G.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.0. Domain decomposition methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.0</seealso>
    let ``G.1.8.0`` = Prefixed_Name(acm, "G.1.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.5. Hyperbolic equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.5</seealso>
    let ``G.1.8.5`` = Prefixed_Name(acm, "G.1.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.6. Inverse problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.6</seealso>
    let ``G.1.8.6`` = Prefixed_Name(acm, "G.1.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.9. Multigrid and multilevel methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.9</seealso>
    let ``G.1.8.9`` = Prefixed_Name(acm, "G.1.8.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.9. Integral Equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.9</seealso>
    let ``G.1.9`` = Prefixed_Name(acm, "G.1.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.0">http://acm.rkbexplorer.com/ontologies/acm#G.2.0</seealso>
    let ``G.2.0`` = Prefixed_Name(acm, "G.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.2.2.</para>
    /// labels<para>G.2.1. Combinatorics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1">http://acm.rkbexplorer.com/ontologies/acm#G.2.1</seealso>
    let ``G.2.1`` = Prefixed_Name(acm, "G.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.18</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.18. Windowing systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.18">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.18</seealso>
    let ``H.5.2.18`` = Prefixed_Name(acm, "H.5.2.18") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.2. Ergonomics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.2</seealso>
    let ``H.5.2.2`` = Prefixed_Name(acm, "H.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.3. Evaluation/methodology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.3</seealso>
    let ``H.5.2.3`` = Prefixed_Name(acm, "H.5.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.4. Graphical user interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.4</seealso>
    let ``H.5.2.4`` = Prefixed_Name(acm, "H.5.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.9. Prototyping</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.9">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.9</seealso>
    let ``H.5.2.9`` = Prefixed_Name(acm, "H.5.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3. Group and Organization Interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.3</seealso>
    let ``H.5.3`` = Prefixed_Name(acm, "H.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.0. Asynchronous interaction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.0</seealso>
    let ``H.5.3.0`` = Prefixed_Name(acm, "H.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.1. Collaborative computing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.1</seealso>
    let ``H.5.3.1`` = Prefixed_Name(acm, "H.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.4.3.4. Sharpening and deblurring</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.4</seealso>
    let ``I.4.3.4`` = Prefixed_Name(acm, "I.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.3.5. Smoothing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.5</seealso>
    let ``I.4.3.5`` = Prefixed_Name(acm, "I.4.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.4. Restoration</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.4</seealso>
    let ``I.4.4`` = Prefixed_Name(acm, "I.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.4.4.0. Inverse filtering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.0</seealso>
    let ``I.4.4.0`` = Prefixed_Name(acm, "I.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.m">http://acm.rkbexplorer.com/ontologies/acm#B.1.m</seealso>
    let ``B.1.m`` = Prefixed_Name(acm, "B.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.6. Software process models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.6</seealso>
    let ``D.2.9.6`` = Prefixed_Name(acm, "D.2.9.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.7. Software quality assurance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.7</seealso>
    let ``D.2.9.7`` = Prefixed_Name(acm, "D.2.9.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #J.1.</para>
    /// labels<para>K.4.4. Electronic Commerce</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4">http://acm.rkbexplorer.com/ontologies/acm#K.4.4</seealso>
    let ``K.4.4`` = Prefixed_Name(acm, "K.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2. ARITHMETIC AND LOGIC STRUCTURES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2">http://acm.rkbexplorer.com/ontologies/acm#B.2</seealso>
    let ``B.2`` = Prefixed_Name(acm, "B.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.8.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.0">http://acm.rkbexplorer.com/ontologies/acm#B.8.0</seealso>
    let ``B.8.0`` = Prefixed_Name(acm, "B.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.8.2. Performance Analysis and Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.2">http://acm.rkbexplorer.com/ontologies/acm#B.8.2</seealso>
    let ``B.8.2`` = Prefixed_Name(acm, "B.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.1.0. Semantics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.1.0</seealso>
    let ``D.3.1.0`` = Prefixed_Name(acm, "D.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.1. Conditioning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.1</seealso>
    let ``G.1.0.1`` = Prefixed_Name(acm, "G.1.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.2. Error analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.2</seealso>
    let ``G.1.0.2`` = Prefixed_Name(acm, "G.1.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.3. Interval arithmetic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.3</seealso>
    let ``G.1.0.3`` = Prefixed_Name(acm, "G.1.0.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.5. Numerical algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.5</seealso>
    let ``G.1.0.5`` = Prefixed_Name(acm, "G.1.0.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.7. Stability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.7</seealso>
    let ``G.1.0.7`` = Prefixed_Name(acm, "G.1.0.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.1.1.0. Difference formulas</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.0</seealso>
    let ``G.1.1.0`` = Prefixed_Name(acm, "G.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.1.4. Spline and piecewise polynomial interpolation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.4</seealso>
    let ``G.1.1.4`` = Prefixed_Name(acm, "G.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.10. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.10</seealso>
    let ``G.1.10`` = Prefixed_Name(acm, "G.1.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.1. Chebyshev approximation and theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.1</seealso>
    let ``G.1.2.1`` = Prefixed_Name(acm, "G.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.10. Spline and piecewise polynomial approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.10</seealso>
    let ``G.1.2.10`` = Prefixed_Name(acm, "G.1.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.4. Least squares approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.4</seealso>
    let ``G.1.2.4`` = Prefixed_Name(acm, "G.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.5. Linear approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.5</seealso>
    let ``G.1.2.5`` = Prefixed_Name(acm, "G.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.8. Rational approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.8</seealso>
    let ``G.1.2.8`` = Prefixed_Name(acm, "G.1.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.9. Special function approximations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.9</seealso>
    let ``G.1.2.9`` = Prefixed_Name(acm, "G.1.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.1.3.1. Determinants</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.1</seealso>
    let ``G.1.3.1`` = Prefixed_Name(acm, "G.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.3.2. Eigenvalues and eigenvectors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.2</seealso>
    let ``G.1.3.2`` = Prefixed_Name(acm, "G.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.1.3. Spreadsheets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.3</seealso>
    let ``H.4.1.3`` = Prefixed_Name(acm, "H.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.1.4. Time management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.4</seealso>
    let ``H.4.1.4`` = Prefixed_Name(acm, "H.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.3. Geometric algorithms, languages, and systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.3</seealso>
    let ``I.3.5.3`` = Prefixed_Name(acm, "I.3.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.4. Hierarchy and geometric transformations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.4</seealso>
    let ``I.3.5.4`` = Prefixed_Name(acm, "I.3.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.6. Object hierarchies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.6</seealso>
    let ``I.3.5.6`` = Prefixed_Name(acm, "I.3.5.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.7. Physically based modeling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.7</seealso>
    let ``I.3.5.7`` = Prefixed_Name(acm, "I.3.5.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.6. Methodology and Techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.6</seealso>
    let ``I.3.6`` = Prefixed_Name(acm, "I.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.6.0. Device independence</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.0</seealso>
    let ``I.3.6.0`` = Prefixed_Name(acm, "I.3.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.6.1. Ergonomics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.1</seealso>
    let ``I.3.6.1`` = Prefixed_Name(acm, "I.3.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.6.2. Graphics data structures and data types</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.2</seealso>
    let ``I.3.6.2`` = Prefixed_Name(acm, "I.3.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.6.5. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.5</seealso>
    let ``I.3.6.5`` = Prefixed_Name(acm, "I.3.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7. Three-Dimensional Graphics and Realism</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.7</seealso>
    let ``I.3.7`` = Prefixed_Name(acm, "I.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.0. Animation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.0</seealso>
    let ``I.3.7.0`` = Prefixed_Name(acm, "I.3.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.1. Color, shading, shadowing, and texture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.1</seealso>
    let ``I.3.7.1`` = Prefixed_Name(acm, "I.3.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.5. Raytracing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.5</seealso>
    let ``I.3.7.5`` = Prefixed_Name(acm, "I.3.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.6. Virtual reality</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.6</seealso>
    let ``I.3.7.6`` = Prefixed_Name(acm, "I.3.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.7. Visible line/surface algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.7</seealso>
    let ``I.3.7.7`` = Prefixed_Name(acm, "I.3.7.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.8. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.8">http://acm.rkbexplorer.com/ontologies/acm#I.3.8</seealso>
    let ``I.3.8`` = Prefixed_Name(acm, "I.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.1.1, #C.1.2.</para>
    /// labels<para>B.2.1. Design Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.1</seealso>
    let ``B.2.1`` = Prefixed_Name(acm, "B.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.1.2. Pipeline</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.1.2</seealso>
    let ``B.2.1.2`` = Prefixed_Name(acm, "B.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2.1. Associative processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.1</seealso>
    let ``C.1.2.1`` = Prefixed_Name(acm, "C.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2.2. Connection machines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.2</seealso>
    let ``C.1.2.2`` = Prefixed_Name(acm, "C.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.0. Abstract data types</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.0</seealso>
    let ``D.3.3.0`` = Prefixed_Name(acm, "D.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.1. Classes and objects</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.1</seealso>
    let ``D.3.3.1`` = Prefixed_Name(acm, "D.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.1.4.2. Equal interval integration</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.2</seealso>
    let ``G.1.4.2`` = Prefixed_Name(acm, "G.1.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.4.5. Gaussian quadrature</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.5</seealso>
    let ``G.1.4.5`` = Prefixed_Name(acm, "G.1.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.3.2. Electronic mail</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.2</seealso>
    let ``H.4.3.2`` = Prefixed_Name(acm, "H.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.5. Modeling packages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.5</seealso>
    let ``I.3.5.5`` = Prefixed_Name(acm, "I.3.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.8. Splines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.8">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.8</seealso>
    let ``I.3.5.8`` = Prefixed_Name(acm, "I.3.5.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1.2. Freeware/shareware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.2</seealso>
    let ``K.8.1.2`` = Prefixed_Name(acm, "K.8.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1.3. Graphics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.3</seealso>
    let ``K.8.1.3`` = Prefixed_Name(acm, "K.8.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.2. Hardware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.2">http://acm.rkbexplorer.com/ontologies/acm#K.8.2</seealso>
    let ``K.8.2`` = Prefixed_Name(acm, "K.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.3. Management/Maintenance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.3">http://acm.rkbexplorer.com/ontologies/acm#K.8.3</seealso>
    let ``K.8.3`` = Prefixed_Name(acm, "K.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.0.3. System architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.3">http://acm.rkbexplorer.com/ontologies/acm#C.0.3</seealso>
    let ``C.0.3`` = Prefixed_Name(acm, "C.0.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.0.4. Systems specification methodology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.4">http://acm.rkbexplorer.com/ontologies/acm#C.0.4</seealso>
    let ``C.0.4`` = Prefixed_Name(acm, "C.0.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.1.1. Extrapolation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.1</seealso>
    let ``G.1.1.1`` = Prefixed_Name(acm, "G.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.1.3. Smoothing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.3</seealso>
    let ``G.1.1.3`` = Prefixed_Name(acm, "G.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2. Approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.2</seealso>
    let ``G.1.2`` = Prefixed_Name(acm, "G.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.2.2. Elementary function approximation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.2</seealso>
    let ``G.1.2.2`` = Prefixed_Name(acm, "G.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.7.3. Systems issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.3</seealso>
    let ``H.3.7.3`` = Prefixed_Name(acm, "H.3.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.4.4. Meta files</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.4</seealso>
    let ``I.3.4.4`` = Prefixed_Name(acm, "I.3.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1991.</para>
    /// labels<para>K.6.5.1. Insurance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.1</seealso>
    let ``K.6.5.1`` = Prefixed_Name(acm, "K.6.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.5.2. Invasive software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.2</seealso>
    let ``K.6.5.2`` = Prefixed_Name(acm, "K.6.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.1.1. Parallel</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.1.1</seealso>
    let ``B.2.1.1`` = Prefixed_Name(acm, "B.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.2.2. Performance Analysis and Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.2</seealso>
    let ``B.2.2`` = Prefixed_Name(acm, "B.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2.0. Array and vector processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.0</seealso>
    let ``C.1.2.0`` = Prefixed_Name(acm, "C.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2.3. Interconnection architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.3</seealso>
    let ``C.1.2.3`` = Prefixed_Name(acm, "C.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.2.5. Parallel processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.5">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.5</seealso>
    let ``C.1.2.5`` = Prefixed_Name(acm, "C.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2.7. Single-instruction-stream, multiple-data-stream processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.7">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.7</seealso>
    let ``C.1.2.7`` = Prefixed_Name(acm, "C.1.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.3.2. Capability architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.2</seealso>
    let ``C.1.3.2`` = Prefixed_Name(acm, "C.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.5. Heterogeneous systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.5">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.5</seealso>
    let ``C.1.3.5`` = Prefixed_Name(acm, "C.1.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.3.9. Stack-oriented processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.9">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.9</seealso>
    let ``C.1.3.9`` = Prefixed_Name(acm, "C.1.3.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.4.0. Distributed architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.4.0</seealso>
    let ``C.1.4.0`` = Prefixed_Name(acm, "C.1.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.10. Input/output</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.10">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.10</seealso>
    let ``D.3.3.10`` = Prefixed_Name(acm, "D.3.3.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5.1. Convergence</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.1</seealso>
    let ``G.1.5.1`` = Prefixed_Name(acm, "G.1.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.5.2. Error analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.2</seealso>
    let ``G.1.5.2`` = Prefixed_Name(acm, "G.1.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6. Optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.6</seealso>
    let ``G.1.6`` = Prefixed_Name(acm, "G.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.0. Constrained optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.0</seealso>
    let ``G.1.6.0`` = Prefixed_Name(acm, "G.1.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.3. Gradient methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.3</seealso>
    let ``G.1.6.3`` = Prefixed_Name(acm, "G.1.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.4. Integer programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.4</seealso>
    let ``G.1.6.4`` = Prefixed_Name(acm, "G.1.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.6.9. Simulated annealing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.9</seealso>
    let ``G.1.6.9`` = Prefixed_Name(acm, "G.1.6.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7. Ordinary Differential Equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.7</seealso>
    let ``G.1.7`` = Prefixed_Name(acm, "G.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.4. Error analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.4</seealso>
    let ``G.1.7.4`` = Prefixed_Name(acm, "G.1.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.7.5. Finite difference methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.5</seealso>
    let ``G.1.7.5`` = Prefixed_Name(acm, "G.1.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.1. Elliptic equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.1</seealso>
    let ``G.1.8.1`` = Prefixed_Name(acm, "G.1.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.10. Parabolic equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.10</seealso>
    let ``G.1.8.10`` = Prefixed_Name(acm, "G.1.8.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.7. Iterative solution techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.7</seealso>
    let ``G.1.8.7`` = Prefixed_Name(acm, "G.1.8.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.8.8. Method of lines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.8</seealso>
    let ``G.1.8.8`` = Prefixed_Name(acm, "G.1.8.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.m">http://acm.rkbexplorer.com/ontologies/acm#G.1.m</seealso>
    let ``G.1.m`` = Prefixed_Name(acm, "G.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2. DISCRETE MATHEMATICS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2">http://acm.rkbexplorer.com/ontologies/acm#G.2</seealso>
    let ``G.2`` = Prefixed_Name(acm, "G.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.1.0. Combinatorial algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.0</seealso>
    let ``G.2.1.0`` = Prefixed_Name(acm, "G.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.1.1. Counting problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.1</seealso>
    let ``G.2.1.1`` = Prefixed_Name(acm, "G.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.1.2. Generating functions</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.2</seealso>
    let ``G.2.1.2`` = Prefixed_Name(acm, "G.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.1.3. Permutations and combinations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.3</seealso>
    let ``G.2.1.3`` = Prefixed_Name(acm, "G.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.2.2. Hypergraphs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.2</seealso>
    let ``G.2.2.2`` = Prefixed_Name(acm, "G.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.2.3. Network problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.3</seealso>
    let ``G.2.2.3`` = Prefixed_Name(acm, "G.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.2.4. Path and circuit problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.4</seealso>
    let ``G.2.2.4`` = Prefixed_Name(acm, "G.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.2.5. Trees</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.5">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.5</seealso>
    let ``G.2.2.5`` = Prefixed_Name(acm, "G.2.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.2. Computer-supported cooperative work</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.2</seealso>
    let ``H.5.3.2`` = Prefixed_Name(acm, "H.5.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.3. Evaluation/methodology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.3</seealso>
    let ``H.5.3.3`` = Prefixed_Name(acm, "H.5.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.4. Organizational design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.4</seealso>
    let ``H.5.3.4`` = Prefixed_Name(acm, "H.5.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.5. Synchronous interaction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.5</seealso>
    let ``H.5.3.5`` = Prefixed_Name(acm, "H.5.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.4.1. Navigation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.1</seealso>
    let ``H.5.4.1`` = Prefixed_Name(acm, "H.5.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.4.2. Theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.2</seealso>
    let ``H.5.4.2`` = Prefixed_Name(acm, "H.5.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.4.3. User issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.3</seealso>
    let ``H.5.4.3`` = Prefixed_Name(acm, "H.5.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #J.5.</para>
    /// labels<para>H.5.5. Sound and Music Computing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.5</seealso>
    let ``H.5.5`` = Prefixed_Name(acm, "H.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.12. Tracking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.12">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.12</seealso>
    let ``I.4.8.12`` = Prefixed_Name(acm, "I.4.8.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.2. Motion</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.2</seealso>
    let ``I.4.8.2`` = Prefixed_Name(acm, "I.4.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.3. Object recognition</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.3</seealso>
    let ``I.4.8.3`` = Prefixed_Name(acm, "I.4.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.4. Photometry</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.4</seealso>
    let ``I.4.8.4`` = Prefixed_Name(acm, "I.4.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.2.0. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.2.0</seealso>
    let ``B.2.2.0`` = Prefixed_Name(acm, "B.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.2.2. Worst-case analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.2.2</seealso>
    let ``B.2.2.2`` = Prefixed_Name(acm, "B.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.2.3. Reliability, Testing, and Fault-Tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.2.3</seealso>
    let ``B.2.3`` = Prefixed_Name(acm, "B.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.3.2. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.2</seealso>
    let ``B.2.3.2`` = Prefixed_Name(acm, "B.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.4.0. Algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.4.0</seealso>
    let ``B.2.4.0`` = Prefixed_Name(acm, "B.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.0.2. Security and protection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.0.2</seealso>
    let ``C.2.0.2`` = Prefixed_Name(acm, "C.2.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.2. Circuit-switching networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.2</seealso>
    let ``C.2.1.2`` = Prefixed_Name(acm, "C.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.7. Network topology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.7">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.7</seealso>
    let ``C.2.1.7`` = Prefixed_Name(acm, "C.2.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.9. Store and forward networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.9">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.9</seealso>
    let ``C.2.1.9`` = Prefixed_Name(acm, "C.2.1.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.2.1. Protocol architecture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.1</seealso>
    let ``C.2.2.1`` = Prefixed_Name(acm, "C.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.3. Network Operations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.3</seealso>
    let ``C.2.3`` = Prefixed_Name(acm, "C.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.4. Distributed Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4">http://acm.rkbexplorer.com/ontologies/acm#C.2.4</seealso>
    let ``C.2.4`` = Prefixed_Name(acm, "C.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.4.1. Distributed applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.1</seealso>
    let ``C.2.4.1`` = Prefixed_Name(acm, "C.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.4.2. Distributed databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.2</seealso>
    let ``C.2.4.2`` = Prefixed_Name(acm, "C.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5.3. High-speed</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.3</seealso>
    let ``C.2.5.3`` = Prefixed_Name(acm, "C.2.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5.4. Internet</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.4">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.4</seealso>
    let ``C.2.5.4`` = Prefixed_Name(acm, "C.2.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.6.0. Routers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.6.0</seealso>
    let ``C.2.6.0`` = Prefixed_Name(acm, "C.2.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #J.7.</para>
    /// labels<para>C.3. SPECIAL-PURPOSE AND APPLICATION-BASED SYSTEMS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3">http://acm.rkbexplorer.com/ontologies/acm#C.3</seealso>
    let ``C.3`` = Prefixed_Name(acm, "C.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.3.0. Microprocessor/microcomputer applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.3.0</seealso>
    let ``C.3.0`` = Prefixed_Name(acm, "C.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.3.4. Smartcards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.4">http://acm.rkbexplorer.com/ontologies/acm#C.3.4</seealso>
    let ``C.3.4`` = Prefixed_Name(acm, "C.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4. PERFORMANCE OF SYSTEMS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4">http://acm.rkbexplorer.com/ontologies/acm#C.4</seealso>
    let ``C.4`` = Prefixed_Name(acm, "C.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4.3. Modeling techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.3">http://acm.rkbexplorer.com/ontologies/acm#C.4.3</seealso>
    let ``C.4.3`` = Prefixed_Name(acm, "C.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4.4. Performance attributes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.4">http://acm.rkbexplorer.com/ontologies/acm#C.4.4</seealso>
    let ``C.4.4`` = Prefixed_Name(acm, "C.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.1.0. Super computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.5.1.0</seealso>
    let ``C.5.1.0`` = Prefixed_Name(acm, "C.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.5.2. Minicomputers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.2">http://acm.rkbexplorer.com/ontologies/acm#C.5.2</seealso>
    let ``C.5.2`` = Prefixed_Name(acm, "C.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.3.0. Microprocessors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.0</seealso>
    let ``C.5.3.0`` = Prefixed_Name(acm, "C.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.3.1. Personal computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.1</seealso>
    let ``C.5.3.1`` = Prefixed_Name(acm, "C.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.5. Servers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.5">http://acm.rkbexplorer.com/ontologies/acm#C.5.5</seealso>
    let ``C.5.5`` = Prefixed_Name(acm, "C.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.m">http://acm.rkbexplorer.com/ontologies/acm#C.5.m</seealso>
    let ``C.5.m`` = Prefixed_Name(acm, "C.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.m">http://acm.rkbexplorer.com/ontologies/acm#C.m</seealso>
    let ``C.m`` = Prefixed_Name(acm, "C.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D. Software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D">http://acm.rkbexplorer.com/ontologies/acm#D</seealso>
    let D = Prefixed_Name(acm, "D") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.1. Applicative Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.1.1</seealso>
    let ``D.1.1`` = Prefixed_Name(acm, "D.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #I.2.2.</para>
    /// labels<para>D.1.2. Automatic Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2">http://acm.rkbexplorer.com/ontologies/acm#D.1.2</seealso>
    let ``D.1.2`` = Prefixed_Name(acm, "D.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.2.0. Distributed programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.1.2.0</seealso>
    let ``D.1.2.0`` = Prefixed_Name(acm, "D.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.6. Logic Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.6">http://acm.rkbexplorer.com/ontologies/acm#D.1.6</seealso>
    let ``D.1.6`` = Prefixed_Name(acm, "D.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.7. Visual Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.7">http://acm.rkbexplorer.com/ontologies/acm#D.1.7</seealso>
    let ``D.1.7`` = Prefixed_Name(acm, "D.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.m">http://acm.rkbexplorer.com/ontologies/acm#D.1.m</seealso>
    let ``D.1.m`` = Prefixed_Name(acm, "D.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #K.6.3.</para>
    /// labels<para>D.2. SOFTWARE ENGINEERING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2">http://acm.rkbexplorer.com/ontologies/acm#D.2</seealso>
    let ``D.2`` = Prefixed_Name(acm, "D.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.1.</para>
    /// labels<para>D.2.1. Requirements/Specifications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.1</seealso>
    let ``D.2.1`` = Prefixed_Name(acm, "D.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.1.0. Elicitation methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.0</seealso>
    let ``D.2.1.0`` = Prefixed_Name(acm, "D.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.1.1. Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.1</seealso>
    let ``D.2.1.1`` = Prefixed_Name(acm, "D.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #D.2.2.</para>
    /// labels<para>D.2.10. Design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10">http://acm.rkbexplorer.com/ontologies/acm#D.2.10</seealso>
    let ``D.2.10`` = Prefixed_Name(acm, "D.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.10.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.10.0. Methodologies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.10.0</seealso>
    let ``D.2.10.0`` = Prefixed_Name(acm, "D.2.10.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.10.1. Representation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.10.1</seealso>
    let ``D.2.10.1`` = Prefixed_Name(acm, "D.2.10.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.11. Software Architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11">http://acm.rkbexplorer.com/ontologies/acm#D.2.11</seealso>
    let ``D.2.11`` = Prefixed_Name(acm, "D.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.11.2. Information hiding</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.2</seealso>
    let ``D.2.11.2`` = Prefixed_Name(acm, "D.2.11.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.11.3. Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.3</seealso>
    let ``D.2.11.3`` = Prefixed_Name(acm, "D.2.11.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.11.4. Patterns</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.4</seealso>
    let ``D.2.11.4`` = Prefixed_Name(acm, "D.2.11.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.12. Interoperability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12">http://acm.rkbexplorer.com/ontologies/acm#D.2.12</seealso>
    let ``D.2.12`` = Prefixed_Name(acm, "D.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.12.2. Interface definition languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.12.2</seealso>
    let ``D.2.12.2`` = Prefixed_Name(acm, "D.2.12.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.13. Reusable Software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13">http://acm.rkbexplorer.com/ontologies/acm#D.2.13</seealso>
    let ``D.2.13`` = Prefixed_Name(acm, "D.2.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.13.0. Domain engineering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.13.0</seealso>
    let ``D.2.13.0`` = Prefixed_Name(acm, "D.2.13.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.13.1. Reusable libraries</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.13.1</seealso>
    let ``D.2.13.1`` = Prefixed_Name(acm, "D.2.13.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.2.10. Structured programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.10">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.10</seealso>
    let ``D.2.2.10`` = Prefixed_Name(acm, "D.2.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.2.11. Top-down programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.11">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.11</seealso>
    let ``D.2.2.11`` = Prefixed_Name(acm, "D.2.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.12. User interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.12">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.12</seealso>
    let ``D.2.2.12`` = Prefixed_Name(acm, "D.2.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.2. Evolutionary prototyping</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.2</seealso>
    let ``D.2.2.2`` = Prefixed_Name(acm, "D.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.2.7. Programmer workbench</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.7</seealso>
    let ``D.2.2.7`` = Prefixed_Name(acm, "D.2.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.8. Software libraries</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.8</seealso>
    let ``D.2.2.8`` = Prefixed_Name(acm, "D.2.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.9. State diagrams</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.9">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.9</seealso>
    let ``D.2.2.9`` = Prefixed_Name(acm, "D.2.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3. Coding Tools and Techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.3</seealso>
    let ``D.2.3`` = Prefixed_Name(acm, "D.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3.0. Object-oriented programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.0</seealso>
    let ``D.2.3.0`` = Prefixed_Name(acm, "D.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3.1. Pretty printers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.1</seealso>
    let ``D.2.3.1`` = Prefixed_Name(acm, "D.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3.2. Program editors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.2</seealso>
    let ``D.2.3.2`` = Prefixed_Name(acm, "D.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.3.3. Reentrant code</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.3</seealso>
    let ``D.2.3.3`` = Prefixed_Name(acm, "D.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.5. Programming by contract</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.5</seealso>
    let ``D.2.4.5`` = Prefixed_Name(acm, "D.2.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.6. Reliability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.6</seealso>
    let ``D.2.4.6`` = Prefixed_Name(acm, "D.2.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.7. Statistical methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.7</seealso>
    let ``D.2.4.7`` = Prefixed_Name(acm, "D.2.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.8. Validation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.8</seealso>
    let ``D.2.4.8`` = Prefixed_Name(acm, "D.2.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5. Testing and Debugging</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.5</seealso>
    let ``D.2.5`` = Prefixed_Name(acm, "D.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.0. Code inspections and walk-throughs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.0</seealso>
    let ``D.2.5.0`` = Prefixed_Name(acm, "D.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.1. Debugging aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.1</seealso>
    let ``D.2.5.1`` = Prefixed_Name(acm, "D.2.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.2. Diagnostics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.2</seealso>
    let ``D.2.5.2`` = Prefixed_Name(acm, "D.2.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.8. Testing tools</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.8</seealso>
    let ``D.2.5.8`` = Prefixed_Name(acm, "D.2.5.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.9. Tracing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.9">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.9</seealso>
    let ``D.2.5.9`` = Prefixed_Name(acm, "D.2.5.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.6. Programming Environments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.6</seealso>
    let ``D.2.6`` = Prefixed_Name(acm, "D.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.6.0. Graphical environments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.0</seealso>
    let ``D.2.6.0`` = Prefixed_Name(acm, "D.2.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.6.1. Integrated environments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.1</seealso>
    let ``D.2.6.1`` = Prefixed_Name(acm, "D.2.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.6.2. Interactive environments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.2</seealso>
    let ``D.2.6.2`` = Prefixed_Name(acm, "D.2.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.6.3. Programmer workbench</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.3</seealso>
    let ``D.2.6.3`` = Prefixed_Name(acm, "D.2.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.7. Distribution, Maintenance, and Enhancement</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.7</seealso>
    let ``D.2.7`` = Prefixed_Name(acm, "D.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.7.3. Extensibility</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.3</seealso>
    let ``D.2.7.3`` = Prefixed_Name(acm, "D.2.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.7.4. Portability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.4</seealso>
    let ``D.2.7.4`` = Prefixed_Name(acm, "D.2.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.7.5. Restructuring, reverse engineering, and reengineering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.5</seealso>
    let ``D.2.7.5`` = Prefixed_Name(acm, "D.2.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.7.6. Version control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.6</seealso>
    let ``D.2.7.6`` = Prefixed_Name(acm, "D.2.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.4.8.</para>
    /// labels<para>D.2.8. Metrics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.8</seealso>
    let ``D.2.8`` = Prefixed_Name(acm, "D.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.8.0. Complexity measures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.0</seealso>
    let ``D.2.8.0`` = Prefixed_Name(acm, "D.2.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.8.1. Performance measures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.1</seealso>
    let ``D.2.8.1`` = Prefixed_Name(acm, "D.2.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #K.6.3, #K.6.4.</para>
    /// labels<para>D.2.9. Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9">http://acm.rkbexplorer.com/ontologies/acm#D.2.9</seealso>
    let ``D.2.9`` = Prefixed_Name(acm, "D.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.9.0. Copyrights</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.0</seealso>
    let ``D.2.9.0`` = Prefixed_Name(acm, "D.2.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.1. Cost estimation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.1</seealso>
    let ``D.2.9.1`` = Prefixed_Name(acm, "D.2.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.2. Life cycle</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.2</seealso>
    let ``D.2.9.2`` = Prefixed_Name(acm, "D.2.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.3. Productivity</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.3</seealso>
    let ``D.2.9.3`` = Prefixed_Name(acm, "D.2.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.4. Programming teams</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.4</seealso>
    let ``D.2.9.4`` = Prefixed_Name(acm, "D.2.9.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.5. Software configuration management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.5</seealso>
    let ``D.2.9.5`` = Prefixed_Name(acm, "D.2.9.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.9.8. Time estimation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.8</seealso>
    let ``D.2.9.8`` = Prefixed_Name(acm, "D.2.9.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m">http://acm.rkbexplorer.com/ontologies/acm#D.2.m</seealso>
    let ``D.2.m`` = Prefixed_Name(acm, "D.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.m.0. Rapid prototyping</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.m.0</seealso>
    let ``D.2.m.0`` = Prefixed_Name(acm, "D.2.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.m.1. Reusable software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.m.1</seealso>
    let ``D.2.m.1`` = Prefixed_Name(acm, "D.2.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3. PROGRAMMING LANGUAGES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3">http://acm.rkbexplorer.com/ontologies/acm#D.3</seealso>
    let ``D.3`` = Prefixed_Name(acm, "D.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.0</seealso>
    let ``D.3.0`` = Prefixed_Name(acm, "D.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.0.0. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.0.0</seealso>
    let ``D.3.0.0`` = Prefixed_Name(acm, "D.3.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.2.1, #F.3.1, #F.3.2, #F.4.2, #F.4.3.</para>
    /// labels<para>D.3.1. Formal Definitions and Theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.1</seealso>
    let ``D.3.1`` = Prefixed_Name(acm, "D.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2. Language Classifications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.2</seealso>
    let ``D.3.2`` = Prefixed_Name(acm, "D.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.0. Applicative languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.0</seealso>
    let ``D.3.2.0`` = Prefixed_Name(acm, "D.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.1. Concurrent, distributed, and parallel languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.1</seealso>
    let ``D.3.2.1`` = Prefixed_Name(acm, "D.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.3.2.10. Nonprocedural languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.10">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.10</seealso>
    let ``D.3.2.10`` = Prefixed_Name(acm, "D.3.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.11. Object-oriented languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.11">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.11</seealso>
    let ``D.3.2.11`` = Prefixed_Name(acm, "D.3.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.12. Specialized application languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.12">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.12</seealso>
    let ``D.3.2.12`` = Prefixed_Name(acm, "D.3.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.13. Very high-level languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.13">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.13</seealso>
    let ``D.3.2.13`` = Prefixed_Name(acm, "D.3.2.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.2. Constraint and logic languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.2</seealso>
    let ``D.3.2.2`` = Prefixed_Name(acm, "D.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.6.5.3. Physical security</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.3</seealso>
    let ``K.6.5.3`` = Prefixed_Name(acm, "K.6.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.5.4. Unauthorized access</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.4</seealso>
    let ``K.6.5.4`` = Prefixed_Name(acm, "K.6.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m">http://acm.rkbexplorer.com/ontologies/acm#K.6.m</seealso>
    let ``K.6.m`` = Prefixed_Name(acm, "K.6.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1991.</para>
    /// labels<para>K.6.m.0. Insurance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.m.0</seealso>
    let ``K.6.m.0`` = Prefixed_Name(acm, "K.6.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1991.</para>
    /// labels<para>K.6.m.1. Security</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.m.1</seealso>
    let ``K.6.m.1`` = Prefixed_Name(acm, "K.6.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7. THE COMPUTING PROFESSION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7">http://acm.rkbexplorer.com/ontologies/acm#K.7</seealso>
    let ``K.7`` = Prefixed_Name(acm, "K.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.0">http://acm.rkbexplorer.com/ontologies/acm#K.7.0</seealso>
    let ``K.7.0`` = Prefixed_Name(acm, "K.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.1. Occupations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.1">http://acm.rkbexplorer.com/ontologies/acm#K.7.1</seealso>
    let ``K.7.1`` = Prefixed_Name(acm, "K.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.2.1. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.2.1</seealso>
    let ``B.2.2.1`` = Prefixed_Name(acm, "B.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.3.1. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.1</seealso>
    let ``B.2.3.1`` = Prefixed_Name(acm, "B.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.3.3. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.3</seealso>
    let ``B.2.3.3`` = Prefixed_Name(acm, "B.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.4.1. Cost/performance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.4.1</seealso>
    let ``B.2.4.1`` = Prefixed_Name(acm, "B.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.3.0. Network management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.3.0</seealso>
    let ``C.2.3.0`` = Prefixed_Name(acm, "C.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.4.0. Client/server</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.0</seealso>
    let ``C.2.4.0`` = Prefixed_Name(acm, "C.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5.0. Access schemes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.0</seealso>
    let ``C.2.5.0`` = Prefixed_Name(acm, "C.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5.2. Ethernet</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.2</seealso>
    let ``C.2.5.2`` = Prefixed_Name(acm, "C.2.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.2.2.</para>
    /// labels<para>C.2.6. Internetworking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6">http://acm.rkbexplorer.com/ontologies/acm#C.2.6</seealso>
    let ``C.2.6`` = Prefixed_Name(acm, "C.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.m">http://acm.rkbexplorer.com/ontologies/acm#C.2.m</seealso>
    let ``C.2.m`` = Prefixed_Name(acm, "C.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.3.2. Real-time and embedded systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.3.2</seealso>
    let ``C.3.2`` = Prefixed_Name(acm, "C.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4.0. Design studies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.0">http://acm.rkbexplorer.com/ontologies/acm#C.4.0</seealso>
    let ``C.4.0`` = Prefixed_Name(acm, "C.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.6. Optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.6">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.6</seealso>
    let ``D.3.4.6`` = Prefixed_Name(acm, "D.3.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.7. Parsing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.7">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.7</seealso>
    let ``D.3.4.7`` = Prefixed_Name(acm, "D.3.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.5.1.4. Hypertext navigation and maps</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.4</seealso>
    let ``H.5.1.4`` = Prefixed_Name(acm, "H.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.1.5. Video</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.5</seealso>
    let ``H.5.1.5`` = Prefixed_Name(acm, "H.5.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1.4. Spreadsheets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.4</seealso>
    let ``K.8.1.4`` = Prefixed_Name(acm, "K.8.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1.5. Word processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.5">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.5</seealso>
    let ``K.8.1.5`` = Prefixed_Name(acm, "K.8.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.m">http://acm.rkbexplorer.com/ontologies/acm#K.8.m</seealso>
    let ``K.8.m`` = Prefixed_Name(acm, "K.8.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.m">http://acm.rkbexplorer.com/ontologies/acm#K.m</seealso>
    let ``K.m`` = Prefixed_Name(acm, "K.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.2.3.0. Diagnostics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.0</seealso>
    let ``B.2.3.0`` = Prefixed_Name(acm, "B.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.4. High-Speed Arithmetic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.2.4</seealso>
    let ``B.2.4`` = Prefixed_Name(acm, "B.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.2.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.m">http://acm.rkbexplorer.com/ontologies/acm#B.2.m</seealso>
    let ``B.2.m`` = Prefixed_Name(acm, "B.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #B.7.1.</para>
    /// labels<para>B.3.1. Semiconductor Memories</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.1</seealso>
    let ``B.3.1`` = Prefixed_Name(acm, "B.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.1.2. Static memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.1.2</seealso>
    let ``B.3.1.2`` = Prefixed_Name(acm, "B.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.2.1. Cache memories</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.1</seealso>
    let ``B.3.2.1`` = Prefixed_Name(acm, "B.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.2.6. Shared memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.6">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.6</seealso>
    let ``B.3.2.6`` = Prefixed_Name(acm, "B.3.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8, #C.4.</para>
    /// labels<para>B.3.3. Performance Analysis and Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.3.3</seealso>
    let ``B.3.3`` = Prefixed_Name(acm, "B.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.3.2. Worst-case analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.3.2</seealso>
    let ``B.3.3.2`` = Prefixed_Name(acm, "B.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.4.0. Diagnostics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.0</seealso>
    let ``B.3.4.0`` = Prefixed_Name(acm, "B.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.4.2. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.2</seealso>
    let ``B.3.4.2`` = Prefixed_Name(acm, "B.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.m">http://acm.rkbexplorer.com/ontologies/acm#B.3.m</seealso>
    let ``B.3.m`` = Prefixed_Name(acm, "B.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.1. Data Communications Devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.1</seealso>
    let ``B.4.1`` = Prefixed_Name(acm, "B.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.1.0. Processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.1.0</seealso>
    let ``B.4.1.0`` = Prefixed_Name(acm, "B.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.2. Input/Output Devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.2</seealso>
    let ``B.4.2`` = Prefixed_Name(acm, "B.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.2.0. Channels and controllers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.0</seealso>
    let ``B.4.2.0`` = Prefixed_Name(acm, "B.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.3. Interconnections</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.3</seealso>
    let ``B.4.3`` = Prefixed_Name(acm, "B.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.3.0. Asynchronous/synchronous operation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.0</seealso>
    let ``B.4.3.0`` = Prefixed_Name(acm, "B.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.3.3. Parallel I/O</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.3</seealso>
    let ``B.4.3.3`` = Prefixed_Name(acm, "B.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.3.4. Physical structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.4</seealso>
    let ``B.4.3.4`` = Prefixed_Name(acm, "B.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.4.1. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.1</seealso>
    let ``B.4.4.1`` = Prefixed_Name(acm, "B.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.4.2. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.2</seealso>
    let ``B.4.4.2`` = Prefixed_Name(acm, "B.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.5.1. Diagnostics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.1</seealso>
    let ``B.4.5.1`` = Prefixed_Name(acm, "B.4.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.5.2. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.2</seealso>
    let ``B.4.5.2`` = Prefixed_Name(acm, "B.4.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.m">http://acm.rkbexplorer.com/ontologies/acm#B.4.m</seealso>
    let ``B.4.m`` = Prefixed_Name(acm, "B.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5. REGISTER-TRANSFER-LEVEL IMPLEMENTATION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5">http://acm.rkbexplorer.com/ontologies/acm#B.5</seealso>
    let ``B.5`` = Prefixed_Name(acm, "B.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.1.0. Arithmetic and logic units</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.0</seealso>
    let ``B.5.1.0`` = Prefixed_Name(acm, "B.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.1.1. Control design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.1</seealso>
    let ``B.5.1.1`` = Prefixed_Name(acm, "B.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.1.2. Data-path design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.2</seealso>
    let ``B.5.1.2`` = Prefixed_Name(acm, "B.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.1.3. Memory design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.3</seealso>
    let ``B.5.1.3`` = Prefixed_Name(acm, "B.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.1.4. Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.4</seealso>
    let ``B.5.1.4`` = Prefixed_Name(acm, "B.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.2. Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.2</seealso>
    let ``B.5.2`` = Prefixed_Name(acm, "B.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.2.3. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.3</seealso>
    let ``B.5.2.3`` = Prefixed_Name(acm, "B.5.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.2.4. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.4</seealso>
    let ``B.5.2.4`` = Prefixed_Name(acm, "B.5.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.5.3. Reliability and Testing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.3</seealso>
    let ``B.5.3`` = Prefixed_Name(acm, "B.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.5.3.0. Built-in tests</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.0</seealso>
    let ``B.5.3.0`` = Prefixed_Name(acm, "B.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.5.3.3. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.3</seealso>
    let ``B.5.3.3`` = Prefixed_Name(acm, "B.5.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.5.3.4. Testability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.4</seealso>
    let ``B.5.3.4`` = Prefixed_Name(acm, "B.5.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.m">http://acm.rkbexplorer.com/ontologies/acm#B.5.m</seealso>
    let ``B.5.m`` = Prefixed_Name(acm, "B.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6. LOGIC DESIGN</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6">http://acm.rkbexplorer.com/ontologies/acm#B.6</seealso>
    let ``B.6`` = Prefixed_Name(acm, "B.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.1. Design Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.1</seealso>
    let ``B.6.1`` = Prefixed_Name(acm, "B.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.1.0. Cellular arrays and automata</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.0</seealso>
    let ``B.6.1.0`` = Prefixed_Name(acm, "B.6.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.1.1. Combinational logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.1</seealso>
    let ``B.6.1.1`` = Prefixed_Name(acm, "B.6.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.1.2. Logic arrays</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.2</seealso>
    let ``B.6.1.2`` = Prefixed_Name(acm, "B.6.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.1.4. Memory used as logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.4</seealso>
    let ``B.6.1.4`` = Prefixed_Name(acm, "B.6.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.1.5. Parallel circuits</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.5">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.5</seealso>
    let ``B.6.1.5`` = Prefixed_Name(acm, "B.6.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.1.6. Sequential circuits</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.6">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.6</seealso>
    let ``B.6.1.6`` = Prefixed_Name(acm, "B.6.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.6.2. Reliability and Testing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.2</seealso>
    let ``B.6.2`` = Prefixed_Name(acm, "B.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.2.1. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.1</seealso>
    let ``B.6.2.1`` = Prefixed_Name(acm, "B.6.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.2.2. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.2</seealso>
    let ``B.6.2.2`` = Prefixed_Name(acm, "B.6.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.2.3. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.3</seealso>
    let ``B.6.2.3`` = Prefixed_Name(acm, "B.6.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.6.2.4. Testability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.4</seealso>
    let ``B.6.2.4`` = Prefixed_Name(acm, "B.6.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3.0. Automatic synthesis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.0</seealso>
    let ``B.6.3.0`` = Prefixed_Name(acm, "B.6.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3.1. Hardware description languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.1</seealso>
    let ``B.6.3.1`` = Prefixed_Name(acm, "B.6.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3.2. Optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.2</seealso>
    let ``B.6.3.2`` = Prefixed_Name(acm, "B.6.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.6.3.3. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.3</seealso>
    let ``B.6.3.3`` = Prefixed_Name(acm, "B.6.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.0</seealso>
    let ``B.7.0`` = Prefixed_Name(acm, "B.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1. Types and Design Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.1</seealso>
    let ``B.7.1`` = Prefixed_Name(acm, "B.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.0. Advanced technologies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.0</seealso>
    let ``B.7.1.0`` = Prefixed_Name(acm, "B.7.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.1. Algorithms implemented in hardware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.1</seealso>
    let ``B.7.1.1`` = Prefixed_Name(acm, "B.7.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.4. Memory technologies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.4</seealso>
    let ``B.7.1.4`` = Prefixed_Name(acm, "B.7.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.5. Microprocessors and microcomputers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.5">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.5</seealso>
    let ``B.7.1.5`` = Prefixed_Name(acm, "B.7.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.7.1.6. Standard cells</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.6">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.6</seealso>
    let ``B.7.1.6`` = Prefixed_Name(acm, "B.7.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.1.7. VLSI</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.7">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.7</seealso>
    let ``B.7.1.7`` = Prefixed_Name(acm, "B.7.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.2. Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.2</seealso>
    let ``B.7.2`` = Prefixed_Name(acm, "B.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.2.0. Graphics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.0</seealso>
    let ``B.7.2.0`` = Prefixed_Name(acm, "B.7.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.2.1. Layout</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.1</seealso>
    let ``B.7.2.1`` = Prefixed_Name(acm, "B.7.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.2.2. Placement and routing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.2</seealso>
    let ``B.7.2.2`` = Prefixed_Name(acm, "B.7.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.7.3. Reliability and Testing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.3</seealso>
    let ``B.7.3`` = Prefixed_Name(acm, "B.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.7.3.0. Built-in tests</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.0</seealso>
    let ``B.7.3.0`` = Prefixed_Name(acm, "B.7.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.7.3.1. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.1</seealso>
    let ``B.7.3.1`` = Prefixed_Name(acm, "B.7.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.7.3.2. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.2</seealso>
    let ``B.7.3.2`` = Prefixed_Name(acm, "B.7.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.7.3.3. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.3</seealso>
    let ``B.7.3.3`` = Prefixed_Name(acm, "B.7.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.7.3.4. Testability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.4</seealso>
    let ``B.7.3.4`` = Prefixed_Name(acm, "B.7.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.m">http://acm.rkbexplorer.com/ontologies/acm#B.7.m</seealso>
    let ``B.7.m`` = Prefixed_Name(acm, "B.7.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.4.</para>
    /// labels<para>B.8. PERFORMANCE AND RELIABILITY</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8">http://acm.rkbexplorer.com/ontologies/acm#B.8</seealso>
    let ``B.8`` = Prefixed_Name(acm, "B.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.8.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.m">http://acm.rkbexplorer.com/ontologies/acm#B.8.m</seealso>
    let ``B.8.m`` = Prefixed_Name(acm, "B.8.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.m">http://acm.rkbexplorer.com/ontologies/acm#B.m</seealso>
    let ``B.m`` = Prefixed_Name(acm, "B.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.m.0. Design management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.m.0">http://acm.rkbexplorer.com/ontologies/acm#B.m.0</seealso>
    let ``B.m.0`` = Prefixed_Name(acm, "B.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C. Computer Systems Organization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C">http://acm.rkbexplorer.com/ontologies/acm#C</seealso>
    let C = Prefixed_Name(acm, "C") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0">http://acm.rkbexplorer.com/ontologies/acm#C.0</seealso>
    let ``C.0`` = Prefixed_Name(acm, "C.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.0.0. Hardware/software interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.0">http://acm.rkbexplorer.com/ontologies/acm#C.0.0</seealso>
    let ``C.0.0`` = Prefixed_Name(acm, "C.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.0.1. Instruction set design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.1">http://acm.rkbexplorer.com/ontologies/acm#C.0.1</seealso>
    let ``C.0.1`` = Prefixed_Name(acm, "C.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.0.2. Modeling of computer architecture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.2">http://acm.rkbexplorer.com/ontologies/acm#C.0.2</seealso>
    let ``C.0.2`` = Prefixed_Name(acm, "C.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.0</seealso>
    let ``C.1.0`` = Prefixed_Name(acm, "C.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.1. Single Data Stream Architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.1</seealso>
    let ``C.1.1`` = Prefixed_Name(acm, "C.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.1.0. Multiple-instruction-stream, single-data-stream processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.0</seealso>
    let ``C.1.1.0`` = Prefixed_Name(acm, "C.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.1.1. Pipeline processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.1</seealso>
    let ``C.1.1.1`` = Prefixed_Name(acm, "C.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.1.2. RISC/CISC, VLIW architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.2</seealso>
    let ``C.1.1.2`` = Prefixed_Name(acm, "C.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.1.3. Single-instruction-stream, single-data-stream processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.3</seealso>
    let ``C.1.1.3`` = Prefixed_Name(acm, "C.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.1.4. Von Neumann architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.4</seealso>
    let ``C.1.1.4`` = Prefixed_Name(acm, "C.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.2. Multiple Data Stream Architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.2</seealso>
    let ``C.1.2`` = Prefixed_Name(acm, "C.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.4. Design languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.4</seealso>
    let ``D.3.2.4`` = Prefixed_Name(acm, "D.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.5. Extensible languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.5</seealso>
    let ``D.3.2.5`` = Prefixed_Name(acm, "D.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.6. Macro and assembly languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.6</seealso>
    let ``D.3.2.6`` = Prefixed_Name(acm, "D.3.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.3.2.7. Microprogramming languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.7</seealso>
    let ``D.3.2.7`` = Prefixed_Name(acm, "D.3.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.2.8. Multiparadigm languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.8</seealso>
    let ``D.3.2.8`` = Prefixed_Name(acm, "D.3.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.3.2.9. Nondeterministic languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.9">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.9</seealso>
    let ``D.3.2.9`` = Prefixed_Name(acm, "D.3.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.2.</para>
    /// labels<para>D.3.3. Language Constructs and Features</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.3</seealso>
    let ``D.3.3`` = Prefixed_Name(acm, "D.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.11. Modules, packages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.11">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.11</seealso>
    let ``D.3.3.11`` = Prefixed_Name(acm, "D.3.3.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.12. Patterns</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.12">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.12</seealso>
    let ``D.3.3.12`` = Prefixed_Name(acm, "D.3.3.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.13. Polymorphism</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.13">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.13</seealso>
    let ``D.3.3.13`` = Prefixed_Name(acm, "D.3.3.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.14. Procedures, functions, and subroutines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.14">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.14</seealso>
    let ``D.3.3.14`` = Prefixed_Name(acm, "D.3.3.14") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.15. Recursion</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.15">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.15</seealso>
    let ``D.3.3.15`` = Prefixed_Name(acm, "D.3.3.15") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.2. Concurrent programming structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.2</seealso>
    let ``D.3.3.2`` = Prefixed_Name(acm, "D.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.3. Constraints</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.3</seealso>
    let ``D.3.3.3`` = Prefixed_Name(acm, "D.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.4. Control structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.4</seealso>
    let ``D.3.3.4`` = Prefixed_Name(acm, "D.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.9. Inheritance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.9">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.9</seealso>
    let ``D.3.3.9`` = Prefixed_Name(acm, "D.3.3.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4. Processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.4</seealso>
    let ``D.3.4`` = Prefixed_Name(acm, "D.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.0. Code generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.0</seealso>
    let ``D.3.4.0`` = Prefixed_Name(acm, "D.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.1. Compilers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.1</seealso>
    let ``D.3.4.1`` = Prefixed_Name(acm, "D.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.10. Run-time environments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.10">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.10</seealso>
    let ``D.3.4.10`` = Prefixed_Name(acm, "D.3.4.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.11. Translator writing systems and compiler generators</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.11">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.11</seealso>
    let ``D.3.4.11`` = Prefixed_Name(acm, "D.3.4.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.2. Debuggers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.2</seealso>
    let ``D.3.4.2`` = Prefixed_Name(acm, "D.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.3. Incremental compilers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.3</seealso>
    let ``D.3.4.3`` = Prefixed_Name(acm, "D.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.m">http://acm.rkbexplorer.com/ontologies/acm#D.3.m</seealso>
    let ``D.3.m`` = Prefixed_Name(acm, "D.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.</para>
    /// labels<para>D.4. OPERATING SYSTEMS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4">http://acm.rkbexplorer.com/ontologies/acm#D.4</seealso>
    let ``D.4`` = Prefixed_Name(acm, "D.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.0</seealso>
    let ``D.4.0`` = Prefixed_Name(acm, "D.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1. Process Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.1</seealso>
    let ``D.4.1`` = Prefixed_Name(acm, "D.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.0. Concurrency</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.0</seealso>
    let ``D.4.1.0`` = Prefixed_Name(acm, "D.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.1. Deadlocks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.1</seealso>
    let ``D.4.1.1`` = Prefixed_Name(acm, "D.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.2. Multiprocessing/multiprogramming/multitasking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.2</seealso>
    let ``D.4.1.2`` = Prefixed_Name(acm, "D.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.3. Mutual exclusion</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.3</seealso>
    let ``D.4.1.3`` = Prefixed_Name(acm, "D.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.3. Main memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.3</seealso>
    let ``D.4.2.3`` = Prefixed_Name(acm, "D.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.4. Secondary storage</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.4</seealso>
    let ``D.4.2.4`` = Prefixed_Name(acm, "D.4.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.2.5. Segmentation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.5</seealso>
    let ``D.4.2.5`` = Prefixed_Name(acm, "D.4.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.6. Storage hierarchies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.6</seealso>
    let ``D.4.2.6`` = Prefixed_Name(acm, "D.4.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.2.7. Swapping</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.7</seealso>
    let ``D.4.2.7`` = Prefixed_Name(acm, "D.4.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.8. Virtual memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.8</seealso>
    let ``D.4.2.8`` = Prefixed_Name(acm, "D.4.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.5.</para>
    /// labels<para>D.4.3. File Systems Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.3</seealso>
    let ``D.4.3`` = Prefixed_Name(acm, "D.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.3.0. Access methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.0</seealso>
    let ``D.4.3.0`` = Prefixed_Name(acm, "D.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.3.1. Directory structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.1</seealso>
    let ``D.4.3.1`` = Prefixed_Name(acm, "D.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.3.2. Distributed file systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.2</seealso>
    let ``D.4.3.2`` = Prefixed_Name(acm, "D.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.3.3. File organization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.3</seealso>
    let ``D.4.3.3`` = Prefixed_Name(acm, "D.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.3.4. Maintenance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.4</seealso>
    let ``D.4.3.4`` = Prefixed_Name(acm, "D.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.2.</para>
    /// labels<para>D.4.4. Communications Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.4</seealso>
    let ``D.4.4`` = Prefixed_Name(acm, "D.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.4.0. Buffering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.0</seealso>
    let ``D.4.4.0`` = Prefixed_Name(acm, "D.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.4.1. Input/output</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.1</seealso>
    let ``D.4.4.1`` = Prefixed_Name(acm, "D.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.3. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.3">http://acm.rkbexplorer.com/ontologies/acm#G.2.3</seealso>
    let ``G.2.3`` = Prefixed_Name(acm, "G.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.m">http://acm.rkbexplorer.com/ontologies/acm#G.2.m</seealso>
    let ``G.2.m`` = Prefixed_Name(acm, "G.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3. PROBABILITY AND STATISTICS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3">http://acm.rkbexplorer.com/ontologies/acm#G.3</seealso>
    let ``G.3`` = Prefixed_Name(acm, "G.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.0. Contingency table analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.0">http://acm.rkbexplorer.com/ontologies/acm#G.3.0</seealso>
    let ``G.3.0`` = Prefixed_Name(acm, "G.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.1. Correlation and regression analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.1">http://acm.rkbexplorer.com/ontologies/acm#G.3.1</seealso>
    let ``G.3.1`` = Prefixed_Name(acm, "G.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.10. Reliability and life testing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.10">http://acm.rkbexplorer.com/ontologies/acm#G.3.10</seealso>
    let ``G.3.10`` = Prefixed_Name(acm, "G.3.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.11. Renewal theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.11">http://acm.rkbexplorer.com/ontologies/acm#G.3.11</seealso>
    let ``G.3.11`` = Prefixed_Name(acm, "G.3.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.12. Robust regression</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.12">http://acm.rkbexplorer.com/ontologies/acm#G.3.12</seealso>
    let ``G.3.12`` = Prefixed_Name(acm, "G.3.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.13. Statistical computing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.13">http://acm.rkbexplorer.com/ontologies/acm#G.3.13</seealso>
    let ``G.3.13`` = Prefixed_Name(acm, "G.3.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.14. Statistical software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.14">http://acm.rkbexplorer.com/ontologies/acm#G.3.14</seealso>
    let ``G.3.14`` = Prefixed_Name(acm, "G.3.14") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.15. Stochastic processes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.15">http://acm.rkbexplorer.com/ontologies/acm#G.3.15</seealso>
    let ``G.3.15`` = Prefixed_Name(acm, "G.3.15") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.16</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.16. Survival analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.16">http://acm.rkbexplorer.com/ontologies/acm#G.3.16</seealso>
    let ``G.3.16`` = Prefixed_Name(acm, "G.3.16") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.17</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.17. Time series analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.17">http://acm.rkbexplorer.com/ontologies/acm#G.3.17</seealso>
    let ``G.3.17`` = Prefixed_Name(acm, "G.3.17") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.2. Distribution functions</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.2">http://acm.rkbexplorer.com/ontologies/acm#G.3.2</seealso>
    let ``G.3.2`` = Prefixed_Name(acm, "G.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.3. Experimental design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.3">http://acm.rkbexplorer.com/ontologies/acm#G.3.3</seealso>
    let ``G.3.3`` = Prefixed_Name(acm, "G.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.4. Markov processes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.4">http://acm.rkbexplorer.com/ontologies/acm#G.3.4</seealso>
    let ``G.3.4`` = Prefixed_Name(acm, "G.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.5.0. Methodologies and techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.0</seealso>
    let ``H.5.5.0`` = Prefixed_Name(acm, "H.5.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.5.1. Modeling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.1</seealso>
    let ``H.5.5.1`` = Prefixed_Name(acm, "H.5.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.5.2. Signal analysis, synthesis, and processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.2</seealso>
    let ``H.5.5.2`` = Prefixed_Name(acm, "H.5.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.5.3. Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.3</seealso>
    let ``H.5.5.3`` = Prefixed_Name(acm, "H.5.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.m">http://acm.rkbexplorer.com/ontologies/acm#H.5.m</seealso>
    let ``H.5.m`` = Prefixed_Name(acm, "H.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.m">http://acm.rkbexplorer.com/ontologies/acm#H.m</seealso>
    let ``H.m`` = Prefixed_Name(acm, "H.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I. Computing Methodologies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I">http://acm.rkbexplorer.com/ontologies/acm#I</seealso>
    let I = Prefixed_Name(acm, "I") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.0">http://acm.rkbexplorer.com/ontologies/acm#I.0</seealso>
    let ``I.0`` = Prefixed_Name(acm, "I.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1. SYMBOLIC AND ALGEBRAIC MANIPULATION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1">http://acm.rkbexplorer.com/ontologies/acm#I.1</seealso>
    let ``I.1`` = Prefixed_Name(acm, "I.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.0</seealso>
    let ``I.1.0`` = Prefixed_Name(acm, "I.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.1, #E.2.</para>
    /// labels<para>I.1.1. Expressions and Their Representation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.1</seealso>
    let ``I.1.1`` = Prefixed_Name(acm, "I.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.1.0. Representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.1.0</seealso>
    let ``I.1.1.0`` = Prefixed_Name(acm, "I.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.1.1. Simplification of expressions</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.1.1</seealso>
    let ``I.1.1.1`` = Prefixed_Name(acm, "I.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.2.1, #F.2.2.</para>
    /// labels<para>I.1.2. Algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.1.2</seealso>
    let ``I.1.2`` = Prefixed_Name(acm, "I.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.1.3.4. Substitution mechanisms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.4</seealso>
    let ``I.1.3.4`` = Prefixed_Name(acm, "I.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.4. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.1.4</seealso>
    let ``I.1.4`` = Prefixed_Name(acm, "I.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.m">http://acm.rkbexplorer.com/ontologies/acm#I.1.m</seealso>
    let ``I.1.m`` = Prefixed_Name(acm, "I.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2. ARTIFICIAL INTELLIGENCE</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2">http://acm.rkbexplorer.com/ontologies/acm#I.2</seealso>
    let ``I.2`` = Prefixed_Name(acm, "I.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.0</seealso>
    let ``I.2.0`` = Prefixed_Name(acm, "I.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.0.0. Cognitive simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.0.0</seealso>
    let ``I.2.0.0`` = Prefixed_Name(acm, "I.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.0.1. Philosophical foundations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.0.1</seealso>
    let ``I.2.0.1`` = Prefixed_Name(acm, "I.2.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #H.4, #J.</para>
    /// labels<para>I.2.1. Applications and Expert Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.1</seealso>
    let ``I.2.1`` = Prefixed_Name(acm, "I.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.0. Cartography</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.0</seealso>
    let ``I.2.1.0`` = Prefixed_Name(acm, "I.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.1. Games</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.1</seealso>
    let ``I.2.1.1`` = Prefixed_Name(acm, "I.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.2. Industrial automation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.2</seealso>
    let ``I.2.1.2`` = Prefixed_Name(acm, "I.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.3. Law</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.3</seealso>
    let ``I.2.1.3`` = Prefixed_Name(acm, "I.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.4. Medicine and science</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.4</seealso>
    let ``I.2.1.4`` = Prefixed_Name(acm, "I.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.5. Natural language interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.5</seealso>
    let ``I.2.1.5`` = Prefixed_Name(acm, "I.2.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.1.6. Office automation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.6</seealso>
    let ``I.2.1.6`` = Prefixed_Name(acm, "I.2.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.11. Distributed Artificial Intelligence</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11">http://acm.rkbexplorer.com/ontologies/acm#I.2.11</seealso>
    let ``I.2.11`` = Prefixed_Name(acm, "I.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.11.0. Coherence and coordination</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.0</seealso>
    let ``I.2.11.0`` = Prefixed_Name(acm, "I.2.11.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.11.1. Intelligent agents</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.1</seealso>
    let ``I.2.11.1`` = Prefixed_Name(acm, "I.2.11.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.11.2. Languages and structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.2</seealso>
    let ``I.2.11.2`` = Prefixed_Name(acm, "I.2.11.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.11.3. Multiagent systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.3</seealso>
    let ``I.2.11.3`` = Prefixed_Name(acm, "I.2.11.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.1.2, #F.3.1, #F.4.1.</para>
    /// labels<para>I.2.2. Automatic Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.2</seealso>
    let ``I.2.2`` = Prefixed_Name(acm, "I.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.2.0. Automatic analysis of algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.0</seealso>
    let ``I.2.2.0`` = Prefixed_Name(acm, "I.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.2.1. Program modification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.1</seealso>
    let ``I.2.2.1`` = Prefixed_Name(acm, "I.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.2.2. Program synthesis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.2</seealso>
    let ``I.2.2.2`` = Prefixed_Name(acm, "I.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.2.3. Program transformation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.3</seealso>
    let ``I.2.2.3`` = Prefixed_Name(acm, "I.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.2.4. Program verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.4</seealso>
    let ``I.2.2.4`` = Prefixed_Name(acm, "I.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.4.1.</para>
    /// labels<para>I.2.3. Deduction and Theorem Proving</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.3</seealso>
    let ``I.2.3`` = Prefixed_Name(acm, "I.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.0. Answer/reason extraction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.0</seealso>
    let ``I.2.3.0`` = Prefixed_Name(acm, "I.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.1. Deduction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.1</seealso>
    let ``I.2.3.1`` = Prefixed_Name(acm, "I.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.3.2. Inference engines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.2</seealso>
    let ``I.2.3.2`` = Prefixed_Name(acm, "I.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.1. Modal logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.1</seealso>
    let ``I.2.4.1`` = Prefixed_Name(acm, "I.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.2. Predicate logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.2</seealso>
    let ``I.2.4.2`` = Prefixed_Name(acm, "I.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.3. Relation systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.3</seealso>
    let ``I.2.4.3`` = Prefixed_Name(acm, "I.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.4. Representation languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.4</seealso>
    let ``I.2.4.4`` = Prefixed_Name(acm, "I.2.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.5. Representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.5</seealso>
    let ``I.2.4.5`` = Prefixed_Name(acm, "I.2.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.6. Semantic networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.6</seealso>
    let ``I.2.4.6`` = Prefixed_Name(acm, "I.2.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.4.7. Temporal logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.7</seealso>
    let ``I.2.4.7`` = Prefixed_Name(acm, "I.2.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.2.</para>
    /// labels<para>I.2.5. Programming Languages and Software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.5</seealso>
    let ``I.2.5`` = Prefixed_Name(acm, "I.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.5.0. Expert system tools and techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.5.0</seealso>
    let ``I.2.5.0`` = Prefixed_Name(acm, "I.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #K.3.2.</para>
    /// labels<para>I.2.6. Learning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.6</seealso>
    let ``I.2.6`` = Prefixed_Name(acm, "I.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.0. Analogies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.0</seealso>
    let ``I.2.6.0`` = Prefixed_Name(acm, "I.2.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.1. Concept learning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.1</seealso>
    let ``I.2.6.1`` = Prefixed_Name(acm, "I.2.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.2. Connectionism and neural nets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.2</seealso>
    let ``I.2.6.2`` = Prefixed_Name(acm, "I.2.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.3. Induction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.3</seealso>
    let ``I.2.6.3`` = Prefixed_Name(acm, "I.2.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.4. Knowledge acquisition</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.4</seealso>
    let ``I.2.6.4`` = Prefixed_Name(acm, "I.2.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.6.5. Language acquisition</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.5</seealso>
    let ``I.2.6.5`` = Prefixed_Name(acm, "I.2.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.1. THE COMPUTER INDUSTRY</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1">http://acm.rkbexplorer.com/ontologies/acm#K.1</seealso>
    let ``K.1`` = Prefixed_Name(acm, "K.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.1.0. Markets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.1.0</seealso>
    let ``K.1.0`` = Prefixed_Name(acm, "K.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.1.1. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.1.1</seealso>
    let ``K.1.1`` = Prefixed_Name(acm, "K.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.1.2. Statistics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.1.2</seealso>
    let ``K.1.2`` = Prefixed_Name(acm, "K.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.1.3. Suppliers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.1.3</seealso>
    let ``K.1.3`` = Prefixed_Name(acm, "K.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.2. HISTORY OF COMPUTING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2">http://acm.rkbexplorer.com/ontologies/acm#K.2</seealso>
    let ``K.2`` = Prefixed_Name(acm, "K.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.2.0. Hardware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.2.0</seealso>
    let ``K.2.0`` = Prefixed_Name(acm, "K.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.2.1. People</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.2.1</seealso>
    let ``K.2.1`` = Prefixed_Name(acm, "K.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.2.2. Software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.2.2</seealso>
    let ``K.2.2`` = Prefixed_Name(acm, "K.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.2.3. Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.2.3</seealso>
    let ``K.2.3`` = Prefixed_Name(acm, "K.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.2.4. Theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.4">http://acm.rkbexplorer.com/ontologies/acm#K.2.4</seealso>
    let ``K.2.4`` = Prefixed_Name(acm, "K.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3. COMPUTERS AND EDUCATION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3">http://acm.rkbexplorer.com/ontologies/acm#K.3</seealso>
    let ``K.3`` = Prefixed_Name(acm, "K.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.0</seealso>
    let ``K.3.0`` = Prefixed_Name(acm, "K.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.1. Computer Uses in Education</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.1</seealso>
    let ``K.3.1`` = Prefixed_Name(acm, "K.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.1.0. Collaborative learning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.0</seealso>
    let ``K.3.1.0`` = Prefixed_Name(acm, "K.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.3.1.1. Computer-assisted instruction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.1</seealso>
    let ``K.3.1.1`` = Prefixed_Name(acm, "K.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4. COMPUTERS AND SOCIETY</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4">http://acm.rkbexplorer.com/ontologies/acm#K.4</seealso>
    let ``K.4`` = Prefixed_Name(acm, "K.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.0</seealso>
    let ``K.4.0`` = Prefixed_Name(acm, "K.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1. Public Policy Issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.1</seealso>
    let ``K.4.1`` = Prefixed_Name(acm, "K.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.0. Abuse and crime involving computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.0</seealso>
    let ``K.4.1.0`` = Prefixed_Name(acm, "K.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.1. Computer-related health issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.1</seealso>
    let ``K.4.1.1`` = Prefixed_Name(acm, "K.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.2. Ethics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.2</seealso>
    let ``K.4.1.2`` = Prefixed_Name(acm, "K.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.3. Human safety</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.3</seealso>
    let ``K.4.1.3`` = Prefixed_Name(acm, "K.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.4. Intellectual property rights</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.4</seealso>
    let ``K.4.1.4`` = Prefixed_Name(acm, "K.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.5. Privacy</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.5</seealso>
    let ``K.4.1.5`` = Prefixed_Name(acm, "K.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.6. Regulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.6</seealso>
    let ``K.4.1.6`` = Prefixed_Name(acm, "K.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.7. Transborder data flow</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.7">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.7</seealso>
    let ``K.4.1.7`` = Prefixed_Name(acm, "K.4.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.1.8. Use/abuse of power</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.8">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.8</seealso>
    let ``K.4.1.8`` = Prefixed_Name(acm, "K.4.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.2. Social Issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.2</seealso>
    let ``K.4.2`` = Prefixed_Name(acm, "K.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.4.2.0. Abuse and crime involving computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.0</seealso>
    let ``K.4.2.0`` = Prefixed_Name(acm, "K.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.2.1. Assistive technologies for persons with disabilities</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.1</seealso>
    let ``K.4.2.1`` = Prefixed_Name(acm, "K.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.2.2. Employment</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.2</seealso>
    let ``K.4.2.2`` = Prefixed_Name(acm, "K.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.4.4. Payment schemes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.4">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.4</seealso>
    let ``K.4.4.4`` = Prefixed_Name(acm, "K.4.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.4.5. Security</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.5">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.5</seealso>
    let ``K.4.4.5`` = Prefixed_Name(acm, "K.4.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.4.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.m">http://acm.rkbexplorer.com/ontologies/acm#K.4.m</seealso>
    let ``K.4.m`` = Prefixed_Name(acm, "K.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5. LEGAL ASPECTS OF COMPUTING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5">http://acm.rkbexplorer.com/ontologies/acm#K.5</seealso>
    let ``K.5`` = Prefixed_Name(acm, "K.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.0</seealso>
    let ``K.5.0`` = Prefixed_Name(acm, "K.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.1. Hardware/Software Protection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.1</seealso>
    let ``K.5.1`` = Prefixed_Name(acm, "K.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.1.0. Copyrights</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.0</seealso>
    let ``K.5.1.0`` = Prefixed_Name(acm, "K.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.1.1. Licensing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.1</seealso>
    let ``K.5.1.1`` = Prefixed_Name(acm, "K.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.1.2. Patents</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.2</seealso>
    let ``K.5.1.2`` = Prefixed_Name(acm, "K.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.1.3. Proprietary rights</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.3</seealso>
    let ``K.5.1.3`` = Prefixed_Name(acm, "K.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.5.1.4. Trade secrets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.4</seealso>
    let ``K.5.1.4`` = Prefixed_Name(acm, "K.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.2. Governmental Issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2">http://acm.rkbexplorer.com/ontologies/acm#K.5.2</seealso>
    let ``K.5.2`` = Prefixed_Name(acm, "K.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.2.0. Censorship</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.2.0</seealso>
    let ``K.5.2.0`` = Prefixed_Name(acm, "K.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.2.1. Regulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.2.1</seealso>
    let ``K.5.2.1`` = Prefixed_Name(acm, "K.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.2.2. Taxation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.5.2.2</seealso>
    let ``K.5.2.2`` = Prefixed_Name(acm, "K.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.5.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m">http://acm.rkbexplorer.com/ontologies/acm#K.5.m</seealso>
    let ``K.5.m`` = Prefixed_Name(acm, "K.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.5.m.0. Contracts</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.m.0</seealso>
    let ``K.5.m.0`` = Prefixed_Name(acm, "K.5.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.5.m.1. Hardware patents</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.m.1</seealso>
    let ``K.5.m.1`` = Prefixed_Name(acm, "K.5.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6. MANAGEMENT OF COMPUTING AND INFORMATION SYSTEMS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6">http://acm.rkbexplorer.com/ontologies/acm#K.6</seealso>
    let ``K.6`` = Prefixed_Name(acm, "K.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.0</seealso>
    let ``K.6.0`` = Prefixed_Name(acm, "K.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.0.0. Economics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.0.0</seealso>
    let ``K.6.0.0`` = Prefixed_Name(acm, "K.6.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1. Project and People Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.1</seealso>
    let ``K.6.1`` = Prefixed_Name(acm, "K.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.0. Life cycle</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.0</seealso>
    let ``K.6.1.0`` = Prefixed_Name(acm, "K.6.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.1. Management techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.1</seealso>
    let ``K.6.1.1`` = Prefixed_Name(acm, "K.6.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.2. Staffing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.2</seealso>
    let ``K.6.1.2`` = Prefixed_Name(acm, "K.6.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.3. Strategic information systems planning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.3</seealso>
    let ``K.6.1.3`` = Prefixed_Name(acm, "K.6.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.4. Systems analysis and design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.4</seealso>
    let ``K.6.1.4`` = Prefixed_Name(acm, "K.6.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.5. Systems development</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.5">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.5</seealso>
    let ``K.6.1.5`` = Prefixed_Name(acm, "K.6.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.1.6. Training</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.6">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.6</seealso>
    let ``K.6.1.6`` = Prefixed_Name(acm, "K.6.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.2. Installation Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.2</seealso>
    let ``K.6.2`` = Prefixed_Name(acm, "K.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.2.0. Benchmarks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.0</seealso>
    let ``K.6.2.0`` = Prefixed_Name(acm, "K.6.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.2.1. Computer selection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.1</seealso>
    let ``K.6.2.1`` = Prefixed_Name(acm, "K.6.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.0. Adaptable architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.0</seealso>
    let ``C.1.3.0`` = Prefixed_Name(acm, "C.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.3. Cellular architecture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.3</seealso>
    let ``C.1.3.3`` = Prefixed_Name(acm, "C.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>C.1.3.6. High-level language architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.6">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.6</seealso>
    let ``C.1.3.6`` = Prefixed_Name(acm, "C.1.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.3.8. Pipeline processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.8">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.8</seealso>
    let ``C.1.3.8`` = Prefixed_Name(acm, "C.1.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m">http://acm.rkbexplorer.com/ontologies/acm#C.1.m</seealso>
    let ``C.1.m`` = Prefixed_Name(acm, "C.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2. COMPUTER-COMMUNICATION NETWORKS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2">http://acm.rkbexplorer.com/ontologies/acm#C.2</seealso>
    let ``C.2`` = Prefixed_Name(acm, "C.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.0.1. Open Systems Interconnection reference model</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.0.1</seealso>
    let ``C.2.0.1`` = Prefixed_Name(acm, "C.2.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1. Network Architecture and Design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.1</seealso>
    let ``C.2.1`` = Prefixed_Name(acm, "C.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.10. Wireless communication</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.10">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.10</seealso>
    let ``C.2.1.10`` = Prefixed_Name(acm, "C.2.1.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.3. Distributed networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.3</seealso>
    let ``C.2.1.3`` = Prefixed_Name(acm, "C.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.6. Network communications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.6">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.6</seealso>
    let ``C.2.1.6`` = Prefixed_Name(acm, "C.2.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.1.8. Packet-switching networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.8">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.8</seealso>
    let ``C.2.1.8`` = Prefixed_Name(acm, "C.2.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.2. Network Protocols</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.2</seealso>
    let ``C.2.2`` = Prefixed_Name(acm, "C.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.2.0. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.0</seealso>
    let ``C.2.2.0`` = Prefixed_Name(acm, "C.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.2.2. Protocol verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.2</seealso>
    let ``C.2.2.2`` = Prefixed_Name(acm, "C.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.2.3. Routing protocols</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.3</seealso>
    let ``C.2.2.3`` = Prefixed_Name(acm, "C.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.3.1. Network monitoring</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.3.1</seealso>
    let ``C.2.3.1`` = Prefixed_Name(acm, "C.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.3.2. Public networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.3.2</seealso>
    let ``C.2.3.2`` = Prefixed_Name(acm, "C.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.4.3. Network operating systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.3</seealso>
    let ``C.2.4.3`` = Prefixed_Name(acm, "C.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5. Local and Wide-Area Networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5">http://acm.rkbexplorer.com/ontologies/acm#C.2.5</seealso>
    let ``C.2.5`` = Prefixed_Name(acm, "C.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.7. Dynamic storage management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.7">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.7</seealso>
    let ``D.3.3.7`` = Prefixed_Name(acm, "D.3.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.3.8. Frameworks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.8">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.8</seealso>
    let ``D.3.3.8`` = Prefixed_Name(acm, "D.3.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.4. Interpreters</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.4</seealso>
    let ``D.3.4.4`` = Prefixed_Name(acm, "D.3.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.5. Memory management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.5">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.5</seealso>
    let ``D.3.4.5`` = Prefixed_Name(acm, "D.3.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.8. Preprocessors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.8">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.8</seealso>
    let ``D.3.4.8`` = Prefixed_Name(acm, "D.3.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.3.4.9. Retargetable compilers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.9">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.9</seealso>
    let ``D.3.4.9`` = Prefixed_Name(acm, "D.3.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.4. Scheduling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.4</seealso>
    let ``D.4.1.4`` = Prefixed_Name(acm, "D.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.5. Synchronization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.5</seealso>
    let ``D.4.1.5`` = Prefixed_Name(acm, "D.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2. Storage Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.2</seealso>
    let ``D.4.2`` = Prefixed_Name(acm, "D.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.0. Allocation/deallocation strategies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.0</seealso>
    let ``D.4.2.0`` = Prefixed_Name(acm, "D.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.1. Distributed memories</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.1</seealso>
    let ``D.4.2.1`` = Prefixed_Name(acm, "D.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.2.2. Garbage collection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.2</seealso>
    let ``D.4.2.2`` = Prefixed_Name(acm, "D.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.1.4. Recurrences and difference equations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.4</seealso>
    let ``G.2.1.4`` = Prefixed_Name(acm, "G.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.2.2.</para>
    /// labels<para>G.2.2. Graph Theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2">http://acm.rkbexplorer.com/ontologies/acm#G.2.2</seealso>
    let ``G.2.2`` = Prefixed_Name(acm, "G.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.2.0. Graph algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.0</seealso>
    let ``G.2.2.0`` = Prefixed_Name(acm, "G.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.2.2.1. Graph labeling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.1</seealso>
    let ``G.2.2.1`` = Prefixed_Name(acm, "G.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.5. Haptic I/O</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.5</seealso>
    let ``H.5.2.5`` = Prefixed_Name(acm, "H.5.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.6. Input devices and strategies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.6">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.6</seealso>
    let ``H.5.2.6`` = Prefixed_Name(acm, "H.5.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.7. Interaction styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.7">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.7</seealso>
    let ``H.5.2.7`` = Prefixed_Name(acm, "H.5.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.8. Natural language</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.8">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.8</seealso>
    let ``H.5.2.8`` = Prefixed_Name(acm, "H.5.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.6. Theory and models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.6">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.6</seealso>
    let ``H.5.3.6`` = Prefixed_Name(acm, "H.5.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.3.7. Web-based interaction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.7">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.7</seealso>
    let ``H.5.3.7`` = Prefixed_Name(acm, "H.5.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #I.7, #J.7.</para>
    /// labels<para>H.5.4. Hypertext/Hypermedia</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.4</seealso>
    let ``H.5.4`` = Prefixed_Name(acm, "H.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.4.0. Architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.0</seealso>
    let ``H.5.4.0`` = Prefixed_Name(acm, "H.5.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.0. Color</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.0</seealso>
    let ``I.4.8.0`` = Prefixed_Name(acm, "I.4.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.1. Depth cues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.1</seealso>
    let ``I.4.8.1`` = Prefixed_Name(acm, "I.4.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.10. Surface fitting</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.10">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.10</seealso>
    let ``I.4.8.10`` = Prefixed_Name(acm, "I.4.8.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.11. Time-varying imagery</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.11">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.11</seealso>
    let ``I.4.8.11`` = Prefixed_Name(acm, "I.4.8.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.5. Range data</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.5</seealso>
    let ``I.4.8.5`` = Prefixed_Name(acm, "I.4.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.6. Sensor fusion</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.6">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.6</seealso>
    let ``I.4.8.6`` = Prefixed_Name(acm, "I.4.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.7. Shading</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.7">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.7</seealso>
    let ``I.4.8.7`` = Prefixed_Name(acm, "I.4.8.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.8. Shape</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.8">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.8</seealso>
    let ``I.4.8.8`` = Prefixed_Name(acm, "I.4.8.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3. MEMORY STRUCTURES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3">http://acm.rkbexplorer.com/ontologies/acm#B.3</seealso>
    let ``B.3`` = Prefixed_Name(acm, "B.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.1.0. Dynamic memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.1.0</seealso>
    let ``B.3.1.0`` = Prefixed_Name(acm, "B.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.2.0. Associative memories</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.0</seealso>
    let ``B.3.2.0`` = Prefixed_Name(acm, "B.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.2.3. Mass storage</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.3</seealso>
    let ``B.3.2.3`` = Prefixed_Name(acm, "B.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.2.5. Sequential-access memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.5</seealso>
    let ``B.3.2.5`` = Prefixed_Name(acm, "B.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.2.7. Virtual memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.7">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.7</seealso>
    let ``B.3.2.7`` = Prefixed_Name(acm, "B.3.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.</para>
    /// labels<para>D.1. PROGRAMMING TECHNIQUES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1">http://acm.rkbexplorer.com/ontologies/acm#D.1</seealso>
    let ``D.1`` = Prefixed_Name(acm, "D.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.5. Reliability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.5</seealso>
    let ``D.4.5`` = Prefixed_Name(acm, "D.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.5.2. Fault-tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.2</seealso>
    let ``D.4.5.2`` = Prefixed_Name(acm, "D.4.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.6.0. Access controls</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.0</seealso>
    let ``D.4.6.0`` = Prefixed_Name(acm, "D.4.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.6.1. Authentication</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.1</seealso>
    let ``D.4.6.1`` = Prefixed_Name(acm, "D.4.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.6.4. Invasive software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.4</seealso>
    let ``D.4.6.4`` = Prefixed_Name(acm, "D.4.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.6.5. Security kernels</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.5</seealso>
    let ``D.4.6.5`` = Prefixed_Name(acm, "D.4.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.7.1. Distributed systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.1</seealso>
    let ``D.4.7.1`` = Prefixed_Name(acm, "D.4.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.7.2. Hierarchical design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.2</seealso>
    let ``D.4.7.2`` = Prefixed_Name(acm, "D.4.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.0. Measurements</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.0</seealso>
    let ``D.4.8.0`` = Prefixed_Name(acm, "D.4.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.1. Modeling and prediction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.1</seealso>
    let ``D.4.8.1`` = Prefixed_Name(acm, "D.4.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.5. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.5</seealso>
    let ``D.4.8.5`` = Prefixed_Name(acm, "D.4.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.6. Stochastic analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.6</seealso>
    let ``D.4.8.6`` = Prefixed_Name(acm, "D.4.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.9.3. Window managers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.3</seealso>
    let ``D.4.9.3`` = Prefixed_Name(acm, "D.4.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.m">http://acm.rkbexplorer.com/ontologies/acm#D.4.m</seealso>
    let ``D.4.m`` = Prefixed_Name(acm, "D.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.7. Probabilistic algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.7">http://acm.rkbexplorer.com/ontologies/acm#G.3.7</seealso>
    let ``G.3.7`` = Prefixed_Name(acm, "G.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.8. Queueing theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.8">http://acm.rkbexplorer.com/ontologies/acm#G.3.8</seealso>
    let ``G.3.8`` = Prefixed_Name(acm, "G.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.0. Algorithm design and analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.0">http://acm.rkbexplorer.com/ontologies/acm#G.4.0</seealso>
    let ``G.4.0`` = Prefixed_Name(acm, "G.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.1. Certification and testing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.1">http://acm.rkbexplorer.com/ontologies/acm#G.4.1</seealso>
    let ``G.4.1`` = Prefixed_Name(acm, "G.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.3. Efficiency</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.3">http://acm.rkbexplorer.com/ontologies/acm#G.4.3</seealso>
    let ``G.4.3`` = Prefixed_Name(acm, "G.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.4. Parallel and vector implementations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.4">http://acm.rkbexplorer.com/ontologies/acm#G.4.4</seealso>
    let ``G.4.4`` = Prefixed_Name(acm, "G.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.4.5. Portability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.5">http://acm.rkbexplorer.com/ontologies/acm#G.4.5</seealso>
    let ``G.4.5`` = Prefixed_Name(acm, "G.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.6. Reliability and robustness</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.6">http://acm.rkbexplorer.com/ontologies/acm#G.4.6</seealso>
    let ``G.4.6`` = Prefixed_Name(acm, "G.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.4.8. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.8">http://acm.rkbexplorer.com/ontologies/acm#G.4.8</seealso>
    let ``G.4.8`` = Prefixed_Name(acm, "G.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.m">http://acm.rkbexplorer.com/ontologies/acm#G.m</seealso>
    let ``G.m`` = Prefixed_Name(acm, "G.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>G.m.0. Queueing theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.m.0">http://acm.rkbexplorer.com/ontologies/acm#G.m.0</seealso>
    let ``G.m.0`` = Prefixed_Name(acm, "G.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H. Information Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H">http://acm.rkbexplorer.com/ontologies/acm#H</seealso>
    let H = Prefixed_Name(acm, "H") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.1.0</seealso>
    let ``H.1.0`` = Prefixed_Name(acm, "H.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.4.</para>
    /// labels<para>H.1.1. Systems and Information Theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.1.1</seealso>
    let ``H.1.1`` = Prefixed_Name(acm, "H.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.1.0. General systems theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.1.1.0</seealso>
    let ``H.1.1.0`` = Prefixed_Name(acm, "H.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.1.1. Information theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.1.1.1</seealso>
    let ``H.1.1.1`` = Prefixed_Name(acm, "H.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.2.0. Human factors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.1.2.0</seealso>
    let ``H.1.2.0`` = Prefixed_Name(acm, "H.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.2.1. Human information processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.1.2.1</seealso>
    let ``H.1.2.1`` = Prefixed_Name(acm, "H.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.2.2. Software psychology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.1.2.2</seealso>
    let ``H.1.2.2`` = Prefixed_Name(acm, "H.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.1.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.m">http://acm.rkbexplorer.com/ontologies/acm#H.1.m</seealso>
    let ``H.1.m`` = Prefixed_Name(acm, "H.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.2.10.1. Architecture and control structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.1</seealso>
    let ``I.2.10.1`` = Prefixed_Name(acm, "I.2.10.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.2. Intensity, color, photometry, and thresholding</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.2</seealso>
    let ``I.2.10.2`` = Prefixed_Name(acm, "I.2.10.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.3. Modeling and recovery of physical attributes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.3</seealso>
    let ``I.2.10.3`` = Prefixed_Name(acm, "I.2.10.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.10.4. Motion</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.4</seealso>
    let ``I.2.10.4`` = Prefixed_Name(acm, "I.2.10.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.4.2. Text processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.2</seealso>
    let ``I.5.4.2`` = Prefixed_Name(acm, "I.5.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.4.3. Waveform analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.3</seealso>
    let ``I.5.4.3`` = Prefixed_Name(acm, "I.5.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.3.</para>
    /// labels<para>I.5.5. Implementation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5">http://acm.rkbexplorer.com/ontologies/acm#I.5.5</seealso>
    let ``I.5.5`` = Prefixed_Name(acm, "I.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.0</seealso>
    let ``B.3.0`` = Prefixed_Name(acm, "B.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.1.1. Read-only memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.1.1</seealso>
    let ``B.3.1.1`` = Prefixed_Name(acm, "B.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.4.2.</para>
    /// labels<para>B.3.2. Design Styles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.2</seealso>
    let ``B.3.2`` = Prefixed_Name(acm, "B.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.2.2. Interleaved memories</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.2</seealso>
    let ``B.3.2.2`` = Prefixed_Name(acm, "B.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.3.2.4. Primary memory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.4</seealso>
    let ``B.3.2.4`` = Prefixed_Name(acm, "B.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.3.0. Formal models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.3.0</seealso>
    let ``B.3.3.0`` = Prefixed_Name(acm, "B.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.3.4. Reliability, Testing, and Fault-Tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.3.4</seealso>
    let ``B.3.4`` = Prefixed_Name(acm, "B.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.4.1. Error-checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.1</seealso>
    let ``B.3.4.1`` = Prefixed_Name(acm, "B.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.4.3. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.3</seealso>
    let ``B.3.4.3`` = Prefixed_Name(acm, "B.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4. INPUT/OUTPUT AND DATA COMMUNICATIONS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4">http://acm.rkbexplorer.com/ontologies/acm#B.4</seealso>
    let ``B.4`` = Prefixed_Name(acm, "B.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.0</seealso>
    let ``B.4.0`` = Prefixed_Name(acm, "B.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.1.2. Transmitters</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.1.2</seealso>
    let ``B.4.1.2`` = Prefixed_Name(acm, "B.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.2.2. Image display</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.2</seealso>
    let ``B.4.2.2`` = Prefixed_Name(acm, "B.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.2.3. Voice</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.3</seealso>
    let ``B.4.2.3`` = Prefixed_Name(acm, "B.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.3.1. Fiber optics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.1</seealso>
    let ``B.4.3.1`` = Prefixed_Name(acm, "B.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.4.3.2. Interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.2</seealso>
    let ``B.4.3.2`` = Prefixed_Name(acm, "B.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.4.4. Performance Analysis and Design Aids</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4">http://acm.rkbexplorer.com/ontologies/acm#B.4.4</seealso>
    let ``B.4.4`` = Prefixed_Name(acm, "B.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.4.0. Formal models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.0</seealso>
    let ``B.4.4.0`` = Prefixed_Name(acm, "B.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998. See also #B.8.</para>
    /// labels<para>B.4.5. Reliability, Testing, and Fault-Tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5">http://acm.rkbexplorer.com/ontologies/acm#B.4.5</seealso>
    let ``B.4.5`` = Prefixed_Name(acm, "B.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.5.0. Built-in tests</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.0</seealso>
    let ``B.4.5.0`` = Prefixed_Name(acm, "B.4.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.5.4. Redundant design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.4">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.4</seealso>
    let ``B.4.5.4`` = Prefixed_Name(acm, "B.4.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.4.5.5. Test generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.5">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.5</seealso>
    let ``B.4.5.5`` = Prefixed_Name(acm, "B.4.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.0</seealso>
    let ``B.5.0`` = Prefixed_Name(acm, "B.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.5.1. Design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.1</seealso>
    let ``B.5.1`` = Prefixed_Name(acm, "B.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.11.0. Data abstraction</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.0</seealso>
    let ``D.2.11.0`` = Prefixed_Name(acm, "D.2.11.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.11.1. Domain-specific architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.1</seealso>
    let ``D.2.11.1`` = Prefixed_Name(acm, "D.2.11.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.12.0. Data mapping</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.12.0</seealso>
    let ``D.2.12.0`` = Prefixed_Name(acm, "D.2.12.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.12.1. Distributed objects</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.12.1</seealso>
    let ``D.2.12.1`` = Prefixed_Name(acm, "D.2.12.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.13.2. Reuse models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.13.2</seealso>
    let ``D.2.13.2`` = Prefixed_Name(acm, "D.2.13.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2. Design Tools and Techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.2</seealso>
    let ``D.2.2`` = Prefixed_Name(acm, "D.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.0. Computer-aided software engineering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.0</seealso>
    let ``D.2.2.0`` = Prefixed_Name(acm, "D.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.1. Decision tables</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.1</seealso>
    let ``D.2.2.1`` = Prefixed_Name(acm, "D.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.3. Flow charts</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.3</seealso>
    let ``D.2.2.3`` = Prefixed_Name(acm, "D.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.4. Modules and interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.4</seealso>
    let ``D.2.2.4`` = Prefixed_Name(acm, "D.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.5. Object-oriented design methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.5</seealso>
    let ``D.2.2.5`` = Prefixed_Name(acm, "D.2.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.2.6. Petri nets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.6</seealso>
    let ``D.2.2.6`` = Prefixed_Name(acm, "D.2.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3.4. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.4</seealso>
    let ``D.2.3.4`` = Prefixed_Name(acm, "D.2.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3.5. Structured programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.5</seealso>
    let ``D.2.3.5`` = Prefixed_Name(acm, "D.2.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.3.6. Top-down programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.6</seealso>
    let ``D.2.3.6`` = Prefixed_Name(acm, "D.2.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.3.1.</para>
    /// labels<para>D.2.4. Software/Program Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.4</seealso>
    let ``D.2.4`` = Prefixed_Name(acm, "D.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.1. Class invariants</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.1</seealso>
    let ``D.2.4.1`` = Prefixed_Name(acm, "D.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.2. Correctness proofs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.2</seealso>
    let ``D.2.4.2`` = Prefixed_Name(acm, "D.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.3. Formal methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.3</seealso>
    let ``D.2.4.3`` = Prefixed_Name(acm, "D.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.4.4. Model checking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.4</seealso>
    let ``D.2.4.4`` = Prefixed_Name(acm, "D.2.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.3. Distributed debugging</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.3</seealso>
    let ``D.2.5.3`` = Prefixed_Name(acm, "D.2.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.5.4. Dumps</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.4</seealso>
    let ``D.2.5.4`` = Prefixed_Name(acm, "D.2.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.5. Error handling and recovery</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.5</seealso>
    let ``D.2.5.5`` = Prefixed_Name(acm, "D.2.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.5.6. Monitors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.6</seealso>
    let ``D.2.5.6`` = Prefixed_Name(acm, "D.2.5.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.1. Computations on discrete structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.1</seealso>
    let ``F.2.2.1`` = Prefixed_Name(acm, "F.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.2. Geometrical problems and computations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.2</seealso>
    let ``F.2.2.2`` = Prefixed_Name(acm, "F.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.3. Pattern matching</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.3</seealso>
    let ``F.2.2.3`` = Prefixed_Name(acm, "F.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.4. Routing and layout</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.4</seealso>
    let ``F.2.2.4`` = Prefixed_Name(acm, "F.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.0</seealso>
    let ``F.3.0`` = Prefixed_Name(acm, "F.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.2.1, #D.2.4, #D.3.1, #E.1.</para>
    /// labels<para>F.3.1. Specifying and Verifying and Reasoning about Programs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.1</seealso>
    let ``F.3.1`` = Prefixed_Name(acm, "F.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.1.0. Assertions</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.0</seealso>
    let ``F.3.1.0`` = Prefixed_Name(acm, "F.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.1.</para>
    /// labels<para>F.3.2. Semantics of Programming Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.2</seealso>
    let ``F.3.2`` = Prefixed_Name(acm, "F.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.2.0. Algebraic approaches to semantics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.0</seealso>
    let ``F.3.2.0`` = Prefixed_Name(acm, "F.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.2.1. Denotational semantics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.1</seealso>
    let ``F.3.2.1`` = Prefixed_Name(acm, "F.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.2.2. Operational semantics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.2</seealso>
    let ``F.3.2.2`` = Prefixed_Name(acm, "F.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.3.0. Control primitives</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.0</seealso>
    let ``F.3.3.0`` = Prefixed_Name(acm, "F.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.3.1. Functional constructs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.1</seealso>
    let ``F.3.3.1`` = Prefixed_Name(acm, "F.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.3.2. Object-oriented constructs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.2</seealso>
    let ``F.3.3.2`` = Prefixed_Name(acm, "F.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.3.3. Program and recursion schemes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.3</seealso>
    let ``F.3.3.3`` = Prefixed_Name(acm, "F.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.3.4. Type structure</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.4</seealso>
    let ``F.3.3.4`` = Prefixed_Name(acm, "F.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.m">http://acm.rkbexplorer.com/ontologies/acm#F.3.m</seealso>
    let ``F.3.m`` = Prefixed_Name(acm, "F.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4. MATHEMATICAL LOGIC AND FORMAL LANGUAGES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4">http://acm.rkbexplorer.com/ontologies/acm#F.4</seealso>
    let ``F.4`` = Prefixed_Name(acm, "F.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.0</seealso>
    let ``F.4.0`` = Prefixed_Name(acm, "F.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9. Robotics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9">http://acm.rkbexplorer.com/ontologies/acm#I.2.9</seealso>
    let ``I.2.9`` = Prefixed_Name(acm, "I.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.0. Autonomous vehicles</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.0</seealso>
    let ``I.2.9.0`` = Prefixed_Name(acm, "I.2.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.1. Commercial robots and applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.1</seealso>
    let ``I.2.9.1`` = Prefixed_Name(acm, "I.2.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.2. Kinematics and dynamics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.2</seealso>
    let ``I.2.9.2`` = Prefixed_Name(acm, "I.2.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.3. Manipulators</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.3</seealso>
    let ``I.2.9.3`` = Prefixed_Name(acm, "I.2.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.4. Operator interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.4</seealso>
    let ``I.2.9.4`` = Prefixed_Name(acm, "I.2.9.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.5. Propelling mechanisms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.5</seealso>
    let ``I.2.9.5`` = Prefixed_Name(acm, "I.2.9.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.2.9.6. Sensors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.6</seealso>
    let ``I.2.9.6`` = Prefixed_Name(acm, "I.2.9.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #B.4.2.</para>
    /// labels<para>I.3.1. Hardware Architecture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.1</seealso>
    let ``I.3.1`` = Prefixed_Name(acm, "I.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.1.0. Graphics processors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.0</seealso>
    let ``I.3.1.0`` = Prefixed_Name(acm, "I.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.1.1. Hardcopy devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.1</seealso>
    let ``I.3.1.1`` = Prefixed_Name(acm, "I.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.1.2. Input devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.2</seealso>
    let ``I.3.1.2`` = Prefixed_Name(acm, "I.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.1.3. Parallel processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.3</seealso>
    let ``I.3.1.3`` = Prefixed_Name(acm, "I.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.1.4. Raster display devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.4</seealso>
    let ``I.3.1.4`` = Prefixed_Name(acm, "I.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.1.5. Storage devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.5</seealso>
    let ``I.3.1.5`` = Prefixed_Name(acm, "I.3.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.1.7. Vector display devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.7</seealso>
    let ``I.3.1.7`` = Prefixed_Name(acm, "I.3.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.2.1, #C.2.4, #C.3.</para>
    /// labels<para>I.3.2. Graphics Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.2</seealso>
    let ``I.3.2`` = Prefixed_Name(acm, "I.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.2.0. Distributed/network graphics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.2.0</seealso>
    let ``I.3.2.0`` = Prefixed_Name(acm, "I.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.2.1. Remote systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.2.1</seealso>
    let ``I.3.2.1`` = Prefixed_Name(acm, "I.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.2.2. Stand-alone systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.2.2</seealso>
    let ``I.3.2.2`` = Prefixed_Name(acm, "I.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.3. Picture/Image Generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.3</seealso>
    let ``I.3.3`` = Prefixed_Name(acm, "I.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.3.0. Antialiasing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.0</seealso>
    let ``I.3.3.0`` = Prefixed_Name(acm, "I.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.3.1. Bitmap and framebuffer operations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.1</seealso>
    let ``I.3.3.1`` = Prefixed_Name(acm, "I.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.3.3. Software selection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.3</seealso>
    let ``K.6.3.3`` = Prefixed_Name(acm, "K.6.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.4. System Management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.4</seealso>
    let ``K.6.4`` = Prefixed_Name(acm, "K.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.4.0. Centralization/decentralization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.4.0</seealso>
    let ``K.6.4.0`` = Prefixed_Name(acm, "K.6.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.4.1. Management audit</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.4.1</seealso>
    let ``K.6.4.1`` = Prefixed_Name(acm, "K.6.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.4.2. Quality assurance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.4.2</seealso>
    let ``K.6.4.2`` = Prefixed_Name(acm, "K.6.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.4.6, #K.4.2.</para>
    /// labels<para>K.6.5. Security and Protection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5">http://acm.rkbexplorer.com/ontologies/acm#K.6.5</seealso>
    let ``K.6.5`` = Prefixed_Name(acm, "K.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.5.0. Authentication</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.0</seealso>
    let ``K.6.5.0`` = Prefixed_Name(acm, "K.6.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5.1. Buses</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.1</seealso>
    let ``C.2.5.1`` = Prefixed_Name(acm, "C.2.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.5.5. Token rings</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.5">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.5</seealso>
    let ``C.2.5.5`` = Prefixed_Name(acm, "C.2.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.2.6.1. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.6.1</seealso>
    let ``C.2.6.1`` = Prefixed_Name(acm, "C.2.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.3.1. Process control systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.3.1</seealso>
    let ``C.3.1`` = Prefixed_Name(acm, "C.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.3.3. Signal processing systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.3">http://acm.rkbexplorer.com/ontologies/acm#C.3.3</seealso>
    let ``C.3.3`` = Prefixed_Name(acm, "C.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4.2. Measurement techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.2">http://acm.rkbexplorer.com/ontologies/acm#C.4.2</seealso>
    let ``C.4.2`` = Prefixed_Name(acm, "C.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4.5. Reliability, availability, and serviceability</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.5">http://acm.rkbexplorer.com/ontologies/acm#C.4.5</seealso>
    let ``C.4.5`` = Prefixed_Name(acm, "C.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5. COMPUTER SYSTEM IMPLEMENTATION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5">http://acm.rkbexplorer.com/ontologies/acm#C.5</seealso>
    let ``C.5`` = Prefixed_Name(acm, "C.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.1. Large and Medium Computers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1">http://acm.rkbexplorer.com/ontologies/acm#C.5.1</seealso>
    let ``C.5.1`` = Prefixed_Name(acm, "C.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.3. Microcomputers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3">http://acm.rkbexplorer.com/ontologies/acm#C.5.3</seealso>
    let ``C.5.3`` = Prefixed_Name(acm, "C.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.3.3. Workstations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.3">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.3</seealso>
    let ``C.5.3.3`` = Prefixed_Name(acm, "C.5.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.4.2. Message sending</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.2</seealso>
    let ``D.4.4.2`` = Prefixed_Name(acm, "D.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.4.3. Network communication</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.3</seealso>
    let ``D.4.4.3`` = Prefixed_Name(acm, "D.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.4.4. Terminal management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.4</seealso>
    let ``D.4.4.4`` = Prefixed_Name(acm, "D.4.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.5.0. Backup procedures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.0</seealso>
    let ``D.4.5.0`` = Prefixed_Name(acm, "D.4.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.5.1. Checkpoint/restart</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.1</seealso>
    let ``D.4.5.1`` = Prefixed_Name(acm, "D.4.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.5.3. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.3</seealso>
    let ``D.4.5.3`` = Prefixed_Name(acm, "D.4.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #K.6.5.</para>
    /// labels<para>D.4.6. Security and Protection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.6</seealso>
    let ``D.4.6`` = Prefixed_Name(acm, "D.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.6.2. Cryptographic controls</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.2</seealso>
    let ``D.4.6.2`` = Prefixed_Name(acm, "D.4.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.6.3. Information flow controls</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.3</seealso>
    let ``D.4.6.3`` = Prefixed_Name(acm, "D.4.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.6.6. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.6</seealso>
    let ``D.4.6.6`` = Prefixed_Name(acm, "D.4.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.7. Organization and Design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7">http://acm.rkbexplorer.com/ontologies/acm#D.4.7</seealso>
    let ``D.4.7`` = Prefixed_Name(acm, "D.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.7.4. Real-time systems and embedded systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.4</seealso>
    let ``D.4.7.4`` = Prefixed_Name(acm, "D.4.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #C.4, #D.2.8, #I.6.</para>
    /// labels<para>D.4.8. Performance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8">http://acm.rkbexplorer.com/ontologies/acm#D.4.8</seealso>
    let ``D.4.8`` = Prefixed_Name(acm, "D.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.3. Operational analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.3</seealso>
    let ``D.4.8.3`` = Prefixed_Name(acm, "D.4.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.4. Queueing theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.4</seealso>
    let ``D.4.8.4`` = Prefixed_Name(acm, "D.4.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.9.0. Command and control languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.0</seealso>
    let ``D.4.9.0`` = Prefixed_Name(acm, "D.4.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.9.1. Linkers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.1</seealso>
    let ``D.4.9.1`` = Prefixed_Name(acm, "D.4.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.m.0. Software psychology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.m.0">http://acm.rkbexplorer.com/ontologies/acm#D.m.0</seealso>
    let ``D.m.0`` = Prefixed_Name(acm, "D.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E. Data</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E">http://acm.rkbexplorer.com/ontologies/acm#E</seealso>
    let E = Prefixed_Name(acm, "E") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.0">http://acm.rkbexplorer.com/ontologies/acm#E.0</seealso>
    let ``E.0`` = Prefixed_Name(acm, "E.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1. DATA STRUCTURES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1">http://acm.rkbexplorer.com/ontologies/acm#E.1</seealso>
    let ``E.1`` = Prefixed_Name(acm, "E.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1.3. Lists, stacks, and queues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.3">http://acm.rkbexplorer.com/ontologies/acm#E.1.3</seealso>
    let ``E.1.3`` = Prefixed_Name(acm, "E.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1.4. Records</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.4">http://acm.rkbexplorer.com/ontologies/acm#E.1.4</seealso>
    let ``E.1.4`` = Prefixed_Name(acm, "E.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.1.5. Tables</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.5">http://acm.rkbexplorer.com/ontologies/acm#E.1.5</seealso>
    let ``E.1.5`` = Prefixed_Name(acm, "E.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1.6. Trees</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.6">http://acm.rkbexplorer.com/ontologies/acm#E.1.6</seealso>
    let ``E.1.6`` = Prefixed_Name(acm, "E.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.2.1. Contiguous representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.1">http://acm.rkbexplorer.com/ontologies/acm#E.2.1</seealso>
    let ``E.2.1`` = Prefixed_Name(acm, "E.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.2.2. Hash-table representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.2">http://acm.rkbexplorer.com/ontologies/acm#E.2.2</seealso>
    let ``E.2.2`` = Prefixed_Name(acm, "E.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.2.3. Linked representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.3">http://acm.rkbexplorer.com/ontologies/acm#E.2.3</seealso>
    let ``E.2.3`` = Prefixed_Name(acm, "E.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.2.4. Object representation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.4">http://acm.rkbexplorer.com/ontologies/acm#E.2.4</seealso>
    let ``E.2.4`` = Prefixed_Name(acm, "E.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.3.0. Code breaking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.0">http://acm.rkbexplorer.com/ontologies/acm#E.3.0</seealso>
    let ``E.3.0`` = Prefixed_Name(acm, "E.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.3.1. Data encryption standard</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.1">http://acm.rkbexplorer.com/ontologies/acm#E.3.1</seealso>
    let ``E.3.1`` = Prefixed_Name(acm, "E.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.3.2. Public key cryptosystems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.2">http://acm.rkbexplorer.com/ontologies/acm#E.3.2</seealso>
    let ``E.3.2`` = Prefixed_Name(acm, "E.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.3.3. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.3">http://acm.rkbexplorer.com/ontologies/acm#E.3.3</seealso>
    let ``E.3.3`` = Prefixed_Name(acm, "E.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.4.1. Error control codes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.1">http://acm.rkbexplorer.com/ontologies/acm#E.4.1</seealso>
    let ``E.4.1`` = Prefixed_Name(acm, "E.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.4.2. Formal models of communication</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.2">http://acm.rkbexplorer.com/ontologies/acm#E.4.2</seealso>
    let ``E.4.2`` = Prefixed_Name(acm, "E.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.4.3. Nonsecret encoding schemes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.3">http://acm.rkbexplorer.com/ontologies/acm#E.4.3</seealso>
    let ``E.4.3`` = Prefixed_Name(acm, "E.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.4.3, #F.2.2, #H.2.</para>
    /// labels<para>E.5. FILES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5">http://acm.rkbexplorer.com/ontologies/acm#E.5</seealso>
    let ``E.5`` = Prefixed_Name(acm, "E.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.m">http://acm.rkbexplorer.com/ontologies/acm#E.m</seealso>
    let ``E.m`` = Prefixed_Name(acm, "E.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F. Theory of Computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F">http://acm.rkbexplorer.com/ontologies/acm#F</seealso>
    let F = Prefixed_Name(acm, "F") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.0">http://acm.rkbexplorer.com/ontologies/acm#F.0</seealso>
    let ``F.0`` = Prefixed_Name(acm, "F.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1. COMPUTATION BY ABSTRACT DEVICES</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1">http://acm.rkbexplorer.com/ontologies/acm#F.1</seealso>
    let ``F.1`` = Prefixed_Name(acm, "F.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.1.3. Relations between models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.3</seealso>
    let ``F.1.1.3`` = Prefixed_Name(acm, "F.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.1.4. Self-modifying machines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.4</seealso>
    let ``F.1.1.4`` = Prefixed_Name(acm, "F.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.1.5. Unbounded-action devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.5">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.5</seealso>
    let ``F.1.1.5`` = Prefixed_Name(acm, "F.1.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2. Modes of Computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.2</seealso>
    let ``F.1.2`` = Prefixed_Name(acm, "F.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2.4. Probabilistic computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.4</seealso>
    let ``F.1.2.4`` = Prefixed_Name(acm, "F.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>F.1.2.5. Relations among modes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.5">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.5</seealso>
    let ``F.1.2.5`` = Prefixed_Name(acm, "F.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2.6. Relativized computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.6">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.6</seealso>
    let ``F.1.2.6`` = Prefixed_Name(acm, "F.1.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.2.</para>
    /// labels<para>F.1.3. Complexity Measures and Classes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.3</seealso>
    let ``F.1.3`` = Prefixed_Name(acm, "F.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.3.1. Data manipulation languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.1</seealso>
    let ``H.2.3.1`` = Prefixed_Name(acm, "H.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.3.2. Database programming languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.2</seealso>
    let ``H.2.3.2`` = Prefixed_Name(acm, "H.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.3.3. Query languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.3</seealso>
    let ``H.2.3.3`` = Prefixed_Name(acm, "H.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.3.4. Report writers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.4</seealso>
    let ``H.2.3.4`` = Prefixed_Name(acm, "H.2.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4. Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.4</seealso>
    let ``H.2.4`` = Prefixed_Name(acm, "H.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.0. Concurrency</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.0</seealso>
    let ``H.2.4.0`` = Prefixed_Name(acm, "H.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.1. Distributed databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.1</seealso>
    let ``H.2.4.1`` = Prefixed_Name(acm, "H.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.2. Multimedia databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.2</seealso>
    let ``H.2.4.2`` = Prefixed_Name(acm, "H.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.6. Relational databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.6">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.6</seealso>
    let ``H.2.4.6`` = Prefixed_Name(acm, "H.2.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.7. Rule-based databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.7">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.7</seealso>
    let ``H.2.4.7`` = Prefixed_Name(acm, "H.2.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.8. Textual databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.8">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.8</seealso>
    let ``H.2.4.8`` = Prefixed_Name(acm, "H.2.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.4.9. Transaction processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.9">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.9</seealso>
    let ``H.2.4.9`` = Prefixed_Name(acm, "H.2.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.5. Heterogeneous Databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5">http://acm.rkbexplorer.com/ontologies/acm#H.2.5</seealso>
    let ``H.2.5`` = Prefixed_Name(acm, "H.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.2.5.0. Data translation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.5.0</seealso>
    let ``H.2.5.0`` = Prefixed_Name(acm, "H.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.2.5.1. Program translation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.5.1</seealso>
    let ``H.2.5.1`` = Prefixed_Name(acm, "H.2.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.6. Database Machines</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.6">http://acm.rkbexplorer.com/ontologies/acm#H.2.6</seealso>
    let ``H.2.6`` = Prefixed_Name(acm, "H.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.7.3. Security, integrity, and protection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.3</seealso>
    let ``H.2.7.3`` = Prefixed_Name(acm, "H.2.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.8. Database Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8">http://acm.rkbexplorer.com/ontologies/acm#H.2.8</seealso>
    let ``H.2.8`` = Prefixed_Name(acm, "H.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.8.0. Data mining</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.0</seealso>
    let ``H.2.8.0`` = Prefixed_Name(acm, "H.2.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.8.1. Image databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.1</seealso>
    let ``H.2.8.1`` = Prefixed_Name(acm, "H.2.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.8.2. Scientific databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.2</seealso>
    let ``H.2.8.2`` = Prefixed_Name(acm, "H.2.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.8.3. Spatial databases and GIS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.3</seealso>
    let ``H.2.8.3`` = Prefixed_Name(acm, "H.2.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.8.4. Statistical databases</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.4</seealso>
    let ``H.2.8.4`` = Prefixed_Name(acm, "H.2.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.2.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.m">http://acm.rkbexplorer.com/ontologies/acm#H.2.m</seealso>
    let ``H.2.m`` = Prefixed_Name(acm, "H.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.1. Content Analysis and Indexing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.1</seealso>
    let ``H.3.1`` = Prefixed_Name(acm, "H.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.1.0. Abstracting methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.0</seealso>
    let ``H.3.1.0`` = Prefixed_Name(acm, "H.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.1.1. Dictionaries</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.1</seealso>
    let ``H.3.1.1`` = Prefixed_Name(acm, "H.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.1.2. Indexing methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.2</seealso>
    let ``H.3.1.2`` = Prefixed_Name(acm, "H.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.1.3. Linguistic processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.3</seealso>
    let ``H.3.1.3`` = Prefixed_Name(acm, "H.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.1.4. Thesauruses</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.4</seealso>
    let ``H.3.1.4`` = Prefixed_Name(acm, "H.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.2. Information Storage</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.2</seealso>
    let ``H.3.2`` = Prefixed_Name(acm, "H.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.2.0. File organization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.2.0</seealso>
    let ``H.3.2.0`` = Prefixed_Name(acm, "H.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.0. Clustering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.0</seealso>
    let ``H.3.3.0`` = Prefixed_Name(acm, "H.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.1. Information filtering</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.1</seealso>
    let ``H.3.3.1`` = Prefixed_Name(acm, "H.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.2. Query formulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.2</seealso>
    let ``H.3.3.2`` = Prefixed_Name(acm, "H.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.3. Relevance feedback</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.3</seealso>
    let ``H.3.3.3`` = Prefixed_Name(acm, "H.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.4. Retrieval models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.4</seealso>
    let ``H.3.3.4`` = Prefixed_Name(acm, "H.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.5. Search process</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.5">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.5</seealso>
    let ``H.3.3.5`` = Prefixed_Name(acm, "H.3.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3.6. Selection process</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.6">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.6</seealso>
    let ``H.3.3.6`` = Prefixed_Name(acm, "H.3.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.4. Systems and Software</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.4</seealso>
    let ``H.3.4`` = Prefixed_Name(acm, "H.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.5.1. Data sharing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.5.1</seealso>
    let ``H.3.5.1`` = Prefixed_Name(acm, "H.3.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.5.2. Web-based services</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.5.2</seealso>
    let ``H.3.5.2`` = Prefixed_Name(acm, "H.3.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.6. Library Automation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6">http://acm.rkbexplorer.com/ontologies/acm#H.3.6</seealso>
    let ``H.3.6`` = Prefixed_Name(acm, "H.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.6.0. Large text archives</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.6.0</seealso>
    let ``H.3.6.0`` = Prefixed_Name(acm, "H.3.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.7. Digital Libraries</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7">http://acm.rkbexplorer.com/ontologies/acm#H.3.7</seealso>
    let ``H.3.7`` = Prefixed_Name(acm, "H.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.7.0. Collection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.0</seealso>
    let ``H.3.7.0`` = Prefixed_Name(acm, "H.3.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.7.1. Dissemination</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.1</seealso>
    let ``H.3.7.1`` = Prefixed_Name(acm, "H.3.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.7.2. Standards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.2</seealso>
    let ``H.3.7.2`` = Prefixed_Name(acm, "H.3.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.3.3. Display algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.3</seealso>
    let ``I.3.3.3`` = Prefixed_Name(acm, "I.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.3.4. Line and curve generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.4</seealso>
    let ``I.3.3.4`` = Prefixed_Name(acm, "I.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.3.5. Viewing algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.5</seealso>
    let ``I.3.3.5`` = Prefixed_Name(acm, "I.3.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4. Graphics Utilities</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.4</seealso>
    let ``I.3.4`` = Prefixed_Name(acm, "I.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4.0. Application packages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.0</seealso>
    let ``I.3.4.0`` = Prefixed_Name(acm, "I.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.4.1. Device drivers</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.1</seealso>
    let ``I.3.4.1`` = Prefixed_Name(acm, "I.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4.2. Graphics editors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.2</seealso>
    let ``I.3.4.2`` = Prefixed_Name(acm, "I.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4.3. Graphics packages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.3</seealso>
    let ``I.3.4.3`` = Prefixed_Name(acm, "I.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4.5. Paint systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.5</seealso>
    let ``I.3.4.5`` = Prefixed_Name(acm, "I.3.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.4.6. Picture description languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.6</seealso>
    let ``I.3.4.6`` = Prefixed_Name(acm, "I.3.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4.7. Software support</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.7</seealso>
    let ``I.3.4.7`` = Prefixed_Name(acm, "I.3.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.4.8. Virtual device interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.8">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.8</seealso>
    let ``I.3.4.8`` = Prefixed_Name(acm, "I.3.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5. Computational Geometry and Object Modeling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.5</seealso>
    let ``I.3.5`` = Prefixed_Name(acm, "I.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.0. Boundary representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.0</seealso>
    let ``I.3.5.0`` = Prefixed_Name(acm, "I.3.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.3.5.1. Constructive solid geometry</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.1</seealso>
    let ``I.3.5.1`` = Prefixed_Name(acm, "I.3.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.5.2. Curve, surface, solid, and object representations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.2</seealso>
    let ``I.3.5.2`` = Prefixed_Name(acm, "I.3.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.2. Organizations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.2">http://acm.rkbexplorer.com/ontologies/acm#K.7.2</seealso>
    let ``K.7.2`` = Prefixed_Name(acm, "K.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.3. Testing, Certification, and Licensing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.3">http://acm.rkbexplorer.com/ontologies/acm#K.7.3</seealso>
    let ``K.7.3`` = Prefixed_Name(acm, "K.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #K.4.</para>
    /// labels<para>K.7.4. Professional Ethics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4">http://acm.rkbexplorer.com/ontologies/acm#K.7.4</seealso>
    let ``K.7.4`` = Prefixed_Name(acm, "K.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.4.0. Codes of ethics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.7.4.0</seealso>
    let ``K.7.4.0`` = Prefixed_Name(acm, "K.7.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.4.1. Codes of good practice</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.7.4.1</seealso>
    let ``K.7.4.1`` = Prefixed_Name(acm, "K.7.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.4.2. Ethical dilemmas</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.7.4.2</seealso>
    let ``K.7.4.2`` = Prefixed_Name(acm, "K.7.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.7.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m">http://acm.rkbexplorer.com/ontologies/acm#K.7.m</seealso>
    let ``K.7.m`` = Prefixed_Name(acm, "K.7.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.7.m.0. Codes of good practice</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.7.m.0</seealso>
    let ``K.7.m.0`` = Prefixed_Name(acm, "K.7.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>K.7.m.1. Ethics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.7.m.1</seealso>
    let ``K.7.m.1`` = Prefixed_Name(acm, "K.7.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8. PERSONAL COMPUTING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8">http://acm.rkbexplorer.com/ontologies/acm#K.8</seealso>
    let ``K.8`` = Prefixed_Name(acm, "K.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1991.</para>
    /// labels<para>K.8.0. General</para><para>K.8.0. Games</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0">http://acm.rkbexplorer.com/ontologies/acm#K.8.0</seealso>
    let ``K.8.0`` = Prefixed_Name(acm, "K.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.0.0. Games</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0.0">http://acm.rkbexplorer.com/ontologies/acm#K.8.0.0</seealso>
    let ``K.8.0.0`` = Prefixed_Name(acm, "K.8.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1. Application Packages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1">http://acm.rkbexplorer.com/ontologies/acm#K.8.1</seealso>
    let ``K.8.1`` = Prefixed_Name(acm, "K.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1.0. Data communications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.0</seealso>
    let ``K.8.1.0`` = Prefixed_Name(acm, "K.8.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.8.1.1. Database processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.1</seealso>
    let ``K.8.1.1`` = Prefixed_Name(acm, "K.8.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.4.1. Fault tolerance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.1">http://acm.rkbexplorer.com/ontologies/acm#C.4.1</seealso>
    let ``C.4.1`` = Prefixed_Name(acm, "C.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.0">http://acm.rkbexplorer.com/ontologies/acm#C.5.0</seealso>
    let ``C.5.0`` = Prefixed_Name(acm, "C.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.3.2. Portable devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.2</seealso>
    let ``C.5.3.2`` = Prefixed_Name(acm, "C.5.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>C.5.4. VLSI Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.4">http://acm.rkbexplorer.com/ontologies/acm#C.5.4</seealso>
    let ``C.5.4`` = Prefixed_Name(acm, "C.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.0">http://acm.rkbexplorer.com/ontologies/acm#D.0</seealso>
    let ``D.0`` = Prefixed_Name(acm, "D.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.1.0</seealso>
    let ``D.1.0`` = Prefixed_Name(acm, "D.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.4. Sequential Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.4">http://acm.rkbexplorer.com/ontologies/acm#D.1.4</seealso>
    let ``D.1.4`` = Prefixed_Name(acm, "D.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.5. Multivariate statistics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.5">http://acm.rkbexplorer.com/ontologies/acm#G.3.5</seealso>
    let ``G.3.5`` = Prefixed_Name(acm, "G.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.6. Nonparametric statistics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.6">http://acm.rkbexplorer.com/ontologies/acm#G.3.6</seealso>
    let ``G.3.6`` = Prefixed_Name(acm, "G.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.3.9. Random number generation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.9">http://acm.rkbexplorer.com/ontologies/acm#G.3.9</seealso>
    let ``G.3.9`` = Prefixed_Name(acm, "G.3.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4. MATHEMATICAL SOFTWARE</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4">http://acm.rkbexplorer.com/ontologies/acm#G.4</seealso>
    let ``G.4`` = Prefixed_Name(acm, "G.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.4.2. Documentation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.2">http://acm.rkbexplorer.com/ontologies/acm#G.4.2</seealso>
    let ``G.4.2`` = Prefixed_Name(acm, "G.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.2.0. Algebraic algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.2.0</seealso>
    let ``I.1.2.0`` = Prefixed_Name(acm, "I.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.1.2.1. Analysis of algorithms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.2.1</seealso>
    let ``I.1.2.1`` = Prefixed_Name(acm, "I.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.2, #D.3.3, #F.2.2.</para>
    /// labels<para>I.1.3. Languages and Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.1.3</seealso>
    let ``I.1.3`` = Prefixed_Name(acm, "I.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.1.6. Threads</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.6</seealso>
    let ``D.4.1.6`` = Prefixed_Name(acm, "D.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.7.4. Radiosity</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.4</seealso>
    let ``I.3.7.4`` = Prefixed_Name(acm, "I.3.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.0</seealso>
    let ``I.4.0`` = Prefixed_Name(acm, "I.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.3.3.1. Simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.3.1</seealso>
    let ``B.3.3.1`` = Prefixed_Name(acm, "B.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.2.1. Parallel programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.1.2.1</seealso>
    let ``D.1.2.1`` = Prefixed_Name(acm, "D.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.1.5. Object-oriented Programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.5">http://acm.rkbexplorer.com/ontologies/acm#D.1.5</seealso>
    let ``D.1.5`` = Prefixed_Name(acm, "D.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #K.5.1.</para>
    /// labels<para>D.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.0</seealso>
    let ``D.2.0`` = Prefixed_Name(acm, "D.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.2.0.0. Protection mechanisms</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.0.0</seealso>
    let ``D.2.0.0`` = Prefixed_Name(acm, "D.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.7.0. Batch processing systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.0</seealso>
    let ``D.4.7.0`` = Prefixed_Name(acm, "D.4.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.7.3. Interactive systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.3</seealso>
    let ``D.4.7.3`` = Prefixed_Name(acm, "D.4.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.8.2. Monitors</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.2</seealso>
    let ``D.4.8.2`` = Prefixed_Name(acm, "D.4.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.4.9. Systems Programs and Utilities</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9">http://acm.rkbexplorer.com/ontologies/acm#D.4.9</seealso>
    let ``D.4.9`` = Prefixed_Name(acm, "D.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.4.9.2. Loaders</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.2</seealso>
    let ``D.4.9.2`` = Prefixed_Name(acm, "D.4.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>D.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.m">http://acm.rkbexplorer.com/ontologies/acm#D.m</seealso>
    let ``D.m`` = Prefixed_Name(acm, "D.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1.0. Arrays</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.0">http://acm.rkbexplorer.com/ontologies/acm#E.1.0</seealso>
    let ``E.1.0`` = Prefixed_Name(acm, "E.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1.1. Distributed data structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.1">http://acm.rkbexplorer.com/ontologies/acm#E.1.1</seealso>
    let ``E.1.1`` = Prefixed_Name(acm, "E.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.1.2. Graphs and networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.2">http://acm.rkbexplorer.com/ontologies/acm#E.1.2</seealso>
    let ``E.1.2`` = Prefixed_Name(acm, "E.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.2. DATA STORAGE REPRESENTATIONS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2">http://acm.rkbexplorer.com/ontologies/acm#E.2</seealso>
    let ``E.2`` = Prefixed_Name(acm, "E.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.2.0. Composite structures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.0">http://acm.rkbexplorer.com/ontologies/acm#E.2.0</seealso>
    let ``E.2.0`` = Prefixed_Name(acm, "E.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.2.5. Primitive data items</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.5">http://acm.rkbexplorer.com/ontologies/acm#E.2.5</seealso>
    let ``E.2.5`` = Prefixed_Name(acm, "E.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.3. DATA ENCRYPTION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3">http://acm.rkbexplorer.com/ontologies/acm#E.3</seealso>
    let ``E.3`` = Prefixed_Name(acm, "E.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #H.1.1.</para>
    /// labels<para>E.4. CODING AND INFORMATION THEORY</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4">http://acm.rkbexplorer.com/ontologies/acm#E.4</seealso>
    let ``E.4`` = Prefixed_Name(acm, "E.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.4.0. Data compaction and compression</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.0">http://acm.rkbexplorer.com/ontologies/acm#E.4.0</seealso>
    let ``E.4.0`` = Prefixed_Name(acm, "E.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.5.0. Backup/recovery</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.0">http://acm.rkbexplorer.com/ontologies/acm#E.5.0</seealso>
    let ``E.5.0`` = Prefixed_Name(acm, "E.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>E.5.1. Optimization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.1">http://acm.rkbexplorer.com/ontologies/acm#E.5.1</seealso>
    let ``E.5.1`` = Prefixed_Name(acm, "E.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>E.5.2. Organization/structure</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.2">http://acm.rkbexplorer.com/ontologies/acm#E.5.2</seealso>
    let ``E.5.2`` = Prefixed_Name(acm, "E.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.0</seealso>
    let ``F.1.0`` = Prefixed_Name(acm, "F.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.4.1.</para>
    /// labels<para>F.1.1. Models of Computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.1</seealso>
    let ``F.1.1`` = Prefixed_Name(acm, "F.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.1.0. Automata</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.0</seealso>
    let ``F.1.1.0`` = Prefixed_Name(acm, "F.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.1.1. Bounded-action devices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.1</seealso>
    let ``F.1.1.1`` = Prefixed_Name(acm, "F.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2.0. Alternation and nondeterminism</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.0</seealso>
    let ``F.1.2.0`` = Prefixed_Name(acm, "F.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2.1. Interactive and reactive computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.1</seealso>
    let ``F.1.2.1`` = Prefixed_Name(acm, "F.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2.2. Online computation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.2</seealso>
    let ``F.1.2.2`` = Prefixed_Name(acm, "F.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.2.3. Parallelism and concurrency</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.3</seealso>
    let ``F.1.2.3`` = Prefixed_Name(acm, "F.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.3.0. Complexity hierarchies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.0</seealso>
    let ``F.1.3.0`` = Prefixed_Name(acm, "F.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>F.1.3.1. Machine-independent complexity</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.1</seealso>
    let ``F.1.3.1`` = Prefixed_Name(acm, "F.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.3.2. Reducibility and completeness</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.2</seealso>
    let ``F.1.3.2`` = Prefixed_Name(acm, "F.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.1.3.3. Relations among complexity classes</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.3</seealso>
    let ``F.1.3.3`` = Prefixed_Name(acm, "F.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #B.6, #B.7, #F.1.3.</para>
    /// labels<para>F.2. ANALYSIS OF ALGORITHMS AND PROBLEM COMPLEXITY</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2">http://acm.rkbexplorer.com/ontologies/acm#F.2</seealso>
    let ``F.2`` = Prefixed_Name(acm, "F.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.2.0</seealso>
    let ``F.2.0`` = Prefixed_Name(acm, "F.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #G.1, #G.4, #I.1.</para>
    /// labels<para>F.2.1. Numerical Algorithms and Problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.2.1</seealso>
    let ``F.2.1`` = Prefixed_Name(acm, "F.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.1.2. Computations on matrices</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.2</seealso>
    let ``F.2.1.2`` = Prefixed_Name(acm, "F.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.1.3. Computations on polynomials</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.3</seealso>
    let ``F.2.1.3`` = Prefixed_Name(acm, "F.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.1.4. Number-theoretic computations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.4</seealso>
    let ``F.2.1.4`` = Prefixed_Name(acm, "F.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.2, #E.3, #E.4, #E.5, #G.2, #H.2, #H.3.</para>
    /// labels<para>F.2.2. Nonnumerical Algorithms and Problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.2.2</seealso>
    let ``F.2.2`` = Prefixed_Name(acm, "F.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.5. Sequencing and scheduling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.5">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.5</seealso>
    let ``F.2.2.5`` = Prefixed_Name(acm, "F.2.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.2.2.6. Sorting and searching</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.6">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.6</seealso>
    let ``F.2.2.6`` = Prefixed_Name(acm, "F.2.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.1.3.</para>
    /// labels<para>F.2.3. Tradeoffs between Complexity Measures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.2.3</seealso>
    let ``F.2.3`` = Prefixed_Name(acm, "F.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3. LOGICS AND MEANINGS OF PROGRAMS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3">http://acm.rkbexplorer.com/ontologies/acm#F.3</seealso>
    let ``F.3`` = Prefixed_Name(acm, "F.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.1.2. Logics of programs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.2</seealso>
    let ``F.3.1.2`` = Prefixed_Name(acm, "F.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.1.3. Mechanical verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.3</seealso>
    let ``F.3.1.3`` = Prefixed_Name(acm, "F.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.1.4. Pre- and post-conditions</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.4</seealso>
    let ``F.3.1.4`` = Prefixed_Name(acm, "F.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.1.5. Specification techniques</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.5">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.5</seealso>
    let ``F.3.1.5`` = Prefixed_Name(acm, "F.3.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.2.3. Partial evaluation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.3</seealso>
    let ``F.3.2.3`` = Prefixed_Name(acm, "F.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.2.4. Process models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.4</seealso>
    let ``F.3.2.4`` = Prefixed_Name(acm, "F.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.3.2.5. Program analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.5</seealso>
    let ``F.3.2.5`` = Prefixed_Name(acm, "F.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.2, #D.3.3.</para>
    /// labels<para>F.3.3. Studies of Program Constructs</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.3</seealso>
    let ``F.3.3`` = Prefixed_Name(acm, "F.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #F.1.1, #I.2.2, #I.2.3, #I.2.4.</para>
    /// labels<para>F.4.1. Mathematical Logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.1</seealso>
    let ``F.4.1`` = Prefixed_Name(acm, "F.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.0. Computability theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.0</seealso>
    let ``F.4.1.0`` = Prefixed_Name(acm, "F.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.1. Computational logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.1</seealso>
    let ``F.4.1.1`` = Prefixed_Name(acm, "F.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.2. Lambda calculus and related systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.2</seealso>
    let ``F.4.1.2`` = Prefixed_Name(acm, "F.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.3. Logic and constraint programming</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.3</seealso>
    let ``F.4.1.3`` = Prefixed_Name(acm, "F.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.4. Mechanical theorem proving</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.4</seealso>
    let ``F.4.1.4`` = Prefixed_Name(acm, "F.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.5. Modal logic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.5</seealso>
    let ``F.4.1.5`` = Prefixed_Name(acm, "F.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.6. Model theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.6</seealso>
    let ``F.4.1.6`` = Prefixed_Name(acm, "F.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.7. Proof theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.7">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.7</seealso>
    let ``F.4.1.7`` = Prefixed_Name(acm, "F.4.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.8. Recursive function theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.8">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.8</seealso>
    let ``F.4.1.8`` = Prefixed_Name(acm, "F.4.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.1.9. Set theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.9">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.9</seealso>
    let ``F.4.1.9`` = Prefixed_Name(acm, "F.4.1.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.2.2. Parallel rewriting systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.2</seealso>
    let ``F.4.2.2`` = Prefixed_Name(acm, "F.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.2.3. Parsing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.3</seealso>
    let ``F.4.2.3`` = Prefixed_Name(acm, "F.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.2.4. Thue systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.4</seealso>
    let ``F.4.2.4`` = Prefixed_Name(acm, "F.4.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.1.</para>
    /// labels<para>F.4.3. Formal Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.3</seealso>
    let ``F.4.3`` = Prefixed_Name(acm, "F.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.3.0. Algebraic language theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.0</seealso>
    let ``F.4.3.0`` = Prefixed_Name(acm, "F.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.3.1. Classes defined by grammars or automata</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.1</seealso>
    let ``F.4.3.1`` = Prefixed_Name(acm, "F.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>F.4.3.2. Classes defined by resource-bounded automata</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.2</seealso>
    let ``F.4.3.2`` = Prefixed_Name(acm, "F.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.3.3. Decision problems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.3</seealso>
    let ``F.4.3.3`` = Prefixed_Name(acm, "F.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.3.4. Operations on languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.4</seealso>
    let ``F.4.3.4`` = Prefixed_Name(acm, "F.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.m">http://acm.rkbexplorer.com/ontologies/acm#F.4.m</seealso>
    let ``F.4.m`` = Prefixed_Name(acm, "F.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.m. MISCELLANEOUS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.m">http://acm.rkbexplorer.com/ontologies/acm#F.m</seealso>
    let ``F.m`` = Prefixed_Name(acm, "F.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G. Mathematics of Computing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G">http://acm.rkbexplorer.com/ontologies/acm#G</seealso>
    let G = Prefixed_Name(acm, "G") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.0. GENERAL</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.0">http://acm.rkbexplorer.com/ontologies/acm#G.0</seealso>
    let ``G.0`` = Prefixed_Name(acm, "G.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1. NUMERICAL ANALYSIS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1">http://acm.rkbexplorer.com/ontologies/acm#G.1</seealso>
    let ``G.1`` = Prefixed_Name(acm, "G.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.0</seealso>
    let ``G.1.0`` = Prefixed_Name(acm, "G.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>G.1.0.0. Computer arithmetic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.0</seealso>
    let ``G.1.0.0`` = Prefixed_Name(acm, "G.1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.3.4.0. Current awareness systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.0</seealso>
    let ``H.3.4.0`` = Prefixed_Name(acm, "H.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.4.1. Distributed systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.1</seealso>
    let ``H.3.4.1`` = Prefixed_Name(acm, "H.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.4.2. Information networks</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.2</seealso>
    let ``H.3.4.2`` = Prefixed_Name(acm, "H.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.4.3. Performance evaluation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.3</seealso>
    let ``H.3.4.3`` = Prefixed_Name(acm, "H.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.3.4.4. Question-answering systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.4</seealso>
    let ``H.3.4.4`` = Prefixed_Name(acm, "H.3.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.4.5. User profiles and alert services</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.5">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.5</seealso>
    let ``H.3.4.5`` = Prefixed_Name(acm, "H.3.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.5. Online Information Services</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5">http://acm.rkbexplorer.com/ontologies/acm#H.3.5</seealso>
    let ``H.3.5`` = Prefixed_Name(acm, "H.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.5.0. Commercial services</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.5.0</seealso>
    let ``H.3.5.0`` = Prefixed_Name(acm, "H.3.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.7.4. User issues</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.4</seealso>
    let ``H.3.7.4`` = Prefixed_Name(acm, "H.3.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.m">http://acm.rkbexplorer.com/ontologies/acm#H.3.m</seealso>
    let ``H.3.m`` = Prefixed_Name(acm, "H.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4. INFORMATION SYSTEMS APPLICATIONS</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4">http://acm.rkbexplorer.com/ontologies/acm#H.4</seealso>
    let ``H.4`` = Prefixed_Name(acm, "H.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.0</seealso>
    let ``H.4.0`` = Prefixed_Name(acm, "H.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #I.7.</para>
    /// labels<para>H.4.1. Office Automation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.1</seealso>
    let ``H.4.1`` = Prefixed_Name(acm, "H.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.1.0. Desktop publishing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.0</seealso>
    let ``H.4.1.0`` = Prefixed_Name(acm, "H.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.4.1.1. Equipment</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.1</seealso>
    let ``H.4.1.1`` = Prefixed_Name(acm, "H.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.1.2. Groupware</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.2</seealso>
    let ``H.4.1.2`` = Prefixed_Name(acm, "H.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.1.5. Word processing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.5</seealso>
    let ``H.4.1.5`` = Prefixed_Name(acm, "H.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.1.6. Workflow management</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.6</seealso>
    let ``H.4.1.6`` = Prefixed_Name(acm, "H.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.2. Types of Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.4.2</seealso>
    let ``H.4.2`` = Prefixed_Name(acm, "H.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.2.0. Decision support</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.2.0</seealso>
    let ``H.4.2.0`` = Prefixed_Name(acm, "H.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.2.1. Logistics</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.2.1</seealso>
    let ``H.4.2.1`` = Prefixed_Name(acm, "H.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.3. Communications Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.4.3</seealso>
    let ``H.4.3`` = Prefixed_Name(acm, "H.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.3.0. Bulletin boards</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.0</seealso>
    let ``H.4.3.0`` = Prefixed_Name(acm, "H.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.3.1. Computer conferencing, teleconferencing, and videoconferencing</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.1</seealso>
    let ``H.4.3.1`` = Prefixed_Name(acm, "H.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.4.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.m">http://acm.rkbexplorer.com/ontologies/acm#H.4.m</seealso>
    let ``H.4.m`` = Prefixed_Name(acm, "H.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #I.7.</para>
    /// labels<para>H.5. INFORMATION INTERFACES AND PRESENTATION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5">http://acm.rkbexplorer.com/ontologies/acm#H.5</seealso>
    let ``H.5`` = Prefixed_Name(acm, "H.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.0</seealso>
    let ``H.5.0`` = Prefixed_Name(acm, "H.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.1. Multimedia Information Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.1</seealso>
    let ``H.5.1`` = Prefixed_Name(acm, "H.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.1.0. Animations</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.0</seealso>
    let ``H.5.1.0`` = Prefixed_Name(acm, "H.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.1.1. Artificial, augmented, and virtual realities</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.1</seealso>
    let ``H.5.1.1`` = Prefixed_Name(acm, "H.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.1.2. Audio input/output</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.2</seealso>
    let ``H.5.1.2`` = Prefixed_Name(acm, "H.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.1.3. Evaluation/methodology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.3</seealso>
    let ``H.5.1.3`` = Prefixed_Name(acm, "H.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.2.2, #H.1.2, #I.3.6.</para>
    /// labels<para>H.5.2. User Interfaces</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.2</seealso>
    let ``H.5.2`` = Prefixed_Name(acm, "H.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.0. Auditory feedback</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.0</seealso>
    let ``H.5.2.0`` = Prefixed_Name(acm, "H.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.1. Benchmarking</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.1</seealso>
    let ``H.5.2.1`` = Prefixed_Name(acm, "H.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.10. Screen design</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.10">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.10</seealso>
    let ``H.5.2.10`` = Prefixed_Name(acm, "H.5.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.11. Standardization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.11">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.11</seealso>
    let ``H.5.2.11`` = Prefixed_Name(acm, "H.5.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.12. Style guides</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.12">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.12</seealso>
    let ``H.5.2.12`` = Prefixed_Name(acm, "H.5.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.5.2.13. Theory and methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.13">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.13</seealso>
    let ``H.5.2.13`` = Prefixed_Name(acm, "H.5.2.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.1. Imaging geometry</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.1</seealso>
    let ``I.4.1.1`` = Prefixed_Name(acm, "I.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.2. Quantization</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.2</seealso>
    let ``I.4.1.2`` = Prefixed_Name(acm, "I.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.3. Radiometry</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.3</seealso>
    let ``I.4.1.3`` = Prefixed_Name(acm, "I.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.4. Reflectance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.4</seealso>
    let ``I.4.1.4`` = Prefixed_Name(acm, "I.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.5. Sampling</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.5</seealso>
    let ``I.4.1.5`` = Prefixed_Name(acm, "I.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.1.6. Scanning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.6</seealso>
    let ``I.4.1.6`` = Prefixed_Name(acm, "I.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.10. Image Representation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10">http://acm.rkbexplorer.com/ontologies/acm#I.4.10</seealso>
    let ``I.4.10`` = Prefixed_Name(acm, "I.4.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.10.0. Hierarchical</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.0</seealso>
    let ``I.4.10.0`` = Prefixed_Name(acm, "I.4.10.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.10.1. Morphological</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.1</seealso>
    let ``I.4.10.1`` = Prefixed_Name(acm, "I.4.10.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.10.2. Multidimensional</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.2</seealso>
    let ``I.4.10.2`` = Prefixed_Name(acm, "I.4.10.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.10.3. Statistical</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.3</seealso>
    let ``I.4.10.3`` = Prefixed_Name(acm, "I.4.10.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.10.4. Volumetric</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.4</seealso>
    let ``I.4.10.4`` = Prefixed_Name(acm, "I.4.10.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #E.4.</para>
    /// labels<para>I.4.2. Compression</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.2</seealso>
    let ``I.4.2`` = Prefixed_Name(acm, "I.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.2.0. Approximate methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.2.0</seealso>
    let ``I.4.2.0`` = Prefixed_Name(acm, "I.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.4.2.1. Exact coding</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.2.1</seealso>
    let ``I.4.2.1`` = Prefixed_Name(acm, "I.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.3. Enhancement</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.3</seealso>
    let ``I.4.3`` = Prefixed_Name(acm, "I.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.5.0. Series expansion methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.5.0</seealso>
    let ``I.4.5.0`` = Prefixed_Name(acm, "I.4.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.4.5.1. Summation methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.5.1</seealso>
    let ``I.4.5.1`` = Prefixed_Name(acm, "I.4.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.5.2. Transform methods</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.5.2</seealso>
    let ``I.4.5.2`` = Prefixed_Name(acm, "I.4.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.6. Segmentation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6">http://acm.rkbexplorer.com/ontologies/acm#I.4.6</seealso>
    let ``I.4.6`` = Prefixed_Name(acm, "I.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.6.0. Edge and feature detection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.0</seealso>
    let ``I.4.6.0`` = Prefixed_Name(acm, "I.4.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.6.1. Pixel classification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.1</seealso>
    let ``I.4.6.1`` = Prefixed_Name(acm, "I.4.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.6.2. Region growing, partitioning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.2</seealso>
    let ``I.4.6.2`` = Prefixed_Name(acm, "I.4.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.6.3. Relaxation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.3</seealso>
    let ``I.4.6.3`` = Prefixed_Name(acm, "I.4.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7. Feature Measurement</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7">http://acm.rkbexplorer.com/ontologies/acm#I.4.7</seealso>
    let ``I.4.7`` = Prefixed_Name(acm, "I.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7.0. Feature representation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.0</seealso>
    let ``I.4.7.0`` = Prefixed_Name(acm, "I.4.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7.1. Invariants</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.1</seealso>
    let ``I.4.7.1`` = Prefixed_Name(acm, "I.4.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7.2. Moments</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.2</seealso>
    let ``I.4.7.2`` = Prefixed_Name(acm, "I.4.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7.3. Projections</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.3</seealso>
    let ``I.4.7.3`` = Prefixed_Name(acm, "I.4.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7.4. Size and shape</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.4</seealso>
    let ``I.4.7.4`` = Prefixed_Name(acm, "I.4.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.7.5. Texture</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.5</seealso>
    let ``I.4.7.5`` = Prefixed_Name(acm, "I.4.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8. Scene Analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8">http://acm.rkbexplorer.com/ontologies/acm#I.4.8</seealso>
    let ``I.4.8`` = Prefixed_Name(acm, "I.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.8.9. Stereo</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.9">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.9</seealso>
    let ``I.4.8.9`` = Prefixed_Name(acm, "I.4.8.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.9. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.9">http://acm.rkbexplorer.com/ontologies/acm#I.4.9</seealso>
    let ``I.4.9`` = Prefixed_Name(acm, "I.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.4.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.m">http://acm.rkbexplorer.com/ontologies/acm#I.4.m</seealso>
    let ``I.4.m`` = Prefixed_Name(acm, "I.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5. PATTERN RECOGNITION</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5">http://acm.rkbexplorer.com/ontologies/acm#I.5</seealso>
    let ``I.5`` = Prefixed_Name(acm, "I.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.0</seealso>
    let ``I.5.0`` = Prefixed_Name(acm, "I.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.1. Models</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.1</seealso>
    let ``I.5.1`` = Prefixed_Name(acm, "I.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>I.5.1.0. Deterministic</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.0</seealso>
    let ``I.5.1.0`` = Prefixed_Name(acm, "I.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.1.1. Fuzzy set</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.1</seealso>
    let ``I.5.1.1`` = Prefixed_Name(acm, "I.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.1.2. Geometric</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.2</seealso>
    let ``I.5.1.2`` = Prefixed_Name(acm, "I.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.1.3. Neural nets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.3</seealso>
    let ``I.5.1.3`` = Prefixed_Name(acm, "I.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.1.4. Statistical</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.4</seealso>
    let ``I.5.1.4`` = Prefixed_Name(acm, "I.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.1.5. Structural</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.5</seealso>
    let ``I.5.1.5`` = Prefixed_Name(acm, "I.5.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.2. Design Methodology</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.2</seealso>
    let ``I.5.2`` = Prefixed_Name(acm, "I.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.2.0. Classifier design and evaluation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.2.0</seealso>
    let ``I.5.2.0`` = Prefixed_Name(acm, "I.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.2.1. Feature evaluation and selection</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.2.1</seealso>
    let ``I.5.2.1`` = Prefixed_Name(acm, "I.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.2.2. Pattern analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.2.2</seealso>
    let ``I.5.2.2`` = Prefixed_Name(acm, "I.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.5.1. Special architectures</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.5.1</seealso>
    let ``I.5.5.1`` = Prefixed_Name(acm, "I.5.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.5.m. Miscellaneous</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.m">http://acm.rkbexplorer.com/ontologies/acm#I.5.m</seealso>
    let ``I.5.m`` = Prefixed_Name(acm, "I.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #G.3.</para>
    /// labels<para>I.6. SIMULATION AND MODELING</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6">http://acm.rkbexplorer.com/ontologies/acm#I.6</seealso>
    let ``I.6`` = Prefixed_Name(acm, "I.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.0. General</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.0</seealso>
    let ``I.6.0`` = Prefixed_Name(acm, "I.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.1. Simulation Theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.6.1</seealso>
    let ``I.6.1`` = Prefixed_Name(acm, "I.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.1.0. Model classification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.1.0</seealso>
    let ``I.6.1.0`` = Prefixed_Name(acm, "I.6.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.1.1. Systems theory</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.6.1.1</seealso>
    let ``I.6.1.1`` = Prefixed_Name(acm, "I.6.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1991.</para>
    /// labels<para>I.6.1.2. Types of simulation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.6.1.2</seealso>
    let ``I.6.1.2`` = Prefixed_Name(acm, "I.6.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.2. Simulation Languages</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.6.2</seealso>
    let ``I.6.2`` = Prefixed_Name(acm, "I.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.3. Applications</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.6.3</seealso>
    let ``I.6.3`` = Prefixed_Name(acm, "I.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.4. Model Validation and Analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.4">http://acm.rkbexplorer.com/ontologies/acm#I.6.4</seealso>
    let ``I.6.4`` = Prefixed_Name(acm, "I.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.5. Model Development</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5">http://acm.rkbexplorer.com/ontologies/acm#I.6.5</seealso>
    let ``I.6.5`` = Prefixed_Name(acm, "I.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.5.0. Modeling methodologies</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.5.0</seealso>
    let ``I.6.5.0`` = Prefixed_Name(acm, "I.6.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.6. Simulation Output Analysis</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.6">http://acm.rkbexplorer.com/ontologies/acm#I.6.6</seealso>
    let ``I.6.6`` = Prefixed_Name(acm, "I.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.6.7. Simulation Support Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7">http://acm.rkbexplorer.com/ontologies/acm#I.6.7</seealso>
    let ``I.6.7`` = Prefixed_Name(acm, "I.6.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:A</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A. General Literature</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A">http://acm.rkbexplorer.com/ontologies/acm#A</seealso>
    let A = Prefixed_Name(acm, "A") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.0.1. Conference proceedings</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0.1">http://acm.rkbexplorer.com/ontologies/acm#A.0.1</seealso>
    let ``A.0.1`` = Prefixed_Name(acm, "A.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A.0.2. General literary works</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0.2">http://acm.rkbexplorer.com/ontologies/acm#A.0.2</seealso>
    let ``A.0.2`` = Prefixed_Name(acm, "A.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.4.4. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.4">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.4</seealso>
    let ``B.1.4.4`` = Prefixed_Name(acm, "B.1.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.5.1. Firmware support of operating systems/instruction sets</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.1</seealso>
    let ``B.1.5.1`` = Prefixed_Name(acm, "B.1.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>B.1.5.3. Peripheral control</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.3</seealso>
    let ``B.1.5.3`` = Prefixed_Name(acm, "B.1.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>B.7.2.4. Verification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.4</seealso>
    let ``B.7.2.4`` = Prefixed_Name(acm, "B.7.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>D.2.8.4. Software science</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.4</seealso>
    let ``D.2.8.4`` = Prefixed_Name(acm, "D.2.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>See also #D.3.1.</para>
    /// labels<para>F.4.2. Grammars and Other Rewriting Systems</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.2</seealso>
    let ``F.4.2`` = Prefixed_Name(acm, "F.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F.4.2.1. Grammar types</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.1</seealso>
    let ``F.4.2.1`` = Prefixed_Name(acm, "F.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depricated, no longer used as of January 1998.</para>
    /// labels<para>H.3.2.1. Record classification</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.2.1</seealso>
    let ``H.3.2.1`` = Prefixed_Name(acm, "H.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>H.3.3. Information Search and Retrieval</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.3</seealso>
    let ``H.3.3`` = Prefixed_Name(acm, "H.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>I.3.3.2. Digitizing and scanning</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.2</seealso>
    let ``I.3.3.2`` = Prefixed_Name(acm, "I.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.2.3. Performance and usage measurement</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.3</seealso>
    let ``K.6.2.3`` = Prefixed_Name(acm, "K.6.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.2.4. Pricing and resource allocation</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.4</seealso>
    let ``K.6.2.4`` = Prefixed_Name(acm, "K.6.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.3.0. Software development</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.0</seealso>
    let ``K.6.3.0`` = Prefixed_Name(acm, "K.6.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>K.6.3.1. Software maintenance</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.1</seealso>
    let ``K.6.3.1`` = Prefixed_Name(acm, "K.6.3.1") |> PrefixedName
