namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.NorthAmerica.USPostalServiceAddresses.slash

open DoxAletheia

module fibo_fnd_plc_uspsa =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/East"></see>
    /// </summary>
    let East = _prefix "East"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/North"></see>
    /// </summary>
    let North = _prefix "North"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Northeast"></see>
    /// </summary>
    let Northeast = _prefix "Northeast"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Northwest"></see>
    /// </summary>
    let Northwest = _prefix "Northwest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/South"></see>
    /// </summary>
    let South = _prefix "South"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Southeast"></see>
    /// </summary>
    let Southeast = _prefix "Southeast"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Southwest"></see>
    /// </summary>
    let Southwest = _prefix "Southwest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/West"></see>
    /// </summary>
    let West = _prefix "West"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/CompleteAddress"></see>
    /// </summary>
    let CompleteAddress = _prefix "CompleteAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/StandardizedAddress"></see>
    /// </summary>
    let StandardizedAddress = _prefix "StandardizedAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryAddressCodeSet"></see>
    /// </summary>
    let DeliveryAddressCodeSet = _prefix "DeliveryAddressCodeSet"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostalServiceAddressIdentifier"></see>
    /// </summary>
    let USPostalServiceAddressIdentifier = _prefix "USPostalServiceAddressIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCode"></see>
    /// </summary>
    let DeliveryPointCode = _prefix "DeliveryPointCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCodeSet"></see>
    /// </summary>
    let DeliveryPointCodeSet = _prefix "DeliveryPointCodeSet"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateAddress"></see>
    /// </summary>
    let DepartmentOfStateAddress = _prefix "DepartmentOfStateAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateUnitComponent"></see>
    /// </summary>
    let DepartmentOfStateUnitComponent = _prefix "DepartmentOfStateUnitComponent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Mailbox"></see>
    /// </summary>
    let Mailbox = _prefix "Mailbox"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/GeneralDeliveryAddress"></see>
    /// </summary>
    let GeneralDeliveryAddress = _prefix "GeneralDeliveryAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRoute"></see>
    /// </summary>
    let HighwayContractRoute = _prefix "HighwayContractRoute"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteDesignator"></see>
    /// </summary>
    let HighwayContractRouteDesignator = _prefix "HighwayContractRouteDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteAddress"></see>
    /// </summary>
    let HighwayContractRouteAddress = _prefix "HighwayContractRouteAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/InternationalAddress"></see>
    /// </summary>
    let InternationalAddress = _prefix "InternationalAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/MailboxDesignator"></see>
    /// </summary>
    let MailboxDesignator = _prefix "MailboxDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/OverseasMilitaryAddress"></see>
    /// </summary>
    let OverseasMilitaryAddress = _prefix "OverseasMilitaryAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PrivateMailBoxAddress"></see>
    /// </summary>
    let PrivateMailBoxAddress = _prefix "PrivateMailBoxAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PuertoRicoAddress"></see>
    /// </summary>
    let PuertoRicoAddress = _prefix "PuertoRicoAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Urbanization"></see>
    /// </summary>
    let Urbanization = _prefix "Urbanization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRoute"></see>
    /// </summary>
    let RuralRoute = _prefix "RuralRoute"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteDesignator"></see>
    /// </summary>
    let RuralRouteDesignator = _prefix "RuralRouteDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteAddress"></see>
    /// </summary>
    let RuralRouteAddress = _prefix "RuralRouteAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostOfficeBoxDesignator"></see>
    /// </summary>
    let USPostOfficeBoxDesignator = _prefix "USPostOfficeBoxDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPPlus4Code"></see>
    /// </summary>
    let ZIPPlus4Code = _prefix "ZIPPlus4Code"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPCode"></see>
    /// </summary>
    let ZIPCode = _prefix "ZIPCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZipCodeScheme"></see>
    /// </summary>
    let ZipCodeScheme = _prefix "ZipCodeScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/hasUrbanization"></see>
    /// </summary>
    let hasUrbanization = _prefix "hasUrbanization"
