namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.MetadataFNDAgentsAndPeople.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_aap_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_aap_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-aap-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Agents and People Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_aap_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-aap-mod:AgentsAndPeopleModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"agents and people module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/AgentsAndPeopleModule">https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/AgentsAndPeopleModule</seealso>
    let AgentsAndPeopleModule =
        Prefixed_Name(fibo_fnd_aap_mod, "AgentsAndPeopleModule") |> PrefixedName
