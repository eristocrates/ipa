namespace http.purl.org.holy.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module holy =
    let _namespace_iri = Namespace_Iri holy |> NamespaceIRI
    /// <summary>
    ///   <para>holy:RoadApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Road Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#RoadApplication">http://purl.org/holy/ns#RoadApplication</seealso>
    let RoadApplication = Prefixed_Name(holy, "RoadApplication") |> PrefixedName
    /// <summary>
    ///   <para>holy:HydrogenProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concerning the scope of focusing on fuel cells and more precisely on PEMFCs, the sub-class reconversion will be the most focused class. Transportation, Storage and Conversion subclasses would receive greater attention when shifting the ontology to other areas of the hydrogen value chain.</para>
    /// labels<para>Hydrogen Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenProduct">http://purl.org/holy/ns#HydrogenProduct</seealso>
    let HydrogenProduct = Prefixed_Name(holy, "HydrogenProduct") |> PrefixedName
    /// <summary>
    ///   <para>holy:ResidentialHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Residential Heating</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ResidentialHeating">http://purl.org/holy/ns#ResidentialHeating</seealso>
    let ResidentialHeating = Prefixed_Name(holy, "ResidentialHeating") |> PrefixedName
    /// <summary>
    ///   <para>holy:Afghanistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Afghanistan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Afghanistan">http://purl.org/holy/ns#Afghanistan</seealso>
    let Afghanistan = Prefixed_Name(holy, "Afghanistan") |> PrefixedName
    /// <summary>
    ///   <para>holy:ZEROe</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ProductDevelopmentProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ZEROe</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ZEROe">http://purl.org/holy/ns#ZEROe</seealso>
    let ZEROe = Prefixed_Name(holy, "ZEROe") |> PrefixedName
    /// <summary>
    ///   <para>holy:Albania</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Albania</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Albania">http://purl.org/holy/ns#Albania</seealso>
    let Albania = Prefixed_Name(holy, "Albania") |> PrefixedName
    /// <summary>
    ///   <para>holy:AlkalineFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alkaline Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AlkalineFuelCell">http://purl.org/holy/ns#AlkalineFuelCell</seealso>
    let AlkalineFuelCell = Prefixed_Name(holy, "AlkalineFuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:Malawi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Malawi</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Malawi">http://purl.org/holy/ns#Malawi</seealso>
    let Malawi = Prefixed_Name(holy, "Malawi") |> PrefixedName
    /// <summary>
    ///   <para>holy:Malaysia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Malaysia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Malaysia">http://purl.org/holy/ns#Malaysia</seealso>
    let Malaysia = Prefixed_Name(holy, "Malaysia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Mauritania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Mauritania</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Mauritania">http://purl.org/holy/ns#Mauritania</seealso>
    let Mauritania = Prefixed_Name(holy, "Mauritania") |> PrefixedName
    /// <summary>
    ///   <para>holy:Mauritius</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Mauritius</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Mauritius">http://purl.org/holy/ns#Mauritius</seealso>
    let Mauritius = Prefixed_Name(holy, "Mauritius") |> PrefixedName
    /// <summary>
    ///   <para>holy:Monaco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Monaco</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Monaco">http://purl.org/holy/ns#Monaco</seealso>
    let Monaco = Prefixed_Name(holy, "Monaco") |> PrefixedName
    /// <summary>
    ///   <para>holy:Mongolia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Mongolia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Mongolia">http://purl.org/holy/ns#Mongolia</seealso>
    let Mongolia = Prefixed_Name(holy, "Mongolia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Myanmar</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Myanmar</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Myanmar">http://purl.org/holy/ns#Myanmar</seealso>
    let Myanmar = Prefixed_Name(holy, "Myanmar") |> PrefixedName
    /// <summary>
    ///   <para>holy:Namibia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Namibia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Namibia">http://purl.org/holy/ns#Namibia</seealso>
    let Namibia = Prefixed_Name(holy, "Namibia") |> PrefixedName
    /// <summary>
    ///   <para>holy:New_Zealand</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>New Zealand</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#New_Zealand">http://purl.org/holy/ns#New_Zealand</seealso>
    let New_Zealand = Prefixed_Name(holy, "New_Zealand") |> PrefixedName
    /// <summary>
    ///   <para>holy:Nigeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Nigeria</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Nigeria">http://purl.org/holy/ns#Nigeria</seealso>
    let Nigeria = Prefixed_Name(holy, "Nigeria") |> PrefixedName
    /// <summary>
    ///   <para>holy:Niue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Niue</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Niue">http://purl.org/holy/ns#Niue</seealso>
    let Niue = Prefixed_Name(holy, "Niue") |> PrefixedName
    /// <summary>
    ///   <para>holy:Oman</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Oman</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Oman">http://purl.org/holy/ns#Oman</seealso>
    let Oman = Prefixed_Name(holy, "Oman") |> PrefixedName
    /// <summary>
    ///   <para>holy:Pakistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Pakistan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Pakistan">http://purl.org/holy/ns#Pakistan</seealso>
    let Pakistan = Prefixed_Name(holy, "Pakistan") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenStorageComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Hydrogen Storage Component" could be expanded to focus the domain scope to the creation of hydrogen with respect to the value chain.</para>
    /// labels<para>Hydrogen Storage Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenStorageComponent">http://purl.org/holy/ns#HydrogenStorageComponent</seealso>
    let HydrogenStorageComponent =
        Prefixed_Name(holy, "HydrogenStorageComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Transport" could be expanded to focus the domain scope to the creation of hydrogen in respect to the value chain.</para>
    /// labels<para>Hydrogen Transport</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenTransport">http://purl.org/holy/ns#HydrogenTransport</seealso>
    let HydrogenTransport = Prefixed_Name(holy, "HydrogenTransport") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenTransportComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Hydrogen Transport Component" could be expanded to focus the domain scope to the transport of hydrogen with respect to the value chain.</para>
    /// labels<para>Hydrogen Transport Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenTransportComponent">http://purl.org/holy/ns#HydrogenTransportComponent</seealso>
    let HydrogenTransportComponent =
        Prefixed_Name(holy, "HydrogenTransportComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:HyzonEconicRefuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:RegionalTruck</para>
    ///
    /// labels<para>Hyzon Econic Refuse</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HyzonEconicRefuse">http://purl.org/holy/ns#HyzonEconicRefuse</seealso>
    let HyzonEconicRefuse = Prefixed_Name(holy, "HyzonEconicRefuse") |> PrefixedName
    /// <summary>
    ///   <para>holy:HyzonHighFloorCoach</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Bus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Hyzon High-Floor Coach</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HyzonHighFloorCoach">http://purl.org/holy/ns#HyzonHighFloorCoach</seealso>
    let HyzonHighFloorCoach = Prefixed_Name(holy, "HyzonHighFloorCoach") |> PrefixedName
    /// <summary>
    ///   <para>holy:TurretTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///
    /// labels<para>Turret Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#TurretTruck">http://purl.org/holy/ns#TurretTruck</seealso>
    let TurretTruck = Prefixed_Name(holy, "TurretTruck") |> PrefixedName
    /// <summary>
    ///   <para>holy:WorkForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Work Force</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#WorkForce">http://purl.org/holy/ns#WorkForce</seealso>
    let WorkForce = Prefixed_Name(holy, "WorkForce") |> PrefixedName
    /// <summary>
    ///   <para>holy:ZEROeTurboprop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Aircraft</para>
    ///
    /// labels<para>ZEROe Turboprop</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ZEROeTurboprop">http://purl.org/holy/ns#ZEROeTurboprop</seealso>
    let ZEROeTurboprop = Prefixed_Name(holy, "ZEROeTurboprop") |> PrefixedName
    /// <summary>
    ///   <para>holy:ZEROeTurbofan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Aircraft</para>
    ///
    /// labels<para>ZEROe Turbofan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ZEROeTurbofan">http://purl.org/holy/ns#ZEROeTurbofan</seealso>
    let ZEROeTurbofan = Prefixed_Name(holy, "ZEROeTurbofan") |> PrefixedName
    /// <summary>
    ///   <para>holy:PassengerTrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Passenger Train</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PassengerTrain">http://purl.org/holy/ns#PassengerTrain</seealso>
    let PassengerTrain = Prefixed_Name(holy, "PassengerTrain") |> PrefixedName
    /// <summary>
    ///   <para>holy:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>The inverse of holy:providesApplication</para>
    /// labels<para>is provided by</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#isProvidedBy">http://purl.org/holy/ns#isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(holy, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>holy:Portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Portugal</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Portugal">http://purl.org/holy/ns#Portugal</seealso>
    let Portugal = Prefixed_Name(holy, "Portugal") |> PrefixedName

    /// <summary>
    ///   <para>holy:PolymerElectrolyteMembraneFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Polymer Electrolyte Membrane Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PolymerElectrolyteMembraneFuelCell">http://purl.org/holy/ns#PolymerElectrolyteMembraneFuelCell</seealso>
    let PolymerElectrolyteMembraneFuelCell =
        Prefixed_Name(holy, "PolymerElectrolyteMembraneFuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:Sahrawi_Arab_Democratic_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Sahrawi Arab Democratic Republic</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Sahrawi_Arab_Democratic_Republic">http://purl.org/holy/ns#Sahrawi_Arab_Democratic_Republic</seealso>
    let Sahrawi_Arab_Democratic_Republic =
        Prefixed_Name(holy, "Sahrawi_Arab_Democratic_Republic") |> PrefixedName

    /// <summary>
    ///   <para>holy:San_Marino</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>San Marino</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#San_Marino">http://purl.org/holy/ns#San_Marino</seealso>
    let San_Marino = Prefixed_Name(holy, "San_Marino") |> PrefixedName
    /// <summary>
    ///   <para>holy:Sierra_Leone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Sierra Leone</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Sierra_Leone">http://purl.org/holy/ns#Sierra_Leone</seealso>
    let Sierra_Leone = Prefixed_Name(holy, "Sierra_Leone") |> PrefixedName
    /// <summary>
    ///   <para>holy:Spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Spain</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Spain">http://purl.org/holy/ns#Spain</seealso>
    let Spain = Prefixed_Name(holy, "Spain") |> PrefixedName
    /// <summary>
    ///   <para>holy:Suriname</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Suriname</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Suriname">http://purl.org/holy/ns#Suriname</seealso>
    let Suriname = Prefixed_Name(holy, "Suriname") |> PrefixedName
    /// <summary>
    ///   <para>holy:Tanzania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Tanzania</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Tanzania">http://purl.org/holy/ns#Tanzania</seealso>
    let Tanzania = Prefixed_Name(holy, "Tanzania") |> PrefixedName
    /// <summary>
    ///   <para>holy:Thailand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Thailand</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Thailand">http://purl.org/holy/ns#Thailand</seealso>
    let Thailand = Prefixed_Name(holy, "Thailand") |> PrefixedName
    /// <summary>
    ///   <para>holy:applicationSoldIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>application sold in</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#applicationSoldIn">http://purl.org/holy/ns#applicationSoldIn</seealso>
    let applicationSoldIn = Prefixed_Name(holy, "applicationSoldIn") |> PrefixedName
    /// <summary>
    ///   <para>holy:usesProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>Inverse of holy:isUsedIn - Disjoint with holy:usesTechnology</para>
    /// labels<para>uses Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#usesProduct">http://purl.org/holy/ns#usesProduct</seealso>
    let usesProduct = Prefixed_Name(holy, "usesProduct") |> PrefixedName
    /// <summary>
    ///   <para>holy:usesTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>Inverse of holy:isUsedIn - Disjoint with holy:usesApplication</para>
    /// labels<para>uses Technology</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#usesTechnology">http://purl.org/holy/ns#usesTechnology</seealso>
    let usesTechnology = Prefixed_Name(holy, "usesTechnology") |> PrefixedName
    /// <summary>
    ///   <para>holy:LongHaulTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Long Haul Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#LongHaulTruck">http://purl.org/holy/ns#LongHaulTruck</seealso>
    let LongHaulTruck = Prefixed_Name(holy, "LongHaulTruck") |> PrefixedName
    /// <summary>
    ///   <para>holy:EthanolFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ethanol Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#EthanolFuelCell">http://purl.org/holy/ns#EthanolFuelCell</seealso>
    let EthanolFuelCell = Prefixed_Name(holy, "EthanolFuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:EuropeanCleanHydrogenAlliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Project</para>
    ///
    /// labels<para>European Clean Hydrogen Alliance</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#EuropeanCleanHydrogenAlliance">http://purl.org/holy/ns#EuropeanCleanHydrogenAlliance</seealso>
    let EuropeanCleanHydrogenAlliance =
        Prefixed_Name(holy, "EuropeanCleanHydrogenAlliance") |> PrefixedName

    /// <summary>
    ///   <para>holy:Exqui.City24FuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Bus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Exqui.City24 Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Exqui.City24FuelCell">http://purl.org/holy/ns#Exqui.City24FuelCell</seealso>
    let ``Exqui.City24FuelCell`` =
        Prefixed_Name(holy, "Exqui.City24FuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:Ferry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ferry</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ferry">http://purl.org/holy/ns#Ferry</seealso>
    let Ferry = Prefixed_Name(holy, "Ferry") |> PrefixedName
    /// <summary>
    ///   <para>holy:GeographicMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic Market</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#GeographicMarket">http://purl.org/holy/ns#GeographicMarket</seealso>
    let GeographicMarket = Prefixed_Name(holy, "GeographicMarket") |> PrefixedName
    /// <summary>
    ///   <para>holy:Hungary</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Hungary</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Hungary">http://purl.org/holy/ns#Hungary</seealso>
    let Hungary = Prefixed_Name(holy, "Hungary") |> PrefixedName
    /// <summary>
    ///   <para>holy:HydrogenStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Storage" could be expanded to focus the domain scope to the creation of hydrogen with respect to the value chain. Future expansions could categorize between storage technologies within tanks or using absorbing materials.</para>
    /// labels<para>Hydrogen Storage</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenStorage">http://purl.org/holy/ns#HydrogenStorage</seealso>
    let HydrogenStorage = Prefixed_Name(holy, "HydrogenStorage") |> PrefixedName

    /// <summary>
    ///   <para>holy:OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:LongHaulTruck</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Hyzon Vehicle</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa">http://purl.org/holy/ns#OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa</seealso>
    let OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa =
        Prefixed_Name(holy, "OWLNamedIndividual_7f4f3263_d74c_4f58_a998_c670b97905fa") |> PrefixedName

    /// <summary>
    ///   <para>holy:HyzonClass8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:LongHaulTruck</para>
    ///
    /// labels<para>Hyzon Class 8</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HyzonClass8">http://purl.org/holy/ns#HyzonClass8</seealso>
    let HyzonClass8 = Prefixed_Name(holy, "HyzonClass8") |> PrefixedName


    let ``TheHydrogenUtilization&GreenEnergyProject`` =
        Prefixed_Name(holy, "TheHydrogenUtilization&GreenEnergyProject") |> PrefixedName

    /// <summary>
    ///   <para>holy:Iraq</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Iraq</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Iraq">http://purl.org/holy/ns#Iraq</seealso>
    let Iraq = Prefixed_Name(holy, "Iraq") |> PrefixedName
    /// <summary>
    ///   <para>holy:Israel</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Israel</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Israel">http://purl.org/holy/ns#Israel</seealso>
    let Israel = Prefixed_Name(holy, "Israel") |> PrefixedName
    /// <summary>
    ///   <para>holy:Kazakhstan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Kazakhstan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Kazakhstan">http://purl.org/holy/ns#Kazakhstan</seealso>
    let Kazakhstan = Prefixed_Name(holy, "Kazakhstan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Kiribati</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Kiribati</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Kiribati">http://purl.org/holy/ns#Kiribati</seealso>
    let Kiribati = Prefixed_Name(holy, "Kiribati") |> PrefixedName
    /// <summary>
    ///   <para>holy:Kosovo</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Kosovo</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Kosovo">http://purl.org/holy/ns#Kosovo</seealso>
    let Kosovo = Prefixed_Name(holy, "Kosovo") |> PrefixedName
    /// <summary>
    ///   <para>holy:South_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Continent</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>South America</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#South_America">http://purl.org/holy/ns#South_America</seealso>
    let South_America = Prefixed_Name(holy, "South_America") |> PrefixedName
    /// <summary>
    ///   <para>holy:Latvia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Latvia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Latvia">http://purl.org/holy/ns#Latvia</seealso>
    let Latvia = Prefixed_Name(holy, "Latvia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Libya</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Libya</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Libya">http://purl.org/holy/ns#Libya</seealso>
    let Libya = Prefixed_Name(holy, "Libya") |> PrefixedName
    /// <summary>
    ///   <para>holy:Liechtenstein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Liechtenstein</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Liechtenstein">http://purl.org/holy/ns#Liechtenstein</seealso>
    let Liechtenstein = Prefixed_Name(holy, "Liechtenstein") |> PrefixedName
    /// <summary>
    ///   <para>holy:Lithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Lithuania</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Lithuania">http://purl.org/holy/ns#Lithuania</seealso>
    let Lithuania = Prefixed_Name(holy, "Lithuania") |> PrefixedName
    /// <summary>
    ///   <para>holy:Luxembourg</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Luxembourg</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Luxembourg">http://purl.org/holy/ns#Luxembourg</seealso>
    let Luxembourg = Prefixed_Name(holy, "Luxembourg") |> PrefixedName
    /// <summary>
    ///   <para>holy:Maldives</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Maldives</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Maldives">http://purl.org/holy/ns#Maldives</seealso>
    let Maldives = Prefixed_Name(holy, "Maldives") |> PrefixedName
    /// <summary>
    ///   <para>holy:Mali</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Mali</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Mali">http://purl.org/holy/ns#Mali</seealso>
    let Mali = Prefixed_Name(holy, "Mali") |> PrefixedName
    /// <summary>
    ///   <para>holy:Mexico</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Mexico</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Mexico">http://purl.org/holy/ns#Mexico</seealso>
    let Mexico = Prefixed_Name(holy, "Mexico") |> PrefixedName
    /// <summary>
    ///   <para>holy:SubstituteProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For the domain scope, Substitute Product currently only defines products which are substitutes for hydrogen fuel cells.</para>
    ///   <para>The subclass "Substitute Product" could be expanded to focus the domain scope.</para>
    /// labels<para>Substitute Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SubstituteProduct">http://purl.org/holy/ns#SubstituteProduct</seealso>
    let SubstituteProduct = Prefixed_Name(holy, "SubstituteProduct") |> PrefixedName
    /// <summary>
    ///   <para>holy:Moldova</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Moldova</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Moldova">http://purl.org/holy/ns#Moldova</seealso>
    let Moldova = Prefixed_Name(holy, "Moldova") |> PrefixedName
    /// <summary>
    ///   <para>holy:Nauru</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Nauru</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Nauru">http://purl.org/holy/ns#Nauru</seealso>
    let Nauru = Prefixed_Name(holy, "Nauru") |> PrefixedName
    /// <summary>
    ///   <para>holy:Nepal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Nepal</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Nepal">http://purl.org/holy/ns#Nepal</seealso>
    let Nepal = Prefixed_Name(holy, "Nepal") |> PrefixedName
    /// <summary>
    ///   <para>holy:Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Netherlands</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Netherlands">http://purl.org/holy/ns#Netherlands</seealso>
    let Netherlands = Prefixed_Name(holy, "Netherlands") |> PrefixedName
    /// <summary>
    ///   <para>holy:North_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Continent</para>
    ///
    /// labels<para>North America</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#North_America">http://purl.org/holy/ns#North_America</seealso>
    let North_America = Prefixed_Name(holy, "North_America") |> PrefixedName
    /// <summary>
    ///   <para>holy:North_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>North Macedonia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#North_Macedonia">http://purl.org/holy/ns#North_Macedonia</seealso>
    let North_Macedonia = Prefixed_Name(holy, "North_Macedonia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Norway</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Norway">http://purl.org/holy/ns#Norway</seealso>
    let Norway = Prefixed_Name(holy, "Norway") |> PrefixedName
    /// <summary>
    ///   <para>holy:Papua_New_Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Papua New Guinea</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Papua_New_Guinea">http://purl.org/holy/ns#Papua_New_Guinea</seealso>
    let Papua_New_Guinea = Prefixed_Name(holy, "Papua_New_Guinea") |> PrefixedName
    /// <summary>
    ///   <para>holy:Paraguay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Paraguay</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Paraguay">http://purl.org/holy/ns#Paraguay</seealso>
    let Paraguay = Prefixed_Name(holy, "Paraguay") |> PrefixedName
    /// <summary>
    ///   <para>holy:Peru</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Peru</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Peru">http://purl.org/holy/ns#Peru</seealso>
    let Peru = Prefixed_Name(holy, "Peru") |> PrefixedName
    /// <summary>
    ///   <para>holy:Philippines</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Philippines</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Philippines">http://purl.org/holy/ns#Philippines</seealso>
    let Philippines = Prefixed_Name(holy, "Philippines") |> PrefixedName

    /// <summary>
    ///   <para>holy:Republic_of_the_Congo</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Republic of the Congo</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Republic_of_the_Congo">http://purl.org/holy/ns#Republic_of_the_Congo</seealso>
    let Republic_of_the_Congo =
        Prefixed_Name(holy, "Republic_of_the_Congo") |> PrefixedName

    /// <summary>
    ///   <para>holy:Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Romania</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Romania">http://purl.org/holy/ns#Romania</seealso>
    let Romania = Prefixed_Name(holy, "Romania") |> PrefixedName
    /// <summary>
    ///   <para>holy:Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Russia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Russia">http://purl.org/holy/ns#Russia</seealso>
    let Russia = Prefixed_Name(holy, "Russia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Rwanda</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rwanda</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Rwanda">http://purl.org/holy/ns#Rwanda</seealso>
    let Rwanda = Prefixed_Name(holy, "Rwanda") |> PrefixedName
    /// <summary>
    ///   <para>holy:Saudi_Arabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Saudi Arabia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Saudi_Arabia">http://purl.org/holy/ns#Saudi_Arabia</seealso>
    let Saudi_Arabia = Prefixed_Name(holy, "Saudi_Arabia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Senegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Senegal</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Senegal">http://purl.org/holy/ns#Senegal</seealso>
    let Senegal = Prefixed_Name(holy, "Senegal") |> PrefixedName
    /// <summary>
    ///   <para>holy:Serbia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Serbia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Serbia">http://purl.org/holy/ns#Serbia</seealso>
    let Serbia = Prefixed_Name(holy, "Serbia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Seychelles</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Seychelles</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Seychelles">http://purl.org/holy/ns#Seychelles</seealso>
    let Seychelles = Prefixed_Name(holy, "Seychelles") |> PrefixedName
    /// <summary>
    ///   <para>holy:Somalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Somalia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Somalia">http://purl.org/holy/ns#Somalia</seealso>
    let Somalia = Prefixed_Name(holy, "Somalia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Somaliland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Somaliland</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Somaliland">http://purl.org/holy/ns#Somaliland</seealso>
    let Somaliland = Prefixed_Name(holy, "Somaliland") |> PrefixedName
    /// <summary>
    ///   <para>holy:South_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>South Africa</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#South_Africa">http://purl.org/holy/ns#South_Africa</seealso>
    let South_Africa = Prefixed_Name(holy, "South_Africa") |> PrefixedName
    /// <summary>
    ///   <para>holy:Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Sweden</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Sweden">http://purl.org/holy/ns#Sweden</seealso>
    let Sweden = Prefixed_Name(holy, "Sweden") |> PrefixedName
    /// <summary>
    ///   <para>holy:Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Switzerland</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Switzerland">http://purl.org/holy/ns#Switzerland</seealso>
    let Switzerland = Prefixed_Name(holy, "Switzerland") |> PrefixedName
    /// <summary>
    ///   <para>holy:Syria</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Syria</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Syria">http://purl.org/holy/ns#Syria</seealso>
    let Syria = Prefixed_Name(holy, "Syria") |> PrefixedName
    /// <summary>
    ///   <para>holy:Tajikistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Tajikistan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Tajikistan">http://purl.org/holy/ns#Tajikistan</seealso>
    let Tajikistan = Prefixed_Name(holy, "Tajikistan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Tonga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Tonga</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Tonga">http://purl.org/holy/ns#Tonga</seealso>
    let Tonga = Prefixed_Name(holy, "Tonga") |> PrefixedName
    /// <summary>
    ///   <para>holy:Trinidad_and_Tobago</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Trinidad and Tobago</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Trinidad_and_Tobago">http://purl.org/holy/ns#Trinidad_and_Tobago</seealso>
    let Trinidad_and_Tobago = Prefixed_Name(holy, "Trinidad_and_Tobago") |> PrefixedName
    /// <summary>
    ///   <para>holy:Tunisia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Tunisia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Tunisia">http://purl.org/holy/ns#Tunisia</seealso>
    let Tunisia = Prefixed_Name(holy, "Tunisia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Turkey</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Turkey">http://purl.org/holy/ns#Turkey</seealso>
    let Turkey = Prefixed_Name(holy, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>holy:Turkmenistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Turkmenistan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Turkmenistan">http://purl.org/holy/ns#Turkmenistan</seealso>
    let Turkmenistan = Prefixed_Name(holy, "Turkmenistan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Tuvalu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Tuvalu</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Tuvalu">http://purl.org/holy/ns#Tuvalu</seealso>
    let Tuvalu = Prefixed_Name(holy, "Tuvalu") |> PrefixedName
    /// <summary>
    ///   <para>holy:Vanuatu</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Vanuatu</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Vanuatu">http://purl.org/holy/ns#Vanuatu</seealso>
    let Vanuatu = Prefixed_Name(holy, "Vanuatu") |> PrefixedName
    /// <summary>
    ///   <para>holy:Vatican_City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Vatican City</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Vatican_City">http://purl.org/holy/ns#Vatican_City</seealso>
    let Vatican_City = Prefixed_Name(holy, "Vatican_City") |> PrefixedName
    /// <summary>
    ///   <para>holy:Venezuela</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Venezuela</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Venezuela">http://purl.org/holy/ns#Venezuela</seealso>
    let Venezuela = Prefixed_Name(holy, "Venezuela") |> PrefixedName
    /// <summary>
    ///   <para>holy:Vietnam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Vietnam</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Vietnam">http://purl.org/holy/ns#Vietnam</seealso>
    let Vietnam = Prefixed_Name(holy, "Vietnam") |> PrefixedName
    /// <summary>
    ///   <para>holy:IndustrialHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Industrial Heating</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#IndustrialHeating">http://purl.org/holy/ns#IndustrialHeating</seealso>
    let IndustrialHeating = Prefixed_Name(holy, "IndustrialHeating") |> PrefixedName
    /// <summary>
    ///   <para>holy:Investment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Investment</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Investment">http://purl.org/holy/ns#Investment</seealso>
    let Investment = Prefixed_Name(holy, "Investment") |> PrefixedName
    /// <summary>
    ///   <para>holy:LithiumBattery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lithium Battery</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#LithiumBattery">http://purl.org/holy/ns#LithiumBattery</seealso>
    let LithiumBattery = Prefixed_Name(holy, "LithiumBattery") |> PrefixedName
    /// <summary>
    ///   <para>holy:ManUpOrderpicker</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Man-Up Orderpicker</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ManUpOrderpicker">http://purl.org/holy/ns#ManUpOrderpicker</seealso>
    let ManUpOrderpicker = Prefixed_Name(holy, "ManUpOrderpicker") |> PrefixedName
    /// <summary>
    ///   <para>holy:hasIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>In the hydrogen ontology, all major classes (organization, project, application, geographical market and product) are linked to the class indicator.</para>
    /// labels<para>has Indicator</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#hasIndicator">http://purl.org/holy/ns#hasIndicator</seealso>
    let hasIndicator = Prefixed_Name(holy, "hasIndicator") |> PrefixedName
    /// <summary>
    ///   <para>holy:hasProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#hasProduct">http://purl.org/holy/ns#hasProduct</seealso>
    let hasProduct = Prefixed_Name(holy, "hasProduct") |> PrefixedName
    /// <summary>
    ///   <para>holy:productSoldIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The inverse of holy:hasProduct</para>
    /// labels<para>product sold in</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#productSoldIn">http://purl.org/holy/ns#productSoldIn</seealso>
    let productSoldIn = Prefixed_Name(holy, "productSoldIn") |> PrefixedName
    /// <summary>
    ///   <para>holy:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>The inverse of holy:producesProduct</para>
    /// labels<para>is produced by</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#isProducedBy">http://purl.org/holy/ns#isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(holy, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>holy:relatesToProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>relates to Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#relatesToProduct">http://purl.org/holy/ns#relatesToProduct</seealso>
    let relatesToProduct = Prefixed_Name(holy, "relatesToProduct") |> PrefixedName
    /// <summary>
    ///   <para>holy:SureSource4000TM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MoltenCarbonateFuelCell</para>
    ///
    /// labels<para>SureSource 4000TM</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SureSource4000TM">http://purl.org/holy/ns#SureSource4000TM</seealso>
    let SureSource4000TM = Prefixed_Name(holy, "SureSource4000TM") |> PrefixedName
    /// <summary>
    ///   <para>holy:Georgia_(country)</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Georgia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Georgia_(country)">http://purl.org/holy/ns#Georgia_(country)</seealso>
    let ``Georgia_(country)`` = Prefixed_Name(holy, "Georgia_(country)") |> PrefixedName
    /// <summary>
    ///   <para>holy:Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Guinea</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Guinea">http://purl.org/holy/ns#Guinea</seealso>
    let Guinea = Prefixed_Name(holy, "Guinea") |> PrefixedName
    /// <summary>
    ///   <para>holy:isUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Inverse of holy:usesProduct and holy:usesTechnology</para>
    /// labels<para>is used in</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#isUsedIn">http://purl.org/holy/ns#isUsedIn</seealso>
    let isUsedIn = Prefixed_Name(holy, "isUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>holy:ZEROeBlendedWingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Aircraft</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ZEROe Blended-Wing Body</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ZEROeBlendedWingBody">http://purl.org/holy/ns#ZEROeBlendedWingBody</seealso>
    let ZEROeBlendedWingBody =
        Prefixed_Name(holy, "ZEROeBlendedWingBody") |> PrefixedName

    /// <summary>
    ///   <para>holy:StateBasedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>State-based Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#StateBasedProject">http://purl.org/holy/ns#StateBasedProject</seealso>
    let StateBasedProject = Prefixed_Name(holy, "StateBasedProject") |> PrefixedName
    /// <summary>
    ///   <para>holy:FossilFuel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "FossilFuel" could be expanded to focus the domain scope to the creation of hydrogen concerning the value chain.</para>
    /// labels<para>Fossil Fuel</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#FossilFuel">http://purl.org/holy/ns#FossilFuel</seealso>
    let FossilFuel = Prefixed_Name(holy, "FossilFuel") |> PrefixedName
    /// <summary>
    ///   <para>holy:FuelProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fuel Processor</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#FuelProcessor">http://purl.org/holy/ns#FuelProcessor</seealso>
    let FuelProcessor = Prefixed_Name(holy, "FuelProcessor") |> PrefixedName
    /// <summary>
    ///   <para>holy:Guatemala</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Guatemala</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Guatemala">http://purl.org/holy/ns#Guatemala</seealso>
    let Guatemala = Prefixed_Name(holy, "Guatemala") |> PrefixedName
    /// <summary>
    ///   <para>holy:Guinea-Bissau</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Guinea-Bissau</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Guinea-Bissau">http://purl.org/holy/ns#Guinea-Bissau</seealso>
    let Guinea_Bissau = Prefixed_Name(holy, "Guinea-Bissau") |> PrefixedName

    /// <summary>
    ///   <para>holy:Exqui.City18FuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Bus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Exqui.City18 Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Exqui.City18FuelCell">http://purl.org/holy/ns#Exqui.City18FuelCell</seealso>
    let ``Exqui.City18FuelCell`` =
        Prefixed_Name(holy, "Exqui.City18FuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:FinishedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Finished Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#FinishedProject">http://purl.org/holy/ns#FinishedProject</seealso>
    let FinishedProject = Prefixed_Name(holy, "FinishedProject") |> PrefixedName
    /// <summary>
    ///   <para>holy:Flags_of_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Flags of Africa</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Flags_of_Africa">http://purl.org/holy/ns#Flags_of_Africa</seealso>
    let Flags_of_Africa = Prefixed_Name(holy, "Flags_of_Africa") |> PrefixedName

    /// <summary>
    ///   <para>holy:ProductDevelopmentProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Product Development Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ProductDevelopmentProject">http://purl.org/holy/ns#ProductDevelopmentProject</seealso>
    let ProductDevelopmentProject =
        Prefixed_Name(holy, "ProductDevelopmentProject") |> PrefixedName

    /// <summary>
    ///   <para>holy:RefineryIndustrialProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Refinery Industrial Processing</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#RefineryIndustrialProcessing">http://purl.org/holy/ns#RefineryIndustrialProcessing</seealso>
    let RefineryIndustrialProcessing =
        Prefixed_Name(holy, "RefineryIndustrialProcessing") |> PrefixedName

    /// <summary>
    ///   <para>holy:ManufacturingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Manufacturing Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ManufacturingOrganization">http://purl.org/holy/ns#ManufacturingOrganization</seealso>
    let ManufacturingOrganization =
        Prefixed_Name(holy, "ManufacturingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>holy:Hyzon_hybrid_bi-polar_plate_technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:BipolarPlate</para>
    ///
    /// labels<para>Hyzon's hybrid bi-polar plate technology</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Hyzon_hybrid_bi-polar_plate_technology">http://purl.org/holy/ns#Hyzon_hybrid_bi-polar_plate_technology</seealso>
    let Hyzon_hybrid_bi_polar_plate_technology =
        Prefixed_Name(holy, "Hyzon_hybrid_bi-polar_plate_technology") |> PrefixedName

    /// <summary>
    ///   <para>holy:HyzonHymaxSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:LongHaulTruck</para>
    ///
    /// labels<para>Hyzon Hymax Series</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HyzonHymaxSeries">http://purl.org/holy/ns#HyzonHymaxSeries</seealso>
    let HyzonHymaxSeries = Prefixed_Name(holy, "HyzonHymaxSeries") |> PrefixedName
    /// <summary>
    ///   <para>holy:HyzonDrayage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:LongHaulTruck</para>
    /// </remarks>
    /// <seealso href="http://purl.org/holy/ns#HyzonDrayage">http://purl.org/holy/ns#HyzonDrayage</seealso>
    let HyzonDrayage = Prefixed_Name(holy, "HyzonDrayage") |> PrefixedName
    /// <summary>
    ///   <para>holy:Iceland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Iceland</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Iceland">http://purl.org/holy/ns#Iceland</seealso>
    let Iceland = Prefixed_Name(holy, "Iceland") |> PrefixedName
    /// <summary>
    ///   <para>holy:Indonesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Indonesia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Indonesia">http://purl.org/holy/ns#Indonesia</seealso>
    let Indonesia = Prefixed_Name(holy, "Indonesia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Ivory_Coast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Ivory Coast</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ivory_Coast">http://purl.org/holy/ns#Ivory_Coast</seealso>
    let Ivory_Coast = Prefixed_Name(holy, "Ivory_Coast") |> PrefixedName
    /// <summary>
    ///   <para>holy:Kenya</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Kenya</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Kenya">http://purl.org/holy/ns#Kenya</seealso>
    let Kenya = Prefixed_Name(holy, "Kenya") |> PrefixedName
    /// <summary>
    ///   <para>holy:Laos</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Laos</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Laos">http://purl.org/holy/ns#Laos</seealso>
    let Laos = Prefixed_Name(holy, "Laos") |> PrefixedName
    /// <summary>
    ///   <para>holy:Liberia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Liberia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Liberia">http://purl.org/holy/ns#Liberia</seealso>
    let Liberia = Prefixed_Name(holy, "Liberia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heating</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Heating">http://purl.org/holy/ns#Heating</seealso>
    let Heating = Prefixed_Name(holy, "Heating") |> PrefixedName

    /// <summary>
    ///   <para>holy:MaterialHandlingVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Material Handling Vehicle</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MaterialHandlingVehicle">http://purl.org/holy/ns#MaterialHandlingVehicle</seealso>
    let MaterialHandlingVehicle =
        Prefixed_Name(holy, "MaterialHandlingVehicle") |> PrefixedName

    /// <summary>
    ///   <para>holy:Algeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Algeria</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Algeria">http://purl.org/holy/ns#Algeria</seealso>
    let Algeria = Prefixed_Name(holy, "Algeria") |> PrefixedName
    /// <summary>
    ///   <para>holy:India</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>India</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#India">http://purl.org/holy/ns#India</seealso>
    let India = Prefixed_Name(holy, "India") |> PrefixedName
    /// <summary>
    ///   <para>holy:Iran</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Iran</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Iran">http://purl.org/holy/ns#Iran</seealso>
    let Iran = Prefixed_Name(holy, "Iran") |> PrefixedName
    /// <summary>
    ///   <para>holy:Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Italy</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Italy">http://purl.org/holy/ns#Italy</seealso>
    let Italy = Prefixed_Name(holy, "Italy") |> PrefixedName
    /// <summary>
    ///   <para>holy:Jamaica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Jamaica</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Jamaica">http://purl.org/holy/ns#Jamaica</seealso>
    let Jamaica = Prefixed_Name(holy, "Jamaica") |> PrefixedName
    /// <summary>
    ///   <para>holy:Jordan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Jordan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Jordan">http://purl.org/holy/ns#Jordan</seealso>
    let Jordan = Prefixed_Name(holy, "Jordan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Kuwait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Kuwait</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Kuwait">http://purl.org/holy/ns#Kuwait</seealso>
    let Kuwait = Prefixed_Name(holy, "Kuwait") |> PrefixedName
    /// <summary>
    ///   <para>holy:Kyrgyzstan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Kyrgyzstan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Kyrgyzstan">http://purl.org/holy/ns#Kyrgyzstan</seealso>
    let Kyrgyzstan = Prefixed_Name(holy, "Kyrgyzstan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Lebanon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Lebanon</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Lebanon">http://purl.org/holy/ns#Lebanon</seealso>
    let Lebanon = Prefixed_Name(holy, "Lebanon") |> PrefixedName
    /// <summary>
    ///   <para>holy:Lesotho</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Lesotho</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Lesotho">http://purl.org/holy/ns#Lesotho</seealso>
    let Lesotho = Prefixed_Name(holy, "Lesotho") |> PrefixedName
    /// <summary>
    ///   <para>holy:CryogenicPistonPump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenStorage</para>
    ///
    /// labels<para>Cryogenic piston pump</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CryogenicPistonPump">http://purl.org/holy/ns#CryogenicPistonPump</seealso>
    let CryogenicPistonPump = Prefixed_Name(holy, "CryogenicPistonPump") |> PrefixedName
    /// <summary>
    ///   <para>holy:IonicCompressor50</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:HydrogenStorage</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ionic Compressor 50</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#IonicCompressor50">http://purl.org/holy/ns#IonicCompressor50</seealso>
    let IonicCompressor50 = Prefixed_Name(holy, "IonicCompressor50") |> PrefixedName
    /// <summary>
    ///   <para>holy:Madagascar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Madagascar</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Madagascar">http://purl.org/holy/ns#Madagascar</seealso>
    let Madagascar = Prefixed_Name(holy, "Madagascar") |> PrefixedName
    /// <summary>
    ///   <para>holy:Malta</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Malta</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Malta">http://purl.org/holy/ns#Malta</seealso>
    let Malta = Prefixed_Name(holy, "Malta") |> PrefixedName
    /// <summary>
    ///   <para>holy:Marshall_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Marshall Islands</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Marshall_Islands">http://purl.org/holy/ns#Marshall_Islands</seealso>
    let Marshall_Islands = Prefixed_Name(holy, "Marshall_Islands") |> PrefixedName
    /// <summary>
    ///   <para>holy:Montenegro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Montenegro</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Montenegro">http://purl.org/holy/ns#Montenegro</seealso>
    let Montenegro = Prefixed_Name(holy, "Montenegro") |> PrefixedName
    /// <summary>
    ///   <para>holy:Morocco</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Morocco</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Morocco">http://purl.org/holy/ns#Morocco</seealso>
    let Morocco = Prefixed_Name(holy, "Morocco") |> PrefixedName
    /// <summary>
    ///   <para>holy:Nicaragua</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Nicaragua</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Nicaragua">http://purl.org/holy/ns#Nicaragua</seealso>
    let Nicaragua = Prefixed_Name(holy, "Nicaragua") |> PrefixedName
    /// <summary>
    ///   <para>holy:Niger</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Niger</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Niger">http://purl.org/holy/ns#Niger</seealso>
    let Niger = Prefixed_Name(holy, "Niger") |> PrefixedName
    /// <summary>
    ///   <para>holy:Palau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Palau</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Palau">http://purl.org/holy/ns#Palau</seealso>
    let Palau = Prefixed_Name(holy, "Palau") |> PrefixedName
    /// <summary>
    ///   <para>holy:Panama</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Panama</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Panama">http://purl.org/holy/ns#Panama</seealso>
    let Panama = Prefixed_Name(holy, "Panama") |> PrefixedName

    /// <summary>
    ///   <para>holy:GenSureFuelCellSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenReconversion</para>
    ///
    /// labels<para>GenSure fuel cell system</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#GenSureFuelCellSystem">http://purl.org/holy/ns#GenSureFuelCellSystem</seealso>
    let GenSureFuelCellSystem =
        Prefixed_Name(holy, "GenSureFuelCellSystem") |> PrefixedName

    /// <summary>
    ///   <para>holy:Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Poland</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Poland">http://purl.org/holy/ns#Poland</seealso>
    let Poland = Prefixed_Name(holy, "Poland") |> PrefixedName
    /// <summary>
    ///   <para>holy:Qatar</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Qatar</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Qatar">http://purl.org/holy/ns#Qatar</seealso>
    let Qatar = Prefixed_Name(holy, "Qatar") |> PrefixedName
    /// <summary>
    ///   <para>holy:Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Republic of Ireland</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Republic_of_Ireland">http://purl.org/holy/ns#Republic_of_Ireland</seealso>
    let Republic_of_Ireland = Prefixed_Name(holy, "Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>holy:Saint_Kitts_and_Nevis</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Saint Kitts and Nevis</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Saint_Kitts_and_Nevis">http://purl.org/holy/ns#Saint_Kitts_and_Nevis</seealso>
    let Saint_Kitts_and_Nevis =
        Prefixed_Name(holy, "Saint_Kitts_and_Nevis") |> PrefixedName

    /// <summary>
    ///   <para>holy:Saint_Lucia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Saint Lucia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Saint_Lucia">http://purl.org/holy/ns#Saint_Lucia</seealso>
    let Saint_Lucia = Prefixed_Name(holy, "Saint_Lucia") |> PrefixedName

    /// <summary>
    ///   <para>holy:Saint_Vincent_and_the_Grenadines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Saint Vincent and the Grenadines</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Saint_Vincent_and_the_Grenadines">http://purl.org/holy/ns#Saint_Vincent_and_the_Grenadines</seealso>
    let Saint_Vincent_and_the_Grenadines =
        Prefixed_Name(holy, "Saint_Vincent_and_the_Grenadines") |> PrefixedName

    /// <summary>
    ///   <para>holy:Samoa</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Samoa</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Samoa">http://purl.org/holy/ns#Samoa</seealso>
    let Samoa = Prefixed_Name(holy, "Samoa") |> PrefixedName
    /// <summary>
    ///   <para>holy:Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Singapore</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Singapore">http://purl.org/holy/ns#Singapore</seealso>
    let Singapore = Prefixed_Name(holy, "Singapore") |> PrefixedName
    /// <summary>
    ///   <para>holy:Slovakia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Slovakia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Slovakia">http://purl.org/holy/ns#Slovakia</seealso>
    let Slovakia = Prefixed_Name(holy, "Slovakia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Slovenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Slovenia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Slovenia">http://purl.org/holy/ns#Slovenia</seealso>
    let Slovenia = Prefixed_Name(holy, "Slovenia") |> PrefixedName
    /// <summary>
    ///   <para>holy:SolidOxideFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Caution, SOFC`s must not be mixed up with SOEC's (Solid Oxide Electrolyser). SOFC`s are fuel cells using hydrogen as a fuel to generate energy. SOEC's are used for hydrogen generation using the reversed process of an SOFC. For this ontology an SOEC would be a part of the conversion class. However, since conversion is out of scope, SOEC are not mentioned in a class structure under the subclass "Conversion".</para>
    /// labels<para>Solid Oxide Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SolidOxideFuelCell">http://purl.org/holy/ns#SolidOxideFuelCell</seealso>
    let SolidOxideFuelCell = Prefixed_Name(holy, "SolidOxideFuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:Sri_Lanka</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Sri Lanka</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Sri_Lanka">http://purl.org/holy/ns#Sri_Lanka</seealso>
    let Sri_Lanka = Prefixed_Name(holy, "Sri_Lanka") |> PrefixedName
    /// <summary>
    ///   <para>holy:PowerGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Power Generation</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PowerGeneration">http://purl.org/holy/ns#PowerGeneration</seealso>
    let PowerGeneration = Prefixed_Name(holy, "PowerGeneration") |> PrefixedName
    /// <summary>
    ///   <para>holy:Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Sudan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Sudan">http://purl.org/holy/ns#Sudan</seealso>
    let Sudan = Prefixed_Name(holy, "Sudan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Trucks are categorized in this ontology by distance and not by categories such as size or transportation limit.</para>
    /// labels<para>Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Truck">http://purl.org/holy/ns#Truck</seealso>
    let Truck = Prefixed_Name(holy, "Truck") |> PrefixedName
    /// <summary>
    ///   <para>holy:The_Bahamas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>The Bahamas</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#The_Bahamas">http://purl.org/holy/ns#The_Bahamas</seealso>
    let The_Bahamas = Prefixed_Name(holy, "The_Bahamas") |> PrefixedName
    /// <summary>
    ///   <para>holy:The_Gambia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>The Gambia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#The_Gambia">http://purl.org/holy/ns#The_Gambia</seealso>
    let The_Gambia = Prefixed_Name(holy, "The_Gambia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Tiger_Cub_Economies</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Tiger Cub Economies</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Tiger_Cub_Economies">http://purl.org/holy/ns#Tiger_Cub_Economies</seealso>
    let Tiger_Cub_Economies = Prefixed_Name(holy, "Tiger_Cub_Economies") |> PrefixedName
    /// <summary>
    ///   <para>holy:Togo</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Togo</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Togo">http://purl.org/holy/ns#Togo</seealso>
    let Togo = Prefixed_Name(holy, "Togo") |> PrefixedName
    /// <summary>
    ///   <para>holy:Uganda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Uganda</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Uganda">http://purl.org/holy/ns#Uganda</seealso>
    let Uganda = Prefixed_Name(holy, "Uganda") |> PrefixedName
    /// <summary>
    ///   <para>holy:Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Ukraine</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ukraine">http://purl.org/holy/ns#Ukraine</seealso>
    let Ukraine = Prefixed_Name(holy, "Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>holy:United_Arab_Emirates</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>United Arab Emirates</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#United_Arab_Emirates">http://purl.org/holy/ns#United_Arab_Emirates</seealso>
    let United_Arab_Emirates =
        Prefixed_Name(holy, "United_Arab_Emirates") |> PrefixedName

    /// <summary>
    ///   <para>holy:United_States</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>United States</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#United_States">http://purl.org/holy/ns#United_States</seealso>
    let United_States = Prefixed_Name(holy, "United_States") |> PrefixedName
    /// <summary>
    ///   <para>holy:Uruguay</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Uruguay</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Uruguay">http://purl.org/holy/ns#Uruguay</seealso>
    let Uruguay = Prefixed_Name(holy, "Uruguay") |> PrefixedName
    /// <summary>
    ///   <para>holy:Uzbekistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Uzbekistan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Uzbekistan">http://purl.org/holy/ns#Uzbekistan</seealso>
    let Uzbekistan = Prefixed_Name(holy, "Uzbekistan") |> PrefixedName
    /// <summary>
    ///   <para>holy:RegionalTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Regional Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#RegionalTruck">http://purl.org/holy/ns#RegionalTruck</seealso>
    let RegionalTruck = Prefixed_Name(holy, "RegionalTruck") |> PrefixedName
    /// <summary>
    ///   <para>holy:Western_Sahara</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Western Sahara</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Western_Sahara">http://purl.org/holy/ns#Western_Sahara</seealso>
    let Western_Sahara = Prefixed_Name(holy, "Western_Sahara") |> PrefixedName
    /// <summary>
    ///   <para>holy:Yemen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Yemen</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Yemen">http://purl.org/holy/ns#Yemen</seealso>
    let Yemen = Prefixed_Name(holy, "Yemen") |> PrefixedName
    /// <summary>
    ///   <para>holy:Zambia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Zambia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Zambia">http://purl.org/holy/ns#Zambia</seealso>
    let Zambia = Prefixed_Name(holy, "Zambia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Zimbabwe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Zimbabwe</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Zimbabwe">http://purl.org/holy/ns#Zimbabwe</seealso>
    let Zimbabwe = Prefixed_Name(holy, "Zimbabwe") |> PrefixedName

    /// <summary>
    ///   <para>holy:CircularEconomyProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Circular Economy Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CircularEconomyProject">http://purl.org/holy/ns#CircularEconomyProject</seealso>
    let CircularEconomyProject =
        Prefixed_Name(holy, "CircularEconomyProject") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenProductComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hydrogen Product Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenProductComponent">http://purl.org/holy/ns#HydrogenProductComponent</seealso>
    let HydrogenProductComponent =
        Prefixed_Name(holy, "HydrogenProductComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/holy/ns#">http://purl.org/holy/ns#</seealso>
    let _prefix_iri = Prefixed_Name(holy, "") |> PrefixedName
    /// <summary>
    ///   <para>holy:A12FuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Bus</para>
    ///
    /// labels<para>A12 Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#A12FuelCell">http://purl.org/holy/ns#A12FuelCell</seealso>
    let A12FuelCell = Prefixed_Name(holy, "A12FuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:A13FuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Bus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>A13 Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#A13FuelCell">http://purl.org/holy/ns#A13FuelCell</seealso>
    let A13FuelCell = Prefixed_Name(holy, "A13FuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Continent</para>
    ///
    /// labels<para>Africa</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Africa">http://purl.org/holy/ns#Africa</seealso>
    let Africa = Prefixed_Name(holy, "Africa") |> PrefixedName
    /// <summary>
    ///   <para>holy:providesApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The inverse of holy:isProvidedBy</para>
    /// labels<para>provides Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#providesApplication">http://purl.org/holy/ns#providesApplication</seealso>
    let providesApplication = Prefixed_Name(holy, "providesApplication") |> PrefixedName
    /// <summary>
    ///   <para>holy:Mozambique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Mozambique</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Mozambique">http://purl.org/holy/ns#Mozambique</seealso>
    let Mozambique = Prefixed_Name(holy, "Mozambique") |> PrefixedName
    /// <summary>
    ///   <para>holy:Hydroflex</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PassengerTrain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/holy/ns#Hydroflex">http://purl.org/holy/ns#Hydroflex</seealso>
    let Hydroflex = Prefixed_Name(holy, "Hydroflex") |> PrefixedName
    /// <summary>
    ///   <para>holy:Ambazonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ambazonia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ambazonia">http://purl.org/holy/ns#Ambazonia</seealso>
    let Ambazonia = Prefixed_Name(holy, "Ambazonia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Solomon_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Solomon Islands</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Solomon_Islands">http://purl.org/holy/ns#Solomon_Islands</seealso>
    let Solomon_Islands = Prefixed_Name(holy, "Solomon_Islands") |> PrefixedName
    /// <summary>
    ///   <para>holy:South_Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>South Sudan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#South_Sudan">http://purl.org/holy/ns#South_Sudan</seealso>
    let South_Sudan = Prefixed_Name(holy, "South_Sudan") |> PrefixedName

    /// <summary>
    ///   <para>holy:SubstituteFuelCellComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Substitute Fuel Cell Component" could be expanded to focus on substitute fuel cells. </para>
    /// labels<para>Substitute Fuel Cell Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SubstituteFuelCellComponent">http://purl.org/holy/ns#SubstituteFuelCellComponent</seealso>
    let SubstituteFuelCellComponent =
        Prefixed_Name(holy, "SubstituteFuelCellComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:Oceania</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Continent</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Oceania</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Oceania">http://purl.org/holy/ns#Oceania</seealso>
    let Oceania = Prefixed_Name(holy, "Oceania") |> PrefixedName
    /// <summary>
    ///   <para>holy:Andorra</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Andorra</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Andorra">http://purl.org/holy/ns#Andorra</seealso>
    let Andorra = Prefixed_Name(holy, "Andorra") |> PrefixedName

    /// <summary>
    ///   <para>holy:EnergySectorOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy Sector Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#EnergySectorOrganization">http://purl.org/holy/ns#EnergySectorOrganization</seealso>
    let EnergySectorOrganization =
        Prefixed_Name(holy, "EnergySectorOrganization") |> PrefixedName

    /// <summary>
    ///   <para>holy:hasOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#hasOrganization">http://purl.org/holy/ns#hasOrganization</seealso>
    let hasOrganization = Prefixed_Name(holy, "hasOrganization") |> PrefixedName
    /// <summary>
    ///   <para>holy:Angola</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Angola</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Angola">http://purl.org/holy/ns#Angola</seealso>
    let Angola = Prefixed_Name(holy, "Angola") |> PrefixedName
    /// <summary>
    ///   <para>holy:Antigua_and_Barbuda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Antigua and Barbuda</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Antigua_and_Barbuda">http://purl.org/holy/ns#Antigua_and_Barbuda</seealso>
    let Antigua_and_Barbuda = Prefixed_Name(holy, "Antigua_and_Barbuda") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bahrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Bahrain</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bahrain">http://purl.org/holy/ns#Bahrain</seealso>
    let Bahrain = Prefixed_Name(holy, "Bahrain") |> PrefixedName
    /// <summary>
    ///   <para>holy:Barbados</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Barbados</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Barbados">http://purl.org/holy/ns#Barbados</seealso>
    let Barbados = Prefixed_Name(holy, "Barbados") |> PrefixedName
    /// <summary>
    ///   <para>holy:Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Belgium</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Belgium">http://purl.org/holy/ns#Belgium</seealso>
    let Belgium = Prefixed_Name(holy, "Belgium") |> PrefixedName

    /// <summary>
    ///   <para>holy:Bosnia_and_Herzegovina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Bosnia and Herzegovina</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bosnia_and_Herzegovina">http://purl.org/holy/ns#Bosnia_and_Herzegovina</seealso>
    let Bosnia_and_Herzegovina =
        Prefixed_Name(holy, "Bosnia_and_Herzegovina") |> PrefixedName

    /// <summary>
    ///   <para>holy:Brunei</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Brunei</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Brunei">http://purl.org/holy/ns#Brunei</seealso>
    let Brunei = Prefixed_Name(holy, "Brunei") |> PrefixedName
    /// <summary>
    ///   <para>holy:Cape_Verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Cape Verde</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Cape_Verde">http://purl.org/holy/ns#Cape_Verde</seealso>
    let Cape_Verde = Prefixed_Name(holy, "Cape_Verde") |> PrefixedName
    /// <summary>
    ///   <para>holy:Chad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Chad</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Chad">http://purl.org/holy/ns#Chad</seealso>
    let Chad = Prefixed_Name(holy, "Chad") |> PrefixedName
    /// <summary>
    ///   <para>holy:China</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>China</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#China">http://purl.org/holy/ns#China</seealso>
    let China = Prefixed_Name(holy, "China") |> PrefixedName
    /// <summary>
    ///   <para>holy:Cook_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Cook Islands</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Cook_Islands">http://purl.org/holy/ns#Cook_Islands</seealso>
    let Cook_Islands = Prefixed_Name(holy, "Cook_Islands") |> PrefixedName
    /// <summary>
    ///   <para>holy:Costa_Rica</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Costa Rica</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Costa_Rica">http://purl.org/holy/ns#Costa_Rica</seealso>
    let Costa_Rica = Prefixed_Name(holy, "Costa_Rica") |> PrefixedName

    /// <summary>
    ///   <para>holy:Democratic_Republic_of_the_Congo</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Democratic Republic of the Congo</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Democratic_Republic_of_the_Congo">http://purl.org/holy/ns#Democratic_Republic_of_the_Congo</seealso>
    let Democratic_Republic_of_the_Congo =
        Prefixed_Name(holy, "Democratic_Republic_of_the_Congo") |> PrefixedName

    /// <summary>
    ///   <para>holy:MethanolFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Methanol Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MethanolFuelCell">http://purl.org/holy/ns#MethanolFuelCell</seealso>
    let MethanolFuelCell = Prefixed_Name(holy, "MethanolFuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:Djibouti</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Djibouti</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Djibouti">http://purl.org/holy/ns#Djibouti</seealso>
    let Djibouti = Prefixed_Name(holy, "Djibouti") |> PrefixedName
    /// <summary>
    ///   <para>holy:Egypt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Egypt</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Egypt">http://purl.org/holy/ns#Egypt</seealso>
    let Egypt = Prefixed_Name(holy, "Egypt") |> PrefixedName
    /// <summary>
    ///   <para>holy:El_Salvador</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>El Salvador</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#El_Salvador">http://purl.org/holy/ns#El_Salvador</seealso>
    let El_Salvador = Prefixed_Name(holy, "El_Salvador") |> PrefixedName
    /// <summary>
    ///   <para>holy:Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Estonia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Estonia">http://purl.org/holy/ns#Estonia</seealso>
    let Estonia = Prefixed_Name(holy, "Estonia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Eswatini</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Eswatini</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Eswatini">http://purl.org/holy/ns#Eswatini</seealso>
    let Eswatini = Prefixed_Name(holy, "Eswatini") |> PrefixedName

    /// <summary>
    ///   <para>holy:PublicAdministrationAndDefenseOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Public Administration and Defense Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PublicAdministrationAndDefenseOrganization">http://purl.org/holy/ns#PublicAdministrationAndDefenseOrganization</seealso>
    let PublicAdministrationAndDefenseOrganization =
        Prefixed_Name(holy, "PublicAdministrationAndDefenseOrganization") |> PrefixedName

    /// <summary>
    ///   <para>holy:Ceres_Power_Holding</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ceres Power Holding</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ceres_Power_Holding">http://purl.org/holy/ns#Ceres_Power_Holding</seealso>
    let Ceres_Power_Holding = Prefixed_Name(holy, "Ceres_Power_Holding") |> PrefixedName
    /// <summary>
    ///   <para>holy:SteelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:SolidOxideFuelCell</para>
    ///
    /// labels<para>SteelCell®</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SteelCell">http://purl.org/holy/ns#SteelCell</seealso>
    let SteelCell = Prefixed_Name(holy, "SteelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:IndustrialProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Industrial Processing</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#IndustrialProcessing">http://purl.org/holy/ns#IndustrialProcessing</seealso>
    let IndustrialProcessing =
        Prefixed_Name(holy, "IndustrialProcessing") |> PrefixedName

    /// <summary>
    ///   <para>holy:CruiseShip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cruise Ship</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CruiseShip">http://purl.org/holy/ns#CruiseShip</seealso>
    let CruiseShip = Prefixed_Name(holy, "CruiseShip") |> PrefixedName
    /// <summary>
    ///   <para>holy:ECTOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:InfrastructureProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ECTOS</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ECTOS">http://purl.org/holy/ns#ECTOS</seealso>
    let ECTOS = Prefixed_Name(holy, "ECTOS") |> PrefixedName
    /// <summary>
    ///   <para>holy:EntryBarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entry Barrier</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#EntryBarrier">http://purl.org/holy/ns#EntryBarrier</seealso>
    let EntryBarrier = Prefixed_Name(holy, "EntryBarrier") |> PrefixedName
    /// <summary>
    ///   <para>holy:Indicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class defined to list certain market indicators of the hydrogen domain.</para>
    /// labels<para>Indicator</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Indicator">http://purl.org/holy/ns#Indicator</seealso>
    let Indicator = Prefixed_Name(holy, "Indicator") |> PrefixedName
    /// <summary>
    ///   <para>holy:PlannedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Planned Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PlannedProject">http://purl.org/holy/ns#PlannedProject</seealso>
    let PlannedProject = Prefixed_Name(holy, "PlannedProject") |> PrefixedName
    /// <summary>
    ///   <para>holy:PowerConditioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Power Conditioner</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PowerConditioner">http://purl.org/holy/ns#PowerConditioner</seealso>
    let PowerConditioner = Prefixed_Name(holy, "PowerConditioner") |> PrefixedName

    /// <summary>
    ///   <para>holy:ResearchOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Research Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ResearchOrganization">http://purl.org/holy/ns#ResearchOrganization</seealso>
    let ResearchOrganization =
        Prefixed_Name(holy, "ResearchOrganization") |> PrefixedName

    /// <summary>
    ///   <para>holy:Revenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Revenue</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Revenue">http://purl.org/holy/ns#Revenue</seealso>
    let Revenue = Prefixed_Name(holy, "Revenue") |> PrefixedName
    /// <summary>
    ///   <para>holy:SolidStateBattery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Solid State Battery</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SolidStateBattery">http://purl.org/holy/ns#SolidStateBattery</seealso>
    let SolidStateBattery = Prefixed_Name(holy, "SolidStateBattery") |> PrefixedName
    /// <summary>
    ///   <para>holy:Spacecraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Spacecraft</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Spacecraft">http://purl.org/holy/ns#Spacecraft</seealso>
    let Spacecraft = Prefixed_Name(holy, "Spacecraft") |> PrefixedName

    /// <summary>
    ///   <para>holy:StandUpCounterbalancedTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///
    /// labels<para>Stand-Up Counterbalanced Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#StandUpCounterbalancedTruck">http://purl.org/holy/ns#StandUpCounterbalancedTruck</seealso>
    let StandUpCounterbalancedTruck =
        Prefixed_Name(holy, "StandUpCounterbalancedTruck") |> PrefixedName

    /// <summary>
    ///   <para>holy:StandUpReachTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///
    /// labels<para>Stand-Up Reach Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#StandUpReachTruck">http://purl.org/holy/ns#StandUpReachTruck</seealso>
    let StandUpReachTruck = Prefixed_Name(holy, "StandUpReachTruck") |> PrefixedName

    /// <summary>
    ///   <para>holy:SteelIndustrialProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Steel Industrial Processing</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SteelIndustrialProcessing">http://purl.org/holy/ns#SteelIndustrialProcessing</seealso>
    let SteelIndustrialProcessing =
        Prefixed_Name(holy, "SteelIndustrialProcessing") |> PrefixedName

    /// <summary>
    ///   <para>holy:Submarine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Submarine</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Submarine">http://purl.org/holy/ns#Submarine</seealso>
    let Submarine = Prefixed_Name(holy, "Submarine") |> PrefixedName

    /// <summary>
    ///   <para>holy:TransportationAndStorageOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Transportation And Storage Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#TransportationAndStorageOrganization">http://purl.org/holy/ns#TransportationAndStorageOrganization</seealso>
    let TransportationAndStorageOrganization =
        Prefixed_Name(holy, "TransportationAndStorageOrganization") |> PrefixedName

    /// <summary>
    ///   <para>holy:Trend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Trend</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Trend">http://purl.org/holy/ns#Trend</seealso>
    let Trend = Prefixed_Name(holy, "Trend") |> PrefixedName
    /// <summary>
    ///   <para>holy:Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Continent</para>
    ///
    /// labels<para>Asia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Asia">http://purl.org/holy/ns#Asia</seealso>
    let Asia = Prefixed_Name(holy, "Asia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Azerbaijan</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Azerbaijan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Azerbaijan">http://purl.org/holy/ns#Azerbaijan</seealso>
    let Azerbaijan = Prefixed_Name(holy, "Azerbaijan") |> PrefixedName

    /// <summary>
    ///   <para>holy:InternationalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>International Organization</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#InternationalOrganization">http://purl.org/holy/ns#InternationalOrganization</seealso>
    let InternationalOrganization =
        Prefixed_Name(holy, "InternationalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>holy:Argentina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Argentina</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Argentina">http://purl.org/holy/ns#Argentina</seealso>
    let Argentina = Prefixed_Name(holy, "Argentina") |> PrefixedName
    /// <summary>
    ///   <para>holy:Austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Austria</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Austria">http://purl.org/holy/ns#Austria</seealso>
    let Austria = Prefixed_Name(holy, "Austria") |> PrefixedName
    /// <summary>
    ///   <para>holy:A18FuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Bus</para>
    ///
    /// labels<para>A18 Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#A18FuelCell">http://purl.org/holy/ns#A18FuelCell</seealso>
    let A18FuelCell = Prefixed_Name(holy, "A18FuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:AirCompressor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Air Compressor</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AirCompressor">http://purl.org/holy/ns#AirCompressor</seealso>
    let AirCompressor = Prefixed_Name(holy, "AirCompressor") |> PrefixedName
    /// <summary>
    ///   <para>holy:AviaticApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Aviatic Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AviaticApplication">http://purl.org/holy/ns#AviaticApplication</seealso>
    let AviaticApplication = Prefixed_Name(holy, "AviaticApplication") |> PrefixedName
    /// <summary>
    ///   <para>holy:MarketShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Market Share</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MarketShare">http://purl.org/holy/ns#MarketShare</seealso>
    let MarketShare = Prefixed_Name(holy, "MarketShare") |> PrefixedName
    /// <summary>
    ///   <para>holy:MarketSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Market Size</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MarketSize">http://purl.org/holy/ns#MarketSize</seealso>
    let MarketSize = Prefixed_Name(holy, "MarketSize") |> PrefixedName
    /// <summary>
    ///   <para>holy:Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Australia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Australia">http://purl.org/holy/ns#Australia</seealso>
    let Australia = Prefixed_Name(holy, "Australia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bangladesh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Bangladesh</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bangladesh">http://purl.org/holy/ns#Bangladesh</seealso>
    let Bangladesh = Prefixed_Name(holy, "Bangladesh") |> PrefixedName
    /// <summary>
    ///   <para>holy:Belize</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Belize</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Belize">http://purl.org/holy/ns#Belize</seealso>
    let Belize = Prefixed_Name(holy, "Belize") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bhutan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Bhutan</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bhutan">http://purl.org/holy/ns#Bhutan</seealso>
    let Bhutan = Prefixed_Name(holy, "Bhutan") |> PrefixedName
    /// <summary>
    ///   <para>holy:Botswana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Botswana</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Botswana">http://purl.org/holy/ns#Botswana</seealso>
    let Botswana = Prefixed_Name(holy, "Botswana") |> PrefixedName
    /// <summary>
    ///   <para>holy:hasApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///
    /// labels<para>has Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#hasApplication">http://purl.org/holy/ns#hasApplication</seealso>
    let hasApplication = Prefixed_Name(holy, "hasApplication") |> PrefixedName
    /// <summary>
    ///   <para>holy:Aircraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Aircraft</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Aircraft">http://purl.org/holy/ns#Aircraft</seealso>
    let Aircraft = Prefixed_Name(holy, "Aircraft") |> PrefixedName
    /// <summary>
    ///   <para>holy:Brazil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Brazil</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Brazil">http://purl.org/holy/ns#Brazil</seealso>
    let Brazil = Prefixed_Name(holy, "Brazil") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Bulgaria</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bulgaria">http://purl.org/holy/ns#Bulgaria</seealso>
    let Bulgaria = Prefixed_Name(holy, "Bulgaria") |> PrefixedName
    /// <summary>
    ///   <para>holy:Burundi</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Burundi</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Burundi">http://purl.org/holy/ns#Burundi</seealso>
    let Burundi = Prefixed_Name(holy, "Burundi") |> PrefixedName
    /// <summary>
    ///   <para>holy:Colombia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Colombia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Colombia">http://purl.org/holy/ns#Colombia</seealso>
    let Colombia = Prefixed_Name(holy, "Colombia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Cuba</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Cuba</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Cuba">http://purl.org/holy/ns#Cuba</seealso>
    let Cuba = Prefixed_Name(holy, "Cuba") |> PrefixedName
    /// <summary>
    ///   <para>holy:Czech_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Czech Republic</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Czech_Republic">http://purl.org/holy/ns#Czech_Republic</seealso>
    let Czech_Republic = Prefixed_Name(holy, "Czech_Republic") |> PrefixedName
    /// <summary>
    ///   <para>holy:Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Denmark</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Denmark">http://purl.org/holy/ns#Denmark</seealso>
    let Denmark = Prefixed_Name(holy, "Denmark") |> PrefixedName
    /// <summary>
    ///   <para>holy:Dominican_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Dominican Republic</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Dominican_Republic">http://purl.org/holy/ns#Dominican_Republic</seealso>
    let Dominican_Republic = Prefixed_Name(holy, "Dominican_Republic") |> PrefixedName
    /// <summary>
    ///   <para>holy:Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Germany</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Germany">http://purl.org/holy/ns#Germany</seealso>
    let Germany = Prefixed_Name(holy, "Germany") |> PrefixedName
    /// <summary>
    ///   <para>holy:Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Continent</para>
    ///
    /// labels<para>Europe</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Europe">http://purl.org/holy/ns#Europe</seealso>
    let Europe = Prefixed_Name(holy, "Europe") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bike</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bike">http://purl.org/holy/ns#Bike</seealso>
    let Bike = Prefixed_Name(holy, "Bike") |> PrefixedName
    /// <summary>
    ///   <para>holy:Ethiopia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Ethiopia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ethiopia">http://purl.org/holy/ns#Ethiopia</seealso>
    let Ethiopia = Prefixed_Name(holy, "Ethiopia") |> PrefixedName

    /// <summary>
    ///   <para>holy:European_microstates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>European microstates</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#European_microstates">http://purl.org/holy/ns#European_microstates</seealso>
    let European_microstates =
        Prefixed_Name(holy, "European_microstates") |> PrefixedName

    /// <summary>
    ///   <para>holy:Federated_States_of_Micronesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Federated States of Micronesia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Federated_States_of_Micronesia">http://purl.org/holy/ns#Federated_States_of_Micronesia</seealso>
    let Federated_States_of_Micronesia =
        Prefixed_Name(holy, "Federated_States_of_Micronesia") |> PrefixedName

    /// <summary>
    ///   <para>holy:Car</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Car</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Car">http://purl.org/holy/ns#Car</seealso>
    let Car = Prefixed_Name(holy, "Car") |> PrefixedName
    /// <summary>
    ///   <para>holy:Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Finland</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Finland">http://purl.org/holy/ns#Finland</seealso>
    let Finland = Prefixed_Name(holy, "Finland") |> PrefixedName
    /// <summary>
    ///   <para>holy:PickupTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pickup Truck</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PickupTruck">http://purl.org/holy/ns#PickupTruck</seealso>
    let PickupTruck = Prefixed_Name(holy, "PickupTruck") |> PrefixedName
    /// <summary>
    ///   <para>holy:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>participates in</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#participatesIn">http://purl.org/holy/ns#participatesIn</seealso>
    let participatesIn = Prefixed_Name(holy, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>holy:United_Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>United Kingdom</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#United_Kingdom">http://purl.org/holy/ns#United_Kingdom</seealso>
    let United_Kingdom = Prefixed_Name(holy, "United_Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>holy:France</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>France</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#France">http://purl.org/holy/ns#France</seealso>
    let France = Prefixed_Name(holy, "France") |> PrefixedName
    /// <summary>
    ///   <para>holy:FuelCellStack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fuel Cell Stack</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#FuelCellStack">http://purl.org/holy/ns#FuelCellStack</seealso>
    let FuelCellStack = Prefixed_Name(holy, "FuelCellStack") |> PrefixedName
    /// <summary>
    ///   <para>holy:producesProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///
    /// labels<para>produces Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#producesProduct">http://purl.org/holy/ns#producesProduct</seealso>
    let producesProduct = Prefixed_Name(holy, "producesProduct") |> PrefixedName
    /// <summary>
    ///   <para>holy:SureSource3000TM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MoltenCarbonateFuelCell</para>
    ///
    /// labels<para>SureSource 300TM</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SureSource3000TM">http://purl.org/holy/ns#SureSource3000TM</seealso>
    let SureSource3000TM = Prefixed_Name(holy, "SureSource3000TM") |> PrefixedName
    /// <summary>
    ///   <para>holy:SureSource1500TM</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:MoltenCarbonateFuelCell</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>SureSource 1500TM</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SureSource1500TM">http://purl.org/holy/ns#SureSource1500TM</seealso>
    let SureSource1500TM = Prefixed_Name(holy, "SureSource1500TM") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bus</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bus">http://purl.org/holy/ns#Bus</seealso>
    let Bus = Prefixed_Name(holy, "Bus") |> PrefixedName
    /// <summary>
    ///   <para>holy:Gabon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Gabon</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Gabon">http://purl.org/holy/ns#Gabon</seealso>
    let Gabon = Prefixed_Name(holy, "Gabon") |> PrefixedName
    /// <summary>
    ///   <para>holy:Ghana</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ghana</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ghana">http://purl.org/holy/ns#Ghana</seealso>
    let Ghana = Prefixed_Name(holy, "Ghana") |> PrefixedName
    /// <summary>
    ///   <para>holy:Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Greece</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Greece">http://purl.org/holy/ns#Greece</seealso>
    let Greece = Prefixed_Name(holy, "Greece") |> PrefixedName
    /// <summary>
    ///   <para>holy:Grenada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Grenada</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Grenada">http://purl.org/holy/ns#Grenada</seealso>
    let Grenada = Prefixed_Name(holy, "Grenada") |> PrefixedName
    /// <summary>
    ///   <para>holy:Guyana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Guyana</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Guyana">http://purl.org/holy/ns#Guyana</seealso>
    let Guyana = Prefixed_Name(holy, "Guyana") |> PrefixedName
    /// <summary>
    ///   <para>holy:Haiti</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Haiti</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Haiti">http://purl.org/holy/ns#Haiti</seealso>
    let Haiti = Prefixed_Name(holy, "Haiti") |> PrefixedName
    /// <summary>
    ///   <para>holy:Honduras</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Honduras</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Honduras">http://purl.org/holy/ns#Honduras</seealso>
    let Honduras = Prefixed_Name(holy, "Honduras") |> PrefixedName
    /// <summary>
    ///   <para>holy:Train</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Train</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Train">http://purl.org/holy/ns#Train</seealso>
    let Train = Prefixed_Name(holy, "Train") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenReconversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Since reconversion solely happenes for energy creation using fuel cells, "Reconversion" is contributed to fuel cell systems.</para>
    /// labels<para>Hydrogen Reconversion</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenReconversion">http://purl.org/holy/ns#HydrogenReconversion</seealso>
    let HydrogenReconversion =
        Prefixed_Name(holy, "HydrogenReconversion") |> PrefixedName

    /// <summary>
    ///   <para>holy:FossilFuelComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Fossil Fuel Component" could be expanded to focus on the components of fossil fuel products classifying as substitutes for hydrogen products.</para>
    /// labels<para>Fossil Fuel Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#FossilFuelComponent">http://purl.org/holy/ns#FossilFuelComponent</seealso>
    let FossilFuelComponent = Prefixed_Name(holy, "FossilFuelComponent") |> PrefixedName
    /// <summary>
    ///   <para>holy:GasDiffusionLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gas Diffusion Layer</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#GasDiffusionLayer">http://purl.org/holy/ns#GasDiffusionLayer</seealso>
    let GasDiffusionLayer = Prefixed_Name(holy, "GasDiffusionLayer") |> PrefixedName
    /// <summary>
    ///   <para>holy:Gasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gasket</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Gasket">http://purl.org/holy/ns#Gasket</seealso>
    let Gasket = Prefixed_Name(holy, "Gasket") |> PrefixedName
    /// <summary>
    ///   <para>holy:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The connection to "Application" would refer to "realized usage". A product has a creator. However, since technology and product are difficult to distinguish, technology and product will be seen as one class. Since organizations can also buy component parts, the product class has sub-classes containing components for fuel cells.</para>
    /// labels<para>Product</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Product">http://purl.org/holy/ns#Product</seealso>
    let Product = Prefixed_Name(holy, "Product") |> PrefixedName

    /// <summary>
    ///   <para>holy:StationaryApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stationary Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#StationaryApplication">http://purl.org/holy/ns#StationaryApplication</seealso>
    let StationaryApplication =
        Prefixed_Name(holy, "StationaryApplication") |> PrefixedName

    /// <summary>
    ///   <para>holy:Humidifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Humidifier</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Humidifier">http://purl.org/holy/ns#Humidifier</seealso>
    let Humidifier = Prefixed_Name(holy, "Humidifier") |> PrefixedName
    /// <summary>
    ///   <para>holy:HydrogenConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Conversion" can be expanded to focus the domain scope to the creation of hydrogen with respect to the value chain. </para>
    /// labels<para>Hydrogen Conversion</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenConversion">http://purl.org/holy/ns#HydrogenConversion</seealso>
    let HydrogenConversion = Prefixed_Name(holy, "HydrogenConversion") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenConversionComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Hydrogen Conversion Component" could be expanded to focus the domain scope to the transport of hydrogen with respect to the value chain.</para>
    /// labels<para>Hydrogen Conversion Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenConversionComponent">http://purl.org/holy/ns#HydrogenConversionComponent</seealso>
    let HydrogenConversionComponent =
        Prefixed_Name(holy, "HydrogenConversionComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:Belarus</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Belarus</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Belarus">http://purl.org/holy/ns#Belarus</seealso>
    let Belarus = Prefixed_Name(holy, "Belarus") |> PrefixedName
    /// <summary>
    ///   <para>holy:Bolivia</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Bolivia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Bolivia">http://purl.org/holy/ns#Bolivia</seealso>
    let Bolivia = Prefixed_Name(holy, "Bolivia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Burkina_Faso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Burkina Faso</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Burkina_Faso">http://purl.org/holy/ns#Burkina_Faso</seealso>
    let Burkina_Faso = Prefixed_Name(holy, "Burkina_Faso") |> PrefixedName
    /// <summary>
    ///   <para>holy:Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Canada</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Canada">http://purl.org/holy/ns#Canada</seealso>
    let Canada = Prefixed_Name(holy, "Canada") |> PrefixedName

    /// <summary>
    ///   <para>holy:Central_African_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Central African Republic</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Central_African_Republic">http://purl.org/holy/ns#Central_African_Republic</seealso>
    let Central_African_Republic =
        Prefixed_Name(holy, "Central_African_Republic") |> PrefixedName

    /// <summary>
    ///   <para>holy:Membrane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Membrane</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Membrane">http://purl.org/holy/ns#Membrane</seealso>
    let Membrane = Prefixed_Name(holy, "Membrane") |> PrefixedName

    /// <summary>
    ///   <para>holy:NickelCadmiumBattery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Nickel Cadmium Battery</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#NickelCadmiumBattery">http://purl.org/holy/ns#NickelCadmiumBattery</seealso>
    let NickelCadmiumBattery =
        Prefixed_Name(holy, "NickelCadmiumBattery") |> PrefixedName

    /// <summary>
    ///   <para>holy:NickelMetalHydrideBattery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Nickel Metal Hydride Battery</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#NickelMetalHydrideBattery">http://purl.org/holy/ns#NickelMetalHydrideBattery</seealso>
    let NickelMetalHydrideBattery =
        Prefixed_Name(holy, "NickelMetalHydrideBattery") |> PrefixedName

    /// <summary>
    ///   <para>holy:NorthernPeripheryandArcticProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>org:Organization</para>
    ///
    /// labels<para>Northern Periphery and Arctic Programme</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#NorthernPeripheryandArcticProgramme">http://purl.org/holy/ns#NorthernPeripheryandArcticProgramme</seealso>
    let NorthernPeripheryandArcticProgramme =
        Prefixed_Name(holy, "NorthernPeripheryandArcticProgramme") |> PrefixedName

    /// <summary>
    ///   <para>holy:OngoingProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ongoing Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#OngoingProject">http://purl.org/holy/ns#OngoingProject</seealso>
    let OngoingProject = Prefixed_Name(holy, "OngoingProject") |> PrefixedName
    /// <summary>
    ///   <para>holy:Patent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Patent</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Patent">http://purl.org/holy/ns#Patent</seealso>
    let Patent = Prefixed_Name(holy, "Patent") |> PrefixedName

    /// <summary>
    ///   <para>holy:PhosphoricAcidFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Phosphoric Acid Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PhosphoricAcidFuelCell">http://purl.org/holy/ns#PhosphoricAcidFuelCell</seealso>
    let PhosphoricAcidFuelCell =
        Prefixed_Name(holy, "PhosphoricAcidFuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:Benin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Benin</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Benin">http://purl.org/holy/ns#Benin</seealso>
    let Benin = Prefixed_Name(holy, "Benin") |> PrefixedName

    /// <summary>
    ///   <para>holy:AnionExchangeMembraneFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anion Exchange Membrane Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AnionExchangeMembraneFuelCell">http://purl.org/holy/ns#AnionExchangeMembraneFuelCell</seealso>
    let AnionExchangeMembraneFuelCell =
        Prefixed_Name(holy, "AnionExchangeMembraneFuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Application">http://purl.org/holy/ns#Application</seealso>
    let Application = Prefixed_Name(holy, "Application") |> PrefixedName

    /// <summary>
    ///   <para>holy:AutomatedGuidedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///
    /// labels<para>Automated Guided Vehicle</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AutomatedGuidedVehicle">http://purl.org/holy/ns#AutomatedGuidedVehicle</seealso>
    let AutomatedGuidedVehicle =
        Prefixed_Name(holy, "AutomatedGuidedVehicle") |> PrefixedName

    /// <summary>
    ///   <para>holy:MobileApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mobile Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MobileApplication">http://purl.org/holy/ns#MobileApplication</seealso>
    let MobileApplication = Prefixed_Name(holy, "MobileApplication") |> PrefixedName
    /// <summary>
    ///   <para>holy:BatteryComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Battery Component" can be expanded to focus on batteries as substitutes for hydrogen products. </para>
    /// labels<para>Battery Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#BatteryComponent">http://purl.org/holy/ns#BatteryComponent</seealso>
    let BatteryComponent = Prefixed_Name(holy, "BatteryComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:SubstituteProductComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "Substitute Product Component" could be expanded to focus on substitute products of hydrogen products.</para>
    /// labels<para>Substitute Product Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SubstituteProductComponent">http://purl.org/holy/ns#SubstituteProductComponent</seealso>
    let SubstituteProductComponent =
        Prefixed_Name(holy, "SubstituteProductComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:A330FuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Bus</para>
    ///
    /// labels<para>A330 Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#A330FuelCell">http://purl.org/holy/ns#A330FuelCell</seealso>
    let A330FuelCell = Prefixed_Name(holy, "A330FuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:HydrogenFuelCellComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fuel Cell Component is directly alligned with sub-classes of 'Reconversion'.</para>
    /// labels<para>Hydrogen Fuel Cell Component</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#HydrogenFuelCellComponent">http://purl.org/holy/ns#HydrogenFuelCellComponent</seealso>
    let HydrogenFuelCellComponent =
        Prefixed_Name(holy, "HydrogenFuelCellComponent") |> PrefixedName

    /// <summary>
    ///   <para>holy:AlkalineBattery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alkaline Battery</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AlkalineBattery">http://purl.org/holy/ns#AlkalineBattery</seealso>
    let AlkalineBattery = Prefixed_Name(holy, "AlkalineBattery") |> PrefixedName
    /// <summary>
    ///   <para>holy:Battery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Battery</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Battery">http://purl.org/holy/ns#Battery</seealso>
    let Battery = Prefixed_Name(holy, "Battery") |> PrefixedName
    /// <summary>
    ///   <para>holy:AmmoniaFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ammonia Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#AmmoniaFuelCell">http://purl.org/holy/ns#AmmoniaFuelCell</seealso>
    let AmmoniaFuelCell = Prefixed_Name(holy, "AmmoniaFuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:usesSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>Main Property for holy:usesProduct and holy:usesTechnology.</para>
    /// labels<para>uses Source</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#usesSource">http://purl.org/holy/ns#usesSource</seealso>
    let usesSource = Prefixed_Name(holy, "usesSource") |> PrefixedName
    /// <summary>
    ///   <para>holy:Cambodia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Cambodia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Cambodia">http://purl.org/holy/ns#Cambodia</seealso>
    let Cambodia = Prefixed_Name(holy, "Cambodia") |> PrefixedName
    /// <summary>
    ///   <para>holy:BipolarPlate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bipolar Plate</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#BipolarPlate">http://purl.org/holy/ns#BipolarPlate</seealso>
    let BipolarPlate = Prefixed_Name(holy, "BipolarPlate") |> PrefixedName
    /// <summary>
    ///   <para>holy:SupportiveHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Supportive Hardware</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SupportiveHardware">http://purl.org/holy/ns#SupportiveHardware</seealso>
    let SupportiveHardware = Prefixed_Name(holy, "SupportiveHardware") |> PrefixedName
    /// <summary>
    ///   <para>holy:Cameroon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Cameroon</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Cameroon">http://purl.org/holy/ns#Cameroon</seealso>
    let Cameroon = Prefixed_Name(holy, "Cameroon") |> PrefixedName
    /// <summary>
    ///   <para>holy:Chile</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Chile</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Chile">http://purl.org/holy/ns#Chile</seealso>
    let Chile = Prefixed_Name(holy, "Chile") |> PrefixedName
    /// <summary>
    ///   <para>holy:SubstituteFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subclass "SubstituteFuelCell" could be expanded to focus the domain scope to the creation of hydrogen concerning the value chain.</para>
    /// labels<para>Substitute Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#SubstituteFuelCell">http://purl.org/holy/ns#SubstituteFuelCell</seealso>
    let SubstituteFuelCell = Prefixed_Name(holy, "SubstituteFuelCell") |> PrefixedName
    /// <summary>
    ///   <para>holy:Dominica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Dominica</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Dominica">http://purl.org/holy/ns#Dominica</seealso>
    let Dominica = Prefixed_Name(holy, "Dominica") |> PrefixedName
    /// <summary>
    ///   <para>holy:East_Timor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>East Timor</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#East_Timor">http://purl.org/holy/ns#East_Timor</seealso>
    let East_Timor = Prefixed_Name(holy, "East_Timor") |> PrefixedName
    /// <summary>
    ///   <para>holy:Comoros</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Comoros</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Comoros">http://purl.org/holy/ns#Comoros</seealso>
    let Comoros = Prefixed_Name(holy, "Comoros") |> PrefixedName
    /// <summary>
    ///   <para>holy:Croatia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Croatia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Croatia">http://purl.org/holy/ns#Croatia</seealso>
    let Croatia = Prefixed_Name(holy, "Croatia") |> PrefixedName
    /// <summary>
    ///   <para>holy:Cyprus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Cyprus</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Cyprus">http://purl.org/holy/ns#Cyprus</seealso>
    let Cyprus = Prefixed_Name(holy, "Cyprus") |> PrefixedName
    /// <summary>
    ///   <para>holy:CargoShip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cargo Ship</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CargoShip">http://purl.org/holy/ns#CargoShip</seealso>
    let CargoShip = Prefixed_Name(holy, "CargoShip") |> PrefixedName
    /// <summary>
    ///   <para>holy:MarineApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Marine Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MarineApplication">http://purl.org/holy/ns#MarineApplication</seealso>
    let MarineApplication = Prefixed_Name(holy, "MarineApplication") |> PrefixedName
    /// <summary>
    ///   <para>holy:CargoTrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cargo Train</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CargoTrain">http://purl.org/holy/ns#CargoTrain</seealso>
    let CargoTrain = Prefixed_Name(holy, "CargoTrain") |> PrefixedName
    /// <summary>
    ///   <para>holy:CatalystLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Catalyst Layer</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CatalystLayer">http://purl.org/holy/ns#CatalystLayer</seealso>
    let CatalystLayer = Prefixed_Name(holy, "CatalystLayer") |> PrefixedName

    /// <summary>
    ///   <para>holy:MembraneElectrodeAssembly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Membrane Electrode Assembly</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MembraneElectrodeAssembly">http://purl.org/holy/ns#MembraneElectrodeAssembly</seealso>
    let MembraneElectrodeAssembly =
        Prefixed_Name(holy, "MembraneElectrodeAssembly") |> PrefixedName

    /// <summary>
    ///   <para>holy:ChemicalIndustrialProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hydrogen is one of the key starting materials used in the chemical industry. It is a fundamental building block for the manufacturing of ammonia, fertilizers, and  methanol, which is used in the manufacture of many polymers.</para>
    /// labels<para>Chemical Industrial Processing</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#ChemicalIndustrialProcessing">http://purl.org/holy/ns#ChemicalIndustrialProcessing</seealso>
    let ChemicalIndustrialProcessing =
        Prefixed_Name(holy, "ChemicalIndustrialProcessing") |> PrefixedName

    /// <summary>
    ///   <para>holy:PurposeBasedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Purpose-based Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#PurposeBasedProject">http://purl.org/holy/ns#PurposeBasedProject</seealso>
    let PurposeBasedProject = Prefixed_Name(holy, "PurposeBasedProject") |> PrefixedName
    /// <summary>
    ///   <para>holy:hasProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#hasProject">http://purl.org/holy/ns#hasProject</seealso>
    let hasProject = Prefixed_Name(holy, "hasProject") |> PrefixedName

    /// <summary>
    ///   <para>holy:MoltenCarbonateFuelCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Molten Carbonate Fuel Cell</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#MoltenCarbonateFuelCell">http://purl.org/holy/ns#MoltenCarbonateFuelCell</seealso>
    let MoltenCarbonateFuelCell =
        Prefixed_Name(holy, "MoltenCarbonateFuelCell") |> PrefixedName

    /// <summary>
    ///   <para>holy:CUTE</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:InfrastructureProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>CUTE</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#CUTE">http://purl.org/holy/ns#CUTE</seealso>
    let CUTE = Prefixed_Name(holy, "CUTE") |> PrefixedName

    /// <summary>
    ///   <para>holy:relatesToApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>relates to Application</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#relatesToApplication">http://purl.org/holy/ns#relatesToApplication</seealso>
    let relatesToApplication =
        Prefixed_Name(holy, "relatesToApplication") |> PrefixedName

    /// <summary>
    ///   <para>holy:InfrastructureProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Infrastructure Project</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#InfrastructureProject">http://purl.org/holy/ns#InfrastructureProject</seealso>
    let InfrastructureProject =
        Prefixed_Name(holy, "InfrastructureProject") |> PrefixedName

    /// <summary>
    ///   <para>holy:Ecuador</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ecuador</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Ecuador">http://purl.org/holy/ns#Ecuador</seealso>
    let Ecuador = Prefixed_Name(holy, "Ecuador") |> PrefixedName
    /// <summary>
    ///   <para>holy:Equatorial_Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Equatorial Guinea</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Equatorial_Guinea">http://purl.org/holy/ns#Equatorial_Guinea</seealso>
    let Equatorial_Guinea = Prefixed_Name(holy, "Equatorial_Guinea") |> PrefixedName
    /// <summary>
    ///   <para>holy:Eritrea</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Eritrea</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Eritrea">http://purl.org/holy/ns#Eritrea</seealso>
    let Eritrea = Prefixed_Name(holy, "Eritrea") |> PrefixedName

    /// <summary>
    ///   <para>holy:NationalInnovationProgrammeHydrogenandFuelCellTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Project</para>
    ///
    /// labels<para>National Innovation Programme Hydrogen and Fuel Cell Technology</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#NationalInnovationProgrammeHydrogenandFuelCellTechnology">http://purl.org/holy/ns#NationalInnovationProgrammeHydrogenandFuelCellTechnology</seealso>
    let NationalInnovationProgrammeHydrogenandFuelCellTechnology =
        Prefixed_Name(holy, "NationalInnovationProgrammeHydrogenandFuelCellTechnology") |> PrefixedName

    /// <summary>
    ///   <para>holy:Fiji</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Fiji</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Fiji">http://purl.org/holy/ns#Fiji</seealso>
    let Fiji = Prefixed_Name(holy, "Fiji") |> PrefixedName
    /// <summary>
    ///   <para>holy:Armenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Country</para>
    ///
    /// labels<para>Armenia</para></remarks>
    /// <seealso href="http://purl.org/holy/ns#Armenia">http://purl.org/holy/ns#Armenia</seealso>
    let Armenia = Prefixed_Name(holy, "Armenia") |> PrefixedName
