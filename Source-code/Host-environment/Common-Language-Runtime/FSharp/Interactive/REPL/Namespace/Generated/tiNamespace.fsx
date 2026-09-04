#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ti =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#" "ti"

    /// <summary>
    ///   <para>rdfs:label : Time intervalrdfs:label : Intervallo di tempo</para>
    ///   <para>rdfs:comment : Any Region in a dimensional space that aims at representing time.
    /// It should be used when you want to talk about time as an object having some characteristics.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#TimeInterval">ti:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : has interval daterdfs:label : intervallo ha data</para>
    ///   <para>rdfs:comment : A datatype property that encodes values from xsd:date (or any other date-related xsd datatype) for a TimeInterval; a same TimeInterval can have more than one date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalDate">ti:hasIntervalDate</a>
    /// </summary>
    let hasIntervalDate = _prefixId.prefix "hasIntervalDate"
    /// <summary>
    ///   <para>rdfs:label : interval has end date</para>
    ///   <para>rdfs:comment : The end date of a time interval.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalEndDate">ti:hasIntervalEndDate</a>
    /// </summary>
    let hasIntervalEndDate = _prefixId.prefix "hasIntervalEndDate"
    /// <summary>
    ///   <para>rdfs:label : interval has start date</para>
    ///   <para>rdfs:comment : The start date of a time interval.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#hasIntervalStartDate">ti:hasIntervalStartDate</a>
    /// </summary>
    let hasIntervalStartDate = _prefixId.prefix "hasIntervalStartDate"
