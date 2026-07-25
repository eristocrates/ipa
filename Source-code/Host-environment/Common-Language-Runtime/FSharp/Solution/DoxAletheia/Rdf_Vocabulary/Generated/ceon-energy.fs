namespace http.w3id.org.CEON.ontology.energy.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_energy =
    let _namespace_iri = Namespace_Iri ceon_energy |> NamespaceIRI
    /// <summary>
    ///   <para>ceon-energy:Biofuel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Biofuel is a fuel that is produced over a short time span from biomass.</para>
    /// labels<para>Biofuel</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Biofuel">http://w3id.org/CEON/ontology/energy/Biofuel</seealso>
    let Biofuel = Prefixed_Name(ceon_energy, "Biofuel") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:Biomass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Biomass represents matter from recently living (but now dead) organisms such as plants, algae and animals.</para>
    /// labels<para>Biomass</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Biomass">http://w3id.org/CEON/ontology/energy/Biomass</seealso>
    let Biomass = Prefixed_Name(ceon_energy, "Biomass") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:Biogas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Biogas represents an energy source that is produced from raw materials such as agricultural waste, manure, municipal waste, plant material, sewage, green waste, wastewater, and food waste.</para>
    /// labels<para>Biogass</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Biogas">http://w3id.org/CEON/ontology/energy/Biogas</seealso>
    let Biogas = Prefixed_Name(ceon_energy, "Biogas") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:Coal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Coal is a black or dark-brown combustible mineral substance consisting of carbonized vegetable matter.</para>
    /// labels<para>Coal</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Coal">http://w3id.org/CEON/ontology/energy/Coal</seealso>
    let Coal = Prefixed_Name(ceon_energy, "Coal") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:FossilFuel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fossil fuel is a carbon compound- or hydrocarbon-containing material[2] formed naturally in the Earth's crust from the buried remains of prehistoric organisms (animals, plants or planktons), a process that occurs within geological formations.</para>
    /// labels<para>Fossil Fuel</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/FossilFuel">http://w3id.org/CEON/ontology/energy/FossilFuel</seealso>
    let FossilFuel = Prefixed_Name(ceon_energy, "FossilFuel") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:EnergyComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation representing the particpation of an energy as a resource.</para>
    /// labels<para>Energy Composition</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/EnergyComposition">http://w3id.org/CEON/ontology/energy/EnergyComposition</seealso>
    let EnergyComposition =
        Prefixed_Name(ceon_energy, "EnergyComposition") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:EnergySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An energy source is a resource or system that provides the energy.</para>
    /// labels<para>Energy Source</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/EnergySource">http://w3id.org/CEON/ontology/energy/EnergySource</seealso>
    let EnergySource = Prefixed_Name(ceon_energy, "EnergySource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:EnergyInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The infrastructures participating in various energy-related processes, including energy production, transmission or distribution.</para>
    /// labels<para>Energy Infrastructure</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/EnergyInfrastructure">http://w3id.org/CEON/ontology/energy/EnergyInfrastructure</seealso>
    let EnergyInfrastructure =
        Prefixed_Name(ceon_energy, "EnergyInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Energy is an ability or a property of matter or a system, to do work because of its motion, its mass, its electric charge, etc.</para>
    /// labels<para>Energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Energy">http://w3id.org/CEON/ontology/energy/Energy</seealso>
    let Energy = Prefixed_Name(ceon_energy, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:Hydropower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hydropower is the use of falling or fast-running water to produce electricity or to power machines.</para>
    /// labels<para>Hydropower</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Hydropower">http://w3id.org/CEON/ontology/energy/Hydropower</seealso>
    let Hydropower = Prefixed_Name(ceon_energy, "Hydropower") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:NonRenewableEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Nonrenewable energy represents energy that comes from such resources that cannot be replaced onew they are used up.</para>
    /// labels<para>NonReneable Energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/NonRenewableEnergy">http://w3id.org/CEON/ontology/energy/NonRenewableEnergy</seealso>
    let NonRenewableEnergy =
        Prefixed_Name(ceon_energy, "NonRenewableEnergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:SolarEnergySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Solar Energy Source is the Sun.</para>
    /// labels<para>Solar Energy Source</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/SolarEnergySource">http://w3id.org/CEON/ontology/energy/SolarEnergySource</seealso>
    let SolarEnergySource =
        Prefixed_Name(ceon_energy, "SolarEnergySource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:EnergyConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Energy Conversion is a process of transforming energy.</para>
    /// labels<para>Energy Conversion</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/EnergyConversion">http://w3id.org/CEON/ontology/energy/EnergyConversion</seealso>
    let EnergyConversion =
        Prefixed_Name(ceon_energy, "EnergyConversion") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:GeothermalEnergySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geothermal Energy Source is the Earth's crust. Geothermal energy is thermal energy extracted from the Earth's crust. It combines energy from the formation of the planet and from radioactive decay.</para>
    /// labels<para>Geothermal Energy Source</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/GeothermalEnergySource">http://w3id.org/CEON/ontology/energy/GeothermalEnergySource</seealso>
    let GeothermalEnergySource =
        Prefixed_Name(ceon_energy, "GeothermalEnergySource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:Petroleum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Petroleum is a naturally occurring yellow-black liquid chemical mixture found in geological formations, consisting primarily of hydrocarbons.</para>
    /// labels<para>Petroleum</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/Petroleum">http://w3id.org/CEON/ontology/energy/Petroleum</seealso>
    let Petroleum = Prefixed_Name(ceon_energy, "Petroleum") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:NaturalGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Natural gas is a combustible gas that is naturally generated and stored under certain geological conditions by ancient animals and plants buried deep underground. It is a gaseous mixture of hydrocarbons and non-hydrocarbons, with methane as its main component.</para>
    /// labels<para>Natural Gas</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/NaturalGas">http://w3id.org/CEON/ontology/energy/NaturalGas</seealso>
    let NaturalGas = Prefixed_Name(ceon_energy, "NaturalGas") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:WindEnergySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Wind Energy Source is the Wind.</para>
    /// labels<para>Wind Energy Source</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/WindEnergySource">http://w3id.org/CEON/ontology/energy/WindEnergySource</seealso>
    let WindEnergySource =
        Prefixed_Name(ceon_energy, "WindEnergySource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:RenewableEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Renewable energy represents energy that comes from renewable resources.</para>
    /// labels<para>Renewable Energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/RenewableEnergy">http://w3id.org/CEON/ontology/energy/RenewableEnergy</seealso>
    let RenewableEnergy = Prefixed_Name(ceon_energy, "RenewableEnergy") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:hasAnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasAnergy represents that energy has part of anergy.</para>
    /// labels<para>has anergy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasAnergy">http://w3id.org/CEON/ontology/energy/hasAnergy</seealso>
    let hasAnergy = Prefixed_Name(ceon_energy, "hasAnergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasConvertedEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasConvertedEnergy represents that an energy transformation process has its final energy.</para>
    /// labels<para>has converted energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasConvertedEnergy">http://w3id.org/CEON/ontology/energy/hasConvertedEnergy</seealso>
    let hasConvertedEnergy =
        Prefixed_Name(ceon_energy, "hasConvertedEnergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasEnergyComponentPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>hasEnergyComponentPercentage represents the percentage of a particular energy as a composition.</para>
    /// labels<para>has energy component percentage</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasEnergyComponentPercentage">http://w3id.org/CEON/ontology/energy/hasEnergyComponentPercentage</seealso>
    let hasEnergyComponentPercentage =
        Prefixed_Name(ceon_energy, "hasEnergyComponentPercentage") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasExergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasExergy represents that energy has part of exergy.</para>
    /// labels<para>has exergy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasExergy">http://w3id.org/CEON/ontology/energy/hasExergy</seealso>
    let hasExergy = Prefixed_Name(ceon_energy, "hasExergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasCarbonIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>hasCarbonIntensity measures how intensive that the carbon is for an energy source.</para>
    /// labels<para>has carbon intensity</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasCarbonIntensity">http://w3id.org/CEON/ontology/energy/hasCarbonIntensity</seealso>
    let hasCarbonIntensity =
        Prefixed_Name(ceon_energy, "hasCarbonIntensity") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasEnergySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasEnergySource represents that energy can have some energy sources.</para>
    /// labels<para>has energy source</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasEnergySource">http://w3id.org/CEON/ontology/energy/hasEnergySource</seealso>
    let hasEnergySource = Prefixed_Name(ceon_energy, "hasEnergySource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasSustainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>hasSustainability measures how sustainable an energy source is.</para>
    /// labels<para>has sustainability</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasSustainability">http://w3id.org/CEON/ontology/energy/hasSustainability</seealso>
    let hasSustainability =
        Prefixed_Name(ceon_energy, "hasSustainability") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:hasOriginalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasOriginalEnergy represents that an energy transformation process has its initial energy.</para>
    /// labels<para>has original energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/hasOriginalEnergy">http://w3id.org/CEON/ontology/energy/hasOriginalEnergy</seealso>
    let hasOriginalEnergy =
        Prefixed_Name(ceon_energy, "hasOriginalEnergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:participatingEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>participatingEnergy represents the energy in an energy composition.</para>
    /// labels<para>participating energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/participatingEnergy">http://w3id.org/CEON/ontology/energy/participatingEnergy</seealso>
    let participatingEnergy =
        Prefixed_Name(ceon_energy, "participatingEnergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-energy:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/">http://w3id.org/CEON/ontology/energy/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_energy, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon-energy:0.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/energy/0.2/">http://w3id.org/CEON/ontology/energy/0.2/</seealso>
    let ``_0.2/`` = Prefixed_Name(ceon_energy, "0.2/") |> PrefixedName
