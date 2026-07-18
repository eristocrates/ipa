namespace http.purl.org.essglobal.vocab.slash

open DoxAletheia.Rdf_Vocabulary

module essglobal =
    let _namespace_name = "http://purl.org/essglobal/vocab/"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Activities"></see>
    /// </summary>
    let Activities = Namespaced_IRI.parse _namespace_name "Activities" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Address"></see>
    /// </summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Cost"></see>
    /// </summary>
    let Cost = Namespaced_IRI.parse _namespace_name "Cost" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/CostComposition"></see>
    /// </summary>
    let CostComposition =
        Namespaced_IRI.parse _namespace_name "CostComposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Input"></see>
    /// </summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Labour"></see>
    /// </summary>
    let Labour = Namespaced_IRI.parse _namespace_name "Labour" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/LegalForm"></see>
    /// </summary>
    let LegalForm = Namespaced_IRI.parse _namespace_name "LegalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/LocationOfSale"></see>
    /// </summary>
    let LocationOfSale =
        Namespaced_IRI.parse _namespace_name "LocationOfSale" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Network"></see>
    /// </summary>
    let Network = Namespaced_IRI.parse _namespace_name "Network" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/OtherCosts"></see>
    /// </summary>
    let OtherCosts = Namespaced_IRI.parse _namespace_name "OtherCosts" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/ProductOrService"></see>
    /// </summary>
    let ProductOrService =
        Namespaced_IRI.parse _namespace_name "ProductOrService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Qualifiers"></see>
    /// </summary>
    let Qualifiers = Namespaced_IRI.parse _namespace_name "Qualifiers" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/SSEInitiative"></see>
    /// </summary>
    let SSEInitiative =
        Namespaced_IRI.parse _namespace_name "SSEInitiative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/SaleOption"></see>
    /// </summary>
    let SaleOption = Namespaced_IRI.parse _namespace_name "SaleOption" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/TypeOfLabour"></see>
    /// </summary>
    let TypeOfLabour =
        Namespaced_IRI.parse _namespace_name "TypeOfLabour" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/costPerUnit"></see>
    /// </summary>
    let costPerUnit =
        Namespaced_IRI.parse _namespace_name "costPerUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/deliveryRangeDistance"></see>
    /// </summary>
    let deliveryRangeDistance =
        Namespaced_IRI.parse _namespace_name "deliveryRangeDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/economicSector"></see>
    /// </summary>
    let economicSector =
        Namespaced_IRI.parse _namespace_name "economicSector" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasCost"></see>
    /// </summary>
    let hasCost = Namespaced_IRI.parse _namespace_name "hasCost" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasImpactOnCost"></see>
    /// </summary>
    let hasImpactOnCost =
        Namespaced_IRI.parse _namespace_name "hasImpactOnCost" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasInputCost"></see>
    /// </summary>
    let hasInputCost =
        Namespaced_IRI.parse _namespace_name "hasInputCost" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasLabourCost"></see>
    /// </summary>
    let hasLabourCost =
        Namespaced_IRI.parse _namespace_name "hasLabourCost" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasOtherCosts"></see>
    /// </summary>
    let hasOtherCosts =
        Namespaced_IRI.parse _namespace_name "hasOtherCosts" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasProductOrService"></see>
    /// </summary>
    let hasProductOrService =
        Namespaced_IRI.parse _namespace_name "hasProductOrService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasSaleOption"></see>
    /// </summary>
    let hasSaleOption =
        Namespaced_IRI.parse _namespace_name "hasSaleOption" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isAvailable"></see>
    /// </summary>
    let isAvailable =
        Namespaced_IRI.parse _namespace_name "isAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isAvailableAt"></see>
    /// </summary>
    let isAvailableAt =
        Namespaced_IRI.parse _namespace_name "isAvailableAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isComposedBy"></see>
    /// </summary>
    let isComposedBy =
        Namespaced_IRI.parse _namespace_name "isComposedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isMain"></see>
    /// </summary>
    let isMain = Namespaced_IRI.parse _namespace_name "isMain" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isSSE"></see>
    /// </summary>
    let isSSE = Namespaced_IRI.parse _namespace_name "isSSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/legalForm"></see>
    /// </summary>
    let legalForm = Namespaced_IRI.parse _namespace_name "legalForm" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/mission"></see>
    /// </summary>
    let mission = Namespaced_IRI.parse _namespace_name "mission" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/objective"></see>
    /// </summary>
    let objective = Namespaced_IRI.parse _namespace_name "objective" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/qualifier"></see>
    /// </summary>
    let qualifier = Namespaced_IRI.parse _namespace_name "qualifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/quantityPerProductOrServiceUnit"></see>
    /// </summary>
    let quantityPerProductOrServiceUnit =
        Namespaced_IRI.parse _namespace_name "quantityPerProductOrServiceUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/salesMarginPercentage"></see>
    /// </summary>
    let salesMarginPercentage =
        Namespaced_IRI.parse _namespace_name "salesMarginPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/salesMarginValue"></see>
    /// </summary>
    let salesMarginValue =
        Namespaced_IRI.parse _namespace_name "salesMarginValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/state"></see>
    /// </summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/totalMen"></see>
    /// </summary>
    let totalMen = Namespaced_IRI.parse _namespace_name "totalMen" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/totalOfMembers"></see>
    /// </summary>
    let totalOfMembers =
        Namespaced_IRI.parse _namespace_name "totalOfMembers" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/totalWomen"></see>
    /// </summary>
    let totalWomen = Namespaced_IRI.parse _namespace_name "totalWomen" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/typeOfLabour"></see>
    /// </summary>
    let typeOfLabour =
        Namespaced_IRI.parse _namespace_name "typeOfLabour" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/unit"></see>
    /// </summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
