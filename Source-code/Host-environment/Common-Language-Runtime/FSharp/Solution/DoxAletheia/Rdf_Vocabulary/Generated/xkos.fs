namespace http.rdf_vocabulary.ddialliance.org.xkos.hash

open DoxAletheia.Rdf_Vocabulary

module xkos =
    let _namespace_name = "http://rdf-vocabulary.ddialliance.org/xkos#"

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#ClassificationLevel"></see>
    /// </summary>
    let ClassificationLevel =
        Namespaced_IRI.parse _namespace_name "ClassificationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#ConceptAssociation"></see>
    /// </summary>
    let ConceptAssociation =
        Namespaced_IRI.parse _namespace_name "ConceptAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#Correspondence"></see>
    /// </summary>
    let Correspondence =
        Namespaced_IRI.parse _namespace_name "Correspondence" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#ExplanatoryNote"></see>
    /// </summary>
    let ExplanatoryNote =
        Namespaced_IRI.parse _namespace_name "ExplanatoryNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#additionalContentNote"></see>
    /// </summary>
    let additionalContentNote =
        Namespaced_IRI.parse _namespace_name "additionalContentNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#inclusionNote"></see>
    /// </summary>
    let inclusionNote =
        Namespaced_IRI.parse _namespace_name "inclusionNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#after"></see>
    /// </summary>
    let after = Namespaced_IRI.parse _namespace_name "after" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#temporal"></see>
    /// </summary>
    let temporal = Namespaced_IRI.parse _namespace_name "temporal" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#before"></see>
    /// </summary>
    let before = Namespaced_IRI.parse _namespace_name "before" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#caseLaw"></see>
    /// </summary>
    let caseLaw = Namespaced_IRI.parse _namespace_name "caseLaw" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#causal"></see>
    /// </summary>
    let causal = Namespaced_IRI.parse _namespace_name "causal" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#causedBy"></see>
    /// </summary>
    let causedBy = Namespaced_IRI.parse _namespace_name "causedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#causes"></see>
    /// </summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#classifiedUnder"></see>
    /// </summary>
    let classifiedUnder =
        Namespaced_IRI.parse _namespace_name "classifiedUnder" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#compares"></see>
    /// </summary>
    let compares = Namespaced_IRI.parse _namespace_name "compares" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#coreContentNote"></see>
    /// </summary>
    let coreContentNote =
        Namespaced_IRI.parse _namespace_name "coreContentNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#covers"></see>
    /// </summary>
    let covers = Namespaced_IRI.parse _namespace_name "covers" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#coversExhaustively"></see>
    /// </summary>
    let coversExhaustively =
        Namespaced_IRI.parse _namespace_name "coversExhaustively" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#coversMutuallyExclusively"></see>
    /// </summary>
    let coversMutuallyExclusively =
        Namespaced_IRI.parse _namespace_name "coversMutuallyExclusively" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#depth"></see>
    /// </summary>
    let depth = Namespaced_IRI.parse _namespace_name "depth" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#disjoint"></see>
    /// </summary>
    let disjoint = Namespaced_IRI.parse _namespace_name "disjoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#exclusionNote"></see>
    /// </summary>
    let exclusionNote =
        Namespaced_IRI.parse _namespace_name "exclusionNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#follows"></see>
    /// </summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#generalizes"></see>
    /// </summary>
    let generalizes =
        Namespaced_IRI.parse _namespace_name "generalizes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#specializes"></see>
    /// </summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#isPartOf"></see>
    /// </summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#levels"></see>
    /// </summary>
    let levels = Namespaced_IRI.parse _namespace_name "levels" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#madeOf"></see>
    /// </summary>
    let madeOf = Namespaced_IRI.parse _namespace_name "madeOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#maxLength"></see>
    /// </summary>
    let maxLength = Namespaced_IRI.parse _namespace_name "maxLength" |> NamespacedName
    /// <summary>
    /// successeur immédiat dans la séquence
    /// immediate successor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName
    /// <summary>
    /// successeur dans la séquence
    /// successor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#succeeds"></see></summary>
    let succeeds = Namespaced_IRI.parse _namespace_name "succeeds" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#notationPattern"></see>
    /// </summary>
    let notationPattern =
        Namespaced_IRI.parse _namespace_name "notationPattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#numberOfLevels"></see>
    /// </summary>
    let numberOfLevels =
        Namespaced_IRI.parse _namespace_name "numberOfLevels" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#organizedBy"></see>
    /// </summary>
    let organizedBy =
        Namespaced_IRI.parse _namespace_name "organizedBy" |> NamespacedName

    /// <summary>
    /// This property is expected to store plain text literals, without HTML or XML markup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#plainText"></see></summary>
    let plainText = Namespaced_IRI.parse _namespace_name "plainText" |> NamespacedName
    /// <summary>
    /// predecessor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#precedes"></see></summary>
    let precedes = Namespaced_IRI.parse _namespace_name "precedes" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#sequential"></see>
    /// </summary>
    let sequential = Namespaced_IRI.parse _namespace_name "sequential" |> NamespacedName
    /// <summary>
    /// immediate predecessor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#previous"></see></summary>
    let previous = Namespaced_IRI.parse _namespace_name "previous" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#sourceConcept"></see>
    /// </summary>
    let sourceConcept =
        Namespaced_IRI.parse _namespace_name "sourceConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#supersedes"></see>
    /// </summary>
    let supersedes = Namespaced_IRI.parse _namespace_name "supersedes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#targetConcept"></see>
    /// </summary>
    let targetConcept =
        Namespaced_IRI.parse _namespace_name "targetConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#variant"></see>
    /// </summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName
