namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.NorthAmericanJurisdiction.MXGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_mxj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_mxj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-mxj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Mexican Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_mxj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-mxj:FederalGovernmentOfMexico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    ///
    /// labels<para>"Federal Government of Mexico"</para><para>"Gobierno Federal de México"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/FederalGovernmentOfMexico">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/FederalGovernmentOfMexico</seealso>
    let FederalGovernmentOfMexico =
        Prefixed_Name(fibo_be_ge_mxj, "FederalGovernmentOfMexico") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-mxj:MexicanEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mexican entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanEntity</seealso>
    let MexicanEntity = Prefixed_Name(fibo_be_ge_mxj, "MexicanEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-mxj:MexicanJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"Mexican jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanJurisdiction</seealso>
    let MexicanJurisdiction =
        Prefixed_Name(fibo_be_ge_mxj, "MexicanJurisdiction") |> PrefixedName
