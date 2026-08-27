namespace https.spec.edmcouncil.org.fibo.ontology.BE.SoleProprietorships.MetadataBESoleProprietorships.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_sps_mod =
    let _namespace_iri = Namespace_Iri fibo_be_sps_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-sps-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Sole Proprietorships Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/">https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_sps_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-sps-mod:SoleProprietorshipsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"sole proprietorships module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/SoleProprietorshipsModule">https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/SoleProprietorshipsModule</seealso>
    let SoleProprietorshipsModule =
        Prefixed_Name(fibo_be_sps_mod, "SoleProprietorshipsModule") |> PrefixedName
