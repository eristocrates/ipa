namespace http.data.lirmm.fr.ontologies.vdpp.hash

open DoxAletheia

module vdpp =
    let _namespace_name = "http://data.lirmm.fr/ontologies/vdpp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/vdpp#fran%C3%A7ois"></see>
    /// </summary>
    let ``fran%C3%A7ois`` = _prefix "fran%C3%A7ois"
    /// <summary>
    /// Describe the process of a converting the source data. The result of the transformation will be a new datset that can be further processed, published and interlinked.
    /// <see href="http://data.lirmm.fr/ontologies/vdpp#Convertion"></see></summary>
    let Convertion = _prefix "Convertion"
    /// <summary>
    /// Describe the process of interlinking a vocabulary with another. The result of the interlinking will be a void:Linkset containing links between the two datasets.
    /// <see href="http://data.lirmm.fr/ontologies/vdpp#Interlinking"></see></summary>
    let Interlinking = _prefix "Interlinking"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/vdpp#LIRMM"></see>
    /// </summary>
    let LIRMM = _prefix "LIRMM"
    /// <summary>
    /// Datasets publication projects. This class makes the link between a DOAP project, and VoIDP provenance events.
    /// <see href="http://data.lirmm.fr/ontologies/vdpp#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Describe the process of publishing a RDF dataset on the Web. The result of the publication is a URI where the dataset is accessible as linked-data.
    /// <see href="http://data.lirmm.fr/ontologies/vdpp#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// Describe the process of a selection of vocabularies to represent a dataset. This selection will result in a set of vocabularies that will be used to describe the published data.
    /// <see href="http://data.lirmm.fr/ontologies/vdpp#Selection"></see></summary>
    let Selection = _prefix "Selection"
    /// <summary>
    /// A process performed during a dataset publication project.
    /// <see href="http://data.lirmm.fr/ontologies/vdpp#process"></see></summary>
    let process_ = _prefix "process"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/vdpp#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/vdpp#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
