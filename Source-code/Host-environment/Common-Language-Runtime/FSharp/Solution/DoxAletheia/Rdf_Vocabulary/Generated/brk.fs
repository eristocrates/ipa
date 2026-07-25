namespace http.brk.basisregistraties.overheid.nl.def.brk.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module brk =
    let _namespace_iri = Namespace_Iri brk |> NamespaceIRI
    /// <summary>
    ///   <para>brk:Perceel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Perceel</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#Perceel">http://brk.basisregistraties.overheid.nl/def/brk#Perceel</seealso>
    let Perceel = Prefixed_Name(brk, "Perceel") |> PrefixedName
    /// <summary>
    ///   <para>brk:grenslijn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>grenslijn</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#grenslijn">http://brk.basisregistraties.overheid.nl/def/brk#grenslijn</seealso>
    let grenslijn = Prefixed_Name(brk, "grenslijn") |> PrefixedName
    /// <summary>
    ///   <para>brk:perceelnummer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>perceelnummer</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummer">http://brk.basisregistraties.overheid.nl/def/brk#perceelnummer</seealso>
    let perceelnummer = Prefixed_Name(brk, "perceelnummer") |> PrefixedName
    /// <summary>
    ///   <para>brk:plaatscoordinaten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>plaatscoordinaten</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#plaatscoordinaten">http://brk.basisregistraties.overheid.nl/def/brk#plaatscoordinaten</seealso>
    let plaatscoordinaten = Prefixed_Name(brk, "plaatscoordinaten") |> PrefixedName
    /// <summary>
    ///   <para>brk:sectie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>sectie</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#sectie">http://brk.basisregistraties.overheid.nl/def/brk#sectie</seealso>
    let sectie = Prefixed_Name(brk, "sectie") |> PrefixedName
    /// <summary>
    ///   <para>brk:typeGrens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#typeGrens">http://brk.basisregistraties.overheid.nl/def/brk#typeGrens</seealso>
    let typeGrens = Prefixed_Name(brk, "typeGrens") |> PrefixedName

    /// <summary>
    ///   <para>brk:perceelnummerRotatie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>perceelnummerRotatie</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummerRotatie">http://brk.basisregistraties.overheid.nl/def/brk#perceelnummerRotatie</seealso>
    let perceelnummerRotatie =
        Prefixed_Name(brk, "perceelnummerRotatie") |> PrefixedName

    /// <summary>
    ///   <para>brk:kadastraleGrootte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>kadastraleGrootte</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGrootte">http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGrootte</seealso>
    let kadastraleGrootte = Prefixed_Name(brk, "kadastraleGrootte") |> PrefixedName
    /// <summary>
    ///   <para>brk:soortGrootte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>soortGrootte</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#soortGrootte">http://brk.basisregistraties.overheid.nl/def/brk#soortGrootte</seealso>
    let soortGrootte = Prefixed_Name(brk, "soortGrootte") |> PrefixedName
    /// <summary>
    ///   <para>brk:KadastraleGrens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>KadastraleGrens</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#KadastraleGrens">http://brk.basisregistraties.overheid.nl/def/brk#KadastraleGrens</seealso>
    let KadastraleGrens = Prefixed_Name(brk, "KadastraleGrens") |> PrefixedName
    /// <summary>
    ///   <para>brk:begrenzingPerceel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>begrenzingPerceel</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#begrenzingPerceel">http://brk.basisregistraties.overheid.nl/def/brk#begrenzingPerceel</seealso>
    let begrenzingPerceel = Prefixed_Name(brk, "begrenzingPerceel") |> PrefixedName
    /// <summary>
    ///   <para>brk:kadastraleGemeente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>kadastraleGemeente</para></remarks>
    /// <seealso href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGemeente">http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGemeente</seealso>
    let kadastraleGemeente = Prefixed_Name(brk, "kadastraleGemeente") |> PrefixedName
