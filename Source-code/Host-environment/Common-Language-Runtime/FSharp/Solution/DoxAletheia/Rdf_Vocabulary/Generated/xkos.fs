namespace http.rdf_vocabulary.ddialliance.org.xkos.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xkos =
    let _namespace_iri = Namespace_Iri xkos |> NamespaceIRI
    /// <summary>
    ///   <para>xkos:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>before</para><para>avant</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#before">http://rdf-vocabulary.ddialliance.org/xkos#before</seealso>
    let before = Prefixed_Name(xkos, "before") |> PrefixedName
    /// <summary>
    ///   <para>xkos:ClassificationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Niveau de nomenclature</para><para>Classification level</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#ClassificationLevel">http://rdf-vocabulary.ddialliance.org/xkos#ClassificationLevel</seealso>
    let ClassificationLevel = Prefixed_Name(xkos, "ClassificationLevel") |> PrefixedName
    /// <summary>
    ///   <para>xkos:Correspondence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Correspondence</para><para>Correspondance</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#Correspondence">http://rdf-vocabulary.ddialliance.org/xkos#Correspondence</seealso>
    let Correspondence = Prefixed_Name(xkos, "Correspondence") |> PrefixedName

    /// <summary>
    ///   <para>xkos:additionalContentNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>additional content</para><para>contenu limite</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#additionalContentNote">http://rdf-vocabulary.ddialliance.org/xkos#additionalContentNote</seealso>
    let additionalContentNote =
        Prefixed_Name(xkos, "additionalContentNote") |> PrefixedName

    /// <summary>
    ///   <para>xkos:caseLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>jurisprudence</para><para>case law</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#caseLaw">http://rdf-vocabulary.ddialliance.org/xkos#caseLaw</seealso>
    let caseLaw = Prefixed_Name(xkos, "caseLaw") |> PrefixedName
    /// <summary>
    ///   <para>xkos:ExplanatoryNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Note explicative</para><para>Explanatory note</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#ExplanatoryNote">http://rdf-vocabulary.ddialliance.org/xkos#ExplanatoryNote</seealso>
    let ExplanatoryNote = Prefixed_Name(xkos, "ExplanatoryNote") |> PrefixedName
    /// <summary>
    ///   <para>xkos:inclusionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>inclusions</para><para>inclusions</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#inclusionNote">http://rdf-vocabulary.ddialliance.org/xkos#inclusionNote</seealso>
    let inclusionNote = Prefixed_Name(xkos, "inclusionNote") |> PrefixedName
    /// <summary>
    ///   <para>xkos:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>after</para><para>après</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#after">http://rdf-vocabulary.ddialliance.org/xkos#after</seealso>
    let after = Prefixed_Name(xkos, "after") |> PrefixedName
    /// <summary>
    ///   <para>xkos:temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>en relation temporelle</para><para>has temporal</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#temporal">http://rdf-vocabulary.ddialliance.org/xkos#temporal</seealso>
    let temporal = Prefixed_Name(xkos, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>xkos:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>appartient à</para><para>belongs to</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#belongsTo">http://rdf-vocabulary.ddialliance.org/xkos#belongsTo</seealso>
    let belongsTo = Prefixed_Name(xkos, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>xkos:causal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>en relation causale</para><para>has causal</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#causal">http://rdf-vocabulary.ddialliance.org/xkos#causal</seealso>
    let causal = Prefixed_Name(xkos, "causal") |> PrefixedName
    /// <summary>
    ///   <para>xkos:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>est la cause de</para><para>causes</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#causes">http://rdf-vocabulary.ddialliance.org/xkos#causes</seealso>
    let causes = Prefixed_Name(xkos, "causes") |> PrefixedName
    /// <summary>
    ///   <para>xkos:compares</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>compares</para><para>compare</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#compares">http://rdf-vocabulary.ddialliance.org/xkos#compares</seealso>
    let compares = Prefixed_Name(xkos, "compares") |> PrefixedName
    /// <summary>
    ///   <para>xkos:covers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>couvre</para><para>covers</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#covers">http://rdf-vocabulary.ddialliance.org/xkos#covers</seealso>
    let covers = Prefixed_Name(xkos, "covers") |> PrefixedName
    /// <summary>
    ///   <para>xkos:coversExhaustively</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>couvre exhaustivement</para><para>covers exhaustively</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#coversExhaustively">http://rdf-vocabulary.ddialliance.org/xkos#coversExhaustively</seealso>
    let coversExhaustively = Prefixed_Name(xkos, "coversExhaustively") |> PrefixedName
    /// <summary>
    ///   <para>xkos:causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>est causé par</para><para>caused by</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#causedBy">http://rdf-vocabulary.ddialliance.org/xkos#causedBy</seealso>
    let causedBy = Prefixed_Name(xkos, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>xkos:classifiedUnder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>classified under</para><para>classé sous</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#classifiedUnder">http://rdf-vocabulary.ddialliance.org/xkos#classifiedUnder</seealso>
    let classifiedUnder = Prefixed_Name(xkos, "classifiedUnder") |> PrefixedName
    /// <summary>
    ///   <para>xkos:coreContentNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>contenu central</para><para>core content</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#coreContentNote">http://rdf-vocabulary.ddialliance.org/xkos#coreContentNote</seealso>
    let coreContentNote = Prefixed_Name(xkos, "coreContentNote") |> PrefixedName

    /// <summary>
    ///   <para>xkos:coversMutuallyExclusively</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>covers mutually exclusively</para><para>couvre sans recouvrement</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#coversMutuallyExclusively">http://rdf-vocabulary.ddialliance.org/xkos#coversMutuallyExclusively</seealso>
    let coversMutuallyExclusively =
        Prefixed_Name(xkos, "coversMutuallyExclusively") |> PrefixedName

    /// <summary>
    ///   <para>xkos:disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>disjoint from</para><para>disjoint de</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#disjoint">http://rdf-vocabulary.ddialliance.org/xkos#disjoint</seealso>
    let disjoint = Prefixed_Name(xkos, "disjoint") |> PrefixedName
    /// <summary>
    ///   <para>xkos:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>specializes</para><para>spécialise</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#specializes">http://rdf-vocabulary.ddialliance.org/xkos#specializes</seealso>
    let specializes = Prefixed_Name(xkos, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>xkos:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>est une partie de</para><para>is a part of</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#isPartOf">http://rdf-vocabulary.ddialliance.org/xkos#isPartOf</seealso>
    let isPartOf = Prefixed_Name(xkos, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>xkos:levels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>liste des niveaux</para><para>level list</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#levels">http://rdf-vocabulary.ddialliance.org/xkos#levels</seealso>
    let levels = Prefixed_Name(xkos, "levels") |> PrefixedName
    /// <summary>
    ///   <para>xkos:madeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>comprend</para><para>made of</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#madeOf">http://rdf-vocabulary.ddialliance.org/xkos#madeOf</seealso>
    let madeOf = Prefixed_Name(xkos, "madeOf") |> PrefixedName
    /// <summary>
    ///   <para>xkos:maxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>longueur maximale</para><para>maximum length</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#maxLength">http://rdf-vocabulary.ddialliance.org/xkos#maxLength</seealso>
    let maxLength = Prefixed_Name(xkos, "maxLength") |> PrefixedName
    /// <summary>
    ///   <para>xkos:succeeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>successeur dans la séquence</para>
    ///   <para>successor in the sequence</para>
    /// labels<para>succède à</para><para>succeeds</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#succeeds">http://rdf-vocabulary.ddialliance.org/xkos#succeeds</seealso>
    let succeeds = Prefixed_Name(xkos, "succeeds") |> PrefixedName
    /// <summary>
    ///   <para>xkos:notationPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>gabarit de code</para><para>code pattern</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#notationPattern">http://rdf-vocabulary.ddialliance.org/xkos#notationPattern</seealso>
    let notationPattern = Prefixed_Name(xkos, "notationPattern") |> PrefixedName
    /// <summary>
    ///   <para>xkos:organizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>organized by</para><para>organisé en</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#organizedBy">http://rdf-vocabulary.ddialliance.org/xkos#organizedBy</seealso>
    let organizedBy = Prefixed_Name(xkos, "organizedBy") |> PrefixedName
    /// <summary>
    ///   <para>xkos:depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>profondeur</para><para>depth</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#depth">http://rdf-vocabulary.ddialliance.org/xkos#depth</seealso>
    let depth = Prefixed_Name(xkos, "depth") |> PrefixedName
    /// <summary>
    ///   <para>xkos:exclusionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>exclusions</para><para>exclusions</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#exclusionNote">http://rdf-vocabulary.ddialliance.org/xkos#exclusionNote</seealso>
    let exclusionNote = Prefixed_Name(xkos, "exclusionNote") |> PrefixedName
    /// <summary>
    ///   <para>xkos:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>follows</para><para>suit</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#follows">http://rdf-vocabulary.ddialliance.org/xkos#follows</seealso>
    let follows = Prefixed_Name(xkos, "follows") |> PrefixedName
    /// <summary>
    ///   <para>xkos:generalizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>generalizes</para><para>généralise</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#generalizes">http://rdf-vocabulary.ddialliance.org/xkos#generalizes</seealso>
    let generalizes = Prefixed_Name(xkos, "generalizes") |> PrefixedName
    /// <summary>
    ///   <para>xkos:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a pour partie</para><para>has part</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#hasPart">http://rdf-vocabulary.ddialliance.org/xkos#hasPart</seealso>
    let hasPart = Prefixed_Name(xkos, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>xkos:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>immediate successor in the sequence</para>
    ///   <para>successeur immédiat dans la séquence</para>
    /// labels<para>suivant</para><para>next</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#next">http://rdf-vocabulary.ddialliance.org/xkos#next</seealso>
    let next = Prefixed_Name(xkos, "next") |> PrefixedName
    /// <summary>
    ///   <para>xkos:numberOfLevels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>nombre de niveaux</para><para>number of levels</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#numberOfLevels">http://rdf-vocabulary.ddialliance.org/xkos#numberOfLevels</seealso>
    let numberOfLevels = Prefixed_Name(xkos, "numberOfLevels") |> PrefixedName
    /// <summary>
    ///   <para>xkos:plainText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property is expected to store plain text literals, without HTML or XML markup.</para>
    /// labels<para>plain text</para><para>texte brut</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#plainText">http://rdf-vocabulary.ddialliance.org/xkos#plainText</seealso>
    let plainText = Prefixed_Name(xkos, "plainText") |> PrefixedName
    /// <summary>
    ///   <para>xkos:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>predecessor in the sequence</para>
    ///   <para>prédécesseur dans la séquence</para>
    /// labels<para>precedes</para><para>précède</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#precedes">http://rdf-vocabulary.ddialliance.org/xkos#precedes</seealso>
    let precedes = Prefixed_Name(xkos, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>xkos:sourceConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>concept source</para><para>source concept</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#sourceConcept">http://rdf-vocabulary.ddialliance.org/xkos#sourceConcept</seealso>
    let sourceConcept = Prefixed_Name(xkos, "sourceConcept") |> PrefixedName
    /// <summary>
    ///   <para>xkos:supersedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supersedes</para><para>remplace</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#supersedes">http://rdf-vocabulary.ddialliance.org/xkos#supersedes</seealso>
    let supersedes = Prefixed_Name(xkos, "supersedes") |> PrefixedName
    /// <summary>
    ///   <para>xkos:targetConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>target concept</para><para>concept cible</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#targetConcept">http://rdf-vocabulary.ddialliance.org/xkos#targetConcept</seealso>
    let targetConcept = Prefixed_Name(xkos, "targetConcept") |> PrefixedName
    /// <summary>
    ///   <para>xkos:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>variante</para><para>variant</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#variant">http://rdf-vocabulary.ddialliance.org/xkos#variant</seealso>
    let variant = Prefixed_Name(xkos, "variant") |> PrefixedName
    /// <summary>
    ///   <para>xkos:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#">http://rdf-vocabulary.ddialliance.org/xkos#</seealso>
    let _prefix_iri = Prefixed_Name(xkos, "") |> PrefixedName
    /// <summary>
    ///   <para>xkos:ConceptAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Association de concepts</para><para>Concept association</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#ConceptAssociation">http://rdf-vocabulary.ddialliance.org/xkos#ConceptAssociation</seealso>
    let ConceptAssociation = Prefixed_Name(xkos, "ConceptAssociation") |> PrefixedName
    /// <summary>
    ///   <para>xkos:sequential</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>en relation séquentielle</para><para>has sequential</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#sequential">http://rdf-vocabulary.ddialliance.org/xkos#sequential</seealso>
    let sequential = Prefixed_Name(xkos, "sequential") |> PrefixedName
    /// <summary>
    ///   <para>xkos:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>prédécesseur immédiat dans la séquence</para>
    ///   <para>immediate predecessor in the sequence</para>
    /// labels<para>précédent</para><para>previous</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/xkos#previous">http://rdf-vocabulary.ddialliance.org/xkos#previous</seealso>
    let previous = Prefixed_Name(xkos, "previous") |> PrefixedName
