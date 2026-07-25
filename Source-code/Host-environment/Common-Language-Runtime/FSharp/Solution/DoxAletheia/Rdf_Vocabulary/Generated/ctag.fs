namespace http.commontag.org.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ctag =
    let _namespace_iri = Namespace_Iri ctag |> NamespaceIRI
    /// <summary>
    ///   <para>ctag:AuthorTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Tag asserted by the author of a content resource.</para>
    /// labels<para>Author Tag</para></remarks>
    /// <seealso href="http://commontag.org/ns#AuthorTag">http://commontag.org/ns#AuthorTag</seealso>
    let AuthorTag = Prefixed_Name(ctag, "AuthorTag") |> PrefixedName
    /// <summary>
    ///   <para>ctag:AutoTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Tag asserted by an automated tool on a content resource.</para>
    /// labels<para>Auto Tag</para></remarks>
    /// <seealso href="http://commontag.org/ns#AutoTag">http://commontag.org/ns#AutoTag</seealso>
    let AutoTag = Prefixed_Name(ctag, "AutoTag") |> PrefixedName
    /// <summary>
    ///   <para>ctag:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource (URI) representing the concepts described by the content.</para>
    /// labels<para>is about</para></remarks>
    /// <seealso href="http://commontag.org/ns#isAbout">http://commontag.org/ns#isAbout</seealso>
    let isAbout = Prefixed_Name(ctag, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>ctag:TaggedContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Content which has one or more Common Tag.</para>
    /// labels<para>Tagged Content</para></remarks>
    /// <seealso href="http://commontag.org/ns#TaggedContent">http://commontag.org/ns#TaggedContent</seealso>
    let TaggedContent = Prefixed_Name(ctag, "TaggedContent") |> PrefixedName
    /// <summary>
    ///   <para>ctag:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A local, human-readable name for a Tag.</para>
    /// labels<para>tag label</para></remarks>
    /// <seealso href="http://commontag.org/ns#label">http://commontag.org/ns#label</seealso>
    let label = Prefixed_Name(ctag, "label") |> PrefixedName
    /// <summary>
    ///   <para>ctag:means</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A a resource (URI) representing the conceptual meaning of a Tag.</para>
    /// labels<para>means</para></remarks>
    /// <seealso href="http://commontag.org/ns#means">http://commontag.org/ns#means</seealso>
    let means = Prefixed_Name(ctag, "means") |> PrefixedName
    /// <summary>
    ///   <para>ctag:taggingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date the Tag was assigned.</para>
    /// labels<para>tagging date</para></remarks>
    /// <seealso href="http://commontag.org/ns#taggingDate">http://commontag.org/ns#taggingDate</seealso>
    let taggingDate = Prefixed_Name(ctag, "taggingDate") |> PrefixedName
    /// <summary>
    ///   <para>ctag:tagged</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a resource to a Common Tag.</para>
    /// labels<para>tagged</para></remarks>
    /// <seealso href="http://commontag.org/ns#tagged">http://commontag.org/ns#tagged</seealso>
    let tagged = Prefixed_Name(ctag, "tagged") |> PrefixedName
    /// <summary>
    ///   <para>ctag:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Common Tag vocabulary</para></remarks>
    /// <seealso href="http://commontag.org/ns#">http://commontag.org/ns#</seealso>
    let _prefix_iri = Prefixed_Name(ctag, "") |> PrefixedName
    /// <summary>
    ///   <para>ctag:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Common Tag associating a URI and a keyword to annotate a resource.</para>
    /// labels<para>Tag</para></remarks>
    /// <seealso href="http://commontag.org/ns#Tag">http://commontag.org/ns#Tag</seealso>
    let Tag = Prefixed_Name(ctag, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>ctag:ReaderTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Tag asserted by the reader (consumer) of a content resource.</para>
    /// labels<para>Reader Tag</para></remarks>
    /// <seealso href="http://commontag.org/ns#ReaderTag">http://commontag.org/ns#ReaderTag</seealso>
    let ReaderTag = Prefixed_Name(ctag, "ReaderTag") |> PrefixedName
