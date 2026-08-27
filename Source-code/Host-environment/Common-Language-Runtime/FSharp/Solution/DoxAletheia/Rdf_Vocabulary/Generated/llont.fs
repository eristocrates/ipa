namespace http.www.linklion.org.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module llont =
    let _namespace_iri = Namespace_Iri llont |> NamespaceIRI
    /// <summary>
    ///   <para>llont:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Algorithm"</para></remarks>
    /// <seealso href="http://www.linklion.org/ontology#Algorithm">http://www.linklion.org/ontology#Algorithm</seealso>
    let Algorithm = Prefixed_Name(llont, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>llont:LDFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Link Discovery Framework"</para></remarks>
    /// <seealso href="http://www.linklion.org/ontology#LDFramework">http://www.linklion.org/ontology#LDFramework</seealso>
    let LDFramework = Prefixed_Name(llont, "LDFramework") |> PrefixedName
    /// <summary>
    ///   <para>llont:LDFrameworkVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Link Discovery Framework Version"</para></remarks>
    /// <seealso href="http://www.linklion.org/ontology#LDFrameworkVersion">http://www.linklion.org/ontology#LDFrameworkVersion</seealso>
    let LDFrameworkVersion = Prefixed_Name(llont, "LDFrameworkVersion") |> PrefixedName
    /// <summary>
    ///   <para>llont:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Link"</para></remarks>
    /// <seealso href="http://www.linklion.org/ontology#Link">http://www.linklion.org/ontology#Link</seealso>
    let Link = Prefixed_Name(llont, "Link") |> PrefixedName
    /// <summary>
    ///   <para>llont:Mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mapping"</para></remarks>
    /// <seealso href="http://www.linklion.org/ontology#Mapping">http://www.linklion.org/ontology#Mapping</seealso>
    let Mapping = Prefixed_Name(llont, "Mapping") |> PrefixedName
    /// <summary>
    ///   <para>llont:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.linklion.org/ontology#hasSource">http://www.linklion.org/ontology#hasSource</seealso>
    let hasSource = Prefixed_Name(llont, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>llont:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.linklion.org/ontology#hasTarget">http://www.linklion.org/ontology#hasTarget</seealso>
    let hasTarget = Prefixed_Name(llont, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>llont:parameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.linklion.org/ontology#parameters">http://www.linklion.org/ontology#parameters</seealso>
    let parameters = Prefixed_Name(llont, "parameters") |> PrefixedName
    /// <summary>
    ///   <para>llont:storedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.linklion.org/ontology#storedAt">http://www.linklion.org/ontology#storedAt</seealso>
    let storedAt = Prefixed_Name(llont, "storedAt") |> PrefixedName
