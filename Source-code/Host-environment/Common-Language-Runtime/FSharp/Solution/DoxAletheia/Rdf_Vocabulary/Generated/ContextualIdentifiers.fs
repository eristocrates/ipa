namespace https.www.omg.org.spec.Commons.ContextualIdentifiers.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ContextualIdentifiers =
    let _namespace_iri = Namespace_Iri ContextualIdentifiers |> NamespaceIRI
    /// <summary>
    ///   <para>ContextualIdentifiers:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualIdentifiers/">https://www.omg.org/spec/Commons/ContextualIdentifiers/</seealso>
    let _prefix_iri = Prefixed_Name(ContextualIdentifiers, "") |> PrefixedName

    /// <summary>
    ///   <para>ContextualIdentifiers:ContextualIdentifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualIdentifiers/ContextualIdentifier">https://www.omg.org/spec/Commons/ContextualIdentifiers/ContextualIdentifier</seealso>
    let ContextualIdentifier =
        Prefixed_Name(ContextualIdentifiers, "ContextualIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ContextualIdentifiers:StructuredIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualIdentifiers/StructuredIdentifier">https://www.omg.org/spec/Commons/ContextualIdentifiers/StructuredIdentifier</seealso>
    let StructuredIdentifier =
        Prefixed_Name(ContextualIdentifiers, "StructuredIdentifier") |> PrefixedName
