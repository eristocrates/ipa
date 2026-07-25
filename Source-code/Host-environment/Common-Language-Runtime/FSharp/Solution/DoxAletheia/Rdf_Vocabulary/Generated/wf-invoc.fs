namespace http.purl.org.net.wf_invocation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wf_invoc =
    let _namespace_iri = Namespace_Iri wf_invoc |> NamespaceIRI
    /// <summary>
    ///   <para>wf-invoc:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specialization of p-plan:Step in order to be able to assert domain specific properties. A wf-invoc:Step refers to those p-plan:Steps related to the scientific workflow invocation.</para>
    /// labels<para>Step</para></remarks>
    /// <seealso href="http://purl.org/net/wf-invocation#Step">http://purl.org/net/wf-invocation#Step</seealso>
    let Step = Prefixed_Name(wf_invoc, "Step") |> PrefixedName
    /// <summary>
    ///   <para>wf-invoc:hasDataBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data property used to bind a wf-invoc:Variable with the path or URL where the data is available for the execution.</para>
    /// labels<para>has Data Binding</para></remarks>
    /// <seealso href="http://purl.org/net/wf-invocation#hasDataBinding">http://purl.org/net/wf-invocation#hasDataBinding</seealso>
    let hasDataBinding = Prefixed_Name(wf_invoc, "hasDataBinding") |> PrefixedName
    /// <summary>
    ///   <para>wf-invoc:hasInvocationLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data property used to link a wf-invoc:Step with the Literal representing the invocation line of the current Step.</para>
    /// labels<para>has Invocation Line</para></remarks>
    /// <seealso href="http://purl.org/net/wf-invocation#hasInvocationLine">http://purl.org/net/wf-invocation#hasInvocationLine</seealso>
    let hasInvocationLine = Prefixed_Name(wf_invoc, "hasInvocationLine") |> PrefixedName
    /// <summary>
    ///   <para>wf-invoc:hasCodeBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/wf-invocation#hasCodeBinding">http://purl.org/net/wf-invocation#hasCodeBinding</seealso>
    let hasCodeBinding = Prefixed_Name(wf_invoc, "hasCodeBinding") |> PrefixedName
    /// <summary>
    ///   <para>wf-invoc:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specialization of p-plan:Variable in order to be able to assert specific properties. A wf-invoc:Variable refers to those p-plan:Variables related to the scientific workflow invocation.</para>
    /// labels<para>Variable</para></remarks>
    /// <seealso href="http://purl.org/net/wf-invocation#Variable">http://purl.org/net/wf-invocation#Variable</seealso>
    let Variable = Prefixed_Name(wf_invoc, "Variable") |> PrefixedName
    /// <summary>
    ///   <para>wf-invoc:hasCustomData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data property used to link a wf-invoc:Step with any particular metadata that will be used in the execution of the Step (e.g., environment requirements, memory, etc.)</para>
    /// labels<para>has Custom Data</para></remarks>
    /// <seealso href="http://purl.org/net/wf-invocation#hasCustomData">http://purl.org/net/wf-invocation#hasCustomData</seealso>
    let hasCustomData = Prefixed_Name(wf_invoc, "hasCustomData") |> PrefixedName
