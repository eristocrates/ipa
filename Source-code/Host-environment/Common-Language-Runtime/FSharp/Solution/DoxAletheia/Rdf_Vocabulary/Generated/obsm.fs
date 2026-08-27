namespace http.rdf.geospecies.org.methods.observationMethod.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module obsm =
    let _namespace_iri = Namespace_Iri obsm |> NamespaceIRI

    /// <summary>
    ///   <para>obsm:Above-Ground_Sticky_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collection method based using a sticky substance that traps insects and other arthropods, usually in the form of a card with a sticky glue-like substance on one side. Often colored yellow or blue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Above-Ground_Sticky_Trap">http://rdf.geospecies.org/methods/observationMethod#Above-Ground_Sticky_Trap</seealso>
    let Above_Ground_Sticky_Trap =
        Prefixed_Name(obsm, "Above-Ground_Sticky_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Aerial_Collection_Net</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""Butterfly" Type Net"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Aerial_Collection_Net">http://rdf.geospecies.org/methods/observationMethod#Aerial_Collection_Net</seealso>
    let Aerial_Collection_Net =
        Prefixed_Name(obsm, "Aerial_Collection_Net") |> PrefixedName

    /// <summary>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#ArthropodCollectionMethods">http://rdf.geospecies.org/methods/observationMethod#ArthropodCollectionMethods</seealso>
    let ArthropodCollectionMethods =
        Prefixed_Name(obsm, "ArthropodCollectionMethods") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Aspirator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A handheld device operated by suction from the lungs of the collector or a vacuum fan, used to collect arthropods."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Aspirator">http://rdf.geospecies.org/methods/observationMethod#Aspirator</seealso>
    let Aspirator = Prefixed_Name(obsm, "Aspirator") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Barrier_Pitfall_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A form of Pitfall Trap that uses a barrier wall that directs arthropods into one of two pitfall traps at either end."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Barrier_Pitfall_Trap">http://rdf.geospecies.org/methods/observationMethod#Barrier_Pitfall_Trap</seealso>
    let Barrier_Pitfall_Trap =
        Prefixed_Name(obsm, "Barrier_Pitfall_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Berlese_Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Method of arthropod collection for soil and litter samples"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Berlese_Sample">http://rdf.geospecies.org/methods/observationMethod#Berlese_Sample</seealso>
    let Berlese_Sample = Prefixed_Name(obsm, "Berlese_Sample") |> PrefixedName
    /// <summary>
    ///   <para>obsm:CO2_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usually a suction-based trap that collects arthropods attracted to light and CO2 (carbon dioxide)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#CO2_Trap">http://rdf.geospecies.org/methods/observationMethod#CO2_Trap</seealso>
    let CO2_Trap = Prefixed_Name(obsm, "CO2_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Cantharidin_Baited_Jar_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Jar_Trap">http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Jar_Trap</seealso>
    let Cantharidin_Baited_Jar_Trap =
        Prefixed_Name(obsm, "Cantharidin_Baited_Jar_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Cantharidin_Baited_Lindgren_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Lindgren_Trap">http://rdf.geospecies.org/methods/observationMethod#Cantharidin_Baited_Lindgren_Trap</seealso>
    let Cantharidin_Baited_Lindgren_Trap =
        Prefixed_Name(obsm, "Cantharidin_Baited_Lindgren_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Chicken-Mash_Baited_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Chicken-Mash_Baited_Trap">http://rdf.geospecies.org/methods/observationMethod#Chicken-Mash_Baited_Trap</seealso>
    let Chicken_Mash_Baited_Trap =
        Prefixed_Name(obsm, "Chicken-Mash_Baited_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Flight_Intercept_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Flight_Intercept_Trap">http://rdf.geospecies.org/methods/observationMethod#Flight_Intercept_Trap</seealso>
    let Flight_Intercept_Trap =
        Prefixed_Name(obsm, "Flight_Intercept_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Ground-based_Sticky_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Ground-based_Sticky_Trap">http://rdf.geospecies.org/methods/observationMethod#Ground-based_Sticky_Trap</seealso>
    let Ground_based_Sticky_Trap =
        Prefixed_Name(obsm, "Ground-based_Sticky_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Hand_Collected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collection by hand, usually into a jar or container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Hand_Collected">http://rdf.geospecies.org/methods/observationMethod#Hand_Collected</seealso>
    let Hand_Collected = Prefixed_Name(obsm, "Hand_Collected") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Hanging_Suction_Based_Attraction_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Suction based traps, usually for flying insects. Often combined with an attractant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Hanging_Suction_Based_Attraction_Trap">http://rdf.geospecies.org/methods/observationMethod#Hanging_Suction_Based_Attraction_Trap</seealso>
    let Hanging_Suction_Based_Attraction_Trap =
        Prefixed_Name(obsm, "Hanging_Suction_Based_Attraction_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Human_Bite_Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Manual collection of insects and other arthropods that bite humans using an aspirator. Usually used to collect mosquitoes or other blood feeding insects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Human_Bite_Collection">http://rdf.geospecies.org/methods/observationMethod#Human_Bite_Collection</seealso>
    let Human_Bite_Collection =
        Prefixed_Name(obsm, "Human_Bite_Collection") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Human_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Human_Observation">http://rdf.geospecies.org/methods/observationMethod#Human_Observation</seealso>
    let Human_Observation = Prefixed_Name(obsm, "Human_Observation") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Light_and_CO2_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usually a suction-based trap that collects arthropods attracted to light and CO2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Light_and_CO2_Trap">http://rdf.geospecies.org/methods/observationMethod#Light_and_CO2_Trap</seealso>
    let Light_and_CO2_Trap = Prefixed_Name(obsm, "Light_and_CO2_Trap") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Lindgren_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Lindgren_Trap">http://rdf.geospecies.org/methods/observationMethod#Lindgren_Trap</seealso>
    let Lindgren_Trap = Prefixed_Name(obsm, "Lindgren_Trap") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Malaise_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Malaise_Trap">http://rdf.geospecies.org/methods/observationMethod#Malaise_Trap</seealso>
    let Malaise_Trap = Prefixed_Name(obsm, "Malaise_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Manual_Collection_Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Manual_Collection_Method">http://rdf.geospecies.org/methods/observationMethod#Manual_Collection_Method</seealso>
    let Manual_Collection_Method =
        Prefixed_Name(obsm, "Manual_Collection_Method") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Photographed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Photographed">http://rdf.geospecies.org/methods/observationMethod#Photographed</seealso>
    let Photographed = Prefixed_Name(obsm, "Photographed") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Pitfall_Based_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ground base traps that arthropods fall into."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Based_Trap">http://rdf.geospecies.org/methods/observationMethod#Pitfall_Based_Trap</seealso>
    let Pitfall_Based_Trap = Prefixed_Name(obsm, "Pitfall_Based_Trap") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Pitfall_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A cup-like trap, place in the ground that captures terrestrial wandering arthropods which fall in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Pitfall_Trap">http://rdf.geospecies.org/methods/observationMethod#Pitfall_Trap</seealso>
    let Pitfall_Trap = Prefixed_Name(obsm, "Pitfall_Trap") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Sweep_Net</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Similar to an Aerial net, but constructed of stronger fabric for sweeping through vegetation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Sweep_Net">http://rdf.geospecies.org/methods/observationMethod#Sweep_Net</seealso>
    let Sweep_Net = Prefixed_Name(obsm, "Sweep_Net") |> PrefixedName
    /// <summary>
    ///   <para>obsm:UV_Light_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#UV_Light_Trap">http://rdf.geospecies.org/methods/observationMethod#UV_Light_Trap</seealso>
    let UV_Light_Trap = Prefixed_Name(obsm, "UV_Light_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Unbaited_Lindgren_Funnel_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Unbaited_Lindgren_Funnel_Trap">http://rdf.geospecies.org/methods/observationMethod#Unbaited_Lindgren_Funnel_Trap</seealso>
    let Unbaited_Lindgren_Funnel_Trap =
        Prefixed_Name(obsm, "Unbaited_Lindgren_Funnel_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:Vacuum_Collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large, often back-mounted vacuum device to collect arthropods from vegetation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Vacuum_Collector">http://rdf.geospecies.org/methods/observationMethod#Vacuum_Collector</seealso>
    let Vacuum_Collector = Prefixed_Name(obsm, "Vacuum_Collector") |> PrefixedName
    /// <summary>
    ///   <para>obsm:Visible_Light_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#Visible_Light_Trap">http://rdf.geospecies.org/methods/observationMethod#Visible_Light_Trap</seealso>
    let Visible_Light_Trap = Prefixed_Name(obsm, "Visible_Light_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:alpha-piniene_Baited_Lindgren_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#alpha-piniene_Baited_Lindgren_Trap">http://rdf.geospecies.org/methods/observationMethod#alpha-piniene_Baited_Lindgren_Trap</seealso>
    let alpha_piniene_Baited_Lindgren_Trap =
        Prefixed_Name(obsm, "alpha-piniene_Baited_Lindgren_Trap") |> PrefixedName

    /// <summary>
    ///   <para>obsm:ipsdiend_Baited_Lindgren_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/methods/observationMethod#ipsdiend_Baited_Lindgren_Trap">http://rdf.geospecies.org/methods/observationMethod#ipsdiend_Baited_Lindgren_Trap</seealso>
    let ipsdiend_Baited_Lindgren_Trap =
        Prefixed_Name(obsm, "ipsdiend_Baited_Lindgren_Trap") |> PrefixedName
