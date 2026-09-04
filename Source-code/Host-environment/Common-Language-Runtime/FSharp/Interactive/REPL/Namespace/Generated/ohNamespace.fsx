#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oh =
    let _prefixId = PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/oh#" "oh"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A calendar which can be used for opening hours^^xsd:string</para>
    ///   <para>rdfs:label : A calendar^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#Calendar">oh:Calendar</a>
    /// </summary>
    let Calendar = _prefixId.prefix "Calendar"
    /// <summary>
    ///   <para>rdfs:comment : A class to identify opening hours^^xsd:string</para>
    ///   <para>rdfs:label : Opening Hours^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#OpeningHours">oh:OpeningHours</a>
    /// </summary>
    let OpeningHours = _prefixId.prefix "OpeningHours"
    /// <summary>
    ///   <para>rdfs:comment : A class to identify the type of opening hours^^xsd:string</para>
    ///   <para>rdfs:label : Opening Hours Type^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#OpeningHoursType">oh:OpeningHoursType</a>
    /// </summary>
    let OpeningHoursType = _prefixId.prefix "OpeningHoursType"
    /// <summary>
    ///   <para>rdfs:comment : A property to tell oh:OpeningHours to keep this calendar into account</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#calendar">oh:calendar</a>
    /// </summary>
    let calendar = _prefixId.prefix "calendar"
    /// <summary>
    ///   <para>rdfs:comment : Tell whether or not this oh:Calendar specifies closing hours.^^xsd:string</para>
    ///   <para>rdfs:label : Are Closing Hours^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#closinghours">oh:closinghours</a>
    /// </summary>
    let closinghours = _prefixId.prefix "closinghours"
    /// <summary>
    ///   <para>rdfs:comment : Link a certain thing to a description of opening hours^^xsd:string</para>
    ///   <para>rdfs:label : Has Opening Hours^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#hasOpeningHours">oh:hasOpeningHours</a>
    /// </summary>
    let hasOpeningHours = _prefixId.prefix "hasOpeningHours"
    /// <summary>
    ///   <para>rdfs:comment : Give a type to an oh:OpeningHours instance</para>
    ///   <para>rdfs:label : has Opening Hours Type^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/oh#type">oh:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
