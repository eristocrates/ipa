namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.MetadataFNDAgreements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_agr_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_agr_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-agr-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Agreements Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_agr_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-mod:AgreementsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"agreements module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/AgreementsModule">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/AgreementsModule</seealso>
    let AgreementsModule =
        Prefixed_Name(fibo_fnd_agr_mod, "AgreementsModule") |> PrefixedName
