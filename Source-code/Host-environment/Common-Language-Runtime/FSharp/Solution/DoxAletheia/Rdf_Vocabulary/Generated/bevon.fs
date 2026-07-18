namespace http.rdfs.co.bevon.slash

open DoxAletheia.Rdf_Vocabulary

module bevon =
    let _namespace_name = "http://rdfs.co/bevon/"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Distillery"></see>
    /// </summary>
    let Distillery = Namespaced_IRI.parse _namespace_name "Distillery" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/abv"></see>
    /// </summary>
    let abv = Namespaced_IRI.parse _namespace_name "abv" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/distillery"></see>
    /// </summary>
    let distillery = Namespaced_IRI.parse _namespace_name "distillery" |> NamespacedName
    /// <summary>
    ///
    ///     Most of the descriptions given here are from Wikipedia or from the websites
    ///     of the related products.
    ///
    ///
    ///     &lt;div&gt;
    ///       The master version of this vocabulary is maintained in &lt;a
    ///       href="https://github.com/jgkim/bevon"&gt;the GitHub repository&lt;/a&gt; so others
    ///       can contribute edits and improvements.
    ///     &lt;/div&gt;
    ///
    /// <see href="http://rdfs.co/bevon/0.8"></see></summary>
    let ``_0.8`` = Namespaced_IRI.parse _namespace_name "0.8" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.8/rdf"></see>
    /// </summary>
    let ``_0.8/rdf`` = Namespaced_IRI.parse _namespace_name "0.8/rdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.8/html"></see>
    /// </summary>
    let ``_0.8/html`` =
        Namespaced_IRI.parse _namespace_name "0.8/html" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.8/ttl"></see>
    /// </summary>
    let ``_0.8/ttl`` = Namespaced_IRI.parse _namespace_name "0.8/ttl" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.7"></see>
    /// </summary>
    let ``_0.7`` = Namespaced_IRI.parse _namespace_name "0.7" |> NamespacedName
    /// <summary>
    ///
    ///     In addition to the BEVON core terms, there are a number of terms for use
    ///     when describing beverages categorized under Beer.
    ///
    /// <see href="http://rdfs.co/bevon/BeerGroup"></see></summary>
    let BeerGroup = Namespaced_IRI.parse _namespace_name "BeerGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These properties are used for describing relations between beverages.
    ///
    /// <see href="http://rdfs.co/bevon/RelationGroup"></see></summary>
    let RelationGroup =
        Namespaced_IRI.parse _namespace_name "RelationGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties are used to describe beverage containers.
    ///
    /// <see href="http://rdfs.co/bevon/ContainerGroup"></see></summary>
    let ContainerGroup =
        Namespaced_IRI.parse _namespace_name "ContainerGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties form the core of BEVON. They describe
    ///     characteristics of beverages in relatively broad terms.
    ///
    /// <see href="http://rdfs.co/bevon/CoreGroup"></see></summary>
    let CoreGroup = Namespaced_IRI.parse _namespace_name "CoreGroup" |> NamespacedName
    /// <summary>
    ///
    ///     These classes describe types of wines.
    ///
    /// <see href="http://rdfs.co/bevon/WineGroup"></see></summary>
    let WineGroup = Namespaced_IRI.parse _namespace_name "WineGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties are for describing beverages categorized under
    ///     Mixed Drink.
    ///
    /// <see href="http://rdfs.co/bevon/CocktailGroup"></see></summary>
    let CocktailGroup =
        Namespaced_IRI.parse _namespace_name "CocktailGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes describe types of whiskies.
    ///
    /// <see href="http://rdfs.co/bevon/WhiskyGroup"></see></summary>
    let WhiskyGroup =
        Namespaced_IRI.parse _namespace_name "WhiskyGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Aging"></see>
    /// </summary>
    let Aging = Namespaced_IRI.parse _namespace_name "Aging" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/AlcoholicBeverage"></see>
    /// </summary>
    let AlcoholicBeverage =
        Namespaced_IRI.parse _namespace_name "AlcoholicBeverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Beverage"></see>
    /// </summary>
    let Beverage = Namespaced_IRI.parse _namespace_name "Beverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/NonAlcoholicBeverage"></see>
    /// </summary>
    let NonAlcoholicBeverage =
        Namespaced_IRI.parse _namespace_name "NonAlcoholicBeverage" |> NamespacedName

    /// <summary>
    ///
    ///     The yeast will ferment the beer quickly, giving it a sweet, full bodied and
    ///     fruity taste.
    ///
    /// <see href="http://rdfs.co/bevon/Ale"></see></summary>
    let Ale = Namespaced_IRI.parse _namespace_name "Ale" |> NamespacedName
    /// <summary>
    ///
    ///     The starch and saccharification enzymes are often derived from malted
    ///     cereal grains, most commonly malted barley and malted wheat.
    ///
    /// <see href="http://rdfs.co/bevon/Beer"></see></summary>
    let Beer = Namespaced_IRI.parse _namespace_name "Beer" |> NamespacedName

    /// <summary>
    ///
    ///     The production and labeling of American whiskey are governed by Title 27 of
    ///     the U.S. Code of Federal Regulations.
    ///
    /// <see href="http://rdfs.co/bevon/AmericanWhiskey"></see></summary>
    let AmericanWhiskey =
        Namespaced_IRI.parse _namespace_name "AmericanWhiskey" |> NamespacedName

    /// <summary>
    ///
    ///     Different grains are used for different varieties, including barley, malted
    ///     barley, rye, malted rye, wheat, and corn. Whisky is typically aged in
    ///     wooden casks, made generally of charred white oak.
    ///
    /// <see href="http://rdfs.co/bevon/Whisky"></see></summary>
    let Whisky = Namespaced_IRI.parse _namespace_name "Whisky" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/FermentedBeverage"></see>
    /// </summary>
    let FermentedBeverage =
        Namespaced_IRI.parse _namespace_name "FermentedBeverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/NonAlcoholicBeer"></see>
    /// </summary>
    let NonAlcoholicBeer =
        Namespaced_IRI.parse _namespace_name "NonAlcoholicBeer" |> NamespacedName

    /// <summary>
    ///
    ///     Dark amber or brown glass greatly reduces UV light from spoiling the beer.
    ///     However, lighter colored bottles are often used for marketing reasons.
    ///
    /// <see href="http://rdfs.co/bevon/BeerBottle"></see></summary>
    let BeerBottle = Namespaced_IRI.parse _namespace_name "BeerBottle" |> NamespacedName

    /// <summary>
    ///
    ///     Glass bottles can vary in size considerably, but are most commonly found in
    ///     sizes ranging between about 10ml and 5 litres.
    ///
    /// <see href="http://rdfs.co/bevon/GlassBottle"></see></summary>
    let GlassBottle =
        Namespaced_IRI.parse _namespace_name "GlassBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/BeerCocktail"></see>
    /// </summary>
    let BeerCocktail =
        Namespaced_IRI.parse _namespace_name "BeerCocktail" |> NamespacedName

    /// <summary>
    ///
    ///     Cocktails were originally a mixture of spirits, sugar, water, and bitters.
    ///     It is now often used for almost any mixed drink that contains alcohol,
    ///     including mixers, mixed shots, etc. A cocktail today usually contains one
    ///     or more kinds of spirit and one or more mixers, such as soda or fruit
    ///     juice. Additional ingredients may be sugar, honey, milk, cream, and various
    ///     herbs.
    ///
    /// <see href="http://rdfs.co/bevon/Cocktail"></see></summary>
    let Cocktail = Namespaced_IRI.parse _namespace_name "Cocktail" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/PaleLager"></see>
    /// </summary>
    let PaleLager = Namespaced_IRI.parse _namespace_name "PaleLager" |> NamespacedName
    /// <summary>
    ///
    ///     It took its name from the city of Pilsen (Plzeň, Bohemia, Czech Republic,
    ///     where it was first produced in 1842).
    ///
    /// <see href="http://rdfs.co/bevon/Pilsner"></see></summary>
    let Pilsner = Namespaced_IRI.parse _namespace_name "Pilsner" |> NamespacedName
    /// <summary>
    ///
    ///     A company that makes beer is called either a brewery or a brewing company.
    ///
    /// <see href="http://rdfs.co/bevon/Brewery"></see></summary>
    let Brewery = Namespaced_IRI.parse _namespace_name "Brewery" |> NamespacedName
    /// <summary>
    ///
    ///     It is known as the standard longneck bottle or industry standard bottle
    ///     (ISB). The ISB longnecks have a uniform capacity, height, weight and
    ///     diameter and can be reused on average 16 times. The long neck offers a long
    ///     cushion of air to absorb the pressure of carbonation to reduce the risk of
    ///     exploding. The longneck also provides a handle for drinking directly from
    ///     the bottle without transferring body heat to the beer from one's hand.
    ///
    /// <see href="http://rdfs.co/bevon/Longneck"></see></summary>
    let Longneck = Namespaced_IRI.parse _namespace_name "Longneck" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/BeerKeg"></see>
    /// </summary>
    let BeerKeg = Namespaced_IRI.parse _namespace_name "BeerKeg" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/ibu"></see>
    /// </summary>
    let ibu = Namespaced_IRI.parse _namespace_name "ibu" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/srm"></see>
    /// </summary>
    let srm = Namespaced_IRI.parse _namespace_name "srm" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/brewery"></see>
    /// </summary>
    let brewery = Namespaced_IRI.parse _namespace_name "brewery" |> NamespacedName
    /// <summary>
    ///
    ///     It is one of the world's major beer styles.
    ///
    /// <see href="http://rdfs.co/bevon/PaleAle"></see></summary>
    let PaleAle = Namespaced_IRI.parse _namespace_name "PaleAle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/IrishRedAle"></see>
    /// </summary>
    let IrishRedAle =
        Namespaced_IRI.parse _namespace_name "IrishRedAle" |> NamespacedName

    /// <summary>
    ///
    ///     The name came about as a result of its popularity with street and river
    ///     porters.
    ///
    /// <see href="http://rdfs.co/bevon/Porter"></see></summary>
    let Porter = Namespaced_IRI.parse _namespace_name "Porter" |> NamespacedName
    /// <summary>
    ///
    ///     Stouts were traditionally the generic term for the strongest or stoutest
    ///     porters, typically 7% or 8%, produced by a brewery.
    ///
    /// <see href="http://rdfs.co/bevon/Stout"></see></summary>
    let Stout = Namespaced_IRI.parse _namespace_name "Stout" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/DryStout"></see>
    /// </summary>
    let DryStout = Namespaced_IRI.parse _namespace_name "DryStout" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Lager"></see>
    /// </summary>
    let Lager = Namespaced_IRI.parse _namespace_name "Lager" |> NamespacedName
    /// <summary>
    ///
    ///     Dunkel is the German word meaning dark, and dunkel beers typically range in
    ///     color from amber to dark reddish brown. They are characterized by their
    ///     smooth malty flavor.
    ///
    /// <see href="http://rdfs.co/bevon/Dunkel"></see></summary>
    let Dunkel = Namespaced_IRI.parse _namespace_name "Dunkel" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Keg"></see>
    /// </summary>
    let Keg = Namespaced_IRI.parse _namespace_name "Keg" |> NamespacedName

    /// <summary>
    ///
    ///     Beverage cans are made of aluminium (75% of worldwide production) or
    ///     tin-plated steel (25% worldwide production).
    ///
    /// <see href="http://rdfs.co/bevon/BeverageCan"></see></summary>
    let BeverageCan =
        Namespaced_IRI.parse _namespace_name "BeverageCan" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Container"></see>
    /// </summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName

    /// <summary>
    ///
    ///     The name of the spirit derives from its historical association with an area
    ///     known as Old Bourbon, around what is now Bourbon County, Kentucky (which,
    ///     in turn, was named after the French House of Bourbon royal family). It has
    ///     been produced since the 18th century. While it may be made anywhere in the
    ///     United States, it is strongly associated with the American South in
    ///     general, and Kentucky in particular.
    ///
    /// <see href="http://rdfs.co/bevon/BourbonWhiskey"></see></summary>
    let BourbonWhiskey =
        Namespaced_IRI.parse _namespace_name "BourbonWhiskey" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/AmericanWhisky"></see>
    /// </summary>
    let AmericanWhisky =
        Namespaced_IRI.parse _namespace_name "AmericanWhisky" |> NamespacedName

    /// <summary>
    ///
    ///     Brandy generally contains 35–60% alcohol by volume (70–120 US proof) and is
    ///     typically taken as an after-dinner drink. Some brandies are aged in wooden
    ///     casks, some are colored with caramel coloring to imitate the effect of
    ///     aging, and some brandies are produced using a combination of both aging and
    ///     coloring.
    ///
    /// <see href="http://rdfs.co/bevon/Brandy"></see></summary>
    let Brandy = Namespaced_IRI.parse _namespace_name "Brandy" |> NamespacedName

    /// <summary>
    ///
    ///      This excludes undistilled fermented beverages such as beer, wine, and
    ///      cider.
    ///
    /// <see href="http://rdfs.co/bevon/DistilledBeverage"></see></summary>
    let DistilledBeverage =
        Namespaced_IRI.parse _namespace_name "DistilledBeverage" |> NamespacedName

    /// <summary>
    ///
    ///     Most Canadian whiskies are blended multi-grain liquors containing a large
    ///     percentage of corn spirits, and are typically lighter and smoother than
    ///     other whisky styles.
    ///
    /// <see href="http://rdfs.co/bevon/CanadianWhisky"></see></summary>
    let CanadianWhisky =
        Namespaced_IRI.parse _namespace_name "CanadianWhisky" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/CarbonatedWater"></see>
    /// </summary>
    let CarbonatedWater =
        Namespaced_IRI.parse _namespace_name "CarbonatedWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Water"></see>
    /// </summary>
    let Water = Namespaced_IRI.parse _namespace_name "Water" |> NamespacedName
    /// <summary>
    ///
    ///     Some mixed drinks are alcoholic beverages that contain liquor; others are
    ///     non-alcoholic.
    ///
    /// <see href="http://rdfs.co/bevon/MixedDrink"></see></summary>
    let MixedDrink = Namespaced_IRI.parse _namespace_name "MixedDrink" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Mocktail"></see>
    /// </summary>
    let Mocktail = Namespaced_IRI.parse _namespace_name "Mocktail" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Highball"></see>
    /// </summary>
    let Highball = Namespaced_IRI.parse _namespace_name "Highball" |> NamespacedName
    /// <summary>
    ///
    ///     The proportions of the two ingredients are adjusted to taste, usually
    ///     half-and-half.
    ///
    /// <see href="http://rdfs.co/bevon/Shandy"></see></summary>
    let Shandy = Namespaced_IRI.parse _namespace_name "Shandy" |> NamespacedName
    /// <summary>
    ///
    ///     It is produced in the wine-growing region surrounding the town from which
    ///     it takes its name, in the French Departements of Charente and
    ///     Charente-Maritime.
    ///
    /// <see href="http://rdfs.co/bevon/Cognac"></see></summary>
    let Cognac = Namespaced_IRI.parse _namespace_name "Cognac" |> NamespacedName

    /// <summary>
    ///
    ///     Plastic bottles are typically used to store liquids such as water, soft
    ///     drinks, motor oil, cooking oil, medicine, shampoo, milk, and ink.
    ///
    /// <see href="http://rdfs.co/bevon/PlasticBottle"></see></summary>
    let PlasticBottle =
        Namespaced_IRI.parse _namespace_name "PlasticBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/volume"></see>
    /// </summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/origin"></see>
    /// </summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/manufacturer"></see>
    /// </summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/color"></see>
    /// </summary>
    let color = Namespaced_IRI.parse _namespace_name "color" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/launch"></see>
    /// </summary>
    let launch = Namespaced_IRI.parse _namespace_name "launch" |> NamespacedName
    /// <summary>
    ///
    ///     The term was originally used in the United Kingdom and was defined as 7/4
    ///     times the alcohol by volume (ABV). The UK now uses the ABV standard instead
    ///     of alcohol proof. In the United States, alcoholic proof is defined as twice
    ///     the percentage of ABV.
    ///
    /// <see href="http://rdfs.co/bevon/proof"></see></summary>
    let proof = Namespaced_IRI.parse _namespace_name "proof" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container"></see>
    /// </summary>
    let container = Namespaced_IRI.parse _namespace_name "container" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/aging"></see>
    /// </summary>
    let aging = Namespaced_IRI.parse _namespace_name "aging" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/fermentation_base"></see>
    /// </summary>
    let fermentation_base =
        Namespaced_IRI.parse _namespace_name "fermentation_base" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/ingredient"></see>
    /// </summary>
    let ingredient = Namespaced_IRI.parse _namespace_name "ingredient" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/FermentationBase"></see>
    /// </summary>
    let FermentationBase =
        Namespaced_IRI.parse _namespace_name "FermentationBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/DilutedSoju"></see>
    /// </summary>
    let DilutedSoju =
        Namespaced_IRI.parse _namespace_name "DilutedSoju" |> NamespacedName

    /// <summary>
    ///
    ///     Its taste is comparable to vodka, though often slightly sweeter due to
    ///     sugars added in the manufacturing process.
    ///
    /// <see href="http://rdfs.co/bevon/Soju"></see></summary>
    let Soju = Namespaced_IRI.parse _namespace_name "Soju" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/DistilledSoju"></see>
    /// </summary>
    let DistilledSoju =
        Namespaced_IRI.parse _namespace_name "DistilledSoju" |> NamespacedName

    /// <summary>
    ///
    ///     This definition is sometimes broadened to include any fermented alcoholic
    ///     beverage except beer. For historical reasons, mead, cider, and perry are
    ///     also excluded from the definition of fruit wine.
    ///
    /// <see href="http://rdfs.co/bevon/FruitWine"></see></summary>
    let FruitWine = Namespaced_IRI.parse _namespace_name "FruitWine" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Wine"></see>
    /// </summary>
    let Wine = Namespaced_IRI.parse _namespace_name "Wine" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Gin"></see>
    /// </summary>
    let Gin = Namespaced_IRI.parse _namespace_name "Gin" |> NamespacedName

    /// <summary>
    ///
    ///     Key regulations defining Irish whiskey and its production are established
    ///     by the Irish Whiskey Act of 1980.
    ///
    /// <see href="http://rdfs.co/bevon/IrishWhiskey"></see></summary>
    let IrishWhiskey =
        Namespaced_IRI.parse _namespace_name "IrishWhiskey" |> NamespacedName

    /// <summary>
    ///
    ///     Whisky production in Japan began around 1870, but the first commercial
    ///     production was in 1924 upon the opening of the country's first distillery,
    ///     Yamazaki. Broadly speaking the style of Japanese whisky is more similar to
    ///     that of Scotch whisky than Irish, American, or Canadian styles of whisky,
    ///     and thus the spelling typically follows the Scottish convention (omitting
    ///     the letter "e").
    ///
    /// <see href="http://rdfs.co/bevon/JapaneseWhisky"></see></summary>
    let JapaneseWhisky =
        Namespaced_IRI.parse _namespace_name "JapaneseWhisky" |> NamespacedName

    /// <summary>
    ///
    ///     Liqueurs are typically quite sweet; they are usually not aged for long
    ///     after the ingredients are mixed, but may have resting periods during their
    ///     production to allow flavors to marry.
    ///
    /// <see href="http://rdfs.co/bevon/Liqueur"></see></summary>
    let Liqueur = Namespaced_IRI.parse _namespace_name "Liqueur" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/MaltWhisky"></see>
    /// </summary>
    let MaltWhisky = Namespaced_IRI.parse _namespace_name "MaltWhisky" |> NamespacedName

    /// <summary>
    ///
    ///     Mineral water may be sparkling due to contained gases.
    ///
    /// <see href="http://rdfs.co/bevon/MineralWater"></see></summary>
    let MineralWater =
        Namespaced_IRI.parse _namespace_name "MineralWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Pisco"></see>
    /// </summary>
    let Pisco = Namespaced_IRI.parse _namespace_name "Pisco" |> NamespacedName
    /// <summary>
    ///
    ///     The actual colour of the wine can range from intense violet, typical of
    ///     young wines, through to brick red for mature wines and brown for older red
    ///     wines.
    ///
    /// <see href="http://rdfs.co/bevon/RedWine"></see></summary>
    let RedWine = Namespaced_IRI.parse _namespace_name "RedWine" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/related"></see>
    /// </summary>
    let related = Namespaced_IRI.parse _namespace_name "related" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/similar"></see>
    /// </summary>
    let similar = Namespaced_IRI.parse _namespace_name "similar" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/variant"></see>
    /// </summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/variantOf"></see>
    /// </summary>
    let variantOf = Namespaced_IRI.parse _namespace_name "variantOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/non_alcoholic_version"></see>
    /// </summary>
    let non_alcoholic_version =
        Namespaced_IRI.parse _namespace_name "non_alcoholic_version" |> NamespacedName

    /// <summary>
    ///
    ///     The distillate, a clear liquid, is then usually aged in
    ///     oak barrels.
    ///
    /// <see href="http://rdfs.co/bevon/Rum"></see></summary>
    let Rum = Namespaced_IRI.parse _namespace_name "Rum" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Sake"></see>
    /// </summary>
    let Sake = Namespaced_IRI.parse _namespace_name "Sake" |> NamespacedName

    /// <summary>
    ///
    ///     All Scotch whisky was originally made from malt barley. Commercial
    ///     distilleries began introducing whisky made from wheat and rye in the late
    ///     eighteenth century.
    ///
    /// <see href="http://rdfs.co/bevon/ScotchWhisky"></see></summary>
    let ScotchWhisky =
        Namespaced_IRI.parse _namespace_name "ScotchWhisky" |> NamespacedName

    /// <summary>
    ///
    ///     As with any Scotch whisky, a single malt Scotch must be distilled in
    ///     Scotland and matured in oak casks in Scotland for at least three years
    ///     (most single malts are matured longer).
    ///
    /// <see href="http://rdfs.co/bevon/SingleMaltScotch"></see></summary>
    let SingleMaltScotch =
        Namespaced_IRI.parse _namespace_name "SingleMaltScotch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/SingleMaltWhisky"></see>
    /// </summary>
    let SingleMaltWhisky =
        Namespaced_IRI.parse _namespace_name "SingleMaltWhisky" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/SpeysideSingleMalt"></see>
    /// </summary>
    let SpeysideSingleMalt =
        Namespaced_IRI.parse _namespace_name "SpeysideSingleMalt" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Tequila"></see>
    /// </summary>
    let Tequila = Namespaced_IRI.parse _namespace_name "Tequila" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/TequilaBlanco"></see>
    /// </summary>
    let TequilaBlanco =
        Namespaced_IRI.parse _namespace_name "TequilaBlanco" |> NamespacedName

    /// <summary>
    ///
    ///     Vodka is made by the distillation of fermented substances such as grains,
    ///     potatoes, or sometimes fruits or sugar.
    ///
    /// <see href="http://rdfs.co/bevon/Vodka"></see></summary>
    let Vodka = Namespaced_IRI.parse _namespace_name "Vodka" |> NamespacedName
    /// <summary>
    ///
    ///     It is produced by the alcoholic fermentation of the non-coloured pulp of
    ///     grapes which may have a white or black skin. It is treated so as to
    ///     maintain a yellow transparent colour in the final product.
    ///
    /// <see href="http://rdfs.co/bevon/WhiteWine"></see></summary>
    let WhiteWine = Namespaced_IRI.parse _namespace_name "WhiteWine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Budweiser"></see>
    /// </summary>
    let ``beverage/Budweiser`` =
        Namespaced_IRI.parse _namespace_name "beverage/Budweiser" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/330mlLongneck"></see>
    /// </summary>
    let ``container/330mlLongneck`` =
        Namespaced_IRI.parse _namespace_name "container/330mlLongneck" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/500mlBeverageCan"></see>
    /// </summary>
    let ``container/500mlBeverageCan`` =
        Namespaced_IRI.parse _namespace_name "container/500mlBeverageCan" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/355mlBeverageCan"></see>
    /// </summary>
    let ``container/355mlBeverageCan`` =
        Namespaced_IRI.parse _namespace_name "container/355mlBeverageCan" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Chamisul"></see>
    /// </summary>
    let ``beverage/Chamisul`` =
        Namespaced_IRI.parse _namespace_name "beverage/Chamisul" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/1_8lPlasticBottle"></see>
    /// </summary>
    let ``container/1_8lPlasticBottle`` =
        Namespaced_IRI.parse _namespace_name "container/1_8lPlasticBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/640mlPlasticBottle"></see>
    /// </summary>
    let ``container/640mlPlasticBottle`` =
        Namespaced_IRI.parse _namespace_name "container/640mlPlasticBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/200mlPlasticBottle"></see>
    /// </summary>
    let ``container/200mlPlasticBottle`` =
        Namespaced_IRI.parse _namespace_name "container/200mlPlasticBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/360mlGlassBottle"></see>
    /// </summary>
    let ``container/360mlGlassBottle`` =
        Namespaced_IRI.parse _namespace_name "container/360mlGlassBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Chum-Churum"></see>
    /// </summary>
    let ``beverage/Chum-Churum`` =
        Namespaced_IRI.parse _namespace_name "beverage/Chum-Churum" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/360mlPlasticBottle"></see>
    /// </summary>
    let ``container/360mlPlasticBottle`` =
        Namespaced_IRI.parse _namespace_name "container/360mlPlasticBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/DonJulioBlanco"></see>
    /// </summary>
    let ``beverage/DonJulioBlanco`` =
        Namespaced_IRI.parse _namespace_name "beverage/DonJulioBlanco" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/750mlGlassBottle"></see>
    /// </summary>
    let ``container/750mlGlassBottle`` =
        Namespaced_IRI.parse _namespace_name "container/750mlGlassBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Glenfiddich12YearOld"></see>
    /// </summary>
    let ``beverage/Glenfiddich12YearOld`` =
        Namespaced_IRI.parse _namespace_name "beverage/Glenfiddich12YearOld" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/duration"></see>
    /// </summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/previous_content"></see>
    /// </summary>
    let previous_content =
        Namespaced_IRI.parse _namespace_name "previous_content" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/material"></see>
    /// </summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/700mlGlassBottle"></see>
    /// </summary>
    let ``container/700mlGlassBottle`` =
        Namespaced_IRI.parse _namespace_name "container/700mlGlassBottle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Guinness"></see>
    /// </summary>
    let ``beverage/Guinness`` =
        Namespaced_IRI.parse _namespace_name "beverage/Guinness" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/15lBeerKeg"></see>
    /// </summary>
    let ``container/15lBeerKeg`` =
        Namespaced_IRI.parse _namespace_name "container/15lBeerKeg" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/30lBeerKeg"></see>
    /// </summary>
    let ``container/30lBeerKeg`` =
        Namespaced_IRI.parse _namespace_name "container/30lBeerKeg" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/330mlBeverageCan"></see>
    /// </summary>
    let ``container/330mlBeverageCan`` =
        Namespaced_IRI.parse _namespace_name "container/330mlBeverageCan" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Kilkenny"></see>
    /// </summary>
    let ``beverage/Kilkenny`` =
        Namespaced_IRI.parse _namespace_name "beverage/Kilkenny" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/440mlBeverageCan"></see>
    /// </summary>
    let ``container/440mlBeverageCan`` =
        Namespaced_IRI.parse _namespace_name "container/440mlBeverageCan" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Smithwicks"></see>
    /// </summary>
    let ``beverage/Smithwicks`` =
        Namespaced_IRI.parse _namespace_name "beverage/Smithwicks" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/KozelDark"></see>
    /// </summary>
    let ``beverage/KozelDark`` =
        Namespaced_IRI.parse _namespace_name "beverage/KozelDark" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/500mlLongneck"></see>
    /// </summary>
    let ``container/500mlLongneck`` =
        Namespaced_IRI.parse _namespace_name "container/500mlLongneck" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Tsingtao"></see>
    /// </summary>
    let ``beverage/Tsingtao`` =
        Namespaced_IRI.parse _namespace_name "beverage/Tsingtao" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/640mlLongneck"></see>
    /// </summary>
    let ``container/640mlLongneck`` =
        Namespaced_IRI.parse _namespace_name "container/640mlLongneck" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/WhiskyAndSoda"></see>
    /// </summary>
    let ``beverage/WhiskyAndSoda`` =
        Namespaced_IRI.parse _namespace_name "beverage/WhiskyAndSoda" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/food"></see>
    /// </summary>
    let food = Namespaced_IRI.parse _namespace_name "food" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/quantity"></see>
    /// </summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/25lBeerKeg"></see>
    /// </summary>
    let ``container/25lBeerKeg`` =
        Namespaced_IRI.parse _namespace_name "container/25lBeerKeg" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/50lBeerKeg"></see>
    /// </summary>
    let ``container/50lBeerKeg`` =
        Namespaced_IRI.parse _namespace_name "container/50lBeerKeg" |> NamespacedName
