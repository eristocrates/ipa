#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-energy`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/energy/" "ceon-energy"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Biofuel^^xsd:string</para>
    ///   <para>rdfs:label : Biofuel^^xsd:string</para>
    ///   <para>rdfs:comment : Biofuel is a fuel that is produced over a short time span from biomass.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Biofuel">ceon-energy:Biofuel</a>
    /// </summary>
    let Biofuel = _prefixId.prefix "Biofuel"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Biogas^^xsd:string</para>
    ///   <para>rdfs:label : Biogass^^xsd:string</para>
    ///   <para>rdfs:comment : Biogas represents an energy source that is produced from raw materials such as agricultural waste, manure, municipal waste, plant material, sewage, green waste, wastewater, and food waste.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Biogas">ceon-energy:Biogas</a>
    /// </summary>
    let Biogas = _prefixId.prefix "Biogas"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Biomass^^xsd:string</para>
    ///   <para>rdfs:label : Biomass^^xsd:string</para>
    ///   <para>rdfs:comment : Biomass represents matter from recently living (but now dead) organisms such as plants, algae and animals.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Biomass">ceon-energy:Biomass</a>
    /// </summary>
    let Biomass = _prefixId.prefix "Biomass"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Coal^^xsd:string</para>
    ///   <para>rdfs:label : Coal^^xsd:string</para>
    ///   <para>rdfs:comment : Coal is a black or dark-brown combustible mineral substance consisting of carbonized vegetable matter.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Coal">ceon-energy:Coal</a>
    /// </summary>
    let Coal = _prefixId.prefix "Coal"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://emmo.info/emmo#EMMO_31ec09ba_1713_42cb_83c7_b38bf6f9ced2^^xsd:string</para>
    ///   <para>rdfs:label : Energy^^xsd:string</para>
    ///   <para>rdfs:comment : Energy is an ability or a property of matter or a system, to do work because of its motion, its mass, its electric charge, etc.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Energy">ceon-energy:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : Energy Composition^^xsd:string</para>
    ///   <para>rdfs:comment : The relation representing the particpation of an energy as a resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/EnergyComposition">ceon-energy:EnergyComposition</a>
    /// </summary>
    let EnergyComposition = _prefixId.prefix "EnergyComposition"
    /// <summary>
    ///   <para>rdfs:label : Energy Conversion^^xsd:string</para>
    ///   <para>rdfs:comment : Energy Conversion is a process of transforming energy.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/EnergyConversion">ceon-energy:EnergyConversion</a>
    /// </summary>
    let EnergyConversion = _prefixId.prefix "EnergyConversion"
    /// <summary>
    ///   <para>rdfs:label : Energy Infrastructure^^xsd:string</para>
    ///   <para>rdfs:comment : The infrastructures participating in various energy-related processes, including energy production, transmission or distribution.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/EnergyInfrastructure">ceon-energy:EnergyInfrastructure</a>
    /// </summary>
    let EnergyInfrastructure = _prefixId.prefix "EnergyInfrastructure"
    /// <summary>
    ///   <para>rdfs:label : Energy Source^^xsd:string</para>
    ///   <para>rdfs:comment : An energy source is a resource or system that provides the energy.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/EnergySource">ceon-energy:EnergySource</a>
    /// </summary>
    let EnergySource = _prefixId.prefix "EnergySource"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Fossil_fuel^^xsd:string</para>
    ///   <para>rdfs:label : Fossil Fuel^^xsd:string</para>
    ///   <para>rdfs:comment : A fossil fuel is a carbon compound- or hydrocarbon-containing material[2] formed naturally in the Earth's crust from the buried remains of prehistoric organisms (animals, plants or planktons), a process that occurs within geological formations.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/FossilFuel">ceon-energy:FossilFuel</a>
    /// </summary>
    let FossilFuel = _prefixId.prefix "FossilFuel"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Geothermal_energy^^xsd:string</para>
    ///   <para>rdfs:label : Geothermal Energy Source^^xsd:string</para>
    ///   <para>rdfs:comment : Geothermal Energy Source is the Earth's crust. Geothermal energy is thermal energy extracted from the Earth's crust. It combines energy from the formation of the planet and from radioactive decay.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/GeothermalEnergySource">ceon-energy:GeothermalEnergySource</a>
    /// </summary>
    let GeothermalEnergySource = _prefixId.prefix "GeothermalEnergySource"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Hydropower^^xsd:string</para>
    ///   <para>rdfs:label : Hydropower^^xsd:string</para>
    ///   <para>rdfs:comment : Hydropower is the use of falling or fast-running water to produce electricity or to power machines.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Hydropower">ceon-energy:Hydropower</a>
    /// </summary>
    let Hydropower = _prefixId.prefix "Hydropower"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Natural_gas^^xsd:string</para>
    ///   <para>rdfs:label : Natural Gas^^xsd:string</para>
    ///   <para>rdfs:comment : Natural gas is a combustible gas that is naturally generated and stored under certain geological conditions by ancient animals and plants buried deep underground. It is a gaseous mixture of hydrocarbons and non-hydrocarbons, with methane as its main component.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/NaturalGas">ceon-energy:NaturalGas</a>
    /// </summary>
    let NaturalGas = _prefixId.prefix "NaturalGas"
    /// <summary>
    ///   <para>rdfs:label : NonReneable Energy^^xsd:string</para>
    ///   <para>rdfs:comment : Nonrenewable energy represents energy that comes from such resources that cannot be replaced onew they are used up.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/NonRenewableEnergy">ceon-energy:NonRenewableEnergy</a>
    /// </summary>
    let NonRenewableEnergy = _prefixId.prefix "NonRenewableEnergy"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Petroleum^^xsd:string</para>
    ///   <para>rdfs:label : Petroleum^^xsd:string</para>
    ///   <para>rdfs:comment : Petroleum is a naturally occurring yellow-black liquid chemical mixture found in geological formations, consisting primarily of hydrocarbons.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/Petroleum">ceon-energy:Petroleum</a>
    /// </summary>
    let Petroleum = _prefixId.prefix "Petroleum"
    /// <summary>
    ///   <para>rdfs:label : Renewable Energy^^xsd:string</para>
    ///   <para>rdfs:comment : Renewable energy represents energy that comes from renewable resources.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/RenewableEnergy">ceon-energy:RenewableEnergy</a>
    /// </summary>
    let RenewableEnergy = _prefixId.prefix "RenewableEnergy"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Solar_energy^^xsd:string</para>
    ///   <para>rdfs:label : Solar Energy Source^^xsd:string</para>
    ///   <para>rdfs:comment : Solar Energy Source is the Sun.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/SolarEnergySource">ceon-energy:SolarEnergySource</a>
    /// </summary>
    let SolarEnergySource = _prefixId.prefix "SolarEnergySource"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Wind_power^^xsd:string</para>
    ///   <para>rdfs:label : Wind Energy Source^^xsd:string</para>
    ///   <para>rdfs:comment : Wind Energy Source is the Wind.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/WindEnergySource">ceon-energy:WindEnergySource</a>
    /// </summary>
    let WindEnergySource = _prefixId.prefix "WindEnergySource"
    /// <summary>
    ///   <para>rdfs:label : has anergy^^xsd:string</para>
    ///   <para>rdfs:comment : hasAnergy represents that energy has part of anergy.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasAnergy">ceon-energy:hasAnergy</a>
    /// </summary>
    let hasAnergy = _prefixId.prefix "hasAnergy"
    /// <summary>
    ///   <para>rdfs:label : has carbon intensity^^xsd:string</para>
    ///   <para>rdfs:comment : hasCarbonIntensity measures how intensive that the carbon is for an energy source.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasCarbonIntensity">ceon-energy:hasCarbonIntensity</a>
    /// </summary>
    let hasCarbonIntensity = _prefixId.prefix "hasCarbonIntensity"
    /// <summary>
    ///   <para>rdfs:label : has converted energy^^xsd:string</para>
    ///   <para>rdfs:comment : hasConvertedEnergy represents that an energy transformation process has its final energy.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasConvertedEnergy">ceon-energy:hasConvertedEnergy</a>
    /// </summary>
    let hasConvertedEnergy = _prefixId.prefix "hasConvertedEnergy"
    /// <summary>
    ///   <para>rdfs:label : has energy component percentage^^xsd:string</para>
    ///   <para>rdfs:comment : hasEnergyComponentPercentage represents the percentage of a particular energy as a composition.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasEnergyComponentPercentage">ceon-energy:hasEnergyComponentPercentage</a>
    /// </summary>
    let hasEnergyComponentPercentage = _prefixId.prefix "hasEnergyComponentPercentage"
    /// <summary>
    ///   <para>rdfs:label : has energy source^^xsd:string</para>
    ///   <para>rdfs:comment : hasEnergySource represents that energy can have some energy sources.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasEnergySource">ceon-energy:hasEnergySource</a>
    /// </summary>
    let hasEnergySource = _prefixId.prefix "hasEnergySource"
    /// <summary>
    ///   <para>rdfs:label : has exergy^^xsd:string</para>
    ///   <para>rdfs:comment : hasExergy represents that energy has part of exergy.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasExergy">ceon-energy:hasExergy</a>
    /// </summary>
    let hasExergy = _prefixId.prefix "hasExergy"
    /// <summary>
    ///   <para>rdfs:label : has original energy^^xsd:string</para>
    ///   <para>rdfs:comment : hasOriginalEnergy represents that an energy transformation process has its initial energy.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasOriginalEnergy">ceon-energy:hasOriginalEnergy</a>
    /// </summary>
    let hasOriginalEnergy = _prefixId.prefix "hasOriginalEnergy"
    /// <summary>
    ///   <para>rdfs:label : has sustainability^^xsd:string</para>
    ///   <para>rdfs:comment : hasSustainability measures how sustainable an energy source is.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/hasSustainability">ceon-energy:hasSustainability</a>
    /// </summary>
    let hasSustainability = _prefixId.prefix "hasSustainability"
    /// <summary>
    ///   <para>rdfs:label : participating energy^^xsd:string</para>
    ///   <para>rdfs:comment : participatingEnergy represents the energy in an energy composition.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/energy/participatingEnergy">ceon-energy:participatingEnergy</a>
    /// </summary>
    let participatingEnergy = _prefixId.prefix "participatingEnergy"
