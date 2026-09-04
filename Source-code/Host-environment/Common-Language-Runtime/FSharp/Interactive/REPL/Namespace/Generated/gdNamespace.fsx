#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gd =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov/def/govdata/" "gd"

    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/Country">gd:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : County^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/County">gd:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:label : Record^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/Record">gd:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    /// <summary>
    ///   <para>rdfs:label : RecordSet^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/RecordSet">gd:RecordSet</a>
    /// </summary>
    let RecordSet = _prefixId.prefix "RecordSet"
    /// <summary>
    ///   <para>rdfs:label : Report^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/Report">gd:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/Site">gd:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/State">gd:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Survey^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/Survey">gd:Survey</a>
    /// </summary>
    let Survey = _prefixId.prefix "Survey"
    /// <summary>
    ///   <para>rdfs:label : count^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/count">gd:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/country">gd:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : countyCode^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/countyCode">gd:countyCode</a>
    /// </summary>
    let countyCode = _prefixId.prefix "countyCode"
    /// <summary>
    ///   <para>rdfs:label : denominator^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/denominator">gd:denominator</a>
    /// </summary>
    let denominator = _prefixId.prefix "denominator"
    /// <summary>
    ///   <para>rdfs:label : median^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/median">gd:median</a>
    /// </summary>
    let median = _prefixId.prefix "median"
    /// <summary>
    ///   <para>rdfs:label : percentage^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/percentage">gd:percentage</a>
    /// </summary>
    let percentage = _prefixId.prefix "percentage"
    /// <summary>
    ///   <para>rdfs:label : record^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/record">gd:record</a>
    /// </summary>
    let record = _prefixId.prefix "record"
    /// <summary>
    ///   <para>rdfs:label : recordset^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/recordset">gd:recordset</a>
    /// </summary>
    let recordset = _prefixId.prefix "recordset"
    /// <summary>
    ///   <para>rdfs:label : stateCode^^xsd:string</para>
    ///   <a href="http://reference.data.gov/def/govdata/stateCode">gd:stateCode</a>
    /// </summary>
    let stateCode = _prefixId.prefix "stateCode"
