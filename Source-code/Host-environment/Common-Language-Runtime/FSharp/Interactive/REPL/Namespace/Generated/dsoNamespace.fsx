#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dso =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://inference-web.org/2.0/ds.owl#" "dso"

    /// <summary>
    ///   <para>rdfs:comment : A template for defining typed-list. It functions like rdf:List with object members.</para>
    ///   <para>rdfs:label : List</para>
    ///   <a href="http://inference-web.org/2.0/ds.owl#List">dso:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:comment : The first item in the subject RDF list.</para>
    ///   <para>rdfs:label : first</para>
    ///   <a href="http://inference-web.org/2.0/ds.owl#first">dso:first</a>
    /// </summary>
    let first = _prefixId.prefix "first"
    let nil = _prefixId.prefix "nil"
    /// <summary>
    ///   <para>rdfs:comment : The rest of the subject RDF list after the first item.</para>
    ///   <para>rdfs:label : rest</para>
    ///   <a href="http://inference-web.org/2.0/ds.owl#rest">dso:rest</a>
    /// </summary>
    let rest = _prefixId.prefix "rest"
