#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dsv =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dsv#" "dsv"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Konceptuální modelrdfs:label : Application Profile</para>
    ///   <para>rdfs:comment : Konceptuální model obsahující profily tříd a vlastností různých slovníků.rdfs:comment : An Application Profile identifies classes and properties from vocabularies, and class profiles and property profiles from Application profiles that are re-used in a certain usage context. It also allows specification editors to further adjust the description of re-used classes and properties for that usage context without the need to explicitly create subclasses and subproperties.</para>
    ///   <a href="https://w3id.org/dsv#ApplicationProfile">dsv:ApplicationProfile</a>
    /// </summary>
    let ApplicationProfile = _prefixId.prefix "ApplicationProfile"

    /// <summary>
    ///   <para>rdfs:label : Application Profile Specification Document</para>
    ///   <para>rdfs:comment : An Application Profile Specification Document contains human-readable version of an Application Profile.</para>
    ///   <a href="https://w3id.org/dsv#ApplicationProfileSpecificationDocument">dsv:ApplicationProfileSpecificationDocument</a>
    /// </summary>
    let ApplicationProfileSpecificationDocument =
        _prefixId.prefix "ApplicationProfileSpecificationDocument"

    /// <summary>
    ///   <para>rdfs:label : Profil třídyrdfs:label : Class Profile</para>
    ///   <para>rdfs:comment : Profile of a class. Allows specification editors to specify profile specific names, definitions and usage notes.</para>
    ///   <a href="https://w3id.org/dsv#ClassProfile">dsv:ClassProfile</a>
    /// </summary>
    let ClassProfile = _prefixId.prefix "ClassProfile"
    /// <summary>
    ///   <para>rdfs:label : Profile atributurdfs:label : Datatype Property Profile</para>
    ///   <a href="https://w3id.org/dsv#DatatypePropertyProfile">dsv:DatatypePropertyProfile</a>
    /// </summary>
    let DatatypePropertyProfile = _prefixId.prefix "DatatypePropertyProfile"
    /// <summary>
    ///   <para>rdfs:label : Nevalidní profilrdfs:label : Invalid Term Profile</para>
    ///   <para>rdfs:comment : Neplatný profil je profil, který porušuje pravidla pro správné profilování. To může být z dobrého důvodu, jako je dočasná nekonzistence, která se má teprve projevit na profilované entitě.rdfs:comment : Invalid Term Profile is a profile, which breaks profile compliance rules. This may be for a good reason such as temporary, to be propagated upstream, inconsistency.</para>
    ///   <a href="https://w3id.org/dsv#InvalidTermProfile">dsv:InvalidTermProfile</a>
    /// </summary>
    let InvalidTermProfile = _prefixId.prefix "InvalidTermProfile"
    /// <summary>
    ///   <para>rdfs:label : Profil objektové vlastnostirdfs:label : Object Property Profile</para>
    ///   <a href="https://w3id.org/dsv#ObjectPropertyProfile">dsv:ObjectPropertyProfile</a>
    /// </summary>
    let ObjectPropertyProfile = _prefixId.prefix "ObjectPropertyProfile"
    /// <summary>
    ///   <para>rdfs:label : Profil vlastnostirdfs:label : Property Profile</para>
    ///   <para>rdfs:comment : Profile of a property allows specification editors to specify profile specific name, definition, usage note, domain, range and cardinality.</para>
    ///   <a href="https://w3id.org/dsv#PropertyProfile">dsv:PropertyProfile</a>
    /// </summary>
    let PropertyProfile = _prefixId.prefix "PropertyProfile"
    /// <summary>
    ///   <para>rdfs:label : Property Value Reuse</para>
    ///   <para>rdfs:comment : Specifies, which values of which properties of which resources are reused for the current Profile.
    /// E.g. reuse of profile name, reuse of class name, reuse of profile definition, reuse of profile usage note, etc.</para>
    ///   <a href="https://w3id.org/dsv#PropertyValueReuse">dsv:PropertyValueReuse</a>
    /// </summary>
    let PropertyValueReuse = _prefixId.prefix "PropertyValueReuse"
    /// <summary>
    ///   <para>rdfs:label : Profilrdfs:label : Term Profile</para>
    ///   <para>rdfs:comment : Profil entity. Umožňuje blíže specifikovat některé její vlastnost v kontextu aplikačního profilu.rdfs:comment : Term profile. Allows profile editors to specify context dependent information such as label, definition, usage note, cardinalities, etc. for Class profiles and Property profiles.</para>
    ///   <a href="https://w3id.org/dsv#TermProfile">dsv:TermProfile</a>
    /// </summary>
    let TermProfile = _prefixId.prefix "TermProfile"

    /// <summary>
    ///   <para>rdfs:label : Vocabulary Specification Document</para>
    ///   <para>rdfs:comment : A Vocabulary Specification Document is a human-readable representation of a Vocabulary.</para>
    ///   <a href="https://w3id.org/dsv#VocabularySpecificationDocument">dsv:VocabularySpecificationDocument</a>
    /// </summary>
    let VocabularySpecificationDocument =
        _prefixId.prefix "VocabularySpecificationDocument"

    /// <summary>
    ///   <para>rdfs:label : kardinalitardfs:label : cardinality</para>
    ///   <a href="https://w3id.org/dsv#cardinality">dsv:cardinality</a>
    /// </summary>
    let cardinality = _prefixId.prefix "cardinality"
    /// <summary>
    ///   <para>rdfs:label : profiled class</para>
    ///   <para>rdfs:comment : The profiled class.</para>
    ///   <a href="https://w3id.org/dsv#class">dsv:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : class role</para>
    ///   <para>rdfs:comment : Class role, e.g. Mandatory, Supportive, etc.</para>
    ///   <a href="https://w3id.org/dsv#classRole">dsv:classRole</a>
    /// </summary>
    let classRole = _prefixId.prefix "classRole"
    /// <summary>
    ///   <para>rdfs:label : datatype</para>
    ///   <a href="https://w3id.org/dsv#datatype">dsv:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    /// <summary>
    ///   <para>rdfs:label : domain</para>
    ///   <para>rdfs:comment : Class profile, which is the domain of the property profile.</para>
    ///   <a href="https://w3id.org/dsv#domain">dsv:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:label : external documentation</para>
    ///   <para>rdfs:comment : Link to an external documentation of this resource. Profiles of this resource should preferably link to this URL for documentation.</para>
    ///   <a href="https://w3id.org/dsv#externalDocumentation">dsv:externalDocumentation</a>
    /// </summary>
    let externalDocumentation = _prefixId.prefix "externalDocumentation"
    /// <summary>
    ///   <para>rdfs:label : profile of</para>
    ///   <para>rdfs:comment : Specifies a parent profile of the current profile.</para>
    ///   <a href="https://w3id.org/dsv#profileOf">dsv:profileOf</a>
    /// </summary>
    let profileOf = _prefixId.prefix "profileOf"
    /// <summary>
    ///   <para>rdfs:label : profiled property</para>
    ///   <para>rdfs:comment : The property profiled by the property profile.</para>
    ///   <a href="https://w3id.org/dsv#property">dsv:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : range</para>
    ///   <para>rdfs:comment : Class profile, which is the range of the object property profile.</para>
    ///   <a href="https://w3id.org/dsv#range">dsv:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:label : requirement level</para>
    ///   <para>rdfs:comment : Requirement level of the property, typically mandatory, recommended or optional.</para>
    ///   <a href="https://w3id.org/dsv#requirementLevel">dsv:requirementLevel</a>
    /// </summary>
    let requirementLevel = _prefixId.prefix "requirementLevel"
    /// <summary>
    ///   <para>rdfs:label : reused from resource</para>
    ///   <para>rdfs:comment : The Resource on which there is a property with a value for reuse.</para>
    ///   <a href="https://w3id.org/dsv#reusedFromResource">dsv:reusedFromResource</a>
    /// </summary>
    let reusedFromResource = _prefixId.prefix "reusedFromResource"
    /// <summary>
    ///   <para>rdfs:label : reused property</para>
    ///   <a href="https://w3id.org/dsv#reusedProperty">dsv:reusedProperty</a>
    /// </summary>
    let reusedProperty = _prefixId.prefix "reusedProperty"
    /// <summary>
    ///   <para>rdfs:label : reuses property value</para>
    ///   <para>rdfs:comment : Points to definitions of Property value reuse for this Profile.</para>
    ///   <a href="https://w3id.org/dsv#reusesPropertyValue">dsv:reusesPropertyValue</a>
    /// </summary>
    let reusesPropertyValue = _prefixId.prefix "reusesPropertyValue"
    /// <summary>
    ///   <para>rdfs:label : specializes</para>
    ///   <para>rdfs:comment : Specifies a profile specialized by this profile.</para>
    ///   <a href="https://w3id.org/dsv#specializes">dsv:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
