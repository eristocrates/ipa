#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module olca =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/olca#" "olca"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A loose coupling of a property to possible or expected class it can describe. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:domain or some owl:Restriction constraint. </para>
    ///   <para>rdfs:label : domain includes</para>
    ///   <a href="https://w3id.org/vocab/olca#domainIncludes">olca:domainIncludes</a>
    /// </summary>
    let domainIncludes = _prefixId.prefix "domainIncludes"
    /// <summary>
    ///   <para>rdfs:comment : A loose coupling of a class to possible or expected properties. This annotation is to be used when one does not want to enforce formally the coupling using rdfs:range or some owl:Restriction.</para>
    ///   <para>rdfs:label : expected property</para>
    ///   <a href="https://w3id.org/vocab/olca#expectedProperty">olca:expectedProperty</a>
    /// </summary>
    let expectedProperty = _prefixId.prefix "expectedProperty"
    /// <summary>
    ///   <para>rdfs:comment : A loose coupling of a property to possible or expected values. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:range or some owl:Restriction constraint.</para>
    ///   <para>rdfs:label : range includes</para>
    ///   <a href="https://w3id.org/vocab/olca#rangeIncludes">olca:rangeIncludes</a>
    /// </summary>
    let rangeIncludes = _prefixId.prefix "rangeIncludes"
    /// <summary>
    ///   <para>rdfs:comment : A loose similarity of classes, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentClass. </para>
    ///   <para>rdfs:label : similar class</para>
    ///   <a href="https://w3id.org/vocab/olca#similarClass">olca:similarClass</a>
    /// </summary>
    let similarClass = _prefixId.prefix "similarClass"
    /// <summary>
    ///   <para>rdfs:label : similar property</para>
    ///   <para>rdfs:comment : A loose similary of properties, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentProperty. </para>
    ///   <a href="https://w3id.org/vocab/olca#similarProperty">olca:similarProperty</a>
    /// </summary>
    let similarProperty = _prefixId.prefix "similarProperty"
