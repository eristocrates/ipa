namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.UKGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_ukj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_ukj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-ukj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Government Entities and Jurisdictions for the United Kingdom of Great Britain and Northern Ireland Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_ukj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:EnglandAndWalesJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"England and Wales jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/EnglandAndWalesJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/EnglandAndWalesJurisdiction</seealso>
    let EnglandAndWalesJurisdiction =
        Prefixed_Name(fibo_be_ge_ukj, "EnglandAndWalesJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:GovernmentOfGuernsey</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of Guernsey"</para><para>"Gouvèrnément d'Guernési"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfGuernsey">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfGuernsey</seealso>
    let GovernmentOfGuernsey =
        Prefixed_Name(fibo_be_ge_ukj, "GovernmentOfGuernsey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:GovernmentOfJersey</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of Jersey"</para><para>"Gouvèrnément d'Jèrri"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfJersey">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfJersey</seealso>
    let GovernmentOfJersey =
        Prefixed_Name(fibo_be_ge_ukj, "GovernmentOfJersey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:GovernmentOfScotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:DevolvedGovernment</para>
    ///
    /// labels<para>"Riaghaltas na h-Alba"</para><para>"Government of Scotland"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfScotland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfScotland</seealso>
    let GovernmentOfScotland =
        Prefixed_Name(fibo_be_ge_ukj, "GovernmentOfScotland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:GovernmentOfTheIsleOfMan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"Government of the Isle of Man"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfTheIsleOfMan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfTheIsleOfMan</seealso>
    let GovernmentOfTheIsleOfMan =
        Prefixed_Name(fibo_be_ge_ukj, "GovernmentOfTheIsleOfMan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:GovernmentOfTheUnitedKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the United Kingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfTheUnitedKingdom">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GovernmentOfTheUnitedKingdom</seealso>
    let GovernmentOfTheUnitedKingdom =
        Prefixed_Name(fibo_be_ge_ukj, "GovernmentOfTheUnitedKingdom") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:GuernseyEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guernsey entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GuernseyEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/GuernseyEntity</seealso>
    let GuernseyEntity = Prefixed_Name(fibo_be_ge_ukj, "GuernseyEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:IsleOfManEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Isle of Man entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/IsleOfManEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/IsleOfManEntity</seealso>
    let IsleOfManEntity =
        Prefixed_Name(fibo_be_ge_ukj, "IsleOfManEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:JerseyEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Jersey entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JerseyEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JerseyEntity</seealso>
    let JerseyEntity = Prefixed_Name(fibo_be_ge_ukj, "JerseyEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:JurisdictionOfGuernsey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Guernsey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JurisdictionOfGuernsey">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JurisdictionOfGuernsey</seealso>
    let JurisdictionOfGuernsey =
        Prefixed_Name(fibo_be_ge_ukj, "JurisdictionOfGuernsey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:JurisdictionOfJersey</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Jersey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JurisdictionOfJersey">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JurisdictionOfJersey</seealso>
    let JurisdictionOfJersey =
        Prefixed_Name(fibo_be_ge_ukj, "JurisdictionOfJersey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:JurisdictionOfTheIsleOfMan</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of the Isle of Man"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JurisdictionOfTheIsleOfMan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/JurisdictionOfTheIsleOfMan</seealso>
    let JurisdictionOfTheIsleOfMan =
        Prefixed_Name(fibo_be_ge_ukj, "JurisdictionOfTheIsleOfMan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:NationalAssemblyForWales</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>fibo-be-ge-ge:DevolvedGovernment</para>
    ///
    /// labels<para>"Cynulliad Cenedlaethol Cymru"</para><para>"National Assembly for Wales"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NationalAssemblyForWales">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NationalAssemblyForWales</seealso>
    let NationalAssemblyForWales =
        Prefixed_Name(fibo_be_ge_ukj, "NationalAssemblyForWales") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:NorthernIrelandAssembly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>fibo-be-ge-ge:DevolvedGovernment</para>
    ///
    /// labels<para>"Tionól Thuaisceart Éireann"</para><para>"Northern Ireland Assembly"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NorthernIrelandAssembly">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NorthernIrelandAssembly</seealso>
    let NorthernIrelandAssembly =
        Prefixed_Name(fibo_be_ge_ukj, "NorthernIrelandAssembly") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:NorthernIrelandEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Northern Ireland entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NorthernIrelandEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NorthernIrelandEntity</seealso>
    let NorthernIrelandEntity =
        Prefixed_Name(fibo_be_ge_ukj, "NorthernIrelandEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:NorthernIrelandJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Northern Ireland jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NorthernIrelandJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/NorthernIrelandJurisdiction</seealso>
    let NorthernIrelandJurisdiction =
        Prefixed_Name(fibo_be_ge_ukj, "NorthernIrelandJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:ScotlandEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Scotland entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/ScotlandEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/ScotlandEntity</seealso>
    let ScotlandEntity = Prefixed_Name(fibo_be_ge_ukj, "ScotlandEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:ScotlandJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Scotland jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/ScotlandJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/ScotlandJurisdiction</seealso>
    let ScotlandJurisdiction =
        Prefixed_Name(fibo_be_ge_ukj, "ScotlandJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:UnitedKingdomEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"United Kingdom entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/UnitedKingdomEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/UnitedKingdomEntity</seealso>
    let UnitedKingdomEntity =
        Prefixed_Name(fibo_be_ge_ukj, "UnitedKingdomEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:UnitedKingdomJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"United Kingdom jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/UnitedKingdomJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/UnitedKingdomJurisdiction</seealso>
    let UnitedKingdomJurisdiction =
        Prefixed_Name(fibo_be_ge_ukj, "UnitedKingdomJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ukj:WelshEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Welsh entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/WelshEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/WelshEntity</seealso>
    let WelshEntity = Prefixed_Name(fibo_be_ge_ukj, "WelshEntity") |> PrefixedName
