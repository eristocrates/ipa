namespace http.eulersharp.sourceforge.net._2003._03swap.genomeAbnormality.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module genomab =
    let _namespace_iri = Namespace_Iri genomab |> NamespaceIRI
    /// <summary>
    ///   <para>genomab:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#</seealso>
    let _prefix_iri = Prefixed_Name(genomab, "") |> PrefixedName
    /// <summary>
    ///   <para>genomab:Aneuploidy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"aneuploidy"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Aneuploidy">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Aneuploidy</seealso>
    let Aneuploidy = Prefixed_Name(genomab, "Aneuploidy") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeAbnormality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome abnormality"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeAbnormality">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeAbnormality</seealso>
    let ChromosomeAbnormality =
        Prefixed_Name(genomab, "ChromosomeAbnormality") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeDeletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome deletion"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeDeletion">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeDeletion</seealso>
    let ChromosomeDeletion =
        Prefixed_Name(genomab, "ChromosomeDeletion") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeDuplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome duplication"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeDuplication">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeDuplication</seealso>
    let ChromosomeDuplication =
        Prefixed_Name(genomab, "ChromosomeDuplication") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeInsertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome insertion"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeInsertion">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeInsertion</seealso>
    let ChromosomeInsertion =
        Prefixed_Name(genomab, "ChromosomeInsertion") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeInversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome inversion"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeInversion">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeInversion</seealso>
    let ChromosomeInversion =
        Prefixed_Name(genomab, "ChromosomeInversion") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeMutation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome mutation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeMutation">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeMutation</seealso>
    let ChromosomeMutation =
        Prefixed_Name(genomab, "ChromosomeMutation") |> PrefixedName

    /// <summary>
    ///   <para>genomab:ChromosomeTranslocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"chromosome translocation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeTranslocation">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#ChromosomeTranslocation</seealso>
    let ChromosomeTranslocation =
        Prefixed_Name(genomab, "ChromosomeTranslocation") |> PrefixedName

    /// <summary>
    ///   <para>genomab:GeneAbnormality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"gene abnormality"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#GeneAbnormality">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#GeneAbnormality</seealso>
    let GeneAbnormality = Prefixed_Name(genomab, "GeneAbnormality") |> PrefixedName
    /// <summary>
    ///   <para>genomab:GenomeAbnormality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"genome abnormality"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#GenomeAbnormality">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#GenomeAbnormality</seealso>
    let GenomeAbnormality = Prefixed_Name(genomab, "GenomeAbnormality") |> PrefixedName
    /// <summary>
    ///   <para>genomab:MonogenicMutation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"monogenic mutation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#MonogenicMutation">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#MonogenicMutation</seealso>
    let MonogenicMutation = Prefixed_Name(genomab, "MonogenicMutation") |> PrefixedName
    /// <summary>
    ///   <para>genomab:Mutated</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"mutated"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Mutated">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Mutated</seealso>
    let Mutated = Prefixed_Name(genomab, "Mutated") |> PrefixedName
    /// <summary>
    ///   <para>genomab:PolygenicMutation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"polygenic mutation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#PolygenicMutation">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#PolygenicMutation</seealso>
    let PolygenicMutation = Prefixed_Name(genomab, "PolygenicMutation") |> PrefixedName

    /// <summary>
    ///   <para>genomab:SingleChromosomeMutation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"single chromosome mutation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#SingleChromosomeMutation">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#SingleChromosomeMutation</seealso>
    let SingleChromosomeMutation =
        Prefixed_Name(genomab, "SingleChromosomeMutation") |> PrefixedName

    /// <summary>
    ///   <para>genomab:TwoChromosomeMutation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"two chromosome mutation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#TwoChromosomeMutation">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#TwoChromosomeMutation</seealso>
    let TwoChromosomeMutation =
        Prefixed_Name(genomab, "TwoChromosomeMutation") |> PrefixedName

    /// <summary>
    ///   <para>genomab:Unmutated</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"unmutated"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Unmutated">http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#Unmutated</seealso>
    let Unmutated = Prefixed_Name(genomab, "Unmutated") |> PrefixedName
