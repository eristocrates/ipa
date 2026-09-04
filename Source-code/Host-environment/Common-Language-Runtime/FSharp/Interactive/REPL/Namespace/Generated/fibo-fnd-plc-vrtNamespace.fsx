#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-plc-vrt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/" "fibo-fnd-plc-vrt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : electronic mail address^^xsd:string</para>
    ///   <para>skos:definition : virtual address that defines an electronic messaging endpoint to which email messages can be delivered, typically via an Simple Mail Transfer Protocol (SMTP) based communications system^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : e-mail address^^xsd:stringcmns-av:abbreviation : email address^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Electronic mail, abbreviated e-mail or email, is a method of composing, sending, and receiving messages over electronic communication systems. The term e-mail applies both to the Internet e-mail system based on the Simple Mail Transfer Protocol (SMTP) and to intranet systems allowing users within one company or organization to send messages to each other. Often these workgroup collaboration systems natively use non-standard protocols but have some form of gateway to allow them to send and receive Internet e-mail. Some organizations may use the Internet protocols for internal e-mail service.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/ElectronicMailAddress">fibo-fnd-plc-vrt:ElectronicMailAddress</a>
    /// </summary>
    let ElectronicMailAddress = _prefixId.prefix "ElectronicMailAddress"
    /// <summary>
    ///   <para>rdfs:label : network location^^xsd:string</para>
    ///   <para>skos:definition : a virtual location that may be identified by a network address (an identifier for a node or interface)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NetworkLocation">fibo-fnd-plc-vrt:NetworkLocation</a>
    /// </summary>
    let NetworkLocation = _prefixId.prefix "NetworkLocation"
    /// <summary>
    ///   <para>rdfs:label : notional place^^xsd:string</para>
    ///   <para>skos:definition : an abstract place; one of many commonly understood concepts such as domestic, Eurozone etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NotionalPlace">fibo-fnd-plc-vrt:NotionalPlace</a>
    /// </summary>
    let NotionalPlace = _prefixId.prefix "NotionalPlace"
    /// <summary>
    ///   <para>rdfs:label : telephone number^^xsd:string</para>
    ///   <para>skos:definition : virtual address that may be assigned to a fixed-line telephone subscriber station connected to a telephone line or to a wireless electronic telephony device, such as a radio telephone or a mobile telephone, or to other devices or services for data transmission via the public switched telephone network (PSTN) or other public and private networks^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : phone number^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Telephone numbers are assigned within the framework of a national or regional telephone numbering plan to subscribers by telephone service operators, which may be commercial entities, state-controlled administrations, or other telecommunication industry associations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/TelephoneNumber">fibo-fnd-plc-vrt:TelephoneNumber</a>
    /// </summary>
    let TelephoneNumber = _prefixId.prefix "TelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : has electronic mail address^^xsd:string</para>
    ///   <para>skos:definition : specifies an electronic messaging endpoint at which some entity may be located or contacted or may receive correspondence^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : has e-mail address^^xsd:stringcmns-av:abbreviation : has email address^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasElectronicMailAddress">fibo-fnd-plc-vrt:hasElectronicMailAddress</a>
    /// </summary>
    let hasElectronicMailAddress = _prefixId.prefix "hasElectronicMailAddress"
    /// <summary>
    ///   <para>rdfs:label : has telephone number^^xsd:string</para>
    ///   <para>skos:definition : indicates a virtual address composed of a sequence of digits and symbols that may be assigned to a fixed-line telephone subscriber station, a wireless electronic telephony device, such as a radio telephone or a mobile telephone, or other similar device or service^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasTelephoneNumber">fibo-fnd-plc-vrt:hasTelephoneNumber</a>
    /// </summary>
    let hasTelephoneNumber = _prefixId.prefix "hasTelephoneNumber"
