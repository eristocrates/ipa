namespace http.data.lirmm.fr.ontologies.food.hash

open DoxAletheia

module food =
    let _namespace_name = "http://data.lirmm.fr/ontologies/food#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fran%C3%A7ois"></see>
    /// </summary>
    let ``fran%C3%A7ois`` = _prefix "fran%C3%A7ois"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#St%C3%A9phaneGigandet"></see>
    /// </summary>
    let ``St%C3%A9phaneGigandet`` = _prefix "St%C3%A9phaneGigandet"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#EmmanuelNauer"></see>
    /// </summary>
    let EmmanuelNauer = _prefix "EmmanuelNauer"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#Mark"></see>
    /// </summary>
    let Mark = _prefix "Mark"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#Dish"></see>
    /// </summary>
    let Dish = _prefix "Dish"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#Food"></see>
    /// </summary>
    let Food = _prefix "Food"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#FoodProduct"></see>
    /// </summary>
    let FoodProduct = _prefix "FoodProduct"
    /// <summary>
    /// Represents an ingredient line in a recipe (for a Dish) or an ingredient listed in the ingredient list (for a Product).
    ///
    /// We need to specify a quantity and unit, so the relation is not binary. So the value for the containsIngredient property of a Food object is an object of the IngredientAmount class (instead of a Food object or string directly). See http://www.w3.org/TR/swbp-n-aryRelations/ for details.
    /// <see href="http://data.lirmm.fr/ontologies/food#Ingredient"></see></summary>
    let Ingredient = _prefix "Ingredient"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#LIRMM"></see>
    /// </summary>
    let LIRMM = _prefix "LIRMM"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#NutritionData"></see>
    /// </summary>
    let NutritionData = _prefix "NutritionData"
    /// <summary>
    /// A recipe as a set of ingredients together with the protocol to prepare the resulting food
    /// <see href="http://data.lirmm.fr/ontologies/food#Recipe"></see></summary>
    let Recipe = _prefix "Recipe"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#bicarbonatePer100g"></see>
    /// </summary>
    let bicarbonatePer100g = _prefix "bicarbonatePer100g"
    /// <summary>
    /// Note that biotin is also known as vitamin H or vitamin B7
    /// <see href="http://data.lirmm.fr/ontologies/food#biotinPer100g"></see></summary>
    let biotinPer100g = _prefix "biotinPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#calciumPer100g"></see>
    /// </summary>
    let calciumPer100g = _prefix "calciumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#carbohydratesPer100g"></see>
    /// </summary>
    let carbohydratesPer100g = _prefix "carbohydratesPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#carbonFootprintPer100g"></see>
    /// </summary>
    let carbonFootprintPer100g = _prefix "carbonFootprintPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#chloridePer100g"></see>
    /// </summary>
    let chloridePer100g = _prefix "chloridePer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#cholesterolPer100g"></see>
    /// </summary>
    let cholesterolPer100g = _prefix "cholesterolPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#chromiumPer100g"></see>
    /// </summary>
    let chromiumPer100g = _prefix "chromiumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#code"></see>
    /// </summary>
    let code = _prefix "code"
    /// <summary>
    /// Value is an object of the class Ingredient so that we can specify the quantity, the unit, and the nature of the ingredient (string or other Food object)
    ///
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)
    /// <see href="http://data.lirmm.fr/ontologies/food#containsIngredient"></see></summary>
    let containsIngredient = _prefix "containsIngredient"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#copperPer100g"></see>
    /// </summary>
    let copperPer100g = _prefix "copperPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#energyPer100g"></see>
    /// </summary>
    let energyPer100g = _prefix "energyPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fatPer100g"></see>
    /// </summary>
    let fatPer100g = _prefix "fatPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fiberPer100g"></see>
    /// </summary>
    let fiberPer100g = _prefix "fiberPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fluoridePer100g"></see>
    /// </summary>
    let fluoridePer100g = _prefix "fluoridePer100g"
    /// <summary>
    /// String or Food object
    /// <see href="http://data.lirmm.fr/ontologies/food#food"></see></summary>
    let food = _prefix "food"
    /// <summary>
    /// Full text of the list of ingredients of a Food item (Product or Dish). May contain more details than what can be listed in the containsIngredient properties.
    /// <see href="http://data.lirmm.fr/ontologies/food#ingredientListAsText"></see></summary>
    let ingredientListAsText = _prefix "ingredientListAsText"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#iodinePer100g"></see>
    /// </summary>
    let iodinePer100g = _prefix "iodinePer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#ironPer100g"></see>
    /// </summary>
    let ironPer100g = _prefix "ironPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#magnesiumPer100g"></see>
    /// </summary>
    let magnesiumPer100g = _prefix "magnesiumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#manganesePer100g"></see>
    /// </summary>
    let manganesePer100g = _prefix "manganesePer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#molybdenumPer100g"></see>
    /// </summary>
    let molybdenumPer100g = _prefix "molybdenumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#monounsaturatedFatPer100g"></see>
    /// </summary>
    let monounsaturatedFatPer100g = _prefix "monounsaturatedFatPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#netWeight"></see>
    /// </summary>
    let netWeight = _prefix "netWeight"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#omega3Fatper100g"></see>
    /// </summary>
    let omega3Fatper100g = _prefix "omega3Fatper100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#omega6FatPer100g"></see>
    /// </summary>
    let omega6FatPer100g = _prefix "omega6FatPer100g"
    /// <summary>
    /// Note that pantothenic acid is also known as vitamin B5
    /// <see href="http://data.lirmm.fr/ontologies/food#pantothenicAcidPer100g"></see></summary>
    let pantothenicAcidPer100g = _prefix "pantothenicAcidPer100g"
    /// <summary>
    /// Useful in particular for food products
    /// <see href="http://data.lirmm.fr/ontologies/food#percent"></see></summary>
    let percent = _prefix "percent"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#phosphorusPer100g"></see>
    /// </summary>
    let phosphorusPer100g = _prefix "phosphorusPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#polyolsPer100g"></see>
    /// </summary>
    let polyolsPer100g = _prefix "polyolsPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#polyunsaturatedFatPer100g"></see>
    /// </summary>
    let polyunsaturatedFatPer100g = _prefix "polyunsaturatedFatPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#potassiumPer100g"></see>
    /// </summary>
    let potassiumPer100g = _prefix "potassiumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#proteinsPer100g"></see>
    /// </summary>
    let proteinsPer100g = _prefix "proteinsPer100g"
    /// <summary>
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)
    /// <see href="http://data.lirmm.fr/ontologies/food#quantity"></see></summary>
    let quantity = _prefix "quantity"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#rank"></see>
    /// </summary>
    let rank = _prefix "rank"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#saltEquivalentPer100g"></see>
    /// </summary>
    let saltEquivalentPer100g = _prefix "saltEquivalentPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#saturatedFatPer100g"></see>
    /// </summary>
    let saturatedFatPer100g = _prefix "saturatedFatPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#seleniumPer100g"></see>
    /// </summary>
    let seleniumPer100g = _prefix "seleniumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#silicaPer100g"></see>
    /// </summary>
    let silicaPer100g = _prefix "silicaPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#sodiumPer100g"></see>
    /// </summary>
    let sodiumPer100g = _prefix "sodiumPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#starchPer100g"></see>
    /// </summary>
    let starchPer100g = _prefix "starchPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#sugarsPer100g"></see>
    /// </summary>
    let sugarsPer100g = _prefix "sugarsPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#transFatPer100g"></see>
    /// </summary>
    let transFatPer100g = _prefix "transFatPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)
    /// <see href="http://data.lirmm.fr/ontologies/food#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminAPer100g"></see>
    /// </summary>
    let vitaminAPer100g = _prefix "vitaminAPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminB12Per100g"></see>
    /// </summary>
    let vitaminB12Per100g = _prefix "vitaminB12Per100g"
    /// <summary>
    /// Note that vitamin B1 is also known as thiamin
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB1Per100g"></see></summary>
    let vitaminB1Per100g = _prefix "vitaminB1Per100g"
    /// <summary>
    /// Note that vitamin B2 is also known as riboflavin
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB2Per100g"></see></summary>
    let vitaminB2Per100g = _prefix "vitaminB2Per100g"
    /// <summary>
    /// Note that vitamin B3 is also known as vitamin Pp or niacin or nicotinic acid
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB3Per100g"></see></summary>
    let vitaminB3Per100g = _prefix "vitaminB3Per100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminB6Per100g"></see>
    /// </summary>
    let vitaminB6Per100g = _prefix "vitaminB6Per100g"
    /// <summary>
    /// Note that vitamin B9 is also known as folacin or folic acid or vitamin M
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB9Per100g"></see></summary>
    let vitaminB9Per100g = _prefix "vitaminB9Per100g"
    /// <summary>
    /// Note that vitamin C is also known as L-ascorbic acid
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminCPer100g"></see></summary>
    let vitaminCPer100g = _prefix "vitaminCPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminDPer100g"></see>
    /// </summary>
    let vitaminDPer100g = _prefix "vitaminDPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminEPer100g"></see>
    /// </summary>
    let vitaminEPer100g = _prefix "vitaminEPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminKPer100g"></see>
    /// </summary>
    let vitaminKPer100g = _prefix "vitaminKPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminPpPer100g"></see>
    /// </summary>
    let vitaminPpPer100g = _prefix "vitaminPpPer100g"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#zincPer100g"></see>
    /// </summary>
    let zincPer100g = _prefix "zincPer100g"
