namespace http.ncicb.nci.nih.gov.xml.owl.EVS.Thesaurus.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ncicp =
    let _namespace_iri = Namespace_Iri ncicp |> NamespaceIRI
    /// <summary>
    ///   <para>ncicp:C113497</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ncicb.nci.nih.gov/xml/owl/EVS/Thesaurus.owl#C113497">http://ncicb.nci.nih.gov/xml/owl/EVS/Thesaurus.owl#C113497</seealso>
    let C113497 = Prefixed_Name(ncicp, "C113497") |> PrefixedName
