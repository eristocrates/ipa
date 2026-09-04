#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdac =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/c/" "rdac"

    let _namespaceIri = _prefixId.prefix ""
    let ``Agent.en`` = _prefixId.prefix "Agent.en"
    /// <summary>
    ///   <para>skos:definition : A distinct intellectual or artistic creation (i.e., the intellectual or artistic content).</para>
    ///   <para>rdfs:label : Work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Work</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10001">rdac:C10001</a>
    /// </summary>
    let C10001 = _prefixId.prefix "C10001"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Agent</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10002">rdac:C10002</a>
    /// </summary>
    let C10002 = _prefixId.prefix "C10002"
    /// <summary>
    ///   <para>skos:definition : A single exemplar or instance of a manifestation.</para>
    ///   <para>rdfs:label : Item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Item</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10003">rdac:C10003</a>
    /// </summary>
    let C10003 = _prefixId.prefix "C10003"
    /// <summary>
    ///   <para>skos:definition : An individual or an identity established by an individual (either alone or in collaboration with one or more other individuals).</para>
    ///   <para>rdfs:label : Person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Person</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10004">rdac:C10004</a>
    /// </summary>
    let C10004 = _prefixId.prefix "C10004"
    /// <summary>
    ///   <para>skos:definition : An organization or group of persons and/or organizations that is identified by a particular name and that acts, or may act, as a unit.</para>
    ///   <para>rdfs:label : Corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : CorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10005">rdac:C10005</a>
    /// </summary>
    let C10005 = _prefixId.prefix "C10005"
    /// <summary>
    ///   <para>skos:definition : The intellectual or artistic realization of a work in the form of alpha-numeric, musical or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.</para>
    ///   <para>rdfs:label : Expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Expression</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10006">rdac:C10006</a>
    /// </summary>
    let C10006 = _prefixId.prefix "C10006"
    /// <summary>
    ///   <para>skos:definition : The physical embodiment of an expression of a work.</para>
    ///   <para>rdfs:label : Manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Manifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10007">rdac:C10007</a>
    /// </summary>
    let C10007 = _prefixId.prefix "C10007"
    /// <summary>
    ///   <para>skos:definition : Two or more persons related by birth, marriage, adoption, civil union, or similar legal status, or who otherwise present themselves as a family.</para>
    ///   <para>rdfs:label : Family</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Family</para>
    ///   <a href="http://rdaregistry.info/Elements/c/C10008">rdac:C10008</a>
    /// </summary>
    let C10008 = _prefixId.prefix "C10008"
    let ``CorporateBody.en`` = _prefixId.prefix "CorporateBody.en"
    let ``Expression.en`` = _prefixId.prefix "Expression.en"
    let ``Family.en`` = _prefixId.prefix "Family.en"
    let ``Item.en`` = _prefixId.prefix "Item.en"
    let ``Manifestation.en`` = _prefixId.prefix "Manifestation.en"
    let ``Person.en`` = _prefixId.prefix "Person.en"
    let ``Work.en`` = _prefixId.prefix "Work.en"
