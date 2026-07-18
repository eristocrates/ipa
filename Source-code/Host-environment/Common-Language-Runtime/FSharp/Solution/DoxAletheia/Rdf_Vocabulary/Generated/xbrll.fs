namespace https.w3id.org.vocab.xbrll.hash

open DoxAletheia.Rdf_Vocabulary

module xbrll =
    let _namespace_name = "https://w3id.org/vocab/xbrll#"
    /// <summary>
    /// the context of a fact in a financial report
    /// <see href="https://w3id.org/vocab/xbrll#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName
    /// <summary>
    /// this define a fact in the report. A data point should have at least one context
    /// <see href="https://w3id.org/vocab/xbrll#DataPoint"></see></summary>
    let DataPoint = Namespaced_IRI.parse _namespace_name "DataPoint" |> NamespacedName
    /// <summary>
    /// Context property from a data point
    /// <see href="https://w3id.org/vocab/xbrll#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    /// The dimension defining whether the dimensions in the axis are explicit member or implicit ones
    /// <see href="https://w3id.org/vocab/xbrll#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#hasDimension"></see>
    /// </summary>
    let hasDimension =
        Namespaced_IRI.parse _namespace_name "hasDimension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#FinancialEntity"></see>
    /// </summary>
    let FinancialEntity =
        Namespaced_IRI.parse _namespace_name "FinancialEntity" |> NamespacedName

    /// <summary>
    /// A financial report may content many data points that are facts
    /// <see href="https://w3id.org/vocab/xbrll#FinancialReport"></see></summary>
    let FinancialReport =
        Namespaced_IRI.parse _namespace_name "FinancialReport" |> NamespacedName

    /// <summary>
    /// Data point property from a financial report
    /// <see href="https://w3id.org/vocab/xbrll#dataPoint"></see></summary>
    let dataPoint = Namespaced_IRI.parse _namespace_name "dataPoint" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#Period"></see>
    /// </summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    /// The person of contact in the metadata info of a company
    /// <see href="https://w3id.org/vocab/xbrll#contactPerson"></see></summary>
    let contactPerson =
        Namespaced_IRI.parse _namespace_name "contactPerson" |> NamespacedName

    /// <summary>
    /// Number of decimals used for a currency
    /// <see href="https://w3id.org/vocab/xbrll#decimals"></see></summary>
    let decimals = Namespaced_IRI.parse _namespace_name "decimals" |> NamespacedName
    /// <summary>
    /// End date of a period
    /// <see href="https://w3id.org/vocab/xbrll#endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    /// End of fiscal year
    /// <see href="https://w3id.org/vocab/xbrll#fiscalYear"></see></summary>
    let fiscalYear = Namespaced_IRI.parse _namespace_name "fiscalYear" |> NamespacedName
    /// <summary>
    /// Boolean telling the period is forever or not
    /// <see href="https://w3id.org/vocab/xbrll#isForever"></see></summary>
    let isForever = Namespaced_IRI.parse _namespace_name "isForever" |> NamespacedName
    /// <summary>
    /// boolean for the instant moment
    /// <see href="https://w3id.org/vocab/xbrll#isInstant"></see></summary>
    let isInstant = Namespaced_IRI.parse _namespace_name "isInstant" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/xbrll#period"></see>
    /// </summary>
    let period = Namespaced_IRI.parse _namespace_name "period" |> NamespacedName
    /// <summary>
    /// year of the report
    /// <see href="https://w3id.org/vocab/xbrll#reportYear"></see></summary>
    let reportYear = Namespaced_IRI.parse _namespace_name "reportYear" |> NamespacedName
    /// <summary>
    /// Starting date of a period
    /// <see href="https://w3id.org/vocab/xbrll#startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
