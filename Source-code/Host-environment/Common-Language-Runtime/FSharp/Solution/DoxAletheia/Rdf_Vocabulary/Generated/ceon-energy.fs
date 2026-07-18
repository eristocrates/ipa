namespace http.w3id.org.CEON.ontology.energy.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_energy =
    let _namespace_name = "http://w3id.org/CEON/ontology/energy/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/energy/0.2/"></see>
    /// </summary>
    let ``_0.2/`` = Namespaced_IRI.parse _namespace_name "0.2/" |> NamespacedName
    /// <summary>
    /// Biofuel is a fuel that is produced over a short time span from biomass.
    /// <see href="http://w3id.org/CEON/ontology/energy/Biofuel"></see></summary>
    let Biofuel = Namespaced_IRI.parse _namespace_name "Biofuel" |> NamespacedName
    /// <summary>
    /// Biomass represents matter from recently living (but now dead) organisms such as plants, algae and animals.
    /// <see href="http://w3id.org/CEON/ontology/energy/Biomass"></see></summary>
    let Biomass = Namespaced_IRI.parse _namespace_name "Biomass" |> NamespacedName
    /// <summary>
    /// Biogas represents an energy source that is produced from raw materials such as agricultural waste, manure, municipal waste, plant material, sewage, green waste, wastewater, and food waste.
    /// <see href="http://w3id.org/CEON/ontology/energy/Biogas"></see></summary>
    let Biogas = Namespaced_IRI.parse _namespace_name "Biogas" |> NamespacedName

    /// <summary>
    /// An energy source is a resource or system that provides the energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergySource"></see></summary>
    let EnergySource =
        Namespaced_IRI.parse _namespace_name "EnergySource" |> NamespacedName

    /// <summary>
    /// Coal is a black or dark-brown combustible mineral substance consisting of carbonized vegetable matter.
    /// <see href="http://w3id.org/CEON/ontology/energy/Coal"></see></summary>
    let Coal = Namespaced_IRI.parse _namespace_name "Coal" |> NamespacedName
    /// <summary>
    /// A fossil fuel is a carbon compound- or hydrocarbon-containing material[2] formed naturally in the Earth's crust from the buried remains of prehistoric organisms (animals, plants or planktons), a process that occurs within geological formations.
    /// <see href="http://w3id.org/CEON/ontology/energy/FossilFuel"></see></summary>
    let FossilFuel = Namespaced_IRI.parse _namespace_name "FossilFuel" |> NamespacedName
    /// <summary>
    /// Energy is an ability or a property of matter or a system, to do work because of its motion, its mass, its electric charge, etc.
    /// <see href="http://w3id.org/CEON/ontology/energy/Energy"></see></summary>
    let Energy = Namespaced_IRI.parse _namespace_name "Energy" |> NamespacedName

    /// <summary>
    /// The relation representing the particpation of an energy as a resource.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergyComposition"></see></summary>
    let EnergyComposition =
        Namespaced_IRI.parse _namespace_name "EnergyComposition" |> NamespacedName

    /// <summary>
    /// Energy Conversion is a process of transforming energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergyConversion"></see></summary>
    let EnergyConversion =
        Namespaced_IRI.parse _namespace_name "EnergyConversion" |> NamespacedName

    /// <summary>
    /// The infrastructures participating in various energy-related processes, including energy production, transmission or distribution.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergyInfrastructure"></see></summary>
    let EnergyInfrastructure =
        Namespaced_IRI.parse _namespace_name "EnergyInfrastructure" |> NamespacedName

    /// <summary>
    /// Geothermal Energy Source is the Earth's crust. Geothermal energy is thermal energy extracted from the Earth's crust. It combines energy from the formation of the planet and from radioactive decay.
    /// <see href="http://w3id.org/CEON/ontology/energy/GeothermalEnergySource"></see></summary>
    let GeothermalEnergySource =
        Namespaced_IRI.parse _namespace_name "GeothermalEnergySource" |> NamespacedName

    /// <summary>
    /// Hydropower is the use of falling or fast-running water to produce electricity or to power machines.
    /// <see href="http://w3id.org/CEON/ontology/energy/Hydropower"></see></summary>
    let Hydropower = Namespaced_IRI.parse _namespace_name "Hydropower" |> NamespacedName
    /// <summary>
    /// Natural gas is a combustible gas that is naturally generated and stored under certain geological conditions by ancient animals and plants buried deep underground. It is a gaseous mixture of hydrocarbons and non-hydrocarbons, with methane as its main component.
    /// <see href="http://w3id.org/CEON/ontology/energy/NaturalGas"></see></summary>
    let NaturalGas = Namespaced_IRI.parse _namespace_name "NaturalGas" |> NamespacedName

    /// <summary>
    /// Nonrenewable energy represents energy that comes from such resources that cannot be replaced onew they are used up.
    /// <see href="http://w3id.org/CEON/ontology/energy/NonRenewableEnergy"></see></summary>
    let NonRenewableEnergy =
        Namespaced_IRI.parse _namespace_name "NonRenewableEnergy" |> NamespacedName

    /// <summary>
    /// Petroleum is a naturally occurring yellow-black liquid chemical mixture found in geological formations, consisting primarily of hydrocarbons.
    /// <see href="http://w3id.org/CEON/ontology/energy/Petroleum"></see></summary>
    let Petroleum = Namespaced_IRI.parse _namespace_name "Petroleum" |> NamespacedName

    /// <summary>
    /// Renewable energy represents energy that comes from renewable resources.
    /// <see href="http://w3id.org/CEON/ontology/energy/RenewableEnergy"></see></summary>
    let RenewableEnergy =
        Namespaced_IRI.parse _namespace_name "RenewableEnergy" |> NamespacedName

    /// <summary>
    /// Solar Energy Source is the Sun.
    /// <see href="http://w3id.org/CEON/ontology/energy/SolarEnergySource"></see></summary>
    let SolarEnergySource =
        Namespaced_IRI.parse _namespace_name "SolarEnergySource" |> NamespacedName

    /// <summary>
    /// Wind Energy Source is the Wind.
    /// <see href="http://w3id.org/CEON/ontology/energy/WindEnergySource"></see></summary>
    let WindEnergySource =
        Namespaced_IRI.parse _namespace_name "WindEnergySource" |> NamespacedName

    /// <summary>
    /// hasAnergy represents that energy has part of anergy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasAnergy"></see></summary>
    let hasAnergy = Namespaced_IRI.parse _namespace_name "hasAnergy" |> NamespacedName

    /// <summary>
    /// hasCarbonIntensity measures how intensive that the carbon is for an energy source.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasCarbonIntensity"></see></summary>
    let hasCarbonIntensity =
        Namespaced_IRI.parse _namespace_name "hasCarbonIntensity" |> NamespacedName

    /// <summary>
    /// hasConvertedEnergy represents that an energy transformation process has its final energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasConvertedEnergy"></see></summary>
    let hasConvertedEnergy =
        Namespaced_IRI.parse _namespace_name "hasConvertedEnergy" |> NamespacedName

    /// <summary>
    /// hasEnergyComponentPercentage represents the percentage of a particular energy as a composition.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasEnergyComponentPercentage"></see></summary>
    let hasEnergyComponentPercentage =
        Namespaced_IRI.parse _namespace_name "hasEnergyComponentPercentage" |> NamespacedName

    /// <summary>
    /// hasEnergySource represents that energy can have some energy sources.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasEnergySource"></see></summary>
    let hasEnergySource =
        Namespaced_IRI.parse _namespace_name "hasEnergySource" |> NamespacedName

    /// <summary>
    /// hasExergy represents that energy has part of exergy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasExergy"></see></summary>
    let hasExergy = Namespaced_IRI.parse _namespace_name "hasExergy" |> NamespacedName

    /// <summary>
    /// hasOriginalEnergy represents that an energy transformation process has its initial energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasOriginalEnergy"></see></summary>
    let hasOriginalEnergy =
        Namespaced_IRI.parse _namespace_name "hasOriginalEnergy" |> NamespacedName

    /// <summary>
    /// hasSustainability measures how sustainable an energy source is.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasSustainability"></see></summary>
    let hasSustainability =
        Namespaced_IRI.parse _namespace_name "hasSustainability" |> NamespacedName

    /// <summary>
    /// participatingEnergy represents the energy in an energy composition.
    /// <see href="http://w3id.org/CEON/ontology/energy/participatingEnergy"></see></summary>
    let participatingEnergy =
        Namespaced_IRI.parse _namespace_name "participatingEnergy" |> NamespacedName
