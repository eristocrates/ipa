namespace http.w3id.org.CEON.ontology.cvn.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_cvn =
    let _namespace_iri = Namespace_Iri ceon_cvn |> NamespaceIRI
    /// <summary>
    ///   <para>ceon:ontology/cvn/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A core module of the CEON ontology network, defining aspects of the circular value network (CVN) itself."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/">http://w3id.org/CEON/ontology/cvn/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_cvn, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/0.3/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/0.3/">http://w3id.org/CEON/ontology/cvn/0.3/</seealso>
    let ``_0.3/`` = Prefixed_Name(ceon_cvn, "0.3/") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/CVN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A network of interlinked value chains and interested parties."</para>
    /// labels<para>"Circular Value Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/CVN">http://w3id.org/CEON/ontology/cvn/CVN</seealso>
    let CVN = Prefixed_Name(ceon_cvn, "CVN") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/CVNBlueprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan or a pattern of a CVN configuration that can then be filled with actual actors and processes. The blueprint can be used to capture a desired setup of a network, or for reusing patterns of CVNs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Circular Value Network Blueprint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/CVNBlueprint">http://w3id.org/CEON/ontology/cvn/CVNBlueprint</seealso>
    let CVNBlueprint = Prefixed_Name(ceon_cvn, "CVNBlueprint") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/CircularStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A circular strategy, such as to reccycle, reuse or refurbish something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Circular Strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/CircularStrategy">http://w3id.org/CEON/ontology/cvn/CircularStrategy</seealso>
    let CircularStrategy = Prefixed_Name(ceon_cvn, "CircularStrategy") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/Collaboration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collaboration between a set of actors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collaboration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/Collaboration">http://w3id.org/CEON/ontology/cvn/Collaboration</seealso>
    let Collaboration = Prefixed_Name(ceon_cvn, "Collaboration") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/aimsAtValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value proposition that the planned abstract CVN configuration, or concrete network wants to achieve."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aims at value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/aimsAtValue">http://w3id.org/CEON/ontology/cvn/aimsAtValue</seealso>
    let aimsAtValue = Prefixed_Name(ceon_cvn, "aimsAtValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/composedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Both a CVN and a process can be composed of other CVNs or processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"composed of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/composedOf">http://w3id.org/CEON/ontology/cvn/composedOf</seealso>
    let composedOf = Prefixed_Name(ceon_cvn, "composedOf") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/cvn/createsValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Value creation can be captured at the actor level, i.e. value created by an actor's participation in a collaboration, or at the process or complete CVN level."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creates value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/createsValue">http://w3id.org/CEON/ontology/cvn/createsValue</seealso>
    let createsValue = Prefixed_Name(ceon_cvn, "createsValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/cvn/implementsBlueprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The blueprint (or plan) that this concrete CVN is an instance of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implements blueprint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/implementsBlueprint">http://w3id.org/CEON/ontology/cvn/implementsBlueprint</seealso>
    let implementsBlueprint =
        Prefixed_Name(ceon_cvn, "implementsBlueprint") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/cvn/implementsStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A strategy that is implemented by this CVN or CVN blueprint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implements strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/implementsStrategy">http://w3id.org/CEON/ontology/cvn/implementsStrategy</seealso>
    let implementsStrategy =
        Prefixed_Name(ceon_cvn, "implementsStrategy") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/cvn/plansToImplementStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A strategy that is planned to be implemented by this CVN or CVN blueprint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"plans to implement strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/plansToImplementStrategy">http://w3id.org/CEON/ontology/cvn/plansToImplementStrategy</seealso>
    let plansToImplementStrategy =
        Prefixed_Name(ceon_cvn, "plansToImplementStrategy") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/cvn/relatedStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A strategy that is targeted by this CVN or CVN blueprint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"related strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/cvn/relatedStrategy">http://w3id.org/CEON/ontology/cvn/relatedStrategy</seealso>
    let relatedStrategy = Prefixed_Name(ceon_cvn, "relatedStrategy") |> PrefixedName
