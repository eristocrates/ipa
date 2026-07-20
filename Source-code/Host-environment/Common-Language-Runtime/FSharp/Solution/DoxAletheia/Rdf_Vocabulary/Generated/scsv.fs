namespace http.purl.org.NET.schema_org_csv.hash

open DoxAletheia

module scsv =
    let _namespace_name = "http://purl.org/NET/schema-org-csv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The header row, that is the first row of the table that contains the column heads that are matched against Schema.org terms.
    /// <see href="http://purl.org/NET/schema-org-csv#HeaderRow"></see></summary>
    let HeaderRow = _prefix "HeaderRow"
    /// <summary>
    /// A row (or record as of http://tools.ietf.org/html/rfc4180).
    /// <see href="http://purl.org/NET/schema-org-csv#Row"></see></summary>
    let Row = _prefix "Row"
    /// <summary>
    /// A CSV table as of http://tools.ietf.org/html/rfc4180.
    /// <see href="http://purl.org/NET/schema-org-csv#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// A row has one or more cells (or field as of http://tools.ietf.org/html/rfc4180), each of which is connected to the row with this property.
    /// <see href="http://purl.org/NET/schema-org-csv#cell"></see></summary>
    let cell = _prefix "cell"
    /// <summary>
    /// A table has one or more rows, each of which is connected to the table via this property.
    /// <see href="http://purl.org/NET/schema-org-csv#row"></see></summary>
    let row = _prefix "row"
