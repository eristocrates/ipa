namespace http.qudt.org.vocab.sou.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qudtsou =
    let _namespace_iri = Namespace_Iri qudtsou |> NamespaceIRI
    /// <summary>
    ///   <para>qudtsou:ASU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Astronomic System Of Units"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/ASU">http://qudt.org/vocab/sou/ASU</seealso>
    let ASU = Prefixed_Name(qudtsou, "ASU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:CGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS System of Units"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/CGS">http://qudt.org/vocab/sou/CGS</seealso>
    let CGS = Prefixed_Name(qudtsou, "CGS") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:CGS-EMU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS System of Units - EMU"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/CGS-EMU">http://qudt.org/vocab/sou/CGS-EMU</seealso>
    let CGS_EMU = Prefixed_Name(qudtsou, "CGS-EMU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:CGS-ESU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS System of Units ESU"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/CGS-ESU">http://qudt.org/vocab/sou/CGS-ESU</seealso>
    let CGS_ESU = Prefixed_Name(qudtsou, "CGS-ESU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:CGS-GAUSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS System of Units - Gaussian"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/CGS-GAUSS">http://qudt.org/vocab/sou/CGS-GAUSS</seealso>
    let CGS_GAUSS = Prefixed_Name(qudtsou, "CGS-GAUSS") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:IMPERIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Imperial System of Units"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/IMPERIAL">http://qudt.org/vocab/sou/IMPERIAL</seealso>
    let IMPERIAL = Prefixed_Name(qudtsou, "IMPERIAL") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:PLANCK</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Planck System of Units"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/PLANCK">http://qudt.org/vocab/sou/PLANCK</seealso>
    let PLANCK = Prefixed_Name(qudtsou, "PLANCK") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SI</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"System International of measures."</para>
    /// labels<para>"International System of Units"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SI">http://qudt.org/vocab/sou/SI</seealso>
    let SI = Prefixed_Name(qudtsou, "SI") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_ASU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Astronomical System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_ASU">http://qudt.org/vocab/sou/SOU_ASU</seealso>
    let SOU_ASU = Prefixed_Name(qudtsou, "SOU_ASU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_CGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_CGS">http://qudt.org/vocab/sou/SOU_CGS</seealso>
    let SOU_CGS = Prefixed_Name(qudtsou, "SOU_CGS") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_CGS-EMU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS-EMU System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_CGS-EMU">http://qudt.org/vocab/sou/SOU_CGS-EMU</seealso>
    let SOU_CGS_EMU = Prefixed_Name(qudtsou, "SOU_CGS-EMU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_CGS-ESU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS-ESU System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_CGS-ESU">http://qudt.org/vocab/sou/SOU_CGS-ESU</seealso>
    let SOU_CGS_ESU = Prefixed_Name(qudtsou, "SOU_CGS-ESU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_CGS-GAUSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"CGS-Gauss System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_CGS-GAUSS">http://qudt.org/vocab/sou/SOU_CGS-GAUSS</seealso>
    let SOU_CGS_GAUSS = Prefixed_Name(qudtsou, "SOU_CGS-GAUSS") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_IMPERIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Imperial System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_IMPERIAL">http://qudt.org/vocab/sou/SOU_IMPERIAL</seealso>
    let SOU_IMPERIAL = Prefixed_Name(qudtsou, "SOU_IMPERIAL") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_PLANCK</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Planck System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_PLANCK">http://qudt.org/vocab/sou/SOU_PLANCK</seealso>
    let SOU_PLANCK = Prefixed_Name(qudtsou, "SOU_PLANCK") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_SI</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"SI System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_SI">http://qudt.org/vocab/sou/SOU_SI</seealso>
    let SOU_SI = Prefixed_Name(qudtsou, "SOU_SI") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:SOU_USCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"US Customary System of Units (deprecated URI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/SOU_USCS">http://qudt.org/vocab/sou/SOU_USCS</seealso>
    let SOU_USCS = Prefixed_Name(qudtsou, "SOU_USCS") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:UNSTATED</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"Unstated System Of Units"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/UNSTATED">http://qudt.org/vocab/sou/UNSTATED</seealso>
    let UNSTATED = Prefixed_Name(qudtsou, "UNSTATED") |> PrefixedName
    /// <summary>
    ///   <para>qudtsou:USCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>"US Customary Unit System"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/sou/USCS">http://qudt.org/vocab/sou/USCS</seealso>
    let USCS = Prefixed_Name(qudtsou, "USCS") |> PrefixedName
