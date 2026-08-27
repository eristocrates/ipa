namespace http.www.ebi.ac.uk.efo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module efo =
    let _namespace_iri = Namespace_Iri efo |> NamespaceIRI
    /// <summary>
    ///   <para>efo:EFO_0004340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"body mass index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebi.ac.uk/efo/EFO_0004340">http://www.ebi.ac.uk/efo/EFO_0004340</seealso>
    let EFO_0004340 = Prefixed_Name(efo, "EFO_0004340") |> PrefixedName
    /// <summary>
    ///   <para>efo:EFO_0005935</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"overweight body mass index status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebi.ac.uk/efo/EFO_0005935">http://www.ebi.ac.uk/efo/EFO_0005935</seealso>
    let EFO_0005935 = Prefixed_Name(efo, "EFO_0005935") |> PrefixedName
    /// <summary>
    ///   <para>efo:EFO_0005936</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underweight body mass index status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebi.ac.uk/efo/EFO_0005936">http://www.ebi.ac.uk/efo/EFO_0005936</seealso>
    let EFO_0005936 = Prefixed_Name(efo, "EFO_0005936") |> PrefixedName
    /// <summary>
    ///   <para>efo:EFO_0007041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obese body mass index status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebi.ac.uk/efo/EFO_0007041">http://www.ebi.ac.uk/efo/EFO_0007041</seealso>
    let EFO_0007041 = Prefixed_Name(efo, "EFO_0007041") |> PrefixedName
    /// <summary>
    ///   <para>efo:swo/SWO_0000740</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebi.ac.uk/efo/swo/SWO_0000740">http://www.ebi.ac.uk/efo/swo/SWO_0000740</seealso>
    let ``swo/SWO_0000740`` = Prefixed_Name(efo, "swo/SWO_0000740") |> PrefixedName
    /// <summary>
    ///   <para>efo:swo/SWO_0000741</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is encoded in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebi.ac.uk/efo/swo/SWO_0000741">http://www.ebi.ac.uk/efo/swo/SWO_0000741</seealso>
    let ``swo/SWO_0000741`` = Prefixed_Name(efo, "swo/SWO_0000741") |> PrefixedName
