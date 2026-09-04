#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module seq =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#" "seq"

    /// <summary>
    ///   <para>rdfs:comment : The intransitive follows relation. For example, Wednesday directly precedes Thursday. Directness of precedence depends on the designer conceptualization.^^xsd:string</para>
    ///   <para>rdfs:label : segue direttamenterdfs:label : directly follows</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyFollows">seq:directlyFollows</a>
    /// </summary>
    let directlyFollows = _prefixId.prefix "directlyFollows"
    /// <summary>
    ///   <para>rdfs:comment : The intransitive precedes relation. For example, Monday directly precedes Tuesday. Directness of precedence depends on the designer conceptualization.^^xsd:string</para>
    ///   <para>rdfs:label : precede direttamenterdfs:label : directly precedes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyPrecedes">seq:directlyPrecedes</a>
    /// </summary>
    let directlyPrecedes = _prefixId.prefix "directlyPrecedes"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 2000 follows 1999', 'preparing coffee' follows 'deciding what coffee to use', 'II World War follows I World War', etc.
    /// It can be used between tasks, processes or time intervals, and subproperties would fit best in order to distinguish the different uses.^^xsd:string</para>
    ///   <para>rdfs:label : seguerdfs:label : follows</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#follows">seq:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 1999 precedes 2000', 'deciding what coffee to use' precedes 'preparing coffee', 'World War II follows World War I', 'in the Milan to Rome autoroute, Bologna precedes Florence', etc.
    /// It can then be used between tasks, processes, time intervals, spatially locate objects, situations, etc.
    /// Subproperties can be defined in order to distinguish the different uses.^^xsd:string</para>
    ///   <para>rdfs:label : precederdfs:label : precedes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#precedes">seq:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
