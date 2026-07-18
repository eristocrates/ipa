namespace http.purl.org.NET.schema_org_csv.hash

open DoxAletheia.Rdf_Vocabulary

module scsv =
    let _namespace_name = "http://purl.org/NET/schema-org-csv#"
    /// <summary>
    /// The header row, that is the first row of the table that contains the column heads that are matched against Schema.org terms.
    /// <see href="http://purl.org/NET/schema-org-csv#HeaderRow"></see></summary>
    let HeaderRow = Namespaced_IRI.parse _namespace_name "HeaderRow" |> NamespacedName
    /// <summary>
    /// A row (or record as of http://tools.ietf.org/html/rfc4180).
    /// <see href="http://purl.org/NET/schema-org-csv#Row"></see></summary>
    let Row = Namespaced_IRI.parse _namespace_name "Row" |> NamespacedName
    /// <summary>
    /// A CSV table as of http://tools.ietf.org/html/rfc4180.
    /// <see href="http://purl.org/NET/schema-org-csv#Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName
    /// <summary>
    /// A row has one or more cells (or field as of http://tools.ietf.org/html/rfc4180), each of which is connected to the row with this property.
    /// <see href="http://purl.org/NET/schema-org-csv#cell"></see></summary>
    let cell = Namespaced_IRI.parse _namespace_name "cell" |> NamespacedName
    /// <summary>
    /// A table has one or more rows, each of which is connected to the table via this property.
    /// <see href="http://purl.org/NET/schema-org-csv#row"></see></summary>
    let row = Namespaced_IRI.parse _namespace_name "row" |> NamespacedName
