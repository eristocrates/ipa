namespace http.cookingbigdata.com.linkeddata.ccpricing.hash

open DoxAletheia

module ccp =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccpricing#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#manuelparra"></see>
    /// </summary>
    let manuelparra = _prefix "manuelparra"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata = _prefix "cookingbigdata"
    /// <summary>
    /// Compound
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#PriceCompound"></see></summary>
    let PriceCompound = _prefix "PriceCompound"
    /// <summary>
    /// PricingPlan
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#PricingPlan"></see></summary>
    let PricingPlan = _prefix "PricingPlan"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#hasPrice"></see>
    /// </summary>
    let hasPrice = _prefix "hasPrice"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#hasPriceCompound"></see>
    /// </summary>
    let hasPriceCompound = _prefix "hasPriceCompound"
    /// <summary>
    /// Has pricing plans
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#hasPricingPlan"></see></summary>
    let hasPricingPlan = _prefix "hasPricingPlan"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#ServicePricing"></see>
    /// </summary>
    let ServicePricing = _prefix "ServicePricing"
    /// <summary>
    /// Instance
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#instance"></see></summary>
    let instance = _prefix "instance"
    /// <summary>
    /// Example Free
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#plan_name"></see></summary>
    let plan_name = _prefix "plan_name"
    /// <summary>
    /// Region
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxCompound"></see>
    /// </summary>
    let withMaxCompound = _prefix "withMaxCompound"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxPrice"></see>
    /// </summary>
    let withMaxPrice = _prefix "withMaxPrice"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMinCompound"></see>
    /// </summary>
    let withMinCompound = _prefix "withMinCompound"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMinPrice"></see>
    /// </summary>
    let withMinPrice = _prefix "withMinPrice"
