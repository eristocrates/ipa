namespace http.vocab.deri.ie.c4n.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module c4n =
    let _namespace_iri = Namespace_Iri c4n |> NamespaceIRI
    /// <summary>
    ///   <para>c4n:issues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>issues</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#issues">http://vocab.deri.ie/c4n#issues</seealso>
    let issues = Prefixed_Name(c4n, "issues") |> PrefixedName
    /// <summary>
    ///   <para>c4n:Call</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>a call</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#Call">http://vocab.deri.ie/c4n#Call</seealso>
    let Call = Prefixed_Name(c4n, "Call") |> PrefixedName
    /// <summary>
    ///   <para>c4n:Deadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>a temporal condition that must be met to comply the call</para>
    /// labels<para>a deadline</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#Deadline">http://vocab.deri.ie/c4n#Deadline</seealso>
    let Deadline = Prefixed_Name(c4n, "Deadline") |> PrefixedName
    /// <summary>
    ///   <para>c4n:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>an event a call refers to</para>
    /// labels<para>an event</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#Event">http://vocab.deri.ie/c4n#Event</seealso>
    let Event = Prefixed_Name(c4n, "Event") |> PrefixedName
    /// <summary>
    ///   <para>c4n:LiDRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#LiDRC">http://vocab.deri.ie/c4n#LiDRC</seealso>
    let LiDRC = Prefixed_Name(c4n, "LiDRC") |> PrefixedName
    /// <summary>
    ///   <para>c4n:Issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>the issuer of the call</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#Issuer">http://vocab.deri.ie/c4n#Issuer</seealso>
    let Issuer = Prefixed_Name(c4n, "Issuer") |> PrefixedName
    /// <summary>
    ///   <para>c4n:for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>restricts the call to a certain event</para>
    /// labels<para>for</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#for">http://vocab.deri.ie/c4n#for</seealso>
    let for_ = Prefixed_Name(c4n, "for") |> PrefixedName
    /// <summary>
    ///   <para>c4n:SpatialScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>a geographic condition that must be met to comply the call</para>
    /// labels<para>a spatial scope</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#SpatialScope">http://vocab.deri.ie/c4n#SpatialScope</seealso>
    let SpatialScope = Prefixed_Name(c4n, "SpatialScope") |> PrefixedName
    /// <summary>
    ///   <para>c4n:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>must meet condition</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#condition">http://vocab.deri.ie/c4n#condition</seealso>
    let condition = Prefixed_Name(c4n, "condition") |> PrefixedName
    /// <summary>
    ///   <para>c4n:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#rdf">http://vocab.deri.ie/c4n#rdf</seealso>
    let rdf = Prefixed_Name(c4n, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>c4n:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#ttl">http://vocab.deri.ie/c4n#ttl</seealso>
    let ttl = Prefixed_Name(c4n, "ttl") |> PrefixedName

    /// <summary>
    ///   <para>c4n:Michael%20Hausenblas</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#Michael%20Hausenblas">http://vocab.deri.ie/c4n#Michael%20Hausenblas</seealso>
    let ``Michael%20Hausenblas`` =
        Prefixed_Name(c4n, "Michael%20Hausenblas") |> PrefixedName

    /// <summary>
    ///   <para>c4n:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>a condition under which the call event has to be understood</para>
    /// labels<para>a condition</para></remarks>
    /// <seealso href="http://vocab.deri.ie/c4n#Condition">http://vocab.deri.ie/c4n#Condition</seealso>
    let Condition = Prefixed_Name(c4n, "Condition") |> PrefixedName
