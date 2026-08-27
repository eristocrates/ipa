namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.OwnershipAndControl.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_oac_oac =
    let _namespace_iri = Namespace_Iri fibo_fnd_oac_oac |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-oac-oac:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Ownership and Control Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_oac_oac, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-oac:OwnershipControlSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ownership control situation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/OwnershipControlSituation">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/OwnershipControlSituation</seealso>
    let OwnershipControlSituation =
        Prefixed_Name(fibo_fnd_oac_oac, "OwnershipControlSituation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-oac:isOwnedAndControlledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owned and controlled by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/isOwnedAndControlledBy">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/isOwnedAndControlledBy</seealso>
    let isOwnedAndControlledBy =
        Prefixed_Name(fibo_fnd_oac_oac, "isOwnedAndControlledBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-oac:ownsAndControls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owns and controls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/ownsAndControls">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/ownsAndControls</seealso>
    let ownsAndControls =
        Prefixed_Name(fibo_fnd_oac_oac, "ownsAndControls") |> PrefixedName
