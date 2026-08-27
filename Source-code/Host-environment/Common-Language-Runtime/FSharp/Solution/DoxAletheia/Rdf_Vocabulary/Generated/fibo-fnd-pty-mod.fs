namespace https.spec.edmcouncil.org.fibo.ontology.FND.Parties.MetadataFNDParties.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_pty_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_pty_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-pty-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Parties Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_pty_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pty-mod:PartiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"parties module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/PartiesModule">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/PartiesModule</seealso>
    let PartiesModule = Prefixed_Name(fibo_fnd_pty_mod, "PartiesModule") |> PrefixedName
