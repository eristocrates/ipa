namespace http.purl.org.vvo.ns.hash

open DoxAletheia

module vvo =
    let _namespace_name = "http://purl.org/vvo/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class of audio and navigation choices or components (CD/DVD/SatNav, a "MonoSelectGroup" in automotive terminology), VW ID: 1
    /// <see href="http://purl.org/vvo/ns#AudioAndNavigation"></see></summary>
    let AudioAndNavigation = _prefix "AudioAndNavigation"
    /// <summary>
    /// An annotation property that can be used to attach element identifiers from XML schemas for the corresponding XML data or schema
    /// <see href="http://purl.org/vvo/ns#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// Four-by-Four Vehicle, VW ID: 6
    /// <see href="http://purl.org/vvo/ns#BodyStyle4X4"></see></summary>
    let BodyStyle4X4 = _prefix "BodyStyle4X4"
    /// <summary>
    /// Cabriolet, VW ID: 4
    /// <see href="http://purl.org/vvo/ns#BodyStyleCabriolet"></see></summary>
    let BodyStyleCabriolet = _prefix "BodyStyleCabriolet"
    /// <summary>
    /// Coupe, VW ID: 7
    /// <see href="http://purl.org/vvo/ns#BodyStyleCoupe"></see></summary>
    let BodyStyleCoupe = _prefix "BodyStyleCoupe"
    /// <summary>
    /// Estate, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#BodyStyleEstate"></see></summary>
    let BodyStyleEstate = _prefix "BodyStyleEstate"
    /// <summary>
    /// Hatchback, VW ID: 1
    /// <see href="http://purl.org/vvo/ns#BodyStyleHatchback"></see></summary>
    let BodyStyleHatchback = _prefix "BodyStyleHatchback"
    /// <summary>
    /// Multi-purpose Vehicle, VW ID: 5
    /// <see href="http://purl.org/vvo/ns#BodyStyleMPV"></see></summary>
    let BodyStyleMPV = _prefix "BodyStyleMPV"
    /// <summary>
    /// Saloon, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#BodyStyleSaloon"></see></summary>
    let BodyStyleSaloon = _prefix "BodyStyleSaloon"
    /// <summary>
    /// Unspecified, VW ID: 0
    /// <see href="http://purl.org/vvo/ns#BodyStyleUnspecified"></see></summary>
    let BodyStyleUnspecified = _prefix "BodyStyleUnspecified"
    /// <summary>
    /// Combined usage as a traffic pattern
    /// <see href="http://purl.org/vvo/ns#Combined"></see></summary>
    let Combined = _prefix "Combined"
    /// <summary>
    /// A value indicating a traffic pattern, to be used as a reference for vso:fuelConsumption or vso:fuelEconomy
    /// <see href="http://purl.org/vvo/ns#TrafficPattern"></see></summary>
    let TrafficPattern = _prefix "TrafficPattern"
    /// <summary>
    /// The class of decorative trim choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 8
    /// <see href="http://purl.org/vvo/ns#DecorativeTrims"></see></summary>
    let DecorativeTrims = _prefix "DecorativeTrims"
    /// <summary>
    /// Diesel, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#Diesel"></see></summary>
    let Diesel = _prefix "Diesel"
    /// <summary>
    /// The class of engines as choices or components
    /// <see href="http://purl.org/vvo/ns#Engine"></see></summary>
    let Engine = _prefix "Engine"
    /// <summary>
    /// The emission standard EURO 1
    /// <see href="http://purl.org/vvo/ns#Euro1"></see></summary>
    let Euro1 = _prefix "Euro1"
    /// <summary>
    /// The emission standard EURO 2
    /// <see href="http://purl.org/vvo/ns#Euro2"></see></summary>
    let Euro2 = _prefix "Euro2"
    /// <summary>
    /// The emission standard EURO 3
    /// <see href="http://purl.org/vvo/ns#Euro3"></see></summary>
    let Euro3 = _prefix "Euro3"
    /// <summary>
    /// The emission standard EURO 4
    /// <see href="http://purl.org/vvo/ns#Euro4"></see></summary>
    let Euro4 = _prefix "Euro4"
    /// <summary>
    /// The emission standard EURO 5
    /// <see href="http://purl.org/vvo/ns#Euro5"></see></summary>
    let Euro5 = _prefix "Euro5"
    /// <summary>
    /// Extra urban as a traffic pattern
    /// <see href="http://purl.org/vvo/ns#ExtraUrban"></see></summary>
    let ExtraUrban = _prefix "ExtraUrban"
    /// <summary>
    /// An instance of this class is the specification of a payment option via staged payments.
    /// <see href="http://purl.org/vvo/ns#Financing"></see></summary>
    let Financing = _prefix "Financing"
    /// <summary>
    /// Automatic gearbox, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#GearboxAutomatic"></see></summary>
    let GearboxAutomatic = _prefix "GearboxAutomatic"
    /// <summary>
    /// A value indicating a gearbox type.
    /// <see href="http://purl.org/vvo/ns#GearboxTypeValue"></see></summary>
    let GearboxTypeValue = _prefix "GearboxTypeValue"
    /// <summary>
    /// DSG gearbox, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#GearboxDSG"></see></summary>
    let GearboxDSG = _prefix "GearboxDSG"
    /// <summary>
    /// Manual gearbox, VW ID: 1
    /// <see href="http://purl.org/vvo/ns#GearboxManual"></see></summary>
    let GearboxManual = _prefix "GearboxManual"
    /// <summary>
    /// Hybrid, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#Hybrid"></see></summary>
    let Hybrid = _prefix "Hybrid"
    /// <summary>
    /// The class of paint choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 3
    /// <see href="http://purl.org/vvo/ns#Paint"></see></summary>
    let Paint = _prefix "Paint"
    /// <summary>
    /// The class of parking-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 7
    /// <see href="http://purl.org/vvo/ns#Parking"></see></summary>
    let Parking = _prefix "Parking"
    /// <summary>
    /// Petrol, VW ID: 1
    /// <see href="http://purl.org/vvo/ns#Petrol"></see></summary>
    let Petrol = _prefix "Petrol"
    /// <summary>
    /// The class of roof choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 5
    /// <see href="http://purl.org/vvo/ns#Roofs"></see></summary>
    let Roofs = _prefix "Roofs"
    /// <summary>
    /// The class of seat-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 9
    /// <see href="http://purl.org/vvo/ns#Seats"></see></summary>
    let Seats = _prefix "Seats"
    /// <summary>
    /// A service or service model. Typical instances are complementing services for a particular car.
    /// <see href="http://purl.org/vvo/ns#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// The class of steering wheels choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 6
    /// <see href="http://purl.org/vvo/ns#SteeringWheels"></see></summary>
    let SteeringWheels = _prefix "SteeringWheels"
    /// <summary>
    /// 4 Speed auto. VW ID: 1
    /// <see href="http://purl.org/vvo/ns#TT4SpeedAuto"></see></summary>
    let TT4SpeedAuto = _prefix "TT4SpeedAuto"
    /// <summary>
    /// The Volkswagen-specific gearbox type ID
    /// <see href="http://purl.org/vvo/ns#gearboxTypeId"></see></summary>
    let gearboxTypeId = _prefix "gearboxTypeId"
    /// <summary>
    /// The class of all automatic transmission types
    /// <see href="http://purl.org/vvo/ns#TransmissionTypeValueAutomatic"></see></summary>
    let TransmissionTypeValueAutomatic = _prefix "TransmissionTypeValueAutomatic"
    /// <summary>
    /// 5 Speed auto DSG, VW ID: 8
    /// <see href="http://purl.org/vvo/ns#TT5SpeedAutoDSG"></see></summary>
    let TT5SpeedAutoDSG = _prefix "TT5SpeedAutoDSG"
    /// <summary>
    /// 5 Speed auto tiptronic, VW ID: 3
    /// <see href="http://purl.org/vvo/ns#TT5SpeedAutoTiptronic"></see></summary>
    let TT5SpeedAutoTiptronic = _prefix "TT5SpeedAutoTiptronic"
    /// <summary>
    /// 5 Speed manual, VW ID: 2
    /// <see href="http://purl.org/vvo/ns#TT5SpeedManual"></see></summary>
    let TT5SpeedManual = _prefix "TT5SpeedManual"
    /// <summary>
    /// The class of all manual transmission types
    /// <see href="http://purl.org/vvo/ns#TransmissionTypeValueManual"></see></summary>
    let TransmissionTypeValueManual = _prefix "TransmissionTypeValueManual"
    /// <summary>
    /// 6 Speed auto, VW ID: 5
    /// <see href="http://purl.org/vvo/ns#TT6SpeedAuto"></see></summary>
    let TT6SpeedAuto = _prefix "TT6SpeedAuto"
    /// <summary>
    /// 6 Speed auto DSG, VW ID: 6
    /// <see href="http://purl.org/vvo/ns#TT6SpeedAutoDSG"></see></summary>
    let TT6SpeedAutoDSG = _prefix "TT6SpeedAutoDSG"
    /// <summary>
    /// 6 Speed auto tiptronic, VW ID: 7
    /// <see href="http://purl.org/vvo/ns#TT6SpeedAutoTiptronic"></see></summary>
    let TT6SpeedAutoTiptronic = _prefix "TT6SpeedAutoTiptronic"
    /// <summary>
    /// 6 Speed manual, VW ID: 4
    /// <see href="http://purl.org/vvo/ns#TT6SpeedManual"></see></summary>
    let TT6SpeedManual = _prefix "TT6SpeedManual"
    /// <summary>
    /// 7 Speed auto DSG, VW ID: 9
    /// <see href="http://purl.org/vvo/ns#TT7SpeedAutoDSG"></see></summary>
    let TT7SpeedAutoDSG = _prefix "TT7SpeedAutoDSG"
    /// <summary>
    /// 8 Speed auto, VW ID: 10
    /// <see href="http://purl.org/vvo/ns#TT8SpeedAuto"></see></summary>
    let TT8SpeedAuto = _prefix "TT8SpeedAuto"
    /// <summary>
    /// Unspecified, VW ID: 0
    /// <see href="http://purl.org/vvo/ns#TTUnspecified"></see></summary>
    let TTUnspecified = _prefix "TTUnspecified"
    /// <summary>
    /// The class of upholstery choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 4
    /// <see href="http://purl.org/vvo/ns#Upholstery"></see></summary>
    let Upholstery = _prefix "Upholstery"
    /// <summary>
    /// Urban usage as a traffic pattern
    /// <see href="http://purl.org/vvo/ns#Urban"></see></summary>
    let Urban = _prefix "Urban"
    /// <summary>
    /// The class of wheels-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 2
    /// <see href="http://purl.org/vvo/ns#Wheels"></see></summary>
    let Wheels = _prefix "Wheels"
    /// <summary>
    /// Indicates the advanced payment for the financing
    /// <see href="http://purl.org/vvo/ns#advancedPayment"></see></summary>
    let advancedPayment = _prefix "advancedPayment"
    /// <summary>
    /// Annual percentage rate. Note: 7.5 % is encoded as "7.5"^^xsd:decimal, not "0.075"^^xsd:decimal.
    /// <see href="http://purl.org/vvo/ns#apr"></see></summary>
    let apr = _prefix "apr"
    /// <summary>
    /// The CAP code
    /// <see href="http://purl.org/vvo/ns#capCode"></see></summary>
    let capCode = _prefix "capCode"
    /// <summary>
    /// Indicates the credit for the financing
    /// <see href="http://purl.org/vvo/ns#credit"></see></summary>
    let credit = _prefix "credit"
    /// <summary>
    /// Indicates the customer cash price for the financing
    /// <see href="http://purl.org/vvo/ns#customerCashPrice"></see></summary>
    let customerCashPrice = _prefix "customerCashPrice"
    /// <summary>
    /// Indicates the customer deposit for the financing
    /// <see href="http://purl.org/vvo/ns#customerDeposit"></see></summary>
    let customerDeposit = _prefix "customerDeposit"
    /// <summary>
    /// The Volkswagen-specific identifier for the cylinder type of a vehicle or engine
    /// <see href="http://purl.org/vvo/ns#cylinderTypeId"></see></summary>
    let cylinderTypeId = _prefix "cylinderTypeId"
    /// <summary>
    /// The date of the official launch of the car model
    /// <see href="http://purl.org/vvo/ns#dateLaunched"></see></summary>
    let dateLaunched = _prefix "dateLaunched"
    /// <summary>
    /// Indicates the deposit contribution for the financing
    /// <see href="http://purl.org/vvo/ns#depositContribution"></see></summary>
    let depositContribution = _prefix "depositContribution"
    /// <summary>
    /// The DH code
    /// <see href="http://purl.org/vvo/ns#dhCode"></see></summary>
    let dhCode = _prefix "dhCode"
    /// <summary>
    /// Indicates the discount for the financing
    /// <see href="http://purl.org/vvo/ns#discount"></see></summary>
    let discount = _prefix "discount"
    /// <summary>
    /// The CO2 emissions in g/km
    /// <see href="http://purl.org/vvo/ns#emissions"></see></summary>
    let emissions = _prefix "emissions"
    /// <summary>
    /// Indicates the rate for excess mileage
    /// <see href="http://purl.org/vvo/ns#excessMileage"></see></summary>
    let excessMileage = _prefix "excessMileage"
    /// <summary>
    /// Indicates the final payment for the financing
    /// <see href="http://purl.org/vvo/ns#finalPayment"></see></summary>
    let finalPayment = _prefix "finalPayment"
    /// <summary>
    /// Indicates the final payment fee for the financing
    /// <see href="http://purl.org/vvo/ns#finalPaymentFee"></see></summary>
    let finalPaymentFee = _prefix "finalPaymentFee"
    /// <summary>
    /// Indicates the first monthly payment fee for the financing
    /// <see href="http://purl.org/vvo/ns#firstMonthlyPaymentFee"></see></summary>
    let firstMonthlyPaymentFee = _prefix "firstMonthlyPaymentFee"
    /// <summary>
    /// The Volkswagen-specific identifier for the fuel injection type of a vehicle or engine
    /// <see href="http://purl.org/vvo/ns#fuelInjectionTypeId"></see></summary>
    let fuelInjectionTypeId = _prefix "fuelInjectionTypeId"
    /// <summary>
    /// The gearbox type of the vehicle or vehicle model
    /// <see href="http://purl.org/vvo/ns#gearbox"></see></summary>
    let gearbox = _prefix "gearbox"
    /// <summary>
    /// The outer height of the vehicle with the bonnet open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#heightOpenBonnet"></see></summary>
    let heightOpenBonnet = _prefix "heightOpenBonnet"
    /// <summary>
    /// The outer height of the vehicle with the tailgate open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#heightOpenTailgate"></see></summary>
    let heightOpenTailgate = _prefix "heightOpenTailgate"
    /// <summary>
    /// The insurance group code
    /// <see href="http://purl.org/vvo/ns#insuranceGroup"></see></summary>
    let insuranceGroup = _prefix "insuranceGroup"
    /// <summary>
    /// The insurance group 50 code
    /// <see href="http://purl.org/vvo/ns#insuranceGroup50"></see></summary>
    let insuranceGroup50 = _prefix "insuranceGroup50"
    /// <summary>
    /// The available volume for cargo or luggage with the seats folded
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vvo/ns#luggageCapacitySeatsFolded"></see></summary>
    let luggageCapacitySeatsFolded = _prefix "luggageCapacitySeatsFolded"
    /// <summary>
    /// The available volume for cargo or luggage with the seats upright
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vvo/ns#luggageCapacitySeatsUpright"></see></summary>
    let luggageCapacitySeatsUpright = _prefix "luggageCapacitySeatsUpright"
    /// <summary>
    /// The manufacturer code
    /// <see href="http://purl.org/vvo/ns#manufacturerCode"></see></summary>
    let manufacturerCode = _prefix "manufacturerCode"
    /// <summary>
    /// The name of the object for marketing purposes
    /// <see href="http://purl.org/vvo/ns#marketingName"></see></summary>
    let marketingName = _prefix "marketingName"
    /// <summary>
    /// Indicates the monthly payment for the financing
    /// <see href="http://purl.org/vvo/ns#monthlyPayment"></see></summary>
    let monthlyPayment = _prefix "monthlyPayment"
    /// <summary>
    /// The number of monthly payments
    /// <see href="http://purl.org/vvo/ns#noOfMonthlyPayments"></see></summary>
    let noOfMonthlyPayments = _prefix "noOfMonthlyPayments"
    /// <summary>
    /// The code for a promotional offer
    /// <see href="http://purl.org/vvo/ns#offerPromoCode"></see></summary>
    let offerPromoCode = _prefix "offerPromoCode"
    /// <summary>
    /// Indicates the OTR retail price for the financing
    /// <see href="http://purl.org/vvo/ns#otrRetailPrice"></see></summary>
    let otrRetailPrice = _prefix "otrRetailPrice"
    /// <summary>
    /// The Volkswagen-specific product code for the vehicle model, choice, component, spare part, or service
    /// <see href="http://purl.org/vvo/ns#productCode"></see></summary>
    let productCode = _prefix "productCode"
    /// <summary>
    /// Indicates the traffic pattern to which the vso:fuelEconomy or vso:fuelConsumption value refers
    /// <see href="http://purl.org/vvo/ns#refersToTrafficPattern"></see></summary>
    let refersToTrafficPattern = _prefix "refersToTrafficPattern"
    /// <summary>
    /// The rotational speed to which a vvo:torque or vso:enginePower value refers
    /// Typical unit code(s): RPM for revolutions per minute or RPS for revolutions per second
    /// <see href="http://purl.org/vvo/ns#rotationalSpeedReference"></see></summary>
    let rotationalSpeedReference = _prefix "rotationalSpeedReference"
    /// <summary>
    /// Indicates the scrappage contribution for the financing
    /// <see href="http://purl.org/vvo/ns#scrappageContribution"></see></summary>
    let scrappageContribution = _prefix "scrappageContribution"
    /// <summary>
    /// The short subtitle for a vehicle, component, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#shortSubtitle"></see></summary>
    let shortSubtitle = _prefix "shortSubtitle"
    /// <summary>
    /// The short title for a vehicle, component, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#shortTitle"></see></summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    /// The subtitle for a vehicle, component, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#subtitle"></see></summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    /// Terms and conditions of the service, offer, or financing option
    /// <see href="http://purl.org/vvo/ns#termsAndConditions"></see></summary>
    let termsAndConditions = _prefix "termsAndConditions"
    /// <summary>
    /// The torque (turning force) of an engine
    /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch
    /// <see href="http://purl.org/vvo/ns#torque"></see></summary>
    let torque = _prefix "torque"
    /// <summary>
    /// Indicates the total payable for the financing
    /// <see href="http://purl.org/vvo/ns#totalPayable"></see></summary>
    let totalPayable = _prefix "totalPayable"
    /// <summary>
    /// The VED code
    /// <see href="http://purl.org/vvo/ns#ved"></see></summary>
    let ved = _prefix "ved"
    /// <summary>
    /// The outer width of the vehicle, excluding door mirrors. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#widthExcludingDoorMirrors"></see></summary>
    let widthExcludingDoorMirrors = _prefix "widthExcludingDoorMirrors"
    /// <summary>
    /// The outer width of the vehicle with the doors open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vvo/ns#widthWithDoorsOpen"></see></summary>
    let widthWithDoorsOpen = _prefix "widthWithDoorsOpen"
