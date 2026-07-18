namespace https.purl.org.psn.vocab.hash

open DoxAletheia.Rdf_Vocabulary

module psn =
    let _namespace_name = "https://purl.org/psn/vocab#"
    /// <summary>
    /// The dependency relation between products in a supply network, characterized by the (partial) consumption of one product for the creation of another. This does not necessitate that a product becomes part of a (physical) presence of the created product. Such examples are chemicals used for cleaning in the manufacturing of microchip or a foundry service (time)slot. Neither example becomes a microchip, but without them, no new microchip are created. The derivation usually expresses the relation between two products, but may include multiple psn:from properties to express alternatives.
    /// <see href="https://purl.org/psn/vocab#Derivation"></see></summary>
    let Derivation = Namespaced_IRI.parse _namespace_name "Derivation" |> NamespacedName
    /// <summary>
    /// An enterprise that supervises the creation of products and sells products to (potential) customers.
    /// <see href="https://purl.org/psn/vocab#Enterprise"></see></summary>
    let Enterprise = Namespaced_IRI.parse _namespace_name "Enterprise" |> NamespacedName
    /// <summary>
    /// A product offered to customers by an enterprise. Products may be created in discrete or continuous manufacturing. Also includes services that are not an infinite pool but a limited amount of depletable (time)slots. Intermediate products not sold are abstracted into the product that is sold. Abstraction level of product model ('a BMW iX'), not product instance ('that blue BMW iX over there in the corner'). May also represent a product group of similar products having alike structures, similar characteristics, and production routes, that vary only in certain well-described ways, such as by size, color, or material. Not on the abstraction level of product model ('car').
    /// <see href="https://purl.org/psn/vocab#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    /// Product that is (partially) consumed for the creation of another product. The latter derives from the former. If a psn:Derivation has multiple psn:from properties, these products are alternatives.
    /// <see href="https://purl.org/psn/vocab#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    /// Product that is created while (partially) consuming another product. The latter derives into the former.
    /// <see href="https://purl.org/psn/vocab#into"></see></summary>
    let into = Namespaced_IRI.parse _namespace_name "into" |> NamespacedName
    /// <summary>
    /// The quantity of a product required in the creation of another product as described by a psn:Derivation. Has to regard the psn:unit property of the products.
    /// <see href="https://purl.org/psn/vocab#quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName
    /// <summary>
    /// Product offered for sale by the enterprise to (potential) customers.
    /// <see href="https://purl.org/psn/vocab#sells"></see></summary>
    let sells = Namespaced_IRI.parse _namespace_name "sells" |> NamespacedName
    /// <summary>
    /// The unit of measure for the quantity of a volumetric product. To state that 20 ml of cleaning liquid derives into one microchip, set the psn:unit of the cleaning liquid as unit:MilliL and the psn:quantity of the psn:Derivation as '20'. To state that 1 ml of cleaning liquid derives from 0.6 ml of water, set the psn:unit of the water as unit:MilliL and the psn:quantity of the psn:Derivation as '0.6'.
    /// <see href="https://purl.org/psn/vocab#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
