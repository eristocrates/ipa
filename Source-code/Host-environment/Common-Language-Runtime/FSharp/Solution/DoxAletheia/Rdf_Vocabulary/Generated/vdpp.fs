namespace http.data.lirmm.fr.ontologies.vdpp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vdpp =
    let _namespace_iri = Namespace_Iri vdpp |> NamespaceIRI
    /// <summary>
    ///   <para>vdpp:Convertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describe the process of a converting the source data. The result of the transformation will be a new datset that can be further processed, published and interlinked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#Convertion">http://data.lirmm.fr/ontologies/vdpp#Convertion</seealso>
    let Convertion = Prefixed_Name(vdpp, "Convertion") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:Interlinking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describe the process of interlinking a vocabulary with another. The result of the interlinking will be a void:Linkset containing links between the two datasets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interlinking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#Interlinking">http://data.lirmm.fr/ontologies/vdpp#Interlinking</seealso>
    let Interlinking = Prefixed_Name(vdpp, "Interlinking") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:LIRMM</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#LIRMM">http://data.lirmm.fr/ontologies/vdpp#LIRMM</seealso>
    let LIRMM = Prefixed_Name(vdpp, "LIRMM") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Datasets publication projects. This class makes the link between a DOAP project, and VoIDP provenance events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset publication project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#Project">http://data.lirmm.fr/ontologies/vdpp#Project</seealso>
    let Project = Prefixed_Name(vdpp, "Project") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describe the process of publishing a RDF dataset on the Web. The result of the publication is a URI where the dataset is accessible as linked-data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#Publication">http://data.lirmm.fr/ontologies/vdpp#Publication</seealso>
    let Publication = Prefixed_Name(vdpp, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:Selection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describe the process of a selection of vocabularies to represent a dataset. This selection will result in a set of vocabularies that will be used to describe the published data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Selection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#Selection">http://data.lirmm.fr/ontologies/vdpp#Selection</seealso>
    let Selection = Prefixed_Name(vdpp, "Selection") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:fran%C3%A7ois</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#fran%C3%A7ois">http://data.lirmm.fr/ontologies/vdpp#fran%C3%A7ois</seealso>
    let ``fran%C3%A7ois`` = Prefixed_Name(vdpp, "fran%C3%A7ois") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:process</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A process performed during a dataset publication project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#process">http://data.lirmm.fr/ontologies/vdpp#process</seealso>
    let process_ = Prefixed_Name(vdpp, "process") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#rdf">http://data.lirmm.fr/ontologies/vdpp#rdf</seealso>
    let rdf = Prefixed_Name(vdpp, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>vdpp:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/vdpp#ttl">http://data.lirmm.fr/ontologies/vdpp#ttl</seealso>
    let ttl = Prefixed_Name(vdpp, "ttl") |> PrefixedName
