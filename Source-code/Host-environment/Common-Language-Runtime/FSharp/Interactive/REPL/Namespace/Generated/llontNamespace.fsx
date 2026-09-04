#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module llont =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.linklion.org/ontology#" "llont"

    /// <summary>
    ///   <para>rdfs:label : Algorithm</para>
    ///   <a href="http://www.linklion.org/ontology#Algorithm">llont:Algorithm</a>
    /// </summary>
    let Algorithm = _prefixId.prefix "Algorithm"
    /// <summary>
    ///   <para>rdfs:label : Link Discovery Framework</para>
    ///   <a href="http://www.linklion.org/ontology#LDFramework">llont:LDFramework</a>
    /// </summary>
    let LDFramework = _prefixId.prefix "LDFramework"
    /// <summary>
    ///   <para>rdfs:label : Link Discovery Framework Version</para>
    ///   <a href="http://www.linklion.org/ontology#LDFrameworkVersion">llont:LDFrameworkVersion</a>
    /// </summary>
    let LDFrameworkVersion = _prefixId.prefix "LDFrameworkVersion"
    /// <summary>
    ///   <para>rdfs:label : Link</para>
    ///   <a href="http://www.linklion.org/ontology#Link">llont:Link</a>
    /// </summary>
    let Link = _prefixId.prefix "Link"
    /// <summary>
    ///   <para>rdfs:label : Mapping</para>
    ///   <a href="http://www.linklion.org/ontology#Mapping">llont:Mapping</a>
    /// </summary>
    let Mapping = _prefixId.prefix "Mapping"
    let hasSource = _prefixId.prefix "hasSource"
    let hasTarget = _prefixId.prefix "hasTarget"
    let parameters = _prefixId.prefix "parameters"
    let storedAt = _prefixId.prefix "storedAt"
