namespace http.purl.org.NET.schema_org_csv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module scsv =
    let _namespace_iri = Namespace_Iri scsv |> NamespaceIRI
    /// <summary>
    ///   <para>scsv:Row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A row (or record as of http://tools.ietf.org/html/rfc4180).</para>
    /// labels<para>row</para></remarks>
    /// <seealso href="http://purl.org/NET/schema-org-csv#Row">http://purl.org/NET/schema-org-csv#Row</seealso>
    let Row = Prefixed_Name(scsv, "Row") |> PrefixedName
    /// <summary>
    ///   <para>scsv:cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A row has one or more cells (or field as of http://tools.ietf.org/html/rfc4180), each of which is connected to the row with this property.</para>
    /// labels<para>has cell</para></remarks>
    /// <seealso href="http://purl.org/NET/schema-org-csv#cell">http://purl.org/NET/schema-org-csv#cell</seealso>
    let cell = Prefixed_Name(scsv, "cell") |> PrefixedName
    /// <summary>
    ///   <para>scsv:row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A table has one or more rows, each of which is connected to the table via this property.</para>
    /// labels<para>has row</para></remarks>
    /// <seealso href="http://purl.org/NET/schema-org-csv#row">http://purl.org/NET/schema-org-csv#row</seealso>
    let row = Prefixed_Name(scsv, "row") |> PrefixedName
    /// <summary>
    ///   <para>scsv:HeaderRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The header row, that is the first row of the table that contains the column heads that are matched against Schema.org terms.</para>
    /// labels<para>header row</para></remarks>
    /// <seealso href="http://purl.org/NET/schema-org-csv#HeaderRow">http://purl.org/NET/schema-org-csv#HeaderRow</seealso>
    let HeaderRow = Prefixed_Name(scsv, "HeaderRow") |> PrefixedName
    /// <summary>
    ///   <para>scsv:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A CSV table as of http://tools.ietf.org/html/rfc4180.</para>
    /// labels<para>table</para></remarks>
    /// <seealso href="http://purl.org/NET/schema-org-csv#Table">http://purl.org/NET/schema-org-csv#Table</seealso>
    let Table = Prefixed_Name(scsv, "Table") |> PrefixedName
