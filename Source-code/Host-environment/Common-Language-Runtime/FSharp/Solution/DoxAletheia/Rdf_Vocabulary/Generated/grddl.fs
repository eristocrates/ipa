namespace http.www.w3.org._2003.g.data_view.hash

open DoxAletheia.Rdf_Vocabulary

module grddl =
    let _namespace_name = "http://www.w3.org/2003/g/data-view#"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/g/data-view#grddl-wg"></see>
    /// </summary>
    let ``grddl-wg`` = Namespaced_IRI.parse _namespace_name "grddl-wg" |> NamespacedName

    /// <summary>
    /// A resource which has the property that all of its essential characteristics can be conveyed in a message
    /// <see href="http://www.w3.org/2003/g/data-view#InformationResource"></see></summary>
    let InformationResource =
        Namespaced_IRI.parse _namespace_name "InformationResource" |> NamespacedName

    /// <summary>
    /// a
    ///     set of RDF triples
    /// <see href="http://www.w3.org/2003/g/data-view#RDFGraph"></see></summary>
    let RDFGraph = Namespaced_IRI.parse _namespace_name "RDFGraph" |> NamespacedName
    /// <summary>
    /// the root of the tree in the XPath data
    ///     model
    /// <see href="http://www.w3.org/2003/g/data-view#RootNode"></see></summary>
    let RootNode = Namespaced_IRI.parse _namespace_name "RootNode" |> NamespacedName

    /// <summary>
    /// an InformationResource that specifies
    ///     a transformation from a set of XML documents to RDF graphs
    /// <see href="http://www.w3.org/2003/g/data-view#Transformation"></see></summary>
    let Transformation =
        Namespaced_IRI.parse _namespace_name "Transformation" |> NamespacedName

    /// <summary>
    /// relates a transformation to the algorithm
    ///     specified by the property that computes an RDF graph from an XML
    ///     document node
    /// <see href="http://www.w3.org/2003/g/data-view#transformationProperty"></see></summary>
    let transformationProperty =
        Namespaced_IRI.parse _namespace_name "transformationProperty" |> NamespacedName

    /// <summary>
    /// a FunctionalProperty that relates
    ///     XML document root nodes to
    ///     RDF graphs
    /// <see href="http://www.w3.org/2003/g/data-view#TransformationProperty"></see></summary>
    let TransformationProperty =
        Namespaced_IRI.parse _namespace_name "TransformationProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2003/g/data-view#danc"></see>
    /// </summary>
    let danc = Namespaced_IRI.parse _namespace_name "danc" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2003/g/data-view#grddlProject"></see>
    /// </summary>
    let grddlProject =
        Namespaced_IRI.parse _namespace_name "grddlProject" |> NamespacedName

    /// <summary>
    /// relates a namespace to a transformation for
    ///     all documents in that namespace
    /// <see href="http://www.w3.org/2003/g/data-view#namespaceTransformation"></see></summary>
    let namespaceTransformation =
        Namespaced_IRI.parse _namespace_name "namespaceTransformation" |> NamespacedName

    /// <summary>
    /// relates a profile document to a
    ///     transformation for all documents bearing that profile
    /// <see href="http://www.w3.org/2003/g/data-view#profileTransformation"></see></summary>
    let profileTransformation =
        Namespaced_IRI.parse _namespace_name "profileTransformation" |> NamespacedName

    /// <summary>
    /// an
    ///     RDF graph obtained from an information resource by directly
    ///     parsing a representation in the standard RDF/XML syntax or
    ///     indirectly by parsing some other dialect using a transformation
    ///     nominated by the document
    /// <see href="http://www.w3.org/2003/g/data-view#result"></see></summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    /// relates a source document to a
    ///     transformation, usually represented in XSLT, that relates the source document syntax
    ///     to the RDF graph syntax
    /// <see href="http://www.w3.org/2003/g/data-view#transformation"></see></summary>
    let transformation =
        Namespaced_IRI.parse _namespace_name "transformation" |> NamespacedName
