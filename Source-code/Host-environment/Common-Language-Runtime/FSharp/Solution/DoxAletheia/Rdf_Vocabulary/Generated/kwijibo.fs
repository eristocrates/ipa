namespace http.kwijibo.talis.com.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module kwijibo =
    let _namespace_iri = Namespace_Iri kwijibo |> NamespaceIRI
    /// <summary>
    ///   <para>kwijibo:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://kwijibo.talis.com/">http://kwijibo.talis.com/</seealso>
    let _prefix_iri = Prefixed_Name(kwijibo, "") |> PrefixedName
