#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vdpp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/vdpp#" "vdpp"

    /// <summary>
    ///   <para>rdfs:label : Convertion^^xsd:string</para>
    ///   <para>rdfs:comment : Describe the process of a converting the source data. The result of the transformation will be a new datset that can be further processed, published and interlinked.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/vdpp#Convertion">vdpp:Convertion</a>
    /// </summary>
    let Convertion = _prefixId.prefix "Convertion"
    /// <summary>
    ///   <para>rdfs:label : Interlinking^^xsd:string</para>
    ///   <para>rdfs:comment : Describe the process of interlinking a vocabulary with another. The result of the interlinking will be a void:Linkset containing links between the two datasets.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/vdpp#Interlinking">vdpp:Interlinking</a>
    /// </summary>
    let Interlinking = _prefixId.prefix "Interlinking"
    let LIRMM = _prefixId.prefix "LIRMM"
    /// <summary>
    ///   <para>rdfs:label : Dataset publication project^^xsd:string</para>
    ///   <para>rdfs:comment : Datasets publication projects. This class makes the link between a DOAP project, and VoIDP provenance events.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/vdpp#Project">vdpp:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <para>rdfs:comment : Describe the process of publishing a RDF dataset on the Web. The result of the publication is a URI where the dataset is accessible as linked-data.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/vdpp#Publication">vdpp:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Selection^^xsd:string</para>
    ///   <para>rdfs:comment : Describe the process of a selection of vocabularies to represent a dataset. This selection will result in a set of vocabularies that will be used to describe the published data.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/vdpp#Selection">vdpp:Selection</a>
    /// </summary>
    let Selection = _prefixId.prefix "Selection"
    let ``fran%C3%A7ois`` = _prefixId.prefix "fran%C3%A7ois"
    /// <summary>
    ///   <para>rdfs:label : Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process performed during a dataset publication project.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/vdpp#process">vdpp:process</a>
    /// </summary>
    let process_ = _prefixId.prefix "process"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
