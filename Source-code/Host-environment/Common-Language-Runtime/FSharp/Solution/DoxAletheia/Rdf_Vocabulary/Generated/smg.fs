namespace http.ns.cerise_project.nl.energy.def.cim_smartgrid.hash

open DoxAletheia.Rdf_Vocabulary

module smg =
    let _namespace_name = "http://ns.cerise-project.nl/energy/def/cim-smartgrid#"

    /// <summary>
    /// Lifecycle states of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind"></see></summary>
    let AmiBillingReadyKind =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind" |> NamespacedName

    /// <summary>
    /// This package contains the core information classes that support end device applications with specialized classes for metering and premise are network devices, and remote reading functions. These classes are generally associated with the point where a service is delivered to the customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Metering"></see></summary>
    let Package_Metering =
        Namespaced_IRI.parse _namespace_name "Package_Metering" |> NamespacedName

    /// <summary>
    /// Usage point is equipped with an AMI capable meter that is not yet currently equipped with a communications module.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiCapable"></see></summary>
    let ``AmiBillingReadyKind.amiCapable`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.amiCapable" |> NamespacedName

    /// <summary>
    /// Usage point is equipped with an AMI capable meter; however, the AMI functionality has been disabled or is not being used.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiDisabled"></see></summary>
    let ``AmiBillingReadyKind.amiDisabled`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.amiDisabled" |> NamespacedName

    /// <summary>
    /// Usage point is equipped with an operating AMI capable meter and accuracy has been certified for billing purposes.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.billingApproved"></see></summary>
    let ``AmiBillingReadyKind.billingApproved`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.billingApproved" |> NamespacedName

    /// <summary>
    /// Usage point is equipped with an AMI capable meter having communications capability.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.enabled"></see></summary>
    let ``AmiBillingReadyKind.enabled`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.enabled" |> NamespacedName

    /// <summary>
    /// Usage point is equipped with a non AMI capable meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonAmi"></see></summary>
    let ``AmiBillingReadyKind.nonAmi`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.nonAmi" |> NamespacedName

    /// <summary>
    /// Usage point is not currently equipped with a meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonMetered"></see></summary>
    let ``AmiBillingReadyKind.nonMetered`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.nonMetered" |> NamespacedName

    /// <summary>
    /// Usage point is equipped with an AMI capable meter that is functioning and communicating with the AMI network.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.operable"></see></summary>
    let ``AmiBillingReadyKind.operable`` =
        Namespaced_IRI.parse _namespace_name "AmiBillingReadyKind.operable" |> NamespacedName

    /// <summary>
    /// Common representation for reading values. Note that a reading value may have multiple qualities, as produced by various systems ('ReadingQuality.source').
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading"></see></summary>
    let BaseReading =
        Namespaced_IRI.parse _namespace_name "BaseReading" |> NamespacedName

    /// <summary>
    /// Value of this reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.value"></see></summary>
    let ``BaseReading.value`` =
        Namespaced_IRI.parse _namespace_name "BaseReading.value" |> NamespacedName

    /// <summary>
    /// System that originally supplied the reading (e.g., customer, AMI system, handheld reading system, another enterprise system, etc.).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.source"></see></summary>
    let ``BaseReading.source`` =
        Namespaced_IRI.parse _namespace_name "BaseReading.source" |> NamespacedName

    /// <summary>
    /// Interval between two date and time points.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval"></see></summary>
    let DateTimeInterval =
        Namespaced_IRI.parse _namespace_name "DateTimeInterval" |> NamespacedName

    /// <summary>
    /// Start and end of the period for those readings whose type has a time attribute such as 'billing', seasonal' or 'forTheSpecifiedPeriod'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.timePeriod"></see></summary>
    let ``BaseReading.timePeriod`` =
        Namespaced_IRI.parse _namespace_name "BaseReading.timePeriod" |> NamespacedName

    /// <summary>
    /// This is a root class to provide common identification for all classes needing identification and naming attributes.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject"></see></summary>
    let IdentifiedObject =
        Namespaced_IRI.parse _namespace_name "IdentifiedObject" |> NamespacedName

    /// <summary>
    /// Coordinate reference system.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem"></see></summary>
    let CoordinateSystem =
        Namespaced_IRI.parse _namespace_name "CoordinateSystem" |> NamespacedName

    /// <summary>
    /// This package contains the information classes that support distribution management in general.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Common"></see></summary>
    let Package_Common =
        Namespaced_IRI.parse _namespace_name "Package_Common" |> NamespacedName

    /// <summary>
    /// A Uniform Resource Name (URN) for the coordinate reference system (crs) used to define 'Location.PositionPoints'.
    /// An example would be the European Petroleum Survey Group (EPSG) code for a coordinate reference system, defined in URN under the Open Geospatial Consortium (OGC) namespace as: urn:ogc :def:uom:EPSG::XXXX, where XXXX is an EPSG code (a full list of codes can be found at the EPSG Registry website http://www.epsg-registry.org/). To define the coordinate system as being WGS84 (latitude, longitude) using an EPSG OGC, this attribute would be urn:ogc:def:uom:EPSG::4236.
    /// A profile should limit this code to a set of allowed URNs agreed to by all sending and receiving parties.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.crsUrn"></see></summary>
    let ``CoordinateSystem.crsUrn`` =
        Namespaced_IRI.parse _namespace_name "CoordinateSystem.crsUrn" |> NamespacedName

    /// <summary>
    /// All locations described with position points in this coordinate system.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.Location"></see></summary>
    let ``CoordinateSystem.Location`` =
        Namespaced_IRI.parse _namespace_name "CoordinateSystem.Location" |> NamespacedName

    /// <summary>
    /// The place, scene, or point of something where someone or something has been, is, and/or will be at a given moment in time. It can be defined with one or more postition points (coordinates) in a given coordinate system.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// Coordinate system used to describe position points of this location.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.CoordinateSystem"></see></summary>
    let ``Location.CoordinateSystem`` =
        Namespaced_IRI.parse _namespace_name "Location.CoordinateSystem" |> NamespacedName

    /// <summary>
    /// Organisation receiving services from service supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer"></see></summary>
    let Customer = Namespaced_IRI.parse _namespace_name "Customer" |> NamespacedName

    /// <summary>
    /// This package contains the core information classes that support customer billing applications.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Customers"></see></summary>
    let Package_Customers =
        Namespaced_IRI.parse _namespace_name "Package_Customers" |> NamespacedName

    /// <summary>
    /// Kind of customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer.kind"></see></summary>
    let ``Customer.kind`` =
        Namespaced_IRI.parse _namespace_name "Customer.kind" |> NamespacedName

    /// <summary>
    /// Kind of customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind"></see></summary>
    let CustomerKind =
        Namespaced_IRI.parse _namespace_name "CustomerKind" |> NamespacedName

    /// <summary>
    /// Identifies a way in which an organisation may participate in the utility enterprise (e.g., customer, manufacturer, etc).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#OrganisationRole"></see></summary>
    let OrganisationRole =
        Namespaced_IRI.parse _namespace_name "OrganisationRole" |> NamespacedName

    /// <summary>
    /// Agreement between the customer and the service supplier to pay for service at a specific service location. It records certain billing information about the type of service provided at the service location and is used during charge creation to determine the type of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement"></see></summary>
    let CustomerAgreement =
        Namespaced_IRI.parse _namespace_name "CustomerAgreement" |> NamespacedName

    /// <summary>
    /// Customer for this agreement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.Customer"></see></summary>
    let ``CustomerAgreement.Customer`` =
        Namespaced_IRI.parse _namespace_name "CustomerAgreement.Customer" |> NamespacedName

    /// <summary>
    /// Service supplier for this customer agreement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceSupplier"></see></summary>
    let ``CustomerAgreement.ServiceSupplier`` =
        Namespaced_IRI.parse _namespace_name "CustomerAgreement.ServiceSupplier" |> NamespacedName

    /// <summary>
    /// Service category for this agreement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceCategory"></see></summary>
    let ``CustomerAgreement.ServiceCategory`` =
        Namespaced_IRI.parse _namespace_name "CustomerAgreement.ServiceCategory" |> NamespacedName

    /// <summary>
    /// Category of service provided to the customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory"></see></summary>
    let ServiceCategory =
        Namespaced_IRI.parse _namespace_name "ServiceCategory" |> NamespacedName

    /// <summary>
    /// Organisation that provides services to customers.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier"></see></summary>
    let ServiceSupplier =
        Namespaced_IRI.parse _namespace_name "ServiceSupplier" |> NamespacedName

    /// <summary>
    /// Commercial industrial customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.commercialIndustrial"></see></summary>
    let ``CustomerKind.commercialIndustrial`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.commercialIndustrial" |> NamespacedName

    /// <summary>
    /// Customer as energy service scheduler.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceScheduler"></see></summary>
    let ``CustomerKind.energyServiceScheduler`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.energyServiceScheduler" |> NamespacedName

    /// <summary>
    /// Customer as energy service supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceSupplier"></see></summary>
    let ``CustomerKind.energyServiceSupplier`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.energyServiceSupplier" |> NamespacedName

    /// <summary>
    /// Internal use customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.internalUse"></see></summary>
    let ``CustomerKind.internalUse`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.internalUse" |> NamespacedName

    /// <summary>
    /// Other kind of customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.other"></see></summary>
    let ``CustomerKind.other`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.other" |> NamespacedName

    /// <summary>
    /// Pumping load customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.pumpingLoad"></see></summary>
    let ``CustomerKind.pumpingLoad`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.pumpingLoad" |> NamespacedName

    /// <summary>
    /// Residential customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residential"></see></summary>
    let ``CustomerKind.residential`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.residential" |> NamespacedName

    /// <summary>
    /// Residential and commercial customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndCommercial"></see></summary>
    let ``CustomerKind.residentialAndCommercial`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.residentialAndCommercial" |> NamespacedName

    /// <summary>
    /// Residential and streetlight customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndStreetlight"></see></summary>
    let ``CustomerKind.residentialAndStreetlight`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.residentialAndStreetlight" |> NamespacedName

    /// <summary>
    /// Residential farm service customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialFarmService"></see></summary>
    let ``CustomerKind.residentialFarmService`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.residentialFarmService" |> NamespacedName

    /// <summary>
    /// Residential streetlight or other related customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialStreetlightOthers"></see></summary>
    let ``CustomerKind.residentialStreetlightOthers`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.residentialStreetlightOthers" |> NamespacedName

    /// <summary>
    /// Wind machine customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.windMachine"></see></summary>
    let ``CustomerKind.windMachine`` =
        Namespaced_IRI.parse _namespace_name "CustomerKind.windMachine" |> NamespacedName

    /// <summary>
    /// The domain package define primitive datatypes that are used by classes in other packages. Stereotypes are used to describe the datatypes. The following stereotypes are defined:
    /// &amp;lt;&amp;lt;enumeration&amp;gt;&amp;gt; A list of permissible constant values.
    /// &amp;lt;&amp;lt;Primitive&amp;gt;&amp;gt; The most basic data types used to compose all other data types.
    /// &amp;lt;&amp;lt;CIMDatatype&amp;gt;&amp;gt; A datatype that contains a value attribute, an optional unit of measure and a unit multiplier. The unit and multiplier may be specified as a static variable initialized to the allowed value.
    /// &amp;lt;&amp;lt;Compound&amp;gt;&amp;gt; A composite of Primitive, enumeration, CIMDatatype or othe Compound classes, as long as the Compound classes do not recurse.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Domain"></see></summary>
    let Package_Domain =
        Namespaced_IRI.parse _namespace_name "Package_Domain" |> NamespacedName

    /// <summary>
    /// End date and time of this interval.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.end"></see></summary>
    let ``DateTimeInterval.end`` =
        Namespaced_IRI.parse _namespace_name "DateTimeInterval.end" |> NamespacedName

    /// <summary>
    /// Start date and time of this interval.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.start"></see></summary>
    let ``DateTimeInterval.start`` =
        Namespaced_IRI.parse _namespace_name "DateTimeInterval.start" |> NamespacedName

    /// <summary>
    /// Electronic address information.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress"></see></summary>
    let ElectronicAddress =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress" |> NamespacedName

    /// <summary>
    /// User ID needed to log in, which can be for an individual person, an organisation, a location, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.userID"></see></summary>
    let ``ElectronicAddress.userID`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.userID" |> NamespacedName

    /// <summary>
    /// World wide web address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.web"></see></summary>
    let ``ElectronicAddress.web`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.web" |> NamespacedName

    /// <summary>
    /// Alternate email address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email2"></see></summary>
    let ``ElectronicAddress.email2`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.email2" |> NamespacedName

    /// <summary>
    /// Radio address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.radio"></see></summary>
    let ``ElectronicAddress.radio`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.radio" |> NamespacedName

    /// <summary>
    /// Primary email address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email1"></see></summary>
    let ``ElectronicAddress.email1`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.email1" |> NamespacedName

    /// <summary>
    /// MAC (Media Access Control) address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.mac"></see></summary>
    let ``ElectronicAddress.mac`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.mac" |> NamespacedName

    /// <summary>
    /// Password needed to log in.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.password"></see></summary>
    let ``ElectronicAddress.password`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.password" |> NamespacedName

    /// <summary>
    /// Address on local area network.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.lan"></see></summary>
    let ``ElectronicAddress.lan`` =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress.lan" |> NamespacedName

    /// <summary>
    /// Asset container that performs one or more end device functions. One type of end device is a meter which can perform metering, load management, connect/disconnect, accounting functions, etc. Some end devices, such as ones monitoring and controlling air conditioner, refrigerator, pool pumps may be connected to a meter. All end devices may have communication capability defined by the associated communication function(s). An end device may be owned by a consumer, a service provider, utility or otherwise.
    /// There may be a related end device function that identifies a sensor or control point within a metering application or communications systems (e.g., water, gas, electricity).
    /// Some devices may use an optical port that conforms to the ANSI C12.18 standard for communications.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice"></see></summary>
    let EndDevice = Namespaced_IRI.parse _namespace_name "EndDevice" |> NamespacedName

    /// <summary>
    /// Usage point to which this end device belongs.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.UsagePoint"></see></summary>
    let ``EndDevice.UsagePoint`` =
        Namespaced_IRI.parse _namespace_name "EndDevice.UsagePoint" |> NamespacedName

    /// <summary>
    /// Function performed by an end device such as a meter, communication equipment, controllers, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction"></see></summary>
    let EndDeviceFunction =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunction" |> NamespacedName

    /// <summary>
    /// All end device functions this end device performs.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.EndDeviceFunctions"></see></summary>
    let ``EndDevice.EndDeviceFunctions`` =
        Namespaced_IRI.parse _namespace_name "EndDevice.EndDeviceFunctions" |> NamespacedName

    /// <summary>
    /// Installation code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.installCode"></see></summary>
    let ``EndDevice.installCode`` =
        Namespaced_IRI.parse _namespace_name "EndDevice.installCode" |> NamespacedName

    /// <summary>
    /// If true, there is no physical device. As an example, a virtual meter can be defined to aggregate the consumption for two or more physical meters. Otherwise, this is a physical hardware device.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.isVirtual"></see></summary>
    let ``EndDevice.isVirtual`` =
        Namespaced_IRI.parse _namespace_name "EndDevice.isVirtual" |> NamespacedName

    /// <summary>
    /// Logical or physical point in the network to which readings or events may be attributed. Used at the place where a physical or virtual meter may be located; however, it is not required that a meter be present.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint"></see></summary>
    let UsagePoint = Namespaced_IRI.parse _namespace_name "UsagePoint" |> NamespacedName

    /// <summary>
    /// End device that performs this function.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction.EndDevice"></see></summary>
    let ``EndDeviceFunction.EndDevice`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunction.EndDevice" |> NamespacedName

    /// <summary>
    /// Kind of end device function.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind"></see></summary>
    let EndDeviceFunctionKind =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind" |> NamespacedName

    /// <summary>
    /// Autonomous application of daylight savings time (DST).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.autonomousDst"></see></summary>
    let ``EndDeviceFunctionKind.autonomousDst`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.autonomousDst" |> NamespacedName

    /// <summary>
    /// Demand response functions.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.demandResponse"></see></summary>
    let ``EndDeviceFunctionKind.demandResponse`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.demandResponse" |> NamespacedName

    /// <summary>
    /// Electricity metering.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.electricMetering"></see></summary>
    let ``EndDeviceFunctionKind.electricMetering`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.electricMetering" |> NamespacedName

    /// <summary>
    /// Gas metering.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.gasMetering"></see></summary>
    let ``EndDeviceFunctionKind.gasMetering`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.gasMetering" |> NamespacedName

    /// <summary>
    /// Presentation of metered values to a user or another system (always a function of a meter, but might not be supported by a load control unit).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.metrology"></see></summary>
    let ``EndDeviceFunctionKind.metrology`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.metrology" |> NamespacedName

    /// <summary>
    /// On-request reads.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.onRequestRead"></see></summary>
    let ``EndDeviceFunctionKind.onRequestRead`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.onRequestRead" |> NamespacedName

    /// <summary>
    /// Reporting historical power interruption data.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.outageHistory"></see></summary>
    let ``EndDeviceFunctionKind.outageHistory`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.outageHistory" |> NamespacedName

    /// <summary>
    /// Support for one or more relays that may be programmable in the meter (and tied to TOU, time pulse, load control or other functions).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.relaysProgramming"></see></summary>
    let ``EndDeviceFunctionKind.relaysProgramming`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.relaysProgramming" |> NamespacedName

    /// <summary>
    /// Detection and monitoring of reverse flow.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.reverseFlow"></see></summary>
    let ``EndDeviceFunctionKind.reverseFlow`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.reverseFlow" |> NamespacedName

    /// <summary>
    /// Water metering.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.waterMetering"></see></summary>
    let ``EndDeviceFunctionKind.waterMetering`` =
        Namespaced_IRI.parse _namespace_name "EndDeviceFunctionKind.waterMetering" |> NamespacedName

    /// <summary>
    /// Contains the core PowerSystemResource and ConductingEquipment entities shared by all applications plus common collections of those entities. Not all applications require all the Core entities.  This package does not depend on any other package except the Domain package, but most of the other packages have associations and generalizations that depend on it.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Core"></see></summary>
    let Package_Core =
        Namespaced_IRI.parse _namespace_name "Package_Core" |> NamespacedName

    /// <summary>
    /// The aliasName is free text human readable name of the object alternative to IdentifiedObject.name. It may be non unique and may not correlate to a naming hierarchy.
    /// The attribute aliasName is retained because of backwards compatibility between CIM relases. It is however recommended to replace aliasName with the Name class as aliasName is planned for retirement at a future time.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.aliasName"></see></summary>
    let ``IdentifiedObject.aliasName`` =
        Namespaced_IRI.parse _namespace_name "IdentifiedObject.aliasName" |> NamespacedName

    /// <summary>
    /// Master resource identifier issued by a model authority. The mRID must semantically be a UUID as specified in RFC 4122. The mRID is globally unique.
    /// For CIMXML data files in RDF syntax, the mRID is mapped to rdf:ID or rdf:about attributes that identify CIM object elements.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.mRID"></see></summary>
    let ``IdentifiedObject.mRID`` =
        Namespaced_IRI.parse _namespace_name "IdentifiedObject.mRID" |> NamespacedName

    /// <summary>
    /// The description is a free human readable text describing or naming the object. It may be non unique and may not correlate to a naming hierarchy.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.description"></see></summary>
    let ``IdentifiedObject.description`` =
        Namespaced_IRI.parse _namespace_name "IdentifiedObject.description" |> NamespacedName

    /// <summary>
    /// The name is any free human readable and possibly non unique text naming the object.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.name"></see></summary>
    let ``IdentifiedObject.name`` =
        Namespaced_IRI.parse _namespace_name "IdentifiedObject.name" |> NamespacedName

    /// <summary>
    /// Time sequence of readings of the same reading type. Contained interval readings may need conversion through the application of an offset and a scalar defined in associated pending.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock"></see></summary>
    let IntervalBlock =
        Namespaced_IRI.parse _namespace_name "IntervalBlock" |> NamespacedName

    /// <summary>
    /// Meter reading containing this interval block.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.MeterReading"></see></summary>
    let ``IntervalBlock.MeterReading`` =
        Namespaced_IRI.parse _namespace_name "IntervalBlock.MeterReading" |> NamespacedName

    /// <summary>
    /// Set of values obtained from the meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading"></see></summary>
    let MeterReading =
        Namespaced_IRI.parse _namespace_name "MeterReading" |> NamespacedName

    /// <summary>
    /// Data captured at regular intervals of time. Interval data could be captured as incremental data, absolute data, or relative data. The source for the data is usually a tariff quantity or an engineering quantity. Data is typically captured in time-tagged, uniform, fixed-length intervals of 5 min, 10 min, 15 min, 30 min, or 60 min.
    /// Note: Interval Data is sometimes also called "Interval Data Readings" (IDR).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading"></see></summary>
    let IntervalReading =
        Namespaced_IRI.parse _namespace_name "IntervalReading" |> NamespacedName

    /// <summary>
    /// Interval reading contained in this block.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.IntervalReadings"></see></summary>
    let ``IntervalBlock.IntervalReadings`` =
        Namespaced_IRI.parse _namespace_name "IntervalBlock.IntervalReadings" |> NamespacedName

    /// <summary>
    /// Type information for interval reading values contained in this block.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.ReadingType"></see></summary>
    let ``IntervalBlock.ReadingType`` =
        Namespaced_IRI.parse _namespace_name "IntervalBlock.ReadingType" |> NamespacedName

    /// <summary>
    /// Detailed description for a type of a reading value. Values in attributes allow for creation of recommended codes to be used for identifying reading value types as follows: &amp;lt;macroPeriod&amp;gt;.&amp;lt;aggregate&amp;gt;.&amp;lt;measuringPeriod&amp;gt;.&amp;lt;accumulation&amp;gt;.&amp;lt;flowDirection&amp;gt;.&amp;lt;commodity&amp;gt;.&amp;lt;measurementKind&amp;gt;.&amp;lt;interharmonic.numerator&amp;gt;.&amp;lt;interharmonic.denominator&amp;gt;.&amp;lt;argument.numerator&amp;gt;.&amp;lt;argument.denominator&amp;gt;.&amp;lt;tou&amp;gt;.&amp;lt;cpp&amp;gt;.&amp;lt;consumptionTier&amp;gt;.&amp;lt;phases&amp;gt;.&amp;lt;multiplier&amp;gt;.&amp;lt;unit&amp;gt;.&amp;lt;currency&amp;gt;.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType"></see></summary>
    let ReadingType =
        Namespaced_IRI.parse _namespace_name "ReadingType" |> NamespacedName

    /// <summary>
    /// All blocks containing this interval reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading.IntervalBlocks"></see></summary>
    let ``IntervalReading.IntervalBlocks`` =
        Namespaced_IRI.parse _namespace_name "IntervalReading.IntervalBlocks" |> NamespacedName

    /// <summary>
    /// Electronic address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.electronicAddress"></see></summary>
    let ``Location.electronicAddress`` =
        Namespaced_IRI.parse _namespace_name "Location.electronicAddress" |> NamespacedName

    /// <summary>
    /// Additional phone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone2"></see></summary>
    let ``Location.phone2`` =
        Namespaced_IRI.parse _namespace_name "Location.phone2" |> NamespacedName

    /// <summary>
    /// Telephone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber"></see></summary>
    let TelephoneNumber =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber" |> NamespacedName

    /// <summary>
    /// Secondary address of the location. For example, PO Box address may have different ZIP code than that in the 'mainAddress'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.secondaryAddress"></see></summary>
    let ``Location.secondaryAddress`` =
        Namespaced_IRI.parse _namespace_name "Location.secondaryAddress" |> NamespacedName

    /// <summary>
    /// Sequence of position points describing this location, expressed in coordinate system 'Location.CoordinateSystem'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.PositionPoints"></see></summary>
    let ``Location.PositionPoints`` =
        Namespaced_IRI.parse _namespace_name "Location.PositionPoints" |> NamespacedName

    /// <summary>
    /// Set of spatial coordinates that determine a point, defined in coordinate system specified in 'Location.CoordinateSystem'. Use a single position point instance to desribe a point-oriented location. Use a sequence of position points to describe a line-oriented object (physical location of non-point oriented objects like cables or lines), or area of an object (like a substation or a geographical zone - in this case, have first and last position point with the same values).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint"></see></summary>
    let PositionPoint =
        Namespaced_IRI.parse _namespace_name "PositionPoint" |> NamespacedName

    /// <summary>
    /// (if applicable) Reference to geographical information source, often external to the utility.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.geoInfoReference"></see></summary>
    let ``Location.geoInfoReference`` =
        Namespaced_IRI.parse _namespace_name "Location.geoInfoReference" |> NamespacedName

    /// <summary>
    /// Status of this location.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.status"></see></summary>
    let ``Location.status`` =
        Namespaced_IRI.parse _namespace_name "Location.status" |> NamespacedName

    /// <summary>
    /// Classification by utility's corporate standards and practices, relative to the location itself (e.g., geographical, functional accounting, etc., not a given property that happens to exist at that location).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.type"></see></summary>
    let ``Location.type`` =
        Namespaced_IRI.parse _namespace_name "Location.type" |> NamespacedName

    /// <summary>
    /// Phone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone1"></see></summary>
    let ``Location.phone1`` =
        Namespaced_IRI.parse _namespace_name "Location.phone1" |> NamespacedName

    /// <summary>
    /// General purpose street address information.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress"></see></summary>
    let StreetAddress =
        Namespaced_IRI.parse _namespace_name "StreetAddress" |> NamespacedName

    /// <summary>
    /// Main address of the location.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.mainAddress"></see></summary>
    let ``Location.mainAddress`` =
        Namespaced_IRI.parse _namespace_name "Location.mainAddress" |> NamespacedName

    /// <summary>
    /// Current status information relevant to an entity.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// Location described by this position point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.Location"></see></summary>
    let ``PositionPoint.Location`` =
        Namespaced_IRI.parse _namespace_name "PositionPoint.Location" |> NamespacedName

    /// <summary>
    /// Physical asset that performs the metering role of the usage point. Used for measuring consumption and detection of events.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter"></see></summary>
    let Meter = Namespaced_IRI.parse _namespace_name "Meter" |> NamespacedName

    /// <summary>
    /// Meter form designation per ANSI C12.10 or other applicable standard. An alphanumeric designation denoting the circuit arrangement for which the meter is applicable and its specific terminal arrangement.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.formNumber"></see></summary>
    let ``Meter.formNumber`` =
        Namespaced_IRI.parse _namespace_name "Meter.formNumber" |> NamespacedName

    /// <summary>
    /// All multipliers applied at this meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterMultipliers"></see></summary>
    let ``Meter.MeterMultipliers`` =
        Namespaced_IRI.parse _namespace_name "Meter.MeterMultipliers" |> NamespacedName

    /// <summary>
    /// All meter readings provided by this meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterReadings"></see></summary>
    let ``Meter.MeterReadings`` =
        Namespaced_IRI.parse _namespace_name "Meter.MeterReadings" |> NamespacedName

    /// <summary>
    /// Multiplier applied at the meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier"></see></summary>
    let MeterMultiplier =
        Namespaced_IRI.parse _namespace_name "MeterMultiplier" |> NamespacedName

    /// <summary>
    /// Meter applying this multiplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.Meter"></see></summary>
    let ``MeterMultiplier.Meter`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplier.Meter" |> NamespacedName

    /// <summary>
    /// Meter providing this reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Meter"></see></summary>
    let ``MeterReading.Meter`` =
        Namespaced_IRI.parse _namespace_name "MeterReading.Meter" |> NamespacedName

    /// <summary>
    /// Multiplier value.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.value"></see></summary>
    let ``MeterMultiplier.value`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplier.value" |> NamespacedName

    /// <summary>
    /// Kind of multiplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.kind"></see></summary>
    let ``MeterMultiplier.kind`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplier.kind" |> NamespacedName

    /// <summary>
    /// Kind of meter multiplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind"></see></summary>
    let MeterMultiplierKind =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind" |> NamespacedName

    /// <summary>
    /// Current transformer ratio used to convert associated quantities to real measurements.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ctRatio"></see></summary>
    let ``MeterMultiplierKind.ctRatio`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind.ctRatio" |> NamespacedName

    /// <summary>
    /// Test constant.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kE"></see></summary>
    let ``MeterMultiplierKind.kE`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind.kE" |> NamespacedName

    /// <summary>
    /// Meter kh (watthour) constant. The number of watthours that must be applied to the meter to cause one disk revolution for an electromechanical meter or the number of watthours represented by one increment pulse for an electronic meter.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kH"></see></summary>
    let ``MeterMultiplierKind.kH`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind.kH" |> NamespacedName

    /// <summary>
    /// Register multiplier. The number to multiply the register reading by in order to get kWh.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kR"></see></summary>
    let ``MeterMultiplierKind.kR`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind.kR" |> NamespacedName

    /// <summary>
    /// Potential transformer ratio used to convert associated quantities to real measurements.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ptRatio"></see></summary>
    let ``MeterMultiplierKind.ptRatio`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind.ptRatio" |> NamespacedName

    /// <summary>
    /// Product of the CT ratio and PT ratio.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.transformerRatio"></see></summary>
    let ``MeterMultiplierKind.transformerRatio`` =
        Namespaced_IRI.parse _namespace_name "MeterMultiplierKind.transformerRatio" |> NamespacedName

    /// <summary>
    /// (could be deprecated in the future) Customer agreement for this meter reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.CustomerAgreement"></see></summary>
    let ``MeterReading.CustomerAgreement`` =
        Namespaced_IRI.parse _namespace_name "MeterReading.CustomerAgreement" |> NamespacedName

    /// <summary>
    /// All reading values contained within this meter reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Readings"></see></summary>
    let ``MeterReading.Readings`` =
        Namespaced_IRI.parse _namespace_name "MeterReading.Readings" |> NamespacedName

    /// <summary>
    /// Usage point from which this meter reading (set of values) has been obtained.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.UsagePoint"></see></summary>
    let ``MeterReading.UsagePoint`` =
        Namespaced_IRI.parse _namespace_name "MeterReading.UsagePoint" |> NamespacedName

    /// <summary>
    /// Date and time interval of the data items contained within this meter reading.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.valuesInterval"></see></summary>
    let ``MeterReading.valuesInterval`` =
        Namespaced_IRI.parse _namespace_name "MeterReading.valuesInterval" |> NamespacedName

    /// <summary>
    /// Specific value measured by a meter or other asset, or calculated by a system. Each Reading is associated with a specific ReadingType.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading"></see></summary>
    let Reading = Namespaced_IRI.parse _namespace_name "Reading" |> NamespacedName

    /// <summary>
    /// All meter readings (sets of values) containing this reading value.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.MeterReadings"></see></summary>
    let ``Reading.MeterReadings`` =
        Namespaced_IRI.parse _namespace_name "Reading.MeterReadings" |> NamespacedName

    /// <summary>
    /// All meter readings obtained from this usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.MeterReadings"></see></summary>
    let ``UsagePoint.MeterReadings`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.MeterReadings" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Base"></see>
    /// </summary>
    let Package_Base =
        Namespaced_IRI.parse _namespace_name "Package_Base" |> NamespacedName

    /// <summary>
    /// Top package for IEC 61970.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61970"></see></summary>
    let Package_IEC61970 =
        Namespaced_IRI.parse _namespace_name "Package_IEC61970" |> NamespacedName

    /// <summary>
    /// The IEC 61968 subpackages of the CIM are developed, standardized and maintained by IEC TC57 Working Group 14: interfaces for distribution management (WG14).
    /// Currently, normative parts of the model support the needs of information exchange defined in IEC 61968-3, IEC 61968-4, IEC 61968-9 and in IEC 61968-13.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61968"></see></summary>
    let Package_IEC61968 =
        Namespaced_IRI.parse _namespace_name "Package_IEC61968" |> NamespacedName

    /// <summary>
    /// Top package for IEC TC57 CIM.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_TC57CIM"></see></summary>
    let Package_TC57CIM =
        Namespaced_IRI.parse _namespace_name "Package_TC57CIM" |> NamespacedName

    /// <summary>
    /// This package is an extension of the Metering package and contains the information classes that support specialised applications such as prepayment metering. These classes are generally associated with the collection and control of revenue from the customer for a delivered service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_PaymentMetering"></see></summary>
    let Package_PaymentMetering =
        Namespaced_IRI.parse _namespace_name "Package_PaymentMetering" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#global_package"></see>
    /// </summary>
    let global_package =
        Namespaced_IRI.parse _namespace_name "global_package" |> NamespacedName

    /// <summary>
    /// X axis position.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.xPosition"></see></summary>
    let ``PositionPoint.xPosition`` =
        Namespaced_IRI.parse _namespace_name "PositionPoint.xPosition" |> NamespacedName

    /// <summary>
    /// (if applicable) Z axis position.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.zPosition"></see></summary>
    let ``PositionPoint.zPosition`` =
        Namespaced_IRI.parse _namespace_name "PositionPoint.zPosition" |> NamespacedName

    /// <summary>
    /// Zero-relative sequence number of this point within a series of points.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.sequenceNumber"></see></summary>
    let ``PositionPoint.sequenceNumber`` =
        Namespaced_IRI.parse _namespace_name "PositionPoint.sequenceNumber" |> NamespacedName

    /// <summary>
    /// Y axis position.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.yPosition"></see></summary>
    let ``PositionPoint.yPosition`` =
        Namespaced_IRI.parse _namespace_name "PositionPoint.yPosition" |> NamespacedName

    /// <summary>
    /// Type information for this reading value.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.ReadingType"></see></summary>
    let ``Reading.ReadingType`` =
        Namespaced_IRI.parse _namespace_name "Reading.ReadingType" |> NamespacedName

    /// <summary>
    /// Accumulation behaviour of a reading over time, usually 'measuringPeriod', to be used with individual endpoints (as opposed to 'macroPeriod' and 'aggregate' that are used to describe aggregations of data from individual endpoints).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.accumulation"></see></summary>
    let ``ReadingType.accumulation`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.accumulation" |> NamespacedName

    /// <summary>
    /// Commodity being measured.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.commodity"></see></summary>
    let ``ReadingType.commodity`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.commodity" |> NamespacedName

    /// <summary>
    /// Flow direction for a reading where the direction of flow of the commodity is important (for electricity measurements this includes current, energy, power, and demand).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.flowDirection"></see></summary>
    let ``ReadingType.flowDirection`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.flowDirection" |> NamespacedName

    /// <summary>
    /// Time attribute inherent or fundamental to the reading value (as opposed to 'macroPeriod' that supplies an "adjective" to describe aspects of a time period with regard to the measurement). It refers to the way the value was originally measured and not to the frequency at which it is reported or presented. For example, an hourly interval of consumption data would have value 'hourly' as an attribute. However in the case of an hourly sampled voltage value, the meterReadings schema would carry the 'hourly' interval size information.
    /// It is common for meters to report demand in a form that is measured over the course of a portion of an hour, while enterprise applications however commonly assume the demand (in kW or kVAr) normalised to 1 hour. The sytem that receives readings directly from the meter therefore must perform this transformation before publishing readings for use by the other enterprise systems. The scalar used is chosen based on the block size (not any sub-interval size).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measuringPeriod"></see></summary>
    let ``ReadingType.measuringPeriod`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.measuringPeriod" |> NamespacedName

    /// <summary>
    /// Salient attribute of the reading data aggregated from individual endpoints. This is mainly used to define a mathematical operation carried out over 'macroPeriod', but may also be used to describe an attribute of the data when the 'macroPeriod' is not defined.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.aggregate"></see></summary>
    let ``ReadingType.aggregate`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.aggregate" |> NamespacedName

    /// <summary>
    /// Identifies "what" is being measured, as refinement of 'commodity'. When combined with 'unit', it provides detail to the unit of measure. For example, 'energy' with a unit of measure of 'kWh' indicates to the user that active energy is being measured, while with 'kVAh' or 'kVArh', it indicates apparent energy and reactive energy, respectively. 'power' can be combined in a similar way with various power units of measure: Distortion power ('distortionVoltAmperes') with 'kVA' is different from 'power' with 'kVA'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measurementKind"></see></summary>
    let ``ReadingType.measurementKind`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.measurementKind" |> NamespacedName

    /// <summary>
    /// Metering-specific unit.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.unit"></see></summary>
    let ``ReadingType.unit`` =
        Namespaced_IRI.parse _namespace_name "ReadingType.unit" |> NamespacedName

    /// <summary>
    /// Kind of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind"></see></summary>
    let ServiceKind =
        Namespaced_IRI.parse _namespace_name "ServiceKind" |> NamespacedName

    /// <summary>
    /// Kind of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory.kind"></see></summary>
    let ``ServiceCategory.kind`` =
        Namespaced_IRI.parse _namespace_name "ServiceCategory.kind" |> NamespacedName

    /// <summary>
    /// Electricity service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.electricity"></see></summary>
    let ``ServiceKind.electricity`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.electricity" |> NamespacedName

    /// <summary>
    /// Gas service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.gas"></see></summary>
    let ``ServiceKind.gas`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.gas" |> NamespacedName

    /// <summary>
    /// Heat service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.heat"></see></summary>
    let ``ServiceKind.heat`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.heat" |> NamespacedName

    /// <summary>
    /// Internet service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.internet"></see></summary>
    let ``ServiceKind.internet`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.internet" |> NamespacedName

    /// <summary>
    /// Other kind of service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.other"></see></summary>
    let ``ServiceKind.other`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.other" |> NamespacedName

    /// <summary>
    /// Rates (e.g. tax, charge, toll, duty, tariff, etc.) service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.rates"></see></summary>
    let ``ServiceKind.rates`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.rates" |> NamespacedName

    /// <summary>
    /// Refuse (waster) service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.refuse"></see></summary>
    let ``ServiceKind.refuse`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.refuse" |> NamespacedName

    /// <summary>
    /// Sewerage service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.sewerage"></see></summary>
    let ``ServiceKind.sewerage`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.sewerage" |> NamespacedName

    /// <summary>
    /// Time service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.time"></see></summary>
    let ``ServiceKind.time`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.time" |> NamespacedName

    /// <summary>
    /// TV license service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.tvLicence"></see></summary>
    let ``ServiceKind.tvLicence`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.tvLicence" |> NamespacedName

    /// <summary>
    /// Water service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.water"></see></summary>
    let ``ServiceKind.water`` =
        Namespaced_IRI.parse _namespace_name "ServiceKind.water" |> NamespacedName

    /// <summary>
    /// Kind of supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind"></see></summary>
    let SupplierKind =
        Namespaced_IRI.parse _namespace_name "SupplierKind" |> NamespacedName

    /// <summary>
    /// Kind of supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.kind"></see></summary>
    let ``ServiceSupplier.kind`` =
        Namespaced_IRI.parse _namespace_name "ServiceSupplier.kind" |> NamespacedName

    /// <summary>
    /// Unique transaction reference prefix number issued to an entity by the International Standards Organisation for the purpose of tagging onto electronic financial transactions, as defined in ISO/IEC 7812-1 and ISO/IEC 7812-2.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.issuerIdentificationNumber"></see></summary>
    let ``ServiceSupplier.issuerIdentificationNumber`` =
        Namespaced_IRI.parse _namespace_name "ServiceSupplier.issuerIdentificationNumber" |> NamespacedName

    /// <summary>
    /// Simple end device function distinguished by 'kind'. Use this class for instances that cannot be represented by another end device function specialisations.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction"></see></summary>
    let SimpleEndDeviceFunction =
        Namespaced_IRI.parse _namespace_name "SimpleEndDeviceFunction" |> NamespacedName

    /// <summary>
    /// Kind of this function.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction.kind"></see></summary>
    let ``SimpleEndDeviceFunction.kind`` =
        Namespaced_IRI.parse _namespace_name "SimpleEndDeviceFunction.kind" |> NamespacedName

    /// <summary>
    /// Date and time for which status 'value' applies.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.dateTime"></see></summary>
    let ``Status.dateTime`` =
        Namespaced_IRI.parse _namespace_name "Status.dateTime" |> NamespacedName

    /// <summary>
    /// Pertinent information regarding the current 'value', as free form text.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.remark"></see></summary>
    let ``Status.remark`` =
        Namespaced_IRI.parse _namespace_name "Status.remark" |> NamespacedName

    /// <summary>
    /// Status value at 'dateTime'; prior status changes may have been kept in instances of activity records associated with the object to which this status applies.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.value"></see></summary>
    let ``Status.value`` =
        Namespaced_IRI.parse _namespace_name "Status.value" |> NamespacedName

    /// <summary>
    /// Reason code or explanation for why an object went to the current status 'value'.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.reason"></see></summary>
    let ``Status.reason`` =
        Namespaced_IRI.parse _namespace_name "Status.reason" |> NamespacedName

    /// <summary>
    /// Town detail.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.townDetail"></see></summary>
    let ``StreetAddress.townDetail`` =
        Namespaced_IRI.parse _namespace_name "StreetAddress.townDetail" |> NamespacedName

    /// <summary>
    /// Street detail.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.streetDetail"></see></summary>
    let ``StreetAddress.streetDetail`` =
        Namespaced_IRI.parse _namespace_name "StreetAddress.streetDetail" |> NamespacedName

    /// <summary>
    /// Street details, in the context of address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail"></see></summary>
    let StreetDetail =
        Namespaced_IRI.parse _namespace_name "StreetDetail" |> NamespacedName

    /// <summary>
    /// Town details, in the context of address.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail"></see></summary>
    let TownDetail = Namespaced_IRI.parse _namespace_name "TownDetail" |> NamespacedName

    /// <summary>
    /// Type of street. Examples include: street, circle, boulevard, avenue, road, drive, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.type"></see></summary>
    let ``StreetDetail.type`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.type" |> NamespacedName

    /// <summary>
    /// Number of the apartment or suite.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suiteNumber"></see></summary>
    let ``StreetDetail.suiteNumber`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.suiteNumber" |> NamespacedName

    /// <summary>
    /// True if this street is within the legal geographical boundaries of the specified town (default).
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.withinTownLimits"></see></summary>
    let ``StreetDetail.withinTownLimits`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.withinTownLimits" |> NamespacedName

    /// <summary>
    /// (if applicable) Utilities often make use of external reference systems, such as those of the town-planner's department or surveyor general's mapping system, that allocate global reference codes to streets.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.code"></see></summary>
    let ``StreetDetail.code`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.code" |> NamespacedName

    /// <summary>
    /// Name of the street.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.name"></see></summary>
    let ``StreetDetail.name`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.name" |> NamespacedName

    /// <summary>
    /// Additional address information, for example a mailstop.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.addressGeneral"></see></summary>
    let ``StreetDetail.addressGeneral`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.addressGeneral" |> NamespacedName

    /// <summary>
    /// Designator of the specific location on the street.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.number"></see></summary>
    let ``StreetDetail.number`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.number" |> NamespacedName

    /// <summary>
    /// Prefix to the street name. For example: North, South, East, West.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.prefix"></see></summary>
    let ``StreetDetail.prefix`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.prefix" |> NamespacedName

    /// <summary>
    /// (if applicable) In certain cases the physical location of the place of interest does not have a direct point of entry from the street, but may be located inside a larger structure such as a building, complex, office block, apartment, etc.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.buildingName"></see></summary>
    let ``StreetDetail.buildingName`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.buildingName" |> NamespacedName

    /// <summary>
    /// Suffix to the street name. For example: North, South, East, West.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suffix"></see></summary>
    let ``StreetDetail.suffix`` =
        Namespaced_IRI.parse _namespace_name "StreetDetail.suffix" |> NamespacedName

    /// <summary>
    /// Other kind of supplier.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.other"></see></summary>
    let ``SupplierKind.other`` =
        Namespaced_IRI.parse _namespace_name "SupplierKind.other" |> NamespacedName

    /// <summary>
    /// Entity that sells the service, but does not deliver to the customer; applies to the deregulated markets.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.retailer"></see></summary>
    let ``SupplierKind.retailer`` =
        Namespaced_IRI.parse _namespace_name "SupplierKind.retailer" |> NamespacedName

    /// <summary>
    /// Entity that delivers the service to the customer.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.utility"></see></summary>
    let ``SupplierKind.utility`` =
        Namespaced_IRI.parse _namespace_name "SupplierKind.utility" |> NamespacedName

    /// <summary>
    /// Area or region code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.areaCode"></see></summary>
    let ``TelephoneNumber.areaCode`` =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber.areaCode" |> NamespacedName

    /// <summary>
    /// Country code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.countryCode"></see></summary>
    let ``TelephoneNumber.countryCode`` =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber.countryCode" |> NamespacedName

    /// <summary>
    /// (if applicable) City code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.cityCode"></see></summary>
    let ``TelephoneNumber.cityCode`` =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber.cityCode" |> NamespacedName

    /// <summary>
    /// Main (local) part of this telephone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.localNumber"></see></summary>
    let ``TelephoneNumber.localNumber`` =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber.localNumber" |> NamespacedName

    /// <summary>
    /// (if applicable) Extension for this telephone number.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.extension"></see></summary>
    let ``TelephoneNumber.extension`` =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber.extension" |> NamespacedName

    /// <summary>
    /// Name of the country.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.country"></see></summary>
    let ``TownDetail.country`` =
        Namespaced_IRI.parse _namespace_name "TownDetail.country" |> NamespacedName

    /// <summary>
    /// Name of the state or province.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.stateOrProvince"></see></summary>
    let ``TownDetail.stateOrProvince`` =
        Namespaced_IRI.parse _namespace_name "TownDetail.stateOrProvince" |> NamespacedName

    /// <summary>
    /// Town code.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.code"></see></summary>
    let ``TownDetail.code`` =
        Namespaced_IRI.parse _namespace_name "TownDetail.code" |> NamespacedName

    /// <summary>
    /// Town name.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.name"></see></summary>
    let ``TownDetail.name`` =
        Namespaced_IRI.parse _namespace_name "TownDetail.name" |> NamespacedName

    /// <summary>
    /// Town section. For example, it is common for there to be 36 sections per township.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.section"></see></summary>
    let ``TownDetail.section`` =
        Namespaced_IRI.parse _namespace_name "TownDetail.section" |> NamespacedName

    /// <summary>
    /// Customer agreement regulating this service delivery point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.CustomerAgreement"></see></summary>
    let ``UsagePoint.CustomerAgreement`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.CustomerAgreement" |> NamespacedName

    /// <summary>
    /// If true, this usage point is a service delivery point, i.e., a usage point where the ownership of the service changes hands.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isSdp"></see></summary>
    let ``UsagePoint.isSdp`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.isSdp" |> NamespacedName

    /// <summary>
    /// If true, this usage point is virtual, i.e., no physical location exists in the network where a meter could be located to collect the meter readings. For example, one may define a virtual usage point to serve as an aggregation of usage for all of a companies premises distributed widely across the distribution territory. Otherwise, the usage point is physical, i.e., there is a logical point in the network where a meter could be located to collect meter readings.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isVirtual"></see></summary>
    let ``UsagePoint.isVirtual`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.isVirtual" |> NamespacedName

    /// <summary>
    /// Tracks the lifecycle of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.amiBillingReady"></see></summary>
    let ``UsagePoint.amiBillingReady`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.amiBillingReady" |> NamespacedName

    /// <summary>
    /// Location of an individual usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePointLocation"></see></summary>
    let UsagePointLocation =
        Namespaced_IRI.parse _namespace_name "UsagePointLocation" |> NamespacedName

    /// <summary>
    /// Location of this usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.UsagePointLocation"></see></summary>
    let ``UsagePoint.UsagePointLocation`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.UsagePointLocation" |> NamespacedName

    /// <summary>
    /// Service category delivered by this usage point.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceCategory"></see></summary>
    let ``UsagePoint.ServiceCategory`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.ServiceCategory" |> NamespacedName

    /// <summary>
    /// ServiceSupplier (Utility) utilising this usage point to deliver a service.
    /// <see href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceSupplier"></see></summary>
    let ``UsagePoint.ServiceSupplier`` =
        Namespaced_IRI.parse _namespace_name "UsagePoint.ServiceSupplier" |> NamespacedName
