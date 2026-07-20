namespace http.www.w3.org.TR._2003.PR_owl_guide_20031209.food.hash

open DoxAletheia

module fowl =
    let _namespace_name = "http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Bananas"></see>
    /// </summary>
    let Bananas = _prefix "Bananas"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetFruit"></see>
    /// </summary>
    let SweetFruit = _prefix "SweetFruit"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BeefCurry"></see>
    /// </summary>
    let BeefCurry = _prefix "BeefCurry"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpicyRedMeat"></see>
    /// </summary>
    let SpicyRedMeat = _prefix "SpicyRedMeat"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BlandFish"></see>
    /// </summary>
    let BlandFish = _prefix "BlandFish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonBlandFish"></see>
    /// </summary>
    let NonBlandFish = _prefix "NonBlandFish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#BlandFishCourse"></see>
    /// </summary>
    let BlandFishCourse = _prefix "BlandFishCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#hasDrink"></see>
    /// </summary>
    let hasDrink = _prefix "hasDrink"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Delicate"></see>
    /// </summary>
    let Delicate = _prefix "Delicate"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#MealCourse"></see>
    /// </summary>
    let MealCourse = _prefix "MealCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#hasFood"></see>
    /// </summary>
    let hasFood = _prefix "hasFood"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Cake"></see>
    /// </summary>
    let Cake = _prefix "Cake"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetDessert"></see>
    /// </summary>
    let SweetDessert = _prefix "SweetDessert"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Cheese"></see>
    /// </summary>
    let Cheese = _prefix "Cheese"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#CheeseNutsDessert"></see>
    /// </summary>
    let CheeseNutsDessert = _prefix "CheeseNutsDessert"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Dessert"></see>
    /// </summary>
    let Dessert = _prefix "Dessert"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#CheeseNutsDessertCourse"></see>
    /// </summary>
    let CheeseNutsDessertCourse = _prefix "CheeseNutsDessertCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Red"></see>
    /// </summary>
    let Red = _prefix "Red"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Chicken"></see>
    /// </summary>
    let Chicken = _prefix "Chicken"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#LightMeatFowl"></see>
    /// </summary>
    let LightMeatFowl = _prefix "LightMeatFowl"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Clams"></see>
    /// </summary>
    let Clams = _prefix "Clams"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonOysterShellfish"></see>
    /// </summary>
    let NonOysterShellfish = _prefix "NonOysterShellfish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ConsumableThing"></see>
    /// </summary>
    let ConsumableThing = _prefix "ConsumableThing"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Crab"></see>
    /// </summary>
    let Crab = _prefix "Crab"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DarkMeatFowl"></see>
    /// </summary>
    let DarkMeatFowl = _prefix "DarkMeatFowl"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fowl"></see>
    /// </summary>
    let Fowl = _prefix "Fowl"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DarkMeatFowlCourse"></see>
    /// </summary>
    let DarkMeatFowlCourse = _prefix "DarkMeatFowlCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Light"></see>
    /// </summary>
    let Light = _prefix "Light"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Dry"></see>
    /// </summary>
    let Dry = _prefix "Dry"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#EdibleThing"></see>
    /// </summary>
    let EdibleThing = _prefix "EdibleThing"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Fruit"></see>
    /// </summary>
    let Fruit = _prefix "Fruit"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#DessertCourse"></see>
    /// </summary>
    let DessertCourse = _prefix "DessertCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Full"></see>
    /// </summary>
    let Full = _prefix "Full"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Strong"></see>
    /// </summary>
    let Strong = _prefix "Strong"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Sweet"></see>
    /// </summary>
    let Sweet = _prefix "Sweet"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Duck"></see>
    /// </summary>
    let Duck = _prefix "Duck"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#EatingGrape"></see>
    /// </summary>
    let EatingGrape = _prefix "EatingGrape"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Grape"></see>
    /// </summary>
    let Grape = _prefix "Grape"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FettucineAlfRedo"></see>
    /// </summary>
    let FettucineAlfRedo = _prefix "FettucineAlfRedo"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithHeavyCreamSauce"></see>
    /// </summary>
    let PastaWithHeavyCreamSauce = _prefix "PastaWithHeavyCreamSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Seafood"></see>
    /// </summary>
    let Seafood = _prefix "Seafood"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Shellfish"></see>
    /// </summary>
    let Shellfish = _prefix "Shellfish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FishCourse"></see>
    /// </summary>
    let FishCourse = _prefix "FishCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Medium"></see>
    /// </summary>
    let Medium = _prefix "Medium"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Flounder"></see>
    /// </summary>
    let Flounder = _prefix "Flounder"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FraDiavolo"></see>
    /// </summary>
    let FraDiavolo = _prefix "FraDiavolo"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithSpicyRedSauce"></see>
    /// </summary>
    let PastaWithSpicyRedSauce = _prefix "PastaWithSpicyRedSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSweetFruit"></see>
    /// </summary>
    let NonSweetFruit = _prefix "NonSweetFruit"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#FruitCourse"></see>
    /// </summary>
    let FruitCourse = _prefix "FruitCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#White"></see>
    /// </summary>
    let White = _prefix "White"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#GarlickyRoast"></see>
    /// </summary>
    let GarlickyRoast = _prefix "GarlickyRoast"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Goose"></see>
    /// </summary>
    let Goose = _prefix "Goose"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Halibut"></see>
    /// </summary>
    let Halibut = _prefix "Halibut"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Juice"></see>
    /// </summary>
    let Juice = _prefix "Juice"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#madeFromFruit"></see>
    /// </summary>
    let madeFromFruit = _prefix "madeFromFruit"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PotableLiquid"></see>
    /// </summary>
    let PotableLiquid = _prefix "PotableLiquid"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#LightMeatFowlCourse"></see>
    /// </summary>
    let LightMeatFowlCourse = _prefix "LightMeatFowlCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Moderate"></see>
    /// </summary>
    let Moderate = _prefix "Moderate"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Lobster"></see>
    /// </summary>
    let Lobster = _prefix "Lobster"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Meal"></see>
    /// </summary>
    let Meal = _prefix "Meal"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#course"></see>
    /// </summary>
    let course = _prefix "course"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Wine"></see>
    /// </summary>
    let Wine = _prefix "Wine"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Meat"></see>
    /// </summary>
    let Meat = _prefix "Meat"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#MixedFruit"></see>
    /// </summary>
    let MixedFruit = _prefix "MixedFruit"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Mussels"></see>
    /// </summary>
    let Mussels = _prefix "Mussels"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonBlandFishCourse"></see>
    /// </summary>
    let NonBlandFishCourse = _prefix "NonBlandFishCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonConsumableThing"></see>
    /// </summary>
    let NonConsumableThing = _prefix "NonConsumableThing"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OysterShellfish"></see>
    /// </summary>
    let OysterShellfish = _prefix "OysterShellfish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonOysterShellfishCourse"></see>
    /// </summary>
    let NonOysterShellfishCourse = _prefix "NonOysterShellfishCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonRedMeat"></see>
    /// </summary>
    let NonRedMeat = _prefix "NonRedMeat"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RedMeat"></see>
    /// </summary>
    let RedMeat = _prefix "RedMeat"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonRedMeatCourse"></see>
    /// </summary>
    let NonRedMeatCourse = _prefix "NonRedMeatCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSpicyRedMeat"></see>
    /// </summary>
    let NonSpicyRedMeat = _prefix "NonSpicyRedMeat"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSpicyRedMeatCourse"></see>
    /// </summary>
    let NonSpicyRedMeatCourse = _prefix "NonSpicyRedMeatCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#NonSweetFruitCourse"></see>
    /// </summary>
    let NonSweetFruitCourse = _prefix "NonSweetFruitCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OffDry"></see>
    /// </summary>
    let OffDry = _prefix "OffDry"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Nuts"></see>
    /// </summary>
    let Nuts = _prefix "Nuts"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OtherTomatoBasedFood"></see>
    /// </summary>
    let OtherTomatoBasedFood = _prefix "OtherTomatoBasedFood"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pasta"></see>
    /// </summary>
    let Pasta = _prefix "Pasta"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OtherTomatoBasedFoodCourse"></see>
    /// </summary>
    let OtherTomatoBasedFoodCourse = _prefix "OtherTomatoBasedFoodCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#OysterShellfishCourse"></see>
    /// </summary>
    let OysterShellfishCourse = _prefix "OysterShellfishCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Oysters"></see>
    /// </summary>
    let Oysters = _prefix "Oysters"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithHeavyCreamCourse"></see>
    /// </summary>
    let PastaWithHeavyCreamCourse = _prefix "PastaWithHeavyCreamCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithWhiteSauce"></see>
    /// </summary>
    let PastaWithWhiteSauce = _prefix "PastaWithWhiteSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithLightCreamCourse"></see>
    /// </summary>
    let PastaWithLightCreamCourse = _prefix "PastaWithLightCreamCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithLightCreamSauce"></see>
    /// </summary>
    let PastaWithLightCreamSauce = _prefix "PastaWithLightCreamSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithNonSpicyRedSauce"></see>
    /// </summary>
    let PastaWithNonSpicyRedSauce = _prefix "PastaWithNonSpicyRedSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithRedSauce"></see>
    /// </summary>
    let PastaWithRedSauce = _prefix "PastaWithRedSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithNonSpicyRedSauceCourse"></see>
    /// </summary>
    let PastaWithNonSpicyRedSauceCourse = _prefix "PastaWithNonSpicyRedSauceCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithSpicyRedSauceCourse"></see>
    /// </summary>
    let PastaWithSpicyRedSauceCourse = _prefix "PastaWithSpicyRedSauceCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#PastaWithWhiteClamSauce"></see>
    /// </summary>
    let PastaWithWhiteClamSauce = _prefix "PastaWithWhiteClamSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Peaches"></see>
    /// </summary>
    let Peaches = _prefix "Peaches"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pie"></see>
    /// </summary>
    let Pie = _prefix "Pie"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pizza"></see>
    /// </summary>
    let Pizza = _prefix "Pizza"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Pork"></see>
    /// </summary>
    let Pork = _prefix "Pork"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RedMeatCourse"></see>
    /// </summary>
    let RedMeatCourse = _prefix "RedMeatCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#RoastBeef"></see>
    /// </summary>
    let RoastBeef = _prefix "RoastBeef"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Rose"></see>
    /// </summary>
    let Rose = _prefix "Rose"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Scrod"></see>
    /// </summary>
    let Scrod = _prefix "Scrod"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SeafoodCourse"></see>
    /// </summary>
    let SeafoodCourse = _prefix "SeafoodCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ShellfishCourse"></see>
    /// </summary>
    let ShellfishCourse = _prefix "ShellfishCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpaghettiWithTomatoSauce"></see>
    /// </summary>
    let SpaghettiWithTomatoSauce = _prefix "SpaghettiWithTomatoSauce"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SpicyRedMeatCourse"></see>
    /// </summary>
    let SpicyRedMeatCourse = _prefix "SpicyRedMeatCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Steak"></see>
    /// </summary>
    let Steak = _prefix "Steak"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetDessertCourse"></see>
    /// </summary>
    let SweetDessertCourse = _prefix "SweetDessertCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#SweetFruitCourse"></see>
    /// </summary>
    let SweetFruitCourse = _prefix "SweetFruitCourse"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Swordfish"></see>
    /// </summary>
    let Swordfish = _prefix "Swordfish"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#ThompsonSeedless"></see>
    /// </summary>
    let ThompsonSeedless = _prefix "ThompsonSeedless"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Tuna"></see>
    /// </summary>
    let Tuna = _prefix "Tuna"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Turkey"></see>
    /// </summary>
    let Turkey = _prefix "Turkey"
    /// <summary>
    ///   <see href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#Veal"></see>
    /// </summary>
    let Veal = _prefix "Veal"
