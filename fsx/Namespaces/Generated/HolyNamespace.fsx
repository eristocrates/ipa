#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module holy =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/holy/ns#" "holy"
    let _namespaceIri = _prefixId.prefix ""
    let A12FuelCell = _prefixId.prefix "A12FuelCell"
    let A13FuelCell = _prefixId.prefix "A13FuelCell"
    let A18FuelCell = _prefixId.prefix "A18FuelCell"
    let A330FuelCell = _prefixId.prefix "A330FuelCell"
    let Afghanistan = _prefixId.prefix "Afghanistan"
    let Africa = _prefixId.prefix "Africa"
    /// <summary>
    ///   <para>skos:definition : A pressure regulating system for enhancing fuel cell improvement by increasing pressure of reactant gases.</para>
    ///   <para>skos:altLabel : Air Compressor</para>
    ///   <para>rdfs:label : Air Compressor</para>
    ///   <a href="http://purl.org/holy/ns#AirCompressor">holy:AirCompressor</a>
    /// </summary>
    let AirCompressor = _prefixId.prefix "AirCompressor"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Unmanned Aerial Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Short Takeoff and Landing Aircrafthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Passenger Planehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Unmanned Long-duration Aircrafthttps://wordnet-rdf.princeton.edu/ontology#hyponym : long-haul aircrafthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Long-duration aircrafthttps://wordnet-rdf.princeton.edu/ontology#hyponym : STOLhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Cargo Planehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Helicopterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Dronehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Long-endurance aircrafthttps://wordnet-rdf.princeton.edu/ontology#hyponym : UAVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Airplanehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Aeroplanehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Zero-emission Aircraft</para>
    ///   <para>rdfs:label : Aircraft</para>
    ///   <para>skos:definition : A vehicle which can fly and carry goods or passengers. It has fixed wings and is powered by propellers or jets.</para>
    ///   <para>skos:example : A321neo</para>
    ///   <para>skos:hiddenLabel : Plane</para>
    ///   <para>skos:altLabel : Aircraft</para>
    ///   <a href="http://purl.org/holy/ns#Aircraft">holy:Aircraft</a>
    /// </summary>
    let Aircraft = _prefixId.prefix "Aircraft"
    let Albania = _prefixId.prefix "Albania"
    let Algeria = _prefixId.prefix "Algeria"
    /// <summary>
    ///   <para>skos:definition : A battery which uses a chemical substance composed of zinc (Zn) and manganese dioxide (MnO2). The separator in alkaline batteries is made totally or at least partially of nonwoven materials.^^xsd:string</para>
    ///   <para>skos:altLabel : Alkaline Battery</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00854-6</para>
    ///   <para>rdfs:label : Alkaline Battery</para>
    ///   <a href="http://purl.org/holy/ns#AlkalineBattery">holy:AlkalineBattery</a>
    /// </summary>
    let AlkalineBattery = _prefixId.prefix "AlkalineBattery"
    /// <summary>
    ///   <para>skos:definition : A fuel cell which uses potassium hydroxide in water as the electrolyte for powering, using a variety of non-precious metals as a catalyst at the anode and cathode.</para>
    ///   <para>skos:altLabel : AMFCskos:altLabel : Alkaline Electrolyzerskos:altLabel : Alkaline Fuel CEllskos:altLabel : Alkaline Membrane Fuel Cells</para>
    ///   <para>rdfs:label : Alkaline Fuel Cell</para>
    ///   <a href="http://purl.org/holy/ns#AlkalineFuelCell">holy:AlkalineFuelCell</a>
    /// </summary>
    let AlkalineFuelCell = _prefixId.prefix "AlkalineFuelCell"
    let Ambazonia = _prefixId.prefix "Ambazonia"
    /// <summary>
    ///   <para>skos:definition : A fuel cell using ammonia as its fuel.</para>
    ///   <para>skos:altLabel : Ammonia Fuel Cellskos:altLabel : DAFCskos:altLabel : Direct Ammonia Fuel Cell</para>
    ///   <para>rdfs:label : Ammonia Fuel Cell</para>
    ///   <a href="http://purl.org/holy/ns#AmmoniaFuelCell">holy:AmmoniaFuelCell</a>
    /// </summary>
    let AmmoniaFuelCell = _prefixId.prefix "AmmoniaFuelCell"
    let Andorra = _prefixId.prefix "Andorra"
    let Angola = _prefixId.prefix "Angola"
    /// <summary>
    ///   <para>skos:definition : A PEMFC-like fuel cell technology which needs less precious metals as catalysts in order to trigger chemical reaction.</para>
    ///   <para>skos:altLabel : AEMskos:altLabel : AEMFCskos:altLabel : Anion Exchange Membrane Fuel Cellskos:altLabel : Anion exchange membrane</para>
    ///   <para>rdfs:label : Anion Exchange Membrane Fuel Cell</para>
    ///   <a href="http://purl.org/holy/ns#AnionExchangeMembraneFuelCell">holy:AnionExchangeMembraneFuelCell</a>
    /// </summary>
    let AnionExchangeMembraneFuelCell = _prefixId.prefix "AnionExchangeMembraneFuelCell"
    let Antigua_and_Barbuda = _prefixId.prefix "Antigua_and_Barbuda"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Industry Applications of Hydrogen Fuel Cellshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Practical Applicationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Applicationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Technology Industry Applicationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Energy Industry Application</para>
    ///   <para>rdfs:label : Application</para>
    ///   <para>skos:altLabel : Use Caseskos:altLabel : Applicationskos:altLabel : Usanceskos:altLabel : Utilization</para>
    ///   <para>skos:definition : The intended end use of a hydrogen-based product or of the result of a hydrogen-related project.</para>
    ///   <para>skos:hiddenLabel : End Use</para>
    ///   <a href="http://purl.org/holy/ns#Application">holy:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    let Argentina = _prefixId.prefix "Argentina"
    let Armenia = _prefixId.prefix "Armenia"
    let Asia = _prefixId.prefix "Asia"
    let Australia = _prefixId.prefix "Australia"
    let Austria = _prefixId.prefix "Austria"
    let AutomatedGuidedVehicle = _prefixId.prefix "AutomatedGuidedVehicle"
    /// <summary>
    ///   <para>skos:altLabel : Aviationskos:altLabel : Airmanshipskos:altLabel : Air Travelskos:altLabel : Aeronautics</para>
    ///   <para>rdfs:label : Aviatic Application</para>
    ///   <para>skos:definition : An application related to the transport of people and/or goods by any form of aircraft or spacecraft.</para>
    ///   <para>skos:hiddenLabel : Air Power</para>
    ///   <a href="http://purl.org/holy/ns#AviaticApplication">holy:AviaticApplication</a>
    /// </summary>
    let AviaticApplication = _prefixId.prefix "AviaticApplication"
    let Azerbaijan = _prefixId.prefix "Azerbaijan"
    let Bahrain = _prefixId.prefix "Bahrain"
    let Bangladesh = _prefixId.prefix "Bangladesh"
    let Barbados = _prefixId.prefix "Barbados"
    /// <summary>
    ///   <para>skos:hiddenLabel : Hybrid Membrane</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Redox Flow Batterieshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Wallhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Cellhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Lead Acid Batteryhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Perfluorinated Sulfonic Acid batteryhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Thermal Management Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Vanadium Redox Flow Batteryhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Car Batteryhttps://wordnet-rdf.princeton.edu/ontology#hyponym : BTMShttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Batteryhttps://wordnet-rdf.princeton.edu/ontology#hyponym : BESShttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fully Electric Barge Battery Containerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Energy Storage Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Barge Battery Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hybrid Membrane Edges Flow Batteries</para>
    ///   <para>skos:altLabel : Battery</para>
    ///   <para>rdfs:label : Battery</para>
    ///   <para>skos:definition : A collection of one or more cells which store electrical energy for powering electrical devices.</para>
    ///   <a href="http://purl.org/holy/ns#Battery">holy:Battery</a>
    /// </summary>
    let Battery = _prefixId.prefix "Battery"
    /// <summary>
    ///   <para>skos:definition : A basic component for batteries.</para>
    ///   <para>rdfs:label : Battery Component</para>
    ///   <para>rdfs:comment : The subclass "Battery Component" can be expanded to focus on batteries as substitutes for hydrogen products. </para>
    ///   <a href="http://purl.org/holy/ns#BatteryComponent">holy:BatteryComponent</a>
    /// </summary>
    let BatteryComponent = _prefixId.prefix "BatteryComponent"
    let Belarus = _prefixId.prefix "Belarus"
    let Belgium = _prefixId.prefix "Belgium"
    let Belize = _prefixId.prefix "Belize"
    let Benin = _prefixId.prefix "Benin"
    let Bhutan = _prefixId.prefix "Bhutan"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Bikehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Mopedhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Mopedhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Motorbikehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Scooterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-powered E-bikehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Bicyclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Motorcyclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Bicyclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Road Bikehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-powered Bikehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Scooterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Race Bike</para>
    ///   <para>skos:hiddenLabel : Cycling</para>
    ///   <para>skos:altLabel : Bike</para>
    ///   <para>skos:definition : A motorbike, motorcycle or scooter.</para>
    ///   <para>skos:example : Honda Grazia Repsol Honda Team Edition</para>
    ///   <para>rdfs:label : Bike</para>
    ///   <a href="http://purl.org/holy/ns#Bike">holy:Bike</a>
    /// </summary>
    let Bike = _prefixId.prefix "Bike"
    /// <summary>
    ///   <para>skos:definition : A plate which provides electrical conduction between cells. Bipolar plates are used to separate cells within a fuel cell from each other and aim to provide physical strength to the stack of cells.</para>
    ///   <para>skos:altLabel : Bipolar Plate</para>
    ///   <para>rdfs:label : Bipolar Plate</para>
    ///   <a href="http://purl.org/holy/ns#BipolarPlate">holy:BipolarPlate</a>
    /// </summary>
    let BipolarPlate = _prefixId.prefix "BipolarPlate"
    let Bolivia = _prefixId.prefix "Bolivia"
    let Bosnia_and_Herzegovina = _prefixId.prefix "Bosnia_and_Herzegovina"
    let Botswana = _prefixId.prefix "Botswana"
    let Brazil = _prefixId.prefix "Brazil"
    let Brunei = _prefixId.prefix "Brunei"
    let Bulgaria = _prefixId.prefix "Bulgaria"
    let Burkina_Faso = _prefixId.prefix "Burkina_Faso"
    let Burundi = _prefixId.prefix "Burundi"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Zero-emission Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : City Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Transit Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Electric Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Municipal Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Minibushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Double-deckerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : PEM Fuel Cell Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : School Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-powered Bushttps://wordnet-rdf.princeton.edu/ontology#hyponym : Trolleybus</para>
    ///   <para>skos:altLabel : Bus</para>
    ///   <para>rdfs:label : Bus</para>
    ///   <para>skos:definition : A large motorzed vehicle with seats for many people.</para>
    ///   <para>skos:example : Xcelsior CHARGE</para>
    ///   <a href="http://purl.org/holy/ns#Bus">holy:Bus</a>
    /// </summary>
    let Bus = _prefixId.prefix "Bus"
    let CUTE = _prefixId.prefix "CUTE"
    let Cambodia = _prefixId.prefix "Cambodia"
    let Cameroon = _prefixId.prefix "Cameroon"
    let Canada = _prefixId.prefix "Canada"
    let Cape_Verde = _prefixId.prefix "Cape_Verde"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Jeephttps://wordnet-rdf.princeton.edu/ontology#hyponym : Coupéhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Coupehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric passenger vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Passenger Carhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hybrid Range Extenderhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Station Wagonhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric SUVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Convertiblehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen SUVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hybrid Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Limousinehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Passenger Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : SUV</para>
    ///   <para>rdfs:label : Car</para>
    ///   <para>skos:example : Toyota Corollaskos:example : Toyota Miraiskos:example : Toyota Yaris</para>
    ///   <para>skos:altLabel : Autoskos:altLabel : Automobileskos:altLabel : Car</para>
    ///   <para>skos:definition : A road vehicle with an engine, four wheels, and seats for a small number of people.</para>
    ///   <a href="http://purl.org/holy/ns#Car">holy:Car</a>
    /// </summary>
    let Car = _prefixId.prefix "Car"
    /// <summary>
    ///   <para>skos:altLabel : Cargo Vesselskos:altLabel : Transport Shipskos:altLabel : Canal Boat</para>
    ///   <para>skos:example : Voilier Ceibaskos:example : Ceiba Ship</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Zero-emission Cargo Shiphttps://wordnet-rdf.princeton.edu/ontology#hyponym : Freighterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Supertankerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Freight Shiphttps://wordnet-rdf.princeton.edu/ontology#hyponym : Container Shiphttps://wordnet-rdf.princeton.edu/ontology#hyponym : Freight Vesselhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Oil Tanker</para>
    ///   <para>rdfs:label : Cargo Ship</para>
    ///   <para>skos:definition : Any kind of a ship or any other vessel that transports heavy goods and materials from one port to another.</para>
    ///   <a href="http://purl.org/holy/ns#CargoShip">holy:CargoShip</a>
    /// </summary>
    let CargoShip = _prefixId.prefix "CargoShip"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Container Trainhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Intermodal Train</para>
    ///   <para>skos:altLabel : Cargo Trainskos:altLabel : Goods Trainskos:altLabel : Freight Trainskos:altLabel : Haulage Train</para>
    ///   <para>skos:hiddenLabel : Nonpassenger Train</para>
    ///   <para>skos:definition : A train carrying mainly goods such as baggage, shipment or merchandise.</para>
    ///   <para>rdfs:label : Cargo Train</para>
    ///   <a href="http://purl.org/holy/ns#CargoTrain">holy:CargoTrain</a>
    /// </summary>
    let CargoTrain = _prefixId.prefix "CargoTrain"
    /// <summary>
    ///   <para>skos:definition : A layer of anodes and cathodes which are placed on opposite sites of the membrane. It is a three-dimensional porous structrure composed of catalyst particles and ionomer fragments.</para>
    ///   <para>skos:altLabel : Catalyst Layer</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00227-6^^xsd:string</para>
    ///   <para>rdfs:label : Catalyst Layer</para>
    ///   <a href="http://purl.org/holy/ns#CatalystLayer">holy:CatalystLayer</a>
    /// </summary>
    let CatalystLayer = _prefixId.prefix "CatalystLayer"
    let Central_African_Republic = _prefixId.prefix "Central_African_Republic"
    let Ceres_Power_Holding = _prefixId.prefix "Ceres_Power_Holding"
    let Chad = _prefixId.prefix "Chad"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Ammonia Processinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Methanol Production</para>
    ///   <para>skos:definition : An application of hydrogen in the chemical industry creating chemical products for numerous sectors such as pharmaceutical, agricultural or consumer goods usage.</para>
    ///   <para>skos:altLabel : Chemical Processing</para>
    ///   <para>rdfs:label : Chemical Industrial Processing</para>
    ///   <para>rdfs:comment : Hydrogen is one of the key starting materials used in the chemical industry. It is a fundamental building block for the manufacturing of ammonia, fertilizers, and  methanol, which is used in the manufacture of many polymers.</para>
    ///   <a href="http://purl.org/holy/ns#ChemicalIndustrialProcessing">holy:ChemicalIndustrialProcessing</a>
    /// </summary>
    let ChemicalIndustrialProcessing = _prefixId.prefix "ChemicalIndustrialProcessing"
    let Chile = _prefixId.prefix "Chile"
    let China = _prefixId.prefix "China"
    /// <summary>
    ///   <para>skos:hiddenLabel : Smart Farm Linked Hydrogen Fuel Cell Power Generation Projectskos:hiddenLabel : Ecodesign projectskos:hiddenLabel : Life Cycle Management Project</para>
    ///   <para>rdfs:label : Circular Economy Project</para>
    ///   <para>skos:altLabel : Circular Economy Project</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Industrial Symbiosis Project</para>
    ///   <para>skos:definition : A project focusing on a circular system of reusing resources which were previously used for something.</para>
    ///   <a href="http://purl.org/holy/ns#CircularEconomyProject">holy:CircularEconomyProject</a>
    /// </summary>
    let CircularEconomyProject = _prefixId.prefix "CircularEconomyProject"
    let Colombia = _prefixId.prefix "Colombia"
    let Comoros = _prefixId.prefix "Comoros"
    let Cook_Islands = _prefixId.prefix "Cook_Islands"
    let Costa_Rica = _prefixId.prefix "Costa_Rica"
    let Croatia = _prefixId.prefix "Croatia"
    /// <summary>
    ///   <para>skos:hiddenLabel : Liner</para>
    ///   <para>skos:definition : A large ship like a hotel which people use for travel and pleasure.</para>
    ///   <para>skos:altLabel : Cruise Linerskos:altLabel : Passenger Ship</para>
    ///   <para>rdfs:label : Cruise Ship</para>
    ///   <a href="http://purl.org/holy/ns#CruiseShip">holy:CruiseShip</a>
    /// </summary>
    let CruiseShip = _prefixId.prefix "CruiseShip"
    let CryogenicPistonPump = _prefixId.prefix "CryogenicPistonPump"
    let Cuba = _prefixId.prefix "Cuba"
    let Cyprus = _prefixId.prefix "Cyprus"
    let Czech_Republic = _prefixId.prefix "Czech_Republic"

    let Democratic_Republic_of_the_Congo = _prefixId.prefix "Democratic_Republic_of_the_Congo"

    let Denmark = _prefixId.prefix "Denmark"
    let Djibouti = _prefixId.prefix "Djibouti"
    let Dominica = _prefixId.prefix "Dominica"
    let Dominican_Republic = _prefixId.prefix "Dominican_Republic"
    let ECTOS = _prefixId.prefix "ECTOS"
    let East_Timor = _prefixId.prefix "East_Timor"
    let Ecuador = _prefixId.prefix "Ecuador"
    let Egypt = _prefixId.prefix "Egypt"
    let El_Salvador = _prefixId.prefix "El_Salvador"
    /// <summary>
    ///   <para>skos:hiddenLabel : Renewable Fuel Producer</para>
    ///   <para>skos:definition : An organization who participates in the activity of providing electric power, natural gas, steam, hot water and the like through a permanent infrastructure (network) of lines, mains and pipes. The dimension of the network is not decisive; also included is the distribution of electricity, gas, steam, hot water and the like in industrial parks or residential buildings according to Section D of EC NACE Rev. 2.</para>
    ///   <para>skos:altLabel : Energy Sector</para>
    ///   <para>rdfs:label : Energy Sector Organization</para>
    ///   <a href="http://purl.org/holy/ns#EnergySectorOrganization">holy:EnergySectorOrganization</a>
    /// </summary>
    let EnergySectorOrganization = _prefixId.prefix "EnergySectorOrganization"
    /// <summary>
    ///   <para>skos:hiddenLabel : ESGskos:hiddenLabel : Governmental Roadblockskos:hiddenLabel : Environmental, Social and Corporate Governance</para>
    ///   <para>skos:definition : An obstacle individuals face when participating in a particular market.</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Regulationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Political Constrainthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Market Permit</para>
    ///   <para>rdfs:label : Entry Barrier</para>
    ///   <a href="http://purl.org/holy/ns#EntryBarrier">holy:EntryBarrier</a>
    /// </summary>
    let EntryBarrier = _prefixId.prefix "EntryBarrier"
    let Equatorial_Guinea = _prefixId.prefix "Equatorial_Guinea"
    let Eritrea = _prefixId.prefix "Eritrea"
    let Estonia = _prefixId.prefix "Estonia"
    let Eswatini = _prefixId.prefix "Eswatini"
    /// <summary>
    ///   <para>skos:hiddenLabel : Ethanol Powered Engines</para>
    ///   <para>rdfs:label : Ethanol Fuel Cell</para>
    ///   <para>skos:altLabel : Ethanol Fuel Cellskos:altLabel : DEFCskos:altLabel : Direct Ethanol Fuel Cell</para>
    ///   <para>skos:definition : A fuel cell using ethanol as its fuel.</para>
    ///   <a href="http://purl.org/holy/ns#EthanolFuelCell">holy:EthanolFuelCell</a>
    /// </summary>
    let EthanolFuelCell = _prefixId.prefix "EthanolFuelCell"
    let Ethiopia = _prefixId.prefix "Ethiopia"
    let Europe = _prefixId.prefix "Europe"
    let EuropeanCleanHydrogenAlliance = _prefixId.prefix "EuropeanCleanHydrogenAlliance"
    let European_microstates = _prefixId.prefix "European_microstates"
    let Exqui'_period_'City18FuelCell = _prefixId.prefix "Exqui.City18FuelCell"
    let Exqui'_period_'City24FuelCell = _prefixId.prefix "Exqui.City24FuelCell"

    let Federated_States_of_Micronesia = _prefixId.prefix "Federated_States_of_Micronesia"

    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Car-ferry</para>
    ///   <para>skos:definition : A boat or ship for taking passengers and often vehicles across an area of water, especially as a regular service.</para>
    ///   <para>skos:altLabel : Car Ferryskos:altLabel : Ferryboat</para>
    ///   <para>rdfs:label : Ferry</para>
    ///   <a href="http://purl.org/holy/ns#Ferry">holy:Ferry</a>
    /// </summary>
    let Ferry = _prefixId.prefix "Ferry"
    let Fiji = _prefixId.prefix "Fiji"
    /// <summary>
    ///   <para>skos:hiddenLabel : Have Been Completedskos:hiddenLabel : Project Was Deemed Succesfulskos:hiddenLabel : Was a Project</para>
    ///   <para>skos:definition : A project which has completed its intended purpose regardless of the level of success.</para>
    ///   <para>skos:altLabel : Completed Project</para>
    ///   <para>rdfs:label : Finished Project</para>
    ///   <a href="http://purl.org/holy/ns#FinishedProject">holy:FinishedProject</a>
    /// </summary>
    let FinishedProject = _prefixId.prefix "FinishedProject"
    let Finland = _prefixId.prefix "Finland"
    let Flags_of_Africa = _prefixId.prefix "Flags_of_Africa"
    /// <summary>
    ///   <para>skos:hiddenLabel : Combustion Engineskos:hiddenLabel : Fossil Fuel Tankskos:hiddenLabel : Gasoline Engine</para>
    ///   <para>skos:definition : A conventional energy production method using fossil fuels as fuel.</para>
    ///   <para>skos:altLabel : Fossil Fuel</para>
    ///   <para>rdfs:label : Fossil Fuel</para>
    ///   <para>rdfs:comment : The subclass "FossilFuel" could be expanded to focus the domain scope to the creation of hydrogen concerning the value chain.</para>
    ///   <a href="http://purl.org/holy/ns#FossilFuel">holy:FossilFuel</a>
    /// </summary>
    let FossilFuel = _prefixId.prefix "FossilFuel"
    /// <summary>
    ///   <para>skos:definition : A basic component for products using fossil fuels.</para>
    ///   <para>rdfs:label : Fossil Fuel Component</para>
    ///   <para>rdfs:comment : The subclass "Fossil Fuel Component" could be expanded to focus on the components of fossil fuel products classifying as substitutes for hydrogen products.</para>
    ///   <a href="http://purl.org/holy/ns#FossilFuelComponent">holy:FossilFuelComponent</a>
    /// </summary>
    let FossilFuelComponent = _prefixId.prefix "FossilFuelComponent"
    let France = _prefixId.prefix "France"
    /// <summary>
    ///   <para>skos:definition : The heart of a fuel cell responsible for energy generation.</para>
    ///   <para>skos:altLabel : Fuel Cell Stack</para>
    ///   <para>rdfs:label : Fuel Cell Stack</para>
    ///   <a href="http://purl.org/holy/ns#FuelCellStack">holy:FuelCellStack</a>
    /// </summary>
    let FuelCellStack = _prefixId.prefix "FuelCellStack"
    /// <summary>
    ///   <para>skos:definition : A converter which is necessary to convert fuel into a fuel cell-usable form.</para>
    ///   <para>skos:altLabel : Fuel Processor</para>
    ///   <para>rdfs:label : Fuel Processor</para>
    ///   <a href="http://purl.org/holy/ns#FuelProcessor">holy:FuelProcessor</a>
    /// </summary>
    let FuelProcessor = _prefixId.prefix "FuelProcessor"
    let Gabon = _prefixId.prefix "Gabon"
    /// <summary>
    ///   <para>skos:definition : A paper-like layer placed outside the catalyst layer which is responsible for transporting reactants into the catalyst layer by removing chemical reaction outcomes.  In most cases, the Gas Diffusion Layer consists of a bilayer structure consisting of a macroporous diffusion medium and microporous layer.</para>
    ///   <para>skos:altLabel : GDLskos:altLabel : Gas Diffusion Layer</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00227-6^^xsd:string</para>
    ///   <para>rdfs:label : Gas Diffusion Layer</para>
    ///   <a href="http://purl.org/holy/ns#GasDiffusionLayer">holy:GasDiffusionLayer</a>
    /// </summary>
    let GasDiffusionLayer = _prefixId.prefix "GasDiffusionLayer"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Low Temperature Fuel Cell Gaskethttps://wordnet-rdf.princeton.edu/ontology#hyponym : PTFE-based Gaskethttps://wordnet-rdf.princeton.edu/ontology#hyponym : EPDM-based gaskethttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Caphttps://wordnet-rdf.princeton.edu/ontology#hyponym : Sealing Gaskethttps://wordnet-rdf.princeton.edu/ontology#hyponym : EPDM gaskethttps://wordnet-rdf.princeton.edu/ontology#hyponym : PTFE-coated Basket</para>
    ///   <para>skos:definition : A part used for gas-tight sealing of the edges of the Membrane Electrode Assembly (MEA).</para>
    ///   <para>rdfs:label : Gasket</para>
    ///   <para>skos:altLabel : Gasket</para>
    ///   <a href="http://purl.org/holy/ns#Gasket">holy:Gasket</a>
    /// </summary>
    let Gasket = _prefixId.prefix "Gasket"
    let GenSureFuelCellSystem = _prefixId.prefix "GenSureFuelCellSystem"
    /// <summary>
    ///   <para>skos:hiddenLabel : Earthskos:hiddenLabel : World</para>
    ///   <para>rdfs:label : Geographic Market</para>
    ///   <para>skos:altLabel : Geographic Market</para>
    ///   <para>skos:definition : An area of land which can be classified for business or trade concerning a particular product or domain.</para>
    ///   <a href="http://purl.org/holy/ns#GeographicMarket">holy:GeographicMarket</a>
    /// </summary>
    let GeographicMarket = _prefixId.prefix "GeographicMarket"
    let ``Georgia_(country)`` = _prefixId.prefix "Georgia_(country)"
    let Germany = _prefixId.prefix "Germany"
    let Ghana = _prefixId.prefix "Ghana"
    let Greece = _prefixId.prefix "Greece"
    let Grenada = _prefixId.prefix "Grenada"
    let Guatemala = _prefixId.prefix "Guatemala"
    let Guinea = _prefixId.prefix "Guinea"
    let Guinea_Bissau = _prefixId.prefix "Guinea-Bissau"
    let Guyana = _prefixId.prefix "Guyana"
    let Haiti = _prefixId.prefix "Haiti"
    /// <summary>
    ///   <para>skos:definition : An application which generates heat for contributing to the heating of buildings or for use in industrial processes.</para>
    ///   <para>skos:hiddenLabel : Meltingskos:hiddenLabel : Boilerskos:hiddenLabel : Heatskos:hiddenLabel : Heating Plant</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Heating Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Heating System</para>
    ///   <para>rdfs:label : Heating</para>
    ///   <para>skos:altLabel : Heating Applicationskos:altLabel : Heat Up</para>
    ///   <a href="http://purl.org/holy/ns#Heating">holy:Heating</a>
    /// </summary>
    let Heating = _prefixId.prefix "Heating"
    let Honduras = _prefixId.prefix "Honduras"
    /// <summary>
    ///   <para>skos:definition : An item which regulates a certain level of humidity within a fuel cell.</para>
    ///   <para>skos:altLabel : Humidifier</para>
    ///   <para>rdfs:label : Humidifier</para>
    ///   <a href="http://purl.org/holy/ns#Humidifier">holy:Humidifier</a>
    /// </summary>
    let Humidifier = _prefixId.prefix "Humidifier"
    let Hungary = _prefixId.prefix "Hungary"
    let Hydroflex = _prefixId.prefix "Hydroflex"
    /// <summary>
    ///   <para>skos:hiddenLabel : Hydrogen-based Fuelskos:hiddenLabel : Low Carbon Transport Fuelskos:hiddenLabel : PEMWEskos:hiddenLabel : Electrolytic Processingskos:hiddenLabel : Green Hydrogenskos:hiddenLabel : Electrolytic Productionskos:hiddenLabel : Grey Hydrogenskos:hiddenLabel : Blue Hydrogen</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Renewable Hydrogen Productionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : PEM water electrolysershttps://wordnet-rdf.princeton.edu/ontology#hyponym : Thermochemical Hydrogen Productionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Direct Solar Water Splitting Processeshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electrolysishttps://wordnet-rdf.princeton.edu/ontology#hyponym : Thermochemical Hydrogen Processesinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Biological Hydrogen Productionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Biological Hydrogen Processes</para>
    ///   <para>skos:definition : The processing of materials into hydrogen.</para>
    ///   <para>rdfs:comment : The subclass "Conversion" can be expanded to focus the domain scope to the creation of hydrogen with respect to the value chain. </para>
    ///   <para>rdfs:label : Hydrogen Conversion</para>
    ///   <para>skos:altLabel : Hydrogen Conversion</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenConversion">holy:HydrogenConversion</a>
    /// </summary>
    let HydrogenConversion = _prefixId.prefix "HydrogenConversion"
    /// <summary>
    ///   <para>skos:definition : A basic component for products which convert compounds to hydrogen.</para>
    ///   <para>rdfs:label : Hydrogen Conversion Component</para>
    ///   <para>rdfs:comment : The subclass "Hydrogen Conversion Component" could be expanded to focus the domain scope to the transport of hydrogen with respect to the value chain.</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenConversionComponent">holy:HydrogenConversionComponent</a>
    /// </summary>
    let HydrogenConversionComponent = _prefixId.prefix "HydrogenConversionComponent"
    /// <summary>
    ///   <para>skos:definition : A basic component of hydrogen fuel cell systems.</para>
    ///   <para>rdfs:label : Hydrogen Fuel Cell Component</para>
    ///   <para>rdfs:comment : Fuel Cell Component is directly alligned with sub-classes of 'Reconversion'.</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenFuelCellComponent">holy:HydrogenFuelCellComponent</a>
    /// </summary>
    let HydrogenFuelCellComponent = _prefixId.prefix "HydrogenFuelCellComponent"
    /// <summary>
    ///   <para>skos:hiddenLabel : Hydrogen Techskos:hiddenLabel : Hydrogen Technology</para>
    ///   <para>skos:definition : A product that is manufactured or refined for sale which can be used to produce, transport, store or "burn"/reconvert hydrogen.</para>
    ///   <para>skos:altLabel : Hydrogen Product</para>
    ///   <para>rdfs:label : Hydrogen Product</para>
    ///   <para>rdfs:comment : Concerning the scope of focusing on fuel cells and more precisely on PEMFCs, the sub-class reconversion will be the most focused class. Transportation, Storage and Conversion subclasses would receive greater attention when shifting the ontology to other areas of the hydrogen value chain.</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenProduct">holy:HydrogenProduct</a>
    /// </summary>
    let HydrogenProduct = _prefixId.prefix "HydrogenProduct"
    /// <summary>
    ///   <para>skos:definition : A part that, combined with other parts, makes up a hydrogen product.</para>
    ///   <para>rdfs:label : Hydrogen Product Component</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenProductComponent">holy:HydrogenProductComponent</a>
    /// </summary>
    let HydrogenProductComponent = _prefixId.prefix "HydrogenProductComponent"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Enginehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cellhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Oxygen Fuel Cellhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Engine Technologyhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Producthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Electrichttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Power Modulehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-powered Fuel Cellhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-fueled Gas Turbineshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen and Fuel Cell System</para>
    ///   <para>skos:altLabel : Reconversion</para>
    ///   <para>skos:hiddenLabel : Fuel Cell</para>
    ///   <para>skos:example : GR Yaris engine</para>
    ///   <para>rdfs:seeAlso : Fuel Cell Solution</para>
    ///   <para>skos:definition : The knowledge which deals with converting hydrogen to other elements. In case of hydrogen fuel cells, hydrogen is reconverted to H2O.</para>
    ///   <para>rdfs:comment : Since reconversion solely happenes for energy creation using fuel cells, "Reconversion" is contributed to fuel cell systems.</para>
    ///   <para>rdfs:label : Hydrogen Reconversion</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenReconversion">holy:HydrogenReconversion</a>
    /// </summary>
    let HydrogenReconversion = _prefixId.prefix "HydrogenReconversion"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : High-pressure Gas Cylindershttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Tankhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Cryogenic Tankshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Storage Tankshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Liquid Hydrogen Storage Tank</para>
    ///   <para>rdfs:comment : The subclass "Storage" could be expanded to focus the domain scope to the creation of hydrogen with respect to the value chain. Future expansions could categorize between storage technologies within tanks or using absorbing materials.</para>
    ///   <para>skos:hiddenLabel : Hydrogen Absorbation in Metalskos:hiddenLabel : Fuel Tank</para>
    ///   <para>skos:definition : The way that hydrogen can be stored for later usage.</para>
    ///   <para>rdfs:label : Hydrogen Storage</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenStorage">holy:HydrogenStorage</a>
    /// </summary>
    let HydrogenStorage = _prefixId.prefix "HydrogenStorage"
    /// <summary>
    ///   <para>skos:definition : A basic component of products capable of storing hydrogen.</para>
    ///   <para>rdfs:label : Hydrogen Storage Component</para>
    ///   <para>rdfs:comment : The subclass "Hydrogen Storage Component" could be expanded to focus the domain scope to the creation of hydrogen with respect to the value chain.</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenStorageComponent">holy:HydrogenStorageComponent</a>
    /// </summary>
    let HydrogenStorageComponent = _prefixId.prefix "HydrogenStorageComponent"
    /// <summary>
    ///   <para>skos:definition : The way that hydrogen can be transported from one place to another.</para>
    ///   <para>skos:altLabel : Hydrogen Transport</para>
    ///   <para>rdfs:label : Hydrogen Transport</para>
    ///   <para>rdfs:comment : The subclass "Transport" could be expanded to focus the domain scope to the creation of hydrogen in respect to the value chain.</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenTransport">holy:HydrogenTransport</a>
    /// </summary>
    let HydrogenTransport = _prefixId.prefix "HydrogenTransport"
    /// <summary>
    ///   <para>skos:definition : A basic component of products designed for transporting hydrogen.</para>
    ///   <para>rdfs:label : Hydrogen Transport Component</para>
    ///   <para>rdfs:comment : The subclass "Hydrogen Transport Component" could be expanded to focus the domain scope to the transport of hydrogen with respect to the value chain.</para>
    ///   <a href="http://purl.org/holy/ns#HydrogenTransportComponent">holy:HydrogenTransportComponent</a>
    /// </summary>
    let HydrogenTransportComponent = _prefixId.prefix "HydrogenTransportComponent"
    let HyzonClass8 = _prefixId.prefix "HyzonClass8"
    let HyzonDrayage = _prefixId.prefix "HyzonDrayage"
    let HyzonEconicRefuse = _prefixId.prefix "HyzonEconicRefuse"
    let HyzonHighFloorCoach = _prefixId.prefix "HyzonHighFloorCoach"
    let HyzonHymaxSeries = _prefixId.prefix "HyzonHymaxSeries"

    let Hyzon_hybrid_bi_polar_plate_technology = _prefixId.prefix "Hyzon_hybrid_bi-polar_plate_technology"

    let Iceland = _prefixId.prefix "Iceland"
    let India = _prefixId.prefix "India"
    /// <summary>
    ///   <para>skos:hiddenLabel : Environmental Social Governanceskos:hiddenLabel : FIscal Year Reportskos:hiddenLabel : FY Report</para>
    ///   <para>skos:definition : Something, often a quanititative measure, which shows what a situation is like or how it is changing.</para>
    ///   <para>skos:altLabel : Index</para>
    ///   <para>rdfs:label : Indicator</para>
    ///   <para>rdfs:comment : Class defined to list certain market indicators of the hydrogen domain.</para>
    ///   <a href="http://purl.org/holy/ns#Indicator">holy:Indicator</a>
    /// </summary>
    let Indicator = _prefixId.prefix "Indicator"
    let Indonesia = _prefixId.prefix "Indonesia"
    /// <summary>
    ///   <para>skos:altLabel : Industrial heating</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Heating Planthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell-based Warehouse Heatinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Kiln Heating</para>
    ///   <para>skos:hiddenLabel : Hydrogen Burnersskos:hiddenLabel : Ovenskos:hiddenLabel : Fuel Cell Burnersskos:hiddenLabel : Kilnskos:hiddenLabel : Burner</para>
    ///   <para>skos:definition : An application used to generate heat for industry usage, such as manufacturing processes where great heat is required, or to heat large areas such as warehouses.</para>
    ///   <para>rdfs:label : Industrial Heating</para>
    ///   <a href="http://purl.org/holy/ns#IndustrialHeating">holy:IndustrialHeating</a>
    /// </summary>
    let IndustrialHeating = _prefixId.prefix "IndustrialHeating"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Circular Production Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Linear Production Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Purification</para>
    ///   <para>skos:definition : An application which is used for industrial processing. Industrial processing involves the manufacturing of semi-finished or high-quality end products by means of physical, mechanical and/or chemical processes.</para>
    ///   <para>rdfs:label : Industrial Processing</para>
    ///   <a href="http://purl.org/holy/ns#IndustrialProcessing">holy:IndustrialProcessing</a>
    /// </summary>
    let IndustrialProcessing = _prefixId.prefix "IndustrialProcessing"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Residential Constructionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Private Construction Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Industrial Construction Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Energy Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Facility Development Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Hub Developmenthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Renewable Energy Development Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Road Infrastructure Construction Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Energy Facility Construction Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Water Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Public Transportation Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Bridge Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Power Generation Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Power and Energy Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Railroad Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Commercial Construction Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Transportation Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Road Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Clean Transport Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Power Edison Partnershiphttps://wordnet-rdf.princeton.edu/ontology#hyponym : Aviation Infrastructure Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Public Construction Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Energy Transport Transformation Project</para>
    ///   <para>rdfs:label : Infrastructure Project</para>
    ///   <para>skos:example : Power Edison Partnershipskos:example : PATH4ZEROskos:example : Paving the way for Zero Emission Inland Navigation</para>
    ///   <para>skos:definition : A project which is focused on the development, creation, maintenance, or enhancement of structures and systems needed for a country, city, or organization to function properly.</para>
    ///   <para>skos:altLabel : Infrastructure Project</para>
    ///   <a href="http://purl.org/holy/ns#InfrastructureProject">holy:InfrastructureProject</a>
    /// </summary>
    let InfrastructureProject = _prefixId.prefix "InfrastructureProject"
    /// <summary>
    ///   <para>skos:example : UNECEskos:example : IMFskos:example : IPCCskos:example : United Nations</para>
    ///   <para>skos:altLabel : International Organization</para>
    ///   <para>skos:definition : An organization classified in activities of international organisations such as the United Nations and the specialised agencies of the United Nations system, regional bodies etc., the International Monetary Fund, the World Bank, the World Customs Organisation, the Organisation for Economic Co-operation and Development, the organisation of Petroleum Exporting Countries, the European Communities, the European Free Trade Association etc. according to Section U of EC NACE Rev. 2.
    ///
    /// This class also includes:
    /// - activities of diplomatic and consular missions when being determined by the country of their location rather than by the country they represent</para>
    ///   <para>rdfs:label : International Organization</para>
    ///   <a href="http://purl.org/holy/ns#InternationalOrganization">holy:InternationalOrganization</a>
    /// </summary>
    let InternationalOrganization = _prefixId.prefix "InternationalOrganization"
    /// <summary>
    ///   <para>rdfs:label : Investment</para>
    ///   <para>skos:hiddenLabel : IPOskos:hiddenLabel : Initial Public Offering</para>
    ///   <para>skos:definition : The amount of money invested by an entity for something like a project, product or application.</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Spendingshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Arbitragehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Leverage</para>
    ///   <para>skos:altLabel : Investing</para>
    ///   <a href="http://purl.org/holy/ns#Investment">holy:Investment</a>
    /// </summary>
    let Investment = _prefixId.prefix "Investment"
    let IonicCompressor50 = _prefixId.prefix "IonicCompressor50"
    let Iran = _prefixId.prefix "Iran"
    let Iraq = _prefixId.prefix "Iraq"
    let Israel = _prefixId.prefix "Israel"
    let Italy = _prefixId.prefix "Italy"
    let Ivory_Coast = _prefixId.prefix "Ivory_Coast"
    let Jamaica = _prefixId.prefix "Jamaica"
    let Jordan = _prefixId.prefix "Jordan"
    let Kazakhstan = _prefixId.prefix "Kazakhstan"
    let Kenya = _prefixId.prefix "Kenya"
    let Kiribati = _prefixId.prefix "Kiribati"
    let Kosovo = _prefixId.prefix "Kosovo"
    let Kuwait = _prefixId.prefix "Kuwait"
    let Kyrgyzstan = _prefixId.prefix "Kyrgyzstan"
    let Laos = _prefixId.prefix "Laos"
    let Latvia = _prefixId.prefix "Latvia"
    let Lebanon = _prefixId.prefix "Lebanon"
    let Lesotho = _prefixId.prefix "Lesotho"
    let Liberia = _prefixId.prefix "Liberia"
    let Libya = _prefixId.prefix "Libya"
    let Liechtenstein = _prefixId.prefix "Liechtenstein"
    /// <summary>
    ///   <para>skos:example : Tesla Powerwall</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00186-6^^xsd:stringdcterms:references : https://doi.org/10.1016/B978-044452745-5.00185-4^^xsd:string</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Lithium Cathode Materialhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Lithium Ion Batteryhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Lithium Ion Battery Cell</para>
    ///   <para>skos:hiddenLabel : Li Ion Battery</para>
    ///   <para>rdfs:label : Lithium Battery</para>
    ///   <para>skos:altLabel : Lithium Battery</para>
    ///   <para>skos:definition : A battery which uses lithium ions as a key component of its electrochemistry using liquid electrolyte solutions. It consists of two current collectors, a negative and positive electrode, and a separator containing electrolytes. The primary lithium battery uses carbon fluoride, (CF)n, as a cathode and lithium metal as an anode. The negative electrode consists of either metallic lithium or lithium compounds.</para>
    ///   <a href="http://purl.org/holy/ns#LithiumBattery">holy:LithiumBattery</a>
    /// </summary>
    let LithiumBattery = _prefixId.prefix "LithiumBattery"
    let Lithuania = _prefixId.prefix "Lithuania"
    /// <summary>
    ///   <para>skos:definition : A large road vehicle which is used for long-distance transporation over 250 miles.</para>
    ///   <para>skos:altLabel : Long Haul Truckskos:altLabel : Long-distance Truck</para>
    ///   <para>rdfs:label : Long Haul Truck</para>
    ///   <a href="http://purl.org/holy/ns#LongHaulTruck">holy:LongHaulTruck</a>
    /// </summary>
    let LongHaulTruck = _prefixId.prefix "LongHaulTruck"
    let Luxembourg = _prefixId.prefix "Luxembourg"
    let Madagascar = _prefixId.prefix "Madagascar"
    let Malawi = _prefixId.prefix "Malawi"
    let Malaysia = _prefixId.prefix "Malaysia"
    let Maldives = _prefixId.prefix "Maldives"
    let Mali = _prefixId.prefix "Mali"
    let Malta = _prefixId.prefix "Malta"
    let ManUpOrderpicker = _prefixId.prefix "ManUpOrderpicker"
    /// <summary>
    ///   <para>skos:example : Hyzon Motors Inc.skos:example : Toyota Motor Corp.skos:example : Plug Power Inc.skos:example : Subaru Corp.skos:example : Rivian Automotive Inc.skos:example : MCIskos:example : Motor Coach Industriesskos:example : Plaxtonskos:example : Arboc Speciality Vehiclesskos:example : Arboc</para>
    ///   <para>skos:hiddenLabel : PLUGskos:hiddenLabel : Plug Powerskos:hiddenLabel : Toyota Motorskos:hiddenLabel : Hyundai Motor Group</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Original Equipment Manufacturerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Solar Panel Makerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Car Makerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Automotive Manufacturerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : OEMhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Car Manufacturer</para>
    ///   <para>rdfs:label : Manufacturing Organization</para>
    ///   <para>skos:altLabel : Manufacturerskos:altLabel : Makerskos:altLabel : Manufacturing Companyskos:altLabel : Producer</para>
    ///   <para>skos:definition : An organization classified in the field of manufacturing according to EC NACE 2 (2008) in Section C Division 10-33.</para>
    ///   <a href="http://purl.org/holy/ns#ManufacturingOrganization">holy:ManufacturingOrganization</a>
    /// </summary>
    let ManufacturingOrganization = _prefixId.prefix "ManufacturingOrganization"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Seagoing Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Deep-sea vesselhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Navalhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Coastalhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Shiphttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Marine Vesselhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Marine Industry</para>
    ///   <para>rdfs:label : Marine Application</para>
    ///   <para>skos:hiddenLabel : Oceanic Useskos:hiddenLabel : Maritimeskos:hiddenLabel : Nauticalskos:hiddenLabel : Aquatic</para>
    ///   <para>skos:altLabel : Maritime Applicationskos:altLabel : Nautical Applicationskos:altLabel : Marine Usageskos:altLabel : Marine Application</para>
    ///   <para>skos:definition : An application related to sea transport of people and/or goods.</para>
    ///   <a href="http://purl.org/holy/ns#MarineApplication">holy:MarineApplication</a>
    /// </summary>
    let MarineApplication = _prefixId.prefix "MarineApplication"
    /// <summary>
    ///   <para>skos:hiddenLabel : Market Leaderskos:hiddenLabel : Market Position</para>
    ///   <para>skos:definition : The total number of buyers a company has for a certain product or in a certain segment compared to the total market size.</para>
    ///   <para>skos:altLabel : Market Percentageskos:altLabel : Market Share</para>
    ///   <para>rdfs:label : Market Share</para>
    ///   <a href="http://purl.org/holy/ns#MarketShare">holy:MarketShare</a>
    /// </summary>
    let MarketShare = _prefixId.prefix "MarketShare"
    /// <summary>
    ///   <para>skos:hiddenLabel : Major Marketskos:hiddenLabel : Second Largest Marketskos:hiddenLabel : Overall Marketskos:hiddenLabel : Key Marketskos:hiddenLabel : Biggest Marketskos:hiddenLabel : Largest Marketskos:hiddenLabel : Total Market</para>
    ///   <para>skos:altLabel : Market Capacityskos:altLabel : Market Sizeskos:altLabel : Market Volume</para>
    ///   <para>skos:definition : The total number of potential buyers of a product or service within a given market and the total revenue that these sales may generate.</para>
    ///   <para>rdfs:label : Market Size</para>
    ///   <a href="http://purl.org/holy/ns#MarketSize">holy:MarketSize</a>
    /// </summary>
    let MarketSize = _prefixId.prefix "MarketSize"
    let Marshall_Islands = _prefixId.prefix "Marshall_Islands"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Turret Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Lift Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : AGVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Man Up Orderpickerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Forklifthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Jitneyhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Stand Up Counterbalanced Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Automated Guided Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Stand Up reach Truck</para>
    ///   <para>skos:hiddenLabel : On-site Transportationskos:hiddenLabel : Warehouse Logisticsskos:hiddenLabel : Material Handling</para>
    ///   <para>skos:altLabel : Material Handling Vehicleskos:altLabel : Warehouse Vehicleskos:altLabel : Material Handling Equipment</para>
    ///   <para>rdfs:label : Material Handling Vehicle</para>
    ///   <para>skos:definition : A vehicle which is intended to be used in a mobile context within the material handling process of organizations or private persons.</para>
    ///   <a href="http://purl.org/holy/ns#MaterialHandlingVehicle">holy:MaterialHandlingVehicle</a>
    /// </summary>
    let MaterialHandlingVehicle = _prefixId.prefix "MaterialHandlingVehicle"
    let Mauritania = _prefixId.prefix "Mauritania"
    let Mauritius = _prefixId.prefix "Mauritius"
    /// <summary>
    ///   <para>skos:altLabel : PEMskos:altLabel : PFSA based proton exchange membraneskos:altLabel : PFSAskos:altLabel : PFSA membraneskos:altLabel : Cation Exchange Membraneskos:altLabel : PEM membraneskos:altLabel : Proton Exchange Membrane Electrolyzerskos:altLabel : Perfluorosulfonic Acid Membraneskos:altLabel : CE Membraneskos:altLabel : Proton Exchange Membraneskos:altLabel : Polymer Electrolyte Membrane</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00227-6^^xsd:string</para>
    ///   <para>skos:definition : A very thin membrane which conducts solely positively-charged ions and is able to block electrons. It serves as the electrolyte.</para>
    ///   <para>rdfs:label : Membrane</para>
    ///   <a href="http://purl.org/holy/ns#Membrane">holy:Membrane</a>
    /// </summary>
    let Membrane = _prefixId.prefix "Membrane"
    /// <summary>
    ///   <para>skos:definition : The heart of the fuel cell and the place where the chemical reaction takes place. It consists of membrane, catalyst layers, and gas diffusion layers.</para>
    ///   <para>skos:altLabel : Bipolar Membrane Electrode Assemblyskos:altLabel : MEAskos:altLabel : Membrane Electrode Assembly</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00227-6^^xsd:string</para>
    ///   <para>rdfs:label : Membrane Electrode Assembly</para>
    ///   <a href="http://purl.org/holy/ns#MembraneElectrodeAssembly">holy:MembraneElectrodeAssembly</a>
    /// </summary>
    let MembraneElectrodeAssembly = _prefixId.prefix "MembraneElectrodeAssembly"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Direct Methanol Fuel Cell</para>
    ///   <para>skos:example : EFYO 80skos:example : EFYO 150</para>
    ///   <para>skos:altLabel : DMFCskos:altLabel : Methanol Fuel Cell</para>
    ///   <para>rdfs:label : Methanol Fuel Cell</para>
    ///   <para>skos:definition : A fuel cell which is powered by pure methanol. It is usually mixed with water and fed directly to the fuel cell anode.</para>
    ///   <a href="http://purl.org/holy/ns#MethanolFuelCell">holy:MethanolFuelCell</a>
    /// </summary>
    let MethanolFuelCell = _prefixId.prefix "MethanolFuelCell"
    let Mexico = _prefixId.prefix "Mexico"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Portable Fuel Cell Applicationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Long-distance Transportation Unithttps://wordnet-rdf.princeton.edu/ontology#hyponym : Cargo Transporthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Transportation Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Freight Transporthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Short-distance Transportation Unithttps://wordnet-rdf.princeton.edu/ontology#hyponym : Motorized Itemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Long-distance Travelhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Clean Transport</para>
    ///   <para>skos:altLabel : Transportationskos:altLabel : Moving Applicationskos:altLabel : Mobile Application^^xsd:string</para>
    ///   <para>skos:definition : An application related to the movement of people and/or goods.</para>
    ///   <para>skos:hiddenLabel : Unstationary</para>
    ///   <para>rdfs:label : Mobile Application</para>
    ///   <a href="http://purl.org/holy/ns#MobileApplication">holy:MobileApplication</a>
    /// </summary>
    let MobileApplication = _prefixId.prefix "MobileApplication"
    let Moldova = _prefixId.prefix "Moldova"
    /// <summary>
    ///   <para>skos:definition : A high temperature fuel cell using natural gas or biogas for powering. The fuel cell itself is able to convert hydrogen in a process called internal reforming.</para>
    ///   <para>skos:altLabel : MCFCskos:altLabel : Molten Carbonate Fuel Cell</para>
    ///   <para>rdfs:label : Molten Carbonate Fuel Cell</para>
    ///   <a href="http://purl.org/holy/ns#MoltenCarbonateFuelCell">holy:MoltenCarbonateFuelCell</a>
    /// </summary>
    let MoltenCarbonateFuelCell = _prefixId.prefix "MoltenCarbonateFuelCell"
    let Monaco = _prefixId.prefix "Monaco"
    let Mongolia = _prefixId.prefix "Mongolia"
    let Montenegro = _prefixId.prefix "Montenegro"
    let Morocco = _prefixId.prefix "Morocco"
    let Mozambique = _prefixId.prefix "Mozambique"
    let Myanmar = _prefixId.prefix "Myanmar"
    let Namibia = _prefixId.prefix "Namibia"

    let NationalInnovationProgrammeHydrogenandFuelCellTechnology = _prefixId.prefix "NationalInnovationProgrammeHydrogenandFuelCellTechnology"

    let Nauru = _prefixId.prefix "Nauru"
    let Nepal = _prefixId.prefix "Nepal"
    let Netherlands = _prefixId.prefix "Netherlands"
    let New_Zealand = _prefixId.prefix "New_Zealand"
    let Nicaragua = _prefixId.prefix "Nicaragua"
    /// <summary>
    ///   <para>skos:definition : A battery which uses nickel oxide hydroxide for the cathode, metallic cadmium as its anode, and an aqueous alkali solution as its electrolyte.</para>
    ///   <para>skos:altLabel : Nickel Cadmium Battery</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-0-12-813975-2.00005-3^^xsd:string</para>
    ///   <para>rdfs:label : Nickel Cadmium Battery</para>
    ///   <a href="http://purl.org/holy/ns#NickelCadmiumBattery">holy:NickelCadmiumBattery</a>
    /// </summary>
    let NickelCadmiumBattery = _prefixId.prefix "NickelCadmiumBattery"
    /// <summary>
    ///   <para>skos:definition : A battery which uses nickel oxide for the cathode. The negative active material is hydrogen in form of a metal hydride. The electrolyte is aqueous potassium hydroxide with lithium hydroxide additive to improve the charging efficiency of the positive electrode by reducing oxygen evolution.</para>
    ///   <para>skos:altLabel : Nickel Metal Hydride Battery</para>
    ///   <para>dcterms:references : https://doi.org/10.1016/B978-044452745-5.00158-1^^xsd:string</para>
    ///   <para>rdfs:label : Nickel Metal Hydride Battery</para>
    ///   <a href="http://purl.org/holy/ns#NickelMetalHydrideBattery">holy:NickelMetalHydrideBattery</a>
    /// </summary>
    let NickelMetalHydrideBattery = _prefixId.prefix "NickelMetalHydrideBattery"
    let Niger = _prefixId.prefix "Niger"
    let Nigeria = _prefixId.prefix "Nigeria"
    let Niue = _prefixId.prefix "Niue"
    let North_America = _prefixId.prefix "North_America"
    let North_Macedonia = _prefixId.prefix "North_Macedonia"

    let NorthernPeripheryandArcticProgramme = _prefixId.prefix "NorthernPeripheryandArcticProgramme"

    let Norway = _prefixId.prefix "Norway"

    let OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa = _prefixId.prefix "OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa"

    let Oceania = _prefixId.prefix "Oceania"
    let Oman = _prefixId.prefix "Oman"
    /// <summary>
    ///   <para>skos:definition : A currently-running project which has been started but is not marked as finished or completed.</para>
    ///   <para>skos:altLabel : Currently Running Projectskos:altLabel : Currently Running Venture</para>
    ///   <para>rdfs:label : Ongoing Project</para>
    ///   <a href="http://purl.org/holy/ns#OngoingProject">holy:OngoingProject</a>
    /// </summary>
    let OngoingProject = _prefixId.prefix "OngoingProject"
    let Pakistan = _prefixId.prefix "Pakistan"
    let Palau = _prefixId.prefix "Palau"
    let Panama = _prefixId.prefix "Panama"
    let Papua_New_Guinea = _prefixId.prefix "Papua_New_Guinea"
    let Paraguay = _prefixId.prefix "Paraguay"
    /// <summary>
    ///   <para>skos:altLabel : Commuter Trainskos:altLabel : Coach Trainskos:altLabel : Passenger Train</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Light Railhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Bullet Trainhttps://wordnet-rdf.princeton.edu/ontology#hyponym : High-speed Trainhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Tram</para>
    ///   <para>skos:definition : A train carrying mostly people.</para>
    ///   <para>rdfs:label : Passenger Train</para>
    ///   <a href="http://purl.org/holy/ns#PassengerTrain">holy:PassengerTrain</a>
    /// </summary>
    let PassengerTrain = _prefixId.prefix "PassengerTrain"
    /// <summary>
    ///   <para>skos:hiddenLabel : Copyrightskos:hiddenLabel : Intellectual Propertyskos:hiddenLabel : Trademark</para>
    ///   <para>skos:definition : The total number of patents attributed to a class individual.</para>
    ///   <para>rdfs:label : Patent</para>
    ///   <a href="http://purl.org/holy/ns#Patent">holy:Patent</a>
    /// </summary>
    let Patent = _prefixId.prefix "Patent"
    let Peru = _prefixId.prefix "Peru"
    let Philippines = _prefixId.prefix "Philippines"
    /// <summary>
    ///   <para>skos:definition : A fuel cell which uses phosporic acid as an electrolyte. It can be powered by hydrogen, natural gas, or biogas.</para>
    ///   <para>skos:altLabel : PAFCskos:altLabel : Phosphoric Acid Fuel Cell</para>
    ///   <para>rdfs:label : Phosphoric Acid Fuel Cell</para>
    ///   <a href="http://purl.org/holy/ns#PhosphoricAcidFuelCell">holy:PhosphoricAcidFuelCell</a>
    /// </summary>
    let PhosphoricAcidFuelCell = _prefixId.prefix "PhosphoricAcidFuelCell"
    /// <summary>
    ///   <para>skos:hiddenLabel : Pick-upskos:hiddenLabel : Pickup</para>
    ///   <para>skos:definition : A small vehicle with an open part at the back in which goods can be carried.</para>
    ///   <para>skos:altLabel : Pickup Truck</para>
    ///   <para>rdfs:label : Pickup Truck</para>
    ///   <a href="http://purl.org/holy/ns#PickupTruck">holy:PickupTruck</a>
    /// </summary>
    let PickupTruck = _prefixId.prefix "PickupTruck"
    /// <summary>
    ///   <para>skos:definition : A project which has not been realised or started but is expected to start in the future.</para>
    ///   <para>rdfs:label : Planned Project</para>
    ///   <a href="http://purl.org/holy/ns#PlannedProject">holy:PlannedProject</a>
    /// </summary>
    let PlannedProject = _prefixId.prefix "PlannedProject"
    let Poland = _prefixId.prefix "Poland"

    /// <summary>
    ///   <para>skos:altLabel : Exchange Membrane Fuel Cellskos:altLabel : PEMFCskos:altLabel : PEM Fuel Cellskos:altLabel : PEFCskos:altLabel : Polymer Elektrolyte Fuel Cellskos:altLabel : Polymer Elektrolyt Membrane Fuel Cellskos:altLabel : Electrolyte Fuel Cell</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : High Temperature PEMFChttps://wordnet-rdf.princeton.edu/ontology#hyponym : Low Temperature PEMFChttps://wordnet-rdf.princeton.edu/ontology#hyponym : Low Temperature Proton Exchange Membrane Fuel Celhttps://wordnet-rdf.princeton.edu/ontology#hyponym : PEMFC modulehttps://wordnet-rdf.princeton.edu/ontology#hyponym : High Temperature Proton Exchange Membrane Fuel Cel</para>
    ///   <para>skos:example : FCmoveTMskos:example : FCwaveTM</para>
    ///   <para>rdfs:label : Polymer Electrolyte Membrane Fuel Cell</para>
    ///   <para>skos:hiddenLabel : Fuel Cell Power Product</para>
    ///   <para>skos:definition : A fuel cell which uses a solid polymer as an electrolyte and porous carbon electrodes containing a platinum or platinum alloy catalyst. It only needs hydrogen, oxygen from the air, and water to operate.</para>
    ///   <a href="http://purl.org/holy/ns#PolymerElectrolyteMembraneFuelCell">holy:PolymerElectrolyteMembraneFuelCell</a>
    /// </summary>
    let PolymerElectrolyteMembraneFuelCell = _prefixId.prefix "PolymerElectrolyteMembraneFuelCell"

    let Portugal = _prefixId.prefix "Portugal"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : UPS Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : AVRhttps://wordnet-rdf.princeton.edu/ontology#hyponym : VRMhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Uninterruptible Power Supply Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electrical Grid Stabilizationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Automatic Voltage Regulatorhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Voltage Regulator Module</para>
    ///   <para>skos:altLabel : Power Conditioner</para>
    ///   <para>rdfs:label : Power Conditioner</para>
    ///   <para>skos:hiddenLabel : Fuel Cell Control Unitskos:hiddenLabel : FCCU</para>
    ///   <para>skos:definition : An electrical current regulator needed for managing power.</para>
    ///   <a href="http://purl.org/holy/ns#PowerConditioner">holy:PowerConditioner</a>
    /// </summary>
    let PowerConditioner = _prefixId.prefix "PowerConditioner"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Industrial Power Generationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Backup Powerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Solar Farmhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Renewable Energy Generationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Grid Scale Energy Storagehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Solar Energyhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Flex Generatorhttps://wordnet-rdf.princeton.edu/ontology#hyponym : H2 Gas Turbinehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Flexible Power Generatorhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Clean Energy Productionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fossil Fuel Electricityhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Power Planthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Coal-fired Powerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Residential Power Generationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Backup Generatorhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Solar Electricityhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Renewable Energy Productionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Small-scale Power Gridhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Power Planthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Coal Power Stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Solar Generationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Local Energy Generationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Power Plant Generator</para>
    ///   <para>rdfs:label : Power Generation</para>
    ///   <para>skos:definition : An application which is used in the field of electricity production via power generating equipment or as fuel.</para>
    ///   <a href="http://purl.org/holy/ns#PowerGeneration">holy:PowerGeneration</a>
    /// </summary>
    let PowerGeneration = _prefixId.prefix "PowerGeneration"
    /// <summary>
    ///   <para>skos:hiddenLabel : Renewable Fuelskos:hiddenLabel : Alternative Energy Technologyskos:hiddenLabel : Homegrown Technologyskos:hiddenLabel : Green Techskos:hiddenLabel : Technology</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Product Article</para>
    ///   <para>rdfs:comment : The connection to "Application" would refer to "realized usage". A product has a creator. However, since technology and product are difficult to distinguish, technology and product will be seen as one class. Since organizations can also buy component parts, the product class has sub-classes containing components for fuel cells.</para>
    ///   <para>rdfs:label : Product</para>
    ///   <para>skos:definition : An article that is manufactured or refined for sale. A distinction will be made between the different value chain positions of a product which can be sold and/or bought.</para>
    ///   <para>skos:altLabel : Product</para>
    ///   <a href="http://purl.org/holy/ns#Product">holy:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Enhacement Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hybrid  Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Breakthrough Projecthttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Storage Project</para>
    ///   <para>skos:altLabel : Product Development Projectskos:altLabel : Product Design Project</para>
    ///   <para>rdfs:label : Product Development Project</para>
    ///   <para>skos:hiddenLabel : Product Development Cooperation</para>
    ///   <para>skos:definition : A project focused on the development of new products or the refinement of existing ones.</para>
    ///   <a href="http://purl.org/holy/ns#ProductDevelopmentProject">holy:ProductDevelopmentProject</a>
    /// </summary>
    let ProductDevelopmentProject = _prefixId.prefix "ProductDevelopmentProject"

    /// <summary>
    ///   <para>skos:example : DARPAskos:example : Defense Advanced Research Projects Agency</para>
    ///   <para>skos:definition : An organization classified in the field of public administration and defense according to EC NACE 2 (2008) in Section O Division 84.</para>
    ///   <para>skos:altLabel : Public Administration Office</para>
    ///   <para>rdfs:label : Public Administration and Defense Organization</para>
    ///   <a href="http://purl.org/holy/ns#PublicAdministrationAndDefenseOrganization">holy:PublicAdministrationAndDefenseOrganization</a>
    /// </summary>
    let PublicAdministrationAndDefenseOrganization = _prefixId.prefix "PublicAdministrationAndDefenseOrganization"

    /// <summary>
    ///   <para>skos:definition : A project classification defined during implementation that specifies essential project attributes and purpose.</para>
    ///   <para>rdfs:label : Purpose-based Project</para>
    ///   <a href="http://purl.org/holy/ns#PurposeBasedProject">holy:PurposeBasedProject</a>
    /// </summary>
    let PurposeBasedProject = _prefixId.prefix "PurposeBasedProject"
    let Qatar = _prefixId.prefix "Qatar"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Petroleum Refininghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrocrackinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Petroleum Productionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogenationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogenolysis</para>
    ///   <para>skos:altLabel : Refining Process</para>
    ///   <para>skos:definition : An application of hydrogen in the refinery industry dedicated to process oil to create different types of oil and oil products.</para>
    ///   <para>rdfs:label : Refinery Industrial Processing</para>
    ///   <para>skos:hiddenLabel : Petrochemical Market</para>
    ///   <a href="http://purl.org/holy/ns#RefineryIndustrialProcessing">holy:RefineryIndustrialProcessing</a>
    /// </summary>
    let RefineryIndustrialProcessing = _prefixId.prefix "RefineryIndustrialProcessing"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Medium Duty Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Refuse Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Straught Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : All-electric Vanhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Box Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Garbage Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-powered Van</para>
    ///   <para>skos:hiddenLabel : Van</para>
    ///   <para>skos:definition : A road vehicle which is small to large-sized and used for the transportation of goods within an area of 150 miles.</para>
    ///   <para>rdfs:label : Regional Truck</para>
    ///   <para>skos:altLabel : Regional Truck</para>
    ///   <a href="http://purl.org/holy/ns#RegionalTruck">holy:RegionalTruck</a>
    /// </summary>
    let RegionalTruck = _prefixId.prefix "RegionalTruck"
    let Republic_of_Ireland = _prefixId.prefix "Republic_of_Ireland"
    let Republic_of_the_Congo = _prefixId.prefix "Republic_of_the_Congo"
    /// <summary>
    ///   <para>skos:hiddenLabel : Scientific Research and Developmentskos:hiddenLabel : ISIC 7120skos:hiddenLabel : NACE 71.20</para>
    ///   <para>skos:example : The European Interoperability Centre for Electric Vehicles and Smart Gridsskos:example : MARiiskos:example : Pacific Northwest National Laboratoryskos:example : Malaysia Automotive Robotics and IoT Instituteskos:example : PNNL</para>
    ///   <para>skos:altLabel : Research Organizationskos:altLabel : Research and Development Centerskos:altLabel : Research Institution</para>
    ///   <para>rdfs:label : Research Organization</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Universityhttps://wordnet-rdf.princeton.edu/ontology#hyponym : University of Applied Scienceshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Technical Testing and Analysishttps://wordnet-rdf.princeton.edu/ontology#hyponym : Professional Scientific And Technical Activity</para>
    ///   <para>skos:definition : An organization classified in the field of scientific and technical activities according to EC NACE 2 (2008) in Section M Division 69-75.</para>
    ///   <a href="http://purl.org/holy/ns#ResearchOrganization">holy:ResearchOrganization</a>
    /// </summary>
    let ResearchOrganization = _prefixId.prefix "ResearchOrganization"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Gas Boilerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : PEM Fuel Cell Heaterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel-Cell Boilerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Heaterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : PEM Heaterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Polymer Electrolyte Membrane Fuel Cell Boilerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Polymer Electrolyte Membrane Fuel Cell Heaterhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel-cell Heating Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell CHPhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Residential Fuel Cell Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Heat and Power Stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Heat and Power Unithttps://wordnet-rdf.princeton.edu/ontology#hyponym : PEM Fuel Cell Boilerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Combined Heat and Power stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Boiler</para>
    ///   <para>skos:hiddenLabel : Furnaceskos:hiddenLabel : CHPskos:hiddenLabel : Radiantskos:hiddenLabel : Boiler</para>
    ///   <para>skos:altLabel : Domestic Heatingskos:altLabel : Residential Heatingskos:altLabel : Apartment Heatingskos:altLabel : Home Heating</para>
    ///   <para>skos:definition : An application used for heating a domestic house or residential area (multiple domestic houses).</para>
    ///   <para>rdfs:label : Residential Heating</para>
    ///   <a href="http://purl.org/holy/ns#ResidentialHeating">holy:ResidentialHeating</a>
    /// </summary>
    let ResidentialHeating = _prefixId.prefix "ResidentialHeating"
    /// <summary>
    ///   <para>skos:hiddenLabel : Absolute Sales</para>
    ///   <para>rdfs:label : Revenue</para>
    ///   <para>skos:altLabel : Salesskos:altLabel : Earningskos:altLabel : Gross Revenueskos:altLabel : Income</para>
    ///   <para>skos:definition : The amount of money generated within a certain class in a certain period of time.</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Total Sales</para>
    ///   <a href="http://purl.org/holy/ns#Revenue">holy:Revenue</a>
    /// </summary>
    let Revenue = _prefixId.prefix "Revenue"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Ethanol ICE Vehicleshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Passenger Electrichttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Electric Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Flex Ethanol Hybridshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen ICE vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : HFCEVshttps://wordnet-rdf.princeton.edu/ontology#hyponym : EVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : ICE vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : EVIChttps://wordnet-rdf.princeton.edu/ontology#hyponym : Flex Fuel Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Ethanol Hybrid Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Passenger Electric Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : H2ICEhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Electric Vehicleshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Ultra clean vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : EVshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Energy Efficient Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Personal Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : BEVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Zero-emission Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : FCVshttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electrical Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Fuel Cell Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Highway Usagehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Long-distance Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : ZEVhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Internal Combustion Engine Vehicle</para>
    ///   <para>skos:altLabel : Hydrogen Internal Combustion Engine Vehicleskos:altLabel : Road Usageskos:altLabel : Vehicle</para>
    ///   <para>skos:example : Ballard Powered Vehicle</para>
    ///   <para>skos:definition : An application related to the transport of people and/or goods on land.</para>
    ///   <para>rdfs:label : Road Application</para>
    ///   <a href="http://purl.org/holy/ns#RoadApplication">holy:RoadApplication</a>
    /// </summary>
    let RoadApplication = _prefixId.prefix "RoadApplication"
    let Romania = _prefixId.prefix "Romania"
    let Russia = _prefixId.prefix "Russia"
    let Rwanda = _prefixId.prefix "Rwanda"

    let Sahrawi_Arab_Democratic_Republic = _prefixId.prefix "Sahrawi_Arab_Democratic_Republic"

    let Saint_Kitts_and_Nevis = _prefixId.prefix "Saint_Kitts_and_Nevis"
    let Saint_Lucia = _prefixId.prefix "Saint_Lucia"

    let Saint_Vincent_and_the_Grenadines = _prefixId.prefix "Saint_Vincent_and_the_Grenadines"

    let Samoa = _prefixId.prefix "Samoa"
    let San_Marino = _prefixId.prefix "San_Marino"
    let Saudi_Arabia = _prefixId.prefix "Saudi_Arabia"
    let Senegal = _prefixId.prefix "Senegal"
    let Serbia = _prefixId.prefix "Serbia"
    let Seychelles = _prefixId.prefix "Seychelles"
    let Sierra_Leone = _prefixId.prefix "Sierra_Leone"
    let Singapore = _prefixId.prefix "Singapore"
    let Slovakia = _prefixId.prefix "Slovakia"
    let Slovenia = _prefixId.prefix "Slovenia"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : High Temperature Fuel Cell Gasket</para>
    ///   <para>skos:definition : A fuel cell which uses a hard, non-porous ceramic compound as the electrolyte. It can reach temperatures up to 1000°C (1830°F). It can be powered by natural gas, coal gas, biogas or hydrogen.</para>
    ///   <para>skos:altLabel : SOFCskos:altLabel : Solid Oxide Fuel Cell</para>
    ///   <para>rdfs:label : Solid Oxide Fuel Cell</para>
    ///   <para>rdfs:comment : Caution, SOFC`s must not be mixed up with SOEC's (Solid Oxide Electrolyser). SOFC`s are fuel cells using hydrogen as a fuel to generate energy. SOEC's are used for hydrogen generation using the reversed process of an SOFC. For this ontology an SOEC would be a part of the conversion class. However, since conversion is out of scope, SOEC are not mentioned in a class structure under the subclass "Conversion".</para>
    ///   <a href="http://purl.org/holy/ns#SolidOxideFuelCell">holy:SolidOxideFuelCell</a>
    /// </summary>
    let SolidOxideFuelCell = _prefixId.prefix "SolidOxideFuelCell"
    /// <summary>
    ///   <para>skos:definition : A battery which uses solid lithium as an electrolyte, not liquid.</para>
    ///   <para>skos:altLabel : Solid State Batteryskos:altLabel : Solid State Battery Technology</para>
    ///   <para>rdfs:label : Solid State Battery</para>
    ///   <a href="http://purl.org/holy/ns#SolidStateBattery">holy:SolidStateBattery</a>
    /// </summary>
    let SolidStateBattery = _prefixId.prefix "SolidStateBattery"
    let Solomon_Islands = _prefixId.prefix "Solomon_Islands"
    let Somalia = _prefixId.prefix "Somalia"
    let Somaliland = _prefixId.prefix "Somaliland"
    let South_Africa = _prefixId.prefix "South_Africa"
    let South_America = _prefixId.prefix "South_America"
    let South_Sudan = _prefixId.prefix "South_Sudan"
    /// <summary>
    ///   <para>rdfs:label : Spacecraft</para>
    ///   <para>skos:hiddenLabel : Shuttleskos:hiddenLabel : Rocketskos:hiddenLabel : Satellite</para>
    ///   <para>skos:altLabel : Rocketshipskos:altLabel : Spacecraftskos:altLabel : Space Shuttleskos:altLabel : Spaceshipskos:altLabel : Space Capsuleskos:altLabel : Satellite Launcherskos:altLabel : Space Vehicle</para>
    ///   <para>skos:definition : A vehicle designed for use and travel in space.</para>
    ///   <a href="http://purl.org/holy/ns#Spacecraft">holy:Spacecraft</a>
    /// </summary>
    let Spacecraft = _prefixId.prefix "Spacecraft"
    let Spain = _prefixId.prefix "Spain"
    let Sri_Lanka = _prefixId.prefix "Sri_Lanka"
    let StandUpCounterbalancedTruck = _prefixId.prefix "StandUpCounterbalancedTruck"
    let StandUpReachTruck = _prefixId.prefix "StandUpReachTruck"
    /// <summary>
    ///   <para>skos:definition : A project classification based on the level of progress of a project. It can be categorized according to the temporary stage such as planned, ongoing, or finished.</para>
    ///   <para>skos:altLabel : State Based Project</para>
    ///   <para>rdfs:label : State-based Project</para>
    ///   <a href="http://purl.org/holy/ns#StateBasedProject">holy:StateBasedProject</a>
    /// </summary>
    let StateBasedProject = _prefixId.prefix "StateBasedProject"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Charging hubhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Vehicle Chargerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : EV Chargerhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Vehicle Charging Hubhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Vehicle Charging Hubhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Clean Energy Storagehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Vehicle Refueling Stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Energy Storage Solutionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Grid Scale Energy Storagehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Charging Stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Charging Systemhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fueling Stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Mobile Energy Storage Solutionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Stationhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Electrolyserhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Stationary Fuel Cell Application</para>
    ///   <para>skos:altLabel : Stationary Applicationskos:altLabel : Stationary Unitskos:altLabel : Immobile</para>
    ///   <para>skos:hiddenLabel : Fast Chargerskos:hiddenLabel : Heavy Industryskos:hiddenLabel : Heavy Machineskos:hiddenLabel : Stationary Sector</para>
    ///   <para>skos:definition : An application which is intended to be placed at one location without the possibility of physically being moved when used.</para>
    ///   <para>rdfs:label : Stationary Application</para>
    ///   <a href="http://purl.org/holy/ns#StationaryApplication">holy:StationaryApplication</a>
    /// </summary>
    let StationaryApplication = _prefixId.prefix "StationaryApplication"
    let SteelCell = _prefixId.prefix "SteelCell"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : EAFhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Atomic Hydrogen Weldinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Arc Furnacehttps://wordnet-rdf.princeton.edu/ontology#hyponym : AHWhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Metal Alloyinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Iron Flashmakinghttps://wordnet-rdf.princeton.edu/ontology#hyponym : Metal Purification</para>
    ///   <para>skos:altLabel : Steel Fabricationskos:altLabel : Steel Manufacturingskos:altLabel : Steel Production</para>
    ///   <para>rdfs:label : Steel Industrial Processing</para>
    ///   <para>skos:definition : An application of hydrogen or hydrogen products in the steel industry with respect to the processing of iron ore into certain types of steel.</para>
    ///   <a href="http://purl.org/holy/ns#SteelIndustrialProcessing">holy:SteelIndustrialProcessing</a>
    /// </summary>
    let SteelIndustrialProcessing = _prefixId.prefix "SteelIndustrialProcessing"
    /// <summary>
    ///   <para>skos:definition : A ship that can travel underwater.</para>
    ///   <para>skos:altLabel : Steel Subskos:altLabel : Submersibleskos:altLabel : U-boatskos:altLabel : Underwater Craft</para>
    ///   <para>rdfs:label : Submarine</para>
    ///   <a href="http://purl.org/holy/ns#Submarine">holy:Submarine</a>
    /// </summary>
    let Submarine = _prefixId.prefix "Submarine"
    /// <summary>
    ///   <para>skos:definition : A fuel cell which uses different resources as its anode gas than hydrogen.</para>
    ///   <para>rdfs:label : Substitute Fuel Cell</para>
    ///   <para>rdfs:comment : The subclass "SubstituteFuelCell" could be expanded to focus the domain scope to the creation of hydrogen concerning the value chain.</para>
    ///   <a href="http://purl.org/holy/ns#SubstituteFuelCell">holy:SubstituteFuelCell</a>
    /// </summary>
    let SubstituteFuelCell = _prefixId.prefix "SubstituteFuelCell"
    /// <summary>
    ///   <para>skos:definition : A basic component for substitute fuel cells.</para>
    ///   <para>rdfs:label : Substitute Fuel Cell Component</para>
    ///   <para>rdfs:comment : The subclass "Substitute Fuel Cell Component" could be expanded to focus on substitute fuel cells. </para>
    ///   <a href="http://purl.org/holy/ns#SubstituteFuelCellComponent">holy:SubstituteFuelCellComponent</a>
    /// </summary>
    let SubstituteFuelCellComponent = _prefixId.prefix "SubstituteFuelCellComponent"
    /// <summary>
    ///   <para>skos:definition : A product that is manufactured or refined for sale which is using other resources than hydrogen to fulfill its purpose.</para>
    ///   <para>rdfs:label : Substitute Product</para>
    ///   <para>rdfs:comment : For the domain scope, Substitute Product currently only defines products which are substitutes for hydrogen fuel cells.rdfs:comment : The subclass "Substitute Product" could be expanded to focus the domain scope.</para>
    ///   <a href="http://purl.org/holy/ns#SubstituteProduct">holy:SubstituteProduct</a>
    /// </summary>
    let SubstituteProduct = _prefixId.prefix "SubstituteProduct"
    /// <summary>
    ///   <para>skos:definition : A part that, combined with other parts, makes a product which is a substitute to hydrogen products.</para>
    ///   <para>rdfs:label : Substitute Product Component</para>
    ///   <para>rdfs:comment : The subclass "Substitute Product Component" could be expanded to focus on substitute products of hydrogen products.</para>
    ///   <a href="http://purl.org/holy/ns#SubstituteProductComponent">holy:SubstituteProductComponent</a>
    /// </summary>
    let SubstituteProductComponent = _prefixId.prefix "SubstituteProductComponent"
    let Sudan = _prefixId.prefix "Sudan"
    /// <summary>
    ///   <para>skos:definition : A component such as equipment, material, or metal which enables efficient energy generation.</para>
    ///   <para>skos:altLabel : Supportive Hardware</para>
    ///   <para>rdfs:label : Supportive Hardware</para>
    ///   <a href="http://purl.org/holy/ns#SupportiveHardware">holy:SupportiveHardware</a>
    /// </summary>
    let SupportiveHardware = _prefixId.prefix "SupportiveHardware"
    let SureSource1500TM = _prefixId.prefix "SureSource1500TM"
    let SureSource3000TM = _prefixId.prefix "SureSource3000TM"
    let SureSource4000TM = _prefixId.prefix "SureSource4000TM"
    let Suriname = _prefixId.prefix "Suriname"
    let Sweden = _prefixId.prefix "Sweden"
    let Switzerland = _prefixId.prefix "Switzerland"
    let Syria = _prefixId.prefix "Syria"
    let Tajikistan = _prefixId.prefix "Tajikistan"
    let Tanzania = _prefixId.prefix "Tanzania"
    let Thailand = _prefixId.prefix "Thailand"

    let TheHydrogenUtilization'_amp_'GreenEnergyProject = _prefixId.prefix "TheHydrogenUtilization&GreenEnergyProject"

    let The_Bahamas = _prefixId.prefix "The_Bahamas"
    let The_Gambia = _prefixId.prefix "The_Gambia"
    let Tiger_Cub_Economies = _prefixId.prefix "Tiger_Cub_Economies"
    let Togo = _prefixId.prefix "Togo"
    let Tonga = _prefixId.prefix "Tonga"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell-powered Trainhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-powered Trainhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Powertrainhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Ammonia Powered Locomotive</para>
    ///   <para>skos:altLabel : Railroad Trainskos:altLabel : Train</para>
    ///   <para>skos:hiddenLabel : Rail</para>
    ///   <para>skos:definition : A vehicle for roads made of railways using an engine and carriages to transport people and/or goods.</para>
    ///   <para>rdfs:label : Train</para>
    ///   <a href="http://purl.org/holy/ns#Train">holy:Train</a>
    /// </summary>
    let Train = _prefixId.prefix "Train"

    /// <summary>
    ///   <para>skos:example : TC Energy</para>
    ///   <para>skos:definition : An organization classified in the field of transportation and storage according to EC NACE 2 (2008) in Section H Division 49-53.</para>
    ///   <para>rdfs:label : Transportation And Storage Organization</para>
    ///   <a href="http://purl.org/holy/ns#TransportationAndStorageOrganization">holy:TransportationAndStorageOrganization</a>
    /// </summary>
    let TransportationAndStorageOrganization = _prefixId.prefix "TransportationAndStorageOrganization"

    /// <summary>
    ///   <para>skos:hiddenLabel : Forum Tomorrow in Motionskos:hiddenLabel : Green Car Korea</para>
    ///   <para>skos:example : The World Climate Conferenceskos:example : Hydrogen Impact 2021 Conferenceskos:example : Hydrogen Technology Expo Europeskos:example : The LA Auto Showskos:example : United Nations Conference on Climate Changeskos:example : Hydrogen Transition Summitskos:example : The Automotive &amp; Tire Industry Forumskos:example : The COP 26 Climate Summitskos:example : The China International Import Exposkos:example : POWERGEN International</para>
    ///   <para>rdfs:label : Trend</para>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Economy Areahttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Adoptionhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Clean Energy Megatrendhttps://wordnet-rdf.princeton.edu/ontology#hyponym : European Mobility Expo</para>
    ///   <para>skos:definition : A general development or change of a situation in terms of behavior which can manifest itself in being discussed in forums, conferences or expos.</para>
    ///   <a href="http://purl.org/holy/ns#Trend">holy:Trend</a>
    /// </summary>
    let Trend = _prefixId.prefix "Trend"
    let Trinidad_and_Tobago = _prefixId.prefix "Trinidad_and_Tobago"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Large Goods Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Heavy Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Logistic Vehiclehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Clean Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Heavy Hydrogen Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Electric Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : HFCEThttps://wordnet-rdf.princeton.edu/ontology#hyponym : Battery Electric Semi Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Logistic Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Road Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Heavy Duty Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Mining Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Road Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen Fuel Cell Electric Truckhttps://wordnet-rdf.princeton.edu/ontology#hyponym : Hydrogen-fueled Tractor Unithttps://wordnet-rdf.princeton.edu/ontology#hyponym : LGV</para>
    ///   <para>skos:hiddenLabel : Tractorskos:hiddenLabel : LT Truckskos:hiddenLabel : LVS</para>
    ///   <para>rdfs:comment : Trucks are categorized in this ontology by distance and not by categories such as size or transportation limit.</para>
    ///   <para>skos:definition : A large road vehicle that is used for transporting large amounts of goods.</para>
    ///   <para>rdfs:label : Truck</para>
    ///   <para>skos:altLabel : Truck</para>
    ///   <a href="http://purl.org/holy/ns#Truck">holy:Truck</a>
    /// </summary>
    let Truck = _prefixId.prefix "Truck"
    let Tunisia = _prefixId.prefix "Tunisia"
    let Turkey = _prefixId.prefix "Turkey"
    let Turkmenistan = _prefixId.prefix "Turkmenistan"
    let TurretTruck = _prefixId.prefix "TurretTruck"
    let Tuvalu = _prefixId.prefix "Tuvalu"
    let Uganda = _prefixId.prefix "Uganda"
    let Ukraine = _prefixId.prefix "Ukraine"
    let United_Arab_Emirates = _prefixId.prefix "United_Arab_Emirates"
    let United_Kingdom = _prefixId.prefix "United_Kingdom"
    let United_States = _prefixId.prefix "United_States"
    let Uruguay = _prefixId.prefix "Uruguay"
    let Uzbekistan = _prefixId.prefix "Uzbekistan"
    let Vanuatu = _prefixId.prefix "Vanuatu"
    let Vatican_City = _prefixId.prefix "Vatican_City"
    let Venezuela = _prefixId.prefix "Venezuela"
    let Vietnam = _prefixId.prefix "Vietnam"
    let Western_Sahara = _prefixId.prefix "Western_Sahara"
    /// <summary>
    ///   <para>https://wordnet-rdf.princeton.edu/ontology#hyponym : Employeehttps://wordnet-rdf.princeton.edu/ontology#hyponym : Worker</para>
    ///   <para>skos:hiddenLabel : Labor</para>
    ///   <para>skos:definition : The number of persons working for an organization.</para>
    ///   <para>skos:altLabel : Labor Forceskos:altLabel : Workforce</para>
    ///   <para>rdfs:label : Work Force</para>
    ///   <a href="http://purl.org/holy/ns#WorkForce">holy:WorkForce</a>
    /// </summary>
    let WorkForce = _prefixId.prefix "WorkForce"
    let Yemen = _prefixId.prefix "Yemen"
    let ZEROe = _prefixId.prefix "ZEROe"
    let ZEROeBlendedWingBody = _prefixId.prefix "ZEROeBlendedWingBody"
    let ZEROeTurbofan = _prefixId.prefix "ZEROeTurbofan"
    let ZEROeTurboprop = _prefixId.prefix "ZEROeTurboprop"
    let Zambia = _prefixId.prefix "Zambia"
    let Zimbabwe = _prefixId.prefix "Zimbabwe"
    /// <summary>
    ///   <para>skos:definition : Defines in which geographic market an application is sold or available for use.</para>
    ///   <para>skos:altLabel : available in</para>
    ///   <para>rdfs:label : application sold in</para>
    ///   <a href="http://purl.org/holy/ns#applicationSoldIn">holy:applicationSoldIn</a>
    /// </summary>
    let applicationSoldIn = _prefixId.prefix "applicationSoldIn"
    /// <summary>
    ///   <para>skos:definition : Relates to the geographic location of applications in the market.</para>
    ///   <para>rdfs:label : has Application</para>
    ///   <a href="http://purl.org/holy/ns#hasApplication">holy:hasApplication</a>
    /// </summary>
    let hasApplication = _prefixId.prefix "hasApplication"
    /// <summary>
    ///   <para>skos:definition : Refers to indicators which are related to a certain class.</para>
    ///   <para>rdfs:label : has Indicator</para>
    ///   <para>rdfs:comment : In the hydrogen ontology, all major classes (organization, project, application, geographical market and product) are linked to the class indicator.</para>
    ///   <a href="http://purl.org/holy/ns#hasIndicator">holy:hasIndicator</a>
    /// </summary>
    let hasIndicator = _prefixId.prefix "hasIndicator"
    /// <summary>
    ///   <para>skos:definition : Indicates a direkt link from a geographic location to an organization. It shows where a organization is located.</para>
    ///   <para>rdfs:label : has Organization</para>
    ///   <a href="http://purl.org/holy/ns#hasOrganization">holy:hasOrganization</a>
    /// </summary>
    let hasOrganization = _prefixId.prefix "hasOrganization"
    /// <summary>
    ///   <para>skos:definition : Indicates a direkt link from a geographic location to a product. It shows where a product is located.</para>
    ///   <para>rdfs:label : has Product</para>
    ///   <a href="http://purl.org/holy/ns#hasProduct">holy:hasProduct</a>
    /// </summary>
    let hasProduct = _prefixId.prefix "hasProduct"
    /// <summary>
    ///   <para>skos:definition : Relates to the geographic location of projects in the market.</para>
    ///   <para>rdfs:label : has Project</para>
    ///   <a href="http://purl.org/holy/ns#hasProject">holy:hasProject</a>
    /// </summary>
    let hasProject = _prefixId.prefix "hasProject"
    /// <summary>
    ///   <para>skos:definition : Indicates which products are manufactured by a given organization.</para>
    ///   <para>rdfs:label : is produced by</para>
    ///   <para>rdfs:comment : The inverse of holy:producesProduct</para>
    ///   <a href="http://purl.org/holy/ns#isProducedBy">holy:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>skos:definition : Indicates which applications are related to an organization in terms of manufacturing, operating, licensing, leasing...</para>
    ///   <para>rdfs:label : is provided by</para>
    ///   <para>rdfs:comment : The inverse of holy:providesApplication</para>
    ///   <a href="http://purl.org/holy/ns#isProvidedBy">holy:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of holy:usesProduct and holy:usesTechnology</para>
    ///   <para>rdfs:label : is used in</para>
    ///   <para>skos:definition : Defines for which purpose a product is used in.</para>
    ///   <a href="http://purl.org/holy/ns#isUsedIn">holy:isUsedIn</a>
    /// </summary>
    let isUsedIn = _prefixId.prefix "isUsedIn"
    /// <summary>
    ///   <para>skos:definition : Defines that an organization participates with presence in a certain geographic market.</para>
    ///   <para>rdfs:label : participates in</para>
    ///   <a href="http://purl.org/holy/ns#participatesIn">holy:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>skos:definition : Indicates which organization manufactures a given product.</para>
    ///   <para>rdfs:label : produces Product</para>
    ///   <a href="http://purl.org/holy/ns#producesProduct">holy:producesProduct</a>
    /// </summary>
    let producesProduct = _prefixId.prefix "producesProduct"
    /// <summary>
    ///   <para>skos:definition : Defines in which geographic market a product is sold or available for use.</para>
    ///   <para>rdfs:label : product sold in</para>
    ///   <para>rdfs:comment : The inverse of holy:hasProduct</para>
    ///   <a href="http://purl.org/holy/ns#productSoldIn">holy:productSoldIn</a>
    /// </summary>
    let productSoldIn = _prefixId.prefix "productSoldIn"
    /// <summary>
    ///   <para>skos:definition : Indicates which organizations are directly providing applications (the end-usage) to the market either by manufacturing the application or operating, licensing, leasing... it.</para>
    ///   <para>rdfs:label : provides Application</para>
    ///   <para>rdfs:comment : The inverse of holy:isProvidedBy</para>
    ///   <a href="http://purl.org/holy/ns#providesApplication">holy:providesApplication</a>
    /// </summary>
    let providesApplication = _prefixId.prefix "providesApplication"
    /// <summary>
    ///   <para>skos:definition : Defines that a certain project is in terms of outcome related to an application.</para>
    ///   <para>rdfs:label : relates to Application</para>
    ///   <a href="http://purl.org/holy/ns#relatesToApplication">holy:relatesToApplication</a>
    /// </summary>
    let relatesToApplication = _prefixId.prefix "relatesToApplication"
    /// <summary>
    ///   <para>skos:definition : Defines that a certain project is in terms of its outcome related to a product.</para>
    ///   <para>rdfs:label : relates to Product</para>
    ///   <a href="http://purl.org/holy/ns#relatesToProduct">holy:relatesToProduct</a>
    /// </summary>
    let relatesToProduct = _prefixId.prefix "relatesToProduct"
    /// <summary>
    ///   <para>skos:definition : Defines the product used in a particular application</para>
    ///   <para>rdfs:label : uses Product</para>
    ///   <para>rdfs:comment : Inverse of holy:isUsedIn - Disjoint with holy:usesTechnology</para>
    ///   <a href="http://purl.org/holy/ns#usesProduct">holy:usesProduct</a>
    /// </summary>
    let usesProduct = _prefixId.prefix "usesProduct"
    /// <summary>
    ///   <para>rdfs:label : uses Source</para>
    ///   <para>rdfs:comment : Main Property for holy:usesProduct and holy:usesTechnology.</para>
    ///   <a href="http://purl.org/holy/ns#usesSource">holy:usesSource</a>
    /// </summary>
    let usesSource = _prefixId.prefix "usesSource"
    /// <summary>
    ///   <para>skos:definition : Defines the technology used in a particular application.</para>
    ///   <para>rdfs:label : uses Technology</para>
    ///   <para>rdfs:comment : Inverse of holy:isUsedIn - Disjoint with holy:usesApplication</para>
    ///   <a href="http://purl.org/holy/ns#usesTechnology">holy:usesTechnology</a>
    /// </summary>
    let usesTechnology = _prefixId.prefix "usesTechnology"
