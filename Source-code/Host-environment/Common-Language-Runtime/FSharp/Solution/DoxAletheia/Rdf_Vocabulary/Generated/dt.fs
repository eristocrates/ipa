namespace http.w3id.org.dt.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dt =
    let _namespace_iri = Namespace_Iri dt |> NamespaceIRI
    /// <summary>
    ///   <para>dt:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/dt#">http://w3id.org/dt#</seealso>
    let _prefix_iri = Prefixed_Name(dt, "") |> PrefixedName
