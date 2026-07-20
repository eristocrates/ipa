namespace https.w3id.org.vocab.xbrll.hash

open DoxAletheia

module xbrll =
    let _namespace_name = "https://w3id.org/vocab/xbrll#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// the context of a fact in a financial report
    /// <see href="https://w3id.org/vocab/xbrll#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// this define a fact in the report. A data point should have at least one context
    /// <see href="https://w3id.org/vocab/xbrll#DataPoint"></see></summary>
    let DataPoint = _prefix "DataPoint"
    /// <summary>
    /// Context property from a data point
    /// <see href="https://w3id.org/vocab/xbrll#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    /// The dimension defining whether the dimensions in the axis are explicit member or implicit ones
    /// <see href="https://w3id.org/vocab/xbrll#Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#hasDimension"></see>
    /// </summary>
    let hasDimension = _prefix "hasDimension"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#FinancialEntity"></see>
    /// </summary>
    let FinancialEntity = _prefix "FinancialEntity"
    /// <summary>
    /// A financial report may content many data points that are facts
    /// <see href="https://w3id.org/vocab/xbrll#FinancialReport"></see></summary>
    let FinancialReport = _prefix "FinancialReport"
    /// <summary>
    /// Data point property from a financial report
    /// <see href="https://w3id.org/vocab/xbrll#dataPoint"></see></summary>
    let dataPoint = _prefix "dataPoint"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#Period"></see>
    /// </summary>
    let Period = _prefix "Period"
    /// <summary>
    /// The person of contact in the metadata info of a company
    /// <see href="https://w3id.org/vocab/xbrll#contactPerson"></see></summary>
    let contactPerson = _prefix "contactPerson"
    /// <summary>
    /// Number of decimals used for a currency
    /// <see href="https://w3id.org/vocab/xbrll#decimals"></see></summary>
    let decimals = _prefix "decimals"
    /// <summary>
    /// End date of a period
    /// <see href="https://w3id.org/vocab/xbrll#endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// End of fiscal year
    /// <see href="https://w3id.org/vocab/xbrll#fiscalYear"></see></summary>
    let fiscalYear = _prefix "fiscalYear"
    /// <summary>
    /// Boolean telling the period is forever or not
    /// <see href="https://w3id.org/vocab/xbrll#isForever"></see></summary>
    let isForever = _prefix "isForever"
    /// <summary>
    /// boolean for the instant moment
    /// <see href="https://w3id.org/vocab/xbrll#isInstant"></see></summary>
    let isInstant = _prefix "isInstant"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#period"></see>
    /// </summary>
    let period = _prefix "period"
    /// <summary>
    /// year of the report
    /// <see href="https://w3id.org/vocab/xbrll#reportYear"></see></summary>
    let reportYear = _prefix "reportYear"
    /// <summary>
    /// Starting date of a period
    /// <see href="https://w3id.org/vocab/xbrll#startDate"></see></summary>
    let startDate = _prefix "startDate"
