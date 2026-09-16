#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module genomab =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#" "genomab"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : aneuploidy</para>
    ///   <para>skos:definition : Numerical chromosome abnormality.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Aneuploidy">genomab:Aneuploidy</a>
    /// </summary>
    let Aneuploidy = _prefixId.prefix "Aneuploidy"
    /// <summary>
    ///   <para>rdfs:label : chromosome abnormality</para>
    ///   <para>skos:definition : Chromosome different from what is normal for an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeAbnormality">genomab:ChromosomeAbnormality</a>
    /// </summary>
    let ChromosomeAbnormality = _prefixId.prefix "ChromosomeAbnormality"
    /// <summary>
    ///   <para>rdfs:label : chromosome deletion</para>
    ///   <para>skos:definition : Loss of part of 1 chromosome.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeDeletion">genomab:ChromosomeDeletion</a>
    /// </summary>
    let ChromosomeDeletion = _prefixId.prefix "ChromosomeDeletion"
    /// <summary>
    ///   <para>rdfs:label : chromosome duplication</para>
    ///   <para>skos:definition : Duplication of part of 1 chromosome.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeDuplication">genomab:ChromosomeDuplication</a>
    /// </summary>
    let ChromosomeDuplication = _prefixId.prefix "ChromosomeDuplication"
    /// <summary>
    ///   <para>rdfs:label : chromosome insertion</para>
    ///   <para>skos:definition : Part of one chromosome inserted into another chromosome.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeInsertion">genomab:ChromosomeInsertion</a>
    /// </summary>
    let ChromosomeInsertion = _prefixId.prefix "ChromosomeInsertion"
    /// <summary>
    ///   <para>rdfs:label : chromosome inversion</para>
    ///   <para>skos:definition : Inversion of part of 1 chromosome.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeInversion">genomab:ChromosomeInversion</a>
    /// </summary>
    let ChromosomeInversion = _prefixId.prefix "ChromosomeInversion"
    /// <summary>
    ///   <para>rdfs:label : chromosome mutation</para>
    ///   <para>skos:definition : Structural chromosome abnormality.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeMutation">genomab:ChromosomeMutation</a>
    /// </summary>
    let ChromosomeMutation = _prefixId.prefix "ChromosomeMutation"
    /// <summary>
    ///   <para>rdfs:label : chromosome translocation</para>
    ///   <para>skos:definition : One part of 2 chromosomes exchanged.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeTranslocation">genomab:ChromosomeTranslocation</a>
    /// </summary>
    let ChromosomeTranslocation = _prefixId.prefix "ChromosomeTranslocation"
    /// <summary>
    ///   <para>rdfs:label : gene abnormality</para>
    ///   <para>skos:definition : Gene different from what is normal for an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#GeneAbnormality">genomab:GeneAbnormality</a>
    /// </summary>
    let GeneAbnormality = _prefixId.prefix "GeneAbnormality"
    /// <summary>
    ///   <para>rdfs:label : genome abnormality</para>
    ///   <para>skos:definition : Genome different from what is normal for an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#GenomeAbnormality">genomab:GenomeAbnormality</a>
    /// </summary>
    let GenomeAbnormality = _prefixId.prefix "GenomeAbnormality"
    /// <summary>
    ///   <para>rdfs:label : monogenic mutation</para>
    ///   <para>skos:definition : One gene different from what is normal for an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#MonogenicMutation">genomab:MonogenicMutation</a>
    /// </summary>
    let MonogenicMutation = _prefixId.prefix "MonogenicMutation"
    /// <summary>
    ///   <para>rdfs:label : mutated</para>
    ///   <para>skos:definition : State of chromosome or gene being structurally changed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Mutated">genomab:Mutated</a>
    /// </summary>
    let Mutated = _prefixId.prefix "Mutated"
    /// <summary>
    ///   <para>rdfs:label : polygenic mutation</para>
    ///   <para>skos:definition : More than one gene different from what is normal for an organism.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#PolygenicMutation">genomab:PolygenicMutation</a>
    /// </summary>
    let PolygenicMutation = _prefixId.prefix "PolygenicMutation"
    /// <summary>
    ///   <para>rdfs:label : single chromosome mutation</para>
    ///   <para>skos:definition : Structural abnormality of 1 chromosome.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#SingleChromosomeMutation">genomab:SingleChromosomeMutation</a>
    /// </summary>
    let SingleChromosomeMutation = _prefixId.prefix "SingleChromosomeMutation"
    /// <summary>
    ///   <para>rdfs:label : two chromosome mutation</para>
    ///   <para>skos:definition : Structural abnormality of 2 chromosomes.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#TwoChromosomeMutation">genomab:TwoChromosomeMutation</a>
    /// </summary>
    let TwoChromosomeMutation = _prefixId.prefix "TwoChromosomeMutation"
    /// <summary>
    ///   <para>rdfs:label : unmutated</para>
    ///   <para>skos:definition : State of chromosome or gene being structurally unchanged.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Unmutated">genomab:Unmutated</a>
    /// </summary>
    let Unmutated = _prefixId.prefix "Unmutated"
