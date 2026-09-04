#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module r4r =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://guava.iis.sinica.edu.tw/r4r/" "r4r"

    /// <summary>
    ///   <para>r4r:Definition : An object is presented mainly as textual form but not exclusively. It is not limited for representing research publications only, and may be presented in a variety of article formats such as: blog articles, encyclopedia articles (a primary division of encyclopedia content; Wikipedia entry pages), Usenet or web forum articles, even non-textual based resources like spoken articles (articles produced in the forms of video clips and audio recordings such as Vlogs/Video blogs, podcasts and audiobooks) are such cases.^^xsd:string</para>
    ///   <para>rdfs:label : Article^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/article^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/Article">r4r:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>r4r:Definition : Any collection of computer instructions is written in human-readable computer language, and served for programming and executing the Data of RRObject.^^xsd:string</para>
    ///   <para>rdfs:label : Code^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/code^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/Code">r4r:Code</a>
    /// </summary>
    let Code = _prefixId.prefix "Code"
    /// <summary>
    ///   <para>r4r:Definition : Data is presented in a structure form such as dataset, algorithms, models, metadata schema or ontologies. There are other forms of data, for instance, tables, figures or nanopublication. Other text based supplement materials like review, comments, and feedbacks are also included.^^xsd:string</para>
    ///   <para>rdfs:label : Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/data^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/Data">r4r:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    let Definition = _prefixId.prefix "Definition"
    /// <summary>
    ///   <para>r4r:Definition : The authorization of the use and reuse of the referred resource, as well as the document recording that authorization.^^xsd:string</para>
    ///   <para>rdfs:label : License^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/license^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/License">r4r:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    /// <summary>
    ///   <para>r4r:Definition : metadata, metadata about metadata, or version information. Descriptive metadata can be represented as part of the Provenance.^^xsd:string</para>
    ///   <para>rdfs:label : Provenance^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/provenance^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/Provenance">r4r:Provenance</a>
    /// </summary>
    let Provenance = _prefixId.prefix "Provenance"
    /// <summary>
    ///   <para>r4r:Definition : Any resource served as a component for publication and reusing is defined as a Reusing Related Object (RRObject). It can be a knowledge unit for research purposes, or any resource that has relations similar to the relations between article, data and code.^^xsd:string</para>
    ///   <para>rdfs:label : RRObject^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/rrobject^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/RRObject">r4r:RRObject</a>
    /// </summary>
    let RRObject = _prefixId.prefix "RRObject"
    /// <summary>
    ///   <para>r4r:Definition : Any mechanism designed for relating to RRObject for reusing purposes is defined as a Reusing Related Policy (RRPolicy). RRPolicy is free to be extended for more issues such as security and trust for its subclasses concepts.^^xsd:string</para>
    ///   <para>rdfs:label : RRPolicy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/rrpolicy^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/RRPolicy">r4r:RRPolicy</a>
    /// </summary>
    let RRPolicy = _prefixId.prefix "RRPolicy"
    /// <summary>
    ///   <para>r4r:Definition : Any resource (A) is referenced by any other resource (B) only when the publication time of A is equal to B. .cites. is used to describe this relation. When it is used as the basic relation description for resource publication, r4r:Cites can be used to describe relations between article, data, or code of RRObject. When it is used for reusing context, r4r:Cites relates any resource that reuses RRObject for citation, and the reusing context is enriched by the packaging of RRPolicy.^^xsd:string</para>
    ///   <para>rdfs:label : cites^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/cites^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/cites">r4r:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>r4r:Definition : It declares the use of license information for RRObject and its subclass when RRPolicy is not ready to use. It is used as the basic relation description for resource publication.^^xsd:string</para>
    ///   <para>rdfs:label : hasLicense^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/haslicense^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/hasLicense">r4r:hasLicense</a>
    /// </summary>
    let hasLicense = _prefixId.prefix "hasLicense"
    /// <summary>
    ///   <para>r4r:Definition : It is used for relating subclass of RRObject to its provenance information when RRPolicy is not ready to use. It is used as the basic relation description for resource publication.^^xsd:string</para>
    ///   <para>rdfs:label : hasProvenance^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/hasprovenance^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/hasProvenance">r4r:hasProvenance</a>
    /// </summary>
    let hasProvenance = _prefixId.prefix "hasProvenance"
    /// <summary>
    ///   <para>r4r:Definition : It describes the creation time of the RRObject. It is used as the basic relation description for resource publication and reusing. A complete R4R resource representation (RRObject isPackagedWith RRPolicy) shares the same property, r4r:locateAt with RRObject.^^xsd:string</para>
    ///   <para>rdfs:label : hasTime^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/hastime
    /// ^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/hasTime">r4r:hasTime</a>
    /// </summary>
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>rdfs:label : isCitedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/iscitedby^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/isCitedBy">r4r:isCitedBy</a>
    /// </summary>
    let isCitedBy = _prefixId.prefix "isCitedBy"
    /// <summary>
    ///   <para>r4r:Definition : It is used for relating RRObject and RRPolicy for accomplishing a particular component, RRPolicy. This relation is served for the reusing context.^^xsd:string</para>
    ///   <para>rdfs:label : isPackagedWith^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/ispackagedwith^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/isPackagedWith">r4r:isPackagedWith</a>
    /// </summary>
    let isPackagedWith = _prefixId.prefix "isPackagedWith"
    /// <summary>
    ///   <para>r4r:Definition : It describes partial relationships with temporal and spatial constraints, and carries with it some characteristics such as being transitive. A isPartOf B only if A and B share the same time and location. Data can be part of data; code can be part of code or data; data like keywords or sentences can also be described as part of the Article; metadata can be part of provenance as long as two objects carry partial and transitive relations.^^xsd:string</para>
    ///   <para>rdfs:label : isPartOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://guava.iis.sinica.edu.tw/r4r/ispartof^^xsd:anyURI</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/isPartOf">r4r:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>r4r:Definition : It is used to relate a machine-readable representation of the RRObject's identification, such as DOI, URI, URL, etc. It is used as the basic relation description for resource publication and reusing. A complete R4R resource representation (RRObject isPackagedWith RRPolicy) shares the same property, r4r:locateAt with RRObject.^^xsd:string</para>
    ///   <para>rdfs:label : locateAt^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/TR/rdf-schema/#ch_resource^^xsd:string</para>
    ///   <a href="http://guava.iis.sinica.edu.tw/r4r/locateAt">r4r:locateAt</a>
    /// </summary>
    let locateAt = _prefixId.prefix "locateAt"
