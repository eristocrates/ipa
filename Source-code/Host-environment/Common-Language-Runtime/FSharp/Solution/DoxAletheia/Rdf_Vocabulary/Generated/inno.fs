namespace http.purl.org.innovation.ns.hash

open DoxAletheia.Rdf_Vocabulary

module inno =
    let _namespace_name = "http://purl.org/innovation/ns#"
    /// <summary>
    /// A benefit to something or someone.
    /// <see href="http://purl.org/innovation/ns#Benefit"></see></summary>
    let Benefit = Namespaced_IRI.parse _namespace_name "Benefit" |> NamespacedName
    /// <summary>
    /// A symptom of a problem. This class is intended to comprise of SKOS concepts belonging to different schemes.
    /// <see href="http://purl.org/innovation/ns#Symptom"></see></summary>
    let Symptom = Namespaced_IRI.parse _namespace_name "Symptom" |> NamespacedName
    /// <summary>
    /// The application or usage of a device or process.
    ///
    /// Typically this is described using the properties usedBy, usedOn and usedWith
    /// <see href="http://purl.org/innovation/ns#Usage"></see></summary>
    let Usage = Namespaced_IRI.parse _namespace_name "Usage" |> NamespacedName
    /// <summary>
    /// The innovation is a conceptual entity, concerned with the idea. Its application comes in the form of benefits and improvements and the things that embody it.
    /// <see href="http://purl.org/innovation/ns#Innovation"></see></summary>
    let Innovation = Namespaced_IRI.parse _namespace_name "Innovation" |> NamespacedName
    /// <summary>
    /// The manifestation of a need. This is represented by a set of symptoms (general phenoma) affecting groups of things.
    /// <see href="http://purl.org/innovation/ns#Problem"></see></summary>
    let Problem = Namespaced_IRI.parse _namespace_name "Problem" |> NamespacedName
    /// <summary>
    /// The physical or tangible manfestiation of some idea, invention or innovation.
    /// A device, process, service, or product that emobodies some idea, invention or innovation.
    ///
    /// e.g The Firefox web browser is an embodiment of the innovation HTTP
    /// e.g Amoxicillin is an embodiment of the innovation Anibiotic
    /// <see href="http://purl.org/innovation/ns#Embodiment"></see></summary>
    let Embodiment = Namespaced_IRI.parse _namespace_name "Embodiment" |> NamespacedName

    /// <summary>
    /// The class of things that are improvements to something i.e making something better than it was.
    ///
    /// Specific improvements include those that provide improved efficiency, effectiveness, value or quality.
    /// <see href="http://purl.org/innovation/ns#Improvement"></see></summary>
    let Improvement =
        Namespaced_IRI.parse _namespace_name "Improvement" |> NamespacedName

    /// <summary>
    /// A stage of development. An example set of development stages, but equally those used to describe software lifecylces, music production lifecylces or anything creative can be used.
    ///
    /// e.g
    ///
    /// Define a need,
    /// Design a solution,
    /// Develop the opportunity,
    /// Demonstrate the benefits,
    /// Distribute the product.
    ///
    /// (taken from the 5 D's defined by the National Innovation Centre, 2011)
    /// <see href="http://purl.org/innovation/ns#DevelopmentStage"></see></summary>
    let DevelopmentStage =
        Namespaced_IRI.parse _namespace_name "DevelopmentStage" |> NamespacedName

    /// <summary>
    /// A need of a particular group or indivual of or for something that is lacking or requires improvement or problem solving.
    /// <see href="http://purl.org/innovation/ns#Need"></see></summary>
    let Need = Namespaced_IRI.parse _namespace_name "Need" |> NamespacedName
    /// <summary>
    /// A person, groups or organisation that can think out of the box, show great expertise or most importantly can find solutions to problems and meet the wants and needs of others.
    /// <see href="http://purl.org/innovation/ns#Innovator"></see></summary>
    let Innovator = Namespaced_IRI.parse _namespace_name "Innovator" |> NamespacedName
    /// <summary>
    /// The group of things affected by a problem. Again it is recommended that a SKOS model is used for such instances.
    /// <see href="http://purl.org/innovation/ns#affects"></see></summary>
    let affects = Namespaced_IRI.parse _namespace_name "affects" |> NamespacedName
    /// <summary>
    /// It is common for one innovation to build upon others. It doesn't neccessarily denote or infer that the subject has improvements on the object or is enabled by the object.
    /// <see href="http://purl.org/innovation/ns#buildsOn"></see></summary>
    let buildsOn = Namespaced_IRI.parse _namespace_name "buildsOn" |> NamespacedName

    /// <summary>
    /// A solution will have the best the chance of success if there is a clear and accurate understanding of the users needs.
    /// <see href="http://purl.org/innovation/ns#d1-defining-the-need"></see></summary>
    let ``d1-defining-the-need`` =
        Namespaced_IRI.parse _namespace_name "d1-defining-the-need" |> NamespacedName

    /// <summary>
    /// A scheme consisting of the the stages of development, comprised by the National Innovation Centre. It could be inferred by the asserted facts about an innovation what stage it qualifies for e.g if it is asserted that an innovation fulfils a particular need, then it qualifies as beingat least at development stage 1 (defining the need).
    /// <see href="http://purl.org/innovation/ns#stages-of-innovation"></see></summary>
    let ``stages-of-innovation`` =
        Namespaced_IRI.parse _namespace_name "stages-of-innovation" |> NamespacedName

    /// <summary>
    /// A well designed innovation is more likely to succeed. Looking at your users needs, work out how your innovatiion can meet them. Indentify the benefits, considering the users or recipients that will gain from your innovation. Outline final designs for your innovation and how they will meet the users’ needs. Decide when to stop designing and, if appropriate, start developing the idea.
    /// <see href="http://purl.org/innovation/ns#d2-designing-the-solution"></see></summary>
    let ``d2-designing-the-solution`` =
        Namespaced_IRI.parse _namespace_name "d2-designing-the-solution" |> NamespacedName

    /// <summary>
    /// Develop a prototype allowing for some ‘user preference’ analysis which can be fed back to the designers.
    /// <see href="http://purl.org/innovation/ns#d3-developing-the-opportunity"></see></summary>
    let ``d3-developing-the-opportunity`` =
        Namespaced_IRI.parse _namespace_name "d3-developing-the-opportunity" |> NamespacedName

    /// <summary>
    /// Test and demonstrate both the functional and non-functional qualities of the solution, emphasising the beneftis to the user.
    /// <see href="http://purl.org/innovation/ns#d4-demonstrating-the-benefits"></see></summary>
    let ``d4-demonstrating-the-benefits`` =
        Namespaced_IRI.parse _namespace_name "d4-demonstrating-the-benefits" |> NamespacedName

    /// <summary>
    /// Execute marketing plan and conducting key post-launch checks.
    /// <see href="http://purl.org/innovation/ns#d5-distributing-the-product"></see></summary>
    let ``d5-distributing-the-product`` =
        Namespaced_IRI.parse _namespace_name "d5-distributing-the-product" |> NamespacedName

    /// <summary>
    /// Relates an innovation to the innovator or innovators who developed it.
    ///
    /// Innovators are generally groups, organisations or people
    /// <see href="http://purl.org/innovation/ns#developedBy"></see></summary>
    let developedBy =
        Namespaced_IRI.parse _namespace_name "developedBy" |> NamespacedName

    /// <summary>
    /// Those benefits that are of an economic nature.
    /// <see href="http://purl.org/innovation/ns#economic-benefits"></see></summary>
    let ``economic-benefits`` =
        Namespaced_IRI.parse _namespace_name "economic-benefits" |> NamespacedName

    /// <summary>
    /// Those symptons that are of an economic nature.
    /// <see href="http://purl.org/innovation/ns#economic-symptoms"></see></summary>
    let ``economic-symptoms`` =
        Namespaced_IRI.parse _namespace_name "economic-symptoms" |> NamespacedName

    /// <summary>
    /// Relates an innovation to a device, process, product, or service (make, model or brand) that embodies the innovation
    ///
    /// e.g The innovation HTTP is emobdied by the browser Firefox
    /// e.g The innovation anibiotic is embodied by Amoxicillin
    /// <see href="http://purl.org/innovation/ns#embodiedBy"></see></summary>
    let embodiedBy = Namespaced_IRI.parse _namespace_name "embodiedBy" |> NamespacedName
    /// <summary>
    /// Relates a device, process, product, or service (make, model or brand) to an innovation that it embodies
    ///
    /// e.g The Firefox web browser embodies the innovation HTTP
    /// e.g Amoxicillin embodies the innovation Anibiotic
    /// <see href="http://purl.org/innovation/ns#embodies"></see></summary>
    let embodies = Namespaced_IRI.parse _namespace_name "embodies" |> NamespacedName
    /// <summary>
    /// Where one innovation is enabled by another innovation or innovations. It is common for innovators to have a solution to a problem that is dependent on something else not yet known, discovered, invented or innovated.
    /// <see href="http://purl.org/innovation/ns#enabledBy"></see></summary>
    let enabledBy = Namespaced_IRI.parse _namespace_name "enabledBy" |> NamespacedName
    /// <summary>
    /// Where one innovation enables a different innovation or innovations.
    /// <see href="http://purl.org/innovation/ns#enables"></see></summary>
    let enables = Namespaced_IRI.parse _namespace_name "enables" |> NamespacedName

    /// <summary>
    /// The expected date of introduction into the market. Mass production, commoditisation or  availability for sale.
    /// <see href="http://purl.org/innovation/ns#expectedMarketEntry"></see></summary>
    let expectedMarketEntry =
        Namespaced_IRI.parse _namespace_name "expectedMarketEntry" |> NamespacedName

    /// <summary>
    /// The applicabiity of an idea can be tested by its ability to fulfil a need. This property therefore links an innovation to a need.
    /// <see href="http://purl.org/innovation/ns#fulfils"></see></summary>
    let fulfils = Namespaced_IRI.parse _namespace_name "fulfils" |> NamespacedName
    /// <summary>
    /// Relates an innovation to some benefit or benefts of that innovation.
    /// <see href="http://purl.org/innovation/ns#hasBenefit"></see></summary>
    let hasBenefit = Namespaced_IRI.parse _namespace_name "hasBenefit" |> NamespacedName

    /// <summary>
    /// Relates innovator to the innovations they have developed.
    ///
    /// Innovators can be groups, organisations or people.
    /// <see href="http://purl.org/innovation/ns#hasDeveloped"></see></summary>
    let hasDeveloped =
        Namespaced_IRI.parse _namespace_name "hasDeveloped" |> NamespacedName

    /// <summary>
    /// Links an innovation to some improvement or improvements it provides.
    /// <see href="http://purl.org/innovation/ns#hasImprovement"></see></summary>
    let hasImprovement =
        Namespaced_IRI.parse _namespace_name "hasImprovement" |> NamespacedName

    /// <summary>
    /// A symptom of a problem. It is recommended that Symptoms follow a SKOS hierarchy.
    /// <see href="http://purl.org/innovation/ns#hasSympton"></see></summary>
    let hasSympton = Namespaced_IRI.parse _namespace_name "hasSympton" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/innovation/ns#Sympton"></see>
    /// </summary>
    let Sympton = Namespaced_IRI.parse _namespace_name "Sympton" |> NamespacedName
    /// <summary>
    /// The problem or need of some individual, group or organisation.
    /// <see href="http://purl.org/innovation/ns#hasUsage"></see></summary>
    let hasUsage = Namespaced_IRI.parse _namespace_name "hasUsage" |> NamespacedName

    /// <summary>
    /// Those benefits that are of a health related nature.
    /// <see href="http://purl.org/innovation/ns#health-benefits"></see></summary>
    let ``health-benefits`` =
        Namespaced_IRI.parse _namespace_name "health-benefits" |> NamespacedName

    /// <summary>
    /// Those symptons that are health related.
    /// <see href="http://purl.org/innovation/ns#health-symptoms"></see></summary>
    let ``health-symptoms`` =
        Namespaced_IRI.parse _namespace_name "health-symptoms" |> NamespacedName

    /// <summary>
    /// Links an improvement to something it improves.
    /// <see href="http://purl.org/innovation/ns#improves"></see></summary>
    let improves = Namespaced_IRI.parse _namespace_name "improves" |> NamespacedName

    /// <summary>
    /// An improvement to the effectiveness of the object i.e effectuates an increase in the desired result.
    ///
    /// e.g the combustion engine improves the effectiveness of a vehicle.
    ///
    /// Without consideration for cost of increase i.e does not necessitate an improvement in efficiciency.
    /// <see href="http://purl.org/innovation/ns#improvesEffectivenessOf"></see></summary>
    let improvesEffectivenessOf =
        Namespaced_IRI.parse _namespace_name "improvesEffectivenessOf" |> NamespacedName

    /// <summary>
    /// An improvement to the efficiency of the of the object. i.e reducing the cost, waste, time or skill required to produce the desired (same) results
    ///
    /// e.g
    ///
    /// Compared to other modes of transportation, a bicycle is efficient because it enables people to get to their destination with less effort.
    /// <see href="http://purl.org/innovation/ns#improvesEfficiencyOf"></see></summary>
    let improvesEfficiencyOf =
        Namespaced_IRI.parse _namespace_name "improvesEfficiencyOf" |> NamespacedName

    /// <summary>
    /// An improvement to the reliability, durability, accessibility, usability or some other non-functional aspect of the object.
    /// <see href="http://purl.org/innovation/ns#improvesQualityOf"></see></summary>
    let improvesQualityOf =
        Namespaced_IRI.parse _namespace_name "improvesQualityOf" |> NamespacedName

    /// <summary>
    /// An improvement to the worth or value of the object i.e as a result of the improvement something becomes more valuable or worthwhile.
    /// e.g:
    ///
    /// Nuclear Fission improves the value of Uranium.
    /// HTTP improves the value of the internet.
    /// <see href="http://purl.org/innovation/ns#improvesValueOf"></see></summary>
    let improvesValueOf =
        Namespaced_IRI.parse _namespace_name "improvesValueOf" |> NamespacedName

    /// <summary>
    /// Relates an innovator to a current innovation that they are developing.
    /// <see href="http://purl.org/innovation/ns#isDeveloping"></see></summary>
    let isDeveloping =
        Namespaced_IRI.parse _namespace_name "isDeveloping" |> NamespacedName

    /// <summary>
    /// Those benefits that are of a legal nature.
    /// <see href="http://purl.org/innovation/ns#legal-benefits"></see></summary>
    let ``legal-benefits`` =
        Namespaced_IRI.parse _namespace_name "legal-benefits" |> NamespacedName

    /// <summary>
    /// Those symptons that are of a legal nature.
    /// <see href="http://purl.org/innovation/ns#legal-symptoms"></see></summary>
    let ``legal-symptoms`` =
        Namespaced_IRI.parse _namespace_name "legal-symptoms" |> NamespacedName

    /// <summary>
    /// The problems that manifest a particular need. A need is generally described by its problems.
    /// <see href="http://purl.org/innovation/ns#manifestedBy"></see></summary>
    let manifestedBy =
        Namespaced_IRI.parse _namespace_name "manifestedBy" |> NamespacedName

    /// <summary>
    /// The problem that manifests a need. The problem defines the characteristics of the need.
    /// <see href="http://purl.org/innovation/ns#manifests"></see></summary>
    let manifests = Namespaced_IRI.parse _namespace_name "manifests" |> NamespacedName

    /// <summary>
    /// Those benefits that are of a scientific nature.
    /// <see href="http://purl.org/innovation/ns#scientific-benefits"></see></summary>
    let ``scientific-benefits`` =
        Namespaced_IRI.parse _namespace_name "scientific-benefits" |> NamespacedName

    /// <summary>
    /// Those symptons that are of a scientific nature.
    /// <see href="http://purl.org/innovation/ns#scientific-symptoms"></see></summary>
    let ``scientific-symptoms`` =
        Namespaced_IRI.parse _namespace_name "scientific-symptoms" |> NamespacedName

    /// <summary>
    /// Those benefits that are of a social nature.
    /// <see href="http://purl.org/innovation/ns#social-benefits"></see></summary>
    let ``social-benefits`` =
        Namespaced_IRI.parse _namespace_name "social-benefits" |> NamespacedName

    /// <summary>
    /// Those symptons that are of a social nature.
    /// <see href="http://purl.org/innovation/ns#social-symptoms"></see></summary>
    let ``social-symptoms`` =
        Namespaced_IRI.parse _namespace_name "social-symptoms" |> NamespacedName

    /// <summary>
    /// Connects an innovation to the problems it solves. Generally speaking, innovations that solve a need do so by solving similar problems associated with the need.
    /// <see href="http://purl.org/innovation/ns#solves"></see></summary>
    let solves = Namespaced_IRI.parse _namespace_name "solves" |> NamespacedName
    /// <summary>
    /// Relates a usage node to the thing that makes use of the device or process i.e the activator or implementor.
    /// <see href="http://purl.org/innovation/ns#usedBy"></see></summary>
    let usedBy = Namespaced_IRI.parse _namespace_name "usedBy" |> NamespacedName
    /// <summary>
    /// Defines the recipient use.
    /// <see href="http://purl.org/innovation/ns#usedOn"></see></summary>
    let usedOn = Namespaced_IRI.parse _namespace_name "usedOn" |> NamespacedName
    /// <summary>
    /// Where something is used in conjunction with something else.
    /// <see href="http://purl.org/innovation/ns#usedWith"></see></summary>
    let usedWith = Namespaced_IRI.parse _namespace_name "usedWith" |> NamespacedName
