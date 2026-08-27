namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.Addresses.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_plc_adr =
    let _namespace_iri = Namespace_Iri fibo_fnd_plc_adr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Addresses Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_plc_adr, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"address"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Address">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Address</seealso>
    let Address = Prefixed_Name(fibo_fnd_plc_adr, "Address") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:AddressComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"address component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressComponent">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressComponent</seealso>
    let AddressComponent =
        Prefixed_Name(fibo_fnd_plc_adr, "AddressComponent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:AddressingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"addressing scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressingScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressingScheme</seealso>
    let AddressingScheme =
        Prefixed_Name(fibo_fnd_plc_adr, "AddressingScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Apartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"apartmento"</para><para>"apartment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Apartment">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Apartment</seealso>
    let Apartment = Prefixed_Name(fibo_fnd_plc_adr, "Apartment") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Basement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"basement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Basement">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Basement</seealso>
    let Basement = Prefixed_Name(fibo_fnd_plc_adr, "Basement") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"building"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Building">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Building</seealso>
    let Building = Prefixed_Name(fibo_fnd_plc_adr, "Building") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conventional street address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/ConventionalStreetAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/ConventionalStreetAddress</seealso>
    let ConventionalStreetAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "ConventionalStreetAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"departamento"</para><para>"department"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Department">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Department</seealso>
    let Department = Prefixed_Name(fibo_fnd_plc_adr, "Department") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"floor"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Floor">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Floor</seealso>
    let Floor = Prefixed_Name(fibo_fnd_plc_adr, "Floor") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Front</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"front"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Front">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Front</seealso>
    let Front = Prefixed_Name(fibo_fnd_plc_adr, "Front") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:GeographicDirectionalSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geographic directional symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/GeographicDirectionalSymbol">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/GeographicDirectionalSymbol</seealso>
    let GeographicDirectionalSymbol =
        Prefixed_Name(fibo_fnd_plc_adr, "GeographicDirectionalSymbol") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Hangar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"hanger"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Hangar">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Hangar</seealso>
    let Hangar = Prefixed_Name(fibo_fnd_plc_adr, "Hangar") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Key</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"key"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Key">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Key</seealso>
    let Key = Prefixed_Name(fibo_fnd_plc_adr, "Key") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Lobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"lobby"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lobby">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lobby</seealso>
    let Lobby = Prefixed_Name(fibo_fnd_plc_adr, "Lobby") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"lot"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lot">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lot</seealso>
    let Lot = Prefixed_Name(fibo_fnd_plc_adr, "Lot") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Lower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"lower"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lower">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lower</seealso>
    let Lower = Prefixed_Name(fibo_fnd_plc_adr, "Lower") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Office</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"office"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Office">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Office</seealso>
    let Office = Prefixed_Name(fibo_fnd_plc_adr, "Office") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Penthouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"penthouse"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Penthouse">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Penthouse</seealso>
    let Penthouse = Prefixed_Name(fibo_fnd_plc_adr, "Penthouse") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical address"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddress</seealso>
    let PhysicalAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "PhysicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddressIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical address identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressIdentifier</seealso>
    let PhysicalAddressIdentifier =
        Prefixed_Name(fibo_fnd_plc_adr, "PhysicalAddressIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddressingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical addressing scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressingScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressingScheme</seealso>
    let PhysicalAddressingScheme =
        Prefixed_Name(fibo_fnd_plc_adr, "PhysicalAddressingScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Pier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Pier">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Pier</seealso>
    let Pier = Prefixed_Name(fibo_fnd_plc_adr, "Pier") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PostCodeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"post code area"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostCodeArea">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostCodeArea</seealso>
    let PostCodeArea = Prefixed_Name(fibo_fnd_plc_adr, "PostCodeArea") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PostOfficeBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"post office box"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBox">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBox</seealso>
    let PostOfficeBox = Prefixed_Name(fibo_fnd_plc_adr, "PostOfficeBox") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PostOfficeBoxAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"post office box address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxAddress</seealso>
    let PostOfficeBoxAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "PostOfficeBoxAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PostOfficeBoxDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"post office box designator"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxDesignator</seealso>
    let PostOfficeBoxDesignator =
        Prefixed_Name(fibo_fnd_plc_adr, "PostOfficeBoxDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostalAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(fibo_fnd_plc_adr, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Postcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"postcode"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Postcode">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Postcode</seealso>
    let Postcode = Prefixed_Name(fibo_fnd_plc_adr, "Postcode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PostdirectionalSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"postdirectional symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostdirectionalSymbol">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostdirectionalSymbol</seealso>
    let PostdirectionalSymbol =
        Prefixed_Name(fibo_fnd_plc_adr, "PostdirectionalSymbol") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PredirectionalSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"predirectional symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PredirectionalSymbol">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PredirectionalSymbol</seealso>
    let PredirectionalSymbol =
        Prefixed_Name(fibo_fnd_plc_adr, "PredirectionalSymbol") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:PrimaryAddressNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary address number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PrimaryAddressNumber">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PrimaryAddressNumber</seealso>
    let PrimaryAddressNumber =
        Prefixed_Name(fibo_fnd_plc_adr, "PrimaryAddressNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Rear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"rear"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Rear">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Rear</seealso>
    let Rear = Prefixed_Name(fibo_fnd_plc_adr, "Rear") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:RegionSpecificIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"region-specific identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/RegionSpecificIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/RegionSpecificIdentifier</seealso>
    let RegionSpecificIdentifier =
        Prefixed_Name(fibo_fnd_plc_adr, "RegionSpecificIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"room"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Room">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Room</seealso>
    let Room = Prefixed_Name(fibo_fnd_plc_adr, "Room") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnit">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnit</seealso>
    let SecondaryUnit = Prefixed_Name(fibo_fnd_plc_adr, "SecondaryUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary unit designator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitDesignator</seealso>
    let SecondaryUnitDesignator =
        Prefixed_Name(fibo_fnd_plc_adr, "SecondaryUnitDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secondary unit indicator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitIndicator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitIndicator</seealso>
    let SecondaryUnitIndicator =
        Prefixed_Name(fibo_fnd_plc_adr, "SecondaryUnitIndicator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Side</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"side"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Side">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Side</seealso>
    let Side = Prefixed_Name(fibo_fnd_plc_adr, "Side") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Slip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"slip"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Slip">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Slip</seealso>
    let Slip = Prefixed_Name(fibo_fnd_plc_adr, "Slip") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"space"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Space">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Space</seealso>
    let Space = Prefixed_Name(fibo_fnd_plc_adr, "Space") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"stop"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Stop">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Stop</seealso>
    let Stop = Prefixed_Name(fibo_fnd_plc_adr, "Stop") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:StreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"street address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetAddress</seealso>
    let StreetAddress = Prefixed_Name(fibo_fnd_plc_adr, "StreetAddress") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:StreetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"street name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetName">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetName</seealso>
    let StreetName = Prefixed_Name(fibo_fnd_plc_adr, "StreetName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:StreetSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"street suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetSuffix">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetSuffix</seealso>
    let StreetSuffix = Prefixed_Name(fibo_fnd_plc_adr, "StreetSuffix") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:StructureName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structure name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StructureName">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StructureName</seealso>
    let StructureName = Prefixed_Name(fibo_fnd_plc_adr, "StructureName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Suite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"suite"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Suite">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Suite</seealso>
    let Suite = Prefixed_Name(fibo_fnd_plc_adr, "Suite") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:SupplementalAddressComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supplemental address component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressComponent">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressComponent</seealso>
    let SupplementalAddressComponent =
        Prefixed_Name(fibo_fnd_plc_adr, "SupplementalAddressComponent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:SupplementalAddressDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supplemental address designator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressDesignator">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressDesignator</seealso>
    let SupplementalAddressDesignator =
        Prefixed_Name(fibo_fnd_plc_adr, "SupplementalAddressDesignator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:SupplementalAddressUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supplemental address unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressUnit">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressUnit</seealso>
    let SupplementalAddressUnit =
        Prefixed_Name(fibo_fnd_plc_adr, "SupplementalAddressUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Trailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"trailer"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Trailer">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Trailer</seealso>
    let Trailer = Prefixed_Name(fibo_fnd_plc_adr, "Trailer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"unit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Unit">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Unit</seealso>
    let Unit = Prefixed_Name(fibo_fnd_plc_adr, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-adr:Upper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:SecondaryUnitDesignator</para>
    ///
    /// labels<para>"upper"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Upper">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Upper</seealso>
    let Upper = Prefixed_Name(fibo_fnd_plc_adr, "Upper") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:VirtualAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"virtual address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/VirtualAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/VirtualAddress</seealso>
    let VirtualAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "VirtualAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddress</seealso>
    let hasAddress = Prefixed_Name(fibo_fnd_plc_adr, "hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasAddressLine1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine1">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine1</seealso>
    let hasAddressLine1 =
        Prefixed_Name(fibo_fnd_plc_adr, "hasAddressLine1") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasAddressLine2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine2">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine2</seealso>
    let hasAddressLine2 =
        Prefixed_Name(fibo_fnd_plc_adr, "hasAddressLine2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasAddressLine3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine3">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine3</seealso>
    let hasAddressLine3 =
        Prefixed_Name(fibo_fnd_plc_adr, "hasAddressLine3") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasAttentionLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has attention line"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAttentionLine">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAttentionLine</seealso>
    let hasAttentionLine =
        Prefixed_Name(fibo_fnd_plc_adr, "hasAttentionLine") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasCountrySubdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasCountrySubdivision">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasCountrySubdivision</seealso>
    let hasCountrySubdivision =
        Prefixed_Name(fibo_fnd_plc_adr, "hasCountrySubdivision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasIndividualPostcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has individual postcode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasIndividualPostcode">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasIndividualPostcode</seealso>
    let hasIndividualPostcode =
        Prefixed_Name(fibo_fnd_plc_adr, "hasIndividualPostcode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasMailRouting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has mail routing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMailRouting">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMailRouting</seealso>
    let hasMailRouting =
        Prefixed_Name(fibo_fnd_plc_adr, "hasMailRouting") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMunicipality">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMunicipality</seealso>
    let hasMunicipality =
        Prefixed_Name(fibo_fnd_plc_adr, "hasMunicipality") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has postal code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostalCode">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostalCode</seealso>
    let hasPostalCode = Prefixed_Name(fibo_fnd_plc_adr, "hasPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasPostdirectionalSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has postdirectional symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostdirectionalSymbol">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostdirectionalSymbol</seealso>
    let hasPostdirectionalSymbol =
        Prefixed_Name(fibo_fnd_plc_adr, "hasPostdirectionalSymbol") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasPredirectionalSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has predirectional symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPredirectionalSymbol">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPredirectionalSymbol</seealso>
    let hasPredirectionalSymbol =
        Prefixed_Name(fibo_fnd_plc_adr, "hasPredirectionalSymbol") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasPrimaryAddressNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has primary address number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPrimaryAddressNumber">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPrimaryAddressNumber</seealso>
    let hasPrimaryAddressNumber =
        Prefixed_Name(fibo_fnd_plc_adr, "hasPrimaryAddressNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasRegisteredAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasRegisteredAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasRegisteredAddress</seealso>
    let hasRegisteredAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "hasRegisteredAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasSecondaryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has secondary unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasSecondaryUnit">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasSecondaryUnit</seealso>
    let hasSecondaryUnit =
        Prefixed_Name(fibo_fnd_plc_adr, "hasSecondaryUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasStreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has street address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetAddress</seealso>
    let hasStreetAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "hasStreetAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasStreetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has street name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetName">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetName</seealso>
    let hasStreetName = Prefixed_Name(fibo_fnd_plc_adr, "hasStreetName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasStreetSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has street suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetSuffix">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetSuffix</seealso>
    let hasStreetSuffix =
        Prefixed_Name(fibo_fnd_plc_adr, "hasStreetSuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasStructureName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has structure name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStructureName">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStructureName</seealso>
    let hasStructureName =
        Prefixed_Name(fibo_fnd_plc_adr, "hasStructureName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:hasTransliteratedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has transliterated address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasTransliteratedAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasTransliteratedAddress</seealso>
    let hasTransliteratedAddress =
        Prefixed_Name(fibo_fnd_plc_adr, "hasTransliteratedAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-adr:requiresSecondaryUnitRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"requires secondary unit range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/requiresSecondaryUnitRange">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/requiresSecondaryUnitRange</seealso>
    let requiresSecondaryUnitRange =
        Prefixed_Name(fibo_fnd_plc_adr, "requiresSecondaryUnitRange") |> PrefixedName
