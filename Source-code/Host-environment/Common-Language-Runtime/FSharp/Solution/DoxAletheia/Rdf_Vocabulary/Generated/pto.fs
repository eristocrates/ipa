namespace http.www.productontology.org.id.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pto =
    let _namespace_iri = Namespace_Iri pto |> NamespaceIRI
    /// <summary>
    ///   <para>pto:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/">http://www.productontology.org/id/</seealso>
    let _prefix_iri = Prefixed_Name(pto, "") |> PrefixedName
    /// <summary>
    ///   <para>pto:Alcoholic_beverage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Alcoholic_beverage">http://www.productontology.org/id/Alcoholic_beverage</seealso>
    let Alcoholic_beverage = Prefixed_Name(pto, "Alcoholic_beverage") |> PrefixedName
    /// <summary>
    ///   <para>pto:Ale</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Ale">http://www.productontology.org/id/Ale</seealso>
    let Ale = Prefixed_Name(pto, "Ale") |> PrefixedName
    /// <summary>
    ///   <para>pto:American_whiskey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/American_whiskey">http://www.productontology.org/id/American_whiskey</seealso>
    let American_whiskey = Prefixed_Name(pto, "American_whiskey") |> PrefixedName
    /// <summary>
    ///   <para>pto:Atlas</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Atlas">http://www.productontology.org/id/Atlas</seealso>
    let Atlas = Prefixed_Name(pto, "Atlas") |> PrefixedName
    /// <summary>
    ///   <para>pto:Beer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Beer">http://www.productontology.org/id/Beer</seealso>
    let Beer = Prefixed_Name(pto, "Beer") |> PrefixedName
    /// <summary>
    ///   <para>pto:Beer_cocktail</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Beer_cocktail">http://www.productontology.org/id/Beer_cocktail</seealso>
    let Beer_cocktail = Prefixed_Name(pto, "Beer_cocktail") |> PrefixedName
    /// <summary>
    ///   <para>pto:Bourbon_whiskey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Bourbon_whiskey">http://www.productontology.org/id/Bourbon_whiskey</seealso>
    let Bourbon_whiskey = Prefixed_Name(pto, "Bourbon_whiskey") |> PrefixedName
    /// <summary>
    ///   <para>pto:Brandy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Brandy">http://www.productontology.org/id/Brandy</seealso>
    let Brandy = Prefixed_Name(pto, "Brandy") |> PrefixedName
    /// <summary>
    ///   <para>pto:Canadian_whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Canadian_whisky">http://www.productontology.org/id/Canadian_whisky</seealso>
    let Canadian_whisky = Prefixed_Name(pto, "Canadian_whisky") |> PrefixedName
    /// <summary>
    ///   <para>pto:Carbonated_water</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Carbonated_water">http://www.productontology.org/id/Carbonated_water</seealso>
    let Carbonated_water = Prefixed_Name(pto, "Carbonated_water") |> PrefixedName
    /// <summary>
    ///   <para>pto:Cocktail</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Cocktail">http://www.productontology.org/id/Cocktail</seealso>
    let Cocktail = Prefixed_Name(pto, "Cocktail") |> PrefixedName
    /// <summary>
    ///   <para>pto:Cognac</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Cognac">http://www.productontology.org/id/Cognac</seealso>
    let Cognac = Prefixed_Name(pto, "Cognac") |> PrefixedName
    /// <summary>
    ///   <para>pto:Distilled_beverage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Distilled_beverage">http://www.productontology.org/id/Distilled_beverage</seealso>
    let Distilled_beverage = Prefixed_Name(pto, "Distilled_beverage") |> PrefixedName
    /// <summary>
    ///   <para>pto:Drink</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Drink">http://www.productontology.org/id/Drink</seealso>
    let Drink = Prefixed_Name(pto, "Drink") |> PrefixedName
    /// <summary>
    ///   <para>pto:Dunkel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Dunkel">http://www.productontology.org/id/Dunkel</seealso>
    let Dunkel = Prefixed_Name(pto, "Dunkel") |> PrefixedName
    /// <summary>
    ///   <para>pto:English_porter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/English_porter">http://www.productontology.org/id/English_porter</seealso>
    let English_porter = Prefixed_Name(pto, "English_porter") |> PrefixedName
    /// <summary>
    ///   <para>pto:Fruit_wine</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Fruit_wine">http://www.productontology.org/id/Fruit_wine</seealso>
    let Fruit_wine = Prefixed_Name(pto, "Fruit_wine") |> PrefixedName
    /// <summary>
    ///   <para>pto:Gin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Gin">http://www.productontology.org/id/Gin</seealso>
    let Gin = Prefixed_Name(pto, "Gin") |> PrefixedName
    /// <summary>
    ///   <para>pto:Highball</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Highball">http://www.productontology.org/id/Highball</seealso>
    let Highball = Prefixed_Name(pto, "Highball") |> PrefixedName
    /// <summary>
    ///   <para>pto:Irish_whiskey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Irish_whiskey">http://www.productontology.org/id/Irish_whiskey</seealso>
    let Irish_whiskey = Prefixed_Name(pto, "Irish_whiskey") |> PrefixedName
    /// <summary>
    ///   <para>pto:Japanese_whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Japanese_whisky">http://www.productontology.org/id/Japanese_whisky</seealso>
    let Japanese_whisky = Prefixed_Name(pto, "Japanese_whisky") |> PrefixedName
    /// <summary>
    ///   <para>pto:Lager</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Lager">http://www.productontology.org/id/Lager</seealso>
    let Lager = Prefixed_Name(pto, "Lager") |> PrefixedName
    /// <summary>
    ///   <para>pto:Liqueur</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Liqueur">http://www.productontology.org/id/Liqueur</seealso>
    let Liqueur = Prefixed_Name(pto, "Liqueur") |> PrefixedName
    /// <summary>
    ///   <para>pto:Low-alcohol_beer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Low-alcohol_beer">http://www.productontology.org/id/Low-alcohol_beer</seealso>
    let Low_alcohol_beer = Prefixed_Name(pto, "Low-alcohol_beer") |> PrefixedName
    /// <summary>
    ///   <para>pto:Malt_whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Malt_whisky">http://www.productontology.org/id/Malt_whisky</seealso>
    let Malt_whisky = Prefixed_Name(pto, "Malt_whisky") |> PrefixedName
    /// <summary>
    ///   <para>pto:Mineral_water</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Mineral_water">http://www.productontology.org/id/Mineral_water</seealso>
    let Mineral_water = Prefixed_Name(pto, "Mineral_water") |> PrefixedName
    /// <summary>
    ///   <para>pto:Mixed_drink</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Mixed_drink">http://www.productontology.org/id/Mixed_drink</seealso>
    let Mixed_drink = Prefixed_Name(pto, "Mixed_drink") |> PrefixedName
    /// <summary>
    ///   <para>pto:Newspaper</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Newspaper">http://www.productontology.org/id/Newspaper</seealso>
    let Newspaper = Prefixed_Name(pto, "Newspaper") |> PrefixedName

    /// <summary>
    ///   <para>pto:Non-alcoholic_beverage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Non-alcoholic_beverage">http://www.productontology.org/id/Non-alcoholic_beverage</seealso>
    let Non_alcoholic_beverage =
        Prefixed_Name(pto, "Non-alcoholic_beverage") |> PrefixedName

    /// <summary>
    ///   <para>pto:Pale_ale</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Pale_ale">http://www.productontology.org/id/Pale_ale</seealso>
    let Pale_ale = Prefixed_Name(pto, "Pale_ale") |> PrefixedName
    /// <summary>
    ///   <para>pto:Pale_lager</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Pale_lager">http://www.productontology.org/id/Pale_lager</seealso>
    let Pale_lager = Prefixed_Name(pto, "Pale_lager") |> PrefixedName
    /// <summary>
    ///   <para>pto:Pilsner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Pilsner">http://www.productontology.org/id/Pilsner</seealso>
    let Pilsner = Prefixed_Name(pto, "Pilsner") |> PrefixedName
    /// <summary>
    ///   <para>pto:Pisco</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Pisco">http://www.productontology.org/id/Pisco</seealso>
    let Pisco = Prefixed_Name(pto, "Pisco") |> PrefixedName
    /// <summary>
    ///   <para>pto:Red_wine</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Red_wine">http://www.productontology.org/id/Red_wine</seealso>
    let Red_wine = Prefixed_Name(pto, "Red_wine") |> PrefixedName
    /// <summary>
    ///   <para>pto:Rum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Rum">http://www.productontology.org/id/Rum</seealso>
    let Rum = Prefixed_Name(pto, "Rum") |> PrefixedName
    /// <summary>
    ///   <para>pto:Sake</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Sake">http://www.productontology.org/id/Sake</seealso>
    let Sake = Prefixed_Name(pto, "Sake") |> PrefixedName
    /// <summary>
    ///   <para>pto:Scotch_whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Scotch_whisky">http://www.productontology.org/id/Scotch_whisky</seealso>
    let Scotch_whisky = Prefixed_Name(pto, "Scotch_whisky") |> PrefixedName
    /// <summary>
    ///   <para>pto:Shandy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Shandy">http://www.productontology.org/id/Shandy</seealso>
    let Shandy = Prefixed_Name(pto, "Shandy") |> PrefixedName
    /// <summary>
    ///   <para>pto:Single_malt_Scotch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Single_malt_Scotch">http://www.productontology.org/id/Single_malt_Scotch</seealso>
    let Single_malt_Scotch = Prefixed_Name(pto, "Single_malt_Scotch") |> PrefixedName
    /// <summary>
    ///   <para>pto:Single_malt_whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Single_malt_whisky">http://www.productontology.org/id/Single_malt_whisky</seealso>
    let Single_malt_whisky = Prefixed_Name(pto, "Single_malt_whisky") |> PrefixedName
    /// <summary>
    ///   <para>pto:Soju</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Soju">http://www.productontology.org/id/Soju</seealso>
    let Soju = Prefixed_Name(pto, "Soju") |> PrefixedName

    /// <summary>
    ///   <para>pto:Speyside_single_malts</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Speyside_single_malts">http://www.productontology.org/id/Speyside_single_malts</seealso>
    let Speyside_single_malts =
        Prefixed_Name(pto, "Speyside_single_malts") |> PrefixedName

    /// <summary>
    ///   <para>pto:Stout</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Stout">http://www.productontology.org/id/Stout</seealso>
    let Stout = Prefixed_Name(pto, "Stout") |> PrefixedName
    /// <summary>
    ///   <para>pto:Tequila</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Tequila">http://www.productontology.org/id/Tequila</seealso>
    let Tequila = Prefixed_Name(pto, "Tequila") |> PrefixedName
    /// <summary>
    ///   <para>pto:Thesis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Thesis">http://www.productontology.org/id/Thesis</seealso>
    let Thesis = Prefixed_Name(pto, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>pto:Vodka</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Vodka">http://www.productontology.org/id/Vodka</seealso>
    let Vodka = Prefixed_Name(pto, "Vodka") |> PrefixedName
    /// <summary>
    ///   <para>pto:Water</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Water">http://www.productontology.org/id/Water</seealso>
    let Water = Prefixed_Name(pto, "Water") |> PrefixedName
    /// <summary>
    ///   <para>pto:Whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Whisky">http://www.productontology.org/id/Whisky</seealso>
    let Whisky = Prefixed_Name(pto, "Whisky") |> PrefixedName
    /// <summary>
    ///   <para>pto:White_wine</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/White_wine">http://www.productontology.org/id/White_wine</seealso>
    let White_wine = Prefixed_Name(pto, "White_wine") |> PrefixedName
    /// <summary>
    ///   <para>pto:Wine</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.productontology.org/id/Wine">http://www.productontology.org/id/Wine</seealso>
    let Wine = Prefixed_Name(pto, "Wine") |> PrefixedName
