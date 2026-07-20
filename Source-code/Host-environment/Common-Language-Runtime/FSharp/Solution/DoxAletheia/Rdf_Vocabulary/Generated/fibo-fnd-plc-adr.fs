namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.Addresses.slash

open DoxAletheia

module fibo_fnd_plc_adr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressingScheme"></see>
    /// </summary>
    let AddressingScheme = _prefix "AddressingScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressComponent"></see>
    /// </summary>
    let AddressComponent = _prefix "AddressComponent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Apartment"></see>
    /// </summary>
    let Apartment = _prefix "Apartment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitDesignator"></see>
    /// </summary>
    let SecondaryUnitDesignator = _prefix "SecondaryUnitDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/requiresSecondaryUnitRange"></see>
    /// </summary>
    let requiresSecondaryUnitRange = _prefix "requiresSecondaryUnitRange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Basement"></see>
    /// </summary>
    let Basement = _prefix "Basement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/ConventionalStreetAddress"></see>
    /// </summary>
    let ConventionalStreetAddress = _prefix "ConventionalStreetAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddress"></see>
    /// </summary>
    let PhysicalAddress = _prefix "PhysicalAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetAddress"></see>
    /// </summary>
    let hasStreetAddress = _prefix "hasStreetAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetAddress"></see>
    /// </summary>
    let StreetAddress = _prefix "StreetAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine1"></see>
    /// </summary>
    let hasAddressLine1 = _prefix "hasAddressLine1"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine2"></see>
    /// </summary>
    let hasAddressLine2 = _prefix "hasAddressLine2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine3"></see>
    /// </summary>
    let hasAddressLine3 = _prefix "hasAddressLine3"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Floor"></see>
    /// </summary>
    let Floor = _prefix "Floor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Front"></see>
    /// </summary>
    let Front = _prefix "Front"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/GeographicDirectionalSymbol"></see>
    /// </summary>
    let GeographicDirectionalSymbol = _prefix "GeographicDirectionalSymbol"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Hangar"></see>
    /// </summary>
    let Hangar = _prefix "Hangar"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Key"></see>
    /// </summary>
    let Key = _prefix "Key"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lobby"></see>
    /// </summary>
    let Lobby = _prefix "Lobby"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lot"></see>
    /// </summary>
    let Lot = _prefix "Lot"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Lower"></see>
    /// </summary>
    let Lower = _prefix "Lower"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Office"></see>
    /// </summary>
    let Office = _prefix "Office"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Penthouse"></see>
    /// </summary>
    let Penthouse = _prefix "Penthouse"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasIndividualPostcode"></see>
    /// </summary>
    let hasIndividualPostcode = _prefix "hasIndividualPostcode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Postcode"></see>
    /// </summary>
    let Postcode = _prefix "Postcode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostalCode"></see>
    /// </summary>
    let hasPostalCode = _prefix "hasPostalCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressIdentifier"></see>
    /// </summary>
    let PhysicalAddressIdentifier = _prefix "PhysicalAddressIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressingScheme"></see>
    /// </summary>
    let PhysicalAddressingScheme = _prefix "PhysicalAddressingScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Pier"></see>
    /// </summary>
    let Pier = _prefix "Pier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostCodeArea"></see>
    /// </summary>
    let PostCodeArea = _prefix "PostCodeArea"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBox"></see>
    /// </summary>
    let PostOfficeBox = _prefix "PostOfficeBox"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressComponent"></see>
    /// </summary>
    let SupplementalAddressComponent = _prefix "SupplementalAddressComponent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxDesignator"></see>
    /// </summary>
    let PostOfficeBoxDesignator = _prefix "PostOfficeBoxDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxAddress"></see>
    /// </summary>
    let PostOfficeBoxAddress = _prefix "PostOfficeBoxAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressDesignator"></see>
    /// </summary>
    let SupplementalAddressDesignator = _prefix "SupplementalAddressDesignator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostdirectionalSymbol"></see>
    /// </summary>
    let PostdirectionalSymbol = _prefix "PostdirectionalSymbol"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PredirectionalSymbol"></see>
    /// </summary>
    let PredirectionalSymbol = _prefix "PredirectionalSymbol"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PrimaryAddressNumber"></see>
    /// </summary>
    let PrimaryAddressNumber = _prefix "PrimaryAddressNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Rear"></see>
    /// </summary>
    let Rear = _prefix "Rear"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/RegionSpecificIdentifier"></see>
    /// </summary>
    let RegionSpecificIdentifier = _prefix "RegionSpecificIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Room"></see>
    /// </summary>
    let Room = _prefix "Room"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnit"></see>
    /// </summary>
    let SecondaryUnit = _prefix "SecondaryUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitIndicator"></see>
    /// </summary>
    let SecondaryUnitIndicator = _prefix "SecondaryUnitIndicator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Side"></see>
    /// </summary>
    let Side = _prefix "Side"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Slip"></see>
    /// </summary>
    let Slip = _prefix "Slip"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Space"></see>
    /// </summary>
    let Space = _prefix "Space"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Stop"></see>
    /// </summary>
    let Stop = _prefix "Stop"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPrimaryAddressNumber"></see>
    /// </summary>
    let hasPrimaryAddressNumber = _prefix "hasPrimaryAddressNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostdirectionalSymbol"></see>
    /// </summary>
    let hasPostdirectionalSymbol = _prefix "hasPostdirectionalSymbol"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPredirectionalSymbol"></see>
    /// </summary>
    let hasPredirectionalSymbol = _prefix "hasPredirectionalSymbol"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasSecondaryUnit"></see>
    /// </summary>
    let hasSecondaryUnit = _prefix "hasSecondaryUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetSuffix"></see>
    /// </summary>
    let hasStreetSuffix = _prefix "hasStreetSuffix"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetSuffix"></see>
    /// </summary>
    let StreetSuffix = _prefix "StreetSuffix"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetName"></see>
    /// </summary>
    let hasStreetName = _prefix "hasStreetName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetName"></see>
    /// </summary>
    let StreetName = _prefix "StreetName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StructureName"></see>
    /// </summary>
    let StructureName = _prefix "StructureName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Suite"></see>
    /// </summary>
    let Suite = _prefix "Suite"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressUnit"></see>
    /// </summary>
    let SupplementalAddressUnit = _prefix "SupplementalAddressUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Trailer"></see>
    /// </summary>
    let Trailer = _prefix "Trailer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Unit"></see>
    /// </summary>
    let Unit = _prefix "Unit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Upper"></see>
    /// </summary>
    let Upper = _prefix "Upper"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/VirtualAddress"></see>
    /// </summary>
    let VirtualAddress = _prefix "VirtualAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAttentionLine"></see>
    /// </summary>
    let hasAttentionLine = _prefix "hasAttentionLine"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMailRouting"></see>
    /// </summary>
    let hasMailRouting = _prefix "hasMailRouting"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStructureName"></see>
    /// </summary>
    let hasStructureName = _prefix "hasStructureName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasTransliteratedAddress"></see>
    /// </summary>
    let hasTransliteratedAddress = _prefix "hasTransliteratedAddress"
