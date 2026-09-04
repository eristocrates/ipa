#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.oegov.org/core/owl/gc#" "gc"
    let Anarcy = _prefixId.prefix "Anarcy"
    /// <summary>
    ///   <para>rdfs:comment : The name, url and other details of an attribution.^^xsd:string</para>
    ///   <para>rdfs:label : Attributed Source^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#AttributedSource">gc:AttributedSource</a>
    /// </summary>
    let AttributedSource = _prefixId.prefix "AttributedSource"
    let CSV_Format = _prefixId.prefix "CSV-Format"
    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#Category">gc:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    let CommunistState = _prefixId.prefix "CommunistState"

    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        _prefixId.prefix "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"

    /// <summary>
    ///   <para>rdfs:label : Data Format^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#DataFormat">gc:DataFormat</a>
    /// </summary>
    let DataFormat = _prefixId.prefix "DataFormat"
    let DateUnion = _prefixId.prefix "DateUnion"
    let Democracy = _prefixId.prefix "Democracy"
    let Dictatorship = _prefixId.prefix "Dictatorship"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#Entity">gc:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    let HTML_Format = _prefixId.prefix "HTML-Format"
    let KML_Format = _prefixId.prefix "KML-Format"
    let KMZ_Format = _prefixId.prefix "KMZ-Format"
    let Monarchy = _prefixId.prefix "Monarchy"
    let OWL_Format = _prefixId.prefix "OWL-Format"
    /// <summary>
    ///   <para>rdfs:label : Period^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#Period">gc:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : Political system^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#PoliticalSystem">gc:PoliticalSystem</a>
    /// </summary>
    let PoliticalSystem = _prefixId.prefix "PoliticalSystem"
    let Q1 = _prefixId.prefix "Q1"
    let Q2 = _prefixId.prefix "Q2"
    let Q3 = _prefixId.prefix "Q3"
    let Q4 = _prefixId.prefix "Q4"
    /// <summary>
    ///   <para>rdfs:label : Quarter^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#Quarter">gc:Quarter</a>
    /// </summary>
    let Quarter = _prefixId.prefix "Quarter"
    let RDF_Format = _prefixId.prefix "RDF-Format"
    let RSS_Format = _prefixId.prefix "RSS-Format"
    let Republic = _prefixId.prefix "Republic"
    let ShapefileFormat = _prefixId.prefix "ShapefileFormat"
    let SocialistState = _prefixId.prefix "SocialistState"
    let TextFormat = _prefixId.prefix "TextFormat"
    let Theocracy = _prefixId.prefix "Theocracy"
    let TopQuadrantAttribution = _prefixId.prefix "TopQuadrantAttribution"
    let Tribal = _prefixId.prefix "Tribal"
    let UnstructuredDataFormat = _prefixId.prefix "UnstructuredDataFormat"
    let XML_Format = _prefixId.prefix "XML-Format"
    let XSL_Format = _prefixId.prefix "XSL-Format"
    /// <summary>
    ///   <para>rdfs:label : archive URL^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#archiveURL">gc:archiveURL</a>
    /// </summary>
    let archiveURL = _prefixId.prefix "archiveURL"
    /// <summary>
    ///   <para>rdfs:label : attributed source^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#attributedSource">gc:attributedSource</a>
    /// </summary>
    let attributedSource = _prefixId.prefix "attributedSource"
    /// <summary>
    ///   <para>rdfs:label : award date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#awardDate">gc:awardDate</a>
    /// </summary>
    let awardDate = _prefixId.prefix "awardDate"
    /// <summary>
    ///   <para>rdfs:label : category^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#category">gc:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : cause^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#cause">gc:cause</a>
    /// </summary>
    let cause = _prefixId.prefix "cause"
    /// <summary>
    ///   <para>rdfs:label : cessation date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#cessationDate">gc:cessationDate</a>
    /// </summary>
    let cessationDate = _prefixId.prefix "cessationDate"
    /// <summary>
    ///   <para>rdfs:label : clause^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#clause">gc:clause</a>
    /// </summary>
    let clause = _prefixId.prefix "clause"
    /// <summary>
    ///   <para>rdfs:label : creation date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#creationDate">gc:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>rdfs:label : currency^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#currency">gc:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#date">gc:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : end date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#endDate">gc:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#format">gc:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : founded on^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#foundedOn">gc:foundedOn</a>
    /// </summary>
    let foundedOn = _prefixId.prefix "foundedOn"
    /// <summary>
    ///   <para>rdfs:label : hashtag^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#hashtag">gc:hashtag</a>
    /// </summary>
    let hashtag = _prefixId.prefix "hashtag"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#identifier">gc:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : licence^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#licence">gc:licence</a>
    /// </summary>
    let licence = _prefixId.prefix "licence"
    /// <summary>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#member">gc:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : number^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#number">gc:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#person">gc:person</a>
    /// </summary>
    let person = _prefixId.prefix "person"
    /// <summary>
    ///   <para>rdfs:label : point of contact^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#pointOfContact">gc:pointOfContact</a>
    /// </summary>
    let pointOfContact = _prefixId.prefix "pointOfContact"
    /// <summary>
    ///   <para>rdfs:label : released date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#releasedDate">gc:releasedDate</a>
    /// </summary>
    let releasedDate = _prefixId.prefix "releasedDate"
    /// <summary>
    ///   <para>rdfs:label : result^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#result">gc:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>rdfs:label : section^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#section">gc:section</a>
    /// </summary>
    let section = _prefixId.prefix "section"
    /// <summary>
    ///   <para>rdfs:label : short title^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#shortTitle">gc:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    /// <summary>
    ///   <para>rdfs:label : start date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#startDate">gc:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#status">gc:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : sub category^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#subCategory">gc:subCategory</a>
    /// </summary>
    let subCategory = _prefixId.prefix "subCategory"
    /// <summary>
    ///   <para>rdfs:label : submission date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#submissionDate">gc:submissionDate</a>
    /// </summary>
    let submissionDate = _prefixId.prefix "submissionDate"
    /// <summary>
    ///   <para>rdfs:label : summary^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#summary">gc:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#text">gc:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#title">gc:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : updated date^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#updatedDate">gc:updatedDate</a>
    /// </summary>
    let updatedDate = _prefixId.prefix "updatedDate"
    /// <summary>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#url">gc:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : year^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/gc#year">gc:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
