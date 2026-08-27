namespace https.w3id.org.vocab.xbrll.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xbrll =
    let _namespace_iri = Namespace_Iri xbrll |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:vocab/xbrll#Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"the context of a fact in a financial report"</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#Context">https://w3id.org/vocab/xbrll#Context</seealso>
    let Context = Prefixed_Name(xbrll, "Context") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#DataPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"this define a fact in the report. A data point should have at least one context"</para>
    /// labels<para>"data point"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#DataPoint">https://w3id.org/vocab/xbrll#DataPoint</seealso>
    let DataPoint = Prefixed_Name(xbrll, "DataPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The dimension defining whether the dimensions in the axis are explicit member or implicit ones"</para>
    /// labels<para>"Dimension"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#Dimension">https://w3id.org/vocab/xbrll#Dimension</seealso>
    let Dimension = Prefixed_Name(xbrll, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#FinancialEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Financial entity"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#FinancialEntity">https://w3id.org/vocab/xbrll#FinancialEntity</seealso>
    let FinancialEntity = Prefixed_Name(xbrll, "FinancialEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#FinancialReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A financial report may content many data points that are facts"</para>
    /// labels<para>"informe financiero"</para><para>"Financial report"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#FinancialReport">https://w3id.org/vocab/xbrll#FinancialReport</seealso>
    let FinancialReport = Prefixed_Name(xbrll, "FinancialReport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Period"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#Period">https://w3id.org/vocab/xbrll#Period</seealso>
    let Period = Prefixed_Name(xbrll, "Period") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#contactPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The person of contact in the metadata info of a company"</para>
    /// labels<para>"Contact person"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#contactPerson">https://w3id.org/vocab/xbrll#contactPerson</seealso>
    let contactPerson = Prefixed_Name(xbrll, "contactPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Context property from a data point"</para>
    /// labels<para>"Context property"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#context">https://w3id.org/vocab/xbrll#context</seealso>
    let context = Prefixed_Name(xbrll, "context") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#dataPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Data point property from a financial report"</para>
    /// labels<para>"Data point property"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#dataPoint">https://w3id.org/vocab/xbrll#dataPoint</seealso>
    let dataPoint = Prefixed_Name(xbrll, "dataPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#decimals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of decimals used for a currency"</para>
    /// labels<para>"Decimals"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#decimals">https://w3id.org/vocab/xbrll#decimals</seealso>
    let decimals = Prefixed_Name(xbrll, "decimals") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"End date of a period"</para>
    /// labels<para>"End date"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#endDate">https://w3id.org/vocab/xbrll#endDate</seealso>
    let endDate = Prefixed_Name(xbrll, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#fiscalYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"End of fiscal year"</para>
    /// labels<para>"Fiscal year"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#fiscalYear">https://w3id.org/vocab/xbrll#fiscalYear</seealso>
    let fiscalYear = Prefixed_Name(xbrll, "fiscalYear") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DataRange</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Has dimension"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#hasDimension">https://w3id.org/vocab/xbrll#hasDimension</seealso>
    let hasDimension = Prefixed_Name(xbrll, "hasDimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#isForever</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Boolean telling the period is forever or not"</para>
    /// labels<para>"Is forever"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#isForever">https://w3id.org/vocab/xbrll#isForever</seealso>
    let isForever = Prefixed_Name(xbrll, "isForever") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#isInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"boolean for the instant moment"</para>
    /// labels<para>"Is instant"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#isInstant">https://w3id.org/vocab/xbrll#isInstant</seealso>
    let isInstant = Prefixed_Name(xbrll, "isInstant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Period"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#period">https://w3id.org/vocab/xbrll#period</seealso>
    let period = Prefixed_Name(xbrll, "period") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#reportYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"year of the report"</para>
    /// labels<para>"Report year"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#reportYear">https://w3id.org/vocab/xbrll#reportYear</seealso>
    let reportYear = Prefixed_Name(xbrll, "reportYear") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll#startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Starting date of a period"</para>
    /// labels<para>"Start date"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll#startDate">https://w3id.org/vocab/xbrll#startDate</seealso>
    let startDate = Prefixed_Name(xbrll, "startDate") |> PrefixedName
