namespace http.imgpedia.dcc.uchile.cl.ontology.hash

open DoxAletheia

module imo =
    let _namespace_name = "http://imgpedia.dcc.uchile.cl/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#CLD"></see>
    /// </summary>
    let CLD = _prefix "CLD"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#Descriptor"></see>
    /// </summary>
    let Descriptor = _prefix "Descriptor"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#GHD"></see>
    /// </summary>
    let GHD = _prefix "GHD"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#HOG"></see>
    /// </summary>
    let HOG = _prefix "HOG"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#ImageRelation"></see>
    /// </summary>
    let ImageRelation = _prefix "ImageRelation"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#appearsIn"></see>
    /// </summary>
    let appearsIn = _prefix "appearsIn"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#describes"></see>
    /// </summary>
    let describes = _prefix "describes"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#distance"></see>
    /// </summary>
    let distance = _prefix "distance"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#fileURL"></see>
    /// </summary>
    let fileURL = _prefix "fileURL"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#height"></see>
    /// </summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#similar"></see>
    /// </summary>
    let similar = _prefix "similar"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#sourceImg"></see>
    /// </summary>
    let sourceImg = _prefix "sourceImg"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#targetImg"></see>
    /// </summary>
    let targetImg = _prefix "targetImg"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#usesDescriptor"></see>
    /// </summary>
    let usesDescriptor = _prefix "usesDescriptor"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#width"></see>
    /// </summary>
    let width = _prefix "width"
