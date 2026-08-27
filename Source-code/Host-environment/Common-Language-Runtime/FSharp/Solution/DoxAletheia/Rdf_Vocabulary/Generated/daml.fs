namespace http.www.daml.org._2001._03.daml_oil.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module daml =
    let _namespace_iri = Namespace_Iri daml |> NamespaceIRI
    /// <summary>
    ///   <para>daml:DatatypeProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#DatatypeProperty">http://www.daml.org/2001/03/daml+oil#DatatypeProperty</seealso>
    let DatatypeProperty = Prefixed_Name(daml, "DatatypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>daml:Ontology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#Ontology">http://www.daml.org/2001/03/daml+oil#Ontology</seealso>
    let Ontology = Prefixed_Name(daml, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>daml:Restriction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#Restriction">http://www.daml.org/2001/03/daml+oil#Restriction</seealso>
    let Restriction = Prefixed_Name(daml, "Restriction") |> PrefixedName
    /// <summary>
    ///   <para>daml:UniqueProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#UniqueProperty">http://www.daml.org/2001/03/daml+oil#UniqueProperty</seealso>
    let UniqueProperty = Prefixed_Name(daml, "UniqueProperty") |> PrefixedName
    /// <summary>
    ///   <para>daml:cardinality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#cardinality">http://www.daml.org/2001/03/daml+oil#cardinality</seealso>
    let cardinality = Prefixed_Name(daml, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>daml:onProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#onProperty">http://www.daml.org/2001/03/daml+oil#onProperty</seealso>
    let onProperty = Prefixed_Name(daml, "onProperty") |> PrefixedName
    /// <summary>
    ///   <para>daml:toClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#toClass">http://www.daml.org/2001/03/daml+oil#toClass</seealso>
    let toClass = Prefixed_Name(daml, "toClass") |> PrefixedName
    /// <summary>
    ///   <para>daml:versionInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.daml.org/2001/03/daml+oil#versionInfo">http://www.daml.org/2001/03/daml+oil#versionInfo</seealso>
    let versionInfo = Prefixed_Name(daml, "versionInfo") |> PrefixedName
