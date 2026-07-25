namespace http.rdfs.co.bevon.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bevon =
    let _namespace_iri = Namespace_Iri bevon |> NamespaceIRI
    /// <summary>
    ///   <para>bevon:0.8</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticAsset</para>
    ///   <para>ccrel:Work</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>
    ///     &lt;div&gt;
    ///       The master version of this vocabulary is maintained in &lt;a
    ///       href="https://github.com/jgkim/bevon"&gt;the GitHub repository&lt;/a&gt; so others
    ///       can contribute edits and improvements.
    ///     &lt;/div&gt;
    ///     </para>
    ///   <para>
    ///     Most of the descriptions given here are from Wikipedia or from the websites
    ///     of the related products.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/0.8">http://rdfs.co/bevon/0.8</seealso>
    let ``_0.8`` = Prefixed_Name(bevon, "0.8") |> PrefixedName
    /// <summary>
    ///   <para>bevon:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/bevon/">http://rdfs.co/bevon/</seealso>
    let _prefix_iri = Prefixed_Name(bevon, "") |> PrefixedName
    /// <summary>
    ///   <para>bevon:CoreGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     These classes and properties form the core of BEVON. They describe
    ///     characteristics of beverages in relatively broad terms.
    ///     </para>
    /// labels<para>Core Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/CoreGroup">http://rdfs.co/bevon/CoreGroup</seealso>
    let CoreGroup = Prefixed_Name(bevon, "CoreGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:WineGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     These classes describe types of wines.
    ///     </para>
    /// labels<para>Wine Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/WineGroup">http://rdfs.co/bevon/WineGroup</seealso>
    let WineGroup = Prefixed_Name(bevon, "WineGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:abv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/abv">http://rdfs.co/bevon/abv</seealso>
    let abv = Prefixed_Name(bevon, "abv") |> PrefixedName
    /// <summary>
    ///   <para>bevon:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/quantity">http://rdfs.co/bevon/quantity</seealso>
    let quantity = Prefixed_Name(bevon, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Distillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Distillery">http://rdfs.co/bevon/Distillery</seealso>
    let Distillery = Prefixed_Name(bevon, "Distillery") |> PrefixedName
    /// <summary>
    ///   <para>bevon:0.8/rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/bevon/0.8/rdf">http://rdfs.co/bevon/0.8/rdf</seealso>
    let ``_0.8/rdf`` = Prefixed_Name(bevon, "0.8/rdf") |> PrefixedName
    /// <summary>
    ///   <para>bevon:distillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/distillery">http://rdfs.co/bevon/distillery</seealso>
    let distillery = Prefixed_Name(bevon, "distillery") |> PrefixedName
    /// <summary>
    ///   <para>bevon:0.8/html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/bevon/0.8/html">http://rdfs.co/bevon/0.8/html</seealso>
    let ``_0.8/html`` = Prefixed_Name(bevon, "0.8/html") |> PrefixedName
    /// <summary>
    ///   <para>bevon:brewery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/brewery">http://rdfs.co/bevon/brewery</seealso>
    let brewery = Prefixed_Name(bevon, "brewery") |> PrefixedName
    /// <summary>
    ///   <para>bevon:DryStout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/DryStout">http://rdfs.co/bevon/DryStout</seealso>
    let DryStout = Prefixed_Name(bevon, "DryStout") |> PrefixedName
    /// <summary>
    ///   <para>bevon:0.7</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/bevon/0.7">http://rdfs.co/bevon/0.7</seealso>
    let ``_0.7`` = Prefixed_Name(bevon, "0.7") |> PrefixedName
    /// <summary>
    ///   <para>bevon:BeerGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     In addition to the BEVON core terms, there are a number of terms for use
    ///     when describing beverages categorized under Beer.
    ///     </para>
    /// labels<para>Beer Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/BeerGroup">http://rdfs.co/bevon/BeerGroup</seealso>
    let BeerGroup = Prefixed_Name(bevon, "BeerGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:CocktailGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     These classes and properties are for describing beverages categorized under
    ///     Mixed Drink.
    ///     </para>
    /// labels<para>Cocktail Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/CocktailGroup">http://rdfs.co/bevon/CocktailGroup</seealso>
    let CocktailGroup = Prefixed_Name(bevon, "CocktailGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:RelationGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     These properties are used for describing relations between beverages.
    ///     </para>
    /// labels<para>Relation Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/RelationGroup">http://rdfs.co/bevon/RelationGroup</seealso>
    let RelationGroup = Prefixed_Name(bevon, "RelationGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:ContainerGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     These classes and properties are used to describe beverage containers.
    ///     </para>
    /// labels<para>Container Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/ContainerGroup">http://rdfs.co/bevon/ContainerGroup</seealso>
    let ContainerGroup = Prefixed_Name(bevon, "ContainerGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/description">http://rdfs.co/bevon/description</seealso>
    let description = Prefixed_Name(bevon, "description") |> PrefixedName
    /// <summary>
    ///   <para>bevon:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/origin">http://rdfs.co/bevon/origin</seealso>
    let origin = Prefixed_Name(bevon, "origin") |> PrefixedName
    /// <summary>
    ///   <para>bevon:ingredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/ingredient">http://rdfs.co/bevon/ingredient</seealso>
    let ingredient = Prefixed_Name(bevon, "ingredient") |> PrefixedName
    /// <summary>
    ///   <para>bevon:FermentationBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/FermentationBase">http://rdfs.co/bevon/FermentationBase</seealso>
    let FermentationBase = Prefixed_Name(bevon, "FermentationBase") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/440mlBeverageCan</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:BeverageCan</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/440mlBeverageCan">http://rdfs.co/bevon/container/440mlBeverageCan</seealso>
    let ``container/440mlBeverageCan`` =
        Prefixed_Name(bevon, "container/440mlBeverageCan") |> PrefixedName

    /// <summary>
    ///   <para>bevon:Highball</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Highball">http://rdfs.co/bevon/Highball</seealso>
    let Highball = Prefixed_Name(bevon, "Highball") |> PrefixedName
    /// <summary>
    ///   <para>bevon:WhiskyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>
    ///     These classes describe types of whiskies.
    ///     </para>
    /// labels<para>Whisky Terms</para></remarks>
    /// <seealso href="http://rdfs.co/bevon/WhiskyGroup">http://rdfs.co/bevon/WhiskyGroup</seealso>
    let WhiskyGroup = Prefixed_Name(bevon, "WhiskyGroup") |> PrefixedName
    /// <summary>
    ///   <para>bevon:fermentation_base</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/fermentation_base">http://rdfs.co/bevon/fermentation_base</seealso>
    let fermentation_base = Prefixed_Name(bevon, "fermentation_base") |> PrefixedName
    /// <summary>
    ///   <para>bevon:AlcoholicBeverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/AlcoholicBeverage">http://rdfs.co/bevon/AlcoholicBeverage</seealso>
    let AlcoholicBeverage = Prefixed_Name(bevon, "AlcoholicBeverage") |> PrefixedName

    /// <summary>
    ///   <para>bevon:NonAlcoholicBeverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/NonAlcoholicBeverage">http://rdfs.co/bevon/NonAlcoholicBeverage</seealso>
    let NonAlcoholicBeverage =
        Prefixed_Name(bevon, "NonAlcoholicBeverage") |> PrefixedName

    /// <summary>
    ///   <para>bevon:Ale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The yeast will ferment the beer quickly, giving it a sweet, full bodied and
    ///     fruity taste.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Ale">http://rdfs.co/bevon/Ale</seealso>
    let Ale = Prefixed_Name(bevon, "Ale") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Aging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Aging">http://rdfs.co/bevon/Aging</seealso>
    let Aging = Prefixed_Name(bevon, "Aging") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Beverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Beverage">http://rdfs.co/bevon/Beverage</seealso>
    let Beverage = Prefixed_Name(bevon, "Beverage") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Beer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The starch and saccharification enzymes are often derived from malted
    ///     cereal grains, most commonly malted barley and malted wheat.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Beer">http://rdfs.co/bevon/Beer</seealso>
    let Beer = Prefixed_Name(bevon, "Beer") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Whisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Different grains are used for different varieties, including barley, malted
    ///     barley, rye, malted rye, wheat, and corn. Whisky is typically aged in
    ///     wooden casks, made generally of charred white oak.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Whisky">http://rdfs.co/bevon/Whisky</seealso>
    let Whisky = Prefixed_Name(bevon, "Whisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:AmericanWhiskey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The production and labeling of American whiskey are governed by Title 27 of
    ///     the U.S. Code of Federal Regulations.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/AmericanWhiskey">http://rdfs.co/bevon/AmericanWhiskey</seealso>
    let AmericanWhiskey = Prefixed_Name(bevon, "AmericanWhiskey") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Sake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Sake">http://rdfs.co/bevon/Sake</seealso>
    let Sake = Prefixed_Name(bevon, "Sake") |> PrefixedName
    /// <summary>
    ///   <para>bevon:ScotchWhisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     All Scotch whisky was originally made from malt barley. Commercial
    ///     distilleries began introducing whisky made from wheat and rye in the late
    ///     eighteenth century.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/ScotchWhisky">http://rdfs.co/bevon/ScotchWhisky</seealso>
    let ScotchWhisky = Prefixed_Name(bevon, "ScotchWhisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:SingleMaltScotch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     As with any Scotch whisky, a single malt Scotch must be distilled in
    ///     Scotland and matured in oak casks in Scotland for at least three years
    ///     (most single malts are matured longer).
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/SingleMaltScotch">http://rdfs.co/bevon/SingleMaltScotch</seealso>
    let SingleMaltScotch = Prefixed_Name(bevon, "SingleMaltScotch") |> PrefixedName
    /// <summary>
    ///   <para>bevon:SingleMaltWhisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/SingleMaltWhisky">http://rdfs.co/bevon/SingleMaltWhisky</seealso>
    let SingleMaltWhisky = Prefixed_Name(bevon, "SingleMaltWhisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:SpeysideSingleMalt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/SpeysideSingleMalt">http://rdfs.co/bevon/SpeysideSingleMalt</seealso>
    let SpeysideSingleMalt = Prefixed_Name(bevon, "SpeysideSingleMalt") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Tequila</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Tequila">http://rdfs.co/bevon/Tequila</seealso>
    let Tequila = Prefixed_Name(bevon, "Tequila") |> PrefixedName
    /// <summary>
    ///   <para>bevon:TequilaBlanco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/TequilaBlanco">http://rdfs.co/bevon/TequilaBlanco</seealso>
    let TequilaBlanco = Prefixed_Name(bevon, "TequilaBlanco") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Vodka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Vodka is made by the distillation of fermented substances such as grains,
    ///     potatoes, or sometimes fruits or sugar.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Vodka">http://rdfs.co/bevon/Vodka</seealso>
    let Vodka = Prefixed_Name(bevon, "Vodka") |> PrefixedName
    /// <summary>
    ///   <para>bevon:WhiteWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     It is produced by the alcoholic fermentation of the non-coloured pulp of
    ///     grapes which may have a white or black skin. It is treated so as to
    ///     maintain a yellow transparent colour in the final product.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/WhiteWine">http://rdfs.co/bevon/WhiteWine</seealso>
    let WhiteWine = Prefixed_Name(bevon, "WhiteWine") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Budweiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:PaleLager</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Budweiser">http://rdfs.co/bevon/beverage/Budweiser</seealso>
    let ``beverage/Budweiser`` =
        Prefixed_Name(bevon, "beverage/Budweiser") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/330mlLongneck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:Longneck</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/330mlLongneck">http://rdfs.co/bevon/container/330mlLongneck</seealso>
    let ``container/330mlLongneck`` =
        Prefixed_Name(bevon, "container/330mlLongneck") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/500mlBeverageCan</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:BeverageCan</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/500mlBeverageCan">http://rdfs.co/bevon/container/500mlBeverageCan</seealso>
    let ``container/500mlBeverageCan`` =
        Prefixed_Name(bevon, "container/500mlBeverageCan") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/355mlBeverageCan</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:BeverageCan</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/355mlBeverageCan">http://rdfs.co/bevon/container/355mlBeverageCan</seealso>
    let ``container/355mlBeverageCan`` =
        Prefixed_Name(bevon, "container/355mlBeverageCan") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Chamisul</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:DilutedSoju</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Chamisul">http://rdfs.co/bevon/beverage/Chamisul</seealso>
    let ``beverage/Chamisul`` =
        Prefixed_Name(bevon, "beverage/Chamisul") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/1_8lPlasticBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:PlasticBottle</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/1_8lPlasticBottle">http://rdfs.co/bevon/container/1_8lPlasticBottle</seealso>
    let ``container/1_8lPlasticBottle`` =
        Prefixed_Name(bevon, "container/1_8lPlasticBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/640mlPlasticBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:PlasticBottle</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/640mlPlasticBottle">http://rdfs.co/bevon/container/640mlPlasticBottle</seealso>
    let ``container/640mlPlasticBottle`` =
        Prefixed_Name(bevon, "container/640mlPlasticBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/200mlPlasticBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:PlasticBottle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/200mlPlasticBottle">http://rdfs.co/bevon/container/200mlPlasticBottle</seealso>
    let ``container/200mlPlasticBottle`` =
        Prefixed_Name(bevon, "container/200mlPlasticBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/360mlGlassBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:GlassBottle</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/360mlGlassBottle">http://rdfs.co/bevon/container/360mlGlassBottle</seealso>
    let ``container/360mlGlassBottle`` =
        Prefixed_Name(bevon, "container/360mlGlassBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Chum-Churum</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:DilutedSoju</para>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Chum-Churum">http://rdfs.co/bevon/beverage/Chum-Churum</seealso>
    let ``beverage/Chum_Churum`` =
        Prefixed_Name(bevon, "beverage/Chum-Churum") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/360mlPlasticBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:PlasticBottle</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/360mlPlasticBottle">http://rdfs.co/bevon/container/360mlPlasticBottle</seealso>
    let ``container/360mlPlasticBottle`` =
        Prefixed_Name(bevon, "container/360mlPlasticBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/DonJulioBlanco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:TequilaBlanco</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/DonJulioBlanco">http://rdfs.co/bevon/beverage/DonJulioBlanco</seealso>
    let ``beverage/DonJulioBlanco`` =
        Prefixed_Name(bevon, "beverage/DonJulioBlanco") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/750mlGlassBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:GlassBottle</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/750mlGlassBottle">http://rdfs.co/bevon/container/750mlGlassBottle</seealso>
    let ``container/750mlGlassBottle`` =
        Prefixed_Name(bevon, "container/750mlGlassBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Glenfiddich12YearOld</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:SpeysideSingleMalt</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Glenfiddich12YearOld">http://rdfs.co/bevon/beverage/Glenfiddich12YearOld</seealso>
    let ``beverage/Glenfiddich12YearOld`` =
        Prefixed_Name(bevon, "beverage/Glenfiddich12YearOld") |> PrefixedName

    /// <summary>
    ///   <para>bevon:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/duration">http://rdfs.co/bevon/duration</seealso>
    let duration = Prefixed_Name(bevon, "duration") |> PrefixedName
    /// <summary>
    ///   <para>bevon:previous_content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/previous_content">http://rdfs.co/bevon/previous_content</seealso>
    let previous_content = Prefixed_Name(bevon, "previous_content") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/700mlGlassBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:GlassBottle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/700mlGlassBottle">http://rdfs.co/bevon/container/700mlGlassBottle</seealso>
    let ``container/700mlGlassBottle`` =
        Prefixed_Name(bevon, "container/700mlGlassBottle") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Guinness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:DryStout</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Guinness">http://rdfs.co/bevon/beverage/Guinness</seealso>
    let ``beverage/Guinness`` =
        Prefixed_Name(bevon, "beverage/Guinness") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/15lBeerKeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:BeerKeg</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/15lBeerKeg">http://rdfs.co/bevon/container/15lBeerKeg</seealso>
    let ``container/15lBeerKeg`` =
        Prefixed_Name(bevon, "container/15lBeerKeg") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/30lBeerKeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:BeerKeg</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/30lBeerKeg">http://rdfs.co/bevon/container/30lBeerKeg</seealso>
    let ``container/30lBeerKeg`` =
        Prefixed_Name(bevon, "container/30lBeerKeg") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/330mlBeverageCan</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:BeverageCan</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/330mlBeverageCan">http://rdfs.co/bevon/container/330mlBeverageCan</seealso>
    let ``container/330mlBeverageCan`` =
        Prefixed_Name(bevon, "container/330mlBeverageCan") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Kilkenny</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:IrishRedAle</para>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Kilkenny">http://rdfs.co/bevon/beverage/Kilkenny</seealso>
    let ``beverage/Kilkenny`` =
        Prefixed_Name(bevon, "beverage/Kilkenny") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Smithwicks</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:IrishRedAle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Smithwicks">http://rdfs.co/bevon/beverage/Smithwicks</seealso>
    let ``beverage/Smithwicks`` =
        Prefixed_Name(bevon, "beverage/Smithwicks") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/KozelDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:Dunkel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/KozelDark">http://rdfs.co/bevon/beverage/KozelDark</seealso>
    let ``beverage/KozelDark`` =
        Prefixed_Name(bevon, "beverage/KozelDark") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/500mlLongneck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bevon:Longneck</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/500mlLongneck">http://rdfs.co/bevon/container/500mlLongneck</seealso>
    let ``container/500mlLongneck`` =
        Prefixed_Name(bevon, "container/500mlLongneck") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/Tsingtao</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:Pilsner</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gr:ProductOrServiceModel</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/Tsingtao">http://rdfs.co/bevon/beverage/Tsingtao</seealso>
    let ``beverage/Tsingtao`` =
        Prefixed_Name(bevon, "beverage/Tsingtao") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/640mlLongneck</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:Longneck</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/640mlLongneck">http://rdfs.co/bevon/container/640mlLongneck</seealso>
    let ``container/640mlLongneck`` =
        Prefixed_Name(bevon, "container/640mlLongneck") |> PrefixedName

    /// <summary>
    ///   <para>bevon:beverage/WhiskyAndSoda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gr:ProductOrServiceModel</para>
    ///   <para>bevon:Highball</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/beverage/WhiskyAndSoda">http://rdfs.co/bevon/beverage/WhiskyAndSoda</seealso>
    let ``beverage/WhiskyAndSoda`` =
        Prefixed_Name(bevon, "beverage/WhiskyAndSoda") |> PrefixedName

    /// <summary>
    ///   <para>bevon:food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/food">http://rdfs.co/bevon/food</seealso>
    let food = Prefixed_Name(bevon, "food") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/25lBeerKeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:BeerKeg</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/25lBeerKeg">http://rdfs.co/bevon/container/25lBeerKeg</seealso>
    let ``container/25lBeerKeg`` =
        Prefixed_Name(bevon, "container/25lBeerKeg") |> PrefixedName

    /// <summary>
    ///   <para>bevon:container/50lBeerKeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>bevon:BeerKeg</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container/50lBeerKeg">http://rdfs.co/bevon/container/50lBeerKeg</seealso>
    let ``container/50lBeerKeg`` =
        Prefixed_Name(bevon, "container/50lBeerKeg") |> PrefixedName

    /// <summary>
    ///   <para>bevon:FermentedBeverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/FermentedBeverage">http://rdfs.co/bevon/FermentedBeverage</seealso>
    let FermentedBeverage = Prefixed_Name(bevon, "FermentedBeverage") |> PrefixedName
    /// <summary>
    ///   <para>bevon:BeerBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Dark amber or brown glass greatly reduces UV light from spoiling the beer.
    ///     However, lighter colored bottles are often used for marketing reasons.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/BeerBottle">http://rdfs.co/bevon/BeerBottle</seealso>
    let BeerBottle = Prefixed_Name(bevon, "BeerBottle") |> PrefixedName
    /// <summary>
    ///   <para>bevon:NonAlcoholicBeer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/NonAlcoholicBeer">http://rdfs.co/bevon/NonAlcoholicBeer</seealso>
    let NonAlcoholicBeer = Prefixed_Name(bevon, "NonAlcoholicBeer") |> PrefixedName
    /// <summary>
    ///   <para>bevon:GlassBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Glass bottles can vary in size considerably, but are most commonly found in
    ///     sizes ranging between about 10ml and 5 litres.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/GlassBottle">http://rdfs.co/bevon/GlassBottle</seealso>
    let GlassBottle = Prefixed_Name(bevon, "GlassBottle") |> PrefixedName
    /// <summary>
    ///   <para>bevon:BeerCocktail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/BeerCocktail">http://rdfs.co/bevon/BeerCocktail</seealso>
    let BeerCocktail = Prefixed_Name(bevon, "BeerCocktail") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Pilsner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     It took its name from the city of Pilsen (Plzeň, Bohemia, Czech Republic,
    ///     where it was first produced in 1842).
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Pilsner">http://rdfs.co/bevon/Pilsner</seealso>
    let Pilsner = Prefixed_Name(bevon, "Pilsner") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Cocktail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Cocktails were originally a mixture of spirits, sugar, water, and bitters.
    ///     It is now often used for almost any mixed drink that contains alcohol,
    ///     including mixers, mixed shots, etc. A cocktail today usually contains one
    ///     or more kinds of spirit and one or more mixers, such as soda or fruit
    ///     juice. Additional ingredients may be sugar, honey, milk, cream, and various
    ///     herbs.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Cocktail">http://rdfs.co/bevon/Cocktail</seealso>
    let Cocktail = Prefixed_Name(bevon, "Cocktail") |> PrefixedName
    /// <summary>
    ///   <para>bevon:PaleLager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/PaleLager">http://rdfs.co/bevon/PaleLager</seealso>
    let PaleLager = Prefixed_Name(bevon, "PaleLager") |> PrefixedName
    /// <summary>
    ///   <para>bevon:BeerKeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/BeerKeg">http://rdfs.co/bevon/BeerKeg</seealso>
    let BeerKeg = Prefixed_Name(bevon, "BeerKeg") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Porter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The name came about as a result of its popularity with street and river
    ///     porters.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Porter">http://rdfs.co/bevon/Porter</seealso>
    let Porter = Prefixed_Name(bevon, "Porter") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Lager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Lager">http://rdfs.co/bevon/Lager</seealso>
    let Lager = Prefixed_Name(bevon, "Lager") |> PrefixedName
    /// <summary>
    ///   <para>bevon:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/material">http://rdfs.co/bevon/material</seealso>
    let material = Prefixed_Name(bevon, "material") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Brewery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A company that makes beer is called either a brewery or a brewing company.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Brewery">http://rdfs.co/bevon/Brewery</seealso>
    let Brewery = Prefixed_Name(bevon, "Brewery") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Longneck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     It is known as the standard longneck bottle or industry standard bottle
    ///     (ISB). The ISB longnecks have a uniform capacity, height, weight and
    ///     diameter and can be reused on average 16 times. The long neck offers a long
    ///     cushion of air to absorb the pressure of carbonation to reduce the risk of
    ///     exploding. The longneck also provides a handle for drinking directly from
    ///     the bottle without transferring body heat to the beer from one's hand.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Longneck">http://rdfs.co/bevon/Longneck</seealso>
    let Longneck = Prefixed_Name(bevon, "Longneck") |> PrefixedName
    /// <summary>
    ///   <para>bevon:ibu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/ibu">http://rdfs.co/bevon/ibu</seealso>
    let ibu = Prefixed_Name(bevon, "ibu") |> PrefixedName
    /// <summary>
    ///   <para>bevon:IrishRedAle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/IrishRedAle">http://rdfs.co/bevon/IrishRedAle</seealso>
    let IrishRedAle = Prefixed_Name(bevon, "IrishRedAle") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Stout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Stouts were traditionally the generic term for the strongest or stoutest
    ///     porters, typically 7% or 8%, produced by a brewery.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Stout">http://rdfs.co/bevon/Stout</seealso>
    let Stout = Prefixed_Name(bevon, "Stout") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Container">http://rdfs.co/bevon/Container</seealso>
    let Container = Prefixed_Name(bevon, "Container") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Brandy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Brandy generally contains 35–60% alcohol by volume (70–120 US proof) and is
    ///     typically taken as an after-dinner drink. Some brandies are aged in wooden
    ///     casks, some are colored with caramel coloring to imitate the effect of
    ///     aging, and some brandies are produced using a combination of both aging and
    ///     coloring.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Brandy">http://rdfs.co/bevon/Brandy</seealso>
    let Brandy = Prefixed_Name(bevon, "Brandy") |> PrefixedName
    /// <summary>
    ///   <para>bevon:CanadianWhisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Most Canadian whiskies are blended multi-grain liquors containing a large
    ///     percentage of corn spirits, and are typically lighter and smoother than
    ///     other whisky styles.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/CanadianWhisky">http://rdfs.co/bevon/CanadianWhisky</seealso>
    let CanadianWhisky = Prefixed_Name(bevon, "CanadianWhisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:CarbonatedWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/CarbonatedWater">http://rdfs.co/bevon/CarbonatedWater</seealso>
    let CarbonatedWater = Prefixed_Name(bevon, "CarbonatedWater") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Water">http://rdfs.co/bevon/Water</seealso>
    let Water = Prefixed_Name(bevon, "Water") |> PrefixedName
    /// <summary>
    ///   <para>bevon:MixedDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Some mixed drinks are alcoholic beverages that contain liquor; others are
    ///     non-alcoholic.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/MixedDrink">http://rdfs.co/bevon/MixedDrink</seealso>
    let MixedDrink = Prefixed_Name(bevon, "MixedDrink") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Mocktail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Mocktail">http://rdfs.co/bevon/Mocktail</seealso>
    let Mocktail = Prefixed_Name(bevon, "Mocktail") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Shandy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The proportions of the two ingredients are adjusted to taste, usually
    ///     half-and-half.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Shandy">http://rdfs.co/bevon/Shandy</seealso>
    let Shandy = Prefixed_Name(bevon, "Shandy") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Cognac</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     It is produced in the wine-growing region surrounding the town from which
    ///     it takes its name, in the French Departements of Charente and
    ///     Charente-Maritime.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Cognac">http://rdfs.co/bevon/Cognac</seealso>
    let Cognac = Prefixed_Name(bevon, "Cognac") |> PrefixedName
    /// <summary>
    ///   <para>bevon:PlasticBottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Plastic bottles are typically used to store liquids such as water, soft
    ///     drinks, motor oil, cooking oil, medicine, shampoo, milk, and ink.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/PlasticBottle">http://rdfs.co/bevon/PlasticBottle</seealso>
    let PlasticBottle = Prefixed_Name(bevon, "PlasticBottle") |> PrefixedName
    /// <summary>
    ///   <para>bevon:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/volume">http://rdfs.co/bevon/volume</seealso>
    let volume = Prefixed_Name(bevon, "volume") |> PrefixedName
    /// <summary>
    ///   <para>bevon:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/name">http://rdfs.co/bevon/name</seealso>
    let name = Prefixed_Name(bevon, "name") |> PrefixedName
    /// <summary>
    ///   <para>bevon:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/manufacturer">http://rdfs.co/bevon/manufacturer</seealso>
    let manufacturer = Prefixed_Name(bevon, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>bevon:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/color">http://rdfs.co/bevon/color</seealso>
    let color = Prefixed_Name(bevon, "color") |> PrefixedName
    /// <summary>
    ///   <para>bevon:launch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/launch">http://rdfs.co/bevon/launch</seealso>
    let launch = Prefixed_Name(bevon, "launch") |> PrefixedName
    /// <summary>
    ///   <para>bevon:proof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     The term was originally used in the United Kingdom and was defined as 7/4
    ///     times the alcohol by volume (ABV). The UK now uses the ABV standard instead
    ///     of alcohol proof. In the United States, alcoholic proof is defined as twice
    ///     the percentage of ABV.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/proof">http://rdfs.co/bevon/proof</seealso>
    let proof = Prefixed_Name(bevon, "proof") |> PrefixedName
    /// <summary>
    ///   <para>bevon:container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/container">http://rdfs.co/bevon/container</seealso>
    let container = Prefixed_Name(bevon, "container") |> PrefixedName
    /// <summary>
    ///   <para>bevon:aging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/aging">http://rdfs.co/bevon/aging</seealso>
    let aging = Prefixed_Name(bevon, "aging") |> PrefixedName
    /// <summary>
    ///   <para>bevon:DilutedSoju</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/DilutedSoju">http://rdfs.co/bevon/DilutedSoju</seealso>
    let DilutedSoju = Prefixed_Name(bevon, "DilutedSoju") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Soju</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Its taste is comparable to vodka, though often slightly sweeter due to
    ///     sugars added in the manufacturing process.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Soju">http://rdfs.co/bevon/Soju</seealso>
    let Soju = Prefixed_Name(bevon, "Soju") |> PrefixedName
    /// <summary>
    ///   <para>bevon:DistilledSoju</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/DistilledSoju">http://rdfs.co/bevon/DistilledSoju</seealso>
    let DistilledSoju = Prefixed_Name(bevon, "DistilledSoju") |> PrefixedName
    /// <summary>
    ///   <para>bevon:FruitWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     This definition is sometimes broadened to include any fermented alcoholic
    ///     beverage except beer. For historical reasons, mead, cider, and perry are
    ///     also excluded from the definition of fruit wine.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/FruitWine">http://rdfs.co/bevon/FruitWine</seealso>
    let FruitWine = Prefixed_Name(bevon, "FruitWine") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Wine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Wine">http://rdfs.co/bevon/Wine</seealso>
    let Wine = Prefixed_Name(bevon, "Wine") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Gin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Gin">http://rdfs.co/bevon/Gin</seealso>
    let Gin = Prefixed_Name(bevon, "Gin") |> PrefixedName
    /// <summary>
    ///   <para>bevon:IrishWhiskey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Key regulations defining Irish whiskey and its production are established
    ///     by the Irish Whiskey Act of 1980.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/IrishWhiskey">http://rdfs.co/bevon/IrishWhiskey</seealso>
    let IrishWhiskey = Prefixed_Name(bevon, "IrishWhiskey") |> PrefixedName
    /// <summary>
    ///   <para>bevon:JapaneseWhisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Whisky production in Japan began around 1870, but the first commercial
    ///     production was in 1924 upon the opening of the country's first distillery,
    ///     Yamazaki. Broadly speaking the style of Japanese whisky is more similar to
    ///     that of Scotch whisky than Irish, American, or Canadian styles of whisky,
    ///     and thus the spelling typically follows the Scottish convention (omitting
    ///     the letter "e").
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/JapaneseWhisky">http://rdfs.co/bevon/JapaneseWhisky</seealso>
    let JapaneseWhisky = Prefixed_Name(bevon, "JapaneseWhisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Liqueur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Liqueurs are typically quite sweet; they are usually not aged for long
    ///     after the ingredients are mixed, but may have resting periods during their
    ///     production to allow flavors to marry.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Liqueur">http://rdfs.co/bevon/Liqueur</seealso>
    let Liqueur = Prefixed_Name(bevon, "Liqueur") |> PrefixedName
    /// <summary>
    ///   <para>bevon:MaltWhisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/MaltWhisky">http://rdfs.co/bevon/MaltWhisky</seealso>
    let MaltWhisky = Prefixed_Name(bevon, "MaltWhisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:MineralWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Mineral water may be sparkling due to contained gases.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/MineralWater">http://rdfs.co/bevon/MineralWater</seealso>
    let MineralWater = Prefixed_Name(bevon, "MineralWater") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Pisco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Pisco">http://rdfs.co/bevon/Pisco</seealso>
    let Pisco = Prefixed_Name(bevon, "Pisco") |> PrefixedName
    /// <summary>
    ///   <para>bevon:RedWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The actual colour of the wine can range from intense violet, typical of
    ///     young wines, through to brick red for mature wines and brown for older red
    ///     wines.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/RedWine">http://rdfs.co/bevon/RedWine</seealso>
    let RedWine = Prefixed_Name(bevon, "RedWine") |> PrefixedName
    /// <summary>
    ///   <para>bevon:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/related">http://rdfs.co/bevon/related</seealso>
    let related = Prefixed_Name(bevon, "related") |> PrefixedName
    /// <summary>
    ///   <para>bevon:similar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/similar">http://rdfs.co/bevon/similar</seealso>
    let similar = Prefixed_Name(bevon, "similar") |> PrefixedName
    /// <summary>
    ///   <para>bevon:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/variant">http://rdfs.co/bevon/variant</seealso>
    let variant = Prefixed_Name(bevon, "variant") |> PrefixedName
    /// <summary>
    ///   <para>bevon:variantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/variantOf">http://rdfs.co/bevon/variantOf</seealso>
    let variantOf = Prefixed_Name(bevon, "variantOf") |> PrefixedName

    /// <summary>
    ///   <para>bevon:non_alcoholic_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/non_alcoholic_version">http://rdfs.co/bevon/non_alcoholic_version</seealso>
    let non_alcoholic_version =
        Prefixed_Name(bevon, "non_alcoholic_version") |> PrefixedName

    /// <summary>
    ///   <para>bevon:Rum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The distillate, a clear liquid, is then usually aged in
    ///     oak barrels.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Rum">http://rdfs.co/bevon/Rum</seealso>
    let Rum = Prefixed_Name(bevon, "Rum") |> PrefixedName
    /// <summary>
    ///   <para>bevon:srm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/srm">http://rdfs.co/bevon/srm</seealso>
    let srm = Prefixed_Name(bevon, "srm") |> PrefixedName
    /// <summary>
    ///   <para>bevon:PaleAle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     It is one of the world's major beer styles.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/PaleAle">http://rdfs.co/bevon/PaleAle</seealso>
    let PaleAle = Prefixed_Name(bevon, "PaleAle") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Dunkel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Dunkel is the German word meaning dark, and dunkel beers typically range in
    ///     color from amber to dark reddish brown. They are characterized by their
    ///     smooth malty flavor.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Dunkel">http://rdfs.co/bevon/Dunkel</seealso>
    let Dunkel = Prefixed_Name(bevon, "Dunkel") |> PrefixedName
    /// <summary>
    ///   <para>bevon:Keg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/Keg">http://rdfs.co/bevon/Keg</seealso>
    let Keg = Prefixed_Name(bevon, "Keg") |> PrefixedName
    /// <summary>
    ///   <para>bevon:BeverageCan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Beverage cans are made of aluminium (75% of worldwide production) or
    ///     tin-plated steel (25% worldwide production).
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/BeverageCan">http://rdfs.co/bevon/BeverageCan</seealso>
    let BeverageCan = Prefixed_Name(bevon, "BeverageCan") |> PrefixedName
    /// <summary>
    ///   <para>bevon:BourbonWhiskey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     The name of the spirit derives from its historical association with an area
    ///     known as Old Bourbon, around what is now Bourbon County, Kentucky (which,
    ///     in turn, was named after the French House of Bourbon royal family). It has
    ///     been produced since the 18th century. While it may be made anywhere in the
    ///     United States, it is strongly associated with the American South in
    ///     general, and Kentucky in particular.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/BourbonWhiskey">http://rdfs.co/bevon/BourbonWhiskey</seealso>
    let BourbonWhiskey = Prefixed_Name(bevon, "BourbonWhiskey") |> PrefixedName
    /// <summary>
    ///   <para>bevon:AmericanWhisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/bevon/AmericanWhisky">http://rdfs.co/bevon/AmericanWhisky</seealso>
    let AmericanWhisky = Prefixed_Name(bevon, "AmericanWhisky") |> PrefixedName
    /// <summary>
    ///   <para>bevon:DistilledBeverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///      This excludes undistilled fermented beverages such as beer, wine, and
    ///      cider.
    ///      </para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/bevon/DistilledBeverage">http://rdfs.co/bevon/DistilledBeverage</seealso>
    let DistilledBeverage = Prefixed_Name(bevon, "DistilledBeverage") |> PrefixedName
    /// <summary>
    ///   <para>bevon:0.8/ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/bevon/0.8/ttl">http://rdfs.co/bevon/0.8/ttl</seealso>
    let ``_0.8/ttl`` = Prefixed_Name(bevon, "0.8/ttl") |> PrefixedName
