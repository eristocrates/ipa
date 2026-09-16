#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module smg =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.cerise-project.nl/energy/def/cim-smartgrid#" "smg"

    /// <summary>
    ///   <para>rdfs:label : AmiBillingReadyKind^^xsd:string</para>
    ///   <para>rdfs:comment : Lifecycle states of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind">smg:AmiBillingReadyKind</a>
    /// </summary>
    let AmiBillingReadyKind = _prefixId.prefix "AmiBillingReadyKind"

    let AmiBillingReadyKind'_period_'amiCapable = _prefixId.prefix "AmiBillingReadyKind.amiCapable"

    let AmiBillingReadyKind'_period_'amiDisabled = _prefixId.prefix "AmiBillingReadyKind.amiDisabled"

    let AmiBillingReadyKind'_period_'billingApproved = _prefixId.prefix "AmiBillingReadyKind.billingApproved"

    let AmiBillingReadyKind'_period_'enabled = _prefixId.prefix "AmiBillingReadyKind.enabled"

    let AmiBillingReadyKind'_period_'nonAmi = _prefixId.prefix "AmiBillingReadyKind.nonAmi"

    let AmiBillingReadyKind'_period_'nonMetered = _prefixId.prefix "AmiBillingReadyKind.nonMetered"

    let AmiBillingReadyKind'_period_'operable = _prefixId.prefix "AmiBillingReadyKind.operable"

    /// <summary>
    ///   <para>rdfs:comment : Common representation for reading values. Note that a reading value may have multiple qualities, as produced by various systems ('ReadingQuality.source').^^xsd:string</para>
    ///   <para>rdfs:label : BaseReading^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading">smg:BaseReading</a>
    /// </summary>
    let BaseReading = _prefixId.prefix "BaseReading"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <para>rdfs:comment : System that originally supplied the reading (e.g., customer, AMI system, handheld reading system, another enterprise system, etc.).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.source">smg:BaseReading.source</a>
    /// </summary>
    let BaseReading'_period_'source = _prefixId.prefix "BaseReading.source"
    /// <summary>
    ///   <para>rdfs:label : timePeriod^^xsd:string</para>
    ///   <para>rdfs:comment : Start and end of the period for those readings whose type has a time attribute such as 'billing', seasonal' or 'forTheSpecifiedPeriod'.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.timePeriod">smg:BaseReading.timePeriod</a>
    /// </summary>
    let BaseReading'_period_'timePeriod = _prefixId.prefix "BaseReading.timePeriod"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>rdfs:comment : Value of this reading.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.value">smg:BaseReading.value</a>
    /// </summary>
    let BaseReading'_period_'value = _prefixId.prefix "BaseReading.value"
    /// <summary>
    ///   <para>rdfs:label : CoordinateSystem^^xsd:string</para>
    ///   <para>rdfs:comment : Coordinate reference system.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem">smg:CoordinateSystem</a>
    /// </summary>
    let CoordinateSystem = _prefixId.prefix "CoordinateSystem"

    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : All locations described with position points in this coordinate system.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.Location">smg:CoordinateSystem.Location</a>
    /// </summary>
    let CoordinateSystem'_period_'Location = _prefixId.prefix "CoordinateSystem.Location"

    /// <summary>
    ///   <para>rdfs:label : crsUrn^^xsd:string</para>
    ///   <para>rdfs:comment : A Uniform Resource Name (URN) for the coordinate reference system (crs) used to define 'Location.PositionPoints'.
    /// An example would be the European Petroleum Survey Group (EPSG) code for a coordinate reference system, defined in URN under the Open Geospatial Consortium (OGC) namespace as: urn:ogc :def:uom:EPSG::XXXX, where XXXX is an EPSG code (a full list of codes can be found at the EPSG Registry website http://www.epsg-registry.org/). To define the coordinate system as being WGS84 (latitude, longitude) using an EPSG OGC, this attribute would be urn:ogc:def:uom:EPSG::4236.
    /// A profile should limit this code to a set of allowed URNs agreed to by all sending and receiving parties.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.crsUrn">smg:CoordinateSystem.crsUrn</a>
    /// </summary>
    let CoordinateSystem'_period_'crsUrn = _prefixId.prefix "CoordinateSystem.crsUrn"
    /// <summary>
    ///   <para>rdfs:label : Customer^^xsd:string</para>
    ///   <para>rdfs:comment : Organisation receiving services from service supplier.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer">smg:Customer</a>
    /// </summary>
    let Customer = _prefixId.prefix "Customer"
    /// <summary>
    ///   <para>rdfs:label : kind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of customer.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer.kind">smg:Customer.kind</a>
    /// </summary>
    let Customer'_period_'kind = _prefixId.prefix "Customer.kind"
    /// <summary>
    ///   <para>rdfs:label : CustomerAgreement^^xsd:string</para>
    ///   <para>rdfs:comment : Agreement between the customer and the service supplier to pay for service at a specific service location. It records certain billing information about the type of service provided at the service location and is used during charge creation to determine the type of service.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement">smg:CustomerAgreement</a>
    /// </summary>
    let CustomerAgreement = _prefixId.prefix "CustomerAgreement"

    /// <summary>
    ///   <para>rdfs:label : Customer^^xsd:string</para>
    ///   <para>rdfs:comment : Customer for this agreement.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.Customer">smg:CustomerAgreement.Customer</a>
    /// </summary>
    let CustomerAgreement'_period_'Customer = _prefixId.prefix "CustomerAgreement.Customer"

    /// <summary>
    ///   <para>rdfs:label : ServiceCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Service category for this agreement.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceCategory">smg:CustomerAgreement.ServiceCategory</a>
    /// </summary>
    let CustomerAgreement'_period_'ServiceCategory = _prefixId.prefix "CustomerAgreement.ServiceCategory"

    /// <summary>
    ///   <para>rdfs:label : ServiceSupplier^^xsd:string</para>
    ///   <para>rdfs:comment : Service supplier for this customer agreement.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceSupplier">smg:CustomerAgreement.ServiceSupplier</a>
    /// </summary>
    let CustomerAgreement'_period_'ServiceSupplier = _prefixId.prefix "CustomerAgreement.ServiceSupplier"

    /// <summary>
    ///   <para>rdfs:label : CustomerKind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of customer.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind">smg:CustomerKind</a>
    /// </summary>
    let CustomerKind = _prefixId.prefix "CustomerKind"

    let CustomerKind'_period_'commercialIndustrial = _prefixId.prefix "CustomerKind.commercialIndustrial"

    let CustomerKind'_period_'energyServiceScheduler = _prefixId.prefix "CustomerKind.energyServiceScheduler"

    let CustomerKind'_period_'energyServiceSupplier = _prefixId.prefix "CustomerKind.energyServiceSupplier"

    let CustomerKind'_period_'internalUse = _prefixId.prefix "CustomerKind.internalUse"
    let CustomerKind'_period_'other = _prefixId.prefix "CustomerKind.other"
    let CustomerKind'_period_'pumpingLoad = _prefixId.prefix "CustomerKind.pumpingLoad"
    let CustomerKind'_period_'residential = _prefixId.prefix "CustomerKind.residential"

    let CustomerKind'_period_'residentialAndCommercial = _prefixId.prefix "CustomerKind.residentialAndCommercial"

    let CustomerKind'_period_'residentialAndStreetlight = _prefixId.prefix "CustomerKind.residentialAndStreetlight"

    let CustomerKind'_period_'residentialFarmService = _prefixId.prefix "CustomerKind.residentialFarmService"

    let CustomerKind'_period_'residentialStreetlightOthers = _prefixId.prefix "CustomerKind.residentialStreetlightOthers"

    let CustomerKind'_period_'windMachine = _prefixId.prefix "CustomerKind.windMachine"
    /// <summary>
    ///   <para>rdfs:comment : Interval between two date and time points.^^xsd:string</para>
    ///   <para>rdfs:label : DateTimeInterval^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval">smg:DateTimeInterval</a>
    /// </summary>
    let DateTimeInterval = _prefixId.prefix "DateTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : end^^xsd:string</para>
    ///   <para>rdfs:comment : End date and time of this interval.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.end">smg:DateTimeInterval.end</a>
    /// </summary>
    let DateTimeInterval'_period_'end = _prefixId.prefix "DateTimeInterval.end"
    /// <summary>
    ///   <para>rdfs:label : start^^xsd:string</para>
    ///   <para>rdfs:comment : Start date and time of this interval.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.start">smg:DateTimeInterval.start</a>
    /// </summary>
    let DateTimeInterval'_period_'start = _prefixId.prefix "DateTimeInterval.start"
    /// <summary>
    ///   <para>rdfs:label : ElectronicAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic address information.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress">smg:ElectronicAddress</a>
    /// </summary>
    let ElectronicAddress = _prefixId.prefix "ElectronicAddress"
    /// <summary>
    ///   <para>rdfs:label : email1^^xsd:string</para>
    ///   <para>rdfs:comment : Primary email address.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email1">smg:ElectronicAddress.email1</a>
    /// </summary>
    let ElectronicAddress'_period_'email1 = _prefixId.prefix "ElectronicAddress.email1"
    /// <summary>
    ///   <para>rdfs:label : email2^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate email address.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email2">smg:ElectronicAddress.email2</a>
    /// </summary>
    let ElectronicAddress'_period_'email2 = _prefixId.prefix "ElectronicAddress.email2"
    /// <summary>
    ///   <para>rdfs:label : lan^^xsd:string</para>
    ///   <para>rdfs:comment : Address on local area network.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.lan">smg:ElectronicAddress.lan</a>
    /// </summary>
    let ElectronicAddress'_period_'lan = _prefixId.prefix "ElectronicAddress.lan"
    /// <summary>
    ///   <para>rdfs:label : mac^^xsd:string</para>
    ///   <para>rdfs:comment : MAC (Media Access Control) address.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.mac">smg:ElectronicAddress.mac</a>
    /// </summary>
    let ElectronicAddress'_period_'mac = _prefixId.prefix "ElectronicAddress.mac"

    /// <summary>
    ///   <para>rdfs:label : password^^xsd:string</para>
    ///   <para>rdfs:comment : Password needed to log in.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.password">smg:ElectronicAddress.password</a>
    /// </summary>
    let ElectronicAddress'_period_'password = _prefixId.prefix "ElectronicAddress.password"

    /// <summary>
    ///   <para>rdfs:label : radio^^xsd:string</para>
    ///   <para>rdfs:comment : Radio address.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.radio">smg:ElectronicAddress.radio</a>
    /// </summary>
    let ElectronicAddress'_period_'radio = _prefixId.prefix "ElectronicAddress.radio"
    /// <summary>
    ///   <para>rdfs:label : userID^^xsd:string</para>
    ///   <para>rdfs:comment : User ID needed to log in, which can be for an individual person, an organisation, a location, etc.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.userID">smg:ElectronicAddress.userID</a>
    /// </summary>
    let ElectronicAddress'_period_'userID = _prefixId.prefix "ElectronicAddress.userID"
    /// <summary>
    ///   <para>rdfs:label : web^^xsd:string</para>
    ///   <para>rdfs:comment : World wide web address.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.web">smg:ElectronicAddress.web</a>
    /// </summary>
    let ElectronicAddress'_period_'web = _prefixId.prefix "ElectronicAddress.web"
    /// <summary>
    ///   <para>rdfs:label : EndDevice^^xsd:string</para>
    ///   <para>rdfs:comment : Asset container that performs one or more end device functions. One type of end device is a meter which can perform metering, load management, connect/disconnect, accounting functions, etc. Some end devices, such as ones monitoring and controlling air conditioner, refrigerator, pool pumps may be connected to a meter. All end devices may have communication capability defined by the associated communication function(s). An end device may be owned by a consumer, a service provider, utility or otherwise.
    /// There may be a related end device function that identifies a sensor or control point within a metering application or communications systems (e.g., water, gas, electricity).
    /// Some devices may use an optical port that conforms to the ANSI C12.18 standard for communications.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice">smg:EndDevice</a>
    /// </summary>
    let EndDevice = _prefixId.prefix "EndDevice"

    /// <summary>
    ///   <para>rdfs:label : EndDeviceFunctions^^xsd:string</para>
    ///   <para>rdfs:comment : All end device functions this end device performs.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.EndDeviceFunctions">smg:EndDevice.EndDeviceFunctions</a>
    /// </summary>
    let EndDevice'_period_'EndDeviceFunctions = _prefixId.prefix "EndDevice.EndDeviceFunctions"

    /// <summary>
    ///   <para>rdfs:label : UsagePoint^^xsd:string</para>
    ///   <para>rdfs:comment : Usage point to which this end device belongs.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.UsagePoint">smg:EndDevice.UsagePoint</a>
    /// </summary>
    let EndDevice'_period_'UsagePoint = _prefixId.prefix "EndDevice.UsagePoint"
    /// <summary>
    ///   <para>rdfs:label : installCode^^xsd:string</para>
    ///   <para>rdfs:comment : Installation code.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.installCode">smg:EndDevice.installCode</a>
    /// </summary>
    let EndDevice'_period_'installCode = _prefixId.prefix "EndDevice.installCode"
    /// <summary>
    ///   <para>rdfs:label : isVirtual^^xsd:string</para>
    ///   <para>rdfs:comment : If true, there is no physical device. As an example, a virtual meter can be defined to aggregate the consumption for two or more physical meters. Otherwise, this is a physical hardware device.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.isVirtual">smg:EndDevice.isVirtual</a>
    /// </summary>
    let EndDevice'_period_'isVirtual = _prefixId.prefix "EndDevice.isVirtual"
    /// <summary>
    ///   <para>rdfs:label : EndDeviceFunction^^xsd:string</para>
    ///   <para>rdfs:comment : Function performed by an end device such as a meter, communication equipment, controllers, etc.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction">smg:EndDeviceFunction</a>
    /// </summary>
    let EndDeviceFunction = _prefixId.prefix "EndDeviceFunction"

    /// <summary>
    ///   <para>rdfs:label : EndDevice^^xsd:string</para>
    ///   <para>rdfs:comment : End device that performs this function.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction.EndDevice">smg:EndDeviceFunction.EndDevice</a>
    /// </summary>
    let EndDeviceFunction'_period_'EndDevice = _prefixId.prefix "EndDeviceFunction.EndDevice"

    /// <summary>
    ///   <para>rdfs:label : EndDeviceFunctionKind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of end device function.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind">smg:EndDeviceFunctionKind</a>
    /// </summary>
    let EndDeviceFunctionKind = _prefixId.prefix "EndDeviceFunctionKind"

    let EndDeviceFunctionKind'_period_'autonomousDst = _prefixId.prefix "EndDeviceFunctionKind.autonomousDst"

    let EndDeviceFunctionKind'_period_'demandResponse = _prefixId.prefix "EndDeviceFunctionKind.demandResponse"

    let EndDeviceFunctionKind'_period_'electricMetering = _prefixId.prefix "EndDeviceFunctionKind.electricMetering"

    let EndDeviceFunctionKind'_period_'gasMetering = _prefixId.prefix "EndDeviceFunctionKind.gasMetering"

    let EndDeviceFunctionKind'_period_'metrology = _prefixId.prefix "EndDeviceFunctionKind.metrology"

    let EndDeviceFunctionKind'_period_'onRequestRead = _prefixId.prefix "EndDeviceFunctionKind.onRequestRead"

    let EndDeviceFunctionKind'_period_'outageHistory = _prefixId.prefix "EndDeviceFunctionKind.outageHistory"

    let EndDeviceFunctionKind'_period_'relaysProgramming = _prefixId.prefix "EndDeviceFunctionKind.relaysProgramming"

    let EndDeviceFunctionKind'_period_'reverseFlow = _prefixId.prefix "EndDeviceFunctionKind.reverseFlow"

    let EndDeviceFunctionKind'_period_'waterMetering = _prefixId.prefix "EndDeviceFunctionKind.waterMetering"

    /// <summary>
    ///   <para>rdfs:comment : This is a root class to provide common identification for all classes needing identification and naming attributes.^^xsd:string</para>
    ///   <para>rdfs:label : IdentifiedObject^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject">smg:IdentifiedObject</a>
    /// </summary>
    let IdentifiedObject = _prefixId.prefix "IdentifiedObject"

    /// <summary>
    ///   <para>rdfs:label : aliasName^^xsd:string</para>
    ///   <para>rdfs:comment : The aliasName is free text human readable name of the object alternative to IdentifiedObject.name. It may be non unique and may not correlate to a naming hierarchy.
    /// The attribute aliasName is retained because of backwards compatibility between CIM relases. It is however recommended to replace aliasName with the Name class as aliasName is planned for retirement at a future time.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.aliasName">smg:IdentifiedObject.aliasName</a>
    /// </summary>
    let IdentifiedObject'_period_'aliasName = _prefixId.prefix "IdentifiedObject.aliasName"

    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>rdfs:comment : The description is a free human readable text describing or naming the object. It may be non unique and may not correlate to a naming hierarchy.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.description">smg:IdentifiedObject.description</a>
    /// </summary>
    let IdentifiedObject'_period_'description = _prefixId.prefix "IdentifiedObject.description"

    /// <summary>
    ///   <para>rdfs:label : mRID^^xsd:string</para>
    ///   <para>rdfs:comment : Master resource identifier issued by a model authority. The mRID must semantically be a UUID as specified in RFC 4122. The mRID is globally unique.
    /// For CIMXML data files in RDF syntax, the mRID is mapped to rdf:ID or rdf:about attributes that identify CIM object elements.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.mRID">smg:IdentifiedObject.mRID</a>
    /// </summary>
    let IdentifiedObject'_period_'mRID = _prefixId.prefix "IdentifiedObject.mRID"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : The name is any free human readable and possibly non unique text naming the object.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.name">smg:IdentifiedObject.name</a>
    /// </summary>
    let IdentifiedObject'_period_'name = _prefixId.prefix "IdentifiedObject.name"
    /// <summary>
    ///   <para>rdfs:label : IntervalBlock^^xsd:string</para>
    ///   <para>rdfs:comment : Time sequence of readings of the same reading type. Contained interval readings may need conversion through the application of an offset and a scalar defined in associated pending.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock">smg:IntervalBlock</a>
    /// </summary>
    let IntervalBlock = _prefixId.prefix "IntervalBlock"

    /// <summary>
    ///   <para>rdfs:label : IntervalReadings^^xsd:string</para>
    ///   <para>rdfs:comment : Interval reading contained in this block.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.IntervalReadings">smg:IntervalBlock.IntervalReadings</a>
    /// </summary>
    let IntervalBlock'_period_'IntervalReadings = _prefixId.prefix "IntervalBlock.IntervalReadings"

    /// <summary>
    ///   <para>rdfs:label : MeterReading^^xsd:string</para>
    ///   <para>rdfs:comment : Meter reading containing this interval block.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.MeterReading">smg:IntervalBlock.MeterReading</a>
    /// </summary>
    let IntervalBlock'_period_'MeterReading = _prefixId.prefix "IntervalBlock.MeterReading"

    /// <summary>
    ///   <para>rdfs:label : ReadingType^^xsd:string</para>
    ///   <para>rdfs:comment : Type information for interval reading values contained in this block.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.ReadingType">smg:IntervalBlock.ReadingType</a>
    /// </summary>
    let IntervalBlock'_period_'ReadingType = _prefixId.prefix "IntervalBlock.ReadingType"

    /// <summary>
    ///   <para>rdfs:comment : Data captured at regular intervals of time. Interval data could be captured as incremental data, absolute data, or relative data. The source for the data is usually a tariff quantity or an engineering quantity. Data is typically captured in time-tagged, uniform, fixed-length intervals of 5 min, 10 min, 15 min, 30 min, or 60 min.
    /// Note: Interval Data is sometimes also called "Interval Data Readings" (IDR).^^xsd:string</para>
    ///   <para>rdfs:label : IntervalReading^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading">smg:IntervalReading</a>
    /// </summary>
    let IntervalReading = _prefixId.prefix "IntervalReading"

    /// <summary>
    ///   <para>rdfs:label : IntervalBlocks^^xsd:string</para>
    ///   <para>rdfs:comment : All blocks containing this interval reading.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading.IntervalBlocks">smg:IntervalReading.IntervalBlocks</a>
    /// </summary>
    let IntervalReading'_period_'IntervalBlocks = _prefixId.prefix "IntervalReading.IntervalBlocks"

    /// <summary>
    ///   <para>rdfs:comment : The place, scene, or point of something where someone or something has been, is, and/or will be at a given moment in time. It can be defined with one or more postition points (coordinates) in a given coordinate system.^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location">smg:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"

    /// <summary>
    ///   <para>rdfs:label : CoordinateSystem^^xsd:string</para>
    ///   <para>rdfs:comment : Coordinate system used to describe position points of this location.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.CoordinateSystem">smg:Location.CoordinateSystem</a>
    /// </summary>
    let Location'_period_'CoordinateSystem = _prefixId.prefix "Location.CoordinateSystem"

    /// <summary>
    ///   <para>rdfs:label : PositionPoints^^xsd:string</para>
    ///   <para>rdfs:comment : Sequence of position points describing this location, expressed in coordinate system 'Location.CoordinateSystem'.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.PositionPoints">smg:Location.PositionPoints</a>
    /// </summary>
    let Location'_period_'PositionPoints = _prefixId.prefix "Location.PositionPoints"

    /// <summary>
    ///   <para>rdfs:label : electronicAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Electronic address.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.electronicAddress">smg:Location.electronicAddress</a>
    /// </summary>
    let Location'_period_'electronicAddress = _prefixId.prefix "Location.electronicAddress"

    /// <summary>
    ///   <para>rdfs:label : geoInfoReference^^xsd:string</para>
    ///   <para>rdfs:comment : (if applicable) Reference to geographical information source, often external to the utility.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.geoInfoReference">smg:Location.geoInfoReference</a>
    /// </summary>
    let Location'_period_'geoInfoReference = _prefixId.prefix "Location.geoInfoReference"

    /// <summary>
    ///   <para>rdfs:label : mainAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Main address of the location.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.mainAddress">smg:Location.mainAddress</a>
    /// </summary>
    let Location'_period_'mainAddress = _prefixId.prefix "Location.mainAddress"
    /// <summary>
    ///   <para>rdfs:label : phone1^^xsd:string</para>
    ///   <para>rdfs:comment : Phone number.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone1">smg:Location.phone1</a>
    /// </summary>
    let Location'_period_'phone1 = _prefixId.prefix "Location.phone1"
    /// <summary>
    ///   <para>rdfs:label : phone2^^xsd:string</para>
    ///   <para>rdfs:comment : Additional phone number.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone2">smg:Location.phone2</a>
    /// </summary>
    let Location'_period_'phone2 = _prefixId.prefix "Location.phone2"

    /// <summary>
    ///   <para>rdfs:label : secondaryAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Secondary address of the location. For example, PO Box address may have different ZIP code than that in the 'mainAddress'.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.secondaryAddress">smg:Location.secondaryAddress</a>
    /// </summary>
    let Location'_period_'secondaryAddress = _prefixId.prefix "Location.secondaryAddress"

    /// <summary>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>rdfs:comment : Status of this location.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.status">smg:Location.status</a>
    /// </summary>
    let Location'_period_'status = _prefixId.prefix "Location.status"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:comment : Classification by utility's corporate standards and practices, relative to the location itself (e.g., geographical, functional accounting, etc., not a given property that happens to exist at that location).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.type">smg:Location.type</a>
    /// </summary>
    let Location'_period_'type = _prefixId.prefix "Location.type"
    /// <summary>
    ///   <para>rdfs:label : Meter^^xsd:string</para>
    ///   <para>rdfs:comment : Physical asset that performs the metering role of the usage point. Used for measuring consumption and detection of events.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter">smg:Meter</a>
    /// </summary>
    let Meter = _prefixId.prefix "Meter"
    /// <summary>
    ///   <para>rdfs:label : MeterMultipliers^^xsd:string</para>
    ///   <para>rdfs:comment : All multipliers applied at this meter.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterMultipliers">smg:Meter.MeterMultipliers</a>
    /// </summary>
    let Meter'_period_'MeterMultipliers = _prefixId.prefix "Meter.MeterMultipliers"
    /// <summary>
    ///   <para>rdfs:label : MeterReadings^^xsd:string</para>
    ///   <para>rdfs:comment : All meter readings provided by this meter.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterReadings">smg:Meter.MeterReadings</a>
    /// </summary>
    let Meter'_period_'MeterReadings = _prefixId.prefix "Meter.MeterReadings"
    /// <summary>
    ///   <para>rdfs:label : formNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Meter form designation per ANSI C12.10 or other applicable standard. An alphanumeric designation denoting the circuit arrangement for which the meter is applicable and its specific terminal arrangement.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.formNumber">smg:Meter.formNumber</a>
    /// </summary>
    let Meter'_period_'formNumber = _prefixId.prefix "Meter.formNumber"
    /// <summary>
    ///   <para>rdfs:comment : Multiplier applied at the meter.^^xsd:string</para>
    ///   <para>rdfs:label : MeterMultiplier^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier">smg:MeterMultiplier</a>
    /// </summary>
    let MeterMultiplier = _prefixId.prefix "MeterMultiplier"
    /// <summary>
    ///   <para>rdfs:label : Meter^^xsd:string</para>
    ///   <para>rdfs:comment : Meter applying this multiplier.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.Meter">smg:MeterMultiplier.Meter</a>
    /// </summary>
    let MeterMultiplier'_period_'Meter = _prefixId.prefix "MeterMultiplier.Meter"
    /// <summary>
    ///   <para>rdfs:label : kind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of multiplier.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.kind">smg:MeterMultiplier.kind</a>
    /// </summary>
    let MeterMultiplier'_period_'kind = _prefixId.prefix "MeterMultiplier.kind"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>rdfs:comment : Multiplier value.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.value">smg:MeterMultiplier.value</a>
    /// </summary>
    let MeterMultiplier'_period_'value = _prefixId.prefix "MeterMultiplier.value"
    /// <summary>
    ///   <para>rdfs:label : MeterMultiplierKind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of meter multiplier.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind">smg:MeterMultiplierKind</a>
    /// </summary>
    let MeterMultiplierKind = _prefixId.prefix "MeterMultiplierKind"

    let MeterMultiplierKind'_period_'ctRatio = _prefixId.prefix "MeterMultiplierKind.ctRatio"

    let MeterMultiplierKind'_period_'kE = _prefixId.prefix "MeterMultiplierKind.kE"
    let MeterMultiplierKind'_period_'kH = _prefixId.prefix "MeterMultiplierKind.kH"
    let MeterMultiplierKind'_period_'kR = _prefixId.prefix "MeterMultiplierKind.kR"

    let MeterMultiplierKind'_period_'ptRatio = _prefixId.prefix "MeterMultiplierKind.ptRatio"

    let MeterMultiplierKind'_period_'transformerRatio = _prefixId.prefix "MeterMultiplierKind.transformerRatio"

    /// <summary>
    ///   <para>rdfs:comment : Set of values obtained from the meter.^^xsd:string</para>
    ///   <para>rdfs:label : MeterReading^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading">smg:MeterReading</a>
    /// </summary>
    let MeterReading = _prefixId.prefix "MeterReading"

    /// <summary>
    ///   <para>rdfs:label : CustomerAgreement^^xsd:string</para>
    ///   <para>rdfs:comment : (could be deprecated in the future) Customer agreement for this meter reading.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.CustomerAgreement">smg:MeterReading.CustomerAgreement</a>
    /// </summary>
    let MeterReading'_period_'CustomerAgreement = _prefixId.prefix "MeterReading.CustomerAgreement"

    /// <summary>
    ///   <para>rdfs:label : Meter^^xsd:string</para>
    ///   <para>rdfs:comment : Meter providing this reading.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Meter">smg:MeterReading.Meter</a>
    /// </summary>
    let MeterReading'_period_'Meter = _prefixId.prefix "MeterReading.Meter"
    /// <summary>
    ///   <para>rdfs:label : Readings^^xsd:string</para>
    ///   <para>rdfs:comment : All reading values contained within this meter reading.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Readings">smg:MeterReading.Readings</a>
    /// </summary>
    let MeterReading'_period_'Readings = _prefixId.prefix "MeterReading.Readings"
    /// <summary>
    ///   <para>rdfs:label : UsagePoint^^xsd:string</para>
    ///   <para>rdfs:comment : Usage point from which this meter reading (set of values) has been obtained.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.UsagePoint">smg:MeterReading.UsagePoint</a>
    /// </summary>
    let MeterReading'_period_'UsagePoint = _prefixId.prefix "MeterReading.UsagePoint"

    /// <summary>
    ///   <para>rdfs:label : valuesInterval^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time interval of the data items contained within this meter reading.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.valuesInterval">smg:MeterReading.valuesInterval</a>
    /// </summary>
    let MeterReading'_period_'valuesInterval = _prefixId.prefix "MeterReading.valuesInterval"

    /// <summary>
    ///   <para>rdfs:label : OrganisationRole^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies a way in which an organisation may participate in the utility enterprise (e.g., customer, manufacturer, etc).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#OrganisationRole">smg:OrganisationRole</a>
    /// </summary>
    let OrganisationRole = _prefixId.prefix "OrganisationRole"
    let Package_Base = _prefixId.prefix "Package_Base"
    let Package_Common = _prefixId.prefix "Package_Common"
    let Package_Core = _prefixId.prefix "Package_Core"
    let Package_Customers = _prefixId.prefix "Package_Customers"
    let Package_Domain = _prefixId.prefix "Package_Domain"
    let Package_IEC61968 = _prefixId.prefix "Package_IEC61968"
    let Package_IEC61970 = _prefixId.prefix "Package_IEC61970"
    let Package_Metering = _prefixId.prefix "Package_Metering"
    let Package_PaymentMetering = _prefixId.prefix "Package_PaymentMetering"
    let Package_TC57CIM = _prefixId.prefix "Package_TC57CIM"
    /// <summary>
    ///   <para>rdfs:label : PositionPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Set of spatial coordinates that determine a point, defined in coordinate system specified in 'Location.CoordinateSystem'. Use a single position point instance to desribe a point-oriented location. Use a sequence of position points to describe a line-oriented object (physical location of non-point oriented objects like cables or lines), or area of an object (like a substation or a geographical zone - in this case, have first and last position point with the same values).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint">smg:PositionPoint</a>
    /// </summary>
    let PositionPoint = _prefixId.prefix "PositionPoint"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : Location described by this position point.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.Location">smg:PositionPoint.Location</a>
    /// </summary>
    let PositionPoint'_period_'Location = _prefixId.prefix "PositionPoint.Location"

    /// <summary>
    ///   <para>rdfs:label : sequenceNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Zero-relative sequence number of this point within a series of points.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.sequenceNumber">smg:PositionPoint.sequenceNumber</a>
    /// </summary>
    let PositionPoint'_period_'sequenceNumber = _prefixId.prefix "PositionPoint.sequenceNumber"

    /// <summary>
    ///   <para>rdfs:label : xPosition^^xsd:string</para>
    ///   <para>rdfs:comment : X axis position.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.xPosition">smg:PositionPoint.xPosition</a>
    /// </summary>
    let PositionPoint'_period_'xPosition = _prefixId.prefix "PositionPoint.xPosition"
    /// <summary>
    ///   <para>rdfs:label : yPosition^^xsd:string</para>
    ///   <para>rdfs:comment : Y axis position.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.yPosition">smg:PositionPoint.yPosition</a>
    /// </summary>
    let PositionPoint'_period_'yPosition = _prefixId.prefix "PositionPoint.yPosition"
    /// <summary>
    ///   <para>rdfs:label : zPosition^^xsd:string</para>
    ///   <para>rdfs:comment : (if applicable) Z axis position.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.zPosition">smg:PositionPoint.zPosition</a>
    /// </summary>
    let PositionPoint'_period_'zPosition = _prefixId.prefix "PositionPoint.zPosition"
    /// <summary>
    ///   <para>rdfs:comment : Specific value measured by a meter or other asset, or calculated by a system. Each Reading is associated with a specific ReadingType.^^xsd:string</para>
    ///   <para>rdfs:label : Reading^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading">smg:Reading</a>
    /// </summary>
    let Reading = _prefixId.prefix "Reading"
    /// <summary>
    ///   <para>rdfs:label : MeterReadings^^xsd:string</para>
    ///   <para>rdfs:comment : All meter readings (sets of values) containing this reading value.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.MeterReadings">smg:Reading.MeterReadings</a>
    /// </summary>
    let Reading'_period_'MeterReadings = _prefixId.prefix "Reading.MeterReadings"
    /// <summary>
    ///   <para>rdfs:label : ReadingType^^xsd:string</para>
    ///   <para>rdfs:comment : Type information for this reading value.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.ReadingType">smg:Reading.ReadingType</a>
    /// </summary>
    let Reading'_period_'ReadingType = _prefixId.prefix "Reading.ReadingType"
    /// <summary>
    ///   <para>rdfs:label : ReadingType^^xsd:string</para>
    ///   <para>rdfs:comment : Detailed description for a type of a reading value. Values in attributes allow for creation of recommended codes to be used for identifying reading value types as follows: &amp;lt;macroPeriod&amp;gt;.&amp;lt;aggregate&amp;gt;.&amp;lt;measuringPeriod&amp;gt;.&amp;lt;accumulation&amp;gt;.&amp;lt;flowDirection&amp;gt;.&amp;lt;commodity&amp;gt;.&amp;lt;measurementKind&amp;gt;.&amp;lt;interharmonic.numerator&amp;gt;.&amp;lt;interharmonic.denominator&amp;gt;.&amp;lt;argument.numerator&amp;gt;.&amp;lt;argument.denominator&amp;gt;.&amp;lt;tou&amp;gt;.&amp;lt;cpp&amp;gt;.&amp;lt;consumptionTier&amp;gt;.&amp;lt;phases&amp;gt;.&amp;lt;multiplier&amp;gt;.&amp;lt;unit&amp;gt;.&amp;lt;currency&amp;gt;.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType">smg:ReadingType</a>
    /// </summary>
    let ReadingType = _prefixId.prefix "ReadingType"
    /// <summary>
    ///   <para>rdfs:label : accumulation^^xsd:string</para>
    ///   <para>rdfs:comment : Accumulation behaviour of a reading over time, usually 'measuringPeriod', to be used with individual endpoints (as opposed to 'macroPeriod' and 'aggregate' that are used to describe aggregations of data from individual endpoints).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.accumulation">smg:ReadingType.accumulation</a>
    /// </summary>
    let ReadingType'_period_'accumulation = _prefixId.prefix "ReadingType.accumulation"
    /// <summary>
    ///   <para>rdfs:label : aggregate^^xsd:string</para>
    ///   <para>rdfs:comment : Salient attribute of the reading data aggregated from individual endpoints. This is mainly used to define a mathematical operation carried out over 'macroPeriod', but may also be used to describe an attribute of the data when the 'macroPeriod' is not defined.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.aggregate">smg:ReadingType.aggregate</a>
    /// </summary>
    let ReadingType'_period_'aggregate = _prefixId.prefix "ReadingType.aggregate"
    /// <summary>
    ///   <para>rdfs:label : commodity^^xsd:string</para>
    ///   <para>rdfs:comment : Commodity being measured.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.commodity">smg:ReadingType.commodity</a>
    /// </summary>
    let ReadingType'_period_'commodity = _prefixId.prefix "ReadingType.commodity"

    /// <summary>
    ///   <para>rdfs:label : flowDirection^^xsd:string</para>
    ///   <para>rdfs:comment : Flow direction for a reading where the direction of flow of the commodity is important (for electricity measurements this includes current, energy, power, and demand).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.flowDirection">smg:ReadingType.flowDirection</a>
    /// </summary>
    let ReadingType'_period_'flowDirection = _prefixId.prefix "ReadingType.flowDirection"

    /// <summary>
    ///   <para>rdfs:label : measurementKind^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies "what" is being measured, as refinement of 'commodity'. When combined with 'unit', it provides detail to the unit of measure. For example, 'energy' with a unit of measure of 'kWh' indicates to the user that active energy is being measured, while with 'kVAh' or 'kVArh', it indicates apparent energy and reactive energy, respectively. 'power' can be combined in a similar way with various power units of measure: Distortion power ('distortionVoltAmperes') with 'kVA' is different from 'power' with 'kVA'.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measurementKind">smg:ReadingType.measurementKind</a>
    /// </summary>
    let ReadingType'_period_'measurementKind = _prefixId.prefix "ReadingType.measurementKind"

    /// <summary>
    ///   <para>rdfs:label : measuringPeriod^^xsd:string</para>
    ///   <para>rdfs:comment : Time attribute inherent or fundamental to the reading value (as opposed to 'macroPeriod' that supplies an "adjective" to describe aspects of a time period with regard to the measurement). It refers to the way the value was originally measured and not to the frequency at which it is reported or presented. For example, an hourly interval of consumption data would have value 'hourly' as an attribute. However in the case of an hourly sampled voltage value, the meterReadings schema would carry the 'hourly' interval size information.
    /// It is common for meters to report demand in a form that is measured over the course of a portion of an hour, while enterprise applications however commonly assume the demand (in kW or kVAr) normalised to 1 hour. The sytem that receives readings directly from the meter therefore must perform this transformation before publishing readings for use by the other enterprise systems. The scalar used is chosen based on the block size (not any sub-interval size).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measuringPeriod">smg:ReadingType.measuringPeriod</a>
    /// </summary>
    let ReadingType'_period_'measuringPeriod = _prefixId.prefix "ReadingType.measuringPeriod"

    /// <summary>
    ///   <para>rdfs:label : unit^^xsd:string</para>
    ///   <para>rdfs:comment : Metering-specific unit.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.unit">smg:ReadingType.unit</a>
    /// </summary>
    let ReadingType'_period_'unit = _prefixId.prefix "ReadingType.unit"
    /// <summary>
    ///   <para>rdfs:label : ServiceCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Category of service provided to the customer.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory">smg:ServiceCategory</a>
    /// </summary>
    let ServiceCategory = _prefixId.prefix "ServiceCategory"
    /// <summary>
    ///   <para>rdfs:label : kind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of service.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory.kind">smg:ServiceCategory.kind</a>
    /// </summary>
    let ServiceCategory'_period_'kind = _prefixId.prefix "ServiceCategory.kind"
    /// <summary>
    ///   <para>rdfs:label : ServiceKind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of service.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind">smg:ServiceKind</a>
    /// </summary>
    let ServiceKind = _prefixId.prefix "ServiceKind"
    let ServiceKind'_period_'electricity = _prefixId.prefix "ServiceKind.electricity"
    let ServiceKind'_period_'gas = _prefixId.prefix "ServiceKind.gas"
    let ServiceKind'_period_'heat = _prefixId.prefix "ServiceKind.heat"
    let ServiceKind'_period_'internet = _prefixId.prefix "ServiceKind.internet"
    let ServiceKind'_period_'other = _prefixId.prefix "ServiceKind.other"
    let ServiceKind'_period_'rates = _prefixId.prefix "ServiceKind.rates"
    let ServiceKind'_period_'refuse = _prefixId.prefix "ServiceKind.refuse"
    let ServiceKind'_period_'sewerage = _prefixId.prefix "ServiceKind.sewerage"
    let ServiceKind'_period_'time = _prefixId.prefix "ServiceKind.time"
    let ServiceKind'_period_'tvLicence = _prefixId.prefix "ServiceKind.tvLicence"
    let ServiceKind'_period_'water = _prefixId.prefix "ServiceKind.water"
    /// <summary>
    ///   <para>rdfs:label : ServiceSupplier^^xsd:string</para>
    ///   <para>rdfs:comment : Organisation that provides services to customers.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier">smg:ServiceSupplier</a>
    /// </summary>
    let ServiceSupplier = _prefixId.prefix "ServiceSupplier"

    /// <summary>
    ///   <para>rdfs:label : issuerIdentificationNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Unique transaction reference prefix number issued to an entity by the International Standards Organisation for the purpose of tagging onto electronic financial transactions, as defined in ISO/IEC 7812-1 and ISO/IEC 7812-2.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.issuerIdentificationNumber">smg:ServiceSupplier.issuerIdentificationNumber</a>
    /// </summary>
    let ServiceSupplier'_period_'issuerIdentificationNumber = _prefixId.prefix "ServiceSupplier.issuerIdentificationNumber"

    /// <summary>
    ///   <para>rdfs:label : kind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of supplier.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.kind">smg:ServiceSupplier.kind</a>
    /// </summary>
    let ServiceSupplier'_period_'kind = _prefixId.prefix "ServiceSupplier.kind"
    /// <summary>
    ///   <para>rdfs:label : SimpleEndDeviceFunction^^xsd:string</para>
    ///   <para>rdfs:comment : Simple end device function distinguished by 'kind'. Use this class for instances that cannot be represented by another end device function specialisations.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction">smg:SimpleEndDeviceFunction</a>
    /// </summary>
    let SimpleEndDeviceFunction = _prefixId.prefix "SimpleEndDeviceFunction"

    /// <summary>
    ///   <para>rdfs:label : kind^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of this function.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction.kind">smg:SimpleEndDeviceFunction.kind</a>
    /// </summary>
    let SimpleEndDeviceFunction'_period_'kind = _prefixId.prefix "SimpleEndDeviceFunction.kind"

    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>rdfs:comment : Current status information relevant to an entity.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status">smg:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : dateTime^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time for which status 'value' applies.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.dateTime">smg:Status.dateTime</a>
    /// </summary>
    let Status'_period_'dateTime = _prefixId.prefix "Status.dateTime"
    /// <summary>
    ///   <para>rdfs:label : reason^^xsd:string</para>
    ///   <para>rdfs:comment : Reason code or explanation for why an object went to the current status 'value'.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.reason">smg:Status.reason</a>
    /// </summary>
    let Status'_period_'reason = _prefixId.prefix "Status.reason"
    /// <summary>
    ///   <para>rdfs:label : remark^^xsd:string</para>
    ///   <para>rdfs:comment : Pertinent information regarding the current 'value', as free form text.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.remark">smg:Status.remark</a>
    /// </summary>
    let Status'_period_'remark = _prefixId.prefix "Status.remark"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>rdfs:comment : Status value at 'dateTime'; prior status changes may have been kept in instances of activity records associated with the object to which this status applies.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.value">smg:Status.value</a>
    /// </summary>
    let Status'_period_'value = _prefixId.prefix "Status.value"
    /// <summary>
    ///   <para>rdfs:label : StreetAddress^^xsd:string</para>
    ///   <para>rdfs:comment : General purpose street address information.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress">smg:StreetAddress</a>
    /// </summary>
    let StreetAddress = _prefixId.prefix "StreetAddress"

    /// <summary>
    ///   <para>rdfs:label : streetDetail^^xsd:string</para>
    ///   <para>rdfs:comment : Street detail.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.streetDetail">smg:StreetAddress.streetDetail</a>
    /// </summary>
    let StreetAddress'_period_'streetDetail = _prefixId.prefix "StreetAddress.streetDetail"

    /// <summary>
    ///   <para>rdfs:label : townDetail^^xsd:string</para>
    ///   <para>rdfs:comment : Town detail.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.townDetail">smg:StreetAddress.townDetail</a>
    /// </summary>
    let StreetAddress'_period_'townDetail = _prefixId.prefix "StreetAddress.townDetail"
    /// <summary>
    ///   <para>rdfs:comment : Street details, in the context of address.^^xsd:string</para>
    ///   <para>rdfs:label : StreetDetail^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail">smg:StreetDetail</a>
    /// </summary>
    let StreetDetail = _prefixId.prefix "StreetDetail"

    /// <summary>
    ///   <para>rdfs:label : addressGeneral^^xsd:string</para>
    ///   <para>rdfs:comment : Additional address information, for example a mailstop.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.addressGeneral">smg:StreetDetail.addressGeneral</a>
    /// </summary>
    let StreetDetail'_period_'addressGeneral = _prefixId.prefix "StreetDetail.addressGeneral"

    /// <summary>
    ///   <para>rdfs:label : buildingName^^xsd:string</para>
    ///   <para>rdfs:comment : (if applicable) In certain cases the physical location of the place of interest does not have a direct point of entry from the street, but may be located inside a larger structure such as a building, complex, office block, apartment, etc.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.buildingName">smg:StreetDetail.buildingName</a>
    /// </summary>
    let StreetDetail'_period_'buildingName = _prefixId.prefix "StreetDetail.buildingName"

    /// <summary>
    ///   <para>rdfs:label : code^^xsd:string</para>
    ///   <para>rdfs:comment : (if applicable) Utilities often make use of external reference systems, such as those of the town-planner's department or surveyor general's mapping system, that allocate global reference codes to streets.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.code">smg:StreetDetail.code</a>
    /// </summary>
    let StreetDetail'_period_'code = _prefixId.prefix "StreetDetail.code"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : Name of the street.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.name">smg:StreetDetail.name</a>
    /// </summary>
    let StreetDetail'_period_'name = _prefixId.prefix "StreetDetail.name"
    /// <summary>
    ///   <para>rdfs:label : number^^xsd:string</para>
    ///   <para>rdfs:comment : Designator of the specific location on the street.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.number">smg:StreetDetail.number</a>
    /// </summary>
    let StreetDetail'_period_'number = _prefixId.prefix "StreetDetail.number"
    /// <summary>
    ///   <para>rdfs:label : prefix^^xsd:string</para>
    ///   <para>rdfs:comment : Prefix to the street name. For example: North, South, East, West.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.prefix">smg:StreetDetail.prefix</a>
    /// </summary>
    let StreetDetail'_period_'prefix = _prefixId.prefix "StreetDetail.prefix"
    /// <summary>
    ///   <para>rdfs:label : suffix^^xsd:string</para>
    ///   <para>rdfs:comment : Suffix to the street name. For example: North, South, East, West.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suffix">smg:StreetDetail.suffix</a>
    /// </summary>
    let StreetDetail'_period_'suffix = _prefixId.prefix "StreetDetail.suffix"
    /// <summary>
    ///   <para>rdfs:label : suiteNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Number of the apartment or suite.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suiteNumber">smg:StreetDetail.suiteNumber</a>
    /// </summary>
    let StreetDetail'_period_'suiteNumber = _prefixId.prefix "StreetDetail.suiteNumber"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of street. Examples include: street, circle, boulevard, avenue, road, drive, etc.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.type">smg:StreetDetail.type</a>
    /// </summary>
    let StreetDetail'_period_'type = _prefixId.prefix "StreetDetail.type"

    /// <summary>
    ///   <para>rdfs:label : withinTownLimits^^xsd:string</para>
    ///   <para>rdfs:comment : True if this street is within the legal geographical boundaries of the specified town (default).^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.withinTownLimits">smg:StreetDetail.withinTownLimits</a>
    /// </summary>
    let StreetDetail'_period_'withinTownLimits = _prefixId.prefix "StreetDetail.withinTownLimits"

    /// <summary>
    ///   <para>rdfs:comment : Kind of supplier.^^xsd:string</para>
    ///   <para>rdfs:label : SupplierKind^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind">smg:SupplierKind</a>
    /// </summary>
    let SupplierKind = _prefixId.prefix "SupplierKind"
    let SupplierKind'_period_'other = _prefixId.prefix "SupplierKind.other"
    let SupplierKind'_period_'retailer = _prefixId.prefix "SupplierKind.retailer"
    let SupplierKind'_period_'utility = _prefixId.prefix "SupplierKind.utility"
    /// <summary>
    ///   <para>rdfs:comment : Telephone number.^^xsd:string</para>
    ///   <para>rdfs:label : TelephoneNumber^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber">smg:TelephoneNumber</a>
    /// </summary>
    let TelephoneNumber = _prefixId.prefix "TelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : areaCode^^xsd:string</para>
    ///   <para>rdfs:comment : Area or region code.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.areaCode">smg:TelephoneNumber.areaCode</a>
    /// </summary>
    let TelephoneNumber'_period_'areaCode = _prefixId.prefix "TelephoneNumber.areaCode"
    /// <summary>
    ///   <para>rdfs:label : cityCode^^xsd:string</para>
    ///   <para>rdfs:comment : (if applicable) City code.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.cityCode">smg:TelephoneNumber.cityCode</a>
    /// </summary>
    let TelephoneNumber'_period_'cityCode = _prefixId.prefix "TelephoneNumber.cityCode"

    /// <summary>
    ///   <para>rdfs:label : countryCode^^xsd:string</para>
    ///   <para>rdfs:comment : Country code.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.countryCode">smg:TelephoneNumber.countryCode</a>
    /// </summary>
    let TelephoneNumber'_period_'countryCode = _prefixId.prefix "TelephoneNumber.countryCode"

    /// <summary>
    ///   <para>rdfs:label : extension^^xsd:string</para>
    ///   <para>rdfs:comment : (if applicable) Extension for this telephone number.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.extension">smg:TelephoneNumber.extension</a>
    /// </summary>
    let TelephoneNumber'_period_'extension = _prefixId.prefix "TelephoneNumber.extension"

    /// <summary>
    ///   <para>rdfs:label : localNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Main (local) part of this telephone number.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.localNumber">smg:TelephoneNumber.localNumber</a>
    /// </summary>
    let TelephoneNumber'_period_'localNumber = _prefixId.prefix "TelephoneNumber.localNumber"

    /// <summary>
    ///   <para>rdfs:comment : Town details, in the context of address.^^xsd:string</para>
    ///   <para>rdfs:label : TownDetail^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail">smg:TownDetail</a>
    /// </summary>
    let TownDetail = _prefixId.prefix "TownDetail"
    /// <summary>
    ///   <para>rdfs:label : code^^xsd:string</para>
    ///   <para>rdfs:comment : Town code.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.code">smg:TownDetail.code</a>
    /// </summary>
    let TownDetail'_period_'code = _prefixId.prefix "TownDetail.code"
    /// <summary>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <para>rdfs:comment : Name of the country.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.country">smg:TownDetail.country</a>
    /// </summary>
    let TownDetail'_period_'country = _prefixId.prefix "TownDetail.country"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : Town name.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.name">smg:TownDetail.name</a>
    /// </summary>
    let TownDetail'_period_'name = _prefixId.prefix "TownDetail.name"
    /// <summary>
    ///   <para>rdfs:label : section^^xsd:string</para>
    ///   <para>rdfs:comment : Town section. For example, it is common for there to be 36 sections per township.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.section">smg:TownDetail.section</a>
    /// </summary>
    let TownDetail'_period_'section = _prefixId.prefix "TownDetail.section"

    /// <summary>
    ///   <para>rdfs:label : stateOrProvince^^xsd:string</para>
    ///   <para>rdfs:comment : Name of the state or province.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.stateOrProvince">smg:TownDetail.stateOrProvince</a>
    /// </summary>
    let TownDetail'_period_'stateOrProvince = _prefixId.prefix "TownDetail.stateOrProvince"

    /// <summary>
    ///   <para>rdfs:label : UsagePoint^^xsd:string</para>
    ///   <para>rdfs:comment : Logical or physical point in the network to which readings or events may be attributed. Used at the place where a physical or virtual meter may be located; however, it is not required that a meter be present.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint">smg:UsagePoint</a>
    /// </summary>
    let UsagePoint = _prefixId.prefix "UsagePoint"

    /// <summary>
    ///   <para>rdfs:label : CustomerAgreement^^xsd:string</para>
    ///   <para>rdfs:comment : Customer agreement regulating this service delivery point.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.CustomerAgreement">smg:UsagePoint.CustomerAgreement</a>
    /// </summary>
    let UsagePoint'_period_'CustomerAgreement = _prefixId.prefix "UsagePoint.CustomerAgreement"

    /// <summary>
    ///   <para>rdfs:label : MeterReadings^^xsd:string</para>
    ///   <para>rdfs:comment : All meter readings obtained from this usage point.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.MeterReadings">smg:UsagePoint.MeterReadings</a>
    /// </summary>
    let UsagePoint'_period_'MeterReadings = _prefixId.prefix "UsagePoint.MeterReadings"

    /// <summary>
    ///   <para>rdfs:label : ServiceCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Service category delivered by this usage point.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceCategory">smg:UsagePoint.ServiceCategory</a>
    /// </summary>
    let UsagePoint'_period_'ServiceCategory = _prefixId.prefix "UsagePoint.ServiceCategory"

    /// <summary>
    ///   <para>rdfs:label : ServiceSupplier^^xsd:string</para>
    ///   <para>rdfs:comment : ServiceSupplier (Utility) utilising this usage point to deliver a service.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceSupplier">smg:UsagePoint.ServiceSupplier</a>
    /// </summary>
    let UsagePoint'_period_'ServiceSupplier = _prefixId.prefix "UsagePoint.ServiceSupplier"

    /// <summary>
    ///   <para>rdfs:label : UsagePointLocation^^xsd:string</para>
    ///   <para>rdfs:comment : Location of this usage point.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.UsagePointLocation">smg:UsagePoint.UsagePointLocation</a>
    /// </summary>
    let UsagePoint'_period_'UsagePointLocation = _prefixId.prefix "UsagePoint.UsagePointLocation"

    /// <summary>
    ///   <para>rdfs:label : amiBillingReady^^xsd:string</para>
    ///   <para>rdfs:comment : Tracks the lifecycle of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.amiBillingReady">smg:UsagePoint.amiBillingReady</a>
    /// </summary>
    let UsagePoint'_period_'amiBillingReady = _prefixId.prefix "UsagePoint.amiBillingReady"

    /// <summary>
    ///   <para>rdfs:label : isSdp^^xsd:string</para>
    ///   <para>rdfs:comment : If true, this usage point is a service delivery point, i.e., a usage point where the ownership of the service changes hands.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isSdp">smg:UsagePoint.isSdp</a>
    /// </summary>
    let UsagePoint'_period_'isSdp = _prefixId.prefix "UsagePoint.isSdp"
    /// <summary>
    ///   <para>rdfs:label : isVirtual^^xsd:string</para>
    ///   <para>rdfs:comment : If true, this usage point is virtual, i.e., no physical location exists in the network where a meter could be located to collect the meter readings. For example, one may define a virtual usage point to serve as an aggregation of usage for all of a companies premises distributed widely across the distribution territory. Otherwise, the usage point is physical, i.e., there is a logical point in the network where a meter could be located to collect meter readings.^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isVirtual">smg:UsagePoint.isVirtual</a>
    /// </summary>
    let UsagePoint'_period_'isVirtual = _prefixId.prefix "UsagePoint.isVirtual"
    /// <summary>
    ///   <para>rdfs:comment : Location of an individual usage point.^^xsd:string</para>
    ///   <para>rdfs:label : UsagePointLocation^^xsd:string</para>
    ///   <a href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePointLocation">smg:UsagePointLocation</a>
    /// </summary>
    let UsagePointLocation = _prefixId.prefix "UsagePointLocation"
    let global_package = _prefixId.prefix "global_package"
