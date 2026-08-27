namespace https.purl.org.cityexplorer.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ce =
    let _namespace_iri = Namespace_Iri ce |> NamespaceIRI
    /// <summary>
    ///   <para>ce:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"CityExplorer :ce"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#">https://purl.org/cityexplorer#</seealso>
    let _prefix_iri = Prefixed_Name(ce, "") |> PrefixedName
    /// <summary>
    ///   <para>ce:100_FiraBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#100_FiraBarcelona">https://purl.org/cityexplorer#100_FiraBarcelona</seealso>
    let _100_FiraBarcelona = Prefixed_Name(ce, "100_FiraBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:100_HotelPalaceM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#100_HotelPalaceM%C3%A0laga">https://purl.org/cityexplorer#100_HotelPalaceM%C3%A0laga</seealso>
    let ``_100_HotelPalaceM%C3%A0laga`` =
        Prefixed_Name(ce, "100_HotelPalaceM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:100_MuseuBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#100_MuseuBilbao">https://purl.org/cityexplorer#100_MuseuBilbao</seealso>
    let _100_MuseuBilbao = Prefixed_Name(ce, "100_MuseuBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:100_RestaurantGourmetToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#100_RestaurantGourmetToledo">https://purl.org/cityexplorer#100_RestaurantGourmetToledo</seealso>
    let _100_RestaurantGourmetToledo =
        Prefixed_Name(ce, "100_RestaurantGourmetToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:100_TransPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#100_TransPamplona">https://purl.org/cityexplorer#100_TransPamplona</seealso>
    let _100_TransPamplona = Prefixed_Name(ce, "100_TransPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:10_CastellToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#10_CastellToledo">https://purl.org/cityexplorer#10_CastellToledo</seealso>
    let _10_CastellToledo = Prefixed_Name(ce, "10_CastellToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:10_Congr%C3%A9sBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#10_Congr%C3%A9sBarcelona">https://purl.org/cityexplorer#10_Congr%C3%A9sBarcelona</seealso>
    let ``_10_Congr%C3%A9sBarcelona`` =
        Prefixed_Name(ce, "10_Congr%C3%A9sBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:10_HotelRoyalCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#10_HotelRoyalCadis">https://purl.org/cityexplorer#10_HotelRoyalCadis</seealso>
    let _10_HotelRoyalCadis = Prefixed_Name(ce, "10_HotelRoyalCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:10_RestaurantDeliciaCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#10_RestaurantDeliciaCadis">https://purl.org/cityexplorer#10_RestaurantDeliciaCadis</seealso>
    let _10_RestaurantDeliciaCadis =
        Prefixed_Name(ce, "10_RestaurantDeliciaCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:10_TransSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#10_TransSevilla">https://purl.org/cityexplorer#10_TransSevilla</seealso>
    let _10_TransSevilla = Prefixed_Name(ce, "10_TransSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:11_CarnavalBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#11_CarnavalBilbao">https://purl.org/cityexplorer#11_CarnavalBilbao</seealso>
    let _11_CarnavalBilbao = Prefixed_Name(ce, "11_CarnavalBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:11_HotelRoyalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#11_HotelRoyalMadrid">https://purl.org/cityexplorer#11_HotelRoyalMadrid</seealso>
    let _11_HotelRoyalMadrid = Prefixed_Name(ce, "11_HotelRoyalMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:11_ParcToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#11_ParcToledo">https://purl.org/cityexplorer#11_ParcToledo</seealso>
    let _11_ParcToledo = Prefixed_Name(ce, "11_ParcToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:11_RestaurantGourmetMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#11_RestaurantGourmetMadrid">https://purl.org/cityexplorer#11_RestaurantGourmetMadrid</seealso>
    let _11_RestaurantGourmetMadrid =
        Prefixed_Name(ce, "11_RestaurantGourmetMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:11_TransVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#11_TransVal%C3%A8ncia">https://purl.org/cityexplorer#11_TransVal%C3%A8ncia</seealso>
    let ``_11_TransVal%C3%A8ncia`` =
        Prefixed_Name(ce, "11_TransVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:12_CatedralCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#12_CatedralCadis">https://purl.org/cityexplorer#12_CatedralCadis</seealso>
    let _12_CatedralCadis = Prefixed_Name(ce, "12_CatedralCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:12_CitySevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#12_CitySevilla">https://purl.org/cityexplorer#12_CitySevilla</seealso>
    let _12_CitySevilla = Prefixed_Name(ce, "12_CitySevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:12_FiraBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#12_FiraBarcelona">https://purl.org/cityexplorer#12_FiraBarcelona</seealso>
    let _12_FiraBarcelona = Prefixed_Name(ce, "12_FiraBarcelona") |> PrefixedName
    /// <summary>
    ///   <para>ce:12_HotelRoyalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#12_HotelRoyalMadrid">https://purl.org/cityexplorer#12_HotelRoyalMadrid</seealso>
    let _12_HotelRoyalMadrid = Prefixed_Name(ce, "12_HotelRoyalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:12_RestaurantSaborCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#12_RestaurantSaborCadis">https://purl.org/cityexplorer#12_RestaurantSaborCadis</seealso>
    let _12_RestaurantSaborCadis =
        Prefixed_Name(ce, "12_RestaurantSaborCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:13_CityCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#13_CityCadis">https://purl.org/cityexplorer#13_CityCadis</seealso>
    let _13_CityCadis = Prefixed_Name(ce, "13_CityCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:13_Congr%C3%A9sVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#13_Congr%C3%A9sVal%C3%A8ncia">https://purl.org/cityexplorer#13_Congr%C3%A9sVal%C3%A8ncia</seealso>
    let ``_13_Congr%C3%A9sVal%C3%A8ncia`` =
        Prefixed_Name(ce, "13_Congr%C3%A9sVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:13_HotelDelMarSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#13_HotelDelMarSevilla">https://purl.org/cityexplorer#13_HotelDelMarSevilla</seealso>
    let _13_HotelDelMarSevilla =
        Prefixed_Name(ce, "13_HotelDelMarSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:13_PalauPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#13_PalauPamplona">https://purl.org/cityexplorer#13_PalauPamplona</seealso>
    let _13_PalauPamplona = Prefixed_Name(ce, "13_PalauPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:13_RestaurantDeliciaSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#13_RestaurantDeliciaSaragossa">https://purl.org/cityexplorer#13_RestaurantDeliciaSaragossa</seealso>
    let _13_RestaurantDeliciaSaragossa =
        Prefixed_Name(ce, "13_RestaurantDeliciaSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:14_CastellPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#14_CastellPamplona">https://purl.org/cityexplorer#14_CastellPamplona</seealso>
    let _14_CastellPamplona = Prefixed_Name(ce, "14_CastellPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:14_Congr%C3%A9sToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#14_Congr%C3%A9sToledo">https://purl.org/cityexplorer#14_Congr%C3%A9sToledo</seealso>
    let ``_14_Congr%C3%A9sToledo`` =
        Prefixed_Name(ce, "14_Congr%C3%A9sToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:14_HotelPalaceMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#14_HotelPalaceMadrid">https://purl.org/cityexplorer#14_HotelPalaceMadrid</seealso>
    let _14_HotelPalaceMadrid =
        Prefixed_Name(ce, "14_HotelPalaceMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:14_MoviPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#14_MoviPamplona">https://purl.org/cityexplorer#14_MoviPamplona</seealso>
    let _14_MoviPamplona = Prefixed_Name(ce, "14_MoviPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:14_RestaurantFusi%C3%B3Val%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#14_RestaurantFusi%C3%B3Val%C3%A8ncia">https://purl.org/cityexplorer#14_RestaurantFusi%C3%B3Val%C3%A8ncia</seealso>
    let ``_14_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Prefixed_Name(ce, "14_RestaurantFusi%C3%B3Val%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:15_CastellCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#15_CastellCadis">https://purl.org/cityexplorer#15_CastellCadis</seealso>
    let _15_CastellCadis = Prefixed_Name(ce, "15_CastellCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:15_FestivalSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#15_FestivalSaragossa">https://purl.org/cityexplorer#15_FestivalSaragossa</seealso>
    let _15_FestivalSaragossa =
        Prefixed_Name(ce, "15_FestivalSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:15_HotelPalaceCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#15_HotelPalaceCadis">https://purl.org/cityexplorer#15_HotelPalaceCadis</seealso>
    let _15_HotelPalaceCadis = Prefixed_Name(ce, "15_HotelPalaceCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:15_MoviCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#15_MoviCadis">https://purl.org/cityexplorer#15_MoviCadis</seealso>
    let _15_MoviCadis = Prefixed_Name(ce, "15_MoviCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:15_RestaurantDeliciaSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#15_RestaurantDeliciaSaragossa">https://purl.org/cityexplorer#15_RestaurantDeliciaSaragossa</seealso>
    let _15_RestaurantDeliciaSaragossa =
        Prefixed_Name(ce, "15_RestaurantDeliciaSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:16_CastellBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#16_CastellBarcelona">https://purl.org/cityexplorer#16_CastellBarcelona</seealso>
    let _16_CastellBarcelona = Prefixed_Name(ce, "16_CastellBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:16_CityM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#16_CityM%C3%A0laga">https://purl.org/cityexplorer#16_CityM%C3%A0laga</seealso>
    let ``_16_CityM%C3%A0laga`` =
        Prefixed_Name(ce, "16_CityM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:16_ConcertSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#16_ConcertSevilla">https://purl.org/cityexplorer#16_ConcertSevilla</seealso>
    let _16_ConcertSevilla = Prefixed_Name(ce, "16_ConcertSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:16_HotelPalaceSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#16_HotelPalaceSaragossa">https://purl.org/cityexplorer#16_HotelPalaceSaragossa</seealso>
    let _16_HotelPalaceSaragossa =
        Prefixed_Name(ce, "16_HotelPalaceSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:16_RestaurantFusi%C3%B3Pamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#16_RestaurantFusi%C3%B3Pamplona">https://purl.org/cityexplorer#16_RestaurantFusi%C3%B3Pamplona</seealso>
    let ``_16_RestaurantFusi%C3%B3Pamplona`` =
        Prefixed_Name(ce, "16_RestaurantFusi%C3%B3Pamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:17_CarnavalVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#17_CarnavalVal%C3%A8ncia">https://purl.org/cityexplorer#17_CarnavalVal%C3%A8ncia</seealso>
    let ``_17_CarnavalVal%C3%A8ncia`` =
        Prefixed_Name(ce, "17_CarnavalVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:17_HotelDelMarToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#17_HotelDelMarToledo">https://purl.org/cityexplorer#17_HotelDelMarToledo</seealso>
    let _17_HotelDelMarToledo =
        Prefixed_Name(ce, "17_HotelDelMarToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:17_ParcMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#17_ParcMadrid">https://purl.org/cityexplorer#17_ParcMadrid</seealso>
    let _17_ParcMadrid = Prefixed_Name(ce, "17_ParcMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:17_RestaurantGourmetCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#17_RestaurantGourmetCadis">https://purl.org/cityexplorer#17_RestaurantGourmetCadis</seealso>
    let _17_RestaurantGourmetCadis =
        Prefixed_Name(ce, "17_RestaurantGourmetCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:17_UrbanBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#17_UrbanBilbao">https://purl.org/cityexplorer#17_UrbanBilbao</seealso>
    let _17_UrbanBilbao = Prefixed_Name(ce, "17_UrbanBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:18_FestivalSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#18_FestivalSaragossa">https://purl.org/cityexplorer#18_FestivalSaragossa</seealso>
    let _18_FestivalSaragossa =
        Prefixed_Name(ce, "18_FestivalSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:18_HotelPalaceMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#18_HotelPalaceMadrid">https://purl.org/cityexplorer#18_HotelPalaceMadrid</seealso>
    let _18_HotelPalaceMadrid =
        Prefixed_Name(ce, "18_HotelPalaceMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:18_MetroBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#18_MetroBilbao">https://purl.org/cityexplorer#18_MetroBilbao</seealso>
    let _18_MetroBilbao = Prefixed_Name(ce, "18_MetroBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:18_MuseuM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#18_MuseuM%C3%A0laga">https://purl.org/cityexplorer#18_MuseuM%C3%A0laga</seealso>
    let ``_18_MuseuM%C3%A0laga`` =
        Prefixed_Name(ce, "18_MuseuM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:18_RestaurantSaborCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#18_RestaurantSaborCadis">https://purl.org/cityexplorer#18_RestaurantSaborCadis</seealso>
    let _18_RestaurantSaborCadis =
        Prefixed_Name(ce, "18_RestaurantSaborCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:19_CityBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#19_CityBilbao">https://purl.org/cityexplorer#19_CityBilbao</seealso>
    let _19_CityBilbao = Prefixed_Name(ce, "19_CityBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:19_ConcertVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#19_ConcertVal%C3%A8ncia">https://purl.org/cityexplorer#19_ConcertVal%C3%A8ncia</seealso>
    let ``_19_ConcertVal%C3%A8ncia`` =
        Prefixed_Name(ce, "19_ConcertVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:19_HotelSolBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#19_HotelSolBilbao">https://purl.org/cityexplorer#19_HotelSolBilbao</seealso>
    let _19_HotelSolBilbao = Prefixed_Name(ce, "19_HotelSolBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:19_PalauBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#19_PalauBarcelona">https://purl.org/cityexplorer#19_PalauBarcelona</seealso>
    let _19_PalauBarcelona = Prefixed_Name(ce, "19_PalauBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:19_RestaurantFusi%C3%B3Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#19_RestaurantFusi%C3%B3Madrid">https://purl.org/cityexplorer#19_RestaurantFusi%C3%B3Madrid</seealso>
    let ``_19_RestaurantFusi%C3%B3Madrid`` =
        Prefixed_Name(ce, "19_RestaurantFusi%C3%B3Madrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:1_CastellSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#1_CastellSaragossa">https://purl.org/cityexplorer#1_CastellSaragossa</seealso>
    let _1_CastellSaragossa = Prefixed_Name(ce, "1_CastellSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:1_Congr%C3%A9sCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#1_Congr%C3%A9sCadis">https://purl.org/cityexplorer#1_Congr%C3%A9sCadis</seealso>
    let ``_1_Congr%C3%A9sCadis`` =
        Prefixed_Name(ce, "1_Congr%C3%A9sCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:1_HotelVistaSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#1_HotelVistaSevilla">https://purl.org/cityexplorer#1_HotelVistaSevilla</seealso>
    let _1_HotelVistaSevilla = Prefixed_Name(ce, "1_HotelVistaSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:1_RestaurantTradici%C3%B3Toledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#1_RestaurantTradici%C3%B3Toledo">https://purl.org/cityexplorer#1_RestaurantTradici%C3%B3Toledo</seealso>
    let ``_1_RestaurantTradici%C3%B3Toledo`` =
        Prefixed_Name(ce, "1_RestaurantTradici%C3%B3Toledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:1_UrbanMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#1_UrbanMadrid">https://purl.org/cityexplorer#1_UrbanMadrid</seealso>
    let _1_UrbanMadrid = Prefixed_Name(ce, "1_UrbanMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:20_CarnavalSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#20_CarnavalSevilla">https://purl.org/cityexplorer#20_CarnavalSevilla</seealso>
    let _20_CarnavalSevilla = Prefixed_Name(ce, "20_CarnavalSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:20_CatedralBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#20_CatedralBarcelona">https://purl.org/cityexplorer#20_CatedralBarcelona</seealso>
    let _20_CatedralBarcelona =
        Prefixed_Name(ce, "20_CatedralBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:20_HotelVistaVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#20_HotelVistaVal%C3%A8ncia">https://purl.org/cityexplorer#20_HotelVistaVal%C3%A8ncia</seealso>
    let ``_20_HotelVistaVal%C3%A8ncia`` =
        Prefixed_Name(ce, "20_HotelVistaVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:20_MoviBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#20_MoviBilbao">https://purl.org/cityexplorer#20_MoviBilbao</seealso>
    let _20_MoviBilbao = Prefixed_Name(ce, "20_MoviBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:20_RestaurantGourmetM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#20_RestaurantGourmetM%C3%A0laga">https://purl.org/cityexplorer#20_RestaurantGourmetM%C3%A0laga</seealso>
    let ``_20_RestaurantGourmetM%C3%A0laga`` =
        Prefixed_Name(ce, "20_RestaurantGourmetM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:21_CatedralM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#21_CatedralM%C3%A0laga">https://purl.org/cityexplorer#21_CatedralM%C3%A0laga</seealso>
    let ``_21_CatedralM%C3%A0laga`` =
        Prefixed_Name(ce, "21_CatedralM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:21_CityPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#21_CityPamplona">https://purl.org/cityexplorer#21_CityPamplona</seealso>
    let _21_CityPamplona = Prefixed_Name(ce, "21_CityPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:21_FiraSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#21_FiraSevilla">https://purl.org/cityexplorer#21_FiraSevilla</seealso>
    let _21_FiraSevilla = Prefixed_Name(ce, "21_FiraSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:21_HotelSolVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#21_HotelSolVal%C3%A8ncia">https://purl.org/cityexplorer#21_HotelSolVal%C3%A8ncia</seealso>
    let ``_21_HotelSolVal%C3%A8ncia`` =
        Prefixed_Name(ce, "21_HotelSolVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:21_RestaurantDeliciaMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#21_RestaurantDeliciaMadrid">https://purl.org/cityexplorer#21_RestaurantDeliciaMadrid</seealso>
    let _21_RestaurantDeliciaMadrid =
        Prefixed_Name(ce, "21_RestaurantDeliciaMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:22_CatedralVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#22_CatedralVal%C3%A8ncia">https://purl.org/cityexplorer#22_CatedralVal%C3%A8ncia</seealso>
    let ``_22_CatedralVal%C3%A8ncia`` =
        Prefixed_Name(ce, "22_CatedralVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:22_FestivalSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#22_FestivalSevilla">https://purl.org/cityexplorer#22_FestivalSevilla</seealso>
    let _22_FestivalSevilla = Prefixed_Name(ce, "22_FestivalSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:22_HotelVistaM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#22_HotelVistaM%C3%A0laga">https://purl.org/cityexplorer#22_HotelVistaM%C3%A0laga</seealso>
    let ``_22_HotelVistaM%C3%A0laga`` =
        Prefixed_Name(ce, "22_HotelVistaM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:22_RestaurantTradici%C3%B3Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#22_RestaurantTradici%C3%B3Madrid">https://purl.org/cityexplorer#22_RestaurantTradici%C3%B3Madrid</seealso>
    let ``_22_RestaurantTradici%C3%B3Madrid`` =
        Prefixed_Name(ce, "22_RestaurantTradici%C3%B3Madrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:22_UrbanSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#22_UrbanSaragossa">https://purl.org/cityexplorer#22_UrbanSaragossa</seealso>
    let _22_UrbanSaragossa = Prefixed_Name(ce, "22_UrbanSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:23_CastellSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#23_CastellSantSebasti%C3%A0">https://purl.org/cityexplorer#23_CastellSantSebasti%C3%A0</seealso>
    let ``_23_CastellSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "23_CastellSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:23_Congr%C3%A9sSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#23_Congr%C3%A9sSaragossa">https://purl.org/cityexplorer#23_Congr%C3%A9sSaragossa</seealso>
    let ``_23_Congr%C3%A9sSaragossa`` =
        Prefixed_Name(ce, "23_Congr%C3%A9sSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:23_HotelVistaToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#23_HotelVistaToledo">https://purl.org/cityexplorer#23_HotelVistaToledo</seealso>
    let _23_HotelVistaToledo = Prefixed_Name(ce, "23_HotelVistaToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:23_MoviPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#23_MoviPamplona">https://purl.org/cityexplorer#23_MoviPamplona</seealso>
    let _23_MoviPamplona = Prefixed_Name(ce, "23_MoviPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:23_RestaurantFusi%C3%B3Sevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#23_RestaurantFusi%C3%B3Sevilla">https://purl.org/cityexplorer#23_RestaurantFusi%C3%B3Sevilla</seealso>
    let ``_23_RestaurantFusi%C3%B3Sevilla`` =
        Prefixed_Name(ce, "23_RestaurantFusi%C3%B3Sevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:24_CastellSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#24_CastellSaragossa">https://purl.org/cityexplorer#24_CastellSaragossa</seealso>
    let _24_CastellSaragossa = Prefixed_Name(ce, "24_CastellSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:24_Congr%C3%A9sBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#24_Congr%C3%A9sBarcelona">https://purl.org/cityexplorer#24_Congr%C3%A9sBarcelona</seealso>
    let ``_24_Congr%C3%A9sBarcelona`` =
        Prefixed_Name(ce, "24_Congr%C3%A9sBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:24_HotelRoyalSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#24_HotelRoyalSaragossa">https://purl.org/cityexplorer#24_HotelRoyalSaragossa</seealso>
    let _24_HotelRoyalSaragossa =
        Prefixed_Name(ce, "24_HotelRoyalSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:24_RestaurantGourmetSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#24_RestaurantGourmetSevilla">https://purl.org/cityexplorer#24_RestaurantGourmetSevilla</seealso>
    let _24_RestaurantGourmetSevilla =
        Prefixed_Name(ce, "24_RestaurantGourmetSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:24_UrbanVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#24_UrbanVal%C3%A8ncia">https://purl.org/cityexplorer#24_UrbanVal%C3%A8ncia</seealso>
    let ``_24_UrbanVal%C3%A8ncia`` =
        Prefixed_Name(ce, "24_UrbanVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:25_CarnavalM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#25_CarnavalM%C3%A0laga">https://purl.org/cityexplorer#25_CarnavalM%C3%A0laga</seealso>
    let ``_25_CarnavalM%C3%A0laga`` =
        Prefixed_Name(ce, "25_CarnavalM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:25_HotelRoyalSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#25_HotelRoyalSevilla">https://purl.org/cityexplorer#25_HotelRoyalSevilla</seealso>
    let _25_HotelRoyalSevilla =
        Prefixed_Name(ce, "25_HotelRoyalSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:25_MetroSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#25_MetroSaragossa">https://purl.org/cityexplorer#25_MetroSaragossa</seealso>
    let _25_MetroSaragossa = Prefixed_Name(ce, "25_MetroSaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:25_ParcBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#25_ParcBilbao">https://purl.org/cityexplorer#25_ParcBilbao</seealso>
    let _25_ParcBilbao = Prefixed_Name(ce, "25_ParcBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:25_RestaurantFusi%C3%B3Sevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#25_RestaurantFusi%C3%B3Sevilla">https://purl.org/cityexplorer#25_RestaurantFusi%C3%B3Sevilla</seealso>
    let ``_25_RestaurantFusi%C3%B3Sevilla`` =
        Prefixed_Name(ce, "25_RestaurantFusi%C3%B3Sevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:26_CarnavalBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#26_CarnavalBilbao">https://purl.org/cityexplorer#26_CarnavalBilbao</seealso>
    let _26_CarnavalBilbao = Prefixed_Name(ce, "26_CarnavalBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:26_CatedralSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#26_CatedralSaragossa">https://purl.org/cityexplorer#26_CatedralSaragossa</seealso>
    let _26_CatedralSaragossa =
        Prefixed_Name(ce, "26_CatedralSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:26_HotelSolCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#26_HotelSolCadis">https://purl.org/cityexplorer#26_HotelSolCadis</seealso>
    let _26_HotelSolCadis = Prefixed_Name(ce, "26_HotelSolCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:26_MetroPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#26_MetroPamplona">https://purl.org/cityexplorer#26_MetroPamplona</seealso>
    let _26_MetroPamplona = Prefixed_Name(ce, "26_MetroPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:26_RestaurantGourmetPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#26_RestaurantGourmetPamplona">https://purl.org/cityexplorer#26_RestaurantGourmetPamplona</seealso>
    let _26_RestaurantGourmetPamplona =
        Prefixed_Name(ce, "26_RestaurantGourmetPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:27_CastellM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#27_CastellM%C3%A0laga">https://purl.org/cityexplorer#27_CastellM%C3%A0laga</seealso>
    let ``_27_CastellM%C3%A0laga`` =
        Prefixed_Name(ce, "27_CastellM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:27_Congr%C3%A9sBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#27_Congr%C3%A9sBilbao">https://purl.org/cityexplorer#27_Congr%C3%A9sBilbao</seealso>
    let ``_27_Congr%C3%A9sBilbao`` =
        Prefixed_Name(ce, "27_Congr%C3%A9sBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:27_HotelSolBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#27_HotelSolBilbao">https://purl.org/cityexplorer#27_HotelSolBilbao</seealso>
    let _27_HotelSolBilbao = Prefixed_Name(ce, "27_HotelSolBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:27_RestaurantTradici%C3%B3SantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#27_RestaurantTradici%C3%B3SantSebasti%C3%A0">https://purl.org/cityexplorer#27_RestaurantTradici%C3%B3SantSebasti%C3%A0</seealso>
    let ``_27_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        Prefixed_Name(ce, "27_RestaurantTradici%C3%B3SantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:27_UrbanBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#27_UrbanBarcelona">https://purl.org/cityexplorer#27_UrbanBarcelona</seealso>
    let _27_UrbanBarcelona = Prefixed_Name(ce, "27_UrbanBarcelona") |> PrefixedName
    /// <summary>
    ///   <para>ce:28_FestivalToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#28_FestivalToledo">https://purl.org/cityexplorer#28_FestivalToledo</seealso>
    let _28_FestivalToledo = Prefixed_Name(ce, "28_FestivalToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:28_HotelDelMarSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#28_HotelDelMarSantSebasti%C3%A0">https://purl.org/cityexplorer#28_HotelDelMarSantSebasti%C3%A0</seealso>
    let ``_28_HotelDelMarSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "28_HotelDelMarSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:28_ParcSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#28_ParcSantSebasti%C3%A0">https://purl.org/cityexplorer#28_ParcSantSebasti%C3%A0</seealso>
    let ``_28_ParcSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "28_ParcSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:28_RestaurantFusi%C3%B3Cadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#28_RestaurantFusi%C3%B3Cadis">https://purl.org/cityexplorer#28_RestaurantFusi%C3%B3Cadis</seealso>
    let ``_28_RestaurantFusi%C3%B3Cadis`` =
        Prefixed_Name(ce, "28_RestaurantFusi%C3%B3Cadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:28_UrbanPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#28_UrbanPamplona">https://purl.org/cityexplorer#28_UrbanPamplona</seealso>
    let _28_UrbanPamplona = Prefixed_Name(ce, "28_UrbanPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:29_CastellSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#29_CastellSantSebasti%C3%A0">https://purl.org/cityexplorer#29_CastellSantSebasti%C3%A0</seealso>
    let ``_29_CastellSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "29_CastellSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:29_FiraMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#29_FiraMadrid">https://purl.org/cityexplorer#29_FiraMadrid</seealso>
    let _29_FiraMadrid = Prefixed_Name(ce, "29_FiraMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:29_HotelRoyalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#29_HotelRoyalMadrid">https://purl.org/cityexplorer#29_HotelRoyalMadrid</seealso>
    let _29_HotelRoyalMadrid = Prefixed_Name(ce, "29_HotelRoyalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:29_MetroSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#29_MetroSantSebasti%C3%A0">https://purl.org/cityexplorer#29_MetroSantSebasti%C3%A0</seealso>
    let ``_29_MetroSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "29_MetroSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:29_RestaurantDeliciaVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#29_RestaurantDeliciaVal%C3%A8ncia">https://purl.org/cityexplorer#29_RestaurantDeliciaVal%C3%A8ncia</seealso>
    let ``_29_RestaurantDeliciaVal%C3%A8ncia`` =
        Prefixed_Name(ce, "29_RestaurantDeliciaVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:2_CarnavalCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#2_CarnavalCadis">https://purl.org/cityexplorer#2_CarnavalCadis</seealso>
    let _2_CarnavalCadis = Prefixed_Name(ce, "2_CarnavalCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:2_CastellSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#2_CastellSevilla">https://purl.org/cityexplorer#2_CastellSevilla</seealso>
    let _2_CastellSevilla = Prefixed_Name(ce, "2_CastellSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:2_HotelRoyalPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#2_HotelRoyalPamplona">https://purl.org/cityexplorer#2_HotelRoyalPamplona</seealso>
    let _2_HotelRoyalPamplona =
        Prefixed_Name(ce, "2_HotelRoyalPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:2_RestaurantGourmetMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#2_RestaurantGourmetMadrid">https://purl.org/cityexplorer#2_RestaurantGourmetMadrid</seealso>
    let _2_RestaurantGourmetMadrid =
        Prefixed_Name(ce, "2_RestaurantGourmetMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:2_TransBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#2_TransBilbao">https://purl.org/cityexplorer#2_TransBilbao</seealso>
    let _2_TransBilbao = Prefixed_Name(ce, "2_TransBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:30_CastellVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#30_CastellVal%C3%A8ncia">https://purl.org/cityexplorer#30_CastellVal%C3%A8ncia</seealso>
    let ``_30_CastellVal%C3%A8ncia`` =
        Prefixed_Name(ce, "30_CastellVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:30_FestivalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#30_FestivalMadrid">https://purl.org/cityexplorer#30_FestivalMadrid</seealso>
    let _30_FestivalMadrid = Prefixed_Name(ce, "30_FestivalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:30_HotelDelMarPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#30_HotelDelMarPamplona">https://purl.org/cityexplorer#30_HotelDelMarPamplona</seealso>
    let _30_HotelDelMarPamplona =
        Prefixed_Name(ce, "30_HotelDelMarPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:30_RestaurantDeliciaPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#30_RestaurantDeliciaPamplona">https://purl.org/cityexplorer#30_RestaurantDeliciaPamplona</seealso>
    let _30_RestaurantDeliciaPamplona =
        Prefixed_Name(ce, "30_RestaurantDeliciaPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:30_UrbanM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#30_UrbanM%C3%A0laga">https://purl.org/cityexplorer#30_UrbanM%C3%A0laga</seealso>
    let ``_30_UrbanM%C3%A0laga`` =
        Prefixed_Name(ce, "30_UrbanM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:31_FiraMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#31_FiraMadrid">https://purl.org/cityexplorer#31_FiraMadrid</seealso>
    let _31_FiraMadrid = Prefixed_Name(ce, "31_FiraMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:31_HotelVistaMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#31_HotelVistaMadrid">https://purl.org/cityexplorer#31_HotelVistaMadrid</seealso>
    let _31_HotelVistaMadrid = Prefixed_Name(ce, "31_HotelVistaMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:31_PalauM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#31_PalauM%C3%A0laga">https://purl.org/cityexplorer#31_PalauM%C3%A0laga</seealso>
    let ``_31_PalauM%C3%A0laga`` =
        Prefixed_Name(ce, "31_PalauM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:31_RestaurantTradici%C3%B3Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#31_RestaurantTradici%C3%B3Madrid">https://purl.org/cityexplorer#31_RestaurantTradici%C3%B3Madrid</seealso>
    let ``_31_RestaurantTradici%C3%B3Madrid`` =
        Prefixed_Name(ce, "31_RestaurantTradici%C3%B3Madrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:31_UrbanSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#31_UrbanSantSebasti%C3%A0">https://purl.org/cityexplorer#31_UrbanSantSebasti%C3%A0</seealso>
    let ``_31_UrbanSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "31_UrbanSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:32_ConcertPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#32_ConcertPamplona">https://purl.org/cityexplorer#32_ConcertPamplona</seealso>
    let _32_ConcertPamplona = Prefixed_Name(ce, "32_ConcertPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:32_HotelPalaceToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#32_HotelPalaceToledo">https://purl.org/cityexplorer#32_HotelPalaceToledo</seealso>
    let _32_HotelPalaceToledo =
        Prefixed_Name(ce, "32_HotelPalaceToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:32_MetroMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#32_MetroMadrid">https://purl.org/cityexplorer#32_MetroMadrid</seealso>
    let _32_MetroMadrid = Prefixed_Name(ce, "32_MetroMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:32_MuseuSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#32_MuseuSaragossa">https://purl.org/cityexplorer#32_MuseuSaragossa</seealso>
    let _32_MuseuSaragossa = Prefixed_Name(ce, "32_MuseuSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:32_RestaurantGourmetMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#32_RestaurantGourmetMadrid">https://purl.org/cityexplorer#32_RestaurantGourmetMadrid</seealso>
    let _32_RestaurantGourmetMadrid =
        Prefixed_Name(ce, "32_RestaurantGourmetMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:33_FestivalBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#33_FestivalBarcelona">https://purl.org/cityexplorer#33_FestivalBarcelona</seealso>
    let _33_FestivalBarcelona =
        Prefixed_Name(ce, "33_FestivalBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:33_HotelSolBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#33_HotelSolBarcelona">https://purl.org/cityexplorer#33_HotelSolBarcelona</seealso>
    let _33_HotelSolBarcelona =
        Prefixed_Name(ce, "33_HotelSolBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:33_MetroMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#33_MetroMadrid">https://purl.org/cityexplorer#33_MetroMadrid</seealso>
    let _33_MetroMadrid = Prefixed_Name(ce, "33_MetroMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:33_MuseuBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#33_MuseuBarcelona">https://purl.org/cityexplorer#33_MuseuBarcelona</seealso>
    let _33_MuseuBarcelona = Prefixed_Name(ce, "33_MuseuBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:33_RestaurantTradici%C3%B3Toledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#33_RestaurantTradici%C3%B3Toledo">https://purl.org/cityexplorer#33_RestaurantTradici%C3%B3Toledo</seealso>
    let ``_33_RestaurantTradici%C3%B3Toledo`` =
        Prefixed_Name(ce, "33_RestaurantTradici%C3%B3Toledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:34_CarnavalSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#34_CarnavalSaragossa">https://purl.org/cityexplorer#34_CarnavalSaragossa</seealso>
    let _34_CarnavalSaragossa =
        Prefixed_Name(ce, "34_CarnavalSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:34_HotelDelMarBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#34_HotelDelMarBarcelona">https://purl.org/cityexplorer#34_HotelDelMarBarcelona</seealso>
    let _34_HotelDelMarBarcelona =
        Prefixed_Name(ce, "34_HotelDelMarBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:34_MuseuSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#34_MuseuSaragossa">https://purl.org/cityexplorer#34_MuseuSaragossa</seealso>
    let _34_MuseuSaragossa = Prefixed_Name(ce, "34_MuseuSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:34_RestaurantDeliciaSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#34_RestaurantDeliciaSevilla">https://purl.org/cityexplorer#34_RestaurantDeliciaSevilla</seealso>
    let _34_RestaurantDeliciaSevilla =
        Prefixed_Name(ce, "34_RestaurantDeliciaSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:34_UrbanSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#34_UrbanSantSebasti%C3%A0">https://purl.org/cityexplorer#34_UrbanSantSebasti%C3%A0</seealso>
    let ``_34_UrbanSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "34_UrbanSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:35_ConcertToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#35_ConcertToledo">https://purl.org/cityexplorer#35_ConcertToledo</seealso>
    let _35_ConcertToledo = Prefixed_Name(ce, "35_ConcertToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:35_HotelDelMarPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#35_HotelDelMarPamplona">https://purl.org/cityexplorer#35_HotelDelMarPamplona</seealso>
    let _35_HotelDelMarPamplona =
        Prefixed_Name(ce, "35_HotelDelMarPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:35_MetroBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#35_MetroBilbao">https://purl.org/cityexplorer#35_MetroBilbao</seealso>
    let _35_MetroBilbao = Prefixed_Name(ce, "35_MetroBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:35_PalauPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#35_PalauPamplona">https://purl.org/cityexplorer#35_PalauPamplona</seealso>
    let _35_PalauPamplona = Prefixed_Name(ce, "35_PalauPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:35_RestaurantDeliciaSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#35_RestaurantDeliciaSantSebasti%C3%A0">https://purl.org/cityexplorer#35_RestaurantDeliciaSantSebasti%C3%A0</seealso>
    let ``_35_RestaurantDeliciaSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "35_RestaurantDeliciaSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:36_CityBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#36_CityBarcelona">https://purl.org/cityexplorer#36_CityBarcelona</seealso>
    let _36_CityBarcelona = Prefixed_Name(ce, "36_CityBarcelona") |> PrefixedName
    /// <summary>
    ///   <para>ce:36_ConcertPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#36_ConcertPamplona">https://purl.org/cityexplorer#36_ConcertPamplona</seealso>
    let _36_ConcertPamplona = Prefixed_Name(ce, "36_ConcertPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:36_HotelPalaceSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#36_HotelPalaceSaragossa">https://purl.org/cityexplorer#36_HotelPalaceSaragossa</seealso>
    let _36_HotelPalaceSaragossa =
        Prefixed_Name(ce, "36_HotelPalaceSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:36_ParcPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#36_ParcPamplona">https://purl.org/cityexplorer#36_ParcPamplona</seealso>
    let _36_ParcPamplona = Prefixed_Name(ce, "36_ParcPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:36_RestaurantFusi%C3%B3Saragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#36_RestaurantFusi%C3%B3Saragossa">https://purl.org/cityexplorer#36_RestaurantFusi%C3%B3Saragossa</seealso>
    let ``_36_RestaurantFusi%C3%B3Saragossa`` =
        Prefixed_Name(ce, "36_RestaurantFusi%C3%B3Saragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:37_CastellMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#37_CastellMadrid">https://purl.org/cityexplorer#37_CastellMadrid</seealso>
    let _37_CastellMadrid = Prefixed_Name(ce, "37_CastellMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:37_FestivalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#37_FestivalMadrid">https://purl.org/cityexplorer#37_FestivalMadrid</seealso>
    let _37_FestivalMadrid = Prefixed_Name(ce, "37_FestivalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:37_HotelDelMarVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#37_HotelDelMarVal%C3%A8ncia">https://purl.org/cityexplorer#37_HotelDelMarVal%C3%A8ncia</seealso>
    let ``_37_HotelDelMarVal%C3%A8ncia`` =
        Prefixed_Name(ce, "37_HotelDelMarVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:37_RestaurantSaborVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#37_RestaurantSaborVal%C3%A8ncia">https://purl.org/cityexplorer#37_RestaurantSaborVal%C3%A8ncia</seealso>
    let ``_37_RestaurantSaborVal%C3%A8ncia`` =
        Prefixed_Name(ce, "37_RestaurantSaborVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:37_TransM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#37_TransM%C3%A0laga">https://purl.org/cityexplorer#37_TransM%C3%A0laga</seealso>
    let ``_37_TransM%C3%A0laga`` =
        Prefixed_Name(ce, "37_TransM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:38_CarnavalSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#38_CarnavalSevilla">https://purl.org/cityexplorer#38_CarnavalSevilla</seealso>
    let _38_CarnavalSevilla = Prefixed_Name(ce, "38_CarnavalSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:38_HotelDelMarM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#38_HotelDelMarM%C3%A0laga">https://purl.org/cityexplorer#38_HotelDelMarM%C3%A0laga</seealso>
    let ``_38_HotelDelMarM%C3%A0laga`` =
        Prefixed_Name(ce, "38_HotelDelMarM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:38_MoviMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#38_MoviMadrid">https://purl.org/cityexplorer#38_MoviMadrid</seealso>
    let _38_MoviMadrid = Prefixed_Name(ce, "38_MoviMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:38_PalauToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#38_PalauToledo">https://purl.org/cityexplorer#38_PalauToledo</seealso>
    let _38_PalauToledo = Prefixed_Name(ce, "38_PalauToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:38_RestaurantDeliciaPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#38_RestaurantDeliciaPamplona">https://purl.org/cityexplorer#38_RestaurantDeliciaPamplona</seealso>
    let _38_RestaurantDeliciaPamplona =
        Prefixed_Name(ce, "38_RestaurantDeliciaPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:39_CastellSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#39_CastellSantSebasti%C3%A0">https://purl.org/cityexplorer#39_CastellSantSebasti%C3%A0</seealso>
    let ``_39_CastellSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "39_CastellSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:39_FiraBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#39_FiraBarcelona">https://purl.org/cityexplorer#39_FiraBarcelona</seealso>
    let _39_FiraBarcelona = Prefixed_Name(ce, "39_FiraBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:39_HotelSolSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#39_HotelSolSaragossa">https://purl.org/cityexplorer#39_HotelSolSaragossa</seealso>
    let _39_HotelSolSaragossa =
        Prefixed_Name(ce, "39_HotelSolSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:39_MoviSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#39_MoviSevilla">https://purl.org/cityexplorer#39_MoviSevilla</seealso>
    let _39_MoviSevilla = Prefixed_Name(ce, "39_MoviSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:39_RestaurantFusi%C3%B3Toledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#39_RestaurantFusi%C3%B3Toledo">https://purl.org/cityexplorer#39_RestaurantFusi%C3%B3Toledo</seealso>
    let ``_39_RestaurantFusi%C3%B3Toledo`` =
        Prefixed_Name(ce, "39_RestaurantFusi%C3%B3Toledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:3_CastellSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#3_CastellSaragossa">https://purl.org/cityexplorer#3_CastellSaragossa</seealso>
    let _3_CastellSaragossa = Prefixed_Name(ce, "3_CastellSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:3_Congr%C3%A9sBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#3_Congr%C3%A9sBilbao">https://purl.org/cityexplorer#3_Congr%C3%A9sBilbao</seealso>
    let ``_3_Congr%C3%A9sBilbao`` =
        Prefixed_Name(ce, "3_Congr%C3%A9sBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:3_HotelRoyalM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#3_HotelRoyalM%C3%A0laga">https://purl.org/cityexplorer#3_HotelRoyalM%C3%A0laga</seealso>
    let ``_3_HotelRoyalM%C3%A0laga`` =
        Prefixed_Name(ce, "3_HotelRoyalM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:3_RestaurantFusi%C3%B3Val%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#3_RestaurantFusi%C3%B3Val%C3%A8ncia">https://purl.org/cityexplorer#3_RestaurantFusi%C3%B3Val%C3%A8ncia</seealso>
    let ``_3_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Prefixed_Name(ce, "3_RestaurantFusi%C3%B3Val%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:3_TransToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#3_TransToledo">https://purl.org/cityexplorer#3_TransToledo</seealso>
    let _3_TransToledo = Prefixed_Name(ce, "3_TransToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:40_FestivalVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#40_FestivalVal%C3%A8ncia">https://purl.org/cityexplorer#40_FestivalVal%C3%A8ncia</seealso>
    let ``_40_FestivalVal%C3%A8ncia`` =
        Prefixed_Name(ce, "40_FestivalVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:40_HotelDelMarSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#40_HotelDelMarSantSebasti%C3%A0">https://purl.org/cityexplorer#40_HotelDelMarSantSebasti%C3%A0</seealso>
    let ``_40_HotelDelMarSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "40_HotelDelMarSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:40_PalauCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#40_PalauCadis">https://purl.org/cityexplorer#40_PalauCadis</seealso>
    let _40_PalauCadis = Prefixed_Name(ce, "40_PalauCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:40_RestaurantGourmetVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#40_RestaurantGourmetVal%C3%A8ncia">https://purl.org/cityexplorer#40_RestaurantGourmetVal%C3%A8ncia</seealso>
    let ``_40_RestaurantGourmetVal%C3%A8ncia`` =
        Prefixed_Name(ce, "40_RestaurantGourmetVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:40_UrbanToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#40_UrbanToledo">https://purl.org/cityexplorer#40_UrbanToledo</seealso>
    let _40_UrbanToledo = Prefixed_Name(ce, "40_UrbanToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:41_CatedralToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#41_CatedralToledo">https://purl.org/cityexplorer#41_CatedralToledo</seealso>
    let _41_CatedralToledo = Prefixed_Name(ce, "41_CatedralToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:41_ConcertToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#41_ConcertToledo">https://purl.org/cityexplorer#41_ConcertToledo</seealso>
    let _41_ConcertToledo = Prefixed_Name(ce, "41_ConcertToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:41_HotelRoyalCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#41_HotelRoyalCadis">https://purl.org/cityexplorer#41_HotelRoyalCadis</seealso>
    let _41_HotelRoyalCadis = Prefixed_Name(ce, "41_HotelRoyalCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:41_MetroBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#41_MetroBarcelona">https://purl.org/cityexplorer#41_MetroBarcelona</seealso>
    let _41_MetroBarcelona = Prefixed_Name(ce, "41_MetroBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:41_RestaurantTradici%C3%B3Saragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#41_RestaurantTradici%C3%B3Saragossa">https://purl.org/cityexplorer#41_RestaurantTradici%C3%B3Saragossa</seealso>
    let ``_41_RestaurantTradici%C3%B3Saragossa`` =
        Prefixed_Name(ce, "41_RestaurantTradici%C3%B3Saragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:42_FestivalPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#42_FestivalPamplona">https://purl.org/cityexplorer#42_FestivalPamplona</seealso>
    let _42_FestivalPamplona = Prefixed_Name(ce, "42_FestivalPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:42_HotelPalaceMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#42_HotelPalaceMadrid">https://purl.org/cityexplorer#42_HotelPalaceMadrid</seealso>
    let _42_HotelPalaceMadrid =
        Prefixed_Name(ce, "42_HotelPalaceMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:42_MuseuMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#42_MuseuMadrid">https://purl.org/cityexplorer#42_MuseuMadrid</seealso>
    let _42_MuseuMadrid = Prefixed_Name(ce, "42_MuseuMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:42_RestaurantTradici%C3%B3Sevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#42_RestaurantTradici%C3%B3Sevilla">https://purl.org/cityexplorer#42_RestaurantTradici%C3%B3Sevilla</seealso>
    let ``_42_RestaurantTradici%C3%B3Sevilla`` =
        Prefixed_Name(ce, "42_RestaurantTradici%C3%B3Sevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:42_UrbanSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#42_UrbanSevilla">https://purl.org/cityexplorer#42_UrbanSevilla</seealso>
    let _42_UrbanSevilla = Prefixed_Name(ce, "42_UrbanSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:43_CityPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#43_CityPamplona">https://purl.org/cityexplorer#43_CityPamplona</seealso>
    let _43_CityPamplona = Prefixed_Name(ce, "43_CityPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:43_FestivalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#43_FestivalMadrid">https://purl.org/cityexplorer#43_FestivalMadrid</seealso>
    let _43_FestivalMadrid = Prefixed_Name(ce, "43_FestivalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:43_HotelRoyalPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#43_HotelRoyalPamplona">https://purl.org/cityexplorer#43_HotelRoyalPamplona</seealso>
    let _43_HotelRoyalPamplona =
        Prefixed_Name(ce, "43_HotelRoyalPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:43_ParcBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#43_ParcBarcelona">https://purl.org/cityexplorer#43_ParcBarcelona</seealso>
    let _43_ParcBarcelona = Prefixed_Name(ce, "43_ParcBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:43_RestaurantFusi%C3%B3Barcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#43_RestaurantFusi%C3%B3Barcelona">https://purl.org/cityexplorer#43_RestaurantFusi%C3%B3Barcelona</seealso>
    let ``_43_RestaurantFusi%C3%B3Barcelona`` =
        Prefixed_Name(ce, "43_RestaurantFusi%C3%B3Barcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:44_Congr%C3%A9sSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#44_Congr%C3%A9sSevilla">https://purl.org/cityexplorer#44_Congr%C3%A9sSevilla</seealso>
    let ``_44_Congr%C3%A9sSevilla`` =
        Prefixed_Name(ce, "44_Congr%C3%A9sSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:44_HotelVistaSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#44_HotelVistaSaragossa">https://purl.org/cityexplorer#44_HotelVistaSaragossa</seealso>
    let _44_HotelVistaSaragossa =
        Prefixed_Name(ce, "44_HotelVistaSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:44_MoviSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#44_MoviSantSebasti%C3%A0">https://purl.org/cityexplorer#44_MoviSantSebasti%C3%A0</seealso>
    let ``_44_MoviSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "44_MoviSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:44_MuseuSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#44_MuseuSevilla">https://purl.org/cityexplorer#44_MuseuSevilla</seealso>
    let _44_MuseuSevilla = Prefixed_Name(ce, "44_MuseuSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:44_RestaurantGourmetM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#44_RestaurantGourmetM%C3%A0laga">https://purl.org/cityexplorer#44_RestaurantGourmetM%C3%A0laga</seealso>
    let ``_44_RestaurantGourmetM%C3%A0laga`` =
        Prefixed_Name(ce, "44_RestaurantGourmetM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:45_CatedralBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#45_CatedralBarcelona">https://purl.org/cityexplorer#45_CatedralBarcelona</seealso>
    let _45_CatedralBarcelona =
        Prefixed_Name(ce, "45_CatedralBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:45_Congr%C3%A9sBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#45_Congr%C3%A9sBarcelona">https://purl.org/cityexplorer#45_Congr%C3%A9sBarcelona</seealso>
    let ``_45_Congr%C3%A9sBarcelona`` =
        Prefixed_Name(ce, "45_Congr%C3%A9sBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:45_HotelRoyalBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#45_HotelRoyalBarcelona">https://purl.org/cityexplorer#45_HotelRoyalBarcelona</seealso>
    let _45_HotelRoyalBarcelona =
        Prefixed_Name(ce, "45_HotelRoyalBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:45_MetroPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#45_MetroPamplona">https://purl.org/cityexplorer#45_MetroPamplona</seealso>
    let _45_MetroPamplona = Prefixed_Name(ce, "45_MetroPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:45_RestaurantFusi%C3%B3Saragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#45_RestaurantFusi%C3%B3Saragossa">https://purl.org/cityexplorer#45_RestaurantFusi%C3%B3Saragossa</seealso>
    let ``_45_RestaurantFusi%C3%B3Saragossa`` =
        Prefixed_Name(ce, "45_RestaurantFusi%C3%B3Saragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:46_Congr%C3%A9sVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#46_Congr%C3%A9sVal%C3%A8ncia">https://purl.org/cityexplorer#46_Congr%C3%A9sVal%C3%A8ncia</seealso>
    let ``_46_Congr%C3%A9sVal%C3%A8ncia`` =
        Prefixed_Name(ce, "46_Congr%C3%A9sVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:46_HotelVistaSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#46_HotelVistaSevilla">https://purl.org/cityexplorer#46_HotelVistaSevilla</seealso>
    let _46_HotelVistaSevilla =
        Prefixed_Name(ce, "46_HotelVistaSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:46_MetroPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#46_MetroPamplona">https://purl.org/cityexplorer#46_MetroPamplona</seealso>
    let _46_MetroPamplona = Prefixed_Name(ce, "46_MetroPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:46_MuseuToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#46_MuseuToledo">https://purl.org/cityexplorer#46_MuseuToledo</seealso>
    let _46_MuseuToledo = Prefixed_Name(ce, "46_MuseuToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:46_RestaurantSaborM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#46_RestaurantSaborM%C3%A0laga">https://purl.org/cityexplorer#46_RestaurantSaborM%C3%A0laga</seealso>
    let ``_46_RestaurantSaborM%C3%A0laga`` =
        Prefixed_Name(ce, "46_RestaurantSaborM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:47_FestivalVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#47_FestivalVal%C3%A8ncia">https://purl.org/cityexplorer#47_FestivalVal%C3%A8ncia</seealso>
    let ``_47_FestivalVal%C3%A8ncia`` =
        Prefixed_Name(ce, "47_FestivalVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:47_HotelDelMarSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#47_HotelDelMarSantSebasti%C3%A0">https://purl.org/cityexplorer#47_HotelDelMarSantSebasti%C3%A0</seealso>
    let ``_47_HotelDelMarSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "47_HotelDelMarSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:47_MoviSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#47_MoviSantSebasti%C3%A0">https://purl.org/cityexplorer#47_MoviSantSebasti%C3%A0</seealso>
    let ``_47_MoviSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "47_MoviSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:47_PalauToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#47_PalauToledo">https://purl.org/cityexplorer#47_PalauToledo</seealso>
    let _47_PalauToledo = Prefixed_Name(ce, "47_PalauToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:47_RestaurantTradici%C3%B3SantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#47_RestaurantTradici%C3%B3SantSebasti%C3%A0">https://purl.org/cityexplorer#47_RestaurantTradici%C3%B3SantSebasti%C3%A0</seealso>
    let ``_47_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        Prefixed_Name(ce, "47_RestaurantTradici%C3%B3SantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:48_FestivalBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#48_FestivalBilbao">https://purl.org/cityexplorer#48_FestivalBilbao</seealso>
    let _48_FestivalBilbao = Prefixed_Name(ce, "48_FestivalBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:48_HotelPalaceM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#48_HotelPalaceM%C3%A0laga">https://purl.org/cityexplorer#48_HotelPalaceM%C3%A0laga</seealso>
    let ``_48_HotelPalaceM%C3%A0laga`` =
        Prefixed_Name(ce, "48_HotelPalaceM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:48_MoviToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#48_MoviToledo">https://purl.org/cityexplorer#48_MoviToledo</seealso>
    let _48_MoviToledo = Prefixed_Name(ce, "48_MoviToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:48_ParcSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#48_ParcSantSebasti%C3%A0">https://purl.org/cityexplorer#48_ParcSantSebasti%C3%A0</seealso>
    let ``_48_ParcSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "48_ParcSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:48_RestaurantSaborSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#48_RestaurantSaborSantSebasti%C3%A0">https://purl.org/cityexplorer#48_RestaurantSaborSantSebasti%C3%A0</seealso>
    let ``_48_RestaurantSaborSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "48_RestaurantSaborSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:49_CastellSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#49_CastellSantSebasti%C3%A0">https://purl.org/cityexplorer#49_CastellSantSebasti%C3%A0</seealso>
    let ``_49_CastellSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "49_CastellSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:49_CityMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#49_CityMadrid">https://purl.org/cityexplorer#49_CityMadrid</seealso>
    let _49_CityMadrid = Prefixed_Name(ce, "49_CityMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:49_ConcertSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#49_ConcertSantSebasti%C3%A0">https://purl.org/cityexplorer#49_ConcertSantSebasti%C3%A0</seealso>
    let ``_49_ConcertSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "49_ConcertSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:49_HotelVistaPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#49_HotelVistaPamplona">https://purl.org/cityexplorer#49_HotelVistaPamplona</seealso>
    let _49_HotelVistaPamplona =
        Prefixed_Name(ce, "49_HotelVistaPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:49_RestaurantSaborM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#49_RestaurantSaborM%C3%A0laga">https://purl.org/cityexplorer#49_RestaurantSaborM%C3%A0laga</seealso>
    let ``_49_RestaurantSaborM%C3%A0laga`` =
        Prefixed_Name(ce, "49_RestaurantSaborM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:4_CarnavalSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#4_CarnavalSevilla">https://purl.org/cityexplorer#4_CarnavalSevilla</seealso>
    let _4_CarnavalSevilla = Prefixed_Name(ce, "4_CarnavalSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:4_CitySaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#4_CitySaragossa">https://purl.org/cityexplorer#4_CitySaragossa</seealso>
    let _4_CitySaragossa = Prefixed_Name(ce, "4_CitySaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:4_HotelRoyalBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#4_HotelRoyalBilbao">https://purl.org/cityexplorer#4_HotelRoyalBilbao</seealso>
    let _4_HotelRoyalBilbao = Prefixed_Name(ce, "4_HotelRoyalBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:4_MuseuMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#4_MuseuMadrid">https://purl.org/cityexplorer#4_MuseuMadrid</seealso>
    let _4_MuseuMadrid = Prefixed_Name(ce, "4_MuseuMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:4_RestaurantDeliciaM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#4_RestaurantDeliciaM%C3%A0laga">https://purl.org/cityexplorer#4_RestaurantDeliciaM%C3%A0laga</seealso>
    let ``_4_RestaurantDeliciaM%C3%A0laga`` =
        Prefixed_Name(ce, "4_RestaurantDeliciaM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:50_FestivalVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#50_FestivalVal%C3%A8ncia">https://purl.org/cityexplorer#50_FestivalVal%C3%A8ncia</seealso>
    let ``_50_FestivalVal%C3%A8ncia`` =
        Prefixed_Name(ce, "50_FestivalVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:50_HotelSolCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#50_HotelSolCadis">https://purl.org/cityexplorer#50_HotelSolCadis</seealso>
    let _50_HotelSolCadis = Prefixed_Name(ce, "50_HotelSolCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:50_ParcM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#50_ParcM%C3%A0laga">https://purl.org/cityexplorer#50_ParcM%C3%A0laga</seealso>
    let ``_50_ParcM%C3%A0laga`` =
        Prefixed_Name(ce, "50_ParcM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:50_RestaurantDeliciaBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#50_RestaurantDeliciaBarcelona">https://purl.org/cityexplorer#50_RestaurantDeliciaBarcelona</seealso>
    let _50_RestaurantDeliciaBarcelona =
        Prefixed_Name(ce, "50_RestaurantDeliciaBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:50_UrbanSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#50_UrbanSaragossa">https://purl.org/cityexplorer#50_UrbanSaragossa</seealso>
    let _50_UrbanSaragossa = Prefixed_Name(ce, "50_UrbanSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:51_CarnavalM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#51_CarnavalM%C3%A0laga">https://purl.org/cityexplorer#51_CarnavalM%C3%A0laga</seealso>
    let ``_51_CarnavalM%C3%A0laga`` =
        Prefixed_Name(ce, "51_CarnavalM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:51_HotelPalacePamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#51_HotelPalacePamplona">https://purl.org/cityexplorer#51_HotelPalacePamplona</seealso>
    let _51_HotelPalacePamplona =
        Prefixed_Name(ce, "51_HotelPalacePamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:51_PalauMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#51_PalauMadrid">https://purl.org/cityexplorer#51_PalauMadrid</seealso>
    let _51_PalauMadrid = Prefixed_Name(ce, "51_PalauMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:51_RestaurantDeliciaSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#51_RestaurantDeliciaSevilla">https://purl.org/cityexplorer#51_RestaurantDeliciaSevilla</seealso>
    let _51_RestaurantDeliciaSevilla =
        Prefixed_Name(ce, "51_RestaurantDeliciaSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:51_UrbanMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#51_UrbanMadrid">https://purl.org/cityexplorer#51_UrbanMadrid</seealso>
    let _51_UrbanMadrid = Prefixed_Name(ce, "51_UrbanMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:52_CatedralMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#52_CatedralMadrid">https://purl.org/cityexplorer#52_CatedralMadrid</seealso>
    let _52_CatedralMadrid = Prefixed_Name(ce, "52_CatedralMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:52_Congr%C3%A9sToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#52_Congr%C3%A9sToledo">https://purl.org/cityexplorer#52_Congr%C3%A9sToledo</seealso>
    let ``_52_Congr%C3%A9sToledo`` =
        Prefixed_Name(ce, "52_Congr%C3%A9sToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:52_HotelSolSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#52_HotelSolSevilla">https://purl.org/cityexplorer#52_HotelSolSevilla</seealso>
    let _52_HotelSolSevilla = Prefixed_Name(ce, "52_HotelSolSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:52_RestaurantDeliciaSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#52_RestaurantDeliciaSaragossa">https://purl.org/cityexplorer#52_RestaurantDeliciaSaragossa</seealso>
    let _52_RestaurantDeliciaSaragossa =
        Prefixed_Name(ce, "52_RestaurantDeliciaSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:52_TransMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#52_TransMadrid">https://purl.org/cityexplorer#52_TransMadrid</seealso>
    let _52_TransMadrid = Prefixed_Name(ce, "52_TransMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:53_CatedralVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#53_CatedralVal%C3%A8ncia">https://purl.org/cityexplorer#53_CatedralVal%C3%A8ncia</seealso>
    let ``_53_CatedralVal%C3%A8ncia`` =
        Prefixed_Name(ce, "53_CatedralVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:53_FiraBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#53_FiraBarcelona">https://purl.org/cityexplorer#53_FiraBarcelona</seealso>
    let _53_FiraBarcelona = Prefixed_Name(ce, "53_FiraBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:53_HotelDelMarM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#53_HotelDelMarM%C3%A0laga">https://purl.org/cityexplorer#53_HotelDelMarM%C3%A0laga</seealso>
    let ``_53_HotelDelMarM%C3%A0laga`` =
        Prefixed_Name(ce, "53_HotelDelMarM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:53_RestaurantDeliciaCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#53_RestaurantDeliciaCadis">https://purl.org/cityexplorer#53_RestaurantDeliciaCadis</seealso>
    let _53_RestaurantDeliciaCadis =
        Prefixed_Name(ce, "53_RestaurantDeliciaCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:53_UrbanToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#53_UrbanToledo">https://purl.org/cityexplorer#53_UrbanToledo</seealso>
    let _53_UrbanToledo = Prefixed_Name(ce, "53_UrbanToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:54_CatedralToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#54_CatedralToledo">https://purl.org/cityexplorer#54_CatedralToledo</seealso>
    let _54_CatedralToledo = Prefixed_Name(ce, "54_CatedralToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:54_FiraPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#54_FiraPamplona">https://purl.org/cityexplorer#54_FiraPamplona</seealso>
    let _54_FiraPamplona = Prefixed_Name(ce, "54_FiraPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:54_HotelPalaceToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#54_HotelPalaceToledo">https://purl.org/cityexplorer#54_HotelPalaceToledo</seealso>
    let _54_HotelPalaceToledo =
        Prefixed_Name(ce, "54_HotelPalaceToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:54_MetroM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#54_MetroM%C3%A0laga">https://purl.org/cityexplorer#54_MetroM%C3%A0laga</seealso>
    let ``_54_MetroM%C3%A0laga`` =
        Prefixed_Name(ce, "54_MetroM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:54_RestaurantSaborSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#54_RestaurantSaborSevilla">https://purl.org/cityexplorer#54_RestaurantSaborSevilla</seealso>
    let _54_RestaurantSaborSevilla =
        Prefixed_Name(ce, "54_RestaurantSaborSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:55_FiraSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#55_FiraSaragossa">https://purl.org/cityexplorer#55_FiraSaragossa</seealso>
    let _55_FiraSaragossa = Prefixed_Name(ce, "55_FiraSaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:55_HotelVistaCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#55_HotelVistaCadis">https://purl.org/cityexplorer#55_HotelVistaCadis</seealso>
    let _55_HotelVistaCadis = Prefixed_Name(ce, "55_HotelVistaCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:55_MoviToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#55_MoviToledo">https://purl.org/cityexplorer#55_MoviToledo</seealso>
    let _55_MoviToledo = Prefixed_Name(ce, "55_MoviToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:55_ParcSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#55_ParcSaragossa">https://purl.org/cityexplorer#55_ParcSaragossa</seealso>
    let _55_ParcSaragossa = Prefixed_Name(ce, "55_ParcSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:55_RestaurantFusi%C3%B3M%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#55_RestaurantFusi%C3%B3M%C3%A0laga">https://purl.org/cityexplorer#55_RestaurantFusi%C3%B3M%C3%A0laga</seealso>
    let ``_55_RestaurantFusi%C3%B3M%C3%A0laga`` =
        Prefixed_Name(ce, "55_RestaurantFusi%C3%B3M%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:56_FestivalBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#56_FestivalBarcelona">https://purl.org/cityexplorer#56_FestivalBarcelona</seealso>
    let _56_FestivalBarcelona =
        Prefixed_Name(ce, "56_FestivalBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:56_HotelDelMarCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#56_HotelDelMarCadis">https://purl.org/cityexplorer#56_HotelDelMarCadis</seealso>
    let _56_HotelDelMarCadis = Prefixed_Name(ce, "56_HotelDelMarCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:56_MuseuToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#56_MuseuToledo">https://purl.org/cityexplorer#56_MuseuToledo</seealso>
    let _56_MuseuToledo = Prefixed_Name(ce, "56_MuseuToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:56_RestaurantTradici%C3%B3Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#56_RestaurantTradici%C3%B3Madrid">https://purl.org/cityexplorer#56_RestaurantTradici%C3%B3Madrid</seealso>
    let ``_56_RestaurantTradici%C3%B3Madrid`` =
        Prefixed_Name(ce, "56_RestaurantTradici%C3%B3Madrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:56_TransVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#56_TransVal%C3%A8ncia">https://purl.org/cityexplorer#56_TransVal%C3%A8ncia</seealso>
    let ``_56_TransVal%C3%A8ncia`` =
        Prefixed_Name(ce, "56_TransVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:57_Congr%C3%A9sBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#57_Congr%C3%A9sBarcelona">https://purl.org/cityexplorer#57_Congr%C3%A9sBarcelona</seealso>
    let ``_57_Congr%C3%A9sBarcelona`` =
        Prefixed_Name(ce, "57_Congr%C3%A9sBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:57_HotelSolSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#57_HotelSolSevilla">https://purl.org/cityexplorer#57_HotelSolSevilla</seealso>
    let _57_HotelSolSevilla = Prefixed_Name(ce, "57_HotelSolSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:57_MoviVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#57_MoviVal%C3%A8ncia">https://purl.org/cityexplorer#57_MoviVal%C3%A8ncia</seealso>
    let ``_57_MoviVal%C3%A8ncia`` =
        Prefixed_Name(ce, "57_MoviVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:57_ParcCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#57_ParcCadis">https://purl.org/cityexplorer#57_ParcCadis</seealso>
    let _57_ParcCadis = Prefixed_Name(ce, "57_ParcCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:57_RestaurantGourmetM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#57_RestaurantGourmetM%C3%A0laga">https://purl.org/cityexplorer#57_RestaurantGourmetM%C3%A0laga</seealso>
    let ``_57_RestaurantGourmetM%C3%A0laga`` =
        Prefixed_Name(ce, "57_RestaurantGourmetM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:58_CarnavalSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#58_CarnavalSevilla">https://purl.org/cityexplorer#58_CarnavalSevilla</seealso>
    let _58_CarnavalSevilla = Prefixed_Name(ce, "58_CarnavalSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:58_CatedralM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#58_CatedralM%C3%A0laga">https://purl.org/cityexplorer#58_CatedralM%C3%A0laga</seealso>
    let ``_58_CatedralM%C3%A0laga`` =
        Prefixed_Name(ce, "58_CatedralM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:58_HotelDelMarSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#58_HotelDelMarSevilla">https://purl.org/cityexplorer#58_HotelDelMarSevilla</seealso>
    let _58_HotelDelMarSevilla =
        Prefixed_Name(ce, "58_HotelDelMarSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:58_MoviPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#58_MoviPamplona">https://purl.org/cityexplorer#58_MoviPamplona</seealso>
    let _58_MoviPamplona = Prefixed_Name(ce, "58_MoviPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:58_RestaurantDeliciaSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#58_RestaurantDeliciaSaragossa">https://purl.org/cityexplorer#58_RestaurantDeliciaSaragossa</seealso>
    let _58_RestaurantDeliciaSaragossa =
        Prefixed_Name(ce, "58_RestaurantDeliciaSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:59_CatedralBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#59_CatedralBilbao">https://purl.org/cityexplorer#59_CatedralBilbao</seealso>
    let _59_CatedralBilbao = Prefixed_Name(ce, "59_CatedralBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:59_FestivalM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#59_FestivalM%C3%A0laga">https://purl.org/cityexplorer#59_FestivalM%C3%A0laga</seealso>
    let ``_59_FestivalM%C3%A0laga`` =
        Prefixed_Name(ce, "59_FestivalM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:59_HotelVistaSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#59_HotelVistaSantSebasti%C3%A0">https://purl.org/cityexplorer#59_HotelVistaSantSebasti%C3%A0</seealso>
    let ``_59_HotelVistaSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "59_HotelVistaSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:59_MetroSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#59_MetroSantSebasti%C3%A0">https://purl.org/cityexplorer#59_MetroSantSebasti%C3%A0</seealso>
    let ``_59_MetroSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "59_MetroSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:59_RestaurantFusi%C3%B3Cadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#59_RestaurantFusi%C3%B3Cadis">https://purl.org/cityexplorer#59_RestaurantFusi%C3%B3Cadis</seealso>
    let ``_59_RestaurantFusi%C3%B3Cadis`` =
        Prefixed_Name(ce, "59_RestaurantFusi%C3%B3Cadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:5_CastellCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#5_CastellCadis">https://purl.org/cityexplorer#5_CastellCadis</seealso>
    let _5_CastellCadis = Prefixed_Name(ce, "5_CastellCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:5_FiraToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#5_FiraToledo">https://purl.org/cityexplorer#5_FiraToledo</seealso>
    let _5_FiraToledo = Prefixed_Name(ce, "5_FiraToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:5_HotelPalaceSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#5_HotelPalaceSaragossa">https://purl.org/cityexplorer#5_HotelPalaceSaragossa</seealso>
    let _5_HotelPalaceSaragossa =
        Prefixed_Name(ce, "5_HotelPalaceSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:5_MoviCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#5_MoviCadis">https://purl.org/cityexplorer#5_MoviCadis</seealso>
    let _5_MoviCadis = Prefixed_Name(ce, "5_MoviCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:5_RestaurantDeliciaPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#5_RestaurantDeliciaPamplona">https://purl.org/cityexplorer#5_RestaurantDeliciaPamplona</seealso>
    let _5_RestaurantDeliciaPamplona =
        Prefixed_Name(ce, "5_RestaurantDeliciaPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:60_FiraSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#60_FiraSevilla">https://purl.org/cityexplorer#60_FiraSevilla</seealso>
    let _60_FiraSevilla = Prefixed_Name(ce, "60_FiraSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:60_HotelDelMarBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#60_HotelDelMarBarcelona">https://purl.org/cityexplorer#60_HotelDelMarBarcelona</seealso>
    let _60_HotelDelMarBarcelona =
        Prefixed_Name(ce, "60_HotelDelMarBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:60_ParcCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#60_ParcCadis">https://purl.org/cityexplorer#60_ParcCadis</seealso>
    let _60_ParcCadis = Prefixed_Name(ce, "60_ParcCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:60_RestaurantDeliciaSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#60_RestaurantDeliciaSantSebasti%C3%A0">https://purl.org/cityexplorer#60_RestaurantDeliciaSantSebasti%C3%A0</seealso>
    let ``_60_RestaurantDeliciaSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "60_RestaurantDeliciaSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:60_UrbanMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#60_UrbanMadrid">https://purl.org/cityexplorer#60_UrbanMadrid</seealso>
    let _60_UrbanMadrid = Prefixed_Name(ce, "60_UrbanMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:61_CarnavalToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#61_CarnavalToledo">https://purl.org/cityexplorer#61_CarnavalToledo</seealso>
    let _61_CarnavalToledo = Prefixed_Name(ce, "61_CarnavalToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:61_HotelDelMarCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#61_HotelDelMarCadis">https://purl.org/cityexplorer#61_HotelDelMarCadis</seealso>
    let _61_HotelDelMarCadis = Prefixed_Name(ce, "61_HotelDelMarCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:61_MetroBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#61_MetroBilbao">https://purl.org/cityexplorer#61_MetroBilbao</seealso>
    let _61_MetroBilbao = Prefixed_Name(ce, "61_MetroBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:61_PalauSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#61_PalauSaragossa">https://purl.org/cityexplorer#61_PalauSaragossa</seealso>
    let _61_PalauSaragossa = Prefixed_Name(ce, "61_PalauSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:61_RestaurantGourmetMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#61_RestaurantGourmetMadrid">https://purl.org/cityexplorer#61_RestaurantGourmetMadrid</seealso>
    let _61_RestaurantGourmetMadrid =
        Prefixed_Name(ce, "61_RestaurantGourmetMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:62_CarnavalCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#62_CarnavalCadis">https://purl.org/cityexplorer#62_CarnavalCadis</seealso>
    let _62_CarnavalCadis = Prefixed_Name(ce, "62_CarnavalCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:62_CatedralVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#62_CatedralVal%C3%A8ncia">https://purl.org/cityexplorer#62_CatedralVal%C3%A8ncia</seealso>
    let ``_62_CatedralVal%C3%A8ncia`` =
        Prefixed_Name(ce, "62_CatedralVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:62_CityCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#62_CityCadis">https://purl.org/cityexplorer#62_CityCadis</seealso>
    let _62_CityCadis = Prefixed_Name(ce, "62_CityCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:62_HotelPalaceBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#62_HotelPalaceBarcelona">https://purl.org/cityexplorer#62_HotelPalaceBarcelona</seealso>
    let _62_HotelPalaceBarcelona =
        Prefixed_Name(ce, "62_HotelPalaceBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:62_RestaurantTradici%C3%B3SantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#62_RestaurantTradici%C3%B3SantSebasti%C3%A0">https://purl.org/cityexplorer#62_RestaurantTradici%C3%B3SantSebasti%C3%A0</seealso>
    let ``_62_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        Prefixed_Name(ce, "62_RestaurantTradici%C3%B3SantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:63_FiraM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#63_FiraM%C3%A0laga">https://purl.org/cityexplorer#63_FiraM%C3%A0laga</seealso>
    let ``_63_FiraM%C3%A0laga`` =
        Prefixed_Name(ce, "63_FiraM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:63_HotelSolBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#63_HotelSolBarcelona">https://purl.org/cityexplorer#63_HotelSolBarcelona</seealso>
    let _63_HotelSolBarcelona =
        Prefixed_Name(ce, "63_HotelSolBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:63_MetroM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#63_MetroM%C3%A0laga">https://purl.org/cityexplorer#63_MetroM%C3%A0laga</seealso>
    let ``_63_MetroM%C3%A0laga`` =
        Prefixed_Name(ce, "63_MetroM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:63_MuseuSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#63_MuseuSaragossa">https://purl.org/cityexplorer#63_MuseuSaragossa</seealso>
    let _63_MuseuSaragossa = Prefixed_Name(ce, "63_MuseuSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:63_RestaurantTradici%C3%B3Cadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#63_RestaurantTradici%C3%B3Cadis">https://purl.org/cityexplorer#63_RestaurantTradici%C3%B3Cadis</seealso>
    let ``_63_RestaurantTradici%C3%B3Cadis`` =
        Prefixed_Name(ce, "63_RestaurantTradici%C3%B3Cadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:64_CityBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#64_CityBarcelona">https://purl.org/cityexplorer#64_CityBarcelona</seealso>
    let _64_CityBarcelona = Prefixed_Name(ce, "64_CityBarcelona") |> PrefixedName
    /// <summary>
    ///   <para>ce:64_FiraMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#64_FiraMadrid">https://purl.org/cityexplorer#64_FiraMadrid</seealso>
    let _64_FiraMadrid = Prefixed_Name(ce, "64_FiraMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:64_HotelPalaceBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#64_HotelPalaceBarcelona">https://purl.org/cityexplorer#64_HotelPalaceBarcelona</seealso>
    let _64_HotelPalaceBarcelona =
        Prefixed_Name(ce, "64_HotelPalaceBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:64_MuseuSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#64_MuseuSantSebasti%C3%A0">https://purl.org/cityexplorer#64_MuseuSantSebasti%C3%A0</seealso>
    let ``_64_MuseuSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "64_MuseuSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:64_RestaurantTradici%C3%B3M%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#64_RestaurantTradici%C3%B3M%C3%A0laga">https://purl.org/cityexplorer#64_RestaurantTradici%C3%B3M%C3%A0laga</seealso>
    let ``_64_RestaurantTradici%C3%B3M%C3%A0laga`` =
        Prefixed_Name(ce, "64_RestaurantTradici%C3%B3M%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:65_CarnavalBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#65_CarnavalBarcelona">https://purl.org/cityexplorer#65_CarnavalBarcelona</seealso>
    let _65_CarnavalBarcelona =
        Prefixed_Name(ce, "65_CarnavalBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:65_HotelPalaceToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#65_HotelPalaceToledo">https://purl.org/cityexplorer#65_HotelPalaceToledo</seealso>
    let _65_HotelPalaceToledo =
        Prefixed_Name(ce, "65_HotelPalaceToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:65_ParcM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#65_ParcM%C3%A0laga">https://purl.org/cityexplorer#65_ParcM%C3%A0laga</seealso>
    let ``_65_ParcM%C3%A0laga`` =
        Prefixed_Name(ce, "65_ParcM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:65_RestaurantGourmetM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#65_RestaurantGourmetM%C3%A0laga">https://purl.org/cityexplorer#65_RestaurantGourmetM%C3%A0laga</seealso>
    let ``_65_RestaurantGourmetM%C3%A0laga`` =
        Prefixed_Name(ce, "65_RestaurantGourmetM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:65_UrbanPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#65_UrbanPamplona">https://purl.org/cityexplorer#65_UrbanPamplona</seealso>
    let _65_UrbanPamplona = Prefixed_Name(ce, "65_UrbanPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:66_FestivalVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#66_FestivalVal%C3%A8ncia">https://purl.org/cityexplorer#66_FestivalVal%C3%A8ncia</seealso>
    let ``_66_FestivalVal%C3%A8ncia`` =
        Prefixed_Name(ce, "66_FestivalVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:66_HotelSolMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#66_HotelSolMadrid">https://purl.org/cityexplorer#66_HotelSolMadrid</seealso>
    let _66_HotelSolMadrid = Prefixed_Name(ce, "66_HotelSolMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:66_MetroSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#66_MetroSevilla">https://purl.org/cityexplorer#66_MetroSevilla</seealso>
    let _66_MetroSevilla = Prefixed_Name(ce, "66_MetroSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:66_MuseuSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#66_MuseuSantSebasti%C3%A0">https://purl.org/cityexplorer#66_MuseuSantSebasti%C3%A0</seealso>
    let ``_66_MuseuSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "66_MuseuSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:66_RestaurantFusi%C3%B3Barcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#66_RestaurantFusi%C3%B3Barcelona">https://purl.org/cityexplorer#66_RestaurantFusi%C3%B3Barcelona</seealso>
    let ``_66_RestaurantFusi%C3%B3Barcelona`` =
        Prefixed_Name(ce, "66_RestaurantFusi%C3%B3Barcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:67_ConcertToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#67_ConcertToledo">https://purl.org/cityexplorer#67_ConcertToledo</seealso>
    let _67_ConcertToledo = Prefixed_Name(ce, "67_ConcertToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:67_HotelVistaMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#67_HotelVistaMadrid">https://purl.org/cityexplorer#67_HotelVistaMadrid</seealso>
    let _67_HotelVistaMadrid = Prefixed_Name(ce, "67_HotelVistaMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:67_MetroToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#67_MetroToledo">https://purl.org/cityexplorer#67_MetroToledo</seealso>
    let _67_MetroToledo = Prefixed_Name(ce, "67_MetroToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:67_ParcCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#67_ParcCadis">https://purl.org/cityexplorer#67_ParcCadis</seealso>
    let _67_ParcCadis = Prefixed_Name(ce, "67_ParcCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:67_RestaurantFusi%C3%B3Toledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#67_RestaurantFusi%C3%B3Toledo">https://purl.org/cityexplorer#67_RestaurantFusi%C3%B3Toledo</seealso>
    let ``_67_RestaurantFusi%C3%B3Toledo`` =
        Prefixed_Name(ce, "67_RestaurantFusi%C3%B3Toledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:68_CastellMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#68_CastellMadrid">https://purl.org/cityexplorer#68_CastellMadrid</seealso>
    let _68_CastellMadrid = Prefixed_Name(ce, "68_CastellMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:68_FiraPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#68_FiraPamplona">https://purl.org/cityexplorer#68_FiraPamplona</seealso>
    let _68_FiraPamplona = Prefixed_Name(ce, "68_FiraPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:68_HotelDelMarMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#68_HotelDelMarMadrid">https://purl.org/cityexplorer#68_HotelDelMarMadrid</seealso>
    let _68_HotelDelMarMadrid =
        Prefixed_Name(ce, "68_HotelDelMarMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:68_TransM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#68_TransM%C3%A0laga">https://purl.org/cityexplorer#68_TransM%C3%A0laga</seealso>
    let ``_68_TransM%C3%A0laga`` =
        Prefixed_Name(ce, "68_TransM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:68_estaurantGourmetBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#68_estaurantGourmetBarcelona">https://purl.org/cityexplorer#68_estaurantGourmetBarcelona</seealso>
    let _68_estaurantGourmetBarcelona =
        Prefixed_Name(ce, "68_estaurantGourmetBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:69_Congr%C3%A9sSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#69_Congr%C3%A9sSaragossa">https://purl.org/cityexplorer#69_Congr%C3%A9sSaragossa</seealso>
    let ``_69_Congr%C3%A9sSaragossa`` =
        Prefixed_Name(ce, "69_Congr%C3%A9sSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:69_HotelRoyalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#69_HotelRoyalMadrid">https://purl.org/cityexplorer#69_HotelRoyalMadrid</seealso>
    let _69_HotelRoyalMadrid = Prefixed_Name(ce, "69_HotelRoyalMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:69_MetroPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#69_MetroPamplona">https://purl.org/cityexplorer#69_MetroPamplona</seealso>
    let _69_MetroPamplona = Prefixed_Name(ce, "69_MetroPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:69_ParcCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#69_ParcCadis">https://purl.org/cityexplorer#69_ParcCadis</seealso>
    let _69_ParcCadis = Prefixed_Name(ce, "69_ParcCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:69_RestaurantGourmetBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#69_RestaurantGourmetBarcelona">https://purl.org/cityexplorer#69_RestaurantGourmetBarcelona</seealso>
    let _69_RestaurantGourmetBarcelona =
        Prefixed_Name(ce, "69_RestaurantGourmetBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:6_Congr%C3%A9sBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#6_Congr%C3%A9sBilbao">https://purl.org/cityexplorer#6_Congr%C3%A9sBilbao</seealso>
    let ``_6_Congr%C3%A9sBilbao`` =
        Prefixed_Name(ce, "6_Congr%C3%A9sBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:6_HotelRoyalSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#6_HotelRoyalSantSebasti%C3%A0">https://purl.org/cityexplorer#6_HotelRoyalSantSebasti%C3%A0</seealso>
    let ``_6_HotelRoyalSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "6_HotelRoyalSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:6_PalauBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#6_PalauBilbao">https://purl.org/cityexplorer#6_PalauBilbao</seealso>
    let _6_PalauBilbao = Prefixed_Name(ce, "6_PalauBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:6_RestaurantSaborSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#6_RestaurantSaborSevilla">https://purl.org/cityexplorer#6_RestaurantSaborSevilla</seealso>
    let _6_RestaurantSaborSevilla =
        Prefixed_Name(ce, "6_RestaurantSaborSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:6_TransPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#6_TransPamplona">https://purl.org/cityexplorer#6_TransPamplona</seealso>
    let _6_TransPamplona = Prefixed_Name(ce, "6_TransPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:70_CastellPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#70_CastellPamplona">https://purl.org/cityexplorer#70_CastellPamplona</seealso>
    let _70_CastellPamplona = Prefixed_Name(ce, "70_CastellPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:70_Congr%C3%A9sSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#70_Congr%C3%A9sSaragossa">https://purl.org/cityexplorer#70_Congr%C3%A9sSaragossa</seealso>
    let ``_70_Congr%C3%A9sSaragossa`` =
        Prefixed_Name(ce, "70_Congr%C3%A9sSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:70_HotelRoyalSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#70_HotelRoyalSaragossa">https://purl.org/cityexplorer#70_HotelRoyalSaragossa</seealso>
    let _70_HotelRoyalSaragossa =
        Prefixed_Name(ce, "70_HotelRoyalSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:70_RestaurantFusi%C3%B3Saragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#70_RestaurantFusi%C3%B3Saragossa">https://purl.org/cityexplorer#70_RestaurantFusi%C3%B3Saragossa</seealso>
    let ``_70_RestaurantFusi%C3%B3Saragossa`` =
        Prefixed_Name(ce, "70_RestaurantFusi%C3%B3Saragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:70_UrbanBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#70_UrbanBilbao">https://purl.org/cityexplorer#70_UrbanBilbao</seealso>
    let _70_UrbanBilbao = Prefixed_Name(ce, "70_UrbanBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:71_FiraM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#71_FiraM%C3%A0laga">https://purl.org/cityexplorer#71_FiraM%C3%A0laga</seealso>
    let ``_71_FiraM%C3%A0laga`` =
        Prefixed_Name(ce, "71_FiraM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:71_HotelDelMarM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#71_HotelDelMarM%C3%A0laga">https://purl.org/cityexplorer#71_HotelDelMarM%C3%A0laga</seealso>
    let ``_71_HotelDelMarM%C3%A0laga`` =
        Prefixed_Name(ce, "71_HotelDelMarM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:71_MoviBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#71_MoviBarcelona">https://purl.org/cityexplorer#71_MoviBarcelona</seealso>
    let _71_MoviBarcelona = Prefixed_Name(ce, "71_MoviBarcelona") |> PrefixedName
    /// <summary>
    ///   <para>ce:71_ParcMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#71_ParcMadrid">https://purl.org/cityexplorer#71_ParcMadrid</seealso>
    let _71_ParcMadrid = Prefixed_Name(ce, "71_ParcMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:71_RestaurantTradici%C3%B3Cadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#71_RestaurantTradici%C3%B3Cadis">https://purl.org/cityexplorer#71_RestaurantTradici%C3%B3Cadis</seealso>
    let ``_71_RestaurantTradici%C3%B3Cadis`` =
        Prefixed_Name(ce, "71_RestaurantTradici%C3%B3Cadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:72_FiraCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#72_FiraCadis">https://purl.org/cityexplorer#72_FiraCadis</seealso>
    let _72_FiraCadis = Prefixed_Name(ce, "72_FiraCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:72_HotelDelMarSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#72_HotelDelMarSaragossa">https://purl.org/cityexplorer#72_HotelDelMarSaragossa</seealso>
    let _72_HotelDelMarSaragossa =
        Prefixed_Name(ce, "72_HotelDelMarSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:72_ParcVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#72_ParcVal%C3%A8ncia">https://purl.org/cityexplorer#72_ParcVal%C3%A8ncia</seealso>
    let ``_72_ParcVal%C3%A8ncia`` =
        Prefixed_Name(ce, "72_ParcVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:72_RestaurantFusi%C3%B3Bilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#72_RestaurantFusi%C3%B3Bilbao">https://purl.org/cityexplorer#72_RestaurantFusi%C3%B3Bilbao</seealso>
    let ``_72_RestaurantFusi%C3%B3Bilbao`` =
        Prefixed_Name(ce, "72_RestaurantFusi%C3%B3Bilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:72_UrbanSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#72_UrbanSevilla">https://purl.org/cityexplorer#72_UrbanSevilla</seealso>
    let _72_UrbanSevilla = Prefixed_Name(ce, "72_UrbanSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:73_CarnavalSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#73_CarnavalSantSebasti%C3%A0">https://purl.org/cityexplorer#73_CarnavalSantSebasti%C3%A0</seealso>
    let ``_73_CarnavalSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "73_CarnavalSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:73_CatedralVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#73_CatedralVal%C3%A8ncia">https://purl.org/cityexplorer#73_CatedralVal%C3%A8ncia</seealso>
    let ``_73_CatedralVal%C3%A8ncia`` =
        Prefixed_Name(ce, "73_CatedralVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:73_HotelVistaSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#73_HotelVistaSantSebasti%C3%A0">https://purl.org/cityexplorer#73_HotelVistaSantSebasti%C3%A0</seealso>
    let ``_73_HotelVistaSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "73_HotelVistaSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:73_RestaurantGourmetVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#73_RestaurantGourmetVal%C3%A8ncia">https://purl.org/cityexplorer#73_RestaurantGourmetVal%C3%A8ncia</seealso>
    let ``_73_RestaurantGourmetVal%C3%A8ncia`` =
        Prefixed_Name(ce, "73_RestaurantGourmetVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:73_TransCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#73_TransCadis">https://purl.org/cityexplorer#73_TransCadis</seealso>
    let _73_TransCadis = Prefixed_Name(ce, "73_TransCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:74_CarnavalM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#74_CarnavalM%C3%A0laga">https://purl.org/cityexplorer#74_CarnavalM%C3%A0laga</seealso>
    let ``_74_CarnavalM%C3%A0laga`` =
        Prefixed_Name(ce, "74_CarnavalM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:74_HotelPalacePamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#74_HotelPalacePamplona">https://purl.org/cityexplorer#74_HotelPalacePamplona</seealso>
    let _74_HotelPalacePamplona =
        Prefixed_Name(ce, "74_HotelPalacePamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:74_PalauMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#74_PalauMadrid">https://purl.org/cityexplorer#74_PalauMadrid</seealso>
    let _74_PalauMadrid = Prefixed_Name(ce, "74_PalauMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:74_RestaurantGourmetPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#74_RestaurantGourmetPamplona">https://purl.org/cityexplorer#74_RestaurantGourmetPamplona</seealso>
    let _74_RestaurantGourmetPamplona =
        Prefixed_Name(ce, "74_RestaurantGourmetPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:74_UrbanSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#74_UrbanSevilla">https://purl.org/cityexplorer#74_UrbanSevilla</seealso>
    let _74_UrbanSevilla = Prefixed_Name(ce, "74_UrbanSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:75_CatedralToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#75_CatedralToledo">https://purl.org/cityexplorer#75_CatedralToledo</seealso>
    let _75_CatedralToledo = Prefixed_Name(ce, "75_CatedralToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:75_FiraSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#75_FiraSevilla">https://purl.org/cityexplorer#75_FiraSevilla</seealso>
    let _75_FiraSevilla = Prefixed_Name(ce, "75_FiraSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:75_HotelRoyalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#75_HotelRoyalMadrid">https://purl.org/cityexplorer#75_HotelRoyalMadrid</seealso>
    let _75_HotelRoyalMadrid = Prefixed_Name(ce, "75_HotelRoyalMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:75_MetroPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#75_MetroPamplona">https://purl.org/cityexplorer#75_MetroPamplona</seealso>
    let _75_MetroPamplona = Prefixed_Name(ce, "75_MetroPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:75_RestaurantSaborSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#75_RestaurantSaborSevilla">https://purl.org/cityexplorer#75_RestaurantSaborSevilla</seealso>
    let _75_RestaurantSaborSevilla =
        Prefixed_Name(ce, "75_RestaurantSaborSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:76_CityMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#76_CityMadrid">https://purl.org/cityexplorer#76_CityMadrid</seealso>
    let _76_CityMadrid = Prefixed_Name(ce, "76_CityMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:76_ConcertM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#76_ConcertM%C3%A0laga">https://purl.org/cityexplorer#76_ConcertM%C3%A0laga</seealso>
    let ``_76_ConcertM%C3%A0laga`` =
        Prefixed_Name(ce, "76_ConcertM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:76_HotelVistaBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#76_HotelVistaBarcelona">https://purl.org/cityexplorer#76_HotelVistaBarcelona</seealso>
    let _76_HotelVistaBarcelona =
        Prefixed_Name(ce, "76_HotelVistaBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:76_PalauBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#76_PalauBarcelona">https://purl.org/cityexplorer#76_PalauBarcelona</seealso>
    let _76_PalauBarcelona = Prefixed_Name(ce, "76_PalauBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:76_RestaurantFusi%C3%B3Val%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#76_RestaurantFusi%C3%B3Val%C3%A8ncia">https://purl.org/cityexplorer#76_RestaurantFusi%C3%B3Val%C3%A8ncia</seealso>
    let ``_76_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Prefixed_Name(ce, "76_RestaurantFusi%C3%B3Val%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:77_FestivalToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#77_FestivalToledo">https://purl.org/cityexplorer#77_FestivalToledo</seealso>
    let _77_FestivalToledo = Prefixed_Name(ce, "77_FestivalToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:77_HotelSolBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#77_HotelSolBarcelona">https://purl.org/cityexplorer#77_HotelSolBarcelona</seealso>
    let _77_HotelSolBarcelona =
        Prefixed_Name(ce, "77_HotelSolBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:77_MetroMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#77_MetroMadrid">https://purl.org/cityexplorer#77_MetroMadrid</seealso>
    let _77_MetroMadrid = Prefixed_Name(ce, "77_MetroMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:77_PalauPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#77_PalauPamplona">https://purl.org/cityexplorer#77_PalauPamplona</seealso>
    let _77_PalauPamplona = Prefixed_Name(ce, "77_PalauPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:77_RestaurantDeliciaSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#77_RestaurantDeliciaSevilla">https://purl.org/cityexplorer#77_RestaurantDeliciaSevilla</seealso>
    let _77_RestaurantDeliciaSevilla =
        Prefixed_Name(ce, "77_RestaurantDeliciaSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:78_CarnavalCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#78_CarnavalCadis">https://purl.org/cityexplorer#78_CarnavalCadis</seealso>
    let _78_CarnavalCadis = Prefixed_Name(ce, "78_CarnavalCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:78_CastellBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#78_CastellBilbao">https://purl.org/cityexplorer#78_CastellBilbao</seealso>
    let _78_CastellBilbao = Prefixed_Name(ce, "78_CastellBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:78_HotelRoyalBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#78_HotelRoyalBilbao">https://purl.org/cityexplorer#78_HotelRoyalBilbao</seealso>
    let _78_HotelRoyalBilbao = Prefixed_Name(ce, "78_HotelRoyalBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:78_MoviBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#78_MoviBilbao">https://purl.org/cityexplorer#78_MoviBilbao</seealso>
    let _78_MoviBilbao = Prefixed_Name(ce, "78_MoviBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:78_RestaurantFusi%C3%B3Val%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#78_RestaurantFusi%C3%B3Val%C3%A8ncia">https://purl.org/cityexplorer#78_RestaurantFusi%C3%B3Val%C3%A8ncia</seealso>
    let ``_78_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Prefixed_Name(ce, "78_RestaurantFusi%C3%B3Val%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:79_CatedralPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#79_CatedralPamplona">https://purl.org/cityexplorer#79_CatedralPamplona</seealso>
    let _79_CatedralPamplona = Prefixed_Name(ce, "79_CatedralPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:79_Congr%C3%A9sCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#79_Congr%C3%A9sCadis">https://purl.org/cityexplorer#79_Congr%C3%A9sCadis</seealso>
    let ``_79_Congr%C3%A9sCadis`` =
        Prefixed_Name(ce, "79_Congr%C3%A9sCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:79_HotelSolM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#79_HotelSolM%C3%A0laga">https://purl.org/cityexplorer#79_HotelSolM%C3%A0laga</seealso>
    let ``_79_HotelSolM%C3%A0laga`` =
        Prefixed_Name(ce, "79_HotelSolM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:79_RestaurantSaborM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#79_RestaurantSaborM%C3%A0laga">https://purl.org/cityexplorer#79_RestaurantSaborM%C3%A0laga</seealso>
    let ``_79_RestaurantSaborM%C3%A0laga`` =
        Prefixed_Name(ce, "79_RestaurantSaborM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:79_TransSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#79_TransSevilla">https://purl.org/cityexplorer#79_TransSevilla</seealso>
    let _79_TransSevilla = Prefixed_Name(ce, "79_TransSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:7_CatedralSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#7_CatedralSevilla">https://purl.org/cityexplorer#7_CatedralSevilla</seealso>
    let _7_CatedralSevilla = Prefixed_Name(ce, "7_CatedralSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:7_FestivalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#7_FestivalMadrid">https://purl.org/cityexplorer#7_FestivalMadrid</seealso>
    let _7_FestivalMadrid = Prefixed_Name(ce, "7_FestivalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:7_HotelRoyalVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#7_HotelRoyalVal%C3%A8ncia">https://purl.org/cityexplorer#7_HotelRoyalVal%C3%A8ncia</seealso>
    let ``_7_HotelRoyalVal%C3%A8ncia`` =
        Prefixed_Name(ce, "7_HotelRoyalVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:7_MetroCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#7_MetroCadis">https://purl.org/cityexplorer#7_MetroCadis</seealso>
    let _7_MetroCadis = Prefixed_Name(ce, "7_MetroCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:7_RestaurantGourmetSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#7_RestaurantGourmetSaragossa">https://purl.org/cityexplorer#7_RestaurantGourmetSaragossa</seealso>
    let _7_RestaurantGourmetSaragossa =
        Prefixed_Name(ce, "7_RestaurantGourmetSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:80_ConcertM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#80_ConcertM%C3%A0laga">https://purl.org/cityexplorer#80_ConcertM%C3%A0laga</seealso>
    let ``_80_ConcertM%C3%A0laga`` =
        Prefixed_Name(ce, "80_ConcertM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:80_HotelVistaSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#80_HotelVistaSantSebasti%C3%A0">https://purl.org/cityexplorer#80_HotelVistaSantSebasti%C3%A0</seealso>
    let ``_80_HotelVistaSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "80_HotelVistaSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:80_ParcMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#80_ParcMadrid">https://purl.org/cityexplorer#80_ParcMadrid</seealso>
    let _80_ParcMadrid = Prefixed_Name(ce, "80_ParcMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:80_RestaurantGourmetPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#80_RestaurantGourmetPamplona">https://purl.org/cityexplorer#80_RestaurantGourmetPamplona</seealso>
    let _80_RestaurantGourmetPamplona =
        Prefixed_Name(ce, "80_RestaurantGourmetPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:80_TransPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#80_TransPamplona">https://purl.org/cityexplorer#80_TransPamplona</seealso>
    let _80_TransPamplona = Prefixed_Name(ce, "80_TransPamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:81_CityBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#81_CityBilbao">https://purl.org/cityexplorer#81_CityBilbao</seealso>
    let _81_CityBilbao = Prefixed_Name(ce, "81_CityBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:81_Congr%C3%A9sToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#81_Congr%C3%A9sToledo">https://purl.org/cityexplorer#81_Congr%C3%A9sToledo</seealso>
    let ``_81_Congr%C3%A9sToledo`` =
        Prefixed_Name(ce, "81_Congr%C3%A9sToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:81_HotelVistaBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#81_HotelVistaBarcelona">https://purl.org/cityexplorer#81_HotelVistaBarcelona</seealso>
    let _81_HotelVistaBarcelona =
        Prefixed_Name(ce, "81_HotelVistaBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:81_ParcSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#81_ParcSevilla">https://purl.org/cityexplorer#81_ParcSevilla</seealso>
    let _81_ParcSevilla = Prefixed_Name(ce, "81_ParcSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:81_RestaurantGourmetSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#81_RestaurantGourmetSantSebasti%C3%A0">https://purl.org/cityexplorer#81_RestaurantGourmetSantSebasti%C3%A0</seealso>
    let ``_81_RestaurantGourmetSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "81_RestaurantGourmetSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:82_CityMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#82_CityMadrid">https://purl.org/cityexplorer#82_CityMadrid</seealso>
    let _82_CityMadrid = Prefixed_Name(ce, "82_CityMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:82_Congr%C3%A9sToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#82_Congr%C3%A9sToledo">https://purl.org/cityexplorer#82_Congr%C3%A9sToledo</seealso>
    let ``_82_Congr%C3%A9sToledo`` =
        Prefixed_Name(ce, "82_Congr%C3%A9sToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:82_HotelPalaceBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#82_HotelPalaceBilbao">https://purl.org/cityexplorer#82_HotelPalaceBilbao</seealso>
    let _82_HotelPalaceBilbao =
        Prefixed_Name(ce, "82_HotelPalaceBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:82_PalauVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#82_PalauVal%C3%A8ncia">https://purl.org/cityexplorer#82_PalauVal%C3%A8ncia</seealso>
    let ``_82_PalauVal%C3%A8ncia`` =
        Prefixed_Name(ce, "82_PalauVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:82_RestaurantGourmetMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#82_RestaurantGourmetMadrid">https://purl.org/cityexplorer#82_RestaurantGourmetMadrid</seealso>
    let _82_RestaurantGourmetMadrid =
        Prefixed_Name(ce, "82_RestaurantGourmetMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:83_CastellM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#83_CastellM%C3%A0laga">https://purl.org/cityexplorer#83_CastellM%C3%A0laga</seealso>
    let ``_83_CastellM%C3%A0laga`` =
        Prefixed_Name(ce, "83_CastellM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:83_CityToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#83_CityToledo">https://purl.org/cityexplorer#83_CityToledo</seealso>
    let _83_CityToledo = Prefixed_Name(ce, "83_CityToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:83_ConcertCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#83_ConcertCadis">https://purl.org/cityexplorer#83_ConcertCadis</seealso>
    let _83_ConcertCadis = Prefixed_Name(ce, "83_ConcertCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:83_HotelPalaceCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#83_HotelPalaceCadis">https://purl.org/cityexplorer#83_HotelPalaceCadis</seealso>
    let _83_HotelPalaceCadis = Prefixed_Name(ce, "83_HotelPalaceCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:83_RestaurantDeliciaBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#83_RestaurantDeliciaBilbao">https://purl.org/cityexplorer#83_RestaurantDeliciaBilbao</seealso>
    let _83_RestaurantDeliciaBilbao =
        Prefixed_Name(ce, "83_RestaurantDeliciaBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:84_CastellPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#84_CastellPamplona">https://purl.org/cityexplorer#84_CastellPamplona</seealso>
    let _84_CastellPamplona = Prefixed_Name(ce, "84_CastellPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:84_FestivalSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#84_FestivalSaragossa">https://purl.org/cityexplorer#84_FestivalSaragossa</seealso>
    let _84_FestivalSaragossa =
        Prefixed_Name(ce, "84_FestivalSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:84_HotelVistaMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#84_HotelVistaMadrid">https://purl.org/cityexplorer#84_HotelVistaMadrid</seealso>
    let _84_HotelVistaMadrid = Prefixed_Name(ce, "84_HotelVistaMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:84_RestaurantFusi%C3%B3Pamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#84_RestaurantFusi%C3%B3Pamplona">https://purl.org/cityexplorer#84_RestaurantFusi%C3%B3Pamplona</seealso>
    let ``_84_RestaurantFusi%C3%B3Pamplona`` =
        Prefixed_Name(ce, "84_RestaurantFusi%C3%B3Pamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:84_TransSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#84_TransSantSebasti%C3%A0">https://purl.org/cityexplorer#84_TransSantSebasti%C3%A0</seealso>
    let ``_84_TransSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "84_TransSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:85_CastellPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#85_CastellPamplona">https://purl.org/cityexplorer#85_CastellPamplona</seealso>
    let _85_CastellPamplona = Prefixed_Name(ce, "85_CastellPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:85_FestivalSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#85_FestivalSantSebasti%C3%A0">https://purl.org/cityexplorer#85_FestivalSantSebasti%C3%A0</seealso>
    let ``_85_FestivalSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "85_FestivalSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:85_HotelPalaceMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#85_HotelPalaceMadrid">https://purl.org/cityexplorer#85_HotelPalaceMadrid</seealso>
    let _85_HotelPalaceMadrid =
        Prefixed_Name(ce, "85_HotelPalaceMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:85_MoviSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#85_MoviSevilla">https://purl.org/cityexplorer#85_MoviSevilla</seealso>
    let _85_MoviSevilla = Prefixed_Name(ce, "85_MoviSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:85_RestaurantFusi%C3%B3Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#85_RestaurantFusi%C3%B3Madrid">https://purl.org/cityexplorer#85_RestaurantFusi%C3%B3Madrid</seealso>
    let ``_85_RestaurantFusi%C3%B3Madrid`` =
        Prefixed_Name(ce, "85_RestaurantFusi%C3%B3Madrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:86_CitySevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#86_CitySevilla">https://purl.org/cityexplorer#86_CitySevilla</seealso>
    let _86_CitySevilla = Prefixed_Name(ce, "86_CitySevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:86_FiraToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#86_FiraToledo">https://purl.org/cityexplorer#86_FiraToledo</seealso>
    let _86_FiraToledo = Prefixed_Name(ce, "86_FiraToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:86_HotelVistaToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#86_HotelVistaToledo">https://purl.org/cityexplorer#86_HotelVistaToledo</seealso>
    let _86_HotelVistaToledo = Prefixed_Name(ce, "86_HotelVistaToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:86_MuseuSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#86_MuseuSaragossa">https://purl.org/cityexplorer#86_MuseuSaragossa</seealso>
    let _86_MuseuSaragossa = Prefixed_Name(ce, "86_MuseuSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:86_RestaurantFusi%C3%B3Cadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#86_RestaurantFusi%C3%B3Cadis">https://purl.org/cityexplorer#86_RestaurantFusi%C3%B3Cadis</seealso>
    let ``_86_RestaurantFusi%C3%B3Cadis`` =
        Prefixed_Name(ce, "86_RestaurantFusi%C3%B3Cadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:87_FestivalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#87_FestivalMadrid">https://purl.org/cityexplorer#87_FestivalMadrid</seealso>
    let _87_FestivalMadrid = Prefixed_Name(ce, "87_FestivalMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:87_HotelSolSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#87_HotelSolSantSebasti%C3%A0">https://purl.org/cityexplorer#87_HotelSolSantSebasti%C3%A0</seealso>
    let ``_87_HotelSolSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "87_HotelSolSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:87_MoviBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#87_MoviBarcelona">https://purl.org/cityexplorer#87_MoviBarcelona</seealso>
    let _87_MoviBarcelona = Prefixed_Name(ce, "87_MoviBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:87_ParcSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#87_ParcSantSebasti%C3%A0">https://purl.org/cityexplorer#87_ParcSantSebasti%C3%A0</seealso>
    let ``_87_ParcSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "87_ParcSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:87_RestaurantSaborVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#87_RestaurantSaborVal%C3%A8ncia">https://purl.org/cityexplorer#87_RestaurantSaborVal%C3%A8ncia</seealso>
    let ``_87_RestaurantSaborVal%C3%A8ncia`` =
        Prefixed_Name(ce, "87_RestaurantSaborVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:88_FestivalToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#88_FestivalToledo">https://purl.org/cityexplorer#88_FestivalToledo</seealso>
    let _88_FestivalToledo = Prefixed_Name(ce, "88_FestivalToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:88_HotelVistaBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#88_HotelVistaBarcelona">https://purl.org/cityexplorer#88_HotelVistaBarcelona</seealso>
    let _88_HotelVistaBarcelona =
        Prefixed_Name(ce, "88_HotelVistaBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:88_PalauToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#88_PalauToledo">https://purl.org/cityexplorer#88_PalauToledo</seealso>
    let _88_PalauToledo = Prefixed_Name(ce, "88_PalauToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:88_RestaurantFusi%C3%B3Barcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#88_RestaurantFusi%C3%B3Barcelona">https://purl.org/cityexplorer#88_RestaurantFusi%C3%B3Barcelona</seealso>
    let ``_88_RestaurantFusi%C3%B3Barcelona`` =
        Prefixed_Name(ce, "88_RestaurantFusi%C3%B3Barcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:88_TransSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#88_TransSaragossa">https://purl.org/cityexplorer#88_TransSaragossa</seealso>
    let _88_TransSaragossa = Prefixed_Name(ce, "88_TransSaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:89_CastellSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#89_CastellSaragossa">https://purl.org/cityexplorer#89_CastellSaragossa</seealso>
    let _89_CastellSaragossa = Prefixed_Name(ce, "89_CastellSaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:89_FiraSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#89_FiraSaragossa">https://purl.org/cityexplorer#89_FiraSaragossa</seealso>
    let _89_FiraSaragossa = Prefixed_Name(ce, "89_FiraSaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:89_HotelVistaBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#89_HotelVistaBilbao">https://purl.org/cityexplorer#89_HotelVistaBilbao</seealso>
    let _89_HotelVistaBilbao = Prefixed_Name(ce, "89_HotelVistaBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:89_RestaurantGourmetM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#89_RestaurantGourmetM%C3%A0laga">https://purl.org/cityexplorer#89_RestaurantGourmetM%C3%A0laga</seealso>
    let ``_89_RestaurantGourmetM%C3%A0laga`` =
        Prefixed_Name(ce, "89_RestaurantGourmetM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:89_UrbanVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#89_UrbanVal%C3%A8ncia">https://purl.org/cityexplorer#89_UrbanVal%C3%A8ncia</seealso>
    let ``_89_UrbanVal%C3%A8ncia`` =
        Prefixed_Name(ce, "89_UrbanVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:8_CityMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#8_CityMadrid">https://purl.org/cityexplorer#8_CityMadrid</seealso>
    let _8_CityMadrid = Prefixed_Name(ce, "8_CityMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:8_FiraM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#8_FiraM%C3%A0laga">https://purl.org/cityexplorer#8_FiraM%C3%A0laga</seealso>
    let ``_8_FiraM%C3%A0laga`` = Prefixed_Name(ce, "8_FiraM%C3%A0laga") |> PrefixedName
    /// <summary>
    ///   <para>ce:8_HotelVistaCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#8_HotelVistaCadis">https://purl.org/cityexplorer#8_HotelVistaCadis</seealso>
    let _8_HotelVistaCadis = Prefixed_Name(ce, "8_HotelVistaCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:8_ParcSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#8_ParcSantSebasti%C3%A0">https://purl.org/cityexplorer#8_ParcSantSebasti%C3%A0</seealso>
    let ``_8_ParcSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "8_ParcSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:8_RestaurantGourmetToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#8_RestaurantGourmetToledo">https://purl.org/cityexplorer#8_RestaurantGourmetToledo</seealso>
    let _8_RestaurantGourmetToledo =
        Prefixed_Name(ce, "8_RestaurantGourmetToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:90_CitySaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#90_CitySaragossa">https://purl.org/cityexplorer#90_CitySaragossa</seealso>
    let _90_CitySaragossa = Prefixed_Name(ce, "90_CitySaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:90_Congr%C3%A9sVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#90_Congr%C3%A9sVal%C3%A8ncia">https://purl.org/cityexplorer#90_Congr%C3%A9sVal%C3%A8ncia</seealso>
    let ``_90_Congr%C3%A9sVal%C3%A8ncia`` =
        Prefixed_Name(ce, "90_Congr%C3%A9sVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:90_HotelDelMarSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#90_HotelDelMarSevilla">https://purl.org/cityexplorer#90_HotelDelMarSevilla</seealso>
    let _90_HotelDelMarSevilla =
        Prefixed_Name(ce, "90_HotelDelMarSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:90_MuseuPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#90_MuseuPamplona">https://purl.org/cityexplorer#90_MuseuPamplona</seealso>
    let _90_MuseuPamplona = Prefixed_Name(ce, "90_MuseuPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:90_RestaurantDeliciaSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#90_RestaurantDeliciaSaragossa">https://purl.org/cityexplorer#90_RestaurantDeliciaSaragossa</seealso>
    let _90_RestaurantDeliciaSaragossa =
        Prefixed_Name(ce, "90_RestaurantDeliciaSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:91_CarnavalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#91_CarnavalMadrid">https://purl.org/cityexplorer#91_CarnavalMadrid</seealso>
    let _91_CarnavalMadrid = Prefixed_Name(ce, "91_CarnavalMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:91_CatedralSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#91_CatedralSevilla">https://purl.org/cityexplorer#91_CatedralSevilla</seealso>
    let _91_CatedralSevilla = Prefixed_Name(ce, "91_CatedralSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:91_HotelDelMarVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#91_HotelDelMarVal%C3%A8ncia">https://purl.org/cityexplorer#91_HotelDelMarVal%C3%A8ncia</seealso>
    let ``_91_HotelDelMarVal%C3%A8ncia`` =
        Prefixed_Name(ce, "91_HotelDelMarVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:91_RestaurantGourmetSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#91_RestaurantGourmetSaragossa">https://purl.org/cityexplorer#91_RestaurantGourmetSaragossa</seealso>
    let _91_RestaurantGourmetSaragossa =
        Prefixed_Name(ce, "91_RestaurantGourmetSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:91_UrbanBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#91_UrbanBilbao">https://purl.org/cityexplorer#91_UrbanBilbao</seealso>
    let _91_UrbanBilbao = Prefixed_Name(ce, "91_UrbanBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:92_FestivalCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#92_FestivalCadis">https://purl.org/cityexplorer#92_FestivalCadis</seealso>
    let _92_FestivalCadis = Prefixed_Name(ce, "92_FestivalCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:92_HotelRoyalM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#92_HotelRoyalM%C3%A0laga">https://purl.org/cityexplorer#92_HotelRoyalM%C3%A0laga</seealso>
    let ``_92_HotelRoyalM%C3%A0laga`` =
        Prefixed_Name(ce, "92_HotelRoyalM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:92_MetroMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#92_MetroMadrid">https://purl.org/cityexplorer#92_MetroMadrid</seealso>
    let _92_MetroMadrid = Prefixed_Name(ce, "92_MetroMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:92_MuseuCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#92_MuseuCadis">https://purl.org/cityexplorer#92_MuseuCadis</seealso>
    let _92_MuseuCadis = Prefixed_Name(ce, "92_MuseuCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:92_RestaurantGourmetPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#92_RestaurantGourmetPamplona">https://purl.org/cityexplorer#92_RestaurantGourmetPamplona</seealso>
    let _92_RestaurantGourmetPamplona =
        Prefixed_Name(ce, "92_RestaurantGourmetPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:93_ConcertCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#93_ConcertCadis">https://purl.org/cityexplorer#93_ConcertCadis</seealso>
    let _93_ConcertCadis = Prefixed_Name(ce, "93_ConcertCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:93_HotelDelMarMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#93_HotelDelMarMadrid">https://purl.org/cityexplorer#93_HotelDelMarMadrid</seealso>
    let _93_HotelDelMarMadrid =
        Prefixed_Name(ce, "93_HotelDelMarMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:93_ParcToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#93_ParcToledo">https://purl.org/cityexplorer#93_ParcToledo</seealso>
    let _93_ParcToledo = Prefixed_Name(ce, "93_ParcToledo") |> PrefixedName

    /// <summary>
    ///   <para>ce:93_RestaurantSaborSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#93_RestaurantSaborSaragossa">https://purl.org/cityexplorer#93_RestaurantSaborSaragossa</seealso>
    let _93_RestaurantSaborSaragossa =
        Prefixed_Name(ce, "93_RestaurantSaborSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:93_TransVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#93_TransVal%C3%A8ncia">https://purl.org/cityexplorer#93_TransVal%C3%A8ncia</seealso>
    let ``_93_TransVal%C3%A8ncia`` =
        Prefixed_Name(ce, "93_TransVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:94_CatedralToledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#94_CatedralToledo">https://purl.org/cityexplorer#94_CatedralToledo</seealso>
    let _94_CatedralToledo = Prefixed_Name(ce, "94_CatedralToledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:94_FestivalMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#94_FestivalMadrid">https://purl.org/cityexplorer#94_FestivalMadrid</seealso>
    let _94_FestivalMadrid = Prefixed_Name(ce, "94_FestivalMadrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:94_HotelVistaBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#94_HotelVistaBilbao">https://purl.org/cityexplorer#94_HotelVistaBilbao</seealso>
    let _94_HotelVistaBilbao = Prefixed_Name(ce, "94_HotelVistaBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:94_MoviM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#94_MoviM%C3%A0laga">https://purl.org/cityexplorer#94_MoviM%C3%A0laga</seealso>
    let ``_94_MoviM%C3%A0laga`` =
        Prefixed_Name(ce, "94_MoviM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:94_RestaurantTradici%C3%B3Sevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#94_RestaurantTradici%C3%B3Sevilla">https://purl.org/cityexplorer#94_RestaurantTradici%C3%B3Sevilla</seealso>
    let ``_94_RestaurantTradici%C3%B3Sevilla`` =
        Prefixed_Name(ce, "94_RestaurantTradici%C3%B3Sevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:95_CatedralVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#95_CatedralVal%C3%A8ncia">https://purl.org/cityexplorer#95_CatedralVal%C3%A8ncia</seealso>
    let ``_95_CatedralVal%C3%A8ncia`` =
        Prefixed_Name(ce, "95_CatedralVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:95_ConcertSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#95_ConcertSaragossa">https://purl.org/cityexplorer#95_ConcertSaragossa</seealso>
    let _95_ConcertSaragossa = Prefixed_Name(ce, "95_ConcertSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:95_HotelPalacePamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#95_HotelPalacePamplona">https://purl.org/cityexplorer#95_HotelPalacePamplona</seealso>
    let _95_HotelPalacePamplona =
        Prefixed_Name(ce, "95_HotelPalacePamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:95_RestaurantTradici%C3%B3Sevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#95_RestaurantTradici%C3%B3Sevilla">https://purl.org/cityexplorer#95_RestaurantTradici%C3%B3Sevilla</seealso>
    let ``_95_RestaurantTradici%C3%B3Sevilla`` =
        Prefixed_Name(ce, "95_RestaurantTradici%C3%B3Sevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:95_TransMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#95_TransMadrid">https://purl.org/cityexplorer#95_TransMadrid</seealso>
    let _95_TransMadrid = Prefixed_Name(ce, "95_TransMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:96_Congr%C3%A9sBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#96_Congr%C3%A9sBarcelona">https://purl.org/cityexplorer#96_Congr%C3%A9sBarcelona</seealso>
    let ``_96_Congr%C3%A9sBarcelona`` =
        Prefixed_Name(ce, "96_Congr%C3%A9sBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:96_HotelVistaPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#96_HotelVistaPamplona">https://purl.org/cityexplorer#96_HotelVistaPamplona</seealso>
    let _96_HotelVistaPamplona =
        Prefixed_Name(ce, "96_HotelVistaPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:96_MuseuMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#96_MuseuMadrid">https://purl.org/cityexplorer#96_MuseuMadrid</seealso>
    let _96_MuseuMadrid = Prefixed_Name(ce, "96_MuseuMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:96_RestaurantTradici%C3%B3Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#96_RestaurantTradici%C3%B3Madrid">https://purl.org/cityexplorer#96_RestaurantTradici%C3%B3Madrid</seealso>
    let ``_96_RestaurantTradici%C3%B3Madrid`` =
        Prefixed_Name(ce, "96_RestaurantTradici%C3%B3Madrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:96_TransSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#96_TransSaragossa">https://purl.org/cityexplorer#96_TransSaragossa</seealso>
    let _96_TransSaragossa = Prefixed_Name(ce, "96_TransSaragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:97_CarnavalBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#97_CarnavalBilbao">https://purl.org/cityexplorer#97_CarnavalBilbao</seealso>
    let _97_CarnavalBilbao = Prefixed_Name(ce, "97_CarnavalBilbao") |> PrefixedName

    /// <summary>
    ///   <para>ce:97_CatedralSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Attraction</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#97_CatedralSaragossa">https://purl.org/cityexplorer#97_CatedralSaragossa</seealso>
    let _97_CatedralSaragossa =
        Prefixed_Name(ce, "97_CatedralSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:97_HotelPalaceM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#97_HotelPalaceM%C3%A0laga">https://purl.org/cityexplorer#97_HotelPalaceM%C3%A0laga</seealso>
    let ``_97_HotelPalaceM%C3%A0laga`` =
        Prefixed_Name(ce, "97_HotelPalaceM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:97_RestaurantFusi%C3%B3Saragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#97_RestaurantFusi%C3%B3Saragossa">https://purl.org/cityexplorer#97_RestaurantFusi%C3%B3Saragossa</seealso>
    let ``_97_RestaurantFusi%C3%B3Saragossa`` =
        Prefixed_Name(ce, "97_RestaurantFusi%C3%B3Saragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:97_TransCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#97_TransCadis">https://purl.org/cityexplorer#97_TransCadis</seealso>
    let _97_TransCadis = Prefixed_Name(ce, "97_TransCadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:98_CityPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Transport</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#98_CityPamplona">https://purl.org/cityexplorer#98_CityPamplona</seealso>
    let _98_CityPamplona = Prefixed_Name(ce, "98_CityPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:98_Congr%C3%A9sSaragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#98_Congr%C3%A9sSaragossa">https://purl.org/cityexplorer#98_Congr%C3%A9sSaragossa</seealso>
    let ``_98_Congr%C3%A9sSaragossa`` =
        Prefixed_Name(ce, "98_Congr%C3%A9sSaragossa") |> PrefixedName

    /// <summary>
    ///   <para>ce:98_HotelPalaceMadrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#98_HotelPalaceMadrid">https://purl.org/cityexplorer#98_HotelPalaceMadrid</seealso>
    let _98_HotelPalaceMadrid =
        Prefixed_Name(ce, "98_HotelPalaceMadrid") |> PrefixedName

    /// <summary>
    ///   <para>ce:98_ParcCadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#98_ParcCadis">https://purl.org/cityexplorer#98_ParcCadis</seealso>
    let _98_ParcCadis = Prefixed_Name(ce, "98_ParcCadis") |> PrefixedName

    /// <summary>
    ///   <para>ce:98_RestaurantDeliciaSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Restaurant</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#98_RestaurantDeliciaSevilla">https://purl.org/cityexplorer#98_RestaurantDeliciaSevilla</seealso>
    let _98_RestaurantDeliciaSevilla =
        Prefixed_Name(ce, "98_RestaurantDeliciaSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:99_CatedralBilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#99_CatedralBilbao">https://purl.org/cityexplorer#99_CatedralBilbao</seealso>
    let _99_CatedralBilbao = Prefixed_Name(ce, "99_CatedralBilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:99_FiraSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#99_FiraSevilla">https://purl.org/cityexplorer#99_FiraSevilla</seealso>
    let _99_FiraSevilla = Prefixed_Name(ce, "99_FiraSevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:99_HotelSolSevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Hotel</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#99_HotelSolSevilla">https://purl.org/cityexplorer#99_HotelSolSevilla</seealso>
    let _99_HotelSolSevilla = Prefixed_Name(ce, "99_HotelSolSevilla") |> PrefixedName

    /// <summary>
    ///   <para>ce:99_MetroSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#99_MetroSantSebasti%C3%A0">https://purl.org/cityexplorer#99_MetroSantSebasti%C3%A0</seealso>
    let ``_99_MetroSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "99_MetroSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:99_RestaurantGourmetVal%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#99_RestaurantGourmetVal%C3%A8ncia">https://purl.org/cityexplorer#99_RestaurantGourmetVal%C3%A8ncia</seealso>
    let ``_99_RestaurantGourmetVal%C3%A8ncia`` =
        Prefixed_Name(ce, "99_RestaurantGourmetVal%C3%A8ncia") |> PrefixedName

    /// <summary>
    ///   <para>ce:9_CatedralPamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Attraction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#9_CatedralPamplona">https://purl.org/cityexplorer#9_CatedralPamplona</seealso>
    let _9_CatedralPamplona = Prefixed_Name(ce, "9_CatedralPamplona") |> PrefixedName

    /// <summary>
    ///   <para>ce:9_Congr%C3%A9sSantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:Event</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#9_Congr%C3%A9sSantSebasti%C3%A0">https://purl.org/cityexplorer#9_Congr%C3%A9sSantSebasti%C3%A0</seealso>
    let ``_9_Congr%C3%A9sSantSebasti%C3%A0`` =
        Prefixed_Name(ce, "9_Congr%C3%A9sSantSebasti%C3%A0") |> PrefixedName

    /// <summary>
    ///   <para>ce:9_HotelRoyalBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Hotel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#9_HotelRoyalBarcelona">https://purl.org/cityexplorer#9_HotelRoyalBarcelona</seealso>
    let _9_HotelRoyalBarcelona =
        Prefixed_Name(ce, "9_HotelRoyalBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:9_MetroBarcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Transport</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#9_MetroBarcelona">https://purl.org/cityexplorer#9_MetroBarcelona</seealso>
    let _9_MetroBarcelona = Prefixed_Name(ce, "9_MetroBarcelona") |> PrefixedName

    /// <summary>
    ///   <para>ce:9_RestaurantDeliciaM%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:Restaurant</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#9_RestaurantDeliciaM%C3%A0laga">https://purl.org/cityexplorer#9_RestaurantDeliciaM%C3%A0laga</seealso>
    let ``_9_RestaurantDeliciaM%C3%A0laga`` =
        Prefixed_Name(ce, "9_RestaurantDeliciaM%C3%A0laga") |> PrefixedName

    /// <summary>
    ///   <para>ce:Andalusian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Andalusian">https://purl.org/cityexplorer#Andalusian</seealso>
    let Andalusian = Prefixed_Name(ce, "Andalusian") |> PrefixedName
    /// <summary>
    ///   <para>ce:AndalusianRestaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to restaurants serving food from Andalusia"</para>
    /// labels<para>"AndalusianRestaurant"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#AndalusianRestaurant">https://purl.org/cityexplorer#AndalusianRestaurant</seealso>
    let AndalusianRestaurant = Prefixed_Name(ce, "AndalusianRestaurant") |> PrefixedName
    /// <summary>
    ///   <para>ce:Attraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an attraction type, which can be cultural, park, etc."</para>
    /// labels<para>"Attraction"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Attraction">https://purl.org/cityexplorer#Attraction</seealso>
    let Attraction = Prefixed_Name(ce, "Attraction") |> PrefixedName
    /// <summary>
    ///   <para>ce:AttractionCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Includes different attraction categories"</para>
    /// labels<para>"AttractionCategory"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#AttractionCategory">https://purl.org/cityexplorer#AttractionCategory</seealso>
    let AttractionCategory = Prefixed_Name(ce, "AttractionCategory") |> PrefixedName
    /// <summary>
    ///   <para>ce:AttractionTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the category of attractions"</para>
    /// labels<para>"AttractionType"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#AttractionTypes">https://purl.org/cityexplorer#AttractionTypes</seealso>
    let AttractionTypes = Prefixed_Name(ce, "AttractionTypes") |> PrefixedName
    /// <summary>
    ///   <para>ce:Barcelona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:City</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Barcelona">https://purl.org/cityexplorer#Barcelona</seealso>
    let Barcelona = Prefixed_Name(ce, "Barcelona") |> PrefixedName
    /// <summary>
    ///   <para>ce:Beach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Beach">https://purl.org/cityexplorer#Beach</seealso>
    let Beach = Prefixed_Name(ce, "Beach") |> PrefixedName
    /// <summary>
    ///   <para>ce:BeachAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to attractions involving a beach"</para>
    /// labels<para>"BeachAttraction"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#BeachAttraction">https://purl.org/cityexplorer#BeachAttraction</seealso>
    let BeachAttraction = Prefixed_Name(ce, "BeachAttraction") |> PrefixedName
    /// <summary>
    ///   <para>ce:BeachCities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to cities located at the beach"</para>
    /// labels<para>"BeachCities"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#BeachCities">https://purl.org/cityexplorer#BeachCities</seealso>
    let BeachCities = Prefixed_Name(ce, "BeachCities") |> PrefixedName
    /// <summary>
    ///   <para>ce:BeachHotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to hotels at the beach"</para>
    /// labels<para>"BeachHotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#BeachHotel">https://purl.org/cityexplorer#BeachHotel</seealso>
    let BeachHotel = Prefixed_Name(ce, "BeachHotel") |> PrefixedName
    /// <summary>
    ///   <para>ce:Bilbao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:City</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Bilbao">https://purl.org/cityexplorer#Bilbao</seealso>
    let Bilbao = Prefixed_Name(ce, "Bilbao") |> PrefixedName
    /// <summary>
    ///   <para>ce:Bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Bus">https://purl.org/cityexplorer#Bus</seealso>
    let Bus = Prefixed_Name(ce, "Bus") |> PrefixedName
    /// <summary>
    ///   <para>ce:BusTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to bus transport"</para>
    /// labels<para>"BusTransport"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#BusTransport">https://purl.org/cityexplorer#BusTransport</seealso>
    let BusTransport = Prefixed_Name(ce, "BusTransport") |> PrefixedName
    /// <summary>
    ///   <para>ce:Business</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Business">https://purl.org/cityexplorer#Business</seealso>
    let Business = Prefixed_Name(ce, "Business") |> PrefixedName
    /// <summary>
    ///   <para>ce:BusinessHotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to hotels considered for business"</para>
    /// labels<para>"BusinessHotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#BusinessHotel">https://purl.org/cityexplorer#BusinessHotel</seealso>
    let BusinessHotel = Prefixed_Name(ce, "BusinessHotel") |> PrefixedName
    /// <summary>
    ///   <para>ce:Cadis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:City</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Cadis">https://purl.org/cityexplorer#Cadis</seealso>
    let Cadis = Prefixed_Name(ce, "Cadis") |> PrefixedName
    /// <summary>
    ///   <para>ce:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global category, including different categories"</para>
    /// labels<para>"Category"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Category">https://purl.org/cityexplorer#Category</seealso>
    let Category = Prefixed_Name(ce, "Category") |> PrefixedName
    /// <summary>
    ///   <para>ce:CategoryTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to different types of categories"</para>
    /// labels<para>"CategoryTypes"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#CategoryTypes">https://purl.org/cityexplorer#CategoryTypes</seealso>
    let CategoryTypes = Prefixed_Name(ce, "CategoryTypes") |> PrefixedName
    /// <summary>
    ///   <para>ce:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to a city"</para>
    /// labels<para>"City"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#City">https://purl.org/cityexplorer#City</seealso>
    let City = Prefixed_Name(ce, "City") |> PrefixedName
    /// <summary>
    ///   <para>ce:Cultural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Cultural">https://purl.org/cityexplorer#Cultural</seealso>
    let Cultural = Prefixed_Name(ce, "Cultural") |> PrefixedName
    /// <summary>
    ///   <para>ce:CulturalAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to attractions involving any kind of cultural activity"</para>
    /// labels<para>"CulturalAttraction"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#CulturalAttraction">https://purl.org/cityexplorer#CulturalAttraction</seealso>
    let CulturalAttraction = Prefixed_Name(ce, "CulturalAttraction") |> PrefixedName
    /// <summary>
    ///   <para>ce:CulturalCities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to cities with cultural interest"</para>
    /// labels<para>"CulturalCities"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#CulturalCities">https://purl.org/cityexplorer#CulturalCities</seealso>
    let CulturalCities = Prefixed_Name(ce, "CulturalCities") |> PrefixedName
    /// <summary>
    ///   <para>ce:CulturalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an event involving any kind of cultural activity"</para>
    /// labels<para>"CulturalEvent"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#CulturalEvent">https://purl.org/cityexplorer#CulturalEvent</seealso>
    let CulturalEvent = Prefixed_Name(ce, "CulturalEvent") |> PrefixedName
    /// <summary>
    ///   <para>ce:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an event"</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Event">https://purl.org/cityexplorer#Event</seealso>
    let Event = Prefixed_Name(ce, "Event") |> PrefixedName
    /// <summary>
    ///   <para>ce:EventCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Includes different event categories"</para>
    /// labels<para>"EventCategory"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#EventCategory">https://purl.org/cityexplorer#EventCategory</seealso>
    let EventCategory = Prefixed_Name(ce, "EventCategory") |> PrefixedName
    /// <summary>
    ///   <para>ce:EventTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the category of events"</para>
    /// labels<para>"EventTypes"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#EventTypes">https://purl.org/cityexplorer#EventTypes</seealso>
    let EventTypes = Prefixed_Name(ce, "EventTypes") |> PrefixedName
    /// <summary>
    ///   <para>ce:Gastronomic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Gastronomic">https://purl.org/cityexplorer#Gastronomic</seealso>
    let Gastronomic = Prefixed_Name(ce, "Gastronomic") |> PrefixedName
    /// <summary>
    ///   <para>ce:GastronomicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an event involving gastronomy"</para>
    /// labels<para>"GastronomicEvent"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#GastronomicEvent">https://purl.org/cityexplorer#GastronomicEvent</seealso>
    let GastronomicEvent = Prefixed_Name(ce, "GastronomicEvent") |> PrefixedName
    /// <summary>
    ///   <para>ce:Hotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an hotel"</para>
    /// labels<para>"Hotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Hotel">https://purl.org/cityexplorer#Hotel</seealso>
    let Hotel = Prefixed_Name(ce, "Hotel") |> PrefixedName
    /// <summary>
    ///   <para>ce:HotelCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Includes different hotel categories"</para>
    /// labels<para>"HotelCategory"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#HotelCategory">https://purl.org/cityexplorer#HotelCategory</seealso>
    let HotelCategory = Prefixed_Name(ce, "HotelCategory") |> PrefixedName
    /// <summary>
    ///   <para>ce:HotelTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the category of hotels"</para>
    /// labels<para>"HotelTypes"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#HotelTypes">https://purl.org/cityexplorer#HotelTypes</seealso>
    let HotelTypes = Prefixed_Name(ce, "HotelTypes") |> PrefixedName
    /// <summary>
    ///   <para>ce:ItalianRestaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to restaurants serving food from Italy"</para>
    /// labels<para>"ItalianRestaurant"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#ItalianRestaurant">https://purl.org/cityexplorer#ItalianRestaurant</seealso>
    let ItalianRestaurant = Prefixed_Name(ce, "ItalianRestaurant") |> PrefixedName
    /// <summary>
    ///   <para>ce:Italianian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Italianian">https://purl.org/cityexplorer#Italianian</seealso>
    let Italianian = Prefixed_Name(ce, "Italianian") |> PrefixedName
    /// <summary>
    ///   <para>ce:Japanese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Japanese">https://purl.org/cityexplorer#Japanese</seealso>
    let Japanese = Prefixed_Name(ce, "Japanese") |> PrefixedName
    /// <summary>
    ///   <para>ce:JapaneseRestaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to restaurants serving food from Japan"</para>
    /// labels<para>"JapaneseRestaurant"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#JapaneseRestaurant">https://purl.org/cityexplorer#JapaneseRestaurant</seealso>
    let JapaneseRestaurant = Prefixed_Name(ce, "JapaneseRestaurant") |> PrefixedName
    /// <summary>
    ///   <para>ce:Luxury</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Luxury">https://purl.org/cityexplorer#Luxury</seealso>
    let Luxury = Prefixed_Name(ce, "Luxury") |> PrefixedName
    /// <summary>
    ///   <para>ce:LuxuryHotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to hotels considered luxurious"</para>
    /// labels<para>"LuxuryHotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#LuxuryHotel">https://purl.org/cityexplorer#LuxuryHotel</seealso>
    let LuxuryHotel = Prefixed_Name(ce, "LuxuryHotel") |> PrefixedName
    /// <summary>
    ///   <para>ce:M%C3%A0laga</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#M%C3%A0laga">https://purl.org/cityexplorer#M%C3%A0laga</seealso>
    let ``M%C3%A0laga`` = Prefixed_Name(ce, "M%C3%A0laga") |> PrefixedName
    /// <summary>
    ///   <para>ce:Madrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Madrid">https://purl.org/cityexplorer#Madrid</seealso>
    let Madrid = Prefixed_Name(ce, "Madrid") |> PrefixedName
    /// <summary>
    ///   <para>ce:Mediterranean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Mediterranean">https://purl.org/cityexplorer#Mediterranean</seealso>
    let Mediterranean = Prefixed_Name(ce, "Mediterranean") |> PrefixedName

    /// <summary>
    ///   <para>ce:MediterraneanRestaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to restaurants serving mediterranean food"</para>
    /// labels<para>"MediterraneanHotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#MediterraneanRestaurant">https://purl.org/cityexplorer#MediterraneanRestaurant</seealso>
    let MediterraneanRestaurant =
        Prefixed_Name(ce, "MediterraneanRestaurant") |> PrefixedName

    /// <summary>
    ///   <para>ce:Metro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Metro">https://purl.org/cityexplorer#Metro</seealso>
    let Metro = Prefixed_Name(ce, "Metro") |> PrefixedName
    /// <summary>
    ///   <para>ce:MetroTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to metro transport"</para>
    /// labels<para>"MetroTransport"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#MetroTransport">https://purl.org/cityexplorer#MetroTransport</seealso>
    let MetroTransport = Prefixed_Name(ce, "MetroTransport") |> PrefixedName
    /// <summary>
    ///   <para>ce:Mexican</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Mexican">https://purl.org/cityexplorer#Mexican</seealso>
    let Mexican = Prefixed_Name(ce, "Mexican") |> PrefixedName
    /// <summary>
    ///   <para>ce:MexicanRestaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to restaurants serving food from Mexico"</para>
    /// labels<para>"MexicanRestaurant"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#MexicanRestaurant">https://purl.org/cityexplorer#MexicanRestaurant</seealso>
    let MexicanRestaurant = Prefixed_Name(ce, "MexicanRestaurant") |> PrefixedName
    /// <summary>
    ///   <para>ce:Monument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Monument">https://purl.org/cityexplorer#Monument</seealso>
    let Monument = Prefixed_Name(ce, "Monument") |> PrefixedName
    /// <summary>
    ///   <para>ce:MonumentAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to attractions involving a monument"</para>
    /// labels<para>"MonumentAttraction"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#MonumentAttraction">https://purl.org/cityexplorer#MonumentAttraction</seealso>
    let MonumentAttraction = Prefixed_Name(ce, "MonumentAttraction") |> PrefixedName
    /// <summary>
    ///   <para>ce:Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Museum">https://purl.org/cityexplorer#Museum</seealso>
    let Museum = Prefixed_Name(ce, "Museum") |> PrefixedName
    /// <summary>
    ///   <para>ce:MuseumAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to attractions involving a museum"</para>
    /// labels<para>"MuseumAttraction"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#MuseumAttraction">https://purl.org/cityexplorer#MuseumAttraction</seealso>
    let MuseumAttraction = Prefixed_Name(ce, "MuseumAttraction") |> PrefixedName
    /// <summary>
    ///   <para>ce:Music</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Music">https://purl.org/cityexplorer#Music</seealso>
    let Music = Prefixed_Name(ce, "Music") |> PrefixedName
    /// <summary>
    ///   <para>ce:MusicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an event involving music"</para>
    /// labels<para>"MusicEveent"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#MusicEvent">https://purl.org/cityexplorer#MusicEvent</seealso>
    let MusicEvent = Prefixed_Name(ce, "MusicEvent") |> PrefixedName
    /// <summary>
    ///   <para>ce:Pamplona</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Pamplona">https://purl.org/cityexplorer#Pamplona</seealso>
    let Pamplona = Prefixed_Name(ce, "Pamplona") |> PrefixedName
    /// <summary>
    ///   <para>ce:Park</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Park">https://purl.org/cityexplorer#Park</seealso>
    let Park = Prefixed_Name(ce, "Park") |> PrefixedName
    /// <summary>
    ///   <para>ce:ParkAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to attractions involving a park"</para>
    /// labels<para>"ParkAttraction"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#ParkAttraction">https://purl.org/cityexplorer#ParkAttraction</seealso>
    let ParkAttraction = Prefixed_Name(ce, "ParkAttraction") |> PrefixedName
    /// <summary>
    ///   <para>ce:PublicBike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#PublicBike">https://purl.org/cityexplorer#PublicBike</seealso>
    let PublicBike = Prefixed_Name(ce, "PublicBike") |> PrefixedName
    /// <summary>
    ///   <para>ce:PublicBikeTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to public bike transport"</para>
    /// labels<para>"PublicBike"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#PublicBikeTransport">https://purl.org/cityexplorer#PublicBikeTransport</seealso>
    let PublicBikeTransport = Prefixed_Name(ce, "PublicBikeTransport") |> PrefixedName
    /// <summary>
    ///   <para>ce:Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Base class to make searches based on rules"</para>
    /// labels<para>"Recommendations"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Recommendation">https://purl.org/cityexplorer#Recommendation</seealso>
    let Recommendation = Prefixed_Name(ce, "Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>ce:RecommendedRestaurants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to restaurants that are recommended"</para>
    /// labels<para>"RecommendedRestaurants"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#RecommendedRestaurants">https://purl.org/cityexplorer#RecommendedRestaurants</seealso>
    let RecommendedRestaurants =
        Prefixed_Name(ce, "RecommendedRestaurants") |> PrefixedName

    /// <summary>
    ///   <para>ce:Restaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to a restaurant"</para>
    /// labels<para>"Restaurant"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Restaurant">https://purl.org/cityexplorer#Restaurant</seealso>
    let Restaurant = Prefixed_Name(ce, "Restaurant") |> PrefixedName
    /// <summary>
    ///   <para>ce:RestaurantCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Includes different restaurant categories"</para>
    /// labels<para>"RestaurantCategory"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#RestaurantCategory">https://purl.org/cityexplorer#RestaurantCategory</seealso>
    let RestaurantCategory = Prefixed_Name(ce, "RestaurantCategory") |> PrefixedName
    /// <summary>
    ///   <para>ce:RestaurantTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the category of restaurants"</para>
    /// labels<para>"RestaurantType"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#RestaurantTypes">https://purl.org/cityexplorer#RestaurantTypes</seealso>
    let RestaurantTypes = Prefixed_Name(ce, "RestaurantTypes") |> PrefixedName
    /// <summary>
    ///   <para>ce:Rural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Rural">https://purl.org/cityexplorer#Rural</seealso>
    let Rural = Prefixed_Name(ce, "Rural") |> PrefixedName
    /// <summary>
    ///   <para>ce:RuralHotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to hotels considered rural"</para>
    /// labels<para>"RuralHotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#RuralHotel">https://purl.org/cityexplorer#RuralHotel</seealso>
    let RuralHotel = Prefixed_Name(ce, "RuralHotel") |> PrefixedName
    /// <summary>
    ///   <para>ce:SantSebasti%C3%A0</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#SantSebasti%C3%A0">https://purl.org/cityexplorer#SantSebasti%C3%A0</seealso>
    let ``SantSebasti%C3%A0`` = Prefixed_Name(ce, "SantSebasti%C3%A0") |> PrefixedName
    /// <summary>
    ///   <para>ce:Saragossa</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Saragossa">https://purl.org/cityexplorer#Saragossa</seealso>
    let Saragossa = Prefixed_Name(ce, "Saragossa") |> PrefixedName
    /// <summary>
    ///   <para>ce:Sevilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Sevilla">https://purl.org/cityexplorer#Sevilla</seealso>
    let Sevilla = Prefixed_Name(ce, "Sevilla") |> PrefixedName
    /// <summary>
    ///   <para>ce:Sport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Sport">https://purl.org/cityexplorer#Sport</seealso>
    let Sport = Prefixed_Name(ce, "Sport") |> PrefixedName
    /// <summary>
    ///   <para>ce:SportsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an event involving sports"</para>
    /// labels<para>"SportsEvent"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#SportsEvent">https://purl.org/cityexplorer#SportsEvent</seealso>
    let SportsEvent = Prefixed_Name(ce, "SportsEvent") |> PrefixedName
    /// <summary>
    ///   <para>ce:Taxi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Taxi">https://purl.org/cityexplorer#Taxi</seealso>
    let Taxi = Prefixed_Name(ce, "Taxi") |> PrefixedName
    /// <summary>
    ///   <para>ce:TaxiTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to taxi transport"</para>
    /// labels<para>"TaxiTransport"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#TaxiTransport">https://purl.org/cityexplorer#TaxiTransport</seealso>
    let TaxiTransport = Prefixed_Name(ce, "TaxiTransport") |> PrefixedName
    /// <summary>
    ///   <para>ce:Technological</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Technological">https://purl.org/cityexplorer#Technological</seealso>
    let Technological = Prefixed_Name(ce, "Technological") |> PrefixedName
    /// <summary>
    ///   <para>ce:TechnologicalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to an event involving tecnology"</para>
    /// labels<para>"TechnologicalEvent"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#TechnologicalEvent">https://purl.org/cityexplorer#TechnologicalEvent</seealso>
    let TechnologicalEvent = Prefixed_Name(ce, "TechnologicalEvent") |> PrefixedName
    /// <summary>
    ///   <para>ce:Toledo</para>
    /// </summary>
    /// <remarks>
    ///   <para>ce:City</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Toledo">https://purl.org/cityexplorer#Toledo</seealso>
    let Toledo = Prefixed_Name(ce, "Toledo") |> PrefixedName
    /// <summary>
    ///   <para>ce:Tourist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Tourist">https://purl.org/cityexplorer#Tourist</seealso>
    let Tourist = Prefixed_Name(ce, "Tourist") |> PrefixedName
    /// <summary>
    ///   <para>ce:TouristHotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to touristic hotels"</para>
    /// labels<para>"TouristHotel"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#TouristHotel">https://purl.org/cityexplorer#TouristHotel</seealso>
    let TouristHotel = Prefixed_Name(ce, "TouristHotel") |> PrefixedName
    /// <summary>
    ///   <para>ce:Tram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Tram">https://purl.org/cityexplorer#Tram</seealso>
    let Tram = Prefixed_Name(ce, "Tram") |> PrefixedName
    /// <summary>
    ///   <para>ce:TramTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to tram transport"</para>
    /// labels<para>"TramTransport"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#TramTransport">https://purl.org/cityexplorer#TramTransport</seealso>
    let TramTransport = Prefixed_Name(ce, "TramTransport") |> PrefixedName
    /// <summary>
    ///   <para>ce:Transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to a way of transport"</para>
    /// labels<para>"Transport"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#Transport">https://purl.org/cityexplorer#Transport</seealso>
    let Transport = Prefixed_Name(ce, "Transport") |> PrefixedName
    /// <summary>
    ///   <para>ce:TransportCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Includes different attraction categories"</para>
    /// labels<para>"TransportCategory"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#TransportCategory">https://purl.org/cityexplorer#TransportCategory</seealso>
    let TransportCategory = Prefixed_Name(ce, "TransportCategory") |> PrefixedName
    /// <summary>
    ///   <para>ce:TransportTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the category of transports"</para>
    /// labels<para>"TransportType"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#TransportTypes">https://purl.org/cityexplorer#TransportTypes</seealso>
    let TransportTypes = Prefixed_Name(ce, "TransportTypes") |> PrefixedName
    /// <summary>
    ///   <para>ce:Val%C3%A8ncia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ce:City</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cityexplorer#Val%C3%A8ncia">https://purl.org/cityexplorer#Val%C3%A8ncia</seealso>
    let ``Val%C3%A8ncia`` = Prefixed_Name(ce, "Val%C3%A8ncia") |> PrefixedName
    /// <summary>
    ///   <para>ce:aggregateRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The overall rating, based on a collection of reviews or ratings, of the item"</para>
    /// labels<para>"aggregateRating"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#aggregateRating">https://purl.org/cityexplorer#aggregateRating</seealso>
    let aggregateRating = Prefixed_Name(ce, "aggregateRating") |> PrefixedName
    /// <summary>
    ///   <para>ce:company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The company of transport"</para>
    /// labels<para>"Company"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#company">https://purl.org/cityexplorer#company</seealso>
    let company = Prefixed_Name(ce, "company") |> PrefixedName
    /// <summary>
    ///   <para>ce:hasCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicate if a class has a specific category"</para>
    /// labels<para>"hasCategory"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#hasCategory">https://purl.org/cityexplorer#hasCategory</seealso>
    let hasCategory = Prefixed_Name(ce, "hasCategory") |> PrefixedName
    /// <summary>
    ///   <para>ce:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier of the object (city, etc.)"</para>
    /// labels<para>"Identifier"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#identifier">https://purl.org/cityexplorer#identifier</seealso>
    let identifier = Prefixed_Name(ce, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>ce:isCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Indicates if a category is a category of a class"</para>
    /// labels<para>"isCategoryOf"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#isCategoryOf">https://purl.org/cityexplorer#isCategoryOf</seealso>
    let isCategoryOf = Prefixed_Name(ce, "isCategoryOf") |> PrefixedName
    /// <summary>
    ///   <para>ce:isCityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Indicates if the city contains the specific property"</para>
    /// labels<para>"isCityOf"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#isCityOf">https://purl.org/cityexplorer#isCityOf</seealso>
    let isCityOf = Prefixed_Name(ce, "isCityOf") |> PrefixedName
    /// <summary>
    ///   <para>ce:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The latitude of a location"</para>
    /// labels<para>"Latitude"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#latitude">https://purl.org/cityexplorer#latitude</seealso>
    let latitude = Prefixed_Name(ce, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>ce:locatedInCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Indicates if it's located in a city"</para>
    /// labels<para>"locatedInCity"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#locatedInCity">https://purl.org/cityexplorer#locatedInCity</seealso>
    let locatedInCity = Prefixed_Name(ce, "locatedInCity") |> PrefixedName
    /// <summary>
    ///   <para>ce:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The longitude of a location"</para>
    /// labels<para>"Longitude"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#longitude">https://purl.org/cityexplorer#longitude</seealso>
    let longitude = Prefixed_Name(ce, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>ce:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The name of the item"</para>
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#name">https://purl.org/cityexplorer#name</seealso>
    let name = Prefixed_Name(ce, "name") |> PrefixedName
    /// <summary>
    ///   <para>ce:priceRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The price range of the business"</para>
    /// labels<para>"priceRange"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#priceRange">https://purl.org/cityexplorer#priceRange</seealso>
    let priceRange = Prefixed_Name(ce, "priceRange") |> PrefixedName
    /// <summary>
    ///   <para>ce:starRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An official rating for a lodging business or food establishment"</para>
    /// labels<para>"starRating"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#starRating">https://purl.org/cityexplorer#starRating</seealso>
    let starRating = Prefixed_Name(ce, "starRating") |> PrefixedName
    /// <summary>
    ///   <para>ce:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The start date and time of the item"</para>
    /// labels<para>"startDate"</para></remarks>
    /// <seealso href="https://purl.org/cityexplorer#startDate">https://purl.org/cityexplorer#startDate</seealso>
    let startDate = Prefixed_Name(ce, "startDate") |> PrefixedName
