namespace http.ns.cerise_project.nl.energy.def.cim_smartgrid.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module smg =
    let _namespace_iri = Namespace_Iri smg |> NamespaceIRI
    /// <summary>
    ///   <para>smg:AmiBillingReadyKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lifecycle states of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AmiBillingReadyKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind</seealso>
    let AmiBillingReadyKind = Prefixed_Name(smg, "AmiBillingReadyKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.amiCapable</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is equipped with an AMI capable meter that is not yet currently equipped with a communications module."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"amiCapable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiCapable">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiCapable</seealso>
    let ``AmiBillingReadyKind.amiCapable`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.amiCapable") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.amiDisabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is equipped with an AMI capable meter; however, the AMI functionality has been disabled or is not being used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"amiDisabled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiDisabled">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.amiDisabled</seealso>
    let ``AmiBillingReadyKind.amiDisabled`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.amiDisabled") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.billingApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is equipped with an operating AMI capable meter and accuracy has been certified for billing purposes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"billingApproved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.billingApproved">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.billingApproved</seealso>
    let ``AmiBillingReadyKind.billingApproved`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.billingApproved") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.enabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is equipped with an AMI capable meter having communications capability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"enabled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.enabled">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.enabled</seealso>
    let ``AmiBillingReadyKind.enabled`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.enabled") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.nonAmi</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is equipped with a non AMI capable meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nonAmi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonAmi">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonAmi</seealso>
    let ``AmiBillingReadyKind.nonAmi`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.nonAmi") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.nonMetered</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is not currently equipped with a meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nonMetered"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonMetered">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.nonMetered</seealso>
    let ``AmiBillingReadyKind.nonMetered`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.nonMetered") |> PrefixedName

    /// <summary>
    ///   <para>smg:AmiBillingReadyKind.operable</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:AmiBillingReadyKind</para>
    ///   <para>"Usage point is equipped with an AMI capable meter that is functioning and communicating with the AMI network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"operable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.operable">http://ns.cerise-project.nl/energy/def/cim-smartgrid#AmiBillingReadyKind.operable</seealso>
    let ``AmiBillingReadyKind.operable`` =
        Prefixed_Name(smg, "AmiBillingReadyKind.operable") |> PrefixedName

    /// <summary>
    ///   <para>smg:BaseReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Common representation for reading values. Note that a reading value may have multiple qualities, as produced by various systems ('ReadingQuality.source')."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BaseReading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading">http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading</seealso>
    let BaseReading = Prefixed_Name(smg, "BaseReading") |> PrefixedName

    /// <summary>
    ///   <para>smg:BaseReading.source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"System that originally supplied the reading (e.g., customer, AMI system, handheld reading system, another enterprise system, etc.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.source">http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.source</seealso>
    let ``BaseReading.source`` =
        Prefixed_Name(smg, "BaseReading.source") |> PrefixedName

    /// <summary>
    ///   <para>smg:BaseReading.timePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Start and end of the period for those readings whose type has a time attribute such as 'billing', seasonal' or 'forTheSpecifiedPeriod'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timePeriod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.timePeriod">http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.timePeriod</seealso>
    let ``BaseReading.timePeriod`` =
        Prefixed_Name(smg, "BaseReading.timePeriod") |> PrefixedName

    /// <summary>
    ///   <para>smg:BaseReading.value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Value of this reading."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.value">http://ns.cerise-project.nl/energy/def/cim-smartgrid#BaseReading.value</seealso>
    let ``BaseReading.value`` = Prefixed_Name(smg, "BaseReading.value") |> PrefixedName
    /// <summary>
    ///   <para>smg:CoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate reference system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CoordinateSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem</seealso>
    let CoordinateSystem = Prefixed_Name(smg, "CoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>smg:CoordinateSystem.Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All locations described with position points in this coordinate system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.Location">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.Location</seealso>
    let ``CoordinateSystem.Location`` =
        Prefixed_Name(smg, "CoordinateSystem.Location") |> PrefixedName

    /// <summary>
    ///   <para>smg:CoordinateSystem.crsUrn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Uniform Resource Name (URN) for the coordinate reference system (crs) used to define 'Location.PositionPoints'.
    /// An example would be the European Petroleum Survey Group (EPSG) code for a coordinate reference system, defined in URN under the Open Geospatial Consortium (OGC) namespace as: urn:ogc :def:uom:EPSG::XXXX, where XXXX is an EPSG code (a full list of codes can be found at the EPSG Registry website http://www.epsg-registry.org/). To define the coordinate system as being WGS84 (latitude, longitude) using an EPSG OGC, this attribute would be urn:ogc:def:uom:EPSG::4236.
    /// A profile should limit this code to a set of allowed URNs agreed to by all sending and receiving parties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"crsUrn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.crsUrn">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CoordinateSystem.crsUrn</seealso>
    let ``CoordinateSystem.crsUrn`` =
        Prefixed_Name(smg, "CoordinateSystem.crsUrn") |> PrefixedName

    /// <summary>
    ///   <para>smg:Customer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organisation receiving services from service supplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Customer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer</seealso>
    let Customer = Prefixed_Name(smg, "Customer") |> PrefixedName
    /// <summary>
    ///   <para>smg:Customer.kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Kind of customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer.kind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Customer.kind</seealso>
    let ``Customer.kind`` = Prefixed_Name(smg, "Customer.kind") |> PrefixedName
    /// <summary>
    ///   <para>smg:CustomerAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agreement between the customer and the service supplier to pay for service at a specific service location. It records certain billing information about the type of service provided at the service location and is used during charge creation to determine the type of service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CustomerAgreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement</seealso>
    let CustomerAgreement = Prefixed_Name(smg, "CustomerAgreement") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerAgreement.Customer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Customer for this agreement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Customer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.Customer">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.Customer</seealso>
    let ``CustomerAgreement.Customer`` =
        Prefixed_Name(smg, "CustomerAgreement.Customer") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerAgreement.ServiceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Service category for this agreement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceCategory">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceCategory</seealso>
    let ``CustomerAgreement.ServiceCategory`` =
        Prefixed_Name(smg, "CustomerAgreement.ServiceCategory") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerAgreement.ServiceSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Service supplier for this customer agreement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceSupplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceSupplier">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerAgreement.ServiceSupplier</seealso>
    let ``CustomerAgreement.ServiceSupplier`` =
        Prefixed_Name(smg, "CustomerAgreement.ServiceSupplier") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kind of customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CustomerKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind</seealso>
    let CustomerKind = Prefixed_Name(smg, "CustomerKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.commercialIndustrial</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Commercial industrial customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"commercialIndustrial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.commercialIndustrial">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.commercialIndustrial</seealso>
    let ``CustomerKind.commercialIndustrial`` =
        Prefixed_Name(smg, "CustomerKind.commercialIndustrial") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.energyServiceScheduler</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Customer as energy service scheduler."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"energyServiceScheduler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceScheduler">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceScheduler</seealso>
    let ``CustomerKind.energyServiceScheduler`` =
        Prefixed_Name(smg, "CustomerKind.energyServiceScheduler") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.energyServiceSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Customer as energy service supplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"energyServiceSupplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceSupplier">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.energyServiceSupplier</seealso>
    let ``CustomerKind.energyServiceSupplier`` =
        Prefixed_Name(smg, "CustomerKind.energyServiceSupplier") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.internalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Internal use customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"internalUse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.internalUse">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.internalUse</seealso>
    let ``CustomerKind.internalUse`` =
        Prefixed_Name(smg, "CustomerKind.internalUse") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.other</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Other kind of customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.other">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.other</seealso>
    let ``CustomerKind.other`` =
        Prefixed_Name(smg, "CustomerKind.other") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.pumpingLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Pumping load customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pumpingLoad"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.pumpingLoad">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.pumpingLoad</seealso>
    let ``CustomerKind.pumpingLoad`` =
        Prefixed_Name(smg, "CustomerKind.pumpingLoad") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.residential</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Residential customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"residential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residential">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residential</seealso>
    let ``CustomerKind.residential`` =
        Prefixed_Name(smg, "CustomerKind.residential") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.residentialAndCommercial</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Residential and commercial customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"residentialAndCommercial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndCommercial">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndCommercial</seealso>
    let ``CustomerKind.residentialAndCommercial`` =
        Prefixed_Name(smg, "CustomerKind.residentialAndCommercial") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.residentialAndStreetlight</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Residential and streetlight customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"residentialAndStreetlight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndStreetlight">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialAndStreetlight</seealso>
    let ``CustomerKind.residentialAndStreetlight`` =
        Prefixed_Name(smg, "CustomerKind.residentialAndStreetlight") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.residentialFarmService</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Residential farm service customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"residentialFarmService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialFarmService">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialFarmService</seealso>
    let ``CustomerKind.residentialFarmService`` =
        Prefixed_Name(smg, "CustomerKind.residentialFarmService") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.residentialStreetlightOthers</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Residential streetlight or other related customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"residentialStreetlightOthers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialStreetlightOthers">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.residentialStreetlightOthers</seealso>
    let ``CustomerKind.residentialStreetlightOthers`` =
        Prefixed_Name(smg, "CustomerKind.residentialStreetlightOthers") |> PrefixedName

    /// <summary>
    ///   <para>smg:CustomerKind.windMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:CustomerKind</para>
    ///   <para>"Wind machine customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"windMachine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.windMachine">http://ns.cerise-project.nl/energy/def/cim-smartgrid#CustomerKind.windMachine</seealso>
    let ``CustomerKind.windMachine`` =
        Prefixed_Name(smg, "CustomerKind.windMachine") |> PrefixedName

    /// <summary>
    ///   <para>smg:DateTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Interval between two date and time points."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DateTimeInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval">http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval</seealso>
    let DateTimeInterval = Prefixed_Name(smg, "DateTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>smg:DateTimeInterval.end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"End date and time of this interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"end"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.end">http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.end</seealso>
    let ``DateTimeInterval.end`` =
        Prefixed_Name(smg, "DateTimeInterval.end") |> PrefixedName

    /// <summary>
    ///   <para>smg:DateTimeInterval.start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Start date and time of this interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"start"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.start">http://ns.cerise-project.nl/energy/def/cim-smartgrid#DateTimeInterval.start</seealso>
    let ``DateTimeInterval.start`` =
        Prefixed_Name(smg, "DateTimeInterval.start") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electronic address information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElectronicAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress</seealso>
    let ElectronicAddress = Prefixed_Name(smg, "ElectronicAddress") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.email1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Primary email address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"email1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email1">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email1</seealso>
    let ``ElectronicAddress.email1`` =
        Prefixed_Name(smg, "ElectronicAddress.email1") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.email2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Alternate email address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"email2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email2">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.email2</seealso>
    let ``ElectronicAddress.email2`` =
        Prefixed_Name(smg, "ElectronicAddress.email2") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.lan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Address on local area network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.lan">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.lan</seealso>
    let ``ElectronicAddress.lan`` =
        Prefixed_Name(smg, "ElectronicAddress.lan") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.mac</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"MAC (Media Access Control) address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mac"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.mac">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.mac</seealso>
    let ``ElectronicAddress.mac`` =
        Prefixed_Name(smg, "ElectronicAddress.mac") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.password</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Password needed to log in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"password"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.password">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.password</seealso>
    let ``ElectronicAddress.password`` =
        Prefixed_Name(smg, "ElectronicAddress.password") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Radio address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"radio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.radio">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.radio</seealso>
    let ``ElectronicAddress.radio`` =
        Prefixed_Name(smg, "ElectronicAddress.radio") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.userID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"User ID needed to log in, which can be for an individual person, an organisation, a location, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"userID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.userID">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.userID</seealso>
    let ``ElectronicAddress.userID`` =
        Prefixed_Name(smg, "ElectronicAddress.userID") |> PrefixedName

    /// <summary>
    ///   <para>smg:ElectronicAddress.web</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"World wide web address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"web"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.web">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ElectronicAddress.web</seealso>
    let ``ElectronicAddress.web`` =
        Prefixed_Name(smg, "ElectronicAddress.web") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asset container that performs one or more end device functions. One type of end device is a meter which can perform metering, load management, connect/disconnect, accounting functions, etc. Some end devices, such as ones monitoring and controlling air conditioner, refrigerator, pool pumps may be connected to a meter. All end devices may have communication capability defined by the associated communication function(s). An end device may be owned by a consumer, a service provider, utility or otherwise.
    /// There may be a related end device function that identifies a sensor or control point within a metering application or communications systems (e.g., water, gas, electricity).
    /// Some devices may use an optical port that conforms to the ANSI C12.18 standard for communications."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EndDevice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice</seealso>
    let EndDevice = Prefixed_Name(smg, "EndDevice") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDevice.EndDeviceFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All end device functions this end device performs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EndDeviceFunctions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.EndDeviceFunctions">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.EndDeviceFunctions</seealso>
    let ``EndDevice.EndDeviceFunctions`` =
        Prefixed_Name(smg, "EndDevice.EndDeviceFunctions") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDevice.UsagePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Usage point to which this end device belongs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UsagePoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.UsagePoint">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.UsagePoint</seealso>
    let ``EndDevice.UsagePoint`` =
        Prefixed_Name(smg, "EndDevice.UsagePoint") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDevice.installCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Installation code."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"installCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.installCode">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.installCode</seealso>
    let ``EndDevice.installCode`` =
        Prefixed_Name(smg, "EndDevice.installCode") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDevice.isVirtual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If true, there is no physical device. As an example, a virtual meter can be defined to aggregate the consumption for two or more physical meters. Otherwise, this is a physical hardware device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isVirtual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.isVirtual">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDevice.isVirtual</seealso>
    let ``EndDevice.isVirtual`` =
        Prefixed_Name(smg, "EndDevice.isVirtual") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Function performed by an end device such as a meter, communication equipment, controllers, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EndDeviceFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction</seealso>
    let EndDeviceFunction = Prefixed_Name(smg, "EndDeviceFunction") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunction.EndDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"End device that performs this function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EndDevice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction.EndDevice">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunction.EndDevice</seealso>
    let ``EndDeviceFunction.EndDevice`` =
        Prefixed_Name(smg, "EndDeviceFunction.EndDevice") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kind of end device function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EndDeviceFunctionKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind</seealso>
    let EndDeviceFunctionKind =
        Prefixed_Name(smg, "EndDeviceFunctionKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.autonomousDst</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Autonomous application of daylight savings time (DST)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"autonomousDst"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.autonomousDst">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.autonomousDst</seealso>
    let ``EndDeviceFunctionKind.autonomousDst`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.autonomousDst") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.demandResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Demand response functions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"demandResponse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.demandResponse">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.demandResponse</seealso>
    let ``EndDeviceFunctionKind.demandResponse`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.demandResponse") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.electricMetering</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Electricity metering."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electricMetering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.electricMetering">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.electricMetering</seealso>
    let ``EndDeviceFunctionKind.electricMetering`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.electricMetering") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.gasMetering</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Gas metering."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gasMetering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.gasMetering">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.gasMetering</seealso>
    let ``EndDeviceFunctionKind.gasMetering`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.gasMetering") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.metrology</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Presentation of metered values to a user or another system (always a function of a meter, but might not be supported by a load control unit)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"metrology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.metrology">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.metrology</seealso>
    let ``EndDeviceFunctionKind.metrology`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.metrology") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.onRequestRead</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"On-request reads."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onRequestRead"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.onRequestRead">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.onRequestRead</seealso>
    let ``EndDeviceFunctionKind.onRequestRead`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.onRequestRead") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.outageHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Reporting historical power interruption data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"outageHistory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.outageHistory">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.outageHistory</seealso>
    let ``EndDeviceFunctionKind.outageHistory`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.outageHistory") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.relaysProgramming</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Support for one or more relays that may be programmable in the meter (and tied to TOU, time pulse, load control or other functions)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relaysProgramming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.relaysProgramming">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.relaysProgramming</seealso>
    let ``EndDeviceFunctionKind.relaysProgramming`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.relaysProgramming") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.reverseFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Detection and monitoring of reverse flow."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reverseFlow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.reverseFlow">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.reverseFlow</seealso>
    let ``EndDeviceFunctionKind.reverseFlow`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.reverseFlow") |> PrefixedName

    /// <summary>
    ///   <para>smg:EndDeviceFunctionKind.waterMetering</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:EndDeviceFunctionKind</para>
    ///   <para>"Water metering."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"waterMetering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.waterMetering">http://ns.cerise-project.nl/energy/def/cim-smartgrid#EndDeviceFunctionKind.waterMetering</seealso>
    let ``EndDeviceFunctionKind.waterMetering`` =
        Prefixed_Name(smg, "EndDeviceFunctionKind.waterMetering") |> PrefixedName

    /// <summary>
    ///   <para>smg:IdentifiedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a root class to provide common identification for all classes needing identification and naming attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IdentifiedObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject</seealso>
    let IdentifiedObject = Prefixed_Name(smg, "IdentifiedObject") |> PrefixedName

    /// <summary>
    ///   <para>smg:IdentifiedObject.aliasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The aliasName is free text human readable name of the object alternative to IdentifiedObject.name. It may be non unique and may not correlate to a naming hierarchy.
    /// The attribute aliasName is retained because of backwards compatibility between CIM relases. It is however recommended to replace aliasName with the Name class as aliasName is planned for retirement at a future time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aliasName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.aliasName">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.aliasName</seealso>
    let ``IdentifiedObject.aliasName`` =
        Prefixed_Name(smg, "IdentifiedObject.aliasName") |> PrefixedName

    /// <summary>
    ///   <para>smg:IdentifiedObject.description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The description is a free human readable text describing or naming the object. It may be non unique and may not correlate to a naming hierarchy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.description">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.description</seealso>
    let ``IdentifiedObject.description`` =
        Prefixed_Name(smg, "IdentifiedObject.description") |> PrefixedName

    /// <summary>
    ///   <para>smg:IdentifiedObject.mRID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Master resource identifier issued by a model authority. The mRID must semantically be a UUID as specified in RFC 4122. The mRID is globally unique.
    /// For CIMXML data files in RDF syntax, the mRID is mapped to rdf:ID or rdf:about attributes that identify CIM object elements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mRID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.mRID">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.mRID</seealso>
    let ``IdentifiedObject.mRID`` =
        Prefixed_Name(smg, "IdentifiedObject.mRID") |> PrefixedName

    /// <summary>
    ///   <para>smg:IdentifiedObject.name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name is any free human readable and possibly non unique text naming the object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.name">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IdentifiedObject.name</seealso>
    let ``IdentifiedObject.name`` =
        Prefixed_Name(smg, "IdentifiedObject.name") |> PrefixedName

    /// <summary>
    ///   <para>smg:IntervalBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Time sequence of readings of the same reading type. Contained interval readings may need conversion through the application of an offset and a scalar defined in associated pending."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntervalBlock"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock</seealso>
    let IntervalBlock = Prefixed_Name(smg, "IntervalBlock") |> PrefixedName

    /// <summary>
    ///   <para>smg:IntervalBlock.IntervalReadings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Interval reading contained in this block."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntervalReadings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.IntervalReadings">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.IntervalReadings</seealso>
    let ``IntervalBlock.IntervalReadings`` =
        Prefixed_Name(smg, "IntervalBlock.IntervalReadings") |> PrefixedName

    /// <summary>
    ///   <para>smg:IntervalBlock.MeterReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Meter reading containing this interval block."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterReading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.MeterReading">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.MeterReading</seealso>
    let ``IntervalBlock.MeterReading`` =
        Prefixed_Name(smg, "IntervalBlock.MeterReading") |> PrefixedName

    /// <summary>
    ///   <para>smg:IntervalBlock.ReadingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type information for interval reading values contained in this block."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ReadingType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.ReadingType">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalBlock.ReadingType</seealso>
    let ``IntervalBlock.ReadingType`` =
        Prefixed_Name(smg, "IntervalBlock.ReadingType") |> PrefixedName

    /// <summary>
    ///   <para>smg:IntervalReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data captured at regular intervals of time. Interval data could be captured as incremental data, absolute data, or relative data. The source for the data is usually a tariff quantity or an engineering quantity. Data is typically captured in time-tagged, uniform, fixed-length intervals of 5 min, 10 min, 15 min, 30 min, or 60 min.
    /// Note: Interval Data is sometimes also called "Interval Data Readings" (IDR)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntervalReading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading</seealso>
    let IntervalReading = Prefixed_Name(smg, "IntervalReading") |> PrefixedName

    /// <summary>
    ///   <para>smg:IntervalReading.IntervalBlocks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All blocks containing this interval reading."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntervalBlocks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading.IntervalBlocks">http://ns.cerise-project.nl/energy/def/cim-smartgrid#IntervalReading.IntervalBlocks</seealso>
    let ``IntervalReading.IntervalBlocks`` =
        Prefixed_Name(smg, "IntervalReading.IntervalBlocks") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The place, scene, or point of something where someone or something has been, is, and/or will be at a given moment in time. It can be defined with one or more postition points (coordinates) in a given coordinate system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location</seealso>
    let Location = Prefixed_Name(smg, "Location") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.CoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Coordinate system used to describe position points of this location."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CoordinateSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.CoordinateSystem">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.CoordinateSystem</seealso>
    let ``Location.CoordinateSystem`` =
        Prefixed_Name(smg, "Location.CoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.PositionPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Sequence of position points describing this location, expressed in coordinate system 'Location.CoordinateSystem'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PositionPoints"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.PositionPoints">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.PositionPoints</seealso>
    let ``Location.PositionPoints`` =
        Prefixed_Name(smg, "Location.PositionPoints") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.electronicAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Electronic address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electronicAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.electronicAddress">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.electronicAddress</seealso>
    let ``Location.electronicAddress`` =
        Prefixed_Name(smg, "Location.electronicAddress") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.geoInfoReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(if applicable) Reference to geographical information source, often external to the utility."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geoInfoReference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.geoInfoReference">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.geoInfoReference</seealso>
    let ``Location.geoInfoReference`` =
        Prefixed_Name(smg, "Location.geoInfoReference") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.mainAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Main address of the location."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mainAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.mainAddress">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.mainAddress</seealso>
    let ``Location.mainAddress`` =
        Prefixed_Name(smg, "Location.mainAddress") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.phone1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Phone number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phone1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone1">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone1</seealso>
    let ``Location.phone1`` = Prefixed_Name(smg, "Location.phone1") |> PrefixedName
    /// <summary>
    ///   <para>smg:Location.phone2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Additional phone number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phone2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone2">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.phone2</seealso>
    let ``Location.phone2`` = Prefixed_Name(smg, "Location.phone2") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.secondaryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Secondary address of the location. For example, PO Box address may have different ZIP code than that in the 'mainAddress'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"secondaryAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.secondaryAddress">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.secondaryAddress</seealso>
    let ``Location.secondaryAddress`` =
        Prefixed_Name(smg, "Location.secondaryAddress") |> PrefixedName

    /// <summary>
    ///   <para>smg:Location.status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Status of this location."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.status">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.status</seealso>
    let ``Location.status`` = Prefixed_Name(smg, "Location.status") |> PrefixedName
    /// <summary>
    ///   <para>smg:Location.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Classification by utility's corporate standards and practices, relative to the location itself (e.g., geographical, functional accounting, etc., not a given property that happens to exist at that location)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.type">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Location.type</seealso>
    let ``Location.type`` = Prefixed_Name(smg, "Location.type") |> PrefixedName
    /// <summary>
    ///   <para>smg:Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical asset that performs the metering role of the usage point. Used for measuring consumption and detection of events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter</seealso>
    let Meter = Prefixed_Name(smg, "Meter") |> PrefixedName

    /// <summary>
    ///   <para>smg:Meter.MeterMultipliers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All multipliers applied at this meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterMultipliers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterMultipliers">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterMultipliers</seealso>
    let ``Meter.MeterMultipliers`` =
        Prefixed_Name(smg, "Meter.MeterMultipliers") |> PrefixedName

    /// <summary>
    ///   <para>smg:Meter.MeterReadings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All meter readings provided by this meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterReadings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterReadings">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.MeterReadings</seealso>
    let ``Meter.MeterReadings`` =
        Prefixed_Name(smg, "Meter.MeterReadings") |> PrefixedName

    /// <summary>
    ///   <para>smg:Meter.formNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Meter form designation per ANSI C12.10 or other applicable standard. An alphanumeric designation denoting the circuit arrangement for which the meter is applicable and its specific terminal arrangement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"formNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.formNumber">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Meter.formNumber</seealso>
    let ``Meter.formNumber`` = Prefixed_Name(smg, "Meter.formNumber") |> PrefixedName
    /// <summary>
    ///   <para>smg:MeterMultiplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Multiplier applied at the meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterMultiplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier</seealso>
    let MeterMultiplier = Prefixed_Name(smg, "MeterMultiplier") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplier.Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Meter applying this multiplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.Meter">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.Meter</seealso>
    let ``MeterMultiplier.Meter`` =
        Prefixed_Name(smg, "MeterMultiplier.Meter") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplier.kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Kind of multiplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.kind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.kind</seealso>
    let ``MeterMultiplier.kind`` =
        Prefixed_Name(smg, "MeterMultiplier.kind") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplier.value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Multiplier value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.value">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplier.value</seealso>
    let ``MeterMultiplier.value`` =
        Prefixed_Name(smg, "MeterMultiplier.value") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kind of meter multiplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterMultiplierKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind</seealso>
    let MeterMultiplierKind = Prefixed_Name(smg, "MeterMultiplierKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind.ctRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:MeterMultiplierKind</para>
    ///   <para>"Current transformer ratio used to convert associated quantities to real measurements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ctRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ctRatio">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ctRatio</seealso>
    let ``MeterMultiplierKind.ctRatio`` =
        Prefixed_Name(smg, "MeterMultiplierKind.ctRatio") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind.kE</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:MeterMultiplierKind</para>
    ///   <para>"Test constant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kE">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kE</seealso>
    let ``MeterMultiplierKind.kE`` =
        Prefixed_Name(smg, "MeterMultiplierKind.kE") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind.kH</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:MeterMultiplierKind</para>
    ///   <para>"Meter kh (watthour) constant. The number of watthours that must be applied to the meter to cause one disk revolution for an electromechanical meter or the number of watthours represented by one increment pulse for an electronic meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kH">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kH</seealso>
    let ``MeterMultiplierKind.kH`` =
        Prefixed_Name(smg, "MeterMultiplierKind.kH") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind.kR</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:MeterMultiplierKind</para>
    ///   <para>"Register multiplier. The number to multiply the register reading by in order to get kWh."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kR">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.kR</seealso>
    let ``MeterMultiplierKind.kR`` =
        Prefixed_Name(smg, "MeterMultiplierKind.kR") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind.ptRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:MeterMultiplierKind</para>
    ///   <para>"Potential transformer ratio used to convert associated quantities to real measurements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ptRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ptRatio">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.ptRatio</seealso>
    let ``MeterMultiplierKind.ptRatio`` =
        Prefixed_Name(smg, "MeterMultiplierKind.ptRatio") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterMultiplierKind.transformerRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:MeterMultiplierKind</para>
    ///   <para>"Product of the CT ratio and PT ratio."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"transformerRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.transformerRatio">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterMultiplierKind.transformerRatio</seealso>
    let ``MeterMultiplierKind.transformerRatio`` =
        Prefixed_Name(smg, "MeterMultiplierKind.transformerRatio") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Set of values obtained from the meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterReading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading</seealso>
    let MeterReading = Prefixed_Name(smg, "MeterReading") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterReading.CustomerAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(could be deprecated in the future) Customer agreement for this meter reading."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CustomerAgreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.CustomerAgreement">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.CustomerAgreement</seealso>
    let ``MeterReading.CustomerAgreement`` =
        Prefixed_Name(smg, "MeterReading.CustomerAgreement") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterReading.Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Meter providing this reading."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Meter">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Meter</seealso>
    let ``MeterReading.Meter`` =
        Prefixed_Name(smg, "MeterReading.Meter") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterReading.Readings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All reading values contained within this meter reading."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Readings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Readings">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.Readings</seealso>
    let ``MeterReading.Readings`` =
        Prefixed_Name(smg, "MeterReading.Readings") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterReading.UsagePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Usage point from which this meter reading (set of values) has been obtained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UsagePoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.UsagePoint">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.UsagePoint</seealso>
    let ``MeterReading.UsagePoint`` =
        Prefixed_Name(smg, "MeterReading.UsagePoint") |> PrefixedName

    /// <summary>
    ///   <para>smg:MeterReading.valuesInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Date and time interval of the data items contained within this meter reading."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"valuesInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.valuesInterval">http://ns.cerise-project.nl/energy/def/cim-smartgrid#MeterReading.valuesInterval</seealso>
    let ``MeterReading.valuesInterval`` =
        Prefixed_Name(smg, "MeterReading.valuesInterval") |> PrefixedName

    /// <summary>
    ///   <para>smg:OrganisationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies a way in which an organisation may participate in the utility enterprise (e.g., customer, manufacturer, etc)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OrganisationRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#OrganisationRole">http://ns.cerise-project.nl/energy/def/cim-smartgrid#OrganisationRole</seealso>
    let OrganisationRole = Prefixed_Name(smg, "OrganisationRole") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_Base</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///
    /// labels<para>"Base"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Base">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Base</seealso>
    let Package_Base = Prefixed_Name(smg, "Package_Base") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_Common</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"This package contains the information classes that support distribution management in general."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Common"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Common">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Common</seealso>
    let Package_Common = Prefixed_Name(smg, "Package_Common") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_Core</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"Contains the core PowerSystemResource and ConductingEquipment entities shared by all applications plus common collections of those entities. Not all applications require all the Core entities.  This package does not depend on any other package except the Domain package, but most of the other packages have associations and generalizations that depend on it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Core"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Core">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Core</seealso>
    let Package_Core = Prefixed_Name(smg, "Package_Core") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_Customers</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"This package contains the core information classes that support customer billing applications."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Customers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Customers">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Customers</seealso>
    let Package_Customers = Prefixed_Name(smg, "Package_Customers") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"The domain package define primitive datatypes that are used by classes in other packages. Stereotypes are used to describe the datatypes. The following stereotypes are defined:
    /// &amp;lt;&amp;lt;enumeration&amp;gt;&amp;gt; A list of permissible constant values.
    /// &amp;lt;&amp;lt;Primitive&amp;gt;&amp;gt; The most basic data types used to compose all other data types.
    /// &amp;lt;&amp;lt;CIMDatatype&amp;gt;&amp;gt; A datatype that contains a value attribute, an optional unit of measure and a unit multiplier. The unit and multiplier may be specified as a static variable initialized to the allowed value.
    /// &amp;lt;&amp;lt;Compound&amp;gt;&amp;gt; A composite of Primitive, enumeration, CIMDatatype or othe Compound classes, as long as the Compound classes do not recurse."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Domain">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Domain</seealso>
    let Package_Domain = Prefixed_Name(smg, "Package_Domain") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_IEC61968</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"The IEC 61968 subpackages of the CIM are developed, standardized and maintained by IEC TC57 Working Group 14: interfaces for distribution management (WG14).
    /// Currently, normative parts of the model support the needs of information exchange defined in IEC 61968-3, IEC 61968-4, IEC 61968-9 and in IEC 61968-13."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IEC61968"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61968">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61968</seealso>
    let Package_IEC61968 = Prefixed_Name(smg, "Package_IEC61968") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_IEC61970</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"Top package for IEC 61970."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IEC61970"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61970">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_IEC61970</seealso>
    let Package_IEC61970 = Prefixed_Name(smg, "Package_IEC61970") |> PrefixedName
    /// <summary>
    ///   <para>smg:Package_Metering</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"This package contains the core information classes that support end device applications with specialized classes for metering and premise are network devices, and remote reading functions. These classes are generally associated with the point where a service is delivered to the customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Metering">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_Metering</seealso>
    let Package_Metering = Prefixed_Name(smg, "Package_Metering") |> PrefixedName

    /// <summary>
    ///   <para>smg:Package_PaymentMetering</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"This package is an extension of the Metering package and contains the information classes that support specialised applications such as prepayment metering. These classes are generally associated with the collection and control of revenue from the customer for a delivered service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PaymentMetering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_PaymentMetering">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_PaymentMetering</seealso>
    let Package_PaymentMetering =
        Prefixed_Name(smg, "Package_PaymentMetering") |> PrefixedName

    /// <summary>
    ///   <para>smg:Package_TC57CIM</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///   <para>"Top package for IEC TC57 CIM."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TC57CIM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_TC57CIM">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Package_TC57CIM</seealso>
    let Package_TC57CIM = Prefixed_Name(smg, "Package_TC57CIM") |> PrefixedName
    /// <summary>
    ///   <para>smg:PositionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Set of spatial coordinates that determine a point, defined in coordinate system specified in 'Location.CoordinateSystem'. Use a single position point instance to desribe a point-oriented location. Use a sequence of position points to describe a line-oriented object (physical location of non-point oriented objects like cables or lines), or area of an object (like a substation or a geographical zone - in this case, have first and last position point with the same values)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PositionPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint">http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint</seealso>
    let PositionPoint = Prefixed_Name(smg, "PositionPoint") |> PrefixedName

    /// <summary>
    ///   <para>smg:PositionPoint.Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Location described by this position point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.Location">http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.Location</seealso>
    let ``PositionPoint.Location`` =
        Prefixed_Name(smg, "PositionPoint.Location") |> PrefixedName

    /// <summary>
    ///   <para>smg:PositionPoint.sequenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Zero-relative sequence number of this point within a series of points."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sequenceNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.sequenceNumber">http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.sequenceNumber</seealso>
    let ``PositionPoint.sequenceNumber`` =
        Prefixed_Name(smg, "PositionPoint.sequenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>smg:PositionPoint.xPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"X axis position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xPosition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.xPosition">http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.xPosition</seealso>
    let ``PositionPoint.xPosition`` =
        Prefixed_Name(smg, "PositionPoint.xPosition") |> PrefixedName

    /// <summary>
    ///   <para>smg:PositionPoint.yPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Y axis position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"yPosition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.yPosition">http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.yPosition</seealso>
    let ``PositionPoint.yPosition`` =
        Prefixed_Name(smg, "PositionPoint.yPosition") |> PrefixedName

    /// <summary>
    ///   <para>smg:PositionPoint.zPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(if applicable) Z axis position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"zPosition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.zPosition">http://ns.cerise-project.nl/energy/def/cim-smartgrid#PositionPoint.zPosition</seealso>
    let ``PositionPoint.zPosition`` =
        Prefixed_Name(smg, "PositionPoint.zPosition") |> PrefixedName

    /// <summary>
    ///   <para>smg:Reading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specific value measured by a meter or other asset, or calculated by a system. Each Reading is associated with a specific ReadingType."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading</seealso>
    let Reading = Prefixed_Name(smg, "Reading") |> PrefixedName

    /// <summary>
    ///   <para>smg:Reading.MeterReadings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All meter readings (sets of values) containing this reading value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterReadings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.MeterReadings">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.MeterReadings</seealso>
    let ``Reading.MeterReadings`` =
        Prefixed_Name(smg, "Reading.MeterReadings") |> PrefixedName

    /// <summary>
    ///   <para>smg:Reading.ReadingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type information for this reading value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ReadingType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.ReadingType">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Reading.ReadingType</seealso>
    let ``Reading.ReadingType`` =
        Prefixed_Name(smg, "Reading.ReadingType") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Detailed description for a type of a reading value. Values in attributes allow for creation of recommended codes to be used for identifying reading value types as follows: &amp;lt;macroPeriod&amp;gt;.&amp;lt;aggregate&amp;gt;.&amp;lt;measuringPeriod&amp;gt;.&amp;lt;accumulation&amp;gt;.&amp;lt;flowDirection&amp;gt;.&amp;lt;commodity&amp;gt;.&amp;lt;measurementKind&amp;gt;.&amp;lt;interharmonic.numerator&amp;gt;.&amp;lt;interharmonic.denominator&amp;gt;.&amp;lt;argument.numerator&amp;gt;.&amp;lt;argument.denominator&amp;gt;.&amp;lt;tou&amp;gt;.&amp;lt;cpp&amp;gt;.&amp;lt;consumptionTier&amp;gt;.&amp;lt;phases&amp;gt;.&amp;lt;multiplier&amp;gt;.&amp;lt;unit&amp;gt;.&amp;lt;currency&amp;gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ReadingType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType</seealso>
    let ReadingType = Prefixed_Name(smg, "ReadingType") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.accumulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Accumulation behaviour of a reading over time, usually 'measuringPeriod', to be used with individual endpoints (as opposed to 'macroPeriod' and 'aggregate' that are used to describe aggregations of data from individual endpoints)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"accumulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.accumulation">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.accumulation</seealso>
    let ``ReadingType.accumulation`` =
        Prefixed_Name(smg, "ReadingType.accumulation") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Salient attribute of the reading data aggregated from individual endpoints. This is mainly used to define a mathematical operation carried out over 'macroPeriod', but may also be used to describe an attribute of the data when the 'macroPeriod' is not defined."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aggregate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.aggregate">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.aggregate</seealso>
    let ``ReadingType.aggregate`` =
        Prefixed_Name(smg, "ReadingType.aggregate") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.commodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Commodity being measured."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"commodity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.commodity">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.commodity</seealso>
    let ``ReadingType.commodity`` =
        Prefixed_Name(smg, "ReadingType.commodity") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.flowDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Flow direction for a reading where the direction of flow of the commodity is important (for electricity measurements this includes current, energy, power, and demand)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"flowDirection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.flowDirection">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.flowDirection</seealso>
    let ``ReadingType.flowDirection`` =
        Prefixed_Name(smg, "ReadingType.flowDirection") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.measurementKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies "what" is being measured, as refinement of 'commodity'. When combined with 'unit', it provides detail to the unit of measure. For example, 'energy' with a unit of measure of 'kWh' indicates to the user that active energy is being measured, while with 'kVAh' or 'kVArh', it indicates apparent energy and reactive energy, respectively. 'power' can be combined in a similar way with various power units of measure: Distortion power ('distortionVoltAmperes') with 'kVA' is different from 'power' with 'kVA'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"measurementKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measurementKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measurementKind</seealso>
    let ``ReadingType.measurementKind`` =
        Prefixed_Name(smg, "ReadingType.measurementKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.measuringPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time attribute inherent or fundamental to the reading value (as opposed to 'macroPeriod' that supplies an "adjective" to describe aspects of a time period with regard to the measurement). It refers to the way the value was originally measured and not to the frequency at which it is reported or presented. For example, an hourly interval of consumption data would have value 'hourly' as an attribute. However in the case of an hourly sampled voltage value, the meterReadings schema would carry the 'hourly' interval size information.
    /// It is common for meters to report demand in a form that is measured over the course of a portion of an hour, while enterprise applications however commonly assume the demand (in kW or kVAr) normalised to 1 hour. The sytem that receives readings directly from the meter therefore must perform this transformation before publishing readings for use by the other enterprise systems. The scalar used is chosen based on the block size (not any sub-interval size)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"measuringPeriod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measuringPeriod">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.measuringPeriod</seealso>
    let ``ReadingType.measuringPeriod`` =
        Prefixed_Name(smg, "ReadingType.measuringPeriod") |> PrefixedName

    /// <summary>
    ///   <para>smg:ReadingType.unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Metering-specific unit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.unit">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ReadingType.unit</seealso>
    let ``ReadingType.unit`` = Prefixed_Name(smg, "ReadingType.unit") |> PrefixedName
    /// <summary>
    ///   <para>smg:ServiceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Category of service provided to the customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory</seealso>
    let ServiceCategory = Prefixed_Name(smg, "ServiceCategory") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceCategory.kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Kind of service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory.kind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceCategory.kind</seealso>
    let ``ServiceCategory.kind`` =
        Prefixed_Name(smg, "ServiceCategory.kind") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kind of service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind</seealso>
    let ServiceKind = Prefixed_Name(smg, "ServiceKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Electricity service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electricity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.electricity">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.electricity</seealso>
    let ``ServiceKind.electricity`` =
        Prefixed_Name(smg, "ServiceKind.electricity") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Gas service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.gas">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.gas</seealso>
    let ``ServiceKind.gas`` = Prefixed_Name(smg, "ServiceKind.gas") |> PrefixedName
    /// <summary>
    ///   <para>smg:ServiceKind.heat</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Heat service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"heat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.heat">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.heat</seealso>
    let ``ServiceKind.heat`` = Prefixed_Name(smg, "ServiceKind.heat") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Internet service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"internet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.internet">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.internet</seealso>
    let ``ServiceKind.internet`` =
        Prefixed_Name(smg, "ServiceKind.internet") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.other</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Other kind of service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.other">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.other</seealso>
    let ``ServiceKind.other`` = Prefixed_Name(smg, "ServiceKind.other") |> PrefixedName
    /// <summary>
    ///   <para>smg:ServiceKind.rates</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Rates (e.g. tax, charge, toll, duty, tariff, etc.) service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.rates">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.rates</seealso>
    let ``ServiceKind.rates`` = Prefixed_Name(smg, "ServiceKind.rates") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.refuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Refuse (waster) service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"refuse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.refuse">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.refuse</seealso>
    let ``ServiceKind.refuse`` =
        Prefixed_Name(smg, "ServiceKind.refuse") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.sewerage</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Sewerage service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sewerage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.sewerage">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.sewerage</seealso>
    let ``ServiceKind.sewerage`` =
        Prefixed_Name(smg, "ServiceKind.sewerage") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.time</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Time service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.time">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.time</seealso>
    let ``ServiceKind.time`` = Prefixed_Name(smg, "ServiceKind.time") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.tvLicence</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"TV license service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tvLicence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.tvLicence">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.tvLicence</seealso>
    let ``ServiceKind.tvLicence`` =
        Prefixed_Name(smg, "ServiceKind.tvLicence") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceKind.water</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:ServiceKind</para>
    ///   <para>"Water service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"water"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.water">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceKind.water</seealso>
    let ``ServiceKind.water`` = Prefixed_Name(smg, "ServiceKind.water") |> PrefixedName
    /// <summary>
    ///   <para>smg:ServiceSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organisation that provides services to customers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceSupplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier</seealso>
    let ServiceSupplier = Prefixed_Name(smg, "ServiceSupplier") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceSupplier.issuerIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique transaction reference prefix number issued to an entity by the International Standards Organisation for the purpose of tagging onto electronic financial transactions, as defined in ISO/IEC 7812-1 and ISO/IEC 7812-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"issuerIdentificationNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.issuerIdentificationNumber">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.issuerIdentificationNumber</seealso>
    let ``ServiceSupplier.issuerIdentificationNumber`` =
        Prefixed_Name(smg, "ServiceSupplier.issuerIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>smg:ServiceSupplier.kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Kind of supplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.kind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#ServiceSupplier.kind</seealso>
    let ``ServiceSupplier.kind`` =
        Prefixed_Name(smg, "ServiceSupplier.kind") |> PrefixedName

    /// <summary>
    ///   <para>smg:SimpleEndDeviceFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Simple end device function distinguished by 'kind'. Use this class for instances that cannot be represented by another end device function specialisations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SimpleEndDeviceFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction">http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction</seealso>
    let SimpleEndDeviceFunction =
        Prefixed_Name(smg, "SimpleEndDeviceFunction") |> PrefixedName

    /// <summary>
    ///   <para>smg:SimpleEndDeviceFunction.kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Kind of this function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction.kind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#SimpleEndDeviceFunction.kind</seealso>
    let ``SimpleEndDeviceFunction.kind`` =
        Prefixed_Name(smg, "SimpleEndDeviceFunction.kind") |> PrefixedName

    /// <summary>
    ///   <para>smg:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Current status information relevant to an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status</seealso>
    let Status = Prefixed_Name(smg, "Status") |> PrefixedName
    /// <summary>
    ///   <para>smg:Status.dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date and time for which status 'value' applies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.dateTime">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.dateTime</seealso>
    let ``Status.dateTime`` = Prefixed_Name(smg, "Status.dateTime") |> PrefixedName
    /// <summary>
    ///   <para>smg:Status.reason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reason code or explanation for why an object went to the current status 'value'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.reason">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.reason</seealso>
    let ``Status.reason`` = Prefixed_Name(smg, "Status.reason") |> PrefixedName
    /// <summary>
    ///   <para>smg:Status.remark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pertinent information regarding the current 'value', as free form text."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"remark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.remark">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.remark</seealso>
    let ``Status.remark`` = Prefixed_Name(smg, "Status.remark") |> PrefixedName
    /// <summary>
    ///   <para>smg:Status.value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Status value at 'dateTime'; prior status changes may have been kept in instances of activity records associated with the object to which this status applies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.value">http://ns.cerise-project.nl/energy/def/cim-smartgrid#Status.value</seealso>
    let ``Status.value`` = Prefixed_Name(smg, "Status.value") |> PrefixedName
    /// <summary>
    ///   <para>smg:StreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"General purpose street address information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StreetAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress</seealso>
    let StreetAddress = Prefixed_Name(smg, "StreetAddress") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetAddress.streetDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Street detail."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"streetDetail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.streetDetail">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.streetDetail</seealso>
    let ``StreetAddress.streetDetail`` =
        Prefixed_Name(smg, "StreetAddress.streetDetail") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetAddress.townDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Town detail."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"townDetail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.townDetail">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetAddress.townDetail</seealso>
    let ``StreetAddress.townDetail`` =
        Prefixed_Name(smg, "StreetAddress.townDetail") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Street details, in the context of address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StreetDetail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail</seealso>
    let StreetDetail = Prefixed_Name(smg, "StreetDetail") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.addressGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Additional address information, for example a mailstop."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"addressGeneral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.addressGeneral">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.addressGeneral</seealso>
    let ``StreetDetail.addressGeneral`` =
        Prefixed_Name(smg, "StreetDetail.addressGeneral") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.buildingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(if applicable) In certain cases the physical location of the place of interest does not have a direct point of entry from the street, but may be located inside a larger structure such as a building, complex, office block, apartment, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"buildingName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.buildingName">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.buildingName</seealso>
    let ``StreetDetail.buildingName`` =
        Prefixed_Name(smg, "StreetDetail.buildingName") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(if applicable) Utilities often make use of external reference systems, such as those of the town-planner's department or surveyor general's mapping system, that allocate global reference codes to streets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.code">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.code</seealso>
    let ``StreetDetail.code`` = Prefixed_Name(smg, "StreetDetail.code") |> PrefixedName
    /// <summary>
    ///   <para>smg:StreetDetail.name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the street."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.name">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.name</seealso>
    let ``StreetDetail.name`` = Prefixed_Name(smg, "StreetDetail.name") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Designator of the specific location on the street."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.number">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.number</seealso>
    let ``StreetDetail.number`` =
        Prefixed_Name(smg, "StreetDetail.number") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Prefix to the street name. For example: North, South, East, West."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.prefix">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.prefix</seealso>
    let ``StreetDetail.prefix`` =
        Prefixed_Name(smg, "StreetDetail.prefix") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Suffix to the street name. For example: North, South, East, West."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suffix">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suffix</seealso>
    let ``StreetDetail.suffix`` =
        Prefixed_Name(smg, "StreetDetail.suffix") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.suiteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of the apartment or suite."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"suiteNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suiteNumber">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.suiteNumber</seealso>
    let ``StreetDetail.suiteNumber`` =
        Prefixed_Name(smg, "StreetDetail.suiteNumber") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of street. Examples include: street, circle, boulevard, avenue, road, drive, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.type">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.type</seealso>
    let ``StreetDetail.type`` = Prefixed_Name(smg, "StreetDetail.type") |> PrefixedName

    /// <summary>
    ///   <para>smg:StreetDetail.withinTownLimits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"True if this street is within the legal geographical boundaries of the specified town (default)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"withinTownLimits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.withinTownLimits">http://ns.cerise-project.nl/energy/def/cim-smartgrid#StreetDetail.withinTownLimits</seealso>
    let ``StreetDetail.withinTownLimits`` =
        Prefixed_Name(smg, "StreetDetail.withinTownLimits") |> PrefixedName

    /// <summary>
    ///   <para>smg:SupplierKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kind of supplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SupplierKind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind">http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind</seealso>
    let SupplierKind = Prefixed_Name(smg, "SupplierKind") |> PrefixedName

    /// <summary>
    ///   <para>smg:SupplierKind.other</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:SupplierKind</para>
    ///   <para>"Other kind of supplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.other">http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.other</seealso>
    let ``SupplierKind.other`` =
        Prefixed_Name(smg, "SupplierKind.other") |> PrefixedName

    /// <summary>
    ///   <para>smg:SupplierKind.retailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:SupplierKind</para>
    ///   <para>"Entity that sells the service, but does not deliver to the customer; applies to the deregulated markets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"retailer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.retailer">http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.retailer</seealso>
    let ``SupplierKind.retailer`` =
        Prefixed_Name(smg, "SupplierKind.retailer") |> PrefixedName

    /// <summary>
    ///   <para>smg:SupplierKind.utility</para>
    /// </summary>
    /// <remarks>
    ///   <para>smg:SupplierKind</para>
    ///   <para>"Entity that delivers the service to the customer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"utility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.utility">http://ns.cerise-project.nl/energy/def/cim-smartgrid#SupplierKind.utility</seealso>
    let ``SupplierKind.utility`` =
        Prefixed_Name(smg, "SupplierKind.utility") |> PrefixedName

    /// <summary>
    ///   <para>smg:TelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Telephone number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TelephoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber</seealso>
    let TelephoneNumber = Prefixed_Name(smg, "TelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>smg:TelephoneNumber.areaCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Area or region code."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"areaCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.areaCode">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.areaCode</seealso>
    let ``TelephoneNumber.areaCode`` =
        Prefixed_Name(smg, "TelephoneNumber.areaCode") |> PrefixedName

    /// <summary>
    ///   <para>smg:TelephoneNumber.cityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(if applicable) City code."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cityCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.cityCode">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.cityCode</seealso>
    let ``TelephoneNumber.cityCode`` =
        Prefixed_Name(smg, "TelephoneNumber.cityCode") |> PrefixedName

    /// <summary>
    ///   <para>smg:TelephoneNumber.countryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Country code."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"countryCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.countryCode">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.countryCode</seealso>
    let ``TelephoneNumber.countryCode`` =
        Prefixed_Name(smg, "TelephoneNumber.countryCode") |> PrefixedName

    /// <summary>
    ///   <para>smg:TelephoneNumber.extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"(if applicable) Extension for this telephone number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"extension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.extension">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.extension</seealso>
    let ``TelephoneNumber.extension`` =
        Prefixed_Name(smg, "TelephoneNumber.extension") |> PrefixedName

    /// <summary>
    ///   <para>smg:TelephoneNumber.localNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Main (local) part of this telephone number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"localNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.localNumber">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TelephoneNumber.localNumber</seealso>
    let ``TelephoneNumber.localNumber`` =
        Prefixed_Name(smg, "TelephoneNumber.localNumber") |> PrefixedName

    /// <summary>
    ///   <para>smg:TownDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Town details, in the context of address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TownDetail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail</seealso>
    let TownDetail = Prefixed_Name(smg, "TownDetail") |> PrefixedName
    /// <summary>
    ///   <para>smg:TownDetail.code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Town code."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.code">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.code</seealso>
    let ``TownDetail.code`` = Prefixed_Name(smg, "TownDetail.code") |> PrefixedName

    /// <summary>
    ///   <para>smg:TownDetail.country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the country."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.country">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.country</seealso>
    let ``TownDetail.country`` =
        Prefixed_Name(smg, "TownDetail.country") |> PrefixedName

    /// <summary>
    ///   <para>smg:TownDetail.name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Town name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.name">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.name</seealso>
    let ``TownDetail.name`` = Prefixed_Name(smg, "TownDetail.name") |> PrefixedName

    /// <summary>
    ///   <para>smg:TownDetail.section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Town section. For example, it is common for there to be 36 sections per township."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.section">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.section</seealso>
    let ``TownDetail.section`` =
        Prefixed_Name(smg, "TownDetail.section") |> PrefixedName

    /// <summary>
    ///   <para>smg:TownDetail.stateOrProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the state or province."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"stateOrProvince"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.stateOrProvince">http://ns.cerise-project.nl/energy/def/cim-smartgrid#TownDetail.stateOrProvince</seealso>
    let ``TownDetail.stateOrProvince`` =
        Prefixed_Name(smg, "TownDetail.stateOrProvince") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Logical or physical point in the network to which readings or events may be attributed. Used at the place where a physical or virtual meter may be located; however, it is not required that a meter be present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UsagePoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint</seealso>
    let UsagePoint = Prefixed_Name(smg, "UsagePoint") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.CustomerAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Customer agreement regulating this service delivery point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CustomerAgreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.CustomerAgreement">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.CustomerAgreement</seealso>
    let ``UsagePoint.CustomerAgreement`` =
        Prefixed_Name(smg, "UsagePoint.CustomerAgreement") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.MeterReadings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"All meter readings obtained from this usage point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeterReadings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.MeterReadings">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.MeterReadings</seealso>
    let ``UsagePoint.MeterReadings`` =
        Prefixed_Name(smg, "UsagePoint.MeterReadings") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.ServiceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Service category delivered by this usage point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceCategory">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceCategory</seealso>
    let ``UsagePoint.ServiceCategory`` =
        Prefixed_Name(smg, "UsagePoint.ServiceCategory") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.ServiceSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ServiceSupplier (Utility) utilising this usage point to deliver a service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceSupplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceSupplier">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.ServiceSupplier</seealso>
    let ``UsagePoint.ServiceSupplier`` =
        Prefixed_Name(smg, "UsagePoint.ServiceSupplier") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.UsagePointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Location of this usage point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UsagePointLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.UsagePointLocation">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.UsagePointLocation</seealso>
    let ``UsagePoint.UsagePointLocation`` =
        Prefixed_Name(smg, "UsagePoint.UsagePointLocation") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.amiBillingReady</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Tracks the lifecycle of the metering installation at a usage point with respect to readiness for billing via advanced metering infrastructure reads."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"amiBillingReady"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.amiBillingReady">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.amiBillingReady</seealso>
    let ``UsagePoint.amiBillingReady`` =
        Prefixed_Name(smg, "UsagePoint.amiBillingReady") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.isSdp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If true, this usage point is a service delivery point, i.e., a usage point where the ownership of the service changes hands."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isSdp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isSdp">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isSdp</seealso>
    let ``UsagePoint.isSdp`` = Prefixed_Name(smg, "UsagePoint.isSdp") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePoint.isVirtual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If true, this usage point is virtual, i.e., no physical location exists in the network where a meter could be located to collect the meter readings. For example, one may define a virtual usage point to serve as an aggregation of usage for all of a companies premises distributed widely across the distribution territory. Otherwise, the usage point is physical, i.e., there is a logical point in the network where a meter could be located to collect meter readings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isVirtual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isVirtual">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePoint.isVirtual</seealso>
    let ``UsagePoint.isVirtual`` =
        Prefixed_Name(smg, "UsagePoint.isVirtual") |> PrefixedName

    /// <summary>
    ///   <para>smg:UsagePointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Location of an individual usage point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UsagePointLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePointLocation">http://ns.cerise-project.nl/energy/def/cim-smartgrid#UsagePointLocation</seealso>
    let UsagePointLocation = Prefixed_Name(smg, "UsagePointLocation") |> PrefixedName
    /// <summary>
    ///   <para>smg:global_package</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://langdale.com.au/2005/UML#Package&gt;</para>
    ///
    /// labels<para>"Global"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.cerise-project.nl/energy/def/cim-smartgrid#global_package">http://ns.cerise-project.nl/energy/def/cim-smartgrid#global_package</seealso>
    let global_package = Prefixed_Name(smg, "global_package") |> PrefixedName
