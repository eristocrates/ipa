namespace http.purl.org.ontology.similarity.slash

open DoxAletheia

module musim =
    let _namespace_name = "http://purl.org/ontology/similarity/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An abstract class to define some association between things.  Entities share an association if they are somehow inter-connected.  Generally a &lt;b&gt;directed association&lt;/b&gt; should have at lease one &lt;code&gt;sim:subject&lt;/code&gt; property and one &lt;code&gt;sim:object&lt;/code&gt; property &lt;b&gt;or&lt;/b&gt; an &lt;b&gt;undirected association&lt;/b&gt; should have at least two &lt;code&gt;sim:element&lt;/code&gt; properties, however this is not a requirement and intentionally left out of the model.
    /// <see href="http://purl.org/ontology/similarity/Association"></see></summary>
    let Association = _prefix "Association"
    /// <summary>
    /// Specifies the &lt;code&gt;sim:AssociationMethod&lt;/code&gt; used to derive a particular Association statement.  This should be used when the process for deriving association statements can be described further.
    /// <see href="http://purl.org/ontology/similarity/method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    /// A concept for representing the method used to derive association or similarity statements.
    /// <see href="http://purl.org/ontology/similarity/AssociationMethod"></see></summary>
    let AssociationMethod = _prefix "AssociationMethod"
    /// <summary>
    /// An abstract class indicating a directed association of influence where the subject entity has influenced the object entity.
    /// <see href="http://purl.org/ontology/similarity/Influence"></see></summary>
    let Influence = _prefix "Influence"
    /// <summary>
    /// A network is a grouping of &lt;code&gt;sim:Association&lt;/code&gt;s.  The associations that comprise a network are specified using a series of &lt;code&gt;sim:edge&lt;/code&gt; predicates.
    /// <see href="http://purl.org/ontology/similarity/Network"></see></summary>
    let Network = _prefix "Network"
    /// <summary>
    /// An abstract class to define similarity between two or more things.  Entities share a similarity if they share some common characteristics of interest.  A similarity is a special type of association.
    /// <see href="http://purl.org/ontology/similarity/Similarity"></see></summary>
    let Similarity = _prefix "Similarity"
    /// <summary>
    /// Binds a sim:Association to an arbitrary thing.
    /// <see href="http://purl.org/ontology/similarity/association"></see></summary>
    let association = _prefix "association"
    /// <summary>
    /// Specifies some description that discloses the process or set of processes used to derive association statements for the given &lt;code&gt;AssociationMethod&lt;/code&gt;.  This property is depricated in favor of the more appropriately named &lt;code&gt;sim:workflow&lt;/code&gt; property.
    /// <see href="http://purl.org/ontology/similarity/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Specifies a workflow that discloses the process or set of processes used to derive association statements for the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;
    /// <see href="http://purl.org/ontology/similarity/workflow"></see></summary>
    let workflow = _prefix "workflow"
    /// <summary>
    /// A weighting value for an Association where a value of 0 implies two elements are the same individual.
    /// <see href="http://purl.org/ontology/similarity/distance"></see></summary>
    let distance = _prefix "distance"
    /// <summary>
    /// Specifies appropriate object types for the &lt;code&gt;sim:subject&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;directed&lt;/i&gt; associations.
    /// <see href="http://purl.org/ontology/similarity/domain"></see></summary>
    let domain = _prefix "domain"
    /// <summary>
    /// Specifies an edge in a &lt;code&gt;sim:Network&lt;/code&gt;
    /// <see href="http://purl.org/ontology/similarity/edge"></see></summary>
    let edge = _prefix "edge"
    /// <summary>
    /// Specifies an entity involved in the given &lt;code&gt;sim:Association&lt;/code&gt; and implies the given association is undirected.
    /// <see href="http://purl.org/ontology/similarity/element"></see></summary>
    let element = _prefix "element"
    /// <summary>
    /// Binds an &lt;code&gt;sim:Association&lt;/code&gt; statement directly instantiated N3-Tr formulae or some other workflow graph which enabled the association derivation.
    /// <see href="http://purl.org/ontology/similarity/grounding"></see></summary>
    let grounding = _prefix "grounding"
    /// <summary>
    /// Specifies the object of a &lt;code&gt;sim:Association&lt;/code&gt; implying a directed association where "subject is associated to object" but the reverse association does not necessarily exist, and if it does exist, it is not an equivalent association.
    /// <see href="http://purl.org/ontology/similarity/object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// Specifies appropriate object types for the &lt;code&gt;sim:object&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;directed&lt;/i&gt; associations.
    /// <see href="http://purl.org/ontology/similarity/range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// Specifies appropriate object types for the &lt;code&gt;sim:element&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;undirected&lt;/i&gt; associations.
    /// <see href="http://purl.org/ontology/similarity/scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// Specifies the subject of an &lt;code&gt;sim:Association&lt;/code&gt; implying a directed association where "subject is associated to object" but the reverse association does not necessarily exist, and if it does exist, it is not an equivalent association.
    /// <see href="http://purl.org/ontology/similarity/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A weighting value bound to a &lt;code&gt;sim:Association&lt;/code&gt; where a value of 0 implies two elements are not at all associated and a higher value implies a closer association.
    /// <see href="http://purl.org/ontology/similarity/weight"></see></summary>
    let weight = _prefix "weight"
