namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.NorthAmerica.USPostalServiceAddresses.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_plc_uspsa =
    let _namespace_iri = Namespace_Iri fibo_fnd_plc_uspsa |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"U.S. Postal Service Addresses Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_plc_uspsa, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:CompleteAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"complete address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/CompleteAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/CompleteAddress</seealso>
    let CompleteAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "CompleteAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:DeliveryAddressCodeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"delivery address code set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryAddressCodeSet">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryAddressCodeSet</seealso>
    let DeliveryAddressCodeSet =
        Prefixed_Name(fibo_fnd_plc_uspsa, "DeliveryAddressCodeSet") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:DeliveryPointCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"delivery point code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCode">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCode</seealso>
    let DeliveryPointCode =
        Prefixed_Name(fibo_fnd_plc_uspsa, "DeliveryPointCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:DeliveryPointCodeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"delivery point code set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCodeSet">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCodeSet</seealso>
    let DeliveryPointCodeSet =
        Prefixed_Name(fibo_fnd_plc_uspsa, "DeliveryPointCodeSet") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:DepartmentOfStateAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Department of State address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateAddress</seealso>
    let DepartmentOfStateAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "DepartmentOfStateAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:DepartmentOfStateUnitComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Department of State unit component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateUnitComponent">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateUnitComponent</seealso>
    let DepartmentOfStateUnitComponent =
        Prefixed_Name(fibo_fnd_plc_uspsa, "DepartmentOfStateUnitComponent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:East</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///
    /// labels<para>"Este"</para><para>"East"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/East">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/East</seealso>
    let East = Prefixed_Name(fibo_fnd_plc_uspsa, "East") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:GeneralDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"general delivery address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/GeneralDeliveryAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/GeneralDeliveryAddress</seealso>
    let GeneralDeliveryAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "GeneralDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:HighwayContractRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"highway contract route"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRoute">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRoute</seealso>
    let HighwayContractRoute =
        Prefixed_Name(fibo_fnd_plc_uspsa, "HighwayContractRoute") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:HighwayContractRouteAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"highway contract address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteAddress</seealso>
    let HighwayContractRouteAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "HighwayContractRouteAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:HighwayContractRouteDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SupplementalAddressDesignator</para>
    ///
    /// labels<para>"highway contract route designator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteDesignator</seealso>
    let HighwayContractRouteDesignator =
        Prefixed_Name(fibo_fnd_plc_uspsa, "HighwayContractRouteDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:InternationalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"international address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/InternationalAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/InternationalAddress</seealso>
    let InternationalAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "InternationalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:Mailbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mailbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Mailbox">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Mailbox</seealso>
    let Mailbox = Prefixed_Name(fibo_fnd_plc_uspsa, "Mailbox") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:MailboxDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SupplementalAddressDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"mailbox designator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/MailboxDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/MailboxDesignator</seealso>
    let MailboxDesignator =
        Prefixed_Name(fibo_fnd_plc_uspsa, "MailboxDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:North</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///
    /// labels<para>"North"</para><para>"Norte"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/North">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/North</seealso>
    let North = Prefixed_Name(fibo_fnd_plc_uspsa, "North") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:Northeast</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Northeast"</para><para>"Noreste"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Northeast">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Northeast</seealso>
    let Northeast = Prefixed_Name(fibo_fnd_plc_uspsa, "Northeast") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:Northwest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///
    /// labels<para>"Northwest"</para><para>"Noroeste"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Northwest">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Northwest</seealso>
    let Northwest = Prefixed_Name(fibo_fnd_plc_uspsa, "Northwest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:OverseasMilitaryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"overseas military address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/OverseasMilitaryAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/OverseasMilitaryAddress</seealso>
    let OverseasMilitaryAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "OverseasMilitaryAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:PrivateMailBoxAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private mail box address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PrivateMailBoxAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PrivateMailBoxAddress</seealso>
    let PrivateMailBoxAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "PrivateMailBoxAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:PuertoRicoAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Puerto Rico address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PuertoRicoAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PuertoRicoAddress</seealso>
    let PuertoRicoAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "PuertoRicoAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:RuralRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"highway contract route address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRoute">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRoute</seealso>
    let RuralRoute = Prefixed_Name(fibo_fnd_plc_uspsa, "RuralRoute") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:RuralRouteAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rural route address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteAddress</seealso>
    let RuralRouteAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "RuralRouteAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:RuralRouteDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SupplementalAddressDesignator</para>
    ///
    /// labels<para>"rural route designator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteDesignator</seealso>
    let RuralRouteDesignator =
        Prefixed_Name(fibo_fnd_plc_uspsa, "RuralRouteDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:South</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sur"</para><para>"South"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/South">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/South</seealso>
    let South = Prefixed_Name(fibo_fnd_plc_uspsa, "South") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:Southeast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///
    /// labels<para>"Southeast"</para><para>"Sureste"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Southeast">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Southeast</seealso>
    let Southeast = Prefixed_Name(fibo_fnd_plc_uspsa, "Southeast") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:Southwest</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Suroeste"</para><para>"Southwest"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Southwest">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Southwest</seealso>
    let Southwest = Prefixed_Name(fibo_fnd_plc_uspsa, "Southwest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:StandardizedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standardized address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/StandardizedAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/StandardizedAddress</seealso>
    let StandardizedAddress =
        Prefixed_Name(fibo_fnd_plc_uspsa, "StandardizedAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:USPostOfficeBoxDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PostOfficeBoxDesignator</para>
    ///
    /// labels<para>"post office box designator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostOfficeBoxDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostOfficeBoxDesignator</seealso>
    let USPostOfficeBoxDesignator =
        Prefixed_Name(fibo_fnd_plc_uspsa, "USPostOfficeBoxDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:USPostalServiceAddressIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"U.S. Postal Service address identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostalServiceAddressIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostalServiceAddressIdentifier</seealso>
    let USPostalServiceAddressIdentifier =
        Prefixed_Name(fibo_fnd_plc_uspsa, "USPostalServiceAddressIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:Urbanization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urbanization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Urbanization">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Urbanization</seealso>
    let Urbanization = Prefixed_Name(fibo_fnd_plc_uspsa, "Urbanization") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:West</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Oeste"</para><para>"West"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/West">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/West</seealso>
    let West = Prefixed_Name(fibo_fnd_plc_uspsa, "West") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:ZIPCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Zip Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPCode">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPCode</seealso>
    let ZIPCode = Prefixed_Name(fibo_fnd_plc_uspsa, "ZIPCode") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:ZIPPlus4Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ZIP+4 Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPPlus4Code">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPPlus4Code</seealso>
    let ZIPPlus4Code = Prefixed_Name(fibo_fnd_plc_uspsa, "ZIPPlus4Code") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:ZipCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zip code scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZipCodeScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZipCodeScheme</seealso>
    let ZipCodeScheme =
        Prefixed_Name(fibo_fnd_plc_uspsa, "ZipCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-uspsa:hasUrbanization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has urbanization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/hasUrbanization">https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/hasUrbanization</seealso>
    let hasUrbanization =
        Prefixed_Name(fibo_fnd_plc_uspsa, "hasUrbanization") |> PrefixedName
