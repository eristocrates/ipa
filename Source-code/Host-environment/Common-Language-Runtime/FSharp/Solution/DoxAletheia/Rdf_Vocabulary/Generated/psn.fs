namespace https.purl.org.psn.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module psn =
    let _namespace_iri = Namespace_Iri psn |> NamespaceIRI
    /// <summary>
    ///   <para>psn:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A product offered to customers by an enterprise. Products may be created in discrete or continuous manufacturing. Also includes services that are not an infinite pool but a limited amount of depletable (time)slots. Intermediate products not sold are abstracted into the product that is sold. Abstraction level of product model ('a BMW iX'), not product instance ('that blue BMW iX over there in the corner'). May also represent a product group of similar products having alike structures, similar characteristics, and production routes, that vary only in certain well-described ways, such as by size, color, or material. Not on the abstraction level of product model ('car').</para>
    /// labels<para>Product</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#Product">https://purl.org/psn/vocab#Product</seealso>
    let Product = Prefixed_Name(psn, "Product") |> PrefixedName
    /// <summary>
    ///   <para>psn:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The quantity of a product required in the creation of another product as described by a psn:Derivation. Has to regard the psn:unit property of the products.</para>
    /// labels<para>quantity</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#quantity">https://purl.org/psn/vocab#quantity</seealso>
    let quantity = Prefixed_Name(psn, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>psn:sells</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Product offered for sale by the enterprise to (potential) customers.</para>
    /// labels<para>sells</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#sells">https://purl.org/psn/vocab#sells</seealso>
    let sells = Prefixed_Name(psn, "sells") |> PrefixedName
    /// <summary>
    ///   <para>psn:Derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The dependency relation between products in a supply network, characterized by the (partial) consumption of one product for the creation of another. This does not necessitate that a product becomes part of a (physical) presence of the created product. Such examples are chemicals used for cleaning in the manufacturing of microchip or a foundry service (time)slot. Neither example becomes a microchip, but without them, no new microchip are created. The derivation usually expresses the relation between two products, but may include multiple psn:from properties to express alternatives.</para>
    /// labels<para>Derivation</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#Derivation">https://purl.org/psn/vocab#Derivation</seealso>
    let Derivation = Prefixed_Name(psn, "Derivation") |> PrefixedName
    /// <summary>
    ///   <para>psn:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Product that is (partially) consumed for the creation of another product. The latter derives from the former. If a psn:Derivation has multiple psn:from properties, these products are alternatives.</para>
    /// labels<para>from</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#from">https://purl.org/psn/vocab#from</seealso>
    let from = Prefixed_Name(psn, "from") |> PrefixedName
    /// <summary>
    ///   <para>psn:Enterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An enterprise that supervises the creation of products and sells products to (potential) customers.</para>
    /// labels<para>Enterprise</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#Enterprise">https://purl.org/psn/vocab#Enterprise</seealso>
    let Enterprise = Prefixed_Name(psn, "Enterprise") |> PrefixedName
    /// <summary>
    ///   <para>psn:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Product Supply Network Vocabulary</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#">https://purl.org/psn/vocab#</seealso>
    let _prefix_iri = Prefixed_Name(psn, "") |> PrefixedName
    /// <summary>
    ///   <para>psn:into</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Product that is created while (partially) consuming another product. The latter derives into the former.</para>
    /// labels<para>into</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#into">https://purl.org/psn/vocab#into</seealso>
    let into = Prefixed_Name(psn, "into") |> PrefixedName
    /// <summary>
    ///   <para>psn:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The unit of measure for the quantity of a volumetric product. To state that 20 ml of cleaning liquid derives into one microchip, set the psn:unit of the cleaning liquid as unit:MilliL and the psn:quantity of the psn:Derivation as '20'. To state that 1 ml of cleaning liquid derives from 0.6 ml of water, set the psn:unit of the water as unit:MilliL and the psn:quantity of the psn:Derivation as '0.6'.</para>
    /// labels<para>unit</para></remarks>
    /// <seealso href="https://purl.org/psn/vocab#unit">https://purl.org/psn/vocab#unit</seealso>
    let unit = Prefixed_Name(psn, "unit") |> PrefixedName
