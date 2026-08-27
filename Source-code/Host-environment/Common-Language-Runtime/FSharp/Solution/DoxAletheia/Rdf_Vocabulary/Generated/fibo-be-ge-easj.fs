namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.AsianJurisdiction.EasternAsiaGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_easj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_easj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-easj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Eastern Asia Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_easj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfJapan</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"日本国"</para><para>"Government of Japan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfJapan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfJapan</seealso>
    let GovernmentOfJapan =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfJapan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfMongolia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Монгол Улс"</para><para>"Government of Mongolia"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfMongolia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfMongolia</seealso>
    let GovernmentOfMongolia =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfMongolia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfTheDemocraticPeoplesRepublicOfKorea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Democratic People's Republic of Korea"</para><para>"조선민주주의인민공화국"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheDemocraticPeoplesRepublicOfKorea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheDemocraticPeoplesRepublicOfKorea</seealso>
    let GovernmentOfTheDemocraticPeoplesRepublicOfKorea =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfTheDemocraticPeoplesRepublicOfKorea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"中華人民共和國香港特別行政區"</para><para>"Government of the Hong Kong Special Administrative Region of the People's Republic of China"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina</seealso>
    let GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"Government of the Macao Special Administrative Region of the People's Republic of China"</para><para>"中華人民共和國澳門特別行政區"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina</seealso>
    let GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfThePeoplesRepublicOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the People's Republic of China"</para><para>"中华人民共和国"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfThePeoplesRepublicOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfThePeoplesRepublicOfChina</seealso>
    let GovernmentOfThePeoplesRepublicOfChina =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfThePeoplesRepublicOfChina") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfTheRepublicOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"中華民國"</para><para>"Government of the Republic of China"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfChina</seealso>
    let GovernmentOfTheRepublicOfChina =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfTheRepublicOfChina") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:GovernmentOfTheRepublicOfKorea</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"대한민국"</para><para>"Government of the Republic of Korea"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfKorea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfKorea</seealso>
    let GovernmentOfTheRepublicOfKorea =
        Prefixed_Name(fibo_be_ge_easj, "GovernmentOfTheRepublicOfKorea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of China"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfChina</seealso>
    let JurisdictionOfChina =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfChina") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfHongKong</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Hong Kong"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfHongKong">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfHongKong</seealso>
    let JurisdictionOfHongKong =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfHongKong") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfJapan</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Japan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfJapan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfJapan</seealso>
    let JurisdictionOfJapan =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfJapan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfMacao</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Macao"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfMacao">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfMacao</seealso>
    let JurisdictionOfMacao =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfMacao") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfMongolia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Mongolia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfMongolia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfMongolia</seealso>
    let JurisdictionOfMongolia =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfMongolia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfTheDemocraticPeoplesRepublicOfKorea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of the Democratic People's Republic of Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfTheDemocraticPeoplesRepublicOfKorea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfTheDemocraticPeoplesRepublicOfKorea</seealso>
    let JurisdictionOfTheDemocraticPeoplesRepublicOfKorea =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfTheDemocraticPeoplesRepublicOfKorea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfTheRepublicOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of the Republic of China"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfTheRepublicOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfTheRepublicOfChina</seealso>
    let JurisdictionOfTheRepublicOfChina =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfTheRepublicOfChina") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:JurisdictionOfTheRepublicOfKorea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of the Republic of Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfTheRepublicOfKorea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/JurisdictionOfTheRepublicOfKorea</seealso>
    let JurisdictionOfTheRepublicOfKorea =
        Prefixed_Name(fibo_be_ge_easj, "JurisdictionOfTheRepublicOfKorea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:RegionalStateOfHongKong</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"regional state of Hong Kong"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/RegionalStateOfHongKong">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/RegionalStateOfHongKong</seealso>
    let RegionalStateOfHongKong =
        Prefixed_Name(fibo_be_ge_easj, "RegionalStateOfHongKong") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:RegionalStateOfMacao</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"regional state of Macao"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/RegionalStateOfMacao">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/RegionalStateOfMacao</seealso>
    let RegionalStateOfMacao =
        Prefixed_Name(fibo_be_ge_easj, "RegionalStateOfMacao") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:StateOfChina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"state of China"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfChina">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfChina</seealso>
    let StateOfChina = Prefixed_Name(fibo_be_ge_easj, "StateOfChina") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-easj:StateOfJapan</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"state of Japan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfJapan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfJapan</seealso>
    let StateOfJapan = Prefixed_Name(fibo_be_ge_easj, "StateOfJapan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:StateOfMongolia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"state of Mongolia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfMongolia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfMongolia</seealso>
    let StateOfMongolia =
        Prefixed_Name(fibo_be_ge_easj, "StateOfMongolia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:StateOfNorthKorea</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"state of North Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfNorthKorea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfNorthKorea</seealso>
    let StateOfNorthKorea =
        Prefixed_Name(fibo_be_ge_easj, "StateOfNorthKorea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:StateOfSouthKorea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"state of South Korea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfSouthKorea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfSouthKorea</seealso>
    let StateOfSouthKorea =
        Prefixed_Name(fibo_be_ge_easj, "StateOfSouthKorea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-easj:StateOfTaiwan</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"regional state of Taiwan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfTaiwan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/StateOfTaiwan</seealso>
    let StateOfTaiwan = Prefixed_Name(fibo_be_ge_easj, "StateOfTaiwan") |> PrefixedName
