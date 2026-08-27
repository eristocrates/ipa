namespace http.purl.org.org.iode.po.voc.cruise_summary_reports.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module csr =
    let _namespace_iri = Namespace_Iri csr |> NamespaceIRI
    /// <summary>
    ///   <para>csr:CruiseSummaryReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/org/iode/po/voc/cruise-summary-reports#CruiseSummaryReport">http://purl.org/org/iode/po/voc/cruise-summary-reports#CruiseSummaryReport</seealso>
    let CruiseSummaryReport = Prefixed_Name(csr, "CruiseSummaryReport") |> PrefixedName
