namespace http.www.telegraphis.net.ontology.geography.geography.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geos =
    let _namespace_iri = Namespace_Iri geos |> NamespaceIRI
    /// <summary>
    ///   <para>geos:Continent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/geography/geography#Continent">http://www.telegraphis.net/ontology/geography/geography#Continent</seealso>
    let Continent = Prefixed_Name(geos, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>geos:officialLanguage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/geography/geography#officialLanguage">http://www.telegraphis.net/ontology/geography/geography#officialLanguage</seealso>
    let officialLanguage = Prefixed_Name(geos, "officialLanguage") |> PrefixedName
