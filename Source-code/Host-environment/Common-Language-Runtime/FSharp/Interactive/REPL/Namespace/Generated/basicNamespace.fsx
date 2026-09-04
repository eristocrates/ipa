#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module basic =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#" "basic"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Measure of rate of change of velocity^^xsd:string</para>
    ///   <para>rdfs:label : Acceleration</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Acceleration">basic:Acceleration</a>
    /// </summary>
    let Acceleration = _prefixId.prefix "Acceleration"
    /// <summary>
    ///   <para>rdfs:comment : measure of arc length or rotation^^xsd:string</para>
    ///   <para>rdfs:label : Angle^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Angle">basic:Angle</a>
    /// </summary>
    let Angle = _prefixId.prefix "Angle"
    /// <summary>
    ///   <para>rdfs:comment : Measure of rate of change of angular position^^xsd:string</para>
    ///   <para>rdfs:label : AngularVelocity^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#AngularVelocity">basic:AngularVelocity</a>
    /// </summary>
    let AngularVelocity = _prefixId.prefix "AngularVelocity"
    /// <summary>
    ///   <para>rdfs:comment : Measure of 2-D extent^^xsd:string</para>
    ///   <para>rdfs:label : Area^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Area">basic:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    let Boolean = _prefixId.prefix "Boolean"
    let CharacterString = _prefixId.prefix "CharacterString"
    /// <summary>
    ///   <para>rdfs:comment : Measure of exchange value^^xsd:string</para>
    ///   <para>rdfs:label : Currency^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Currency">basic:Currency</a>
    /// </summary>
    let Currency = _prefixId.prefix "Currency"
    let Date = _prefixId.prefix "Date"
    let DateTime = _prefixId.prefix "DateTime"
    let Decimal = _prefixId.prefix "Decimal"
    /// <summary>
    ///   <para>rdfs:comment : Measure of spatial separation along some 1-D manifold^^xsd:string</para>
    ///   <para>rdfs:label : Distance^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Distance">basic:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    let Integer = _prefixId.prefix "Integer"
    /// <summary>
    ///   <para>rdfs:comment : Measure of 1-D extent^^xsd:string</para>
    ///   <para>rdfs:label : Length^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Length">basic:Length</a>
    /// </summary>
    let Length = _prefixId.prefix "Length"
    let LocalName = _prefixId.prefix "LocalName"
    /// <summary>
    ///   <para>rdfs:comment : Measure of amount of substance^^xsd:string</para>
    ///   <para>rdfs:label : Mass^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Mass">basic:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>rdfs:label : Mesurerdfs:label : Measure</para>
    ///   <para>rdfs:comment : Scaled number^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Measure">basic:Measure</a>
    /// </summary>
    let Measure = _prefixId.prefix "Measure"
    let Number = _prefixId.prefix "Number"
    let Real = _prefixId.prefix "Real"
    /// <summary>
    ///   <para>rdfs:comment : Factor by which a representation should be magnified to match the geomstric size of the thing it represents.^^xsd:string</para>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Scale">basic:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:comment : Measure of temporal extent^^xsd:string</para>
    ///   <para>rdfs:label : Time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Time">basic:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:comment : Scale for a number describing size or extent^^xsd:string</para>
    ///   <para>rdfs:label : Unit of measure^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#UnitOfMeasure">basic:UnitOfMeasure</a>
    /// </summary>
    let UnitOfMeasure = _prefixId.prefix "UnitOfMeasure"
    /// <summary>
    ///   <para>rdfs:comment : A vector is a sequence of a fixed length of Numbers. Normally, the numbers represent some measures, and thus vectors are often used where records of Numbers would be more appropriate. In geometry for example, direct positions are given by undistinguished coordinate vectors, which can be interpreted through the use of coordinate reference systems.^^xsd:string</para>
    ///   <para>rdfs:label : Vector^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Vector">basic:Vector</a>
    /// </summary>
    let Vector = _prefixId.prefix "Vector"
    /// <summary>
    ///   <para>rdfs:comment : Measure of rate of change of position^^xsd:string</para>
    ///   <para>rdfs:label : Velocity^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Velocity">basic:Velocity</a>
    /// </summary>
    let Velocity = _prefixId.prefix "Velocity"
    /// <summary>
    ///   <para>skos:notation : Volume^^basic:ISOClassName</para>
    ///   <para>rdfs:comment : Measure of 3-D extent^^xsd:string</para>
    ///   <para>rdfs:label : Volume^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Volume">basic:Volume</a>
    /// </summary>
    let Volume = _prefixId.prefix "Volume"
    /// <summary>
    ///   <para>rdfs:comment : Measure of force due to a mass in a specific gravitational field^^xsd:string</para>
    ///   <para>rdfs:label : Weight^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Weight">basic:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>rdfs:label : dimension^^xsd:string</para>
    ///   <para>rdfs:comment : Number of components in the vector^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#dimension">basic:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>rdfs:comment : The value of this property is a scaled number^^xsd:string</para>
    ///   <para>rdfs:label : measure^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#measure">basic:measure</a>
    /// </summary>
    let measure = _prefixId.prefix "measure"
    /// <summary>
    ///   <para>rdfs:label : ordinates^^xsd:string</para>
    ///   <para>rdfs:comment : Numerical values of the vector components^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#ordinates">basic:ordinates</a>
    /// </summary>
    let ordinates = _prefixId.prefix "ordinates"
    /// <summary>
    ///   <para>rdfs:comment : The value of this property designates the units of measure or scale for the quantity^^xsd:string</para>
    ///   <para>rdfs:label : unit of measure^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#uom">basic:uom</a>
    /// </summary>
    let uom = _prefixId.prefix "uom"
    /// <summary>
    ///   <para>rdfs:comment : The value of this property is a number^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#value">basic:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
