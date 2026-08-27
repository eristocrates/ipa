namespace http.www.ontologydesignpatterns.org.cp.owl.situation.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module situ =
    let _namespace_iri = Namespace_Iri situ |> NamespaceIRI
    /// <summary>
    ///   <para>situ:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A view on a set of entities. It can be seen as a 'relational context', reifying a relation.
    /// For example, a PlanExecution is a context including some actions executed by agents according to certain parameters and expected tasks to be achieved from a Plan; a DiagnosedSituation is a context of observed entities that is interpreted on the basis of a Diagnosis, etc.
    /// Situation is also able to represent reified n-ary relations, where isSettingFor is the top-level relation for all binary projections of the n-ary relation. If used in a transformation pattern for n-ary relations, the designer should take care of:
    /// - creating only one situation for each instance of an n-ary relation, otherwise the 'identification constraint' (Calvanese et al., IJCAI 2001) could be violated
    /// - adding an 'exact cardinality' restriction corresponding to the arity of the n-ary relation, otherwise the designer would actually represent a polymorphic relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Situation"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#Situation">http://www.ontologydesignpatterns.org/cp/owl/situation.owl#Situation</seealso>
    let Situation = Prefixed_Name(situ, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>situ:hasSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities and situations, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica' (i.e.: (an amount of) a new fantastic Arabica hasSetting the preparation of my coffee this morning)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has setting"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#hasSetting">http://www.ontologydesignpatterns.org/cp/owl/situation.owl#hasSetting</seealso>
    let hasSetting = Prefixed_Name(situ, "hasSetting") |> PrefixedName
    /// <summary>
    ///   <para>situ:isSettingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is setting for"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#isSettingFor">http://www.ontologydesignpatterns.org/cp/owl/situation.owl#isSettingFor</seealso>
    let isSettingFor = Prefixed_Name(situ, "isSettingFor") |> PrefixedName
