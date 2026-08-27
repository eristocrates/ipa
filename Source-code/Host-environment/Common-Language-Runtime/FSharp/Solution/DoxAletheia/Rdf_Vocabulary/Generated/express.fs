namespace https.w3id.org.express.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module express =
    let _namespace_iri = Namespace_Iri express |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:express#BINARY</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#BINARY">https://w3id.org/express#BINARY</seealso>
    let BINARY = Prefixed_Name(express, "BINARY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#BOOLEAN</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#BOOLEAN">https://w3id.org/express#BOOLEAN</seealso>
    let BOOLEAN = Prefixed_Name(express, "BOOLEAN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#ENUMERATION</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#ENUMERATION">https://w3id.org/express#ENUMERATION</seealso>
    let ENUMERATION = Prefixed_Name(express, "ENUMERATION") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#INTEGER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#INTEGER">https://w3id.org/express#INTEGER</seealso>
    let INTEGER = Prefixed_Name(express, "INTEGER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#INTEGER_EmptyList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#INTEGER_EmptyList">https://w3id.org/express#INTEGER_EmptyList</seealso>
    let INTEGER_EmptyList = Prefixed_Name(express, "INTEGER_EmptyList") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#INTEGER_List</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#INTEGER_List">https://w3id.org/express#INTEGER_List</seealso>
    let INTEGER_List = Prefixed_Name(express, "INTEGER_List") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#LOGICAL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#LOGICAL">https://w3id.org/express#LOGICAL</seealso>
    let LOGICAL = Prefixed_Name(express, "LOGICAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#NUMBER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#NUMBER">https://w3id.org/express#NUMBER</seealso>
    let NUMBER = Prefixed_Name(express, "NUMBER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#REAL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#REAL">https://w3id.org/express#REAL</seealso>
    let REAL = Prefixed_Name(express, "REAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#REAL_EmptyList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#REAL_EmptyList">https://w3id.org/express#REAL_EmptyList</seealso>
    let REAL_EmptyList = Prefixed_Name(express, "REAL_EmptyList") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#REAL_List</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#REAL_List">https://w3id.org/express#REAL_List</seealso>
    let REAL_List = Prefixed_Name(express, "REAL_List") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#SELECT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#SELECT">https://w3id.org/express#SELECT</seealso>
    let SELECT = Prefixed_Name(express, "SELECT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#STRING</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#STRING">https://w3id.org/express#STRING</seealso>
    let STRING = Prefixed_Name(express, "STRING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express#hasSet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express#hasSet">https://w3id.org/express#hasSet</seealso>
    let hasSet = Prefixed_Name(express, "hasSet") |> PrefixedName
