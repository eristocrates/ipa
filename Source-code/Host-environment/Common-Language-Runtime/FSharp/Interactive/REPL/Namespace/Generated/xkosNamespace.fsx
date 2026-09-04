#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module xkos =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf-vocabulary.ddialliance.org/xkos#" "xkos"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Niveau de nomenclaturerdfs:label : Classification level</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#ClassificationLevel">xkos:ClassificationLevel</a>
    /// </summary>
    let ClassificationLevel = _prefixId.prefix "ClassificationLevel"
    /// <summary>
    ///   <para>rdfs:label : Association de conceptsrdfs:label : Concept association</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#ConceptAssociation">xkos:ConceptAssociation</a>
    /// </summary>
    let ConceptAssociation = _prefixId.prefix "ConceptAssociation"
    /// <summary>
    ///   <para>rdfs:label : Correspondancerdfs:label : Correspondence</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#Correspondence">xkos:Correspondence</a>
    /// </summary>
    let Correspondence = _prefixId.prefix "Correspondence"
    /// <summary>
    ///   <para>rdfs:label : Note explicativerdfs:label : Explanatory note</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#ExplanatoryNote">xkos:ExplanatoryNote</a>
    /// </summary>
    let ExplanatoryNote = _prefixId.prefix "ExplanatoryNote"
    /// <summary>
    ///   <para>rdfs:label : contenu limiterdfs:label : additional content</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#additionalContentNote">xkos:additionalContentNote</a>
    /// </summary>
    let additionalContentNote = _prefixId.prefix "additionalContentNote"
    /// <summary>
    ///   <para>rdfs:label : aprèsrdfs:label : after</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#after">xkos:after</a>
    /// </summary>
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>rdfs:label : avantrdfs:label : before</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#before">xkos:before</a>
    /// </summary>
    let before = _prefixId.prefix "before"
    /// <summary>
    ///   <para>rdfs:label : appartient àrdfs:label : belongs to</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#belongsTo">xkos:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:label : jurisprudencerdfs:label : case law</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#caseLaw">xkos:caseLaw</a>
    /// </summary>
    let caseLaw = _prefixId.prefix "caseLaw"
    /// <summary>
    ///   <para>rdfs:label : en relation causalerdfs:label : has causal</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#causal">xkos:causal</a>
    /// </summary>
    let causal = _prefixId.prefix "causal"
    /// <summary>
    ///   <para>rdfs:label : est causé parrdfs:label : caused by</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#causedBy">xkos:causedBy</a>
    /// </summary>
    let causedBy = _prefixId.prefix "causedBy"
    /// <summary>
    ///   <para>rdfs:label : est la cause derdfs:label : causes</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#causes">xkos:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>rdfs:label : classé sousrdfs:label : classified under</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#classifiedUnder">xkos:classifiedUnder</a>
    /// </summary>
    let classifiedUnder = _prefixId.prefix "classifiedUnder"
    /// <summary>
    ///   <para>rdfs:label : comparerdfs:label : compares</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#compares">xkos:compares</a>
    /// </summary>
    let compares = _prefixId.prefix "compares"
    /// <summary>
    ///   <para>rdfs:label : contenu centralrdfs:label : core content</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#coreContentNote">xkos:coreContentNote</a>
    /// </summary>
    let coreContentNote = _prefixId.prefix "coreContentNote"
    /// <summary>
    ///   <para>rdfs:label : couvrerdfs:label : covers</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#covers">xkos:covers</a>
    /// </summary>
    let covers = _prefixId.prefix "covers"
    /// <summary>
    ///   <para>rdfs:label : couvre exhaustivementrdfs:label : covers exhaustively</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#coversExhaustively">xkos:coversExhaustively</a>
    /// </summary>
    let coversExhaustively = _prefixId.prefix "coversExhaustively"
    /// <summary>
    ///   <para>rdfs:label : couvre sans recouvrementrdfs:label : covers mutually exclusively</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#coversMutuallyExclusively">xkos:coversMutuallyExclusively</a>
    /// </summary>
    let coversMutuallyExclusively = _prefixId.prefix "coversMutuallyExclusively"
    /// <summary>
    ///   <para>rdfs:label : profondeurrdfs:label : depth</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#depth">xkos:depth</a>
    /// </summary>
    let depth = _prefixId.prefix "depth"
    /// <summary>
    ///   <para>rdfs:label : disjoint derdfs:label : disjoint from</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#disjoint">xkos:disjoint</a>
    /// </summary>
    let disjoint = _prefixId.prefix "disjoint"
    /// <summary>
    ///   <para>rdfs:label : exclusionsrdfs:label : exclusions</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#exclusionNote">xkos:exclusionNote</a>
    /// </summary>
    let exclusionNote = _prefixId.prefix "exclusionNote"
    /// <summary>
    ///   <para>rdfs:label : suitrdfs:label : follows</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#follows">xkos:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:label : généraliserdfs:label : generalizes</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#generalizes">xkos:generalizes</a>
    /// </summary>
    let generalizes = _prefixId.prefix "generalizes"
    /// <summary>
    ///   <para>rdfs:label : a pour partierdfs:label : has part</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#hasPart">xkos:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : inclusionsrdfs:label : inclusions</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#inclusionNote">xkos:inclusionNote</a>
    /// </summary>
    let inclusionNote = _prefixId.prefix "inclusionNote"
    /// <summary>
    ///   <para>rdfs:label : est une partie derdfs:label : is a part of</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#isPartOf">xkos:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : liste des niveauxrdfs:label : level list</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#levels">xkos:levels</a>
    /// </summary>
    let levels = _prefixId.prefix "levels"
    /// <summary>
    ///   <para>rdfs:label : comprendrdfs:label : made of</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#madeOf">xkos:madeOf</a>
    /// </summary>
    let madeOf = _prefixId.prefix "madeOf"
    /// <summary>
    ///   <para>rdfs:label : longueur maximalerdfs:label : maximum length</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#maxLength">xkos:maxLength</a>
    /// </summary>
    let maxLength = _prefixId.prefix "maxLength"
    /// <summary>
    ///   <para>rdfs:comment : successeur immédiat dans la séquence^^xsd:stringrdfs:comment : immediate successor in the sequence</para>
    ///   <para>rdfs:label : suivantrdfs:label : next</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#next">xkos:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:label : gabarit de coderdfs:label : code pattern</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#notationPattern">xkos:notationPattern</a>
    /// </summary>
    let notationPattern = _prefixId.prefix "notationPattern"
    /// <summary>
    ///   <para>rdfs:label : nombre de niveauxrdfs:label : number of levels</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#numberOfLevels">xkos:numberOfLevels</a>
    /// </summary>
    let numberOfLevels = _prefixId.prefix "numberOfLevels"
    /// <summary>
    ///   <para>rdfs:label : organisé enrdfs:label : organized by</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#organizedBy">xkos:organizedBy</a>
    /// </summary>
    let organizedBy = _prefixId.prefix "organizedBy"
    /// <summary>
    ///   <para>rdfs:comment : This property is expected to store plain text literals, without HTML or XML markup.</para>
    ///   <para>rdfs:label : texte brutrdfs:label : plain text</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#plainText">xkos:plainText</a>
    /// </summary>
    let plainText = _prefixId.prefix "plainText"
    /// <summary>
    ///   <para>rdfs:comment : prédécesseur dans la séquencerdfs:comment : predecessor in the sequence</para>
    ///   <para>rdfs:label : précèderdfs:label : precedes</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#precedes">xkos:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:comment : prédécesseur immédiat dans la séquencerdfs:comment : immediate predecessor in the sequence</para>
    ///   <para>rdfs:label : précédentrdfs:label : previous</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#previous">xkos:previous</a>
    /// </summary>
    let previous = _prefixId.prefix "previous"
    /// <summary>
    ///   <para>rdfs:label : en relation séquentiellerdfs:label : has sequential</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#sequential">xkos:sequential</a>
    /// </summary>
    let sequential = _prefixId.prefix "sequential"
    /// <summary>
    ///   <para>rdfs:label : concept sourcerdfs:label : source concept</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#sourceConcept">xkos:sourceConcept</a>
    /// </summary>
    let sourceConcept = _prefixId.prefix "sourceConcept"
    /// <summary>
    ///   <para>rdfs:label : spécialiserdfs:label : specializes</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#specializes">xkos:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
    /// <summary>
    ///   <para>rdfs:comment : successeur dans la séquence^^xsd:stringrdfs:comment : successor in the sequence</para>
    ///   <para>rdfs:label : succède àrdfs:label : succeeds</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#succeeds">xkos:succeeds</a>
    /// </summary>
    let succeeds = _prefixId.prefix "succeeds"
    /// <summary>
    ///   <para>rdfs:label : remplacerdfs:label : supersedes</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#supersedes">xkos:supersedes</a>
    /// </summary>
    let supersedes = _prefixId.prefix "supersedes"
    /// <summary>
    ///   <para>rdfs:label : concept ciblerdfs:label : target concept</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#targetConcept">xkos:targetConcept</a>
    /// </summary>
    let targetConcept = _prefixId.prefix "targetConcept"
    /// <summary>
    ///   <para>rdfs:label : en relation temporellerdfs:label : has temporal</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#temporal">xkos:temporal</a>
    /// </summary>
    let temporal = _prefixId.prefix "temporal"
    /// <summary>
    ///   <para>rdfs:label : varianterdfs:label : variant</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/xkos#variant">xkos:variant</a>
    /// </summary>
    let variant = _prefixId.prefix "variant"
