namespace https.spec.edmcouncil.org.fibo.ontology.BE.Trusts.MetadataBETrusts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_tr_mod =
    let _namespace_iri = Namespace_Iri fibo_be_tr_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-tr-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Trusts Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_tr_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-tr-mod:TrustsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"trusts module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/TrustsModule">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/TrustsModule</seealso>
    let TrustsModule = Prefixed_Name(fibo_be_tr_mod, "TrustsModule") |> PrefixedName
