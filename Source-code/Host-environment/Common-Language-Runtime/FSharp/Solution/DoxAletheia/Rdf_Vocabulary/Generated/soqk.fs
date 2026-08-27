namespace http.qudt.org.vocab.soqk.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module soqk =
    let _namespace_iri = Namespace_Iri soqk |> NamespaceIRI
    /// <summary>
    ///   <para>qudtsoqk:/CGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"CGS System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/CGS">http://qudt.org/vocab/soqk/CGS</seealso>
    let CGS = Prefixed_Name(soqk, "CGS") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/CGS-EMU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"CGS-EMU System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/CGS-EMU">http://qudt.org/vocab/soqk/CGS-EMU</seealso>
    let CGS_EMU = Prefixed_Name(soqk, "CGS-EMU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/CGS-ESU</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"CGS-ESU System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/CGS-ESU">http://qudt.org/vocab/soqk/CGS-ESU</seealso>
    let CGS_ESU = Prefixed_Name(soqk, "CGS-ESU") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/CGS-Gauss</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"CGS-Gauss System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/CGS-Gauss">http://qudt.org/vocab/soqk/CGS-Gauss</seealso>
    let CGS_Gauss = Prefixed_Name(soqk, "CGS-Gauss") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/IMPERIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"Imperial System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/IMPERIAL">http://qudt.org/vocab/soqk/IMPERIAL</seealso>
    let IMPERIAL = Prefixed_Name(soqk, "IMPERIAL") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/ISQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"ISO System of Quantity Kinds (ISQ)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/ISQ">http://qudt.org/vocab/soqk/ISQ</seealso>
    let ISQ = Prefixed_Name(soqk, "ISQ") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/Planck</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"Planck System of Quantities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/Planck">http://qudt.org/vocab/soqk/Planck</seealso>
    let Planck = Prefixed_Name(soqk, "Planck") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/SI</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"International System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/SI">http://qudt.org/vocab/soqk/SI</seealso>
    let SI = Prefixed_Name(soqk, "SI") |> PrefixedName
    /// <summary>
    ///   <para>qudtsoqk:/USCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    ///
    /// labels<para>"US Customary System of Quantity Kinds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/soqk/USCS">http://qudt.org/vocab/soqk/USCS</seealso>
    let USCS = Prefixed_Name(soqk, "USCS") |> PrefixedName
