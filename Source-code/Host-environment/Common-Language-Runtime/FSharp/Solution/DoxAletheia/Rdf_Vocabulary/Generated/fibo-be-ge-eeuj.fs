namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.EasternEuropeGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_eeuj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_eeuj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-eeuj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Eastern Europe Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_eeuj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:BelarusianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Беларускае ўтварэнне"</para><para>"Belarusian entity"</para><para>"Белорусское предприятие"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/BelarusianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/BelarusianEntity</seealso>
    let BelarusianEntity =
        Prefixed_Name(fibo_be_ge_eeuj, "BelarusianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:BulgarianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Българско образувание"</para><para>"Bulgarian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/BulgarianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/BulgarianEntity</seealso>
    let BulgarianEntity =
        Prefixed_Name(fibo_be_ge_eeuj, "BulgarianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:CzechEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Czech entity"</para><para>"Český subjekt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/CzechEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/CzechEntity</seealso>
    let CzechEntity = Prefixed_Name(fibo_be_ge_eeuj, "CzechEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfHungary</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Magyarország kormánya"</para><para>"Government of Hungary"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfHungary">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfHungary</seealso>
    let GovernmentOfHungary =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfHungary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfRomania</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of Romania"</para><para>"Guvernul României"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfRomania">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfRomania</seealso>
    let GovernmentOfRomania =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfRomania") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheCzechRepublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Czech Republic"</para><para>"Vláda České republiky"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheCzechRepublic">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheCzechRepublic</seealso>
    let GovernmentOfTheCzechRepublic =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheCzechRepublic") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheRepublicOfBelarus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Republic of Belarus"</para><para>"Урад Рэспублікі Беларусь"</para><para>"Правительство Республики Беларусь"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfBelarus">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfBelarus</seealso>
    let GovernmentOfTheRepublicOfBelarus =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheRepublicOfBelarus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheRepublicOfBulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Republic of Bulgaria"</para><para>"Правителство на Република България"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfBulgaria">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfBulgaria</seealso>
    let GovernmentOfTheRepublicOfBulgaria =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheRepublicOfBulgaria") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheRepublicOfMoldova</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Republic of Moldova"</para><para>"Guvernul Republicii Moldova"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfMoldova">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfMoldova</seealso>
    let GovernmentOfTheRepublicOfMoldova =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheRepublicOfMoldova") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheRepublicOfPoland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Rząd Rzeczpospolita Polska"</para><para>"Government of the Republic of Poland"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfPoland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfPoland</seealso>
    let GovernmentOfTheRepublicOfPoland =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheRepublicOfPoland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheRussianFederation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///
    /// labels<para>"Правительство Российской Федерации"</para><para>"Government of the Russian Federation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRussianFederation">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRussianFederation</seealso>
    let GovernmentOfTheRussianFederation =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheRussianFederation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfTheSlovakRepublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Slovak Republic"</para><para>"Vláda Slovenskej republiky"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheSlovakRepublic">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheSlovakRepublic</seealso>
    let GovernmentOfTheSlovakRepublic =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfTheSlovakRepublic") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:GovernmentOfUkraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Уряд України"</para><para>"Government of Ukraine"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfUkraine">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfUkraine</seealso>
    let GovernmentOfUkraine =
        Prefixed_Name(fibo_be_ge_eeuj, "GovernmentOfUkraine") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:HungarianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Magyar entitás"</para><para>"Hungarian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/HungarianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/HungarianEntity</seealso>
    let HungarianEntity =
        Prefixed_Name(fibo_be_ge_eeuj, "HungarianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfBelarus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"юрысдыкцыя Беларусі"</para><para>"юрисдикция Беларуси"</para><para>"jurisdiction of Belarus"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfBelarus">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfBelarus</seealso>
    let JurisdictionOfBelarus =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfBelarus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfBulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Bulgaria"</para><para>"юрисдикция на България"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfBulgaria">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfBulgaria</seealso>
    let JurisdictionOfBulgaria =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfBulgaria") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfCzechia</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Czechia"</para><para>"jurisdikce česka"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfCzechia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfCzechia</seealso>
    let JurisdictionOfCzechia =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfCzechia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfHungary</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Hungary"</para><para>"Magyarország joghatósága"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfHungary">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfHungary</seealso>
    let JurisdictionOfHungary =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfHungary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfMoldova</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Moldova"</para><para>"jurisdicția Moldovei"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfMoldova">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfMoldova</seealso>
    let JurisdictionOfMoldova =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfMoldova") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfPoland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurysdykcja Polski"</para><para>"jurisdiction of Poland"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfPoland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfPoland</seealso>
    let JurisdictionOfPoland =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfPoland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfRomania</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdicția României"</para><para>"jurisdiction of Romania"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfRomania">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfRomania</seealso>
    let JurisdictionOfRomania =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfRomania") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfRussianFederation</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Russian Federation"</para><para>"юрисдикция Российской Федерации"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfRussianFederation">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfRussianFederation</seealso>
    let JurisdictionOfRussianFederation =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfRussianFederation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfSlovakia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Slovakia"</para><para>"jurisdikcia Slovenska"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfSlovakia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfSlovakia</seealso>
    let JurisdictionOfSlovakia =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfSlovakia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:JurisdictionOfUkraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Ukraine"</para><para>"юрисдикція України"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfUkraine">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfUkraine</seealso>
    let JurisdictionOfUkraine =
        Prefixed_Name(fibo_be_ge_eeuj, "JurisdictionOfUkraine") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:MoldovanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Entitate moldovenească"</para><para>"Moldovan entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/MoldovanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/MoldovanEntity</seealso>
    let MoldovanEntity =
        Prefixed_Name(fibo_be_ge_eeuj, "MoldovanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:PolishEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Polish entity"</para><para>"Podmiot polski"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/PolishEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/PolishEntity</seealso>
    let PolishEntity = Prefixed_Name(fibo_be_ge_eeuj, "PolishEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:RomanianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Entitate românească"</para><para>"Romanian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/RomanianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/RomanianEntity</seealso>
    let RomanianEntity =
        Prefixed_Name(fibo_be_ge_eeuj, "RomanianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:RussianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"Российское предприятие"</para><para>"Russian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/RussianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/RussianEntity</seealso>
    let RussianEntity = Prefixed_Name(fibo_be_ge_eeuj, "RussianEntity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-eeuj:SlovakEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Slovak entity"</para><para>"Slovenský subjekt"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/SlovakEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/SlovakEntity</seealso>
    let SlovakEntity = Prefixed_Name(fibo_be_ge_eeuj, "SlovakEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-eeuj:UkranianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Українське утворення"</para><para>"Ukrainian entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/UkranianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/UkranianEntity</seealso>
    let UkranianEntity =
        Prefixed_Name(fibo_be_ge_eeuj, "UkranianEntity") |> PrefixedName
