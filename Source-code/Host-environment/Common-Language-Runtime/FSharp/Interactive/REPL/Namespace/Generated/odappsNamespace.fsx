#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module odapps =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/odapps#" "odapps"

    /// <summary>
    ///   <para>rdfs:comment : An App Concept describes an idea for an application (a digital work) which refers to Open Data.</para>
    ///   <para>rdfs:label : Application Concept</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#AppConcept">odapps:AppConcept</a>
    /// </summary>
    let AppConcept = _prefixId.prefix "AppConcept"
    /// <summary>
    ///   <para>rdfs:comment : An App Concept implementation.^^xsd:string</para>
    ///   <para>rdfs:label : Application</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#Application">odapps:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>rdfs:label : Tool.</para>
    ///   <para>rdfs:comment : The tool or library used to build the application.</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#Tool">odapps:Tool</a>
    /// </summary>
    let Tool = _prefixId.prefix "Tool"
    /// <summary>
    ///   <para>rdfs:label : comment</para>
    ///   <para>rdfs:comment : comment on the application and the Concept^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#comment">odapps:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:comment : The Agent which conceived the idea about the App Concept^^xsd:string</para>
    ///   <para>rdfs:label : conceived by^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#conceived">odapps:conceived</a>
    /// </summary>
    let conceived = _prefixId.prefix "conceived"
    /// <summary>
    ///   <para>rdfs:label : consumes</para>
    ///   <para>rdfs:comment : links to the dataset used to make the application, and could be of different types or formats^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#consumes">odapps:consumes</a>
    /// </summary>
    let consumes = _prefixId.prefix "consumes"
    /// <summary>
    ///   <para>rdfs:label : dataset description</para>
    ///   <para>rdfs:comment : Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc.</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#datasetDescription">odapps:datasetDescription</a>
    /// </summary>
    let datasetDescription = _prefixId.prefix "datasetDescription"
    /// <summary>
    ///   <para>rdfs:label : demo uri</para>
    ///   <para>rdfs:comment : Property for a given demo of the application and/or the Concept.</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#demoUri">odapps:demoUri</a>
    /// </summary>
    let demoUri = _prefixId.prefix "demoUri"
    /// <summary>
    ///   <para>rdfs:label : Concept and/or Application description</para>
    ///   <para>rdfs:comment : Property for a given descriptive informations of the concept and/or the application.</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#description">odapps:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : download url</para>
    ///   <para>rdfs:comment : This property links to the application</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#downloadUrl">odapps:downloadUrl</a>
    /// </summary>
    let downloadUrl = _prefixId.prefix "downloadUrl"
    /// <summary>
    ///   <para>rdfs:comment : The App Concept that this application implements</para>
    ///   <para>rdfs:label : implements</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#implements">odapps:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:comment : The Agent which conceived the idea about the App Concept (the instigator/initiator).</para>
    ///   <para>rdfs:label : instigator</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#instigator">odapps:instigator</a>
    /// </summary>
    let instigator = _prefixId.prefix "instigator"
    /// <summary>
    ///   <para>rdfs:label : dataset description</para>
    ///   <para>rdfs:comment : The keywords of the Application.</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#keyword">odapps:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : has license</para>
    ///   <para>rdfs:comment : This property links to the license of the application^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#license">odapps:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:comment : The Agent which revised / extended the idea about the App Concept.</para>
    ///   <para>rdfs:label : revised</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#revised">odapps:revised</a>
    /// </summary>
    let revised = _prefixId.prefix "revised"
    /// <summary>
    ///   <para>rdfs:comment : An App concept which was revised and re-posed / extended. ^^xsd:string</para>
    ///   <para>rdfs:label : revision of^^xsd:string</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#revision">odapps:revision</a>
    /// </summary>
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>rdfs:label : url</para>
    ///   <para>rdfs:comment : This property links to the application</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#url">odapps:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : usesTool</para>
    ///   <para>rdfs:comment : This property links to the tools or libraries used for the application</para>
    ///   <a href="http://semweb.mmlab.be/ns/odapps#usesTool">odapps:usesTool</a>
    /// </summary>
    let usesTool = _prefixId.prefix "usesTool"
