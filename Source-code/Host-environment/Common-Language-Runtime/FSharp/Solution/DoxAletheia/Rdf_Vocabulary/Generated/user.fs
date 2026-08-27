namespace http.schemas.talis.com._2005.user.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module user =
    let _namespace_iri = Namespace_Iri user |> NamespaceIRI
    /// <summary>
    ///   <para>user:User</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.talis.com/2005/user/schema#User">http://schemas.talis.com/2005/user/schema#User</seealso>
    let User = Prefixed_Name(user, "User") |> PrefixedName
