namespace http.www.rddl.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rddl =
    let _namespace_iri = Namespace_Iri rddl |> NamespaceIRI
    /// <summary>
    ///   <para>rddl:nature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rddl.org/nature">http://www.rddl.org/nature</seealso>
    let nature = Prefixed_Name(rddl, "nature") |> PrefixedName

    /// <summary>
    ///   <para>rddl:purposes#normative-reference</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rddl.org/purposes#normative-reference">http://www.rddl.org/purposes#normative-reference</seealso>
    let ``purposes#normative_reference`` =
        Prefixed_Name(rddl, "purposes#normative-reference") |> PrefixedName
