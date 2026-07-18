namespace http.rdf.geospecies.org.methods.observationMethod.hash

open DoxAletheia.Rdf_Vocabulary

module obsm =
    let _namespace_name = "http://rdf.geospecies.org/methods/observationMethod#"

    /// <summary>
    /// Collection method based using a sticky substance that traps insects and other arthropods, usually in the form of a card with a sticky glue-like substance on one side. Often colored yellow or blue.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Above-Ground_Sticky_Trap"></see></summary>
    let ``Above-Ground_Sticky_Trap`` =
        Namespaced_IRI.parse _namespace_name "Above-Ground_Sticky_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#ArthropodCollectionMethods"></see>
    /// </summary>
    let ArthropodCollectionMethods =
        Namespaced_IRI.parse _namespace_name "ArthropodCollectionMethods" |> NamespacedName

    /// <summary>
    /// "Butterfly" Type Net
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Aerial_Collection_Net"></see></summary>
    let Aerial_Collection_Net =
        Namespaced_IRI.parse _namespace_name "Aerial_Collection_Net" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Manual_Collection_Method"></see>
    /// </summary>
    let Manual_Collection_Method =
        Namespaced_IRI.parse _namespace_name "Manual_Collection_Method" |> NamespacedName

    /// <summary>
    /// A handheld device operated by suction from the lungs of the collector or a vacuum fan, used to collect arthropods.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Aspirator"></see></summary>
    let Aspirator = Namespaced_IRI.parse _namespace_name "Aspirator" |> NamespacedName

    /// <summary>
    /// A form of Pitfall Trap that uses a barrier wall that directs arthropods into one of two pitfall traps at either end.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Barrier_Pitfall_Trap"></see></summary>
    let Barrier_Pitfall_Trap =
        Namespaced_IRI.parse _namespace_name "Barrier_Pitfall_Trap" |> NamespacedName

    /// <summary>
    /// Ground base traps that arthropods fall into.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Based_Trap"></see></summary>
    let Pitfall_Based_Trap =
        Namespaced_IRI.parse _namespace_name "Pitfall_Based_Trap" |> NamespacedName

    /// <summary>
    /// Method of arthropod collection for soil and litter samples
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Berlese_Sample"></see></summary>
    let Berlese_Sample =
        Namespaced_IRI.parse _namespace_name "Berlese_Sample" |> NamespacedName

    /// <summary>
    /// Usually a suction-based trap that collects arthropods attracted to light and CO2 (carbon dioxide)
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#CO2_Trap"></see></summary>
    let CO2_Trap = Namespaced_IRI.parse _namespace_name "CO2_Trap" |> NamespacedName

    /// <summary>
    /// Suction based traps, usually for flying insects. Often combined with an attractant.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Hanging_Suction_Based_Attraction_Trap"></see></summary>
    let Hanging_Suction_Based_Attraction_Trap =
        Namespaced_IRI.parse _namespace_name "Hanging_Suction_Based_Attraction_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Jar_Trap"></see>
    /// </summary>
    let Cantharidin_Baited_Jar_Trap =
        Namespaced_IRI.parse _namespace_name "Cantharidin_Baited_Jar_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Lindgren_Trap"></see>
    /// </summary>
    let Cantharidin_Baited_Lindgren_Trap =
        Namespaced_IRI.parse _namespace_name "Cantharidin_Baited_Lindgren_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Lindgren_Trap"></see>
    /// </summary>
    let Lindgren_Trap =
        Namespaced_IRI.parse _namespace_name "Lindgren_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Chicken-Mash_Baited_Trap"></see>
    /// </summary>
    let ``Chicken-Mash_Baited_Trap`` =
        Namespaced_IRI.parse _namespace_name "Chicken-Mash_Baited_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Flight_Intercept_Trap"></see>
    /// </summary>
    let Flight_Intercept_Trap =
        Namespaced_IRI.parse _namespace_name "Flight_Intercept_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Ground-based_Sticky_Trap"></see>
    /// </summary>
    let ``Ground-based_Sticky_Trap`` =
        Namespaced_IRI.parse _namespace_name "Ground-based_Sticky_Trap" |> NamespacedName

    /// <summary>
    /// Collection by hand, usually into a jar or container
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Hand_Collected"></see></summary>
    let Hand_Collected =
        Namespaced_IRI.parse _namespace_name "Hand_Collected" |> NamespacedName

    /// <summary>
    /// Manual collection of insects and other arthropods that bite humans using an aspirator. Usually used to collect mosquitoes or other blood feeding insects.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Human_Bite_Collection"></see></summary>
    let Human_Bite_Collection =
        Namespaced_IRI.parse _namespace_name "Human_Bite_Collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Human_Observation"></see>
    /// </summary>
    let Human_Observation =
        Namespaced_IRI.parse _namespace_name "Human_Observation" |> NamespacedName

    /// <summary>
    /// Usually a suction-based trap that collects arthropods attracted to light and CO2.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Light_and_CO2_Trap"></see></summary>
    let Light_and_CO2_Trap =
        Namespaced_IRI.parse _namespace_name "Light_and_CO2_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Malaise_Trap"></see>
    /// </summary>
    let Malaise_Trap =
        Namespaced_IRI.parse _namespace_name "Malaise_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Photographed"></see>
    /// </summary>
    let Photographed =
        Namespaced_IRI.parse _namespace_name "Photographed" |> NamespacedName

    /// <summary>
    /// A cup-like trap, place in the ground that captures terrestrial wandering arthropods which fall in.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Trap"></see></summary>
    let Pitfall_Trap =
        Namespaced_IRI.parse _namespace_name "Pitfall_Trap" |> NamespacedName

    /// <summary>
    /// Similar to an Aerial net, but constructed of stronger fabric for sweeping through vegetation.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Sweep_Net"></see></summary>
    let Sweep_Net = Namespaced_IRI.parse _namespace_name "Sweep_Net" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#UV_Light_Trap"></see>
    /// </summary>
    let UV_Light_Trap =
        Namespaced_IRI.parse _namespace_name "UV_Light_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Unbaited_Lindgren_Funnel_Trap"></see>
    /// </summary>
    let Unbaited_Lindgren_Funnel_Trap =
        Namespaced_IRI.parse _namespace_name "Unbaited_Lindgren_Funnel_Trap" |> NamespacedName

    /// <summary>
    /// A large, often back-mounted vacuum device to collect arthropods from vegetation.
    /// <see href="http://rdf.geospecies.org/methods/observationMethod#Vacuum_Collector"></see></summary>
    let Vacuum_Collector =
        Namespaced_IRI.parse _namespace_name "Vacuum_Collector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#Visible_Light_Trap"></see>
    /// </summary>
    let Visible_Light_Trap =
        Namespaced_IRI.parse _namespace_name "Visible_Light_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#alpha-piniene_Baited_Lindgren_Trap"></see>
    /// </summary>
    let ``alpha-piniene_Baited_Lindgren_Trap`` =
        Namespaced_IRI.parse _namespace_name "alpha-piniene_Baited_Lindgren_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/methods/observationMethod#ipsdiend_Baited_Lindgren_Trap"></see>
    /// </summary>
    let ipsdiend_Baited_Lindgren_Trap =
        Namespaced_IRI.parse _namespace_name "ipsdiend_Baited_Lindgren_Trap" |> NamespacedName
