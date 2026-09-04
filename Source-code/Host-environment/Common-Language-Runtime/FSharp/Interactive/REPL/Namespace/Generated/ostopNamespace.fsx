#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ostop =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#" "ostop"

    /// <summary>
    ///   <para>rdfs:comment : Secondary concept^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#EconomicActivity">ostop:EconomicActivity</a>
    /// </summary>
    let EconomicActivity = _prefixId.prefix "EconomicActivity"
    /// <summary>
    ///   <para>rdfs:label : English County^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#English_County">ostop:English_County</a>
    /// </summary>
    let English_County = _prefixId.prefix "English_County"
    /// <summary>
    ///   <para>rdfs:label : Footprint^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Footprint">ostop:Footprint</a>
    /// </summary>
    let Footprint = _prefixId.prefix "Footprint"
    /// <summary>
    ///   <para>rdfs:label : "Holding"^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Holding">ostop:Holding</a>
    /// </summary>
    let Holding = _prefixId.prefix "Holding"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : Secondary concept^^xsd:string</para>
    ///   <para>rdfs:label : Industry^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Industry">ostop:Industry</a>
    /// </summary>
    let Industry = _prefixId.prefix "Industry"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : Purpose is a secondary concept.^^xsd:string</para>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Purpose">ostop:Purpose</a>
    /// </summary>
    let Purpose = _prefixId.prefix "Purpose"
    /// <summary>
    ///   <para>rdfs:label : Storage^^xsd:stringrdfs:label : Secondary concept^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Storage">ostop:Storage</a>
    /// </summary>
    let Storage = _prefixId.prefix "Storage"
    /// <summary>
    ///   <para>rdfs:label : Structure^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Structure">ostop:Structure</a>
    /// </summary>
    let Structure = _prefixId.prefix "Structure"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : Surface is a secondary concept.^^xsd:string</para>
    ///   <para>rdfs:label : Surface^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Surface">ostop:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : Topographic Object^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#TopographicObject">ostop:TopographicObject</a>
    /// </summary>
    let TopographicObject = _prefixId.prefix "TopographicObject"
    /// <summary>
    ///   <para>rdfs:label : "Traditional County"^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Traditional_County">ostop:Traditional_County</a>
    /// </summary>
    let Traditional_County = _prefixId.prefix "Traditional_County"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : Secondary concept^^xsd:string</para>
    ///   <para>rdfs:label : "Transport"^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#Transport">ostop:Transport</a>
    /// </summary>
    let Transport = _prefixId.prefix "Transport"
    /// <summary>
    ///   <para>rdfs:label : UK Country^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#UK_Country">ostop:UK_Country</a>
    /// </summary>
    let UK_Country = _prefixId.prefix "UK_Country"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : The relationship "contains" is the complement of "is contained in".^^xsd:string</para>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#contains">ostop:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    let earths_surface = _prefixId.prefix "earths_surface"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Definition : allows something to happen but not necessairly by design.^^xsd:string</para>
    ///   <para>rdfs:label : enables^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#enables">ostop:enables</a>
    /// </summary>
    let enables = _prefixId.prefix "enables"
    let england = _prefixId.prefix "england"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Definition : Occupies a physical area of the terrain's surface.^^xsd:string</para>
    ///   <para>rdfs:label : has footprint^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#hasFootprint">ostop:hasFootprint</a>
    /// </summary>
    let hasFootprint = _prefixId.prefix "hasFootprint"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Definition : Possesses a name.^^xsd:string</para>
    ///   <para>rdfs:label : has name^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#hasName">ostop:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : The relationship "has purpose is" a special type of the relationship "enables".^^xsd:string</para>
    ///   <para>rdfs:label : has purpose^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#hasPurpose">ostop:hasPurpose</a>
    /// </summary>
    let hasPurpose = _prefixId.prefix "hasPurpose"
    /// <summary>
    ///   <para>http://www.ordnancesurvey.co.uk/ontology/Rabbit/v1.0/Rabbit.owl#Rabbit : The relationship "is contained in" is the inverse of "contains".^^xsd:string</para>
    ///   <para>rdfs:label : is contained in^^xsd:string</para>
    ///   <a href="http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#isContainedIn">ostop:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    let scotland = _prefixId.prefix "scotland"
    let somerset = _prefixId.prefix "somerset"
    let uk = _prefixId.prefix "uk"
    let united_kingdom = _prefixId.prefix "united_kingdom"
    let wales = _prefixId.prefix "wales"
