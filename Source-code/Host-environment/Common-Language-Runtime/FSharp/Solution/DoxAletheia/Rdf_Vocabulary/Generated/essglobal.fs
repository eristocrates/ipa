namespace http.purl.org.essglobal.vocab.slash

open DoxAletheia

module essglobal =
    let _namespace_name = "http://purl.org/essglobal/vocab/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Activities"></see>
    /// </summary>
    let Activities = _prefix "Activities"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Cost"></see>
    /// </summary>
    let Cost = _prefix "Cost"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/CostComposition"></see>
    /// </summary>
    let CostComposition = _prefix "CostComposition"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Input"></see>
    /// </summary>
    let Input = _prefix "Input"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Labour"></see>
    /// </summary>
    let Labour = _prefix "Labour"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/LegalForm"></see>
    /// </summary>
    let LegalForm = _prefix "LegalForm"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/LocationOfSale"></see>
    /// </summary>
    let LocationOfSale = _prefix "LocationOfSale"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Network"></see>
    /// </summary>
    let Network = _prefix "Network"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/OtherCosts"></see>
    /// </summary>
    let OtherCosts = _prefix "OtherCosts"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/ProductOrService"></see>
    /// </summary>
    let ProductOrService = _prefix "ProductOrService"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/Qualifiers"></see>
    /// </summary>
    let Qualifiers = _prefix "Qualifiers"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/SSEInitiative"></see>
    /// </summary>
    let SSEInitiative = _prefix "SSEInitiative"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/SaleOption"></see>
    /// </summary>
    let SaleOption = _prefix "SaleOption"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/TypeOfLabour"></see>
    /// </summary>
    let TypeOfLabour = _prefix "TypeOfLabour"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/costPerUnit"></see>
    /// </summary>
    let costPerUnit = _prefix "costPerUnit"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/deliveryRangeDistance"></see>
    /// </summary>
    let deliveryRangeDistance = _prefix "deliveryRangeDistance"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/economicSector"></see>
    /// </summary>
    let economicSector = _prefix "economicSector"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasCost"></see>
    /// </summary>
    let hasCost = _prefix "hasCost"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasImpactOnCost"></see>
    /// </summary>
    let hasImpactOnCost = _prefix "hasImpactOnCost"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasInputCost"></see>
    /// </summary>
    let hasInputCost = _prefix "hasInputCost"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasLabourCost"></see>
    /// </summary>
    let hasLabourCost = _prefix "hasLabourCost"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasOtherCosts"></see>
    /// </summary>
    let hasOtherCosts = _prefix "hasOtherCosts"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasProductOrService"></see>
    /// </summary>
    let hasProductOrService = _prefix "hasProductOrService"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/hasSaleOption"></see>
    /// </summary>
    let hasSaleOption = _prefix "hasSaleOption"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isAvailable"></see>
    /// </summary>
    let isAvailable = _prefix "isAvailable"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isAvailableAt"></see>
    /// </summary>
    let isAvailableAt = _prefix "isAvailableAt"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isComposedBy"></see>
    /// </summary>
    let isComposedBy = _prefix "isComposedBy"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isMain"></see>
    /// </summary>
    let isMain = _prefix "isMain"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/isSSE"></see>
    /// </summary>
    let isSSE = _prefix "isSSE"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/legalForm"></see>
    /// </summary>
    let legalForm = _prefix "legalForm"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/mission"></see>
    /// </summary>
    let mission = _prefix "mission"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/objective"></see>
    /// </summary>
    let objective = _prefix "objective"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/qualifier"></see>
    /// </summary>
    let qualifier = _prefix "qualifier"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/quantityPerProductOrServiceUnit"></see>
    /// </summary>
    let quantityPerProductOrServiceUnit = _prefix "quantityPerProductOrServiceUnit"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/salesMarginPercentage"></see>
    /// </summary>
    let salesMarginPercentage = _prefix "salesMarginPercentage"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/salesMarginValue"></see>
    /// </summary>
    let salesMarginValue = _prefix "salesMarginValue"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/state"></see>
    /// </summary>
    let state = _prefix "state"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/totalMen"></see>
    /// </summary>
    let totalMen = _prefix "totalMen"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/totalOfMembers"></see>
    /// </summary>
    let totalOfMembers = _prefix "totalOfMembers"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/totalWomen"></see>
    /// </summary>
    let totalWomen = _prefix "totalWomen"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/typeOfLabour"></see>
    /// </summary>
    let typeOfLabour = _prefix "typeOfLabour"
    /// <summary>
    ///   <see href="http://purl.org/essglobal/vocab/unit"></see>
    /// </summary>
    let unit = _prefix "unit"
