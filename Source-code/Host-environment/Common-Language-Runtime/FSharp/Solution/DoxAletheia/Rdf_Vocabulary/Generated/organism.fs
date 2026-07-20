namespace http.eulersharp.sourceforge.net._2003._03swap.organism.hash

open DoxAletheia

module organism =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/organism#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Alive"></see>
    /// </summary>
    let Alive = _prefix "Alive"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ancestry"></see>
    /// </summary>
    let Ancestry = _prefix "Ancestry"
    /// <summary>
    /// Organism that is an earlier form of another organism.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ascendant"></see></summary>
    let Ascendant = _prefix "Ascendant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Organism"></see>
    /// </summary>
    let Organism = _prefix "Organism"
    /// <summary>
    /// Organism that is produced by another.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Child"></see></summary>
    let Child = _prefix "Child"
    /// <summary>
    /// Organism deriving from an earlier form.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Descendant"></see></summary>
    let Descendant = _prefix "Descendant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasParent"></see>
    /// </summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Children"></see>
    /// </summary>
    let Children = _prefix "Children"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Offspring"></see>
    /// </summary>
    let Offspring = _prefix "Offspring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNA"></see>
    /// </summary>
    let DNA = _prefix "DNA"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequence"></see>
    /// </summary>
    let DNASequence = _prefix "DNASequence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequence"></see>
    /// </summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequencing"></see>
    /// </summary>
    let DNASequencing = _prefix "DNASequencing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#sequenceOf"></see>
    /// </summary>
    let sequenceOf = _prefix "sequenceOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequencing"></see>
    /// </summary>
    let Sequencing = _prefix "Sequencing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Dead"></see>
    /// </summary>
    let Dead = _prefix "Dead"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Death"></see>
    /// </summary>
    let Death = _prefix "Death"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DeathCause"></see>
    /// </summary>
    let DeathCause = _prefix "DeathCause"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#DevelopmentState"></see>
    /// </summary>
    let DevelopmentState = _prefix "DevelopmentState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Eukaryote"></see>
    /// </summary>
    let Eukaryote = _prefix "Eukaryote"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Father"></see>
    /// </summary>
    let Father = _prefix "Father"
    /// <summary>
    /// Organism that produces another.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parent"></see></summary>
    let Parent = _prefix "Parent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Genome"></see>
    /// </summary>
    let Genome = _prefix "Genome"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Gravidity"></see>
    /// </summary>
    let Gravidity = _prefix "Gravidity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Pregnant"></see>
    /// </summary>
    let Pregnant = _prefix "Pregnant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Nonpregnant"></see>
    /// </summary>
    let Nonpregnant = _prefix "Nonpregnant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Immature"></see>
    /// </summary>
    let Immature = _prefix "Immature"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#ImmatureOrganism"></see>
    /// </summary>
    let ImmatureOrganism = _prefix "ImmatureOrganism"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDevelopmentState"></see>
    /// </summary>
    let hasDevelopmentState = _prefix "hasDevelopmentState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#IndividualLife"></see>
    /// </summary>
    let IndividualLife = _prefix "IndividualLife"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Life"></see>
    /// </summary>
    let Life = _prefix "Life"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotype"></see>
    /// </summary>
    let Karyotype = _prefix "Karyotype"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotyping"></see>
    /// </summary>
    let Karyotyping = _prefix "Karyotyping"
    /// <summary>
    /// A criterium can be: capable of reproduction.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mature"></see></summary>
    let Mature = _prefix "Mature"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#MatureOrganism"></see>
    /// </summary>
    let MatureOrganism = _prefix "MatureOrganism"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mortal"></see>
    /// </summary>
    let Mortal = _prefix "Mortal"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mother"></see>
    /// </summary>
    let Mother = _prefix "Mother"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasChild"></see>
    /// </summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parents"></see>
    /// </summary>
    let Parents = _prefix "Parents"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#PregnantOrganism"></see>
    /// </summary>
    let PregnantOrganism = _prefix "PregnantOrganism"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasGravidity"></see>
    /// </summary>
    let hasGravidity = _prefix "hasGravidity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#UnbranchedBioPolymer"></see>
    /// </summary>
    let UnbranchedBioPolymer = _prefix "UnbranchedBioPolymer"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#beginDate"></see>
    /// </summary>
    let beginDate = _prefix "beginDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#begins"></see>
    /// </summary>
    let begins = _prefix "begins"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#ends"></see>
    /// </summary>
    let ends = _prefix "ends"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDate"></see>
    /// </summary>
    let hasBirthDate = _prefix "hasBirthDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#lives"></see>
    /// </summary>
    let lives = _prefix "lives"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDateTime"></see>
    /// </summary>
    let hasBirthDateTime = _prefix "hasBirthDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthTime"></see>
    /// </summary>
    let hasBirthTime = _prefix "hasBirthTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasCauseOfDeath"></see>
    /// </summary>
    let hasCauseOfDeath = _prefix "hasCauseOfDeath"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDNASequence"></see>
    /// </summary>
    let hasDNASequence = _prefix "hasDNASequence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDate"></see>
    /// </summary>
    let hasDeathDate = _prefix "hasDeathDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDateTime"></see>
    /// </summary>
    let hasDeathDateTime = _prefix "hasDeathDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathTime"></see>
    /// </summary>
    let hasDeathTime = _prefix "hasDeathTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasFather"></see>
    /// </summary>
    let hasFather = _prefix "hasFather"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasKaryotype"></see>
    /// </summary>
    let hasKaryotype = _prefix "hasKaryotype"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasMother"></see>
    /// </summary>
    let hasMother = _prefix "hasMother"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasSequence"></see>
    /// </summary>
    let hasSequence = _prefix "hasSequence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasTaxon"></see>
    /// </summary>
    let hasTaxon = _prefix "hasTaxon"
