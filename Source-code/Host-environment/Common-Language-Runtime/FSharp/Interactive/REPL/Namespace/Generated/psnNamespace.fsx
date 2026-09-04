#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module psn =
    let _prefixId = PrefixId.fromNamespaceLabel "https://purl.org/psn/vocab#" "psn"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Derivation</para>
    ///   <para>rdfs:comment : The dependency relation between products in a supply network, characterized by the (partial) consumption of one product for the creation of another. This does not necessitate that a product becomes part of a (physical) presence of the created product. Such examples are chemicals used for cleaning in the manufacturing of microchip or a foundry service (time)slot. Neither example becomes a microchip, but without them, no new microchip are created. The derivation usually expresses the relation between two products, but may include multiple psn:from properties to express alternatives.</para>
    ///   <a href="https://purl.org/psn/vocab#Derivation">psn:Derivation</a>
    /// </summary>
    let Derivation = _prefixId.prefix "Derivation"
    /// <summary>
    ///   <para>rdfs:label : Enterprise</para>
    ///   <para>rdfs:comment : An enterprise that supervises the creation of products and sells products to (potential) customers.</para>
    ///   <a href="https://purl.org/psn/vocab#Enterprise">psn:Enterprise</a>
    /// </summary>
    let Enterprise = _prefixId.prefix "Enterprise"
    /// <summary>
    ///   <para>rdfs:label : Product</para>
    ///   <para>rdfs:comment : A product offered to customers by an enterprise. Products may be created in discrete or continuous manufacturing. Also includes services that are not an infinite pool but a limited amount of depletable (time)slots. Intermediate products not sold are abstracted into the product that is sold. Abstraction level of product model ('a BMW iX'), not product instance ('that blue BMW iX over there in the corner'). May also represent a product group of similar products having alike structures, similar characteristics, and production routes, that vary only in certain well-described ways, such as by size, color, or material. Not on the abstraction level of product model ('car').</para>
    ///   <a href="https://purl.org/psn/vocab#Product">psn:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : from</para>
    ///   <para>rdfs:comment : Product that is (partially) consumed for the creation of another product. The latter derives from the former. If a psn:Derivation has multiple psn:from properties, these products are alternatives.</para>
    ///   <a href="https://purl.org/psn/vocab#from">psn:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>rdfs:label : into</para>
    ///   <para>rdfs:comment : Product that is created while (partially) consuming another product. The latter derives into the former.</para>
    ///   <a href="https://purl.org/psn/vocab#into">psn:into</a>
    /// </summary>
    let into = _prefixId.prefix "into"
    /// <summary>
    ///   <para>rdfs:label : quantity</para>
    ///   <para>rdfs:comment : The quantity of a product required in the creation of another product as described by a psn:Derivation. Has to regard the psn:unit property of the products.</para>
    ///   <a href="https://purl.org/psn/vocab#quantity">psn:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>rdfs:label : sells</para>
    ///   <para>rdfs:comment : Product offered for sale by the enterprise to (potential) customers.</para>
    ///   <a href="https://purl.org/psn/vocab#sells">psn:sells</a>
    /// </summary>
    let sells = _prefixId.prefix "sells"
    /// <summary>
    ///   <para>rdfs:label : unit</para>
    ///   <para>rdfs:comment : The unit of measure for the quantity of a volumetric product. To state that 20 ml of cleaning liquid derives into one microchip, set the psn:unit of the cleaning liquid as unit:MilliL and the psn:quantity of the psn:Derivation as '20'. To state that 1 ml of cleaning liquid derives from 0.6 ml of water, set the psn:unit of the water as unit:MilliL and the psn:quantity of the psn:Derivation as '0.6'.</para>
    ///   <a href="https://purl.org/psn/vocab#unit">psn:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
