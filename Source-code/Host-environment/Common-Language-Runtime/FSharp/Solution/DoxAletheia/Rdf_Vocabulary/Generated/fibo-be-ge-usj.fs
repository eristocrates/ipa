namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.NorthAmericanJurisdiction.USGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_usj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_usj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-usj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"US Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_usj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:AmericanSamoaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"American Samoa entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/AmericanSamoaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/AmericanSamoaEntity</seealso>
    let AmericanSamoaEntity =
        Prefixed_Name(fibo_be_ge_usj, "AmericanSamoaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:AmericanSamoaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"American Samoa jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/AmericanSamoaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/AmericanSamoaJurisdiction</seealso>
    let AmericanSamoaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "AmericanSamoaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:CommonwealthOfPuertoRicoEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Commonwealth of Puerto Rico entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/CommonwealthOfPuertoRicoEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/CommonwealthOfPuertoRicoEntity</seealso>
    let CommonwealthOfPuertoRicoEntity =
        Prefixed_Name(fibo_be_ge_usj, "CommonwealthOfPuertoRicoEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:CommonwealthOfTheNorthernMarianaIslandsEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Commonwealth of the Northern Mariana Islands entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/CommonwealthOfTheNorthernMarianaIslandsEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/CommonwealthOfTheNorthernMarianaIslandsEntity</seealso>
    let CommonwealthOfTheNorthernMarianaIslandsEntity =
        Prefixed_Name(fibo_be_ge_usj, "CommonwealthOfTheNorthernMarianaIslandsEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:DistrictOfColumbiaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"District of Columbia entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/DistrictOfColumbiaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/DistrictOfColumbiaEntity</seealso>
    let DistrictOfColumbiaEntity =
        Prefixed_Name(fibo_be_ge_usj, "DistrictOfColumbiaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:DistrictOfColumbiaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"District of Columbia government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/DistrictOfColumbiaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/DistrictOfColumbiaGovernment</seealso>
    let DistrictOfColumbiaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "DistrictOfColumbiaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:DistrictOfColumbiaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"District of Columbia jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/DistrictOfColumbiaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/DistrictOfColumbiaJurisdiction</seealso>
    let DistrictOfColumbiaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "DistrictOfColumbiaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GovernmentOfAmericanSamoa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of American Samoa"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfAmericanSamoa">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfAmericanSamoa</seealso>
    let GovernmentOfAmericanSamoa =
        Prefixed_Name(fibo_be_ge_usj, "GovernmentOfAmericanSamoa") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GovernmentOfGuam</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of Guam"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfGuam">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfGuam</seealso>
    let GovernmentOfGuam =
        Prefixed_Name(fibo_be_ge_usj, "GovernmentOfGuam") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GovernmentOfNorthernMarianaIslands</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of the Northern Mariana Islands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfNorthernMarianaIslands">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfNorthernMarianaIslands</seealso>
    let GovernmentOfNorthernMarianaIslands =
        Prefixed_Name(fibo_be_ge_usj, "GovernmentOfNorthernMarianaIslands") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GovernmentOfPuertoRico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Puerto Rico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfPuertoRico">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfPuertoRico</seealso>
    let GovernmentOfPuertoRico =
        Prefixed_Name(fibo_be_ge_usj, "GovernmentOfPuertoRico") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GovernmentOfVirginIslands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of the Virgin Islands (USA)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfVirginIslands">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GovernmentOfVirginIslands</seealso>
    let GovernmentOfVirginIslands =
        Prefixed_Name(fibo_be_ge_usj, "GovernmentOfVirginIslands") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GuamEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guam entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GuamEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GuamEntity</seealso>
    let GuamEntity = Prefixed_Name(fibo_be_ge_usj, "GuamEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:GuamJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guam jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GuamJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/GuamJurisdiction</seealso>
    let GuamJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "GuamJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:NorthernMarianaIslandsJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Northern Mariana Islands jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/NorthernMarianaIslandsJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/NorthernMarianaIslandsJurisdiction</seealso>
    let NorthernMarianaIslandsJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "NorthernMarianaIslandsJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:PuertoRicoJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Puerto Rico jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/PuertoRicoJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/PuertoRicoJurisdiction</seealso>
    let PuertoRicoJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "PuertoRicoJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfAlabamaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Alabama entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlabamaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlabamaEntity</seealso>
    let StateOfAlabamaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfAlabamaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfAlabamaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Alabama government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlabamaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlabamaGovernment</seealso>
    let StateOfAlabamaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfAlabamaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfAlabamaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Alabama jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlabamaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlabamaJurisdiction</seealso>
    let StateOfAlabamaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfAlabamaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfAlaskaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Alaska entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlaskaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlaskaEntity</seealso>
    let StateOfAlaskaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfAlaskaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfAlaskaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Alaska government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlaskaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlaskaGovernment</seealso>
    let StateOfAlaskaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfAlaskaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfAlaskaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Alaska jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlaskaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfAlaskaJurisdiction</seealso>
    let StateOfAlaskaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfAlaskaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfArizonaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Arizona entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArizonaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArizonaEntity</seealso>
    let StateOfArizonaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfArizonaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfArizonaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Arizona government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArizonaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArizonaGovernment</seealso>
    let StateOfArizonaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfArizonaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfArizonaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Arizona jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArizonaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArizonaJurisdiction</seealso>
    let StateOfArizonaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfArizonaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfArkansasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Arkansas entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArkansasEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArkansasEntity</seealso>
    let StateOfArkansasEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfArkansasEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfArkansasGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Arkansas government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArkansasGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArkansasGovernment</seealso>
    let StateOfArkansasGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfArkansasGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfArkansasJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Arkansas jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArkansasJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfArkansasJurisdiction</seealso>
    let StateOfArkansasJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfArkansasJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfCaliforniaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of California entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfCaliforniaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfCaliforniaEntity</seealso>
    let StateOfCaliforniaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfCaliforniaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfCaliforniaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of California government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfCaliforniaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfCaliforniaGovernment</seealso>
    let StateOfCaliforniaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfCaliforniaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfCaliforniaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of California jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfCaliforniaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfCaliforniaJurisdiction</seealso>
    let StateOfCaliforniaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfCaliforniaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfColoradoEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Colorado entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfColoradoEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfColoradoEntity</seealso>
    let StateOfColoradoEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfColoradoEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfColoradoGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Colorado government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfColoradoGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfColoradoGovernment</seealso>
    let StateOfColoradoGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfColoradoGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfColoradoJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Colorado jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfColoradoJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfColoradoJurisdiction</seealso>
    let StateOfColoradoJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfColoradoJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfConnecticutEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Connecticut entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfConnecticutEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfConnecticutEntity</seealso>
    let StateOfConnecticutEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfConnecticutEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfConnecticutGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Connecticut government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfConnecticutGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfConnecticutGovernment</seealso>
    let StateOfConnecticutGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfConnecticutGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfConnecticutJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Connecticut jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfConnecticutJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfConnecticutJurisdiction</seealso>
    let StateOfConnecticutJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfConnecticutJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfDelawareEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Delaware entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfDelawareEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfDelawareEntity</seealso>
    let StateOfDelawareEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfDelawareEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfDelawareGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Delaware government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfDelawareGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfDelawareGovernment</seealso>
    let StateOfDelawareGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfDelawareGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfDelawareJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Delaware jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfDelawareJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfDelawareJurisdiction</seealso>
    let StateOfDelawareJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfDelawareJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfFloridaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Florida entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfFloridaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfFloridaEntity</seealso>
    let StateOfFloridaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfFloridaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfFloridaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Florida government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfFloridaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfFloridaGovernment</seealso>
    let StateOfFloridaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfFloridaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfFloridaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Florida jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfFloridaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfFloridaJurisdiction</seealso>
    let StateOfFloridaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfFloridaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfGeorgiaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Georgia entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfGeorgiaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfGeorgiaEntity</seealso>
    let StateOfGeorgiaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfGeorgiaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfGeorgiaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Georgia government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfGeorgiaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfGeorgiaGovernment</seealso>
    let StateOfGeorgiaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfGeorgiaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfGeorgiaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Georgia jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfGeorgiaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfGeorgiaJurisdiction</seealso>
    let StateOfGeorgiaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfGeorgiaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfHawaiiEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Hawai'i entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfHawaiiEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfHawaiiEntity</seealso>
    let StateOfHawaiiEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfHawaiiEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfHawaiiGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Hawai'i government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfHawaiiGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfHawaiiGovernment</seealso>
    let StateOfHawaiiGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfHawaiiGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfHawaiiJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Hawai'i jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfHawaiiJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfHawaiiJurisdiction</seealso>
    let StateOfHawaiiJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfHawaiiJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIdahoEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Idaho entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIdahoEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIdahoEntity</seealso>
    let StateOfIdahoEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIdahoEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIdahoGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Idaho government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIdahoGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIdahoGovernment</seealso>
    let StateOfIdahoGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIdahoGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIdahoJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Idaho jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIdahoJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIdahoJurisdiction</seealso>
    let StateOfIdahoJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIdahoJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIllinoisEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Illinois entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIllinoisEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIllinoisEntity</seealso>
    let StateOfIllinoisEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIllinoisEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIllinoisGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Illinois government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIllinoisGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIllinoisGovernment</seealso>
    let StateOfIllinoisGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIllinoisGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIllinoisJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Illinois jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIllinoisJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIllinoisJurisdiction</seealso>
    let StateOfIllinoisJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIllinoisJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIndianaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Indiana entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIndianaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIndianaEntity</seealso>
    let StateOfIndianaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIndianaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIndianaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Indiana government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIndianaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIndianaGovernment</seealso>
    let StateOfIndianaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIndianaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIndianaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Indiana jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIndianaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIndianaJurisdiction</seealso>
    let StateOfIndianaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIndianaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIowaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Iowa entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIowaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIowaEntity</seealso>
    let StateOfIowaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIowaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIowaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Iowa government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIowaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIowaGovernment</seealso>
    let StateOfIowaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIowaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfIowaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Iowa jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIowaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfIowaJurisdiction</seealso>
    let StateOfIowaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfIowaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfKansasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Kansas entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKansasEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKansasEntity</seealso>
    let StateOfKansasEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfKansasEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfKansasGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Kansas government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKansasGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKansasGovernment</seealso>
    let StateOfKansasGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfKansasGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfKansasJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Kansas jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKansasJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKansasJurisdiction</seealso>
    let StateOfKansasJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfKansasJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfKentuckyEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Kentucky entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKentuckyEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKentuckyEntity</seealso>
    let StateOfKentuckyEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfKentuckyEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfKentuckyGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Kentucky government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKentuckyGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKentuckyGovernment</seealso>
    let StateOfKentuckyGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfKentuckyGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfKentuckyJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Kentucky jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKentuckyJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfKentuckyJurisdiction</seealso>
    let StateOfKentuckyJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfKentuckyJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfLouisianaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Louisiana entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfLouisianaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfLouisianaEntity</seealso>
    let StateOfLouisianaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfLouisianaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfLouisianaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Louisiana government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfLouisianaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfLouisianaGovernment</seealso>
    let StateOfLouisianaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfLouisianaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfLouisianaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Louisiana jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfLouisianaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfLouisianaJurisdiction</seealso>
    let StateOfLouisianaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfLouisianaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMaineEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Maine entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMaineEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMaineEntity</seealso>
    let StateOfMaineEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMaineEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMaineGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Maine government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMaineGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMaineGovernment</seealso>
    let StateOfMaineGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMaineGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMaineJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Maine jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMaineJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMaineJurisdiction</seealso>
    let StateOfMaineJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMaineJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMarylandEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Maryland entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMarylandEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMarylandEntity</seealso>
    let StateOfMarylandEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMarylandEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMarylandGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Maryland government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMarylandGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMarylandGovernment</seealso>
    let StateOfMarylandGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMarylandGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMarylandJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Maryland jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMarylandJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMarylandJurisdiction</seealso>
    let StateOfMarylandJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMarylandJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMassachusettsEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Massachusetts entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMassachusettsEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMassachusettsEntity</seealso>
    let StateOfMassachusettsEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMassachusettsEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMassachusettsGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Massachusetts government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMassachusettsGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMassachusettsGovernment</seealso>
    let StateOfMassachusettsGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMassachusettsGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMassachusettsJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Massachusetts jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMassachusettsJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMassachusettsJurisdiction</seealso>
    let StateOfMassachusettsJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMassachusettsJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMichiganEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Michigan entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMichiganEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMichiganEntity</seealso>
    let StateOfMichiganEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMichiganEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMichiganGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Michigan government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMichiganGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMichiganGovernment</seealso>
    let StateOfMichiganGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMichiganGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMichiganJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Michigan jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMichiganJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMichiganJurisdiction</seealso>
    let StateOfMichiganJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMichiganJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMinnesotaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Minnesota entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMinnesotaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMinnesotaEntity</seealso>
    let StateOfMinnesotaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMinnesotaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMinnesotaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Minnesota government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMinnesotaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMinnesotaGovernment</seealso>
    let StateOfMinnesotaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMinnesotaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMinnesotaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Minnesota jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMinnesotaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMinnesotaJurisdiction</seealso>
    let StateOfMinnesotaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMinnesotaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMississippiEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Mississippi entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMississippiEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMississippiEntity</seealso>
    let StateOfMississippiEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMississippiEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMississippiGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Mississippi government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMississippiGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMississippiGovernment</seealso>
    let StateOfMississippiGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMississippiGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMississippiJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Mississippi jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMississippiJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMississippiJurisdiction</seealso>
    let StateOfMississippiJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMississippiJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMissouriEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Missouri entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMissouriEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMissouriEntity</seealso>
    let StateOfMissouriEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMissouriEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMissouriGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Missouri government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMissouriGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMissouriGovernment</seealso>
    let StateOfMissouriGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMissouriGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMissouriJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Missouri jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMissouriJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMissouriJurisdiction</seealso>
    let StateOfMissouriJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMissouriJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMontanaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Montana entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMontanaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMontanaEntity</seealso>
    let StateOfMontanaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMontanaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMontanaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Montana government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMontanaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMontanaGovernment</seealso>
    let StateOfMontanaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMontanaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfMontanaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Montana jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMontanaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfMontanaJurisdiction</seealso>
    let StateOfMontanaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfMontanaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNebraskaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Nebraska entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNebraskaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNebraskaEntity</seealso>
    let StateOfNebraskaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNebraskaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNebraskaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Nebraska government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNebraskaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNebraskaGovernment</seealso>
    let StateOfNebraskaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNebraskaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNebraskaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Nebraska jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNebraskaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNebraskaJurisdiction</seealso>
    let StateOfNebraskaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNebraskaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNevadaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Nevada entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNevadaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNevadaEntity</seealso>
    let StateOfNevadaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNevadaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNevadaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Nevada government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNevadaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNevadaGovernment</seealso>
    let StateOfNevadaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNevadaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNevadaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Nevada jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNevadaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNevadaJurisdiction</seealso>
    let StateOfNevadaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNevadaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewHampshireEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of New Hampshire entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewHampshireEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewHampshireEntity</seealso>
    let StateOfNewHampshireEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewHampshireEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewHampshireGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of New Hampshire government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewHampshireGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewHampshireGovernment</seealso>
    let StateOfNewHampshireGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewHampshireGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewHampshireJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of New Hampshire jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewHampshireJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewHampshireJurisdiction</seealso>
    let StateOfNewHampshireJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewHampshireJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewJerseyEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of New Jersey entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewJerseyEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewJerseyEntity</seealso>
    let StateOfNewJerseyEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewJerseyEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewJerseyGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of New Jersey government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewJerseyGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewJerseyGovernment</seealso>
    let StateOfNewJerseyGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewJerseyGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewJerseyJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of New Jersey jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewJerseyJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewJerseyJurisdiction</seealso>
    let StateOfNewJerseyJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewJerseyJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewMexicoEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of New Mexico entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewMexicoEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewMexicoEntity</seealso>
    let StateOfNewMexicoEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewMexicoEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewMexicoGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of New Mexico government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewMexicoGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewMexicoGovernment</seealso>
    let StateOfNewMexicoGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewMexicoGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewMexicoJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of New Mexico jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewMexicoJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewMexicoJurisdiction</seealso>
    let StateOfNewMexicoJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewMexicoJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewYorkEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of New York entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewYorkEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewYorkEntity</seealso>
    let StateOfNewYorkEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewYorkEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewYorkGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of New York government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewYorkGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewYorkGovernment</seealso>
    let StateOfNewYorkGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewYorkGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNewYorkJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of New York jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewYorkJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNewYorkJurisdiction</seealso>
    let StateOfNewYorkJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNewYorkJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNorthCarolinaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of North Carolina entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthCarolinaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthCarolinaEntity</seealso>
    let StateOfNorthCarolinaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNorthCarolinaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNorthCarolinaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of North Carolina government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthCarolinaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthCarolinaGovernment</seealso>
    let StateOfNorthCarolinaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNorthCarolinaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNorthCarolinaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of North Carolina jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthCarolinaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthCarolinaJurisdiction</seealso>
    let StateOfNorthCarolinaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNorthCarolinaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNorthDakotaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of North Dakota entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthDakotaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthDakotaEntity</seealso>
    let StateOfNorthDakotaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNorthDakotaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNorthDakotaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of North Dakota government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthDakotaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthDakotaGovernment</seealso>
    let StateOfNorthDakotaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNorthDakotaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfNorthDakotaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of North Dakota jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthDakotaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfNorthDakotaJurisdiction</seealso>
    let StateOfNorthDakotaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfNorthDakotaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOhioEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Ohio entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOhioEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOhioEntity</seealso>
    let StateOfOhioEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOhioEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOhioGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Ohio government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOhioGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOhioGovernment</seealso>
    let StateOfOhioGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOhioGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOhioJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Ohio jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOhioJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOhioJurisdiction</seealso>
    let StateOfOhioJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOhioJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOklahomaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Oklahoma entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOklahomaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOklahomaEntity</seealso>
    let StateOfOklahomaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOklahomaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOklahomaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Oklahoma government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOklahomaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOklahomaGovernment</seealso>
    let StateOfOklahomaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOklahomaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOklahomaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Oklahoma jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOklahomaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOklahomaJurisdiction</seealso>
    let StateOfOklahomaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOklahomaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOregonEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Oregon entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOregonEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOregonEntity</seealso>
    let StateOfOregonEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOregonEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOregonGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Oregon government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOregonGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOregonGovernment</seealso>
    let StateOfOregonGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOregonGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfOregonJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Oregon jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOregonJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfOregonJurisdiction</seealso>
    let StateOfOregonJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfOregonJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfPennsylvaniaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Pennsylvania entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfPennsylvaniaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfPennsylvaniaEntity</seealso>
    let StateOfPennsylvaniaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfPennsylvaniaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfPennsylvaniaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Pennsylvania government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfPennsylvaniaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfPennsylvaniaGovernment</seealso>
    let StateOfPennsylvaniaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfPennsylvaniaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfPennsylvaniaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Pennsylvania jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfPennsylvaniaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfPennsylvaniaJurisdiction</seealso>
    let StateOfPennsylvaniaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfPennsylvaniaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfRhodeIslandEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Rhode Island entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfRhodeIslandEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfRhodeIslandEntity</seealso>
    let StateOfRhodeIslandEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfRhodeIslandEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfRhodeIslandGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Rhode Island government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfRhodeIslandGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfRhodeIslandGovernment</seealso>
    let StateOfRhodeIslandGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfRhodeIslandGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfRhodeIslandJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Rhode Island jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfRhodeIslandJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfRhodeIslandJurisdiction</seealso>
    let StateOfRhodeIslandJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfRhodeIslandJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfSouthCarolinaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of South Carolina entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthCarolinaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthCarolinaEntity</seealso>
    let StateOfSouthCarolinaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfSouthCarolinaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfSouthCarolinaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of South Carolina government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthCarolinaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthCarolinaGovernment</seealso>
    let StateOfSouthCarolinaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfSouthCarolinaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfSouthCarolinaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of South Carolina jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthCarolinaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthCarolinaJurisdiction</seealso>
    let StateOfSouthCarolinaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfSouthCarolinaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfSouthDakotaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of South Dakota entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthDakotaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthDakotaEntity</seealso>
    let StateOfSouthDakotaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfSouthDakotaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfSouthDakotaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of South Dakota government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthDakotaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthDakotaGovernment</seealso>
    let StateOfSouthDakotaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfSouthDakotaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfSouthDakotaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of South Dakota jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthDakotaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfSouthDakotaJurisdiction</seealso>
    let StateOfSouthDakotaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfSouthDakotaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfTennesseeEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Tennessee entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTennesseeEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTennesseeEntity</seealso>
    let StateOfTennesseeEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfTennesseeEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfTennesseeGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Tennessee government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTennesseeGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTennesseeGovernment</seealso>
    let StateOfTennesseeGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfTennesseeGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfTennesseeJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Tennessee jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTennesseeJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTennesseeJurisdiction</seealso>
    let StateOfTennesseeJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfTennesseeJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfTexasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Texas entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTexasEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTexasEntity</seealso>
    let StateOfTexasEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfTexasEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfTexasGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Texas government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTexasGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTexasGovernment</seealso>
    let StateOfTexasGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfTexasGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfTexasJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Texas jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTexasJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfTexasJurisdiction</seealso>
    let StateOfTexasJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfTexasJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfUtahEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Utah entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfUtahEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfUtahEntity</seealso>
    let StateOfUtahEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfUtahEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfUtahGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Utah government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfUtahGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfUtahGovernment</seealso>
    let StateOfUtahGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfUtahGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfUtahJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Utah jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfUtahJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfUtahJurisdiction</seealso>
    let StateOfUtahJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfUtahJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfVermontEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Vermont entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVermontEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVermontEntity</seealso>
    let StateOfVermontEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfVermontEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfVermontGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Vermont government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVermontGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVermontGovernment</seealso>
    let StateOfVermontGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfVermontGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfVermontJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Vermont jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVermontJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVermontJurisdiction</seealso>
    let StateOfVermontJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfVermontJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfVirginiaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Virginia entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVirginiaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVirginiaEntity</seealso>
    let StateOfVirginiaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfVirginiaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfVirginiaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Virginia government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVirginiaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVirginiaGovernment</seealso>
    let StateOfVirginiaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfVirginiaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfVirginiaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Virginia jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVirginiaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfVirginiaJurisdiction</seealso>
    let StateOfVirginiaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfVirginiaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWashingtonEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Washington entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWashingtonEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWashingtonEntity</seealso>
    let StateOfWashingtonEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWashingtonEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWashingtonGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Washington government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWashingtonGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWashingtonGovernment</seealso>
    let StateOfWashingtonGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWashingtonGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWashingtonJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Washington jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWashingtonJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWashingtonJurisdiction</seealso>
    let StateOfWashingtonJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWashingtonJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWestVirginiaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of West Virginia entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWestVirginiaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWestVirginiaEntity</seealso>
    let StateOfWestVirginiaEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWestVirginiaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWestVirginiaGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of West Virginia government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWestVirginiaGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWestVirginiaGovernment</seealso>
    let StateOfWestVirginiaGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWestVirginiaGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWestVirginiaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of West Virginia jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWestVirginiaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWestVirginiaJurisdiction</seealso>
    let StateOfWestVirginiaJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWestVirginiaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWisconsinEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"State of Wisconsin entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWisconsinEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWisconsinEntity</seealso>
    let StateOfWisconsinEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWisconsinEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWisconsinGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Wisconsin government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWisconsinGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWisconsinGovernment</seealso>
    let StateOfWisconsinGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWisconsinGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWisconsinJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Wisconsin jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWisconsinJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWisconsinJurisdiction</seealso>
    let StateOfWisconsinJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWisconsinJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWyomingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of Wyoming entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWyomingEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWyomingEntity</seealso>
    let StateOfWyomingEntity =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWyomingEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWyomingGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"State of Wyoming government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWyomingGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWyomingGovernment</seealso>
    let StateOfWyomingGovernment =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWyomingGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:StateOfWyomingJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"State of Wyoming jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWyomingJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/StateOfWyomingJurisdiction</seealso>
    let StateOfWyomingJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "StateOfWyomingJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:UnitedStatesEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"United States entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/UnitedStatesEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/UnitedStatesEntity</seealso>
    let UnitedStatesEntity =
        Prefixed_Name(fibo_be_ge_usj, "UnitedStatesEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:UnitedStatesGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United States federal government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/UnitedStatesGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/UnitedStatesGovernment</seealso>
    let UnitedStatesGovernment =
        Prefixed_Name(fibo_be_ge_usj, "UnitedStatesGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:UnitedStatesJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"United States jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/UnitedStatesJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/UnitedStatesJurisdiction</seealso>
    let UnitedStatesJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "UnitedStatesJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:VirginIslandsEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Virgin Islands entity (USA)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/VirginIslandsEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/VirginIslandsEntity</seealso>
    let VirginIslandsEntity =
        Prefixed_Name(fibo_be_ge_usj, "VirginIslandsEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-usj:VirginIslandsJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"Virgin Islands jurisdiction (USA)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/VirginIslandsJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/VirginIslandsJurisdiction</seealso>
    let VirginIslandsJurisdiction =
        Prefixed_Name(fibo_be_ge_usj, "VirginIslandsJurisdiction") |> PrefixedName
