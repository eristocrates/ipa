namespace http.rs.tdwg.org.dwc.iri.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dwciri =
    let _namespace_iri = Namespace_Iri dwciri |> NamespaceIRI
    /// <summary>
    ///   <para>dwciri:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/iri/">http://rs.tdwg.org/dwc/iri/</seealso>
    let _prefix_iri = Prefixed_Name(dwciri, "") |> PrefixedName
    /// <summary>
    ///   <para>dwciri:habitat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/iri/habitat">http://rs.tdwg.org/dwc/iri/habitat</seealso>
    let habitat = Prefixed_Name(dwciri, "habitat") |> PrefixedName
