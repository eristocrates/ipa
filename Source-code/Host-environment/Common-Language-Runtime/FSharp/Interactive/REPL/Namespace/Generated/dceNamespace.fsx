#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dce =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dc/elements/1.1/" "dce"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Contributor</para>
    ///   <para>rdfs:comment : An entity responsible for making contributions to the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Examples of a Contributor include a person, an organization, or a service. Typically, the name of a Contributor should be used to indicate the entity.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/contributor">dce:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Coverage</para>
    ///   <para>rdfs:comment : The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Spatial topic and spatial applicability may be a named place or a location specified by its geographic coordinates. Temporal topic may be a named period, date, or date range. A jurisdiction may be a named administrative entity or a geographic place to which the resource applies. Recommended best practice is to use a controlled vocabulary such as the Thesaurus of Geographic Names [TGN]. Where appropriate, named places or time periods can be used in preference to numeric identifiers such as sets of coordinates or date ranges.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/coverage">dce:coverage</a>
    /// </summary>
    let coverage = _prefixId.prefix "coverage"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <para>rdfs:comment : An entity primarily responsible for making the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Examples of a Creator include a person, an organization, or a service. Typically, the name of a Creator should be used to indicate the entity.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/creator">dce:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : A point or period of time associated with an event in the lifecycle of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Date may be used to express temporal information at any level of granularity.  Recommended best practice is to use an encoding scheme, such as the W3CDTF profile of ISO 8601 [W3CDTF].</para>
    ///   <a href="http://purl.org/dc/elements/1.1/date">dce:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Description</para>
    ///   <para>rdfs:comment : An account of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/description">dce:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : The file format, physical medium, or dimensions of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Examples of dimensions include size and duration. Recommended best practice is to use a controlled vocabulary such as the list of Internet Media Types [MIME].</para>
    ///   <a href="http://purl.org/dc/elements/1.1/format">dce:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>rdfs:comment : An unambiguous reference to the resource within a given context.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Recommended best practice is to identify the resource by means of a string conforming to a formal identification system. </para>
    ///   <a href="http://purl.org/dc/elements/1.1/identifier">dce:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>dcterms:description : Recommended best practice is to use a controlled vocabulary such as RFC 4646 [RFC4646].</para>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : A language of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/elements/1.1/language">dce:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Examples of a Publisher include a person, an organization, or a service. Typically, the name of a Publisher should be used to indicate the entity.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/publisher">dce:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <para>rdfs:comment : A related resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Recommended best practice is to identify the related resource by means of a string conforming to a formal identification system. </para>
    ///   <a href="http://purl.org/dc/elements/1.1/relation">dce:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Rights</para>
    ///   <para>rdfs:comment : Information about rights held in and over the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/rights">dce:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : A related resource from which the described resource is derived.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : The described resource may be derived from the related resource in whole or in part. Recommended best practice is to identify the related resource by means of a string conforming to a formal identification system.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/source">dce:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <para>rdfs:comment : The topic of the resource.</para>
    ///   <para>dcterms:modified : 2012-06-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Typically, the subject will be represented using keywords, key phrases, or classification codes. Recommended best practice is to use a controlled vocabulary.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/subject">dce:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Title</para>
    ///   <para>rdfs:comment : A name given to the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <a href="http://purl.org/dc/elements/1.1/title">dce:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>skos:note : A second property with the same name as this property has been declared in the dcterms: namespace (http://purl.org/dc/terms/).  See the Introduction to the document "DCMI Metadata Terms" (http://dublincore.org/documents/dcmi-terms/) for an explanation.</para>
    ///   <para>rdfs:label : Type</para>
    ///   <para>rdfs:comment : The nature or genre of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 1999-07-02^^xsd:date</para>
    ///   <para>dcterms:description : Recommended best practice is to use a controlled vocabulary such as the DCMI Type Vocabulary [DCMITYPE]. To describe the file format, physical medium, or dimensions of the resource, use the Format element.</para>
    ///   <a href="http://purl.org/dc/elements/1.1/type">dce:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
