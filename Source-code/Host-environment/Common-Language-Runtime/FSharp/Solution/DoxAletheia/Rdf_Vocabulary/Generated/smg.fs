namespace http.ns.cerise_project.nl.energy.def.cim_smartgrid.hash

open DoxAletheia

module smg =
    let _namespace_name = "http://ns.cerise-project.nl/energy/def/cim-smartgrid#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Lifecycle states of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind"></see></summary>
    let AmiBillingReadyKind = _prefix "AmiBillingReadyKind"
    /// <summary>
    /// This package contains the core information classes that support end device applications with specialized classes for metering and premise are network devices, and remote reading functions. These classes are generally associated with the point where a service is delivered to the customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Metering"></see></summary>
    let Package_Metering = _prefix "Package_Metering"
    /// <summary>
    /// Usage point is equipped with an AMI capable meter that is not yet currently equipped with a communications module.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiCapable"></see></summary>
    let ``AmiBillingReadyKind.amiCapable`` = _prefix "AmiBillingReadyKind.amiCapable"
    /// <summary>
    /// Usage point is equipped with an AMI capable meter; however, the AMI functionality has been disabled or is not being used.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiDisabled"></see></summary>
    let ``AmiBillingReadyKind.amiDisabled`` = _prefix "AmiBillingReadyKind.amiDisabled"

    /// <summary>
    /// Usage point is equipped with an operating AMI capable meter and accuracy has been certified for billing purposes.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.billingApproved"></see></summary>
    let ``AmiBillingReadyKind.billingApproved`` =
        _prefix "AmiBillingReadyKind.billingApproved"

    /// <summary>
    /// Usage point is equipped with an AMI capable meter having communications capability.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.enabled"></see></summary>
    let ``AmiBillingReadyKind.enabled`` = _prefix "AmiBillingReadyKind.enabled"
    /// <summary>
    /// Usage point is equipped with a non AMI capable meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonAmi"></see></summary>
    let ``AmiBillingReadyKind.nonAmi`` = _prefix "AmiBillingReadyKind.nonAmi"
    /// <summary>
    /// Usage point is not currently equipped with a meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonMetered"></see></summary>
    let ``AmiBillingReadyKind.nonMetered`` = _prefix "AmiBillingReadyKind.nonMetered"
    /// <summary>
    /// Usage point is equipped with an AMI capable meter that is functioning and communicating with the AMI network.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.operable"></see></summary>
    let ``AmiBillingReadyKind.operable`` = _prefix "AmiBillingReadyKind.operable"
    /// <summary>
    /// Common representation for reading values. Note that a reading value may have multiple qualities, as produced by various systems ('ReadingQuality.source').
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading"></see></summary>
    let BaseReading = _prefix "BaseReading"
    /// <summary>
    /// Value of this reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.value"></see></summary>
    let ``BaseReading.value`` = _prefix "BaseReading.value"
    /// <summary>
    /// System that originally supplied the reading (e.g., customer, AMI system, handheld reading system, another enterprise system, etc.).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.source"></see></summary>
    let ``BaseReading.source`` = _prefix "BaseReading.source"
    /// <summary>
    /// Interval between two date and time points.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval"></see></summary>
    let DateTimeInterval = _prefix "DateTimeInterval"
    /// <summary>
    /// Start and end of the period for those readings whose type has a time attribute such as 'billing', seasonal' or 'forTheSpecifiedPeriod'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.timePeriod"></see></summary>
    let ``BaseReading.timePeriod`` = _prefix "BaseReading.timePeriod"
    /// <summary>
    /// This is a root class to provide common identification for all classes needing identification and naming attributes.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject"></see></summary>
    let IdentifiedObject = _prefix "IdentifiedObject"
    /// <summary>
    /// Coordinate reference system.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem"></see></summary>
    let CoordinateSystem = _prefix "CoordinateSystem"
    /// <summary>
    /// This package contains the information classes that support distribution management in general.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Common"></see></summary>
    let Package_Common = _prefix "Package_Common"
    /// <summary>
    /// A Uniform Resource Name (URN) for the coordinate reference system (crs) used to define 'Location.PositionPoints'.
    /// An example would be the European Petroleum Survey Group (EPSG) code for a coordinate reference system, defined in URN under the Open Geospatial Consortium (OGC) namespace as: urn:ogc :def:uom:EPSG::XXXX, where XXXX is an EPSG code (a full list of codes can be found at the EPSG Registry website http://www.epsg-registry.org/). To define the coordinate system as being WGS84 (latitude, longitude) using an EPSG OGC, this attribute would be urn:ogc:def:uom:EPSG::4236.
    /// A profile should limit this code to a set of allowed URNs agreed to by all sending and receiving parties.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.crsUrn"></see></summary>
    let ``CoordinateSystem.crsUrn`` = _prefix "CoordinateSystem.crsUrn"
    /// <summary>
    /// All locations described with position points in this coordinate system.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.Location"></see></summary>
    let ``CoordinateSystem.Location`` = _prefix "CoordinateSystem.Location"
    /// <summary>
    /// The place, scene, or point of something where someone or something has been, is, and/or will be at a given moment in time. It can be defined with one or more postition points (coordinates) in a given coordinate system.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Coordinate system used to describe position points of this location.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.CoordinateSystem"></see></summary>
    let ``Location.CoordinateSystem`` = _prefix "Location.CoordinateSystem"
    /// <summary>
    /// Organisation receiving services from service supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer"></see></summary>
    let Customer = _prefix "Customer"
    /// <summary>
    /// This package contains the core information classes that support customer billing applications.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Customers"></see></summary>
    let Package_Customers = _prefix "Package_Customers"
    /// <summary>
    /// Kind of customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer.kind"></see></summary>
    let ``Customer.kind`` = _prefix "Customer.kind"
    /// <summary>
    /// Kind of customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind"></see></summary>
    let CustomerKind = _prefix "CustomerKind"
    /// <summary>
    /// Identifies a way in which an organisation may participate in the utility enterprise (e.g., customer, manufacturer, etc).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#OrganisationRole"></see></summary>
    let OrganisationRole = _prefix "OrganisationRole"
    /// <summary>
    /// Agreement between the customer and the service supplier to pay for service at a specific service location. It records certain billing information about the type of service provided at the service location and is used during charge creation to determine the type of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement"></see></summary>
    let CustomerAgreement = _prefix "CustomerAgreement"
    /// <summary>
    /// Customer for this agreement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.Customer"></see></summary>
    let ``CustomerAgreement.Customer`` = _prefix "CustomerAgreement.Customer"

    /// <summary>
    /// Service supplier for this customer agreement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceSupplier"></see></summary>
    let ``CustomerAgreement.ServiceSupplier`` =
        _prefix "CustomerAgreement.ServiceSupplier"

    /// <summary>
    /// Service category for this agreement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceCategory"></see></summary>
    let ``CustomerAgreement.ServiceCategory`` =
        _prefix "CustomerAgreement.ServiceCategory"

    /// <summary>
    /// Category of service provided to the customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory"></see></summary>
    let ServiceCategory = _prefix "ServiceCategory"
    /// <summary>
    /// Organisation that provides services to customers.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier"></see></summary>
    let ServiceSupplier = _prefix "ServiceSupplier"

    /// <summary>
    /// Commercial industrial customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.commercialIndustrial"></see></summary>
    let ``CustomerKind.commercialIndustrial`` =
        _prefix "CustomerKind.commercialIndustrial"

    /// <summary>
    /// Customer as energy service scheduler.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceScheduler"></see></summary>
    let ``CustomerKind.energyServiceScheduler`` =
        _prefix "CustomerKind.energyServiceScheduler"

    /// <summary>
    /// Customer as energy service supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceSupplier"></see></summary>
    let ``CustomerKind.energyServiceSupplier`` =
        _prefix "CustomerKind.energyServiceSupplier"

    /// <summary>
    /// Internal use customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.internalUse"></see></summary>
    let ``CustomerKind.internalUse`` = _prefix "CustomerKind.internalUse"
    /// <summary>
    /// Other kind of customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.other"></see></summary>
    let ``CustomerKind.other`` = _prefix "CustomerKind.other"
    /// <summary>
    /// Pumping load customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.pumpingLoad"></see></summary>
    let ``CustomerKind.pumpingLoad`` = _prefix "CustomerKind.pumpingLoad"
    /// <summary>
    /// Residential customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residential"></see></summary>
    let ``CustomerKind.residential`` = _prefix "CustomerKind.residential"

    /// <summary>
    /// Residential and commercial customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndCommercial"></see></summary>
    let ``CustomerKind.residentialAndCommercial`` =
        _prefix "CustomerKind.residentialAndCommercial"

    /// <summary>
    /// Residential and streetlight customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndStreetlight"></see></summary>
    let ``CustomerKind.residentialAndStreetlight`` =
        _prefix "CustomerKind.residentialAndStreetlight"

    /// <summary>
    /// Residential farm service customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialFarmService"></see></summary>
    let ``CustomerKind.residentialFarmService`` =
        _prefix "CustomerKind.residentialFarmService"

    /// <summary>
    /// Residential streetlight or other related customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialStreetlightOthers"></see></summary>
    let ``CustomerKind.residentialStreetlightOthers`` =
        _prefix "CustomerKind.residentialStreetlightOthers"

    /// <summary>
    /// Wind machine customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.windMachine"></see></summary>
    let ``CustomerKind.windMachine`` = _prefix "CustomerKind.windMachine"
    /// <summary>
    /// The domain package define primitive datatypes that are used by classes in other packages. Stereotypes are used to describe the datatypes. The following stereotypes are defined:
    /// &amp;lt;&amp;lt;enumeration&amp;gt;&amp;gt; A list of permissible constant values.
    /// &amp;lt;&amp;lt;Primitive&amp;gt;&amp;gt; The most basic data types used to compose all other data types.
    /// &amp;lt;&amp;lt;CIMDatatype&amp;gt;&amp;gt; A datatype that contains a value attribute, an optional unit of measure and a unit multiplier. The unit and multiplier may be specified as a static variable initialized to the allowed value.
    /// &amp;lt;&amp;lt;Compound&amp;gt;&amp;gt; A composite of Primitive, enumeration, CIMDatatype or othe Compound classes, as long as the Compound classes do not recurse.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Domain"></see></summary>
    let Package_Domain = _prefix "Package_Domain"
    /// <summary>
    /// End date and time of this interval.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.end"></see></summary>
    let ``DateTimeInterval.end`` = _prefix "DateTimeInterval.end"
    /// <summary>
    /// Start date and time of this interval.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.start"></see></summary>
    let ``DateTimeInterval.start`` = _prefix "DateTimeInterval.start"
    /// <summary>
    /// Electronic address information.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress"></see></summary>
    let ElectronicAddress = _prefix "ElectronicAddress"
    /// <summary>
    /// User ID needed to log in, which can be for an individual person, an organisation, a location, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.userID"></see></summary>
    let ``ElectronicAddress.userID`` = _prefix "ElectronicAddress.userID"
    /// <summary>
    /// World wide web address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.web"></see></summary>
    let ``ElectronicAddress.web`` = _prefix "ElectronicAddress.web"
    /// <summary>
    /// Alternate email address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email2"></see></summary>
    let ``ElectronicAddress.email2`` = _prefix "ElectronicAddress.email2"
    /// <summary>
    /// Radio address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.radio"></see></summary>
    let ``ElectronicAddress.radio`` = _prefix "ElectronicAddress.radio"
    /// <summary>
    /// Primary email address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email1"></see></summary>
    let ``ElectronicAddress.email1`` = _prefix "ElectronicAddress.email1"
    /// <summary>
    /// MAC (Media Access Control) address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.mac"></see></summary>
    let ``ElectronicAddress.mac`` = _prefix "ElectronicAddress.mac"
    /// <summary>
    /// Password needed to log in.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.password"></see></summary>
    let ``ElectronicAddress.password`` = _prefix "ElectronicAddress.password"
    /// <summary>
    /// Address on local area network.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.lan"></see></summary>
    let ``ElectronicAddress.lan`` = _prefix "ElectronicAddress.lan"
    /// <summary>
    /// Asset container that performs one or more end device functions. One type of end device is a meter which can perform metering, load management, connect/disconnect, accounting functions, etc. Some end devices, such as ones monitoring and controlling air conditioner, refrigerator, pool pumps may be connected to a meter. All end devices may have communication capability defined by the associated communication function(s). An end device may be owned by a consumer, a service provider, utility or otherwise.
    /// There may be a related end device function that identifies a sensor or control point within a metering application or communications systems (e.g., water, gas, electricity).
    /// Some devices may use an optical port that conforms to the ANSI C12.18 standard for communications.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice"></see></summary>
    let EndDevice = _prefix "EndDevice"
    /// <summary>
    /// Usage point to which this end device belongs.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.UsagePoint"></see></summary>
    let ``EndDevice.UsagePoint`` = _prefix "EndDevice.UsagePoint"
    /// <summary>
    /// Function performed by an end device such as a meter, communication equipment, controllers, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction"></see></summary>
    let EndDeviceFunction = _prefix "EndDeviceFunction"
    /// <summary>
    /// All end device functions this end device performs.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.EndDeviceFunctions"></see></summary>
    let ``EndDevice.EndDeviceFunctions`` = _prefix "EndDevice.EndDeviceFunctions"
    /// <summary>
    /// Installation code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.installCode"></see></summary>
    let ``EndDevice.installCode`` = _prefix "EndDevice.installCode"
    /// <summary>
    /// If true, there is no physical device. As an example, a virtual meter can be defined to aggregate the consumption for two or more physical meters. Otherwise, this is a physical hardware device.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.isVirtual"></see></summary>
    let ``EndDevice.isVirtual`` = _prefix "EndDevice.isVirtual"
    /// <summary>
    /// Logical or physical point in the network to which readings or events may be attributed. Used at the place where a physical or virtual meter may be located; however, it is not required that a meter be present.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint"></see></summary>
    let UsagePoint = _prefix "UsagePoint"
    /// <summary>
    /// End device that performs this function.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction.EndDevice"></see></summary>
    let ``EndDeviceFunction.EndDevice`` = _prefix "EndDeviceFunction.EndDevice"
    /// <summary>
    /// Kind of end device function.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind"></see></summary>
    let EndDeviceFunctionKind = _prefix "EndDeviceFunctionKind"

    /// <summary>
    /// Autonomous application of daylight savings time (DST).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.autonomousDst"></see></summary>
    let ``EndDeviceFunctionKind.autonomousDst`` =
        _prefix "EndDeviceFunctionKind.autonomousDst"

    /// <summary>
    /// Demand response functions.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.demandResponse"></see></summary>
    let ``EndDeviceFunctionKind.demandResponse`` =
        _prefix "EndDeviceFunctionKind.demandResponse"

    /// <summary>
    /// Electricity metering.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.electricMetering"></see></summary>
    let ``EndDeviceFunctionKind.electricMetering`` =
        _prefix "EndDeviceFunctionKind.electricMetering"

    /// <summary>
    /// Gas metering.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.gasMetering"></see></summary>
    let ``EndDeviceFunctionKind.gasMetering`` =
        _prefix "EndDeviceFunctionKind.gasMetering"

    /// <summary>
    /// Presentation of metered values to a user or another system (always a function of a meter, but might not be supported by a load control unit).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.metrology"></see></summary>
    let ``EndDeviceFunctionKind.metrology`` = _prefix "EndDeviceFunctionKind.metrology"

    /// <summary>
    /// On-request reads.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.onRequestRead"></see></summary>
    let ``EndDeviceFunctionKind.onRequestRead`` =
        _prefix "EndDeviceFunctionKind.onRequestRead"

    /// <summary>
    /// Reporting historical power interruption data.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.outageHistory"></see></summary>
    let ``EndDeviceFunctionKind.outageHistory`` =
        _prefix "EndDeviceFunctionKind.outageHistory"

    /// <summary>
    /// Support for one or more relays that may be programmable in the meter (and tied to TOU, time pulse, load control or other functions).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.relaysProgramming"></see></summary>
    let ``EndDeviceFunctionKind.relaysProgramming`` =
        _prefix "EndDeviceFunctionKind.relaysProgramming"

    /// <summary>
    /// Detection and monitoring of reverse flow.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.reverseFlow"></see></summary>
    let ``EndDeviceFunctionKind.reverseFlow`` =
        _prefix "EndDeviceFunctionKind.reverseFlow"

    /// <summary>
    /// Water metering.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.waterMetering"></see></summary>
    let ``EndDeviceFunctionKind.waterMetering`` =
        _prefix "EndDeviceFunctionKind.waterMetering"

    /// <summary>
    /// Contains the core PowerSystemResource and ConductingEquipment entities shared by all applications plus common collections of those entities. Not all applications require all the Core entities.  This package does not depend on any other package except the Domain package, but most of the other packages have associations and generalizations that depend on it.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Core"></see></summary>
    let Package_Core = _prefix "Package_Core"
    /// <summary>
    /// The aliasName is free text human readable name of the object alternative to IdentifiedObject.name. It may be non unique and may not correlate to a naming hierarchy.
    /// The attribute aliasName is retained because of backwards compatibility between CIM relases. It is however recommended to replace aliasName with the Name class as aliasName is planned for retirement at a future time.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.aliasName"></see></summary>
    let ``IdentifiedObject.aliasName`` = _prefix "IdentifiedObject.aliasName"
    /// <summary>
    /// Master resource identifier issued by a model authority. The mRID must semantically be a UUID as specified in RFC 4122. The mRID is globally unique.
    /// For CIMXML data files in RDF syntax, the mRID is mapped to rdf:ID or rdf:about attributes that identify CIM object elements.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.mRID"></see></summary>
    let ``IdentifiedObject.mRID`` = _prefix "IdentifiedObject.mRID"
    /// <summary>
    /// The description is a free human readable text describing or naming the object. It may be non unique and may not correlate to a naming hierarchy.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.description"></see></summary>
    let ``IdentifiedObject.description`` = _prefix "IdentifiedObject.description"
    /// <summary>
    /// The name is any free human readable and possibly non unique text naming the object.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.name"></see></summary>
    let ``IdentifiedObject.name`` = _prefix "IdentifiedObject.name"
    /// <summary>
    /// Time sequence of readings of the same reading type. Contained interval readings may need conversion through the application of an offset and a scalar defined in associated pending.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock"></see></summary>
    let IntervalBlock = _prefix "IntervalBlock"
    /// <summary>
    /// Meter reading containing this interval block.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.MeterReading"></see></summary>
    let ``IntervalBlock.MeterReading`` = _prefix "IntervalBlock.MeterReading"
    /// <summary>
    /// Set of values obtained from the meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading"></see></summary>
    let MeterReading = _prefix "MeterReading"
    /// <summary>
    /// Data captured at regular intervals of time. Interval data could be captured as incremental data, absolute data, or relative data. The source for the data is usually a tariff quantity or an engineering quantity. Data is typically captured in time-tagged, uniform, fixed-length intervals of 5 min, 10 min, 15 min, 30 min, or 60 min.
    /// Note: Interval Data is sometimes also called "Interval Data Readings" (IDR).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading"></see></summary>
    let IntervalReading = _prefix "IntervalReading"
    /// <summary>
    /// Interval reading contained in this block.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.IntervalReadings"></see></summary>
    let ``IntervalBlock.IntervalReadings`` = _prefix "IntervalBlock.IntervalReadings"
    /// <summary>
    /// Type information for interval reading values contained in this block.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.ReadingType"></see></summary>
    let ``IntervalBlock.ReadingType`` = _prefix "IntervalBlock.ReadingType"
    /// <summary>
    /// Detailed description for a type of a reading value. Values in attributes allow for creation of recommended codes to be used for identifying reading value types as follows: &amp;lt;macroPeriod&amp;gt;.&amp;lt;aggregate&amp;gt;.&amp;lt;measuringPeriod&amp;gt;.&amp;lt;accumulation&amp;gt;.&amp;lt;flowDirection&amp;gt;.&amp;lt;commodity&amp;gt;.&amp;lt;measurementKind&amp;gt;.&amp;lt;interharmonic.numerator&amp;gt;.&amp;lt;interharmonic.denominator&amp;gt;.&amp;lt;argument.numerator&amp;gt;.&amp;lt;argument.denominator&amp;gt;.&amp;lt;tou&amp;gt;.&amp;lt;cpp&amp;gt;.&amp;lt;consumptionTier&amp;gt;.&amp;lt;phases&amp;gt;.&amp;lt;multiplier&amp;gt;.&amp;lt;unit&amp;gt;.&amp;lt;currency&amp;gt;.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType"></see></summary>
    let ReadingType = _prefix "ReadingType"
    /// <summary>
    /// All blocks containing this interval reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading.IntervalBlocks"></see></summary>
    let ``IntervalReading.IntervalBlocks`` = _prefix "IntervalReading.IntervalBlocks"
    /// <summary>
    /// Electronic address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.electronicAddress"></see></summary>
    let ``Location.electronicAddress`` = _prefix "Location.electronicAddress"
    /// <summary>
    /// Additional phone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone2"></see></summary>
    let ``Location.phone2`` = _prefix "Location.phone2"
    /// <summary>
    /// Telephone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber"></see></summary>
    let TelephoneNumber = _prefix "TelephoneNumber"
    /// <summary>
    /// Secondary address of the location. For example, PO Box address may have different ZIP code than that in the 'mainAddress'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.secondaryAddress"></see></summary>
    let ``Location.secondaryAddress`` = _prefix "Location.secondaryAddress"
    /// <summary>
    /// Sequence of position points describing this location, expressed in coordinate system 'Location.CoordinateSystem'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.PositionPoints"></see></summary>
    let ``Location.PositionPoints`` = _prefix "Location.PositionPoints"
    /// <summary>
    /// Set of spatial coordinates that determine a point, defined in coordinate system specified in 'Location.CoordinateSystem'. Use a single position point instance to desribe a point-oriented location. Use a sequence of position points to describe a line-oriented object (physical location of non-point oriented objects like cables or lines), or area of an object (like a substation or a geographical zone - in this case, have first and last position point with the same values).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint"></see></summary>
    let PositionPoint = _prefix "PositionPoint"
    /// <summary>
    /// (if applicable) Reference to geographical information source, often external to the utility.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.geoInfoReference"></see></summary>
    let ``Location.geoInfoReference`` = _prefix "Location.geoInfoReference"
    /// <summary>
    /// Status of this location.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.status"></see></summary>
    let ``Location.status`` = _prefix "Location.status"
    /// <summary>
    /// Classification by utility's corporate standards and practices, relative to the location itself (e.g., geographical, functional accounting, etc., not a given property that happens to exist at that location).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.type"></see></summary>
    let ``Location.type`` = _prefix "Location.type"
    /// <summary>
    /// Phone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone1"></see></summary>
    let ``Location.phone1`` = _prefix "Location.phone1"
    /// <summary>
    /// General purpose street address information.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress"></see></summary>
    let StreetAddress = _prefix "StreetAddress"
    /// <summary>
    /// Main address of the location.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.mainAddress"></see></summary>
    let ``Location.mainAddress`` = _prefix "Location.mainAddress"
    /// <summary>
    /// Current status information relevant to an entity.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Location described by this position point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.Location"></see></summary>
    let ``PositionPoint.Location`` = _prefix "PositionPoint.Location"
    /// <summary>
    /// Physical asset that performs the metering role of the usage point. Used for measuring consumption and detection of events.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter"></see></summary>
    let Meter = _prefix "Meter"
    /// <summary>
    /// Meter form designation per ANSI C12.10 or other applicable standard. An alphanumeric designation denoting the circuit arrangement for which the meter is applicable and its specific terminal arrangement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.formNumber"></see></summary>
    let ``Meter.formNumber`` = _prefix "Meter.formNumber"
    /// <summary>
    /// All multipliers applied at this meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterMultipliers"></see></summary>
    let ``Meter.MeterMultipliers`` = _prefix "Meter.MeterMultipliers"
    /// <summary>
    /// All meter readings provided by this meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterReadings"></see></summary>
    let ``Meter.MeterReadings`` = _prefix "Meter.MeterReadings"
    /// <summary>
    /// Multiplier applied at the meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier"></see></summary>
    let MeterMultiplier = _prefix "MeterMultiplier"
    /// <summary>
    /// Meter applying this multiplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.Meter"></see></summary>
    let ``MeterMultiplier.Meter`` = _prefix "MeterMultiplier.Meter"
    /// <summary>
    /// Meter providing this reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Meter"></see></summary>
    let ``MeterReading.Meter`` = _prefix "MeterReading.Meter"
    /// <summary>
    /// Multiplier value.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.value"></see></summary>
    let ``MeterMultiplier.value`` = _prefix "MeterMultiplier.value"
    /// <summary>
    /// Kind of multiplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.kind"></see></summary>
    let ``MeterMultiplier.kind`` = _prefix "MeterMultiplier.kind"
    /// <summary>
    /// Kind of meter multiplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind"></see></summary>
    let MeterMultiplierKind = _prefix "MeterMultiplierKind"
    /// <summary>
    /// Current transformer ratio used to convert associated quantities to real measurements.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ctRatio"></see></summary>
    let ``MeterMultiplierKind.ctRatio`` = _prefix "MeterMultiplierKind.ctRatio"
    /// <summary>
    /// Test constant.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kE"></see></summary>
    let ``MeterMultiplierKind.kE`` = _prefix "MeterMultiplierKind.kE"
    /// <summary>
    /// Meter kh (watthour) constant. The number of watthours that must be applied to the meter to cause one disk revolution for an electromechanical meter or the number of watthours represented by one increment pulse for an electronic meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kH"></see></summary>
    let ``MeterMultiplierKind.kH`` = _prefix "MeterMultiplierKind.kH"
    /// <summary>
    /// Register multiplier. The number to multiply the register reading by in order to get kWh.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kR"></see></summary>
    let ``MeterMultiplierKind.kR`` = _prefix "MeterMultiplierKind.kR"
    /// <summary>
    /// Potential transformer ratio used to convert associated quantities to real measurements.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ptRatio"></see></summary>
    let ``MeterMultiplierKind.ptRatio`` = _prefix "MeterMultiplierKind.ptRatio"

    /// <summary>
    /// Product of the CT ratio and PT ratio.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.transformerRatio"></see></summary>
    let ``MeterMultiplierKind.transformerRatio`` =
        _prefix "MeterMultiplierKind.transformerRatio"

    /// <summary>
    /// (could be deprecated in the future) Customer agreement for this meter reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.CustomerAgreement"></see></summary>
    let ``MeterReading.CustomerAgreement`` = _prefix "MeterReading.CustomerAgreement"
    /// <summary>
    /// All reading values contained within this meter reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Readings"></see></summary>
    let ``MeterReading.Readings`` = _prefix "MeterReading.Readings"
    /// <summary>
    /// Usage point from which this meter reading (set of values) has been obtained.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.UsagePoint"></see></summary>
    let ``MeterReading.UsagePoint`` = _prefix "MeterReading.UsagePoint"
    /// <summary>
    /// Date and time interval of the data items contained within this meter reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.valuesInterval"></see></summary>
    let ``MeterReading.valuesInterval`` = _prefix "MeterReading.valuesInterval"
    /// <summary>
    /// Specific value measured by a meter or other asset, or calculated by a system. Each Reading is associated with a specific ReadingType.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading"></see></summary>
    let Reading = _prefix "Reading"
    /// <summary>
    /// All meter readings (sets of values) containing this reading value.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.MeterReadings"></see></summary>
    let ``Reading.MeterReadings`` = _prefix "Reading.MeterReadings"
    /// <summary>
    /// All meter readings obtained from this usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.MeterReadings"></see></summary>
    let ``UsagePoint.MeterReadings`` = _prefix "UsagePoint.MeterReadings"
    /// <summary>
    ///   <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Base"></see>
    /// </summary>
    let Package_Base = _prefix "Package_Base"
    /// <summary>
    /// Top package for IEC 61970.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61970"></see></summary>
    let Package_IEC61970 = _prefix "Package_IEC61970"
    /// <summary>
    /// The IEC 61968 subpackages of the CIM are developed, standardized and maintained by IEC TC57 Working Group 14: interfaces for distribution management (WG14).
    /// Currently, normative parts of the model support the needs of information exchange defined in IEC 61968-3, IEC 61968-4, IEC 61968-9 and in IEC 61968-13.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61968"></see></summary>
    let Package_IEC61968 = _prefix "Package_IEC61968"
    /// <summary>
    /// Top package for IEC TC57 CIM.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_TC57CIM"></see></summary>
    let Package_TC57CIM = _prefix "Package_TC57CIM"
    /// <summary>
    /// This package is an extension of the Metering package and contains the information classes that support specialised applications such as prepayment metering. These classes are generally associated with the collection and control of revenue from the customer for a delivered service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_PaymentMetering"></see></summary>
    let Package_PaymentMetering = _prefix "Package_PaymentMetering"
    /// <summary>
    ///   <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#global_package"></see>
    /// </summary>
    let global_package = _prefix "global_package"
    /// <summary>
    /// X axis position.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.xPosition"></see></summary>
    let ``PositionPoint.xPosition`` = _prefix "PositionPoint.xPosition"
    /// <summary>
    /// (if applicable) Z axis position.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.zPosition"></see></summary>
    let ``PositionPoint.zPosition`` = _prefix "PositionPoint.zPosition"
    /// <summary>
    /// Zero-relative sequence number of this point within a series of points.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.sequenceNumber"></see></summary>
    let ``PositionPoint.sequenceNumber`` = _prefix "PositionPoint.sequenceNumber"
    /// <summary>
    /// Y axis position.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.yPosition"></see></summary>
    let ``PositionPoint.yPosition`` = _prefix "PositionPoint.yPosition"
    /// <summary>
    /// Type information for this reading value.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.ReadingType"></see></summary>
    let ``Reading.ReadingType`` = _prefix "Reading.ReadingType"
    /// <summary>
    /// Accumulation behaviour of a reading over time, usually 'measuringPeriod', to be used with individual endpoints (as opposed to 'macroPeriod' and 'aggregate' that are used to describe aggregations of data from individual endpoints).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.accumulation"></see></summary>
    let ``ReadingType.accumulation`` = _prefix "ReadingType.accumulation"
    /// <summary>
    /// Commodity being measured.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.commodity"></see></summary>
    let ``ReadingType.commodity`` = _prefix "ReadingType.commodity"
    /// <summary>
    /// Flow direction for a reading where the direction of flow of the commodity is important (for electricity measurements this includes current, energy, power, and demand).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.flowDirection"></see></summary>
    let ``ReadingType.flowDirection`` = _prefix "ReadingType.flowDirection"
    /// <summary>
    /// Time attribute inherent or fundamental to the reading value (as opposed to 'macroPeriod' that supplies an "adjective" to describe aspects of a time period with regard to the measurement). It refers to the way the value was originally measured and not to the frequency at which it is reported or presented. For example, an hourly interval of consumption data would have value 'hourly' as an attribute. However in the case of an hourly sampled voltage value, the meterReadings schema would carry the 'hourly' interval size information.
    /// It is common for meters to report demand in a form that is measured over the course of a portion of an hour, while enterprise applications however commonly assume the demand (in kW or kVAr) normalised to 1 hour. The sytem that receives readings directly from the meter therefore must perform this transformation before publishing readings for use by the other enterprise systems. The scalar used is chosen based on the block size (not any sub-interval size).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measuringPeriod"></see></summary>
    let ``ReadingType.measuringPeriod`` = _prefix "ReadingType.measuringPeriod"
    /// <summary>
    /// Salient attribute of the reading data aggregated from individual endpoints. This is mainly used to define a mathematical operation carried out over 'macroPeriod', but may also be used to describe an attribute of the data when the 'macroPeriod' is not defined.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.aggregate"></see></summary>
    let ``ReadingType.aggregate`` = _prefix "ReadingType.aggregate"
    /// <summary>
    /// Identifies "what" is being measured, as refinement of 'commodity'. When combined with 'unit', it provides detail to the unit of measure. For example, 'energy' with a unit of measure of 'kWh' indicates to the user that active energy is being measured, while with 'kVAh' or 'kVArh', it indicates apparent energy and reactive energy, respectively. 'power' can be combined in a similar way with various power units of measure: Distortion power ('distortionVoltAmperes') with 'kVA' is different from 'power' with 'kVA'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measurementKind"></see></summary>
    let ``ReadingType.measurementKind`` = _prefix "ReadingType.measurementKind"
    /// <summary>
    /// Metering-specific unit.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.unit"></see></summary>
    let ``ReadingType.unit`` = _prefix "ReadingType.unit"
    /// <summary>
    /// Kind of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind"></see></summary>
    let ServiceKind = _prefix "ServiceKind"
    /// <summary>
    /// Kind of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory.kind"></see></summary>
    let ``ServiceCategory.kind`` = _prefix "ServiceCategory.kind"
    /// <summary>
    /// Electricity service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.electricity"></see></summary>
    let ``ServiceKind.electricity`` = _prefix "ServiceKind.electricity"
    /// <summary>
    /// Gas service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.gas"></see></summary>
    let ``ServiceKind.gas`` = _prefix "ServiceKind.gas"
    /// <summary>
    /// Heat service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.heat"></see></summary>
    let ``ServiceKind.heat`` = _prefix "ServiceKind.heat"
    /// <summary>
    /// Internet service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.internet"></see></summary>
    let ``ServiceKind.internet`` = _prefix "ServiceKind.internet"
    /// <summary>
    /// Other kind of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.other"></see></summary>
    let ``ServiceKind.other`` = _prefix "ServiceKind.other"
    /// <summary>
    /// Rates (e.g. tax, charge, toll, duty, tariff, etc.) service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.rates"></see></summary>
    let ``ServiceKind.rates`` = _prefix "ServiceKind.rates"
    /// <summary>
    /// Refuse (waster) service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.refuse"></see></summary>
    let ``ServiceKind.refuse`` = _prefix "ServiceKind.refuse"
    /// <summary>
    /// Sewerage service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.sewerage"></see></summary>
    let ``ServiceKind.sewerage`` = _prefix "ServiceKind.sewerage"
    /// <summary>
    /// Time service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.time"></see></summary>
    let ``ServiceKind.time`` = _prefix "ServiceKind.time"
    /// <summary>
    /// TV license service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.tvLicence"></see></summary>
    let ``ServiceKind.tvLicence`` = _prefix "ServiceKind.tvLicence"
    /// <summary>
    /// Water service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.water"></see></summary>
    let ``ServiceKind.water`` = _prefix "ServiceKind.water"
    /// <summary>
    /// Kind of supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind"></see></summary>
    let SupplierKind = _prefix "SupplierKind"
    /// <summary>
    /// Kind of supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.kind"></see></summary>
    let ``ServiceSupplier.kind`` = _prefix "ServiceSupplier.kind"

    /// <summary>
    /// Unique transaction reference prefix number issued to an entity by the International Standards Organisation for the purpose of tagging onto electronic financial transactions, as defined in ISO/IEC 7812-1 and ISO/IEC 7812-2.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.issuerIdentificationNumber"></see></summary>
    let ``ServiceSupplier.issuerIdentificationNumber`` =
        _prefix "ServiceSupplier.issuerIdentificationNumber"

    /// <summary>
    /// Simple end device function distinguished by 'kind'. Use this class for instances that cannot be represented by another end device function specialisations.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction"></see></summary>
    let SimpleEndDeviceFunction = _prefix "SimpleEndDeviceFunction"
    /// <summary>
    /// Kind of this function.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction.kind"></see></summary>
    let ``SimpleEndDeviceFunction.kind`` = _prefix "SimpleEndDeviceFunction.kind"
    /// <summary>
    /// Date and time for which status 'value' applies.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.dateTime"></see></summary>
    let ``Status.dateTime`` = _prefix "Status.dateTime"
    /// <summary>
    /// Pertinent information regarding the current 'value', as free form text.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.remark"></see></summary>
    let ``Status.remark`` = _prefix "Status.remark"
    /// <summary>
    /// Status value at 'dateTime'; prior status changes may have been kept in instances of activity records associated with the object to which this status applies.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.value"></see></summary>
    let ``Status.value`` = _prefix "Status.value"
    /// <summary>
    /// Reason code or explanation for why an object went to the current status 'value'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.reason"></see></summary>
    let ``Status.reason`` = _prefix "Status.reason"
    /// <summary>
    /// Town detail.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.townDetail"></see></summary>
    let ``StreetAddress.townDetail`` = _prefix "StreetAddress.townDetail"
    /// <summary>
    /// Street detail.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.streetDetail"></see></summary>
    let ``StreetAddress.streetDetail`` = _prefix "StreetAddress.streetDetail"
    /// <summary>
    /// Street details, in the context of address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail"></see></summary>
    let StreetDetail = _prefix "StreetDetail"
    /// <summary>
    /// Town details, in the context of address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail"></see></summary>
    let TownDetail = _prefix "TownDetail"
    /// <summary>
    /// Type of street. Examples include: street, circle, boulevard, avenue, road, drive, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.type"></see></summary>
    let ``StreetDetail.type`` = _prefix "StreetDetail.type"
    /// <summary>
    /// Number of the apartment or suite.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suiteNumber"></see></summary>
    let ``StreetDetail.suiteNumber`` = _prefix "StreetDetail.suiteNumber"
    /// <summary>
    /// True if this street is within the legal geographical boundaries of the specified town (default).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.withinTownLimits"></see></summary>
    let ``StreetDetail.withinTownLimits`` = _prefix "StreetDetail.withinTownLimits"
    /// <summary>
    /// (if applicable) Utilities often make use of external reference systems, such as those of the town-planner's department or surveyor general's mapping system, that allocate global reference codes to streets.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.code"></see></summary>
    let ``StreetDetail.code`` = _prefix "StreetDetail.code"
    /// <summary>
    /// Name of the street.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.name"></see></summary>
    let ``StreetDetail.name`` = _prefix "StreetDetail.name"
    /// <summary>
    /// Additional address information, for example a mailstop.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.addressGeneral"></see></summary>
    let ``StreetDetail.addressGeneral`` = _prefix "StreetDetail.addressGeneral"
    /// <summary>
    /// Designator of the specific location on the street.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.number"></see></summary>
    let ``StreetDetail.number`` = _prefix "StreetDetail.number"
    /// <summary>
    /// Prefix to the street name. For example: North, South, East, West.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.prefix"></see></summary>
    let ``StreetDetail.prefix`` = _prefix "StreetDetail.prefix"
    /// <summary>
    /// (if applicable) In certain cases the physical location of the place of interest does not have a direct point of entry from the street, but may be located inside a larger structure such as a building, complex, office block, apartment, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.buildingName"></see></summary>
    let ``StreetDetail.buildingName`` = _prefix "StreetDetail.buildingName"
    /// <summary>
    /// Suffix to the street name. For example: North, South, East, West.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suffix"></see></summary>
    let ``StreetDetail.suffix`` = _prefix "StreetDetail.suffix"
    /// <summary>
    /// Other kind of supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.other"></see></summary>
    let ``SupplierKind.other`` = _prefix "SupplierKind.other"
    /// <summary>
    /// Entity that sells the service, but does not deliver to the customer; applies to the deregulated markets.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.retailer"></see></summary>
    let ``SupplierKind.retailer`` = _prefix "SupplierKind.retailer"
    /// <summary>
    /// Entity that delivers the service to the customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.utility"></see></summary>
    let ``SupplierKind.utility`` = _prefix "SupplierKind.utility"
    /// <summary>
    /// Area or region code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.areaCode"></see></summary>
    let ``TelephoneNumber.areaCode`` = _prefix "TelephoneNumber.areaCode"
    /// <summary>
    /// Country code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.countryCode"></see></summary>
    let ``TelephoneNumber.countryCode`` = _prefix "TelephoneNumber.countryCode"
    /// <summary>
    /// (if applicable) City code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.cityCode"></see></summary>
    let ``TelephoneNumber.cityCode`` = _prefix "TelephoneNumber.cityCode"
    /// <summary>
    /// Main (local) part of this telephone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.localNumber"></see></summary>
    let ``TelephoneNumber.localNumber`` = _prefix "TelephoneNumber.localNumber"
    /// <summary>
    /// (if applicable) Extension for this telephone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.extension"></see></summary>
    let ``TelephoneNumber.extension`` = _prefix "TelephoneNumber.extension"
    /// <summary>
    /// Name of the country.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.country"></see></summary>
    let ``TownDetail.country`` = _prefix "TownDetail.country"
    /// <summary>
    /// Name of the state or province.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.stateOrProvince"></see></summary>
    let ``TownDetail.stateOrProvince`` = _prefix "TownDetail.stateOrProvince"
    /// <summary>
    /// Town code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.code"></see></summary>
    let ``TownDetail.code`` = _prefix "TownDetail.code"
    /// <summary>
    /// Town name.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.name"></see></summary>
    let ``TownDetail.name`` = _prefix "TownDetail.name"
    /// <summary>
    /// Town section. For example, it is common for there to be 36 sections per township.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.section"></see></summary>
    let ``TownDetail.section`` = _prefix "TownDetail.section"
    /// <summary>
    /// Customer agreement regulating this service delivery point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.CustomerAgreement"></see></summary>
    let ``UsagePoint.CustomerAgreement`` = _prefix "UsagePoint.CustomerAgreement"
    /// <summary>
    /// If true, this usage point is a service delivery point, i.e., a usage point where the ownership of the service changes hands.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isSdp"></see></summary>
    let ``UsagePoint.isSdp`` = _prefix "UsagePoint.isSdp"
    /// <summary>
    /// If true, this usage point is virtual, i.e., no physical location exists in the network where a meter could be located to collect the meter readings. For example, one may define a virtual usage point to serve as an aggregation of usage for all of a companies premises distributed widely across the distribution territory. Otherwise, the usage point is physical, i.e., there is a logical point in the network where a meter could be located to collect meter readings.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isVirtual"></see></summary>
    let ``UsagePoint.isVirtual`` = _prefix "UsagePoint.isVirtual"
    /// <summary>
    /// Tracks the lifecycle of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.amiBillingReady"></see></summary>
    let ``UsagePoint.amiBillingReady`` = _prefix "UsagePoint.amiBillingReady"
    /// <summary>
    /// Location of an individual usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePointLocation"></see></summary>
    let UsagePointLocation = _prefix "UsagePointLocation"
    /// <summary>
    /// Location of this usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.UsagePointLocation"></see></summary>
    let ``UsagePoint.UsagePointLocation`` = _prefix "UsagePoint.UsagePointLocation"
    /// <summary>
    /// Service category delivered by this usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceCategory"></see></summary>
    let ``UsagePoint.ServiceCategory`` = _prefix "UsagePoint.ServiceCategory"
    /// <summary>
    /// ServiceSupplier (Utility) utilising this usage point to deliver a service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceSupplier"></see></summary>
    let ``UsagePoint.ServiceSupplier`` = _prefix "UsagePoint.ServiceSupplier"
