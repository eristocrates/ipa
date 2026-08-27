namespace https.spec.edmcouncil.org.fibo.ontology.BE.SoleProprietorships.SoleProprietorships.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_sps_sps =
    let _namespace_iri = Namespace_Iri fibo_be_sps_sps |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-sps-sps:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Sole Proprietorships Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/">https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_sps_sps, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-sps-sps:SoleProprietor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sole proprietor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietor">https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietor</seealso>
    let SoleProprietor =
        Prefixed_Name(fibo_be_sps_sps, "SoleProprietor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-sps-sps:SoleProprietorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sole proprietorship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietorship">https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietorship</seealso>
    let SoleProprietorship =
        Prefixed_Name(fibo_be_sps_sps, "SoleProprietorship") |> PrefixedName
