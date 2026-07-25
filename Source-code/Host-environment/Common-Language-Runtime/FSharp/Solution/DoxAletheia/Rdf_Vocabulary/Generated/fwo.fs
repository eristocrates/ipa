namespace https.w3id.org.foodwaste.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fwo =
    let _namespace_iri = Namespace_Iri fwo |> NamespaceIRI
    /// <summary>
    ///   <para>fwo:Milk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Milk">https://w3id.org/foodwaste/ontology#Milk</seealso>
    let Milk = Prefixed_Name(fwo, "Milk") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Tree_Nuts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Tree_Nuts">https://w3id.org/foodwaste/ontology#Tree_Nuts</seealso>
    let Tree_Nuts = Prefixed_Name(fwo, "Tree_Nuts") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Wheat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Wheat">https://w3id.org/foodwaste/ontology#Wheat</seealso>
    let Wheat = Prefixed_Name(fwo, "Wheat") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Fish">https://w3id.org/foodwaste/ontology#Fish</seealso>
    let Fish = Prefixed_Name(fwo, "Fish") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Sesame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Allergen</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Sesame">https://w3id.org/foodwaste/ontology#Sesame</seealso>
    let Sesame = Prefixed_Name(fwo, "Sesame") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Soybeans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Soybeans">https://w3id.org/foodwaste/ontology#Soybeans</seealso>
    let Soybeans = Prefixed_Name(fwo, "Soybeans") |> PrefixedName
    /// <summary>
    ///   <para>fwo:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An individual or organization interacting with the food wastage system.</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#User">https://w3id.org/foodwaste/ontology#User</seealso>
    let User = Prefixed_Name(fwo, "User") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Donor1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor1">https://w3id.org/foodwaste/ontology#Donor1</seealso>
    let Donor1 = Prefixed_Name(fwo, "Donor1") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Donor10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor10">https://w3id.org/foodwaste/ontology#Donor10</seealso>
    let Donor10 = Prefixed_Name(fwo, "Donor10") |> PrefixedName
    /// <summary>
    ///   <para>fwo:NGO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>User is an NGO</para>
    /// labels<para>NGO</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#NGO">https://w3id.org/foodwaste/ontology#NGO</seealso>
    let NGO = Prefixed_Name(fwo, "NGO") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Donor_xyzq</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor_xyzq">https://w3id.org/foodwaste/ontology#Donor_xyzq</seealso>
    let Donor_xyzq = Prefixed_Name(fwo, "Donor_xyzq") |> PrefixedName

    /// <summary>
    ///   <para>fwo:6832c9d165d2ec4756cab2ed_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor">https://w3id.org/foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor</seealso>
    let _6832c9d165d2ec4756cab2ed_Donor =
        Prefixed_Name(fwo, "6832c9d165d2ec4756cab2ed_Donor") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>User is a donor</para>
    /// labels<para>Donor</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor">https://w3id.org/foodwaste/ontology#Donor</seealso>
    let Donor = Prefixed_Name(fwo, "Donor") |> PrefixedName

    /// <summary>
    ///   <para>fwo:6841464540dd1a066f42dc98_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#6841464540dd1a066f42dc98_Donor">https://w3id.org/foodwaste/ontology#6841464540dd1a066f42dc98_Donor</seealso>
    let _6841464540dd1a066f42dc98_Donor =
        Prefixed_Name(fwo, "6841464540dd1a066f42dc98_Donor") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Allergen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An enumeration of substances that may cause allergic reactions.</para>
    /// labels<para>Allergens</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Allergen">https://w3id.org/foodwaste/ontology#Allergen</seealso>
    let Allergen = Prefixed_Name(fwo, "Allergen") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Crustacean_shellfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Crustacean_shellfish">https://w3id.org/foodwaste/ontology#Crustacean_shellfish</seealso>
    let Crustacean_shellfish =
        Prefixed_Name(fwo, "Crustacean_shellfish") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Eggs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Eggs">https://w3id.org/foodwaste/ontology#Eggs</seealso>
    let Eggs = Prefixed_Name(fwo, "Eggs") |> PrefixedName
    /// <summary>
    ///   <para>fwo:AtRiskDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A food donation that is nearing its expiry and should be prioritized.</para>
    /// labels<para>At‑Risk Donation</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#AtRiskDonation">https://w3id.org/foodwaste/ontology#AtRiskDonation</seealso>
    let AtRiskDonation = Prefixed_Name(fwo, "AtRiskDonation") |> PrefixedName
    /// <summary>
    ///   <para>fwo:FoodDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A record representing a donation of food items.</para>
    /// labels<para>Food Donation</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#FoodDonation">https://w3id.org/foodwaste/ontology#FoodDonation</seealso>
    let FoodDonation = Prefixed_Name(fwo, "FoodDonation") |> PrefixedName
    /// <summary>
    ///   <para>fwo:hasPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the priority level assigned to a donation.</para>
    /// labels<para>has priority</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasPriority">https://w3id.org/foodwaste/ontology#hasPriority</seealso>
    let hasPriority = Prefixed_Name(fwo, "hasPriority") |> PrefixedName
    /// <summary>
    ///   <para>fwo:High</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#High">https://w3id.org/foodwaste/ontology#High</seealso>
    let High = Prefixed_Name(fwo, "High") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Available</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Available">https://w3id.org/foodwaste/ontology#Available</seealso>
    let Available = Prefixed_Name(fwo, "Available") |> PrefixedName
    /// <summary>
    ///   <para>fwo:BakedGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#BakedGoods">https://w3id.org/foodwaste/ontology#BakedGoods</seealso>
    let BakedGoods = Prefixed_Name(fwo, "BakedGoods") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Beverages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Beverages">https://w3id.org/foodwaste/ontology#Beverages</seealso>
    let Beverages = Prefixed_Name(fwo, "Beverages") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Claimed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Claimed">https://w3id.org/foodwaste/ontology#Claimed</seealso>
    let Claimed = Prefixed_Name(fwo, "Claimed") |> PrefixedName
    /// <summary>
    ///   <para>fwo:ClaimedDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A food donation that has been claimed by a recipient.</para>
    /// labels<para>Claimed Donation</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#ClaimedDonation">https://w3id.org/foodwaste/ontology#ClaimedDonation</seealso>
    let ClaimedDonation = Prefixed_Name(fwo, "ClaimedDonation") |> PrefixedName
    /// <summary>
    ///   <para>fwo:hasDonationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a donation with its current status.</para>
    /// labels<para>has donation status</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasDonationStatus">https://w3id.org/foodwaste/ontology#hasDonationStatus</seealso>
    let hasDonationStatus = Prefixed_Name(fwo, "hasDonationStatus") |> PrefixedName
    /// <summary>
    ///   <para>fwo:CookedFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#CookedFood">https://w3id.org/foodwaste/ontology#CookedFood</seealso>
    let CookedFood = Prefixed_Name(fwo, "CookedFood") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Dairy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Dairy">https://w3id.org/foodwaste/ontology#Dairy</seealso>
    let Dairy = Prefixed_Name(fwo, "Dairy") |> PrefixedName
    /// <summary>
    ///   <para>fwo:DairyProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#DairyProducts">https://w3id.org/foodwaste/ontology#DairyProducts</seealso>
    let DairyProducts = Prefixed_Name(fwo, "DairyProducts") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Delivered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#DonationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Delivered">https://w3id.org/foodwaste/ontology#Delivered</seealso>
    let Delivered = Prefixed_Name(fwo, "Delivered") |> PrefixedName
    /// <summary>
    ///   <para>fwo:DonationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An enumeration of possible statuses for a food donation (e.g., At Risk, Claimed).</para>
    /// labels<para>Donation Status</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#DonationStatus">https://w3id.org/foodwaste/ontology#DonationStatus</seealso>
    let DonationStatus = Prefixed_Name(fwo, "DonationStatus") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Diabetic_Sweets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Diabetic_Sweets">https://w3id.org/foodwaste/ontology#Diabetic_Sweets</seealso>
    let Diabetic_Sweets = Prefixed_Name(fwo, "Diabetic_Sweets") |> PrefixedName
    /// <summary>
    ///   <para>fwo:containsAllergen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Denotes that a donation includes a specified allergen.</para>
    /// labels<para>contains Allergen</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#containsAllergen">https://w3id.org/foodwaste/ontology#containsAllergen</seealso>
    let containsAllergen = Prefixed_Name(fwo, "containsAllergen") |> PrefixedName
    /// <summary>
    ///   <para>fwo:FoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An enumeration of categories of food (e.g., fruits, vegetables, dairy)</para>
    /// labels<para>Food Type</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#FoodType">https://w3id.org/foodwaste/ontology#FoodType</seealso>
    let FoodType = Prefixed_Name(fwo, "FoodType") |> PrefixedName
    /// <summary>
    ///   <para>fwo:hasFoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the type of food in this donation.</para>
    /// labels<para>has food type</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasFoodType">https://w3id.org/foodwaste/ontology#hasFoodType</seealso>
    let hasFoodType = Prefixed_Name(fwo, "hasFoodType") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered enumeration indicating the urgency or importance of a donation.</para>
    /// labels<para>Priority</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Priority">https://w3id.org/foodwaste/ontology#Priority</seealso>
    let Priority = Prefixed_Name(fwo, "Priority") |> PrefixedName
    /// <summary>
    ///   <para>fwo:FreshProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#FreshProduce">https://w3id.org/foodwaste/ontology#FreshProduce</seealso>
    let FreshProduce = Prefixed_Name(fwo, "FreshProduce") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Grains_and_Cerals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Grains_and_Cerals">https://w3id.org/foodwaste/ontology#Grains_and_Cerals</seealso>
    let Grains_and_Cerals = Prefixed_Name(fwo, "Grains_and_Cerals") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Meat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Meat">https://w3id.org/foodwaste/ontology#Meat</seealso>
    let Meat = Prefixed_Name(fwo, "Meat") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Non_Diabetic_Sweets</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#FoodType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Non_Diabetic_Sweets">https://w3id.org/foodwaste/ontology#Non_Diabetic_Sweets</seealso>
    let Non_Diabetic_Sweets = Prefixed_Name(fwo, "Non_Diabetic_Sweets") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Processed_and_Packaged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Processed_and_Packaged">https://w3id.org/foodwaste/ontology#Processed_and_Packaged</seealso>
    let Processed_and_Packaged =
        Prefixed_Name(fwo, "Processed_and_Packaged") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Sea_Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Sea_Food">https://w3id.org/foodwaste/ontology#Sea_Food</seealso>
    let Sea_Food = Prefixed_Name(fwo, "Sea_Food") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Snacks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Snacks">https://w3id.org/foodwaste/ontology#Snacks</seealso>
    let Snacks = Prefixed_Name(fwo, "Snacks") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Spices_and_Condiments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Spices_and_Condiments">https://w3id.org/foodwaste/ontology#Spices_and_Condiments</seealso>
    let Spices_and_Condiments =
        Prefixed_Name(fwo, "Spices_and_Condiments") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Staple_Foods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Staple_Foods">https://w3id.org/foodwaste/ontology#Staple_Foods</seealso>
    let Staple_Foods = Prefixed_Name(fwo, "Staple_Foods") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Fruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Fruit">https://w3id.org/foodwaste/ontology#Fruit</seealso>
    let Fruit = Prefixed_Name(fwo, "Fruit") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Gluten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Gluten">https://w3id.org/foodwaste/ontology#Gluten</seealso>
    let Gluten = Prefixed_Name(fwo, "Gluten") |> PrefixedName

    /// <summary>
    ///   <para>fwo:hasHigherPriorityThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that one priority level is higher than another.</para>
    /// labels<para>has higher priority than</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasHigherPriorityThan">https://w3id.org/foodwaste/ontology#hasHigherPriorityThan</seealso>
    let hasHigherPriorityThan =
        Prefixed_Name(fwo, "hasHigherPriorityThan") |> PrefixedName

    /// <summary>
    ///   <para>fwo:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Medium">https://w3id.org/foodwaste/ontology#Medium</seealso>
    let Medium = Prefixed_Name(fwo, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Low</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Priority</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Low">https://w3id.org/foodwaste/ontology#Low</seealso>
    let Low = Prefixed_Name(fwo, "Low") |> PrefixedName
    /// <summary>
    ///   <para>fwo:avoidsAllergen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a user to an allergen they need to avoid</para>
    /// labels<para>avoids Allergen</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#avoidsAllergen">https://w3id.org/foodwaste/ontology#avoidsAllergen</seealso>
    let avoidsAllergen = Prefixed_Name(fwo, "avoidsAllergen") |> PrefixedName
    /// <summary>
    ///   <para>fwo:prefersFoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a user to the types of food they prefer.</para>
    /// labels<para>prefers food type</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#prefersFoodType">https://w3id.org/foodwaste/ontology#prefersFoodType</seealso>
    let prefersFoodType = Prefixed_Name(fwo, "prefersFoodType") |> PrefixedName
    /// <summary>
    ///   <para>fwo:rejectsFoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>links user to the food type they reject</para>
    /// labels<para>rejects food type</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#rejectsFoodType">https://w3id.org/foodwaste/ontology#rejectsFoodType</seealso>
    let rejectsFoodType = Prefixed_Name(fwo, "rejectsFoodType") |> PrefixedName
    /// <summary>
    ///   <para>fwo:NGO1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#NGO1">https://w3id.org/foodwaste/ontology#NGO1</seealso>
    let NGO1 = Prefixed_Name(fwo, "NGO1") |> PrefixedName
    /// <summary>
    ///   <para>fwo:NGO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#NGO2">https://w3id.org/foodwaste/ontology#NGO2</seealso>
    let NGO2 = Prefixed_Name(fwo, "NGO2") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Peanut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Peanut">https://w3id.org/foodwaste/ontology#Peanut</seealso>
    let Peanut = Prefixed_Name(fwo, "Peanut") |> PrefixedName
    /// <summary>
    ///   <para>fwo:Peanuts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Peanuts">https://w3id.org/foodwaste/ontology#Peanuts</seealso>
    let Peanuts = Prefixed_Name(fwo, "Peanuts") |> PrefixedName
    /// <summary>
    ///   <para>fwo:PreferredDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A donation marked as preferred by a user based on their preferences.</para>
    /// labels<para>Preferred Donation</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#PreferredDonation">https://w3id.org/foodwaste/ontology#PreferredDonation</seealso>
    let PreferredDonation = Prefixed_Name(fwo, "PreferredDonation") |> PrefixedName
    /// <summary>
    ///   <para>fwo:TrustedDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A donation from a source flagged as trusted.</para>
    /// labels<para>Trusted Donation</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#TrustedDonation">https://w3id.org/foodwaste/ontology#TrustedDonation</seealso>
    let TrustedDonation = Prefixed_Name(fwo, "TrustedDonation") |> PrefixedName
    /// <summary>
    ///   <para>fwo:UrgentDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A donation requiring immediate pickup or distribution</para>
    /// labels<para>Urgent Donation</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#UrgentDonation">https://w3id.org/foodwaste/ontology#UrgentDonation</seealso>
    let UrgentDonation = Prefixed_Name(fwo, "UrgentDonation") |> PrefixedName
    /// <summary>
    ///   <para>fwo:abc123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#abc123">https://w3id.org/foodwaste/ontology#abc123</seealso>
    let abc123 = Prefixed_Name(fwo, "abc123") |> PrefixedName
    /// <summary>
    ///   <para>fwo:abc1234</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#abc1234">https://w3id.org/foodwaste/ontology#abc1234</seealso>
    let abc1234 = Prefixed_Name(fwo, "abc1234") |> PrefixedName
    /// <summary>
    ///   <para>fwo:abc123_Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#abc123_Location">https://w3id.org/foodwaste/ontology#abc123_Location</seealso>
    let abc123_Location = Prefixed_Name(fwo, "abc123_Location") |> PrefixedName
    /// <summary>
    ///   <para>fwo:claimedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates the user who has claimed this donation.</para>
    /// labels<para>claimed by</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#claimedBy">https://w3id.org/foodwaste/ontology#claimedBy</seealso>
    let claimedBy = Prefixed_Name(fwo, "claimedBy") |> PrefixedName
    /// <summary>
    ///   <para>fwo:don12345_Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#don12345_Location">https://w3id.org/foodwaste/ontology#don12345_Location</seealso>
    let don12345_Location = Prefixed_Name(fwo, "don12345_Location") |> PrefixedName
    /// <summary>
    ///   <para>fwo:donatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the user or farmer who made this donation.</para>
    /// labels<para>donated by</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#donatedBy">https://w3id.org/foodwaste/ontology#donatedBy</seealso>
    let donatedBy = Prefixed_Name(fwo, "donatedBy") |> PrefixedName
    /// <summary>
    ///   <para>fwo:hasDonated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a user to the donations they have made.</para>
    /// labels<para>has donated</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasDonated">https://w3id.org/foodwaste/ontology#hasDonated</seealso>
    let hasDonated = Prefixed_Name(fwo, "hasDonated") |> PrefixedName
    /// <summary>
    ///   <para>fwo:donor456_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#donor456_Donor">https://w3id.org/foodwaste/ontology#donor456_Donor</seealso>
    let donor456_Donor = Prefixed_Name(fwo, "donor456_Donor") |> PrefixedName
    /// <summary>
    ///   <para>fwo:hasExpiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Denotes the expiration date of a donated food item</para>
    /// labels<para>has expiry date</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasExpiryDate">https://w3id.org/foodwaste/ontology#hasExpiryDate</seealso>
    let hasExpiryDate = Prefixed_Name(fwo, "hasExpiryDate") |> PrefixedName

    /// <summary>
    ///   <para>fwo:hasLowerPriorityThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that one priority level is lower than another.</para>
    /// labels<para>has lower priority than</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasLowerPriorityThan">https://w3id.org/foodwaste/ontology#hasLowerPriorityThan</seealso>
    let hasLowerPriorityThan =
        Prefixed_Name(fwo, "hasLowerPriorityThan") |> PrefixedName

    /// <summary>
    ///   <para>fwo:hasParentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a food type to its more general parent category.</para>
    /// labels<para>has parent type</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasParentType">https://w3id.org/foodwaste/ontology#hasParentType</seealso>
    let hasParentType = Prefixed_Name(fwo, "hasParentType") |> PrefixedName
    /// <summary>
    ///   <para>fwo:isPreferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a donation is preferred by a particular user.</para>
    /// labels<para>is preferred by</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#isPreferredBy">https://w3id.org/foodwaste/ontology#isPreferredBy</seealso>
    let isPreferredBy = Prefixed_Name(fwo, "isPreferredBy") |> PrefixedName
    /// <summary>
    ///   <para>fwo:isRejectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a donation type has been rejected by a particular user.</para>
    /// labels<para>is rejected by</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#isRejectedBy">https://w3id.org/foodwaste/ontology#isRejectedBy</seealso>
    let isRejectedBy = Prefixed_Name(fwo, "isRejectedBy") |> PrefixedName
    /// <summary>
    ///   <para>fwo:xyz1234</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#xyz1234">https://w3id.org/foodwaste/ontology#xyz1234</seealso>
    let xyz1234 = Prefixed_Name(fwo, "xyz1234") |> PrefixedName
    /// <summary>
    ///   <para>fwo:xyzq_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#xyzq_Donor">https://w3id.org/foodwaste/ontology#xyzq_Donor</seealso>
    let xyzq_Donor = Prefixed_Name(fwo, "xyzq_Donor") |> PrefixedName
