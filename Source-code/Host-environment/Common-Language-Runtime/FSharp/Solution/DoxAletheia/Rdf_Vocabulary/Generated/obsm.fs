namespace http.rdf.geospecies.org.methods.observationMethod.hash

open DoxAletheia

module obsm =
    let _namespace_name = "http://rdf.geospecies.org/methods/observationMethod#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Collection method based using a sticky substance that traps insects and other arthropods, usually in the form of a card with a sticky glue-like substance on one side. Often colored yellow or blue.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Above-Ground_Sticky_Trap"></see></summary>
    let ``Above-Ground_Sticky_Trap`` = _prefix "Above-Ground_Sticky_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#ArthropodCollectionMethods"></see>
    /// </summary>
    let ArthropodCollectionMethods = _prefix "ArthropodCollectionMethods"
    /// <summary>
    /// "Butterfly" Type Net
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Aerial_Collection_Net"></see></summary>
    let Aerial_Collection_Net = _prefix "Aerial_Collection_Net"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Manual_Collection_Method"></see>
    /// </summary>
    let Manual_Collection_Method = _prefix "Manual_Collection_Method"
    /// <summary>
    /// A handheld device operated by suction from the lungs of the collector or a vacuum fan, used to collect arthropods.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Aspirator"></see></summary>
    let Aspirator = _prefix "Aspirator"
    /// <summary>
    /// A form of Pitfall Trap that uses a barrier wall that directs arthropods into one of two pitfall traps at either end.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Barrier_Pitfall_Trap"></see></summary>
    let Barrier_Pitfall_Trap = _prefix "Barrier_Pitfall_Trap"
    /// <summary>
    /// Ground base traps that arthropods fall into.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Based_Trap"></see></summary>
    let Pitfall_Based_Trap = _prefix "Pitfall_Based_Trap"
    /// <summary>
    /// Method of arthropod collection for soil and litter samples
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Berlese_Sample"></see></summary>
    let Berlese_Sample = _prefix "Berlese_Sample"
    /// <summary>
    /// Usually a suction-based trap that collects arthropods attracted to light and CO2 (carbon dioxide)
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#CO2_Trap"></see></summary>
    let CO2_Trap = _prefix "CO2_Trap"

    /// <summary>
    /// Suction based traps, usually for flying insects. Often combined with an attractant.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Hanging_Suction_Based_Attraction_Trap"></see></summary>
    let Hanging_Suction_Based_Attraction_Trap =
        _prefix "Hanging_Suction_Based_Attraction_Trap"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Jar_Trap"></see>
    /// </summary>
    let Cantharidin_Baited_Jar_Trap = _prefix "Cantharidin_Baited_Jar_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Lindgren_Trap"></see>
    /// </summary>
    let Cantharidin_Baited_Lindgren_Trap = _prefix "Cantharidin_Baited_Lindgren_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Lindgren_Trap"></see>
    /// </summary>
    let Lindgren_Trap = _prefix "Lindgren_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Chicken-Mash_Baited_Trap"></see>
    /// </summary>
    let ``Chicken-Mash_Baited_Trap`` = _prefix "Chicken-Mash_Baited_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Flight_Intercept_Trap"></see>
    /// </summary>
    let Flight_Intercept_Trap = _prefix "Flight_Intercept_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Ground-based_Sticky_Trap"></see>
    /// </summary>
    let ``Ground-based_Sticky_Trap`` = _prefix "Ground-based_Sticky_Trap"
    /// <summary>
    /// Collection by hand, usually into a jar or container
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Hand_Collected"></see></summary>
    let Hand_Collected = _prefix "Hand_Collected"
    /// <summary>
    /// Manual collection of insects and other arthropods that bite humans using an aspirator. Usually used to collect mosquitoes or other blood feeding insects.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Human_Bite_Collection"></see></summary>
    let Human_Bite_Collection = _prefix "Human_Bite_Collection"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Human_Observation"></see>
    /// </summary>
    let Human_Observation = _prefix "Human_Observation"
    /// <summary>
    /// Usually a suction-based trap that collects arthropods attracted to light and CO2.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Light_and_CO2_Trap"></see></summary>
    let Light_and_CO2_Trap = _prefix "Light_and_CO2_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Malaise_Trap"></see>
    /// </summary>
    let Malaise_Trap = _prefix "Malaise_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Photographed"></see>
    /// </summary>
    let Photographed = _prefix "Photographed"
    /// <summary>
    /// A cup-like trap, place in the ground that captures terrestrial wandering arthropods which fall in.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Trap"></see></summary>
    let Pitfall_Trap = _prefix "Pitfall_Trap"
    /// <summary>
    /// Similar to an Aerial net, but constructed of stronger fabric for sweeping through vegetation.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Sweep_Net"></see></summary>
    let Sweep_Net = _prefix "Sweep_Net"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#UV_Light_Trap"></see>
    /// </summary>
    let UV_Light_Trap = _prefix "UV_Light_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Unbaited_Lindgren_Funnel_Trap"></see>
    /// </summary>
    let Unbaited_Lindgren_Funnel_Trap = _prefix "Unbaited_Lindgren_Funnel_Trap"
    /// <summary>
    /// A large, often back-mounted vacuum device to collect arthropods from vegetation.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Vacuum_Collector"></see></summary>
    let Vacuum_Collector = _prefix "Vacuum_Collector"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Visible_Light_Trap"></see>
    /// </summary>
    let Visible_Light_Trap = _prefix "Visible_Light_Trap"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#alpha-piniene_Baited_Lindgren_Trap"></see>
    /// </summary>
    let ``alpha-piniene_Baited_Lindgren_Trap`` =
        _prefix "alpha-piniene_Baited_Lindgren_Trap"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#ipsdiend_Baited_Lindgren_Trap"></see>
    /// </summary>
    let ipsdiend_Baited_Lindgren_Trap = _prefix "ipsdiend_Baited_Lindgren_Trap"
