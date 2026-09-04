#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module date =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/misc/date#" "date"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Calendar^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a system of representing time^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Calendar">date:Calendar</a>
    /// </summary>
    let Calendar = _prefixId.prefix "Calendar"
    /// <summary>
    ///   <para>rdfs:label : Calendar Reference Point^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a reference point which a calendar measures other dates relative to^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#CalendarReferencePoint">date:CalendarReferencePoint</a>
    /// </summary>
    let CalendarReferencePoint = _prefixId.prefix "CalendarReferencePoint"
    /// <summary>
    ///   <para>rdfs:label : Date^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a value representing time^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Date">date:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rdfs:label : Date Component^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the parts of a date^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Date-Component">date:Date-Component</a>
    /// </summary>
    let Date_Component = _prefixId.prefix "Date-Component"
    /// <summary>
    ///   <para>rdfs:label : Date Ordering^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the order in which components describing a date should be displayed^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Date-Ordering">date:Date-Ordering</a>
    /// </summary>
    let Date_Ordering = _prefixId.prefix "Date-Ordering"
    /// <summary>
    ///   <para>rdfs:label : Day^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the part of a date which is the day designaition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Day">date:Day</a>
    /// </summary>
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:label : Hour^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the part of a date which is the hour designaition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Hour">date:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>rdfs:label : Minute^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the part of a date which is the minute designaition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Minute">date:Minute</a>
    /// </summary>
    let Minute = _prefixId.prefix "Minute"
    /// <summary>
    ///   <para>rdfs:label : Month^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the part of a date which is the month designaition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Month">date:Month</a>
    /// </summary>
    let Month = _prefixId.prefix "Month"
    /// <summary>
    ///   <para>rdfs:label : Qualifier^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the textual qualifier that may be part of the data i.e. AD, BCE etc^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Qualifier">date:Qualifier</a>
    /// </summary>
    let Qualifier = _prefixId.prefix "Qualifier"
    /// <summary>
    ///   <para>rdfs:label : Second^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the part of a date which is the second designaition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Second">date:Second</a>
    /// </summary>
    let Second = _prefixId.prefix "Second"
    /// <summary>
    ///   <para>rdfs:label : International Standard^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the International Standard form of the date^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Standard">date:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>rdfs:label : Year^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the part of a date which is the year designaition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#Year">date:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>rdfs:comment : The occurrance of an event from which the reference point was abstracted^^xsd:string</para>
    ///   <para>rdfs:label : Abstracted From Occurrence^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#abstracted-from-occurrence">date:abstracted-from-occurrence</a>
    /// </summary>
    let abstracted_from_occurrence = _prefixId.prefix "abstracted-from-occurrence"
    /// <summary>
    ///   <para>rdfs:comment : The relative reference point after which the desired point of time occurs^^xsd:string</para>
    ///   <para>rdfs:label : After Reference Point^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#after-reference-point">date:after-reference-point</a>
    /// </summary>
    let after_reference_point = _prefixId.prefix "after-reference-point"
    /// <summary>
    ///   <para>rdfs:comment : The relative reference point before which the desired point of time occurs^^xsd:string</para>
    ///   <para>rdfs:label : Before Reference Point^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#before-reference-point">date:before-reference-point</a>
    /// </summary>
    let before_reference_point = _prefixId.prefix "before-reference-point"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the name represented by the component^^xsd:string</para>
    ///   <para>rdfs:label : Has Date Component^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#has-date-component">date:has-date-component</a>
    /// </summary>
    let has_date_component = _prefixId.prefix "has-date-component"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a point of reference in a Calendar^^xsd:string</para>
    ///   <para>rdfs:label : Has Reference Point^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#has-reference-point">date:has-reference-point</a>
    /// </summary>
    let has_reference_point = _prefixId.prefix "has-reference-point"
    /// <summary>
    ///   <para>rdfs:comment : The Year Preceeding the Reference Point Year^^xsd:string</para>
    ///   <para>rdfs:label : Reference Point Minus One^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-minus-one">date:reference-point-minus-one</a>
    /// </summary>
    let reference_point_minus_one = _prefixId.prefix "reference-point-minus-one"
    /// <summary>
    ///   <para>rdfs:comment : The Year Following the Reference Point Year^^xsd:string</para>
    ///   <para>rdfs:label : Reference Point Plus One^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-plus-one">date:reference-point-plus-one</a>
    /// </summary>
    let reference_point_plus_one = _prefixId.prefix "reference-point-plus-one"
    /// <summary>
    ///   <para>rdfs:comment : The calandar which the date uses^^xsd:string</para>
    ///   <para>rdfs:label : Uses Calendar^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/misc/date#uses-calendar">date:uses-calendar</a>
    /// </summary>
    let uses_calendar = _prefixId.prefix "uses-calendar"
