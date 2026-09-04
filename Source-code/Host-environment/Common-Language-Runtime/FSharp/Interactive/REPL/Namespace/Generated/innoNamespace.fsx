#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module inno =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/innovation/ns#" "inno"
    /// <summary>
    ///   <para>rdfs:label : Benefit</para>
    ///   <para>rdfs:comment : A benefit to something or someone.</para>
    ///   <a href="http://purl.org/innovation/ns#Benefit">inno:Benefit</a>
    /// </summary>
    let Benefit = _prefixId.prefix "Benefit"
    /// <summary>
    ///   <para>rdfs:label : DevelopmentStage</para>
    ///   <para>rdfs:comment : A stage of development. An example set of development stages, but equally those used to describe software lifecylces, music production lifecylces or anything creative can be used.
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
    ///   <a href="http://purl.org/innovation/ns#DevelopmentStage">inno:DevelopmentStage</a>
    /// </summary>
    let DevelopmentStage = _prefixId.prefix "DevelopmentStage"
    /// <summary>
    ///   <para>rdfs:label : Embodiment</para>
    ///   <para>rdfs:comment : The physical or tangible manfestiation of some idea, invention or innovation.
    /// A device, process, service, or product that emobodies some idea, invention or innovation.
    ///
    /// e.g The Firefox web browser is an embodiment of the innovation HTTP
    /// e.g Amoxicillin is an embodiment of the innovation Anibiotic</para>
    ///   <a href="http://purl.org/innovation/ns#Embodiment">inno:Embodiment</a>
    /// </summary>
    let Embodiment = _prefixId.prefix "Embodiment"
    /// <summary>
    ///   <para>rdfs:label : Improvement</para>
    ///   <para>rdfs:comment : The class of things that are improvements to something i.e making something better than it was.
    ///
    /// Specific improvements include those that provide improved efficiency, effectiveness, value or quality.</para>
    ///   <a href="http://purl.org/innovation/ns#Improvement">inno:Improvement</a>
    /// </summary>
    let Improvement = _prefixId.prefix "Improvement"
    /// <summary>
    ///   <para>rdfs:label : Innovation</para>
    ///   <para>rdfs:comment : The innovation is a conceptual entity, concerned with the idea. Its application comes in the form of benefits and improvements and the things that embody it.</para>
    ///   <a href="http://purl.org/innovation/ns#Innovation">inno:Innovation</a>
    /// </summary>
    let Innovation = _prefixId.prefix "Innovation"
    /// <summary>
    ///   <para>rdfs:comment : A person, groups or organisation that can think out of the box, show great expertise or most importantly can find solutions to problems and meet the wants and needs of others.</para>
    ///   <para>rdfs:label : Innovator</para>
    ///   <a href="http://purl.org/innovation/ns#Innovator">inno:Innovator</a>
    /// </summary>
    let Innovator = _prefixId.prefix "Innovator"
    /// <summary>
    ///   <para>rdfs:label : Need</para>
    ///   <para>rdfs:comment : A need of a particular group or indivual of or for something that is lacking or requires improvement or problem solving.</para>
    ///   <a href="http://purl.org/innovation/ns#Need">inno:Need</a>
    /// </summary>
    let Need = _prefixId.prefix "Need"
    /// <summary>
    ///   <para>rdfs:comment : The manifestation of a need. This is represented by a set of symptoms (general phenoma) affecting groups of things.</para>
    ///   <para>rdfs:label : Problem</para>
    ///   <a href="http://purl.org/innovation/ns#Problem">inno:Problem</a>
    /// </summary>
    let Problem = _prefixId.prefix "Problem"
    /// <summary>
    ///   <para>rdfs:label : Symptom</para>
    ///   <para>rdfs:comment : A symptom of a problem. This class is intended to comprise of SKOS concepts belonging to different schemes.</para>
    ///   <a href="http://purl.org/innovation/ns#Symptom">inno:Symptom</a>
    /// </summary>
    let Symptom = _prefixId.prefix "Symptom"
    let Sympton = _prefixId.prefix "Sympton"
    /// <summary>
    ///   <para>rdfs:label : Usage</para>
    ///   <para>rdfs:comment : The application or usage of a device or process.
    ///
    /// Typically this is described using the properties usedBy, usedOn and usedWith</para>
    ///   <a href="http://purl.org/innovation/ns#Usage">inno:Usage</a>
    /// </summary>
    let Usage = _prefixId.prefix "Usage"
    /// <summary>
    ///   <para>rdfs:comment : The group of things affected by a problem. Again it is recommended that a SKOS model is used for such instances.</para>
    ///   <para>rdfs:label : affects</para>
    ///   <a href="http://purl.org/innovation/ns#affects">inno:affects</a>
    /// </summary>
    let affects = _prefixId.prefix "affects"
    /// <summary>
    ///   <para>rdfs:comment : It is common for one innovation to build upon others. It doesn't neccessarily denote or infer that the subject has improvements on the object or is enabled by the object.</para>
    ///   <para>rdfs:label : buildsOn</para>
    ///   <a href="http://purl.org/innovation/ns#buildsOn">inno:buildsOn</a>
    /// </summary>
    let buildsOn = _prefixId.prefix "buildsOn"
    let d1_defining_the_need = _prefixId.prefix "d1-defining-the-need"
    let d2_designing_the_solution = _prefixId.prefix "d2-designing-the-solution"
    let d3_developing_the_opportunity = _prefixId.prefix "d3-developing-the-opportunity"
    let d4_demonstrating_the_benefits = _prefixId.prefix "d4-demonstrating-the-benefits"
    let d5_distributing_the_product = _prefixId.prefix "d5-distributing-the-product"
    /// <summary>
    ///   <para>rdfs:comment : Relates an innovation to the innovator or innovators who developed it.
    ///
    /// Innovators are generally groups, organisations or people</para>
    ///   <para>rdfs:label : developedBy</para>
    ///   <a href="http://purl.org/innovation/ns#developedBy">inno:developedBy</a>
    /// </summary>
    let developedBy = _prefixId.prefix "developedBy"
    let economic_benefits = _prefixId.prefix "economic-benefits"
    let economic_symptoms = _prefixId.prefix "economic-symptoms"
    /// <summary>
    ///   <para>rdfs:comment : Relates an innovation to a device, process, product, or service (make, model or brand) that embodies the innovation
    ///
    /// e.g The innovation HTTP is emobdied by the browser Firefox
    /// e.g The innovation anibiotic is embodied by Amoxicillin</para>
    ///   <para>rdfs:label : embodiedBy</para>
    ///   <a href="http://purl.org/innovation/ns#embodiedBy">inno:embodiedBy</a>
    /// </summary>
    let embodiedBy = _prefixId.prefix "embodiedBy"
    /// <summary>
    ///   <para>rdfs:comment : Relates a device, process, product, or service (make, model or brand) to an innovation that it embodies
    ///
    /// e.g The Firefox web browser embodies the innovation HTTP
    /// e.g Amoxicillin embodies the innovation Anibiotic</para>
    ///   <para>rdfs:label : embodies</para>
    ///   <a href="http://purl.org/innovation/ns#embodies">inno:embodies</a>
    /// </summary>
    let embodies = _prefixId.prefix "embodies"
    /// <summary>
    ///   <para>rdfs:comment : Where one innovation is enabled by another innovation or innovations. It is common for innovators to have a solution to a problem that is dependent on something else not yet known, discovered, invented or innovated.</para>
    ///   <para>rdfs:label : enabledBy</para>
    ///   <a href="http://purl.org/innovation/ns#enabledBy">inno:enabledBy</a>
    /// </summary>
    let enabledBy = _prefixId.prefix "enabledBy"
    /// <summary>
    ///   <para>rdfs:comment : Where one innovation enables a different innovation or innovations.</para>
    ///   <para>rdfs:label : enables</para>
    ///   <a href="http://purl.org/innovation/ns#enables">inno:enables</a>
    /// </summary>
    let enables = _prefixId.prefix "enables"
    /// <summary>
    ///   <para>rdfs:comment : The expected date of introduction into the market. Mass production, commoditisation or  availability for sale.</para>
    ///   <para>rdfs:label : expectedMarketEntry</para>
    ///   <a href="http://purl.org/innovation/ns#expectedMarketEntry">inno:expectedMarketEntry</a>
    /// </summary>
    let expectedMarketEntry = _prefixId.prefix "expectedMarketEntry"
    /// <summary>
    ///   <para>rdfs:comment : The applicabiity of an idea can be tested by its ability to fulfil a need. This property therefore links an innovation to a need.</para>
    ///   <para>rdfs:label : fulfils</para>
    ///   <a href="http://purl.org/innovation/ns#fulfils">inno:fulfils</a>
    /// </summary>
    let fulfils = _prefixId.prefix "fulfils"
    /// <summary>
    ///   <para>rdfs:comment : Relates an innovation to some benefit or benefts of that innovation.</para>
    ///   <para>rdfs:label : hasBenefit</para>
    ///   <a href="http://purl.org/innovation/ns#hasBenefit">inno:hasBenefit</a>
    /// </summary>
    let hasBenefit = _prefixId.prefix "hasBenefit"
    /// <summary>
    ///   <para>rdfs:comment : Relates innovator to the innovations they have developed.
    ///
    /// Innovators can be groups, organisations or people.</para>
    ///   <para>rdfs:label : hasDeveloped</para>
    ///   <a href="http://purl.org/innovation/ns#hasDeveloped">inno:hasDeveloped</a>
    /// </summary>
    let hasDeveloped = _prefixId.prefix "hasDeveloped"
    /// <summary>
    ///   <para>rdfs:comment : Links an innovation to some improvement or improvements it provides.</para>
    ///   <para>rdfs:label : hasImprovement</para>
    ///   <a href="http://purl.org/innovation/ns#hasImprovement">inno:hasImprovement</a>
    /// </summary>
    let hasImprovement = _prefixId.prefix "hasImprovement"
    /// <summary>
    ///   <para>rdfs:comment : A symptom of a problem. It is recommended that Symptoms follow a SKOS hierarchy.</para>
    ///   <para>rdfs:label : hasSympton</para>
    ///   <a href="http://purl.org/innovation/ns#hasSympton">inno:hasSympton</a>
    /// </summary>
    let hasSympton = _prefixId.prefix "hasSympton"
    /// <summary>
    ///   <para>rdfs:comment : The problem or need of some individual, group or organisation.</para>
    ///   <para>rdfs:label : hasUsage</para>
    ///   <a href="http://purl.org/innovation/ns#hasUsage">inno:hasUsage</a>
    /// </summary>
    let hasUsage = _prefixId.prefix "hasUsage"
    let health_benefits = _prefixId.prefix "health-benefits"
    let health_symptoms = _prefixId.prefix "health-symptoms"
    /// <summary>
    ///   <para>rdfs:comment : Links an improvement to something it improves.</para>
    ///   <para>rdfs:label : improves</para>
    ///   <a href="http://purl.org/innovation/ns#improves">inno:improves</a>
    /// </summary>
    let improves = _prefixId.prefix "improves"
    /// <summary>
    ///   <para>rdfs:comment : An improvement to the effectiveness of the object i.e effectuates an increase in the desired result.
    ///
    /// e.g the combustion engine improves the effectiveness of a vehicle.
    ///
    /// Without consideration for cost of increase i.e does not necessitate an improvement in efficiciency.</para>
    ///   <para>rdfs:label : improvesEffectivenessOf</para>
    ///   <a href="http://purl.org/innovation/ns#improvesEffectivenessOf">inno:improvesEffectivenessOf</a>
    /// </summary>
    let improvesEffectivenessOf = _prefixId.prefix "improvesEffectivenessOf"
    /// <summary>
    ///   <para>rdfs:comment : An improvement to the efficiency of the of the object. i.e reducing the cost, waste, time or skill required to produce the desired (same) results
    ///
    /// e.g
    ///
    /// Compared to other modes of transportation, a bicycle is efficient because it enables people to get to their destination with less effort.</para>
    ///   <para>rdfs:label : improvesEfficiencyOf</para>
    ///   <a href="http://purl.org/innovation/ns#improvesEfficiencyOf">inno:improvesEfficiencyOf</a>
    /// </summary>
    let improvesEfficiencyOf = _prefixId.prefix "improvesEfficiencyOf"
    /// <summary>
    ///   <para>rdfs:comment : An improvement to the reliability, durability, accessibility, usability or some other non-functional aspect of the object.</para>
    ///   <para>rdfs:label : improvesQualityOf</para>
    ///   <a href="http://purl.org/innovation/ns#improvesQualityOf">inno:improvesQualityOf</a>
    /// </summary>
    let improvesQualityOf = _prefixId.prefix "improvesQualityOf"
    /// <summary>
    ///   <para>rdfs:comment : An improvement to the worth or value of the object i.e as a result of the improvement something becomes more valuable or worthwhile.
    /// e.g:
    ///
    /// Nuclear Fission improves the value of Uranium.
    /// HTTP improves the value of the internet.</para>
    ///   <para>rdfs:label : improvesValueOf</para>
    ///   <a href="http://purl.org/innovation/ns#improvesValueOf">inno:improvesValueOf</a>
    /// </summary>
    let improvesValueOf = _prefixId.prefix "improvesValueOf"
    /// <summary>
    ///   <para>rdfs:comment : Relates an innovator to a current innovation that they are developing.</para>
    ///   <para>rdfs:label : isDeveloping</para>
    ///   <a href="http://purl.org/innovation/ns#isDeveloping">inno:isDeveloping</a>
    /// </summary>
    let isDeveloping = _prefixId.prefix "isDeveloping"
    let legal_benefits = _prefixId.prefix "legal-benefits"
    let legal_symptoms = _prefixId.prefix "legal-symptoms"
    /// <summary>
    ///   <para>rdfs:comment : The problems that manifest a particular need. A need is generally described by its problems.</para>
    ///   <para>rdfs:label : manifestedBy</para>
    ///   <a href="http://purl.org/innovation/ns#manifestedBy">inno:manifestedBy</a>
    /// </summary>
    let manifestedBy = _prefixId.prefix "manifestedBy"
    /// <summary>
    ///   <para>rdfs:comment : The problem that manifests a need. The problem defines the characteristics of the need.</para>
    ///   <para>rdfs:label : manifests</para>
    ///   <a href="http://purl.org/innovation/ns#manifests">inno:manifests</a>
    /// </summary>
    let manifests = _prefixId.prefix "manifests"
    let scientific_benefits = _prefixId.prefix "scientific-benefits"
    let scientific_symptoms = _prefixId.prefix "scientific-symptoms"
    let social_benefits = _prefixId.prefix "social-benefits"
    let social_symptoms = _prefixId.prefix "social-symptoms"
    /// <summary>
    ///   <para>rdfs:comment : Connects an innovation to the problems it solves. Generally speaking, innovations that solve a need do so by solving similar problems associated with the need.</para>
    ///   <para>rdfs:label : solves</para>
    ///   <a href="http://purl.org/innovation/ns#solves">inno:solves</a>
    /// </summary>
    let solves = _prefixId.prefix "solves"
    let stages_of_innovation = _prefixId.prefix "stages-of-innovation"
    /// <summary>
    ///   <para>rdfs:comment : Relates a usage node to the thing that makes use of the device or process i.e the activator or implementor.</para>
    ///   <para>rdfs:label : usedBy</para>
    ///   <a href="http://purl.org/innovation/ns#usedBy">inno:usedBy</a>
    /// </summary>
    let usedBy = _prefixId.prefix "usedBy"
    /// <summary>
    ///   <para>rdfs:comment : Defines the recipient use.</para>
    ///   <para>rdfs:label : usedOn</para>
    ///   <a href="http://purl.org/innovation/ns#usedOn">inno:usedOn</a>
    /// </summary>
    let usedOn = _prefixId.prefix "usedOn"
    /// <summary>
    ///   <para>rdfs:comment : Where something is used in conjunction with something else.</para>
    ///   <para>rdfs:label : usedWith</para>
    ///   <a href="http://purl.org/innovation/ns#usedWith">inno:usedWith</a>
    /// </summary>
    let usedWith = _prefixId.prefix "usedWith"
