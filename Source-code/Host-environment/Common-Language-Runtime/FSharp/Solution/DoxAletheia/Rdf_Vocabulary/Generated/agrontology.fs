namespace http.aims.fao.org.aos.agrontology.hash

open DoxAletheia.Rdf_Vocabulary

module agrontology =
    let _namespace_name = "http://aims.fao.org/aos/agrontology#"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#RangeOfHasTermType"></see>
    /// </summary>
    let RangeOfHasTermType =
        Namespaced_IRI.parse _namespace_name "RangeOfHasTermType" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#RangeOfIsPartOfSubvocabulary"></see>
    /// </summary>
    let RangeOfIsPartOfSubvocabulary =
        Namespaced_IRI.parse _namespace_name "RangeOfIsPartOfSubvocabulary" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#actsUpon"></see>
    /// </summary>
    let actsUpon = Namespaced_IRI.parse _namespace_name "actsUpon" |> NamespacedName

    /// <summary>
    /// Super-property for causative relationships
    /// <see href="http://aims.fao.org/aos/agrontology#causativeRelationship"></see></summary>
    let causativeRelationship =
        Namespaced_IRI.parse _namespace_name "causativeRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isActedUponBy"></see>
    /// </summary>
    let isActedUponBy =
        Namespaced_IRI.parse _namespace_name "isActedUponBy" |> NamespacedName

    /// <summary>
    /// X &lt;affects&gt; Y. Action of agent X changes the state or location of Y. E.g. "water depletion" &lt;affects&gt; "groundwater table", "mechanical damage" &lt;affects&gt; “transporting quality”. Do not use for diseases or disorders; for those, use &lt;afflicts/is afflicted by&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#affects"></see></summary>
    let affects = Namespaced_IRI.parse _namespace_name "affects" |> NamespacedName

    /// <summary>
    /// Y &lt;is affected by&gt; X. An object Y changes state or location because of an action of an agent X. E.g. "trees" &lt;is affected by&gt; "arboricides", "transporting quality" &lt;is affected by&gt; "mechanical damage". Do not use for diseases or disorders; for those, use &lt;afflicts/is afflicted by&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#isAffectedBy"></see></summary>
    let isAffectedBy =
        Namespaced_IRI.parse _namespace_name "isAffectedBy" |> NamespacedName

    /// <summary>
    /// X &lt;afflicts&gt; Y. The disease or disorder X could have negative effects in Y, such as adversely affect the health of an organism or body part Y. E.g. "scrapie" &lt;afflicts&gt; "sheep", “glossitis” &lt;afflicts&gt; “tongue”.
    /// <see href="http://aims.fao.org/aos/agrontology#afflicts"></see></summary>
    let afflicts = Namespaced_IRI.parse _namespace_name "afflicts" |> NamespacedName

    /// <summary>
    /// Y &lt;is afflicted by&gt; X. The health or wellbeing of an organism or body part Y could adversely be affected by the disease X. E.g. "honey bees" &lt;is afflicted by&gt; "varoosis", "tongue" &lt;is afflicted by&gt; "glossitis".
    /// <see href="http://aims.fao.org/aos/agrontology#isAfflictedBy"></see></summary>
    let isAfflictedBy =
        Namespaced_IRI.parse _namespace_name "isAfflictedBy" |> NamespacedName

    /// <summary>
    /// Y &lt;benefitsFrom&gt; X. A result Y  that is advantageous to some beneficiary, produced by the behaviour of an agent X. A consequence Y achieved through a means X. E.g. "biological control" &lt;benefitsFrom&gt; "biological control arthropods"; "plant health" &lt;benefitsFrom&gt; "pest control";
    /// <see href="http://aims.fao.org/aos/agrontology#benefitsFrom"></see></summary>
    let benefitsFrom =
        Namespaced_IRI.parse _namespace_name "benefitsFrom" |> NamespacedName

    /// <summary>
    /// X &lt;isBeneficialFor&gt; Y. Agent X behaves in a way that produces some result Y that is advantageous to some beneficiary. A means X through which a consequence Y can be achieved. E.g. "biological control arthropods" &lt;isBeneficialFor&gt; "biological control"; "pest control" &lt;isBeneficialFor&gt; "plant health";
    /// <see href="http://aims.fao.org/aos/agrontology#isBeneficialFor"></see></summary>
    let isBeneficialFor =
        Namespaced_IRI.parse _namespace_name "isBeneficialFor" |> NamespacedName

    /// <summary>
    /// X &lt;causes&gt; Y. Agent X (animate or inanimate) brings about a result Y. E.g. "prions" &lt;causes&gt; "spongiform encephalopathy", "soil moisture deficit" &lt;causes&gt; "wilting".
    /// <see href="http://aims.fao.org/aos/agrontology#causes"></see></summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName
    /// <summary>
    /// Y &lt;is caused by&gt; X. A result Y occurred because of an agent X (animate or inanimate). E.g. "spongiform encephalopathy" &lt;is caused by&gt; “prions”, "soil moisture deficit” &lt;is caused by&gt; "wilting".
    /// <see href="http://aims.fao.org/aos/agrontology#isCausedBy"></see></summary>
    let isCausedBy = Namespaced_IRI.parse _namespace_name "isCausedBy" |> NamespacedName
    /// <summary>
    /// Y &lt;compose&gt; X. Y is the material or substance of which X is composed. E.g. “microbial flora” &lt;compose&gt; "soil flora", “volcanic materials” &lt;compose&gt; "tuff".
    /// <see href="http://aims.fao.org/aos/agrontology#compose"></see></summary>
    let compose = Namespaced_IRI.parse _namespace_name "compose" |> NamespacedName
    /// <summary>
    ///  Y &lt;is part of&gt; X. X is composed of one or more parts, where Y is one part. E.g. “cortex” &lt;is part of&gt; “stems”, “root nodules” &lt;is part of&gt; “roots". Use this relationship when none of the other lower partitive relations (&lt;is composed of&gt;, &lt;has member&gt;) apply.
    /// <see href="http://aims.fao.org/aos/agrontology#isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    /// X &lt;is composed of&gt; Y. X is composed of material or substance Y . E.g. “soil flora” &lt;is composed of&gt; “microbial flora”, “tuff”&lt;is composed of&gt; “volcanic materials”.
    /// <see href="http://aims.fao.org/aos/agrontology#isComposedOf"></see></summary>
    let isComposedOf =
        Namespaced_IRI.parse _namespace_name "isComposedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#controls"></see>
    /// </summary>
    let controls = Namespaced_IRI.parse _namespace_name "controls" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isControlledBy"></see>
    /// </summary>
    let isControlledBy =
        Namespaced_IRI.parse _namespace_name "isControlledBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#developsFrom"></see>
    /// </summary>
    let developsFrom =
        Namespaced_IRI.parse _namespace_name "developsFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#temporalRelationship"></see>
    /// </summary>
    let temporalRelationship =
        Namespaced_IRI.parse _namespace_name "temporalRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#developsInto"></see>
    /// </summary>
    let developsInto =
        Namespaced_IRI.parse _namespace_name "developsInto" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#follows"></see>
    /// </summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#precedes"></see>
    /// </summary>
    let precedes = Namespaced_IRI.parse _namespace_name "precedes" |> NamespacedName

    /// <summary>
    /// An inclusion that was valid in the past but currently is not valid anymore.
    /// <see href="http://aims.fao.org/aos/agrontology#formerlyIncludedIn"></see></summary>
    let formerlyIncludedIn =
        Namespaced_IRI.parse _namespace_name "formerlyIncludedIn" |> NamespacedName

    /// <summary>
    /// Y &lt;is included in&gt;X. X is an entity that includes the element Y. For example: "dehorning” &lt;included in&gt; ”animal husbandry methods”, “microbiological analysis" &lt;included in&gt; “water analysis”
    /// <see href="http://aims.fao.org/aos/agrontology#isIncludedIn"></see></summary>
    let isIncludedIn =
        Namespaced_IRI.parse _namespace_name "isIncludedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#formerlyIncludes"></see>
    /// </summary>
    let formerlyIncludes =
        Namespaced_IRI.parse _namespace_name "formerlyIncludes" |> NamespacedName

    /// <summary>
    /// X &lt;includes&gt; Y. X is an entity that includes the element Y. For example: “animal husbandry methods” &lt;includes&gt; ”dehorning”, “water analysis” &lt;includes&gt; ”microbiological analysis”.
    /// <see href="http://aims.fao.org/aos/agrontology#includes"></see></summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#greaterThan"></see>
    /// </summary>
    let greaterThan =
        Namespaced_IRI.parse _namespace_name "greaterThan" |> NamespacedName

    /// <summary>
    /// Super-property for quantitative relationships. All relationships involving a quantity or a measure.
    /// <see href="http://aims.fao.org/aos/agrontology#quantitativeRelationship"></see></summary>
    let quantitativeRelationship =
        Namespaced_IRI.parse _namespace_name "quantitativeRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#smallerThan"></see>
    /// </summary>
    let smallerThan =
        Namespaced_IRI.parse _namespace_name "smallerThan" |> NamespacedName

    /// <summary>
    /// X &lt;growsIn&gt; Y. A taxon X grows in an environment Y. Use this in a plant and related domain (e.g. fungi). E.g. "jasmine rice" &lt;growsIn&gt; "isarn region"; "rice" &lt;growsIn&gt; "moist soil";
    /// <see href="http://aims.fao.org/aos/agrontology#growsln"></see></summary>
    let growsln = Namespaced_IRI.parse _namespace_name "growsln" |> NamespacedName

    /// <summary>
    /// Y &lt;isAGrowthEnvironmentFor&gt; X. An environment Y favorable to a taxon X. This is used as the inverse relationship of &lt;growsIn&gt;. Use this in a plant and related domain (e.g. fungi). E.g. "isarn region" &lt;isAGrowthEnvironmentFor&gt; "jasmine rice"; "moist soil" &lt;isAGrowthEnvironmentFor&gt; "rice";
    /// <see href="http://aims.fao.org/aos/agrontology#isAGrowthEnvironmentFor"></see></summary>
    let isAGrowthEnvironmentFor =
        Namespaced_IRI.parse _namespace_name "isAGrowthEnvironmentFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasAbbreviation"></see>
    /// </summary>
    let hasAbbreviation =
        Namespaced_IRI.parse _namespace_name "hasAbbreviation" |> NamespacedName

    /// <summary>
    /// X &lt;has synonym&gt; Y. Y &lt;has synonym&gt; X. “Bulgaria”&lt;has synonym&gt;”Republic of Bulgaria”. Used to distinguish an exact and current synonym from obsolete terms which might have been used in the past (for that, use &lt;has old name&gt;). Use only between labels for the same concept in a specific language.
    /// <see href="http://aims.fao.org/aos/agrontology#hasSynonym"></see></summary>
    let hasSynonym = Namespaced_IRI.parse _namespace_name "hasSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isAbbreviationOf"></see>
    /// </summary>
    let isAbbreviationOf =
        Namespaced_IRI.parse _namespace_name "isAbbreviationOf" |> NamespacedName

    /// <summary>
    /// X &lt;has acronym&gt; Y. An acronym is an abbreviation formed from the initial letters of other words, often pronounced as a word. E.g. “acquired immunodeficiency syndrome” &lt;has acronym&gt;”AIDS”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasAcronym"></see></summary>
    let hasAcronym = Namespaced_IRI.parse _namespace_name "hasAcronym" |> NamespacedName

    /// <summary>
    /// Y &lt;is acronym of&gt; X. An acronym is an abbreviation formed from the initial letters of other words, often pronounced as a word.  “AIDS” &lt;is acronym of&gt;”acquired immunodeficiency syndrome”.
    /// <see href="http://aims.fao.org/aos/agrontology#isAcronymOf"></see></summary>
    let isAcronymOf =
        Namespaced_IRI.parse _namespace_name "isAcronymOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasAntonym"></see>
    /// </summary>
    let hasAntonym = Namespaced_IRI.parse _namespace_name "hasAntonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasBiologicalControlAgent"></see>
    /// </summary>
    let hasBiologicalControlAgent =
        Namespaced_IRI.parse _namespace_name "hasBiologicalControlAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isBiologicalControlAgentOf"></see>
    /// </summary>
    let isBiologicalControlAgentOf =
        Namespaced_IRI.parse _namespace_name "isBiologicalControlAgentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasBreedingMethod"></see>
    /// </summary>
    let hasBreedingMethod =
        Namespaced_IRI.parse _namespace_name "hasBreedingMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isBreedingMethodOf"></see>
    /// </summary>
    let isBreedingMethodOf =
        Namespaced_IRI.parse _namespace_name "isBreedingMethodOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasBroaderSynonym"></see>
    /// </summary>
    let hasBroaderSynonym =
        Namespaced_IRI.parse _namespace_name "hasBroaderSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasNarrowerSynonym"></see>
    /// </summary>
    let hasNarrowerSynonym =
        Namespaced_IRI.parse _namespace_name "hasNarrowerSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasChemicalFormula"></see>
    /// </summary>
    let hasChemicalFormula =
        Namespaced_IRI.parse _namespace_name "hasChemicalFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isChemicalFormulaOf"></see>
    /// </summary>
    let isChemicalFormulaOf =
        Namespaced_IRI.parse _namespace_name "isChemicalFormulaOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeAsc"></see>
    /// </summary>
    let hasCodeAsc = Namespaced_IRI.parse _namespace_name "hasCodeAsc" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeAsfa"></see>
    /// </summary>
    let hasCodeAsfa =
        Namespaced_IRI.parse _namespace_name "hasCodeAsfa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeFaoPa"></see>
    /// </summary>
    let hasCodeFaoPa =
        Namespaced_IRI.parse _namespace_name "hasCodeFaoPa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeFaoterm"></see>
    /// </summary>
    let hasCodeFaoterm =
        Namespaced_IRI.parse _namespace_name "hasCodeFaoterm" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeFishery3Alpha"></see>
    /// </summary>
    let hasCodeFishery3Alpha =
        Namespaced_IRI.parse _namespace_name "hasCodeFishery3Alpha" |> NamespacedName

    /// <summary>
    /// The International Standard for country codes and codes for their subdivisions. Alpha-3 code – a three-letter code that represents a country name, which is usually more closely related to the country name
    /// <see href="http://aims.fao.org/aos/agrontology#hasCodeISO3Country"></see></summary>
    let hasCodeISO3Country =
        Namespaced_IRI.parse _namespace_name "hasCodeISO3Country" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeTaxonomic"></see>
    /// </summary>
    let hasCodeTaxonomic =
        Namespaced_IRI.parse _namespace_name "hasCodeTaxonomic" |> NamespacedName

    /// <summary>
    /// Y &lt;has common name concept&gt; X. Y is a scientifically defined concept for an organism or a group of organisms with scientific name as labels, having a specific taxonomic rank. "Apis mellifera” &lt;has common name concept&gt; “honey bees”. Use at concept level when common name and scientific name are separate concepts. For label-to-label relationship for use within a concept, use &lt;has scientific name / scientific name of&gt;.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasCommonNameConcept"></see></summary>
    let hasCommonNameConcept =
        Namespaced_IRI.parse _namespace_name "hasCommonNameConcept" |> NamespacedName

    /// <summary>
    /// Super-property for taxonomic relationships.
    /// <see href="http://aims.fao.org/aos/agrontology#taxonomicRelationship"></see></summary>
    let taxonomicRelationship =
        Namespaced_IRI.parse _namespace_name "taxonomicRelationship" |> NamespacedName

    /// <summary>
    /// X &lt;has taxonomic concept&gt; Y.  X is a common name concept for an organism or organism group. Y is the scientifically defined concept name for the same organism or a group of organisms, having a specific taxonomic rank. E.g. “honey bees” &lt;has taxonomic concept&gt; ”Apis mellifera”. Use at concept level when common name and scientific name are separate concepts. For label-to-label relationship for use within a concept, use &lt;has scientific name / scientific name of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#hasTaxonomicConcept"></see></summary>
    let hasTaxonomicConcept =
        Namespaced_IRI.parse _namespace_name "hasTaxonomicConcept" |> NamespacedName

    /// <summary>
    /// Y &lt;has component&gt; X. An object X that is a part of a whole Y and also has an existence independently from Y. E.g. "trees" &lt;has component&gt; "leaves",  "vehicle systems" &lt;has component&gt; "engines".
    /// <see href="http://aims.fao.org/aos/agrontology#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// X &lt;has part&gt; Y. A composite entity X that can be identified as being composed of one or more parts, between which Y. E.g. “stems” &lt;has part&gt; “cortex”, “roots” &lt;has part&gt;“root nodules”. Use this relationship when none of the other lower partitive relations (&lt;has component&gt;, &lt;is composed of&gt;, &lt;member&gt;) apply.
    /// <see href="http://aims.fao.org/aos/agrontology#hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    ///  X &lt;is component of&gt; Y. An object X that is a part of a whole Y, also has an existence independently from Y. E.g. "leaves" &lt;is component of&gt; "trees", "engines" &lt;is component of&gt; "vehicle systems".
    /// <see href="http://aims.fao.org/aos/agrontology#isComponentOf"></see></summary>
    let isComponentOf =
        Namespaced_IRI.parse _namespace_name "isComponentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasComposition"></see>
    /// </summary>
    let hasComposition =
        Namespaced_IRI.parse _namespace_name "hasComposition" |> NamespacedName

    /// <summary>
    /// Super-property for partitive relationships
    /// <see href="http://aims.fao.org/aos/agrontology#partitiveRelationship"></see></summary>
    let partitiveRelationship =
        Namespaced_IRI.parse _namespace_name "partitiveRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isCompositionOf"></see>
    /// </summary>
    let isCompositionOf =
        Namespaced_IRI.parse _namespace_name "isCompositionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasControlMethod"></see>
    /// </summary>
    let hasControlMethod =
        Namespaced_IRI.parse _namespace_name "hasControlMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isControlMethodOf"></see>
    /// </summary>
    let isControlMethodOf =
        Namespaced_IRI.parse _namespace_name "isControlMethodOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCropingSystem"></see>
    /// </summary>
    let hasCropingSystem =
        Namespaced_IRI.parse _namespace_name "hasCropingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isCropingSystemOf"></see>
    /// </summary>
    let isCropingSystemOf =
        Namespaced_IRI.parse _namespace_name "isCropingSystemOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCultivationProcess"></see>
    /// </summary>
    let hasCultivationProcess =
        Namespaced_IRI.parse _namespace_name "hasCultivationProcess" |> NamespacedName

    /// <summary>
    /// Super-property for process relationships
    /// <see href="http://aims.fao.org/aos/agrontology#processRelationship"></see></summary>
    let processRelationship =
        Namespaced_IRI.parse _namespace_name "processRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isCultivationProcessOf"></see>
    /// </summary>
    let isCultivationProcessOf =
        Namespaced_IRI.parse _namespace_name "isCultivationProcessOf" |> NamespacedName

    /// <summary>
    /// X &lt;has disease&gt; Y. Organism X can have disease Y. E.g. “Sorghum” &lt;has disease&gt; “loose smut of sorghum”. Organism to disease relationship.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasDisease"></see></summary>
    let hasDisease = Namespaced_IRI.parse _namespace_name "hasDisease" |> NamespacedName

    /// <summary>
    /// Y &lt;is disease for&gt; X. Disease Y is disease of organism X. E.g. “loose smut of sorghum”&lt;is disease for&gt; “Sorghum". Disease to organism relationship.
    /// <see href="http://aims.fao.org/aos/agrontology#isDiseaseFor"></see></summary>
    let isDiseaseFor =
        Namespaced_IRI.parse _namespace_name "isDiseaseFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasDisorder"></see>
    /// </summary>
    let hasDisorder =
        Namespaced_IRI.parse _namespace_name "hasDisorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isDisorderOf"></see>
    /// </summary>
    let isDisorderOf =
        Namespaced_IRI.parse _namespace_name "isDisorderOf" |> NamespacedName

    /// <summary>
    /// X &lt;has goal or process&gt; Y. X has intended goal or  process Y. E.g. “veterinary services” &lt;has goal or process&gt; “animal health”, “coppicing” &lt;has goal or process&gt; “natural regeneration”.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasGoalOrProcess"></see></summary>
    let hasGoalOrProcess =
        Namespaced_IRI.parse _namespace_name "hasGoalOrProcess" |> NamespacedName

    /// <summary>
    /// Y &lt;is achieved by means of&gt; X. Y is an objective or process used by X, without Y necessarily being part of X. E.g. “mating disruption” &lt;is achieved by means of&gt; “pheromone analogues”, “decision making” &lt;is achieved by means of&gt; “decision support systems”.
    /// <see href="http://aims.fao.org/aos/agrontology#isAchievedByMeansOf"></see></summary>
    let isAchievedByMeansOf =
        Namespaced_IRI.parse _namespace_name "isAchievedByMeansOf" |> NamespacedName

    /// <summary>
    /// X &lt;has vector or host&gt; Y.  X has organism host or vector  Y.  E.g. “Plasmodium” &lt;has host&gt; ”Anopheles”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasHost"></see></summary>
    let hasHost = Namespaced_IRI.parse _namespace_name "hasHost" |> NamespacedName
    /// <summary>
    /// Y &lt;Is vector or host for&gt; X. Organism Y is host or vector for X.  E.g. “Anopheles” &lt;is vector or host for&gt; ”Plasmodium”.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#isHostFor"></see></summary>
    let isHostFor = Namespaced_IRI.parse _namespace_name "isHostFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasInfectionPart"></see>
    /// </summary>
    let hasInfectionPart =
        Namespaced_IRI.parse _namespace_name "hasInfectionPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isInfectedPartOf"></see>
    /// </summary>
    let isInfectedPartOf =
        Namespaced_IRI.parse _namespace_name "isInfectedPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasLocalName"></see>
    /// </summary>
    let hasLocalName =
        Namespaced_IRI.parse _namespace_name "hasLocalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isLocalNameOf"></see>
    /// </summary>
    let isLocalNameOf =
        Namespaced_IRI.parse _namespace_name "isLocalNameOf" |> NamespacedName

    /// <summary>
    /// Y &lt;has member&gt; X. A social or political group Y consists of one or more subsidiary social or political units (group or individual) X. E.g. "Francophone Africa" &lt;has member&gt; "Benin", "bee colonies" &lt;has member&gt; "worker bees". Limit use to geographical or socio-political units. Do not use for grouping organisms by use, climate, or taxonomic rank. Use &lt;includes&gt; / &lt;included in&gt; if describing spatial or temporal relation, if more loose than &lt;has part/is part of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// X &lt;is member of&gt; Y. A social or political unit (group or individual) X belongs to a social or political group Y. E.g. "Benin" &lt;is member of&gt; "Francophone Africa", "worker bees" &lt;is member of&gt; "bee colonies". Limit use to geographical or socio-political units, do not use for grouping organisms (e.g. by use, climate, or taxonomic rank). Use &lt;includes/included in&gt; if describing spatial or temporal relation, but more loose than &lt;is part of.&gt;
    /// <see href="http://aims.fao.org/aos/agrontology#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasNaturalEnemy"></see>
    /// </summary>
    let hasNaturalEnemy =
        Namespaced_IRI.parse _namespace_name "hasNaturalEnemy" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isNaturalEnemyOf"></see>
    /// </summary>
    let isNaturalEnemyOf =
        Namespaced_IRI.parse _namespace_name "isNaturalEnemyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasNearSynonym"></see>
    /// </summary>
    let hasNearSynonym =
        Namespaced_IRI.parse _namespace_name "hasNearSynonym" |> NamespacedName

    /// <summary>
    /// X &lt;has object of activity&gt; Y. Activity X focuses on Y. E.g. “shearing” &lt;has object of activity&gt; “wool”, “ratification” &lt;has object of activity&gt; “treaties”.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasObjectOfActivity"></see></summary>
    let hasObjectOfActivity =
        Namespaced_IRI.parse _namespace_name "hasObjectOfActivity" |> NamespacedName

    /// <summary>
    /// Y &lt;is object of activity&gt; X. Y is the focus of activity X.  E.g. “wool” &lt;is object of activity&gt; "shearing”, “treaties" &lt;is object of activity&gt; “ratification”.
    /// <see href="http://aims.fao.org/aos/agrontology#isObjectOfActivity"></see></summary>
    let isObjectOfActivity =
        Namespaced_IRI.parse _namespace_name "isObjectOfActivity" |> NamespacedName

    /// <summary>
    /// X &lt;has old name&gt; Y. Use for obsolete labels, such as old names of countries. E.g. “Bulgaria”&lt;has old name&gt;”People’s Republic of Bulgaria”. Use only between labels for the same concept in a specific language.
    /// <see href="http://aims.fao.org/aos/agrontology#hasOldName"></see></summary>
    let hasOldName = Namespaced_IRI.parse _namespace_name "hasOldName" |> NamespacedName

    /// <summary>
    /// Y &lt;is old name of&gt; X. Use for obsolete labels , like old names of countries. E.g. “People’s Republic of Bulgaria” &lt;is old name of&gt; ”Bulgaria”. Use only for labels for the same concept in a specific language.
    /// <see href="http://aims.fao.org/aos/agrontology#isOldNameOf"></see></summary>
    let isOldNameOf =
        Namespaced_IRI.parse _namespace_name "isOldNameOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasParent"></see>
    /// </summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isParentOf"></see>
    /// </summary>
    let isParentOf = Namespaced_IRI.parse _namespace_name "isParentOf" |> NamespacedName

    /// <summary>
    /// X &lt;has pathogen&gt; Y. Organism X has pathogen Y. Pathogens are pathogenic microorganism such as viruses, bacteria and fungi. E.g. "Olea europaea" &lt;has pathogen&gt; "Xylella fastidiosa".
    /// <see href="http://aims.fao.org/aos/agrontology#hasPathogen"></see></summary>
    let hasPathogen =
        Namespaced_IRI.parse _namespace_name "hasPathogen" |> NamespacedName

    /// <summary>
    /// Y &lt;is pathogen of&gt; X . Y is pathogen of organism X. E.g. "Xylella fastidiosa" &lt;is pathogen of&gt; "Olea europaea".
    /// <see href="http://aims.fao.org/aos/agrontology#isPathogenOf"></see></summary>
    let isPathogenOf =
        Namespaced_IRI.parse _namespace_name "isPathogenOf" |> NamespacedName

    /// <summary>
    /// Y &lt;has pest&gt; X. An organism Y in which the pest X causes harm. Pests are insects, nematodes and rodents that cause damage. E.g. "Apis mellifera" &lt;has pest&gt; "Varroa destructor", "Olea europaea" &lt;has pest&gt; "Bactrocera oleae".
    /// <see href="http://aims.fao.org/aos/agrontology#hasPest"></see></summary>
    let hasPest = Namespaced_IRI.parse _namespace_name "hasPest" |> NamespacedName
    /// <summary>
    /// X &lt;pest of&gt; Y. Pest X causes harm to organism Y. E.g. "Varroa destructor" &lt;pest of&gt; "Apis mellifera".
    /// <see href="http://aims.fao.org/aos/agrontology#pestOf"></see></summary>
    let pestOf = Namespaced_IRI.parse _namespace_name "pestOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPhysiologicalFunction"></see>
    /// </summary>
    let hasPhysiologicalFunction =
        Namespaced_IRI.parse _namespace_name "hasPhysiologicalFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPhysiologicalFunctionOf"></see>
    /// </summary>
    let isPhysiologicalFunctionOf =
        Namespaced_IRI.parse _namespace_name "isPhysiologicalFunctionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPlural"></see>
    /// </summary>
    let hasPlural = Namespaced_IRI.parse _namespace_name "hasPlural" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPostProductionPractice"></see>
    /// </summary>
    let hasPostProductionPractice =
        Namespaced_IRI.parse _namespace_name "hasPostProductionPractice" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPractice"></see>
    /// </summary>
    let hasPractice =
        Namespaced_IRI.parse _namespace_name "hasPractice" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPostProductionPracticeFor"></see>
    /// </summary>
    let isPostProductionPracticeFor =
        Namespaced_IRI.parse _namespace_name "isPostProductionPracticeFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPracticeFor"></see>
    /// </summary>
    let isPracticeFor =
        Namespaced_IRI.parse _namespace_name "isPracticeFor" |> NamespacedName

    /// <summary>
    /// X &lt;has product&gt; Y. X is the source of product Y, with a processing element. E.g. “logging”&lt;has product&gt; “logging wastes”, “Spain” &lt;has product&gt; “sherry”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasProduct"></see></summary>
    let hasProduct = Namespaced_IRI.parse _namespace_name "hasProduct" |> NamespacedName
    /// <summary>
    /// Y &lt;product of&gt; X, with a processing element. Y is produced or manufactured as a result or consequence of X. E.g. “logging wastes” &lt;product of&gt; “logging”, “sherry” &lt;product of&gt; “Spain”. However, “honey” &lt;is produced by&gt; “honey bees”.
    /// <see href="http://aims.fao.org/aos/agrontology#productOf"></see></summary>
    let productOf = Namespaced_IRI.parse _namespace_name "productOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPropagationMaterial"></see>
    /// </summary>
    let hasPropagationMaterial =
        Namespaced_IRI.parse _namespace_name "hasPropagationMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPropagationMaterialOf"></see>
    /// </summary>
    let isPropagationMaterialOf =
        Namespaced_IRI.parse _namespace_name "isPropagationMaterialOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPropagationProcess"></see>
    /// </summary>
    let hasPropagationProcess =
        Namespaced_IRI.parse _namespace_name "hasPropagationProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPropagationProcessOf"></see>
    /// </summary>
    let isPropagationProcessOf =
        Namespaced_IRI.parse _namespace_name "isPropagationProcessOf" |> NamespacedName

    /// <summary>
    /// X &lt;has property&gt; Y. A property might be a quality or trait. E.g. “seed” &lt;has property&gt; “seed size", “medicinal plants” &lt;has property&gt; “medicinal properties”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// Y &lt;is property of&gt; X. A property might be a quality or trait. E.g. “seed viability” &lt;is property of&gt; “seed”, “medicinal properties” &lt;is property of&gt; “medicinal plants”.
    /// <see href="http://aims.fao.org/aos/agrontology#isPropertyOf"></see></summary>
    let isPropertyOf =
        Namespaced_IRI.parse _namespace_name "isPropertyOf" |> NamespacedName

    /// <summary>
    /// X &lt;has scientific name&gt; Y. E.g. “sea trout” &lt;has scientific name&gt; "Salmo trutta”. Label-to-label relationship for use within a concept. Use when common name and scientific name are not separate concepts, or when a separate relation between scientific and common name is needed for a specific language. When common name and scientific name are separate concepts, use concept-to-concept relation &lt;has taxonomic concept/has common name concept&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#hasScientificName"></see></summary>
    let hasScientificName =
        Namespaced_IRI.parse _namespace_name "hasScientificName" |> NamespacedName

    /// <summary>
    /// Y &lt;scientific name of&gt; X. E.g. “Salmo trutta” &lt;scientific name of&gt; "sea trout”. Label-to-label relationship for use within a concept. Use when common name and scientific name are not separate concepts, or when a separate relation between scientific and common name is needed for a specific language. When common name and scientific name are separate concepts, use concept-to-concept relation &lt;has taxonomic concept/has common name concept&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#scientificNameOf"></see></summary>
    let scientificNameOf =
        Namespaced_IRI.parse _namespace_name "scientificNameOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasSingular"></see>
    /// </summary>
    let hasSingular =
        Namespaced_IRI.parse _namespace_name "hasSingular" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasSubstitute"></see>
    /// </summary>
    let hasSubstitute =
        Namespaced_IRI.parse _namespace_name "hasSubstitute" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isSubstituteFor"></see>
    /// </summary>
    let isSubstituteFor =
        Namespaced_IRI.parse _namespace_name "isSubstituteFor" |> NamespacedName

    /// <summary>
    /// X &lt;has symbol&gt; Y. “iron” has symbol ”Fe (symbol)”. Use for disambiguation of chemical element symbols from other similar abbreviations.
    /// <see href="http://aims.fao.org/aos/agrontology#hasSymbol"></see></summary>
    let hasSymbol = Namespaced_IRI.parse _namespace_name "hasSymbol" |> NamespacedName

    /// <summary>
    /// Y &lt;is symbol for&gt; X. ”Fe (symbol)” &lt;is symbol for&gt; “iron”. Use for disambiguation of chemical element symbols from other similar abbreviations.
    /// <see href="http://aims.fao.org/aos/agrontology#isSymbolFor"></see></summary>
    let isSymbolFor =
        Namespaced_IRI.parse _namespace_name "isSymbolFor" |> NamespacedName

    /// <summary>
    /// X &lt;has symptom&gt; Y. A disease or disorder X presents disease characteristic Y in an organism. E.g. "malnutrition" &lt;has symptom&gt; "thinness", "septicaemia" &lt;has symptom&gt; "septic shock".
    /// <see href="http://aims.fao.org/aos/agrontology#hasSymptom"></see></summary>
    let hasSymptom = Namespaced_IRI.parse _namespace_name "hasSymptom" |> NamespacedName
    /// <summary>
    /// Y &lt;indicates&gt; X. A disease or disorder characteristic Y in an organism indicates disease X. E.g. "septic shock" &lt;indicates&gt; "septicaemia". Use only for diseases. However, "acidity" &lt;is measured by&gt; "pH".
    /// <see href="http://aims.fao.org/aos/agrontology#indicates"></see></summary>
    let indicates = Namespaced_IRI.parse _namespace_name "indicates" |> NamespacedName

    /// <summary>
    /// X &lt;has taxonomic rank&gt; Y. Describes taxonomic rank Y of organism X. “Spodoptera frugiperda” &lt;has taxonomic rank&gt; “species (taxa)”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasTaxonomicRank"></see></summary>
    let hasTaxonomicRank =
        Namespaced_IRI.parse _namespace_name "hasTaxonomicRank" |> NamespacedName

    /// <summary>
    ///  Y &lt;is taxonomic rank of&gt; X. Describes taxonomic rank Y of organism X. E.g. “species (taxa)” &lt;is taxonomic rank of&gt; “Spodoptera frugiperda”.
    /// <see href="http://aims.fao.org/aos/agrontology#isTaxonomicRankOf"></see></summary>
    let isTaxonomicRankOf =
        Namespaced_IRI.parse _namespace_name "isTaxonomicRankOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasTermType"></see>
    /// </summary>
    let hasTermType =
        Namespaced_IRI.parse _namespace_name "hasTermType" |> NamespacedName

    /// <summary>
    /// From CWR ontology.
    /// <see href="http://aims.fao.org/aos/agrontology#hasTheme"></see></summary>
    let hasTheme = Namespaced_IRI.parse _namespace_name "hasTheme" |> NamespacedName
    /// <summary>
    /// From CWR ontology.
    /// <see href="http://aims.fao.org/aos/agrontology#isThemeOf"></see></summary>
    let isThemeOf = Namespaced_IRI.parse _namespace_name "isThemeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasTradeName"></see>
    /// </summary>
    let hasTradeName =
        Namespaced_IRI.parse _namespace_name "hasTradeName" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isTradeNameOf"></see>
    /// </summary>
    let isTradeNameOf =
        Namespaced_IRI.parse _namespace_name "isTradeNameOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasTransliteration"></see>
    /// </summary>
    let hasTransliteration =
        Namespaced_IRI.parse _namespace_name "hasTransliteration" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isTransliterationOf"></see>
    /// </summary>
    let isTransliterationOf =
        Namespaced_IRI.parse _namespace_name "isTransliterationOf" |> NamespacedName

    /// <summary>
    /// X &lt;has type&gt; Y. Concept X has types Y. &lt;type of&gt; is broader and quite similar to &lt;skos:broader&gt;, but  it is not exclusive.  E.g. “horse gaits” &lt;has type&gt; “gallop”, but also elephants and camels can gallop.
    /// <see href="http://aims.fao.org/aos/agrontology#hasType"></see></summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName
    /// <summary>
    /// Y &lt;type of&gt; X. Concept Y is a type of X.  &lt;type of&gt; is broader and quite similar to &lt;skos:broader&gt;, but  it is not exclusive.  E.g. “gallop” &lt;type of&gt; “horse gaits”, but also elephants and camels can gallop.
    /// <see href="http://aims.fao.org/aos/agrontology#typeOf"></see></summary>
    let typeOf = Namespaced_IRI.parse _namespace_name "typeOf" |> NamespacedName
    /// <summary>
    /// Simmetric relationship indicating that two concepts are variety each other.
    /// <see href="http://aims.fao.org/aos/agrontology#hasVariety"></see></summary>
    let hasVariety = Namespaced_IRI.parse _namespace_name "hasVariety" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasWeed"></see>
    /// </summary>
    let hasWeed = Namespaced_IRI.parse _namespace_name "hasWeed" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isWeedOf"></see>
    /// </summary>
    let isWeedOf = Namespaced_IRI.parse _namespace_name "isWeedOf" |> NamespacedName

    /// <summary>
    /// X &lt;includesSubprocess&gt; Y. Process X naturally or conventionally realized at the minimum through process Y. Equivalent to &lt;stageOf&gt;. E.g. "milk production" &lt;includesSubprocess&gt; "pasteurization";
    /// <see href="http://aims.fao.org/aos/agrontology#includesSubprocess"></see></summary>
    let includesSubprocess =
        Namespaced_IRI.parse _namespace_name "includesSubprocess" |> NamespacedName

    /// <summary>
    /// Y &lt;isSubprocessOf&gt; X. Y is one of one or more processes naturally or conventionally associated with the realization of process X. E.g. "pasteurization" &lt;isSubprocessOf&gt; "milk production";
    /// <see href="http://aims.fao.org/aos/agrontology#isSubprocessOf"></see></summary>
    let isSubprocessOf =
        Namespaced_IRI.parse _namespace_name "isSubprocessOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#influences"></see>
    /// </summary>
    let influences = Namespaced_IRI.parse _namespace_name "influences" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isInfluencedBy"></see>
    /// </summary>
    let isInfluencedBy =
        Namespaced_IRI.parse _namespace_name "isInfluencedBy" |> NamespacedName

    /// <summary>
    /// X &lt;is derived from&gt; Y. A substance or product X obtained exclusively from source Y without any additional substance or product. E.g. “almond oil” &lt;is derived from&gt; “almonds”, “orange juice” &lt;is derived from&gt; “sweet oranges”. Use to relate an organism with a derived product: “mutton” &lt;is derived from&gt; “sheep”.
    /// <see href="http://aims.fao.org/aos/agrontology#isDerivedFrom"></see></summary>
    let isDerivedFrom =
        Namespaced_IRI.parse _namespace_name "isDerivedFrom" |> NamespacedName

    /// <summary>
    /// Y &lt;is source of&gt; X. E.g. “almonds" &lt;is source of&gt; “almond oil”, “sweet oranges”&lt;is source of&gt; “orange juice". Use to relate an organism with a derived product: “sheep” &lt;is source of&gt; “mutton”.  (But “honey” &lt;is produced by&gt; “honey bees”, “silage effluents” &lt;product of&gt; “silage”.)
    /// <see href="http://aims.fao.org/aos/agrontology#isSourceOf"></see></summary>
    let isSourceOf = Namespaced_IRI.parse _namespace_name "isSourceOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isInputFor"></see>
    /// </summary>
    let isInputFor = Namespaced_IRI.parse _namespace_name "isInputFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isOutputFrom"></see>
    /// </summary>
    let isOutputFrom =
        Namespaced_IRI.parse _namespace_name "isOutputFrom" |> NamespacedName

    /// <summary>
    ///  X &lt;is made from&gt; Y.  Product X is mainly made from substance or a product Y. E.g. "sheep cheese" &lt;is made from&gt; "ewe milk", "concrete" &lt;is made from&gt; "cement", "bacon" &lt;is made from&gt; "pork". Stronger processing element than &lt;is source of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#isMadeFrom"></see></summary>
    let isMadeFrom = Namespaced_IRI.parse _namespace_name "isMadeFrom" |> NamespacedName

    /// <summary>
    /// Y &lt;is used to make&gt; X. A substance or a product Y is used to make product X. E.g. "ewe milk" &lt;is used to make&gt; "sheep cheese", "cement" &lt;is used to make&gt; "concrete", "pork" &lt;is used to make&gt; "bacon". Stronger processing element than &lt;is source of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#isUsedToMake"></see></summary>
    let isUsedToMake =
        Namespaced_IRI.parse _namespace_name "isUsedToMake" |> NamespacedName

    /// <summary>
    /// X &lt;isMeansFor&gt; Y. An object or process X mainly used to perform a process Y. See also &lt;usedAs&gt;. E.g. "curry paste grinding" &lt;performedWithInstrument&gt; "curry paste grinding machine"; "weapon" &lt;instrumentFor&gt; "killing"; "fishing pole" &lt;instrumentFor&gt; "fishing"; "alcohol" &lt;instrumentFor&gt; "cleaning"; Ploughs &lt;isMeansFor&gt; Ploughing ;but NOT "knives" &lt;instrumentFor&gt; "felling" (because knives are not primarily used for cutting down trees);
    /// <see href="http://aims.fao.org/aos/agrontology#isMeansFor"></see></summary>
    let isMeansFor = Namespaced_IRI.parse _namespace_name "isMeansFor" |> NamespacedName

    /// <summary>
    /// Y &lt;isPerformedByMeansOf&gt; X. An object or process X mainly used to perform a process Y. See also &lt;usedAs&gt;. E.g. "curry paste grinding" &lt;isPerformedByMeansOf&gt; "curry paste grinding machine"; "weapon" &lt;meansFor&gt; "killing"; "fishing pole" &lt;meansFor&gt; "fishing"; "alcohol" &lt;meansFor&gt; "cleaning"; but NOT "knives" &lt;meansFor&gt; "felling" (because knives are not primarily used for cutting down trees);
    /// <see href="http://aims.fao.org/aos/agrontology#isPerformedByMeansOf"></see></summary>
    let isPerformedByMeansOf =
        Namespaced_IRI.parse _namespace_name "isPerformedByMeansOf" |> NamespacedName

    /// <summary>
    /// X &lt;is measured by&gt; Y. A quantitative property of X is measured by Y. For example: “temperature” &lt;is measured by&gt; “thermometers”, “social change” &lt;is measured by&gt; “social indicators".
    /// <see href="http://aims.fao.org/aos/agrontology#isMeasuredBy"></see></summary>
    let isMeasuredBy =
        Namespaced_IRI.parse _namespace_name "isMeasuredBy" |> NamespacedName

    /// <summary>
    /// Y &lt;measures&gt; X. Y is used to measure a quantitative property of X. For example: “thermometers” &lt;measures&gt; “temperature”, “social indicators” &lt;measures&gt; ”social change”.
    /// <see href="http://aims.fao.org/aos/agrontology#measures"></see></summary>
    let measures = Namespaced_IRI.parse _namespace_name "measures" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPartOfSubvocabulary"></see>
    /// </summary>
    let isPartOfSubvocabulary =
        Namespaced_IRI.parse _namespace_name "isPartOfSubvocabulary" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPerformedBy"></see>
    /// </summary>
    let isPerformedBy =
        Namespaced_IRI.parse _namespace_name "isPerformedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#performs"></see>
    /// </summary>
    let performs = Namespaced_IRI.parse _namespace_name "performs" |> NamespacedName

    /// <summary>
    /// X &lt;is prevented by&gt; Y. X can be reduced, interrupted or prevented by Y. E.g. "disease transmission" &lt;is prevented by&gt; "hand hygiene", "occupational hazards" &lt;is prevented by&gt; "safety at work".
    /// <see href="http://aims.fao.org/aos/agrontology#isPreventedBy"></see></summary>
    let isPreventedBy =
        Namespaced_IRI.parse _namespace_name "isPreventedBy" |> NamespacedName

    /// <summary>
    /// Y &lt;prevents&gt; X. Y is an element which prevents, interrupts or reduces harm or damage X. E.g. “hand hygiene” &lt;prevents&gt; “disease transmission”, “safety at work”&lt;prevents&gt; “occupational hazards”.
    /// <see href="http://aims.fao.org/aos/agrontology#prevents"></see></summary>
    let prevents = Namespaced_IRI.parse _namespace_name "prevents" |> NamespacedName

    /// <summary>
    /// Y &lt;is process for&gt; X. One or more actions, activities, methods Y that produce a change or development for X. E.g. ”sterilization” &lt;is process for&gt; “sterile insect release”, “alcoholic fermentation” &lt;is process for&gt; “winemaking”.
    /// <see href="http://aims.fao.org/aos/agrontology#isProcessFor"></see></summary>
    let isProcessFor =
        Namespaced_IRI.parse _namespace_name "isProcessFor" |> NamespacedName

    /// <summary>
    /// X &lt;uses process&gt; Y. X uses one or more actions, activities, methods Y as a process. E.g. “winter crops” &lt;uses process&gt; “vernalization”, “canning” &lt;uses process&gt; “sterilizing”.
    /// <see href="http://aims.fao.org/aos/agrontology#usesProcess"></see></summary>
    let usesProcess =
        Namespaced_IRI.parse _namespace_name "usesProcess" |> NamespacedName

    /// <summary>
    /// X &lt;is produced by&gt; Y. Restrict use to natural processes (such as fruits growing on plants, eggs, milk) - but also chemical processes. E.g. “honey” &lt;is produced by&gt; “honey bees”, “potatoes” &lt;is produced by&gt; “Solanum tuberosum". However, “cheese” &lt;product of&gt; “cheese-making”.
    /// <see href="http://aims.fao.org/aos/agrontology#isProducedBy"></see></summary>
    let isProducedBy =
        Namespaced_IRI.parse _namespace_name "isProducedBy" |> NamespacedName

    /// <summary>
    /// Y &lt;produces&gt; X. E.g. “honey bees” &lt;produces&gt;“honey”,  “Solanum tuberosum” &lt;produces&gt; "potatoes". However, “cheese-making” &lt;has product&gt;”cheese”.
    /// <see href="http://aims.fao.org/aos/agrontology#produces"></see></summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName

    /// <summary>
    /// Y &lt;is spatially included in&gt; X. Spatial region Y is an inalienable spatial part of spatial region X. E.g. "African inland waters" &lt;is spatially included in&gt; "Africa", "Peru" &lt;is spatially included in&gt; "Andean region".
    /// <see href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedIn"></see></summary>
    let isSpatiallyIncludedIn =
        Namespaced_IRI.parse _namespace_name "isSpatiallyIncludedIn" |> NamespacedName

    /// <summary>
    /// Super-property for spatial relationships
    /// <see href="http://aims.fao.org/aos/agrontology#spatialRelationship"></see></summary>
    let spatialRelationship =
        Namespaced_IRI.parse _namespace_name "spatialRelationship" |> NamespacedName

    /// <summary>
    /// X &lt;spatially includes&gt; Y. Region X spatially includes as inalienable part the spatial region Y. E.g. "Africa" &lt;spatially includes&gt; "African inland waters", "Andean region" &lt;spatially includes&gt; "Peru".
    /// <see href="http://aims.fao.org/aos/agrontology#spatiallyIncludes"></see></summary>
    let spatiallyIncludes =
        Namespaced_IRI.parse _namespace_name "spatiallyIncludes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInCity"></see>
    /// </summary>
    let isSpatiallyIncludedInCity =
        Namespaced_IRI.parse _namespace_name "isSpatiallyIncludedInCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInState"></see>
    /// </summary>
    let isSpatiallyIncludedInState =
        Namespaced_IRI.parse _namespace_name "isSpatiallyIncludedInState" |> NamespacedName

    /// <summary>
    /// X &lt;is studied by&gt; Y. Concept X is studied by field, science or group Y. E.g. “palaeontology”&lt;is studied by&gt; "palaeontologists”, “working conditions” &lt;is studied by&gt; “ergonomics”.
    /// <see href="http://aims.fao.org/aos/agrontology#isStudiedBy"></see></summary>
    let isStudiedBy =
        Namespaced_IRI.parse _namespace_name "isStudiedBy" |> NamespacedName

    /// <summary>
    /// Y &lt;study&gt; X. Field, science or group Y studies concept X. E.g. “sedimentology” &lt;study&gt; “sediment”,
    /// “wood anatomy” &lt;study&gt; “heartwood”.
    /// <see href="http://aims.fao.org/aos/agrontology#study"></see></summary>
    let study = Namespaced_IRI.parse _namespace_name "study" |> NamespacedName
    /// <summary>
    /// Y &lt;is use of&gt; X.  For example, "sweeteners" &lt;is use of&gt; '"sorbitol",  "fuels" &lt;is use of&gt; "ethanol".
    /// <see href="http://aims.fao.org/aos/agrontology#isUseOf"></see></summary>
    let isUseOf = Namespaced_IRI.parse _namespace_name "isUseOf" |> NamespacedName
    /// <summary>
    /// X &lt;is used as&gt; Y. E.g. "sorbitol" &lt;is used as&gt; "sweetener"; "ethanol" &lt;is used as&gt; "fuel".
    /// <see href="http://aims.fao.org/aos/agrontology#isUsedAs"></see></summary>
    let isUsedAs = Namespaced_IRI.parse _namespace_name "isUsedAs" |> NamespacedName
    /// <summary>
    /// X &lt;is used in&gt; Y. X is habitually used in Y, it is normal to use X in the practice of Y. E.g. “casings” &lt;is used in&gt; “sausages”, “trains” &lt;is used in&gt; “rail transport”.
    /// <see href="http://aims.fao.org/aos/agrontology#isUsedIn"></see></summary>
    let isUsedIn = Namespaced_IRI.parse _namespace_name "isUsedIn" |> NamespacedName
    /// <summary>
    /// Y &lt;make use of&gt; X. Activity Y makes use of process or input X. E.g. “navigation” &lt;make use of&gt; ”navigational aids”, “precision agriculture” &lt;make use of&gt; ”geographical information systems”, “rail transport” &lt;make use of&gt; “trains”.
    /// <see href="http://aims.fao.org/aos/agrontology#makeUseOf"></see></summary>
    let makeUseOf = Namespaced_IRI.parse _namespace_name "makeUseOf" |> NamespacedName
    /// <summary>
    /// UN M49 or the Standard Country or Area Codes for Statistical Use (Series M, No. 49) is a standard for area codes used by the United Nations for statistical purposes, developed and maintained by the United Nations Statistics Division.
    /// <see href="http://aims.fao.org/aos/agrontology#m49Code"></see></summary>
    let m49Code = Namespaced_IRI.parse _namespace_name "m49Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#spellingVariant"></see>
    /// </summary>
    let spellingVariant =
        Namespaced_IRI.parse _namespace_name "spellingVariant" |> NamespacedName

    /// <summary>
    /// X &lt;surrounded by&gt; Y. The object X is physically surrounded by object Y. E.g. “pupae” &lt;surrounded by&gt; “cocoons“, "endosperm” &lt;surrounded by&gt; “aleurone cells". Use only for the terms that are physically immediately adjacent to each other. For geography use &lt;is spatially included in&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#surroundedBy"></see></summary>
    let surroundedBy =
        Namespaced_IRI.parse _namespace_name "surroundedBy" |> NamespacedName

    /// <summary>
    /// Y &lt;surrounds&gt; X. The object Y is physically surrounding object X. E.g. “cocoons” &lt;surrounds&gt; “pupae“, "aleurone cells” &lt;surrounds&gt; “endosperm". Use only for the terms that are physically immediately adjacent to each other. For geography use &lt;spatially Includes&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#surrounds"></see></summary>
    let surrounds = Namespaced_IRI.parse _namespace_name "surrounds" |> NamespacedName
    /// <summary>
    /// A concept that make use of a specific value.
    /// <see href="http://aims.fao.org/aos/agrontology#usingValue"></see></summary>
    let usingValue = Namespaced_IRI.parse _namespace_name "usingValue" |> NamespacedName

    /// <summary>
    /// A measure or other value used in a specific activity or methods or for any purpose.
    /// <see href="http://aims.fao.org/aos/agrontology#valueUsedIn"></see></summary>
    let valueUsedIn =
        Namespaced_IRI.parse _namespace_name "valueUsedIn" |> NamespacedName
