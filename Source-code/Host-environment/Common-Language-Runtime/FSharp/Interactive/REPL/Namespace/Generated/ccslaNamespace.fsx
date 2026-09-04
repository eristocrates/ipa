#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ccsla =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccsla#" "ccsla"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Claims of the agreement</para>
    ///   <para>rdfs:comment : Claims of the agreement license</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#Claim">ccsla:Claim</a>
    /// </summary>
    let Claim = _prefixId.prefix "Claim"
    /// <summary>
    ///   <para>rdfs:label : Conditions of compensation</para>
    ///   <para>rdfs:comment : Conditions and levels of the agreement and compensation</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#Condition">ccsla:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : Definitions of the agreement</para>
    ///   <para>rdfs:comment : Definitions of the agreement license used in terms</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#Definition">ccsla:Definition</a>
    /// </summary>
    let Definition = _prefixId.prefix "Definition"
    /// <summary>
    ///   <para>rdfs:label : Limitations of the agreement</para>
    ///   <para>rdfs:comment : Limitations and Exclusions of the agreement license considering Compensations</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#Limitation">ccsla:Limitation</a>
    /// </summary>
    let Limitation = _prefixId.prefix "Limitation"
    /// <summary>
    ///   <para>rdfs:label : SLA Class</para>
    ///   <para>rdfs:comment : SLA Main Class</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#SLA">ccsla:SLA</a>
    /// </summary>
    let SLA = _prefixId.prefix "SLA"
    /// <summary>
    ///   <para>rdfs:label : ServiceCredits of the agreement</para>
    ///   <para>rdfs:comment : ServiceCredits of the agreement license considering Compensations terms</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#ServiceCredit">ccsla:ServiceCredit</a>
    /// </summary>
    let ServiceCredit = _prefixId.prefix "ServiceCredit"
    /// <summary>
    ///   <para>rdfs:label : Term of the agreement</para>
    ///   <para>rdfs:comment : Term of the SLA</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#Term">ccsla:Term</a>
    /// </summary>
    let Term = _prefixId.prefix "Term"
    /// <summary>
    ///   <para>rdfs:label : SLA Contains</para>
    ///   <para>rdfs:comment : SLA contains Terms of the agreement</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#containsTerm">ccsla:containsTerm</a>
    /// </summary>
    let containsTerm = _prefixId.prefix "containsTerm"
    let cookingbigdata = _prefixId.prefix "cookingbigdata"
    /// <summary>
    ///   <para>rdfs:label : Term Compensation</para>
    ///   <para>rdfs:comment : Term Compensation of the agreement</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#hasCompensation">ccsla:hasCompensation</a>
    /// </summary>
    let hasCompensation = _prefixId.prefix "hasCompensation"
    /// <summary>
    ///   <para>rdfs:label : Definition values</para>
    ///   <para>rdfs:comment : Definition values of an agreement term.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#hasDefinitionValue">ccsla:hasDefinitionValue</a>
    /// </summary>
    let hasDefinitionValue = _prefixId.prefix "hasDefinitionValue"
    /// <summary>
    ///   <para>rdfs:label : Terms values</para>
    ///   <para>rdfs:comment : Definition values of an agreement term.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#hasTermValue">ccsla:hasTermValue</a>
    /// </summary>
    let hasTermValue = _prefixId.prefix "hasTermValue"
    /// <summary>
    ///   <para>rdfs:label : Validity interval</para>
    ///   <para>rdfs:comment : Validity interval of an agreement term.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#hasValidity">ccsla:hasValidity</a>
    /// </summary>
    let hasValidity = _prefixId.prefix "hasValidity"
    /// <summary>
    ///   <para>rdfs:label : Include Defs</para>
    ///   <para>rdfs:comment : Include definitions</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#includeDefs">ccsla:includeDefs</a>
    /// </summary>
    let includeDefs = _prefixId.prefix "includeDefs"
    /// <summary>
    ///   <para>rdfs:label : With values</para>
    ///   <para>rdfs:comment : Values of the condition</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccsla#includeValue">ccsla:includeValue</a>
    /// </summary>
    let includeValue = _prefixId.prefix "includeValue"
    let manuelparra = _prefixId.prefix "manuelparra"
