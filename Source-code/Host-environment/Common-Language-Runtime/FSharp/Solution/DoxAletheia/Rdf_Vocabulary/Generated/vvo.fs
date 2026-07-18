namespace http.purl.org.vvo.ns.hash

open DoxAletheia.Rdf_Vocabulary

module vvo =
    let _namespace_name = "http://purl.org/vvo/ns#"

    /// <summary>
    /// The class of audio and navigation choices or components (CD/DVD/SatNav, a "MonoSelectGroup" in automotive terminology), VW ID: 1
    /// <see href="http://purl.org/vvo/ns#AudioAndNavigation"></see></summary>
    let AudioAndNavigation =
        Namespaced_IRI.parse _namespace_name "AudioAndNavigation" |> NamespacedName

    /// <summary>
    /// An annotation property that can be used to attach element identifiers from XML schemas for the corresponding XML data or schema
    /// <see href="http://purl.org/vvo/ns#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName

    /// <summary>
    /// Four-by-Four Vehicle, VW ID: 6
    /// <see href="http://purl.org/vvo/ns#BodyStyle4X4"></see></summary>
    let BodyStyle4X4 =
        Namespaced_IRI.parse _namespace_name "BodyStyle4X4" |> NamespacedName

    /// <summary>
    /// Cabriolet, VW ID: 4
    /// <see href="http://purl.org/vvo/ns#BodyStyleCabriolet"></see></summary>
    let BodyStyleCabriolet =
        Namespaced_IRI.parse _namespace_name "BodyStyleCabriolet" |> NamespacedName

    /// <summary>
    /// Coupe, VW ID: 7
    /// <see href="http://purl.org/vvo/ns#BodyStyleCoupe"></see></summary>
    let BodyStyleCoupe =
        Namespaced_IRI.parse _namespace_name "BodyStyleCoupe" |> NamespacedName

    /// <summary>
    /// Estate, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#BodyStyleEstate"></see></summary>
    let BodyStyleEstate =
        Namespaced_IRI.parse _namespace_name "BodyStyleEstate" |> NamespacedName

    /// <summary>
    /// Hatchback, VW ID: 1
    /// <see href="http://purl.org/vvo/ns#BodyStyleHatchback"></see></summary>
    let BodyStyleHatchback =
        Namespaced_IRI.parse _namespace_name "BodyStyleHatchback" |> NamespacedName

    /// <summary>
    /// Multi-purpose Vehicle, VW ID: 5
    /// <see href="http://purl.org/vvo/ns#BodyStyleMPV"></see></summary>
    let BodyStyleMPV =
        Namespaced_IRI.parse _namespace_name "BodyStyleMPV" |> NamespacedName

    /// <summary>
    /// Saloon, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#BodyStyleSaloon"></see></summary>
    let BodyStyleSaloon =
        Namespaced_IRI.parse _namespace_name "BodyStyleSaloon" |> NamespacedName

    /// <summary>
    /// Unspecified, VW ID: 0
    /// <see href="http://purl.org/vvo/ns#BodyStyleUnspecified"></see></summary>
    let BodyStyleUnspecified =
        Namespaced_IRI.parse _namespace_name "BodyStyleUnspecified" |> NamespacedName

    /// <summary>
    /// Combined usage as a traffic pattern
    /// <see href="http://purl.org/vvo/ns#Combined"></see></summary>
    let Combined = Namespaced_IRI.parse _namespace_name "Combined" |> NamespacedName

    /// <summary>
    /// A value indicating a traffic pattern, to be used as a reference for vso:fuelConsumption or vso:fuelEconomy
    /// <see href="http://purl.org/vvo/ns#TrafficPattern"></see></summary>
    let TrafficPattern =
        Namespaced_IRI.parse _namespace_name "TrafficPattern" |> NamespacedName

    /// <summary>
    /// The class of decorative trim choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 8
    /// <see href="http://purl.org/vvo/ns#DecorativeTrims"></see></summary>
    let DecorativeTrims =
        Namespaced_IRI.parse _namespace_name "DecorativeTrims" |> NamespacedName

    /// <summary>
    /// Diesel, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#Diesel"></see></summary>
    let Diesel = Namespaced_IRI.parse _namespace_name "Diesel" |> NamespacedName
    /// <summary>
    /// The class of engines as choices or components
    /// <see href="http://purl.org/vvo/ns#Engine"></see></summary>
    let Engine = Namespaced_IRI.parse _namespace_name "Engine" |> NamespacedName
    /// <summary>
    /// The emission standard EURO 1
    /// <see href="http://purl.org/vvo/ns#Euro1"></see></summary>
    let Euro1 = Namespaced_IRI.parse _namespace_name "Euro1" |> NamespacedName
    /// <summary>
    /// The emission standard EURO 2
    /// <see href="http://purl.org/vvo/ns#Euro2"></see></summary>
    let Euro2 = Namespaced_IRI.parse _namespace_name "Euro2" |> NamespacedName
    /// <summary>
    /// The emission standard EURO 3
    /// <see href="http://purl.org/vvo/ns#Euro3"></see></summary>
    let Euro3 = Namespaced_IRI.parse _namespace_name "Euro3" |> NamespacedName
    /// <summary>
    /// The emission standard EURO 4
    /// <see href="http://purl.org/vvo/ns#Euro4"></see></summary>
    let Euro4 = Namespaced_IRI.parse _namespace_name "Euro4" |> NamespacedName
    /// <summary>
    /// The emission standard EURO 5
    /// <see href="http://purl.org/vvo/ns#Euro5"></see></summary>
    let Euro5 = Namespaced_IRI.parse _namespace_name "Euro5" |> NamespacedName
    /// <summary>
    /// Extra urban as a traffic pattern
    /// <see href="http://purl.org/vvo/ns#ExtraUrban"></see></summary>
    let ExtraUrban = Namespaced_IRI.parse _namespace_name "ExtraUrban" |> NamespacedName
    /// <summary>
    /// An instance of this class is the specification of a payment option via staged payments.
    /// <see href="http://purl.org/vvo/ns#Financing"></see></summary>
    let Financing = Namespaced_IRI.parse _namespace_name "Financing" |> NamespacedName

    /// <summary>
    /// Automatic gearbox, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#GearboxAutomatic"></see></summary>
    let GearboxAutomatic =
        Namespaced_IRI.parse _namespace_name "GearboxAutomatic" |> NamespacedName

    /// <summary>
    /// A value indicating a gearbox type.
    /// <see href="http://purl.org/vvo/ns#GearboxTypeValue"></see></summary>
    let GearboxTypeValue =
        Namespaced_IRI.parse _namespace_name "GearboxTypeValue" |> NamespacedName

    /// <summary>
    /// DSG gearbox, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#GearboxDSG"></see></summary>
    let GearboxDSG = Namespaced_IRI.parse _namespace_name "GearboxDSG" |> NamespacedName

    /// <summary>
    /// Manual gearbox, VW ID: 1
    /// <see href="http://purl.org/vvo/ns#GearboxManual"></see></summary>
    let GearboxManual =
        Namespaced_IRI.parse _namespace_name "GearboxManual" |> NamespacedName

    /// <summary>
    /// Hybrid, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#Hybrid"></see></summary>
    let Hybrid = Namespaced_IRI.parse _namespace_name "Hybrid" |> NamespacedName
    /// <summary>
    /// The class of paint choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 3
    /// <see href="http://purl.org/vvo/ns#Paint"></see></summary>
    let Paint = Namespaced_IRI.parse _namespace_name "Paint" |> NamespacedName
    /// <summary>
    /// The class of parking-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 7
    /// <see href="http://purl.org/vvo/ns#Parking"></see></summary>
    let Parking = Namespaced_IRI.parse _namespace_name "Parking" |> NamespacedName
    /// <summary>
    /// Petrol, VW ID: 1
    /// <see href="http://purl.org/vvo/ns#Petrol"></see></summary>
    let Petrol = Namespaced_IRI.parse _namespace_name "Petrol" |> NamespacedName
    /// <summary>
    /// The class of roof choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 5
    /// <see href="http://purl.org/vvo/ns#Roofs"></see></summary>
    let Roofs = Namespaced_IRI.parse _namespace_name "Roofs" |> NamespacedName
    /// <summary>
    /// The class of seat-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 9
    /// <see href="http://purl.org/vvo/ns#Seats"></see></summary>
    let Seats = Namespaced_IRI.parse _namespace_name "Seats" |> NamespacedName
    /// <summary>
    /// A service or service model. Typical instances are complementing services for a particular car.
    /// <see href="http://purl.org/vvo/ns#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// The class of steering wheels choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 6
    /// <see href="http://purl.org/vvo/ns#SteeringWheels"></see></summary>
    let SteeringWheels =
        Namespaced_IRI.parse _namespace_name "SteeringWheels" |> NamespacedName

    /// <summary>
    /// 4 Speed auto. VW ID: 1
    /// <see href="http://purl.org/vvo/ns#TT4SpeedAuto"></see></summary>
    let TT4SpeedAuto =
        Namespaced_IRI.parse _namespace_name "TT4SpeedAuto" |> NamespacedName

    /// <summary>
    /// The Volkswagen-specific gearbox type ID
    /// <see href="http://purl.org/vvo/ns#gearboxTypeId"></see></summary>
    let gearboxTypeId =
        Namespaced_IRI.parse _namespace_name "gearboxTypeId" |> NamespacedName

    /// <summary>
    /// The class of all automatic transmission types
    /// <see href="http://purl.org/vvo/ns#TransmissionTypeValueAutomatic"></see></summary>
    let TransmissionTypeValueAutomatic =
        Namespaced_IRI.parse _namespace_name "TransmissionTypeValueAutomatic" |> NamespacedName

    /// <summary>
    /// 5 Speed auto DSG, VW ID: 8
    /// <see href="http://purl.org/vvo/ns#TT5SpeedAutoDSG"></see></summary>
    let TT5SpeedAutoDSG =
        Namespaced_IRI.parse _namespace_name "TT5SpeedAutoDSG" |> NamespacedName

    /// <summary>
    /// 5 Speed auto tiptronic, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#TT5SpeedAutoTiptronic"></see></summary>
    let TT5SpeedAutoTiptronic =
        Namespaced_IRI.parse _namespace_name "TT5SpeedAutoTiptronic" |> NamespacedName

    /// <summary>
    /// 5 Speed manual, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#TT5SpeedManual"></see></summary>
    let TT5SpeedManual =
        Namespaced_IRI.parse _namespace_name "TT5SpeedManual" |> NamespacedName

    /// <summary>
    /// The class of all manual transmission types
    /// <see href="http://purl.org/vvo/ns#TransmissionTypeValueManual"></see></summary>
    let TransmissionTypeValueManual =
        Namespaced_IRI.parse _namespace_name "TransmissionTypeValueManual" |> NamespacedName

    /// <summary>
    /// 6 Speed auto, VW ID: 5
    /// <see href="http://purl.org/vvo/ns#TT6SpeedAuto"></see></summary>
    let TT6SpeedAuto =
        Namespaced_IRI.parse _namespace_name "TT6SpeedAuto" |> NamespacedName

    /// <summary>
    /// 6 Speed auto DSG, VW ID: 6
    /// <see href="http://purl.org/vvo/ns#TT6SpeedAutoDSG"></see></summary>
    let TT6SpeedAutoDSG =
        Namespaced_IRI.parse _namespace_name "TT6SpeedAutoDSG" |> NamespacedName

    /// <summary>
    /// 6 Speed auto tiptronic, VW ID: 7
    /// <see href="http://purl.org/vvo/ns#TT6SpeedAutoTiptronic"></see></summary>
    let TT6SpeedAutoTiptronic =
        Namespaced_IRI.parse _namespace_name "TT6SpeedAutoTiptronic" |> NamespacedName

    /// <summary>
    /// 6 Speed manual, VW ID: 4
    /// <see href="http://purl.org/vvo/ns#TT6SpeedManual"></see></summary>
    let TT6SpeedManual =
        Namespaced_IRI.parse _namespace_name "TT6SpeedManual" |> NamespacedName

    /// <summary>
    /// 7 Speed auto DSG, VW ID: 9
    /// <see href="http://purl.org/vvo/ns#TT7SpeedAutoDSG"></see></summary>
    let TT7SpeedAutoDSG =
        Namespaced_IRI.parse _namespace_name "TT7SpeedAutoDSG" |> NamespacedName

    /// <summary>
    /// 8 Speed auto, VW ID: 10
    /// <see href="http://purl.org/vvo/ns#TT8SpeedAuto"></see></summary>
    let TT8SpeedAuto =
        Namespaced_IRI.parse _namespace_name "TT8SpeedAuto" |> NamespacedName

    /// <summary>
    /// Unspecified, VW ID: 0
    /// <see href="http://purl.org/vvo/ns#TTUnspecified"></see></summary>
    let TTUnspecified =
        Namespaced_IRI.parse _namespace_name "TTUnspecified" |> NamespacedName

    /// <summary>
    /// The class of upholstery choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 4
    /// <see href="http://purl.org/vvo/ns#Upholstery"></see></summary>
    let Upholstery = Namespaced_IRI.parse _namespace_name "Upholstery" |> NamespacedName
    /// <summary>
    /// Urban usage as a traffic pattern
    /// <see href="http://purl.org/vvo/ns#Urban"></see></summary>
    let Urban = Namespaced_IRI.parse _namespace_name "Urban" |> NamespacedName
    /// <summary>
    /// The class of wheels-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 2
    /// <see href="http://purl.org/vvo/ns#Wheels"></see></summary>
    let Wheels = Namespaced_IRI.parse _namespace_name "Wheels" |> NamespacedName

    /// <summary>
    /// Indicates the advanced payment for the financing
    /// <see href="http://purl.org/vvo/ns#advancedPayment"></see></summary>
    let advancedPayment =
        Namespaced_IRI.parse _namespace_name "advancedPayment" |> NamespacedName

    /// <summary>
    /// Annual percentage rate. Note: 7.5 % is encoded as "7.5"^^xsd:decimal, not "0.075"^^xsd:decimal.
    /// <see href="http://purl.org/vvo/ns#apr"></see></summary>
    let apr = Namespaced_IRI.parse _namespace_name "apr" |> NamespacedName
    /// <summary>
    /// The CAP code
    /// <see href="http://purl.org/vvo/ns#capCode"></see></summary>
    let capCode = Namespaced_IRI.parse _namespace_name "capCode" |> NamespacedName
    /// <summary>
    /// Indicates the credit for the financing
    /// <see href="http://purl.org/vvo/ns#credit"></see></summary>
    let credit = Namespaced_IRI.parse _namespace_name "credit" |> NamespacedName

    /// <summary>
    /// Indicates the customer cash price for the financing
    /// <see href="http://purl.org/vvo/ns#customerCashPrice"></see></summary>
    let customerCashPrice =
        Namespaced_IRI.parse _namespace_name "customerCashPrice" |> NamespacedName

    /// <summary>
    /// Indicates the customer deposit for the financing
    /// <see href="http://purl.org/vvo/ns#customerDeposit"></see></summary>
    let customerDeposit =
        Namespaced_IRI.parse _namespace_name "customerDeposit" |> NamespacedName

    /// <summary>
    /// The Volkswagen-specific identifier for the cylinder type of a vehicle or engine
    /// <see href="http://purl.org/vvo/ns#cylinderTypeId"></see></summary>
    let cylinderTypeId =
        Namespaced_IRI.parse _namespace_name "cylinderTypeId" |> NamespacedName

    /// <summary>
    /// The date of the official launch of the car model
    /// <see href="http://purl.org/vvo/ns#dateLaunched"></see></summary>
    let dateLaunched =
        Namespaced_IRI.parse _namespace_name "dateLaunched" |> NamespacedName

    /// <summary>
    /// Indicates the deposit contribution for the financing
    /// <see href="http://purl.org/vvo/ns#depositContribution"></see></summary>
    let depositContribution =
        Namespaced_IRI.parse _namespace_name "depositContribution" |> NamespacedName

    /// <summary>
    /// The DH code
    /// <see href="http://purl.org/vvo/ns#dhCode"></see></summary>
    let dhCode = Namespaced_IRI.parse _namespace_name "dhCode" |> NamespacedName
    /// <summary>
    /// Indicates the discount for the financing
    /// <see href="http://purl.org/vvo/ns#discount"></see></summary>
    let discount = Namespaced_IRI.parse _namespace_name "discount" |> NamespacedName
    /// <summary>
    /// The CO2 emissions in g/km
    /// <see href="http://purl.org/vvo/ns#emissions"></see></summary>
    let emissions = Namespaced_IRI.parse _namespace_name "emissions" |> NamespacedName

    /// <summary>
    /// Indicates the rate for excess mileage
    /// <see href="http://purl.org/vvo/ns#excessMileage"></see></summary>
    let excessMileage =
        Namespaced_IRI.parse _namespace_name "excessMileage" |> NamespacedName

    /// <summary>
    /// Indicates the final payment for the financing
    /// <see href="http://purl.org/vvo/ns#finalPayment"></see></summary>
    let finalPayment =
        Namespaced_IRI.parse _namespace_name "finalPayment" |> NamespacedName

    /// <summary>
    /// Indicates the final payment fee for the financing
    /// <see href="http://purl.org/vvo/ns#finalPaymentFee"></see></summary>
    let finalPaymentFee =
        Namespaced_IRI.parse _namespace_name "finalPaymentFee" |> NamespacedName

    /// <summary>
    /// Indicates the first monthly payment fee for the financing
    /// <see href="http://purl.org/vvo/ns#firstMonthlyPaymentFee"></see></summary>
    let firstMonthlyPaymentFee =
        Namespaced_IRI.parse _namespace_name "firstMonthlyPaymentFee" |> NamespacedName

    /// <summary>
    /// The Volkswagen-specific identifier for the fuel injection type of a vehicle or engine
    /// <see href="http://purl.org/vvo/ns#fuelInjectionTypeId"></see></summary>
    let fuelInjectionTypeId =
        Namespaced_IRI.parse _namespace_name "fuelInjectionTypeId" |> NamespacedName

    /// <summary>
    /// The gearbox type of the vehicle or vehicle model
    /// <see href="http://purl.org/vvo/ns#gearbox"></see></summary>
    let gearbox = Namespaced_IRI.parse _namespace_name "gearbox" |> NamespacedName

    /// <summary>
    /// The outer height of the vehicle with the bonnet open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#heightOpenBonnet"></see></summary>
    let heightOpenBonnet =
        Namespaced_IRI.parse _namespace_name "heightOpenBonnet" |> NamespacedName

    /// <summary>
    /// The outer height of the vehicle with the tailgate open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#heightOpenTailgate"></see></summary>
    let heightOpenTailgate =
        Namespaced_IRI.parse _namespace_name "heightOpenTailgate" |> NamespacedName

    /// <summary>
    /// The insurance group code
    /// <see href="http://purl.org/vvo/ns#insuranceGroup"></see></summary>
    let insuranceGroup =
        Namespaced_IRI.parse _namespace_name "insuranceGroup" |> NamespacedName

    /// <summary>
    /// The insurance group 50 code
    /// <see href="http://purl.org/vvo/ns#insuranceGroup50"></see></summary>
    let insuranceGroup50 =
        Namespaced_IRI.parse _namespace_name "insuranceGroup50" |> NamespacedName

    /// <summary>
    /// The available volume for cargo or luggage with the seats folded
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vvo/ns#luggageCapacitySeatsFolded"></see></summary>
    let luggageCapacitySeatsFolded =
        Namespaced_IRI.parse _namespace_name "luggageCapacitySeatsFolded" |> NamespacedName

    /// <summary>
    /// The available volume for cargo or luggage with the seats upright
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vvo/ns#luggageCapacitySeatsUpright"></see></summary>
    let luggageCapacitySeatsUpright =
        Namespaced_IRI.parse _namespace_name "luggageCapacitySeatsUpright" |> NamespacedName

    /// <summary>
    /// The manufacturer code
    /// <see href="http://purl.org/vvo/ns#manufacturerCode"></see></summary>
    let manufacturerCode =
        Namespaced_IRI.parse _namespace_name "manufacturerCode" |> NamespacedName

    /// <summary>
    /// The name of the object for marketing purposes
    /// <see href="http://purl.org/vvo/ns#marketingName"></see></summary>
    let marketingName =
        Namespaced_IRI.parse _namespace_name "marketingName" |> NamespacedName

    /// <summary>
    /// Indicates the monthly payment for the financing
    /// <see href="http://purl.org/vvo/ns#monthlyPayment"></see></summary>
    let monthlyPayment =
        Namespaced_IRI.parse _namespace_name "monthlyPayment" |> NamespacedName

    /// <summary>
    /// The number of monthly payments
    /// <see href="http://purl.org/vvo/ns#noOfMonthlyPayments"></see></summary>
    let noOfMonthlyPayments =
        Namespaced_IRI.parse _namespace_name "noOfMonthlyPayments" |> NamespacedName

    /// <summary>
    /// The code for a promotional offer
    /// <see href="http://purl.org/vvo/ns#offerPromoCode"></see></summary>
    let offerPromoCode =
        Namespaced_IRI.parse _namespace_name "offerPromoCode" |> NamespacedName

    /// <summary>
    /// Indicates the OTR retail price for the financing
    /// <see href="http://purl.org/vvo/ns#otrRetailPrice"></see></summary>
    let otrRetailPrice =
        Namespaced_IRI.parse _namespace_name "otrRetailPrice" |> NamespacedName

    /// <summary>
    /// The Volkswagen-specific product code for the vehicle model, choice, component, spare part, or service
    /// <see href="http://purl.org/vvo/ns#productCode"></see></summary>
    let productCode =
        Namespaced_IRI.parse _namespace_name "productCode" |> NamespacedName

    /// <summary>
    /// Indicates the traffic pattern to which the vso:fuelEconomy or vso:fuelConsumption value refers
    /// <see href="http://purl.org/vvo/ns#refersToTrafficPattern"></see></summary>
    let refersToTrafficPattern =
        Namespaced_IRI.parse _namespace_name "refersToTrafficPattern" |> NamespacedName

    /// <summary>
    /// The rotational speed to which a vvo:torque or vso:enginePower value refers
    /// Typical unit code(s): RPM for revolutions per minute or RPS for revolutions per second
    /// <see href="http://purl.org/vvo/ns#rotationalSpeedReference"></see></summary>
    let rotationalSpeedReference =
        Namespaced_IRI.parse _namespace_name "rotationalSpeedReference" |> NamespacedName

    /// <summary>
    /// Indicates the scrappage contribution for the financing
    /// <see href="http://purl.org/vvo/ns#scrappageContribution"></see></summary>
    let scrappageContribution =
        Namespaced_IRI.parse _namespace_name "scrappageContribution" |> NamespacedName

    /// <summary>
    /// The short subtitle for a vehicle, component, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#shortSubtitle"></see></summary>
    let shortSubtitle =
        Namespaced_IRI.parse _namespace_name "shortSubtitle" |> NamespacedName

    /// <summary>
    /// The short title for a vehicle, component, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#shortTitle"></see></summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName
    /// <summary>
    /// The subtitle for a vehicle, component, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#subtitle"></see></summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName

    /// <summary>
    /// Terms and conditions of the service, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#termsAndConditions"></see></summary>
    let termsAndConditions =
        Namespaced_IRI.parse _namespace_name "termsAndConditions" |> NamespacedName

    /// <summary>
    /// The torque (turning force) of an engine
    /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch
    /// <see href="http://purl.org/vvo/ns#torque"></see></summary>
    let torque = Namespaced_IRI.parse _namespace_name "torque" |> NamespacedName

    /// <summary>
    /// Indicates the total payable for the financing
    /// <see href="http://purl.org/vvo/ns#totalPayable"></see></summary>
    let totalPayable =
        Namespaced_IRI.parse _namespace_name "totalPayable" |> NamespacedName

    /// <summary>
    /// The VED code
    /// <see href="http://purl.org/vvo/ns#ved"></see></summary>
    let ved = Namespaced_IRI.parse _namespace_name "ved" |> NamespacedName

    /// <summary>
    /// The outer width of the vehicle, excluding door mirrors. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#widthExcludingDoorMirrors"></see></summary>
    let widthExcludingDoorMirrors =
        Namespaced_IRI.parse _namespace_name "widthExcludingDoorMirrors" |> NamespacedName

    /// <summary>
    /// The outer width of the vehicle with the doors open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#widthWithDoorsOpen"></see></summary>
    let widthWithDoorsOpen =
        Namespaced_IRI.parse _namespace_name "widthWithDoorsOpen" |> NamespacedName
