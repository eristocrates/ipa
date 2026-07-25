namespace http.purl.org.spar.mito.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sparmito =
    let _namespace_iri = Namespace_Iri sparmito |> NamespaceIRI
    /// <summary>
    ///   <para>sparmito:2024-05-09</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/mito/2024-05-09">http://purl.org/spar/mito/2024-05-09</seealso>
    let _2024_05_09 = Prefixed_Name(sparmito, "2024-05-09") |> PrefixedName
    /// <summary>
    ///   <para>sparmito:Mention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Originally: the action of calling to mind or commemorating something in speech or writing. Subsequently in more restricted sense: the action or an act of referring to, remarking upon, or introducing the name of a person or thing in spoken or written discourse, often incidentally and as not necessarily essential to the discussion.
    /// Stated by https://www.oed.com/dictionary/mention_n?tl=true</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/Mention">http://purl.org/spar/mito/Mention</seealso>
    let Mention = Prefixed_Name(sparmito, "Mention") |> PrefixedName

    /// <summary>
    ///   <para>sparmito:hasMentionedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that relates the mention to the mentioned entity.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/hasMentionedEntity">http://purl.org/spar/mito/hasMentionedEntity</seealso>
    let hasMentionedEntity =
        Prefixed_Name(sparmito, "hasMentionedEntity") |> PrefixedName

    /// <summary>
    ///   <para>sparmito:MentionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The aim of this class is to reify the implicit or explicit characteristic of a mention.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/MentionType">http://purl.org/spar/mito/MentionType</seealso>
    let MentionType = Prefixed_Name(sparmito, "MentionType") |> PrefixedName
    /// <summary>
    ///   <para>sparmito:isMentionedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that connect the two sides involved in the act of mentioning</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/isMentionedBy">http://purl.org/spar/mito/isMentionedBy</seealso>
    let isMentionedBy = Prefixed_Name(sparmito, "isMentionedBy") |> PrefixedName
    /// <summary>
    ///   <para>sparmito:hasMentionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that aims to define the implicit or explicit character of the mention it is describing</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/hasMentionType">http://purl.org/spar/mito/hasMentionType</seealso>
    let hasMentionType = Prefixed_Name(sparmito, "hasMentionType") |> PrefixedName

    /// <summary>
    ///   <para>sparmito:hasMentioningEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that relates the mention to the mentioning entity.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/hasMentioningEntity">http://purl.org/spar/mito/hasMentioningEntity</seealso>
    let hasMentioningEntity =
        Prefixed_Name(sparmito, "hasMentioningEntity") |> PrefixedName

    /// <summary>
    ///   <para>sparmito:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that connect the two sides involved in the act of mentioning</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/mito/mentions">http://purl.org/spar/mito/mentions</seealso>
    let mentions = Prefixed_Name(sparmito, "mentions") |> PrefixedName
