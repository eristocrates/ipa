#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-ra`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/RegistrationAuthorities/" "cmns-ra"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : registered identifier^^xsd:string</para>
    ///   <para>skos:definition : contextual identifier that is registered in a registry by, or on behalf of, a registration authority according to some registration scheme^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegisteredIdentifier">cmns-ra:RegisteredIdentifier</a>
    /// </summary>
    let RegisteredIdentifier = _prefixId.prefix "RegisteredIdentifier"
    /// <summary>
    ///   <para>rdfs:label : registrar^^xsd:string</para>
    ///   <para>skos:definition : role of a party that acts as a representative of a registration authority to provide registration services, including official record keeping^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economic Terms, Fifth Edition, 2012^^xsd:stringcmns-av:adaptedFrom : ISO/IEC 11179-3:2023, Information technology - Metadata registries (MDR) - Part 3: Metamodel for registry common facilities, Fourth edition, 2023^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/Registrar">cmns-ra:Registrar</a>
    /// </summary>
    let Registrar = _prefixId.prefix "Registrar"
    /// <summary>
    ///   <para>rdfs:label : registration authority^^xsd:string</para>
    ///   <para>skos:definition : service provider that is officially responsible for maintaining a registry and providing registration services and/or for delegating of some or all of these roles to a registrar^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RA^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3:2023, Information technology - Metadata registries (MDR) - Part 3: Metamodel for registry common facilities, Fourth edition, 2023^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationAuthority">cmns-ra:RegistrationAuthority</a>
    /// </summary>
    let RegistrationAuthority = _prefixId.prefix "RegistrationAuthority"
    /// <summary>
    ///   <para>rdfs:label : registration scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme for organizing information in a registry and allocating identifiers to registered items^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3:2023, Information technology - Metadata registries (MDR) - Part 3: Metamodel for registry common facilities, Fourth edition, 2023^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationScheme">cmns-ra:RegistrationScheme</a>
    /// </summary>
    let RegistrationScheme = _prefixId.prefix "RegistrationScheme"
    /// <summary>
    ///   <para>rdfs:label : registration service^^xsd:string</para>
    ///   <para>skos:definition : service provided to individuals and/or organizations for the registration of items in a registry^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationService">cmns-ra:RegistrationService</a>
    /// </summary>
    let RegistrationService = _prefixId.prefix "RegistrationService"
    /// <summary>
    ///   <para>rdfs:label : registry^^xsd:string</para>
    ///   <para>skos:definition : authoritative record or collection of records relating to something^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3:2023, Information technology - Metadata registries (MDR) - Part 3: Metamodel for registry common facilities, Fourth edition, 2023^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Electronic registries typically contain a unique identifier for each entry, so that individual records can be referenced from other documents and registries.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/Registry">cmns-ra:Registry</a>
    /// </summary>
    let Registry = _prefixId.prefix "Registry"
    /// <summary>
    ///   <para>rdfs:label : registry entry^^xsd:string</para>
    ///   <para>skos:definition : constituent of a registry that includes the details for something recorded in that registry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3:2023, Information technology - Metadata registries (MDR) - Part 3: Metamodel for registry common facilities, Fourth edition, 2023^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note: From an ISO 11179 perspective, a registry item (entry) is recorded in the registry, but is not necessarily identified, named, defined, classified, registered or administered. Specific information needs to be provided for each of these categories which can be provided when the item is initially recorded, or later.^^xsd:string</para>
    ///   <para>cmns-av:synonym : registry item^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistryEntry">cmns-ra:RegistryEntry</a>
    /// </summary>
    let RegistryEntry = _prefixId.prefix "RegistryEntry"
    /// <summary>
    ///   <para>rdfs:label : has registration authority^^xsd:string</para>
    ///   <para>skos:definition : indicates the registration authority for something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/hasRegistrationAuthority">cmns-ra:hasRegistrationAuthority</a>
    /// </summary>
    let hasRegistrationAuthority = _prefixId.prefix "hasRegistrationAuthority"
    /// <summary>
    ///   <para>rdfs:label : has registration date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date or date and time on which something is registered^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/hasRegistrationDate">cmns-ra:hasRegistrationDate</a>
    /// </summary>
    let hasRegistrationDate = _prefixId.prefix "hasRegistrationDate"
    /// <summary>
    ///   <para>rdfs:label : is registered by^^xsd:string</para>
    ///   <para>skos:definition : indicates the registration authority or registrar that registers something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegisteredBy">cmns-ra:isRegisteredBy</a>
    /// </summary>
    let isRegisteredBy = _prefixId.prefix "isRegisteredBy"
    /// <summary>
    ///   <para>rdfs:label : is registered in^^xsd:string</para>
    ///   <para>skos:definition : indicates the registry that something is registered in^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegisteredIn">cmns-ra:isRegisteredIn</a>
    /// </summary>
    let isRegisteredIn = _prefixId.prefix "isRegisteredIn"
    /// <summary>
    ///   <para>rdfs:label : is registration authority for^^xsd:string</para>
    ///   <para>skos:definition : indicates something (typically an identifier or code) that the registration authority issues^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegistrationAuthorityFor">cmns-ra:isRegistrationAuthorityFor</a>
    /// </summary>
    let isRegistrationAuthorityFor = _prefixId.prefix "isRegistrationAuthorityFor"
    /// <summary>
    ///   <para>rdfs:label : registers^^xsd:string</para>
    ///   <para>skos:definition : records something in a registry or archive^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegistrationAuthorities/registers">cmns-ra:registers</a>
    /// </summary>
    let registers = _prefixId.prefix "registers"
