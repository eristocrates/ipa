namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.LegalEntities.DowJonesIndustrialAverageCompanies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_le_djiac =
    let _namespace_iri = Namespace_Iri fibo_exmp_le_djiac |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-exmp-le-djiac:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Dow Jones Industrial Average Companies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_le_djiac, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AlphabetInc-US-CA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///
    /// labels<para>"Alphabet Inc. US-CA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetInc-US-CA">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetInc-US-CA</seealso>
    let AlphabetInc_US_CA =
        Prefixed_Name(fibo_exmp_le_djiac, "AlphabetInc-US-CA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AlphabetIncBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Alphabet Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetIncBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetIncBusinessEntityIdentifier</seealso>
    let AlphabetIncBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_djiac, "AlphabetIncBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AlphabetIncCorporateAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Alphabet Inc. corporate address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetIncCorporateAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetIncCorporateAddress</seealso>
    let AlphabetIncCorporateAddress =
        Prefixed_Name(fibo_exmp_le_djiac, "AlphabetIncCorporateAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AlphabetIncIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Alphabet Inc. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetIncIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AlphabetIncIncorporationDate</seealso>
    let AlphabetIncIncorporationDate =
        Prefixed_Name(fibo_exmp_le_djiac, "AlphabetIncIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AppleInc-US-CA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///
    /// labels<para>"Apple Inc. US-CA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleInc-US-CA">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleInc-US-CA</seealso>
    let AppleInc_US_CA =
        Prefixed_Name(fibo_exmp_le_djiac, "AppleInc-US-CA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AppleIncBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Apple Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleIncBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleIncBusinessEntityIdentifier</seealso>
    let AppleIncBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_djiac, "AppleIncBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AppleIncCorporateAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Apple Inc. corporate address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleIncCorporateAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleIncCorporateAddress</seealso>
    let AppleIncCorporateAddress =
        Prefixed_Name(fibo_exmp_le_djiac, "AppleIncCorporateAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:AppleIncIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Apple Inc. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleIncIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/AppleIncIncorporationDate</seealso>
    let AppleIncIncorporationDate =
        Prefixed_Name(fibo_exmp_le_djiac, "AppleIncIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporation-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///
    /// labels<para>"International Business Machines Corporation US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporation-US-NY">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporation-US-NY</seealso>
    let InternationalBusinessMachinesCorporation_US_NY =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporation-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"International Business Machines Corporation address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationAddress</seealso>
    let InternationalBusinessMachinesCorporationAddress =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporationAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporationBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"International Business Machines Corporation business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessEntityIdentifier</seealso>
    let InternationalBusinessMachinesCorporationBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporationBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporationBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///
    /// labels<para>"International Business Machines Corporation Business Identifier Code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessIdentifierCode</seealso>
    let InternationalBusinessMachinesCorporationBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporationBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporationBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///
    /// labels<para>"International Business Machines Corporation business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessPartyPrefix</seealso>
    let InternationalBusinessMachinesCorporationBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporationBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporationBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///
    /// labels<para>"International Business Machines Corporation business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationBusinessPartySuffix</seealso>
    let InternationalBusinessMachinesCorporationBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporationBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:InternationalBusinessMachinesCorporationIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"International Business Machines Corporation incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/InternationalBusinessMachinesCorporationIncorporationDate</seealso>
    let InternationalBusinessMachinesCorporationIncorporationDate =
        Prefixed_Name(fibo_exmp_le_djiac, "InternationalBusinessMachinesCorporationIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompany-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Coca-Cola Company US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompany-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompany-US-DE</seealso>
    let TheCoca_ColaCompany_US_DE =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompany-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompanyBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Coca-Cola Company business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessEntityIdentifier</seealso>
    let TheCoca_ColaCompanyBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompanyBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompanyBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Coca-Cola Company business identifier code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessIdentifierCode</seealso>
    let TheCoca_ColaCompanyBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompanyBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompanyBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///
    /// labels<para>"The Coca-Cola Company business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessPartyPrefix</seealso>
    let TheCoca_ColaCompanyBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompanyBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompanyBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Coca-Cola Company business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyBusinessPartySuffix</seealso>
    let TheCoca_ColaCompanyBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompanyBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompanyCorporateAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Coca-Cola Company corporate address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyCorporateAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyCorporateAddress</seealso>
    let TheCoca_ColaCompanyCorporateAddress =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompanyCorporateAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheCoca-ColaCompanyIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Coca-Cola Company incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheCoca-ColaCompanyIncorporationDate</seealso>
    let TheCoca_ColaCompanyIncorporationDate =
        Prefixed_Name(fibo_exmp_le_djiac, "TheCoca-ColaCompanyIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheHomeDepotBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"The Home Depot, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotBusinessEntityIdentifier</seealso>
    let TheHomeDepotBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_djiac, "TheHomeDepotBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheHomeDepotInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///
    /// labels<para>"The Home Depot, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotInc-US-DE</seealso>
    let TheHomeDepotInc_US_DE =
        Prefixed_Name(fibo_exmp_le_djiac, "TheHomeDepotInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheHomeDepotIncCorporateAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"The Home Depot, Inc. corporate address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotIncCorporateAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotIncCorporateAddress</seealso>
    let TheHomeDepotIncCorporateAddress =
        Prefixed_Name(fibo_exmp_le_djiac, "TheHomeDepotIncCorporateAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheHomeDepotIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"The Home Depot, Inc. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheHomeDepotIncorporationDate</seealso>
    let TheHomeDepotIncorporationDate =
        Prefixed_Name(fibo_exmp_le_djiac, "TheHomeDepotIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompany-US-OH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company US-OH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompany-US-OH">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompany-US-OH</seealso>
    let TheProctorAndGambleCompany_US_OH =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompany-US-OH") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessEntityIdentifier</seealso>
    let TheProctorAndGambleCompanyBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company business identifier code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessIdentifierCode</seealso>
    let TheProctorAndGambleCompanyBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessPartyPrefix</seealso>
    let TheProctorAndGambleCompanyBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyBusinessPartySuffix</seealso>
    let TheProctorAndGambleCompanyBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyCorporateAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company corporate address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyCorporateAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyCorporateAddress</seealso>
    let TheProctorAndGambleCompanyCorporateAddress =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyCorporateAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyDateEstablished</seealso>
    let TheProctorAndGambleCompanyDateEstablished =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiac:TheProctorAndGambleCompanyIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Proctor &amp; Gamble Company incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/TheProctorAndGambleCompanyIncorporationDate</seealso>
    let TheProctorAndGambleCompanyIncorporationDate =
        Prefixed_Name(fibo_exmp_le_djiac, "TheProctorAndGambleCompanyIncorporationDate") |> PrefixedName
