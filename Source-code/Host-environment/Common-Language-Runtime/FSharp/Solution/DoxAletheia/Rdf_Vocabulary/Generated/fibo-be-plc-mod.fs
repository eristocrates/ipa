namespace https.spec.edmcouncil.org.fibo.ontology.BE.PrivateLimitedCompanies.MetadataBEPrivateLimitedCompanies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_plc_mod =
    let _namespace_iri = Namespace_Iri fibo_be_plc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-plc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Private Limited Companies Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_plc_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-mod:PrivateLimitedCompaniesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"private limited companies module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/PrivateLimitedCompaniesModule">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/PrivateLimitedCompaniesModule</seealso>
    let PrivateLimitedCompaniesModule =
        Prefixed_Name(fibo_be_plc_mod, "PrivateLimitedCompaniesModule") |> PrefixedName
