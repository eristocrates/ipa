namespace https.w3id.org.foodwaste.ontology.hash

open DoxAletheia

module fwo =
    let _namespace_name = "https://w3id.org/foodwaste/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor"></see>
    /// </summary>
    let _6832c9d165d2ec4756cab2ed_Donor = _prefix "6832c9d165d2ec4756cab2ed_Donor"
    /// <summary>
    /// User is a donor
    /// <see href="https://w3id.org/foodwaste/ontology#Donor"></see></summary>
    let Donor = _prefix "Donor"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#6841464540dd1a066f42dc98_Donor"></see>
    /// </summary>
    let _6841464540dd1a066f42dc98_Donor = _prefix "6841464540dd1a066f42dc98_Donor"
    /// <summary>
    /// An enumeration of substances that may cause allergic reactions.
    /// <see href="https://w3id.org/foodwaste/ontology#Allergen"></see></summary>
    let Allergen = _prefix "Allergen"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Crustacean_shellfish"></see>
    /// </summary>
    let Crustacean_shellfish = _prefix "Crustacean_shellfish"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Eggs"></see>
    /// </summary>
    let Eggs = _prefix "Eggs"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Milk"></see>
    /// </summary>
    let Milk = _prefix "Milk"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Sesame"></see>
    /// </summary>
    let Sesame = _prefix "Sesame"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Soybeans"></see>
    /// </summary>
    let Soybeans = _prefix "Soybeans"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Tree_Nuts"></see>
    /// </summary>
    let Tree_Nuts = _prefix "Tree_Nuts"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Wheat"></see>
    /// </summary>
    let Wheat = _prefix "Wheat"
    /// <summary>
    /// A food donation that is nearing its expiry and should be prioritized.
    /// <see href="https://w3id.org/foodwaste/ontology#AtRiskDonation"></see></summary>
    let AtRiskDonation = _prefix "AtRiskDonation"
    /// <summary>
    /// A record representing a donation of food items.
    /// <see href="https://w3id.org/foodwaste/ontology#FoodDonation"></see></summary>
    let FoodDonation = _prefix "FoodDonation"
    /// <summary>
    /// Specifies the priority level assigned to a donation.
    /// <see href="https://w3id.org/foodwaste/ontology#hasPriority"></see></summary>
    let hasPriority = _prefix "hasPriority"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#High"></see>
    /// </summary>
    let High = _prefix "High"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Available"></see>
    /// </summary>
    let Available = _prefix "Available"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#BakedGoods"></see>
    /// </summary>
    let BakedGoods = _prefix "BakedGoods"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Beverages"></see>
    /// </summary>
    let Beverages = _prefix "Beverages"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Claimed"></see>
    /// </summary>
    let Claimed = _prefix "Claimed"
    /// <summary>
    /// A food donation that has been claimed by a recipient.
    /// <see href="https://w3id.org/foodwaste/ontology#ClaimedDonation"></see></summary>
    let ClaimedDonation = _prefix "ClaimedDonation"
    /// <summary>
    /// Associates a donation with its current status.
    /// <see href="https://w3id.org/foodwaste/ontology#hasDonationStatus"></see></summary>
    let hasDonationStatus = _prefix "hasDonationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#CookedFood"></see>
    /// </summary>
    let CookedFood = _prefix "CookedFood"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Dairy"></see>
    /// </summary>
    let Dairy = _prefix "Dairy"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#DairyProducts"></see>
    /// </summary>
    let DairyProducts = _prefix "DairyProducts"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Delivered"></see>
    /// </summary>
    let Delivered = _prefix "Delivered"
    /// <summary>
    /// An enumeration of possible statuses for a food donation (e.g., At Risk, Claimed).
    /// <see href="https://w3id.org/foodwaste/ontology#DonationStatus"></see></summary>
    let DonationStatus = _prefix "DonationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Diabetic_Sweets"></see>
    /// </summary>
    let Diabetic_Sweets = _prefix "Diabetic_Sweets"
    /// <summary>
    /// An individual or organization interacting with the food wastage system.
    /// <see href="https://w3id.org/foodwaste/ontology#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// User is an NGO
    /// <see href="https://w3id.org/foodwaste/ontology#NGO"></see></summary>
    let NGO = _prefix "NGO"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Donor1"></see>
    /// </summary>
    let Donor1 = _prefix "Donor1"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Donor10"></see>
    /// </summary>
    let Donor10 = _prefix "Donor10"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Donor_xyzq"></see>
    /// </summary>
    let Donor_xyzq = _prefix "Donor_xyzq"
    /// <summary>
    /// Denotes that a donation includes a specified allergen.
    /// <see href="https://w3id.org/foodwaste/ontology#containsAllergen"></see></summary>
    let containsAllergen = _prefix "containsAllergen"
    /// <summary>
    /// An enumeration of categories of food (e.g., fruits, vegetables, dairy)
    /// <see href="https://w3id.org/foodwaste/ontology#FoodType"></see></summary>
    let FoodType = _prefix "FoodType"
    /// <summary>
    /// Specifies the type of food in this donation.
    /// <see href="https://w3id.org/foodwaste/ontology#hasFoodType"></see></summary>
    let hasFoodType = _prefix "hasFoodType"
    /// <summary>
    /// An ordered enumeration indicating the urgency or importance of a donation.
    /// <see href="https://w3id.org/foodwaste/ontology#Priority"></see></summary>
    let Priority = _prefix "Priority"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#FreshProduce"></see>
    /// </summary>
    let FreshProduce = _prefix "FreshProduce"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Grains_and_Cerals"></see>
    /// </summary>
    let Grains_and_Cerals = _prefix "Grains_and_Cerals"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Meat"></see>
    /// </summary>
    let Meat = _prefix "Meat"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Non_Diabetic_Sweets"></see>
    /// </summary>
    let Non_Diabetic_Sweets = _prefix "Non_Diabetic_Sweets"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Processed_and_Packaged"></see>
    /// </summary>
    let Processed_and_Packaged = _prefix "Processed_and_Packaged"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Sea_Food"></see>
    /// </summary>
    let Sea_Food = _prefix "Sea_Food"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Snacks"></see>
    /// </summary>
    let Snacks = _prefix "Snacks"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Spices_and_Condiments"></see>
    /// </summary>
    let Spices_and_Condiments = _prefix "Spices_and_Condiments"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Staple_Foods"></see>
    /// </summary>
    let Staple_Foods = _prefix "Staple_Foods"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Fruit"></see>
    /// </summary>
    let Fruit = _prefix "Fruit"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Gluten"></see>
    /// </summary>
    let Gluten = _prefix "Gluten"
    /// <summary>
    /// Indicates that one priority level is higher than another.
    /// <see href="https://w3id.org/foodwaste/ontology#hasHigherPriorityThan"></see></summary>
    let hasHigherPriorityThan = _prefix "hasHigherPriorityThan"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Medium"></see>
    /// </summary>
    let Medium = _prefix "Medium"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Low"></see>
    /// </summary>
    let Low = _prefix "Low"
    /// <summary>
    /// Links a user to an allergen they need to avoid
    /// <see href="https://w3id.org/foodwaste/ontology#avoidsAllergen"></see></summary>
    let avoidsAllergen = _prefix "avoidsAllergen"
    /// <summary>
    /// Links a user to the types of food they prefer.
    /// <see href="https://w3id.org/foodwaste/ontology#prefersFoodType"></see></summary>
    let prefersFoodType = _prefix "prefersFoodType"
    /// <summary>
    /// links user to the food type they reject
    /// <see href="https://w3id.org/foodwaste/ontology#rejectsFoodType"></see></summary>
    let rejectsFoodType = _prefix "rejectsFoodType"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#NGO1"></see>
    /// </summary>
    let NGO1 = _prefix "NGO1"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#NGO2"></see>
    /// </summary>
    let NGO2 = _prefix "NGO2"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Peanut"></see>
    /// </summary>
    let Peanut = _prefix "Peanut"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Peanuts"></see>
    /// </summary>
    let Peanuts = _prefix "Peanuts"
    /// <summary>
    /// A donation marked as preferred by a user based on their preferences.
    /// <see href="https://w3id.org/foodwaste/ontology#PreferredDonation"></see></summary>
    let PreferredDonation = _prefix "PreferredDonation"
    /// <summary>
    /// A donation from a source flagged as trusted.
    /// <see href="https://w3id.org/foodwaste/ontology#TrustedDonation"></see></summary>
    let TrustedDonation = _prefix "TrustedDonation"
    /// <summary>
    /// A donation requiring immediate pickup or distribution
    /// <see href="https://w3id.org/foodwaste/ontology#UrgentDonation"></see></summary>
    let UrgentDonation = _prefix "UrgentDonation"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#abc123"></see>
    /// </summary>
    let abc123 = _prefix "abc123"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#abc1234"></see>
    /// </summary>
    let abc1234 = _prefix "abc1234"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#abc123_Location"></see>
    /// </summary>
    let abc123_Location = _prefix "abc123_Location"
    /// <summary>
    /// Indicates the user who has claimed this donation.
    /// <see href="https://w3id.org/foodwaste/ontology#claimedBy"></see></summary>
    let claimedBy = _prefix "claimedBy"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#don12345_Location"></see>
    /// </summary>
    let don12345_Location = _prefix "don12345_Location"
    /// <summary>
    /// Indicates the user or farmer who made this donation.
    /// <see href="https://w3id.org/foodwaste/ontology#donatedBy"></see></summary>
    let donatedBy = _prefix "donatedBy"
    /// <summary>
    /// Links a user to the donations they have made.
    /// <see href="https://w3id.org/foodwaste/ontology#hasDonated"></see></summary>
    let hasDonated = _prefix "hasDonated"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#donor456_Donor"></see>
    /// </summary>
    let donor456_Donor = _prefix "donor456_Donor"
    /// <summary>
    /// Denotes the expiration date of a donated food item
    /// <see href="https://w3id.org/foodwaste/ontology#hasExpiryDate"></see></summary>
    let hasExpiryDate = _prefix "hasExpiryDate"
    /// <summary>
    /// Indicates that one priority level is lower than another.
    /// <see href="https://w3id.org/foodwaste/ontology#hasLowerPriorityThan"></see></summary>
    let hasLowerPriorityThan = _prefix "hasLowerPriorityThan"
    /// <summary>
    /// Relates a food type to its more general parent category.
    /// <see href="https://w3id.org/foodwaste/ontology#hasParentType"></see></summary>
    let hasParentType = _prefix "hasParentType"
    /// <summary>
    /// Indicates that a donation is preferred by a particular user.
    /// <see href="https://w3id.org/foodwaste/ontology#isPreferredBy"></see></summary>
    let isPreferredBy = _prefix "isPreferredBy"
    /// <summary>
    /// Indicates that a donation type has been rejected by a particular user.
    /// <see href="https://w3id.org/foodwaste/ontology#isRejectedBy"></see></summary>
    let isRejectedBy = _prefix "isRejectedBy"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#xyz1234"></see>
    /// </summary>
    let xyz1234 = _prefix "xyz1234"
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#xyzq_Donor"></see>
    /// </summary>
    let xyzq_Donor = _prefix "xyzq_Donor"
