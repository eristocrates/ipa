namespace http.data.lirmm.fr.ontologies.food.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module food =
    let _namespace_iri = Namespace_Iri food |> NamespaceIRI

    /// <summary>
    ///   <para>food:St%C3%A9phaneGigandet</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#St%C3%A9phaneGigandet">http://data.lirmm.fr/ontologies/food#St%C3%A9phaneGigandet</seealso>
    let ``St%C3%A9phaneGigandet`` =
        Prefixed_Name(food, "St%C3%A9phaneGigandet") |> PrefixedName

    /// <summary>
    ///   <para>food:Mark</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#Mark">http://data.lirmm.fr/ontologies/food#Mark</seealso>
    let Mark = Prefixed_Name(food, "Mark") |> PrefixedName
    /// <summary>
    ///   <para>food:EmmanuelNauer</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#EmmanuelNauer">http://data.lirmm.fr/ontologies/food#EmmanuelNauer</seealso>
    let EmmanuelNauer = Prefixed_Name(food, "EmmanuelNauer") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminCPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Note that vitamin C is also known as L-ascorbic acid</para>
    /// labels<para>Nutrition data: vitamin C (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminCPer100g">http://data.lirmm.fr/ontologies/food#vitaminCPer100g</seealso>
    let vitaminCPer100g = Prefixed_Name(food, "vitaminCPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminEPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: vitamin E (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminEPer100g">http://data.lirmm.fr/ontologies/food#vitaminEPer100g</seealso>
    let vitaminEPer100g = Prefixed_Name(food, "vitaminEPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminPpPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>vitaminPpPer100g</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminPpPer100g">http://data.lirmm.fr/ontologies/food#vitaminPpPer100g</seealso>
    let vitaminPpPer100g = Prefixed_Name(food, "vitaminPpPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:Dish</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A dish is a food item with a recipe</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#Dish">http://data.lirmm.fr/ontologies/food#Dish</seealso>
    let Dish = Prefixed_Name(food, "Dish") |> PrefixedName
    /// <summary>
    ///   <para>food:FoodProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A manufactured food product</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#FoodProduct">http://data.lirmm.fr/ontologies/food#FoodProduct</seealso>
    let FoodProduct = Prefixed_Name(food, "FoodProduct") |> PrefixedName
    /// <summary>
    ///   <para>food:Ingredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents an ingredient line in a recipe (for a Dish) or an ingredient listed in the ingredient list (for a Product).
    ///
    /// We need to specify a quantity and unit, so the relation is not binary. So the value for the containsIngredient property of a Food object is an object of the IngredientAmount class (instead of a Food object or string directly). See http://www.w3.org/TR/swbp-n-aryRelations/ for details.</para>
    /// labels<para>An ingredient : a certain quantity of food that is part of another food</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#Ingredient">http://data.lirmm.fr/ontologies/food#Ingredient</seealso>
    let Ingredient = Prefixed_Name(food, "Ingredient") |> PrefixedName
    /// <summary>
    ///   <para>food:NutritionData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Nutrition data for a food item (recipe, product or ingredient)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#NutritionData">http://data.lirmm.fr/ontologies/food#NutritionData</seealso>
    let NutritionData = Prefixed_Name(food, "NutritionData") |> PrefixedName
    /// <summary>
    ///   <para>food:Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Anything that can be eaten: a basic Food item (e.g. salt), a Dish made with a recipe, a manufactured Food Product</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#Food">http://data.lirmm.fr/ontologies/food#Food</seealso>
    let Food = Prefixed_Name(food, "Food") |> PrefixedName
    /// <summary>
    ///   <para>food:Recipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A recipe as a set of ingredients together with the protocol to prepare the resulting food</para>
    /// labels<para>Recipe</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#Recipe">http://data.lirmm.fr/ontologies/food#Recipe</seealso>
    let Recipe = Prefixed_Name(food, "Recipe") |> PrefixedName
    /// <summary>
    ///   <para>food:LIRMM</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#LIRMM">http://data.lirmm.fr/ontologies/food#LIRMM</seealso>
    let LIRMM = Prefixed_Name(food, "LIRMM") |> PrefixedName

    /// <summary>
    ///   <para>food:carbohydratesPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: carbohydrates (in g) per 100g (or 100ml for liquids) </para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#carbohydratesPer100g">http://data.lirmm.fr/ontologies/food#carbohydratesPer100g</seealso>
    let carbohydratesPer100g =
        Prefixed_Name(food, "carbohydratesPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:chloridePer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: chloride (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#chloridePer100g">http://data.lirmm.fr/ontologies/food#chloridePer100g</seealso>
    let chloridePer100g = Prefixed_Name(food, "chloridePer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:containsIngredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Value is an object of the class Ingredient so that we can specify the quantity, the unit, and the nature of the ingredient (string or other Food object)
    ///
    /// e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)</para>
    /// labels<para>Specifies an ingredient contained in the Food object</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#containsIngredient">http://data.lirmm.fr/ontologies/food#containsIngredient</seealso>
    let containsIngredient = Prefixed_Name(food, "containsIngredient") |> PrefixedName
    /// <summary>
    ///   <para>food:energyPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: energy (in kJ) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#energyPer100g">http://data.lirmm.fr/ontologies/food#energyPer100g</seealso>
    let energyPer100g = Prefixed_Name(food, "energyPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:fiberPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: fiber (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#fiberPer100g">http://data.lirmm.fr/ontologies/food#fiberPer100g</seealso>
    let fiberPer100g = Prefixed_Name(food, "fiberPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:fluoridePer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: fluoride (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#fluoridePer100g">http://data.lirmm.fr/ontologies/food#fluoridePer100g</seealso>
    let fluoridePer100g = Prefixed_Name(food, "fluoridePer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:bicarbonatePer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: bicarbonate (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#bicarbonatePer100g">http://data.lirmm.fr/ontologies/food#bicarbonatePer100g</seealso>
    let bicarbonatePer100g = Prefixed_Name(food, "bicarbonatePer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:biotinPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Note that biotin is also known as vitamin H or vitamin B7</para>
    /// labels<para>Nutrition data: biotin (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#biotinPer100g">http://data.lirmm.fr/ontologies/food#biotinPer100g</seealso>
    let biotinPer100g = Prefixed_Name(food, "biotinPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:calciumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: calcium (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#calciumPer100g">http://data.lirmm.fr/ontologies/food#calciumPer100g</seealso>
    let calciumPer100g = Prefixed_Name(food, "calciumPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:carbonFootprintPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Carbon foorprint (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#carbonFootprintPer100g">http://data.lirmm.fr/ontologies/food#carbonFootprintPer100g</seealso>
    let carbonFootprintPer100g =
        Prefixed_Name(food, "carbonFootprintPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:cholesterolPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: cholesterol (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#cholesterolPer100g">http://data.lirmm.fr/ontologies/food#cholesterolPer100g</seealso>
    let cholesterolPer100g = Prefixed_Name(food, "cholesterolPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier: usually a barcode such as EAN-13 (European Article Numbering) or UPC-A (Universal Product Code)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#code">http://data.lirmm.fr/ontologies/food#code</seealso>
    let code = Prefixed_Name(food, "code") |> PrefixedName
    /// <summary>
    ///   <para>food:copperPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: copper (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#copperPer100g">http://data.lirmm.fr/ontologies/food#copperPer100g</seealso>
    let copperPer100g = Prefixed_Name(food, "copperPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:chromiumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: chromium (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#chromiumPer100g">http://data.lirmm.fr/ontologies/food#chromiumPer100g</seealso>
    let chromiumPer100g = Prefixed_Name(food, "chromiumPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:fatPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#fatPer100g">http://data.lirmm.fr/ontologies/food#fatPer100g</seealso>
    let fatPer100g = Prefixed_Name(food, "fatPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:food</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>String or Food object</para>
    /// labels<para>Food that is an ingredient of another food</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#food">http://data.lirmm.fr/ontologies/food#food</seealso>
    let food_ = Prefixed_Name(food, "food") |> PrefixedName

    /// <summary>
    ///   <para>food:ingredientListAsText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Full text of the list of ingredients of a Food item (Product or Dish). May contain more details than what can be listed in the containsIngredient properties.</para>
    /// labels<para>Text of the list of ingredients</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#ingredientListAsText">http://data.lirmm.fr/ontologies/food#ingredientListAsText</seealso>
    let ingredientListAsText =
        Prefixed_Name(food, "ingredientListAsText") |> PrefixedName

    /// <summary>
    ///   <para>food:iodinePer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: iodine (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#iodinePer100g">http://data.lirmm.fr/ontologies/food#iodinePer100g</seealso>
    let iodinePer100g = Prefixed_Name(food, "iodinePer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:magnesiumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: magnesium (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#magnesiumPer100g">http://data.lirmm.fr/ontologies/food#magnesiumPer100g</seealso>
    let magnesiumPer100g = Prefixed_Name(food, "magnesiumPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:manganesePer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: manganese (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#manganesePer100g">http://data.lirmm.fr/ontologies/food#manganesePer100g</seealso>
    let manganesePer100g = Prefixed_Name(food, "manganesePer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:monounsaturatedFatPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: monounsaturated fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#monounsaturatedFatPer100g">http://data.lirmm.fr/ontologies/food#monounsaturatedFatPer100g</seealso>
    let monounsaturatedFatPer100g =
        Prefixed_Name(food, "monounsaturatedFatPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:omega3Fatper100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: omega 3 fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#omega3Fatper100g">http://data.lirmm.fr/ontologies/food#omega3Fatper100g</seealso>
    let omega3Fatper100g = Prefixed_Name(food, "omega3Fatper100g") |> PrefixedName
    /// <summary>
    ///   <para>food:omega6FatPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: omega 6 fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#omega6FatPer100g">http://data.lirmm.fr/ontologies/food#omega6FatPer100g</seealso>
    let omega6FatPer100g = Prefixed_Name(food, "omega6FatPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:ironPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: ironPer100g (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#ironPer100g">http://data.lirmm.fr/ontologies/food#ironPer100g</seealso>
    let ironPer100g = Prefixed_Name(food, "ironPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:netWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>net weight of a food product (g) </para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#netWeight">http://data.lirmm.fr/ontologies/food#netWeight</seealso>
    let netWeight = Prefixed_Name(food, "netWeight") |> PrefixedName

    /// <summary>
    ///   <para>food:pantothenicAcidPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Note that pantothenic acid is also known as vitamin B5</para>
    /// labels<para>Nutrition data: pantothenic acid (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#pantothenicAcidPer100g">http://data.lirmm.fr/ontologies/food#pantothenicAcidPer100g</seealso>
    let pantothenicAcidPer100g =
        Prefixed_Name(food, "pantothenicAcidPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:phosphorusPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: phosphorus (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#phosphorusPer100g">http://data.lirmm.fr/ontologies/food#phosphorusPer100g</seealso>
    let phosphorusPer100g = Prefixed_Name(food, "phosphorusPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:polyolsPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: polyols (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#polyolsPer100g">http://data.lirmm.fr/ontologies/food#polyolsPer100g</seealso>
    let polyolsPer100g = Prefixed_Name(food, "polyolsPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:proteinsPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: proteins (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#proteinsPer100g">http://data.lirmm.fr/ontologies/food#proteinsPer100g</seealso>
    let proteinsPer100g = Prefixed_Name(food, "proteinsPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)</para>
    /// labels<para>quantity of ingredient in any unit (unit specified in unit)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#quantity">http://data.lirmm.fr/ontologies/food#quantity</seealso>
    let quantity = Prefixed_Name(food, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>food:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#rdf">http://data.lirmm.fr/ontologies/food#rdf</seealso>
    let rdf = Prefixed_Name(food, "rdf") |> PrefixedName

    /// <summary>
    ///   <para>food:saltEquivalentPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: equivalent in salt (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#saltEquivalentPer100g">http://data.lirmm.fr/ontologies/food#saltEquivalentPer100g</seealso>
    let saltEquivalentPer100g =
        Prefixed_Name(food, "saltEquivalentPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:seleniumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: selenium (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#seleniumPer100g">http://data.lirmm.fr/ontologies/food#seleniumPer100g</seealso>
    let seleniumPer100g = Prefixed_Name(food, "seleniumPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:molybdenumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: molybdenum (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#molybdenumPer100g">http://data.lirmm.fr/ontologies/food#molybdenumPer100g</seealso>
    let molybdenumPer100g = Prefixed_Name(food, "molybdenumPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:percent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Useful in particular for food products</para>
    /// labels<para>Quantity of ingredient in percentage % of the total amount of ingredients in a Food</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#percent">http://data.lirmm.fr/ontologies/food#percent</seealso>
    let percent = Prefixed_Name(food, "percent") |> PrefixedName

    /// <summary>
    ///   <para>food:polyunsaturatedFatPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: polyunsaturated fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#polyunsaturatedFatPer100g">http://data.lirmm.fr/ontologies/food#polyunsaturatedFatPer100g</seealso>
    let polyunsaturatedFatPer100g =
        Prefixed_Name(food, "polyunsaturatedFatPer100g") |> PrefixedName

    /// <summary>
    ///   <para>food:potassiumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: potassium (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#potassiumPer100g">http://data.lirmm.fr/ontologies/food#potassiumPer100g</seealso>
    let potassiumPer100g = Prefixed_Name(food, "potassiumPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Rank of an ingredient in an ingredient list ordered by quantity (e.g. food products)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#rank">http://data.lirmm.fr/ontologies/food#rank</seealso>
    let rank = Prefixed_Name(food, "rank") |> PrefixedName
    /// <summary>
    ///   <para>food:saturatedFatPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: saturated fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#saturatedFatPer100g">http://data.lirmm.fr/ontologies/food#saturatedFatPer100g</seealso>
    let saturatedFatPer100g = Prefixed_Name(food, "saturatedFatPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:silicaPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: silica (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#silicaPer100g">http://data.lirmm.fr/ontologies/food#silicaPer100g</seealso>
    let silicaPer100g = Prefixed_Name(food, "silicaPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:sodiumPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: sodium (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#sodiumPer100g">http://data.lirmm.fr/ontologies/food#sodiumPer100g</seealso>
    let sodiumPer100g = Prefixed_Name(food, "sodiumPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:transFatPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: trans fat (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#transFatPer100g">http://data.lirmm.fr/ontologies/food#transFatPer100g</seealso>
    let transFatPer100g = Prefixed_Name(food, "transFatPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>e.g. 1 clove of garlic -&gt; quantity = 1, unit = clove, ingredient = garlic (or Food object for garlic)</para>
    /// labels<para>Unit for the specified quantity</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#unit">http://data.lirmm.fr/ontologies/food#unit</seealso>
    let unit = Prefixed_Name(food, "unit") |> PrefixedName
    /// <summary>
    ///   <para>food:sugarsPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: sugars (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#sugarsPer100g">http://data.lirmm.fr/ontologies/food#sugarsPer100g</seealso>
    let sugarsPer100g = Prefixed_Name(food, "sugarsPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminAPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: vitamin A (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminAPer100g">http://data.lirmm.fr/ontologies/food#vitaminAPer100g</seealso>
    let vitaminAPer100g = Prefixed_Name(food, "vitaminAPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminB1Per100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Note that vitamin B1 is also known as thiamin</para>
    /// labels<para>Nutrition data: vitamin B1 (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminB1Per100g">http://data.lirmm.fr/ontologies/food#vitaminB1Per100g</seealso>
    let vitaminB1Per100g = Prefixed_Name(food, "vitaminB1Per100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminB3Per100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note that vitamin B3 is also known as vitamin Pp or niacin or nicotinic acid</para>
    /// labels<para>Nutrition data: vitamin B3 (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminB3Per100g">http://data.lirmm.fr/ontologies/food#vitaminB3Per100g</seealso>
    let vitaminB3Per100g = Prefixed_Name(food, "vitaminB3Per100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminB9Per100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note that vitamin B9 is also known as folacin or folic acid or vitamin M</para>
    /// labels<para>Nutrition data: vitamin B9 (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminB9Per100g">http://data.lirmm.fr/ontologies/food#vitaminB9Per100g</seealso>
    let vitaminB9Per100g = Prefixed_Name(food, "vitaminB9Per100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminDPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: vitamin D (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminDPer100g">http://data.lirmm.fr/ontologies/food#vitaminDPer100g</seealso>
    let vitaminDPer100g = Prefixed_Name(food, "vitaminDPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminKPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: vitamin K (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminKPer100g">http://data.lirmm.fr/ontologies/food#vitaminKPer100g</seealso>
    let vitaminKPer100g = Prefixed_Name(food, "vitaminKPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:zincPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: zinc (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#zincPer100g">http://data.lirmm.fr/ontologies/food#zincPer100g</seealso>
    let zincPer100g = Prefixed_Name(food, "zincPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:starchPer100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nutrition data: starch (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#starchPer100g">http://data.lirmm.fr/ontologies/food#starchPer100g</seealso>
    let starchPer100g = Prefixed_Name(food, "starchPer100g") |> PrefixedName
    /// <summary>
    ///   <para>food:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#ttl">http://data.lirmm.fr/ontologies/food#ttl</seealso>
    let ttl = Prefixed_Name(food, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminB12Per100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: vitamin B12 (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminB12Per100g">http://data.lirmm.fr/ontologies/food#vitaminB12Per100g</seealso>
    let vitaminB12Per100g = Prefixed_Name(food, "vitaminB12Per100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminB2Per100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Note that vitamin B2 is also known as riboflavin</para>
    /// labels<para>Nutrition data: vitamin B2 (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminB2Per100g">http://data.lirmm.fr/ontologies/food#vitaminB2Per100g</seealso>
    let vitaminB2Per100g = Prefixed_Name(food, "vitaminB2Per100g") |> PrefixedName
    /// <summary>
    ///   <para>food:vitaminB6Per100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nutrition data: vitamin B6 (in g) per 100g (or 100ml for liquids)</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#vitaminB6Per100g">http://data.lirmm.fr/ontologies/food#vitaminB6Per100g</seealso>
    let vitaminB6Per100g = Prefixed_Name(food, "vitaminB6Per100g") |> PrefixedName
    /// <summary>
    ///   <para>food:fran%C3%A7ois</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/food#fran%C3%A7ois">http://data.lirmm.fr/ontologies/food#fran%C3%A7ois</seealso>
    let ``fran%C3%A7ois`` = Prefixed_Name(food, "fran%C3%A7ois") |> PrefixedName
