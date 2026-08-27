namespace http.purl.org.linked_data.registry.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module reg =
    let _namespace_iri = Namespace_Iri reg |> NamespaceIRI
    /// <summary>
    ///   <para>reg:RegisterItem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#RegisterItem">http://purl.org/linked-data/registry#RegisterItem</seealso>
    let RegisterItem = Prefixed_Name(reg, "RegisterItem") |> PrefixedName
    /// <summary>
    ///   <para>reg:definition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#definition">http://purl.org/linked-data/registry#definition</seealso>
    let definition = Prefixed_Name(reg, "definition") |> PrefixedName
    /// <summary>
    ///   <para>reg:entity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#entity">http://purl.org/linked-data/registry#entity</seealso>
    let entity = Prefixed_Name(reg, "entity") |> PrefixedName
    /// <summary>
    ///   <para>reg:itemClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#itemClass">http://purl.org/linked-data/registry#itemClass</seealso>
    let itemClass = Prefixed_Name(reg, "itemClass") |> PrefixedName
    /// <summary>
    ///   <para>reg:notation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#notation">http://purl.org/linked-data/registry#notation</seealso>
    let notation = Prefixed_Name(reg, "notation") |> PrefixedName
    /// <summary>
    ///   <para>reg:register</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#register">http://purl.org/linked-data/registry#register</seealso>
    let register = Prefixed_Name(reg, "register") |> PrefixedName
    /// <summary>
    ///   <para>reg:sourceGraph</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#sourceGraph">http://purl.org/linked-data/registry#sourceGraph</seealso>
    let sourceGraph = Prefixed_Name(reg, "sourceGraph") |> PrefixedName
    /// <summary>
    ///   <para>reg:status</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#status">http://purl.org/linked-data/registry#status</seealso>
    let status = Prefixed_Name(reg, "status") |> PrefixedName
    /// <summary>
    ///   <para>reg:statusStable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#statusStable">http://purl.org/linked-data/registry#statusStable</seealso>
    let statusStable = Prefixed_Name(reg, "statusStable") |> PrefixedName
    /// <summary>
    ///   <para>reg:submitter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linked-data/registry#submitter">http://purl.org/linked-data/registry#submitter</seealso>
    let submitter = Prefixed_Name(reg, "submitter") |> PrefixedName
