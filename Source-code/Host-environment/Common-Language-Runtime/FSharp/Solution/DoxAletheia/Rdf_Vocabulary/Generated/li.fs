namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.lineage.hash

open DoxAletheia.Rdf_Vocabulary

module li =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Source"></see>
    /// </summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Lineage"></see>
    /// </summary>
    let Lineage = Namespaced_IRI.parse _namespace_name "Lineage" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processor"></see>
    /// </summary>
    let processor = Namespaced_IRI.parse _namespace_name "processor" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#scaleDenominator"></see>
    /// </summary>
    let scaleDenominator =
        Namespaced_IRI.parse _namespace_name "scaleDenominator" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceReferenceSystem"></see>
    /// </summary>
    let sourceReferenceSystem =
        Namespaced_IRI.parse _namespace_name "sourceReferenceSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#ProcessStep"></see>
    /// </summary>
    let ProcessStep =
        Namespaced_IRI.parse _namespace_name "ProcessStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#statement"></see>
    /// </summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceCitation"></see>
    /// </summary>
    let sourceCitation =
        Namespaced_IRI.parse _namespace_name "sourceCitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#dateTime"></see>
    /// </summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceStep"></see>
    /// </summary>
    let sourceStep = Namespaced_IRI.parse _namespace_name "sourceStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processStep"></see>
    /// </summary>
    let processStep =
        Namespaced_IRI.parse _namespace_name "processStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceExtent"></see>
    /// </summary>
    let sourceExtent =
        Namespaced_IRI.parse _namespace_name "sourceExtent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#rationale"></see>
    /// </summary>
    let rationale = Namespaced_IRI.parse _namespace_name "rationale" |> NamespacedName
