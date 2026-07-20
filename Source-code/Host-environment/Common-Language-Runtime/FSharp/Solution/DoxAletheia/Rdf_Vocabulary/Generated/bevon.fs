namespace http.rdfs.co.bevon.slash

open DoxAletheia

module bevon =
    let _namespace_name = "http://rdfs.co/bevon/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Distillery"></see>
    /// </summary>
    let Distillery = _prefix "Distillery"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/abv"></see>
    /// </summary>
    let abv = _prefix "abv"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/distillery"></see>
    /// </summary>
    let distillery = _prefix "distillery"
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
    let ``_0.8`` = _prefix "0.8"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.8/rdf"></see>
    /// </summary>
    let ``_0.8/rdf`` = _prefix "0.8/rdf"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.8/html"></see>
    /// </summary>
    let ``_0.8/html`` = _prefix "0.8/html"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.8/ttl"></see>
    /// </summary>
    let ``_0.8/ttl`` = _prefix "0.8/ttl"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/0.7"></see>
    /// </summary>
    let ``_0.7`` = _prefix "0.7"
    /// <summary>
    ///
    ///     In addition to the BEVON core terms, there are a number of terms for use
    ///     when describing beverages categorized under Beer.
    ///
    /// <see href="http://rdfs.co/bevon/BeerGroup"></see></summary>
    let BeerGroup = _prefix "BeerGroup"
    /// <summary>
    ///
    ///     These properties are used for describing relations between beverages.
    ///
    /// <see href="http://rdfs.co/bevon/RelationGroup"></see></summary>
    let RelationGroup = _prefix "RelationGroup"
    /// <summary>
    ///
    ///     These classes and properties are used to describe beverage containers.
    ///
    /// <see href="http://rdfs.co/bevon/ContainerGroup"></see></summary>
    let ContainerGroup = _prefix "ContainerGroup"
    /// <summary>
    ///
    ///     These classes and properties form the core of BEVON. They describe
    ///     characteristics of beverages in relatively broad terms.
    ///
    /// <see href="http://rdfs.co/bevon/CoreGroup"></see></summary>
    let CoreGroup = _prefix "CoreGroup"
    /// <summary>
    ///
    ///     These classes describe types of wines.
    ///
    /// <see href="http://rdfs.co/bevon/WineGroup"></see></summary>
    let WineGroup = _prefix "WineGroup"
    /// <summary>
    ///
    ///     These classes and properties are for describing beverages categorized under
    ///     Mixed Drink.
    ///
    /// <see href="http://rdfs.co/bevon/CocktailGroup"></see></summary>
    let CocktailGroup = _prefix "CocktailGroup"
    /// <summary>
    ///
    ///     These classes describe types of whiskies.
    ///
    /// <see href="http://rdfs.co/bevon/WhiskyGroup"></see></summary>
    let WhiskyGroup = _prefix "WhiskyGroup"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Aging"></see>
    /// </summary>
    let Aging = _prefix "Aging"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/AlcoholicBeverage"></see>
    /// </summary>
    let AlcoholicBeverage = _prefix "AlcoholicBeverage"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Beverage"></see>
    /// </summary>
    let Beverage = _prefix "Beverage"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/NonAlcoholicBeverage"></see>
    /// </summary>
    let NonAlcoholicBeverage = _prefix "NonAlcoholicBeverage"
    /// <summary>
    ///
    ///     The yeast will ferment the beer quickly, giving it a sweet, full bodied and
    ///     fruity taste.
    ///
    /// <see href="http://rdfs.co/bevon/Ale"></see></summary>
    let Ale = _prefix "Ale"
    /// <summary>
    ///
    ///     The starch and saccharification enzymes are often derived from malted
    ///     cereal grains, most commonly malted barley and malted wheat.
    ///
    /// <see href="http://rdfs.co/bevon/Beer"></see></summary>
    let Beer = _prefix "Beer"
    /// <summary>
    ///
    ///     The production and labeling of American whiskey are governed by Title 27 of
    ///     the U.S. Code of Federal Regulations.
    ///
    /// <see href="http://rdfs.co/bevon/AmericanWhiskey"></see></summary>
    let AmericanWhiskey = _prefix "AmericanWhiskey"
    /// <summary>
    ///
    ///     Different grains are used for different varieties, including barley, malted
    ///     barley, rye, malted rye, wheat, and corn. Whisky is typically aged in
    ///     wooden casks, made generally of charred white oak.
    ///
    /// <see href="http://rdfs.co/bevon/Whisky"></see></summary>
    let Whisky = _prefix "Whisky"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/FermentedBeverage"></see>
    /// </summary>
    let FermentedBeverage = _prefix "FermentedBeverage"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/NonAlcoholicBeer"></see>
    /// </summary>
    let NonAlcoholicBeer = _prefix "NonAlcoholicBeer"
    /// <summary>
    ///
    ///     Dark amber or brown glass greatly reduces UV light from spoiling the beer.
    ///     However, lighter colored bottles are often used for marketing reasons.
    ///
    /// <see href="http://rdfs.co/bevon/BeerBottle"></see></summary>
    let BeerBottle = _prefix "BeerBottle"
    /// <summary>
    ///
    ///     Glass bottles can vary in size considerably, but are most commonly found in
    ///     sizes ranging between about 10ml and 5 litres.
    ///
    /// <see href="http://rdfs.co/bevon/GlassBottle"></see></summary>
    let GlassBottle = _prefix "GlassBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/BeerCocktail"></see>
    /// </summary>
    let BeerCocktail = _prefix "BeerCocktail"
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
    let Cocktail = _prefix "Cocktail"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/PaleLager"></see>
    /// </summary>
    let PaleLager = _prefix "PaleLager"
    /// <summary>
    ///
    ///     It took its name from the city of Pilsen (Plzeň, Bohemia, Czech Republic,
    ///     where it was first produced in 1842).
    ///
    /// <see href="http://rdfs.co/bevon/Pilsner"></see></summary>
    let Pilsner = _prefix "Pilsner"
    /// <summary>
    ///
    ///     A company that makes beer is called either a brewery or a brewing company.
    ///
    /// <see href="http://rdfs.co/bevon/Brewery"></see></summary>
    let Brewery = _prefix "Brewery"
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
    let Longneck = _prefix "Longneck"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/BeerKeg"></see>
    /// </summary>
    let BeerKeg = _prefix "BeerKeg"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/ibu"></see>
    /// </summary>
    let ibu = _prefix "ibu"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/srm"></see>
    /// </summary>
    let srm = _prefix "srm"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/brewery"></see>
    /// </summary>
    let brewery = _prefix "brewery"
    /// <summary>
    ///
    ///     It is one of the world's major beer styles.
    ///
    /// <see href="http://rdfs.co/bevon/PaleAle"></see></summary>
    let PaleAle = _prefix "PaleAle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/IrishRedAle"></see>
    /// </summary>
    let IrishRedAle = _prefix "IrishRedAle"
    /// <summary>
    ///
    ///     The name came about as a result of its popularity with street and river
    ///     porters.
    ///
    /// <see href="http://rdfs.co/bevon/Porter"></see></summary>
    let Porter = _prefix "Porter"
    /// <summary>
    ///
    ///     Stouts were traditionally the generic term for the strongest or stoutest
    ///     porters, typically 7% or 8%, produced by a brewery.
    ///
    /// <see href="http://rdfs.co/bevon/Stout"></see></summary>
    let Stout = _prefix "Stout"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/DryStout"></see>
    /// </summary>
    let DryStout = _prefix "DryStout"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Lager"></see>
    /// </summary>
    let Lager = _prefix "Lager"
    /// <summary>
    ///
    ///     Dunkel is the German word meaning dark, and dunkel beers typically range in
    ///     color from amber to dark reddish brown. They are characterized by their
    ///     smooth malty flavor.
    ///
    /// <see href="http://rdfs.co/bevon/Dunkel"></see></summary>
    let Dunkel = _prefix "Dunkel"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Keg"></see>
    /// </summary>
    let Keg = _prefix "Keg"
    /// <summary>
    ///
    ///     Beverage cans are made of aluminium (75% of worldwide production) or
    ///     tin-plated steel (25% worldwide production).
    ///
    /// <see href="http://rdfs.co/bevon/BeverageCan"></see></summary>
    let BeverageCan = _prefix "BeverageCan"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Container"></see>
    /// </summary>
    let Container = _prefix "Container"
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
    let BourbonWhiskey = _prefix "BourbonWhiskey"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/AmericanWhisky"></see>
    /// </summary>
    let AmericanWhisky = _prefix "AmericanWhisky"
    /// <summary>
    ///
    ///     Brandy generally contains 35–60% alcohol by volume (70–120 US proof) and is
    ///     typically taken as an after-dinner drink. Some brandies are aged in wooden
    ///     casks, some are colored with caramel coloring to imitate the effect of
    ///     aging, and some brandies are produced using a combination of both aging and
    ///     coloring.
    ///
    /// <see href="http://rdfs.co/bevon/Brandy"></see></summary>
    let Brandy = _prefix "Brandy"
    /// <summary>
    ///
    ///      This excludes undistilled fermented beverages such as beer, wine, and
    ///      cider.
    ///
    /// <see href="http://rdfs.co/bevon/DistilledBeverage"></see></summary>
    let DistilledBeverage = _prefix "DistilledBeverage"
    /// <summary>
    ///
    ///     Most Canadian whiskies are blended multi-grain liquors containing a large
    ///     percentage of corn spirits, and are typically lighter and smoother than
    ///     other whisky styles.
    ///
    /// <see href="http://rdfs.co/bevon/CanadianWhisky"></see></summary>
    let CanadianWhisky = _prefix "CanadianWhisky"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/CarbonatedWater"></see>
    /// </summary>
    let CarbonatedWater = _prefix "CarbonatedWater"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Water"></see>
    /// </summary>
    let Water = _prefix "Water"
    /// <summary>
    ///
    ///     Some mixed drinks are alcoholic beverages that contain liquor; others are
    ///     non-alcoholic.
    ///
    /// <see href="http://rdfs.co/bevon/MixedDrink"></see></summary>
    let MixedDrink = _prefix "MixedDrink"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Mocktail"></see>
    /// </summary>
    let Mocktail = _prefix "Mocktail"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Highball"></see>
    /// </summary>
    let Highball = _prefix "Highball"
    /// <summary>
    ///
    ///     The proportions of the two ingredients are adjusted to taste, usually
    ///     half-and-half.
    ///
    /// <see href="http://rdfs.co/bevon/Shandy"></see></summary>
    let Shandy = _prefix "Shandy"
    /// <summary>
    ///
    ///     It is produced in the wine-growing region surrounding the town from which
    ///     it takes its name, in the French Departements of Charente and
    ///     Charente-Maritime.
    ///
    /// <see href="http://rdfs.co/bevon/Cognac"></see></summary>
    let Cognac = _prefix "Cognac"
    /// <summary>
    ///
    ///     Plastic bottles are typically used to store liquids such as water, soft
    ///     drinks, motor oil, cooking oil, medicine, shampoo, milk, and ink.
    ///
    /// <see href="http://rdfs.co/bevon/PlasticBottle"></see></summary>
    let PlasticBottle = _prefix "PlasticBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/volume"></see>
    /// </summary>
    let volume = _prefix "volume"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/origin"></see>
    /// </summary>
    let origin = _prefix "origin"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/manufacturer"></see>
    /// </summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/color"></see>
    /// </summary>
    let color = _prefix "color"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/launch"></see>
    /// </summary>
    let launch = _prefix "launch"
    /// <summary>
    ///
    ///     The term was originally used in the United Kingdom and was defined as 7/4
    ///     times the alcohol by volume (ABV). The UK now uses the ABV standard instead
    ///     of alcohol proof. In the United States, alcoholic proof is defined as twice
    ///     the percentage of ABV.
    ///
    /// <see href="http://rdfs.co/bevon/proof"></see></summary>
    let proof = _prefix "proof"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container"></see>
    /// </summary>
    let container = _prefix "container"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/aging"></see>
    /// </summary>
    let aging = _prefix "aging"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/fermentation_base"></see>
    /// </summary>
    let fermentation_base = _prefix "fermentation_base"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/ingredient"></see>
    /// </summary>
    let ingredient = _prefix "ingredient"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/FermentationBase"></see>
    /// </summary>
    let FermentationBase = _prefix "FermentationBase"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/DilutedSoju"></see>
    /// </summary>
    let DilutedSoju = _prefix "DilutedSoju"
    /// <summary>
    ///
    ///     Its taste is comparable to vodka, though often slightly sweeter due to
    ///     sugars added in the manufacturing process.
    ///
    /// <see href="http://rdfs.co/bevon/Soju"></see></summary>
    let Soju = _prefix "Soju"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/DistilledSoju"></see>
    /// </summary>
    let DistilledSoju = _prefix "DistilledSoju"
    /// <summary>
    ///
    ///     This definition is sometimes broadened to include any fermented alcoholic
    ///     beverage except beer. For historical reasons, mead, cider, and perry are
    ///     also excluded from the definition of fruit wine.
    ///
    /// <see href="http://rdfs.co/bevon/FruitWine"></see></summary>
    let FruitWine = _prefix "FruitWine"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Wine"></see>
    /// </summary>
    let Wine = _prefix "Wine"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Gin"></see>
    /// </summary>
    let Gin = _prefix "Gin"
    /// <summary>
    ///
    ///     Key regulations defining Irish whiskey and its production are established
    ///     by the Irish Whiskey Act of 1980.
    ///
    /// <see href="http://rdfs.co/bevon/IrishWhiskey"></see></summary>
    let IrishWhiskey = _prefix "IrishWhiskey"
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
    let JapaneseWhisky = _prefix "JapaneseWhisky"
    /// <summary>
    ///
    ///     Liqueurs are typically quite sweet; they are usually not aged for long
    ///     after the ingredients are mixed, but may have resting periods during their
    ///     production to allow flavors to marry.
    ///
    /// <see href="http://rdfs.co/bevon/Liqueur"></see></summary>
    let Liqueur = _prefix "Liqueur"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/MaltWhisky"></see>
    /// </summary>
    let MaltWhisky = _prefix "MaltWhisky"
    /// <summary>
    ///
    ///     Mineral water may be sparkling due to contained gases.
    ///
    /// <see href="http://rdfs.co/bevon/MineralWater"></see></summary>
    let MineralWater = _prefix "MineralWater"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Pisco"></see>
    /// </summary>
    let Pisco = _prefix "Pisco"
    /// <summary>
    ///
    ///     The actual colour of the wine can range from intense violet, typical of
    ///     young wines, through to brick red for mature wines and brown for older red
    ///     wines.
    ///
    /// <see href="http://rdfs.co/bevon/RedWine"></see></summary>
    let RedWine = _prefix "RedWine"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/related"></see>
    /// </summary>
    let related = _prefix "related"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/similar"></see>
    /// </summary>
    let similar = _prefix "similar"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/variant"></see>
    /// </summary>
    let variant = _prefix "variant"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/variantOf"></see>
    /// </summary>
    let variantOf = _prefix "variantOf"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/non_alcoholic_version"></see>
    /// </summary>
    let non_alcoholic_version = _prefix "non_alcoholic_version"
    /// <summary>
    ///
    ///     The distillate, a clear liquid, is then usually aged in
    ///     oak barrels.
    ///
    /// <see href="http://rdfs.co/bevon/Rum"></see></summary>
    let Rum = _prefix "Rum"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Sake"></see>
    /// </summary>
    let Sake = _prefix "Sake"
    /// <summary>
    ///
    ///     All Scotch whisky was originally made from malt barley. Commercial
    ///     distilleries began introducing whisky made from wheat and rye in the late
    ///     eighteenth century.
    ///
    /// <see href="http://rdfs.co/bevon/ScotchWhisky"></see></summary>
    let ScotchWhisky = _prefix "ScotchWhisky"
    /// <summary>
    ///
    ///     As with any Scotch whisky, a single malt Scotch must be distilled in
    ///     Scotland and matured in oak casks in Scotland for at least three years
    ///     (most single malts are matured longer).
    ///
    /// <see href="http://rdfs.co/bevon/SingleMaltScotch"></see></summary>
    let SingleMaltScotch = _prefix "SingleMaltScotch"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/SingleMaltWhisky"></see>
    /// </summary>
    let SingleMaltWhisky = _prefix "SingleMaltWhisky"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/SpeysideSingleMalt"></see>
    /// </summary>
    let SpeysideSingleMalt = _prefix "SpeysideSingleMalt"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/Tequila"></see>
    /// </summary>
    let Tequila = _prefix "Tequila"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/TequilaBlanco"></see>
    /// </summary>
    let TequilaBlanco = _prefix "TequilaBlanco"
    /// <summary>
    ///
    ///     Vodka is made by the distillation of fermented substances such as grains,
    ///     potatoes, or sometimes fruits or sugar.
    ///
    /// <see href="http://rdfs.co/bevon/Vodka"></see></summary>
    let Vodka = _prefix "Vodka"
    /// <summary>
    ///
    ///     It is produced by the alcoholic fermentation of the non-coloured pulp of
    ///     grapes which may have a white or black skin. It is treated so as to
    ///     maintain a yellow transparent colour in the final product.
    ///
    /// <see href="http://rdfs.co/bevon/WhiteWine"></see></summary>
    let WhiteWine = _prefix "WhiteWine"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Budweiser"></see>
    /// </summary>
    let ``beverage/Budweiser`` = _prefix "beverage/Budweiser"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/330mlLongneck"></see>
    /// </summary>
    let ``container/330mlLongneck`` = _prefix "container/330mlLongneck"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/500mlBeverageCan"></see>
    /// </summary>
    let ``container/500mlBeverageCan`` = _prefix "container/500mlBeverageCan"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/355mlBeverageCan"></see>
    /// </summary>
    let ``container/355mlBeverageCan`` = _prefix "container/355mlBeverageCan"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Chamisul"></see>
    /// </summary>
    let ``beverage/Chamisul`` = _prefix "beverage/Chamisul"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/1_8lPlasticBottle"></see>
    /// </summary>
    let ``container/1_8lPlasticBottle`` = _prefix "container/1_8lPlasticBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/640mlPlasticBottle"></see>
    /// </summary>
    let ``container/640mlPlasticBottle`` = _prefix "container/640mlPlasticBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/200mlPlasticBottle"></see>
    /// </summary>
    let ``container/200mlPlasticBottle`` = _prefix "container/200mlPlasticBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/360mlGlassBottle"></see>
    /// </summary>
    let ``container/360mlGlassBottle`` = _prefix "container/360mlGlassBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Chum-Churum"></see>
    /// </summary>
    let ``beverage/Chum-Churum`` = _prefix "beverage/Chum-Churum"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/360mlPlasticBottle"></see>
    /// </summary>
    let ``container/360mlPlasticBottle`` = _prefix "container/360mlPlasticBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/DonJulioBlanco"></see>
    /// </summary>
    let ``beverage/DonJulioBlanco`` = _prefix "beverage/DonJulioBlanco"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/750mlGlassBottle"></see>
    /// </summary>
    let ``container/750mlGlassBottle`` = _prefix "container/750mlGlassBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Glenfiddich12YearOld"></see>
    /// </summary>
    let ``beverage/Glenfiddich12YearOld`` = _prefix "beverage/Glenfiddich12YearOld"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/duration"></see>
    /// </summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/previous_content"></see>
    /// </summary>
    let previous_content = _prefix "previous_content"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/material"></see>
    /// </summary>
    let material = _prefix "material"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/700mlGlassBottle"></see>
    /// </summary>
    let ``container/700mlGlassBottle`` = _prefix "container/700mlGlassBottle"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Guinness"></see>
    /// </summary>
    let ``beverage/Guinness`` = _prefix "beverage/Guinness"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/15lBeerKeg"></see>
    /// </summary>
    let ``container/15lBeerKeg`` = _prefix "container/15lBeerKeg"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/30lBeerKeg"></see>
    /// </summary>
    let ``container/30lBeerKeg`` = _prefix "container/30lBeerKeg"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/330mlBeverageCan"></see>
    /// </summary>
    let ``container/330mlBeverageCan`` = _prefix "container/330mlBeverageCan"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Kilkenny"></see>
    /// </summary>
    let ``beverage/Kilkenny`` = _prefix "beverage/Kilkenny"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/440mlBeverageCan"></see>
    /// </summary>
    let ``container/440mlBeverageCan`` = _prefix "container/440mlBeverageCan"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Smithwicks"></see>
    /// </summary>
    let ``beverage/Smithwicks`` = _prefix "beverage/Smithwicks"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/KozelDark"></see>
    /// </summary>
    let ``beverage/KozelDark`` = _prefix "beverage/KozelDark"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/500mlLongneck"></see>
    /// </summary>
    let ``container/500mlLongneck`` = _prefix "container/500mlLongneck"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/Tsingtao"></see>
    /// </summary>
    let ``beverage/Tsingtao`` = _prefix "beverage/Tsingtao"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/640mlLongneck"></see>
    /// </summary>
    let ``container/640mlLongneck`` = _prefix "container/640mlLongneck"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/beverage/WhiskyAndSoda"></see>
    /// </summary>
    let ``beverage/WhiskyAndSoda`` = _prefix "beverage/WhiskyAndSoda"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/food"></see>
    /// </summary>
    let food = _prefix "food"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/quantity"></see>
    /// </summary>
    let quantity = _prefix "quantity"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/25lBeerKeg"></see>
    /// </summary>
    let ``container/25lBeerKeg`` = _prefix "container/25lBeerKeg"
    /// <summary>
    ///   <see href="http://rdfs.co/bevon/container/50lBeerKeg"></see>
    /// </summary>
    let ``container/50lBeerKeg`` = _prefix "container/50lBeerKeg"
