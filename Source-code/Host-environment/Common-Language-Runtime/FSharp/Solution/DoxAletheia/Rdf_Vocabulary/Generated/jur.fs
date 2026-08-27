namespace http.sweet.jpl.nasa.gov._2._3.humanJurisdiction.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module jur =
    let _namespace_iri = Namespace_Iri jur |> NamespaceIRI
    /// <summary>
    ///   <para>jur:Country</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/humanJurisdiction.owl#Country">http://sweet.jpl.nasa.gov/2.3/humanJurisdiction.owl#Country</seealso>
    let Country = Prefixed_Name(jur, "Country") |> PrefixedName
