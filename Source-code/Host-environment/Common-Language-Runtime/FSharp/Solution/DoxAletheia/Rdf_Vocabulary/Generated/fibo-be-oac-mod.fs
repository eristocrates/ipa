namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.MetadataBEOwnershipAndControl.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_oac_mod =
    let _namespace_iri = Namespace_Iri fibo_be_oac_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-oac-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Ownership and Control Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_oac_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-mod:OwnershipAndControlModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"ownership and control module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/OwnershipAndControlModule">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/OwnershipAndControlModule</seealso>
    let OwnershipAndControlModule =
        Prefixed_Name(fibo_be_oac_mod, "OwnershipAndControlModule") |> PrefixedName
