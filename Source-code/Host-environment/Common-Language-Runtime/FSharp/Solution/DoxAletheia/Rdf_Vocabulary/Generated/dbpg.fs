namespace http.dbpedia.org.page.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dbpg =
    let _namespace_iri = Namespace_Iri dbpg |> NamespaceIRI
    /// <summary>
    ///   <para>planet:page/Academic_term</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/page/Academic_term">http://dbpedia.org/page/Academic_term</seealso>
    let Academic_term = Prefixed_Name(dbpg, "Academic_term") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Electric_vehicle_battery_manufacturers</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Electric_vehicle_battery_manufacturers">http://dbpedia.org/page/Category:Electric_vehicle_battery_manufacturers</seealso>
    let ``Category:Electric_vehicle_battery_manufacturers`` =
        Prefixed_Name(dbpg, "Category:Electric_vehicle_battery_manufacturers") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Fuel_cell_manufacturers</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Fuel_cell_manufacturers">http://dbpedia.org/page/Category:Fuel_cell_manufacturers</seealso>
    let ``Category:Fuel_cell_manufacturers`` =
        Prefixed_Name(dbpg, "Category:Fuel_cell_manufacturers") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Fuel_cell_vehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:RoadApplication</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Fuel cell vehicles"</para></remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Fuel_cell_vehicles">http://dbpedia.org/page/Category:Fuel_cell_vehicles</seealso>
    let ``Category:Fuel_cell_vehicles`` =
        Prefixed_Name(dbpg, "Category:Fuel_cell_vehicles") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Heating</para>
    ///
    /// labels<para>"Heating"</para></remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Heating">http://dbpedia.org/page/Category:Heating</seealso>
    let ``Category:Heating`` = Prefixed_Name(dbpg, "Category:Heating") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Heating,_ventilation_and_air_conditioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Heating</para>
    ///
    /// labels<para>"Heating, ventilation, and air conditioning"</para></remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Heating,_ventilation_and_air_conditioning">http://dbpedia.org/page/Category:Heating,_ventilation_and_air_conditioning</seealso>
    let ``Category:Heating,_ventilation_and_air_conditioning`` =
        Prefixed_Name(dbpg, "Category:Heating,_ventilation_and_air_conditioning") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Hydrogen_technologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenProduct</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Hydrogen_technologies">http://dbpedia.org/page/Category:Hydrogen_technologies</seealso>
    let ``Category:Hydrogen_technologies`` =
        Prefixed_Name(dbpg, "Category:Hydrogen_technologies") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Material_Handling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///   <para>"Material handling involves short-distance movement within the confines of a building or between a building and a transportation vehicle. It uses a wide range of manual, semi-automated, and automated equipment and includes consideration of the protection, storage, and control of materials throughout their manufacturing, warehousing, distribution, consumption, and disposal. Material handling can be used to create time and place utility through the handling, storage, and control of waste, as distinct from manufacturing, which creates form utility by changing the shape, form, and makeup of material."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Material_Handling">http://dbpedia.org/page/Category:Material_Handling</seealso>
    let ``Category:Material_Handling`` =
        Prefixed_Name(dbpg, "Category:Material_Handling") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Category:Residential_heating_appliances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ResidentialHeating</para>
    ///
    /// labels<para>"Residential heating appliances"</para></remarks>
    /// <seealso href="http://dbpedia.org/page/Category:Residential_heating_appliances">http://dbpedia.org/page/Category:Residential_heating_appliances</seealso>
    let ``Category:Residential_heating_appliances`` =
        Prefixed_Name(dbpg, "Category:Residential_heating_appliances") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Coach_%28vehicle%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/page/Coach_%28vehicle%29">http://dbpedia.org/page/Coach_%28vehicle%29</seealso>
    let ``Coach_%28vehicle%29`` =
        Prefixed_Name(dbpg, "Coach_%28vehicle%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Course_(education)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/page/Course_(education)">http://dbpedia.org/page/Course_(education)</seealso>
    let ``Course_(education)`` =
        Prefixed_Name(dbpg, "Course_(education)") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/National_Institute_for_Research_in_Computer_Science_and_Control</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/page/National_Institute_for_Research_in_Computer_Science_and_Control">http://dbpedia.org/page/National_Institute_for_Research_in_Computer_Science_and_Control</seealso>
    let National_Institute_for_Research_in_Computer_Science_and_Control =
        Prefixed_Name(dbpg, "National_Institute_for_Research_in_Computer_Science_and_Control") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/National_University_of_Distance_Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/page/National_University_of_Distance_Education">http://dbpedia.org/page/National_University_of_Distance_Education</seealso>
    let National_University_of_Distance_Education =
        Prefixed_Name(dbpg, "National_University_of_Distance_Education") |> PrefixedName

    /// <summary>
    ///   <para>planet:page/Transmission_%28mechanics%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/page/Transmission_%28mechanics%29">http://dbpedia.org/page/Transmission_%28mechanics%29</seealso>
    let ``Transmission_%28mechanics%29`` =
        Prefixed_Name(dbpg, "Transmission_%28mechanics%29") |> PrefixedName
