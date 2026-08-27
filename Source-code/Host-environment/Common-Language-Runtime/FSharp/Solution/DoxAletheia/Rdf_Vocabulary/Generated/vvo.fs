namespace http.purl.org.vvo.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vvo =
    let _namespace_iri = Namespace_Iri vvo |> NamespaceIRI
    /// <summary>
    ///   <para>vvo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"VVO: The Volkswagen Vehicles Ontology
    ///
    /// A vocabulary for describing Volkswagen-specific features of automobiles and their components
    ///
    /// Vocabulary:    http://purl.org/vvo/ns
    /// Namespace:     http://purl.org/vvo/ns#
    ///
    ///
    /// The vocabulary is designed to be used in combination with
    /// (1) GoodRelations, a standard vocabulary for the commercial aspects of offers for sale, rental, repair, or disposal;
    /// (2) the Vehicle Sales Ontology, a standard vocabulary for cars and other vehicles; and
    /// (3) the Car Options Ontology, a standard vocabulary for buildability / configuration information for cars.
    ///
    /// See http://purl.org/goodrelations/ for more information."</para>
    /// labels<para>"Volkswagen Vehicles Ontology"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#">http://purl.org/vvo/ns#</seealso>
    let _prefix_iri = Prefixed_Name(vvo, "") |> PrefixedName
    /// <summary>
    ///   <para>vvo:AudioAndNavigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of audio and navigation choices or components (CD/DVD/SatNav, a "MonoSelectGroup" in automotive terminology), VW ID: 1"</para>
    /// labels<para>"Audio and Navigation Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#AudioAndNavigation">http://purl.org/vvo/ns#AudioAndNavigation</seealso>
    let AudioAndNavigation = Prefixed_Name(vvo, "AudioAndNavigation") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Automobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vvo/ns#Automobile">http://purl.org/vvo/ns#Automobile</seealso>
    let Automobile = Prefixed_Name(vvo, "Automobile") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyle4X4</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Four-by-Four Vehicle, VW ID: 6"</para>
    /// labels<para>"4 X 4 (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyle4X4">http://purl.org/vvo/ns#BodyStyle4X4</seealso>
    let BodyStyle4X4 = Prefixed_Name(vvo, "BodyStyle4X4") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyleCabriolet</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Cabriolet, VW ID: 4"</para>
    /// labels<para>"Cabriolet (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleCabriolet">http://purl.org/vvo/ns#BodyStyleCabriolet</seealso>
    let BodyStyleCabriolet = Prefixed_Name(vvo, "BodyStyleCabriolet") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyleCoupe</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Coupe, VW ID: 7"</para>
    /// labels<para>"Coupe (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleCoupe">http://purl.org/vvo/ns#BodyStyleCoupe</seealso>
    let BodyStyleCoupe = Prefixed_Name(vvo, "BodyStyleCoupe") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyleEstate</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Estate, VW ID: 3"</para>
    /// labels<para>"Estate (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleEstate">http://purl.org/vvo/ns#BodyStyleEstate</seealso>
    let BodyStyleEstate = Prefixed_Name(vvo, "BodyStyleEstate") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyleHatchback</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Hatchback, VW ID: 1"</para>
    /// labels<para>"Hatchback (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleHatchback">http://purl.org/vvo/ns#BodyStyleHatchback</seealso>
    let BodyStyleHatchback = Prefixed_Name(vvo, "BodyStyleHatchback") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyleMPV</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Multi-purpose Vehicle, VW ID: 5"</para>
    /// labels<para>"MPV (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleMPV">http://purl.org/vvo/ns#BodyStyleMPV</seealso>
    let BodyStyleMPV = Prefixed_Name(vvo, "BodyStyleMPV") |> PrefixedName
    /// <summary>
    ///   <para>vvo:BodyStyleSaloon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Saloon, VW ID: 2"</para>
    /// labels<para>"Saloon (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleSaloon">http://purl.org/vvo/ns#BodyStyleSaloon</seealso>
    let BodyStyleSaloon = Prefixed_Name(vvo, "BodyStyleSaloon") |> PrefixedName

    /// <summary>
    ///   <para>vvo:BodyStyleUnspecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:BodyStyleValue</para>
    ///   <para>"Unspecified, VW ID: 0"</para>
    /// labels<para>"Unspecified (vso:BodyStyleValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#BodyStyleUnspecified">http://purl.org/vvo/ns#BodyStyleUnspecified</seealso>
    let BodyStyleUnspecified =
        Prefixed_Name(vvo, "BodyStyleUnspecified") |> PrefixedName

    /// <summary>
    ///   <para>vvo:Combined</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TrafficPattern</para>
    ///   <para>"Combined usage as a traffic pattern"</para>
    /// labels<para>"Combined (vvo:TrafficPattern)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Combined">http://purl.org/vvo/ns#Combined</seealso>
    let Combined = Prefixed_Name(vvo, "Combined") |> PrefixedName
    /// <summary>
    ///   <para>vvo:DecorativeTrims</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of decorative trim choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 8"</para>
    /// labels<para>"Decorative Trims Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#DecorativeTrims">http://purl.org/vvo/ns#DecorativeTrims</seealso>
    let DecorativeTrims = Prefixed_Name(vvo, "DecorativeTrims") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Diesel</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelTypeValue</para>
    ///   <para>"Diesel, VW ID: 2"</para>
    /// labels<para>"Diesel (vso:FuelTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Diesel">http://purl.org/vvo/ns#Diesel</seealso>
    let Diesel = Prefixed_Name(vvo, "Diesel") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Engine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of engines as choices or components"</para>
    /// labels<para>"Engine Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Engine">http://purl.org/vvo/ns#Engine</seealso>
    let Engine = Prefixed_Name(vvo, "Engine") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Euro1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:EmissionStandardValue</para>
    ///   <para>"The emission standard EURO 1"</para>
    /// labels<para>"Euro 1 (vso:EmissionStandardValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Euro1">http://purl.org/vvo/ns#Euro1</seealso>
    let Euro1 = Prefixed_Name(vvo, "Euro1") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Euro2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:EmissionStandardValue</para>
    ///   <para>"The emission standard EURO 2"</para>
    /// labels<para>"Euro 2 (vso:EmissionStandardValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Euro2">http://purl.org/vvo/ns#Euro2</seealso>
    let Euro2 = Prefixed_Name(vvo, "Euro2") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Euro3</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:EmissionStandardValue</para>
    ///   <para>"The emission standard EURO 3"</para>
    /// labels<para>"Euro 3 (vso:EmissionStandardValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Euro3">http://purl.org/vvo/ns#Euro3</seealso>
    let Euro3 = Prefixed_Name(vvo, "Euro3") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Euro4</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:EmissionStandardValue</para>
    ///   <para>"The emission standard EURO 4"</para>
    /// labels<para>"Euro 4 (vso:EmissionStandardValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Euro4">http://purl.org/vvo/ns#Euro4</seealso>
    let Euro4 = Prefixed_Name(vvo, "Euro4") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Euro5</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:EmissionStandardValue</para>
    ///   <para>"The emission standard EURO 5"</para>
    /// labels<para>"Euro 5 (vso:EmissionStandardValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Euro5">http://purl.org/vvo/ns#Euro5</seealso>
    let Euro5 = Prefixed_Name(vvo, "Euro5") |> PrefixedName
    /// <summary>
    ///   <para>vvo:ExtraUrban</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TrafficPattern</para>
    ///   <para>"Extra urban as a traffic pattern"</para>
    /// labels<para>"ExtraUrban (vvo:TrafficPattern)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#ExtraUrban">http://purl.org/vvo/ns#ExtraUrban</seealso>
    let ExtraUrban = Prefixed_Name(vvo, "ExtraUrban") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Financing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of this class is the specification of a payment option via staged payments."</para>
    /// labels<para>"Financing (gr:PaymentMethod)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Financing">http://purl.org/vvo/ns#Financing</seealso>
    let Financing = Prefixed_Name(vvo, "Financing") |> PrefixedName
    /// <summary>
    ///   <para>vvo:GearboxAutomatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:GearboxTypeValue</para>
    ///   <para>"Automatic gearbox, VW ID: 2"</para>
    /// labels<para>"Automatic (vvo:GearboxTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#GearboxAutomatic">http://purl.org/vvo/ns#GearboxAutomatic</seealso>
    let GearboxAutomatic = Prefixed_Name(vvo, "GearboxAutomatic") |> PrefixedName
    /// <summary>
    ///   <para>vvo:GearboxDSG</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:GearboxTypeValue</para>
    ///   <para>"DSG gearbox, VW ID: 3"</para>
    /// labels<para>"DSG (vvo:GearboxTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#GearboxDSG">http://purl.org/vvo/ns#GearboxDSG</seealso>
    let GearboxDSG = Prefixed_Name(vvo, "GearboxDSG") |> PrefixedName
    /// <summary>
    ///   <para>vvo:GearboxManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:GearboxTypeValue</para>
    ///   <para>"Manual gearbox, VW ID: 1"</para>
    /// labels<para>"Manual (vvo:GearboxTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#GearboxManual">http://purl.org/vvo/ns#GearboxManual</seealso>
    let GearboxManual = Prefixed_Name(vvo, "GearboxManual") |> PrefixedName
    /// <summary>
    ///   <para>vvo:GearboxTypeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value indicating a gearbox type."</para>
    /// labels<para>"Gearbox type value (the class of predefined values)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#GearboxTypeValue">http://purl.org/vvo/ns#GearboxTypeValue</seealso>
    let GearboxTypeValue = Prefixed_Name(vvo, "GearboxTypeValue") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Hybrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelTypeValue</para>
    ///   <para>"Hybrid, VW ID: 3"</para>
    /// labels<para>"Hybrid (vso:FuelTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Hybrid">http://purl.org/vvo/ns#Hybrid</seealso>
    let Hybrid = Prefixed_Name(vvo, "Hybrid") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Paint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of paint choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 3"</para>
    /// labels<para>"Paint Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Paint">http://purl.org/vvo/ns#Paint</seealso>
    let Paint = Prefixed_Name(vvo, "Paint") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Parking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of parking-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 7"</para>
    /// labels<para>"Parking Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Parking">http://purl.org/vvo/ns#Parking</seealso>
    let Parking = Prefixed_Name(vvo, "Parking") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Petrol</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelTypeValue</para>
    ///   <para>"Petrol, VW ID: 1"</para>
    /// labels<para>"Petrol (vso:FuelTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Petrol">http://purl.org/vvo/ns#Petrol</seealso>
    let Petrol = Prefixed_Name(vvo, "Petrol") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Roofs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of roof choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 5"</para>
    /// labels<para>"Roofs Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Roofs">http://purl.org/vvo/ns#Roofs</seealso>
    let Roofs = Prefixed_Name(vvo, "Roofs") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Seats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of seat-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 9"</para>
    /// labels<para>"Seats Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Seats">http://purl.org/vvo/ns#Seats</seealso>
    let Seats = Prefixed_Name(vvo, "Seats") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A service or service model. Typical instances are complementing services for a particular car."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Service">http://purl.org/vvo/ns#Service</seealso>
    let Service = Prefixed_Name(vvo, "Service") |> PrefixedName
    /// <summary>
    ///   <para>vvo:SteeringWheels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of steering wheels choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 6"</para>
    /// labels<para>"Steering Wheels Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#SteeringWheels">http://purl.org/vvo/ns#SteeringWheels</seealso>
    let SteeringWheels = Prefixed_Name(vvo, "SteeringWheels") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TT4SpeedAuto</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"4 Speed auto. VW ID: 1"</para>
    /// labels<para>"4 Speed auto (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT4SpeedAuto">http://purl.org/vvo/ns#TT4SpeedAuto</seealso>
    let TT4SpeedAuto = Prefixed_Name(vvo, "TT4SpeedAuto") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TT5SpeedAutoDSG</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"5 Speed auto DSG, VW ID: 8"</para>
    /// labels<para>"5 Speed auto DSG (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT5SpeedAutoDSG">http://purl.org/vvo/ns#TT5SpeedAutoDSG</seealso>
    let TT5SpeedAutoDSG = Prefixed_Name(vvo, "TT5SpeedAutoDSG") |> PrefixedName

    /// <summary>
    ///   <para>vvo:TT5SpeedAutoTiptronic</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"5 Speed auto tiptronic, VW ID: 3"</para>
    /// labels<para>"5 Speed auto tiptronic (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT5SpeedAutoTiptronic">http://purl.org/vvo/ns#TT5SpeedAutoTiptronic</seealso>
    let TT5SpeedAutoTiptronic =
        Prefixed_Name(vvo, "TT5SpeedAutoTiptronic") |> PrefixedName

    /// <summary>
    ///   <para>vvo:TT5SpeedManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueManual</para>
    ///   <para>"5 Speed manual, VW ID: 2"</para>
    /// labels<para>"5 Speed manual (vvo:TransmissionTypeValueManual)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT5SpeedManual">http://purl.org/vvo/ns#TT5SpeedManual</seealso>
    let TT5SpeedManual = Prefixed_Name(vvo, "TT5SpeedManual") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TT6SpeedAuto</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"6 Speed auto, VW ID: 5"</para>
    /// labels<para>"6 Speed auto (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT6SpeedAuto">http://purl.org/vvo/ns#TT6SpeedAuto</seealso>
    let TT6SpeedAuto = Prefixed_Name(vvo, "TT6SpeedAuto") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TT6SpeedAutoDSG</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"6 Speed auto DSG, VW ID: 6"</para>
    /// labels<para>"6 Speed auto DSG (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT6SpeedAutoDSG">http://purl.org/vvo/ns#TT6SpeedAutoDSG</seealso>
    let TT6SpeedAutoDSG = Prefixed_Name(vvo, "TT6SpeedAutoDSG") |> PrefixedName

    /// <summary>
    ///   <para>vvo:TT6SpeedAutoTiptronic</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"6 Speed auto tiptronic, VW ID: 7"</para>
    /// labels<para>"6 Speed auto tiptronic (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT6SpeedAutoTiptronic">http://purl.org/vvo/ns#TT6SpeedAutoTiptronic</seealso>
    let TT6SpeedAutoTiptronic =
        Prefixed_Name(vvo, "TT6SpeedAutoTiptronic") |> PrefixedName

    /// <summary>
    ///   <para>vvo:TT6SpeedManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueManual</para>
    ///   <para>"6 Speed manual, VW ID: 4"</para>
    /// labels<para>"6 Speed manual (vvo:TransmissionTypeValueManual)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT6SpeedManual">http://purl.org/vvo/ns#TT6SpeedManual</seealso>
    let TT6SpeedManual = Prefixed_Name(vvo, "TT6SpeedManual") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TT7SpeedAutoDSG</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"7 Speed auto DSG, VW ID: 9"</para>
    /// labels<para>"7 Speed auto DSG (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT7SpeedAutoDSG">http://purl.org/vvo/ns#TT7SpeedAutoDSG</seealso>
    let TT7SpeedAutoDSG = Prefixed_Name(vvo, "TT7SpeedAutoDSG") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TT8SpeedAuto</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    ///   <para>"8 Speed auto, VW ID: 10"</para>
    /// labels<para>"8 Speed auto (vvo:TransmissionTypeValueAutomatic)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TT8SpeedAuto">http://purl.org/vvo/ns#TT8SpeedAuto</seealso>
    let TT8SpeedAuto = Prefixed_Name(vvo, "TT8SpeedAuto") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TTUnspecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:TransmissionTypeValue</para>
    ///   <para>"Unspecified, VW ID: 0"</para>
    /// labels<para>"Unspecified (vso:TransmissionTypeValue)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TTUnspecified">http://purl.org/vvo/ns#TTUnspecified</seealso>
    let TTUnspecified = Prefixed_Name(vvo, "TTUnspecified") |> PrefixedName
    /// <summary>
    ///   <para>vvo:TrafficPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value indicating a traffic pattern, to be used as a reference for vso:fuelConsumption or vso:fuelEconomy"</para>
    /// labels<para>"Traffic pattern value (the class of predefined values)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TrafficPattern">http://purl.org/vvo/ns#TrafficPattern</seealso>
    let TrafficPattern = Prefixed_Name(vvo, "TrafficPattern") |> PrefixedName

    /// <summary>
    ///   <para>vvo:TransmissionTypeValueAutomatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of all automatic transmission types"</para>
    /// labels<para>"TransmissionTypeValueAutomatic"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TransmissionTypeValueAutomatic">http://purl.org/vvo/ns#TransmissionTypeValueAutomatic</seealso>
    let TransmissionTypeValueAutomatic =
        Prefixed_Name(vvo, "TransmissionTypeValueAutomatic") |> PrefixedName

    /// <summary>
    ///   <para>vvo:TransmissionTypeValueManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of all manual transmission types"</para>
    /// labels<para>"TransmissionTypeValueManual"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#TransmissionTypeValueManual">http://purl.org/vvo/ns#TransmissionTypeValueManual</seealso>
    let TransmissionTypeValueManual =
        Prefixed_Name(vvo, "TransmissionTypeValueManual") |> PrefixedName

    /// <summary>
    ///   <para>vvo:Upholstery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of upholstery choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 4"</para>
    /// labels<para>"Upholstery Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Upholstery">http://purl.org/vvo/ns#Upholstery</seealso>
    let Upholstery = Prefixed_Name(vvo, "Upholstery") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Urban</para>
    /// </summary>
    /// <remarks>
    ///   <para>vvo:TrafficPattern</para>
    ///   <para>"Urban usage as a traffic pattern"</para>
    /// labels<para>"Urban (vvo:TrafficPattern)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Urban">http://purl.org/vvo/ns#Urban</seealso>
    let Urban = Prefixed_Name(vvo, "Urban") |> PrefixedName
    /// <summary>
    ///   <para>vvo:Wheels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of wheels-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 2"</para>
    /// labels<para>"Wheels Choice or Component"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#Wheels">http://purl.org/vvo/ns#Wheels</seealso>
    let Wheels = Prefixed_Name(vvo, "Wheels") |> PrefixedName
    /// <summary>
    ///   <para>vvo:advancedPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the advanced payment for the financing"</para>
    /// labels<para>"advancedPayment (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#advancedPayment">http://purl.org/vvo/ns#advancedPayment</seealso>
    let advancedPayment = Prefixed_Name(vvo, "advancedPayment") |> PrefixedName
    /// <summary>
    ///   <para>vvo:apr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Annual percentage rate. Note: 7.5 % is encoded as "7.5"^^xsd:decimal, not "0.075"^^xsd:decimal."</para>
    /// labels<para>"apr (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#apr">http://purl.org/vvo/ns#apr</seealso>
    let apr = Prefixed_Name(vvo, "apr") |> PrefixedName
    /// <summary>
    ///   <para>vvo:capCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The CAP code"</para>
    /// labels<para>"capCode (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#capCode">http://purl.org/vvo/ns#capCode</seealso>
    let capCode = Prefixed_Name(vvo, "capCode") |> PrefixedName
    /// <summary>
    ///   <para>vvo:credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the credit for the financing"</para>
    /// labels<para>"credit (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#credit">http://purl.org/vvo/ns#credit</seealso>
    let credit = Prefixed_Name(vvo, "credit") |> PrefixedName
    /// <summary>
    ///   <para>vvo:customerCashPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the customer cash price for the financing"</para>
    /// labels<para>"customerCashPrice (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#customerCashPrice">http://purl.org/vvo/ns#customerCashPrice</seealso>
    let customerCashPrice = Prefixed_Name(vvo, "customerCashPrice") |> PrefixedName
    /// <summary>
    ///   <para>vvo:customerDeposit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the customer deposit for the financing"</para>
    /// labels<para>"customerDeposit (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#customerDeposit">http://purl.org/vvo/ns#customerDeposit</seealso>
    let customerDeposit = Prefixed_Name(vvo, "customerDeposit") |> PrefixedName
    /// <summary>
    ///   <para>vvo:cylinderTypeId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Volkswagen-specific identifier for the cylinder type of a vehicle or engine"</para>
    /// labels<para>"cylinderTypeId (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#cylinderTypeId">http://purl.org/vvo/ns#cylinderTypeId</seealso>
    let cylinderTypeId = Prefixed_Name(vvo, "cylinderTypeId") |> PrefixedName
    /// <summary>
    ///   <para>vvo:dateLaunched</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of the official launch of the car model"</para>
    /// labels<para>"dateLaunched (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#dateLaunched">http://purl.org/vvo/ns#dateLaunched</seealso>
    let dateLaunched = Prefixed_Name(vvo, "dateLaunched") |> PrefixedName
    /// <summary>
    ///   <para>vvo:depositContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the deposit contribution for the financing"</para>
    /// labels<para>"depositContribution (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#depositContribution">http://purl.org/vvo/ns#depositContribution</seealso>
    let depositContribution = Prefixed_Name(vvo, "depositContribution") |> PrefixedName
    /// <summary>
    ///   <para>vvo:dhCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The DH code"</para>
    /// labels<para>"dhCode (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#dhCode">http://purl.org/vvo/ns#dhCode</seealso>
    let dhCode = Prefixed_Name(vvo, "dhCode") |> PrefixedName
    /// <summary>
    ///   <para>vvo:discount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the discount for the financing"</para>
    /// labels<para>"discount (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#discount">http://purl.org/vvo/ns#discount</seealso>
    let discount = Prefixed_Name(vvo, "discount") |> PrefixedName
    /// <summary>
    ///   <para>vvo:emissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The CO2 emissions in g/km"</para>
    /// labels<para>"emissions (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#emissions">http://purl.org/vvo/ns#emissions</seealso>
    let emissions = Prefixed_Name(vvo, "emissions") |> PrefixedName
    /// <summary>
    ///   <para>vvo:excessMileage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the rate for excess mileage"</para>
    /// labels<para>"excessMileage (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#excessMileage">http://purl.org/vvo/ns#excessMileage</seealso>
    let excessMileage = Prefixed_Name(vvo, "excessMileage") |> PrefixedName
    /// <summary>
    ///   <para>vvo:finalPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the final payment for the financing"</para>
    /// labels<para>"finalPayment (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#finalPayment">http://purl.org/vvo/ns#finalPayment</seealso>
    let finalPayment = Prefixed_Name(vvo, "finalPayment") |> PrefixedName
    /// <summary>
    ///   <para>vvo:finalPaymentFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the final payment fee for the financing"</para>
    /// labels<para>"finalPaymentFee (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#finalPaymentFee">http://purl.org/vvo/ns#finalPaymentFee</seealso>
    let finalPaymentFee = Prefixed_Name(vvo, "finalPaymentFee") |> PrefixedName

    /// <summary>
    ///   <para>vvo:firstMonthlyPaymentFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the first monthly payment fee for the financing"</para>
    /// labels<para>"firstMonthlyPaymentFee (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#firstMonthlyPaymentFee">http://purl.org/vvo/ns#firstMonthlyPaymentFee</seealso>
    let firstMonthlyPaymentFee =
        Prefixed_Name(vvo, "firstMonthlyPaymentFee") |> PrefixedName

    /// <summary>
    ///   <para>vvo:fuelInjectionTypeId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Volkswagen-specific identifier for the fuel injection type of a vehicle or engine"</para>
    /// labels<para>"fuelInjectionTypeId (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#fuelInjectionTypeId">http://purl.org/vvo/ns#fuelInjectionTypeId</seealso>
    let fuelInjectionTypeId = Prefixed_Name(vvo, "fuelInjectionTypeId") |> PrefixedName
    /// <summary>
    ///   <para>vvo:gearbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The gearbox type of the vehicle or vehicle model"</para>
    /// labels<para>"gearbox (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#gearbox">http://purl.org/vvo/ns#gearbox</seealso>
    let gearbox = Prefixed_Name(vvo, "gearbox") |> PrefixedName
    /// <summary>
    ///   <para>vvo:gearboxTypeId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Volkswagen-specific gearbox type ID"</para>
    /// labels<para>"gearboxTypeId (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#gearboxTypeId">http://purl.org/vvo/ns#gearboxTypeId</seealso>
    let gearboxTypeId = Prefixed_Name(vvo, "gearboxTypeId") |> PrefixedName
    /// <summary>
    ///   <para>vvo:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property that can be used to attach element identifiers from XML schemas for the corresponding XML data or schema"</para>
    /// labels<para>"hasID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#hasID">http://purl.org/vvo/ns#hasID</seealso>
    let hasID = Prefixed_Name(vvo, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>vvo:heightOpenBonnet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The outer height of the vehicle with the bonnet open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet"</para>
    /// labels<para>"heightOpenBonnet (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#heightOpenBonnet">http://purl.org/vvo/ns#heightOpenBonnet</seealso>
    let heightOpenBonnet = Prefixed_Name(vvo, "heightOpenBonnet") |> PrefixedName
    /// <summary>
    ///   <para>vvo:heightOpenTailgate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The outer height of the vehicle with the tailgate open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet"</para>
    /// labels<para>"heightOpenTailgate (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#heightOpenTailgate">http://purl.org/vvo/ns#heightOpenTailgate</seealso>
    let heightOpenTailgate = Prefixed_Name(vvo, "heightOpenTailgate") |> PrefixedName
    /// <summary>
    ///   <para>vvo:insuranceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The insurance group code"</para>
    /// labels<para>"insuranceGroup (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#insuranceGroup">http://purl.org/vvo/ns#insuranceGroup</seealso>
    let insuranceGroup = Prefixed_Name(vvo, "insuranceGroup") |> PrefixedName
    /// <summary>
    ///   <para>vvo:insuranceGroup50</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The insurance group 50 code "</para>
    /// labels<para>"insuranceGroup50 (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#insuranceGroup50">http://purl.org/vvo/ns#insuranceGroup50</seealso>
    let insuranceGroup50 = Prefixed_Name(vvo, "insuranceGroup50") |> PrefixedName

    /// <summary>
    ///   <para>vvo:luggageCapacitySeatsFolded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The available volume for cargo or luggage with the seats folded
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges."</para>
    /// labels<para>"luggageCapacitySeatsFolded (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#luggageCapacitySeatsFolded">http://purl.org/vvo/ns#luggageCapacitySeatsFolded</seealso>
    let luggageCapacitySeatsFolded =
        Prefixed_Name(vvo, "luggageCapacitySeatsFolded") |> PrefixedName

    /// <summary>
    ///   <para>vvo:luggageCapacitySeatsUpright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The available volume for cargo or luggage with the seats upright
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges."</para>
    /// labels<para>"luggageCapacitySeatsUpright (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#luggageCapacitySeatsUpright">http://purl.org/vvo/ns#luggageCapacitySeatsUpright</seealso>
    let luggageCapacitySeatsUpright =
        Prefixed_Name(vvo, "luggageCapacitySeatsUpright") |> PrefixedName

    /// <summary>
    ///   <para>vvo:manufacturerCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The manufacturer code"</para>
    /// labels<para>"manufacturerCode (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#manufacturerCode">http://purl.org/vvo/ns#manufacturerCode</seealso>
    let manufacturerCode = Prefixed_Name(vvo, "manufacturerCode") |> PrefixedName
    /// <summary>
    ///   <para>vvo:marketingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The name of the object for marketing purposes"</para>
    /// labels<para>"marketingName (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#marketingName">http://purl.org/vvo/ns#marketingName</seealso>
    let marketingName = Prefixed_Name(vvo, "marketingName") |> PrefixedName
    /// <summary>
    ///   <para>vvo:monthlyPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the monthly payment for the financing"</para>
    /// labels<para>"monthlyPayment (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#monthlyPayment">http://purl.org/vvo/ns#monthlyPayment</seealso>
    let monthlyPayment = Prefixed_Name(vvo, "monthlyPayment") |> PrefixedName
    /// <summary>
    ///   <para>vvo:noOfMonthlyPayments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of monthly payments"</para>
    /// labels<para>"noOfMonthlyPayments (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#noOfMonthlyPayments">http://purl.org/vvo/ns#noOfMonthlyPayments</seealso>
    let noOfMonthlyPayments = Prefixed_Name(vvo, "noOfMonthlyPayments") |> PrefixedName
    /// <summary>
    ///   <para>vvo:offerPromoCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The code for a promotional offer"</para>
    /// labels<para>"offerPromoCode (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#offerPromoCode">http://purl.org/vvo/ns#offerPromoCode</seealso>
    let offerPromoCode = Prefixed_Name(vvo, "offerPromoCode") |> PrefixedName
    /// <summary>
    ///   <para>vvo:otrRetailPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the OTR retail price for the financing"</para>
    /// labels<para>"otrRetailPrice (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#otrRetailPrice">http://purl.org/vvo/ns#otrRetailPrice</seealso>
    let otrRetailPrice = Prefixed_Name(vvo, "otrRetailPrice") |> PrefixedName
    /// <summary>
    ///   <para>vvo:productCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Volkswagen-specific product code for the vehicle model, choice, component, spare part, or service"</para>
    /// labels<para>"productCode (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#productCode">http://purl.org/vvo/ns#productCode</seealso>
    let productCode = Prefixed_Name(vvo, "productCode") |> PrefixedName

    /// <summary>
    ///   <para>vvo:refersToTrafficPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the traffic pattern to which the vso:fuelEconomy or vso:fuelConsumption value refers"</para>
    /// labels<para>"refersToTrafficPattern  (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#refersToTrafficPattern">http://purl.org/vvo/ns#refersToTrafficPattern</seealso>
    let refersToTrafficPattern =
        Prefixed_Name(vvo, "refersToTrafficPattern") |> PrefixedName

    /// <summary>
    ///   <para>vvo:rotationalSpeedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The rotational speed to which a vvo:torque or vso:enginePower value refers
    /// Typical unit code(s): RPM for revolutions per minute or RPS for revolutions per second"</para>
    /// labels<para>"rotationalSpeedReference  (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#rotationalSpeedReference">http://purl.org/vvo/ns#rotationalSpeedReference</seealso>
    let rotationalSpeedReference =
        Prefixed_Name(vvo, "rotationalSpeedReference") |> PrefixedName

    /// <summary>
    ///   <para>vvo:scrappageContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the scrappage contribution for the financing"</para>
    /// labels<para>"scrappageContribution (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#scrappageContribution">http://purl.org/vvo/ns#scrappageContribution</seealso>
    let scrappageContribution =
        Prefixed_Name(vvo, "scrappageContribution") |> PrefixedName

    /// <summary>
    ///   <para>vvo:shortSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The short subtitle for a vehicle, component, offer, or financing option"</para>
    /// labels<para>"shortSubtitle (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#shortSubtitle">http://purl.org/vvo/ns#shortSubtitle</seealso>
    let shortSubtitle = Prefixed_Name(vvo, "shortSubtitle") |> PrefixedName
    /// <summary>
    ///   <para>vvo:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The short title for a vehicle, component, offer, or financing option"</para>
    /// labels<para>"shortTitle (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#shortTitle">http://purl.org/vvo/ns#shortTitle</seealso>
    let shortTitle = Prefixed_Name(vvo, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>vvo:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The subtitle for a vehicle, component, offer, or financing option"</para>
    /// labels<para>"subtitle (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#subtitle">http://purl.org/vvo/ns#subtitle</seealso>
    let subtitle = Prefixed_Name(vvo, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>vvo:termsAndConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Terms and conditions of the service, offer, or financing option"</para>
    /// labels<para>"termsAndConditions (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#termsAndConditions">http://purl.org/vvo/ns#termsAndConditions</seealso>
    let termsAndConditions = Prefixed_Name(vvo, "termsAndConditions") |> PrefixedName
    /// <summary>
    ///   <para>vvo:torque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The torque (turning force) of an engine
    /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch"</para>
    /// labels<para>"torque (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#torque">http://purl.org/vvo/ns#torque</seealso>
    let torque = Prefixed_Name(vvo, "torque") |> PrefixedName
    /// <summary>
    ///   <para>vvo:totalPayable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the total payable for the financing"</para>
    /// labels<para>"totalPayable (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#totalPayable">http://purl.org/vvo/ns#totalPayable</seealso>
    let totalPayable = Prefixed_Name(vvo, "totalPayable") |> PrefixedName
    /// <summary>
    ///   <para>vvo:ved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The VED code"</para>
    /// labels<para>"ved (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#ved">http://purl.org/vvo/ns#ved</seealso>
    let ved = Prefixed_Name(vvo, "ved") |> PrefixedName

    /// <summary>
    ///   <para>vvo:widthExcludingDoorMirrors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The outer width of the vehicle, excluding door mirrors. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet"</para>
    /// labels<para>"widthExcludingDoorMirrors (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#widthExcludingDoorMirrors">http://purl.org/vvo/ns#widthExcludingDoorMirrors</seealso>
    let widthExcludingDoorMirrors =
        Prefixed_Name(vvo, "widthExcludingDoorMirrors") |> PrefixedName

    /// <summary>
    ///   <para>vvo:widthWithDoorsOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The outer width of the vehicle with the doors open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet"</para>
    /// labels<para>"widthWithDoorsOpen (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/vvo/ns#widthWithDoorsOpen">http://purl.org/vvo/ns#widthWithDoorsOpen</seealso>
    let widthWithDoorsOpen = Prefixed_Name(vvo, "widthWithDoorsOpen") |> PrefixedName
