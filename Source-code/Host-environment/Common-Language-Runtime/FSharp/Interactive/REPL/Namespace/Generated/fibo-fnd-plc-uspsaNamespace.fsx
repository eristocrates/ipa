#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-plc-uspsa`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/" "fibo-fnd-plc-uspsa"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : complete address^^xsd:string</para>
    ///   <para>skos:definition : delivery address that has all the address elements necessary to allow an exact match with the current Postal Service ZIP+4 and City State files to obtain the finest level of ZIP+4 and delivery point codes for the delivery address^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A complete address may be required on mail at some automation rates.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/CompleteAddress">fibo-fnd-plc-uspsa:CompleteAddress</a>
    /// </summary>
    let CompleteAddress = _prefixId.prefix "CompleteAddress"
    /// <summary>
    ///   <para>rdfs:label : delivery address code set^^xsd:string</para>
    ///   <para>skos:definition : system of numeric codes that substitute for specified delivery point details according to the U.S. Postal Service Publication 28^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryAddressCodeSet">fibo-fnd-plc-uspsa:DeliveryAddressCodeSet</a>
    /// </summary>
    let DeliveryAddressCodeSet = _prefixId.prefix "DeliveryAddressCodeSet"
    /// <summary>
    ///   <para>rdfs:label : delivery point code^^xsd:string</para>
    ///   <para>skos:definition : specific set of digits between 00 and 99 assigned to a delivery point^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When combined with the ZIP + 4 code, the delivery point code provides a unique identifier for every deliverable address served by the USPS. The delivery point digits are almost never printed on mail in human-readable form; instead they are encoded in the POSTNET delivery point barcode (DPBC) or as part of the newer Intelligent Mail Barcode (IMB).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCode">fibo-fnd-plc-uspsa:DeliveryPointCode</a>
    /// </summary>
    let DeliveryPointCode = _prefixId.prefix "DeliveryPointCode"
    /// <summary>
    ///   <para>rdfs:label : delivery point code set^^xsd:string</para>
    ///   <para>skos:definition : system of numeric codes that substitute for specified delivery point details according to the U.S. Postal Service Publication 28^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DeliveryPointCodeSet">fibo-fnd-plc-uspsa:DeliveryPointCodeSet</a>
    /// </summary>
    let DeliveryPointCodeSet = _prefixId.prefix "DeliveryPointCodeSet"
    /// <summary>
    ///   <para>rdfs:label : Department of State address^^xsd:string</para>
    ///   <para>skos:definition : delivery address whose delivery address line uses 'UNIT' followed by the unit identifier, followed by 'BOX' followed by box number, in place of a street address, 'DPO' as the literal value for the city, and the appropriate armed forces subdivision code in place of a subdivision (state) code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateAddress">fibo-fnd-plc-uspsa:DepartmentOfStateAddress</a>
    /// </summary>
    let DepartmentOfStateAddress = _prefixId.prefix "DepartmentOfStateAddress"

    /// <summary>
    ///   <para>rdfs:label : Department of State unit component^^xsd:string</para>
    ///   <para>skos:definition : component of a Department of State address that includes 'UNIT' followed by the unit identifier^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/DepartmentOfStateUnitComponent">fibo-fnd-plc-uspsa:DepartmentOfStateUnitComponent</a>
    /// </summary>
    let DepartmentOfStateUnitComponent =
        _prefixId.prefix "DepartmentOfStateUnitComponent"

    let East = _prefixId.prefix "East"
    /// <summary>
    ///   <para>rdfs:label : general delivery address^^xsd:string</para>
    ///   <para>skos:definition : delivery address that uses the words 'GENERAL DELIVERY', uppercase preferred, spelled out (no abbreviation), in place of a street address^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The value of the +4 component of a ZIP+4 code should be '9999'.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/GeneralDeliveryAddress">fibo-fnd-plc-uspsa:GeneralDeliveryAddress</a>
    /// </summary>
    let GeneralDeliveryAddress = _prefixId.prefix "GeneralDeliveryAddress"
    /// <summary>
    ///   <para>rdfs:label : highway contract route^^xsd:string</para>
    ///   <para>skos:definition : highway contract route associated with an address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRoute">fibo-fnd-plc-uspsa:HighwayContractRoute</a>
    /// </summary>
    let HighwayContractRoute = _prefixId.prefix "HighwayContractRoute"
    /// <summary>
    ///   <para>rdfs:label : highway contract address^^xsd:string</para>
    ///   <para>skos:definition : delivery address whose delivery address line uses the abbreviation 'HC', followed by the route identifier, followed by 'BOX' followed by box number, in place of a street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/HighwayContractRouteAddress">fibo-fnd-plc-uspsa:HighwayContractRouteAddress</a>
    /// </summary>
    let HighwayContractRouteAddress = _prefixId.prefix "HighwayContractRouteAddress"

    let HighwayContractRouteDesignator =
        _prefixId.prefix "HighwayContractRouteDesignator"

    /// <summary>
    ///   <para>rdfs:label : international address^^xsd:string</para>
    ///   <para>skos:definition : physical address that explicitly includes a country^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/InternationalAddress">fibo-fnd-plc-uspsa:InternationalAddress</a>
    /// </summary>
    let InternationalAddress = _prefixId.prefix "InternationalAddress"
    /// <summary>
    ///   <para>rdfs:label : mailbox^^xsd:string</para>
    ///   <para>skos:definition : mailbox, other than a U.S. Post Office box, associated with an address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Mailbox">fibo-fnd-plc-uspsa:Mailbox</a>
    /// </summary>
    let Mailbox = _prefixId.prefix "Mailbox"
    let MailboxDesignator = _prefixId.prefix "MailboxDesignator"
    let North = _prefixId.prefix "North"
    let Northeast = _prefixId.prefix "Northeast"
    let Northwest = _prefixId.prefix "Northwest"
    /// <summary>
    ///   <para>rdfs:label : overseas military address^^xsd:string</para>
    ///   <para>skos:definition : delivery address whose delivery address line uses an abbreviation for the unit or command such as 'CMR', 'PSC', or 'UNIT', or 'HC', followed by the unit identifier, followed by 'BOX' followed by box number, in place of a street address, either 'APO' or 'FPO' as the literal value for the city and the appropriate armed forces subdivision code in place of a subdivision (state) code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/OverseasMilitaryAddress">fibo-fnd-plc-uspsa:OverseasMilitaryAddress</a>
    /// </summary>
    let OverseasMilitaryAddress = _prefixId.prefix "OverseasMilitaryAddress"
    /// <summary>
    ///   <para>rdfs:label : private mail box address^^xsd:string</para>
    ///   <para>skos:definition : delivery address provided by a commercial mail receiving company that includes a supplementary address line containing the abbreviation 'PMB' or the pound "#" symbol followed by the mailbox number; alternatively, 'PMB' or '#" and the mailbox number can be appended to the street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PrivateMailBoxAddress">fibo-fnd-plc-uspsa:PrivateMailBoxAddress</a>
    /// </summary>
    let PrivateMailBoxAddress = _prefixId.prefix "PrivateMailBoxAddress"
    /// <summary>
    ///   <para>rdfs:label : Puerto Rico address^^xsd:string</para>
    ///   <para>skos:definition : delivery address for a delivery point in Puerto Rico that may include a supplementary address line containing the abbreviation 'URB' followed by the name of the urbanization area that is appropriate for that address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/PuertoRicoAddress">fibo-fnd-plc-uspsa:PuertoRicoAddress</a>
    /// </summary>
    let PuertoRicoAddress = _prefixId.prefix "PuertoRicoAddress"
    /// <summary>
    ///   <para>rdfs:label : highway contract route address^^xsd:string</para>
    ///   <para>skos:definition : mail route outside the city or township limits in a rural area associated with an address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRoute">fibo-fnd-plc-uspsa:RuralRoute</a>
    /// </summary>
    let RuralRoute = _prefixId.prefix "RuralRoute"
    /// <summary>
    ///   <para>rdfs:label : rural route address^^xsd:string</para>
    ///   <para>skos:definition : delivery address whose delivery address line uses the abbreviation 'RR', followed by the route identifier, followed by 'BOX' followed by box number, in place of a street address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/RuralRouteAddress">fibo-fnd-plc-uspsa:RuralRouteAddress</a>
    /// </summary>
    let RuralRouteAddress = _prefixId.prefix "RuralRouteAddress"
    let RuralRouteDesignator = _prefixId.prefix "RuralRouteDesignator"
    let South = _prefixId.prefix "South"
    let Southeast = _prefixId.prefix "Southeast"
    let Southwest = _prefixId.prefix "Southwest"
    /// <summary>
    ///   <para>rdfs:label : standardized address^^xsd:string</para>
    ///   <para>skos:definition : delivery address that is fully spelled out, abbreviated by using the Postal Service standard abbreviations or as given in the current Postal Service ZIP+4 file^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/StandardizedAddress">fibo-fnd-plc-uspsa:StandardizedAddress</a>
    /// </summary>
    let StandardizedAddress = _prefixId.prefix "StandardizedAddress"
    let USPostOfficeBoxDesignator = _prefixId.prefix "USPostOfficeBoxDesignator"

    /// <summary>
    ///   <para>rdfs:label : U.S. Postal Service address identifier^^xsd:string</para>
    ///   <para>skos:definition : combined with the ZIP + 4 code, the delivery point code provides a unique identifier for every deliverable address served by the USPS^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The delivery point digits are almost never printed on mail in human-readable form; instead they are encoded in the POSTNET delivery point barcode (DPBC) or as part of the newer Intelligent Mail Barcode (IMB).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/USPostalServiceAddressIdentifier">fibo-fnd-plc-uspsa:USPostalServiceAddressIdentifier</a>
    /// </summary>
    let USPostalServiceAddressIdentifier =
        _prefixId.prefix "USPostalServiceAddressIdentifier"

    /// <summary>
    ///   <para>rdfs:label : urbanization^^xsd:string</para>
    ///   <para>skos:definition : an area, sector, or development within a larger geographic area^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This URB descriptor, commonly used in urban areas of Puerto Rico, is an important part of the addressing format, as it describes the location of a given street.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/Urbanization">fibo-fnd-plc-uspsa:Urbanization</a>
    /// </summary>
    let Urbanization = _prefixId.prefix "Urbanization"
    let West = _prefixId.prefix "West"
    /// <summary>
    ///   <para>rdfs:label : Zip Code^^xsd:string</para>
    ///   <para>skos:definition : five-digit code code assigned to a delivery address indicating the state and post office or postal zone^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPCode">fibo-fnd-plc-uspsa:ZIPCode</a>
    /// </summary>
    let ZIPCode = _prefixId.prefix "ZIPCode"
    /// <summary>
    ///   <para>rdfs:label : ZIP+4 Code^^xsd:string</para>
    ///   <para>skos:definition : nine-digit number consisting of five digits, a hyphen, and four digits, which the USPS describes by its trademark ZIP+4^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The correct format for a numeric ZIP+4 code is five digits, a hyphen, and four digits. The first five digits represent the 5-digit ZIP Code; the sixth and seventh digits (the first two after the hyphen) identify an area known as a sector; the eighth and ninth digits identify a smaller area known as a segment. Together, the final four digits identify geographic units such as a side of a street between intersections, both sides of a street between intersections, a building, a floor or group of floors in a building, a firm within a building, a span of boxes on a rural route, or a group of Post Office boxes to which a single USPS employee makes delivery.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZIPPlus4Code">fibo-fnd-plc-uspsa:ZIPPlus4Code</a>
    /// </summary>
    let ZIPPlus4Code = _prefixId.prefix "ZIPPlus4Code"
    /// <summary>
    ///   <para>rdfs:label : zip code scheme^^xsd:string</para>
    ///   <para>skos:definition : system used in the U.S. to facilitate the delivery of mail, consisting of a five- or nine-digit code Zone Improvement Plan (ZIP) printed directly after the address, the first five digits (initial code) indicating the state and post office or postal zone, the last four (expanded code) the box section or number, portion of a rural route, building, or other specific delivery location^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/ZipCodeScheme">fibo-fnd-plc-uspsa:ZipCodeScheme</a>
    /// </summary>
    let ZipCodeScheme = _prefixId.prefix "ZipCodeScheme"
    /// <summary>
    ///   <para>rdfs:label : has urbanization^^xsd:string</para>
    ///   <para>skos:definition : indicates area, sector, or development within a geographic area relevant to a delivery address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/hasUrbanization">fibo-fnd-plc-uspsa:hasUrbanization</a>
    /// </summary>
    let hasUrbanization = _prefixId.prefix "hasUrbanization"
