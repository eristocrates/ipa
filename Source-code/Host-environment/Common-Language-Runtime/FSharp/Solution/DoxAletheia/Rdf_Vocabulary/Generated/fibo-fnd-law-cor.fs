namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.LegalCore.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_law_cor =
    let _namespace_iri = Namespace_Iri fibo_fnd_law_cor |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-law-cor:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Legal Core Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_law_cor, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-cor:Constitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"constitution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Constitution">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Constitution</seealso>
    let Constitution = Prefixed_Name(fibo_fnd_law_cor, "Constitution") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-cor:CourtOfLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"court of law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/CourtOfLaw">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/CourtOfLaw</seealso>
    let CourtOfLaw = Prefixed_Name(fibo_fnd_law_cor, "CourtOfLaw") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-cor:Law</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Law">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Law</seealso>
    let Law = Prefixed_Name(fibo_fnd_law_cor, "Law") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-cor:StatuteLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statute law"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/StatuteLaw">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/StatuteLaw</seealso>
    let StatuteLaw = Prefixed_Name(fibo_fnd_law_cor, "StatuteLaw") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-cor:hasInForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has in force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/hasInForce">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/hasInForce</seealso>
    let hasInForce = Prefixed_Name(fibo_fnd_law_cor, "hasInForce") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-cor:isInForceIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is in force in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/isInForceIn">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/isInForceIn</seealso>
    let isInForceIn = Prefixed_Name(fibo_fnd_law_cor, "isInForceIn") |> PrefixedName
