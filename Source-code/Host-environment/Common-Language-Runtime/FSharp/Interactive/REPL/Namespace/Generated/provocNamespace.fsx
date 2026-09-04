#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module provoc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.inria.fr/provoc#" "provoc"
    let Ambassador = _prefixId.prefix "Ambassador"
    let Component = _prefixId.prefix "Component"
    let Designer = _prefixId.prefix "Designer"
    let Model = _prefixId.prefix "Model"
    let Package = _prefixId.prefix "Package"
    let ProductOrServiceRange = _prefixId.prefix "ProductOrServiceRange"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the brand of a range or a product.</para>
    ///   <a href="http://ns.inria.fr/provoc#belongsToBrand">provoc:belongsToBrand</a>
    /// </summary>
    let belongsToBrand = _prefixId.prefix "belongsToBrand"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the division that proposes a brand.</para>
    ///   <a href="http://ns.inria.fr/provoc#belongsToDivision">provoc:belongsToDivision</a>
    /// </summary>
    let belongsToDivision = _prefixId.prefix "belongsToDivision"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the group that contains divisions.</para>
    ///   <a href="http://ns.inria.fr/provoc#belongsToGroup">provoc:belongsToGroup</a>
    /// </summary>
    let belongsToGroup = _prefixId.prefix "belongsToGroup"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the package that contains several products,, not neceserraly from the same pv:Range.</para>
    ///   <a href="http://ns.inria.fr/provoc#belongsToPackage">provoc:belongsToPackage</a>
    /// </summary>
    let belongsToPackage = _prefixId.prefix "belongsToPackage"

    /// <summary>
    ///   <para>rdfs:comment : This specifies the range of products.</para>
    ///   <a href="http://ns.inria.fr/provoc#belongsToProductOrServiceRange">provoc:belongsToProductOrServiceRange</a>
    /// </summary>
    let belongsToProductOrServiceRange =
        _prefixId.prefix "belongsToProductOrServiceRange"

    /// <summary>
    ///   <para>rdfs:comment : This specifies the components included in a component.</para>
    ///   <a href="http://ns.inria.fr/provoc#consistsOf">provoc:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the ambassadors of a product, a range of product, a brand, a division, etc...</para>
    ///   <a href="http://ns.inria.fr/provoc#hasAmbassador">provoc:hasAmbassador</a>
    /// </summary>
    let hasAmbassador = _prefixId.prefix "hasAmbassador"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the components included in a product.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasComponent">provoc:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : This specifies main contributors of the creation of the product.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasCreator">provoc:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the founder of a group.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasFounder">provoc:hasFounder</a>
    /// </summary>
    let hasFounder = _prefixId.prefix "hasFounder"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the creator of a fragrance.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasFragranceCreator">provoc:hasFragranceCreator</a>
    /// </summary>
    let hasFragranceCreator = _prefixId.prefix "hasFragranceCreator"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the functionalities/roles of a component. For instance "sodium nitrate" is a food preservative.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasFunctionality">provoc:hasFunctionality</a>
    /// </summary>
    let hasFunctionality = _prefixId.prefix "hasFunctionality"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the models who represent a product, a range of product, a brand, a division, etc...</para>
    ///   <a href="http://ns.inria.fr/provoc#hasModel">provoc:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:comment : This specifies the designer of a fragrance.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasPackageDesigner">provoc:hasPackageDesigner</a>
    /// </summary>
    let hasPackageDesigner = _prefixId.prefix "hasPackageDesigner"
    /// <summary>
    ///   <para>rdfs:comment : This specifies providers of products incurred by a corporation. for instance Sephora is a provider of L'Oréal.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasProvider">provoc:hasProvider</a>
    /// </summary>
    let hasProvider = _prefixId.prefix "hasProvider"
    /// <summary>
    ///   <para>rdfs:comment : This specifies persons who represent a product, a range of product, a brand, a division, etc...</para>
    ///   <a href="http://ns.inria.fr/provoc#hasRepresentative">provoc:hasRepresentative</a>
    /// </summary>
    let hasRepresentative = _prefixId.prefix "hasRepresentative"
    /// <summary>
    ///   <para>rdfs:comment : A product or service may have a target, for example, male or female.rdfs:comment : Un produit ou service peut avoir une cible, par exemple féminine ou masculine.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasTarget">provoc:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    /// <summary>
    ///   <para>rdfs:comment : A product or service may have different versions.</para>
    ///   <a href="http://ns.inria.fr/provoc#hasVersion">provoc:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:comment : A component/ingredient of a product may have an impact according to health.</para>
    ///   <a href="http://ns.inria.fr/provoc#healthImpact">provoc:healthImpact</a>
    /// </summary>
    let healthImpact = _prefixId.prefix "healthImpact"
