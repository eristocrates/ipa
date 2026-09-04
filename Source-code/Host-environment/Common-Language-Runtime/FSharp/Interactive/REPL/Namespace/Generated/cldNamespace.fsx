#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cld =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/cld/terms/" "cld"
    let _namespaceIri = _prefixId.prefix ""
    let AccrualMethod = _prefixId.prefix "AccrualMethod"
    let AccrualPolicy = _prefixId.prefix "AccrualPolicy"
    let CDType = _prefixId.prefix "CDType"
    let Frequency = _prefixId.prefix "Frequency"
    let RKMS_ISO8601 = _prefixId.prefix "RKMS-ISO8601"
    /// <summary>
    ///   <para>rdfs:comment : A second collection that is associated with the current collection.</para>
    ///   <para>rdfs:label : Associated Collection</para>
    ///   <a href="http://purl.org/cld/terms/associatedCollection">cld:associatedCollection</a>
    /// </summary>
    let associatedCollection = _prefixId.prefix "associatedCollection"
    /// <summary>
    ///   <para>rdfs:comment : A catalogue for, or index of, the collection.</para>
    ///   <para>rdfs:label : Catalogue or Index</para>
    ///   <a href="http://purl.org/cld/terms/catalogueOrIndex">cld:catalogueOrIndex</a>
    /// </summary>
    let catalogueOrIndex = _prefixId.prefix "catalogueOrIndex"
    /// <summary>
    ///   <para>rdfs:comment : A range of dates over which the individual items within the collection were created.</para>
    ///   <para>rdfs:label : Date Items Created</para>
    ///   <a href="http://purl.org/cld/terms/dateItemsCreated">cld:dateItemsCreated</a>
    /// </summary>
    let dateItemsCreated = _prefixId.prefix "dateItemsCreated"
    /// <summary>
    ///   <para>rdfs:comment : A collection that is described by the current collection.</para>
    ///   <para>rdfs:label : Described Collection</para>
    ///   <a href="http://purl.org/cld/terms/describedCollection">cld:describedCollection</a>
    /// </summary>
    let describedCollection = _prefixId.prefix "describedCollection"
    /// <summary>
    ///   <para>rdfs:comment : A service that provides access to the items within the collection.</para>
    ///   <para>rdfs:label : Is Accessed Via</para>
    ///   <a href="http://purl.org/cld/terms/isAccessedVia">cld:isAccessedVia</a>
    /// </summary>
    let isAccessedVia = _prefixId.prefix "isAccessedVia"
    /// <summary>
    ///   <para>rdfs:comment : A location where the collection is held.</para>
    ///   <para>rdfs:label : Is Located At</para>
    ///   <a href="http://purl.org/cld/terms/isLocatedAt">cld:isLocatedAt</a>
    /// </summary>
    let isLocatedAt = _prefixId.prefix "isLocatedAt"
    /// <summary>
    ///   <para>rdfs:comment : The media type, physical or digital, of one or more items within the collection.</para>
    ///   <para>rdfs:label : Item Format</para>
    ///   <a href="http://purl.org/cld/terms/itemFormat">cld:itemFormat</a>
    /// </summary>
    let itemFormat = _prefixId.prefix "itemFormat"
    /// <summary>
    ///   <para>rdfs:comment : The nature or genre of the content of one or more items within the collection.</para>
    ///   <para>rdfs:label : Item Type</para>
    ///   <a href="http://purl.org/cld/terms/itemType">cld:itemType</a>
    /// </summary>
    let itemType = _prefixId.prefix "itemType"
