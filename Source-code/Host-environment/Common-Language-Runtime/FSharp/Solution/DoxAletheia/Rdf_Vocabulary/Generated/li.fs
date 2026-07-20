namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.lineage.hash

open DoxAletheia

module li =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Source"></see>
    /// </summary>
    let Source = _prefix "Source"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Lineage"></see>
    /// </summary>
    let Lineage = _prefix "Lineage"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processor"></see>
    /// </summary>
    let processor = _prefix "processor"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#scaleDenominator"></see>
    /// </summary>
    let scaleDenominator = _prefix "scaleDenominator"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceReferenceSystem"></see>
    /// </summary>
    let sourceReferenceSystem = _prefix "sourceReferenceSystem"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#ProcessStep"></see>
    /// </summary>
    let ProcessStep = _prefix "ProcessStep"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#statement"></see>
    /// </summary>
    let statement = _prefix "statement"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceCitation"></see>
    /// </summary>
    let sourceCitation = _prefix "sourceCitation"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#dateTime"></see>
    /// </summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceStep"></see>
    /// </summary>
    let sourceStep = _prefix "sourceStep"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processStep"></see>
    /// </summary>
    let processStep = _prefix "processStep"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceExtent"></see>
    /// </summary>
    let sourceExtent = _prefix "sourceExtent"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#rationale"></see>
    /// </summary>
    let rationale = _prefix "rationale"
