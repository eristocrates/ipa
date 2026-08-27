namespace http.purl.org.emmedi.hico.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hico =
    let _namespace_iri = Namespace_Iri hico |> NamespaceIRI
    /// <summary>
    ///   <para>hico:2020-03-31</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/emmedi/hico/2020-03-31">http://purl.org/emmedi/hico/2020-03-31</seealso>
    let _2020_03_31 = Prefixed_Name(hico, "2020-03-31") |> PrefixedName
    /// <summary>
    ///   <para>hico:InterpretationAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/emmedi/hico/InterpretationAct">http://purl.org/emmedi/hico/InterpretationAct</seealso>
    let InterpretationAct = Prefixed_Name(hico, "InterpretationAct") |> PrefixedName
