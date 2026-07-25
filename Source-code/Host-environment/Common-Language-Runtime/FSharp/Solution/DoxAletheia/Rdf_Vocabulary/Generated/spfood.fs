namespace http.kmi._open.ac.uk.projects.smartproducts.ontologies.food.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spfood =
    let _namespace_iri = Namespace_Iri spfood |> NamespaceIRI

    /// <summary>
    ///   <para>spfood:RegionalCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RegionalCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RegionalCuisineRecipe</seealso>
    let RegionalCuisineRecipe =
        Prefixed_Name(spfood, "RegionalCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Cheese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cheese">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cheese</seealso>
    let Cheese = Prefixed_Name(spfood, "Cheese") |> PrefixedName

    /// <summary>
    ///   <para>spfood:ChineseCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ChineseCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ChineseCuisineRecipe</seealso>
    let ChineseCuisineRecipe =
        Prefixed_Name(spfood, "ChineseCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:ConcreteDrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteDrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteDrinkItem</seealso>
    let ConcreteDrinkItem = Prefixed_Name(spfood, "ConcreteDrinkItem") |> PrefixedName

    /// <summary>
    ///   <para>spfood:ConcreteFoodOrDrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteFoodOrDrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteFoodOrDrinkItem</seealso>
    let ConcreteFoodOrDrinkItem =
        Prefixed_Name(spfood, "ConcreteFoodOrDrinkItem") |> PrefixedName

    /// <summary>
    ///   <para>spfood:VirtualFoodOrDrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VirtualFoodOrDrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VirtualFoodOrDrinkItem</seealso>
    let VirtualFoodOrDrinkItem =
        Prefixed_Name(spfood, "VirtualFoodOrDrinkItem") |> PrefixedName

    /// <summary>
    ///   <para>spfood:CookingActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingActivity">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingActivity</seealso>
    let CookingActivity = Prefixed_Name(spfood, "CookingActivity") |> PrefixedName
    /// <summary>
    ///   <para>spfood:numberOfGuests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#numberOfGuests">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#numberOfGuests</seealso>
    let numberOfGuests = Prefixed_Name(spfood, "numberOfGuests") |> PrefixedName

    /// <summary>
    ///   <para>spfood:AmericanCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#AmericanCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#AmericanCuisineRecipe</seealso>
    let AmericanCuisineRecipe =
        Prefixed_Name(spfood, "AmericanCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:AtomicFoodOrDrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#AtomicFoodOrDrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#AtomicFoodOrDrinkItem</seealso>
    let AtomicFoodOrDrinkItem =
        Prefixed_Name(spfood, "AtomicFoodOrDrinkItem") |> PrefixedName

    /// <summary>
    ///   <para>spfood:FoodOrDrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrinkItem</seealso>
    let FoodOrDrinkItem = Prefixed_Name(spfood, "FoodOrDrinkItem") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Oven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Oven">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Oven</seealso>
    let Oven = Prefixed_Name(spfood, "Oven") |> PrefixedName

    /// <summary>
    ///   <para>spfood:RecipeCookingTimePreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeCookingTimePreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeCookingTimePreference</seealso>
    let RecipeCookingTimePreference =
        Prefixed_Name(spfood, "RecipeCookingTimePreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealNutritionPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealNutritionPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealNutritionPreference</seealso>
    let MealNutritionPreference =
        Prefixed_Name(spfood, "MealNutritionPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealPreference</seealso>
    let MealPreference = Prefixed_Name(spfood, "MealPreference") |> PrefixedName
    /// <summary>
    ///   <para>spfood:MealStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealStructure">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealStructure</seealso>
    let MealStructure = Prefixed_Name(spfood, "MealStructure") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Appetizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:MealCourseType</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Appetizer">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Appetizer</seealso>
    let Appetizer = Prefixed_Name(spfood, "Appetizer") |> PrefixedName
    /// <summary>
    ///   <para>spfood:BakingOven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#BakingOven">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#BakingOven</seealso>
    let BakingOven = Prefixed_Name(spfood, "BakingOven") |> PrefixedName
    /// <summary>
    ///   <para>spfood:MealCourseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealCourseType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealCourseType</seealso>
    let MealCourseType = Prefixed_Name(spfood, "MealCourseType") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Disease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Disease">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Disease</seealso>
    let Disease = Prefixed_Name(spfood, "Disease") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FoodOrDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrink">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrink</seealso>
    let FoodOrDrink = Prefixed_Name(spfood, "FoodOrDrink") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FoodOrDrinkMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrinkMatter">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrinkMatter</seealso>
    let FoodOrDrinkMatter = Prefixed_Name(spfood, "FoodOrDrinkMatter") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Boiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:CookingTaskType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Boiling">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Boiling</seealso>
    let Boiling = Prefixed_Name(spfood, "Boiling") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Nutrient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Nutrient">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Nutrient</seealso>
    let Nutrient = Prefixed_Name(spfood, "Nutrient") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Cholesterol</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:Nutrient</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cholesterol">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cholesterol</seealso>
    let Cholesterol = Prefixed_Name(spfood, "Cholesterol") |> PrefixedName
    /// <summary>
    ///   <para>spfood:ConcreteFoodItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteFoodItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteFoodItem</seealso>
    let ConcreteFoodItem = Prefixed_Name(spfood, "ConcreteFoodItem") |> PrefixedName
    /// <summary>
    ///   <para>spfood:IngredientPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IngredientPortion">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IngredientPortion</seealso>
    let IngredientPortion = Prefixed_Name(spfood, "IngredientPortion") |> PrefixedName
    /// <summary>
    ///   <para>spfood:KitchenTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#KitchenTool">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#KitchenTool</seealso>
    let KitchenTool = Prefixed_Name(spfood, "KitchenTool") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Cutting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:CookingTaskType</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cutting">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cutting</seealso>
    let Cutting = Prefixed_Name(spfood, "Cutting") |> PrefixedName
    /// <summary>
    ///   <para>spfood:MealCourseRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealCourseRole">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealCourseRole</seealso>
    let MealCourseRole = Prefixed_Name(spfood, "MealCourseRole") |> PrefixedName
    /// <summary>
    ///   <para>spfood:DiabeticDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:DietType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DiabeticDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DiabeticDiet</seealso>
    let DiabeticDiet = Prefixed_Name(spfood, "DiabeticDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:RecipePreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipePreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipePreference</seealso>
    let RecipePreference = Prefixed_Name(spfood, "RecipePreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:EnergyQuantityInCalories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#EnergyQuantityInCalories">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#EnergyQuantityInCalories</seealso>
    let EnergyQuantityInCalories =
        Prefixed_Name(spfood, "EnergyQuantityInCalories") |> PrefixedName

    /// <summary>
    ///   <para>spfood:BritishCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#BritishCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#BritishCuisineRecipe</seealso>
    let BritishCuisineRecipe =
        Prefixed_Name(spfood, "BritishCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Stilton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Stilton">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Stilton</seealso>
    let Stilton = Prefixed_Name(spfood, "Stilton") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Turkey">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Turkey</seealso>
    let Turkey = Prefixed_Name(spfood, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>spfood:VegetableOil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VegetableOil">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VegetableOil</seealso>
    let VegetableOil = Prefixed_Name(spfood, "VegetableOil") |> PrefixedName
    /// <summary>
    ///   <para>spfood:courseValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#courseValue">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#courseValue</seealso>
    let courseValue = Prefixed_Name(spfood, "courseValue") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasExpiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasExpiryDate">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasExpiryDate</seealso>
    let hasExpiryDate = Prefixed_Name(spfood, "hasExpiryDate") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Carbohydrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:Nutrient</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Carbohydrate">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Carbohydrate</seealso>
    let Carbohydrate = Prefixed_Name(spfood, "Carbohydrate") |> PrefixedName

    /// <summary>
    ///   <para>spfood:CompositeFoodOrDrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CompositeFoodOrDrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CompositeFoodOrDrinkItem</seealso>
    let CompositeFoodOrDrinkItem =
        Prefixed_Name(spfood, "CompositeFoodOrDrinkItem") |> PrefixedName

    /// <summary>
    ///   <para>spfood:FoodItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodItem</seealso>
    let FoodItem = Prefixed_Name(spfood, "FoodItem") |> PrefixedName
    /// <summary>
    ///   <para>spfood:CookingGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingGuide">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingGuide</seealso>
    let CookingGuide = Prefixed_Name(spfood, "CookingGuide") |> PrefixedName
    /// <summary>
    ///   <para>spfood:DairyFreeDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DairyFreeDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DairyFreeDiet</seealso>
    let DairyFreeDiet = Prefixed_Name(spfood, "DairyFreeDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:DietType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DietType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DietType</seealso>
    let DietType = Prefixed_Name(spfood, "DietType") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Dessert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:MealCourseType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Dessert">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Dessert</seealso>
    let Dessert = Prefixed_Name(spfood, "Dessert") |> PrefixedName
    /// <summary>
    ///   <para>spfood:DessertCourseRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DessertCourseRole">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DessertCourseRole</seealso>
    let DessertCourseRole = Prefixed_Name(spfood, "DessertCourseRole") |> PrefixedName
    /// <summary>
    ///   <para>spfood:DishPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DishPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DishPreference</seealso>
    let DishPreference = Prefixed_Name(spfood, "DishPreference") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Drinks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:MealCourseType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Drinks">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Drinks</seealso>
    let Drinks = Prefixed_Name(spfood, "Drinks") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Easy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>spfood:CookingDifficultyCategory</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Easy">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Easy</seealso>
    let Easy = Prefixed_Name(spfood, "Easy") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Expert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:CookingDifficultyCategory</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Expert">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Expert</seealso>
    let Expert = Prefixed_Name(spfood, "Expert") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Fat</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:Nutrient</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fat">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fat</seealso>
    let Fat = Prefixed_Name(spfood, "Fat") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FishProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FishProduct">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FishProduct</seealso>
    let FishProduct = Prefixed_Name(spfood, "FishProduct") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Food">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Food</seealso>
    let Food = Prefixed_Name(spfood, "Food") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FoodPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodPreference</seealso>
    let FoodPreference = Prefixed_Name(spfood, "FoodPreference") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FoodProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodProduct">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodProduct</seealso>
    let FoodProduct = Prefixed_Name(spfood, "FoodProduct") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Frying</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:CookingTaskType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Frying">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Frying</seealso>
    let Frying = Prefixed_Name(spfood, "Frying") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FryingPan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FryingPan">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FryingPan</seealso>
    let FryingPan = Prefixed_Name(spfood, "FryingPan") |> PrefixedName

    /// <summary>
    ///   <para>spfood:GermanCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GermanCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GermanCuisineRecipe</seealso>
    let GermanCuisineRecipe =
        Prefixed_Name(spfood, "GermanCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MediterraneanCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MediterraneanCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MediterraneanCuisineRecipe</seealso>
    let MediterraneanCuisineRecipe =
        Prefixed_Name(spfood, "MediterraneanCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Grill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Grill">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Grill</seealso>
    let Grill = Prefixed_Name(spfood, "Grill") |> PrefixedName

    /// <summary>
    ///   <para>spfood:IndianCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IndianCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IndianCuisineRecipe</seealso>
    let IndianCuisineRecipe =
        Prefixed_Name(spfood, "IndianCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:IrishCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IrishCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IrishCuisineRecipe</seealso>
    let IrishCuisineRecipe = Prefixed_Name(spfood, "IrishCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:ItalianCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ItalianCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ItalianCuisineRecipe</seealso>
    let ItalianCuisineRecipe =
        Prefixed_Name(spfood, "ItalianCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:LowFatDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#LowFatDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#LowFatDiet</seealso>
    let LowFatDiet = Prefixed_Name(spfood, "LowFatDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:LowInSaltDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#LowInSaltDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#LowInSaltDiet</seealso>
    let LowInSaltDiet = Prefixed_Name(spfood, "LowInSaltDiet") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MassQuantityInPounds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MassQuantityInPounds">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MassQuantityInPounds</seealso>
    let MassQuantityInPounds =
        Prefixed_Name(spfood, "MassQuantityInPounds") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MaxCaloriesPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MaxCaloriesPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MaxCaloriesPreference</seealso>
    let MaxCaloriesPreference =
        Prefixed_Name(spfood, "MaxCaloriesPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:NutritionPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutritionPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutritionPreference</seealso>
    let NutritionPreference =
        Prefixed_Name(spfood, "NutritionPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealContext">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealContext</seealso>
    let MealContext = Prefixed_Name(spfood, "MealContext") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealMaxNutritionEnergyPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealMaxNutritionEnergyPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealMaxNutritionEnergyPreference</seealso>
    let MealMaxNutritionEnergyPreference =
        Prefixed_Name(spfood, "MealMaxNutritionEnergyPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealNutritionEnergyPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealNutritionEnergyPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealNutritionEnergyPreference</seealso>
    let MealNutritionEnergyPreference =
        Prefixed_Name(spfood, "MealNutritionEnergyPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealMinNutritionEnergyPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealMinNutritionEnergyPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealMinNutritionEnergyPreference</seealso>
    let MealMinNutritionEnergyPreference =
        Prefixed_Name(spfood, "MealMinNutritionEnergyPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Sodium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:Nutrient</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Sodium">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Sodium</seealso>
    let Sodium = Prefixed_Name(spfood, "Sodium") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Soup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>spfood:MealCourseType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Soup">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Soup</seealso>
    let Soup = Prefixed_Name(spfood, "Soup") |> PrefixedName

    /// <summary>
    ///   <para>spfood:SpanishCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#SpanishCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#SpanishCuisineRecipe</seealso>
    let SpanishCuisineRecipe =
        Prefixed_Name(spfood, "SpanishCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Steamer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Steamer">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Steamer</seealso>
    let Steamer = Prefixed_Name(spfood, "Steamer") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Store</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Store">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Store</seealso>
    let Store = Prefixed_Name(spfood, "Store") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Supermarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Supermarket">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Supermarket</seealso>
    let Supermarket = Prefixed_Name(spfood, "Supermarket") |> PrefixedName
    /// <summary>
    ///   <para>spfood:TESCO</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:Supermarket</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#TESCO">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#TESCO</seealso>
    let TESCO = Prefixed_Name(spfood, "TESCO") |> PrefixedName
    /// <summary>
    ///   <para>spfood:ThaiCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ThaiCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ThaiCuisineRecipe</seealso>
    let ThaiCuisineRecipe = Prefixed_Name(spfood, "ThaiCuisineRecipe") |> PrefixedName
    /// <summary>
    ///   <para>spfood:TimeOfDayMealType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#TimeOfDayMealType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#TimeOfDayMealType</seealso>
    let TimeOfDayMealType = Prefixed_Name(spfood, "TimeOfDayMealType") |> PrefixedName
    /// <summary>
    ///   <para>spfood:VegetarianDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VegetarianDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VegetarianDiet</seealso>
    let VegetarianDiet = Prefixed_Name(spfood, "VegetarianDiet") |> PrefixedName

    /// <summary>
    ///   <para>spfood:VietnameseCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VietnameseCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VietnameseCuisineRecipe</seealso>
    let VietnameseCuisineRecipe =
        Prefixed_Name(spfood, "VietnameseCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:VolumeQuantityInCups</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VolumeQuantityInCups">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VolumeQuantityInCups</seealso>
    let VolumeQuantityInCups =
        Prefixed_Name(spfood, "VolumeQuantityInCups") |> PrefixedName

    /// <summary>
    ///   <para>spfood:VolumeQuantityInTableSpoons</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VolumeQuantityInTableSpoons">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VolumeQuantityInTableSpoons</seealso>
    let VolumeQuantityInTableSpoons =
        Prefixed_Name(spfood, "VolumeQuantityInTableSpoons") |> PrefixedName

    /// <summary>
    ///   <para>spfood:canBeReplacedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#canBeReplacedWith">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#canBeReplacedWith</seealso>
    let canBeReplacedWith = Prefixed_Name(spfood, "canBeReplacedWith") |> PrefixedName

    /// <summary>
    ///   <para>spfood:hasAvailableIngredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasAvailableIngredient">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasAvailableIngredient</seealso>
    let hasAvailableIngredient =
        Prefixed_Name(spfood, "hasAvailableIngredient") |> PrefixedName

    /// <summary>
    ///   <para>spfood:hasCookingTaskType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasCookingTaskType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasCookingTaskType</seealso>
    let hasCookingTaskType = Prefixed_Name(spfood, "hasCookingTaskType") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasDefaultPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDefaultPortion">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDefaultPortion</seealso>
    let hasDefaultPortion = Prefixed_Name(spfood, "hasDefaultPortion") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasDietType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDietType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDietType</seealso>
    let hasDietType = Prefixed_Name(spfood, "hasDietType") |> PrefixedName

    /// <summary>
    ///   <para>spfood:hasDifficultyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDifficultyCategory">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDifficultyCategory</seealso>
    let hasDifficultyCategory =
        Prefixed_Name(spfood, "hasDifficultyCategory") |> PrefixedName

    /// <summary>
    ///   <para>spfood:hasGuest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasGuest">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasGuest</seealso>
    let hasGuest = Prefixed_Name(spfood, "hasGuest") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasHealthProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasHealthProfile">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasHealthProfile</seealso>
    let hasHealthProfile = Prefixed_Name(spfood, "hasHealthProfile") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasMealStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasMealStructure">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasMealStructure</seealso>
    let hasMealStructure = Prefixed_Name(spfood, "hasMealStructure") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasNutrient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasNutrient">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasNutrient</seealso>
    let hasNutrient = Prefixed_Name(spfood, "hasNutrient") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasScore">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasScore</seealso>
    let hasScore = Prefixed_Name(spfood, "hasScore") |> PrefixedName
    /// <summary>
    ///   <para>spfood:impliesPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#impliesPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#impliesPreference</seealso>
    let impliesPreference = Prefixed_Name(spfood, "impliesPreference") |> PrefixedName
    /// <summary>
    ///   <para>spfood:producedByRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#producedByRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#producedByRecipe</seealso>
    let producedByRecipe = Prefixed_Name(spfood, "producedByRecipe") |> PrefixedName
    /// <summary>
    ///   <para>spfood:producesFoodItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#producesFoodItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#producesFoodItem</seealso>
    let producesFoodItem = Prefixed_Name(spfood, "producesFoodItem") |> PrefixedName
    /// <summary>
    ///   <para>spfood:suitableForDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#suitableForDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#suitableForDiet</seealso>
    let suitableForDiet = Prefixed_Name(spfood, "suitableForDiet") |> PrefixedName

    /// <summary>
    ///   <para>spfood:suitableForMealCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#suitableForMealCourse">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#suitableForMealCourse</seealso>
    let suitableForMealCourse =
        Prefixed_Name(spfood, "suitableForMealCourse") |> PrefixedName

    /// <summary>
    ///   <para>spfood:CaribbeanCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CaribbeanCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CaribbeanCuisineRecipe</seealso>
    let CaribbeanCuisineRecipe =
        Prefixed_Name(spfood, "CaribbeanCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:VeganDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>spfood:DietType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VeganDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VeganDiet</seealso>
    let VeganDiet = Prefixed_Name(spfood, "VeganDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:courseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#courseType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#courseType</seealso>
    let courseType = Prefixed_Name(spfood, "courseType") |> PrefixedName
    /// <summary>
    ///   <para>spfood:cup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://kmi.open.ac.uk/projects/smartproducts/ontologies/generic.owl#VolumeMeasurementUnit&gt;</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#cup">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#cup</seealso>
    let cup = Prefixed_Name(spfood, "cup") |> PrefixedName
    /// <summary>
    ///   <para>spfood:hasMealCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasMealCourse">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasMealCourse</seealso>
    let hasMealCourse = Prefixed_Name(spfood, "hasMealCourse") |> PrefixedName
    /// <summary>
    ///   <para>spfood:DrinkItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DrinkItem">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DrinkItem</seealso>
    let DrinkItem = Prefixed_Name(spfood, "DrinkItem") |> PrefixedName

    /// <summary>
    ///   <para>spfood:CookingDifficultyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingDifficultyCategory">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingDifficultyCategory</seealso>
    let CookingDifficultyCategory =
        Prefixed_Name(spfood, "CookingDifficultyCategory") |> PrefixedName

    /// <summary>
    ///   <para>spfood:DairyProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DairyProduct">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DairyProduct</seealso>
    let DairyProduct = Prefixed_Name(spfood, "DairyProduct") |> PrefixedName

    /// <summary>
    ///   <para>spfood:DefaultIngredientPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DefaultIngredientPortion">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DefaultIngredientPortion</seealso>
    let DefaultIngredientPortion =
        Prefixed_Name(spfood, "DefaultIngredientPortion") |> PrefixedName

    /// <summary>
    ///   <para>spfood:DietAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DietAssessment">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DietAssessment</seealso>
    let DietAssessment = Prefixed_Name(spfood, "DietAssessment") |> PrefixedName
    /// <summary>
    ///   <para>spfood:HealthProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#HealthProfile">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#HealthProfile</seealso>
    let HealthProfile = Prefixed_Name(spfood, "HealthProfile") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Drink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Drink">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Drink</seealso>
    let Drink = Prefixed_Name(spfood, "Drink") |> PrefixedName
    /// <summary>
    ///   <para>spfood:EggFreeDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#EggFreeDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#EggFreeDiet</seealso>
    let EggFreeDiet = Prefixed_Name(spfood, "EggFreeDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:SideCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:MealCourseType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#SideCourse">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#SideCourse</seealso>
    let SideCourse = Prefixed_Name(spfood, "SideCourse") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FingerFood</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FingerFood">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FingerFood</seealso>
    let FingerFood = Prefixed_Name(spfood, "FingerFood") |> PrefixedName
    /// <summary>
    ///   <para>spfood:FoodMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodMatter">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodMatter</seealso>
    let FoodMatter = Prefixed_Name(spfood, "FoodMatter") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fridge">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fridge</seealso>
    let Fridge = Prefixed_Name(spfood, "Fridge") |> PrefixedName
    /// <summary>
    ///   <para>spfood:GlutenFreeDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GlutenFreeDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GlutenFreeDiet</seealso>
    let GlutenFreeDiet = Prefixed_Name(spfood, "GlutenFreeDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Ingredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Ingredient">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Ingredient</seealso>
    let Ingredient = Prefixed_Name(spfood, "Ingredient") |> PrefixedName

    /// <summary>
    ///   <para>spfood:IngredientPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IngredientPreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IngredientPreference</seealso>
    let IngredientPreference =
        Prefixed_Name(spfood, "IngredientPreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:JapaneseCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#JapaneseCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#JapaneseCuisineRecipe</seealso>
    let JapaneseCuisineRecipe =
        Prefixed_Name(spfood, "JapaneseCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MainCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:MealCourseType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MainCourse">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MainCourse</seealso>
    let MainCourse = Prefixed_Name(spfood, "MainCourse") |> PrefixedName
    /// <summary>
    ///   <para>spfood:MainCourseRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MainCourseRole">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MainCourseRole</seealso>
    let MainCourseRole = Prefixed_Name(spfood, "MainCourseRole") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Fish</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fish">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fish</seealso>
    let Fish = Prefixed_Name(spfood, "Fish") |> PrefixedName

    /// <summary>
    ///   <para>spfood:FrenchCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FrenchCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FrenchCuisineRecipe</seealso>
    let FrenchCuisineRecipe =
        Prefixed_Name(spfood, "FrenchCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Gorgonzola</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Gorgonzola">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Gorgonzola</seealso>
    let Gorgonzola = Prefixed_Name(spfood, "Gorgonzola") |> PrefixedName
    /// <summary>
    ///   <para>spfood:GreekCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GreekCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GreekCuisineRecipe</seealso>
    let GreekCuisineRecipe = Prefixed_Name(spfood, "GreekCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MassQuantityInOunces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MassQuantityInOunces">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MassQuantityInOunces</seealso>
    let MassQuantityInOunces =
        Prefixed_Name(spfood, "MassQuantityInOunces") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MaxCookingTimePreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MaxCookingTimePreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MaxCookingTimePreference</seealso>
    let MaxCookingTimePreference =
        Prefixed_Name(spfood, "MaxCookingTimePreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MealPlanningTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealPlanningTask">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealPlanningTask</seealso>
    let MealPlanningTask = Prefixed_Name(spfood, "MealPlanningTask") |> PrefixedName
    /// <summary>
    ///   <para>spfood:MealType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealType</seealso>
    let MealType = Prefixed_Name(spfood, "MealType") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MiddleEasternCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MiddleEasternCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MiddleEasternCuisineRecipe</seealso>
    let MiddleEasternCuisineRecipe =
        Prefixed_Name(spfood, "MiddleEasternCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:NutritionalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:Nutrient</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutritionalEnergy">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutritionalEnergy</seealso>
    let NutritionalEnergy = Prefixed_Name(spfood, "NutritionalEnergy") |> PrefixedName

    /// <summary>
    ///   <para>spfood:PhilipsCookingGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#PhilipsCookingGuide">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#PhilipsCookingGuide</seealso>
    let PhilipsCookingGuide =
        Prefixed_Name(spfood, "PhilipsCookingGuide") |> PrefixedName

    /// <summary>
    ///   <para>spfood:PhilipsCookingGuideXYZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#PhilipsCookingGuideXYZ">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#PhilipsCookingGuideXYZ</seealso>
    let PhilipsCookingGuideXYZ =
        Prefixed_Name(spfood, "PhilipsCookingGuideXYZ") |> PrefixedName

    /// <summary>
    ///   <para>spfood:hasIngredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasIngredient">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasIngredient</seealso>
    let hasIngredient = Prefixed_Name(spfood, "hasIngredient") |> PrefixedName
    /// <summary>
    ///   <para>spfood:RecipeDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeDescription">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeDescription</seealso>
    let RecipeDescription = Prefixed_Name(spfood, "RecipeDescription") |> PrefixedName

    /// <summary>
    ///   <para>spfood:RecipeTypePreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeTypePreference">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeTypePreference</seealso>
    let RecipeTypePreference =
        Prefixed_Name(spfood, "RecipeTypePreference") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MeatProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MeatProduct">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MeatProduct</seealso>
    let MeatProduct = Prefixed_Name(spfood, "MeatProduct") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MoroccanCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MoroccanCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MoroccanCuisineRecipe</seealso>
    let MoroccanCuisineRecipe =
        Prefixed_Name(spfood, "MoroccanCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:NutrientPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutrientPortion">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutrientPortion</seealso>
    let NutrientPortion = Prefixed_Name(spfood, "NutrientPortion") |> PrefixedName

    /// <summary>
    ///   <para>spfood:MexicanCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MexicanCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MexicanCuisineRecipe</seealso>
    let MexicanCuisineRecipe =
        Prefixed_Name(spfood, "MexicanCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Moderate</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:CookingDifficultyCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Moderate">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Moderate</seealso>
    let Moderate = Prefixed_Name(spfood, "Moderate") |> PrefixedName
    /// <summary>
    ///   <para>spfood:NutFreeDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:DietType</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutFreeDiet">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutFreeDiet</seealso>
    let NutFreeDiet = Prefixed_Name(spfood, "NutFreeDiet") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Party">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Party</seealso>
    let Party = Prefixed_Name(spfood, "Party") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Proteins</para>
    /// </summary>
    /// <remarks>
    ///   <para>spfood:Nutrient</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Proteins">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Proteins</seealso>
    let Proteins = Prefixed_Name(spfood, "Proteins") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Recipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Recipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Recipe</seealso>
    let Recipe = Prefixed_Name(spfood, "Recipe") |> PrefixedName
    /// <summary>
    ///   <para>spfood:Sauce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Sauce">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Sauce</seealso>
    let Sauce = Prefixed_Name(spfood, "Sauce") |> PrefixedName

    /// <summary>
    ///   <para>spfood:ScottishCuisineRecipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ScottishCuisineRecipe">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ScottishCuisineRecipe</seealso>
    let ScottishCuisineRecipe =
        Prefixed_Name(spfood, "ScottishCuisineRecipe") |> PrefixedName

    /// <summary>
    ///   <para>spfood:hasGeographicalProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasGeographicalProvenance">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasGeographicalProvenance</seealso>
    let hasGeographicalProvenance =
        Prefixed_Name(spfood, "hasGeographicalProvenance") |> PrefixedName

    /// <summary>
    ///   <para>spfood:Baking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spfood:CookingTaskType</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Baking">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Baking</seealso>
    let Baking = Prefixed_Name(spfood, "Baking") |> PrefixedName
    /// <summary>
    ///   <para>spfood:CookingTaskType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingTaskType">http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingTaskType</seealso>
    let CookingTaskType = Prefixed_Name(spfood, "CookingTaskType") |> PrefixedName
