namespace http.purl.obolibrary.org.obo.GAZ_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gaz =
    let _namespace_iri = Namespace_Iri gaz |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:GAZ_00000448</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geographic location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GAZ_00000448">http://purl.obolibrary.org/obo/GAZ_00000448</seealso>
    let geographic_location = Prefixed_Name(gaz, "00000448") |> PrefixedName
