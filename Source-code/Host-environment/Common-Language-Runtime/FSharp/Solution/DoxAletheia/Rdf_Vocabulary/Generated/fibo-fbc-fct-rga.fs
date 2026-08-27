namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.RegulatoryAgencies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_rga =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_rga |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-rga:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Regulatory Agencies Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_rga, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-rga:Examiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"examiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/Examiner">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/Examiner</seealso>
    let Examiner = Prefixed_Name(fibo_fbc_fct_rga, "Examiner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-rga:GovernmentIssuedLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government-issued license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/GovernmentIssuedLicense">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/GovernmentIssuedLicense</seealso>
    let GovernmentIssuedLicense =
        Prefixed_Name(fibo_fbc_fct_rga, "GovernmentIssuedLicense") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-rga:RegulationIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentificationScheme</seealso>
    let RegulationIdentificationScheme =
        Prefixed_Name(fibo_fbc_fct_rga, "RegulationIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-rga:RegulationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentifier</seealso>
    let RegulationIdentifier =
        Prefixed_Name(fibo_fbc_fct_rga, "RegulationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-rga:RegulatoryCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulatory capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulatoryCapacity">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulatoryCapacity</seealso>
    let RegulatoryCapacity =
        Prefixed_Name(fibo_fbc_fct_rga, "RegulatoryCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-rga:TaxAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tax authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/TaxAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/TaxAuthority</seealso>
    let TaxAuthority = Prefixed_Name(fibo_fbc_fct_rga, "TaxAuthority") |> PrefixedName
