#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4syst =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4syst/" "s4syst"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Connection</para>
    ///   <para>rdfs:comment : The class of connections between systems. This class qualifies property s4syst:connectedTo. A connection describes potential interactions between systems. Any two connected systems are connected through a connection. A connection can connect more than two systems at the same time.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/Connection">s4syst:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    /// <summary>
    ///   <para>rdfs:label : Connection Point</para>
    ///   <para>rdfs:comment : The class of connection points of systems, at which they may be connected to other systems. This class qualifies properties s4syst:connectsSystem and s4syst:connectedThrough. A connection point belongs to exactly one system. Any system connected through a connection is connected at one of its connection points to the connection. The system of a connection point that is connected through a connection is itself connected through the connection.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/ConnectionPoint">s4syst:ConnectionPoint</a>
    /// </summary>
    let ConnectionPoint = _prefixId.prefix "ConnectionPoint"
    /// <summary>
    ///   <para>rdfs:label : System</para>
    ///   <para>rdfs:comment : The class of systems, i.e., systems virtually isolated from the environment, whose behaviour and interactions with the environment are modeled. Systems can be connected to other systems. Connected systems interact in some ways. Systems can also have subsystems. Properties of subsystems somehow contribute to the properties of the supersystem.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/System">s4syst:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : connected through</para>
    ///   <para>rdfs:comment : Links a system to one of its connections to other systems.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectedThrough">s4syst:connectedThrough</a>
    /// </summary>
    let connectedThrough = _prefixId.prefix "connectedThrough"
    /// <summary>
    ///   <para>rdfs:label : connected to</para>
    ///   <para>rdfs:comment : Links a system to a system it is connected to. Connected systems interact in some way. The exact meaning of "interact" is defined by sub properties of s4syst:connectedTo. Property s4syst:connectedTo is symmetric. This property can be qualified using class s4syst:Connection, which connects the two systems. If there is a connection between several systems, then one may infer these systems are pairwise connected.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectedTo">s4syst:connectedTo</a>
    /// </summary>
    let connectedTo = _prefixId.prefix "connectedTo"
    /// <summary>
    ///   <para>rdfs:label : connection point to</para>
    ///   <para>rdfs:comment : Links a connection point to the one and only one system it belongs to.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectionPointOf">s4syst:connectionPointOf</a>
    /// </summary>
    let connectionPointOf = _prefixId.prefix "connectionPointOf"
    /// <summary>
    ///   <para>rdfs:label : connects at</para>
    ///   <para>rdfs:comment : Links a system to one of the connection points at which it connects.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectsAt">s4syst:connectsAt</a>
    /// </summary>
    let connectsAt = _prefixId.prefix "connectsAt"
    /// <summary>
    ///   <para>rdfs:label : connects system</para>
    ///   <para>rdfs:comment : Links a connection to one of the systems it connects.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectsSystem">s4syst:connectsSystem</a>
    /// </summary>
    let connectsSystem = _prefixId.prefix "connectsSystem"
    /// <summary>
    ///   <para>rdfs:label : connects system at</para>
    ///   <para>rdfs:comment : Links a connection to one of the connection points at which it connects a system.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectsSystemAt">s4syst:connectsSystemAt</a>
    /// </summary>
    let connectsSystemAt = _prefixId.prefix "connectsSystemAt"
    /// <summary>
    ///   <para>rdfs:label : connects system through</para>
    ///   <para>rdfs:comment : Links a connection point to one of the connections through which it connects its system.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/connectsSystemThrough">s4syst:connectsSystemThrough</a>
    /// </summary>
    let connectsSystemThrough = _prefixId.prefix "connectsSystemThrough"
    /// <summary>
    ///   <para>rdfs:label : has sub system</para>
    ///   <para>rdfs:comment : Links a system to one of its sub systems.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/hasSubSystem">s4syst:hasSubSystem</a>
    /// </summary>
    let hasSubSystem = _prefixId.prefix "hasSubSystem"
    /// <summary>
    ///   <para>rdfs:label : sub system of</para>
    ///   <para>rdfs:comment : Links a system to its super system. Properties of subsystems somehow contribute to the properties of the super system. The exact meaning of "contribute is defined by sub properties of s4syst:subSystemOf. Property s4syst:subSystemOf is transitive.</para>
    ///   <a href="https://saref.etsi.org/saref4syst/subSystemOf">s4syst:subSystemOf</a>
    /// </summary>
    let subSystemOf = _prefixId.prefix "subSystemOf"
