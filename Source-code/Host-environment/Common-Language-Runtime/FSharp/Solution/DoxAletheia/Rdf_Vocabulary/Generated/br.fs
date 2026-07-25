namespace http.vocab.deri.ie.br.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module br =
    let _namespace_iri = Namespace_Iri br |> NamespaceIRI
    /// <summary>
    ///   <para>br:Brainstorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Brainstorm</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#Brainstorm">http://vocab.deri.ie/br#Brainstorm</seealso>
    let Brainstorm = Prefixed_Name(br, "Brainstorm") |> PrefixedName
    /// <summary>
    ///   <para>br:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Label</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#Label">http://vocab.deri.ie/br#Label</seealso>
    let Label = Prefixed_Name(br, "Label") |> PrefixedName
    /// <summary>
    ///   <para>br:ObjTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Objective Title</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#ObjTitle">http://vocab.deri.ie/br#ObjTitle</seealso>
    let ObjTitle = Prefixed_Name(br, "ObjTitle") |> PrefixedName
    /// <summary>
    ///   <para>br:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/br#rdf">http://vocab.deri.ie/br#rdf</seealso>
    let rdf = Prefixed_Name(br, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>br:BrTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>BrTopic</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#BrTopic">http://vocab.deri.ie/br#BrTopic</seealso>
    let BrTopic = Prefixed_Name(br, "BrTopic") |> PrefixedName
    /// <summary>
    ///   <para>br:ObjDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Objective Description</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#ObjDescription">http://vocab.deri.ie/br#ObjDescription</seealso>
    let ObjDescription = Prefixed_Name(br, "ObjDescription") |> PrefixedName
    /// <summary>
    ///   <para>br:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Site</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#Site">http://vocab.deri.ie/br#Site</seealso>
    let Site = Prefixed_Name(br, "Site") |> PrefixedName
    /// <summary>
    ///   <para>br:hasIdea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>br:hasIdea</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasIdea">http://vocab.deri.ie/br#hasIdea</seealso>
    let hasIdea = Prefixed_Name(br, "hasIdea") |> PrefixedName
    /// <summary>
    ///   <para>br:Idea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Idea</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#Idea">http://vocab.deri.ie/br#Idea</seealso>
    let Idea = Prefixed_Name(br, "Idea") |> PrefixedName
    /// <summary>
    ///   <para>br:Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Participant</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#Participant">http://vocab.deri.ie/br#Participant</seealso>
    let Participant = Prefixed_Name(br, "Participant") |> PrefixedName

    /// <summary>
    ///   <para>br:DERI%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/br#DERI%2C%20NUI%20Galway">http://vocab.deri.ie/br#DERI%2C%20NUI%20Galway</seealso>
    let ``DERI%2C%20NUI%20Galway`` =
        Prefixed_Name(br, "DERI%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>br:Objective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Objective</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#Objective">http://vocab.deri.ie/br#Objective</seealso>
    let Objective = Prefixed_Name(br, "Objective") |> PrefixedName
    /// <summary>
    ///   <para>br:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>dc:description</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#description">http://vocab.deri.ie/br#description</seealso>
    let description = Prefixed_Name(br, "description") |> PrefixedName
    /// <summary>
    ///   <para>br:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>br:hasParticipant</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasParticipant">http://vocab.deri.ie/br#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(br, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>br:hasReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>rev:hasReview</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasReview">http://vocab.deri.ie/br#hasReview</seealso>
    let hasReview = Prefixed_Name(br, "hasReview") |> PrefixedName
    /// <summary>
    ///   <para>br:hasSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>sioc:has_space</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasSpace">http://vocab.deri.ie/br#hasSpace</seealso>
    let hasSpace = Prefixed_Name(br, "hasSpace") |> PrefixedName
    /// <summary>
    ///   <para>br:holdsAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>foaf:holdsAccount</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#holdsAccount">http://vocab.deri.ie/br#holdsAccount</seealso>
    let holdsAccount = Prefixed_Name(br, "holdsAccount") |> PrefixedName
    /// <summary>
    ///   <para>br:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>dc:creator</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#creator">http://vocab.deri.ie/br#creator</seealso>
    let creator = Prefixed_Name(br, "creator") |> PrefixedName
    /// <summary>
    ///   <para>br:hasExpectation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>br:hasExpectation</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasExpectation">http://vocab.deri.ie/br#hasExpectation</seealso>
    let hasExpectation = Prefixed_Name(br, "hasExpectation") |> PrefixedName
    /// <summary>
    ///   <para>br:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>br:hasEvent</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasEvent">http://vocab.deri.ie/br#hasEvent</seealso>
    let hasEvent = Prefixed_Name(br, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>br:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>skos:member</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#member">http://vocab.deri.ie/br#member</seealso>
    let member_ = Prefixed_Name(br, "member") |> PrefixedName
    /// <summary>
    ///   <para>br:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>br:hasTopic</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#hasTopic">http://vocab.deri.ie/br#hasTopic</seealso>
    let hasTopic = Prefixed_Name(br, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>br:taggedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Tags_taggedBy</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#taggedBy">http://vocab.deri.ie/br#taggedBy</seealso>
    let taggedBy = Prefixed_Name(br, "taggedBy") |> PrefixedName
    /// <summary>
    ///   <para>br:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>rdf:type</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#type">http://vocab.deri.ie/br#type</seealso>
    let type_ = Prefixed_Name(br, "type") |> PrefixedName
    /// <summary>
    ///   <para>br:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>skos:prefLabel</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#prefLabel">http://vocab.deri.ie/br#prefLabel</seealso>
    let prefLabel = Prefixed_Name(br, "prefLabel") |> PrefixedName
    /// <summary>
    ///   <para>br:semanticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>skos:semanticRelation</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#semanticRelation">http://vocab.deri.ie/br#semanticRelation</seealso>
    let semanticRelation = Prefixed_Name(br, "semanticRelation") |> PrefixedName
    /// <summary>
    ///   <para>br:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>dc:title</para></remarks>
    /// <seealso href="http://vocab.deri.ie/br#title">http://vocab.deri.ie/br#title</seealso>
    let title = Prefixed_Name(br, "title") |> PrefixedName
    /// <summary>
    ///   <para>br:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/br#ttl">http://vocab.deri.ie/br#ttl</seealso>
    let ttl = Prefixed_Name(br, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>br:lorlor</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/br#lorlor">http://vocab.deri.ie/br#lorlor</seealso>
    let lorlor = Prefixed_Name(br, "lorlor") |> PrefixedName
