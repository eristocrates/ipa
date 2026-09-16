#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module organization =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/organization#" "organization"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : company</para>
    ///   <para>skos:definition : Organisation with persons united or incorporated for joint action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organization#Company">organization:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : department</para>
    ///   <para>skos:definition : A specialized division of an organization.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organization#Department">organization:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>rdfs:label : enterprise</para>
    ///   <para>skos:definition : Company organized for commercial purposes.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organization#Enterprise">organization:Enterprise</a>
    /// </summary>
    let Enterprise = _prefixId.prefix "Enterprise"
    /// <summary>
    ///   <para>rdfs:label : legal person</para>
    ///   <para>skos:definition : Role of an organization recognised as having legal personality to enter legal relations, being able to act as a natural person for limited purposes, most commonly lawsuits, property ownership, and contracts.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organization#LegalPerson">organization:LegalPerson</a>
    /// </summary>
    let LegalPerson = _prefixId.prefix "LegalPerson"
    /// <summary>
    ///   <para>rdfs:label : university</para>
    ///   <para>skos:definition : .</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organization#University">organization:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>skos:definition : Specifying a seat of an organization.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/organization#hasSeat">organization:hasSeat</a>
    /// </summary>
    let hasSeat = _prefixId.prefix "hasSeat"
