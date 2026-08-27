namespace http.eulersharp.sourceforge.net._2003._03swap.weekScheme.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapweekScheme =
    let _namespace_iri = Namespace_Iri swapweekScheme |> NamespaceIRI
    /// <summary>
    ///   <para>swapweekScheme:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Used in e.g. rules to calculate availbility knowing opening hours."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#</seealso>
    let _prefix_iri = Prefixed_Name(swapweekScheme, "") |> PrefixedName
    /// <summary>
    ///   <para>swapweekScheme:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"working day"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Day">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Day</seealso>
    let Day = Prefixed_Name(swapweekScheme, "Day") |> PrefixedName
    /// <summary>
    ///   <para>swapweekScheme:Duty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"duty"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Duty">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Duty</seealso>
    let Duty = Prefixed_Name(swapweekScheme, "Duty") |> PrefixedName
    /// <summary>
    ///   <para>swapweekScheme:hasDayEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayEnd">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayEnd</seealso>
    let hasDayEnd = Prefixed_Name(swapweekScheme, "hasDayEnd") |> PrefixedName
    /// <summary>
    ///   <para>swapweekScheme:hasDayStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayStart">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayStart</seealso>
    let hasDayStart = Prefixed_Name(swapweekScheme, "hasDayStart") |> PrefixedName
    /// <summary>
    ///   <para>swapweekScheme:hasDutyEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyEnd">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyEnd</seealso>
    let hasDutyEnd = Prefixed_Name(swapweekScheme, "hasDutyEnd") |> PrefixedName
    /// <summary>
    ///   <para>swapweekScheme:hasDutyStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyStart">http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyStart</seealso>
    let hasDutyStart = Prefixed_Name(swapweekScheme, "hasDutyStart") |> PrefixedName
