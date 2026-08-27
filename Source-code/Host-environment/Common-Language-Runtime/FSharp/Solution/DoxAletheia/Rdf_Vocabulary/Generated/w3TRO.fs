namespace https.w3id.org.TRO.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3TRO =
    let _namespace_iri = Namespace_Iri w3TRO |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:TRO/0.1.3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/TRO/0.1.3">https://w3id.org/TRO/0.1.3</seealso>
    let ``_0.1.3`` = Prefixed_Name(w3TRO, "0.1.3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:TRO/IndividualContractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person that acts as a single contractor to other organizations, usually government organizations"</para>
    /// labels<para>"Individual contractor"</para></remarks>
    /// <seealso href="https://w3id.org/TRO/IndividualContractor">https://w3id.org/TRO/IndividualContractor</seealso>
    let IndividualContractor =
        Prefixed_Name(w3TRO, "IndividualContractor") |> PrefixedName
