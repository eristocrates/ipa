namespace http.w3id.org.CEON.ontology.energy.slash

open DoxAletheia

module ceon_energy =
    let _namespace_name = "http://w3id.org/CEON/ontology/energy/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/energy/0.2/"></see>
    /// </summary>
    let ``_0.2/`` = _prefix "0.2/"
    /// <summary>
    /// Biofuel is a fuel that is produced over a short time span from biomass.
    /// <see href="http://w3id.org/CEON/ontology/energy/Biofuel"></see></summary>
    let Biofuel = _prefix "Biofuel"
    /// <summary>
    /// Biomass represents matter from recently living (but now dead) organisms such as plants, algae and animals.
    /// <see href="http://w3id.org/CEON/ontology/energy/Biomass"></see></summary>
    let Biomass = _prefix "Biomass"
    /// <summary>
    /// Biogas represents an energy source that is produced from raw materials such as agricultural waste, manure, municipal waste, plant material, sewage, green waste, wastewater, and food waste.
    /// <see href="http://w3id.org/CEON/ontology/energy/Biogas"></see></summary>
    let Biogas = _prefix "Biogas"
    /// <summary>
    /// An energy source is a resource or system that provides the energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergySource"></see></summary>
    let EnergySource = _prefix "EnergySource"
    /// <summary>
    /// Coal is a black or dark-brown combustible mineral substance consisting of carbonized vegetable matter.
    /// <see href="http://w3id.org/CEON/ontology/energy/Coal"></see></summary>
    let Coal = _prefix "Coal"
    /// <summary>
    /// A fossil fuel is a carbon compound- or hydrocarbon-containing material[2] formed naturally in the Earth's crust from the buried remains of prehistoric organisms (animals, plants or planktons), a process that occurs within geological formations.
    /// <see href="http://w3id.org/CEON/ontology/energy/FossilFuel"></see></summary>
    let FossilFuel = _prefix "FossilFuel"
    /// <summary>
    /// Energy is an ability or a property of matter or a system, to do work because of its motion, its mass, its electric charge, etc.
    /// <see href="http://w3id.org/CEON/ontology/energy/Energy"></see></summary>
    let Energy = _prefix "Energy"
    /// <summary>
    /// The relation representing the particpation of an energy as a resource.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergyComposition"></see></summary>
    let EnergyComposition = _prefix "EnergyComposition"
    /// <summary>
    /// Energy Conversion is a process of transforming energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergyConversion"></see></summary>
    let EnergyConversion = _prefix "EnergyConversion"
    /// <summary>
    /// The infrastructures participating in various energy-related processes, including energy production, transmission or distribution.
    /// <see href="http://w3id.org/CEON/ontology/energy/EnergyInfrastructure"></see></summary>
    let EnergyInfrastructure = _prefix "EnergyInfrastructure"
    /// <summary>
    /// Geothermal Energy Source is the Earth's crust. Geothermal energy is thermal energy extracted from the Earth's crust. It combines energy from the formation of the planet and from radioactive decay.
    /// <see href="http://w3id.org/CEON/ontology/energy/GeothermalEnergySource"></see></summary>
    let GeothermalEnergySource = _prefix "GeothermalEnergySource"
    /// <summary>
    /// Hydropower is the use of falling or fast-running water to produce electricity or to power machines.
    /// <see href="http://w3id.org/CEON/ontology/energy/Hydropower"></see></summary>
    let Hydropower = _prefix "Hydropower"
    /// <summary>
    /// Natural gas is a combustible gas that is naturally generated and stored under certain geological conditions by ancient animals and plants buried deep underground. It is a gaseous mixture of hydrocarbons and non-hydrocarbons, with methane as its main component.
    /// <see href="http://w3id.org/CEON/ontology/energy/NaturalGas"></see></summary>
    let NaturalGas = _prefix "NaturalGas"
    /// <summary>
    /// Nonrenewable energy represents energy that comes from such resources that cannot be replaced onew they are used up.
    /// <see href="http://w3id.org/CEON/ontology/energy/NonRenewableEnergy"></see></summary>
    let NonRenewableEnergy = _prefix "NonRenewableEnergy"
    /// <summary>
    /// Petroleum is a naturally occurring yellow-black liquid chemical mixture found in geological formations, consisting primarily of hydrocarbons.
    /// <see href="http://w3id.org/CEON/ontology/energy/Petroleum"></see></summary>
    let Petroleum = _prefix "Petroleum"
    /// <summary>
    /// Renewable energy represents energy that comes from renewable resources.
    /// <see href="http://w3id.org/CEON/ontology/energy/RenewableEnergy"></see></summary>
    let RenewableEnergy = _prefix "RenewableEnergy"
    /// <summary>
    /// Solar Energy Source is the Sun.
    /// <see href="http://w3id.org/CEON/ontology/energy/SolarEnergySource"></see></summary>
    let SolarEnergySource = _prefix "SolarEnergySource"
    /// <summary>
    /// Wind Energy Source is the Wind.
    /// <see href="http://w3id.org/CEON/ontology/energy/WindEnergySource"></see></summary>
    let WindEnergySource = _prefix "WindEnergySource"
    /// <summary>
    /// hasAnergy represents that energy has part of anergy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasAnergy"></see></summary>
    let hasAnergy = _prefix "hasAnergy"
    /// <summary>
    /// hasCarbonIntensity measures how intensive that the carbon is for an energy source.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasCarbonIntensity"></see></summary>
    let hasCarbonIntensity = _prefix "hasCarbonIntensity"
    /// <summary>
    /// hasConvertedEnergy represents that an energy transformation process has its final energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasConvertedEnergy"></see></summary>
    let hasConvertedEnergy = _prefix "hasConvertedEnergy"
    /// <summary>
    /// hasEnergyComponentPercentage represents the percentage of a particular energy as a composition.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasEnergyComponentPercentage"></see></summary>
    let hasEnergyComponentPercentage = _prefix "hasEnergyComponentPercentage"
    /// <summary>
    /// hasEnergySource represents that energy can have some energy sources.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasEnergySource"></see></summary>
    let hasEnergySource = _prefix "hasEnergySource"
    /// <summary>
    /// hasExergy represents that energy has part of exergy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasExergy"></see></summary>
    let hasExergy = _prefix "hasExergy"
    /// <summary>
    /// hasOriginalEnergy represents that an energy transformation process has its initial energy.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasOriginalEnergy"></see></summary>
    let hasOriginalEnergy = _prefix "hasOriginalEnergy"
    /// <summary>
    /// hasSustainability measures how sustainable an energy source is.
    /// <see href="http://w3id.org/CEON/ontology/energy/hasSustainability"></see></summary>
    let hasSustainability = _prefix "hasSustainability"
    /// <summary>
    /// participatingEnergy represents the energy in an energy composition.
    /// <see href="http://w3id.org/CEON/ontology/energy/participatingEnergy"></see></summary>
    let participatingEnergy = _prefix "participatingEnergy"
