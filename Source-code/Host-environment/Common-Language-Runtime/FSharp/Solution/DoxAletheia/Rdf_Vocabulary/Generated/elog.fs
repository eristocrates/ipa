namespace http.eulersharp.sourceforge.net._2003._03swap.log_rules.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module elog =
    let _namespace_iri = Namespace_Iri elog |> NamespaceIRI
    /// <summary>
    ///   <para>elog:Number</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/log-rules#Number">http://eulersharp.sourceforge.net/2003/03swap/log-rules#Number</seealso>
    let Number = Prefixed_Name(elog, "Number") |> PrefixedName
