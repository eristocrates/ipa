#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module scsv =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/NET/schema-org-csv#" "scsv"

    /// <summary>
    ///   <para>rdfs:label : header row^^xsd:string</para>
    ///   <para>rdfs:comment : The header row, that is the first row of the table that contains the column heads that are matched against Schema.org terms.^^xsd:string</para>
    ///   <a href="http://purl.org/NET/schema-org-csv#HeaderRow">scsv:HeaderRow</a>
    /// </summary>
    let HeaderRow = _prefixId.prefix "HeaderRow"
    /// <summary>
    ///   <para>rdfs:label : row^^xsd:string</para>
    ///   <para>rdfs:comment : A row (or record as of http://tools.ietf.org/html/rfc4180).^^xsd:string</para>
    ///   <a href="http://purl.org/NET/schema-org-csv#Row">scsv:Row</a>
    /// </summary>
    let Row = _prefixId.prefix "Row"
    /// <summary>
    ///   <para>rdfs:label : table^^xsd:string</para>
    ///   <para>rdfs:comment : A CSV table as of http://tools.ietf.org/html/rfc4180.^^xsd:string</para>
    ///   <a href="http://purl.org/NET/schema-org-csv#Table">scsv:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : has cell^^xsd:string</para>
    ///   <para>rdfs:comment : A row has one or more cells (or field as of http://tools.ietf.org/html/rfc4180), each of which is connected to the row with this property.^^xsd:string</para>
    ///   <a href="http://purl.org/NET/schema-org-csv#cell">scsv:cell</a>
    /// </summary>
    let cell = _prefixId.prefix "cell"
    /// <summary>
    ///   <para>rdfs:label : has row^^xsd:string</para>
    ///   <para>rdfs:comment : A table has one or more rows, each of which is connected to the table via this property.^^xsd:string</para>
    ///   <a href="http://purl.org/NET/schema-org-csv#row">scsv:row</a>
    /// </summary>
    let row = _prefixId.prefix "row"
