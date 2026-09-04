#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module h2o =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#" "h2o"

    let _namespaceIri = _prefixId.prefix ""
    let ISOClassName = _prefixId.prefix "ISOClassName"
    /// <summary>
    ///   <para>rdfs:label : UML tagged value structure^^xsd:string</para>
    ///   <para>rdfs:comment : Class for UML tagged values^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#TaggedValue">h2o:TaggedValue</a>
    /// </summary>
    let TaggedValue = _prefixId.prefix "TaggedValue"
    /// <summary>
    ///   <para>rdfs:label : UML constraint^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#constraint">h2o:constraint</a>
    /// </summary>
    let constraint_ = _prefixId.prefix "constraint"
    /// <summary>
    ///   <para>rdfs:label : UML abstract class^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates whether the class was flagged 'abstract' in the UML model. Abstract classes cannot be instantiated directly. Concrete subclasses may be instantiated.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isAbstract">h2o:isAbstract</a>
    /// </summary>
    let isAbstract = _prefixId.prefix "isAbstract"
    /// <summary>
    ///   <para>rdfs:label : ISO stereotype flag^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates if the class corresponds to a UML stereotype ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isStereotype">h2o:isStereotype</a>
    /// </summary>
    let isStereotype = _prefixId.prefix "isStereotype"
    /// <summary>
    ///   <para>rdfs:label : UML tagged value^^xsd:string</para>
    ///   <para>rdfs:comment : OWL property that links to a tagged value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tag">h2o:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : UML tagged value tag^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ttag">h2o:ttag</a>
    /// </summary>
    let ttag = _prefixId.prefix "ttag"
    /// <summary>
    ///   <para>rdfs:label : UML tagged value value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tvalue">h2o:tvalue</a>
    /// </summary>
    let tvalue = _prefixId.prefix "tvalue"
    /// <summary>
    ///   <para>rdfs:label : value assignment method^^xsd:string</para>
    ///   <para>rdfs:comment : property that can be attached to any statement to support a link to the evidence for the value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#valueAssignment">h2o:valueAssignment</a>
    /// </summary>
    let valueAssignment = _prefixId.prefix "valueAssignment"
