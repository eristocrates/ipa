namespace http.kmi._open.ac.uk.projects.smartproducts.ontologies.food.owl.hash

open DoxAletheia

module spfood =
    let _namespace_name =
        "http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#AmericanCuisineRecipe"></see>
    /// </summary>
    let AmericanCuisineRecipe = _prefix "AmericanCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasGeographicalProvenance"></see>
    /// </summary>
    let hasGeographicalProvenance = _prefix "hasGeographicalProvenance"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RegionalCuisineRecipe"></see>
    /// </summary>
    let RegionalCuisineRecipe = _prefix "RegionalCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Appetizer"></see>
    /// </summary>
    let Appetizer = _prefix "Appetizer"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealCourseType"></see>
    /// </summary>
    let MealCourseType = _prefix "MealCourseType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#AtomicFoodOrDrinkItem"></see>
    /// </summary>
    let AtomicFoodOrDrinkItem = _prefix "AtomicFoodOrDrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrinkMatter"></see>
    /// </summary>
    let FoodOrDrinkMatter = _prefix "FoodOrDrinkMatter"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrinkItem"></see>
    /// </summary>
    let FoodOrDrinkItem = _prefix "FoodOrDrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Baking"></see>
    /// </summary>
    let Baking = _prefix "Baking"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingTaskType"></see>
    /// </summary>
    let CookingTaskType = _prefix "CookingTaskType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#BakingOven"></see>
    /// </summary>
    let BakingOven = _prefix "BakingOven"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Oven"></see>
    /// </summary>
    let Oven = _prefix "Oven"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Boiling"></see>
    /// </summary>
    let Boiling = _prefix "Boiling"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#BritishCuisineRecipe"></see>
    /// </summary>
    let BritishCuisineRecipe = _prefix "BritishCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Carbohydrate"></see>
    /// </summary>
    let Carbohydrate = _prefix "Carbohydrate"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Nutrient"></see>
    /// </summary>
    let Nutrient = _prefix "Nutrient"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CaribbeanCuisineRecipe"></see>
    /// </summary>
    let CaribbeanCuisineRecipe = _prefix "CaribbeanCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cheese"></see>
    /// </summary>
    let Cheese = _prefix "Cheese"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ChineseCuisineRecipe"></see>
    /// </summary>
    let ChineseCuisineRecipe = _prefix "ChineseCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cholesterol"></see>
    /// </summary>
    let Cholesterol = _prefix "Cholesterol"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CompositeFoodOrDrinkItem"></see>
    /// </summary>
    let CompositeFoodOrDrinkItem = _prefix "CompositeFoodOrDrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteDrinkItem"></see>
    /// </summary>
    let ConcreteDrinkItem = _prefix "ConcreteDrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteFoodOrDrinkItem"></see>
    /// </summary>
    let ConcreteFoodOrDrinkItem = _prefix "ConcreteFoodOrDrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DrinkItem"></see>
    /// </summary>
    let DrinkItem = _prefix "DrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ConcreteFoodItem"></see>
    /// </summary>
    let ConcreteFoodItem = _prefix "ConcreteFoodItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodItem"></see>
    /// </summary>
    let FoodItem = _prefix "FoodItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IngredientPortion"></see>
    /// </summary>
    let IngredientPortion = _prefix "IngredientPortion"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VirtualFoodOrDrinkItem"></see>
    /// </summary>
    let VirtualFoodOrDrinkItem = _prefix "VirtualFoodOrDrinkItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingActivity"></see>
    /// </summary>
    let CookingActivity = _prefix "CookingActivity"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingDifficultyCategory"></see>
    /// </summary>
    let CookingDifficultyCategory = _prefix "CookingDifficultyCategory"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#CookingGuide"></see>
    /// </summary>
    let CookingGuide = _prefix "CookingGuide"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#KitchenTool"></see>
    /// </summary>
    let KitchenTool = _prefix "KitchenTool"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Cutting"></see>
    /// </summary>
    let Cutting = _prefix "Cutting"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DairyFreeDiet"></see>
    /// </summary>
    let DairyFreeDiet = _prefix "DairyFreeDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DietType"></see>
    /// </summary>
    let DietType = _prefix "DietType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DairyProduct"></see>
    /// </summary>
    let DairyProduct = _prefix "DairyProduct"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DefaultIngredientPortion"></see>
    /// </summary>
    let DefaultIngredientPortion = _prefix "DefaultIngredientPortion"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Dessert"></see>
    /// </summary>
    let Dessert = _prefix "Dessert"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DessertCourseRole"></see>
    /// </summary>
    let DessertCourseRole = _prefix "DessertCourseRole"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealCourseRole"></see>
    /// </summary>
    let MealCourseRole = _prefix "MealCourseRole"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DiabeticDiet"></see>
    /// </summary>
    let DiabeticDiet = _prefix "DiabeticDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DietAssessment"></see>
    /// </summary>
    let DietAssessment = _prefix "DietAssessment"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Disease"></see>
    /// </summary>
    let Disease = _prefix "Disease"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#HealthProfile"></see>
    /// </summary>
    let HealthProfile = _prefix "HealthProfile"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#DishPreference"></see>
    /// </summary>
    let DishPreference = _prefix "DishPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipePreference"></see>
    /// </summary>
    let RecipePreference = _prefix "RecipePreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Drink"></see>
    /// </summary>
    let Drink = _prefix "Drink"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodOrDrink"></see>
    /// </summary>
    let FoodOrDrink = _prefix "FoodOrDrink"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Drinks"></see>
    /// </summary>
    let Drinks = _prefix "Drinks"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Easy"></see>
    /// </summary>
    let Easy = _prefix "Easy"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#EggFreeDiet"></see>
    /// </summary>
    let EggFreeDiet = _prefix "EggFreeDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#EnergyQuantityInCalories"></see>
    /// </summary>
    let EnergyQuantityInCalories = _prefix "EnergyQuantityInCalories"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Expert"></see>
    /// </summary>
    let Expert = _prefix "Expert"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fat"></see>
    /// </summary>
    let Fat = _prefix "Fat"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FingerFood"></see>
    /// </summary>
    let FingerFood = _prefix "FingerFood"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#SideCourse"></see>
    /// </summary>
    let SideCourse = _prefix "SideCourse"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FishProduct"></see>
    /// </summary>
    let FishProduct = _prefix "FishProduct"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Food"></see>
    /// </summary>
    let Food = _prefix "Food"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodMatter"></see>
    /// </summary>
    let FoodMatter = _prefix "FoodMatter"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodPreference"></see>
    /// </summary>
    let FoodPreference = _prefix "FoodPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FoodProduct"></see>
    /// </summary>
    let FoodProduct = _prefix "FoodProduct"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FrenchCuisineRecipe"></see>
    /// </summary>
    let FrenchCuisineRecipe = _prefix "FrenchCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Fridge"></see>
    /// </summary>
    let Fridge = _prefix "Fridge"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Frying"></see>
    /// </summary>
    let Frying = _prefix "Frying"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#FryingPan"></see>
    /// </summary>
    let FryingPan = _prefix "FryingPan"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GermanCuisineRecipe"></see>
    /// </summary>
    let GermanCuisineRecipe = _prefix "GermanCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GlutenFreeDiet"></see>
    /// </summary>
    let GlutenFreeDiet = _prefix "GlutenFreeDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Gorgonzola"></see>
    /// </summary>
    let Gorgonzola = _prefix "Gorgonzola"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#GreekCuisineRecipe"></see>
    /// </summary>
    let GreekCuisineRecipe = _prefix "GreekCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MediterraneanCuisineRecipe"></see>
    /// </summary>
    let MediterraneanCuisineRecipe = _prefix "MediterraneanCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Grill"></see>
    /// </summary>
    let Grill = _prefix "Grill"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IndianCuisineRecipe"></see>
    /// </summary>
    let IndianCuisineRecipe = _prefix "IndianCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Ingredient"></see>
    /// </summary>
    let Ingredient = _prefix "Ingredient"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IngredientPreference"></see>
    /// </summary>
    let IngredientPreference = _prefix "IngredientPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#IrishCuisineRecipe"></see>
    /// </summary>
    let IrishCuisineRecipe = _prefix "IrishCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ItalianCuisineRecipe"></see>
    /// </summary>
    let ItalianCuisineRecipe = _prefix "ItalianCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#JapaneseCuisineRecipe"></see>
    /// </summary>
    let JapaneseCuisineRecipe = _prefix "JapaneseCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#LowFatDiet"></see>
    /// </summary>
    let LowFatDiet = _prefix "LowFatDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#LowInSaltDiet"></see>
    /// </summary>
    let LowInSaltDiet = _prefix "LowInSaltDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MainCourse"></see>
    /// </summary>
    let MainCourse = _prefix "MainCourse"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MainCourseRole"></see>
    /// </summary>
    let MainCourseRole = _prefix "MainCourseRole"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MassQuantityInOunces"></see>
    /// </summary>
    let MassQuantityInOunces = _prefix "MassQuantityInOunces"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MassQuantityInPounds"></see>
    /// </summary>
    let MassQuantityInPounds = _prefix "MassQuantityInPounds"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MaxCaloriesPreference"></see>
    /// </summary>
    let MaxCaloriesPreference = _prefix "MaxCaloriesPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutritionPreference"></see>
    /// </summary>
    let NutritionPreference = _prefix "NutritionPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MaxCookingTimePreference"></see>
    /// </summary>
    let MaxCookingTimePreference = _prefix "MaxCookingTimePreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeCookingTimePreference"></see>
    /// </summary>
    let RecipeCookingTimePreference = _prefix "RecipeCookingTimePreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealContext"></see>
    /// </summary>
    let MealContext = _prefix "MealContext"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealMaxNutritionEnergyPreference"></see>
    /// </summary>
    let MealMaxNutritionEnergyPreference = _prefix "MealMaxNutritionEnergyPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealNutritionEnergyPreference"></see>
    /// </summary>
    let MealNutritionEnergyPreference = _prefix "MealNutritionEnergyPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealMinNutritionEnergyPreference"></see>
    /// </summary>
    let MealMinNutritionEnergyPreference = _prefix "MealMinNutritionEnergyPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealNutritionPreference"></see>
    /// </summary>
    let MealNutritionPreference = _prefix "MealNutritionPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealPreference"></see>
    /// </summary>
    let MealPreference = _prefix "MealPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealPlanningTask"></see>
    /// </summary>
    let MealPlanningTask = _prefix "MealPlanningTask"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealStructure"></see>
    /// </summary>
    let MealStructure = _prefix "MealStructure"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MealType"></see>
    /// </summary>
    let MealType = _prefix "MealType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MeatProduct"></see>
    /// </summary>
    let MeatProduct = _prefix "MeatProduct"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MexicanCuisineRecipe"></see>
    /// </summary>
    let MexicanCuisineRecipe = _prefix "MexicanCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MiddleEasternCuisineRecipe"></see>
    /// </summary>
    let MiddleEasternCuisineRecipe = _prefix "MiddleEasternCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Moderate"></see>
    /// </summary>
    let Moderate = _prefix "Moderate"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#MoroccanCuisineRecipe"></see>
    /// </summary>
    let MoroccanCuisineRecipe = _prefix "MoroccanCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutFreeDiet"></see>
    /// </summary>
    let NutFreeDiet = _prefix "NutFreeDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutrientPortion"></see>
    /// </summary>
    let NutrientPortion = _prefix "NutrientPortion"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#NutritionalEnergy"></see>
    /// </summary>
    let NutritionalEnergy = _prefix "NutritionalEnergy"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Party"></see>
    /// </summary>
    let Party = _prefix "Party"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#PhilipsCookingGuide"></see>
    /// </summary>
    let PhilipsCookingGuide = _prefix "PhilipsCookingGuide"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#PhilipsCookingGuideXYZ"></see>
    /// </summary>
    let PhilipsCookingGuideXYZ = _prefix "PhilipsCookingGuideXYZ"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Proteins"></see>
    /// </summary>
    let Proteins = _prefix "Proteins"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Recipe"></see>
    /// </summary>
    let Recipe = _prefix "Recipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasIngredient"></see>
    /// </summary>
    let hasIngredient = _prefix "hasIngredient"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeDescription"></see>
    /// </summary>
    let RecipeDescription = _prefix "RecipeDescription"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#RecipeTypePreference"></see>
    /// </summary>
    let RecipeTypePreference = _prefix "RecipeTypePreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Sauce"></see>
    /// </summary>
    let Sauce = _prefix "Sauce"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ScottishCuisineRecipe"></see>
    /// </summary>
    let ScottishCuisineRecipe = _prefix "ScottishCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Sodium"></see>
    /// </summary>
    let Sodium = _prefix "Sodium"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Soup"></see>
    /// </summary>
    let Soup = _prefix "Soup"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#SpanishCuisineRecipe"></see>
    /// </summary>
    let SpanishCuisineRecipe = _prefix "SpanishCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Steamer"></see>
    /// </summary>
    let Steamer = _prefix "Steamer"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Stilton"></see>
    /// </summary>
    let Stilton = _prefix "Stilton"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Store"></see>
    /// </summary>
    let Store = _prefix "Store"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Supermarket"></see>
    /// </summary>
    let Supermarket = _prefix "Supermarket"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#TESCO"></see>
    /// </summary>
    let TESCO = _prefix "TESCO"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#ThaiCuisineRecipe"></see>
    /// </summary>
    let ThaiCuisineRecipe = _prefix "ThaiCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#TimeOfDayMealType"></see>
    /// </summary>
    let TimeOfDayMealType = _prefix "TimeOfDayMealType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#Turkey"></see>
    /// </summary>
    let Turkey = _prefix "Turkey"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VeganDiet"></see>
    /// </summary>
    let VeganDiet = _prefix "VeganDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VegetableOil"></see>
    /// </summary>
    let VegetableOil = _prefix "VegetableOil"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VegetarianDiet"></see>
    /// </summary>
    let VegetarianDiet = _prefix "VegetarianDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VietnameseCuisineRecipe"></see>
    /// </summary>
    let VietnameseCuisineRecipe = _prefix "VietnameseCuisineRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VolumeQuantityInCups"></see>
    /// </summary>
    let VolumeQuantityInCups = _prefix "VolumeQuantityInCups"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#VolumeQuantityInTableSpoons"></see>
    /// </summary>
    let VolumeQuantityInTableSpoons = _prefix "VolumeQuantityInTableSpoons"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#canBeReplacedWith"></see>
    /// </summary>
    let canBeReplacedWith = _prefix "canBeReplacedWith"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#courseType"></see>
    /// </summary>
    let courseType = _prefix "courseType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#courseValue"></see>
    /// </summary>
    let courseValue = _prefix "courseValue"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#cup"></see>
    /// </summary>
    let cup = _prefix "cup"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasAvailableIngredient"></see>
    /// </summary>
    let hasAvailableIngredient = _prefix "hasAvailableIngredient"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasCookingTaskType"></see>
    /// </summary>
    let hasCookingTaskType = _prefix "hasCookingTaskType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDefaultPortion"></see>
    /// </summary>
    let hasDefaultPortion = _prefix "hasDefaultPortion"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDietType"></see>
    /// </summary>
    let hasDietType = _prefix "hasDietType"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasDifficultyCategory"></see>
    /// </summary>
    let hasDifficultyCategory = _prefix "hasDifficultyCategory"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasExpiryDate"></see>
    /// </summary>
    let hasExpiryDate = _prefix "hasExpiryDate"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasGuest"></see>
    /// </summary>
    let hasGuest = _prefix "hasGuest"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasHealthProfile"></see>
    /// </summary>
    let hasHealthProfile = _prefix "hasHealthProfile"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasMealCourse"></see>
    /// </summary>
    let hasMealCourse = _prefix "hasMealCourse"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasMealStructure"></see>
    /// </summary>
    let hasMealStructure = _prefix "hasMealStructure"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasNutrient"></see>
    /// </summary>
    let hasNutrient = _prefix "hasNutrient"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#hasScore"></see>
    /// </summary>
    let hasScore = _prefix "hasScore"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#impliesPreference"></see>
    /// </summary>
    let impliesPreference = _prefix "impliesPreference"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#numberOfGuests"></see>
    /// </summary>
    let numberOfGuests = _prefix "numberOfGuests"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#producedByRecipe"></see>
    /// </summary>
    let producedByRecipe = _prefix "producedByRecipe"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#producesFoodItem"></see>
    /// </summary>
    let producesFoodItem = _prefix "producesFoodItem"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#suitableForDiet"></see>
    /// </summary>
    let suitableForDiet = _prefix "suitableForDiet"
    /// <summary>
    ///   <see href="http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#suitableForMealCourse"></see>
    /// </summary>
    let suitableForMealCourse = _prefix "suitableForMealCourse"
