#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bevon =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.co/bevon/" "bevon"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.7`` = _prefixId.prefix "0.7"
    let ``_0.8`` = _prefixId.prefix "0.8"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Aging is the process of storing beverages in casks for a specific period of
    ///     time to remove harsh flavors and add distinct characteristics found in the
    ///     cask's wood.
    ///     </para>
    ///   <para>skos:prefLabel : 숙성skos:prefLabel : Aging</para>
    ///   <a href="http://rdfs.co/bevon/Aging">bevon:Aging</a>
    /// </summary>
    let Aging = _prefixId.prefix "Aging"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 알코올 음료skos:prefLabel : Alcoholic Beverage</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///      An alcoholic beverage is a drink and psychoactive drug containing
    ///      ethyl alcohol which is commonly referred to as ethanol.
    ///      </para>
    ///   <a href="http://rdfs.co/bevon/AlcoholicBeverage">bevon:AlcoholicBeverage</a>
    /// </summary>
    let AlcoholicBeverage = _prefixId.prefix "AlcoholicBeverage"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 에일skos:prefLabel : Ale</para>
    ///   <para>skos:definition :
    ///     Ale is a type of beer brewed from malted barley using a warm-fermentation
    ///     with a strain of brewers' yeast.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     The yeast will ferment the beer quickly, giving it a sweet, full bodied and
    ///     fruity taste.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Ale">bevon:Ale</a>
    /// </summary>
    let Ale = _prefixId.prefix "Ale"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : American Whisky</para>
    ///   <para>skos:prefLabel : American Whiskeyskos:prefLabel : 아메리칸 위스키</para>
    ///   <para>skos:definition :
    ///     American whiskey is a distilled beverage produced in the United States from
    ///     a fermented mash of cereal grain.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     The production and labeling of American whiskey are governed by Title 27 of
    ///     the U.S. Code of Federal Regulations.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/AmericanWhiskey">bevon:AmericanWhiskey</a>
    /// </summary>
    let AmericanWhiskey = _prefixId.prefix "AmericanWhiskey"
    let AmericanWhisky = _prefixId.prefix "AmericanWhisky"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 맥주skos:prefLabel : Beer</para>
    ///   <para>skos:definition :
    ///     Beer is an alcoholic beverage produced by the saccharification of starch
    ///     and fermentation of the resulting sugar.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment :
    ///     The starch and saccharification enzymes are often derived from malted
    ///     cereal grains, most commonly malted barley and malted wheat.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Beer">bevon:Beer</a>
    /// </summary>
    let Beer = _prefixId.prefix "Beer"
    /// <summary>
    ///   <para>skos:definition :
    ///     A beer bottle is a bottle made to contain beer, usually made of glass and
    ///     come in various sizes, shapes and colors.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     Dark amber or brown glass greatly reduces UV light from spoiling the beer.
    ///     However, lighter colored bottles are often used for marketing reasons.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 맥주병skos:prefLabel : Beer Bottle</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/BeerBottle">bevon:BeerBottle</a>
    /// </summary>
    let BeerBottle = _prefixId.prefix "BeerBottle"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A beer cocktail is a cocktail that is made by mixing beer with a distilled
    ///     beverage. In this type of cocktail, the primary ingredient is beer.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : Beer Cocktailskos:prefLabel : 맥주 칵테일</para>
    ///   <a href="http://rdfs.co/bevon/BeerCocktail">bevon:BeerCocktail</a>
    /// </summary>
    let BeerCocktail = _prefixId.prefix "BeerCocktail"
    let BeerGroup = _prefixId.prefix "BeerGroup"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Beer kegs are made of stainless steel, or less commonly, of aluminium.
    ///     </para>
    ///   <para>skos:prefLabel : 맥주 케그skos:prefLabel : Beer Keg</para>
    ///   <a href="http://rdfs.co/bevon/BeerKeg">bevon:BeerKeg</a>
    /// </summary>
    let BeerKeg = _prefixId.prefix "BeerKeg"
    /// <summary>
    ///   <para>skos:prefLabel : 음료skos:prefLabel : Beverage</para>
    ///   <para>skos:definition :
    ///     A beverage, or drink, is a kind of liquid which is specifically prepared
    ///     for human consumption.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Drink</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Beverage">bevon:Beverage</a>
    /// </summary>
    let Beverage = _prefixId.prefix "Beverage"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A beverage can is a metal container designed to hold a fixed portion of
    ///     liquid such as a carbonated soft drinks, alcoholic beverages, fruit juices,
    ///     teas, tisanes, energy drinks, etc.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Beverage Canskos:prefLabel : 음료 캔</para>
    ///   <para>rdfs:comment :
    ///     Beverage cans are made of aluminium (75% of worldwide production) or
    ///     tin-plated steel (25% worldwide production).
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/BeverageCan">bevon:BeverageCan</a>
    /// </summary>
    let BeverageCan = _prefixId.prefix "BeverageCan"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     The name of the spirit derives from its historical association with an area
    ///     known as Old Bourbon, around what is now Bourbon County, Kentucky (which,
    ///     in turn, was named after the French House of Bourbon royal family). It has
    ///     been produced since the 18th century. While it may be made anywhere in the
    ///     United States, it is strongly associated with the American South in
    ///     general, and Kentucky in particular.
    ///     </para>
    ///   <para>skos:altLabel : Bourbon Whisky</para>
    ///   <para>skos:prefLabel : 버번 위스키skos:prefLabel : Bourbon Whiskey</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Bourbon whiskey is a type of American whiskey – a barrel-aged distilled
    ///     spirit made primarily from corn.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/BourbonWhiskey">bevon:BourbonWhiskey</a>
    /// </summary>
    let BourbonWhiskey = _prefixId.prefix "BourbonWhiskey"
    /// <summary>
    ///   <para>skos:prefLabel : Brandyskos:prefLabel : 브랜디</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment :
    ///     Brandy generally contains 35–60% alcohol by volume (70–120 US proof) and is
    ///     typically taken as an after-dinner drink. Some brandies are aged in wooden
    ///     casks, some are colored with caramel coloring to imitate the effect of
    ///     aging, and some brandies are produced using a combination of both aging and
    ///     coloring.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Brandy (from brandywine, derived from Dutch brandewijn—"burnt wine") is a
    ///     spirit produced by distilling wine.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Brandy">bevon:Brandy</a>
    /// </summary>
    let Brandy = _prefixId.prefix "Brandy"
    /// <summary>
    ///   <para>skos:prefLabel : 양조장skos:prefLabel : Brewery</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A brewery is a dedicated building for the making of beer, though beer can
    ///     be made at home, and has been for much of beer's history.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment :
    ///     A company that makes beer is called either a brewery or a brewing company.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Brewery">bevon:Brewery</a>
    /// </summary>
    let Brewery = _prefixId.prefix "Brewery"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment :
    ///     Most Canadian whiskies are blended multi-grain liquors containing a large
    ///     percentage of corn spirits, and are typically lighter and smoother than
    ///     other whisky styles.
    ///     </para>
    ///   <para>skos:definition :
    ///     Canadian whisky is a type of whisky produced in Canada.
    ///     </para>
    ///   <para>skos:prefLabel : 캐내디언 위스키skos:prefLabel : Canadian Whisky</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Canadian Whiskey</para>
    ///   <a href="http://rdfs.co/bevon/CanadianWhisky">bevon:CanadianWhisky</a>
    /// </summary>
    let CanadianWhisky = _prefixId.prefix "CanadianWhisky"
    /// <summary>
    ///   <para>skos:altLabel : 소다수skos:altLabel : 클럽소다skos:altLabel : Seltzer Waterskos:altLabel : Soda Waterskos:altLabel : Sparkling Waterskos:altLabel : Fizzy Waterskos:altLabel : Club Soda</para>
    ///   <para>skos:definition :
    ///     Carbonated water is water into which carbon dioxide gas under pressure has
    ///     been dissolved.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Carbonated Waterskos:prefLabel : 탄산수</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/CarbonatedWater">bevon:CarbonatedWater</a>
    /// </summary>
    let CarbonatedWater = _prefixId.prefix "CarbonatedWater"
    /// <summary>
    ///   <para>skos:definition :
    ///     A cocktail is a mixed drink that contains alcohol, including mixers, mixed
    ///     shots, etc.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment :
    ///     Cocktails were originally a mixture of spirits, sugar, water, and bitters.
    ///     It is now often used for almost any mixed drink that contains alcohol,
    ///     including mixers, mixed shots, etc. A cocktail today usually contains one
    ///     or more kinds of spirit and one or more mixers, such as soda or fruit
    ///     juice. Additional ingredients may be sugar, honey, milk, cream, and various
    ///     herbs.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 칵테일skos:prefLabel : Cocktail</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Cocktail">bevon:Cocktail</a>
    /// </summary>
    let Cocktail = _prefixId.prefix "Cocktail"
    let CocktailGroup = _prefixId.prefix "CocktailGroup"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Cognac, named after the town of Cognac in France, is a variety of brandy.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:prefLabel : 코냑skos:prefLabel : Cognac</para>
    ///   <para>rdfs:comment :
    ///     It is produced in the wine-growing region surrounding the town from which
    ///     it takes its name, in the French Departements of Charente and
    ///     Charente-Maritime.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Cognac">bevon:Cognac</a>
    /// </summary>
    let Cognac = _prefixId.prefix "Cognac"
    /// <summary>
    ///   <para>skos:prefLabel : Containerskos:prefLabel : 용기</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A container is an item used to contain, store, and transport a beverage.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/Container">bevon:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    let ContainerGroup = _prefixId.prefix "ContainerGroup"
    let CoreGroup = _prefixId.prefix "CoreGroup"
    /// <summary>
    ///   <para>skos:prefLabel : Diluted Sojuskos:prefLabel : 희석식 소주</para>
    ///   <para>skos:definition :
    ///     Diluted Soju is made by mixing pure ethanol distilled from various grains,
    ///     such as potatoes, wheat, barley, sweet potatoes, or tapioca, with water and
    ///     flavoring.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/DilutedSoju">bevon:DilutedSoju</a>
    /// </summary>
    let DilutedSoju = _prefixId.prefix "DilutedSoju"
    /// <summary>
    ///   <para>skos:prefLabel : 증류주skos:prefLabel : Distilled Beverage</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:altLabel : Spiritskos:altLabel : Liquor</para>
    ///   <para>skos:definition :
    ///      A distilled beverage, spirit, or liquor is an alcoholic beverage
    ///      containing ethanol that is produced by distilling (i.e., concentrating
    ///      by distillation) ethanol produced by means of fermenting grain, fruit,
    ///      or vegetables.
    ///      </para>
    ///   <para>rdfs:comment :
    ///      This excludes undistilled fermented beverages such as beer, wine, and
    ///      cider.
    ///      </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/DistilledBeverage">bevon:DistilledBeverage</a>
    /// </summary>
    let DistilledBeverage = _prefixId.prefix "DistilledBeverage"
    /// <summary>
    ///   <para>skos:prefLabel : 증류식 소주skos:prefLabel : Distilled Soju</para>
    ///   <para>skos:definition :
    ///     Distilled Soju is manufactured traditionally by distillation from grains,
    ///     mainly rice.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/DistilledSoju">bevon:DistilledSoju</a>
    /// </summary>
    let DistilledSoju = _prefixId.prefix "DistilledSoju"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A distillery is a premise where distillation takes place, especially
    ///     distillation of alcohol.
    ///     </para>
    ///   <para>skos:prefLabel : 증류소skos:prefLabel : Distillery</para>
    ///   <a href="http://rdfs.co/bevon/Distillery">bevon:Distillery</a>
    /// </summary>
    let Distillery = _prefixId.prefix "Distillery"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Irish stout or dry stout is very dark or rich in color and it often has a
    ///     "roasted" or coffee-like taste.
    ///     </para>
    ///   <para>skos:altLabel : Irish Stout</para>
    ///   <para>skos:prefLabel : Dry Stoutskos:prefLabel : 드라이 스타우트</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/DryStout">bevon:DryStout</a>
    /// </summary>
    let DryStout = _prefixId.prefix "DryStout"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 둔켈skos:prefLabel : Dunkel</para>
    ///   <para>skos:definition :
    ///     Dunkel, or Dunkles, is a word used for several types of dark German lager.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     Dunkel is the German word meaning dark, and dunkel beers typically range in
    ///     color from amber to dark reddish brown. They are characterized by their
    ///     smooth malty flavor.
    ///     </para>
    ///   <para>skos:altLabel : Dunkles</para>
    ///   <a href="http://rdfs.co/bevon/Dunkel">bevon:Dunkel</a>
    /// </summary>
    let Dunkel = _prefixId.prefix "Dunkel"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A fruit or grain which provides the sugar for fermentation from which a
    ///     alcoholic beverage is made.
    ///     </para>
    ///   <para>skos:prefLabel : 발효 주재료skos:prefLabel : Fermentation Base</para>
    ///   <a href="http://rdfs.co/bevon/FermentationBase">bevon:FermentationBase</a>
    /// </summary>
    let FermentationBase = _prefixId.prefix "FermentationBase"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A fermented beverage is a drink produced by fermenting grain, fruit, or
    ///     vegetables.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:altLabel : 발효주</para>
    ///   <para>skos:prefLabel : 양조주skos:prefLabel : Fermented Beverage</para>
    ///   <a href="http://rdfs.co/bevon/FermentedBeverage">bevon:FermentedBeverage</a>
    /// </summary>
    let FermentedBeverage = _prefixId.prefix "FermentedBeverage"
    /// <summary>
    ///   <para>skos:prefLabel : Fruit Wineskos:prefLabel : 과실주skos:prefLabel : Vin de Sureau</para>
    ///   <para>dcterms:modified : 2014-03-07+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:definition :
    ///     Fruit wines are fermented alcoholic beverages made from a variety of base
    ///     ingredients (other than grapes); they may also have additional flavors
    ///     taken from fruits, flowers, and herbs.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     This definition is sometimes broadened to include any fermented alcoholic
    ///     beverage except beer. For historical reasons, mead, cider, and perry are
    ///     also excluded from the definition of fruit wine.
    ///     </para>
    ///   <para>dcterms:issued : 2014-03-07+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/FruitWine">bevon:FruitWine</a>
    /// </summary>
    let FruitWine = _prefixId.prefix "FruitWine"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Gin is a spirit which derives its predominant flavor from juniper berries
    ///     (Juniperus communis).
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 진skos:prefLabel : Gin</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://rdfs.co/bevon/Gin">bevon:Gin</a>
    /// </summary>
    let Gin = _prefixId.prefix "Gin"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Glass Bottleskos:prefLabel : 유리병</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     Glass bottles can vary in size considerably, but are most commonly found in
    ///     sizes ranging between about 10ml and 5 litres.
    ///     </para>
    ///   <para>skos:definition :
    ///     A glass bottle is a bottle created from glass.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/GlassBottle">bevon:GlassBottle</a>
    /// </summary>
    let GlassBottle = _prefixId.prefix "GlassBottle"
    /// <summary>
    ///   <para>skos:definition :
    ///     Highball is the name for a family of mixed drinks that are composed of an
    ///     alcoholic base spirit and a larger proportion of a non-alcoholic mixer.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 하이볼skos:prefLabel : Highball</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Highball">bevon:Highball</a>
    /// </summary>
    let Highball = _prefixId.prefix "Highball"
    /// <summary>
    ///   <para>skos:prefLabel : Irish Red Aleskos:prefLabel : 아이리쉬 레드 에일</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Irish red ale, red ale, or Irish ale is a name used by brewers in Ireland.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/IrishRedAle">bevon:IrishRedAle</a>
    /// </summary>
    let IrishRedAle = _prefixId.prefix "IrishRedAle"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : Irish Whiskeyskos:prefLabel : 아이리쉬 위스키skos:prefLabel : Fuisce</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Irish Whisky</para>
    ///   <para>rdfs:comment :
    ///     Key regulations defining Irish whiskey and its production are established
    ///     by the Irish Whiskey Act of 1980.
    ///     </para>
    ///   <para>skos:definition :
    ///     Irish whiskey is whisky made in Ireland.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/IrishWhiskey">bevon:IrishWhiskey</a>
    /// </summary>
    let IrishWhiskey = _prefixId.prefix "IrishWhiskey"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Japanese Whiskey</para>
    ///   <para>rdfs:comment :
    ///     Whisky production in Japan began around 1870, but the first commercial
    ///     production was in 1924 upon the opening of the country's first distillery,
    ///     Yamazaki. Broadly speaking the style of Japanese whisky is more similar to
    ///     that of Scotch whisky than Irish, American, or Canadian styles of whisky,
    ///     and thus the spelling typically follows the Scottish convention (omitting
    ///     the letter "e").
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 재패니즈 위스키skos:prefLabel : Japanese Whisky</para>
    ///   <para>skos:definition :
    ///     Japanese whisky is whisky made in Japan.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/JapaneseWhisky">bevon:JapaneseWhisky</a>
    /// </summary>
    let JapaneseWhisky = _prefixId.prefix "JapaneseWhisky"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Kegskos:prefLabel : 케그</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     A keg is a small barrel.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Keg">bevon:Keg</a>
    /// </summary>
    let Keg = _prefixId.prefix "Keg"
    /// <summary>
    ///   <para>skos:definition :
    ///     Lager is a type of beer that is fermented and conditioned at low
    ///     temperatures.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : Lagerskos:prefLabel : 라거</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Lager">bevon:Lager</a>
    /// </summary>
    let Lager = _prefixId.prefix "Lager"
    /// <summary>
    ///   <para>skos:altLabel : Cordialsskos:altLabel : Schnapps</para>
    ///   <para>rdfs:comment :
    ///     Liqueurs are typically quite sweet; they are usually not aged for long
    ///     after the ingredients are mixed, but may have resting periods during their
    ///     production to allow flavors to marry.
    ///     </para>
    ///   <para>skos:definition :
    ///     A liqueur is an alcoholic beverage made from a distilled spirit that has
    ///     been flavored with fruit, cream, herbs, spices, flowers or nuts and bottled
    ///     with added sugar or other sweetener (such as high-fructose corn syrup).
    ///     </para>
    ///   <para>skos:prefLabel : 리큐어skos:prefLabel : Liqueur</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Liqueur">bevon:Liqueur</a>
    /// </summary>
    let Liqueur = _prefixId.prefix "Liqueur"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : North American Longneckskos:altLabel : Industry Standard Bottle</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 긴목 맥주병skos:prefLabel : Longneck</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     It is known as the standard longneck bottle or industry standard bottle
    ///     (ISB). The ISB longnecks have a uniform capacity, height, weight and
    ///     diameter and can be reused on average 16 times. The long neck offers a long
    ///     cushion of air to absorb the pressure of carbonation to reduce the risk of
    ///     exploding. The longneck also provides a handle for drinking directly from
    ///     the bottle without transferring body heat to the beer from one's hand.
    ///     </para>
    ///   <para>skos:definition :
    ///     A longneck is a type of beer bottle with a long neck.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Longneck">bevon:Longneck</a>
    /// </summary>
    let Longneck = _prefixId.prefix "Longneck"
    /// <summary>
    ///   <para>skos:prefLabel : Malt Whiskyskos:prefLabel : 몰트 위스키</para>
    ///   <para>skos:definition :
    ///     Malt whisky is whisky that is made from a fermented mash produced primarily
    ///     from a malted grain.
    ///     </para>
    ///   <para>skos:altLabel : Malt Whiskey</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/MaltWhisky">bevon:MaltWhisky</a>
    /// </summary>
    let MaltWhisky = _prefixId.prefix "MaltWhisky"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 광천수skos:prefLabel : Mineral Water</para>
    ///   <para>skos:definition :
    ///     Mineral water is water from a mineral spring containing various minerals
    ///     such as salts and sulfur compounds.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     Mineral water may be sparkling due to contained gases.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/MineralWater">bevon:MineralWater</a>
    /// </summary>
    let MineralWater = _prefixId.prefix "MineralWater"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment :
    ///     Some mixed drinks are alcoholic beverages that contain liquor; others are
    ///     non-alcoholic.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 혼합 음료skos:prefLabel : Mixed Drink</para>
    ///   <para>skos:definition :
    ///     A mixed drink is a beverage in which two or more ingredients are mixed.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/MixedDrink">bevon:MixedDrink</a>
    /// </summary>
    let MixedDrink = _prefixId.prefix "MixedDrink"
    /// <summary>
    ///   <para>skos:definition :
    ///     Mocktails are mock cocktails, or those that do not contain any alcohol.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 목테일skos:prefLabel : Mocktail</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Mocktail">bevon:Mocktail</a>
    /// </summary>
    let Mocktail = _prefixId.prefix "Mocktail"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : Low-alcoholic Beer</para>
    ///   <para>skos:definition :
    ///     Non-alcohol beer (also called light beer, low-alcoholic beer, small beer,
    ///     small ale, or near-beer) is beer with low alcohol content or no alcohol,
    ///     which aim to reproduce the taste of beer without the inebriating effects of
    ///     standard alcoholic brews.
    ///     </para>
    ///   <para>skos:prefLabel : Non-alcoholic Beerskos:prefLabel : 비알코올 맥주</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/NonAlcoholicBeer">bevon:NonAlcoholicBeer</a>
    /// </summary>
    let NonAlcoholicBeer = _prefixId.prefix "NonAlcoholicBeer"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///      A non-alcoholic beverage (also known as a virgin drink) is defined
    ///      in the U.S. as a beverage that contains less than 0.5% alcohol by volume.
    ///      </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Non-alcoholic Beverageskos:prefLabel : 비알코올 음료</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://rdfs.co/bevon/NonAlcoholicBeverage">bevon:NonAlcoholicBeverage</a>
    /// </summary>
    let NonAlcoholicBeverage = _prefixId.prefix "NonAlcoholicBeverage"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     It is one of the world's major beer styles.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Pale Aleskos:prefLabel : 페일 에일</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Pale ale is a beer made by warm fermentation using predominantly pale malt.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/PaleAle">bevon:PaleAle</a>
    /// </summary>
    let PaleAle = _prefixId.prefix "PaleAle"
    /// <summary>
    ///   <para>skos:prefLabel : 페일 라거skos:prefLabel : Pale Lager</para>
    ///   <para>skos:definition :
    ///     Pale lager is a very pale to golden-colored beer with a well attenuated
    ///     body and a varying degree of noble hop bitterness.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/PaleLager">bevon:PaleLager</a>
    /// </summary>
    let PaleLager = _prefixId.prefix "PaleLager"
    /// <summary>
    ///   <para>skos:prefLabel : 필스너skos:prefLabel : Pilsner</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : Pilsenerskos:altLabel : Pils</para>
    ///   <para>rdfs:comment :
    ///     It took its name from the city of Pilsen (Plzeň, Bohemia, Czech Republic,
    ///     where it was first produced in 1842).
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Pilsner (also pilsener or simply pils) is a type of pale lager.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Pilsner">bevon:Pilsner</a>
    /// </summary>
    let Pilsner = _prefixId.prefix "Pilsner"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:prefLabel : Piscoskos:prefLabel : 피스코</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Pisco is a colorless or yellowish-to-amber colored grape brandy produced
    ///     in winemaking regions of Peru and Chile.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Pisco">bevon:Pisco</a>
    /// </summary>
    let Pisco = _prefixId.prefix "Pisco"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Plastic Bottleskos:prefLabel : 플라스틱 병</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     Plastic bottles are typically used to store liquids such as water, soft
    ///     drinks, motor oil, cooking oil, medicine, shampoo, milk, and ink.
    ///     </para>
    ///   <para>skos:definition :
    ///     A plastic bottle is a bottle constructed of plastic.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/PlasticBottle">bevon:PlasticBottle</a>
    /// </summary>
    let PlasticBottle = _prefixId.prefix "PlasticBottle"
    /// <summary>
    ///   <para>skos:altLabel : English Porter</para>
    ///   <para>skos:prefLabel : Porterskos:prefLabel : 포터</para>
    ///   <para>rdfs:comment :
    ///     The name came about as a result of its popularity with street and river
    ///     porters.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Porter is a dark style of beer originating in London in the 18th century,
    ///     descended from brown beer, a well hopped beer made from brown malt.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Porter">bevon:Porter</a>
    /// </summary>
    let Porter = _prefixId.prefix "Porter"
    /// <summary>
    ///   <para>skos:prefLabel : Vin Rougeskos:prefLabel : Red Wineskos:prefLabel : 레드 와인</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2014-03-07+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Red wine is a type of wine made from dark-coloured (black) grape varieties.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     The actual colour of the wine can range from intense violet, typical of
    ///     young wines, through to brick red for mature wines and brown for older red
    ///     wines.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-07+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/RedWine">bevon:RedWine</a>
    /// </summary>
    let RedWine = _prefixId.prefix "RedWine"
    let RelationGroup = _prefixId.prefix "RelationGroup"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Ronskos:prefLabel : Rumskos:prefLabel : 럼</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     The distillate, a clear liquid, is then usually aged in
    ///     oak barrels.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:definition :
    ///     Rum is a distilled alcoholic beverage made from sugarcane byproducts, such
    ///     as molasses, or directly from sugarcane juice, by a process of fermentation
    ///     and distillation.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Rum">bevon:Rum</a>
    /// </summary>
    let Rum = _prefixId.prefix "Rum"
    /// <summary>
    ///   <para>skos:altLabel : Rice Wine</para>
    ///   <para>skos:prefLabel : 사케skos:prefLabel : Sakeskos:prefLabel : Saké</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Sake or saké is an alcoholic beverage of Japanese origin that is made from
    ///     fermented rice.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Sake">bevon:Sake</a>
    /// </summary>
    let Sake = _prefixId.prefix "Sake"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     All Scotch whisky was originally made from malt barley. Commercial
    ///     distilleries began introducing whisky made from wheat and rye in the late
    ///     eighteenth century.
    ///     </para>
    ///   <para>skos:prefLabel : Scotch Whiskyskos:prefLabel : 스카치 위스키</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Scotch whisky (often referred to simply as "Scotch") is malt whisky or grain
    ///     whisky made in Scotland.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Scotch Whiskey</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/ScotchWhisky">bevon:ScotchWhisky</a>
    /// </summary>
    let ScotchWhisky = _prefixId.prefix "ScotchWhisky"
    /// <summary>
    ///   <para>skos:prefLabel : Shandyskos:prefLabel : 섄디</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     The proportions of the two ingredients are adjusted to taste, usually
    ///     half-and-half.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     A shandy, or shandygaff, is beer mixed with a soft drink, carbonated
    ///     lemonade, ginger beer, ginger ale, or apple juice.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Shandy">bevon:Shandy</a>
    /// </summary>
    let Shandy = _prefixId.prefix "Shandy"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : Single Malt Scotchskos:prefLabel : 싱글 몰트 스카치</para>
    ///   <para>rdfs:comment :
    ///     As with any Scotch whisky, a single malt Scotch must be distilled in
    ///     Scotland and matured in oak casks in Scotland for at least three years
    ///     (most single malts are matured longer).
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Single Malt Scotch is single malt whisky made in Scotland using a pot still
    ///     distillation process at a single distillery, with malted barley as the only
    ///     grain ingredient.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/SingleMaltScotch">bevon:SingleMaltScotch</a>
    /// </summary>
    let SingleMaltScotch = _prefixId.prefix "SingleMaltScotch"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Single malt whisky is a whisky made at one particular distillery from a
    ///     mash that uses only malted grain, ordinarily barley.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Single Malt Whiskey</para>
    ///   <para>skos:prefLabel : 싱글 몰트 위스키skos:prefLabel : Single Malt Whisky</para>
    ///   <a href="http://rdfs.co/bevon/SingleMaltWhisky">bevon:SingleMaltWhisky</a>
    /// </summary>
    let SingleMaltWhisky = _prefixId.prefix "SingleMaltWhisky"
    /// <summary>
    ///   <para>skos:prefLabel : Sojuskos:prefLabel : 소주</para>
    ///   <para>skos:definition :
    ///     Soju is a distilled beverage native to Korea.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     Its taste is comparable to vodka, though often slightly sweeter due to
    ///     sugars added in the manufacturing process.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Soju">bevon:Soju</a>
    /// </summary>
    let Soju = _prefixId.prefix "Soju"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Speyside single malts are single malt Scotch whiskies, distilled in
    ///     Strathspey, the area around the River Spey in Moray and Badenoch and
    ///     Strathspey, in northeastern Scotland.
    ///     </para>
    ///   <para>skos:prefLabel : 스페이사이드 싱글 몰트skos:prefLabel : Speyside Single Malt</para>
    ///   <a href="http://rdfs.co/bevon/SpeysideSingleMalt">bevon:SpeysideSingleMalt</a>
    /// </summary>
    let SpeysideSingleMalt = _prefixId.prefix "SpeysideSingleMalt"
    /// <summary>
    ///   <para>skos:prefLabel : Stoutskos:prefLabel : 스타우트</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Stout is a dark beer made using roasted malt or roasted barley, hops, water
    ///     and yeast.
    ///     </para>
    ///   <para>skos:altLabel : Strong Porter</para>
    ///   <para>rdfs:comment :
    ///     Stouts were traditionally the generic term for the strongest or stoutest
    ///     porters, typically 7% or 8%, produced by a brewery.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/Stout">bevon:Stout</a>
    /// </summary>
    let Stout = _prefixId.prefix "Stout"
    /// <summary>
    ///   <para>skos:prefLabel : Tequilaskos:prefLabel : 테킬라</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Tequila is a distilled beverage made from the blue agave plant, primarily
    ///     in the area surrounding the city of Tequila, 65 kilometres (40 mi)
    ///     northwest of Guadalajara, and in the highlands (Los Altos) of the western
    ///     Mexican state of Jalisco.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Tequila">bevon:Tequila</a>
    /// </summary>
    let Tequila = _prefixId.prefix "Tequila"
    /// <summary>
    ///   <para>skos:prefLabel : 테킬라 블랑코skos:prefLabel : Tequila Blanco</para>
    ///   <para>skos:definition :
    ///     Tequila Blanco ("white") or Plata ("silver") is a white spirit, un-aged and
    ///     bottled or stored immediately after distillation, or aged less than two
    ///     months in stainless steel or neutral oak barrels.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Tequila Plata</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/TequilaBlanco">bevon:TequilaBlanco</a>
    /// </summary>
    let TequilaBlanco = _prefixId.prefix "TequilaBlanco"
    /// <summary>
    ///   <para>skos:definition :
    ///     Vodka is a distilled beverage composed primarily of water and ethanol,
    ///     sometimes with traces of impurities and flavorings.
    ///     </para>
    ///   <para>skos:prefLabel : 보드카skos:prefLabel : Vodkaskos:prefLabel : водкаskos:prefLabel : Wódka</para>
    ///   <para>rdfs:comment :
    ///     Vodka is made by the distillation of fermented substances such as grains,
    ///     potatoes, or sometimes fruits or sugar.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://rdfs.co/bevon/Vodka">bevon:Vodka</a>
    /// </summary>
    let Vodka = _prefixId.prefix "Vodka"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 물skos:prefLabel : Water</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:definition :
    ///     In the Beverage Ontology, Water means a drinking water.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/Water">bevon:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>skos:prefLabel : Whiskyskos:prefLabel : 위스키</para>
    ///   <para>dcterms:modified : 2015-07-23+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Whisky or whiskey is a type of distilled alcoholic beverage made from
    ///     fermented grain mash.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     Different grains are used for different varieties, including barley, malted
    ///     barley, rye, malted rye, wheat, and corn. Whisky is typically aged in
    ///     wooden casks, made generally of charred white oak.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:altLabel : Whiskey</para>
    ///   <a href="http://rdfs.co/bevon/Whisky">bevon:Whisky</a>
    /// </summary>
    let Whisky = _prefixId.prefix "Whisky"
    let WhiskyGroup = _prefixId.prefix "WhiskyGroup"
    /// <summary>
    ///   <para>skos:prefLabel : 화이트 와인skos:prefLabel : White Wineskos:prefLabel : Vin Blanc</para>
    ///   <para>skos:definition :
    ///     White wine is a wine whose colour can be straw-yellow, yellow-green, or
    ///     yellow-gold coloured.
    ///     </para>
    ///   <para>dcterms:issued : 2014-03-07+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     It is produced by the alcoholic fermentation of the non-coloured pulp of
    ///     grapes which may have a white or black skin. It is treated so as to
    ///     maintain a yellow transparent colour in the final product.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2014-03-07+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/WhiteWine">bevon:WhiteWine</a>
    /// </summary>
    let WhiteWine = _prefixId.prefix "WhiteWine"
    /// <summary>
    ///   <para>skos:prefLabel : Wineskos:prefLabel : Vinskos:prefLabel : 와인</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:definition :
    ///     Wine is an alcoholic beverage made from fermented grapes or other fruits.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-07+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/Wine">bevon:Wine</a>
    /// </summary>
    let Wine = _prefixId.prefix "Wine"
    let WineGroup = _prefixId.prefix "WineGroup"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>skos:definition :
    ///     ABV (Alcohol by Volume) is a standard measure of how much alcohol is
    ///     contained in the drink.
    ///     </para>
    ///   <para>skos:prefLabel : 알코올 도수skos:prefLabel : ABV</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : alcohol by volume</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/abv">bevon:abv</a>
    /// </summary>
    let abv = _prefixId.prefix "abv"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property specifies how the beverage has been aged.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 숙성skos:prefLabel : aging</para>
    ///   <a href="http://rdfs.co/bevon/aging">bevon:aging</a>
    /// </summary>
    let aging = _prefixId.prefix "aging"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property relates a beer to its brewery.
    ///     </para>
    ///   <para>skos:prefLabel : 양조장skos:prefLabel : Brewery</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/brewery">bevon:brewery</a>
    /// </summary>
    let brewery = _prefixId.prefix "brewery"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : colorskos:prefLabel : 색상</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     This property specifies the color of the beverage.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/color">bevon:color</a>
    /// </summary>
    let color = _prefixId.prefix "color"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     This property can be used to indicate that the beverage is available in a
    ///     type of container.
    ///     </para>
    ///   <para>skos:prefLabel : 용기skos:prefLabel : container</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/container">bevon:container</a>
    /// </summary>
    let container = _prefixId.prefix "container"
    /// <summary>
    ///   <para>skos:prefLabel : 설명skos:prefLabel : description</para>
    ///   <para>skos:definition :
    ///     This property specifies the short text description of the beverage.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/description">bevon:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>skos:prefLabel : 증류소skos:prefLabel : Distillery</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property relates a distilled beverage to its distillery.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/distillery">bevon:distillery</a>
    /// </summary>
    let distillery = _prefixId.prefix "distillery"
    /// <summary>
    ///   <para>skos:prefLabel : durationskos:prefLabel : 기간</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property describes how long the beverage was aged in the cask.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/duration">bevon:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>skos:definition :
    ///     This property indicates which fermentation base is used to make the
    ///     alcoholic beverage.
    ///     </para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 발효 주재료skos:prefLabel : fermentation base</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/fermentation_base">bevon:fermentation_base</a>
    /// </summary>
    let fermentation_base = _prefixId.prefix "fermentation_base"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 음식skos:prefLabel : food</para>
    ///   <para>skos:definition :
    ///     This property describes food that is an ingredient of a mixed drink.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/food">bevon:food</a>
    /// </summary>
    let food = _prefixId.prefix "food"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : IBU scaleskos:prefLabel : IBU 척도</para>
    ///   <para>skos:altLabel : International Bitterness Unit scale</para>
    ///   <para>skos:definition :
    ///     The International Bittering Units scale, or simply IBU scale, provides a
    ///     measure of the bitterness of beer, which is provided by the hops used
    ///     during brewing.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/ibu">bevon:ibu</a>
    /// </summary>
    let ibu = _prefixId.prefix "ibu"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 재료skos:prefLabel : ingredient</para>
    ///   <para>skos:definition :
    ///     This property specifies an ingredient of the mixed drink.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/ingredient">bevon:ingredient</a>
    /// </summary>
    let ingredient = _prefixId.prefix "ingredient"
    /// <summary>
    ///   <para>skos:prefLabel : launchskos:prefLabel : 출시년도</para>
    ///   <para>skos:definition :
    ///     This property specifies the year when the beverage was first introduced to
    ///     the market.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/launch">bevon:launch</a>
    /// </summary>
    let launch = _prefixId.prefix "launch"
    /// <summary>
    ///   <para>skos:prefLabel : manufacturerskos:prefLabel : 제조사</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property specifies the manufacturer of the beverage.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/manufacturer">bevon:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property specifies what the aging cask was made of.
    ///     </para>
    ///   <para>skos:prefLabel : 소재skos:prefLabel : material</para>
    ///   <a href="http://rdfs.co/bevon/material">bevon:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property indicates the name of the beverage.
    ///     </para>
    ///   <para>skos:prefLabel : 이름skos:prefLabel : name</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/name">bevon:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Some alcoholic beverages have non-alcoholic versions, such as non-alcoholic
    ///     beer ("near beer") and cocktails ("mocktails").
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : non-alcoholic versionskos:prefLabel : 비알코올 버전</para>
    ///   <a href="http://rdfs.co/bevon/non_alcoholic_version">bevon:non_alcoholic_version</a>
    /// </summary>
    let non_alcoholic_version = _prefixId.prefix "non_alcoholic_version"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property indicates the place where the beverage was first invented.
    ///     </para>
    ///   <para>skos:prefLabel : originskos:prefLabel : 원산지</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/origin">bevon:origin</a>
    /// </summary>
    let origin = _prefixId.prefix "origin"
    /// <summary>
    ///   <para>skos:prefLabel : 이전 내용물skos:prefLabel : previous content</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property specifies what as in the cask before the aging.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/bevon/previous_content">bevon:previous_content</a>
    /// </summary>
    let previous_content = _prefixId.prefix "previous_content"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 프루프skos:prefLabel : proof</para>
    ///   <para>skos:altLabel : alcohol proof</para>
    ///   <para>rdfs:comment :
    ///     The term was originally used in the United Kingdom and was defined as 7/4
    ///     times the alcohol by volume (ABV). The UK now uses the ABV standard instead
    ///     of alcohol proof. In the United States, alcoholic proof is defined as twice
    ///     the percentage of ABV.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Alcohol proof is a measure of how much alcohol (ethanol) is contained in an
    ///     alcoholic beverage.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/proof">bevon:proof</a>
    /// </summary>
    let proof = _prefixId.prefix "proof"
    /// <summary>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : quantityskos:prefLabel : 양</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     This property specifies the quantity of the ingredient with a type
    ///     in the UN/CEFACT Common Code.
    ///     </para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/quantity">bevon:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     This property states that a beverage is related to another beverage.
    ///     </para>
    ///   <para>skos:prefLabel : 연관skos:prefLabel : related</para>
    ///   <a href="http://rdfs.co/bevon/related">bevon:related</a>
    /// </summary>
    let related = _prefixId.prefix "related"
    let similar = _prefixId.prefix "similar"
    /// <summary>
    ///   <para>skos:prefLabel : SRM</para>
    ///   <para>skos:altLabel : Standard Reference Method</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     The Standard Reference Method or SRM is one of several systems modern
    ///     brewers use to specify beer color.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/srm">bevon:srm</a>
    /// </summary>
    let srm = _prefixId.prefix "srm"
    /// <summary>
    ///   <para>skos:definition :
    ///     This property states that a beverage has a variant.
    ///     </para>
    ///   <para>skos:prefLabel : variantskos:prefLabel : 변형</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/bevon/variant">bevon:variant</a>
    /// </summary>
    let variant = _prefixId.prefix "variant"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : variant ofskos:prefLabel : 바탕</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property states that a beverage is a variant of another beverage.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/variantOf">bevon:variantOf</a>
    /// </summary>
    let variantOf = _prefixId.prefix "variantOf"
    /// <summary>
    ///   <para>skos:prefLabel : 용량skos:prefLabel : volume</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2013-07-04+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-03-01+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property specifies the volume of the container.
    ///     </para>
    ///   <a href="http://rdfs.co/bevon/volume">bevon:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
