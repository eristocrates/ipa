namespace http.delicias.dia.fi.upm.es.ontologies.ObjectWithStates.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module obws =
    let _namespace_iri = Namespace_Iri obws |> NamespaceIRI
    /// <summary>
    ///   <para>obws:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Objects are entities that have different states and that in each state different restrictions on their properties apply."</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#Object">http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#Object</seealso>
    let Object = Prefixed_Name(obws, "Object") |> PrefixedName
    /// <summary>
    ///   <para>obws:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"States are the different states that an object can have. States must belong to a single collection of non-duplicate elements (i.e., to a set)."</para>
    /// labels<para>"State"</para></remarks>
    /// <seealso href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#State">http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#State</seealso>
    let State = Prefixed_Name(obws, "State") |> PrefixedName
    /// <summary>
    ///   <para>obws:StateSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State sets are sets of states (i.e., collections of non-duplicate states)."</para>
    /// labels<para>"State set"</para></remarks>
    /// <seealso href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#StateSet">http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#StateSet</seealso>
    let StateSet = Prefixed_Name(obws, "StateSet") |> PrefixedName
    /// <summary>
    ///   <para>obws:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the state of an object."</para>
    /// labels<para>"has state"</para></remarks>
    /// <seealso href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#hasState">http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#hasState</seealso>
    let hasState = Prefixed_Name(obws, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>obws:isStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the object that has an state"</para>
    /// labels<para>"is state of"</para></remarks>
    /// <seealso href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#isStateOf">http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#isStateOf</seealso>
    let isStateOf = Prefixed_Name(obws, "isStateOf") |> PrefixedName
