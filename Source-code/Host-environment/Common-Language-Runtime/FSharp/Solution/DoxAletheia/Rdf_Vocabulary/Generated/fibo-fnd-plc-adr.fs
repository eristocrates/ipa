namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.Addresses.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_plc_adr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Address"></see>
    /// </summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressingScheme"></see>
    /// </summary>
    let AddressingScheme =
        Namespaced_IRI.parse _namespace_name "AddressingScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressComponent"></see>
    /// </summary>
    let AddressComponent =
        Namespaced_IRI.parse _namespace_name "AddressComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Apartment"></see>
    /// </summary>
    let Apartment = Namespaced_IRI.parse _namespace_name "Apartment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitDesignator"></see>
    /// </summary>
    let SecondaryUnitDesignator =
        Namespaced_IRI.parse _namespace_name "SecondaryUnitDesignator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/requiresSecondaryUnitRange"></see>
    /// </summary>
    let requiresSecondaryUnitRange =
        Namespaced_IRI.parse _namespace_name "requiresSecondaryUnitRange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Basement"></see>
    /// </summary>
    let Basement = Namespaced_IRI.parse _namespace_name "Basement" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/ConventionalStreetAddress"></see>
    /// </summary>
    let ConventionalStreetAddress =
        Namespaced_IRI.parse _namespace_name "ConventionalStreetAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddress"></see>
    /// </summary>
    let PhysicalAddress =
        Namespaced_IRI.parse _namespace_name "PhysicalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetAddress"></see>
    /// </summary>
    let hasStreetAddress =
        Namespaced_IRI.parse _namespace_name "hasStreetAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetAddress"></see>
    /// </summary>
    let StreetAddress =
        Namespaced_IRI.parse _namespace_name "StreetAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine1"></see>
    /// </summary>
    let hasAddressLine1 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine1" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine2"></see>
    /// </summary>
    let hasAddressLine2 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine2" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine3"></see>
    /// </summary>
    let hasAddressLine3 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine3" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Floor"></see>
    /// </summary>
    let Floor = Namespaced_IRI.parse _namespace_name "Floor" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Front"></see>
    /// </summary>
    let Front = Namespaced_IRI.parse _namespace_name "Front" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/GeographicDirectionalSymbol"></see>
    /// </summary>
    let GeographicDirectionalSymbol =
        Namespaced_IRI.parse _namespace_name "GeographicDirectionalSymbol" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Hangar"></see>
    /// </summary>
    let Hangar = Namespaced_IRI.parse _namespace_name "Hangar" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Key"></see>
    /// </summary>
    let Key = Namespaced_IRI.parse _namespace_name "Key" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lobby"></see>
    /// </summary>
    let Lobby = Namespaced_IRI.parse _namespace_name "Lobby" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lot"></see>
    /// </summary>
    let Lot = Namespaced_IRI.parse _namespace_name "Lot" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lower"></see>
    /// </summary>
    let Lower = Namespaced_IRI.parse _namespace_name "Lower" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Office"></see>
    /// </summary>
    let Office = Namespaced_IRI.parse _namespace_name "Office" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Penthouse"></see>
    /// </summary>
    let Penthouse = Namespaced_IRI.parse _namespace_name "Penthouse" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasIndividualPostcode"></see>
    /// </summary>
    let hasIndividualPostcode =
        Namespaced_IRI.parse _namespace_name "hasIndividualPostcode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Postcode"></see>
    /// </summary>
    let Postcode = Namespaced_IRI.parse _namespace_name "Postcode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostalCode"></see>
    /// </summary>
    let hasPostalCode =
        Namespaced_IRI.parse _namespace_name "hasPostalCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressIdentifier"></see>
    /// </summary>
    let PhysicalAddressIdentifier =
        Namespaced_IRI.parse _namespace_name "PhysicalAddressIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressingScheme"></see>
    /// </summary>
    let PhysicalAddressingScheme =
        Namespaced_IRI.parse _namespace_name "PhysicalAddressingScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Pier"></see>
    /// </summary>
    let Pier = Namespaced_IRI.parse _namespace_name "Pier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostCodeArea"></see>
    /// </summary>
    let PostCodeArea =
        Namespaced_IRI.parse _namespace_name "PostCodeArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBox"></see>
    /// </summary>
    let PostOfficeBox =
        Namespaced_IRI.parse _namespace_name "PostOfficeBox" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressComponent"></see>
    /// </summary>
    let SupplementalAddressComponent =
        Namespaced_IRI.parse _namespace_name "SupplementalAddressComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxDesignator"></see>
    /// </summary>
    let PostOfficeBoxDesignator =
        Namespaced_IRI.parse _namespace_name "PostOfficeBoxDesignator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxAddress"></see>
    /// </summary>
    let PostOfficeBoxAddress =
        Namespaced_IRI.parse _namespace_name "PostOfficeBoxAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressDesignator"></see>
    /// </summary>
    let SupplementalAddressDesignator =
        Namespaced_IRI.parse _namespace_name "SupplementalAddressDesignator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostdirectionalSymbol"></see>
    /// </summary>
    let PostdirectionalSymbol =
        Namespaced_IRI.parse _namespace_name "PostdirectionalSymbol" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PredirectionalSymbol"></see>
    /// </summary>
    let PredirectionalSymbol =
        Namespaced_IRI.parse _namespace_name "PredirectionalSymbol" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PrimaryAddressNumber"></see>
    /// </summary>
    let PrimaryAddressNumber =
        Namespaced_IRI.parse _namespace_name "PrimaryAddressNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Rear"></see>
    /// </summary>
    let Rear = Namespaced_IRI.parse _namespace_name "Rear" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/RegionSpecificIdentifier"></see>
    /// </summary>
    let RegionSpecificIdentifier =
        Namespaced_IRI.parse _namespace_name "RegionSpecificIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Room"></see>
    /// </summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnit"></see>
    /// </summary>
    let SecondaryUnit =
        Namespaced_IRI.parse _namespace_name "SecondaryUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitIndicator"></see>
    /// </summary>
    let SecondaryUnitIndicator =
        Namespaced_IRI.parse _namespace_name "SecondaryUnitIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Side"></see>
    /// </summary>
    let Side = Namespaced_IRI.parse _namespace_name "Side" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Slip"></see>
    /// </summary>
    let Slip = Namespaced_IRI.parse _namespace_name "Slip" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Space"></see>
    /// </summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Stop"></see>
    /// </summary>
    let Stop = Namespaced_IRI.parse _namespace_name "Stop" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPrimaryAddressNumber"></see>
    /// </summary>
    let hasPrimaryAddressNumber =
        Namespaced_IRI.parse _namespace_name "hasPrimaryAddressNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostdirectionalSymbol"></see>
    /// </summary>
    let hasPostdirectionalSymbol =
        Namespaced_IRI.parse _namespace_name "hasPostdirectionalSymbol" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPredirectionalSymbol"></see>
    /// </summary>
    let hasPredirectionalSymbol =
        Namespaced_IRI.parse _namespace_name "hasPredirectionalSymbol" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasSecondaryUnit"></see>
    /// </summary>
    let hasSecondaryUnit =
        Namespaced_IRI.parse _namespace_name "hasSecondaryUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetSuffix"></see>
    /// </summary>
    let hasStreetSuffix =
        Namespaced_IRI.parse _namespace_name "hasStreetSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetSuffix"></see>
    /// </summary>
    let StreetSuffix =
        Namespaced_IRI.parse _namespace_name "StreetSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetName"></see>
    /// </summary>
    let hasStreetName =
        Namespaced_IRI.parse _namespace_name "hasStreetName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetName"></see>
    /// </summary>
    let StreetName = Namespaced_IRI.parse _namespace_name "StreetName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StructureName"></see>
    /// </summary>
    let StructureName =
        Namespaced_IRI.parse _namespace_name "StructureName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Suite"></see>
    /// </summary>
    let Suite = Namespaced_IRI.parse _namespace_name "Suite" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressUnit"></see>
    /// </summary>
    let SupplementalAddressUnit =
        Namespaced_IRI.parse _namespace_name "SupplementalAddressUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Trailer"></see>
    /// </summary>
    let Trailer = Namespaced_IRI.parse _namespace_name "Trailer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Unit"></see>
    /// </summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Upper"></see>
    /// </summary>
    let Upper = Namespaced_IRI.parse _namespace_name "Upper" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/VirtualAddress"></see>
    /// </summary>
    let VirtualAddress =
        Namespaced_IRI.parse _namespace_name "VirtualAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAttentionLine"></see>
    /// </summary>
    let hasAttentionLine =
        Namespaced_IRI.parse _namespace_name "hasAttentionLine" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMailRouting"></see>
    /// </summary>
    let hasMailRouting =
        Namespaced_IRI.parse _namespace_name "hasMailRouting" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStructureName"></see>
    /// </summary>
    let hasStructureName =
        Namespaced_IRI.parse _namespace_name "hasStructureName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasTransliteratedAddress"></see>
    /// </summary>
    let hasTransliteratedAddress =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedAddress" |> NamespacedName
