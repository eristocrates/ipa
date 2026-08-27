namespace https.w3id.org.eep.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eep =
    let _namespace_iri = Namespace_Iri eep |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:eep#Execution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/eep#Execution">https://w3id.org/eep#Execution</seealso>
    let Execution = Prefixed_Name(eep, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eep#Executor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/eep#Executor">https://w3id.org/eep#Executor</seealso>
    let Executor = Prefixed_Name(eep, "Executor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eep#forQuality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/eep#forQuality">https://w3id.org/eep#forQuality</seealso>
    let forQuality = Prefixed_Name(eep, "forQuality") |> PrefixedName
