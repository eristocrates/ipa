#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oae =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/oae/core#" "oae"

    /// <summary>
    ///   <para>dcterms:description : Represents an identified entity.</para>
    ///   <para>rdfs:label : entity</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#Entity">oae:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    let NEE = _prefixId.prefix "NEE"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to a category.</para>
    ///   <para>rdfs:label : belongs to</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#belongsTo">oae:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to a literal representing the confidence of an ambiguous entity.</para>
    ///   <para>rdfs:label : confidence</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#confidence">oae:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to a literal representing the string in the document that was detected and considered an entity.</para>
    ///   <para>rdfs:label : detected as</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#detectedAs">oae:detectedAs</a>
    /// </summary>
    let detectedAs = _prefixId.prefix "detectedAs"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to a URI.</para>
    ///   <para>rdfs:label : has matched URI</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#hasMatchedURI">oae:hasMatchedURI</a>
    /// </summary>
    let hasMatchedURI = _prefixId.prefix "hasMatchedURI"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to one or more literals representing the positions in the document in which the entity name was detected.</para>
    ///   <para>rdfs:label : position</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#position">oae:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to a literal representing the actual entity name that exists in a gazetteer of the NEE system.</para>
    ///   <para>rdfs:label : regards entity name</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#regardsEntityName">oae:regardsEntityName</a>
    /// </summary>
    let regardsEntityName = _prefixId.prefix "regardsEntityName"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity to a literal (or a URI to a literal) representing the score of an entity (or of URI).</para>
    ///   <para>rdfs:label : score</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#score">oae:score</a>
    /// </summary>
    let score = _prefixId.prefix "score"
    /// <summary>
    ///   <para>dcterms:description : Relates the annotation process to a configuration.</para>
    ///   <para>rdfs:label : using configuration</para>
    ///   <a href="http://www.ics.forth.gr/isl/oae/core#usingConfiguration">oae:usingConfiguration</a>
    /// </summary>
    let usingConfiguration = _prefixId.prefix "usingConfiguration"
