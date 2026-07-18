namespace http.cookingbigdata.com.linkeddata.ccpricing.hash

open DoxAletheia.Rdf_Vocabulary

module ccp =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccpricing#"

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#manuelparra"></see>
    /// </summary>
    let manuelparra =
        Namespaced_IRI.parse _namespace_name "manuelparra" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata =
        Namespaced_IRI.parse _namespace_name "cookingbigdata" |> NamespacedName

    /// <summary>
    /// Compound
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#PriceCompound"></see></summary>
    let PriceCompound =
        Namespaced_IRI.parse _namespace_name "PriceCompound" |> NamespacedName

    /// <summary>
    /// PricingPlan
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#PricingPlan"></see></summary>
    let PricingPlan =
        Namespaced_IRI.parse _namespace_name "PricingPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#hasPrice"></see>
    /// </summary>
    let hasPrice = Namespaced_IRI.parse _namespace_name "hasPrice" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#hasPriceCompound"></see>
    /// </summary>
    let hasPriceCompound =
        Namespaced_IRI.parse _namespace_name "hasPriceCompound" |> NamespacedName

    /// <summary>
    /// Has pricing plans
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#hasPricingPlan"></see></summary>
    let hasPricingPlan =
        Namespaced_IRI.parse _namespace_name "hasPricingPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#ServicePricing"></see>
    /// </summary>
    let ServicePricing =
        Namespaced_IRI.parse _namespace_name "ServicePricing" |> NamespacedName

    /// <summary>
    /// Instance
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#instance"></see></summary>
    let instance = Namespaced_IRI.parse _namespace_name "instance" |> NamespacedName
    /// <summary>
    /// Example Free
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#plan_name"></see></summary>
    let plan_name = Namespaced_IRI.parse _namespace_name "plan_name" |> NamespacedName
    /// <summary>
    /// Region
    /// <see href="http://cookingbigdata.com/linkeddata/ccpricing#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxCompound"></see>
    /// </summary>
    let withMaxCompound =
        Namespaced_IRI.parse _namespace_name "withMaxCompound" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxPrice"></see>
    /// </summary>
    let withMaxPrice =
        Namespaced_IRI.parse _namespace_name "withMaxPrice" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMinCompound"></see>
    /// </summary>
    let withMinCompound =
        Namespaced_IRI.parse _namespace_name "withMinCompound" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccpricing#withMinPrice"></see>
    /// </summary>
    let withMinPrice =
        Namespaced_IRI.parse _namespace_name "withMinPrice" |> NamespacedName
