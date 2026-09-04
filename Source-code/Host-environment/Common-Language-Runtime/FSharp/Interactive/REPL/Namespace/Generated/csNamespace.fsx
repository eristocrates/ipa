#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cs =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/changeset/schema#" "cs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : The encapsulation of a delta between two versions of a resource description</para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:label : ChangeSet</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#ChangeSet">cs:ChangeSet</a>
    /// </summary>
    let ChangeSet = _prefixId.prefix "ChangeSet"
    /// <summary>
    ///   <para>skos:definition : a triple to be added to the resource description</para>
    ///   <para>rdfs:comment :
    ///       By convention the subject of the triple being added should be the same as the subjectOfChange
    ///     </para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:label : addition</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#addition">cs:addition</a>
    /// </summary>
    let addition = _prefixId.prefix "addition"
    /// <summary>
    ///   <para>skos:definition : a  short, human readable description of the purpose for the changeset</para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:label : changeReason</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#changeReason">cs:changeReason</a>
    /// </summary>
    let changeReason = _prefixId.prefix "changeReason"
    /// <summary>
    ///   <para>skos:definition : the date that the changeset was created</para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:label : createdDate</para>
    ///   <para>rdfs:comment :
    ///       The date should be in W3CDTF format
    ///     </para>
    ///   <a href="http://purl.org/vocab/changeset/schema#createdDate">cs:createdDate</a>
    /// </summary>
    let createdDate = _prefixId.prefix "createdDate"
    /// <summary>
    ///   <para>skos:definition : the name of the entity responsible for creating the changeset</para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:label : creatorName</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#creatorName">cs:creatorName</a>
    /// </summary>
    let creatorName = _prefixId.prefix "creatorName"
    /// <summary>
    ///   <para>rdfs:label : precedingChangeSet</para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///       This property can be used to build a history of changes to a particular resource description. The first
    ///       ChangeSet in the history will have no precedingChangeSet property. Each subsequent ChangeSet added
    ///       to the history references the preceding one resulting in a singly-linked list of changes.  Care must be taken
    ///       not to introduce cycles in the history.
    ///     rdfs:comment :
    ///       In systems that assume a closed world, the most recent ChangeSet for a particular resource description
    ///       can be discovered by looking for the ChangeSet that is not the value of a precedingChangeSet property.
    ///       Conversely, the earliest ChangeSet is the one that is not the subject of a precedingChangeSet property.
    ///     </para>
    ///   <para>skos:definition : the changeset that immediately precedes this one</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#precedingChangeSet">cs:precedingChangeSet</a>
    /// </summary>
    let precedingChangeSet = _prefixId.prefix "precedingChangeSet"
    let previousChangeSet = _prefixId.prefix "previousChangeSet"
    /// <summary>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>skos:definition : a triple to be removed from the resource description</para>
    ///   <para>rdfs:label : removal</para>
    ///   <para>rdfs:comment :
    ///       By convention the subject of the triple being removed should be the same as the subjectOfChange
    ///     </para>
    ///   <a href="http://purl.org/vocab/changeset/schema#removal">cs:removal</a>
    /// </summary>
    let removal = _prefixId.prefix "removal"
    /// <summary>
    ///   <para>skos:definition : a triple included in this set of changes</para>
    ///   <para>dcterms:issued : 2006-03-21^^xsd:string</para>
    ///   <para>rdfs:label : statement</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#statement">cs:statement</a>
    /// </summary>
    let statement = _prefixId.prefix "statement"
    /// <summary>
    ///   <para>skos:definition : the resource to which this set of changes applies</para>
    ///   <para>dcterms:issued : 2005-12-14^^xsd:string</para>
    ///   <para>rdfs:label : subjectOfChange</para>
    ///   <a href="http://purl.org/vocab/changeset/schema#subjectOfChange">cs:subjectOfChange</a>
    /// </summary>
    let subjectOfChange = _prefixId.prefix "subjectOfChange"
