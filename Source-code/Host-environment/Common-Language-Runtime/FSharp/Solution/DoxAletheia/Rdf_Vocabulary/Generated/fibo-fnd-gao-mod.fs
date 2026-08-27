namespace https.spec.edmcouncil.org.fibo.ontology.FND.GoalsAndObjectives.MetadataFNDGoalsAndObjectives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_gao_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_gao_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-gao-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Goals and Objectives Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_gao_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-mod:GoalsAndObjectivesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"goals and objectives module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/GoalsAndObjectivesModule">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/GoalsAndObjectivesModule</seealso>
    let GoalsAndObjectivesModule =
        Prefixed_Name(fibo_fnd_gao_mod, "GoalsAndObjectivesModule") |> PrefixedName
