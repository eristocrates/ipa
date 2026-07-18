namespace http.cookingbigdata.com.linkeddata.ccsla.hash

open DoxAletheia.Rdf_Vocabulary

module ccsla =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccsla#"

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccsla#manuelparra"></see>
    /// </summary>
    let manuelparra =
        Namespaced_IRI.parse _namespace_name "manuelparra" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccsla#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata =
        Namespaced_IRI.parse _namespace_name "cookingbigdata" |> NamespacedName

    /// <summary>
    /// Claims of the agreement license
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Claim"></see></summary>
    let Claim = Namespaced_IRI.parse _namespace_name "Claim" |> NamespacedName
    /// <summary>
    /// Term of the SLA
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Term"></see></summary>
    let Term = Namespaced_IRI.parse _namespace_name "Term" |> NamespacedName
    /// <summary>
    /// Conditions and levels of the agreement and compensation
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// Definitions of the agreement license used in terms
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Definition"></see></summary>
    let Definition = Namespaced_IRI.parse _namespace_name "Definition" |> NamespacedName
    /// <summary>
    /// Limitations and Exclusions of the agreement license considering Compensations
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Limitation"></see></summary>
    let Limitation = Namespaced_IRI.parse _namespace_name "Limitation" |> NamespacedName
    /// <summary>
    /// SLA Main Class
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#SLA"></see></summary>
    let SLA = Namespaced_IRI.parse _namespace_name "SLA" |> NamespacedName

    /// <summary>
    /// ServiceCredits of the agreement license considering Compensations terms
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#ServiceCredit"></see></summary>
    let ServiceCredit =
        Namespaced_IRI.parse _namespace_name "ServiceCredit" |> NamespacedName

    /// <summary>
    /// SLA contains Terms of the agreement
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#containsTerm"></see></summary>
    let containsTerm =
        Namespaced_IRI.parse _namespace_name "containsTerm" |> NamespacedName

    /// <summary>
    /// Term Compensation of the agreement
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasCompensation"></see></summary>
    let hasCompensation =
        Namespaced_IRI.parse _namespace_name "hasCompensation" |> NamespacedName

    /// <summary>
    /// Definition values of an agreement term.
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasDefinitionValue"></see></summary>
    let hasDefinitionValue =
        Namespaced_IRI.parse _namespace_name "hasDefinitionValue" |> NamespacedName

    /// <summary>
    /// Definition values of an agreement term.
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasTermValue"></see></summary>
    let hasTermValue =
        Namespaced_IRI.parse _namespace_name "hasTermValue" |> NamespacedName

    /// <summary>
    /// Validity interval of an agreement term.
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasValidity"></see></summary>
    let hasValidity =
        Namespaced_IRI.parse _namespace_name "hasValidity" |> NamespacedName

    /// <summary>
    /// Include definitions
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#includeDefs"></see></summary>
    let includeDefs =
        Namespaced_IRI.parse _namespace_name "includeDefs" |> NamespacedName

    /// <summary>
    /// Values of the condition
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#includeValue"></see></summary>
    let includeValue =
        Namespaced_IRI.parse _namespace_name "includeValue" |> NamespacedName
