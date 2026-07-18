namespace http.data.lirmm.fr.ontologies.food.hash

open DoxAletheia.Rdf_Vocabulary

module food =
    let _namespace_name = "http://data.lirmm.fr/ontologies/food#"

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fran%C3%A7ois"></see>
    /// </summary>
    let ``fran%C3%A7ois`` =
        Namespaced_IRI.parse _namespace_name "fran%C3%A7ois" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#St%C3%A9phaneGigandet"></see>
    /// </summary>
    let ``St%C3%A9phaneGigandet`` =
        Namespaced_IRI.parse _namespace_name "St%C3%A9phaneGigandet" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#EmmanuelNauer"></see>
    /// </summary>
    let EmmanuelNauer =
        Namespaced_IRI.parse _namespace_name "EmmanuelNauer" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#Mark"></see>
    /// </summary>
    let Mark = Namespaced_IRI.parse _namespace_name "Mark" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#Dish"></see>
    /// </summary>
    let Dish = Namespaced_IRI.parse _namespace_name "Dish" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#Food"></see>
    /// </summary>
    let Food = Namespaced_IRI.parse _namespace_name "Food" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#FoodProduct"></see>
    /// </summary>
    let FoodProduct =
        Namespaced_IRI.parse _namespace_name "FoodProduct" |> NamespacedName

    /// <summary>
    /// Represents an ingredient line in a recipe (for a Dish) or an ingredient listed in the ingredient list (for a Product).
    ///
    /// We need to specify a quantity and unit, so the relation is not binary. So the value for the containsIngredient property of a Food object is an object of the IngredientAmount class (instead of a Food object or string directly). See http://www.w3.org/TR/swbp-n-aryRelations/ for details.
    /// <see href="http://data.lirmm.fr/ontologies/food#Ingredient"></see></summary>
    let Ingredient = Namespaced_IRI.parse _namespace_name "Ingredient" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#LIRMM"></see>
    /// </summary>
    let LIRMM = Namespaced_IRI.parse _namespace_name "LIRMM" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#NutritionData"></see>
    /// </summary>
    let NutritionData =
        Namespaced_IRI.parse _namespace_name "NutritionData" |> NamespacedName

    /// <summary>
    /// A recipe as a set of ingredients together with the protocol to prepare the resulting food
    /// <see href="http://data.lirmm.fr/ontologies/food#Recipe"></see></summary>
    let Recipe = Namespaced_IRI.parse _namespace_name "Recipe" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#bicarbonatePer100g"></see>
    /// </summary>
    let bicarbonatePer100g =
        Namespaced_IRI.parse _namespace_name "bicarbonatePer100g" |> NamespacedName

    /// <summary>
    /// Note that biotin is also known as vitamin H or vitamin B7
    /// <see href="http://data.lirmm.fr/ontologies/food#biotinPer100g"></see></summary>
    let biotinPer100g =
        Namespaced_IRI.parse _namespace_name "biotinPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#calciumPer100g"></see>
    /// </summary>
    let calciumPer100g =
        Namespaced_IRI.parse _namespace_name "calciumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#carbohydratesPer100g"></see>
    /// </summary>
    let carbohydratesPer100g =
        Namespaced_IRI.parse _namespace_name "carbohydratesPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#carbonFootprintPer100g"></see>
    /// </summary>
    let carbonFootprintPer100g =
        Namespaced_IRI.parse _namespace_name "carbonFootprintPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#chloridePer100g"></see>
    /// </summary>
    let chloridePer100g =
        Namespaced_IRI.parse _namespace_name "chloridePer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#cholesterolPer100g"></see>
    /// </summary>
    let cholesterolPer100g =
        Namespaced_IRI.parse _namespace_name "cholesterolPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#chromiumPer100g"></see>
    /// </summary>
    let chromiumPer100g =
        Namespaced_IRI.parse _namespace_name "chromiumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#code"></see>
    /// </summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    /// Value is an object of the class Ingredient so that we can specify the quantity, the unit, and the nature of the ingredient (string or other Food object)
    ///
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)
    /// <see href="http://data.lirmm.fr/ontologies/food#containsIngredient"></see></summary>
    let containsIngredient =
        Namespaced_IRI.parse _namespace_name "containsIngredient" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#copperPer100g"></see>
    /// </summary>
    let copperPer100g =
        Namespaced_IRI.parse _namespace_name "copperPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#energyPer100g"></see>
    /// </summary>
    let energyPer100g =
        Namespaced_IRI.parse _namespace_name "energyPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fatPer100g"></see>
    /// </summary>
    let fatPer100g = Namespaced_IRI.parse _namespace_name "fatPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fiberPer100g"></see>
    /// </summary>
    let fiberPer100g =
        Namespaced_IRI.parse _namespace_name "fiberPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#fluoridePer100g"></see>
    /// </summary>
    let fluoridePer100g =
        Namespaced_IRI.parse _namespace_name "fluoridePer100g" |> NamespacedName

    /// <summary>
    /// String or Food object
    /// <see href="http://data.lirmm.fr/ontologies/food#food"></see></summary>
    let food = Namespaced_IRI.parse _namespace_name "food" |> NamespacedName

    /// <summary>
    /// Full text of the list of ingredients of a Food item (Product or Dish). May contain more details than what can be listed in the containsIngredient properties.
    /// <see href="http://data.lirmm.fr/ontologies/food#ingredientListAsText"></see></summary>
    let ingredientListAsText =
        Namespaced_IRI.parse _namespace_name "ingredientListAsText" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#iodinePer100g"></see>
    /// </summary>
    let iodinePer100g =
        Namespaced_IRI.parse _namespace_name "iodinePer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#ironPer100g"></see>
    /// </summary>
    let ironPer100g =
        Namespaced_IRI.parse _namespace_name "ironPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#magnesiumPer100g"></see>
    /// </summary>
    let magnesiumPer100g =
        Namespaced_IRI.parse _namespace_name "magnesiumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#manganesePer100g"></see>
    /// </summary>
    let manganesePer100g =
        Namespaced_IRI.parse _namespace_name "manganesePer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#molybdenumPer100g"></see>
    /// </summary>
    let molybdenumPer100g =
        Namespaced_IRI.parse _namespace_name "molybdenumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#monounsaturatedFatPer100g"></see>
    /// </summary>
    let monounsaturatedFatPer100g =
        Namespaced_IRI.parse _namespace_name "monounsaturatedFatPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#netWeight"></see>
    /// </summary>
    let netWeight = Namespaced_IRI.parse _namespace_name "netWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#omega3Fatper100g"></see>
    /// </summary>
    let omega3Fatper100g =
        Namespaced_IRI.parse _namespace_name "omega3Fatper100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#omega6FatPer100g"></see>
    /// </summary>
    let omega6FatPer100g =
        Namespaced_IRI.parse _namespace_name "omega6FatPer100g" |> NamespacedName

    /// <summary>
    /// Note that pantothenic acid is also known as vitamin B5
    /// <see href="http://data.lirmm.fr/ontologies/food#pantothenicAcidPer100g"></see></summary>
    let pantothenicAcidPer100g =
        Namespaced_IRI.parse _namespace_name "pantothenicAcidPer100g" |> NamespacedName

    /// <summary>
    /// Useful in particular for food products
    /// <see href="http://data.lirmm.fr/ontologies/food#percent"></see></summary>
    let percent = Namespaced_IRI.parse _namespace_name "percent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#phosphorusPer100g"></see>
    /// </summary>
    let phosphorusPer100g =
        Namespaced_IRI.parse _namespace_name "phosphorusPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#polyolsPer100g"></see>
    /// </summary>
    let polyolsPer100g =
        Namespaced_IRI.parse _namespace_name "polyolsPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#polyunsaturatedFatPer100g"></see>
    /// </summary>
    let polyunsaturatedFatPer100g =
        Namespaced_IRI.parse _namespace_name "polyunsaturatedFatPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#potassiumPer100g"></see>
    /// </summary>
    let potassiumPer100g =
        Namespaced_IRI.parse _namespace_name "potassiumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#proteinsPer100g"></see>
    /// </summary>
    let proteinsPer100g =
        Namespaced_IRI.parse _namespace_name "proteinsPer100g" |> NamespacedName

    /// <summary>
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)
    /// <see href="http://data.lirmm.fr/ontologies/food#quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#rank"></see>
    /// </summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#saltEquivalentPer100g"></see>
    /// </summary>
    let saltEquivalentPer100g =
        Namespaced_IRI.parse _namespace_name "saltEquivalentPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#saturatedFatPer100g"></see>
    /// </summary>
    let saturatedFatPer100g =
        Namespaced_IRI.parse _namespace_name "saturatedFatPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#seleniumPer100g"></see>
    /// </summary>
    let seleniumPer100g =
        Namespaced_IRI.parse _namespace_name "seleniumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#silicaPer100g"></see>
    /// </summary>
    let silicaPer100g =
        Namespaced_IRI.parse _namespace_name "silicaPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#sodiumPer100g"></see>
    /// </summary>
    let sodiumPer100g =
        Namespaced_IRI.parse _namespace_name "sodiumPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#starchPer100g"></see>
    /// </summary>
    let starchPer100g =
        Namespaced_IRI.parse _namespace_name "starchPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#sugarsPer100g"></see>
    /// </summary>
    let sugarsPer100g =
        Namespaced_IRI.parse _namespace_name "sugarsPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#transFatPer100g"></see>
    /// </summary>
    let transFatPer100g =
        Namespaced_IRI.parse _namespace_name "transFatPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
    /// <summary>
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)
    /// <see href="http://data.lirmm.fr/ontologies/food#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminAPer100g"></see>
    /// </summary>
    let vitaminAPer100g =
        Namespaced_IRI.parse _namespace_name "vitaminAPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminB12Per100g"></see>
    /// </summary>
    let vitaminB12Per100g =
        Namespaced_IRI.parse _namespace_name "vitaminB12Per100g" |> NamespacedName

    /// <summary>
    /// Note that vitamin B1 is also known as thiamin
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB1Per100g"></see></summary>
    let vitaminB1Per100g =
        Namespaced_IRI.parse _namespace_name "vitaminB1Per100g" |> NamespacedName

    /// <summary>
    /// Note that vitamin B2 is also known as riboflavin
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB2Per100g"></see></summary>
    let vitaminB2Per100g =
        Namespaced_IRI.parse _namespace_name "vitaminB2Per100g" |> NamespacedName

    /// <summary>
    /// Note that vitamin B3 is also known as vitamin Pp or niacin or nicotinic acid
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB3Per100g"></see></summary>
    let vitaminB3Per100g =
        Namespaced_IRI.parse _namespace_name "vitaminB3Per100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminB6Per100g"></see>
    /// </summary>
    let vitaminB6Per100g =
        Namespaced_IRI.parse _namespace_name "vitaminB6Per100g" |> NamespacedName

    /// <summary>
    /// Note that vitamin B9 is also known as folacin or folic acid or vitamin M
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminB9Per100g"></see></summary>
    let vitaminB9Per100g =
        Namespaced_IRI.parse _namespace_name "vitaminB9Per100g" |> NamespacedName

    /// <summary>
    /// Note that vitamin C is also known as L-ascorbic acid
    /// <see href="http://data.lirmm.fr/ontologies/food#vitaminCPer100g"></see></summary>
    let vitaminCPer100g =
        Namespaced_IRI.parse _namespace_name "vitaminCPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminDPer100g"></see>
    /// </summary>
    let vitaminDPer100g =
        Namespaced_IRI.parse _namespace_name "vitaminDPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminEPer100g"></see>
    /// </summary>
    let vitaminEPer100g =
        Namespaced_IRI.parse _namespace_name "vitaminEPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminKPer100g"></see>
    /// </summary>
    let vitaminKPer100g =
        Namespaced_IRI.parse _namespace_name "vitaminKPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#vitaminPpPer100g"></see>
    /// </summary>
    let vitaminPpPer100g =
        Namespaced_IRI.parse _namespace_name "vitaminPpPer100g" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/food#zincPer100g"></see>
    /// </summary>
    let zincPer100g =
        Namespaced_IRI.parse _namespace_name "zincPer100g" |> NamespacedName
