namespace http.google.com.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module luffy =
    let _namespace_iri = Namespace_Iri luffy |> NamespaceIRI
    /// <summary>
    ///   <para>luffy:+BernardVatant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://google.com/+BernardVatant">http://google.com/+BernardVatant</seealso>
    let ``_+BernardVatant`` = Prefixed_Name(luffy, "+BernardVatant") |> PrefixedName

    /// <summary>
    ///   <para>luffy:+Mar%C3%ADaPovedaVillal%C3%B3n</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://google.com/+Mar%C3%ADaPovedaVillal%C3%B3n">http://google.com/+Mar%C3%ADaPovedaVillal%C3%B3n</seealso>
    let ``_+Mar%C3%ADaPovedaVillal%C3%B3n`` =
        Prefixed_Name(luffy, "+Mar%C3%ADaPovedaVillal%C3%B3n") |> PrefixedName

    /// <summary>
    ///   <para>luffy:+MarianaCuradoMalta</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://google.com/+MarianaCuradoMalta">http://google.com/+MarianaCuradoMalta</seealso>
    let ``_+MarianaCuradoMalta`` =
        Prefixed_Name(luffy, "+MarianaCuradoMalta") |> PrefixedName

    /// <summary>
    ///   <para>luffy:+RonaldPoell</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://google.com/+RonaldPoell">http://google.com/+RonaldPoell</seealso>
    let ``_+RonaldPoell`` = Prefixed_Name(luffy, "+RonaldPoell") |> PrefixedName
