#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.wsmo.org/ns/wsmo-lite#" "wl"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:description : preconditions of services and operations</para>
    ///   <para>rdfs:label : Condition</para>
    ///   <a href="http://www.wsmo.org/ns/wsmo-lite#Condition">wl:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:description : effects (postconditions) of services and operations</para>
    ///   <para>rdfs:label : Effect</para>
    ///   <a href="http://www.wsmo.org/ns/wsmo-lite#Effect">wl:Effect</a>
    /// </summary>
    let Effect = _prefixId.prefix "Effect"
    let FunctionalClassificationRoot = _prefixId.prefix "FunctionalClassificationRoot"
    /// <summary>
    ///   <para>rdfs:description : instances of this class are concrete nonfunctional properties of services</para>
    ///   <para>rdfs:label : Nonfunctional Parameter</para>
    ///   <a href="http://www.wsmo.org/ns/wsmo-lite#NonfunctionalParameter">wl:NonfunctionalParameter</a>
    /// </summary>
    let NonfunctionalParameter = _prefixId.prefix "NonfunctionalParameter"
    /// <summary>
    ///   <para>rdfs:description : information model ontology (deprecated)</para>
    ///   <para>rdfs:label : Ontology</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://www.wsmo.org/ns/wsmo-lite#Ontology">wl:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    let Service = _prefixId.prefix "Service"
    let usesOntology = _prefixId.prefix "usesOntology"
