#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module organism =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/organism#" "organism"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : alive</para>
    ///   <para>skos:definition : State of being capable of response to stimuli, reproduction, growth and development, and maintenance of homeostasis as a stable whole.</para>
    ///   <para>skos:note : Up till now no satisfying definition.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Alive">organism:Alive</a>
    /// </summary>
    let Alive = _prefixId.prefix "Alive"
    let Ancestry = _prefixId.prefix "Ancestry"
    /// <summary>
    ///   <para>rdfs:label : biological ascendant</para>
    ///   <para>skos:definition : Living ascendant of any kind.</para>
    ///   <para>rdfs:comment : Organism that is an earlier form of another organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Ascendant">organism:Ascendant</a>
    /// </summary>
    let Ascendant = _prefixId.prefix "Ascendant"
    /// <summary>
    ///   <para>rdfs:label : biological child</para>
    ///   <para>skos:definition : First grade living descendant of any kind.</para>
    ///   <para>rdfs:comment : Organism that is produced by another.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Child">organism:Child</a>
    /// </summary>
    let Child = _prefixId.prefix "Child"
    /// <summary>
    ///   <para>skos:definition : Children of the same biological parent(s).</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Children">organism:Children</a>
    /// </summary>
    let Children = _prefixId.prefix "Children"
    /// <summary>
    ///   <para>rdfs:label : deoxyribonucleic acid </para>
    ///   <para>skos:definition : Nucleic acid containing genetic instructions for development and functioning of organisms, except RNA viruses.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNA">organism:DNA</a>
    /// </summary>
    let DNA = _prefixId.prefix "DNA"
    /// <summary>
    ///   <para>rdfs:label : DNA sequence</para>
    ///   <para>skos:definition : Determination of a nucleotide order of DNA of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequence">organism:DNASequence</a>
    /// </summary>
    let DNASequence = _prefixId.prefix "DNASequence"
    /// <summary>
    ///   <para>rdfs:label : DNA sequencing</para>
    ///   <para>skos:definition : Determining a nucleotide order of DNA of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#DNASequencing">organism:DNASequencing</a>
    /// </summary>
    let DNASequencing = _prefixId.prefix "DNASequencing"
    /// <summary>
    ///   <para>rdfs:label : dead</para>
    ///   <para>skos:definition : State of being not alive anymore.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Dead">organism:Dead</a>
    /// </summary>
    let Dead = _prefixId.prefix "Dead"
    /// <summary>
    ///   <para>rdfs:label : death</para>
    ///   <para>skos:definition : Finding of the remains of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Death">organism:Death</a>
    /// </summary>
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>rdfs:label : cause of death</para>
    ///   <para>skos:definition : Action causing death.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#DeathCause">organism:DeathCause</a>
    /// </summary>
    let DeathCause = _prefixId.prefix "DeathCause"
    /// <summary>
    ///   <para>rdfs:label : biological descendant</para>
    ///   <para>skos:definition : Living descendant of any kind.</para>
    ///   <para>rdfs:comment : Organism deriving from an earlier form.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Descendant">organism:Descendant</a>
    /// </summary>
    let Descendant = _prefixId.prefix "Descendant"
    /// <summary>
    ///   <para>rdfs:label : development state</para>
    ///   <para>skos:definition : Any state of development.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#DevelopmentState">organism:DevelopmentState</a>
    /// </summary>
    let DevelopmentState = _prefixId.prefix "DevelopmentState"
    /// <summary>
    ///   <para>rdfs:label : eukaryote</para>
    ///   <para>skos:definition : Organism with a cellular nucleus.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Eukaryote">organism:Eukaryote</a>
    /// </summary>
    let Eukaryote = _prefixId.prefix "Eukaryote"
    /// <summary>
    ///   <para>rdfs:label : biological father</para>
    ///   <para>skos:definition : Male biological parent.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Father">organism:Father</a>
    /// </summary>
    let Father = _prefixId.prefix "Father"
    /// <summary>
    ///   <para>rdfs:label : genome</para>
    ///   <para>skos:definition : All hereditary information of an organism coded in nucleotide chains.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Genome">organism:Genome</a>
    /// </summary>
    let Genome = _prefixId.prefix "Genome"
    /// <summary>
    ///   <para>rdfs:label : gravidity</para>
    ///   <para>skos:definition : Any state of gravidity.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Gravidity">organism:Gravidity</a>
    /// </summary>
    let Gravidity = _prefixId.prefix "Gravidity"
    /// <summary>
    ///   <para>rdfs:label : immature</para>
    ///   <para>skos:definition : State of being biologically not full-grown.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Immature">organism:Immature</a>
    /// </summary>
    let Immature = _prefixId.prefix "Immature"
    /// <summary>
    ///   <para>rdfs:label : immature organism</para>
    ///   <para>skos:definition : Organism being immature.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#ImmatureOrganism">organism:ImmatureOrganism</a>
    /// </summary>
    let ImmatureOrganism = _prefixId.prefix "ImmatureOrganism"
    /// <summary>
    ///   <para>rdfs:label : individual life</para>
    ///   <para>skos:definition : Life of an organism after birth.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#IndividualLife">organism:IndividualLife</a>
    /// </summary>
    let IndividualLife = _prefixId.prefix "IndividualLife"
    /// <summary>
    ///   <para>rdfs:label : karyotype</para>
    ///   <para>skos:definition : Classification of chromosomes from a nucleus of a eukaryotic cell according to the number, size, shape, banding pattern, placement of centromere or other characteristics.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotype">organism:Karyotype</a>
    /// </summary>
    let Karyotype = _prefixId.prefix "Karyotype"
    /// <summary>
    ///   <para>rdfs:label : karyotyping</para>
    ///   <para>skos:definition : Classifying chromosomes from a nucleus of a eukaryotic cell according to number, size, shape, banding pattern, placement of centromere or other characteristics.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Karyotyping">organism:Karyotyping</a>
    /// </summary>
    let Karyotyping = _prefixId.prefix "Karyotyping"
    /// <summary>
    ///   <para>rdfs:label : life</para>
    ///   <para>skos:definition : The action of being alive.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Life">organism:Life</a>
    /// </summary>
    let Life = _prefixId.prefix "Life"
    /// <summary>
    ///   <para>rdfs:label : mature</para>
    ///   <para>skos:definition : State of being biologically full-grown.</para>
    ///   <para>rdfs:comment : A criterium can be: capable of reproduction.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mature">organism:Mature</a>
    /// </summary>
    let Mature = _prefixId.prefix "Mature"
    /// <summary>
    ///   <para>rdfs:label : mature organism</para>
    ///   <para>skos:definition : Organism being mature.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#MatureOrganism">organism:MatureOrganism</a>
    /// </summary>
    let MatureOrganism = _prefixId.prefix "MatureOrganism"
    /// <summary>
    ///   <para>rdfs:label : mortal</para>
    ///   <para>skos:definition : State of having a limited lifetime.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mortal">organism:Mortal</a>
    /// </summary>
    let Mortal = _prefixId.prefix "Mortal"
    /// <summary>
    ///   <para>rdfs:label : biological mother</para>
    ///   <para>skos:definition : Female biological parent.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Mother">organism:Mother</a>
    /// </summary>
    let Mother = _prefixId.prefix "Mother"
    /// <summary>
    ///   <para>rdfs:label : nonpregnant</para>
    ///   <para>skos:definition : State of an organism of not having offspring developing in its body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Nonpregnant">organism:Nonpregnant</a>
    /// </summary>
    let Nonpregnant = _prefixId.prefix "Nonpregnant"
    /// <summary>
    ///   <para>rdfs:label : biological offspring</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Offspring">organism:Offspring</a>
    /// </summary>
    let Offspring = _prefixId.prefix "Offspring"
    /// <summary>
    ///   <para>rdfs:label : organism</para>
    ///   <para>skos:definition : Something that lives.</para>
    ///   <para>skos:note : Superclass can be organism in a more general way: any complex thing having properties and functions determined not only by the properties of its individual parts, but by the character of the whole that they compose and by the relations of the parts to the whole.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Organism">organism:Organism</a>
    /// </summary>
    let Organism = _prefixId.prefix "Organism"
    /// <summary>
    ///   <para>rdfs:label : biological parent</para>
    ///   <para>skos:definition : First grade ascendant of an organism.</para>
    ///   <para>rdfs:comment : Organism that produces another.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Parent">organism:Parent</a>
    /// </summary>
    let Parent = _prefixId.prefix "Parent"
    let Parents = _prefixId.prefix "Parents"
    /// <summary>
    ///   <para>rdfs:label : pregnant</para>
    ///   <para>skos:definition : State of an organism of having offspring developing in its body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Pregnant">organism:Pregnant</a>
    /// </summary>
    let Pregnant = _prefixId.prefix "Pregnant"
    /// <summary>
    ///   <para>rdfs:label : pregnant organism</para>
    ///   <para>skos:definition : Organism being pregnant.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#PregnantOrganism">organism:PregnantOrganism</a>
    /// </summary>
    let PregnantOrganism = _prefixId.prefix "PregnantOrganism"
    /// <summary>
    ///   <para>rdfs:label : sequence</para>
    ///   <para>skos:definition : Determination of a primary structure or sequence of an unbranched biopolymer of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequence">organism:Sequence</a>
    /// </summary>
    let Sequence = _prefixId.prefix "Sequence"
    /// <summary>
    ///   <para>rdfs:label : sequencing</para>
    ///   <para>skos:definition : Determining a primary structure or sequence of an unbranched biopolymer of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#Sequencing">organism:Sequencing</a>
    /// </summary>
    let Sequencing = _prefixId.prefix "Sequencing"
    /// <summary>
    ///   <para>rdfs:label : unbranched bioPolymer</para>
    ///   <para>skos:definition : Polymer of an organism without branch.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#UnbranchedBioPolymer">organism:UnbranchedBioPolymer</a>
    /// </summary>
    let UnbranchedBioPolymer = _prefixId.prefix "UnbranchedBioPolymer"
    /// <summary>
    ///   <para>skos:definition : Specifying the beginning of a life of an organism as individual.</para>
    ///   <para>skos:note : End of a delivery.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#beginDate">organism:beginDate</a>
    /// </summary>
    let beginDate = _prefixId.prefix "beginDate"
    /// <summary>
    ///   <para>skos:definition : Specifying the beginning of a life of an organism as individual.</para>
    ///   <para>skos:note : End of a delivery.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#begins">organism:begins</a>
    /// </summary>
    let begins = _prefixId.prefix "begins"
    /// <summary>
    ///   <para>skos:definition : Specifying the endpoint in time of a life of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#endDate">organism:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>skos:definition : Specifying the endpoint in time of a life of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#ends">organism:ends</a>
    /// </summary>
    let ends = _prefixId.prefix "ends"
    /// <summary>
    ///   <para>rdfs:label : has birth date</para>
    ///   <para>skos:definition : Specifying a date an organism is born on.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDate">organism:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>rdfs:label : has birth date time</para>
    ///   <para>skos:definition : Specifying a snapshot event's date and time an organism is born on.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthDateTime">organism:hasBirthDateTime</a>
    /// </summary>
    let hasBirthDateTime = _prefixId.prefix "hasBirthDateTime"
    /// <summary>
    ///   <para>rdfs:label : has birth time</para>
    ///   <para>skos:definition : Specifying a snapshot event's time of a day an organism is born on.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasBirthTime">organism:hasBirthTime</a>
    /// </summary>
    let hasBirthTime = _prefixId.prefix "hasBirthTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a cause of death of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasCauseOfDeath">organism:hasCauseOfDeath</a>
    /// </summary>
    let hasCauseOfDeath = _prefixId.prefix "hasCauseOfDeath"
    /// <summary>
    ///   <para>skos:definition : Specifying the first grade descendant of an organism or group of organisms.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasChild">organism:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:label : has DNA Sequence</para>
    ///   <para>skos:definition : Specifying a DNA sequence of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDNASequence">organism:hasDNASequence</a>
    /// </summary>
    let hasDNASequence = _prefixId.prefix "hasDNASequence"
    /// <summary>
    ///   <para>rdfs:label : has death date</para>
    ///   <para>skos:definition : Specifying a snapshot event's date an organism died on.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDate">organism:hasDeathDate</a>
    /// </summary>
    let hasDeathDate = _prefixId.prefix "hasDeathDate"
    /// <summary>
    ///   <para>rdfs:label : has death date time</para>
    ///   <para>skos:definition : Specifying a snapshot event's date and time an organism died on.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathDateTime">organism:hasDeathDateTime</a>
    /// </summary>
    let hasDeathDateTime = _prefixId.prefix "hasDeathDateTime"
    /// <summary>
    ///   <para>rdfs:label : has death time</para>
    ///   <para>skos:definition : Specifying the time of a day an organism died.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDeathTime">organism:hasDeathTime</a>
    /// </summary>
    let hasDeathTime = _prefixId.prefix "hasDeathTime"
    /// <summary>
    ///   <para>skos:definition : Specifying the state of development of an individual organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasDevelopmentState">organism:hasDevelopmentState</a>
    /// </summary>
    let hasDevelopmentState = _prefixId.prefix "hasDevelopmentState"
    /// <summary>
    ///   <para>skos:definition : Specifying the first grade male ascendent of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasFather">organism:hasFather</a>
    /// </summary>
    let hasFather = _prefixId.prefix "hasFather"
    /// <summary>
    ///   <para>skos:definition : Specifying the gravidity of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasGravidity">organism:hasGravidity</a>
    /// </summary>
    let hasGravidity = _prefixId.prefix "hasGravidity"
    /// <summary>
    ///   <para>rdfs:label : has karyotype</para>
    ///   <para>skos:definition : Specifying a karyotype of a eukaryote.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasKaryotype">organism:hasKaryotype</a>
    /// </summary>
    let hasKaryotype = _prefixId.prefix "hasKaryotype"
    /// <summary>
    ///   <para>skos:definition : Specifying the first grade female ascendent of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasMother">organism:hasMother</a>
    /// </summary>
    let hasMother = _prefixId.prefix "hasMother"
    /// <summary>
    ///   <para>skos:definition : Specifying the first grade ascendent of an organism or group of organisms.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasParent">organism:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:label : has sequence</para>
    ///   <para>skos:definition : Specifying a sequence of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasSequence">organism:hasSequence</a>
    /// </summary>
    let hasSequence = _prefixId.prefix "hasSequence"
    /// <summary>
    ///   <para>skos:definition : Specifying the taxonomic identity of an organism as defined in uniprot taxonomy.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#hasTaxon">organism:hasTaxon</a>
    /// </summary>
    let hasTaxon = _prefixId.prefix "hasTaxon"
    /// <summary>
    ///   <para>skos:definition : Specifying a life process of an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#lives">organism:lives</a>
    /// </summary>
    let lives = _prefixId.prefix "lives"
    /// <summary>
    ///   <para>rdfs:label : sequence of</para>
    ///   <para>skos:definition : Specifying an organism's specimen having a sequence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organism#sequenceOf">organism:sequenceOf</a>
    /// </summary>
    let sequenceOf = _prefixId.prefix "sequenceOf"
