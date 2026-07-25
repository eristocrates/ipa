namespace http.purl.org.spar.frbr.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sparfrbr =
    let _namespace_iri = Namespace_Iri sparfrbr |> NamespaceIRI
    /// <summary>
    ///   <para>sparfrbr:2011-06-29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/frbr/2011-06-29">http://purl.org/spar/frbr/2011-06-29</seealso>
    let _2011_06_29 = Prefixed_Name(sparfrbr, "2011-06-29") |> PrefixedName
    /// <summary>
    ///   <para>sparfrbr:2018-03-29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/frbr/2018-03-29">http://purl.org/spar/frbr/2018-03-29</seealso>
    let _2018_03_29 = Prefixed_Name(sparfrbr, "2018-03-29") |> PrefixedName
