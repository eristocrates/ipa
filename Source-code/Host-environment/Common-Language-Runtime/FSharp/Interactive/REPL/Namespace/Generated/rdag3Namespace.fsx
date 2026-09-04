#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdag3 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdvocab.info/ElementsGr3/" "rdag3"

    /// <summary>
    ///   <para>skos:definition : An annotation that might be helpful to those using or revising the authorized access point representing an entity or relationship data, or creating an authorized access point representing a related entity.</para>
    ///   <para>rdfs:label : Cataloguer's note</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cataloguersNote</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/cataloguersNote">rdag3:cataloguersNote</a>
    /// </summary>
    let cataloguersNote = _prefixId.prefix "cataloguersNote"
    /// <summary>
    ///   <para>rdfs:label : Identifier for the concept</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheConcept</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/identifierForTheConcept">rdag3:identifierForTheConcept</a>
    /// </summary>
    let identifierForTheConcept = _prefixId.prefix "identifierForTheConcept"
    /// <summary>
    ///   <para>rdfs:label : Identifier for the event</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheEvent</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/identifierForTheEvent">rdag3:identifierForTheEvent</a>
    /// </summary>
    let identifierForTheEvent = _prefixId.prefix "identifierForTheEvent"
    /// <summary>
    ///   <para>rdfs:label : Identifier for the object</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheObject</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/identifierForTheObject">rdag3:identifierForTheObject</a>
    /// </summary>
    let identifierForTheObject = _prefixId.prefix "identifierForTheObject"
    /// <summary>
    ///   <para>rdfs:label : Identifier for the place</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForThePlace</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/identifierForThePlace">rdag3:identifierForThePlace</a>
    /// </summary>
    let identifierForThePlace = _prefixId.prefix "identifierForThePlace"
    /// <summary>
    ///   <para>rdfs:label : Name of the event</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheEvent</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/nameOfTheEvent">rdag3:nameOfTheEvent</a>
    /// </summary>
    let nameOfTheEvent = _prefixId.prefix "nameOfTheEvent"
    /// <summary>
    ///   <para>rdfs:label : Name of the object</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheObject</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/nameOfTheObject">rdag3:nameOfTheObject</a>
    /// </summary>
    let nameOfTheObject = _prefixId.prefix "nameOfTheObject"
    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters by which a place is known.</para>
    ///   <para>rdfs:label : Name of the place</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfThePlace</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/nameOfThePlace">rdag3:nameOfThePlace</a>
    /// </summary>
    let nameOfThePlace = _prefixId.prefix "nameOfThePlace"
    /// <summary>
    ///   <para>rdfs:label : Preferred name for the event</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheEvent</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/preferredNameForTheEvent">rdag3:preferredNameForTheEvent</a>
    /// </summary>
    let preferredNameForTheEvent = _prefixId.prefix "preferredNameForTheEvent"
    /// <summary>
    ///   <para>rdfs:label : Preferred name for the object</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheObject</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/preferredNameForTheObject">rdag3:preferredNameForTheObject</a>
    /// </summary>
    let preferredNameForTheObject = _prefixId.prefix "preferredNameForTheObject"
    /// <summary>
    ///   <para>skos:definition : The name or form of name chosen to represent a place when a place name is used as the conventional name of a government, etc., or as an addition to the name of a corporate body, a conference, etc., or a work, or when recording a place associated with a person, family, or corporate body.</para>
    ///   <para>rdfs:label : Preferred name for the place</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForThePlace</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/preferredNameForThePlace">rdag3:preferredNameForThePlace</a>
    /// </summary>
    let preferredNameForThePlace = _prefixId.prefix "preferredNameForThePlace"
    /// <summary>
    ///   <para>rdfs:label : Preferred term for the concept</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredTermForTheConcept</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/preferredTermForTheConcept">rdag3:preferredTermForTheConcept</a>
    /// </summary>
    let preferredTermForTheConcept = _prefixId.prefix "preferredTermForTheConcept"
    /// <summary>
    ///   <para>skos:definition : A resource used in determining the name, title, or other identifying attributes of an entity, or in determining the relationship between entities.</para>
    ///   <para>rdfs:label : Source consulted</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sourceConsulted</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/sourceConsulted">rdag3:sourceConsulted</a>
    /// </summary>
    let sourceConsulted = _prefixId.prefix "sourceConsulted"
    /// <summary>
    ///   <para>skos:definition : A resource used in determining the name, title, or other identifying attributes of an entity, or in determining the relationship between entities.</para>
    ///   <para>rdfs:label : Status of identification</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statusOfIdentification</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/statusOfIdentification">rdag3:statusOfIdentification</a>
    /// </summary>
    let statusOfIdentification = _prefixId.prefix "statusOfIdentification"
    /// <summary>
    ///   <para>rdfs:label : Term for the concept</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : termForTheConcept</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/termForTheConcept">rdag3:termForTheConcept</a>
    /// </summary>
    let termForTheConcept = _prefixId.prefix "termForTheConcept"
    /// <summary>
    ///   <para>rdfs:label : Variant name for the event</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheEvent</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/variantNameForTheEvent">rdag3:variantNameForTheEvent</a>
    /// </summary>
    let variantNameForTheEvent = _prefixId.prefix "variantNameForTheEvent"
    /// <summary>
    ///   <para>rdfs:label : Variant name for the object</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheObject</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/variantNameForTheObject">rdag3:variantNameForTheObject</a>
    /// </summary>
    let variantNameForTheObject = _prefixId.prefix "variantNameForTheObject"
    /// <summary>
    ///   <para>rdfs:label : Variant name for the place</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForThePlace</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/variantNameForThePlace">rdag3:variantNameForThePlace</a>
    /// </summary>
    let variantNameForThePlace = _prefixId.prefix "variantNameForThePlace"
    /// <summary>
    ///   <para>rdfs:label : Variant term for the concept</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTermForTheConcept</para>
    ///   <a href="http://rdvocab.info/ElementsGr3/variantTermForTheConcept">rdag3:variantTermForTheConcept</a>
    /// </summary>
    let variantTermForTheConcept = _prefixId.prefix "variantTermForTheConcept"
