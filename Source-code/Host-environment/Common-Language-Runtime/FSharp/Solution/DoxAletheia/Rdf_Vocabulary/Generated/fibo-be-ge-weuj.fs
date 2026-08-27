namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.WesternEuropeGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_weuj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_weuj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-weuj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Western Europe Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_weuj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:AustrianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"Austrian entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/AustrianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/AustrianEntity</seealso>
    let AustrianEntity =
        Prefixed_Name(fibo_be_ge_weuj, "AustrianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:BelgianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"Belgian entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/BelgianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/BelgianEntity</seealso>
    let BelgianEntity = Prefixed_Name(fibo_be_ge_weuj, "BelgianEntity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-weuj:FrenchEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"French entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/FrenchEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/FrenchEntity</seealso>
    let FrenchEntity = Prefixed_Name(fibo_be_ge_weuj, "FrenchEntity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-weuj:GermanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"German entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GermanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GermanEntity</seealso>
    let GermanEntity = Prefixed_Name(fibo_be_ge_weuj, "GermanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheFederalRepublicOfGermany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///
    /// labels<para>"Government of the Federal Republic of Germany"</para><para>"Bundesrepublik Deutschland"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheFederalRepublicOfGermany">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheFederalRepublicOfGermany</seealso>
    let GovernmentOfTheFederalRepublicOfGermany =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheFederalRepublicOfGermany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheFrenchRepublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Gouvernement de la République française"</para><para>"Government of the French Republic"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheFrenchRepublic">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheFrenchRepublic</seealso>
    let GovernmentOfTheFrenchRepublic =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheFrenchRepublic") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheGrandDuchyOfLuxembourg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Grand Duchy of Luxembourg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheGrandDuchyOfLuxembourg">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheGrandDuchyOfLuxembourg</seealso>
    let GovernmentOfTheGrandDuchyOfLuxembourg =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheGrandDuchyOfLuxembourg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheKingdomOfBelgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///
    /// labels<para>"Government of the Kingdom of Belgium"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfBelgium">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheKingdomOfBelgium</seealso>
    let GovernmentOfTheKingdomOfBelgium =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheKingdomOfBelgium") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheNetherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Netherlands"</para><para>"Rijksoverheid"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheNetherlands">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheNetherlands</seealso>
    let GovernmentOfTheNetherlands =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheNetherlands") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfThePrincipalityOfLiechtenstein</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Principality of Liechtenstein"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfThePrincipalityOfLiechtenstein">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfThePrincipalityOfLiechtenstein</seealso>
    let GovernmentOfThePrincipalityOfLiechtenstein =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfThePrincipalityOfLiechtenstein") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfThePrincipalityOfMonaco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    ///
    /// labels<para>"Government of the Principality of Monaco"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfThePrincipalityOfMonaco">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfThePrincipalityOfMonaco</seealso>
    let GovernmentOfThePrincipalityOfMonaco =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfThePrincipalityOfMonaco") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheRepublicOfAustria</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of the Republic of Austria"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfAustria">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheRepublicOfAustria</seealso>
    let GovernmentOfTheRepublicOfAustria =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheRepublicOfAustria") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:GovernmentOfTheSwissConfederation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///
    /// labels<para>"Government of the Swiss Confederation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheSwissConfederation">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/GovernmentOfTheSwissConfederation</seealso>
    let GovernmentOfTheSwissConfederation =
        Prefixed_Name(fibo_be_ge_weuj, "GovernmentOfTheSwissConfederation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfAustria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Austria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfAustria">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfAustria</seealso>
    let JurisdictionOfAustria =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfAustria") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfBelgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Belgium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfBelgium">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfBelgium</seealso>
    let JurisdictionOfBelgium =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfBelgium") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfFrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of France"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfFrance">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfFrance</seealso>
    let JurisdictionOfFrance =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfFrance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfGermany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"German jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfGermany">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfGermany</seealso>
    let JurisdictionOfGermany =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfGermany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfLiechtenstein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Liechtenstein"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLiechtenstein">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLiechtenstein</seealso>
    let JurisdictionOfLiechtenstein =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfLiechtenstein") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfLuxembourg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"jurisdiction of Luxembourg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLuxembourg">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfLuxembourg</seealso>
    let JurisdictionOfLuxembourg =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfLuxembourg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfMonaco</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Monaco"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfMonaco">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfMonaco</seealso>
    let JurisdictionOfMonaco =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfMonaco") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfSwitzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of Switzerland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfSwitzerland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfSwitzerland</seealso>
    let JurisdictionOfSwitzerland =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfSwitzerland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:JurisdictionOfTheNetherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"jurisdiction of the Netherlands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfTheNetherlands">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/JurisdictionOfTheNetherlands</seealso>
    let JurisdictionOfTheNetherlands =
        Prefixed_Name(fibo_be_ge_weuj, "JurisdictionOfTheNetherlands") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:LiechtensteinerEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Liechtensteiner entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/LiechtensteinerEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/LiechtensteinerEntity</seealso>
    let LiechtensteinerEntity =
        Prefixed_Name(fibo_be_ge_weuj, "LiechtensteinerEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:LuxembourgerEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Luxembourger entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/LuxembourgerEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/LuxembourgerEntity</seealso>
    let LuxembourgerEntity =
        Prefixed_Name(fibo_be_ge_weuj, "LuxembourgerEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:MonegasqueEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Monegasque entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/MonegasqueEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/MonegasqueEntity</seealso>
    let MonegasqueEntity =
        Prefixed_Name(fibo_be_ge_weuj, "MonegasqueEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:NetherlandsEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    ///
    /// labels<para>"Netherlands entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/NetherlandsEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/NetherlandsEntity</seealso>
    let NetherlandsEntity =
        Prefixed_Name(fibo_be_ge_weuj, "NetherlandsEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-weuj:SwissEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"Swiss entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/SwissEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/SwissEntity</seealso>
    let SwissEntity = Prefixed_Name(fibo_be_ge_weuj, "SwissEntity") |> PrefixedName
