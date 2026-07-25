namespace http.www.daml.org.services.owl_s._1._2.Process.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module damlProcess =
    let _namespace_iri = Namespace_Iri damlProcess |> NamespaceIRI
    /// <summary>
    ///   <para>damlProcess:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>
    ///     Upper-level OWL ontology for Processes.
    ///     Part of the DAML-S/OWL-S effort; see http://www.daml.org/services/owl-s/.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl">http://www.daml.org/services/owl-s/1.2/Process.owl</seealso>
    let _prefix_iri = Prefixed_Name(damlProcess, "") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ProcessComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Deprecated as of v. 1.1.
    ///     Note: the old concept ProcessComponent is no longer needed. ControlConstruct
    ///     which includes Perform as a subclass should be used anywhere that
    ///     ProcessComponent might have been used (which in the OWL-S 1.0 ontology
    ///     was only in describing the relationship to temporal aspects)
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ProcessComponent">http://www.daml.org/services/owl-s/1.2/Process.owl#ProcessComponent</seealso>
    let ``_#ProcessComponent`` =
        Prefixed_Name(damlProcess, "#ProcessComponent") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#Any-Order</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Any-Order">http://www.daml.org/services/owl-s/1.2/Process.owl#Any-Order</seealso>
    let ``_#Any_Order`` = Prefixed_Name(damlProcess, "#Any-Order") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#collapsesTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#collapsesTo">http://www.daml.org/services/owl-s/1.2/Process.owl#collapsesTo</seealso>
    let ``_#collapsesTo`` = Prefixed_Name(damlProcess, "#collapsesTo") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ConditionalOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Deprecated as of version 1.1 </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalOutput">http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalOutput</seealso>
    let ``_#ConditionalOutput`` =
        Prefixed_Name(damlProcess, "#ConditionalOutput") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ControlConstruct</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstruct">http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstruct</seealso>
    let ``_#ControlConstruct`` =
        Prefixed_Name(damlProcess, "#ControlConstruct") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#expandsTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#expandsTo">http://www.daml.org/services/owl-s/1.2/Process.owl#expandsTo</seealso>
    let ``_#expandsTo`` = Prefixed_Name(damlProcess, "#expandsTo") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#collapse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is a deprecated usage; collapsesTo is preferred.</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#collapse">http://www.daml.org/services/owl-s/1.2/Process.owl#collapse</seealso>
    let ``_#collapse`` = Prefixed_Name(damlProcess, "#collapse") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ConditionalEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Deprecated as of version 1.1 </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalEffect">http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalEffect</seealso>
    let ``_#ConditionalEffect`` =
        Prefixed_Name(damlProcess, "#ConditionalEffect") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#Unordered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///      Deprecated.  As of version 1.1, renamed to Any-Order.
    ///   </para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Unordered">http://www.daml.org/services/owl-s/1.2/Process.owl#Unordered</seealso>
    let ``_#Unordered`` = Prefixed_Name(damlProcess, "#Unordered") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#expand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is a deprecated usage; expandsTo is preferred.</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#expand">http://www.daml.org/services/owl-s/1.2/Process.owl#expand</seealso>
    let ``_#expand`` = Prefixed_Name(damlProcess, "#expand") |> PrefixedName
