namespace http.purl.org.ontology.similarity.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module musim =
    let _namespace_iri = Namespace_Iri musim |> NamespaceIRI
    /// <summary>
    ///   <para>musim:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An abstract class to define some association between things.  Entities share an association if they are somehow inter-connected.  Generally a &lt;b&gt;directed association&lt;/b&gt; should have at lease one &lt;code&gt;sim:subject&lt;/code&gt; property and one &lt;code&gt;sim:object&lt;/code&gt; property &lt;b&gt;or&lt;/b&gt; an &lt;b&gt;undirected association&lt;/b&gt; should have at least two &lt;code&gt;sim:element&lt;/code&gt; properties, however this is not a requirement and intentionally left out of the model.</para>
    /// labels<para>Association</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/Association">http://purl.org/ontology/similarity/Association</seealso>
    let Association = Prefixed_Name(musim, "Association") |> PrefixedName
    /// <summary>
    ///   <para>musim:AssociationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A concept for representing the method used to derive association or similarity statements.</para>
    /// labels<para>Association Method</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/AssociationMethod">http://purl.org/ontology/similarity/AssociationMethod</seealso>
    let AssociationMethod = Prefixed_Name(musim, "AssociationMethod") |> PrefixedName
    /// <summary>
    ///   <para>musim:Similarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An abstract class to define similarity between two or more things.  Entities share a similarity if they share some common characteristics of interest.  A similarity is a special type of association.</para>
    /// labels<para>Similarity</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/Similarity">http://purl.org/ontology/similarity/Similarity</seealso>
    let Similarity = Prefixed_Name(musim, "Similarity") |> PrefixedName
    /// <summary>
    ///   <para>musim:distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A weighting value for an Association where a value of 0 implies two elements are the same individual.</para>
    /// labels<para>distance</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/distance">http://purl.org/ontology/similarity/distance</seealso>
    let distance = Prefixed_Name(musim, "distance") |> PrefixedName
    /// <summary>
    ///   <para>musim:element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies an entity involved in the given &lt;code&gt;sim:Association&lt;/code&gt; and implies the given association is undirected.</para>
    /// labels<para>element</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/element">http://purl.org/ontology/similarity/element</seealso>
    let element = Prefixed_Name(musim, "element") |> PrefixedName
    /// <summary>
    ///   <para>musim:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the &lt;code&gt;sim:AssociationMethod&lt;/code&gt; used to derive a particular Association statement.  This should be used when the process for deriving association statements can be described further.</para>
    /// labels<para>method</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/method">http://purl.org/ontology/similarity/method</seealso>
    let method = Prefixed_Name(musim, "method") |> PrefixedName
    /// <summary>
    ///   <para>musim:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A network is a grouping of &lt;code&gt;sim:Association&lt;/code&gt;s.  The associations that comprise a network are specified using a series of &lt;code&gt;sim:edge&lt;/code&gt; predicates.</para>
    /// labels<para>Network</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/Network">http://purl.org/ontology/similarity/Network</seealso>
    let Network = Prefixed_Name(musim, "Network") |> PrefixedName
    /// <summary>
    ///   <para>musim:grounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Binds an &lt;code&gt;sim:Association&lt;/code&gt; statement directly instantiated N3-Tr formulae or some other workflow graph which enabled the association derivation.</para>
    /// labels<para>grounding</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/grounding">http://purl.org/ontology/similarity/grounding</seealso>
    let grounding = Prefixed_Name(musim, "grounding") |> PrefixedName
    /// <summary>
    ///   <para>musim:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies appropriate object types for the &lt;code&gt;sim:element&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;undirected&lt;/i&gt; associations.</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/scope">http://purl.org/ontology/similarity/scope</seealso>
    let scope = Prefixed_Name(musim, "scope") |> PrefixedName
    /// <summary>
    ///   <para>musim:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies some description that discloses the process or set of processes used to derive association statements for the given &lt;code&gt;AssociationMethod&lt;/code&gt;.  This property is depricated in favor of the more appropriately named &lt;code&gt;sim:workflow&lt;/code&gt; property.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/description">http://purl.org/ontology/similarity/description</seealso>
    let description = Prefixed_Name(musim, "description") |> PrefixedName
    /// <summary>
    ///   <para>musim:edge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies an edge in a &lt;code&gt;sim:Network&lt;/code&gt;</para>
    /// labels<para>edge</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/edge">http://purl.org/ontology/similarity/edge</seealso>
    let edge = Prefixed_Name(musim, "edge") |> PrefixedName
    /// <summary>
    ///   <para>musim:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the object of a &lt;code&gt;sim:Association&lt;/code&gt; implying a directed association where "subject is associated to object" but the reverse association does not necessarily exist, and if it does exist, it is not an equivalent association.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/object">http://purl.org/ontology/similarity/object</seealso>
    let object = Prefixed_Name(musim, "object") |> PrefixedName
    /// <summary>
    ///   <para>musim:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A weighting value bound to a &lt;code&gt;sim:Association&lt;/code&gt; where a value of 0 implies two elements are not at all associated and a higher value implies a closer association.</para>
    /// labels<para>weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/weight">http://purl.org/ontology/similarity/weight</seealso>
    let weight = Prefixed_Name(musim, "weight") |> PrefixedName
    /// <summary>
    ///   <para>musim:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies appropriate object types for the &lt;code&gt;sim:object&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;directed&lt;/i&gt; associations.</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/range">http://purl.org/ontology/similarity/range</seealso>
    let range = Prefixed_Name(musim, "range") |> PrefixedName
    /// <summary>
    ///   <para>musim:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the subject of an &lt;code&gt;sim:Association&lt;/code&gt; implying a directed association where "subject is associated to object" but the reverse association does not necessarily exist, and if it does exist, it is not an equivalent association.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/subject">http://purl.org/ontology/similarity/subject</seealso>
    let subject = Prefixed_Name(musim, "subject") |> PrefixedName
    /// <summary>
    ///   <para>musim:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This is an ontology to express associations between entities whether artists, tracks, albums, compositional styles, sections of tracks, playing techniques or anything.  It is designed with the hope of being easily extensible, extremely expressive, and still computationally reasonable.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/similarity/">http://purl.org/ontology/similarity/</seealso>
    let _prefix_iri = Prefixed_Name(musim, "") |> PrefixedName
    /// <summary>
    ///   <para>musim:Influence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An abstract class indicating a directed association of influence where the subject entity has influenced the object entity.</para>
    /// labels<para>Influence</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/Influence">http://purl.org/ontology/similarity/Influence</seealso>
    let Influence = Prefixed_Name(musim, "Influence") |> PrefixedName
    /// <summary>
    ///   <para>musim:association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Binds a sim:Association to an arbitrary thing.</para>
    /// labels<para>association</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/association">http://purl.org/ontology/similarity/association</seealso>
    let association = Prefixed_Name(musim, "association") |> PrefixedName
    /// <summary>
    ///   <para>musim:workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a workflow that discloses the process or set of processes used to derive association statements for the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;</para>
    /// labels<para>workflow</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/workflow">http://purl.org/ontology/similarity/workflow</seealso>
    let workflow = Prefixed_Name(musim, "workflow") |> PrefixedName
    /// <summary>
    ///   <para>musim:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies appropriate object types for the &lt;code&gt;sim:subject&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;directed&lt;/i&gt; associations.</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://purl.org/ontology/similarity/domain">http://purl.org/ontology/similarity/domain</seealso>
    let domain = Prefixed_Name(musim, "domain") |> PrefixedName
