#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-plc-adr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/" "fibo-fnd-plc-adr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : address</para>
    ///   <para>skos:definition : index to a location to which communications may be delivered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Address">fibo-fnd-plc-adr:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:label : address component^^xsd:string</para>
    ///   <para>skos:definition : aspect of an address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressComponent">fibo-fnd-plc-adr:AddressComponent</a>
    /// </summary>
    let AddressComponent = _prefixId.prefix "AddressComponent"
    /// <summary>
    ///   <para>rdfs:label : addressing scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating addresses to objects^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/AddressingScheme">fibo-fnd-plc-adr:AddressingScheme</a>
    /// </summary>
    let AddressingScheme = _prefixId.prefix "AddressingScheme"
    let Apartment = _prefixId.prefix "Apartment"
    let Basement = _prefixId.prefix "Basement"
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : conventional street address^^xsd:string</para>
    ///   <para>skos:definition : physical address that identifies a location on a street to which communications may be delivered^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Other unconventional addresses may include rural and highway route addresses, general delivery addresses, post office box addresses, private mail center addresses, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/ConventionalStreetAddress">fibo-fnd-plc-adr:ConventionalStreetAddress</a>
    /// </summary>
    let ConventionalStreetAddress = _prefixId.prefix "ConventionalStreetAddress"
    let Department = _prefixId.prefix "Department"
    let Floor = _prefixId.prefix "Floor"
    let Front = _prefixId.prefix "Front"
    /// <summary>
    ///   <para>rdfs:label : geographic directional symbol^^xsd:string</para>
    ///   <para>skos:definition : code element that gives directional information for postal delivery^^xsd:string</para>
    ///   <para>skos:example : In the United States, these include N, S, E, W, NE, NW, SE, SW.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/GeographicDirectionalSymbol">fibo-fnd-plc-adr:GeographicDirectionalSymbol</a>
    /// </summary>
    let GeographicDirectionalSymbol = _prefixId.prefix "GeographicDirectionalSymbol"
    let Hangar = _prefixId.prefix "Hangar"
    let Key = _prefixId.prefix "Key"
    let Lobby = _prefixId.prefix "Lobby"
    let Lot = _prefixId.prefix "Lot"
    let Lower = _prefixId.prefix "Lower"
    let Office = _prefixId.prefix "Office"
    let Penthouse = _prefixId.prefix "Penthouse"
    /// <summary>
    ///   <para>rdfs:label : physical address</para>
    ///   <para>skos:definition : physical address where communications can be addressed, papers served or representatives located for any kind of organization or person^^xsd:string</para>
    ///   <para>skos:scopeNote : An address may be used as an index to the location of a building, apartment, office within an office block, or other structure or parcel of land, often using political boundaries and street names as references, along with other information such as house or building numbers or names. Some addresses also contain secondary elements such as apartment or building numbers, or special codes to aid routing of mail and packages.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Typically, addresses will have only one postcode expressed either as a string value or individual, and only a municipality (individual) or city (string value).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddress">fibo-fnd-plc-adr:PhysicalAddress</a>
    /// </summary>
    let PhysicalAddress = _prefixId.prefix "PhysicalAddress"
    /// <summary>
    ///   <para>rdfs:label : physical address identifier^^xsd:string</para>
    ///   <para>skos:definition : unique identifier for a physical address^^xsd:string</para>
    ///   <para>skos:example : Physical address identifiers may include bar codes, QCR codes, and +codes in a number of countries.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressIdentifier">fibo-fnd-plc-adr:PhysicalAddressIdentifier</a>
    /// </summary>
    let PhysicalAddressIdentifier = _prefixId.prefix "PhysicalAddressIdentifier"
    /// <summary>
    ///   <para>rdfs:label : physical addressing scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme for specifying physical addresses according to a country specific standard^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PhysicalAddressingScheme">fibo-fnd-plc-adr:PhysicalAddressingScheme</a>
    /// </summary>
    let PhysicalAddressingScheme = _prefixId.prefix "PhysicalAddressingScheme"
    let Pier = _prefixId.prefix "Pier"
    /// <summary>
    ///   <para>rdfs:label : post code area</para>
    ///   <para>skos:definition : physical area uniquely identified by some postal code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostCodeArea">fibo-fnd-plc-adr:PostCodeArea</a>
    /// </summary>
    let PostCodeArea = _prefixId.prefix "PostCodeArea"
    /// <summary>
    ///   <para>rdfs:label : post office box^^xsd:string</para>
    ///   <para>skos:definition : post office box associated with an address^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Post office box identifiers are only unique to a given jurisdiction, which may be a post office, town, or other region.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBox">fibo-fnd-plc-adr:PostOfficeBox</a>
    /// </summary>
    let PostOfficeBox = _prefixId.prefix "PostOfficeBox"
    /// <summary>
    ///   <para>rdfs:label : post office box address^^xsd:string</para>
    ///   <para>skos:definition : physical address used to deliver communications to a designated container at a local post office or the local equivalent for the jurisdiction, where mail is held until the recipient collects it, rather than to a given house, building, or other location^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxAddress">fibo-fnd-plc-adr:PostOfficeBoxAddress</a>
    /// </summary>
    let PostOfficeBoxAddress = _prefixId.prefix "PostOfficeBoxAddress"
    /// <summary>
    ///   <para>rdfs:label : post office box designator</para>
    ///   <para>skos:definition : designator used, together with an identifier, for a post office box^^xsd:string</para>
    ///   <para>skos:example : In the U.S., the preferred designator is 'PO BOX'.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostOfficeBoxDesignator">fibo-fnd-plc-adr:PostOfficeBoxDesignator</a>
    /// </summary>
    let PostOfficeBoxDesignator = _prefixId.prefix "PostOfficeBoxDesignator"
    /// <summary>
    ///   <para>rdfs:label : postcode</para>
    ///   <para>skos:definition : sequence of characters used to assist in the sorting of mail^^xsd:string</para>
    ///   <para>cmns-av:synonym : postal code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/Postcode">fibo-fnd-plc-adr:Postcode</a>
    /// </summary>
    let Postcode = _prefixId.prefix "Postcode"
    /// <summary>
    ///   <para>rdfs:label : postdirectional symbol^^xsd:string</para>
    ///   <para>skos:definition : geographic directional symbol that follows the street name and street suffix in a street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PostdirectionalSymbol">fibo-fnd-plc-adr:PostdirectionalSymbol</a>
    /// </summary>
    let PostdirectionalSymbol = _prefixId.prefix "PostdirectionalSymbol"
    /// <summary>
    ///   <para>rdfs:label : predirectional symbol^^xsd:string</para>
    ///   <para>skos:definition : geographic directional symbol that occurs after the primary street number but before the street name in a street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PredirectionalSymbol">fibo-fnd-plc-adr:PredirectionalSymbol</a>
    /// </summary>
    let PredirectionalSymbol = _prefixId.prefix "PredirectionalSymbol"
    /// <summary>
    ///   <para>rdfs:label : primary address number^^xsd:string</para>
    ///   <para>skos:definition : address component that identifies a location with respect to a given street^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Although traditionally called a 'number', the street number may consist of alphanumeric characters, for example, '221B'.^^xsd:string</para>
    ///   <para>cmns-av:synonym : street number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/PrimaryAddressNumber">fibo-fnd-plc-adr:PrimaryAddressNumber</a>
    /// </summary>
    let PrimaryAddressNumber = _prefixId.prefix "PrimaryAddressNumber"
    let Rear = _prefixId.prefix "Rear"
    /// <summary>
    ///   <para>rdfs:label : region-specific identifier^^xsd:string</para>
    ///   <para>skos:definition : geographic region or subdivision identifier used internally by a country or other region^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/RegionSpecificIdentifier">fibo-fnd-plc-adr:RegionSpecificIdentifier</a>
    /// </summary>
    let RegionSpecificIdentifier = _prefixId.prefix "RegionSpecificIdentifier"
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:label : secondary unit^^xsd:string</para>
    ///   <para>skos:definition : address component that identifies an individual unit within a larger structure, such as an apartment, office, hangar, slip, mailbox, and so forth, at a given street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnit">fibo-fnd-plc-adr:SecondaryUnit</a>
    /// </summary>
    let SecondaryUnit = _prefixId.prefix "SecondaryUnit"
    /// <summary>
    ///   <para>rdfs:label : secondary unit designator^^xsd:string</para>
    ///   <para>skos:definition : classifier for a smaller structure or component within a larger facility, such as an apartment, office, mail stop, or other similar designation^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that only certain secondary units require a secondary range, such as an apartment number, to complete a delivery point.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitDesignator">fibo-fnd-plc-adr:SecondaryUnitDesignator</a>
    /// </summary>
    let SecondaryUnitDesignator = _prefixId.prefix "SecondaryUnitDesignator"
    /// <summary>
    ///   <para>rdfs:label : secondary unit indicator^^xsd:string</para>
    ///   <para>skos:definition : index to the specific unit within a secondary unit, such as a building or apartment, at a particular street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SecondaryUnitIndicator">fibo-fnd-plc-adr:SecondaryUnitIndicator</a>
    /// </summary>
    let SecondaryUnitIndicator = _prefixId.prefix "SecondaryUnitIndicator"
    let Side = _prefixId.prefix "Side"
    let Slip = _prefixId.prefix "Slip"
    let Space = _prefixId.prefix "Space"
    let Stop = _prefixId.prefix "Stop"
    /// <summary>
    ///   <para>rdfs:label : street address^^xsd:string</para>
    ///   <para>skos:definition : index to a location that consists of a primary address number, predirectional, street name, suffix, postdirectional, and an optional secondary unit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetAddress">fibo-fnd-plc-adr:StreetAddress</a>
    /// </summary>
    let StreetAddress = _prefixId.prefix "StreetAddress"
    /// <summary>
    ///   <para>rdfs:label : street name^^xsd:string</para>
    ///   <para>skos:definition : identifier for a street in some context (e.g., city, municipality, geographic region)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetName">fibo-fnd-plc-adr:StreetName</a>
    /// </summary>
    let StreetName = _prefixId.prefix "StreetName"
    /// <summary>
    ///   <para>rdfs:label : street suffix^^xsd:string</para>
    ///   <para>skos:definition : classifier for a street or other delivery location, such as a dwelling located along a waterway^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The suffix may provide some insight into the size or length of the street, though not necessarily consistently. In some cities, the suffix differentiates the street from another in the same context, such as 19th Street vs. 19th Avenue in San Francisco.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StreetSuffix">fibo-fnd-plc-adr:StreetSuffix</a>
    /// </summary>
    let StreetSuffix = _prefixId.prefix "StreetSuffix"
    /// <summary>
    ///   <para>rdfs:label : structure name^^xsd:string</para>
    ///   <para>skos:definition : name for a building, house, office complex, shopping center, or other structure or group of structures^^xsd:string</para>
    ///   <para>skos:example : Examples include 'McCoy Center', which is the name of the office complex where JPMorgan Chase's Polaris facility is located, 'Apple Park', which is the name of the corporate headquarters of Apple, Inc., and 'Howells Bridge Cottage', which is the name of a very old cottage in Cornwall.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/StructureName">fibo-fnd-plc-adr:StructureName</a>
    /// </summary>
    let StructureName = _prefixId.prefix "StructureName"
    let Suite = _prefixId.prefix "Suite"
    /// <summary>
    ///   <para>rdfs:label : supplemental address component^^xsd:string</para>
    ///   <para>skos:definition : address component that provides additional information that is important to ensuring proper delivery of communications^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Supplemental components include post office box information, rural route and highway contract route information, private mailboxes, and so forth, that are not part of a conventional street address.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressComponent">fibo-fnd-plc-adr:SupplementalAddressComponent</a>
    /// </summary>
    let SupplementalAddressComponent = _prefixId.prefix "SupplementalAddressComponent"
    /// <summary>
    ///   <para>rdfs:label : supplemental address designator^^xsd:string</para>
    ///   <para>skos:definition : classifier for supplemental address information, such as a highway contract route, rural route, building complex, shopping center, condominium complex, mail box, or other similar designation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressDesignator">fibo-fnd-plc-adr:SupplementalAddressDesignator</a>
    /// </summary>
    let SupplementalAddressDesignator = _prefixId.prefix "SupplementalAddressDesignator"
    /// <summary>
    ///   <para>rdfs:label : supplemental address unit^^xsd:string</para>
    ///   <para>skos:definition : address component that includes a specific route, box, apartment, condominium or other indicator or unit associated with a specific address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/SupplementalAddressUnit">fibo-fnd-plc-adr:SupplementalAddressUnit</a>
    /// </summary>
    let SupplementalAddressUnit = _prefixId.prefix "SupplementalAddressUnit"
    let Trailer = _prefixId.prefix "Trailer"
    let Unit = _prefixId.prefix "Unit"
    let Upper = _prefixId.prefix "Upper"
    /// <summary>
    ///   <para>rdfs:label : virtual address^^xsd:string</para>
    ///   <para>skos:definition : address identifying a virtual, i.e. non-physical, location^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/VirtualAddress">fibo-fnd-plc-adr:VirtualAddress</a>
    /// </summary>
    let VirtualAddress = _prefixId.prefix "VirtualAddress"
    /// <summary>
    ///   <para>rdfs:label : has address^^xsd:string</para>
    ///   <para>skos:definition : indicates a means by which something (in the case of a network address) or some entity may be located or contacted or may receive correspondence^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddress">fibo-fnd-plc-adr:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : has address line 1^^xsd:string</para>
    ///   <para>skos:definition : the first line of the street address^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine1">fibo-fnd-plc-adr:hasAddressLine1</a>
    /// </summary>
    let hasAddressLine1 = _prefixId.prefix "hasAddressLine1"
    /// <summary>
    ///   <para>rdfs:label : has address line 2^^xsd:string</para>
    ///   <para>skos:definition : the second line of the street address^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine2">fibo-fnd-plc-adr:hasAddressLine2</a>
    /// </summary>
    let hasAddressLine2 = _prefixId.prefix "hasAddressLine2"
    /// <summary>
    ///   <para>rdfs:label : has address line 3^^xsd:string</para>
    ///   <para>skos:definition : the third line of the street address^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <para>cmns-av:usageNote : This element SHALL be omitted if address line 2 is omitted.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAddressLine3">fibo-fnd-plc-adr:hasAddressLine3</a>
    /// </summary>
    let hasAddressLine3 = _prefixId.prefix "hasAddressLine3"
    /// <summary>
    ///   <para>rdfs:label : has attention line^^xsd:string</para>
    ///   <para>skos:definition : an optional, free text address line denoting the intended recipient^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasAttentionLine">fibo-fnd-plc-adr:hasAttentionLine</a>
    /// </summary>
    let hasAttentionLine = _prefixId.prefix "hasAttentionLine"
    /// <summary>
    ///   <para>rdfs:label : has individual postcode^^xsd:string</para>
    ///   <para>skos:definition : indicates the local or international postcode element of a delivery address as specified by the local postal service^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasIndividualPostcode">fibo-fnd-plc-adr:hasIndividualPostcode</a>
    /// </summary>
    let hasIndividualPostcode = _prefixId.prefix "hasIndividualPostcode"
    /// <summary>
    ///   <para>rdfs:label : has mail routing^^xsd:string</para>
    ///   <para>skos:definition : an optional, free text address line containing explicit routing information (this elements's presence indicates that this address is a routing / 'care of' address)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasMailRouting">fibo-fnd-plc-adr:hasMailRouting</a>
    /// </summary>
    let hasMailRouting = _prefixId.prefix "hasMailRouting"
    /// <summary>
    ///   <para>rdfs:label : has postal code^^xsd:string</para>
    ///   <para>skos:definition : the postal code of this address as specified by the local postal service^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostalCode">fibo-fnd-plc-adr:hasPostalCode</a>
    /// </summary>
    let hasPostalCode = _prefixId.prefix "hasPostalCode"
    /// <summary>
    ///   <para>rdfs:label : has postdirectional symbol^^xsd:string</para>
    ///   <para>skos:definition : specifies a geographic directional symbol that follows the street name and street suffix in a street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPostdirectionalSymbol">fibo-fnd-plc-adr:hasPostdirectionalSymbol</a>
    /// </summary>
    let hasPostdirectionalSymbol = _prefixId.prefix "hasPostdirectionalSymbol"
    /// <summary>
    ///   <para>rdfs:label : has predirectional symbol^^xsd:string</para>
    ///   <para>skos:definition : specifies a geographic directional symbol that occurs after the primary street number but before the street name in a street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPredirectionalSymbol">fibo-fnd-plc-adr:hasPredirectionalSymbol</a>
    /// </summary>
    let hasPredirectionalSymbol = _prefixId.prefix "hasPredirectionalSymbol"
    /// <summary>
    ///   <para>rdfs:label : has primary address number^^xsd:string</para>
    ///   <para>skos:definition : specifies a a location with respect to a given street^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasPrimaryAddressNumber">fibo-fnd-plc-adr:hasPrimaryAddressNumber</a>
    /// </summary>
    let hasPrimaryAddressNumber = _prefixId.prefix "hasPrimaryAddressNumber"
    /// <summary>
    ///   <para>rdfs:label : has secondary unit^^xsd:string</para>
    ///   <para>skos:definition : specifies an individual unit within a larger structure, such as an apartment, office, hangar, slip, mailbox, and so forth, at a given street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasSecondaryUnit">fibo-fnd-plc-adr:hasSecondaryUnit</a>
    /// </summary>
    let hasSecondaryUnit = _prefixId.prefix "hasSecondaryUnit"
    /// <summary>
    ///   <para>rdfs:label : has street address^^xsd:string</para>
    ///   <para>skos:definition : indicates a fully-specified address component that consists of a primary address number, predirectional, street name, suffix, postdirectional, and an optional secondary unit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetAddress">fibo-fnd-plc-adr:hasStreetAddress</a>
    /// </summary>
    let hasStreetAddress = _prefixId.prefix "hasStreetAddress"
    /// <summary>
    ///   <para>rdfs:label : has street name^^xsd:string</para>
    ///   <para>skos:definition : specifies an identifier for a street in some context (e.g., 'Baker', 'First', 'Main')^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetName">fibo-fnd-plc-adr:hasStreetName</a>
    /// </summary>
    let hasStreetName = _prefixId.prefix "hasStreetName"
    /// <summary>
    ///   <para>rdfs:label : has street suffix^^xsd:string</para>
    ///   <para>skos:definition : specifies an additional qualifier for a street or other delivery location, such as a dwelling located along a waterway^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStreetSuffix">fibo-fnd-plc-adr:hasStreetSuffix</a>
    /// </summary>
    let hasStreetSuffix = _prefixId.prefix "hasStreetSuffix"
    /// <summary>
    ///   <para>rdfs:label : has structure name^^xsd:string</para>
    ///   <para>skos:definition : specifies an identifier for a building, house, office complex, shopping center, or other structure or group of structures^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasStructureName">fibo-fnd-plc-adr:hasStructureName</a>
    /// </summary>
    let hasStructureName = _prefixId.prefix "hasStructureName"
    /// <summary>
    ///   <para>rdfs:label : has transliterated address^^xsd:string</para>
    ///   <para>skos:definition : identifies a transliterated (i.e., in Latin or Romanized ASCII) address for the registered entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/hasTransliteratedAddress">fibo-fnd-plc-adr:hasTransliteratedAddress</a>
    /// </summary>
    let hasTransliteratedAddress = _prefixId.prefix "hasTransliteratedAddress"
    /// <summary>
    ///   <para>rdfs:label : requires secondary unit range^^xsd:string</para>
    ///   <para>skos:definition : if true, indicates that an additional qualifier is needed to complete the delivery point description, such as an apartment number^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that in some cases, such as for lobby or office, if there are multiple secondary units then a range may be needed to differentiate between them, even if the range is not always required.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/requiresSecondaryUnitRange">fibo-fnd-plc-adr:requiresSecondaryUnitRange</a>
    /// </summary>
    let requiresSecondaryUnitRange = _prefixId.prefix "requiresSecondaryUnitRange"
