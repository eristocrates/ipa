#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module situ =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/situation.owl#" "situ"

    /// <summary>
    ///   <para>rdfs:label : Situation</para>
    ///   <para>rdfs:comment : A view on a set of entities. It can be seen as a 'relational context', reifying a relation.
    /// For example, a PlanExecution is a context including some actions executed by agents according to certain parameters and expected tasks to be achieved from a Plan; a DiagnosedSituation is a context of observed entities that is interpreted on the basis of a Diagnosis, etc.
    /// Situation is also able to represent reified n-ary relations, where isSettingFor is the top-level relation for all binary projections of the n-ary relation. If used in a transformation pattern for n-ary relations, the designer should take care of:
    /// - creating only one situation for each instance of an n-ary relation, otherwise the 'identification constraint' (Calvanese et al., IJCAI 2001) could be violated
    /// - adding an 'exact cardinality' restriction corresponding to the arity of the n-ary relation, otherwise the designer would actually represent a polymorphic relation.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#Situation">situ:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:label : has setting</para>
    ///   <para>rdfs:comment : A relation between entities and situations, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica' (i.e.: (an amount of) a new fantastic Arabica hasSetting the preparation of my coffee this morning).^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#hasSetting">situ:hasSetting</a>
    /// </summary>
    let hasSetting = _prefixId.prefix "hasSetting"
    /// <summary>
    ///   <para>rdfs:label : is setting for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#isSettingFor">situ:isSettingFor</a>
    /// </summary>
    let isSettingFor = _prefixId.prefix "isSettingFor"
