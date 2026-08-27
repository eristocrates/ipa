namespace https.www.omg.org.spec.Commons.Identifiers.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Identifiers =
    let _namespace_iri = Namespace_Iri Identifiers |> NamespaceIRI
    /// <summary>
    ///   <para>Identifiers:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Identifiers/">https://www.omg.org/spec/Commons/Identifiers/</seealso>
    let _prefix_iri = Prefixed_Name(Identifiers, "") |> PrefixedName

    /// <summary>
    ///   <para>Identifiers:IdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Identifiers/IdentificationScheme">https://www.omg.org/spec/Commons/Identifiers/IdentificationScheme</seealso>
    let IdentificationScheme =
        Prefixed_Name(Identifiers, "IdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>Identifiers:Identifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Identifiers/Identifier">https://www.omg.org/spec/Commons/Identifiers/Identifier</seealso>
    let Identifier = Prefixed_Name(Identifiers, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>Identifiers:identifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Identifiers/identifiedBy">https://www.omg.org/spec/Commons/Identifiers/identifiedBy</seealso>
    let identifiedBy = Prefixed_Name(Identifiers, "identifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>Identifiers:identifies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Identifiers/identifies">https://www.omg.org/spec/Commons/Identifiers/identifies</seealso>
    let identifies = Prefixed_Name(Identifiers, "identifies") |> PrefixedName
    /// <summary>
    ///   <para>Identifiers:isIdentifiedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Identifiers/isIdentifiedBy">https://www.omg.org/spec/Commons/Identifiers/isIdentifiedBy</seealso>
    let isIdentifiedBy = Prefixed_Name(Identifiers, "isIdentifiedBy") |> PrefixedName
