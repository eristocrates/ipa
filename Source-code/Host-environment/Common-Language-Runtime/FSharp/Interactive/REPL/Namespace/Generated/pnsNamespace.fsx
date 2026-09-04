#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pns =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.press.net/ontology/stuff/" "pns"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A base class for all intangible stuff (eg love, conservatism, fashion)</para>
    ///   <para>rdfs:label : A base class for Intangible Stuff</para>
    ///   <a href="http://data.press.net/ontology/stuff/Intangible">pns:Intangible</a>
    /// </summary>
    let Intangible = _prefixId.prefix "Intangible"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A Location - a base class for Locations. Also a subclass of geo:SpatialThing</para>
    ///   <para>rdfs:label : A Location - a base class for Locations</para>
    ///   <a href="http://data.press.net/ontology/stuff/Location">pns:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : An Organization - a base class for instances of organizations. Also a subclass of foaf:Organization</para>
    ///   <para>rdfs:label : An Organization - a base class for instances of organizations</para>
    ///   <a href="http://data.press.net/ontology/stuff/Organization">pns:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A Person - a base class for people instances. Also a subclass of foaf:Person</para>
    ///   <para>rdfs:label : A Person - a base class for people instances.</para>
    ///   <a href="http://data.press.net/ontology/stuff/Person">pns:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Generic Stuff Class  - a base class for all domain stuff</para>
    ///   <para>rdfs:label : Generic Stuff Class</para>
    ///   <a href="http://data.press.net/ontology/stuff/Stuff">pns:Stuff</a>
    /// </summary>
    let Stuff = _prefixId.prefix "Stuff"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A base class for all tangible stuff (eg people, places, physical things)</para>
    ///   <para>rdfs:label : A base Class for Tangible Stuff</para>
    ///   <a href="http://data.press.net/ontology/stuff/Tangible">pns:Tangible</a>
    /// </summary>
    let Tangible = _prefixId.prefix "Tangible"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : String property that indicates an alias of a Stuff instance. For example 'Television' might have an alias of 'TV'.</para>
    ///   <para>rdfs:label : An alias label of a Stuff instance</para>
    ///   <a href="http://data.press.net/ontology/stuff/alias">pns:alias</a>
    /// </summary>
    let alias = _prefixId.prefix "alias"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : String property that indicates the definitive description of a Stuff instance.</para>
    ///   <para>rdfs:label : The definitive description of a Stuff instance</para>
    ///   <a href="http://data.press.net/ontology/stuff/comment">pns:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : A person's date of birth</para>
    ///   <para>rdfs:comment : Property of a Person. A person's date of birth</para>
    ///   <a href="http://data.press.net/ontology/stuff/dateOfBirth">pns:dateOfBirth</a>
    /// </summary>
    let dateOfBirth = _prefixId.prefix "dateOfBirth"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : A person's date of death</para>
    ///   <para>rdfs:comment : Property of a Person. A person's date of death</para>
    ///   <a href="http://data.press.net/ontology/stuff/dateOfDeath">pns:dateOfDeath</a>
    /// </summary>
    let dateOfDeath = _prefixId.prefix "dateOfDeath"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates assets directly with domain entities, e.g. official biography, corporate logo</para>
    ///   <para>rdfs:label : Property that associates assets directly with domain entities.</para>
    ///   <a href="http://data.press.net/ontology/stuff/hasAsset">pns:hasAsset</a>
    /// </summary>
    let hasAsset = _prefixId.prefix "hasAsset"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates images with domain entities, e.g. official photograph, corporate logo</para>
    ///   <para>rdfs:label : Property that associates images with domain entities.</para>
    ///   <a href="http://data.press.net/ontology/stuff/hasImage">pns:hasImage</a>
    /// </summary>
    let hasImage = _prefixId.prefix "hasImage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : String property that indicates the definitive label of a Stuff instance. This might be the full name of a Person, Organization or something Intangible</para>
    ///   <para>rdfs:label : The definitive label of a Stuff instance</para>
    ///   <a href="http://data.press.net/ontology/stuff/label">pns:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : String property that indicates the long name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Manchester United F.C.'</para>
    ///   <para>rdfs:label : A long name of a Person or Organization</para>
    ///   <a href="http://data.press.net/ontology/stuff/longName">pns:longName</a>
    /// </summary>
    let longName = _prefixId.prefix "longName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : String property that indicates the definitive full name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label</para>
    ///   <para>rdfs:label : The definitive name of a Person or Organization</para>
    ///   <a href="http://data.press.net/ontology/stuff/name">pns:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Property that notably associates stuff together</para>
    ///   <para>rdfs:comment : Property that notably associates stuff together, for example Karl Lagerfeld is notably associated with Fashion</para>
    ///   <a href="http://data.press.net/ontology/stuff/notablyAssociatedWith">pns:notablyAssociatedWith</a>
    /// </summary>
    let notablyAssociatedWith = _prefixId.prefix "notablyAssociatedWith"
    let parentLocation = _prefixId.prefix "parentLocation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : A person's place of birth</para>
    ///   <para>rdfs:comment : Property of a Person. A person's place of birth</para>
    ///   <a href="http://data.press.net/ontology/stuff/placeOfBirth">pns:placeOfBirth</a>
    /// </summary>
    let placeOfBirth = _prefixId.prefix "placeOfBirth"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : String property that indicates the short name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Man Utd'</para>
    ///   <para>rdfs:label : A short name of a Person or Organization</para>
    ///   <a href="http://data.press.net/ontology/stuff/shortName">pns:shortName</a>
    /// </summary>
    let shortName = _prefixId.prefix "shortName"
