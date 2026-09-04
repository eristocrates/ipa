#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module obsm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf.geospecies.org/methods/observationMethod#" "obsm"

    /// <summary>
    ///   <para>rdfs:comment : Collection method based using a sticky substance that traps insects and other arthropods, usually in the form of a card with a sticky glue-like substance on one side. Often colored yellow or blue.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Above-Ground_Sticky_Trap">obsm:Above-Ground_Sticky_Trap</a>
    /// </summary>
    let Above_Ground_Sticky_Trap = _prefixId.prefix "Above-Ground_Sticky_Trap"
    /// <summary>
    ///   <para>rdfs:comment : "Butterfly" Type Net^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Aerial_Collection_Net">obsm:Aerial_Collection_Net</a>
    /// </summary>
    let Aerial_Collection_Net = _prefixId.prefix "Aerial_Collection_Net"
    let ArthropodCollectionMethods = _prefixId.prefix "ArthropodCollectionMethods"
    /// <summary>
    ///   <para>rdfs:comment : A handheld device operated by suction from the lungs of the collector or a vacuum fan, used to collect arthropods.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Aspirator">obsm:Aspirator</a>
    /// </summary>
    let Aspirator = _prefixId.prefix "Aspirator"
    /// <summary>
    ///   <para>rdfs:comment : A form of Pitfall Trap that uses a barrier wall that directs arthropods into one of two pitfall traps at either end.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Barrier_Pitfall_Trap">obsm:Barrier_Pitfall_Trap</a>
    /// </summary>
    let Barrier_Pitfall_Trap = _prefixId.prefix "Barrier_Pitfall_Trap"
    /// <summary>
    ///   <para>rdfs:comment : Method of arthropod collection for soil and litter samples^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Berlese_Sample">obsm:Berlese_Sample</a>
    /// </summary>
    let Berlese_Sample = _prefixId.prefix "Berlese_Sample"
    /// <summary>
    ///   <para>rdfs:comment : Usually a suction-based trap that collects arthropods attracted to light and CO2 (carbon dioxide)^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#CO2_Trap">obsm:CO2_Trap</a>
    /// </summary>
    let CO2_Trap = _prefixId.prefix "CO2_Trap"
    let Cantharidin_Baited_Jar_Trap = _prefixId.prefix "Cantharidin_Baited_Jar_Trap"

    let Cantharidin_Baited_Lindgren_Trap =
        _prefixId.prefix "Cantharidin_Baited_Lindgren_Trap"

    let Chicken_Mash_Baited_Trap = _prefixId.prefix "Chicken-Mash_Baited_Trap"
    let Flight_Intercept_Trap = _prefixId.prefix "Flight_Intercept_Trap"
    let Ground_based_Sticky_Trap = _prefixId.prefix "Ground-based_Sticky_Trap"
    /// <summary>
    ///   <para>rdfs:comment : Collection by hand, usually into a jar or container^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Hand_Collected">obsm:Hand_Collected</a>
    /// </summary>
    let Hand_Collected = _prefixId.prefix "Hand_Collected"

    /// <summary>
    ///   <para>rdfs:comment : Suction based traps, usually for flying insects. Often combined with an attractant.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Hanging_Suction_Based_Attraction_Trap">obsm:Hanging_Suction_Based_Attraction_Trap</a>
    /// </summary>
    let Hanging_Suction_Based_Attraction_Trap =
        _prefixId.prefix "Hanging_Suction_Based_Attraction_Trap"

    /// <summary>
    ///   <para>rdfs:comment : Manual collection of insects and other arthropods that bite humans using an aspirator. Usually used to collect mosquitoes or other blood feeding insects.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Human_Bite_Collection">obsm:Human_Bite_Collection</a>
    /// </summary>
    let Human_Bite_Collection = _prefixId.prefix "Human_Bite_Collection"
    let Human_Observation = _prefixId.prefix "Human_Observation"
    /// <summary>
    ///   <para>rdfs:comment : Usually a suction-based trap that collects arthropods attracted to light and CO2.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Light_and_CO2_Trap">obsm:Light_and_CO2_Trap</a>
    /// </summary>
    let Light_and_CO2_Trap = _prefixId.prefix "Light_and_CO2_Trap"
    let Lindgren_Trap = _prefixId.prefix "Lindgren_Trap"
    let Malaise_Trap = _prefixId.prefix "Malaise_Trap"
    let Manual_Collection_Method = _prefixId.prefix "Manual_Collection_Method"
    let Photographed = _prefixId.prefix "Photographed"
    /// <summary>
    ///   <para>rdfs:comment : Ground base traps that arthropods fall into.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Based_Trap">obsm:Pitfall_Based_Trap</a>
    /// </summary>
    let Pitfall_Based_Trap = _prefixId.prefix "Pitfall_Based_Trap"
    /// <summary>
    ///   <para>rdfs:comment : A cup-like trap, place in the ground that captures terrestrial wandering arthropods which fall in.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Trap">obsm:Pitfall_Trap</a>
    /// </summary>
    let Pitfall_Trap = _prefixId.prefix "Pitfall_Trap"
    /// <summary>
    ///   <para>rdfs:comment : Similar to an Aerial net, but constructed of stronger fabric for sweeping through vegetation.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Sweep_Net">obsm:Sweep_Net</a>
    /// </summary>
    let Sweep_Net = _prefixId.prefix "Sweep_Net"
    let UV_Light_Trap = _prefixId.prefix "UV_Light_Trap"
    let Unbaited_Lindgren_Funnel_Trap = _prefixId.prefix "Unbaited_Lindgren_Funnel_Trap"
    /// <summary>
    ///   <para>rdfs:comment : A large, often back-mounted vacuum device to collect arthropods from vegetation.^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/methods/observationMethod#Vacuum_Collector">obsm:Vacuum_Collector</a>
    /// </summary>
    let Vacuum_Collector = _prefixId.prefix "Vacuum_Collector"
    let Visible_Light_Trap = _prefixId.prefix "Visible_Light_Trap"

    let alpha_piniene_Baited_Lindgren_Trap =
        _prefixId.prefix "alpha-piniene_Baited_Lindgren_Trap"

    let ipsdiend_Baited_Lindgren_Trap = _prefixId.prefix "ipsdiend_Baited_Lindgren_Trap"
