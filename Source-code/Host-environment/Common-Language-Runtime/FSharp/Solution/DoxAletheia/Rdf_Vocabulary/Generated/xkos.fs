namespace http.rdf_vocabulary.ddialliance.org.xkos.hash

open DoxAletheia

module xkos =
    let _namespace_name = "http://rdf-vocabulary.ddialliance.org/xkos#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#ClassificationLevel"></see>
    /// </summary>
    let ClassificationLevel = _prefix "ClassificationLevel"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#ConceptAssociation"></see>
    /// </summary>
    let ConceptAssociation = _prefix "ConceptAssociation"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#Correspondence"></see>
    /// </summary>
    let Correspondence = _prefix "Correspondence"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#ExplanatoryNote"></see>
    /// </summary>
    let ExplanatoryNote = _prefix "ExplanatoryNote"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#additionalContentNote"></see>
    /// </summary>
    let additionalContentNote = _prefix "additionalContentNote"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#inclusionNote"></see>
    /// </summary>
    let inclusionNote = _prefix "inclusionNote"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#after"></see>
    /// </summary>
    let after = _prefix "after"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#temporal"></see>
    /// </summary>
    let temporal = _prefix "temporal"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#before"></see>
    /// </summary>
    let before = _prefix "before"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#caseLaw"></see>
    /// </summary>
    let caseLaw = _prefix "caseLaw"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#causal"></see>
    /// </summary>
    let causal = _prefix "causal"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#causedBy"></see>
    /// </summary>
    let causedBy = _prefix "causedBy"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#causes"></see>
    /// </summary>
    let causes = _prefix "causes"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#classifiedUnder"></see>
    /// </summary>
    let classifiedUnder = _prefix "classifiedUnder"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#compares"></see>
    /// </summary>
    let compares = _prefix "compares"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#coreContentNote"></see>
    /// </summary>
    let coreContentNote = _prefix "coreContentNote"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#covers"></see>
    /// </summary>
    let covers = _prefix "covers"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#coversExhaustively"></see>
    /// </summary>
    let coversExhaustively = _prefix "coversExhaustively"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#coversMutuallyExclusively"></see>
    /// </summary>
    let coversMutuallyExclusively = _prefix "coversMutuallyExclusively"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#depth"></see>
    /// </summary>
    let depth = _prefix "depth"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#disjoint"></see>
    /// </summary>
    let disjoint = _prefix "disjoint"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#exclusionNote"></see>
    /// </summary>
    let exclusionNote = _prefix "exclusionNote"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#follows"></see>
    /// </summary>
    let follows = _prefix "follows"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#generalizes"></see>
    /// </summary>
    let generalizes = _prefix "generalizes"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#specializes"></see>
    /// </summary>
    let specializes = _prefix "specializes"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#isPartOf"></see>
    /// </summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#levels"></see>
    /// </summary>
    let levels = _prefix "levels"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#madeOf"></see>
    /// </summary>
    let madeOf = _prefix "madeOf"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#maxLength"></see>
    /// </summary>
    let maxLength = _prefix "maxLength"
    /// <summary>
    /// successeur immédiat dans la séquence
    /// immediate successor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// successeur dans la séquence
    /// successor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#succeeds"></see></summary>
    let succeeds = _prefix "succeeds"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#notationPattern"></see>
    /// </summary>
    let notationPattern = _prefix "notationPattern"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#numberOfLevels"></see>
    /// </summary>
    let numberOfLevels = _prefix "numberOfLevels"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#organizedBy"></see>
    /// </summary>
    let organizedBy = _prefix "organizedBy"
    /// <summary>
    /// This property is expected to store plain text literals, without HTML or XML markup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#plainText"></see></summary>
    let plainText = _prefix "plainText"
    /// <summary>
    /// predecessor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#precedes"></see></summary>
    let precedes = _prefix "precedes"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#sequential"></see>
    /// </summary>
    let sequential = _prefix "sequential"
    /// <summary>
    /// immediate predecessor in the sequence
    /// <see href="http://rdf-vocabulary.ddialliance.org/xkos#previous"></see></summary>
    let previous = _prefix "previous"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#sourceConcept"></see>
    /// </summary>
    let sourceConcept = _prefix "sourceConcept"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#supersedes"></see>
    /// </summary>
    let supersedes = _prefix "supersedes"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#targetConcept"></see>
    /// </summary>
    let targetConcept = _prefix "targetConcept"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/xkos#variant"></see>
    /// </summary>
    let variant = _prefix "variant"
