#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module obws =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#" "obws"

    /// <summary>
    ///   <para>rdfs:label : Object</para>
    ///   <para>rdfs:comment : Objects are entities that have different states and that in each state different restrictions on their properties apply.</para>
    ///   <a href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#Object">obws:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : States are the different states that an object can have. States must belong to a single collection of non-duplicate elements (i.e., to a set).</para>
    ///   <a href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#State">obws:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : State set</para>
    ///   <para>rdfs:comment : State sets are sets of states (i.e., collections of non-duplicate states).</para>
    ///   <a href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#StateSet">obws:StateSet</a>
    /// </summary>
    let StateSet = _prefixId.prefix "StateSet"
    /// <summary>
    ///   <para>rdfs:label : has state</para>
    ///   <para>rdfs:comment : Defines the state of an object.</para>
    ///   <a href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#hasState">obws:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>rdfs:label : is state of</para>
    ///   <para>rdfs:comment : Defines the object that has an state</para>
    ///   <a href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#isStateOf">obws:isStateOf</a>
    /// </summary>
    let isStateOf = _prefixId.prefix "isStateOf"
