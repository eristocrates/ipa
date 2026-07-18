namespace http.ns.inria.fr.provoc.hash

open DoxAletheia.Rdf_Vocabulary

module provoc =
    let _namespace_name = "http://ns.inria.fr/provoc#"

    /// <summary>
    /// This specifies the brand of a range or a product.
    /// <see href="http://ns.inria.fr/provoc#belongsToBrand"></see></summary>
    let belongsToBrand =
        Namespaced_IRI.parse _namespace_name "belongsToBrand" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#ProductOrServiceRange"></see>
    /// </summary>
    let ProductOrServiceRange =
        Namespaced_IRI.parse _namespace_name "ProductOrServiceRange" |> NamespacedName

    /// <summary>
    /// This specifies the division that proposes a brand.
    /// <see href="http://ns.inria.fr/provoc#belongsToDivision"></see></summary>
    let belongsToDivision =
        Namespaced_IRI.parse _namespace_name "belongsToDivision" |> NamespacedName

    /// <summary>
    /// This specifies the group that contains divisions.
    /// <see href="http://ns.inria.fr/provoc#belongsToGroup"></see></summary>
    let belongsToGroup =
        Namespaced_IRI.parse _namespace_name "belongsToGroup" |> NamespacedName

    /// <summary>
    /// This specifies the package that contains several products,, not neceserraly from the same pv:Range.
    /// <see href="http://ns.inria.fr/provoc#belongsToPackage"></see></summary>
    let belongsToPackage =
        Namespaced_IRI.parse _namespace_name "belongsToPackage" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Package"></see>
    /// </summary>
    let Package = Namespaced_IRI.parse _namespace_name "Package" |> NamespacedName

    /// <summary>
    /// This specifies the range of products.
    /// <see href="http://ns.inria.fr/provoc#belongsToProductOrServiceRange"></see></summary>
    let belongsToProductOrServiceRange =
        Namespaced_IRI.parse _namespace_name "belongsToProductOrServiceRange" |> NamespacedName

    /// <summary>
    /// This specifies the components included in a component.
    /// <see href="http://ns.inria.fr/provoc#consistsOf"></see></summary>
    let consistsOf = Namespaced_IRI.parse _namespace_name "consistsOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Component"></see>
    /// </summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    /// This specifies the ambassadors of a product, a range of product, a brand, a division, etc...
    /// <see href="http://ns.inria.fr/provoc#hasAmbassador"></see></summary>
    let hasAmbassador =
        Namespaced_IRI.parse _namespace_name "hasAmbassador" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Ambassador"></see>
    /// </summary>
    let Ambassador = Namespaced_IRI.parse _namespace_name "Ambassador" |> NamespacedName

    /// <summary>
    /// This specifies persons who represent a product, a range of product, a brand, a division, etc...
    /// <see href="http://ns.inria.fr/provoc#hasRepresentative"></see></summary>
    let hasRepresentative =
        Namespaced_IRI.parse _namespace_name "hasRepresentative" |> NamespacedName

    /// <summary>
    /// This specifies the components included in a product.
    /// <see href="http://ns.inria.fr/provoc#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// This specifies main contributors of the creation of the product.
    /// <see href="http://ns.inria.fr/provoc#hasCreator"></see></summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName
    /// <summary>
    /// This specifies the founder of a group.
    /// <see href="http://ns.inria.fr/provoc#hasFounder"></see></summary>
    let hasFounder = Namespaced_IRI.parse _namespace_name "hasFounder" |> NamespacedName

    /// <summary>
    /// This specifies the creator of a fragrance.
    /// <see href="http://ns.inria.fr/provoc#hasFragranceCreator"></see></summary>
    let hasFragranceCreator =
        Namespaced_IRI.parse _namespace_name "hasFragranceCreator" |> NamespacedName

    /// <summary>
    /// This specifies the functionalities/roles of a component. For instance "sodium nitrate" is a food preservative.
    /// <see href="http://ns.inria.fr/provoc#hasFunctionality"></see></summary>
    let hasFunctionality =
        Namespaced_IRI.parse _namespace_name "hasFunctionality" |> NamespacedName

    /// <summary>
    /// This specifies the models who represent a product, a range of product, a brand, a division, etc...
    /// <see href="http://ns.inria.fr/provoc#hasModel"></see></summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Model"></see>
    /// </summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    /// This specifies the designer of a fragrance.
    /// <see href="http://ns.inria.fr/provoc#hasPackageDesigner"></see></summary>
    let hasPackageDesigner =
        Namespaced_IRI.parse _namespace_name "hasPackageDesigner" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Designer"></see>
    /// </summary>
    let Designer = Namespaced_IRI.parse _namespace_name "Designer" |> NamespacedName

    /// <summary>
    /// This specifies providers of products incurred by a corporation. for instance Sephora is a provider of L'Oréal.
    /// <see href="http://ns.inria.fr/provoc#hasProvider"></see></summary>
    let hasProvider =
        Namespaced_IRI.parse _namespace_name "hasProvider" |> NamespacedName

    /// <summary>
    /// A product or service may have a target, for example, male or female.
    /// <see href="http://ns.inria.fr/provoc#hasTarget"></see></summary>
    let hasTarget = Namespaced_IRI.parse _namespace_name "hasTarget" |> NamespacedName
    /// <summary>
    /// A product or service may have different versions.
    /// <see href="http://ns.inria.fr/provoc#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// A component/ingredient of a product may have an impact according to health.
    /// <see href="http://ns.inria.fr/provoc#healthImpact"></see></summary>
    let healthImpact =
        Namespaced_IRI.parse _namespace_name "healthImpact" |> NamespacedName
