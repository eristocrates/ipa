namespace http.www.ontologydesignpatterns.org.cp.owl.timeinterval.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ti =
    let _namespace_iri = Namespace_Iri ti |> NamespaceIRI
    /// <summary>
    ///   <para>ti:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Region in a dimensional space that aims at representing time.
    /// It should be used when you want to talk about time as an object having some characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Two (starting and ending) points in time that define a particular period of time."</para>
    /// labels<para>"Intervallo di tempo"</para><para>"time interval"</para><para>"Time interval"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#TimeInterval">http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(ti, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>ti:hasIntervalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A datatype property that encodes values from xsd:date (or any other date-related xsd datatype) for a TimeInterval; a same TimeInterval can have more than one date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"intervallo ha data"</para><para>"has interval date"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalDate">http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalDate</seealso>
    let hasIntervalDate = Prefixed_Name(ti, "hasIntervalDate") |> PrefixedName
    /// <summary>
    ///   <para>ti:hasIntervalEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The end date of a time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interval has end date"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalEndDate">http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalEndDate</seealso>
    let hasIntervalEndDate = Prefixed_Name(ti, "hasIntervalEndDate") |> PrefixedName
    /// <summary>
    ///   <para>ti:hasIntervalStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The start date of a time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interval has start date"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalStartDate">http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalStartDate</seealso>
    let hasIntervalStartDate = Prefixed_Name(ti, "hasIntervalStartDate") |> PrefixedName
