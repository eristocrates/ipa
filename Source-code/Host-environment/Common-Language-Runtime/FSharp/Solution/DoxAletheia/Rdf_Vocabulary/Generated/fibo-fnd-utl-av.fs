namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.AnnotationVocabulary.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_utl_av =
    let _namespace_iri = Namespace_Iri fibo_fnd_utl_av |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-utl-av:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"FIBO Annotation Vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_utl_av, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-av:Informative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:MaturityLevel</para>
    ///
    /// labels<para>"informative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Informative">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Informative</seealso>
    let Informative = Prefixed_Name(fibo_fnd_utl_av, "Informative") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-av:MaturityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maturity level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/MaturityLevel">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/MaturityLevel</seealso>
    let MaturityLevel = Prefixed_Name(fibo_fnd_utl_av, "MaturityLevel") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-av:Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Module">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Module</seealso>
    let Module = Prefixed_Name(fibo_fnd_utl_av, "Module") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-av:Provisional</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:MaturityLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"provisional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Provisional">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Provisional</seealso>
    let Provisional = Prefixed_Name(fibo_fnd_utl_av, "Provisional") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-av:Release</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:MaturityLevel</para>
    ///
    /// labels<para>"release"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Release">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Release</seealso>
    let Release = Prefixed_Name(fibo_fnd_utl_av, "Release") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-av:commonDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"common designation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/commonDesignation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/commonDesignation</seealso>
    let commonDesignation =
        Prefixed_Name(fibo_fnd_utl_av, "commonDesignation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-av:definitionOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"definition origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/definitionOrigin">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/definitionOrigin</seealso>
    let definitionOrigin =
        Prefixed_Name(fibo_fnd_utl_av, "definitionOrigin") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-av:hasMaturityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has maturity level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/hasMaturityLevel">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/hasMaturityLevel</seealso>
    let hasMaturityLevel =
        Prefixed_Name(fibo_fnd_utl_av, "hasMaturityLevel") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-av:preferredDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"preferred designation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/preferredDesignation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/preferredDesignation</seealso>
    let preferredDesignation =
        Prefixed_Name(fibo_fnd_utl_av, "preferredDesignation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-av:termOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"term origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/termOrigin">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/termOrigin</seealso>
    let termOrigin = Prefixed_Name(fibo_fnd_utl_av, "termOrigin") |> PrefixedName
