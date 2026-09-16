#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdam =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/m/" "rdam"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a categorization reflecting the format of the storage medium and housing of a carrier in combination with the type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A categorization reflecting the format of the storage medium and housing of a carrier in combination with the type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : carrierType</para>
    ///   <para>rdfs:label : has carrier type</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : carrier type</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30001">rdam:P30001</a>
    /// </summary>
    let P30001 = _prefixId.prefix "P30001"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediaType</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : media type</para>
    ///   <para>rdfs:label : has media type</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30002">rdam:P30002</a>
    /// </summary>
    let P30002 = _prefixId.prefix "P30002"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : mode of issuance</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A categorization reflecting whether a resource is issued in one or more parts, the way it is updated, and its intended termination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modeOfIssuance</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.13^^xsd:string</para>
    ///   <para>rdfs:label : has mode of issuance</para>
    ///   <para>skos:definition : Relates a manifestation to a categorization reflecting whether a resource is issued in one or more parts, the way it is updated, and its intended termination.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30003">rdam:P30003</a>
    /// </summary>
    let P30003 = _prefixId.prefix "P30003"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A character string associated with a manifestation that serves to differentiate that manifestation from other manifestations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.15^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : identifier for the manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheManifestation</para>
    ///   <para>rdfs:label : has identifier for the manifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a character string associated with a manifestation that serves to differentiate that manifestation from other manifestations.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30004">rdam:P30004</a>
    /// </summary>
    let P30004 = _prefixId.prefix "P30004"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredCitation</para>
    ///   <para>rdfs:label : has preferred citation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preferred citation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A citation for a resource in the form preferred by a creator, publisher, custodian, indexing or abstracting service, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.16^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a citation for a resource in the form preferred by a creator, publisher, custodian, indexing or abstracting service, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30005">rdam:P30005</a>
    /// </summary>
    let P30005 = _prefixId.prefix "P30005"
    /// <summary>
    ///   <para>rdfs:label : has regional encoding</para>
    ///   <para>skos:definition : Relates a manifestation to a code identifying the region of the world for which a videodisc has been encoded and preventing the disc from being played on a player sold in a different region.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A code identifying the region of the world for which a videodisc has been encoded and preventing the disc from being played on a player sold in a different region.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : regional encoding</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : regionalEncoding</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30006">rdam:P30006</a>
    /// </summary>
    let P30006 = _prefixId.prefix "P30006"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : copyright date</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : copyrightDate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.11^^xsd:string</para>
    ///   <para>rdfs:label : has copyright date</para>
    ///   <para>skos:definition : Relates a manifestation to a date associated with a claim of protection under copyright or a similar regime.</para>
    ///   <para>skos:scopeNote : Copyright dates include phonogram dates (i.e., dates associated with claims of protection for audio recordings).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date associated with a claim of protection under copyright or a similar regime.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30007">rdam:P30007</a>
    /// </summary>
    let P30007 = _prefixId.prefix "P30007"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.9.6^^xsd:string</para>
    ///   <para>rdfs:label : has date of distribution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date associated with the distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDistribution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of distribution</para>
    ///   <para>skos:definition : Relates a manifestation to a date associated with the distribution of a resource in a published form.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30008">rdam:P30008</a>
    /// </summary>
    let P30008 = _prefixId.prefix "P30008"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of production</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfProduction</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>rdfs:label : has date of production</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.7.6^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a date associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30009">rdam:P30009</a>
    /// </summary>
    let P30009 = _prefixId.prefix "P30009"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of manufacture</para>
    ///   <para>skos:definition : Relates a manifestation to a date associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfManufacture</para>
    ///   <para>rdfs:label : has date of manufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.10.6^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30010">rdam:P30010</a>
    /// </summary>
    let P30010 = _prefixId.prefix "P30010"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.8.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfPublication</para>
    ///   <para>rdfs:label : has date of publication</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of publication</para>
    ///   <para>skos:definition : Relates a manifestation to a date associated with the publication, release, or issuing of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30011">rdam:P30011</a>
    /// </summary>
    let P30011 = _prefixId.prefix "P30011"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel designation of a named revision of an edition</para>
    ///   <para>skos:definition : Relates a manifestation to a designation of a named revision of an edition in a language and/or script that differs from that recorded in the designation of a named revision of an edition element.</para>
    ///   <para>rdfs:label : has parallel designation of a named revision of an edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A designation of a named revision of an edition in a language and/or script that differs from that recorded in the designation of a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfANamedRevisionOfAnEdition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.7^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30012">rdam:P30012</a>
    /// </summary>
    let P30012 = _prefixId.prefix "P30012"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfEdition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel designation of edition</para>
    ///   <para>rdfs:label : has parallel designation of edition</para>
    ///   <para>skos:definition : Relates a manifestation to a designation of edition in a language and/or script that differs from that recorded in the designation of edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A designation of edition in a language and/or script that differs from that recorded in the designation of edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.3^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30013">rdam:P30013</a>
    /// </summary>
    let P30013 = _prefixId.prefix "P30013"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSeries</para>
    ///   <para>skos:definition : Relates a manifestation to a designation of the sequencing of a part or parts within a series.</para>
    ///   <para>rdfs:label : has numbering within series</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.9^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A designation of the sequencing of a part or parts within a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numbering within series</para>
    ///   <para>skos:scopeNote : Numbering within series may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30014">rdam:P30014</a>
    /// </summary>
    let P30014 = _prefixId.prefix "P30014"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numbering within subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSubseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A designation of the sequencing of a part or parts within a subseries.</para>
    ///   <para>rdfs:label : has numbering within subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.17^^xsd:string</para>
    ///   <para>skos:scopeNote : Numbering within subseries may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <para>skos:definition : Relates a manifestation to a designation of the sequencing of a part or parts within a subseries.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30015">rdam:P30015</a>
    /// </summary>
    let P30015 = _prefixId.prefix "P30015"
    /// <summary>
    ///   <para>rdfs:label : is electronic reproduction (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation in a digital format that is the result of the transfer of a manifestation in an analog format.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation in a digital format that is the result of the transfer of a manifestation in an analog format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : electronic reproduction (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30016">rdam:P30016</a>
    /// </summary>
    let P30016 = _prefixId.prefix "P30016"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDistributorsName</para>
    ///   <para>rdfs:label : has parallel distributor’s name</para>
    ///   <para>skos:definition : Relates a manifestation to a distributor's name in a language and/or script that differs from that recorded in the distributor's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel distributor's name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A distributor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.9.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30017">rdam:P30017</a>
    /// </summary>
    let P30017 = _prefixId.prefix "P30017"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : file type</para>
    ///   <para>skos:definition : Relates a manifestation to a general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileType</para>
    ///   <para>rdfs:label : has file type</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30018">rdam:P30018</a>
    /// </summary>
    let P30018 = _prefixId.prefix "P30018"
    /// <summary>
    ///   <para>rdfs:label : is facsimile contained in</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileContainedIn</para>
    ///   <para>skos:definition : Relates a manifestation to a larger manifestation of which a part is a discrete component that exactly reproduces another manifestation embodying the same expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A larger manifestation of which a part is a discrete component that exactly reproduces another manifestation embodying the same expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : facsimile contained in</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30019">rdam:P30019</a>
    /// </summary>
    let P30019 = _prefixId.prefix "P30019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : contained in (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a larger manifestation of which the manifestation is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInManifestation</para>
    ///   <para>rdfs:label : is contained in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A larger manifestation of which the manifestation is a discrete component.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30020">rdam:P30020</a>
    /// </summary>
    let P30020 = _prefixId.prefix "P30020"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preservation facsimile (manifestation)</para>
    ///   <para>rdfs:label : is preservation facsimile (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that consists of an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that consists of an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30021">rdam:P30021</a>
    /// </summary>
    let P30021 = _prefixId.prefix "P30021"
    /// <summary>
    ///   <para>rdfs:label : is insert</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : insert</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation consisting of separately issued material that is not an integral part of the larger manifestation into which it has been inserted.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insert</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation consisting of separately issued material that is not an integral part of the larger manifestation into which it has been inserted.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30022">rdam:P30022</a>
    /// </summary>
    let P30022 = _prefixId.prefix "P30022"
    let P30023 = _prefixId.prefix "P30023"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that embodies the same expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalentManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that embodies the same expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : equivalent (manifestation)</para>
    ///   <para>rdfs:label : is equivalent (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30024">rdam:P30024</a>
    /// </summary>
    let P30024 = _prefixId.prefix "P30024"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a manifestation into which material has been inserted that is not an integral part of the publication.</para>
    ///   <para>rdfs:label : is inserted in</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : inserted in</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation into which material has been inserted that is not an integral part of the publication.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insertedIn</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30025">rdam:P30025</a>
    /// </summary>
    let P30025 = _prefixId.prefix "P30025"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that embodies the same expression of a work in a different format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : also issued as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alsoIssuedAs</para>
    ///   <para>rdfs:label : is also issued as</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that embodies the same expression of a work in a different format.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30026">rdam:P30026</a>
    /// </summary>
    let P30026 = _prefixId.prefix "P30026"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : accompanied by (manifestation)</para>
    ///   <para>rdfs:label : is accompanied by (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation issued with another manifestation, without any relationship to its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompaniedByManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation issued with another manifestation, without any relationship to its content.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30027">rdam:P30027</a>
    /// </summary>
    let P30027 = _prefixId.prefix "P30027"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is an exact copy of a website , used to reduce network traffic or improve the availability of the content of the original site.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : mirror site</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is an exact copy of a website , used to reduce network traffic or improve the availability of the content of the original site.</para>
    ///   <para>rdfs:label : is mirror site</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mirrorSite</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30028">rdam:P30028</a>
    /// </summary>
    let P30028 = _prefixId.prefix "P30028"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferManifestation</para>
    ///   <para>rdfs:label : is digital transfer (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digital transfer (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation in a digital format that results from the transfer of a manifestation in another digital format.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation in a digital format that results from the transfer of a manifestation in another digital format.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30029">rdam:P30029</a>
    /// </summary>
    let P30029 = _prefixId.prefix "P30029"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssue</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that consists of a single issue or a supplementary section of a serial or newspaper devoted to a special subject.</para>
    ///   <para>rdfs:label : is special issue</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : special issue</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that consists of a single issue or a supplementary section of a serial or newspaper devoted to a special subject.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30030">rdam:P30030</a>
    /// </summary>
    let P30030 = _prefixId.prefix "P30030"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that exactly reproduces another manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : facsimile (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that exactly reproduces another manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileManifestation</para>
    ///   <para>rdfs:label : is facsimile (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30031">rdam:P30031</a>
    /// </summary>
    let P30031 = _prefixId.prefix "P30031"
    let P30032 = _prefixId.prefix "P30032"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is a discrete component of a larger manifestation.</para>
    ///   <para>rdfs:label : is container of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : container of (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is a discrete component of a larger manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containerOfManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30033">rdam:P30033</a>
    /// </summary>
    let P30033 = _prefixId.prefix "P30033"
    let P30034 = _prefixId.prefix "P30034"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is issued on the same carrier as the manifestation being described.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is issued on the same carrier as the manifestation being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuedWith</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : issued with</para>
    ///   <para>rdfs:label : is issued with</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30035">rdam:P30035</a>
    /// </summary>
    let P30035 = _prefixId.prefix "P30035"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onDiscWithManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is issued on the same disc with the manifestation being described.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is issued on the same disc with the manifestation being described.</para>
    ///   <para>rdfs:label : is on disc with (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : on disc with (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30036">rdam:P30036</a>
    /// </summary>
    let P30036 = _prefixId.prefix "P30036"
    /// <summary>
    ///   <para>rdfs:label : is filmed with (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is issued on the same microform with the manifestation being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is issued on the same microform with the manifestation being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmedWithManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : filmed with (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30037">rdam:P30037</a>
    /// </summary>
    let P30037 = _prefixId.prefix "P30037"
    /// <summary>
    ///   <para>rdfs:label : is reprinted as (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintedAsManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is a reissue of another printed manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is a reissue of another printed manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reprinted as (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30038">rdam:P30038</a>
    /// </summary>
    let P30038 = _prefixId.prefix "P30038"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reproduced as (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that reproduces another manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproducedAsManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that reproduces another manifestation.</para>
    ///   <para>rdfs:label : is reproduced as (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30039">rdam:P30039</a>
    /// </summary>
    let P30039 = _prefixId.prefix "P30039"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation in a digital format that is transferred to another digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digital transfer of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferOfManifestation</para>
    ///   <para>rdfs:label : is digital transfer of (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation in a digital format that is transferred to another digital format.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30040">rdam:P30040</a>
    /// </summary>
    let P30040 = _prefixId.prefix "P30040"
    let P30041 = _prefixId.prefix "P30041"
    let P30042 = _prefixId.prefix "P30042"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reproduction of (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is used as the basis for a reproduction.</para>
    ///   <para>rdfs:label : is reproduction of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproductionOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is used as the basis for a reproduction.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30043">rdam:P30043</a>
    /// </summary>
    let P30043 = _prefixId.prefix "P30043"
    let P30044 = _prefixId.prefix "P30044"
    /// <summary>
    ///   <para>rdfs:label : is preservation facsimile of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preservation facsimile of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30045">rdam:P30045</a>
    /// </summary>
    let P30045 = _prefixId.prefix "P30045"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileContainerOf</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation used as the basis for an exact reproduction that is a discrete component of a larger manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : facsimile container of</para>
    ///   <para>rdfs:label : is facsimile container of</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation used as the basis for an exact reproduction that is a discrete component of a larger manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30046">rdam:P30046</a>
    /// </summary>
    let P30046 = _prefixId.prefix "P30046"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is used as the basis for an exact reproduction.</para>
    ///   <para>rdfs:label : is facsimile of (manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is used as the basis for an exact reproduction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : facsimile of (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30047">rdam:P30047</a>
    /// </summary>
    let P30047 = _prefixId.prefix "P30047"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a manifestation, represented by an identifier or a description, that is related to the manifestation being described (e.g., a manifestation in a different format).</para>
    ///   <para>rdfs:label : has related manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation, represented by an identifier or a description, that is related to the manifestation being described (e.g., a manifestation in a different format).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 27.1^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30048">rdam:P30048</a>
    /// </summary>
    let P30048 = _prefixId.prefix "P30048"
    /// <summary>
    ///   <para>rdfs:label : has parallel manufacturer’s name</para>
    ///   <para>skos:definition : Relates a manifestation to a manufacturer's name in a language and/or script that differs from that recorded in the manufacturer's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manufacturer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelManufacturersName</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel manufacturer's name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.10.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30049">rdam:P30049</a>
    /// </summary>
    let P30049 = _prefixId.prefix "P30049"
    /// <summary>
    ///   <para>rdfs:label : has note on issue, part, or iteration used as the basis for identification of the resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on issue, part, or iteration used as the basis for identification of the resource</para>
    ///   <para>skos:definition : Relates a manifestation to a note identifying the issue or part of a multipart monograph or serial, or the iteration of an integrating resource that has been used as the basis for the identification of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.13^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note identifying the issue or part of a multipart monograph or serial, or the iteration of an integrating resource that has been used as the basis for the identification of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30050">rdam:P30050</a>
    /// </summary>
    let P30050 = _prefixId.prefix "P30050"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.21.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note on changes in the characteristics of the carrier that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnChangesInCarrierCharacteristics</para>
    ///   <para>rdfs:label : has note on changes in carrier characteristics</para>
    ///   <para>skos:definition : Relates a manifestation to a note on changes in the characteristics of the carrier that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on changes in carrier characteristics</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30051">rdam:P30051</a>
    /// </summary>
    let P30051 = _prefixId.prefix "P30051"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a note providing details on place of distribution, distributor, or date of distribution, or information on changes in the place of distribution, distributor, or distributor’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.8^^xsd:string</para>
    ///   <para>rdfs:label : has note on distribution statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDistributionStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing details on place of distribution, distributor, or date of distribution, or information on changes in the place of distribution, distributor, or distributor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on distribution statement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30052">rdam:P30052</a>
    /// </summary>
    let P30052 = _prefixId.prefix "P30052"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnManufactureStatement</para>
    ///   <para>rdfs:label : has note on manufacture statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on manufacture statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.9^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing details on place of manufacture, manufacturer, or date of manufacture, or information on changes in the place of manufacture, manufacturer, or manufacturer</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing details on place of manufacture, manufacturer, or date of manufacture, or information on changes in the place of manufacture, manufacturer, or manufacturer’s name.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30053">rdam:P30053</a>
    /// </summary>
    let P30053 = _prefixId.prefix "P30053"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.6^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing details on place of production, producer, or date of production, or information on changes in the place of production, producer, or producer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing details on place of production, producer, or date of production, or information on changes in the place of production, producer, or producer</para>
    ///   <para>rdfs:label : has note on production statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on production statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnProductionStatement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30054">rdam:P30054</a>
    /// </summary>
    let P30054 = _prefixId.prefix "P30054"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a note providing details on place of publication, publisher, or date of publication, information on changes in the place of publication, publisher, or publisher’s name, or on suspension of publication.</para>
    ///   <para>rdfs:label : has note on publication statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnPublicationStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing details on place of publication, publisher, or date of publication, information on changes in the place of publication, publisher, or publisher</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on publication statement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30055">rdam:P30055</a>
    /// </summary>
    let P30055 = _prefixId.prefix "P30055"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnFrequency</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing details on the currency of the contents, on the frequency of release of issues or parts of a serial or the frequency of updates to an integrating resource, or on changes in frequency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on frequency</para>
    ///   <para>rdfs:label : has note on frequency</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.12^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing details on the currency of the contents, on the frequency of release of issues or parts of a serial or the frequency of updates to an integrating resource, or on changes in frequency.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30056">rdam:P30056</a>
    /// </summary>
    let P30056 = _prefixId.prefix "P30056"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnStatementOfResponsibility</para>
    ///   <para>rdfs:label : has note on statement of responsibility</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on statement of responsibility</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on a person, family, or corporate body not named in a statement of responsibility to whom responsibility for the intellectual or artistic content of the resource has been attributed, on variant forms of names appearing in the resource, on changes in statements of responsibility, or on other details relating to a statement of responsibility.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on a person, family, or corporate body not named in a statement of responsibility to whom responsibility for the intellectual or artistic content of the resource has been attributed, on variant forms of names appearing in the resource, on changes in statements of responsibility, or on other details relating to a statement of responsibility.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30057">rdam:P30057</a>
    /// </summary>
    let P30057 = _prefixId.prefix "P30057"
    /// <summary>
    ///   <para>rdfs:label : has note on series statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on series statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnSeriesStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.11^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on complex series statements, incorrect numbering within series, or changes in series statements.</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on complex series statements, incorrect numbering within series, or changes in series statements.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30058">rdam:P30058</a>
    /// </summary>
    let P30058 = _prefixId.prefix "P30058"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on copyright dates not recorded as part of the copyright date element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.10^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on copyright date</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnCopyrightDate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on copyright dates not recorded as part of the copyright date element.</para>
    ///   <para>rdfs:label : has note on copyright date</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30059">rdam:P30059</a>
    /// </summary>
    let P30059 = _prefixId.prefix "P30059"
    /// <summary>
    ///   <para>rdfs:label : has note on dimensions of manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.21.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the dimensions of a manifestation that is not recorded as part of the dimensions element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDimensionsOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on dimensions of manifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on the dimensions of a manifestation that is not recorded as part of the dimensions element.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30060">rdam:P30060</a>
    /// </summary>
    let P30060 = _prefixId.prefix "P30060"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on the extent of a manifestation that is not recorded as part of the extent element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the extent of a manifestation that is not recorded as part of the extent element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on extent of manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnExtentOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.21.2^^xsd:string</para>
    ///   <para>rdfs:label : has note on extent of manifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30061">rdam:P30061</a>
    /// </summary>
    let P30061 = _prefixId.prefix "P30061"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on the numbering of the first and/or last issue or part, on complex or irregular numbering (including numbering errors), or on the period covered by a volume, issue, part, etc.</para>
    ///   <para>rdfs:label : has note on numbering of serials</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on numbering of serials</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnNumberingOfSerials</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the numbering of the first and/or last issue or part, on complex or irregular numbering (including numbering errors), or on the period covered by a volume, issue, part, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30062">rdam:P30062</a>
    /// </summary>
    let P30062 = _prefixId.prefix "P30062"
    /// <summary>
    ///   <para>rdfs:label : has note on title</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the source from which a title was taken, the date the title was viewed, variations in titles, inaccuracies, deletions, etc., or other information relating to a title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on title</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on the source from which a title was taken, the date the title was viewed, variations in titles, inaccuracies, deletions, etc., or other information relating to a title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnTitle</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.2^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30063">rdam:P30063</a>
    /// </summary>
    let P30063 = _prefixId.prefix "P30063"
    /// <summary>
    ///   <para>rdfs:label : has note on edition statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnEditionStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the source of an edition statement, on edition statements relating to issues, parts, etc., on changes in edition statements, or other information relating to an edition statement.</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on the source of an edition statement, on edition statements relating to issues, parts, etc., on changes in edition statements, or other information relating to an edition statement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on edition statement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30064">rdam:P30064</a>
    /// </summary>
    let P30064 = _prefixId.prefix "P30064"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a numbering designation assigned to a resource by a music publisher, appearing normally only on the title page, the cover, and/or the first page of music.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersNumberForMusic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A numbering designation assigned to a resource by a music publisher, appearing normally only on the title page, the cover, and/or the first page of music.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.15.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : publisher's number for music</para>
    ///   <para>rdfs:label : has publisher’s number for music</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30065">rdam:P30065</a>
    /// </summary>
    let P30065 = _prefixId.prefix "P30065"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a numbering designation assigned to a resource by a music publisher.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : plate number for music</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plateNumberForMusic</para>
    ///   <para>skos:scopeNote : The number is usually printed at the bottom of each page, and sometimes also appears on the title page.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.15.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A numbering designation assigned to a resource by a music publisher.</para>
    ///   <para>rdfs:label : has plate number for music</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30066">rdam:P30066</a>
    /// </summary>
    let P30066 = _prefixId.prefix "P30066"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in broadcasting a manifestation to an audience via radio, television, webcast, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : broadcaster</para>
    ///   <para>rdfs:label : has broadcaster</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in broadcasting a manifestation to an audience via radio, television, webcast, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcaster</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30067">rdam:P30067</a>
    /// </summary>
    let P30067 = _prefixId.prefix "P30067"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDistributor</para>
    ///   <para>rdfs:label : has film distributor</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in distributing a moving image manifestation to theatres or other distribution channels.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : film distributor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in distributing a moving image manifestation to theatres or other distribution channels.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30068">rdam:P30068</a>
    /// </summary>
    let P30068 = _prefixId.prefix "P30068"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookDesigner</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : book designer</para>
    ///   <para>rdfs:label : has book designer</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30069">rdam:P30069</a>
    /// </summary>
    let P30069 = _prefixId.prefix "P30069"
    /// <summary>
    ///   <para>rdfs:label : has engraver</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by cutting letters, figures, etc., on a surface such as a wooden or metal plate used for printing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : engraver</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : engraver</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by cutting letters, figures, etc., on a surface such as a wooden or metal plate used for printing.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30070">rdam:P30070</a>
    /// </summary>
    let P30070 = _prefixId.prefix "P30070"
    /// <summary>
    ///   <para>rdfs:label : has braille embosser</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : brailleEmbosser</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by embossing braille cells using a stylus, special embossing printer, or other device.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by embossing Braille cells using a stylus, special embossing printer, or other device.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : braille embosser</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30071">rdam:P30071</a>
    /// </summary>
    let P30071 = _prefixId.prefix "P30071"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printmaker</para>
    ///   <para>rdfs:label : has printmaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : printmaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by making a relief, intaglio, or planographic printing surface.</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by making a relief, intaglio, or planographic printing surface.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30072">rdam:P30072</a>
    /// </summary>
    let P30072 = _prefixId.prefix "P30072"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by pouring a liquid or molten substance into a mold and leaving it to solidify to take the shape of the mold.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : caster</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by pouring a liquid or molten substance into a mold and leaving it to solidify to take the shape of the mold.</para>
    ///   <para>rdfs:label : has caster</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : caster</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30073">rdam:P30073</a>
    /// </summary>
    let P30073 = _prefixId.prefix "P30073"
    /// <summary>
    ///   <para>rdfs:label : has lithographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : lithographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lithographer</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by preparing a stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by preparing a stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30074">rdam:P30074</a>
    /// </summary>
    let P30074 = _prefixId.prefix "P30074"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by preparing plates used in the production of printed images and/or text.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by preparing plates used in the production of printed images and/or text.</para>
    ///   <para>rdfs:label : has platemaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : platemaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : platemaker</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30075">rdam:P30075</a>
    /// </summary>
    let P30075 = _prefixId.prefix "P30075"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation by subjecting metal, glass, or some other surface used for printing, to acid or another corrosive substance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : etcher</para>
    ///   <para>rdfs:label : has etcher</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : etcher</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation by subjecting metal, glass, or some other surface used for printing, to acid or another corrosive substance.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30076">rdam:P30076</a>
    /// </summary>
    let P30076 = _prefixId.prefix "P30076"
    /// <summary>
    ///   <para>rdfs:label : has collotyper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : collotyper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation using a photomechanical process for making prints directly from a hardened film of gelatin or other colloid that has ink-receptive and ink-repellent surfaces.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collotyper</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation using a photomechanical process for making prints directly from a hardened film of gelatin or other colloid that has ink-receptive and ink-repellent surfaces.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30077">rdam:P30077</a>
    /// </summary>
    let P30077 = _prefixId.prefix "P30077"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : printer</para>
    ///   <para>rdfs:label : has printer</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30078">rdam:P30078</a>
    /// </summary>
    let P30078 = _prefixId.prefix "P30078"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPFCManifestation</para>
    ///   <para>skos:scopeNote : Includes book designers, platemakers, etc.</para>
    ///   <para>rdfs:label : has other person, family, or corporate body associated with a manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body other than a producer, publisher, distributor or manufacturer associated with a manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body other than a producer, publisher, distributor or manufacturer associated with a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 21.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other person, family, or corporate body associated with a manifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30079">rdam:P30079</a>
    /// </summary>
    let P30079 = _prefixId.prefix "P30079"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 21.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for distributing a resource.</para>
    ///   <para>rdfs:label : has distributor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : distributor</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body responsible for distributing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributor</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30080">rdam:P30080</a>
    /// </summary>
    let P30080 = _prefixId.prefix "P30080"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerOfAnUnpublishedResource</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 21.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : producer of an unpublished resource</para>
    ///   <para>rdfs:label : has producer of an unpublished resource</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30081">rdam:P30081</a>
    /// </summary>
    let P30081 = _prefixId.prefix "P30081"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : manufacturer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 21.5^^xsd:string</para>
    ///   <para>rdfs:label : has manufacturer</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30082">rdam:P30082</a>
    /// </summary>
    let P30082 = _prefixId.prefix "P30082"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>rdfs:label : has publisher</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : publisher</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publisher</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 21.3^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30083">rdam:P30083</a>
    /// </summary>
    let P30083 = _prefixId.prefix "P30083"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appliedMaterial</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A physical or chemical substance applied to a base material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.7^^xsd:string</para>
    ///   <para>rdfs:label : has applied material</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : applied material</para>
    ///   <para>skos:definition : Relates a manifestation to a physical or chemical substance applied to a base material of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30084">rdam:P30084</a>
    /// </summary>
    let P30084 = _prefixId.prefix "P30084"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a place associated with the distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place associated with the distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.9.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of distribution</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDistribution</para>
    ///   <para>rdfs:label : has place of distribution</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30085">rdam:P30085</a>
    /// </summary>
    let P30085 = _prefixId.prefix "P30085"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of production</para>
    ///   <para>rdfs:label : has place of production</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfProduction</para>
    ///   <para>skos:definition : Relates a manifestation to a place associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.7.2^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30086">rdam:P30086</a>
    /// </summary>
    let P30086 = _prefixId.prefix "P30086"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of manufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfManufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>rdfs:label : has place of manufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.10.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a place associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30087">rdam:P30087</a>
    /// </summary>
    let P30087 = _prefixId.prefix "P30087"
    /// <summary>
    ///   <para>rdfs:label : has place of publication</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfPublication</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.8.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of publication</para>
    ///   <para>skos:definition : Relates a manifestation to a place associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place associated with the publication, release, or issuing of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30088">rdam:P30088</a>
    /// </summary>
    let P30088 = _prefixId.prefix "P30088"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.9.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel place of distribution</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfDistribution</para>
    ///   <para>rdfs:label : has parallel place of distribution</para>
    ///   <para>skos:definition : Relates a manifestation to a place of distribution in a language and/or script that differs from that recorded in the place of distribution element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place of distribution in a language and/or script that differs from that recorded in the place of distribution element.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30089">rdam:P30089</a>
    /// </summary>
    let P30089 = _prefixId.prefix "P30089"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel place of manufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.10.3^^xsd:string</para>
    ///   <para>rdfs:label : has parallel place of manufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfManufacture</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place of manufacture in a language and/or script that differs from that recorded in the place of manufacture element.</para>
    ///   <para>skos:definition : Relates a manifestation to a place of manufacture in a language and/or script that differs from that recorded in the place of manufacture element.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30090">rdam:P30090</a>
    /// </summary>
    let P30090 = _prefixId.prefix "P30090"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place of production in a language and/or script that differs from that recorded in the place of production element.</para>
    ///   <para>skos:definition : Relates a manifestation to a place of production in a language and/or script that differs from that recorded in the place of production element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel place of production</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfProduction</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.7.3^^xsd:string</para>
    ///   <para>rdfs:label : has parallel place of production</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30091">rdam:P30091</a>
    /// </summary>
    let P30091 = _prefixId.prefix "P30091"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel place of publication</para>
    ///   <para>skos:definition : Relates a manifestation to a place of publication in a language and/or script that differs from that recorded in the place of publication element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.8.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place of publication in a language and/or script that differs from that recorded in the place of publication element.</para>
    ///   <para>rdfs:label : has parallel place of publication</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfPublication</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30092">rdam:P30092</a>
    /// </summary>
    let P30092 = _prefixId.prefix "P30092"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A printed manifestation that is used as the basis for a reissue of a manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to a printed manifestation that is used as the basis for a reissue of a manifestation.</para>
    ///   <para>rdfs:label : is reprint of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reprint of (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30093">rdam:P30093</a>
    /// </summary>
    let P30093 = _prefixId.prefix "P30093"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.7.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel producer's name</para>
    ///   <para>rdfs:label : has parallel producer’s name</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelProducersName</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A producer</para>
    ///   <para>skos:definition : Relates a manifestation to a producer's name in a language and/or script that differs from that recorded in the producer's name element.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30094">rdam:P30094</a>
    /// </summary>
    let P30094 = _prefixId.prefix "P30094"
    /// <summary>
    ///   <para>rdfs:label : has parallel publisher’s name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel publisher's name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A publisher</para>
    ///   <para>skos:definition : Relates a manifestation to a publisher's name in a language and/or script that differs from that recorded in the publisher's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPublishersName</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.8.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30095">rdam:P30095</a>
    /// </summary>
    let P30095 = _prefixId.prefix "P30095"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : encodingFormat</para>
    ///   <para>skos:definition : Relates a manifestation to a schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : encoding format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.3^^xsd:string</para>
    ///   <para>rdfs:label : has encoding format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30096">rdam:P30096</a>
    /// </summary>
    let P30096 = _prefixId.prefix "P30096"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has alternative numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : alternative numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A second or subsequent system of numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>skos:definition : Relates a manifestation to a second or subsequent system of numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.6^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30097">rdam:P30097</a>
    /// </summary>
    let P30097 = _prefixId.prefix "P30097"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.8^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a second or subsequent system of numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>rdfs:label : has alternative numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : alternative numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A second or subsequent system of numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30098">rdam:P30098</a>
    /// </summary>
    let P30098 = _prefixId.prefix "P30098"
    /// <summary>
    ///   <para>rdfs:label : has alternative chronological designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : alternative chronological designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>skos:definition : Relates a manifestation to a second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.7^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30099">rdam:P30099</a>
    /// </summary>
    let P30099 = _prefixId.prefix "P30099"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>skos:definition : Relates a manifestation to a second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>rdfs:label : has alternative chronological designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : alternative chronological designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.9^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30100">rdam:P30100</a>
    /// </summary>
    let P30100 = _prefixId.prefix "P30100"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : special issue of</para>
    ///   <para>skos:definition : Relates a manifestation to a serial or newspaper containing a single issue or a supplementary section devoted to a special subject, with or without serial numbering, such as an anniversary number of a periodical or newspaper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A serial or newspaper containing a single issue or a supplementary section devoted to a special subject, with or without serial numbering, such as an anniversary number of a periodical or newspaper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssueOf</para>
    ///   <para>rdfs:label : is special issue of</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30101">rdam:P30101</a>
    /// </summary>
    let P30101 = _prefixId.prefix "P30101"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A set of technical details relating to the encoding of geospatial information in a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalRepresentationOfCartographicContent</para>
    ///   <para>rdfs:label : has digital representation of cartographic content</para>
    ///   <para>skos:definition : Relates a manifestation to a set of technical details relating to the encoding of geospatial information in a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digital representation of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30102">rdam:P30102</a>
    /// </summary>
    let P30102 = _prefixId.prefix "P30102"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : exemplar of manifestation</para>
    ///   <para>rdfs:label : has exemplar of manifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a single exemplar or instance of a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : exemplarOfManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A single exemplar or instance of a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 17.11^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30103">rdam:P30103</a>
    /// </summary>
    let P30103 = _prefixId.prefix "P30103"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>rdfs:label : has video format</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoFormat</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.18.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video format</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30104">rdam:P30104</a>
    /// </summary>
    let P30104 = _prefixId.prefix "P30104"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a statement associated with the title proper of a resource that relates to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : statement of responsibility relating to title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.4.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToTitleProper</para>
    ///   <para>rdfs:label : has statement of responsibility relating to title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement associated with the title proper of a resource that relates to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30105">rdam:P30105</a>
    /// </summary>
    let P30105 = _prefixId.prefix "P30105"
    /// <summary>
    ///   <para>skos:scopeNote : A series statement may also include information identifying one or more subseries to which the resource being described belongs. Series statements sometimes include statements of responsibility relating to a series or subseries.</para>
    ///   <para>rdfs:label : has series statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement identifying a series to which a resource belongs and the numbering of the resource within the series.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement identifying a series to which a resource belongs and the numbering of the resource within the series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : series statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30106">rdam:P30106</a>
    /// </summary>
    let P30106 = _prefixId.prefix "P30106"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a statement identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editionStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5^^xsd:string</para>
    ///   <para>rdfs:label : has edition statement</para>
    ///   <para>skos:scopeNote : An edition statement sometimes includes a designation of a named revision of an edition. An edition statement sometimes includes a statement or statements of responsibility relating to the edition and/or to a named revision of an edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : edition statement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30107">rdam:P30107</a>
    /// </summary>
    let P30107 = _prefixId.prefix "P30107"
    /// <summary>
    ///   <para>rdfs:label : has distribution statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement identifying the place or places of distribution, distributor or distributors, and date or dates of distribution of a resource in a published form.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement identifying the place or places of distribution, distributor or distributors, and date or dates of distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributionStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : distribution statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.9^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30108">rdam:P30108</a>
    /// </summary>
    let P30108 = _prefixId.prefix "P30108"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : manufacture statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement identifying the place or places of manufacture, manufacturer or manufacturers, and date or dates of manufacture of a resource in a published form.</para>
    ///   <para>rdfs:label : has manufacture statement</para>
    ///   <para>skos:scopeNote : Manufacture statements include statements relating to the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.1^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a statement identifying the place or places of manufacture, manufacturer or manufacturers, and date or dates of manufacture of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufactureStatement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30109">rdam:P30109</a>
    /// </summary>
    let P30109 = _prefixId.prefix "P30109"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : production statement</para>
    ///   <para>rdfs:label : has production statement</para>
    ///   <para>skos:scopeNote : Production statements include statements relating to the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement identifying the place or places of production, producer or producers, and date or dates of production of a resource in an unpublished form.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement identifying the place or places of production, producer or producers, and date or dates of production of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionStatement</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30110">rdam:P30110</a>
    /// </summary>
    let P30110 = _prefixId.prefix "P30110"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement identifying the place or places of publication, publisher or publishers, and date or dates of publication of a resource.</para>
    ///   <para>skos:scopeNote : Publication statements include statements relating to the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publicationStatement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : publication statement</para>
    ///   <para>rdfs:label : has publication statement</para>
    ///   <para>skos:definition : Relates a manifestation to a statement identifying the place or places of publication, publisher or publishers, and date or dates of publication of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30111">rdam:P30111</a>
    /// </summary>
    let P30111 = _prefixId.prefix "P30111"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.9^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a statement of responsibility relating to a named revision of an edition in a language and/or script that differs from that recorded in the statement of responsibility relating to a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel statement of responsibility relating to a named revision of an edition</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to a named revision of an edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement of responsibility relating to a named revision of an edition in a language and/or script that differs from that recorded in the statement of responsibility relating to a named revision of an edition element.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30112">rdam:P30112</a>
    /// </summary>
    let P30112 = _prefixId.prefix "P30112"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a statement of responsibility relating to series in a language and/or script that differs from that recorded in the statement of responsibility relating to series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel statement of responsibility relating to series</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement of responsibility relating to series in a language and/or script that differs from that recorded in the statement of responsibility relating to series element.</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to series</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSeries</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30113">rdam:P30113</a>
    /// </summary>
    let P30113 = _prefixId.prefix "P30113"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSubseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement of responsibility relating to subseries in a language and/or script that differs from that recorded in the statement of responsibility relating to subseries element.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement of responsibility relating to subseries in a language and/or script that differs from that recorded in the statement of responsibility relating to subseries element.</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel statement of responsibility relating to subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.15^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30114">rdam:P30114</a>
    /// </summary>
    let P30114 = _prefixId.prefix "P30114"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTheEdition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel statement of responsibility relating to the edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement of responsibility relating to the edition in a language and/or script that differs from that recorded in the statement of responsibility relating to the edition element.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement of responsibility relating to the edition in a language and/or script that differs from that recorded in the statement of responsibility relating to the edition element.</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to the edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30115">rdam:P30115</a>
    /// </summary>
    let P30115 = _prefixId.prefix "P30115"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.4.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement of responsibility relating to title proper in a language and/or script that differs from that recorded in the statement of responsibility relating to title proper element.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement of responsibility relating to title proper in a language and/or script that differs from that recorded in the statement of responsibility relating to title proper element.</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTitleProper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel statement of responsibility relating to title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30116">rdam:P30116</a>
    /// </summary>
    let P30116 = _prefixId.prefix "P30116"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibility</para>
    ///   <para>skos:scopeNote : A statement of responsibility sometimes includes words or phrases that are neither names nor linking words.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement relating to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of a resource.</para>
    ///   <para>rdfs:label : has statement of responsibility</para>
    ///   <para>skos:definition : Relates a manifestation to a statement relating to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : statement of responsibility</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30117">rdam:P30117</a>
    /// </summary>
    let P30117 = _prefixId.prefix "P30117"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : statement of responsibility relating to a named revision of an edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    ///   <para>skos:definition : Relates a manifestation to a statement relating to the identification of any persons, families, or corporate bodies responsible for a named revision of an edition.</para>
    ///   <para>rdfs:label : has statement of responsibility relating to a named revision of an edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a named revision of an edition.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30118">rdam:P30118</a>
    /// </summary>
    let P30118 = _prefixId.prefix "P30118"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.6^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a statement relating to the identification of any persons, families, or corporate bodies responsible for a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSeries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : statement of responsibility relating to series</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a series.</para>
    ///   <para>rdfs:label : has statement of responsibility relating to series</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30119">rdam:P30119</a>
    /// </summary>
    let P30119 = _prefixId.prefix "P30119"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a subseries.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement relating to the identification of any persons, families, or corporate bodies responsible for a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSubseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.14^^xsd:string</para>
    ///   <para>rdfs:label : has statement of responsibility relating to subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : statement of responsibility relating to subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30120">rdam:P30120</a>
    /// </summary>
    let P30120 = _prefixId.prefix "P30120"
    /// <summary>
    ///   <para>rdfs:label : has statement of responsibility relating to the edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a statement relating to the identification of any persons, families, or corporate bodies responsible for the edition being described but not to all editions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToTheEdition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A statement relating to the identification of any persons, families, or corporate bodies responsible for the edition being described but not to all editions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : statement of responsibility relating to the edition</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30121">rdam:P30121</a>
    /// </summary>
    let P30121 = _prefixId.prefix "P30121"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.7.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : emulsion on microfilm and microfiche</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : emulsionOnMicrofilmAndMicrofiche</para>
    ///   <para>rdfs:label : has emulsion on microfilm and microfiche</para>
    ///   <para>skos:definition : Relates a manifestation to a suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30122">rdam:P30122</a>
    /// </summary>
    let P30122 = _prefixId.prefix "P30122"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcastStandard</para>
    ///   <para>rdfs:label : has broadcast standard</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : broadcast standard</para>
    ///   <para>skos:definition : Relates a manifestation to a system used to format a video resource for television broadcast.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.18.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A system used to format a video resource for television broadcast.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30123">rdam:P30123</a>
    /// </summary>
    let P30123 = _prefixId.prefix "P30123"
    /// <summary>
    ///   <para>rdfs:label : has digital file characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digital file characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalFileCharacteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>skos:definition : Relates a manifestation to a technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30124">rdam:P30124</a>
    /// </summary>
    let P30124 = _prefixId.prefix "P30124"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a technical specification relating to the encoding of sound in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sound characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundCharacteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A technical specification relating to the encoding of sound in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16^^xsd:string</para>
    ///   <para>rdfs:label : has sound characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30125">rdam:P30125</a>
    /// </summary>
    let P30125 = _prefixId.prefix "P30125"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.18^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoCharacteristic</para>
    ///   <para>rdfs:label : has video characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A technical specification relating to the encoding of video images in a resource.</para>
    ///   <para>skos:definition : Relates a manifestation to a technical specification relating to the encoding of video images in a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30126">rdam:P30126</a>
    /// </summary>
    let P30126 = _prefixId.prefix "P30126"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : projection characteristic of motion picture film</para>
    ///   <para>rdfs:label : has projection characteristic of motion picture film</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.17^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a technical specification relating to the projection of a motion picture film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A technical specification relating to the projection of a motion picture film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionCharacteristicOfMotionPictureFilm</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30127">rdam:P30127</a>
    /// </summary>
    let P30127 = _prefixId.prefix "P30127"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A title associated with a resource that differs from a title recorded as the title proper, a parallel title proper, other title information, parallel other title information, earlier title proper, later title proper, key title, or abbreviated title.</para>
    ///   <para>skos:definition : Relates a manifestation to a title associated with a resource that differs from a title recorded as the title proper, a parallel title proper, other title information, parallel other title information, earlier title proper, later title proper, key title, or abbreviated title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTitle</para>
    ///   <para>rdfs:label : has variant title</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : variant title</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30128">rdam:P30128</a>
    /// </summary>
    let P30128 = _prefixId.prefix "P30128"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.8^^xsd:string</para>
    ///   <para>rdfs:label : has later title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : laterTitleProper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A title proper appearing on a later issue or part of a multipart monograph or serial that differs from that on the first or earliest issue or part.</para>
    ///   <para>skos:definition : Relates a manifestation to a title proper appearing on a later issue or part of a multipart monograph or serial that differs from that on the first or earliest issue or part.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : later title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30129">rdam:P30129</a>
    /// </summary>
    let P30129 = _prefixId.prefix "P30129"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : earlier title proper</para>
    ///   <para>rdfs:label : has earlier title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A title proper appearing on an earlier iteration of an integrating resource that differs from that on the current iteration.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : earlierTitleProper</para>
    ///   <para>skos:definition : Relates a manifestation to a title proper appearing on an earlier iteration of an integrating resource that differs from that on the current iteration.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30130">rdam:P30130</a>
    /// </summary>
    let P30130 = _prefixId.prefix "P30130"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.10^^xsd:string</para>
    ///   <para>rdfs:label : has abbreviated title</para>
    ///   <para>skos:definition : Relates a manifestation to a title that has been abbreviated for purposes of indexing or identification.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A title that has been abbreviated for purposes of indexing or identification.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abbreviated title</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abbreviatedTitle</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30131">rdam:P30131</a>
    /// </summary>
    let P30131 = _prefixId.prefix "P30131"
    /// <summary>
    ///   <para>rdfs:label : has designation of a named revision of an edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character, or group of words and/or characters, identifying a particular revision of a named edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.6^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a word, character, or group of words and/or characters, identifying a particular revision of a named edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfANamedRevisionOfAnEdition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : designation of a named revision of an edition</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30132">rdam:P30132</a>
    /// </summary>
    let P30132 = _prefixId.prefix "P30132"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.5.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a word, character or group of words and/or characters, identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character or group of words and/or characters, identifying the edition to which a resource belongs.</para>
    ///   <para>rdfs:label : has designation of edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : designation of edition</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfEdition</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30133">rdam:P30133</a>
    /// </summary>
    let P30133 = _prefixId.prefix "P30133"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : title</para>
    ///   <para>rdfs:label : has title</para>
    ///   <para>skos:definition : Relates a manifestation to a word, character, or group of words and/or characters that names a resource or a work contained in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character, or group of words and/or characters that names a resource or a work contained in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : title</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30134">rdam:P30134</a>
    /// </summary>
    let P30134 = _prefixId.prefix "P30134"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : work manifested</para>
    ///   <para>rdfs:label : has work manifested</para>
    ///   <para>skos:definition : Relates a manifestation to a work embodied in a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work embodied in a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 17.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : workManifested</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30135">rdam:P30135</a>
    /// </summary>
    let P30135 = _prefixId.prefix "P30135"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation in an analog format that is transferred to a digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionOfManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation in an analog format that is transferred to a digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : electronic reproduction of (manifestation)</para>
    ///   <para>rdfs:label : is electronic reproduction of (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30136">rdam:P30136</a>
    /// </summary>
    let P30136 = _prefixId.prefix "P30136"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to an annotation providing additional information about manifestation attributes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An annotation providing additional information about manifestation attributes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.17^^xsd:string</para>
    ///   <para>rdfs:label : has note on manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on manifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30137">rdam:P30137</a>
    /// </summary>
    let P30137 = _prefixId.prefix "P30137"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialPlaybackCharacteristic</para>
    ///   <para>rdfs:label : has special playback characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.9^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : special playback characteristic</para>
    ///   <para>skos:definition : Relates a manifestation to an equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30138">rdam:P30138</a>
    /// </summary>
    let P30138 = _prefixId.prefix "P30138"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression embodied in a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 17.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : expression manifested</para>
    ///   <para>skos:definition : Relates a manifestation to an expression embodied in a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expressionManifested</para>
    ///   <para>rdfs:label : has expression manifested</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30139">rdam:P30139</a>
    /// </summary>
    let P30139 = _prefixId.prefix "P30139"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 28.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item, represented by an identifier or a description, that is related to the manifestation being described (e.g., an item used as the basis for a microform reproduction).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related item</para>
    ///   <para>skos:definition : Relates a manifestation to an item, represented by an identifier or a description, that is related to the manifestation being described (e.g., an item used as the basis for a microform reproduction).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedItem</para>
    ///   <para>rdfs:label : has related item</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30140">rdam:P30140</a>
    /// </summary>
    let P30140 = _prefixId.prefix "P30140"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contactInformation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information about an organization, etc., from which a resource may be obtained.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : contact information</para>
    ///   <para>rdfs:label : has contact information</para>
    ///   <para>skos:definition : Relates a manifestation to information about an organization, etc., from which a resource may be obtained.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30141">rdam:P30141</a>
    /// </summary>
    let P30141 = _prefixId.prefix "P30141"
    /// <summary>
    ///   <para>rdfs:label : has other title information</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information that appears in conjunction with, and is subordinate to, the title proper of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other title information</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformation</para>
    ///   <para>skos:definition : Relates a manifestation to information that appears in conjunction with, and is subordinate to, the title proper of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30142">rdam:P30142</a>
    /// </summary>
    let P30142 = _prefixId.prefix "P30142"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSeries</para>
    ///   <para>rdfs:label : has other title information of series</para>
    ///   <para>skos:definition : Relates a manifestation to information that appears in conjunction with, and is subordinate to, the title proper of a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other title information of series</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information that appears in conjunction with, and is subordinate to, the title proper of a series.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30143">rdam:P30143</a>
    /// </summary>
    let P30143 = _prefixId.prefix "P30143"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other title information of subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information that appears in conjunction with, and is subordinate to, the title proper of a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.12^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSubseries</para>
    ///   <para>skos:definition : Relates a manifestation to information that appears in conjunction with, and is subordinate to, the title proper of a subseries.</para>
    ///   <para>rdfs:label : has other title information of subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30144">rdam:P30144</a>
    /// </summary>
    let P30144 = _prefixId.prefix "P30144"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to limitations placed on access to a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnAccessToManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Limitations placed on access to a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : restrictions on access</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.4^^xsd:string</para>
    ///   <para>rdfs:label : has restrictions on access to manifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30145">rdam:P30145</a>
    /// </summary>
    let P30145 = _prefixId.prefix "P30145"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.5^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnUseOfManifestation</para>
    ///   <para>rdfs:label : has restrictions on use of manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : restrictions on use</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30146">rdam:P30146</a>
    /// </summary>
    let P30146 = _prefixId.prefix "P30146"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <para>rdfs:label : has numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30147">rdam:P30147</a>
    /// </summary>
    let P30147 = _prefixId.prefix "P30147"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>rdfs:label : has numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <para>skos:definition : Relates a manifestation to numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30148">rdam:P30148</a>
    /// </summary>
    let P30148 = _prefixId.prefix "P30148"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : chronological designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.3^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>rdfs:label : has chronological designation of first issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30149">rdam:P30149</a>
    /// </summary>
    let P30149 = _prefixId.prefix "P30149"
    /// <summary>
    ///   <para>rdfs:label : has chronological designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : chronological designation of last issue or part of sequence</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>skos:definition : Relates a manifestation to numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30150">rdam:P30150</a>
    /// </summary>
    let P30150 = _prefixId.prefix "P30150"
    /// <summary>
    ///   <para>rdfs:label : has parallel other title information</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel other title information</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.5^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to other title information in a language and/or script that differs from that recorded in the other title information element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Other title information in a language and/or script that differs from that recorded in the other title information element.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30151">rdam:P30151</a>
    /// </summary>
    let P30151 = _prefixId.prefix "P30151"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to other title information of a series in a language and/or script that differs from that recorded in the other title information of series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Other title information of a series in a language and/or script that differs from that recorded in the other title information of series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel other title information of series</para>
    ///   <para>rdfs:label : has parallel other title information of series</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSeries</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30152">rdam:P30152</a>
    /// </summary>
    let P30152 = _prefixId.prefix "P30152"
    /// <summary>
    ///   <para>rdfs:label : has parallel other title information of subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Other title information of a subseries in a language and/or script that differs from that recorded in the other title information of subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.13^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel other title information of subseries</para>
    ///   <para>skos:definition : Relates a manifestation to other title information of a subseries in a language and/or script that differs from that recorded in the other title information of subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSubseries</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30153">rdam:P30153</a>
    /// </summary>
    let P30153 = _prefixId.prefix "P30153"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : Uniform Resource Locator</para>
    ///   <para>skos:definition : Relates a manifestation to the address of a remote access resource.</para>
    ///   <para>rdfs:label : has uniform resource locator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : uniformResourceLocator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The address of a remote access resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30154">rdam:P30154</a>
    /// </summary>
    let P30154 = _prefixId.prefix "P30154"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The arrangement of text, images, tactile notation, etc., in a resource.</para>
    ///   <para>rdfs:label : has layout</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : layout</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.11^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layout</para>
    ///   <para>skos:definition : Relates a manifestation to the arrangement of text, images, tactile notation, etc., in a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30155">rdam:P30155</a>
    /// </summary>
    let P30155 = _prefixId.prefix "P30155"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The chief name of a resource (i.e., the title normally used when citing the resource).</para>
    ///   <para>skos:definition : Relates a manifestation to the chief name of a resource (i.e., the title normally used when citing the resource).</para>
    ///   <para>rdfs:label : has title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.2^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30156">rdam:P30156</a>
    /// </summary>
    let P30156 = _prefixId.prefix "P30156"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSeries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : title proper of series</para>
    ///   <para>rdfs:label : has title proper of series</para>
    ///   <para>skos:definition : Relates a manifestation to the chief name of a series (i.e., the title normally used when citing the series).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The chief name of a series (i.e., the title normally used when citing the series).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30157">rdam:P30157</a>
    /// </summary>
    let P30157 = _prefixId.prefix "P30157"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.10^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the chief name of a subseries (i.e., the title normally used when citing the subseries).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : title proper of subseries</para>
    ///   <para>rdfs:label : has title proper of subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The chief name of a subseries (i.e., the title normally used when citing the subseries).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSubseries</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30158">rdam:P30158</a>
    /// </summary>
    let P30158 = _prefixId.prefix "P30158"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.5^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the clarity or fineness of detail in a digital image, expressed by the measurement of the image in pixels, etc.</para>
    ///   <para>rdfs:label : has resolution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : resolution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The clarity or fineness of detail in a digital image, expressed by the measurement of the image in pixels, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : resolution</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30159">rdam:P30159</a>
    /// </summary>
    let P30159 = _prefixId.prefix "P30159"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : terms of availability</para>
    ///   <para>skos:definition : Relates a manifestation to the conditions under which the publisher, distributor, etc., will normally supply a resource or the price of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The conditions under which the publisher, distributor, etc., will normally supply a resource or the price of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : termsOfAvailability</para>
    ///   <para>rdfs:label : has terms of availability</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30160">rdam:P30160</a>
    /// </summary>
    let P30160 = _prefixId.prefix "P30160"
    /// <summary>
    ///   <para>rdfs:label : has track configuration</para>
    ///   <para>skos:definition : Relates a manifestation to the configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : trackConfiguration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : track configuration</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30161">rdam:P30161</a>
    /// </summary>
    let P30161 = _prefixId.prefix "P30161"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equipmentOrSystemRequirement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : equipment or system requirement</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The equipment or system required for use, playback, etc., of an analog, digital, etc., resource.</para>
    ///   <para>rdfs:label : has equipment or system requirement</para>
    ///   <para>skos:definition : Relates a manifestation to the equipment or system required for use, playback, etc., of an analog, digital, etc., resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30162">rdam:P30162</a>
    /// </summary>
    let P30162 = _prefixId.prefix "P30162"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The format used in the production of a projected image (e.g., Cinerama, IMAX).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presentationFormat</para>
    ///   <para>rdfs:label : has presentation format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.17.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the format used in the production of a projected image (e.g., Cinerama, IMAX).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : presentation format</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30163">rdam:P30163</a>
    /// </summary>
    let P30163 = _prefixId.prefix "P30163"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grooveCharacteristic</para>
    ///   <para>rdfs:label : has groove characteristic</para>
    ///   <para>skos:definition : Relates a manifestation to the groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : groove characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30164">rdam:P30164</a>
    /// </summary>
    let P30164 = _prefixId.prefix "P30164"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numbering of serials</para>
    ///   <para>skos:definition : Relates a manifestation to the identification of each of the issues or parts of a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The identification of each of the issues or parts of a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfSerials</para>
    ///   <para>rdfs:label : has numbering of serials</para>
    ///   <para>skos:scopeNote : Numbering of serials may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30165">rdam:P30165</a>
    /// </summary>
    let P30165 = _prefixId.prefix "P30165"
    /// <summary>
    ///   <para>rdfs:label : has ISSN of series</para>
    ///   <para>skos:definition : Relates a manifestation to the identifier assigned to a series by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSeries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : ISSN of series</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The identifier assigned to a series by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.8^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30166">rdam:P30166</a>
    /// </summary>
    let P30166 = _prefixId.prefix "P30166"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.16^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSubseries</para>
    ///   <para>skos:definition : Relates a manifestation to the identifier assigned to a subseries by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : ISSN of subseries</para>
    ///   <para>rdfs:label : has ISSN of subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The identifier assigned to a subseries by an ISSN registration agency.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30167">rdam:P30167</a>
    /// </summary>
    let P30167 = _prefixId.prefix "P30167"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the intervals at which the issues or parts of a serial or the updates to an integrating resource are issued.</para>
    ///   <para>rdfs:label : has frequency</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The intervals at which the issues or parts of a serial or the updates to an integrating resource are issued.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : frequency</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : frequency</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.14^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30168">rdam:P30168</a>
    /// </summary>
    let P30168 = _prefixId.prefix "P30168"
    /// <summary>
    ///   <para>rdfs:label : has dimensions</para>
    ///   <para>skos:definition : Relates a manifestation to the measurements of the carrier or carriers and/or the container of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensions</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dimensions</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The measurements of the carrier or carriers and/or the container of a resource.</para>
    ///   <para>skos:scopeNote : Dimensions include measurements of height, width, depth, length, gauge, and diameter.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30169">rdam:P30169</a>
    /// </summary>
    let P30169 = _prefixId.prefix "P30169"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the measurements of the face of a map, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The measurements of the face of a map, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dimensions of map, etc.</para>
    ///   <para>rdfs:label : has dimensions of map, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.5.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfMapEtc</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30170">rdam:P30170</a>
    /// </summary>
    let P30170 = _prefixId.prefix "P30170"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfStillImage</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.5.3^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the measurements of the pictorial area of a still image.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The measurements of the pictorial area of a still image.</para>
    ///   <para>rdfs:label : has dimensions of still image</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dimensions of still image</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30171">rdam:P30171</a>
    /// </summary>
    let P30171 = _prefixId.prefix "P30171"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfRecording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : type of recording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the method used to encode audio content for playback (e.g., analog or digital).</para>
    ///   <para>rdfs:label : has type of recording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The method used to encode audio content for playback (e.g., analog or digital).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30172">rdam:P30172</a>
    /// </summary>
    let P30172 = _prefixId.prefix "P30172"
    /// <summary>
    ///   <para>rdfs:label : has distributor’s name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : distributor's name</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorsName</para>
    ///   <para>skos:definition : Relates a manifestation to the name of a person, family, or corporate body responsible for distributing a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.9.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name of a person, family, or corporate body responsible for distributing a resource in a published form.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30173">rdam:P30173</a>
    /// </summary>
    let P30173 = _prefixId.prefix "P30173"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the name of a person, family, or corporate body responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : producer's name</para>
    ///   <para>rdfs:label : has producer’s name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name of a person, family, or corporate body responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producersName</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.7.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30174">rdam:P30174</a>
    /// </summary>
    let P30174 = _prefixId.prefix "P30174"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.10.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : manufacturer's name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name of a person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>skos:definition : Relates a manifestation to the name of a person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>rdfs:label : has manufacturer’s name</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturersName</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30175">rdam:P30175</a>
    /// </summary>
    let P30175 = _prefixId.prefix "P30175"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the name of a person, family, or corporate body responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.8.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : publisher's name</para>
    ///   <para>rdfs:label : has publisher’s name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name of a person, family, or corporate body responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersName</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30176">rdam:P30176</a>
    /// </summary>
    let P30176 = _prefixId.prefix "P30176"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : extent of cartographic resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.4.2^^xsd:string</para>
    ///   <para>rdfs:label : has extent of cartographic resource</para>
    ///   <para>skos:definition : Relates a manifestation to the number and type of units and/or subunits making up a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfCartographicResource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number and type of units and/or subunits making up a cartographic resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30177">rdam:P30177</a>
    /// </summary>
    let P30177 = _prefixId.prefix "P30177"
    /// <summary>
    ///   <para>rdfs:label : has extent of notated music</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfNotatedMusic</para>
    ///   <para>skos:definition : Relates a manifestation to the number and type of units and/or subunits making up a resource consisting of notated music, with or without accompanying text and/or illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.4.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : extent of notated music</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number and type of units and/or subunits making up a resource consisting of notated music, with or without accompanying text and/or illustrations.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30178">rdam:P30178</a>
    /// </summary>
    let P30178 = _prefixId.prefix "P30178"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the number and type of units and/or subunits making up a resource consisting of one or more still images.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number and type of units and/or subunits making up a resource consisting of one or more still images.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfStillImage</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : extent of still image</para>
    ///   <para>rdfs:label : has extent of still image</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.4.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30179">rdam:P30179</a>
    /// </summary>
    let P30179 = _prefixId.prefix "P30179"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : extent of three-dimensional form</para>
    ///   <para>rdfs:label : has extent of three-dimensional form</para>
    ///   <para>skos:definition : Relates a manifestation to the number and type of units and/or subunits making up a resource consisting of one or more three-dimensional forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.4.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfThreeDimensionalForm</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number and type of units and/or subunits making up a resource consisting of one or more three-dimensional forms.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30180">rdam:P30180</a>
    /// </summary>
    let P30180 = _prefixId.prefix "P30180"
    /// <summary>
    ///   <para>rdfs:label : has extent of text</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfText</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : extent of text</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number and type of units and/or subunits making up a resource consisting of text, with or without accompanying illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.4.5^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the number and type of units and/or subunits making up a resource consisting of text, with or without accompanying illustrations.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30181">rdam:P30181</a>
    /// </summary>
    let P30181 = _prefixId.prefix "P30181"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.4^^xsd:string</para>
    ///   <para>rdfs:label : has extent</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : extent</para>
    ///   <para>skos:definition : Relates a manifestation to the number and type of units and/or subunits making up a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extent</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number and type of units and/or subunits making up a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30182">rdam:P30182</a>
    /// </summary>
    let P30182 = _prefixId.prefix "P30182"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the number of bytes in a digital file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : file size</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileSize</para>
    ///   <para>rdfs:label : has file size</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number of bytes in a digital file.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30183">rdam:P30183</a>
    /// </summary>
    let P30183 = _prefixId.prefix "P30183"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : configurationOfPlaybackChannels</para>
    ///   <para>skos:definition : Relates a manifestation to the number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>rdfs:label : has configuration of playback channels</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : configuration of playback channels</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30184">rdam:P30184</a>
    /// </summary>
    let P30184 = _prefixId.prefix "P30184"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : tapeConfiguration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : tape configuration</para>
    ///   <para>skos:definition : Relates a manifestation to the number of tracks on an audiotape.</para>
    ///   <para>rdfs:label : has tape configuration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The number of tracks on an audiotape.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30185">rdam:P30185</a>
    /// </summary>
    let P30185 = _prefixId.prefix "P30185"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mount</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>rdfs:label : has mount</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : mount</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30186">rdam:P30186</a>
    /// </summary>
    let P30186 = _prefixId.prefix "P30186"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the process used to produce a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.9^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethod</para>
    ///   <para>rdfs:label : has production method</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : production method</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The process used to produce a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30187">rdam:P30187</a>
    /// </summary>
    let P30187 = _prefixId.prefix "P30187"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForTactileResource</para>
    ///   <para>skos:definition : Relates a manifestation to the process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.9.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : production method for tactile resource</para>
    ///   <para>rdfs:label : has production method for tactile resource</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30188">rdam:P30188</a>
    /// </summary>
    let P30188 = _prefixId.prefix "P30188"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : production method for manuscript</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForManuscript</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The process used to produce an original manuscript or a copy.</para>
    ///   <para>rdfs:label : has production method for manuscript</para>
    ///   <para>skos:definition : Relates a manifestation to the process used to produce an original manuscript or a copy.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.9.2^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30189">rdam:P30189</a>
    /// </summary>
    let P30189 = _prefixId.prefix "P30189"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the relationship between an original audio carrier and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfAudioRecording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : generation of audio recording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.2^^xsd:string</para>
    ///   <para>rdfs:label : has generation of audio recording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between an original audio carrier and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30190">rdam:P30190</a>
    /// </summary>
    let P30190 = _prefixId.prefix "P30190"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : generation</para>
    ///   <para>rdfs:label : has generation</para>
    ///   <para>skos:definition : Relates a manifestation to the relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.1^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30191">rdam:P30191</a>
    /// </summary>
    let P30191 = _prefixId.prefix "P30191"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfDigitalResource</para>
    ///   <para>rdfs:label : has generation of digital resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : generation of digital resource</para>
    ///   <para>skos:definition : Relates a manifestation to the relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30192">rdam:P30192</a>
    /// </summary>
    let P30192 = _prefixId.prefix "P30192"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : generation of motion picture film</para>
    ///   <para>skos:definition : Relates a manifestation to the relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>rdfs:label : has generation of motion picture film</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMotionPictureFilm</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30193">rdam:P30193</a>
    /// </summary>
    let P30193 = _prefixId.prefix "P30193"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.6^^xsd:string</para>
    ///   <para>rdfs:label : has generation of videotape</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : generation of videotape</para>
    ///   <para>skos:definition : Relates a manifestation to the relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfVideotape</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30194">rdam:P30194</a>
    /// </summary>
    let P30194 = _prefixId.prefix "P30194"
    /// <summary>
    ///   <para>rdfs:label : has generation of microform</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMicroform</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : generation of microform</para>
    ///   <para>skos:definition : Relates a manifestation to the relationship between an original microform carrier and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between an original microform carrier and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30195">rdam:P30195</a>
    /// </summary>
    let P30195 = _prefixId.prefix "P30195"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : polarity</para>
    ///   <para>skos:definition : Relates a manifestation to the relationship of the colours and tones in an image to the colours and tones of the object reproduced (e.g., positive, negative).</para>
    ///   <para>rdfs:label : has polarity</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : polarity</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.14^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship of the colours and tones in an image to the colours and tones of the object reproduced (e.g., positive, negative).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30196">rdam:P30196</a>
    /// </summary>
    let P30196 = _prefixId.prefix "P30196"
    /// <summary>
    ///   <para>rdfs:label : has book format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.12^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : book format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>skos:definition : Relates a manifestation to the result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookFormat</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30197">rdam:P30197</a>
    /// </summary>
    let P30197 = _prefixId.prefix "P30197"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reduction ratio</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reductionRatio</para>
    ///   <para>skos:definition : Relates a manifestation to the size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.15^^xsd:string</para>
    ///   <para>rdfs:label : has reduction ratio</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30198">rdam:P30198</a>
    /// </summary>
    let P30198 = _prefixId.prefix "P30198"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fontSize</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : font size</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.13^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>rdfs:label : has font size</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30199">rdam:P30199</a>
    /// </summary>
    let P30199 = _prefixId.prefix "P30199"
    /// <summary>
    ///   <para>rdfs:label : has projection speed</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionSpeed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : projection speed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.17.3^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30200">rdam:P30200</a>
    /// </summary>
    let P30200 = _prefixId.prefix "P30200"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : playingSpeed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>rdfs:label : has playing speed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : playing speed</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30201">rdam:P30201</a>
    /// </summary>
    let P30201 = _prefixId.prefix "P30201"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the speed at which streaming audio, video, etc., is designed to play.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : encodedBitrate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.7^^xsd:string</para>
    ///   <para>rdfs:label : has encoded bitrate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : encoded bitrate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The speed at which streaming audio, video, etc., is designed to play.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30202">rdam:P30202</a>
    /// </summary>
    let P30202 = _prefixId.prefix "P30202"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The title proper in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel title proper</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.3^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the title proper in another language and/or script.</para>
    ///   <para>rdfs:label : has parallel title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30203">rdam:P30203</a>
    /// </summary>
    let P30203 = _prefixId.prefix "P30203"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The title proper of a series in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSeries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.3^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the title proper of a series in another language and/or script.</para>
    ///   <para>rdfs:label : has parallel title proper of series</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel title proper of series</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30204">rdam:P30204</a>
    /// </summary>
    let P30204 = _prefixId.prefix "P30204"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the title proper of a subseries in another language and/or script.</para>
    ///   <para>rdfs:label : has parallel title proper of subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSubseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The title proper of a subseries in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parallel title proper of subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.12.11^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30205">rdam:P30205</a>
    /// </summary>
    let P30205 = _prefixId.prefix "P30205"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingMedium</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : recording medium</para>
    ///   <para>skos:definition : Relates a manifestation to the type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>rdfs:label : has recording medium</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30206">rdam:P30206</a>
    /// </summary>
    let P30206 = _prefixId.prefix "P30206"
    let P30207 = _prefixId.prefix "P30207"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : base material</para>
    ///   <para>rdfs:label : has base material</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : baseMaterial</para>
    ///   <para>skos:definition : Relates a manifestation to the underlying physical material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The underlying physical material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.6^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30208">rdam:P30208</a>
    /// </summary>
    let P30208 = _prefixId.prefix "P30208"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.3.9^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to the unique name assigned to a resource by an issn registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : key title</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : keyTitle</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The unique name assigned to a resource by an ISSN registration agency.</para>
    ///   <para>rdfs:label : has key title</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30209">rdam:P30209</a>
    /// </summary>
    let P30209 = _prefixId.prefix "P30209"
    /// <summary>
    ///   <para>rdfs:label : has accompanying manifestation relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingManifestationRelationship</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that accompanies or is accompanied by the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : accompanying manifestation relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that accompanies or is accompanied by the manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30210">rdam:P30210</a>
    /// </summary>
    let P30210 = _prefixId.prefix "P30210"
    let P30211 = _prefixId.prefix "P30211"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is equivalent to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : equivalent manifestation relationship</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is equivalent to the manifestation.</para>
    ///   <para>rdfs:label : has equivalent manifestation relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalentManifestationRelationship</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30212">rdam:P30212</a>
    /// </summary>
    let P30212 = _prefixId.prefix "P30212"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is contained in or contains the manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to a manifestation that is contained in or contains the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : whole-part manifestation relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartManifestationRelationship</para>
    ///   <para>rdfs:label : has whole-part manifestation relationship with</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30213">rdam:P30213</a>
    /// </summary>
    let P30213 = _prefixId.prefix "P30213"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnCarrier</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on attributes of the carrier or carriers of the manifestation.</para>
    ///   <para>rdfs:label : has note on carrier</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.21^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to a note providing information on attributes of the carrier or carriers of the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on carrier</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30214">rdam:P30214</a>
    /// </summary>
    let P30214 = _prefixId.prefix "P30214"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : papermaker</para>
    ///   <para>rdfs:label : has papermaker</para>
    ///   <para>skos:definition : Relates a manifestation to a person, family, or corporate body responsible for the production of paper used to manufacture a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for the production of paper used to manufacture a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : papermaker</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30215">rdam:P30215</a>
    /// </summary>
    let P30215 = _prefixId.prefix "P30215"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a physical or chemical substance applied to a base material of a resource.</para>
    ///   <para>rdfs:label : has details of applied material</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.7.1.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of a physical or chemical substance applied to a base material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of applied material</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfAppliedMaterial</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30216">rdam:P30216</a>
    /// </summary>
    let P30216 = _prefixId.prefix "P30216"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfBaseMaterial</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.6.1.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of the underlying physical material of a resource.</para>
    ///   <para>rdfs:label : has details of base material</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of base material</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the underlying physical material of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30217">rdam:P30217</a>
    /// </summary>
    let P30217 = _prefixId.prefix "P30217"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to details of the result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.12.1.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>rdfs:label : has details of book format</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfBookFormat</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of book format</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30218">rdam:P30218</a>
    /// </summary>
    let P30218 = _prefixId.prefix "P30218"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfBroadcastStandard</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.18.3.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a system used to format a video resource for television broadcast.</para>
    ///   <para>skos:definition : Relates a manifestation to details of a system used to format a video resource for television broadcast.</para>
    ///   <para>rdfs:label : has details of broadcast standard</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of broadcast standard</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30219">rdam:P30219</a>
    /// </summary>
    let P30219 = _prefixId.prefix "P30219"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfConfigurationOfPlaybackChannels</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>skos:definition : Relates a manifestation to details of the number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.8.4^^xsd:string</para>
    ///   <para>rdfs:label : has details of configuration of playback channels</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of configuration of playback channels</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30220">rdam:P30220</a>
    /// </summary>
    let P30220 = _prefixId.prefix "P30220"
    /// <summary>
    ///   <para>rdfs:label : has details of digital file characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfDigitalFileCharacteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.1.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of a technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of digital file characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30221">rdam:P30221</a>
    /// </summary>
    let P30221 = _prefixId.prefix "P30221"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.8.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the encoding of geospatial information in a cartographic resource (e.g., topology level, compression).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfDigitalRepresentationOfCartographicContent</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of digital representation of cartographic content</para>
    ///   <para>rdfs:label : has details of digital representation of cartographic content</para>
    ///   <para>skos:definition : Relates a manifestation to details of the encoding of geospatial information in a cartographic resource (e.g., topology level, compression).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30222">rdam:P30222</a>
    /// </summary>
    let P30222 = _prefixId.prefix "P30222"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.7.2.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfEmulsionOnMicrofilmAndMicrofiche</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of emulsion on microfilm and microfiche</para>
    ///   <para>rdfs:label : has details of emulsion on microfilm and microfiche</para>
    ///   <para>skos:definition : Relates a manifestation to details of a suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30223">rdam:P30223</a>
    /// </summary>
    let P30223 = _prefixId.prefix "P30223"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.3.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfEncodingFormat</para>
    ///   <para>skos:definition : Relates a manifestation to details of a schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>rdfs:label : has details of encoding format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of encoding format</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30224">rdam:P30224</a>
    /// </summary>
    let P30224 = _prefixId.prefix "P30224"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of file type</para>
    ///   <para>rdfs:label : has details of file type</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.19.2.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a general type of data content encoded in a computer file.</para>
    ///   <para>skos:definition : Relates a manifestation to details of a general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFileType</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30225">rdam:P30225</a>
    /// </summary>
    let P30225 = _prefixId.prefix "P30225"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of font size</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFontSize</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>skos:definition : Relates a manifestation to details of the size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>rdfs:label : has details of font size</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.13.1.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30226">rdam:P30226</a>
    /// </summary>
    let P30226 = _prefixId.prefix "P30226"
    /// <summary>
    ///   <para>rdfs:label : has details of generation of audio recording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.2.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of generation of audio recording</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfAudioRecording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship between an original audio carrier and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship between an original audio carrier and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30227">rdam:P30227</a>
    /// </summary>
    let P30227 = _prefixId.prefix "P30227"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfDigitalResource</para>
    ///   <para>rdfs:label : has details of generation of digital resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of generation of digital resource</para>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.3.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30228">rdam:P30228</a>
    /// </summary>
    let P30228 = _prefixId.prefix "P30228"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship between an original microform carrier and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.4.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship between an original microform carrier and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of generation of microform</para>
    ///   <para>rdfs:label : has details of generation of microform</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfMicroform</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30229">rdam:P30229</a>
    /// </summary>
    let P30229 = _prefixId.prefix "P30229"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.5.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of generation of motion picture film</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>rdfs:label : has details of generation of motion picture film</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfMotionPictureFilm</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30230">rdam:P30230</a>
    /// </summary>
    let P30230 = _prefixId.prefix "P30230"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfVideotape</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of generation of videotape</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.6.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>rdfs:label : has details of generation of videotape</para>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30231">rdam:P30231</a>
    /// </summary>
    let P30231 = _prefixId.prefix "P30231"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGrooveCharacteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>skos:definition : Relates a manifestation to details of the groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of groove characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.5.4^^xsd:string</para>
    ///   <para>rdfs:label : has details of groove characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30232">rdam:P30232</a>
    /// </summary>
    let P30232 = _prefixId.prefix "P30232"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.11.1.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of the arrangement of text, images, tactile notation, etc., in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfLayout</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of layout</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the arrangement of text, images, tactile notation, etc., in a resource.</para>
    ///   <para>rdfs:label : has details of layout</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30233">rdam:P30233</a>
    /// </summary>
    let P30233 = _prefixId.prefix "P30233"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.8.1.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of mount</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfMount</para>
    ///   <para>skos:definition : Relates a manifestation to details of the physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>rdfs:label : has details of mount</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30234">rdam:P30234</a>
    /// </summary>
    let P30234 = _prefixId.prefix "P30234"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfPlayingSpeed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.4.4^^xsd:string</para>
    ///   <para>rdfs:label : has details of playing speed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of playing speed</para>
    ///   <para>skos:definition : Relates a manifestation to details of the speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30235">rdam:P30235</a>
    /// </summary>
    let P30235 = _prefixId.prefix "P30235"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of polarity</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship of the colours and tones in an image to the colours and tones of the object reproduced (e.g., positive, negative).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.14.1.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship of the colours and tones in an image to the colours and tones of the object reproduced (e.g., positive, negative).</para>
    ///   <para>rdfs:label : has details of polarity</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfPolarity</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30236">rdam:P30236</a>
    /// </summary>
    let P30236 = _prefixId.prefix "P30236"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to details of the format used in the production of a projected image (e.g., Cinerama, Imax).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfPresentationFormat</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of presentation format</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the format used in the production of a projected image (e.g., Cinerama, Imax).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.17.2.4^^xsd:string</para>
    ///   <para>rdfs:label : has details of presentation format</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30237">rdam:P30237</a>
    /// </summary>
    let P30237 = _prefixId.prefix "P30237"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProductionMethod</para>
    ///   <para>rdfs:label : has details of production method</para>
    ///   <para>skos:definition : Relates a manifestation to details of the process used to produce a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of production method</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the process used to produce a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.9.1.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30238">rdam:P30238</a>
    /// </summary>
    let P30238 = _prefixId.prefix "P30238"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to details of the process used to produce an original manuscript or a copy.</para>
    ///   <para>rdfs:label : has details of production method for manuscript</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProductionMethodForManuscript</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of production method for manuscript</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the process used to produce an original manuscript or a copy.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.9.2.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30239">rdam:P30239</a>
    /// </summary>
    let P30239 = _prefixId.prefix "P30239"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of production method for tactile resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>skos:definition : Relates a manifestation to details of the process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>rdfs:label : has details of production method for tactile resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProductionMethodForTactileResource</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.9.3.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30240">rdam:P30240</a>
    /// </summary>
    let P30240 = _prefixId.prefix "P30240"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProjectionCharacteristicOfMotionPictureFilm</para>
    ///   <para>skos:definition : Relates a manifestation to details of a technical specification relating to the projection of a motion picture film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a technical specification relating to the projection of a motion picture film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of projection characteristic of motion picture film</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.17.1.4^^xsd:string</para>
    ///   <para>rdfs:label : has details of projection characteristic of motion picture film</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30241">rdam:P30241</a>
    /// </summary>
    let P30241 = _prefixId.prefix "P30241"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to details of the speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.17.3.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProjectionSpeed</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of projection speed</para>
    ///   <para>rdfs:label : has details of projection speed</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30242">rdam:P30242</a>
    /// </summary>
    let P30242 = _prefixId.prefix "P30242"
    /// <summary>
    ///   <para>rdfs:label : has details of recording medium</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.3.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfRecordingMedium</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of recording medium</para>
    ///   <para>skos:definition : Relates a manifestation to details of the type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30243">rdam:P30243</a>
    /// </summary>
    let P30243 = _prefixId.prefix "P30243"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of reduction ratio</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.15.1.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfReductionRatio</para>
    ///   <para>skos:definition : Relates a manifestation to details of the size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>rdfs:label : has details of reduction ratio</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30244">rdam:P30244</a>
    /// </summary>
    let P30244 = _prefixId.prefix "P30244"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to details of a technical specification relating to the encoding of sound in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfSoundCharacteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.1.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of sound characteristic</para>
    ///   <para>rdfs:label : has details of sound characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a technical specification relating to the encoding of sound in a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30245">rdam:P30245</a>
    /// </summary>
    let P30245 = _prefixId.prefix "P30245"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of an equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.9.4^^xsd:string</para>
    ///   <para>rdfs:label : has details of special playback characteristic</para>
    ///   <para>skos:definition : Relates a manifestation to details of an equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfSpecialPlaybackCharacteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of special playback characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30246">rdam:P30246</a>
    /// </summary>
    let P30246 = _prefixId.prefix "P30246"
    /// <summary>
    ///   <para>rdfs:label : has details of tape configuration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.7.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfTapeConfiguration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the number of tracks on an audiotape.</para>
    ///   <para>skos:definition : Relates a manifestation to details of the number of tracks on an audiotape.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of tape configuration</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30247">rdam:P30247</a>
    /// </summary>
    let P30247 = _prefixId.prefix "P30247"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfTrackConfiguration</para>
    ///   <para>skos:definition : Relates a manifestation to details of the configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>rdfs:label : has details of track configuration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of track configuration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.6.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30248">rdam:P30248</a>
    /// </summary>
    let P30248 = _prefixId.prefix "P30248"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.16.2.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a manifestation to details of the method used to encode audio content for playback (e.g., analog or digital).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfTypeOfRecording</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the method used to encode audio content for playback (e.g., analog or digital).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of type of recording</para>
    ///   <para>rdfs:label : has details of type of recording</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30249">rdam:P30249</a>
    /// </summary>
    let P30249 = _prefixId.prefix "P30249"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a technical specification relating to the encoding of video images in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.18.1.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of video characteristic</para>
    ///   <para>skos:definition : Relates a manifestation to details of a technical specification relating to the encoding of video images in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfVideoCharacteristic</para>
    ///   <para>rdfs:label : has details of video characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30250">rdam:P30250</a>
    /// </summary>
    let P30250 = _prefixId.prefix "P30250"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.18.2.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of video format</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfVideoFormat</para>
    ///   <para>rdfs:label : has details of video format</para>
    ///   <para>skos:definition : Relates a manifestation to details of a standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of a standard, etc., used to encode the analog video content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30251">rdam:P30251</a>
    /// </summary>
    let P30251 = _prefixId.prefix "P30251"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.10.1.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : details of generation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGeneration</para>
    ///   <para>skos:definition : Relates a manifestation to details of the relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Details of the relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>rdfs:label : has details of generation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30252">rdam:P30252</a>
    /// </summary>
    let P30252 = _prefixId.prefix "P30252"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a work that is about the manifestation.</para>
    ///   <para>rdfs:label : is subject of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is about the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOfManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30253">rdam:P30253</a>
    /// </summary>
    let P30253 = _prefixId.prefix "P30253"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that describes a described manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to a work that describes a described manifestation.</para>
    ///   <para>rdfs:label : is described in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : described in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedInManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30254">rdam:P30254</a>
    /// </summary>
    let P30254 = _prefixId.prefix "P30254"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a work that examines the source manifestation to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedInManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that examines the source manifestation to identify its components and their relations.</para>
    ///   <para>rdfs:label : is analysed in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysed in (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30255">rdam:P30255</a>
    /// </summary>
    let P30255 = _prefixId.prefix "P30255"
    /// <summary>
    ///   <para>rdfs:label : is commentary in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryInManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a work that contains a set of explanatory or critical notes on the described manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a set of explanatory or critical notes on the described manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary in (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30256">rdam:P30256</a>
    /// </summary>
    let P30256 = _prefixId.prefix "P30256"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a work that contains a critical evaluation of the described manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critiqued in (manifestation)</para>
    ///   <para>rdfs:label : is critiqued in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedInManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a critical evaluation of the described manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30257">rdam:P30257</a>
    /// </summary>
    let P30257 = _prefixId.prefix "P30257"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluated in (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that examines or judges the described manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedInManifestation</para>
    ///   <para>skos:definition : Relates a manifestation to a work that examines or judges the described manifestation.</para>
    ///   <para>rdfs:label : is evaluated in (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30258">rdam:P30258</a>
    /// </summary>
    let P30258 = _prefixId.prefix "P30258"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a brief evaluation of the described manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to a work that contains a brief evaluation of the described manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedInManifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reviewed in (manifestation)</para>
    ///   <para>rdfs:label : is reviewed in (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/m/P30259">rdam:P30259</a>
    /// </summary>
    let P30259 = _prefixId.prefix "P30259"
    let abbreviatedTitle'_period_'en = _prefixId.prefix "abbreviatedTitle.en"

    let accompaniedByManifestation'_period_'en = _prefixId.prefix "accompaniedByManifestation.en"

    let accompanyingManifestationRelationship'_period_'en = _prefixId.prefix "accompanyingManifestationRelationship.en"

    let alsoIssuedAs'_period_'en = _prefixId.prefix "alsoIssuedAs.en"

    let alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence'_period_'en = _prefixId.prefix "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en"

    let alternativeChronologicalDesignationOfLastIssueOrPartOfSequence'_period_'en = _prefixId.prefix "alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en"

    let alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence'_period_'en =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en"

    let alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence'_period_'en =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en"

    let analysedInManifestation'_period_'en = _prefixId.prefix "analysedInManifestation.en"

    let appliedMaterial'_period_'en = _prefixId.prefix "appliedMaterial.en"
    let baseMaterial'_period_'en = _prefixId.prefix "baseMaterial.en"
    let bookDesigner'_period_'en = _prefixId.prefix "bookDesigner.en"
    let bookFormat'_period_'en = _prefixId.prefix "bookFormat.en"
    let brailleEmbosser'_period_'en = _prefixId.prefix "brailleEmbosser.en"
    let broadcastStandard'_period_'en = _prefixId.prefix "broadcastStandard.en"
    let broadcaster'_period_'en = _prefixId.prefix "broadcaster.en"
    let carrierType'_period_'en = _prefixId.prefix "carrierType.en"
    let caster'_period_'en = _prefixId.prefix "caster.en"

    let chronologicalDesignationOfFirstIssueOrPartOfSequence'_period_'en = _prefixId.prefix "chronologicalDesignationOfFirstIssueOrPartOfSequence.en"

    let chronologicalDesignationOfLastIssueOrPartOfSequence'_period_'en = _prefixId.prefix "chronologicalDesignationOfLastIssueOrPartOfSequence.en"

    let collotyper'_period_'en = _prefixId.prefix "collotyper.en"

    let commentaryInManifestation'_period_'en = _prefixId.prefix "commentaryInManifestation.en"

    let configurationOfPlaybackChannels'_period_'en = _prefixId.prefix "configurationOfPlaybackChannels.en"

    let contactInformation'_period_'en = _prefixId.prefix "contactInformation.en"

    let containedInManifestation'_period_'en = _prefixId.prefix "containedInManifestation.en"

    let containerOfManifestation'_period_'en = _prefixId.prefix "containerOfManifestation.en"

    let copyrightDate'_period_'en = _prefixId.prefix "copyrightDate.en"

    let critiquedInManifestation'_period_'en = _prefixId.prefix "critiquedInManifestation.en"

    let dateOfDistribution'_period_'en = _prefixId.prefix "dateOfDistribution.en"
    let dateOfManufacture'_period_'en = _prefixId.prefix "dateOfManufacture.en"
    let dateOfProduction'_period_'en = _prefixId.prefix "dateOfProduction.en"
    let dateOfPublication'_period_'en = _prefixId.prefix "dateOfPublication.en"

    let describedInManifestation'_period_'en = _prefixId.prefix "describedInManifestation.en"

    let designationOfANamedRevisionOfAnEdition'_period_'en = _prefixId.prefix "designationOfANamedRevisionOfAnEdition.en"

    let designationOfEdition'_period_'en = _prefixId.prefix "designationOfEdition.en"

    let detailsOfAppliedMaterial'_period_'en = _prefixId.prefix "detailsOfAppliedMaterial.en"

    let detailsOfBaseMaterial'_period_'en = _prefixId.prefix "detailsOfBaseMaterial.en"
    let detailsOfBookFormat'_period_'en = _prefixId.prefix "detailsOfBookFormat.en"

    let detailsOfBroadcastStandard'_period_'en = _prefixId.prefix "detailsOfBroadcastStandard.en"

    let detailsOfConfigurationOfPlaybackChannels'_period_'en = _prefixId.prefix "detailsOfConfigurationOfPlaybackChannels.en"

    let detailsOfDigitalFileCharacteristic'_period_'en = _prefixId.prefix "detailsOfDigitalFileCharacteristic.en"

    let detailsOfDigitalRepresentationOfCartographicContent'_period_'en = _prefixId.prefix "detailsOfDigitalRepresentationOfCartographicContent.en"

    let detailsOfEmulsionOnMicrofilmAndMicrofiche'_period_'en = _prefixId.prefix "detailsOfEmulsionOnMicrofilmAndMicrofiche.en"

    let detailsOfEncodingFormat'_period_'en = _prefixId.prefix "detailsOfEncodingFormat.en"

    let detailsOfFileType'_period_'en = _prefixId.prefix "detailsOfFileType.en"
    let detailsOfFontSize'_period_'en = _prefixId.prefix "detailsOfFontSize.en"
    let detailsOfGeneration'_period_'en = _prefixId.prefix "detailsOfGeneration.en"

    let detailsOfGenerationOfAudioRecording'_period_'en = _prefixId.prefix "detailsOfGenerationOfAudioRecording.en"

    let detailsOfGenerationOfDigitalResource'_period_'en = _prefixId.prefix "detailsOfGenerationOfDigitalResource.en"

    let detailsOfGenerationOfMicroform'_period_'en = _prefixId.prefix "detailsOfGenerationOfMicroform.en"

    let detailsOfGenerationOfMotionPictureFilm'_period_'en = _prefixId.prefix "detailsOfGenerationOfMotionPictureFilm.en"

    let detailsOfGenerationOfVideotape'_period_'en = _prefixId.prefix "detailsOfGenerationOfVideotape.en"

    let detailsOfGrooveCharacteristic'_period_'en = _prefixId.prefix "detailsOfGrooveCharacteristic.en"

    let detailsOfLayout'_period_'en = _prefixId.prefix "detailsOfLayout.en"
    let detailsOfMount'_period_'en = _prefixId.prefix "detailsOfMount.en"
    let detailsOfPlayingSpeed'_period_'en = _prefixId.prefix "detailsOfPlayingSpeed.en"
    let detailsOfPolarity'_period_'en = _prefixId.prefix "detailsOfPolarity.en"

    let detailsOfPresentationFormat'_period_'en = _prefixId.prefix "detailsOfPresentationFormat.en"

    let detailsOfProductionMethod'_period_'en = _prefixId.prefix "detailsOfProductionMethod.en"

    let detailsOfProductionMethodForManuscript'_period_'en = _prefixId.prefix "detailsOfProductionMethodForManuscript.en"

    let detailsOfProductionMethodForTactileResource'_period_'en = _prefixId.prefix "detailsOfProductionMethodForTactileResource.en"

    let detailsOfProjectionCharacteristicOfMotionPictureFilm'_period_'en = _prefixId.prefix "detailsOfProjectionCharacteristicOfMotionPictureFilm.en"

    let detailsOfProjectionSpeed'_period_'en = _prefixId.prefix "detailsOfProjectionSpeed.en"

    let detailsOfRecordingMedium'_period_'en = _prefixId.prefix "detailsOfRecordingMedium.en"

    let detailsOfReductionRatio'_period_'en = _prefixId.prefix "detailsOfReductionRatio.en"

    let detailsOfSoundCharacteristic'_period_'en = _prefixId.prefix "detailsOfSoundCharacteristic.en"

    let detailsOfSpecialPlaybackCharacteristic'_period_'en = _prefixId.prefix "detailsOfSpecialPlaybackCharacteristic.en"

    let detailsOfTapeConfiguration'_period_'en = _prefixId.prefix "detailsOfTapeConfiguration.en"

    let detailsOfTrackConfiguration'_period_'en = _prefixId.prefix "detailsOfTrackConfiguration.en"

    let detailsOfTypeOfRecording'_period_'en = _prefixId.prefix "detailsOfTypeOfRecording.en"

    let detailsOfVideoCharacteristic'_period_'en = _prefixId.prefix "detailsOfVideoCharacteristic.en"

    let detailsOfVideoFormat'_period_'en = _prefixId.prefix "detailsOfVideoFormat.en"

    let digitalFileCharacteristic'_period_'en = _prefixId.prefix "digitalFileCharacteristic.en"

    let digitalRepresentationOfCartographicContent'_period_'en = _prefixId.prefix "digitalRepresentationOfCartographicContent.en"

    let digitalTransferManifestation'_period_'en = _prefixId.prefix "digitalTransferManifestation.en"

    let digitalTransferOfManifestation'_period_'en = _prefixId.prefix "digitalTransferOfManifestation.en"

    let dimensions'_period_'en = _prefixId.prefix "dimensions.en"
    let dimensionsOfMapEtc'_period_'en = _prefixId.prefix "dimensionsOfMapEtc.en"

    let dimensionsOfStillImage'_period_'en = _prefixId.prefix "dimensionsOfStillImage.en"

    let distributionStatement'_period_'en = _prefixId.prefix "distributionStatement.en"
    let distributor'_period_'en = _prefixId.prefix "distributor.en"
    let distributorsName'_period_'en = _prefixId.prefix "distributorsName.en"
    let earlierTitleProper'_period_'en = _prefixId.prefix "earlierTitleProper.en"
    let editionStatement'_period_'en = _prefixId.prefix "editionStatement.en"

    let electronicReproductionManifestation'_period_'en = _prefixId.prefix "electronicReproductionManifestation.en"

    let electronicReproductionOfManifestation'_period_'en = _prefixId.prefix "electronicReproductionOfManifestation.en"

    let emulsionOnMicrofilmAndMicrofiche'_period_'en = _prefixId.prefix "emulsionOnMicrofilmAndMicrofiche.en"

    let encodedBitrate'_period_'en = _prefixId.prefix "encodedBitrate.en"
    let encodingFormat'_period_'en = _prefixId.prefix "encodingFormat.en"
    let engraver'_period_'en = _prefixId.prefix "engraver.en"

    let equipmentOrSystemRequirement'_period_'en = _prefixId.prefix "equipmentOrSystemRequirement.en"

    let equivalentManifestation'_period_'en = _prefixId.prefix "equivalentManifestation.en"

    let equivalentManifestationRelationship'_period_'en = _prefixId.prefix "equivalentManifestationRelationship.en"

    let etcher'_period_'en = _prefixId.prefix "etcher.en"

    let evaluatedInManifestation'_period_'en = _prefixId.prefix "evaluatedInManifestation.en"

    let exemplarOfManifestation'_period_'en = _prefixId.prefix "exemplarOfManifestation.en"

    let expressionManifested'_period_'en = _prefixId.prefix "expressionManifested.en"
    let extent'_period_'en = _prefixId.prefix "extent.en"

    let extentOfCartographicResource'_period_'en = _prefixId.prefix "extentOfCartographicResource.en"

    let extentOfNotatedMusic'_period_'en = _prefixId.prefix "extentOfNotatedMusic.en"
    let extentOfStillImage'_period_'en = _prefixId.prefix "extentOfStillImage.en"
    let extentOfText'_period_'en = _prefixId.prefix "extentOfText.en"

    let extentOfThreeDimensionalForm'_period_'en = _prefixId.prefix "extentOfThreeDimensionalForm.en"

    let facsimileContainedIn'_period_'en = _prefixId.prefix "facsimileContainedIn.en"
    let facsimileContainerOf'_period_'en = _prefixId.prefix "facsimileContainerOf.en"

    let facsimileManifestation'_period_'en = _prefixId.prefix "facsimileManifestation.en"

    let facsimileOfManifestation'_period_'en = _prefixId.prefix "facsimileOfManifestation.en"

    let fileSize'_period_'en = _prefixId.prefix "fileSize.en"
    let fileType'_period_'en = _prefixId.prefix "fileType.en"
    let filmDistributor'_period_'en = _prefixId.prefix "filmDistributor.en"

    let filmedWithManifestation'_period_'en = _prefixId.prefix "filmedWithManifestation.en"

    let fontSize'_period_'en = _prefixId.prefix "fontSize.en"
    let frequency'_period_'en = _prefixId.prefix "frequency.en"
    let generation'_period_'en = _prefixId.prefix "generation.en"

    let generationOfAudioRecording'_period_'en = _prefixId.prefix "generationOfAudioRecording.en"

    let generationOfDigitalResource'_period_'en = _prefixId.prefix "generationOfDigitalResource.en"

    let generationOfMicroform'_period_'en = _prefixId.prefix "generationOfMicroform.en"

    let generationOfMotionPictureFilm'_period_'en = _prefixId.prefix "generationOfMotionPictureFilm.en"

    let generationOfVideotape'_period_'en = _prefixId.prefix "generationOfVideotape.en"
    let grooveCharacteristic'_period_'en = _prefixId.prefix "grooveCharacteristic.en"

    let identifierForTheManifestation'_period_'en = _prefixId.prefix "identifierForTheManifestation.en"

    let insert'_period_'en = _prefixId.prefix "insert.en"
    let insertedIn'_period_'en = _prefixId.prefix "insertedIn.en"
    let issnOfSeries'_period_'en = _prefixId.prefix "issnOfSeries.en"
    let issnOfSubseries'_period_'en = _prefixId.prefix "issnOfSubseries.en"
    let issuedWith'_period_'en = _prefixId.prefix "issuedWith.en"
    let keyTitle'_period_'en = _prefixId.prefix "keyTitle.en"
    let laterTitleProper'_period_'en = _prefixId.prefix "laterTitleProper.en"
    let layout'_period_'en = _prefixId.prefix "layout.en"
    let lithographer'_period_'en = _prefixId.prefix "lithographer.en"
    let manufactureStatement'_period_'en = _prefixId.prefix "manufactureStatement.en"
    let manufacturer'_period_'en = _prefixId.prefix "manufacturer.en"
    let manufacturersName'_period_'en = _prefixId.prefix "manufacturersName.en"
    let mediaType'_period_'en = _prefixId.prefix "mediaType.en"
    let mirrorSite'_period_'en = _prefixId.prefix "mirrorSite.en"
    let modeOfIssuance'_period_'en = _prefixId.prefix "modeOfIssuance.en"
    let mount'_period_'en = _prefixId.prefix "mount.en"
    let noteOnCarrier'_period_'en = _prefixId.prefix "noteOnCarrier.en"

    let noteOnChangesInCarrierCharacteristics'_period_'en = _prefixId.prefix "noteOnChangesInCarrierCharacteristics.en"

    let noteOnCopyrightDate'_period_'en = _prefixId.prefix "noteOnCopyrightDate.en"

    let noteOnDimensionsOfManifestation'_period_'en = _prefixId.prefix "noteOnDimensionsOfManifestation.en"

    let noteOnDistributionStatement'_period_'en = _prefixId.prefix "noteOnDistributionStatement.en"

    let noteOnEditionStatement'_period_'en = _prefixId.prefix "noteOnEditionStatement.en"

    let noteOnExtentOfManifestation'_period_'en = _prefixId.prefix "noteOnExtentOfManifestation.en"

    let noteOnFrequency'_period_'en = _prefixId.prefix "noteOnFrequency.en"

    let noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource'_period_'en =
        _prefixId.prefix "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en"

    let noteOnManifestation'_period_'en = _prefixId.prefix "noteOnManifestation.en"

    let noteOnManufactureStatement'_period_'en = _prefixId.prefix "noteOnManufactureStatement.en"

    let noteOnNumberingOfSerials'_period_'en = _prefixId.prefix "noteOnNumberingOfSerials.en"

    let noteOnProductionStatement'_period_'en = _prefixId.prefix "noteOnProductionStatement.en"

    let noteOnPublicationStatement'_period_'en = _prefixId.prefix "noteOnPublicationStatement.en"

    let noteOnSeriesStatement'_period_'en = _prefixId.prefix "noteOnSeriesStatement.en"

    let noteOnStatementOfResponsibility'_period_'en = _prefixId.prefix "noteOnStatementOfResponsibility.en"

    let noteOnTitle'_period_'en = _prefixId.prefix "noteOnTitle.en"
    let numberingOfSerials'_period_'en = _prefixId.prefix "numberingOfSerials.en"
    let numberingWithinSeries'_period_'en = _prefixId.prefix "numberingWithinSeries.en"

    let numberingWithinSubseries'_period_'en = _prefixId.prefix "numberingWithinSubseries.en"

    let numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence'_period_'en = _prefixId.prefix "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en"

    let numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence'_period_'en = _prefixId.prefix "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en"

    let onDiscWithManifestation'_period_'en = _prefixId.prefix "onDiscWithManifestation.en"

    let otherPFCManifestation'_period_'en = _prefixId.prefix "otherPFCManifestation.en"
    let otherTitleInformation'_period_'en = _prefixId.prefix "otherTitleInformation.en"

    let otherTitleInformationOfSeries'_period_'en = _prefixId.prefix "otherTitleInformationOfSeries.en"

    let otherTitleInformationOfSubseries'_period_'en = _prefixId.prefix "otherTitleInformationOfSubseries.en"

    let papermaker'_period_'en = _prefixId.prefix "papermaker.en"

    let parallelDesignationOfANamedRevisionOfAnEdition'_period_'en = _prefixId.prefix "parallelDesignationOfANamedRevisionOfAnEdition.en"

    let parallelDesignationOfEdition'_period_'en = _prefixId.prefix "parallelDesignationOfEdition.en"

    let parallelDistributorsName'_period_'en = _prefixId.prefix "parallelDistributorsName.en"

    let parallelManufacturersName'_period_'en = _prefixId.prefix "parallelManufacturersName.en"

    let parallelOtherTitleInformation'_period_'en = _prefixId.prefix "parallelOtherTitleInformation.en"

    let parallelOtherTitleInformationOfSeries'_period_'en = _prefixId.prefix "parallelOtherTitleInformationOfSeries.en"

    let parallelOtherTitleInformationOfSubseries'_period_'en = _prefixId.prefix "parallelOtherTitleInformationOfSubseries.en"

    let parallelPlaceOfDistribution'_period_'en = _prefixId.prefix "parallelPlaceOfDistribution.en"

    let parallelPlaceOfManufacture'_period_'en = _prefixId.prefix "parallelPlaceOfManufacture.en"

    let parallelPlaceOfProduction'_period_'en = _prefixId.prefix "parallelPlaceOfProduction.en"

    let parallelPlaceOfPublication'_period_'en = _prefixId.prefix "parallelPlaceOfPublication.en"

    let parallelProducersName'_period_'en = _prefixId.prefix "parallelProducersName.en"

    let parallelPublishersName'_period_'en = _prefixId.prefix "parallelPublishersName.en"

    let parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition'_period_'en =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en"

    let parallelStatementOfResponsibilityRelatingToSeries'_period_'en = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSeries.en"

    let parallelStatementOfResponsibilityRelatingToSubseries'_period_'en = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSubseries.en"

    let parallelStatementOfResponsibilityRelatingToTheEdition'_period_'en = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTheEdition.en"

    let parallelStatementOfResponsibilityRelatingToTitleProper'_period_'en = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTitleProper.en"

    let parallelTitleProper'_period_'en = _prefixId.prefix "parallelTitleProper.en"

    let parallelTitleProperOfSeries'_period_'en = _prefixId.prefix "parallelTitleProperOfSeries.en"

    let parallelTitleProperOfSubseries'_period_'en = _prefixId.prefix "parallelTitleProperOfSubseries.en"

    let placeOfDistribution'_period_'en = _prefixId.prefix "placeOfDistribution.en"
    let placeOfManufacture'_period_'en = _prefixId.prefix "placeOfManufacture.en"
    let placeOfProduction'_period_'en = _prefixId.prefix "placeOfProduction.en"
    let placeOfPublication'_period_'en = _prefixId.prefix "placeOfPublication.en"
    let plateNumberForMusic'_period_'en = _prefixId.prefix "plateNumberForMusic.en"
    let platemaker'_period_'en = _prefixId.prefix "platemaker.en"
    let playingSpeed'_period_'en = _prefixId.prefix "playingSpeed.en"
    let polarity'_period_'en = _prefixId.prefix "polarity.en"
    let preferredCitation'_period_'en = _prefixId.prefix "preferredCitation.en"
    let presentationFormat'_period_'en = _prefixId.prefix "presentationFormat.en"

    let preservationFacsimileManifestation'_period_'en = _prefixId.prefix "preservationFacsimileManifestation.en"

    let preservationFacsimileOfManifestation'_period_'en = _prefixId.prefix "preservationFacsimileOfManifestation.en"

    let printer'_period_'en = _prefixId.prefix "printer.en"
    let printmaker'_period_'en = _prefixId.prefix "printmaker.en"

    let producerOfAnUnpublishedResource'_period_'en = _prefixId.prefix "producerOfAnUnpublishedResource.en"

    let producersName'_period_'en = _prefixId.prefix "producersName.en"
    let productionMethod'_period_'en = _prefixId.prefix "productionMethod.en"

    let productionMethodForManuscript'_period_'en = _prefixId.prefix "productionMethodForManuscript.en"

    let productionMethodForTactileResource'_period_'en = _prefixId.prefix "productionMethodForTactileResource.en"

    let productionStatement'_period_'en = _prefixId.prefix "productionStatement.en"

    let projectionCharacteristicOfMotionPictureFilm'_period_'en = _prefixId.prefix "projectionCharacteristicOfMotionPictureFilm.en"

    let projectionSpeed'_period_'en = _prefixId.prefix "projectionSpeed.en"
    let publicationStatement'_period_'en = _prefixId.prefix "publicationStatement.en"
    let publisher'_period_'en = _prefixId.prefix "publisher.en"
    let publishersName'_period_'en = _prefixId.prefix "publishersName.en"

    let publishersNumberForMusic'_period_'en = _prefixId.prefix "publishersNumberForMusic.en"

    let recordingMedium'_period_'en = _prefixId.prefix "recordingMedium.en"
    let reductionRatio'_period_'en = _prefixId.prefix "reductionRatio.en"
    let regionalEncoding'_period_'en = _prefixId.prefix "regionalEncoding.en"
    let relatedItem'_period_'en = _prefixId.prefix "relatedItem.en"
    let relatedManifestation'_period_'en = _prefixId.prefix "relatedManifestation.en"

    let reprintOfManifestation'_period_'en = _prefixId.prefix "reprintOfManifestation.en"

    let reprintedAsManifestation'_period_'en = _prefixId.prefix "reprintedAsManifestation.en"

    let reproducedAsManifestation'_period_'en = _prefixId.prefix "reproducedAsManifestation.en"

    let reproductionOfManifestation'_period_'en = _prefixId.prefix "reproductionOfManifestation.en"

    let resolution'_period_'en = _prefixId.prefix "resolution.en"

    let restrictionsOnAccessToManifestation'_period_'en = _prefixId.prefix "restrictionsOnAccessToManifestation.en"

    let restrictionsOnUseOfManifestation'_period_'en = _prefixId.prefix "restrictionsOnUseOfManifestation.en"

    let reviewedInManifestation'_period_'en = _prefixId.prefix "reviewedInManifestation.en"

    let seriesStatement'_period_'en = _prefixId.prefix "seriesStatement.en"
    let soundCharacteristic'_period_'en = _prefixId.prefix "soundCharacteristic.en"
    let specialIssue'_period_'en = _prefixId.prefix "specialIssue.en"
    let specialIssueOf'_period_'en = _prefixId.prefix "specialIssueOf.en"

    let specialPlaybackCharacteristic'_period_'en = _prefixId.prefix "specialPlaybackCharacteristic.en"

    let statementOfResponsibility'_period_'en = _prefixId.prefix "statementOfResponsibility.en"

    let statementOfResponsibilityRelatingToANamedRevisionOfAnEdition'_period_'en = _prefixId.prefix "statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en"

    let statementOfResponsibilityRelatingToSeries'_period_'en = _prefixId.prefix "statementOfResponsibilityRelatingToSeries.en"

    let statementOfResponsibilityRelatingToSubseries'_period_'en = _prefixId.prefix "statementOfResponsibilityRelatingToSubseries.en"

    let statementOfResponsibilityRelatingToTheEdition'_period_'en = _prefixId.prefix "statementOfResponsibilityRelatingToTheEdition.en"

    let statementOfResponsibilityRelatingToTitleProper'_period_'en = _prefixId.prefix "statementOfResponsibilityRelatingToTitleProper.en"

    let subjectOfManifestation'_period_'en = _prefixId.prefix "subjectOfManifestation.en"

    let tapeConfiguration'_period_'en = _prefixId.prefix "tapeConfiguration.en"
    let termsOfAvailability'_period_'en = _prefixId.prefix "termsOfAvailability.en"
    let title'_period_'en = _prefixId.prefix "title.en"
    let titleProper'_period_'en = _prefixId.prefix "titleProper.en"
    let titleProperOfSeries'_period_'en = _prefixId.prefix "titleProperOfSeries.en"

    let titleProperOfSubseries'_period_'en = _prefixId.prefix "titleProperOfSubseries.en"

    let trackConfiguration'_period_'en = _prefixId.prefix "trackConfiguration.en"
    let typeOfRecording'_period_'en = _prefixId.prefix "typeOfRecording.en"

    let uniformResourceLocator'_period_'en = _prefixId.prefix "uniformResourceLocator.en"

    let variantTitle'_period_'en = _prefixId.prefix "variantTitle.en"
    let videoCharacteristic'_period_'en = _prefixId.prefix "videoCharacteristic.en"
    let videoFormat'_period_'en = _prefixId.prefix "videoFormat.en"

    let wholePartManifestationRelationship'_period_'en = _prefixId.prefix "wholePartManifestationRelationship.en"

    let workManifested'_period_'en = _prefixId.prefix "workManifested.en"
