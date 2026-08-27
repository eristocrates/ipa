namespace http.www.w3.org.TR._2003.PR_owl_guide_20031209.food.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fowl =
    let _namespace_iri = Namespace_Iri fowl |> NamespaceIRI
    /// <summary>
    ///   <para>fowl:Bananas</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SweetFruit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Bananas">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Bananas</seealso>
    let Bananas = Prefixed_Name(fowl, "Bananas") |> PrefixedName
    /// <summary>
    ///   <para>fowl:BeefCurry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SpicyRedMeat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BeefCurry">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BeefCurry</seealso>
    let BeefCurry = Prefixed_Name(fowl, "BeefCurry") |> PrefixedName
    /// <summary>
    ///   <para>fowl:BlandFish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BlandFish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BlandFish</seealso>
    let BlandFish = Prefixed_Name(fowl, "BlandFish") |> PrefixedName
    /// <summary>
    ///   <para>fowl:BlandFishCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BlandFishCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BlandFishCourse</seealso>
    let BlandFishCourse = Prefixed_Name(fowl, "BlandFishCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Cake</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SweetDessert</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Cake">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Cake</seealso>
    let Cake = Prefixed_Name(fowl, "Cake") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Cheese</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:CheeseNutsDessert</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Cheese">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Cheese</seealso>
    let Cheese = Prefixed_Name(fowl, "Cheese") |> PrefixedName
    /// <summary>
    ///   <para>fowl:CheeseNutsDessert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#CheeseNutsDessert">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#CheeseNutsDessert</seealso>
    let CheeseNutsDessert = Prefixed_Name(fowl, "CheeseNutsDessert") |> PrefixedName

    /// <summary>
    ///   <para>fowl:CheeseNutsDessertCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#CheeseNutsDessertCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#CheeseNutsDessertCourse</seealso>
    let CheeseNutsDessertCourse =
        Prefixed_Name(fowl, "CheeseNutsDessertCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:Chicken</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:LightMeatFowl</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Chicken">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Chicken</seealso>
    let Chicken = Prefixed_Name(fowl, "Chicken") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Clams</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonOysterShellfish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Clams">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Clams</seealso>
    let Clams = Prefixed_Name(fowl, "Clams") |> PrefixedName
    /// <summary>
    ///   <para>fowl:ConsumableThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ConsumableThing">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ConsumableThing</seealso>
    let ConsumableThing = Prefixed_Name(fowl, "ConsumableThing") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Crab</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonOysterShellfish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Crab">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Crab</seealso>
    let Crab = Prefixed_Name(fowl, "Crab") |> PrefixedName
    /// <summary>
    ///   <para>fowl:DarkMeatFowl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DarkMeatFowl">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DarkMeatFowl</seealso>
    let DarkMeatFowl = Prefixed_Name(fowl, "DarkMeatFowl") |> PrefixedName
    /// <summary>
    ///   <para>fowl:DarkMeatFowlCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DarkMeatFowlCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DarkMeatFowlCourse</seealso>
    let DarkMeatFowlCourse = Prefixed_Name(fowl, "DarkMeatFowlCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Delicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Delicate">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Delicate</seealso>
    let Delicate = Prefixed_Name(fowl, "Delicate") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Dessert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Dessert">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Dessert</seealso>
    let Dessert = Prefixed_Name(fowl, "Dessert") |> PrefixedName
    /// <summary>
    ///   <para>fowl:DessertCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DessertCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DessertCourse</seealso>
    let DessertCourse = Prefixed_Name(fowl, "DessertCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Dry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Dry">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Dry</seealso>
    let Dry = Prefixed_Name(fowl, "Dry") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Duck</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:DarkMeatFowl</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Duck">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Duck</seealso>
    let Duck = Prefixed_Name(fowl, "Duck") |> PrefixedName
    /// <summary>
    ///   <para>fowl:EatingGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#EatingGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#EatingGrape</seealso>
    let EatingGrape = Prefixed_Name(fowl, "EatingGrape") |> PrefixedName
    /// <summary>
    ///   <para>fowl:EdibleThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#EdibleThing">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#EdibleThing</seealso>
    let EdibleThing = Prefixed_Name(fowl, "EdibleThing") |> PrefixedName
    /// <summary>
    ///   <para>fowl:FettucineAlfRedo</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:PastaWithHeavyCreamSauce</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FettucineAlfRedo">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FettucineAlfRedo</seealso>
    let FettucineAlfRedo = Prefixed_Name(fowl, "FettucineAlfRedo") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fish</seealso>
    let Fish = Prefixed_Name(fowl, "Fish") |> PrefixedName
    /// <summary>
    ///   <para>fowl:FishCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FishCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FishCourse</seealso>
    let FishCourse = Prefixed_Name(fowl, "FishCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Flounder</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:BlandFish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Flounder">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Flounder</seealso>
    let Flounder = Prefixed_Name(fowl, "Flounder") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Fowl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fowl">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fowl</seealso>
    let Fowl = Prefixed_Name(fowl, "Fowl") |> PrefixedName
    /// <summary>
    ///   <para>fowl:FraDiavolo</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:PastaWithSpicyRedSauce</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FraDiavolo">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FraDiavolo</seealso>
    let FraDiavolo = Prefixed_Name(fowl, "FraDiavolo") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Fruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fruit">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fruit</seealso>
    let Fruit = Prefixed_Name(fowl, "Fruit") |> PrefixedName
    /// <summary>
    ///   <para>fowl:FruitCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FruitCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FruitCourse</seealso>
    let FruitCourse = Prefixed_Name(fowl, "FruitCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Full</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Full">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Full</seealso>
    let Full = Prefixed_Name(fowl, "Full") |> PrefixedName
    /// <summary>
    ///   <para>fowl:GarlickyRoast</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SpicyRedMeat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#GarlickyRoast">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#GarlickyRoast</seealso>
    let GarlickyRoast = Prefixed_Name(fowl, "GarlickyRoast") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Goose</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:DarkMeatFowl</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Goose">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Goose</seealso>
    let Goose = Prefixed_Name(fowl, "Goose") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Grape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Grape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Grape</seealso>
    let Grape = Prefixed_Name(fowl, "Grape") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Halibut</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:BlandFish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Halibut">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Halibut</seealso>
    let Halibut = Prefixed_Name(fowl, "Halibut") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Juice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Juice">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Juice</seealso>
    let Juice = Prefixed_Name(fowl, "Juice") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Light</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Light">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Light</seealso>
    let Light = Prefixed_Name(fowl, "Light") |> PrefixedName
    /// <summary>
    ///   <para>fowl:LightMeatFowl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#LightMeatFowl">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#LightMeatFowl</seealso>
    let LightMeatFowl = Prefixed_Name(fowl, "LightMeatFowl") |> PrefixedName
    /// <summary>
    ///   <para>fowl:LightMeatFowlCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#LightMeatFowlCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#LightMeatFowlCourse</seealso>
    let LightMeatFowlCourse = Prefixed_Name(fowl, "LightMeatFowlCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Lobster</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonOysterShellfish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Lobster">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Lobster</seealso>
    let Lobster = Prefixed_Name(fowl, "Lobster") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Meal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Meal">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Meal</seealso>
    let Meal = Prefixed_Name(fowl, "Meal") |> PrefixedName
    /// <summary>
    ///   <para>fowl:MealCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#MealCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#MealCourse</seealso>
    let MealCourse = Prefixed_Name(fowl, "MealCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Meat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Meat">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Meat</seealso>
    let Meat = Prefixed_Name(fowl, "Meat") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Medium">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Medium</seealso>
    let Medium = Prefixed_Name(fowl, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>fowl:MixedFruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SweetFruit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#MixedFruit">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#MixedFruit</seealso>
    let MixedFruit = Prefixed_Name(fowl, "MixedFruit") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Moderate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Moderate">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Moderate</seealso>
    let Moderate = Prefixed_Name(fowl, "Moderate") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Mussels</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonOysterShellfish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Mussels">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Mussels</seealso>
    let Mussels = Prefixed_Name(fowl, "Mussels") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonBlandFish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonBlandFish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonBlandFish</seealso>
    let NonBlandFish = Prefixed_Name(fowl, "NonBlandFish") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonBlandFishCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonBlandFishCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonBlandFishCourse</seealso>
    let NonBlandFishCourse = Prefixed_Name(fowl, "NonBlandFishCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonConsumableThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonConsumableThing">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonConsumableThing</seealso>
    let NonConsumableThing = Prefixed_Name(fowl, "NonConsumableThing") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonOysterShellfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonOysterShellfish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonOysterShellfish</seealso>
    let NonOysterShellfish = Prefixed_Name(fowl, "NonOysterShellfish") |> PrefixedName

    /// <summary>
    ///   <para>fowl:NonOysterShellfishCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonOysterShellfishCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonOysterShellfishCourse</seealso>
    let NonOysterShellfishCourse =
        Prefixed_Name(fowl, "NonOysterShellfishCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:NonRedMeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonRedMeat">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonRedMeat</seealso>
    let NonRedMeat = Prefixed_Name(fowl, "NonRedMeat") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonRedMeatCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonRedMeatCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonRedMeatCourse</seealso>
    let NonRedMeatCourse = Prefixed_Name(fowl, "NonRedMeatCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonSpicyRedMeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSpicyRedMeat">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSpicyRedMeat</seealso>
    let NonSpicyRedMeat = Prefixed_Name(fowl, "NonSpicyRedMeat") |> PrefixedName

    /// <summary>
    ///   <para>fowl:NonSpicyRedMeatCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSpicyRedMeatCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSpicyRedMeatCourse</seealso>
    let NonSpicyRedMeatCourse =
        Prefixed_Name(fowl, "NonSpicyRedMeatCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:NonSweetFruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSweetFruit">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSweetFruit</seealso>
    let NonSweetFruit = Prefixed_Name(fowl, "NonSweetFruit") |> PrefixedName
    /// <summary>
    ///   <para>fowl:NonSweetFruitCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSweetFruitCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSweetFruitCourse</seealso>
    let NonSweetFruitCourse = Prefixed_Name(fowl, "NonSweetFruitCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Nuts</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:CheeseNutsDessert</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Nuts">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Nuts</seealso>
    let Nuts = Prefixed_Name(fowl, "Nuts") |> PrefixedName
    /// <summary>
    ///   <para>fowl:OffDry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OffDry">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OffDry</seealso>
    let OffDry = Prefixed_Name(fowl, "OffDry") |> PrefixedName

    /// <summary>
    ///   <para>fowl:OtherTomatoBasedFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OtherTomatoBasedFood">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OtherTomatoBasedFood</seealso>
    let OtherTomatoBasedFood =
        Prefixed_Name(fowl, "OtherTomatoBasedFood") |> PrefixedName

    /// <summary>
    ///   <para>fowl:OtherTomatoBasedFoodCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OtherTomatoBasedFoodCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OtherTomatoBasedFoodCourse</seealso>
    let OtherTomatoBasedFoodCourse =
        Prefixed_Name(fowl, "OtherTomatoBasedFoodCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:OysterShellfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OysterShellfish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OysterShellfish</seealso>
    let OysterShellfish = Prefixed_Name(fowl, "OysterShellfish") |> PrefixedName

    /// <summary>
    ///   <para>fowl:OysterShellfishCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OysterShellfishCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OysterShellfishCourse</seealso>
    let OysterShellfishCourse =
        Prefixed_Name(fowl, "OysterShellfishCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:Oysters</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:OysterShellfish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Oysters">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Oysters</seealso>
    let Oysters = Prefixed_Name(fowl, "Oysters") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Pasta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pasta">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pasta</seealso>
    let Pasta = Prefixed_Name(fowl, "Pasta") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithHeavyCreamCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithHeavyCreamCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithHeavyCreamCourse</seealso>
    let PastaWithHeavyCreamCourse =
        Prefixed_Name(fowl, "PastaWithHeavyCreamCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithHeavyCreamSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithHeavyCreamSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithHeavyCreamSauce</seealso>
    let PastaWithHeavyCreamSauce =
        Prefixed_Name(fowl, "PastaWithHeavyCreamSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithLightCreamCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithLightCreamCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithLightCreamCourse</seealso>
    let PastaWithLightCreamCourse =
        Prefixed_Name(fowl, "PastaWithLightCreamCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithLightCreamSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithLightCreamSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithLightCreamSauce</seealso>
    let PastaWithLightCreamSauce =
        Prefixed_Name(fowl, "PastaWithLightCreamSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithNonSpicyRedSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithNonSpicyRedSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithNonSpicyRedSauce</seealso>
    let PastaWithNonSpicyRedSauce =
        Prefixed_Name(fowl, "PastaWithNonSpicyRedSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithNonSpicyRedSauceCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithNonSpicyRedSauceCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithNonSpicyRedSauceCourse</seealso>
    let PastaWithNonSpicyRedSauceCourse =
        Prefixed_Name(fowl, "PastaWithNonSpicyRedSauceCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithRedSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithRedSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithRedSauce</seealso>
    let PastaWithRedSauce = Prefixed_Name(fowl, "PastaWithRedSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithSpicyRedSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithSpicyRedSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithSpicyRedSauce</seealso>
    let PastaWithSpicyRedSauce =
        Prefixed_Name(fowl, "PastaWithSpicyRedSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithSpicyRedSauceCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithSpicyRedSauceCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithSpicyRedSauceCourse</seealso>
    let PastaWithSpicyRedSauceCourse =
        Prefixed_Name(fowl, "PastaWithSpicyRedSauceCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithWhiteClamSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:PastaWithLightCreamSauce</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithWhiteClamSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithWhiteClamSauce</seealso>
    let PastaWithWhiteClamSauce =
        Prefixed_Name(fowl, "PastaWithWhiteClamSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:PastaWithWhiteSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithWhiteSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithWhiteSauce</seealso>
    let PastaWithWhiteSauce = Prefixed_Name(fowl, "PastaWithWhiteSauce") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Peaches</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SweetFruit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Peaches">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Peaches</seealso>
    let Peaches = Prefixed_Name(fowl, "Peaches") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Pie</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:SweetDessert</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pie">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pie</seealso>
    let Pie = Prefixed_Name(fowl, "Pie") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Pizza</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:OtherTomatoBasedFood</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pizza">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pizza</seealso>
    let Pizza = Prefixed_Name(fowl, "Pizza") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Pork</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonRedMeat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pork">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pork</seealso>
    let Pork = Prefixed_Name(fowl, "Pork") |> PrefixedName
    /// <summary>
    ///   <para>fowl:PotableLiquid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PotableLiquid">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PotableLiquid</seealso>
    let PotableLiquid = Prefixed_Name(fowl, "PotableLiquid") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Red</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Red">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Red</seealso>
    let Red = Prefixed_Name(fowl, "Red") |> PrefixedName
    /// <summary>
    ///   <para>fowl:RedMeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RedMeat">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RedMeat</seealso>
    let RedMeat = Prefixed_Name(fowl, "RedMeat") |> PrefixedName
    /// <summary>
    ///   <para>fowl:RedMeatCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RedMeatCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RedMeatCourse</seealso>
    let RedMeatCourse = Prefixed_Name(fowl, "RedMeatCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:RoastBeef</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonSpicyRedMeat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RoastBeef">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RoastBeef</seealso>
    let RoastBeef = Prefixed_Name(fowl, "RoastBeef") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Rose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Rose">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Rose</seealso>
    let Rose = Prefixed_Name(fowl, "Rose") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Scrod</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:BlandFish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Scrod">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Scrod</seealso>
    let Scrod = Prefixed_Name(fowl, "Scrod") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Seafood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Seafood">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Seafood</seealso>
    let Seafood = Prefixed_Name(fowl, "Seafood") |> PrefixedName
    /// <summary>
    ///   <para>fowl:SeafoodCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SeafoodCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SeafoodCourse</seealso>
    let SeafoodCourse = Prefixed_Name(fowl, "SeafoodCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Shellfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Shellfish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Shellfish</seealso>
    let Shellfish = Prefixed_Name(fowl, "Shellfish") |> PrefixedName
    /// <summary>
    ///   <para>fowl:ShellfishCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ShellfishCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ShellfishCourse</seealso>
    let ShellfishCourse = Prefixed_Name(fowl, "ShellfishCourse") |> PrefixedName

    /// <summary>
    ///   <para>fowl:SpaghettiWithTomatoSauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:PastaWithNonSpicyRedSauce</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpaghettiWithTomatoSauce">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpaghettiWithTomatoSauce</seealso>
    let SpaghettiWithTomatoSauce =
        Prefixed_Name(fowl, "SpaghettiWithTomatoSauce") |> PrefixedName

    /// <summary>
    ///   <para>fowl:SpicyRedMeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpicyRedMeat">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpicyRedMeat</seealso>
    let SpicyRedMeat = Prefixed_Name(fowl, "SpicyRedMeat") |> PrefixedName
    /// <summary>
    ///   <para>fowl:SpicyRedMeatCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpicyRedMeatCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpicyRedMeatCourse</seealso>
    let SpicyRedMeatCourse = Prefixed_Name(fowl, "SpicyRedMeatCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Steak</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonSpicyRedMeat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Steak">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Steak</seealso>
    let Steak = Prefixed_Name(fowl, "Steak") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Strong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Strong">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Strong</seealso>
    let Strong = Prefixed_Name(fowl, "Strong") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Sweet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Sweet">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Sweet</seealso>
    let Sweet = Prefixed_Name(fowl, "Sweet") |> PrefixedName
    /// <summary>
    ///   <para>fowl:SweetDessert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetDessert">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetDessert</seealso>
    let SweetDessert = Prefixed_Name(fowl, "SweetDessert") |> PrefixedName
    /// <summary>
    ///   <para>fowl:SweetDessertCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetDessertCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetDessertCourse</seealso>
    let SweetDessertCourse = Prefixed_Name(fowl, "SweetDessertCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:SweetFruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetFruit">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetFruit</seealso>
    let SweetFruit = Prefixed_Name(fowl, "SweetFruit") |> PrefixedName
    /// <summary>
    ///   <para>fowl:SweetFruitCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetFruitCourse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetFruitCourse</seealso>
    let SweetFruitCourse = Prefixed_Name(fowl, "SweetFruitCourse") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Swordfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonBlandFish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Swordfish">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Swordfish</seealso>
    let Swordfish = Prefixed_Name(fowl, "Swordfish") |> PrefixedName
    /// <summary>
    ///   <para>fowl:ThompsonSeedless</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:EatingGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ThompsonSeedless">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ThompsonSeedless</seealso>
    let ThompsonSeedless = Prefixed_Name(fowl, "ThompsonSeedless") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Tuna</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonBlandFish</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Tuna">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Tuna</seealso>
    let Tuna = Prefixed_Name(fowl, "Tuna") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:LightMeatFowl</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Turkey">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Turkey</seealso>
    let Turkey = Prefixed_Name(fowl, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Veal</para>
    /// </summary>
    /// <remarks>
    ///   <para>fowl:NonSpicyRedMeat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Veal">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Veal</seealso>
    let Veal = Prefixed_Name(fowl, "Veal") |> PrefixedName
    /// <summary>
    ///   <para>fowl:White</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#White">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#White</seealso>
    let White = Prefixed_Name(fowl, "White") |> PrefixedName
    /// <summary>
    ///   <para>fowl:Wine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Wine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Wine</seealso>
    let Wine = Prefixed_Name(fowl, "Wine") |> PrefixedName
    /// <summary>
    ///   <para>fowl:course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#course">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#course</seealso>
    let course = Prefixed_Name(fowl, "course") |> PrefixedName
    /// <summary>
    ///   <para>fowl:hasDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#hasDrink">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#hasDrink</seealso>
    let hasDrink = Prefixed_Name(fowl, "hasDrink") |> PrefixedName
    /// <summary>
    ///   <para>fowl:hasFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#hasFood">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#hasFood</seealso>
    let hasFood = Prefixed_Name(fowl, "hasFood") |> PrefixedName
    /// <summary>
    ///   <para>fowl:madeFromFruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#madeFromFruit">http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#madeFromFruit</seealso>
    let madeFromFruit = Prefixed_Name(fowl, "madeFromFruit") |> PrefixedName
