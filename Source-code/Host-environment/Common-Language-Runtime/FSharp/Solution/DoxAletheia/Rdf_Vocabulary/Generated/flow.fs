namespace http.www.w3.org._2005._01.wf.flow.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module flow =
    let _namespace_iri = Namespace_Iri flow |> NamespaceIRI
    /// <summary>
    ///   <para>flow:assignee</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2005/01/wf/flow#assignee">http://www.w3.org/2005/01/wf/flow#assignee</seealso>
    let assignee = Prefixed_Name(flow, "assignee") |> PrefixedName
    /// <summary>
    ///   <para>flow:dependent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2005/01/wf/flow#dependent">http://www.w3.org/2005/01/wf/flow#dependent</seealso>
    let dependent = Prefixed_Name(flow, "dependent") |> PrefixedName
