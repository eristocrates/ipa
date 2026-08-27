namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.LatinAmericanJurisdiction.CentralAmericanGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_ctlaj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_ctlaj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Central American Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_ctlaj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:BelizeanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Belizean entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/BelizeanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/BelizeanEntity</seealso>
    let BelizeanEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "BelizeanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:CostaRicanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Costa Rican entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/CostaRicanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/CostaRicanEntity</seealso>
    let CostaRicanEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "CostaRicanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfBelize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of Belize"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfBelize">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfBelize</seealso>
    let GovernmentOfBelize =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfBelize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfTheRepublicOfCostaRica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Republic of Costa Rica"</para><para>"República de Costa Rica"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfCostaRica">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfCostaRica</seealso>
    let GovernmentOfTheRepublicOfCostaRica =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfTheRepublicOfCostaRica") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfTheRepublicOfElSalvador</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Republic of El Salvador"</para><para>"República de El Salvador"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfElSalvador">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfElSalvador</seealso>
    let GovernmentOfTheRepublicOfElSalvador =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfTheRepublicOfElSalvador") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfTheRepublicOfGuatemala</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"República de Guatemala"</para><para>"Government of the Republic of Guatemala"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfGuatemala">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfGuatemala</seealso>
    let GovernmentOfTheRepublicOfGuatemala =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfTheRepublicOfGuatemala") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfTheRepublicOfHonduras</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Republic of Honduras"</para><para>"República de Honduras"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfHonduras">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfHonduras</seealso>
    let GovernmentOfTheRepublicOfHonduras =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfTheRepublicOfHonduras") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfTheRepublicOfNicaragua</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Republic of Nicaragua"</para><para>"República de Nicaragua"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfNicaragua">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfNicaragua</seealso>
    let GovernmentOfTheRepublicOfNicaragua =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfTheRepublicOfNicaragua") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GovernmentOfTheRepublicOfPanama</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Republic of Panama"</para><para>"República de Panamá"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfPanama">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfPanama</seealso>
    let GovernmentOfTheRepublicOfPanama =
        Prefixed_Name(fibo_be_ge_ctlaj, "GovernmentOfTheRepublicOfPanama") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:GuatemalanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Guatemalan entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GuatemalanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/GuatemalanEntity</seealso>
    let GuatemalanEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "GuatemalanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:HonduranEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Honduran entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/HonduranEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/HonduranEntity</seealso>
    let HonduranEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "HonduranEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfBelize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Belize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfBelize">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfBelize</seealso>
    let JurisdictionOfBelize =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfBelize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfCostaRica</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Costa Rica"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfCostaRica">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfCostaRica</seealso>
    let JurisdictionOfCostaRica =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfCostaRica") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfElSalvador</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of ElSalvador"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfElSalvador">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfElSalvador</seealso>
    let JurisdictionOfElSalvador =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfElSalvador") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfGuatemala</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Guatemala"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfGuatemala">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfGuatemala</seealso>
    let JurisdictionOfGuatemala =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfGuatemala") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfHonduras</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Honduras"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfHonduras">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfHonduras</seealso>
    let JurisdictionOfHonduras =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfHonduras") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfNicaragua</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Nicaragua"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfNicaragua">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfNicaragua</seealso>
    let JurisdictionOfNicaragua =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfNicaragua") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:JurisdictionOfPanama</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Panama"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfPanama">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/JurisdictionOfPanama</seealso>
    let JurisdictionOfPanama =
        Prefixed_Name(fibo_be_ge_ctlaj, "JurisdictionOfPanama") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:NicaraguanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Nicaraguan entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/NicaraguanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/NicaraguanEntity</seealso>
    let NicaraguanEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "NicaraguanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:PanamanianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Panamanian entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/PanamanianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/PanamanianEntity</seealso>
    let PanamanianEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "PanamanianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ctlaj:SalvadorianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Salvadorian entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/SalvadorianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/SalvadorianEntity</seealso>
    let SalvadorianEntity =
        Prefixed_Name(fibo_be_ge_ctlaj, "SalvadorianEntity") |> PrefixedName
