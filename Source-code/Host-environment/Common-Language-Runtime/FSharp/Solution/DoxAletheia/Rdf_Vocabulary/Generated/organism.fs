namespace http.eulersharp.sourceforge.net._2003._03swap.organism.hash

open DoxAletheia.Rdf_Vocabulary

module organism =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/organism#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Alive"></see>
    /// </summary>
    let Alive = Namespaced_IRI.parse _namespace_name "Alive" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ancestry"></see>
    /// </summary>
    let Ancestry = Namespaced_IRI.parse _namespace_name "Ancestry" |> NamespacedName
    /// <summary>
    /// Organism that is an earlier form of another organism.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ascendant"></see></summary>
    let Ascendant = Namespaced_IRI.parse _namespace_name "Ascendant" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Organism"></see>
    /// </summary>
    let Organism = Namespaced_IRI.parse _namespace_name "Organism" |> NamespacedName
    /// <summary>
    /// Organism that is produced by another.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Child"></see></summary>
    let Child = Namespaced_IRI.parse _namespace_name "Child" |> NamespacedName
    /// <summary>
    /// Organism deriving from an earlier form.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Descendant"></see></summary>
    let Descendant = Namespaced_IRI.parse _namespace_name "Descendant" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasParent"></see>
    /// </summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Children"></see>
    /// </summary>
    let Children = Namespaced_IRI.parse _namespace_name "Children" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Offspring"></see>
    /// </summary>
    let Offspring = Namespaced_IRI.parse _namespace_name "Offspring" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNA"></see>
    /// </summary>
    let DNA = Namespaced_IRI.parse _namespace_name "DNA" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequence"></see>
    /// </summary>
    let DNASequence =
        Namespaced_IRI.parse _namespace_name "DNASequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequence"></see>
    /// </summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequencing"></see>
    /// </summary>
    let DNASequencing =
        Namespaced_IRI.parse _namespace_name "DNASequencing" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#sequenceOf"></see>
    /// </summary>
    let sequenceOf = Namespaced_IRI.parse _namespace_name "sequenceOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequencing"></see>
    /// </summary>
    let Sequencing = Namespaced_IRI.parse _namespace_name "Sequencing" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Dead"></see>
    /// </summary>
    let Dead = Namespaced_IRI.parse _namespace_name "Dead" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Death"></see>
    /// </summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DeathCause"></see>
    /// </summary>
    let DeathCause = Namespaced_IRI.parse _namespace_name "DeathCause" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DevelopmentState"></see>
    /// </summary>
    let DevelopmentState =
        Namespaced_IRI.parse _namespace_name "DevelopmentState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Eukaryote"></see>
    /// </summary>
    let Eukaryote = Namespaced_IRI.parse _namespace_name "Eukaryote" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Father"></see>
    /// </summary>
    let Father = Namespaced_IRI.parse _namespace_name "Father" |> NamespacedName
    /// <summary>
    /// Organism that produces another.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parent"></see></summary>
    let Parent = Namespaced_IRI.parse _namespace_name "Parent" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Genome"></see>
    /// </summary>
    let Genome = Namespaced_IRI.parse _namespace_name "Genome" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Gravidity"></see>
    /// </summary>
    let Gravidity = Namespaced_IRI.parse _namespace_name "Gravidity" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Pregnant"></see>
    /// </summary>
    let Pregnant = Namespaced_IRI.parse _namespace_name "Pregnant" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Nonpregnant"></see>
    /// </summary>
    let Nonpregnant =
        Namespaced_IRI.parse _namespace_name "Nonpregnant" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Immature"></see>
    /// </summary>
    let Immature = Namespaced_IRI.parse _namespace_name "Immature" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#ImmatureOrganism"></see>
    /// </summary>
    let ImmatureOrganism =
        Namespaced_IRI.parse _namespace_name "ImmatureOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDevelopmentState"></see>
    /// </summary>
    let hasDevelopmentState =
        Namespaced_IRI.parse _namespace_name "hasDevelopmentState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#IndividualLife"></see>
    /// </summary>
    let IndividualLife =
        Namespaced_IRI.parse _namespace_name "IndividualLife" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Life"></see>
    /// </summary>
    let Life = Namespaced_IRI.parse _namespace_name "Life" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotype"></see>
    /// </summary>
    let Karyotype = Namespaced_IRI.parse _namespace_name "Karyotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotyping"></see>
    /// </summary>
    let Karyotyping =
        Namespaced_IRI.parse _namespace_name "Karyotyping" |> NamespacedName

    /// <summary>
    /// A criterium can be: capable of reproduction.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mature"></see></summary>
    let Mature = Namespaced_IRI.parse _namespace_name "Mature" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#MatureOrganism"></see>
    /// </summary>
    let MatureOrganism =
        Namespaced_IRI.parse _namespace_name "MatureOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mortal"></see>
    /// </summary>
    let Mortal = Namespaced_IRI.parse _namespace_name "Mortal" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mother"></see>
    /// </summary>
    let Mother = Namespaced_IRI.parse _namespace_name "Mother" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasChild"></see>
    /// </summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parents"></see>
    /// </summary>
    let Parents = Namespaced_IRI.parse _namespace_name "Parents" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#PregnantOrganism"></see>
    /// </summary>
    let PregnantOrganism =
        Namespaced_IRI.parse _namespace_name "PregnantOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasGravidity"></see>
    /// </summary>
    let hasGravidity =
        Namespaced_IRI.parse _namespace_name "hasGravidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#UnbranchedBioPolymer"></see>
    /// </summary>
    let UnbranchedBioPolymer =
        Namespaced_IRI.parse _namespace_name "UnbranchedBioPolymer" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#beginDate"></see>
    /// </summary>
    let beginDate = Namespaced_IRI.parse _namespace_name "beginDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#begins"></see>
    /// </summary>
    let begins = Namespaced_IRI.parse _namespace_name "begins" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#ends"></see>
    /// </summary>
    let ends = Namespaced_IRI.parse _namespace_name "ends" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDate"></see>
    /// </summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#lives"></see>
    /// </summary>
    let lives = Namespaced_IRI.parse _namespace_name "lives" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDateTime"></see>
    /// </summary>
    let hasBirthDateTime =
        Namespaced_IRI.parse _namespace_name "hasBirthDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthTime"></see>
    /// </summary>
    let hasBirthTime =
        Namespaced_IRI.parse _namespace_name "hasBirthTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasCauseOfDeath"></see>
    /// </summary>
    let hasCauseOfDeath =
        Namespaced_IRI.parse _namespace_name "hasCauseOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDNASequence"></see>
    /// </summary>
    let hasDNASequence =
        Namespaced_IRI.parse _namespace_name "hasDNASequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDate"></see>
    /// </summary>
    let hasDeathDate =
        Namespaced_IRI.parse _namespace_name "hasDeathDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDateTime"></see>
    /// </summary>
    let hasDeathDateTime =
        Namespaced_IRI.parse _namespace_name "hasDeathDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathTime"></see>
    /// </summary>
    let hasDeathTime =
        Namespaced_IRI.parse _namespace_name "hasDeathTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasFather"></see>
    /// </summary>
    let hasFather = Namespaced_IRI.parse _namespace_name "hasFather" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasKaryotype"></see>
    /// </summary>
    let hasKaryotype =
        Namespaced_IRI.parse _namespace_name "hasKaryotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasMother"></see>
    /// </summary>
    let hasMother = Namespaced_IRI.parse _namespace_name "hasMother" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasSequence"></see>
    /// </summary>
    let hasSequence =
        Namespaced_IRI.parse _namespace_name "hasSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasTaxon"></see>
    /// </summary>
    let hasTaxon = Namespaced_IRI.parse _namespace_name "hasTaxon" |> NamespacedName
