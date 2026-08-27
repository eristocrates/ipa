namespace http.eulersharp.sourceforge.net._2003._03swap.organism.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module organism =
    let _namespace_iri = Namespace_Iri organism |> NamespaceIRI
    /// <summary>
    ///   <para>organism:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#">http://eulersharp.sourceforge.net/2003/03swap/organism#</seealso>
    let _prefix_iri = Prefixed_Name(organism, "") |> PrefixedName
    /// <summary>
    ///   <para>organism:Alive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"alive"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Alive">http://eulersharp.sourceforge.net/2003/03swap/organism#Alive</seealso>
    let Alive = Prefixed_Name(organism, "Alive") |> PrefixedName
    /// <summary>
    ///   <para>organism:Ancestry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ancestry">http://eulersharp.sourceforge.net/2003/03swap/organism#Ancestry</seealso>
    let Ancestry = Prefixed_Name(organism, "Ancestry") |> PrefixedName
    /// <summary>
    ///   <para>organism:Ascendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organism that is an earlier form of another organism."</para>
    /// labels<para>"biological ascendant"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ascendant">http://eulersharp.sourceforge.net/2003/03swap/organism#Ascendant</seealso>
    let Ascendant = Prefixed_Name(organism, "Ascendant") |> PrefixedName
    /// <summary>
    ///   <para>organism:Child</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organism that is produced by another."</para>
    /// labels<para>"biological child"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Child">http://eulersharp.sourceforge.net/2003/03swap/organism#Child</seealso>
    let Child = Prefixed_Name(organism, "Child") |> PrefixedName
    /// <summary>
    ///   <para>organism:Children</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Children">http://eulersharp.sourceforge.net/2003/03swap/organism#Children</seealso>
    let Children = Prefixed_Name(organism, "Children") |> PrefixedName
    /// <summary>
    ///   <para>organism:DNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"deoxyribonucleic acid "</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNA">http://eulersharp.sourceforge.net/2003/03swap/organism#DNA</seealso>
    let DNA = Prefixed_Name(organism, "DNA") |> PrefixedName
    /// <summary>
    ///   <para>organism:DNASequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"DNA sequence"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequence">http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequence</seealso>
    let DNASequence = Prefixed_Name(organism, "DNASequence") |> PrefixedName
    /// <summary>
    ///   <para>organism:DNASequencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"DNA sequencing"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequencing">http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequencing</seealso>
    let DNASequencing = Prefixed_Name(organism, "DNASequencing") |> PrefixedName
    /// <summary>
    ///   <para>organism:Dead</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"dead"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Dead">http://eulersharp.sourceforge.net/2003/03swap/organism#Dead</seealso>
    let Dead = Prefixed_Name(organism, "Dead") |> PrefixedName
    /// <summary>
    ///   <para>organism:Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"death"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Death">http://eulersharp.sourceforge.net/2003/03swap/organism#Death</seealso>
    let Death = Prefixed_Name(organism, "Death") |> PrefixedName
    /// <summary>
    ///   <para>organism:DeathCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"cause of death"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#DeathCause">http://eulersharp.sourceforge.net/2003/03swap/organism#DeathCause</seealso>
    let DeathCause = Prefixed_Name(organism, "DeathCause") |> PrefixedName
    /// <summary>
    ///   <para>organism:Descendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organism deriving from an earlier form."</para>
    /// labels<para>"biological descendant"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Descendant">http://eulersharp.sourceforge.net/2003/03swap/organism#Descendant</seealso>
    let Descendant = Prefixed_Name(organism, "Descendant") |> PrefixedName
    /// <summary>
    ///   <para>organism:DevelopmentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"development state"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#DevelopmentState">http://eulersharp.sourceforge.net/2003/03swap/organism#DevelopmentState</seealso>
    let DevelopmentState = Prefixed_Name(organism, "DevelopmentState") |> PrefixedName
    /// <summary>
    ///   <para>organism:Eukaryote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"eukaryote"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Eukaryote">http://eulersharp.sourceforge.net/2003/03swap/organism#Eukaryote</seealso>
    let Eukaryote = Prefixed_Name(organism, "Eukaryote") |> PrefixedName
    /// <summary>
    ///   <para>organism:Father</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"biological father"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Father">http://eulersharp.sourceforge.net/2003/03swap/organism#Father</seealso>
    let Father = Prefixed_Name(organism, "Father") |> PrefixedName
    /// <summary>
    ///   <para>organism:Genome</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"genome"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Genome">http://eulersharp.sourceforge.net/2003/03swap/organism#Genome</seealso>
    let Genome = Prefixed_Name(organism, "Genome") |> PrefixedName
    /// <summary>
    ///   <para>organism:Gravidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"gravidity"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Gravidity">http://eulersharp.sourceforge.net/2003/03swap/organism#Gravidity</seealso>
    let Gravidity = Prefixed_Name(organism, "Gravidity") |> PrefixedName
    /// <summary>
    ///   <para>organism:Immature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>organism:DevelopmentState</para>
    ///
    /// labels<para>"immature"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Immature">http://eulersharp.sourceforge.net/2003/03swap/organism#Immature</seealso>
    let Immature = Prefixed_Name(organism, "Immature") |> PrefixedName
    /// <summary>
    ///   <para>organism:ImmatureOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"immature organism"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#ImmatureOrganism">http://eulersharp.sourceforge.net/2003/03swap/organism#ImmatureOrganism</seealso>
    let ImmatureOrganism = Prefixed_Name(organism, "ImmatureOrganism") |> PrefixedName
    /// <summary>
    ///   <para>organism:IndividualLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"individual life"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#IndividualLife">http://eulersharp.sourceforge.net/2003/03swap/organism#IndividualLife</seealso>
    let IndividualLife = Prefixed_Name(organism, "IndividualLife") |> PrefixedName
    /// <summary>
    ///   <para>organism:Karyotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"karyotype"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotype">http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotype</seealso>
    let Karyotype = Prefixed_Name(organism, "Karyotype") |> PrefixedName
    /// <summary>
    ///   <para>organism:Karyotyping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"karyotyping"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotyping">http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotyping</seealso>
    let Karyotyping = Prefixed_Name(organism, "Karyotyping") |> PrefixedName
    /// <summary>
    ///   <para>organism:Life</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"life"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Life">http://eulersharp.sourceforge.net/2003/03swap/organism#Life</seealso>
    let Life = Prefixed_Name(organism, "Life") |> PrefixedName
    /// <summary>
    ///   <para>organism:Mature</para>
    /// </summary>
    /// <remarks>
    ///   <para>organism:DevelopmentState</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A criterium can be: capable of reproduction."</para>
    /// labels<para>"mature"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mature">http://eulersharp.sourceforge.net/2003/03swap/organism#Mature</seealso>
    let Mature = Prefixed_Name(organism, "Mature") |> PrefixedName
    /// <summary>
    ///   <para>organism:MatureOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"mature organism"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#MatureOrganism">http://eulersharp.sourceforge.net/2003/03swap/organism#MatureOrganism</seealso>
    let MatureOrganism = Prefixed_Name(organism, "MatureOrganism") |> PrefixedName
    /// <summary>
    ///   <para>organism:Mortal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"mortal"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mortal">http://eulersharp.sourceforge.net/2003/03swap/organism#Mortal</seealso>
    let Mortal = Prefixed_Name(organism, "Mortal") |> PrefixedName
    /// <summary>
    ///   <para>organism:Mother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"biological mother"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mother">http://eulersharp.sourceforge.net/2003/03swap/organism#Mother</seealso>
    let Mother = Prefixed_Name(organism, "Mother") |> PrefixedName
    /// <summary>
    ///   <para>organism:Nonpregnant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>organism:Gravidity</para>
    ///
    /// labels<para>"nonpregnant"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Nonpregnant">http://eulersharp.sourceforge.net/2003/03swap/organism#Nonpregnant</seealso>
    let Nonpregnant = Prefixed_Name(organism, "Nonpregnant") |> PrefixedName
    /// <summary>
    ///   <para>organism:Offspring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"biological offspring"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Offspring">http://eulersharp.sourceforge.net/2003/03swap/organism#Offspring</seealso>
    let Offspring = Prefixed_Name(organism, "Offspring") |> PrefixedName
    /// <summary>
    ///   <para>organism:Organism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"organism"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Organism">http://eulersharp.sourceforge.net/2003/03swap/organism#Organism</seealso>
    let Organism = Prefixed_Name(organism, "Organism") |> PrefixedName
    /// <summary>
    ///   <para>organism:Parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organism that produces another."</para>
    /// labels<para>"biological parent"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parent">http://eulersharp.sourceforge.net/2003/03swap/organism#Parent</seealso>
    let Parent = Prefixed_Name(organism, "Parent") |> PrefixedName
    /// <summary>
    ///   <para>organism:Parents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parents">http://eulersharp.sourceforge.net/2003/03swap/organism#Parents</seealso>
    let Parents = Prefixed_Name(organism, "Parents") |> PrefixedName
    /// <summary>
    ///   <para>organism:Pregnant</para>
    /// </summary>
    /// <remarks>
    ///   <para>organism:Gravidity</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"pregnant"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Pregnant">http://eulersharp.sourceforge.net/2003/03swap/organism#Pregnant</seealso>
    let Pregnant = Prefixed_Name(organism, "Pregnant") |> PrefixedName
    /// <summary>
    ///   <para>organism:PregnantOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"pregnant organism"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#PregnantOrganism">http://eulersharp.sourceforge.net/2003/03swap/organism#PregnantOrganism</seealso>
    let PregnantOrganism = Prefixed_Name(organism, "PregnantOrganism") |> PrefixedName
    /// <summary>
    ///   <para>organism:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"sequence"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequence">http://eulersharp.sourceforge.net/2003/03swap/organism#Sequence</seealso>
    let Sequence = Prefixed_Name(organism, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>organism:Sequencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"sequencing"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequencing">http://eulersharp.sourceforge.net/2003/03swap/organism#Sequencing</seealso>
    let Sequencing = Prefixed_Name(organism, "Sequencing") |> PrefixedName

    /// <summary>
    ///   <para>organism:UnbranchedBioPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"unbranched bioPolymer"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#UnbranchedBioPolymer">http://eulersharp.sourceforge.net/2003/03swap/organism#UnbranchedBioPolymer</seealso>
    let UnbranchedBioPolymer =
        Prefixed_Name(organism, "UnbranchedBioPolymer") |> PrefixedName

    /// <summary>
    ///   <para>organism:beginDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#beginDate">http://eulersharp.sourceforge.net/2003/03swap/organism#beginDate</seealso>
    let beginDate = Prefixed_Name(organism, "beginDate") |> PrefixedName
    /// <summary>
    ///   <para>organism:begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#begins">http://eulersharp.sourceforge.net/2003/03swap/organism#begins</seealso>
    let begins = Prefixed_Name(organism, "begins") |> PrefixedName
    /// <summary>
    ///   <para>organism:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#endDate">http://eulersharp.sourceforge.net/2003/03swap/organism#endDate</seealso>
    let endDate = Prefixed_Name(organism, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>organism:ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#ends">http://eulersharp.sourceforge.net/2003/03swap/organism#ends</seealso>
    let ends = Prefixed_Name(organism, "ends") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has birth date"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDate">http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(organism, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasBirthDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has birth date time"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDateTime">http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDateTime</seealso>
    let hasBirthDateTime = Prefixed_Name(organism, "hasBirthDateTime") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasBirthTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has birth time"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthTime">http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthTime</seealso>
    let hasBirthTime = Prefixed_Name(organism, "hasBirthTime") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasCauseOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasCauseOfDeath">http://eulersharp.sourceforge.net/2003/03swap/organism#hasCauseOfDeath</seealso>
    let hasCauseOfDeath = Prefixed_Name(organism, "hasCauseOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasChild">http://eulersharp.sourceforge.net/2003/03swap/organism#hasChild</seealso>
    let hasChild = Prefixed_Name(organism, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasDNASequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has DNA Sequence"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDNASequence">http://eulersharp.sourceforge.net/2003/03swap/organism#hasDNASequence</seealso>
    let hasDNASequence = Prefixed_Name(organism, "hasDNASequence") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasDeathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has death date"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDate">http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDate</seealso>
    let hasDeathDate = Prefixed_Name(organism, "hasDeathDate") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasDeathDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has death date time"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDateTime">http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDateTime</seealso>
    let hasDeathDateTime = Prefixed_Name(organism, "hasDeathDateTime") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasDeathTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has death time"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathTime">http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathTime</seealso>
    let hasDeathTime = Prefixed_Name(organism, "hasDeathTime") |> PrefixedName

    /// <summary>
    ///   <para>organism:hasDevelopmentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDevelopmentState">http://eulersharp.sourceforge.net/2003/03swap/organism#hasDevelopmentState</seealso>
    let hasDevelopmentState =
        Prefixed_Name(organism, "hasDevelopmentState") |> PrefixedName

    /// <summary>
    ///   <para>organism:hasFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasFather">http://eulersharp.sourceforge.net/2003/03swap/organism#hasFather</seealso>
    let hasFather = Prefixed_Name(organism, "hasFather") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasGravidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasGravidity">http://eulersharp.sourceforge.net/2003/03swap/organism#hasGravidity</seealso>
    let hasGravidity = Prefixed_Name(organism, "hasGravidity") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasKaryotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has karyotype"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasKaryotype">http://eulersharp.sourceforge.net/2003/03swap/organism#hasKaryotype</seealso>
    let hasKaryotype = Prefixed_Name(organism, "hasKaryotype") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasMother">http://eulersharp.sourceforge.net/2003/03swap/organism#hasMother</seealso>
    let hasMother = Prefixed_Name(organism, "hasMother") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasParent">http://eulersharp.sourceforge.net/2003/03swap/organism#hasParent</seealso>
    let hasParent = Prefixed_Name(organism, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sequence"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasSequence">http://eulersharp.sourceforge.net/2003/03swap/organism#hasSequence</seealso>
    let hasSequence = Prefixed_Name(organism, "hasSequence") |> PrefixedName
    /// <summary>
    ///   <para>organism:hasTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasTaxon">http://eulersharp.sourceforge.net/2003/03swap/organism#hasTaxon</seealso>
    let hasTaxon = Prefixed_Name(organism, "hasTaxon") |> PrefixedName
    /// <summary>
    ///   <para>organism:lives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#lives">http://eulersharp.sourceforge.net/2003/03swap/organism#lives</seealso>
    let lives = Prefixed_Name(organism, "lives") |> PrefixedName
    /// <summary>
    ///   <para>organism:sequenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sequence of"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organism#sequenceOf">http://eulersharp.sourceforge.net/2003/03swap/organism#sequenceOf</seealso>
    let sequenceOf = Prefixed_Name(organism, "sequenceOf") |> PrefixedName
