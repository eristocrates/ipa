namespace http.ns.inria.fr.provoc.hash

open DoxAletheia

module provoc =
    let _namespace_name = "http://ns.inria.fr/provoc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This specifies the brand of a range or a product.
    /// <see href="http://ns.inria.fr/provoc#belongsToBrand"></see></summary>
    let belongsToBrand = _prefix "belongsToBrand"
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#ProductOrServiceRange"></see>
    /// </summary>
    let ProductOrServiceRange = _prefix "ProductOrServiceRange"
    /// <summary>
    /// This specifies the division that proposes a brand.
    /// <see href="http://ns.inria.fr/provoc#belongsToDivision"></see></summary>
    let belongsToDivision = _prefix "belongsToDivision"
    /// <summary>
    /// This specifies the group that contains divisions.
    /// <see href="http://ns.inria.fr/provoc#belongsToGroup"></see></summary>
    let belongsToGroup = _prefix "belongsToGroup"
    /// <summary>
    /// This specifies the package that contains several products,, not neceserraly from the same pv:Range.
    /// <see href="http://ns.inria.fr/provoc#belongsToPackage"></see></summary>
    let belongsToPackage = _prefix "belongsToPackage"
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Package"></see>
    /// </summary>
    let Package = _prefix "Package"
    /// <summary>
    /// This specifies the range of products.
    /// <see href="http://ns.inria.fr/provoc#belongsToProductOrServiceRange"></see></summary>
    let belongsToProductOrServiceRange = _prefix "belongsToProductOrServiceRange"
    /// <summary>
    /// This specifies the components included in a component.
    /// <see href="http://ns.inria.fr/provoc#consistsOf"></see></summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Component"></see>
    /// </summary>
    let Component = _prefix "Component"
    /// <summary>
    /// This specifies the ambassadors of a product, a range of product, a brand, a division, etc...
    /// <see href="http://ns.inria.fr/provoc#hasAmbassador"></see></summary>
    let hasAmbassador = _prefix "hasAmbassador"
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Ambassador"></see>
    /// </summary>
    let Ambassador = _prefix "Ambassador"
    /// <summary>
    /// This specifies persons who represent a product, a range of product, a brand, a division, etc...
    /// <see href="http://ns.inria.fr/provoc#hasRepresentative"></see></summary>
    let hasRepresentative = _prefix "hasRepresentative"
    /// <summary>
    /// This specifies the components included in a product.
    /// <see href="http://ns.inria.fr/provoc#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// This specifies main contributors of the creation of the product.
    /// <see href="http://ns.inria.fr/provoc#hasCreator"></see></summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    /// This specifies the founder of a group.
    /// <see href="http://ns.inria.fr/provoc#hasFounder"></see></summary>
    let hasFounder = _prefix "hasFounder"
    /// <summary>
    /// This specifies the creator of a fragrance.
    /// <see href="http://ns.inria.fr/provoc#hasFragranceCreator"></see></summary>
    let hasFragranceCreator = _prefix "hasFragranceCreator"
    /// <summary>
    /// This specifies the functionalities/roles of a component. For instance "sodium nitrate" is a food preservative.
    /// <see href="http://ns.inria.fr/provoc#hasFunctionality"></see></summary>
    let hasFunctionality = _prefix "hasFunctionality"
    /// <summary>
    /// This specifies the models who represent a product, a range of product, a brand, a division, etc...
    /// <see href="http://ns.inria.fr/provoc#hasModel"></see></summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Model"></see>
    /// </summary>
    let Model = _prefix "Model"
    /// <summary>
    /// This specifies the designer of a fragrance.
    /// <see href="http://ns.inria.fr/provoc#hasPackageDesigner"></see></summary>
    let hasPackageDesigner = _prefix "hasPackageDesigner"
    /// <summary>
    ///   <see href="http://ns.inria.fr/provoc#Designer"></see>
    /// </summary>
    let Designer = _prefix "Designer"
    /// <summary>
    /// This specifies providers of products incurred by a corporation. for instance Sephora is a provider of L'Oréal.
    /// <see href="http://ns.inria.fr/provoc#hasProvider"></see></summary>
    let hasProvider = _prefix "hasProvider"
    /// <summary>
    /// A product or service may have a target, for example, male or female.
    /// <see href="http://ns.inria.fr/provoc#hasTarget"></see></summary>
    let hasTarget = _prefix "hasTarget"
    /// <summary>
    /// A product or service may have different versions.
    /// <see href="http://ns.inria.fr/provoc#hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// A component/ingredient of a product may have an impact according to health.
    /// <see href="http://ns.inria.fr/provoc#healthImpact"></see></summary>
    let healthImpact = _prefix "healthImpact"
