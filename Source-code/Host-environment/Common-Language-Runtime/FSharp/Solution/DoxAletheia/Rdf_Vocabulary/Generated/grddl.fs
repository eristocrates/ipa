namespace http.www.w3.org._2003.g.data_view.hash

open DoxAletheia

module grddl =
    let _namespace_name = "http://www.w3.org/2003/g/data-view#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2003/g/data-view#grddl-wg"></see>
    /// </summary>
    let ``grddl-wg`` = _prefix "grddl-wg"
    /// <summary>
    /// A resource which has the property that all of its essential characteristics can be conveyed in a message
    /// <see href="http://www.w3.org/2003/g/data-view#InformationResource"></see></summary>
    let InformationResource = _prefix "InformationResource"
    /// <summary>
    /// a
    ///     set of RDF triples
    /// <see href="http://www.w3.org/2003/g/data-view#RDFGraph"></see></summary>
    let RDFGraph = _prefix "RDFGraph"
    /// <summary>
    /// the root of the tree in the XPath data
    ///     model
    /// <see href="http://www.w3.org/2003/g/data-view#RootNode"></see></summary>
    let RootNode = _prefix "RootNode"
    /// <summary>
    /// an InformationResource that specifies
    ///     a transformation from a set of XML documents to RDF graphs
    /// <see href="http://www.w3.org/2003/g/data-view#Transformation"></see></summary>
    let Transformation = _prefix "Transformation"
    /// <summary>
    /// relates a transformation to the algorithm
    ///     specified by the property that computes an RDF graph from an XML
    ///     document node
    /// <see href="http://www.w3.org/2003/g/data-view#transformationProperty"></see></summary>
    let transformationProperty = _prefix "transformationProperty"
    /// <summary>
    /// a FunctionalProperty that relates
    ///     XML document root nodes to
    ///     RDF graphs
    /// <see href="http://www.w3.org/2003/g/data-view#TransformationProperty"></see></summary>
    let TransformationProperty = _prefix "TransformationProperty"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/g/data-view#danc"></see>
    /// </summary>
    let danc = _prefix "danc"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/g/data-view#grddlProject"></see>
    /// </summary>
    let grddlProject = _prefix "grddlProject"
    /// <summary>
    /// relates a namespace to a transformation for
    ///     all documents in that namespace
    /// <see href="http://www.w3.org/2003/g/data-view#namespaceTransformation"></see></summary>
    let namespaceTransformation = _prefix "namespaceTransformation"
    /// <summary>
    /// relates a profile document to a
    ///     transformation for all documents bearing that profile
    /// <see href="http://www.w3.org/2003/g/data-view#profileTransformation"></see></summary>
    let profileTransformation = _prefix "profileTransformation"
    /// <summary>
    /// an
    ///     RDF graph obtained from an information resource by directly
    ///     parsing a representation in the standard RDF/XML syntax or
    ///     indirectly by parsing some other dialect using a transformation
    ///     nominated by the document
    /// <see href="http://www.w3.org/2003/g/data-view#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// relates a source document to a
    ///     transformation, usually represented in XSLT, that relates the source document syntax
    ///     to the RDF graph syntax
    /// <see href="http://www.w3.org/2003/g/data-view#transformation"></see></summary>
    let transformation = _prefix "transformation"
