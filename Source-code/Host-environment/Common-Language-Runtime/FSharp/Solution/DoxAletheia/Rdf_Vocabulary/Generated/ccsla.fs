namespace http.cookingbigdata.com.linkeddata.ccsla.hash

open DoxAletheia

module ccsla =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccsla#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccsla#manuelparra"></see>
    /// </summary>
    let manuelparra = _prefix "manuelparra"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccsla#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata = _prefix "cookingbigdata"
    /// <summary>
    /// Claims of the agreement license
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Claim"></see></summary>
    let Claim = _prefix "Claim"
    /// <summary>
    /// Term of the SLA
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Term"></see></summary>
    let Term = _prefix "Term"
    /// <summary>
    /// Conditions and levels of the agreement and compensation
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// Definitions of the agreement license used in terms
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Definition"></see></summary>
    let Definition = _prefix "Definition"
    /// <summary>
    /// Limitations and Exclusions of the agreement license considering Compensations
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#Limitation"></see></summary>
    let Limitation = _prefix "Limitation"
    /// <summary>
    /// SLA Main Class
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#SLA"></see></summary>
    let SLA = _prefix "SLA"
    /// <summary>
    /// ServiceCredits of the agreement license considering Compensations terms
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#ServiceCredit"></see></summary>
    let ServiceCredit = _prefix "ServiceCredit"
    /// <summary>
    /// SLA contains Terms of the agreement
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#containsTerm"></see></summary>
    let containsTerm = _prefix "containsTerm"
    /// <summary>
    /// Term Compensation of the agreement
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasCompensation"></see></summary>
    let hasCompensation = _prefix "hasCompensation"
    /// <summary>
    /// Definition values of an agreement term.
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasDefinitionValue"></see></summary>
    let hasDefinitionValue = _prefix "hasDefinitionValue"
    /// <summary>
    /// Definition values of an agreement term.
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasTermValue"></see></summary>
    let hasTermValue = _prefix "hasTermValue"
    /// <summary>
    /// Validity interval of an agreement term.
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#hasValidity"></see></summary>
    let hasValidity = _prefix "hasValidity"
    /// <summary>
    /// Include definitions
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#includeDefs"></see></summary>
    let includeDefs = _prefix "includeDefs"
    /// <summary>
    /// Values of the condition
    /// <see href="http://cookingbigdata.com/linkeddata/ccsla#includeValue"></see></summary>
    let includeValue = _prefix "includeValue"
