#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mdoprov =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/mdo/provenance/" "mdoprov"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : author name</para>
    ///   <para>rdfs:comment : AuthorName represents that a reference agent has the author's name in a string.</para>
    ///   <a href="https://w3id.org/mdo/provenance/AuthorName">mdoprov:AuthorName</a>
    /// </summary>
    let AuthorName = _prefixId.prefix "AuthorName"
    /// <summary>
    ///   <para>rdfs:label : DOI</para>
    ///   <para>rdfs:comment : DOI represents that a reference agent has the DOI in a string.</para>
    ///   <a href="https://w3id.org/mdo/provenance/DOI">mdoprov:DOI</a>
    /// </summary>
    let DOI = _prefixId.prefix "DOI"
    /// <summary>
    ///   <para>rdfs:label : database name</para>
    ///   <para>rdfs:comment : DatabaseName represents that a reference agent has the database's name in a string.</para>
    ///   <a href="https://w3id.org/mdo/provenance/DatabaseName">mdoprov:DatabaseName</a>
    /// </summary>
    let DatabaseName = _prefixId.prefix "DatabaseName"
    /// <summary>
    ///   <para>rdfs:label : publication dateTime</para>
    ///   <para>rdfs:comment : PublicationDateTime represents that a reference agent has the date time in a dateTime.</para>
    ///   <a href="https://w3id.org/mdo/provenance/PublicationDateTime">mdoprov:PublicationDateTime</a>
    /// </summary>
    let PublicationDateTime = _prefixId.prefix "PublicationDateTime"
    /// <summary>
    ///   <para>rdfs:label : publication title</para>
    ///   <para>rdfs:comment : PublicationTitle represents that a reference agent has the publication's title in a string.</para>
    ///   <a href="https://w3id.org/mdo/provenance/PublicationTitle">mdoprov:PublicationTitle</a>
    /// </summary>
    let PublicationTitle = _prefixId.prefix "PublicationTitle"
    /// <summary>
    ///   <para>rdfs:label : Reference Agent</para>
    ///   <para>rdfs:comment : A reference agent is the representation of the reference that the structure or property refer to.</para>
    ///   <a href="https://w3id.org/mdo/provenance/ReferenceAgent">mdoprov:ReferenceAgent</a>
    /// </summary>
    let ReferenceAgent = _prefixId.prefix "ReferenceAgent"
    /// <summary>
    ///   <para>rdfs:label : software name</para>
    ///   <para>rdfs:comment : SoftwareName represents that a software agent has the name in a string.</para>
    ///   <a href="https://w3id.org/mdo/provenance/SoftwareName">mdoprov:SoftwareName</a>
    /// </summary>
    let SoftwareName = _prefixId.prefix "SoftwareName"
    /// <summary>
    ///   <para>rdfs:label : URL</para>
    ///   <para>rdfs:comment : URL represents that a reference agent has the URL in a string.</para>
    ///   <a href="https://w3id.org/mdo/provenance/URL">mdoprov:URL</a>
    /// </summary>
    let URL = _prefixId.prefix "URL"
