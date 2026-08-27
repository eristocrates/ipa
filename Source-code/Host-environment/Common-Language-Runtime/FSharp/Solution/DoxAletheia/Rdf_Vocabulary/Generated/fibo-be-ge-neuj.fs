namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.NorthernEuropeGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_neuj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_neuj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-neuj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Northern Europe Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_neuj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:AlandIslandsJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"Ahvenanmaan lainkäyttöalue"</para><para>"Ålandöarnas jurisdiktion"</para><para>"Aland Islands jurisdiction"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/AlandIslandsJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/AlandIslandsJurisdiction</seealso>
    let AlandIslandsJurisdiction =
        Prefixed_Name(fibo_be_ge_neuj, "AlandIslandsJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:AlandicEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ahvenanmaan kokonaisuus"</para><para>"Ålandisk enhet"</para><para>"Alandic entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/AlandicEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/AlandicEntity</seealso>
    let AlandicEntity = Prefixed_Name(fibo_be_ge_neuj, "AlandicEntity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-neuj:DanishEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Dansk enhed"</para><para>"Danish entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/DanishEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/DanishEntity</seealso>
    let DanishEntity = Prefixed_Name(fibo_be_ge_neuj, "DanishEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:EstonianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Eesti üksus"</para><para>"Estonian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/EstonianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/EstonianEntity</seealso>
    let EstonianEntity =
        Prefixed_Name(fibo_be_ge_neuj, "EstonianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:FinnishEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Finnish entity"</para><para>"Suomen entiteetti"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/FinnishEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/FinnishEntity</seealso>
    let FinnishEntity = Prefixed_Name(fibo_be_ge_neuj, "FinnishEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfAland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"Ahvenanmaan hallitus"</para><para>"Government of Aland"</para><para>"Ålands regering"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfAland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfAland</seealso>
    let GovernmentOfAland =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfAland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfIceland</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ríkisstjórn Íslands"</para><para>"Government of Iceland"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfIceland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfIceland</seealso>
    let GovernmentOfIceland =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfIceland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheKingdomOfDenmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Kingdom of Denmark"</para><para>"Kongeriget Danmarks regering"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfDenmark">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfDenmark</seealso>
    let GovernmentOfTheKingdomOfDenmark =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheKingdomOfDenmark") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheKingdomOfNorway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Kongeriket Norges regjering"</para><para>"Government of the Kingdom of Norway"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfNorway">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfNorway</seealso>
    let GovernmentOfTheKingdomOfNorway =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheKingdomOfNorway") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheKingdomOfSweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Kingdom of Sweden"</para><para>"Konungariket Sveriges regering"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfSweden">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfSweden</seealso>
    let GovernmentOfTheKingdomOfSweden =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheKingdomOfSweden") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheRepublicOfEstonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Republic of Estonia"</para><para>"Eesti Vabariigi valitsus"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfEstonia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfEstonia</seealso>
    let GovernmentOfTheRepublicOfEstonia =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheRepublicOfEstonia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheRepublicOfFinland</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Republic of Finland"</para><para>"Suomen tasavallan hallitus"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfFinland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfFinland</seealso>
    let GovernmentOfTheRepublicOfFinland =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheRepublicOfFinland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheRepublicOfIreland</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Rialtas Phoblacht na hÉireann"</para><para>"Government of the Republic of Ireland"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfIreland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfIreland</seealso>
    let GovernmentOfTheRepublicOfIreland =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheRepublicOfIreland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheRepublicOfLatvia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Latvijas Republikas valdība"</para><para>"Government of the Republic of Latvia"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfLatvia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfLatvia</seealso>
    let GovernmentOfTheRepublicOfLatvia =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheRepublicOfLatvia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:GovernmentOfTheRepublicOfLithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Lietuvos Respublikos Vyriausybė"</para><para>"Government of the Republic of Lithuania"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfLithuania">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfLithuania</seealso>
    let GovernmentOfTheRepublicOfLithuania =
        Prefixed_Name(fibo_be_ge_neuj, "GovernmentOfTheRepublicOfLithuania") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:IcelandicEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Icelandic entity"</para><para>"Íslensk eining"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/IcelandicEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/IcelandicEntity</seealso>
    let IcelandicEntity =
        Prefixed_Name(fibo_be_ge_neuj, "IcelandicEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:IrishEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Irish entity"</para><para>"Aonán Éireannach"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/IrishEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/IrishEntity</seealso>
    let IrishEntity = Prefixed_Name(fibo_be_ge_neuj, "IrishEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfDenmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"Danmarks jurisdiktion"</para><para>"jurisdiction of Denmark"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfDenmark">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfDenmark</seealso>
    let JurisdictionOfDenmark =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfDenmark") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfEstonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"Eesti jurisdiktsioon"</para><para>"jurisdiction of Estonia"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfEstonia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfEstonia</seealso>
    let JurisdictionOfEstonia =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfEstonia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfFinland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Finland"</para><para>"Suomen lainkäyttövaltaan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfFinland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfFinland</seealso>
    let JurisdictionOfFinland =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfFinland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfIceland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Iceland"</para><para>"lögsögu Íslands"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfIceland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfIceland</seealso>
    let JurisdictionOfIceland =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfIceland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfIreland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Ireland"</para><para>"dlínse na hÉireann"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfIreland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfIreland</seealso>
    let JurisdictionOfIreland =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfIreland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfLatvia</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Latvia"</para><para>"Latvijas jurisdikcija"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLatvia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLatvia</seealso>
    let JurisdictionOfLatvia =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfLatvia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfLithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Lithuania"</para><para>"Lietuvos jurisdikcija"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLithuania">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLithuania</seealso>
    let JurisdictionOfLithuania =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfLithuania") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfNorway</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Norway"</para><para>"jurisdiksjon av Norge"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfNorway">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfNorway</seealso>
    let JurisdictionOfNorway =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfNorway") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:JurisdictionOfSweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Sweden"</para><para>"Sveriges jurisdiktion"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfSweden">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfSweden</seealso>
    let JurisdictionOfSweden =
        Prefixed_Name(fibo_be_ge_neuj, "JurisdictionOfSweden") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:LatvianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Latvian entity"</para><para>"Latvijas vienība"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/LatvianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/LatvianEntity</seealso>
    let LatvianEntity = Prefixed_Name(fibo_be_ge_neuj, "LatvianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:LithuanianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Lietuvos subjektas"</para><para>"Lithuanian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/LithuanianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/LithuanianEntity</seealso>
    let LithuanianEntity =
        Prefixed_Name(fibo_be_ge_neuj, "LithuanianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:NorwegianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Norsk enhet"</para><para>"Norwegian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/NorwegianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/NorwegianEntity</seealso>
    let NorwegianEntity =
        Prefixed_Name(fibo_be_ge_neuj, "NorwegianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-neuj:SwedishEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Svensk enhet"</para><para>"Swedish entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/SwedishEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/SwedishEntity</seealso>
    let SwedishEntity = Prefixed_Name(fibo_be_ge_neuj, "SwedishEntity") |> PrefixedName
