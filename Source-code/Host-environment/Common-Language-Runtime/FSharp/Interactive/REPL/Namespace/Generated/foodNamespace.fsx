#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module food =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/food#" "food"

    /// <summary>
    ///   <para>rdfs:label : A dish is a food item with a recipe^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#Dish">food:Dish</a>
    /// </summary>
    let Dish = _prefixId.prefix "Dish"
    let EmmanuelNauer = _prefixId.prefix "EmmanuelNauer"
    /// <summary>
    ///   <para>rdfs:label : Anything that can be eaten: a basic Food item (e.g. salt), a Dish made with a recipe, a manufactured Food Product^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#Food">food:Food</a>
    /// </summary>
    let Food = _prefixId.prefix "Food"
    /// <summary>
    ///   <para>rdfs:label : A manufactured food product^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#FoodProduct">food:FoodProduct</a>
    /// </summary>
    let FoodProduct = _prefixId.prefix "FoodProduct"
    /// <summary>
    ///   <para>rdfs:label : An ingredient : a certain quantity of food that is part of another food^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an ingredient line in a recipe (for a Dish) or an ingredient listed in the ingredient list (for a Product).
    ///
    /// We need to specify a quantity and unit, so the relation is not binary. So the value for the containsIngredient property of a Food object is an object of the IngredientAmount class (instead of a Food object or string directly). See http://www.w3.org/TR/swbp-n-aryRelations/ for details.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#Ingredient">food:Ingredient</a>
    /// </summary>
    let Ingredient = _prefixId.prefix "Ingredient"
    let LIRMM = _prefixId.prefix "LIRMM"
    let Mark = _prefixId.prefix "Mark"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data for a food item (recipe, product or ingredient)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#NutritionData">food:NutritionData</a>
    /// </summary>
    let NutritionData = _prefixId.prefix "NutritionData"
    /// <summary>
    ///   <para>rdfs:label : Recipe^^xsd:string</para>
    ///   <para>rdfs:comment : A recipe as a set of ingredients together with the protocol to prepare the resulting food^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#Recipe">food:Recipe</a>
    /// </summary>
    let Recipe = _prefixId.prefix "Recipe"
    let ``St%C3%A9phaneGigandet`` = _prefixId.prefix "St%C3%A9phaneGigandet"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: bicarbonate (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#bicarbonatePer100g">food:bicarbonatePer100g</a>
    /// </summary>
    let bicarbonatePer100g = _prefixId.prefix "bicarbonatePer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: biotin (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that biotin is also known as vitamin H or vitamin B7^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#biotinPer100g">food:biotinPer100g</a>
    /// </summary>
    let biotinPer100g = _prefixId.prefix "biotinPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: calcium (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#calciumPer100g">food:calciumPer100g</a>
    /// </summary>
    let calciumPer100g = _prefixId.prefix "calciumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: carbohydrates (in g) per 100g (or 100ml for liquids) ^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#carbohydratesPer100g">food:carbohydratesPer100g</a>
    /// </summary>
    let carbohydratesPer100g = _prefixId.prefix "carbohydratesPer100g"
    /// <summary>
    ///   <para>rdfs:label : Carbon foorprint (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#carbonFootprintPer100g">food:carbonFootprintPer100g</a>
    /// </summary>
    let carbonFootprintPer100g = _prefixId.prefix "carbonFootprintPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: chloride (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#chloridePer100g">food:chloridePer100g</a>
    /// </summary>
    let chloridePer100g = _prefixId.prefix "chloridePer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: cholesterol (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#cholesterolPer100g">food:cholesterolPer100g</a>
    /// </summary>
    let cholesterolPer100g = _prefixId.prefix "cholesterolPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: chromium (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#chromiumPer100g">food:chromiumPer100g</a>
    /// </summary>
    let chromiumPer100g = _prefixId.prefix "chromiumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Identifier: usually a barcode such as EAN-13 (European Article Numbering) or UPC-A (Universal Product Code)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#code">food:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:label : Specifies an ingredient contained in the Food object^^xsd:string</para>
    ///   <para>rdfs:comment : Value is an object of the class Ingredient so that we can specify the quantity, the unit, and the nature of the ingredient (string or other Food object)
    ///
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#containsIngredient">food:containsIngredient</a>
    /// </summary>
    let containsIngredient = _prefixId.prefix "containsIngredient"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: copper (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#copperPer100g">food:copperPer100g</a>
    /// </summary>
    let copperPer100g = _prefixId.prefix "copperPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: energy (in kJ) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#energyPer100g">food:energyPer100g</a>
    /// </summary>
    let energyPer100g = _prefixId.prefix "energyPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#fatPer100g">food:fatPer100g</a>
    /// </summary>
    let fatPer100g = _prefixId.prefix "fatPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: fiber (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#fiberPer100g">food:fiberPer100g</a>
    /// </summary>
    let fiberPer100g = _prefixId.prefix "fiberPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: fluoride (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#fluoridePer100g">food:fluoridePer100g</a>
    /// </summary>
    let fluoridePer100g = _prefixId.prefix "fluoridePer100g"
    /// <summary>
    ///   <para>rdfs:label : Food that is an ingredient of another food^^xsd:string</para>
    ///   <para>rdfs:comment : String or Food object^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#food">food:food</a>
    /// </summary>
    let food = _prefixId.prefix "food"
    let ``fran%C3%A7ois`` = _prefixId.prefix "fran%C3%A7ois"
    /// <summary>
    ///   <para>rdfs:label : Text of the list of ingredients^^xsd:string</para>
    ///   <para>rdfs:comment : Full text of the list of ingredients of a Food item (Product or Dish). May contain more details than what can be listed in the containsIngredient properties.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#ingredientListAsText">food:ingredientListAsText</a>
    /// </summary>
    let ingredientListAsText = _prefixId.prefix "ingredientListAsText"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: iodine (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#iodinePer100g">food:iodinePer100g</a>
    /// </summary>
    let iodinePer100g = _prefixId.prefix "iodinePer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: ironPer100g (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#ironPer100g">food:ironPer100g</a>
    /// </summary>
    let ironPer100g = _prefixId.prefix "ironPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: magnesium (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#magnesiumPer100g">food:magnesiumPer100g</a>
    /// </summary>
    let magnesiumPer100g = _prefixId.prefix "magnesiumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: manganese (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#manganesePer100g">food:manganesePer100g</a>
    /// </summary>
    let manganesePer100g = _prefixId.prefix "manganesePer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: molybdenum (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#molybdenumPer100g">food:molybdenumPer100g</a>
    /// </summary>
    let molybdenumPer100g = _prefixId.prefix "molybdenumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: monounsaturated fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#monounsaturatedFatPer100g">food:monounsaturatedFatPer100g</a>
    /// </summary>
    let monounsaturatedFatPer100g = _prefixId.prefix "monounsaturatedFatPer100g"
    /// <summary>
    ///   <para>rdfs:label : net weight of a food product (g) ^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#netWeight">food:netWeight</a>
    /// </summary>
    let netWeight = _prefixId.prefix "netWeight"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: omega 3 fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#omega3Fatper100g">food:omega3Fatper100g</a>
    /// </summary>
    let omega3Fatper100g = _prefixId.prefix "omega3Fatper100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: omega 6 fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#omega6FatPer100g">food:omega6FatPer100g</a>
    /// </summary>
    let omega6FatPer100g = _prefixId.prefix "omega6FatPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: pantothenic acid (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that pantothenic acid is also known as vitamin B5^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#pantothenicAcidPer100g">food:pantothenicAcidPer100g</a>
    /// </summary>
    let pantothenicAcidPer100g = _prefixId.prefix "pantothenicAcidPer100g"
    /// <summary>
    ///   <para>rdfs:label : Quantity of ingredient in percentage % of the total amount of ingredients in a Food^^xsd:string</para>
    ///   <para>rdfs:comment : Useful in particular for food products^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#percent">food:percent</a>
    /// </summary>
    let percent = _prefixId.prefix "percent"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: phosphorus (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#phosphorusPer100g">food:phosphorusPer100g</a>
    /// </summary>
    let phosphorusPer100g = _prefixId.prefix "phosphorusPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: polyols (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#polyolsPer100g">food:polyolsPer100g</a>
    /// </summary>
    let polyolsPer100g = _prefixId.prefix "polyolsPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: polyunsaturated fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#polyunsaturatedFatPer100g">food:polyunsaturatedFatPer100g</a>
    /// </summary>
    let polyunsaturatedFatPer100g = _prefixId.prefix "polyunsaturatedFatPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: potassium (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#potassiumPer100g">food:potassiumPer100g</a>
    /// </summary>
    let potassiumPer100g = _prefixId.prefix "potassiumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: proteins (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#proteinsPer100g">food:proteinsPer100g</a>
    /// </summary>
    let proteinsPer100g = _prefixId.prefix "proteinsPer100g"
    /// <summary>
    ///   <para>rdfs:label : quantity of ingredient in any unit (unit specified in unit)^^xsd:string</para>
    ///   <para>rdfs:comment : e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#quantity">food:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>rdfs:label : Rank of an ingredient in an ingredient list ordered by quantity (e.g. food products)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#rank">food:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: equivalent in salt (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#saltEquivalentPer100g">food:saltEquivalentPer100g</a>
    /// </summary>
    let saltEquivalentPer100g = _prefixId.prefix "saltEquivalentPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: saturated fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#saturatedFatPer100g">food:saturatedFatPer100g</a>
    /// </summary>
    let saturatedFatPer100g = _prefixId.prefix "saturatedFatPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: selenium (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#seleniumPer100g">food:seleniumPer100g</a>
    /// </summary>
    let seleniumPer100g = _prefixId.prefix "seleniumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: silica (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#silicaPer100g">food:silicaPer100g</a>
    /// </summary>
    let silicaPer100g = _prefixId.prefix "silicaPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: sodium (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#sodiumPer100g">food:sodiumPer100g</a>
    /// </summary>
    let sodiumPer100g = _prefixId.prefix "sodiumPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: starch (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#starchPer100g">food:starchPer100g</a>
    /// </summary>
    let starchPer100g = _prefixId.prefix "starchPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: sugars (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#sugarsPer100g">food:sugarsPer100g</a>
    /// </summary>
    let sugarsPer100g = _prefixId.prefix "sugarsPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: trans fat (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#transFatPer100g">food:transFatPer100g</a>
    /// </summary>
    let transFatPer100g = _prefixId.prefix "transFatPer100g"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : Unit for the specified quantity^^xsd:string</para>
    ///   <para>rdfs:comment : e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#unit">food:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin A (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminAPer100g">food:vitaminAPer100g</a>
    /// </summary>
    let vitaminAPer100g = _prefixId.prefix "vitaminAPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin B12 (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminB12Per100g">food:vitaminB12Per100g</a>
    /// </summary>
    let vitaminB12Per100g = _prefixId.prefix "vitaminB12Per100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin B1 (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that vitamin B1 is also known as thiamin^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminB1Per100g">food:vitaminB1Per100g</a>
    /// </summary>
    let vitaminB1Per100g = _prefixId.prefix "vitaminB1Per100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin B2 (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that vitamin B2 is also known as riboflavin^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminB2Per100g">food:vitaminB2Per100g</a>
    /// </summary>
    let vitaminB2Per100g = _prefixId.prefix "vitaminB2Per100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin B3 (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that vitamin B3 is also known as vitamin Pp or niacin or nicotinic acid^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminB3Per100g">food:vitaminB3Per100g</a>
    /// </summary>
    let vitaminB3Per100g = _prefixId.prefix "vitaminB3Per100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin B6 (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminB6Per100g">food:vitaminB6Per100g</a>
    /// </summary>
    let vitaminB6Per100g = _prefixId.prefix "vitaminB6Per100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin B9 (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that vitamin B9 is also known as folacin or folic acid or vitamin M^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminB9Per100g">food:vitaminB9Per100g</a>
    /// </summary>
    let vitaminB9Per100g = _prefixId.prefix "vitaminB9Per100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin C (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <para>rdfs:comment : Note that vitamin C is also known as L-ascorbic acid^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminCPer100g">food:vitaminCPer100g</a>
    /// </summary>
    let vitaminCPer100g = _prefixId.prefix "vitaminCPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin D (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminDPer100g">food:vitaminDPer100g</a>
    /// </summary>
    let vitaminDPer100g = _prefixId.prefix "vitaminDPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin E (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminEPer100g">food:vitaminEPer100g</a>
    /// </summary>
    let vitaminEPer100g = _prefixId.prefix "vitaminEPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: vitamin K (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminKPer100g">food:vitaminKPer100g</a>
    /// </summary>
    let vitaminKPer100g = _prefixId.prefix "vitaminKPer100g"
    /// <summary>
    ///   <para>rdfs:label : vitaminPpPer100g^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#vitaminPpPer100g">food:vitaminPpPer100g</a>
    /// </summary>
    let vitaminPpPer100g = _prefixId.prefix "vitaminPpPer100g"
    /// <summary>
    ///   <para>rdfs:label : Nutrition data: zinc (in g) per 100g (or 100ml for liquids)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/food#zincPer100g">food:zincPer100g</a>
    /// </summary>
    let zincPer100g = _prefixId.prefix "zincPer100g"
