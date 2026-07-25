namespace http.purl.org.net.hifm.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hifm =
    let _namespace_iri = Namespace_Iri hifm |> NamespaceIRI
    /// <summary>
    ///   <para>hifm:dosageForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the dosage form of the medicine.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#dosageForm">http://purl.org/net/hifm/ontology#dosageForm</seealso>
    let dosageForm = Prefixed_Name(hifm, "dosageForm") |> PrefixedName
    /// <summary>
    ///   <para>hifm:notes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents additional notes related to a medicine.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#notes">http://purl.org/net/hifm/ontology#notes</seealso>
    let notes = Prefixed_Name(hifm, "notes") |> PrefixedName
    /// <summary>
    ///   <para>hifm:packaging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the number of units per drug package.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#packaging">http://purl.org/net/hifm/ontology#packaging</seealso>
    let packaging = Prefixed_Name(hifm, "packaging") |> PrefixedName
    /// <summary>
    ///   <para>hifm:similarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a similarity that is known between two drugs.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#similarTo">http://purl.org/net/hifm/ontology#similarTo</seealso>
    let similarTo = Prefixed_Name(hifm, "similarTo") |> PrefixedName
    /// <summary>
    ///   <para>hifm:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This is the ID that the medicine has in the local system of the Health Insurance Fund of Macedonia</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#id">http://purl.org/net/hifm/ontology#id</seealso>
    let id = Prefixed_Name(hifm, "id") |> PrefixedName
    /// <summary>
    ///   <para>hifm:refPriceWithVAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the referent value of the medicine in macedonian denars (MKD), with VAT calculated</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#refPriceWithVAT">http://purl.org/net/hifm/ontology#refPriceWithVAT</seealso>
    let refPriceWithVAT = Prefixed_Name(hifm, "refPriceWithVAT") |> PrefixedName
    /// <summary>
    ///   <para>hifm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The HIFM Ontology.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#">http://purl.org/net/hifm/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(hifm, "") |> PrefixedName
    /// <summary>
    ///   <para>hifm:Drug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a brand-name drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#Drug">http://purl.org/net/hifm/ontology#Drug</seealso>
    let Drug = Prefixed_Name(hifm, "Drug") |> PrefixedName
    /// <summary>
    ///   <para>hifm:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents a manufacturer of a drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#manufacturer">http://purl.org/net/hifm/ontology#manufacturer</seealso>
    let manufacturer = Prefixed_Name(hifm, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>hifm:refPriceNoVAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the referent price of the medicine in macedonian denars (MKD), with NO VAT calculated</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#refPriceNoVAT">http://purl.org/net/hifm/ontology#refPriceNoVAT</seealso>
    let refPriceNoVAT = Prefixed_Name(hifm, "refPriceNoVAT") |> PrefixedName
    /// <summary>
    ///   <para>hifm:strength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the strength of the drug, in milligrams.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/hifm/ontology#strength">http://purl.org/net/hifm/ontology#strength</seealso>
    let strength = Prefixed_Name(hifm, "strength") |> PrefixedName
