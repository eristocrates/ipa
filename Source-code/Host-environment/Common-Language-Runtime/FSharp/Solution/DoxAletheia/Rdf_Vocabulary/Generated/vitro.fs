namespace http.vitro.mannlib.cornell.edu.ns.vitro._public.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vitro =
    let _namespace_iri = Namespace_Iri vitro |> NamespaceIRI
    /// <summary>
    ///   <para>vitro:File</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"File"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vitro.mannlib.cornell.edu/ns/vitro/public#File">http://vitro.mannlib.cornell.edu/ns/vitro/public#File</seealso>
    let File = Prefixed_Name(vitro, "File") |> PrefixedName
    /// <summary>
    ///   <para>vitro:FileByteStream</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"FileByteStream"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vitro.mannlib.cornell.edu/ns/vitro/public#FileByteStream">http://vitro.mannlib.cornell.edu/ns/vitro/public#FileByteStream</seealso>
    let FileByteStream = Prefixed_Name(vitro, "FileByteStream") |> PrefixedName
