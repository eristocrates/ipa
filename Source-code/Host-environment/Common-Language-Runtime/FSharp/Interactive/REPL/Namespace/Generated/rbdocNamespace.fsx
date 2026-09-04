#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rbdoc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/riverbench/schema/documentation#" "rbdoc"

    /// <summary>
    ///   <para>rdfs:label : Documentation group</para>
    ///   <para>rdfs:comment : Documentation group, corresponding to a heading in the generated document.</para>
    ///   <a href="https://w3id.org/riverbench/schema/documentation#DocGroup">rbdoc:DocGroup</a>
    /// </summary>
    let DocGroup = _prefixId.prefix "DocGroup"
    let groupContent = _prefixId.prefix "groupContent"
    let groupDistributions = _prefixId.prefix "groupDistributions"
    let groupGeneralInfo = _prefixId.prefix "groupGeneralInfo"
    let groupTechnicalMetadata = _prefixId.prefix "groupTechnicalMetadata"
    /// <summary>
    ///   <para>rbdoc:isHiddenInDoc : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Has documentation group</para>
    ///   <para>rdfs:comment : Indicates the documentation group (heading) of a property</para>
    ///   <a href="https://w3id.org/riverbench/schema/documentation#hasDocGroup">rbdoc:hasDocGroup</a>
    /// </summary>
    let hasDocGroup = _prefixId.prefix "hasDocGroup"
    /// <summary>
    ///   <para>rbdoc:isHiddenInDoc : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Has documentation weight</para>
    ///   <para>rdfs:comment : Weight of a given property or item when generating documentation (integer). Properties or items with lower values will be shown first in the generated docs.</para>
    ///   <a href="https://w3id.org/riverbench/schema/documentation#hasDocWeight">rbdoc:hasDocWeight</a>
    /// </summary>
    let hasDocWeight = _prefixId.prefix "hasDocWeight"
    /// <summary>
    ///   <para>rbdoc:isHiddenInDoc : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Has label override</para>
    ///   <para>rdfs:comment : Top-priority label to be used in documentation pages.</para>
    ///   <a href="https://w3id.org/riverbench/schema/documentation#hasLabelOverride">rbdoc:hasLabelOverride</a>
    /// </summary>
    let hasLabelOverride = _prefixId.prefix "hasLabelOverride"
    /// <summary>
    ///   <para>rbdoc:isHiddenInDoc : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Is hidden in documentation</para>
    ///   <para>rdfs:comment : Whether a given property should be omitted in the generated documentation.</para>
    ///   <a href="https://w3id.org/riverbench/schema/documentation#isHiddenInDoc">rbdoc:isHiddenInDoc</a>
    /// </summary>
    let isHiddenInDoc = _prefixId.prefix "isHiddenInDoc"
