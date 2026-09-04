#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdafrbr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdvocab.info/uri/schema/FRBRentitiesRDA/" "rdafrbr"

    /// <summary>
    ///   <para>skos:scopeNote : Based on FRBRoo/CIDOC-CRM concept of E39 Actor as agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Agent</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Agent">rdafrbr:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>skos:definition : An abstract notion or idea.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Concept</para>
    ///   <para>rdfs:label : Concept</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Concept">rdafrbr:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>skos:definition : An organization or group of individuals and/or organizations acting as a unit.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : CorporateBody</para>
    ///   <para>rdfs:label : Corporate Body</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/CorporateBody">rdafrbr:CorporateBody</a>
    /// </summary>
    let CorporateBody = _prefixId.prefix "CorporateBody"
    /// <summary>
    ///   <para>skos:definition : An action or occurrence.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Event</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Event">rdafrbr:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>skos:definition : The intellectual or artistic realization of a work in the form of alpha-numeric, musical, or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Expression</para>
    ///   <para>rdfs:label : Expression</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Expression">rdafrbr:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Family</para>
    ///   <para>rdfs:label : Family</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Family">rdafrbr:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>skos:definition : A single exemplar of a manifestation. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Item</para>
    ///   <para>rdfs:label : Item</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Item">rdafrbr:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>skos:definition : The physical embodiment of an expression of a work. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Manifestation</para>
    ///   <para>rdfs:label : Manifestation</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Manifestation">rdafrbr:Manifestation</a>
    /// </summary>
    let Manifestation = _prefixId.prefix "Manifestation"
    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters by which a person, family, or corporate body is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Name</para>
    ///   <para>rdfs:label : Name</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Name">rdafrbr:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>skos:definition : A material thing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Object</para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Object">rdafrbr:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>skos:definition : An individual.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Person</para>
    ///   <para>rdfs:label : Person</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Person">rdafrbr:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>skos:definition : A location.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Place</para>
    ///   <para>rdfs:label : Place</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Place">rdafrbr:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Subject</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Subject">rdafrbr:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>skos:definition : A distinct intellectual or artistic creation. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Work</para>
    ///   <para>rdfs:label : Work</para>
    ///   <a href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Work">rdafrbr:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
