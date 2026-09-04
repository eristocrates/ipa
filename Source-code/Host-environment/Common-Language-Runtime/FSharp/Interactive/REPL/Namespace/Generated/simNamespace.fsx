#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sim =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/similarity/" "sim"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Association^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class to define some association between things.  Entities share an association if they are somehow inter-connected.  Generally a &lt;b&gt;directed association&lt;/b&gt; should have at lease one &lt;code&gt;sim:subject&lt;/code&gt; property and one &lt;code&gt;sim:object&lt;/code&gt; property &lt;b&gt;or&lt;/b&gt; an &lt;b&gt;undirected association&lt;/b&gt; should have at least two &lt;code&gt;sim:element&lt;/code&gt; properties, however this is not a requirement and intentionally left out of the model.</para>
    ///   <a href="http://purl.org/ontology/similarity/Association">sim:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Association Method^^xsd:string</para>
    ///   <para>rdfs:comment : A concept for representing the method used to derive association or similarity statements.</para>
    ///   <a href="http://purl.org/ontology/similarity/AssociationMethod">sim:AssociationMethod</a>
    /// </summary>
    let AssociationMethod = _prefixId.prefix "AssociationMethod"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Influence^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class indicating a directed association of influence where the subject entity has influenced the object entity.</para>
    ///   <a href="http://purl.org/ontology/similarity/Influence">sim:Influence</a>
    /// </summary>
    let Influence = _prefixId.prefix "Influence"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Network^^xsd:string</para>
    ///   <para>rdfs:comment : A network is a grouping of &lt;code&gt;sim:Association&lt;/code&gt;s.  The associations that comprise a network are specified using a series of &lt;code&gt;sim:edge&lt;/code&gt; predicates.</para>
    ///   <a href="http://purl.org/ontology/similarity/Network">sim:Network</a>
    /// </summary>
    let Network = _prefixId.prefix "Network"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Similarity^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class to define similarity between two or more things.  Entities share a similarity if they share some common characteristics of interest.  A similarity is a special type of association.</para>
    ///   <a href="http://purl.org/ontology/similarity/Similarity">sim:Similarity</a>
    /// </summary>
    let Similarity = _prefixId.prefix "Similarity"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : association^^xsd:string</para>
    ///   <para>rdfs:comment : Binds a sim:Association to an arbitrary thing.</para>
    ///   <a href="http://purl.org/ontology/similarity/association">sim:association</a>
    /// </summary>
    let association = _prefixId.prefix "association"
    /// <summary>
    ///   <para>vs:term_status : depricated^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies some description that discloses the process or set of processes used to derive association statements for the given &lt;code&gt;AssociationMethod&lt;/code&gt;.  This property is depricated in favor of the more appropriately named &lt;code&gt;sim:workflow&lt;/code&gt; property.</para>
    ///   <a href="http://purl.org/ontology/similarity/description">sim:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : distance^^xsd:string</para>
    ///   <para>rdfs:comment : A weighting value for an Association where a value of 0 implies two elements are the same individual.</para>
    ///   <a href="http://purl.org/ontology/similarity/distance">sim:distance</a>
    /// </summary>
    let distance = _prefixId.prefix "distance"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies appropriate object types for the &lt;code&gt;sim:subject&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;directed&lt;/i&gt; associations.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/similarity/domain">sim:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : edge^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies an edge in a &lt;code&gt;sim:Network&lt;/code&gt;</para>
    ///   <a href="http://purl.org/ontology/similarity/edge">sim:edge</a>
    /// </summary>
    let edge = _prefixId.prefix "edge"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : element^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies an entity involved in the given &lt;code&gt;sim:Association&lt;/code&gt; and implies the given association is undirected.</para>
    ///   <a href="http://purl.org/ontology/similarity/element">sim:element</a>
    /// </summary>
    let element = _prefixId.prefix "element"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : grounding^^xsd:string</para>
    ///   <para>rdfs:comment : Binds an &lt;code&gt;sim:Association&lt;/code&gt; statement directly instantiated N3-Tr formulae or some other workflow graph which enabled the association derivation.</para>
    ///   <a href="http://purl.org/ontology/similarity/grounding">sim:grounding</a>
    /// </summary>
    let grounding = _prefixId.prefix "grounding"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the &lt;code&gt;sim:AssociationMethod&lt;/code&gt; used to derive a particular Association statement.  This should be used when the process for deriving association statements can be described further.</para>
    ///   <a href="http://purl.org/ontology/similarity/method">sim:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the object of a &lt;code&gt;sim:Association&lt;/code&gt; implying a directed association where "subject is associated to object" but the reverse association does not necessarily exist, and if it does exist, it is not an equivalent association.</para>
    ///   <a href="http://purl.org/ontology/similarity/object">sim:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies appropriate object types for the &lt;code&gt;sim:object&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;directed&lt;/i&gt; associations.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/similarity/range">sim:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies appropriate object types for the &lt;code&gt;sim:element&lt;/code&gt; predicate for &lt;code&gt;sim:Association&lt;/code&gt;s bound to the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;.  The presence of this predicate implies the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt; begets &lt;i&gt;undirected&lt;/i&gt; associations.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/similarity/scope">sim:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the subject of an &lt;code&gt;sim:Association&lt;/code&gt; implying a directed association where "subject is associated to object" but the reverse association does not necessarily exist, and if it does exist, it is not an equivalent association.</para>
    ///   <a href="http://purl.org/ontology/similarity/subject">sim:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : weight^^xsd:string</para>
    ///   <para>rdfs:comment : A weighting value bound to a &lt;code&gt;sim:Association&lt;/code&gt; where a value of 0 implies two elements are not at all associated and a higher value implies a closer association.</para>
    ///   <a href="http://purl.org/ontology/similarity/weight">sim:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : workflow^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a workflow that discloses the process or set of processes used to derive association statements for the given &lt;code&gt;sim:AssociationMethod&lt;/code&gt;</para>
    ///   <a href="http://purl.org/ontology/similarity/workflow">sim:workflow</a>
    /// </summary>
    let workflow = _prefixId.prefix "workflow"
