namespace http.purl.org.innovation.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module inno =
    let _namespace_iri = Namespace_Iri inno |> NamespaceIRI
    /// <summary>
    ///   <para>inno:enables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Where one innovation enables a different innovation or innovations.</para>
    /// labels<para>enables</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#enables">http://purl.org/innovation/ns#enables</seealso>
    let enables = Prefixed_Name(inno, "enables") |> PrefixedName
    /// <summary>
    ///   <para>inno:fulfils</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The applicabiity of an idea can be tested by its ability to fulfil a need. This property therefore links an innovation to a need.</para>
    /// labels<para>fulfils</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#fulfils">http://purl.org/innovation/ns#fulfils</seealso>
    let fulfils = Prefixed_Name(inno, "fulfils") |> PrefixedName
    /// <summary>
    ///   <para>inno:hasImprovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an innovation to some improvement or improvements it provides.</para>
    /// labels<para>hasImprovement</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#hasImprovement">http://purl.org/innovation/ns#hasImprovement</seealso>
    let hasImprovement = Prefixed_Name(inno, "hasImprovement") |> PrefixedName
    /// <summary>
    ///   <para>inno:health-benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Those benefits that are of a health related nature.</para>
    /// labels<para>health-benefits</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#health-benefits">http://purl.org/innovation/ns#health-benefits</seealso>
    let health_benefits = Prefixed_Name(inno, "health-benefits") |> PrefixedName
    /// <summary>
    ///   <para>inno:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The application or usage of a device or process.
    ///
    /// Typically this is described using the properties usedBy, usedOn and usedWith</para>
    /// labels<para>Usage</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Usage">http://purl.org/innovation/ns#Usage</seealso>
    let Usage = Prefixed_Name(inno, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>inno:Innovation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The innovation is a conceptual entity, concerned with the idea. Its application comes in the form of benefits and improvements and the things that embody it.</para>
    /// labels<para>Innovation</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Innovation">http://purl.org/innovation/ns#Innovation</seealso>
    let Innovation = Prefixed_Name(inno, "Innovation") |> PrefixedName
    /// <summary>
    ///   <para>inno:Benefit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A benefit to something or someone.</para>
    /// labels<para>Benefit</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Benefit">http://purl.org/innovation/ns#Benefit</seealso>
    let Benefit = Prefixed_Name(inno, "Benefit") |> PrefixedName
    /// <summary>
    ///   <para>inno:Embodiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical or tangible manfestiation of some idea, invention or innovation.
    /// A device, process, service, or product that emobodies some idea, invention or innovation.
    ///
    /// e.g The Firefox web browser is an embodiment of the innovation HTTP
    /// e.g Amoxicillin is an embodiment of the innovation Anibiotic</para>
    /// labels<para>Embodiment</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Embodiment">http://purl.org/innovation/ns#Embodiment</seealso>
    let Embodiment = Prefixed_Name(inno, "Embodiment") |> PrefixedName
    /// <summary>
    ///   <para>inno:Need</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A need of a particular group or indivual of or for something that is lacking or requires improvement or problem solving.</para>
    /// labels<para>Need</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Need">http://purl.org/innovation/ns#Need</seealso>
    let Need = Prefixed_Name(inno, "Need") |> PrefixedName
    /// <summary>
    ///   <para>inno:Symptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A symptom of a problem. This class is intended to comprise of SKOS concepts belonging to different schemes.</para>
    /// labels<para>Symptom</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Symptom">http://purl.org/innovation/ns#Symptom</seealso>
    let Symptom = Prefixed_Name(inno, "Symptom") |> PrefixedName
    /// <summary>
    ///   <para>inno:Improvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of things that are improvements to something i.e making something better than it was.
    ///
    /// Specific improvements include those that provide improved efficiency, effectiveness, value or quality.</para>
    /// labels<para>Improvement</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Improvement">http://purl.org/innovation/ns#Improvement</seealso>
    let Improvement = Prefixed_Name(inno, "Improvement") |> PrefixedName
    /// <summary>
    ///   <para>inno:Problem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The manifestation of a need. This is represented by a set of symptoms (general phenoma) affecting groups of things.</para>
    /// labels<para>Problem</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Problem">http://purl.org/innovation/ns#Problem</seealso>
    let Problem = Prefixed_Name(inno, "Problem") |> PrefixedName
    /// <summary>
    ///   <para>inno:Innovator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person, groups or organisation that can think out of the box, show great expertise or most importantly can find solutions to problems and meet the wants and needs of others.</para>
    /// labels<para>Innovator</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Innovator">http://purl.org/innovation/ns#Innovator</seealso>
    let Innovator = Prefixed_Name(inno, "Innovator") |> PrefixedName
    /// <summary>
    ///   <para>inno:affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The group of things affected by a problem. Again it is recommended that a SKOS model is used for such instances.</para>
    /// labels<para>affects</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#affects">http://purl.org/innovation/ns#affects</seealso>
    let affects = Prefixed_Name(inno, "affects") |> PrefixedName

    /// <summary>
    ///   <para>inno:d1-defining-the-need</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:Concept</para>
    ///   <para>inno:DevelopmentStage</para>
    ///   <para>A solution will have the best the chance of success if there is a clear and accurate understanding of the users needs.</para>
    /// labels<para>d1-defining-the-need</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#d1-defining-the-need">http://purl.org/innovation/ns#d1-defining-the-need</seealso>
    let d1_defining_the_need =
        Prefixed_Name(inno, "d1-defining-the-need") |> PrefixedName

    /// <summary>
    ///   <para>inno:d2-designing-the-solution</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///   <para>inno:DevelopmentStage</para>
    ///   <para>A well designed innovation is more likely to succeed. Looking at your users needs, work out how your innovatiion can meet them. Indentify the benefits, considering the users or recipients that will gain from your innovation. Outline final designs for your innovation and how they will meet the users’ needs. Decide when to stop designing and, if appropriate, start developing the idea.</para>
    /// labels<para>d2-designing-the-solution</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#d2-designing-the-solution">http://purl.org/innovation/ns#d2-designing-the-solution</seealso>
    let d2_designing_the_solution =
        Prefixed_Name(inno, "d2-designing-the-solution") |> PrefixedName

    /// <summary>
    ///   <para>inno:buildsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It is common for one innovation to build upon others. It doesn't neccessarily denote or infer that the subject has improvements on the object or is enabled by the object.</para>
    /// labels<para>buildsOn</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#buildsOn">http://purl.org/innovation/ns#buildsOn</seealso>
    let buildsOn = Prefixed_Name(inno, "buildsOn") |> PrefixedName

    /// <summary>
    ///   <para>inno:stages-of-innovation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Thing</para>
    ///   <para>A scheme consisting of the the stages of development, comprised by the National Innovation Centre. It could be inferred by the asserted facts about an innovation what stage it qualifies for e.g if it is asserted that an innovation fulfils a particular need, then it qualifies as beingat least at development stage 1 (defining the need).</para>
    /// labels<para>stages-of-innovation</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#stages-of-innovation">http://purl.org/innovation/ns#stages-of-innovation</seealso>
    let stages_of_innovation =
        Prefixed_Name(inno, "stages-of-innovation") |> PrefixedName

    /// <summary>
    ///   <para>inno:d3-developing-the-opportunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>inno:DevelopmentStage</para>
    ///   <para>skos:Concept</para>
    ///   <para>Develop a prototype allowing for some ‘user preference’ analysis which can be fed back to the designers.</para>
    /// labels<para>d3-developing-the-opportunity</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#d3-developing-the-opportunity">http://purl.org/innovation/ns#d3-developing-the-opportunity</seealso>
    let d3_developing_the_opportunity =
        Prefixed_Name(inno, "d3-developing-the-opportunity") |> PrefixedName

    /// <summary>
    ///   <para>inno:developedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an innovation to the innovator or innovators who developed it.
    ///
    /// Innovators are generally groups, organisations or people</para>
    /// labels<para>developedBy</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#developedBy">http://purl.org/innovation/ns#developedBy</seealso>
    let developedBy = Prefixed_Name(inno, "developedBy") |> PrefixedName

    /// <summary>
    ///   <para>inno:d4-demonstrating-the-benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>inno:DevelopmentStage</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///   <para>Test and demonstrate both the functional and non-functional qualities of the solution, emphasising the beneftis to the user.</para>
    /// labels<para>d4-demonstrating-the-benefits</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#d4-demonstrating-the-benefits">http://purl.org/innovation/ns#d4-demonstrating-the-benefits</seealso>
    let d4_demonstrating_the_benefits =
        Prefixed_Name(inno, "d4-demonstrating-the-benefits") |> PrefixedName

    /// <summary>
    ///   <para>inno:d5-distributing-the-product</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///   <para>inno:DevelopmentStage</para>
    ///   <para>Execute marketing plan and conducting key post-launch checks.</para>
    /// labels<para>d5-distributing-the-product</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#d5-distributing-the-product">http://purl.org/innovation/ns#d5-distributing-the-product</seealso>
    let d5_distributing_the_product =
        Prefixed_Name(inno, "d5-distributing-the-product") |> PrefixedName

    /// <summary>
    ///   <para>inno:economic-benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Those benefits that are of an economic nature.</para>
    /// labels<para>economic-benefits</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#economic-benefits">http://purl.org/innovation/ns#economic-benefits</seealso>
    let economic_benefits = Prefixed_Name(inno, "economic-benefits") |> PrefixedName
    /// <summary>
    ///   <para>inno:economic-symptoms</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Thing</para>
    ///   <para>Those symptons that are of an economic nature.</para>
    /// labels<para>economic-symptoms</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#economic-symptoms">http://purl.org/innovation/ns#economic-symptoms</seealso>
    let economic_symptoms = Prefixed_Name(inno, "economic-symptoms") |> PrefixedName
    /// <summary>
    ///   <para>inno:embodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a device, process, product, or service (make, model or brand) to an innovation that it embodies
    ///
    /// e.g The Firefox web browser embodies the innovation HTTP
    /// e.g Amoxicillin embodies the innovation Anibiotic</para>
    /// labels<para>embodies</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#embodies">http://purl.org/innovation/ns#embodies</seealso>
    let embodies = Prefixed_Name(inno, "embodies") |> PrefixedName
    /// <summary>
    ///   <para>inno:expectedMarketEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The expected date of introduction into the market. Mass production, commoditisation or  availability for sale.</para>
    /// labels<para>expectedMarketEntry</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#expectedMarketEntry">http://purl.org/innovation/ns#expectedMarketEntry</seealso>
    let expectedMarketEntry = Prefixed_Name(inno, "expectedMarketEntry") |> PrefixedName
    /// <summary>
    ///   <para>inno:Sympton</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/innovation/ns#Sympton">http://purl.org/innovation/ns#Sympton</seealso>
    let Sympton = Prefixed_Name(inno, "Sympton") |> PrefixedName
    /// <summary>
    ///   <para>inno:hasUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The problem or need of some individual, group or organisation.</para>
    /// labels<para>hasUsage</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#hasUsage">http://purl.org/innovation/ns#hasUsage</seealso>
    let hasUsage = Prefixed_Name(inno, "hasUsage") |> PrefixedName
    /// <summary>
    ///   <para>inno:improves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an improvement to something it improves.</para>
    /// labels<para>improves</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#improves">http://purl.org/innovation/ns#improves</seealso>
    let improves = Prefixed_Name(inno, "improves") |> PrefixedName

    /// <summary>
    ///   <para>inno:improvesEfficiencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An improvement to the efficiency of the of the object. i.e reducing the cost, waste, time or skill required to produce the desired (same) results
    ///
    /// e.g
    ///
    /// Compared to other modes of transportation, a bicycle is efficient because it enables people to get to their destination with less effort.</para>
    /// labels<para>improvesEfficiencyOf</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#improvesEfficiencyOf">http://purl.org/innovation/ns#improvesEfficiencyOf</seealso>
    let improvesEfficiencyOf =
        Prefixed_Name(inno, "improvesEfficiencyOf") |> PrefixedName

    /// <summary>
    ///   <para>inno:isDeveloping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an innovator to a current innovation that they are developing.</para>
    /// labels<para>isDeveloping</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#isDeveloping">http://purl.org/innovation/ns#isDeveloping</seealso>
    let isDeveloping = Prefixed_Name(inno, "isDeveloping") |> PrefixedName
    /// <summary>
    ///   <para>inno:legal-symptoms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Those symptons that are of a legal nature.</para>
    /// labels<para>legal-symptoms</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#legal-symptoms">http://purl.org/innovation/ns#legal-symptoms</seealso>
    let legal_symptoms = Prefixed_Name(inno, "legal-symptoms") |> PrefixedName
    /// <summary>
    ///   <para>inno:embodiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an innovation to a device, process, product, or service (make, model or brand) that embodies the innovation
    ///
    /// e.g The innovation HTTP is emobdied by the browser Firefox
    /// e.g The innovation anibiotic is embodied by Amoxicillin</para>
    /// labels<para>embodiedBy</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#embodiedBy">http://purl.org/innovation/ns#embodiedBy</seealso>
    let embodiedBy = Prefixed_Name(inno, "embodiedBy") |> PrefixedName
    /// <summary>
    ///   <para>inno:enabledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Where one innovation is enabled by another innovation or innovations. It is common for innovators to have a solution to a problem that is dependent on something else not yet known, discovered, invented or innovated.</para>
    /// labels<para>enabledBy</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#enabledBy">http://purl.org/innovation/ns#enabledBy</seealso>
    let enabledBy = Prefixed_Name(inno, "enabledBy") |> PrefixedName
    /// <summary>
    ///   <para>inno:hasBenefit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an innovation to some benefit or benefts of that innovation.</para>
    /// labels<para>hasBenefit</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#hasBenefit">http://purl.org/innovation/ns#hasBenefit</seealso>
    let hasBenefit = Prefixed_Name(inno, "hasBenefit") |> PrefixedName
    /// <summary>
    ///   <para>inno:hasDeveloped</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates innovator to the innovations they have developed.
    ///
    /// Innovators can be groups, organisations or people.</para>
    /// labels<para>hasDeveloped</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#hasDeveloped">http://purl.org/innovation/ns#hasDeveloped</seealso>
    let hasDeveloped = Prefixed_Name(inno, "hasDeveloped") |> PrefixedName
    /// <summary>
    ///   <para>inno:hasSympton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A symptom of a problem. It is recommended that Symptoms follow a SKOS hierarchy.</para>
    /// labels<para>hasSympton</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#hasSympton">http://purl.org/innovation/ns#hasSympton</seealso>
    let hasSympton = Prefixed_Name(inno, "hasSympton") |> PrefixedName
    /// <summary>
    ///   <para>inno:health-symptoms</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Thing</para>
    ///   <para>Those symptons that are health related.</para>
    /// labels<para>health-symptoms</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#health-symptoms">http://purl.org/innovation/ns#health-symptoms</seealso>
    let health_symptoms = Prefixed_Name(inno, "health-symptoms") |> PrefixedName

    /// <summary>
    ///   <para>inno:improvesEffectivenessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An improvement to the effectiveness of the object i.e effectuates an increase in the desired result.
    ///
    /// e.g the combustion engine improves the effectiveness of a vehicle.
    ///
    /// Without consideration for cost of increase i.e does not necessitate an improvement in efficiciency.</para>
    /// labels<para>improvesEffectivenessOf</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#improvesEffectivenessOf">http://purl.org/innovation/ns#improvesEffectivenessOf</seealso>
    let improvesEffectivenessOf =
        Prefixed_Name(inno, "improvesEffectivenessOf") |> PrefixedName

    /// <summary>
    ///   <para>inno:improvesValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An improvement to the worth or value of the object i.e as a result of the improvement something becomes more valuable or worthwhile.
    /// e.g:
    ///
    /// Nuclear Fission improves the value of Uranium.
    /// HTTP improves the value of the internet.</para>
    /// labels<para>improvesValueOf</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#improvesValueOf">http://purl.org/innovation/ns#improvesValueOf</seealso>
    let improvesValueOf = Prefixed_Name(inno, "improvesValueOf") |> PrefixedName
    /// <summary>
    ///   <para>inno:legal-benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Thing</para>
    ///   <para>Those benefits that are of a legal nature.</para>
    /// labels<para>legal-benefits</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#legal-benefits">http://purl.org/innovation/ns#legal-benefits</seealso>
    let legal_benefits = Prefixed_Name(inno, "legal-benefits") |> PrefixedName
    /// <summary>
    ///   <para>inno:scientific-benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Those benefits that are of a scientific nature.</para>
    /// labels<para>scientific-benefits</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#scientific-benefits">http://purl.org/innovation/ns#scientific-benefits</seealso>
    let scientific_benefits = Prefixed_Name(inno, "scientific-benefits") |> PrefixedName
    /// <summary>
    ///   <para>inno:social-benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Thing</para>
    ///   <para>Those benefits that are of a social nature.</para>
    /// labels<para>social-benefits</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#social-benefits">http://purl.org/innovation/ns#social-benefits</seealso>
    let social_benefits = Prefixed_Name(inno, "social-benefits") |> PrefixedName
    /// <summary>
    ///   <para>inno:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a usage node to the thing that makes use of the device or process i.e the activator or implementor.</para>
    /// labels<para>usedBy</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#usedBy">http://purl.org/innovation/ns#usedBy</seealso>
    let usedBy = Prefixed_Name(inno, "usedBy") |> PrefixedName
    /// <summary>
    ///   <para>inno:improvesQualityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An improvement to the reliability, durability, accessibility, usability or some other non-functional aspect of the object.</para>
    /// labels<para>improvesQualityOf</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#improvesQualityOf">http://purl.org/innovation/ns#improvesQualityOf</seealso>
    let improvesQualityOf = Prefixed_Name(inno, "improvesQualityOf") |> PrefixedName
    /// <summary>
    ///   <para>inno:manifestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The problems that manifest a particular need. A need is generally described by its problems.</para>
    /// labels<para>manifestedBy</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#manifestedBy">http://purl.org/innovation/ns#manifestedBy</seealso>
    let manifestedBy = Prefixed_Name(inno, "manifestedBy") |> PrefixedName
    /// <summary>
    ///   <para>inno:manifests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The problem that manifests a need. The problem defines the characteristics of the need.</para>
    /// labels<para>manifests</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#manifests">http://purl.org/innovation/ns#manifests</seealso>
    let manifests = Prefixed_Name(inno, "manifests") |> PrefixedName
    /// <summary>
    ///   <para>inno:scientific-symptoms</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Thing</para>
    ///   <para>Those symptons that are of a scientific nature.</para>
    /// labels<para>scientific-symptoms</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#scientific-symptoms">http://purl.org/innovation/ns#scientific-symptoms</seealso>
    let scientific_symptoms = Prefixed_Name(inno, "scientific-symptoms") |> PrefixedName
    /// <summary>
    ///   <para>inno:solves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an innovation to the problems it solves. Generally speaking, innovations that solve a need do so by solving similar problems associated with the need.</para>
    /// labels<para>solves</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#solves">http://purl.org/innovation/ns#solves</seealso>
    let solves = Prefixed_Name(inno, "solves") |> PrefixedName
    /// <summary>
    ///   <para>inno:usedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Where something is used in conjunction with something else.</para>
    /// labels<para>usedWith</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#usedWith">http://purl.org/innovation/ns#usedWith</seealso>
    let usedWith = Prefixed_Name(inno, "usedWith") |> PrefixedName
    /// <summary>
    ///   <para>inno:social-symptoms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Those symptons that are of a social nature.</para>
    /// labels<para>social-symptoms</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#social-symptoms">http://purl.org/innovation/ns#social-symptoms</seealso>
    let social_symptoms = Prefixed_Name(inno, "social-symptoms") |> PrefixedName
    /// <summary>
    ///   <para>inno:usedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the recipient use.</para>
    /// labels<para>usedOn</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#usedOn">http://purl.org/innovation/ns#usedOn</seealso>
    let usedOn = Prefixed_Name(inno, "usedOn") |> PrefixedName
    /// <summary>
    ///   <para>inno:DevelopmentStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A stage of development. An example set of development stages, but equally those used to describe software lifecylces, music production lifecylces or anything creative can be used.
    ///
    /// e.g
    ///
    /// Define a need,
    /// Design a solution,
    /// Develop the opportunity,
    /// Demonstrate the benefits,
    /// Distribute the product.
    ///
    /// (taken from the 5 D's defined by the National Innovation Centre, 2011)</para>
    /// labels<para>DevelopmentStage</para></remarks>
    /// <seealso href="http://purl.org/innovation/ns#DevelopmentStage">http://purl.org/innovation/ns#DevelopmentStage</seealso>
    let DevelopmentStage = Prefixed_Name(inno, "DevelopmentStage") |> PrefixedName
