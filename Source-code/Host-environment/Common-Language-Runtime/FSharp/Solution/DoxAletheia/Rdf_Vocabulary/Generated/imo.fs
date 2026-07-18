namespace http.imgpedia.dcc.uchile.cl.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module imo =
    let _namespace_name = "http://imgpedia.dcc.uchile.cl/ontology#"
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#CLD"></see>
    /// </summary>
    let CLD = Namespaced_IRI.parse _namespace_name "CLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#Descriptor"></see>
    /// </summary>
    let Descriptor = Namespaced_IRI.parse _namespace_name "Descriptor" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#GHD"></see>
    /// </summary>
    let GHD = Namespaced_IRI.parse _namespace_name "GHD" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#HOG"></see>
    /// </summary>
    let HOG = Namespaced_IRI.parse _namespace_name "HOG" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#ImageRelation"></see>
    /// </summary>
    let ImageRelation =
        Namespaced_IRI.parse _namespace_name "ImageRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#appearsIn"></see>
    /// </summary>
    let appearsIn = Namespaced_IRI.parse _namespace_name "appearsIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#describes"></see>
    /// </summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#distance"></see>
    /// </summary>
    let distance = Namespaced_IRI.parse _namespace_name "distance" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#fileURL"></see>
    /// </summary>
    let fileURL = Namespaced_IRI.parse _namespace_name "fileURL" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#height"></see>
    /// </summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#similar"></see>
    /// </summary>
    let similar = Namespaced_IRI.parse _namespace_name "similar" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#sourceImg"></see>
    /// </summary>
    let sourceImg = Namespaced_IRI.parse _namespace_name "sourceImg" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#targetImg"></see>
    /// </summary>
    let targetImg = Namespaced_IRI.parse _namespace_name "targetImg" |> NamespacedName

    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#usesDescriptor"></see>
    /// </summary>
    let usesDescriptor =
        Namespaced_IRI.parse _namespace_name "usesDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://imgpedia.dcc.uchile.cl/ontology#width"></see>
    /// </summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
