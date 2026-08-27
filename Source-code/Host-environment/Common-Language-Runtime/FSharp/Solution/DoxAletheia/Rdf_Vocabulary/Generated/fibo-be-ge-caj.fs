namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.NorthAmericanJurisdiction.CAGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_caj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_caj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-caj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Canadian Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_caj, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-caj:CanadianEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///
    /// labels<para>"Canadian entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/CanadianEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/CanadianEntity</seealso>
    let CanadianEntity = Prefixed_Name(fibo_be_ge_caj, "CanadianEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:CanadianJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canadian jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/CanadianJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/CanadianJurisdiction</seealso>
    let CanadianJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "CanadianJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfAlberta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Alberta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfAlberta">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfAlberta</seealso>
    let GovernmentOfAlberta =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfAlberta") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfBritishColumbia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of British Columbia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfBritishColumbia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfBritishColumbia</seealso>
    let GovernmentOfBritishColumbia =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfBritishColumbia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Government of Canada"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfCanada">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfCanada</seealso>
    let GovernmentOfCanada =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfCanada") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfManitoba</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of Manitoba"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfManitoba">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfManitoba</seealso>
    let GovernmentOfManitoba =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfManitoba") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfNewBrunswick</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of New Brunswick"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNewBrunswick">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNewBrunswick</seealso>
    let GovernmentOfNewBrunswick =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfNewBrunswick") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfNewfoundlandAndLabrador</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of Newfoundland and Labrador"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNewfoundlandAndLabrador">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNewfoundlandAndLabrador</seealso>
    let GovernmentOfNewfoundlandAndLabrador =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfNewfoundlandAndLabrador") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfNorthwestTerritories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Northwest Territories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNorthwestTerritories">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNorthwestTerritories</seealso>
    let GovernmentOfNorthwestTerritories =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfNorthwestTerritories") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfNovaScotia</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of Nova Scotia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNovaScotia">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNovaScotia</seealso>
    let GovernmentOfNovaScotia =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfNovaScotia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfNunavut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Nunavut"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNunavut">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfNunavut</seealso>
    let GovernmentOfNunavut =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfNunavut") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfOntario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Ontario"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfOntario">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfOntario</seealso>
    let GovernmentOfOntario =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfOntario") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfPrinceEdwardIsland</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of Prince Edward Island"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfPrinceEdwardIsland">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfPrinceEdwardIsland</seealso>
    let GovernmentOfPrinceEdwardIsland =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfPrinceEdwardIsland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfQuebec</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"government of Quebec"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfQuebec">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfQuebec</seealso>
    let GovernmentOfQuebec =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfQuebec") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfSaskatchewan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Saskatchewan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfSaskatchewan">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfSaskatchewan</seealso>
    let GovernmentOfSaskatchewan =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfSaskatchewan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:GovernmentOfYukon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    ///
    /// labels<para>"government of Yukon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfYukon">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/GovernmentOfYukon</seealso>
    let GovernmentOfYukon =
        Prefixed_Name(fibo_be_ge_caj, "GovernmentOfYukon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:NorthwestTerritoriesEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Northwest Territories entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NorthwestTerritoriesEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NorthwestTerritoriesEntity</seealso>
    let NorthwestTerritoriesEntity =
        Prefixed_Name(fibo_be_ge_caj, "NorthwestTerritoriesEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:NorthwestTerritoriesJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Northwest Territories jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NorthwestTerritoriesJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NorthwestTerritoriesJurisdiction</seealso>
    let NorthwestTerritoriesJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "NorthwestTerritoriesJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:NunavutEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Nunavut entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NunavutEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NunavutEntity</seealso>
    let NunavutEntity = Prefixed_Name(fibo_be_ge_caj, "NunavutEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:NunavutJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"Nunavut jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NunavutJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/NunavutJurisdiction</seealso>
    let NunavutJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "NunavutJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfAlbertaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Province of Alberta entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfAlbertaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfAlbertaEntity</seealso>
    let ProvinceOfAlbertaEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfAlbertaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfAlbertaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"province of Alberta jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfAlbertaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfAlbertaJurisdiction</seealso>
    let ProvinceOfAlbertaJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfAlbertaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfBritishColumbiaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Province of British Columbia entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfBritishColumbiaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfBritishColumbiaEntity</seealso>
    let ProvinceOfBritishColumbiaEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfBritishColumbiaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfBritishColumbiaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"province of British Columbia jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfBritishColumbiaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfBritishColumbiaJurisdiction</seealso>
    let ProvinceOfBritishColumbiaJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfBritishColumbiaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfManitobaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Province of Manitoba entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfManitobaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfManitobaEntity</seealso>
    let ProvinceOfManitobaEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfManitobaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfManitobaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"province of Manitoba jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfManitobaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfManitobaJurisdiction</seealso>
    let ProvinceOfManitobaJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfManitobaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfNewBrunswickEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Province of New Brunswick entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewBrunswickEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewBrunswickEntity</seealso>
    let ProvinceOfNewBrunswickEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfNewBrunswickEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfNewBrunswickJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"province of New Brunswick jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewBrunswickJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewBrunswickJurisdiction</seealso>
    let ProvinceOfNewBrunswickJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfNewBrunswickJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfNewfoundlandAndLabradorEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Province of Newfoundland and Labrador entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewfoundlandAndLabradorEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewfoundlandAndLabradorEntity</seealso>
    let ProvinceOfNewfoundlandAndLabradorEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfNewfoundlandAndLabradorEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfNewfoundlandAndLabradorJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"province of Newfoundland and Labrador jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewfoundlandAndLabradorJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNewfoundlandAndLabradorJurisdiction</seealso>
    let ProvinceOfNewfoundlandAndLabradorJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfNewfoundlandAndLabradorJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfNovaScotiaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Province of Nova Scotia entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNovaScotiaEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNovaScotiaEntity</seealso>
    let ProvinceOfNovaScotiaEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfNovaScotiaEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfNovaScotiaJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"province of Nova Scotia jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNovaScotiaJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfNovaScotiaJurisdiction</seealso>
    let ProvinceOfNovaScotiaJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfNovaScotiaJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfOntarioEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Province of Ontario entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfOntarioEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfOntarioEntity</seealso>
    let ProvinceOfOntarioEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfOntarioEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfOntarioJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"province of Ontario jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfOntarioJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfOntarioJurisdiction</seealso>
    let ProvinceOfOntarioJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfOntarioJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfPrinceEdwardIslandEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Province of Prince Edward Island entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfPrinceEdwardIslandEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfPrinceEdwardIslandEntity</seealso>
    let ProvinceOfPrinceEdwardIslandEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfPrinceEdwardIslandEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfPrinceEdwardIslandJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"province of Prince Edward Island jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfPrinceEdwardIslandJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfPrinceEdwardIslandJurisdiction</seealso>
    let ProvinceOfPrinceEdwardIslandJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfPrinceEdwardIslandJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfQuebecEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Province of Quebec entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfQuebecEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfQuebecEntity</seealso>
    let ProvinceOfQuebecEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfQuebecEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfQuebecJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"province of Quebec jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfQuebecJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfQuebecJurisdiction</seealso>
    let ProvinceOfQuebecJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfQuebecJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfSaskatchewanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Province of Saskatchewan entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfSaskatchewanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfSaskatchewanEntity</seealso>
    let ProvinceOfSaskatchewanEntity =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfSaskatchewanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:ProvinceOfSaskatchewanJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"province of Saskatchewan jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfSaskatchewanJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/ProvinceOfSaskatchewanJurisdiction</seealso>
    let ProvinceOfSaskatchewanJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "ProvinceOfSaskatchewanJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:YukonEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    ///
    /// labels<para>"Yukon entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/YukonEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/YukonEntity</seealso>
    let YukonEntity = Prefixed_Name(fibo_be_ge_caj, "YukonEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-caj:YukonJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Yukon jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/YukonJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/YukonJurisdiction</seealso>
    let YukonJurisdiction =
        Prefixed_Name(fibo_be_ge_caj, "YukonJurisdiction") |> PrefixedName
