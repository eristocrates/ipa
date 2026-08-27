namespace http.protege.stanford.edu.system.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module protege =
    let _namespace_iri = Namespace_Iri protege |> NamespaceIRI
    /// <summary>
    ///   <para>protege:role</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://protege.stanford.edu/system#role">http://protege.stanford.edu/system#role</seealso>
    let role = Prefixed_Name(protege, "role") |> PrefixedName
