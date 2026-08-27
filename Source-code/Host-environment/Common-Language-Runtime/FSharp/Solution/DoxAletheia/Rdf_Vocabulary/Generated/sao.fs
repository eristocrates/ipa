namespace http.salt.semanticauthoring.org.ontologies.sao.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sao =
    let _namespace_iri = Namespace_Iri sao |> NamespaceIRI
    /// <summary>
    ///   <para>sao:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#Annotation">http://salt.semanticauthoring.org/ontologies/sao#Annotation</seealso>
    let Annotation = Prefixed_Name(sao, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>sao:CitationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"CitationContext"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#CitationContext">http://salt.semanticauthoring.org/ontologies/sao#CitationContext</seealso>
    let CitationContext = Prefixed_Name(sao, "CitationContext") |> PrefixedName
    /// <summary>
    ///   <para>sao:annotates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"annotates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#annotates">http://salt.semanticauthoring.org/ontologies/sao#annotates</seealso>
    let annotates = Prefixed_Name(sao, "annotates") |> PrefixedName
    /// <summary>
    ///   <para>sao:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"cites"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#cites">http://salt.semanticauthoring.org/ontologies/sao#cites</seealso>
    let cites = Prefixed_Name(sao, "cites") |> PrefixedName
    /// <summary>
    ///   <para>sao:hasCitationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasCitationContext"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationContext">http://salt.semanticauthoring.org/ontologies/sao#hasCitationContext</seealso>
    let hasCitationContext = Prefixed_Name(sao, "hasCitationContext") |> PrefixedName
    /// <summary>
    ///   <para>sao:hasCitationKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasCitationKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationKey">http://salt.semanticauthoring.org/ontologies/sao#hasCitationKey</seealso>
    let hasCitationKey = Prefixed_Name(sao, "hasCitationKey") |> PrefixedName
    /// <summary>
    ///   <para>sao:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasTopic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#hasTopic">http://salt.semanticauthoring.org/ontologies/sao#hasTopic</seealso>
    let hasTopic = Prefixed_Name(sao, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>sao:isCitedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"isCitedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#isCitedBy">http://salt.semanticauthoring.org/ontologies/sao#isCitedBy</seealso>
    let isCitedBy = Prefixed_Name(sao, "isCitedBy") |> PrefixedName
    /// <summary>
    ///   <para>sao:pointsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"pointsTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sao#pointsTo">http://salt.semanticauthoring.org/ontologies/sao#pointsTo</seealso>
    let pointsTo = Prefixed_Name(sao, "pointsTo") |> PrefixedName
