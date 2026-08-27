namespace http.aims.fao.org.aos.agrovoc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module agrovoc =
    let _namespace_iri = Namespace_Iri agrovoc |> NamespaceIRI
    /// <summary>
    ///   <para>agrovoc:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrovoc/">http://aims.fao.org/aos/agrovoc/</seealso>
    let _prefix_iri = Prefixed_Name(agrovoc, "") |> PrefixedName
    /// <summary>
    ///   <para>agrovoc:c_1333</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>"Carotenoid Reflectance Index 1 (CRI1) Carotenoids function in light absorption processes in plants, as well as in protecting plants from the harmful effects of too much light. Weakening vegetation contains higher concentrations of carotenoids, so this index is one measure of stressed vegetation. Higher CRI1 values mean greater carotenoid concentration relative to chlorophyll. The value of this index ranges from 0 to more than 15. The common range for green vegetation is 1 to 12. This index uses reflectance measurements in the visible spectrum to take advantage of the absorption signatures of stress-related pigments. See Narrowband Definitions for the allowable range of wavelengths."</para>
    /// labels<para>"CRI"</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrovoc/c_1333">http://aims.fao.org/aos/agrovoc/c_1333</seealso>
    let c_1333 = Prefixed_Name(agrovoc, "c_1333") |> PrefixedName
    /// <summary>
    ///   <para>agrovoc:c_1373987580598</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>"Information All biomass of living vegetation, both woody and herbaceous, above the soil including stems, stumps, branches, bark, seeds, and foliage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AGB"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrovoc/c_1373987580598">http://aims.fao.org/aos/agrovoc/c_1373987580598</seealso>
    let c_1373987580598 = Prefixed_Name(agrovoc, "c_1373987580598") |> PrefixedName
    /// <summary>
    ///   <para>agrovoc:c_34790</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Diameter at Breast Height (DBH). Diameter is generally measured 1.3 m. (4.5 feet) above the ground, which is roughly at breast height. DBH is measured on standing trees outside of the bark."</para>
    /// labels<para>"DBH"</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrovoc/c_34790">http://aims.fao.org/aos/agrovoc/c_34790</seealso>
    let c_34790 = Prefixed_Name(agrovoc, "c_34790") |> PrefixedName
