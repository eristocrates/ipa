namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.MetadataFNDLaw.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_law_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_law_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-law-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Law Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/">https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_law_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-mod:LawModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"law module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/LawModule">https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/LawModule</seealso>
    let LawModule = Prefixed_Name(fibo_fnd_law_mod, "LawModule") |> PrefixedName
