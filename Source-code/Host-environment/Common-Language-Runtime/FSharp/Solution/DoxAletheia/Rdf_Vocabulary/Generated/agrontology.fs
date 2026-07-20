namespace http.aims.fao.org.aos.agrontology.hash

open DoxAletheia

module agrontology =
    let _namespace_name = "http://aims.fao.org/aos/agrontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#RangeOfHasTermType"></see>
    /// </summary>
    let RangeOfHasTermType = _prefix "RangeOfHasTermType"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#RangeOfIsPartOfSubvocabulary"></see>
    /// </summary>
    let RangeOfIsPartOfSubvocabulary = _prefix "RangeOfIsPartOfSubvocabulary"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#actsUpon"></see>
    /// </summary>
    let actsUpon = _prefix "actsUpon"
    /// <summary>
    /// Super-property for causative relationships
    /// <see href="http://aims.fao.org/aos/agrontology#causativeRelationship"></see></summary>
    let causativeRelationship = _prefix "causativeRelationship"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isActedUponBy"></see>
    /// </summary>
    let isActedUponBy = _prefix "isActedUponBy"
    /// <summary>
    /// X &lt;affects&gt; Y. Action of agent X changes the state or location of Y. E.g. "water depletion" &lt;affects&gt; "groundwater table", "mechanical damage" &lt;affects&gt; “transporting quality”. Do not use for diseases or disorders; for those, use &lt;afflicts/is afflicted by&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#affects"></see></summary>
    let affects = _prefix "affects"
    /// <summary>
    /// Y &lt;is affected by&gt; X. An object Y changes state or location because of an action of an agent X. E.g. "trees" &lt;is affected by&gt; "arboricides", "transporting quality" &lt;is affected by&gt; "mechanical damage". Do not use for diseases or disorders; for those, use &lt;afflicts/is afflicted by&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#isAffectedBy"></see></summary>
    let isAffectedBy = _prefix "isAffectedBy"
    /// <summary>
    /// X &lt;afflicts&gt; Y. The disease or disorder X could have negative effects in Y, such as adversely affect the health of an organism or body part Y. E.g. "scrapie" &lt;afflicts&gt; "sheep", “glossitis” &lt;afflicts&gt; “tongue”.
    /// <see href="http://aims.fao.org/aos/agrontology#afflicts"></see></summary>
    let afflicts = _prefix "afflicts"
    /// <summary>
    /// Y &lt;is afflicted by&gt; X. The health or wellbeing of an organism or body part Y could adversely be affected by the disease X. E.g. "honey bees" &lt;is afflicted by&gt; "varoosis", "tongue" &lt;is afflicted by&gt; "glossitis".
    /// <see href="http://aims.fao.org/aos/agrontology#isAfflictedBy"></see></summary>
    let isAfflictedBy = _prefix "isAfflictedBy"
    /// <summary>
    /// Y &lt;benefitsFrom&gt; X. A result Y  that is advantageous to some beneficiary, produced by the behaviour of an agent X. A consequence Y achieved through a means X. E.g. "biological control" &lt;benefitsFrom&gt; "biological control arthropods"; "plant health" &lt;benefitsFrom&gt; "pest control";
    /// <see href="http://aims.fao.org/aos/agrontology#benefitsFrom"></see></summary>
    let benefitsFrom = _prefix "benefitsFrom"
    /// <summary>
    /// X &lt;isBeneficialFor&gt; Y. Agent X behaves in a way that produces some result Y that is advantageous to some beneficiary. A means X through which a consequence Y can be achieved. E.g. "biological control arthropods" &lt;isBeneficialFor&gt; "biological control"; "pest control" &lt;isBeneficialFor&gt; "plant health";
    /// <see href="http://aims.fao.org/aos/agrontology#isBeneficialFor"></see></summary>
    let isBeneficialFor = _prefix "isBeneficialFor"
    /// <summary>
    /// X &lt;causes&gt; Y. Agent X (animate or inanimate) brings about a result Y. E.g. "prions" &lt;causes&gt; "spongiform encephalopathy", "soil moisture deficit" &lt;causes&gt; "wilting".
    /// <see href="http://aims.fao.org/aos/agrontology#causes"></see></summary>
    let causes = _prefix "causes"
    /// <summary>
    /// Y &lt;is caused by&gt; X. A result Y occurred because of an agent X (animate or inanimate). E.g. "spongiform encephalopathy" &lt;is caused by&gt; “prions”, "soil moisture deficit” &lt;is caused by&gt; "wilting".
    /// <see href="http://aims.fao.org/aos/agrontology#isCausedBy"></see></summary>
    let isCausedBy = _prefix "isCausedBy"
    /// <summary>
    /// Y &lt;compose&gt; X. Y is the material or substance of which X is composed. E.g. “microbial flora” &lt;compose&gt; "soil flora", “volcanic materials” &lt;compose&gt; "tuff".
    /// <see href="http://aims.fao.org/aos/agrontology#compose"></see></summary>
    let compose = _prefix "compose"
    /// <summary>
    ///  Y &lt;is part of&gt; X. X is composed of one or more parts, where Y is one part. E.g. “cortex” &lt;is part of&gt; “stems”, “root nodules” &lt;is part of&gt; “roots". Use this relationship when none of the other lower partitive relations (&lt;is composed of&gt;, &lt;has member&gt;) apply.
    /// <see href="http://aims.fao.org/aos/agrontology#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// X &lt;is composed of&gt; Y. X is composed of material or substance Y . E.g. “soil flora” &lt;is composed of&gt; “microbial flora”, “tuff”&lt;is composed of&gt; “volcanic materials”.
    /// <see href="http://aims.fao.org/aos/agrontology#isComposedOf"></see></summary>
    let isComposedOf = _prefix "isComposedOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#controls"></see>
    /// </summary>
    let controls = _prefix "controls"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isControlledBy"></see>
    /// </summary>
    let isControlledBy = _prefix "isControlledBy"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#developsFrom"></see>
    /// </summary>
    let developsFrom = _prefix "developsFrom"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#temporalRelationship"></see>
    /// </summary>
    let temporalRelationship = _prefix "temporalRelationship"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#developsInto"></see>
    /// </summary>
    let developsInto = _prefix "developsInto"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#follows"></see>
    /// </summary>
    let follows = _prefix "follows"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#precedes"></see>
    /// </summary>
    let precedes = _prefix "precedes"
    /// <summary>
    /// An inclusion that was valid in the past but currently is not valid anymore.
    /// <see href="http://aims.fao.org/aos/agrontology#formerlyIncludedIn"></see></summary>
    let formerlyIncludedIn = _prefix "formerlyIncludedIn"
    /// <summary>
    /// Y &lt;is included in&gt;X. X is an entity that includes the element Y. For example: "dehorning” &lt;included in&gt; ”animal husbandry methods”, “microbiological analysis" &lt;included in&gt; “water analysis”
    /// <see href="http://aims.fao.org/aos/agrontology#isIncludedIn"></see></summary>
    let isIncludedIn = _prefix "isIncludedIn"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#formerlyIncludes"></see>
    /// </summary>
    let formerlyIncludes = _prefix "formerlyIncludes"
    /// <summary>
    /// X &lt;includes&gt; Y. X is an entity that includes the element Y. For example: “animal husbandry methods” &lt;includes&gt; ”dehorning”, “water analysis” &lt;includes&gt; ”microbiological analysis”.
    /// <see href="http://aims.fao.org/aos/agrontology#includes"></see></summary>
    let includes = _prefix "includes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#greaterThan"></see>
    /// </summary>
    let greaterThan = _prefix "greaterThan"
    /// <summary>
    /// Super-property for quantitative relationships. All relationships involving a quantity or a measure.
    /// <see href="http://aims.fao.org/aos/agrontology#quantitativeRelationship"></see></summary>
    let quantitativeRelationship = _prefix "quantitativeRelationship"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#smallerThan"></see>
    /// </summary>
    let smallerThan = _prefix "smallerThan"
    /// <summary>
    /// X &lt;growsIn&gt; Y. A taxon X grows in an environment Y. Use this in a plant and related domain (e.g. fungi). E.g. "jasmine rice" &lt;growsIn&gt; "isarn region"; "rice" &lt;growsIn&gt; "moist soil";
    /// <see href="http://aims.fao.org/aos/agrontology#growsln"></see></summary>
    let growsln = _prefix "growsln"
    /// <summary>
    /// Y &lt;isAGrowthEnvironmentFor&gt; X. An environment Y favorable to a taxon X. This is used as the inverse relationship of &lt;growsIn&gt;. Use this in a plant and related domain (e.g. fungi). E.g. "isarn region" &lt;isAGrowthEnvironmentFor&gt; "jasmine rice"; "moist soil" &lt;isAGrowthEnvironmentFor&gt; "rice";
    /// <see href="http://aims.fao.org/aos/agrontology#isAGrowthEnvironmentFor"></see></summary>
    let isAGrowthEnvironmentFor = _prefix "isAGrowthEnvironmentFor"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasAbbreviation"></see>
    /// </summary>
    let hasAbbreviation = _prefix "hasAbbreviation"
    /// <summary>
    /// X &lt;has synonym&gt; Y. Y &lt;has synonym&gt; X. “Bulgaria”&lt;has synonym&gt;”Republic of Bulgaria”. Used to distinguish an exact and current synonym from obsolete terms which might have been used in the past (for that, use &lt;has old name&gt;). Use only between labels for the same concept in a specific language.
    /// <see href="http://aims.fao.org/aos/agrontology#hasSynonym"></see></summary>
    let hasSynonym = _prefix "hasSynonym"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isAbbreviationOf"></see>
    /// </summary>
    let isAbbreviationOf = _prefix "isAbbreviationOf"
    /// <summary>
    /// X &lt;has acronym&gt; Y. An acronym is an abbreviation formed from the initial letters of other words, often pronounced as a word. E.g. “acquired immunodeficiency syndrome” &lt;has acronym&gt;”AIDS”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasAcronym"></see></summary>
    let hasAcronym = _prefix "hasAcronym"
    /// <summary>
    /// Y &lt;is acronym of&gt; X. An acronym is an abbreviation formed from the initial letters of other words, often pronounced as a word.  “AIDS” &lt;is acronym of&gt;”acquired immunodeficiency syndrome”.
    /// <see href="http://aims.fao.org/aos/agrontology#isAcronymOf"></see></summary>
    let isAcronymOf = _prefix "isAcronymOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasAntonym"></see>
    /// </summary>
    let hasAntonym = _prefix "hasAntonym"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasBiologicalControlAgent"></see>
    /// </summary>
    let hasBiologicalControlAgent = _prefix "hasBiologicalControlAgent"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isBiologicalControlAgentOf"></see>
    /// </summary>
    let isBiologicalControlAgentOf = _prefix "isBiologicalControlAgentOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasBreedingMethod"></see>
    /// </summary>
    let hasBreedingMethod = _prefix "hasBreedingMethod"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isBreedingMethodOf"></see>
    /// </summary>
    let isBreedingMethodOf = _prefix "isBreedingMethodOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasBroaderSynonym"></see>
    /// </summary>
    let hasBroaderSynonym = _prefix "hasBroaderSynonym"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasNarrowerSynonym"></see>
    /// </summary>
    let hasNarrowerSynonym = _prefix "hasNarrowerSynonym"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasChemicalFormula"></see>
    /// </summary>
    let hasChemicalFormula = _prefix "hasChemicalFormula"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isChemicalFormulaOf"></see>
    /// </summary>
    let isChemicalFormulaOf = _prefix "isChemicalFormulaOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeAsc"></see>
    /// </summary>
    let hasCodeAsc = _prefix "hasCodeAsc"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeAsfa"></see>
    /// </summary>
    let hasCodeAsfa = _prefix "hasCodeAsfa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeFaoPa"></see>
    /// </summary>
    let hasCodeFaoPa = _prefix "hasCodeFaoPa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeFaoterm"></see>
    /// </summary>
    let hasCodeFaoterm = _prefix "hasCodeFaoterm"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeFishery3Alpha"></see>
    /// </summary>
    let hasCodeFishery3Alpha = _prefix "hasCodeFishery3Alpha"
    /// <summary>
    /// The International Standard for country codes and codes for their subdivisions. Alpha-3 code – a three-letter code that represents a country name, which is usually more closely related to the country name
    /// <see href="http://aims.fao.org/aos/agrontology#hasCodeISO3Country"></see></summary>
    let hasCodeISO3Country = _prefix "hasCodeISO3Country"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCodeTaxonomic"></see>
    /// </summary>
    let hasCodeTaxonomic = _prefix "hasCodeTaxonomic"
    /// <summary>
    /// Y &lt;has common name concept&gt; X. Y is a scientifically defined concept for an organism or a group of organisms with scientific name as labels, having a specific taxonomic rank. "Apis mellifera” &lt;has common name concept&gt; “honey bees”. Use at concept level when common name and scientific name are separate concepts. For label-to-label relationship for use within a concept, use &lt;has scientific name / scientific name of&gt;.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasCommonNameConcept"></see></summary>
    let hasCommonNameConcept = _prefix "hasCommonNameConcept"
    /// <summary>
    /// Super-property for taxonomic relationships.
    /// <see href="http://aims.fao.org/aos/agrontology#taxonomicRelationship"></see></summary>
    let taxonomicRelationship = _prefix "taxonomicRelationship"
    /// <summary>
    /// X &lt;has taxonomic concept&gt; Y.  X is a common name concept for an organism or organism group. Y is the scientifically defined concept name for the same organism or a group of organisms, having a specific taxonomic rank. E.g. “honey bees” &lt;has taxonomic concept&gt; ”Apis mellifera”. Use at concept level when common name and scientific name are separate concepts. For label-to-label relationship for use within a concept, use &lt;has scientific name / scientific name of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#hasTaxonomicConcept"></see></summary>
    let hasTaxonomicConcept = _prefix "hasTaxonomicConcept"
    /// <summary>
    /// Y &lt;has component&gt; X. An object X that is a part of a whole Y and also has an existence independently from Y. E.g. "trees" &lt;has component&gt; "leaves",  "vehicle systems" &lt;has component&gt; "engines".
    /// <see href="http://aims.fao.org/aos/agrontology#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// X &lt;has part&gt; Y. A composite entity X that can be identified as being composed of one or more parts, between which Y. E.g. “stems” &lt;has part&gt; “cortex”, “roots” &lt;has part&gt;“root nodules”. Use this relationship when none of the other lower partitive relations (&lt;has component&gt;, &lt;is composed of&gt;, &lt;member&gt;) apply.
    /// <see href="http://aims.fao.org/aos/agrontology#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///  X &lt;is component of&gt; Y. An object X that is a part of a whole Y, also has an existence independently from Y. E.g. "leaves" &lt;is component of&gt; "trees", "engines" &lt;is component of&gt; "vehicle systems".
    /// <see href="http://aims.fao.org/aos/agrontology#isComponentOf"></see></summary>
    let isComponentOf = _prefix "isComponentOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasComposition"></see>
    /// </summary>
    let hasComposition = _prefix "hasComposition"
    /// <summary>
    /// Super-property for partitive relationships
    /// <see href="http://aims.fao.org/aos/agrontology#partitiveRelationship"></see></summary>
    let partitiveRelationship = _prefix "partitiveRelationship"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isCompositionOf"></see>
    /// </summary>
    let isCompositionOf = _prefix "isCompositionOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasControlMethod"></see>
    /// </summary>
    let hasControlMethod = _prefix "hasControlMethod"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isControlMethodOf"></see>
    /// </summary>
    let isControlMethodOf = _prefix "isControlMethodOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCropingSystem"></see>
    /// </summary>
    let hasCropingSystem = _prefix "hasCropingSystem"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isCropingSystemOf"></see>
    /// </summary>
    let isCropingSystemOf = _prefix "isCropingSystemOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasCultivationProcess"></see>
    /// </summary>
    let hasCultivationProcess = _prefix "hasCultivationProcess"
    /// <summary>
    /// Super-property for process relationships
    /// <see href="http://aims.fao.org/aos/agrontology#processRelationship"></see></summary>
    let processRelationship = _prefix "processRelationship"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isCultivationProcessOf"></see>
    /// </summary>
    let isCultivationProcessOf = _prefix "isCultivationProcessOf"
    /// <summary>
    /// X &lt;has disease&gt; Y. Organism X can have disease Y. E.g. “Sorghum” &lt;has disease&gt; “loose smut of sorghum”. Organism to disease relationship.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasDisease"></see></summary>
    let hasDisease = _prefix "hasDisease"
    /// <summary>
    /// Y &lt;is disease for&gt; X. Disease Y is disease of organism X. E.g. “loose smut of sorghum”&lt;is disease for&gt; “Sorghum". Disease to organism relationship.
    /// <see href="http://aims.fao.org/aos/agrontology#isDiseaseFor"></see></summary>
    let isDiseaseFor = _prefix "isDiseaseFor"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasDisorder"></see>
    /// </summary>
    let hasDisorder = _prefix "hasDisorder"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isDisorderOf"></see>
    /// </summary>
    let isDisorderOf = _prefix "isDisorderOf"
    /// <summary>
    /// X &lt;has goal or process&gt; Y. X has intended goal or  process Y. E.g. “veterinary services” &lt;has goal or process&gt; “animal health”, “coppicing” &lt;has goal or process&gt; “natural regeneration”.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasGoalOrProcess"></see></summary>
    let hasGoalOrProcess = _prefix "hasGoalOrProcess"
    /// <summary>
    /// Y &lt;is achieved by means of&gt; X. Y is an objective or process used by X, without Y necessarily being part of X. E.g. “mating disruption” &lt;is achieved by means of&gt; “pheromone analogues”, “decision making” &lt;is achieved by means of&gt; “decision support systems”.
    /// <see href="http://aims.fao.org/aos/agrontology#isAchievedByMeansOf"></see></summary>
    let isAchievedByMeansOf = _prefix "isAchievedByMeansOf"
    /// <summary>
    /// X &lt;has vector or host&gt; Y.  X has organism host or vector  Y.  E.g. “Plasmodium” &lt;has host&gt; ”Anopheles”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasHost"></see></summary>
    let hasHost = _prefix "hasHost"
    /// <summary>
    /// Y &lt;Is vector or host for&gt; X. Organism Y is host or vector for X.  E.g. “Anopheles” &lt;is vector or host for&gt; ”Plasmodium”.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#isHostFor"></see></summary>
    let isHostFor = _prefix "isHostFor"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasInfectionPart"></see>
    /// </summary>
    let hasInfectionPart = _prefix "hasInfectionPart"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isInfectedPartOf"></see>
    /// </summary>
    let isInfectedPartOf = _prefix "isInfectedPartOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasLocalName"></see>
    /// </summary>
    let hasLocalName = _prefix "hasLocalName"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isLocalNameOf"></see>
    /// </summary>
    let isLocalNameOf = _prefix "isLocalNameOf"
    /// <summary>
    /// Y &lt;has member&gt; X. A social or political group Y consists of one or more subsidiary social or political units (group or individual) X. E.g. "Francophone Africa" &lt;has member&gt; "Benin", "bee colonies" &lt;has member&gt; "worker bees". Limit use to geographical or socio-political units. Do not use for grouping organisms by use, climate, or taxonomic rank. Use &lt;includes&gt; / &lt;included in&gt; if describing spatial or temporal relation, if more loose than &lt;has part/is part of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// X &lt;is member of&gt; Y. A social or political unit (group or individual) X belongs to a social or political group Y. E.g. "Benin" &lt;is member of&gt; "Francophone Africa", "worker bees" &lt;is member of&gt; "bee colonies". Limit use to geographical or socio-political units, do not use for grouping organisms (e.g. by use, climate, or taxonomic rank). Use &lt;includes/included in&gt; if describing spatial or temporal relation, but more loose than &lt;is part of.&gt;
    /// <see href="http://aims.fao.org/aos/agrontology#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasNaturalEnemy"></see>
    /// </summary>
    let hasNaturalEnemy = _prefix "hasNaturalEnemy"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isNaturalEnemyOf"></see>
    /// </summary>
    let isNaturalEnemyOf = _prefix "isNaturalEnemyOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasNearSynonym"></see>
    /// </summary>
    let hasNearSynonym = _prefix "hasNearSynonym"
    /// <summary>
    /// X &lt;has object of activity&gt; Y. Activity X focuses on Y. E.g. “shearing” &lt;has object of activity&gt; “wool”, “ratification” &lt;has object of activity&gt; “treaties”.
    ///
    /// <see href="http://aims.fao.org/aos/agrontology#hasObjectOfActivity"></see></summary>
    let hasObjectOfActivity = _prefix "hasObjectOfActivity"
    /// <summary>
    /// Y &lt;is object of activity&gt; X. Y is the focus of activity X.  E.g. “wool” &lt;is object of activity&gt; "shearing”, “treaties" &lt;is object of activity&gt; “ratification”.
    /// <see href="http://aims.fao.org/aos/agrontology#isObjectOfActivity"></see></summary>
    let isObjectOfActivity = _prefix "isObjectOfActivity"
    /// <summary>
    /// X &lt;has old name&gt; Y. Use for obsolete labels, such as old names of countries. E.g. “Bulgaria”&lt;has old name&gt;”People’s Republic of Bulgaria”. Use only between labels for the same concept in a specific language.
    /// <see href="http://aims.fao.org/aos/agrontology#hasOldName"></see></summary>
    let hasOldName = _prefix "hasOldName"
    /// <summary>
    /// Y &lt;is old name of&gt; X. Use for obsolete labels , like old names of countries. E.g. “People’s Republic of Bulgaria” &lt;is old name of&gt; ”Bulgaria”. Use only for labels for the same concept in a specific language.
    /// <see href="http://aims.fao.org/aos/agrontology#isOldNameOf"></see></summary>
    let isOldNameOf = _prefix "isOldNameOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasParent"></see>
    /// </summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isParentOf"></see>
    /// </summary>
    let isParentOf = _prefix "isParentOf"
    /// <summary>
    /// X &lt;has pathogen&gt; Y. Organism X has pathogen Y. Pathogens are pathogenic microorganism such as viruses, bacteria and fungi. E.g. "Olea europaea" &lt;has pathogen&gt; "Xylella fastidiosa".
    /// <see href="http://aims.fao.org/aos/agrontology#hasPathogen"></see></summary>
    let hasPathogen = _prefix "hasPathogen"
    /// <summary>
    /// Y &lt;is pathogen of&gt; X . Y is pathogen of organism X. E.g. "Xylella fastidiosa" &lt;is pathogen of&gt; "Olea europaea".
    /// <see href="http://aims.fao.org/aos/agrontology#isPathogenOf"></see></summary>
    let isPathogenOf = _prefix "isPathogenOf"
    /// <summary>
    /// Y &lt;has pest&gt; X. An organism Y in which the pest X causes harm. Pests are insects, nematodes and rodents that cause damage. E.g. "Apis mellifera" &lt;has pest&gt; "Varroa destructor", "Olea europaea" &lt;has pest&gt; "Bactrocera oleae".
    /// <see href="http://aims.fao.org/aos/agrontology#hasPest"></see></summary>
    let hasPest = _prefix "hasPest"
    /// <summary>
    /// X &lt;pest of&gt; Y. Pest X causes harm to organism Y. E.g. "Varroa destructor" &lt;pest of&gt; "Apis mellifera".
    /// <see href="http://aims.fao.org/aos/agrontology#pestOf"></see></summary>
    let pestOf = _prefix "pestOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPhysiologicalFunction"></see>
    /// </summary>
    let hasPhysiologicalFunction = _prefix "hasPhysiologicalFunction"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPhysiologicalFunctionOf"></see>
    /// </summary>
    let isPhysiologicalFunctionOf = _prefix "isPhysiologicalFunctionOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPlural"></see>
    /// </summary>
    let hasPlural = _prefix "hasPlural"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPostProductionPractice"></see>
    /// </summary>
    let hasPostProductionPractice = _prefix "hasPostProductionPractice"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPractice"></see>
    /// </summary>
    let hasPractice = _prefix "hasPractice"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPostProductionPracticeFor"></see>
    /// </summary>
    let isPostProductionPracticeFor = _prefix "isPostProductionPracticeFor"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPracticeFor"></see>
    /// </summary>
    let isPracticeFor = _prefix "isPracticeFor"
    /// <summary>
    /// X &lt;has product&gt; Y. X is the source of product Y, with a processing element. E.g. “logging”&lt;has product&gt; “logging wastes”, “Spain” &lt;has product&gt; “sherry”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasProduct"></see></summary>
    let hasProduct = _prefix "hasProduct"
    /// <summary>
    /// Y &lt;product of&gt; X, with a processing element. Y is produced or manufactured as a result or consequence of X. E.g. “logging wastes” &lt;product of&gt; “logging”, “sherry” &lt;product of&gt; “Spain”. However, “honey” &lt;is produced by&gt; “honey bees”.
    /// <see href="http://aims.fao.org/aos/agrontology#productOf"></see></summary>
    let productOf = _prefix "productOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPropagationMaterial"></see>
    /// </summary>
    let hasPropagationMaterial = _prefix "hasPropagationMaterial"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPropagationMaterialOf"></see>
    /// </summary>
    let isPropagationMaterialOf = _prefix "isPropagationMaterialOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasPropagationProcess"></see>
    /// </summary>
    let hasPropagationProcess = _prefix "hasPropagationProcess"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPropagationProcessOf"></see>
    /// </summary>
    let isPropagationProcessOf = _prefix "isPropagationProcessOf"
    /// <summary>
    /// X &lt;has property&gt; Y. A property might be a quality or trait. E.g. “seed” &lt;has property&gt; “seed size", “medicinal plants” &lt;has property&gt; “medicinal properties”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// Y &lt;is property of&gt; X. A property might be a quality or trait. E.g. “seed viability” &lt;is property of&gt; “seed”, “medicinal properties” &lt;is property of&gt; “medicinal plants”.
    /// <see href="http://aims.fao.org/aos/agrontology#isPropertyOf"></see></summary>
    let isPropertyOf = _prefix "isPropertyOf"
    /// <summary>
    /// X &lt;has scientific name&gt; Y. E.g. “sea trout” &lt;has scientific name&gt; "Salmo trutta”. Label-to-label relationship for use within a concept. Use when common name and scientific name are not separate concepts, or when a separate relation between scientific and common name is needed for a specific language. When common name and scientific name are separate concepts, use concept-to-concept relation &lt;has taxonomic concept/has common name concept&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#hasScientificName"></see></summary>
    let hasScientificName = _prefix "hasScientificName"
    /// <summary>
    /// Y &lt;scientific name of&gt; X. E.g. “Salmo trutta” &lt;scientific name of&gt; "sea trout”. Label-to-label relationship for use within a concept. Use when common name and scientific name are not separate concepts, or when a separate relation between scientific and common name is needed for a specific language. When common name and scientific name are separate concepts, use concept-to-concept relation &lt;has taxonomic concept/has common name concept&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#scientificNameOf"></see></summary>
    let scientificNameOf = _prefix "scientificNameOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasSingular"></see>
    /// </summary>
    let hasSingular = _prefix "hasSingular"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasSubstitute"></see>
    /// </summary>
    let hasSubstitute = _prefix "hasSubstitute"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isSubstituteFor"></see>
    /// </summary>
    let isSubstituteFor = _prefix "isSubstituteFor"
    /// <summary>
    /// X &lt;has symbol&gt; Y. “iron” has symbol ”Fe (symbol)”. Use for disambiguation of chemical element symbols from other similar abbreviations.
    /// <see href="http://aims.fao.org/aos/agrontology#hasSymbol"></see></summary>
    let hasSymbol = _prefix "hasSymbol"
    /// <summary>
    /// Y &lt;is symbol for&gt; X. ”Fe (symbol)” &lt;is symbol for&gt; “iron”. Use for disambiguation of chemical element symbols from other similar abbreviations.
    /// <see href="http://aims.fao.org/aos/agrontology#isSymbolFor"></see></summary>
    let isSymbolFor = _prefix "isSymbolFor"
    /// <summary>
    /// X &lt;has symptom&gt; Y. A disease or disorder X presents disease characteristic Y in an organism. E.g. "malnutrition" &lt;has symptom&gt; "thinness", "septicaemia" &lt;has symptom&gt; "septic shock".
    /// <see href="http://aims.fao.org/aos/agrontology#hasSymptom"></see></summary>
    let hasSymptom = _prefix "hasSymptom"
    /// <summary>
    /// Y &lt;indicates&gt; X. A disease or disorder characteristic Y in an organism indicates disease X. E.g. "septic shock" &lt;indicates&gt; "septicaemia". Use only for diseases. However, "acidity" &lt;is measured by&gt; "pH".
    /// <see href="http://aims.fao.org/aos/agrontology#indicates"></see></summary>
    let indicates = _prefix "indicates"
    /// <summary>
    /// X &lt;has taxonomic rank&gt; Y. Describes taxonomic rank Y of organism X. “Spodoptera frugiperda” &lt;has taxonomic rank&gt; “species (taxa)”.
    /// <see href="http://aims.fao.org/aos/agrontology#hasTaxonomicRank"></see></summary>
    let hasTaxonomicRank = _prefix "hasTaxonomicRank"
    /// <summary>
    ///  Y &lt;is taxonomic rank of&gt; X. Describes taxonomic rank Y of organism X. E.g. “species (taxa)” &lt;is taxonomic rank of&gt; “Spodoptera frugiperda”.
    /// <see href="http://aims.fao.org/aos/agrontology#isTaxonomicRankOf"></see></summary>
    let isTaxonomicRankOf = _prefix "isTaxonomicRankOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasTermType"></see>
    /// </summary>
    let hasTermType = _prefix "hasTermType"
    /// <summary>
    /// From CWR ontology.
    /// <see href="http://aims.fao.org/aos/agrontology#hasTheme"></see></summary>
    let hasTheme = _prefix "hasTheme"
    /// <summary>
    /// From CWR ontology.
    /// <see href="http://aims.fao.org/aos/agrontology#isThemeOf"></see></summary>
    let isThemeOf = _prefix "isThemeOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasTradeName"></see>
    /// </summary>
    let hasTradeName = _prefix "hasTradeName"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isTradeNameOf"></see>
    /// </summary>
    let isTradeNameOf = _prefix "isTradeNameOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasTransliteration"></see>
    /// </summary>
    let hasTransliteration = _prefix "hasTransliteration"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isTransliterationOf"></see>
    /// </summary>
    let isTransliterationOf = _prefix "isTransliterationOf"
    /// <summary>
    /// X &lt;has type&gt; Y. Concept X has types Y. &lt;type of&gt; is broader and quite similar to &lt;skos:broader&gt;, but  it is not exclusive.  E.g. “horse gaits” &lt;has type&gt; “gallop”, but also elephants and camels can gallop.
    /// <see href="http://aims.fao.org/aos/agrontology#hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    /// Y &lt;type of&gt; X. Concept Y is a type of X.  &lt;type of&gt; is broader and quite similar to &lt;skos:broader&gt;, but  it is not exclusive.  E.g. “gallop” &lt;type of&gt; “horse gaits”, but also elephants and camels can gallop.
    /// <see href="http://aims.fao.org/aos/agrontology#typeOf"></see></summary>
    let typeOf = _prefix "typeOf"
    /// <summary>
    /// Simmetric relationship indicating that two concepts are variety each other.
    /// <see href="http://aims.fao.org/aos/agrontology#hasVariety"></see></summary>
    let hasVariety = _prefix "hasVariety"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#hasWeed"></see>
    /// </summary>
    let hasWeed = _prefix "hasWeed"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isWeedOf"></see>
    /// </summary>
    let isWeedOf = _prefix "isWeedOf"
    /// <summary>
    /// X &lt;includesSubprocess&gt; Y. Process X naturally or conventionally realized at the minimum through process Y. Equivalent to &lt;stageOf&gt;. E.g. "milk production" &lt;includesSubprocess&gt; "pasteurization";
    /// <see href="http://aims.fao.org/aos/agrontology#includesSubprocess"></see></summary>
    let includesSubprocess = _prefix "includesSubprocess"
    /// <summary>
    /// Y &lt;isSubprocessOf&gt; X. Y is one of one or more processes naturally or conventionally associated with the realization of process X. E.g. "pasteurization" &lt;isSubprocessOf&gt; "milk production";
    /// <see href="http://aims.fao.org/aos/agrontology#isSubprocessOf"></see></summary>
    let isSubprocessOf = _prefix "isSubprocessOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#influences"></see>
    /// </summary>
    let influences = _prefix "influences"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isInfluencedBy"></see>
    /// </summary>
    let isInfluencedBy = _prefix "isInfluencedBy"
    /// <summary>
    /// X &lt;is derived from&gt; Y. A substance or product X obtained exclusively from source Y without any additional substance or product. E.g. “almond oil” &lt;is derived from&gt; “almonds”, “orange juice” &lt;is derived from&gt; “sweet oranges”. Use to relate an organism with a derived product: “mutton” &lt;is derived from&gt; “sheep”.
    /// <see href="http://aims.fao.org/aos/agrontology#isDerivedFrom"></see></summary>
    let isDerivedFrom = _prefix "isDerivedFrom"
    /// <summary>
    /// Y &lt;is source of&gt; X. E.g. “almonds" &lt;is source of&gt; “almond oil”, “sweet oranges”&lt;is source of&gt; “orange juice". Use to relate an organism with a derived product: “sheep” &lt;is source of&gt; “mutton”.  (But “honey” &lt;is produced by&gt; “honey bees”, “silage effluents” &lt;product of&gt; “silage”.)
    /// <see href="http://aims.fao.org/aos/agrontology#isSourceOf"></see></summary>
    let isSourceOf = _prefix "isSourceOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isInputFor"></see>
    /// </summary>
    let isInputFor = _prefix "isInputFor"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isOutputFrom"></see>
    /// </summary>
    let isOutputFrom = _prefix "isOutputFrom"
    /// <summary>
    ///  X &lt;is made from&gt; Y.  Product X is mainly made from substance or a product Y. E.g. "sheep cheese" &lt;is made from&gt; "ewe milk", "concrete" &lt;is made from&gt; "cement", "bacon" &lt;is made from&gt; "pork". Stronger processing element than &lt;is source of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#isMadeFrom"></see></summary>
    let isMadeFrom = _prefix "isMadeFrom"
    /// <summary>
    /// Y &lt;is used to make&gt; X. A substance or a product Y is used to make product X. E.g. "ewe milk" &lt;is used to make&gt; "sheep cheese", "cement" &lt;is used to make&gt; "concrete", "pork" &lt;is used to make&gt; "bacon". Stronger processing element than &lt;is source of&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#isUsedToMake"></see></summary>
    let isUsedToMake = _prefix "isUsedToMake"
    /// <summary>
    /// X &lt;isMeansFor&gt; Y. An object or process X mainly used to perform a process Y. See also &lt;usedAs&gt;. E.g. "curry paste grinding" &lt;performedWithInstrument&gt; "curry paste grinding machine"; "weapon" &lt;instrumentFor&gt; "killing"; "fishing pole" &lt;instrumentFor&gt; "fishing"; "alcohol" &lt;instrumentFor&gt; "cleaning"; Ploughs &lt;isMeansFor&gt; Ploughing ;but NOT "knives" &lt;instrumentFor&gt; "felling" (because knives are not primarily used for cutting down trees);
    /// <see href="http://aims.fao.org/aos/agrontology#isMeansFor"></see></summary>
    let isMeansFor = _prefix "isMeansFor"
    /// <summary>
    /// Y &lt;isPerformedByMeansOf&gt; X. An object or process X mainly used to perform a process Y. See also &lt;usedAs&gt;. E.g. "curry paste grinding" &lt;isPerformedByMeansOf&gt; "curry paste grinding machine"; "weapon" &lt;meansFor&gt; "killing"; "fishing pole" &lt;meansFor&gt; "fishing"; "alcohol" &lt;meansFor&gt; "cleaning"; but NOT "knives" &lt;meansFor&gt; "felling" (because knives are not primarily used for cutting down trees);
    /// <see href="http://aims.fao.org/aos/agrontology#isPerformedByMeansOf"></see></summary>
    let isPerformedByMeansOf = _prefix "isPerformedByMeansOf"
    /// <summary>
    /// X &lt;is measured by&gt; Y. A quantitative property of X is measured by Y. For example: “temperature” &lt;is measured by&gt; “thermometers”, “social change” &lt;is measured by&gt; “social indicators".
    /// <see href="http://aims.fao.org/aos/agrontology#isMeasuredBy"></see></summary>
    let isMeasuredBy = _prefix "isMeasuredBy"
    /// <summary>
    /// Y &lt;measures&gt; X. Y is used to measure a quantitative property of X. For example: “thermometers” &lt;measures&gt; “temperature”, “social indicators” &lt;measures&gt; ”social change”.
    /// <see href="http://aims.fao.org/aos/agrontology#measures"></see></summary>
    let measures = _prefix "measures"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPartOfSubvocabulary"></see>
    /// </summary>
    let isPartOfSubvocabulary = _prefix "isPartOfSubvocabulary"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isPerformedBy"></see>
    /// </summary>
    let isPerformedBy = _prefix "isPerformedBy"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#performs"></see>
    /// </summary>
    let performs = _prefix "performs"
    /// <summary>
    /// X &lt;is prevented by&gt; Y. X can be reduced, interrupted or prevented by Y. E.g. "disease transmission" &lt;is prevented by&gt; "hand hygiene", "occupational hazards" &lt;is prevented by&gt; "safety at work".
    /// <see href="http://aims.fao.org/aos/agrontology#isPreventedBy"></see></summary>
    let isPreventedBy = _prefix "isPreventedBy"
    /// <summary>
    /// Y &lt;prevents&gt; X. Y is an element which prevents, interrupts or reduces harm or damage X. E.g. “hand hygiene” &lt;prevents&gt; “disease transmission”, “safety at work”&lt;prevents&gt; “occupational hazards”.
    /// <see href="http://aims.fao.org/aos/agrontology#prevents"></see></summary>
    let prevents = _prefix "prevents"
    /// <summary>
    /// Y &lt;is process for&gt; X. One or more actions, activities, methods Y that produce a change or development for X. E.g. ”sterilization” &lt;is process for&gt; “sterile insect release”, “alcoholic fermentation” &lt;is process for&gt; “winemaking”.
    /// <see href="http://aims.fao.org/aos/agrontology#isProcessFor"></see></summary>
    let isProcessFor = _prefix "isProcessFor"
    /// <summary>
    /// X &lt;uses process&gt; Y. X uses one or more actions, activities, methods Y as a process. E.g. “winter crops” &lt;uses process&gt; “vernalization”, “canning” &lt;uses process&gt; “sterilizing”.
    /// <see href="http://aims.fao.org/aos/agrontology#usesProcess"></see></summary>
    let usesProcess = _prefix "usesProcess"
    /// <summary>
    /// X &lt;is produced by&gt; Y. Restrict use to natural processes (such as fruits growing on plants, eggs, milk) - but also chemical processes. E.g. “honey” &lt;is produced by&gt; “honey bees”, “potatoes” &lt;is produced by&gt; “Solanum tuberosum". However, “cheese” &lt;product of&gt; “cheese-making”.
    /// <see href="http://aims.fao.org/aos/agrontology#isProducedBy"></see></summary>
    let isProducedBy = _prefix "isProducedBy"
    /// <summary>
    /// Y &lt;produces&gt; X. E.g. “honey bees” &lt;produces&gt;“honey”,  “Solanum tuberosum” &lt;produces&gt; "potatoes". However, “cheese-making” &lt;has product&gt;”cheese”.
    /// <see href="http://aims.fao.org/aos/agrontology#produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// Y &lt;is spatially included in&gt; X. Spatial region Y is an inalienable spatial part of spatial region X. E.g. "African inland waters" &lt;is spatially included in&gt; "Africa", "Peru" &lt;is spatially included in&gt; "Andean region".
    /// <see href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedIn"></see></summary>
    let isSpatiallyIncludedIn = _prefix "isSpatiallyIncludedIn"
    /// <summary>
    /// Super-property for spatial relationships
    /// <see href="http://aims.fao.org/aos/agrontology#spatialRelationship"></see></summary>
    let spatialRelationship = _prefix "spatialRelationship"
    /// <summary>
    /// X &lt;spatially includes&gt; Y. Region X spatially includes as inalienable part the spatial region Y. E.g. "Africa" &lt;spatially includes&gt; "African inland waters", "Andean region" &lt;spatially includes&gt; "Peru".
    /// <see href="http://aims.fao.org/aos/agrontology#spatiallyIncludes"></see></summary>
    let spatiallyIncludes = _prefix "spatiallyIncludes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInCity"></see>
    /// </summary>
    let isSpatiallyIncludedInCity = _prefix "isSpatiallyIncludedInCity"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInState"></see>
    /// </summary>
    let isSpatiallyIncludedInState = _prefix "isSpatiallyIncludedInState"
    /// <summary>
    /// X &lt;is studied by&gt; Y. Concept X is studied by field, science or group Y. E.g. “palaeontology”&lt;is studied by&gt; "palaeontologists”, “working conditions” &lt;is studied by&gt; “ergonomics”.
    /// <see href="http://aims.fao.org/aos/agrontology#isStudiedBy"></see></summary>
    let isStudiedBy = _prefix "isStudiedBy"
    /// <summary>
    /// Y &lt;study&gt; X. Field, science or group Y studies concept X. E.g. “sedimentology” &lt;study&gt; “sediment”,
    /// “wood anatomy” &lt;study&gt; “heartwood”.
    /// <see href="http://aims.fao.org/aos/agrontology#study"></see></summary>
    let study = _prefix "study"
    /// <summary>
    /// Y &lt;is use of&gt; X.  For example, "sweeteners" &lt;is use of&gt; '"sorbitol",  "fuels" &lt;is use of&gt; "ethanol".
    /// <see href="http://aims.fao.org/aos/agrontology#isUseOf"></see></summary>
    let isUseOf = _prefix "isUseOf"
    /// <summary>
    /// X &lt;is used as&gt; Y. E.g. "sorbitol" &lt;is used as&gt; "sweetener"; "ethanol" &lt;is used as&gt; "fuel".
    /// <see href="http://aims.fao.org/aos/agrontology#isUsedAs"></see></summary>
    let isUsedAs = _prefix "isUsedAs"
    /// <summary>
    /// X &lt;is used in&gt; Y. X is habitually used in Y, it is normal to use X in the practice of Y. E.g. “casings” &lt;is used in&gt; “sausages”, “trains” &lt;is used in&gt; “rail transport”.
    /// <see href="http://aims.fao.org/aos/agrontology#isUsedIn"></see></summary>
    let isUsedIn = _prefix "isUsedIn"
    /// <summary>
    /// Y &lt;make use of&gt; X. Activity Y makes use of process or input X. E.g. “navigation” &lt;make use of&gt; ”navigational aids”, “precision agriculture” &lt;make use of&gt; ”geographical information systems”, “rail transport” &lt;make use of&gt; “trains”.
    /// <see href="http://aims.fao.org/aos/agrontology#makeUseOf"></see></summary>
    let makeUseOf = _prefix "makeUseOf"
    /// <summary>
    /// UN M49 or the Standard Country or Area Codes for Statistical Use (Series M, No. 49) is a standard for area codes used by the United Nations for statistical purposes, developed and maintained by the United Nations Statistics Division.
    /// <see href="http://aims.fao.org/aos/agrontology#m49Code"></see></summary>
    let m49Code = _prefix "m49Code"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/agrontology#spellingVariant"></see>
    /// </summary>
    let spellingVariant = _prefix "spellingVariant"
    /// <summary>
    /// X &lt;surrounded by&gt; Y. The object X is physically surrounded by object Y. E.g. “pupae” &lt;surrounded by&gt; “cocoons“, "endosperm” &lt;surrounded by&gt; “aleurone cells". Use only for the terms that are physically immediately adjacent to each other. For geography use &lt;is spatially included in&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#surroundedBy"></see></summary>
    let surroundedBy = _prefix "surroundedBy"
    /// <summary>
    /// Y &lt;surrounds&gt; X. The object Y is physically surrounding object X. E.g. “cocoons” &lt;surrounds&gt; “pupae“, "aleurone cells” &lt;surrounds&gt; “endosperm". Use only for the terms that are physically immediately adjacent to each other. For geography use &lt;spatially Includes&gt;.
    /// <see href="http://aims.fao.org/aos/agrontology#surrounds"></see></summary>
    let surrounds = _prefix "surrounds"
    /// <summary>
    /// A concept that make use of a specific value.
    /// <see href="http://aims.fao.org/aos/agrontology#usingValue"></see></summary>
    let usingValue = _prefix "usingValue"
    /// <summary>
    /// A measure or other value used in a specific activity or methods or for any purpose.
    /// <see href="http://aims.fao.org/aos/agrontology#valueUsedIn"></see></summary>
    let valueUsedIn = _prefix "valueUsedIn"
