namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.MetadataFNDOwnershipAndControl.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_oac_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_oac_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-oac-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Ownership and Control Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_oac_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-mod:OwnershipAndControlModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"ownership and control module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/OwnershipAndControlModule">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/OwnershipAndControlModule</seealso>
    let OwnershipAndControlModule =
        Prefixed_Name(fibo_fnd_oac_mod, "OwnershipAndControlModule") |> PrefixedName
