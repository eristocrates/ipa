namespace http.premon.fbk.eu.ontology.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmo =
    let _namespace_iri = Namespace_Iri pmo |> NamespaceIRI
    /// <summary>
    ///   <para>pmo:Conceptualization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#Conceptualization">http://premon.fbk.eu/ontology/core#Conceptualization</seealso>
    let Conceptualization = Prefixed_Name(pmo, "Conceptualization") |> PrefixedName
    /// <summary>
    ///   <para>pmo:Example</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#Example">http://premon.fbk.eu/ontology/core#Example</seealso>
    let Example = Prefixed_Name(pmo, "Example") |> PrefixedName
    /// <summary>
    ///   <para>pmo:SemanticClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#SemanticClass">http://premon.fbk.eu/ontology/core#SemanticClass</seealso>
    let SemanticClass = Prefixed_Name(pmo, "SemanticClass") |> PrefixedName
    /// <summary>
    ///   <para>pmo:SemanticRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#SemanticRole">http://premon.fbk.eu/ontology/core#SemanticRole</seealso>
    let SemanticRole = Prefixed_Name(pmo, "SemanticRole") |> PrefixedName
    /// <summary>
    ///   <para>pmo:classRel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#classRel">http://premon.fbk.eu/ontology/core#classRel</seealso>
    let classRel = Prefixed_Name(pmo, "classRel") |> PrefixedName
    /// <summary>
    ///   <para>pmo:evokedConcept</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#evokedConcept">http://premon.fbk.eu/ontology/core#evokedConcept</seealso>
    let evokedConcept = Prefixed_Name(pmo, "evokedConcept") |> PrefixedName
    /// <summary>
    ///   <para>pmo:first</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#first">http://premon.fbk.eu/ontology/core#first</seealso>
    let first = Prefixed_Name(pmo, "first") |> PrefixedName
    /// <summary>
    ///   <para>pmo:item</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#item">http://premon.fbk.eu/ontology/core#item</seealso>
    let item = Prefixed_Name(pmo, "item") |> PrefixedName
    /// <summary>
    ///   <para>pmo:next</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#next">http://premon.fbk.eu/ontology/core#next</seealso>
    let next = Prefixed_Name(pmo, "next") |> PrefixedName
    /// <summary>
    ///   <para>pmo:roleRel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#roleRel">http://premon.fbk.eu/ontology/core#roleRel</seealso>
    let roleRel = Prefixed_Name(pmo, "roleRel") |> PrefixedName
    /// <summary>
    ///   <para>pmo:semRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#semRole">http://premon.fbk.eu/ontology/core#semRole</seealso>
    let semRole = Prefixed_Name(pmo, "semRole") |> PrefixedName
    /// <summary>
    ///   <para>pmo:valueDt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#valueDt">http://premon.fbk.eu/ontology/core#valueDt</seealso>
    let valueDt = Prefixed_Name(pmo, "valueDt") |> PrefixedName
    /// <summary>
    ///   <para>pmo:valueObj</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/core#valueObj">http://premon.fbk.eu/ontology/core#valueObj</seealso>
    let valueObj = Prefixed_Name(pmo, "valueObj") |> PrefixedName
