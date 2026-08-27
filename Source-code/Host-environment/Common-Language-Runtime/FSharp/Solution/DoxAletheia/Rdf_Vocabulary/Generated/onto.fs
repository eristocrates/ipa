namespace http.www.ontotext.com.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module onto =
    let _namespace_iri = Namespace_Iri onto |> NamespaceIRI
    /// <summary>
    ///   <para>onto:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"Ontotext Corp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/">http://www.ontotext.com/</seealso>
    let _prefix_iri = Prefixed_Name(onto, "") |> PrefixedName

    /// <summary>
    ///   <para>onto:plugins/geosparql#wktLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/plugins/geosparql#wktLiteral">http://www.ontotext.com/plugins/geosparql#wktLiteral</seealso>
    let ``plugins/geosparql#wktLiteral`` =
        Prefixed_Name(onto, "plugins/geosparql#wktLiteral") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton-ontology/AirplaneModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton-ontology/AirplaneModel">http://www.ontotext.com/proton-ontology/AirplaneModel</seealso>
    let ``proton_ontology/AirplaneModel`` =
        Prefixed_Name(onto, "proton-ontology/AirplaneModel") |> PrefixedName
