namespace http.reference.data.gov.def.govdata.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gd =
    let _namespace_iri = Namespace_Iri gd |> NamespaceIRI
    /// <summary>
    ///   <para>gd:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/Country">http://reference.data.gov/def/govdata/Country</seealso>
    let Country = Prefixed_Name(gd, "Country") |> PrefixedName
    /// <summary>
    ///   <para>gd:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"County"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/County">http://reference.data.gov/def/govdata/County</seealso>
    let County = Prefixed_Name(gd, "County") |> PrefixedName
    /// <summary>
    ///   <para>gd:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/Record">http://reference.data.gov/def/govdata/Record</seealso>
    let Record = Prefixed_Name(gd, "Record") |> PrefixedName
    /// <summary>
    ///   <para>gd:RecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"RecordSet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/RecordSet">http://reference.data.gov/def/govdata/RecordSet</seealso>
    let RecordSet = Prefixed_Name(gd, "RecordSet") |> PrefixedName
    /// <summary>
    ///   <para>gd:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/Report">http://reference.data.gov/def/govdata/Report</seealso>
    let Report = Prefixed_Name(gd, "Report") |> PrefixedName
    /// <summary>
    ///   <para>gd:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/Site">http://reference.data.gov/def/govdata/Site</seealso>
    let Site = Prefixed_Name(gd, "Site") |> PrefixedName
    /// <summary>
    ///   <para>gd:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/State">http://reference.data.gov/def/govdata/State</seealso>
    let State = Prefixed_Name(gd, "State") |> PrefixedName
    /// <summary>
    ///   <para>gd:Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/Survey">http://reference.data.gov/def/govdata/Survey</seealso>
    let Survey = Prefixed_Name(gd, "Survey") |> PrefixedName
    /// <summary>
    ///   <para>gd:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/count">http://reference.data.gov/def/govdata/count</seealso>
    let count = Prefixed_Name(gd, "count") |> PrefixedName
    /// <summary>
    ///   <para>gd:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/country">http://reference.data.gov/def/govdata/country</seealso>
    let country = Prefixed_Name(gd, "country") |> PrefixedName
    /// <summary>
    ///   <para>gd:countyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"countyCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/countyCode">http://reference.data.gov/def/govdata/countyCode</seealso>
    let countyCode = Prefixed_Name(gd, "countyCode") |> PrefixedName
    /// <summary>
    ///   <para>gd:denominator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"denominator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/denominator">http://reference.data.gov/def/govdata/denominator</seealso>
    let denominator = Prefixed_Name(gd, "denominator") |> PrefixedName
    /// <summary>
    ///   <para>gd:median</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"median"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/median">http://reference.data.gov/def/govdata/median</seealso>
    let median = Prefixed_Name(gd, "median") |> PrefixedName
    /// <summary>
    ///   <para>gd:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/percentage">http://reference.data.gov/def/govdata/percentage</seealso>
    let percentage = Prefixed_Name(gd, "percentage") |> PrefixedName
    /// <summary>
    ///   <para>gd:record</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/record">http://reference.data.gov/def/govdata/record</seealso>
    let record = Prefixed_Name(gd, "record") |> PrefixedName
    /// <summary>
    ///   <para>gd:recordset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"recordset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/recordset">http://reference.data.gov/def/govdata/recordset</seealso>
    let recordset = Prefixed_Name(gd, "recordset") |> PrefixedName
    /// <summary>
    ///   <para>gd:stateCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"stateCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://reference.data.gov/def/govdata/stateCode">http://reference.data.gov/def/govdata/stateCode</seealso>
    let stateCode = Prefixed_Name(gd, "stateCode") |> PrefixedName
