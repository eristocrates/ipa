namespace http.www.ontologydesignpatterns.org.cp.owl.timeinterval.owl.hash

open DoxAletheia

module ti =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Any Region in a dimensional space that aims at representing time.
    /// It should be used when you want to talk about time as an object having some characteristics.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    /// The start date of a time interval.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalStartDate"></see></summary>
    let hasIntervalStartDate = _prefix "hasIntervalStartDate"
    /// <summary>
    /// The end date of a time interval.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalEndDate"></see></summary>
    let hasIntervalEndDate = _prefix "hasIntervalEndDate"
    /// <summary>
    /// A datatype property that encodes values from xsd:date (or any other date-related xsd datatype) for a TimeInterval; a same TimeInterval can have more than one date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalDate"></see></summary>
    let hasIntervalDate = _prefix "hasIntervalDate"
