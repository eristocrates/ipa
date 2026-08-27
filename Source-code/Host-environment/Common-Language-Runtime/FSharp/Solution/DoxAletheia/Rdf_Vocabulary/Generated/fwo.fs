namespace https.w3id.org.foodwaste.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fwo =
    let _namespace_iri = Namespace_Iri fwo |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor">https://w3id.org/foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor</seealso>
    let _6832c9d165d2ec4756cab2ed_Donor =
        Prefixed_Name(fwo, "6832c9d165d2ec4756cab2ed_Donor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#6841464540dd1a066f42dc98_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#6841464540dd1a066f42dc98_Donor">https://w3id.org/foodwaste/ontology#6841464540dd1a066f42dc98_Donor</seealso>
    let _6841464540dd1a066f42dc98_Donor =
        Prefixed_Name(fwo, "6841464540dd1a066f42dc98_Donor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Allergen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enumeration of substances that may cause allergic reactions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Allergens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Allergen">https://w3id.org/foodwaste/ontology#Allergen</seealso>
    let Allergen = Prefixed_Name(fwo, "Allergen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#AtRiskDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A food donation that is nearing its expiry and should be prioritized."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"At‑Risk Donation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#AtRiskDonation">https://w3id.org/foodwaste/ontology#AtRiskDonation</seealso>
    let AtRiskDonation = Prefixed_Name(fwo, "AtRiskDonation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Available</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Available">https://w3id.org/foodwaste/ontology#Available</seealso>
    let Available = Prefixed_Name(fwo, "Available") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#BakedGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#BakedGoods">https://w3id.org/foodwaste/ontology#BakedGoods</seealso>
    let BakedGoods = Prefixed_Name(fwo, "BakedGoods") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Beverages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Beverages">https://w3id.org/foodwaste/ontology#Beverages</seealso>
    let Beverages = Prefixed_Name(fwo, "Beverages") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Claimed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Claimed">https://w3id.org/foodwaste/ontology#Claimed</seealso>
    let Claimed = Prefixed_Name(fwo, "Claimed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#ClaimedDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A food donation that has been claimed by a recipient."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Claimed Donation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#ClaimedDonation">https://w3id.org/foodwaste/ontology#ClaimedDonation</seealso>
    let ClaimedDonation = Prefixed_Name(fwo, "ClaimedDonation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#CookedFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#CookedFood">https://w3id.org/foodwaste/ontology#CookedFood</seealso>
    let CookedFood = Prefixed_Name(fwo, "CookedFood") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Crustacean_shellfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Crustacean_shellfish">https://w3id.org/foodwaste/ontology#Crustacean_shellfish</seealso>
    let Crustacean_shellfish =
        Prefixed_Name(fwo, "Crustacean_shellfish") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Dairy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Dairy">https://w3id.org/foodwaste/ontology#Dairy</seealso>
    let Dairy = Prefixed_Name(fwo, "Dairy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#DairyProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#DairyProducts">https://w3id.org/foodwaste/ontology#DairyProducts</seealso>
    let DairyProducts = Prefixed_Name(fwo, "DairyProducts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Delivered</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#DonationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Delivered">https://w3id.org/foodwaste/ontology#Delivered</seealso>
    let Delivered = Prefixed_Name(fwo, "Delivered") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Diabetic_Sweets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Diabetic_Sweets">https://w3id.org/foodwaste/ontology#Diabetic_Sweets</seealso>
    let Diabetic_Sweets = Prefixed_Name(fwo, "Diabetic_Sweets") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#DonationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enumeration of possible statuses for a food donation (e.g., At Risk, Claimed)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Donation Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#DonationStatus">https://w3id.org/foodwaste/ontology#DonationStatus</seealso>
    let DonationStatus = Prefixed_Name(fwo, "DonationStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"User is a donor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Donor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor">https://w3id.org/foodwaste/ontology#Donor</seealso>
    let Donor = Prefixed_Name(fwo, "Donor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Donor1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor1">https://w3id.org/foodwaste/ontology#Donor1</seealso>
    let Donor1 = Prefixed_Name(fwo, "Donor1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Donor10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor10">https://w3id.org/foodwaste/ontology#Donor10</seealso>
    let Donor10 = Prefixed_Name(fwo, "Donor10") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Donor_xyzq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Donor_xyzq">https://w3id.org/foodwaste/ontology#Donor_xyzq</seealso>
    let Donor_xyzq = Prefixed_Name(fwo, "Donor_xyzq") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Eggs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Eggs">https://w3id.org/foodwaste/ontology#Eggs</seealso>
    let Eggs = Prefixed_Name(fwo, "Eggs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Fish">https://w3id.org/foodwaste/ontology#Fish</seealso>
    let Fish = Prefixed_Name(fwo, "Fish") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#FoodDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A record representing a donation of food items."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Food Donation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#FoodDonation">https://w3id.org/foodwaste/ontology#FoodDonation</seealso>
    let FoodDonation = Prefixed_Name(fwo, "FoodDonation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#FoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enumeration of categories of food (e.g., fruits, vegetables, dairy)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Food Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#FoodType">https://w3id.org/foodwaste/ontology#FoodType</seealso>
    let FoodType = Prefixed_Name(fwo, "FoodType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#FreshProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#FreshProduce">https://w3id.org/foodwaste/ontology#FreshProduce</seealso>
    let FreshProduce = Prefixed_Name(fwo, "FreshProduce") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Fruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Fruit">https://w3id.org/foodwaste/ontology#Fruit</seealso>
    let Fruit = Prefixed_Name(fwo, "Fruit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Gluten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Gluten">https://w3id.org/foodwaste/ontology#Gluten</seealso>
    let Gluten = Prefixed_Name(fwo, "Gluten") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Grains_and_Cerals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Grains_and_Cerals">https://w3id.org/foodwaste/ontology#Grains_and_Cerals</seealso>
    let Grains_and_Cerals = Prefixed_Name(fwo, "Grains_and_Cerals") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#High</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#High">https://w3id.org/foodwaste/ontology#High</seealso>
    let High = Prefixed_Name(fwo, "High") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Low</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Priority</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Low">https://w3id.org/foodwaste/ontology#Low</seealso>
    let Low = Prefixed_Name(fwo, "Low") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Meat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Meat">https://w3id.org/foodwaste/ontology#Meat</seealso>
    let Meat = Prefixed_Name(fwo, "Meat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Medium">https://w3id.org/foodwaste/ontology#Medium</seealso>
    let Medium = Prefixed_Name(fwo, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Milk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Milk">https://w3id.org/foodwaste/ontology#Milk</seealso>
    let Milk = Prefixed_Name(fwo, "Milk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"User is an NGO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NGO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#NGO">https://w3id.org/foodwaste/ontology#NGO</seealso>
    let NGO = Prefixed_Name(fwo, "NGO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#NGO1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#NGO1">https://w3id.org/foodwaste/ontology#NGO1</seealso>
    let NGO1 = Prefixed_Name(fwo, "NGO1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#NGO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#NGO2">https://w3id.org/foodwaste/ontology#NGO2</seealso>
    let NGO2 = Prefixed_Name(fwo, "NGO2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Non_Diabetic_Sweets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#FoodType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Non_Diabetic_Sweets">https://w3id.org/foodwaste/ontology#Non_Diabetic_Sweets</seealso>
    let Non_Diabetic_Sweets = Prefixed_Name(fwo, "Non_Diabetic_Sweets") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Peanut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Peanut">https://w3id.org/foodwaste/ontology#Peanut</seealso>
    let Peanut = Prefixed_Name(fwo, "Peanut") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Peanuts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Peanuts">https://w3id.org/foodwaste/ontology#Peanuts</seealso>
    let Peanuts = Prefixed_Name(fwo, "Peanuts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#PreferredDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A donation marked as preferred by a user based on their preferences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Preferred Donation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#PreferredDonation">https://w3id.org/foodwaste/ontology#PreferredDonation</seealso>
    let PreferredDonation = Prefixed_Name(fwo, "PreferredDonation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered enumeration indicating the urgency or importance of a donation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Priority">https://w3id.org/foodwaste/ontology#Priority</seealso>
    let Priority = Prefixed_Name(fwo, "Priority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Processed_and_Packaged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Processed_and_Packaged">https://w3id.org/foodwaste/ontology#Processed_and_Packaged</seealso>
    let Processed_and_Packaged =
        Prefixed_Name(fwo, "Processed_and_Packaged") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Sea_Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Sea_Food">https://w3id.org/foodwaste/ontology#Sea_Food</seealso>
    let Sea_Food = Prefixed_Name(fwo, "Sea_Food") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Sesame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Allergen</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Sesame">https://w3id.org/foodwaste/ontology#Sesame</seealso>
    let Sesame = Prefixed_Name(fwo, "Sesame") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Snacks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Snacks">https://w3id.org/foodwaste/ontology#Snacks</seealso>
    let Snacks = Prefixed_Name(fwo, "Snacks") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Soybeans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Soybeans">https://w3id.org/foodwaste/ontology#Soybeans</seealso>
    let Soybeans = Prefixed_Name(fwo, "Soybeans") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Spices_and_Condiments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Spices_and_Condiments">https://w3id.org/foodwaste/ontology#Spices_and_Condiments</seealso>
    let Spices_and_Condiments =
        Prefixed_Name(fwo, "Spices_and_Condiments") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Staple_Foods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Staple_Foods">https://w3id.org/foodwaste/ontology#Staple_Foods</seealso>
    let Staple_Foods = Prefixed_Name(fwo, "Staple_Foods") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Tree_Nuts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Tree_Nuts">https://w3id.org/foodwaste/ontology#Tree_Nuts</seealso>
    let Tree_Nuts = Prefixed_Name(fwo, "Tree_Nuts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#TrustedDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A donation from a source flagged as trusted."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trusted Donation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#TrustedDonation">https://w3id.org/foodwaste/ontology#TrustedDonation</seealso>
    let TrustedDonation = Prefixed_Name(fwo, "TrustedDonation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#UrgentDonation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A donation requiring immediate pickup or distribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Urgent Donation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#UrgentDonation">https://w3id.org/foodwaste/ontology#UrgentDonation</seealso>
    let UrgentDonation = Prefixed_Name(fwo, "UrgentDonation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual or organization interacting with the food wastage system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#User">https://w3id.org/foodwaste/ontology#User</seealso>
    let User = Prefixed_Name(fwo, "User") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#Wheat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#Wheat">https://w3id.org/foodwaste/ontology#Wheat</seealso>
    let Wheat = Prefixed_Name(fwo, "Wheat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#abc123</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#abc123">https://w3id.org/foodwaste/ontology#abc123</seealso>
    let abc123 = Prefixed_Name(fwo, "abc123") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#abc1234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#NGO</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#abc1234">https://w3id.org/foodwaste/ontology#abc1234</seealso>
    let abc1234 = Prefixed_Name(fwo, "abc1234") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#abc123_Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#abc123_Location">https://w3id.org/foodwaste/ontology#abc123_Location</seealso>
    let abc123_Location = Prefixed_Name(fwo, "abc123_Location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#avoidsAllergen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a user to an allergen they need to avoid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"avoids Allergen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#avoidsAllergen">https://w3id.org/foodwaste/ontology#avoidsAllergen</seealso>
    let avoidsAllergen = Prefixed_Name(fwo, "avoidsAllergen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#claimedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the user who has claimed this donation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"claimed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#claimedBy">https://w3id.org/foodwaste/ontology#claimedBy</seealso>
    let claimedBy = Prefixed_Name(fwo, "claimedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#containsAllergen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that a donation includes a specified allergen."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains Allergen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#containsAllergen">https://w3id.org/foodwaste/ontology#containsAllergen</seealso>
    let containsAllergen = Prefixed_Name(fwo, "containsAllergen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#don12345_Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#don12345_Location">https://w3id.org/foodwaste/ontology#don12345_Location</seealso>
    let don12345_Location = Prefixed_Name(fwo, "don12345_Location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#donatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the user or farmer who made this donation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"donated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#donatedBy">https://w3id.org/foodwaste/ontology#donatedBy</seealso>
    let donatedBy = Prefixed_Name(fwo, "donatedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#donor456_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#donor456_Donor">https://w3id.org/foodwaste/ontology#donor456_Donor</seealso>
    let donor456_Donor = Prefixed_Name(fwo, "donor456_Donor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasDonated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a user to the donations they have made."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has donated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasDonated">https://w3id.org/foodwaste/ontology#hasDonated</seealso>
    let hasDonated = Prefixed_Name(fwo, "hasDonated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasDonationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Associates a donation with its current status."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has donation status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasDonationStatus">https://w3id.org/foodwaste/ontology#hasDonationStatus</seealso>
    let hasDonationStatus = Prefixed_Name(fwo, "hasDonationStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasExpiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes the expiration date of a donated food item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has expiry date"</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasExpiryDate">https://w3id.org/foodwaste/ontology#hasExpiryDate</seealso>
    let hasExpiryDate = Prefixed_Name(fwo, "hasExpiryDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasFoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the type of food in this donation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has food type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasFoodType">https://w3id.org/foodwaste/ontology#hasFoodType</seealso>
    let hasFoodType = Prefixed_Name(fwo, "hasFoodType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasHigherPriorityThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Indicates that one priority level is higher than another."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has higher priority than"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasHigherPriorityThan">https://w3id.org/foodwaste/ontology#hasHigherPriorityThan</seealso>
    let hasHigherPriorityThan =
        Prefixed_Name(fwo, "hasHigherPriorityThan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasLowerPriorityThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that one priority level is lower than another."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has lower priority than"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasLowerPriorityThan">https://w3id.org/foodwaste/ontology#hasLowerPriorityThan</seealso>
    let hasLowerPriorityThan =
        Prefixed_Name(fwo, "hasLowerPriorityThan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasParentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a food type to its more general parent category."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has parent type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasParentType">https://w3id.org/foodwaste/ontology#hasParentType</seealso>
    let hasParentType = Prefixed_Name(fwo, "hasParentType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#hasPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the priority level assigned to a donation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#hasPriority">https://w3id.org/foodwaste/ontology#hasPriority</seealso>
    let hasPriority = Prefixed_Name(fwo, "hasPriority") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#isPreferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a donation is preferred by a particular user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is preferred by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#isPreferredBy">https://w3id.org/foodwaste/ontology#isPreferredBy</seealso>
    let isPreferredBy = Prefixed_Name(fwo, "isPreferredBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#isRejectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a donation type has been rejected by a particular user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is rejected by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#isRejectedBy">https://w3id.org/foodwaste/ontology#isRejectedBy</seealso>
    let isRejectedBy = Prefixed_Name(fwo, "isRejectedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#prefersFoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a user to the types of food they prefer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prefers food type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#prefersFoodType">https://w3id.org/foodwaste/ontology#prefersFoodType</seealso>
    let prefersFoodType = Prefixed_Name(fwo, "prefersFoodType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#rejectsFoodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links user to the food type they reject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rejects food type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#rejectsFoodType">https://w3id.org/foodwaste/ontology#rejectsFoodType</seealso>
    let rejectsFoodType = Prefixed_Name(fwo, "rejectsFoodType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#xyz1234</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#xyz1234">https://w3id.org/foodwaste/ontology#xyz1234</seealso>
    let xyz1234 = Prefixed_Name(fwo, "xyz1234") |> PrefixedName
    /// <summary>
    ///   <para>w3id:foodwaste/ontology#xyzq_Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:foodwaste/ontology#Donor</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology#xyzq_Donor">https://w3id.org/foodwaste/ontology#xyzq_Donor</seealso>
    let xyzq_Donor = Prefixed_Name(fwo, "xyzq_Donor") |> PrefixedName
