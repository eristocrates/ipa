namespace http.purl.org.vocab.changeset.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module changeset =
    let _namespace_iri = Namespace_Iri changeset |> NamespaceIRI
    /// <summary>
    ///   <para>changeset:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#">http://purl.org/vocab/changeset/schema#</seealso>
    let _prefix_iri = Prefixed_Name(changeset, "") |> PrefixedName

    /// <summary>
    ///   <para>changeset:precedingChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///       This property can be used to build a history of changes to a particular resource description. The first
    ///       ChangeSet in the history will have no precedingChangeSet property. Each subsequent ChangeSet added
    ///       to the history references the preceding one resulting in a singly-linked list of changes.  Care must be taken
    ///       not to introduce cycles in the history.
    ///     </para>
    ///   <para>
    ///       In systems that assume a closed world, the most recent ChangeSet for a particular resource description
    ///       can be discovered by looking for the ChangeSet that is not the value of a precedingChangeSet property.
    ///       Conversely, the earliest ChangeSet is the one that is not the subject of a precedingChangeSet property.
    ///     </para>
    /// labels<para>precedingChangeSet</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#precedingChangeSet">http://purl.org/vocab/changeset/schema#precedingChangeSet</seealso>
    let precedingChangeSet =
        Prefixed_Name(changeset, "precedingChangeSet") |> PrefixedName

    /// <summary>
    ///   <para>changeset:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>statement</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#statement">http://purl.org/vocab/changeset/schema#statement</seealso>
    let statement = Prefixed_Name(changeset, "statement") |> PrefixedName
    /// <summary>
    ///   <para>changeset:subjectOfChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subjectOfChange</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#subjectOfChange">http://purl.org/vocab/changeset/schema#subjectOfChange</seealso>
    let subjectOfChange = Prefixed_Name(changeset, "subjectOfChange") |> PrefixedName
    /// <summary>
    ///   <para>changeset:createdDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///       The date should be in W3CDTF format
    ///     </para>
    /// labels<para>createdDate</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#createdDate">http://purl.org/vocab/changeset/schema#createdDate</seealso>
    let createdDate = Prefixed_Name(changeset, "createdDate") |> PrefixedName
    /// <summary>
    ///   <para>changeset:creatorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>creatorName</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#creatorName">http://purl.org/vocab/changeset/schema#creatorName</seealso>
    let creatorName = Prefixed_Name(changeset, "creatorName") |> PrefixedName
    /// <summary>
    ///   <para>changeset:changeReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>changeReason</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#changeReason">http://purl.org/vocab/changeset/schema#changeReason</seealso>
    let changeReason = Prefixed_Name(changeset, "changeReason") |> PrefixedName
    /// <summary>
    ///   <para>changeset:addition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///       By convention the subject of the triple being added should be the same as the subjectOfChange
    ///     </para>
    /// labels<para>addition</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#addition">http://purl.org/vocab/changeset/schema#addition</seealso>
    let addition = Prefixed_Name(changeset, "addition") |> PrefixedName
    /// <summary>
    ///   <para>changeset:removal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///       By convention the subject of the triple being removed should be the same as the subjectOfChange
    ///     </para>
    /// labels<para>removal</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#removal">http://purl.org/vocab/changeset/schema#removal</seealso>
    let removal = Prefixed_Name(changeset, "removal") |> PrefixedName
    /// <summary>
    ///   <para>changeset:ChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ChangeSet</para></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#ChangeSet">http://purl.org/vocab/changeset/schema#ChangeSet</seealso>
    let ChangeSet = Prefixed_Name(changeset, "ChangeSet") |> PrefixedName

    /// <summary>
    ///   <para>changeset:previousChangeSet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/changeset/schema#previousChangeSet">http://purl.org/vocab/changeset/schema#previousChangeSet</seealso>
    let previousChangeSet =
        Prefixed_Name(changeset, "previousChangeSet") |> PrefixedName
