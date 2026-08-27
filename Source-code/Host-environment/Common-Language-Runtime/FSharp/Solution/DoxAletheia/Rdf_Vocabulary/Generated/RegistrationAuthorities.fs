namespace https.www.omg.org.spec.Commons.RegistrationAuthorities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module RegistrationAuthorities =
    let _namespace_iri = Namespace_Iri RegistrationAuthorities |> NamespaceIRI
    /// <summary>
    ///   <para>RegistrationAuthorities:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/">https://www.omg.org/spec/Commons/RegistrationAuthorities/</seealso>
    let _prefix_iri = Prefixed_Name(RegistrationAuthorities, "") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:RegisteredIdentifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegisteredIdentifier">https://www.omg.org/spec/Commons/RegistrationAuthorities/RegisteredIdentifier</seealso>
    let RegisteredIdentifier =
        Prefixed_Name(RegistrationAuthorities, "RegisteredIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:Registrar</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/Registrar">https://www.omg.org/spec/Commons/RegistrationAuthorities/Registrar</seealso>
    let Registrar = Prefixed_Name(RegistrationAuthorities, "Registrar") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationAuthority">https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationAuthority</seealso>
    let RegistrationAuthority =
        Prefixed_Name(RegistrationAuthorities, "RegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:RegistrationScheme</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationScheme">https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationScheme</seealso>
    let RegistrationScheme =
        Prefixed_Name(RegistrationAuthorities, "RegistrationScheme") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationService">https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistrationService</seealso>
    let RegistrationService =
        Prefixed_Name(RegistrationAuthorities, "RegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:Registry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/Registry">https://www.omg.org/spec/Commons/RegistrationAuthorities/Registry</seealso>
    let Registry = Prefixed_Name(RegistrationAuthorities, "Registry") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:RegistryEntry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistryEntry">https://www.omg.org/spec/Commons/RegistrationAuthorities/RegistryEntry</seealso>
    let RegistryEntry =
        Prefixed_Name(RegistrationAuthorities, "RegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:hasRegistrationAuthority</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/hasRegistrationAuthority">https://www.omg.org/spec/Commons/RegistrationAuthorities/hasRegistrationAuthority</seealso>
    let hasRegistrationAuthority =
        Prefixed_Name(RegistrationAuthorities, "hasRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:hasRegistrationDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/hasRegistrationDate">https://www.omg.org/spec/Commons/RegistrationAuthorities/hasRegistrationDate</seealso>
    let hasRegistrationDate =
        Prefixed_Name(RegistrationAuthorities, "hasRegistrationDate") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:isRegisteredBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegisteredBy">https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegisteredBy</seealso>
    let isRegisteredBy =
        Prefixed_Name(RegistrationAuthorities, "isRegisteredBy") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:isRegisteredIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegisteredIn">https://www.omg.org/spec/Commons/RegistrationAuthorities/isRegisteredIn</seealso>
    let isRegisteredIn =
        Prefixed_Name(RegistrationAuthorities, "isRegisteredIn") |> PrefixedName

    /// <summary>
    ///   <para>RegistrationAuthorities:registers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegistrationAuthorities/registers">https://www.omg.org/spec/Commons/RegistrationAuthorities/registers</seealso>
    let registers = Prefixed_Name(RegistrationAuthorities, "registers") |> PrefixedName
