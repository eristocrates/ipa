namespace http.purl.obolibrary.org.obo.VO_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vo =
    let _namespace_iri = Namespace_Iri vo |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:VO_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vaccine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/VO_0000001">http://purl.obolibrary.org/obo/VO_0000001</seealso>
    let vaccine = Prefixed_Name(vo, "0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:VO_0000002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vaccination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/VO_0000002">http://purl.obolibrary.org/obo/VO_0000002</seealso>
    let vaccination = Prefixed_Name(vo, "0000002") |> PrefixedName
