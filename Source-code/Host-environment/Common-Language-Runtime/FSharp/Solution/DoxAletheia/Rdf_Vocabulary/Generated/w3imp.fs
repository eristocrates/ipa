namespace https.w3id.org._function.vocabulary.implementation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3imp =
    let _namespace_iri = Namespace_Iri w3imp |> NamespaceIRI
    /// <summary>
    ///   <para>w3imp:JavaClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, distributed as a JAVA class snippet file</para>
    /// labels<para>JAVA class</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#JavaClass">https://w3id.org/function/vocabulary/implementation#JavaClass</seealso>
    let JavaClass = Prefixed_Name(w3imp, "JavaClass") |> PrefixedName

    /// <summary>
    ///   <para>w3imp:JavaScriptImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, coded in JavaScript</para>
    /// labels<para>JavaScript Function</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#JavaScriptImplementation">https://w3id.org/function/vocabulary/implementation#JavaScriptImplementation</seealso>
    let JavaScriptImplementation =
        Prefixed_Name(w3imp, "JavaScriptImplementation") |> PrefixedName

    /// <summary>
    ///   <para>w3imp:WebApi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, distributed as a Web API</para>
    /// labels<para>Web API</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#WebApi">https://w3id.org/function/vocabulary/implementation#WebApi</seealso>
    let WebApi = Prefixed_Name(w3imp, "WebApi") |> PrefixedName
    /// <summary>
    ///   <para>w3imp:NpmPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, distributed as an NPM package</para>
    /// labels<para>NPM Package</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#NpmPackage">https://w3id.org/function/vocabulary/implementation#NpmPackage</seealso>
    let NpmPackage = Prefixed_Name(w3imp, "NpmPackage") |> PrefixedName
    /// <summary>
    ///   <para>w3imp:SQLImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, as used in a SQL query</para>
    /// labels<para>SQL Function</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#SQLImplementation">https://w3id.org/function/vocabulary/implementation#SQLImplementation</seealso>
    let SQLImplementation = Prefixed_Name(w3imp, "SQLImplementation") |> PrefixedName
    /// <summary>
    ///   <para>w3imp:class-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Connects a class name to an implemenation description.</para>
    /// labels<para>class name</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#class-name">https://w3id.org/function/vocabulary/implementation#class-name</seealso>
    let class_name = Prefixed_Name(w3imp, "class-name") |> PrefixedName
    /// <summary>
    ///   <para>w3imp:JavaImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, coded in JAVA</para>
    /// labels<para>JAVA implementation</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#JavaImplementation">https://w3id.org/function/vocabulary/implementation#JavaImplementation</seealso>
    let JavaImplementation = Prefixed_Name(w3imp, "JavaImplementation") |> PrefixedName
    /// <summary>
    ///   <para>w3imp:JavaScriptFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, distributed as a JavaScript snippet</para>
    /// labels<para>JavaScript function</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#JavaScriptFunction">https://w3id.org/function/vocabulary/implementation#JavaScriptFunction</seealso>
    let JavaScriptFunction = Prefixed_Name(w3imp, "JavaScriptFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3imp:JsonApi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, distributed as a JSON (Hydra) API</para>
    /// labels<para>JSON API</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#JsonApi">https://w3id.org/function/vocabulary/implementation#JsonApi</seealso>
    let JsonApi = Prefixed_Name(w3imp, "JsonApi") |> PrefixedName

    /// <summary>
    ///   <para>w3imp:OpenRefineImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, as used in OpenRefine</para>
    /// labels<para>Openrefine Function</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#OpenRefineImplementation">https://w3id.org/function/vocabulary/implementation#OpenRefineImplementation</seealso>
    let OpenRefineImplementation =
        Prefixed_Name(w3imp, "OpenRefineImplementation") |> PrefixedName

    /// <summary>
    ///   <para>w3imp:SPARQLImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, as used in a SPARQL query</para>
    /// labels<para>SPARQL Function</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#SPARQLImplementation">https://w3id.org/function/vocabulary/implementation#SPARQLImplementation</seealso>
    let SPARQLImplementation =
        Prefixed_Name(w3imp, "SPARQLImplementation") |> PrefixedName

    /// <summary>
    ///   <para>w3imp:XPATHImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fno:Implementation, as used in an XPath expression</para>
    /// labels<para>XPath Function</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation#XPATHImplementation">https://w3id.org/function/vocabulary/implementation#XPATHImplementation</seealso>
    let XPATHImplementation =
        Prefixed_Name(w3imp, "XPATHImplementation") |> PrefixedName
