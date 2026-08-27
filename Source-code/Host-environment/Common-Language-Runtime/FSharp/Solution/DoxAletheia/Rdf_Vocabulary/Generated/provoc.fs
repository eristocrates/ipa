namespace http.ns.inria.fr.provoc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module provoc =
    let _namespace_iri = Namespace_Iri provoc |> NamespaceIRI
    /// <summary>
    ///   <para>provoc:Ambassador</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/provoc#Ambassador">http://ns.inria.fr/provoc#Ambassador</seealso>
    let Ambassador = Prefixed_Name(provoc, "Ambassador") |> PrefixedName
    /// <summary>
    ///   <para>provoc:Component</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/provoc#Component">http://ns.inria.fr/provoc#Component</seealso>
    let Component = Prefixed_Name(provoc, "Component") |> PrefixedName
    /// <summary>
    ///   <para>provoc:Designer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/provoc#Designer">http://ns.inria.fr/provoc#Designer</seealso>
    let Designer = Prefixed_Name(provoc, "Designer") |> PrefixedName
    /// <summary>
    ///   <para>provoc:Model</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/provoc#Model">http://ns.inria.fr/provoc#Model</seealso>
    let Model = Prefixed_Name(provoc, "Model") |> PrefixedName
    /// <summary>
    ///   <para>provoc:Package</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/provoc#Package">http://ns.inria.fr/provoc#Package</seealso>
    let Package = Prefixed_Name(provoc, "Package") |> PrefixedName

    /// <summary>
    ///   <para>provoc:ProductOrServiceRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/provoc#ProductOrServiceRange">http://ns.inria.fr/provoc#ProductOrServiceRange</seealso>
    let ProductOrServiceRange =
        Prefixed_Name(provoc, "ProductOrServiceRange") |> PrefixedName

    /// <summary>
    ///   <para>provoc:belongsToBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the brand of a range or a product."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#belongsToBrand">http://ns.inria.fr/provoc#belongsToBrand</seealso>
    let belongsToBrand = Prefixed_Name(provoc, "belongsToBrand") |> PrefixedName
    /// <summary>
    ///   <para>provoc:belongsToDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the division that proposes a brand."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#belongsToDivision">http://ns.inria.fr/provoc#belongsToDivision</seealso>
    let belongsToDivision = Prefixed_Name(provoc, "belongsToDivision") |> PrefixedName
    /// <summary>
    ///   <para>provoc:belongsToGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the group that contains divisions."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#belongsToGroup">http://ns.inria.fr/provoc#belongsToGroup</seealso>
    let belongsToGroup = Prefixed_Name(provoc, "belongsToGroup") |> PrefixedName
    /// <summary>
    ///   <para>provoc:belongsToPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the package that contains several products,, not neceserraly from the same pv:Range."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#belongsToPackage">http://ns.inria.fr/provoc#belongsToPackage</seealso>
    let belongsToPackage = Prefixed_Name(provoc, "belongsToPackage") |> PrefixedName

    /// <summary>
    ///   <para>provoc:belongsToProductOrServiceRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the range of products."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#belongsToProductOrServiceRange">http://ns.inria.fr/provoc#belongsToProductOrServiceRange</seealso>
    let belongsToProductOrServiceRange =
        Prefixed_Name(provoc, "belongsToProductOrServiceRange") |> PrefixedName

    /// <summary>
    ///   <para>provoc:consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the components included in a component."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#consistsOf">http://ns.inria.fr/provoc#consistsOf</seealso>
    let consistsOf = Prefixed_Name(provoc, "consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasAmbassador</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the ambassadors of a product, a range of product, a brand, a division, etc..."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasAmbassador">http://ns.inria.fr/provoc#hasAmbassador</seealso>
    let hasAmbassador = Prefixed_Name(provoc, "hasAmbassador") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the components included in a product."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasComponent">http://ns.inria.fr/provoc#hasComponent</seealso>
    let hasComponent = Prefixed_Name(provoc, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies main contributors of the creation of the product."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasCreator">http://ns.inria.fr/provoc#hasCreator</seealso>
    let hasCreator = Prefixed_Name(provoc, "hasCreator") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasFounder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the founder of a group."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasFounder">http://ns.inria.fr/provoc#hasFounder</seealso>
    let hasFounder = Prefixed_Name(provoc, "hasFounder") |> PrefixedName

    /// <summary>
    ///   <para>provoc:hasFragranceCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the creator of a fragrance."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasFragranceCreator">http://ns.inria.fr/provoc#hasFragranceCreator</seealso>
    let hasFragranceCreator =
        Prefixed_Name(provoc, "hasFragranceCreator") |> PrefixedName

    /// <summary>
    ///   <para>provoc:hasFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This specifies the functionalities/roles of a component. For instance "sodium nitrate" is a food preservative."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasFunctionality">http://ns.inria.fr/provoc#hasFunctionality</seealso>
    let hasFunctionality = Prefixed_Name(provoc, "hasFunctionality") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the models who represent a product, a range of product, a brand, a division, etc..."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasModel">http://ns.inria.fr/provoc#hasModel</seealso>
    let hasModel = Prefixed_Name(provoc, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasPackageDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the designer of a fragrance."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasPackageDesigner">http://ns.inria.fr/provoc#hasPackageDesigner</seealso>
    let hasPackageDesigner = Prefixed_Name(provoc, "hasPackageDesigner") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies providers of products incurred by a corporation. for instance Sephora is a provider of L'Oréal."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasProvider">http://ns.inria.fr/provoc#hasProvider</seealso>
    let hasProvider = Prefixed_Name(provoc, "hasProvider") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies persons who represent a product, a range of product, a brand, a division, etc..."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasRepresentative">http://ns.inria.fr/provoc#hasRepresentative</seealso>
    let hasRepresentative = Prefixed_Name(provoc, "hasRepresentative") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A product or service may have a target, for example, male or female."</para>
    ///   <para>"Un produit ou service peut avoir une cible, par exemple féminine ou masculine."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasTarget">http://ns.inria.fr/provoc#hasTarget</seealso>
    let hasTarget = Prefixed_Name(provoc, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>provoc:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A product or service may have different versions."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#hasVersion">http://ns.inria.fr/provoc#hasVersion</seealso>
    let hasVersion = Prefixed_Name(provoc, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>provoc:healthImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A component/ingredient of a product may have an impact according to health."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/provoc#healthImpact">http://ns.inria.fr/provoc#healthImpact</seealso>
    let healthImpact = Prefixed_Name(provoc, "healthImpact") |> PrefixedName
