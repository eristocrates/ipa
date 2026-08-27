namespace http.acm.rkbexplorer.com.ontologies.acm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module acm =
    let _namespace_iri = Namespace_Iri acm |> NamespaceIRI
    /// <summary>
    ///   <para>acm:A</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A. General Literature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A">http://acm.rkbexplorer.com/ontologies/acm#A</seealso>
    let A = Prefixed_Name(acm, "A") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0">http://acm.rkbexplorer.com/ontologies/acm#A.0</seealso>
    let ``A.0`` = Prefixed_Name(acm, "A.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.0.0. Biographies/autobiographies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0.0">http://acm.rkbexplorer.com/ontologies/acm#A.0.0</seealso>
    let ``A.0.0`` = Prefixed_Name(acm, "A.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.0.1. Conference proceedings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0.1">http://acm.rkbexplorer.com/ontologies/acm#A.0.1</seealso>
    let ``A.0.1`` = Prefixed_Name(acm, "A.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.0.2. General literary works"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.0.2">http://acm.rkbexplorer.com/ontologies/acm#A.0.2</seealso>
    let ``A.0.2`` = Prefixed_Name(acm, "A.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.1. INTRODUCTORY AND SURVEY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.1">http://acm.rkbexplorer.com/ontologies/acm#A.1</seealso>
    let ``A.1`` = Prefixed_Name(acm, "A.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.2. REFERENCE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.2">http://acm.rkbexplorer.com/ontologies/acm#A.2</seealso>
    let ``A.2`` = Prefixed_Name(acm, "A.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:A.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#A.m">http://acm.rkbexplorer.com/ontologies/acm#A.m</seealso>
    let ``A.m`` = Prefixed_Name(acm, "A.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B. Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B">http://acm.rkbexplorer.com/ontologies/acm#B</seealso>
    let B = Prefixed_Name(acm, "B") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.0">http://acm.rkbexplorer.com/ontologies/acm#B.0</seealso>
    let ``B.0`` = Prefixed_Name(acm, "B.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1. CONTROL STRUCTURES AND MICROPROGRAMMING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1">http://acm.rkbexplorer.com/ontologies/acm#B.1</seealso>
    let ``B.1`` = Prefixed_Name(acm, "B.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.0</seealso>
    let ``B.1.0`` = Prefixed_Name(acm, "B.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.1. Control Design Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.1</seealso>
    let ``B.1.1`` = Prefixed_Name(acm, "B.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.1.0. Hardwired control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.1.0</seealso>
    let ``B.1.1.0`` = Prefixed_Name(acm, "B.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.1.1. Microprogrammed logic arrays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.1.1</seealso>
    let ``B.1.1.1`` = Prefixed_Name(acm, "B.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.1.2. Writable control store"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.1.2</seealso>
    let ``B.1.1.2`` = Prefixed_Name(acm, "B.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.2. Control Structure Performance Analysis and Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.2</seealso>
    let ``B.1.2`` = Prefixed_Name(acm, "B.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.2.0. Automatic synthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.2.0</seealso>
    let ``B.1.2.0`` = Prefixed_Name(acm, "B.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.2.1. Formal models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.2.1</seealso>
    let ``B.1.2.1`` = Prefixed_Name(acm, "B.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.2.2. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.2.2</seealso>
    let ``B.1.2.2`` = Prefixed_Name(acm, "B.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.3. Control Structure Reliability, Testing, and Fault-Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.3</seealso>
    let ``B.1.3`` = Prefixed_Name(acm, "B.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.3.0. Diagnostics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.0</seealso>
    let ``B.1.3.0`` = Prefixed_Name(acm, "B.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.3.1. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.1</seealso>
    let ``B.1.3.1`` = Prefixed_Name(acm, "B.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.3.2. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.2</seealso>
    let ``B.1.3.2`` = Prefixed_Name(acm, "B.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.3.3. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.3.3</seealso>
    let ``B.1.3.3`` = Prefixed_Name(acm, "B.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.2.2, #D.2.4, #D.3.2, #D.3.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.4. Microprogram Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.1.4</seealso>
    let ``B.1.4`` = Prefixed_Name(acm, "B.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.4.0. Firmware engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.0</seealso>
    let ``B.1.4.0`` = Prefixed_Name(acm, "B.1.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.4.1. Languages and compilers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.1</seealso>
    let ``B.1.4.1`` = Prefixed_Name(acm, "B.1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.4.2. Machine-independent microcode generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.2</seealso>
    let ``B.1.4.2`` = Prefixed_Name(acm, "B.1.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.4.3. Optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.3</seealso>
    let ``B.1.4.3`` = Prefixed_Name(acm, "B.1.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.4.4. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.4">http://acm.rkbexplorer.com/ontologies/acm#B.1.4.4</seealso>
    let ``B.1.4.4`` = Prefixed_Name(acm, "B.1.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.5. Microcode Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5">http://acm.rkbexplorer.com/ontologies/acm#B.1.5</seealso>
    let ``B.1.5`` = Prefixed_Name(acm, "B.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.5.0. Direct data manipulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.0">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.0</seealso>
    let ``B.1.5.0`` = Prefixed_Name(acm, "B.1.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.5.1. Firmware support of operating systems/instruction sets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.1">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.1</seealso>
    let ``B.1.5.1`` = Prefixed_Name(acm, "B.1.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.5.2. Instruction set interpretation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.2">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.2</seealso>
    let ``B.1.5.2`` = Prefixed_Name(acm, "B.1.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.5.3. Peripheral control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.3">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.3</seealso>
    let ``B.1.5.3`` = Prefixed_Name(acm, "B.1.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.1.5.4. Special-purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.4">http://acm.rkbexplorer.com/ontologies/acm#B.1.5.4</seealso>
    let ``B.1.5.4`` = Prefixed_Name(acm, "B.1.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.1.m">http://acm.rkbexplorer.com/ontologies/acm#B.1.m</seealso>
    let ``B.1.m`` = Prefixed_Name(acm, "B.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2. ARITHMETIC AND LOGIC STRUCTURES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2">http://acm.rkbexplorer.com/ontologies/acm#B.2</seealso>
    let ``B.2`` = Prefixed_Name(acm, "B.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.0</seealso>
    let ``B.2.0`` = Prefixed_Name(acm, "B.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.1.1, #C.1.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.1. Design Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.1</seealso>
    let ``B.2.1`` = Prefixed_Name(acm, "B.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.1.0. Calculator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.1.0</seealso>
    let ``B.2.1.0`` = Prefixed_Name(acm, "B.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.1.1. Parallel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.1.1</seealso>
    let ``B.2.1.1`` = Prefixed_Name(acm, "B.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.1.2. Pipeline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.1.2</seealso>
    let ``B.2.1.2`` = Prefixed_Name(acm, "B.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.2. Performance Analysis and Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.2</seealso>
    let ``B.2.2`` = Prefixed_Name(acm, "B.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.2.0. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.2.0</seealso>
    let ``B.2.2.0`` = Prefixed_Name(acm, "B.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.2.1. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.2.1</seealso>
    let ``B.2.2.1`` = Prefixed_Name(acm, "B.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.2.2. Worst-case analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.2.2</seealso>
    let ``B.2.2.2`` = Prefixed_Name(acm, "B.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.3. Reliability, Testing, and Fault-Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.2.3</seealso>
    let ``B.2.3`` = Prefixed_Name(acm, "B.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.3.0. Diagnostics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.0</seealso>
    let ``B.2.3.0`` = Prefixed_Name(acm, "B.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.3.1. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.1</seealso>
    let ``B.2.3.1`` = Prefixed_Name(acm, "B.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.3.2. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.2</seealso>
    let ``B.2.3.2`` = Prefixed_Name(acm, "B.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.2.3.3. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.2.3.3</seealso>
    let ``B.2.3.3`` = Prefixed_Name(acm, "B.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.4. High-Speed Arithmetic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.2.4</seealso>
    let ``B.2.4`` = Prefixed_Name(acm, "B.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.4.0. Algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.2.4.0</seealso>
    let ``B.2.4.0`` = Prefixed_Name(acm, "B.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.4.1. Cost/performance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.2.4.1</seealso>
    let ``B.2.4.1`` = Prefixed_Name(acm, "B.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.2.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.2.m">http://acm.rkbexplorer.com/ontologies/acm#B.2.m</seealso>
    let ``B.2.m`` = Prefixed_Name(acm, "B.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3. MEMORY STRUCTURES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3">http://acm.rkbexplorer.com/ontologies/acm#B.3</seealso>
    let ``B.3`` = Prefixed_Name(acm, "B.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.0</seealso>
    let ``B.3.0`` = Prefixed_Name(acm, "B.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #B.7.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.1. Semiconductor Memories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.1</seealso>
    let ``B.3.1`` = Prefixed_Name(acm, "B.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.1.0. Dynamic memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.1.0</seealso>
    let ``B.3.1.0`` = Prefixed_Name(acm, "B.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.1.1. Read-only memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.1.1</seealso>
    let ``B.3.1.1`` = Prefixed_Name(acm, "B.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.1.2. Static memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.1.2</seealso>
    let ``B.3.1.2`` = Prefixed_Name(acm, "B.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.4.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.2. Design Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.2</seealso>
    let ``B.3.2`` = Prefixed_Name(acm, "B.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.2.0. Associative memories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.0</seealso>
    let ``B.3.2.0`` = Prefixed_Name(acm, "B.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.2.1. Cache memories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.1</seealso>
    let ``B.3.2.1`` = Prefixed_Name(acm, "B.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.2.2. Interleaved memories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.2</seealso>
    let ``B.3.2.2`` = Prefixed_Name(acm, "B.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.2.3. Mass storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.3</seealso>
    let ``B.3.2.3`` = Prefixed_Name(acm, "B.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.2.4. Primary memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.4</seealso>
    let ``B.3.2.4`` = Prefixed_Name(acm, "B.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.2.5. Sequential-access memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.5</seealso>
    let ``B.3.2.5`` = Prefixed_Name(acm, "B.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.2.6. Shared memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.6">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.6</seealso>
    let ``B.3.2.6`` = Prefixed_Name(acm, "B.3.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.2.7. Virtual memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.7">http://acm.rkbexplorer.com/ontologies/acm#B.3.2.7</seealso>
    let ``B.3.2.7`` = Prefixed_Name(acm, "B.3.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8, #C.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.3. Performance Analysis and Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.3.3</seealso>
    let ``B.3.3`` = Prefixed_Name(acm, "B.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.3.0. Formal models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.3.0</seealso>
    let ``B.3.3.0`` = Prefixed_Name(acm, "B.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.3.1. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.3.1</seealso>
    let ``B.3.3.1`` = Prefixed_Name(acm, "B.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.3.2. Worst-case analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.3.2</seealso>
    let ``B.3.3.2`` = Prefixed_Name(acm, "B.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.4. Reliability, Testing, and Fault-Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.3.4</seealso>
    let ``B.3.4`` = Prefixed_Name(acm, "B.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.4.0. Diagnostics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.0</seealso>
    let ``B.3.4.0`` = Prefixed_Name(acm, "B.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.4.1. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.1</seealso>
    let ``B.3.4.1`` = Prefixed_Name(acm, "B.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.4.2. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.2</seealso>
    let ``B.3.4.2`` = Prefixed_Name(acm, "B.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.3.4.3. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.3.4.3</seealso>
    let ``B.3.4.3`` = Prefixed_Name(acm, "B.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.3.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.3.m">http://acm.rkbexplorer.com/ontologies/acm#B.3.m</seealso>
    let ``B.3.m`` = Prefixed_Name(acm, "B.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4. INPUT/OUTPUT AND DATA COMMUNICATIONS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4">http://acm.rkbexplorer.com/ontologies/acm#B.4</seealso>
    let ``B.4`` = Prefixed_Name(acm, "B.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.0</seealso>
    let ``B.4.0`` = Prefixed_Name(acm, "B.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.1. Data Communications Devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.1</seealso>
    let ``B.4.1`` = Prefixed_Name(acm, "B.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.1.0. Processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.1.0</seealso>
    let ``B.4.1.0`` = Prefixed_Name(acm, "B.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.1.1. Receivers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.1.1</seealso>
    let ``B.4.1.1`` = Prefixed_Name(acm, "B.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.1.2. Transmitters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.1.2</seealso>
    let ``B.4.1.2`` = Prefixed_Name(acm, "B.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.2. Input/Output Devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.2</seealso>
    let ``B.4.2`` = Prefixed_Name(acm, "B.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.2.0. Channels and controllers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.0</seealso>
    let ``B.4.2.0`` = Prefixed_Name(acm, "B.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.2.1. Data terminals and printers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.1</seealso>
    let ``B.4.2.1`` = Prefixed_Name(acm, "B.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.2.2. Image display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.2</seealso>
    let ``B.4.2.2`` = Prefixed_Name(acm, "B.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.2.3. Voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.2.3</seealso>
    let ``B.4.2.3`` = Prefixed_Name(acm, "B.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.3. Interconnections"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.3</seealso>
    let ``B.4.3`` = Prefixed_Name(acm, "B.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.3.0. Asynchronous/synchronous operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.0</seealso>
    let ``B.4.3.0`` = Prefixed_Name(acm, "B.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.3.1. Fiber optics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.1</seealso>
    let ``B.4.3.1`` = Prefixed_Name(acm, "B.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.3.2. Interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.2</seealso>
    let ``B.4.3.2`` = Prefixed_Name(acm, "B.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.3.3. Parallel I/O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.3</seealso>
    let ``B.4.3.3`` = Prefixed_Name(acm, "B.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.3.4. Physical structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.4</seealso>
    let ``B.4.3.4`` = Prefixed_Name(acm, "B.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.3.5. Topology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.5">http://acm.rkbexplorer.com/ontologies/acm#B.4.3.5</seealso>
    let ``B.4.3.5`` = Prefixed_Name(acm, "B.4.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.4. Performance Analysis and Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4">http://acm.rkbexplorer.com/ontologies/acm#B.4.4</seealso>
    let ``B.4.4`` = Prefixed_Name(acm, "B.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.4.0. Formal models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.0</seealso>
    let ``B.4.4.0`` = Prefixed_Name(acm, "B.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.4.1. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.1</seealso>
    let ``B.4.4.1`` = Prefixed_Name(acm, "B.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.4.2. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.2</seealso>
    let ``B.4.4.2`` = Prefixed_Name(acm, "B.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.4.3. Worst-case analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.4.3</seealso>
    let ``B.4.4.3`` = Prefixed_Name(acm, "B.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5. Reliability, Testing, and Fault-Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5">http://acm.rkbexplorer.com/ontologies/acm#B.4.5</seealso>
    let ``B.4.5`` = Prefixed_Name(acm, "B.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5.0. Built-in tests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.0">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.0</seealso>
    let ``B.4.5.0`` = Prefixed_Name(acm, "B.4.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5.1. Diagnostics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.1">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.1</seealso>
    let ``B.4.5.1`` = Prefixed_Name(acm, "B.4.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5.2. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.2">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.2</seealso>
    let ``B.4.5.2`` = Prefixed_Name(acm, "B.4.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5.3. Hardware reliability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.3">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.3</seealso>
    let ``B.4.5.3`` = Prefixed_Name(acm, "B.4.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5.4. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.4">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.4</seealso>
    let ``B.4.5.4`` = Prefixed_Name(acm, "B.4.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.4.5.5. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.5">http://acm.rkbexplorer.com/ontologies/acm#B.4.5.5</seealso>
    let ``B.4.5.5`` = Prefixed_Name(acm, "B.4.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.4.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.4.m">http://acm.rkbexplorer.com/ontologies/acm#B.4.m</seealso>
    let ``B.4.m`` = Prefixed_Name(acm, "B.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5. REGISTER-TRANSFER-LEVEL IMPLEMENTATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5">http://acm.rkbexplorer.com/ontologies/acm#B.5</seealso>
    let ``B.5`` = Prefixed_Name(acm, "B.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.0</seealso>
    let ``B.5.0`` = Prefixed_Name(acm, "B.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.1. Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.1</seealso>
    let ``B.5.1`` = Prefixed_Name(acm, "B.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.1.0. Arithmetic and logic units"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.0</seealso>
    let ``B.5.1.0`` = Prefixed_Name(acm, "B.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.1.1. Control design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.1</seealso>
    let ``B.5.1.1`` = Prefixed_Name(acm, "B.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.1.2. Data-path design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.2</seealso>
    let ``B.5.1.2`` = Prefixed_Name(acm, "B.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.1.3. Memory design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.3</seealso>
    let ``B.5.1.3`` = Prefixed_Name(acm, "B.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.1.4. Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.5.1.4</seealso>
    let ``B.5.1.4`` = Prefixed_Name(acm, "B.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.2. Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.2</seealso>
    let ``B.5.2`` = Prefixed_Name(acm, "B.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.2.0. Automatic synthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.0</seealso>
    let ``B.5.2.0`` = Prefixed_Name(acm, "B.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.2.1. Hardware description languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.1</seealso>
    let ``B.5.2.1`` = Prefixed_Name(acm, "B.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.2.2. Optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.2</seealso>
    let ``B.5.2.2`` = Prefixed_Name(acm, "B.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.2.3. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.3</seealso>
    let ``B.5.2.3`` = Prefixed_Name(acm, "B.5.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.2.4. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.5.2.4</seealso>
    let ``B.5.2.4`` = Prefixed_Name(acm, "B.5.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.5.3. Reliability and Testing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.3</seealso>
    let ``B.5.3`` = Prefixed_Name(acm, "B.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.5.3.0. Built-in tests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.0</seealso>
    let ``B.5.3.0`` = Prefixed_Name(acm, "B.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.5.3.1. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.1</seealso>
    let ``B.5.3.1`` = Prefixed_Name(acm, "B.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.5.3.2. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.2</seealso>
    let ``B.5.3.2`` = Prefixed_Name(acm, "B.5.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.5.3.3. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.3</seealso>
    let ``B.5.3.3`` = Prefixed_Name(acm, "B.5.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.5.3.4. Testability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.5.3.4</seealso>
    let ``B.5.3.4`` = Prefixed_Name(acm, "B.5.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.5.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.5.m">http://acm.rkbexplorer.com/ontologies/acm#B.5.m</seealso>
    let ``B.5.m`` = Prefixed_Name(acm, "B.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6. LOGIC DESIGN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6">http://acm.rkbexplorer.com/ontologies/acm#B.6</seealso>
    let ``B.6`` = Prefixed_Name(acm, "B.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.0</seealso>
    let ``B.6.0`` = Prefixed_Name(acm, "B.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.1. Design Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.1</seealso>
    let ``B.6.1`` = Prefixed_Name(acm, "B.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.1.0. Cellular arrays and automata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.0</seealso>
    let ``B.6.1.0`` = Prefixed_Name(acm, "B.6.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.1.1. Combinational logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.1</seealso>
    let ``B.6.1.1`` = Prefixed_Name(acm, "B.6.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.1.2. Logic arrays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.2</seealso>
    let ``B.6.1.2`` = Prefixed_Name(acm, "B.6.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.1.3. Memory control and access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.3</seealso>
    let ``B.6.1.3`` = Prefixed_Name(acm, "B.6.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.1.4. Memory used as logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.4</seealso>
    let ``B.6.1.4`` = Prefixed_Name(acm, "B.6.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.1.5. Parallel circuits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.5">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.5</seealso>
    let ``B.6.1.5`` = Prefixed_Name(acm, "B.6.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.1.6. Sequential circuits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.6">http://acm.rkbexplorer.com/ontologies/acm#B.6.1.6</seealso>
    let ``B.6.1.6`` = Prefixed_Name(acm, "B.6.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.2. Reliability and Testing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.2</seealso>
    let ``B.6.2`` = Prefixed_Name(acm, "B.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.2.0. Built-in tests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.0</seealso>
    let ``B.6.2.0`` = Prefixed_Name(acm, "B.6.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.2.1. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.1</seealso>
    let ``B.6.2.1`` = Prefixed_Name(acm, "B.6.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.2.2. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.2</seealso>
    let ``B.6.2.2`` = Prefixed_Name(acm, "B.6.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.2.3. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.3</seealso>
    let ``B.6.2.3`` = Prefixed_Name(acm, "B.6.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.6.2.4. Testability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.6.2.4</seealso>
    let ``B.6.2.4`` = Prefixed_Name(acm, "B.6.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3. Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.3</seealso>
    let ``B.6.3`` = Prefixed_Name(acm, "B.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3.0. Automatic synthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.0</seealso>
    let ``B.6.3.0`` = Prefixed_Name(acm, "B.6.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3.1. Hardware description languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.1</seealso>
    let ``B.6.3.1`` = Prefixed_Name(acm, "B.6.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3.2. Optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.2</seealso>
    let ``B.6.3.2`` = Prefixed_Name(acm, "B.6.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3.3. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.3</seealso>
    let ``B.6.3.3`` = Prefixed_Name(acm, "B.6.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3.4. Switching theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.4</seealso>
    let ``B.6.3.4`` = Prefixed_Name(acm, "B.6.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.3.5. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.5">http://acm.rkbexplorer.com/ontologies/acm#B.6.3.5</seealso>
    let ``B.6.3.5`` = Prefixed_Name(acm, "B.6.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.6.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.6.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.6.m">http://acm.rkbexplorer.com/ontologies/acm#B.6.m</seealso>
    let ``B.6.m`` = Prefixed_Name(acm, "B.6.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7. INTEGRATED CIRCUITS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7">http://acm.rkbexplorer.com/ontologies/acm#B.7</seealso>
    let ``B.7`` = Prefixed_Name(acm, "B.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.0</seealso>
    let ``B.7.0`` = Prefixed_Name(acm, "B.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1. Types and Design Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.1</seealso>
    let ``B.7.1`` = Prefixed_Name(acm, "B.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.0. Advanced technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.0</seealso>
    let ``B.7.1.0`` = Prefixed_Name(acm, "B.7.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.1. Algorithms implemented in hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.1</seealso>
    let ``B.7.1.1`` = Prefixed_Name(acm, "B.7.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.2. Gate arrays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.2</seealso>
    let ``B.7.1.2`` = Prefixed_Name(acm, "B.7.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.3. Input/output circuits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.3</seealso>
    let ``B.7.1.3`` = Prefixed_Name(acm, "B.7.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.4. Memory technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.4">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.4</seealso>
    let ``B.7.1.4`` = Prefixed_Name(acm, "B.7.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.5. Microprocessors and microcomputers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.5">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.5</seealso>
    let ``B.7.1.5`` = Prefixed_Name(acm, "B.7.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.1.6. Standard cells"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.6">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.6</seealso>
    let ``B.7.1.6`` = Prefixed_Name(acm, "B.7.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.1.7. VLSI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.7">http://acm.rkbexplorer.com/ontologies/acm#B.7.1.7</seealso>
    let ``B.7.1.7`` = Prefixed_Name(acm, "B.7.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.2. Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.2</seealso>
    let ``B.7.2`` = Prefixed_Name(acm, "B.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.2.0. Graphics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.0</seealso>
    let ``B.7.2.0`` = Prefixed_Name(acm, "B.7.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.2.1. Layout"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.1</seealso>
    let ``B.7.2.1`` = Prefixed_Name(acm, "B.7.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.2.2. Placement and routing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.2</seealso>
    let ``B.7.2.2`` = Prefixed_Name(acm, "B.7.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.2.3. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.3</seealso>
    let ``B.7.2.3`` = Prefixed_Name(acm, "B.7.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.2.4. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.4">http://acm.rkbexplorer.com/ontologies/acm#B.7.2.4</seealso>
    let ``B.7.2.4`` = Prefixed_Name(acm, "B.7.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #B.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.3. Reliability and Testing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.3</seealso>
    let ``B.7.3`` = Prefixed_Name(acm, "B.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.3.0. Built-in tests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.0">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.0</seealso>
    let ``B.7.3.0`` = Prefixed_Name(acm, "B.7.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.3.1. Error-checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.1">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.1</seealso>
    let ``B.7.3.1`` = Prefixed_Name(acm, "B.7.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.3.2. Redundant design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.2">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.2</seealso>
    let ``B.7.3.2`` = Prefixed_Name(acm, "B.7.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.3.3. Test generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.3">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.3</seealso>
    let ``B.7.3.3`` = Prefixed_Name(acm, "B.7.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.7.3.4. Testability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.4">http://acm.rkbexplorer.com/ontologies/acm#B.7.3.4</seealso>
    let ``B.7.3.4`` = Prefixed_Name(acm, "B.7.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.7.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.7.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.7.m">http://acm.rkbexplorer.com/ontologies/acm#B.7.m</seealso>
    let ``B.7.m`` = Prefixed_Name(acm, "B.7.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B.8. PERFORMANCE AND RELIABILITY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8">http://acm.rkbexplorer.com/ontologies/acm#B.8</seealso>
    let ``B.8`` = Prefixed_Name(acm, "B.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.8.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.0">http://acm.rkbexplorer.com/ontologies/acm#B.8.0</seealso>
    let ``B.8.0`` = Prefixed_Name(acm, "B.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.8.1. Reliability, Testing, and Fault-Tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.1">http://acm.rkbexplorer.com/ontologies/acm#B.8.1</seealso>
    let ``B.8.1`` = Prefixed_Name(acm, "B.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.8.2. Performance Analysis and Design Aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.2">http://acm.rkbexplorer.com/ontologies/acm#B.8.2</seealso>
    let ``B.8.2`` = Prefixed_Name(acm, "B.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.8.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.8.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.8.m">http://acm.rkbexplorer.com/ontologies/acm#B.8.m</seealso>
    let ``B.8.m`` = Prefixed_Name(acm, "B.8.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.m">http://acm.rkbexplorer.com/ontologies/acm#B.m</seealso>
    let ``B.m`` = Prefixed_Name(acm, "B.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:B.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B.m.0. Design management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#B.m.0">http://acm.rkbexplorer.com/ontologies/acm#B.m.0</seealso>
    let ``B.m.0`` = Prefixed_Name(acm, "B.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C. Computer Systems Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C">http://acm.rkbexplorer.com/ontologies/acm#C</seealso>
    let C = Prefixed_Name(acm, "C") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0">http://acm.rkbexplorer.com/ontologies/acm#C.0</seealso>
    let ``C.0`` = Prefixed_Name(acm, "C.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.0.0. Hardware/software interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.0">http://acm.rkbexplorer.com/ontologies/acm#C.0.0</seealso>
    let ``C.0.0`` = Prefixed_Name(acm, "C.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.0.1. Instruction set design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.1">http://acm.rkbexplorer.com/ontologies/acm#C.0.1</seealso>
    let ``C.0.1`` = Prefixed_Name(acm, "C.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.0.2. Modeling of computer architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.2">http://acm.rkbexplorer.com/ontologies/acm#C.0.2</seealso>
    let ``C.0.2`` = Prefixed_Name(acm, "C.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.0.3. System architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.3">http://acm.rkbexplorer.com/ontologies/acm#C.0.3</seealso>
    let ``C.0.3`` = Prefixed_Name(acm, "C.0.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.0.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.0.4. Systems specification methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.0.4">http://acm.rkbexplorer.com/ontologies/acm#C.0.4</seealso>
    let ``C.0.4`` = Prefixed_Name(acm, "C.0.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1. PROCESSOR ARCHITECTURES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1">http://acm.rkbexplorer.com/ontologies/acm#C.1</seealso>
    let ``C.1`` = Prefixed_Name(acm, "C.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.0</seealso>
    let ``C.1.0`` = Prefixed_Name(acm, "C.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.1. Single Data Stream Architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.1</seealso>
    let ``C.1.1`` = Prefixed_Name(acm, "C.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.1.0. Multiple-instruction-stream, single-data-stream processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.0</seealso>
    let ``C.1.1.0`` = Prefixed_Name(acm, "C.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.1.1. Pipeline processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.1</seealso>
    let ``C.1.1.1`` = Prefixed_Name(acm, "C.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.1.2. RISC/CISC, VLIW architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.2</seealso>
    let ``C.1.1.2`` = Prefixed_Name(acm, "C.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.1.3. Single-instruction-stream, single-data-stream processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.3</seealso>
    let ``C.1.1.3`` = Prefixed_Name(acm, "C.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.1.4. Von Neumann architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.1.4</seealso>
    let ``C.1.1.4`` = Prefixed_Name(acm, "C.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2. Multiple Data Stream Architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.2</seealso>
    let ``C.1.2`` = Prefixed_Name(acm, "C.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2.0. Array and vector processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.0</seealso>
    let ``C.1.2.0`` = Prefixed_Name(acm, "C.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2.1. Associative processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.1</seealso>
    let ``C.1.2.1`` = Prefixed_Name(acm, "C.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2.2. Connection machines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.2</seealso>
    let ``C.1.2.2`` = Prefixed_Name(acm, "C.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2.3. Interconnection architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.3</seealso>
    let ``C.1.2.3`` = Prefixed_Name(acm, "C.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2.4. Multiple-instruction-stream, multiple-data-stream processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.4</seealso>
    let ``C.1.2.4`` = Prefixed_Name(acm, "C.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.2.5. Parallel processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.5">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.5</seealso>
    let ``C.1.2.5`` = Prefixed_Name(acm, "C.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.2.6. Pipeline processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.6">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.6</seealso>
    let ``C.1.2.6`` = Prefixed_Name(acm, "C.1.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.2.7. Single-instruction-stream, multiple-data-stream processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.7">http://acm.rkbexplorer.com/ontologies/acm#C.1.2.7</seealso>
    let ``C.1.2.7`` = Prefixed_Name(acm, "C.1.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3. Other Architecture Styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.3</seealso>
    let ``C.1.3`` = Prefixed_Name(acm, "C.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.0. Adaptable architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.0</seealso>
    let ``C.1.3.0`` = Prefixed_Name(acm, "C.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.1. Analog computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.1</seealso>
    let ``C.1.3.1`` = Prefixed_Name(acm, "C.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.3.2. Capability architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.2</seealso>
    let ``C.1.3.2`` = Prefixed_Name(acm, "C.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.3. Cellular architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.3</seealso>
    let ``C.1.3.3`` = Prefixed_Name(acm, "C.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.4. Data-flow architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.4</seealso>
    let ``C.1.3.4`` = Prefixed_Name(acm, "C.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.5. Heterogeneous systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.5">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.5</seealso>
    let ``C.1.3.5`` = Prefixed_Name(acm, "C.1.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.3.6. High-level language architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.6">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.6</seealso>
    let ``C.1.3.6`` = Prefixed_Name(acm, "C.1.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.7. Neural nets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.7">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.7</seealso>
    let ``C.1.3.7`` = Prefixed_Name(acm, "C.1.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.3.8. Pipeline processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.8">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.8</seealso>
    let ``C.1.3.8`` = Prefixed_Name(acm, "C.1.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.3.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.3.9. Stack-oriented processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.9">http://acm.rkbexplorer.com/ontologies/acm#C.1.3.9</seealso>
    let ``C.1.3.9`` = Prefixed_Name(acm, "C.1.3.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.4. Parallel Architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4">http://acm.rkbexplorer.com/ontologies/acm#C.1.4</seealso>
    let ``C.1.4`` = Prefixed_Name(acm, "C.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.4.0. Distributed architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.4.0</seealso>
    let ``C.1.4.0`` = Prefixed_Name(acm, "C.1.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.4.1. Mobile processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.4.1</seealso>
    let ``C.1.4.1`` = Prefixed_Name(acm, "C.1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m">http://acm.rkbexplorer.com/ontologies/acm#C.1.m</seealso>
    let ``C.1.m`` = Prefixed_Name(acm, "C.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.m.0. Analog computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.0">http://acm.rkbexplorer.com/ontologies/acm#C.1.m.0</seealso>
    let ``C.1.m.0`` = Prefixed_Name(acm, "C.1.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.1.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.1.m.1. Hybrid systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.1">http://acm.rkbexplorer.com/ontologies/acm#C.1.m.1</seealso>
    let ``C.1.m.1`` = Prefixed_Name(acm, "C.1.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2. COMPUTER-COMMUNICATION NETWORKS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2">http://acm.rkbexplorer.com/ontologies/acm#C.2</seealso>
    let ``C.2`` = Prefixed_Name(acm, "C.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.0</seealso>
    let ``C.2.0`` = Prefixed_Name(acm, "C.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.0.0. Data communications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.0.0</seealso>
    let ``C.2.0.0`` = Prefixed_Name(acm, "C.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.0.1. Open Systems Interconnection reference model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.0.1</seealso>
    let ``C.2.0.1`` = Prefixed_Name(acm, "C.2.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.0.2. Security and protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.0.2</seealso>
    let ``C.2.0.2`` = Prefixed_Name(acm, "C.2.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1. Network Architecture and Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.1</seealso>
    let ``C.2.1`` = Prefixed_Name(acm, "C.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.0. Asynchronous Transfer Mode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.0</seealso>
    let ``C.2.1.0`` = Prefixed_Name(acm, "C.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.2.1.1. Centralized networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.1</seealso>
    let ``C.2.1.1`` = Prefixed_Name(acm, "C.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.10. Wireless communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.10">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.10</seealso>
    let ``C.2.1.10`` = Prefixed_Name(acm, "C.2.1.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.2. Circuit-switching networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.2</seealso>
    let ``C.2.1.2`` = Prefixed_Name(acm, "C.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.3. Distributed networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.3</seealso>
    let ``C.2.1.3`` = Prefixed_Name(acm, "C.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.4. Frame relay networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.4</seealso>
    let ``C.2.1.4`` = Prefixed_Name(acm, "C.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.5. ISDN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.5">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.5</seealso>
    let ``C.2.1.5`` = Prefixed_Name(acm, "C.2.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.6. Network communications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.6">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.6</seealso>
    let ``C.2.1.6`` = Prefixed_Name(acm, "C.2.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.7. Network topology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.7">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.7</seealso>
    let ``C.2.1.7`` = Prefixed_Name(acm, "C.2.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.8. Packet-switching networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.8">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.8</seealso>
    let ``C.2.1.8`` = Prefixed_Name(acm, "C.2.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.1.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.1.9. Store and forward networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.9">http://acm.rkbexplorer.com/ontologies/acm#C.2.1.9</seealso>
    let ``C.2.1.9`` = Prefixed_Name(acm, "C.2.1.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.2. Network Protocols"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.2</seealso>
    let ``C.2.2`` = Prefixed_Name(acm, "C.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.2.0. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.0</seealso>
    let ``C.2.2.0`` = Prefixed_Name(acm, "C.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.2.1. Protocol architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.1</seealso>
    let ``C.2.2.1`` = Prefixed_Name(acm, "C.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.2.2. Protocol verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.2</seealso>
    let ``C.2.2.2`` = Prefixed_Name(acm, "C.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.2.3. Routing protocols"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.2.3</seealso>
    let ``C.2.2.3`` = Prefixed_Name(acm, "C.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.3. Network Operations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.3</seealso>
    let ``C.2.3`` = Prefixed_Name(acm, "C.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.3.0. Network management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.3.0</seealso>
    let ``C.2.3.0`` = Prefixed_Name(acm, "C.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.3.1. Network monitoring"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.3.1</seealso>
    let ``C.2.3.1`` = Prefixed_Name(acm, "C.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.3.2. Public networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.3.2</seealso>
    let ``C.2.3.2`` = Prefixed_Name(acm, "C.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.4. Distributed Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4">http://acm.rkbexplorer.com/ontologies/acm#C.2.4</seealso>
    let ``C.2.4`` = Prefixed_Name(acm, "C.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.4.0. Client/server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.0</seealso>
    let ``C.2.4.0`` = Prefixed_Name(acm, "C.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.4.1. Distributed applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.1</seealso>
    let ``C.2.4.1`` = Prefixed_Name(acm, "C.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.4.2. Distributed databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.2</seealso>
    let ``C.2.4.2`` = Prefixed_Name(acm, "C.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.4.3. Network operating systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.4.3</seealso>
    let ``C.2.4.3`` = Prefixed_Name(acm, "C.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5. Local and Wide-Area Networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5">http://acm.rkbexplorer.com/ontologies/acm#C.2.5</seealso>
    let ``C.2.5`` = Prefixed_Name(acm, "C.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5.0. Access schemes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.0</seealso>
    let ``C.2.5.0`` = Prefixed_Name(acm, "C.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5.1. Buses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.1</seealso>
    let ``C.2.5.1`` = Prefixed_Name(acm, "C.2.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5.2. Ethernet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.2">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.2</seealso>
    let ``C.2.5.2`` = Prefixed_Name(acm, "C.2.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5.3. High-speed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.3">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.3</seealso>
    let ``C.2.5.3`` = Prefixed_Name(acm, "C.2.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5.4. Internet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.4">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.4</seealso>
    let ``C.2.5.4`` = Prefixed_Name(acm, "C.2.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.5.5. Token rings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.5">http://acm.rkbexplorer.com/ontologies/acm#C.2.5.5</seealso>
    let ``C.2.5.5`` = Prefixed_Name(acm, "C.2.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.2.6. Internetworking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6">http://acm.rkbexplorer.com/ontologies/acm#C.2.6</seealso>
    let ``C.2.6`` = Prefixed_Name(acm, "C.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.6.0. Routers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.0">http://acm.rkbexplorer.com/ontologies/acm#C.2.6.0</seealso>
    let ``C.2.6.0`` = Prefixed_Name(acm, "C.2.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.6.1. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.1">http://acm.rkbexplorer.com/ontologies/acm#C.2.6.1</seealso>
    let ``C.2.6.1`` = Prefixed_Name(acm, "C.2.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.2.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.2.m">http://acm.rkbexplorer.com/ontologies/acm#C.2.m</seealso>
    let ``C.2.m`` = Prefixed_Name(acm, "C.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #J.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.3. SPECIAL-PURPOSE AND APPLICATION-BASED SYSTEMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3">http://acm.rkbexplorer.com/ontologies/acm#C.3</seealso>
    let ``C.3`` = Prefixed_Name(acm, "C.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.3.0. Microprocessor/microcomputer applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.3.0</seealso>
    let ``C.3.0`` = Prefixed_Name(acm, "C.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.3.1. Process control systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.3.1</seealso>
    let ``C.3.1`` = Prefixed_Name(acm, "C.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.3.2. Real-time and embedded systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.3.2</seealso>
    let ``C.3.2`` = Prefixed_Name(acm, "C.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.3.3. Signal processing systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.3">http://acm.rkbexplorer.com/ontologies/acm#C.3.3</seealso>
    let ``C.3.3`` = Prefixed_Name(acm, "C.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.3.4. Smartcards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.3.4">http://acm.rkbexplorer.com/ontologies/acm#C.3.4</seealso>
    let ``C.3.4`` = Prefixed_Name(acm, "C.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4. PERFORMANCE OF SYSTEMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4">http://acm.rkbexplorer.com/ontologies/acm#C.4</seealso>
    let ``C.4`` = Prefixed_Name(acm, "C.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4.0. Design studies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.0">http://acm.rkbexplorer.com/ontologies/acm#C.4.0</seealso>
    let ``C.4.0`` = Prefixed_Name(acm, "C.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4.1. Fault tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.1">http://acm.rkbexplorer.com/ontologies/acm#C.4.1</seealso>
    let ``C.4.1`` = Prefixed_Name(acm, "C.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4.2. Measurement techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.2">http://acm.rkbexplorer.com/ontologies/acm#C.4.2</seealso>
    let ``C.4.2`` = Prefixed_Name(acm, "C.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4.3. Modeling techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.3">http://acm.rkbexplorer.com/ontologies/acm#C.4.3</seealso>
    let ``C.4.3`` = Prefixed_Name(acm, "C.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4.4. Performance attributes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.4">http://acm.rkbexplorer.com/ontologies/acm#C.4.4</seealso>
    let ``C.4.4`` = Prefixed_Name(acm, "C.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.4.5. Reliability, availability, and serviceability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.4.5">http://acm.rkbexplorer.com/ontologies/acm#C.4.5</seealso>
    let ``C.4.5`` = Prefixed_Name(acm, "C.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5. COMPUTER SYSTEM IMPLEMENTATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5">http://acm.rkbexplorer.com/ontologies/acm#C.5</seealso>
    let ``C.5`` = Prefixed_Name(acm, "C.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.0">http://acm.rkbexplorer.com/ontologies/acm#C.5.0</seealso>
    let ``C.5.0`` = Prefixed_Name(acm, "C.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.1. Large and Medium Computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1">http://acm.rkbexplorer.com/ontologies/acm#C.5.1</seealso>
    let ``C.5.1`` = Prefixed_Name(acm, "C.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.1.0. Super computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#C.5.1.0</seealso>
    let ``C.5.1.0`` = Prefixed_Name(acm, "C.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C.5.2. Minicomputers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.2">http://acm.rkbexplorer.com/ontologies/acm#C.5.2</seealso>
    let ``C.5.2`` = Prefixed_Name(acm, "C.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.3. Microcomputers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3">http://acm.rkbexplorer.com/ontologies/acm#C.5.3</seealso>
    let ``C.5.3`` = Prefixed_Name(acm, "C.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.3.0. Microprocessors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.0</seealso>
    let ``C.5.3.0`` = Prefixed_Name(acm, "C.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.3.1. Personal computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.1</seealso>
    let ``C.5.3.1`` = Prefixed_Name(acm, "C.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.3.2. Portable devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.2">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.2</seealso>
    let ``C.5.3.2`` = Prefixed_Name(acm, "C.5.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.3.3. Workstations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.3">http://acm.rkbexplorer.com/ontologies/acm#C.5.3.3</seealso>
    let ``C.5.3.3`` = Prefixed_Name(acm, "C.5.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.4. VLSI Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.4">http://acm.rkbexplorer.com/ontologies/acm#C.5.4</seealso>
    let ``C.5.4`` = Prefixed_Name(acm, "C.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.5. Servers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.5">http://acm.rkbexplorer.com/ontologies/acm#C.5.5</seealso>
    let ``C.5.5`` = Prefixed_Name(acm, "C.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.5.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.5.m">http://acm.rkbexplorer.com/ontologies/acm#C.5.m</seealso>
    let ``C.5.m`` = Prefixed_Name(acm, "C.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:C.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"C.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#C.m">http://acm.rkbexplorer.com/ontologies/acm#C.m</seealso>
    let ``C.m`` = Prefixed_Name(acm, "C.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D. Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D">http://acm.rkbexplorer.com/ontologies/acm#D</seealso>
    let D = Prefixed_Name(acm, "D") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.0">http://acm.rkbexplorer.com/ontologies/acm#D.0</seealso>
    let ``D.0`` = Prefixed_Name(acm, "D.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.1. PROGRAMMING TECHNIQUES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1">http://acm.rkbexplorer.com/ontologies/acm#D.1</seealso>
    let ``D.1`` = Prefixed_Name(acm, "D.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.1.0</seealso>
    let ``D.1.0`` = Prefixed_Name(acm, "D.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.1. Applicative Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.1.1</seealso>
    let ``D.1.1`` = Prefixed_Name(acm, "D.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #I.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.1.2. Automatic Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2">http://acm.rkbexplorer.com/ontologies/acm#D.1.2</seealso>
    let ``D.1.2`` = Prefixed_Name(acm, "D.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.2.0. Distributed programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.1.2.0</seealso>
    let ``D.1.2.0`` = Prefixed_Name(acm, "D.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.2.1. Parallel programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.1.2.1</seealso>
    let ``D.1.2.1`` = Prefixed_Name(acm, "D.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.4. Sequential Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.4">http://acm.rkbexplorer.com/ontologies/acm#D.1.4</seealso>
    let ``D.1.4`` = Prefixed_Name(acm, "D.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.5. Object-oriented Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.5">http://acm.rkbexplorer.com/ontologies/acm#D.1.5</seealso>
    let ``D.1.5`` = Prefixed_Name(acm, "D.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.6. Logic Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.6">http://acm.rkbexplorer.com/ontologies/acm#D.1.6</seealso>
    let ``D.1.6`` = Prefixed_Name(acm, "D.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.7. Visual Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.7">http://acm.rkbexplorer.com/ontologies/acm#D.1.7</seealso>
    let ``D.1.7`` = Prefixed_Name(acm, "D.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.1.m">http://acm.rkbexplorer.com/ontologies/acm#D.1.m</seealso>
    let ``D.1.m`` = Prefixed_Name(acm, "D.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #K.6.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2. SOFTWARE ENGINEERING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2">http://acm.rkbexplorer.com/ontologies/acm#D.2</seealso>
    let ``D.2`` = Prefixed_Name(acm, "D.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #K.5.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.0</seealso>
    let ``D.2.0`` = Prefixed_Name(acm, "D.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.0.0. Protection mechanisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.0.0</seealso>
    let ``D.2.0.0`` = Prefixed_Name(acm, "D.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.0.1. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.0.1</seealso>
    let ``D.2.0.1`` = Prefixed_Name(acm, "D.2.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.1. Requirements/Specifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.1</seealso>
    let ``D.2.1`` = Prefixed_Name(acm, "D.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.1.0. Elicitation methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.0</seealso>
    let ``D.2.1.0`` = Prefixed_Name(acm, "D.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.1.1. Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.1</seealso>
    let ``D.2.1.1`` = Prefixed_Name(acm, "D.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.1.2. Methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.2</seealso>
    let ``D.2.1.2`` = Prefixed_Name(acm, "D.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.1.3. Tools"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.1.3</seealso>
    let ``D.2.1.3`` = Prefixed_Name(acm, "D.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998. See also #D.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.10. Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10">http://acm.rkbexplorer.com/ontologies/acm#D.2.10</seealso>
    let ``D.2.10`` = Prefixed_Name(acm, "D.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.10.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.10.0. Methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.10.0</seealso>
    let ``D.2.10.0`` = Prefixed_Name(acm, "D.2.10.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.10.1. Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.10.1</seealso>
    let ``D.2.10.1`` = Prefixed_Name(acm, "D.2.10.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.11. Software Architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11">http://acm.rkbexplorer.com/ontologies/acm#D.2.11</seealso>
    let ``D.2.11`` = Prefixed_Name(acm, "D.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.11.0. Data abstraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.0</seealso>
    let ``D.2.11.0`` = Prefixed_Name(acm, "D.2.11.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.11.1. Domain-specific architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.1</seealso>
    let ``D.2.11.1`` = Prefixed_Name(acm, "D.2.11.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.11.2. Information hiding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.2</seealso>
    let ``D.2.11.2`` = Prefixed_Name(acm, "D.2.11.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.11.3. Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.3</seealso>
    let ``D.2.11.3`` = Prefixed_Name(acm, "D.2.11.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.11.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.11.4. Patterns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.11.4</seealso>
    let ``D.2.11.4`` = Prefixed_Name(acm, "D.2.11.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.12. Interoperability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12">http://acm.rkbexplorer.com/ontologies/acm#D.2.12</seealso>
    let ``D.2.12`` = Prefixed_Name(acm, "D.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.12.0. Data mapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.12.0</seealso>
    let ``D.2.12.0`` = Prefixed_Name(acm, "D.2.12.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.12.1. Distributed objects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.12.1</seealso>
    let ``D.2.12.1`` = Prefixed_Name(acm, "D.2.12.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.12.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.12.2. Interface definition languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.12.2</seealso>
    let ``D.2.12.2`` = Prefixed_Name(acm, "D.2.12.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.13. Reusable Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13">http://acm.rkbexplorer.com/ontologies/acm#D.2.13</seealso>
    let ``D.2.13`` = Prefixed_Name(acm, "D.2.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.13.0. Domain engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.13.0</seealso>
    let ``D.2.13.0`` = Prefixed_Name(acm, "D.2.13.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.13.1. Reusable libraries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.13.1</seealso>
    let ``D.2.13.1`` = Prefixed_Name(acm, "D.2.13.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.13.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.13.2. Reuse models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.13.2</seealso>
    let ``D.2.13.2`` = Prefixed_Name(acm, "D.2.13.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2. Design Tools and Techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.2</seealso>
    let ``D.2.2`` = Prefixed_Name(acm, "D.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.0. Computer-aided software engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.0</seealso>
    let ``D.2.2.0`` = Prefixed_Name(acm, "D.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.1. Decision tables"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.1</seealso>
    let ``D.2.2.1`` = Prefixed_Name(acm, "D.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.2.10. Structured programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.10">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.10</seealso>
    let ``D.2.2.10`` = Prefixed_Name(acm, "D.2.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.2.11. Top-down programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.11">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.11</seealso>
    let ``D.2.2.11`` = Prefixed_Name(acm, "D.2.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.12. User interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.12">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.12</seealso>
    let ``D.2.2.12`` = Prefixed_Name(acm, "D.2.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.2. Evolutionary prototyping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.2</seealso>
    let ``D.2.2.2`` = Prefixed_Name(acm, "D.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.3. Flow charts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.3</seealso>
    let ``D.2.2.3`` = Prefixed_Name(acm, "D.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.4. Modules and interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.4</seealso>
    let ``D.2.2.4`` = Prefixed_Name(acm, "D.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.5. Object-oriented design methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.5</seealso>
    let ``D.2.2.5`` = Prefixed_Name(acm, "D.2.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.6. Petri nets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.6</seealso>
    let ``D.2.2.6`` = Prefixed_Name(acm, "D.2.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.2.7. Programmer workbench"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.7</seealso>
    let ``D.2.2.7`` = Prefixed_Name(acm, "D.2.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.8. Software libraries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.8</seealso>
    let ``D.2.2.8`` = Prefixed_Name(acm, "D.2.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.2.9. State diagrams"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.9">http://acm.rkbexplorer.com/ontologies/acm#D.2.2.9</seealso>
    let ``D.2.2.9`` = Prefixed_Name(acm, "D.2.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3. Coding Tools and Techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.3</seealso>
    let ``D.2.3`` = Prefixed_Name(acm, "D.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3.0. Object-oriented programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.0</seealso>
    let ``D.2.3.0`` = Prefixed_Name(acm, "D.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3.1. Pretty printers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.1</seealso>
    let ``D.2.3.1`` = Prefixed_Name(acm, "D.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3.2. Program editors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.2</seealso>
    let ``D.2.3.2`` = Prefixed_Name(acm, "D.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.3.3. Reentrant code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.3</seealso>
    let ``D.2.3.3`` = Prefixed_Name(acm, "D.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3.4. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.4</seealso>
    let ``D.2.3.4`` = Prefixed_Name(acm, "D.2.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3.5. Structured programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.5</seealso>
    let ``D.2.3.5`` = Prefixed_Name(acm, "D.2.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.3.6. Top-down programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.3.6</seealso>
    let ``D.2.3.6`` = Prefixed_Name(acm, "D.2.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.4. Software/Program Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.4</seealso>
    let ``D.2.4`` = Prefixed_Name(acm, "D.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.0. Assertion checkers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.0</seealso>
    let ``D.2.4.0`` = Prefixed_Name(acm, "D.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.1. Class invariants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.1</seealso>
    let ``D.2.4.1`` = Prefixed_Name(acm, "D.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.2. Correctness proofs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.2</seealso>
    let ``D.2.4.2`` = Prefixed_Name(acm, "D.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.3. Formal methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.3</seealso>
    let ``D.2.4.3`` = Prefixed_Name(acm, "D.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.4. Model checking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.4</seealso>
    let ``D.2.4.4`` = Prefixed_Name(acm, "D.2.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.5. Programming by contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.5</seealso>
    let ``D.2.4.5`` = Prefixed_Name(acm, "D.2.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.6. Reliability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.6</seealso>
    let ``D.2.4.6`` = Prefixed_Name(acm, "D.2.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.7. Statistical methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.7</seealso>
    let ``D.2.4.7`` = Prefixed_Name(acm, "D.2.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.4.8. Validation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.4.8</seealso>
    let ``D.2.4.8`` = Prefixed_Name(acm, "D.2.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5. Testing and Debugging"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.5</seealso>
    let ``D.2.5`` = Prefixed_Name(acm, "D.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.0. Code inspections and walk-throughs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.0</seealso>
    let ``D.2.5.0`` = Prefixed_Name(acm, "D.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.1. Debugging aids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.1</seealso>
    let ``D.2.5.1`` = Prefixed_Name(acm, "D.2.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.2. Diagnostics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.2</seealso>
    let ``D.2.5.2`` = Prefixed_Name(acm, "D.2.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.3. Distributed debugging"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.3</seealso>
    let ``D.2.5.3`` = Prefixed_Name(acm, "D.2.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.5.4. Dumps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.4</seealso>
    let ``D.2.5.4`` = Prefixed_Name(acm, "D.2.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.5. Error handling and recovery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.5</seealso>
    let ``D.2.5.5`` = Prefixed_Name(acm, "D.2.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.6. Monitors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.6</seealso>
    let ``D.2.5.6`` = Prefixed_Name(acm, "D.2.5.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.7. Symbolic execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.7</seealso>
    let ``D.2.5.7`` = Prefixed_Name(acm, "D.2.5.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.8. Testing tools"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.8</seealso>
    let ``D.2.5.8`` = Prefixed_Name(acm, "D.2.5.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.5.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.5.9. Tracing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.9">http://acm.rkbexplorer.com/ontologies/acm#D.2.5.9</seealso>
    let ``D.2.5.9`` = Prefixed_Name(acm, "D.2.5.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.6. Programming Environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.6</seealso>
    let ``D.2.6`` = Prefixed_Name(acm, "D.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.6.0. Graphical environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.0</seealso>
    let ``D.2.6.0`` = Prefixed_Name(acm, "D.2.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.6.1. Integrated environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.1</seealso>
    let ``D.2.6.1`` = Prefixed_Name(acm, "D.2.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.6.2. Interactive environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.2</seealso>
    let ``D.2.6.2`` = Prefixed_Name(acm, "D.2.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.6.3. Programmer workbench"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.6.3</seealso>
    let ``D.2.6.3`` = Prefixed_Name(acm, "D.2.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.7. Distribution, Maintenance, and Enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.7</seealso>
    let ``D.2.7`` = Prefixed_Name(acm, "D.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.7.0. Corrections"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.0</seealso>
    let ``D.2.7.0`` = Prefixed_Name(acm, "D.2.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.7.1. Documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.1</seealso>
    let ``D.2.7.1`` = Prefixed_Name(acm, "D.2.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.7.2. Enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.2</seealso>
    let ``D.2.7.2`` = Prefixed_Name(acm, "D.2.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.7.3. Extensibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.3</seealso>
    let ``D.2.7.3`` = Prefixed_Name(acm, "D.2.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.7.4. Portability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.4</seealso>
    let ``D.2.7.4`` = Prefixed_Name(acm, "D.2.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.7.5. Restructuring, reverse engineering, and reengineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.5</seealso>
    let ``D.2.7.5`` = Prefixed_Name(acm, "D.2.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.7.6. Version control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.7.6</seealso>
    let ``D.2.7.6`` = Prefixed_Name(acm, "D.2.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.4.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.8. Metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.8</seealso>
    let ``D.2.8`` = Prefixed_Name(acm, "D.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.8.0. Complexity measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.0</seealso>
    let ``D.2.8.0`` = Prefixed_Name(acm, "D.2.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.8.1. Performance measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.1</seealso>
    let ``D.2.8.1`` = Prefixed_Name(acm, "D.2.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.8.2. Process metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.2</seealso>
    let ``D.2.8.2`` = Prefixed_Name(acm, "D.2.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.8.3. Product metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.3</seealso>
    let ``D.2.8.3`` = Prefixed_Name(acm, "D.2.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.8.4. Software science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.8.4</seealso>
    let ``D.2.8.4`` = Prefixed_Name(acm, "D.2.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #K.6.3, #K.6.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.9. Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9">http://acm.rkbexplorer.com/ontologies/acm#D.2.9</seealso>
    let ``D.2.9`` = Prefixed_Name(acm, "D.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.9.0. Copyrights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.0</seealso>
    let ``D.2.9.0`` = Prefixed_Name(acm, "D.2.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.1. Cost estimation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.1</seealso>
    let ``D.2.9.1`` = Prefixed_Name(acm, "D.2.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.2. Life cycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.2">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.2</seealso>
    let ``D.2.9.2`` = Prefixed_Name(acm, "D.2.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.3. Productivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.3">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.3</seealso>
    let ``D.2.9.3`` = Prefixed_Name(acm, "D.2.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.4. Programming teams"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.4">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.4</seealso>
    let ``D.2.9.4`` = Prefixed_Name(acm, "D.2.9.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.5. Software configuration management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.5">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.5</seealso>
    let ``D.2.9.5`` = Prefixed_Name(acm, "D.2.9.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.6. Software process models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.6">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.6</seealso>
    let ``D.2.9.6`` = Prefixed_Name(acm, "D.2.9.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.7. Software quality assurance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.7">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.7</seealso>
    let ``D.2.9.7`` = Prefixed_Name(acm, "D.2.9.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.9.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.9.8. Time estimation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.8">http://acm.rkbexplorer.com/ontologies/acm#D.2.9.8</seealso>
    let ``D.2.9.8`` = Prefixed_Name(acm, "D.2.9.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.2.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m">http://acm.rkbexplorer.com/ontologies/acm#D.2.m</seealso>
    let ``D.2.m`` = Prefixed_Name(acm, "D.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.m.0. Rapid prototyping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.0">http://acm.rkbexplorer.com/ontologies/acm#D.2.m.0</seealso>
    let ``D.2.m.0`` = Prefixed_Name(acm, "D.2.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.2.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.2.m.1. Reusable software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.1">http://acm.rkbexplorer.com/ontologies/acm#D.2.m.1</seealso>
    let ``D.2.m.1`` = Prefixed_Name(acm, "D.2.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3. PROGRAMMING LANGUAGES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3">http://acm.rkbexplorer.com/ontologies/acm#D.3</seealso>
    let ``D.3`` = Prefixed_Name(acm, "D.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.0</seealso>
    let ``D.3.0`` = Prefixed_Name(acm, "D.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.0.0. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.0.0</seealso>
    let ``D.3.0.0`` = Prefixed_Name(acm, "D.3.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.2.1, #F.3.1, #F.3.2, #F.4.2, #F.4.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.3.1. Formal Definitions and Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.1</seealso>
    let ``D.3.1`` = Prefixed_Name(acm, "D.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.1.0. Semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.1.0</seealso>
    let ``D.3.1.0`` = Prefixed_Name(acm, "D.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.1.1. Syntax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.1.1</seealso>
    let ``D.3.1.1`` = Prefixed_Name(acm, "D.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2. Language Classifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.2</seealso>
    let ``D.3.2`` = Prefixed_Name(acm, "D.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.0. Applicative languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.0</seealso>
    let ``D.3.2.0`` = Prefixed_Name(acm, "D.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.1. Concurrent, distributed, and parallel languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.1</seealso>
    let ``D.3.2.1`` = Prefixed_Name(acm, "D.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.3.2.10. Nonprocedural languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.10">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.10</seealso>
    let ``D.3.2.10`` = Prefixed_Name(acm, "D.3.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.11. Object-oriented languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.11">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.11</seealso>
    let ``D.3.2.11`` = Prefixed_Name(acm, "D.3.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.12. Specialized application languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.12">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.12</seealso>
    let ``D.3.2.12`` = Prefixed_Name(acm, "D.3.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.13. Very high-level languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.13">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.13</seealso>
    let ``D.3.2.13`` = Prefixed_Name(acm, "D.3.2.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.2. Constraint and logic languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.2</seealso>
    let ``D.3.2.2`` = Prefixed_Name(acm, "D.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.3. Data-flow languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.3</seealso>
    let ``D.3.2.3`` = Prefixed_Name(acm, "D.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.4. Design languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.4</seealso>
    let ``D.3.2.4`` = Prefixed_Name(acm, "D.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.5. Extensible languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.5</seealso>
    let ``D.3.2.5`` = Prefixed_Name(acm, "D.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.6. Macro and assembly languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.6</seealso>
    let ``D.3.2.6`` = Prefixed_Name(acm, "D.3.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.3.2.7. Microprogramming languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.7</seealso>
    let ``D.3.2.7`` = Prefixed_Name(acm, "D.3.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.2.8. Multiparadigm languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.8</seealso>
    let ``D.3.2.8`` = Prefixed_Name(acm, "D.3.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.3.2.9. Nondeterministic languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.9">http://acm.rkbexplorer.com/ontologies/acm#D.3.2.9</seealso>
    let ``D.3.2.9`` = Prefixed_Name(acm, "D.3.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.3.3. Language Constructs and Features"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.3</seealso>
    let ``D.3.3`` = Prefixed_Name(acm, "D.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.0. Abstract data types"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.0</seealso>
    let ``D.3.3.0`` = Prefixed_Name(acm, "D.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.1. Classes and objects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.1</seealso>
    let ``D.3.3.1`` = Prefixed_Name(acm, "D.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.10. Input/output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.10">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.10</seealso>
    let ``D.3.3.10`` = Prefixed_Name(acm, "D.3.3.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.11. Modules, packages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.11">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.11</seealso>
    let ``D.3.3.11`` = Prefixed_Name(acm, "D.3.3.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.12. Patterns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.12">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.12</seealso>
    let ``D.3.3.12`` = Prefixed_Name(acm, "D.3.3.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.13. Polymorphism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.13">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.13</seealso>
    let ``D.3.3.13`` = Prefixed_Name(acm, "D.3.3.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.14. Procedures, functions, and subroutines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.14">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.14</seealso>
    let ``D.3.3.14`` = Prefixed_Name(acm, "D.3.3.14") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.15. Recursion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.15">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.15</seealso>
    let ``D.3.3.15`` = Prefixed_Name(acm, "D.3.3.15") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.2. Concurrent programming structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.2</seealso>
    let ``D.3.3.2`` = Prefixed_Name(acm, "D.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.3. Constraints"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.3</seealso>
    let ``D.3.3.3`` = Prefixed_Name(acm, "D.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.4. Control structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.4</seealso>
    let ``D.3.3.4`` = Prefixed_Name(acm, "D.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.5. Coroutines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.5">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.5</seealso>
    let ``D.3.3.5`` = Prefixed_Name(acm, "D.3.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.6. Data types and structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.6">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.6</seealso>
    let ``D.3.3.6`` = Prefixed_Name(acm, "D.3.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.7. Dynamic storage management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.7">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.7</seealso>
    let ``D.3.3.7`` = Prefixed_Name(acm, "D.3.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.8. Frameworks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.8">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.8</seealso>
    let ``D.3.3.8`` = Prefixed_Name(acm, "D.3.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.3.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.3.9. Inheritance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.9">http://acm.rkbexplorer.com/ontologies/acm#D.3.3.9</seealso>
    let ``D.3.3.9`` = Prefixed_Name(acm, "D.3.3.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4. Processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.4</seealso>
    let ``D.3.4`` = Prefixed_Name(acm, "D.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.0. Code generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.0</seealso>
    let ``D.3.4.0`` = Prefixed_Name(acm, "D.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.1. Compilers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.1</seealso>
    let ``D.3.4.1`` = Prefixed_Name(acm, "D.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.10. Run-time environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.10">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.10</seealso>
    let ``D.3.4.10`` = Prefixed_Name(acm, "D.3.4.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.11. Translator writing systems and compiler generators"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.11">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.11</seealso>
    let ``D.3.4.11`` = Prefixed_Name(acm, "D.3.4.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.2. Debuggers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.2</seealso>
    let ``D.3.4.2`` = Prefixed_Name(acm, "D.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.3. Incremental compilers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.3</seealso>
    let ``D.3.4.3`` = Prefixed_Name(acm, "D.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.4. Interpreters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.4</seealso>
    let ``D.3.4.4`` = Prefixed_Name(acm, "D.3.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.5. Memory management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.5">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.5</seealso>
    let ``D.3.4.5`` = Prefixed_Name(acm, "D.3.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.6. Optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.6">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.6</seealso>
    let ``D.3.4.6`` = Prefixed_Name(acm, "D.3.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.7. Parsing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.7">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.7</seealso>
    let ``D.3.4.7`` = Prefixed_Name(acm, "D.3.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.8. Preprocessors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.8">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.8</seealso>
    let ``D.3.4.8`` = Prefixed_Name(acm, "D.3.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.4.9. Retargetable compilers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.9">http://acm.rkbexplorer.com/ontologies/acm#D.3.4.9</seealso>
    let ``D.3.4.9`` = Prefixed_Name(acm, "D.3.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.3.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.3.m">http://acm.rkbexplorer.com/ontologies/acm#D.3.m</seealso>
    let ``D.3.m`` = Prefixed_Name(acm, "D.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4. OPERATING SYSTEMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4">http://acm.rkbexplorer.com/ontologies/acm#D.4</seealso>
    let ``D.4`` = Prefixed_Name(acm, "D.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.0</seealso>
    let ``D.4.0`` = Prefixed_Name(acm, "D.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1. Process Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.1</seealso>
    let ``D.4.1`` = Prefixed_Name(acm, "D.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.0. Concurrency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.0</seealso>
    let ``D.4.1.0`` = Prefixed_Name(acm, "D.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.1. Deadlocks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.1</seealso>
    let ``D.4.1.1`` = Prefixed_Name(acm, "D.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.2. Multiprocessing/multiprogramming/multitasking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.2</seealso>
    let ``D.4.1.2`` = Prefixed_Name(acm, "D.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.3. Mutual exclusion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.3</seealso>
    let ``D.4.1.3`` = Prefixed_Name(acm, "D.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.4. Scheduling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.4</seealso>
    let ``D.4.1.4`` = Prefixed_Name(acm, "D.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.5. Synchronization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.5</seealso>
    let ``D.4.1.5`` = Prefixed_Name(acm, "D.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.1.6. Threads"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.1.6</seealso>
    let ``D.4.1.6`` = Prefixed_Name(acm, "D.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2. Storage Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.2</seealso>
    let ``D.4.2`` = Prefixed_Name(acm, "D.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.0. Allocation/deallocation strategies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.0</seealso>
    let ``D.4.2.0`` = Prefixed_Name(acm, "D.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.1. Distributed memories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.1</seealso>
    let ``D.4.2.1`` = Prefixed_Name(acm, "D.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.2. Garbage collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.2</seealso>
    let ``D.4.2.2`` = Prefixed_Name(acm, "D.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.3. Main memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.3</seealso>
    let ``D.4.2.3`` = Prefixed_Name(acm, "D.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.4. Secondary storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.4</seealso>
    let ``D.4.2.4`` = Prefixed_Name(acm, "D.4.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.2.5. Segmentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.5</seealso>
    let ``D.4.2.5`` = Prefixed_Name(acm, "D.4.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.6. Storage hierarchies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.6</seealso>
    let ``D.4.2.6`` = Prefixed_Name(acm, "D.4.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.2.7. Swapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.7">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.7</seealso>
    let ``D.4.2.7`` = Prefixed_Name(acm, "D.4.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.2.8. Virtual memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.8">http://acm.rkbexplorer.com/ontologies/acm#D.4.2.8</seealso>
    let ``D.4.2.8`` = Prefixed_Name(acm, "D.4.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.3. File Systems Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.3</seealso>
    let ``D.4.3`` = Prefixed_Name(acm, "D.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.3.0. Access methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.0</seealso>
    let ``D.4.3.0`` = Prefixed_Name(acm, "D.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.3.1. Directory structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.1</seealso>
    let ``D.4.3.1`` = Prefixed_Name(acm, "D.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.3.2. Distributed file systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.2</seealso>
    let ``D.4.3.2`` = Prefixed_Name(acm, "D.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.3.3. File organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.3</seealso>
    let ``D.4.3.3`` = Prefixed_Name(acm, "D.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.3.4. Maintenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.3.4</seealso>
    let ``D.4.3.4`` = Prefixed_Name(acm, "D.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.4. Communications Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.4</seealso>
    let ``D.4.4`` = Prefixed_Name(acm, "D.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.4.0. Buffering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.0</seealso>
    let ``D.4.4.0`` = Prefixed_Name(acm, "D.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.4.1. Input/output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.1</seealso>
    let ``D.4.4.1`` = Prefixed_Name(acm, "D.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.4.2. Message sending"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.2</seealso>
    let ``D.4.4.2`` = Prefixed_Name(acm, "D.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.4.3. Network communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.3</seealso>
    let ``D.4.4.3`` = Prefixed_Name(acm, "D.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.4.4. Terminal management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.4.4</seealso>
    let ``D.4.4.4`` = Prefixed_Name(acm, "D.4.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.5. Reliability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.5</seealso>
    let ``D.4.5`` = Prefixed_Name(acm, "D.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.5.0. Backup procedures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.0</seealso>
    let ``D.4.5.0`` = Prefixed_Name(acm, "D.4.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.5.1. Checkpoint/restart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.1</seealso>
    let ``D.4.5.1`` = Prefixed_Name(acm, "D.4.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.5.2. Fault-tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.2</seealso>
    let ``D.4.5.2`` = Prefixed_Name(acm, "D.4.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.5.3. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.5.3</seealso>
    let ``D.4.5.3`` = Prefixed_Name(acm, "D.4.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #K.6.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.6. Security and Protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.6</seealso>
    let ``D.4.6`` = Prefixed_Name(acm, "D.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.6.0. Access controls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.0</seealso>
    let ``D.4.6.0`` = Prefixed_Name(acm, "D.4.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.6.1. Authentication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.1</seealso>
    let ``D.4.6.1`` = Prefixed_Name(acm, "D.4.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.6.2. Cryptographic controls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.2</seealso>
    let ``D.4.6.2`` = Prefixed_Name(acm, "D.4.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.6.3. Information flow controls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.3</seealso>
    let ``D.4.6.3`` = Prefixed_Name(acm, "D.4.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.6.4. Invasive software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.4</seealso>
    let ``D.4.6.4`` = Prefixed_Name(acm, "D.4.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.6.5. Security kernels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.5</seealso>
    let ``D.4.6.5`` = Prefixed_Name(acm, "D.4.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.6.6. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.6.6</seealso>
    let ``D.4.6.6`` = Prefixed_Name(acm, "D.4.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.7. Organization and Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7">http://acm.rkbexplorer.com/ontologies/acm#D.4.7</seealso>
    let ``D.4.7`` = Prefixed_Name(acm, "D.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.7.0. Batch processing systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.0</seealso>
    let ``D.4.7.0`` = Prefixed_Name(acm, "D.4.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.7.1. Distributed systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.1</seealso>
    let ``D.4.7.1`` = Prefixed_Name(acm, "D.4.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.7.2. Hierarchical design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.2</seealso>
    let ``D.4.7.2`` = Prefixed_Name(acm, "D.4.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.7.3. Interactive systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.3</seealso>
    let ``D.4.7.3`` = Prefixed_Name(acm, "D.4.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.7.4. Real-time systems and embedded systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.7.4</seealso>
    let ``D.4.7.4`` = Prefixed_Name(acm, "D.4.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.4, #D.2.8, #I.6."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.8. Performance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8">http://acm.rkbexplorer.com/ontologies/acm#D.4.8</seealso>
    let ``D.4.8`` = Prefixed_Name(acm, "D.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.0. Measurements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.0</seealso>
    let ``D.4.8.0`` = Prefixed_Name(acm, "D.4.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.1. Modeling and prediction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.1</seealso>
    let ``D.4.8.1`` = Prefixed_Name(acm, "D.4.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.2. Monitors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.2</seealso>
    let ``D.4.8.2`` = Prefixed_Name(acm, "D.4.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.3. Operational analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.3</seealso>
    let ``D.4.8.3`` = Prefixed_Name(acm, "D.4.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.4. Queueing theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.4">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.4</seealso>
    let ``D.4.8.4`` = Prefixed_Name(acm, "D.4.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.5. Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.5">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.5</seealso>
    let ``D.4.8.5`` = Prefixed_Name(acm, "D.4.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.8.6. Stochastic analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.6">http://acm.rkbexplorer.com/ontologies/acm#D.4.8.6</seealso>
    let ``D.4.8.6`` = Prefixed_Name(acm, "D.4.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.9. Systems Programs and Utilities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9">http://acm.rkbexplorer.com/ontologies/acm#D.4.9</seealso>
    let ``D.4.9`` = Prefixed_Name(acm, "D.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.9.0. Command and control languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.0">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.0</seealso>
    let ``D.4.9.0`` = Prefixed_Name(acm, "D.4.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.9.1. Linkers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.1">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.1</seealso>
    let ``D.4.9.1`` = Prefixed_Name(acm, "D.4.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.4.9.2. Loaders"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.2">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.2</seealso>
    let ``D.4.9.2`` = Prefixed_Name(acm, "D.4.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.9.3. Window managers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.3">http://acm.rkbexplorer.com/ontologies/acm#D.4.9.3</seealso>
    let ``D.4.9.3`` = Prefixed_Name(acm, "D.4.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.4.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.4.m">http://acm.rkbexplorer.com/ontologies/acm#D.4.m</seealso>
    let ``D.4.m`` = Prefixed_Name(acm, "D.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"D.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.m">http://acm.rkbexplorer.com/ontologies/acm#D.m</seealso>
    let ``D.m`` = Prefixed_Name(acm, "D.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:D.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D.m.0. Software psychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#D.m.0">http://acm.rkbexplorer.com/ontologies/acm#D.m.0</seealso>
    let ``D.m.0`` = Prefixed_Name(acm, "D.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E. Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E">http://acm.rkbexplorer.com/ontologies/acm#E</seealso>
    let E = Prefixed_Name(acm, "E") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.0">http://acm.rkbexplorer.com/ontologies/acm#E.0</seealso>
    let ``E.0`` = Prefixed_Name(acm, "E.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1. DATA STRUCTURES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1">http://acm.rkbexplorer.com/ontologies/acm#E.1</seealso>
    let ``E.1`` = Prefixed_Name(acm, "E.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1.0. Arrays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.0">http://acm.rkbexplorer.com/ontologies/acm#E.1.0</seealso>
    let ``E.1.0`` = Prefixed_Name(acm, "E.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1.1. Distributed data structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.1">http://acm.rkbexplorer.com/ontologies/acm#E.1.1</seealso>
    let ``E.1.1`` = Prefixed_Name(acm, "E.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1.2. Graphs and networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.2">http://acm.rkbexplorer.com/ontologies/acm#E.1.2</seealso>
    let ``E.1.2`` = Prefixed_Name(acm, "E.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1.3. Lists, stacks, and queues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.3">http://acm.rkbexplorer.com/ontologies/acm#E.1.3</seealso>
    let ``E.1.3`` = Prefixed_Name(acm, "E.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1.4. Records"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.4">http://acm.rkbexplorer.com/ontologies/acm#E.1.4</seealso>
    let ``E.1.4`` = Prefixed_Name(acm, "E.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.1.5. Tables"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.5">http://acm.rkbexplorer.com/ontologies/acm#E.1.5</seealso>
    let ``E.1.5`` = Prefixed_Name(acm, "E.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.1.6. Trees"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.1.6">http://acm.rkbexplorer.com/ontologies/acm#E.1.6</seealso>
    let ``E.1.6`` = Prefixed_Name(acm, "E.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.2. DATA STORAGE REPRESENTATIONS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2">http://acm.rkbexplorer.com/ontologies/acm#E.2</seealso>
    let ``E.2`` = Prefixed_Name(acm, "E.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.2.0. Composite structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.0">http://acm.rkbexplorer.com/ontologies/acm#E.2.0</seealso>
    let ``E.2.0`` = Prefixed_Name(acm, "E.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.2.1. Contiguous representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.1">http://acm.rkbexplorer.com/ontologies/acm#E.2.1</seealso>
    let ``E.2.1`` = Prefixed_Name(acm, "E.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.2.2. Hash-table representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.2">http://acm.rkbexplorer.com/ontologies/acm#E.2.2</seealso>
    let ``E.2.2`` = Prefixed_Name(acm, "E.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.2.3. Linked representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.3">http://acm.rkbexplorer.com/ontologies/acm#E.2.3</seealso>
    let ``E.2.3`` = Prefixed_Name(acm, "E.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.2.4. Object representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.4">http://acm.rkbexplorer.com/ontologies/acm#E.2.4</seealso>
    let ``E.2.4`` = Prefixed_Name(acm, "E.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.2.5. Primitive data items"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.2.5">http://acm.rkbexplorer.com/ontologies/acm#E.2.5</seealso>
    let ``E.2.5`` = Prefixed_Name(acm, "E.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.3. DATA ENCRYPTION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3">http://acm.rkbexplorer.com/ontologies/acm#E.3</seealso>
    let ``E.3`` = Prefixed_Name(acm, "E.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.3.0. Code breaking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.0">http://acm.rkbexplorer.com/ontologies/acm#E.3.0</seealso>
    let ``E.3.0`` = Prefixed_Name(acm, "E.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.3.1. Data encryption standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.1">http://acm.rkbexplorer.com/ontologies/acm#E.3.1</seealso>
    let ``E.3.1`` = Prefixed_Name(acm, "E.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.3.2. Public key cryptosystems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.2">http://acm.rkbexplorer.com/ontologies/acm#E.3.2</seealso>
    let ``E.3.2`` = Prefixed_Name(acm, "E.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.3.3. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.3.3">http://acm.rkbexplorer.com/ontologies/acm#E.3.3</seealso>
    let ``E.3.3`` = Prefixed_Name(acm, "E.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #H.1.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.4. CODING AND INFORMATION THEORY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4">http://acm.rkbexplorer.com/ontologies/acm#E.4</seealso>
    let ``E.4`` = Prefixed_Name(acm, "E.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.4.0. Data compaction and compression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.0">http://acm.rkbexplorer.com/ontologies/acm#E.4.0</seealso>
    let ``E.4.0`` = Prefixed_Name(acm, "E.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.4.1. Error control codes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.1">http://acm.rkbexplorer.com/ontologies/acm#E.4.1</seealso>
    let ``E.4.1`` = Prefixed_Name(acm, "E.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.4.2. Formal models of communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.2">http://acm.rkbexplorer.com/ontologies/acm#E.4.2</seealso>
    let ``E.4.2`` = Prefixed_Name(acm, "E.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.4.3. Nonsecret encoding schemes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.4.3">http://acm.rkbexplorer.com/ontologies/acm#E.4.3</seealso>
    let ``E.4.3`` = Prefixed_Name(acm, "E.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.4.3, #F.2.2, #H.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.5. FILES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5">http://acm.rkbexplorer.com/ontologies/acm#E.5</seealso>
    let ``E.5`` = Prefixed_Name(acm, "E.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.5.0. Backup/recovery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.0">http://acm.rkbexplorer.com/ontologies/acm#E.5.0</seealso>
    let ``E.5.0`` = Prefixed_Name(acm, "E.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E.5.1. Optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.1">http://acm.rkbexplorer.com/ontologies/acm#E.5.1</seealso>
    let ``E.5.1`` = Prefixed_Name(acm, "E.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.5.2. Organization/structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.2">http://acm.rkbexplorer.com/ontologies/acm#E.5.2</seealso>
    let ``E.5.2`` = Prefixed_Name(acm, "E.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.5.3. Sorting/searching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.5.3">http://acm.rkbexplorer.com/ontologies/acm#E.5.3</seealso>
    let ``E.5.3`` = Prefixed_Name(acm, "E.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:E.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"E.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#E.m">http://acm.rkbexplorer.com/ontologies/acm#E.m</seealso>
    let ``E.m`` = Prefixed_Name(acm, "E.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F. Theory of Computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F">http://acm.rkbexplorer.com/ontologies/acm#F</seealso>
    let F = Prefixed_Name(acm, "F") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.0">http://acm.rkbexplorer.com/ontologies/acm#F.0</seealso>
    let ``F.0`` = Prefixed_Name(acm, "F.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1. COMPUTATION BY ABSTRACT DEVICES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1">http://acm.rkbexplorer.com/ontologies/acm#F.1</seealso>
    let ``F.1`` = Prefixed_Name(acm, "F.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.0</seealso>
    let ``F.1.0`` = Prefixed_Name(acm, "F.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.4.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.1.1. Models of Computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.1</seealso>
    let ``F.1.1`` = Prefixed_Name(acm, "F.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.1.0. Automata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.0</seealso>
    let ``F.1.1.0`` = Prefixed_Name(acm, "F.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.1.1. Bounded-action devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.1</seealso>
    let ``F.1.1.1`` = Prefixed_Name(acm, "F.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.1.2. Computability theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.2</seealso>
    let ``F.1.1.2`` = Prefixed_Name(acm, "F.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.1.3. Relations between models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.3</seealso>
    let ``F.1.1.3`` = Prefixed_Name(acm, "F.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.1.4. Self-modifying machines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.4</seealso>
    let ``F.1.1.4`` = Prefixed_Name(acm, "F.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.1.5. Unbounded-action devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.5">http://acm.rkbexplorer.com/ontologies/acm#F.1.1.5</seealso>
    let ``F.1.1.5`` = Prefixed_Name(acm, "F.1.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2. Modes of Computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.2</seealso>
    let ``F.1.2`` = Prefixed_Name(acm, "F.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2.0. Alternation and nondeterminism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.0</seealso>
    let ``F.1.2.0`` = Prefixed_Name(acm, "F.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2.1. Interactive and reactive computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.1</seealso>
    let ``F.1.2.1`` = Prefixed_Name(acm, "F.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2.2. Online computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.2</seealso>
    let ``F.1.2.2`` = Prefixed_Name(acm, "F.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2.3. Parallelism and concurrency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.3</seealso>
    let ``F.1.2.3`` = Prefixed_Name(acm, "F.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2.4. Probabilistic computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.4</seealso>
    let ``F.1.2.4`` = Prefixed_Name(acm, "F.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.1.2.5. Relations among modes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.5">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.5</seealso>
    let ``F.1.2.5`` = Prefixed_Name(acm, "F.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.2.6. Relativized computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.6">http://acm.rkbexplorer.com/ontologies/acm#F.1.2.6</seealso>
    let ``F.1.2.6`` = Prefixed_Name(acm, "F.1.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.1.3. Complexity Measures and Classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.3</seealso>
    let ``F.1.3`` = Prefixed_Name(acm, "F.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.3.0. Complexity hierarchies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.0</seealso>
    let ``F.1.3.0`` = Prefixed_Name(acm, "F.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.1.3.1. Machine-independent complexity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.1</seealso>
    let ``F.1.3.1`` = Prefixed_Name(acm, "F.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.3.2. Reducibility and completeness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.2</seealso>
    let ``F.1.3.2`` = Prefixed_Name(acm, "F.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.3.3. Relations among complexity classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.3</seealso>
    let ``F.1.3.3`` = Prefixed_Name(acm, "F.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.3.4. Relations among complexity measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#F.1.3.4</seealso>
    let ``F.1.3.4`` = Prefixed_Name(acm, "F.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.1.m">http://acm.rkbexplorer.com/ontologies/acm#F.1.m</seealso>
    let ``F.1.m`` = Prefixed_Name(acm, "F.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #B.6, #B.7, #F.1.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.2. ANALYSIS OF ALGORITHMS AND PROBLEM COMPLEXITY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2">http://acm.rkbexplorer.com/ontologies/acm#F.2</seealso>
    let ``F.2`` = Prefixed_Name(acm, "F.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.2.0</seealso>
    let ``F.2.0`` = Prefixed_Name(acm, "F.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #G.1, #G.4, #I.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.2.1. Numerical Algorithms and Problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.2.1</seealso>
    let ``F.2.1`` = Prefixed_Name(acm, "F.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.1.0. Computation of transforms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.0</seealso>
    let ``F.2.1.0`` = Prefixed_Name(acm, "F.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.1.1. Computations in finite fields"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.1</seealso>
    let ``F.2.1.1`` = Prefixed_Name(acm, "F.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.1.2. Computations on matrices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.2</seealso>
    let ``F.2.1.2`` = Prefixed_Name(acm, "F.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.1.3. Computations on polynomials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.3</seealso>
    let ``F.2.1.3`` = Prefixed_Name(acm, "F.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.1.4. Number-theoretic computations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.2.1.4</seealso>
    let ``F.2.1.4`` = Prefixed_Name(acm, "F.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.2, #E.3, #E.4, #E.5, #G.2, #H.2, #H.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.2.2. Nonnumerical Algorithms and Problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.2.2</seealso>
    let ``F.2.2`` = Prefixed_Name(acm, "F.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.0. Complexity of proof procedures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.0</seealso>
    let ``F.2.2.0`` = Prefixed_Name(acm, "F.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.1. Computations on discrete structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.1</seealso>
    let ``F.2.2.1`` = Prefixed_Name(acm, "F.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.2. Geometrical problems and computations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.2</seealso>
    let ``F.2.2.2`` = Prefixed_Name(acm, "F.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.3. Pattern matching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.3</seealso>
    let ``F.2.2.3`` = Prefixed_Name(acm, "F.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.4. Routing and layout"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.4</seealso>
    let ``F.2.2.4`` = Prefixed_Name(acm, "F.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.5. Sequencing and scheduling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.5">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.5</seealso>
    let ``F.2.2.5`` = Prefixed_Name(acm, "F.2.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.2.2.6. Sorting and searching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.6">http://acm.rkbexplorer.com/ontologies/acm#F.2.2.6</seealso>
    let ``F.2.2.6`` = Prefixed_Name(acm, "F.2.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.1.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.2.3. Tradeoffs between Complexity Measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.2.3</seealso>
    let ``F.2.3`` = Prefixed_Name(acm, "F.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3. LOGICS AND MEANINGS OF PROGRAMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3">http://acm.rkbexplorer.com/ontologies/acm#F.3</seealso>
    let ``F.3`` = Prefixed_Name(acm, "F.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.0</seealso>
    let ``F.3.0`` = Prefixed_Name(acm, "F.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.2.1, #D.2.4, #D.3.1, #E.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.3.1. Specifying and Verifying and Reasoning about Programs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.1</seealso>
    let ``F.3.1`` = Prefixed_Name(acm, "F.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.1.0. Assertions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.0</seealso>
    let ``F.3.1.0`` = Prefixed_Name(acm, "F.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.1.1. Invariants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.1</seealso>
    let ``F.3.1.1`` = Prefixed_Name(acm, "F.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.1.2. Logics of programs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.2</seealso>
    let ``F.3.1.2`` = Prefixed_Name(acm, "F.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.1.3. Mechanical verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.3</seealso>
    let ``F.3.1.3`` = Prefixed_Name(acm, "F.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.1.4. Pre- and post-conditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.4</seealso>
    let ``F.3.1.4`` = Prefixed_Name(acm, "F.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.1.5. Specification techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.5">http://acm.rkbexplorer.com/ontologies/acm#F.3.1.5</seealso>
    let ``F.3.1.5`` = Prefixed_Name(acm, "F.3.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.3.2. Semantics of Programming Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.2</seealso>
    let ``F.3.2`` = Prefixed_Name(acm, "F.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.2.0. Algebraic approaches to semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.0</seealso>
    let ``F.3.2.0`` = Prefixed_Name(acm, "F.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.2.1. Denotational semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.1</seealso>
    let ``F.3.2.1`` = Prefixed_Name(acm, "F.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.2.2. Operational semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.2</seealso>
    let ``F.3.2.2`` = Prefixed_Name(acm, "F.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.2.3. Partial evaluation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.3</seealso>
    let ``F.3.2.3`` = Prefixed_Name(acm, "F.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.2.4. Process models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.4</seealso>
    let ``F.3.2.4`` = Prefixed_Name(acm, "F.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.2.5. Program analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#F.3.2.5</seealso>
    let ``F.3.2.5`` = Prefixed_Name(acm, "F.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.2, #D.3.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.3.3. Studies of Program Constructs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.3</seealso>
    let ``F.3.3`` = Prefixed_Name(acm, "F.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.3.0. Control primitives"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.0</seealso>
    let ``F.3.3.0`` = Prefixed_Name(acm, "F.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.3.1. Functional constructs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.1</seealso>
    let ``F.3.3.1`` = Prefixed_Name(acm, "F.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.3.2. Object-oriented constructs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.2</seealso>
    let ``F.3.3.2`` = Prefixed_Name(acm, "F.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.3.3. Program and recursion schemes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.3</seealso>
    let ``F.3.3.3`` = Prefixed_Name(acm, "F.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.3.4. Type structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#F.3.3.4</seealso>
    let ``F.3.3.4`` = Prefixed_Name(acm, "F.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.3.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.3.m">http://acm.rkbexplorer.com/ontologies/acm#F.3.m</seealso>
    let ``F.3.m`` = Prefixed_Name(acm, "F.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4. MATHEMATICAL LOGIC AND FORMAL LANGUAGES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4">http://acm.rkbexplorer.com/ontologies/acm#F.4</seealso>
    let ``F.4`` = Prefixed_Name(acm, "F.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.0</seealso>
    let ``F.4.0`` = Prefixed_Name(acm, "F.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.1.1, #I.2.2, #I.2.3, #I.2.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.4.1. Mathematical Logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.1</seealso>
    let ``F.4.1`` = Prefixed_Name(acm, "F.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.0. Computability theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.0</seealso>
    let ``F.4.1.0`` = Prefixed_Name(acm, "F.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.1. Computational logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.1</seealso>
    let ``F.4.1.1`` = Prefixed_Name(acm, "F.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.10. Temporal logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.10">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.10</seealso>
    let ``F.4.1.10`` = Prefixed_Name(acm, "F.4.1.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.2. Lambda calculus and related systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.2</seealso>
    let ``F.4.1.2`` = Prefixed_Name(acm, "F.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.3. Logic and constraint programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.3</seealso>
    let ``F.4.1.3`` = Prefixed_Name(acm, "F.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.4. Mechanical theorem proving"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.4</seealso>
    let ``F.4.1.4`` = Prefixed_Name(acm, "F.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.5. Modal logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.5</seealso>
    let ``F.4.1.5`` = Prefixed_Name(acm, "F.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.6. Model theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.6</seealso>
    let ``F.4.1.6`` = Prefixed_Name(acm, "F.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.7. Proof theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.7">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.7</seealso>
    let ``F.4.1.7`` = Prefixed_Name(acm, "F.4.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.8. Recursive function theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.8">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.8</seealso>
    let ``F.4.1.8`` = Prefixed_Name(acm, "F.4.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.1.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.1.9. Set theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.9">http://acm.rkbexplorer.com/ontologies/acm#F.4.1.9</seealso>
    let ``F.4.1.9`` = Prefixed_Name(acm, "F.4.1.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.4.2. Grammars and Other Rewriting Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.2</seealso>
    let ``F.4.2`` = Prefixed_Name(acm, "F.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.2.0. Decision problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.0</seealso>
    let ``F.4.2.0`` = Prefixed_Name(acm, "F.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.2.1. Grammar types"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.1</seealso>
    let ``F.4.2.1`` = Prefixed_Name(acm, "F.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.2.2. Parallel rewriting systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.2</seealso>
    let ``F.4.2.2`` = Prefixed_Name(acm, "F.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.2.3. Parsing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.3</seealso>
    let ``F.4.2.3`` = Prefixed_Name(acm, "F.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.2.4. Thue systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.4">http://acm.rkbexplorer.com/ontologies/acm#F.4.2.4</seealso>
    let ``F.4.2.4`` = Prefixed_Name(acm, "F.4.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.4.3. Formal Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.3</seealso>
    let ``F.4.3`` = Prefixed_Name(acm, "F.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.3.0. Algebraic language theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.0</seealso>
    let ``F.4.3.0`` = Prefixed_Name(acm, "F.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.3.1. Classes defined by grammars or automata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.1</seealso>
    let ``F.4.3.1`` = Prefixed_Name(acm, "F.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F.4.3.2. Classes defined by resource-bounded automata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.2</seealso>
    let ``F.4.3.2`` = Prefixed_Name(acm, "F.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.3.3. Decision problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.3</seealso>
    let ``F.4.3.3`` = Prefixed_Name(acm, "F.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.3.4. Operations on languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#F.4.3.4</seealso>
    let ``F.4.3.4`` = Prefixed_Name(acm, "F.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.4.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.4.m">http://acm.rkbexplorer.com/ontologies/acm#F.4.m</seealso>
    let ``F.4.m`` = Prefixed_Name(acm, "F.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:F.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#F.m">http://acm.rkbexplorer.com/ontologies/acm#F.m</seealso>
    let ``F.m`` = Prefixed_Name(acm, "F.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G. Mathematics of Computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G">http://acm.rkbexplorer.com/ontologies/acm#G</seealso>
    let G = Prefixed_Name(acm, "G") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.0">http://acm.rkbexplorer.com/ontologies/acm#G.0</seealso>
    let ``G.0`` = Prefixed_Name(acm, "G.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1. NUMERICAL ANALYSIS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1">http://acm.rkbexplorer.com/ontologies/acm#G.1</seealso>
    let ``G.1`` = Prefixed_Name(acm, "G.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.0</seealso>
    let ``G.1.0`` = Prefixed_Name(acm, "G.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.0. Computer arithmetic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.0</seealso>
    let ``G.1.0.0`` = Prefixed_Name(acm, "G.1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.1. Conditioning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.1</seealso>
    let ``G.1.0.1`` = Prefixed_Name(acm, "G.1.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.2. Error analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.2</seealso>
    let ``G.1.0.2`` = Prefixed_Name(acm, "G.1.0.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.3. Interval arithmetic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.3</seealso>
    let ``G.1.0.3`` = Prefixed_Name(acm, "G.1.0.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.4. Multiple precision arithmetic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.4</seealso>
    let ``G.1.0.4`` = Prefixed_Name(acm, "G.1.0.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.5. Numerical algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.5</seealso>
    let ``G.1.0.5`` = Prefixed_Name(acm, "G.1.0.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.6. Parallel algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.6</seealso>
    let ``G.1.0.6`` = Prefixed_Name(acm, "G.1.0.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.0.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.0.7. Stability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.0.7</seealso>
    let ``G.1.0.7`` = Prefixed_Name(acm, "G.1.0.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #I.3.5, #I.3.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.1.1. Interpolation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.1</seealso>
    let ``G.1.1`` = Prefixed_Name(acm, "G.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.1.1.0. Difference formulas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.0</seealso>
    let ``G.1.1.0`` = Prefixed_Name(acm, "G.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.1.1. Extrapolation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.1</seealso>
    let ``G.1.1.1`` = Prefixed_Name(acm, "G.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.1.2. Interpolation formulas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.2</seealso>
    let ``G.1.1.2`` = Prefixed_Name(acm, "G.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.1.3. Smoothing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.3</seealso>
    let ``G.1.1.3`` = Prefixed_Name(acm, "G.1.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.1.4. Spline and piecewise polynomial interpolation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.1.4</seealso>
    let ``G.1.1.4`` = Prefixed_Name(acm, "G.1.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.10. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.10</seealso>
    let ``G.1.10`` = Prefixed_Name(acm, "G.1.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2. Approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.2</seealso>
    let ``G.1.2`` = Prefixed_Name(acm, "G.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.0. Approximation of surfaces and contours"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.0</seealso>
    let ``G.1.2.0`` = Prefixed_Name(acm, "G.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.1. Chebyshev approximation and theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.1</seealso>
    let ``G.1.2.1`` = Prefixed_Name(acm, "G.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.10. Spline and piecewise polynomial approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.10</seealso>
    let ``G.1.2.10`` = Prefixed_Name(acm, "G.1.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.11. Wavelets and fractals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.11">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.11</seealso>
    let ``G.1.2.11`` = Prefixed_Name(acm, "G.1.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.2. Elementary function approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.2</seealso>
    let ``G.1.2.2`` = Prefixed_Name(acm, "G.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.3. Fast Fourier transforms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.3</seealso>
    let ``G.1.2.3`` = Prefixed_Name(acm, "G.1.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.4. Least squares approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.4</seealso>
    let ``G.1.2.4`` = Prefixed_Name(acm, "G.1.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.5. Linear approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.5</seealso>
    let ``G.1.2.5`` = Prefixed_Name(acm, "G.1.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.6. Minimax approximation and algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.6</seealso>
    let ``G.1.2.6`` = Prefixed_Name(acm, "G.1.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.7. Nonlinear approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.7</seealso>
    let ``G.1.2.7`` = Prefixed_Name(acm, "G.1.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.8. Rational approximation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.8</seealso>
    let ``G.1.2.8`` = Prefixed_Name(acm, "G.1.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.2.9. Special function approximations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.2.9</seealso>
    let ``G.1.2.9`` = Prefixed_Name(acm, "G.1.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3. Numerical Linear Algebra"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.3</seealso>
    let ``G.1.3`` = Prefixed_Name(acm, "G.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.0. Conditioning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.0</seealso>
    let ``G.1.3.0`` = Prefixed_Name(acm, "G.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.1.3.1. Determinants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.1</seealso>
    let ``G.1.3.1`` = Prefixed_Name(acm, "G.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.2. Eigenvalues and eigenvectors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.2</seealso>
    let ``G.1.3.2`` = Prefixed_Name(acm, "G.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.3. Error analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.3</seealso>
    let ``G.1.3.3`` = Prefixed_Name(acm, "G.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.4. Linear systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.4</seealso>
    let ``G.1.3.4`` = Prefixed_Name(acm, "G.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.5. Matrix inversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.5</seealso>
    let ``G.1.3.5`` = Prefixed_Name(acm, "G.1.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.1.3.6. Pseudoinverses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.6</seealso>
    let ``G.1.3.6`` = Prefixed_Name(acm, "G.1.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.7. Singular value decomposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.7</seealso>
    let ``G.1.3.7`` = Prefixed_Name(acm, "G.1.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.3.8. Sparse, structured, and very large systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.3.8</seealso>
    let ``G.1.3.8`` = Prefixed_Name(acm, "G.1.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.2.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.1.4. Quadrature and Numerical Differentiation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.4</seealso>
    let ``G.1.4`` = Prefixed_Name(acm, "G.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.0. Adaptive and iterative quadrature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.0</seealso>
    let ``G.1.4.0`` = Prefixed_Name(acm, "G.1.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.1. Automatic differentiation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.1</seealso>
    let ``G.1.4.1`` = Prefixed_Name(acm, "G.1.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.1.4.2. Equal interval integration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.2</seealso>
    let ``G.1.4.2`` = Prefixed_Name(acm, "G.1.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.3. Error analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.3</seealso>
    let ``G.1.4.3`` = Prefixed_Name(acm, "G.1.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.4. Finite difference methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.4</seealso>
    let ``G.1.4.4`` = Prefixed_Name(acm, "G.1.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.5. Gaussian quadrature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.5</seealso>
    let ``G.1.4.5`` = Prefixed_Name(acm, "G.1.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.6. Iterative methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.6</seealso>
    let ``G.1.4.6`` = Prefixed_Name(acm, "G.1.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.4.7. Multidimensional quadrature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.4.7</seealso>
    let ``G.1.4.7`` = Prefixed_Name(acm, "G.1.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5. Roots of Nonlinear Equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.5</seealso>
    let ``G.1.5`` = Prefixed_Name(acm, "G.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5.0. Continuation methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.0</seealso>
    let ``G.1.5.0`` = Prefixed_Name(acm, "G.1.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5.1. Convergence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.1</seealso>
    let ``G.1.5.1`` = Prefixed_Name(acm, "G.1.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5.2. Error analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.2</seealso>
    let ``G.1.5.2`` = Prefixed_Name(acm, "G.1.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5.3. Iterative methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.3</seealso>
    let ``G.1.5.3`` = Prefixed_Name(acm, "G.1.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5.4. Polynomials, methods for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.4</seealso>
    let ``G.1.5.4`` = Prefixed_Name(acm, "G.1.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.5.5. Systems of equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.5.5</seealso>
    let ``G.1.5.5`` = Prefixed_Name(acm, "G.1.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6. Optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.6</seealso>
    let ``G.1.6`` = Prefixed_Name(acm, "G.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.0. Constrained optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.0</seealso>
    let ``G.1.6.0`` = Prefixed_Name(acm, "G.1.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.1. Convex programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.1</seealso>
    let ``G.1.6.1`` = Prefixed_Name(acm, "G.1.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.10. Stochastic programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.10</seealso>
    let ``G.1.6.10`` = Prefixed_Name(acm, "G.1.6.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.11. Unconstrained optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.11">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.11</seealso>
    let ``G.1.6.11`` = Prefixed_Name(acm, "G.1.6.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.2. Global optimization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.2</seealso>
    let ``G.1.6.2`` = Prefixed_Name(acm, "G.1.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.3. Gradient methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.3</seealso>
    let ``G.1.6.3`` = Prefixed_Name(acm, "G.1.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.4. Integer programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.4</seealso>
    let ``G.1.6.4`` = Prefixed_Name(acm, "G.1.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.5. Least squares methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.5</seealso>
    let ``G.1.6.5`` = Prefixed_Name(acm, "G.1.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.6. Linear programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.6</seealso>
    let ``G.1.6.6`` = Prefixed_Name(acm, "G.1.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.7. Nonlinear programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.7</seealso>
    let ``G.1.6.7`` = Prefixed_Name(acm, "G.1.6.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.8. Quadratic programming methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.8</seealso>
    let ``G.1.6.8`` = Prefixed_Name(acm, "G.1.6.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.6.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.6.9. Simulated annealing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.6.9</seealso>
    let ``G.1.6.9`` = Prefixed_Name(acm, "G.1.6.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7. Ordinary Differential Equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.7</seealso>
    let ``G.1.7`` = Prefixed_Name(acm, "G.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.0. Boundary value problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.0</seealso>
    let ``G.1.7.0`` = Prefixed_Name(acm, "G.1.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.1. Chaotic systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.1</seealso>
    let ``G.1.7.1`` = Prefixed_Name(acm, "G.1.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.2. Convergence and stability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.2</seealso>
    let ``G.1.7.2`` = Prefixed_Name(acm, "G.1.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.3. Differential-algebraic equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.3</seealso>
    let ``G.1.7.3`` = Prefixed_Name(acm, "G.1.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.4. Error analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.4</seealso>
    let ``G.1.7.4`` = Prefixed_Name(acm, "G.1.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.5. Finite difference methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.5</seealso>
    let ``G.1.7.5`` = Prefixed_Name(acm, "G.1.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.6. Initial value problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.6</seealso>
    let ``G.1.7.6`` = Prefixed_Name(acm, "G.1.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.7. Multistep and multivalue methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.7</seealso>
    let ``G.1.7.7`` = Prefixed_Name(acm, "G.1.7.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.8. One-step methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.8</seealso>
    let ``G.1.7.8`` = Prefixed_Name(acm, "G.1.7.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.7.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.7.9. Stiff equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.7.9</seealso>
    let ``G.1.7.9`` = Prefixed_Name(acm, "G.1.7.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8. Partial Differential Equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.8</seealso>
    let ``G.1.8`` = Prefixed_Name(acm, "G.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.0. Domain decomposition methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.0</seealso>
    let ``G.1.8.0`` = Prefixed_Name(acm, "G.1.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.1. Elliptic equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.1</seealso>
    let ``G.1.8.1`` = Prefixed_Name(acm, "G.1.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.10. Parabolic equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.10">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.10</seealso>
    let ``G.1.8.10`` = Prefixed_Name(acm, "G.1.8.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.11. Spectral methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.11">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.11</seealso>
    let ``G.1.8.11`` = Prefixed_Name(acm, "G.1.8.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.2. Finite difference methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.2</seealso>
    let ``G.1.8.2`` = Prefixed_Name(acm, "G.1.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.3. Finite element methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.3</seealso>
    let ``G.1.8.3`` = Prefixed_Name(acm, "G.1.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.4. Finite volume methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.4">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.4</seealso>
    let ``G.1.8.4`` = Prefixed_Name(acm, "G.1.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.5. Hyperbolic equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.5">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.5</seealso>
    let ``G.1.8.5`` = Prefixed_Name(acm, "G.1.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.6. Inverse problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.6">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.6</seealso>
    let ``G.1.8.6`` = Prefixed_Name(acm, "G.1.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.7. Iterative solution techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.7">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.7</seealso>
    let ``G.1.8.7`` = Prefixed_Name(acm, "G.1.8.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.8. Method of lines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.8">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.8</seealso>
    let ``G.1.8.8`` = Prefixed_Name(acm, "G.1.8.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.8.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.8.9. Multigrid and multilevel methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.8.9</seealso>
    let ``G.1.8.9`` = Prefixed_Name(acm, "G.1.8.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.9. Integral Equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9">http://acm.rkbexplorer.com/ontologies/acm#G.1.9</seealso>
    let ``G.1.9`` = Prefixed_Name(acm, "G.1.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.9.0. Delay equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.0">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.0</seealso>
    let ``G.1.9.0`` = Prefixed_Name(acm, "G.1.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.9.1. Fredholm equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.1">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.1</seealso>
    let ``G.1.9.1`` = Prefixed_Name(acm, "G.1.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.9.2. Integro-differential equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.2">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.2</seealso>
    let ``G.1.9.2`` = Prefixed_Name(acm, "G.1.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.9.3. Volterra equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.3">http://acm.rkbexplorer.com/ontologies/acm#G.1.9.3</seealso>
    let ``G.1.9.3`` = Prefixed_Name(acm, "G.1.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.1.m">http://acm.rkbexplorer.com/ontologies/acm#G.1.m</seealso>
    let ``G.1.m`` = Prefixed_Name(acm, "G.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2. DISCRETE MATHEMATICS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2">http://acm.rkbexplorer.com/ontologies/acm#G.2</seealso>
    let ``G.2`` = Prefixed_Name(acm, "G.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.0">http://acm.rkbexplorer.com/ontologies/acm#G.2.0</seealso>
    let ``G.2.0`` = Prefixed_Name(acm, "G.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.2.1. Combinatorics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1">http://acm.rkbexplorer.com/ontologies/acm#G.2.1</seealso>
    let ``G.2.1`` = Prefixed_Name(acm, "G.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.1.0. Combinatorial algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.0</seealso>
    let ``G.2.1.0`` = Prefixed_Name(acm, "G.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.1.1. Counting problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.1</seealso>
    let ``G.2.1.1`` = Prefixed_Name(acm, "G.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.1.2. Generating functions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.2</seealso>
    let ``G.2.1.2`` = Prefixed_Name(acm, "G.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.1.3. Permutations and combinations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.3</seealso>
    let ``G.2.1.3`` = Prefixed_Name(acm, "G.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.1.4. Recurrences and difference equations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#G.2.1.4</seealso>
    let ``G.2.1.4`` = Prefixed_Name(acm, "G.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.2.2. Graph Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2">http://acm.rkbexplorer.com/ontologies/acm#G.2.2</seealso>
    let ``G.2.2`` = Prefixed_Name(acm, "G.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.2.0. Graph algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.0</seealso>
    let ``G.2.2.0`` = Prefixed_Name(acm, "G.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.2.1. Graph labeling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.1</seealso>
    let ``G.2.2.1`` = Prefixed_Name(acm, "G.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.2.2. Hypergraphs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.2</seealso>
    let ``G.2.2.2`` = Prefixed_Name(acm, "G.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.2.3. Network problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.3</seealso>
    let ``G.2.2.3`` = Prefixed_Name(acm, "G.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.2.4. Path and circuit problems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.4</seealso>
    let ``G.2.2.4`` = Prefixed_Name(acm, "G.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.2.5. Trees"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.5">http://acm.rkbexplorer.com/ontologies/acm#G.2.2.5</seealso>
    let ``G.2.2.5`` = Prefixed_Name(acm, "G.2.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.3. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.3">http://acm.rkbexplorer.com/ontologies/acm#G.2.3</seealso>
    let ``G.2.3`` = Prefixed_Name(acm, "G.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.2.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.2.m">http://acm.rkbexplorer.com/ontologies/acm#G.2.m</seealso>
    let ``G.2.m`` = Prefixed_Name(acm, "G.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3. PROBABILITY AND STATISTICS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3">http://acm.rkbexplorer.com/ontologies/acm#G.3</seealso>
    let ``G.3`` = Prefixed_Name(acm, "G.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.0. Contingency table analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.0">http://acm.rkbexplorer.com/ontologies/acm#G.3.0</seealso>
    let ``G.3.0`` = Prefixed_Name(acm, "G.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.1. Correlation and regression analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.1">http://acm.rkbexplorer.com/ontologies/acm#G.3.1</seealso>
    let ``G.3.1`` = Prefixed_Name(acm, "G.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.10. Reliability and life testing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.10">http://acm.rkbexplorer.com/ontologies/acm#G.3.10</seealso>
    let ``G.3.10`` = Prefixed_Name(acm, "G.3.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.11. Renewal theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.11">http://acm.rkbexplorer.com/ontologies/acm#G.3.11</seealso>
    let ``G.3.11`` = Prefixed_Name(acm, "G.3.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.12. Robust regression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.12">http://acm.rkbexplorer.com/ontologies/acm#G.3.12</seealso>
    let ``G.3.12`` = Prefixed_Name(acm, "G.3.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.13. Statistical computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.13">http://acm.rkbexplorer.com/ontologies/acm#G.3.13</seealso>
    let ``G.3.13`` = Prefixed_Name(acm, "G.3.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.14. Statistical software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.14">http://acm.rkbexplorer.com/ontologies/acm#G.3.14</seealso>
    let ``G.3.14`` = Prefixed_Name(acm, "G.3.14") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.15. Stochastic processes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.15">http://acm.rkbexplorer.com/ontologies/acm#G.3.15</seealso>
    let ``G.3.15`` = Prefixed_Name(acm, "G.3.15") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.16</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.16. Survival analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.16">http://acm.rkbexplorer.com/ontologies/acm#G.3.16</seealso>
    let ``G.3.16`` = Prefixed_Name(acm, "G.3.16") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.17</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.17. Time series analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.17">http://acm.rkbexplorer.com/ontologies/acm#G.3.17</seealso>
    let ``G.3.17`` = Prefixed_Name(acm, "G.3.17") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.2. Distribution functions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.2">http://acm.rkbexplorer.com/ontologies/acm#G.3.2</seealso>
    let ``G.3.2`` = Prefixed_Name(acm, "G.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.3. Experimental design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.3">http://acm.rkbexplorer.com/ontologies/acm#G.3.3</seealso>
    let ``G.3.3`` = Prefixed_Name(acm, "G.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.4. Markov processes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.4">http://acm.rkbexplorer.com/ontologies/acm#G.3.4</seealso>
    let ``G.3.4`` = Prefixed_Name(acm, "G.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.5. Multivariate statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.5">http://acm.rkbexplorer.com/ontologies/acm#G.3.5</seealso>
    let ``G.3.5`` = Prefixed_Name(acm, "G.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.6. Nonparametric statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.6">http://acm.rkbexplorer.com/ontologies/acm#G.3.6</seealso>
    let ``G.3.6`` = Prefixed_Name(acm, "G.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.7. Probabilistic algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.7">http://acm.rkbexplorer.com/ontologies/acm#G.3.7</seealso>
    let ``G.3.7`` = Prefixed_Name(acm, "G.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.8. Queueing theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.8">http://acm.rkbexplorer.com/ontologies/acm#G.3.8</seealso>
    let ``G.3.8`` = Prefixed_Name(acm, "G.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.3.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.3.9. Random number generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.3.9">http://acm.rkbexplorer.com/ontologies/acm#G.3.9</seealso>
    let ``G.3.9`` = Prefixed_Name(acm, "G.3.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4. MATHEMATICAL SOFTWARE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4">http://acm.rkbexplorer.com/ontologies/acm#G.4</seealso>
    let ``G.4`` = Prefixed_Name(acm, "G.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.0. Algorithm design and analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.0">http://acm.rkbexplorer.com/ontologies/acm#G.4.0</seealso>
    let ``G.4.0`` = Prefixed_Name(acm, "G.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.1. Certification and testing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.1">http://acm.rkbexplorer.com/ontologies/acm#G.4.1</seealso>
    let ``G.4.1`` = Prefixed_Name(acm, "G.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.2. Documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.2">http://acm.rkbexplorer.com/ontologies/acm#G.4.2</seealso>
    let ``G.4.2`` = Prefixed_Name(acm, "G.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.3. Efficiency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.3">http://acm.rkbexplorer.com/ontologies/acm#G.4.3</seealso>
    let ``G.4.3`` = Prefixed_Name(acm, "G.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.4. Parallel and vector implementations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.4">http://acm.rkbexplorer.com/ontologies/acm#G.4.4</seealso>
    let ``G.4.4`` = Prefixed_Name(acm, "G.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.4.5. Portability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.5">http://acm.rkbexplorer.com/ontologies/acm#G.4.5</seealso>
    let ``G.4.5`` = Prefixed_Name(acm, "G.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.6. Reliability and robustness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.6">http://acm.rkbexplorer.com/ontologies/acm#G.4.6</seealso>
    let ``G.4.6`` = Prefixed_Name(acm, "G.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.4.7. User interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.7">http://acm.rkbexplorer.com/ontologies/acm#G.4.7</seealso>
    let ``G.4.7`` = Prefixed_Name(acm, "G.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.4.8. Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.4.8">http://acm.rkbexplorer.com/ontologies/acm#G.4.8</seealso>
    let ``G.4.8`` = Prefixed_Name(acm, "G.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"G.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.m">http://acm.rkbexplorer.com/ontologies/acm#G.m</seealso>
    let ``G.m`` = Prefixed_Name(acm, "G.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:G.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"G.m.0. Queueing theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#G.m.0">http://acm.rkbexplorer.com/ontologies/acm#G.m.0</seealso>
    let ``G.m.0`` = Prefixed_Name(acm, "G.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H. Information Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H">http://acm.rkbexplorer.com/ontologies/acm#H</seealso>
    let H = Prefixed_Name(acm, "H") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.0">http://acm.rkbexplorer.com/ontologies/acm#H.0</seealso>
    let ``H.0`` = Prefixed_Name(acm, "H.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1. MODELS AND PRINCIPLES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1">http://acm.rkbexplorer.com/ontologies/acm#H.1</seealso>
    let ``H.1`` = Prefixed_Name(acm, "H.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.1.0</seealso>
    let ``H.1.0`` = Prefixed_Name(acm, "H.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.1.1. Systems and Information Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.1.1</seealso>
    let ``H.1.1`` = Prefixed_Name(acm, "H.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.1.0. General systems theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.1.1.0</seealso>
    let ``H.1.1.0`` = Prefixed_Name(acm, "H.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.1.1. Information theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.1.1.1</seealso>
    let ``H.1.1.1`` = Prefixed_Name(acm, "H.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.1.2. Value of information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.1.1.2</seealso>
    let ``H.1.1.2`` = Prefixed_Name(acm, "H.1.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.2. User/Machine Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.1.2</seealso>
    let ``H.1.2`` = Prefixed_Name(acm, "H.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.2.0. Human factors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.1.2.0</seealso>
    let ``H.1.2.0`` = Prefixed_Name(acm, "H.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.2.1. Human information processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.1.2.1</seealso>
    let ``H.1.2.1`` = Prefixed_Name(acm, "H.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.2.2. Software psychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.1.2.2</seealso>
    let ``H.1.2.2`` = Prefixed_Name(acm, "H.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.1.m">http://acm.rkbexplorer.com/ontologies/acm#H.1.m</seealso>
    let ``H.1.m`` = Prefixed_Name(acm, "H.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.2. DATABASE MANAGEMENT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2">http://acm.rkbexplorer.com/ontologies/acm#H.2</seealso>
    let ``H.2`` = Prefixed_Name(acm, "H.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.0</seealso>
    let ``H.2.0`` = Prefixed_Name(acm, "H.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.2.0.0. Security, integrity, and protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.0.0</seealso>
    let ``H.2.0.0`` = Prefixed_Name(acm, "H.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.1. Logical Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.1</seealso>
    let ``H.2.1`` = Prefixed_Name(acm, "H.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.1.0. Data models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.1.0</seealso>
    let ``H.2.1.0`` = Prefixed_Name(acm, "H.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.1.1. Normal forms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.1.1</seealso>
    let ``H.2.1.1`` = Prefixed_Name(acm, "H.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.1.2. Schema and subschema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.1.2</seealso>
    let ``H.2.1.2`` = Prefixed_Name(acm, "H.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.2. Physical Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.2</seealso>
    let ``H.2.2`` = Prefixed_Name(acm, "H.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.2.0. Access methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.2.0</seealso>
    let ``H.2.2.0`` = Prefixed_Name(acm, "H.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.2.1. Deadlock avoidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.2.1</seealso>
    let ``H.2.2.1`` = Prefixed_Name(acm, "H.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.2.2. Recovery and restart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.2.2</seealso>
    let ``H.2.2.2`` = Prefixed_Name(acm, "H.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.2.3. Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.3</seealso>
    let ``H.2.3`` = Prefixed_Name(acm, "H.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.3.0. Data description languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.0</seealso>
    let ``H.2.3.0`` = Prefixed_Name(acm, "H.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.3.1. Data manipulation languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.1</seealso>
    let ``H.2.3.1`` = Prefixed_Name(acm, "H.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.3.2. Database programming languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.2</seealso>
    let ``H.2.3.2`` = Prefixed_Name(acm, "H.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.3.3. Query languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.3</seealso>
    let ``H.2.3.3`` = Prefixed_Name(acm, "H.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.3.4. Report writers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.3.4</seealso>
    let ``H.2.3.4`` = Prefixed_Name(acm, "H.2.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4. Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.4</seealso>
    let ``H.2.4`` = Prefixed_Name(acm, "H.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.0. Concurrency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.0</seealso>
    let ``H.2.4.0`` = Prefixed_Name(acm, "H.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.1. Distributed databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.1</seealso>
    let ``H.2.4.1`` = Prefixed_Name(acm, "H.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.2. Multimedia databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.2</seealso>
    let ``H.2.4.2`` = Prefixed_Name(acm, "H.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.3. Object-oriented databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.3</seealso>
    let ``H.2.4.3`` = Prefixed_Name(acm, "H.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.4. Parallel databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.4</seealso>
    let ``H.2.4.4`` = Prefixed_Name(acm, "H.2.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.5. Query processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.5">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.5</seealso>
    let ``H.2.4.5`` = Prefixed_Name(acm, "H.2.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.6. Relational databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.6">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.6</seealso>
    let ``H.2.4.6`` = Prefixed_Name(acm, "H.2.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.7. Rule-based databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.7">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.7</seealso>
    let ``H.2.4.7`` = Prefixed_Name(acm, "H.2.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.8. Textual databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.8">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.8</seealso>
    let ``H.2.4.8`` = Prefixed_Name(acm, "H.2.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.4.9. Transaction processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.9">http://acm.rkbexplorer.com/ontologies/acm#H.2.4.9</seealso>
    let ``H.2.4.9`` = Prefixed_Name(acm, "H.2.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.5. Heterogeneous Databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5">http://acm.rkbexplorer.com/ontologies/acm#H.2.5</seealso>
    let ``H.2.5`` = Prefixed_Name(acm, "H.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.2.5.0. Data translation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.5.0</seealso>
    let ``H.2.5.0`` = Prefixed_Name(acm, "H.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.2.5.1. Program translation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.5.1</seealso>
    let ``H.2.5.1`` = Prefixed_Name(acm, "H.2.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.6. Database Machines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.6">http://acm.rkbexplorer.com/ontologies/acm#H.2.6</seealso>
    let ``H.2.6`` = Prefixed_Name(acm, "H.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.7. Database Administration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7">http://acm.rkbexplorer.com/ontologies/acm#H.2.7</seealso>
    let ``H.2.7`` = Prefixed_Name(acm, "H.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.7.0. Data dictionary/directory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.0</seealso>
    let ``H.2.7.0`` = Prefixed_Name(acm, "H.2.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.7.1. Data warehouse and repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.1</seealso>
    let ``H.2.7.1`` = Prefixed_Name(acm, "H.2.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.7.2. Logging and recovery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.2</seealso>
    let ``H.2.7.2`` = Prefixed_Name(acm, "H.2.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.7.3. Security, integrity, and protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.7.3</seealso>
    let ``H.2.7.3`` = Prefixed_Name(acm, "H.2.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.8. Database Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8">http://acm.rkbexplorer.com/ontologies/acm#H.2.8</seealso>
    let ``H.2.8`` = Prefixed_Name(acm, "H.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.8.0. Data mining"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.0">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.0</seealso>
    let ``H.2.8.0`` = Prefixed_Name(acm, "H.2.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.8.1. Image databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.1">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.1</seealso>
    let ``H.2.8.1`` = Prefixed_Name(acm, "H.2.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.8.2. Scientific databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.2">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.2</seealso>
    let ``H.2.8.2`` = Prefixed_Name(acm, "H.2.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.8.3. Spatial databases and GIS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.3">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.3</seealso>
    let ``H.2.8.3`` = Prefixed_Name(acm, "H.2.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.8.4. Statistical databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.4">http://acm.rkbexplorer.com/ontologies/acm#H.2.8.4</seealso>
    let ``H.2.8.4`` = Prefixed_Name(acm, "H.2.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.2.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.2.m">http://acm.rkbexplorer.com/ontologies/acm#H.2.m</seealso>
    let ``H.2.m`` = Prefixed_Name(acm, "H.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3. INFORMATION STORAGE AND RETRIEVAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3">http://acm.rkbexplorer.com/ontologies/acm#H.3</seealso>
    let ``H.3`` = Prefixed_Name(acm, "H.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.0</seealso>
    let ``H.3.0`` = Prefixed_Name(acm, "H.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.1. Content Analysis and Indexing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.1</seealso>
    let ``H.3.1`` = Prefixed_Name(acm, "H.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.1.0. Abstracting methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.0</seealso>
    let ``H.3.1.0`` = Prefixed_Name(acm, "H.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.1.1. Dictionaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.1</seealso>
    let ``H.3.1.1`` = Prefixed_Name(acm, "H.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.1.2. Indexing methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.2</seealso>
    let ``H.3.1.2`` = Prefixed_Name(acm, "H.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.1.3. Linguistic processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.3</seealso>
    let ``H.3.1.3`` = Prefixed_Name(acm, "H.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.1.4. Thesauruses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.1.4</seealso>
    let ``H.3.1.4`` = Prefixed_Name(acm, "H.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.2. Information Storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.2</seealso>
    let ``H.3.2`` = Prefixed_Name(acm, "H.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.2.0. File organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.2.0</seealso>
    let ``H.3.2.0`` = Prefixed_Name(acm, "H.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.3.2.1. Record classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.2.1</seealso>
    let ``H.3.2.1`` = Prefixed_Name(acm, "H.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3. Information Search and Retrieval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.3</seealso>
    let ``H.3.3`` = Prefixed_Name(acm, "H.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.0. Clustering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.0</seealso>
    let ``H.3.3.0`` = Prefixed_Name(acm, "H.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.1. Information filtering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.1</seealso>
    let ``H.3.3.1`` = Prefixed_Name(acm, "H.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.2. Query formulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.2</seealso>
    let ``H.3.3.2`` = Prefixed_Name(acm, "H.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.3. Relevance feedback"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.3</seealso>
    let ``H.3.3.3`` = Prefixed_Name(acm, "H.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.4. Retrieval models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.4</seealso>
    let ``H.3.3.4`` = Prefixed_Name(acm, "H.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.5. Search process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.5">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.5</seealso>
    let ``H.3.3.5`` = Prefixed_Name(acm, "H.3.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.3.6. Selection process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.6">http://acm.rkbexplorer.com/ontologies/acm#H.3.3.6</seealso>
    let ``H.3.3.6`` = Prefixed_Name(acm, "H.3.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.4. Systems and Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.4</seealso>
    let ``H.3.4`` = Prefixed_Name(acm, "H.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.3.4.0. Current awareness systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.0</seealso>
    let ``H.3.4.0`` = Prefixed_Name(acm, "H.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.4.1. Distributed systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.1</seealso>
    let ``H.3.4.1`` = Prefixed_Name(acm, "H.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.4.2. Information networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.2</seealso>
    let ``H.3.4.2`` = Prefixed_Name(acm, "H.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.4.3. Performance evaluation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.3</seealso>
    let ``H.3.4.3`` = Prefixed_Name(acm, "H.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.3.4.4. Question-answering systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.4</seealso>
    let ``H.3.4.4`` = Prefixed_Name(acm, "H.3.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.4.5. User profiles and alert services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.5">http://acm.rkbexplorer.com/ontologies/acm#H.3.4.5</seealso>
    let ``H.3.4.5`` = Prefixed_Name(acm, "H.3.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.5. Online Information Services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5">http://acm.rkbexplorer.com/ontologies/acm#H.3.5</seealso>
    let ``H.3.5`` = Prefixed_Name(acm, "H.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.5.0. Commercial services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.5.0</seealso>
    let ``H.3.5.0`` = Prefixed_Name(acm, "H.3.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.5.1. Data sharing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.5.1</seealso>
    let ``H.3.5.1`` = Prefixed_Name(acm, "H.3.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.5.2. Web-based services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.5.2</seealso>
    let ``H.3.5.2`` = Prefixed_Name(acm, "H.3.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.6. Library Automation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6">http://acm.rkbexplorer.com/ontologies/acm#H.3.6</seealso>
    let ``H.3.6`` = Prefixed_Name(acm, "H.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.6.0. Large text archives"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.6.0</seealso>
    let ``H.3.6.0`` = Prefixed_Name(acm, "H.3.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.7. Digital Libraries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7">http://acm.rkbexplorer.com/ontologies/acm#H.3.7</seealso>
    let ``H.3.7`` = Prefixed_Name(acm, "H.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.7.0. Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.0">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.0</seealso>
    let ``H.3.7.0`` = Prefixed_Name(acm, "H.3.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.7.1. Dissemination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.1">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.1</seealso>
    let ``H.3.7.1`` = Prefixed_Name(acm, "H.3.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.7.2. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.2">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.2</seealso>
    let ``H.3.7.2`` = Prefixed_Name(acm, "H.3.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.7.3. Systems issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.3">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.3</seealso>
    let ``H.3.7.3`` = Prefixed_Name(acm, "H.3.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.7.4. User issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.4">http://acm.rkbexplorer.com/ontologies/acm#H.3.7.4</seealso>
    let ``H.3.7.4`` = Prefixed_Name(acm, "H.3.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.3.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.3.m">http://acm.rkbexplorer.com/ontologies/acm#H.3.m</seealso>
    let ``H.3.m`` = Prefixed_Name(acm, "H.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4. INFORMATION SYSTEMS APPLICATIONS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4">http://acm.rkbexplorer.com/ontologies/acm#H.4</seealso>
    let ``H.4`` = Prefixed_Name(acm, "H.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.0</seealso>
    let ``H.4.0`` = Prefixed_Name(acm, "H.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #I.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.4.1. Office Automation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.1</seealso>
    let ``H.4.1`` = Prefixed_Name(acm, "H.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.1.0. Desktop publishing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.0</seealso>
    let ``H.4.1.0`` = Prefixed_Name(acm, "H.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.4.1.1. Equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.1</seealso>
    let ``H.4.1.1`` = Prefixed_Name(acm, "H.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.1.2. Groupware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.2</seealso>
    let ``H.4.1.2`` = Prefixed_Name(acm, "H.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.1.3. Spreadsheets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.3</seealso>
    let ``H.4.1.3`` = Prefixed_Name(acm, "H.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.1.4. Time management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.4</seealso>
    let ``H.4.1.4`` = Prefixed_Name(acm, "H.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.1.5. Word processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.5</seealso>
    let ``H.4.1.5`` = Prefixed_Name(acm, "H.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.1.6. Workflow management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#H.4.1.6</seealso>
    let ``H.4.1.6`` = Prefixed_Name(acm, "H.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.2. Types of Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.4.2</seealso>
    let ``H.4.2`` = Prefixed_Name(acm, "H.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.2.0. Decision support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.2.0</seealso>
    let ``H.4.2.0`` = Prefixed_Name(acm, "H.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.2.1. Logistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.2.1</seealso>
    let ``H.4.2.1`` = Prefixed_Name(acm, "H.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.3. Communications Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.4.3</seealso>
    let ``H.4.3`` = Prefixed_Name(acm, "H.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.3.0. Bulletin boards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.0</seealso>
    let ``H.4.3.0`` = Prefixed_Name(acm, "H.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.3.1. Computer conferencing, teleconferencing, and videoconferencing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.1</seealso>
    let ``H.4.3.1`` = Prefixed_Name(acm, "H.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.3.2. Electronic mail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.2</seealso>
    let ``H.4.3.2`` = Prefixed_Name(acm, "H.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.3.3. Information browsers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.3</seealso>
    let ``H.4.3.3`` = Prefixed_Name(acm, "H.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.3.4. Videotex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.4.3.4</seealso>
    let ``H.4.3.4`` = Prefixed_Name(acm, "H.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.4.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.4.m">http://acm.rkbexplorer.com/ontologies/acm#H.4.m</seealso>
    let ``H.4.m`` = Prefixed_Name(acm, "H.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #I.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.5. INFORMATION INTERFACES AND PRESENTATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5">http://acm.rkbexplorer.com/ontologies/acm#H.5</seealso>
    let ``H.5`` = Prefixed_Name(acm, "H.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.0</seealso>
    let ``H.5.0`` = Prefixed_Name(acm, "H.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.1. Multimedia Information Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.1</seealso>
    let ``H.5.1`` = Prefixed_Name(acm, "H.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.1.0. Animations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.0</seealso>
    let ``H.5.1.0`` = Prefixed_Name(acm, "H.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.1.1. Artificial, augmented, and virtual realities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.1</seealso>
    let ``H.5.1.1`` = Prefixed_Name(acm, "H.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.1.2. Audio input/output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.2</seealso>
    let ``H.5.1.2`` = Prefixed_Name(acm, "H.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.1.3. Evaluation/methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.3</seealso>
    let ``H.5.1.3`` = Prefixed_Name(acm, "H.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.5.1.4. Hypertext navigation and maps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.4</seealso>
    let ``H.5.1.4`` = Prefixed_Name(acm, "H.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.1.5. Video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.1.5</seealso>
    let ``H.5.1.5`` = Prefixed_Name(acm, "H.5.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.2.2, #H.1.2, #I.3.6."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.5.2. User Interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.2</seealso>
    let ``H.5.2`` = Prefixed_Name(acm, "H.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.0. Auditory feedback"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.0</seealso>
    let ``H.5.2.0`` = Prefixed_Name(acm, "H.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.1. Benchmarking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.1</seealso>
    let ``H.5.2.1`` = Prefixed_Name(acm, "H.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.10. Screen design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.10">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.10</seealso>
    let ``H.5.2.10`` = Prefixed_Name(acm, "H.5.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.11. Standardization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.11">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.11</seealso>
    let ``H.5.2.11`` = Prefixed_Name(acm, "H.5.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.12. Style guides"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.12">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.12</seealso>
    let ``H.5.2.12`` = Prefixed_Name(acm, "H.5.2.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.13. Theory and methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.13">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.13</seealso>
    let ``H.5.2.13`` = Prefixed_Name(acm, "H.5.2.13") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.14. Training, help, and documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.14">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.14</seealso>
    let ``H.5.2.14`` = Prefixed_Name(acm, "H.5.2.14") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.15. User-centered design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.15">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.15</seealso>
    let ``H.5.2.15`` = Prefixed_Name(acm, "H.5.2.15") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.16</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.16. User interface management systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.16">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.16</seealso>
    let ``H.5.2.16`` = Prefixed_Name(acm, "H.5.2.16") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.17</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.17. Voice I/O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.17">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.17</seealso>
    let ``H.5.2.17`` = Prefixed_Name(acm, "H.5.2.17") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.18</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.18. Windowing systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.18">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.18</seealso>
    let ``H.5.2.18`` = Prefixed_Name(acm, "H.5.2.18") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.2. Ergonomics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.2</seealso>
    let ``H.5.2.2`` = Prefixed_Name(acm, "H.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.3. Evaluation/methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.3</seealso>
    let ``H.5.2.3`` = Prefixed_Name(acm, "H.5.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.4. Graphical user interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.4</seealso>
    let ``H.5.2.4`` = Prefixed_Name(acm, "H.5.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.5. Haptic I/O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.5</seealso>
    let ``H.5.2.5`` = Prefixed_Name(acm, "H.5.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.6. Input devices and strategies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.6">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.6</seealso>
    let ``H.5.2.6`` = Prefixed_Name(acm, "H.5.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.7. Interaction styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.7">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.7</seealso>
    let ``H.5.2.7`` = Prefixed_Name(acm, "H.5.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.8. Natural language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.8">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.8</seealso>
    let ``H.5.2.8`` = Prefixed_Name(acm, "H.5.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.2.9. Prototyping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.9">http://acm.rkbexplorer.com/ontologies/acm#H.5.2.9</seealso>
    let ``H.5.2.9`` = Prefixed_Name(acm, "H.5.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3. Group and Organization Interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.3</seealso>
    let ``H.5.3`` = Prefixed_Name(acm, "H.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.0. Asynchronous interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.0</seealso>
    let ``H.5.3.0`` = Prefixed_Name(acm, "H.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.1. Collaborative computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.1</seealso>
    let ``H.5.3.1`` = Prefixed_Name(acm, "H.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.2. Computer-supported cooperative work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.2</seealso>
    let ``H.5.3.2`` = Prefixed_Name(acm, "H.5.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.3. Evaluation/methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.3</seealso>
    let ``H.5.3.3`` = Prefixed_Name(acm, "H.5.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.4. Organizational design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.4</seealso>
    let ``H.5.3.4`` = Prefixed_Name(acm, "H.5.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.5. Synchronous interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.5</seealso>
    let ``H.5.3.5`` = Prefixed_Name(acm, "H.5.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.6. Theory and models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.6">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.6</seealso>
    let ``H.5.3.6`` = Prefixed_Name(acm, "H.5.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.3.7. Web-based interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.7">http://acm.rkbexplorer.com/ontologies/acm#H.5.3.7</seealso>
    let ``H.5.3.7`` = Prefixed_Name(acm, "H.5.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #I.7, #J.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.5.4. Hypertext/Hypermedia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4">http://acm.rkbexplorer.com/ontologies/acm#H.5.4</seealso>
    let ``H.5.4`` = Prefixed_Name(acm, "H.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.4.0. Architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.0</seealso>
    let ``H.5.4.0`` = Prefixed_Name(acm, "H.5.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.4.1. Navigation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.1</seealso>
    let ``H.5.4.1`` = Prefixed_Name(acm, "H.5.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.4.2. Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.2</seealso>
    let ``H.5.4.2`` = Prefixed_Name(acm, "H.5.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.4.3. User issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.4.3</seealso>
    let ``H.5.4.3`` = Prefixed_Name(acm, "H.5.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #J.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H.5.5. Sound and Music Computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5">http://acm.rkbexplorer.com/ontologies/acm#H.5.5</seealso>
    let ``H.5.5`` = Prefixed_Name(acm, "H.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.5.0. Methodologies and techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.0">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.0</seealso>
    let ``H.5.5.0`` = Prefixed_Name(acm, "H.5.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.5.1. Modeling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.1">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.1</seealso>
    let ``H.5.5.1`` = Prefixed_Name(acm, "H.5.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.5.2. Signal analysis, synthesis, and processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.2">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.2</seealso>
    let ``H.5.5.2`` = Prefixed_Name(acm, "H.5.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.5.3. Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.3">http://acm.rkbexplorer.com/ontologies/acm#H.5.5.3</seealso>
    let ``H.5.5.3`` = Prefixed_Name(acm, "H.5.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.5.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.5.m">http://acm.rkbexplorer.com/ontologies/acm#H.5.m</seealso>
    let ``H.5.m`` = Prefixed_Name(acm, "H.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:H.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"H.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#H.m">http://acm.rkbexplorer.com/ontologies/acm#H.m</seealso>
    let ``H.m`` = Prefixed_Name(acm, "H.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I. Computing Methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I">http://acm.rkbexplorer.com/ontologies/acm#I</seealso>
    let I = Prefixed_Name(acm, "I") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.0">http://acm.rkbexplorer.com/ontologies/acm#I.0</seealso>
    let ``I.0`` = Prefixed_Name(acm, "I.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1. SYMBOLIC AND ALGEBRAIC MANIPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1">http://acm.rkbexplorer.com/ontologies/acm#I.1</seealso>
    let ``I.1`` = Prefixed_Name(acm, "I.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.0</seealso>
    let ``I.1.0`` = Prefixed_Name(acm, "I.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.1, #E.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.1.1. Expressions and Their Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.1</seealso>
    let ``I.1.1`` = Prefixed_Name(acm, "I.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.1.0. Representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.1.0</seealso>
    let ``I.1.1.0`` = Prefixed_Name(acm, "I.1.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.1.1. Simplification of expressions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.1.1</seealso>
    let ``I.1.1.1`` = Prefixed_Name(acm, "I.1.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.2.1, #F.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.1.2. Algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.1.2</seealso>
    let ``I.1.2`` = Prefixed_Name(acm, "I.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.2.0. Algebraic algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.2.0</seealso>
    let ``I.1.2.0`` = Prefixed_Name(acm, "I.1.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.2.1. Analysis of algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.2.1</seealso>
    let ``I.1.2.1`` = Prefixed_Name(acm, "I.1.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.2.2. Nonalgebraic algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.1.2.2</seealso>
    let ``I.1.2.2`` = Prefixed_Name(acm, "I.1.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.2, #D.3.3, #F.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.1.3. Languages and Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.1.3</seealso>
    let ``I.1.3`` = Prefixed_Name(acm, "I.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.3.0. Evaluation strategies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.0</seealso>
    let ``I.1.3.0`` = Prefixed_Name(acm, "I.1.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.1.3.1. Nonprocedural languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.1</seealso>
    let ``I.1.3.1`` = Prefixed_Name(acm, "I.1.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.3.2. Special-purpose algebraic systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.2</seealso>
    let ``I.1.3.2`` = Prefixed_Name(acm, "I.1.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.1.3.3. Special-purpose hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.3</seealso>
    let ``I.1.3.3`` = Prefixed_Name(acm, "I.1.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.1.3.4. Substitution mechanisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.1.3.4</seealso>
    let ``I.1.3.4`` = Prefixed_Name(acm, "I.1.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.4. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.1.4</seealso>
    let ``I.1.4`` = Prefixed_Name(acm, "I.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.1.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.1.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.1.m">http://acm.rkbexplorer.com/ontologies/acm#I.1.m</seealso>
    let ``I.1.m`` = Prefixed_Name(acm, "I.1.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2. ARTIFICIAL INTELLIGENCE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2">http://acm.rkbexplorer.com/ontologies/acm#I.2</seealso>
    let ``I.2`` = Prefixed_Name(acm, "I.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.0</seealso>
    let ``I.2.0`` = Prefixed_Name(acm, "I.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.0.0. Cognitive simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.0.0</seealso>
    let ``I.2.0.0`` = Prefixed_Name(acm, "I.2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.0.1. Philosophical foundations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.0.1</seealso>
    let ``I.2.0.1`` = Prefixed_Name(acm, "I.2.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #H.4, #J."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.1. Applications and Expert Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.1</seealso>
    let ``I.2.1`` = Prefixed_Name(acm, "I.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.0. Cartography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.0</seealso>
    let ``I.2.1.0`` = Prefixed_Name(acm, "I.2.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.1. Games"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.1</seealso>
    let ``I.2.1.1`` = Prefixed_Name(acm, "I.2.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.2. Industrial automation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.2</seealso>
    let ``I.2.1.2`` = Prefixed_Name(acm, "I.2.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.3. Law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.3</seealso>
    let ``I.2.1.3`` = Prefixed_Name(acm, "I.2.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.4. Medicine and science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.4</seealso>
    let ``I.2.1.4`` = Prefixed_Name(acm, "I.2.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.5. Natural language interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.5</seealso>
    let ``I.2.1.5`` = Prefixed_Name(acm, "I.2.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.1.6. Office automation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.1.6</seealso>
    let ``I.2.1.6`` = Prefixed_Name(acm, "I.2.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #I.4.8, #I.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.10. Vision and Scene Understanding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10">http://acm.rkbexplorer.com/ontologies/acm#I.2.10</seealso>
    let ``I.2.10`` = Prefixed_Name(acm, "I.2.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.0. 3D/stereo scene analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.0</seealso>
    let ``I.2.10.0`` = Prefixed_Name(acm, "I.2.10.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.10.1. Architecture and control structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.1</seealso>
    let ``I.2.10.1`` = Prefixed_Name(acm, "I.2.10.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.2. Intensity, color, photometry, and thresholding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.2</seealso>
    let ``I.2.10.2`` = Prefixed_Name(acm, "I.2.10.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.3. Modeling and recovery of physical attributes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.3</seealso>
    let ``I.2.10.3`` = Prefixed_Name(acm, "I.2.10.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.4. Motion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.4</seealso>
    let ``I.2.10.4`` = Prefixed_Name(acm, "I.2.10.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.5. Perceptual reasoning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.5</seealso>
    let ``I.2.10.5`` = Prefixed_Name(acm, "I.2.10.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.6. Representations, data structures, and transforms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.6</seealso>
    let ``I.2.10.6`` = Prefixed_Name(acm, "I.2.10.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.7. Shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.7</seealso>
    let ``I.2.10.7`` = Prefixed_Name(acm, "I.2.10.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.8. Texture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.8">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.8</seealso>
    let ``I.2.10.8`` = Prefixed_Name(acm, "I.2.10.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.10.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.10.9. Video analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.9">http://acm.rkbexplorer.com/ontologies/acm#I.2.10.9</seealso>
    let ``I.2.10.9`` = Prefixed_Name(acm, "I.2.10.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.11. Distributed Artificial Intelligence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11">http://acm.rkbexplorer.com/ontologies/acm#I.2.11</seealso>
    let ``I.2.11`` = Prefixed_Name(acm, "I.2.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.11.0. Coherence and coordination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.0</seealso>
    let ``I.2.11.0`` = Prefixed_Name(acm, "I.2.11.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.11.1. Intelligent agents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.1</seealso>
    let ``I.2.11.1`` = Prefixed_Name(acm, "I.2.11.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.11.2. Languages and structures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.2</seealso>
    let ``I.2.11.2`` = Prefixed_Name(acm, "I.2.11.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.11.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.11.3. Multiagent systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.11.3</seealso>
    let ``I.2.11.3`` = Prefixed_Name(acm, "I.2.11.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.1.2, #F.3.1, #F.4.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.2. Automatic Programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.2</seealso>
    let ``I.2.2`` = Prefixed_Name(acm, "I.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.2.0. Automatic analysis of algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.0</seealso>
    let ``I.2.2.0`` = Prefixed_Name(acm, "I.2.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.2.1. Program modification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.1</seealso>
    let ``I.2.2.1`` = Prefixed_Name(acm, "I.2.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.2.2. Program synthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.2</seealso>
    let ``I.2.2.2`` = Prefixed_Name(acm, "I.2.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.2.3. Program transformation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.3</seealso>
    let ``I.2.2.3`` = Prefixed_Name(acm, "I.2.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.2.4. Program verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.2.4</seealso>
    let ``I.2.2.4`` = Prefixed_Name(acm, "I.2.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.4.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.3. Deduction and Theorem Proving"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.3</seealso>
    let ``I.2.3`` = Prefixed_Name(acm, "I.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.0. Answer/reason extraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.0</seealso>
    let ``I.2.3.0`` = Prefixed_Name(acm, "I.2.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.1. Deduction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.1</seealso>
    let ``I.2.3.1`` = Prefixed_Name(acm, "I.2.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.2. Inference engines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.2</seealso>
    let ``I.2.3.2`` = Prefixed_Name(acm, "I.2.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.3. Logic programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.3</seealso>
    let ``I.2.3.3`` = Prefixed_Name(acm, "I.2.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.4. Mathematical induction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.4</seealso>
    let ``I.2.3.4`` = Prefixed_Name(acm, "I.2.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.3.5. Metatheory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.5</seealso>
    let ``I.2.3.5`` = Prefixed_Name(acm, "I.2.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.6. Nonmonotonic reasoning and belief revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.6</seealso>
    let ``I.2.3.6`` = Prefixed_Name(acm, "I.2.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.7. Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.7</seealso>
    let ``I.2.3.7`` = Prefixed_Name(acm, "I.2.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.3.8. Uncertainty, ``fuzzy,'' and probabilistic reasoning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.8">http://acm.rkbexplorer.com/ontologies/acm#I.2.3.8</seealso>
    let ``I.2.3.8`` = Prefixed_Name(acm, "I.2.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.4.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.4. Knowledge Representation Formalisms and Methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.4</seealso>
    let ``I.2.4`` = Prefixed_Name(acm, "I.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.0. Frames and scripts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.0</seealso>
    let ``I.2.4.0`` = Prefixed_Name(acm, "I.2.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.1. Modal logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.1</seealso>
    let ``I.2.4.1`` = Prefixed_Name(acm, "I.2.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.2. Predicate logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.2</seealso>
    let ``I.2.4.2`` = Prefixed_Name(acm, "I.2.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.3. Relation systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.3</seealso>
    let ``I.2.4.3`` = Prefixed_Name(acm, "I.2.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.4. Representation languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.4</seealso>
    let ``I.2.4.4`` = Prefixed_Name(acm, "I.2.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.5. Representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.5</seealso>
    let ``I.2.4.5`` = Prefixed_Name(acm, "I.2.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.6. Semantic networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.6</seealso>
    let ``I.2.4.6`` = Prefixed_Name(acm, "I.2.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.4.7. Temporal logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.4.7</seealso>
    let ``I.2.4.7`` = Prefixed_Name(acm, "I.2.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.3.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.5. Programming Languages and Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.5</seealso>
    let ``I.2.5`` = Prefixed_Name(acm, "I.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.5.0. Expert system tools and techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.5.0</seealso>
    let ``I.2.5.0`` = Prefixed_Name(acm, "I.2.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #K.3.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.6. Learning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.6</seealso>
    let ``I.2.6`` = Prefixed_Name(acm, "I.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.0. Analogies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.0</seealso>
    let ``I.2.6.0`` = Prefixed_Name(acm, "I.2.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.1. Concept learning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.1</seealso>
    let ``I.2.6.1`` = Prefixed_Name(acm, "I.2.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.2. Connectionism and neural nets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.2</seealso>
    let ``I.2.6.2`` = Prefixed_Name(acm, "I.2.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.3. Induction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.3</seealso>
    let ``I.2.6.3`` = Prefixed_Name(acm, "I.2.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.4. Knowledge acquisition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.4</seealso>
    let ``I.2.6.4`` = Prefixed_Name(acm, "I.2.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.5. Language acquisition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.5</seealso>
    let ``I.2.6.5`` = Prefixed_Name(acm, "I.2.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.6.6. Parameter learning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.6.6</seealso>
    let ``I.2.6.6`` = Prefixed_Name(acm, "I.2.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7. Natural Language Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.7</seealso>
    let ``I.2.7`` = Prefixed_Name(acm, "I.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.0. Discourse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.0</seealso>
    let ``I.2.7.0`` = Prefixed_Name(acm, "I.2.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.1. Language generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.1</seealso>
    let ``I.2.7.1`` = Prefixed_Name(acm, "I.2.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.2. Language models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.2</seealso>
    let ``I.2.7.2`` = Prefixed_Name(acm, "I.2.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.3. Language parsing and understanding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.3</seealso>
    let ``I.2.7.3`` = Prefixed_Name(acm, "I.2.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.4. Machine translation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.4</seealso>
    let ``I.2.7.4`` = Prefixed_Name(acm, "I.2.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.5. Speech recognition and synthesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.5</seealso>
    let ``I.2.7.5`` = Prefixed_Name(acm, "I.2.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.7.6. Text analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.7.6</seealso>
    let ``I.2.7.6`` = Prefixed_Name(acm, "I.2.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #F.2.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.2.8. Problem Solving, Control Methods, and Search"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8">http://acm.rkbexplorer.com/ontologies/acm#I.2.8</seealso>
    let ``I.2.8`` = Prefixed_Name(acm, "I.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.0. Backtracking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.0</seealso>
    let ``I.2.8.0`` = Prefixed_Name(acm, "I.2.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.1. Control theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.1</seealso>
    let ``I.2.8.1`` = Prefixed_Name(acm, "I.2.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.2. Dynamic programming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.2</seealso>
    let ``I.2.8.2`` = Prefixed_Name(acm, "I.2.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.3. Graph and tree search strategies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.3</seealso>
    let ``I.2.8.3`` = Prefixed_Name(acm, "I.2.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.4. Heuristic methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.4</seealso>
    let ``I.2.8.4`` = Prefixed_Name(acm, "I.2.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.5. Plan execution, formation, and generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.5</seealso>
    let ``I.2.8.5`` = Prefixed_Name(acm, "I.2.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.8.6. Scheduling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.8.6</seealso>
    let ``I.2.8.6`` = Prefixed_Name(acm, "I.2.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9. Robotics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9">http://acm.rkbexplorer.com/ontologies/acm#I.2.9</seealso>
    let ``I.2.9`` = Prefixed_Name(acm, "I.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.0. Autonomous vehicles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.0">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.0</seealso>
    let ``I.2.9.0`` = Prefixed_Name(acm, "I.2.9.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.1. Commercial robots and applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.1">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.1</seealso>
    let ``I.2.9.1`` = Prefixed_Name(acm, "I.2.9.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.2. Kinematics and dynamics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.2">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.2</seealso>
    let ``I.2.9.2`` = Prefixed_Name(acm, "I.2.9.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.3. Manipulators"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.3">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.3</seealso>
    let ``I.2.9.3`` = Prefixed_Name(acm, "I.2.9.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.4. Operator interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.4">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.4</seealso>
    let ``I.2.9.4`` = Prefixed_Name(acm, "I.2.9.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.5. Propelling mechanisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.5">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.5</seealso>
    let ``I.2.9.5`` = Prefixed_Name(acm, "I.2.9.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.6. Sensors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.6">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.6</seealso>
    let ``I.2.9.6`` = Prefixed_Name(acm, "I.2.9.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.9.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.9.7. Workcell organization and planning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.7">http://acm.rkbexplorer.com/ontologies/acm#I.2.9.7</seealso>
    let ``I.2.9.7`` = Prefixed_Name(acm, "I.2.9.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.2.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.2.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.2.m">http://acm.rkbexplorer.com/ontologies/acm#I.2.m</seealso>
    let ``I.2.m`` = Prefixed_Name(acm, "I.2.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3. COMPUTER GRAPHICS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3">http://acm.rkbexplorer.com/ontologies/acm#I.3</seealso>
    let ``I.3`` = Prefixed_Name(acm, "I.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.0</seealso>
    let ``I.3.0`` = Prefixed_Name(acm, "I.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #B.4.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.1. Hardware Architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.1</seealso>
    let ``I.3.1`` = Prefixed_Name(acm, "I.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.1.0. Graphics processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.0</seealso>
    let ``I.3.1.0`` = Prefixed_Name(acm, "I.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.1.1. Hardcopy devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.1</seealso>
    let ``I.3.1.1`` = Prefixed_Name(acm, "I.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.1.2. Input devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.2</seealso>
    let ``I.3.1.2`` = Prefixed_Name(acm, "I.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.1.3. Parallel processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.3</seealso>
    let ``I.3.1.3`` = Prefixed_Name(acm, "I.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.1.4. Raster display devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.4</seealso>
    let ``I.3.1.4`` = Prefixed_Name(acm, "I.3.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.1.5. Storage devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.5</seealso>
    let ``I.3.1.5`` = Prefixed_Name(acm, "I.3.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.1.6. Three-dimensional displays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.6</seealso>
    let ``I.3.1.6`` = Prefixed_Name(acm, "I.3.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.1.7. Vector display devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.1.7</seealso>
    let ``I.3.1.7`` = Prefixed_Name(acm, "I.3.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.2.1, #C.2.4, #C.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.2. Graphics Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.2</seealso>
    let ``I.3.2`` = Prefixed_Name(acm, "I.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.2.0. Distributed/network graphics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.2.0</seealso>
    let ``I.3.2.0`` = Prefixed_Name(acm, "I.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.2.1. Remote systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.2.1</seealso>
    let ``I.3.2.1`` = Prefixed_Name(acm, "I.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.2.2. Stand-alone systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.2.2</seealso>
    let ``I.3.2.2`` = Prefixed_Name(acm, "I.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.3. Picture/Image Generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.3</seealso>
    let ``I.3.3`` = Prefixed_Name(acm, "I.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.3.0. Antialiasing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.0</seealso>
    let ``I.3.3.0`` = Prefixed_Name(acm, "I.3.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.3.1. Bitmap and framebuffer operations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.1</seealso>
    let ``I.3.3.1`` = Prefixed_Name(acm, "I.3.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.3.2. Digitizing and scanning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.2</seealso>
    let ``I.3.3.2`` = Prefixed_Name(acm, "I.3.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.3.3. Display algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.3</seealso>
    let ``I.3.3.3`` = Prefixed_Name(acm, "I.3.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.3.4. Line and curve generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.4</seealso>
    let ``I.3.3.4`` = Prefixed_Name(acm, "I.3.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.3.5. Viewing algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.3.5</seealso>
    let ``I.3.3.5`` = Prefixed_Name(acm, "I.3.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4. Graphics Utilities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.4</seealso>
    let ``I.3.4`` = Prefixed_Name(acm, "I.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4.0. Application packages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.0</seealso>
    let ``I.3.4.0`` = Prefixed_Name(acm, "I.3.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.4.1. Device drivers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.1</seealso>
    let ``I.3.4.1`` = Prefixed_Name(acm, "I.3.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4.2. Graphics editors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.2</seealso>
    let ``I.3.4.2`` = Prefixed_Name(acm, "I.3.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4.3. Graphics packages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.3</seealso>
    let ``I.3.4.3`` = Prefixed_Name(acm, "I.3.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.4.4. Meta files"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.4</seealso>
    let ``I.3.4.4`` = Prefixed_Name(acm, "I.3.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4.5. Paint systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.5</seealso>
    let ``I.3.4.5`` = Prefixed_Name(acm, "I.3.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.4.6. Picture description languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.6</seealso>
    let ``I.3.4.6`` = Prefixed_Name(acm, "I.3.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4.7. Software support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.7</seealso>
    let ``I.3.4.7`` = Prefixed_Name(acm, "I.3.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.4.8. Virtual device interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.8">http://acm.rkbexplorer.com/ontologies/acm#I.3.4.8</seealso>
    let ``I.3.4.8`` = Prefixed_Name(acm, "I.3.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5. Computational Geometry and Object Modeling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.5</seealso>
    let ``I.3.5`` = Prefixed_Name(acm, "I.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.0. Boundary representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.0</seealso>
    let ``I.3.5.0`` = Prefixed_Name(acm, "I.3.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.5.1. Constructive solid geometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.1</seealso>
    let ``I.3.5.1`` = Prefixed_Name(acm, "I.3.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.2. Curve, surface, solid, and object representations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.2</seealso>
    let ``I.3.5.2`` = Prefixed_Name(acm, "I.3.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.3. Geometric algorithms, languages, and systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.3</seealso>
    let ``I.3.5.3`` = Prefixed_Name(acm, "I.3.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.4. Hierarchy and geometric transformations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.4</seealso>
    let ``I.3.5.4`` = Prefixed_Name(acm, "I.3.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.5. Modeling packages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.5</seealso>
    let ``I.3.5.5`` = Prefixed_Name(acm, "I.3.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.6. Object hierarchies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.6</seealso>
    let ``I.3.5.6`` = Prefixed_Name(acm, "I.3.5.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.7. Physically based modeling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.7</seealso>
    let ``I.3.5.7`` = Prefixed_Name(acm, "I.3.5.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.5.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.5.8. Splines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.8">http://acm.rkbexplorer.com/ontologies/acm#I.3.5.8</seealso>
    let ``I.3.5.8`` = Prefixed_Name(acm, "I.3.5.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.6. Methodology and Techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.6</seealso>
    let ``I.3.6`` = Prefixed_Name(acm, "I.3.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.3.6.0. Device independence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.0</seealso>
    let ``I.3.6.0`` = Prefixed_Name(acm, "I.3.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.6.1. Ergonomics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.1</seealso>
    let ``I.3.6.1`` = Prefixed_Name(acm, "I.3.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.6.2. Graphics data structures and data types"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.2</seealso>
    let ``I.3.6.2`` = Prefixed_Name(acm, "I.3.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.6.3. Interaction techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.3</seealso>
    let ``I.3.6.3`` = Prefixed_Name(acm, "I.3.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.6.4. Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.4</seealso>
    let ``I.3.6.4`` = Prefixed_Name(acm, "I.3.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.6.5. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.6.5</seealso>
    let ``I.3.6.5`` = Prefixed_Name(acm, "I.3.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7. Three-Dimensional Graphics and Realism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.7</seealso>
    let ``I.3.7`` = Prefixed_Name(acm, "I.3.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.0. Animation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.0</seealso>
    let ``I.3.7.0`` = Prefixed_Name(acm, "I.3.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.1. Color, shading, shadowing, and texture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.1</seealso>
    let ``I.3.7.1`` = Prefixed_Name(acm, "I.3.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.2. Fractals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.2</seealso>
    let ``I.3.7.2`` = Prefixed_Name(acm, "I.3.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.3. Hidden line/surface removal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.3</seealso>
    let ``I.3.7.3`` = Prefixed_Name(acm, "I.3.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.4. Radiosity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.4</seealso>
    let ``I.3.7.4`` = Prefixed_Name(acm, "I.3.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.5. Raytracing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.5">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.5</seealso>
    let ``I.3.7.5`` = Prefixed_Name(acm, "I.3.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.6. Virtual reality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.6">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.6</seealso>
    let ``I.3.7.6`` = Prefixed_Name(acm, "I.3.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.7.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.7.7. Visible line/surface algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.7">http://acm.rkbexplorer.com/ontologies/acm#I.3.7.7</seealso>
    let ``I.3.7.7`` = Prefixed_Name(acm, "I.3.7.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.8. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.8">http://acm.rkbexplorer.com/ontologies/acm#I.3.8</seealso>
    let ``I.3.8`` = Prefixed_Name(acm, "I.3.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.3.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.3.m">http://acm.rkbexplorer.com/ontologies/acm#I.3.m</seealso>
    let ``I.3.m`` = Prefixed_Name(acm, "I.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4. IMAGE PROCESSING AND COMPUTER VISION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4">http://acm.rkbexplorer.com/ontologies/acm#I.4</seealso>
    let ``I.4`` = Prefixed_Name(acm, "I.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.0</seealso>
    let ``I.4.0`` = Prefixed_Name(acm, "I.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.0.0. Image displays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.0.0</seealso>
    let ``I.4.0.0`` = Prefixed_Name(acm, "I.4.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.0.1. Image processing software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.0.1</seealso>
    let ``I.4.0.1`` = Prefixed_Name(acm, "I.4.0.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1. Digitization and Image Capture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.1</seealso>
    let ``I.4.1`` = Prefixed_Name(acm, "I.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.0. Camera calibration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.0</seealso>
    let ``I.4.1.0`` = Prefixed_Name(acm, "I.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.1. Imaging geometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.1</seealso>
    let ``I.4.1.1`` = Prefixed_Name(acm, "I.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.2. Quantization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.2</seealso>
    let ``I.4.1.2`` = Prefixed_Name(acm, "I.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.3. Radiometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.3</seealso>
    let ``I.4.1.3`` = Prefixed_Name(acm, "I.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.4. Reflectance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.4</seealso>
    let ``I.4.1.4`` = Prefixed_Name(acm, "I.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.5. Sampling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.5</seealso>
    let ``I.4.1.5`` = Prefixed_Name(acm, "I.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.1.6. Scanning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#I.4.1.6</seealso>
    let ``I.4.1.6`` = Prefixed_Name(acm, "I.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.10. Image Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10">http://acm.rkbexplorer.com/ontologies/acm#I.4.10</seealso>
    let ``I.4.10`` = Prefixed_Name(acm, "I.4.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.10.0. Hierarchical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.0</seealso>
    let ``I.4.10.0`` = Prefixed_Name(acm, "I.4.10.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.10.1. Morphological"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.1</seealso>
    let ``I.4.10.1`` = Prefixed_Name(acm, "I.4.10.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.10.2. Multidimensional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.2</seealso>
    let ``I.4.10.2`` = Prefixed_Name(acm, "I.4.10.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.10.3. Statistical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.3</seealso>
    let ``I.4.10.3`` = Prefixed_Name(acm, "I.4.10.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.10.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.10.4. Volumetric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.10.4</seealso>
    let ``I.4.10.4`` = Prefixed_Name(acm, "I.4.10.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #E.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.2. Compression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.2</seealso>
    let ``I.4.2`` = Prefixed_Name(acm, "I.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.2.0. Approximate methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.2.0</seealso>
    let ``I.4.2.0`` = Prefixed_Name(acm, "I.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.2.1. Exact coding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.2.1</seealso>
    let ``I.4.2.1`` = Prefixed_Name(acm, "I.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.3. Enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.3</seealso>
    let ``I.4.3`` = Prefixed_Name(acm, "I.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.3.0. Filtering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.0</seealso>
    let ``I.4.3.0`` = Prefixed_Name(acm, "I.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.3.1. Geometric correction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.1</seealso>
    let ``I.4.3.1`` = Prefixed_Name(acm, "I.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.3.2. Grayscale manipulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.2</seealso>
    let ``I.4.3.2`` = Prefixed_Name(acm, "I.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.3.3. Registration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.3</seealso>
    let ``I.4.3.3`` = Prefixed_Name(acm, "I.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.3.4. Sharpening and deblurring"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.4</seealso>
    let ``I.4.3.4`` = Prefixed_Name(acm, "I.4.3.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.3.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.3.5. Smoothing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.3.5</seealso>
    let ``I.4.3.5`` = Prefixed_Name(acm, "I.4.3.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.4. Restoration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.4</seealso>
    let ``I.4.4`` = Prefixed_Name(acm, "I.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.4.0. Inverse filtering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.0</seealso>
    let ``I.4.4.0`` = Prefixed_Name(acm, "I.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.4.1. Kalman filtering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.1</seealso>
    let ``I.4.4.1`` = Prefixed_Name(acm, "I.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.4.2. Pseudoinverse restoration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.2</seealso>
    let ``I.4.4.2`` = Prefixed_Name(acm, "I.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.4.3. Wiener filtering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.4.3</seealso>
    let ``I.4.4.3`` = Prefixed_Name(acm, "I.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.5. Reconstruction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.5</seealso>
    let ``I.4.5`` = Prefixed_Name(acm, "I.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.5.0. Series expansion methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.5.0</seealso>
    let ``I.4.5.0`` = Prefixed_Name(acm, "I.4.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.4.5.1. Summation methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.5.1</seealso>
    let ``I.4.5.1`` = Prefixed_Name(acm, "I.4.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.5.2. Transform methods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.5.2</seealso>
    let ``I.4.5.2`` = Prefixed_Name(acm, "I.4.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.6. Segmentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6">http://acm.rkbexplorer.com/ontologies/acm#I.4.6</seealso>
    let ``I.4.6`` = Prefixed_Name(acm, "I.4.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.6.0. Edge and feature detection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.0</seealso>
    let ``I.4.6.0`` = Prefixed_Name(acm, "I.4.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.6.1. Pixel classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.1</seealso>
    let ``I.4.6.1`` = Prefixed_Name(acm, "I.4.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.6.2. Region growing, partitioning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.2</seealso>
    let ``I.4.6.2`` = Prefixed_Name(acm, "I.4.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.6.3. Relaxation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.6.3</seealso>
    let ``I.4.6.3`` = Prefixed_Name(acm, "I.4.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7. Feature Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7">http://acm.rkbexplorer.com/ontologies/acm#I.4.7</seealso>
    let ``I.4.7`` = Prefixed_Name(acm, "I.4.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7.0. Feature representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.0</seealso>
    let ``I.4.7.0`` = Prefixed_Name(acm, "I.4.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7.1. Invariants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.1</seealso>
    let ``I.4.7.1`` = Prefixed_Name(acm, "I.4.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7.2. Moments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.2</seealso>
    let ``I.4.7.2`` = Prefixed_Name(acm, "I.4.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7.3. Projections"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.3</seealso>
    let ``I.4.7.3`` = Prefixed_Name(acm, "I.4.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7.4. Size and shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.4</seealso>
    let ``I.4.7.4`` = Prefixed_Name(acm, "I.4.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.7.5. Texture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.7.5</seealso>
    let ``I.4.7.5`` = Prefixed_Name(acm, "I.4.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8. Scene Analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8">http://acm.rkbexplorer.com/ontologies/acm#I.4.8</seealso>
    let ``I.4.8`` = Prefixed_Name(acm, "I.4.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.0. Color"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.0">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.0</seealso>
    let ``I.4.8.0`` = Prefixed_Name(acm, "I.4.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.1. Depth cues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.1">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.1</seealso>
    let ``I.4.8.1`` = Prefixed_Name(acm, "I.4.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.10. Surface fitting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.10">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.10</seealso>
    let ``I.4.8.10`` = Prefixed_Name(acm, "I.4.8.10") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.11. Time-varying imagery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.11">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.11</seealso>
    let ``I.4.8.11`` = Prefixed_Name(acm, "I.4.8.11") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.12</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.12. Tracking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.12">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.12</seealso>
    let ``I.4.8.12`` = Prefixed_Name(acm, "I.4.8.12") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.2. Motion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.2">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.2</seealso>
    let ``I.4.8.2`` = Prefixed_Name(acm, "I.4.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.3. Object recognition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.3">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.3</seealso>
    let ``I.4.8.3`` = Prefixed_Name(acm, "I.4.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.4. Photometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.4">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.4</seealso>
    let ``I.4.8.4`` = Prefixed_Name(acm, "I.4.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.5. Range data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.5">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.5</seealso>
    let ``I.4.8.5`` = Prefixed_Name(acm, "I.4.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.6. Sensor fusion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.6">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.6</seealso>
    let ``I.4.8.6`` = Prefixed_Name(acm, "I.4.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.7. Shading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.7">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.7</seealso>
    let ``I.4.8.7`` = Prefixed_Name(acm, "I.4.8.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.8. Shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.8">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.8</seealso>
    let ``I.4.8.8`` = Prefixed_Name(acm, "I.4.8.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.8.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.8.9. Stereo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.9">http://acm.rkbexplorer.com/ontologies/acm#I.4.8.9</seealso>
    let ``I.4.8.9`` = Prefixed_Name(acm, "I.4.8.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.9. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.9">http://acm.rkbexplorer.com/ontologies/acm#I.4.9</seealso>
    let ``I.4.9`` = Prefixed_Name(acm, "I.4.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.4.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.4.m">http://acm.rkbexplorer.com/ontologies/acm#I.4.m</seealso>
    let ``I.4.m`` = Prefixed_Name(acm, "I.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5. PATTERN RECOGNITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5">http://acm.rkbexplorer.com/ontologies/acm#I.5</seealso>
    let ``I.5`` = Prefixed_Name(acm, "I.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.0</seealso>
    let ``I.5.0`` = Prefixed_Name(acm, "I.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.1. Models"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.1</seealso>
    let ``I.5.1`` = Prefixed_Name(acm, "I.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.5.1.0. Deterministic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.0</seealso>
    let ``I.5.1.0`` = Prefixed_Name(acm, "I.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.1.1. Fuzzy set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.1</seealso>
    let ``I.5.1.1`` = Prefixed_Name(acm, "I.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.1.2. Geometric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.2</seealso>
    let ``I.5.1.2`` = Prefixed_Name(acm, "I.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.1.3. Neural nets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.3</seealso>
    let ``I.5.1.3`` = Prefixed_Name(acm, "I.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.1.4. Statistical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.4</seealso>
    let ``I.5.1.4`` = Prefixed_Name(acm, "I.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.1.5. Structural"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.5">http://acm.rkbexplorer.com/ontologies/acm#I.5.1.5</seealso>
    let ``I.5.1.5`` = Prefixed_Name(acm, "I.5.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.2. Design Methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.2</seealso>
    let ``I.5.2`` = Prefixed_Name(acm, "I.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.2.0. Classifier design and evaluation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.2.0</seealso>
    let ``I.5.2.0`` = Prefixed_Name(acm, "I.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.2.1. Feature evaluation and selection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.2.1</seealso>
    let ``I.5.2.1`` = Prefixed_Name(acm, "I.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.2.2. Pattern analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.2.2</seealso>
    let ``I.5.2.2`` = Prefixed_Name(acm, "I.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.3. Clustering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3">http://acm.rkbexplorer.com/ontologies/acm#I.5.3</seealso>
    let ``I.5.3`` = Prefixed_Name(acm, "I.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.3.0. Algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.3.0</seealso>
    let ``I.5.3.0`` = Prefixed_Name(acm, "I.5.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.3.1. Similarity measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.3.1</seealso>
    let ``I.5.3.1`` = Prefixed_Name(acm, "I.5.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.4. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4">http://acm.rkbexplorer.com/ontologies/acm#I.5.4</seealso>
    let ``I.5.4`` = Prefixed_Name(acm, "I.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.4.0. Computer vision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.0</seealso>
    let ``I.5.4.0`` = Prefixed_Name(acm, "I.5.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.4.1. Signal processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.1</seealso>
    let ``I.5.4.1`` = Prefixed_Name(acm, "I.5.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.4.2. Text processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.2</seealso>
    let ``I.5.4.2`` = Prefixed_Name(acm, "I.5.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.4.3. Waveform analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.5.4.3</seealso>
    let ``I.5.4.3`` = Prefixed_Name(acm, "I.5.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.5.5. Implementation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5">http://acm.rkbexplorer.com/ontologies/acm#I.5.5</seealso>
    let ``I.5.5`` = Prefixed_Name(acm, "I.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.5.0. Interactive systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.5.5.0</seealso>
    let ``I.5.5.0`` = Prefixed_Name(acm, "I.5.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.5.1. Special architectures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.1">http://acm.rkbexplorer.com/ontologies/acm#I.5.5.1</seealso>
    let ``I.5.5.1`` = Prefixed_Name(acm, "I.5.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.5.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.5.m">http://acm.rkbexplorer.com/ontologies/acm#I.5.m</seealso>
    let ``I.5.m`` = Prefixed_Name(acm, "I.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #G.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.6. SIMULATION AND MODELING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6">http://acm.rkbexplorer.com/ontologies/acm#I.6</seealso>
    let ``I.6`` = Prefixed_Name(acm, "I.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.0</seealso>
    let ``I.6.0`` = Prefixed_Name(acm, "I.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.1. Simulation Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1">http://acm.rkbexplorer.com/ontologies/acm#I.6.1</seealso>
    let ``I.6.1`` = Prefixed_Name(acm, "I.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.1.0. Model classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.1.0</seealso>
    let ``I.6.1.0`` = Prefixed_Name(acm, "I.6.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.1.1. Systems theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.6.1.1</seealso>
    let ``I.6.1.1`` = Prefixed_Name(acm, "I.6.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1991."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.6.1.2. Types of simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.6.1.2</seealso>
    let ``I.6.1.2`` = Prefixed_Name(acm, "I.6.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.2. Simulation Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.2">http://acm.rkbexplorer.com/ontologies/acm#I.6.2</seealso>
    let ``I.6.2`` = Prefixed_Name(acm, "I.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.3. Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.3">http://acm.rkbexplorer.com/ontologies/acm#I.6.3</seealso>
    let ``I.6.3`` = Prefixed_Name(acm, "I.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.4. Model Validation and Analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.4">http://acm.rkbexplorer.com/ontologies/acm#I.6.4</seealso>
    let ``I.6.4`` = Prefixed_Name(acm, "I.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.5. Model Development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5">http://acm.rkbexplorer.com/ontologies/acm#I.6.5</seealso>
    let ``I.6.5`` = Prefixed_Name(acm, "I.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.5.0. Modeling methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.5.0</seealso>
    let ``I.6.5.0`` = Prefixed_Name(acm, "I.6.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.6. Simulation Output Analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.6">http://acm.rkbexplorer.com/ontologies/acm#I.6.6</seealso>
    let ``I.6.6`` = Prefixed_Name(acm, "I.6.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.7. Simulation Support Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7">http://acm.rkbexplorer.com/ontologies/acm#I.6.7</seealso>
    let ``I.6.7`` = Prefixed_Name(acm, "I.6.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.7.0. Environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.7.0</seealso>
    let ``I.6.7.0`` = Prefixed_Name(acm, "I.6.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8. Types of Simulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8">http://acm.rkbexplorer.com/ontologies/acm#I.6.8</seealso>
    let ``I.6.8`` = Prefixed_Name(acm, "I.6.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.0. Animation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.0">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.0</seealso>
    let ``I.6.8.0`` = Prefixed_Name(acm, "I.6.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.1. Combined"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.1">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.1</seealso>
    let ``I.6.8.1`` = Prefixed_Name(acm, "I.6.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.2. Continuous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.2">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.2</seealso>
    let ``I.6.8.2`` = Prefixed_Name(acm, "I.6.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.3. Discrete event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.3">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.3</seealso>
    let ``I.6.8.3`` = Prefixed_Name(acm, "I.6.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.4. Distributed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.4">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.4</seealso>
    let ``I.6.8.4`` = Prefixed_Name(acm, "I.6.8.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.5. Gaming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.5">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.5</seealso>
    let ``I.6.8.5`` = Prefixed_Name(acm, "I.6.8.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.6. Monte Carlo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.6">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.6</seealso>
    let ``I.6.8.6`` = Prefixed_Name(acm, "I.6.8.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.7. Parallel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.7">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.7</seealso>
    let ``I.6.8.7`` = Prefixed_Name(acm, "I.6.8.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.8.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.8.8. Visual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.8">http://acm.rkbexplorer.com/ontologies/acm#I.6.8.8</seealso>
    let ``I.6.8.8`` = Prefixed_Name(acm, "I.6.8.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.6.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.6.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.6.m">http://acm.rkbexplorer.com/ontologies/acm#I.6.m</seealso>
    let ``I.6.m`` = Prefixed_Name(acm, "I.6.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #H.4, #H.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.7. DOCUMENT AND TEXT PROCESSING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7">http://acm.rkbexplorer.com/ontologies/acm#I.7</seealso>
    let ``I.7`` = Prefixed_Name(acm, "I.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.0</seealso>
    let ``I.7.0`` = Prefixed_Name(acm, "I.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.1. Document and Text Editing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.1</seealso>
    let ``I.7.1`` = Prefixed_Name(acm, "I.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.1.0. Document management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.0</seealso>
    let ``I.7.1.0`` = Prefixed_Name(acm, "I.7.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.7.1.1. Languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.1</seealso>
    let ``I.7.1.1`` = Prefixed_Name(acm, "I.7.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.7.1.2. Spelling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.2</seealso>
    let ``I.7.1.2`` = Prefixed_Name(acm, "I.7.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.1.3. Version control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.1.3</seealso>
    let ``I.7.1.3`` = Prefixed_Name(acm, "I.7.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2. Document Preparation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.2</seealso>
    let ``I.7.2`` = Prefixed_Name(acm, "I.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.0. Desktop publishing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.0</seealso>
    let ``I.7.2.0`` = Prefixed_Name(acm, "I.7.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.1. Format and notation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.1</seealso>
    let ``I.7.2.1`` = Prefixed_Name(acm, "I.7.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.2. Hypertext/hypermedia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.2</seealso>
    let ``I.7.2.2`` = Prefixed_Name(acm, "I.7.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.3. Index generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.3</seealso>
    let ``I.7.2.3`` = Prefixed_Name(acm, "I.7.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.4. Languages and systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.4">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.4</seealso>
    let ``I.7.2.4`` = Prefixed_Name(acm, "I.7.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.5. Markup languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.5">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.5</seealso>
    let ``I.7.2.5`` = Prefixed_Name(acm, "I.7.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.6. Multi/mixed media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.6">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.6</seealso>
    let ``I.7.2.6`` = Prefixed_Name(acm, "I.7.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.7. Photocomposition/typesetting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.7">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.7</seealso>
    let ``I.7.2.7`` = Prefixed_Name(acm, "I.7.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.8. Scripting languages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.8">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.8</seealso>
    let ``I.7.2.8`` = Prefixed_Name(acm, "I.7.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.2.9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.2.9. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.9">http://acm.rkbexplorer.com/ontologies/acm#I.7.2.9</seealso>
    let ``I.7.2.9`` = Prefixed_Name(acm, "I.7.2.9") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.7.3. Index Generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.3</seealso>
    let ``I.7.3`` = Prefixed_Name(acm, "I.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #H.5.4, #J.7, #I.4.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"I.7.4. Electronic Publishing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4">http://acm.rkbexplorer.com/ontologies/acm#I.7.4</seealso>
    let ``I.7.4`` = Prefixed_Name(acm, "I.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.4.0. Document analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.0">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.0</seealso>
    let ``I.7.4.0`` = Prefixed_Name(acm, "I.7.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.4.1. Graphics recognition and interpretation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.1">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.1</seealso>
    let ``I.7.4.1`` = Prefixed_Name(acm, "I.7.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.4.2. Optical character recognition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.2">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.2</seealso>
    let ``I.7.4.2`` = Prefixed_Name(acm, "I.7.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.4.3. Scanning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.3">http://acm.rkbexplorer.com/ontologies/acm#I.7.4.3</seealso>
    let ``I.7.4.3`` = Prefixed_Name(acm, "I.7.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.7.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.7.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.7.m">http://acm.rkbexplorer.com/ontologies/acm#I.7.m</seealso>
    let ``I.7.m`` = Prefixed_Name(acm, "I.7.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:I.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"I.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#I.m">http://acm.rkbexplorer.com/ontologies/acm#I.m</seealso>
    let ``I.m`` = Prefixed_Name(acm, "I.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:J</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J. Computer Applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J">http://acm.rkbexplorer.com/ontologies/acm#J</seealso>
    let J = Prefixed_Name(acm, "J") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.0">http://acm.rkbexplorer.com/ontologies/acm#J.0</seealso>
    let ``J.0`` = Prefixed_Name(acm, "J.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1. ADMINISTRATIVE DATA PROCESSING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1">http://acm.rkbexplorer.com/ontologies/acm#J.1</seealso>
    let ``J.1`` = Prefixed_Name(acm, "J.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.0. Business"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.0">http://acm.rkbexplorer.com/ontologies/acm#J.1.0</seealso>
    let ``J.1.0`` = Prefixed_Name(acm, "J.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.1. Education"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.1">http://acm.rkbexplorer.com/ontologies/acm#J.1.1</seealso>
    let ``J.1.1`` = Prefixed_Name(acm, "J.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.2. Financial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.2">http://acm.rkbexplorer.com/ontologies/acm#J.1.2</seealso>
    let ``J.1.2`` = Prefixed_Name(acm, "J.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.3. Government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.3">http://acm.rkbexplorer.com/ontologies/acm#J.1.3</seealso>
    let ``J.1.3`` = Prefixed_Name(acm, "J.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.4. Law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.4">http://acm.rkbexplorer.com/ontologies/acm#J.1.4</seealso>
    let ``J.1.4`` = Prefixed_Name(acm, "J.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.5. Manufacturing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.5">http://acm.rkbexplorer.com/ontologies/acm#J.1.5</seealso>
    let ``J.1.5`` = Prefixed_Name(acm, "J.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.6. Marketing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.6">http://acm.rkbexplorer.com/ontologies/acm#J.1.6</seealso>
    let ``J.1.6`` = Prefixed_Name(acm, "J.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.1.7. Military"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.1.7">http://acm.rkbexplorer.com/ontologies/acm#J.1.7</seealso>
    let ``J.1.7`` = Prefixed_Name(acm, "J.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2. PHYSICAL SCIENCES AND ENGINEERING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2">http://acm.rkbexplorer.com/ontologies/acm#J.2</seealso>
    let ``J.2`` = Prefixed_Name(acm, "J.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.0. Aerospace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.0">http://acm.rkbexplorer.com/ontologies/acm#J.2.0</seealso>
    let ``J.2.0`` = Prefixed_Name(acm, "J.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.1. Archaeology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.1">http://acm.rkbexplorer.com/ontologies/acm#J.2.1</seealso>
    let ``J.2.1`` = Prefixed_Name(acm, "J.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.2. Astronomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.2">http://acm.rkbexplorer.com/ontologies/acm#J.2.2</seealso>
    let ``J.2.2`` = Prefixed_Name(acm, "J.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.3. Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.3">http://acm.rkbexplorer.com/ontologies/acm#J.2.3</seealso>
    let ``J.2.3`` = Prefixed_Name(acm, "J.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.4. Earth and atmospheric sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.4">http://acm.rkbexplorer.com/ontologies/acm#J.2.4</seealso>
    let ``J.2.4`` = Prefixed_Name(acm, "J.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.5. Electronics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.5">http://acm.rkbexplorer.com/ontologies/acm#J.2.5</seealso>
    let ``J.2.5`` = Prefixed_Name(acm, "J.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.6. Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.6">http://acm.rkbexplorer.com/ontologies/acm#J.2.6</seealso>
    let ``J.2.6`` = Prefixed_Name(acm, "J.2.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.7. Mathematics and statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.7">http://acm.rkbexplorer.com/ontologies/acm#J.2.7</seealso>
    let ``J.2.7`` = Prefixed_Name(acm, "J.2.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.2.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.2.8. Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.2.8">http://acm.rkbexplorer.com/ontologies/acm#J.2.8</seealso>
    let ``J.2.8`` = Prefixed_Name(acm, "J.2.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.3. LIFE AND MEDICAL SCIENCES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3">http://acm.rkbexplorer.com/ontologies/acm#J.3</seealso>
    let ``J.3`` = Prefixed_Name(acm, "J.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.3.0. Biology and genetics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3.0">http://acm.rkbexplorer.com/ontologies/acm#J.3.0</seealso>
    let ``J.3.0`` = Prefixed_Name(acm, "J.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.3.1. Health"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3.1">http://acm.rkbexplorer.com/ontologies/acm#J.3.1</seealso>
    let ``J.3.1`` = Prefixed_Name(acm, "J.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.3.2. Medical information systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.3.2">http://acm.rkbexplorer.com/ontologies/acm#J.3.2</seealso>
    let ``J.3.2`` = Prefixed_Name(acm, "J.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.4. SOCIAL AND BEHAVIORAL SCIENCES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4">http://acm.rkbexplorer.com/ontologies/acm#J.4</seealso>
    let ``J.4`` = Prefixed_Name(acm, "J.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.4.0. Economics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4.0">http://acm.rkbexplorer.com/ontologies/acm#J.4.0</seealso>
    let ``J.4.0`` = Prefixed_Name(acm, "J.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.4.1. Psychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4.1">http://acm.rkbexplorer.com/ontologies/acm#J.4.1</seealso>
    let ``J.4.1`` = Prefixed_Name(acm, "J.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.4.2. Sociology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.4.2">http://acm.rkbexplorer.com/ontologies/acm#J.4.2</seealso>
    let ``J.4.2`` = Prefixed_Name(acm, "J.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5. ARTS AND HUMANITIES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5">http://acm.rkbexplorer.com/ontologies/acm#J.5</seealso>
    let ``J.5`` = Prefixed_Name(acm, "J.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5.0. Architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.0">http://acm.rkbexplorer.com/ontologies/acm#J.5.0</seealso>
    let ``J.5.0`` = Prefixed_Name(acm, "J.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J.5.1. Arts, fine and performing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.1">http://acm.rkbexplorer.com/ontologies/acm#J.5.1</seealso>
    let ``J.5.1`` = Prefixed_Name(acm, "J.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5.2. Fine arts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.2">http://acm.rkbexplorer.com/ontologies/acm#J.5.2</seealso>
    let ``J.5.2`` = Prefixed_Name(acm, "J.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5.3. Language translation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.3">http://acm.rkbexplorer.com/ontologies/acm#J.5.3</seealso>
    let ``J.5.3`` = Prefixed_Name(acm, "J.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5.4. Linguistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.4">http://acm.rkbexplorer.com/ontologies/acm#J.5.4</seealso>
    let ``J.5.4`` = Prefixed_Name(acm, "J.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5.5. Literature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.5">http://acm.rkbexplorer.com/ontologies/acm#J.5.5</seealso>
    let ``J.5.5`` = Prefixed_Name(acm, "J.5.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J.5.6. Music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.6">http://acm.rkbexplorer.com/ontologies/acm#J.5.6</seealso>
    let ``J.5.6`` = Prefixed_Name(acm, "J.5.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.5.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.5.7. Performing arts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.5.7">http://acm.rkbexplorer.com/ontologies/acm#J.5.7</seealso>
    let ``J.5.7`` = Prefixed_Name(acm, "J.5.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.6. COMPUTER-AIDED ENGINEERING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.6">http://acm.rkbexplorer.com/ontologies/acm#J.6</seealso>
    let ``J.6`` = Prefixed_Name(acm, "J.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.6.0. Computer-aided design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.6.0">http://acm.rkbexplorer.com/ontologies/acm#J.6.0</seealso>
    let ``J.6.0`` = Prefixed_Name(acm, "J.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.6.1. Computer-aided manufacturing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.6.1">http://acm.rkbexplorer.com/ontologies/acm#J.6.1</seealso>
    let ``J.6.1`` = Prefixed_Name(acm, "J.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #C.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J.7. COMPUTERS IN OTHER SYSTEMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7">http://acm.rkbexplorer.com/ontologies/acm#J.7</seealso>
    let ``J.7`` = Prefixed_Name(acm, "J.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.0. Command and control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.0">http://acm.rkbexplorer.com/ontologies/acm#J.7.0</seealso>
    let ``J.7.0`` = Prefixed_Name(acm, "J.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.1. Consumer products"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.1">http://acm.rkbexplorer.com/ontologies/acm#J.7.1</seealso>
    let ``J.7.1`` = Prefixed_Name(acm, "J.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.2. Industrial control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.2">http://acm.rkbexplorer.com/ontologies/acm#J.7.2</seealso>
    let ``J.7.2`` = Prefixed_Name(acm, "J.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.3. Military"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.3">http://acm.rkbexplorer.com/ontologies/acm#J.7.3</seealso>
    let ``J.7.3`` = Prefixed_Name(acm, "J.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.4. Process control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.4">http://acm.rkbexplorer.com/ontologies/acm#J.7.4</seealso>
    let ``J.7.4`` = Prefixed_Name(acm, "J.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.5. Publishing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.5">http://acm.rkbexplorer.com/ontologies/acm#J.7.5</seealso>
    let ``J.7.5`` = Prefixed_Name(acm, "J.7.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.7.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.7.6. Real time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.7.6">http://acm.rkbexplorer.com/ontologies/acm#J.7.6</seealso>
    let ``J.7.6`` = Prefixed_Name(acm, "J.7.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:J.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"J.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#J.m">http://acm.rkbexplorer.com/ontologies/acm#J.m</seealso>
    let ``J.m`` = Prefixed_Name(acm, "J.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K. Computing Milieux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K">http://acm.rkbexplorer.com/ontologies/acm#K</seealso>
    let K = Prefixed_Name(acm, "K") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.0. GENERAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.0">http://acm.rkbexplorer.com/ontologies/acm#K.0</seealso>
    let ``K.0`` = Prefixed_Name(acm, "K.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.1. THE COMPUTER INDUSTRY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1">http://acm.rkbexplorer.com/ontologies/acm#K.1</seealso>
    let ``K.1`` = Prefixed_Name(acm, "K.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.1.0. Markets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.1.0</seealso>
    let ``K.1.0`` = Prefixed_Name(acm, "K.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.1.1. Standards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.1.1</seealso>
    let ``K.1.1`` = Prefixed_Name(acm, "K.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.1.2. Statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.1.2</seealso>
    let ``K.1.2`` = Prefixed_Name(acm, "K.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.1.3. Suppliers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.1.3</seealso>
    let ``K.1.3`` = Prefixed_Name(acm, "K.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.2. HISTORY OF COMPUTING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2">http://acm.rkbexplorer.com/ontologies/acm#K.2</seealso>
    let ``K.2`` = Prefixed_Name(acm, "K.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.2.0. Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.2.0</seealso>
    let ``K.2.0`` = Prefixed_Name(acm, "K.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.2.1. People"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.2.1</seealso>
    let ``K.2.1`` = Prefixed_Name(acm, "K.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.2.2. Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.2.2</seealso>
    let ``K.2.2`` = Prefixed_Name(acm, "K.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.2.3. Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.2.3</seealso>
    let ``K.2.3`` = Prefixed_Name(acm, "K.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.2.4. Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.2.4">http://acm.rkbexplorer.com/ontologies/acm#K.2.4</seealso>
    let ``K.2.4`` = Prefixed_Name(acm, "K.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3. COMPUTERS AND EDUCATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3">http://acm.rkbexplorer.com/ontologies/acm#K.3</seealso>
    let ``K.3`` = Prefixed_Name(acm, "K.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.0</seealso>
    let ``K.3.0`` = Prefixed_Name(acm, "K.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.1. Computer Uses in Education"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.1</seealso>
    let ``K.3.1`` = Prefixed_Name(acm, "K.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.1.0. Collaborative learning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.0</seealso>
    let ``K.3.1.0`` = Prefixed_Name(acm, "K.3.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.1.1. Computer-assisted instruction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.1</seealso>
    let ``K.3.1.1`` = Prefixed_Name(acm, "K.3.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.1.2. Computer-managed instruction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.2</seealso>
    let ``K.3.1.2`` = Prefixed_Name(acm, "K.3.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.1.3. Distance learning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.3.1.3</seealso>
    let ``K.3.1.3`` = Prefixed_Name(acm, "K.3.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2. Computer and Information Science Education"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2">http://acm.rkbexplorer.com/ontologies/acm#K.3.2</seealso>
    let ``K.3.2`` = Prefixed_Name(acm, "K.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2.0. Accreditation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.0</seealso>
    let ``K.3.2.0`` = Prefixed_Name(acm, "K.3.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2.1. Computer science education"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.1</seealso>
    let ``K.3.2.1`` = Prefixed_Name(acm, "K.3.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2.2. Curriculum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.2</seealso>
    let ``K.3.2.2`` = Prefixed_Name(acm, "K.3.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2.3. Information systems education"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.3</seealso>
    let ``K.3.2.3`` = Prefixed_Name(acm, "K.3.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2.4. Literacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.4">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.4</seealso>
    let ``K.3.2.4`` = Prefixed_Name(acm, "K.3.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.2.5. Self-assessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.5">http://acm.rkbexplorer.com/ontologies/acm#K.3.2.5</seealso>
    let ``K.3.2.5`` = Prefixed_Name(acm, "K.3.2.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.3.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m">http://acm.rkbexplorer.com/ontologies/acm#K.3.m</seealso>
    let ``K.3.m`` = Prefixed_Name(acm, "K.3.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.3.m.0. Accreditation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.3.m.0</seealso>
    let ``K.3.m.0`` = Prefixed_Name(acm, "K.3.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.3.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.3.m.1. Computer literacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.3.m.1</seealso>
    let ``K.3.m.1`` = Prefixed_Name(acm, "K.3.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4. COMPUTERS AND SOCIETY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4">http://acm.rkbexplorer.com/ontologies/acm#K.4</seealso>
    let ``K.4`` = Prefixed_Name(acm, "K.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.0</seealso>
    let ``K.4.0`` = Prefixed_Name(acm, "K.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1. Public Policy Issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.1</seealso>
    let ``K.4.1`` = Prefixed_Name(acm, "K.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.0. Abuse and crime involving computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.0</seealso>
    let ``K.4.1.0`` = Prefixed_Name(acm, "K.4.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.1. Computer-related health issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.1</seealso>
    let ``K.4.1.1`` = Prefixed_Name(acm, "K.4.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.2. Ethics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.2</seealso>
    let ``K.4.1.2`` = Prefixed_Name(acm, "K.4.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.3. Human safety"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.3</seealso>
    let ``K.4.1.3`` = Prefixed_Name(acm, "K.4.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.4. Intellectual property rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.4</seealso>
    let ``K.4.1.4`` = Prefixed_Name(acm, "K.4.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.5. Privacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.5">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.5</seealso>
    let ``K.4.1.5`` = Prefixed_Name(acm, "K.4.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.6. Regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.6">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.6</seealso>
    let ``K.4.1.6`` = Prefixed_Name(acm, "K.4.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.7. Transborder data flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.7">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.7</seealso>
    let ``K.4.1.7`` = Prefixed_Name(acm, "K.4.1.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.1.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.1.8. Use/abuse of power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.8">http://acm.rkbexplorer.com/ontologies/acm#K.4.1.8</seealso>
    let ``K.4.1.8`` = Prefixed_Name(acm, "K.4.1.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.2. Social Issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.2</seealso>
    let ``K.4.2`` = Prefixed_Name(acm, "K.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.4.2.0. Abuse and crime involving computers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.0</seealso>
    let ``K.4.2.0`` = Prefixed_Name(acm, "K.4.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.2.1. Assistive technologies for persons with disabilities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.1</seealso>
    let ``K.4.2.1`` = Prefixed_Name(acm, "K.4.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.2.2. Employment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.2</seealso>
    let ``K.4.2.2`` = Prefixed_Name(acm, "K.4.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.4.2.3. Handicapped persons/special needs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.2.3</seealso>
    let ``K.4.2.3`` = Prefixed_Name(acm, "K.4.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.3. Organizational Impacts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.3</seealso>
    let ``K.4.3`` = Prefixed_Name(acm, "K.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.3.0. Automation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.0</seealso>
    let ``K.4.3.0`` = Prefixed_Name(acm, "K.4.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.3.1. Computer-supported collaborative work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.1</seealso>
    let ``K.4.3.1`` = Prefixed_Name(acm, "K.4.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.3.2. Employment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.2</seealso>
    let ``K.4.3.2`` = Prefixed_Name(acm, "K.4.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.3.3. Reengineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.3.3</seealso>
    let ``K.4.3.3`` = Prefixed_Name(acm, "K.4.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #J.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.4.4. Electronic Commerce"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4">http://acm.rkbexplorer.com/ontologies/acm#K.4.4</seealso>
    let ``K.4.4`` = Prefixed_Name(acm, "K.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.4.0. Cybercash, digital cash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.0</seealso>
    let ``K.4.4.0`` = Prefixed_Name(acm, "K.4.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.4.1. Distributed commercial transactions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.1</seealso>
    let ``K.4.4.1`` = Prefixed_Name(acm, "K.4.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.4.2. Electronic data interchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.2</seealso>
    let ``K.4.4.2`` = Prefixed_Name(acm, "K.4.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.4.3. Intellectual property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.3">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.3</seealso>
    let ``K.4.4.3`` = Prefixed_Name(acm, "K.4.4.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.4.4. Payment schemes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.4">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.4</seealso>
    let ``K.4.4.4`` = Prefixed_Name(acm, "K.4.4.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.4.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.4.5. Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.5">http://acm.rkbexplorer.com/ontologies/acm#K.4.4.5</seealso>
    let ``K.4.4.5`` = Prefixed_Name(acm, "K.4.4.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.4.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.4.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.4.m">http://acm.rkbexplorer.com/ontologies/acm#K.4.m</seealso>
    let ``K.4.m`` = Prefixed_Name(acm, "K.4.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5. LEGAL ASPECTS OF COMPUTING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5">http://acm.rkbexplorer.com/ontologies/acm#K.5</seealso>
    let ``K.5`` = Prefixed_Name(acm, "K.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.0</seealso>
    let ``K.5.0`` = Prefixed_Name(acm, "K.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.1. Hardware/Software Protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.1</seealso>
    let ``K.5.1`` = Prefixed_Name(acm, "K.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.1.0. Copyrights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.0</seealso>
    let ``K.5.1.0`` = Prefixed_Name(acm, "K.5.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.1.1. Licensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.1</seealso>
    let ``K.5.1.1`` = Prefixed_Name(acm, "K.5.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.1.2. Patents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.2</seealso>
    let ``K.5.1.2`` = Prefixed_Name(acm, "K.5.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.1.3. Proprietary rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.3</seealso>
    let ``K.5.1.3`` = Prefixed_Name(acm, "K.5.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.5.1.4. Trade secrets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.5.1.4</seealso>
    let ``K.5.1.4`` = Prefixed_Name(acm, "K.5.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.2. Governmental Issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2">http://acm.rkbexplorer.com/ontologies/acm#K.5.2</seealso>
    let ``K.5.2`` = Prefixed_Name(acm, "K.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.2.0. Censorship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.2.0</seealso>
    let ``K.5.2.0`` = Prefixed_Name(acm, "K.5.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.2.1. Regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.2.1</seealso>
    let ``K.5.2.1`` = Prefixed_Name(acm, "K.5.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.2.2. Taxation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.5.2.2</seealso>
    let ``K.5.2.2`` = Prefixed_Name(acm, "K.5.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.5.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m">http://acm.rkbexplorer.com/ontologies/acm#K.5.m</seealso>
    let ``K.5.m`` = Prefixed_Name(acm, "K.5.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.5.m.0. Contracts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.5.m.0</seealso>
    let ``K.5.m.0`` = Prefixed_Name(acm, "K.5.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.5.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.5.m.1. Hardware patents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.5.m.1</seealso>
    let ``K.5.m.1`` = Prefixed_Name(acm, "K.5.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6. MANAGEMENT OF COMPUTING AND INFORMATION SYSTEMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6">http://acm.rkbexplorer.com/ontologies/acm#K.6</seealso>
    let ``K.6`` = Prefixed_Name(acm, "K.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.0</seealso>
    let ``K.6.0`` = Prefixed_Name(acm, "K.6.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.0.0. Economics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.0.0</seealso>
    let ``K.6.0.0`` = Prefixed_Name(acm, "K.6.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1. Project and People Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.1</seealso>
    let ``K.6.1`` = Prefixed_Name(acm, "K.6.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.0. Life cycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.0</seealso>
    let ``K.6.1.0`` = Prefixed_Name(acm, "K.6.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.1. Management techniques"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.1</seealso>
    let ``K.6.1.1`` = Prefixed_Name(acm, "K.6.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.2. Staffing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.2</seealso>
    let ``K.6.1.2`` = Prefixed_Name(acm, "K.6.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.3. Strategic information systems planning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.3</seealso>
    let ``K.6.1.3`` = Prefixed_Name(acm, "K.6.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.4. Systems analysis and design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.4</seealso>
    let ``K.6.1.4`` = Prefixed_Name(acm, "K.6.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.5. Systems development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.5">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.5</seealso>
    let ``K.6.1.5`` = Prefixed_Name(acm, "K.6.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.1.6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.1.6. Training"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.6">http://acm.rkbexplorer.com/ontologies/acm#K.6.1.6</seealso>
    let ``K.6.1.6`` = Prefixed_Name(acm, "K.6.1.6") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.2. Installation Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.2</seealso>
    let ``K.6.2`` = Prefixed_Name(acm, "K.6.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.2.0. Benchmarks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.0</seealso>
    let ``K.6.2.0`` = Prefixed_Name(acm, "K.6.2.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.2.1. Computer selection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.1</seealso>
    let ``K.6.2.1`` = Prefixed_Name(acm, "K.6.2.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.2.2. Computing equipment management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.2</seealso>
    let ``K.6.2.2`` = Prefixed_Name(acm, "K.6.2.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.2.3. Performance and usage measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.3</seealso>
    let ``K.6.2.3`` = Prefixed_Name(acm, "K.6.2.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.2.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.2.4. Pricing and resource allocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.2.4</seealso>
    let ``K.6.2.4`` = Prefixed_Name(acm, "K.6.2.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.2.9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.6.3. Software Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.3</seealso>
    let ``K.6.3`` = Prefixed_Name(acm, "K.6.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.3.0. Software development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.0</seealso>
    let ``K.6.3.0`` = Prefixed_Name(acm, "K.6.3.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.3.1. Software maintenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.1</seealso>
    let ``K.6.3.1`` = Prefixed_Name(acm, "K.6.3.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.3.2. Software process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.2</seealso>
    let ``K.6.3.2`` = Prefixed_Name(acm, "K.6.3.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.3.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.3.3. Software selection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.3.3</seealso>
    let ``K.6.3.3`` = Prefixed_Name(acm, "K.6.3.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.4. System Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.4</seealso>
    let ``K.6.4`` = Prefixed_Name(acm, "K.6.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.4.0. Centralization/decentralization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.4.0</seealso>
    let ``K.6.4.0`` = Prefixed_Name(acm, "K.6.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.4.1. Management audit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.4.1</seealso>
    let ``K.6.4.1`` = Prefixed_Name(acm, "K.6.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.4.2. Quality assurance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.4.2</seealso>
    let ``K.6.4.2`` = Prefixed_Name(acm, "K.6.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #D.4.6, #K.4.2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.6.5. Security and Protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5">http://acm.rkbexplorer.com/ontologies/acm#K.6.5</seealso>
    let ``K.6.5`` = Prefixed_Name(acm, "K.6.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.5.0. Authentication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.0</seealso>
    let ``K.6.5.0`` = Prefixed_Name(acm, "K.6.5.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1991."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.6.5.1. Insurance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.1</seealso>
    let ``K.6.5.1`` = Prefixed_Name(acm, "K.6.5.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.5.2. Invasive software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.2">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.2</seealso>
    let ``K.6.5.2`` = Prefixed_Name(acm, "K.6.5.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.6.5.3. Physical security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.3">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.3</seealso>
    let ``K.6.5.3`` = Prefixed_Name(acm, "K.6.5.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.5.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.5.4. Unauthorized access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.4">http://acm.rkbexplorer.com/ontologies/acm#K.6.5.4</seealso>
    let ``K.6.5.4`` = Prefixed_Name(acm, "K.6.5.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.6.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m">http://acm.rkbexplorer.com/ontologies/acm#K.6.m</seealso>
    let ``K.6.m`` = Prefixed_Name(acm, "K.6.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1991."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.6.m.0. Insurance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.6.m.0</seealso>
    let ``K.6.m.0`` = Prefixed_Name(acm, "K.6.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.6.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1991."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.6.m.1. Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.6.m.1</seealso>
    let ``K.6.m.1`` = Prefixed_Name(acm, "K.6.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7. THE COMPUTING PROFESSION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7">http://acm.rkbexplorer.com/ontologies/acm#K.7</seealso>
    let ``K.7`` = Prefixed_Name(acm, "K.7") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.0">http://acm.rkbexplorer.com/ontologies/acm#K.7.0</seealso>
    let ``K.7.0`` = Prefixed_Name(acm, "K.7.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.1. Occupations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.1">http://acm.rkbexplorer.com/ontologies/acm#K.7.1</seealso>
    let ``K.7.1`` = Prefixed_Name(acm, "K.7.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.2. Organizations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.2">http://acm.rkbexplorer.com/ontologies/acm#K.7.2</seealso>
    let ``K.7.2`` = Prefixed_Name(acm, "K.7.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.3. Testing, Certification, and Licensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.3">http://acm.rkbexplorer.com/ontologies/acm#K.7.3</seealso>
    let ``K.7.3`` = Prefixed_Name(acm, "K.7.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See also #K.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.7.4. Professional Ethics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4">http://acm.rkbexplorer.com/ontologies/acm#K.7.4</seealso>
    let ``K.7.4`` = Prefixed_Name(acm, "K.7.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.4.0. Codes of ethics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.0">http://acm.rkbexplorer.com/ontologies/acm#K.7.4.0</seealso>
    let ``K.7.4.0`` = Prefixed_Name(acm, "K.7.4.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.4.1. Codes of good practice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.1">http://acm.rkbexplorer.com/ontologies/acm#K.7.4.1</seealso>
    let ``K.7.4.1`` = Prefixed_Name(acm, "K.7.4.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.4.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.4.2. Ethical dilemmas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.2">http://acm.rkbexplorer.com/ontologies/acm#K.7.4.2</seealso>
    let ``K.7.4.2`` = Prefixed_Name(acm, "K.7.4.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.7.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m">http://acm.rkbexplorer.com/ontologies/acm#K.7.m</seealso>
    let ``K.7.m`` = Prefixed_Name(acm, "K.7.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.m.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.7.m.0. Codes of good practice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.0">http://acm.rkbexplorer.com/ontologies/acm#K.7.m.0</seealso>
    let ``K.7.m.0`` = Prefixed_Name(acm, "K.7.m.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.7.m.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1998."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.7.m.1. Ethics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.1">http://acm.rkbexplorer.com/ontologies/acm#K.7.m.1</seealso>
    let ``K.7.m.1`` = Prefixed_Name(acm, "K.7.m.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8. PERSONAL COMPUTING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8">http://acm.rkbexplorer.com/ontologies/acm#K.8</seealso>
    let ``K.8`` = Prefixed_Name(acm, "K.8") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depricated, no longer used as of January 1991."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"K.8.0. General"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"K.8.0. Games"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0">http://acm.rkbexplorer.com/ontologies/acm#K.8.0</seealso>
    let ``K.8.0`` = Prefixed_Name(acm, "K.8.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.0.0. Games"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0.0">http://acm.rkbexplorer.com/ontologies/acm#K.8.0.0</seealso>
    let ``K.8.0.0`` = Prefixed_Name(acm, "K.8.0.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1. Application Packages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1">http://acm.rkbexplorer.com/ontologies/acm#K.8.1</seealso>
    let ``K.8.1`` = Prefixed_Name(acm, "K.8.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1.0. Data communications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.0">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.0</seealso>
    let ``K.8.1.0`` = Prefixed_Name(acm, "K.8.1.0") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1.1. Database processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.1">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.1</seealso>
    let ``K.8.1.1`` = Prefixed_Name(acm, "K.8.1.1") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1.2. Freeware/shareware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.2">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.2</seealso>
    let ``K.8.1.2`` = Prefixed_Name(acm, "K.8.1.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1.3. Graphics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.3">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.3</seealso>
    let ``K.8.1.3`` = Prefixed_Name(acm, "K.8.1.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1.4. Spreadsheets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.4">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.4</seealso>
    let ``K.8.1.4`` = Prefixed_Name(acm, "K.8.1.4") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.1.5. Word processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.5">http://acm.rkbexplorer.com/ontologies/acm#K.8.1.5</seealso>
    let ``K.8.1.5`` = Prefixed_Name(acm, "K.8.1.5") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.2. Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.2">http://acm.rkbexplorer.com/ontologies/acm#K.8.2</seealso>
    let ``K.8.2`` = Prefixed_Name(acm, "K.8.2") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.3. Management/Maintenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.3">http://acm.rkbexplorer.com/ontologies/acm#K.8.3</seealso>
    let ``K.8.3`` = Prefixed_Name(acm, "K.8.3") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.8.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.8.m. Miscellaneous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.8.m">http://acm.rkbexplorer.com/ontologies/acm#K.8.m</seealso>
    let ``K.8.m`` = Prefixed_Name(acm, "K.8.m") |> PrefixedName
    /// <summary>
    ///   <para>acm:K.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"K.m. MISCELLANEOUS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://acm.rkbexplorer.com/ontologies/acm#K.m">http://acm.rkbexplorer.com/ontologies/acm#K.m</seealso>
    let ``K.m`` = Prefixed_Name(acm, "K.m") |> PrefixedName
