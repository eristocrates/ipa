#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vvo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vvo/ns#" "vvo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vvo:hasID : 1^^xsd:string</para>
    ///   <para>rdfs:label : Audio and Navigation Choice or Component</para>
    ///   <para>rdfs:comment : The class of audio and navigation choices or components (CD/DVD/SatNav, a "MonoSelectGroup" in automotive terminology), VW ID: 1</para>
    ///   <a href="http://purl.org/vvo/ns#AudioAndNavigation">vvo:AudioAndNavigation</a>
    /// </summary>
    let AudioAndNavigation = _prefixId.prefix "AudioAndNavigation"
    let BodyStyle4X4 = _prefixId.prefix "BodyStyle4X4"
    let BodyStyleCabriolet = _prefixId.prefix "BodyStyleCabriolet"
    let BodyStyleCoupe = _prefixId.prefix "BodyStyleCoupe"
    let BodyStyleEstate = _prefixId.prefix "BodyStyleEstate"
    let BodyStyleHatchback = _prefixId.prefix "BodyStyleHatchback"
    let BodyStyleMPV = _prefixId.prefix "BodyStyleMPV"
    let BodyStyleSaloon = _prefixId.prefix "BodyStyleSaloon"
    let BodyStyleUnspecified = _prefixId.prefix "BodyStyleUnspecified"
    let Combined = _prefixId.prefix "Combined"
    /// <summary>
    ///   <para>vvo:hasID : 8^^xsd:string</para>
    ///   <para>rdfs:label : Decorative Trims Choice or Component</para>
    ///   <para>rdfs:comment : The class of decorative trim choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 8</para>
    ///   <a href="http://purl.org/vvo/ns#DecorativeTrims">vvo:DecorativeTrims</a>
    /// </summary>
    let DecorativeTrims = _prefixId.prefix "DecorativeTrims"
    let Diesel = _prefixId.prefix "Diesel"
    /// <summary>
    ///   <para>rdfs:label : Engine Choice or Component</para>
    ///   <para>rdfs:comment : The class of engines as choices or components</para>
    ///   <a href="http://purl.org/vvo/ns#Engine">vvo:Engine</a>
    /// </summary>
    let Engine = _prefixId.prefix "Engine"
    let Euro1 = _prefixId.prefix "Euro1"
    let Euro2 = _prefixId.prefix "Euro2"
    let Euro3 = _prefixId.prefix "Euro3"
    let Euro4 = _prefixId.prefix "Euro4"
    let Euro5 = _prefixId.prefix "Euro5"
    let ExtraUrban = _prefixId.prefix "ExtraUrban"
    /// <summary>
    ///   <para>rdfs:label : Financing (gr:PaymentMethod)</para>
    ///   <para>rdfs:comment : An instance of this class is the specification of a payment option via staged payments.</para>
    ///   <a href="http://purl.org/vvo/ns#Financing">vvo:Financing</a>
    /// </summary>
    let Financing = _prefixId.prefix "Financing"
    let GearboxAutomatic = _prefixId.prefix "GearboxAutomatic"
    let GearboxDSG = _prefixId.prefix "GearboxDSG"
    let GearboxManual = _prefixId.prefix "GearboxManual"
    /// <summary>
    ///   <para>rdfs:label : Gearbox type value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating a gearbox type.</para>
    ///   <a href="http://purl.org/vvo/ns#GearboxTypeValue">vvo:GearboxTypeValue</a>
    /// </summary>
    let GearboxTypeValue = _prefixId.prefix "GearboxTypeValue"
    let Hybrid = _prefixId.prefix "Hybrid"
    /// <summary>
    ///   <para>vvo:hasID : 3^^xsd:string</para>
    ///   <para>rdfs:label : Paint Choice or Component</para>
    ///   <para>rdfs:comment : The class of paint choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 3</para>
    ///   <a href="http://purl.org/vvo/ns#Paint">vvo:Paint</a>
    /// </summary>
    let Paint = _prefixId.prefix "Paint"
    /// <summary>
    ///   <para>vvo:hasID : 7^^xsd:string</para>
    ///   <para>rdfs:label : Parking Choice or Component</para>
    ///   <para>rdfs:comment : The class of parking-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 7</para>
    ///   <a href="http://purl.org/vvo/ns#Parking">vvo:Parking</a>
    /// </summary>
    let Parking = _prefixId.prefix "Parking"
    let Petrol = _prefixId.prefix "Petrol"
    /// <summary>
    ///   <para>vvo:hasID : 5^^xsd:string</para>
    ///   <para>rdfs:label : Roofs Choice or Component</para>
    ///   <para>rdfs:comment : The class of roof choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 5</para>
    ///   <a href="http://purl.org/vvo/ns#Roofs">vvo:Roofs</a>
    /// </summary>
    let Roofs = _prefixId.prefix "Roofs"
    /// <summary>
    ///   <para>vvo:hasID : 9^^xsd:string</para>
    ///   <para>rdfs:label : Seats Choice or Component</para>
    ///   <para>rdfs:comment : The class of seat-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 9</para>
    ///   <a href="http://purl.org/vvo/ns#Seats">vvo:Seats</a>
    /// </summary>
    let Seats = _prefixId.prefix "Seats"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A service or service model. Typical instances are complementing services for a particular car.</para>
    ///   <a href="http://purl.org/vvo/ns#Service">vvo:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>vvo:hasID : 6^^xsd:string</para>
    ///   <para>rdfs:label : Steering Wheels Choice or Component</para>
    ///   <para>rdfs:comment : The class of steering wheels choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 6</para>
    ///   <a href="http://purl.org/vvo/ns#SteeringWheels">vvo:SteeringWheels</a>
    /// </summary>
    let SteeringWheels = _prefixId.prefix "SteeringWheels"
    let TT4SpeedAuto = _prefixId.prefix "TT4SpeedAuto"
    let TT5SpeedAutoDSG = _prefixId.prefix "TT5SpeedAutoDSG"
    let TT5SpeedAutoTiptronic = _prefixId.prefix "TT5SpeedAutoTiptronic"
    let TT5SpeedManual = _prefixId.prefix "TT5SpeedManual"
    let TT6SpeedAuto = _prefixId.prefix "TT6SpeedAuto"
    let TT6SpeedAutoDSG = _prefixId.prefix "TT6SpeedAutoDSG"
    let TT6SpeedAutoTiptronic = _prefixId.prefix "TT6SpeedAutoTiptronic"
    let TT6SpeedManual = _prefixId.prefix "TT6SpeedManual"
    let TT7SpeedAutoDSG = _prefixId.prefix "TT7SpeedAutoDSG"
    let TT8SpeedAuto = _prefixId.prefix "TT8SpeedAuto"
    let TTUnspecified = _prefixId.prefix "TTUnspecified"
    /// <summary>
    ///   <para>rdfs:label : Traffic pattern value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating a traffic pattern, to be used as a reference for vso:fuelConsumption or vso:fuelEconomy</para>
    ///   <a href="http://purl.org/vvo/ns#TrafficPattern">vvo:TrafficPattern</a>
    /// </summary>
    let TrafficPattern = _prefixId.prefix "TrafficPattern"

    /// <summary>
    ///   <para>rdfs:label : TransmissionTypeValueAutomatic</para>
    ///   <para>rdfs:comment : The class of all automatic transmission types</para>
    ///   <a href="http://purl.org/vvo/ns#TransmissionTypeValueAutomatic">vvo:TransmissionTypeValueAutomatic</a>
    /// </summary>
    let TransmissionTypeValueAutomatic =
        _prefixId.prefix "TransmissionTypeValueAutomatic"

    /// <summary>
    ///   <para>rdfs:label : TransmissionTypeValueManual</para>
    ///   <para>rdfs:comment : The class of all manual transmission types</para>
    ///   <a href="http://purl.org/vvo/ns#TransmissionTypeValueManual">vvo:TransmissionTypeValueManual</a>
    /// </summary>
    let TransmissionTypeValueManual = _prefixId.prefix "TransmissionTypeValueManual"
    /// <summary>
    ///   <para>vvo:hasID : 4^^xsd:string</para>
    ///   <para>rdfs:label : Upholstery Choice or Component</para>
    ///   <para>rdfs:comment : The class of upholstery choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 4</para>
    ///   <a href="http://purl.org/vvo/ns#Upholstery">vvo:Upholstery</a>
    /// </summary>
    let Upholstery = _prefixId.prefix "Upholstery"
    let Urban = _prefixId.prefix "Urban"
    /// <summary>
    ///   <para>vvo:hasID : 2^^xsd:string</para>
    ///   <para>rdfs:label : Wheels Choice or Component</para>
    ///   <para>rdfs:comment : The class of wheels-related choices or components (a "MonoSelectGroup" in automotive terminology), VW ID: 2</para>
    ///   <a href="http://purl.org/vvo/ns#Wheels">vvo:Wheels</a>
    /// </summary>
    let Wheels = _prefixId.prefix "Wheels"
    /// <summary>
    ///   <para>rdfs:label : advancedPayment (0..1)</para>
    ///   <para>rdfs:comment : Indicates the advanced payment for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#advancedPayment">vvo:advancedPayment</a>
    /// </summary>
    let advancedPayment = _prefixId.prefix "advancedPayment"
    /// <summary>
    ///   <para>rdfs:label : apr (0..1)</para>
    ///   <para>rdfs:comment : Annual percentage rate. Note: 7.5 % is encoded as "7.5"^^xsd:decimal, not "0.075"^^xsd:decimal.</para>
    ///   <a href="http://purl.org/vvo/ns#apr">vvo:apr</a>
    /// </summary>
    let apr = _prefixId.prefix "apr"
    /// <summary>
    ///   <para>rdfs:label : capCode (0..1)</para>
    ///   <para>rdfs:comment : The CAP code</para>
    ///   <a href="http://purl.org/vvo/ns#capCode">vvo:capCode</a>
    /// </summary>
    let capCode = _prefixId.prefix "capCode"
    /// <summary>
    ///   <para>rdfs:label : credit (0..1)</para>
    ///   <para>rdfs:comment : Indicates the credit for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#credit">vvo:credit</a>
    /// </summary>
    let credit = _prefixId.prefix "credit"
    /// <summary>
    ///   <para>rdfs:label : customerCashPrice (0..1)</para>
    ///   <para>rdfs:comment : Indicates the customer cash price for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#customerCashPrice">vvo:customerCashPrice</a>
    /// </summary>
    let customerCashPrice = _prefixId.prefix "customerCashPrice"
    /// <summary>
    ///   <para>rdfs:label : customerDeposit (0..1)</para>
    ///   <para>rdfs:comment : Indicates the customer deposit for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#customerDeposit">vvo:customerDeposit</a>
    /// </summary>
    let customerDeposit = _prefixId.prefix "customerDeposit"
    /// <summary>
    ///   <para>rdfs:label : cylinderTypeId (0..1)</para>
    ///   <para>rdfs:comment : The Volkswagen-specific identifier for the cylinder type of a vehicle or engine</para>
    ///   <a href="http://purl.org/vvo/ns#cylinderTypeId">vvo:cylinderTypeId</a>
    /// </summary>
    let cylinderTypeId = _prefixId.prefix "cylinderTypeId"
    /// <summary>
    ///   <para>rdfs:label : dateLaunched (0..1)</para>
    ///   <para>rdfs:comment : The date of the official launch of the car model</para>
    ///   <a href="http://purl.org/vvo/ns#dateLaunched">vvo:dateLaunched</a>
    /// </summary>
    let dateLaunched = _prefixId.prefix "dateLaunched"
    /// <summary>
    ///   <para>rdfs:label : depositContribution (0..1)</para>
    ///   <para>rdfs:comment : Indicates the deposit contribution for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#depositContribution">vvo:depositContribution</a>
    /// </summary>
    let depositContribution = _prefixId.prefix "depositContribution"
    /// <summary>
    ///   <para>rdfs:label : dhCode (0..1)</para>
    ///   <para>rdfs:comment : The DH code</para>
    ///   <a href="http://purl.org/vvo/ns#dhCode">vvo:dhCode</a>
    /// </summary>
    let dhCode = _prefixId.prefix "dhCode"
    /// <summary>
    ///   <para>rdfs:label : discount (0..1)</para>
    ///   <para>rdfs:comment : Indicates the discount for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#discount">vvo:discount</a>
    /// </summary>
    let discount = _prefixId.prefix "discount"
    /// <summary>
    ///   <para>rdfs:label : emissions (0..1)</para>
    ///   <para>rdfs:comment : The CO2 emissions in g/km</para>
    ///   <a href="http://purl.org/vvo/ns#emissions">vvo:emissions</a>
    /// </summary>
    let emissions = _prefixId.prefix "emissions"
    /// <summary>
    ///   <para>rdfs:label : excessMileage (0..1)</para>
    ///   <para>rdfs:comment : Indicates the rate for excess mileage</para>
    ///   <a href="http://purl.org/vvo/ns#excessMileage">vvo:excessMileage</a>
    /// </summary>
    let excessMileage = _prefixId.prefix "excessMileage"
    /// <summary>
    ///   <para>rdfs:label : finalPayment (0..1)</para>
    ///   <para>rdfs:comment : Indicates the final payment for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#finalPayment">vvo:finalPayment</a>
    /// </summary>
    let finalPayment = _prefixId.prefix "finalPayment"
    /// <summary>
    ///   <para>rdfs:label : finalPaymentFee (0..1)</para>
    ///   <para>rdfs:comment : Indicates the final payment fee for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#finalPaymentFee">vvo:finalPaymentFee</a>
    /// </summary>
    let finalPaymentFee = _prefixId.prefix "finalPaymentFee"
    /// <summary>
    ///   <para>rdfs:label : firstMonthlyPaymentFee (0..1)</para>
    ///   <para>rdfs:comment : Indicates the first monthly payment fee for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#firstMonthlyPaymentFee">vvo:firstMonthlyPaymentFee</a>
    /// </summary>
    let firstMonthlyPaymentFee = _prefixId.prefix "firstMonthlyPaymentFee"
    /// <summary>
    ///   <para>rdfs:label : fuelInjectionTypeId (0..1)</para>
    ///   <para>rdfs:comment : The Volkswagen-specific identifier for the fuel injection type of a vehicle or engine</para>
    ///   <a href="http://purl.org/vvo/ns#fuelInjectionTypeId">vvo:fuelInjectionTypeId</a>
    /// </summary>
    let fuelInjectionTypeId = _prefixId.prefix "fuelInjectionTypeId"
    /// <summary>
    ///   <para>rdfs:label : gearbox (0..1)</para>
    ///   <para>rdfs:comment : The gearbox type of the vehicle or vehicle model</para>
    ///   <a href="http://purl.org/vvo/ns#gearbox">vvo:gearbox</a>
    /// </summary>
    let gearbox = _prefixId.prefix "gearbox"
    /// <summary>
    ///   <para>rdfs:label : gearboxTypeId (0..1)</para>
    ///   <para>rdfs:comment : The Volkswagen-specific gearbox type ID</para>
    ///   <a href="http://purl.org/vvo/ns#gearboxTypeId">vvo:gearboxTypeId</a>
    /// </summary>
    let gearboxTypeId = _prefixId.prefix "gearboxTypeId"
    /// <summary>
    ///   <para>rdfs:label : hasID (0..1)</para>
    ///   <para>rdfs:comment : An annotation property that can be used to attach element identifiers from XML schemas for the corresponding XML data or schema</para>
    ///   <a href="http://purl.org/vvo/ns#hasID">vvo:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : heightOpenBonnet (0..1)</para>
    ///   <para>rdfs:comment : The outer height of the vehicle with the bonnet open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vvo/ns#heightOpenBonnet">vvo:heightOpenBonnet</a>
    /// </summary>
    let heightOpenBonnet = _prefixId.prefix "heightOpenBonnet"
    /// <summary>
    ///   <para>rdfs:label : heightOpenTailgate (0..1)</para>
    ///   <para>rdfs:comment : The outer height of the vehicle with the tailgate open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vvo/ns#heightOpenTailgate">vvo:heightOpenTailgate</a>
    /// </summary>
    let heightOpenTailgate = _prefixId.prefix "heightOpenTailgate"
    /// <summary>
    ///   <para>rdfs:label : insuranceGroup (0..1)</para>
    ///   <para>rdfs:comment : The insurance group code</para>
    ///   <a href="http://purl.org/vvo/ns#insuranceGroup">vvo:insuranceGroup</a>
    /// </summary>
    let insuranceGroup = _prefixId.prefix "insuranceGroup"
    /// <summary>
    ///   <para>rdfs:label : insuranceGroup50 (0..1)</para>
    ///   <para>rdfs:comment : The insurance group 50 code </para>
    ///   <a href="http://purl.org/vvo/ns#insuranceGroup50">vvo:insuranceGroup50</a>
    /// </summary>
    let insuranceGroup50 = _prefixId.prefix "insuranceGroup50"
    /// <summary>
    ///   <para>rdfs:label : luggageCapacitySeatsFolded (0..1)</para>
    ///   <para>rdfs:comment : The available volume for cargo or luggage with the seats folded
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vvo/ns#luggageCapacitySeatsFolded">vvo:luggageCapacitySeatsFolded</a>
    /// </summary>
    let luggageCapacitySeatsFolded = _prefixId.prefix "luggageCapacitySeatsFolded"
    /// <summary>
    ///   <para>rdfs:label : luggageCapacitySeatsUpright (0..1)</para>
    ///   <para>rdfs:comment : The available volume for cargo or luggage with the seats upright
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vvo/ns#luggageCapacitySeatsUpright">vvo:luggageCapacitySeatsUpright</a>
    /// </summary>
    let luggageCapacitySeatsUpright = _prefixId.prefix "luggageCapacitySeatsUpright"
    /// <summary>
    ///   <para>rdfs:label : manufacturerCode (0..1)</para>
    ///   <para>rdfs:comment : The manufacturer code</para>
    ///   <a href="http://purl.org/vvo/ns#manufacturerCode">vvo:manufacturerCode</a>
    /// </summary>
    let manufacturerCode = _prefixId.prefix "manufacturerCode"
    /// <summary>
    ///   <para>rdfs:label : marketingName (0..1)</para>
    ///   <para>rdfs:comment : The name of the object for marketing purposes</para>
    ///   <a href="http://purl.org/vvo/ns#marketingName">vvo:marketingName</a>
    /// </summary>
    let marketingName = _prefixId.prefix "marketingName"
    /// <summary>
    ///   <para>rdfs:label : monthlyPayment (0..1)</para>
    ///   <para>rdfs:comment : Indicates the monthly payment for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#monthlyPayment">vvo:monthlyPayment</a>
    /// </summary>
    let monthlyPayment = _prefixId.prefix "monthlyPayment"
    /// <summary>
    ///   <para>rdfs:label : noOfMonthlyPayments (0..1)</para>
    ///   <para>rdfs:comment : The number of monthly payments</para>
    ///   <a href="http://purl.org/vvo/ns#noOfMonthlyPayments">vvo:noOfMonthlyPayments</a>
    /// </summary>
    let noOfMonthlyPayments = _prefixId.prefix "noOfMonthlyPayments"
    /// <summary>
    ///   <para>rdfs:label : offerPromoCode (0..1)</para>
    ///   <para>rdfs:comment : The code for a promotional offer</para>
    ///   <a href="http://purl.org/vvo/ns#offerPromoCode">vvo:offerPromoCode</a>
    /// </summary>
    let offerPromoCode = _prefixId.prefix "offerPromoCode"
    /// <summary>
    ///   <para>rdfs:label : otrRetailPrice (0..1)</para>
    ///   <para>rdfs:comment : Indicates the OTR retail price for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#otrRetailPrice">vvo:otrRetailPrice</a>
    /// </summary>
    let otrRetailPrice = _prefixId.prefix "otrRetailPrice"
    /// <summary>
    ///   <para>rdfs:label : productCode (0..1)</para>
    ///   <para>rdfs:comment : The Volkswagen-specific product code for the vehicle model, choice, component, spare part, or service</para>
    ///   <a href="http://purl.org/vvo/ns#productCode">vvo:productCode</a>
    /// </summary>
    let productCode = _prefixId.prefix "productCode"
    /// <summary>
    ///   <para>rdfs:label : refersToTrafficPattern  (0..1)</para>
    ///   <para>rdfs:comment : Indicates the traffic pattern to which the vso:fuelEconomy or vso:fuelConsumption value refers</para>
    ///   <a href="http://purl.org/vvo/ns#refersToTrafficPattern">vvo:refersToTrafficPattern</a>
    /// </summary>
    let refersToTrafficPattern = _prefixId.prefix "refersToTrafficPattern"
    /// <summary>
    ///   <para>rdfs:label : rotationalSpeedReference  (0..1)</para>
    ///   <para>rdfs:comment : The rotational speed to which a vvo:torque or vso:enginePower value refers
    /// Typical unit code(s): RPM for revolutions per minute or RPS for revolutions per second</para>
    ///   <a href="http://purl.org/vvo/ns#rotationalSpeedReference">vvo:rotationalSpeedReference</a>
    /// </summary>
    let rotationalSpeedReference = _prefixId.prefix "rotationalSpeedReference"
    /// <summary>
    ///   <para>rdfs:label : scrappageContribution (0..1)</para>
    ///   <para>rdfs:comment : Indicates the scrappage contribution for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#scrappageContribution">vvo:scrappageContribution</a>
    /// </summary>
    let scrappageContribution = _prefixId.prefix "scrappageContribution"
    /// <summary>
    ///   <para>rdfs:label : shortSubtitle (0..1)</para>
    ///   <para>rdfs:comment : The short subtitle for a vehicle, component, offer, or financing option</para>
    ///   <a href="http://purl.org/vvo/ns#shortSubtitle">vvo:shortSubtitle</a>
    /// </summary>
    let shortSubtitle = _prefixId.prefix "shortSubtitle"
    /// <summary>
    ///   <para>rdfs:label : shortTitle (0..1)</para>
    ///   <para>rdfs:comment : The short title for a vehicle, component, offer, or financing option</para>
    ///   <a href="http://purl.org/vvo/ns#shortTitle">vvo:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    /// <summary>
    ///   <para>rdfs:label : subtitle (0..1)</para>
    ///   <para>rdfs:comment : The subtitle for a vehicle, component, offer, or financing option</para>
    ///   <a href="http://purl.org/vvo/ns#subtitle">vvo:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>rdfs:label : termsAndConditions (0..1)</para>
    ///   <para>rdfs:comment : Terms and conditions of the service, offer, or financing option</para>
    ///   <a href="http://purl.org/vvo/ns#termsAndConditions">vvo:termsAndConditions</a>
    /// </summary>
    let termsAndConditions = _prefixId.prefix "termsAndConditions"
    /// <summary>
    ///   <para>rdfs:label : torque (0..*)</para>
    ///   <para>rdfs:comment : The torque (turning force) of an engine
    /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch</para>
    ///   <a href="http://purl.org/vvo/ns#torque">vvo:torque</a>
    /// </summary>
    let torque = _prefixId.prefix "torque"
    /// <summary>
    ///   <para>rdfs:label : totalPayable (0..1)</para>
    ///   <para>rdfs:comment : Indicates the total payable for the financing</para>
    ///   <a href="http://purl.org/vvo/ns#totalPayable">vvo:totalPayable</a>
    /// </summary>
    let totalPayable = _prefixId.prefix "totalPayable"
    /// <summary>
    ///   <para>rdfs:label : ved (0..1)</para>
    ///   <para>rdfs:comment : The VED code</para>
    ///   <a href="http://purl.org/vvo/ns#ved">vvo:ved</a>
    /// </summary>
    let ved = _prefixId.prefix "ved"
    /// <summary>
    ///   <para>rdfs:label : widthExcludingDoorMirrors (0..1)</para>
    ///   <para>rdfs:comment : The outer width of the vehicle, excluding door mirrors. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vvo/ns#widthExcludingDoorMirrors">vvo:widthExcludingDoorMirrors</a>
    /// </summary>
    let widthExcludingDoorMirrors = _prefixId.prefix "widthExcludingDoorMirrors"
    /// <summary>
    ///   <para>rdfs:label : widthWithDoorsOpen (0..1)</para>
    ///   <para>rdfs:comment : The outer width of the vehicle with the doors open. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vvo/ns#widthWithDoorsOpen">vvo:widthWithDoorsOpen</a>
    /// </summary>
    let widthWithDoorsOpen = _prefixId.prefix "widthWithDoorsOpen"
