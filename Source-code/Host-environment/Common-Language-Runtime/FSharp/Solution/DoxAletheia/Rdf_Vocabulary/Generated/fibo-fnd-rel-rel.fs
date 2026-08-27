namespace https.spec.edmcouncil.org.fibo.ontology.FND.Relations.Relations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_rel_rel =
    let _namespace_iri = Namespace_Iri fibo_fnd_rel_rel |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Relations Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_rel_rel, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:Referent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"referent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/Referent">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/Referent</seealso>
    let Referent = Prefixed_Name(fibo_fnd_rel_rel, "Referent") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"causes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/causes">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/causes</seealso>
    let causes = Prefixed_Name(fibo_fnd_rel_rel, "causes") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:comprises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/comprises">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/comprises</seealso>
    let comprises = Prefixed_Name(fibo_fnd_rel_rel, "comprises") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:confers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"confers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/confers">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/confers</seealso>
    let confers = Prefixed_Name(fibo_fnd_rel_rel, "confers") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:controls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"controls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/controls">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/controls</seealso>
    let controls = Prefixed_Name(fibo_fnd_rel_rel, "controls") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:embodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"embodies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/embodies">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/embodies</seealso>
    let embodies = Prefixed_Name(fibo_fnd_rel_rel, "embodies") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:evaluates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"evaluates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/evaluates">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/evaluates</seealso>
    let evaluates = Prefixed_Name(fibo_fnd_rel_rel, "evaluates") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:exchanges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exchanges"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exchanges">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exchanges</seealso>
    let exchanges = Prefixed_Name(fibo_fnd_rel_rel, "exchanges") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:exemplifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exemplifies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exemplifies">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exemplifies</seealso>
    let exemplifies = Prefixed_Name(fibo_fnd_rel_rel, "exemplifies") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:generates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"generates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/generates">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/generates</seealso>
    let generates = Prefixed_Name(fibo_fnd_rel_rel, "generates") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has alias"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasAlias">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasAlias</seealso>
    let hasAlias = Prefixed_Name(fibo_fnd_rel_rel, "hasAlias") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasCommonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has common name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasCommonName">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasCommonName</seealso>
    let hasCommonName = Prefixed_Name(fibo_fnd_rel_rel, "hasCommonName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has designation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasDesignation">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasDesignation</seealso>
    let hasDesignation =
        Prefixed_Name(fibo_fnd_rel_rel, "hasDesignation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasFormalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has formal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasFormalName">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasFormalName</seealso>
    let hasFormalName = Prefixed_Name(fibo_fnd_rel_rel, "hasFormalName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasIdentity">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasIdentity</seealso>
    let hasIdentity = Prefixed_Name(fibo_fnd_rel_rel, "hasIdentity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasLegalName">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasLegalName</seealso>
    let hasLegalName = Prefixed_Name(fibo_fnd_rel_rel, "hasLegalName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasTag">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasTag</seealso>
    let hasTag = Prefixed_Name(fibo_fnd_rel_rel, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:holds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"holds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/holds">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/holds</seealso>
    let holds = Prefixed_Name(fibo_fnd_rel_rel, "holds") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"involves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/involves">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/involves</seealso>
    let involves = Prefixed_Name(fibo_fnd_rel_rel, "involves") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is caused by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isCausedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isCausedBy</seealso>
    let isCausedBy = Prefixed_Name(fibo_fnd_rel_rel, "isCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isConferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is conferred by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isConferredBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isConferredBy</seealso>
    let isConferredBy = Prefixed_Name(fibo_fnd_rel_rel, "isConferredBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isControlledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlled by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isControlledBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isControlledBy</seealso>
    let isControlledBy =
        Prefixed_Name(fibo_fnd_rel_rel, "isControlledBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isEvaluatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is evaluated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isEvaluatedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isEvaluatedBy</seealso>
    let isEvaluatedBy = Prefixed_Name(fibo_fnd_rel_rel, "isEvaluatedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isExemplifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is exemplified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isExemplifiedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isExemplifiedBy</seealso>
    let isExemplifiedBy =
        Prefixed_Name(fibo_fnd_rel_rel, "isExemplifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is generated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isGeneratedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isGeneratedBy</seealso>
    let isGeneratedBy = Prefixed_Name(fibo_fnd_rel_rel, "isGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is held by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isHeldBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isHeldBy</seealso>
    let isHeldBy = Prefixed_Name(fibo_fnd_rel_rel, "isHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isIssuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is issued by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isIssuedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isIssuedBy</seealso>
    let isIssuedBy = Prefixed_Name(fibo_fnd_rel_rel, "isIssuedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isMandatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is mandated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isMandatedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isMandatedBy</seealso>
    let isMandatedBy = Prefixed_Name(fibo_fnd_rel_rel, "isMandatedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is produced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProducedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(fibo_fnd_rel_rel, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProvidedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(fibo_fnd_rel_rel, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:issues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"issues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/issues">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/issues</seealso>
    let issues = Prefixed_Name(fibo_fnd_rel_rel, "issues") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:mandates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mandates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/mandates">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/mandates</seealso>
    let mandates = Prefixed_Name(fibo_fnd_rel_rel, "mandates") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-rel-rel:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"produces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/produces">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/produces</seealso>
    let produces = Prefixed_Name(fibo_fnd_rel_rel, "produces") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-rel:wasFormerlyKnownAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"was formerly known as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/wasFormerlyKnownAs">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/wasFormerlyKnownAs</seealso>
    let wasFormerlyKnownAs =
        Prefixed_Name(fibo_fnd_rel_rel, "wasFormerlyKnownAs") |> PrefixedName
