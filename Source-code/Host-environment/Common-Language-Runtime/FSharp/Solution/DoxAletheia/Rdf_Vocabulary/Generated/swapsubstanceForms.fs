namespace http.eulersharp.sourceforge.net._2003._03swap.substanceForms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapsubstanceForms =
    let _namespace_iri = Namespace_Iri swapsubstanceForms |> NamespaceIRI
    /// <summary>
    ///   <para>swapsubstanceForms:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#">http://eulersharp.sourceforge.net/2003/03swap/substanceForms#</seealso>
    let _prefix_iri = Prefixed_Name(swapsubstanceForms, "") |> PrefixedName

    /// <summary>
    ///   <para>swapsubstanceForms:GranularSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>granular substance</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#GranularSubstance">http://eulersharp.sourceforge.net/2003/03swap/substanceForms#GranularSubstance</seealso>
    let GranularSubstance =
        Prefixed_Name(swapsubstanceForms, "GranularSubstance") |> PrefixedName

    /// <summary>
    ///   <para>swapsubstanceForms:Powder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>powder</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/substanceForms#Powder">http://eulersharp.sourceforge.net/2003/03swap/substanceForms#Powder</seealso>
    let Powder = Prefixed_Name(swapsubstanceForms, "Powder") |> PrefixedName
